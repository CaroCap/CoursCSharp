using System;

namespace Demo.CinemaProject.DAL.EntitiesDTO
{
    public class Diffusion
    {
        public int Id { get; set; }
        public int Cinema_Id { get; set; }
        public int Film_Id { get; set; }
        public DateTime DateDiffusion { get; set; }
    }
}
