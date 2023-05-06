namespace GalliumPlus.WebApi.Core.Users
{
    /// <summary>
    /// Permissions sp�ciales attribu�es aux r�les.
    /// </summary>
    public enum Permissions : uint
    {
        /// <summary>
        /// Acc�s en lecture aux produits et cat�gories.
        /// </summary>
        SEE_PRODUCTS_AND_CATEGORIES = 1,

        /// <summary>
        /// Gestion des produits (acc�s � tous, cr�ation, modification et suppression).
        /// </summary>
        MANAGE_PRODUCTS = 2 | SEE_PRODUCTS_AND_CATEGORIES,

        /// <summary>
        /// Gestion des cat�gories (acc�s, cr�ation, modification et suppression).
        /// </summary>
        MANAGE_CATEGORIES = 4 | SEE_PRODUCTS_AND_CATEGORIES,

        /// <summary>
        /// Acc�s en lecture � tous les comptes.
        /// </summary>
        SEE_ALL_USERS = 8,

        /// <summary>
        /// Gestion des acomptes (ajout et retrait).
        /// </summary>
        MANAGE_DEPOSITS = 16 | SEE_ALL_USERS,

        /// <summary>
        /// Gestion des utilisateurs (cr�ation, modification et suppression de compte).
        /// S'applique uniquement aux utilisateurs dont le rang est inf�rieur ou �gal
        /// au rang de l'utilisateur ayant cette permission.
        /// </summary>
        MANAGE_USERS = 32 | MANAGE_DEPOSITS,

        /// <summary>
        /// Gestion des r�les (cr�ation, modification et suppression).
        /// </summary>
        MANAGE_ROLES = 64,

        /// <summary>
        /// Faire des ventes.
        /// </summary>
        SELL = 128 | MANAGE_PRODUCTS | MANAGE_DEPOSITS,

        /// <summary>
        /// Acc�s aux logs.
        /// </summary>
        READ_LOGS = 256,

        /// <summary>
        /// Permission de r�voquer toutes les adh�sions.
        /// </summary>
        RESET_MEMBERSHIPS = 512 | MANAGE_USERS,
    }
}