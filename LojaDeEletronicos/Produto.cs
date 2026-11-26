using System;

namespace LojaDeEletronicos;

public class Produto
{
   public string Marca, Modelo;
    public int Codigo, Quantidade;
    public double Preco;

    public Produto(string marca, string modelo, int codigo, double preco, int quantidade)
    {
        Marca = marca;
        Modelo = modelo;
        Codigo = codigo;
        Preco = preco;
        Quantidade = quantidade;
    }

    public void Mostrar()
    {
        Console.WriteLine($"{Codigo,-5} | {Marca,-15} | {Modelo,-20} | {Preco,10:F2} | {Quantidade,5}");
    }
}