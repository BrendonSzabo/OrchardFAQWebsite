using OrchardCore.ContentManagement;

namespace FAQModule.Models
{
    public class FAQPart : ContentPart
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
