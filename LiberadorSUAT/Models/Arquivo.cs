using LiberadorSUAT.Screens.Modals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberadorSUAT.Models
{
    class Arquivo
    {
        string[] optionList = new string[2]
        {
            "Word Documents|*.doc|PDF Files|*.pdf",
            "DB Files|*.sql|*.seq|*.syn|*.tab|*.trg|*.tps|*.vw|*.fnc|*.bdy"
        };

        public void AdicionarArquivos(ListBox listBox, int i)
        {
            listBox.IntegralHeight = true;

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.Filter = optionList[i];

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var file in dialog.FileNames)
                    {
                        listBox.Items.Add(file);
                    }
                }
            }

            listBox.HorizontalScrollbar = true;
        }

        public void ExcluirArquivos(ListBox listBox)
        {
            for (int i = listBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                if (listBox.SelectedIndex != -1)
                {
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Selecione os arquivos que deseja excluir");
                }
            }
        }
    }
}
