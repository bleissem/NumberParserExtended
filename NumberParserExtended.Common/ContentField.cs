using System;
using System.Collections.Generic;
using System.Text;

namespace NumberParserExtended.Common
{

    /// <summary>
    /// TopLeft     Top         TopRight 
    /// Left        Content     Right
    /// BottomLeft  Bottom      BottomRight
    /// </summary>
    public class ContentField: IEquatable<ContentField>
    {
        private ContentField()
        {
            
        }

        public ContentField(char content)
        {
            this.Content = content;
            this._Guid = Guid.NewGuid();
        }

        public char Content { get; set; }

        public ContentField TopLeft { get; set; }

        public ContentField Top { get; set; }

        public ContentField TopRight { get; set; }

        public ContentField Left { get; set; }

        public ContentField Right { get; set; }

        public ContentField BottomLeft { get; set; }

        public ContentField Bottom { get; set; }

        public ContentField BottomRight { get; set; }

        private Guid _Guid;

        public bool Equals(ContentField other)
        {
            if (null == other) return false;

            return this._Guid == other._Guid;
        }
    }
}
