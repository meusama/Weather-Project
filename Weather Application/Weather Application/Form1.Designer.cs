namespace Weather_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(162, 61);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(231, 39);
            this.TBCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "City:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(460, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.White;
            this.labCondition.Location = new System.Drawing.Point(624, 61);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(0, 33);
            this.labCondition.TabIndex = 4;
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(69, 163);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(136, 33);
            this.labDetails.TabIndex = 5;
            this.labDetails.Text = "Condition:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sunrise:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(180, 226);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(62, 33);
            this.labSunrise.TabIndex = 7;
            this.labSunrise.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 33);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sunset:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(180, 302);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(62, 33);
            this.labSunset.TabIndex = 9;
            this.labSunset.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(608, 226);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(62, 33);
            this.labPressure.TabIndex = 13;
            this.labPressure.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(443, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pressure:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(608, 163);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(62, 33);
            this.labWindSpeed.TabIndex = 11;
            this.labWindSpeed.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(443, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wind Speed:";
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(75, 372);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(811, 157);
            this.FLP.TabIndex = 15;
            this.FLP.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 560);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCity);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel FLP;
    }
}

