using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Potrawa
    {
        public string potrawa;
        public string cena;
        public string ocena;
        public string opis;
        public Potrawa(string potrawa, string cena, string ocena, string opis)
        {
            this.potrawa = potrawa;
            this.cena = cena;
            this.ocena = ocena;
            this.opis = opis;
        }

        public void Display(Label label_potrawa, Label label_cena, Label label_ocena, Label label_opis)
        {

            label_potrawa.Text = potrawa;
            label_cena.Text = cena;
            label_ocena.Text = ocena;
            label_opis.Text = opis;
        }
    }
}
