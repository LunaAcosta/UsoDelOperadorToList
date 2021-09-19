using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDelOperadorToList
{
    class Lista
    {
        public string deportes { get; set; }


        public static List<Lista> GetListas()
        {
            List<Lista> listas = new List<Lista>
            {
                new Lista {deportes="Ajedrez"},
                new Lista {deportes="Atletismo"},
                new Lista {deportes="Artes Maciales"},
                new Lista {deportes="Automovilismo"},
                new Lista {deportes="Baloncesto"},
                new Lista {deportes="Balonmano"},
                new Lista {deportes="Beisbol"},
                new Lista {deportes="Boxeo"},
                new Lista {deportes="Ciclismo"},
                new Lista {deportes="Esgrima"},
                new Lista {deportes="Fisicoculturismo"},
                new Lista {deportes="Futbol"},
                new Lista {deportes="Judo"},
                new Lista {deportes="Lucha Limpia"},
                new Lista {deportes="Motociclismo"},
                new Lista {deportes="Natacion"},
                new Lista {deportes="Softbol"},
                new Lista {deportes="Tenis"},
                new Lista {deportes="Tenis de Mesa"},
                new Lista {deportes="Tiro"},
                new Lista {deportes="Tiro con Arco"},
                new Lista {deportes="Voleibol"},
            };

            return listas;
        }
    }
}
