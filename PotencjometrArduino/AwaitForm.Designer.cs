
namespace PotencjometrArduino
{
    partial class AwaitForm
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
            this.lAwaitInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lAwaitInfo
            // 
            this.lAwaitInfo.AutoSize = true;
            this.lAwaitInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAwaitInfo.Location = new System.Drawing.Point(12, 9);
            this.lAwaitInfo.Name = "lAwaitInfo";
            this.lAwaitInfo.Size = new System.Drawing.Size(408, 24);
            this.lAwaitInfo.TabIndex = 1;
            this.lAwaitInfo.Text = "Oczekiwanie na wciśnięcie zielonego przycisku";
            // 
            // AwaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 46);
            this.ControlBox = false;
            this.Controls.Add(this.lAwaitInfo);
            this.Name = "AwaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oczekiwanie na reakcję";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lAwaitInfo;
    }
}