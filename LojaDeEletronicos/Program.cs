using System;

namespace LojaDeEletronicos;

class Program
{
    static void Main()
    {
        Estoque estoque = new Estoque();
        bool loop = true;

        do
        {
            Utils.Limpar();

            Menu.Cabecalho();

            Menu.Controle();

            string input = Console.ReadLine();

            if (Utils.ReadInt(input))
            {
                switch (input)
                {
                case "1": // Vizualizar Estoque
                    Utils.Limpar();
                    estoque.MostrarEstoque();
                    break;
                case "2": // Adicionar Produto
                    Estoque.CadastrarProduto(estoque);
                    break;
                case "3": // Remover Produto
                    Utils.Limpar();
                    estoque.RemoverProduto(estoque);
                    break;
                case "4": // Buscar Produto
                    Console.WriteLine("Vizualizar");
                    break;
                case "5": // Limpar Estoque
                    estoque.LimparEstoque(estoque);
                    break;
                case "6": // Sair
                    return;
                default:
                    Utils.Mensagem("Opcao invalida.");
                    break;
                }
            }
            else Utils.Mensagem("Opcao invalida. ");     
        }
        while(loop);
    }
}