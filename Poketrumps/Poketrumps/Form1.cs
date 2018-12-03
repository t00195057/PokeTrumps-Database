using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poketrumps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayCreateAccount_Click(object sender, EventArgs e)
        {
            grdCreateAccount.Visible = true;
            btnDisplayCreateAccount.Visible = false;
            btnDisplayLogin.Visible = true;
            grdLogin.Visible = false;
        }

        private void btnDisplayLogin_Click(object sender, EventArgs e)
        {
            grdCreateAccount.Visible = false;
            btnDisplayCreateAccount.Visible = true;
            btnDisplayLogin.Visible = false;
            grdLogin.Visible = true;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

            using (PokemonEntities5 context = new PokemonEntities5())
            {

                var max = context.Trainers.DefaultIfEmpty().Max(r => r == null ? 0 : r.TrainerID);
                max = Convert.ToInt16(max) + 1;

                short NextID = Convert.ToInt16(max);

                Trainer trainer = new Trainer
                {

                    TrainerID = NextID,
                    TName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    CreationDate = DateTime.Now

                };





                context.Trainers.Add(trainer);

                context.SaveChanges();
                for (int x = 0; x < 5; x++)
                {
                    context.getNewPokemon(NextID);
                    context.SaveChanges();
                }
                this.Hide();
                var form2 = new Team(NextID);
                form2.Closed += (s, args) => this.Close();

                form2.Show();

            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (PokemonEntities5 context = new PokemonEntities5())
            {
                var username = Convert.ToString(txtLoginUsername.Text);
                var password = Convert.ToString(txtLoginPassword.Text);
                //https://stackoverflow.com/questions/1802286/best-way-to-check-if-object-exists-in-entity-framework


                var result = context.Trainers
                .Where(t => t.TName == username && t.Password == password)
                .Select(t => new { t.TrainerID}).ToList();

                dataGridView1.DataSource = result;

             
             
                
                if (context.Trainers.Any(t => t.TName == username)){
                         if (dataGridView1.RowCount==0)
                         {
                             MessageBox.Show(username + " does not use the password you have entered");
                             txtLoginPassword.Clear();
                         }
                         else
                         {

                             short shortId = Convert.ToInt16(dataGridView1.Rows[0].Cells[0].Value);
                             this.Hide();
                             var form2 = new Team(shortId);
                             form2.Closed += (s, args) => this.Close();
                             form2.Show();
                         }
                     }
                     else
                         MessageBox.Show(username+" does not exist in the system create an account");
                 }
                 


            }
        }
    }


