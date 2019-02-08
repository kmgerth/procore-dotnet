using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Procore.Api.Core.Project;

namespace Procore.Api.Core.Commitments
{
    /// <summary>
    ///     Models a WorkOrderContract.
    /// </summary>
    [DataContract]
    class WorkOrderContract
    {
        /// <summary>
        ///     Gets or sets the accounting_method of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "accounting_method")]
        public string AccountingMethod { get; set; }

        /// <summary>
        ///     Gets or sets the actual_completion_date of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "actual_completion_date")]
        public DateTimeOffset ActualCompletionDate { get; set; }

        /// <summary>
        ///     Gets or sets the approved_change_orders of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "approved_change_orders")]
        public string ApprovedChangeOrders { get; set; }

        /// <summary>
        ///     Gets or sets the contract_start_date of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "contract_start_date")]
        public DateTimeOffset ContractStartDate { get; set; }

        /// <summary>
        ///     Gets or sets the contract_estimated_completion_date of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "contract_estimated_completion_date")]
        public DateTimeOffset ContractEstimatedCompletionDate { get; set; }

        /// <summary>
        ///     Gets or sets the created_at of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        ///     Gets or sets the deleted_at of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "deleted_at")]
        public DateTimeOffset DeletedAt { get; set; }

        /// <summary>
        ///     Gets or sets the description of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the exclusions of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "exclusions")]
        public string Exclusions { get; set; }

        /// <summary>
        ///     Gets or sets the executed of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "executed")]
        public bool Executed { get; set; }

        /// <summary>
        ///     Gets or sets the grand_total of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "grand_total")]
        public string GrandTotal { get; set; }

        /// <summary>
        ///     Gets or sets the id of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "id")]
        public long Id { get; set; }

        /// <summary>
        ///     Gets or sets the inclusions of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "inclusions")]
        public string Inclusions { get; set; }

        /// <summary>
        ///     Gets or sets the number of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "number")]
        public string Number { get; set; }

        /// <summary>
        ///     Gets or sets the origin_data of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "origin_data")]
        public string OriginData { get; set; }

        /// <summary>
        ///     Gets or sets the origin_code of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "origin_code")]
        public string OriginCode { get; set; }

        /// <summary>
        ///     Gets or sets the origin_id of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "origin_id")]
        public long OriginId { get; set; }

        /// <summary>
        ///     Gets or sets the pending_change_orders of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "pending_change_orders")]
        public string PendingChangeOrders { get; set; }

        /// <summary>
        ///     Gets or sets the pending_revised_contract of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "pending_revised_contract")]
        public string PendingRevisedContract { get; set; }

        /// <summary>
        ///     Gets or sets the percentage_paid of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "percentage_paid")]
        public string PercentagePaid { get; set; }

        /// <summary>
        ///     Gets or sets the private of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "private")]
        public bool Private { get; set; }

        /// <summary>
        ///     Gets or sets the project of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "project")]
        public ProjectStruct Project { get; set; }

        /// <summary>
        ///     Gets or sets the remaining_balance_outstanding of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "remaining_balance_outstanding")]
        public string RemainingBalanceOutstanding { get; set; }

        /// <summary>
        ///     Gets or sets the requisitions_are_enabled of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "requisitions_are_enabled")]
        public bool RequisitionsAreEnabled { get; set; }

        /// <summary>
        ///     Gets or sets the retainage_percent of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "retainage_percent")]
        public string RetainagePercent { get; set; }

        /// <summary>
        ///     Gets or sets the revised_contract of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "revised_contract")]
        public string RevisedContract { get; set; }

        /// <summary>
        ///     Gets or sets the signed_contract_received_date of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "signed_contract_received_date")]
        public DateTimeOffset SignedContractReceivedDate { get; set; }

        /// <summary>
        ///     Gets or sets the status of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        ///     Gets or sets the title of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        ///     Gets or sets the total_draw_requests_amount of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "total_draw_requests_amount")]
        public string TotalDrawRequestsAmount { get; set; }

        /// <summary>
        ///     Gets or sets the total_payments of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "total_payments")]
        public string TotalPayments { get; set; }

        /// <summary>
        ///     Gets or sets the total_requisitions_amount of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "total_requisitions_amount")]
        public string TotalRequisitionsAmount { get; set; }

        /// <summary>
        ///     Gets or sets the updated_at of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        ///     Gets or sets the vendor of the <see cref="WorkOrderContract" />.
        /// </summary>
        [DataMember(Name = "vendor")]
        public VendorStruct Vendor { get; set; }

        public struct ProjectStruct
        {
            /// <summary>
            ///     Gets or sets the id of the <see cref="Project" />.
            /// </summary>
            [DataMember(Name = "id")]
            public long Id { get; set; }

            /// <summary>
            ///     Gets or sets the name of the <see cref="Project" />.
            /// </summary>
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }

        public struct VendorStruct
        {
            /// <summary>
            ///     Gets or sets the id of the <see cref="Vendor" />.
            /// </summary>
            [DataMember(Name = "id")]
            public long Id { get; set; }

            /// <summary>
            ///     Gets or sets the company of the <see cref="Vendor" />.
            /// </summary>
            [DataMember(Name = "company")]
            public string Company { get; set; }
        }
    }

   
}
