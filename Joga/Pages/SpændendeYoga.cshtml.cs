using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages
{
    public class SpændendeYogaModel : PageModel
    {
        private IHoldRepository _repo;
        public SpændendeYogaModel(IHoldRepository repo)
        {
            _repo = repo;
        }

        //properties
        public Hold spændendeYoga { get; set; }
        public void OnGet()
        {
            spændendeYoga = _repo.HentHold(4);
        }
    }
}

