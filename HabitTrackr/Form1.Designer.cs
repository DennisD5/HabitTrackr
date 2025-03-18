namespace HabitTrackr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtHabitName = new TextBox();
            label2 = new Label();
            txtHabitDescription = new TextBox();
            btnAddHabit = new Button();
            lstHabits = new ListBox();
            btnMarkDone = new Button();
            btnDeleteHabit = new Button();
            btnEditHabit = new Button();
            progressBarHabit = new ProgressBar();
            lblProgress = new Label();
            numGoalStreak = new NumericUpDown();
            lblCountStreak = new Label();
            ((System.ComponentModel.ISupportInitialize)numGoalStreak).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Habit Name:";
            // 
            // txtHabitName
            // 
            txtHabitName.Location = new Point(102, 37);
            txtHabitName.Name = "txtHabitName";
            txtHabitName.Size = new Size(226, 23);
            txtHabitName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // txtHabitDescription
            // 
            txtHabitDescription.Location = new Point(102, 84);
            txtHabitDescription.Multiline = true;
            txtHabitDescription.Name = "txtHabitDescription";
            txtHabitDescription.Size = new Size(226, 23);
            txtHabitDescription.TabIndex = 3;
            // 
            // btnAddHabit
            // 
            btnAddHabit.Location = new Point(244, 113);
            btnAddHabit.Name = "btnAddHabit";
            btnAddHabit.Size = new Size(75, 23);
            btnAddHabit.TabIndex = 4;
            btnAddHabit.Text = "Add Habit";
            btnAddHabit.UseVisualStyleBackColor = true;
            btnAddHabit.Click += btnAddHabit_Click;
            // 
            // lstHabits
            // 
            lstHabits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstHabits.FormattingEnabled = true;
            lstHabits.Location = new Point(12, 267);
            lstHabits.Name = "lstHabits";
            lstHabits.Size = new Size(352, 604);
            lstHabits.TabIndex = 5;
            lstHabits.SelectedIndexChanged += lstHabits_SelectedIndexChanged;
            // 
            // btnMarkDone
            // 
            btnMarkDone.Location = new Point(12, 190);
            btnMarkDone.Name = "btnMarkDone";
            btnMarkDone.Size = new Size(105, 23);
            btnMarkDone.TabIndex = 6;
            btnMarkDone.Text = "Mark as Done";
            btnMarkDone.UseVisualStyleBackColor = true;
            btnMarkDone.Click += btnMarkDone_Click;
            // 
            // btnDeleteHabit
            // 
            btnDeleteHabit.Location = new Point(244, 190);
            btnDeleteHabit.Name = "btnDeleteHabit";
            btnDeleteHabit.Size = new Size(84, 23);
            btnDeleteHabit.TabIndex = 7;
            btnDeleteHabit.Text = "Delete Habit";
            btnDeleteHabit.UseVisualStyleBackColor = true;
            btnDeleteHabit.Click += btnDeleteHabit_Click;
            // 
            // btnEditHabit
            // 
            btnEditHabit.Location = new Point(244, 148);
            btnEditHabit.Name = "btnEditHabit";
            btnEditHabit.Size = new Size(75, 23);
            btnEditHabit.TabIndex = 8;
            btnEditHabit.Text = "Edit Habit";
            btnEditHabit.UseVisualStyleBackColor = true;
            btnEditHabit.Click += btnEditHabit_Click;
            // 
            // progressBarHabit
            // 
            progressBarHabit.Location = new Point(122, 238);
            progressBarHabit.Name = "progressBarHabit";
            progressBarHabit.Size = new Size(213, 23);
            progressBarHabit.TabIndex = 9;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(29, 246);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(87, 15);
            lblProgress.TabIndex = 10;
            lblProgress.Text = "Streak Progress";
            // 
            // numGoalStreak
            // 
            numGoalStreak.Location = new Point(102, 124);
            numGoalStreak.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numGoalStreak.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numGoalStreak.Name = "numGoalStreak";
            numGoalStreak.Size = new Size(120, 23);
            numGoalStreak.TabIndex = 11;
            numGoalStreak.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCountStreak
            // 
            lblCountStreak.AutoSize = true;
            lblCountStreak.Location = new Point(22, 131);
            lblCountStreak.Name = "lblCountStreak";
            lblCountStreak.Size = new Size(66, 15);
            lblCountStreak.TabIndex = 12;
            lblCountStreak.Text = "Goal Streak";
            // 
            // Form1
            // 
            AcceptButton = btnAddHabit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 882);
            Controls.Add(lblCountStreak);
            Controls.Add(numGoalStreak);
            Controls.Add(lblProgress);
            Controls.Add(progressBarHabit);
            Controls.Add(btnEditHabit);
            Controls.Add(btnDeleteHabit);
            Controls.Add(btnMarkDone);
            Controls.Add(lstHabits);
            Controls.Add(btnAddHabit);
            Controls.Add(txtHabitDescription);
            Controls.Add(label2);
            Controls.Add(txtHabitName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Habit Tracker";
            ((System.ComponentModel.ISupportInitialize)numGoalStreak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHabitName;
        private Label label2;
        private TextBox txtHabitDescription;
        private Button btnAddHabit;
        private ListBox lstHabits;
        private Button btnMarkDone;
        private Button btnDeleteHabit;
        private Button btnEditHabit;
        private ProgressBar progressBarHabit;
        private Label lblProgress;
        private NumericUpDown numGoalStreak;
        private Label lblCountStreak;
    }
}
