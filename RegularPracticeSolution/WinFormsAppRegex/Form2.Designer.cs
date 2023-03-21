namespace WinFormsAppRegex
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnGetAllNumbers = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 12);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(677, 460);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = resources.GetString("txtContent.Text");
            // 
            // btnGetAllNumbers
            // 
            this.btnGetAllNumbers.Location = new System.Drawing.Point(448, 478);
            this.btnGetAllNumbers.Name = "btnGetAllNumbers";
            this.btnGetAllNumbers.Size = new System.Drawing.Size(241, 59);
            this.btnGetAllNumbers.TabIndex = 1;
            this.btnGetAllNumbers.Text = "Butun nomreleri sec";
            this.btnGetAllNumbers.UseVisualStyleBackColor = true;
            this.btnGetAllNumbers.Click += new System.EventHandler(this.btnGetAllNumbers_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 25;
            this.lstNumbers.Location = new System.Drawing.Point(695, 12);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(271, 529);
            this.lstNumbers.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnGetAllNumbers);
            this.Controls.Add(this.txtContent);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtContent;
        private Button btnGetAllNumbers;
        private ListBox lstNumbers;
    }
}