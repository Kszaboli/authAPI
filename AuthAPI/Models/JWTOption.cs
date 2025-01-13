﻿namespace AuthAPI.Models
{
    public class JWTOption
    {
        public string Issuer { get; set; } = string.Empty;
        public string Audience {  get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
    }
}
