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

        List<Team> myTeamList = new List<Team>();

        public d_formMain()
        {
            InitializeComponent();
        }

        #region Called by Eventhandler

        private void PullTeamData(object sender, EventArgs e) //Pull team data from server, then update the UI
        {
            Button teamButtons; //Raw button that I can edit the settings of later
            Panel teamBox = this.d_allTeamPanel; //The GroupBox that I want the buttons to appear in
            Random rnd = new Random();
            Team myTeam;
            for(int i = 69; i > 0; i--) //8 is just there for now, I'll change it later. It's going downwards so the buttons appear in the proper order (1 -> 8 instead of 8 -> 1)
            {
                myTeam = new Team();
                myTeam.number = i;
                //myTeam.rankpoints = rnd.Next(1,46);
                myTeam.rankpoints = i;
                myTeam.comments = "This is team " + i.ToString();
                myTeamList.Add(myTeam);
            }
            myTeamList.OrderBy(Team => Team.rankpoints).ToList();
            for (int j = 69; j > 0; j--) {
                teamButtons = new Button(); //Initialize the button
                teamButtons.Name = "d_buttonTeam" + myTeamList[69-j].number.ToString(); //Set the id/name
                teamButtons.Text = myTeamList[69 - j].number.ToString(); //Set text to the team nuber
                teamButtons.Font = new Font("Ariel", 18); //Set the text a little bigger, and ariel
                teamButtons.Size = new System.Drawing.Size(teamButtons.Size.Width, 36); //Keep the width the same, make the height a bit bigger to fir the font size
                teamButtons.Dock = DockStyle.Top; //Dock to the top, so we don't need to add a size
                teamButtons.TabIndex = j;
                teamButtons.Click += new System.EventHandler(this.displayTeamChosen); //Add the onClick
                teamBox.Controls.Add(teamButtons); //Add the button to the teamBox
            }
        }

        private void applyFilters(object sender, EventArgs e)
        {
            Button teamButtons; //Raw button that I can edit the settings of later
            Panel teamBox = this.d_filterTeamsPanel; //The GroupBox that I want the buttons to appear in
            for (int i = 34; i > 0; i--) //8 is just there for now, I'll change it later. It's going downwards so the buttons appear in the proper order (1 -> 8 instead of 8 -> 1)
            {
                teamButtons = new Button(); //Initialize the button
                teamButtons.Name = "d_buttonTeam" + i.ToString(); //Set the id/name
                teamButtons.Text = i.ToString(); //Set text to the id/name
                teamButtons.Font = new Font("Ariel", 18); //Set the text a little bigger, and ariel
                teamButtons.Size = new System.Drawing.Size(teamButtons.Size.Width, 36); //Keep the width the same, make the height a bit bigger to fir the font size
                teamButtons.Dock = DockStyle.Top; //Dock to the top, so we don't need to add a size
                teamButtons.TabIndex = i;
                teamButtons.Click += new System.EventHandler(this.displayTeamChosen); //Add the onClick
                teamBox.Controls.Add(teamButtons); //Add the button to the teamBox
            }
            teamButtons = new Button(); //Initialize the button
            teamButtons.Name = "d_buttonTeam" + 7722.ToString(); //Set the id/name
            teamButtons.Text = 7722.ToString(); //Set text to the id/name
            teamButtons.Font = new Font("Ariel", 18); //Set the text a little bigger, and ariel
            teamButtons.Size = new System.Drawing.Size(teamButtons.Size.Width, 36); //Keep the width the same, make the height a bit bigger to fir the font size
            teamButtons.Dock = DockStyle.Top; //Dock to the top, so we don't need to add a size
            teamButtons.Click += new System.EventHandler(this.displayTeamChosen); //Add the onClick
            teamBox.Controls.Add(teamButtons); //Add the button to the teamBox
        }

        private void AddRobotData(object sender, EventArgs e)
        {
            UploadData addData = new UploadData(); //Create instance of addData form
            addData.Show(); //Show the form
        }

        #endregion

        private void displayTeamChosen(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button; //The button clicked is now in this object
            //Create new team
            Team myTeam = new Team();
            myTeam.number = Int16.Parse(buttonClicked.Text);
            myTeam.comments = myTeamList[myTeam.number].comments;
            myTeam.rankpoints = myTeamList[myTeam.number].rankpoints;
            //Show the message box
            MessageBox.Show("Team Number: " + myTeam.number + "\n" + "Comments: " + myTeam.comments + "\n" + "Ranking Points: " + myTeam.rankpoints.ToString(),
                                "Team " + myTeam.number + " Info",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void openGithubPage(object sender, EventArgs e)
        {
            ToolStripLabel githubLink = this.d_githubLink;
            githubLink.ForeColor = Color.Purple;
            System.Diagnostics.Process.Start("https://github.com/JakeGuy11/MechaArchives");
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

        public int rankpoints;
    }
}
