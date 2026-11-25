using System;
using System.Globalization;

namespace LojaDeEletronicos;

public class Utils
{
    public static bool ReadInt(string input)
    {
        if (int.TryParse(input, CultureInfo.InvariantCulture, out int output))
        {
            return true;
        }
        else return false;
    }

    public static void Mensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
        Aguardar(1500);
    }

        public static void Limpar()
    {
        Console.Clear();
    }

    public static void Aguardar(int ms)
    {
        Thread.Sleep(ms);
    }
}