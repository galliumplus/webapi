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

        NOT_SEE_PRODUCTS_AND_CATEGORIES = 1 | NOT_MANAGE_PRODUCTS | NOT_MANAGE_CATEGORIES,

        /// <summary>
        /// Gestion des produits (acc�s � tous, cr�ation, modification et suppression).
        /// </summary>
        MANAGE_PRODUCTS = 2 | SEE_PRODUCTS_AND_CATEGORIES,

        NOT_MANAGE_PRODUCTS = 2,

        /// <summary>
        /// Gestion des cat�gories (acc�s, cr�ation, modification et suppression).
        /// </summary>
        MANAGE_CATEGORIES = 4 | SEE_PRODUCTS_AND_CATEGORIES,

        NOT_MANAGE_CATEGORIES = 4,

        /// <summary>
        /// Acc�s en lecture � tous les comptes et r�les.
        /// </summary>
        SEE_ALL_USERS_AND_ROLES = 8,

        NOT_SEE_ALL_USERS_AND_ROLES = 8 | NOT_MANAGE_DEPOSITS | NOT_MANAGE_ROLES,

        /// <summary>
        /// Gestion des acomptes (ajout et retrait).
        /// </summary>
        MANAGE_DEPOSITS = 16 | SEE_ALL_USERS_AND_ROLES,

        NOT_MANAGE_DEPOSITS = 16 | NOT_MANAGE_USERS,

        /// <summary>
        /// Gestion des utilisateurs (cr�ation, modification et suppression de compte).
        /// S'applique uniquement aux utilisateurs dont le rang est inf�rieur ou �gal
        /// au rang de l'utilisateur ayant cette permission.
        /// </summary>
        MANAGE_USERS = 32 | MANAGE_DEPOSITS,

        NOT_MANAGE_USERS = 32 | NOT_RESET_MEMBERSHIPS,

        /// <summary>
        /// Gestion des r�les (cr�ation, modification et suppression).
        /// </summary>
        MANAGE_ROLES = 64 | SEE_ALL_USERS_AND_ROLES,

        NOT_MANAGE_ROLES = 64,

        /// <summary>
        /// Acc�s aux logs.
        /// </summary>
        READ_LOGS = 128,

        /// <summary>
        /// Permission de r�voquer toutes les adh�sions.
        /// </summary>
        RESET_MEMBERSHIPS = 256 | MANAGE_USERS,

        NOT_RESET_MEMBERSHIPS = 256,

        //=== PERMISSIONS COMPOS�ES ===//

        /// <summary>
        /// Faire des ventes.
        /// </summary>
        SELL = MANAGE_PRODUCTS | MANAGE_DEPOSITS,

        //=== VALEURS SP�CIALES ===//

        /// <summary>
        /// Aucune permission
        /// </summary>
        NONE = 0,

        /// <summary>
        /// Toutes les permissions
        /// </summary>
        ALL = 511,
    }

    public static class PermissionsExtensions
    {
        /// <summary>
        /// V�rifie que <paramref name="other"/> est inclus dans ces permissions.
        /// </summary>
        /// <param name="other">Les permissions � tester.</param>
        /// <returns><see langword="true"/> si les permissions sont incluses, sinon <see langword="false"/></returns>
        public static bool Includes(this Permissions @this, Permissions other)
        {
            return (@this & other) == other;
        }

        /// <summary>
        /// Ajoute <paramref name="other"/> � ces permissions.
        /// </summary>
        /// <param name="other">Les permissions � ajouter.</param>
        /// <returns>Les permissions combin�es.</returns>
        public static Permissions Grant(this Permissions @this, Permissions other)
        {
            return @this | other;
        }

        /// <summary>
        /// Enl�ve <paramref name="other"/> de ces permissions.
        /// </summary>
        /// <param name="other">Les permissions � enlever.</param>
        /// <returns>Les permissions restantes.</returns>
        public static Permissions Revoke(this Permissions @this, Permissions other)
        {
            return @this & ~other;
        }
    }
}