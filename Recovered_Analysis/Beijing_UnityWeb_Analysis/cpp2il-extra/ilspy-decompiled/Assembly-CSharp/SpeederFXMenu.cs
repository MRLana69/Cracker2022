using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class SpeederFXMenu : MonoBehaviour
{
	private ParticleSystem[] _particleSystems;

	private Renderer[] _renderes;

	private TrailRenderer[] _trailRenderes;

	private void Awake()
	{
		CancelInvoke();
	}

	private unsafe void OnDestroy()
	{
		//IL_0250: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_001e: Expected Obj, but got I4
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I4
		//IL_00f7: Expected I, but got Obj
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		Renderer[] renderes = _renderes;
		if (renderes.Length != 0)
		{
			object obj = _renderes + 12;
			object obj2 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = _renderes + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				((Renderer)obj5).shadowCastingMode = ShadowCastingMode.Off;
				object obj6 = obj2 + 1;
				obj2 = obj6;
			}
		}
		TrailRenderer[] trailRenderes = _trailRenderes;
		if (trailRenderes.Length != 0)
		{
			object obj7 = _trailRenderes + 12;
			object obj8 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				object obj9 = _trailRenderes + 16;
				object obj10 = obj8 << 2;
				object obj11 = obj9 + obj10;
				((Renderer)obj11).shadowCastingMode = ShadowCastingMode.Off;
				object obj12 = obj8 + 1;
				obj8 = obj12;
			}
		}
		nint num = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v14 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num2 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinMagnet instance = CoinMagnet.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj14 = default;
		obj14.method_ptr = method_ptr;
		obj14.method = (nint)__ldftn(SpeederFXMenu.HandleOnSpeederStart);
		object obj15 = obj14 + 16;
		obj15 = this;
		object obj16 = instance + 56;
		Delegate obj17 = ((Delegate)(object)instance.game).CombineImpl(obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj18 = default;
		obj16 = obj18;
		CoinMagnet instance2 = CoinMagnet.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj19 = default;
		obj19.method_ptr = method_ptr2;
		obj19.method = (nint)__ldftn(SpeederFXMenu.HandleOnSpeederEnd);
		object obj20 = obj19 + 16;
		obj20 = this;
		object obj21 = instance2 + 60;
		Delegate obj22 = ((Delegate)(object)instance2.powerDownSound).CombineImpl(obj19);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj23 = default;
		obj21 = obj23;
	}

	private unsafe void HandleOnSpeederStart()
	{
		//IL_01da: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I
		//IL_02c1: Expected I, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_00ee: Expected I, but got Obj
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		nint num = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinMagnet instance = CoinMagnet.Instance;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)instance).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v41 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinMagnet instance2 = CoinMagnet.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj4 = default;
		obj4.method_ptr = method_ptr;
		obj4.method = (nint)__ldftn(SpeederFXMenu.HandleOnSpeederStart);
		object obj5 = obj4 + 16;
		obj5 = this;
		object obj6 = instance2 + 56;
		Delegate obj7 = ((Delegate)(object)instance2.game).RemoveImpl(obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj8 = default;
		obj6 = obj8;
		CoinMagnet instance3 = CoinMagnet.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj9 = default;
		obj9.method_ptr = method_ptr2;
		obj9.method = (nint)__ldftn(SpeederFXMenu.HandleOnSpeederEnd);
		object obj10 = obj9 + 16;
		obj10 = this;
		object obj11 = instance3 + 60;
		Delegate obj12 = ((Delegate)(object)instance3.powerDownSound).RemoveImpl(obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj13 = default;
		obj11 = obj13;
	}

	private void HandleOnSpeederEnd()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0134: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		ParticleSystem[] particleSystems = _particleSystems;
		if (particleSystems.Length != 0)
		{
			object obj = _particleSystems + 12;
			object obj2 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = _particleSystems + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				string text = ((Component)obj5).tag;
				((GameObject)(object)text).tag = null;
				object obj6 = obj2 + 1;
				obj2 = obj6;
			}
		}
		Renderer[] renderes = _renderes;
		if (renderes.Length != 0)
		{
			object obj7 = _renderes + 12;
			object obj8 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				object obj9 = _renderes + 16;
				object obj10 = obj8 << 2;
				object obj11 = obj9 + obj10;
				((Renderer)obj11).shadowCastingMode = ShadowCastingMode.On;
				object obj12 = obj8 + 1;
				obj8 = obj12;
			}
		}
		TrailRenderer[] trailRenderes = _trailRenderes;
		if (trailRenderes.Length != 0)
		{
			object obj13 = _trailRenderes + 12;
			object obj14 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
			{
				object obj15 = _trailRenderes + 16;
				object obj16 = obj14 << 2;
				object obj17 = obj15 + obj16;
				((Renderer)obj17).shadowCastingMode = ShadowCastingMode.On;
				object obj18 = obj14 + 1;
				obj14 = obj18;
			}
		}
	}

	public SpeederFXMenu()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		ParticleSystem[] particleSystems = _particleSystems;
		if (particleSystems.Length != 0)
		{
			object obj = _particleSystems + 12;
			object obj2 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = _particleSystems + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				string text = ((Component)obj5).tag;
				((GameObject)(object)text).tag = (string)1;
				object obj6 = obj2 + 1;
				obj2 = obj6;
			}
		}
		Renderer[] renderes = _renderes;
		if (renderes.Length != 0)
		{
			object obj7 = _renderes + 12;
			object obj8 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				object obj9 = _renderes + 16;
				object obj10 = obj8 << 2;
				object obj11 = obj9 + obj10;
				((Renderer)obj11).shadowCastingMode = ShadowCastingMode.Off;
				object obj12 = obj8 + 1;
				obj8 = obj12;
			}
		}
		TrailRenderer[] trailRenderes = _trailRenderes;
		if (trailRenderes.Length != 0)
		{
			object obj13 = _trailRenderes + 12;
			object obj14 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
			{
				object obj15 = _trailRenderes + 16;
				object obj16 = obj14 << 2;
				object obj17 = obj15 + obj16;
				((Renderer)obj17).shadowCastingMode = ShadowCastingMode.Off;
				object obj18 = obj14 + 1;
				obj14 = obj18;
			}
		}
	}
}
