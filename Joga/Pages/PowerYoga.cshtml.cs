using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages
{
    public class PowerYogaModel : PageModel
    {
        private IHoldRepository _repo;
        public PowerYogaModel(IHoldRepository repo)
        {
            _repo = repo;
        }

        //properties
        public Hold powerYoga { get; set; }
        public void OnGet()
        {
            powerYoga = _repo.HentHold(2);
        }
    }
}

