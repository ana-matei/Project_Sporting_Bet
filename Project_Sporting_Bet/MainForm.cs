using Project_Sporting_Bet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Sporting_Bet
{
    public partial class MainForm : Form
    {
        private List<Gambler> _gamblerList;
        public MainForm()
        {
            InitializeComponent();
            _gamblerList = new List<Gambler>();
        }

        private void AddBetbtn_Click(object sender, EventArgs e)
        {
            AddBet addBet = new AddBet();
            addBet.ShowDialog(this);
        }
        

        private void AddBetbtn_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.Alt && e.KeyCode == Keys.B)
                {
                    AddBetbtn.PerformClick();
                    e.Handled = true;
                }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview= true;

            ComboMain.Items.Add(1);
            ComboMain.Items.Add("Ana");
            ComboMain.Items.Add("Diana");
        }

        private void AddMatchbtn_Click(object sender, EventArgs e)
        {
            AddMatch addMatch= new AddMatch();
            addMatch.ShowDialog(this);
        }

        private void AddMatchbtn_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.Alt && e.KeyCode == Keys.M)
                {
                    AddMatchbtn.PerformClick();
                    e.Handled = true;
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gamblerListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)  // save button gambler
        {
            decimal ID = numericUpDown.Value;
            string name = gamblerNameTextBox.Text;
            if (string.IsNullOrEmpty(gamblerNameTextBox.Text))
            {
                gamblerErrorProvider.SetError(gamblerNameTextBox, "This field is required.");
            }
            else
            {
                gamblerErrorProvider.SetError(gamblerNameTextBox, string.Empty);

                Gambler addedGambler = new Gambler((int)ID, name);

                _gamblerList.Add(addedGambler);
                showGamblers();

                gamblerNameTextBox.Clear();
                numericUpDown.Value = numericUpDown.Minimum;
            }
        }

        private void showGamblers()
        {
            gamblerListView.Items.Clear();
            
            foreach (Gambler gambler in _gamblerList)
            {
                ListViewItem listItem = new ListViewItem(
                    new[]
                {
                    gambler.Name,
                    gambler.Id.ToString(),
                });
                gamblerListView.Items.Add(listItem);
            }
            
            
        }

        private void serializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("gambler.bin"))
                formatter.Serialize(stream, _gamblerList);
        }

        private void deserializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("gambler.bin"))
            {
                _gamblerList = (List<Gambler>)formatter.Deserialize(stream);
                showGamblers();
            }
        }

        private void gamblerBtnReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Report";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        
                        writer.WriteLine("-----------------------");

                        foreach(Gambler gambler in _gamblerList)
                        {
                            writer.WriteLine($"{gambler.Name} {gambler.Id.ToString()}");
                        }

                        writer.WriteLine("-----------------------");
                        
                    }

                    MessageBox.Show("Report created and saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while creating the report: {ex.Message}");
                }
            }
        }

        private void ComboMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
