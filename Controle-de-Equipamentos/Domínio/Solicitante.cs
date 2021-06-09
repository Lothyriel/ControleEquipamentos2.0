using System;

namespace Controle_de_Equipamentos.Domínio
{
    class Solicitante 
    {
        private String nome;
        private String email;
        private String nro_tel;

        public Solicitante(string nome, string email, string nro_tel)
        {
            this.nome = nome;
            this.email = email;
            this.nro_tel = nro_tel;
        }

        public string Nome { get => nome;}

        public override bool Equals(object obj)
        {
            return email == ((Solicitante)obj).email;
        }

        public override int GetHashCode()
        {
            return nome.GetHashCode() ^ email.GetHashCode();
        }

        public override string ToString()
        {
            return "Solicitante{" + "Nome:" + nome + "/ Email: " + email + "/ Número_Telefone: " + nro_tel + '}';
        }
    }
}
