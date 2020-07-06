using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace MicrosoftStoreServices.V1.Common.Enums
{
    /// <summary>
    /// User's payment method
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentInstrumentType
    {
        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Credit Card")]
        CreditCard,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Direct Debit Card")]
        DirectDebitCard,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Inferred Purchase")]
        InferredPurchase,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "MS Balance")]
        MSBalance,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Mobile Operator")]
        MobileOperator,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Online Bank Transfer")]
        OnlineBankTransfer,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "PayPal")]
        PayPal,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Split Transaction")]
        SplitTransaction,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Token Redemption")]
        TokenRedemption,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Zero Amount Paid")]
        ZeroAmountPaid,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "eWallet")]
        EWallet,

        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

    }
}
