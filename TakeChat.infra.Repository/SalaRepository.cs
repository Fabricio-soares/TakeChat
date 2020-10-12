using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using TakeChat.Domain.IRepository;
using TakeChat.Domain.Models;

namespace TakeChat.infra.Repository
{
    public class SalaRepository : ISalaRepository
    {
        private readonly IDbConnection dbConnection;
        static SalaRepository() => SqlMapper.AddTypeMap(typeof(string), DbType.AnsiString);

        public SalaRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
        }

        public async Task InserirSala(Sala sala)
        {
            var buscaParam = new DynamicParameters();
            buscaParam.Add("nome_sala", sala.Nome);
            buscaParam.Add("ativa",true);

            var query = @"INSERT INTO Sala
                           (nome_sala
                           ,ativa)
                     VALUES
                           (@nome_sala
                           ,@ativa)";

            await dbConnection.ExecuteAsync(query,buscaParam);
        }

        public async Task<IEnumerable<Sala>> ObterSala()
        {
            var buscaParam = new DynamicParameters();


            var query = @"SELECT [id]
                          ,[nome_sala]
                          ,[ativa]
                      FROM [TakeChat].[dbo].[Sala]";

           return await dbConnection.QuerySingleOrDefaultAsync<IEnumerable<Sala>>(query);
        }
    }
}
