using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuintaApp.Models
{
    public class Usuario
    {
        public int UsuId { get; set; }
        public string UsuNome { get; set; }
        public string UsuObs { get; set; }
        public DateTime UsuNasc { get; set; }
        public string UsuEmail { get; set; }
        public string UsuLogin { get; set; }
        public int UsuSenha { get; set; }
        public int UsuConfirmarSenha { get; set; }
    }
}