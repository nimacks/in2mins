using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    /// <summary>
    /// Represents an odd number exception that will occur during the excecution of the program
    /// </summary>
    [Serializable]
    public class OddNumberException : Exception
    {
        public int OddNumber { get; set; }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("OddNumber",OddNumber);
        }
        public OddNumberException(){}
        public OddNumberException(int oddNumber) 
        {
            this.OddNumber = oddNumber;
        }

        public OddNumberException(string message) : base(message){}
    }
}
/*
Steps to create a custom exception
 * Give it a name
 * Add at least one constructor 
 


*/