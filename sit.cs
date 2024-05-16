// Check if the directory path is null or empty
if (string.IsNullOrEmpty(dirPath))
{
    throw new ArgumentException("Directory path cannot be null or empty.", nameof(dirPath));
}

// Check if the directory exists
if (!Directory.Exists(dirPath))
{
    throw new DirectoryNotFoundException($"Directory {dirPath} not found");
}
