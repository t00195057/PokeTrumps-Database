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
            using (PokemonEntities5 context = new PokemonEntities5())
            {
                InitializeComponent();
                txtID.Text = Convert.ToString(TrainerID);
                grdTeam.DataSource = context.getTeam(TrainerID);
                grdTeam.Rows[0].Cells[0].Selected = false;
                grdCollection.DataSource = context.getCollection(TrainerID);
                if(grdCollection.Rows.Count>=2)
                grdCollection.Rows[0].Cells[0].Selected = false;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
                short PokIn = Convert.ToInt16(grdCollection.Rows[grdCollection.CurrentCell.RowIndex].Cells[0].Value);

                short PokOut = Convert.ToInt16(grdTeam.Rows[grdTeam.CurrentCell.RowIndex].Cells[0].Value);

                short trainerID = Convert.ToInt16(txtID.Text);
                using (PokemonEntities5 context = new PokemonEntities5())
                {
                    context.updateTeam(trainerID, PokOut, PokIn);
                    grdTeam.DataSource = context.getTeam(Convert.ToInt16(txtID.Text));
                    grdTeam.Rows[0].Cells[0].Selected = false;
                    grdCollection.DataSource = context.getCollection(Convert.ToInt16(txtID.Text));
                    if (grdCollection.Rows.Count >= 2)
                        grdCollection.Rows[0].Cells[0].Selected = false;

                
            }
        }
    }
}
