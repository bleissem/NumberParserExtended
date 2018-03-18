using System;
using System.Collections.Generic;
using System.Text;

namespace NumberParserExtended.Common.Configurations
{
    public class NumberOneConfiguration : NumberConfigurationBase
    {

        protected override void Initialize(out ContentField field)
        {
            field = new ContentField(ContentFieldConstants.Vertical)
            {
                Bottom = new ContentField(ContentFieldConstants.Vertical)
                {
                    Bottom = new ContentField(ContentFieldConstants.Vertical)
                    {
                        Bottom = new ContentField(ContentFieldConstants.Vertical)
                    }
                }
            };
        }
    }
}
