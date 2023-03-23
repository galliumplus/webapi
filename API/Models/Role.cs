using System.Text.Json.Serialization;

namespace GalliumPlusAPI.Models
{
	/// <summary>
	/// Le r�le d'un utilisateur. 
	/// </summary>
	public class Role : IModel<int>
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
		public int Permissions { get; set; }

        /// <summary>
        /// V�rifie qu'un r�le a une certaine permission.
        /// </summary>
        /// <param name="perm">La permission � v�rifier</param>
        /// <returns><see langword="true"/> si le r�le a la permission, sinon <see langword="false"/>.</returns>
        public bool HasPermission(Permission perm)
		{
			return (this.Permissions & (int) perm) != 0;
		}
	}
}