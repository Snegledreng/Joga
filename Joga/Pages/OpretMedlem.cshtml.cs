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
    }
}
