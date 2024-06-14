namespace Group4_Invidiual.Data.Forms
{
    partial class Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NUserTxt = new System.Windows.Forms.TextBox();
            this.NPassTxt = new System.Windows.Forms.TextBox();
            this.CPassText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LoginBackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 105);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // NUserTxt
            // 
            this.NUserTxt.Location = new System.Drawing.Point(263, 143);
            this.NUserTxt.Multiline = true;
            this.NUserTxt.Name = "NUserTxt";
            this.NUserTxt.Size = new System.Drawing.Size(358, 30);
            this.NUserTxt.TabIndex = 1;
            this.NUserTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NPassTxt
            // 
            this.NPassTxt.Location = new System.Drawing.Point(263, 232);
            this.NPassTxt.Multiline = true;
            this.NPassTxt.Name = "NPassTxt";
            this.NPassTxt.Size = new System.Drawing.Size(358, 30);
            this.NPassTxt.TabIndex = 2;
            this.NPassTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CPassText
            // 
            this.CPassText.Location = new System.Drawing.Point(263, 329);
            this.CPassText.Multiline = true;
            this.CPassText.Name = "CPassText";
            this.CPassText.Size = new System.Drawing.Size(358, 30);
            this.CPassText.TabIndex = 3;
            this.CPassText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Username :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password :";
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserBtn.Location = new System.Drawing.Point(816, 433);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(137, 48);
            this.CreateUserBtn.TabIndex = 7;
            this.CreateUserBtn.Text = "Create Account";
            this.CreateUserBtn.UseVisualStyleBackColor = true;
            this.CreateUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(658, 433);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(137, 48);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // LoginBackBtn
            // 
            this.LoginBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBackBtn.Location = new System.Drawing.Point(502, 433);
            this.LoginBackBtn.Name = "LoginBackBtn";
            this.LoginBackBtn.Size = new System.Drawing.Size(137, 48);
            this.LoginBackBtn.TabIndex = 9;
            this.LoginBackBtn.Text = "<< Go Back";
            this.LoginBackBtn.UseVisualStyleBackColor = true;
            this.LoginBackBtn.Click += new System.EventHandler(this.LoginBackBtn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 502);
            this.Controls.Add(this.LoginBackBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CreateUserBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CPassText);
            this.Controls.Add(this.NPassTxt);
            this.Controls.Add(this.NUserTxt);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NPassTxt;
        private System.Windows.Forms.TextBox CPassText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateUserBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button LoginBackBtn;
        private System.Windows.Forms.TextBox NUserTxt;
    }
}