using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RestAPI
{
    public class Result
    {

        /*
         * Complete the 'getRelevantFoodOutlets' function below.
         *
         * URL for cut and paste
         * https://jsonmock.hackerrank.com/api/food_outlets?city=<city>&page=<pageNumber>
         *
         * The function is expected to return an array of strings.
         * 
         * The function accepts a city argument (String) and maxCost argument(Integer).
         */


        public static List<string> getRelevantFoodOutlets(string city, int maxCost)
        {
            string baseUrl = "https://jsonmock.hackerrank.com/api/food_outlets";
            string cityParameter = "?city=" + city;
            string pageParameter = "&page=";
            string json;
            int totalPageCount = 0;
            List<string> foodOutlets = new List<string>();
            List<Data> foodOutletsData = new List<Data>();

            totalPageCount = Utils.GetTotalPageCount(String.Concat(baseUrl,cityParameter));

            for (int i = 1; i <= totalPageCount; i++)
            {
                var urlWithParameters = String.Concat(baseUrl,cityParameter,pageParameter,i.ToString());
                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(urlWithParameters);
                    JObject parsedJson = JObject.Parse(json);
                    IList<JToken> dataResults = parsedJson["data"].Children().ToList();
                    foreach (JToken result in dataResults)
                    {
                        Data newData = result.ToObject<Data>();
                        foodOutletsData.Add(newData);
                    }
                }
            }

            for (int i=0;i<foodOutletsData.Count;i++)
            {
                if (foodOutletsData[i] != null || foodOutletsData.Count() != 0)
                {
                    if (foodOutletsData[i].Estimated_Cost <= maxCost)
                    {
                        foodOutlets.Add(foodOutletsData[i].Name);
                    }
                }
            }

            return foodOutlets;

        }

    }
}
