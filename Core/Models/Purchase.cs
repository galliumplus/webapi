using System.Text.Json.Serialization;

namespace GalliumPlus.WebApi.Models
{
	/// <summary>
	/// Un achat.
	/// </summary>
	public class Purchase
	{
		/// <summary>
		/// Les produits achet�s.
		/// </summary>
		public List<PurchaseProduct> Products { get; set; }

		/// <summary>
		/// La m�thode de paiement utilis�e.
		/// </summary>
		public PaymentMethod PaymentMethod { get; set; }
	}
}