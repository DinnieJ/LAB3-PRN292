using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace excercise3
{
    public enum EN
    {
        [EnumMember(Value = "Login")]
        LABEL,
        [EnumMember(Value = "Username:")]
        USERNAME_LABEL,
        [EnumMember(Value = "Password:")]
        PASSWORD_LABEL,
        [EnumMember(Value = "EN")]
        RADIO_EN,
        [EnumMember(Value = "VI")]
        RADIO_VI,

    }

    public enum VI
    {
        [EnumMember(Value = "Đăng nhập")]
        LABEL,
        [EnumMember(Value = "Tên đăng nhập:")]
        USERNAME_LABEL,
        [EnumMember(Value = "Mật khẩu:")]
        PASSWORD_LABEL,
        [EnumMember(Value = "Anh")]
        RADIO_EN,
        [EnumMember(Value = "Việt")]
        RADIO_VI,
    }
}
