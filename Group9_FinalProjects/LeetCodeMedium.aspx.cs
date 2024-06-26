﻿/*
# Name: Duyen Huynh
# email: huynhd2@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 04/23/2024
# Course: IS 3050
# Semester/Year:Spring 2024
# Brief Description: This is the final project
# Citations:https://chat.openai.com/,https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
# Anything else that's relevant:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group9_FinalProjects
{
    public partial class LeetCodeMedium : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void GetCombinations_Click(object sender, EventArgs e)
        {
            var generator = new LetterCombinations();

            // Get the digits from the TextBox
            string digits = txtDigits.Text.Trim();

            // Validate the input to ensure it contains only valid characters (digits 2-9)
            if (!System.Text.RegularExpressions.Regex.IsMatch(digits, "^[2-9]*$"))
            {
                lblSolutions.Text = "Please enter digits between 2 and 9.";
                return;
            }

            // Call the method to get combinations
            IList<string> combinations = generator.letterCombinations(digits);

            // Format and display the results
            if (combinations.Count > 0)
            {
                lblSolutions.Text = String.Join(", ", combinations);
            }
            else
            {
                lblSolutions.Text = "No combinations available.";
            }
        }
    }
}