using Services.Facade;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class TurkcrmComponents
    {

        private TurkcrmComponents()
        {

        }

        private static TurkcrmComponents _instance;
        public static TurkcrmComponents Instance
        {
            get { return _instance ?? (_instance = new TurkcrmComponents()); }
        }
        public static string ConnectionString { get; set; }

        public IPageUrlFacade PageUrlFacade
        {
            get
            {
                return new PageUrlFacade();
            }
        }
    }
}
