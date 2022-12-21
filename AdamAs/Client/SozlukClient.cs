using AdamAs.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdamAs.Client
{
    public class SozlukClient
    {
        private static int getRandomKelimeId()
        {
            Random random = new Random();
            int id = random.Next(5000);
            return id;
        }

        public static async Task<string> GetKelimeJSONString()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {

                    var getKelime = await httpClient.GetAsync("https://sozluk.gov.tr/gts_id?id=" + getRandomKelimeId());
                    return await getKelime.Content.ReadAsStringAsync();
                }
                catch (Exception)
                {
                    
                    return "";
                }
            }

        }

        public static async Task<Root> GetKelime()
        {
            try
            {
                var json = JsonConvert.DeserializeObject<List<Root>>(await GetKelimeJSONString());
                return json[0];
            }
            catch (Exception)
            {

                return null;
            }
            

        }


    }
}
