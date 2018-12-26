// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MediaJobRetry.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MediaJobRetry
    {
        /// <summary>
        /// Issue needs to be investigated and then the job resubmitted with
        /// corrections or retried once the underlying issue has been
        /// corrected.
        /// </summary>
        [EnumMember(Value = "DoNotRetry")]
        DoNotRetry,
        /// <summary>
        /// Issue may be resolved after waiting for a period of time and
        /// resubmitting the same Job.
        /// </summary>
        [EnumMember(Value = "MayRetry")]
        MayRetry
    }
    internal static class MediaJobRetryEnumExtension
    {
        internal static string ToSerializedValue(this MediaJobRetry? value)
        {
            return value == null ? null : ((MediaJobRetry)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MediaJobRetry value)
        {
            switch( value )
            {
                case MediaJobRetry.DoNotRetry:
                    return "DoNotRetry";
                case MediaJobRetry.MayRetry:
                    return "MayRetry";
            }
            return null;
        }

        internal static MediaJobRetry? ParseMediaJobRetry(this string value)
        {
            switch( value )
            {
                case "DoNotRetry":
                    return MediaJobRetry.DoNotRetry;
                case "MayRetry":
                    return MediaJobRetry.MayRetry;
            }
            return null;
        }
    }
}