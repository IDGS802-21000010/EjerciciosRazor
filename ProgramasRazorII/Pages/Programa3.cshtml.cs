using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgramasRazorII.Pages
{
    public class Programa3Model : PageModel
    {
        [BindProperty]
        public string va { get; set; } = "";
        [BindProperty]
        public string vb { get; set; } = "";
        [BindProperty]
        public string vx { get; set; } = "";
        [BindProperty]
        public string vy { get; set; } = "";
        [BindProperty]
        public string vn { get; set; } = "";

        public double k = 0.0;
        public double res = 0.0;
        public double res2 = 0.0;
        public double exp = 0.0;
        public double sum = 0;

        public void OnPost()
        {
            double a = Convert.ToDouble(va);
            double b = Convert.ToDouble(vb);
            double x = Convert.ToDouble(vx);
            double y = Convert.ToDouble(vy);
            double n = Convert.ToDouble(vn);

            //Primer Metodo
            res = Math.Pow(((a * x) + (b * y)), n);

            //Segundo Metodo
            {
                while (k <= n)
                {
                    exp = (Factorial(n) / (Factorial((k)) * (Factorial((n - k)))));
                    sum = ((exp) * (Math.Pow((a * x), n - k)) * (Math.Pow((b * y), k)));
                    res2 = res2 + sum;
                    k++;
                }
            }

            ModelState.Clear();
        }
        public double Factorial(double numero)
        {
            if (numero == 0) return 1;

            double resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

    }
}
