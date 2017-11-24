using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Interceptors
{
    public class DukeNukemQuotesProviderCacheDecorator : IDukeNukemQuotesProvider
    {
        private readonly IDukeNukemQuotesProvider inner;
        private IEnumerable<string> cache;

        public DukeNukemQuotesProviderCacheDecorator(IDukeNukemQuotesProvider inner)
        {
            this.inner = inner ?? throw new ArgumentNullException(nameof(inner));
        }

        public async Task<IEnumerable<string>> GetAllQuotes()
        {
            if (this.cache == null)
                this.cache = await this.inner.GetAllQuotes();

            return this.cache;
        }
    }
}
