using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages.Admin
{
    public class MedlemslisteModel : PageModel
    {
        private MedlemRepository _repo;
        public MedlemslisteModel(MedlemRepository repo)
        {
            _repo = repo;
        }

        //properties
        public List<Medlem> Medlemmer { get; set; }
        public void OnGet()
        {
            Medlemmer = _repo.HentAlleMedlemmer();
        }
    }
}
