using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using Data.Migration;
using Data.Save;
using SYBO.Subway.Info;
using UnityEngine;

public class UIMessageHelper : MonoBehaviour
{
	private sealed class _003CFadeOut_003Ed__5(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMessageHelper _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private float _003CfadeTime_003E5__3;

		private Vector3 _003CscaleFrom_003E5__4;

		private Vector3 _003CscaleTo_003E5__5;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0491: Unknown result type (might be due to invalid IL or missing references)
				//IL_0496: Expected Obj, but got Unknown
				//IL_049f: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a4: Expected Obj, but got Unknown
				//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_04b2: Expected Obj, but got Unknown
				//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_04c0: Expected Obj, but got Unknown
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Expected Obj, but got Unknown
				//IL_00a9: Expected Obj, but got I4
				//IL_00e0: Expected Obj, but got I
				//IL_00f1: Expected VT, but got Obj
				//IL_0116: Unknown result type (might be due to invalid IL or missing references)
				//IL_011b: Expected Obj, but got Unknown
				//IL_0133: Unknown result type (might be due to invalid IL or missing references)
				//IL_0138: Expected Obj, but got Unknown
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Expected Obj, but got Unknown
				//IL_014c: Expected Obj, but got I4
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_0195: Expected Obj, but got Unknown
				//IL_03b1: Expected Obj, but got I
				//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c5: Expected Obj, but got Unknown
				//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e5: Expected Obj, but got Unknown
				//IL_0408: Expected I, but got Obj
				//IL_041e: Expected Obj, but got I
				//IL_0345: Unknown result type (might be due to invalid IL or missing references)
				//IL_034a: Expected Obj, but got Unknown
				//IL_0366: Expected Obj, but got I4
				//IL_01dd: Expected I4, but got Obj
				//IL_01dd: Expected Obj, but got I
				//IL_01ee: Expected Obj, but got I
				//IL_0557: Expected VT, but got Obj
				//IL_0557: Expected VT, but got Obj
				//IL_058b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0590: Expected Obj, but got Unknown
				//IL_0599: Expected Obj, but got I4
				//IL_05ad: Expected Obj, but got I4
				//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0202: Expected Obj, but got Unknown
				//IL_0449: Expected I, but got Obj
				//IL_0270: Expected I, but got Obj
				//IL_0286: Expected Obj, but got I
				//IL_0500: Expected Obj, but got I4
				//IL_02b1: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 48);
				Transform transform2 = (Transform)(obj + 36);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
				UIMessageHelper uIMessageHelper = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UIMessageHelper)+1C]");
								((UILabel)0).fontSize = (int)"";
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UIMessageHelper)+1C]");
								GameObject gameObject = ((Component)0).gameObject;
								object obj4 = this + 28;
								transform2 = (Transform)obj4;
								Transform transform3 = transform2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S2_v35+8]");
								((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
								transform = transform2;
								((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
								((Transform)(object)gameObject).parent = transform;
								string tag = uIMessageHelper.tag;
								((GameObject)(object)tag).tag = null;
								nint num = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v84 (Il2CppClass<UIScreenController>)+BA]");
								object obj5 = (nint)0 & (nint)0x200;
								if (obj5 != null)
								{
									nint num2 = (nint)typeof(UIScreenController);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v91 (Il2CppClass<UIScreenController>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag = UIScreenController.ShouldShowOnlineScreen();
								((UIScreenController)flag)._ShowNextMessage();
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						_003Cduration_003E5__2 = 0.2f;
						_003CfadeTime_003E5__3 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UIMessageHelper)+1C]");
						GameObject gameObject2 = ((Component)0).gameObject;
						transform2.localScale = (Vector3)gameObject2;
						transform = transform2;
						((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
						object obj6 = this + 28;
						obj6 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
						object obj7 = this + 28;
						object obj8 = this + 28;
						obj2 = 0;
						_ = 0;
						obj2 = obj7;
						_ = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v62+8]");
						_ = 0;
						transform = (Transform)obj2;
						Transform transform4 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						object obj9 = this + 40;
						obj9 = transform;
						_ = ((UnityEngine.Object)transform).m_CachedPtr;
					}
					if (!(_003CfadeTime_003E5__3 < 1f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.5f;
						object obj10 = this + 12;
						object obj11 = default;
						obj10 = obj11;
						_003C_003E1__state = 3;
						return 1;
					}
					float unscaledTime = Time.unscaledTime;
					float num3 = unscaledTime / _003Cduration_003E5__2;
					float num4 = _003CfadeTime_003E5__3 + num3;
					_003CfadeTime_003E5__3 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UIMessageHelper)+1C]");
					GameObject gameObject3 = ((Component)0).gameObject;
					object obj12 = this + 28;
					obj2 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S2_v7+8]");
					_ = 0;
					object obj13 = this + 40;
					obj3 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S2_v12+8]");
					_ = 0;
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v27 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num6 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S1_v42 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform2 = (Transform)obj2;
					Transform transform5 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					transform = (Transform)obj3;
					Transform transform6 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
					Vector3 vector = Vector3.LerpUnclamped((Vector3)transform2, (Vector3)transform, _003CfadeTime_003E5__3);
					transform = (Transform)obj;
					Transform transform7 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
					((Transform)(object)gameObject3).parent = transform;
					object obj15 = this + 12;
					obj15 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 2f;
				object obj16 = this + 12;
				object obj17 = default;
				obj16 = obj17;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

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

	public Color shownColor;

	private UILabel _label;

	private bool _wasPermanentlyHidden;

	private void Awake()
	{
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 24;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj5 = this + 36;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<HoverboardThemes.HoverboardTheme> list = default;
		list._002Ector();
		object obj7 = this + 52;
		obj7 = list;
		CancelInvoke();
	}

	public void ShowMessage(string message, bool bigText = false)
	{
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper)+2C]");
		if ((nint)0 == (bigText ? 1 : 0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper)+30]");
			if (0 == (nint)message)
			{
				return;
			}
		}
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v8 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v14 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper)+30]");
		PlayerInfoMigrator.LogMigrationFail((string)0, (Exception)bigText);
		((UICharacterThemeShifter)this).ThemeButtonPressed(bigText ? 1 : 0);
	}

	private IEnumerator FadeOut()
	{
		//IL_001f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper)+24]");
		bool flag = (nint)0 != 0;
		return (IEnumerator)flag;
	}

	public unsafe void SetTemporaryHidden(bool hidden)
	{
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0168: Expected Obj, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I
		//IL_0211: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v25 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper)+3C]");
		int currentlyShownHoverboardTheme = BoardManager.GetCurrentlyShownHoverboardTheme(BoardManager.ScreenContext.BoardScreen);
		((UIHoverboardThemeShifter)this).ClickedTheme(hidden ? 1 : 0);
		if (hidden)
		{
			nint num3 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S2_v9 (Il2CppClass<HoverboardThemes>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S2_v25 (Il2CppClass<HoverboardThemes>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ref Notification notification = ref *(Notification*)((hidden ? 1 : 0) - 1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper)+2C]");
			bool amount = ((NotificationsObserver)0).DidAppStartFromNotificationAndroid(out notification);
			nint num5 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S2_v16 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S2_v21 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper)+2C]");
			CharacterManager.CollectToken(Characters.CharacterId.slick, amount ? 1 : 0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper)+28]");
		if ((nint)0 != 0)
		{
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S2_v5 (Il2CppMethodInfo)+18]");
			object obj4 = 0;
			object obj5 = obj4;
			object obj6 = obj5 & 0x3FFF;
			object obj7 = obj6 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v93 @ S3_v6 (should have been resolved before IL gen)");
		}
	}

	public void DisableShowLabel()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = this + 28;
		UILabel component = GetComponent<UILabel>();
		obj = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		string text = tag;
		((GameObject)(object)text).tag = null;
	}

	public UIMessageHelper()
	{
		//IL_0022: Expected I4, but got Obj
		UILabel label = _label;
		char c = label.mText.get_Chars((int)"");
		int wasPermanentlyHidden = c & 1;
		_wasPermanentlyHidden = (byte)wasPermanentlyHidden != 0;
		_label.tag = null;
	}
}
