using System;

namespace LojaDeEletronicos;

class Program
{
    static void Main()
    {
        Estoque estoque = new Estoque();
        Dados.Carregar(estoque);
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
                    estoque.CadastrarProduto();
                    break;
                case "3": // Remover Produto
                    Utils.Limpar();
                    estoque.RemoverProduto();
                    break;
                case "4": // Buscar Produto
                    Utils.Limpar();
                    Console.WriteLine("[ 1 ]  Buscar por Codigo");
                    Console.WriteLine("[ 2 ]  Buscar por Marca");
                    Console.WriteLine("[ 3 ]  Buscar por Modelo");
                    Console.Write("[ OPCAO ] > ");
                    string inputBusca = Console.ReadLine();

                    if (inputBusca == "1") BuscaPorCod.Buscar(estoque);
                    else if (inputBusca == "2") BuscaPorMarca.Buscar(estoque);
                    else if (inputBusca == "3") BuscaPorModelo.Buscar(estoque);
                    else Utils.Mensagem("Opcao invalida.");
                    break;
                case "5": // Ordenar Estoque
                    Utils.Limpar();
                    Ordenacao.Ordenar(estoque);
                    break;
                case "6": // Selecionar Produto
                    Utils.Limpar();
                    Selecao.Selecionar(estoque);
                    break;
                case "7": // Limpar Estoque
                    estoque.LimparEstoque();
                    break;
                case "8": // Sair
                    return;
                }
            }
            else Utils.Mensagem("Opcao invalida. ");     
        }
        while(loop);
    }
}