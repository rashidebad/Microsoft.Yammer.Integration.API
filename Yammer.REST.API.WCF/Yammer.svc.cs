using MCKD_YammerWCF.Models;
using MCKD_YammerWCF.YammerBusinesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MCKD_YammerWCF
{




    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Yammer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Yammer.svc or Yammer.svc.cs at the Solution Explorer and start debugging.
    public class Yammer : IYammer
    {
        private YammerConroller yammerConroller = new YammerConroller();

        public GroupMessagesRespone GetRecentAnnouncements()
        {
            return yammerConroller.GetRecentAnnouncements();
        }
    }
}
