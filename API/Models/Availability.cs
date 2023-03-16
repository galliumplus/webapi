namespace GalliumPlusAPI.Models
{

	/// <summary>
	/// Disponiblit� d'un produit.
	/// </summary>
	public enum Availability
	{
		/// <summary>
		/// Le produit est toujours consid�r� comme disponible.
		/// </summary>
		ALWAYS,
		
		/// <summary>
		/// Le produit est disponible si il en reste en stock.
		/// </summary>
		AUTO,
		
		/// <summary>
		/// Le produit est toujours consid�r� comme indisponible.
		/// </summary>
		NEVER,
	}
}