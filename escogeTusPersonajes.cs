using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_final_Base_de_Datos
{
    public partial class escogeTusPersonajes : Form
    {
        public escogeTusPersonajes()
        {
            InitializeComponent();
        }

        private void bPersonajesEscogidos_Click(object sender, EventArgs e)
        {
            List<String> personajesSeleccionados = new List<String>();
            List<String> personajes = new List<String>
{
    "Mario", "Donkey Kong", "Link", "Samus", "Dark Samus",
    "Yoshi", "Kirby", "Fox", "Pikachu", "Luigi",
    "Ness", "Captain Falcon", "Jigglypuff", "Peach", "Daisy",
    "Bowser", "Ice Climbers", "Sheik", "Zelda", "Dr. Mario",
    "Pichu", "Falco", "Marth", "Lucina", "Young Link",
    "Ganondorf", "Mewtwo", "Roy", "Chrom", "Mr. Game & Watch",
    "Meta Knight", "Pit", "Dark Pit", "Zero Suit Samus", "Wario",
    "Snake", "Ike", "Pokémon Trainer", "Diddy Kong", "Lucas",
    "Sonic", "King Dedede", "Olimar", "Lucario", "R.O.B.",
    "Toon Link", "Wolf", "Villager", "Mega Man", "Wii Fit Trainer",
    "Rosalina & Luma", "Little Mac", "Greninja", 
    "Palutena", "Pac-Man", "Robin", "Shulk",
    "Bowser Jr.", "Duck Hunt", "Ryu", "Ken", "Cloud",
    "Corrin", "Bayonetta", "Inkling", "Ridley", "Simon",
    "Richter", "King K. Rool", "Isabelle", "Incineroar", "Piranha Plant",
    "Joker", "Hero", "Banjo & Kazooie", "Terry", "Byleth",
    "Min Min", "Steve", "Sephiroth", "Aegis",
    "Kazuya", "Sora", "Mii Brawler", "Mii Swordfighter", "Mii Gunner"
};
     var checkBoxesOrdenados = this.tLPPersonajes.Controls
    .OfType<CheckBox>()
    .OrderBy(cb => int.Parse(new string(cb.Name.Where(char.IsDigit).ToArray())));

            foreach (CheckBox cb in checkBoxesOrdenados)
            {
                if (cb.Checked)
                {
                    String n =new string(cb.Name.Where(char.IsDigit).ToArray());
                    int num = int.Parse(n);
                    personajesSeleccionados.Add(personajes[num-1]);
                }
            }
            
            consulta con = new consulta(personajesSeleccionados);
            con.Show();
            this.Hide();
        }
    }
}
