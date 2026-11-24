using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using SYBO.Common.Visuals;
using SYBO.Components.Analytics;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Themes;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Common.Utilities;

public class SyboRandom
{
	private IRandomGen _randomGen;

	public static IRandomGen MakeRandomGen()
	{
		//IL_0066: Expected I4, but got Obj
		//IL_0066: Expected I4, but got Obj
		//IL_0034: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I4
		string graphicsDeviceVersion = SystemInfo.GetGraphicsDeviceVersion();
		string text = graphicsDeviceVersion.ToLowerInvariant();
		string text2 = text.Remove((int)"(tm)", (int)string.Empty);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		System.Text.RegularExpressions.ExclusiveReference exclusiveReference = default;
		exclusiveReference.Release((object)"[^a-z0-9]");
		return (IRandomGen)((System.Text.RegularExpressions.RegexBoyerMoore)(object)exclusiveReference).MatchPattern(text2, (int)"");
	}

	public SyboRandom()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public unsafe SyboRandom(IRandomGen randomGen)
	{
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_019a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		Collider collider = default;
		object obj = collider + 24;
		obj = 0;
		_ = 0;
		_ = 0;
		Collider component = ((GameObject)(object)randomGen).GetComponent<Collider>();
		Renderer component2 = ((GameObject)(object)randomGen).GetComponent<Renderer>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			collider.get_bounds_Injected(out *(Bounds*)component);
			obj = collider;
			_ = ((UnityEngine.Object)collider).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Collider)+10]");
			_ = 0;
		}
		else
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				((Renderer)(object)collider).SetMaterial((Material)(object)component2);
				obj = collider;
				_ = ((UnityEngine.Object)collider).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Collider)+10]");
				_ = 0;
			}
		}
		SyboRandom syboRandom = (SyboRandom)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_randomGen = (IRandomGen)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
	}

	public void SetGenerator(IRandomGen randomGen)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = randomGen;
	}

	public unsafe uint NextUint()
	{
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected I, but got Unknown
		//IL_022f: Expected I, but got Obj
		//IL_024b: Expected Obj, but got I4
		//IL_0060: Expected I4, but got Obj
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_00c0: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0101: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v20 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(MeshRenderer);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type methodName = Type.internal_from_handle((IntPtr)num3);
		Coroutine coroutine = ((MonoBehaviour)this).StartCoroutine((string)(object)methodName, (object)1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		IList<CombineableMesh> list = default;
		uint result = (uint)(int)MeshUtil.CombineMeshes((GameObject)(object)this, list);
		object obj2 = list + 12;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = list + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			string tag = ((Component)obj6).tag;
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S2_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)tag).FindKernel((string)(object)this) != 0)
			{
				((Renderer)obj6).shadowCastingMode = ShadowCastingMode.Off;
			}
			object obj8 = obj3 + 1;
			obj3 = obj8;
		}
		return result;
	}

	public float NextFloat()
	{
		float framerate = ((FramerateTracker)_randomGen).GetFramerate();
		return framerate * 1000f;
	}

	public float Value()
	{
		bool flag = Bool();
		return (float)(flag ? 1 : 0) * 2.3283064E-10f;
	}

	public bool Bool()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		bool result = default;
		return result;
	}

	public int Range(int min, int max)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 20;
		obj = this;
		object obj2 = num + 16;
		obj2 = min;
		object obj3 = num + 24;
		obj3 = max;
		return num;
	}

	public float Range(float min, float max)
	{
		if (!(max > min))
		{
			return min;
		}
		float num = ((SYBO.Components.Analytics.SyboRandom)this).Value();
		float num2 = max - min;
		float num3 = num * num2;
		return num3 + min;
	}

	public T RandomElement<T>(T[] array)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_013d: Expected VT, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		object obj = 0;
		nint num = default;
		object obj2 = num + 12;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v6+18]");
		object obj5 = 0;
		object obj6 = obj5 & 0x3FFF;
		object obj7 = obj6 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S2_v5 (should have been resolved before IL gen)");
		object obj8 = default;
		if (obj8 != null)
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v5+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S3_v6+1C]");
			object obj11 = 0;
			object obj12 = obj11 & 0x1FFF;
			object obj13 = obj12 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S4_v5 (should have been resolved before IL gen)");
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S3_v9+60]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S3_v10+20]");
			object obj16 = 0;
			object obj17 = obj16 & 0x1FFF;
			object obj18 = obj17 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S4_v9 (should have been resolved before IL gen)");
			T result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return (T)obj;
	}

	public T RandomElementNoRepeats<T>(T[] array, T lastPickedElement) where T : class
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0017: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_028b: Expected Obj, but got I
		//IL_029b: Expected Obj, but got I
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_015d: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_0230: Expected Obj, but got I
		//IL_0240: Expected Obj, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_01b9: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected Obj, but got Unknown
		object result = 0;
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v6+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v7+24]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S2_v6 (should have been resolved before IL gen)");
		object obj7 = 0;
		object obj13 = default;
		object obj25 = default;
		object obj31 = default;
		while (true)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v9+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S2_v10+18]");
			object obj10 = 0;
			object obj11 = obj10 & 0x3FFF;
			object obj12 = obj11 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v66 @ S3_v7 (should have been resolved before IL gen)");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
			{
				object obj14 = obj7 + 1;
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S3_v10+60]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S3_v11+1C]");
				object obj17 = 0;
				object obj18 = obj17 & 0x1FFF;
				object obj19 = obj18 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S4_v8 (should have been resolved before IL gen)");
				object obj20 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S3_v14+60]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S3_v15+28]");
				object obj22 = 0;
				object obj23 = obj22 & 0x1FFF;
				object obj24 = obj23 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v100 @ S4_v12 (should have been resolved before IL gen)");
				if (obj25 == null)
				{
					object obj26 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S3_v19+60]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S3_v20+2C]");
					object obj28 = 0;
					object obj29 = obj28 & 0x1FFF;
					object obj30 = obj29 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v118 @ S4_v17 (should have been resolved before IL gen)");
					if (obj31 != null)
					{
						break;
					}
					object obj32 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S3_v27+60]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S3_v28+30]");
					object obj34 = 0;
					object obj35 = obj34 & 0x1FFF;
					object obj36 = obj35 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v121 @ S4_v25 (should have been resolved before IL gen)");
				}
				obj7 = obj14;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			return (T)result;
		}
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S3_v23+60]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S3_v24+20]");
		object obj39 = 0;
		object obj40 = obj39 & 0x1FFF;
		object obj41 = obj40 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v153 @ S4_v21 (should have been resolved before IL gen)");
		T result2 = default;
		return result2;
	}

	public unsafe T RandomElementNoRepeats<T>(IList<T> array, T lastPickedElement) where T : class
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		object obj = array + 12;
		T result;
		if ((nint)obj == 1)
		{
			object obj2 = array + 16;
			result = (T)obj2;
		}
		else
		{
			object obj3 = obj << 1;
			object obj8;
			do
			{
				object obj4 = array + 16;
				bool flag = ((Theme)this).TryGetDevicePerformanceRelativeMaterial((Material)null, out *(Material*)obj);
				object obj5 = (flag ? 1u : 0u) << 2;
				object obj6 = obj4 + obj5;
				bool flag2 = obj6 == lastPickedElement;
				object obj7 = 0 + 1;
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
				obj8 = flag2 & flag3;
				result = (T)obj6;
			}
			while (obj8 != null);
		}
		return result;
	}

	public unsafe T RandomElement<T>(IList<T> array)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0045: Expected VT, but got Obj
		object obj = array + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [array @ L1 (System.Collections.Generic.IList`1<T>)+C]");
		bool flag = ((Theme)this).TryGetDevicePerformanceRelativeMaterial((Material)null, out *(Material*)null);
		object obj2 = (flag ? 1u : 0u) << 2;
		object obj3 = obj + obj2;
		return (T)obj3;
	}

	public int RandomElementIndex<T>(ICollection<T> array)
	{
		//IL_000e: Expected Obj, but got I
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		ref Material performanceRelative = default;
		bool flag = ((Theme)this).TryGetDevicePerformanceRelativeMaterial((Material)null, out performanceRelative);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		int result = default;
		return result;
	}

	public void Shuffle<T>(IList<T> list)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00ad: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		nint num = default;
		object obj3 = num + 24;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new NullReferenceException();
	}
}
