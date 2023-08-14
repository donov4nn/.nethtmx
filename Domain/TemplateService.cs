using JinianNet.JNTemplate;
using WebApp.Domain.Interfaces;
namespace WebApp.Domain;

public class TemplateService : ITemplateService
{
    public string RenderComponent(string componentName, Dictionary<string, string> keyValues)
    {
        var template = Engine.LoadTemplate(PathHelper.GetComponentPath("name"));
        
        foreach (var keyValuePair in keyValues)
            template.Set(keyValuePair.Key, keyValuePair.Value);
        
        return template.Render();
    }
    
    public string RenderComponent(string componentName, KeyValuePair<string, string> keyValue)
    {
        var template = Engine.LoadTemplate(PathHelper.GetComponentPath("name"));
        template.Set(keyValue.Key, keyValue.Value);
        return template.Render();
    }
}