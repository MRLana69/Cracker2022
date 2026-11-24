using System;
using System.Collections;
using ABTest;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;
using UnityEngine.U2D;

namespace UI.MessageCenter;

public class UIButtonChangeScreen : UIBasicButton
{
	public enum ScreenChangeType
	{
		PushScreen,
		SwitchScreen,
		BackToPrevious,
		QueuePopup,
		ClosePopup,
		PushPopup
	}

	public ScreenChangeType screenChangeType;

	private string _screenName;

	private string _popupName;

	private string[] _popups;

	private string[] _screens;

	public string PopupName
	{
		get
		{
			//IL_000b: Expected Obj, but got I
			//IL_0019: Expected Obj, but got I4
			//IL_001d: Expected Obj, but got I4
			int layer = ((GameObject)(nint)((UnityEngine.Object)this).m_CachedPtr).layer;
			return (string)((SpriteAtlas)layer).CanBindTo(null);
		}
		set
		{
			if (value != null)
			{
				if (trigger != Trigger.OnPress)
				{
					return;
				}
			}
			else if (trigger != Trigger.OnRelease)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	private void UpdateAndSortLists()
	{
		CancelInvoke();
	}

	public string GetScreenOrPopupName()
	{
		return _popupName;
	}

	private bool ShowScreens()
	{
		//IL_0033: Expected I4, but got Obj
		//IL_009e: Expected I4, but got Obj
		//IL_0090: Expected I4, but got Obj
		if (screenChangeType == ScreenChangeType.PushScreen || screenChangeType == ScreenChangeType.SwitchScreen)
		{
			return (byte)(int)_screenName != 0;
		}
		if (screenChangeType == ScreenChangeType.QueuePopup || screenChangeType == ScreenChangeType.PushPopup)
		{
			return (byte)(int)_popupName != 0;
		}
		return (byte)(int)string.Empty != 0;
	}

	private bool ShowPopups()
	{
		if (screenChangeType != ScreenChangeType.PushScreen)
		{
			return screenChangeType == ScreenChangeType.SwitchScreen;
		}
		return true;
	}

	public override void Send()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreens>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 32;
		obj2 = UIScreens.SCREENS;
		object obj3 = this + 28;
		obj3 = UIScreens.POPUPS;
		Array.Sort(_screens);
		Array.Sort(_popups);
	}

	public UIButtonChangeScreen()
	{
		//IL_074d: Expected I, but got Obj
		//IL_0763: Expected Obj, but got I
		//IL_0789: Expected Obj, but got I4
		//IL_0797: Expected Obj, but got I4
		//IL_0140: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0166: Expected VT, but got Obj
		//IL_07c6: Expected Obj, but got I4
		//IL_01aa: Expected I, but got Obj
		//IL_01c0: Expected Obj, but got I
		//IL_07f5: Expected I, but got Obj
		//IL_080b: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_085d: Expected Obj, but got I4
		//IL_086f: Expected Obj, but got I4
		//IL_01eb: Expected I, but got Obj
		//IL_00f3: Expected I, but got Obj
		//IL_024c: Expected VT, but got Obj
		//IL_03ef: Expected I, but got Obj
		//IL_0405: Expected Obj, but got I
		//IL_08f1: Expected Obj, but got I4
		//IL_08f1: Expected Obj, but got I4
		//IL_08a9: Expected I4, but got Obj
		//IL_0430: Expected I, but got Obj
		//IL_047d: Expected I, but got Obj
		//IL_0493: Expected Obj, but got I
		//IL_090d: Expected Obj, but got I4
		//IL_090d: Expected Obj, but got I4
		//IL_04be: Expected I, but got Obj
		//IL_050b: Expected I, but got Obj
		//IL_0521: Expected Obj, but got I
		//IL_0924: Expected Obj, but got I4
		//IL_054c: Expected I, but got Obj
		//IL_0599: Expected I, but got Obj
		//IL_05af: Expected Obj, but got I
		//IL_093f: Expected Obj, but got I4
		//IL_093f: Expected Obj, but got I4
		//IL_05da: Expected I, but got Obj
		//IL_0627: Expected I, but got Obj
		//IL_063d: Expected Obj, but got I
		//IL_0956: Expected Obj, but got I4
		//IL_0668: Expected I, but got Obj
		//IL_06b5: Expected I, but got Obj
		//IL_06cb: Expected Obj, but got I
		//IL_0971: Expected Obj, but got I4
		//IL_0971: Expected Obj, but got I4
		//IL_06f6: Expected I, but got Obj
		bool flag = ShowScreens();
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v158 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ABTestManager.DisableDebugPayload((string)flag);
		if ((string)flag != "CoinsUI_quick")
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v133 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v154 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			IEnumerator enumerator = ((UIScreenController)flag2).DelayHideMainCamera();
			if (enumerator != null)
			{
			}
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v142 (Il2CppClass<Flurry>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v146 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		else if ((string)flag != "PauseUI")
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			_ = 1;
		}
		else if ((string)flag != "IngameUI")
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v114 (Il2CppClass<UIScreenController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v125 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			bool isShowingPopup = ((UIScreenController)flag3).isShowingPopup;
			if ((string)isShowingPopup != "ConsumablesPopup")
			{
				_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				_ = 1;
			}
		}
		if (!isActiveAndEnabled)
		{
			return;
		}
		string text = tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 == null)
		{
			return;
		}
		bool flag4;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6 (System.Boolean)+8]");
			flag4 = (nint)0 == 0;
		}
		else
		{
			flag4 = true;
		}
		if (flag4 && (screenChangeType == ScreenChangeType.PushScreen || screenChangeType == ScreenChangeType.SwitchScreen || screenChangeType == ScreenChangeType.QueuePopup))
		{
			UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
			string msg = string.ConcatArray((string[])(object)values, (int)" tried to send an empty Change Screen message");
			SDebug.LogFormat(msg, null);
		}
		if (screenChangeType != ScreenChangeType.PushScreen)
		{
			if (screenChangeType != ScreenChangeType.SwitchScreen)
			{
				if (screenChangeType != ScreenChangeType.BackToPrevious)
				{
					if (screenChangeType != ScreenChangeType.QueuePopup)
					{
						if (screenChangeType != ScreenChangeType.ClosePopup)
						{
							if (screenChangeType != ScreenChangeType.PushPopup)
							{
								return;
							}
							nint num9 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v83 (Il2CppClass<UIScreenController>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num10 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v89 (Il2CppClass<UIScreenController>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag5 = UIScreenController.ShouldShowOnlineScreen();
							((UIScreenController)flag5).QueuePopup((string)flag);
							return;
						}
						nint num11 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v72 (Il2CppClass<UIScreenController>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num12 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v78 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag6 = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag6).DebugCloseAllPopups();
						return;
					}
					nint num13 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v61 (Il2CppClass<UIScreenController>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num14 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v67 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag7 = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag7)._ActivateNextPopup((string)flag);
					return;
				}
				nint num15 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v50 (Il2CppClass<UIScreenController>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num16 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v56 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag8 = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag8).ClearPopupsAndScreens();
				return;
			}
			nint num17 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v39 (Il2CppClass<UIScreenController>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v45 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag9 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag9).ScreenDidChange((string)flag);
			return;
		}
		nint num19 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v28 (Il2CppClass<UIScreenController>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num20 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag10 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag10).SwitchScreen((string)flag);
	}
}
