using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.LocalizationManager;
using UnityEngine;

namespace Kiloo.Common.Ads;

public class DebugAdProvider : AbstractAdProvider
{
	private sealed class _003CCacheInterstitialCoroutine_003Ed__34(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DebugAdProvider _003C_003E4__this;

		public string adLocationID;

		public string cacheID;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_02d7: Expected Obj, but got I4
				//IL_004a: Expected Obj, but got I4
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Expected Obj, but got Unknown
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Expected Obj, but got Unknown
				//IL_0091: Expected Obj, but got I4
				//IL_00a5: Expected Obj, but got I4
				//IL_00d1: Expected I, but got Obj
				//IL_00e7: Expected Obj, but got I
				//IL_03b3: Expected I, but got Obj
				//IL_03c9: Expected Obj, but got I
				//IL_0112: Expected I, but got Obj
				//IL_0372: Expected I, but got Obj
				//IL_0388: Expected Obj, but got I
				//IL_0238: Expected I, but got Obj
				//IL_0285: Expected I, but got Obj
				//IL_01aa: Expected I, but got Obj
				//IL_01c0: Expected Obj, but got I
				//IL_01eb: Expected I, but got Obj
				object obj = 0;
				DebugAdProvider debugAdProvider = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						debugAdProvider._isCachingInterstitial = false;
						nint num = (nint)typeof(DebugAdProvider);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v23 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num2 = (nint)typeof(DebugAdProvider);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v80 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(forceNextCacheToFail ? 1u : 0u) != 0)
						{
							string id = _003C_003E4__this.id;
							if (id == null)
							{
								debugAdProvider._cachedInterstitials.Add(cacheID);
								nint num3 = (nint)typeof(AbstractAdProvider);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v66 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
								object obj3 = (nint)0 & (nint)0x200;
								if (obj3 != null)
								{
									nint num4 = (nint)typeof(AbstractAdProvider);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v74 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
								string providerID = default;
								((AdController.EventHandler)(object)AbstractAdProvider.eventInvoker).CachedAd(AdType.Interstitial, providerID, adLocationID, false);
								return null;
							}
						}
						nint num5 = (nint)typeof(DebugAdProvider);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v33 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num6 = (nint)typeof(DebugAdProvider);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v54 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						forceNextCacheToFail = false;
						nint num7 = (nint)typeof(AbstractAdProvider);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v40 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num8 = (nint)typeof(AbstractAdProvider);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v48 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						string providerID2 = default;
						AbstractAdProvider.eventInvoker.FailedToShowAd(AdType.Interstitial, providerID2, adLocationID);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				int num9 = Util.ConvertTimeoutToMilliseconds(1f);
				obj = num9;
				object obj6 = this + 12;
				object obj7 = obj;
				_ = 1;
				object l = _003C_003E4__this - -64;
				bool flag = ((LegalLanguage._003C_003Ec)obj)._003CImportLocalePaste_003Eb__6_0((string)l);
				obj6 = flag;
				_003C_003E1__state = 1;
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

	private sealed class _003CCacheVideoCoroutine_003Ed__35(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DebugAdProvider _003C_003E4__this;

		public string adLocationID;

		public string cacheID;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0358: Expected Obj, but got I4
				//IL_004a: Expected Obj, but got I4
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Expected Obj, but got Unknown
				//IL_0086: Expected Obj, but got I4
				//IL_009a: Expected Obj, but got I4
				//IL_00c6: Expected I, but got Obj
				//IL_00dc: Expected Obj, but got I
				//IL_040c: Expected I, but got Obj
				//IL_0422: Expected Obj, but got I
				//IL_0107: Expected I, but got Obj
				//IL_0484: Expected I, but got Obj
				//IL_049a: Expected Obj, but got I
				//IL_02b9: Expected I, but got Obj
				//IL_0306: Expected I, but got Obj
				//IL_0189: Expected I, but got Obj
				//IL_019f: Expected Obj, but got I
				//IL_01ca: Expected I, but got Obj
				//IL_022b: Expected I, but got Obj
				//IL_0241: Expected Obj, but got I
				//IL_026c: Expected I, but got Obj
				object obj = 0;
				DebugAdProvider debugAdProvider = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						debugAdProvider._isCachingVideo = false;
						nint num = (nint)typeof(DebugAdProvider);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v23 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num2 = (nint)typeof(DebugAdProvider);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v95 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(forceNextCacheToFail ? 1u : 0u) != 0)
						{
							string id = debugAdProvider.id;
							if (id == null)
							{
								nint num3 = (nint)typeof(DebugAdProvider);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v64 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+BA]");
								object obj3 = (nint)0 & (nint)0x200;
								if (obj3 != null)
								{
									nint num4 = (nint)typeof(DebugAdProvider);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v89 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (~(forceCacheToFail ? 1u : 0u) != 0)
								{
									debugAdProvider._cachedVideos.Add(cacheID);
									nint num5 = (nint)typeof(AbstractAdProvider);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v75 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
									object obj4 = (nint)0 & (nint)0x200;
									if (obj4 != null)
									{
										nint num6 = (nint)typeof(AbstractAdProvider);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v83 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
									string providerID = default;
									((AdController.EventHandler)(object)AbstractAdProvider.eventInvoker).CachedAd(AdType.Video, providerID, adLocationID, false);
									return null;
								}
							}
						}
						nint num7 = (nint)typeof(DebugAdProvider);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v33 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num8 = (nint)typeof(DebugAdProvider);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v54 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						forceNextCacheToFail = false;
						nint num9 = (nint)typeof(AbstractAdProvider);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v40 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num10 = (nint)typeof(AbstractAdProvider);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v48 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						string providerID2 = default;
						AbstractAdProvider.eventInvoker.FailedToShowAd(AdType.Video, providerID2, adLocationID);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				int num11 = Util.ConvertTimeoutToMilliseconds(1f);
				obj = num11;
				object obj7 = this + 12;
				object obj8 = obj;
				_ = 1;
				bool flag = ((LegalLanguage._003C_003Ec)obj)._003CImportLocalePaste_003Eb__6_0((string)(object)debugAdProvider._videoRunner);
				obj7 = flag;
				_003C_003E1__state = 1;
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

	private const int DEVICE_CLOSE_BUTTON_SIZE = 150;

	private const int DEVICE_TEXT_FONT_SIZE = 60;

	private const float SIMULATED_FAIL_CHANCE = 0.15f;

	private const float SIMULATED_CACHE_TIME = 1f;

	private readonly string _id;

	private readonly bool _supportsMulticaching;

	private DebugAdGUI _adGUI;

	private List<string> _cachedVideos;

	private List<string> _cachedInterstitials;

	private MonoBehaviour _interstitialRunner;

	private bool _isCachingInterstitial;

	private bool _isCachingVideo;

	private MonoBehaviour _videoRunner;

	public static bool forceNextCacheToFail;

	public static bool forceCacheToFail;

	private unsafe bool errorHappened
	{
		get
		{
			//IL_0064: Expected Obj, but got I4
			//IL_0079: Expected Obj, but got I4
			//IL_00a3: Expected I, but got Obj
			//IL_00b9: Expected Obj, but got I
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected VT, but got Unknown
			//IL_00f1: Expected F4, but got Obj
			//IL_00ec: Expected native int or pointer, but got VT
			//IL_0106: Expected F4, but got I
			//IL_0101: Expected native int or pointer, but got VT
			//IL_0118: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			int height = Screen.height;
			object obj = 0;
			_ = 0;
			object obj2 = height - base._initState;
			obj = obj2;
			_ = 0f;
			_ = base._initState;
			_ = base._initState;
			nint num = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v34 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Rect rect = (Rect)(obj + 16);
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			return (byte)(int)GUI.TextField(rect, "X") != 0;
		}
	}

	public override string id
	{
		get
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0066: Expected I, but got Obj
			//IL_007c: Expected Obj, but got I
			//IL_00a7: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text = default;
			if (text.EndsWith("fail-provider"))
			{
				return (string)1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text2 = default;
			if (!text2.EndsWith("success-provider"))
			{
				nint num = (nint)typeof(DebugAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v16 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(DebugAdProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v19 (Il2CppClass<Kiloo.Common.Ads.DebugAdProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
			return null;
		}
	}

	private static bool simulateErrors
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
			bool result = default;
			return result;
		}
	}

	public override bool supportsMulticaching
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_id != 0;
		}
	}

	public DebugAdProvider(string id, bool supportsMulticahing)
	{
		//IL_000b: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got F4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		_cacheInterstitialLocation = (string)1;
		_ = 0;
		object obj = this + 16;
		obj = supportsMulticahing;
		_cacheVideoLocation = (string)5f;
		object obj2 = this + 36;
		obj2 = id;
	}

	protected unsafe override void CheckPlatformSupport(AdProviderConfiguration configuration)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Ref, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GUIStyle gUIStyle = default;
		gUIStyle.name = (string)(object)configuration;
		object obj = this + 32;
		obj = gUIStyle;
		RectOffset margin = ((GUIStyle)(object)_supportedAdTypes).margin;
		Color blue = Color.blue;
		object obj2 = default;
		ref Color reference = ref *(Color*)(obj2 + 16);
		reference = ref *(Color*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((GUIStyleState)(object)margin).set_textColor_Injected(ref reference);
	}

	protected override void CacheInterstitial(string adLocationID, string cacheID)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_002f: Expected I, but got Obj
		//IL_0045: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected I4, but got Unknown
		//IL_0070: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj = this + 56;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list2 = default;
		list2._002Ector();
		object obj2 = this + 60;
		obj2 = list2;
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v24 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AdController)(object)this).ChangeToNextProvider();
		object obj4 = this + 44;
		obj4 = adLocationID;
		bool flag = (byte)(cacheID & 1) != 0;
		_supportsMulticaching = flag;
	}

	protected override void CacheVideo(string adLocationID, string cacheID)
	{
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_00b4: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null && (~(_isCachingInterstitial ? 1u : 0u) == 0 || _cachedInterstitials.Contains(cacheID)))
		{
			return;
		}
		_isCachingInterstitial = true;
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v11 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v22 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		AbstractAdProvider.eventInvoker.FailedToCacheAd(AdType.Interstitial, providerID, adLocationID);
		object obj3 = this - -64;
		IEnumerator routine = CacheVideoCoroutine(adLocationID, cacheID);
		Coroutine coroutine = ((MonoBehaviour)obj3).StartCoroutine_Auto(routine);
	}

	protected override bool HasCachedInterstitial(string cacheID)
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_000e: Invalid comparison between VT and I4
		//IL_00da: Expected I4, but got VT
		//IL_0055: Expected I, but got Obj
		//IL_006b: Expected Obj, but got I
		//IL_0096: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = cacheID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Func<_0021_00210, bool> func = default;
		object obj3 = func + 16;
		obj3 = obj2;
		_0021_00210 val = (_0021_00210)Enumerable.SingleOrDefault<TSource>((IEnumerable<TSource>)(object)_cacheInterstitialLocation, (Func<TSource, bool>)(object)func);
		if (val == (_0021_00210)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			string text = string.ConcatArray((string[])(object)"Could not find an ad location with the specified ID: ", 0);
			nint num2 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v18 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num3 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v23 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text).Awake();
		}
		return (byte)(int)val != 0;
	}

	protected override bool HasCachedVideo(string cacheID)
	{
		return _cachedInterstitials.Contains(cacheID);
	}

	protected override void OnCacheTimeout(AdType adType, string adLocationID)
	{
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_010f: Expected Obj, but got I4
		//IL_00b4: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null && (~(_isCachingVideo ? 1u : 0u) == 0 || _cachedVideos.Contains(adLocationID)))
		{
			return;
		}
		_isCachingVideo = true;
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v11 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		AbstractAdProvider.eventInvoker.FailedToCacheAd(AdType.Video, providerID, (string)adType);
		OfferWallManager instance = OfferWallManager.instance;
		((AdEventLogger)(object)instance).FinishedWatchingVideo((string)adType, (string)(object)this);
		bool flag = ((InterstitialStats)(object)this).HasVersionChangedForList((string)adType, adLocationID);
		Coroutine coroutine = _videoRunner.StartCoroutine_Auto((IEnumerator)flag);
	}

	protected override void OnInitialize(AdProviderConfiguration configuration)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0077: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S4_v4+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S5_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S4_v8+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v9+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v8 (should have been resolved before IL gen)");
	}

	private void UpdateAdGuiProperties()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	protected override void ShowInterstitial(string adLocationID, string cacheID)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		if (adLocationID != null)
		{
			_isCachingVideo = false;
			MonoBehaviour.print(_videoRunner);
		}
		else
		{
			_isCachingInterstitial = false;
			object message = this - -64;
			MonoBehaviour.print(message);
		}
	}

	protected override void ShowVideo(string adLocationID, string cacheID)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_0169: Expected I, but got Obj
		//IL_0067: Expected I, but got Obj
		string text = id;
		if (text != null)
		{
			bool flag = _cachedInterstitials.Remove(cacheID);
			nint num = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v39 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v46 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string providerID = default;
			AbstractAdProvider.eventInvoker.CachingTimedOut(AdType.Interstitial, providerID, adLocationID);
			return;
		}
		DebugAdGUI adGUI = _adGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		adGUI._showInterstitial = true;
		adGUI._showVideo = false;
		object obj2 = adGUI + 16;
		object obj3 = default;
		obj2 = obj3;
		object obj4 = adGUI + 36;
		obj4 = adLocationID;
		bool flag2 = _cachedInterstitials.Remove(cacheID);
		nint num3 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v22 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v29 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID2 = default;
		AbstractAdProvider.eventInvoker.DismissedAd(AdType.Interstitial, providerID2, adLocationID);
	}

	private IEnumerator CacheInterstitialCoroutine(string adLocationID, string cacheID)
	{
		if (base._initState != AbstractAdProvider.InitState.Initialized)
		{
			return null;
		}
		if (cacheID == null || cacheID.m_stringLength == 0)
		{
			return null;
		}
		if ((nint)adLocationID == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		}
		IEnumerator result = default;
		return result;
	}

	private IEnumerator CacheVideoCoroutine(string adLocationID, string cacheID)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = adLocationID;
		object obj3 = enumerator + 24;
		obj3 = cacheID;
		return enumerator;
	}

	private void _003COnInitialize_003Eb__30_0()
	{
		//IL_0015: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I4
		_adGUI.ShowInterstitial((string)150, (string)60);
	}

	private unsafe void _003COnInitialize_003Eb__30_1(AdType adType)
	{
		//IL_002a: Expected I4, but got Obj
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_02b2: Expected I4, but got Obj
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_014a: Expected I, but got Obj
		//IL_01c6: Expected I4, but got Obj
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_0264: Expected Obj, but got I4
		string text = id;
		if (text != null)
		{
			OnFinishedCaching((string)null);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)_id;
		object obj = this + 52;
		DebugAdGUI debugAdGUI = gameObject.AddComponent<DebugAdGUI>();
		obj = debugAdGUI;
		_003COnInitialize_003Eb__30_0();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(DebugAdProvider._003COnInitialize_003Eb__30_0);
		object obj2 = action + 16;
		obj2 = this;
		_adGUI.finishedWatchingVideo -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<AdType> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		_adGUI.dismissedAd -= action2;
		string tag = _adGUI.tag;
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)tag).Exec();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject2 = default;
		gameObject2.layer = (int)"VideoRunner";
		object obj5 = this + 72;
		NewMonoBehaviour newMonoBehaviour = gameObject2.AddComponent<NewMonoBehaviour>();
		obj5 = newMonoBehaviour;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject3 = default;
		gameObject3.layer = (int)"InterstitialRunner";
		object obj6 = this - -64;
		NewMonoBehaviour newMonoBehaviour2 = gameObject3.AddComponent<NewMonoBehaviour>();
		obj6 = newMonoBehaviour2;
		GameObject gameObject4 = _videoRunner.gameObject;
		GameObject gameObject5 = _adGUI.gameObject;
		((Transform)(object)gameObject4).parentInternal = (Transform)(object)gameObject5;
		object obj7 = this - -64;
		GameObject gameObject6 = ((Component)obj7).gameObject;
		GameObject gameObject7 = _adGUI.gameObject;
		((Transform)(object)gameObject6).parentInternal = (Transform)(object)gameObject7;
		OnFinishedCaching((string)1);
	}
}
