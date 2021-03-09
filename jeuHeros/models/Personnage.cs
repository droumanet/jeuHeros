using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuHeros.models {
    public class Personnage {
        public String pseudo;
        public Char sexe;           // permettre les autres (PAN, robots, extraterrestres, fantômes, etc.)
        public int pointVie;
        public int niveau;
        public int experienceNiveau;    // pourcentage permettant le calcul de passage prochain niveau

        public Personnage(String nom) {
            this.pseudo = nom;
        }
        public Personnage(String nom, char sexe, int vie) {
            this.pseudo = nom;
            this.sexe = sexe;
            this.pointVie = vie;
        }
    }
    public class Guerrier : Personnage {
        public int force;
        public Guerrier(String Nom, int Force) : base(Nom) {
            this.force = Force;
        }
    }
}
