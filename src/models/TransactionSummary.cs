using System;
using System.Collections.Generic;
using Newtonsoft.Json;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2019 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Genevieve Conty
 * @author Greg Hester
 * Swagger name: AvaTaxClient
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Summary information about an overall transaction.
    /// </summary>
    public class TransactionSummary
    {
        /// <summary>
        /// Two character ISO-3166 country code.
        /// </summary>
        public String country { get; set; }

        /// <summary>
        /// Two or three character ISO region, state or province code, if applicable.
        /// </summary>
        public String region { get; set; }

        /// <summary>
        /// The type of jurisdiction that collects this tax.
        /// </summary>
        public JurisdictionType? jurisType { get; set; }

        /// <summary>
        /// Jurisdiction Code for the taxing jurisdiction
        /// </summary>
        public String jurisCode { get; set; }

        /// <summary>
        /// The name of the jurisdiction that collects this tax.
        /// </summary>
        public String jurisName { get; set; }

        /// <summary>
        /// The unique ID of the Tax Authority Type that collects this tax.
        /// </summary>
        public Int32? taxAuthorityType { get; set; }

        /// <summary>
        /// The state assigned number of the jurisdiction that collects this tax.
        /// </summary>
        public String stateAssignedNo { get; set; }

        /// <summary>
        /// The tax type of this tax.
        /// </summary>
        public String taxType { get; set; }

        /// <summary>
        /// The tax subtype of this tax.
        /// </summary>
        public String taxSubType { get; set; }

        /// <summary>
        /// The name of the tax.
        /// </summary>
        public String taxName { get; set; }

        /// <summary>
        /// Group code when special grouping is enabled.
        /// </summary>
        public String taxGroup { get; set; }

        /// <summary>
        /// DEPRECATED - Date: 3/1/2018, Version: 18.3, Message: Please use rateTypeCode instead.
        /// Indicates the tax rate type.
        /// </summary>
        public RateType? rateType { get; set; }

        /// <summary>
        /// Indicates the code of the rate type. Use [ListRateTypesByCountry](https://developer.avalara.com/api-reference/avatax/rest/v2/methods/Definitions/ListRateTypesByCountry/) API for a full list of rate type codes.
        /// </summary>
        public String rateTypeCode { get; set; }

        /// <summary>
        /// Tax Base - The adjusted taxable amount.
        /// </summary>
        public Decimal? taxable { get; set; }

        /// <summary>
        /// Tax Rate - The rate of taxation, as a fraction of the amount.
        /// </summary>
        public Decimal? rate { get; set; }

        /// <summary>
        /// Tax amount - The calculated tax (Base * Rate).
        /// </summary>
        public Decimal? tax { get; set; }

        /// <summary>
        /// The amount of tax that AvaTax calculated for the transaction.
        ///  
        /// If you used a `taxOverride` of type `taxAmount`, there may be a difference between
        /// the `tax` field which applies your override, and the `TaxCalculated` field which
        /// represents the amount of tax that AvaTax calculated for this transaction without override.
        ///  
        /// You can use this for comparison.
        /// </summary>
        public Decimal? taxCalculated { get; set; }

        /// <summary>
        /// The amount of the transaction that was non-taxable.
        /// </summary>
        public Decimal? nonTaxable { get; set; }

        /// <summary>
        /// The amount of the transaction that was exempt.
        /// </summary>
        public Decimal? exemption { get; set; }


        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}
