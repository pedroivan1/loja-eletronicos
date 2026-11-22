using System;

namespace LojaDeEletronicos;

class Program
{
    static void Main()
    {
        Estoque estoque = new Estoque();

        estoque.AdicionarProduto(new Produto("AMD", "Ryzen 5 5600", 1));
        estoque.AdicionarProduto(new Produto("Intel", "I9 9900K", 2));
        estoque.MostrarEstoque();
    }
}