using FAQModule.Models;
using FAQModule.ViewModels;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;

namespace FAQModule.Drivers
{
    public class FAQPartDisplayDriver : ContentPartDisplayDriver<FAQPart>
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public FAQPartDisplayDriver(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public override IDisplayResult Display(FAQPart part, BuildPartDisplayContext context) =>
            Initialize<FAQPartViewModel>(
                GetDisplayShapeType(context),
                viewModel => PopulateViewModel(part, viewModel))
            .Location("Detail", "Content")
            .Location("Summary", "Content");

        public override IDisplayResult Edit(FAQPart part, BuildPartEditorContext context) =>
           Initialize<FAQPartViewModel>(
               GetEditorShapeType(context),
               viewModel => PopulateViewModel(part, viewModel))
           .Location("Content:5");

        public override async Task<IDisplayResult> UpdateAsync(FAQPart part, IUpdateModel updater, UpdatePartEditorContext context)
        {
            var viewModel = new FAQPartViewModel();

            await updater.TryUpdateModelAsync(viewModel, Prefix);

            part.Question = viewModel.Question;
            part.Answer = viewModel.Answer;

            return await EditAsync(part, context);
        }

        private Task PopulateViewModel(FAQPart part, FAQPartViewModel viewModel)
        {
            viewModel.Question = part.Question;
            viewModel.Answer = part.Answer;

            return Task.CompletedTask;
        }
    }
}
