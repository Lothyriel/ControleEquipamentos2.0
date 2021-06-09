using System;

namespace Controle_de_Equipamentos.Domínio
{
    class Chamado 
    {
        private string titulo;
        private string desc;
        private Equipamento equipamento;
        private DateTime data_abertura;
        private Solicitante solicitante;

        public Chamado(string titulo, String desc, Equipamento equipamento, DateTime data_abertura, Solicitante solicitante)
        {
            this.titulo = titulo;
            this.desc = desc;
            this.equipamento = equipamento;
            this.data_abertura = data_abertura;
            this.solicitante = solicitante;
        }
        public Equipamento Equipamento { get => equipamento; }

        private int diasAberto(DateTime data)
        {
            TimeSpan diferenca = DateTime.Now.Subtract(data);
            return Convert.ToInt32(diferenca.TotalDays);
        }
        public override String ToString()
        {
            return "Chamado{" + "Título:" + titulo + "/ Equipamento: " + equipamento.Nome + "/ Data_abertura: " + data_abertura.ToString("dd/MM/yyyy") + "/ Dias_em_aberto: " + diasAberto(data_abertura) + "/ Solicitante: " + solicitante.Nome + '}';
        }
        public override bool Equals(object obj)
        {
            return (titulo == ((Chamado)obj).titulo);
        }
        public override int GetHashCode() //    ^ = XOR, ou exclusivo, em operacoes com inteiros os transforma em binario faz a operacao bit a bit
        {
            return titulo.GetHashCode() ^ desc.GetHashCode();
        }
    }
}
