namespace XMLWeather
{
    partial class CurrentScreen
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
            this.cityOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.iconOutput = new System.Windows.Forms.Label();
            this.maxMinOutput = new System.Windows.Forms.Label();
            this.windInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(81, 104);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(252, 56);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.tempLabel.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.tempLabel.Location = new System.Drawing.Point(11, 300);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(395, 201);
            this.tempLabel.TabIndex = 28;
            this.tempLabel.Text = "*C";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(169, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 80);
            this.label3.TabIndex = 40;
            this.label3.Text = "Current";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(169, 581);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 80);
            this.label1.TabIndex = 41;
            this.label1.Text = "Forecast";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.Black;
            this.dateOutput.Location = new System.Drawing.Point(389, 104);
            this.dateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(318, 56);
            this.dateOutput.TabIndex = 42;
            this.dateOutput.Text = "Date";
            this.dateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconOutput
            // 
            this.iconOutput.BackColor = System.Drawing.Color.Transparent;
            this.iconOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconOutput.ForeColor = System.Drawing.Color.White;
            this.iconOutput.Location = new System.Drawing.Point(388, 198);
            this.iconOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iconOutput.Name = "iconOutput";
            this.iconOutput.Size = new System.Drawing.Size(319, 305);
            this.iconOutput.TabIndex = 44;
            // 
            // maxMinOutput
            // 
            this.maxMinOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxMinOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxMinOutput.ForeColor = System.Drawing.Color.Black;
            this.maxMinOutput.Location = new System.Drawing.Point(20, 519);
            this.maxMinOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxMinOutput.Name = "maxMinOutput";
            this.maxMinOutput.Size = new System.Drawing.Size(697, 62);
            this.maxMinOutput.TabIndex = 45;
            this.maxMinOutput.Text = "max/min";
            this.maxMinOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windInfo
            // 
            this.windInfo.BackColor = System.Drawing.Color.Transparent;
            this.windInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windInfo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.windInfo.Location = new System.Drawing.Point(20, 178);
            this.windInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windInfo.Name = "windInfo";
            this.windInfo.Size = new System.Drawing.Size(367, 130);
            this.windInfo.TabIndex = 46;
            this.windInfo.Text = "wind";
            this.windInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.iconOutput);
            this.Controls.Add(this.windInfo);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.maxMinOutput);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(750, 678);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label iconOutput;
        private System.Windows.Forms.Label maxMinOutput;
        private System.Windows.Forms.Label windInfo;
    }
}
