namespace DemoProbnikk
{
    partial class AddNewUserForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secondnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.createButton = new System.Windows.Forms.Button();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(102, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // secondnameTextBox
            // 
            this.secondnameTextBox.Location = new System.Drawing.Point(102, 88);
            this.secondnameTextBox.Name = "secondnameTextBox";
            this.secondnameTextBox.Size = new System.Drawing.Size(185, 20);
            this.secondnameTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(102, 138);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(185, 20);
            this.surnameTextBox.TabIndex = 7;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(102, 185);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(185, 20);
            this.loginTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(102, 235);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(185, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Роль";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.roleComboBox.Location = new System.Drawing.Point(102, 284);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(185, 21);
            this.roleComboBox.TabIndex = 11;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(113, 367);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(106, 32);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(DemoProbnikk.Roles);
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.secondnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(349, 489);
            this.MinimumSize = new System.Drawing.Size(349, 489);
            this.Name = "AddNewUserForm";
            this.Text = "Окно создания пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox secondnameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.Button createButton;
    }
}