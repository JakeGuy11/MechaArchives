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

        private void d_pullButton_Click(object sender, EventArgs e)
        {
            Button teamButtons; //Raw button that I can edit the settings of later
            Label myLabel = this.label1;
            GroupBox teamBox = this.d_teamBox; //The GroupBox that I want the buttons to appear in
            for(int i = 0; i <16; i++) //8 is just there for now, I'll change it later. It's going downwards so the buttons appear in the proper order (1 -> 8 instead of 8 -> 1)
            {
                teamButtons = new Button(); //Initialize the button
                teamButtons.Name = i.ToString(); //Set the id/name
                teamButtons.Text = teamButtons.Name; //Set text to the id/name
                teamButtons.Dock = DockStyle.Top; //Dock to the top
                teamButtons.Size = new Size(144, 23); //This is the full size of the GroupBox
                teamButtons.Click += (object sender1, EventArgs e1) => { displayTeamChosen(sender, e, i); };
                teamBox.Controls.Add(teamButtons); //Add the button
            }
        }

        private void displayTeamChosen(object sender, EventArgs e, int n)
        {
            d_teamBox.Text = "teamNum is " + n.ToString();
        }
    }
}
