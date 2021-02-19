using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Threading.Tasks;

namespace Razor.Templating.Core
{
    public interface IRazorViewToStringRenderer
    {
        Task<string> RenderViewToStringAsync<TModel>(string partialName, TModel model);

        Task<string> RenderViewToStringAsync<TModel>(string partialName, TModel model, ViewDataDictionary viewDataDictionary);
    }
}
