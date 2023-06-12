using PublicApiCollection.Core.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PublicApiCollection.Core;

[DependsOn(
    typeof(CoreEntityFrameworkCoreTestModule)
    )]
public class CoreDomainTestModule : AbpModule
{

}
