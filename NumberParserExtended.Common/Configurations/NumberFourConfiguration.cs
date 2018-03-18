using System;
using System.Collections.Generic;
using System.Text;

namespace NumberParserExtended.Common.Configurations
{
    public class NumberFourConfiguration : NumberConfigurationBase
    {
        protected override void Initialize(out ContentField field)
        {
            field = new ContentField(ContentFieldConstants.Vertical)
            {
                Bottom = new ContentField(ContentFieldConstants.Vertical)
                {
                    Right = new ContentField(ContentFieldConstants.Bottom)
                    {
                        Right = new ContentField(ContentFieldConstants.Bottom)
                        {
                            Right = new ContentField(ContentFieldConstants.Bottom)
                            {
                                Right = new ContentField(ContentFieldConstants.Vertical)
                                {
                                    Top = new ContentField(ContentFieldConstants.Vertical),
                                    Bottom = new ContentField(ContentFieldConstants.Vertical)
                                    {
                                        Bottom = new ContentField(ContentFieldConstants.Vertical)
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
