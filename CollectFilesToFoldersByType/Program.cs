var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

foreach (var file in Directory.EnumerateFiles(path))
{
    var extension = Path.GetExtension(file).Replace(".", "");
    var extensionFolder = Path.Combine(path, extension);

    if (!Directory.Exists(extensionFolder))
    {
        Directory.CreateDirectory(extensionFolder);
    }

    var filename = Path.GetFileName(file);
    var newPath = Path.Combine(path, extension, filename);
    File.Move(file,newPath, false);
}