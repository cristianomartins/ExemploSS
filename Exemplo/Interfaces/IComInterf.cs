
namespace Exemplo.Interfaces
{
    public interface IComInterf
    {
        #region Propriedades

        string Documento { get; }

        int Recibo { get; }

        double Comissao { get; }

        #endregion

        #region Métodos
        
        void Importar(byte[] file);

        void Carregar();

        bool ValidarCampos();

        #endregion
    }
}
