using Demo.CinemaProject.ASP.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo.CinemaProject.ASP.Handlers
{
    public class SessionManager
    {
        private readonly ISession _session;
        public SessionManager(IHttpContextAccessor httpContextAccessor)
            {
            _session = httpContextAccessor.HttpContext.Session;
            }

        public int? ValeurInt { 
            get 
            {
                return _session.GetInt32("ValeurInt");
            }
            set {
                _session.SetInt32("ValeurInt", value.Value);
            } 
        }

        public string ValeurString {
            get
            {
                return _session.GetString("ValeurString");
            }
            set {
                _session.SetString("ValeurString", value);
            }    
        }

        public byte[] MonTableauDeByte {
            get
            {
                return _session.Get("MonTableauDeByte");
            }

            set
            {
                _session.Set("MonTableauDeByte", value);
            }
        }


        // POUR STOCKER DES FILMS
        public IEnumerable<CinemaListItem> FavoriteCinema
        {
            get 
            {
                if (_session.GetString(nameof(FavoriteCinema)) is null) FavoriteCinema = new List<CinemaListItem> ();
                return JsonSerializer.Deserialize<CinemaListItem[]>(_session.GetString(nameof(FavoriteCinema))); //Faire un using TextJson et non Newton
            }
            set 
            {
                _session.SetString(nameof(FavoriteCinema), JsonSerializer.Serialize(value));
            }
        }

        public void AddCinema(CinemaListItem cinema) 
        {
            List<CinemaListItem> cinemas = new List<CinemaListItem>(FavoriteCinema);
            cinemas.Add(cinema);
            FavoriteCinema = cinemas;
        }




        //POUR LA SESSION USER
        public bool IsConnected { get { return _session.GetString("user") != null; } } // Un booleen pour voir il y a un utilisateur connecté ou non
        public void SetUser(LoginForm form) // cf MyFirstMVC ici ma le Model LoginForm
        {
            _session.SetString("user", form.Email);
        }
    }
}
