using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Joga.Pages
{
    public class OpretMedlemModel : PageModel

        
    {
        private IMedlemRepository _repo;
        public OpretMedlemModel(IMedlemRepository repo)
        {
            _repo = repo;
        }


        [BindProperty]
        public int NyId { get; set; }

        [BindProperty]
        [Required]
        public string NyNavn { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [BindProperty]
        public string NyEmail { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(8)]
        [Required]
        [BindProperty]
        public string NyTlf { get; set; }

        [BindProperty]
        public bool NyNyhedsbrev { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Medlem m = new Medlem(NyId, NyNavn, NyEmail, NyTlf, true, NyNyhedsbrev);
            _repo.TilføjMedlem(m);
            return RedirectToPage("/Admin/Medlemsliste");
        }
    }
}
