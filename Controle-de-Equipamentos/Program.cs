using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using Controle_de_Equipamentos.Telas;
using Controle_de_Equipamentos.Validadores;
using System;

namespace Controle_de_Equipamentos
{
    class Program
    {
        private static void Main(string[] args)
        {
            new TelaPrincipal();
        }
        public static void erro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(mensagem); Console.ResetColor();
        }
        public static bool printArray(Object[] array)
        {
            if (array.Length == 0)
            {
                erro("Nada cadastrado aqui!");
                return false;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("[" + (i + 1) + "] " + array[i]);
                }
                return true;
            }
        }
    }
}

