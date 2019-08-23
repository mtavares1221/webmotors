
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteWebMotors.Domain.Entities
{
    public class Ad
    {
        [Key]
        public int ID { get; set; }
        [Column("marca")]
        public string Make { get; set; }
        [Column("modelo")]
        public string Model { get; set; }
        [Column("versao")]
        public string Version { get; set; }
        [Column("Ano")]
        public int Year { get; set; }
        [Column("quilometragem")]
        public int Km { get; set; }
        [Column("observacao")]
        public string Obs { get; set; }
    }
}
