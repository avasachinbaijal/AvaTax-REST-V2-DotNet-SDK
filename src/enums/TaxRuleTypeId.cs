using System;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2018 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Ted Spence
 * @author Zhenya Frolov
 * @author Greg Hester
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Specifies the type of custom tax rule you have created.
    /// </summary>
    public enum TaxRuleTypeId
    {
        /// <summary>
        /// Reserved for Avalara internal usage.
        /// </summary>
        RateRule,

        /// <summary>
        /// Specifies a rule that changes the rate of tax for a specified set of criteria.
        ///  
        ///  This rule can apply to one specific type of product (identified by `TaxCode`) or all products (identified by a null `TaxCode`).
        /// </summary>
        RateOverrideRule,

        /// <summary>
        /// Specifies a rule that changes the tax base of a specific product.
        ///  
        ///  This rule can apply to one specific type of product (identified by `TaxCode`) or all products (identified by a null `TaxCode`).
        /// </summary>
        BaseRule,

        /// <summary>
        /// Indicates that a particular product is exempt from tax due to an exempt usage reason.
        ///  
        ///  Amounts exempted by this rule are stored in the `exemptAmount` field on the transaction.
        /// </summary>
        ExemptEntityRule,

        /// <summary>
        /// Specifies a rule that changes whether a product is taxable or not.
        ///  
        ///  This rule must be applied to a specific type of product. If you attempt to create a product taxability rule while
        ///  leaving the `TaxCode` and `TaxCodeId` fields empty, you will get an error.
        ///  
        ///  A `value` field of `1` means that this tax code is taxable; `0` means it is nontaxable.
        ///  
        ///  Amounts that are considered not taxable according to this rule are stored in the `nonTaxableAmount`
        ///  column in a transaction.
        ///  
        ///  This type of rule can also determine the rate type for a product or to apply a cap or threshold.
        /// </summary>
        ProductTaxabilityRule,

        /// <summary>
        /// Reserved for Avalara internal usage.
        /// </summary>
        NexusRule,

    }
}
