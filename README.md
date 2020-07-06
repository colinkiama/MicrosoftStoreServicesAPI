# MicrosoftStoreServices
You can easily query the Microsoft Store Services API in C# with this package.
It provides an easy and strongly-typed way to interact with data about your Microsoft Store products.

Data you can get from this SDK are :
- App acquisitions
- A list of your published applications
- Error reporting data
- IAP acquisitions
- Ratings
- Reviews

It still is an early release.
If you encounter any bugs, please report it or feel free to participate on this repository.

Prerequisites
-------
Microsoft Store Serivces API will require you to setup properly your Partner Center account with your Azure AD to authenticate you, otherwise you won't be allow to query for data.

All the prerequisites required are explained here: in "Complete prerequisites for using the Microsoft Store analytics API : https://msdn.microsoft.com/en-us/windows/uwp/monetize/access-analytics-data-using-windows-store-services
Important Tip: To make things easy, use the Azure Portal to create a new Azure AD app registration. You can then add the application to the "Users" page of your Partner Center Account Settings.

How to install it
-------
Package will be made when it's ready...


How to get an OAuth token
-------
Once all the prerequisites have been done, you will need to get an authentication token for your Azure AD application before querying the API.

Here's how to do it :
```csharp
var oauthClient = new MicrosoftStoreServicesAPI.OAuth.OAuthClient();
var token = await oauthClient.GetTokenAsync("{YOUR-AZURE-AD-TENANT-ID}",
                                            "{YOUR-AZURE-AD-APPLICATION-CLIENT-ID}",
                                            "{YOUR-AZURE-AD-APPLICATION-SECRETKEY}");
```


How to get analytics data
-------
```csharp
var analyticsContext = new AnalyticsContext(token);

// Retrieve all the apps published by your Dev Center account
var apps = await analyticsContext.Applications().GetResultsAsync();

// Retrieve reviews for an app
var reviews = await analyticsContext.Reviews(apps.First().ApplicationId)
                                    .Between(new DateTime(2016, 1, 1), DateTime.Now)
                                    .OrderBy(ReviewsOrderBy.OsVersion)
                                    .ThenOrderBy(ReviewsOrderBy.Rating, OrderByDirections.Descending)
                                    .Take(5)
                                    .GetResultsAsync();
```
