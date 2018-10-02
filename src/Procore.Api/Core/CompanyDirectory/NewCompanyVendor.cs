using System.Runtime.Serialization;

namespace Procore.Api.Core.CompanyDirectory
{
    /// <summary>
    ///     Represents a new <see cref="Company" /> vendor.
    /// </summary>
    [DataContract]
    public class NewCompanyVendor
    {
        //---------------------------------------------------------------------
        // Properties - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Company ID.
        /// </summary>
        [DataMember(Name = "company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        ///     Vendor information.
        /// </summary>
        [DataMember(Name = "vendor")]
        public Vendor VendorDetail { get; set; }

        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        /// <summary>
        ///     Initializes a new instance of the <see cref="NewCompanyVendor" /> class.
        /// </summary>
        public NewCompanyVendor()
        {
            VendorDetail = new Vendor();
        }

        //---------------------------------------------------------------------
        // Classes - Public
        //---------------------------------------------------------------------

        /// <summary>
        ///     Represents the vendor details.
        /// </summary>
        [DataContract]
        public class Vendor
        {
            //---------------------------------------------------------------------
            // Properties - Public
            //---------------------------------------------------------------------

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> abbreviated name.
            /// </summary>
            [DataMember(Name = "abbreviated_name")]
            public string AbbreviatedName { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> address.
            /// </summary>
            [DataMember(Name = "address")]
            public string Address { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> authorized bidder status.
            /// </summary>
            [DataMember(Name = "authorized_bidder")]
            public bool AuthorizedBidder { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> bid details.
            /// </summary>
            [DataMember(Name = "bidding")]
            public BiddingStatus BiddingStatuses { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> business phone number.
            /// </summary>
            [DataMember(Name = "business_phone")]
            public string BusinessPhone { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> city.
            /// </summary>
            [DataMember(Name = "city")]
            public string City { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> company.
            /// </summary>
            [DataMember(Name = "company")]
            public string Company { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> country code.
            /// </summary>
            [DataMember(Name = "country_code")]
            public string CountryCode { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> email address.
            /// </summary>
            [DataMember(Name = "email_address")]
            public string EmailAddress { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> fax number.
            /// </summary>
            [DataMember(Name = "fax_number")]
            public string FaxNumber { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is active. (Defaults to true)
            /// </summary>
            [DataMember(Name = "is_active")]
            public bool IsActive { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> labor union.
            /// </summary>
            [DataMember(Name = "labor_union")]
            public string LaborUnion { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> license number.
            /// </summary>
            [DataMember(Name = "license_number")]
            public string LicenseNumber { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> mobile phone number.
            /// </summary>
            [DataMember(Name = "mobile_phone")]
            public string MobilePhone { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> name.
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a non-union prevailing-wage business.
            /// </summary>
            [DataMember(Name = "non_union_prevailing_wage")]
            public bool NonUnionPrevailingWage { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> notes.
            /// </summary>
            [DataMember(Name = "notes")]
            public string Notes { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> origin code.
            /// </summary>
            [DataMember(Name = "origin_code")]
            public string OriginCode { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> origin data.
            /// </summary>
            [DataMember(Name = "origin_data")]
            public string OriginData { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> origin ID.
            /// </summary>
            [DataMember(Name = "origin_id")]
            public string OriginId { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is prequalifed.
            /// </summary>
            [DataMember(Name = "prequalified")]
            public bool Prequalified { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> state code.
            /// </summary>
            [DataMember(Name = "state_code")]
            public string StateCode { get; set; }

            /// <summary>
            ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a union member.
            /// </summary>
            [DataMember(Name = "union_member")]
            public bool UnionMember { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> website.
            /// </summary>
            [DataMember(Name = "website")]
            public string Website { get; set; }

            /// <summary>
            ///     Gets or sets the <see cref="Vendor" /> zip code.
            /// </summary>
            [DataMember(Name = "zip")]
            public string Zip { get; set; }

            //---------------------------------------------------------------------
            // Constructor
            //---------------------------------------------------------------------

            /// <summary>
            ///     Initializes a new instance of the <see cref="CompanyVendorUpdate" /> class.
            /// </summary>
            public Vendor()
            {
                IsActive = true;
                BiddingStatuses = new BiddingStatus();
            }

            //---------------------------------------------------------------------
            // Classes - Public
            //---------------------------------------------------------------------

            /// <summary>
            ///     Represents <see cref="Vendor" /> bidding flags.
            /// </summary>
            [DataContract]
            public class BiddingStatus
            {
                //---------------------------------------------------------------------
                // Properties - Public
                //---------------------------------------------------------------------

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is an affirmative action business.
                /// </summary>
                [DataMember(Name = "affirmative_action")]
                public bool AffirmativeAction { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is an African American business.
                /// </summary>
                [DataMember(Name = "african_american_business")]
                public bool AfricanAmericanBusiness { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is an Asian American business.
                /// </summary>
                [DataMember(Name = "asian_american_business")]
                public bool AsianAmericanBusiness { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a certified business enterprise.
                /// </summary>
                [DataMember(Name = "certified_business_enterprise")]
                public bool CertifiedBusinessEnterprise { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a disadvantaged business.
                /// </summary>
                [DataMember(Name = "disadvantaged_business")]
                public bool DisadvantagedBusiness { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is an 8A business.
                /// </summary>
                [DataMember(Name = "eight_a_business")]
                public bool EightABusiness { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a Hispanic business.
                /// </summary>
                [DataMember(Name = "hispanic_business")]
                public bool HispanicBusiness { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a historically underutilized business.
                /// </summary>
                [DataMember(Name = "historically_underutilized_business")]
                public bool HistoricallyUnderutilizedBusiness { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a minority business enterprise.
                /// </summary>
                [DataMember(Name = "minority_business_enterprise")]
                public bool MinorityBusinessEnterprise { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a Native American business.
                /// </summary>
                [DataMember(Name = "native_american_business")]
                public bool NativeAmericanBusiness { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is an SDVO business.
                /// </summary>
                [DataMember(Name = "sdvo_business")]
                public bool SdvoBusiness { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a small business.
                /// </summary>
                [DataMember(Name = "small_business")]
                public bool SmallBusiness { get; set; }

                /// <summary>
                ///     Gets or sets the flag indicating if the <see cref="Vendor" /> is a woman owned business.
                /// </summary>
                [DataMember(Name = "womens_business")]
                public bool WomensBusiness { get; set; }
            }
        }
    }
}
