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

        public Medlem Medlem { get; set; }
        public Hold Hold2 { get; set; }

        //properties
        public List<Hold> Hold { get; set; }

        [BindProperty]
        public int MedlemsId { get; set; }

        [BindProperty]
        public Hold Tilmeld { get; set; }
        
        //onget funktioner
        public void OnGet()
        {
            Hold = _repo.HentAlleHold();
        }

        //onpost funktioner
        //public IActionResult OnPostTilmeld(MedlemsId)
        //{
        //    Tilmeld.Add(MedlemRepository.HentMedlem(MedlemsId));
        //}

    }
}