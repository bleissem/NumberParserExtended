using NumberParserExtended.Common.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberParserExtended.Common
{
    public class Recognize
    {

        public bool DoRecognize<TNumberConfig>(ContentField field) where TNumberConfig: INumberConfiguration, new()
        {

            TNumberConfig tc = new TNumberConfig();
            ContentField configuration = tc.Field;

            return DoRecognizeInternalY(field, configuration);
        }

        /// <summary>
        /// loop through y 
        /// </summary>
        /// <param name="field"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        private bool DoRecognizeInternalY(ContentField field, ContentField configuration)
        {
            bool b = DoRecognize(field, configuration);
            ContentField current = field;
            do
            {
                b = b || DoRecognizeInternalX(current, configuration);
                current = current.Bottom ?? null;
            }
            while ((current != null) && (!field.Equals(current)));
            
            return b;
        }

        /// <summary>
        /// loop through y
        /// </summary>
        /// <param name="field"></param>
        /// <param name="bottom"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        private bool DoRecognizeInternalX(ContentField field, ContentField configuration)
        {
            bool b = DoRecognize(field, configuration);

            ContentField current = field;
            do
            {
                b = b || DoRecognize(current, configuration);
                current = current.Right ?? null;
            }
            while ((current != null) &&  (!field.Equals(current)));

            return b;
        }

        private bool DoRecognize(ContentField field, ContentField configuration)
        {
            if ((field == null) && (configuration == null)) return true;

            if (field.Content != configuration.Content)
            {
                return false;
            }

            bool topLeftBool =  DoRecognizeNext(field.TopLeft, configuration.TopLeft);
            bool topBool = DoRecognizeNext(field.Top, configuration.Top);
            bool topRightBool = DoRecognizeNext(field.TopRight, configuration.TopRight);

            bool leftBool = DoRecognizeNext(field.Left, configuration.Left);
            bool rightBool = DoRecognizeNext(field.Right, configuration.Right);

            bool bottomLeftBool = DoRecognizeNext(field.BottomLeft, configuration.BottomLeft);
            bool bottomBool = DoRecognizeNext(field.Bottom, configuration.Bottom);
            bool bottomRightBool = DoRecognizeNext(field.BottomRight, configuration.BottomRight);

            return topLeftBool && topBool && topRightBool && leftBool && rightBool && bottomLeftBool && bottomBool && bottomRightBool;
        }

        private bool DoRecognizeNext(ContentField fieldNext, ContentField configNext)
        {
            if (configNext != null)
            {
                if ((fieldNext != null) && (fieldNext.Content == configNext.Content))
                {
                    return DoRecognize(fieldNext, configNext);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

    }
}
