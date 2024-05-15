public static string GetFileNameFromPath(string folderPath)
{
    // Check if the folderPath is null or empty
    if (string.IsNullOrEmpty(folderPath))
    {
        throw new ArgumentNullException(nameof(folderPath), "The folder path cannot be null or empty.");
    }

    // Check if the folderPath is a valid file path
    if (!Path.IsPathRooted(folderPath))
    {
        throw new ArgumentException("The folder path must be a fully qualified path.", nameof(folderPath));
    }

    // Return the file name part of the folder path
    return Path.GetFileName(folderPath);
}
