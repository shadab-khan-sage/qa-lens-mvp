using QaLensConsole.Services;
using Microsoft.Extensions.Configuration;

namespace QaLensConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("🚀 QA Lens: Starting Test Case Suggestion Process...");

            // Load config from appsettings.json
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            // Read the diff file
            var diffPath = Path.Combine(AppContext.BaseDirectory, "Inputs", "pr_diff.txt");

            if (!File.Exists(diffPath))
            {
                Console.WriteLine("❌ pr_diff.txt not found in Inputs folder.");
                return;
            }

            var diffContent = await File.ReadAllTextAsync(diffPath);

            // Extract impacted files from diff
            var diffLines = diffContent.Split('\n');
            var impactedFiles = diffLines
                .Where(line => line.StartsWith("Diff for "))
                .Select(line => line.Replace("Diff for ", "").Trim())
                .ToList();

            var impactedSection = "## Impacted Areas\n";
            if (impactedFiles.Any())
            {
                impactedSection += string.Join("\n", impactedFiles.Select(f => $"- {f}"));
            }
            else
            {
                impactedSection += "No files detected as changed.";
            }
            impactedSection += "\n\n";

            // Initialize OpenAI service
            var service = new OpenAiService();
            var output = await service.GenerateTestSuggestions(diffContent);

            // Prepend impacted section to the report
            var finalReport = impactedSection + output;
            var outputPath = "qa-report.md";
            await File.WriteAllTextAsync(outputPath, finalReport);

            Console.WriteLine($"✅ QA summary saved to: {outputPath}");
        }
    }
}
