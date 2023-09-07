﻿namespace GalliumPlus.WebApi.Core.Stocks
{
    /// <summary>
    /// Disponiblité d'un produit.
    /// </summary>
    public enum Availability
    {
        /// <summary>
        /// Le produit est toujours considéré comme disponible.
        /// </summary>
        ALWAYS = 0,

        /// <summary>
        /// Le produit est disponible si il en reste en stock.
        /// </summary>
        AUTO = 1,

        /// <summary>
        /// Le produit est toujours considéré comme indisponible.
        /// </summary>
        NEVER = 2,
    }
}