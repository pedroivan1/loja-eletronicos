using System;

namespace LojaDeEletronicos;

public class Menu
{
    public static void Controle()
    {
        Console.WriteLine("[ 1 ]  Vizualizar Estoque");
        Console.WriteLine("[ 2 ]  Adicionar Produto");
        Console.WriteLine("[ 3 ]  Remover Produto");
        Console.WriteLine("[ 4 ]  Buscar Produto");
        Console.WriteLine("[ 5 ]  Limpar Estoque");
        Console.WriteLine("[ 6 ]  Sair");
        Console.Write("[ OPCAO ] > ");
    }
    public static void Cabecalho()
    {
        Console.WriteLine(new string('-', 47));
        Console.WriteLine("                     TED");
        Console.WriteLine(new string('-', 47));
    }
}