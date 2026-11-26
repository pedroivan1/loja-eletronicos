using System;

namespace LojaDeEletronicos;

public class BuscaPorCod
{
    public static Produto BSequencial(List<Produto> produtos, int codigo)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            if (produtos[i].Codigo == codigo) return produtos[i];
        }
        return null;
    }

    public static void Buscar(Estoque estoque)
    {
        if (estoque.Produtos.Count == 0) Utils.Mensagem("Estoque vazio.");
        else
        {
            Console.Write("Digite o codigo do produto: ");
            string input = Console.ReadLine();

            if (Utils.ReadInt(input))
            {
                Produto produto = BSequencial(estoque.Produtos, int.Parse(input));

                if (produto != null)
                {
                    estoque.Cabecalho();
                    produto.Mostrar();
                    Utils.Aguardar(3000);
                }
                else Utils.Mensagem("Produto nao encontrado.");
            }
            else Utils.Mensagem("Codigo invalido.");
        }
    }
}

public class BuscaPorMarca
{
    public static List<Produto> Sequencial(List<Produto> produtos, string marca)
    {
        List<Produto> encontrados = new List<Produto>();

        for (int i = 0; i < produtos.Count; i++)
        {
            if (string.Equals(produtos[i].Marca, marca, StringComparison.OrdinalIgnoreCase))
                encontrados.Add(produtos[i]);
        }
        return encontrados;
    }

    public static void Buscar(Estoque estoque)
    {
        if (estoque.Produtos.Count == 0) Utils.Mensagem("Estoque vazio.");
        else
        {
            Console.Write("Digite a marca do produto: ");
            string marca = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(marca))
            {
                List<Produto> encontrados = Sequencial(estoque.Produtos, marca.Trim());

                if (encontrados.Count > 0)
                {
                    estoque.Cabecalho();
                    foreach (Produto produto in encontrados) produto.Mostrar();
                    Utils.Aguardar(3000);
                }
                else Utils.Mensagem("Nenhum produto encontrado.");
            }
            else Utils.Mensagem("Marca invalida.");
        }
    }
}

public class BuscaPorModelo
{
    public static List<Produto> Sequencial(List<Produto> produtos, string modelo)
    {
        List<Produto> encontrados = new List<Produto>();

        for (int i = 0; i < produtos.Count; i++)
        {
            if (string.Equals(produtos[i].Modelo, modelo, StringComparison.OrdinalIgnoreCase))
                encontrados.Add(produtos[i]);
        }
        return encontrados;
    }

    public static void Buscar(Estoque estoque)
    {
        if (estoque.Produtos.Count == 0) Utils.Mensagem("Estoque vazio.");
        else
        {
            Console.Write("Digite o modelo do produto: ");
            string modelo = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(modelo))
            {
                List<Produto> encontrados = Sequencial(estoque.Produtos, modelo.Trim());

                if (encontrados.Count > 0)
                {
                    estoque.Cabecalho();
                    foreach (Produto produto in encontrados) produto.Mostrar();
                    Utils.Aguardar(3000);
                }
                else Utils.Mensagem("Nenhum produto encontrado.");
            }
            else Utils.Mensagem("Modelo invalido.");
        }
    }
}