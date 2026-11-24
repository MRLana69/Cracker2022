using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Utility;
using UnityEngine;
using UnityEngine.Networking;

namespace Kiloo.Common.Ads;

public class AdLocation : AdEventListenerAdapter
{
	private sealed class _003CWaitWhileConditionOrUntilTimedOut_003Ed__21(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Func<bool> condition;

		public float timeoutInSeconds;

		private float _003CstartTime_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f3: Expected Obj, but got Unknown
				//IL_00fc: Expected Obj, but got I4
				//IL_0110: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
					_003CelapsedTime_003E5__3 = 0f;
				}
				if (condition())
				{
					if (_003CelapsedTime_003E5__3 < timeoutInSeconds)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num = maxDelay2 - _003CstartTime_003E5__2;
						_003CelapsedTime_003E5__3 = num;
						object obj = this + 12;
						obj = 0;
						_003C_003E1__state = 1;
						return 1;
					}
					return null;
				}
				return null;
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

	private sealed class _003CWaitWhileUnavailableThenCache_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AdLocation _003C_003E4__this;

		private Func<bool> _003CisInitializingFunc_003E5__2;

		private Func<bool> _003CisCachingFunc_003E5__3;

		private int _003CwaitTimeout_003E5__4;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0082: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Expected Obj, but got Unknown
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Expected Obj, but got Unknown
				//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ca: Expected Obj, but got Unknown
				//IL_00da: Unknown result type (might be due to invalid IL or missing references)
				//IL_00df: Expected Obj, but got Unknown
				//IL_0156: Expected Obj, but got I4
				//IL_0437: Unknown result type (might be due to invalid IL or missing references)
				//IL_043c: Expected Obj, but got Unknown
				//IL_0470: Expected Obj, but got I4
				//IL_0479: Expected Obj, but got I4
				//IL_016f: Expected Obj, but got I4
				//IL_017d: Expected Obj, but got I4
				//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01dc: Expected Obj, but got Unknown
				//IL_01ef: Expected F4, but got I4
				//IL_0210: Expected Obj, but got I4
				//IL_0219: Expected Obj, but got I4
				//IL_01cc: Expected Obj, but got I4
				//IL_026b: Expected Obj, but got I4
				//IL_04e7: Expected I, but got Obj
				//IL_04fd: Expected Obj, but got I
				//IL_0378: Expected I, but got Obj
				//IL_03cc: Expected Obj, but got I4
				//IL_0365: Expected Obj, but got I4
				//IL_03ad: Expected Obj, but got I4
				//IL_033c: Expected Obj, but got I4
				//IL_0350: Expected Obj, but got I4
				AdLocation adLocation = _003C_003E4__this;
				object obj;
				object result = default;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							obj = 11;
						}
						else
						{
							obj = 18;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						obj = 8;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					float maxDelay = NetworkServer.maxDelay;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num = 0;
					_ = 0;
					object obj3 = default;
					object obj2 = obj3 + 16;
					obj2 = _003C_003E4__this;
					object obj4 = this + 20;
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num2 = 0;
					_ = 0;
					object obj6 = default;
					object obj5 = obj6 + 16;
					obj5 = _003C_003E4__this;
					object obj7 = this + 24;
					obj7 = obj6;
					int num3 = default;
					if (adLocation._adProvider != null)
					{
						AdLocationInfo info = adLocation.info;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
					}
					else
					{
						num3 = 0;
					}
					_003CwaitTimeout_003E5__4 = num3;
					object obj8 = this + 12;
					AnimationState animationState = ((Animation)null).CrossFadeQueued((string)(object)_003CisInitializingFunc_003E5__2, 5f);
					obj8 = animationState;
					_003C_003E1__state = 1;
					result = 1;
					obj = 18;
				}
				object obj9 = obj;
				Type type = default;
				while (true)
				{
					if ((nint)obj9 == 8)
					{
						adLocation._shouldRestartIsCachingCheck = false;
						if (!_003CisCachingFunc_003E5__3())
						{
							obj9 = 11;
							continue;
						}
						object obj10 = this + 12;
						AnimationState animationState2 = ((Animation)null).CrossFadeQueued((string)(object)_003CisCachingFunc_003E5__3, (float)_003CwaitTimeout_003E5__4);
						obj10 = animationState2;
						_003C_003E1__state = 2;
						result = 1;
						obj9 = 18;
					}
					else if ((nint)obj9 == 11)
					{
						if (~(adLocation._shouldRestartIsCachingCheck ? 1u : 0u) == 0)
						{
							obj9 = 8;
							continue;
						}
						bool flag = _003CisInitializingFunc_003E5__2();
						bool flag2 = _003CisCachingFunc_003E5__3();
						if (adLocation._adProvider != null)
						{
							AbstractAdProvider adProvider = adLocation._adProvider;
							if (adProvider._initState == AbstractAdProvider.InitState.Initialized)
							{
								AdLocationInfo info2 = adLocation.info;
								AdLocationInfo info3 = adLocation.info;
								bool flag3 = _003C_003E4__this.IsCached();
								adLocation._adProvider.FailedToCacheAd(info2.adType, info3.id, (string)flag3);
								result = null;
								obj9 = 18;
								continue;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj11 = ((IConvertible)"Initilisation of provider ").ToType(type, (IFormatProvider)(object)" failed!");
						nint num4 = (nint)typeof(AdSystemLog);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v36 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 == null)
						{
							result = null;
							obj9 = 18;
							continue;
						}
						nint num5 = (nint)typeof(AdSystemLog);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v40 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
						if ((nint)0 != 0)
						{
							result = null;
							obj9 = 18;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							result = null;
							obj9 = 18;
						}
					}
					else if ((nint)obj9 == 18)
					{
						break;
					}
				}
				return result;
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

	private sealed class _003CCacheCoroutine_003Ed__23(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AdLocation _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		private float _003CelapsedTime_003E5__3;

		private double _003CcacheTimeoutLimit_003E5__4;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0596: Unknown result type (might be due to invalid IL or missing references)
				//IL_059b: Expected Obj, but got Unknown
				//IL_05a4: Expected Obj, but got I4
				//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_05b2: Expected Obj, but got Unknown
				//IL_05bb: Expected Obj, but got I4
				//IL_03f8: Expected Obj, but got I4
				//IL_03f8: Expected Obj, but got I4
				//IL_013d: Expected Obj, but got I4
				//IL_013d: Expected Obj, but got I4
				//IL_01e3: Expected Obj, but got I4
				//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ee: Expected Obj, but got Unknown
				//IL_0225: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 8;
				obj2 = 0;
				object obj3 = obj2 + 12;
				obj3 = 0;
				AdLocation adLocation = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
					_003CelapsedTime_003E5__3 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					AdLocationInfo info = adLocation.info;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A7EB");
					object obj4 = default;
					obj2 = obj4;
					double num = (double)obj2 * 1E-07;
					_003CcacheTimeoutLimit_003E5__4 = num;
				}
				if (adLocation._adProvider != null)
				{
					AbstractAdProvider adProvider = adLocation._adProvider;
					if (~(adProvider.isCaching__BackingField ? 1u : 0u) == 0)
					{
						AdLocationInfo info2 = adLocation.info;
						bool flag = adLocation.IsCached();
						IEnumerator enumerator = ((DebugAdProvider)adLocation._adProvider).CacheInterstitialCoroutine((string)info2.adType, (string)flag);
						if (enumerator == null)
						{
							if (!(_003CcacheTimeoutLimit_003E5__4 < (double)_003CelapsedTime_003E5__3))
							{
								float maxDelay2 = NetworkServer.maxDelay;
								float num2 = maxDelay2 - _003CstartTime_003E5__2;
								_003CelapsedTime_003E5__3 = num2;
								int num3 = Util.ConvertTimeoutToMilliseconds(0.5f);
								obj3 = num3;
								object obj5 = this + 12;
								object obj6 = obj3;
								_ = 1;
								IEnumerator enumerator2 = ((Wait.Config)obj3).WaitCoroutine();
								obj5 = enumerator2;
								_003C_003E1__state = 1;
								return 1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							throw new ArrayTypeMismatchException();
						}
					}
				}
				AbstractAdProvider adProvider2 = adLocation._adProvider;
				if (~(adProvider2.isCaching__BackingField ? 1u : 0u) == 0)
				{
					AdLocationInfo info3 = adLocation.info;
					bool flag2 = adLocation.IsCached();
					IEnumerator enumerator3 = ((DebugAdProvider)adLocation._adProvider).CacheInterstitialCoroutine((string)info3.adType, (string)flag2);
					if (enumerator3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						throw new ArrayTypeMismatchException();
					}
				}
				return null;
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

	private const float CHECK_TIMEOUT_INTERVAL = 0.5f;

	private const float INITIALIZE_WAIT_TIME_SECONDS = 5f;

	private AbstractAdProvider _adProvider;

	private IAdSettingsProvider _settingsProvider;

	private DateTime _timeOfLastShow;

	private IEnumerator _cacheCoroutine;

	private bool _shouldRestartIsCachingCheck;

	private IEnumerator _unavailableCoroutine;

	public readonly AdLocationInfo info;

	public readonly string waterfallID;

	private bool hasProvider
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			bool result = default;
			return result;
		}
	}

	public bool isCaching => _adProvider != null;

	public AdLocation(AdLocationInfo info, string waterfallID)
	{
	}

	public void SetSettingsProvider(IAdSettingsProvider settingsProvider)
	{
	}

	public void SetAdProvider(AbstractAdProvider adProvider)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = adProvider;
	}

	private string GetCacheId()
	{
		//IL_003c: Expected Obj, but got I4
		if (_adProvider != null)
		{
			bool flag = _adProvider.HasCachedVideo((string)(object)info);
			return (string)flag;
		}
		return null;
	}

	public bool IsCached()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
		bool result = default;
		return result;
	}

	public bool Show()
	{
		//IL_004b: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I4
		//IL_005c: Expected I4, but got Obj
		if (_adProvider != null)
		{
			AdLocationInfo adLocationInfo = info;
			bool flag = IsCached();
			IEnumerator enumerator = ((DebugAdProvider)_adProvider).CacheInterstitialCoroutine((string)adLocationInfo.adType, (string)flag);
			return (byte)(int)enumerator != 0;
		}
		return false;
	}

	public void Cache()
	{
	}

	private IEnumerator WaitWhileConditionOrUntilTimedOut(Func<bool> condition, float timeoutInSeconds)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 24;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = condition;
		return enumerator;
	}

	private IEnumerator WaitWhileUnavailableThenCache()
	{
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0250: Expected I4, but got Obj
		//IL_0262: Expected I, but got Obj
		//IL_0278: Expected Obj, but got I
		//IL_02a3: Expected I, but got Obj
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0371: Expected I, but got Obj
		//IL_0387: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_048f: Expected Obj, but got VT
		//IL_04b9: Expected Obj, but got VT
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_00f9: Expected I, but got Obj
		//IL_0415: Expected Obj, but got VT
		//IL_041d: Expected Obj, but got VT
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_0195: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I4
		//IL_021d: Expected I4, but got Obj
		//IL_021d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 56;
		object obj3 = obj2 + 48;
		object obj4 = obj2 + 40;
		object obj5 = obj2 + 32;
		object obj6 = obj2 + 24;
		object obj7 = obj2 + 16;
		object obj8 = obj2 + 8;
		if (_adProvider != null)
		{
			AdLocationInfo adLocationInfo = info;
			AdLocationInfo adLocationInfo2 = info;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A7EB");
			AdLocationInfo adLocationInfo3 = info;
			bool flag;
			if (adLocationInfo3.adType != AdType.Interstitial)
			{
				flag = false;
			}
			else
			{
				nint num = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v92 (Il2CppClass<Globals>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num2 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v100 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				flag = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT;
			}
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<System.DateTime>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v87 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime utcNow = DateTime.UtcNow;
			obj4 = _timeOfLastShow;
			object obj11 = default;
			obj5 = obj11;
			obj3 = obj4;
			obj = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
			obj6 = utcNow;
			object obj12 = default;
			obj7 = obj12;
			obj3 = obj6;
			obj = obj7;
			object obj13 = obj3 & 0x3FFFFFFFFFFFFFFFL;
			object obj14 = obj & 0x3FFFFFFFFFFFFFFFL;
			bool flag2;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
			{
				flag2 = true;
			}
			else
			{
				nint num5 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v68 (Il2CppClass<System.DateTime>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num6 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v82 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime utcNow2 = DateTime.UtcNow;
				obj8 = _timeOfLastShow;
				obj2 = utcNow2;
				obj3 = obj8;
				obj = obj2;
				object obj16 = obj3 & 0x3FFFFFFFFFFFFFFFL;
				object obj17 = obj & 0x3FFFFFFFFFFFFFFFL;
				flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
			}
			object obj18 = flag2 | flag;
			object obj19 = obj18 + 15;
			object obj20 = obj19 & 0xF;
			if (obj20 != null)
			{
				return null;
			}
			AdLocationInfo adLocationInfo4 = info;
			AdLocationInfo adLocationInfo5 = info;
			bool flag3 = IsCached();
			return (IEnumerator)((AdController)(object)_adProvider).CreatePriorityListForID((string)adLocationInfo4.adType, (AdType)adLocationInfo5.id, (IAdSettingsProvider)flag3);
		}
		AdLocationInfo adLocationInfo6 = info;
		string text = string.ConcatArray((string[])(object)"Provider was null for location: ", (int)adLocationInfo6.id);
		nint num7 = (nint)typeof(AdSystemLog);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v16 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num8 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v21 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DebugAdGUI)(object)text).Awake();
		return null;
	}

	private IEnumerator CacheCoroutine()
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

	public override void StartedCachingAd(AdType adType, string providerID, string adLocationID)
	{
	}

	public override void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_0074: Expected I4, but got Obj
		if (_adProvider != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text = default;
			if (text != newProvider)
			{
				AdLocationInfo adLocationInfo = info;
				if (changedWaterfallID.get_Chars((int)adLocationInfo.id) != '\0')
				{
					_shouldRestartIsCachingCheck = true;
				}
			}
		}
		AdLocationInfo adLocationInfo2 = info;
		if (adLocationInfo2.id != changedWaterfallID)
		{
			CoroutineUtil.StopCoroutine((Coroutine)(object)_cacheCoroutine);
			object obj = this + 24;
			bool flag = _003CWaitWhileUnavailableThenCache_003Eb__22_0();
			obj = flag;
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_cacheCoroutine);
		}
	}

	public override void DismissedAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00b6: Expected I, but got Obj
		if (_adProvider == null)
		{
			return;
		}
		AdLocationInfo adLocationInfo = info;
		if (adLocationInfo.adType != adType || !(waterfallID != adLocationID))
		{
			return;
		}
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool allowReCacheOnFail = ((AdController)(object)providerID).allowReCacheOnFail;
		((AdProviderConfiguration)(object)this).isRestricted = allowReCacheOnFail;
	}

	public override void FinishedWatchingVideo(string providerID, string adLocationID)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		object obj = this + 36;
		obj = providerID;
		object obj2 = this + 40;
		obj2 = adLocationID;
	}

	public override void FailedToShowAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_000e: Expected I4, but got Obj
		//IL_000e: Expected I4, but got Obj
		((DebugAdGUI)(object)this).SetGuiProperties((int)providerID, (int)adLocationID);
	}

	public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_000e: Expected I4, but got Obj
		//IL_000e: Expected I4, but got Obj
		((DebugAdGUI)(object)this).SetGuiProperties((int)providerID, (int)adLocationID);
	}

	private void MakeSureAdIsCached(string providerID, string adLocationId)
	{
		//IL_000e: Expected I4, but got Obj
		//IL_000e: Expected I4, but got Obj
		((DebugAdGUI)(object)this).SetGuiProperties((int)providerID, (int)adLocationId);
	}

	public override void ShowedAd(AdType adType, string providerID, string adLocationID)
	{
		if (_adProvider == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string text = default;
		if (providerID != text)
		{
			AdLocationInfo adLocationInfo = info;
			if (adLocationInfo.adType != adType)
			{
				_shouldRestartIsCachingCheck = true;
			}
		}
	}

	private bool _003CWaitWhileUnavailableThenCache_003Eb__22_0()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	private bool _003CWaitWhileUnavailableThenCache_003Eb__22_1()
	{
		if (_adProvider != null)
		{
			AbstractAdProvider adProvider = _adProvider;
			return adProvider._initState == AbstractAdProvider.InitState.Initializing;
		}
		return false;
	}
}
