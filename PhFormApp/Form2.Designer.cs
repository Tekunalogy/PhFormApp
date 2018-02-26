namespace PhFormApp
{
    partial class PhProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhProcess));
            this.ColorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColorLabel
            // 
            this.ColorLabel.Location = new System.Drawing.Point(327, 270);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(154, 75);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Color of Solution";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.ColorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhProcess";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PhProcess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ColorLabel;
    }
}