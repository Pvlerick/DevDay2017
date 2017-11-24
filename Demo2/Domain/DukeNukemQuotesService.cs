using System;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class DukeNukemQuotesService
    {
        private readonly IDukeNukemQuotesProvider dukeNukemQuotesProvider;

        public DukeNukemQuotesService(IDukeNukemQuotesProvider dukeNukemQuotesProvider)
        {
            this.dukeNukemQuotesProvider = dukeNukemQuotesProvider ?? throw new ArgumentNullException(nameof(dukeNukemQuotesProvider));
        }

        public async Task<string> GetRandomQuote()
        {
            var quotes = (await this.dukeNukemQuotesProvider.GetAllQuotes()).ToArray();
            var random = new Random();
            return $"Duke says: {quotes[random.Next(quotes.Length)]}";
        }
    }
}
