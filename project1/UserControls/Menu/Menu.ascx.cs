using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControls.Menu
{
    public partial class Menu : UserControl
    {
        public enum ElementsMenu
        {
            Home,
            Customize
        }

        public void SelectMenuItem(ElementsMenu oMenuItem)
        {
            switch (oMenuItem)
            {
                case ElementsMenu.Home:
                    {
                        HomeItem.Selected();
                        break;
                    }
                case ElementsMenu.Customize:
                    {
                        CustomizeItem.Selected();
                        break;
                    }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}