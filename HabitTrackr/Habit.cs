using System;

namespace HabitTracker
{
    public class Habit
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Streak { get; private set; }
        public DateTime? LastCompletedDate { get; private set; }

        public Habit(string name, string description = "")
        {
            Name = name;
            Description = description;
            Streak = 0;
            LastCompletedDate = null;
        }

        public void MarkAsDone()
        {
            if (LastCompletedDate == null || LastCompletedDate.Value.Date != DateTime.Today)
            {
                Streak++;
                LastCompletedDate = DateTime.Today;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Description} - Streak: {Streak} days";
        }
    }
}
