using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2.DeveloperTest.Context
{
    public class MigrationsContextFactory : IDbContextFactory<DeveloperTest>
    {
        public DeveloperTest Create()
        {
            return new DeveloperTest(M2.DeveloperTest.Constants.Constant.SystemEmail);
        }
    }
}
