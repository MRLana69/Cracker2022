using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class FanFoldOut : CharacterCustomizationProp
{
	private sealed class _003CPlay_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FanFoldOut _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Expected Obj, but got Unknown
				//IL_0137: Expected Obj, but got I4
				//IL_017e: Expected Obj, but got I4
				//IL_0106: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Expected Obj, but got Unknown
				FanFoldOut fanFoldOut = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						fanFoldOut._foldIn.shadowCastingMode = ShadowCastingMode.Off;
						fanFoldOut._foldOut.shadowCastingMode = ShadowCastingMode.On;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				CharacterRig characterRig = fanFoldOut._characterRig;
				AnimationState animationState = characterRig.characterAnimation.get_Item(fanFoldOut._requiredAnimationName);
				if ((object)animationState != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = fanFoldOut._flipTime;
					object obj = this + 12;
					object obj2 = default;
					obj = obj2;
					_003C_003E1__state = 2;
				}
				else
				{
					object obj3 = this + 12;
					obj3 = 0;
					_003C_003E1__state = 1;
				}
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private float _flipTime;

	private Renderer _foldIn;

	private Renderer _foldOut;

	private string _requiredAnimationName;

	private CharacterRig _characterRig;

	public override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_00ec: Expected I, but got Obj
		GameObject gameObject = base.gameObject;
		GameObject parentInternal = characterRig.attachPoint1.gameObject;
		((Transform)(object)gameObject).parentInternal = (Transform)(object)parentInternal;
		GameObject gameObject2 = base.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v39 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 32;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj3 + 48);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v14+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject3 = base.gameObject;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v21 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v35 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj3 + 16;
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj5;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v26+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		GameObject gameObject4 = base.gameObject;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject4).parent = transform;
	}

	private IEnumerator Play()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}
}
