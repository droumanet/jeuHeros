/* ====================================================================================================================
 * Structure pour code de gestion d'un jeu de rôles avec des classes de personnage
 * auteur : david ROUMANET
 * version : 0.2 (alpha)
 * date : 01 mars 2021
 * 09/03/2021 Mise en place de GIT
 * 09/03/2021 modification titre
 * =================================================================================================================== */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jeuHeros.models;          // importation des classes liées aux personnages

namespace jeuHeros {

    class Program {
        static void Main(string[] args) {
            Personnage human = new Personnage("Francis");
            Guerrier barbare = new Guerrier("Conan", 150);
            Console.WriteLine("un humain {0} et un barbare {1} ont été créés.", human.pseudo, barbare.pseudo);
            Console.ReadKey();
        }
    }
}
