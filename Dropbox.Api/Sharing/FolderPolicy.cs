// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>A set of policies governing membership and privileges for a shared folder.</para>
    /// </summary>
    /// <seealso cref="SharedFolderMetadata" />
    /// <seealso cref="SharedFolderMetadataBase" />
    public class FolderPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FolderPolicy> Encoder = new FolderPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FolderPolicy> Decoder = new FolderPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderPolicy" /> class.</para>
        /// </summary>
        /// <param name="aclUpdatePolicy">Who can add and remove members from this shared
        /// folder.</param>
        /// <param name="sharedLinkPolicy">Who links can be shared with.</param>
        /// <param name="memberPolicy">Who can be a member of this shared folder. Only set if
        /// the user is a member of a team.</param>
        public FolderPolicy(AclUpdatePolicy aclUpdatePolicy,
                            SharedLinkPolicy sharedLinkPolicy,
                            MemberPolicy memberPolicy = null)
        {
            if (aclUpdatePolicy == null)
            {
                throw new sys.ArgumentNullException("aclUpdatePolicy");
            }

            if (sharedLinkPolicy == null)
            {
                throw new sys.ArgumentNullException("sharedLinkPolicy");
            }

            this.AclUpdatePolicy = aclUpdatePolicy;
            this.SharedLinkPolicy = sharedLinkPolicy;
            this.MemberPolicy = memberPolicy;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderPolicy" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public FolderPolicy()
        {
        }

        /// <summary>
        /// <para>Who can add and remove members from this shared folder.</para>
        /// </summary>
        public AclUpdatePolicy AclUpdatePolicy { get; protected set; }

        /// <summary>
        /// <para>Who links can be shared with.</para>
        /// </summary>
        public SharedLinkPolicy SharedLinkPolicy { get; protected set; }

        /// <summary>
        /// <para>Who can be a member of this shared folder. Only set if the user is a member
        /// of a team.</para>
        /// </summary>
        public MemberPolicy MemberPolicy { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FolderPolicy" />.</para>
        /// </summary>
        private class FolderPolicyEncoder : enc.StructEncoder<FolderPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FolderPolicy value, enc.IJsonWriter writer)
            {
                WriteProperty("acl_update_policy", value.AclUpdatePolicy, writer, Dropbox.Api.Sharing.AclUpdatePolicy.Encoder);
                WriteProperty("shared_link_policy", value.SharedLinkPolicy, writer, Dropbox.Api.Sharing.SharedLinkPolicy.Encoder);
                if (value.MemberPolicy != null)
                {
                    WriteProperty("member_policy", value.MemberPolicy, writer, Dropbox.Api.Sharing.MemberPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FolderPolicy" />.</para>
        /// </summary>
        private class FolderPolicyDecoder : enc.StructDecoder<FolderPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FolderPolicy" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FolderPolicy Create()
            {
                return new FolderPolicy();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FolderPolicy value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "acl_update_policy":
                        value.AclUpdatePolicy = Dropbox.Api.Sharing.AclUpdatePolicy.Decoder.Decode(reader);
                        break;
                    case "shared_link_policy":
                        value.SharedLinkPolicy = Dropbox.Api.Sharing.SharedLinkPolicy.Decoder.Decode(reader);
                        break;
                    case "member_policy":
                        value.MemberPolicy = Dropbox.Api.Sharing.MemberPolicy.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
