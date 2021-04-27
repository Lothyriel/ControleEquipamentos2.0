using System;

namespace Equipamentos_Junior
{
    class Program
    {
        private static Controlador controller = new Controlador();

        private static void Main(string[] args) { menu(); }
        private static void menu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nDigite: ");
                Console.WriteLine("1- para visualizar o menu de equipamentos");
                Console.WriteLine("2- para visualizar o menu de chamados");
                Console.ResetColor();

                string opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1": menuEquipamentos(); break;
                    case "2": menuChamados(); break;

                    default: erro("Comando incorreto!"); break;
                }
            }
        }
        public static void menuEquipamentos()
        {
            Console.WriteLine("1- para visualizar equipamentos cadastrados");
            Console.WriteLine("2- para cadastrar novos equipamentos");
            Console.WriteLine("3- para editar equipamentos");
            Console.WriteLine("4- para excluir equipamentos");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": printArray(controller.Equip); break;
                case "2": cadastrarEquip(-1); break;
                case "3": edit(controller.Equip); break;
                case "4": excluir(controller.Equip); break;

                default: erro("Comando incorreto!"); break;
            }
        }
        public static void menuChamados()
        {
            Console.WriteLine("1- para visualizar chamados cadastrados");
            Console.WriteLine("2- para cadastrar novos chamados");
            Console.WriteLine("3- para editar chamados");
            Console.WriteLine("4- para excluir chamados\n");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": printArray(controller.Cham); break;
                case "2": cadastrarCham(-1); break;
                case "3": edit(controller.Cham); break;
                case "4": excluir(controller.Cham); break;

                default: erro("Comando incorreto!"); break;
            }
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
        private static void cadastrarEquip(int indice)
        {
            Equipamentos eq = Validador.equipValido();

            if (Validador.itemDuplicado(controller.Equip, eq) && indice == -1) { erro("Item já esta cadastrado"); }

            else
            {
                controller.cadastrarEquip(indice, eq);
            }
        }
        private static void cadastrarCham(int indice)
        {
            if (controller.Equip.Length == 0) { erro("Nenhum equipamento registrado!"); }
            else
            {
                Chamados c = Validador.chamadoValido(controller.Equip);

                if (Validador.itemDuplicado(controller.Cham, c) && indice == -1) { erro("Item já esta cadastrado"); }

                else
                {
                    controller.cadastrarCham(indice, c);
                }
            }
        }
        private static void excluir(Object[] array)
        {
            while (true)
            {
                Console.WriteLine("Digite o indice para exclusão ou digite 0 para cancelar");
                if (!printArray(array)) { break; }
                string opcao = Console.ReadLine();
                if (opcao == "0") { break; }

                if (!int.TryParse(opcao, out int opcaoInt) || opcaoInt < 0 || opcaoInt > array.Length) { continue; }

                if (array.Equals(controller.Equip) && Validador.equipDependente(controller.Cham, controller.Equip[opcaoInt - 1]))
                {
                    erro("Este equipamento está vinculado a um chamado"); break;
                }
                controller.excluir(opcaoInt, array); break;
            }
        }
        private static void edit(Object[] array)
        {
            while (true)
            {
                Console.WriteLine("Digite o indice para editar ou digite 0 para cancelar");
                if (!printArray(array)) { break; }
                string opcao = Console.ReadLine();
                if (opcao == "0") { break; }

                if (!int.TryParse(opcao, out int opcaoInt) || opcaoInt < 0 || opcaoInt > array.Length) { continue; }

                if (array.Equals(controller.Equip)) { cadastrarEquip(opcaoInt); break; }
                else if (array.Equals(controller.Cham)) { cadastrarCham(opcaoInt); break; }
            }
        }
        private static void erro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(mensagem); Console.ResetColor();
        }
    }
}

