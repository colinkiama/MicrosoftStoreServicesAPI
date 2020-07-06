using MicrosoftStoreServicesAPI.V1.Common;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MicrosoftStoreServices.V1.Acquisitions
{
    public enum AcquisitionsOrderBy
    {
        /// <summary>
        /// Date
        /// </summary>
        [EnumMember(Value = "date")]
        Date,

        /// <summary>
        /// Type of acquisition
        /// </summary>
        [EnumMember(Value = "acquisitionType")]
        AcquisitionType,

        /// <summary>
        /// Age group
        /// </summary>
        [EnumMember(Value = "age")]
        Age,

        /// <summary>
        /// Place where the app has been acquired
        /// </summary>
        [EnumMember(Value = "storeClient")]
        StoreClient,

        /// <summary>
        /// Gender of the user
        /// </summary>
        [EnumMember(Value = "gender")]
        Gender,

        /// <summary>
        /// Market where the app has been acquired
        /// </summary>
        [EnumMember(Value = "market")]
        Market,

        /// <summary>
        /// OS Version of the user
        /// </summary>
        [EnumMember(Value = "osVersion")]
        OsVersion,

        /// <summary>
        /// Device type
        /// </summary>
        [EnumMember(Value = "deviceType")]
        DeviceType,

        /// <summary>
        /// PaymentInstrumentType
        /// </summary>
        [EnumMember(Value = "paymentInstrumentType")]
        PaymentInstrumentType,

        /// <summary>
        /// PaymentInstrumentType
        /// </summary>
        [EnumMember(Value = "sandboxId")]
        SandboxId,

        /// <summary>
        /// PaymentInstrumentType
        /// </summary>
        [EnumMember(Value = "xboxTitleIdHex")]
        XboxTitleIdHex,

    }
}
