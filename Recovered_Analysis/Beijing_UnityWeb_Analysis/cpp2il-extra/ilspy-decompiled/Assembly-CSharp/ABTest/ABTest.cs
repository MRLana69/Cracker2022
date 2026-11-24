using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using AdHandling.AdConstants;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Analytics;
using Kiloo.Common.Ads;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.Utility;
using SYBO.Components.Analytics;
using SYBO.Components.Analytics.Integration;
using UnityEngine;
using UnityEngine.Rendering;

namespace ABTest;

public class ABTest
{
	private const string ONLINESETTINGS_ABTEST_PREFIX = "abtest";

	private const string ONLINESETTINGS_ABTEST_VERSION_KEY = "version";

	private const string ONLINESETTINGS_ABTEST_DEFAULT_PAYLOAD_KEY = "default_payload_override";

	private const string ONLINESETTINGS_ABTEST_ACTIVE_KEY = "active";

	private const string ONLINESETTINGS_ABTEST_MIN_INSTALL_DATETIME_KEY = "min_install_datetime";

	private const string ONLINESETTINGS_ABTEST_MAX_INSTALL_DATETIME_KEY = "max_install_datetime";

	private const string ONLINESETTINGS_ABTEST_EXCLUDED_TAGS_KEY = "excluded_tags";

	private const string ONLINESETTINGS_ABTEST_SEGMENT_OFFSET_KEY = "segment_offset";

	private const string ONLINESETTINGS_ABTEST_SEGMENT_SIZE_KEY = "segment_size";

	private const string ONLINESETTINGS_ABTEST_SEGMENT_PAYLOAD_KEY = "segment_payload";

	private const string ONLINESETTINGS_ABTEST_TAG_KEY = "tag";

	private const string ONLINESETTINGS_ABTEST_INCLUDE_ANALYTICS_SAMPLING_RANGE_KEY = "include_analytics_sampling_key_range";

	private const string ONLINESETTINGS_ABTEST_EXCLUDE_ANALYTICS_SAMPLING_RANGE_KEY = "exclude_analytics_sampling_key_range";

	private const string ONLINESETTINGS_ABTEST_DEBUG_ENABLE_ANALYTICS_SAMPLING_KEY_CHECK = "debug_enable_analytics_sampling_key_range";

	private const int DEFAULT_ABTEST_VERSION = 0;

	private const bool DEFAULT_ABTEST_ACTIVE = false;

	private const bool DEFAULT_ABTEST_DEBUG_ENABLE_ANALYTICS_SAMPLING_KEY_CHECK = false;

	private const string DEFAULT_ABTEST_DEFAULT = "";

	private const string DEFAULT_ABTEST_MIN_INSTALL_DATETIME = "";

	private const string DEFAULT_ABTEST_MAX_INSTALL_DATETIME = "";

	private const string DEFAULT_ABTEST_EXCLUDED_TAGS = "";

	private const string DEFAULT_ABTEST_SEGMENT_OFFSET = "";

	private const string DEFAULT_ABTEST_SEGMENT_SIZE = "";

	private const string DEFAULT_ABTEST_SEGMENT_PAYLOAD = "";

	private const string DEFAULT_ABTEST_INCLUDE_ANALYTICS_SAMPLING_RANGE = "";

	private const string DEFAULT_ABTEST_EXCLUDE_ANALYTICS_SAMPLING_RANGE = "";

	private const string DEBUG_PAYLOAD_PREFIX = "debug_payload_";

	private static readonly Range[] KILOO_ANALYTICS_SAMPLING_KEY_TEST_RANGES;

	private static readonly Range[] SYBO_ANALYTICS_SAMPLING_KEY_TEST_RANGES;

	private readonly string _identifier;

	private readonly float _sample;

	private readonly TestRange _analyticsSamplingKeyRange;

	private readonly float _analyticsSamplingKey;

	private int _version;

	private int _segmentIndex;

	private bool isForcedDisabled__BackingField;

	private bool isActive__BackingField;

	private string payload__BackingField;

	private string defaultPayload__BackingField;

	private string tag__BackingField;

	public int segmentIndex
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)defaultPayload__BackingField;
		}
	}

	public bool isForcedDisabled
	{
		get
		{
			return (byte)_segmentIndex != 0;
		}
		private set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_0031: Expected Obj, but got I4
			((WaterFallReach)this).Reset();
			_identifier = null;
			_ = 0;
			_sample = 0f;
			object obj = this + 16;
			obj = value;
		}
	}

	public bool isActive
	{
		get
		{
			return isForcedDisabled__BackingField;
		}
		private set
		{
			isForcedDisabled__BackingField = value;
		}
	}

	public string payload
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = isActive__BackingField;
			return (string)flag;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			isActive__BackingField = flag;
		}
	}

	public string defaultPayload
	{
		get
		{
			return payload__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 36;
			obj = value;
		}
	}

	public string tag
	{
		get
		{
			return defaultPayload__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 40;
			obj = value;
		}
	}

	public ABTest(ABTestData.ABTestDataItem testDataItem)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 44;
		obj = testDataItem;
	}

	public unsafe void Update(List<string> tags)
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_018e: Expected I4, but got Obj
		//IL_01b9: Expected I4, but got Obj
		//IL_0039: Expected Obj, but got I4
		//IL_004b: Expected I, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_01d0: Expected I4, but got Obj
		//IL_01f0: Expected I4, but got Obj
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I4
		_segmentIndex = -1;
		object obj = this + 8;
		obj = tags._size;
		_analyticsSamplingKeyRange = (TestRange)tags._syncRoot;
		float userSampleValue = Manager.userSampleValue;
		_analyticsSamplingKey = userSampleValue;
		string abTestTagData = AnalyticsSave.abTestTagData;
		string list = string.ConcatArray((string[])(object)abTestTagData, (int)_identifier);
		Coroutine str = CoroutineUtil.WaitForAll((IEnumerable<YieldInstruction>)(object)list);
		bool flag = TimeUtility.TryParseSortableNumber((string)(object)str, out *(DateTime*)null);
		string text = ((string)flag).InternalSubString(0, 8);
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v16 (Il2CppClass<System.Convert>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v34 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Convert.ToString((int)text, 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AggregatedDataTracking aggregatedDataTracking = default;
		aggregatedDataTracking.Initialize((byte)(int)text2 != 0, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SyboRandom syboRandom = default;
		object obj3 = syboRandom + 8;
		obj3 = aggregatedDataTracking;
		float num3 = syboRandom.Value();
		float sample = num3 * 100f;
		_sample = sample;
		_version = -1;
		object obj4 = this + 40;
		obj4 = tags._version;
		bool flag2 = tags._items != null;
		isForcedDisabled__BackingField = flag2;
	}

	private bool IsExcludedByIncludeAnalyticsSamplingKeyRange()
	{
		//IL_0007: Expected I4, but got Obj
		return (byte)(int)tag__BackingField != 0;
	}

	private bool IsExcludedByExcludeAnalyticsSamplingKeyRange()
	{
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_01e4: Expected I, but got Obj
		//IL_01fa: Expected Obj, but got I
		//IL_0188: Expected I4, but got Obj
		//IL_019e: Expected I4, but got Obj
		//IL_01b1: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ce: Invalid comparison between I and F4
		//IL_00ff: Invalid comparison between I and F4
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		nint num3 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v34 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<float> key = ParseFloatList(_identifier, (char)(int)"include_analytics_sampling_key_range");
		bool value = ((OnlineSettings)(object)saveDataPath).GetValue((string)(object)key, (byte)(int)"" != 0);
		IAsyncResult asyncResult = ((PokiUnitySDK.CommercialBreakDelegate)null).BeginInvoke((AsyncCallback)value, (object)45);
		if (asyncResult != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v20 (System.IAsyncResult)+C]");
			bool flag;
			if (0f < _analyticsSamplingKey)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v20 (System.IAsyncResult)+8]");
				flag = !(0f < _analyticsSamplingKey);
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				return true;
			}
		}
		return false;
	}

	private bool IsExcludedByAnalyticsSamplingKeyTestRanges()
	{
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_01ef: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_0188: Expected I4, but got Obj
		//IL_019e: Expected I4, but got Obj
		//IL_01b1: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ce: Invalid comparison between I and F4
		//IL_00ff: Invalid comparison between I and F4
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		nint num3 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v35 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<float> key = ParseFloatList(_identifier, (char)(int)"exclude_analytics_sampling_key_range");
		bool value = ((OnlineSettings)(object)saveDataPath).GetValue((string)(object)key, (byte)(int)"" != 0);
		IAsyncResult asyncResult = ((PokiUnitySDK.CommercialBreakDelegate)null).BeginInvoke((AsyncCallback)value, (object)45);
		if (asyncResult != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v20 (System.IAsyncResult)+C]");
			bool flag;
			if (0f < _analyticsSamplingKey)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v20 (System.IAsyncResult)+8]");
				flag = !(0f < _analyticsSamplingKey);
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				return true;
			}
		}
		return false;
	}

	private bool IsCheckForAnalyticsSamplingKeyRangeEnabled()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I4
		//IL_0051: Invalid comparison between I and F4
		//IL_01ef: Expected Obj, but got I
		//IL_0082: Invalid comparison between I and F4
		//IL_02b6: Expected Obj, but got I
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		string text = GetPayload();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v86+C]");
				bool flag;
				if (0f < _analyticsSamplingKey)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v86+8]");
					flag = !(0f < _analyticsSamplingKey);
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					object obj4 = obj2 + 4;
					object obj5 = obj4 + 1;
					obj4 = obj5;
					object obj6 = obj5 << 2;
					object obj7 = obj2 + obj6;
					obj7 = 59;
					break;
				}
				continue;
			}
			object obj8 = obj2 + 4;
			object obj9 = obj8 + 1;
			obj8 = obj9;
			object obj10 = obj9 << 2;
			object obj11 = obj2 + obj10;
			obj11 = 57;
			break;
		}
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj2 + obj13;
			if ((nint)obj14 == 59)
			{
				object obj15 = obj2 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				goto IL_03f5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj2 + obj17;
			if ((nint)obj18 == 57)
			{
				object obj19 = obj2 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				return true;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			goto IL_03f5;
		}
		return true;
		IL_03f5:
		bool result = default;
		return result;
	}

	private string RangesToText(IEnumerable<Range> ranges)
	{
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I4
		//IL_008f: Expected Obj, but got I4
		nint num = (nint)typeof(WaterFallReach);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.JsonUtil.WaterFallReach>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WaterFallReach);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<Kiloo.Common.JsonUtil.WaterFallReach>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Enumerable.Contains(WaterFallReach.SCREENS_THAT_CAN_CACHE_A_VIDEO_AD, (string)(object)ranges))
		{
			if ((string)(object)ranges != "ChallengesScreen")
			{
				bool isRestricted = ((AdConstants)null).isRestricted;
				return (string)isRestricted;
			}
			return (string)1;
		}
		return null;
	}

	private unsafe IEnumerable<Range> GetAnalyticsSamplingKeyTestRanges()
	{
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_01de: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_013d: Expected I4, but got Obj
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		nint num3 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v2 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v12 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<float> key = ParseFloatList(_identifier, (char)(int)"debug_enable_analytics_sampling_key_range");
		bool flag = ((OnlineSettings)(object)saveDataPath).TryGetValue((string)(object)key, out *(string*)null);
		nint num5 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v7 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v16 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG = Globals.DEBUG;
		object obj4 = (dEBUG ? 1 : 0) ^ 1;
		return (IEnumerable<Range>)(flag | obj4);
	}

	public string GetPayload()
	{
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_0078: Expected I, but got Obj
		//IL_00c5: Expected I, but got Obj
		//IL_00db: Expected Obj, but got I
		//IL_0106: Expected I, but got Obj
		if (_analyticsSamplingKeyRange != TestRange.Kiloo)
		{
			if (_analyticsSamplingKeyRange == TestRange.Sybo)
			{
				nint num = (nint)typeof(ABTest);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v23 (Il2CppClass<ABTest.ABTest>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(ABTest);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v30 (Il2CppClass<ABTest.ABTest>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (string)(object)SYBO_ANALYTICS_SAMPLING_KEY_TEST_RANGES;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			string result = default;
			return result;
		}
		nint num3 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)KILOO_ANALYTICS_SAMPLING_KEY_TEST_RANGES;
	}

	public bool GetPayload(bool defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_010a: Expected I4, but got Obj
		//IL_01ce: Expected Obj, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		string text = string.Empty;
		object obj3 = default;
		object obj4 = default;
		object obj5 = default;
		string text2 = default;
		string text3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj4 == obj5)
			{
				text = text2;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			text = text3;
		}
		object obj6 = obj2 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj2 + obj8;
		obj9 = 71;
		bool result = (byte)(int)text != 0;
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj2 + obj11;
			if ((nint)obj12 == 71)
			{
				object obj13 = obj2 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_02dc;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02dc;
		IL_02dc:
		return result;
	}

	public unsafe uint GetPayload(uint defaultValue)
	{
		//IL_0075: Expected Obj, but got I4
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		IFormatProvider formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(bool);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<System.Boolean>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(bool);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v14 (Il2CppClass<System.Boolean>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ((bool*)payload__BackingField)->System_002EIConvertible_002EToBoolean(formatProvider);
		bool result = formatProvider != null;
		if (flag)
		{
			return result ? 1u : 0u;
		}
		return defaultValue;
	}

	public unsafe int GetPayload(int defaultValue)
	{
		//IL_0059: Expected I4, but got I8
		ref ulong reference = ref *(ulong*)null;
		NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
		if (ulong.TryParse(payload__BackingField, NumberStyles.Integer, currentInfo, out reference))
		{
			return (int)reference;
		}
		return defaultValue;
	}

	private unsafe static string GetOnlineSettingsKey(string identifier, string key)
	{
		//IL_0030: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I8
		ref long reference = ref *(long*)null;
		NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [identifier @ L0 (System.String)+24]");
		if (long.TryParse((string)0, NumberStyles.Integer, currentInfo, out reference))
		{
			return (string)reference;
		}
		return key;
	}

	public Range ParseKeyRange(string str, char separator)
	{
		//IL_012a: Expected I, but got Obj
		//IL_0140: Expected Obj, but got I
		//IL_016b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool allowReCacheOnFail = ((AdController)separator).allowReCacheOnFail;
		if (_identifier != null)
		{
			string currentProviderIDForLocation = ((AdSystemEventLogger)this).GetCurrentProviderIDForLocation(str);
			return (Range)(object)string.Format((IFormatProvider)(object)"{0}{1}", currentProviderIDForLocation, "Clicked");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		IEnumerable<_0021_00210> source = default;
		IOrderedEnumerable<_0021_00210> orderedEnumerable = (IOrderedEnumerable<_0021_00210>)Enumerable.OrderByDescending<TSource, TKey>((IEnumerable<TSource>)source, (Func<TSource, TKey>)(object)str);
		string currentProviderIDForLocation2 = ((AdSystemEventLogger)this).GetCurrentProviderIDForLocation(str);
		if (orderedEnumerable != null)
		{
			return (Range)(object)string.Format((IFormatProvider)(object)"{0}{1}", currentProviderIDForLocation2, "Closed");
		}
		return (Range)(object)string.Format((IFormatProvider)(object)"{0}{1}", currentProviderIDForLocation2, "NoClickInfo");
	}

	private static List<float> ParseFloatList(string str, char separator)
	{
		//IL_001c: Expected I4, but got Obj
		//IL_001c: Expected I4, but got Obj
		//IL_0020: Expected Obj, but got I4
		return (List<float>)"abtest_".IndexOf((char)(int)str, (int)"_", separator);
	}

	public bool HasDebugPayload()
	{
		//IL_0007: Expected I4, but got Obj
		return (byte)(int)payload__BackingField != 0;
	}

	public unsafe string GetDebugPayload()
	{
		//IL_0015: Expected I4, but got Obj
		//IL_0026: Expected Obj, but got I4
		string text = string.ConcatArray((string[])(object)"debug_payload_", (int)_identifier);
		return (string)((LODParameters*)text)->GetHashCode();
	}

	public unsafe void EnableDebugPayload(string value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Expected Obj, but got Unknown
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected Obj, but got Unknown
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected Obj, but got Unknown
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1132: Expected Obj, but got Unknown
		//IL_113b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected Obj, but got Unknown
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_114e: Expected Obj, but got Unknown
		//IL_1157: Expected Obj, but got I4
		//IL_1160: Unknown result type (might be due to invalid IL or missing references)
		//IL_1165: Expected Obj, but got Unknown
		//IL_116e: Expected Obj, but got I4
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Expected Obj, but got Unknown
		//IL_1185: Expected Obj, but got I4
		//IL_1194: Unknown result type (might be due to invalid IL or missing references)
		//IL_1199: Expected Obj, but got Unknown
		//IL_0059: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I
		//IL_11e5: Expected I, but got Obj
		//IL_11fb: Expected Obj, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got I4
		//IL_1228: Expected I4, but got Obj
		//IL_009a: Expected I, but got Obj
		//IL_00e7: Expected I, but got Obj
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_1285: Expected I, but got Obj
		//IL_129b: Expected Obj, but got I
		//IL_12c8: Expected I4, but got Obj
		//IL_12de: Expected I4, but got Obj
		//IL_017f: Expected I, but got Obj
		//IL_01cc: Expected I, but got Obj
		//IL_1c44: Expected I, but got Obj
		//IL_1c5a: Expected Obj, but got I
		//IL_1336: Expected I, but got Obj
		//IL_134c: Expected Obj, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_1379: Expected I4, but got Obj
		//IL_025b: Expected I, but got Obj
		//IL_02a8: Expected I, but got Obj
		//IL_02f5: Expected I, but got Obj
		//IL_030b: Expected Obj, but got I
		//IL_13c9: Expected I, but got Obj
		//IL_13df: Expected Obj, but got I
		//IL_140c: Expected I4, but got Obj
		//IL_1422: Expected I4, but got Obj
		//IL_0336: Expected I, but got Obj
		//IL_0383: Expected I, but got Obj
		//IL_1c85: Expected I, but got Obj
		//IL_1c9b: Expected Obj, but got I
		//IL_15ac: Expected I, but got Obj
		//IL_15c2: Expected Obj, but got I
		//IL_03fa: Expected I, but got Obj
		//IL_0410: Expected Obj, but got I
		//IL_15ef: Expected I4, but got Obj
		//IL_1605: Expected I4, but got Obj
		//IL_058c: Expected I, but got Obj
		//IL_147b: Expected I, but got Obj
		//IL_1491: Expected Obj, but got I
		//IL_05d9: Expected I, but got Obj
		//IL_14c4: Expected Obj, but got I4
		//IL_14c4: Expected Obj, but got I4
		//IL_043b: Expected I, but got Obj
		//IL_0488: Expected I, but got Obj
		//IL_16d6: Expected I, but got Obj
		//IL_16ec: Expected Obj, but got I
		//IL_04d5: Expected I, but got Obj
		//IL_04eb: Expected Obj, but got I
		//IL_17ce: Expected I, but got Obj
		//IL_17e4: Expected Obj, but got I
		//IL_0650: Expected I, but got Obj
		//IL_0666: Expected Obj, but got I
		//IL_14fd: Expected I, but got Obj
		//IL_1513: Expected Obj, but got I
		//IL_1811: Expected I4, but got Obj
		//IL_1827: Expected I4, but got Obj
		//IL_07ae: Expected I, but got Obj
		//IL_165d: Expected I, but got Obj
		//IL_1673: Expected Obj, but got I
		//IL_1538: Expected Obj, but got VT
		//IL_155d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1562: Expected Obj, but got Unknown
		//IL_156f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Expected Obj, but got Unknown
		//IL_0516: Expected I, but got Obj
		//IL_07e1: Expected I, but got Obj
		//IL_16a6: Expected Obj, but got I4
		//IL_16a6: Expected Obj, but got I4
		//IL_0691: Expected I, but got Obj
		//IL_0549: Expected I, but got Obj
		//IL_06c4: Expected I, but got Obj
		//IL_06f7: Expected I, but got Obj
		//IL_070d: Expected Obj, but got I
		//IL_0848: Expected Obj, but got I4
		//IL_0851: Expected Obj, but got I4
		//IL_085e: Expected Obj, but got I4
		//IL_1720: Expected I, but got Obj
		//IL_1736: Expected Obj, but got I
		//IL_175b: Expected Obj, but got VT
		//IL_1780: Unknown result type (might be due to invalid IL or missing references)
		//IL_1785: Expected Obj, but got Unknown
		//IL_1792: Unknown result type (might be due to invalid IL or missing references)
		//IL_1797: Expected Obj, but got Unknown
		//IL_0738: Expected I, but got Obj
		//IL_076b: Expected I, but got Obj
		//IL_0ba6: Expected I, but got Obj
		//IL_0bbc: Expected Obj, but got I
		//IL_1959: Expected I, but got Obj
		//IL_196f: Expected Obj, but got I
		//IL_0965: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Expected Obj, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected Obj, but got Unknown
		//IL_09a4: Expected Obj, but got I4
		//IL_199c: Expected I4, but got Obj
		//IL_19b2: Expected I4, but got Obj
		//IL_19c4: Expected Obj, but got I4
		//IL_19c4: Expected Obj, but got I4
		//IL_0be7: Expected I, but got Obj
		//IL_0c1a: Expected I, but got Obj
		//IL_0c81: Expected I, but got Obj
		//IL_0c97: Expected Obj, but got I
		//IL_0a2c: Expected Obj, but got I
		//IL_19e4: Expected I, but got Obj
		//IL_19fa: Expected Obj, but got I
		//IL_0ac0: Expected Obj, but got I
		//IL_1a27: Expected I4, but got Obj
		//IL_1a3d: Expected I4, but got Obj
		//IL_1a4f: Expected Obj, but got I4
		//IL_1a4f: Expected Obj, but got I4
		//IL_0cc2: Expected I, but got Obj
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a67: Expected Obj, but got Unknown
		//IL_0cf5: Expected I, but got Obj
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Expected Obj, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected Obj, but got Unknown
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected Obj, but got Unknown
		//IL_0957: Expected Obj, but got I4
		//IL_0d5c: Expected I, but got Obj
		//IL_0d72: Expected Obj, but got I
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected Obj, but got Unknown
		//IL_1a94: Expected Obj, but got I
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected Obj, but got Unknown
		//IL_0d9d: Expected I, but got Obj
		//IL_0dd2: Expected Obj, but got I
		//IL_0de4: Expected Obj, but got I4
		//IL_0e1e: Expected Obj, but got I4
		//IL_0e2f: Expected Obj, but got I4
		//IL_0eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Expected Obj, but got Unknown
		//IL_0ec4: Expected Obj, but got I4
		//IL_0ed2: Expected I, but got Obj
		//IL_0ee8: Expected Obj, but got I
		//IL_1ae0: Expected I, but got Obj
		//IL_1af6: Expected Obj, but got I
		//IL_1b23: Expected I4, but got Obj
		//IL_1b39: Expected I4, but got Obj
		//IL_0f13: Expected I, but got Obj
		//IL_0f46: Expected I, but got Obj
		//IL_1044: Expected I, but got Obj
		//IL_105a: Expected Obj, but got I
		//IL_0fad: Expected Obj, but got I4
		//IL_0fb6: Expected Obj, but got I4
		//IL_0fc3: Expected Obj, but got I4
		//IL_1bbb: Expected I, but got Obj
		//IL_1bd1: Expected Obj, but got I
		//IL_1bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf9: Expected Obj, but got Unknown
		//IL_1c09: Expected I4, but got Obj
		//IL_1c20: Expected I4, but got Obj
		//IL_1c2d: Expected Obj, but got I4
		//IL_1085: Expected I, but got Obj
		//IL_10b8: Expected I, but got Obj
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_1008: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 56;
		object obj4 = obj2 + 48;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 16;
		object obj7 = obj2 + 8;
		CultureInfo cultureInfo = (CultureInfo)(obj2 + 40);
		cultureInfo = (CultureInfo)0;
		CultureInfo cultureInfo2 = (CultureInfo)(obj2 + 32);
		cultureInfo2 = (CultureInfo)0;
		object obj8 = obj2 + 80;
		obj8 = 0;
		_ = 0;
		object obj9 = obj2 + 72;
		obj9 = obj;
		_ = -1;
		string debugPayload = GetDebugPayload();
		if (debugPayload != null)
		{
			isActive__BackingField = true;
			object obj10 = this + 36;
			bool flag = ABTestManager.IsActive((string)(object)this);
			obj10 = flag;
			_version = -1;
			return;
		}
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v512 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		nint num3 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S2_v3 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num4 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S2_v116 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<float> key = ParseFloatList(_identifier, (char)(int)"version");
		uint value2 = ((OnlineSettings)(object)saveDataPath).GetValue((string)(object)key, 0u);
		if (value2 == (uint)_version)
		{
			return;
		}
		_version = (int)value2;
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v46 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v508 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		nint num7 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S2_v11 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num8 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S2_v112 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<float> key2 = ParseFloatList(_identifier, (char)(int)"default_payload_override");
		bool value3 = ((OnlineSettings)(object)saveDataPath2).GetValue((string)(object)key2, (byte)(int)"" != 0);
		bool flag2;
		if (value3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v52 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (!flag2)
		{
			object obj15 = this + 40;
			obj15 = value3;
		}
		nint num9 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v57 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num10 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v498 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath3 = OnlineSettings.GetSaveDataPath();
		nint num11 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v66 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num12 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v494 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<float> key3 = ParseFloatList(_identifier, (char)(int)"active");
		bool flag3 = ((OnlineSettings)(object)saveDataPath3).TryGetValue((string)(object)key3, out *(string*)null);
		isActive__BackingField = flag3;
		if (~(isActive__BackingField ? 1u : 0u) != 0)
		{
			return;
		}
		nint num13 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v74 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num14 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v490 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath4 = OnlineSettings.GetSaveDataPath();
		nint num15 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S0_v83 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num16 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S0_v486 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<float> key4 = ParseFloatList(_identifier, (char)(int)"min_install_datetime");
		bool value4 = ((OnlineSettings)(object)saveDataPath4).GetValue((string)(object)key4, (byte)(int)"" != 0);
		bool flag4;
		if (value4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v88 (System.Boolean)+8]");
			flag4 = (nint)0 == 0;
		}
		else
		{
			flag4 = true;
		}
		if (!flag4)
		{
			nint num17 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S0_v432 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num18 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v478 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			nint num19 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S0_v439 (Il2CppClass<System.DateTime>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num20 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v474 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj22 = ((System.DefaultBinder)value4).ChangeType(currentCulture, (Type)7, cultureInfo);
			if (obj22 != null)
			{
				nint num21 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S0_v446 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num22 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S0_v471 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime lastTimeAVideoForKeysWasSeen = UserSave.lastTimeAVideoForKeysWasSeen;
				nint num23 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S0_v455 (Il2CppClass<System.DateTime>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num24 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S0_v468 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj5 = lastTimeAVideoForKeysWasSeen;
				obj6 = cultureInfo;
				obj4 = obj5;
				obj3 = obj6;
				object obj25 = obj4 & 0x3FFFFFFFFFFFFFFFL;
				object obj26 = obj3 & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26))
				{
					isActive__BackingField = false;
					return;
				}
			}
		}
		nint num25 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v93 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num26 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S0_v427 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath5 = OnlineSettings.GetSaveDataPath();
		nint num27 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v102 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num28 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v423 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<float> key5 = ParseFloatList(_identifier, (char)(int)"max_install_datetime");
		bool value5 = ((OnlineSettings)(object)saveDataPath5).GetValue((string)(object)key5, (byte)(int)"" != 0);
		bool flag5;
		if (value5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ S0_v107 (System.Boolean)+8]");
			flag5 = (nint)0 == 0;
		}
		else
		{
			flag5 = true;
		}
		if (!flag5)
		{
			nint num29 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S0_v370 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num30 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S0_v416 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CultureInfo currentCulture2 = CultureInfo.CurrentCulture;
			nint num31 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ S0_v377 (Il2CppClass<System.DateTime>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num32 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v413 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj31 = ((System.DefaultBinder)value5).ChangeType(currentCulture2, (Type)7, cultureInfo2);
			if (obj31 != null)
			{
				nint num33 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S0_v385 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num34 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ S0_v410 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime lastTimeAVideoForKeysWasSeen2 = UserSave.lastTimeAVideoForKeysWasSeen;
				nint num35 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S0_v394 (Il2CppClass<System.DateTime>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num36 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ S0_v407 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj7 = lastTimeAVideoForKeysWasSeen2;
				obj2 = cultureInfo2;
				obj4 = obj7;
				obj3 = obj2;
				object obj34 = obj4 & 0x3FFFFFFFFFFFFFFFL;
				object obj35 = obj3 & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj34) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj35))
				{
					isActive__BackingField = false;
					return;
				}
			}
		}
		nint num37 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S0_v112 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num38 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S0_v366 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath6 = OnlineSettings.GetSaveDataPath();
		nint num39 = (nint)typeof(ABTest);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S0_v121 (Il2CppClass<ABTest.ABTest>)+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			nint num40 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ S0_v363 (Il2CppClass<ABTest.ABTest>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<float> key6 = ParseFloatList(_identifier, (char)(int)"excluded_tags");
		bool value6 = ((OnlineSettings)(object)saveDataPath6).GetValue((string)(object)key6, (byte)(int)"" != 0);
		bool flag6;
		if (value6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v126 (System.Boolean)+8]");
			flag6 = (nint)0 == 0;
		}
		else
		{
			flag6 = true;
		}
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num41 = default;
			object obj38 = num41 + 16;
			obj38 = 59;
			string source = ((string)value6).Substring(num41);
			List<string> list = Enumerable.ToList((IEnumerable<string>)(object)source);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj39 = default;
			object obj40 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj39 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj40 != null)
					{
						isActive__BackingField = false;
						object obj41 = obj9 + 4;
						object obj42 = obj41 + 1;
						obj41 = obj42;
						object obj43 = obj42 << 2;
						object obj44 = obj9 + obj43;
						obj44 = 883;
						break;
					}
					continue;
				}
				object obj45 = obj9 + 4;
				object obj46 = obj45 + 1;
				obj45 = obj46;
				object obj47 = obj46 << 2;
				object obj48 = obj9 + obj47;
				obj48 = 460;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v29+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v29+4]");
				object obj49 = (nint)0 << 2;
				object obj50 = obj9 + obj49;
				if ((nint)obj50 == 883)
				{
					object obj51 = obj9 + 4;
					if ((nint)obj51 > -1)
					{
						object obj52 = obj51 + -1;
						obj51 = obj52;
					}
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v29+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v29+4]");
				object obj53 = (nint)0 << 2;
				object obj54 = obj9 + obj53;
				if ((nint)obj54 == 460)
				{
					object obj55 = obj9 + 4;
					if ((nint)obj55 > -1)
					{
						object obj56 = obj55 + -1;
						obj55 = obj56;
					}
					goto IL_1cb8;
				}
			}
			object obj57 = default;
			if (obj57 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_1cb8;
		IL_1cb8:
		IEnumerable<Range> analyticsSamplingKeyTestRanges = GetAnalyticsSamplingKeyTestRanges();
		if (analyticsSamplingKeyTestRanges != null && IsCheckForAnalyticsSamplingKeyRangeEnabled())
		{
			isActive__BackingField = false;
		}
		else if (!IsExcludedByAnalyticsSamplingKeyTestRanges() && !IsExcludedByExcludeAnalyticsSamplingKeyRange())
		{
			nint num42 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ S0_v141 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj58 = (nint)0 & (nint)0x200;
			if (obj58 != null)
			{
				nint num43 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ S0_v258 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath7 = OnlineSettings.GetSaveDataPath();
			nint num44 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ S2_v38 (Il2CppClass<ABTest.ABTest>)+BA]");
			object obj59 = (nint)0 & (nint)0x200;
			if (obj59 != null)
			{
				nint num45 = (nint)typeof(ABTest);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ S2_v78 (Il2CppClass<ABTest.ABTest>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<float> key7 = ParseFloatList(_identifier, (char)(int)"segment_offset");
			bool value7 = ((OnlineSettings)(object)saveDataPath7).GetValue((string)(object)key7, (byte)(int)"" != 0);
			bool flag7 = ((PokiUnitySDK._003C_003Ec__DisplayClass49_0)value7)._003CdisplayAd_003Eb__0((string)59);
			if (!flag7)
			{
				isActive__BackingField = false;
				return;
			}
			nint num46 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ S0_v151 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj60 = (nint)0 & (nint)0x200;
			if (obj60 != null)
			{
				nint num47 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ S0_v254 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath8 = OnlineSettings.GetSaveDataPath();
			nint num48 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ S2_v48 (Il2CppClass<ABTest.ABTest>)+BA]");
			object obj61 = (nint)0 & (nint)0x200;
			if (obj61 != null)
			{
				nint num49 = (nint)typeof(ABTest);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ S2_v75 (Il2CppClass<ABTest.ABTest>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<float> key8 = ParseFloatList(_identifier, (char)(int)"segment_size");
			bool value8 = ((OnlineSettings)(object)saveDataPath8).GetValue((string)(object)key8, (byte)(int)"" != 0);
			bool flag8 = ((PokiUnitySDK._003C_003Ec__DisplayClass49_0)value8)._003CdisplayAd_003Eb__0((string)59);
			if (!flag8)
			{
				isActive__BackingField = false;
				return;
			}
			nint num50 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v998 @ S1_v74 (Il2CppClass<System.Math>)+BA]");
			object obj62 = (nint)0 & (nint)0x200;
			if (obj62 != null)
			{
				nint num51 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ S1_v118 (Il2CppClass<System.Math>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ S0_v148 (System.Boolean)+C]");
			nint num52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ S0_v158 (System.Boolean)+C]");
			bool flag9 = num52 <= 0;
			bool flag10 = !flag9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ S0_v158 (System.Boolean)+C]");
			object obj63 = 0;
			if (!flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ S0_v148 (System.Boolean)+C]");
				obj63 = 0;
			}
			int num53 = 0;
			while (true)
			{
				if (num53 < (nint)obj63)
				{
					float num54 = ((List<float>)flag7).get_Item(num53);
					if (!(_sample > num54))
					{
						goto IL_0e66;
					}
					float num55 = ((List<float>)flag7).get_Item(num53);
					float num56 = ((List<float>)flag8).get_Item(num53);
					float num57 = num55 + num56;
					if (!(_sample < num57))
					{
						goto IL_0e66;
					}
					if (num53 > -1)
					{
						_segmentIndex = num53;
						object obj64 = this + 36;
						obj64 = 0;
						nint num58 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v187 (Il2CppClass<Info.OnlineSettings>)+BA]");
						object obj65 = (nint)0 & (nint)0x200;
						if (obj65 != null)
						{
							nint num59 = (nint)typeof(OnlineSettings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ S0_v249 (Il2CppClass<Info.OnlineSettings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						break;
					}
				}
				isActive__BackingField = false;
				return;
				IL_0e66:
				int num60 = num53 + 1;
				num53 = num60;
			}
			string saveDataPath9 = OnlineSettings.GetSaveDataPath();
			nint num61 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ S0_v196 (Il2CppClass<ABTest.ABTest>)+BA]");
			object obj66 = (nint)0 & (nint)0x200;
			if (obj66 != null)
			{
				nint num62 = (nint)typeof(ABTest);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ S0_v246 (Il2CppClass<ABTest.ABTest>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<float> key9 = ParseFloatList(_identifier, (char)(int)"segment_payload");
			bool value9 = ((OnlineSettings)(object)saveDataPath9).GetValue((string)(object)key9, (byte)(int)"" != 0);
			bool flag11;
			if (value9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ S0_v201 (System.Boolean)+8]");
				flag11 = (nint)0 == 0;
			}
			else
			{
				flag11 = true;
			}
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				int num63 = default;
				object obj67 = num63 + 16;
				obj67 = 59;
				string source2 = ((string)value9).Substring(num63);
				List<string> list2 = Enumerable.ToList((IEnumerable<string>)(object)source2);
				if (list2._size > num53)
				{
					object obj68 = this + 36;
					string text = list2.get_Item(num53);
					obj68 = text;
				}
			}
			if (payload__BackingField == null)
			{
				isActive__BackingField = false;
				return;
			}
			nint num64 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ S0_v209 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj69 = (nint)0 & (nint)0x200;
			if (obj69 != null)
			{
				nint num65 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ S0_v227 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath10 = OnlineSettings.GetSaveDataPath();
			nint num66 = (nint)typeof(ABTest);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ S0_v218 (Il2CppClass<ABTest.ABTest>)+BA]");
			object obj70 = (nint)0 & (nint)0x200;
			if (obj70 != null)
			{
				nint num67 = (nint)typeof(ABTest);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ S0_v224 (Il2CppClass<ABTest.ABTest>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj71 = this + 44;
			List<float> key10 = ParseFloatList(_identifier, (char)(int)"tag");
			bool value10 = ((OnlineSettings)(object)saveDataPath10).GetValue((string)(object)key10, (byte)(int)_identifier != 0);
			string text2 = string.Copy((string)value10);
			obj71 = text2;
		}
		else
		{
			isActive__BackingField = false;
		}
	}

	public void DisableDebugPayload()
	{
		//IL_09fc: Expected Obj, but got I
		//IL_0a0c: Expected Obj, but got I
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected Obj, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected Obj, but got Unknown
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected Obj, but got Unknown
		//IL_0a6d: Expected Obj, but got I
		//IL_0a7d: Expected Obj, but got I
		//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Expected Obj, but got Unknown
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Expected Obj, but got Unknown
		//IL_0ab9: Expected I, but got Obj
		//IL_0acf: Expected Obj, but got I
		//IL_0b02: Expected Obj, but got I
		//IL_0b12: Expected Obj, but got I
		//IL_0b22: Expected Obj, but got I
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Expected Obj, but got Unknown
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected Obj, but got Unknown
		//IL_0b5e: Expected Obj, but got I
		//IL_0b6e: Expected Obj, but got I
		//IL_0b7e: Expected Obj, but got I
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected Obj, but got Unknown
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected Obj, but got Unknown
		//IL_0bba: Expected Obj, but got I
		//IL_0bca: Expected Obj, but got I
		//IL_0bda: Expected Obj, but got I
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Expected Obj, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0c16: Expected Obj, but got I
		//IL_0c26: Expected Obj, but got I
		//IL_0c36: Expected Obj, but got I
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected Obj, but got Unknown
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected Obj, but got Unknown
		//IL_0c72: Expected Obj, but got I
		//IL_0c82: Expected Obj, but got I
		//IL_0c92: Expected Obj, but got I
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected Obj, but got Unknown
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected Obj, but got Unknown
		//IL_0cce: Expected Obj, but got I
		//IL_0cde: Expected Obj, but got I
		//IL_0cee: Expected Obj, but got I
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected Obj, but got Unknown
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Expected Obj, but got Unknown
		//IL_0d2a: Expected Obj, but got I
		//IL_0d3a: Expected Obj, but got I
		//IL_0d4a: Expected Obj, but got I
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected Obj, but got Unknown
		//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Expected Obj, but got Unknown
		//IL_0d86: Expected Obj, but got I
		//IL_0d96: Expected Obj, but got I
		//IL_0da6: Expected Obj, but got I
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Expected Obj, but got Unknown
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Expected Obj, but got Unknown
		//IL_0de2: Expected Obj, but got I
		//IL_0df2: Expected Obj, but got I
		//IL_0e02: Expected Obj, but got I
		//IL_0e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e10: Expected Obj, but got Unknown
		//IL_0e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Expected Obj, but got Unknown
		//IL_0e3e: Expected Obj, but got I
		//IL_0e4e: Expected Obj, but got I
		//IL_0e5e: Expected Obj, but got I
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected Obj, but got Unknown
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7a: Expected Obj, but got Unknown
		//IL_0e9a: Expected Obj, but got I
		//IL_0eaa: Expected Obj, but got I
		//IL_0eba: Expected Obj, but got I
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec8: Expected Obj, but got Unknown
		//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Expected Obj, but got Unknown
		//IL_0eee: Expected I, but got Obj
		//IL_0f04: Expected Obj, but got I
		//IL_0f1a: Expected Obj, but got I
		//IL_0f2a: Expected Obj, but got I
		//IL_0f3a: Expected Obj, but got I
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected Obj, but got Unknown
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Expected Obj, but got Unknown
		//IL_0f76: Expected Obj, but got I
		//IL_0f86: Expected Obj, but got I
		//IL_0f96: Expected Obj, but got I
		//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa4: Expected Obj, but got Unknown
		//IL_0fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Expected Obj, but got Unknown
		//IL_0fd2: Expected Obj, but got I
		//IL_0fe2: Expected Obj, but got I
		//IL_0ff2: Expected Obj, but got I
		//IL_0ffb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1000: Expected Obj, but got Unknown
		//IL_1009: Unknown result type (might be due to invalid IL or missing references)
		//IL_100e: Expected Obj, but got Unknown
		//IL_102e: Expected Obj, but got I
		//IL_103e: Expected Obj, but got I
		//IL_104e: Expected Obj, but got I
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Expected Obj, but got Unknown
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_106a: Expected Obj, but got Unknown
		//IL_108a: Expected Obj, but got I
		//IL_109a: Expected Obj, but got I
		//IL_10aa: Expected Obj, but got I
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Expected Obj, but got Unknown
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected Obj, but got Unknown
		//IL_10e6: Expected Obj, but got I
		//IL_10f6: Expected Obj, but got I
		//IL_1106: Expected Obj, but got I
		//IL_110f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected Obj, but got Unknown
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Expected Obj, but got Unknown
		//IL_1142: Expected Obj, but got I
		//IL_1152: Expected Obj, but got I
		//IL_1162: Expected Obj, but got I
		//IL_116b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Expected Obj, but got Unknown
		//IL_1179: Unknown result type (might be due to invalid IL or missing references)
		//IL_117e: Expected Obj, but got Unknown
		//IL_119e: Expected Obj, but got I
		//IL_11ae: Expected Obj, but got I
		//IL_11be: Expected Obj, but got I
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc: Expected Obj, but got Unknown
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11da: Expected Obj, but got Unknown
		//IL_11fa: Expected Obj, but got I
		//IL_120a: Expected Obj, but got I
		//IL_121a: Expected Obj, but got I
		//IL_1223: Unknown result type (might be due to invalid IL or missing references)
		//IL_1228: Expected Obj, but got Unknown
		//IL_1231: Unknown result type (might be due to invalid IL or missing references)
		//IL_1236: Expected Obj, but got Unknown
		//IL_1246: Unknown result type (might be due to invalid IL or missing references)
		//IL_124b: Expected Obj, but got Unknown
		//IL_1273: Expected Obj, but got I
		//IL_1283: Expected Obj, but got I
		//IL_1294: Unknown result type (might be due to invalid IL or missing references)
		//IL_1299: Expected Obj, but got Unknown
		//IL_12a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a7: Expected Obj, but got Unknown
		//IL_12b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bc: Expected Obj, but got Unknown
		//IL_12e4: Expected Obj, but got I
		//IL_12f4: Expected Obj, but got I
		//IL_1305: Unknown result type (might be due to invalid IL or missing references)
		//IL_130a: Expected Obj, but got Unknown
		//IL_1313: Unknown result type (might be due to invalid IL or missing references)
		//IL_1318: Expected Obj, but got Unknown
		//IL_1338: Expected Obj, but got I
		//IL_1348: Expected Obj, but got I
		//IL_1358: Expected Obj, but got I
		//IL_1361: Unknown result type (might be due to invalid IL or missing references)
		//IL_1366: Expected Obj, but got Unknown
		//IL_136f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1374: Expected Obj, but got Unknown
		//IL_1394: Expected Obj, but got I
		//IL_13a4: Expected Obj, but got I
		//IL_13b4: Expected Obj, but got I
		//IL_13bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c2: Expected Obj, but got Unknown
		//IL_13cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Expected Obj, but got Unknown
		//IL_13f0: Expected Obj, but got I
		//IL_1400: Expected Obj, but got I
		//IL_1410: Expected Obj, but got I
		//IL_1419: Unknown result type (might be due to invalid IL or missing references)
		//IL_141e: Expected Obj, but got Unknown
		//IL_1427: Unknown result type (might be due to invalid IL or missing references)
		//IL_142c: Expected Obj, but got Unknown
		//IL_144c: Expected Obj, but got I
		//IL_145c: Expected Obj, but got I
		//IL_146c: Expected Obj, but got I
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_147a: Expected Obj, but got Unknown
		//IL_1483: Unknown result type (might be due to invalid IL or missing references)
		//IL_1488: Expected Obj, but got Unknown
		//IL_14a8: Expected Obj, but got I
		//IL_14b8: Expected Obj, but got I
		//IL_14c8: Expected Obj, but got I
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d6: Expected Obj, but got Unknown
		//IL_14df: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e4: Expected Obj, but got Unknown
		//IL_1504: Expected Obj, but got I
		//IL_1514: Expected Obj, but got I
		//IL_1524: Expected Obj, but got I
		//IL_152d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1532: Expected Obj, but got Unknown
		//IL_153b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1540: Expected Obj, but got Unknown
		//IL_1560: Expected Obj, but got I
		//IL_1570: Expected Obj, but got I
		//IL_1580: Expected Obj, but got I
		//IL_1589: Unknown result type (might be due to invalid IL or missing references)
		//IL_158e: Expected Obj, but got Unknown
		//IL_1597: Unknown result type (might be due to invalid IL or missing references)
		//IL_159c: Expected Obj, but got Unknown
		//IL_15bc: Expected Obj, but got I
		//IL_15cc: Expected Obj, but got I
		//IL_15dc: Expected Obj, but got I
		//IL_15e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ea: Expected Obj, but got Unknown
		//IL_15f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f8: Expected Obj, but got Unknown
		//IL_1618: Expected Obj, but got I
		//IL_1628: Expected Obj, but got I
		//IL_1638: Expected Obj, but got I
		//IL_1641: Unknown result type (might be due to invalid IL or missing references)
		//IL_1646: Expected Obj, but got Unknown
		//IL_164f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1654: Expected Obj, but got Unknown
		//IL_1674: Expected Obj, but got I
		//IL_1684: Expected Obj, but got I
		//IL_1694: Expected Obj, but got I
		//IL_169d: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a2: Expected Obj, but got Unknown
		//IL_16ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b0: Expected Obj, but got Unknown
		//IL_16d0: Expected Obj, but got I
		//IL_16e0: Expected Obj, but got I
		//IL_16f0: Expected Obj, but got I
		//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fe: Expected Obj, but got Unknown
		//IL_1707: Unknown result type (might be due to invalid IL or missing references)
		//IL_170c: Expected Obj, but got Unknown
		//IL_172c: Expected Obj, but got I
		//IL_173c: Expected Obj, but got I
		//IL_174c: Expected Obj, but got I
		//IL_1755: Unknown result type (might be due to invalid IL or missing references)
		//IL_175a: Expected Obj, but got Unknown
		//IL_1763: Unknown result type (might be due to invalid IL or missing references)
		//IL_1768: Expected Obj, but got Unknown
		//IL_1788: Expected Obj, but got I
		//IL_1798: Expected Obj, but got I
		//IL_17a8: Expected Obj, but got I
		//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b6: Expected Obj, but got Unknown
		//IL_17bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c4: Expected Obj, but got Unknown
		//IL_17e4: Expected Obj, but got I
		//IL_17f4: Expected Obj, but got I
		//IL_1804: Expected Obj, but got I
		//IL_180d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1812: Expected Obj, but got Unknown
		//IL_181b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1820: Expected Obj, but got Unknown
		//IL_1838: Expected I, but got Obj
		//IL_184e: Expected Obj, but got I
		//IL_1864: Expected Obj, but got I
		//IL_1874: Expected Obj, but got I
		//IL_1884: Expected Obj, but got I
		//IL_188d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1892: Expected Obj, but got Unknown
		//IL_189b: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a0: Expected Obj, but got Unknown
		//IL_18c0: Expected Obj, but got I
		//IL_18d0: Expected Obj, but got I
		//IL_18e0: Expected Obj, but got I
		//IL_18e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ee: Expected Obj, but got Unknown
		//IL_18f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fc: Expected Obj, but got Unknown
		//IL_191c: Expected Obj, but got I
		//IL_192c: Expected Obj, but got I
		//IL_193c: Expected Obj, but got I
		//IL_1945: Unknown result type (might be due to invalid IL or missing references)
		//IL_194a: Expected Obj, but got Unknown
		//IL_1953: Unknown result type (might be due to invalid IL or missing references)
		//IL_1958: Expected Obj, but got Unknown
		//IL_1978: Expected Obj, but got I
		//IL_1988: Expected Obj, but got I
		//IL_1998: Expected Obj, but got I
		//IL_19a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a6: Expected Obj, but got Unknown
		//IL_19af: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b4: Expected Obj, but got Unknown
		//IL_19d4: Expected Obj, but got I
		//IL_19e4: Expected Obj, but got I
		//IL_19f4: Expected Obj, but got I
		//IL_19fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a02: Expected Obj, but got Unknown
		//IL_1a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a10: Expected Obj, but got Unknown
		//IL_1a30: Expected Obj, but got I
		//IL_1a40: Expected Obj, but got I
		//IL_1a50: Expected Obj, but got I
		//IL_1a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5e: Expected Obj, but got Unknown
		//IL_1a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6c: Expected Obj, but got Unknown
		//IL_1a8c: Expected Obj, but got I
		//IL_1a9c: Expected Obj, but got I
		//IL_1aac: Expected Obj, but got I
		//IL_1ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aba: Expected Obj, but got Unknown
		//IL_1ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac8: Expected Obj, but got Unknown
		//IL_1ae8: Expected Obj, but got I
		//IL_1af8: Expected Obj, but got I
		//IL_1b08: Expected Obj, but got I
		//IL_1b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b16: Expected Obj, but got Unknown
		//IL_1b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b24: Expected Obj, but got Unknown
		//IL_1b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b39: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_012d: Expected Obj, but got I
		//IL_013d: Expected Obj, but got I
		//IL_014d: Expected Obj, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01e5: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_0261: Expected Obj, but got I
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_029d: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I
		//IL_02bd: Expected Obj, but got I
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02f9: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_0355: Expected Obj, but got I
		//IL_0365: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03b1: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_040d: Expected Obj, but got I
		//IL_041d: Expected Obj, but got I
		//IL_042d: Expected Obj, but got I
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_0469: Expected Obj, but got I
		//IL_0479: Expected Obj, but got I
		//IL_0489: Expected Obj, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected Obj, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04c5: Expected Obj, but got I
		//IL_04d5: Expected Obj, but got I
		//IL_04e5: Expected Obj, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_0519: Expected I, but got Obj
		//IL_052f: Expected Obj, but got I
		//IL_0545: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I
		//IL_0565: Expected Obj, but got I
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_05a1: Expected Obj, but got I
		//IL_05b1: Expected Obj, but got I
		//IL_05c1: Expected Obj, but got I
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected Obj, but got Unknown
		//IL_05fd: Expected Obj, but got I
		//IL_060d: Expected Obj, but got I
		//IL_061d: Expected Obj, but got I
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected Obj, but got Unknown
		//IL_0659: Expected Obj, but got I
		//IL_0669: Expected Obj, but got I
		//IL_0679: Expected Obj, but got I
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected Obj, but got Unknown
		//IL_06b5: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I
		//IL_06d5: Expected Obj, but got I
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected Obj, but got Unknown
		//IL_0711: Expected Obj, but got I
		//IL_0721: Expected Obj, but got I
		//IL_0731: Expected Obj, but got I
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected Obj, but got Unknown
		//IL_076d: Expected Obj, but got I
		//IL_077d: Expected Obj, but got I
		//IL_078d: Expected Obj, but got I
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected Obj, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected Obj, but got Unknown
		//IL_07c9: Expected Obj, but got I
		//IL_07d9: Expected Obj, but got I
		//IL_07e9: Expected Obj, but got I
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_0825: Expected Obj, but got I
		//IL_0835: Expected Obj, but got I
		//IL_0845: Expected Obj, but got I
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected Obj, but got Unknown
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected Obj, but got Unknown
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_08a3: Expected Obj, but got I
		//IL_08b3: Expected Obj, but got I
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got Unknown
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected Obj, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected Obj, but got Unknown
		//IL_0914: Expected Obj, but got I
		//IL_0924: Expected Obj, but got I
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got Unknown
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected Obj, but got Unknown
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected Obj, but got Unknown
		//IL_098a: Expected Obj, but got I
		//IL_099a: Expected Obj, but got I
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Obj, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected Obj, but got Unknown
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v8+60]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x1FFF;
		object obj12 = obj11 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S4_v8 (should have been resolved before IL gen)");
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v14 (Il2CppClass<AdLocations>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v179 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v10 (Il2CppMethodInfo)+C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v11+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v12+48]");
		object obj16 = 0;
		object obj17 = obj16 & 0x7FF;
		object obj18 = obj17 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S5_v8 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v15 (Il2CppMethodInfo)+C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v16+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v17+48]");
		object obj21 = 0;
		object obj22 = obj21 & 0x7FF;
		object obj23 = obj22 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S5_v12 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v20 (Il2CppMethodInfo)+C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S4_v21+60]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S4_v22+48]");
		object obj26 = 0;
		object obj27 = obj26 & 0x7FF;
		object obj28 = obj27 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v130 @ S5_v16 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S4_v25 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S4_v26+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v27+48]");
		object obj31 = 0;
		object obj32 = obj31 & 0x7FF;
		object obj33 = obj32 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v151 @ S5_v20 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v30 (Il2CppMethodInfo)+C]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v31+60]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S4_v32+48]");
		object obj36 = 0;
		object obj37 = obj36 & 0x7FF;
		object obj38 = obj37 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172 @ S5_v24 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S4_v35 (Il2CppMethodInfo)+C]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S4_v36+60]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S4_v37+48]");
		object obj41 = 0;
		object obj42 = obj41 & 0x7FF;
		object obj43 = obj42 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v193 @ S5_v28 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S4_v40 (Il2CppMethodInfo)+C]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S4_v41+60]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S4_v42+48]");
		object obj46 = 0;
		object obj47 = obj46 & 0x7FF;
		object obj48 = obj47 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v214 @ S5_v32 (should have been resolved before IL gen)");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S4_v45 (Il2CppMethodInfo)+C]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S4_v46+60]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S4_v47+48]");
		object obj51 = 0;
		object obj52 = obj51 & 0x7FF;
		object obj53 = obj52 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v235 @ S5_v36 (should have been resolved before IL gen)");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S4_v50 (Il2CppMethodInfo)+C]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S4_v51+60]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S4_v52+48]");
		object obj56 = 0;
		object obj57 = obj56 & 0x7FF;
		object obj58 = obj57 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v256 @ S5_v40 (should have been resolved before IL gen)");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S4_v55 (Il2CppMethodInfo)+C]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S4_v56+60]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S4_v57+48]");
		object obj61 = 0;
		object obj62 = obj61 & 0x7FF;
		object obj63 = obj62 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v277 @ S5_v44 (should have been resolved before IL gen)");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S4_v60 (Il2CppMethodInfo)+C]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S4_v61+60]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S4_v62+48]");
		object obj66 = 0;
		object obj67 = obj66 & 0x7FF;
		object obj68 = obj67 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v298 @ S5_v48 (should have been resolved before IL gen)");
		nint num16 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v51 (Il2CppClass<AdLocations>)+5C]");
		object obj69 = -(-64);
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S4_v65 (Il2CppMethodInfo)+C]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S4_v66+60]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S4_v67+48]");
		object obj72 = 0;
		object obj73 = obj72 & 0x7FF;
		object obj74 = obj73 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v321 @ S5_v52 (should have been resolved before IL gen)");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S4_v70 (Il2CppMethodInfo)+C]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S4_v71+60]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S4_v72+48]");
		object obj77 = 0;
		object obj78 = obj77 & 0x7FF;
		object obj79 = obj78 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v342 @ S5_v56 (should have been resolved before IL gen)");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S4_v75 (Il2CppMethodInfo)+C]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S4_v76+60]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S4_v77+48]");
		object obj82 = 0;
		object obj83 = obj82 & 0x7FF;
		object obj84 = obj83 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v363 @ S5_v60 (should have been resolved before IL gen)");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S4_v80 (Il2CppMethodInfo)+C]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S4_v81+60]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S4_v82+48]");
		object obj87 = 0;
		object obj88 = obj87 & 0x7FF;
		object obj89 = obj88 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v384 @ S5_v64 (should have been resolved before IL gen)");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S4_v85 (Il2CppMethodInfo)+C]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S4_v86+60]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S4_v87+48]");
		object obj92 = 0;
		object obj93 = obj92 & 0x7FF;
		object obj94 = obj93 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v405 @ S5_v68 (should have been resolved before IL gen)");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S4_v90 (Il2CppMethodInfo)+C]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S4_v91+60]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S4_v92+48]");
		object obj97 = 0;
		object obj98 = obj97 & 0x7FF;
		object obj99 = obj98 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v426 @ S5_v72 (should have been resolved before IL gen)");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S4_v95 (Il2CppMethodInfo)+C]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S4_v96+60]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S4_v97+48]");
		object obj102 = 0;
		object obj103 = obj102 & 0x7FF;
		object obj104 = obj103 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v447 @ S5_v76 (should have been resolved before IL gen)");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S4_v100 (Il2CppMethodInfo)+C]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S4_v101+60]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S4_v102+48]");
		object obj107 = 0;
		object obj108 = obj107 & 0x7FF;
		object obj109 = obj108 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v468 @ S5_v80 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S4_v105 (Il2CppMethodInfo)+C]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S4_v106+60]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S4_v107+48]");
		object obj112 = 0;
		object obj113 = obj112 & 0x7FF;
		object obj114 = obj113 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v489 @ S5_v84 (should have been resolved before IL gen)");
		object obj115 = this + 12;
		object obj116 = default;
		obj115 = obj116;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S3_v32 (Il2CppMethodInfo)+C]");
		object obj117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S3_v33+60]");
		object obj118 = 0;
		object obj119 = obj118;
		object obj120 = obj119 & 0x1FFF;
		object obj121 = obj120 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v513 @ S4_v112 (should have been resolved before IL gen)");
		object obj122 = this + 16;
		object obj123 = default;
		obj122 = obj123;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S3_v37 (Il2CppMethodInfo)+C]");
		object obj124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ S3_v38+60]");
		object obj125 = 0;
		object obj126 = obj125;
		object obj127 = obj126 & 0x1FFF;
		object obj128 = obj127 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v537 @ S4_v116 (should have been resolved before IL gen)");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S4_v118 (Il2CppMethodInfo)+C]");
		object obj129 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S4_v119+60]");
		object obj130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S4_v120+48]");
		object obj131 = 0;
		object obj132 = obj131 & 0x7FF;
		object obj133 = obj132 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v558 @ S5_v92 (should have been resolved before IL gen)");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S4_v123 (Il2CppMethodInfo)+C]");
		object obj134 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S4_v124+60]");
		object obj135 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S4_v125+48]");
		object obj136 = 0;
		object obj137 = obj136 & 0x7FF;
		object obj138 = obj137 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v579 @ S5_v96 (should have been resolved before IL gen)");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S4_v128 (Il2CppMethodInfo)+C]");
		object obj139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S4_v129+60]");
		object obj140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S4_v130+48]");
		object obj141 = 0;
		object obj142 = obj141 & 0x7FF;
		object obj143 = obj142 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v600 @ S5_v100 (should have been resolved before IL gen)");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S4_v133 (Il2CppMethodInfo)+C]");
		object obj144 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S4_v134+60]");
		object obj145 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S4_v135+48]");
		object obj146 = 0;
		object obj147 = obj146 & 0x7FF;
		object obj148 = obj147 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v621 @ S5_v104 (should have been resolved before IL gen)");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S4_v138 (Il2CppMethodInfo)+C]");
		object obj149 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S4_v139+60]");
		object obj150 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S4_v140+48]");
		object obj151 = 0;
		object obj152 = obj151 & 0x7FF;
		object obj153 = obj152 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v642 @ S5_v108 (should have been resolved before IL gen)");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S4_v143 (Il2CppMethodInfo)+C]");
		object obj154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S4_v144+60]");
		object obj155 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ S4_v145+48]");
		object obj156 = 0;
		object obj157 = obj156 & 0x7FF;
		object obj158 = obj157 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v663 @ S5_v112 (should have been resolved before IL gen)");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S4_v148 (Il2CppMethodInfo)+C]");
		object obj159 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S4_v149+60]");
		object obj160 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S4_v150+48]");
		object obj161 = 0;
		object obj162 = obj161 & 0x7FF;
		object obj163 = obj162 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v684 @ S5_v116 (should have been resolved before IL gen)");
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S4_v153 (Il2CppMethodInfo)+C]");
		object obj164 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S4_v154+60]");
		object obj165 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S4_v155+48]");
		object obj166 = 0;
		object obj167 = obj166 & 0x7FF;
		object obj168 = obj167 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v705 @ S5_v120 (should have been resolved before IL gen)");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ S4_v158 (Il2CppMethodInfo)+C]");
		object obj169 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S4_v159+60]");
		object obj170 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ S4_v160+48]");
		object obj171 = 0;
		object obj172 = obj171 & 0x7FF;
		object obj173 = obj172 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v726 @ S5_v124 (should have been resolved before IL gen)");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S4_v163 (Il2CppMethodInfo)+C]");
		object obj174 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S4_v164+60]");
		object obj175 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ S4_v165+48]");
		object obj176 = 0;
		object obj177 = obj176 & 0x7FF;
		object obj178 = obj177 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v747 @ S5_v128 (should have been resolved before IL gen)");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S4_v168 (Il2CppMethodInfo)+C]");
		object obj179 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S4_v169+60]");
		object obj180 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S4_v170+48]");
		object obj181 = 0;
		object obj182 = obj181 & 0x7FF;
		object obj183 = obj182 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v768 @ S5_v132 (should have been resolved before IL gen)");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ S4_v173 (Il2CppMethodInfo)+C]");
		object obj184 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ S4_v174+60]");
		object obj185 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S4_v175+48]");
		object obj186 = 0;
		object obj187 = obj186 & 0x7FF;
		object obj188 = obj187 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v789 @ S5_v136 (should have been resolved before IL gen)");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ S4_v178 (Il2CppMethodInfo)+C]");
		object obj189 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ S4_v179+60]");
		object obj190 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ S4_v180+48]");
		object obj191 = 0;
		object obj192 = obj191 & 0x7FF;
		object obj193 = obj192 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v810 @ S5_v140 (should have been resolved before IL gen)");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S4_v183 (Il2CppMethodInfo)+C]");
		object obj194 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ S4_v184+60]");
		object obj195 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ S4_v185+48]");
		object obj196 = 0;
		object obj197 = obj196 & 0x7FF;
		object obj198 = obj197 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v831 @ S5_v144 (should have been resolved before IL gen)");
		nint num42 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ S1_v150 (Il2CppClass<AdLocations>)+5C]");
		object obj199 = -(-64);
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ S4_v188 (Il2CppMethodInfo)+C]");
		object obj200 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S4_v189+60]");
		object obj201 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S4_v190+48]");
		object obj202 = 0;
		object obj203 = obj202 & 0x7FF;
		object obj204 = obj203 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v854 @ S5_v148 (should have been resolved before IL gen)");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ S4_v193 (Il2CppMethodInfo)+C]");
		object obj205 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S4_v194+60]");
		object obj206 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ S4_v195+48]");
		object obj207 = 0;
		object obj208 = obj207 & 0x7FF;
		object obj209 = obj208 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v875 @ S5_v152 (should have been resolved before IL gen)");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S4_v198 (Il2CppMethodInfo)+C]");
		object obj210 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S4_v199+60]");
		object obj211 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ S4_v200+48]");
		object obj212 = 0;
		object obj213 = obj212 & 0x7FF;
		object obj214 = obj213 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v896 @ S5_v156 (should have been resolved before IL gen)");
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S4_v203 (Il2CppMethodInfo)+C]");
		object obj215 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ S4_v204+60]");
		object obj216 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ S4_v205+48]");
		object obj217 = 0;
		object obj218 = obj217 & 0x7FF;
		object obj219 = obj218 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v917 @ S5_v160 (should have been resolved before IL gen)");
		nint num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S4_v208 (Il2CppMethodInfo)+C]");
		object obj220 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ S4_v209+60]");
		object obj221 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ S4_v210+48]");
		object obj222 = 0;
		object obj223 = obj222 & 0x7FF;
		object obj224 = obj223 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v938 @ S5_v164 (should have been resolved before IL gen)");
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S4_v213 (Il2CppMethodInfo)+C]");
		object obj225 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ S4_v214+60]");
		object obj226 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ S4_v215+48]");
		object obj227 = 0;
		object obj228 = obj227 & 0x7FF;
		object obj229 = obj228 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v959 @ S5_v168 (should have been resolved before IL gen)");
		nint num49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ S4_v218 (Il2CppMethodInfo)+C]");
		object obj230 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ S4_v219+60]");
		object obj231 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ S4_v220+48]");
		object obj232 = 0;
		object obj233 = obj232 & 0x7FF;
		object obj234 = obj233 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v980 @ S5_v172 (should have been resolved before IL gen)");
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S4_v223 (Il2CppMethodInfo)+C]");
		object obj235 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ S4_v224+60]");
		object obj236 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ S4_v225+48]");
		object obj237 = 0;
		object obj238 = obj237 & 0x7FF;
		object obj239 = obj238 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1001 @ S5_v176 (should have been resolved before IL gen)");
		object obj240 = this + 20;
		object obj241 = default;
		obj240 = obj241;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ S3_v64 (Il2CppMethodInfo)+C]");
		object obj242 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ S3_v65+60]");
		object obj243 = 0;
		object obj244 = obj243;
		object obj245 = obj244 & 0x1FFF;
		object obj246 = obj245 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1024 @ S4_v230 (should have been resolved before IL gen)");
		object obj247 = this + 24;
		object obj248 = default;
		obj247 = obj248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ S3_v69 (Il2CppMethodInfo)+C]");
		object obj249 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ S3_v70+60]");
		object obj250 = 0;
		object obj251 = obj250;
		object obj252 = obj251 & 0x1FFF;
		object obj253 = obj252 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1047 @ S4_v234 (should have been resolved before IL gen)");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ S4_v236 (Il2CppMethodInfo)+C]");
		object obj254 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ S4_v237+60]");
		object obj255 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ S4_v238+48]");
		object obj256 = 0;
		object obj257 = obj256 & 0x7FF;
		object obj258 = obj257 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1068 @ S5_v184 (should have been resolved before IL gen)");
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ S4_v241 (Il2CppMethodInfo)+C]");
		object obj259 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ S4_v242+60]");
		object obj260 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ S4_v243+48]");
		object obj261 = 0;
		object obj262 = obj261 & 0x7FF;
		object obj263 = obj262 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1089 @ S5_v188 (should have been resolved before IL gen)");
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ S4_v246 (Il2CppMethodInfo)+C]");
		object obj264 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ S4_v247+60]");
		object obj265 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ S4_v248+48]");
		object obj266 = 0;
		object obj267 = obj266 & 0x7FF;
		object obj268 = obj267 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1110 @ S5_v192 (should have been resolved before IL gen)");
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ S4_v251 (Il2CppMethodInfo)+C]");
		object obj269 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ S4_v252+60]");
		object obj270 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ S4_v253+48]");
		object obj271 = 0;
		object obj272 = obj271 & 0x7FF;
		object obj273 = obj272 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1131 @ S5_v196 (should have been resolved before IL gen)");
		nint num57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ S4_v256 (Il2CppMethodInfo)+C]");
		object obj274 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1143 @ S4_v257+60]");
		object obj275 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1144 @ S4_v258+48]");
		object obj276 = 0;
		object obj277 = obj276 & 0x7FF;
		object obj278 = obj277 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1152 @ S5_v200 (should have been resolved before IL gen)");
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ S4_v261 (Il2CppMethodInfo)+C]");
		object obj279 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ S4_v262+60]");
		object obj280 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ S4_v263+48]");
		object obj281 = 0;
		object obj282 = obj281 & 0x7FF;
		object obj283 = obj282 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1173 @ S5_v204 (should have been resolved before IL gen)");
		nint num59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ S4_v266 (Il2CppMethodInfo)+C]");
		object obj284 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ S4_v267+60]");
		object obj285 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ S4_v268+48]");
		object obj286 = 0;
		object obj287 = obj286 & 0x7FF;
		object obj288 = obj287 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1194 @ S5_v208 (should have been resolved before IL gen)");
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ S4_v271 (Il2CppMethodInfo)+C]");
		object obj289 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ S4_v272+60]");
		object obj290 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ S4_v273+48]");
		object obj291 = 0;
		object obj292 = obj291 & 0x7FF;
		object obj293 = obj292 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1215 @ S5_v212 (should have been resolved before IL gen)");
		nint num61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ S4_v276 (Il2CppMethodInfo)+C]");
		object obj294 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ S4_v277+60]");
		object obj295 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1228 @ S4_v278+48]");
		object obj296 = 0;
		object obj297 = obj296 & 0x7FF;
		object obj298 = obj297 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1236 @ S5_v216 (should have been resolved before IL gen)");
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ S4_v281 (Il2CppMethodInfo)+C]");
		object obj299 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1248 @ S4_v282+60]");
		object obj300 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1249 @ S4_v283+48]");
		object obj301 = 0;
		object obj302 = obj301 & 0x7FF;
		object obj303 = obj302 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1257 @ S5_v220 (should have been resolved before IL gen)");
		nint num63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ S4_v286 (Il2CppMethodInfo)+C]");
		object obj304 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S4_v287+60]");
		object obj305 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ S4_v288+48]");
		object obj306 = 0;
		object obj307 = obj306 & 0x7FF;
		object obj308 = obj307 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1278 @ S5_v224 (should have been resolved before IL gen)");
		nint num64 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ S1_v233 (Il2CppClass<AdLocations>)+5C]");
		object obj309 = -(-64);
		nint num65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ S4_v291 (Il2CppMethodInfo)+C]");
		object obj310 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1292 @ S4_v292+60]");
		object obj311 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1293 @ S4_v293+48]");
		object obj312 = 0;
		object obj313 = obj312 & 0x7FF;
		object obj314 = obj313 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1301 @ S5_v228 (should have been resolved before IL gen)");
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ S4_v296 (Il2CppMethodInfo)+C]");
		object obj315 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ S4_v297+60]");
		object obj316 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1314 @ S4_v298+48]");
		object obj317 = 0;
		object obj318 = obj317 & 0x7FF;
		object obj319 = obj318 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1322 @ S5_v232 (should have been resolved before IL gen)");
		nint num67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1333 @ S4_v301 (Il2CppMethodInfo)+C]");
		object obj320 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1334 @ S4_v302+60]");
		object obj321 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ S4_v303+48]");
		object obj322 = 0;
		object obj323 = obj322 & 0x7FF;
		object obj324 = obj323 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1343 @ S5_v236 (should have been resolved before IL gen)");
		nint num68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ S4_v306 (Il2CppMethodInfo)+C]");
		object obj325 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ S4_v307+60]");
		object obj326 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ S4_v308+48]");
		object obj327 = 0;
		object obj328 = obj327 & 0x7FF;
		object obj329 = obj328 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1364 @ S5_v240 (should have been resolved before IL gen)");
		nint num69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1375 @ S4_v311 (Il2CppMethodInfo)+C]");
		object obj330 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ S4_v312+60]");
		object obj331 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1377 @ S4_v313+48]");
		object obj332 = 0;
		object obj333 = obj332 & 0x7FF;
		object obj334 = obj333 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1385 @ S5_v244 (should have been resolved before IL gen)");
		nint num70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ S4_v316 (Il2CppMethodInfo)+C]");
		object obj335 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ S4_v317+60]");
		object obj336 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ S4_v318+48]");
		object obj337 = 0;
		object obj338 = obj337 & 0x7FF;
		object obj339 = obj338 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1406 @ S5_v248 (should have been resolved before IL gen)");
		nint num71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ S4_v321 (Il2CppMethodInfo)+C]");
		object obj340 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1418 @ S4_v322+60]");
		object obj341 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ S4_v323+48]");
		object obj342 = 0;
		object obj343 = obj342 & 0x7FF;
		object obj344 = obj343 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1427 @ S5_v252 (should have been resolved before IL gen)");
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ S4_v326 (Il2CppMethodInfo)+C]");
		object obj345 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ S4_v327+60]");
		object obj346 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1440 @ S4_v328+48]");
		object obj347 = 0;
		object obj348 = obj347 & 0x7FF;
		object obj349 = obj348 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1448 @ S5_v256 (should have been resolved before IL gen)");
		nint num73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1459 @ S4_v331 (Il2CppMethodInfo)+C]");
		object obj350 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1460 @ S4_v332+60]");
		object obj351 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1461 @ S4_v333+48]");
		object obj352 = 0;
		object obj353 = obj352 & 0x7FF;
		object obj354 = obj353 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1469 @ S5_v260 (should have been resolved before IL gen)");
		object obj355 = this + 28;
		object obj356 = default;
		obj355 = obj356;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1482 @ S3_v94 (Il2CppMethodInfo)+C]");
		object obj357 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1483 @ S3_v95+60]");
		object obj358 = 0;
		object obj359 = obj358;
		object obj360 = obj359 & 0x1FFF;
		object obj361 = obj360 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1492 @ S4_v338 (should have been resolved before IL gen)");
		object obj362 = this + 32;
		object obj363 = default;
		obj362 = obj363;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1505 @ S3_v99 (Il2CppMethodInfo)+C]");
		object obj364 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ S3_v100+60]");
		object obj365 = 0;
		object obj366 = obj365;
		object obj367 = obj366 & 0x1FFF;
		object obj368 = obj367 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1515 @ S4_v342 (should have been resolved before IL gen)");
		object obj369 = this + 36;
		object obj370 = default;
		obj369 = obj370;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1528 @ S3_v104 (Il2CppMethodInfo)+C]");
		object obj371 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1529 @ S3_v105+60]");
		object obj372 = 0;
		object obj373 = obj372;
		object obj374 = obj373 & 0x1FFF;
		object obj375 = obj374 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1538 @ S4_v346 (should have been resolved before IL gen)");
		object obj376 = this + 40;
		object obj377 = default;
		obj376 = obj377;
	}

	private static void LogWarn(string msg, string identifier, UnityEngine.Object context = null)
	{
		msg.m_stringLength = 1;
	}

	private static void LogErr(string msg, string identifier, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, string identifier, UnityEngine.Object context = null)
	{
		//IL_001c: Expected I4, but got Obj
		//IL_001c: Expected I4, but got Obj
		//IL_001c: Expected I4, but got Obj
		//IL_002d: Expected Obj, but got I4
		int num = "[ABTest:".IndexOf((char)(int)identifier, (int)"] ", (int)msg);
		SDebug.LogFormat((string)num, (object[])(object)context);
	}

	static ABTest()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
