// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace DownstreamClients.GitHub.Repos.Item.Item.Releases.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WithRelease_PatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Text describing the contents of the tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>If specified, a discussion of the specified category is created and linked to the release. The value must be a category that already exists in the repository. If there is already a discussion linked to the release, this parameter is ignored. For more information, see &quot;[Managing categories for discussions in your repository](https://docs.github.com/discussions/managing-discussions-for-your-community/managing-categories-for-discussions-in-your-repository).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DiscussionCategoryName { get; set; }
#nullable restore
#else
        public string DiscussionCategoryName { get; set; }
#endif
        /// <summary>`true` makes the release a draft, and `false` publishes the release.</summary>
        public bool? Draft { get; set; }
        /// <summary>Specifies whether this release should be set as the latest release for the repository. Drafts and prereleases cannot be set as latest. Defaults to `true` for newly published releases. `legacy` specifies that the latest release should be determined based on the release creation date and higher semantic version.</summary>
        public global::DownstreamClients.GitHub.Repos.Item.Item.Releases.Item.WithRelease_PatchRequestBody_make_latest? MakeLatest { get; set; }
        /// <summary>The name of the release.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>`true` to identify the release as a prerelease, `false` to identify the release as a full release.</summary>
        public bool? Prerelease { get; set; }
        /// <summary>The name of the tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TagName { get; set; }
#nullable restore
#else
        public string TagName { get; set; }
#endif
        /// <summary>Specifies the commitish value that determines where the Git tag is created from. Can be any branch or commit SHA. Unused if the Git tag already exists. Default: the repository&apos;s default branch (usually `master`).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetCommitish { get; set; }
#nullable restore
#else
        public string TargetCommitish { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::DownstreamClients.GitHub.Repos.Item.Item.Releases.Item.WithRelease_PatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithRelease_PatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            MakeLatest = global::DownstreamClients.GitHub.Repos.Item.Item.Releases.Item.WithRelease_PatchRequestBody_make_latest.True;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::DownstreamClients.GitHub.Repos.Item.Item.Releases.Item.WithRelease_PatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::DownstreamClients.GitHub.Repos.Item.Item.Releases.Item.WithRelease_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::DownstreamClients.GitHub.Repos.Item.Item.Releases.Item.WithRelease_PatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "body", n => { Body = n.GetStringValue(); } },
                { "discussion_category_name", n => { DiscussionCategoryName = n.GetStringValue(); } },
                { "draft", n => { Draft = n.GetBoolValue(); } },
                { "make_latest", n => { MakeLatest = n.GetEnumValue<global::DownstreamClients.GitHub.Repos.Item.Item.Releases.Item.WithRelease_PatchRequestBody_make_latest>(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "prerelease", n => { Prerelease = n.GetBoolValue(); } },
                { "tag_name", n => { TagName = n.GetStringValue(); } },
                { "target_commitish", n => { TargetCommitish = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("body", Body);
            writer.WriteStringValue("discussion_category_name", DiscussionCategoryName);
            writer.WriteBoolValue("draft", Draft);
            writer.WriteEnumValue<global::DownstreamClients.GitHub.Repos.Item.Item.Releases.Item.WithRelease_PatchRequestBody_make_latest>("make_latest", MakeLatest);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("prerelease", Prerelease);
            writer.WriteStringValue("tag_name", TagName);
            writer.WriteStringValue("target_commitish", TargetCommitish);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
