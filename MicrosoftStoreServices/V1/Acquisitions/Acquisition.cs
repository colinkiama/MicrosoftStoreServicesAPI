using MicrosoftStoreServices.V1.Common.Enums;
using MicrosoftStoreServicesAPI.V1.Common.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftStoreServices.V1.Acquisitions
{
    public class Acquisition
    {
        /// <summary>
        /// Gets the product ID of the app for which you are retrieving acquisition data.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets the first date in the date range for the acquisition data.
        /// If the request specified a single day, this value is that date.
        /// If the request specified a week, month, or other date range, this value is the first date in that date range.
        /// </summary>
        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets the display name of the app.
        /// </summary>
        [JsonProperty("applicationName")]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Get the type of acquisition (free, paid, and so on).
        /// </summary>
        [JsonProperty("acquisitionType")]
        public AcquisitionType AcquisitionType { get; set; }

        /// <summary>
        /// Gets the age group of the user who made the acquisition.
        /// </summary>
        [JsonProperty("age")]
        public Age Age { get; set; }

        /// <summary>
        /// Gets the type of device that completed the acquisition.
        /// </summary>
        [JsonProperty("deviceType")]
        public DeviceType DeviceType { get; set; }
        
        /// <summary>
        /// Gets the gender of the user who made the acquisition.
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets the ISO 3166 country code of the market where the acquisition occurred.
        /// </summary>
        [JsonProperty("market")]
        public string Market { get; set; }
        
        // <summary>
        /// Gets the OS version on which the acquisition occurred.
        /// </summary>
        [JsonProperty("osVersion")]
        public OsVersion OsVersion { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("paymentInstrumentType")]
        public PaymentInstrumentType PaymentInstrumentType { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("sandboxId")]
        public string SandBoxId{ get; set; }


        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("storeClient")]
        public StoreClientType StoreClient { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("xboxTitleId")]
        public string XboxTitleId { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("acquisitionQuantity")]
        public int AcquisitionQuantity { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("purchasePriceUSDAmount")]
        public int PurchasePriceUSDAmount { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("purchaseTaxUSDAmount")]
        public int PurchaseTaxUSDAmount { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("localCurrencyCode")]
        public string LocalCurrencyCode { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("xboxProductId")]
        public string XboxProductId { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("availabilityId")]
        public string AvailabilityId { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("skuId")]
        public string SkuId { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("skuDisplayName")]
        public string SkuDisplayName { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("xboxParentProductId")]
        public string XboxParentProductId { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("parentProductName")]
        public string parentProductName { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("productTypeName")]
        public string ProductTypeName { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("purchaseTaxType")]
        public string PurchaseTaxType { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("purchasePriceLocalAmount")]
        public int PurchasePriceLocalAmount { get; set; }

        /// <summary>
        /// Gets the version of the Store where the acquisition occurred.
        /// </summary>
        [JsonProperty("purchaseTaxLocalAmount")]
        public int PurchaseTaxLocalAmount { get; set; }

    }
}
