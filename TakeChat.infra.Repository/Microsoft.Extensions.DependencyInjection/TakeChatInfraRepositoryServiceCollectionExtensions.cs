using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using TakeChat.Domain.IRepository;
using TakeChat.Infra.Repository;

namespace TakeChat.infra.Repository.Microsoft.Extensions.DependencyInjection
{
    public static class TakeChatInfraRepositoryServiceCollectionExtensions
    {
        [ExcludeFromCodeCoverage]


        public static IServiceCollection AddRepository(this IServiceCollection services, RepositoryConfiguration repositoryConfiguration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (repositoryConfiguration == null)
                throw new ArgumentNullException(nameof(repositoryConfiguration));

            // Registra a instancia do objeto de configuracoes desta camanda.
            services.AddSingleton(repositoryConfiguration);

            services.AddScoped<IDbConnection>(d =>
            {
                return new SqlConnection(repositoryConfiguration.SqlConnectionString);
            });

            // Registra a implementacao do ITmdbAdapter para ser utilizado na camada de aplicacao.
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ISalaRepository, SalaRepository>();
            

            return services;
        }

    }
}
