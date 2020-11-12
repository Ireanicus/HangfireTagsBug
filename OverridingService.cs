using System.ComponentModel;
using Hangfire.Tags.Attributes;

[Tag("overriding-class")]
public class OverridingService : BaseService 
{
    [Tag("overriding-method")]
    [DisplayName("overriding-method")]
    public override void Run() 
    {
        base.Run();
    }
}