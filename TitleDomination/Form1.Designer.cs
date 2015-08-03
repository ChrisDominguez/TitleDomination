namespace TitleDomination
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
            this.titleInput = new System.Windows.Forms.TextBox();
            this.titleOutput = new System.Windows.Forms.TextBox();
            this.dominatedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleInput
            // 
            this.titleInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleInput.Location = new System.Drawing.Point(13, 13);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(484, 20);
            this.titleInput.TabIndex = 0;
            this.titleInput.TextChanged += new System.EventHandler(this.titleInput_TextChanged);
            // 
            // titleOutput
            // 
            this.titleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleOutput.Location = new System.Drawing.Point(13, 40);
            this.titleOutput.Name = "titleOutput";
            this.titleOutput.Size = new System.Drawing.Size(484, 20);
            this.titleOutput.TabIndex = 1;
            // 
            // dominatedLabel
            // 
            this.dominatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dominatedLabel.AutoSize = true;
            this.dominatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dominatedLabel.Location = new System.Drawing.Point(9, 72);
            this.dominatedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dominatedLabel.Name = "dominatedLabel";
            this.dominatedLabel.Size = new System.Drawing.Size(0, 55);
            this.dominatedLabel.TabIndex = 2;
            this.dominatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 148);
            this.Controls.Add(this.dominatedLabel);
            this.Controls.Add(this.titleOutput);
            this.Controls.Add(this.titleInput);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 187);
            this.MinimumSize = new System.Drawing.Size(525, 187);
            this.Name = "Form1";
            this.Text = "Title Domination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox titleOutput;
        private System.Windows.Forms.Label dominatedLabel;
    }
}

