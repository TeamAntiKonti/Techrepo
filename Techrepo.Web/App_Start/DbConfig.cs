using System.Data.Entity;
using Techrepo.Data;
using Techrepo.Data.Migrations;

namespace Techrepo.Web.App_Start
{
    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TechrepoDbContext, Configuration>());
            TechrepoDbContext.Create().Database.Initialize(true);
        }
    }
}