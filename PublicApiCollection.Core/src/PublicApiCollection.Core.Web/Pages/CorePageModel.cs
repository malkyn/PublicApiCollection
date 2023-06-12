using PublicApiCollection.Core.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace PublicApiCollection.Core.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CorePageModel : AbpPageModel
{
    protected CorePageModel()
    {
        LocalizationResourceType = typeof(CoreResource);
    }
}
