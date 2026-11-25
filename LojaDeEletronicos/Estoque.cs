using System;

namespace LojaDeEletronicos;

public class Estoque
{
    public List<Produto> Produtos = new List<Produto>();
    public int codigo = 1;

    public void MostrarEstoque()
    {
        if (Produtos.Count == 0) Utils.Mensagem("Estoque vazio.");
        else {
        Cabecalho();
        foreach(Produto produto in Produtos) produto.Mostrar();
        Utils.Aguardar(3000);
        }
    }

    public void AdicionarProduto(string marca, string modelo)
    {
        Produto produto = new Produto(marca, modelo, codigo);
        codigo++;
        Produtos.Add(produto);
    }

    public void Cabecalho()
    {
        Console.WriteLine($"{"COD",-9} | {"Marca",-21} | {"Modelo",-23}");
        Console.WriteLine(new string('-', 47));
    }

    public static void CadastrarProduto(Estoque estoque)
    {
        Console.Write("Qual a marca do produto? ");
        string marca = Console.ReadLine();

        Console.Write("Qual o modelo do produto? ");
        string modelo = Console.ReadLine();

        estoque.AdicionarProduto(marca, modelo);
        
        Utils.Mensagem($"O produto {marca} {modelo} foi adicionado com codigo {estoque.codigo - 1}");
    }

    public void RemoverProduto(Estoque estoque)
    {
        if (Produtos.Count == 0) Utils.Mensagem("Estoque vazio. ");
        else
        {
            estoque.MostrarEstoque();
            Console.Write("Digite o código do produto a ser removido: ");
            string input = Console.ReadLine();
            if (Utils.ReadInt(input))
            {
                Produtos.RemoveAt(int.Parse(input)-1);
                Utils.Mensagem("Produto removido.");
            }
            else Utils.Mensagem("Codigo invalido");
        }
        
    }

    public void LimparEstoque(Estoque estoque)
    {
        if (Produtos.Count == 0) Utils.Mensagem("Estoque vazio. ");
        else
        {
            for (int i = 0; i <= Produtos.Count; i++)
            {
                Produtos.RemoveAt(i);
            }
            Utils.Mensagem("Estoque foi limpo. ");
        }
    }
}