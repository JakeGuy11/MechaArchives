using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MechaArchives
{
    public partial class UploadData : Form
    {
        public UploadData()
        {
            InitializeComponent();
        }

        private void numberOnlyCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //If the key pressed is a number or control (enter, backspace, etc)
            {
                e.Handled = true; //Allow it. If not, don't write it
            }
        }

        private void checkChanged(object sender, EventArgs e)
        {
            //JAKE! MAKE THIS MORE EFFICIENT! For now, this is just a bunch of nested ifs so that is option 3 is checked, so is 2 and 1. I won't comment it up because it'll be way too long but enjoy...
            if(sender == this.d_hasAuto)
            {
                if (!this.d_hasAuto.Checked)
                {
                    this.d_shootsAuto.Checked = false;
                    this.d_refillsAuto.Checked = false;
                }
            }
            else if(sender == this.d_shootsAuto)
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

        private void emptyDiscard(object sender, EventArgs e)
        {
            clearForm(); //Call custom clear function
        }

        private void clearSave(object sender, EventArgs e)
        {
            try
            {
                saveForm(); //Call custom save function
                clearForm(); //Clear form
            }
            catch
            {
                MessageBox.Show("One or more fields was entered incorrectly. Please fix the problem and try again.",
                                "Bad Field",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning); //Let them know something's wrong and they have to fix it
            }
        }

        private void saveExit(object sender, EventArgs e)
        {
            try
            {
                saveForm(); //Save the form
                this.Close(); //Close this form
            }
            catch
            {
                MessageBox.Show("One or more fields was entered incorrectly. Please fix the problem and try again.",
                                "Bad Field",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning); //There's something wrong...
            }
        }

        private void saveForm()
        {
            Team saveTeam = new Team(); //Create new instance of Team
            //For each of the below, it's getting the info from the form filled in by user
            saveTeam.number = Int16.Parse(this.d_teamNum.Text); //Set team number
            saveTeam.height = Int16.Parse(this.d_robotHeight.Text); //Set height
            saveTeam.weight = Int16.Parse(this.d_robotWeight.Text); //Set weight
            saveTeam.language = this.d_robotLanguage.SelectedIndex; //Set language
            saveTeam.rankpoints = (Int16)this.d_teamRankpoints.Value; //Set ranking points
            saveTeam.matches = (Int16)this.d_teamMatches.Value; //Set number of matches
            saveTeam.comments = this.d_comments.Text; //Set comments
            if (this.d_refillsAuto.Checked) saveTeam.auto = 3; //For the ifs here, going down the list and setting the int to the level of auto
            else if (this.d_shootsAuto.Checked) saveTeam.auto = 2;
            else if (this.d_hasAuto.Checked) saveTeam.auto = 1;
            else saveTeam.auto = 0;
            saveTeam.cellLevel1 = this.d_cell1.Checked; //See if they can do lv 1
            saveTeam.cellLevel2 = this.d_cell2.Checked; //See if they can do lv 2
            saveTeam.cellLevel3 = this.d_cell3.Checked; //See if they can do lv 3
            saveTeam.spin = this.d_spinPanel.Checked; //See if they can spin the panel
            saveTeam.colour = this.d_colorPanel.Checked; //See if they can set the colour
            saveTeam.under = this.d_underPanel.Checked; //See if they can go under the panel
            saveTeam.climb = this.d_canClimb.Checked; //See if they can fight
            saveTeam.balance = this.d_canBalance.Checked; //See if they can balance
            saveTeam.lift = this.d_canLift.Checked; //See if they can lift other robots
            string jArchiveContent = JsonConvert.SerializeObject(saveTeam); //Convert the saveTeam to a proper jArchive
            var jArchivePath = Environment.ExpandEnvironmentVariables("%AppData%\\MechaArchives\\"); //Expand the Appdata and add our folder
            var jArchiveFile = Environment.ExpandEnvironmentVariables("%AppData%\\MechaArchives\\" + saveTeam.number.ToString() + ".jArchive"); //Create the name of the jArchive file
            if (Directory.Exists(jArchivePath)) //Check if the file exists
            {
                //The directory exists
                File.Delete(jArchiveFile); //Delete file so that we don't just add to the file
                using (var jArchivewriter = new StreamWriter(jArchiveFile, true)) //Create temporary file writer to the file we defined
                {
                    jArchivewriter.WriteLine(jArchiveContent); //Write the jArchive
                    jArchivewriter.Close(); //Close it
                }
            }
            else if (!Directory.Exists(jArchivePath))
            {
                //Directory doesn't exist
                Directory.CreateDirectory(jArchivePath); //Create the directory
                using (var jArchivewriter = new StreamWriter(jArchiveFile, true)) //Create temporary file writer
                {
                    jArchivewriter.WriteLine(jArchiveContent); //Write the jArchive
                    jArchivewriter.Close(); //Close it
                }
            }
        }

        private void clearForm()
        {
            //Set every editable field to the default, blank or unchecked
            this.d_teamNum.Text = "";
            this.d_robotHeight.Text = "";
            this.d_robotWeight.Text = "";
            this.d_robotLanguage.SelectedIndex = -1;
            this.d_teamRankpoints.Value = 24;
            this.d_teamMatches.Value = 12;
            this.d_comments.Text = "";
            this.d_hasAuto.Checked = false;
            this.d_cell1.Checked = false;
            this.d_cell2.Checked = false;
            this.d_cell3.Checked = false;
            this.d_spinPanel.Checked = false;
            this.d_colorPanel.Checked = false;
            this.d_underPanel.Checked = false;
            this.d_canClimb.Checked = false;
            this.d_canBalance.Checked = false;
            this.d_canLift.Checked = false;
        }
    }
    
}
