# Bend&trade;
![Logo](https://raw.githubusercontent.com/RohanPankaj/Bend/master/READMEImages/newBendLogo.PNG)


An application for calculating and storing data for Bending Test Analysis. Created in Collaboration with The Oregon State University College of Forestry Wood Science Innovation Center. Read Below to learn how to use and download Bend&trade;. Refernece the License to Read about Using Bend&trade; : https://github.com/RohanPankaj/Bend/blob/master/LICENSE


## Using Bend&trade;
1. Launch The Application
 *![Step 1](https://raw.githubusercontent.com/RohanPankaj/Bend/master/READMEImages/openApplication.PNG)
2. Import Your Data Folder -- Note that Bend only uses CSV Files
 *![Step 2](https://raw.githubusercontent.com/RohanPankaj/Bend/master/READMEImages/step2.PNG)
3. Select Your Specimen Number
 *![Step 3](https://raw.githubusercontent.com/RohanPankaj/Bend/master/READMEImages/step3.PNG)
4. Input the Specimen Dimensions
 *![Step 4](https://raw.githubusercontent.com/RohanPankaj/Bend/master/READMEImages/step4.PNG)
5. Select your Calculation Method
 *![Step 5](https://raw.githubusercontent.com/RohanPankaj/Bend/master/READMEImages/step5.PNG)
6. Push the Calculate Properties Button to Calculate the MOE, MOR, MAx Load and Max Cylindrical Deflection
  *![Step 8](https://raw.githubusercontent.com/RohanPankaj/Bend/master/READMEImages/step6.PNG)
 7. Push the Graph Data Button to Graph the Data onto the Grid
  *![Step 7](https://raw.githubusercontent.com/RohanPankaj/Bend/master/READMEImages/step7.PNG)
 8. Push the Graph Regression Button to Graph the Linear Regression onto the Grid
  *![Step 1](https://raw.githubusercontent.com/RohanPankaj/Bend/master/READMEImages/step8.PNG)


## DownLoading Bend&trade;

First Download the leatest Version of Bend&trade;, which can be found here: https://github.com/RohanPankaj/Bend/releases. 

In order to Download Bend as an application you will first need Visual Studio Code Community Eddition wich can be downloaded here: https://visualstudio.microsoft.com/downloads/.

Once you have Visual Studio Code Commmunity under the Build Tab Select Publish. The setup wizard will now appear giving you instructions to publish the code to your system or FTP Server. For questions aboutl publishing refernce the Microsoft Guide: https://docs.microsoft.com/en-us/visualstudio/deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard?view=vs-2019. 

## References

The "Graph Data" and "Graph Regression" methods -  lines 313 to 365 of Form1.cs (Form1: https://github.com/RohanPankaj/Bend/blob/master/Bend/Form1.cs) was adapted from http://csharpexperiments.blogspot.com/2014/04/multivariate-linear-regression.html.

