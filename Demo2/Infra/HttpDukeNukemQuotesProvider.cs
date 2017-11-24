using Domain;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Infra
{
    public class HttpDukeNukemQuotesProvider : IDukeNukemQuotesProvider
    {
        private readonly string uri;
        private readonly ILogger<HttpDukeNukemQuotesProvider> logger;

        public HttpDukeNukemQuotesProvider(string uri,
            ILogger<HttpDukeNukemQuotesProvider> logger)
        {
            this.uri = uri;
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<string>> GetAllQuotes()
        {
            this.logger.LogInformation("Meking call to {0}", this.uri);

            using (var client = new HttpClient())
            {
                var result = await client.GetStringAsync(this.uri);
                var content = JsonConvert.DeserializeObject<Content>(result);
                return content.Quotes;
            }
        }

        class Content
        {
            public string[] Quotes { get; set; }
        }
    }
}
