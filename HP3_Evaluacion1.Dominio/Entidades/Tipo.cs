<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP3_Evaluacion1.Dominio.Entidades
{
    [Table ("Tipo")]
    public class Tipo
    {
        [Column  ("Id")]
         public required int Id { get; set; }

        [Column ("Tipo"), StringLength(100)] 
        public string Nombre { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP3_Evaluacion1.Dominio.Entidades
{
    [Table ("Tipo")]
    public class Tipo
    {
        [Column  ("Id")]
         public required int Id { get; set; }

        [Column ("Tipo"), StringLength(100)] 
        public string Nombre { get; set; }
    }
}
>>>>>>> 6331e77 (Agregar archivos de proyecto.)
