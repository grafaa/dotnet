using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;

namespace DBConnection
{
    public static class EntityObjectExtension
    {
        public static void Add(this EntityObject aObject)
        {
            ContextDAO.DataContext.AddObject(aObject.GetType().Name, aObject);
            ContextDAO.Save();
        }
        public static void Delete(this EntityObject aObject)
        {
            ContextDAO.DataContext.DeleteObject(aObject);
            ContextDAO.Save();
        }
    }
}
