using System.Globalization;

namespace Aula08 {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

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
