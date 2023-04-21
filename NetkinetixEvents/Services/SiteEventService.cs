using Microsoft.AspNetCore.Components;
using NetkinetixEvents.Models;
using System.Net.Http.Json;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace NetkinetixEvents.Services
{
    public class SiteEventService : ISiteEventService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        private string apiURl = "https://nkeventsapi.netkinetix.com/SiteEvent";
        public List<SiteEvent> seEvents { get; set; } = new List<SiteEvent>();
      

        public SiteEventService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public async Task CreateSiteEvent(SiteEvent seEvent)
        {
            var json = JsonConvert.SerializeObject(seEvent);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(stringContent);
            var response = await _http.PostAsync($"{apiURl}/Set", stringContent);
            var responseString = await response.Content.ReadAsStringAsync();

            if (responseString != null)
            {
                var result = await _http.GetFromJsonAsync<List<SiteEvent>>($"{apiURl}/List");
                seEvents = result;
            }
        }

        public Task DeleteSiteEvent(int seId)
        {
            throw new NotImplementedException();
        }

        public async Task GetAllEvents()
        {
            var result = await _http.GetFromJsonAsync<List<SiteEvent>>($"{apiURl}/List");
            if (result != null)
            {
                seEvents = result;
            } else
            {
                throw new Exception("No events found");
            }
        }

        public async Task<SiteEvent> GetOneSiteEvent(int seId)
        {
            try
            {
                var result = await _http.GetFromJsonAsync<SiteEvent>($"{apiURl}/GetByID/{seId}");
                if (result != null)
                {
                    return result;

                }
                else
                {
                    return new SiteEvent { };
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return new SiteEvent { };
            }
        }

        public async Task UpdateSiteEvent(SiteEvent seEvent)
        {
            Console.WriteLine(seEvent.ToString());
            var json = JsonConvert.SerializeObject(seEvent);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(stringContent);
            var response = await _http.PostAsync($"{apiURl}/Set", stringContent);
            var responseString = await response.Content.ReadAsStringAsync();
            if (responseString != null)
            {
                var result = await _http.GetFromJsonAsync<List<SiteEvent>>($"{apiURl}/List");
                seEvents = result;
            }
        }

        public async Task SearchEvents(EventSearch search)
        {

            var json = JsonConvert.SerializeObject(search);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync($"{apiURl}/Search", stringContent);
            var responseString = await response.Content.ReadAsStringAsync();

            if (responseString != null)
            {
                seEvents = JsonConvert.DeserializeObject<List<SiteEvent>>(responseString);
            }
        }
    }
}
