namespace DemoProbnikk
{
    partial class AdminForm
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
            this.userListBox = new System.Windows.Forms.ListBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.changeStatusBlockedButton = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(12, 12);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(562, 420);
            this.userListBox.TabIndex = 0;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(580, 12);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(208, 40);
            this.createUserButton.TabIndex = 1;
            this.createUserButton.Text = "Создать пользователя";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(580, 58);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(208, 40);
            this.editUserButton.TabIndex = 2;
            this.editUserButton.Text = "Редактировать пользователя";
            this.editUserButton.UseVisualStyleBackColor = true;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(580, 104);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(208, 40);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Удалить пользователя";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(580, 392);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(208, 40);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Выйти";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // changeStatusBlockedButton
            // 
            this.changeStatusBlockedButton.Location = new System.Drawing.Point(580, 150);
            this.changeStatusBlockedButton.Name = "changeStatusBlockedButton";
            this.changeStatusBlockedButton.Size = new System.Drawing.Size(208, 40);
            this.changeStatusBlockedButton.TabIndex = 5;
            this.changeStatusBlockedButton.Text = "Изменить статус блокироваки";
            this.changeStatusBlockedButton.UseVisualStyleBackColor = true;
            this.changeStatusBlockedButton.Click += new System.EventHandler(this.changeStatusBlockedButton_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(DemoProbnikk.Users);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeStatusBlockedButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.userListBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AdminForm";
            this.Text = "Окно администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button changeStatusBlockedButton;
        private System.Windows.Forms.BindingSource usersBindingSource;
    }
}