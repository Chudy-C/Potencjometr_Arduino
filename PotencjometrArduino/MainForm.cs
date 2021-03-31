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

namespace PotencjometrArduino
{
    public partial class MainForm : Form
    {
        bool isConnected = false;
        bool updateData = false;
        String[] ports;
        SerialPort port;
        bool isValueReturned = false;
        string returnedValue = "";
        bool isFormClosed;

        string percentage, volts, byteValue;
        double voltageValue;

        private Stopwatch stopWatch;

        //int milis, seconds, minutes = 0;
        TimeSpan ts;
        public MainForm()
        {
            InitializeComponent();
            getAvailablePorts();

            foreach(string port in ports)
            {
                comBox.Items.Add(port);
                if(ports[0] != null)
                {
                    comBox.SelectedItem = ports[0];
                }
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            progressChart.ChartAreas[0].AxisY.Minimum = 0;
            progressChart.ChartAreas[0].AxisY.Maximum = 5;
            progressChart.Series[0].Points.AddY(3);
            progressChart.Series[0].IsValueShownAsLabel = false;
            progressChart.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;

            progressChart.Series[0].BorderWidth = 3;
            progressChart.Series[0].Color = Color.IndianRed;

            stopWatch = new Stopwatch();

            startButton.Enabled = false;
            stopButton.Enabled = false;
            resetTimerButton.Enabled = false;
            patientBox.Enabled = false;

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
            port = new SerialPort(selectedPort, 9600);
            port.Open();
            port.Write("Start");

            connectionText.Text = "CONNECTED";
            connectionText.ForeColor = Color.LimeGreen;
            connectionText.Visible = true;

            connectButton.Text = "Disconnect";

            patientBox.Enabled = true;

            disableControls();
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("STOP");
            port.Close();
            connectionText.Text = "DISCONNECTED";
            connectionText.ForeColor = Color.IndianRed;

            connectButton.Text = "Connect";

            patientBox.SelectedIndex = 0;
            patientBox.Enabled = false;

            milisecondsText.Text = "00";
            secondsText.Text = "00";
            minutesText.Text = "00";

            startButton.Enabled = false;
            stopButton.Enabled = false;
            resetTimerButton.Enabled = false;

            patientBox.SelectedIndex = -1;
            patientBox.Enabled = false;

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

            milisecondsText.Text = "00";
            secondsText.Text = "00";
            minutesText.Text = "00";

            startButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;
            patientBox.Enabled = false;

            port.Write("START\n");
            isValueReturned = false;

            while (isValueReturned == false || isFormClosed == false)
            {
                if (returnedValue != "SENDING\n")
                {
                    returnedValue = port.ReadLine();
                }
                else
                {
                    port.WriteLine("OK");
                    stopWatch.Start();
                    measurementTimer.Start();
                    isValueReturned = true;
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            measurementTimer.Stop();
            stopWatch.Stop();
            resetTimerButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void resetTimerButton_Click(object sender, EventArgs e)
        {
/*            milis = 0;
            seconds = 0;
            minutes = 0;*/
            milisecondsText.Text = "00";
            secondsText.Text = "00";
            minutesText.Text = "00";

            startButton.Enabled = true;
            patientBox.Enabled = true;
            resetTimerButton.Enabled = false;

            stopWatch.Reset();
        }

        private void measurementTimer_Tick(object sender, EventArgs e)
        {

            ts = stopWatch.Elapsed;
            if(ts.Milliseconds.ToString().Length == 1)
            {
                milisecondsText.Text = "0"+(ts.Milliseconds / 10).ToString();
            }
            else milisecondsText.Text = (ts.Milliseconds/10).ToString();
            if(ts.Seconds.ToString().Length == 1)
            {
                secondsText.Text = "0"+ts.Seconds.ToString();
            }
            else secondsText.Text = ts.Seconds.ToString();
            if (ts.Minutes.ToString().Length ==1)
            {
                minutesText.Text = "0"+ ts.Minutes.ToString();
            }
            else minutesText.Text = ts.Minutes.ToString();
        }

        private void patientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;

        }


        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataIn = port.ReadTo("\n");
            Data_Parsing(dataIn);
            this.BeginInvoke(new EventHandler(Show_data));
        }

        private void Show_data(object sender, EventArgs e)
        {
            if (updateData)
            {
                lByteValue.Text = string.Format("Potentiometer Value [Byte] : {0}", byteValue);
                lVoltageValue.Text = string.Format("Potentiometer Value[V] :  {0}", volts);
                lPercentage.Text = float.Parse(percentage).ToString();
                progressBar.Value = Int32.Parse(percentage);


                progressChart.Series[0].Points.Add(voltageValue);
                progressChart.ChartAreas[0].AxisY.Maximum = 5;
                if (progressChart.Series[0].Points.Count == 20) progressChart.Series[0].Points.RemoveAt(0);
            }
        }

        private void Data_Parsing(string inputData)
        {
            sbyte indexOf_startDataCharacter = (sbyte)inputData.IndexOf("@");
            sbyte indexOfB = (sbyte)inputData.IndexOf("B");
            sbyte indexOfV = (sbyte)inputData.IndexOf("V");
            sbyte indexOfp = (sbyte)inputData.IndexOf("p");

            if (indexOf_startDataCharacter != -1 && indexOfB != -1 && indexOfV != -1 && indexOfp != -1)
            {
                try
                {
                    string str_byte = inputData.Substring(indexOf_startDataCharacter + 1, (indexOfB - indexOf_startDataCharacter) - 1);
                    string str_volts = inputData.Substring(indexOfB + 1, (indexOfV - indexOfB) - 1);
                    string str_p = inputData.Substring(indexOfV + 1, (indexOfp - indexOfV) - 1);

                    percentage = str_p;
                    volts = str_volts;
                    byteValue = str_byte;

                    voltageValue = Convert.ToDouble(str_volts);

                    updateData = true;
                }
                catch (Exception)
                {

                }
            }
            else updateData = false;
        }



        /*        private void timer1_Tick(object sender, EventArgs e)
                {
                    var serialRead = port.ReadLine();
                    labelPotentiometer.Text = "Potentiometer Value [Byte] : " + serialRead;
                    var i = Convert.ToByte(serialRead);
                    var voltageValueDouble = Convert.ToInt32(i) * 0.0196;
                    var voltageValue = Convert.ToInt32(i);
                    progressBar.Value = voltageValue;

                    labelPotentiometerVoltage.Text = "Potentiometer Value [V] : " + Math.Round(voltageValueDouble,2).ToString();

                    progressChart.Series[0].Points.Add(voltageValueDouble);
                    progressChart.ChartAreas[0].AxisY.Maximum = 5;
                    if (progressChart.Series[0].Points.Count == 20) progressChart.Series[0].Points.RemoveAt(0);
                }*/

    }
}
