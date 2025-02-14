﻿namespace Quaestor.Bot.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        public string AccessToken { get; set; }
        public string UserName { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public long UserId { get; set; }
        public bool IsGoogle2Fa { get; set; }
    }
}
