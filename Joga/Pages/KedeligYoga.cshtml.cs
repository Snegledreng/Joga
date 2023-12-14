using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages
{
    public class KedeligYogaModel : PageModel
    {
        private IHoldRepository _repo;
        public KedeligYogaModel(IHoldRepository repo)
        {
            _repo = repo;
        }

        //properties
        public Hold kedeligYoga { get; set; }
        public void OnGet()
        {
            kedeligYoga = _repo.HentHold(3);
        }
    }
}

