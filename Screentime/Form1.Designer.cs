namespace Screentime
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
            this.AppUsageListviewControl = new System.Windows.Forms.ListView();
            this.AppUsageDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppUsageListviewControl
            // 
            this.AppUsageListviewControl.HideSelection = false;
            this.AppUsageListviewControl.Location = new System.Drawing.Point(12, 141);
            this.AppUsageListviewControl.Name = "AppUsageListviewControl";
            this.AppUsageListviewControl.Size = new System.Drawing.Size(296, 466);
            this.AppUsageListviewControl.TabIndex = 0;
            this.AppUsageListviewControl.UseCompatibleStateImageBehavior = false;
            this.AppUsageListviewControl.View = System.Windows.Forms.View.Details;
            // 
            // AppUsageDescriptionLabel
            // 
            this.AppUsageDescriptionLabel.Location = new System.Drawing.Point(12, 28);
            this.AppUsageDescriptionLabel.Name = "AppUsageDescriptionLabel";
            this.AppUsageDescriptionLabel.Size = new System.Drawing.Size(296, 110);
            this.AppUsageDescriptionLabel.TabIndex = 1;
            this.AppUsageDescriptionLabel.Text = "AppUsageDescriptionLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 619);
            this.Controls.Add(this.AppUsageDescriptionLabel);
            this.Controls.Add(this.AppUsageListviewControl);
            this.Name = "Form1";
            this.Text = "Screentime Tracker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView AppUsageListviewControl;
        private System.Windows.Forms.Label AppUsageDescriptionLabel;
    }
}

