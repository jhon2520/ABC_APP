using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_APP
{
    class Prueba
    {
        public string EjecutarPython()
        {
            string pyPath = @"C:\Users\Jhon Romero\source\repos\ABC_APP\ABC_APP\ObjectPy.py";
            ScriptRuntime py = Python.CreateRuntime();

            //ejecuta todo el archivo .py
            dynamic pyProgram = py.UseFile(pyPath);

            //ejecutar un métopdo en python
            string valor = pyProgram.probando("Jhon");
            return valor;
        }

    }
}
