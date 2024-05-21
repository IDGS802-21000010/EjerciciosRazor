using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgramasRazorII.Pages
{
    public class Programa4Model : PageModel
    {
        public int[] numerosAleatorios = new int[20];
        public double suma;
        public double media;
        public int moda;
        public int mediana;
        public void OnGet()
        {
            Random random = new Random();
            for (int i = 0; i < numerosAleatorios.Length; i++)
            {
                numerosAleatorios[i] = random.Next(0, 101);
            }

            suma = numerosAleatorios.Sum();

            media = suma / numerosAleatorios.Length;

            moda = numerosAleatorios.GroupBy(n => n)
                                    .OrderByDescending(g => g.Count())
                                    .Select(g => g.Key)
                                    .FirstOrDefault();

            Array.Sort(numerosAleatorios);
            if (numerosAleatorios.Length % 2 == 0)
            {
                mediana = (numerosAleatorios[numerosAleatorios.Length / 2] + numerosAleatorios[numerosAleatorios.Length / 2 - 1]) / 2;
            }
            else
            {
                mediana = numerosAleatorios[numerosAleatorios.Length / 2];
            }
        }
    }
}
