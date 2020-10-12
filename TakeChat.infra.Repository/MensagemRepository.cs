using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TakeChat.Domain.IRepository;
using TakeChat.Domain.Models;

namespace TakeChat.infra.Repository
{
    public class MensagemRepository : IMensagemRepository
    {
        private readonly IDbConnection dbConnection;
        static MensagemRepository() => SqlMapper.AddTypeMap(typeof(string), DbType.AnsiString);

        public MensagemRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection ?? throw new System.ArgumentNullException(nameof(dbConnection));
        }

        public async Task InserirMensagemAsync(Mensagem mensagem)
        {
            var buscaParam = new DynamicParameters();
            buscaParam.Add("conteudo", mensagem,System.Data.DbType.String);
            buscaParam.Add("id_sala", mensagem,System.Data.DbType.Guid);
            buscaParam.Add("id_usuario_env", mensagem,System.Data.DbType.Guid);
            buscaParam.Add("id_usuario_rec", mensagem,System.Data.DbType.Guid);
            buscaParam.Add("data_env", DateTime.Now,System.Data.DbType.DateTime);


            var query = @"INSERT INTO [dbo].[Mensagem]
                           (conteudo
                           ,id_sala
                           ,id_usuario_env
                           ,id_usuario_rec
                           ,data_env)
                     VALUES
                           (@conteudo,
                           ,@id_sala, 
                           ,@id_usuario_env, 
                           ,@id_usuario_rec,
                           ,@data_env)";

            await dbConnection.ExecuteAsync(query, buscaParam);

        }
    }
}
