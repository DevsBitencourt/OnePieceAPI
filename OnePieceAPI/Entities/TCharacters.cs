using Azure;
using Azure.Data.Tables;

namespace OnePieceAPI.Entities
{
    public class TCharacters : ITableEntity
    {
        public string PartitionKey { get; set; } = default!;
        public string RowKey { get; set; } = default!;
        public DateTimeOffset? Timestamp { get; set; } = default!;
        public ETag ETag { get; set; } = default!;

        public string Name { get; set; } = default!;
        public double CurrentReward { get; set; } = default!;
        public string Tribulation { get; set; } = default!;

    }
}
