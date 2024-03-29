using MCKD_YammerWCF.Models;
using MCKD_YammerWCF.YammerBusinesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MCKD_YammerWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IYammer" in both code and config file together.
    [ServiceContract]
    public interface IYammer
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
     UriTemplate = "/GetRecentAnnouncements")]
        GroupMessagesRespone GetRecentAnnouncements();
    }
}
