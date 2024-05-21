using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgramasRazorII.Pages
{
    public class Programa2Model : PageModel
    {
        [BindProperty]
        public string mensaje { get; set; } = "";

        [BindProperty]
        public int n { get; set; }

        [BindProperty]
        public string res { get; set; } = "";

        public void OnPostCifrar()
        {
            res = CifradoCesar(mensaje, n);
        }

        public void OnPostDescifrar()
        {
            res = CifradoCesar(mensaje, -n);
        }

        private string CifradoCesar(string mensaje, int n)
        {
            char[] texto = mensaje.ToUpper().ToCharArray();
            for (int i = 0; i < texto.Length; i++)
            {
                char letra = texto[i];
                if (char.IsLetter(letra))
                {
                    char inicio = 'A';
                    letra = (char)((letra + n - inicio) % 26 + inicio);
                    if (letra < 'A')
                    {
                        letra = (char)(letra + 26);
                    }
                    texto[i] = letra;
                }
            }
            return new string(texto);
        }
    }
}
