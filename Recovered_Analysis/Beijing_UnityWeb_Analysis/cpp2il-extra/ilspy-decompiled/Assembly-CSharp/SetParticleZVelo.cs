using System;
using Cpp2ILInjected;
using NaughtyAttributes;
using SYBO.Subway;
using UnityEngine;

public class SetParticleZVelo : MonoBehaviour
{
	private float _speedMultiplier;

	private ParticleSystem _particleSystem;

	private Game _game;

	private void Awake()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_007c: Expected Obj, but got VT
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = this + 16;
		string text = tag;
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)(object)text).GetComponentInChildren<T>();
		obj = componentInChildren;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v8 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 20;
		bool isInstantiated = Game.IsInstantiated;
		obj3 = isInstantiated;
	}

	public SetParticleZVelo()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I4
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0172: Expected I, but got F4
		//IL_0021: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		//IL_00c2: Expected I, but got F4
		MaxValueAttribute maxValueAttribute = default;
		object obj = maxValueAttribute - -64;
		object obj2 = maxValueAttribute + 24;
		obj2 = 0;
		GameObject gameObject = base.gameObject;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v33 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		Transform transform = (Transform)(maxValueAttribute + 32);
		transform = (Transform)(object)maxValueAttribute;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)maxValueAttribute.maxValue;
		Quaternion localRotation = transform.localRotation;
		if (_speedMultiplier > 0f)
		{
			obj = 0;
			obj2 = _particleSystem;
			maxValueAttribute._002Ector(_game.__currentSpeed * _speedMultiplier);
			transform = (Transform)(object)maxValueAttribute;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)maxValueAttribute.maxValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (NaughtyAttributes.MaxValueAttribute)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11754");
		}
	}
}
