namespace DemoProbnikk
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LTpictureBox = new System.Windows.Forms.PictureBox();
            this.LBpictureBox = new System.Windows.Forms.PictureBox();
            this.RTpictureBox = new System.Windows.Forms.PictureBox();
            this.RBpictureBox = new System.Windows.Forms.PictureBox();
            this.refrashButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LTpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(117, 67);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(136, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(117, 125);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(136, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // LTpictureBox
            // 
            this.LTpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LTpictureBox.Image")));
            this.LTpictureBox.Location = new System.Drawing.Point(117, 226);
            this.LTpictureBox.Name = "LTpictureBox";
            this.LTpictureBox.Size = new System.Drawing.Size(60, 60);
            this.LTpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LTpictureBox.TabIndex = 4;
            this.LTpictureBox.TabStop = false;
            // 
            // LBpictureBox
            // 
            this.LBpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LBpictureBox.Image")));
            this.LBpictureBox.Location = new System.Drawing.Point(117, 292);
            this.LBpictureBox.Name = "LBpictureBox";
            this.LBpictureBox.Size = new System.Drawing.Size(60, 60);
            this.LBpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LBpictureBox.TabIndex = 5;
            this.LBpictureBox.TabStop = false;
            // 
            // RTpictureBox
            // 
            this.RTpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RTpictureBox.Image")));
            this.RTpictureBox.Location = new System.Drawing.Point(183, 226);
            this.RTpictureBox.Name = "RTpictureBox";
            this.RTpictureBox.Size = new System.Drawing.Size(60, 60);
            this.RTpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RTpictureBox.TabIndex = 6;
            this.RTpictureBox.TabStop = false;
            // 
            // RBpictureBox
            // 
            this.RBpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RBpictureBox.Image")));
            this.RBpictureBox.Location = new System.Drawing.Point(183, 292);
            this.RBpictureBox.Name = "RBpictureBox";
            this.RBpictureBox.Size = new System.Drawing.Size(60, 60);
            this.RBpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RBpictureBox.TabIndex = 7;
            this.RBpictureBox.TabStop = false;
            // 
            // refrashButton
            // 
            this.refrashButton.Location = new System.Drawing.Point(117, 188);
            this.refrashButton.Name = "refrashButton";
            this.refrashButton.Size = new System.Drawing.Size(126, 32);
            this.refrashButton.TabIndex = 8;
            this.refrashButton.Text = "Поменять местами";
            this.refrashButton.UseVisualStyleBackColor = true;
            this.refrashButton.Click += new System.EventHandler(this.refrashButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(117, 376);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(126, 38);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.refrashButton);
            this.Controls.Add(this.RBpictureBox);
            this.Controls.Add(this.RTpictureBox);
            this.Controls.Add(this.LBpictureBox);
            this.Controls.Add(this.LTpictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.MaximumSize = new System.Drawing.Size(374, 489);
            this.MinimumSize = new System.Drawing.Size(374, 489);
            this.Name = "AuthForm";
            this.Text = "Окно авторизации";
            ((System.ComponentModel.ISupportInitialize)(this.LTpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox LTpictureBox;
        private System.Windows.Forms.PictureBox LBpictureBox;
        private System.Windows.Forms.PictureBox RTpictureBox;
        private System.Windows.Forms.PictureBox RBpictureBox;
        private System.Windows.Forms.Button refrashButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
    }
}