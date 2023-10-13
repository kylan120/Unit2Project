using Microsoft.EntityFrameworkCore;
using Unit2Project.Models;

namespace Unit2Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Confiugration = configuration;
        }
        public IConfiguration Confiugration { get;}

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ComicContext>(options =>
                options.UseSqlServer(
                    Confiugration.GetConnectionString("ComicContext")));
        }
    }
}
