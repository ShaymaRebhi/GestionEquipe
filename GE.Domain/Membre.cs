using System;
using System.Collections.Generic;
using System.Text;

namespace GE.Domain
{
    public class Membre
    {
        public DateTime DateNaissance { get; set; }
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
