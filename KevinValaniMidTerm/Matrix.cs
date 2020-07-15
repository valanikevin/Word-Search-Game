using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KevinValaniMidTerm
{
    public partial class Home
    {
        List<string> grid = null;
        const string randString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        bool buildMatrix(int size)
        {
            grid = new List<string>(10); 
            mainGrid.Text = "";
            bool status = false;
            for (int i=0; i<size; i++)
            {
                Random rnd = new Random();
                string tempString = null;
                mainGrid.Text += Environment.NewLine;
                for (int j=0; j<size; j++)
                {
                    tempString += randString[rnd.Next(0, 25)];
                    //mainGrid.Text+= randString[rnd.Next(0, 25)];

                }
                grid.Insert(i, tempString);
            }
            txtSearch.Text = grid[0];
            return status;
        }

        void printMatrix()
        {
            mainGrid.Text = "";
            for (int i=0; i<grid.Count; i++)
            {
                string tempString = grid[i];
                string tempString1 = null;
                for (int j=0; j<grid.Count; j++)
                {
                    try
                    {
                        tempString1 += String.Format(tempString[j] + "\t");
                    }
                    catch (Exception ex)
                    {

                    }
                    
                }
                mainGrid.Text += tempString1+Environment.NewLine;
            }
        }
    }
}
