using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProbnikk
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text == "" || 
                passwordTextBox.Text == "" || 
                nameTextBox.Text == "" || 
                secondnameTextBox.Text == "" || 
                surnameTextBox.Text == "" || 
                roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Не все поля заполнены!",
                    "Ошибка заполнения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var user = DemoProbnikkEntities.GetContext().Users
                .FirstOrDefault(u => u.Login == loginTextBox.Text);

            if (user != null) 
            {
                MessageBox.Show("Пользователь с таким логином уже существует",
                    "Ошибка создания",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Users users = new Users()
            {
                Name = nameTextBox.Text,
                Secondname = secondnameTextBox.Text,
                Surname = surnameTextBox.Text,
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
                IsBlocked = false,
                RoleId = roleComboBox.SelectedItem.ToString() == "Пользователь"?2 : 1,
            };
            DemoProbnikkEntities.GetContext().Users.Add(users);
            DemoProbnikkEntities.GetContext().SaveChanges();
            MessageBox.Show("Пользователь успешно добавлен",
                    "Успешное добавление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            this.Close();
        }
    }
}
