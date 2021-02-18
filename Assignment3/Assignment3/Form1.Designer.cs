
namespace Assignment3
{
    partial class Scores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.countsBox = new System.Windows.Forms.GroupBox();
            this.numAssignments = new System.Windows.Forms.TextBox();
            this.numStudents = new System.Windows.Forms.TextBox();
            this.countSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfStudentsLabel = new System.Windows.Forms.Label();
            this.scoreReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastStudent = new System.Windows.Forms.Button();
            this.nxtStudent = new System.Windows.Forms.Button();
            this.prevStudent = new System.Windows.Forms.Button();
            this.firstStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentNameLbl = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.saveStudent = new System.Windows.Forms.Button();
            this.StudentInfo2 = new System.Windows.Forms.GroupBox();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.assignmentScore = new System.Windows.Forms.TextBox();
            this.assignmentLbl = new System.Windows.Forms.Label();
            this.assigmentNum = new System.Windows.Forms.TextBox();
            this.saveNewScore = new System.Windows.Forms.Button();
            this.displayScores = new System.Windows.Forms.Button();
            this.scoresListView = new System.Windows.Forms.ListView();
            this.countsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.StudentInfo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // countsBox
            // 
            this.countsBox.Controls.Add(this.numAssignments);
            this.countsBox.Controls.Add(this.numStudents);
            this.countsBox.Controls.Add(this.countSubmit);
            this.countsBox.Controls.Add(this.label1);
            this.countsBox.Controls.Add(this.numberOfStudentsLabel);
            this.countsBox.Location = new System.Drawing.Point(13, 13);
            this.countsBox.Name = "countsBox";
            this.countsBox.Size = new System.Drawing.Size(362, 69);
            this.countsBox.TabIndex = 0;
            this.countsBox.TabStop = false;
            this.countsBox.Text = "Counts";
            // 
            // numAssignments
            // 
            this.numAssignments.Location = new System.Drawing.Point(156, 41);
            this.numAssignments.Name = "numAssignments";
            this.numAssignments.Size = new System.Drawing.Size(100, 20);
            this.numAssignments.TabIndex = 4;
            // 
            // numStudents
            // 
            this.numStudents.Location = new System.Drawing.Point(156, 13);
            this.numStudents.Name = "numStudents";
            this.numStudents.Size = new System.Drawing.Size(100, 20);
            this.numStudents.TabIndex = 3;
            // 
            // countSubmit
            // 
            this.countSubmit.Location = new System.Drawing.Point(263, 27);
            this.countSubmit.Name = "countSubmit";
            this.countSubmit.Size = new System.Drawing.Size(93, 20);
            this.countSubmit.TabIndex = 2;
            this.countSubmit.Text = "Submit Counts";
            this.countSubmit.UseVisualStyleBackColor = true;
            this.countSubmit.Click += new System.EventHandler(this.countSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Assignments:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numberOfStudentsLabel
            // 
            this.numberOfStudentsLabel.AutoSize = true;
            this.numberOfStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfStudentsLabel.Location = new System.Drawing.Point(27, 16);
            this.numberOfStudentsLabel.Name = "numberOfStudentsLabel";
            this.numberOfStudentsLabel.Size = new System.Drawing.Size(123, 13);
            this.numberOfStudentsLabel.TabIndex = 0;
            this.numberOfStudentsLabel.Text = "Number of Students:";
            this.numberOfStudentsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // scoreReset
            // 
            this.scoreReset.Location = new System.Drawing.Point(467, 40);
            this.scoreReset.Name = "scoreReset";
            this.scoreReset.Size = new System.Drawing.Size(93, 20);
            this.scoreReset.TabIndex = 5;
            this.scoreReset.Text = "Reset Scores";
            this.scoreReset.UseVisualStyleBackColor = true;
            this.scoreReset.Click += new System.EventHandler(this.scoreReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastStudent);
            this.groupBox1.Controls.Add(this.nxtStudent);
            this.groupBox1.Controls.Add(this.prevStudent);
            this.groupBox1.Controls.Add(this.firstStudent);
            this.groupBox1.Location = new System.Drawing.Point(13, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigate";
            // 
            // lastStudent
            // 
            this.lastStudent.Location = new System.Drawing.Point(307, 19);
            this.lastStudent.Name = "lastStudent";
            this.lastStudent.Size = new System.Drawing.Size(93, 20);
            this.lastStudent.TabIndex = 5;
            this.lastStudent.Text = "Last Student >>";
            this.lastStudent.UseVisualStyleBackColor = true;
            this.lastStudent.Click += new System.EventHandler(this.lastStudent_Click);
            // 
            // nxtStudent
            // 
            this.nxtStudent.Location = new System.Drawing.Point(208, 19);
            this.nxtStudent.Name = "nxtStudent";
            this.nxtStudent.Size = new System.Drawing.Size(93, 20);
            this.nxtStudent.TabIndex = 4;
            this.nxtStudent.Text = "Next Student >";
            this.nxtStudent.UseVisualStyleBackColor = true;
            this.nxtStudent.Click += new System.EventHandler(this.nxtStudent_Click);
            // 
            // prevStudent
            // 
            this.prevStudent.Location = new System.Drawing.Point(109, 19);
            this.prevStudent.Name = "prevStudent";
            this.prevStudent.Size = new System.Drawing.Size(93, 20);
            this.prevStudent.TabIndex = 3;
            this.prevStudent.Text = "< Prev Student";
            this.prevStudent.UseVisualStyleBackColor = true;
            this.prevStudent.Click += new System.EventHandler(this.prevStudent_Click);
            // 
            // firstStudent
            // 
            this.firstStudent.Location = new System.Drawing.Point(10, 19);
            this.firstStudent.Name = "firstStudent";
            this.firstStudent.Size = new System.Drawing.Size(93, 20);
            this.firstStudent.TabIndex = 2;
            this.firstStudent.Text = "<< First Student";
            this.firstStudent.UseVisualStyleBackColor = true;
            this.firstStudent.Click += new System.EventHandler(this.firstStudent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentNameLbl);
            this.groupBox2.Controls.Add(this.studentName);
            this.groupBox2.Controls.Add(this.saveStudent);
            this.groupBox2.Location = new System.Drawing.Point(13, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 49);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info";
            // 
            // studentNameLbl
            // 
            this.studentNameLbl.AutoSize = true;
            this.studentNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLbl.Location = new System.Drawing.Point(7, 22);
            this.studentNameLbl.Name = "studentNameLbl";
            this.studentNameLbl.Size = new System.Drawing.Size(97, 13);
            this.studentNameLbl.TabIndex = 5;
            this.studentNameLbl.Text = "{Student Name}";
            this.studentNameLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(141, 19);
            this.studentName.MaxLength = 25;
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(160, 20);
            this.studentName.TabIndex = 5;
            // 
            // saveStudent
            // 
            this.saveStudent.Location = new System.Drawing.Point(307, 19);
            this.saveStudent.Name = "saveStudent";
            this.saveStudent.Size = new System.Drawing.Size(93, 20);
            this.saveStudent.TabIndex = 5;
            this.saveStudent.Text = "Save Name";
            this.saveStudent.UseVisualStyleBackColor = true;
            this.saveStudent.Click += new System.EventHandler(this.saveStudent_Click);
            // 
            // StudentInfo2
            // 
            this.StudentInfo2.Controls.Add(this.scoreLbl);
            this.StudentInfo2.Controls.Add(this.assignmentScore);
            this.StudentInfo2.Controls.Add(this.assignmentLbl);
            this.StudentInfo2.Controls.Add(this.assigmentNum);
            this.StudentInfo2.Controls.Add(this.saveNewScore);
            this.StudentInfo2.Location = new System.Drawing.Point(13, 198);
            this.StudentInfo2.Name = "StudentInfo2";
            this.StudentInfo2.Size = new System.Drawing.Size(411, 67);
            this.StudentInfo2.TabIndex = 7;
            this.StudentInfo2.TabStop = false;
            this.StudentInfo2.Text = "Student Info";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(34, 45);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(112, 13);
            this.scoreLbl.TabIndex = 6;
            this.scoreLbl.Text = "Assignment Score:";
            this.scoreLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // assignmentScore
            // 
            this.assignmentScore.Location = new System.Drawing.Point(164, 42);
            this.assignmentScore.Name = "assignmentScore";
            this.assignmentScore.Size = new System.Drawing.Size(38, 20);
            this.assignmentScore.TabIndex = 7;
            // 
            // assignmentLbl
            // 
            this.assignmentLbl.AutoSize = true;
            this.assignmentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentLbl.Location = new System.Drawing.Point(7, 22);
            this.assignmentLbl.Name = "assignmentLbl";
            this.assignmentLbl.Size = new System.Drawing.Size(109, 13);
            this.assignmentLbl.TabIndex = 5;
            this.assignmentLbl.Text = "Enter Assignment:";
            this.assignmentLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // assigmentNum
            // 
            this.assigmentNum.Location = new System.Drawing.Point(164, 19);
            this.assigmentNum.Name = "assigmentNum";
            this.assigmentNum.Size = new System.Drawing.Size(38, 20);
            this.assigmentNum.TabIndex = 5;
            // 
            // saveNewScore
            // 
            this.saveNewScore.Location = new System.Drawing.Point(208, 22);
            this.saveNewScore.Name = "saveNewScore";
            this.saveNewScore.Size = new System.Drawing.Size(93, 36);
            this.saveNewScore.TabIndex = 5;
            this.saveNewScore.Text = "Save Score";
            this.saveNewScore.UseVisualStyleBackColor = true;
            this.saveNewScore.Click += new System.EventHandler(this.saveNewScore_Click);
            // 
            // displayScores
            // 
            this.displayScores.Location = new System.Drawing.Point(276, 285);
            this.displayScores.Name = "displayScores";
            this.displayScores.Size = new System.Drawing.Size(93, 20);
            this.displayScores.TabIndex = 8;
            this.displayScores.Text = "Display Scores";
            this.displayScores.UseVisualStyleBackColor = true;
            this.displayScores.Click += new System.EventHandler(this.displayScores_Click);
            // 
            // scoresListView
            // 
            this.scoresListView.HideSelection = false;
            this.scoresListView.Location = new System.Drawing.Point(13, 311);
            this.scoresListView.Name = "scoresListView";
            this.scoresListView.Size = new System.Drawing.Size(609, 288);
            this.scoresListView.TabIndex = 9;
            this.scoresListView.UseCompatibleStateImageBehavior = false;
            this.scoresListView.View = System.Windows.Forms.View.Details;
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.scoresListView);
            this.Controls.Add(this.displayScores);
            this.Controls.Add(this.StudentInfo2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scoreReset);
            this.Controls.Add(this.countsBox);
            this.MaximumSize = new System.Drawing.Size(650, 650);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "Scores";
            this.Text = "Scores";
            this.countsBox.ResumeLayout(false);
            this.countsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.StudentInfo2.ResumeLayout(false);
            this.StudentInfo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox countsBox;
        private System.Windows.Forms.TextBox numAssignments;
        private System.Windows.Forms.TextBox numStudents;
        private System.Windows.Forms.Button countSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfStudentsLabel;
        private System.Windows.Forms.Button scoreReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lastStudent;
        private System.Windows.Forms.Button nxtStudent;
        private System.Windows.Forms.Button prevStudent;
        private System.Windows.Forms.Button firstStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label studentNameLbl;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Button saveStudent;
        private System.Windows.Forms.GroupBox StudentInfo2;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.TextBox assignmentScore;
        private System.Windows.Forms.Label assignmentLbl;
        private System.Windows.Forms.TextBox assigmentNum;
        private System.Windows.Forms.Button saveNewScore;
        private System.Windows.Forms.Button displayScores;
        private System.Windows.Forms.ListView scoresListView;
    }
}

