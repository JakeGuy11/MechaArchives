using Newtonsoft.Json; //It's dangerous to go alone, take this https://www.newtonsoft.com/json/help/html/DeserializeObject.htm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechaArchives
{
    public partial class d_formMain : Form
    {

        List<Team> myTeamList = new List<Team>();
        List<Team> filteredTeamList = new List<Team>();
        private static readonly string jArchivePath = Environment.ExpandEnvironmentVariables("%AppData%\\MechaArchives\\");

        public d_formMain()
        {
            InitializeComponent();
        }

        #region Called by Eventhandler

        private void PullTeamData(object sender, EventArgs e) //Pull team data from server, then update the UI
        {
            
        }

        private void applyFilters(object sender, EventArgs e)
        {
            string[] jArchiveNames = Directory.GetFiles(jArchivePath);
            myTeamList = new List<Team>();
            Team currentTeam;
            for (int i = 0; i < jArchiveNames.Length; i++)
            {
                currentTeam = new Team();
                currentTeam = JsonConvert.DeserializeObject<Team>(File.ReadAllText(jArchiveNames[i]));
                myTeamList.Add(currentTeam);
            }
            myTeamList = myTeamList.OrderByDescending(Team => Team.rankpoints).ToList();
            myTeamList.Reverse();
            //-----------------------------------------------
            //                  Filter Here
            //-----------------------------------------------
            Team teamForFilter;
            for (int j = 0; j < myTeamList.Count; j++)
            {
                teamForFilter = myTeamList[j];
                bool failedFilter = false;
                if (this.d_boxHeight.Checked)
                {
                    if (teamForFilter.height < this.d_minHeight.Value) failedFilter = true;
                    if (teamForFilter.height > this.d_maxHeight.Value) failedFilter = true;
                }
                if (this.d_boxLanguage.Checked)
                {
                    if (teamForFilter.language != d_robotLanguage.SelectedIndex) failedFilter = true;
                }
                if (this.d_boxAvgRank.Checked)
                {
                    if (Decimal.Parse(teamForFilter.avgRankpoints().ToString()) < this.d_avgRankPoints.Value) failedFilter = true;
                }
                if (this.d_boxTotalRank.Checked)
                {
                    if (teamForFilter.rankpoints < this.d_totalRank.Value) failedFilter = true;
                }
                if (this.d_autoEnabled.Checked)
                {
                    int autoLevel = 0;
                    if (this.d_refillsAuto.Checked) autoLevel = 3;
                    else if (this.d_shootsAuto.Checked) autoLevel = 2;
                    else if (this.d_hasAuto.Checked) autoLevel = 1;
                    if (teamForFilter.auto < autoLevel) failedFilter = true;
                }
                if (this.d_cellEnabled.Checked)
                {
                    if (!teamForFilter.cellLevel1 == true && this.d_cell1.Checked) failedFilter = true;
                    if (!teamForFilter.cellLevel2 == true && this.d_cell2.Checked) failedFilter = true;
                    if (!teamForFilter.cellLevel3 == true && this.d_cell3.Checked) failedFilter = true;
                }
                if (this.d_panelEnabled.Checked)
                {
                    if (!teamForFilter.spin == true && this.d_spinPanel.Checked == true) failedFilter = true;
                    if (!teamForFilter.colour == true && this.d_colorPanel.Checked == true) failedFilter = true;
                    if (!teamForFilter.under == true && this.d_underPanel.Checked == true) failedFilter = true;
                }
                if (this.d_climbEnabled.Checked)
                {
                    if (!teamForFilter.climb == true && this.d_canLift.Checked == true) failedFilter = true;
                    if (!teamForFilter.balance == true && this.d_canBalance.Checked == true) failedFilter = true;
                    if (!teamForFilter.lift == true && this.d_canLift.Checked == true) failedFilter = true;
                }
                myTeamList[j].enabled = !failedFilter;
            }

            //-----------------------------------------------
            //                  Filter Done
            //-----------------------------------------------
            Button teamButtons; //Raw button that we can edit the settings of later
            Panel teamBox = this.d_filterTeamsPanel; //The GroupBox that I want the buttons to appear in
            teamBox.Controls.Clear();
            for (int k = myTeamList.Count; k > 0; k--)
            {
                if (myTeamList[myTeamList.Count - k].enabled == true)
                {
                    teamButtons = new Button(); //Initialize the button
                    teamButtons.Name = "d_buttonTeam" + myTeamList[myTeamList.Count - k].number.ToString(); //Set the id/name
                    teamButtons.Text = myTeamList[myTeamList.Count - k].number.ToString(); //Set text to the team nuber
                    teamButtons.Font = new Font("Ariel", 18); //Set the text a little bigger, and ariel
                    teamButtons.Size = new System.Drawing.Size(teamButtons.Size.Width, 36); //Keep the width the same, make the height a bit bigger to fir the font size
                    teamButtons.Dock = DockStyle.Top; //Dock to the top, so we don't need to add a size
                    teamButtons.TabIndex = k; //Set the tab index
                    teamButtons.Click += new System.EventHandler(this.displayTeamChosen); //Add the onClick
                    teamBox.Controls.Add(teamButtons); //Add the button to the teamBox
                }
            }
        }

        private void AddRobotData(object sender, EventArgs e)
        {
            UploadData addTeamForm = new UploadData(); //Create new instance of addTeamForm
            addTeamForm.FormClosed += new FormClosedEventHandler(addDataClosed);
            this.ActivateMdiChild(addTeamForm); //Add it to this form as a child
            addTeamForm.Show(); //Show the form
        }

        private void addDataClosed(object sender, FormClosedEventArgs e)
        {
            updatejArchiveLocally();
        }
        
        private void updateFromLocal(object sender, EventArgs e)
        {
            updatejArchiveLocally();
        }

        #endregion

        private void updatejArchiveLocally()
        {
            string[] jArchiveNames = Directory.GetFiles(jArchivePath);
            myTeamList = new List<Team>();
            Team currentTeam;
            for (int i = 0; i < jArchiveNames.Length; i++)
            {
                currentTeam = new Team();
                currentTeam = JsonConvert.DeserializeObject<Team>(File.ReadAllText(jArchiveNames[i]));
                myTeamList.Add(currentTeam);
            }
            myTeamList = myTeamList.OrderByDescending(Team => Team.rankpoints).ToList();
            myTeamList.Reverse();
            Button teamButtons; //Raw button that I can edit the settings of later
            Panel teamBox = this.d_allTeamPanel; //The GroupBox that I want the buttons to appear in
            teamBox.Controls.Clear(); //Remove all current buttons so we don't just add to it
            for (int j = myTeamList.Count; j > 0; j--)
            {
                teamButtons = new Button(); //Initialize the button
                teamButtons.Name = "d_buttonTeam" + myTeamList[myTeamList.Count - j].number.ToString(); //Set the id/name
                teamButtons.Text = myTeamList[myTeamList.Count - j].number.ToString(); //Set text to the team nuber
                teamButtons.Font = new Font("Ariel", 18); //Set the text a little bigger, and ariel
                teamButtons.Size = new System.Drawing.Size(teamButtons.Size.Width, 36); //Keep the width the same, make the height a bit bigger to fir the font size
                teamButtons.Dock = DockStyle.Top; //Dock to the top, so we don't need to add a size
                teamButtons.TabIndex = j; //Set the tab index
                teamButtons.Click += new System.EventHandler(this.displayTeamChosen); //Add the onClick
                teamBox.Controls.Add(teamButtons); //Add the button to the teamBox
            }
        }

        private void displayTeamChosen(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button; //The button clicked is now in this object
            //Create new team
            Team myTeam = myTeamList[myTeamList.Count - buttonClicked.TabIndex]; //Take the team object chosen
            ViewTeam teamDetailForm = new ViewTeam(); //Create new instance of addTeamForm
            //addTeamForm.FormClosed += new FormClosedEventHandler(addDataClosed);
            teamDetailForm.Text = myTeam.number.ToString();
            this.ActivateMdiChild(teamDetailForm); //Add it to this form as a child
            teamDetailForm.Show(); //Show the form
        }

        private void openGithubPage(object sender, EventArgs e)
        {
            ToolStripLabel githubLink = this.d_githubLink;
            githubLink.ForeColor = Color.Purple;
            System.Diagnostics.Process.Start("https://github.com/JakeGuy11/MechaArchives");
        }

        #region Checkstates Changed

        private void d_autoEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.d_autoEnabled.Checked)
            {
                this.d_hasAuto.Enabled = false;
                this.d_shootsAuto.Enabled = false;
                this.d_refillsAuto.Enabled = false;
            }
            else
            {
                this.d_hasAuto.Enabled = true;
                this.d_shootsAuto.Enabled = true;
                this.d_refillsAuto.Enabled = true;
            }
        }

        private void autoBoxChanged(object sender, EventArgs e)
        {
            //JAKE! MAKE THIS MORE EFFICIENT! For now, this is just a bunch of nested ifs so that is option 3 is checked, so is 2 and 1. I won't comment it up because it'll be way too long but enjoy...
            if (sender == this.d_hasAuto)
            {
                if (!this.d_hasAuto.Checked)
                {
                    this.d_shootsAuto.Checked = false;
                    this.d_refillsAuto.Checked = false;
                }
            }
            else if (sender == this.d_shootsAuto)
            {
                if (this.d_shootsAuto.Checked) this.d_hasAuto.Checked = true;
                else if (!this.d_shootsAuto.Checked)
                {
                    this.d_refillsAuto.Checked = false;
                }
            }
            else if (sender == this.d_refillsAuto)
            {
                if (this.d_refillsAuto.Checked)
                {
                    this.d_hasAuto.Checked = true;
                    this.d_shootsAuto.Checked = true;
                }
            }
        }

        private void d_cellEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.d_cellEnabled.Checked)
            {
                this.d_cell1.Enabled = false;
                this.d_cell2.Enabled = false;
                this.d_cell3.Enabled = false;
            }
            else
            {
                this.d_cell1.Enabled = true;
                this.d_cell2.Enabled = true;
                this.d_cell3.Enabled = true;
            }
        }

        private void d_panelEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.d_panelEnabled.Checked)
            {
                this.d_spinPanel.Enabled = false;
                this.d_colorPanel.Enabled = false;
                this.d_underPanel.Enabled = false;
            }
            else
            {
                this.d_spinPanel.Enabled = true;
                this.d_colorPanel.Enabled = true;
                this.d_underPanel.Enabled = true;
            }
        }

        private void d_climbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.d_climbEnabled.Checked)
            {
                this.d_canClimb.Enabled = false;
                this.d_canBalance.Enabled = false;
                this.d_canLift.Enabled = false;
            }
            else
            {
                this.d_canClimb.Enabled = true;
                this.d_canBalance.Enabled = true;
                this.d_canLift.Enabled = true;
            }
        }

        private void d_boxHeight_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.d_boxHeight.Checked)
            {
                this.d_maxHeight.Enabled = false;
                this.d_minHeight.Enabled = false;
            }
            else
            {
                this.d_maxHeight.Enabled = true;
                this.d_minHeight.Enabled = true;
            }
        }

        private void d_boxLanguage_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.d_boxLanguage.Checked)
            {
                this.d_robotLanguage.Enabled = false;
            }
            else
            {
                this.d_robotLanguage.Enabled = true;
            }
        }

        private void d_boxAvgRank_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.d_boxAvgRank.Checked)
            {
                this.d_avgRankPoints.Enabled = false;
            }
            else
            {
                this.d_avgRankPoints.Enabled = true;
            }
        }

        private void d_boxTotalRank_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.d_boxTotalRank.Checked)
            {
                this.d_totalRank.Enabled = false;
            }
            else
            {
                this.d_totalRank.Enabled = true;
            }
        }

        #endregion
    }
}
