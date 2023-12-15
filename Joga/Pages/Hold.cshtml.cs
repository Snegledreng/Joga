using Joga.model;
using Joga.Pages.Admin;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages
{
    public class HoldModel : PageModel
    {
        private IHoldRepository _repo;
        private IMedlemRepository _repo2;
        public HoldModel(IHoldRepository repo,  IMedlemRepository repo2)
        {
            _repo = repo;
            _repo2 = repo2;
        }


        //properties
        public List<Hold> Hold { get; set; }
        public string ErrorMessage { get; set; }

        [BindProperty]
        public int MedlemsId { get; set; }

        [BindProperty]
        public List<Medlem> HoldMedlemsListe { get; set; }

        //onget funktioner
        public void OnGet()
        {
            Hold = _repo.HentAlleHold();
            ErrorMessage = string.Empty;
        }

        //onpost funktioner
        public IActionResult OnPostTilmeld(int holdNummer)
        {
            try
            {
                Hold yogaHold = _repo.HentHold(holdNummer);
                yogaHold.holdMedlemListe.Add(_repo2.HentMedlem(MedlemsId));
            }
            catch (Exception e) 
            {
                ErrorMessage = e.Message;
            }
            Hold = _repo.HentAlleHold();
            return Page();

        }
    }
}