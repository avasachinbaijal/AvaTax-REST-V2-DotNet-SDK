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
    /// Frequency Available object
    /// </summary>
    public class FrequencyAvailableModel
    {
        /// <summary>
        /// Frequency Code
        /// </summary>
        public String frequencyCode { get; set; }

        /// <summary>
        /// Frequency Name
        /// </summary>
        public String frequencyName { get; set; }

        /// <summary>
        /// Reason
        /// </summary>
        public String reason { get; set; }

        /// <summary>
        /// Expired Calendar End Date
        /// </summary>
        public List<AvailableCycleModel> availableCycles { get; set; }


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
