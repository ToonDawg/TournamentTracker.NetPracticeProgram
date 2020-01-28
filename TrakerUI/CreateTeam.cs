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
    public partial class CreateTeam : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        public CreateTeam()
        {
            InitializeComponent();

            //CreateSampleData();

            wireUpLists();
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { EmailAddress = "dog@dog", FirstName = "toons", LastName = "Johnson" });
            availableTeamMembers.Add(new PersonModel { EmailAddress = "dog@dog", FirstName = "Artz", LastName = "Johnson" });

            selectedTeamMembers.Add(new PersonModel { EmailAddress = "dog@dog", FirstName = "Pans", LastName = "Johnson" });
            selectedTeamMembers.Add(new PersonModel { EmailAddress = "dog@dog", FirstName = "Ngatai", LastName = "Johnson" });
        

        }

        private void wireUpLists()
        {
            selectTeamCombo.DataSource = null;
            selectTeamCombo.DataSource = availableTeamMembers;
            selectTeamCombo.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            //Validate form
            if (ValidateForm())
            {
                //Create Prize model
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.MobileNumber = mobileValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                wireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                mobileValue.Text = "";
            }


            //save the prize model

            //Clear out the form
        }

        private bool ValidateForm()
        {
            string fName = firstNameValue.Text;
            string lName = lastNameValue.Text;
            string email = emailValue.Text;
            string mobile = mobileValue.Text;
            int testMobile;
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (mobileValue.Text.Length == 0)
            {
                return false;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("Check that your email is correct.");
                return false;
                
            }
            else if (!int.TryParse(mobile, out testMobile))
            {
                MessageBox.Show("Please check your mobile and try again");
                return false;
            }
            
            return true;
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamCombo.SelectedItem;

            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            wireUpLists();
        }

        private void deleteSelMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                wireUpLists();
            }
            
        }

        private void createMemberButton_Click_1(object sender, EventArgs e)
        {
            //Validate form
            if (ValidateForm())
            {
                //Create Prize model
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.MobileNumber = mobileValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                wireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                mobileValue.Text = "";
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            //TODO = If we arent closing the form after creation reset form.
        }
    }
}
