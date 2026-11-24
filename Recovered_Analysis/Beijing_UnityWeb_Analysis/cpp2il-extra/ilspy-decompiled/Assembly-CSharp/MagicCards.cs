using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class MagicCards : CharacterCustomizationProp
{
	private sealed class _003CPlay_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public MagicCards _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0339: Unknown result type (might be due to invalid IL or missing references)
				//IL_033e: Expected Obj, but got Unknown
				//IL_0347: Expected Obj, but got I4
				//IL_038e: Expected Obj, but got I4
				//IL_0316: Unknown result type (might be due to invalid IL or missing references)
				//IL_031b: Expected Obj, but got Unknown
				//IL_0167: Unknown result type (might be due to invalid IL or missing references)
				//IL_016c: Expected Obj, but got Unknown
				//IL_0188: Expected Obj, but got I4
				//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01de: Expected Obj, but got Unknown
				//IL_01fa: Expected Obj, but got I4
				//IL_024b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0250: Expected Obj, but got Unknown
				//IL_026c: Expected Obj, but got I4
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
										magicCards._card2.shadowCastingMode = ShadowCastingMode.Off;
										magicCards._card3.shadowCastingMode = ShadowCastingMode.Off;
										return null;
									}
									return null;
								}
								_003C_003E1__state = -1;
								magicCards._card2.shadowCastingMode = ShadowCastingMode.On;
								magicCards._card3.shadowCastingMode = ShadowCastingMode.On;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								_ = 1.28f;
								object obj = this + 12;
								object obj2 = default;
								obj = obj2;
								_003C_003E1__state = 5;
								return 1;
							}
							_003C_003E1__state = -1;
							magicCards._card1.shadowCastingMode = ShadowCastingMode.Off;
							magicCards._card4.shadowCastingMode = ShadowCastingMode.Off;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							_ = 0.4f;
							object obj3 = this + 12;
							object obj4 = default;
							obj3 = obj4;
							_003C_003E1__state = 4;
							return 1;
						}
						_003C_003E1__state = -1;
						magicCards._card1.shadowCastingMode = ShadowCastingMode.On;
						magicCards._card4.shadowCastingMode = ShadowCastingMode.On;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.96f;
						object obj5 = this + 12;
						object obj6 = default;
						obj5 = obj6;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					magicCards._card1.shadowCastingMode = ShadowCastingMode.Off;
					magicCards._card2.shadowCastingMode = ShadowCastingMode.Off;
					magicCards._card3.shadowCastingMode = ShadowCastingMode.Off;
					magicCards._card4.shadowCastingMode = ShadowCastingMode.Off;
				}
				CharacterRig characterRig = magicCards._characterRig;
				AnimationState animationState = characterRig.characterAnimation.get_Item(magicCards._requiredAnimationName);
				if ((object)animationState != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 1.32f;
					object obj7 = this + 12;
					object obj8 = default;
					obj7 = obj8;
					_003C_003E1__state = 2;
				}
				else
				{
					object obj9 = this + 12;
					obj9 = 0;
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

	private Renderer _card1 = (Renderer)0.2f;

	private Renderer _card2;

	private Renderer _card3;

	private Renderer _card4;

	private CharacterRig _characterRig;

	private string _requiredAnimationName;

	public override void Initialize(CharacterRig characterRig, bool alternateSetup)
	{
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_00e2: Expected I, but got Obj
		object obj = this + 28;
		obj = characterRig;
		GameObject gameObject = base.gameObject;
		((Transform)(object)gameObject).parentInternal = characterRig.rightHand;
		GameObject gameObject2 = base.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v44 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 32;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj4 + 48);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject3 = base.gameObject;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v22 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v40 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj4 + 16;
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj6;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v27+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		GameObject gameObject4 = base.gameObject;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj4;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject4).parent = transform;
		if (alternateSetup)
		{
			_card3.shadowCastingMode = ShadowCastingMode.On;
			return;
		}
		IEnumerator routine = Play();
		Coroutine coroutine = StartCoroutine_Auto(routine);
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

	public MagicCards()
	{
		//IL_0010: Expected Obj, but got F4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = "";
		base._002Ector();
	}
}
