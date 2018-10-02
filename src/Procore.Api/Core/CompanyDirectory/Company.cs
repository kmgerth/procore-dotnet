using System.Runtime.Serialization;

namespace Procore.Api.Core.CompanyDirectory
{
    /// <summary>
    ///     Models a Company.
    /// </summary>
    [DataContract]
    public class Company
    {
        /// <summary>
        ///     Unique ID of the <see cref="Company" />.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        ///     The name of the <see cref="Company" />.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     The active status of the <see cref="Company" />.
        /// </summary>
        [DataMember(Name = "is_active")]
        public bool IsActive { get; set; }
    }
}
