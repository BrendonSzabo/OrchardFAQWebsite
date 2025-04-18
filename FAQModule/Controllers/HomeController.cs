using FAQModule.Models;
using FAQModule.ViewModels;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Records;
using System.Linq;
using System.Threading.Tasks;
using YesSql;

namespace FAQModule.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISession _session;
        private readonly IContentManager _contentManager;

        public HomeController(ISession session, IContentManager contentManager)
        {
            _session = session;
            _contentManager = contentManager;
        }

        public async Task<IActionResult> Index()
        {
            var faqItems = await _session
                .Query<ContentItem, ContentItemIndex>(idx => idx.ContentType == nameof(FAQPart))
                .ListAsync();

            foreach (var item in faqItems)
            {
                await _contentManager.LoadAsync(item);
            }

            var faqs = faqItems.Select(item => item.As<FAQPart>()).ToList();

            return View(faqs);
        }

    }
}