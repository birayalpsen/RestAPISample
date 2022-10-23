using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    public class Utils
    {
        public static int GetTotalPageCount(string apiUrl)
        {
            int totalPageCount = 0;

            using (WebClient wc = new WebClient())
            {
                dynamic obj = JsonConvert.DeserializeObject(wc.DownloadString(apiUrl));
                totalPageCount = Convert.ToInt32(obj.total_pages);
            }

            return totalPageCount;
        }
    }
}
