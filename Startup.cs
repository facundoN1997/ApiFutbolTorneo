using apiFutbol.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


namespace apiFutbol
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Agrego linea para solucionar bug
            services.AddMvc();
            //CONFIGURO OPCIONES CORS PARA PERMITIR LAS PETICIONES
            services.AddCors();
            services.AddControllers();
            //services.AddControllersWithViews();
            //AGREGO CONTEXTO BASE DE DATOS
            services.AddDbContext<FutbolDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Database"))
            );
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiFutbolTorneo", Version = "v1" });
            });
        }

       

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //CONFIGURO OPCIONES CORS
            app.UseCors(option =>
            {
                option.WithOrigins("*");
                option.AllowAnyMethod();
                option.AllowAnyHeader();
            });
            
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiFutbolTorneo v1"));
            

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

