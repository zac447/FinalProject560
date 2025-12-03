using ProjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface2
{
    public static class Validation
    {
        

        public static bool ValidateNulls(string value, string field)
        {
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show($"{field} cannot be left blank.");
                return false;
            }
            return true;
        }

        public static bool CheckCheckBoxes(bool box1, bool box2, string field)
        {
            if (box1 == false && box2 == false)
            {
                MessageBox.Show($"A {field} must be selected.");
                return false;
            }
            if (box1 == true && box2 == true)
            {
                MessageBox.Show($"Only one {field} can be selected.");
                return false;
            }
            return true;
        }
    }
}
