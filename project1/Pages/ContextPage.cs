using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Pages
{
    public class ContextPage: Page
    {
        protected new IMasterPage Master
        {
            get { return (IMasterPage)base.Master; }
        }
        public ContextPage()
        {
        }
        public void SelectMenuItem(UserControls.Menu.Menu.ElementsMenu oMenuItem)
        {
            Master.SelectMenuItem(oMenuItem);
        }
    }
}