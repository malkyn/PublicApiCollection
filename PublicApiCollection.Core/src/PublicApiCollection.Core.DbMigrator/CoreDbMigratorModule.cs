using PublicApiCollection.Core.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PublicApiCollection.Core.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CoreEntityFrameworkCoreModule),
    typeof(CoreApplicationContractsModule)
    )]
public class CoreDbMigratorModule : AbpModule
{

}
