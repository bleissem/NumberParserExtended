using System;
using System.Collections.Generic;
using System.Text;

namespace NumberParserExtended.Common.Configurations
{
    public class NumberThreeConfiguration : NumberConfigurationBase
    {
        protected override void Initialize(out ContentField field)
        {
            field = new ContentField(ContentFieldConstants.Minus)
            {
                Right = new ContentField(ContentFieldConstants.Minus)
                {
                    Right = new ContentField(ContentFieldConstants.Minus)
                    {
                        BottomLeft = new ContentField(ContentFieldConstants.Angular1)
                        {
                            Bottom = new ContentField(ContentFieldConstants.Angular2)
                            {
                                Bottom = new ContentField(ContentFieldConstants.Minus)
                                {
                                    Left = new ContentField(ContentFieldConstants.Minus)
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
