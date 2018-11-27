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
     
            using (PokemonEntities2 context = new PokemonEntities2())
            {

                var max = context.Trainers.DefaultIfEmpty().Max(r => r == null ? 0 : r.TrainerID);
                int newID = Convert.ToInt16(max)+1;
                Trainer trainer = new Trainer
                {

                    TrainerID = Convert.ToInt16(newID),
                    TName = Convert.ToString(txtUsername.Text),
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    CreationDate = DateTime.Now

                };

                
                context.Trainers.Add(trainer);
                context.SaveChanges();
                this.Hide();
                var form2 = new Team();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (PokemonEntities2 context = new PokemonEntities2())
            {
                var username = Convert.ToString(txtLoginUsername.Text);
                var password = Convert.ToString(txtLoginPassword.Text);
                //https://stackoverflow.com/questions/1802286/best-way-to-check-if-object-exists-in-entity-framework

                var clientNameParameter = new SqlParameter("@Tname", username);
                var clientPasswordParameter = new SqlParameter("@Password", password);

                var result = context.Database
                    .SqlQuery<Trainer>("GetResultsForCampaign @ClientId", clientNameParameter,clientPasswordParameter);
                    
            
            if (context.Trainers.Any(t => t.TName == username)){
                    if (result != null)
                    {
                        MessageBox.Show(username + "does not use the password you have entered");
                        txtLoginPassword.Clear();
                    }
                    else
                    {
                        this.Hide();
                        var form2 = new Team();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                }
                else
                    MessageBox.Show(username+"does not exist in the system create an account");
            }
        }
    }
}
