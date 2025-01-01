
namespace Domain.Entities.Media
{
    public class Season
    {
        private Guid Id {  get; set; } = Guid.NewGuid();
        private Guid SeriesId { get; set; }
        private string Title { get; set; }
        private int SeasonNumber { get; set; }
    }
}
