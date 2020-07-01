using Radyn.Common.DataStructure;
using Radyn.Framework;
using Radyn.Framework.DbHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class PageUrlDA : DALBase<PageUrl>
    {
        public PageUrlDA(IConnectionHandler connectionHandler) : base(connectionHandler)
        {
        }
    }
}
