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
    public partial class AuthForm : Form
    {
        static public AuthForm MainForm;
        public AuthForm()
        {
            InitializeComponent();
            MainForm = this;
        }

        bool captchaFlag = false;

        private void refrashButton_Click(object sender, EventArgs e)
        {

            captchaFlag = !captchaFlag;

            var picture = LTpictureBox.Image;
            LTpictureBox.Image = RTpictureBox.Image;
            RTpictureBox.Image = picture;

            picture = LBpictureBox.Image;
            LBpictureBox.Image = RBpictureBox.Image;
            RBpictureBox.Image = picture;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (captchaFlag == false)
            {
                MessageBox.Show("Капча собрана непраивльно", 
                    "Ошибка входа", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            if(loginTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!", 
                    "Ошибка входа", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            var user = DemoProbnikkEntities.GetContext().Users
                .FirstOrDefault(u => u.Login == loginTextBox.Text && u.Password == passwordTextBox.Text);
            if(user == null)
            {
                MessageBox.Show("Вы ввели неверный логин или пароль",
                    "Ошибка входа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if(user.IsBlocked == true)
            {
                MessageBox.Show("Ваш аккаунт заблокирован, обратитесь к администратору",
                    "Ошибка входа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Вы успешно авторизовались",
                    "Успешная авторизация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            if(user.RoleId == 1)
            {
                AdminForm adminForm = new AdminForm();
                this.Visible = false;
                adminForm.Show();
            }
            else
                MessageBox.Show(user.ToString(),
                    "Информация о пользователе",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
