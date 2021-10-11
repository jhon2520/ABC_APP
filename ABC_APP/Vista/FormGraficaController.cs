﻿using ABC_APP.logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_APP.Vista
{
    class FormGraficaController
    {
        private FormGrafica formGrafica;
        private Archivos archivos = new Archivos();
        private FormError formError;
        private string nombreGragica;
        private double zoom = 1.0;

        public string NombreGragica { get => nombreGragica; set => nombreGragica = value; }

        public FormGraficaController(FormGrafica formGrafica, string nombreGrafica)
        {
            this.formGrafica = formGrafica;
            this.NombreGragica = nombreGrafica; 
            Sobrecargas();
        }

        public void Sobrecargas()
        {
            this.formGrafica.Load += new EventHandler(AbrirForm);

        }

        public void AbrirForm(object sender, EventArgs args)
        {
            //TODO: Crear método abstracto para esto con un try catch

            try
            {
                this.formGrafica.pbxGrafica.Image = Image.FromFile(@"C:\Users\Jhon Romero\archivosABC\" + this.NombreGragica + ".png");
            }
            catch (Exception ex)
            {
                formError = new FormError(ex.ToString());
                formError.ShowDialog();
            }

        }

       
    }
}
