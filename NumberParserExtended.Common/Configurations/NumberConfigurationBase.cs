using System;
using System.Collections.Generic;
using System.Text;

namespace NumberParserExtended.Common.Configurations
{
    public abstract class NumberConfigurationBase
    {
        public NumberConfigurationBase()
        {

        }

        private ContentField _Field;

        public ContentField Field
        {
            get
            {
                if (null == _Field)
                {
                    Initialize(out _Field);
                }

                return _Field;
            }

        }

        protected abstract void Initialize(out ContentField field);

    }
}
