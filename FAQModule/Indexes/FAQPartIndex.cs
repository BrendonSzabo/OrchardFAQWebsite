using FAQModule.Models;
using OrchardCore.ContentManagement;
using YesSql.Indexes;

namespace FAQModule.Indexes
{
    class FAQPartIndex : MapIndex
    {
        public string ContentItemId { get; set; }
        public string Question { get; set; }
    }

    public class FAQPartIndexProvider : IndexProvider<ContentItem>
    {
        public override void Describe(DescribeContext<ContentItem> context) =>
            context.For<FAQPartIndex>().Map(contentItem =>
            {
                var personPart = contentItem.As<FAQPart>();

                return personPart == null
                    ? null
                    : new FAQPartIndex
                    {
                        ContentItemId = contentItem.ContentItemId,
                        Question = personPart.Question
                    };
            });
    }
}
