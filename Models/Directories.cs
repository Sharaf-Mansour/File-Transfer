namespace File_Transfer.Models
{
    public class Directories
    {
        private static string _path { get; } = "wwwroot/SharedFiles";
        public List<string?> _directories { get; init; } = new();

        public Directories() =>
            _directories = Directory.GetDirectories(_path)
            .Select(Path.GetFileName).AsList();

        public List<string?> GetDirectories() => _directories;

        public List<string?> GetFiles(string _dir) =>
         Directory.GetFiles(Path.Combine(_path, _dir))
            .Select(Path.GetFileName).AsList();
    }
}
