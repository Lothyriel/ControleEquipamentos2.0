using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using System;

namespace Controle_de_Equipamentos.Validadores
{
    class ValidadorSolicitante : Validador
    {
        public ValidadorSolicitante(ControladorSolicitante controller) : base(controller)
        {

        }
        public override object objetoValido()
        {
            int nro_tel;
            string email, nome, nro_telS;

            while (true)
            {
                Console.WriteLine("Digite o nome do solicitante");
                nome = Console.ReadLine(); //"João"; //
                if (nome.Length > 5) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o email do solicitante");
                email = Console.ReadLine(); //"email@gmail.com"; //
                if (email.Length > 4) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o número de telefone do solicitante");
                nro_telS = Console.ReadLine(); //"99790818"; //
                if (nro_telS.Length > 8 && int.TryParse(nro_telS, out nro_tel)) { break; }
            }

            return new Solicitante(nome, email, nro_telS);
        }
    }
}
