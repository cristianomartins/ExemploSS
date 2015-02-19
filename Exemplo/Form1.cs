using Exemplo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string filePath = "";

            if (cmbSeguradora.SelectedIndex == 0)
                filePath = @"C:\Temp\ComissaoAzul.txt";
            else
                filePath = @"C:\Temp\ComissaoTokio.txt";

            CntrInterface cntrInterface = new CntrInterface();
            cntrInterface.Importar(cmbSeguradora.SelectedIndex, filePath);
        }
    }
}
