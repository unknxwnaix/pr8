using Newtonsoft.Json;

namespace SerealizationAndDeserealizationLib1
{
    public class SerealizationAndDeserealizationLib
    {
        static string path = "C:\\Users\\aiX\\Desktop\\Colour.json";
        public static void Serialize<T>(T list)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(path, json);
        }
        public static T Deserialize<T>()
        {
            string json = File.ReadAllText(path); ;
            T list = JsonConvert.DeserializeObject<T>(json);
            return list;
        }
    }
}