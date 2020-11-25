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
            this.connectButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lConnection = new System.Windows.Forms.Label();
            this.connectionText = new System.Windows.Forms.Label();
            this.progressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.arduinoTimer = new System.Windows.Forms.Timer(this.components);
            this.labelPotentiometer = new System.Windows.Forms.Label();
            this.labelPotentiometerVoltage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getPatientButton = new System.Windows.Forms.Button();
            this.clearPatientButton = new System.Windows.Forms.Button();
            this.patientLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colonL = new System.Windows.Forms.Label();
            this.colonR = new System.Windows.Forms.Label();
            this.milisecondsText = new System.Windows.Forms.Label();
            this.secondsText = new System.Windows.Forms.Label();
            this.minutesText = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lMinutes = new System.Windows.Forms.Label();
            this.lSeconds = new System.Windows.Forms.Label();
            this.lNano = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetTimerButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.measurementTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comBox
            // 
            this.comBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(13, 27);
            this.comBox.Margin = new System.Windows.Forms.Padding(4);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(104, 27);
            this.comBox.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.Control;
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectButton.FlatAppearance.BorderSize = 20;
            this.connectButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.Location = new System.Drawing.Point(14, 63);
            this.connectButton.Margin = new System.Windows.Forms.Padding(5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(103, 27);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 330);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Maximum = 255;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(465, 30);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // lConnection
            // 
            this.lConnection.AutoSize = true;
            this.lConnection.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lConnection.Location = new System.Drawing.Point(138, 30);
            this.lConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConnection.Name = "lConnection";
            this.lConnection.Size = new System.Drawing.Size(60, 19);
            this.lConnection.TabIndex = 6;
            this.lConnection.Text = "STATUS:";
            // 
            // connectionText
            // 
            this.connectionText.AutoSize = true;
            this.connectionText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionText.ForeColor = System.Drawing.Color.LimeGreen;
            this.connectionText.Location = new System.Drawing.Point(138, 63);
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
            this.progressChart.Location = new System.Drawing.Point(17, 26);
            this.progressChart.Name = "progressChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.Name = "Potentiometer";
            this.progressChart.Series.Add(series2);
            this.progressChart.Size = new System.Drawing.Size(465, 229);
            this.progressChart.TabIndex = 8;
            this.progressChart.Text = "VoltageChart";
            title2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.Name = "Title1";
            title2.Text = "Voltage";
            this.progressChart.Titles.Add(title2);
            // 
            // arduinoTimer
            // 
            this.arduinoTimer.Interval = 10;
            this.arduinoTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPotentiometer
            // 
            this.labelPotentiometer.AutoSize = true;
            this.labelPotentiometer.Location = new System.Drawing.Point(155, 267);
            this.labelPotentiometer.Name = "labelPotentiometer";
            this.labelPotentiometer.Size = new System.Drawing.Size(220, 19);
            this.labelPotentiometer.TabIndex = 9;
            this.labelPotentiometer.Text = "Potentiometer Value [Byte] : 000";
            // 
            // labelPotentiometerVoltage
            // 
            this.labelPotentiometerVoltage.AutoSize = true;
            this.labelPotentiometerVoltage.Location = new System.Drawing.Point(165, 295);
            this.labelPotentiometerVoltage.Name = "labelPotentiometerVoltage";
            this.labelPotentiometerVoltage.Size = new System.Drawing.Size(204, 19);
            this.labelPotentiometerVoltage.TabIndex = 10;
            this.labelPotentiometerVoltage.Text = "Potentiometer Value [V] : 0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBox);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.lConnection);
            this.groupBox1.Controls.Add(this.connectionText);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 101);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.patientLabel);
            this.groupBox2.Controls.Add(this.clearPatientButton);
            this.groupBox2.Controls.Add(this.getPatientButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 102);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient";
            // 
            // getPatientButton
            // 
            this.getPatientButton.BackColor = System.Drawing.SystemColors.Control;
            this.getPatientButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.getPatientButton.FlatAppearance.BorderSize = 20;
            this.getPatientButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.getPatientButton.Location = new System.Drawing.Point(8, 67);
            this.getPatientButton.Margin = new System.Windows.Forms.Padding(5);
            this.getPatientButton.Name = "getPatientButton";
            this.getPatientButton.Size = new System.Drawing.Size(103, 27);
            this.getPatientButton.TabIndex = 5;
            this.getPatientButton.Text = "Get Patient";
            this.getPatientButton.UseVisualStyleBackColor = false;
            // 
            // clearPatientButton
            // 
            this.clearPatientButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearPatientButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearPatientButton.FlatAppearance.BorderSize = 20;
            this.clearPatientButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearPatientButton.Location = new System.Drawing.Point(223, 67);
            this.clearPatientButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearPatientButton.Name = "clearPatientButton";
            this.clearPatientButton.Size = new System.Drawing.Size(103, 27);
            this.clearPatientButton.TabIndex = 6;
            this.clearPatientButton.Text = "Reset";
            this.clearPatientButton.UseVisualStyleBackColor = false;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.patientLabel.Location = new System.Drawing.Point(10, 33);
            this.patientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(13, 19);
            this.patientLabel.TabIndex = 8;
            this.patientLabel.Text = " ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressChart);
            this.groupBox3.Controls.Add(this.labelPotentiometer);
            this.groupBox3.Controls.Add(this.labelPotentiometerVoltage);
            this.groupBox3.Controls.Add(this.progressBar);
            this.groupBox3.Location = new System.Drawing.Point(365, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 369);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Measurment";
            // 
            // colonL
            // 
            this.colonL.AutoSize = true;
            this.colonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colonL.Location = new System.Drawing.Point(181, 64);
            this.colonL.Name = "colonL";
            this.colonL.Size = new System.Drawing.Size(26, 37);
            this.colonL.TabIndex = 17;
            this.colonL.Text = ":";
            // 
            // colonR
            // 
            this.colonR.AutoSize = true;
            this.colonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colonR.Location = new System.Drawing.Point(252, 65);
            this.colonR.Name = "colonR";
            this.colonR.Size = new System.Drawing.Size(26, 37);
            this.colonR.TabIndex = 18;
            this.colonR.Text = ":";
            // 
            // milisecondsText
            // 
            this.milisecondsText.AutoSize = true;
            this.milisecondsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.milisecondsText.Location = new System.Drawing.Point(274, 65);
            this.milisecondsText.Name = "milisecondsText";
            this.milisecondsText.Size = new System.Drawing.Size(53, 38);
            this.milisecondsText.TabIndex = 14;
            this.milisecondsText.Text = "00";
            // 
            // secondsText
            // 
            this.secondsText.AutoSize = true;
            this.secondsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsText.Location = new System.Drawing.Point(203, 65);
            this.secondsText.Name = "secondsText";
            this.secondsText.Size = new System.Drawing.Size(53, 38);
            this.secondsText.TabIndex = 15;
            this.secondsText.Text = "00";
            // 
            // minutesText
            // 
            this.minutesText.AutoSize = true;
            this.minutesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesText.Location = new System.Drawing.Point(135, 64);
            this.minutesText.Name = "minutesText";
            this.minutesText.Size = new System.Drawing.Size(53, 38);
            this.minutesText.TabIndex = 16;
            this.minutesText.Text = "00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resetTimerButton);
            this.groupBox4.Controls.Add(this.stopButton);
            this.groupBox4.Controls.Add(this.startButton);
            this.groupBox4.Controls.Add(this.lNano);
            this.groupBox4.Controls.Add(this.lSeconds);
            this.groupBox4.Controls.Add(this.lMinutes);
            this.groupBox4.Controls.Add(this.secondsText);
            this.groupBox4.Controls.Add(this.colonL);
            this.groupBox4.Controls.Add(this.minutesText);
            this.groupBox4.Controls.Add(this.colonR);
            this.groupBox4.Controls.Add(this.milisecondsText);
            this.groupBox4.Location = new System.Drawing.Point(13, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 138);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "START / STOP";
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMinutes.Location = new System.Drawing.Point(127, 48);
            this.lMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(61, 19);
            this.lMinutes.TabIndex = 20;
            this.lMinutes.Text = "minutes";
            // 
            // lSeconds
            // 
            this.lSeconds.AutoSize = true;
            this.lSeconds.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSeconds.Location = new System.Drawing.Point(197, 48);
            this.lSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSeconds.Name = "lSeconds";
            this.lSeconds.Size = new System.Drawing.Size(62, 19);
            this.lSeconds.TabIndex = 21;
            this.lSeconds.Text = "seconds";
            // 
            // lNano
            // 
            this.lNano.AutoSize = true;
            this.lNano.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNano.Location = new System.Drawing.Point(277, 48);
            this.lNano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNano.Name = "lNano";
            this.lNano.Size = new System.Drawing.Size(41, 19);
            this.lNano.TabIndex = 22;
            this.lNano.Text = "nano";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.FlatAppearance.BorderSize = 20;
            this.startButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(12, 28);
            this.startButton.Margin = new System.Windows.Forms.Padding(5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 27);
            this.startButton.TabIndex = 23;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.SystemColors.Control;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopButton.FlatAppearance.BorderSize = 20;
            this.stopButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.Location = new System.Drawing.Point(13, 65);
            this.stopButton.Margin = new System.Windows.Forms.Padding(5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(103, 27);
            this.stopButton.TabIndex = 24;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // resetTimerButton
            // 
            this.resetTimerButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetTimerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetTimerButton.FlatAppearance.BorderSize = 20;
            this.resetTimerButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetTimerButton.Location = new System.Drawing.Point(13, 102);
            this.resetTimerButton.Margin = new System.Windows.Forms.Padding(5);
            this.resetTimerButton.Name = "resetTimerButton";
            this.resetTimerButton.Size = new System.Drawing.Size(103, 27);
            this.resetTimerButton.TabIndex = 25;
            this.resetTimerButton.Text = "Reset";
            this.resetTimerButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PotencjometrArduino.Properties.Resources.wnt_logo_92x92;
            this.pictureBox1.InitialImage = global::PotencjometrArduino.Properties.Resources.wnt_logo_92x92;
            this.pictureBox1.Location = new System.Drawing.Point(254, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 92);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(873, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(889, 438);
            this.MinimumSize = new System.Drawing.Size(889, 438);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Arduino Potencjometr";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort arduinoPort;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lConnection;
        private System.Windows.Forms.Label connectionText;
        private System.Windows.Forms.DataVisualization.Charting.Chart progressChart;
        private System.Windows.Forms.Timer arduinoTimer;
        private System.Windows.Forms.Label labelPotentiometer;
        private System.Windows.Forms.Label labelPotentiometerVoltage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Button clearPatientButton;
        private System.Windows.Forms.Button getPatientButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label colonL;
        private System.Windows.Forms.Label colonR;
        private System.Windows.Forms.Label milisecondsText;
        private System.Windows.Forms.Label secondsText;
        private System.Windows.Forms.Label minutesText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lNano;
        private System.Windows.Forms.Label lSeconds;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Button resetTimerButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer measurementTimer;
    }
}

