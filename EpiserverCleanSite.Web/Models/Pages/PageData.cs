using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverCleanSite.Web.Models.Pages
{
    public class PageData : EPiServer.Core.PageData
    {
        #region SEO

        protected const string GroupNameSEO = "SEO";

        [Display(GroupName = GroupNameSEO, Order = 200, Name = nameof(Title))]
        [CultureSpecific]
        public virtual string Title { get; set; }

        [Display(GroupName = GroupNameSEO, Order = 200, Name = nameof(Description))]
        [CultureSpecific]
        public virtual string Description { get; set; }

        [Display(GroupName = GroupNameSEO, Order = 200, Name = nameof(Keywords))]
        [CultureSpecific]
        public virtual string Keywords { get; set; }

        #endregion
    }
}