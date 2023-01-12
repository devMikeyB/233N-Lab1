using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MichaelBaldwinLab1
{
    public class User
    {
        public User()
        {
            this.Name = "Unknown";
            this.Password = "Default";
            this.userImage= null;
            this.userImageLocation = String.Empty;
            this.userImage = null;
        }

        public User(string name, string password, string imageLocation = null)
        {
            this.Name = name;
            this.Password = password;
            this.userImageLocation = imageLocation;
            try
            {
                this.userImage = Image.FromFile(imageLocation);
            }
            catch { Console.WriteLine($"Unable to generate image for {this.Name}"); }
        }

        public string Name { get; }
        public string Password { get; }

        public string userImageLocation { get; set; }
        public Image userImage { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}