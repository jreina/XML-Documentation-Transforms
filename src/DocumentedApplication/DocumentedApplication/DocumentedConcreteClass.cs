using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentedApplication
{
    /// <summary>
    /// This is a concrete class which implements inherited methods.
    /// </summary>
    public class DocumentedConcreteClass : DocumentedAbstractClass
    {
        /// <summary>
        /// This is a concrete implementation of InterfaceMethod.
        /// </summary>
        public override void InterfaceMethod()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a concrete implementation of InterfaceMethodBool.
        /// </summary>
        /// <returns>A boolean.</returns>
        public override bool InterfaceMethodBool()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a concrete implementation of InterfaceMethodInt.
        /// </summary>
        /// <returns>An integer.</returns>
        public override int InterfaceMethodInt()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a concrete implementation of InterfaceMethodString.
        /// </summary>
        /// <returns>A string.</returns>
        public override string InterfaceMethodString()
        {
            throw new NotImplementedException();
        }
    }
}
