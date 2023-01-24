namespace Weather_Application
{
    partial class ForecastUC
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
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labDT = new System.Windows.Forms.Label();
            this.labMainWeahter = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(3, 3);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(91, 77);
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // labDT
            // 
            this.labDT.AutoSize = true;
            this.labDT.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDT.Location = new System.Drawing.Point(118, 3);
            this.labDT.Name = "labDT";
            this.labDT.Size = new System.Drawing.Size(71, 24);
            this.labDT.TabIndex = 1;
            this.labDT.Text = "Sunday";
            // 
            // labMainWeahter
            // 
            this.labMainWeahter.AutoSize = true;
            this.labMainWeahter.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainWeahter.Location = new System.Drawing.Point(118, 27);
            this.labMainWeahter.Name = "labMainWeahter";
            this.labMainWeahter.Size = new System.Drawing.Size(53, 24);
            this.labMainWeahter.TabIndex = 2;
            this.labMainWeahter.Text = "Clear";
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherDescription.Location = new System.Drawing.Point(118, 56);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(104, 24);
            this.labWeatherDescription.TabIndex = 3;
            this.labWeatherDescription.Text = "Description";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labMainWeahter);
            this.Controls.Add(this.labDT);
            this.Controls.Add(this.picWeatherIcon);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(342, 94);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labDT;
        public System.Windows.Forms.Label labMainWeahter;
        public System.Windows.Forms.Label labWeatherDescription;
    }
}
