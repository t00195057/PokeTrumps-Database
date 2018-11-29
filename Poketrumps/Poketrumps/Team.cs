using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poketrumps
{
    public partial class Team : Form
    {
        
        public Team(short TrainerID)
        {
            using (PokemonEntities3 context = new PokemonEntities3())
            {
                InitializeComponent();
                grdTeam.DataSource = context.getTeam(77);
                grdTeam.Rows[0].Cells[0].Selected = false;
                grdCollection.DataSource = context.getCollection(77);
                grdCollection.Rows[0].Cells[0].Selected = false;
            }
        }

        private void grdCollection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
