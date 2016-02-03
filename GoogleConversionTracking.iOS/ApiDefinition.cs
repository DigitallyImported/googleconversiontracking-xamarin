using System.Security;

namespace GoogleConversionTracking.iOS
{
    using System;
    using Foundation;

    // @interface ACTReporter : NSObject
    [BaseType (typeof(NSObject))]
    interface ACTReporter
    {
        // +(NSString *)SDKVersion;
        [Static]
        [Export ("SDKVersion")]
        string SDKVersion { get; }

        // -(BOOL)report;
        [Export ("report")]
        bool Report ();
    }

    // @interface ACTConversionReporter : ACTReporter
    [BaseType (typeof(ACTReporter))]
    interface ACTConversionReporter
    {
        // @property (copy, nonatomic) NSString * value;
        [Export ("value")]
        string Value { get; set; }

        // @property (copy, nonatomic) NSString * currencyCode;
        [Export ("currencyCode")]
        string CurrencyCode { get; set; }

        // +(void)reportWithConversionID:(NSString *)conversionID label:(NSString *)label value:(NSString *)value currencyCode:(NSString *)currencyCode isRepeatable:(BOOL)isRepeatable;
        [Static]
        [Export ("reportWithConversionID:label:value:currencyCode:isRepeatable:")]
        void ReportWithConversionID (string conversionID, string label, string value, string currencyCode, bool isRepeatable);

        // +(void)reportWithConversionID:(NSString *)conversionID label:(NSString *)label value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
        [Static]
        [Export ("reportWithConversionID:label:value:isRepeatable:")]
        void ReportWithConversionID (string conversionID, string label, string value, bool isRepeatable);

        // +(void)reportWithProductID:(NSString *)productID value:(NSString *)value currencyCode:(NSString *)currencyCode isRepeatable:(BOOL)isRepeatable;
        [Static]
        [Export ("reportWithProductID:value:currencyCode:isRepeatable:")]
        void ReportWithProductID (string productID, string value, string currencyCode, bool isRepeatable);

        // +(void)reportWithProductID:(NSString *)productID value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
        [Static]
        [Export ("reportWithProductID:value:isRepeatable:")]
        void ReportWithProductID (string productID, string value, bool isRepeatable);

        // +(BOOL)registerReferrer:(NSURL *)clickURL;
        [Static]
        [Export ("registerReferrer:")]
        bool RegisterReferrer (NSUrl clickURL);

        // -(instancetype)initWithConversionID:(NSString *)conversionID label:(NSString *)label value:(NSString *)value currencyCode:(NSString *)currencyCode isRepeatable:(BOOL)isRepeatable;
        [Export ("initWithConversionID:label:value:currencyCode:isRepeatable:")]
        IntPtr Constructor (string conversionID, string label, string value, string currencyCode, bool isRepeatable);

        // -(instancetype)initWithConversionID:(NSString *)conversionID label:(NSString *)label value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
        [Export ("initWithConversionID:label:value:isRepeatable:")]
        IntPtr Constructor (string conversionID, string label, string value, bool isRepeatable);
    }

//    // @interface ACTConversionReporter : ACTReporter
//	[BaseType (typeof(ACTConversionReporter), Name = "ACTConversionReporter")]
//    interface ACTProductConversionReporter
//    {
//        // -(instancetype)initWithProductID:(NSString *)productID value:(NSString *)value currencyCode:(NSString *)currencyCode isRepeatable:(BOOL)isRepeatable;
//        [Export ("initWithProductID:value:currencyCode:isRepeatable:")]
//        IntPtr Constructor (string productID, string value, string currencyCode, bool isRepeatable);
//
//        // -(instancetype)initWithProductID:(NSString *)productID value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
//        [Export ("initWithProductID:value:isRepeatable:")]
//        IntPtr Constructor (string productID, string value, bool isRepeatable);
//    }

    // @interface ACTRemarketingReporter : ACTReporter
    [BaseType (typeof(ACTReporter))]
    interface ACTRemarketingReporter
    {
        // +(void)reportWithConversionID:(NSString *)conversionID customParameters:(NSDictionary *)customParameters;
        [Static]
        [Export ("reportWithConversionID:customParameters:")]
        void ReportWithConversionID (string conversionID, NSDictionary customParameters);

        // -(instancetype)initWithConversionID:(NSString *)conversionID customParameters:(NSDictionary *)customParameters;
        [Export ("initWithConversionID:customParameters:")]
        IntPtr Constructor (string conversionID, NSDictionary customParameters);
    }

    // @interface ACTAutomatedUsageTracker : NSObject
    [BaseType (typeof(NSObject))]
    interface ACTAutomatedUsageTracker
    {
        // +(void)enableAutomatedUsageReportingWithConversionID:(NSString *)conversionID;
        [Static]
        [Export ("enableAutomatedUsageReportingWithConversionID:")]
        void EnableAutomatedUsageReportingWithConversionID (string conversionID);

        // +(void)disableAutomatedUsageReportingWithConversionID:(NSString *)conversionID;
        [Static]
        [Export ("disableAutomatedUsageReportingWithConversionID:")]
        void DisableAutomatedUsageReportingWithConversionID (string conversionID);
    }

    // @interface DCTConversionReporter : ACTReporter
    [BaseType (typeof(ACTReporter))]
    interface DCTConversionReporter
    {
        // @property (copy, nonatomic) NSString * value;
        [Export ("value")]
        string Value { get; set; }

        // @property (copy, nonatomic) NSString * currencyCode;
        [Export ("currencyCode")]
        string CurrencyCode { get; set; }

        // +(void)reportWithConversionID:(NSString *)conversionID value:(NSString *)value currencyCode:(NSString *)currencyCode isRepeatable:(BOOL)isRepeatable;
        [Static]
        [Export ("reportWithConversionID:value:currencyCode:isRepeatable:")]
        void ReportWithConversionID (string conversionID, string value, string currencyCode, bool isRepeatable);

        // +(void)reportWithConversionID:(NSString *)conversionID value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
        [Static]
        [Export ("reportWithConversionID:value:isRepeatable:")]
        void ReportWithConversionID (string conversionID, string value, bool isRepeatable);

        // -(instancetype)initWithConversionID:(NSString *)conversionID value:(NSString *)value currencyCode:(NSString *)currencyCode isRepeatable:(BOOL)isRepeatable;
        [Export ("initWithConversionID:value:currencyCode:isRepeatable:")]
        IntPtr Constructor (string conversionID, string value, string currencyCode, bool isRepeatable);

        // -(instancetype)initWithConversionID:(NSString *)conversionID value:(NSString *)value isRepeatable:(BOOL)isRepeatable;
        [Export ("initWithConversionID:value:isRepeatable:")]
        IntPtr Constructor (string conversionID, string value, bool isRepeatable);
    }

    // @interface DCTActivityReporter : ACTReporter
    [BaseType (typeof(ACTReporter))]
    interface DCTActivityReporter
    {
        // +(void)reportWithAdUnitID:(NSString *)adUnitID publisherProvidedID:(NSString *)publisherProvidedID customParameters:(NSDictionary *)customParameters;
        [Static]
        [Export ("reportWithAdUnitID:publisherProvidedID:customParameters:")]
        void ReportWithAdUnitID (string adUnitID, string publisherProvidedID, NSDictionary customParameters);

        // -(instancetype)initWithAdUnitID:(NSString *)adUnitID publisherProvidedID:(NSString *)publisherProvidedID customParameters:(NSDictionary *)customParameters;
        [Export ("initWithAdUnitID:publisherProvidedID:customParameters:")]
        IntPtr Constructor (string adUnitID, string publisherProvidedID, NSDictionary customParameters);
    }
}

