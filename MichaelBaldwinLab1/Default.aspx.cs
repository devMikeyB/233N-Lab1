using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MichaelBaldwinLab1
{
    public partial class Default : System.Web.UI.Page
    {
        //Init Array of users.
        internal User[] UserList = new User[3];
        //Create users using User class.

        User User0 = new User("Cat", "111");
        User User1 = new User("Tiger", "222");
        User User2 = new User("Dog", "333");

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                User0.userImageLocation = "Assets/cat.jpg";
                User1.userImageLocation = "Assets/tiger.jpg";
                User2.userImageLocation = "Assets/dog.png";

            }
            catch (Exception ex) { Console.WriteLine("Error: ", ex); }



            UserList[0] = User0;
            UserList[1] = User1;
            UserList[2] = User2;

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            foreach (User user in UserList)
            {
                if (user.Name.ToLower() == userTextBox.Text.ToLower() && user.Password == passwordTextBox.Text)
                {
                    welcomeLabel.Text = $"Welcome, {user.Name}!";
                    userImage.ImageUrl = user.userImageLocation;

                    MessageBox.Show($"{user.Name} has successfully logged in.");
                    nextButton.Visible = true;
                    userImage.Visible = true;
                    infoCheckBox.Visible = true;
                    welcomeLabel.Visible = true;
                    return;
                }
            }
            MessageBox.Show("Invalid login information. Are you sure you entered everything correctly?");

        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            userTextBox.Text= string.Empty;
            passwordTextBox.Text= string.Empty;

            nextButton.Visible = false;
            userImage.Visible = false;
            infoCheckBox.Visible = false;
            pageInfoLabel.Visible = false;
            welcomeLabel.Visible = false;
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("States.aspx");
        }

        protected void infoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!infoCheckBox.Checked)
            {
                pageInfoLabel.Visible = false;
            } else
            {
                pageInfoLabel.Visible = true;
                pageInfoLabel.BackColor = Color.CadetBlue;
            }
        }
    }
}