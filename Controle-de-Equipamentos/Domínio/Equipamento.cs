using System;

namespace Controle_de_Equipamentos.Domínio
{
    class Equipamento
    {
        private string nome;
        private double preco;
        private int nro_serie;
        private DateTime data_fabricacao;
        private string fabricante;

        public Equipamento(string nome, double preco, int nro_serie, DateTime data_fabricacao, string fabricante)
        {
            this.nome = nome;
            this.preco = preco;
            this.nro_serie = nro_serie;
            this.data_fabricacao = data_fabricacao;
            this.fabricante = fabricante;
        }
        public string Nome { get => nome;}
        public int Nro_serie { get => nro_serie;}

        public override string ToString()
        {
            return "Equipamento{" + "Nome:" + nome + "/ Nro_serie: " + nro_serie + "/ Preço: " + preco + "/ Data_Fabricação: " + data_fabricacao.ToString("dd/MM/yyyy") + "/ Fabricante:" + fabricante + '}';
        }
        public override bool Equals(object obj)
        {
            return (nro_serie == ((Equipamento)obj).nro_serie);
        }
        public override int GetHashCode() //    ^ = XOR, ou exclusivo, em operacoes com inteiros os transforma em binario faz a operacao bit a bit
        {
            return nro_serie.GetHashCode() ^ nome.GetHashCode();
        }
    }
}
