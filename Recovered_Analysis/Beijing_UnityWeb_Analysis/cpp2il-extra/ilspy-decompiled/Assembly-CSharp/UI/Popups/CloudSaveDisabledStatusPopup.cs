using System;
using System.Collections;
using System.Collections.Generic;
using Authentication;
using Cloud;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Utility;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CloudSaveDisabledStatusPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__17_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudSaveComparisonPopup._003C_003Ec obj = default;
			CloudSaveComparisonPopup._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).DebugCloseAllPopups();
		}

		internal void _003CButtonClicked_Routine_003Eb__17_0()
		{
		}
	}

	private sealed class _003CButtonClicked_Routine_003Ed__17(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudSaveDisabledStatusPopup _003C_003E4__this;

		private bool _003CloggedIntoNative_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_00c8: Expected Obj, but got I4
				//IL_00e9: Expected I, but got Obj
				//IL_00ff: Expected Obj, but got I
				//IL_02be: Expected I, but got Obj
				//IL_02d4: Expected Obj, but got I
				//IL_05ce: Expected I, but got Obj
				//IL_05e4: Expected Obj, but got I
				//IL_06ff: Expected Obj, but got I4
				//IL_0711: Expected Obj, but got I4
				//IL_012a: Expected I, but got Obj
				//IL_02ff: Expected I, but got Obj
				//IL_08a1: Expected I, but got Obj
				//IL_08b7: Expected Obj, but got I
				//IL_0177: Expected I, but got Obj
				//IL_039b: Expected I, but got Obj
				//IL_03b1: Expected Obj, but got I
				//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_06ba: Expected Obj, but got Unknown
				//IL_06e3: Expected Obj, but got I4
				//IL_01c4: Expected I, but got Obj
				//IL_01da: Expected Obj, but got I
				//IL_0731: Expected Obj, but got I4
				//IL_035d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0362: Expected Obj, but got Unknown
				//IL_036b: Expected Obj, but got I4
				//IL_037f: Expected Obj, but got I4
				//IL_0252: Expected I, but got Obj
				//IL_0668: Unknown result type (might be due to invalid IL or missing references)
				//IL_066d: Expected Obj, but got Unknown
				//IL_0684: Expected I, but got Obj
				//IL_069a: Expected Obj, but got I
				//IL_0431: Expected Obj, but got I
				//IL_0441: Expected Obj, but got I
				//IL_0452: Unknown result type (might be due to invalid IL or missing references)
				//IL_0457: Expected Obj, but got Unknown
				//IL_0460: Unknown result type (might be due to invalid IL or missing references)
				//IL_0465: Expected Obj, but got Unknown
				//IL_03dc: Expected I, but got Obj
				//IL_0205: Expected I, but got Obj
				//IL_0756: Expected Obj, but got I
				//IL_0766: Expected Obj, but got I
				//IL_0776: Expected Obj, but got I
				//IL_077f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0784: Expected Obj, but got Unknown
				//IL_078d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0792: Expected Obj, but got Unknown
				//IL_07b2: Expected Obj, but got I
				//IL_07c2: Expected Obj, but got I
				//IL_07d2: Expected Obj, but got I
				//IL_07db: Unknown result type (might be due to invalid IL or missing references)
				//IL_07e0: Expected Obj, but got Unknown
				//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_07ee: Expected Obj, but got Unknown
				//IL_08e2: Expected I, but got Obj
				//IL_08f8: Expected Obj, but got I
				//IL_04b2: Expected I, but got Obj
				//IL_04c8: Expected Obj, but got I
				//IL_0540: Expected I, but got Obj
				//IL_0830: Expected Obj, but got I
				//IL_0840: Expected Obj, but got I
				//IL_0850: Expected Obj, but got I
				//IL_0859: Unknown result type (might be due to invalid IL or missing references)
				//IL_085e: Expected Obj, but got Unknown
				//IL_0867: Unknown result type (might be due to invalid IL or missing references)
				//IL_086c: Expected Obj, but got Unknown
				//IL_04f3: Expected I, but got Obj
				CloudSaveDisabledStatusPopup cloudSaveDisabledStatusPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1 && _003C_003E1__state != 2)
					{
						return null;
					}
					_003C_003E1__state = -1;
					nint num = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v89 (Il2CppClass<UIScreenController>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v151 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = UIScreenController.ShouldShowOnlineScreen();
					bool isShowingPopup = ((UIScreenController)flag).isShowingPopup;
					if ((string)isShowingPopup != "CloudSaveCelebrationPopup")
					{
						object obj2 = this + 12;
						obj2 = 0;
						_003C_003E1__state = 2;
						return 1;
					}
					cloudSaveDisabledStatusPopup.ButtonClicked();
					nint num3 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v99 (Il2CppClass<UIScreenController>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v143 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag2 = UIScreenController.ShouldShowOnlineScreen();
					((UIScreenController)flag2).ClosePopup((GameObject)(object)"CloudSaveDisabledStatusPopup");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S3_v3 (Il2CppMethodInfo)+C]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S3_v4+60]");
					object obj5 = 0;
					object obj6 = obj5;
					object obj7 = obj6 & 0x1FFF;
					object obj8 = obj7 + 113696;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v258 @ S4_v5 (should have been resolved before IL gen)");
					if (~(_003CloggedIntoNative_003E5__2 ? 1u : 0u) == 0)
					{
						object obj9 = "NativeLoggedIn";
					}
					else
					{
						object obj9 = "NativeLoggedOut";
					}
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S4_v7 (Il2CppMethodInfo)+C]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S4_v8+60]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S4_v9+48]");
					object obj12 = 0;
					object obj13 = obj12 & 0x7FF;
					object obj14 = obj13 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v301 @ S5_v7 (should have been resolved before IL gen)");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S4_v12 (Il2CppMethodInfo)+C]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S4_v13+60]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S4_v14+48]");
					object obj17 = 0;
					object obj18 = obj17 & 0x7FF;
					object obj19 = obj18 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v319 @ S5_v11 (should have been resolved before IL gen)");
					if (~(_003CloggedIntoNative_003E5__2 ? 1u : 0u) == 0)
					{
						nint num8 = (nint)typeof(Auth);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v131 (Il2CppClass<Authentication.Auth>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num9 = (nint)typeof(Auth);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v139 (Il2CppClass<Authentication.Auth>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool isInitialized = Auth.isInitialized;
						nint num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S4_v18 (Il2CppMethodInfo)+C]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S4_v19+60]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S4_v20+48]");
						object obj23 = 0;
						object obj24 = obj23 & 0x7FF;
						object obj25 = obj24 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v334 @ S5_v16 (should have been resolved before IL gen)");
					}
					nint num11 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v120 (Il2CppClass<Flurry>)+BA]");
					object obj26 = (nint)0 & (nint)0x200;
					if (obj26 != null)
					{
						nint num12 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v126 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					cloudSaveDisabledStatusPopup._authRoutineRunning = false;
					return null;
				}
				_003C_003E1__state = -1;
				if (~(cloudSaveDisabledStatusPopup._authRoutineRunning ? 1u : 0u) == 0)
				{
					return null;
				}
				cloudSaveDisabledStatusPopup._authRoutineRunning = true;
				string tag = cloudSaveDisabledStatusPopup._buttonLabel.tag;
				((GameObject)(object)tag).tag = null;
				string tag2 = cloudSaveDisabledStatusPopup._spinner.tag;
				((GameObject)(object)tag2).tag = (string)1;
				cloudSaveDisabledStatusPopup._buttonOverlay.GoToSelectedState();
				nint num13 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v24 (Il2CppClass<Authentication.Auth>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					nint num14 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v82 (Il2CppClass<Authentication.Auth>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isAuthorized = Auth.isAuthorized;
				_003CloggedIntoNative_003E5__2 = isAuthorized;
				nint num15 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v30 (Il2CppClass<UI.Popups.CloudSaveDisabledStatusPopup+<>c>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num16 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v76 (Il2CppClass<UI.Popups.CloudSaveDisabledStatusPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = _003C_003Ec._003C_003E9__17_0 == null;
				bool flag4 = !flag3;
				Action onFinished = _003C_003Ec._003C_003E9__17_0;
				if (!flag4)
				{
					nint num17 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v53 (Il2CppClass<UI.Popups.CloudSaveDisabledStatusPopup+<>c>)+BA]");
					object obj29 = (nint)0 & (nint)0x200;
					if (obj29 != null)
					{
						nint num18 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v70 (Il2CppClass<UI.Popups.CloudSaveDisabledStatusPopup+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					Action action = default;
					((Delegate)action).method_ptr = method_ptr;
					((Delegate)action).method = (nint)__ldftn(_003C_003Ec._003CButtonClicked_Routine_003Eb__17_0);
					object obj30 = action + 16;
					obj30 = _003C_003Ec._003C_003E9;
					nint num19 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v67 (Il2CppClass<UI.Popups.CloudSaveDisabledStatusPopup+<>c>)+5C]");
					object obj31 = (nint)0 + (nint)4;
					obj31 = action;
					onFinished = action;
				}
				nint num20 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v40 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num21 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v48 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj33 = this + 12;
				Coroutine coroutine = CloudSave.UpdateAsync(onFinished);
				obj33 = coroutine;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_00ef: Expected I, but got Obj
			//IL_0105: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0156: Expected Obj, but got I4
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
			object obj2 = default;
			if ((nint)obj2 != 1)
			{
				return;
			}
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 19;
			_ = 1;
			((UIScreenController)flag)._QueueMessage(text);
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

	private UILabel _headline;

	private UILabel _message1;

	private UILabel _message2;

	private UILabel _buttonLabel;

	private UISprite _background;

	private UIWidget _skyline;

	private Layout _horizontalLayout;

	private Layout _verticalLayout;

	private UIButtonOverlayOff _buttonOverlay;

	private UISprite _spinner;

	private UISprite _glow;

	private bool _authRoutineRunning;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		ShowIfInactive();
		ResetPopup();
	}

	private void SetupBasic()
	{
		base.Hide();
		ButtonClicked();
	}

	private unsafe void ResetPopup()
	{
		//IL_0532: Expected I, but got Obj
		//IL_0548: Expected Obj, but got I
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected Obj, but got Unknown
		//IL_05e6: Expected Obj, but got I4
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected I4, but got Unknown
		//IL_0616: Expected I4, but got Obj
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_064e: Expected Obj, but got I4
		//IL_0670: Expected I4, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0090: Expected I4, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00ea: Expected I4, but got Obj
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0129: Expected I4, but got Obj
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_015e: Expected Obj, but got I4
		//IL_0180: Expected I4, but got Obj
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01ad: Expected Obj, but got I4
		//IL_01bf: Expected I4, but got Obj
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I4
		//IL_0216: Expected I4, but got Obj
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I4
		//IL_0275: Expected I4, but got Obj
		//IL_028b: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I4
		//IL_02bf: Expected I4, but got Obj
		//IL_0355: Expected I, but got Obj
		//IL_036b: Expected Obj, but got I
		//IL_0582: Expected I4, but got Obj
		//IL_03e3: Expected I4, but got Obj
		//IL_03f6: Expected I4, but got Obj
		//IL_0396: Expected I, but got Obj
		//IL_0342: Expected Obj, but got I4
		//IL_0417: Expected I, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_04a5: Expected I4, but got Obj
		//IL_04b8: Expected I4, but got Obj
		//IL_0458: Expected I, but got Obj
		//IL_04da: Expected I4, but got Obj
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v56 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 144;
		object obj4 = (flag ? 1 : 0) + 140;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 160);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_headline.rawPivot = pivot;
		object obj5 = obj3 + 128;
		object obj6 = (flag ? 1 : 0) + 92;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_message1.rawPivot = pivot;
		object obj7 = obj3 + 112;
		object obj8 = (flag ? 1 : 0) + 92;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18+8]");
		_ = 0;
		_message2.rawPivot = pivot;
		object obj9 = obj3 + 96;
		object obj10 = (flag ? 1 : 0) + 28;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v37+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v24+8]");
		_ = 0;
		UIEventListener.FloatDelegate floatDelegate = (UIEventListener.FloatDelegate)(obj3 + 80);
		floatDelegate((GameObject)pivot, 0.7f);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)floatDelegate;
		_ = ((Delegate)floatDelegate).method_ptr;
		_background.rawPivot = pivot;
		object obj11 = obj3 - -64;
		object obj12 = (flag ? 1 : 0) + 60;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v54+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v34+8]");
		_ = 0;
		UIEventListener.FloatDelegate floatDelegate2 = (UIEventListener.FloatDelegate)(obj3 + 48);
		floatDelegate2((GameObject)pivot, 0.5f);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)floatDelegate2;
		_ = ((Delegate)floatDelegate2).method_ptr;
		_skyline.rawPivot = pivot;
		object obj13 = obj3 + 32;
		object obj14 = (flag ? 1 : 0) + 604;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S2_v71+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v44+8]");
		_ = 0;
		_buttonLabel.rawPivot = pivot;
		object obj15 = obj3 + 16;
		object obj16 = (flag ? 1 : 0) + 732;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S2_v82+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v50+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		object obj17 = (flag ? 1 : 0) + 268;
		obj3 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S2_v92+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_glow.rawPivot = pivot;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v62 (Il2CppClass<Strings>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v90 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("CLOUDSAVE_STATUS_DISABLED_TITLE");
		_headline.fontSize = (int)text3;
		string text4 = Strings.GetDefault("CLOUDSAVE_STATUS_DISABLED_INFO1");
		string text5 = string.ConcatArray((string[])(object)"+ ", (int)text4);
		_message1.fontSize = (int)text5;
		string format = Strings.GetDefault("CLOUDSAVE_STATUS_DISABLED_INFO2");
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S2_v110 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S2_v124 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		string checksumToShow = ((OnlineSettings)(object)saveDataPath).GetChecksumToShow();
		string text6 = string.Format(format, (object[])(object)checksumToShow);
		string text7 = string.ConcatArray((string[])(object)"+ ", (int)text6);
		_message2.fontSize = (int)text7;
		string text8 = Strings.GetDefault("CLOUDSAVE_STATUS_DISABLED_BUTTON");
		_buttonLabel.fontSize = (int)text8;
		((RewardForVideoButton)(object)_verticalLayout).Init((VideoButtonPayload)null);
		object obj20 = this - -64;
		((RewardForVideoButton)obj20).Init((VideoButtonPayload)null);
		string text9 = _spinner.tag;
		((GameObject)(object)text9).tag = null;
	}

	public void ButtonClicked()
	{
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_buttonLabel != null))
		{
			string text = _buttonLabel.tag;
			((GameObject)(object)text).tag = (string)1;
			string text2 = _spinner.tag;
			((GameObject)(object)text2).tag = null;
			_buttonOverlay.GoToNotAvailableState();
		}
	}

	private IEnumerator ButtonClicked_Routine()
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

	public CloudSaveDisabledStatusPopup()
	{
		((PreferencesSave)null)._002Ector();
		IEnumerator list = ((CloudSaveIntroductionPopup)this).LoginRoutine();
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}
}
