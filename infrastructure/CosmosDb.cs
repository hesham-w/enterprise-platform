using Pulumi.AzureNative.Resources;
using DocumentDB = Pulumi.AzureNative.DocumentDB;

namespace Infrastructure
{
    internal static class CosmosDb
    {
        internal static void Create(ResourceGroup resourceGroup)
        {
            // Cosmos DB Account
            var cosmosdbAccount = new DocumentDB.DatabaseAccount("enterpriseplatform-cdb", new DocumentDB.DatabaseAccountArgs
            {
                ResourceGroupName = resourceGroup.Name,
                DatabaseAccountOfferType = DocumentDB.DatabaseAccountOfferType.Standard,
                Locations =
            {
                new DocumentDB.Inputs.LocationArgs
                {
                    LocationName = resourceGroup.Location,
                    FailoverPriority = 0,
                },
            },
                ConsistencyPolicy = new DocumentDB.Inputs.ConsistencyPolicyArgs
                {
                    DefaultConsistencyLevel = DocumentDB.DefaultConsistencyLevel.Session,
                },
            });

            // Cosmos DB Database
            var db = new DocumentDB.SqlResourceSqlDatabase("enterpriseplatform-cdb", new DocumentDB.SqlResourceSqlDatabaseArgs
            {
                ResourceGroupName = resourceGroup.Name,
                AccountName = cosmosdbAccount.Name,
                Resource = new DocumentDB.Inputs.SqlDatabaseResourceArgs
                {
                    Id = "enterpriseplatform-cdb",
                },
            });
        }
    }
}
