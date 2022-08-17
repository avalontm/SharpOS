//
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using NUnit.Framework;

[TestFixture]
public class KernelTests {
	[Test]
	public void SharpOS_Kernel_Tests_IL_Addition_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.Addition.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.Addition.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_Addition_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.Addition.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.Addition.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ConditionChecking_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ConditionChecking.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.ConditionChecking.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ConstantLoading_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ConstantLoading.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.ConstantLoading.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ConstantLoading_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ConstantLoading.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.ConstantLoading.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ConversionOperations_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ConversionOperations.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.ConversionOperations.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ExceptionHandling_CMPFinally ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFinally () == 1, "'SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFinally' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ExceptionHandling_CMPDontRunFilter ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPDontRunFilter () == 1, "'SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPDontRunFilter' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ExceptionHandling_CMPFilter ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFilter () == 1, "'SharpOS.Kernel.Tests.IL.ExceptionHandling.CMPFilter' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP3 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP4 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP5 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP5 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP5' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP6 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP6 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP6' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP7 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP7 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP7' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP8 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP8 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP8' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP9 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP9 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP9' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP10 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP10 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP10' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP3 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP4 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP5 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP5 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP5' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP6 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP6 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP6' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP7 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP7 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP7' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP8 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP8 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP8' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP9 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP9 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP9' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP10 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP10 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP10' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP11 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP11 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP11' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP12 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP12 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP12' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP13 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP13 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP13' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP14 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP14 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP14' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP15 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP15 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP15' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP16 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP16 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP16' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP17 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP17 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP17' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP3 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP4 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP5 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP5 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP5' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP3 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP4 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP5 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP5 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP5' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP6 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP6 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP6' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP7 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP7 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP7' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP8 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP8 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP8' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP9 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP9 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP9' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP10 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP10 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP10' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP11 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP11 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP11' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SUB_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SUB.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.SUB.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_MethodArguments_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.MethodArguments.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.MethodArguments.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_MethodArguments_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.MethodArguments.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.MethodArguments.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_MethodArguments_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.MethodArguments.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.MethodArguments.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Abstract_CMPGetAbstractProperty ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Abstract.CMPGetAbstractProperty () == 1, "'SharpOS.Kernel.Tests.CS.Abstract.CMPGetAbstractProperty' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Abstract_CMPCallInherited ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Abstract.CMPCallInherited () == 1, "'SharpOS.Kernel.Tests.CS.Abstract.CMPCallInherited' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Abstract_CMPCallProxiedInherited ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Abstract.CMPCallProxiedInherited () == 1, "'SharpOS.Kernel.Tests.CS.Abstract.CMPCallProxiedInherited' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Abstract_CMPCallOverridden ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Abstract.CMPCallOverridden () == 1, "'SharpOS.Kernel.Tests.CS.Abstract.CMPCallOverridden' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Abstract_CMPCallAbstractMember ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Abstract.CMPCallAbstractMember () == 1, "'SharpOS.Kernel.Tests.CS.Abstract.CMPCallAbstractMember' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arguments_CMPArguments1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arguments.CMPArguments1 () == 1, "'SharpOS.Kernel.Tests.CS.Arguments.CMPArguments1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arguments_CMPArguments2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arguments.CMPArguments2 () == 1, "'SharpOS.Kernel.Tests.CS.Arguments.CMPArguments2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arguments_CMPArgumentsParams ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arguments.CMPArgumentsParams () == 1, "'SharpOS.Kernel.Tests.CS.Arguments.CMPArgumentsParams' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleAdd32 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd32 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd32' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleSubtract32 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract32 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract32' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleMultiply32 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply32 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply32' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleDivide32 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide32 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide32' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleAdd64 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd64 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd64' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleDivide64 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide64 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide64' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleSubtract64 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract64 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract64' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleMultiply64 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply64 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply64' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPOverflowAdd64 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowAdd64 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowAdd64' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPOverflowSubtract64 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowSubtract64 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowSubtract64' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPOverflowMultiply64 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowMultiply64 () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPOverflowMultiply64' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPStructArrayCall ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPStructArrayCall () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPStructArrayCall' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPObjectArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPObjectArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPObjectArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPIntArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPIntArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPIntArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPShortArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPShortArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPShortArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPByteArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPByteArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPByteArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPLongArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPLongArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPLongArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPUIntArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPUIntArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPUIntArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPUShortArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPUShortArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPUShortArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPSByteArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPSByteArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPSByteArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPULongArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPULongArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPULongArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPIntArrayLength ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPIntArrayLength () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPIntArrayLength' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPIntArrayZeroLength ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPIntArrayZeroLength () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPIntArrayZeroLength' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPIntJaggedMultidimensionalArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedMultidimensionalArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedMultidimensionalArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPIntJaggedArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPIntJaggedArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPShortJaggedArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPShortJaggedArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPShortJaggedArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPByteJaggedArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPByteJaggedArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPByteJaggedArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPLongJaggedArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPLongJaggedArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPLongJaggedArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPULongJaggedArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPULongJaggedArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPULongJaggedArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPSByteJaggedArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPSByteJaggedArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPSByteJaggedArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPUShortJaggedArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPUShortJaggedArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPUShortJaggedArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPUIntJaggedArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPUIntJaggedArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPUIntJaggedArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPIntMultidimensionalArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPShortMultidimensionalArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPShortMultidimensionalArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPShortMultidimensionalArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPByteMultidimensionalArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPByteMultidimensionalArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPByteMultidimensionalArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPLongMultidimensionalArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPLongMultidimensionalArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPLongMultidimensionalArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPUIntMultidimensionalArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPUIntMultidimensionalArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPUIntMultidimensionalArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPUShortMultidimensionalArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPUShortMultidimensionalArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPUShortMultidimensionalArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPSByteMultidimensionalArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPSByteMultidimensionalArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPSByteMultidimensionalArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPULongMultidimensionalArray ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPULongMultidimensionalArray () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPULongMultidimensionalArray' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Array_CMPIntMultidimensionalArrayLength ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArrayLength () == 1, "'SharpOS.Kernel.Tests.CS.Array.CMPIntMultidimensionalArrayLength' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleAND ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleAND () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleAND' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleOR ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleOR () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleOR' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleXOR ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleXOR () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleXOR' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleNot ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleNot () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleNot' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleShiftLeft ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftLeft () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftLeft' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPUnsignedShiftLeft ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPUnsignedShiftLeft () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPUnsignedShiftLeft' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleShiftRight ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftRight () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftRight' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Boolean_CMPSimpleAnd ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleAnd () == 1, "'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleAnd' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Boolean_CMPSimpleOr ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleOr () == 1, "'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleOr' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Boolean_CMPSimpleNot ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleNot () == 1, "'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleNot' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BooleanOrderOfOperations_CMPConstants ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPConstants () == 1, "'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPConstants' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BooleanOrderOfOperations_CMPValues ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValues () == 1, "'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValues' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BooleanOrderOfOperations_CMPValuesAndConstants ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValuesAndConstants () == 1, "'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValuesAndConstants' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Boxing_CMPBoxUnbox ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Boxing.CMPBoxUnbox () == 1, "'SharpOS.Kernel.Tests.CS.Boxing.CMPBoxUnbox' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Boxing_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Boxing.CMP2 () == 1, "'SharpOS.Kernel.Tests.CS.Boxing.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_ByteString_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.ByteString.CMP0 () == 1, "'SharpOS.Kernel.Tests.CS.ByteString.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_ConditionalOperator_CMPQuestionOperator1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator1 () == 1, "'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_ConditionalOperator_CMPQuestionOperator2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator2 () == 1, "'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_ConditionalOperator_CMPQuestionOperator3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator3 () == 1, "'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_ConditionalOperator_CMPQuestionOperator4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator4 () == 1, "'SharpOS.Kernel.Tests.CS.ConditionalOperator.CMPQuestionOperator4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPLiteralToInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToInt () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPIntToLiteral ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPIntToLiteral () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPIntToLiteral' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPIntConstantComparison ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPIntConstantComparison () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPIntConstantComparison' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPIntValueComparison ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPIntValueComparison () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPIntValueComparison' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPSimpleIntFlags ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPSimpleIntFlags () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPSimpleIntFlags' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPIntEnumReturn ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPIntEnumReturn () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPIntEnumReturn' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPLiteralToULong ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToULong () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToULong' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPULongToLiteral ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPULongToLiteral () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPULongToLiteral' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPULongConstantComparison ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPULongConstantComparison () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPULongConstantComparison' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPULongValueComparison ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPULongValueComparison () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPULongValueComparison' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPSimpleULongFlags ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPSimpleULongFlags () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPSimpleULongFlags' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPULongEnumReturn ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPULongEnumReturn () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPULongEnumReturn' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Equals_CMPInt32EqualsInt32 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32 () == 1, "'SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Equals_CMPInt32EqualsInt32Object ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32Object () == 1, "'SharpOS.Kernel.Tests.CS.Equals.CMPInt32EqualsInt32Object' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Equals_CMPInt32ObjectEqualsInt32Object ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Equals.CMPInt32ObjectEqualsInt32Object () == 1, "'SharpOS.Kernel.Tests.CS.Equals.CMPInt32ObjectEqualsInt32Object' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPFinally ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPFinally2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally2 () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPFinally2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPCatch ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPCatch2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch2 () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPCatch3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch3 () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatch3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPCatchDivideError ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPCatchDivideError () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPCatchDivideError' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPTryCatchFinally1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally1 () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPTryCatchFinally2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally2 () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPTryCatchFinally3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally3 () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPTryCatchFinally4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally4 () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPTryCatchFinally5 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally5 () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPTryCatchFinally5' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Exceptions_CMPRethrow ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Exceptions.CMPRethrow () == 1, "'SharpOS.Kernel.Tests.CS.Exceptions.CMPRethrow' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Generics_CMPGenericMethod ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Generics.CMPGenericMethod () == 1, "'SharpOS.Kernel.Tests.CS.Generics.CMPGenericMethod' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Generics_CMPGenericType ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Generics.CMPGenericType () == 1, "'SharpOS.Kernel.Tests.CS.Generics.CMPGenericType' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Generics_CMPGenericTypeTwo ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwo () == 1, "'SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwo' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Generics_CMPGenericTypeTwoVirtualMethods ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwoVirtualMethods () == 1, "'SharpOS.Kernel.Tests.CS.Generics.CMPGenericTypeTwoVirtualMethods' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Generics_CMPSubGenericType ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Generics.CMPSubGenericType () == 1, "'SharpOS.Kernel.Tests.CS.Generics.CMPSubGenericType' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPCallInherited ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallInherited () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallInherited' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPCallProxiedInherited ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallProxiedInherited () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallProxiedInherited' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPCallOverriddenInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenInt () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPCallOverriddenEnum ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenEnum () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallOverriddenEnum' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPCallShadowedMember ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMember () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMember' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPCallShadowedMemberFromBase ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMemberFromBase () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPCallShadowedMemberFromBase' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPObjectIsValueType ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsValueType () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsValueType' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPObjectIsClass ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsClass () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPObjectIsClass' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPIsInst ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPIsInst () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPIsInst' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPTypeSafeIsInst ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeIsInst () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeIsInst' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPCastClass ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPCastClass () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPCastClass' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Inheritance_CMPTypeSafeCastClass ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeCastClass () == 1, "'SharpOS.Kernel.Tests.CS.Inheritance.CMPTypeSafeCastClass' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPInterfaceImplementationInherited ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPInterfaceImplementationInherited () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPInterfaceImplementationInherited' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPBasic ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPBasic () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPBasic' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPExplicitImplementation ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPExplicitImplementation2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation2 () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPExplicitImplementation2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPPointerMethod ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPPointerMethod () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPPointerMethod' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPOverrides1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPOverrides1 () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPOverrides1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPOverrides2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPOverrides2 () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPOverrides2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPOverrides3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPOverrides3 () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPOverrides3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPGetProperty ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPGetProperty () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPGetProperty' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPCallGet100 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPCallGet100 () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPCallGet100' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPCallChosenInterface1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface1 () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPCallChosenInterface2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface2 () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPCallChosenInterface2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPIsOperator ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Interface_CMPIsOperator2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator2 () == 1, "'SharpOS.Kernel.Tests.CS.Interface.CMPIsOperator2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Misc_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Misc.CMP1 () == 1, "'SharpOS.Kernel.Tests.CS.Misc.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Misc_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Misc.CMP2 () == 1, "'SharpOS.Kernel.Tests.CS.Misc.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Misc_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Misc.CMP0 () == 1, "'SharpOS.Kernel.Tests.CS.Misc.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Misc_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Misc.CMP3 () == 1, "'SharpOS.Kernel.Tests.CS.Misc.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Misc_CMP4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Misc.CMP4 () == 1, "'SharpOS.Kernel.Tests.CS.Misc.CMP4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Misc_CMPPhiIndexBug ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Misc.CMPPhiIndexBug () == 1, "'SharpOS.Kernel.Tests.CS.Misc.CMPPhiIndexBug' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUInt2SByte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2SByte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2SByte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPInt2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUInt2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPByte2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Int () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPSByte2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2UInt () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPByte2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Short () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPSByte2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2Short () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPShort2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUShort2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUShort2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Int () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPShort2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2UInt () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUInt2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Short () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPInt2UShort ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2UShort () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2UShort' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Short () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Int () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2Long ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Long () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Long' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2SByte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2SByte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2SByte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2UShort ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UShort () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UShort' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UInt () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2ULong ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2ULong () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2ULong' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Objects_CMPFieldNullReference ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Objects.CMPFieldNullReference () == 1, "'SharpOS.Kernel.Tests.CS.Objects.CMPFieldNullReference' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Objects_CMPMethodNullReference ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Objects.CMPMethodNullReference () == 1, "'SharpOS.Kernel.Tests.CS.Objects.CMPMethodNullReference' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Objects_CMPCreateObject ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Objects.CMPCreateObject () == 1, "'SharpOS.Kernel.Tests.CS.Objects.CMPCreateObject' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Objects_CMPOverrideObject ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Objects.CMPOverrideObject () == 1, "'SharpOS.Kernel.Tests.CS.Objects.CMPOverrideObject' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Objects_CMPDefaultToString ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Objects.CMPDefaultToString () == 1, "'SharpOS.Kernel.Tests.CS.Objects.CMPDefaultToString' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Objects_CMPIsOperator ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Objects.CMPIsOperator () == 1, "'SharpOS.Kernel.Tests.CS.Objects.CMPIsOperator' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_OrderOfOperations_CMPConstants ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPConstants () == 1, "'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPConstants' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_OrderOfOperations_CMPValues ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValues () == 1, "'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValues' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_OrderOfOperations_CMPValuesAndConstants ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValuesAndConstants () == 1, "'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValuesAndConstants' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPVoidP2ByteP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ByteP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ByteP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPVoidP2ShortP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ShortP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ShortP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPVoidP2IntP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2IntP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2IntP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPVoidP2LongP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2LongP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2LongP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPByteP2VoidP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPByteP2VoidP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPByteP2VoidP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPShortP2VoidP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPShortP2VoidP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPShortP2VoidP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPIntP2VoidP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPIntP2VoidP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPIntP2VoidP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPLongP2VoidP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPLongP2VoidP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPLongP2VoidP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPInt2SByte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2SByte () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2SByte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPSByte2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Int () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPSByte2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Short () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPShort2SByte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2SByte () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2SByte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPShort2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2Int () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPInt2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2Short () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPLong2SByte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPLong2SByte () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPLong2SByte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_StaticConstructor_CMPStaticConstructor ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.StaticConstructor.CMPStaticConstructor () == 1, "'SharpOS.Kernel.Tests.CS.StaticConstructor.CMPStaticConstructor' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPGetLength ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPGetLength () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPGetLength' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPGetChars ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPGetChars () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPGetChars' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPGetChars2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPGetChars2 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPGetChars2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPBumperIndexing1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing1 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPBumperIndexing2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing2 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPBumperLength ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPBumperLength () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPBumperLength' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPCStringStub1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPCStringStub1 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPCStringStub1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPCStringPass1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPCStringPass1 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPCStringPass1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPConstIndexing3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPConstIndexing3 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPConstIndexing3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPConcat ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPConcat () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPConcat' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPSubString ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPSubString () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPSubString' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPSubString2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPSubString2 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPSubString2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPIndexOf ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPIndexOf () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPIndexOf' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPLastIndexOf ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPLastIndexOf () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPLastIndexOf' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPConstructor ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPConstructor () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPConstructor' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPStructPointer ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPStructPointer2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer2 () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPEmptyStruct ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPEmptyStruct () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPEmptyStruct' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPStructParameter ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPStructParameter () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPStructParameter' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPNoChanges ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPNoChanges () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPNoChanges' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPCopy ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPCopy () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPCopy' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPReturn ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPReturn () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPReturn' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPSizeof1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPSizeof1 () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPSizeof1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPSizeof2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPSizeof2 () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPSizeof2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPPrivateStatic ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPPrivateStatic () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPPrivateStatic' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMP0 () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMP1 () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMP2 () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMP3 () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMPMisc2a ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMPMisc2a () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2a' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMPMisc2b ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMPMisc2b () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2b' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMPMisc2c ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMPMisc2c () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2c' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UInt32_CMPToString ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UInt32.CMPToString () == 1, "'SharpOS.Kernel.Tests.CS.UInt32.CMPToString' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UInt32_CMPToString2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UInt32.CMPToString2 () == 1, "'SharpOS.Kernel.Tests.CS.UInt32.CMPToString2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPUInt2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2Byte () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPByte2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UInt () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPByte2UShort ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UShort () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UShort' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPUShort2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2Byte () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPUShort2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2UInt () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPUInt2UShort ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2UShort () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2UShort' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPULong2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPULong2Byte () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPULong2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_WhileLoop_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.WhileLoop.CMP0 () == 1, "'SharpOS.Kernel.Tests.CS.WhileLoop.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_X86_CMPPushArgument ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.X86.CMPPushArgument () == 1, "'SharpOS.Kernel.Tests.CS.X86.CMPPushArgument' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_X86_CMPReadArgument ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.X86.CMPReadArgument () == 1, "'SharpOS.Kernel.Tests.CS.X86.CMPReadArgument' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_X86_CMPLabelHandling ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.X86.CMPLabelHandling () == 1, "'SharpOS.Kernel.Tests.CS.X86.CMPLabelHandling' failed.");
	}
}
