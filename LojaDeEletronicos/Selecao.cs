using System;

namespace LojaDeEletronicos;

public class Selecao
{
    public static Produto MenorPreco(List<Produto> produtos)
    {
        Produto menor = produtos[0];

        for (int i = 1; i < produtos.Count; i++)
        {
            if (produtos[i].Preco < menor.Preco) menor = produtos[i];
        }
        return menor;
    }

    public static Produto MaiorPreco(List<Produto> produtos)
    {
        Produto maior = produtos[0];

        for (int i = 1; i < produtos.Count; i++)
        {
            if (produtos[i].Preco > maior.Preco) maior = produtos[i];
        }
        return maior;
    }

    public static void Selecionar(Estoque estoque)
    {
        if (estoque.Produtos.Count == 0) Utils.Mensagem("Estoque vazio.");
        else
        {
            Console.WriteLine("[ 1 ]  Produto mais barato");
            Console.WriteLine("[ 2 ]  Produto mais caro");
            Console.Write("[ OPCAO ] > ");
            string input = Console.ReadLine();

            Produto produto = null;

            if (input == "1") produto = MenorPreco(estoque.Produtos);
            else if (input == "2") produto = MaiorPreco(estoque.Produtos);
            else Utils.Mensagem("Opcao invalida.");

            if (produto != null)
            {
                estoque.Cabecalho();
                produto.Mostrar();
                Utils.Aguardar(3000);
            }
        }
    }
}