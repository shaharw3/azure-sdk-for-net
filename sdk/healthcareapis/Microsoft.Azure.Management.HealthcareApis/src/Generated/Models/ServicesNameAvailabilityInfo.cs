// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties indicating whether a given service name is available.
    /// </summary>
    public partial class ServicesNameAvailabilityInfo
    {
        /// <summary>
        /// Initializes a new instance of the ServicesNameAvailabilityInfo
        /// class.
        /// </summary>
        public ServicesNameAvailabilityInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServicesNameAvailabilityInfo
        /// class.
        /// </summary>
        /// <param name="nameAvailable">The value which indicates whether the
        /// provided name is available.</param>
        /// <param name="reason">The reason for unavailability. Possible values
        /// include: 'Invalid', 'AlreadyExists'</param>
        /// <param name="message">The detailed reason message.</param>
        public ServicesNameAvailabilityInfo(bool? nameAvailable = default(bool?), ServiceNameUnavailabilityReason? reason = default(ServiceNameUnavailabilityReason?), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the value which indicates whether the provided name is
        /// available.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; private set; }

        /// <summary>
        /// Gets the reason for unavailability. Possible values include:
        /// 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public ServiceNameUnavailabilityReason? Reason { get; private set; }

        /// <summary>
        /// Gets or sets the detailed reason message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}