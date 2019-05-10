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
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Represents the exact API request and response from the original transaction API call, if available
    /// </summary>
    public class OriginalApiRequestResponseModel
    {
        /// <summary>
        /// API request
		/// CAUTION: the type of this will change in 19.5 update
        /// </summary>
        public object request { get; set; }

		/// <summary>
		/// API response
		/// CAUTION: the type of this will change in 19.5 update
		/// </summary>
		public object response { get; set; }


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
