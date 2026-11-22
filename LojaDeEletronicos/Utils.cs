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

    public static void Erro(string mensagem)
    {
        Console.WriteLine(mensagem);
        Menu.Aguardar(1500);
    }
}