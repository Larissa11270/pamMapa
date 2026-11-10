using System;
using System.Collections.Generic;
using System.Text;

namespace MapaPam.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
