using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProject
{
    class NewClass
    {
        public string StringName;
        public int NumberId;
        public bool BoolSrtring;

        public NewClass(string str, int id)
        {
            this.StringName = str;
            this.NumberId = id;
            this.BoolSrtring = true;
        }

        public string GetName()
        {
            if (this.StringName != null)
            {
                return this.StringName;
            }
            else return null;
        }
    }
}
