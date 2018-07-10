using System;
using System.Runtime.Serialization;
using PipServices.Commons.Data;

namespace Interface
{
    [DataContract]
    public class AccountV1 : IStringIdentifiable
    {
        /* Identification */
        [DataMember(Name="id")]
        public string Id { get; set; }
        [DataMember(Name="login")]
        public string Login { get; set; }
        [DataMember(Name="name")]
        public string Name;

        /* Activity tracking */
        [DataMember(Name="create_time")]
        public DateTime CreateTime { get; set; }
        [DataMember(Name="active")]
        public Boolean Active { get; set; }

        /* User preferences */
        [DataMember(Name="time_zone")]
        public string TimeZone { get; set; }
        [DataMember(Name="language")]
        public string Language { get; set; }
        [DataMember(Name="theme")]
        public string Theme { get; set; }

        /* Custom fields */
        [DataMember(Name="custom_hdr")]
        public object CustomHdr { get; set; }
        [DataMember(Name="custom_dat")]
        public object CustomDat { get; set; }

        public bool Equals(AccountV1 a)
        {
            return a != null
                   && a.Id == Id
                   && a.Name == Name
                   && a.Login == Login
                   && a.CreateTime == CreateTime
                   && a.Active == Active
                   && a.TimeZone == TimeZone
                   && a.Language == Language
                   && a.Theme == Theme
                   && a.CustomHdr == CustomHdr
                   && a.CustomDat == CustomDat
                   && a.CreateTime == CreateTime;
        }
    }
}