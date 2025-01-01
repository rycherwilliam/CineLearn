using Domain.Enums;

namespace Domain.Entities.Media
{
    public class Series
    {
        private Guid Id {  get; set; } = Guid.NewGuid();
        private string Title { get; set; }
        private Genre Genre { get; set; }
        private bool IsAvaibleForStreaming { get; set; }
    }
}
