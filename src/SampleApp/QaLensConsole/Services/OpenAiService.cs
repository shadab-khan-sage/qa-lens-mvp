using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace QaLensConsole.Services;

public class OpenAiService
{
    private readonly string _endpoint = "http://localhost:11434/api/generate";

    public async Task<string> GenerateTestSuggestions(string diff)
    {
        using var client = new HttpClient
        {
            Timeout = TimeSpan.FromMinutes(30) // or even more if needed
        };

        var request = new
        {
            model = "openchat", // or "mistral", "llama2", etc.
            prompt = $"Here is a code diff:\n\n{diff}\n\nSuggest test cases and edge cases in Markdown.",
            stream = false
        };

        var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
        var response = await client.PostAsync(_endpoint, content);

        if (!response.IsSuccessStatusCode)
        {
            var err = await response.Content.ReadAsStringAsync();
            throw new Exception("❌ Ollama API call failed: " + err);
        }

        var responseJson = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(responseJson);
        return doc.RootElement.GetProperty("response").GetString() ?? "⚠️ No content returned.";
    }
}
