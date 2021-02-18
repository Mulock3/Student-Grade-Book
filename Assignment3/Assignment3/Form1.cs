using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Scores : Form
    {
        /// <summary>
        /// Total Count of Students
        /// </summary>
        private int studentCount;
        /// <summary>
        /// Total Count of Assignments
        /// </summary>
        private int assignmentCount;
        /// <summary>
        /// Current Selected Student
        /// </summary>
        private int selectedStudent;
        /// <summary>
        /// List of all students
        /// </summary>
        private string[] studentList;
        /// <summary>
        /// List of all the grades for each student
        /// </summary>
        // A little complicated so let's break it down (I'd usually just make a student object that contains the lists
        // but it didn't feel to meet the guidelines of the assignment
        //
        // We have an array of ints representing students, which then contains an array of scores based upon their 
        // assignments. Therefore we can pull by their index really easily the score for an assignment. This is best
        // illustrated in the init. of the form
        private int[,] gradeList;

        /// <summary>
        /// Initializes the Scores page
        /// Sets up basic variables and loads UI
        /// </summary>
        public Scores()
        {
            InitializeComponent();

            // Sets up the initial values
            studentCount = 0;
            assignmentCount = 0;
            selectedStudent = 0;
            studentList = new string[studentCount];
            gradeList = new int[studentCount, assignmentCount];
            scoresListView.Scrollable = true;
        }

        // Sets up how many students, displays the scores, and can reset everything
        #region Admin/Setup
        /// <summary>
        /// Sets the amount of students and assignments
        /// 
        /// Students Max = 10
        /// Assignmenets Max = 99
        /// 
        /// Warning, will Reset Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countSubmit_Click(object sender, EventArgs e)
        {
            // Asks first if you have data if you really want to reset your data
            bool createNewEntries = true;

            if (studentCount > 0 && assignmentCount > 0)
            {
                createNewEntries = false;
                // Do you want to reset data?
                DialogResult result = MessageBox.Show("This will reset data, do you want to proceed?", "Confirm", MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    createNewEntries = true;
                }
            }
            
            if (createNewEntries == true)
            {
                try
                {
                    if (Convert.ToInt32(numStudents.Text) <= 10 && Convert.ToInt32(numStudents.Text) > 0)
                    {
                        studentCount = Convert.ToInt32(numStudents.Text);
                    }
                    else
                    {
                        MessageBox.Show("You can have between 1-10 Students", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Convert.ToInt32(numAssignments.Text) <= 99 && Convert.ToInt32(numAssignments.Text) > 0)
                    {
                        assignmentCount = Convert.ToInt32(numAssignments.Text);
                    }
                    else
                    {
                        MessageBox.Show("You can have between 1-99 Assignments", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    selectedStudent = 0;
                    studentList = new string[studentCount];
                    gradeList = new int[studentCount, assignmentCount];

                    // Prepopulate the student list
                    for (int x = 0; x < studentCount; x++)
                    {
                        studentList[x] = "Student #" + (x + 1);
                        // Prepopulate the grade list
                        for (int y = 0; y < assignmentCount; y++)
                        {
                            gradeList[x, y] = 0;
                        }
                    }


                }
                catch
                {
                    MessageBox.Show("Please enter valid numbers for Student and Assignment Counts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    updateUI();
                }
            }
        }

        /// <summary>
        /// Displays the students, their grades, their average grade, and their letter grade
        /// 
        /// Pulls info from the Syllabus 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayScores_Click(object sender, EventArgs e)
        {
            if (studentCount > 0 && assignmentCount > 0)
            {
                List<int> avgScoreList = new List<int>();
                int avgIndvidualScore = 0;
                // First sets up columns 
                scoresListView.Columns.Clear();
                scoresListView.Columns.Add("Students", 100);
                for (int x = 0; x < assignmentCount; x++)
                {
                    scoresListView.Columns.Add("#" + (x + 1), 40);
                }
                scoresListView.Columns.Add("AVG");
                scoresListView.Columns.Add("Grade");

                scoresListView.Items.Clear();
                foreach (string y in studentList)
                {
                    scoresListView.Items.Add(y);
                }

                for (int x = 0; x < studentCount; x++)
                {
                    for (int y = 0; y < assignmentCount; y++)
                    {
                        scoresListView.Items[x].SubItems.Add(gradeList[x, y].ToString());
                        avgScoreList.Add(y);
                        avgIndvidualScore += gradeList[x, y];
                    }
                    avgIndvidualScore = avgIndvidualScore / avgScoreList.Count();
                    scoresListView.Items[x].SubItems.Add(avgIndvidualScore.ToString());

                    // Letter Grade
                    if (avgIndvidualScore >= 93)
                    {
                        scoresListView.Items[x].SubItems.Add("A");
                    }
                    else if (avgIndvidualScore >= 90)
                    {
                        scoresListView.Items[x].SubItems.Add("A-");
                    }
                    else if (avgIndvidualScore >= 87)
                    {
                        scoresListView.Items[x].SubItems.Add("B+");
                    }
                    else if (avgIndvidualScore >= 83)
                    {
                        scoresListView.Items[x].SubItems.Add("B");
                    }
                    else if (avgIndvidualScore >= 80)
                    {
                        scoresListView.Items[x].SubItems.Add("B-");
                    }
                    else if (avgIndvidualScore >= 77)
                    {
                        scoresListView.Items[x].SubItems.Add("C+");
                    }
                    else if (avgIndvidualScore >= 73)
                    {
                        scoresListView.Items[x].SubItems.Add("C");
                    }
                    else if (avgIndvidualScore >= 70)
                    {
                        scoresListView.Items[x].SubItems.Add("C-");
                    }
                    else if (avgIndvidualScore >= 68)
                    {
                        scoresListView.Items[x].SubItems.Add("D+");
                    }
                    else if (avgIndvidualScore >= 63)
                    {
                        scoresListView.Items[x].SubItems.Add("D");
                    }
                    else if (avgIndvidualScore >= 60)
                    {
                        scoresListView.Items[x].SubItems.Add("D-");
                    }
                    else
                    {
                        scoresListView.Items[x].SubItems.Add("E");
                    }
                    avgIndvidualScore = 0;
                    avgScoreList.Clear();
                }
            }
        }

        /// <summary>
        /// Resets everything from scratch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scoreReset_Click(object sender, EventArgs e)
        {
            // Do you want to reset data?
            DialogResult result = MessageBox.Show("This will reset data, do you want to proceed?", "Confirm", MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
            {
                studentCount = 0;
                assignmentCount = 0;
                selectedStudent = 0;
                studentList = new string[studentCount];
                gradeList = new int[studentCount, assignmentCount];

                updateUI();
            }

        }
        #endregion

        // Handles Navigation between the different students
        #region Navigation
        /// <summary>
        /// Goes to the first student in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstStudent_Click(object sender, EventArgs e)
        {
            selectedStudent = 0;

            updateUI();
        }

        /// <summary>
        /// Goes back a student (if possible)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudent > 0)
            {
                selectedStudent--;
            }

            updateUI();
        }

        /// <summary>
        /// Goes to the next student (if possible)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nxtStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudent < studentCount - 1)
            {
                selectedStudent++;
            }

            updateUI();
        }

        /// <summary>
        /// Goes to the last student in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastStudent_Click(object sender, EventArgs e)
        {
            if (studentCount > 0)
            {
                selectedStudent = studentCount - 1;
            }
            else
            {
                selectedStudent = 0;
            }

            updateUI();
        }
        #endregion

        // Handles student info such as Student Name, and Grades per Assignment
        #region Student Info (Grades/Name)
        /// <summary>
        /// Saves a new students name into the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentName.Text.Trim() != "")
                {
                    studentList[selectedStudent] = studentName.Text;
                    MessageBox.Show("Student Name Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateUI();
                    return;
                }
                MessageBox.Show("Please Enter Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Please provide student and assignment count first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Saves the new score for the student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveNewScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (assignmentScore.Text.Trim() != "" && assigmentNum.Text.Trim() != "")
                {
                    if (Convert.ToInt32(assignmentScore.Text) >= 0 && Convert.ToInt32(assignmentScore.Text) <= 100)
                    {
                        gradeList[selectedStudent, Convert.ToInt32(assigmentNum.Text) - 1] = Convert.ToInt32(assignmentScore.Text);
                        MessageBox.Show("Assignment " + assigmentNum.Text + " Score Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a score from 0-100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Please Enter Assignment Score and Assignment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Please make sure a student is selected and you entered numbers for the Assignment number and score", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            updateUI();
        }
        #endregion

        /// <summary>
        /// Updates the UI based on the new data
        /// </summary>
        private void updateUI()
        {
            if (studentCount > 0 && assignmentCount > 0)
            {
                studentNameLbl.Text = studentList[selectedStudent];
                assignmentLbl.Text = "Enter Assignment (1-" + assignmentCount + "):";

                this.Refresh();
            }
            else
            {
                studentNameLbl.Text = "{Student Name}";
                assignmentLbl.Text = "Enter Assignment:";

                scoresListView.Clear();

                this.Refresh();
            }
        }

    }
}
