using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PotencjometrArduino
{
    public partial class AwaitForm : Form
    {
        //        SerialPort openedPort;

        bool isClosed = true;

        public AwaitForm()
        {
            InitializeComponent();

/*            openedPort = new SerialPort();
            openedPort = arduinoPort;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal new bool FormClosing()
        {
            return isClosed;
        }

    }
}
