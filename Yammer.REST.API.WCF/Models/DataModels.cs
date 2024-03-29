using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MCKD_YammerWCF.Models
{


    [Serializable]
    [DataContract]
    public class ProfileDataResponse
    {
        [DataMember]
        public string Success { get; set; }

        [DataMember]
        public string MessageEn { get; set; }
        
        [DataMember]
        public ReadEmployeeProfileDataClass[] ReadEmployeeProfileData { get; set; }

  
    }


    [Serializable]
    [DataContract]
    public class ReadEmployeeProfileDataClass
    {
        [DataMember]
        public string EmployeeId { get; set; }

        [DataMember]
        public string EmployeeNo { get; set; }

        [DataMember]
        public string EmployeeCardNo { get; set; }


    }
    


    [Serializable]
    [DataContract]
    public class Body
    {
        [DataMember]
        public string[] urls { get; set; }
        [DataMember]
        public string parsed { get; set; }

        [DataMember]
        public string plain { get; set; }
        [DataMember]

        public string rich { get; set; }
    }


    [Serializable]
    [DataContract]
    public class Announcement
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string sender_id { get; set; }


        [DataMember]
        public string delegate_id { get; set; }
        [DataMember]

        public string replied_to_id { get; set; }

        [DataMember]
        public string created_at { get; set; }

        [DataMember]
        public string network_id { get; set; }

        [DataMember]
        public string message_type { get; set; }

        [DataMember]
        public string sender_type { get; set; }

        [DataMember]
        public string url { get; set; }


        [DataMember]
        public string web_url { get; set; }


        [DataMember]
        public string group_id { get; set; }


        [DataMember]
        public Body body { get; set; }

        [DataMember]
        public DateTime date { get; set; }

        [DataMember]
        public string thread_id { get; set; }

        [DataMember]
        public string client_type { get; set; }


        [DataMember]
        public string client_url { get; set; }

        [DataMember]
        public string system_message { get; set; }

        [DataMember]
        public string direct_message { get; set; }

        [DataMember]
        public string chat_client_sequence { get; set; }

        [DataMember]
        public string language { get; set; }

        [DataMember]
        public string[] notified_user_ids { get; set; }

        [DataMember]
        public string privacy { get; set; }

        [DataMember]
        public string content_excerpt { get; set; }

        [DataMember]
        public string group_created_id { get; set; }



        [DataMember]
        public Attachment[] attachments { get; set; }

        [DataMember]
        public likedBy liked_by { get; set; }


    }

    [Serializable]
    [DataContract]
    public class likedBy
    {

        [DataMember]
        public string count { get; set; }

        [DataMember]
        public string[] names { get; set; }
    }


    [Serializable]
    [DataContract]
    public class Attachment
    {

        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string network_id { get; set; }

        [DataMember]
        public string url { get; set; }

        [DataMember]
        public string web_url { get; set; }

        [DataMember]
        public string type { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string original_name { get; set; }

        [DataMember]
        public string full_name { get; set; }

        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string content_type { get; set; }
        [DataMember]
        public string content_class { get; set; }
        [DataMember]
        public string created_at { get; set; }
        [DataMember]
        public string owner_id { get; set; }
        [DataMember]
        public string official { get; set; }
        [DataMember]
        public string storage_type { get; set; }

        [DataMember]
        public string target_type { get; set; }
        [DataMember]
        public string storage_state { get; set; }
        [DataMember]
        public string sharepoint_id { get; set; }
        [DataMember]
        public string sharepoint_web_url { get; set; }
        [DataMember]
        public string small_icon_url { get; set; }
        [DataMember]
        public string large_icon_url { get; set; }
        [DataMember]
        public string download_url { get; set; }
        [DataMember]
        public string thumbnail_url { get; set; }
        [DataMember]
        public string preview_url { get; set; }
        [DataMember]
        public string large_preview_url { get; set; }

        [DataMember]
        public string size { get; set; }
        [DataMember]
        public string owner_type { get; set; }
        [DataMember]
        public string last_uploaded_at { get; set; }
        [DataMember]
        public string last_uploaded_by_id { get; set; }
        [DataMember]
        public string last_uploaded_by_type { get; set; }
        [DataMember]
        public string uuid { get; set; }
        [DataMember]
        public string transcoded { get; set; }
        [DataMember]
        public string streaming_url { get; set; }
        [DataMember]
        public string path { get; set; }
        [DataMember]
        public string y_id { get; set; }
        [DataMember]
        public string overlay_url { get; set; }

        [DataMember]
        public string privacy { get; set; }
        [DataMember]
        public string group_id { get; set; }
        [DataMember]
        public string height { get; set; }
        [DataMember]
        public string width { get; set; }
        [DataMember]
        public string scaled_url { get; set; }
        [DataMember]
        public string latest_version_id { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string real_type { get; set; }

        [DataMember]
        public Image image { get; set; }



    }

    [Serializable]
    [DataContract]
    public class Image
    {
       [DataMember]
        public string url { get; set; }
        [DataMember]
        public string size { get; set; }
        [DataMember]
        public string thumbnail_url { get; set; }


    }





    [Serializable]
    [DataContract]
    public class GroupMessagesRespone
    {
        [DataMember]
        public ThreadedExtended threaded_extended { get; set; }

        [DataMember]
        public Announcement[] messages { get; set; }       

        [DataMember]
        public string[] external_references { get; set; }

        //[DataMember]
        //public Attachment[] attachments { get; set; }

        //[DataMember]
        //public Meta[] meta { get; set; }


    }

    [Serializable]
    [DataContract]
    public class Meta
    {
        [DataMember]
        public bool older_available { get; set; }

        [DataMember]
        public string requested_poll_interval { get; set; }

        [DataMember]
        public RealTime realtime { get; set; }

        [DataMember]
        public string last_seen_message_id { get; set; }

        [DataMember]
        public string current_user_id { get; set; }

        [DataMember]
        public string[] followed_references { get; set; }

        [DataMember]
        public string[] ymodules { get; set; }

        [DataMember]
        public string newest_message_details { get; set; }

        [DataMember]
        public string feed_name { get; set; }

        [DataMember]
        public string feed_desc { get; set; }

        [DataMember]
        public bool direct_from_body { get; set; }


    }
    [Serializable]
    [DataContract]
    public class RealTime
    {
        [DataMember]
        public string uri { get; set; }

        [DataMember]
        public string authentication_token { get; set; }

        [DataMember]
        public string channel_id { get; set; }
    }



    [Serializable]
    [DataContract]
    public class ThreadedExtended
    {
        [DataMember]
        public string id { get; set; }

    }

}

/*
 {
  "id": 1091955163963392,
  "sender_id": 147678453760,
  "delegate_id": null,
  "replied_to_id": null,
  "created_at": "2021/02/23 05:03:19 +0000",
  "network_id": 7782690,
  "message_type": "update",
  "sender_type": "user",
  "url": "https://www.yammer.com/api/v1/messages/1091955163963392",
  "web_url": "https://www.yammer.com/mckd.gov.ae/messages/1091955163963392",
  "group_id": 29716217856,
  "body": {
    "urls": [
      "https://zoom.us/j/94499171007"
    ],
    "parsed": "يوم الطفل الإماراتي \"حق اللعب\" \n\nhttps://zoom.us/j/94499171007",
    "plain": "يوم الطفل الإماراتي \"حق اللعب\"\n\nhttps://zoom.us/j/94499171007",
    "rich": "يوم الطفل الإماراتي \"حق اللعب\" <br><br><a class=\"linkified\" href=\"https://zoom.us/j/94499171007\" target=\"_blank\" rel=\"nofollow noreferrer\">https://zoom.us/j/94499171007</a>"
  },
  "thread_id": 1091955163963392,
  "client_type": "iPhone",
  "client_url": "https://about.yammer.com/product/mobile/ios/",
  "system_message": false,
  "direct_message": false,
  "chat_client_sequence": null,
  "language": "ar",
  "notified_user_ids": [],
  "privacy": "public",
  "attachments": [
    {
      "id": 918108012544,
      "network_id": 7782690,
      "url": "https://www.yammer.com/api/v1/uploaded_files/918108012544",
      "web_url": "https://www.yammer.com/mckd.gov.ae/uploaded_files/918108012544",
      "type": "image",
      "name": "image003 1.png",
      "original_name": "image003 1.png",
      "full_name": "image003 1",
      "description": "",
      "content_type": "image/png",
      "content_class": "Image",
      "created_at": "2021/02/23 05:01:22 +0000",
      "owner_id": 147678453760,
      "official": false,
      "storage_type": "SHAREPOINT",
      "target_type": "GROUP",
      "storage_state": null,
      "sharepoint_id": "01DRBFMMKMLFIZI56FA5GYZF3JRXRWC25Z",
      "sharepoint_web_url": "https://mckduae.sharepoint.com/sites/allcompany/Shared%20Documents/Apps/Yammer/image003%201.png",
      "small_icon_url": "https://s0-azure.assets-yammer.com/assets/images/file_icons/types/picture_orange_39x50_icon.png",
      "large_icon_url": "https://s0-azure.assets-yammer.com/assets/images/file_icons/types/picture_orange_79x102_icon.png",
      "download_url": "https://www.yammer.com/api/v1/uploaded_files/918108012544/download",
      "thumbnail_url": "https://www.yammer.com/api/v1/uploaded_files/918108012544/version/933330296832/thumbnail",
      "preview_url": "https://www.yammer.com/api/v1/uploaded_files/918108012544/preview/",
      "large_preview_url": "https://www.yammer.com/api/v1/uploaded_files/918108012544/version/933330296832/large_preview/",
      "size": 431528,
      "owner_type": "user",
      "last_uploaded_at": "2021/02/23 05:01:22 +0000",
      "last_uploaded_by_id": 147678453760,
      "last_uploaded_by_type": "user",
      "uuid": null,
      "transcoded": null,
      "streaming_url": null,
      "path": "7782690/918108012544/image003 1.png",
      "y_id": 918108012544,
      "overlay_url": "https://www.yammer.com/api/v1/uploaded_files/918108012544/version/933330296832/preview/",
      "privacy": "public",
      "group_id": 29716217856,
      "height": 2048,
      "width": 2048,
      "scaled_url": "https://www.yammer.com/api/v1/uploaded_files/918108012544/version/933330296832/scaled/{{width}}x{{height}}",
      "image": {
        "url": "https://www.yammer.com/api/v1/uploaded_files/918108012544/preview/",
        "size": 431528,
        "thumbnail_url": "https://www.yammer.com/api/v1/uploaded_files/918108012544/version/933330296832/thumbnail"
      },
      "latest_version_id": 933330296832,
      "status": "not_ams",
      "real_type": "uploaded_file"
    },
    {
      "id": 918108307456,
      "network_id": 7782690,
      "url": "https://www.yammer.com/api/v1/uploaded_files/918108307456",
      "web_url": "https://www.yammer.com/mckd.gov.ae/uploaded_files/918108307456",
      "type": "image",
      "name": "الأجندة ِECD 2021Artboard 1.png",
      "original_name": "الأجندة ِECD 2021Artboard 1.png",
      "full_name": "الأجندة ِECD 2021Artboard 1",
      "description": "",
      "content_type": "image/png",
      "content_class": "Image",
      "created_at": "2021/02/23 05:02:15 +0000",
      "owner_id": 147678453760,
      "official": false,
      "storage_type": "SHAREPOINT",
      "target_type": "GROUP",
      "storage_state": null,
      "sharepoint_id": "01DRBFMMNN3ZZDOGAEB5H3C6AECLL5PGUV",
      "sharepoint_web_url": "https://mckduae.sharepoint.com/sites/allcompany/Shared%20Documents/Apps/Yammer/%D8%A7%D9%84%D8%A3%D8%AC%D9%86%D8%AF%D8%A9%20%D9%90ECD%202021Artboard%201.png",
      "small_icon_url": "https://s0-azure.assets-yammer.com/assets/images/file_icons/types/picture_orange_39x50_icon.png",
      "large_icon_url": "https://s0-azure.assets-yammer.com/assets/images/file_icons/types/picture_orange_79x102_icon.png",
      "download_url": "https://www.yammer.com/api/v1/uploaded_files/918108307456/download",
      "thumbnail_url": "https://www.yammer.com/api/v1/uploaded_files/918108307456/version/933330599936/thumbnail",
      "preview_url": "https://www.yammer.com/api/v1/uploaded_files/918108307456/preview/",
      "large_preview_url": "https://www.yammer.com/api/v1/uploaded_files/918108307456/version/933330599936/large_preview/",
      "size": 511677,
      "owner_type": "user",
      "last_uploaded_at": "2021/02/23 05:02:15 +0000",
      "last_uploaded_by_id": 147678453760,
      "last_uploaded_by_type": "user",
      "uuid": null,
      "transcoded": null,
      "streaming_url": null,
      "path": "7782690/918108307456/الأجندة ِECD 2021Artboard 1.png",
      "y_id": 918108307456,
      "overlay_url": "https://www.yammer.com/api/v1/uploaded_files/918108307456/version/933330599936/preview/",
      "privacy": "public",
      "group_id": 29716217856,
      "height": 5760,
      "width": 3240,
      "scaled_url": "https://www.yammer.com/api/v1/uploaded_files/918108307456/version/933330599936/scaled/{{width}}x{{height}}",
      "image": {
        "url": "https://www.yammer.com/api/v1/uploaded_files/918108307456/preview/",
        "size": 511677,
        "thumbnail_url": "https://www.yammer.com/api/v1/uploaded_files/918108307456/version/933330599936/thumbnail"
      },
      "latest_version_id": 933330599936,
      "status": "not_ams",
      "real_type": "uploaded_file"
    },
    {
      "id": 4698160128499712,
      "fake_ogo_ymodule": true,
      "type": "ymodule",
      "record_id": 360620496453632,
      "name": "Join our Cloud HD Video Meeting",
      "description": "Zoom is the leader in modern enterprise video communications, with an easy, reliable cloud platform for video and audio conferencing, chat, and webinars across mobile, desktop, and room systems. Zoom Rooms is the original software-based conference room solution used around the world in board, conference, huddle, and training rooms, as well as executive offices and classrooms. Founded in 2011, Zoom helps businesses and organizations bring their teams together in a frictionless environment to get more done. Zoom is a publicly traded company headquartered in San Jose, CA.",
      "network_id": 7782690,
      "web_url": "https://zoom.us/j/94499171007",
      "thumbnail_url": null,
      "object_type": "page",
      "object_name": "zoom.us",
      "host_url": "zoom.us",
      "inline_url": "blank.html",
      "inline_html": "<div class=\"yj-open-graph-object ymodule-instance\" data-ymodule-instance=\"4698160128499712\">\n  <div class=\"ymodule-instance-4698160128499712-container-1 yj-open-graph-no-image yj-open-graph-contents\">\n    <h5 class=\"yj-title\">\n      <span><a href=\"https://zoom.us/j/94499171007\" target=\"_blank\" rel=\"nofollow noreferrer\"\n          >\n        Join our Cloud HD Video Meeting\n      </a></span>\n    </h5>\n    <h6 class=\"yj-subtitle\">\n      <span>zoom.us</span>\n    </h6>\n    <p class=\"yj-description\">\n      <span>Zoom is the leader in modern enterprise video communications, with an easy, reliable cloud platform for video and audio conferencing, chat, and webinars across mobile, desktop, and room systems. Zoom Rooms is the original software-based conference room solution used around the world in board, conference, huddle, and training rooms, as well as executive offices and classrooms. Founded in 2011, Zoom helps businesses and organizations bring their teams together in a frictionless environment to get…</span>\n    </p>\n  </div>\n  <div class=\"yj-actions-container\"></div>\n</div>\n",
      "ymodule": {
        "web_app_id": "open_graph_object",
        "app_id": "blank",
        "icon_url": "blank.gif"
      }
    }
  ],
  "liked_by": {
    "count": 0,
    "names": []
  },
  "content_excerpt": "يوم الطفل الإماراتي \"حق اللعب\"\n\nhttps://zoom.us/j/94499171007",
  "group_created_id": 29716217856
}
 */
