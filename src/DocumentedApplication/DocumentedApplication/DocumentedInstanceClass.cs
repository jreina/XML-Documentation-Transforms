using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentedApplication
{
    /// <summary>
    /// This is a well-documented instance class.
    /// </summary>
    public class DocumentedInstanceClass
    {
        /// <summary>
        /// This is the parameterless constructor for DocumentInstanceClass.
        /// </summary>
        public DocumentedInstanceClass() { }

        /// <summary>
        /// This is a constructor which accepts two objects as parameters.
        /// </summary>
        /// <param name="a">Object a</param>
        /// <param name="b">Object b</param>
        public DocumentedInstanceClass(object a, object b) { }

        /// <summary>
        /// This is an instance method of DocumentedInstanceClass which accepts an object as a parameter.
        /// </summary>
        /// <param name="b">Object b</param>
        public void DoStuffTo(object b) { }

        /// <summary>
        /// This is a generic instance method
        /// </summary>
        /// <typeparam name="T">Type T.</typeparam>
        /// <param name="b">Object b</param>
        /// <returns></returns>
        public T DoStuffTo<T>(object b) { return (T)b; }

        /// <summary>
        /// This is a string instance property.
        /// </summary>
        public string InstancePropertyString { get; set; }

        /// <summary>
        /// This is an int instance property.
        /// </summary>
        public int InstancePropertyInt { get; set; }

        /// <summary>
        /// This is a boolean instance property.
        /// </summary>
        public bool InstancePropertyBoolean { get; set; }

        /// <summary>
        /// This is a integer array instance property.
        /// </summary>
        public int[] InstancePropertyIntArray { get; set; }
    }
}
