using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserControls.Menu;

namespace Pages
{
    public partial class Home : ContextPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SelectMenuItem(UserControls.Menu.Menu.ElementsMenu.Home);
        }
    }
}