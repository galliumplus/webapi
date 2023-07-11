﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GalliumPlus.WebApi.Core.Sales
{
    public abstract class PaymentMethod
    {
        /// <summary>
        /// Paie le montant indiqué.
        /// </summary>
        /// <param name="amount">Le montant à payer.</param>
        /// <exception cref="CantSellException"></exception>
        /// <returns>Une phrase indiquant que l'opération à bien été effectuée.</returns>
        public abstract string Pay(double amount);
    }
}