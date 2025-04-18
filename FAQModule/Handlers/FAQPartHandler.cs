using OrchardCore.ContentManagement.Handlers;
using System.Threading.Tasks;
using FAQModule.Models;

namespace FAQModule.Handlers
{
    public class FAQPartHandler : ContentPartHandler<FAQPart>
    {
        public override Task InitializingAsync(InitializingContentContext context, FAQPart part)
        {
            context.ContentItem.DisplayText = part.Question;
            return Task.CompletedTask;
        }
    }
}