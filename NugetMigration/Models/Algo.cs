using System.ComponentModel.DataAnnotations;

namespace NugetMigration.Models
{
    public class Algo
    {
        [Key]
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public required string Matricula { get; set; }
    }
}