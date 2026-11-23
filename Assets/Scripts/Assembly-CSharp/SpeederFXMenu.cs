using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class SpeederFXMenu : MonoBehaviour
{
	private ParticleSystem[] _particleSystems;

	private Renderer[] _renderes;

	private TrailRenderer[] _trailRenderes;

	private unsafe void Awake()
	{
		//IL_000f: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_007d: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		Renderer[] renderes = _renderes;
		if (renderes.Length != 0)
		{
			object obj = renderes.Length;
			object obj2 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)renderes + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v49+10]");
				((Renderer)0).enabled = false;
				object obj5 = obj2 + 1;
				obj = renderes.Length;
				obj2 = obj5;
			}
		}
		TrailRenderer[] trailRenderes = _trailRenderes;
		if (trailRenderes.Length != 0)
		{
			object obj6 = trailRenderes.Length;
			object obj7 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				object obj8 = obj7 << 2;
				object obj9 = (object)trailRenderes + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v38+10]");
				((Renderer)0).enabled = false;
				object obj10 = obj7 + 1;
				obj6 = trailRenderes.Length;
				obj7 = obj10;
			}
		}
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(SpeederFXMenu.HandleOnSpeederStart));
		Delegate obj11 = Delegate.Combine(instance.OnSpeederStart, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onSpeederStart = default;
		instance.OnSpeederStart = onSpeederStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(SpeederFXMenu.HandleOnSpeederEnd));
		Delegate obj12 = Delegate.Combine(instance2.OnSpeederEnd, action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onSpeederEnd = default;
		instance2.OnSpeederEnd = onSpeederEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private unsafe void OnDestroy()
	{
		HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
		if (instance != null)
		{
			HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(SpeederFXMenu.HandleOnSpeederStart));
			Delegate obj = Delegate.Remove(instance2.OnSpeederStart, action);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			Action onSpeederStart = default;
			instance2.OnSpeederStart = onSpeederStart;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			HoverboardModelPreviewFactory instance3 = HoverboardModelPreviewFactory.Instance;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(SpeederFXMenu.HandleOnSpeederEnd));
			Delegate obj2 = Delegate.Remove(instance3.OnSpeederEnd, action2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			Action onSpeederEnd = default;
			instance3.OnSpeederEnd = onSpeederEnd;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
	}

	private void HandleOnSpeederStart()
	{
		//IL_0032: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I4
		ParticleSystem[] particleSystems = _particleSystems;
		if (particleSystems.Length != 0)
		{
			object obj = 0;
			object obj2 = particleSystems.Length;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object obj3 = obj << 2;
				object obj4 = (object)particleSystems + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v43+10]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: false);
				object obj5 = obj + 1;
				obj = obj5;
				obj2 = particleSystems.Length;
			}
		}
		Renderer[] renderes = _renderes;
		if (renderes.Length != 0)
		{
			object obj6 = 0;
			object obj7 = renderes.Length;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				object obj8 = obj6 << 2;
				object obj9 = (object)renderes + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v32+10]");
				((Renderer)0).enabled = true;
				object obj10 = obj6 + 1;
				obj6 = obj10;
				obj7 = renderes.Length;
			}
		}
		TrailRenderer[] trailRenderes = _trailRenderes;
		if (trailRenderes.Length != 0)
		{
			object obj11 = 0;
			object obj12 = trailRenderes.Length;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				object obj13 = obj11 << 2;
				object obj14 = (object)trailRenderes + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v21+10]");
				((Renderer)0).enabled = true;
				object obj15 = obj11 + 1;
				obj11 = obj15;
				obj12 = trailRenderes.Length;
			}
		}
	}

	private void HandleOnSpeederEnd()
	{
		//IL_0032: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_0120: Expected Obj, but got I4
		//IL_012a: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got I4
		ParticleSystem[] particleSystems = _particleSystems;
		if (particleSystems.Length != 0)
		{
			object obj = 0;
			object obj2 = particleSystems.Length;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object obj3 = obj << 2;
				object obj4 = (object)particleSystems + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v43+10]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: true);
				object obj5 = obj + 1;
				obj = obj5;
				obj2 = particleSystems.Length;
			}
		}
		Renderer[] renderes = _renderes;
		if (renderes.Length != 0)
		{
			object obj6 = 0;
			object obj7 = renderes.Length;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				object obj8 = obj6 << 2;
				object obj9 = (object)renderes + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v32+10]");
				((Renderer)0).enabled = false;
				object obj10 = obj6 + 1;
				obj6 = obj10;
				obj7 = renderes.Length;
			}
		}
		TrailRenderer[] trailRenderes = _trailRenderes;
		if (trailRenderes.Length != 0)
		{
			object obj11 = 0;
			object obj12 = trailRenderes.Length;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				object obj13 = obj11 << 2;
				object obj14 = (object)trailRenderes + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v21+10]");
				((Renderer)0).enabled = false;
				object obj15 = obj11 + 1;
				obj11 = obj15;
				obj12 = trailRenderes.Length;
			}
		}
	}
}
