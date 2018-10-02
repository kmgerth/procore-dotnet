using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Procore.Api.Core.CompanyDirectory
{
    /// <summary>
    ///     Represents an existing <see cref="Company" /> vendor.
    /// </summary>
    [DataContract]
    public class CompanyVendor
    {
        //---------------------------------------------------------------------
        // Properties - Public
        //---------------------------------------------------------------------
        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> abbreviated name.
        /// </summary>
        [DataMember(Name = "abbreviated_name")]
        public string AbbreviatedName { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> address.
        /// </summary>
        [DataMember(Name = "address")]
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the list of <see cref="CompanyVendor" /> attachments.
        /// </summary>
        [DataMember(Name = "attachments")]
        public IEnumerable<Attachment> Attachments { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> authorized bidder status.
        /// </summary>
        [DataMember(Name = "authorized_bidder")]
        public bool AuthorizedBidder { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> bid details.
        /// </summary>
        [DataMember(Name = "bidding")]
        public BiddingStatus BiddingStatuses { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> business phone number.
        /// </summary>
        [DataMember(Name = "business_phone")]
        public string BusinessPhone { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> business register.
        /// </summary>
        [DataMember(Name = "business_register")]
        public object BusinessRegister { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> city.
        /// </summary>
        [DataMember(Name = "city")]
        public string City { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> company.
        /// </summary>
        [DataMember(Name = "company")]
        public string Company { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> country code.
        /// </summary>
        [DataMember(Name = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     Gets or sets the date the <see cref="CompanyVendor" /> was created.
        /// </summary>
        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> email address.
        /// </summary>
        [DataMember(Name = "email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> fax number.
        /// </summary>
        [DataMember(Name = "fax_number")]
        public string FaxNumber { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> ID.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is active. (Defaults to true)
        /// </summary>
        [DataMember(Name = "is_active")]
        public bool IsActive { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> labor union.
        /// </summary>
        [DataMember(Name = "labor_union")]
        public string LaborUnion { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> license number.
        /// </summary>
        [DataMember(Name = "license_number")]
        public string LicenseNumber { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> logo.
        /// </summary>
        [DataMember(Name = "logo")]
        public string Logo { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> mobile phone number.
        /// </summary>
        [DataMember(Name = "mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a non-union prevailing-wage business.
        /// </summary>
        [DataMember(Name = "non_union_prevailing_wage")]
        public bool NonUnionPrevailingWage { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> notes.
        /// </summary>
        [DataMember(Name = "notes")]
        public string Notes { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> origin code.
        /// </summary>
        [DataMember(Name = "origin_code")]
        public string OriginCode { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> origin data.
        /// </summary>
        [DataMember(Name = "origin_data")]
        public string OriginData { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> origin ID.
        /// </summary>
        [DataMember(Name = "origin_id")]
        public string OriginId { get; set; }

        /// <summary>
        ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is prequalifed.
        /// </summary>
        [DataMember(Name = "prequalified")]
        public bool Prequalified { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> <see cref="PrimaryContact" />.
        /// </summary>
        [DataMember(Name = "primary_contact")]
        public PrimaryContact PrimaryContactDetail { get; set; }

        /// <summary>
        ///     Gets or sets the list of <see cref="CompanyVendor" /> project IDs.
        /// </summary>
        [DataMember(Name = "project_ids")]
        public IEnumerable<int> ProjectIds { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> state code.
        /// </summary>
        [DataMember(Name = "state_code")]
        public string StateCode { get; set; }

        /// <summary>
        ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a union member.
        /// </summary>
        [DataMember(Name = "union_member")]
        public bool UnionMember { get; set; }

        /// <summary>
        ///     Gets or sets the date the <see cref="CompanyVendor" /> was last updated.
        /// </summary>
        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        ///     Gets or sets the list of <see cref="CompanyVendor" /> <see cref="VendorGroup" /> details.
        /// </summary>
        [DataMember(Name = "vendor_group")]
        public VendorGroup VendorGroupDetail { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> website.
        /// </summary>
        [DataMember(Name = "website")]
        public string Website { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="CompanyVendor" /> zip code.
        /// </summary>
        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        //---------------------------------------------------------------------
        // Classes - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Initializes a new isntance of the <see cref="CompanyVendor" /> class.
        /// </summary>
        public CompanyVendor()
        {
            IsActive = true;
            BiddingStatuses = new BiddingStatus();
            Attachments = new List<Attachment>();
            ProjectIds = new List<int>();
            VendorGroupDetail = new VendorGroup();
            PrimaryContactDetail = new PrimaryContact();
        }

        //---------------------------------------------------------------------
        // Functions - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Converts the value of this instance to its equivalent <see cref="CompanyVendorUpdate" /> representation.
        /// </summary>
        public CompanyVendorUpdate ToCompanyVendorUpdate()
        {
            CompanyVendorUpdate vendor = new CompanyVendorUpdate
            {
                Id = Id,
                VendorDetail =
                {
                    AbbreviatedName = AbbreviatedName,
                    Address = Address,
                    AuthorizedBidder = AuthorizedBidder,
                    BusinessPhone = BusinessPhone,
                    City = City,
                    CountryCode = CountryCode,
                    EmailAddress = EmailAddress,
                    FaxNumber = FaxNumber,
                    IsActive = IsActive,
                    LaborUnion = LaborUnion,
                    LicenseNumber = LicenseNumber,
                    MobilePhone = MobilePhone,
                    Name = Name,
                    NonUnionPrevailingWage = NonUnionPrevailingWage,
                    Notes = Notes,
                    OriginCode = OriginCode,
                    OriginData = OriginData,
                    OriginId = OriginId,
                    Prequalified = Prequalified,
                    StateCode = StateCode,
                    UnionMember = UnionMember,
                    Website = Website,
                    Zip = Zip
                }
            };

            // Normally the constructor will initialize this object, but if the class was created
            // through a JSON Serializer it can be null.
            if (BiddingStatuses != null)
            {
                vendor.VendorDetail.BiddingStatuses.AffirmativeAction = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.SmallBusiness = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.AfricanAmericanBusiness = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.HispanicBusiness = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.WomensBusiness = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.HistoricallyUnderutilizedBusiness = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.SdvoBusiness = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.CertifiedBusinessEnterprise = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.AsianAmericanBusiness = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.NativeAmericanBusiness = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.DisadvantagedBusiness = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.MinorityBusinessEnterprise = BiddingStatuses.AffirmativeAction;
                vendor.VendorDetail.BiddingStatuses.EightABusiness = BiddingStatuses.AffirmativeAction;
            }

            return vendor;
        }

        //---------------------------------------------------------------------
        // Classes - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Represents <see cref="CompanyVendor" /> bidding flags.
        /// </summary>
        [DataContract]
        public class BiddingStatus
        {
            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is an affirmative action business.
            /// </summary>
            [DataMember(Name = "affirmative_action")]
            public bool AffirmativeAction { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is an African American business.
            /// </summary>
            [DataMember(Name = "african_american_business")]
            public bool AfricanAmericanBusiness { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is an Asian American business.
            /// </summary>
            [DataMember(Name = "asian_american_business")]
            public bool AsianAmericanBusiness { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a certified business enterprise.
            /// </summary>
            [DataMember(Name = "certified_business_enterprise")]
            public bool CertifiedBusinessEnterprise { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a disadvantaged business.
            /// </summary>
            [DataMember(Name = "disadvantaged_business")]
            public bool DisadvantagedBusiness { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is an 8A business.
            /// </summary>
            [DataMember(Name = "eight_a_business")]
            public bool EightABusiness { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a Hispanic business.
            /// </summary>
            [DataMember(Name = "hispanic_business")]
            public bool HispanicBusiness { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a historically underutilized business.
            /// </summary>
            [DataMember(Name = "historically_underutilized_business")]
            public bool HistoricallyUnderutilizedBusiness { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a minority business enterprise.
            /// </summary>
            [DataMember(Name = "minority_business_enterprise")]
            public bool MinorityBusinessEnterprise { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a Native American business.
            /// </summary>
            [DataMember(Name = "native_american_business")]
            public bool NativeAmericanBusiness { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is an SDVO business.
            /// </summary>
            [DataMember(Name = "sdvo_business")]
            public bool SdvoBusiness { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a small business.
            /// </summary>
            [DataMember(Name = "small_business")]
            public bool SmallBusiness { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="CompanyVendor" /> is a woman owned business.
            /// </summary>
            [DataMember(Name = "womens_business")]
            public bool WomensBusiness { get; set; }
        }

        //---------------------------------------------------------------------
        // Classes - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Represents a <see cref="CompanyVendor" /> vendor group.
        /// </summary>
        [DataContract]
        public class VendorGroup
        {
            //---------------------------------------------------------------------
            // Properties - Public
            //---------------------------------------------------------------------

            /// <summary>
            ///     Gets or sets the <see cref="VendorGroup" /> ID.
            /// </summary>
            [DataMember(Name = "id")]
            public int Id { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="VendorGroup" /> name.
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }

        /// <summary>
        ///     Represents a <see cref="CompanyVendor" /> primary contact.
        /// </summary>
        [DataContract]
        public class PrimaryContact
        {
            //---------------------------------------------------------------------
            // Properties - Public
            //---------------------------------------------------------------------

            /// <summary>
            ///     Gets or sets the date the <see cref="PrimaryContact" /> was created.
            /// </summary>
            [DataMember(Name = "created_at")]
            public string CreatedAt { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="PrimaryContact" /> email address.
            /// </summary>
            [DataMember(Name = "email_address")]
            public string EmailAddress { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="PrimaryContact" /> first name.
            /// </summary>
            [DataMember(Name = "first_name")]
            public string FirstName { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="PrimaryContact" /> ID.
            /// </summary>
            [DataMember(Name = "id")]
            public int Id { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="PrimaryContact" /> last name.
            /// </summary>
            [DataMember(Name = "last_name")]
            public string LastName { get; set; }

            /// <summary>
            ///     Gets or sets the date the <see cref="PrimaryContact" /> was last updated.
            /// </summary>
            [DataMember(Name = "updated_at")]
            public string UpdatedAt { get; set; }
        }

        /// <summary>
        ///     Represents a <see cref="CompanyVendor" /> primary attachment.
        /// </summary>
        [DataContract]
        public class Attachment
        {
            //---------------------------------------------------------------------
            // Properties - Public
            //---------------------------------------------------------------------

            /// <summary>
            ///     Gets or sets the <see cref="Attachment" /> file name.
            /// </summary>
            [DataMember(Name = "filename")]
            public string Filename { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Attachment" /> ID.
            /// </summary>
            [DataMember(Name = "id")]
            public int Id { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Attachment" /> URL.
            /// </summary>
            [DataMember(Name = "url")]
            public string Url { get; set; }
        }
    }
}
