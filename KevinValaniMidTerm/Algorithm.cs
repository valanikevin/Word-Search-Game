using System;
using System.Collections.Generic;
using System.Text;

namespace KevinValaniMidTerm
{
    public class RowW : Row
    {
        public override bool isRow(string uString)
        {
            bool status = false;
            if (!(uString.Contains(Environment.NewLine)))
            {
                status = true;
            }
            return status;
        }
    }
    public partial class Home
    {
        bool searchString(string sString)
        {
            RowW row = new RowW();
            if (row.isRow(sString)==false)
            {
                txtResult.Text = "Please Enter Valid String.";
            }
            bool oStatus = false;
            bool horStatus = checkHorRow(sString);
            bool revHorStatus = checkHorRow(revString(sString));
            bool verStatus = checkVerRow(sString);
            bool revVerStatus = checkVerRow(revString(sString));
            bool cross1Status = checkCross1(sString);
            bool revCross1Status = checkCross1(revString(sString));
            bool cross2Status = checkCross2(sString);
            bool revCross2Status = checkCross2(revString(sString));
            //

            if (horStatus || revHorStatus || verStatus || revVerStatus || cross1Status || revCross1Status || cross2Status || revCross2Status)
            {
               txtResult.Text ="Game Result"+Environment.NewLine + "Match Found: Yes";
                oStatus = true;
            }
            else
            {

               txtResult.Text ="Game Result"+ Environment.NewLine + "Match Found: No";
            }
            return oStatus;
        }

        string revString(string uString)
        {
            string revString = null;
            for (int i = grid.Count - 1; i >= 0; i--)
            {
                try
                {
                    revString += uString[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return revString;
        }

        bool checkHorRow(string uString)
        {
            bool status = false;
            string tempString = null;
            for (int i = 0; i < grid.Count; i++)
            {
                tempString = grid[i];
                if (tempString.Contains(uString))
                {
                    status = true;
                }
            }
            return status;
        }

        bool checkVerRow(string uString)
        {
            bool status = false;
            string tempString = null;
            for (int i=0; i<grid.Count;i++)
            {
                for (int j=0; j<grid.Count; j++)
                {
                    string tempString1 = grid[j];
                    tempString += tempString1[i];
                }
                if (tempString.Contains(uString))
                {
                    status = true;
                }
            }
            return status;
        }

        bool checkCross1(string uString)
        {
            bool status = false;
            string tempString = null;
            for (int i = 0; i < grid.Count; i++)
            {
                for (int j=0; j<grid.Count; j++)
                {
                    string tempString1 = grid[j];
                    try
                    {
                        tempString += tempString1[j-i];
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                for (int j = 0; j < grid.Count; j++)
                {
                    string tempString1 = grid[j];
                    try
                    {
                        tempString += tempString1[j + i];
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                if (tempString.Contains(uString))
                {
                    status = true;
                }
                
            }
            
            return status;
        }

        bool checkCross2(string uString)
        {
            bool status = false;
            
            string tempString = null;
            for (int i = 0; i < grid.Count; i++)
            {
                
                for (int j=0; j<grid.Count; j++)
                {
                    
                    try
                    {
                        string tempString1 = grid[i - j];
                        tempString += tempString1[j];
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                if (tempString.Contains(uString))
                {
                    status = true;
                }
            }
            return status;
        }
    }
}
