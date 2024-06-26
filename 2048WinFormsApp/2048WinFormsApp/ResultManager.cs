using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    public class ResultManager
    {
        public static List<Result> GetAll(string fileName)
        {
            var results = JsonConvert.DeserializeObject<List<Result>>(DataProvider.ReadAll(fileName));
            if (results == null || results.Count == 0)
            {
                results = new List<Result>();
                results.Add(new Result());
            }
            return results;
        }
        public static void Save(Result result, string fileName)
        {
            var results = JsonConvert.DeserializeObject<List<Result>>(DataProvider.ReadAll(fileName));
            if (results == null)
            {
                results = new List<Result>();
            }
            results.Add(result);
            var sortedResults = results.OrderByDescending(p => p.Score).ThenBy(p => p.Name);
            DataProvider.Write(fileName, JsonConvert.SerializeObject(sortedResults), false);
        }
    }
}
