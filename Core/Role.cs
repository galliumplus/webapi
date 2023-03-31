using GalliumPlus.WebApi.Core.Serialization;
using System.Text.Json.Serialization;

namespace GalliumPlus.WebApi.Core
{
    /// <summary>
    /// Le r�le d'un utilisateur. 
    /// </summary>
    public class Role
    {
        private int id;
        private string name;
        private Permission permissions;

        /// <summary>
        /// L'identifiant du r�le.
        /// </summary>
        [JsonReferenceKey]
        public int Id { get => this.id; set => this.id = value; }

        /// <summary>
        /// Le nom affich� du r�le.
        /// </summary>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// La somme des permissions attribu�es au r�le.
        /// </summary>
        private Permission Permissions { get => this.permissions; set => this.permissions = value; }

        /// <summary>
        /// V�rifie que le r�le a une certaine permission.
        /// </summary>
        /// <param name="perm">La permission � v�rifier</param>
        /// <returns><see langword="true"/> si le r�le a la permission, sinon <see langword="false"/>.</returns>
        public bool HasPermission(Permission perm)
        {
            return (Permissions & perm) != 0;
        }

        /// <summary>
        /// Cr�e un r�le.
        /// </summary>
        /// <param name="id">L'identifiant du r�le.</param>
        /// <param name="name">Le nom affich� du r�le.</param>
        /// <param name="permissions">La somme des permissions attribu�es au r�le.</param>
        public Role(int id, string name, Permission permissions)
        {
            this.id = id;
            this.name = name;
            this.permissions = permissions;
        }
    }
}