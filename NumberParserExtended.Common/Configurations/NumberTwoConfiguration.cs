using System;
using System.Collections.Generic;
using System.Text;

namespace NumberParserExtended.Common.Configurations
{
    public class NumberTwoConfiguration : NumberConfigurationBase
    {
        protected override void Initialize(out ContentField field)
        {
            field = new ContentField(ContentFieldConstants.Minus)
            {
                Right = new ContentField(ContentFieldConstants.Minus)
                {
                    Right = new ContentField(ContentFieldConstants.Minus)
                    {
                        Bottom = new ContentField(ContentFieldConstants.Vertical)
                        {
                            Left = new ContentField(ContentFieldConstants.Bottom)
                            {
                                BottomLeft = new ContentField(ContentFieldConstants.Vertical)
                                {
                                    Bottom = new ContentField(ContentFieldConstants.Minus)
                                    {
                                        Right = new ContentField(ContentFieldConstants.Minus)
                                        {
                                            Right = new ContentField(ContentFieldConstants.Minus)
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
