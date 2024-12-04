using Project_Sporting_Bet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sporting_Bet
{
    public partial class AddBet : Form
    {
        private  Bets _bet;

        public AddBet()
        {
            InitializeComponent();
        }

        public AddBet(Bets bet)
        {
            InitializeComponent();
            _bet = bet;
            amountTextBox.Text = _bet.Amount.ToString();
            betTeamTextBox.Text = _bet.BetTeam.ToString();

        }


        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            int amount = int.Parse(amountTextBox.Text);
            string betTeam = betTeamTextBox.Text;

            Bets newBet = new Bets(id, amount, betTeam);

            this.Close();
        }

        private void amountTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(amountTextBox.Text.Length < 2)
            { 
                e.Cancel = true;
                errorAmount.SetError((Control)sender, "Not good");
            
            }
        }

        private void CancelbtnAddBets_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            if(numericUpDown1.Value > 3)
            {
                e.Cancel = true;
                errorBet.SetError((Control)sender, "No");
            }
        }

        private void betTeamTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(betTeamTextBox.Text == "Ana")
            {
                e.Cancel = true;
                errorProviderBetTeam.SetError((Control)sender, "VAAAAAAAAAAAAAAI");
            }
        }
    }
}
