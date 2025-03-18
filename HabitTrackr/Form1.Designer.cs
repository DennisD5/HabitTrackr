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
            lstHabits.Location = new Point(12, 237);
            lstHabits.Name = "lstHabits";
            lstHabits.Size = new Size(352, 634);
            lstHabits.TabIndex = 5;
            // 
            // btnMarkDone
            // 
            btnMarkDone.Location = new Point(39, 148);
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
            // Form1
            // 
            AcceptButton = btnAddHabit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 882);
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
    }
}
