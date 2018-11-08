// Grading ID: C3527
// Due Date: 4/25/17
// Program 4
// CIS 199-75
// This program takes the origin and destination zip code for a package, along with its length, height, width, and weight and calculates the price
// to deliver the package. The price is then added to a listBox. There is a button that will display the details of the package in a MessageBox and there 
// are two buttons, one that will change the destination zip code to 40202 and one that will change the origin zip code to 40202.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class Package : Form
    {
        // List to hold package objects
        List<GroundPackage> packageList = new List<GroundPackage>();

        public Package()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)

        {
            GroundPackage package = new GroundPackage();      // Holds new package
            ValidatePackageData(package);                     // Makes sure data is valid  
            packageList.Add(package);                         // Adds package to list
            double cost = package.CalcCost();                 // Holds the package cost
            packageListBox.Items.Add(cost.ToString("c2"));    // Adds package cost to list

            // Clear textbox controls
            originZipCodeTextBox.Clear();
            DestinationZipCodeTextBox.Clear();
            lengthTextBox.Clear();
            heightTextBox.Clear();
            widthTextBox.Clear();
            weightTextBox.Clear();

            // Refocus
            originZipCodeTextBox.Focus();
 
        }

        // Precondition: None
        // Postcondition: Gets and parses inputted data and then assigns the data to the correct variable.    
        public void ValidatePackageData(GroundPackage package)
        { 
            int originZip;              // Holds origin Zip Code
            int destinationZip;         // Holds destination Zip Code
            double length;              // Holds package length
            double height;              // Holds package height
            double width;               // Holds package width
            double weight;              // Holds package weight

            if (int.TryParse(originZipCodeTextBox.Text, out originZip) && originZip >= 11111 && originZip <= 99999)
                package.OriginZip = originZip;
            else
                MessageBox.Show("Please enter a valid zip code.");

            if (int.TryParse(DestinationZipCodeTextBox.Text, out destinationZip) && destinationZip >= 11111 && destinationZip <= 99999)
                package.DestinationZip = destinationZip;
            else
                MessageBox.Show("Please enter a valid zip code.");

            if (double.TryParse(lengthTextBox.Text, out length) && length >= 1)
                package.Length = length;
            else
                MessageBox.Show("Please enter a number greater than 1.");

            if (double.TryParse(heightTextBox.Text, out height) && height >= 1)
                package.Height = height;
            else
                MessageBox.Show("Please enter a number greater than 1.");

            if (double.TryParse(widthTextBox.Text, out width) && width >= 1)
                package.Width = width;
            else
                MessageBox.Show("Please enter a number greater than 1.");

            if (double.TryParse(weightTextBox.Text, out weight) && weight >= 1)
                package.Weight = weight;
            else
                MessageBox.Show("Please enter a number greater than 1."); 
         }
        // Precondition: None
        // Postcondition: Will display the details of the package in a messageBox
        private void detailsButton_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex; ;  // index of selected item

            if (index >= 0)
                MessageBox.Show(packageList[index].ToString());
            else
                MessageBox.Show("Please select a package from the list.");
        }
        // Precondition: None
        // Postcondition: Will change the destination zip code property to 40202
        private void sendToButton_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex; ;

            if (index >= 0)
            {
                packageList[index].DestinationZip = 40202;          // Changes the zip code property
                double cost = packageList[index].CalcCost();        // Holds the new cost
                packageListBox.Items[index] = cost.ToString("C2");  // Outputs the new cost
                MessageBox.Show("The selected package's destination zip code has been changed.");
            }
            else
                MessageBox.Show("Please select a package from the list.");
        }
        // Precondition: None
        // Postcondition: Will change the origin zip code property to 40202
        private void sendFromButton_Click(object sender, EventArgs e)
        {
            int index = packageListBox.SelectedIndex; ;  // Value to hold index

             if (index >= 0)
            {
                packageList[index].OriginZip = 40202;               // Changes the zip code property
                double cost = packageList[index].CalcCost();        // Holds the new cost
                packageListBox.Items[index] = cost.ToString("C2");  // Outputs the new cost
                MessageBox.Show("The selected package's origin zip code has been changed.");
            }
            else
                MessageBox.Show("Please select a package from the list.");
        }
    }
}

