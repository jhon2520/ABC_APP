using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.CacheData
{
    public static class Cache
    {
        private static Color colorLetra;
        private static Color colorFondo;
        private static double valorCeldaFormato;
        private static DataTable  dataTablePrueba;

        public static Color ColorLetra { get => colorLetra; set => colorLetra = value; }
        public static Color ColorFondo { get => colorFondo; set => colorFondo = value; }
        public static double ValorCeldaFormato { get => valorCeldaFormato; set => valorCeldaFormato = value; }
        public static DataTable DataTablePrueba{ get => dataTablePrueba; set => dataTablePrueba = value; }
    }
}
