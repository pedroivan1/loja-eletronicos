# Loja de Eletronicos

Sistema de gerenciamento de estoque de uma loja de eletronicos, desenvolvido em C# (console), com aplicacao de algoritmos de busca, selecao e ordenacao sobre uma estrutura de dados linear.

## Integrantes

- [Seu nome completo]
- [Nome completo do colega]

## Sobre o projeto

O programa permite cadastrar, listar, remover, buscar, ordenar e selecionar produtos de uma loja de eletronicos. Cada produto possui codigo (gerado automaticamente), marca, modelo, preco e quantidade em estoque.

A estrutura de dados linear utilizada e a lista (`List<Produto>`).

## Algoritmos aplicados

| Tipo | Parametro 1 | Parametro 2 |
|---|---|---|
| Busca | Busca por codigo | Busca por marca (e por modelo) |
| Selecao | Menor preco | Maior preco |
| Ordenacao | Bubble Sort | Merge Sort |

- **Busca:** busca sequencial percorrendo a lista, por codigo, marca ou modelo.
- **Selecao:** percorre a lista para encontrar o produto mais barato e o mais caro.
- **Ordenacao:** Bubble Sort e Merge Sort, ambos implementados manualmente, com criterio de ordenacao por codigo, marca, modelo ou preco.

## Funcionalidades

1. Visualizar estoque
2. Adicionar produto
3. Remover produto
4. Buscar produto
5. Ordenar estoque
6. Selecionar produto (mais barato ou mais caro)
7. Limpar estoque
8. Sair

## Tecnologias

- C# / .NET
- Visual Studio Code
- Git e GitHub

## Como executar

Pre-requisito: [.NET SDK](https://dotnet.microsoft.com/download) instalado.

```bash
git clone [link do repositorio]
cd [nome-da-pasta]
dotnet run --project LojaDeEletronicos
```

## Estrutura do projeto

```
LojaDeEletronicos/
├── Program.cs     (ponto de entrada e menu principal)
├── Menu.cs        (exibicao do menu)
├── Produto.cs     (classe Produto)
├── Estoque.cs     (lista de produtos e operacoes)
├── Dados.cs       (produtos de exemplo)
├── Busca.cs       (algoritmos de busca)
├── Ordenacao.cs   (Bubble Sort e Merge Sort)
├── Selecao.cs     (menor e maior preco)
└── Utils.cs       (funcoes auxiliares)
```