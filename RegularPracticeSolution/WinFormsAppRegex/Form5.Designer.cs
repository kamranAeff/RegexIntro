namespace WinFormsAppRegex
{
    partial class Form5
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnGetWords = new System.Windows.Forms.Button();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 12);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(582, 323);
            this.txtContent.TabIndex = 0;
            // 
            // btnGetWords
            // 
            this.btnGetWords.Location = new System.Drawing.Point(402, 341);
            this.btnGetWords.Name = "btnGetWords";
            this.btnGetWords.Size = new System.Drawing.Size(192, 51);
            this.btnGetWords.TabIndex = 1;
            this.btnGetWords.Text = "Get Words";
            this.btnGetWords.UseVisualStyleBackColor = true;
            this.btnGetWords.Click += new System.EventHandler(this.btnGetWords_Click);
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 25;
            this.lstWords.Location = new System.Drawing.Point(600, 12);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(259, 379);
            this.lstWords.TabIndex = 2;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 413);
            this.Controls.Add(this.lstWords);
            this.Controls.Add(this.btnGetWords);
            this.Controls.Add(this.txtContent);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtContent;
        private Button btnGetWords;
        private ListBox lstWords;
    }
}