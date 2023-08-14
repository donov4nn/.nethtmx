namespace WebApp.Domain.Interfaces;

public interface ITemplateService
{
    string RenderComponent(string componentName, Dictionary<string, string> keyValues);
    string RenderComponent(string componentName, KeyValuePair<string, string> keyValue);
}