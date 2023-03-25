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

        /// <summary>
        /// Cr�e un achat.
        /// </summary>
        /// <param name="products">Les produits achet�s.</param>
        /// <param name="paymentMethod">La m�thode de paiement utilis�e.</param>
        public Purchase(List<PurchaseProduct> products, PaymentMethod paymentMethod)
		{
			this.Products = products;
			this.PaymentMethod = paymentMethod;
		}
	}
}