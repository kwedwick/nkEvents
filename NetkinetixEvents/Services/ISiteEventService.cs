using NetkinetixEvents.Models;

namespace NetkinetixEvents.Services
{
    public interface ISiteEventService
    {
        List<SiteEvent> seEvents { get; set; }

        Task GetAllEvents();
        Task<SiteEvent> GetOneSiteEvent(int seId);
        Task CreateSiteEvent(SiteEvent seEvent);
        Task UpdateSiteEvent(SiteEvent seEvent);
        Task DeleteSiteEvent(int seId);

        Task SearchEvents(SiteEvent seEvent);

    }
}
