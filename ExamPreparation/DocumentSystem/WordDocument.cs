﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class WordDocument : OfficeDocument, IEditable
    {
        public long? Chars { get; private set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.Chars = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {

            output.Add(new KeyValuePair<string, object>("chars", this.Chars));
            base.SaveAllProperties(output);

        }

        public void ChangeContent(string content)
        {
            this.Content = content;
        }
    }
}
