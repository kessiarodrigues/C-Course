using System.Globalization;

namespace Aula06 {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotal() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", " + "$" + Preco.ToString("F2", CultureInfo.InvariantCulture) +
            ", "
            + Quantidade
            + " Unidades, Valor total: $" 
            + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
