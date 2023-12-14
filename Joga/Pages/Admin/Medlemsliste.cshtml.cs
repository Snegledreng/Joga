using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages.Admin
{
    public class MedlemslisteModel : PageModel
    {
        private IMedlemRepository _repo;
        public MedlemslisteModel(IMedlemRepository repo)
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
