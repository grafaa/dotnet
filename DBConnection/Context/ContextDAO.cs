using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Web;

namespace DBConnection
{
    public partial class ContextDAO
    {
        /// <summary>
        /// List of data contexts
        /// </summary>
        static Dictionary<string, DBHomeContainer> _listContexts;

        /// <summary>
        /// Property to access list of data contexts
        /// </summary>
        static Dictionary<string, DBHomeContainer> ListContexts
        {
            get { return ContextDAO._listContexts; }
            set { ContextDAO._listContexts = value; }
        }

        /// <summary>
        /// Static constructor
        /// </summary>
        static ContextDAO()
        {
            ContextDAO._listContexts = new Dictionary<string, DBHomeContainer>();
        }

        /// <summary>
        /// Create a data context
        /// </summary>
        /// <returns>DBHomeContainer</returns>
        private static DBHomeContainer CreateDataContext()
        {
            DBHomeContainer oDBHomeConn = new DBHomeContainer(ConfigurationManager.ConnectionStrings["DBHomeContainer"].ConnectionString);
            return oDBHomeConn;
        }

        /// <summary>
        /// To access to data context
        /// </summary>
        internal static DBHomeContainer DataContext
        {
            get
            {
                DBHomeContainer oDataContext = null;
                if (HttpContext.Current != null && HttpContext.Current.Session != null)
                {
                    if (ListContexts.ContainsKey(HttpContext.Current.Session.SessionID))
                    {
                        oDataContext = ListContexts[HttpContext.Current.Session.SessionID];
                    }
                    else
                    {
                        oDataContext = ContextDAO.CreateDataContext();
                        ListContexts.Add(HttpContext.Current.Session.SessionID, oDataContext);
                    }
                }
                else
                {
                    if (ListContexts.ContainsKey("AppliWin"))
                    {
                        oDataContext = ListContexts["AppliWin"];
                    }
                    else
                    {
                        oDataContext = ContextDAO.CreateDataContext();
                        ListContexts.Add("AppliWin", oDataContext);
                    }
                }
                return oDataContext;
            }
        }
        
        /// <summary>
        /// Remove context when session ends
        /// </summary>
        /// <param name="aIdDataContext"></param>
        public static void DeleteContext(string aIdDataContext)
        {
            if(ListContexts.ContainsKey(aIdDataContext))
            {
                ListContexts.Remove(aIdDataContext);
            }
        }

        /// <summary>
        /// Save changes to data base, SaveChanges() is applied on the current data context
        /// </summary>
        public static void Save()
        {
            ContextDAO.DataContext.SaveChanges();
        }
    }
}
