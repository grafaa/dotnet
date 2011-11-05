using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserControls.Menu;

namespace Pages
{
    public interface IMasterPage
    {
        void SelectMenuItem(Menu.ElementsMenu oMenuItem);
    }
}