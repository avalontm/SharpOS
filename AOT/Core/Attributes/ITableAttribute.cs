// 
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Stanislaw Pitucha <viraptor@gmail.com>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using System;
using System.Text;
using SharpOS.AOT;

namespace SharpOS.AOT.Attributes {
	/// <summary>
	/// Used to mark the class that will be used as the itable in every object.
	/// </summary>
	[AttributeUsage (AttributeTargets.Class)]
	public sealed class ITableAttribute : Attribute {
	}
}
