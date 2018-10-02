using System.Runtime.Serialization;

namespace Procore.Api.Core.CompanyDirectory
{
    /// <summary>
    ///     Models extended details for a User associated with a Company.
    /// </summary>
    [DataContract]
    public class CompanyUserDetail
    {
        /// <summary>
        ///     The Address of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "address")]
        public string Address { get; set; }

        /// <summary>
        ///     Avatar URL of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "avatar")]
        public string Avatar { get; set; }

        /// <summary>
        ///     The Business Phone of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "business_phone")]
        public string BusinessPhone { get; set; }

        /// <summary>
        ///     The Business Phone Extension of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "business_phone_extension")]
        public string BusinessPhoneExtension { get; set; }

        /// <summary>
        ///     The City of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }

        /// <summary>
        ///     The Country Code of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     The Email Address of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        ///     The Email Signature of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "email_signature")]
        public string EmailSignature { get; set; }

        /// <summary>
        ///     The ID of the Employee of the <see cref="CompanyUserDetail" /> when <see cref="IsEmployee" /> is set to true.
        /// </summary>
        [DataMember(Name = "employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        ///     The Fax Number of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "fax_number")]
        public string FaxNumber { get; set; }

        /// <summary>
        ///     The First Name of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        ///     Unique ID of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     The Initials of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "initials")]
        public string Initials { get; set; }

        /// <summary>
        ///     Date the <see cref="CompanyUserDetail" /> was invited to Procore.
        /// </summary>
        [DataMember(Name = "invited_at")]
        public string InvitedAt { get; set; }

        /// <summary>
        ///     The Active status of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "is_active")]
        public bool IsActive { get; set; }

        /// <summary>
        ///     The Employee status of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "is_employee")]
        public bool IsEmployee { get; set; }

        /// <summary>
        ///     The Job Title of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "job_title")]
        public string JobTitle { get; set; }

        /// <summary>
        ///     Date the <see cref="CompanyUserDetail" /> last logged in.
        /// </summary>
        [DataMember(Name = "last_login_at")]
        public string LastLoginAt { get; set; }

        /// <summary>
        ///     The Last Name of the <see cref="CompanyUserDetail" />
        /// </summary>
        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        ///     The Mobile Phone of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        ///     The Notes of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "notes")]
        public string Notes { get; set; }

        /// <summary>
        ///     The State Code of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "state_code")]
        public string StateCode { get; set; }

        /// <summary>
        ///     The Zip code of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        /// <summary>
        ///     The Origin ID of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "origin_id")]
        public string OriginId { get; set; }

        /// <summary>
        ///     The Origin Data of the <see cref="CompanyUserDetail" />.
        /// </summary>
        [DataMember(Name = "origin_data")]
        public string OriginData { get; set; }

        /// <summary>
        ///     Date the <see cref="CompanyUserDetail" /> was created.
        /// </summary>
        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        ///     Date the <see cref="CompanyUserDetail" /> was updated.
        /// </summary>
        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        ///     Models a Vendor associated with a Company.
        /// </summary>
        [DataMember(Name = "vendor")]
        public VendorStruct? Vendor { get; set; }

        /// <summary>
        ///     Models a Vendor associated with a Company.
        /// </summary>
        [DataContract]
        public struct VendorStruct
        {
            /// <summary>
            ///     The ID of the Vendor of the <see cref="CompanyUserDetail" />.
            /// </summary>
            [DataMember(Name = "id")]
            public string Id { get; set; }

            /// <summary>
            ///     The name of the Vendor of the <see cref="CompanyUserDetail" />.
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }
    }
}
