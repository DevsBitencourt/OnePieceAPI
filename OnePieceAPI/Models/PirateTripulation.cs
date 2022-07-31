using CosmoSQL;
namespace OnePieceAPI.Models
{
    public class PirateTripulation
    {
        private CosmoSQL.Models.ConnectionCosmo Connection { get; set; }

        public PirateTripulation()
        {
            Connection = new CosmoSQL.Models.ConnectionCosmo();
            Connection.Connection();
        }

        public async Task<IEnumerable<Entities.TCharacters>> GetCharacters()
        {
            var services = Connection.Services.GetTableClient(tableName: nameof(Entities.TCharacters));
            
            var Response = await services.CreateIfNotExistsAsync();
            
            /*
            var character = new Entities.TCharacters() { 
                PartitionKey = "Tripulation",
                RowKey = "Benn Beckman",
                Tribulation = "Piratas do Ruivo",
                Name = "Benn Beckman",
                CurrentReward = 0.00M
            };

            var ResponseAdd = await services.AddEntityAsync<Entities.TCharacters>(character);
            */
            //var GetCharacter = await services.GetEntityAsync<Entities.TCharacters>( partitionKey: "Tripulation", rowKey: "Akagami");
            return services.Query<Entities.TCharacters>(x => 1 == 1);
        }


    }
}
