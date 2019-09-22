// Copyright (c) 2019 Oregon State University

//Authored by Rohan Pankaj

//cite README for Referneces

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.LinearAlgebra.Double;

namespace OSUBendingTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ------------------------Constructor Variables-------------------------------


        // File Location Variables
            public static string FILEPATH; //Path of the csv file
            public static string FOLDERPATH;
            public static string CURRENTSPECIMEN;
        Random rand = new Random();

        // Specimen Properties
            public static double Pmax;
            public static double CYLDEFmax;
            public static double MOE;
            public static double MOR;
            public static double span;
            public static double width;
            public static double depth;

        // Values for Graph
            public static List<double> xValueList = new List<double>(); //x Values for the data graph 
            public static List<double> yValueList = new List<double>(); //y values for the data graph

        // Calculation Method
            public static int CalculationMethod;
       
        public static bool ThreePointCalculationMethodState;
        public static bool FourPointCalculationMethodState;


     
        

        //______________________________________________________________________________Form Setup________________________________________________________________________________________________________________________

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ResetForm()
            // Resets all TextBoxes and Specimen Deependent Values in the Form
        {
            CurrentSpecimenValue_Label.Text = CURRENTSPECIMEN;
            
            Span_TaxtBox.Text = "";
            Depth_TextBox.Text = "";
            Width_TextBox.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            CalculationMethod = 0;

            MaxLoadValue_Label.Text = "---";
            MOEValue_Label.Text = "---";
            MORValue_Label.Text = "---";
            MaxCylindricalDeflectionValue_Label.Text = "---";

            


            FilePath_Label.Text = "---";

            LowerBound_NumericUpDown.Value = 0;
            UpperBound_NumericUpDown.Value = 100;


            

        }
        //____________________________________________________________________________________Graphic User Interphase Events______________________________________________________________________________________________________
        private void SpecimenNumber_NumericUpDown_ValueChanged(object sender, EventArgs e)
            // Calls The new Specimen command which changes the file path and resets the form 
        {
            NewSpecimen();
        }
        private void GraphRegression_Button_Click(object sender, EventArgs e)
            // Graphs the Linear Regression
        {
            GraphRegression();
        }
        public void GraphData_Button_Click(object sender, EventArgs e)
            // Graphs the data
        {
            GraphData();
        }
        private void ImportData_Button_Click(object sender, EventArgs e)
        // Name: ImportData_Clickd
        //Description: When the "Import Data" button is clicked a diolog withh open prompting the user to open a data file
        //Inputs: User Selected data file
        //Returns: Nothing but assigns FILEPATH variable to the path of the file
        {
            ImportData();

        }
        private void CalculateProperties_Button_Click(object sender, EventArgs e)
            // Calls the Calculate Properties method and then displays the properties with the Display Properties Method
        {
            CalculateProperties();
            DisplayProperties();
        }
        private void LowerBound_NumericUpDown_ValueChanged(object sender, EventArgs e)
            // Gives user an error as the range feautre has not been implemetned yet
        {
            LowerBoundNumericUpDown_errorProvider.SetError(LowerBound_NumericUpDown, "This feature has not been impemented yet");
            
        }
        private void UpperBound_NumericUpDown_ValueChanged(object sender, EventArgs e)
            // Gives user an error as the range feature has not been impeleneted yet
        {
            UpperBoundNumericUpDown_errorProvider.SetError(UpperBound_NumericUpDown, "This feature has not been impemented yer");
        }
        //____________________________________________________________________________________Calculations_______________________________________________________________________________________
        private void CalculateProperties()
            //Name: CalcualteProperties
            //Description: declares span, width, and depth variables according to the user inputs, Then calls the methods form calculating the differtn properties
                            // ie. MOR, MOE, Max Load, and Max Cylindrical Deflection
            //Input: Takes the user inputs of Span, Depth and Width
            //Returns: Nothing but calls functions to calculate MOR, MOE, Max Load and Max Cylindrical Deflection
        {
            //Calculation Method
            ThreePointCalculationMethodState = radioButton1.Checked;
            FourPointCalculationMethodState = radioButton2.Checked;

            
            //User inputed variables
            span = Convert.ToDouble(Span_TaxtBox.Text);
            width = Convert.ToDouble(Width_TextBox.Text);
            depth = Convert.ToDouble(Depth_TextBox.Text);

            // Maximum values
            Pmax = FindHighestLoadValue();
            CYLDEFmax = FindMaxClyndDef();

            CSVColumnToList(1, 2, "LoadF"); // write the 1st and 2nd columns of the csv file to the xValueList and yValue List respectivly 


            // use the appropriate calculatoins for the selected calculation method
            if (ThreePointCalculationMethodState == true && FourPointCalculationMethodState == false)
            {
                ThreePointCalculateMOE();
                ThreePointCalculateMOR();
            }
            else if (FourPointCalculationMethodState == true && ThreePointCalculationMethodState == false)
            {
                CalculateProperties_errorProvider.SetError(CalculateProperties_Button, "This Feature has not been implementedy yet");
            }
            else
            {
                CalculateProperties_errorProvider.SetError(CalculateProperties_Button, "This is not a valid operation chech the Calculation Method");
            }
        }
        private void ThreePointCalculateMOE()
            // Calculate the MOE for the 3 point calculation method
        {
            MOE = (Pmax * (span * span * span) / (48 * ((width * (depth * depth * depth)) / 12) * CYLDEFmax));
        }


        private void ThreePointCalculateMOR()
            // Calculate the MOR for the 4 point calculation method
        {
            MOR = ((Pmax * span) / ((depth * (width * width)) / 6));

        }

        private static double yPrediction(double xCoordinate, double[] theta)
        //Name: yPrediction
        //Description: Makes a prediction y Coordinate based on the y Coordinate for the linear regression
        //Inputa: xCoordinate - the x Coordinate, theta - the list of y Coordinates
        //OutPut: yCorrdinate - the predicted yCorrdinate for the xCoordinate 
        {
            var yCoordinate = 0.0;
            for (var i = 0; i < theta.Length; i++)
            {
                yCoordinate += theta[i] * Math.Pow(xCoordinate, i);
            }
            return yCoordinate;
        }
        //___________________________________________________________________________________________Supporting Methods____________________________________________________


        protected static double FindHighestLoadValue()
            //Name: FindHighestLoadValue
            //Description: Finds the Maximum Load from the data
            //Inputs: none but uses the xValueList variable
            //Retruns: maxValue - the maximum value
        {
            // ConvertCSVtoDataTable(FILEPATH);
            // DataTable dt = 
            double maxValue = Convert.ToDouble(xValueList.DefaultIfEmpty().Max<double>());
            return maxValue;
        }
        protected static double FindMaxClyndDef()
            //Name: FindMaxCylDef
            //Description: Finds the Maximum Cylindrical Deflection from the data
            //Inputs: non but uses the yValueList variable
            //Retruns: maxValue - the maximum value
        {
            // ConvertCSVtoDataTable(FILEPATH);
            // DataTable dt = 
            double maxValue = Convert.ToDouble(yValueList.DefaultIfEmpty().Max<double>());
            return maxValue;
        }


        private void CSVColumnToList(int FirstColumnNumber, int SecondColumnNumber, string FirstColumnHeadder)
        //Name: CSVColumnToList
        //Description: Converts two columns of a csv file to lists
        //Inputs: string FILEPATH - the path of the csv, int FirstColumnNumber - the number of the first column with 0 being the first,
        //int SecondColumnNumber - the number of the second column with 0 being the first, string FirstColumnHeader - the header of the first Column
        //Returns: Nothing but adds the values from the FirstColumn to the xValueList and the values from the SecondColumn to the yValueList 
        {

            var reader = new StreamReader(File.OpenRead(FILEPATH));

            while (!reader.EndOfStream)
            {
                if (!reader.ReadLine().Contains(FirstColumnHeadder))
                {
                    var line = reader.ReadLine();
                    var values = reader.ReadLine().Split(new char[] { Convert.ToChar(',') }); //This line is having an error
                    xValueList.Add(Convert.ToDouble(values[FirstColumnNumber]));

                    yValueList.Add(Convert.ToDouble(values[SecondColumnNumber]));
                }
            }
        }


        private void ImportData()
        // Name: ImportData
            //Description: diolog opens prompting the user to open a data file
            //Inputs: User Selected data file
            //Returns: Nothing but assigns FOLDERPPATH variable to the path of the file
        {
            FolderBrowserDialog DataFile = new FolderBrowserDialog();

            if (DataFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FOLDERPATH = DataFile.SelectedPath;

            }
        }

        private void NewSpecimen()
            //When a new specimen in selected first the method gets the filepath of the new specimen with
                //the GetFilePath_from_FolderPath() method then resets the form with the ReserForm() method
        {
            GetFilePath_from_FolderPath();
            ResetForm();
        }
        private void GetFilePath_from_FolderPath()
            //Name: GetFilePath_form_FolderPath
            //Description: assigns the FILEPATH variable to the path of the current specimen
            //Inputs: None but uses the FOLDERPATh variable
            //Retruns: None but assigns the FILEPATH variable to the path of the current Specimen
        {
            string[] split = FOLDERPATH.Split(new char[] { Convert.ToChar("\\") });

            string SpecimenType = split.Last();
            string SpecimenName;

            if (SpecimenNumber_NumericUpDown.Value <= 9)
            {
                SpecimenName = SpecimenType + "_0" + SpecimenNumber_NumericUpDown.Value;
            }
            else
            {
                SpecimenName = SpecimenType + "_" + SpecimenNumber_NumericUpDown.Value;
            }

            CURRENTSPECIMEN = SpecimenName;
            FILEPATH = FOLDERPATH + "\\" + SpecimenName + ".csv";
            FilePath_Label.Text = FILEPATH;
            FilePath_Label.Text = FILEPATH;


        }

        //_______________________________________________________________________________________Displaying Values to the Graphic User Interphase (GUI)___________________________________________________


        public void GraphRegression()  //-- GraphRegression() Code adapted from http://csharpexperiments.blogspot.com/2014/04/multivariate-linear-regression.html
        // Name:GraphRegression
        //Description: Graphs the Linear Regression
        //Input: None but uses xValueList and yValueList variables
        //OutPut: Graphs the Linear Regression on chart1
        {

            chart1.Series.Add("Regression Line");
            chart1.Series["Regression Line"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Regression Line"].Color = Color.Orange;

            int degree = 1;
            double[] xValueDefArray = xValueList.ToArray();
            double[] yValueDefArray = yValueList.ToArray();
            chart1.Series["Regression Line"].Points.Clear();
            var xLinearRegression = new DenseMatrix(xValueList.Count, degree + 1);
            var yLinearRegression = DenseMatrix.OfColumns(yValueList.Count, 1, new[] { new DenseVector(yValueDefArray) });
            xLinearRegression.SetColumn(0, DenseVector.Create(xValueList.Count, i => 1));

            xLinearRegression.SetColumn(1, xValueDefArray);

            for (int i = 2; i <= degree; i++)
            {
                xLinearRegression.SetColumn(i, xLinearRegression.Column(1).PointwiseMultiply(xLinearRegression.Column(i - 1)));
            }


            var qrTheta = xLinearRegression.QR().Solve(yLinearRegression).ToColumnMajorArray();


            for (var i = 0; i < xValueList.Count; i++)
            {
                chart1.Series["Regression Line"].Points.AddXY(xValueList[i], yPrediction(xValueList[i], qrTheta));
            }
        }
        public void GraphData() //-- GraphData() Code adapted from http://csharpexperiments.blogspot.com/2014/04/multivariate-linear-regression.html
        //Name: GraphData
        //Description: convert the csv to a datatable and graph the data
        //Inputs: Nothing but using the xValueList and yValueList variables
        //OutPut: Nothing but creates a graph 
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("linear Regression");
            chart1.Series.Clear();
            chart1.Series.Add("Data Points");
            chart1.Series["Data Points"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;


            for (var i = 0; i < xValueList.Count; i++)
            {
                chart1.Series["Data Points"].Points.AddXY(xValueList[i], yValueList[i]);
            }
        }
        private void DisplayProperties()
            //Name: DisplayProperties
            //Description: Outouts the Properties to their corresponding Value Label on the form
            //Inputs: none but uses the Pmax, MOR, MOE, and CYLDEFmax variables
            //Retruns: none but outputs MOE to MOEValue_Label, MOR to MORValue_Label, Pmax to MaxLoadvalue_Label, and CYLDEF to MaxCylindricalDeflectionValue_label
        {
            MaxLoadValue_Label.Text = Convert.ToString(Pmax);
            MORValue_Label.Text = Convert.ToString(MOR);
            MOEValue_Label.Text = Convert.ToString(MOE);
            MaxCylindricalDeflectionValue_Label.Text = Convert.ToString(CYLDEFmax);
        }

       
    }
    

}

