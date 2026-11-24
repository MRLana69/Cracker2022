using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using UnityEngine;

public class PokiUnitySDK : MonoBehaviour
{
	public delegate void CommercialBreakDelegate();

	public delegate void RewardedBreakDelegate(bool withReward);

	public class LoadingProgressData : ScriptableObject
	{
		public float percentageDone;

		public int kbLoaded;

		public int kbTotal;

		public string fileNameLoaded;

		public int filesLoaded;

		public int filesTotal;

		public LoadingProgressData()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_0287: Invalid comparison between F4 and I4
			//IL_02b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (PokiUnitySDK+LoadingProgressData)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (PokiUnitySDK+LoadingProgressData)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (PokiUnitySDK+LoadingProgressData)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && percentageDone != 0f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
						object obj19 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj19 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
							}
						}
						else if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}
	}

	private static PokiUnitySDK _instance;

	private bool initialized;

	public bool adblocked;

	private bool isShowingAd__BackingField;

	public CommercialBreakDelegate commercialBreakCallBack;

	public RewardedBreakDelegate rewardedBreakCallBack;

	public static PokiUnitySDK Instance
	{
		get
		{
			//IL_000e: Expected Obj, but got I
			nint num = default;
			return (PokiUnitySDK)(num + 4);
		}
	}

	public bool isShowingAd
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14B8");
			object obj = default;
			bool result = (byte)(obj + 36) != 0;
			if (obj == null)
			{
				result = false;
			}
			return result;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Exception);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Exception)(object)this).SetErrorCode(value ? 1 : 0);
		}
	}

	[PreserveSig]
	private static extern void JS_PokiSDK_initPokiBridge(string instanceName);

	[PreserveSig]
	private static extern void JS_PokiSDK_gameLoadingStart();

	[PreserveSig]
	private static extern void JS_PokiSDK_gameLoadingFinished();

	[PreserveSig]
	private static extern void JS_PokiSDK_gameLoadingProgress(string data);

	[PreserveSig]
	private static extern void JS_PokiSDK_roundStart(string indentifier);

	[PreserveSig]
	private static extern void JS_PokiSDK_roundEnd(string indentifier);

	[PreserveSig]
	private static extern void JS_PokiSDK_gameInteractive();

	[PreserveSig]
	private static extern void JS_PokiSDK_customEvent(string noun, string verb, string data);

	[PreserveSig]
	private static extern void JS_PokiSDK_setPlayerAge(string age);

	[PreserveSig]
	private static extern void JS_PokiSDK_togglePlayerAdvertisingConsent(string consent);

	[PreserveSig]
	private static extern void JS_PokiSDK_gameplayStart();

	[PreserveSig]
	private static extern void JS_PokiSDK_gameplayStop();

	[PreserveSig]
	private static extern void JS_PokiSDK_commercialBreak();

	[PreserveSig]
	private static extern void JS_PokiSDK_rewardedBreak();

	[PreserveSig]
	private static extern void JS_PokiSDK_happyTime(string intensity);

	[PreserveSig]
	private static extern void JS_PokiSDK_displayAd(string indentifier, string size, string top, string left);

	[PreserveSig]
	private static extern void JS_PokiSDK_destroyAd(string indentifier);

	public PokiUnitySDK()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
	}

	public void init()
	{
		CancelInvoke();
	}

	public bool isInitialized()
	{
		return isShowingAd__BackingField;
	}

	public bool adsBlocked()
	{
		return initialized;
	}

	public void gameLoadingStart()
	{
		//IL_004e: Expected Obj, but got I4
		//IL_001d: Expected I4, but got Obj
		if (~(initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PokiUnitySDK pokiUnitySDK = default;
			pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is already initialized" != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			((PokiUnitySDK)null).ready();
			bool flag = AdSystemManager.isInitialized;
			UnityEngine.Object data = UnityEngine.Object.Instantiate((UnityEngine.Object)flag);
			JS_PokiSDK_gameLoadingProgress((string)(object)data);
		}
	}

	public void gameLoadingFinished()
	{
		//IL_002c: Expected I4, but got Obj
		if (~(initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @44");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PokiUnitySDK pokiUnitySDK = default;
		pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public void roundStart(string indentifier)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(indentifier & 1) != 0;
		isShowingAd__BackingField = flag;
	}

	public void roundEnd(string indentifier)
	{
		//IL_002b: Expected I4, but got Obj
		if (~(initialized ? 1u : 0u) == 0)
		{
			JS_PokiSDK_roundEnd(indentifier);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PokiUnitySDK pokiUnitySDK = default;
		pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
		pokiUnitySDK.roundStart(null);
	}

	public void gameInteractive()
	{
		//IL_002c: Expected I4, but got Obj
		if (~(initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @42");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PokiUnitySDK pokiUnitySDK = default;
		pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public void customEvent(string eventNoun, string eventVerb, ScriptableObject eventData)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
	}

	public void setPlayerAge(int age)
	{
		//IL_002b: Expected I4, but got Obj
		//IL_000e: Expected Obj, but got I4
		if (~(initialized ? 1u : 0u) == 0)
		{
			JS_PokiSDK_setPlayerAge((string)age);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PokiUnitySDK pokiUnitySDK = default;
		pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
		pokiUnitySDK.roundEnd(null);
	}

	public void togglePlayerAdvertisingConsent(bool consent)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0042: Expected I4, but got Obj
		object obj = consent;
		if (~(initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string consent2 = default;
			JS_PokiSDK_togglePlayerAdvertisingConsent(consent2);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PokiUnitySDK pokiUnitySDK = default;
			pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
			pokiUnitySDK.setPlayerAge(0);
		}
	}

	public void gameLoadingProgress(LoadingProgressData data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005d: Expected I4, but got Obj
		object obj = data & 1;
		object obj2 = obj;
		if (~(initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
			string text = default;
			string intensity = text.ToLowerInvariant();
			JS_PokiSDK_happyTime(intensity);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PokiUnitySDK pokiUnitySDK = default;
			pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
			pokiUnitySDK.togglePlayerAdvertisingConsent(consent: false);
		}
	}

	public void gameplayStart()
	{
		//IL_002c: Expected I4, but got Obj
		if (~(initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @41");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PokiUnitySDK pokiUnitySDK = default;
		pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public void gameplayStop()
	{
		//IL_002c: Expected I4, but got Obj
		if (~(initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PokiUnitySDK pokiUnitySDK = default;
		pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public void commercialBreak()
	{
		//IL_002c: Expected I4, but got Obj
		if (~(initialized ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @46");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PokiUnitySDK pokiUnitySDK = default;
		pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public void rewardedBreak()
	{
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_004c: Expected I4, but got Obj
		//IL_01ca: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		//IL_00b9: Expected I, but got Obj
		//IL_0106: Expected I, but got Obj
		isShowingAd__BackingField = true;
		if (~(adblocked ? 1u : 0u) == 0)
		{
			((LegalKeys)(object)this)._002Ector();
			return;
		}
		if (~(initialized ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PokiUnitySDK pokiUnitySDK = default;
			pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3D");
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v14 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool musicEnabled = PreferencesSave.musicEnabled;
		bool topRunChallengersEnabled = PreferencesSave.topRunChallengersEnabled;
		nint num3 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S2_v4 (Il2CppClass<HouseKeeper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S2_v9 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((HouseKeeper)musicEnabled).OnOpenedThroughNotification((Notification)topRunChallengersEnabled);
		OfferWallManager instance = OfferWallManager.instance;
		((AdSystemManager)(object)instance).EnableAudio();
	}

	public void happyTime(float intensity)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got F4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got F4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0088: Invalid comparison between F4 and Obj
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_0476: Invalid comparison between F4 and Obj
		//IL_041f: Expected I, but got Obj
		//IL_0435: Expected Obj, but got I
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_04c0: Expected F4, but got Obj
		//IL_012b: Expected F8, but got I4
		//IL_04eb: Expected Obj, but got I
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected Obj, but got Unknown
		//IL_0168: Expected F8, but got I4
		//IL_01a5: Expected F8, but got I4
		//IL_01b3: Expected F8, but got I4
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got Unknown
		//IL_01f0: Expected F8, but got I4
		//IL_022d: Expected F8, but got I4
		//IL_023b: Expected F8, but got I4
		//IL_05d1: Expected Obj, but got F8
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_0278: Expected F8, but got I4
		//IL_02b5: Expected F8, but got I4
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected Obj, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected Obj, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_0396: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I4
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected Obj, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_03c7: Expected Obj, but got I4
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (PokiUnitySDK)+34]");
		if ((nint)0 == 0)
		{
			return;
		}
		object obj = this + 36;
		float num = (float)obj + intensity;
		obj = num;
		object obj2 = this + 40;
		float num2 = (float)obj2 + intensity;
		obj2 = num2;
		object obj3 = this + 44;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
		bool flag2 = !flag;
		float num3 = num2;
		if (!flag2)
		{
			object obj4 = this + 88;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD");
				object obj5 = default;
				double num4 = (double)obj5 * 1000000.0;
				if (num4 != num4)
				{
					num4 = 0.0;
				}
				else if (!(num4 < 1.8446744073709552E+19))
				{
					num4 = 0.0;
				}
				else if (!(num4 > -1.0))
				{
					num4 = 0.0;
				}
				object obj6 = obj4;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v27+8]");
				object obj8 = (nint)0 & (nint)0xFF;
				object obj9 = obj8 + 401;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v181 @ S1_v30 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DD");
				object obj10 = default;
				double num5 = (double)obj10 * 1000000.0;
				if (num5 != num5)
				{
					num5 = 0.0;
				}
				else if (!(num5 < 1.8446744073709552E+19))
				{
					num5 = 0.0;
				}
				else if (!(num5 > -1.0))
				{
					num5 = 0.0;
				}
				double num6 = num5 - num4;
				object obj11 = this + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [208900]");
				double num7 = 0.0 * num6;
				double num8 = num7 + 0.5;
				if (num8 != num8)
				{
					num8 = 0.0;
				}
				else if (!(num8 < 1.8446744073709552E+19))
				{
					num8 = 0.0;
				}
				else if (!(num8 > -1.0))
				{
					num8 = 0.0;
				}
				double num9 = (double)obj11 + num8;
				obj11 = num9;
				object obj12 = this + 60;
				object obj14 = default;
				object obj13 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12)) ? obj12 : obj14);
				obj12 = obj13;
				object obj15 = this - -64;
				object obj16 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15)) ? obj15 : obj14);
				obj15 = obj16;
				object obj17 = this + 56;
				object obj18 = obj17 + 1;
				obj17 = obj18;
				object obj19 = this + 68;
				object obj23;
				object obj24;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
				{
					object obj20 = obj14 - obj19;
					object obj21 = obj20 / obj18;
					object obj22 = obj19 + obj21;
					obj19 = obj22;
					obj23 = obj14 - obj22;
					obj24 = obj20;
				}
				else
				{
					object obj25 = obj19 - obj14;
					object obj26 = obj25 / obj18;
					object obj27 = obj19 - obj26;
					obj19 = obj27;
					obj23 = obj27 - obj14;
					obj24 = obj25;
				}
				object obj28 = this + 72;
				object obj29 = obj24 * obj23;
				object obj30 = obj28 + obj29;
				obj28 = obj30;
				object obj31 = this + 92;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (PokiUnitySDK)+64]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (PokiUnitySDK)+64]");
					object obj32 = (nint)0 + (nint)(-1);
					object obj33;
					if ((nint)obj32 > 0)
					{
						obj33 = 0;
						while (true)
						{
							object obj34 = obj33 << 2;
							object obj35 = obj31 + obj34;
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35))
							{
								break;
							}
							object obj36 = obj33 + 1;
							bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32);
							obj33 = obj36;
							if (!flag3)
							{
								obj33 = obj36;
								break;
							}
						}
					}
					else
					{
						obj33 = 0;
					}
					object obj37 = obj33 << 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (PokiUnitySDK)+6C]");
					object obj38 = 0 + obj37;
					object obj39 = obj38 + 1;
					obj38 = obj39;
				}
			}
			object obj40 = obj - obj3;
			obj = obj40;
			num3 = (float)obj2;
		}
		object obj41 = this + 48;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41))
		{
			nint num10 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S2_v5 (Il2CppClass<PokiUnitySDK>)+14]");
			object obj42 = (nint)0 & (nint)0x3FFF;
			object obj43 = obj42 + 80504;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v149 @ S2_v8 (should have been resolved before IL gen)");
			object obj44 = obj2 - obj41;
			obj2 = obj44;
		}
	}

	public void displayAd(string identifier, string size, string top, string left)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @55D6");
	}

	public void destroyAd(string identifier)
	{
		//IL_0042: Expected I4, but got Obj
		//IL_0013: Expected Obj, but got I4
		if (~(initialized ? 1u : 0u) == 0)
		{
			object indentifier = JsonUtility.FromJson(identifier, (Type)1);
			JS_PokiSDK_roundStart((string)indentifier);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PokiUnitySDK pokiUnitySDK = default;
			pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
			pokiUnitySDK.gameLoadingProgress(null);
		}
	}

	public void checkInit()
	{
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_018f: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_0051: Expected I4, but got Obj
		//IL_01cf: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_00be: Expected I, but got Obj
		//IL_010b: Expected I, but got Obj
		isShowingAd__BackingField = true;
		if (~(adblocked ? 1u : 0u) == 0)
		{
			((AdSystemDebugLabel)this).FinishedShowingAd("false");
			return;
		}
		if (~(initialized ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PokiUnitySDK pokiUnitySDK = default;
			pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @49");
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v14 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v22 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool musicEnabled = PreferencesSave.musicEnabled;
		bool topRunChallengersEnabled = PreferencesSave.topRunChallengersEnabled;
		nint num3 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v4 (Il2CppClass<HouseKeeper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v9 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((HouseKeeper)musicEnabled).OnOpenedThroughNotification((Notification)topRunChallengersEnabled);
		OfferWallManager instance = OfferWallManager.instance;
		((AdSystemManager)(object)instance).EnableAudio();
	}

	public void ready()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public void adblock()
	{
		initialized = true;
	}

	public void commercialBreakCompleted()
	{
		initialized = true;
		adblocked = true;
	}

	public void rewardedBreakCompleted(string withReward)
	{
		//IL_002b: Expected I4, but got Obj
		if (~(initialized ? 1u : 0u) == 0)
		{
			((PokiUnitySDK)(object)withReward)._002Ector();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PokiUnitySDK pokiUnitySDK = default;
		pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
		pokiUnitySDK.destroyAd(null);
	}
}
