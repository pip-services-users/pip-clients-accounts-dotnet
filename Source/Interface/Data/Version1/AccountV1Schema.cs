using System;
using PipServices.Commons.Validate;

namespace Interface
{
    public class AccountV1Schema : ObjectSchema
    {
        public AccountV1Schema()
        {
            WithOptionalProperty("Id", TypeCode.String);
            WithRequiredProperty("Login", TypeCode.String);
            WithOptionalProperty("Name", TypeCode.String);
            WithOptionalProperty("CreateTime", TypeCode.DateTime);
            WithOptionalProperty("Active", TypeCode.Boolean);
            WithOptionalProperty("TimeZone", TypeCode.String);
            WithOptionalProperty("Language", TypeCode.String);
            WithOptionalProperty("Theme", TypeCode.String);
            WithOptionalProperty("CustomHdr", TypeCode.Object);
            WithOptionalProperty("CustomDat", TypeCode.Object);
        }
    }
}