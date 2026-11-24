using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.MessageCenter;
using UnityEngine;
using UnityEngine.Networking;

public class ResumeButtonHelper : MonoBehaviour
{
	private sealed class _003CEnableButtonWhenReady_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResumeButtonHelper _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		private float _003CtimeWaited_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Expected Obj, but got Unknown
				//IL_0124: Expected Obj, but got I4
				//IL_018a: Expected I, but got Obj
				//IL_01a0: Expected Obj, but got I
				//IL_01cb: Expected I, but got Obj
				//IL_0234: Unknown result type (might be due to invalid IL or missing references)
				//IL_0239: Expected Obj, but got Unknown
				//IL_0264: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							goto IL_0152;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
					_003CtimeWaited_003E5__3 = 0f;
				}
				if (_003CtimeWaited_003E5__3 < 1f)
				{
					float maxDelay2 = NetworkServer.maxDelay;
					float num = maxDelay2 - _003CstartTime_003E5__2;
					_003CtimeWaited_003E5__3 = num;
					object obj = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					_003C_003E1__state = 1;
					return 1;
				}
				string dataPath = Application.dataPath;
				if ((nint)dataPath == 8)
				{
					goto IL_0152;
				}
				goto IL_0269;
				IL_0269:
				_003C_003E4__this.DisableButton();
				return null;
				IL_0152:
				if (_003CtimeWaited_003E5__3 < 5f)
				{
					nint num2 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v19 (Il2CppClass<SocialManager>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num3 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v31 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v24 (System.Boolean)+74]");
					if ((nint)0 == 0)
					{
						float maxDelay3 = NetworkServer.maxDelay;
						float num4 = maxDelay3 - _003CstartTime_003E5__2;
						_003CtimeWaited_003E5__3 = num4;
						object obj4 = this + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj5 = default;
						obj4 = obj5;
						_003C_003E1__state = 2;
						return 1;
					}
				}
				goto IL_0269;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CEnableButtonWhenReady_003Ed__10(int _003C_003E1__state)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected Obj, but got Unknown
			//IL_00c0: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num2 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 one = Vector2.one;
			object obj = default;
			GameObject gameObject = (GameObject)(obj + 8);
			((CharacterOwnagePopup.CharacterOwnageListAdapter)this)._002Ector((List<KeyValuePair<Characters.CharacterId, Characters.Model>>)_003C_003E1__state, (GameObject)obj);
		}

		void IDisposable.Dispose()
		{
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

	private const float MIN_WAIT_TIME = 1f;

	private const float MAX_WAIT_TIME = 5f;

	private UILabel label;

	private UIButtonOverlayOff _cachedOverlayHelper;

	private bool _buttonEnabled;

	private UIButtonOverlayOff overlayHelper => (UIButtonOverlayOff)(object)label;

	public bool isButtonEnabled
	{
		get
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected Obj, but got Unknown
			//IL_004b: Expected I4, but got Obj
			//IL_000f: Expected I4, but got Obj
			if ((object)_cachedOverlayHelper != null)
			{
				return (byte)(int)_cachedOverlayHelper != 0;
			}
			object obj = this + 16;
			string text = tag;
			UIButtonOverlayOff component = ((GameObject)(object)text).GetComponent<UIButtonOverlayOff>();
			obj = component;
			return (byte)(int)component != 0;
		}
	}

	private void OnApplicationPause(bool pause)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = pause;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		((BackBtnBehaviour)(object)new NullReferenceException())?.Update();
	}

	private IEnumerator EnableButtonWhenReady()
	{
		//IL_0019: Expected Obj, but got I4
		bool buttonEnabled = _buttonEnabled;
		return (IEnumerator)buttonEnabled;
	}

	public void EnableButton()
	{
		CancelInvoke();
	}

	public unsafe void DisableButton()
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected VT, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_0197: Expected Obj, but got VT
		//IL_01ac: Expected F4, but got Obj
		//IL_01a7: Expected native int or pointer, but got VT
		//IL_01c6: Expected F4, but got Obj
		//IL_01c1: Expected native int or pointer, but got VT
		//IL_01db: Expected F4, but got I
		//IL_01d6: Expected native int or pointer, but got VT
		//IL_01f5: Expected I4, but got VT
		//IL_01f5: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_0225: Expected I4, but got Obj
		//IL_0100: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 24);
		object obj2 = obj + 20;
		object obj3 = obj + 16;
		if (~(_buttonEnabled ? 1u : 0u) == 0)
		{
			return;
		}
		bool flag = isButtonEnabled;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v9 (Il2CppClass<GlobalColors>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v35 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = GlobalColors.FOOTER_BIG_PLAY_RESUME_COLOR;
		obj3 = obj2;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v20 (System.Boolean)+C]");
		TweenHeight tweenHeight = TweenHeight.Begin((UIWidget)0, 0f, (int)matrix4x);
		bool flag2 = isButtonEnabled;
		((UIButtonOverlayOff)flag2).GoToNotAvailableState();
		_buttonEnabled = true;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v24 (Il2CppClass<Strings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v31 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("PAUSE_UI_RESUME");
		label.fontSize = (int)text;
	}

	public unsafe ResumeButtonHelper()
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected VT, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_018c: Expected Obj, but got VT
		//IL_01a1: Expected F4, but got Obj
		//IL_019c: Expected native int or pointer, but got VT
		//IL_01bb: Expected F4, but got Obj
		//IL_01b6: Expected native int or pointer, but got VT
		//IL_01d0: Expected F4, but got I
		//IL_01cb: Expected native int or pointer, but got VT
		//IL_01ea: Expected I4, but got VT
		//IL_01ea: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_021a: Expected I4, but got Obj
		//IL_0100: Expected I, but got Obj
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 24);
		object obj2 = obj + 20;
		object obj3 = obj + 16;
		if (~(_buttonEnabled ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag = isButtonEnabled;
		nint num = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v9 (Il2CppClass<GlobalColors>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v35 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = GlobalColors.FOOTER_BIG_WAIT_COLOR;
		obj3 = obj2;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v19 (System.Boolean)+C]");
		TweenHeight tweenHeight = TweenHeight.Begin((UIWidget)0, 0f, (int)matrix4x);
		bool flag2 = isButtonEnabled;
		((UIButtonOverlayOff)flag2).GoToSelectedState();
		_buttonEnabled = false;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v24 (Il2CppClass<Strings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v31 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("RESUME_BUTTON_HELPER_WAIT");
		label.fontSize = (int)text;
	}
}
