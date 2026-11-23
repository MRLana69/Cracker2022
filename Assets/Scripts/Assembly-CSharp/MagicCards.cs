using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class MagicCards : CharacterCustomizationProp
{
	private sealed class _003CPlay_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MagicCards _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			MagicCards magicCards = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							if (_003C_003E1__state != 4)
							{
								if (_003C_003E1__state == 5)
								{
									_003C_003E1__state = -1;
									magicCards._card2.enabled = false;
									magicCards._card3.enabled = false;
								}
								return false;
							}
							_003C_003E1__state = -1;
							magicCards._card2.enabled = true;
							magicCards._card3.enabled = true;
							_ = 1.28f;
							object obj = default;
							_003C_003E2__current = obj;
							_003C_003E1__state = 5;
							return true;
						}
						_003C_003E1__state = -1;
						magicCards._card1.enabled = false;
						magicCards._card4.enabled = false;
						_ = 0.4f;
						object obj2 = default;
						_003C_003E2__current = obj2;
						_003C_003E1__state = 4;
						return true;
					}
					_003C_003E1__state = -1;
					magicCards._card1.enabled = true;
					magicCards._card4.enabled = true;
					_ = 0.96f;
					object obj3 = default;
					_003C_003E2__current = obj3;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				magicCards._card1.enabled = false;
				magicCards._card2.enabled = false;
				magicCards._card3.enabled = false;
				magicCards._card4.enabled = false;
			}
			CharacterRig characterRig = magicCards._characterRig;
			if (characterRig.characterAnimation.IsPlaying(magicCards._requiredAnimationName))
			{
				_ = 1.32f;
				object obj4 = default;
				_003C_003E2__current = obj4;
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

	private Renderer _card1;

	private Renderer _card2;

	private Renderer _card3;

	private Renderer _card4;

	private CharacterRig _characterRig;

	private string _requiredAnimationName = string.Empty;

	public unsafe override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00d5: Expected I, but got Obj
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected VT, but got Unknown
		//IL_014a: Expected I, but got Obj
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected VT, but got Unknown
		//IL_01bf: Expected I, but got Obj
		//IL_01e4: Expected F4, but got I
		//IL_01df: Expected native int or pointer, but got VT
		//IL_01f2: Expected F4, but got VT
		//IL_01ed: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_characterRig = characterRig;
		Transform transform = base.transform;
		Transform parent = characterRig.attachPoint1.transform;
		transform.parent = parent;
		Transform transform2 = base.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v28 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v29 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
		if (!alternateSetup)
		{
			IEnumerator routine = Play();
			Coroutine coroutine = StartCoroutine(routine);
			return;
		}
		_card1.enabled = false;
		_card2.enabled = false;
		_card3.enabled = false;
		_card4.enabled = false;
	}

	private IEnumerator Play()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
