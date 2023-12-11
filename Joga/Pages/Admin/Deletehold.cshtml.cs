using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages.Admin
{
    public class DeleteholdModel : PageModel
    {
        private HoldRepository _repo;
        public DeleteholdModel(HoldRepository repo)
        {
            _repo = repo;
        }

        //properties
        public List<Hold> Hold { get; set; }
        public IActionResult OnGet(int nummer)
        {
            Hold = _repo.HentAlleHold();
            //_repo.SletHold(nummer);
            return RedirectToPage("Admin/Holdliste");
            
        }
    }
}
