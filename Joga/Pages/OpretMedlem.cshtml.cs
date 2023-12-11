using Joga.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages
{
    public class OpretMedlemModel : PageModel
    {
        [BindProperty]
        public int NyId { get; set; }

        [BindProperty]
        public string NyNavn { get; set; }

        [BindProperty]
        public string NyEmail { get; set; }

        [BindProperty]
        public string NyTlf { get; set; }

        [BindProperty]
        public bool NyNyhedsbrev { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Medlem nyMedlem = new Medlem(NyId, NyNavn, NyEmail, NyTlf, true, NyNyhedsbrev);
            MedlemList.TilføjMedlem(nyMedlem);
            return Page();
        }
    }
}
