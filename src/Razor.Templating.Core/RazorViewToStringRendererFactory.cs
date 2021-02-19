using Microsoft.Extensions.DependencyInjection;

namespace Razor.Templating.Core
{
    internal static class RazorViewToStringRendererFactory
    {
        private static IServiceCollection? _serviceCollection;

        /// <summary>
        /// Get's the new instance of ServiceCollection class, if doesn't exists
        /// </summary>
        public static IServiceCollection ServiceCollection
        {
            get
            {
                if (_serviceCollection is null)
                {
                    return new ServiceCollection();
                }

                return _serviceCollection;
            }
            set
            {
                _serviceCollection = value;
            }
        }
        /// <summary>
        /// Returns the instance of RazorViewToStringRenderer by resolving all the dependencies required to 
        /// successfully render the razor views to string.
        /// </summary>
        /// <returns></returns>
        public static RazorViewToStringRenderer CreateRenderer()
        {
            var services = ServiceCollection;

            var provider = services.BuildServiceProvider();
            return provider.GetRequiredService<RazorViewToStringRenderer>();
        }
    }
}
