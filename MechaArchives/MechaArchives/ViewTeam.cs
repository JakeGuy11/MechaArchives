using Newtonsoft.Json;
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
    public partial class ViewTeam : Form
    {

        private static readonly string jArchivePath = Environment.ExpandEnvironmentVariables("%AppData%\\MechaArchives\\");

        public ViewTeam()
        {
            InitializeComponent();
        }

        private void ViewTeam_Load(object sender, EventArgs e)
        {
            Team selectedTeam = new Team();
            selectedTeam = JsonConvert.DeserializeObject<Team>(File.ReadAllText(jArchivePath + this.Text + ".jArchive"));
            this.Text = "Team " + selectedTeam.number;
            this.d_titleLabel.Text = this.Text;
            this.d_height.Text = selectedTeam.height + " inches";
            this.d_weight.Text = selectedTeam.weight + " lbs";
            this.d_totalRank.Text = selectedTeam.rankpoints + " ranking points";
            this.d_avgRank.Text = selectedTeam.avgRankpoints() + " ranking points / match";
            this.d_matches.Text = selectedTeam.matches + " matches";
            this.d_comments.Text = selectedTeam.comments;
            if (selectedTeam.language == 0) this.d_language.Text = "C++";
            else if (selectedTeam.language == 1) this.d_language.Text = "Java";
            else if (selectedTeam.language == 2) this.d_language.Text = "Python";
            else if (selectedTeam.language == 3) this.d_language.Text = "CHANGE ME JAKE";
            else this.d_language.Text = "Other";
            if(selectedTeam.auto == 3)
            {
                this.d_hasAuto.ForeColor = System.Drawing.Color.Black;
                this.d_shootsAuto.ForeColor = System.Drawing.Color.Black;
                this.d_refillsAuto.ForeColor = System.Drawing.Color.Black;
            }
            else if(selectedTeam.auto == 2)
            {
                this.d_hasAuto.ForeColor = System.Drawing.Color.Black;
                this.d_shootsAuto.ForeColor = System.Drawing.Color.Black;
            }
            else if(selectedTeam.auto == 1)
            {
                this.d_hasAuto.ForeColor = System.Drawing.Color.Black;
            }
            if (selectedTeam.cellLevel1 == true) this.d_cell1.ForeColor = System.Drawing.Color.Black;
            if (selectedTeam.cellLevel2 == true) this.d_cell2.ForeColor = System.Drawing.Color.Black;
            if (selectedTeam.cellLevel3 == true) this.d_cell3.ForeColor = System.Drawing.Color.Black;
            if (selectedTeam.spin == true) this.d_spins.ForeColor = System.Drawing.Color.Black;
            if (selectedTeam.colour == true) this.d_colour.ForeColor = System.Drawing.Color.Black;
            if (selectedTeam.under == true) this.d_under.ForeColor = System.Drawing.Color.Black;
            if (selectedTeam.climb == true) this.d_climb.ForeColor = System.Drawing.Color.Black;
            if (selectedTeam.balance == true) this.d_balance.ForeColor = System.Drawing.Color.Black;
            if (selectedTeam.lift == true) this.d_lift.ForeColor = System.Drawing.Color.Black;

        }
    }
}
