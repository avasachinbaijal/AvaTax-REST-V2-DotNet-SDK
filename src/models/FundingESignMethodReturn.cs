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
    /// Represents the current status of a funding ESign method
    /// </summary>
    public class FundingESignMethodReturn
    {
        /// <summary>
        /// Method
        /// </summary>
        public String method { get; set; }

        /// <summary>
        /// JavaScriptReady
        /// </summary>
        public Boolean? javaScriptReady { get; set; }

        /// <summary>
        /// The actual javascript to use to render this object
        /// </summary>
        public String javaScript { get; set; }


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
