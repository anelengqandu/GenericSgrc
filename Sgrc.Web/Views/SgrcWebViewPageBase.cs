using Abp.Web.Mvc.Views;

namespace Sgrc.Web.Views
{
    public abstract class SgrcWebViewPageBase : SgrcWebViewPageBase<dynamic>
    {

    }

    public abstract class SgrcWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SgrcWebViewPageBase()
        {
            LocalizationSourceName = SgrcConsts.LocalizationSourceName;
        }
    }
}