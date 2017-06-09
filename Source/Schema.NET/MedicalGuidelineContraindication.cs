namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A guideline contraindication that designates a process as harmful and where quality of the data supporting the contraindication is sound.
    /// </summary>
    [DataContract]
    public class MedicalGuidelineContraindication : MedicalGuideline
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalGuidelineContraindication";
    }
}