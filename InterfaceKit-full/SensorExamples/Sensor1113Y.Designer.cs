namespace InterfaceKit_full.SensorExamples
{
    partial class Sensor1113Y
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.analogInputLabel0 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // analogInputLabel0
            // 
            this.analogInputLabel0.AutoSize = true;
            this.analogInputLabel0.Location = new System.Drawing.Point(3, 10);
            this.analogInputLabel0.Name = "analogInputLabel0";
            this.analogInputLabel0.Size = new System.Drawing.Size(35, 13);
            this.analogInputLabel0.TabIndex = 52;
            this.analogInputLabel0.Text = "Y Val:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 7);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 51;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(269, 3);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 59);
            this.trackBar1.TabIndex = 53;
            this.trackBar1.TickFrequency = 500;
            // 
            // Sensor1113Y
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.analogInputLabel0);
            this.Controls.Add(this.textBox1);
            this.Name = "Sensor1113Y";
            this.Size = new System.Drawing.Size(317, 65);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label analogInputLabel0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}
