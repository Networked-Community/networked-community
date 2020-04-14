using System;
using System.Collections.Generic;
using System.Text;
using Nc.Localization;
using Volo.Abp.Application.Services;

namespace Nc
{
    /* Inherit your application services from this class.
     */
    public abstract class NcAppService : ApplicationService
    {
        protected NcAppService()
        {
            LocalizationResource = typeof(NcResource);
        }
    }
}
