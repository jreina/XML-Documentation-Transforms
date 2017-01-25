using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentedApplication
{
    /// <summary>
    /// I am a well-documented abstract class which implements the IAmDocumented interface.
    /// </summary>
    public abstract class DocumentedAbstractClass : IAmDocumented
    {
        /// <summary>
        /// I am an abstract implementation of InterfaceMethod.
        /// </summary>
        public abstract void InterfaceMethod();

        /// <summary>
        /// I am an abstract implementation of InterfaceMethodBool.
        /// </summary>
        /// <returns>A boolean.</returns>
        public abstract bool InterfaceMethodBool();

        /// <summary>
        /// I am an abstract implementation of InterfaceMethodInt.
        /// </summary>
        /// <returns>An integer.</returns>
        public abstract int InterfaceMethodInt();

        /// <summary>
        /// I am an abstract implementation of InterfaceMethodString.
        /// </summary>
        /// <returns>A string.</returns>
        public abstract string InterfaceMethodString();
    }
}
