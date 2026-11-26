using System;

namespace LojaDeEletronicos;

public class Menu
{
    public static void Controle()
    {
        Console.WriteLine("[ 1 ]  Visualizar Estoque");
        Console.WriteLine("[ 2 ]  Adicionar Produto");
        Console.WriteLine("[ 3 ]  Remover Produto");
        Console.WriteLine("[ 4 ]  Buscar Produto");
        Console.WriteLine("[ 5 ]  Ordenar Estoque");
        Console.WriteLine("[ 6 ]  Selecionar Produto");
        Console.WriteLine("[ 7 ]  Limpar Estoque");
        Console.WriteLine("[ 8 ]  Sair");
        Console.Write("[ OPCAO ] > ");
    }
    public static void Cabecalho()
    {
        Console.WriteLine(new string('-', 47));
        Console.WriteLine("                     TED");
        Console.WriteLine(new string('-', 47));
    }
}