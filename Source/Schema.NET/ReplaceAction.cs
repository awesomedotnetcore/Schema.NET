namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
    [DataContract]
    public class ReplaceAction : UpdateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ReplaceAction";

        /// <summary>
        /// A sub property of object. The object that is being replaced.
        /// </summary>
        [DataMember(Name = "replacee")]
        public Thing Replacee { get; set; }

        /// <summary>
        /// A sub property of object. The object that replaces.
        /// </summary>
        [DataMember(Name = "replacer")]
        public Thing Replacer { get; set; }
    }
}