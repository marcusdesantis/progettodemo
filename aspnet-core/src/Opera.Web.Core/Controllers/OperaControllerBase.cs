using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Opera.Controllers
{
    public abstract class OperaControllerBase: AbpController
    {
        protected OperaControllerBase()
        {
            LocalizationSourceName = OperaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
