using DevFramework.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerlHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure();
        }
    }
}
