﻿namespace GalliumPlus.WebApi.Core.Exceptions
{
    /// <summary>
    /// Erreur indiquant une vente refusée.
    /// </summary>
    public class CantSellException : GalliumException
    {
        public override ErrorCode ErrorCode => ErrorCode.CANT_SELL;

        public CantSellException(string message) : base(message) { }
    }
}
