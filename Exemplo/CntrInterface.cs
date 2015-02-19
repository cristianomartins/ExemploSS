using Exemplo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo
{
    public class CntrInterface
    {
        public void Importar(int seguradora, string filePath)
        {

            IComInterf converteComissao;

            if (seguradora == 0)
                converteComissao = new CntrConverteComissaoAzul();
            else
                converteComissao = new CntrConverteComissaoTokio();

            //Importando
            converteComissao.Importar(null);
            
            //Validando dados:
            try
            {

                if (converteComissao.ValidarCampos())
                {
                    //Agora que os dados estão validadados preenchemos as classe correspondemtes com os dados

                    //Recibo rebibo = new Recibo()
                    //recibo.Numero = converteComissao.Recibo
                    //recibo.Documento = converteComissao.Documento
                    //recibo.Comissao = converteComissao.Comissao

                    //CntrRecibo cntrRecibo = new CntrRecibo();
                    //cntrRecibo.Salva(recibo);
                    MessageBox.Show("Comissão salva com sucesso!", "S U C E S S O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "E R R O", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
