using Newtonsoft.Json;

namespace OlxCarFilter.Utils;

public static class FileReader<T>
{
	public static T GetSpecifications(string jsonFilePath)
	{
		StreamReader reader = new(jsonFilePath);
		string json = reader.ReadToEnd();
		return JsonConvert.DeserializeObject<T>(json) ?? throw new InvalidOperationException();
	}
}
