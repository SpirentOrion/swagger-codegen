/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
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
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Model for testing model name same as property name
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class Name :  IEquatable<Name>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Name" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Name() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Name" /> class.
        /// </summary>
        /// <param name="_Name">_Name (required).</param>
        /// <param name="Property">Property.</param>
        public Name(int? _Name = null, string Property = null)
        {
            // to ensure "_Name" is required (not null)
            if (_Name == null)
            {
                throw new InvalidDataException("_Name is a required property for Name and cannot be null");
            }
            else
            {
                this._Name = _Name;
            }
            this.Property = Property;
        }
        
        /// <summary>
        /// Gets or Sets _Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public int? _Name { get; set; }
        /// <summary>
        /// Gets or Sets SnakeCase
        /// </summary>
        [DataMember(Name="snake_case", EmitDefaultValue=false)]
        public int? SnakeCase { get; private set; }
        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
        /// <summary>
        /// Gets or Sets _123Number
        /// </summary>
        [DataMember(Name="123Number", EmitDefaultValue=false)]
        public int? _123Number { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Name {\n");
            sb.Append("  _Name: ").Append(_Name).Append("\n");
            sb.Append("  SnakeCase: ").Append(SnakeCase).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  _123Number: ").Append(_123Number).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Name);
        }

        /// <summary>
        /// Returns true if Name instances are equal
        /// </summary>
        /// <param name="other">Instance of Name to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Name other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Name == other._Name ||
                    this._Name != null &&
                    this._Name.Equals(other._Name)
                ) && 
                (
                    this.SnakeCase == other.SnakeCase ||
                    this.SnakeCase != null &&
                    this.SnakeCase.Equals(other.SnakeCase)
                ) && 
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) && 
                (
                    this._123Number == other._123Number ||
                    this._123Number != null &&
                    this._123Number.Equals(other._123Number)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this._Name != null)
                    hash = hash * 59 + this._Name.GetHashCode();
                if (this.SnakeCase != null)
                    hash = hash * 59 + this.SnakeCase.GetHashCode();
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                if (this._123Number != null)
                    hash = hash * 59 + this._123Number.GetHashCode();
                return hash;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
