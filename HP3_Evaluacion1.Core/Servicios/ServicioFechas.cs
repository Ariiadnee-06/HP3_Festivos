<<<<<<< HEAD
﻿using System;

namespace HP3_Evaluacion1.Core.Servicios
{
    public class ServicioFechas
    {
        public static DateTime ObtenerInicioSemanaSanta(int año)
        {
            int a = año % 19;
            int b = año % 4;
            int c = año % 7;
            int d = (19 * a + 24) % 30;
            int e = (2 * b + 4 * c + 6 * d + 5) % 7;
            int dias = d + e;

            int dia = 15 + dias;
            int mes = 3;

            if (dia > 31)
            {
                dia -= 31;
                mes = 4;
            }

            return new DateTime(año, mes, dia);
        }

        public static DateTime AgregarDias(DateTime fecha, int dias)
        {
            return fecha.AddDays(dias);
        }

        public static DateTime ObtenerSiguienteLunes(DateTime fecha)
        {
            int diasLunes = ((int)DayOfWeek.Monday - (int)fecha.DayOfWeek + 7) % 7;
            return diasLunes == 0 ? fecha : AgregarDias(fecha, diasLunes);
        }
    }
}
=======
﻿using System;

namespace HP3_Evaluacion1.Core.Servicios
{
    public class ServicioFechas
    {
        public static DateTime ObtenerInicioSemanaSanta(int año)
        {
            int a = año % 19;
            int b = año % 4;
            int c = año % 7;
            int d = (19 * a + 24) % 30;
            int e = (2 * b + 4 * c + 6 * d + 5) % 7;
            int dias = d + e;

            int dia = 15 + dias;
            int mes = 3;

            if (dia > 31)
            {
                dia -= 31;
                mes = 4;
            }

            return new DateTime(año, mes, dia);
        }

        public static DateTime AgregarDias(DateTime fecha, int dias)
        {
            return fecha.AddDays(dias);
        }

        public static DateTime ObtenerSiguienteLunes(DateTime fecha)
        {
            int diasLunes = ((int)DayOfWeek.Monday - (int)fecha.DayOfWeek + 7) % 7;
            return diasLunes == 0 ? fecha : AgregarDias(fecha, diasLunes);
        }
    }
}
>>>>>>> 6331e77 (Agregar archivos de proyecto.)
