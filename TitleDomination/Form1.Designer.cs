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
            this.SuspendLayout();
            // 
            // titleInput
            // 
            this.titleInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleInput.Location = new System.Drawing.Point(13, 13);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(701, 20);
            this.titleInput.TabIndex = 0;
            this.titleInput.TextChanged += new System.EventHandler(this.titleInput_TextChanged);
            // 
            // titleOutput
            // 
            this.titleOutput.Location = new System.Drawing.Point(13, 40);
            this.titleOutput.Name = "titleOutput";
            this.titleOutput.Size = new System.Drawing.Size(701, 20);
            this.titleOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 347);
            this.Controls.Add(this.titleOutput);
            this.Controls.Add(this.titleInput);
            this.Name = "Form1";
            this.Text = "Title Domination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox titleOutput;
    }
}

