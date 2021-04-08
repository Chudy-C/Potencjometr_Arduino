using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace PotencjometrArduino
{
    public partial class MainForm : Form
    {
        bool isConnected = false;
        String[] ports;


        string fileDate;
        uint probka;
        string percentage, volts, byteValue;
        double voltageValue;
        int percentageInt;
        public string timeStamp, milis, seconds, minutes;
        TimeSpan ts;
        Stopwatch stopWatch;

        public MainForm()
        {
            InitializeComponent();
            getAvailablePorts();

            foreach (string port in ports)
            {
                comBox.Items.Add(port);
                if (ports[0] != null)
                {
                    comBox.SelectedItem = ports[0];
                }
            }
            string day = DateTime.Now.Day.ToString("00");
            string month = DateTime.Now.Month.ToString("00");
            string year = DateTime.Now.Year.ToString("00");
            string hour = DateTime.Now.Hour.ToString("00");
            string minute = DateTime.Now.Minute.ToString("00");
            fileDate = day + "-" + month + "-" + year + "_" + hour + minute;
            probka = 0;

            stopWatch = new Stopwatch();
            measurementTimer.Start();
            measurementTimer.Tick += measurementTimer_Tick;
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            progressChart.ChartAreas[0].AxisY.Minimum = 0;
            progressChart.ChartAreas[0].AxisY.Maximum = 2;
            progressChart.Series[0].IsValueShownAsLabel = false;
            progressChart.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;

            progressChart.Series[0].BorderWidth = 3;
            progressChart.Series[0].Color = Color.IndianRed;


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduinoPort.IsOpen) arduinoPort.Close();
        }

        private void getAvailablePorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!isConnected) connectToArduino();
            else disconnectFromArduino();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comBox.GetItemText(comBox.SelectedItem);
            arduinoPort = new SerialPort(selectedPort, 9600);
            arduinoPort.Open();
            arduinoPort.Write("Start");

            arduinoPort.DataReceived += port_DataReceived;

            connectionText.Text = "CONNECTED";
            connectionText.ForeColor = Color.LimeGreen;
            connectionText.Visible = true;

            connectButton.Text = "Disconnect";
            disableControls();

            //arduinoTimer.Interval = 100;
            //arduinoTimer.Start();
        }

        private void disconnectFromArduino()
        {
            //arduinoTimer.Stop();

            isConnected = false;
            arduinoPort.Write("STOP");
            arduinoPort.Close();
            connectionText.Text = "DISCONNECTED";
            connectionText.ForeColor = Color.IndianRed;

            connectButton.Text = "Connect";


            lByteValue.Text = "Potentiometer Value [Byte] : 000";
            lVoltageValue.Text = "Potentiometer Value[V] : 000";

            enableControls();
        }

        private void enableControls()
        {
            comBox.Enabled = true;
            progressBar.Enabled = true;

        }
        private void disableControls()
        {
            comBox.Enabled = false;
            progressBar.Enabled = false;
            progressBar.Value = 0;
        }


        private string StringToCSV(string input)
        {
            probka++;

            input = input.Remove(0, 1);
            input = input.Replace('N', ';');
            input = input.Replace('B', ';');
            input = input.Replace('V', ';');
            input = input.Replace('P', ';');
            input = input + timeStamp;
            return input;
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*todo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
             * !!!!! TU NASTĄPIŁA ZMIANA KODU !!!!!
             * !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
             */
            string dataIn = arduinoPort.ReadTo("\n");
            if (!stopWatch.IsRunning) stopWatch.Start();
            if (dataIn == "KONIEC\r")
            {
                stopWatch.Stop();
                measurementTimer.Stop();

                string message = "Czy chcesz dokonać ponownego pomiaru?";
                DialogResult result = MessageBox.Show(message, caption: "Zamykam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else Environment.Exit(0);
            }
            else
            {
                if (measurementTimer.Enabled && dataIn.StartsWith("@"))
                {
                    Data_Parsing(dataIn);
                    this.BeginInvoke(new EventHandler(Show_data));

                    string path = String.Format(@"D:\5_STUDIA\inzynierka\C#_program\TxtFiles\{0}.txt", fileDate);
                    if (!File.Exists(path))
                    {
                        File.Create(path).Dispose();

                        using (TextWriter tw = new StreamWriter(path))
                        {
                            tw.WriteLine("N;Byte;Voltage;Percentage;TimeStamp");
                            tw.WriteLine(StringToCSV(dataIn));

                        }

                    }
                    else if (File.Exists(path))
                    {
                        using (TextWriter tw = File.AppendText(path))
                        {
                            tw.WriteLine(StringToCSV(dataIn));
                        }
                    }
                }

            }
        }

        private void Show_data(object sender, EventArgs e)
        {

            /* x : Timer label 
                - Dodać label do wyświetlania timeStamp
                - jeżeli dataReciver otrzyma "KONIEC" -> wyłącz timer oraz StopWatch
                - bool sprawdzający czy Timer zaczął działać
                    = true jeżeli przyjął dane typu: @201N1024B0.48V100P
                    else = false;
             */

            lByteValue.Text = string.Format("Potentiometer Value [Byte] : {0}", byteValue);
            lVoltageValue.Text = string.Format("Potentiometer Value[V] :  {0}", volts);
            lPercentage.Text = percentage;
            progressBar.Value = percentageInt;



            progressChart.Series[0].Points.Add(voltageValue);
            progressChart.ChartAreas[0].AxisY.Maximum = 2;
            if (progressChart.Series[0].Points.Count == 20) progressChart.Series[0].Points.RemoveAt(0);
        }

        private void Data_Parsing(string inputData)
        {

            //@201N1024B0.48V100P
            sbyte indexOf_startDataCharacter = (sbyte)inputData.IndexOf('@');
            sbyte indexOfN = (sbyte)inputData.IndexOf('N');
            sbyte indexOfB = (sbyte)inputData.IndexOf('B');
            sbyte indexOfV = (sbyte)inputData.IndexOf('V');
            sbyte indexOfP = (sbyte)inputData.IndexOf('P');

            if (indexOf_startDataCharacter != -1 && indexOfN != -1 && indexOfB != -1 && indexOfV != -1 && indexOfP != -1)
            {
                try
                {
                    string str_probka = inputData.Substring(indexOf_startDataCharacter + 1, (indexOfN - indexOf_startDataCharacter) - 1);
                    string str_byte = inputData.Substring(indexOfN + 1, (indexOfB - indexOfN) - 1);
                    string str_volts = inputData.Substring(indexOfB + 1, (indexOfV - indexOfB) - 1);
                    string str_p = inputData.Substring(indexOfV + 1, (indexOfP - indexOfV) - 1);

                    percentage = str_p;
                    volts = str_volts;
                    byteValue = str_byte;

                    /*int.TryParse(percentage, out percentageInt);*/

                    float percentageFloat = float.Parse(percentage, CultureInfo.InvariantCulture.NumberFormat);

                    percentageInt = (int)Math.Round(percentageFloat);
                    if (percentageInt > 100) percentageInt = 100;
                    if (percentageInt < 0) percentageInt = 0;

                    percentage = percentageInt.ToString();

                    voltageValue = double.Parse(str_volts, System.Globalization.CultureInfo.InvariantCulture);

                }
                catch (Exception)
                {

                }
            }
        }

        private void textBoxReceiver_TextChanged(object sender, EventArgs e)
        {
            textBoxReceiver.SelectionStart = textBoxReceiver.Text.Length;
            textBoxReceiver.ScrollToCaret();
        }

        private void measurementTimer_Tick(object sender, EventArgs e)
        {
            ts = stopWatch.Elapsed;
            if (ts.Milliseconds.ToString().Length == 1)
            {
                milis = "0" + (ts.Milliseconds / 10).ToString();
            }
            else milis = (ts.Milliseconds / 10).ToString();
            if (ts.Seconds.ToString().Length == 1)
            {
                seconds = "0" + ts.Seconds.ToString();
            }
            else seconds = ts.Seconds.ToString();
            if (ts.Minutes.ToString().Length == 1)
            {
                minutes = "0" + ts.Minutes.ToString();
            }
            else minutes = ts.Minutes.ToString();

            timeStamp = minutes + ":" + seconds + "." + milis;

            Invoke(new SetLogDelegate(this.SetLogText), timeStamp);
        }

        private delegate void SetLogDelegate(string time);
        private void SetLogText(string strText)
        {
            labelTimer.Text = strText;
        }

    }
}
