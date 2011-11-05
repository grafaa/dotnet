using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages
{
    public partial class Customize : ContextPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SelectMenuItem(UserControls.Menu.Menu.ElementsMenu.Customize);
        }
    }
}