using System.Text.Json.Serialization;

namespace GalliumPlus.WebApi.Models
{
	/// <summary>
	/// Une quantit� d'un produit.
	/// </summary>
	public class PurchaseProduct
	{
		/// <summary>
		/// L'identifiant produit achet�.
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// La quantit� achet�e.
		/// </summary>
		public int Quantity { get; set; }
	}
}
