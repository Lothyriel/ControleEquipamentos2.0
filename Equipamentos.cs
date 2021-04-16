using System;

namespace Equipamentos_Junior
{
    class Equipamentos
    {
        private string nome;
        private double preco;
        private int nro_serie;
        private DateTime data_fabricacao;
        private string fabricante;

        public Equipamentos(string nome, double preco, int nro_serie, DateTime data_fabricacao, string fabricante)
        {
            this.nome = nome;
            this.preco = preco;
            this.nro_serie = nro_serie;
            this.data_fabricacao = data_fabricacao;
            this.fabricante = fabricante;
        }

        public string Nome { get => nome; set => nome = value; }

        public override string ToString()
        {
            return "Equipamento{" + "Nome:" + nome + "/ Nro_serie: " + nro_serie + "/ Preço: " + preco + "/ Data_Fabricação: " + data_fabricacao.ToString("dd/MM/yyyy") + "/ Fabricante:" + fabricante + '}';
        }
    }
}
