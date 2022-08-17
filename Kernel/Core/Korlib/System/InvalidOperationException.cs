//
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Sander van Rossen <sander.vanrossen@gmail.com>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using SharpOS.AOT.Attributes;
using SharpOS.Korlib.Runtime;

namespace InternalSystem {
	[TargetNamespace ("System")]
	public class InvalidOperationException: InternalSystem.SystemException {
		public InvalidOperationException () :
			base ("The requested operation cannot be performed.")
		{
		}

		public InvalidOperationException (string message):
			base (message)
		{
		}
	}
}
