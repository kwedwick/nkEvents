using Microsoft.AspNetCore.Components;
using NetkinetixEvents.Models;
using System.Net.Http.Json;

namespace NetkinetixEvents.Services
{
    public class SiteEventService : ISiteEventService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public List<SiteEvent> seEvents { get; set; } = new List<SiteEvent>();

        public SiteEventService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public Task CreateSiteEvent(SiteEvent seEvent)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSiteEvent(int seId)
        {
            throw new NotImplementedException();
        }

        public async Task GetAllEvents()
        {
            var result = await _http.GetFromJsonAsync<List<SiteEvent>>("https://nkeventsapi.netkinetix.com/SiteEvent/List");
            if (result != null)
            {
                seEvents = result;
                Console.WriteLine(seEvents);
            } else
            {
                throw new Exception("No events found");
            }
        }

        public Task<SiteEvent> GetOneSiteEvent(int seId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSiteEvent(SiteEvent seEvent)
        {
            throw new NotImplementedException();
        }
    }
}
