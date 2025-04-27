using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseII_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void consoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.modelDataSet.Game);
            this.consoleTableAdapter.Fill(this.modelDataSet.Console);

            if (!modelDataSet.Game.Columns.Contains("Console_Name"))
            {
                modelDataSet.Game.Columns.Add("Console_Name", typeof(string));
            }

            // Fill that new column with Console Names
            foreach (var gameRow in modelDataSet.Game)
            {
                var consoleRow = modelDataSet.Console.FirstOrDefault(c => c.ConsoleID == gameRow.ConsoleID);
                if (consoleRow != null)
                {
                    gameRow["Console_Name"] = consoleRow.Console_Name;
                }
            }
        }

        private int GetConsoleIDByName(string consoleName)
        {
            var consoleRow = modelDataSet.Console.FirstOrDefault(c => c.Console_Name == consoleName);
            return consoleRow.ConsoleID;
        }

        private void button_Click(object sender, EventArgs e)
        {
            int consoleID = GetConsoleIDByName(console_NameTextBox.Text);
            if (consoleID == null)
            {
                MessageBox.Show("Console not found.");
                return;
            }

            var newGame = modelDataSet.Game.NewGameRow();

            newGame.Game_Title = game_TitleTextBox.Text;
            newGame.Price = decimal.Parse(priceTextBox.Text);
            newGame.ConsoleID = consoleID;

            modelDataSet.Game.Rows.Add(newGame);

            this.Validate();
            this.consoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

            game_TitleTextBox.Clear();
            priceTextBox.Clear();
            console_NameTextBox.Clear();

        }
    }
}
