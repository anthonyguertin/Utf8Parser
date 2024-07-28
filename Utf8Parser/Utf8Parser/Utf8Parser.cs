namespace Utf8Parser
{
    public class UtfParser(string filePath)
    {
        private string FilePath { get; set; } = string.IsNullOrEmpty(filePath) ? string.Empty :filePath;
        public Dictionary<string, string> GetKeyValuePair()
        {
            string[] lines = File.ReadAllLines(FilePath);
            var result = new Dictionary<string, string>();
            var current = string.Empty;

            foreach (var line in lines)
            {
                if (line == "" || line == " ") { continue; }

                var indexEndOfKey = line.IndexOf('=');
                var key = string.Empty;
                var value = string.Empty;

                if (!line.Contains('='))
                {
                    result[current] += line;
                    continue;
                }

                if (indexEndOfKey >= 0 && indexEndOfKey <= line.Length)
                {
                    key = line[..indexEndOfKey];
                    current = key;
                }

                value = line.Substring(indexEndOfKey + 1);
                result.Add(key, value);
                current = key;
            }
            return result;
        }
    }
}