using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace NomadJournalApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //using (var context = new NomadJournalContext())
            //{
            //    context.Admins.Add(new Admin {
            //        Login = "a",
            //        Password = "a"
            //    });
            //    context.Users.Add(new User
            //    {
            //        Login = "b",
            //        Password = "b"
            //    });
            //    context.SaveChanges();
            //}
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            using (var context = new NomadJournalContext())
            {
                if (!string.IsNullOrWhiteSpace(loginTextBox.Text))
                {
                    if (!string.IsNullOrWhiteSpace(passwordTextBox.Text))
                    {
                        bool isFound = false;
                        foreach (var user in context.Users)
                        {
                            if (user.Login == loginTextBox.Text && user.Password == passwordTextBox.Text)
                            {
                                isFound = true;
                                Logged(user);
                            }
                        }
                        foreach (var admin in context.Admins)
                        {
                            if (admin.Login == loginTextBox.Text && admin.Password == passwordTextBox.Text)
                            {
                                isFound = true;
                                Logged(admin);
                            }
                        }
                        if (!isFound)
                        {
                            MessageBox.Show("Пользователь не найден");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите пароль");
                    }
                }
                else
                {
                    MessageBox.Show("Введите логин");
                } 
            }
        }

        private void Logged(User user)
        {
            Clear();
            enteredLoginLabel.Text = user.Login;
            fullNameLabel.Text = user.FullName;
            subscriptionMontsLabel.Text = "Вы подписаны на " + Convert.ToString(user.SubscriptionMonths) + "\nмесяцев";

            
        }

        private void Logged(Admin admin)
        {
            Clear();

            loadReport.Visible = true;
            loadReport.Enabled = true;

            addIssueButton.Visible = true;
            addIssueButton.Enabled = true;

            sendIssueButton.Visible = true;
            sendIssueButton.Enabled = true;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            enterLabel.Visible = false;

            loginLabel.Visible = false;
            passwordLabel.Visible = false;

            loginTextBox.Visible = false;
            loginTextBox.Enabled = false;

            passwordTextBox.Visible = false;
            passwordTextBox.Enabled = false;

            authorizationButton.Visible = false;
            authorizationButton.Enabled = false;

            registrationLabel.Visible = false;
            registrationLabel.Enabled = false;

            registrationButton.Visible = false;
            registrationButton.Enabled = false;
        }

        private void addIssueButton_Click(object sender, EventArgs e)
        {

        }

        private void sendIssueButton_Click(object sender, EventArgs e)
        {

        }

        private void loadReport_Click(object sender, EventArgs e)
        {

        }
    }
}
