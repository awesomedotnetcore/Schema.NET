namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    [DataContract]
    public partial class VisualArtwork : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VisualArtwork";

        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        [DataMember(Name = "artEdition", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? ArtEdition { get; set; }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [DataMember(Name = "artform", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? Artform { get; set; }

        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        [DataMember(Name = "artist", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Person>? Artist { get; set; }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        [DataMember(Name = "artMedium", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? ArtMedium { get; set; }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        [DataMember(Name = "artworkSurface", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? ArtworkSurface { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [DataMember(Name = "colorist", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Person>? Colorist { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [DataMember(Name = "depth", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, QuantitativeValue>? Depth { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, QuantitativeValue>? Height { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [DataMember(Name = "inker", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Person>? Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [DataMember(Name = "letterer", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Person>? Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [DataMember(Name = "penciler", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Person>? Penciler { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, QuantitativeValue>? Width { get; set; }
    }
}
