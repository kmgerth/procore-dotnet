using System;
using System.Runtime.Serialization;

namespace Procore.Api.Core.Project
{
    /// <summary>
    ///     Models a Project.
    /// </summary>
    [DataContract]
    public class Project
    {
        /// <summary>
        ///     Gets or sets the address of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "address")]
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the city of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }

        /// <summary>
        ///     Gets or sets the company the <see cref="Project" /> belongs to.
        /// </summary>
        [DataMember(Name = "company")]
        public CompanyStruct Company { get; set; }

        /// <summary>
        ///     Gets or sets the country code of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     Gets or sets the county of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "county")]
        public string County { get; set; }

        /// <summary>
        ///     Gets or sets the date the <see cref="Project" /> was created.
        /// </summary>
        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Gets or sets the display name of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Gets or sets the unique ID of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        ///     The Active status of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "active")]
        public bool IsActive { get; set; }

        /// <summary>
        ///     Gets or sets the latitude of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "latitude")]
        public float? Latitude { get; set; }

        /// <summary>
        ///     Gets or sets the longitude of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "longitude")]
        public float? Longitude { get; set; }

        /// <summary>
        ///     Gets or sets the name of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the third-party data of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "origin_data")]
        public string OriginData { get; set; }

        /// <summary>
        ///     Gets or sets the third-party ID of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "origin_id")]
        public string OriginId { get; set; }

        /// <summary>
        ///     Gets or sets the phone number of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="Project" /> number.
        /// </summary>
        [DataMember(Name = "project_number")]
        public string ProjectNumber { get; set; }

        /// <summary>
        ///     Gets or sets the stage of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "stage")]
        public string Stage { get; set; }

        /// <summary>
        ///     Gets or sets the state code of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "state_code")]
        public string StateCode { get; set; }

        /// <summary>
        ///     Gets or sets the date the <see cref="Project" /> was last updated.
        /// </summary>
        [DataMember(Name = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///     Gets or sets the zip code of the <see cref="Project" />.
        /// </summary>
        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        [DataContract]
        public struct CompanyStruct
        {
            /// <summary>
            ///     Gets or sets the ID of the <see cref="Company" />
            /// </summary>
            [DataMember(Name = "id")]
            public int Id { get; set; }

            /// <summary>
            ///     Gets or sets the name of the <see cref="Company" />
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }
    }
}
