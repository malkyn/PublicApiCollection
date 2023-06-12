using PublicApiCollection.Core.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PublicApiCollection.Core.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CoreController : AbpControllerBase
{
    protected CoreController()
    {
        LocalizationResource = typeof(CoreResource);
    }
}
