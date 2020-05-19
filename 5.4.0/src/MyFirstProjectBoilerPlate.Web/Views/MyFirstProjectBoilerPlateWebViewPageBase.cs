using Abp.Web.Mvc.Views;

namespace MyFirstProjectBoilerPlate.Web.Views
{
    public abstract class MyFirstProjectBoilerPlateWebViewPageBase : MyFirstProjectBoilerPlateWebViewPageBase<dynamic>
    {

    }

    public abstract class MyFirstProjectBoilerPlateWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyFirstProjectBoilerPlateWebViewPageBase()
        {
            LocalizationSourceName = MyFirstProjectBoilerPlateConsts.LocalizationSourceName;
        }
    }
}