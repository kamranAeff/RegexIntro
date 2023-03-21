namespace WinFormsAppRegex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtHexColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnColorValidate = new System.Windows.Forms.Button();
            this.btnTestMathc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnMobilePhoneCheck = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(11, 62);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(305, 31);
            this.txtTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saati daxil edin:";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(11, 111);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(135, 34);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Yoxla";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtHexColor
            // 
            this.txtHexColor.Location = new System.Drawing.Point(11, 238);
            this.txtHexColor.Name = "txtHexColor";
            this.txtHexColor.Size = new System.Drawing.Size(305, 31);
            this.txtHexColor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reng kodunu daxil edin:";
            // 
            // btnColorValidate
            // 
            this.btnColorValidate.Location = new System.Drawing.Point(11, 287);
            this.btnColorValidate.Name = "btnColorValidate";
            this.btnColorValidate.Size = new System.Drawing.Size(304, 34);
            this.btnColorValidate.TabIndex = 2;
            this.btnColorValidate.Text = "Yoxla";
            this.btnColorValidate.UseVisualStyleBackColor = true;
            this.btnColorValidate.Click += new System.EventHandler(this.btnColorValidate_Click);
            // 
            // btnTestMathc
            // 
            this.btnTestMathc.Location = new System.Drawing.Point(180, 111);
            this.btnTestMathc.Name = "btnTestMathc";
            this.btnTestMathc.Size = new System.Drawing.Size(135, 34);
            this.btnTestMathc.TabIndex = 2;
            this.btnTestMathc.Text = "Yoxla";
            this.btnTestMathc.UseVisualStyleBackColor = true;
            this.btnTestMathc.Click += new System.EventHandler(this.btnTestMathc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(542, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mobile Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(542, 62);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(323, 31);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Text = "+99477-123-44-67";
            // 
            // btnMobilePhoneCheck
            // 
            this.btnMobilePhoneCheck.Location = new System.Drawing.Point(542, 111);
            this.btnMobilePhoneCheck.Name = "btnMobilePhoneCheck";
            this.btnMobilePhoneCheck.Size = new System.Drawing.Size(323, 34);
            this.btnMobilePhoneCheck.TabIndex = 5;
            this.btnMobilePhoneCheck.Text = "Telefon nomresini yoxla";
            this.btnMobilePhoneCheck.UseVisualStyleBackColor = true;
            this.btnMobilePhoneCheck.Click += new System.EventHandler(this.btnMobilePhoneCheck_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(542, 168);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(323, 153);
            this.txtResponse.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 426);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnMobilePhoneCheck);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnColorValidate);
            this.Controls.Add(this.btnTestMathc);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHexColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTime;
        private Label label1;
        private Button btnValidate;
        private TextBox txtHexColor;
        private Label label2;
        private Button btnColorValidate;
        private Button btnTestMathc;
        private Label label3;
        private TextBox txtPhone;
        private Button btnMobilePhoneCheck;
        private TextBox txtResponse;
    }
}