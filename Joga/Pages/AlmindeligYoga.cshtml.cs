using Joga.model;
using Joga.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joga.Pages
{
    public class AlmindeligYogaModel : PageModel
    {
        private IHoldRepository _repo;
        public AlmindeligYogaModel(IHoldRepository repo)
        {
            _repo = repo;
        }

        //properties
        public Hold almindeligYoga { get; set; }
        public void OnGet()
        {
            almindeligYoga = _repo.HentHold(5);
        }
    }
}

