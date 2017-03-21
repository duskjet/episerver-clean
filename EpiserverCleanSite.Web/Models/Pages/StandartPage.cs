using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverCleanSite.Web.Models.Pages
{
    [ContentType(DisplayName = "StandartPage", GUID = "de0cff87-589b-4dfd-999a-80aa33599e13", Description = "")]
    public class StandartPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}