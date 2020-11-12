using System.ComponentModel;
using Hangfire.Tags.Attributes;

[Tag("base-class")]
public class BaseService 
{
    [Tag("base-method")]
    [DisplayName("base-method")]
    public virtual void Run()
    {
    }
}