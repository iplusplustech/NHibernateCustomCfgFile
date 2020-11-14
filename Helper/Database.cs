using System;
using NHibernate;
using NHibernate.Cfg;

namespace NHibernateCustomCfgFile.Helper
{
    public class Database
    {
        public static ISession session = null;
        public enum DBSelector
        {
            CUSTOM,
            DEFAULT
        };

        public static ISession DBSession(DBSelector db = DBSelector.DEFAULT)
        {            
            switch (db)
            {
                case DBSelector.CUSTOM:
                    {
                        var cfgFile = string.Empty;                        
                        cfgFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\mypath\\custom.cfg.xml";//replace the [mypath] with your path
                        Configuration configuration = new Configuration()
                                    .AddAssembly("NHibernateCustomCfgFile")
                                    .Configure(cfgFile);
                        ISessionFactory sessionFactory = configuration.BuildSessionFactory();
                        session = sessionFactory.OpenSession();
                    }

                    break;
                default:
                case DBSelector.DEFAULT:
                    {
                        Configuration configuration = new Configuration()
                               .AddAssembly("NHibernateCustomCfgFile")
                               .Configure();//by default it reads hibernate.cfg.xml            
                        ISessionFactory sessionFactory = configuration.BuildSessionFactory();
                        session = sessionFactory.OpenSession();
                        break;
                    }
            }
            return session;
        }
    }
}
