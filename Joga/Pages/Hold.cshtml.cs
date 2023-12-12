using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages
{
    public class HoldListeModel : PageModel
    {
        private HoldRepository _repo;
        public HoldListeModel(HoldRepository repo)
        {
            _repo = repo;
        }

        //properties
        public List<Hold> Hold { get; set; }

        [BindProperty]
        public int MedlemsId { get; set; }
        
        //onget funktioner
        public void OnGet()
        {
            Hold = _repo.HentAlleHold();
        }

        //onpost funktioner
        //public IActionResult OnPost()
        //{

        //}

    }
}