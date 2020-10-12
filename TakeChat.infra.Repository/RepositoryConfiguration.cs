using Otc.ComponentModel.DataAnnotations;

namespace TakeChat.Infra.Repository
{
    public class RepositoryConfiguration
    {
        [Required]
        public string SqlConnectionString { get; set; }
    }
}
