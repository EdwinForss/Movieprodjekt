using System;
using System.Threading.Tasks;

namespace Movieprodjekt
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Menu1.PrintFirstMenu().ConfigureAwait(false);

        }
    }
}
