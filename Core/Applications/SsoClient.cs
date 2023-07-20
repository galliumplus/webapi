﻿using GalliumPlus.WebApi.Core.Random;
using GalliumPlus.WebApi.Core.Users;

namespace GalliumPlus.WebApi.Core.Applications
{
    /// <summary>
    /// Une application cliente qui authentifie ses utilisateurs
    /// via le système de <em>Same Sing-On</em> de Gallium+.
    /// </summary>
    public class SsoClient : Client
    {
        private string secret;
        private string redirectUrl;
        private string? logoUrl;

        /// <summary>
        /// Le code secret utilisé pour signer les jeton d'authentification
        /// </summary>
        public string Secret { get => this.secret; set => this.secret = value; }

        /// <summary>
        /// L'url de redirection une fois l'authentifiaction terminée.
        /// </summary>
        public string RedirectUrl { get => this.redirectUrl; set => this.redirectUrl = value; }

        /// <summary>
        /// L'url du logo de l'application (optionnel)
        /// </summary>
        public string? LogoUrl { get => this.logoUrl; set => this.logoUrl = value; }

        /// <summary>
        /// Crée une application existante avec SSO.
        /// </summary>
        /// <param name="id">L'identifiant de l'application.</param>
        /// <param name="apiKey">La clé d'API.</param>
        /// <param name="secret">Le code secret utilisé comme signature.</param>
        /// <param name="name">Le nom de l'application.</param>
        /// <param name="isEnabled">Si l'application est active ou non.</param>
        /// <param name="redirectUrl">L'URL de redirection après authentification.</param>
        /// <param name="granted">Les permissions accordées à tous les utilisateurs.</param>
        /// <param name="revoked">Les permissions refusées à tous les utilisateurs.</param>
        /// <param name="allowUsers">Autorise ou non les utilisateur à se connecter via l'application.</param>
        /// <param name="logoUrl">L'URL du logo de l'application.</param>
        public SsoClient(
            int id,
            string apiKey,
            string secret,
            string name,
            bool isEnabled,
            string redirectUrl,
            Permissions granted,
            Permissions revoked,
            bool allowUsers,
            string? logoUrl
        )
        : base(id, apiKey, name, isEnabled, granted, revoked, allowUsers)
        {
            this.secret = secret;
            this.redirectUrl = redirectUrl;
            this.logoUrl = logoUrl;
        }

        /// <summary>
        /// Crée une nouvelle application avec SSO.
        /// </summary>
        /// <param name="name">Le nom de l'application.</param>
        /// <param name="redirectUrl">L'URL de redirection après authentification.</param>
        /// <param name="granted">Les permissions accordées à tous les utilisateurs.</param>
        /// <param name="revoked">Les permissions refusées à tous les utilisateurs.</param>
        /// <param name="allowUsers">Autorise ou non les utilisateur à se connecter via l'application.</param>
        /// <param name="logoUrl">L'URL du logo de l'application.</param>
        public SsoClient(
            string name,
            string redirectUrl,
            bool isEnabled = true,
            Permissions granted = Permissions.NONE,
            Permissions revoked = Permissions.NONE,
            bool allowUsers = false,
            string? logoUrl = null
        )
        : base(name, isEnabled, granted, revoked, allowUsers)
        {
            this.redirectUrl = redirectUrl;
            this.logoUrl = logoUrl;

            this.secret = "";
            this.RegenerateSecret();
        }

        public void RegenerateSecret()
        {
            var rtg = new RandomTextGenerator(new CryptoRandomProvider());
            this.secret = rtg.SecretKey();
        }
    }
}
