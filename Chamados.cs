using System;
using System.Collections.Generic;
using System.Text;

namespace Equipamentos_Junior
{
    class Chamados
    {
        private string titulo;
        private string desc;
        private Equipamentos equipamento;
        private DateTime data_abertura;

        public Chamados(string titulo, String desc, Equipamentos equipamento, DateTime data_abertura)
        {
            this.titulo = titulo;
            this.desc = desc;
            this.equipamento = equipamento;
            this.data_abertura = data_abertura;
        }
        private static string printarData(DateTime data)
        {
            return data.Day + "/" + data.Month + "/" + data.Year;
        }
        public int diasAberto(DateTime data)
        {
            TimeSpan diferenca = DateTime.Now.Subtract(data);
            return Convert.ToInt32(diferenca.TotalDays);
        }
        public override String ToString()
        {
            return "Chamado{" + "Título:" + titulo + " " + equipamento.Nome + ", Data_abertura:" + printarData(data_abertura) + " Dias_em_aberto:" + diasAberto(data_abertura) + '}';
        }
    }
}
