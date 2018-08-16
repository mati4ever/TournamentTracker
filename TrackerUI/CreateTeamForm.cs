using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData(); 
            WireUpLists();
        }

     

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
            

        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Matthew" , LastName = "Zaho"});
            availableTeamMembers.Add(new PersonModel { FirstName = "Michał", LastName = "Dziuba"});

            selectedTeamMembers.Add(new PersonModel { FirstName = "Angelika", LastName = "Krzak" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Joe", LastName = "Potter" });
        }



        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValueTextBox.Text;
                p.LastName = lastNameValueTextBox.Text;
                p.EmailAddress = emailValueTexBox.Text;
                p.CellphoneNumber = phoneValueTextBox.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

                firstNameValueTextBox.Text = "";
                lastNameValueTextBox.Text = "";
                emailValueTexBox.Text = "";
                phoneValueTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("You nees to fill all of the fields.");
            }

        }

        private bool ValidateForm()
        {
            //TODO - Add validation to the form.
            if (firstNameValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (emailValueTexBox.Text.Length == 0)
            {
                return false;
            }
            if (phoneValueTextBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValueTextBox.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            // TODO - Close or reset the form after creation
        }
    }
}
