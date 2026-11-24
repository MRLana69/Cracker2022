using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Backend;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.JsonUtil;
using Kiloo.Common.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Kiloo.Common.Ads;

public class AdController
{
	private class CacheList
	{
		public readonly List<AdLocation> list;

		public readonly int capacity;

		private int _locationToShowNext;

		public int count
		{
			get
			{
				//IL_000a: Expected I4, but got Obj
				return (int)((IEnumerable)this).GetEnumerator();
			}
		}

		public CacheList(int capacity)
		{
			//IL_000a: Expected Obj, but got I4
			list = (List<AdLocation>)capacity;
			bool hasShutdownStarted = Environment.HasShutdownStarted;
			_locationToShowNext = (hasShutdownStarted ? 1 : 0);
		}

		public void Add(AdLocation location)
		{
			//IL_000f: Expected I4, but got Obj
			//IL_0026: Expected I4, but got Obj
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			capacity = (int)location;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<AdLocation> list = default;
			list._002Ector((int)location);
			object obj = this + 8;
			obj = list;
		}

		public AdLocation GetLocationToShow()
		{
			//IL_0019: Expected Obj, but got I4
			List<AdLocation> list = this.list;
			return (AdLocation)list._size;
		}

		public void AdvanceShowPointer()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public class EventHandler : AdEventListenerAdapter
	{
		private AdController _controller;

		public EventHandler(AdController controller)
		{
			((List<AdLocation>)(object)_controller).Add((AdLocation)(object)controller);
		}

		public override void ShowedAd(AdType adType, string providerID, string adLocationID)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector("This event should not be invoked by the ad provider!");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		public override void FailedToInitAdProvider(string providerID)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = providerID;
		}

		public override void CachingTimedOut(AdType adType, string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_069c: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a1: Expected Obj, but got Unknown
			//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_06af: Expected Obj, but got Unknown
			//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bd: Expected Obj, but got Unknown
			//IL_06c6: Expected Obj, but got I4
			//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06da: Expected Obj, but got Unknown
			//IL_0700: Expected I, but got Obj
			//IL_0716: Expected Obj, but got I
			//IL_0789: Expected Obj, but got VT
			//IL_079e: Expected VT, but got Obj
			//IL_00b6: Expected I, but got Obj
			//IL_075e: Expected Obj, but got VT
			//IL_0773: Expected VT, but got Obj
			//IL_0045: Expected I, but got Obj
			//IL_0600: Expected I4, but got Obj
			//IL_0612: Expected I, but got Obj
			//IL_0628: Expected Obj, but got I
			//IL_05db: Expected Obj, but got I
			//IL_0653: Expected I, but got Obj
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Expected Obj, but got Unknown
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Expected Obj, but got Unknown
			//IL_01d7: Expected Obj, but got I4
			//IL_01e0: Expected Obj, but got I4
			//IL_040c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0411: Expected Obj, but got Unknown
			//IL_041a: Unknown result type (might be due to invalid IL or missing references)
			//IL_041f: Expected Obj, but got Unknown
			//IL_044b: Expected Obj, but got I4
			//IL_0454: Expected Obj, but got I4
			//IL_029f: Expected Obj, but got I
			//IL_0513: Expected Obj, but got I
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected Obj, but got Unknown
			//IL_0551: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Expected Obj, but got Unknown
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Expected Obj, but got Unknown
			//IL_0587: Unknown result type (might be due to invalid IL or missing references)
			//IL_058c: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 16;
			object obj4 = obj2 + 8;
			object obj5 = obj2 + 40;
			obj5 = 0;
			_ = 0;
			object obj6 = obj2 + 32;
			obj6 = obj;
			_ = -1;
			AdController controller = _controller;
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v24 (Il2CppClass<System.DateTime>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			bool flag = obj7 == null;
			if (adType == AdType.Video)
			{
				if (!flag)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v227 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime utcNow = DateTime.UtcNow;
				obj4 = utcNow;
				obj3 = obj4;
				controller._timeOfLastVideo = (DateTime)obj3;
			}
			else
			{
				if (!flag)
				{
					nint num3 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v217 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime utcNow2 = DateTime.UtcNow;
				obj2 = utcNow2;
				obj3 = obj2;
				controller._timeOfLastInterstitial = (DateTime)obj3;
				AdController controller2 = _controller;
				InterstitialStats interstitialStats = controller2._interstitialStats;
				int num4 = interstitialStats.seenThisHour__BackingField + 1;
				interstitialStats.seenThisHour__BackingField = num4;
				int num5 = interstitialStats.seenThisDay__BackingField + 1;
				interstitialStats.seenThisDay__BackingField = num5;
				if (~(interstitialStats.hasSeenFirstInterstitial__BackingField ? 1u : 0u) != 0)
				{
					interstitialStats.hasSeenFirstInterstitial__BackingField = true;
				}
				AdController controller3 = _controller;
				AdController controller4 = _controller;
				if (((PriorityList)(object)controller3._interstitialStats)._003CChangeToNextProvider_003Eb__35_0((AdProviderInfo)controller4._settings))
				{
					AdController controller5 = _controller;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
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
						AdController controller6 = _controller;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					}
					object obj9 = obj6 + 4;
					object obj10 = obj9 + 1;
					obj9 = obj10;
					object obj11 = obj10 << 2;
					object obj12 = obj6 + obj11;
					obj12 = 259;
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
						object obj14 = (nint)0 << 2;
						object obj15 = obj6 + obj14;
						if ((nint)obj15 == 259)
						{
							object obj16 = obj6 + 4;
							if ((nint)obj16 > -1)
							{
								object obj17 = obj16 + -1;
								obj16 = obj17;
							}
							goto IL_0895;
						}
					}
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
						goto IL_05a8;
					}
				}
				AdController controller7 = _controller;
				AdController controller8 = _controller;
				if (controller7._interstitialStats.ReachedDailyLimit(controller8._settings))
				{
					AdController controller9 = _controller;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
					obj5 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					object obj18 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj18 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						AdController controller10 = _controller;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					}
					object obj19 = obj6 + 4;
					object obj20 = obj19 + 1;
					obj19 = obj20;
					object obj21 = obj20 << 2;
					object obj22 = obj6 + obj21;
					obj22 = 259;
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
						object obj24 = (nint)0 << 2;
						object obj25 = obj6 + obj24;
						if ((nint)obj25 == 259)
						{
							object obj26 = obj6 + 4;
							if ((nint)obj26 > -1)
							{
								object obj27 = obj26 + -1;
								obj26 = obj27;
							}
							goto IL_0895;
						}
					}
					if (obj23 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
						goto IL_05a8;
					}
				}
			}
			goto IL_0895;
			IL_05a8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			goto IL_0895;
			IL_0895:
			if (((DebugAdProvider)(object)_controller).HasCachedInterstitial(adLocationID))
			{
				AdController controller11 = _controller;
				Dictionary<string, PriorityList> idToPriorityList = controller11._idToPriorityList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v33 (System.Boolean)+28]");
				PriorityList priorityList = idToPriorityList.get_Item((string)0);
				priorityList.CheckIfProviderExpired();
				return;
			}
			string text = string.ConcatArray((string[])(object)"Unknown ad location ", (int)adLocationID);
			nint num6 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v19 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num7 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S1_v24 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text).Awake();
		}

		public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}

		public override void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((AbstractAdProvider._003CGetAbstractAdProviderSubTypes_003Ed__44)(object)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 56)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		private unsafe bool IncrementFailCount(string waterfallID)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected I, but got Unknown
			//IL_00bc: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v20 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object typeFromHandle = typeof(AbstractAdProvider);
			nint num3 = (nint)(typeFromHandle + 4);
			((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
			Type type = Type.internal_from_handle((IntPtr)num3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			bool result = default;
			return result;
		}

		public override void FailedToShowAd(AdType adType, string providerID, string adLocationID)
		{
			//IL_0069: Expected I4, but got Obj
			//IL_0069: Expected I4, but got Obj
			//IL_0069: Expected I4, but got Obj
			//IL_007b: Expected I, but got Obj
			//IL_0091: Expected Obj, but got I
			//IL_00b7: Expected Obj, but got I4
			//IL_00c5: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			int num = "Failed to cache ".IndexOf((char)(int)adLocationID, (int)", ", (int)providerID);
			nint num2 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v10 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)num).Awake();
			((CloudWorkingCopy.LocalItem.GetDataStreamFunction)(object)this)._002Ector((object)providerID, (IntPtr)adLocationID);
		}

		private void HandleFail(string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((AbstractAdProvider._003CGetAbstractAdProviderSubTypes_003Ed__44)(object)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 53)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public AdType adType;

		public _003C_003Ec__DisplayClass29_0()
		{
			//IL_0016: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdController+<>c__DisplayClass29_0)+10]");
			object obj = (nint)0 + (nint)1;
			AdLocation locationToShow = ((CacheList)this).GetLocationToShow();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdController+<>c__DisplayClass29_0)+10]");
			if (0 >= (nint)locationToShow)
			{
				_ = 0;
			}
		}

		internal bool _003CIsCached_003Eb__0(AdLocation location)
		{
			//IL_0024: Expected Obj, but got I
			AdType adType = this.adType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (Kiloo.Common.Ads.AdType)+10]");
			PriorityList priorityList = ((Dictionary<string, PriorityList>)0).get_Item((string)(object)location);
			return ((AbstractListAdapter)(object)priorityList).HasStableIds();
		}
	}

	private sealed class _003CCheckCacheExpiredCoroutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_065d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0662: Expected Obj, but got Unknown
				//IL_066b: Expected Obj, but got I4
				//IL_067a: Unknown result type (might be due to invalid IL or missing references)
				//IL_067f: Expected Obj, but got Unknown
				//IL_0688: Expected Obj, but got I4
				//IL_0697: Unknown result type (might be due to invalid IL or missing references)
				//IL_069c: Expected Obj, but got Unknown
				//IL_062e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0633: Expected Obj, but got Unknown
				//IL_064f: Expected Obj, but got I4
				//IL_009a: Expected Obj, but got I4
				//IL_0464: Unknown result type (might be due to invalid IL or missing references)
				//IL_0469: Expected Obj, but got Unknown
				//IL_0472: Unknown result type (might be due to invalid IL or missing references)
				//IL_0477: Expected Obj, but got Unknown
				//IL_04a3: Expected Obj, but got I4
				//IL_053c: Expected Obj, but got I
				//IL_0572: Unknown result type (might be due to invalid IL or missing references)
				//IL_0577: Expected Obj, but got Unknown
				//IL_021b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0220: Expected Obj, but got Unknown
				//IL_0229: Unknown result type (might be due to invalid IL or missing references)
				//IL_022e: Expected I, but got Unknown
				//IL_0236: Expected Obj, but got I
				//IL_0244: Expected Obj, but got I
				//IL_025a: Expected Obj, but got I4
				//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_05ad: Expected Obj, but got Unknown
				//IL_012d: Expected Obj, but got I
				//IL_0317: Expected Obj, but got I
				//IL_03ac: Expected Obj, but got I4
				//IL_034d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0352: Expected Obj, but got Unknown
				//IL_0383: Unknown result type (might be due to invalid IL or missing references)
				//IL_0388: Expected Obj, but got Unknown
				//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ca: Expected Obj, but got Unknown
				//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d8: Expected Obj, but got Unknown
				//IL_0204: Expected Obj, but got I4
				//IL_020d: Expected Obj, but got I4
				Dictionary<, >.ValueCollection valueCollection = default;
				object obj = valueCollection - -64;
				object obj2 = valueCollection + 40;
				obj2 = 0;
				_ = 0;
				object obj3 = valueCollection + 24;
				obj3 = 0;
				_ = 0;
				IAdSettingsProvider adSettingsProvider = (IAdSettingsProvider)(valueCollection + 16);
				adSettingsProvider = (IAdSettingsProvider)obj;
				_ = -1;
				AdController adController = _003C_003E4__this;
				object obj27 = default;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE18");
						_00211 item = default;
						((ICollection<TValue>)valueCollection).Add((TValue)item);
						obj2 = valueCollection;
						_ = valueCollection.dictionary;
						object obj4 = 0;
						object obj5 = default;
						object obj6 = default;
						object obj8 = default;
						object obj9 = default;
						object obj10 = default;
						object obj19 = default;
						object obj21 = default;
						object obj23 = default;
						object obj24 = default;
						object obj25 = default;
						object obj26 = default;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if (obj5 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj3 = valueCollection;
								_ = valueCollection.dictionary;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									if (obj6 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v177 (Il2CppClass<Kiloo.Common.Ads.IAdSettingsProvider>)+24]");
										object obj7 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
										if (obj8 == null)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										if (obj9 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
											if (obj10 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
												object obj11 = adSettingsProvider + 4;
												IAdSettingsProvider adSettingsProvider2 = (IAdSettingsProvider)(obj11 + 1);
												obj11 = adSettingsProvider2;
												object obj12 = (object)adSettingsProvider2 << 2;
												object obj13 = (object)adSettingsProvider + obj12;
												obj13 = 195;
												obj4 = 1;
												break;
											}
										}
										continue;
									}
									IAdSettingsProvider adSettingsProvider3 = (IAdSettingsProvider)(adSettingsProvider + 4);
									nint num = (nint)(adSettingsProvider3 + 1);
									adSettingsProvider3 = (IAdSettingsProvider)num;
									object obj14 = num << 2;
									object obj15 = (object)adSettingsProvider + obj14;
									obj15 = 195;
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Kiloo.Common.Ads.IAdSettingsProvider)+4]");
								if ((nint)0 != -1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Kiloo.Common.Ads.IAdSettingsProvider)+4]");
									object obj16 = (nint)0 << 2;
									object obj17 = (object)adSettingsProvider + obj16;
									if ((nint)obj17 == 195)
									{
										IAdSettingsProvider adSettingsProvider4 = (IAdSettingsProvider)(adSettingsProvider + 4);
										if ((nint)adSettingsProvider4 > -1)
										{
											object obj18 = adSettingsProvider4 + -1;
											adSettingsProvider4 = (IAdSettingsProvider)obj18;
										}
										continue;
									}
								}
								if (obj19 == null)
								{
									obj19 = 0;
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj20 = obj21;
								object obj22 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
								if (obj20 == obj24)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
									obj25 = obj26;
									obj27 = obj4;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
								}
								break;
							}
							object obj28 = adSettingsProvider + 4;
							object obj29 = obj28 + 1;
							obj28 = obj29;
							object obj30 = obj29 << 2;
							object obj31 = (object)adSettingsProvider + obj30;
							obj31 = 220;
							obj25 = obj19;
							obj27 = obj4;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Kiloo.Common.Ads.IAdSettingsProvider)+4]");
						if ((nint)0 != -1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v11 (Kiloo.Common.Ads.IAdSettingsProvider)+4]");
							object obj32 = (nint)0 << 2;
							object obj33 = (object)adSettingsProvider + obj32;
							if ((nint)obj33 == 220)
							{
								object obj34 = adSettingsProvider + 4;
								if ((nint)obj34 > -1)
								{
									object obj35 = obj34 + -1;
									obj34 = obj35;
								}
								goto IL_075d;
							}
						}
						if (obj25 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
						}
						goto IL_075d;
					}
					return null;
				}
				_003C_003E1__state = -1;
				float dpi = Screen.dpi;
				float num2 = dpi;
				goto IL_0619;
				IL_0619:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj36 = this + 12;
				object obj37 = default;
				obj36 = obj37;
				_003C_003E1__state = 1;
				return 1;
				IL_075d:
				float num3 = ((obj27 == null) ? adExpiryMinCheckInterval : Screen.dpi);
				num2 = num3;
				goto IL_0619;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CCheckCacheExpiredCoroutine_003Ed__31(int _003C_003E1__state)
		{
			//IL_0072: Expected I, but got Obj
			//IL_0088: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			string text = string.ConcatArray((string[])(object)"Failed to initialize ad provider ", _003C_003E1__state);
			nint num = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text).Awake();
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0016: Expected I4, but got Obj
			//IL_0016: Expected Obj, but got I4
			//IL_001a: Expected I4, but got Obj
			return (byte)(int)((List<AdLocation>)_003C_003E1__state).get_Item((int)_003C_003E4__this) != 0;
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<AdLocation> _003C_003E9__33_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AbstractAdProvider._003C_003Ec obj = default;
			AbstractAdProvider._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal bool _003CShow_003Eb__33_0(AdLocation location)
		{
			AdLocationInfo info = location.info;
			AdType adType = info.adType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdController+<>c)+8]");
			if ((nint)adType == (nint)0)
			{
				AdLocationInfo info2 = location.info;
				if (~(info2.isPoolLocation ? 1u : 0u) == 0)
				{
					return location.Show();
				}
				return false;
			}
			return false;
		}
	}

	private readonly IAdSettingsProvider _settings;

	private readonly List<AdLocation> _adLocations;

	private readonly Dictionary<string, PriorityList> _idToPriorityList;

	private DateTime _timeOfLastVideo;

	private DateTime _timeOfLastInterstitial;

	private InterstitialStats _interstitialStats;

	private List<IAdEventListener> _eventListeners;

	private const int DEFAULT_NUMBER_OF_VIDEO_ADS_TO_CACHE = 2;

	private const int DEFAULT_NUMBER_OF_INTERSTITIALS_TO_CACHE = 1;

	private const string ONLINE_SETTINGS_KEY_NUMBER_OF_VIDEO_ADS_TO_CACHE = "video_ads_cache_pool_size";

	private const string ONLINE_SETTINGS_KEY_NUMBER_OF_INTERSTITIALS_TO_CACHE = "interstitial_ads_cache_pool_size";

	private const float DEFAULT_AD_EXPIRY_MIN_CHECK_INTERVAL = 10f;

	private const float DEFAULT_AD_EXPIRY_MAX_CHECK_INTERVAL = 30f;

	private const string ONLINE_SETTINGS_KEY_AD_MIN_EXPIRY_CHECK_INTERVAL = "ad_expiry_min_check_interval";

	private const string ONLINE_SETTINGS_KEY_AD_MAX_EXPIRY_CHECK_INTERVAL = "ad_expiry_max_check_interval";

	private readonly Dictionary<AdType, CacheList> _cacheLists;

	private bool allowReCacheOnFail__BackingField;

	private static float adExpiryMaxCheckInterval
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return KilooWebClient.defaultMaxBackOffTime__BackingField;
		}
	}

	private static float adExpiryMinCheckInterval
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00af: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			return ((LayoutGroup)(object)saveDataPath).GetStartOffset((int)"ad_expiry_max_check_interval", 30f);
		}
	}

	public bool allowReCacheOnFail
	{
		get
		{
			//IL_01a5: Expected I, but got Obj
			//IL_01bb: Expected Obj, but got I
			//IL_0239: Expected Obj, but got I
			//IL_0249: Expected Obj, but got I
			//IL_0259: Expected Obj, but got I
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Expected Obj, but got Unknown
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Expected Obj, but got Unknown
			//IL_0105: Expected I4, but got Obj
			//IL_0117: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0158: Expected I, but got Obj
			//IL_00f5: Expected I4, but got Obj
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IEnumerable<Type> abstractAdProviderSubTypes = AbstractAdProvider.GetAbstractAdProviderSubTypes();
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v4+44]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S3_v4 (should have been resolved before IL gen)");
			object obj7 = default;
			if ((nint)obj7 > -1)
			{
				nint num4 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v20 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num5 = (nint)typeof(AbstractAdProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v28 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				IEnumerable<Type> abstractAdProviderSubTypes2 = AbstractAdProvider.GetAbstractAdProviderSubTypes();
				AbstractAdProvider abstractAdProvider = ((Dictionary<string, AbstractAdProvider>)abstractAdProviderSubTypes2).get_Item((string)(object)this);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				Dictionary<AdLocationInfo, string> cacheIDs = default;
				abstractAdProvider.CheckHasCacheIDs(cacheIDs);
				return (byte)(int)abstractAdProvider != 0;
			}
			string text = string.ConcatArray((string[])(object)"Unknown provider ID ", (int)this);
			nint num6 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v8 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v13 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text).Awake();
			return false;
		}
		set
		{
			//IL_0017: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text = default;
			if ((string)value != text)
			{
				_interstitialStats = null;
			}
		}
	}

	public AdController(IAdSettingsProvider settings, ICollection<AdLocationInfo> adLocations, InterstitialStats interstitialStats)
	{
		//IL_000a: Expected I4, but got Obj
		allowReCacheOnFail = (byte)(int)adLocations != 0;
	}

	public void UpdateInterstitialStats(InterstitialStats stats)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(stats & 1) != 0;
		allowReCacheOnFail__BackingField = flag;
	}

	public void AddEventListener(IAdEventListener eventListener)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 40;
		obj = eventListener;
	}

	public void RemoveEventListener(IAdEventListener eventListener)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AbstractAdProvider.RemoveEventListener(eventListener);
		_eventListeners.Add(eventListener);
	}

	public bool IsCachedDebug(AdLocationInfo adLocationInfo)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type type = default;
		object message = ((IConvertible)"Ad provider ").ToType(type, (IFormatProvider)(object)", does not support interstitials");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector((string)message);
		((AbstractAdProvider)(object)ex).HasCachedInterstitial((string)null);
		return false;
	}

	public bool IsCached(AdType adType)
	{
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [adType @ L1 (Kiloo.Common.Ads.AdType)+8]");
			bool flag = ((DebugAdProvider)this).HasCachedInterstitial((string)0);
			if (flag)
			{
				return ((AdLocation)flag).Show();
			}
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [adType @ L1 (Kiloo.Common.Ads.AdType)+C]");
		return IsCaching((string)0);
	}

	public bool IsCaching(string adLocationID)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = default;
		obj = obj3;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S2_v8 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v9+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v10+68]");
		object obj6 = 0;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S3_v4 (should have been resolved before IL gen)");
		object obj9 = default;
		return (nint)obj9 != -1;
	}

	private IEnumerator CheckCacheExpiredCoroutine()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = allowReCacheOnFail__BackingField;
		return (IEnumerator)flag;
	}

	public void Cache(AdLocation specificLocation = null)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AbstractAdProvider)(object)specificLocation)._002Ector();
		bool flag = _eventListeners.Remove(specificLocation);
	}

	public bool Show(string adLocationID)
	{
		//IL_0056: Expected I4, but got Obj
		//IL_0068: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_0117: Expected I4, but got Obj
		//IL_0035: Expected Obj, but got I4
		bool flag = ((DebugAdProvider)this).HasCachedInterstitial(adLocationID);
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj = default;
			string text = ((obj == null) ? null : ((AdLocation)flag).GetCacheId());
			return (byte)(int)text != 0;
		}
		string text2 = string.ConcatArray((string[])(object)"Unknown ad location ID ", (int)adLocationID);
		nint num = (nint)typeof(AdSystemLog);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v6 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v11 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DebugAdGUI)(object)text2).Awake();
		return false;
	}

	public void ChangeToNextProvider()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I
		//IL_0085: Expected Obj, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = "undetermined";
		object obj2 = this + 12;
		obj2 = "undetermined";
		object obj3 = this + 16;
		obj3 = "undetermined";
		object obj4 = this + 20;
		obj4 = "undetermined";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v3+60]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S4_v4 (should have been resolved before IL gen)");
		object obj10 = this + 32;
		object obj11 = default;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj13 = default;
		object obj12 = obj13 + 20;
		obj12 = 1;
		object obj14 = this + 36;
		obj14 = obj13;
	}

	public string GetInfo()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = this;
		return text;
	}

	public void SetDebugPriorityListVersion(AdType adtype, string version)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type type = default;
		object message = ((IConvertible)"Ad provider ").ToType(type, (IFormatProvider)(object)", does not support videos");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector((string)message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public string GetCurrentProviderIDForLocation(string locationID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected Obj, but got Unknown
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd4: Expected Obj, but got Unknown
		//IL_0cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected Obj, but got Unknown
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected Obj, but got Unknown
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Expected Obj, but got Unknown
		//IL_0d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Expected Obj, but got Unknown
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected Obj, but got Unknown
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected Obj, but got Unknown
		//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected Obj, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected Obj, but got Unknown
		//IL_0d4d: Expected Obj, but got I4
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected Obj, but got Unknown
		//IL_0d64: Expected Obj, but got I4
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d78: Expected Obj, but got Unknown
		//IL_0c26: Expected I4, but got Obj
		//IL_0c38: Expected I, but got Obj
		//IL_0c4e: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I
		//IL_0c79: Expected I, but got Obj
		//IL_036e: Expected Obj, but got I
		//IL_0390: Expected Obj, but got I
		//IL_0e56: Expected Obj, but got I
		//IL_03fa: Expected I, but got Obj
		//IL_0410: Expected Obj, but got I
		//IL_0e94: Expected I, but got Obj
		//IL_0eaa: Expected Obj, but got I
		//IL_043b: Expected I, but got Obj
		//IL_11a5: Expected Obj, but got VT
		//IL_11cf: Expected Obj, but got VT
		//IL_11f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f9: Expected Obj, but got Unknown
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Expected Obj, but got Unknown
		//IL_04e3: Expected I, but got Obj
		//IL_04f9: Expected Obj, but got I
		//IL_0488: Expected I, but got Obj
		//IL_0f25: Expected Obj, but got VT
		//IL_0f2d: Expected Obj, but got VT
		//IL_0f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Expected Obj, but got Unknown
		//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f61: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0eec: Expected Obj, but got I4
		//IL_0524: Expected I, but got Obj
		//IL_0dba: Expected Obj, but got VT
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de4: Expected Obj, but got Unknown
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Expected Obj, but got Unknown
		//IL_0823: Expected Obj, but got I
		//IL_084c: Expected I, but got Obj
		//IL_0862: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_1248: Expected Obj, but got I
		//IL_1258: Expected Obj, but got I
		//IL_1268: Expected Obj, but got I
		//IL_1271: Unknown result type (might be due to invalid IL or missing references)
		//IL_1276: Expected Obj, but got Unknown
		//IL_127f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1284: Expected Obj, but got Unknown
		//IL_088d: Expected I, but got Obj
		//IL_0a72: Expected Obj, but got I4
		//IL_08da: Expected I, but got Obj
		//IL_08f0: Expected Obj, but got I
		//IL_1007: Unknown result type (might be due to invalid IL or missing references)
		//IL_100c: Expected Obj, but got Unknown
		//IL_1023: Expected I, but got Obj
		//IL_1039: Expected Obj, but got I
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected Obj, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected Obj, but got Unknown
		//IL_06c6: Expected Obj, but got I4
		//IL_06cf: Expected Obj, but got I4
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_020a: Expected Obj, but got I4
		//IL_099c: Expected I, but got Obj
		//IL_09b2: Expected Obj, but got I
		//IL_091b: Expected I, but got Obj
		//IL_1133: Expected I, but got Obj
		//IL_1149: Expected Obj, but got I
		//IL_1073: Expected I, but got Obj
		//IL_1089: Expected Obj, but got I
		//IL_0b3c: Expected I, but got Obj
		//IL_0b52: Expected Obj, but got I
		//IL_09dd: Expected I, but got Obj
		//IL_077e: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got I
		//IL_0bca: Expected I, but got Obj
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Expected Obj, but got Unknown
		//IL_0af4: Expected Obj, but got I4
		//IL_0a2a: Expected I, but got Obj
		//IL_05fa: Expected F8, but got I4
		//IL_0b7d: Expected I, but got Obj
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_0637: Expected F8, but got I4
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_0674: Expected F8, but got I4
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 128;
		object obj3 = obj2 + 80;
		object obj4 = obj2 + 72;
		object obj5 = obj2 - -64;
		object obj6 = obj2 + 56;
		object obj7 = obj2 + 48;
		object obj8 = obj2 + 32;
		object obj9 = obj2 + 24;
		object obj10 = obj2 + 16;
		object obj11 = obj2 + 8;
		object obj12 = obj2 + 40;
		obj12 = 0;
		object obj13 = obj2 + 104;
		obj13 = 0;
		_ = 0;
		object obj14 = obj2 + 96;
		obj14 = obj;
		_ = -1;
		if (((DebugAdProvider)this).HasCachedInterstitial(locationID))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38 (System.Boolean)+24]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v46+C]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj16 = default;
				if (obj16 == null || _interstitialStats.ReachedHourlyLimit(_settings))
				{
					goto IL_0dad;
				}
				InterstitialStats interstitialStats = _interstitialStats;
				if (!interstitialStats.hasSeenFirstInterstitial__BackingField)
				{
					DateTime today = CDateTime.Today;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
					nint num = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v286 (Il2CppClass<System.DateTime>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num2 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v370 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj5 = today;
					object obj18 = default;
					obj6 = obj18;
					obj4 = obj5;
					obj3 = obj6;
					object obj19 = obj4 & 0x3FFFFFFFFFFFFFFFL;
					object obj20 = obj3 & 0x3FFFFFFFFFFFFFFFL;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
						obj13 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						_ = 0;
						object obj21 = default;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if (obj21 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
						}
						object obj22 = obj14 + 4;
						object obj23 = obj22 + 1;
						obj22 = obj23;
						object obj24 = obj23 << 2;
						object obj25 = obj14 + obj24;
						obj25 = 196;
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v35+4]");
						if ((nint)0 != -1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v35+4]");
							object obj27 = (nint)0 << 2;
							object obj28 = obj14 + obj27;
							if ((nint)obj28 == 196)
							{
								object obj29 = obj14 + 4;
								if ((nint)obj29 > -1)
								{
									object obj30 = obj29 + -1;
									obj29 = obj30;
								}
								goto IL_0dad;
							}
						}
						if (obj26 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
						}
						goto IL_0dad;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38 (System.Boolean)+24]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @ABDA");
			object obj32 = default;
			obj12 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38 (System.Boolean)+24]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v53+C]");
			DateTime dateTime = (((nint)0 != 1) ? _timeOfLastInterstitial : _timeOfLastVideo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38 (System.Boolean)+24]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v58+C]");
			bool flag;
			if ((nint)0 == 1)
			{
				flag = false;
			}
			else
			{
				nint num3 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v253 (Il2CppClass<Globals>)+BA]");
				object obj35 = (nint)0 & (nint)0x200;
				if (obj35 != null)
				{
					nint num4 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v261 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				flag = Globals.DEBUG_INTERSTITIAL_PROVIDERS_IGNORE_TIME_LIMIT;
			}
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v63 (Il2CppClass<System.DateTime>)+BA]");
			object obj36 = (nint)0 & (nint)0x200;
			if (obj36 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v248 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime utcNow = DateTime.UtcNow;
			obj7 = dateTime;
			obj8 = obj12;
			obj4 = obj7;
			obj3 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
			obj9 = utcNow;
			object obj37 = default;
			obj10 = obj37;
			obj4 = obj9;
			obj3 = obj10;
			object obj38 = obj4 & 0x3FFFFFFFFFFFFFFFL;
			object obj39 = obj3 & 0x3FFFFFFFFFFFFFFFL;
			bool flag2;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39))
			{
				flag2 = true;
			}
			else
			{
				nint num7 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S0_v229 (Il2CppClass<System.DateTime>)+BA]");
				object obj40 = (nint)0 & (nint)0x200;
				if (obj40 != null)
				{
					nint num8 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S0_v243 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime utcNow2 = DateTime.UtcNow;
				obj11 = dateTime;
				obj2 = utcNow2;
				obj4 = obj11;
				obj3 = obj2;
				object obj41 = obj4 & 0x3FFFFFFFFFFFFFFFL;
				object obj42 = obj3 & 0x3FFFFFFFFFFFFFFFL;
				flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj41) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42);
			}
			object obj43 = flag2 | flag;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj44 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj44 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					double num9 = (double)obj12 * 1E-07;
					if (num9 != num9)
					{
						num9 = -2147483648.0;
					}
					else if (!(num9 < 2147483648.0))
					{
						num9 = -2147483648.0;
					}
					else if (!(num9 > -2147483649.0))
					{
						num9 = -2147483648.0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
				}
				object obj45 = obj14 + 4;
				object obj46 = obj45 + 1;
				obj45 = obj46;
				object obj47 = obj46 << 2;
				object obj48 = obj14 + obj47;
				obj48 = 661;
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v35+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v35+4]");
					object obj50 = (nint)0 << 2;
					object obj51 = obj14 + obj50;
					if ((nint)obj51 == 661)
					{
						object obj52 = obj14 + 4;
						if ((nint)obj52 > -1)
						{
							object obj53 = obj52 + -1;
							obj52 = obj53;
						}
						goto IL_0dad;
					}
				}
				if (obj49 == null)
				{
					goto IL_0dad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38 (System.Boolean)+24]");
			object obj54 = 0;
			Dictionary<AdType, CacheList> cacheLists = _cacheLists;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S1_v63+C]");
			CacheList cacheList = cacheLists.get_Item(AdType.Interstitial);
			nint num10 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S1_v66 (Il2CppClass<Kiloo.Common.Ads.AdController+<>c>)+BA]");
			object obj55 = (nint)0 & (nint)0x200;
			if (obj55 != null)
			{
				nint num11 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S1_v145 (Il2CppClass<Kiloo.Common.Ads.AdController+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = _003C_003Ec._003C_003E9__33_0 == null;
			bool flag4 = !flag3;
			Predicate<AdLocation> predicate = _003C_003Ec._003C_003E9__33_0;
			if (!flag4)
			{
				nint num12 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ S1_v119 (Il2CppClass<Kiloo.Common.Ads.AdController+<>c>)+BA]");
				object obj56 = (nint)0 & (nint)0x200;
				if (obj56 != null)
				{
					nint num13 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ S1_v139 (Il2CppClass<Kiloo.Common.Ads.AdController+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num14 = 0;
				_ = 0;
				Predicate<AdLocation> predicate2 = default;
				object obj57 = predicate2 + 16;
				obj57 = _003C_003Ec._003C_003E9;
				nint num15 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ S1_v136 (Il2CppClass<Kiloo.Common.Ads.AdController+<>c>)+5C]");
				object obj58 = (nint)0 + (nint)4;
				obj58 = predicate2;
				predicate = predicate2;
			}
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S2_v18 (Il2CppMethodInfo)+C]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ S2_v19+60]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S2_v20+68]");
			object obj61 = 0;
			object obj62 = obj61 & 0x1FFF;
			object obj63 = obj62 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v665 @ S3_v9 (should have been resolved before IL gen)");
			object obj64 = default;
			if ((nint)obj64 == -1)
			{
				string text = $"Ad Location: {(object[])(object)locationID}";
				string text2 = string.Format((IFormatProvider)(object)"{0};{1}", "null", "Attempt to show ad", "No cached ad");
				nint num17 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ S0_v141 (Il2CppClass<Flurry>)+BA]");
				object obj65 = (nint)0 & (nint)0x200;
				if (obj65 != null)
				{
					nint num18 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S0_v149 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj66 = ((IConvertible)"Show called from location: ").ToType((Type)(object)locationID, (IFormatProvider)(object)", but no video ads are cached!");
				nint num19 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ S1_v108 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
				object obj67 = (nint)0 & (nint)0x200;
				if (obj67 != null)
				{
					nint num20 = (nint)typeof(AdSystemLog);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ S1_v114 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((DebugAdGUI)obj66).Awake();
				((AdEventListenerAdapter)this).FailedToInitAdProvider((string)null);
			}
			else
			{
				object obj68 = 0;
				AdLocation adLocation = null;
				while (true)
				{
					bool flag5 = adLocation == null;
					AdLocation locationToShow = cacheList.GetLocationToShow();
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68) < System.Runtime.CompilerServices.Unsafe.As<AdLocation, UIntPtr>(ref locationToShow))
					{
						if (flag5 || !adLocation.Show())
						{
							bool flag6 = ((_003CCheckCacheExpiredCoroutine_003Ed__31)(object)cacheList).MoveNext();
							((_003C_003Ec__DisplayClass29_0)(object)cacheList)._002Ector();
							object obj69 = obj68 + 1;
							obj68 = obj69;
							adLocation = (AdLocation)flag6;
							continue;
						}
					}
					else if (flag5)
					{
						break;
					}
					string text3 = $"Ad Location: {(object[])(object)locationID}";
					string text4 = string.Format((IFormatProvider)(object)"{0};{1}", "null", "Attempt to show ad", "Success");
					nint num21 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ S0_v110 (Il2CppClass<Flurry>)+BA]");
					object obj70 = (nint)0 & (nint)0x200;
					if (obj70 != null)
					{
						nint num22 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ S0_v116 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return (string)(object)adLocation.WaitWhileUnavailableThenCache();
				}
				object obj71 = ((IConvertible)"!!! Show called for location: ").ToType((Type)(object)locationID, (IFormatProvider)(object)" and though it wasn't caught by the no ad cached checks, no cached ad was found!");
				nint num23 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ S1_v88 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
				object obj72 = (nint)0 & (nint)0x200;
				if (obj72 != null)
				{
					nint num24 = (nint)typeof(AdSystemLog);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ S1_v93 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((DebugAdGUI)obj71).Awake();
			}
		}
		else
		{
			string text5 = string.ConcatArray((string[])(object)"Unknown ad location ID: ", (int)locationID);
			nint num25 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v25 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
			object obj73 = (nint)0 & (nint)0x200;
			if (obj73 != null)
			{
				nint num26 = (nint)typeof(AdSystemLog);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v30 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((DebugAdGUI)(object)text5).Awake();
		}
		goto IL_0dad;
		IL_0dad:
		IEnumerator result = default;
		return (string)(object)result;
	}

	public void SetProviderForAdLocation(string adLocationId, AbstractAdProvider provider)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
	}

	public uint GetGracePeriodValue()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02b6: Expected Obj, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02d3: Expected Obj, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 40;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder sb = default;
		System.Text.StringBuilderCache.Release(sb);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj10 = default;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v76+24]");
			object obj7 = 0;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj9 = obj10;
			}
			else
			{
				object obj9 = "none";
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj11 = obj12 & 1;
			obj4 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		}
		object obj13 = obj5 + 4;
		object obj14 = obj13 + 1;
		obj13 = obj14;
		object obj15 = obj14 << 2;
		object obj16 = obj5 + obj15;
		obj16 = 142;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj5 + obj17;
			if ((nint)obj18 == 142)
			{
				object obj19 = obj5 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_0359;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0359;
		IL_0359:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		uint result = default;
		return result;
	}

	public bool GetAvailabilityForLocation(string locationID)
	{
		//IL_0072: Expected I4, but got Obj
		//IL_000f: Expected Obj, but got I4
		//IL_002b: Expected I4, but got Obj
		bool flag = ((DebugAdProvider)this).HasCachedInterstitial(locationID);
		bool flag2 = !flag;
		bool result = (byte)(int)string.Empty != 0;
		if (!flag2)
		{
			AdLocation adLocationFromID = GetAdLocationFromID((string)flag);
			bool flag3 = adLocationFromID == null;
			result = (byte)(int)string.Empty != 0;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				bool flag4 = default;
				result = flag4;
			}
		}
		return result;
	}

	public bool AreInterstitialsAllowed()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		bool result = default;
		return result;
	}

	public bool HasPriorityListWrapped(string locationID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		bool result = default;
		return result;
	}

	private bool HasPriorityListChanged(AdLocation adLocation)
	{
		//IL_001c: Expected Obj, but got I
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		if (((DebugAdProvider)this).HasCachedInterstitial((string)(object)adLocation))
		{
			Dictionary<string, PriorityList> idToPriorityList = _idToPriorityList;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6 (System.Boolean)+28]");
			PriorityList priorityList = idToPriorityList.get_Item((string)0);
			object obj = priorityList - -64;
			return obj != null;
		}
		return false;
	}

	private void UpdatePriorityListForID(string waterfallID, AdType adType)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = waterfallID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		NullReferenceException ex = new NullReferenceException();
		((AdProviderConfiguration)(object)ex).isRestricted = (byte)adType != 0;
	}

	public void UpdateCacheIdsFromOnlineSettings()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		Dictionary<, >.ValueCollection valueCollection = default;
		object obj = valueCollection + 48;
		object obj2 = valueCollection + 24;
		obj2 = 0;
		_ = 0;
		object obj3 = valueCollection + 16;
		obj3 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE18");
		_00211 item = default;
		((ICollection<TValue>)valueCollection).Add((TValue)item);
		obj2 = valueCollection;
		_ = valueCollection.dictionary;
		object obj4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj4 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj5 = obj3 + 4;
		object obj6 = obj5 + 1;
		obj5 = obj6;
		object obj7 = obj6 << 2;
		object obj8 = obj3 + obj7;
		obj8 = 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj3 + obj9;
			if ((nint)obj10 == 56)
			{
				object obj11 = obj3 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private PriorityList CreatePriorityListForID(string waterfallID, AdType adType, IAdSettingsProvider settings)
	{
		//IL_029a: Invalid comparison between VT and I4
		//IL_01c2: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I
		//IL_034e: Expected I, but got Obj
		//IL_0364: Expected Obj, but got I
		//IL_03a1: Expected Obj, but got I4
		//IL_03a1: Expected I4, but got Obj
		//IL_0203: Expected I, but got Obj
		//IL_0250: Expected I, but got Obj
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_030e: Expected Obj, but got I4
		//IL_030e: Expected I4, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I4
		//IL_02df: Expected I4, but got Obj
		//IL_01af: Expected Obj, but got I4
		//IL_00e3: Expected I, but got Obj
		if (_timeOfLastVideo == (DateTime)(object)2)
		{
			bool flag;
			if (settings != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [settings @ L3 (Kiloo.Common.Ads.IAdSettingsProvider)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				IEnumerator enumerator = ((DebugAdProvider)this).CacheInterstitialCoroutine(waterfallID, (string)(object)settings);
				nint num = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v10 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				bool flag2 = obj != null;
				if (enumerator == null)
				{
					if (flag2)
					{
						nint num2 = (nint)typeof(AbstractAdProvider);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v64 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					string providerID = default;
					AbstractAdProvider.eventInvoker.CachingTimedOut((AdType)waterfallID, providerID, (string)adType);
					return null;
				}
				if (flag2)
				{
					nint num3 = (nint)typeof(AbstractAdProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v52 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				string providerID2 = default;
				AbstractAdProvider.eventInvoker.ShowedAd((AdType)waterfallID, providerID2, (string)adType);
				if ((nint)waterfallID == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
				}
				return (PriorityList)1;
			}
		}
		nint num4 = (nint)typeof(AdSystemLog);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v32 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DebugAdGUI)(object)"Unable to show ad, provider is not initialized or cacheID is null").Awake();
		nint num6 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID3 = default;
		AbstractAdProvider.eventInvoker.CachingTimedOut((AdType)waterfallID, providerID3, (string)adType);
		return null;
	}

	public string GetWaterfallID(AdLocationInfo adLocation)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		InterstitialStats interstitialStats = _interstitialStats;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [adLocation @ L1 (Kiloo.Common.Ads.AdLocationInfo)+28]");
		string providerId = default;
		return ((AdSystemEventLogger)(object)interstitialStats).GetResultOfVideoShown(AdType.Interstitial, providerId);
	}

	private AbstractAdProvider GetCurrentProvider(AdLocation adLocation)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		AbstractAdProvider abstractAdProvider = default;
		bool flag = abstractAdProvider == null || abstractAdProvider._showInterstitialLocation == null;
		bool flag2 = !flag;
		AbstractAdProvider result = abstractAdProvider;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			AbstractAdProvider abstractAdProvider2 = default;
			result = abstractAdProvider2;
		}
		return result;
	}

	private AdLocation GetAdLocationFromID(string adLocationID)
	{
		//IL_00bd: Expected Obj, but got I
		//IL_001c: Expected I, but got Obj
		//IL_0032: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_005d: Expected I, but got Obj
		Dictionary<string, PriorityList> idToPriorityList = _idToPriorityList;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [adLocationID @ L1 (System.String)+28]");
		PriorityList priorityList = idToPriorityList.get_Item((string)0);
		if (priorityList.maxPriorityInList != 0)
		{
			priorityList.MarkCurrentProviderAsExhausted();
			nint num = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = ((AdController)(object)priorityList.currentProvider__BackingField).allowReCacheOnFail;
			return (AdLocation)flag;
		}
		return null;
	}
}
