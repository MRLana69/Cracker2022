using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class FanFoldOut : CharacterCustomizationProp
{
	private sealed class _003CPlay_003Ed__6(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FanFoldOut _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			FanFoldOut fanFoldOut = _003C_003E4__this;
			if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
			{
				if (_003C_003E1__state == 2)
				{
					_003C_003E1__state = -1;
					fanFoldOut._foldIn.enabled = false;
					fanFoldOut._foldOut.enabled = true;
				}
				return false;
			}
			_003C_003E1__state = -1;
			CharacterRig characterRig = fanFoldOut._characterRig;
			if (characterRig.characterAnimation.IsPlaying(fanFoldOut._requiredAnimationName))
			{
				_ = fanFoldOut._flipTime;
				object obj = default;
				_003C_003E2__current = obj;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private float _flipTime = 0.2f;

	private Renderer _foldIn;

	private Renderer _foldOut;

	private string _requiredAnimationName = string.Empty;

	private CharacterRig _characterRig;

	public unsafe override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008e: Expected I, but got Obj
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected VT, but got Unknown
		//IL_0103: Expected I, but got Obj
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected VT, but got Unknown
		//IL_0178: Expected I, but got Obj
		//IL_019d: Expected F4, but got I
		//IL_0198: Expected native int or pointer, but got VT
		//IL_01ab: Expected F4, but got VT
		//IL_01a6: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_characterRig = characterRig;
		Transform transform = base.transform;
		transform.parent = characterRig.rightHand;
		Transform transform2 = base.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform2.localPosition = localPosition;
		Transform transform3 = base.transform;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v29 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		transform3.localRotation = localRotation;
		Transform transform4 = base.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
		if (!alternateSetup)
		{
			IEnumerator routine = Play();
			Coroutine coroutine = StartCoroutine(routine);
		}
		else
		{
			_foldOut.enabled = true;
		}
	}

	private IEnumerator Play()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
