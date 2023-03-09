using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
//lab 8- raw prject

namespace imageeTestFaculty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //*******************************************************
        //*******************************************************
        //* Creating  a set of data commands and a database     *
        //*connection that are used to fill the DataSet and     *
        //*update the data source.                              *
        OleDbDataAdapter facultyAdapter;
        OleDbCommand facultyCommand;
        //*******************************************************
        //Using an open connection to access a data source
        OleDbConnection facultyConnection;
        //********************************************************************
        //declaring global variable
        string identity;
        int portfolio;
        int facultyID;
        //bolean parameters
        bool newFaculty = false;
        string choose;
        //********************************************************************
        //Creating data table
        DataTable facultyTable;
        ////The CurrencyManager object manages all the association 
        //between the DataTable (the DefaultView of the DataTable to be 
        //specific) or other bindable class and the controls they are bound to           
        CurrencyManager facultyManager;

        OleDbCommand addNewFacultyCommand;
        //**********************************************



        private void Form1_Load(object sender, EventArgs e)

        {
            //*********************************************************************
            //we hide the title bar of the form so the user is forced to click on exit button
            this.FormBorderStyle = FormBorderStyle.None;
            //center the form
            this.StartPosition = FormStartPosition.CenterScreen;
            //calling connection method
            myConnections();
            //calling binding method
            binding();

            //// call a method to fill combobox and show the first record in it
            firstFill();

        }
        private void myConnections()
        {
            // Connection string connecting to Microsoft Access database
            facultyConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + "\\faculty.mdb");
            ////Open the database
            facultyConnection.Open();
            //we can use a method here but I use the form event
            // Faculty command object
            facultyCommand = new OleDbCommand("SELECT * FROM faculty", facultyConnection);
            // establish Customers data adapter/data table
            facultyAdapter = new OleDbDataAdapter();
            facultyAdapter.SelectCommand = facultyCommand;
            facultyTable = new DataTable();
            facultyAdapter.Fill(facultyTable);
            //  currency manager binding
            facultyManager = (CurrencyManager)this.BindingContext[facultyTable];
        }
        private void binding()
        {
            // bind textboxes to data table
            firstNameTextBox.DataBindings.Add("Text", facultyTable, "FirstName");
            lastNameTextBox.DataBindings.Add("Text", facultyTable, "LastName");
            pictureLabel.DataBindings.Add("Text", facultyTable, "photo");
        }
        // a loop to extact faculty last name, first name, and ID to be displayed in a combo box
        private void firstFill()
        {
            //calling a fill method
            fillFaculty();
            //displaying first record in the combo box. 
            if (facultyComboBox.Items.Count != 0)
            {
                facultyComboBox.SelectedIndex = 0;
            }

        }
        private void fillFaculty()

        {

            //////// a loop to add records to the combobox (note a method named facultyListing under this method
            if (facultyTable.Rows.Count != 0)
            {
                for (int numberRecord = 0; numberRecord < facultyTable.Rows.Count; numberRecord++)
                {

                    facultyComboBox.Items.Add(facultyListing(facultyTable.Rows[numberRecord]["lastName"].ToString(), facultyTable.Rows[numberRecord]["firstName"].ToString(), facultyTable.Rows[numberRecord]["facultyID"].ToString()));

                }
            }
        }
        private string facultyListing(string lastName, string firstName, string facultyID)
        {
            return (lastName + ", " + firstName + " (" + facultyID + ")");
        }

        //a method that is used to display images according to the name of image
        private void ShowPhoto()
        {
            // display photo if the label is not blank
            if (pictureLabel.Text != "")
            {
                try
                {
                    facultyPictureBox.Image = Image.FromFile(pictureLabel.Text);
                }
                catch
                {
                    MessageBox.Show("Loading images was not successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                facultyPictureBox.Image = null;
            }
        }

        private void facultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for new faculty to add, we use different method
            if (newFaculty)

                return;


            //showing the selected items

            choose = facultyComboBox.SelectedItem.ToString();
            try
            {

                //Reports the zero-based index of the first occurrence of a specified Unicode character or string within this instance. The method returns -1 if the character or string is not found in this instance.
                portfolio = choose.IndexOf("(");
                if (portfolio == -1)
                    return;
                // extract ID from selected items
                identity = choose.Substring(portfolio + 1, choose.Length - portfolio - 2);

                //Columns are sorted ascending by default.Multiple columns can be separated by commas.
                facultyTable.DefaultView.Sort = "facultyID";
                //Finds a row in the DataView by the specified sort key value
                facultyManager.Position = facultyTable.DefaultView.Find(identity);
                facultyID = (int)Convert.ToInt64(identity);
                //calling the method for showing images
                ShowPhoto();
            }
            catch
            {
                MessageBox.Show("Faculty Could not be found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facultyGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
           //will make the textboxes ready for typing
            newFaculty = true;
            firstNameTextBox.Text = null;
            lastNameTextBox.Text = null;

            pictureLabel.Text = "";
            firstNameTextBox.ReadOnly = false;
            lastNameTextBox.ReadOnly = false;

            facultyComboBox.Text = "";
            facultyComboBox.SelectedText = "";
            facultyComboBox.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
            addButton.Enabled = true;
            loadImageButton.Visible = true;
            facultyPictureBox.Image = null;
        }
        //inserts the input to the table
        private void saveButton_Click(object sender, EventArgs e)
        {
            addNewFacultyCommand = new OleDbCommand(
            "INSERT INTO faculty(firstName, lastName, photo)" +
                "VALUES(@firstname, @lastname,  @photo)", facultyConnection);

            addNewFacultyCommand.Parameters.AddWithValue("@firstname", firstNameTextBox.Text);
            addNewFacultyCommand.Parameters.AddWithValue("@lastname", lastNameTextBox.Text);

            addNewFacultyCommand.Parameters.AddWithValue("@photo", (pictureLabel.Text));
            addNewFacultyCommand.ExecuteNonQuery();


            saveButton.Enabled = false;
            cancelButton.Enabled = false;
            loadImageButton.Visible = false;
            cancelButton.Visible = false;
            facultyComboBox.Enabled = true;
            imageCancelButton.Visible = false;
            facultyComboBox.Items.Clear();
            facultyTable.Clear();
            facultyAdapter.Fill(facultyTable);
            fillFaculty();
            newFaculty = false;
            facultyComboBox.SelectedIndex = 0;
        }
        //loading picture to the picturebox
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadImageDialog = new OpenFileDialog();
            loadImageDialog.InitialDirectory = Application.StartupPath + "\\image";
            if (loadImageDialog.ShowDialog() == DialogResult.OK)
            {
                pictureLabel.Text = loadImageDialog.FileName.ToString();

                ShowPhoto();
            }
        }
        //canceling the chose picture. Needs validation
        private void imageCancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                facultyPictureBox.Image = null;
                loadImageButton.Visible = true;
                pictureLabel.Text = null;

            }
            catch
            {
                MessageBox.Show("Nothing to remove");
            }
        }
    }
}
    

