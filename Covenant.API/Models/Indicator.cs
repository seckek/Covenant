// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Indicator
    {
        /// <summary>
        /// Initializes a new instance of the Indicator class.
        /// </summary>
        public Indicator()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Indicator class.
        /// </summary>
        /// <param name="type">Possible values include: 'FileIndicator',
        /// 'NetworkIndicator', 'TargetIndicator'</param>
        public Indicator(int? id = default(int?), IndicatorType? type = default(IndicatorType?))
        {
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'FileIndicator',
        /// 'NetworkIndicator', 'TargetIndicator'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public IndicatorType? Type { get; set; }

    }
}