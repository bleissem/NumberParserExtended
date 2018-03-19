using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NumberParserExtended.Common
{
    public class BuildContentField
    {

        public ContentField Build(string content)
        {        
            // y -> x -> ContentFxield
            SortedDictionary<int, SortedDictionary<int, ContentField>> mappedField = new SortedDictionary<int, SortedDictionary<int, ContentField>>();

            string[] contents = content.Split(Environment.NewLine, StringSplitOptions.None);
            char currentCh = ' ';

            for (int y = 0; y < contents.Length; ++y)
            {
                char[] oneCharLine = contents[y].Replace("\t", "   ").ToCharArray(); // hack

                for (int x = 0; x < oneCharLine.Length; ++x)
                {
                    currentCh = oneCharLine[x];
                    //if (!currentCh.Equals(ContentFieldConstants.EmptyContent))
                    {                      
                        if (!mappedField.ContainsKey(y))
                        {
                            mappedField.Add(y, new SortedDictionary<int, ContentField>());
                        }

                        if (!mappedField[y].ContainsKey(x))
                        {
                            mappedField[y].Add(x, new ContentField(currentCh));
                        }
                        else
                        {
                            Trace.Fail("fail");
                        }
                    }
                }
            }

            return MapDict(mappedField);
        }

        private ContentField MapDict(SortedDictionary<int, SortedDictionary<int, ContentField>> mappedField)
        {
            ContentField result = null;

            /// TopLeft     Top         TopRight 
            /// Left        Content     Right
            /// BottomLeft  Bottom      BottomRight

            int yCount = mappedField.Keys.Count;
            int xCount = 0;
            int xLeft = 0;
            int xRight = 0;
            int yUp = 0;
            int yBottom = 0;

            ContentField currentField = null;
            ContentField tmpField = null;

            for (int y = 0; y < yCount; ++y)
            {
                yUp = (y == 0 ? yCount - 1 : y - 1);
                yBottom = (y + 1) % yCount;

                xCount = mappedField[y].Count;
                for (int x = 0; x < xCount; ++x)
                {
                    xLeft = (x == 0 ? xCount - 1 : x - 1);
                    xRight = (x + 1) % xCount;

                    if (!mappedField[y].TryGetValue(x, out currentField))
                    {
                        continue;
                    }
                    else
                    {
                        if (null == result)
                        {
                            result = currentField;
                        }
                    }

                    // topleft 
                    if (mappedField[yUp].TryGetValue(xLeft, out tmpField))
                    {
                        currentField.TopLeft = tmpField;
                    }

                    // top 
                    if (mappedField[yUp].TryGetValue(x, out tmpField))
                    {
                        currentField.Top = tmpField;
                    }

                    // topright
                    if (mappedField[yUp].TryGetValue(xRight, out tmpField))
                    {
                        currentField.TopRight = tmpField;
                    }

                    // left 
                    if (mappedField[y].TryGetValue(xLeft, out tmpField))
                    {
                        currentField.Left = tmpField;
                    }

                    // right
                    if (mappedField[y].TryGetValue(xRight, out tmpField))
                    {
                        currentField.Right = tmpField;
                    }

                    // bottomleft 
                    if (mappedField[yBottom].TryGetValue(xLeft, out tmpField))
                    {
                        currentField.BottomLeft = tmpField;
                    }

                    // bottom 
                    if (mappedField[yBottom].TryGetValue(x, out tmpField))
                    {
                        currentField.Bottom = tmpField;
                    }

                    // bottomright
                    if (mappedField[yBottom].TryGetValue(xRight, out tmpField))
                    {
                        currentField.BottomRight = tmpField;
                    }
                }
            }


            return result;
        }
    }
}
