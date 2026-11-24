using System;
using System.Collections.Generic;
using System.IO;
using ABTest;
using AdHandling.AdConstants;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Ads;
using Kiloo.Common.Extensions;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.Utility;
using UI.SlideIns;
using UnityEngine;

public class AdSystemManager : AdEventListenerAdapter
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__56_0;

		static _003C_003Ec()
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_0067: Expected I, but got Obj
			//IL_007d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			ABTestManager._tags = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S4_v4 (should have been resolved before IL gen)");
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v15 (Il2CppClass<ABTest.ABTestManager>)+5C]");
			object obj6 = (nint)0 + (nint)4;
			object obj7 = default;
			obj6 = obj7;
			ABTestManager._boostsScreen = 0u;
			ABTestManager._earnCoinsScreen = 0u;
			ABTestManager._storeScreen = 0u;
			ABTestManager._quickStorePopup = 0u;
		}

		internal void _003CInitialize_003Eb__56_0()
		{
		}
	}

	public const string LAST_SHOWED_PROVIDER_SAVED_SUFFIX = "_(saved)";

	private const string ONLINE_SETTINGS_ALLOW_RECACHE_DURING_RUN_KEY = "allow_recache_during_run";

	private bool _isInitialized;

	private bool _showAllowed;

	private AdController _adController;

	private AdLocationInfo _currentlyShowingAdAtLocation;

	private Dictionary<string, string> _lastShowedProviderPerLocation;

	private static Action m_onAdSystemInitialized;

	private static Action<string> m_onWillShowVideo;

	private static Action<string> m_onShowedVideo;

	private static Action<string> m_onFailedToShowVideo;

	private static Action<string> m_onDismissedVideo;

	private static Action<string, bool> m_onCachedVideo;

	private static Action<string> m_onFailedToCacheVideo;

	private static Action<string> m_onFinishedWatchingVideo;

	private Action _videoReward;

	private static Action<string> m_onWillShowInterstitial;

	private static Action<string> m_onCachedInterstitial;

	private static Action<string> m_onFailedToCacheInterstitial;

	private static Action<string> m_onShowedInterstitial;

	private static Action<string> m_onFailedToShowInterstitial;

	private static Action<string> m_onDismissedInterstitial;

	private static Action<string> m_onPriorityListWrapped;

	private static Action<string> m_onChangedProvider;

	private static AdSystemManager _instance;

	public unsafe static bool isInitialized
	{
		get
		{
			//IL_0609: Expected I, but got Obj
			//IL_061f: Expected Obj, but got I
			//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cb: Expected I, but got Unknown
			//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d9: Expected Obj, but got Unknown
			//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e7: Expected Obj, but got Unknown
			//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f5: Expected Obj, but got Unknown
			//IL_0707: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0657: Expected I, but got Obj
			//IL_0672: Expected I, but got Obj
			//IL_0688: Expected Obj, but got I
			//IL_06e0: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0209: Expected I, but got Obj
			//IL_021f: Expected Obj, but got I
			//IL_017b: Expected I, but got Obj
			//IL_0191: Expected Obj, but got I
			//IL_024a: Expected I, but got Obj
			//IL_0385: Expected I, but got Obj
			//IL_039b: Expected Obj, but got I
			//IL_01bc: Expected I, but got Obj
			//IL_0763: Expected I, but got Obj
			//IL_02b7: Expected I4, but got Obj
			//IL_02c9: Expected I, but got Obj
			//IL_02df: Expected Obj, but got I
			//IL_0412: Expected I4, but got Obj
			//IL_0420: Expected I, but got Obj
			//IL_0436: Expected Obj, but got I
			//IL_03c6: Expected I, but got Obj
			//IL_030a: Expected I, but got Obj
			//IL_0461: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v139 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 16);
			object obj3 = obj2 + 12;
			object obj4 = obj2 + 8;
			object obj5 = obj2 + 4;
			if (PokiUnitySDK._instance != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v35 (Il2CppClass<System.Type>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v135 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = typeof(PokiUnitySDK);
				((IntPtr*)num3)->m_value = (void*)(nint)obj3;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v109 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				PokiUnitySDK pokiUnitySDK = default;
				PokiUnitySDK._instance = pokiUnitySDK;
				obj4 = typeof(PokiUnitySDK);
				((IntPtr*)num3)->m_value = (void*)(nint)obj4;
				Type type2 = Type.internal_from_handle((IntPtr)num3);
				HideFlags hideFlags = ((UnityEngine.Object)(object)type2).hideFlags;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v51 (UnityEngine.HideFlags)+C]");
				if ((nint)0 >= (nint)2)
				{
					nint num8 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v125 (Il2CppClass<UnityEngine.Debug>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num9 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v131 (Il2CppClass<UnityEngine.Debug>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Debug.LogException((Exception)(object)"[Singleton] Something went really wrong  - there should never be more than 1 singleton! Reopening the scene might fix it.");
				}
				else
				{
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num11 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v103 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (PokiUnitySDK._instance != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Stream stream = default;
						UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
						PokiUnitySDK pokiUnitySDK2 = ((GameObject)(object)stream).AddComponent<PokiUnitySDK>();
						PokiUnitySDK._instance = pokiUnitySDK2;
						nint num12 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v71 (Il2CppClass<System.Type>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num13 = (nint)typeof(Type);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v111 (Il2CppClass<System.Type>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj5 = typeof(PokiUnitySDK);
						((IntPtr*)num3)->m_value = (void*)(nint)obj5;
						Type type3 = Type.internal_from_handle((IntPtr)num3);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						int totalLength = default;
						string text2 = string.ConcatArray((string[])(object)"(singleton) ", totalLength);
						UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)stream, (byte)(int)text2 != 0);
						nint num14 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v81 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num15 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((UnityEngine.UnitySynchronizationContext)(object)stream).Exec();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						throw new ArrayTypeMismatchException();
					}
					string tag = PokiUnitySDK._instance.tag;
					UnityEngine.Object obj12 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)tag);
					string message = string.ConcatArray((string[])(object)"[Singleton] Using instance already created: ", (int)obj12);
					nint num16 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v94 (Il2CppClass<UnityEngine.Debug>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num17 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v99 (Il2CppClass<UnityEngine.Debug>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Debug.LogError(message);
				}
			}
			return (byte)(int)PokiUnitySDK._instance != 0;
		}
	}

	public static AdSystemManager instance
	{
		get
		{
			//IL_0070: Expected I, but got Obj
			//IL_0086: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0053: Expected Obj, but got I4
			nint num = (nint)typeof(AdSystemManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AdSystemManager>)+5C]");
			object obj = -(-64);
			if (obj != null)
			{
				nint num2 = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v13 (Il2CppClass<AdSystemManager>)+5C]");
				object obj2 = -(-64);
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v16+8]");
				bool flag = (nint)0 != 0;
				return (AdSystemManager)flag;
			}
			return null;
		}
	}

	public static event Action onAdSystemInitialized
	{
		add
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			object obj = value + 24;
			obj = string.Empty;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
		remove
		{
			Delegate obj = AdSystemManager.m_onAdSystemInitialized;
			Action action = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)AdSystemManager.m_onAdSystemInitialized == obj)
				{
					AdSystemManager.m_onAdSystemInitialized = action;
				}
				if ((object)AdSystemManager.m_onAdSystemInitialized != obj)
				{
					obj = AdSystemManager.m_onAdSystemInitialized;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onWillShowVideo
	{
		add
		{
			Delegate obj = AdSystemManager.m_onAdSystemInitialized;
			Action action = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				if ((object)AdSystemManager.m_onAdSystemInitialized == obj)
				{
					AdSystemManager.m_onAdSystemInitialized = action;
				}
				if ((object)AdSystemManager.m_onAdSystemInitialized != obj)
				{
					obj = AdSystemManager.m_onAdSystemInitialized;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onWillShowVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onShowedVideo
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onWillShowVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onShowedVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onFailedToShowVideo
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onShowedVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFailedToShowVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onDismissedVideo
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFailedToShowVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onDismissedVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string, bool> onCachedVideo
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onDismissedVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)16;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onCachedVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onFailedToCacheVideo
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onCachedVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFailedToCacheVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onFinishedWatchingVideo
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFailedToCacheVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFinishedWatchingVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)28;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onWillShowInterstitial
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFinishedWatchingVideo;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)28;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onWillShowInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)32;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onCachedInterstitial
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onWillShowInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)32;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onCachedInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)36;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onFailedToCacheInterstitial
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onCachedInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)36;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFailedToCacheInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onShowedInterstitial
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFailedToCacheInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)40;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onShowedInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)44;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onFailedToShowInterstitial
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onShowedInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)44;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFailedToShowInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)48;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onDismissedInterstitial
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onFailedToShowInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)48;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onDismissedInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)52;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onPriorityListWrapped
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onDismissedInterstitial;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)52;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onPriorityListWrapped;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)56;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> onChangedProvider
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onPriorityListWrapped;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)56;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdSystemManager.m_onChangedProvider;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdSystemManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
				object obj3 = (nint)0 + (nint)60;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private void Initialize()
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		Delegate obj = AdSystemManager.m_onChangedProvider;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num = (nint)typeof(AdSystemManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdSystemManager>)+5C]");
			object obj3 = (nint)0 + (nint)60;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private void AppHasRefreshed(RefreshType refreshType)
	{
		//IL_001c: Expected Obj, but got I
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_00c5: Expected I4, but got Obj
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected I4, but got Unknown
		AdLocationInfo currentlyShowingAdAtLocation = _currentlyShowingAdAtLocation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S1_v2 (Kiloo.Common.Ads.AdLocationInfo)+64]");
		_lastShowedProviderPerLocation = (Dictionary<string, string>)0;
		AdController adController = _adController;
		Dictionary<string, string> lastShowedProviderPerLocation = _lastShowedProviderPerLocation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v5 (Kiloo.Common.Ads.AdController)+64]");
		object obj = lastShowedProviderPerLocation - 0;
		OfferWallManager offerWallManager = OfferWallManager.instance;
		bool availabilityForLocation = ((AdSystemManager)(object)offerWallManager).GetAvailabilityForLocation((string)refreshType);
		bool flag;
		if (availabilityForLocation)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v7 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			string text = ((string)availabilityForLocation).InternalSubString(0, 2);
			((UILabel)(object)_adController).fontSize = (int)text;
			AdController adController2 = _adController;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v6 (Kiloo.Common.Ads.AdController)+64]");
			int height = obj + 0;
			((UIWidget)(object)_currentlyShowingAdAtLocation).height = height;
		}
	}

	private void OnOnlineSettingsDownloadResult(bool b)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005a: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = b;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			object obj4 = _adController + 40;
			int currentIntroVideoAdPrizeIndex = AdsSave.currentIntroVideoAdPrizeIndex;
			obj4 = currentIntroVideoAdPrizeIndex;
		}
	}

	private unsafe void UpdateCacheIdsFromOnlineSettings()
	{
		//IL_04ea: Expected I, but got Obj
		//IL_0500: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0126: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_0554: Expected Obj, but got I4
		//IL_0554: Expected I4, but got Obj
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_0167: Expected I, but got Obj
		//IL_00c1: Expected I, but got Obj
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Obj, but got Unknown
		//IL_028c: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I
		//IL_0570: Expected I, but got Obj
		//IL_0586: Expected Obj, but got I
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_060e: Expected Obj, but got I
		//IL_02cd: Expected I, but got Obj
		//IL_031a: Expected I, but got Obj
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03ce: Expected I, but got Obj
		//IL_03e4: Expected Obj, but got I
		//IL_063b: Expected I4, but got Obj
		//IL_040f: Expected I, but got Obj
		//IL_045c: Expected I, but got Obj
		//IL_0472: Expected Obj, but got I
		//IL_066f: Expected Obj, but got I4
		//IL_0686: Expected I, but got Obj
		//IL_069c: Expected Obj, but got I
		//IL_06a4: Expected Obj, but got I4
		//IL_049d: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v148 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AgeRestriction.shouldDisplayPopup)
		{
			int tickCount = Environment.TickCount;
			string text = string.ConcatArray((string[])(object)"AdSystemManager initialized before AgeRestriction has been setup!\n", tickCount);
			nint num3 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v69 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v74 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text).Awake();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AdSystemDebugLabel adSystemDebugLabel = default;
		adSystemDebugLabel.Awake();
		nint num5 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v17 (Il2CppClass<AdLocations>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v137 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int currentIntroVideoAdPrizeIndex = AdsSave.currentIntroVideoAdPrizeIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AdEventListenerAdapter adEventListenerAdapter = default;
		adEventListenerAdapter.WillShowAd((AdType)adSystemDebugLabel, (string)(object)AdLocations.adLocations, (string)currentIntroVideoAdPrizeIndex);
		object obj4 = this + 12;
		obj4 = adEventListenerAdapter;
		_adController.RemoveEventListener(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AdTrackingSystemLogger adTrackingSystemLogger = default;
		adTrackingSystemLogger._002Ector();
		_adController.RemoveEventListener((IAdEventListener)adTrackingSystemLogger);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IAdEventListener adEventListener = default;
		object obj5 = adEventListener + 8;
		obj5 = _adController;
		_adController.RemoveEventListener(adEventListener);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AdEventLogger adEventLogger = default;
		adEventLogger.OnApplicationPaused();
		_adController.RemoveEventListener(adEventLogger);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<string> action = default;
		object obj6 = action + 16;
		obj6 = this;
		nint num8 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v49 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v133 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnWillShowScreen -= action;
		nint num10 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v55 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num11 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v129 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj9 = default;
		obj9.method_ptr = method_ptr;
		obj9.method = (nint)__ldftn(AdSystemManager.OnOnlineSettingsDownloadResult);
		object obj10 = obj9 + 16;
		obj10 = this;
		object obj11 = saveDataPath + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v60 (System.String)+18]");
		Delegate obj12 = ((Delegate)0).CombineImpl(obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj13 = default;
		obj11 = obj13;
		Cache();
		ChangeToNextProvider();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		_ = 0;
		Action<RefreshType> action2 = default;
		object obj14 = action2 + 16;
		obj14 = this;
		AppRefreshHandler.hasRefreshed -= action2;
		_isInitialized = true;
		nint num13 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v87 (Il2CppClass<AdSystemManager+<>c>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num14 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v123 (Il2CppClass<AdSystemManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__56_0 == null;
		bool flag2 = !flag;
		int ticket = (int)_003C_003Ec._003C_003E9__56_0;
		if (!flag2)
		{
			nint num15 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v100 (Il2CppClass<AdSystemManager+<>c>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num16 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v117 (Il2CppClass<AdSystemManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num17 = 0;
			_ = 0;
			int num18 = default;
			object obj17 = num18 + 16;
			obj17 = _003C_003Ec._003C_003E9;
			nint num19 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v114 (Il2CppClass<AdSystemManager+<>c>)+5C]");
			object obj18 = (nint)0 + (nint)4;
			obj18 = num18;
			ticket = num18;
		}
		object list = Depository.CheckOut(ticket);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])list);
	}

	public bool IsCachedDebug(AdLocationInfo adLocationInfo)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0092: Expected I4, but got Obj
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_00e5: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string flurryApiKey = AdConstants.FlurryApiKey;
		Dictionary<AdLocationInfo, string> flurryAdCacheIDs = ((AdConstants)(object)flurryApiKey).FlurryAdCacheIDs;
		object obj = flurryAdCacheIDs & 1;
		if (!((string)(object)adLocationInfo != "flurry") && !((string)(object)adLocationInfo != "facebook"))
		{
			string text = string.ConcatArray((string[])(object)"Configuration is not defined for ", (int)adLocationInfo);
			nint num = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v13 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v18 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text).Awake();
		}
		bool result = default;
		return result;
	}

	public bool IsCached(AdLocationInfo info)
	{
		//IL_000f: Expected I4, but got Obj
		return _adController.IsCached((AdType)info);
	}

	public bool IsCaching(string adLocationID)
	{
		//IL_0014: Expected Obj, but got I4
		return _adController.IsCaching((string)adLocationID.m_firstChar);
	}

	public void Cache()
	{
		((AdEventListenerAdapter)(object)_adController)._002Ector();
	}

	public void Show(AdLocationInfo adLocationInfo, Action videoPayout = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0255: Expected Obj, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0289: Expected I, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_0313: Expected Obj, but got I4
		//IL_0194: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<AdLocations>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v95 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj7 != null)
			{
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj3 = obj2;
			}
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 74;
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj4 + obj13;
			if ((nint)obj14 == 74)
			{
				object obj15 = obj4 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				goto IL_034e;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_034e;
		IL_034e:
		AdSystemManager adSystemManager = (AdSystemManager)obj3;
	}

	private void SkipVideoAd()
	{
		((AdEventListenerAdapter)(object)_adController).FailedToInitAdProvider((string)null);
	}

	private void ShowAd(AdLocationInfo adLocationInfo)
	{
		Cache();
	}

	public string GetLastShowedProviderForLocation(string locationID)
	{
		//IL_0013: Expected Obj, but got I4
		return (string)_adController.Show(locationID);
	}

	public string GetCurrentProviderIDForLocation(string locationID)
	{
		//IL_003b: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag = (nint)obj6 > -1;
		bool flag2 = !flag;
		string result = string.Empty;
		if (!flag2)
		{
			string text = _lastShowedProviderPerLocation.get_Item(locationID);
			result = text;
		}
		return result;
	}

	public bool GetAvailabilityForLocation(string locationID)
	{
		return _adController.GetAvailabilityForLocation(locationID);
	}

	public uint GetGracePeriodValue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_2244: Unknown result type (might be due to invalid IL or missing references)
		//IL_2249: Expected Obj, but got Unknown
		//IL_2252: Expected Obj, but got I4
		//IL_2261: Unknown result type (might be due to invalid IL or missing references)
		//IL_2266: Expected Obj, but got Unknown
		//IL_2295: Expected I, but got Obj
		//IL_22ab: Expected Obj, but got I
		//IL_22f4: Expected Obj, but got I4
		//IL_103a: Expected I, but got Obj
		//IL_1050: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_2407: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_2521: Expected I4, but got Obj
		//IL_107b: Expected I, but got Obj
		//IL_10c8: Expected I, but got Obj
		//IL_10de: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_1109: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I4
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected Obj, but got Unknown
		//IL_1187: Expected Obj, but got I4
		//IL_1745: Unknown result type (might be due to invalid IL or missing references)
		//IL_174a: Expected Obj, but got Unknown
		//IL_01b4: Expected I, but got Obj
		//IL_01ca: Expected Obj, but got I
		//IL_059b: Expected I, but got Obj
		//IL_05b1: Expected Obj, but got I
		//IL_120e: Expected I, but got Obj
		//IL_1224: Expected Obj, but got I
		//IL_01f5: Expected I, but got Obj
		//IL_05dc: Expected I, but got Obj
		//IL_1022: Expected Obj, but got I4
		//IL_0f84: Expected Obj, but got I
		//IL_12e9: Expected I, but got Obj
		//IL_12ff: Expected Obj, but got I
		//IL_124f: Expected I, but got Obj
		//IL_026d: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_13aa: Expected I, but got Obj
		//IL_13c0: Expected Obj, but got I
		//IL_1457: Expected I, but got Obj
		//IL_146d: Expected Obj, but got I
		//IL_2196: Expected Obj, but got I
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Expected Obj, but got Unknown
		//IL_132a: Expected I, but got Obj
		//IL_02ae: Expected I, but got Obj
		//IL_13eb: Expected I, but got Obj
		//IL_1498: Expected I, but got Obj
		//IL_21d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d9: Expected Obj, but got Unknown
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffd: Expected Obj, but got Unknown
		//IL_220a: Unknown result type (might be due to invalid IL or missing references)
		//IL_220f: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_1570: Unknown result type (might be due to invalid IL or missing references)
		//IL_1575: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_15c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c6: Expected Obj, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I4
		//IL_15f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f9: Expected Obj, but got Unknown
		//IL_160b: Expected Obj, but got I4
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_164e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1653: Expected Obj, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_1681: Unknown result type (might be due to invalid IL or missing references)
		//IL_1686: Expected Obj, but got Unknown
		//IL_04d0: Expected I, but got Obj
		//IL_04e6: Expected Obj, but got I
		//IL_16ba: Expected I, but got Obj
		//IL_16d0: Expected Obj, but got I
		//IL_0511: Expected I, but got Obj
		//IL_16fb: Expected I, but got Obj
		//IL_0eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaf: Expected Obj, but got Unknown
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Expected Obj, but got Unknown
		//IL_0ee9: Expected Obj, but got I4
		//IL_20b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b9: Expected Obj, but got Unknown
		//IL_20c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c7: Expected Obj, but got Unknown
		//IL_20f3: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<AdProviderInfo> list = default;
		list._002Ector();
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21 (Il2CppClass<Globals>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v682 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = this == null;
		bool dEBUG_INTERSTITIAL_PROVIDERS = Globals.DEBUG_INTERSTITIAL_PROVIDERS;
		object obj6 = flag & dEBUG_INTERSTITIAL_PROVIDERS;
		if (obj6 == null)
		{
			goto IL_102c;
		}
		nint num3 = (nint)typeof(AdSettingsProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v379 (Il2CppClass<AdSettingsProvider>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v675 (Il2CppClass<AdSettingsProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj8 = default;
		object obj9 = default;
		object obj12 = default;
		object obj14 = default;
		object obj16 = default;
		object obj19 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj9 != null)
			{
				nint num5 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ S0_v536 (Il2CppClass<Globals>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ S0_v661 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK ? 1u : 0u) != 0)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num7 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ S0_v550 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num8 = (nint)typeof(AbstractAdProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ S0_v652 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj13 = obj14 + 16;
				obj13 = "The provider with ID: ";
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj15 = obj14 + 20;
				obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj17 = obj14 + 24;
				obj17 = " and adType: ";
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj18 = obj14 + 28;
				obj18 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj20 = obj14 + 32;
				obj20 = " is not supported on this platform.";
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num9 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1607 @ S0_v619 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num10 = (nint)typeof(AdSystemLog);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1624 @ S0_v628 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			nint num11 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S0_v516 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num12 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ S0_v525 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj23 = 71;
		object obj24 = obj23 - 15;
		object obj25;
		object obj27;
		object obj28 = default;
		if ((nint)obj23 != 15)
		{
			if ((nint)obj24 != 1)
			{
				if ((nint)obj24 != 2)
				{
					if ((nint)obj24 == 3 || (nint)obj24 == 4 || (nint)obj24 == 5 || (nint)obj24 == 6)
					{
						goto IL_0f3b;
					}
					if ((nint)obj24 != 7)
					{
						if ((nint)obj24 == 8 || (nint)obj24 == 9 || (nint)obj24 == 10 || (nint)obj24 == 11 || (nint)obj24 == 12 || (nint)obj24 == 13)
						{
							goto IL_0f3b;
						}
						if ((nint)obj24 != 14)
						{
							if ((nint)obj24 != 15)
							{
								if ((nint)obj24 == 16 || (nint)obj24 == 17 || (nint)obj24 == 18 || (nint)obj24 == 19 || (nint)obj24 == 20 || (nint)obj24 == 21)
								{
									goto IL_0f3b;
								}
								if ((nint)obj24 != 22)
								{
									if ((nint)obj24 != 23)
									{
										if ((nint)obj24 == 24 || (nint)obj24 == 25)
										{
											goto IL_0f3b;
										}
										if ((nint)obj24 != 26)
										{
											if ((nint)obj24 == 27)
											{
												goto IL_0f3b;
											}
											if ((nint)obj24 != 28)
											{
												if ((nint)obj24 == 29 || (nint)obj24 == 30 || (nint)obj24 == 31 || (nint)obj24 == 32 || (nint)obj24 == 33 || (nint)obj24 == 34 || (nint)obj24 == 35 || (nint)obj24 == 36 || (nint)obj24 == 37 || (nint)obj24 == 38 || (nint)obj24 == 39 || (nint)obj24 == 40)
												{
													goto IL_0f3b;
												}
												if ((nint)obj24 != 41)
												{
													if ((nint)obj24 != 42)
													{
														if ((nint)obj24 != 43)
														{
															if ((nint)obj24 != 44)
															{
																if ((nint)obj24 != 45 && (nint)obj24 != 46 && (nint)obj24 != 47)
																{
																	if ((nint)obj24 != 48 && (nint)obj24 != 49 && (nint)obj24 != 50 && (nint)obj24 != 51 && (nint)obj24 != 52)
																	{
																		if ((nint)obj24 == 53)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																			object obj26 = default;
																			obj25 = obj26;
																			obj27 = obj28;
																			goto IL_2385;
																		}
																		if ((nint)obj24 != 54 && (nint)obj24 != 55 && (nint)obj24 == 56)
																		{
																			object obj29 = obj4 + 4;
																			object obj30 = obj29 + 1;
																			obj29 = obj30;
																			object obj31 = obj30 << 2;
																			object obj32 = obj4 + obj31;
																			obj32 = 216;
																		}
																	}
																	goto IL_0f3b;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																object obj33 = default;
																obj25 = obj33;
																obj27 = obj28;
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																object obj34 = default;
																obj25 = obj34;
																obj27 = obj28;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj35 = default;
															obj25 = obj35;
															obj27 = obj28;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj36 = default;
														obj25 = obj36;
														obj27 = obj28;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj37 = default;
													obj25 = obj37;
													obj27 = obj28;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj38 = default;
												obj25 = obj38;
												obj27 = obj28;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj39 = default;
											obj25 = obj39;
											obj27 = obj28;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj40 = default;
										obj25 = obj40;
										obj27 = obj28;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj41 = default;
									obj25 = obj41;
									obj27 = obj28;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj42 = default;
								obj25 = obj42;
								obj27 = obj28;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj43 = default;
							obj25 = obj43;
							obj27 = obj28;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj44 = default;
						obj25 = obj44;
						obj27 = obj28;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj45 = default;
					obj25 = obj45;
					obj27 = obj28;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj46 = default;
				obj25 = obj46;
				obj27 = obj28;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj47 = default;
			obj25 = obj47;
			obj27 = obj28;
		}
		goto IL_2385;
		IL_102c:
		nint num13 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v34 (Il2CppClass<Globals>)+BA]");
		object obj48 = (nint)0 & (nint)0x200;
		if (obj48 != null)
		{
			nint num14 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v372 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = (nint)this == 1;
		bool dEBUG_VIDEOADS_PROVIDERS = Globals.DEBUG_VIDEOADS_PROVIDERS;
		object obj49 = flag2 & dEBUG_VIDEOADS_PROVIDERS;
		object obj70;
		object obj72;
		object obj77 = default;
		object obj78 = default;
		if (obj49 != null)
		{
			nint num15 = (nint)typeof(AdSettingsProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v45 (Il2CppClass<AdSettingsProvider>)+BA]");
			object obj50 = (nint)0 & (nint)0x200;
			if (obj50 != null)
			{
				nint num16 = (nint)typeof(AdSettingsProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v366 (Il2CppClass<AdSettingsProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj51 = default;
			object obj52 = default;
			object obj54 = default;
			object obj58 = default;
			object obj60 = default;
			object obj62 = default;
			object obj65 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj51 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj52 != null)
				{
					nint num17 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ S0_v345 (Il2CppClass<Globals>)+BA]");
					object obj53 = (nint)0 & (nint)0x200;
					if (obj53 != null)
					{
						nint num18 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ S0_v352 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					if (!Globals.DEBUG_VIDEOADS_PROVIDERS_FLURRY)
					{
						continue;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
						nint num19 = (nint)typeof(AdSystemLog);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ S0_v309 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
						object obj55 = (nint)0 & (nint)0x200;
						if (obj55 != null)
						{
							nint num20 = (nint)typeof(AdSystemLog);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ S0_v318 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						continue;
					}
					nint num21 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1254 @ S0_v328 (Il2CppClass<Globals>)+BA]");
					object obj56 = (nint)0 & (nint)0x200;
					if (obj56 != null)
					{
						nint num22 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ S0_v335 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					if (!Globals.DEBUG_VIDEOADS_PROVIDERS_FACEBOOK)
					{
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num23 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ S0_v178 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
				object obj57 = (nint)0 & (nint)0x200;
				if (obj57 != null)
				{
					nint num24 = (nint)typeof(AbstractAdProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ S0_v280 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj58 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj59 = obj60 + 16;
				obj59 = "The provider with ID: ";
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj61 = obj60 + 20;
				obj61 = obj62;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj63 = obj60 + 24;
				obj63 = " and adType: ";
				obj2 = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj64 = obj60 + 28;
				obj64 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj66 = obj60 + 32;
				obj66 = " is not supported on this platform.";
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num25 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ S0_v247 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
				object obj67 = (nint)0 & (nint)0x200;
				if (obj67 != null)
				{
					nint num26 = (nint)typeof(AdSystemLog);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ S0_v256 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			object obj68 = 153;
			object obj69 = obj68 - 89;
			if ((nint)obj68 != 89)
			{
				if ((nint)obj69 != 1)
				{
					if ((nint)obj69 != 2)
					{
						if ((nint)obj69 == 3 || (nint)obj69 == 4)
						{
							goto IL_214d;
						}
						if ((nint)obj69 != 5)
						{
							if ((nint)obj69 == 6 || (nint)obj69 == 7 || (nint)obj69 == 8 || (nint)obj69 == 9)
							{
								goto IL_214d;
							}
							if ((nint)obj69 != 10)
							{
								if ((nint)obj69 == 11 || (nint)obj69 == 12 || (nint)obj69 == 13 || (nint)obj69 == 14 || (nint)obj69 == 15 || (nint)obj69 == 16 || (nint)obj69 == 17 || (nint)obj69 == 18 || (nint)obj69 == 19 || (nint)obj69 == 20)
								{
									goto IL_214d;
								}
								if ((nint)obj69 != 21)
								{
									if ((nint)obj69 != 22)
									{
										if ((nint)obj69 == 23 || (nint)obj69 == 24 || (nint)obj69 == 25 || (nint)obj69 == 26 || (nint)obj69 == 27 || (nint)obj69 == 28 || (nint)obj69 == 29)
										{
											goto IL_214d;
										}
										if ((nint)obj69 != 30)
										{
											if ((nint)obj69 != 31)
											{
												if ((nint)obj69 == 32 || (nint)obj69 == 33)
												{
													goto IL_214d;
												}
												if ((nint)obj69 != 34)
												{
													if ((nint)obj69 == 35)
													{
														goto IL_214d;
													}
													if ((nint)obj69 != 36)
													{
														if ((nint)obj69 == 37 || (nint)obj69 == 38 || (nint)obj69 == 39 || (nint)obj69 == 40 || (nint)obj69 == 41 || (nint)obj69 == 42 || (nint)obj69 == 43 || (nint)obj69 == 44 || (nint)obj69 == 45 || (nint)obj69 == 46 || (nint)obj69 == 47 || (nint)obj69 == 48)
														{
															goto IL_214d;
														}
														if ((nint)obj69 != 49)
														{
															if ((nint)obj69 != 50)
															{
																if ((nint)obj69 != 51)
																{
																	if ((nint)obj69 != 52)
																	{
																		if ((nint)obj69 != 53 && (nint)obj69 != 54 && (nint)obj69 != 55)
																		{
																			if ((nint)obj69 != 56 && (nint)obj69 != 57 && (nint)obj69 != 58 && (nint)obj69 != 59 && (nint)obj69 != 60)
																			{
																				if ((nint)obj69 == 61)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																					object obj71 = default;
																					obj70 = obj71;
																					obj72 = obj28;
																					goto IL_24a3;
																				}
																				if ((nint)obj69 != 62 && (nint)obj69 != 63 && (nint)obj69 == 64)
																				{
																					object obj73 = obj4 + 4;
																					object obj74 = obj73 + 1;
																					obj73 = obj74;
																					object obj75 = obj74 << 2;
																					object obj76 = obj4 + obj75;
																					obj76 = 461;
																					obj77 = obj78;
																				}
																			}
																			goto IL_214d;
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																		object obj79 = default;
																		obj70 = obj79;
																		obj72 = obj28;
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																		object obj80 = default;
																		obj70 = obj80;
																		obj72 = obj28;
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj81 = default;
																	obj70 = obj81;
																	obj72 = obj28;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																object obj82 = default;
																obj70 = obj82;
																obj72 = obj28;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj83 = default;
															obj70 = obj83;
															obj72 = obj28;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj84 = default;
														obj70 = obj84;
														obj72 = obj28;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj85 = default;
													obj70 = obj85;
													obj72 = obj28;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj86 = default;
												obj70 = obj86;
												obj72 = obj28;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj87 = default;
											obj70 = obj87;
											obj72 = obj28;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj88 = default;
										obj70 = obj88;
										obj72 = obj28;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj89 = default;
									obj70 = obj89;
									obj72 = obj28;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj90 = default;
								obj70 = obj90;
								obj72 = obj28;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj91 = default;
							obj70 = obj91;
							obj72 = obj28;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj92 = default;
						obj70 = obj92;
						obj72 = obj28;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj93 = default;
					obj70 = obj93;
					obj72 = obj28;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj94 = default;
				obj70 = obj94;
				obj72 = obj28;
			}
			goto IL_24a3;
		}
		goto IL_251c;
		IL_251c:
		return (uint)(int)list;
		IL_222b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		return 0u;
		IL_2385:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj95 = default;
		if (obj27 != obj95)
		{
			object obj96 = obj25;
			goto IL_222b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		object obj97 = default;
		obj78 = obj97;
		goto IL_0f3b;
		IL_214d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj98 = (nint)0 << 2;
			object obj99 = obj4 + obj98;
			if ((nint)obj99 == 461)
			{
				object obj100 = obj4 + 4;
				if ((nint)obj100 > -1)
				{
					object obj101 = obj100 + -1;
					obj100 = obj101;
				}
				goto IL_251c;
			}
		}
		if (obj77 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_251c;
		IL_0f3b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj102 = (nint)0 << 2;
			object obj103 = obj4 + obj102;
			if ((nint)obj103 == 216)
			{
				object obj104 = obj4 + 4;
				if ((nint)obj104 > -1)
				{
					object obj105 = obj104 + -1;
					obj104 = obj105;
				}
				goto IL_102c;
			}
		}
		if (obj78 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			goto IL_222b;
		}
		obj78 = 0;
		goto IL_102c;
		IL_24a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj106 = default;
		if (obj72 != obj106)
		{
			object obj96 = obj70;
			goto IL_222b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		object obj107 = default;
		obj77 = obj107;
		goto IL_214d;
	}

	public bool AreInterstitialsAllowed()
	{
		return _adController.AreInterstitialsAllowed();
	}

	public bool HasPriorityListWrapped(string locationID)
	{
		return _adController.HasPriorityListWrapped(locationID);
	}

	public unsafe override void WillShowAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected VT, but got Unknown
		//IL_0169: Expected I8, but got Obj
		//IL_0164: Expected native int or pointer, but got VT
		//IL_003b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I4
		//IL_022a: Expected I8, but got Obj
		//IL_0225: Expected native int or pointer, but got VT
		//IL_022f: Expected native int or pointer, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_00c9: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		_ = 0;
		TimeSpan timeSpan = (TimeSpan)(obj2 + 24);
		((TimeSpan*)(nint)timeSpan)->_ticks = (long)adLocationID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"lock_on_time_limit_{args}";
		string key = text.ToLowerInvariant();
		if ((nint)adLocationID < 2)
		{
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v28 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v43 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			uint value = ((OnlineSettings)(object)saveDataPath).GetValue(key, 72000u);
			nint num3 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v21 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v32 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
			AdSystemManager adSystemManager = (AdSystemManager)0;
			_isInitialized = false;
			object obj5 = default;
			obj2 = obj5;
			((TimeSpan*)(nint)timeSpan)->_ticks = (long)obj2;
			*(TimeSpan?*)(nint)this = timeSpan;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			AdSystemManager adSystemManager = (AdSystemManager)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_isInitialized = false;
		}
	}

	public override void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached)
	{
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_001d: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = providerID;
		if (_adController == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PokiUnitySDK pokiUnitySDK = default;
			pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_0108: Expected Obj, but got I4
		//IL_0108: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		((AdEventLogger)(object)this).WillShowAd((AdType)adLocationID, providerID, (string)1);
		switch (adType)
		{
		case AdType.Interstitial:
			if (AdSystemManager.m_onWillShowInterstitial != null)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v4 (Il2CppMethodInfo)+18]");
				object obj5 = 0;
				object obj6 = obj5;
				object obj7 = obj6 & 0x3FFF;
				object obj8 = obj7 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S3_v7 (should have been resolved before IL gen)");
			}
			break;
		case AdType.Video:
			if (AdSystemManager.m_onWillShowVideo != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v7 (Il2CppMethodInfo)+18]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj2 & 0x3FFF;
				object obj4 = obj3 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S3_v11 (should have been resolved before IL gen)");
			}
			break;
		}
	}

	public override void ShowedAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_0132: Expected I4, but got Obj
		//IL_0132: Expected Obj, but got I4
		//IL_0078: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		bool availabilityForLocation = _adController.GetAvailabilityForLocation(adLocationID);
		if (((string)availabilityForLocation).get_Chars((int)providerID) != '\0')
		{
			return;
		}
		switch (adType)
		{
		case AdType.Interstitial:
			if (AdSystemManager.m_onFailedToCacheInterstitial != null)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v5 (Il2CppMethodInfo)+18]");
				object obj5 = 0;
				object obj6 = obj5;
				object obj7 = obj6 & 0x3FFF;
				object obj8 = obj7 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v83 @ S3_v6 (should have been resolved before IL gen)");
			}
			break;
		case AdType.Video:
			if (AdSystemManager.m_onFailedToCacheVideo != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S2_v8 (Il2CppMethodInfo)+18]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj2 & 0x3FFF;
				object obj4 = obj3 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S3_v10 (should have been resolved before IL gen)");
			}
			break;
		}
	}

	public override void FinishedWatchingVideo(string providerID, string adLocationID)
	{
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_018f: Expected Obj, but got I4
		//IL_0063: Expected I, but got Obj
		if (~(_showAllowed ? 1u : 0u) != 0)
		{
			return;
		}
		_showAllowed = false;
		if (providerID.m_firstChar == '\u0001')
		{
			object obj = this + 24;
			obj = adLocationID;
		}
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v14 (Il2CppClass<Globals>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v36 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_SKIP_VIDEO_ADS ? 1u : 0u) == 0 && providerID.m_firstChar == '\u0001')
		{
			GiveReward();
			return;
		}
		PriorityListWrapped(providerID);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		int num4 = default;
		object obj3 = num4 + 16;
		obj3 = this;
		object list = Depository.CheckOut(num4);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])list);
	}

	public override void FailedToShowAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_010a: Expected I4, but got Obj
		//IL_0118: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		((AdEventLogger)(object)this).WillShowAd((AdType)adLocationID, providerID, (string)null);
		((AdSystemManager)null).SetProviderForAdLocation((string)adType, (AbstractAdProvider)(object)adLocationID);
		switch (adType)
		{
		case AdType.Interstitial:
			if (AdSystemManager.m_onShowedInterstitial != null)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S2_v5 (Il2CppMethodInfo)+18]");
				object obj5 = 0;
				object obj6 = obj5;
				object obj7 = obj6 & 0x3FFF;
				object obj8 = obj7 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S3_v8 (should have been resolved before IL gen)");
			}
			break;
		case AdType.Video:
			((AdSystemManager)null).EnableAudio();
			if (AdSystemManager.m_onShowedVideo != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S2_v8 (Il2CppMethodInfo)+18]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj2 & 0x3FFF;
				object obj4 = obj3 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69 @ S3_v12 (should have been resolved before IL gen)");
			}
			break;
		}
	}

	public override void DismissedAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_023c: Expected I, but got Obj
		//IL_0252: Expected Obj, but got I
		//IL_028a: Expected Obj, but got I4
		//IL_00dd: Expected I, but got Obj
		//IL_012a: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		((AdSystemManager)null).UpdateDebugPriorityListVersion(adType);
		object obj = this + 16;
		obj = 0;
		switch (adType)
		{
		case AdType.Interstitial:
			if (AdSystemManager.m_onFailedToShowInterstitial != null)
			{
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v4 (Il2CppMethodInfo)+18]");
				object obj8 = 0;
				object obj9 = obj8;
				object obj10 = obj9 & 0x3FFF;
				object obj11 = obj10 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S3_v6 (should have been resolved before IL gen)");
			}
			break;
		case AdType.Video:
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v19 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v41 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v10 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v20 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string slideIn = Strings.GetDefault("SLIDEIN_VIDEO_PLAY_ERROR");
			((UIScreenController)flag).QueueSlideIn((SlideIn)(object)slideIn);
			if (AdSystemManager.m_onFailedToShowVideo != null)
			{
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v11 (Il2CppMethodInfo)+18]");
				object obj4 = 0;
				object obj5 = obj4;
				object obj6 = obj5 & 0x3FFF;
				object obj7 = obj6 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v135 @ S3_v11 (should have been resolved before IL gen)");
			}
			if (adLocationID != null && adLocationID.m_stringLength != 0)
			{
				SkipVideoAd();
			}
			break;
		}
		}
	}

	public override void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		((AdSystemManager)null).UpdateDebugPriorityListVersion(adType);
		object obj = this + 16;
		obj = 0;
		switch (adType)
		{
		case AdType.Interstitial:
			if (AdSystemManager.m_onDismissedInterstitial != null)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v4 (Il2CppMethodInfo)+18]");
				object obj6 = 0;
				object obj7 = obj6;
				object obj8 = obj7 & 0x3FFF;
				object obj9 = obj8 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S3_v6 (should have been resolved before IL gen)");
			}
			break;
		case AdType.Video:
			((AdSystemManager)null).LoadLastShowedProviders();
			if (AdSystemManager.m_onDismissedVideo != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v7 (Il2CppMethodInfo)+18]");
				object obj2 = 0;
				object obj3 = obj2;
				object obj4 = obj3 & 0x3FFF;
				object obj5 = obj4 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63 @ S3_v10 (should have been resolved before IL gen)");
			}
			break;
		}
	}

	public override void PriorityListWrapped(string waterfallID)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got I4
		object obj = this + 16;
		obj = waterfallID;
		string currentProviderIDForLocation = _adController.GetCurrentProviderIDForLocation((string)waterfallID.m_stringLength);
		if (currentProviderIDForLocation != null)
		{
			((AdSystemManager)null).ShowOverlay((AdType)waterfallID.m_firstChar, (string)waterfallID.m_stringLength);
		}
	}

	private void HandleOnWillShowScreen(string screenName)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		if (AdSystemManager.m_onPriorityListWrapped != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v2 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	private void GiveReward()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	private void ShowTransitionOverlay(AdType adType, string adLocationID)
	{
		//IL_0039: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		((AdSystemManager)null).UpdateDebugPriorityListVersion(AdType.Video);
		((AdSystemManager)null).LoadLastShowedProviders();
		DisableAudio();
		if (AdSystemManager.m_onFinishedWatchingVideo != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v3 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S3_v5 (should have been resolved before IL gen)");
		}
		bool flag;
		if (adLocationID != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [adLocationID @ L2 (Kiloo.Common.Ads.AdType)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			SkipVideoAd();
		}
	}

	private void ShowOverlay(AdType adType, string adLocationID)
	{
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_0076: Expected I, but got Obj
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_01c6: Expected I4, but got Obj
		//IL_01c6: Expected Obj, but got I4
		//IL_0104: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I4
		switch (adType)
		{
		case AdType.Interstitial:
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).ShowDiskSpaceErrorOverlay();
			break;
		}
		case AdType.Video:
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v23 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).HideVideoAdsOverlay((byte)(int)adLocationID != 0);
			break;
		}
		default:
		{
			object obj = adType;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "Unable to find AdsOverlay for adType: " + text;
			SDebug.LogFormat(msg, null);
			break;
		}
		}
	}

	private unsafe void HideOverlay(AdType adType)
	{
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00f0: Expected I4, but got Obj
		//IL_00f0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		bool flag = ((OnlineSettings)(object)saveDataPath).TryGetValue("allow_recache_during_run", out *(string*)null);
		AdController adController = _adController;
		char c = ((string)adType).get_Chars((int)"IngameUI");
		int num3 = (flag ? 1 : 0) | (int)c;
		int num4 = num3 & 1;
		adController.allowReCacheOnFail__BackingField = (byte)num4 != 0;
	}

	public void DisableAudio()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		if (_videoReward != null)
		{
			TransformExtensions.Reset((Transform)(object)_videoReward);
			object obj = this + 24;
			obj = 0;
		}
		else
		{
			SDebug.LogFormat("Tried to GiveReward but _videoReward is null!", null);
		}
	}

	public void EnableAudio()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool musicEnabled = PreferencesSave.musicEnabled;
		bool topRunChallengersEnabled = PreferencesSave.topRunChallengersEnabled;
		nint num3 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v2 (Il2CppClass<HouseKeeper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v7 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((HouseKeeper)musicEnabled).OnOpenedThroughNotification((Notification)topRunChallengersEnabled);
		Trophies._002Ecctor();
	}

	private void LoadLastShowedProviders()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
	}

	private void UpdateLastShowedProviders(string adLocationID, string providerID, bool shouldSave)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		if (AdSystemManager.m_onChangedProvider != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v2 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	public void ChangeToNextProvider()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Expected Obj, but got I4
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0120: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		InterstitialStats interstitialStats = AdsSave.interstitialStats;
		if (interstitialStats == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj7 = obj5 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj5 + obj9;
		obj10 = 86;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj5 + obj11;
			if ((nint)obj12 == 86)
			{
				object obj13 = obj5 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				return;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void UpdateDebugPriorityListVersion(AdType adType)
	{
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_0076: Expected I, but got Obj
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		//IL_0104: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I4
		switch (adType)
		{
		case AdType.Interstitial:
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).ShowTransitionAdsOverlay();
			break;
		}
		case AdType.Video:
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v23 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).AddBackButtonBehavior((string)1);
			break;
		}
		default:
		{
			object obj = adType;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "Unable to find AdsOverlay for adType: " + text;
			SDebug.LogFormat(msg, null);
			break;
		}
		}
	}

	public void SetProviderForAdLocation(string adLocationId, AbstractAdProvider provider)
	{
		//IL_0035: Expected I, but got Obj
		//IL_004b: Expected Obj, but got I
		//IL_01ab: Expected Obj, but got I4
		//IL_0076: Expected I, but got Obj
		//IL_00c3: Expected I, but got Obj
		//IL_00d9: Expected Obj, but got I
		//IL_01c6: Expected I4, but got Obj
		//IL_01c6: Expected Obj, but got I4
		//IL_0104: Expected I, but got Obj
		if (adLocationId != null)
		{
			if ((nint)adLocationId == 1)
			{
				nint num = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v23 (Il2CppClass<UIScreenController>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				((UIScreenController)flag).HideVideoAdsOverlay((byte)(int)provider != 0);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text = default;
				string msg = "Unable to find AdsOverlay for adType: " + text;
				SDebug.LogFormat(msg, null);
			}
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).HideAdsOverlay();
	}

	public string GetIdOfAdlocationBeingShown()
	{
		//IL_000f: Expected Obj, but got I4
		return (string)((AdLocation)(object)_adController).hasProvider;
	}

	private AdSystemManager()
	{
		_adController.UpdateCacheIdsFromOnlineSettings();
		((AdEventListenerAdapter)(object)_adController).FailedToInitAdProvider((string)null);
	}

	private void _003CShow_003Eb__66_0()
	{
		//IL_003c: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		_showAllowed = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 20;
		object obj7 = default;
		obj6 = obj7;
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			UpdateCacheIdsFromOnlineSettings();
		}
	}
}
