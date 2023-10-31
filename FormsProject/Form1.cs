using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace FormsProject
{
    public partial class MainForm : Form
    {
        private IFirebaseConfig config;
        private FireSharp.FirebaseClient client;

        public MainForm()
        {
            InitializeComponent();
            InitializeFirebase(); // Initialize Firebase configuration
        }

        public class CarModel
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }
            public string Body { get; set; }
            public string Fuel { get; set; }
        }

        private void InitializeFirebase()
        {
            config = new FireSharp.Config.FirebaseConfig
            {
                AuthSecret = "D84WZonQIr3VqA91I1exNp2yWtJaJTjmR7DQEhR6",
                BasePath = "https://fir-windows-d1432-default-rtdb.europe-west1.firebasedatabase.app/",
            };

            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                // Firebase connection successful
                MessageBox.Show("Firebase connection successful!");
            }
            else
            {
                // Handle Firebase connection error
                MessageBox.Show("Failed to connect to Firebase!");
            }
        }


        private Dictionary<string, CarModel> searchResults;





        // Haku napin painallus
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Get the search query from the search box
            string searchTerm = SearchBox.Text.ToLower(); // Convert the search term to lowercase

            // Firebase path to your database node (replace 'cars' with your actual node name)
            string firebasePath = "cars";

            // Search for car models containing the search term
            var response = client.Get(firebasePath);

            // Clear the results panel and search results collection
            ResultsPanel.Items.Clear();
            searchResults = new Dictionary<string, CarModel>();

            if (response.Body != "null")
            {
                var carModels = response.ResultAs<Dictionary<string, CarModel>>();

                foreach (var carModel in carModels)
                {
                    if (carModel.Value.Make.ToLower().Contains(searchTerm)) // Convert to lowercase and use Contains
                    {
                        string resultText = $"{carModel.Value.Make} {carModel.Value.Model} ({carModel.Value.Year})";
                        ResultsPanel.Items.Add(resultText);
                        searchResults[resultText] = carModel.Value; // Store the CarModel object
                    }
                }

                if (ResultsPanel.Items.Count == 0)
                {
                    MessageBox.Show("Virhe: ei tuloksia");
                }
            }
            else
            {
                MessageBox.Show("Haussa tapahtui virhe");
            }
        }





        // Lisää napin painallus
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ValidateInput())
            {
                MessageBox.Show("Virheellinen syöte. Tarkista Vuosimalli kenttä.");
                return;
            }

            // Create a new CarModel object with data from textboxes
            var newCarModel = new CarModel
            {
                Make = MakeTextBox.Text,
                Model = ModelTextBox.Text,
                Year = YearTextBox.Text,
                Body = BodyTextBox.Text,
                Fuel = FuelTextBox.Text
            };

            // Generate a unique ID for the new record
            string newCarModelId = GenerateUniqueID(); // Implement this method

            // Firebase path to your database node (replace 'cars' with your actual node name)
            string firebasePath = $"cars/{newCarModelId}";

            // Add the new car model to the database
            SetResponse response = client.Set(firebasePath, newCarModel);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Tietue lisätty");
                ClearTextBoxes(); // Clear input textboxes after adding
            }
            else
            {
                MessageBox.Show("Tietuetta ei ovitu lisätä");
            }
        }

        // Luo ID Lisäysnappia varten
        private string GenerateUniqueID()
        {
            // Implement a method to generate a unique ID (e.g., using timestamp or random string)
            // Return the generated ID
            // Example using timestamp: return DateTime.Now.Ticks.ToString()
            return Guid.NewGuid().ToString(); // Using a random GUID as an example
        }





        // ToDo:Inputtien validointi. Conformation tai error
        private bool ValidateInput()
        {
            // Implement input validation, specifically for the "Year" field
            // Return true if input is valid, otherwise return false
            // Example: check if Year is a valid numeric value
            if (!int.TryParse(YearTextBox.Text, out _))
            {
                return false;
            }

            return true;
        }
        




        // Update napin painallus
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ResultsPanel.SelectedIndex >= 0)
            {
                // Get the selected "Make" value from the ResultsPanel
                string selectedMake = ResultsPanel.SelectedItem.ToString();

                if (searchResults.ContainsKey(selectedMake))
                {
                    // Retrieve the CarModel object associated with the selected "Make"
                    CarModel selectedCarModel = searchResults[selectedMake];

                    // Get the unique ID of the selected car model
                    string carModelId = GetCarModelId(selectedCarModel);

                    // Create a car model object with updated information
                    var updatedCarModel = new CarModel
                    {
                        Make = MakeTextBox.Text,
                        Model = ModelTextBox.Text,
                        Year = YearTextBox.Text,
                        Body = BodyTextBox.Text, // Add the Body property
                        Fuel = FuelTextBox.Text   // Add the Fuel property
                    };

                    // Firebase path to your database node (replace 'cars' with your actual node name)
                    string firebasePath = $"cars/{carModelId}";

                    // Update the car model in Firebase
                    var response = client.Set(firebasePath, updatedCarModel);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Car model updated successfully!");
                        ClearTextBoxes(); // Clear input textboxes after updating
                    }
                    else
                    {
                        MessageBox.Show("Failed to update car model.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a car model to update.");
                }
            }
        }

        // Luo ID autoille jotta voit päivittää niitä
        private string GetCarModelId(CarModel carModel)
        {
            string searchTerm = carModel.Make;

            // Firebase path to your database node (replace 'cars' with your actual node name)
            string firebasePath = "cars";
            var response = client.Get(firebasePath);

            if (response.Body != "null")
            {
                var carModels = response.ResultAs<Dictionary<string, CarModel>>();

                foreach (var entry in carModels)
                {
                    if (entry.Value.Make.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                    {
                        return entry.Key; // Return the ID of the matching car model
                    }
                }
            }

            return string.Empty; // Return an empty string if no match is found
        }





        // Clear nappi painallus
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(); // Call the ClearTextBoxes method to clear the textboxes
        }

        // Clear nappi toiminta
        private void ClearTextBoxes()
        {
            MakeTextBox.Text = "";
            ModelTextBox.Text = "";
            YearTextBox.Text = "";
            BodyTextBox.Text = "";
            FuelTextBox.Text = "";
            ResultsPanel.Items.Clear();
        }





/* TODO Delete function
private void DeleteButton_Click(object sender, EventArgs e)
{
    if (ResultsPanel.SelectedIndex >= 0)
    {
        // Get the unique ID of the car model to delete
        string carModelId = searchResults.Keys.ElementAt(ResultsPanel.SelectedIndex);

        // Firebase path to your database node
        string firebasePath = $"cars/{carModelId}";

        // Delete the car model in Firebase
        var response = client.Delete(firebasePath);

        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            MessageBox.Show("Car deleted successfully");
            ClearTextBoxes(); // Clear input textboxes after deleting
        }
        else
        {
            MessageBox.Show("Failed to delete car.");
        }
    }
    else
    {
        MessageBox.Show("Please select a car to delete.");
    }
}
*/





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void ResultsPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResultsPanel.SelectedIndex >= 0)
            {
                // Get the selected "Make" value from the ResultsPanel
                string selectedMake = ResultsPanel.SelectedItem.ToString();

                if (searchResults.ContainsKey(selectedMake))
                {
                    // Retrieve the CarModel object associated with the selected "Make"
                    CarModel selectedCarModel = searchResults[selectedMake];

                    // Display the information in the corresponding textboxes
                    MakeTextBox.Text = selectedCarModel.Make;
                    ModelTextBox.Text = selectedCarModel.Model;
                    YearTextBox.Text = selectedCarModel.Year;
                    BodyTextBox.Text = selectedCarModel.Body;
                    FuelTextBox.Text = selectedCarModel.Fuel;
                    // Add code to display Body and Fuel properties if needed
                }
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }


        private void Make_TextChanged(object sender, EventArgs e)
        {
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
