using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgramasRazorII.Pages
{
    public class Programa1Model : PageModel
    {
        //Propiedades
        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]
        public string altura { get; set; } = "";

        public double imc = 0;

        public void OnPost()
        {
            double p = Convert.ToDouble(peso);
            double a = Convert.ToDouble(altura);

            imc = p / (a*a);

            ModelState.Clear();
        }
    }
}
