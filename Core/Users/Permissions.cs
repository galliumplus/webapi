/**
 * PAR PITI�, NE MODIFIEZ PAS LES PERMISSIONS EXISTANTES.
 * 
 * Vous pouvez rajouter de nouvelles permissions avec des puissances de 2
 * (jusqu'� 2 147 483 648)
 * 
 * R�FL�CHISSEZ AUSSI AVANT DE RENOMMER/CHANGER LA SIGNIFICATION D'UN R�LE
 */

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
        /// Acc�s en lecture � tous les comptes et r�les.
        /// </summary>
        SEE_ALL_USERS_AND_ROLES = 8,

        /// <summary>
        /// Gestion des acomptes (ajout et retrait).
        /// </summary>
        MANAGE_DEPOSITS = 16 | SEE_ALL_USERS_AND_ROLES,

        /// <summary>
        /// Gestion des utilisateurs (cr�ation, modification et suppression de compte).
        /// S'applique uniquement aux utilisateurs dont le rang est inf�rieur ou �gal
        /// au rang de l'utilisateur ayant cette permission.
        /// </summary>
        MANAGE_USERS = 32 | MANAGE_DEPOSITS,

        /// <summary>
        /// Gestion des r�les (cr�ation, modification et suppression).
        /// </summary>
        MANAGE_ROLES = 64 | SEE_ALL_USERS_AND_ROLES,

        /// <summary>
        /// Acc�s aux logs.
        /// </summary>
        READ_LOGS = 128,

        /// <summary>
        /// Permission de r�voquer toutes les adh�sions.
        /// </summary>
        RESET_MEMBERSHIPS = 256 | MANAGE_USERS,

        //=== PERMISSIONS COMPOS�ES ===//

        /// <summary>
        /// Faire des ventes.
        /// </summary>
        SELL = MANAGE_PRODUCTS | MANAGE_DEPOSITS,
    }
}