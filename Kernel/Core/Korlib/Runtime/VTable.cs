//
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using System.Runtime.InteropServices;

namespace SharpOS.Korlib.Runtime {
	[SharpOS.AOT.Attributes.VTable]
	[StructLayout (LayoutKind.Sequential)]
	internal class VTable : InternalSystem.Object {
		internal TypeInfo Type;
		internal uint Size;
		internal ITable ITable; 
	}
}
