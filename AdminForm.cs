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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            //refrashUserList();
        }

        void refrashUserList()
        {
            userListBox.Items.Clear();
            userListBox.Items.AddRange(
                DemoProbnikkEntities.GetContext().Users.ToArray());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AuthForm.MainForm.Visible = true;
            this.Close();
        }

        private void changeStatusBlockedButton_Click(object sender, EventArgs e)
        {
            if (userListBox.SelectedItems != null)
            {
                var user = userListBox.SelectedItem as Users;
                user.IsBlocked = !user.IsBlocked;
                DemoProbnikkEntities.GetContext().SaveChanges();
                refrashUserList();
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            var user = userListBox.SelectedItem as Users;
            DemoProbnikkEntities.GetContext().Users.Remove(user);
            DemoProbnikkEntities.GetContext().SaveChanges();
            refrashUserList();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm();
            addNewUserForm.ShowDialog();
            refrashUserList();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthForm.MainForm.Close();
        }
    }
}
