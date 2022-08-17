// 
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using System;
using System.Text;
using SharpOS.AOT;

namespace SharpOS.AOT.Attributes {
	/// <summary>
	/// Used to mark a define the real namespace of a class/enum/struct/interface.
	/// </summary>
	[AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	public sealed class TargetNamespaceAttribute : Attribute
    {
		public TargetNamespaceAttribute (string value) 
		{

		}
	}
}
