using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoDelOperadorToList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            selecListaDeportes();
        }
        private void selecListaDeportes()
        {
            List<string> deportesLista = (
                from deportes in Lista.GetListas()
                select deportes.deportes
                ).ToList();

            foreach (var deportes in deportesLista)
                lstLista.Items.Add(deportes);

        }

    }
}  


