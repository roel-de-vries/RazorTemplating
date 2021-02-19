using Razor.Templating.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRazorTemplating(this IServiceCollection services)
        {
            if(RazorViewToStringRendererFactory.ServiceCollection != null)
            {
                RazorViewToStringRendererFactory.ServiceCollection = services;
                RazorViewToStringRendererFactory.RegisterDependencies();
            }

            RazorViewToStringRendererFactory.ServiceCollection = services;
        }
    }
}
