using Demo.CinemaProject.ASP.Handlers;
using Demo.CinemaProject.BLL.EntitiesBLL;
using Demo.CinemaProject.BLL.Services;
using Demo.CinemaProject.Common.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.CinemaProject.ASP
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
            // Possibilité de mettre des cookies et d'ajouter une session
            services.AddDistributedMemoryCache(); // Préparer de l'espace mémoie pour la session
            services.AddSession(options =>
            {
                options.Cookie.Name = "ExempleCookie";  // Nom du cookie
                options.Cookie.HttpOnly = true; // Cooki accessible que par des requete http et non pas par du JavaScript ou autre (+ sécurisé)
                options.Cookie.IsEssential = true;

                options.IdleTimeout = TimeSpan.FromMinutes(1); // Temps avant la fin de la session (1minute dans ce cas ci)
            });
            // + AJOUTER DANS CONFIG APP.USESESSION()
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true; // Vérifier l'acceptation des cookies
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.Strict; //
            });

            // ON VA UTILISER LE SESSION MANAGER 
            services.AddHttpContextAccessor();
            services.AddScoped<SessionManager>();


            services.AddControllersWithViews();
            // Pour que la vue fonctionne, il faut ajouter une de ces actions (injections de dépendances)
            // 1°) services.AddSingleton<>; => même objet pour tout le monde du monde entier ==> pas sécurisé et latence car nombreux sur l'objet
            // 2°) services.AddScoped<>; => même instance d'objet par client
            // 3°) services.AddTransient<>; => nouveau objet à chaque fois ==> TRES LOURD mais très efficace !
            // EX Moule à gâteau dans une cuisine :
            // cas 1° = 1 seul moule à gâteau pour tout le monde à devoir se prêter de cuisine en cuisine
            // cas 2° = 1 moule par cuisine (par client) donc pratique sauf si il veut faire plusieurs gâteau en même temps...
            // cas 3° = 1 moule par patisserie donc prend beaucoup de place dans la cuisine (est très lourd) 
            // 1° = ex d'utilisation => besoin d'une maintenance du site => même heure pour tout le monde
            // 2° souvent utilisé
            // 3° moins utilisé car très lourd mais utile pour de petites application pour l'affichage...

            // Injection de dépendance pour la DAL
            services.AddScoped<ICinemaRepository<DAL.EntitiesDTO.Cinema>, DAL.RepositoriesDAO.CinemaService>();
            services.AddScoped<IFilmRepository<DAL.EntitiesDTO.Film>, DAL.RepositoriesDAO.FilmService>();
            services.AddScoped<IDiffusionRepository<DAL.EntitiesDTO.Diffusion>, DAL.RepositoriesDAO.DiffusionService>();
            // Injection de dépendance pour le BLL
            services.AddScoped<ICinemaRepository<CinemaBLL>, CinemaService>();
            services.AddScoped<IFilmRepository<FilmBLL>, FilmService>();
            services.AddScoped<IDiffusionRepository<DiffusionBLL>, DiffusionService>();
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            // POUR ACTIVER L'UTILISATION DE SESSION - COOKIES
            app.UseSession();
            app.UseCookiePolicy(); // Défini dans le ConfigureService
            //

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
