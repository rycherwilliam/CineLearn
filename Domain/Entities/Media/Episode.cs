namespace Domain.Entities.Media
{
    public class Episode
    {
        private Guid Id {  get; set; } = Guid.NewGuid();
        private Guid SeasonId { get; set; }
        private string Title { get; set; }
        private TimeSpan Duration {  get; set; }
        private int EpisodeNumber { get; set; }

    }
}
