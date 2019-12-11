using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class NewClass
    {
        public string StringName;

        public NewClass(string stringName)
        {
            StringName = stringName;
        }

        public string GetName()
        {
            return this.StringName;
        }
    }
}
