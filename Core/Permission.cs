namespace GalliumPlus.WebApi.Core
{
    /// <summary>
    /// Permissions sp�ciales attribu�es aux r�les.
    /// </summary>
    public enum Permission
    {
        /// <summary>
        /// Gestion des produits (acc�s � tous, cr�ation, modification et suppression).
        /// </summary>
        MANAGE_PRODUCTS = 1,
        /// <summary>
        /// Gestion des cat�gories (acc�s, cr�ation, modification et suppression).
        /// </summary>
        MANAGE_CATEGORIES = 2,
        /// <summary>
        /// Gestion des utilisateurs (cr�ation, modification et suppression de compte).
        /// </summary>
        MANAGE_USERS = 4,
        /// <summary>
        /// Acc�s en lecture � tous les comptes.
        /// </summary>
        SEE_ALL_USERS = 8,
        /// <summary>
        /// Gestion des acomptes (ajout et retrait).
        /// </summary>
        MANAGE_DEPOSITS = 16,
        /// <summary>
        /// Gestion des r�les (acc�s, cr�ation, assignation, modification et suppression).
        /// </summary>
        MANAGE_ROLES = 32,
        /// <summary>
        /// Faire des ventes.
        /// </summary>
        SELL = 64,
        /// <summary>
        /// Acc�s aux logs.
        /// </summary>
        READ_LOGS = 128,
        /// <summary>
        /// Permission de r�voquer toutes les adh�sions.
        /// </summary>
        RESET_MEMBERSHIPS = 256,
    }
}