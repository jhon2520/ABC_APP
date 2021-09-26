using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABC_APP.logica
{
    class ComboBoxLogica
    {
        public void PasarItemsComboBox(ComboBox comboBoxOrigen, ComboBox comboBoxDestino)
        {
            comboBoxDestino.Items.Add(comboBoxOrigen.SelectedItem);
        }

        public void RemoverDuplicados(ComboBox comboBoxDestino)
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < comboBoxDestino.Items.Count; i++)
            {
                lista.Add(comboBoxDestino.Items[i].ToString());
                
            }

            List<string> ListaUnica = lista.Distinct().ToList();
            comboBoxDestino.Items.Clear();
            comboBoxDestino.Items.AddRange(ListaUnica.ToArray());
            
        }

        public List<string> GetComboBoxItems(ComboBox comboBox)
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                lista.Add(comboBox.Items[i].ToString());
            }
            return lista;
        }
        /// <summary>
        /// Método para pasar los elementos de una lista a items de un combobox
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="comboBox"></param>
        public void FromListToComboBox(List<string> lista,ComboBox comboBox)
        {
            foreach (string item in lista)
            {
                comboBox.Items.Add(item);
            }
        }

    }
}
