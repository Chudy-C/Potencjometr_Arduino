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

namespace PotencjometrArduino
{
    public partial class MainForm : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;

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
            progressChart.ChartAreas[0].AxisY.Maximum = 5.5;
            progressChart.Series[0].Points.AddY(3);
            progressChart.Series[0].IsValueShownAsLabel = false;
            progressChart.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;

            progressChart.Series[0].BorderWidth = 3;
            progressChart.Series[0].Color = Color.IndianRed;
        }

        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            disableControls();

            timer1.Start();
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("STOP");
            port.Close();
            connectionText.Text = "DISCONNECTED";
            connectionText.ForeColor = Color.IndianRed;

            connectButton.Text = "Connect";

            enableControls();
            timer1.Stop();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            var serialRead = port.ReadLine();
            labelPotentiometer.Text = "Potentiometer Value [B] : " + serialRead;
            var i = Convert.ToByte(serialRead);
            var voltageValueDouble = Convert.ToInt32(i) * 0.0196;
            var voltageValue = Convert.ToInt32(i);
            progressBar.Value = voltageValue;

            labelPotentiometerVoltage.Text = "Potentiometer Value [V] : " + Math.Round(voltageValueDouble,2).ToString();
            
            progressChart.Series[0].Points.Add(voltageValueDouble);
            if (progressChart.Series[0].Points.Count == 20) progressChart.Series[0].Points.RemoveAt(0);
            progressChart.ChartAreas[0].AxisY.Maximum = 5.5;
        }
    }
}
