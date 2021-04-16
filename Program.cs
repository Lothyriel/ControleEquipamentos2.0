﻿using System;
using System.Globalization;

namespace Equipamentos_Junior
{
    class Program
    {
        static Equipamentos[] equip = new Equipamentos[0];
        static Chamados[] cham = new Chamados[0];

        static void Main(string[] args)
        {
            menu();
        }

        private static void menu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("\nDigite: ");
                Console.WriteLine("1- para visualizar equipamentos");
                Console.WriteLine("2- para visualizar chamados");
                Console.WriteLine("3- para cadastrar novos equipamentos");
                Console.WriteLine("4- para cadastrar novos chamados");
                Console.WriteLine("5- para editar equipamentos");
                Console.WriteLine("6- para excluir equipamentos");
                Console.WriteLine("7- para editar chamados");
                Console.WriteLine("8- para excluir chamados\n");
                Console.ResetColor();

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": printArray(equip); break;
                    case "2": printArray(cham); break;
                    case "3": cadastrarEquip(-1); break;
                    case "4": cadastrarCham(-1); break;
                    case "5": edit(equip); break;
                    case "6": excluirEquip(); break;
                    case "7": edit(cham); break;
                    case "8": excluirCham(); break;

                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Comando incorreto!"); Console.ResetColor(); break;
                }
            }
        }
        public static void printArray(Object[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Nada cadastrado aqui!");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("[" + (i + 1) + "] " + array[i]);
                }
            }
        }
        public static void cadastrarEquip(int e)
        {
            int nro_serie;
            double preco;
            string nome, fabricante;
            DateTime data_fabr;

            while (true)
            {
                Console.WriteLine("Digite o nome do equipamento");
                nome = "VOLT TV"; //Console.ReadLine();
                if (nome.Length > 5) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o preço do equipamento");
                string precoStr = "3000"; //Console.ReadLine();
                if (double.TryParse(precoStr, out preco)) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o número de série do equipamento");
                string nro_serieStr = "1000"; //Console.ReadLine();
                if (int.TryParse(nro_serieStr, out nro_serie)) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite a data de fabricação do equipamento");
                string data_fabrStr = "27/04/2001"; //Console.ReadLine();
                if (DateTime.TryParse(data_fabrStr, out data_fabr)) { break; };
            }
            while (true)
            {
                Console.WriteLine("Digite o fabricante do equipamento");
                fabricante = "LG"; //Console.ReadLine();
                if (fabricante.Length > 1) { break; }
            }

            //AUMENTANDO O ARRAY E INSERINDO VALORES JÁ VALIDADOS
            Array.Resize(ref equip, equip.Length + 1);
            Equipamentos e = new Equipamentos(nome, preco, nro_serie, data_fabr, fabricante);
            if (e == -1) { equip[equip.Length - 1] = e; }
            else { equip[e] = e; }
        }   //INT E INDICA SE O VALOR É NOVO OU É UM EDIT DE UM VALOR ANTERIOR
        public static void cadastrarCham(int e)
        {
            if (equip.Length == 0) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Nenhum equipamento registrado!"); Console.ResetColor(); }
            else
            {
                int iEquip;
                string desc, titulo;
                DateTime data_ab;

                while (true)
                {
                    Console.WriteLine("Digite o titulo do chamado");
                    titulo = "1"; //Console.ReadLine();
                    if (titulo.Length >= 1) { break; }
                }
                while (true)
                {
                    Console.WriteLine("Digite a descrição do chamado");
                    desc = "Celular Explodiu carregando"; //Console.ReadLine();
                    if (desc.Length >= 1) { break; }
                }
                while (true)
                {
                    Console.WriteLine("Digite o número do equipamento");
                    printArray(equip);
                    string equipStr = "1"; //Console.ReadLine();
                    if (int.TryParse(equipStr, out iEquip) && iEquip <= equip.Length && iEquip > 0) { break; }
                }
                while (true)
                {
                    Console.WriteLine("Digite a data de abertura do chamado");
                    string data_abStr = "27/04/2011"; //Console.ReadLine();
                    if (DateTime.TryParse(data_abStr, out data_ab)) { break; };
                }

                //AUMENTANDO O ARRAY E INSERINDO VALORES JÁ VALIDADOS
                Array.Resize(ref cham, cham.Length + 1);
                Chamados c = new Chamados(titulo, desc, equip[iEquip - 1], data_ab);
                if (e == -1) { cham[cham.Length - 1] = c; }
            }
        }
        public static void excluirEquip()
        {
            while (true)
            {
                Console.WriteLine("Digite o indice para exclusão ou digite 0 para cancelar");
                string opcao = "1"; //Console.ReadLine();
                printArray(equip);
                if (!int.TryParse(opcao, out int opcaoInt) || opcaoInt <= 0 || opcaoInt > equip.Length) { break; }
                else
                {
                    for (int i = opcaoInt; i < equip.Length; i++)
                    {
                        Equipamentos e = equip[i];
                        equip[i - 1] = e;
                    }
                    Array.Resize(ref equip, equip.Length - 1);
                    break;
                }
            }
        }
        public static void excluirCham()
        {
            while (true)
            {
                Console.WriteLine("Digite o indice para exclusão ou digite 0 para cancelar");
                string opcao = "1"; //Console.ReadLine();
                printArray(cham);
                if (!int.TryParse(opcao, out int opcaoInt) || opcaoInt <= 0 || opcaoInt > cham.Length) { break; }
                else
                {
                    for (int i = opcaoInt; i < cham.Length; i++)
                    {
                        Chamados c = cham[i];
                        cham[i - 1] = c;
                    }
                    Array.Resize(ref cham, cham.Length - 1);
                    break;
                }
            }
        }
        public static void edit(Object[] array)
        {
            while (true)
            {
                Console.WriteLine("Digite o indice para editar ou digite 0 para cancelar");
                string opcao = "1"; //Console.ReadLine();
                printArray(array);
                if (!int.TryParse(opcao, out int opcaoInt) || opcaoInt <= 0 || opcaoInt > cham.Length) { break; }
                else
                {
                    if (array.Equals(equip)) { cadastrarEquip(opcaoInt); break; }
                    else if (array.Equals(cham)) { cadastrarCham(opcaoInt); break; }
                }
            }
        }
    }
}

