namespace WinFormsAppRegex
{
    partial class Form3
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGetAllKeys = new System.Windows.Forms.Button();
            this.lstKeys = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 27);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(813, 31);
            this.txtUrl.TabIndex = 0;
            // 
            // btnGetAllKeys
            // 
            this.btnGetAllKeys.Location = new System.Drawing.Point(831, 25);
            this.btnGetAllKeys.Name = "btnGetAllKeys";
            this.btnGetAllKeys.Size = new System.Drawing.Size(112, 34);
            this.btnGetAllKeys.TabIndex = 1;
            this.btnGetAllKeys.Text = "Get Keys";
            this.btnGetAllKeys.UseVisualStyleBackColor = true;
            this.btnGetAllKeys.Click += new System.EventHandler(this.btnGetAllKeys_Click);
            // 
            // lstKeys
            // 
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.ItemHeight = 25;
            this.lstKeys.Location = new System.Drawing.Point(12, 64);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.Size = new System.Drawing.Size(931, 604);
            this.lstKeys.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 686);
            this.Controls.Add(this.lstKeys);
            this.Controls.Add(this.btnGetAllKeys);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUrl;
        private Button btnGetAllKeys;
        private ListBox lstKeys;
    }
}