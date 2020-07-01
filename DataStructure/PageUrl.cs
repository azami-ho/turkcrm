using System;
using Radyn.Framework;

namespace Radyn.Common.DataStructure
{
    [Serializable]
    [Schema("Common")]
    public sealed class PageUrl : DataStructureBase<PageUrl>
    {
        private Guid _id;
        [Key(false)]
        [DbType("uniqueidentifier")]
        public Guid Id
        {
            get { return _id; }
            set { base.SetPropertyValue("Id", value); }
        }

        private string _seoUrl;
        [DbType("nvarchar(200)")]
        [Unique]
        public string SeoUrl
        {
            get { return _seoUrl; }
            set { base.SetPropertyValue("SeoUrl", value); }
        }

        private string _pageLink;
        [DbType("nvarchar(200)")]
        public string PageLink
        {
            get { return _pageLink; }
            set { base.SetPropertyValue("PageLink", value); }
        }


    }

}