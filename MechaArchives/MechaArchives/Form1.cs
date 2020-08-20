using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechaArchives
{
    public partial class d_formMain : Form
    {
        public d_formMain()
        {
            InitializeComponent();
        }

        #region Called by Eventhandler

        private void PullTeamData(object sender, EventArgs e) //Pull team data from server, then update the UI
        {
            Button teamButtons; //Raw button that I can edit the settings of later
            GroupBox teamBox = this.d_teamBox; //The GroupBox that I want the buttons to appear in
            for(int i = 20; i > 0; i--) //8 is just there for now, I'll change it later. It's going downwards so the buttons appear in the proper order (1 -> 8 instead of 8 -> 1)
            {
                teamButtons = new Button(); //Initialize the button
                teamButtons.Name = i.ToString(); //Set the id/name
                teamButtons.Text = teamButtons.Name; //Set text to the id/name
                teamButtons.Dock = DockStyle.Top; //Dock to the top
                teamButtons.Size = new Size(144, 23); //This is the full size of the GroupBox
                teamButtons.Click += new System.EventHandler(this.displayTeamChosen); //Add the onClick
                teamBox.Controls.Add(teamButtons); //Add the button
            }
        }

        #endregion

        private void displayTeamChosen(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button; //The button clicked is now in this object
            //Create new team
            Team myTeam = new Team();
            myTeam.number = Int16.Parse(buttonClicked.Text);
            myTeam.comments = "waifu team";
            MessageBox.Show("Team Number: " + myTeam.number + "\n" + "Comments: " + myTeam.comments,
                                "Team " + myTeam.number + " Info",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }
    }

    public class Team
    {
        public int number;
        public int height;
        public int weight;
        public int language;
        public int auto;
        public int cellLevel;
        public int panel;
        public int climb;
        public string comments;
    }
}
