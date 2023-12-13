using Joga.model;
using Joga.Pages.Admin;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages
{
    public class HoldModel : PageModel
    {
        private HoldRepository _repo;
        private MedlemRepository _repo2;
        public HoldModel(HoldRepository repo, MedlemRepository repo2)
        {
            _repo = repo;
            _repo2 = repo2;
        }


        //properties
        public List<Hold> Hold { get; set; }

        [BindProperty]
        public int MedlemsId { get; set; }

        [BindProperty]
        public List<Medlem> HoldMedlemsListe { get; set; }

        //onget funktioner
        public void OnGet()
        {
            Hold = _repo.HentAlleHold();
        }

        //onpost funktioner
        public IActionResult OnPostTilmeld(int holdNummer)
        {
            try
            {
                Hold yogaHold = _repo.HentHold(holdNummer);
                yogaHold.holdMedlemListe.Add(_repo2.HentMedlem(MedlemsId));
                Hold = _repo.HentAlleHold();

                return Page();
            }
            catch 
            {
                throw new Exception();
            }
        }

    }
}