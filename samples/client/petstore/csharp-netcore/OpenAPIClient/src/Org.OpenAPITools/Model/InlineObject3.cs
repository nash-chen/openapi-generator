/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// InlineObject3
    /// </summary>
    [DataContract(Name = "inline_object_3")]
    public partial class InlineObject3 : IEquatable<InlineObject3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject3" /> class.
        /// </summary>
        /// <param name="integer">None.</param>
        /// <param name="int32">None.</param>
        /// <param name="int64">None.</param>
        /// <param name="number">None (required).</param>
        /// <param name="_float">None.</param>
        /// <param name="_double">None (required).</param>
        /// <param name="_string">None.</param>
        /// <param name="patternWithoutDelimiter">None (required).</param>
        /// <param name="_byte">None (required).</param>
        /// <param name="binary">None.</param>
        /// <param name="date">None.</param>
        /// <param name="dateTime">None.</param>
        /// <param name="password">None.</param>
        /// <param name="callback">None.</param>
        public InlineObject3(int integer = default(int), int int32 = default(int), long int64 = default(long), decimal number = default(decimal), float _float = default(float), double _double = default(double), string _string = default(string), string patternWithoutDelimiter = default(string), byte[] _byte = default(byte[]), System.IO.Stream binary = default(System.IO.Stream), DateTime date = default(DateTime), DateTime dateTime = default(DateTime), string password = default(string), string callback = default(string))
        {
            this.Number = number;
            this.Double = _double;
            // to ensure "patternWithoutDelimiter" is required (not null)
            this.PatternWithoutDelimiter = patternWithoutDelimiter ?? throw new ArgumentNullException("patternWithoutDelimiter is a required property for InlineObject3 and cannot be null");
            // to ensure "_byte" is required (not null)
            this.Byte = _byte ?? throw new ArgumentNullException("_byte is a required property for InlineObject3 and cannot be null");
            this.Integer = integer;
            this.Int32 = int32;
            this.Int64 = int64;
            this.Float = _float;
            this.String = _string;
            this.Binary = binary;
            this.Date = date;
            this.DateTime = dateTime;
            this.Password = password;
            this.Callback = callback;
        }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "integer", EmitDefaultValue = false)]
        public int Integer { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "int32", EmitDefaultValue = false)]
        public int Int32 { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "int64", EmitDefaultValue = false)]
        public long Int64 { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public decimal Number { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "float", EmitDefaultValue = false)]
        public float Float { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "double", EmitDefaultValue = false)]
        public double Double { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "string", EmitDefaultValue = false)]
        public string String { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "pattern_without_delimiter", EmitDefaultValue = false)]
        public string PatternWithoutDelimiter { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "byte", EmitDefaultValue = false)]
        public byte[] Byte { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "binary", EmitDefaultValue = false)]
        public System.IO.Stream Binary { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "dateTime", EmitDefaultValue = false)]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [DataMember(Name = "callback", EmitDefaultValue = false)]
        public string Callback { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject3 {\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  PatternWithoutDelimiter: ").Append(PatternWithoutDelimiter).Append("\n");
            sb.Append("  Byte: ").Append(Byte).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Callback: ").Append(Callback).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as InlineObject3).AreEqual;
        }

        /// <summary>
        /// Returns true if InlineObject3 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject3 input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = hashCode * 59 + this.Integer.GetHashCode();
                hashCode = hashCode * 59 + this.Int32.GetHashCode();
                hashCode = hashCode * 59 + this.Int64.GetHashCode();
                hashCode = hashCode * 59 + this.Number.GetHashCode();
                hashCode = hashCode * 59 + this.Float.GetHashCode();
                hashCode = hashCode * 59 + this.Double.GetHashCode();
                if (this.String != null)
                    hashCode = hashCode * 59 + this.String.GetHashCode();
                if (this.PatternWithoutDelimiter != null)
                    hashCode = hashCode * 59 + this.PatternWithoutDelimiter.GetHashCode();
                if (this.Byte != null)
                    hashCode = hashCode * 59 + this.Byte.GetHashCode();
                if (this.Binary != null)
                    hashCode = hashCode * 59 + this.Binary.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Callback != null)
                    hashCode = hashCode * 59 + this.Callback.GetHashCode();
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
            // Integer (int) maximum
            if(this.Integer > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value less than or equal to 100.", new [] { "Integer" });
            }

            // Integer (int) minimum
            if(this.Integer < (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value greater than or equal to 10.", new [] { "Integer" });
            }

            // Int32 (int) maximum
            if(this.Int32 > (int)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value less than or equal to 200.", new [] { "Int32" });
            }

            // Int32 (int) minimum
            if(this.Int32 < (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value greater than or equal to 20.", new [] { "Int32" });
            }

            // Number (decimal) maximum
            if(this.Number > (decimal)543.2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value less than or equal to 543.2.", new [] { "Number" });
            }

            // Number (decimal) minimum
            if(this.Number < (decimal)32.1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value greater than or equal to 32.1.", new [] { "Number" });
            }

            // Float (float) maximum
            if(this.Float > (float)987.6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Float, must be a value less than or equal to 987.6.", new [] { "Float" });
            }

            // Double (double) maximum
            if(this.Double > (double)123.4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Double, must be a value less than or equal to 123.4.", new [] { "Double" });
            }

            // Double (double) minimum
            if(this.Double < (double)67.8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Double, must be a value greater than or equal to 67.8.", new [] { "Double" });
            }

            // String (string) pattern
            Regex regexString = new Regex(@"[a-z]", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            if (false == regexString.Match(this.String).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for String, must match a pattern of " + regexString, new [] { "String" });
            }

            // PatternWithoutDelimiter (string) pattern
            Regex regexPatternWithoutDelimiter = new Regex(@"^[A-Z].*", RegexOptions.CultureInvariant);
            if (false == regexPatternWithoutDelimiter.Match(this.PatternWithoutDelimiter).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithoutDelimiter, must match a pattern of " + regexPatternWithoutDelimiter, new [] { "PatternWithoutDelimiter" });
            }

            // Password (string) maxLength
            if(this.Password != null && this.Password.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 64.", new [] { "Password" });
            }

            // Password (string) minLength
            if(this.Password != null && this.Password.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 10.", new [] { "Password" });
            }

            yield break;
        }
    }

}
