using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class UserInfoBoxControl : System.Web.UI.UserControl
    {
        private string userName;
        private int userAge;
        private string userCountry;
        
        public string UserName { get => userName; set => userName = value; }
        public int UserAge { get => userAge; set => userAge = value; }
        public string UserCountry { get => userCountry; set => userCountry = value; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}