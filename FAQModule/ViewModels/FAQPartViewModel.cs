using FAQModule.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.ContentManagement;
using System.ComponentModel.DataAnnotations;

namespace FAQModule.ViewModels
{
    public class FAQPartViewModel
    {

        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }
    }
}
