using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo.Interfaces;

namespace Exemplo
{
    public abstract class CntrConverteComissaoBase : IComInterf
    {
        #region Campos
        protected string documento;
        protected int recibo;
        protected double comissao;
        #endregion

        #region Propriedades
        public string Documento
        {
            get { return this.documento; }
        }

        public int Recibo
        {
            get { return this.recibo; }
        }

        public double Comissao
        {
            get { return this.comissao; }
        }
        #endregion

        #region Métodos
        public virtual bool ValidarCampos()
        {
            if (this.Comissao > 100)
            {
                throw new Exception("Comissão não pode ser maior que 100");
            }

            if (this.Documento == "")
            {
                throw new Exception("Documento não informado");
            }

            if (this.Recibo == 0)
            {
                throw new Exception("Recibo não informado");
            }

            return true;
        }

        public abstract void Carregar();

        public abstract void Importar(byte[] file);

        #endregion
    }
}
