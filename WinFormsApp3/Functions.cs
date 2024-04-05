using System.Text.Json;
using System.Xml.Linq;

namespace WinFormsApp3;

public static class Functions
{
    public static void WriteUserToJson(User u)
    {
        JsonSerializerOptions op = new()
        {
            WriteIndented = true
        };
        string json = JsonSerializer.Serialize(u, op);
        File.WriteAllText(u.Name, json);
    }
    public static User ReadUserToJson(string name)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonstring = "";
        jsonstring = File.ReadAllText(name);
        return JsonSerializer.Deserialize<User>(jsonstring, options);
    }
}
