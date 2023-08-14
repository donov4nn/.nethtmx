namespace WebApp.Domain;

public static class PathHelper
{
    public static string GetComponentPath(string componentName) =>
        Path.Combine(Directory.GetCurrentDirectory(), $@"Components/{componentName}.html");
}