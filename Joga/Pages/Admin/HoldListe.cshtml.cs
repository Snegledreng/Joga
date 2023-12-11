using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages.Admin
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
        public void OnGet()
        {
            Hold = _repo.HentAlleHold();
        }
    }
}