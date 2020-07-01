using Radyn.Framework;
using Radyn.Framework.DbHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public abstract class TurkcrmBaseFacade<T> : BaseFacade<T> where T : class
    {
        protected TurkcrmBaseFacade() : base(new TurkcrmConnectionHandler(), false)
        {

        }
        protected TurkcrmBaseFacade(IConnectionHandler connectionHandler)
            : base(connectionHandler)
        {

        }
    }

    public class TurkcrmConnectionHandler : ConnectionHandler
    {
        public TurkcrmConnectionHandler()
        {
            base.ConnectionString = TurkcrmComponents.ConnectionString;
        }
    }

}
