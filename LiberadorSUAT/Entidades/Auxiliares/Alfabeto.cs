using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberadorSUAT.Entidades.Auxiliares
{
    public class Alfabeto
    {
        public string[] alfabeto = new string[26] {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k","l", "m", 
                "n", "o", "p", "q", "r", "s", "t", "u", "v", "x","w", "y", "z"};

        public string proximaLetra = "";

        public string proximaLetraAlfabeto(string x)
        {
            foreach (var letra in alfabeto)
            {
                if (x == letra)
                {
                    int indice = Array.IndexOf(alfabeto, letra);
                    proximaLetra = alfabeto[indice + 1];
                }
            }
            return proximaLetra;
        }
    }
}
