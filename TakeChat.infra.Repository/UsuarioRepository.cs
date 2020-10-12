using Dapper;
using System;
using System.Data;
using System.Threading.Tasks;
using TakeChat.Domain.IRepository;
using TakeChat.Domain.Models;

namespace TakeChat.infra.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IDbConnection dbConnection;

        static UsuarioRepository() => SqlMapper.AddTypeMap(typeof(string), DbType.AnsiString);

        public UsuarioRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
        }

        public async Task InserirUsuarioAsync(Usuario usuario)
        {
            var buscaParam = new DynamicParameters();

            buscaParam.Add("nome_usuario", usuario.Nome, DbType.String);
            buscaParam.Add("apelido", usuario.Apelido, DbType.String);


            var query = @"INSERT INTO Usuario
                               (nome_usuario
                               ,apelido)
                         VALUES
                               (@nome_usuario
                               ,@apelido)";

            await dbConnection.ExecuteAsync(query, buscaParam);

        }
    }
}
