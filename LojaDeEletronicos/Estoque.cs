using System;

namespace LojaDeEletronicos;

public class Estoque
{
    public List<Produto> Produtos = new List<Produto>();
    private int proximoCodigo = 1;

    public Produto AdicionarProduto(string marca, string modelo, double preco, int quantidade)
    {
        Produto produto = new Produto(marca, modelo, proximoCodigo, preco, quantidade);
        proximoCodigo++;
        Produtos.Add(produto);
        return produto;
    }

    public void Cabecalho()
    {
        Console.WriteLine($"{"COD",-5} | {"Marca",-15} | {"Modelo",-20} | {"Preco",10} | {"Qtd",5}");
        Console.WriteLine(new string('-', 67));
    }

    public void ListarProdutos()
    {
        Cabecalho();
        foreach (Produto produto in Produtos) produto.Mostrar();
    }

    public void MostrarEstoque()
    {
        if (Produtos.Count == 0) Utils.Mensagem("Estoque vazio.");
        else
        {
            ListarProdutos();
            Utils.Aguardar(3000);
        }
    }

    public void CadastrarProduto()
    {
        Console.Write("Qual a marca do produto? ");
        string marca = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(marca)) { Utils.Mensagem("Marca invalida."); return; }

        Console.Write("Qual o modelo do produto? ");
        string modelo = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(modelo)) { Utils.Mensagem("Modelo invalido."); return; }

        Console.Write("Qual o preco do produto? ");
        if (!Utils.ReadDouble(Console.ReadLine(), out double preco) || preco < 0)
        {
            Utils.Mensagem("Preco invalido.");
            return;
        }

        Console.Write("Qual a quantidade em estoque? ");
        string inputQtd = Console.ReadLine();
        if (!Utils.ReadInt(inputQtd) || int.Parse(inputQtd) < 0)
        {
            Utils.Mensagem("Quantidade invalida.");
            return;
        }

        Produto produto = AdicionarProduto(marca.Trim(), modelo.Trim(), preco, int.Parse(inputQtd));
        Utils.Mensagem($"O produto {produto.Marca} {produto.Modelo} foi adicionado com codigo {produto.Codigo}");
    }

    public void RemoverProduto()
    {
        if (Produtos.Count == 0) { Utils.Mensagem("Estoque vazio."); return; }

        ListarProdutos();
        Console.Write("Digite o codigo do produto a ser removido: ");
        string input = Console.ReadLine();

        if (Utils.ReadInt(input))
        {
            int cod = int.Parse(input);
            for (int i = 0; i < Produtos.Count; i++)
            {
                if (Produtos[i].Codigo == cod)
                {
                    Produtos.RemoveAt(i);
                    Utils.Mensagem("Produto removido.");
                    return;
                }
            }
            Utils.Mensagem("Produto nao encontrado.");
        }
        else Utils.Mensagem("Codigo invalido.");
    }

    public void LimparEstoque()
    {
        if (Produtos.Count == 0) Utils.Mensagem("Estoque vazio.");
        else
        {
            Console.Write("Tem certeza que deseja limpar o estoque? (S/N) ");
            string resposta = Console.ReadLine();

            if (resposta != null && resposta.Trim().ToUpper() == "S")
            {
                Produtos.Clear();
                Utils.Mensagem("Estoque foi limpo.");
            }
            else Utils.Mensagem("Operacao cancelada.");
        }
    }
}