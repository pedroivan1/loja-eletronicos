using System;

namespace LojaDeEletronicos;

public class Estoque
{
    public List<Produto> Produtos = new List<Produto>();

    public void MostrarEstoque()
    {
        Cabecalho();
        foreach(Produto produto in Produtos)
        {
            produto.Mostrar();
        }
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public void Cabecalho()
    {
        Console.WriteLine($"{"COD",-9} | {"Marca",-21} | {"Modelo",-23}");
        Console.WriteLine(new string('-', 47));
    }
}