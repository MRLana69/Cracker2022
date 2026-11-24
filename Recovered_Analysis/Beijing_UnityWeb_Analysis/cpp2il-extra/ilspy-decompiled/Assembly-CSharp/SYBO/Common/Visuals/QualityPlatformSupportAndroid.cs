using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities.Flags;
using SYBO.Components.Utilities.Validators;

namespace SYBO.Common.Visuals;

public class QualityPlatformSupportAndroid : IQualityPlatformSupport
{
	private enum AndroidQualityCategory
	{
		HighPerformanceDevice
	}

	private Dictionary<QualityFeature, AndroidQualityCategory> _qualityFeatureCategory;

	private Dictionary<AndroidQualityCategory, bool> _qualityCategorySupport;

	public void Initialize()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 16;
		object obj2 = default;
		obj = obj2;
		((Validator<>)this)._002Ector();
	}

	public bool IsSupported(QualityFeature feature)
	{
		//IL_001a: Expected Obj, but got I4
		//IL_001a: Expected Obj, but got I
		//IL_001e: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Visuals.QualityPlatformSupportAndroid)+10]");
		return (byte)(int)Enumerable.OrderByDescending<TSource, TKey>((IEnumerable<TSource>)0, (Func<TSource, TKey>)feature) != 0;
	}

	public unsafe QualityPlatformSupportAndroid()
	{
		//IL_000e: Expected Obj, but got Ref
		//IL_0234: Expected Obj, but got Ref
		//IL_023d: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got Ref
		//IL_026d: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_0312: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I
		//IL_0332: Expected Obj, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		ref _0021_00210 reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 48));
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 24));
		obj2 = 0;
		_ = 0;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11 (Il2CppClass<DeviceInfo>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v53 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S2_v3 (System.Int32)+8]");
		bool flag = (nint)0 >= (nint)2;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S4_v3+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S4_v4+48]");
		object obj7 = 0;
		object obj8 = obj7 & 0x7FF;
		object obj9 = obj8 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S5_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
		_0021_00210 flag2 = default;
		FlagsHelper.Set<T>(ref System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (T)flag2);
		obj2 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+8]");
		_ = 0;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		}
		object obj11 = obj3 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj3 + obj13;
		obj14 = 75;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj3 + obj15;
			if ((nint)obj16 == 75)
			{
				object obj17 = obj3 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				return;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
