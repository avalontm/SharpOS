//
// (C) 2006-2008 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Michael Ruck (aka grover) <sharpos@michaelruck.de>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using System;
using System.Collections.Generic;
using System.Text;

namespace SharpOS.Kernel.Vfs {
	/// <summary>
	/// Flags for the <see cref="SharpOS.Kernel.Vfs.VirtualFileSystem.AccessCheck"/> function.
	/// </summary>
	[Flags]
	public enum AccessCheckFlags {
		/// <summary>
		/// No special access checking flags.
		/// </summary>
		None = 0x00000000,

		/// <summary>
		/// Do not throw an exception for failed access checks. The return value is false for failed access checks the caller
		/// must take care of properly handling the result of the AccessCheck in order to prevent security breaches.
		/// </summary>
		NoThrow = 0x00000001
	}

	public sealed class AccessCheck {
		/// <summary>
		/// This method performs an access check on the given dentry.
		/// </summary>
		/// <param name="dentry">The directory entry to perform the access check on.</param>
		/// <param name="mode">The access mode to check.</param>
		/// <param name="flags">Flags, which control the operation.</param>
		/// <returns>True if the caller has the requested permissions on the given directory entry.</returns>
		/// <exception cref="System.Security.SecurityException">This exception is thrown for failed access checks unless the caller has specified AccessCheckFlags.NoThrow.</exception>
		/// <remarks>
		/// This function only checks the permissions on the dentry itself. It does not traverse the directory tree towards the root 
		/// to check the entire tree. Tree checking is automatically performed by Lookup and related functions.
		/// </remarks>
		public static bool Perform(DirectoryEntry dentry, AccessMode mode, AccessCheckFlags flags)
		{
			// FIXME: Implement the access checking
			return true;
		}
	}
}
