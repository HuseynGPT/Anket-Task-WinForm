using Anket_Task.Models;

namespace Anket_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Person person = new Person(NameTextBox.Text, SurnameTextBox.Text, FatherNameTextBox.Text, CountryTextBox.Text, CityTextBox.Text, PhoneNumberTextBox.Text, dateTimePicker1.Value.ToShortDateString());

            if (FemaleRadioButton.Checked == true || MaleRadioButton.Checked == true)
            {
                if (FemaleRadioButton.Checked == true) { person.Gender = "Female"; }
                else if (MaleRadioButton.Checked == true) { person.Gender = "Male"; }
            }
            else { MessageBox.Show("Select your gender!!!!", "Error x89213421", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            JsonHandling.WritePersonToJson(person);
            MessageBox.Show("Saved Successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Person loadedPerson = JsonHandling.ReadPersonToJson(LoadTextBox.Text);
                NameTextBox.Text = loadedPerson.Name;
                SurnameTextBox.Text = loadedPerson.Surname;
                FatherNameTextBox.Text = loadedPerson.FathersName;
                CountryTextBox.Text = loadedPerson.Country;
                CityTextBox.Text = loadedPerson.City;
                PhoneNumberTextBox.Text = loadedPerson.PhoneNumber;
                dateTimePicker1.Text = loadedPerson.BirthDate;
                if (loadedPerson.Gender == "Male") { MaleRadioButton.Select(); }
                else if (loadedPerson.Gender == "Female") { FemaleRadioButton.Select(); }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Name not found", "Eror 12x2131231", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}