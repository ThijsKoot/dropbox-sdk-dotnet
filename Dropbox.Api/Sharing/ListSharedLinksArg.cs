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
    /// <para>The list shared links arg object</para>
    /// </summary>
    public class ListSharedLinksArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListSharedLinksArg> Encoder = new ListSharedLinksArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListSharedLinksArg> Decoder = new ListSharedLinksArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListSharedLinksArg" />
        /// class.</para>
        /// </summary>
        /// <param name="path">See <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.ListSharedLinksAsync" />
        /// description.</param>
        /// <param name="cursor">The cursor returned by your last call to <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.ListSharedLinksAsync" />.</param>
        /// <param name="directOnly">See <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.ListSharedLinksAsync" />
        /// description.</param>
        public ListSharedLinksArg(string path = null,
                                  string cursor = null,
                                  bool? directOnly = null)
        {
            if (path != null && (!re.Regex.IsMatch(path, @"\A(?:((/|id:).*)|(rev:[0-9a-f]{9,}))\z")))
            {
                throw new sys.ArgumentOutOfRangeException("path");
            }

            this.Path = path;
            this.Cursor = cursor;
            this.DirectOnly = directOnly;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListSharedLinksArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListSharedLinksArg()
        {
        }

        /// <summary>
        /// <para>See <see cref="Dropbox.Api.Sharing.Routes.SharingRoutes.ListSharedLinksAsync"
        /// /> description.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>The cursor returned by your last call to <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.ListSharedLinksAsync" />.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        /// <summary>
        /// <para>See <see cref="Dropbox.Api.Sharing.Routes.SharingRoutes.ListSharedLinksAsync"
        /// /> description.</para>
        /// </summary>
        public bool? DirectOnly { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListSharedLinksArg" />.</para>
        /// </summary>
        private class ListSharedLinksArgEncoder : enc.StructEncoder<ListSharedLinksArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListSharedLinksArg value, enc.IJsonWriter writer)
            {
                if (value.Path != null)
                {
                    WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                }
                if (value.Cursor != null)
                {
                    WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
                }
                if (value.DirectOnly != null)
                {
                    WriteProperty("direct_only", value.DirectOnly.Value, writer, enc.BooleanEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListSharedLinksArg" />.</para>
        /// </summary>
        private class ListSharedLinksArgDecoder : enc.StructDecoder<ListSharedLinksArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListSharedLinksArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListSharedLinksArg Create()
            {
                return new ListSharedLinksArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListSharedLinksArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "direct_only":
                        value.DirectOnly = enc.BooleanDecoder.Instance.Decode(reader);
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
