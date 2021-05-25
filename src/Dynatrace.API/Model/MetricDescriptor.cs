/* 
 * Dynatrace Environment API
 *
 *  Documentation of the Dynatrace Environment API v2. Resources here generally supersede those in v1. Migration of resources from v1 is in progress.   If you miss a resource, consider using the Dynatrace Environment API v1. To read about use cases and examples, refer to the [help page](https://dt-url.net/2u23k1k) .  Notes about compatibility: * Operations marked as early adopter or preview may be changed in non-compatible ways, although we try to avoid this. * We may add new enum constants without incrementing the API version; thus, clients need to handle unknown enum constants gracefully.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Dynatrace.API.Client.SwaggerDateConverter;

namespace Dynatrace.API.Model
{
    /// <summary>
    /// The descriptor of a metric.
    /// </summary>
    [DataContract]
        public partial class MetricDescriptor :  IEquatable<MetricDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Defines AggregationTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AggregationTypesEnum
        {
            /// <summary>
            /// Enum Auto for value: auto
            /// </summary>
            [EnumMember(Value = "auto")]
            Auto = 1,
            /// <summary>
            /// Enum Avg for value: avg
            /// </summary>
            [EnumMember(Value = "avg")]
            Avg = 2,
            /// <summary>
            /// Enum Count for value: count
            /// </summary>
            [EnumMember(Value = "count")]
            Count = 3,
            /// <summary>
            /// Enum Max for value: max
            /// </summary>
            [EnumMember(Value = "max")]
            Max = 4,
            /// <summary>
            /// Enum Median for value: median
            /// </summary>
            [EnumMember(Value = "median")]
            Median = 5,
            /// <summary>
            /// Enum Min for value: min
            /// </summary>
            [EnumMember(Value = "min")]
            Min = 6,
            /// <summary>
            /// Enum Percentile for value: percentile
            /// </summary>
            [EnumMember(Value = "percentile")]
            Percentile = 7,
            /// <summary>
            /// Enum Sum for value: sum
            /// </summary>
            [EnumMember(Value = "sum")]
            Sum = 8,
            /// <summary>
            /// Enum Value for value: value
            /// </summary>
            [EnumMember(Value = "value")]
            Value = 9        }
        /// <summary>
        /// The list of allowed aggregations for this metric.
        /// </summary>
        /// <value>The list of allowed aggregations for this metric.</value>
        [DataMember(Name="aggregationTypes", EmitDefaultValue=false)]
        public List<AggregationTypesEnum> AggregationTypes { get; set; }
        /// <summary>
        /// Defines Transformations
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TransformationsEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,
            /// <summary>
            /// Enum Filter for value: filter
            /// </summary>
            [EnumMember(Value = "filter")]
            Filter = 2,
            /// <summary>
            /// Enum Fold for value: fold
            /// </summary>
            [EnumMember(Value = "fold")]
            Fold = 3,
            /// <summary>
            /// Enum Last for value: last
            /// </summary>
            [EnumMember(Value = "last")]
            Last = 4,
            /// <summary>
            /// Enum Limit for value: limit
            /// </summary>
            [EnumMember(Value = "limit")]
            Limit = 5,
            /// <summary>
            /// Enum Merge for value: merge
            /// </summary>
            [EnumMember(Value = "merge")]
            Merge = 6,
            /// <summary>
            /// Enum Names for value: names
            /// </summary>
            [EnumMember(Value = "names")]
            Names = 7,
            /// <summary>
            /// Enum Parents for value: parents
            /// </summary>
            [EnumMember(Value = "parents")]
            Parents = 8,
            /// <summary>
            /// Enum Rate for value: rate
            /// </summary>
            [EnumMember(Value = "rate")]
            Rate = 9,
            /// <summary>
            /// Enum Sort for value: sort
            /// </summary>
            [EnumMember(Value = "sort")]
            Sort = 10,
            /// <summary>
            /// Enum SplitBy for value: splitBy
            /// </summary>
            [EnumMember(Value = "splitBy")]
            SplitBy = 11,
            /// <summary>
            /// Enum Timeshift for value: timeshift
            /// </summary>
            [EnumMember(Value = "timeshift")]
            Timeshift = 12        }
        /// <summary>
        /// Transform operators that could be appended to the current transformation list. Must be enabled with the \&quot;fields\&quot; parameter on &#x60;/metrics&#x60; and is always present on &#x60;/metrics/{metricId}&#x60;.
        /// </summary>
        /// <value>Transform operators that could be appended to the current transformation list. Must be enabled with the \&quot;fields\&quot; parameter on &#x60;/metrics&#x60; and is always present on &#x60;/metrics/{metricId}&#x60;.</value>
        [DataMember(Name="transformations", EmitDefaultValue=false)]
        public List<TransformationsEnum> Transformations { get; set; }
        /// <summary>
        /// The unit of the metric.
        /// </summary>
        /// <value>The unit of the metric.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UnitEnum
        {
            /// <summary>
            /// Enum Bit for value: Bit
            /// </summary>
            [EnumMember(Value = "Bit")]
            Bit = 1,
            /// <summary>
            /// Enum BitPerHour for value: BitPerHour
            /// </summary>
            [EnumMember(Value = "BitPerHour")]
            BitPerHour = 2,
            /// <summary>
            /// Enum BitPerMinute for value: BitPerMinute
            /// </summary>
            [EnumMember(Value = "BitPerMinute")]
            BitPerMinute = 3,
            /// <summary>
            /// Enum BitPerSecond for value: BitPerSecond
            /// </summary>
            [EnumMember(Value = "BitPerSecond")]
            BitPerSecond = 4,
            /// <summary>
            /// Enum Byte for value: Byte
            /// </summary>
            [EnumMember(Value = "Byte")]
            Byte = 5,
            /// <summary>
            /// Enum BytePerHour for value: BytePerHour
            /// </summary>
            [EnumMember(Value = "BytePerHour")]
            BytePerHour = 6,
            /// <summary>
            /// Enum BytePerMinute for value: BytePerMinute
            /// </summary>
            [EnumMember(Value = "BytePerMinute")]
            BytePerMinute = 7,
            /// <summary>
            /// Enum BytePerSecond for value: BytePerSecond
            /// </summary>
            [EnumMember(Value = "BytePerSecond")]
            BytePerSecond = 8,
            /// <summary>
            /// Enum Cores for value: Cores
            /// </summary>
            [EnumMember(Value = "Cores")]
            Cores = 9,
            /// <summary>
            /// Enum Count for value: Count
            /// </summary>
            [EnumMember(Value = "Count")]
            Count = 10,
            /// <summary>
            /// Enum Day for value: Day
            /// </summary>
            [EnumMember(Value = "Day")]
            Day = 11,
            /// <summary>
            /// Enum DecibelMilliWatt for value: DecibelMilliWatt
            /// </summary>
            [EnumMember(Value = "DecibelMilliWatt")]
            DecibelMilliWatt = 12,
            /// <summary>
            /// Enum GibiByte for value: GibiByte
            /// </summary>
            [EnumMember(Value = "GibiByte")]
            GibiByte = 13,
            /// <summary>
            /// Enum Giga for value: Giga
            /// </summary>
            [EnumMember(Value = "Giga")]
            Giga = 14,
            /// <summary>
            /// Enum GigaByte for value: GigaByte
            /// </summary>
            [EnumMember(Value = "GigaByte")]
            GigaByte = 15,
            /// <summary>
            /// Enum Hour for value: Hour
            /// </summary>
            [EnumMember(Value = "Hour")]
            Hour = 16,
            /// <summary>
            /// Enum KibiByte for value: KibiByte
            /// </summary>
            [EnumMember(Value = "KibiByte")]
            KibiByte = 17,
            /// <summary>
            /// Enum KibiBytePerHour for value: KibiBytePerHour
            /// </summary>
            [EnumMember(Value = "KibiBytePerHour")]
            KibiBytePerHour = 18,
            /// <summary>
            /// Enum KibiBytePerMinute for value: KibiBytePerMinute
            /// </summary>
            [EnumMember(Value = "KibiBytePerMinute")]
            KibiBytePerMinute = 19,
            /// <summary>
            /// Enum KibiBytePerSecond for value: KibiBytePerSecond
            /// </summary>
            [EnumMember(Value = "KibiBytePerSecond")]
            KibiBytePerSecond = 20,
            /// <summary>
            /// Enum Kilo for value: Kilo
            /// </summary>
            [EnumMember(Value = "Kilo")]
            Kilo = 21,
            /// <summary>
            /// Enum KiloByte for value: KiloByte
            /// </summary>
            [EnumMember(Value = "KiloByte")]
            KiloByte = 22,
            /// <summary>
            /// Enum KiloBytePerHour for value: KiloBytePerHour
            /// </summary>
            [EnumMember(Value = "KiloBytePerHour")]
            KiloBytePerHour = 23,
            /// <summary>
            /// Enum KiloBytePerMinute for value: KiloBytePerMinute
            /// </summary>
            [EnumMember(Value = "KiloBytePerMinute")]
            KiloBytePerMinute = 24,
            /// <summary>
            /// Enum KiloBytePerSecond for value: KiloBytePerSecond
            /// </summary>
            [EnumMember(Value = "KiloBytePerSecond")]
            KiloBytePerSecond = 25,
            /// <summary>
            /// Enum MSU for value: MSU
            /// </summary>
            [EnumMember(Value = "MSU")]
            MSU = 26,
            /// <summary>
            /// Enum MebiByte for value: MebiByte
            /// </summary>
            [EnumMember(Value = "MebiByte")]
            MebiByte = 27,
            /// <summary>
            /// Enum MebiBytePerHour for value: MebiBytePerHour
            /// </summary>
            [EnumMember(Value = "MebiBytePerHour")]
            MebiBytePerHour = 28,
            /// <summary>
            /// Enum MebiBytePerMinute for value: MebiBytePerMinute
            /// </summary>
            [EnumMember(Value = "MebiBytePerMinute")]
            MebiBytePerMinute = 29,
            /// <summary>
            /// Enum MebiBytePerSecond for value: MebiBytePerSecond
            /// </summary>
            [EnumMember(Value = "MebiBytePerSecond")]
            MebiBytePerSecond = 30,
            /// <summary>
            /// Enum Mega for value: Mega
            /// </summary>
            [EnumMember(Value = "Mega")]
            Mega = 31,
            /// <summary>
            /// Enum MegaByte for value: MegaByte
            /// </summary>
            [EnumMember(Value = "MegaByte")]
            MegaByte = 32,
            /// <summary>
            /// Enum MegaBytePerHour for value: MegaBytePerHour
            /// </summary>
            [EnumMember(Value = "MegaBytePerHour")]
            MegaBytePerHour = 33,
            /// <summary>
            /// Enum MegaBytePerMinute for value: MegaBytePerMinute
            /// </summary>
            [EnumMember(Value = "MegaBytePerMinute")]
            MegaBytePerMinute = 34,
            /// <summary>
            /// Enum MegaBytePerSecond for value: MegaBytePerSecond
            /// </summary>
            [EnumMember(Value = "MegaBytePerSecond")]
            MegaBytePerSecond = 35,
            /// <summary>
            /// Enum MicroSecond for value: MicroSecond
            /// </summary>
            [EnumMember(Value = "MicroSecond")]
            MicroSecond = 36,
            /// <summary>
            /// Enum MilliCores for value: MilliCores
            /// </summary>
            [EnumMember(Value = "MilliCores")]
            MilliCores = 37,
            /// <summary>
            /// Enum MilliSecond for value: MilliSecond
            /// </summary>
            [EnumMember(Value = "MilliSecond")]
            MilliSecond = 38,
            /// <summary>
            /// Enum MilliSecondPerMinute for value: MilliSecondPerMinute
            /// </summary>
            [EnumMember(Value = "MilliSecondPerMinute")]
            MilliSecondPerMinute = 39,
            /// <summary>
            /// Enum Minute for value: Minute
            /// </summary>
            [EnumMember(Value = "Minute")]
            Minute = 40,
            /// <summary>
            /// Enum Month for value: Month
            /// </summary>
            [EnumMember(Value = "Month")]
            Month = 41,
            /// <summary>
            /// Enum NanoSecond for value: NanoSecond
            /// </summary>
            [EnumMember(Value = "NanoSecond")]
            NanoSecond = 42,
            /// <summary>
            /// Enum NanoSecondPerMinute for value: NanoSecondPerMinute
            /// </summary>
            [EnumMember(Value = "NanoSecondPerMinute")]
            NanoSecondPerMinute = 43,
            /// <summary>
            /// Enum NotApplicable for value: NotApplicable
            /// </summary>
            [EnumMember(Value = "NotApplicable")]
            NotApplicable = 44,
            /// <summary>
            /// Enum PerHour for value: PerHour
            /// </summary>
            [EnumMember(Value = "PerHour")]
            PerHour = 45,
            /// <summary>
            /// Enum PerMinute for value: PerMinute
            /// </summary>
            [EnumMember(Value = "PerMinute")]
            PerMinute = 46,
            /// <summary>
            /// Enum PerSecond for value: PerSecond
            /// </summary>
            [EnumMember(Value = "PerSecond")]
            PerSecond = 47,
            /// <summary>
            /// Enum Percent for value: Percent
            /// </summary>
            [EnumMember(Value = "Percent")]
            Percent = 48,
            /// <summary>
            /// Enum Pixel for value: Pixel
            /// </summary>
            [EnumMember(Value = "Pixel")]
            Pixel = 49,
            /// <summary>
            /// Enum Promille for value: Promille
            /// </summary>
            [EnumMember(Value = "Promille")]
            Promille = 50,
            /// <summary>
            /// Enum Ratio for value: Ratio
            /// </summary>
            [EnumMember(Value = "Ratio")]
            Ratio = 51,
            /// <summary>
            /// Enum Second for value: Second
            /// </summary>
            [EnumMember(Value = "Second")]
            Second = 52,
            /// <summary>
            /// Enum State for value: State
            /// </summary>
            [EnumMember(Value = "State")]
            State = 53,
            /// <summary>
            /// Enum Unspecified for value: Unspecified
            /// </summary>
            [EnumMember(Value = "Unspecified")]
            Unspecified = 54,
            /// <summary>
            /// Enum Week for value: Week
            /// </summary>
            [EnumMember(Value = "Week")]
            Week = 55,
            /// <summary>
            /// Enum Year for value: Year
            /// </summary>
            [EnumMember(Value = "Year")]
            Year = 56        }
        /// <summary>
        /// The unit of the metric.
        /// </summary>
        /// <value>The unit of the metric.</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public UnitEnum? Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDescriptor" /> class.
        /// </summary>
        /// <param name="dduBillable">If &#x60;true&#x60; the usage of metric consumes [Davis data units](https://dt-url.net/ddu).    Metric expressions don&#x27;t return this field..</param>
        /// <param name="defaultAggregation">defaultAggregation.</param>
        /// <param name="impactRelevant">The metric is (&#x60;true&#x60;) or is not (&#x60;false&#x60;) impact relevant.   Metric expressions don&#x27;t return this field..</param>
        /// <param name="dimensionDefinitions">The fine metric division (for example, process group and process ID for some process-related metric)..</param>
        /// <param name="rootCauseRelevant">The metric is (&#x60;true&#x60;) or is not (&#x60;false&#x60;) root cause relevant.   Metric expressions don&#x27;t return this field..</param>
        /// <param name="minimumValue">The minimum value of the metric.   Metric expressions don&#x27;t return this field..</param>
        /// <param name="maximumValue">The maximum value of the metric.   Metric expressions don&#x27;t return this field..</param>
        /// <param name="lastWritten">The timestamp when the metric was last written.   Has the value of &#x60;null&#x60; for metric expressions or if the data has never been written..</param>
        /// <param name="metricValueType">metricValueType.</param>
        /// <param name="entityType">List of admissible primary entity types for this metric. Can be used for the &#x60;type&#x60; predicate in the &#x60;entitySelector&#x60;..</param>
        /// <param name="metricId">The fully qualified key of the metric.   If a transformation has been used it is reflected in the metric key. (required).</param>
        /// <param name="aggregationTypes">The list of allowed aggregations for this metric..</param>
        /// <param name="warnings">A list of potential warnings that affect this ID. For example deprecated feature usage etc..</param>
        /// <param name="tags">The tags applied to the metric.    Metric expressions don&#x27;t return this field..</param>
        /// <param name="description">A short description of the metric..</param>
        /// <param name="transformations">Transform operators that could be appended to the current transformation list. Must be enabled with the \&quot;fields\&quot; parameter on &#x60;/metrics&#x60; and is always present on &#x60;/metrics/{metricId}&#x60;..</param>
        /// <param name="unit">The unit of the metric..</param>
        /// <param name="created">The timestamp of metric creation.   Built-in metrics and metric expressions have the value of &#x60;null&#x60;..</param>
        /// <param name="displayName">The name of the metric in the user interface..</param>
        public MetricDescriptor(bool? dduBillable = default(bool?), MetricDefaultAggregation defaultAggregation = default(MetricDefaultAggregation), bool? impactRelevant = default(bool?), List<MetricDimensionDefinition> dimensionDefinitions = default(List<MetricDimensionDefinition>), bool? rootCauseRelevant = default(bool?), double? minimumValue = default(double?), double? maximumValue = default(double?), long? lastWritten = default(long?), MetricValueType metricValueType = default(MetricValueType), List<string> entityType = default(List<string>), string metricId = default(string), List<AggregationTypesEnum> aggregationTypes = default(List<AggregationTypesEnum>), List<string> warnings = default(List<string>), List<string> tags = default(List<string>), string description = default(string), List<TransformationsEnum> transformations = default(List<TransformationsEnum>), UnitEnum? unit = default(UnitEnum?), long? created = default(long?), string displayName = default(string))
        {
            // to ensure "metricId" is required (not null)
            if (metricId == null)
            {
                throw new InvalidDataException("metricId is a required property for MetricDescriptor and cannot be null");
            }
            else
            {
                this.MetricId = metricId;
            }
            this.DduBillable = dduBillable;
            this.DefaultAggregation = defaultAggregation;
            this.ImpactRelevant = impactRelevant;
            this.DimensionDefinitions = dimensionDefinitions;
            this.RootCauseRelevant = rootCauseRelevant;
            this.MinimumValue = minimumValue;
            this.MaximumValue = maximumValue;
            this.LastWritten = lastWritten;
            this.MetricValueType = metricValueType;
            this.EntityType = entityType;
            this.AggregationTypes = aggregationTypes;
            this.Warnings = warnings;
            this.Tags = tags;
            this.Description = description;
            this.Transformations = transformations;
            this.Unit = unit;
            this.Created = created;
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// If &#x60;true&#x60; the usage of metric consumes [Davis data units](https://dt-url.net/ddu).    Metric expressions don&#x27;t return this field.
        /// </summary>
        /// <value>If &#x60;true&#x60; the usage of metric consumes [Davis data units](https://dt-url.net/ddu).    Metric expressions don&#x27;t return this field.</value>
        [DataMember(Name="dduBillable", EmitDefaultValue=false)]
        public bool? DduBillable { get; set; }

        /// <summary>
        /// Gets or Sets DefaultAggregation
        /// </summary>
        [DataMember(Name="defaultAggregation", EmitDefaultValue=false)]
        public MetricDefaultAggregation DefaultAggregation { get; set; }

        /// <summary>
        /// The metric is (&#x60;true&#x60;) or is not (&#x60;false&#x60;) impact relevant.   Metric expressions don&#x27;t return this field.
        /// </summary>
        /// <value>The metric is (&#x60;true&#x60;) or is not (&#x60;false&#x60;) impact relevant.   Metric expressions don&#x27;t return this field.</value>
        [DataMember(Name="impactRelevant", EmitDefaultValue=false)]
        public bool? ImpactRelevant { get; set; }

        /// <summary>
        /// The fine metric division (for example, process group and process ID for some process-related metric).
        /// </summary>
        /// <value>The fine metric division (for example, process group and process ID for some process-related metric).</value>
        [DataMember(Name="dimensionDefinitions", EmitDefaultValue=false)]
        public List<MetricDimensionDefinition> DimensionDefinitions { get; set; }

        /// <summary>
        /// The metric is (&#x60;true&#x60;) or is not (&#x60;false&#x60;) root cause relevant.   Metric expressions don&#x27;t return this field.
        /// </summary>
        /// <value>The metric is (&#x60;true&#x60;) or is not (&#x60;false&#x60;) root cause relevant.   Metric expressions don&#x27;t return this field.</value>
        [DataMember(Name="rootCauseRelevant", EmitDefaultValue=false)]
        public bool? RootCauseRelevant { get; set; }

        /// <summary>
        /// The minimum value of the metric.   Metric expressions don&#x27;t return this field.
        /// </summary>
        /// <value>The minimum value of the metric.   Metric expressions don&#x27;t return this field.</value>
        [DataMember(Name="minimumValue", EmitDefaultValue=false)]
        public double? MinimumValue { get; set; }

        /// <summary>
        /// The maximum value of the metric.   Metric expressions don&#x27;t return this field.
        /// </summary>
        /// <value>The maximum value of the metric.   Metric expressions don&#x27;t return this field.</value>
        [DataMember(Name="maximumValue", EmitDefaultValue=false)]
        public double? MaximumValue { get; set; }

        /// <summary>
        /// The timestamp when the metric was last written.   Has the value of &#x60;null&#x60; for metric expressions or if the data has never been written.
        /// </summary>
        /// <value>The timestamp when the metric was last written.   Has the value of &#x60;null&#x60; for metric expressions or if the data has never been written.</value>
        [DataMember(Name="lastWritten", EmitDefaultValue=false)]
        public long? LastWritten { get; set; }

        /// <summary>
        /// Gets or Sets MetricValueType
        /// </summary>
        [DataMember(Name="metricValueType", EmitDefaultValue=false)]
        public MetricValueType MetricValueType { get; set; }

        /// <summary>
        /// List of admissible primary entity types for this metric. Can be used for the &#x60;type&#x60; predicate in the &#x60;entitySelector&#x60;.
        /// </summary>
        /// <value>List of admissible primary entity types for this metric. Can be used for the &#x60;type&#x60; predicate in the &#x60;entitySelector&#x60;.</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public List<string> EntityType { get; set; }

        /// <summary>
        /// The fully qualified key of the metric.   If a transformation has been used it is reflected in the metric key.
        /// </summary>
        /// <value>The fully qualified key of the metric.   If a transformation has been used it is reflected in the metric key.</value>
        [DataMember(Name="metricId", EmitDefaultValue=false)]
        public string MetricId { get; set; }


        /// <summary>
        /// A list of potential warnings that affect this ID. For example deprecated feature usage etc.
        /// </summary>
        /// <value>A list of potential warnings that affect this ID. For example deprecated feature usage etc.</value>
        [DataMember(Name="warnings", EmitDefaultValue=false)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// The tags applied to the metric.    Metric expressions don&#x27;t return this field.
        /// </summary>
        /// <value>The tags applied to the metric.    Metric expressions don&#x27;t return this field.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// A short description of the metric.
        /// </summary>
        /// <value>A short description of the metric.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The timestamp of metric creation.   Built-in metrics and metric expressions have the value of &#x60;null&#x60;.
        /// </summary>
        /// <value>The timestamp of metric creation.   Built-in metrics and metric expressions have the value of &#x60;null&#x60;.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public long? Created { get; set; }

        /// <summary>
        /// The name of the metric in the user interface.
        /// </summary>
        /// <value>The name of the metric in the user interface.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricDescriptor {\n");
            sb.Append("  DduBillable: ").Append(DduBillable).Append("\n");
            sb.Append("  DefaultAggregation: ").Append(DefaultAggregation).Append("\n");
            sb.Append("  ImpactRelevant: ").Append(ImpactRelevant).Append("\n");
            sb.Append("  DimensionDefinitions: ").Append(DimensionDefinitions).Append("\n");
            sb.Append("  RootCauseRelevant: ").Append(RootCauseRelevant).Append("\n");
            sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
            sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
            sb.Append("  LastWritten: ").Append(LastWritten).Append("\n");
            sb.Append("  MetricValueType: ").Append(MetricValueType).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  MetricId: ").Append(MetricId).Append("\n");
            sb.Append("  AggregationTypes: ").Append(AggregationTypes).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Transformations: ").Append(Transformations).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricDescriptor);
        }

        /// <summary>
        /// Returns true if MetricDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DduBillable == input.DduBillable ||
                    (this.DduBillable != null &&
                    this.DduBillable.Equals(input.DduBillable))
                ) && 
                (
                    this.DefaultAggregation == input.DefaultAggregation ||
                    (this.DefaultAggregation != null &&
                    this.DefaultAggregation.Equals(input.DefaultAggregation))
                ) && 
                (
                    this.ImpactRelevant == input.ImpactRelevant ||
                    (this.ImpactRelevant != null &&
                    this.ImpactRelevant.Equals(input.ImpactRelevant))
                ) && 
                (
                    this.DimensionDefinitions == input.DimensionDefinitions ||
                    this.DimensionDefinitions != null &&
                    input.DimensionDefinitions != null &&
                    this.DimensionDefinitions.SequenceEqual(input.DimensionDefinitions)
                ) && 
                (
                    this.RootCauseRelevant == input.RootCauseRelevant ||
                    (this.RootCauseRelevant != null &&
                    this.RootCauseRelevant.Equals(input.RootCauseRelevant))
                ) && 
                (
                    this.MinimumValue == input.MinimumValue ||
                    (this.MinimumValue != null &&
                    this.MinimumValue.Equals(input.MinimumValue))
                ) && 
                (
                    this.MaximumValue == input.MaximumValue ||
                    (this.MaximumValue != null &&
                    this.MaximumValue.Equals(input.MaximumValue))
                ) && 
                (
                    this.LastWritten == input.LastWritten ||
                    (this.LastWritten != null &&
                    this.LastWritten.Equals(input.LastWritten))
                ) && 
                (
                    this.MetricValueType == input.MetricValueType ||
                    (this.MetricValueType != null &&
                    this.MetricValueType.Equals(input.MetricValueType))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    this.EntityType != null &&
                    input.EntityType != null &&
                    this.EntityType.SequenceEqual(input.EntityType)
                ) && 
                (
                    this.MetricId == input.MetricId ||
                    (this.MetricId != null &&
                    this.MetricId.Equals(input.MetricId))
                ) && 
                (
                    this.AggregationTypes == input.AggregationTypes ||
                    this.AggregationTypes != null &&
                    input.AggregationTypes != null &&
                    this.AggregationTypes.SequenceEqual(input.AggregationTypes)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Transformations == input.Transformations ||
                    this.Transformations != null &&
                    input.Transformations != null &&
                    this.Transformations.SequenceEqual(input.Transformations)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DduBillable != null)
                    hashCode = hashCode * 59 + this.DduBillable.GetHashCode();
                if (this.DefaultAggregation != null)
                    hashCode = hashCode * 59 + this.DefaultAggregation.GetHashCode();
                if (this.ImpactRelevant != null)
                    hashCode = hashCode * 59 + this.ImpactRelevant.GetHashCode();
                if (this.DimensionDefinitions != null)
                    hashCode = hashCode * 59 + this.DimensionDefinitions.GetHashCode();
                if (this.RootCauseRelevant != null)
                    hashCode = hashCode * 59 + this.RootCauseRelevant.GetHashCode();
                if (this.MinimumValue != null)
                    hashCode = hashCode * 59 + this.MinimumValue.GetHashCode();
                if (this.MaximumValue != null)
                    hashCode = hashCode * 59 + this.MaximumValue.GetHashCode();
                if (this.LastWritten != null)
                    hashCode = hashCode * 59 + this.LastWritten.GetHashCode();
                if (this.MetricValueType != null)
                    hashCode = hashCode * 59 + this.MetricValueType.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.MetricId != null)
                    hashCode = hashCode * 59 + this.MetricId.GetHashCode();
                if (this.AggregationTypes != null)
                    hashCode = hashCode * 59 + this.AggregationTypes.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Transformations != null)
                    hashCode = hashCode * 59 + this.Transformations.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
