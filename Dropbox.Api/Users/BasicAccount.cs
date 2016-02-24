// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Basic information about any account.</para>
    /// </summary>
    /// <seealso cref="Dropbox.Api.Users.Account" />
    public class BasicAccount : Account
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<BasicAccount> Encoder = new BasicAccountEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<BasicAccount> Decoder = new BasicAccountDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="BasicAccount" /> class.</para>
        /// </summary>
        /// <param name="accountId">The user's unique Dropbox ID.</param>
        /// <param name="name">Details of a user's name.</param>
        /// <param name="email">The user's e-mail address. Do not rely on this without checking
        /// the <paramref name="emailVerified" /> field. Even then, it's possible that the user
        /// has since lost access to their e-mail.</param>
        /// <param name="emailVerified">Whether the user has verified their e-mail
        /// address.</param>
        /// <param name="isTeammate">Whether this user is a teammate of the current user. If
        /// this account is the current user's account, then this will be <c>true</c>.</param>
        /// <param name="profilePhotoUrl">URL for the photo representing the user, if one is
        /// set.</param>
        /// <param name="teamMemberId">The user's unique team member id. This field will only
        /// be present if the user is part of a team and <paramref name="isTeammate" /> is
        /// <c>true</c>.</param>
        public BasicAccount(string accountId,
                            Name name,
                            string email,
                            bool emailVerified,
                            bool isTeammate,
                            string profilePhotoUrl = null,
                            string teamMemberId = null)
            : base(accountId, name, email, emailVerified, profilePhotoUrl)
        {
            this.IsTeammate = isTeammate;
            this.TeamMemberId = teamMemberId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="BasicAccount" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public BasicAccount()
        {
        }

        /// <summary>
        /// <para>Whether this user is a teammate of the current user. If this account is the
        /// current user's account, then this will be <c>true</c>.</para>
        /// </summary>
        public bool IsTeammate { get; protected set; }

        /// <summary>
        /// <para>The user's unique team member id. This field will only be present if the user
        /// is part of a team and <see cref="IsTeammate" /> is <c>true</c>.</para>
        /// </summary>
        public string TeamMemberId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="BasicAccount" />.</para>
        /// </summary>
        private class BasicAccountEncoder : enc.StructEncoder<BasicAccount>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(BasicAccount value, enc.IJsonWriter writer)
            {
                WriteProperty("account_id", value.AccountId, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, Dropbox.Api.Users.Name.Encoder);
                WriteProperty("email", value.Email, writer, enc.StringEncoder.Instance);
                WriteProperty("email_verified", value.EmailVerified, writer, enc.BooleanEncoder.Instance);
                WriteProperty("is_teammate", value.IsTeammate, writer, enc.BooleanEncoder.Instance);
                if (value.ProfilePhotoUrl != null)
                {
                    WriteProperty("profile_photo_url", value.ProfilePhotoUrl, writer, enc.StringEncoder.Instance);
                }
                if (value.TeamMemberId != null)
                {
                    WriteProperty("team_member_id", value.TeamMemberId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="BasicAccount" />.</para>
        /// </summary>
        private class BasicAccountDecoder : enc.StructDecoder<BasicAccount>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="BasicAccount" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override BasicAccount Create()
            {
                return new BasicAccount();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(BasicAccount value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "account_id":
                        value.AccountId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = Dropbox.Api.Users.Name.Decoder.Decode(reader);
                        break;
                    case "email":
                        value.Email = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "email_verified":
                        value.EmailVerified = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "is_teammate":
                        value.IsTeammate = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "profile_photo_url":
                        value.ProfilePhotoUrl = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "team_member_id":
                        value.TeamMemberId = enc.StringDecoder.Instance.Decode(reader);
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
