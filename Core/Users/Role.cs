namespace GalliumPlus.WebApi.Core.Users
{
    /// <summary>
    /// Le r�le d'un utilisateur. 
    /// </summary>
    public class Role
    {
        private int id;
        private string name;
        private Permissions permissions;

        /// <summary>
        /// L'identifiant du r�le.
        /// </summary>
        public int Id { get => this.id; set => this.id = value; }

        /// <summary>
        /// Le nom affich� du r�le.
        /// </summary>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// La somme des permissions attribu�es au r�le.
        /// </summary>
        public Permissions Permissions { get => this.permissions; set => this.permissions = value; }

        /// <summary>
        /// Cr�e un r�le.
        /// </summary>
        /// <param name="id">L'identifiant du r�le.</param>
        /// <param name="name">Le nom affich� du r�le.</param>
        /// <param name="permissions">La somme des permissions attribu�es au r�le.</param>
        public Role(int id, string name, Permissions permissions)
        {
            this.id = id;
            this.name = name;
            this.permissions = permissions;
        }
    }
}