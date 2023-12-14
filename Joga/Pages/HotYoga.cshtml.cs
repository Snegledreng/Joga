using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages
{
    public class HotYogaModel : PageModel
    {
        private IHoldRepository _repo;
        public HotYogaModel(IHoldRepository repo)
        {
            _repo = repo;
        }

        //properties
        public Hold hotYoga { get; set; }
        public void OnGet()
        {
            hotYoga = _repo.HentHold(1);
        }
    }
}

