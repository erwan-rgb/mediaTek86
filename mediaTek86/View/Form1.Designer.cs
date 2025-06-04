
namespace mediaTek86
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
            btnConnexion = new Button();
            txtLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPwd = new TextBox();
            SuspendLayout();
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(202, 132);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(94, 29);
            btnConnexion.TabIndex = 0;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(68, 36);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(228, 27);
            txtLogin.TabIndex = 1;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Login :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 4;
            label2.Text = "Pwd : ";
            label2.Click += label2_Click;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(68, 78);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(228, 27);
            txtPwd.TabIndex = 5;
            txtPwd.TextChanged += txtPwd_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 195);
            Controls.Add(txtPwd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Controls.Add(btnConnexion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnConnexion;
        private TextBox txtLogin;
        private Label label1;
        private Label label2;
        private TextBox txtPwd;
    }
}
