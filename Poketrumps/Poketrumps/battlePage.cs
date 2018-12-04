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
    public partial class battlePage : Form
    {
        public battlePage(short trainerID)
        {
            InitializeComponent();
            txt.Text = Convert.ToString(trainerID);

            using (PokemonEntities5 context = new PokemonEntities5())
            {

                var max = context.Trainers.DefaultIfEmpty().Max(r => r == null ? 0 : r.TrainerID);
                max = Convert.ToInt16(max) + 1;

                short NextID = Convert.ToInt16(max);
                var UI = "Ui";
                txtAI.Text = Convert.ToString(max);
                Trainer trainer = new Trainer
                {

                    TrainerID = NextID,
                    TName = UI,
                    Password = UI,
                    Email = UI,
                    CreationDate = DateTime.Now

                };
                context.Trainers.Add(trainer);

                context.SaveChanges();
                for (int x = 0; x < 5; x++)
                {
                    context.getNewPokemon(NextID);
                    context.SaveChanges();
                }

                grdAiTeam.DataSource = context.getTeam(NextID);
                grdTrainerTeam.DataSource = context.getTeam(trainerID);

                var battleid = context.Battles.DefaultIfEmpty().Max(r => r == null ? 0 : r.BattleID);
                battleid = Convert.ToInt16(battleid) + 1;

                short shortBattleID = Convert.ToInt16(battleid);
                txtBattleID.Text = Convert.ToString(shortBattleID);
                context.initiateBattle(trainerID, NextID, shortBattleID);
                context.SaveChanges();
            }
        }

        private void btnChoosePokemon_Click(object sender, EventArgs e)
        {
            if (grdTrainerTeam.CurrentCell != null)
            {
                short AIPok = Convert.ToInt16(grdAiTeam.Rows[Convert.ToInt16(txtRound.Text)-1].Cells[0].Value);
                short TrainerPok = Convert.ToInt16(grdTrainerTeam.Rows[grdTrainerTeam.CurrentCell.RowIndex].Cells[0].Value);

              

               

            using (PokemonEntities5 context = new PokemonEntities5())
            {

               
            
                        context.initiateRound(Convert.ToInt16(txt.Text), Convert.ToInt16(txtAI.Text), Convert.ToInt16(txtBattleID.Text), TrainerPok, AIPok);
                        context.SaveChanges();
                   
                    
             
                int cell = (grdTrainerTeam.CurrentCell.RowIndex);
                grdTrainerTeam.CurrentCell = null;
                grdAiTeam.CurrentCell = null;
                grdAiTeam.Rows[Convert.ToInt16(txtRound.Text)-1].Visible = false;
                txtRound.Text = Convert.ToString(Convert.ToInt16(txtRound.Text) + 1);
                grdTrainerTeam.Rows[cell].Visible = false;
                    var trainerID = Convert.ToInt16(txt.Text);
                    var AiID = Convert.ToInt16(txtAI.Text);
                    var BattleID = Convert.ToInt16(txtBattleID.Text);
                   
                    var TrainerScore = context.Rounds
                    .Where(t => t.WinnerID == trainerID && t.BattleID == BattleID)
                    .Select(t => new { t.RoundID }).Count();

                    var AiScore = context.Rounds
                  .Where(t => t.WinnerID == AiID && t.BattleID == BattleID)
                  .Select(t => new { t.RoundID }).Count();

                    if ( TrainerScore>=3|| AiScore>= 3|| Convert.ToInt16(txtRound.Text) > 5)
            {

                
                    
           
                
                MessageBox.Show("game over");

                if(TrainerScore>= 3)
                    {
                        MessageBox.Show("Congradulations You Won");
                        context.getNewPokemon(Convert.ToInt16(txt.Text));
                        context.SaveChanges();
                    }
                        this.Hide();
                        var form = new Team(Convert.ToInt16(txt.Text));

                        form.Closed += (s, args) => this.Close();
                        form.Show();

                    }
            }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();

            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}

