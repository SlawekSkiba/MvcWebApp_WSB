using Microsoft.EntityFrameworkCore;
using MvcWebApp.Storage;

namespace MvcWebApp.Extensions;

public static class Migrator
{
    public static async Task MigrateDatabaseAsync(this IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            if (context != null)
            {
                await context.Database.MigrateAsync();
            }
        }
    }
}
