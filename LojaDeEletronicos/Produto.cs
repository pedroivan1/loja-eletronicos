using System;

namespace LojaDeEletronicos;

public class Produto
{
    public string Marca, Modelo;
    public int Codigo;

    public Produto(string marca, string modelo, int codigo){
        Marca = marca;
        Modelo = modelo;
        Codigo = codigo;
    }

    public void Mostrar()
    {
        Console.WriteLine($"COD {Codigo, -5} | Marca {Marca, -15} | Modelo {Modelo, -15}");
    }
}