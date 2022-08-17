//
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using SharpOS.Kernel.ADC;

namespace SharpOS.Kernel.Tests {
	public unsafe class Wrapper {
		public static void Run ()
		{
#if KERNEL_TESTS
			int failures = 0;
			if (SharpOS.Kernel.Tests.IL.Addition.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.Addition.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.Addition.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.Addition.CMP1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.Addition.CMP1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.Addition.CMP1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ConditionChecking.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ConditionChecking.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ConditionChecking.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ConstantLoading.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ConstantLoading.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ConstantLoading.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ConstantLoading.CMP1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ConstantLoading.CMP1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ConstantLoading.CMP1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ConversionOperations.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ConversionOperations.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ConversionOperations.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFinally () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFinally' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFinally' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPDontRunFilter () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPDontRunFilter' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPDontRunFilter' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFilter () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFilter' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFilter' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP4 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP4' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP4' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP5 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP5' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP5' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP6 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP6' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP6' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP7 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP7' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP7' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP8 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP8' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP8' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP9 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP9' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP9' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHR.CMP10 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP10' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHR.CMP10' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP4 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP4' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP4' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP5 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP5' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP5' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP6 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP6' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP6' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP7 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP7' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP7' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP8 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP8' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP8' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP9 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP9' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP9' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP10 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP10' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP10' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP11 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP11' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP11' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP12 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP12' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP12' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP13 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP13' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP13' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP14 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP14' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP14' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP15 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP15' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP15' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP16 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP16' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP16' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHL.CMP17 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP17' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHL.CMP17' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ADD.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ADD.CMP1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ADD.CMP2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ADD.CMP3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ADD.CMP4 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP4' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP4' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.ADD.CMP5 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP5' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.ADD.CMP5' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP4 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP4' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP4' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP5 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP5' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP5' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP6 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP6' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP6' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP7 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP7' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP7' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP8 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP8' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP8' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP9 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP9' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP9' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP10 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP10' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP10' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SHRUN.CMP11 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP11' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SHRUN.CMP11' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.SUB.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.SUB.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.SUB.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.MethodArguments.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.MethodArguments.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.MethodArguments.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.MethodArguments.CMP1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.MethodArguments.CMP1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.MethodArguments.CMP1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.IL.MethodArguments.CMP2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.IL.MethodArguments.CMP2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.IL.MethodArguments.CMP2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Abstract.CMPGetAbstractProperty () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPGetAbstractProperty' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPGetAbstractProperty' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Abstract.CMPCallInherited () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPCallInherited' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPCallInherited' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Abstract.CMPCallProxiedInherited () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPCallProxiedInherited' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPCallProxiedInherited' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Abstract.CMPCallOverridden () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPCallOverridden' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPCallOverridden' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Abstract.CMPCallAbstractMember () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPCallAbstractMember' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Abstract.CMPCallAbstractMember' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arguments.CMPArguments1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arguments.CMPArguments1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arguments.CMPArguments1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arguments.CMPArguments2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arguments.CMPArguments2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arguments.CMPArguments2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arguments.CMPArgumentsParams () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arguments.CMPArgumentsParams' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arguments.CMPArgumentsParams' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd32 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd32' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd32' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract32 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract32' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract32' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply32 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply32' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply32' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide32 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide32' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide32' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd64 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd64' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd64' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide64 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide64' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide64' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract64 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract64' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract64' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply64 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply64' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply64' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowAdd64 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowAdd64' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowAdd64' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowSubtract64 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowSubtract64' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowSubtract64' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowMultiply64 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowMultiply64' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowMultiply64' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPStructArrayCall () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPStructArrayCall' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPStructArrayCall' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPObjectArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPObjectArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPObjectArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPIntArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPShortArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPShortArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPShortArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPByteArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPByteArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPByteArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPLongArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPLongArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPLongArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPUIntArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUIntArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUIntArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPUShortArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUShortArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUShortArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPSByteArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPSByteArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPSByteArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPULongArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPULongArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPULongArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPIntArrayLength () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntArrayLength' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntArrayLength' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPIntArrayZeroLength () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntArrayZeroLength' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntArrayZeroLength' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedMultidimensionalArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedMultidimensionalArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedMultidimensionalArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPShortJaggedArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPShortJaggedArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPShortJaggedArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPByteJaggedArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPByteJaggedArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPByteJaggedArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPLongJaggedArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPLongJaggedArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPLongJaggedArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPULongJaggedArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPULongJaggedArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPULongJaggedArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPSByteJaggedArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPSByteJaggedArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPSByteJaggedArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPUShortJaggedArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUShortJaggedArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUShortJaggedArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPUIntJaggedArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUIntJaggedArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUIntJaggedArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPShortMultidimensionalArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPShortMultidimensionalArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPShortMultidimensionalArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPByteMultidimensionalArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPByteMultidimensionalArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPByteMultidimensionalArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPLongMultidimensionalArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPLongMultidimensionalArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPLongMultidimensionalArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPUIntMultidimensionalArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUIntMultidimensionalArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUIntMultidimensionalArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPUShortMultidimensionalArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUShortMultidimensionalArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPUShortMultidimensionalArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPSByteMultidimensionalArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPSByteMultidimensionalArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPSByteMultidimensionalArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPULongMultidimensionalArray () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPULongMultidimensionalArray' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPULongMultidimensionalArray' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArrayLength () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArrayLength' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArrayLength' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleAND () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleAND' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleAND' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleOR () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleOR' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleOR' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleXOR () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleXOR' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleXOR' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleNot () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleNot' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleNot' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftLeft () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftLeft' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftLeft' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPUnsignedShiftLeft () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPUnsignedShiftLeft' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPUnsignedShiftLeft' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftRight () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftRight' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftRight' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleAnd () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleAnd' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleAnd' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleOr () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleOr' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleOr' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleNot () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleNot' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleNot' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPConstants () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPConstants' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPConstants' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValues () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValues' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValues' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValuesAndConstants () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValuesAndConstants' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValuesAndConstants' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Boxing.CMPBoxUnbox () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Boxing.CMPBoxUnbox' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Boxing.CMPBoxUnbox' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Boxing.CMP2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Boxing.CMP2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Boxing.CMP2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.ByteString.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.ByteString.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.ByteString.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator4 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator4' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator4' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToInt () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToInt' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToInt' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPIntToLiteral () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPIntToLiteral' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPIntToLiteral' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPIntConstantComparison () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPIntConstantComparison' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPIntConstantComparison' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPIntValueComparison () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPIntValueComparison' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPIntValueComparison' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPSimpleIntFlags () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPSimpleIntFlags' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPSimpleIntFlags' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPIntEnumReturn () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPIntEnumReturn' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPIntEnumReturn' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToULong () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToULong' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToULong' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPULongToLiteral () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPULongToLiteral' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPULongToLiteral' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPULongConstantComparison () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPULongConstantComparison' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPULongConstantComparison' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPULongValueComparison () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPULongValueComparison' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPULongValueComparison' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPSimpleULongFlags () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPSimpleULongFlags' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPSimpleULongFlags' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Enum.CMPULongEnumReturn () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPULongEnumReturn' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Enum.CMPULongEnumReturn' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32Object () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32Object' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32Object' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Equals.CMPInt32ObjectEqualsInt32Object () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Equals.CMPInt32ObjectEqualsInt32Object' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Equals.CMPInt32ObjectEqualsInt32Object' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPCatchDivideError () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatchDivideError' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatchDivideError' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally4 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally4' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally4' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally5 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally5' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally5' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Exceptions.CMPRethrow () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPRethrow' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Exceptions.CMPRethrow' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Generics.CMPGenericMethod () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPGenericMethod' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPGenericMethod' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Generics.CMPGenericType () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPGenericType' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPGenericType' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwo () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwo' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwo' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwoVirtualMethods () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwoVirtualMethods' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwoVirtualMethods' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Generics.CMPSubGenericType () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPSubGenericType' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Generics.CMPSubGenericType' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallInherited () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallInherited' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallInherited' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallProxiedInherited () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallProxiedInherited' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallProxiedInherited' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenInt () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenInt' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenInt' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenEnum () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenEnum' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenEnum' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMember () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMember' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMember' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMemberFromBase () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMemberFromBase' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMemberFromBase' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsValueType () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsValueType' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsValueType' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsClass () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsClass' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsClass' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPIsInst () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPIsInst' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPIsInst' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeIsInst () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeIsInst' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeIsInst' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPCastClass () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCastClass' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPCastClass' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeCastClass () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeCastClass' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeCastClass' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPInterfaceImplementationInherited () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPInterfaceImplementationInherited' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPInterfaceImplementationInherited' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPBasic () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPBasic' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPBasic' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPPointerMethod () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPPointerMethod' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPPointerMethod' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPOverrides1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPOverrides1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPOverrides1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPOverrides2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPOverrides2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPOverrides2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPOverrides3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPOverrides3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPOverrides3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPGetProperty () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPGetProperty' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPGetProperty' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPCallGet100 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPCallGet100' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPCallGet100' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Misc.CMP1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Misc.CMP2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Misc.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Misc.CMP3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Misc.CMP4 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP4' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMP4' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Misc.CMPPhiIndexBug () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMPPhiIndexBug' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Misc.CMPPhiIndexBug' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2SByte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2SByte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2SByte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2Byte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2Byte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2Byte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Byte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Byte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Byte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Int () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Int' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Int' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2UInt () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2UInt' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2UInt' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Short () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Short' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Short' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2Short () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2Short' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2Short' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2Byte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2Byte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2Byte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Byte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Byte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Byte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Int () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Int' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Int' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2UInt () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2UInt' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2UInt' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Short () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Short' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Short' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2UShort () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2UShort' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2UShort' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Byte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Byte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Byte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Short () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Short' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Short' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Int () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Int' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Int' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Long () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Long' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Long' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2SByte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2SByte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2SByte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UShort () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UShort' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UShort' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UInt () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UInt' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UInt' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2ULong () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2ULong' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2ULong' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Objects.CMPFieldNullReference () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPFieldNullReference' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPFieldNullReference' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Objects.CMPMethodNullReference () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPMethodNullReference' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPMethodNullReference' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Objects.CMPCreateObject () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPCreateObject' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPCreateObject' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Objects.CMPOverrideObject () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPOverrideObject' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPOverrideObject' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Objects.CMPDefaultToString () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPDefaultToString' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPDefaultToString' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Objects.CMPIsOperator () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPIsOperator' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Objects.CMPIsOperator' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPConstants () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPConstants' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPConstants' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValues () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValues' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValues' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValuesAndConstants () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValuesAndConstants' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValuesAndConstants' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ByteP () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ByteP' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ByteP' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ShortP () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ShortP' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ShortP' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2IntP () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2IntP' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2IntP' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2LongP () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2LongP' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2LongP' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.PointerCast.CMPByteP2VoidP () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPByteP2VoidP' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPByteP2VoidP' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.PointerCast.CMPShortP2VoidP () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPShortP2VoidP' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPShortP2VoidP' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.PointerCast.CMPIntP2VoidP () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPIntP2VoidP' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPIntP2VoidP' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.PointerCast.CMPLongP2VoidP () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPLongP2VoidP' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.PointerCast.CMPLongP2VoidP' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2SByte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2SByte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2SByte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Int () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Int' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Int' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Short () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Short' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Short' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2SByte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2SByte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2SByte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2Int () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2Int' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2Int' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2Short () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2Short' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2Short' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPLong2SByte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPLong2SByte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPLong2SByte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.StaticConstructor.CMPStaticConstructor () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.StaticConstructor.CMPStaticConstructor' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.StaticConstructor.CMPStaticConstructor' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPGetLength () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPGetLength' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPGetLength' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPGetChars () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPGetChars' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPGetChars' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPGetChars2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPGetChars2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPGetChars2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPBumperLength () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPBumperLength' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPBumperLength' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPCStringStub1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPCStringStub1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPCStringStub1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPCStringPass1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPCStringPass1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPCStringPass1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPConstIndexing3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPConstIndexing3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPConstIndexing3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPConcat () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPConcat' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPConcat' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPSubString () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPSubString' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPSubString' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPSubString2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPSubString2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPSubString2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPIndexOf () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPIndexOf' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPIndexOf' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.String.CMPLastIndexOf () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPLastIndexOf' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.String.CMPLastIndexOf' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPConstructor () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPConstructor' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPConstructor' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPEmptyStruct () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPEmptyStruct' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPEmptyStruct' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPStructParameter () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPStructParameter' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPStructParameter' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPNoChanges () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPNoChanges' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPNoChanges' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPCopy () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPCopy' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPCopy' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPReturn () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPReturn' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPReturn' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPSizeof1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPSizeof1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPSizeof1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPSizeof2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPSizeof2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPSizeof2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Struct.CMPPrivateStatic () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPPrivateStatic' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Struct.CMPPrivateStatic' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Switch.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Switch.CMP1 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMP1' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMP1' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Switch.CMP2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMP2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMP2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Switch.CMP3 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMP3' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMP3' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Switch.CMPMisc2a () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2a' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2a' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Switch.CMPMisc2b () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2b' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2b' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.Switch.CMPMisc2c () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2c' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2c' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.UInt32.CMPToString () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.UInt32.CMPToString' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.UInt32.CMPToString' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.UInt32.CMPToString2 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.UInt32.CMPToString2' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.UInt32.CMPToString2' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2Byte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2Byte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2Byte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UInt () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UInt' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UInt' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UShort () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UShort' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UShort' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2Byte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2Byte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2Byte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2UInt () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2UInt' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2UInt' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2UShort () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2UShort' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2UShort' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPULong2Byte () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPULong2Byte' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPULong2Byte' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.WhileLoop.CMP0 () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.WhileLoop.CMP0' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.WhileLoop.CMP0' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.X86.CMPPushArgument () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.X86.CMPPushArgument' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.X86.CMPPushArgument' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.X86.CMPReadArgument () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.X86.CMPReadArgument' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.X86.CMPReadArgument' failed.");
				failures++;
			}

			if (SharpOS.Kernel.Tests.CS.X86.CMPLabelHandling () != 1) {
				TextMode.WriteLine ("'SharpOS.Kernel.Tests.CS.X86.CMPLabelHandling' failed.");
				Debug.COM1.WriteLine ("'SharpOS.Kernel.Tests.CS.X86.CMPLabelHandling' failed.");
				failures++;
			}

			if (failures > 0)
				TextMode.WriteLine ("Not all tests passed!");
			else
				TextMode.WriteLine ("All test cases have completed successfully!");
#endif
		}
	}
}
