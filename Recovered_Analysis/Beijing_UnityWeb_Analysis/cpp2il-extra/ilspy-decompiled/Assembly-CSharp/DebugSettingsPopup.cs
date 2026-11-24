using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using AppRefresh;
using Cloud;
using Cpp2ILInjected;
using Data.DebugUtil;
using Data.Managers;
using Data.Migration;
using Data.Save;
using Info;
using Kiloo.Common.Ads;
using Kiloo.Common.HTTP;
using Kiloo.Common.OnGUIWrappers;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.UI;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin;
using Missions;
using SYBO.Common.Automation;
using SYBO.Common.Automation.Steps;
using SYBO.Common.StateSystem;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Info;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Utilities;
using UI.Screens;
using UI.SlideIns;
using UnityEngine;
using UnityEngine.Networking;
using WeeklyHunt;
using WordHunt;

public class DebugSettingsPopup : UIScreen
{
	public enum DebugNotificationType
	{
		Test,
		Coins,
		TopRun,
		MB,
		SMB,
		Video
	}

	public enum DebugGuidelineType
	{
		Empty,
		Hoverboards,
		FacebookConnect,
		Missions,
		CollectGold
	}

	[Serializable]
	public class SybotRequestData
	{
		public string user_id;
	}

	public class DebugSettingsListAdapter : ListAdapter<DebugSettingsCell>
	{
		public DebugSettingsPopup debugSettingsPopup;

		public GameObject debugTitlePrefab;

		public GameObject debugTogglePrefab;

		public GameObject debugButtonPrefab;

		public GameObject debugSubButtonPrefab;

		public GameObject debugSubTogglePrefab;

		public GameObject debugExpandablePrefab;

		public GameObject debugSpacePrefab;

		private const int DEBUGSETTINGS_TOGGLE_PREFAB = 0;

		private const int DEBUGSETTINGS_BUTTON_PREFAB = 1;

		private const int DEBUGSETTINGS_SUBTOGGLE_PREFAB = 2;

		private const int DEBUGSETTINGS_SPACE_PREFAB = 3;

		private const int DEBUGSETTINGS_EXPANDABLE_PREFAB = 4;

		private const int DEBUGSETTINGS_TITLE_PREFAB = 5;

		private const int DEBUGSETTINGS_SUBBUTTON_PREFAB = 6;

		public unsafe DebugSettingsListAdapter(List<DebugSettingsCell> contentList, GameObject debugSettingsTogglePrefab, GameObject debugSettingsButtonPrefab, GameObject debugSettingsSubTogglePrefab, GameObject debugSettingsSpacePrefab, GameObject debugSettingsExpandablePrefab, GameObject debugSettingsTitlePrefab, GameObject debugSettingsSubButtonPrefab, DebugSettingsPopup screenReference)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8e: Expected Obj, but got Unknown
			//IL_0139: Expected Obj, but got I4
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected Obj, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Expected Obj, but got Unknown
			//IL_024e: Expected I4, but got Obj
			//IL_024e: Expected Ref, but got VT
			//IL_026c: Expected I4, but got Obj
			//IL_026c: Expected I4, but got Obj
			//IL_026c: Expected Obj, but got I4
			//IL_026c: Expected I4, but got Obj
			//IL_0275: Expected Obj, but got I4
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected Obj, but got Unknown
			//IL_0d3e: Expected Obj, but got I4
			//IL_0322: Expected Obj, but got I4
			//IL_032f: Expected Obj, but got I4
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected Obj, but got Unknown
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Expected Obj, but got Unknown
			//IL_0dd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd9: Expected Obj, but got Unknown
			//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de7: Expected Obj, but got Unknown
			//IL_0df0: Expected Obj, but got I4
			//IL_0df9: Expected Obj, but got I4
			//IL_0e02: Expected Obj, but got I4
			//IL_0418: Expected Obj, but got I4
			//IL_047f: Expected Obj, but got I4
			//IL_048c: Expected Obj, but got I4
			//IL_0c22: Expected I4, but got Obj
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_0546: Expected Obj, but got Unknown
			//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a7: Expected Obj, but got Unknown
			//IL_068c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0691: Expected Obj, but got Unknown
			//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ba: Expected Obj, but got Unknown
			//IL_0e9a: Expected Obj, but got I4
			//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a10: Expected Obj, but got Unknown
			//IL_0a39: Expected Obj, but got I4
			//IL_08ce: Expected Obj, but got I
			//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f61: Expected Obj, but got Unknown
			//IL_0f9d: Expected I4, but got Obj
			//IL_0f9d: Expected I4, but got Obj
			//IL_0faa: Expected Obj, but got I4
			//IL_098c: Expected Obj, but got I4
			//IL_0955: Expected Obj, but got I4
			//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bac: Expected Obj, but got Unknown
			//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7b: Expected Obj, but got Unknown
			//IL_0ab4: Expected Obj, but got I
			//IL_0904: Unknown result type (might be due to invalid IL or missing references)
			//IL_0909: Expected Obj, but got Unknown
			//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae1: Expected Obj, but got Unknown
			//IL_0b0a: Expected Obj, but got I4
			//IL_093a: Unknown result type (might be due to invalid IL or missing references)
			//IL_093f: Expected Obj, but got Unknown
			//IL_0b38: Expected I, but got Obj
			//IL_0b4e: Expected Obj, but got I
			//IL_0b79: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 16;
			object obj3 = obj2 + 8;
			obj3 = obj;
			_ = -1;
			if (contentList == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ArgumentOutOfRangeException ex = default;
				ex._002Ector("data");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			if (this == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ArgumentOutOfRangeException ex2 = default;
				ex2._002Ector("path");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			if ((nint)debugSettingsButtonPrefab <= -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ArithmeticException ex3 = default;
				ex3._002Ector("offset");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			GameObject gameObject;
			if ((nint)debugSettingsSubTogglePrefab == -1)
			{
				bool flag = (nint)debugSettingsButtonPrefab >= 1;
				bool flag2 = !flag;
				gameObject = (GameObject)contentList._size;
				if (!flag2)
				{
					GameObject gameObject2 = (GameObject)(contentList._size - debugSettingsButtonPrefab);
					gameObject = gameObject2;
				}
			}
			else
			{
				gameObject = debugSettingsSubTogglePrefab;
			}
			if ((nint)gameObject >= 0)
			{
				object obj4 = (object)gameObject + (object)debugSettingsButtonPrefab;
				if ((nint)obj4 <= contentList._size)
				{
					List<DebugSettingsCell> data;
					if ((object)debugSettingsTogglePrefab == null || ((UnityEngine.Object)debugSettingsTogglePrefab).m_CachedPtr == (IntPtr)0)
					{
						data = contentList;
					}
					else
					{
						Encoding uTF = Encoding.UTF32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
						Array.SorterObjectArray sorterObjectArray = default;
						object obj5 = sorterObjectArray + 12;
						object obj6 = (object)gameObject + obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						int num = default;
						((Array.SorterObjectArray*)sorterObjectArray)->SwapIfGreaterWithItems(num, (int)obj5);
						Array.ConstrainedCopy((Array)(object)contentList, (int)debugSettingsButtonPrefab, (Array)num, (int)obj5, (int)gameObject);
						data = (List<DebugSettingsCell>)num;
					}
					byte[] array = Checksum.ComputeMD5((byte[])(object)data);
					object obj7 = debugSettingsSpacePrefab + 1;
					bool flag3 = (object)debugSettingsTitlePrefab != null;
					bool flag4 = !flag3;
					object obj8 = obj7;
					if (!flag4)
					{
						object obj9 = debugSettingsSubButtonPrefab + 1;
						object obj10 = obj9 + obj7;
						obj8 = obj10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					bool flag5 = (nint)debugSettingsSpacePrefab < 1;
					bool flag6 = (nint)debugSettingsExpandablePrefab < 1;
					object obj11 = flag5 & flag6;
					if (obj11 != null)
					{
						throw new ArrayTypeMismatchException();
					}
					byte[] array2 = FileUtil.TryLoadFile((string)(object)this, (byte[])1);
					object obj12 = 0;
					byte[] array3 = array2;
					object obj13 = default;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) <= System.Runtime.CompilerServices.Unsafe.As<GameObject, UIntPtr>(ref debugSettingsSpacePrefab))
					{
						byte[] array4 = (byte[])(array3 + 1);
						bool flag7 = System.Runtime.CompilerServices.Unsafe.As<byte[], UIntPtr>(ref array4) >= System.Runtime.CompilerServices.Unsafe.As<GameObject, UIntPtr>(ref debugSettingsExpandablePrefab);
						bool flag8 = !flag7;
						array3 = array4;
						if (!flag8)
						{
							array3 = null;
						}
						obj2 = array3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						string text2 = default;
						string text = (string)(object)this + "." + text2;
						throw new ArrayTypeMismatchException();
					}
					object obj14 = obj12;
					if (flag3)
					{
						bool flag9 = (nint)debugSettingsSubButtonPrefab < 1;
						bool flag10 = (nint)screenReference < 1;
						object obj15 = flag9 & flag10;
						if (obj15 != null)
						{
							throw new ArrayTypeMismatchException();
						}
						byte[] array5 = FileUtil.TryLoadFile((string)(object)debugSettingsTitlePrefab, (byte[])1);
						object obj16 = 0;
						byte[] array6 = array5;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) <= System.Runtime.CompilerServices.Unsafe.As<GameObject, UIntPtr>(ref debugSettingsSubButtonPrefab))
						{
							byte[] array7 = (byte[])(array6 + 1);
							bool flag11 = System.Runtime.CompilerServices.Unsafe.As<byte[], UIntPtr>(ref array7) >= System.Runtime.CompilerServices.Unsafe.As<DebugSettingsPopup, UIntPtr>(ref screenReference);
							bool flag12 = !flag11;
							byte[] array8 = array7;
							if (!flag12)
							{
								array8 = null;
							}
							obj2 = array8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							string text4 = default;
							string text3 = (string)(object)debugSettingsTitlePrefab + "." + text4;
							throw new ArrayTypeMismatchException();
						}
					}
					object obj18 = default;
					object obj17 = obj18 + 12;
					object obj19 = array + 12;
					object obj20 = 0;
					object obj21 = 0;
					object obj22 = 0;
					object obj33 = default;
					object obj35 = default;
					object obj36 = default;
					object obj37 = default;
					object obj38 = default;
					object obj43 = default;
					object obj44 = default;
					object obj46 = default;
					object obj47 = default;
					int count = default;
					object obj65 = default;
					MemoryStream memoryStream = default;
					while (true)
					{
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
						{
							object obj23 = obj18 + 16;
							object obj24 = obj21 << 2;
							object obj25 = obj23 + obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj26 = obj18 + 16;
							object obj27 = obj21 << 2;
							object obj28 = obj26 + obj27;
							object obj29 = obj18 + 16;
							object obj30 = obj21 << 2;
							object obj31 = obj29 + obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj32 = obj33;
							obj20 = 1;
							object obj34 = obj35;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
							if (obj32 == obj36)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
								obj22 = obj37;
								if (obj38 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
								if ((nint)0 != -1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
									object obj39 = (nint)0 << 2;
									object obj40 = obj3 + obj39;
									if ((nint)obj40 == 498)
									{
										object obj41 = obj3 + 4;
										if ((nint)obj41 > -1)
										{
											object obj42 = obj41 + -1;
											obj41 = obj42;
										}
										goto IL_0b9e;
									}
								}
								if (obj22 == null)
								{
									obj22 = 0;
									goto IL_0b9e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj32 = obj33;
								obj34 = obj43;
								obj22 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
							object obj64;
							if (obj32 == obj44)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
								object obj45 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								if (obj47 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
									object obj48 = obj18 + 16;
									object obj49 = obj21 << 2;
									object obj50 = obj48 + obj49;
									int num2 = ((string)obj50).LastIndexOfAny((char[])47);
									if (num2 >= 0)
									{
										object obj51 = obj18 + 16;
										object obj52 = obj21 << 2;
										object obj53 = obj51 + obj52;
										object obj54 = obj53;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ S1_v73+8]");
										object obj55 = -1;
										if (num2 < (nint)obj55)
										{
											object obj56 = obj18 + 16;
											object obj57 = obj21 << 2;
											object obj58 = obj56 + obj57;
											char[] trimChars = (char[])(num2 + 1);
											string text5 = ((string)obj58).Trim(trimChars);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
											nint num3 = (nint)typeof(Flurry);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ S0_v140 (Il2CppClass<Flurry>)+BA]");
											object obj59 = (nint)0 & (nint)0x200;
											if (obj59 != null)
											{
												nint num4 = (nint)typeof(Flurry);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1046 @ S0_v143 (Il2CppClass<Flurry>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
										}
									}
									object obj60 = obj18 + 16;
									object obj61 = obj21 << 2;
									object obj62 = obj60 + obj61;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
									int num5 = "Error saving file: ".IndexOf((char)(int)obj62, (int)": ", count);
									FileUtil.LogWarning((string)num5);
									goto IL_0b9e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
								object obj63 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
								obj64 = obj65;
								break;
							}
							obj64 = obj34;
							break;
						}
						if (obj20 != null)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						memoryStream._002Ector((int)"All attempts to write failed");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
						break;
						IL_0b9e:
						object obj66 = obj21 + 1;
						obj21 = obj66;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArithmeticException ex4 = default;
			ex4._002Ector("length");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		public void SetNewDataList(List<DebugSettingsCell> leaderboardListT)
		{
		}

		public override int GetModelType(int index)
		{
			//IL_0020: Expected Obj, but got I4
			object obj = index + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}

		public unsafe override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected I4, but got Unknown
			//IL_001e: Expected I4, but got Obj
			//IL_0067: Expected Obj, but got I4
			//IL_0074: Expected I4, but got Obj
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_004b: Expected Obj, but got VT
			object obj = default;
			SecretPopupTabHelper.Tabs tabs = (SecretPopupTabHelper.Tabs)(obj + 8);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8B88");
			Container container2 = default;
			Container container3 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				container3.Measure((byte)(int)debugSettingsPopup != 0);
				object obj2 = container3 + 84;
				_0021_00210 componentInChildren = (_0021_00210)container3.model.GetComponentInChildren<T>();
				obj2 = componentInChildren;
			}
			if (!isMeasurePass)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				obj = ((SecretPopupTabHelper.Tabs*)(int)tabs)->value__;
				((SecretPopupTabHelper.Tabs*)(int)tabs)->value__ = (int)obj;
				SecretPopupTabHelper secretPopupTabHelper = default;
				secretPopupTabHelper.SetTabActivation(tabs);
			}
			return container3;
		}
	}

	private enum TabNumber
	{
		Tab1,
		Tab2,
		Tab3,
		Tab4
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static WebClient.RequestCompleteHandler _003C_003E9__140_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CelebrationTesterPopup._003C_003Ec obj = default;
			CelebrationTesterPopup._003C_003Ec._003C_003E9 = obj;
		}

		internal void _003CRequestAnalyticsCheck_003Eb__140_0(IRequest request, bool cache)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			//IL_006c: Expected Obj, but got I4
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = this + 16;
			obj6 = cache;
		}
	}

	private static bool forceRefreshAdSystem__BackingField;

	private GameObject DebugSettingsTogglePrefab;

	private GameObject DebugSettingsSubTogglePrefab;

	private GameObject DebugSettingsExpandablePrefab;

	private GameObject DebugSettingsButtonPrefab;

	private GameObject DebugSettingsSpacePrefab;

	private GameObject DebugSettingsTitlePrefab;

	private GameObject DebugSettingsSubButtonPrefab;

	private GameObject TabsParent;

	private int lastTab1Index;

	private int lastTab2Index;

	private int lastTab3Index;

	private int lastTab4Index;

	private TabNumber lastTabOpen;

	private bool _listHasBeenDisplayedOnce;

	private const string KilooGoogleSheetID = "1d4AZJWVKm1c438UX21RZIMHGpzjRd013Bmk10_n5tmU";

	private static bool _isShowingFps;

	public static Dictionary<string, string> completeAwardsTiersSelectedItems;

	public static int completeAwardsTiersSelectedTiers;

	public static Dictionary<string, string> almostCompleteAwardsTiersSelectedItems;

	public static int amountOfHuntTokensToReward;

	public static int amountOfMissionSetsToSkip;

	public static DebugNotificationType notificationTypeToDisplay;

	private static DebugGuidelineType _guidelineToDebug;

	public static float TimeScaleInGameOverrideSelectedValue;

	public static float TimeScaleInMenuOverrideSelectedValue;

	private List<DebugSettingsCell> _contentList;

	private DebugSettingsListAdapter _adapter;

	private ScrollView _scrollView;

	public static bool DownloadNewOS;

	public static bool RefreshInterstitials;

	public static bool RefreshVideoAds;

	private bool _isDailyWordCompletedeChangeRegistered;

	public static bool HasDeliveredFullUpgrades;

	public static bool ScreenTimoutDisabled;

	public static bool HasSkippedMissions;

	public static bool PrintRouteChunksInDebugLabel;

	private static Action<bool> m_OnRoutePrintSettingChanged;

	private int _originalScreenTimout;

	private static bool _shouldRefreshListOnShow;

	private const string ScreenTimeoutTitle = "Screen Timeout Disabled";

	private const string ScreenTimeoutDescription = "Enables / disables screen timeout";

	private const string ScreenTimeoutFunc = "ToggleScreenTimeout";

	private GameObject fpsObject;

	public static bool forceRefreshAdSystem
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CollectCoinsScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<CollectCoinsScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CollectCoinsScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<CollectCoinsScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return CollectCoinsScreenManager._instance != null;
		}
		private set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected Obj, but got Unknown
			//IL_00cd: Expected Obj, but got I4
			//IL_00eb: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<UnityEngine.Vector3>)+74]");
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
			object obj4 = (value ? 1 : 0) + 48;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
			_ = 0;
			((UpgradeScreen)value).Start();
		}
	}

	public static bool IsShowingFPS
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return forceRefreshAdSystem__BackingField;
		}
	}

	public static DebugGuidelineType guidelineToDebug
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return _isShowingFps ? DebugGuidelineType.Hoverboards : DebugGuidelineType.Empty;
		}
		set
		{
			//IL_0107: Expected I, but got Obj
			//IL_011d: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected Obj, but got I4
			//IL_00cf: Expected Obj, but got I4
			//IL_00cf: Expected Obj, but got I
			//IL_00cf: Expected Obj, but got I
			//IL_00cf: Expected Obj, but got I
			//IL_00cf: Expected Obj, but got I
			//IL_00cf: Expected Obj, but got I
			//IL_00cf: Expected Obj, but got I
			//IL_00e2: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A1E5");
			nint num = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v38 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_shouldRefreshListOnShow = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (DebugSettingsPopup+DebugGuidelineType)+60]");
			if ((nint)0 != 0)
			{
				object assemblyInfo = value - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (DebugSettingsPopup+DebugGuidelineType)+60]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (DebugSettingsPopup+DebugGuidelineType)+28]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (DebugSettingsPopup+DebugGuidelineType)+34]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (DebugSettingsPopup+DebugGuidelineType)+2C]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (DebugSettingsPopup+DebugGuidelineType)+38]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (DebugSettingsPopup+DebugGuidelineType)+30]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (DebugSettingsPopup+DebugGuidelineType)+3C]");
				System.Runtime.Serialization.Formatters.Binary.ObjectMap objectMap = default;
				objectMap._002Ector((string)num3, (string[])num4, (System.Runtime.Serialization.Formatters.Binary.BinaryTypeEnum[])num5, (object[])num6, (int[])num7, (System.Runtime.Serialization.Formatters.Binary.ObjectReader)num8, 0, (System.Runtime.Serialization.Formatters.Binary.BinaryAssemblyInfo)assemblyInfo, (System.Runtime.Serialization.Formatters.Binary.SizedArray)value);
				object obj2 = value + 100;
				obj2 = objectMap;
			}
		}
	}

	public static event Action<bool> OnRoutePrintSettingChanged
	{
		add
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected I4, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (byte)(value & 1) != 0;
			forceRefreshAdSystem__BackingField = flag;
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = DebugSettingsPopup.m_OnRoutePrintSettingChanged;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<DebugSettingsPopup>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(DebugSettingsPopup);
				if (!flag)
				{
					nint num5 = (nint)typeof(DebugSettingsPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(DebugSettingsPopup);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(DebugSettingsPopup);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<DebugSettingsPopup>)+5C]");
				object obj5 = (nint)0 + (nint)48;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public override void Init()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = DebugSettingsPopup.m_OnRoutePrintSettingChanged;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(DebugSettingsPopup);
			if (!flag)
			{
				nint num5 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(DebugSettingsPopup);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(DebugSettingsPopup);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<DebugSettingsPopup>)+5C]");
			object obj5 = (nint)0 + (nint)48;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	public override void Hide()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_guidelineToDebug = (DebugGuidelineType)this;
	}

	public override void Show()
	{
		//IL_0525: Expected I, but got Obj
		//IL_053b: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0588: Expected I, but got Obj
		//IL_059e: Expected Obj, but got I
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0373: Expected I, but got Obj
		//IL_0389: Expected Obj, but got I
		//IL_0298: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_02e5: Expected I, but got Obj
		//IL_02fb: Expected Obj, but got I
		//IL_020a: Expected I, but got Obj
		//IL_03b4: Expected I, but got Obj
		//IL_0616: Expected Obj, but got I4
		//IL_0407: Expected I, but got Obj
		//IL_041d: Expected Obj, but got I
		//IL_0326: Expected I, but got Obj
		//IL_0664: Expected I, but got Obj
		//IL_067a: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I4
		//IL_0448: Expected I, but got Obj
		//IL_0495: Expected I, but got Obj
		//IL_050b: Expected Obj, but got I4
		base.LoseFocus();
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v139 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(DownloadNewOS ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v116 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v133 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DownloadNewOS = false;
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v123 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v129 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			((OnlineSettings)(object)saveDataPath).LoadFromFile();
		}
		nint num7 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v109 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(RefreshInterstitials ? 1u : 0u) == 0)
		{
			nint num9 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v96 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v103 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RefreshInterstitials = false;
			((DebugSettingsPopup)null).StartBenchmarkConfirmed((string)null);
		}
		nint num11 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v25 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v89 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(RefreshVideoAds ? 1u : 0u) == 0)
		{
			nint num13 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v76 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num14 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v83 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RefreshVideoAds = false;
			((DebugSettingsPopup)null).StartBenchmarkConfirmed((string)1);
		}
		nint num15 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v34 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num16 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v71 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @93AB");
		object obj9 = default;
		if (obj9 == null)
		{
			return;
		}
		((DebugSettingsPopup)null).ForceDownloadOnlineSettings();
		nint num17 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v43 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num18 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v67 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @93A0");
		_shouldRefreshListOnShow = true;
		nint num19 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v52 (Il2CppClass<UIScreenController>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num20 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v63 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		UIScreen uIScreen = ((UIScreenController)flag)._ActivateScreen("FrontScreen");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Component component = default;
		string text = component.tag;
		((GameObject)(object)text).tag = null;
		string text2 = component.tag;
		((GameObject)(object)text2).tag = (string)1;
	}

	private void ScrollToLastIndex(TabNumber tab)
	{
		if (((UnityEngine.Object)this).m_CachedPtr != (IntPtr)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CE4");
		}
	}

	private void SaveIndex()
	{
		//IL_0240: Expected I, but got Obj
		//IL_0256: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_013a: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_01c8: Expected I, but got Obj
		//IL_00ed: Expected I, but got Obj
		base.Hide();
		if (~(_isDailyWordCompletedeChangeRegistered ? 1u : 0u) != 0)
		{
			nint num = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v40 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v60 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (WordHuntManager.IsActiveDailyLetterEvent())
			{
				_isDailyWordCompletedeChangeRegistered = true;
				nint num3 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v48 (Il2CppClass<DebugSettingsPopup>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(DebugSettingsPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v54 (Il2CppClass<DebugSettingsPopup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_shouldRefreshListOnShow = true;
			}
		}
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v11 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v33 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_shouldRefreshListOnShow ? 1u : 0u) != 0)
		{
			return;
		}
		nint num7 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v20 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_shouldRefreshListOnShow = false;
		DisplayTab1();
	}

	private void SetContent()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00c1: Expected I4, but got Obj
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00de: Expected I4, but got Obj
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00fb: Expected I4, but got Obj
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0118: Expected I4, but got Obj
		if (~(_listHasBeenDisplayedOnce ? 1u : 0u) != 0)
		{
			return;
		}
		Container lastVisibleContainerOnScreen = _scrollView.GetLastVisibleContainerOnScreen();
		if (lastTabOpen != TabNumber.Tab1)
		{
			if (lastTabOpen != TabNumber.Tab2)
			{
				if (lastTabOpen != TabNumber.Tab3)
				{
					if (lastTabOpen == TabNumber.Tab4)
					{
						object obj = lastVisibleContainerOnScreen - -64;
						lastTab4Index = (int)obj;
					}
				}
				else
				{
					object obj2 = lastVisibleContainerOnScreen - -64;
					lastTab3Index = (int)obj2;
				}
			}
			else
			{
				object obj3 = lastVisibleContainerOnScreen - -64;
				lastTab2Index = (int)obj3;
			}
		}
		else
		{
			object obj4 = lastVisibleContainerOnScreen - -64;
			lastTab1Index = (int)obj4;
		}
	}

	public void DisplayTab1()
	{
		//IL_0010: Expected Obj, but got I4
		TabsParent.tag = (string)1;
		ForceRefreshAdSystem((AdType)lastTabOpen);
	}

	public void DisplayTab2()
	{
		ForceRefreshAdSystem(AdType.Interstitial);
	}

	public void DisplayTab3()
	{
		ForceRefreshAdSystem(AdType.Video);
	}

	public void DisplayTab4()
	{
		ForceRefreshAdSystem((AdType)2);
	}

	private void SetContentList(TabNumber tab)
	{
		//IL_0083: Expected VT, but got I4
		//IL_0092: Expected VT, but got I4
		//IL_00a1: Expected VT, but got I4
		//IL_00b0: Expected VT, but got I4
		//IL_00be: Expected VT, but got I4
		Vector3 localOffset = tab switch
		{
			TabNumber.Tab1 => (Vector3)lastTab1Index, 
			TabNumber.Tab2 => (Vector3)lastTab2Index, 
			TabNumber.Tab3 => (Vector3)lastTab3Index, 
			TabNumber.Tab4 => (Vector3)lastTab4Index, 
			_ => (Vector3)0, 
		};
		_scrollView.SmoothScrollToOffset(localOffset, (Action)null, 0f);
	}

	private void InsertGroupTitle(string title, string description)
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)DebugSettingsSpacePrefab).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	private void InsertGroupTopToggle(string title, string description, string functionName, DebugSetting settingType)
	{
		//IL_00c8: Expected I4, but got Obj
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00e0: Expected I4, but got Obj
		//IL_001b: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_005c: Expected I, but got Obj
		((UILabel)(object)DebugSettingsTitlePrefab).fontSize = (int)title;
		object obj = this - -64;
		((UILabel)obj).fontSize = (int)description;
		if (settingType == DebugSetting.Characters)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)TabsParent).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			int fontSize = default;
			((UILabel)(object)TabsParent).fontSize = fontSize;
		}
	}

	private void InsertToggle(string title, string description, string functionName, DebugSetting settingType)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingsCell debugSettingsCell = default;
		debugSettingsCell.cellType = DebugSettingsCellType.Toggle;
		object obj = debugSettingsCell + 16;
		obj = title;
		object obj2 = debugSettingsCell + 20;
		obj2 = description;
		object obj3 = debugSettingsCell + 24;
		obj3 = functionName;
		debugSettingsCell.settingType = settingType;
		_contentList.Add(debugSettingsCell);
	}

	private void InsertButton(string title, string description, string functionName, ButtonIcon buttonIcon)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingsCell debugSettingsCell = default;
		debugSettingsCell.cellType = DebugSettingsCellType.Toggle;
		object obj = debugSettingsCell + 16;
		obj = title;
		object obj2 = debugSettingsCell + 20;
		obj2 = description;
		object obj3 = debugSettingsCell + 24;
		obj3 = functionName;
		debugSettingsCell.settingType = (DebugSetting)buttonIcon;
		_contentList.Add(debugSettingsCell);
		ResetList();
	}

	private void InsertGroupSubButton(string title, string buttonText, string functionName)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I4
		//IL_0012: Expected I4, but got Obj
		object obj = title & 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (DebugSettingsPopup)+41]");
		bool flag = (nint)0 != 0;
		((Component)(object)screenName).tag = (string)flag;
		string text = tag;
		BoxCollider component = ((GameObject)(object)text).GetComponent<BoxCollider>();
		component.isTrigger = (byte)(int)title != 0;
		((GameObject)(object)base.parentScreen__BackingField).tag = null;
		DebugSettingsTogglePrefab.tag = buttonText;
		DebugSettingsSubTogglePrefab.tag = functionName;
	}

	private void InsertGroupToggle(string title, string functionName, DebugSetting settingType)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingsCell debugSettingsCell = default;
		debugSettingsCell.cellType = DebugSettingsCellType.SubButton;
		object obj = debugSettingsCell + 16;
		obj = title;
		object obj2 = debugSettingsCell + 20;
		obj2 = functionName;
		object obj3 = debugSettingsCell + 24;
		obj3 = settingType;
		_contentList.Add(debugSettingsCell);
	}

	private void InsertGroupExpandable(string title, DebugSetting settingType, bool multiSelect = false)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingsCell debugSettingsCell = default;
		debugSettingsCell.cellType = DebugSettingsCellType.SubToggle;
		object obj = debugSettingsCell + 16;
		obj = title;
		object obj2 = debugSettingsCell + 24;
		obj2 = settingType;
		debugSettingsCell.settingType = (multiSelect ? DebugSetting.Boards : DebugSetting.Characters);
		_contentList.Add(debugSettingsCell);
	}

	private void InsertGroupBottom()
	{
		ForceRefreshAdSystem((AdType)3);
	}

	private void AddSpace()
	{
		ResetList();
	}

	private void ResetList()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DebugSettingsCell debugSettingsCell = default;
		debugSettingsCell.cellType = DebugSettingsCellType.Space;
		_contentList.Add(debugSettingsCell);
	}

	public static bool IsAllowingDebugging()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)_guidelineToDebug != 0;
	}

	private void ForceRefreshAdSystem(AdType adType)
	{
		//IL_00f6: Expected I4, but got Obj
		//IL_0110: Expected I4, but got Obj
		//IL_0125: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I4
		//IL_00ac: Expected I4, but got Obj
		//IL_00ac: Expected I4, but got Obj
		//IL_00ac: Expected I4, but got Obj
		//IL_00c1: Expected I4, but got Obj
		//IL_03f2: Expected Obj, but got I4
		//IL_03f2: Expected I4, but got Obj
		//IL_013f: Expected I4, but got Obj
		//IL_0154: Expected I4, but got Obj
		//IL_040c: Expected I4, but got Obj
		//IL_016e: Expected I4, but got Obj
		//IL_0183: Expected I4, but got Obj
		//IL_0446: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I4
		//IL_0446: Expected I4, but got Obj
		//IL_08eb: Expected Obj, but got I4
		//IL_08eb: Expected I4, but got Obj
		//IL_08eb: Expected I4, but got Obj
		//IL_08eb: Expected I4, but got Obj
		//IL_019d: Expected I4, but got Obj
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_0460: Expected I4, but got Obj
		//IL_0475: Expected I4, but got Obj
		//IL_0910: Expected Obj, but got I4
		//IL_0910: Expected I4, but got Obj
		//IL_0910: Expected I4, but got Obj
		//IL_0910: Expected I4, but got Obj
		//IL_048f: Expected I4, but got Obj
		//IL_04a4: Expected I4, but got Obj
		//IL_0935: Expected Obj, but got I4
		//IL_0935: Expected I4, but got Obj
		//IL_0935: Expected I4, but got Obj
		//IL_0935: Expected I4, but got Obj
		//IL_0a76: Expected Obj, but got I4
		//IL_0a76: Expected I4, but got Obj
		//IL_01ec: Expected I, but got Obj
		//IL_04be: Expected I4, but got Obj
		//IL_095a: Expected Obj, but got I4
		//IL_095a: Expected I4, but got Obj
		//IL_095a: Expected I4, but got Obj
		//IL_095a: Expected I4, but got Obj
		//IL_0a90: Expected I4, but got Obj
		//IL_0271: Expected Obj, but got I4
		//IL_0271: Expected I4, but got Obj
		//IL_0286: Expected I4, but got Obj
		//IL_0240: Expected I4, but got Obj
		//IL_04f8: Expected I4, but got Obj
		//IL_0994: Expected I4, but got Obj
		//IL_0abc: Expected Obj, but got I4
		//IL_0abc: Expected I4, but got Obj
		//IL_0512: Expected Obj, but got I4
		//IL_0512: Expected Obj, but got I4
		//IL_0512: Expected I4, but got Obj
		//IL_09aa: Expected Obj, but got I4
		//IL_09aa: Expected I4, but got Obj
		//IL_0c6d: Expected I, but got Obj
		//IL_0c83: Expected Obj, but got I
		//IL_09e4: Expected I4, but got Obj
		//IL_0317: Expected Obj, but got I4
		//IL_0317: Expected Obj, but got I4
		//IL_0317: Expected I4, but got Obj
		//IL_057d: Expected I4, but got Obj
		//IL_09fa: Expected Obj, but got I4
		//IL_09fa: Expected I4, but got Obj
		//IL_0cae: Expected I, but got Obj
		//IL_0331: Expected I4, but got Obj
		//IL_0346: Expected Obj, but got I4
		//IL_0346: Expected Obj, but got I4
		//IL_0346: Expected I4, but got Obj
		//IL_02e2: Expected I4, but got Obj
		//IL_0597: Expected I4, but got Obj
		//IL_0afc: Expected Obj, but got I4
		//IL_035c: Expected Obj, but got I4
		//IL_035c: Expected I4, but got Obj
		//IL_0371: Expected I4, but got Obj
		//IL_0a45: Expected Obj, but got I4
		//IL_0a45: Expected I4, but got Obj
		//IL_05f5: Expected Obj, but got I4
		//IL_05f5: Expected I4, but got Obj
		//IL_05f5: Expected I4, but got Obj
		//IL_05f5: Expected I4, but got Obj
		//IL_0b60: Expected I4, but got Obj
		//IL_0b75: Expected Obj, but got I4
		//IL_0b75: Expected Obj, but got I4
		//IL_0b75: Expected I4, but got Obj
		//IL_0d1d: Expected I4, but got Obj
		//IL_03a2: Expected Obj, but got I4
		//IL_03a2: Expected I4, but got Obj
		//IL_03b7: Expected I4, but got Obj
		//IL_0625: Expected I4, but got Obj
		//IL_063b: Expected Obj, but got I4
		//IL_063b: Expected I4, but got Obj
		//IL_064c: Expected Obj, but got I4
		//IL_064c: Expected I4, but got Obj
		//IL_06f4: Expected Obj, but got I4
		//IL_06f4: Expected I4, but got Obj
		//IL_070e: Expected I4, but got Obj
		//IL_073e: Expected I4, but got Obj
		//IL_0758: Expected I4, but got Obj
		//IL_0779: Expected I4, but got Obj
		//IL_0779: Expected I4, but got Obj
		//IL_0779: Expected I4, but got Obj
		//IL_079a: Expected I4, but got Obj
		//IL_079a: Expected I4, but got Obj
		//IL_079a: Expected I4, but got Obj
		//IL_07de: Expected I, but got Obj
		//IL_07f4: Expected Obj, but got I
		//IL_0da8: Expected I4, but got Obj
		//IL_0da8: Expected I4, but got Obj
		//IL_0da8: Expected I4, but got Obj
		//IL_087a: Expected I4, but got Obj
		//IL_087a: Expected I4, but got Obj
		//IL_087a: Expected I4, but got Obj
		//IL_081f: Expected I, but got Obj
		//IL_08a0: Expected I4, but got Obj
		//IL_08a0: Expected I4, but got Obj
		//IL_08a0: Expected I4, but got Obj
		//IL_08c1: Expected I4, but got Obj
		//IL_08c1: Expected I4, but got Obj
		//IL_08c1: Expected I4, but got Obj
		SetContent();
		SkipVideoAds();
		string dataPath;
		string dataPath4;
		switch (adType)
		{
		case AdType.Interstitial:
		{
			if (OnboardingSave.numberOfRunsSinceLastGuideline == 0)
			{
				((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Skip Tutorial", (IngameScreen.SpeedometerState)"Fast forward through the tutorial level", (IngameScreen.PowerUpType)"SkipTutorialLevel", (UIPanel)3);
				InsertGroupExpandable("Show FrontScreen buttons", (DebugSetting)"ToggleShowFrontScreen", multiSelect: true);
				AddSpace();
			}
			((EventTesterManager)(object)this).UpdateSettingValue("Unlock Items", "Enable or purchase ingame items for free");
			InsertGroupExpandable("Display All Characters", (DebugSetting)"ToggleDisplayAllChars", multiSelect: true);
			InsertGroupExpandable("Display All Boards", (DebugSetting)"ToggleDisplayAllBoards", multiSelect: true);
			InsertGroupExpandable("Unlock All Characters", (DebugSetting)"ToggleAllChars");
			InsertGroupExpandable("Unlock All Boards", (DebugSetting)"ToggleAllBoards", multiSelect: true);
			InsertGroupExpandable("Free Purchases", (DebugSetting)"ToggleFreePurchases", multiSelect: true);
			InsertGroupExpandable("Full Upgrades", (DebugSetting)"GiveFullUpgrades", multiSelect: true);
			InsertGroupExpandable("Enable Sales", (DebugSetting)"ToggleSales", multiSelect: true);
			InsertGroupExpandable("Enable New Year Sale", (DebugSetting)"ToggleNewYearSales", multiSelect: true);
			nint num3 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v38 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S0_v69 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!WordHuntManager.IsActiveDailyLetterEvent())
			{
				InsertGroupExpandable("Skip Daily Letters", (DebugSetting)"ToggleSkipDailyLetters", multiSelect: true);
			}
			AddSpace();
			((EventTesterManager)(object)this).UpdateSettingValue("Reward Hunt Tokens", "Reward an amount of Hunt tokens");
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Amount", (UISprite)45, (UILabel)null);
			InsertGroupToggle("", "Reward", (DebugSetting)"RewardHuntTokens");
			AddSpace();
			if (((EventTesterManager)null).GetEventType() != SSEventType.None)
			{
				((EventTesterManager)(object)this).UpdateSettingValue("WordyWeekend Progress", "Reward the next Wordy Weekend letter");
				InsertGroupToggle("", "Reward Letter", (DebugSetting)"RewardWordyWeekendLetter");
				AddSpace();
			}
			((EventTesterManager)(object)this).UpdateSettingValue("Awards Test", "Progress/Complete selected awards");
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Near-finish Award", (UISprite)39, (UILabel)1);
			InsertGroupToggle("Click to progress", "Enable", (DebugSetting)"AlmostCompleteAwardTier");
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Complete Award", (UISprite)37, (UILabel)1);
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"No. of tiers", (UISprite)38, (UILabel)null);
			InsertGroupToggle("Click to reward", "Reward", (DebugSetting)"CompleteAwardsTiers");
			AddSpace();
			((EventTesterManager)(object)this).UpdateSettingValue("Skip Mission Sets", "Skip a fixed amount of mission sets");
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Amount", (UISprite)51, (UILabel)null);
			InsertGroupToggle("", "Skip", (DebugSetting)"SkipMissions");
			AddSpace();
			break;
		}
		case AdType.Video:
		{
			InsertToggle("Online Settings Set", "Enables a specific set of OnlineSettings", "ToggleUseOnlineSettingsSet", DebugSetting.UseOSSet);
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Set", (UISprite)8, (UILabel)null);
			InsertGroupExpandable("Use test time", (DebugSetting)"ToggleOnlineSettingsTestTime", multiSelect: true);
			AddSpace();
			InsertToggle("Interstitials", "Allows debugging of specific providers", "ToggleDebugInterstitialProviders", DebugSetting.Interstitials);
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Provider", (UISprite)12, (UILabel)1);
			InsertGroupExpandable("Ignore time limit", (DebugSetting)"ToggleDebugInterstitialTimelimit", multiSelect: true);
			InsertGroupExpandable("Ignore impression limit", (DebugSetting)"ToggleDebugInterstitialImpressionlimit", multiSelect: true);
			InsertGroupExpandable("Ignore grace period", (DebugSetting)"ToggleDebugInterstitialIgnoreGracePeriod", multiSelect: true);
			InsertGroupExpandable("Ignore in-app purchases", (DebugSetting)"ToggleDebugInterstitialInApp", multiSelect: true);
			InsertGroupToggle("Change provider", "Force Next", (DebugSetting)"ForciblyChangeInterstitialProvider");
			AddSpace();
			InsertToggle("Video Ads", "Allows debugging of specific providers", "ToggleDebugVideoAdProviders", DebugSetting.VideoAds);
			InsertGroupToggle("Change provider", "Force Next", (DebugSetting)"ForciblyChangeVideoProvider");
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Provider", (UISprite)14, (UILabel)1);
			string dataPath5 = Application.dataPath;
			if ((nint)dataPath5 != 7)
			{
				string dataPath6 = Application.dataPath;
				if (dataPath6 != null)
				{
					goto IL_0582;
				}
			}
			InsertGroupExpandable("Fail Video Caching", (DebugSetting)"ToggleDebugFailNextCacheCall", multiSelect: true);
			goto IL_0582;
		}
		case (AdType)2:
			((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Open Event Tester", (IngameScreen.SpeedometerState)"Use this for testing different events", (IngameScreen.PowerUpType)"OpenEventTesterPopup", (UIPanel)2);
			AddSpace();
			((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Open Celebration Tester", (IngameScreen.SpeedometerState)"Use this for testing celebration screens", (IngameScreen.PowerUpType)"OpenCelebrationTesterPopup", (UIPanel)1);
			AddSpace();
			((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Open Welcome Popup", (IngameScreen.SpeedometerState)"Use this for checking the Welcome Popup", (IngameScreen.PowerUpType)"OpenWelcomePopup", (UIPanel)6);
			AddSpace();
			((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Open Weekly Hunt Tester", (IngameScreen.SpeedometerState)"Use this for testing weekly hunt", (IngameScreen.PowerUpType)"OpenWeeklyHuntTesterPopup", (UIPanel)7);
			AddSpace();
			InsertToggle("Override Character Popup", "Overrides character shown in the popup", "ToggleDebugLimitedCharacterPopup", DebugSetting.LimitedCharacterPopup);
			InsertGroupExpandable("Ignore expire time", (DebugSetting)"ToggleLimitedCharacterPopupIgnoreExpire", multiSelect: true);
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Character", (UISprite)31, (UILabel)null);
			AddSpace();
			InsertToggle("Override Board Popup", "Overrides board shown in the popup", "ToggleDebugLimitedBoardPopup", DebugSetting.LimitedBoardPopup);
			InsertGroupExpandable("Ignore expire time", (DebugSetting)"ToggleLimitedBoardPopupIgnoreExpire", multiSelect: true);
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Board", (UISprite)34, (UILabel)null);
			AddSpace();
			InsertButton("Enable Board Bundle", "Use this to enable board bundle", "ToggleEnableBoardBundle", (ButtonIcon)60);
			((EventTesterManager)(object)this).UpdateSettingValue("Guideline Tutorial Test", "Trigger a guideline tutorial to show");
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Type", (UISprite)61, (UILabel)null);
			AddSpace();
			break;
		case (AdType)3:
		{
			((EventTesterManager)(object)this).UpdateSettingValue("Benchmarking", "Choose and start benchmark");
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Benchmark Type", (UISprite)50, (UILabel)null);
			InsertGroupToggle("", "Start", (DebugSetting)"StartBenchmark");
			AddSpace();
			((EventTesterManager)(object)this).UpdateSettingValue("Performance Level", "Override once for next startup");
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Switch Level", (UISprite)46, (UILabel)null);
			AddSpace();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80D1");
			object obj = default;
			if (obj != null)
			{
				object obj2 = 45000;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args = default;
				string description = $"Sets z distance target position to {args}";
				InsertButton("Debug Level Reset Z Target", description, "ToggleDebugZDistanceTargetPosition", (ButtonIcon)59);
				((EventTesterManager)(object)this).UpdateSettingValue("Queued Environments", "Queue specific environments for debugging");
				InsertGroupExpandable("Use Queued Environment Spawning", (DebugSetting)"ToggleQueuedEnvironmentSpawning", multiSelect: true);
				((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Environments", (UISprite)58, (UILabel)1);
				AddSpace();
			}
			InsertButton("Print Route Chunk Names", "See names of chunks in debug label", "TogglePrintRouteNames", (ButtonIcon)52);
			InsertButton("Debug Shaders", "Toggles global shader debug flag", "ToggleDebugShaders", (ButtonIcon)25);
			InsertButton("Character No Hit Collision", "Enables characters to pass through trains", "ToggleCharacterNoHitCollisions", (ButtonIcon)26);
			InsertButton("Screen Timeout Disabled", "Enables / disables screen timeout", "ToggleScreenTimeout", (ButtonIcon)27);
			InsertButton("Display FPS", "Enables the FPS counter", "DisplayFpsCounter", (ButtonIcon)16);
			InsertButton("Test FPS spikes", "Periodicaly locks up the game", "TestFpsSpikes", (ButtonIcon)15);
			InsertButton("Show Performance Info", "Shows performance info in the dev screen", "ToggleShowEndPerformanceInDevScreen", (ButtonIcon)36);
			break;
		}
		default:
			{
				SDebug.LogFormat("Attempting to use non-setup tab.", null);
				break;
			}
			IL_0582:
			InsertGroupExpandable("Skip Video Ads", (DebugSetting)"SkipVideoAds", multiSelect: true);
			AddSpace();
			InsertButton("Ad System Impression", "Only show 1 impression per provider", "ToggleAdSystemSingleImpressionLimit", (ButtonIcon)62);
			InsertButton("Ad debug provider", "Enable debug ad provider", "ToggleAdDebugProviderState", (ButtonIcon)64);
			((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Open Ad System Tester", (IngameScreen.SpeedometerState)"Manually cache and show ad locations", (IngameScreen.PowerUpType)"OpenAdSystemTesterPopup", (UIPanel)8);
			AddSpace();
			((EventTesterManager)(object)this).UpdateSettingValue("TimeScale", "Play in slow/fast motion");
			InsertGroupExpandable("TimeScale Pausebutton", (DebugSetting)"DisplayTimescalePauseButton", multiSelect: true);
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"InMenu", (UISprite)41, (UILabel)null);
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"InGame", (UISprite)40, (UILabel)null);
			AddSpace();
			dataPath = Application.dataPath;
			if ((nint)dataPath != 11)
			{
				string dataPath2 = Application.dataPath;
				if ((nint)dataPath2 != 8)
				{
					string dataPath3 = Application.dataPath;
					if ((nint)dataPath3 != 7)
					{
						goto IL_0719;
					}
				}
			}
			((EventTesterManager)(object)this).UpdateSettingValue("Test Notifications", "Schedule local test notification in 5 sec");
			((IngameScreen)this).ActivateGear((IngameScreen.PowerUpType)"Type", (UISprite)53, (UILabel)null);
			InsertGroupToggle("", "Test", (DebugSetting)"ScheduleTestNotification");
			AddSpace();
			goto IL_0719;
			IL_0719:
			((EventTesterManager)(object)this).UpdateSettingValue("First purchase bonus", "Enable different states of FPB");
			InsertGroupToggle("", "Reset", (DebugSetting)"ResetFpb");
			InsertGroupToggle("", "Collect", (DebugSetting)"ActivateCollectState");
			AddSpace();
			((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Open A/B Test Tester", (IngameScreen.SpeedometerState)"Override active variation", (IngameScreen.PowerUpType)"OpenABTestTesterPopup", (UIPanel)null);
			AddSpace();
			((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Open Character Ownage", (IngameScreen.SpeedometerState)"Change owned characters", (IngameScreen.PowerUpType)"OpenCharacterOwnagePopup", (UIPanel)null);
			AddSpace();
			dataPath4 = Application.dataPath;
			if ((nint)dataPath4 == 11)
			{
				nint num = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ S0_v127 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ S0_v140 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int androidApiLevel = DeviceUtility.GetAndroidApiLevel();
				string text = string.ConcatArray((string[])(object)"Export player data to external path - ", androidApiLevel);
				((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Export Player Data", (IngameScreen.SpeedometerState)text, (IngameScreen.PowerUpType)"ExportPlayerInfo", (UIPanel)null);
				AddSpace();
				((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Import Player Data", (IngameScreen.SpeedometerState)"Import player info from external path", (IngameScreen.PowerUpType)"ImportPlayerInfo", (UIPanel)null);
				AddSpace();
			}
			((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Copy to Clipboard", (IngameScreen.SpeedometerState)"Copy all player data to clipboard", (IngameScreen.PowerUpType)"CopyPlayerDataToClipboard", (UIPanel)null);
			AddSpace();
			((IngameScreen)this).ChangeSpeedometerState((IngameScreen.SpeedometerState)"Request Analytics Check", (IngameScreen.SpeedometerState)"Request Sybot to perform analytics check for this user", (IngameScreen.PowerUpType)"RequestAnalyticsCheck", (UIPanel)null);
			AddSpace();
			break;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_scrollView).FindKernel((string)null) != 0 && _adapter != null)
		{
			_scrollView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		}
		lastTabOpen = (TabNumber)adType;
		SetContentList((TabNumber)adType);
		_listHasBeenDisplayedOnce = true;
	}

	private void SkipVideoAds()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
	}

	private void ToggleShowEndPerformanceInDevScreen()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_SKIP_VIDEO_ADS = Globals.DEBUG_SKIP_VIDEO_ADS;
		bool dEBUG_SKIP_VIDEO_ADS2 = (byte)((dEBUG_SKIP_VIDEO_ADS ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_SKIP_VIDEO_ADS = dEBUG_SKIP_VIDEO_ADS2;
	}

	private void ToggleEnableBoardBundle()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_SHOW_PERFORMANCE_INFO = Globals.DEBUG_SHOW_PERFORMANCE_INFO;
		bool dEBUG_SHOW_PERFORMANCE_INFO2 = (byte)((dEBUG_SHOW_PERFORMANCE_INFO ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_SHOW_PERFORMANCE_INFO = dEBUG_SHOW_PERFORMANCE_INFO2;
	}

	private void TogglePrintRouteNames()
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_0212: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v32 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_ENABLE_BOARD_BUNDLE = Globals.DEBUG_ENABLE_BOARD_BUNDLE;
		bool dEBUG_ENABLE_BOARD_BUNDLE2 = (byte)((dEBUG_ENABLE_BOARD_BUNDLE ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_ENABLE_BOARD_BUNDLE = dEBUG_ENABLE_BOARD_BUNDLE2;
		nint num5 = (nint)typeof(BoardBundlePopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardBundlePopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v28 (Il2CppClass<UI.Screens.BoardBundlePopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int pageIndex = ChallengesScreen.GetPageIndex();
		((BoardBundlePopupManager)pageIndex).StartTimer();
	}

	private void ToggleCharacterNoHitCollisions()
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v39 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool printRouteChunksInDebugLabel = PrintRouteChunksInDebugLabel;
		bool printRouteChunksInDebugLabel2 = (byte)((printRouteChunksInDebugLabel ? 1u : 0u) ^ 1u) != 0;
		PrintRouteChunksInDebugLabel = printRouteChunksInDebugLabel2;
		if (DebugSettingsPopup.m_OnRoutePrintSettingChanged == null)
		{
			return;
		}
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v26 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v33 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool printRouteChunksInDebugLabel3 = PrintRouteChunksInDebugLabel;
		DebugSettingsPopup.m_OnRoutePrintSettingChanged(printRouteChunksInDebugLabel3);
	}

	private void ToggleScreenTimeout()
	{
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0225: Expected VT, but got I
		//IL_0225: Expected VT, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I4
		//IL_0126: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected I4, but got Unknown
		//IL_0175: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v42 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Layers>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v38 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool startupFinished = LoadLevelCtrl.StartupFinished;
		bool startupFinished2 = LoadLevelCtrl.StartupFinished;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v19 (System.Boolean)+14]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v6 (System.Boolean)+C]");
		bool flag = Physics.Raycast((Vector3)num5, (Vector3)0);
		bool startupFinished3 = LoadLevelCtrl.StartupFinished;
		bool startupFinished4 = LoadLevelCtrl.StartupFinished;
		string text = (string)((flag ? 1 : 0) ^ 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v23 (System.Boolean)+14]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v9 (System.Boolean)+C]");
		((UnityWebRequest)num6)._002Ector((string)0, text);
		nint num7 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v26 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num8 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v32 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS = (byte)(text & 1) != 0;
		Globals.DEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS = dEBUG_CHARACTER_MOVE_THROUGH_COLLIDERS;
	}

	private void ToggleDebugShaders()
	{
		//IL_01b3: Expected I, but got Obj
		//IL_01c9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0112: Expected VT, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_00fd: Expected VT, but got I4
		//IL_0166: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(ScreenTimoutDisabled ? 1u : 0u) == 0)
		{
			int pixelLightCount = QualitySettings.pixelLightCount;
			_originalScreenTimout = pixelLightCount;
			GL.Color((Color)(-1));
		}
		else
		{
			GL.Color((Color)_originalScreenTimout);
		}
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v23 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v30 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool screenTimoutDisabled = ScreenTimoutDisabled;
		bool screenTimoutDisabled2 = (byte)((screenTimoutDisabled ? 1u : 0u) ^ 1u) != 0;
		ScreenTimoutDisabled = screenTimoutDisabled2;
	}

	private void ToggleAllChars()
	{
		//IL_0159: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01d8: Expected VT, but got I4
		//IL_01e6: Expected I, but got Obj
		//IL_01fc: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v40 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_SHADERS = Globals.DEBUG_SHADERS;
		bool dEBUG_SHADERS2 = (byte)((dEBUG_SHADERS ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_SHADERS = dEBUG_SHADERS2;
		bool dEBUG_SHADERS3 = Globals.DEBUG_SHADERS;
		Shader.SetGlobalVector("_DebugShaders", (Vector4)dEBUG_SHADERS3);
		nint num5 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v24 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Globals.DEBUG_SHADERS)
		{
			Shader.DisableKeyword("_DebugShaders");
		}
		else
		{
			Material.CreateWithString((Material)(object)"_DebugShaders");
		}
	}

	private void ToggleDisplayAllChars()
	{
		//IL_0332: Expected I, but got Obj
		//IL_0348: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_03f7: Expected I, but got Obj
		//IL_040d: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_03da: Expected Obj, but got I4
		//IL_020a: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_0434: Expected Obj, but got I4
		//IL_0446: Expected I, but got Obj
		//IL_045c: Expected Obj, but got I
		//IL_0298: Expected I, but got Obj
		//IL_02e5: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v94 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v88 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_ALL_CHARS = Globals.DEBUG_ALL_CHARS;
		bool dEBUG_ALL_CHARS2 = (byte)((dEBUG_ALL_CHARS ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_ALL_CHARS = dEBUG_ALL_CHARS2;
		if (~(Globals.DEBUG_ALL_CHARS ? 1u : 0u) != 0)
		{
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v77 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v84 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterManager.UnlockOutfit(Characters.CharacterId.slick, 0);
			bool isInstanced = UIScreenController.IsInstanced;
			((UIPowerupHandler)isInstanced).SetPowerupSlotContent((ActivePowerup)null, 0);
		}
		nint num7 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v28 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v70 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreen.forceRefreshOnCharacterScreen = true;
		nint num9 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v35 (Il2CppClass<Globals>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v64 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_ALL_CHARS ? 1u : 0u) != 0)
		{
			return;
		}
		nint num11 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v43 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v60 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerator enumerator = CloudSave.LoginAsync((Action)1);
		nint num13 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v50 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num14 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v56 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string assetBundlesCachePath = AssetBundleManager.GetAssetBundlesCachePath();
		((AssetBundleManager)(object)assetBundlesCachePath).InitializeDownloadRequests();
	}

	private void ToggleDisplayAllBoards()
	{
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0282: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_02bf: Expected Obj, but got I4
		//IL_02d1: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v66 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v60 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_DISPLAY_ALL_CHARS = Globals.DEBUG_DISPLAY_ALL_CHARS;
		bool dEBUG_DISPLAY_ALL_CHARS2 = (byte)((dEBUG_DISPLAY_ALL_CHARS ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_DISPLAY_ALL_CHARS = dEBUG_DISPLAY_ALL_CHARS2;
		nint num5 = (nint)typeof(CharacterScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v22 (Il2CppClass<UI.Screens.CharacterScreen>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(CharacterScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v54 (Il2CppClass<UI.Screens.CharacterScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterScreen.forceRefreshOnCharacterScreen = true;
		if (~(Globals.DEBUG_DISPLAY_ALL_CHARS ? 1u : 0u) != 0)
		{
			return;
		}
		nint num7 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v33 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v50 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerator enumerator = CloudSave.LoginAsync((Action)1);
		nint num9 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v40 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v46 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string assetBundlesCachePath = AssetBundleManager.GetAssetBundlesCachePath();
		((AssetBundleManager)(object)assetBundlesCachePath).InitializeDownloadRequests();
	}

	private void ToggleAllBoards()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v32 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_DISPLAY_ALL_BOARDS = Globals.DEBUG_DISPLAY_ALL_BOARDS;
		bool dEBUG_DISPLAY_ALL_BOARDS2 = (byte)((dEBUG_DISPLAY_ALL_BOARDS ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_DISPLAY_ALL_BOARDS = dEBUG_DISPLAY_ALL_BOARDS2;
		nint num5 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v28 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
		((UnityEngine.Object)instance2).m_CachedPtr = (IntPtr)1;
	}

	private void ToggleFreePurchases()
	{
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I4
		//IL_014b: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v40 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_ALL_BOARDS = Globals.DEBUG_ALL_BOARDS;
		bool dEBUG_ALL_BOARDS2 = (byte)((dEBUG_ALL_BOARDS ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_ALL_BOARDS = dEBUG_ALL_BOARDS2;
		if (~(Globals.DEBUG_ALL_BOARDS ? 1u : 0u) != 0)
		{
			bool isInstanced = UIScreenController.IsInstanced;
			((UIModelController)isInstanced).ActivateModelScreen(UIModelController.ModelScreen.CelebrationBoardUnlock);
		}
		nint num5 = (nint)typeof(BoardScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v28 (Il2CppClass<BoardScreenManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v34 (Il2CppClass<BoardScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardModelPreviewFactory instance2 = HoverboardModelPreviewFactory.Instance;
		((UnityEngine.Object)instance2).m_CachedPtr = (IntPtr)1;
	}

	private void ToggleSkipDailyLetters()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_FREE_INAPP_PURCHASE = Globals.DEBUG_FREE_INAPP_PURCHASE;
		bool dEBUG_FREE_INAPP_PURCHASE2 = (byte)((dEBUG_FREE_INAPP_PURCHASE ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_FREE_INAPP_PURCHASE = dEBUG_FREE_INAPP_PURCHASE2;
	}

	private void ToggleShowFrontScreen()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_SKIP_DAILY_LETTERS = Globals.DEBUG_SKIP_DAILY_LETTERS;
		bool dEBUG_SKIP_DAILY_LETTERS2 = (byte)((dEBUG_SKIP_DAILY_LETTERS ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_SKIP_DAILY_LETTERS = dEBUG_SKIP_DAILY_LETTERS2;
	}

	private void OpenEventTesterPopup()
	{
		//IL_02aa: Expected I, but got Obj
		//IL_02c0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02ef: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_035f: Expected I, but got Obj
		//IL_0375: Expected Obj, but got I
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got I4
		//IL_01e1: Expected I, but got Obj
		//IL_0321: Expected Obj, but got I4
		//IL_022e: Expected I, but got Obj
		//IL_0153: Expected I, but got Obj
		//IL_0297: Expected Obj, but got I4
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v67 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v63 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		if (!((string)(object)enumerator != "FrontScreen"))
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v53 (Il2CppClass<UIScreenController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v59 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).QueueSlideIn((SlideIn)(object)"Only in works\nin FrontScreen");
			return;
		}
		nint num7 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v24 (Il2CppClass<Globals>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v46 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER = Globals.DEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER;
		bool dEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER2 = (byte)((dEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER = dEBUG_SHOW_FRONT_SCREEN_IF_NEW_USER2;
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v42 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		UIScreen uIScreen = ((UIScreenController)flag3)._ActivateScreen("FrontScreen");
		string text = uIScreen.tag;
		((GameObject)(object)text).tag = null;
		string text2 = uIScreen.tag;
		((GameObject)(object)text2).tag = (string)1;
	}

	private void OpenCelebrationTesterPopup()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("EventTesterPopup");
	}

	private void OpenWeeklyHuntTesterPopup()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("CelebrationTesterPopup");
	}

	private void ToggleSales()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("WeeklyHuntTesterPopup");
	}

	private void ToggleHolidaySales()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_ENABLE_SALES = Globals.DEBUG_ENABLE_SALES;
		bool dEBUG_ENABLE_SALES2 = (byte)((dEBUG_ENABLE_SALES ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_ENABLE_SALES = dEBUG_ENABLE_SALES2;
	}

	private void ToggleNewYearSales()
	{
		//IL_0118: Expected I, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I4
		//IL_01bc: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_0105: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		nint num4 = (nint)typeof(Globals);
		if (!flag)
		{
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v25 (Il2CppClass<Globals>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(Globals);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(Globals);
			}
		}
		nint num6 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v19 (Il2CppClass<Globals>)+5C]");
		object obj3 = -(-64);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ L0_v4 (Il2CppClass<Globals>)+5C]");
		object obj4 = -(-64);
		bool flag4 = obj4 != null;
		object obj5 = (flag4 ? 1 : 0) ^ 1;
		obj3 = obj5;
		nint num7 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v13 (Il2CppClass<Globals>)+5C]");
		object obj6 = -(-64);
		bool dEBUG_ENABLE_SALES = obj6 != null;
		Globals.DEBUG_ENABLE_SALES = dEBUG_ENABLE_SALES;
	}

	private void RewardHuntTokens()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v24 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_ENABLE_NEW_YEAR_SALES = Globals.DEBUG_ENABLE_NEW_YEAR_SALES;
		bool dEBUG_ENABLE_NEW_YEAR_SALES2 = (byte)((dEBUG_ENABLE_NEW_YEAR_SALES ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_ENABLE_NEW_YEAR_SALES = dEBUG_ENABLE_NEW_YEAR_SALES2;
		bool dEBUG_ENABLE_NEW_YEAR_SALES3 = Globals.DEBUG_ENABLE_NEW_YEAR_SALES;
		Globals.DEBUG_ENABLE_SALES = dEBUG_ENABLE_NEW_YEAR_SALES3;
	}

	private void RewardWordyWeekendLetter()
	{
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_01ca: Expected I, but got Obj
		//IL_01e0: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_00fc: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		object obj2 = 0;
		while (true)
		{
			nint num3 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v34 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)obj2 >= amountOfHuntTokensToReward)
			{
				break;
			}
			nint num5 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v23 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v30 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WeeklyHuntManager.InitIfNeeded();
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
	}

	private bool IsWordyWeekendActive()
	{
		((CollectCoinsScreenManager)(object)this)._002Ector();
		return showOldFooterSection;
	}

	private unsafe void OpenWelcomePopup()
	{
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected VT, but got Unknown
		//IL_01b0: Expected VT, but got I4
		//IL_01be: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		//IL_0148: Expected I4, but got Obj
		//IL_0155: Expected VT, but got Obj
		//IL_0183: Expected Ref, but got VT
		CharacterNameEventManager characterNameEventManager = default;
		char? c = (char?)(object)(characterNameEventManager + 4);
		c = (char?)(object)0;
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v43 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null || ((EventTesterManager)null).GetEventType() == SSEventType.None)
		{
			return;
		}
		nint num3 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v22 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v39 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		CharacterNameEventManager typeOfActiveEventManager = ((SSEventsManagerController)(object)flurryUserId).GetTypeOfActiveEventManager<CharacterNameEventManager>();
		if (typeOfActiveEventManager != null && typeOfActiveEventManager.GetAmountOfCollectedLetters() != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			characterNameEventManager.NotifyLetterCollected((char)(int)typeOfActiveEventManager);
			c = (char?)(object)characterNameEventManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Nullable`1<System.Char>)+2]");
			if ((nint)0 != 0)
			{
				char value = ((char?*)c)->Value;
				((SSEventsManagerController)(object)typeOfActiveEventManager).OnHasRefreshed((RefreshType)value);
			}
		}
	}

	private void OpenABTestTesterPopup()
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v30 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DebugSettingsPopup._002Ecctor();
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v26 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("WelcomePopup");
	}

	private void OpenCharacterOwnagePopup()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("ABTestTesterPopup");
	}

	private void ToggleDebugInterstitialProviders()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("CharacterOwnageDebugPopup");
	}

	private void ToggleDebugVideoAdProviders()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_INTERSTITIAL_PROVIDERS = Globals.DEBUG_INTERSTITIAL_PROVIDERS;
		bool dEBUG_INTERSTITIAL_PROVIDERS2 = (byte)((dEBUG_INTERSTITIAL_PROVIDERS ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_INTERSTITIAL_PROVIDERS = dEBUG_INTERSTITIAL_PROVIDERS2;
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RefreshInterstitials = true;
	}

	private void ToggleDebugInterstitialIgnoreGracePeriod()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_VIDEOADS_PROVIDERS = Globals.DEBUG_VIDEOADS_PROVIDERS;
		bool dEBUG_VIDEOADS_PROVIDERS2 = (byte)((dEBUG_VIDEOADS_PROVIDERS ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_VIDEOADS_PROVIDERS = dEBUG_VIDEOADS_PROVIDERS2;
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RefreshVideoAds = true;
	}

	private void ToggleDebugInterstitialImpressionlimit()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD;
		bool dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD2 = (byte)((dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD = dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_GRACE_PERIOD2;
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RefreshInterstitials = true;
	}

	private void ToggleDebugInterstitialTimelimit()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT;
		bool dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT2 = (byte)((dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT = dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IMPRESSION_LIMIT2;
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RefreshInterstitials = true;
	}

	private void ToggleDebugInterstitialEditor()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT;
		bool dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT2 = (byte)((dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT = dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT2;
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RefreshInterstitials = true;
	}

	private void ToggleDebugInterstitialInApp()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_INTERSTITIAL_IN_EDITOR = Globals.DEBUG_INTERSTITIAL_IN_EDITOR;
		bool dEBUG_INTERSTITIAL_IN_EDITOR2 = (byte)((dEBUG_INTERSTITIAL_IN_EDITOR ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_INTERSTITIAL_IN_EDITOR = dEBUG_INTERSTITIAL_IN_EDITOR2;
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RefreshInterstitials = true;
	}

	private void ToggleUseOnlineSettingsSet()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES;
		bool dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES2 = (byte)((dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES = dEBUG_INTERSTITIAL_PROVIDERS_IGNORE_IN_APP_PURCHASES2;
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RefreshInterstitials = true;
	}

	private void ToggleOnlineSettingsTestTime()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_ONLINESETTINGS_SET = Globals.DEBUG_USE_ONLINESETTINGS_SET;
		bool dEBUG_USE_ONLINESETTINGS_SET2 = (byte)((dEBUG_USE_ONLINESETTINGS_SET ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_USE_ONLINESETTINGS_SET = dEBUG_USE_ONLINESETTINGS_SET2;
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v22 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DownloadNewOS = true;
	}

	private void DisplayFpsCounter()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_ONLINESETTINGS_TESTTIME = Globals.DEBUG_USE_ONLINESETTINGS_TESTTIME;
		bool dEBUG_USE_ONLINESETTINGS_TESTTIME2 = (byte)((dEBUG_USE_ONLINESETTINGS_TESTTIME ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_USE_ONLINESETTINGS_TESTTIME = dEBUG_USE_ONLINESETTINGS_TESTTIME2;
	}

	private void TestFpsSpikes()
	{
		//IL_034d: Expected I, but got Obj
		//IL_0363: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I4
		//IL_00f8: Expected I4, but got Obj
		//IL_02b1: Expected Obj, but got VT
		//IL_02bf: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I
		//IL_0204: Expected I, but got Obj
		//IL_021a: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0120: Expected I4, but got Obj
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0300: Expected I, but got Obj
		//IL_0245: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v73 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (fpsObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"FpsManager";
			object obj3 = this + 116;
			obj3 = gameObject;
			UnityEngine.Object.DestroyImmediate(fpsObject, (byte)(int)"FpsManager" != 0);
			HUDFPS hUDFPS = fpsObject.AddComponent<HUDFPS>();
			nint num5 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v61 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v67 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_isShowingFps = true;
			return;
		}
		if (fpsObject.activeInHierarchy)
		{
			fpsObject.tag = null;
			nint num7 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v38 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v44 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_isShowingFps = false;
			return;
		}
		fpsObject.tag = (string)1;
		_0021_00210 componentInChildren = (_0021_00210)fpsObject.GetComponentInChildren<T>();
		((HUDFPS)componentInChildren).Reset();
		nint num9 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v24 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v30 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_isShowingFps = true;
	}

	private void RecordFPS()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_TEST_FPS_SPIKES = Globals.DEBUG_TEST_FPS_SPIKES;
		bool dEBUG_TEST_FPS_SPIKES2 = (byte)((dEBUG_TEST_FPS_SPIKES ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_TEST_FPS_SPIKES = dEBUG_TEST_FPS_SPIKES2;
	}

	private unsafe void StartAutoFPSTest()
	{
		//IL_00da: Expected I, but got Obj
		//IL_00f0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance != null)
		{
			bool flag = IOSViewController._GetIsSimulator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (System.Boolean)+74]");
			bool flag2 = (nint)0 != 0;
			bool flag3 = IOSViewController._GetIsSimulator();
			if (flag2)
			{
				(flag3 ? ((IntMask*)1) : ((IntMask*)null))->set_Item(0, true);
			}
			else
			{
				(flag3 ? ((IntMask*)1) : ((IntMask*)null))->set_Item(1, true);
			}
		}
	}

	private void StartAutoFPSTestPreSet()
	{
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0064: Expected VT, but got I4
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_01e4: Expected I, but got Obj
		//IL_01fa: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_00ff: Expected I, but got Obj
		//IL_014c: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		bool flag = IOSViewController._GetIsSimulator();
		if ((int)(IntMask)flag != 0)
		{
			bool flag2 = IOSViewController._GetIsSimulator();
			((FPSLog)flag2).SetFPSLogging(shouldEnable: false, 1);
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v23 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v14 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string slideIn = Strings.GetDefault("CONNECTION_TEST_FAILED_ERROR_MESSAGE");
		((UIScreenController)flag3).QueueSlideIn((SlideIn)(object)slideIn);
	}

	private void StartBenchmark()
	{
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0064: Expected VT, but got I4
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_01e4: Expected I, but got Obj
		//IL_01fa: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0232: Expected Obj, but got I4
		//IL_00ff: Expected I, but got Obj
		//IL_014c: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		bool flag = IOSViewController._GetIsSimulator();
		if ((int)(IntMask)flag != 0)
		{
			bool flag2 = IOSViewController._GetIsSimulator();
			((FPSLog)flag2).SetFPSLogging(shouldEnable: true, 0);
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v23 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v7 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v14 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string slideIn = Strings.GetDefault("CONNECTION_TEST_FAILED_ERROR_MESSAGE");
		((UIScreenController)flag3).QueueSlideIn((SlideIn)(object)slideIn);
	}

	private void StartBenchmarkConfirmed(string popupResult)
	{
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @93AE");
		OfferWallManager instance = OfferWallManager.instance;
		((AdEventLogger)(object)instance).FailedToInitAdProvider(popupResult);
		OfferWallManager instance2 = OfferWallManager.instance;
		((AdSystemManager)(object)instance2).SkipVideoAd();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @93AE");
	}

	private void ToggleCappedFPS()
	{
		//IL_0440: Expected I, but got Obj
		//IL_0456: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0494: Expected I, but got Obj
		//IL_04aa: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_052e: Expected I4, but got Obj
		//IL_01d1: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_04ff: Expected I4, but got Obj
		//IL_0107: Expected I, but got Obj
		//IL_02f6: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I
		//IL_0212: Expected I, but got Obj
		//IL_025a: Expected VT, but got Obj
		//IL_0268: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03b2: Expected I, but got Obj
		//IL_03c8: Expected Obj, but got I
		//IL_0337: Expected I, but got Obj
		//IL_058c: Expected Obj, but got VT
		//IL_02a9: Expected I, but got Obj
		//IL_03f3: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v98 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v92 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_POPUP_TESTOLOGY = Globals.DEBUG_POPUP_TESTOLOGY;
		nint num5 = (nint)typeof(SubwayBenchmarkContainer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v7 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 != null;
		if (dEBUG_POPUP_TESTOLOGY)
		{
			if (flag)
			{
				nint num6 = (nint)typeof(SubwayBenchmarkContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v88 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CompoundAutomationStep kind = SubwayMemoryBenchmark.GenerateSingleUICompoundStep();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			EnvironmentBackground environmentBackground = default;
			environmentBackground.RouteChunk_OnEnvironmentSegmentSpawned((EnvironmentKind)(object)kind, (int)"1d4AZJWVKm1c438UX21RZIMHGpzjRd013Bmk10_n5tmU", (Route)(object)"https://script.google.com/macros/s/AKfycbzysbyZuNXvOTJh5llqjN4N2dP4PAXusuwfaHjvTD3ESkx5Sas/exec");
			EnvironmentBackground environmentBackground2 = environmentBackground;
		}
		else
		{
			if (flag)
			{
				nint num7 = (nint)typeof(SubwayBenchmarkContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v77 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CompoundAutomationStep kind2 = SubwayMemoryBenchmark.GenerateSingleUICompoundStep();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			EnvironmentBackground environmentBackground3 = default;
			environmentBackground3.RouteChunk_OnEnvironmentSegmentSpawned((EnvironmentKind)(object)kind2, (int)"1HIlWcwxXV0dVjsf0gLpgFE0B0bei1vdn2xJNTAIxFv4", (Route)(object)"https://script.google.com/macros/s/AKfycbzysbyZuNXvOTJh5llqjN4N2dP4PAXusuwfaHjvTD3ESkx5Sas/exec");
			EnvironmentBackground environmentBackground2 = environmentBackground3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @93EC");
		nint num8 = (nint)typeof(SubwayBenchmarkContainer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v25 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num9 = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v66 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string selectedBencharmProcessorPostfix = SubwayBenchmarkContainer.SelectedBencharmProcessorPostfix;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj5 = default;
		if (obj5 == null)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			nint num10 = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v28 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num11 = (nint)typeof(SubwayBenchmarkContainer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v34 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string selectedBencharmProcessorPostfix2 = SubwayBenchmarkContainer.SelectedBencharmProcessorPostfix;
			((AutomationStepExecutor)val)._002Ector((IAutomationStep[])(object)selectedBencharmProcessorPostfix2);
			return;
		}
		nint num12 = (nint)typeof(SubwayBenchmarkContainer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v33 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num13 = (nint)typeof(SubwayBenchmarkContainer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v59 (Il2CppClass<SYBO.Subway.Benchmarking.SubwayBenchmarkContainer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string selectedBencharmProcessorPostfix3 = SubwayBenchmarkContainer.SelectedBencharmProcessorPostfix;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num14 = 0;
		GUILayoutOption[] array = default;
		array[1] = (GUILayoutOption)0;
		object obj8 = array + 16;
		obj8 = this;
		nint num15 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v49 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num16 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v55 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 scrollPosition = default;
		((GUIScrollView)(object)"Confirm Benchmark")._002Ector(scrollPosition, (GUIStyle)"Cancel", (GUIStyle)"OK", array);
	}

	private void ToggleUnCappedFPS()
	{
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I4
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance != null)
		{
			bool flag = IOSViewController._GetIsSimulator();
			bool flag2 = IOSViewController._GetIsSimulator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5 (System.Boolean)+68]");
			bool flag3 = (nint)0 != 0;
			object obj2 = (flag3 ? 1 : 0) ^ 1;
		}
	}

	private void RefreshScrollList()
	{
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I4
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance != null)
		{
			bool flag = IOSViewController._GetIsSimulator();
			bool flag2 = IOSViewController._GetIsSimulator();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5 (System.Boolean)+69]");
			bool flag3 = (nint)0 != 0;
			object obj2 = (flag3 ? 1 : 0) ^ 1;
		}
	}

	private void DisplayTimescalePauseButton()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_003d: Expected VT, but got Obj
		Container lastVisibleContainerOnScreen = _scrollView.GetLastVisibleContainerOnScreen();
		object obj = lastVisibleContainerOnScreen - -64;
		DisplayTab1();
		_scrollView.SmoothScrollToOffset((Vector3)obj, (Action)null, 0f);
	}

	private void ToggleDebugLimitedCharacterPopup()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_TIMESCALE_PAUSE_BUTTON = Globals.DEBUG_USE_TIMESCALE_PAUSE_BUTTON;
		bool dEBUG_USE_TIMESCALE_PAUSE_BUTTON2 = (byte)((dEBUG_USE_TIMESCALE_PAUSE_BUTTON ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_USE_TIMESCALE_PAUSE_BUTTON = dEBUG_USE_TIMESCALE_PAUSE_BUTTON2;
	}

	private void ToggleLimitedCharacterPopupIgnoreExpire()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_LIMITED_CHARACTER_POPUP = Globals.DEBUG_LIMITED_CHARACTER_POPUP;
		bool dEBUG_LIMITED_CHARACTER_POPUP2 = (byte)((dEBUG_LIMITED_CHARACTER_POPUP ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_LIMITED_CHARACTER_POPUP = dEBUG_LIMITED_CHARACTER_POPUP2;
	}

	private void ToggleDebugLimitedBoardPopup()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE = Globals.DEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE;
		bool dEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE2 = (byte)((dEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE = dEBUG_LIMITED_CHARACTER_POPUP_IGNORE_EXPIRE2;
	}

	private void ToggleLimitedBoardPopupIgnoreExpire()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_LIMITED_BOARD_POPUP = Globals.DEBUG_LIMITED_BOARD_POPUP;
		bool dEBUG_LIMITED_BOARD_POPUP2 = (byte)((dEBUG_LIMITED_BOARD_POPUP ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_LIMITED_BOARD_POPUP = dEBUG_LIMITED_BOARD_POPUP2;
	}

	private void CompleteAwardsTiers()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE = Globals.DEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE;
		bool dEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE2 = (byte)((dEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE = dEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE2;
	}

	private void AlmostCompleteAwardTier()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected Obj, but got Unknown
		//IL_0ef7: Expected Obj, but got I4
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected Obj, but got Unknown
		//IL_0f27: Expected I, but got Obj
		//IL_0f3d: Expected Obj, but got I
		//IL_1162: Unknown result type (might be due to invalid IL or missing references)
		//IL_1167: Expected Obj, but got Unknown
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_11a9: Expected I, but got Obj
		//IL_11bf: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_112e: Expected Obj, but got I4
		//IL_018a: Expected I, but got Obj
		//IL_01e1: Expected Obj, but got I4
		//IL_013d: Expected I, but got Obj
		//IL_0f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I4
		//IL_0210: Expected Obj, but got I4
		//IL_108a: Expected I, but got Obj
		//IL_10a0: Expected Obj, but got I
		//IL_0fdd: Expected I, but got Obj
		//IL_0ff3: Expected Obj, but got I
		//IL_0223: Expected I, but got Obj
		//IL_120f: Expected I, but got Obj
		//IL_1225: Expected Obj, but got I
		//IL_0de8: Expected Obj, but got I
		//IL_10d0: Expected Obj, but got I4
		//IL_1154: Expected Obj, but got I4
		//IL_04d4: Expected I, but got Obj
		//IL_04ea: Expected Obj, but got I
		//IL_047e: Expected I, but got Obj
		//IL_1031: Expected Obj, but got I4
		//IL_0266: Expected Obj, but got I4
		//IL_0ea0: Expected I, but got Obj
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Expected Obj, but got Unknown
		//IL_10fe: Expected Obj, but got I4
		//IL_02e8: Expected I, but got Obj
		//IL_02fe: Expected Obj, but got I
		//IL_0292: Expected I, but got Obj
		//IL_056b: Expected I, but got Obj
		//IL_0581: Expected Obj, but got I
		//IL_0515: Expected I, but got Obj
		//IL_04c1: Expected Obj, but got I4
		//IL_105f: Expected Obj, but got I4
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e59: Expected Obj, but got Unknown
		//IL_1116: Expected Obj, but got I4
		//IL_037f: Expected I, but got Obj
		//IL_0395: Expected Obj, but got I
		//IL_0329: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I4
		//IL_05ac: Expected I, but got Obj
		//IL_0558: Expected Obj, but got I4
		//IL_1077: Expected Obj, but got I4
		//IL_03c0: Expected I, but got Obj
		//IL_036c: Expected Obj, but got I4
		//IL_063e: Expected Obj, but got I
		//IL_05ef: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got I4
		//IL_0436: Expected Obj, but got I4
		//IL_03e9: Expected Obj, but got I4
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected Obj, but got Unknown
		//IL_0d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Expected Obj, but got Unknown
		//IL_0d60: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v313 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 40;
		object obj7 = obj2 + 16;
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v307 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (completeAwardsTiersSelectedTiers <= 0)
		{
			nint num5 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v295 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v301 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			completeAwardsTiersSelectedTiers = 1;
		}
		nint num7 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v42 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num8 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v288 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, string>.KeyCollection keys = completeAwardsTiersSelectedItems.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @821F");
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23+8]");
		_ = 0;
		object obj12 = default;
		object obj11;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 75;
			bool flag = obj12 == null;
			obj11 = 78;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 21;
			object obj13 = 0;
			bool flag3;
			while (true)
			{
				nint num9 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v121 (Il2CppClass<DebugSettingsPopup>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num10 = (nint)typeof(DebugSettingsPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v278 (Il2CppClass<DebugSettingsPopup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						obj11 = 50;
					}
				}
				bool flag2 = (nint)obj13 < completeAwardsTiersSelectedTiers;
				nint num11 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S1_v70 (Il2CppClass<Missions.AwardsManager>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				flag3 = obj15 != null;
				if (!flag2)
				{
					break;
				}
				if (flag3)
				{
					nint num12 = (nint)typeof(AwardsManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S0_v270 (Il2CppClass<Missions.AwardsManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						obj11 = 25;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				obj11 = 31;
				nint num13 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S0_v212 (Il2CppClass<System.Type>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num14 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S0_v262 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						obj11 = 32;
					}
				}
				obj7 = typeof(AwardId);
				obj6 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj11 = 37;
				nint num15 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S0_v225 (Il2CppClass<System.Enum>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num16 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S0_v255 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						obj11 = 38;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj11 = 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj11 = 49;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				obj11 = 49;
				object obj18 = obj13 + 1;
				obj13 = obj18;
			}
			if (flag3)
			{
				nint num17 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S0_v193 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj11 = 26;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj11 = 59;
			nint num18 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S0_v139 (Il2CppClass<System.Type>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num19 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S0_v185 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj11 = 60;
				}
			}
			obj2 = typeof(AwardId);
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj11 = 65;
			nint num20 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ S0_v152 (Il2CppClass<System.Enum>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num21 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ S0_v177 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj11 = 66;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj11 = 73;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ S0_v170+1C]");
			object obj21 = 0;
			_ = 2;
		}
		object obj22 = obj11 - 21;
		if ((nint)obj11 != 21)
		{
			if ((nint)obj22 != 1 && (nint)obj22 != 2 && (nint)obj22 != 3)
			{
				if ((nint)obj22 == 4 || (nint)obj22 == 5)
				{
					goto IL_0d65;
				}
				if ((nint)obj22 != 6 && (nint)obj22 != 7 && (nint)obj22 != 8 && (nint)obj22 != 9)
				{
					if ((nint)obj22 == 10 || (nint)obj22 == 11)
					{
						goto IL_0d65;
					}
					if ((nint)obj22 != 12 && (nint)obj22 != 13 && (nint)obj22 != 14 && (nint)obj22 != 15)
					{
						if ((nint)obj22 == 16 || (nint)obj22 == 17)
						{
							goto IL_0d65;
						}
						if ((nint)obj22 != 18 && (nint)obj22 != 19 && (nint)obj22 != 20 && (nint)obj22 != 21 && (nint)obj22 != 22 && (nint)obj22 != 23 && (nint)obj22 != 24 && (nint)obj22 != 25 && (nint)obj22 != 26)
						{
							if ((nint)obj22 == 27 || (nint)obj22 == 28 || (nint)obj22 == 29)
							{
								goto IL_0d65;
							}
							if ((nint)obj22 != 30 && (nint)obj22 != 31 && (nint)obj22 != 32 && (nint)obj22 != 33 && (nint)obj22 != 34 && (nint)obj22 != 35 && (nint)obj22 != 36 && (nint)obj22 != 37)
							{
								if ((nint)obj22 == 38 || (nint)obj22 == 39)
								{
									goto IL_0d65;
								}
								if ((nint)obj22 != 40 && (nint)obj22 != 41 && (nint)obj22 != 42 && (nint)obj22 != 43)
								{
									if ((nint)obj22 == 44 || (nint)obj22 == 45)
									{
										goto IL_0d65;
									}
									if ((nint)obj22 != 46 && (nint)obj22 != 47 && (nint)obj22 != 48 && (nint)obj22 != 49 && (nint)obj22 != 50 && (nint)obj22 != 51)
									{
										if ((nint)obj22 == 52 || (nint)obj22 == 53 || (nint)obj22 == 54)
										{
											goto IL_0d65;
										}
										if ((nint)obj22 != 55 && (nint)obj22 != 56 && (nint)obj22 == 57)
										{
											object obj23 = obj4 + 4;
											object obj24 = obj23 + 1;
											obj23 = obj24;
											object obj25 = obj24 << 2;
											object obj26 = obj4 + obj25;
											obj26 = 162;
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_11dc;
		}
		goto IL_0d65;
		IL_0d65:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj27 = default;
		object obj28 = default;
		if (obj27 == obj28)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_11dc;
		IL_1201:
		nint num22 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S0_v68 (Il2CppClass<UIScreenController>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num23 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S0_v74 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag4).QueueSlideIn((SlideIn)(object)"Award tier(s)\nare completed");
		return;
		IL_11dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj30 = (nint)0 << 2;
			object obj31 = obj4 + obj30;
			if ((nint)obj31 == 162)
			{
				object obj32 = obj4 + 4;
				if ((nint)obj32 > -1)
				{
					object obj33 = obj32 + -1;
					obj32 = obj33;
				}
				goto IL_1201;
			}
		}
		object obj34 = default;
		if (obj34 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_1201;
	}

	private void GiveFullUpgrades()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_04d5: Expected Obj, but got I4
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_0505: Expected I, but got Obj
		//IL_051b: Expected Obj, but got I
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_033e: Expected Obj, but got I4
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_0644: Expected I, but got Obj
		//IL_065a: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I
		//IL_05fd: Expected Obj, but got I4
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_0169: Expected I, but got Obj
		//IL_047e: Expected I, but got Obj
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0244: Expected I, but got Obj
		//IL_025a: Expected Obj, but got I
		//IL_01f7: Expected I, but got Obj
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0285: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 16;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v177 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 32;
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v30 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v171 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, string>.KeyCollection keys = almostCompleteAwardsTiersSelectedItems.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @821F");
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23+8]");
		_ = 0;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num5 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v101 (Il2CppClass<Missions.AwardsManager>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v164 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			nint num7 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v113 (Il2CppClass<System.Type>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v157 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			obj2 = typeof(AwardId);
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num9 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v125 (Il2CppClass<System.Enum>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num10 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v150 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj12 = obj4 + 4;
		object obj13 = obj12 + 1;
		obj12 = obj13;
		object obj14 = obj13 << 2;
		object obj15 = obj4 + obj14;
		obj15 = 95;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj4 + obj16;
			if ((nint)obj17 == 95)
			{
				object obj18 = obj4 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_0636;
			}
		}
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0636;
		IL_0636:
		nint num11 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v51 (Il2CppClass<UIScreenController>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num12 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v57 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueueSlideIn((SlideIn)(object)"Award tier(s)\nare almost completed");
	}

	private void SkipMissions()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_05ea: Expected Obj, but got I4
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected Obj, but got Unknown
		//IL_061a: Expected I, but got Obj
		//IL_0630: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected Obj, but got Unknown
		//IL_06d0: Expected Obj, but got I4
		//IL_06d9: Expected Obj, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I4
		//IL_01fd: Expected Obj, but got I4
		//IL_07a6: Expected I, but got Obj
		//IL_07bc: Expected Obj, but got I
		//IL_04cd: Expected Obj, but got I
		//IL_03fd: Expected Obj, but got I4
		//IL_0760: Expected I, but got Obj
		//IL_0776: Expected Obj, but got I
		//IL_029e: Expected Obj, but got I
		//IL_0585: Expected I, but got Obj
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		//IL_0356: Expected I, but got Obj
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v205 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UpgradeType> list = default;
		list._002Ector();
		list.Add(UpgradeType.coinmagnet);
		list.Add(UpgradeType.doubleMultiplier);
		list.Add(UpgradeType.supersneakers);
		list.Add(UpgradeType.jetpack);
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v34 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v199 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(HasDeliveredFullUpgrades ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj7 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj7 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			object obj8 = obj4 + 4;
			object obj9 = obj8 + 1;
			obj8 = obj9;
			object obj10 = obj9 << 2;
			object obj11 = obj4 + obj10;
			obj11 = 169;
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj13 = (nint)0 << 2;
				object obj14 = obj4 + obj13;
				if ((nint)obj14 == 169)
				{
					object obj15 = obj4 + 4;
					if ((nint)obj15 > -1)
					{
						object obj16 = obj15 + -1;
						obj15 = obj16;
					}
					goto IL_0752;
				}
			}
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0752;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj17 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj17 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			object obj18 = 0;
			while ((nint)obj18 <= 5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj19 = obj18 + 1;
				obj18 = obj19;
			}
		}
		object obj20 = obj4 + 4;
		object obj21 = obj20 + 1;
		obj20 = obj21;
		object obj22 = obj21 << 2;
		object obj23 = obj4 + obj22;
		obj23 = 116;
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj25 = (nint)0 << 2;
			object obj26 = obj4 + obj25;
			if ((nint)obj26 == 116)
			{
				object obj27 = obj4 + 4;
				if ((nint)obj27 > -1)
				{
					object obj28 = obj27 + -1;
					obj27 = obj28;
				}
				goto IL_0798;
			}
		}
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0798;
		IL_0798:
		nint num5 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v61 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num6 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v67 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HasDeliveredFullUpgrades = true;
		return;
		IL_0752:
		nint num7 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v143 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num8 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v149 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HasDeliveredFullUpgrades = false;
	}

	private void ToggleDebugZDistanceTargetPosition()
	{
		//IL_01b0: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_0244: Expected I, but got Obj
		//IL_025a: Expected Obj, but got I
		//IL_0121: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I4
		//IL_0162: Expected I, but got Obj
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		object obj2 = 0;
		while (true)
		{
			nint num3 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v16 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v43 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)obj2 >= amountOfMissionSetsToSkip)
			{
				break;
			}
			MissionTarget missionTarget = MissionTarget.none;
			while (missionTarget <= MissionTarget.SpendCoin)
			{
				StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
				((MissionsManager)(object)instance2).OverWriteAchievementsProgress(missionTarget, 0);
				MissionTarget missionTarget2 = missionTarget + 1;
				missionTarget = missionTarget2;
			}
			object obj4 = obj2 + 1;
			obj2 = obj4;
		}
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v23 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueueSlideIn((SlideIn)(object)"Mission sets\nhave been skipped.");
	}

	private void ToggleQueuedEnvironmentSpawning()
	{
		bool useQueuedEnvironmentKinds = DebugSettings.UseQueuedEnvironmentKinds;
		bool useQueuedEnvironmentKinds2 = (byte)((useQueuedEnvironmentKinds ? 1u : 0u) ^ 1u) != 0;
		DebugSettings.UseQueuedEnvironmentKinds = useQueuedEnvironmentKinds2;
	}

	private void SkipTutorialLevel()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		EnvironmentKind[] queuedEnvironmentKinds = DebugSettings.QueuedEnvironmentKinds;
		EnvironmentKind[] queuedEnvironmentKinds2 = (EnvironmentKind[])(queuedEnvironmentKinds ^ 1);
		DebugSettings.QueuedEnvironmentKinds = queuedEnvironmentKinds2;
	}

	private void ExportPlayerInfo()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ForceClosePresentPopups();
	}

	private void ImportPlayerInfo()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveGameDebug.ImportPlayerInfoFromExternal();
	}

	private void CopyPlayerDataToClipboard()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveGameDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveGameDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Data.DebugUtil.SaveGameDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveGameDebug.ExportToFiles();
	}

	public void RequestAnalyticsCheck()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_032d: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_018d: Expected I4, but got Obj
		//IL_019f: Expected I4, but got Obj
		//IL_01dd: Expected I4, but got Obj
		//IL_01ef: Expected I4, but got Obj
		//IL_022d: Expected I4, but got Obj
		//IL_023f: Expected I4, but got Obj
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_02be: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string msg = default;
		FlurryVideoAds.LogError(msg, (UnityEngine.Object)null);
		nint num = (nint)typeof(PlayerInfoMigrator);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(PlayerInfoMigrator);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v86 (Il2CppClass<Data.Migration.PlayerInfoMigrator>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		string[] array = default;
		string[] values = array;
		string values2 = string.ConcatArray(values, (int)"\r\n");
		string values3 = string.ConcatArray((string[])(object)values2, (int)"Cloud Data -\r\n");
		int overridePerformanceLevel = DebugSave.overridePerformanceLevel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v24 (System.Int32)+C]");
		string values4 = string.ConcatArray((string[])(object)values3, 0);
		string values5 = string.ConcatArray((string[])(object)values4, (int)"\r\n");
		string values6 = string.ConcatArray((string[])(object)values5, (int)"Local Data -\r\n");
		int overridePerformanceLevel2 = DebugSave.overridePerformanceLevel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v31 (System.Int32)+8]");
		string values7 = string.ConcatArray((string[])(object)values6, 0);
		string values8 = string.ConcatArray((string[])(object)values7, (int)"\r\n");
		string values9 = string.ConcatArray((string[])(object)values8, (int)"Local Debug Data -\r\n");
		int overridePerformanceLevel3 = DebugSave.overridePerformanceLevel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v38 (System.Int32)+10]");
		string message = string.ConcatArray((string[])(object)values9, 0);
		nint num3 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v41 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v46 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DeviceUtility.MakeIOSNSLog(message);
	}

	public static void DebugButtonSkipTutorialLevel()
	{
	}

	private static void SkipTutorialLevelSegment()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ForceClosePresentPopups();
	}

	private unsafe void ScheduleTestNotification()
	{
		//IL_01ed: Expected Obj, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I4
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected VT, but got Unknown
		//IL_033c: Expected I4, but got Obj
		//IL_0337: Expected native int or pointer, but got VT
		//IL_0351: Expected Obj, but got I
		//IL_034c: Expected native int or pointer, but got VT
		//IL_0117: Expected I, but got Obj
		//IL_0164: Expected I, but got Obj
		//IL_017a: Expected Obj, but got I
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected Obj, but got Unknown
		//IL_02ec: Expected I, but got Obj
		//IL_0302: Expected Obj, but got I
		//IL_01a5: Expected I, but got Obj
		object obj = 0;
		_ = 0;
		int syboAnalyticsCurrentSession = SyboAnalyticsSave.syboAnalyticsCurrentSession;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Texture2D texture2D = default;
		object obj2 = texture2D + 8;
		obj2 = syboAnalyticsCurrentSession;
		byte[] array = ImageConversion.EncodeToPNG(texture2D);
		Encoding latin = Encoding.Latin1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)(object)"http://docker.sybogames.local:11000/sybot/analytics-check");
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v24 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v34 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IRequest request = WebClient.CreateGet(uri);
		IRequest request2 = RequestExtensions.WithIgnoreContentMD5(request, ignoreContentMD5: true);
		object jsonData = default;
		IRequest request3 = RequestExtensions.WithJsonContent(request2, jsonData, (IJsonSerializer)(object)"application/json");
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v17 (Il2CppClass<DebugSettingsPopup+<>c>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v55 (Il2CppClass<DebugSettingsPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__140_0 == null;
		bool flag2 = !flag;
		WebClient.RequestCompleteHandler onComplete = _003C_003Ec._003C_003E9__140_0;
		if (!flag2)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v32 (Il2CppClass<DebugSettingsPopup+<>c>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v49 (Il2CppClass<DebugSettingsPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			WebClient.RequestCompleteHandler requestCompleteHandler = default;
			((Delegate)requestCompleteHandler).method_ptr = method_ptr;
			((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec._003CRequestAnalyticsCheck_003Eb__140_0);
			object obj6 = requestCompleteHandler + 16;
			obj6 = _003C_003Ec._003C_003E9;
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v46 (Il2CppClass<DebugSettingsPopup+<>c>)+5C]");
			object obj7 = (nint)0 + (nint)4;
			obj7 = requestCompleteHandler;
			onComplete = requestCompleteHandler;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
		Coroutine coroutine = RequestExtensions.SendAsync(request3, onComplete, sendOptions);
	}

	private void ResetFpb()
	{
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected Obj, but got Unknown
		//IL_058b: Expected Obj, but got I4
		//IL_0599: Expected I, but got Obj
		//IL_05af: Expected Obj, but got I
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		//IL_0716: Expected Obj, but got I4
		//IL_0176: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0247: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_0617: Expected I4, but got Obj
		//IL_04a7: Expected I, but got Obj
		//IL_04bd: Expected Obj, but got I
		//IL_0288: Expected I, but got Obj
		//IL_02df: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_0685: Expected Obj, but got VT
		//IL_069d: Expected I, but got Obj
		//IL_06b3: Expected Obj, but got I
		//IL_0633: Expected I4, but got Obj
		//IL_04e8: Expected I, but got Obj
		//IL_0320: Expected I, but got Obj
		//IL_0377: Expected I, but got Obj
		//IL_038d: Expected Obj, but got I
		//IL_0535: Expected I, but got Obj
		//IL_064f: Expected I4, but got Obj
		//IL_03b8: Expected I, but got Obj
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_05df: Expected I4, but got Obj
		//IL_0124: Expected I, but got Obj
		//IL_040f: Expected I, but got Obj
		//IL_0425: Expected Obj, but got I
		//IL_066b: Expected I4, but got Obj
		//IL_0450: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v150 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 16;
		object obj5 = notificationTypeToDisplay - 1;
		if (notificationTypeToDisplay != DebugNotificationType.Coins)
		{
			if ((nint)obj5 != 1)
			{
				if ((nint)obj5 != 2)
				{
					if ((nint)obj5 != 3)
					{
						if ((nint)obj5 == 4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
							nint num3 = (nint)typeof(HouseKeeper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v124 (Il2CppClass<HouseKeeper>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num4 = (nint)typeof(HouseKeeper);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v131 (Il2CppClass<HouseKeeper>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool triggeredViaMysteryPowerup = default;
							ActivePowerup activePowerup = ((GameStats)(object)"LOCAL_NOTIFICATION_MESSAGE_DAILY_VIDEO").TriggerPowerup((UpgradeType)"LOCAL_NOTIFICATION_MESSAGE_DAILY_VIDEO_PERSONAL", triggeredViaMysteryPowerup);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
							nint num5 = (nint)typeof(HouseKeeper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v139 (Il2CppClass<HouseKeeper>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num6 = (nint)typeof(HouseKeeper);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v146 (Il2CppClass<HouseKeeper>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool triggeredViaMysteryPowerup2 = default;
							ActivePowerup activePowerup = ((GameStats)(object)"LOCAL_NOTIFICATION_TEST").TriggerPowerup((UpgradeType)"LOCAL_NOTIFICATION_TEST_PERSONAL", triggeredViaMysteryPowerup2);
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
						nint num7 = (nint)typeof(HouseKeeper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v109 (Il2CppClass<HouseKeeper>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num8 = (nint)typeof(HouseKeeper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v116 (Il2CppClass<HouseKeeper>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool triggeredViaMysteryPowerup3 = default;
						ActivePowerup activePowerup = ((GameStats)(object)"LOCAL_NOTIFICATION_MESSAGE_SMB").TriggerPowerup((UpgradeType)"LOCAL_NOTIFICATION_MESSAGE_SMB_PERSONAL", triggeredViaMysteryPowerup3);
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
					nint num9 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v94 (Il2CppClass<HouseKeeper>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num10 = (nint)typeof(HouseKeeper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v101 (Il2CppClass<HouseKeeper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool triggeredViaMysteryPowerup4 = default;
					ActivePowerup activePowerup = ((GameStats)(object)"LOCAL_NOTIFICATION_MESSAGE_MB").TriggerPowerup((UpgradeType)"LOCAL_NOTIFICATION_MESSAGE_MB_PERSONAL", triggeredViaMysteryPowerup4);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
				nint num11 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v79 (Il2CppClass<HouseKeeper>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num12 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v86 (Il2CppClass<HouseKeeper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool triggeredViaMysteryPowerup5 = default;
				ActivePowerup activePowerup = ((GameStats)(object)"LOCAL_NOTIFICATION_MESSAGE_TOPRUN_ENDING").TriggerPowerup((UpgradeType)"LOCAL_NOTIFICATION_MESSAGE_TOPRUN_ENDING_PERSONAL", triggeredViaMysteryPowerup5);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A44");
			nint num13 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v25 (Il2CppClass<System.DateTime>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num14 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v52 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime utcNow = DateTime.UtcNow;
			obj = utcNow;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
			nint num15 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v33 (Il2CppClass<Strings>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num16 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v48 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("LOCAL_NOTIFICATION_TITLE");
			object obj13 = default;
			obj2 = obj13;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9404");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj4 = 123;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	private void ActivateCollectState()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FirstPurchaseBonusManager.ActivateCollectState();
	}

	private void EnableGuidelineTest()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FirstPurchaseBonusManager.StartStateCheckCoroutine();
	}

	private void ForceDownloadOnlineSettings()
	{
		//IL_01bd: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v29 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @93AB");
		object obj4 = default;
		object obj3 = obj4 - 1;
		if ((nint)obj4 != 1)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 != 2)
				{
					if ((nint)obj3 == 3)
					{
						OnboardingSave.shouldShowFacebookPopup = true;
						OnboardingSave.hasShownFacebookPopup = false;
					}
				}
				else
				{
					OnboardingSave.shouldShowEndGameMissionPopup = true;
					OnboardingSave.hasShownEndGameMissionPopup = false;
				}
			}
			else
			{
				OnboardingSave.shouldShowHoverboardPopup = true;
				OnboardingSave.hasShownHoverboardPopup = false;
			}
		}
		else
		{
			OnboardingSave.shouldShowMissionIntroPopup = true;
			OnboardingSave.hasShownMissionIntroPopup = false;
		}
	}

	private static void ForceClosePresentPopups()
	{
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_07fd: Expected I, but got Obj
		//IL_0813: Expected Obj, but got I
		//IL_0b52: Expected Obj, but got I4
		//IL_0b64: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		//IL_0139: Expected I, but got Obj
		//IL_0228: Expected Obj, but got I4
		//IL_0b7b: Expected I, but got Obj
		//IL_0b91: Expected Obj, but got I
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_0868: Expected Obj, but got I4
		//IL_0851: Expected Obj, but got I4
		//IL_023b: Expected I, but got Obj
		//IL_01e0: Expected I, but got Obj
		//IL_08ad: Expected I, but got Obj
		//IL_08c3: Expected Obj, but got I
		//IL_02a1: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I
		//IL_0bc5: Expected Obj, but got I4
		//IL_0bc5: Expected Obj, but got I4
		//IL_0bd3: Expected I, but got Obj
		//IL_0be9: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I4
		//IL_036d: Expected I, but got Obj
		//IL_0383: Expected Obj, but got I
		//IL_089a: Expected Obj, but got I4
		//IL_0aa5: Expected Obj, but got I4
		//IL_0ab3: Expected I, but got Obj
		//IL_0ac9: Expected Obj, but got I
		//IL_057c: Expected I, but got Obj
		//IL_0911: Expected I, but got Obj
		//IL_0927: Expected Obj, but got I
		//IL_02e2: Expected I, but got Obj
		//IL_05c9: Expected I, but got Obj
		//IL_0957: Expected I, but got Obj
		//IL_096d: Expected Obj, but got I
		//IL_03ae: Expected I, but got Obj
		//IL_06f1: Expected I, but got Obj
		//IL_0707: Expected Obj, but got I
		//IL_0616: Expected I, but got Obj
		//IL_09aa: Expected I, but got Obj
		//IL_09c0: Expected Obj, but got I
		//IL_03fb: Expected I, but got Obj
		//IL_0b3b: Expected Obj, but got I4
		//IL_0663: Expected I, but got Obj
		//IL_0679: Expected Obj, but got I
		//IL_09ef: Expected Obj, but got I4
		//IL_09fd: Expected I, but got Obj
		//IL_0a13: Expected Obj, but got I
		//IL_0448: Expected I, but got Obj
		//IL_0732: Expected I, but got Obj
		//IL_0b1f: Expected Obj, but got I4
		//IL_0a47: Expected Obj, but got I4
		//IL_0a55: Expected I, but got Obj
		//IL_0a6b: Expected Obj, but got I
		//IL_0495: Expected I, but got Obj
		//IL_06a4: Expected I, but got Obj
		//IL_04e2: Expected I, but got Obj
		//IL_052f: Expected I, but got Obj
		object obj = default;
		string text = (string)(obj + 16);
		object obj2 = obj + 8;
		if (OnboardingSave.numberOfRunsSinceLastGuideline != 0)
		{
			return;
		}
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v18 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v92 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		OnboardingSave.numberOfRunsSinceLastGuideline = 1;
		nint num3 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v26 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v86 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_shouldRefreshListOnShow = true;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v33 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v82 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool isShowingPopup = ((UIScreenController)flag).isShowingPopup;
		object obj7;
		if ((string)isShowingPopup != "DebugSettingsPopup")
		{
			nint num7 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v67 (Il2CppClass<Globals>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v76 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool dEBUG_POPUP_TESTOLOGY = Globals.DEBUG_POPUP_TESTOLOGY;
			obj7 = (dEBUG_POPUP_TESTOLOGY ? 1 : 0) ^ 1;
		}
		else
		{
			obj7 = 0;
		}
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v145 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag2).DelayHideMainCamera();
		if ((string)(object)enumerator != "PauseUI")
		{
			nint num11 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v135 (Il2CppClass<UIScreenController>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num12 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v141 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag3).SwitchScreen("IngameUI");
		}
		else if ((string)(object)enumerator != "FrontScreen")
		{
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
			nint num13 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v69 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num14 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v130 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = obj2;
			text = (string)obj;
			AgeRestriction.Log(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @89B1");
			nint num15 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v78 (Il2CppClass<DebugSettingsPopup>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num16 = (nint)typeof(DebugSettingsPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v126 (Il2CppClass<DebugSettingsPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DebugSettingsPopup._002Ecctor();
			nint num17 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v84 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num18 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S1_v122 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			((SSEventsManagerController)(object)flurryUserId).CurrentEventHasBeenTriedNow();
			nint num19 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S1_v91 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num20 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S1_v118 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			((Game)isInstantiated).Update();
			nint num21 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S1_v98 (Il2CppClass<UIScreenController>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num22 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S1_v114 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag4).SwitchScreen("IngameUI");
			nint num23 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S1_v105 (Il2CppClass<SaveMeManager>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num24 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S1_v110 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveMeManager.SkipReviveIfPurchaseFailed();
		}
		nint num25 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S1_v26 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num26 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v60 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)102);
		nint num27 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v33 (Il2CppClass<UIScreenController>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num28 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v56 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag5).PayoutCelebrationReward(null);
		nint num29 = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v40 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num30 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v52 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DebugSettingsPopup._002Ecctor();
		if (obj7 != null)
		{
			nint num31 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v55 (Il2CppClass<UIScreenController>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num32 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S0_v61 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag6 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag6).QueuePopup("DebugSettingsPopup");
		}
		nint num33 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v44 (Il2CppClass<UIScreenController>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num34 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v50 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag7 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag7).QueueSlideIn((SlideIn)(object)"Tutorial has\nbeen skipped");
	}

	private void OpenAdSystemTesterPopup()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		((OnlineSettings)(object)saveDataPath).LoadFromFile();
	}

	private void ForciblyChangeVideoProvider()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("AdSystemTesterPopup");
	}

	private void ForciblyChangeInterstitialProvider()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance != null)
		{
			((DebugSettingsPopup)null).ToggleAdSystemSingleImpressionLimit();
		}
	}

	private void ToggleDebugFailNextCacheCall()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance != null)
		{
			((DebugSettingsPopup)null).ToggleAdSystemSingleImpressionLimit();
		}
	}

	private void ChangeToNextProvider()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(DebugAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DebugAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool forceCacheToFail = DebugAdProvider.forceCacheToFail;
		bool forceCacheToFail2 = (byte)((forceCacheToFail ? 1u : 0u) ^ 1u) != 0;
		DebugAdProvider.forceCacheToFail = forceCacheToFail2;
	}

	private void ToggleAdSystemSingleImpressionLimit()
	{
		OfferWallManager instance = OfferWallManager.instance;
		((AdSystemManager)(object)instance)._002Ector();
	}

	private void ToggleAdDebugProviderState()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_AD_SYSTEM_SINGLE_IMPRESSION = Globals.DEBUG_AD_SYSTEM_SINGLE_IMPRESSION;
		bool dEBUG_AD_SYSTEM_SINGLE_IMPRESSION2 = (byte)((dEBUG_AD_SYSTEM_SINGLE_IMPRESSION ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_AD_SYSTEM_SINGLE_IMPRESSION = dEBUG_AD_SYSTEM_SINGLE_IMPRESSION2;
	}

	private void UpdateQuickVideoButtonState()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DebugSettingsPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DebugSettingsPopup>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugSettingsPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<DebugSettingsPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EventTesterManager instance = EventTesterManager.Instance;
		if (instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_DEBUG_AD_PROVIDER = Globals.DEBUG_USE_DEBUG_AD_PROVIDER;
		bool dEBUG_USE_DEBUG_AD_PROVIDER2 = (byte)((dEBUG_USE_DEBUG_AD_PROVIDER ? 1u : 0u) ^ 1u) != 0;
		Globals.DEBUG_USE_DEBUG_AD_PROVIDER = dEBUG_USE_DEBUG_AD_PROVIDER2;
		((DebugSettingsPopup)null).ToggleAdSystemSingleImpressionLimit();
		((DebugSettingsPopup)null)._002Ector();
	}

	public DebugSettingsPopup()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		UIScreen uIScreen = ((UIScreenController)flag)._ActivateScreen("FrontScreen");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		FrontScreen frontScreen = default;
		frontScreen.AnimatePromotionButton();
	}

	static DebugSettingsPopup()
	{
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_014b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		while (true)
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			IEnumerator enumerator = ((UIScreenController)flag).HideInAppPurchaceOverlayDelayedCoroutine();
			if (enumerator != null)
			{
				break;
			}
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).DebugCloseAllPopups();
		}
	}
}
