using Newtonsoft.Json;

namespace Anket_Task.Models;

static public class JsonHandling
{
    public static string path = "..\\..\\..\\JsonFiles\\";
    static public void WritePersonToJson(Person person)
    {
        string json = JsonConvert.SerializeObject(person, Formatting.Indented);
        File.WriteAllText(path + person.Name + ".json", json);
    }

    static public Person ReadPersonToJson(string name)
    {
        string json = File.ReadAllText(path + name + ".json");
        Person loadedPerson = JsonConvert.DeserializeObject<Person>(json);
        return loadedPerson;

    }

}
