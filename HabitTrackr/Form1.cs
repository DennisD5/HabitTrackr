using HabitTracker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace HabitTrackr
{
    public partial class Form1 : Form
    {
        private List<Habit> habits = new List<Habit>();
        private int editingIndex = -1;


        public Form1()
        {
            InitializeComponent();
            UpdateHabitList();
        }

        private void btnAddHabit_Click(object sender, EventArgs e)
        {
            string name = txtHabitName.Text.Trim();
            string description = txtHabitDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Habit name cannot be empty.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (editingIndex != -1)
            {
                habits[editingIndex].Name = name;
                habits[editingIndex].Description = description;

               
                editingIndex = -1;
                btnAddHabit.Text = "Add Habit";  
            }
            else
            {
               
                habits.Add(new Habit(name, description));
            }

            UpdateHabitList();
            txtHabitName.Clear();
            txtHabitDescription.Clear();
        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            if (lstHabits.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a habit to mark as done.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            habits[lstHabits.SelectedIndex].MarkAsDone();
            UpdateHabitList();
        }

        private void UpdateHabitList()
        {
            lstHabits.Items.Clear();
            foreach (var habit in habits)
            {
                lstHabits.Items.Add(habit.ToString());
            }
        }

        private void btnDeleteHabit_Click(object sender, EventArgs e)
        {
            if (lstHabits.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a habit to delete.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this habit?",
                "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                habits.RemoveAt(lstHabits.SelectedIndex);
                UpdateHabitList();
            }
        }

        private void btnEditHabit_Click(object sender, EventArgs e)
        {
            if (lstHabits.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a habit to edit.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            editingIndex = lstHabits.SelectedIndex;
            Habit selectedHabit = habits[editingIndex];
            txtHabitName.Text = selectedHabit.Name;
            txtHabitDescription.Text = selectedHabit.Description;

            btnAddHabit.Text = "Update Habit";
        }
    }
}
