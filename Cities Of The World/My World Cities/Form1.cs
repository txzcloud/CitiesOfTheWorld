using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Cities
{
	public partial class Form_worldCities : Form
	{
		// This holds the raw data read from the City Country file
		private string[] rawCityCountryData = null;
		// Here we store the mapping from city to Country
		Dictionary<string, string> countryOf = null;
		// Here we store the mapping from city to population
		Dictionary<string, int> populationOf = null;

		/// <summary>
		/// Constructor for the main form
		/// </summary>
		public Form_worldCities()
		{
			// This initializes the form and all of its components
			InitializeComponent();

			// Now that the form's components have been initialized
			// We can go load the City Country data
			loadData();
			// And then we fill the combo box
			fillListBox();
		}

		public class populationCityPair
		{
			// The population
			public int population;
			// The city
			public string city;
			/// <summary>
			/// Simple constructor for a popuation/City pair
			/// </summary>
			/// <param name="pop"></param>
			/// <param name="city"></param>
			public populationCityPair(int pop, String city) 
			{ 
				// Just set the population and city fields
				population = pop; 
				this.city = city; 
			}
		};

		//Above code was not manipulated
		//---------------------------------------------------------------------------------------------------------------------------
		//Below is my committed code for this project #3

		private void comboBox_City_SelectionChangeCommitted(object sender, EventArgs e)
		{
			// Get the selected city;
			string city = comboBox_City.SelectedItem.ToString();
			// Set its country by finding the exact string match of the city
			//reference: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.combobox.findstringexact?view=net-5.0
			comboBox_Country.SelectedIndex = comboBox_Country.FindStringExact(countryOf[city]);
			// Set its population
			label_Population.Text = populationOf[city].ToString("N0");
		}

		private void comboBox_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
			//initialized variables
			// holds the count of each country's pop
			int countryPop = 0;

			//first before call, to clear the cities from the comboboxes
			comboBox_City.Items.Clear();

			//get selected country
			string country = comboBox_Country.SelectedItem.ToString();

			//this is the dict that holds the country's cities
			Dictionary<string, int> cities = new Dictionary<string, int>();

			//for looping to find each city that exist within a specified country
			foreach (KeyValuePair<string, string> cityCountry in countryOf)
			{
				//checking to see if the citycountry valie matches directly with the country
				if (cityCountry.Value.Equals(country))
				{
					//if true, it will add said city to the combobox for the cities
					cities.Add(cityCountry.Key, populationOf[cityCountry.Key]);
				}
			}

			//--------------------------------------------------------------------------------
			//piechart customization section below

			//setting the piechart to be visible
			countryChart.Visible = true;
			//adding the tooltip so when mouse is hovered, it will show the city's population
			//reference: https://www.aspforums.net/Threads/119482/Display-data-in-Tooltip-on-Pie-Chart-Mouse-Hover-using-C-and-VBNet-in-ASPNet/
			countryChart.Series["City"].ToolTip = "Population:  #VALY"; // reference - set tooltip for piechart

			//this is just to disable the labels of piechart due to the unreadable labels overlapping each other on the chart
			//reference: https://stackoverflow.com/questions/2147930/hide-labels-in-pie-charts-ms-chart-for-net
			countryChart.Series["City"]["PieLabelStyle"] = "Disabled"; // reference - disable labels of piechart

			//clearing and adding titles for piechart
			//reference: https://stackoverflow.com/questions/13320181/how-to-set-and-show-title-to-pie-chart-using-ms-chart
			countryChart.Titles.Clear();
			countryChart.Titles.Add("PieChart of All Cities Within Selected Country");
			countryChart.Titles.Add("[Please hover mouse over piechart for tool tip]");

			//this is a separate dict that will sort cities by its population
			Dictionary<string, int> sortedCities = cities.OrderByDescending(p => p.Value).ToDictionary(p => p.Key, p => p.Value);
			//clearing the data series to avoid overlapping of data when reselection of country
			countryChart.Series["City"].Points.Clear();


			//for looping to add city pop to data series of chart, also to summate the total population
			foreach (KeyValuePair<string, int> cityPopulation in sortedCities)
			{
				comboBox_City.Items.Add(cityPopulation.Key);
				countryPop += cityPopulation.Value;
				countryChart.Series["City"].Points.AddXY(cityPopulation.Key, cityPopulation.Value);
			}
			//starting the selected index at 0
			comboBox_City.SelectedIndex = 0;
			//displaying the total pop for a country to the label
			label_Population.Text = countryPop.ToString("N0");
		}

		//below is the reset button, after each reset, clears the comboboxes and charts
		private void resButton_Click(object sender, EventArgs e)
		{
			//allow the chart's visible to set to false, not showing the chart after reset button is clicked
			countryChart.Visible = false;
			//calls the fillListBox function to fill out the cities and countries for the two existing comboboxes
			fillListBox();
		}

	}
}
