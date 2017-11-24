using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDukeNukemQuotesProvider
    {
        Task<IEnumerable<string>> GetAllQuotes();
    }
}