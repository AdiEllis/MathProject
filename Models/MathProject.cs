namespace MathProject.Models
{
    public class MathProject
    {
        public string Topic { get; set; } 
        public string Students { get; set; } 
        public string PresentationLink { get; set; } 
        public string VideoLink { get; set; } 
        public string ExercisesLink { get; set; }
        public bool IsCompleted { get; set; }

        // status
        public bool HasPresentation { get; set; }
        public bool HasVideo { get; set; }
        public bool HasExercises { get; set; }

    }
}
