using MongoDB.Driver;
using ProductApi.Models;

public ProductService(IInventoryDatabaseSettings settings)
{
    var client = new MongoClient(settings.ConnectionString);
    var database = client.GetDatabase(settings.DatabaseName);

    _products = database.GetCollection<Product>(settings.InventoryCollectionName);
}