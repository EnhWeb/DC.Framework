﻿namespace Ding.Biz.OAuthLogin.QQ.Configs
{
    /// <summary>
    /// QQ配置
    /// </summary>
    public class QQConfig : ConfigBase
    {
        /// <summary>
        /// 仅做说明用
        /// 请根据步骤操作：Authorization => AccessToken => OpenId => OpenAPI（get_user_info）
        /// </summary>
        public enum Step
        {
            Step1_Authorization,
            Step2_AccessToken,
            Step3_OpenId,
            Step4_OpenAPI
        }

        #region API请求接口

        /// <summary>
        /// PC网站，GET
        /// </summary>
        public string API_Authorization_PC { get; set; } = "https://graph.qq.com/oauth2.0/authorize";

        /// <summary>
        /// PC网站，GET
        /// </summary>
        public string API_AccessToken_PC { get; set; } = "https://graph.qq.com/oauth2.0/token";
        /// <summary>
        /// WAP网站，GET
        /// </summary>
        public string API_AccessToken_WAP { get; set; } = "https://graph.z.qq.com/moc2/token";

        /// <summary>
        /// PC GET
        /// </summary>
        public string API_OpenID_PC = "https://graph.qq.com/oauth2.0/me";

        /// <summary>
        /// WAP GET
        /// </summary>
        public string API_OpenID_WAP = "https://graph.z.qq.com/moc2/me";

        /// <summary>
        /// GET
        /// </summary>
        public string API_Get_User_Info = "https://graph.qq.com/user/get_user_info";

        #endregion
    }
}
