using System;
using System.Diagnostics.CodeAnalysis;
using TakeChat.Application;
using TakeChat.Application.Service;
using TakeChat.Application.Service.Concreto;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ApplicationServiceCollectionExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IServiceCollection AddApplication(
            this IServiceCollection services,
            ApplicationConfiguration applicationConfiguration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (applicationConfiguration == null)
            {
                throw new ArgumentNullException(nameof(applicationConfiguration));
            }

            services.AddSingleton(applicationConfiguration);

            services.AddScoped<ISalaAppService, SalaAppService>();
            services.AddScoped<IMensagemAppService, MensagemAppService>();
            services.AddScoped<IUsuarioAppService, UsuarioAppService>();
            

            return services;
        }
    }
}
