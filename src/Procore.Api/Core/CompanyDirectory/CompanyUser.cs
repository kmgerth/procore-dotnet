using System.Runtime.Serialization;

namespace Procore.Api.Core.CompanyDirectory
{
    /// <summary>
    ///     Models a User associated with a Company that can be safely updated through the Procore API.
    /// </summary>
    [DataContract(Name = "user")]
    public class CompanyUser
    {
        /// <summary>
        ///     The Address of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "address")]
        public string Address { get; set; }

        /// <summary>
        ///     The Business Phone of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "business_phone")]
        public string BusinessPhone { get; set; }

        /// <summary>
        ///     The Business Phone Extension of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "business_phone_extension")]
        public string BusinessPhoneExtension { get; set; }

        /// <summary>
        ///     The City of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }

        /// <summary>
        ///     The Country Code of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     The Email Address of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        ///     The Email Signature of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "email_signature")]
        public string EmailSignature { get; set; }

        /// <summary>
        ///     The ID of the Employee of the <see cref="CompanyUser" /> when <see cref="IsEmployee" /> is set to true.
        /// </summary>
        [DataMember(Name = "employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        ///     The Fax Number of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "fax_number")]
        public string FaxNumber { get; set; }

        /// <summary>
        ///     The First Name of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        ///     Unique Id of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     The Initials of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "initials")]
        public string Initials { get; set; }

        /// <summary>
        ///     The Active status of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "is_active")]
        public bool IsActive { get; set; }

        /// <summary>
        ///     The Employee status of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "is_employee")]
        public bool IsEmployee { get; set; }

        /// <summary>
        ///     The Job Title of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "job_title")]
        public string JobTitle { get; set; }

        /// <summary>
        ///     The Last Name of the <see cref="CompanyUser" />
        /// </summary>
        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        ///     The Mobile Phone of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        ///     The Notes of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "notes")]
        public string Notes { get; set; }

        /// <summary>
        ///     The State Code of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "state_code")]
        public string StateCode { get; set; }

        /// <summary>
        ///     The ID of the Vendor of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "vendor_id")]
        public string VendorId { get; set; }

        /// <summary>
        ///     The Zip code of the <see cref="CompanyUser" />.
        /// </summary>
        [DataMember(Name = "zip")]
        public string Zip { get; set; }
    }
}
