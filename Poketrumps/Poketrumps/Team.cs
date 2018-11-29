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
                txtID.Text = Convert.ToString(TrainerID);
                InitializeComponent();
                grdTeam.DataSource = context.getTeam(TrainerID);
                grdTeam.Rows[0].Cells[0].Selected = false;
                grdCollection.DataSource = context.getCollection(TrainerID);
                grdCollection.Rows[0].Cells[0].Selected = false;
            }
        }

        private void grdCollection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdTeam.CurrentCell.Value != null)
            {

              

                short PokIn = Convert.ToInt16(grdCollection.Rows[grdCollection.CurrentCell.RowIndex].Cells[0].Value);
               
                short PokOut = Convert.ToInt16(grdTeam.Rows[grdTeam.CurrentCell.RowIndex].Cells[0].Value);
              
                short trainerID = Convert.ToInt16(txtID.Text);
                using (PokemonEntities3 context = new PokemonEntities3())
                {
                    context.updateTeam(trainerID,PokOut, PokIn);

                }
            }
        }

        private void grdTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (grdTeam.CurrentCell.Value != null)
            {



                short PokIn = Convert.ToInt16(grdCollection.Rows[grdCollection.CurrentCell.RowIndex].Cells[0].Value);

                short PokOut = Convert.ToInt16(grdTeam.Rows[grdTeam.CurrentCell.RowIndex].Cells[0].Value);

                short trainerID = Convert.ToInt16(txtID.Text);
                using (PokemonEntities3 context = new PokemonEntities3())
                {
                    context.updateTeam(trainerID, PokOut, PokIn);

                }
            }
        }
    }
}
