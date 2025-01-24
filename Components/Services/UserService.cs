using System.Text.Json;
using ExpenseTracker.Components.model;

namespace ExpenseTracker.Services
{
    public class UserService
    {
        private static readonly string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LocalDB");
        private static readonly string FilePath = Path.Combine(FolderPath, "appdata.json");

        private User? _loggedInUser;

        public AppData LoadData()
        {
            if (!File.Exists(FilePath))
                return new AppData();

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<AppData>(json) ?? new AppData();
        }

        public void SaveData(AppData data)
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public bool RegisterUser(User user, string password)
        {
            var data = LoadData();

            if (data.Users.Any(u => u.Email == user.Email))
                return false;

            user.Password = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
            user.Id = data.Users.Any() ? data.Users.Max(u => u.Id) + 1 : 1;
            data.Users.Add(user);

            SaveData(data);
            return true;
        }

        public User? Login(string email, string password)
        {
            var data = LoadData();
            string hashedPassword = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
            _loggedInUser = data.Users.FirstOrDefault(u => u.Email == email && u.Password == hashedPassword);
            return _loggedInUser;
        }

        public User? GetLoggedInUser()
        {
            return _loggedInUser;
        }

        public void Logout()
        {
            _loggedInUser = null;
        }
    }
}
