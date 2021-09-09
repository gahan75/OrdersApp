using System.Threading.Tasks;

namespace OrdersApp.Data
{
    public interface IOrdersAppDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
