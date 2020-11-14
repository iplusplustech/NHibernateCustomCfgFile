using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernateCustomCfgFile.Helper;
using NHibernateCustomCfgFile.Models;

namespace NHibernateCustomCfgFile.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBDConnection()
        {
            //When using the default config file for NHibernate
            Database.DBSession()
                 .QueryOver<DTOUser>()
                 .Where(i => i.Active == 1)
                 .List<DTOUser>();

            //When using the custom config file for NHibernate
            Database.DBSession(Database.DBSelector.CUSTOM)
                 .QueryOver<DTOUser>()
                 .Where(i => i.Active == 1)
                 .List<DTOUser>();
        }
    }
}
