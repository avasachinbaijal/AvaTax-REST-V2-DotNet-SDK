using System;

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
    /// 
    /// </summary>
    public enum CompanyAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,

        /// <summary>
        /// 
        /// </summary>
        SingleCompany = 1,

        /// <summary>
        /// 
        /// </summary>
        SingleAccount = 2,

        /// <summary>
        /// 
        /// </summary>
        AllCompanies = 3,

        /// <summary>
        /// 
        /// </summary>
        FirmManagedAccounts = 4,

    }
}
