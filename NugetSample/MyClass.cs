using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NugetSample
{
   public class MyClass
    {
        async Task DownloadAsyn()
        {
            HttpClient httclient = new HttpClient();

            await httclient.GetStringAsync("");
        }
    }
}
