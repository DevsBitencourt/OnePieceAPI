using Azure.Data.Tables;
using System.Reflection;
using System.Text.Json;

namespace CosmoSQL.Models
{
    public class ConnectionCosmo
    {
        private string FileSettingName { get => "ConnectionCosmo.json"; }

        public Entites.EConnectionCosmo Setting { get; private set; } = new();

        public TableServiceClient Services { get; private set; }

        public ConnectionCosmo Connection()
        {
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.

            string location = Assembly.GetAssembly(GetType()).Location;
            string PathLocation = Path.GetDirectoryName(location).Replace("file:\\", "");
            string ConfigurationCosmo = Path.Combine(PathLocation, FileSettingName);

            if (!File.Exists(ConfigurationCosmo))
            {
                Setting = JsonSerializer.Deserialize<Entites.EConnectionCosmo>(Environment.GetEnvironmentVariable("CONNECTIONONEPIECE"));
            }
            else
            {
                Setting = JsonSerializer.Deserialize<Entites.EConnectionCosmo>(File.ReadAllText(ConfigurationCosmo));
            }

#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
            // New instance of the TableClient class
            Services = new TableServiceClient(Setting.ConnectionString());

            return this;
        }

    }
}