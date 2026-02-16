using Firebase.Database;
using Firebase.Database.Query;
using MathProject.Models;
public class FirebaseService
{
    private readonly FirebaseClient _client;

    public FirebaseService()
    {
        // החליפי את הלינק למטה בלינק של ה-Database שלך מה-Firebase Console
        _client = new FirebaseClient("https://mathproject-y1-default-rtdb.europe-west1.firebasedatabase.app/");
    }

    // קבלת כל הפרויקטים
    public async Task<List<ProjectModel>> GetProjectsAsync()
    {
        var projects = await _client
            .Child("projects")
            .OnceAsync<ProjectModel>();

        return projects.Select(item => {
            item.Object.Id = item.Key; // שומרים את המפתח של פיירבייס בתוך המודל
            return item.Object;
        }).ToList();
    }

    // עדכון פרויקט קיים (למשל כשמוסיפים לינק)
    public async Task UpdateProjectAsync(ProjectModel project)
    {
        await _client
            .Child("projects")
            .Child(project.Id)
            .PutAsync(project);
    }
}