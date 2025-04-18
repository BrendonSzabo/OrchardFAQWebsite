using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.Data.Migration;
using FAQModule.Models;
using System;
using FAQModule.Indexes;

namespace FAQModule.Migrations
{
    public class FAQMigrations : DataMigration
    {
        IContentDefinitionManager _contentDefinitionManager;

        public FAQMigrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public int Create()
        {
            _contentDefinitionManager.AlterPartDefinition(nameof(FAQPart), builder => builder
                .Attachable()
                .WithDescription("Provides a FAQ part for your content item."));

            _contentDefinitionManager.AlterTypeDefinition(nameof(FAQPart), type => type
                .Creatable()
                .Listable()
                .WithPart(nameof(FAQPart))
                .WithSettings(new ContentTypeSettings
                {
                    Stereotype = "{{ ContentItem | display_text }}"
                })
            );

            SchemaBuilder.CreateMapIndexTable(nameof(FAQPartIndex), table => table
                .Column<string>(nameof(FAQPartIndex.ContentItemId), column => column.WithLength(26))
                .Column<string>(nameof(FAQPartIndex.Question))
            );

            SchemaBuilder.AlterTable(nameof(FAQPartIndex), table => table
                .CreateIndex(
                    $"IDX_{nameof(FAQPartIndex)}_{nameof(FAQPartIndex.Question)}",
                    nameof(FAQPartIndex.Question))
            );

            return 3;
        }

        public int UpdateFrom2()
        {
            SchemaBuilder.CreateMapIndexTable(nameof(FAQPartIndex), table => table
                .Column<string>(nameof(FAQPartIndex.ContentItemId), column => column.WithLength(26))
                .Column<DateTime>(nameof(FAQPartIndex.Question))
            );

            SchemaBuilder.AlterTable(nameof(FAQPartIndex), table => table
                .CreateIndex(
                    $"IDX_{nameof(FAQPartIndex)}_{nameof(FAQPartIndex.Question)}",
                    nameof(FAQPartIndex.Question))
            );

            return 3;
        }
    }
}