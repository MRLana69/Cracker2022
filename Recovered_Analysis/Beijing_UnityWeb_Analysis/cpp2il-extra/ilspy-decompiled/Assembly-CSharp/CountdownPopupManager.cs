using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway;
using SYBO.Subway.Inputs;
using SYBO.Subway.UI;
using UI.Screens;
using UI.SlideIns;
using UI.VideoAdPrizes;
using UnityEngine;

public class CountdownPopupManager
{
	private sealed class _003CUpdate_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CountdownPopupManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00a7: Expected I, but got Obj
				//IL_00bd: Expected Obj, but got I
				//IL_019c: Expected I4, but got F4
				//IL_01aa: Invalid comparison between I4 and F4
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Expected Obj, but got Unknown
				//IL_01f3: Expected Obj, but got I4
				//IL_0207: Expected Obj, but got I4
				//IL_00e8: Expected I, but got Obj
				//IL_012d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0132: Expected Obj, but got Unknown
				//IL_013b: Expected Obj, but got I4
				//IL_014f: Expected Obj, but got I4
				CountdownPopupManager countdownPopupManager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						goto IL_015e;
					}
					if (_003C_003E1__state != 2)
					{
						return null;
					}
				}
				_003C_003E1__state = -1;
				if (((DeviceInfo)(object)countdownPopupManager).deviceModel != null)
				{
					nint num = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v30 (Il2CppClass<UIScreenController>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = UIScreenController.ShouldShowOnlineScreen();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v35 (System.Boolean)+58]");
					if ((nint)0 == 0)
					{
						object obj2 = this + 12;
						obj2 = 0;
						_003C_003E1__state = 1;
						return 1;
					}
					goto IL_015e;
				}
				return null;
				IL_015e:
				float dpi = ((DeviceInfo)(object)countdownPopupManager).dpi;
				float num3 = dpi * 1.75f;
				float num4 = (float)((DeviceInfo)(object)countdownPopupManager)._performanceLevel - num3;
				((DeviceInfo)(object)countdownPopupManager)._performanceLevel = (DeviceInfo.PerformanceLevel)num4;
				if (!((float)((DeviceInfo)(object)countdownPopupManager)._performanceLevel > 0f))
				{
					countdownPopupManager.DefaultEndLogic();
					return null;
				}
				object obj3 = this + 12;
				obj3 = 0;
				_003C_003E1__state = 2;
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

	private static CountdownPopupManager _instance;

	private const int DefaultCountdown = 3;

	private float CountdownInSeconds__BackingField;

	private bool IsCountdownActive__BackingField;

	private float _timeStart;

	private float _timeDelta;

	private float _actual;

	private bool _timeStarted;

	private Coroutine _countdownCoroutine;

	private Action _customEndLogic;

	private Action OnCountdownEnded__BackingField;

	public static CountdownPopupManager Instance
	{
		get
		{
			//IL_00f8: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			nint num = (nint)typeof(CoinsForVideoManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CoinsForVideoManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CoinsForVideoManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<CoinsForVideoManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = CoinsForVideoManager._instance == null;
			bool flag2 = !flag;
			CountdownPopupManager result = (CountdownPopupManager)(object)CoinsForVideoManager._instance;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = (nint)typeof(CoinsForVideoManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v20 (Il2CppClass<CoinsForVideoManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(CoinsForVideoManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27 (Il2CppClass<CoinsForVideoManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CountdownPopupManager countdownPopupManager = default;
				CoinsForVideoManager._instance = (CoinsForVideoManager)(object)countdownPopupManager;
				result = countdownPopupManager;
			}
			return result;
		}
	}

	public float CountdownInSeconds
	{
		get
		{
			float num = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+34]");
			float num2 = num - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+38]");
			float num3 = 0f * num2;
			float num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+3C]");
			float num5 = num4 / 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+34]");
			return 0f + num5;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0084: Expected Obj, but got I4
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected Obj, but got Unknown
			//IL_00b7: Expected Obj, but got I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			//IL_0045: Expected Obj, but got I4
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = 0;
			string tag = ((Component)this).tag;
			ParticleSystem[] componentsInChildren = ((GameObject)(object)tag).GetComponentsInChildren<ParticleSystem>(false);
			object obj3 = componentsInChildren + 12;
			object obj4 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj5 = componentsInChildren + 16;
				object obj6 = obj4 << 2;
				object obj7 = obj5 + obj6;
				obj = 0;
				obj = obj7;
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11760");
				object obj8 = obj4 + 1;
				obj4 = obj8;
			}
		}
	}

	public unsafe bool IsCountdownActive
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool result = default;
			return result;
		}
		private set
		{
			//IL_0624: Expected I, but got Obj
			//IL_063a: Expected Obj, but got I
			//IL_0856: Expected Obj, but got I4
			//IL_0071: Expected I, but got Obj
			//IL_0087: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0663: Expected Obj, but got F4
			//IL_005e: Expected Obj, but got I4
			//IL_0110: Expected I, but got Obj
			//IL_0126: Expected Obj, but got I
			//IL_00b2: Expected I, but got Obj
			//IL_0690: Expected Obj, but got F4
			//IL_00fd: Expected Obj, but got F4
			//IL_01af: Expected I, but got Obj
			//IL_01c5: Expected Obj, but got I
			//IL_0151: Expected I, but got Obj
			//IL_06bb: Expected Obj, but got I4
			//IL_019c: Expected Obj, but got F4
			//IL_0250: Expected I, but got Obj
			//IL_0266: Expected Obj, but got I
			//IL_01f0: Expected I, but got Obj
			//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ea: Expected VT, but got Unknown
			//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f8: Expected Obj, but got Unknown
			//IL_0701: Unknown result type (might be due to invalid IL or missing references)
			//IL_0706: Expected Obj, but got Unknown
			//IL_070f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0714: Expected Obj, but got Unknown
			//IL_0723: Expected Obj, but got I4
			//IL_0723: Expected Obj, but got I4
			//IL_023d: Expected Obj, but got I4
			//IL_023d: Expected Obj, but got I4
			//IL_02de: Expected I, but got Obj
			//IL_02f4: Expected Obj, but got I
			//IL_0291: Expected I, but got Obj
			//IL_0744: Expected Obj, but got F4
			//IL_0744: Expected Obj, but got I4
			//IL_031f: Expected I, but got Obj
			//IL_052b: Expected I4, but got Obj
			//IL_052b: Expected Obj, but got I
			//IL_0539: Expected I, but got Obj
			//IL_054f: Expected Obj, but got I
			//IL_0370: Expected Obj, but got I
			//IL_0382: Expected Obj, but got I
			//IL_07dc: Expected Obj, but got VT
			//IL_07f1: Expected F4, but got Obj
			//IL_07ec: Expected native int or pointer, but got VT
			//IL_080b: Expected F4, but got Obj
			//IL_0806: Expected native int or pointer, but got VT
			//IL_0820: Expected F4, but got I
			//IL_081b: Expected native int or pointer, but got VT
			//IL_0835: Expected I4, but got VT
			//IL_0835: Expected Obj, but got I
			//IL_0845: Expected I4, but got Obj
			//IL_03a9: Expected Obj, but got I
			//IL_05c9: Expected Obj, but got I4
			//IL_05df: Expected Obj, but got I
			//IL_057a: Expected I, but got Obj
			//IL_03bc: Expected I, but got Obj
			//IL_03d2: Expected Obj, but got I
			//IL_05fa: Expected Obj, but got I4
			//IL_05fa: Expected Obj, but got I
			//IL_0610: Expected Obj, but got I4
			//IL_0610: Expected Obj, but got I
			//IL_075f: Expected Obj, but got VT
			//IL_0774: Expected F4, but got Obj
			//IL_076f: Expected native int or pointer, but got VT
			//IL_078e: Expected F4, but got Obj
			//IL_0789: Expected native int or pointer, but got VT
			//IL_07a3: Expected F4, but got I
			//IL_079e: Expected native int or pointer, but got VT
			//IL_07b8: Expected I4, but got VT
			//IL_07b8: Expected Obj, but got I
			//IL_07ce: Expected I4, but got Obj
			//IL_07ce: Expected Obj, but got I
			//IL_03fd: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v104 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)IsCountdownActive__BackingField).FindKernel(null) != 0)
			{
				((GameObject)IsCountdownActive__BackingField).tag = null;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v99 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)_timeStart).FindKernel(null) != 0)
			{
				((GameObject)_timeStart).tag = null;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v94 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)_actual).FindKernel(null) != 0)
			{
				((GameObject)_actual).tag = null;
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v98 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)value).FindKernel(null) != 0)
			{
				((GameObject)value).tag = (string)1;
			}
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v93 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = default;
			Matrix4x4 matrix4x = (Matrix4x4)(obj6 + 32);
			object obj7 = obj6 + 16;
			object obj8 = obj6 + 24;
			object obj9 = obj6 + 20;
			if ((UnityEngine.Object)value == (UnityEngine.Object)IsCountdownActive__BackingField)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v89 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!((UnityEngine.Object)value != (UnityEngine.Object)_actual))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+34]");
					((Component)0).tag = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+30]");
					((Component)0).tag = null;
					((Component)(object)OnCountdownEnded__BackingField).tag = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+38]");
					((Collider)0).isTrigger = false;
					nint num13 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S1_v73 (Il2CppClass<GlobalColors>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num14 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v86 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj7 = GlobalColors.PRIMARY_ACTION_COLOR_UNAVAILABLE;
					obj9 = obj7;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
					Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+2C]");
					((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+2C]");
					((UISprite)0).fillCenter = (byte)(int)"button_generic_1" != 0;
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+64]");
			if ((nint)0 == 2)
			{
				SlideInData instance = SlideInData.instance;
				bool flag = ((VideoAdPrizeManager)(object)instance).HasVideoAdPrizeIndexChanged();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S2_v38 (System.Boolean)+8]");
				string titleStringIdForVideoAdPrize = ((CoinEarnerVideoAds)this).GetTitleStringIdForVideoAdPrize(VideoAdPrizeType.NotSet);
				SlideInData instance2 = SlideInData.instance;
				bool flag2 = ((VideoAdPrizeManager)(object)instance2).HasVideoAdPrizeIndexChanged();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S3_v8 (System.Boolean)+8]");
				UISprite prizeIcon = ((CoinEarnerVideoAds)null).GetPrizeIcon(0);
				SlideInData instance3 = SlideInData.instance;
				VideoAdPrize videoAdPrize = ((VideoAdPrizeManager)(object)instance3).GetVideoAdPrize();
				((DebugSettingsPopup)this).InsertGroupTopToggle(titleStringIdForVideoAdPrize, (string)(object)prizeIcon, (string)(object)videoAdPrize, DebugSetting.Boards);
				((CoinEarnerVideoAds)this).LogButtonShownToFlurry();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+2C]");
			((UISprite)0).fillCenter = (byte)(int)"backgroud_callout_square" != 0;
			nint num15 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v40 (Il2CppClass<GlobalColors>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num16 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v57 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj7 = GlobalColors.PRIMARY_ACTION_COLOR;
			obj8 = obj7;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+2C]");
			((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
			((UISprite)(object)OnCountdownEnded__BackingField).fillCenter = (byte)(int)"whitebox_div" != 0;
			((Component)(object)OnCountdownEnded__BackingField).tag = (string)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+38]");
			((Collider)0).isTrigger = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+30]");
			((Component)0).tag = (string)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+34]");
			((Component)0).tag = (string)1;
		}
	}

	public Action OnCountdownEnded
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = IsCountdownActive__BackingField;
			return (Action)flag;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			IsCountdownActive__BackingField = flag;
		}
	}

	public void StartCountdown()
	{
		((UpgradeScreen)this).Start();
	}

	public void StartCountdown(Action customEndLogic)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 40;
		obj = customEndLogic;
	}

	public void StartCountdown(float countdown, Action customEndLogic)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+90]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CountdownPopupManager)+6C]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S2_v2+44]");
		float pos = num / 0f;
		((FollowingGuard)this).CatchPlayer(pos);
	}

	public void StopCountdown()
	{
		((DayHelper)this).Init(0);
	}

	private void CountdownEnded()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		if (~(IsCountdownActive__BackingField ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
		IsCountdownActive__BackingField = false;
		if (_countdownCoroutine != null)
		{
			FileUtil.LogError((string)(object)_countdownCoroutine);
			object obj2 = this + 32;
			obj2 = 0;
		}
	}

	private void DefaultEndLogic()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I4
		IsCountdownActive__BackingField = false;
		CountdownInSeconds__BackingField = 0f;
		if (OnCountdownEnded__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		if (_customEndLogic != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			object obj = this + 36;
			obj = 0;
		}
		else
		{
			((CountdownPopupManager)null)._002Ector();
		}
	}

	private IEnumerator Update()
	{
		return (IEnumerator)(object)OnCountdownEnded__BackingField;
	}

	private float UpdateRealTimeDelta()
	{
		return CountdownInSeconds__BackingField;
	}

	public CountdownPopupManager()
	{
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0214: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I4
		//IL_017c: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!MergeLevelStartHelp.IsValidLoadedLevelNameForGameplay())
		{
			return;
		}
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)isInstantiated).FindKernel(null) == 0)
		{
			return;
		}
		nint num7 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated2 = Game.IsInstantiated;
		((Game)isInstantiated2).HandleProductionInput(InputType.None);
	}
}
