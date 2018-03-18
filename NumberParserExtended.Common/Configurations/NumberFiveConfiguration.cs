using System;
using System.Collections.Generic;
using System.Text;

namespace NumberParserExtended.Common.Configurations
{
    public class NumberFiveConfiguration : NumberConfigurationBase
    {
        protected override void Initialize(out ContentField field)
        {
            field = new ContentField(ContentFieldConstants.Minus)
            {
                Left = new ContentField(ContentFieldConstants.Minus)
                {
                    Left = new ContentField(ContentFieldConstants.Minus)
                    {
                        Left = new ContentField(ContentFieldConstants.Minus)
                        {
                            Left = new ContentField(ContentFieldConstants.Minus)
                            {
                                Bottom = new ContentField(ContentFieldConstants.Vertical)
                                {
                                    Right = new ContentField(ContentFieldConstants.Bottom)
                                    {
                                        Right = new ContentField(ContentFieldConstants.Bottom)
                                        {
                                            Right = new ContentField(ContentFieldConstants.Bottom)
                                            {
                                                BottomRight = new ContentField(ContentFieldConstants.Vertical)
                                                {
                                                    Bottom = new ContentField(ContentFieldConstants.Vertical)
                                                    {
                                                        Left = new ContentField(ContentFieldConstants.Bottom)
                                                        {
                                                            Left = new ContentField(ContentFieldConstants.Bottom)
                                                            {
                                                                Left = new ContentField(ContentFieldConstants.Bottom)
                                                                {
                                                                    Left = new ContentField(ContentFieldConstants.Bottom)
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
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
