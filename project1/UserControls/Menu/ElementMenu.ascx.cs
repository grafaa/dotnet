using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Framework.Constants;

namespace UserControls.Menu
{
    public partial class ElementMenu : UserControl
    {
        
        #region Properties

        /// <summary>
        /// Label property
        /// </summary>
        public string LblElement
        {
            get { return lblElementMenu.Text; }
            set { lblElementMenu.Text = value; }
        }

        /// <summary>
        /// Url property
        /// </summary>
        public string UrlElement
        {
            get { return lnkElement.NavigateUrl; }
            set { lnkElement.NavigateUrl = value; }
        }
        #endregion

        public void Selected()
        {
            lblElementMenu.CssClass += Styles.SelectedElementMenu;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}