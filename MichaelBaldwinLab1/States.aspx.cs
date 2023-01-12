using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MichaelBaldwinLab1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void stateRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.Print(stateRadioButtonList.SelectedItem.Value);
            switch (stateRadioButtonList.SelectedItem.Text)
            {
                case "State of Oregon":
                    try
                    {
                        stateImage.Visible = true;
                        stateImage.ToolTip = "State of Oregon";
                        stateImage.ImageUrl = "Assets/Oregon.png";
                        stateInfoLabel.Text = "The State of Oregon has a varried climate depending on the area.\n The state of Oregon is known as the Beaver State.";
                        stateInfoLabel.BackColor = Color.Green;
                        stateRadioButtonList.BackColor = Color.Green;
                        stateInfoLabel.Visible = true;

                    }
                    catch (Exception ex){ MessageBox.Show(ex.ToString()); }
                    break;
                case "State of Colorado":
                    try
                    {
                        stateImage.Visible = true;
                        stateImage.ToolTip = "State of Colorado";
                        stateImage.ImageUrl = "Assets/Colorado.png";
                        stateInfoLabel.Text = "The State of Colorado has a cool and dry climate. \nThe State of Colorado is known as the Centennial State.";
                        stateInfoLabel.BackColor = Color.CadetBlue;
                        stateRadioButtonList.BackColor = Color.CadetBlue;
                        stateInfoLabel.Visible = true;

                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    break;
                case "State of Utah":
                    try
                    {
                        stateImage.Visible = true;
                        stateImage.ToolTip = "State of Utah";
                        stateImage.ImageUrl = "Assets/Utah.png";
                        stateInfoLabel.Text = "The State of Utah has a harsh and varried climate. \nThe state of Utah is known as the Beehive State.";
                        stateInfoLabel.BackColor = Color.OrangeRed;
                        stateRadioButtonList.BackColor = Color.OrangeRed;
                        stateInfoLabel.Visible = true;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    break;
                case "Clear":
                    stateImage.Visible = false;
                    stateImage.ImageUrl = string.Empty;
                    stateRadioButtonList.BackColor= Color.Empty;
                    stateInfoLabel.Visible = false;


                    break;
            }
        }

        protected void populationDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (populationDropDownList.SelectedItem.Text)
            {
                case "Oregon":
                    MessageBox.Show("Oregon Population: 4.176 million.");
                    break;
                case "Colorado":
                    MessageBox.Show("Colorado Population: 5.77 million.");
                    break;
                case "Utah":
                    MessageBox.Show("Oregon Population: 3.16 million.");
                    break;
            }
        }

        protected void prevButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}