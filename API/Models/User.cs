namespace GalliumPlusAPI.Models
{
	/// <summary>
	/// Un utilisateur de l'application.
	/// </summary>
	public class User : IModel<string>
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
	}
}