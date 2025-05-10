<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HP3_Evaluacion1.Dominio.Entidades
{
    [Table("Festivo")]
    public class Festivo
    {

        [Column("Id")]
        public int Id { get; set; }

        [Column("pkFestivo_Id")]
        public int pkFestivo_Id { get; set; }

        [Column("Nombre"), StringLength(100)]
        public required string Nombre { get; set; }

        [Column("Dia")]
        public required int Dia { get; set; }

        [Column("Mes")]
        public required int Mes { get; set; }

        [Column("DiasPascua")]
        public required int DiasPascua { get; set; }

        //Foreign Key
        [Column("fkFestivo_Tipo")]
        public int IdTipo { get; set; }
        public Tipo Tipo { get; set; }
    }
}
=======
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HP3_Evaluacion1.Dominio.Entidades
{
    [Table("Festivo")]
    public class Festivo
    {

        [Column("Id")]
        public int Id { get; set; }

        [Column("pkFestivo_Id")]
        public int pkFestivo_Id { get; set; }

        [Column("Nombre"), StringLength(100)]
        public required string Nombre { get; set; }

        [Column("Dia")]
        public required int Dia { get; set; }

        [Column("Mes")]
        public required int Mes { get; set; }

        [Column("DiasPascua")]
        public required int DiasPascua { get; set; }

        //Foreign Key
        [Column("fkFestivo_Tipo")]
        public int IdTipo { get; set; }
        public Tipo Tipo { get; set; }
    }
}
>>>>>>> 6331e77 (Agregar archivos de proyecto.)
