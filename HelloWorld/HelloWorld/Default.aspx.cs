using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello, World!";
            UserInfoBoxControl userInfoBoxControl = (UserInfoBoxControl)LoadControl("~/UserInfoBoxControl.ascx");
            userInfoBoxControl.UserName = "Jane Doe";
            userInfoBoxControl.UserAge = 33;
            userInfoBoxControl.UserCountry = "USA";
            phUserInfoBox.Controls.Add(userInfoBoxControl);
        }

        protected void GreetButton_Click(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello, " + TextInput.Text; 
        }

        protected void GreetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello, " + GreetList.SelectedValue;
        }

        protected void MyEventUserControl_PageTitleUpdated(object sender, EventArgs e)
        {
            this.Title = MyEventUserControl.PageTitle;
        }
    }
}