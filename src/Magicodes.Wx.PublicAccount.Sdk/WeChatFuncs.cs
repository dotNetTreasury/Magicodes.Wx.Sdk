﻿using System;

namespace Magicodes.Wx.PublicAccount.Sdk
{
    public class WeChatFuncs
    {
        public Func<WeChatOptions> GetWeChatOptions { get; set; }

        public Func<string, string> GetAccessTokenByAppId { get; set; }

        public Action<string, string> CacheAccessToken { get; set; }
    }
}
