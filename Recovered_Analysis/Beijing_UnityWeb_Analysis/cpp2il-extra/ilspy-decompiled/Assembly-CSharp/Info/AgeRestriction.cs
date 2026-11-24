using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Data.Save.Internal;
using Kiloo.Analytics;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Components.Analytics;
using SYBO.Components.Utilities;
using SYBO.Subway.Info;
using SYBO.Subway.Level;
using SYBO.Subway.Level.Environments;
using UnityEngine;

namespace Info;

public static class AgeRestriction
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			MovingTrainUpdater._003C_003Ec obj = default;
			MovingTrainUpdater._003C_003Ec._003C_003E9 = obj;
		}

		internal void _003C_002Ecctor_003Eb__25_0(RefreshType type)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected Obj, but got Unknown
			//IL_0045: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<Transform> list = default;
			list._002Ector();
			object obj = this + 8;
			obj = list;
			_ = -1260f;
			object obj2 = this + 16;
			obj2 = type;
			((TransitionConfig.WeightRandomizedTransitionPrefabContainer)this)._002Ector();
		}
	}

	private const string ONLINESETTINGS_AGE_RESTRICTION_THRESHOLD_KEY = "age_restriction_threshold";

	private const string ONLINESETTINGS_AGE_RESTRICTION_VERSION_KEY = "age_restriction_version";

	private const string ONLINESETTINGS_AGE_RESTRICTION_GLOBAL_DEFAULT_KEY = "age_restriction_global_default";

	private const int AGE_RESTRICTION_GLOBAL_THRESHOLD_DEFAULT = 13;

	private const int AGE_RESTRICTION_VERSION_DEFAULT = 0;

	private static Action m_restrictionChanged;

	public static bool shouldSendAgeEvent;

	public static bool shouldSendConsentEvent;

	private static bool countryCodeRestricted__BackingField;

	private static bool _userAgeRegistered;

	private static readonly string CACHED_COUNTRY_CODE;

	private static readonly Dictionary<string, int> DEFAULT_COUNTRY_CODE_RESTRICTIONS;

	public static bool isRestricted
	{
		get
		{
			//IL_0144: Expected I, but got Obj
			//IL_015a: Expected Obj, but got I
			//IL_01c6: Expected I, but got Obj
			//IL_01dc: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01b8: Expected I4, but got Obj
			//IL_005b: Expected VT, but got Obj
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00f7: Expected I, but got Obj
			//IL_0180: Expected Obj, but got VT
			//IL_00aa: Expected I, but got Obj
			nint num = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v48 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(GamePositionRoot._instantiated ? 1u : 0u) != 0)
			{
				_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
				nint num3 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v33 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(GamePositionRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v42 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GamePositionRoot._instance = (GamePositionRoot)val;
				GamePositionRoot._instantiated = true;
			}
			nint num5 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v23 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)GamePositionRoot._instance != 0;
		}
	}

	public static bool waitForAgeRestriction
	{
		get
		{
			//IL_0198: Expected I, but got Obj
			//IL_01ae: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected I4, but got Unknown
			//IL_013d: Expected I, but got Obj
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8998");
			object obj2 = default;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v35 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (GetUserAge() != 0)
				{
					return true;
				}
				nint num5 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v30 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, string> lastShowedProviders = AdsSave.lastShowedProviders;
				return (byte)(lastShowedProviders ^ 1) != 0;
			}
			return false;
		}
	}

	public static bool shouldDisplayPopup
	{
		get
		{
			//IL_0234: Expected I, but got Obj
			//IL_024a: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_018a: Expected I, but got Obj
			//IL_01a0: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c1: Expected I4, but got Unknown
			//IL_01cb: Expected I, but got Obj
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v55 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8998");
			object obj2 = default;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v49 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(_userAgeRegistered ? 1u : 0u) == 0)
				{
					nint num5 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v25 (Il2CppClass<Info.AgeRestriction>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num6 = (nint)typeof(AgeRestriction);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v45 (Il2CppClass<Info.AgeRestriction>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (GetUserAge() != 0)
					{
						return false;
					}
					nint num7 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v33 (Il2CppClass<Info.AgeRestriction>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num8 = (nint)typeof(AgeRestriction);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40 (Il2CppClass<Info.AgeRestriction>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Dictionary<string, string> lastShowedProviders = AdsSave.lastShowedProviders;
					return (byte)(lastShowedProviders ^ 1) != 0;
				}
				return true;
			}
			return false;
		}
	}

	public static bool shouldShowBehaviouralAdsConsentPopup
	{
		get
		{
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8998");
			object obj2 = default;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v24 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool userAgeRegistered = _userAgeRegistered;
				return (byte)((userAgeRegistered ? 1u : 0u) ^ 1u) != 0;
			}
			return false;
		}
	}

	public static bool countryCodeRestricted
	{
		get
		{
			//IL_0198: Expected I, but got Obj
			//IL_01ae: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected I4, but got Unknown
			//IL_013d: Expected I, but got Obj
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v39 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8998");
			object obj2 = default;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v35 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (GetUserAge() != 0)
				{
					return false;
				}
				nint num5 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v30 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, string> lastShowedProviders = AdsSave.lastShowedProviders;
				return (byte)(lastShowedProviders ^ 1) != 0;
			}
			return false;
		}
		private set
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I4
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = AgeRestriction.m_restrictionChanged;
			Action action = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)AgeRestriction.m_restrictionChanged == obj2)
				{
					AgeRestriction.m_restrictionChanged = action;
				}
				if ((object)AgeRestriction.m_restrictionChanged != obj2)
				{
					obj2 = AgeRestriction.m_restrictionChanged;
					continue;
				}
				break;
			}
		}
	}

	public static event Action restrictionChanged
	{
		add
		{
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = AgeRestriction.m_restrictionChanged;
			Action action = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)AgeRestriction.m_restrictionChanged == obj2)
				{
					AgeRestriction.m_restrictionChanged = action;
				}
				if ((object)AgeRestriction.m_restrictionChanged != obj2)
				{
					obj2 = AgeRestriction.m_restrictionChanged;
					continue;
				}
				break;
			}
		}
	}

	static AgeRestriction()
	{
		//IL_100c: Expected Obj, but got I
		//IL_101c: Expected Obj, but got I
		//IL_102d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1032: Expected Obj, but got Unknown
		//IL_103b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Expected Obj, but got Unknown
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1062: Expected Obj, but got Unknown
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_1079: Expected Obj, but got Unknown
		//IL_10aa: Expected Obj, but got I
		//IL_10ba: Expected Obj, but got I
		//IL_10ca: Expected Obj, but got I
		//IL_10d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d8: Expected Obj, but got Unknown
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e6: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_0328: Expected Obj, but got I
		//IL_0338: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03df: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I
		//IL_03ff: Expected Obj, but got I
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_0491: Expected Obj, but got I
		//IL_04a1: Expected Obj, but got I
		//IL_04b1: Expected Obj, but got I
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_0548: Expected Obj, but got I
		//IL_0558: Expected Obj, but got I
		//IL_0568: Expected Obj, but got I
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected Obj, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected Obj, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected Obj, but got Unknown
		//IL_05fa: Expected Obj, but got I
		//IL_060a: Expected Obj, but got I
		//IL_061a: Expected Obj, but got I
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected Obj, but got Unknown
		//IL_06b1: Expected Obj, but got I
		//IL_06c1: Expected Obj, but got I
		//IL_06d1: Expected Obj, but got I
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_0763: Expected Obj, but got I
		//IL_0773: Expected Obj, but got I
		//IL_0783: Expected Obj, but got I
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Obj, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected Obj, but got Unknown
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected Obj, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected Obj, but got Unknown
		//IL_081a: Expected Obj, but got I
		//IL_082a: Expected Obj, but got I
		//IL_083a: Expected Obj, but got I
		//IL_0843: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected Obj, but got Unknown
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected Obj, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_08cc: Expected Obj, but got I
		//IL_08dc: Expected Obj, but got I
		//IL_08ec: Expected Obj, but got I
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected Obj, but got Unknown
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected Obj, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected Obj, but got Unknown
		//IL_0983: Expected Obj, but got I
		//IL_0993: Expected Obj, but got I
		//IL_09a3: Expected Obj, but got I
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got Unknown
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Expected Obj, but got Unknown
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected Obj, but got Unknown
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected Obj, but got Unknown
		//IL_0a35: Expected Obj, but got I
		//IL_0a45: Expected Obj, but got I
		//IL_0a55: Expected Obj, but got I
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected Obj, but got Unknown
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected Obj, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Expected Obj, but got Unknown
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected Obj, but got Unknown
		//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected Obj, but got Unknown
		//IL_0ae7: Expected Obj, but got I4
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Expected Obj, but got Unknown
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Expected Obj, but got Unknown
		//IL_0b39: Expected Obj, but got I4
		//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b56: Expected Obj, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected Obj, but got Unknown
		//IL_0b98: Expected Obj, but got I
		//IL_0ba8: Expected Obj, but got I
		//IL_0bb8: Expected Obj, but got I
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected Obj, but got Unknown
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected Obj, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected Obj, but got Unknown
		//IL_0c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Expected Obj, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3c: Expected Obj, but got Unknown
		//IL_0c45: Expected Obj, but got I4
		//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c62: Expected Obj, but got Unknown
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c85: Expected Obj, but got Unknown
		//IL_0c8e: Expected Obj, but got I4
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected Obj, but got Unknown
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc9: Expected Obj, but got Unknown
		//IL_0ce8: Expected Obj, but got I
		//IL_0cf8: Expected Obj, but got I
		//IL_0d08: Expected Obj, but got I
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Expected Obj, but got Unknown
		//IL_0d1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Expected Obj, but got Unknown
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Expected Obj, but got Unknown
		//IL_0d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Expected Obj, but got Unknown
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Expected Obj, but got Unknown
		//IL_0d9a: Expected Obj, but got I4
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected Obj, but got Unknown
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Expected Obj, but got Unknown
		//IL_0dde: Expected Obj, but got I4
		//IL_0e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e10: Expected Obj, but got Unknown
		//IL_0e2f: Expected Obj, but got I
		//IL_0e3f: Expected Obj, but got I
		//IL_0e4f: Expected Obj, but got I
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5d: Expected Obj, but got Unknown
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected Obj, but got Unknown
		//IL_0fcd: Expected I, but got Obj
		//IL_0fe3: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj7 = default;
		object obj6 = obj7 + 8;
		obj6 = "CHARACTERS_JAKE";
		object obj8 = obj7 + 12;
		obj8 = "slick";
		_ = 0;
		_ = 0;
		_ = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S4_v7+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v8+48]");
		object obj11 = 0;
		object obj12 = obj11 & 0x7FF;
		object obj13 = obj12 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj15 = default;
		object obj14 = obj15 + 8;
		obj14 = "CHARACTERS_TRICKY";
		object obj16 = obj15 + 12;
		obj16 = "tricky";
		_ = 1;
		object obj17 = obj15 + 24;
		obj17 = "CHARACTER_TOKEN_NAME_TRICKY";
		object obj18 = obj15 + 28;
		obj18 = "trophy_tricky_token";
		_ = 2;
		_ = 0;
		_ = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S4_v12+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S4_v13+48]");
		object obj21 = 0;
		object obj22 = obj21 & 0x7FF;
		object obj23 = obj22 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v118 @ S5_v10 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj25 = default;
		object obj24 = obj25 + 8;
		obj24 = "CHARACTERS_FRESH";
		object obj26 = obj25 + 12;
		obj26 = "fresh";
		object obj27 = obj25 + 24;
		obj27 = "CHARACTER_TOKEN_NAME_FRESH";
		object obj28 = obj25 + 28;
		obj28 = "trophy_fresh_token";
		_ = 1;
		_ = 50;
		_ = 0;
		_ = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S4_v17+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S4_v18+48]");
		object obj31 = 0;
		object obj32 = obj31 & 0x7FF;
		object obj33 = obj32 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v166 @ S5_v14 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj35 = default;
		object obj34 = obj35 + 8;
		obj34 = "CHARACTERS_SPIKE";
		object obj36 = obj35 + 12;
		obj36 = "spike";
		_ = 1;
		object obj37 = obj35 + 24;
		obj37 = "CHARACTER_TOKEN_NAME_SPIKE";
		object obj38 = obj35 + 28;
		obj38 = "trophy_spike_token";
		_ = 200;
		_ = 0;
		_ = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S4_v22+60]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S4_v23+48]");
		object obj41 = 0;
		object obj42 = obj41 & 0x7FF;
		object obj43 = obj42 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v214 @ S5_v18 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj45 = default;
		object obj44 = obj45 + 8;
		obj44 = "CHARACTERS_YUTANI";
		object obj46 = obj45 + 12;
		obj46 = "yutani";
		_ = 1;
		object obj47 = obj45 + 24;
		obj47 = "CHARACTER_TOKEN_NAME_YUTANI";
		object obj48 = obj45 + 28;
		obj48 = "trophy_yutani_token";
		_ = 500;
		_ = 54;
		_ = 0;
		_ = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S4_v27+60]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S4_v28+48]");
		object obj51 = 0;
		object obj52 = obj51 & 0x7FF;
		object obj53 = obj52 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v264 @ S5_v22 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj55 = default;
		object obj54 = obj55 + 8;
		obj54 = "CHARACTERS_LUCY";
		object obj56 = obj55 + 12;
		obj56 = "lucy";
		_ = 2;
		_ = 7000;
		_ = 44;
		_ = 0;
		_ = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S4_v32+60]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S4_v33+48]");
		object obj59 = 0;
		object obj60 = obj59 & 0x7FF;
		object obj61 = obj60 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v304 @ S5_v26 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj63 = default;
		object obj62 = obj63 + 8;
		obj62 = "CHARACTERS_NINJA";
		object obj64 = obj63 + 12;
		obj64 = "ninja";
		_ = 2;
		_ = 20000;
		_ = 45;
		_ = 0;
		_ = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S4_v37+60]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S4_v38+48]");
		object obj67 = 0;
		object obj68 = obj67 & 0x7FF;
		object obj69 = obj68 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v344 @ S5_v30 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj71 = default;
		object obj70 = obj71 + 8;
		obj70 = "CHARACTERS_FRANK";
		object obj72 = obj71 + 12;
		obj72 = "frank";
		_ = 2;
		_ = 40000;
		_ = 46;
		_ = 0;
		_ = 0;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S4_v42+60]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S4_v43+48]");
		object obj75 = 0;
		object obj76 = obj75 & 0x7FF;
		object obj77 = obj76 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v384 @ S5_v34 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj79 = default;
		object obj78 = obj79 + 8;
		obj78 = "CHARACTERS_KING";
		object obj80 = obj79 + 12;
		obj80 = "king";
		_ = 2;
		_ = 80000;
		_ = 43;
		_ = 0;
		_ = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S4_v47+60]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S4_v48+48]");
		object obj83 = 0;
		object obj84 = obj83 & 0x7FF;
		object obj85 = obj84 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v424 @ S5_v38 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj87 = default;
		object obj86 = obj87 + 8;
		obj86 = "CHARACTERS_FRIZZY";
		object obj88 = obj87 + 12;
		obj88 = "frizzy";
		_ = 2;
		_ = 150000;
		_ = 47;
		_ = 0;
		_ = 0;
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S4_v51 (Il2CppMethodInfo)+C]");
		object obj89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S4_v52+60]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S4_v53+48]");
		object obj91 = 0;
		object obj92 = obj91 & 0x7FF;
		object obj93 = obj92 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v464 @ S5_v42 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj95 = default;
		object obj94 = obj95 + 8;
		obj94 = "CHARACTERS_TAGBOT";
		object obj96 = obj95 + 12;
		obj96 = "tag";
		_ = 2;
		_ = 12000;
		_ = 49;
		_ = 0;
		_ = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S4_v56 (Il2CppMethodInfo)+C]");
		object obj97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S4_v57+60]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S4_v58+48]");
		object obj99 = 0;
		object obj100 = obj99 & 0x7FF;
		object obj101 = obj100 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v504 @ S5_v46 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj103 = default;
		object obj102 = obj103 + 8;
		obj102 = "CHARACTERS_TASHA";
		object obj104 = obj103 + 12;
		obj104 = "tasha";
		_ = 2;
		_ = 30000;
		_ = 50;
		_ = 0;
		_ = 0;
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S4_v61 (Il2CppMethodInfo)+C]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S4_v62+60]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S4_v63+48]");
		object obj107 = 0;
		object obj108 = obj107 & 0x7FF;
		object obj109 = obj108 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v544 @ S5_v50 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj111 = default;
		object obj110 = obj111 + 8;
		obj110 = "CHARACTERS_ZOE";
		object obj112 = obj111 + 12;
		obj112 = "zoe";
		_ = 2;
		_ = 120000;
		_ = 51;
		_ = 0;
		_ = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ S4_v66 (Il2CppMethodInfo)+C]");
		object obj113 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S4_v67+60]");
		object obj114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ S4_v68+48]");
		object obj115 = 0;
		object obj116 = obj115 & 0x7FF;
		object obj117 = obj116 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v584 @ S5_v54 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj119 = default;
		object obj118 = obj119 + 8;
		obj118 = "CHARACTERS_BRODY";
		object obj120 = obj119 + 12;
		obj120 = "brody";
		_ = 2;
		_ = 350000;
		_ = 52;
		_ = 0;
		_ = 0;
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ S4_v71 (Il2CppMethodInfo)+C]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ S4_v72+60]");
		object obj122 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ S4_v73+48]");
		object obj123 = 0;
		object obj124 = obj123 & 0x7FF;
		object obj125 = obj124 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v624 @ S5_v58 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj127 = default;
		object obj126 = obj127 + 8;
		obj126 = "CHARACTERS_PRINCE_K";
		object obj128 = obj127 + 12;
		obj128 = "princek";
		_ = 2;
		_ = 980000;
		_ = 53;
		_ = 0;
		_ = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S4_v76 (Il2CppMethodInfo)+C]");
		object obj129 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ S4_v77+60]");
		object obj130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S4_v78+48]");
		object obj131 = 0;
		object obj132 = obj131 & 0x7FF;
		object obj133 = obj132 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v664 @ S5_v62 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj135 = default;
		object obj134 = obj135 + 8;
		obj134 = "CHARACTERS_TONY";
		object obj136 = obj135 + 12;
		obj136 = "tony";
		_ = 2;
		_ = 95000;
		_ = 0;
		_ = 1;
		object obj138 = default;
		object obj137 = obj138 + 72;
		obj137 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj139 = obj138 + 88;
		obj139 = obj137;
		object obj140 = obj138 + 96;
		obj140 = obj139;
		object obj141 = obj138 + 56;
		obj141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj142 = obj138 + 80;
		obj142 = obj141;
		obj140 = obj142;
		object obj143 = obj135 + 36;
		obj143 = "UPDATE_SPECIAL_TAG_NEW_YORK";
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ S4_v83 (Il2CppMethodInfo)+C]");
		object obj144 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ S4_v84+60]");
		object obj145 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S4_v85+48]");
		object obj146 = 0;
		object obj147 = obj146 & 0x7FF;
		object obj148 = obj147 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v754 @ S5_v66 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj150 = default;
		object obj149 = obj150 + 8;
		obj149 = "CHARACTERS_SEOUL_CHARACTER01";
		object obj151 = obj150 + 12;
		obj151 = "seoulCharacter01";
		_ = 2;
		_ = 95000;
		_ = 0;
		_ = 1;
		object obj152 = obj138 + 48;
		obj152 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj153 = obj138 - -64;
		obj153 = obj152;
		obj140 = obj153;
		object obj154 = obj138 + 32;
		obj154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj155 = obj138 + 40;
		obj155 = obj154;
		obj140 = obj155;
		object obj156 = obj150 + 36;
		obj156 = "UPDATE_SPECIAL_TAG_SEOUL";
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ S4_v90 (Il2CppMethodInfo)+C]");
		object obj157 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ S4_v91+60]");
		object obj158 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ S4_v92+48]");
		object obj159 = 0;
		object obj160 = obj159 & 0x7FF;
		object obj161 = obj160 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v841 @ S5_v70 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj163 = default;
		object obj162 = obj163 + 8;
		obj162 = "CHARACTERS_AMSTERDAM_CHARACTER01";
		object obj164 = obj163 + 12;
		obj164 = "amsterdamCharacter01";
		_ = 2;
		_ = 95000;
		_ = 0;
		_ = 1;
		object obj165 = obj138 + 16;
		obj165 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj166 = obj138 + 24;
		obj166 = obj165;
		obj140 = obj166;
		object obj167 = obj138 + 8;
		obj167 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		obj138 = obj167;
		obj140 = obj138;
		object obj168 = obj163 + 36;
		obj168 = "UPDATE_SPECIAL_TAG_AMSTERDAM";
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ S4_v97 (Il2CppMethodInfo)+C]");
		object obj169 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ S4_v98+60]");
		object obj170 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ S4_v99+48]");
		object obj171 = 0;
		object obj172 = obj171 & 0x7FF;
		object obj173 = obj172 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v925 @ S5_v74 (should have been resolved before IL gen)");
		Dictionary<Characters.CharacterId, Characters.Model> characterData = default;
		Characters.characterData = characterData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Characters.CharacterId> list = default;
		list._002Ector();
		list.Add(Characters.CharacterId.yutani);
		list.Add(Characters.CharacterId.spike);
		list.Add(Characters.CharacterId.fresh);
		list.Add(Characters.CharacterId.tricky);
		list.Add(Characters.CharacterId.slick);
		list.Add(Characters.CharacterId.tony);
		list.Add(Characters.CharacterId.amsterdamCharacter01);
		list.Add(Characters.CharacterId.seoulCharacter01);
		list.Add(Characters.CharacterId.frank);
		list.Add(Characters.CharacterId.frizzy);
		list.Add(Characters.CharacterId.king);
		list.Add(Characters.CharacterId.lucy);
		list.Add(Characters.CharacterId.ninja);
		list.Add(Characters.CharacterId.tag);
		list.Add(Characters.CharacterId.tasha);
		list.Add(Characters.CharacterId.zoe);
		list.Add(Characters.CharacterId.brody);
		list.Add(Characters.CharacterId.princek);
		nint num20 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ S0_v326 (Il2CppClass<SYBO.Subway.Info.Characters>)+5C]");
		object obj174 = (nint)0 + (nint)4;
		obj174 = list;
	}

	private unsafe static void OnlineSettingsDownloaded()
	{
		//IL_0201: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02b1: Expected Obj, but got I
		//IL_02c1: Expected Obj, but got I
		//IL_02d1: Expected Obj, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_030d: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0369: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_03c5: Expected Obj, but got I
		//IL_03d5: Expected Obj, but got I
		//IL_03e5: Expected Obj, but got I
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I
		//IL_0441: Expected Obj, but got I
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_047d: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I
		//IL_049d: Expected Obj, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04d9: Expected Obj, but got I
		//IL_04e9: Expected Obj, but got I
		//IL_04f9: Expected Obj, but got I
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Obj, but got Unknown
		//IL_0535: Expected Obj, but got I
		//IL_0545: Expected Obj, but got I
		//IL_0555: Expected Obj, but got I
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_0591: Expected Obj, but got I
		//IL_05a1: Expected Obj, but got I
		//IL_05b1: Expected Obj, but got I
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_05ed: Expected Obj, but got I
		//IL_05fd: Expected Obj, but got I
		//IL_060d: Expected Obj, but got I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected Obj, but got Unknown
		//IL_0649: Expected Obj, but got I
		//IL_0659: Expected Obj, but got I
		//IL_0669: Expected Obj, but got I
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_06a5: Expected Obj, but got I
		//IL_06b5: Expected Obj, but got I
		//IL_06c5: Expected Obj, but got I
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected Obj, but got Unknown
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected Obj, but got Unknown
		//IL_0701: Expected Obj, but got I
		//IL_0711: Expected Obj, but got I
		//IL_0721: Expected Obj, but got I
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected Obj, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected Obj, but got Unknown
		//IL_075d: Expected Obj, but got I
		//IL_076d: Expected Obj, but got I
		//IL_077d: Expected Obj, but got I
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_07b9: Expected Obj, but got I
		//IL_07c9: Expected Obj, but got I
		//IL_07d9: Expected Obj, but got I
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got Unknown
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected Obj, but got Unknown
		//IL_0815: Expected Obj, but got I
		//IL_0825: Expected Obj, but got I
		//IL_0835: Expected Obj, but got I
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected Obj, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected Obj, but got Unknown
		//IL_0871: Expected Obj, but got I
		//IL_0881: Expected Obj, but got I
		//IL_0891: Expected Obj, but got I
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089f: Expected Obj, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected Obj, but got Unknown
		//IL_08cd: Expected Obj, but got I
		//IL_08dd: Expected Obj, but got I
		//IL_08ed: Expected Obj, but got I
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected Obj, but got Unknown
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Obj, but got Unknown
		//IL_0929: Expected Obj, but got I
		//IL_0939: Expected Obj, but got I
		//IL_0949: Expected Obj, but got I
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Expected Obj, but got Unknown
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Expected Obj, but got Unknown
		//IL_0985: Expected Obj, but got I
		//IL_0995: Expected Obj, but got I
		//IL_09a5: Expected Obj, but got I
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected Obj, but got Unknown
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected Obj, but got Unknown
		//IL_09e1: Expected Obj, but got I
		//IL_09f1: Expected Obj, but got I
		//IL_0a01: Expected Obj, but got I
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Expected Obj, but got Unknown
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected Obj, but got Unknown
		//IL_0a3d: Expected Obj, but got I
		//IL_0a4d: Expected Obj, but got I
		//IL_0a5d: Expected Obj, but got I
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Expected Obj, but got Unknown
		//IL_0a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Expected Obj, but got Unknown
		//IL_0a99: Expected Obj, but got I
		//IL_0aa9: Expected Obj, but got I
		//IL_0ab9: Expected Obj, but got I
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected Obj, but got Unknown
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected Obj, but got Unknown
		//IL_0af5: Expected Obj, but got I
		//IL_0b05: Expected Obj, but got I
		//IL_0b15: Expected Obj, but got I
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected Obj, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected Obj, but got Unknown
		//IL_0b51: Expected Obj, but got I
		//IL_0b61: Expected Obj, but got I
		//IL_0b71: Expected Obj, but got I
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected Obj, but got Unknown
		//IL_0bad: Expected Obj, but got I
		//IL_0bbd: Expected Obj, but got I
		//IL_0bcd: Expected Obj, but got I
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected Obj, but got Unknown
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be9: Expected Obj, but got Unknown
		//IL_0c09: Expected Obj, but got I
		//IL_0c19: Expected Obj, but got I
		//IL_0c29: Expected Obj, but got I
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected Obj, but got Unknown
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected Obj, but got Unknown
		//IL_0c65: Expected Obj, but got I
		//IL_0c75: Expected Obj, but got I
		//IL_0c85: Expected Obj, but got I
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected Obj, but got Unknown
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca1: Expected Obj, but got Unknown
		//IL_0cc1: Expected Obj, but got I
		//IL_0cd1: Expected Obj, but got I
		//IL_0ce1: Expected Obj, but got I
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected Obj, but got Unknown
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Expected Obj, but got Unknown
		//IL_0d1d: Expected Obj, but got I
		//IL_0d2d: Expected Obj, but got I
		//IL_0d3d: Expected Obj, but got I
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Expected Obj, but got Unknown
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Expected Obj, but got Unknown
		//IL_0d79: Expected Obj, but got I
		//IL_0d89: Expected Obj, but got I
		//IL_0d99: Expected Obj, but got I
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected Obj, but got Unknown
		//IL_0db0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Expected Obj, but got Unknown
		//IL_0dd5: Expected Obj, but got I
		//IL_0de5: Expected Obj, but got I
		//IL_0df5: Expected Obj, but got I
		//IL_0dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e03: Expected Obj, but got Unknown
		//IL_0e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Expected Obj, but got Unknown
		//IL_0e29: Expected I, but got Obj
		//IL_0e3f: Expected Obj, but got I
		//IL_0e55: Expected I, but got Obj
		//IL_0e6b: Expected Obj, but got I
		//IL_0e9f: Expected I, but got Obj
		//IL_0eb5: Expected Obj, but got I
		//IL_0eed: Expected I, but got Obj
		//IL_0f03: Expected Obj, but got I
		//IL_0f0b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected Obj, but got Unknown
		//IL_0f6f: Expected Obj, but got I4
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_0100: Expected I, but got Obj
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa7: Expected Obj, but got Unknown
		//IL_018e: Expected I, but got Obj
		shouldSendAgeEvent = true;
		shouldSendConsentEvent = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v72 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S4_v17+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v18+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S5_v14 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v22+60]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v23+48]");
		object obj23 = 0;
		object obj24 = obj23 & 0x7FF;
		object obj25 = obj24 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v108 @ S5_v18 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S4_v27+60]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S4_v28+48]");
		object obj28 = 0;
		object obj29 = obj28 & 0x7FF;
		object obj30 = obj29 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v126 @ S5_v22 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S4_v32+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S4_v33+48]");
		object obj33 = 0;
		object obj34 = obj33 & 0x7FF;
		object obj35 = obj34 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v144 @ S5_v26 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S4_v37+60]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S4_v38+48]");
		object obj38 = 0;
		object obj39 = obj38 & 0x7FF;
		object obj40 = obj39 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v162 @ S5_v30 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S4_v42+60]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S4_v43+48]");
		object obj43 = 0;
		object obj44 = obj43 & 0x7FF;
		object obj45 = obj44 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v180 @ S5_v34 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S4_v47+60]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S4_v48+48]");
		object obj48 = 0;
		object obj49 = obj48 & 0x7FF;
		object obj50 = obj49 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v198 @ S5_v38 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S4_v51 (Il2CppMethodInfo)+C]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S4_v52+60]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S4_v53+48]");
		object obj53 = 0;
		object obj54 = obj53 & 0x7FF;
		object obj55 = obj54 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v216 @ S5_v42 (should have been resolved before IL gen)");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S4_v56 (Il2CppMethodInfo)+C]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S4_v57+60]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S4_v58+48]");
		object obj58 = 0;
		object obj59 = obj58 & 0x7FF;
		object obj60 = obj59 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v234 @ S5_v46 (should have been resolved before IL gen)");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S4_v61 (Il2CppMethodInfo)+C]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S4_v62+60]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S4_v63+48]");
		object obj63 = 0;
		object obj64 = obj63 & 0x7FF;
		object obj65 = obj64 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v252 @ S5_v50 (should have been resolved before IL gen)");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S4_v66 (Il2CppMethodInfo)+C]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S4_v67+60]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S4_v68+48]");
		object obj68 = 0;
		object obj69 = obj68 & 0x7FF;
		object obj70 = obj69 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v270 @ S5_v54 (should have been resolved before IL gen)");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S4_v71 (Il2CppMethodInfo)+C]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S4_v72+60]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S4_v73+48]");
		object obj73 = 0;
		object obj74 = obj73 & 0x7FF;
		object obj75 = obj74 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v288 @ S5_v58 (should have been resolved before IL gen)");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S4_v76 (Il2CppMethodInfo)+C]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S4_v77+60]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S4_v78+48]");
		object obj78 = 0;
		object obj79 = obj78 & 0x7FF;
		object obj80 = obj79 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v306 @ S5_v62 (should have been resolved before IL gen)");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S4_v81 (Il2CppMethodInfo)+C]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S4_v82+60]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S4_v83+48]");
		object obj83 = 0;
		object obj84 = obj83 & 0x7FF;
		object obj85 = obj84 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v324 @ S5_v66 (should have been resolved before IL gen)");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S4_v86 (Il2CppMethodInfo)+C]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S4_v87+60]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S4_v88+48]");
		object obj88 = 0;
		object obj89 = obj88 & 0x7FF;
		object obj90 = obj89 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v342 @ S5_v70 (should have been resolved before IL gen)");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S4_v91 (Il2CppMethodInfo)+C]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S4_v92+60]");
		object obj92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S4_v93+48]");
		object obj93 = 0;
		object obj94 = obj93 & 0x7FF;
		object obj95 = obj94 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v360 @ S5_v74 (should have been resolved before IL gen)");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S4_v96 (Il2CppMethodInfo)+C]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S4_v97+60]");
		object obj97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S4_v98+48]");
		object obj98 = 0;
		object obj99 = obj98 & 0x7FF;
		object obj100 = obj99 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v378 @ S5_v78 (should have been resolved before IL gen)");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S4_v101 (Il2CppMethodInfo)+C]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S4_v102+60]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S4_v103+48]");
		object obj103 = 0;
		object obj104 = obj103 & 0x7FF;
		object obj105 = obj104 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v396 @ S5_v82 (should have been resolved before IL gen)");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S4_v106 (Il2CppMethodInfo)+C]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S4_v107+60]");
		object obj107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S4_v108+48]");
		object obj108 = 0;
		object obj109 = obj108 & 0x7FF;
		object obj110 = obj109 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v414 @ S5_v86 (should have been resolved before IL gen)");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S4_v111 (Il2CppMethodInfo)+C]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S4_v112+60]");
		object obj112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S4_v113+48]");
		object obj113 = 0;
		object obj114 = obj113 & 0x7FF;
		object obj115 = obj114 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v432 @ S5_v90 (should have been resolved before IL gen)");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S4_v116 (Il2CppMethodInfo)+C]");
		object obj116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S4_v117+60]");
		object obj117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S4_v118+48]");
		object obj118 = 0;
		object obj119 = obj118 & 0x7FF;
		object obj120 = obj119 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v450 @ S5_v94 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S4_v121 (Il2CppMethodInfo)+C]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S4_v122+60]");
		object obj122 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S4_v123+48]");
		object obj123 = 0;
		object obj124 = obj123 & 0x7FF;
		object obj125 = obj124 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v468 @ S5_v98 (should have been resolved before IL gen)");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S4_v126 (Il2CppMethodInfo)+C]");
		object obj126 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S4_v127+60]");
		object obj127 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S4_v128+48]");
		object obj128 = 0;
		object obj129 = obj128 & 0x7FF;
		object obj130 = obj129 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v486 @ S5_v102 (should have been resolved before IL gen)");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S4_v131 (Il2CppMethodInfo)+C]");
		object obj131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S4_v132+60]");
		object obj132 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S4_v133+48]");
		object obj133 = 0;
		object obj134 = obj133 & 0x7FF;
		object obj135 = obj134 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v504 @ S5_v106 (should have been resolved before IL gen)");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S4_v136 (Il2CppMethodInfo)+C]");
		object obj136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S4_v137+60]");
		object obj137 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S4_v138+48]");
		object obj138 = 0;
		object obj139 = obj138 & 0x7FF;
		object obj140 = obj139 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v522 @ S5_v110 (should have been resolved before IL gen)");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S4_v141 (Il2CppMethodInfo)+C]");
		object obj141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S4_v142+60]");
		object obj142 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S4_v143+48]");
		object obj143 = 0;
		object obj144 = obj143 & 0x7FF;
		object obj145 = obj144 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v540 @ S5_v114 (should have been resolved before IL gen)");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S4_v146 (Il2CppMethodInfo)+C]");
		object obj146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S4_v147+60]");
		object obj147 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S4_v148+48]");
		object obj148 = 0;
		object obj149 = obj148 & 0x7FF;
		object obj150 = obj149 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v558 @ S5_v118 (should have been resolved before IL gen)");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S4_v151 (Il2CppMethodInfo)+C]");
		object obj151 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ S4_v152+60]");
		object obj152 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S4_v153+48]");
		object obj153 = 0;
		object obj154 = obj153 & 0x7FF;
		object obj155 = obj154 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v576 @ S5_v122 (should have been resolved before IL gen)");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S4_v156 (Il2CppMethodInfo)+C]");
		object obj156 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S4_v157+60]");
		object obj157 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S4_v158+48]");
		object obj158 = 0;
		object obj159 = obj158 & 0x7FF;
		object obj160 = obj159 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v594 @ S5_v126 (should have been resolved before IL gen)");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ S4_v161 (Il2CppMethodInfo)+C]");
		object obj161 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S4_v162+60]");
		object obj162 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S4_v163+48]");
		object obj163 = 0;
		object obj164 = obj163 & 0x7FF;
		object obj165 = obj164 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v612 @ S5_v130 (should have been resolved before IL gen)");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ S4_v166 (Il2CppMethodInfo)+C]");
		object obj166 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S4_v167+60]");
		object obj167 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S4_v168+48]");
		object obj168 = 0;
		object obj169 = obj168 & 0x7FF;
		object obj170 = obj169 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v630 @ S5_v134 (should have been resolved before IL gen)");
		nint num35 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S0_v81 (Il2CppClass<Info.AgeRestriction>)+5C]");
		object obj171 = (nint)0 + (nint)12;
		object obj172 = default;
		obj171 = obj172;
		nint num36 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ S0_v85 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj173 = (nint)0 & (nint)0x200;
		if (obj173 != null)
		{
			nint num37 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ S0_v138 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
		nint num38 = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ S1_v75 (Il2CppClass<Utils>)+BA]");
		object obj174 = (nint)0 & (nint)0x200;
		if (obj174 != null)
		{
			nint num39 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S1_v101 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Utils.IsEnum((Type)(object)unfilteredLocale);
		nint num40 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ S0_v93 (Il2CppClass<Info.AgeRestriction>)+5C]");
		object obj175 = (nint)0 + (nint)8;
		obj175 = flag;
		bool flag2 = HasValidData();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @89AB");
		bool userAgeRegistered = IsConsentGiven();
		_userAgeRegistered = userAgeRegistered;
		nint num41 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S0_v104 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj176 = (nint)0 & (nint)0x200;
		if (obj176 != null)
		{
			nint num42 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S0_v134 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&OnlineSettingsDownloaded);
		object obj177 = action + 16;
		obj177 = 0;
		((OnlineSettings)(object)saveDataPath).RemoveOnFinishedDownloadingOnlineSettingsHandler(action);
		nint num43 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ S0_v111 (Il2CppClass<Info.AgeRestriction+<>c>)+BA]");
		object obj178 = (nint)0 & (nint)0x200;
		if (obj178 != null)
		{
			nint num44 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ S0_v128 (Il2CppClass<Info.AgeRestriction+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num45 = 0;
		_ = 0;
		Action<RefreshType> action2 = default;
		object obj179 = action2 + 16;
		obj179 = _003C_003Ec._003C_003E9;
		AppRefreshHandler.hasRefreshed -= action2;
	}

	private static bool IsCountryRestricted()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return countryCodeRestricted__BackingField;
	}

	private static bool HasValidData()
	{
		//IL_0334: Expected I, but got Obj
		//IL_034a: Expected Obj, but got I
		//IL_04ce: Expected I4, but got Obj
		//IL_04ce: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03b1: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0462: Expected I4, but got Obj
		//IL_0462: Expected I4, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_024b: Expected I, but got Obj
		//IL_0298: Expected I, but got Obj
		//IL_02ae: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_02d9: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v85 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath, (int)"age_restriction_threshold");
		if (outfitForCharacter != null)
		{
			nint num3 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v73 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v81 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			uint value = ((OnlineSettings)(object)saveDataPath2).GetValue("age_restriction_threshold", 0u);
			return (int)value > -1;
		}
		nint num5 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v15 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v66 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S2_v4 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v5+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v6+44]");
		object obj6 = 0;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S3_v5 (should have been resolved before IL gen)");
		object obj9 = default;
		if ((nint)obj9 > -1)
		{
			nint num8 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v51 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v60 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num10 = DEFAULT_COUNTRY_CODE_RESTRICTIONS.get_Item(CACHED_COUNTRY_CODE);
			return num10 > -1;
		}
		nint num11 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v25 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v46 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath3 = OnlineSettings.GetSaveDataPath();
		Outfit outfitForCharacter2 = Outfits.GetOutfitForCharacter((Characters.CharacterId)saveDataPath3, (int)"age_restriction_global_default");
		if (outfitForCharacter2 != null)
		{
			nint num13 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v34 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num14 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v42 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath4 = OnlineSettings.GetSaveDataPath();
			uint value2 = ((OnlineSettings)(object)saveDataPath4).GetValue("age_restriction_global_default", 0u);
			return (int)value2 > -1;
		}
		return true;
	}

	private static void LogBirthdayChanged()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HasValidData();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @89AB");
		bool userAgeRegistered = IsConsentGiven();
		_userAgeRegistered = userAgeRegistered;
	}

	private static bool IsConsentGiven()
	{
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_023e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int ageRestrictionInputYear = UserSave.ageRestrictionInputYear;
		bool flag = ageRestrictionInputYear > 0;
		bool cloudSaveEnabled = UserSave.cloudSaveEnabled;
		bool flag2 = (cloudSaveEnabled ? 1 : 0) > (false ? 1 : 0);
		object obj2 = flag & flag2;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v24 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int ageRestrictionInputMonth = UserSave.ageRestrictionInputMonth;
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v10 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v17 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			uint value = ((OnlineSettings)(object)saveDataPath).GetValue("age_restriction_version", 0u);
			return ageRestrictionInputMonth >= (int)value;
		}
		return false;
	}

	public static void RegisterConsent(bool given)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		countryCodeRestricted__BackingField = given;
	}

	private static bool IsAgeRestricted()
	{
		//IL_0009: Expected I4, but got Obj
		return (byte)(int)AdsSave.lastShowedProviders != 0;
	}

	public static int GetUserAge()
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_userAgeRegistered ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v23 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int ageThreshold = GetAgeThreshold();
			string[] allBoardNames = Boards.GetAllBoardNames();
			return (ageThreshold < (nint)allBoardNames) ? 1 : 0;
		}
		return 0;
	}

	private unsafe static int GetAgeThreshold()
	{
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_021c: Expected Obj, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Expected Obj, but got I4
		//IL_0241: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_0303: Expected I, but got Obj
		//IL_0319: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got VT
		//IL_0060: Expected I, but got Obj
		//IL_00cd: Expected I4, but got Obj
		//IL_00db: Expected Obj, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_02ab: Expected I, but got Obj
		//IL_02c1: Expected Obj, but got I
		//IL_01ab: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v68 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int ageRestrictionInputYear = UserSave.ageRestrictionInputYear;
		bool cloudSaveEnabled = UserSave.cloudSaveEnabled;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v64 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (cloudSaveEnabled ? ((DateTime*)1) : ((DateTime*)null))->Equals(ageRestrictionInputYear);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		DateTime defaultLocalFileTime = File.DefaultLocalFileTime;
		obj3 = defaultLocalFileTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
		object obj6 = default;
		object obj7 = default;
		int num5 = obj6 - obj7;
		object obj8 = -num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA8");
		object obj9 = obj2 + 8;
		obj9 = obj;
		object obj10 = default;
		obj2 = obj10;
		object obj11 = obj2 + 32;
		obj11 = obj9;
		object obj12 = obj2 + 40;
		obj12 = obj2;
		object obj13 = obj11 & 0x3FFFFFFFFFFFFFFFL;
		object obj14 = obj12 & 0x3FFFFFFFFFFFFFFFL;
		bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
		bool flag3 = !flag2;
		int num6 = num5;
		if (!flag3)
		{
			int num7 = num5 - 1;
			num6 = num7;
		}
		nint num8 = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v48 (Il2CppClass<System.Math>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num9 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v58 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (num6 < 0)
		{
			return 0;
		}
		return num6;
	}

	public static void RegisterUserBirthday(DateTime birthday)
	{
		LocalDebugData localDebug = DataManager<>.localDebug;
	}

	private static void FireRestrictionChangedEvent()
	{
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0203: Expected Obj, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_021a: Expected Obj, but got I4
		//IL_0228: Expected I, but got Obj
		//IL_023e: Expected Obj, but got I
		//IL_03a7: Expected Obj, but got VT
		//IL_03bf: Expected I, but got Obj
		//IL_03d5: Expected Obj, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0271: Expected Obj, but got VT
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v81 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime scheduledFirstInterstitialShowTime = AdsSave.scheduledFirstInterstitialShowTime;
		obj = scheduledFirstInterstitialShowTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v77 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 8;
		obj6 = scheduledFirstInterstitialShowTime;
		obj2 = obj3;
		object obj7 = obj2 + 32;
		obj7 = obj6;
		object obj8 = obj2 + 40;
		obj8 = obj2;
		object obj9 = obj7 & 0x3FFFFFFFFFFFFFFFL;
		object obj10 = obj8 & 0x3FFFFFFFFFFFFFFFL;
		if (obj9 == obj10)
		{
			return;
		}
		nint num5 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v40 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v73 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Tracker.CreateEvent(Kiloo.Analytics.EventType.PlayerBirthdayEntered, null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC8");
		object obj12 = default;
		bool flag = (nint)obj12 > 6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
		object obj13 = default;
		obj8 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	public static DateTime GetUserBirthday()
	{
		//IL_0068: Expected Obj, but got VT
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		DateTime dateTime = AnalyticsEvent.GetDeviceStartupTime();
		object obj = dateTime;
		nint num = (nint)typeof(AnalyticsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v10 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AnalyticsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime eventTime = AnalyticsEvent.GetEventTime();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9D");
		DateTime result = default;
		return result;
	}

	private static void Log(string msg)
	{
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_01f9: Expected I, but got Obj
		//IL_020f: Expected Obj, but got I
		//IL_018e: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = IsConsentGiven();
		nint num3 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v29 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue("age_restriction_version", 0u);
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v7 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UserSave.ageRestrictionInputMonth = (int)value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCC8");
		int ageRestrictionInputYear = default;
		UserSave.ageRestrictionInputYear = ageRestrictionInputYear;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @937F");
		_userAgeRegistered = true;
		FireRestrictionChangedEvent();
		Boards._002Ecctor();
	}
}
