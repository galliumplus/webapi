using System.Text.Json.Serialization;

namespace GalliumPlus.WebApi.Models
{
    /// <summary>
    /// Le r�le d'un utilisateur. 
    /// </summary>
    public class Role
    {
        /// <summary>
        /// L'identifiant du r�le.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Le nom affich� du r�le.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// La somme des permissions attribu�es au r�le.
        /// </summary>
        private int Permissions { get; set; }

        /// <summary>
        /// V�rifie que le r�le a une certaine permission.
        /// </summary>
        /// <param name="perm">La permission � v�rifier</param>
        /// <returns><see langword="true"/> si le r�le a la permission, sinon <see langword="false"/>.</returns>
        public bool HasPermission(Permission perm)
        {
            return (this.Permissions & (int)perm) != 0;
        }

        /// <summary>
        /// Cr�e un r�le.
        /// </summary>
        /// <param name="id">L'identifiant du r�le.</param>
        /// <param name="name">Le nom affich� du r�le.</param>
        /// <param name="permissions">La somme des permissions attribu�es au r�le.</param>
        public Role(int id, string name, int permissions)
        {
            this.Id = id;
            this.Name = name;
            this.Permissions = permissions;
        }
    }
}