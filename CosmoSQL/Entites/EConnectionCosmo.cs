namespace CosmoSQL.Entites
{
    public class EConnectionCosmo
    {
        private string? EndpointsProtocol;

        public string? DefaultEndpointsProtocol
        {
            get { return EndpointsProtocol; }
            set { EndpointsProtocol = value; }
        }

        private string? Account_Name;

        public string? AccountName
        {
            get { return Account_Name; }
            set { Account_Name = value; }
        }

        private string? Account_Key;

        public string? AccountKey
        {
            get { return Account_Key; }
            set { Account_Key = value; }
        }

        private string? Table_Endpoint;

        public string? TableEndpoint
        {
            get { return Table_Endpoint; }
            set { Table_Endpoint = value; }
        }

        public string ConnectionString()
        {
            var builder = new System.Text.StringBuilder();

            builder.Append($"{nameof(DefaultEndpointsProtocol)}={EndpointsProtocol};")
                .Append($"{nameof(AccountName)}={Account_Name};")
                .Append($"{nameof(AccountKey)}={Account_Key};")
                .Append($"{nameof(TableEndpoint)}={Table_Endpoint};");

            return builder.ToString();
        }
    }
}
