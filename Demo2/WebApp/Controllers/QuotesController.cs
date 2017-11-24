using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
        private readonly DukeNukemQuotesService dukeNukemQuotesService;

        public QuotesController(DukeNukemQuotesService dukeNukemQuotesService)
        {
            this.dukeNukemQuotesService = dukeNukemQuotesService ?? throw new ArgumentNullException(nameof(dukeNukemQuotesService));
        }

        [HttpGet]
        public async Task<string> Get() => await this.dukeNukemQuotesService.GetRandomQuote();
    }
}
