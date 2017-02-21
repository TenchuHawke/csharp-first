using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace YourNamespace {
    public class Startup {
        public void ConfigureServices (IServiceCollection services) {
            services.AddMvc ();
        }
        public void Configure (IApplicationBuilder app) {
            app.UseMvc (routes => {
                routes.MapRoute (
                    name: "Default", // The route's name is only for our own reference
                    template: "", // The pattern that the route matches
                    defaults : new { controller = "Hello", action = "Index" } // The controller and method to execute
                );
            });
        }
    }
}
