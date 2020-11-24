namespace PotencjometrArduino
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.comBox = new System.Windows.Forms.ComboBox();
            this.lCOM = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lConnection = new System.Windows.Forms.Label();
            this.connectionText = new System.Windows.Forms.Label();
            this.progressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPotentiometer = new System.Windows.Forms.Label();
            this.labelPotentiometerVoltage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).BeginInit();
            this.SuspendLayout();
            // 
            // comBox
            // 
            this.comBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(67, 11);
            this.comBox.Margin = new System.Windows.Forms.Padding(4);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(104, 27);
            this.comBox.TabIndex = 0;
            this.comBox.SelectedIndexChanged += new System.EventHandler(this.comBox_SelectedIndexChanged);
            // 
            // lCOM
            // 
            this.lCOM.AutoSize = true;
            this.lCOM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCOM.Location = new System.Drawing.Point(9, 14);
            this.lCOM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCOM.Name = "lCOM";
            this.lCOM.Size = new System.Drawing.Size(50, 19);
            this.lCOM.TabIndex = 1;
            this.lCOM.Text = "COM :";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.Control;
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectButton.FlatAppearance.BorderSize = 20;
            this.connectButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.Location = new System.Drawing.Point(213, 11);
            this.connectButton.Margin = new System.Windows.Forms.Padding(5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(86, 27);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 152);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Maximum = 255;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(330, 51);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // lConnection
            // 
            this.lConnection.AutoSize = true;
            this.lConnection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lConnection.Location = new System.Drawing.Point(95, 62);
            this.lConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConnection.Name = "lConnection";
            this.lConnection.Size = new System.Drawing.Size(90, 19);
            this.lConnection.TabIndex = 6;
            this.lConnection.Text = "Connection: ";
            // 
            // connectionText
            // 
            this.connectionText.AutoSize = true;
            this.connectionText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionText.ForeColor = System.Drawing.Color.LimeGreen;
            this.connectionText.Location = new System.Drawing.Point(193, 62);
            this.connectionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionText.Name = "connectionText";
            this.connectionText.Size = new System.Drawing.Size(13, 19);
            this.connectionText.TabIndex = 7;
            this.connectionText.Text = " ";
            // 
            // progressChart
            // 
            chartArea2.Name = "ChartArea1";
            this.progressChart.ChartAreas.Add(chartArea2);
            this.progressChart.Location = new System.Drawing.Point(348, 11);
            this.progressChart.Name = "progressChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.Name = "Potentiometer";
            this.progressChart.Series.Add(series2);
            this.progressChart.Size = new System.Drawing.Size(446, 192);
            this.progressChart.TabIndex = 8;
            this.progressChart.Text = "VoltageChart";
            title2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "Title1";
            title2.Text = "Voltage";
            this.progressChart.Titles.Add(title2);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPotentiometer
            // 
            this.labelPotentiometer.AutoSize = true;
            this.labelPotentiometer.Location = new System.Drawing.Point(63, 90);
            this.labelPotentiometer.Name = "labelPotentiometer";
            this.labelPotentiometer.Size = new System.Drawing.Size(200, 19);
            this.labelPotentiometer.TabIndex = 9;
            this.labelPotentiometer.Text = "Potentiometer Value [B] : 000";
            // 
            // labelPotentiometerVoltage
            // 
            this.labelPotentiometerVoltage.AutoSize = true;
            this.labelPotentiometerVoltage.Location = new System.Drawing.Point(63, 118);
            this.labelPotentiometerVoltage.Name = "labelPotentiometerVoltage";
            this.labelPotentiometerVoltage.Size = new System.Drawing.Size(204, 19);
            this.labelPotentiometerVoltage.TabIndex = 10;
            this.labelPotentiometerVoltage.Text = "Potentiometer Value [V] : 0.00";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(806, 215);
            this.Controls.Add(this.labelPotentiometerVoltage);
            this.Controls.Add(this.labelPotentiometer);
            this.Controls.Add(this.progressChart);
            this.Controls.Add(this.connectionText);
            this.Controls.Add(this.lConnection);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.lCOM);
            this.Controls.Add(this.comBox);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(497, 221);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Arduino Potencjometr";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort arduinoPort;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Label lCOM;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lConnection;
        private System.Windows.Forms.Label connectionText;
        private System.Windows.Forms.DataVisualization.Charting.Chart progressChart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPotentiometer;
        private System.Windows.Forms.Label labelPotentiometerVoltage;
    }
}

