using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pages;
using UserControls.Menu;


namespace project1
{
    public partial class SiteMaster : System.Web.UI.MasterPage, IMasterPage
    {
        /// <summary>
        /// Selection du menu
        /// </summary>
        /// <param name="oMenuItem"></param>
        public void SelectMenuItem(UserControls.Menu.Menu.ElementsMenu oMenuItem)
        {
            MainMenu.SelectMenuItem(oMenuItem);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
