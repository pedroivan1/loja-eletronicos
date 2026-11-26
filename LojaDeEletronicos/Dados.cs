using System;

namespace LojaDeEletronicos;

public class Dados
{
    public static void Carregar(Estoque estoque)
    {
        estoque.AdicionarProduto("AMD", "Ryzen 5 5600", 899.90, 10);
        estoque.AdicionarProduto("AMD", "Ryzen 7 5700X", 1299.00, 6);
        estoque.AdicionarProduto("AMD", "Ryzen 9 7900X", 2499.90, 3);
        estoque.AdicionarProduto("Intel", "Core i5-12400F", 949.90, 8);
        estoque.AdicionarProduto("Intel", "Core i7-13700K", 2399.00, 4);
        estoque.AdicionarProduto("Intel", "Core i9-14900K", 3799.00, 2);
        estoque.AdicionarProduto("NVIDIA", "RTX 4060", 1899.00, 5);
        estoque.AdicionarProduto("NVIDIA", "RTX 4070", 3699.00, 3);
        estoque.AdicionarProduto("NVIDIA", "RTX 4090", 12999.00, 1);
        estoque.AdicionarProduto("AMD", "RX 7600", 1699.00, 7);
        estoque.AdicionarProduto("Kingston", "Fury 16GB DDR4", 329.90, 25);
        estoque.AdicionarProduto("Kingston", "NV2 1TB NVMe", 369.00, 18);
        estoque.AdicionarProduto("Corsair", "Vengeance 32GB DDR5", 749.90, 12);
        estoque.AdicionarProduto("Corsair", "RM750e 750W", 699.00, 9);
        estoque.AdicionarProduto("Samsung", "980 Pro 1TB", 599.00, 14);
        estoque.AdicionarProduto("Samsung", "Odyssey G5 27", 1599.00, 6);
        estoque.AdicionarProduto("Logitech", "G203", 119.90, 40);
        estoque.AdicionarProduto("Logitech", "G Pro X", 899.00, 11);
        estoque.AdicionarProduto("Asus", "TUF B550M", 849.00, 8);
        estoque.AdicionarProduto("Asus", "ROG Strix Z790", 2799.00, 3);
    }
}