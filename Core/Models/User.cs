namespace GalliumPlus.WebApi.Models
{
	/// <summary>
	/// Un utilisateur de l'application.
	/// </summary>
	public class User
	{
		/// <summary>
		/// L'identifiant IUT (ou identifiant sp�cial) de l'utilisateur.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Le pr�nom et nom de l'utilisateur.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// L'identifiant du r�le de l'utilisateur.
		/// </summary>
		public int RoleId { get; set; }

		/// <summary>
		/// La promotion de l'utilisateur.
		/// </summary>
		public string Year { get; set; }

		/// <summary>
		/// L'acompte de l'utilisateur.
		/// </summary>
		public double Deposit { get; set; }

		/// <summary>
		/// Indique si l'utilisateur doit valider les paiements avec son acompte.
		/// </summary>
		public bool RequireValidationForPayments { get; set; }

        /// <summary>
        /// Cr�e un utilisateur.
        /// </summary>
        /// <param name="id">L'identifiant IUT (ou identifiant sp�cial) de l'utilisateur.</param>
        /// <param name="name">Le pr�nom et nom de l'utilisateur.</param>
        /// <param name="roleId">L'identifiant du r�le de l'utilisateur.</param>
        /// <param name="year">La promotion de l'utilisateur.</param>
        /// <param name="deposit">L'acompte de l'utilisateur.</param>
        /// <param name="requireValidationForPayments">Indique si l'utilisateur doit valider les paiements avec son acompte.</param>
        public User(string id, string name, int roleId, string year, double deposit, bool requireValidationForPayments)
        {
            this.Id = id;
            this.Name = name;
            this.RoleId = roleId;
            this.Year = year;
            this.Deposit = deposit;
            this.RequireValidationForPayments = requireValidationForPayments;
        }
    }
}