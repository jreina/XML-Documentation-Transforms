using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentedApplication
{
    /// <summary>
    /// This is a well-documented interface.
    /// </summary>
    interface IAmDocumented
    {
        /// <summary>
        /// This is a well-documented interface method.
        /// </summary>
        void InterfaceMethod();

        /// <summary>
        /// This is a well-documented interface method which returns an integer.
        /// </summary>
        /// <returns>An integer.</returns>
        int InterfaceMethodInt();

        /// <summary>
        /// This is a well-documented interface method which returns a boolean.
        /// </summary>
        /// <returns>A boolean.</returns>
        bool InterfaceMethodBool();

        /// <summary>
        /// This is a well-documented interface method which returns a string.
        /// </summary>
        /// <returns>A string.</returns>
        string InterfaceMethodString();
    }
}
