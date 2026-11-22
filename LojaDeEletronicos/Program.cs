using System;

namespace LojaDeEletronicos;

class Program
{
    static void Main()
    {
        bool loop = true;

        do
        {
            Menu.Limpar();

            Menu.Cabecalho();

            Estoque estoque = new Estoque();

            Menu.Controle();

            string input = Console.ReadLine();

            if (Utils.ReadInt(input))
            {
                switch (input)
                {
                case "1": // Vizualizar Estoque
                    break;
                case "2": // Adicionar Produto
                    break;
                case "3": // Remover Produto
                    break;
                case "4": // Buscar Produto
                    break;
                case "5": // Limpar Estoque
                    break;
                case "6": // Sair
                    return;
                }
            }
            else Utils.Erro("Opcao invalida. ");     
        }
        while(loop);
    }
}