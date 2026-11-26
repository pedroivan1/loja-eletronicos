using System;

namespace LojaDeEletronicos;

public class Ordenacao
{
    public static int Comparar(Produto a, Produto b, int criterio)
    {
        switch (criterio)
        {
            case 1: return a.Codigo.CompareTo(b.Codigo);
            case 2: return string.Compare(a.Marca, b.Marca, StringComparison.OrdinalIgnoreCase);
            case 3: return string.Compare(a.Modelo, b.Modelo, StringComparison.OrdinalIgnoreCase);
            default: return a.Preco.CompareTo(b.Preco);
        }
    }

    public static void Bubble(List<Produto> produtos, int criterio)
    {
        for (int i = 0; i < produtos.Count - 1; i++)
        {
            bool trocou = false;

            for (int j = 0; j < produtos.Count - 1 - i; j++)
            {
                if (Comparar(produtos[j], produtos[j + 1], criterio) > 0)
                {
                    Produto temp = produtos[j];
                    produtos[j] = produtos[j + 1];
                    produtos[j + 1] = temp;
                    trocou = true;
                }
            }
            if (!trocou) break; 
        }
    }

    public static List<Produto> Merge(List<Produto> produtos, int criterio)
    {
        if (produtos.Count <= 1) return produtos;

        int meio = produtos.Count / 2;
        List<Produto> esquerda = Merge(produtos.GetRange(0, meio), criterio);
        List<Produto> direita = Merge(produtos.GetRange(meio, produtos.Count - meio), criterio);

        List<Produto> resultado = new List<Produto>();
        int e = 0, d = 0;

        while (e < esquerda.Count && d < direita.Count)
        {
            if (Comparar(esquerda[e], direita[d], criterio) <= 0) resultado.Add(esquerda[e++]);
            else resultado.Add(direita[d++]);
        }
        while (e < esquerda.Count) resultado.Add(esquerda[e++]);
        while (d < direita.Count) resultado.Add(direita[d++]);

        return resultado;
    }

    // Interacao com o usuario
    public static void Ordenar(Estoque estoque)
    {
        if (estoque.Produtos.Count == 0) { Utils.Mensagem("Estoque vazio."); return; }

        Console.WriteLine("[ 1 ]  Bubble Sort");
        Console.WriteLine("[ 2 ]  Merge Sort");
        Console.Write("[ ALGORITMO ] > ");
        string algoritmo = Console.ReadLine();
        if (algoritmo != "1" && algoritmo != "2") { Utils.Mensagem("Opcao invalida."); return; }

        Console.WriteLine("[ 1 ]  Codigo");
        Console.WriteLine("[ 2 ]  Marca");
        Console.WriteLine("[ 3 ]  Modelo");
        Console.WriteLine("[ 4 ]  Preco");
        Console.Write("[ CRITERIO ] > ");
        string inputCriterio = Console.ReadLine();
        if (!Utils.ReadInt(inputCriterio) || int.Parse(inputCriterio) < 1 || int.Parse(inputCriterio) > 4)
        {
            Utils.Mensagem("Opcao invalida.");
            return;
        }
        int criterio = int.Parse(inputCriterio);

        if (algoritmo == "1") Bubble(estoque.Produtos, criterio);
        else estoque.Produtos = Merge(estoque.Produtos, criterio);

        Utils.Limpar();
        estoque.MostrarEstoque();
    }
}