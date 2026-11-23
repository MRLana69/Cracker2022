using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Backend;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Kiloo.Monetization.Offerwall.Internal;
using Kiloo.Monetization.Tapjoy;
using Kiloo.Monetization.Tapjoy.Internal;
using Kiloo.Plugins.DeviceUtility;
using MiniJSON;
using UnityEngine;

namespace Kiloo.Monetization.Offerwall.TapjoyOfferwall;

public class TapJoyOfferWallProvider : IOfferWallProvider
{
	private enum TapJoyOfferwallConnectionState
	{
		Disconnected,
		Connecting,
		Connected
	}

	private enum RequestStates
	{
		NotStarted,
		InProgress,
		Succeeded,
		Failed
	}

	private sealed class _003CRefreshOffersCoroutine_003Ed__51(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TapJoyOfferWallProvider _003C_003E4__this;

		public int amountOfOffersToRequest;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0104: Expected Obj, but got I4
			//IL_019c: Expected Obj, but got I4
			//IL_0180: Expected Obj, but got I4
			//IL_02b7: Expected Obj, but got I4
			//IL_029b: Expected Obj, but got I4
			TapJoyOfferWallProvider tapJoyOfferWallProvider = _003C_003E4__this;
			RequestStates requestOffersState;
			object obj2;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							goto IL_0463;
						}
						_003C_003E1__state = -1;
						bool flag = tapJoyOfferWallProvider._requestOffersState != RequestStates.Failed;
						requestOffersState = tapJoyOfferWallProvider._requestOffersState;
						if (flag)
						{
							goto IL_0486;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						object obj = tapJoyOfferWallProvider._requestExternalIpState - 2;
						if (tapJoyOfferWallProvider._requestExternalIpState == RequestStates.Succeeded)
						{
							string deviceExternalIP = tapJoyOfferWallProvider._deviceExternalIP;
							if (tapJoyOfferWallProvider._deviceExternalIP != null)
							{
								obj2 = 0;
								if (deviceExternalIP._stringLength != 0)
								{
									goto IL_0469;
								}
							}
							obj2 = 1;
							goto IL_0469;
						}
						if ((nint)obj != 1)
						{
							goto IL_023e;
						}
					}
				}
				else
				{
					_003C_003E1__state = -1;
					if (tapJoyOfferWallProvider._offerWallConnectionState != TapJoyOfferwallConnectionState.Disconnected)
					{
						goto IL_01e8;
					}
				}
				goto IL_03ee;
			}
			_003C_003E1__state = -1;
			if (tapJoyOfferWallProvider._requestOffersState != RequestStates.InProgress)
			{
				((List<T>)(object)tapJoyOfferWallProvider._downloadedOffers).Clear();
				tapJoyOfferWallProvider._requestOffersState = RequestStates.InProgress;
				tapJoyOfferWallProvider.InitializeSDK();
				goto IL_01e8;
			}
			goto IL_0463;
			IL_0463:
			return false;
			IL_0469:
			if (obj2 == null)
			{
				goto IL_023e;
			}
			goto IL_03ee;
			IL_03ee:
			((List<T>)(object)tapJoyOfferWallProvider._downloadedOffers).Clear();
			Action onOffersRequestFailed = tapJoyOfferWallProvider.m_onOffersRequestFailed;
			if (tapJoyOfferWallProvider.m_onOffersRequestFailed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			tapJoyOfferWallProvider._requestOffersState = RequestStates.Failed;
			return false;
			IL_03d6:
			_003C_003E2__current = null;
			_003C_003E1__state = 2;
			return true;
			IL_01e8:
			if (tapJoyOfferWallProvider._offerWallConnectionState != TapJoyOfferwallConnectionState.Connected)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			tapJoyOfferWallProvider.PostExternalIpRequest();
			goto IL_023e;
			IL_0486:
			if (requestOffersState != RequestStates.Succeeded)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			}
			List<IDisplayableOffer> downloadedOffers = tapJoyOfferWallProvider._downloadedOffers;
			if (tapJoyOfferWallProvider._downloadedOffers != null && downloadedOffers._size >= 1)
			{
				OfferWallImagesDownloader<>.DownloadImagesForOffers((List<T>)(object)tapJoyOfferWallProvider._downloadedOffers);
				Action<List<IDisplayableOffer>, bool> onOffersReceived = tapJoyOfferWallProvider.m_onOffersReceived;
				if (tapJoyOfferWallProvider.m_onOffersReceived != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v231 @ S0_v33 (System.Action`2<System.Collections.Generic.List`1<Kiloo.Monetization.Offerwall.IDisplayableOffer>, System.Boolean>)+C] (should have been resolved before IL gen)");
					return false;
				}
			}
			else
			{
				Action onOffersRequestFailed2 = tapJoyOfferWallProvider.m_onOffersRequestFailed;
				if (tapJoyOfferWallProvider.m_onOffersRequestFailed != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v205.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				tapJoyOfferWallProvider._requestOffersState = RequestStates.Failed;
			}
			goto IL_0463;
			IL_023e:
			if (tapJoyOfferWallProvider._requestExternalIpState != RequestStates.Succeeded)
			{
				goto IL_03d6;
			}
			string deviceExternalIP2 = tapJoyOfferWallProvider._deviceExternalIP;
			object obj3;
			if (tapJoyOfferWallProvider._deviceExternalIP != null)
			{
				obj3 = 0;
				if (deviceExternalIP2._stringLength != 0)
				{
					goto IL_04b1;
				}
			}
			obj3 = 1;
			goto IL_04b1;
			IL_04b1:
			if (obj3 != null)
			{
				goto IL_03d6;
			}
			tapJoyOfferWallProvider.MakeOfferwallRequest(amountOfOffersToRequest);
			requestOffersState = tapJoyOfferWallProvider._requestOffersState;
			goto IL_0486;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CGetPendingRewardsCoroutine_003Ed__52(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TapJoyOfferWallProvider _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Expected I4, but got Unknown
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_0546: Expected I4, but got Unknown
			TapJoyOfferWallProvider tapJoyOfferWallProvider = _003C_003E4__this;
			RequestStates spendRewardState;
			RequestStates requestRewardState;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (tapJoyOfferWallProvider._offerWallConnectionState != TapJoyOfferwallConnectionState.Disconnected)
					{
						goto IL_01b2;
					}
					goto IL_041e;
				}
				if (_003C_003E1__state != 2)
				{
					if (_003C_003E1__state == 3)
					{
						_003C_003E1__state = -1;
						bool flag = tapJoyOfferWallProvider._spendRewardState != RequestStates.Failed;
						spendRewardState = tapJoyOfferWallProvider._spendRewardState;
						if (!flag)
						{
							goto IL_041e;
						}
						goto IL_04ab;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					bool flag2 = tapJoyOfferWallProvider._requestRewardState != RequestStates.Failed;
					requestRewardState = tapJoyOfferWallProvider._requestRewardState;
					if (flag2)
					{
						goto IL_048b;
					}
					Action onPendingRewardsRequestFailed = tapJoyOfferWallProvider.m_onPendingRewardsRequestFailed;
					if (tapJoyOfferWallProvider.m_onPendingRewardsRequestFailed != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v144.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
			}
			else
			{
				_003C_003E1__state = -1;
				if (tapJoyOfferWallProvider._requestRewardState != RequestStates.InProgress && tapJoyOfferWallProvider._spendRewardState != RequestStates.InProgress)
				{
					tapJoyOfferWallProvider._requestRewardState = RequestStates.InProgress;
					tapJoyOfferWallProvider.InitializeSDK();
					goto IL_01b2;
				}
			}
			goto IL_0485;
			IL_048b:
			if (requestRewardState == RequestStates.Succeeded)
			{
				if (tapJoyOfferWallProvider._amountPendingApprovalToBeRewarded >= 1)
				{
					tapJoyOfferWallProvider._spendRewardState = RequestStates.InProgress;
					TapJoy.SpendPoints(tapJoyOfferWallProvider._amountPendingApprovalToBeRewarded);
					spendRewardState = tapJoyOfferWallProvider._spendRewardState;
					goto IL_04ab;
				}
				if (tapJoyOfferWallProvider._amountPendingApprovalToBeRewarded == 0)
				{
					Action<int> onPendingRewardsReceived = tapJoyOfferWallProvider.m_onPendingRewardsReceived;
					if (tapJoyOfferWallProvider.m_onPendingRewardsReceived != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v217 @ S0_v61 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
					}
				}
				else
				{
					Action onPendingRewardsRequestFailed2 = tapJoyOfferWallProvider.m_onPendingRewardsRequestFailed;
					if (tapJoyOfferWallProvider.m_onPendingRewardsRequestFailed != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v219.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					tapJoyOfferWallProvider._requestRewardState = RequestStates.Failed;
					int num = tapJoyOfferWallProvider + 32;
					string text = ((int*)num)->ToString();
					string msg = "The amount offered to be rewarded to the user is: " + text + ". It should never be below 0!";
					LogError(msg);
				}
				goto IL_0485;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 2;
			return true;
			IL_0485:
			return false;
			IL_04ab:
			if (spendRewardState != RequestStates.Succeeded)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			}
			int num2 = tapJoyOfferWallProvider + 36;
			if (tapJoyOfferWallProvider._amountApprovedToBeRewarded >= 0)
			{
				Action<int> onPendingRewardsReceived2 = tapJoyOfferWallProvider.m_onPendingRewardsReceived;
				if (tapJoyOfferWallProvider.m_onPendingRewardsReceived != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ S0_v29 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
				}
				((int*)num2)->m_value = 0;
			}
			else
			{
				Action onPendingRewardsRequestFailed3 = tapJoyOfferWallProvider.m_onPendingRewardsRequestFailed;
				if (tapJoyOfferWallProvider.m_onPendingRewardsRequestFailed != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v213.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				tapJoyOfferWallProvider._requestRewardState = RequestStates.Failed;
				string text2 = ((int*)num2)->ToString();
				string msg2 = "The amount approved to be rewarded to the user is: " + text2 + ". It should never be below 0!";
				LogError(msg2);
			}
			goto IL_0485;
			IL_01b2:
			if (tapJoyOfferWallProvider._offerWallConnectionState != TapJoyOfferwallConnectionState.Connected)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			DateTime now = CDateTime.Now;
			tapJoyOfferWallProvider._lastTimeRewardsWereRequested = now;
			TapJoy.GetPoints();
			requestRewardState = tapJoyOfferWallProvider._requestRewardState;
			goto IL_048b;
			IL_041e:
			Action onPendingRewardsRequestFailed4 = tapJoyOfferWallProvider.m_onPendingRewardsRequestFailed;
			if (tapJoyOfferWallProvider.m_onPendingRewardsRequestFailed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v157.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			tapJoyOfferWallProvider._requestRewardState = RequestStates.Failed;
			goto IL_0485;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public TapJoyOfferWallProvider _003C_003E4__this;

		public OfferwallRequest requestData;

		internal void _003CPostOfferwallRequest_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected Obj, but got Unknown
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected Obj, but got Unknown
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected Obj, but got Unknown
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected Obj, but got Unknown
			//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f6: Expected Obj, but got Unknown
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected Obj, but got Unknown
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Expected Obj, but got Unknown
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 80;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			bool flag = obj3 == null;
			string jsonstring = null;
			if (!flag)
			{
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S1_v88+D4] (should have been resolved before IL gen)");
				string text = default;
				jsonstring = text;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj5 = default;
			if (obj5 != null && obj3 != null)
			{
				List<TapjoyOffer> list = DeserializeJsonOffers(jsonstring);
				List<TapjoyOffer> list2 = _003C_003E4__this.FilterOffers(list);
				TapJoyOfferWallProvider tapJoyOfferWallProvider = _003C_003E4__this;
				if (tapJoyOfferWallProvider.m_notifyOffersReceivedVSOffersRequested != null)
				{
					object obj6 = obj - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					OfferwallRequest offerwallRequest = requestData;
					_ = offerwallRequest.max__BackingField;
					_ = list._size;
					_ = list2._size;
					_ = list2._size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
					_ = 0;
					object obj7 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @64B");
				}
				if (list2._size >= 1)
				{
					List<IDisplayableOffer> list3 = default;
					list3._002Ector();
					int num = 0;
					while (num < list2._size)
					{
						TapjoyOffer item = list2.get_Item(num);
						list3.Add(item);
						int num2 = num + 1;
						num = num2;
					}
					TapJoyOfferWallProvider tapJoyOfferWallProvider2 = _003C_003E4__this;
					tapJoyOfferWallProvider2._downloadedOffers = list3;
					TapJoyOfferWallProvider tapJoyOfferWallProvider3 = _003C_003E4__this;
					tapJoyOfferWallProvider3._requestOffersState = RequestStates.Succeeded;
					object obj8 = obj + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
					_ = 0;
					object obj9 = obj + 48;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					_ = 0;
					object obj11 = default;
					do
					{
						_ = 0;
						object obj10 = obj + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							break;
						}
						if (obj11 != null)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							continue;
						}
						object obj12 = obj + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5796");
						return;
					}
					while ((nint)0 != 1);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					object obj13 = default;
					object obj14 = default;
					bool flag2 = obj13 != obj14;
					object obj16 = default;
					object obj15 = obj16;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj17 = obj + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5796");
							goto IL_038f;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						object obj18 = default;
						obj15 = obj18;
					}
					_ = 0;
					object obj19 = obj + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return;
				}
				goto IL_038f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text2 = default;
			string msg = "OfferWall request failed: " + text2;
			LogError(msg);
			TapJoyOfferWallProvider tapJoyOfferWallProvider4 = _003C_003E4__this;
			tapJoyOfferWallProvider4._requestOffersState = RequestStates.Failed;
			return;
			IL_038f:
			TapJoyOfferWallProvider tapJoyOfferWallProvider5 = _003C_003E4__this;
			tapJoyOfferWallProvider5._requestOffersState = RequestStates.Failed;
		}
	}

	private DateTime _lastTimeOffersWereRequested = DateTime.MinValue;

	private DateTime _lastTimeRewardsWereRequested = DateTime.MinValue;

	private TapJoyOfferwallConnectionState _offerWallConnectionState;

	private List<IDisplayableOffer> _downloadedOffers;

	private int _amountPendingApprovalToBeRewarded;

	private int _amountApprovedToBeRewarded;

	private string _deviceExternalIP;

	private IOfferWallDataManager _dataManager;

	private RequestStates _requestOffersState;

	private RequestStates _requestRewardState;

	private RequestStates _spendRewardState;

	private RequestStates _requestExternalIpState;

	private Action<List<IDisplayableOffer>, bool> m_onOffersReceived;

	private Action m_onOffersRequestFailed;

	private Action<int> m_onPendingRewardsReceived;

	private Action m_onPendingRewardsRequestFailed;

	private Action<OffersResponseData> m_notifyOffersReceivedVSOffersRequested;

	public OfferWallProviderID providerID => OfferWallProviderID.TapJoy;

	private bool allowsSDKInitialize
	{
		get
		{
			bool flag = _dataManager == null;
			bool result = false;
			if (!flag)
			{
				bool flag2 = _offerWallConnectionState == TapJoyOfferwallConnectionState.Connected;
				result = false;
				if (!flag2)
				{
					bool flag3 = _offerWallConnectionState == TapJoyOfferwallConnectionState.Connecting;
					result = false;
					if (!flag3)
					{
						bool flag4 = IsSupportedOnPlatform();
						bool flag5 = !flag4;
						result = false;
						if (!flag5)
						{
							bool waitForAgeRestriction = AgeRestriction.waitForAgeRestriction;
							result = false;
							if (!waitForAgeRestriction)
							{
								bool isRestricted = AgeRestriction.isRestricted;
								bool flag6 = (byte)((isRestricted ? 1u : 0u) ^ 1u) != 0;
								result = flag6;
							}
						}
					}
				}
			}
			return result;
		}
	}

	private bool isSDKInitialized => _offerWallConnectionState == TapJoyOfferwallConnectionState.Connected;

	private bool isSDKInitializing => _offerWallConnectionState == TapJoyOfferwallConnectionState.Connecting;

	private bool isManagerSetUp => _dataManager != null;

	public event Action<List<IDisplayableOffer>, bool> onOffersReceived
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this - -64;
			Delegate obj2 = this.m_onOffersReceived;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this - -64;
			Delegate obj2 = this.m_onOffersReceived;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action onOffersRequestFailed
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 68;
			Delegate obj2 = this.m_onOffersRequestFailed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 68;
			Delegate obj2 = this.m_onOffersRequestFailed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<int> onPendingRewardsReceived
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 72;
			Delegate obj2 = this.m_onPendingRewardsReceived;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 72;
			Delegate obj2 = this.m_onPendingRewardsReceived;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action onPendingRewardsRequestFailed
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 76;
			Delegate obj2 = this.m_onPendingRewardsRequestFailed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 76;
			Delegate obj2 = this.m_onPendingRewardsRequestFailed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action<OffersResponseData> notifyOffersReceivedVSOffersRequested
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 80;
			Delegate obj2 = this.m_notifyOffersReceivedVSOffersRequested;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 80;
			Delegate obj2 = this.m_notifyOffersReceivedVSOffersRequested;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public bool IsSupportedOnPlatform()
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			bool isKindleDevice = DeviceUtility.isKindleDevice;
			return (byte)((isKindleDevice ? 1u : 0u) ^ 1u) != 0;
		}
		return false;
	}

	public void InitProvider(IOfferWallDataManager dataManager)
	{
		_dataManager = dataManager;
	}

	public void RefreshOffers(bool bypassTimeLimitsEnforcedByOutside = false)
	{
		//IL_01f8: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		if (_dataManager != null)
		{
			bool flag = !bypassTimeLimitsEnforcedByOutside;
			bool flag2 = !flag;
			bool flag3 = false;
			if (!flag2)
			{
				bool flag4 = _offerWallConnectionState != TapJoyOfferwallConnectionState.Disconnected;
				flag3 = flag4;
			}
			bool flag5 = _requestOffersState == RequestStates.Succeeded;
			object obj = 1;
			if (!flag5)
			{
				obj = 2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int timeInterval = default;
			if (!flag3 || HasTimeIntervalPassedSinceDate(_lastTimeOffersWereRequested, timeInterval))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				int amountOfOffersToRequest = default;
				IEnumerator coroutine = RefreshOffersCoroutine(amountOfOffersToRequest);
				Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
				return;
			}
			List<IDisplayableOffer> downloadedOffers = _downloadedOffers;
			if (_downloadedOffers != null && downloadedOffers._size >= 1)
			{
				Action<List<IDisplayableOffer>, bool> action = this.m_onOffersReceived;
				if (this.m_onOffersReceived != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v140 @ S0_v47 (System.Action`2<System.Collections.Generic.List`1<Kiloo.Monetization.Offerwall.IDisplayableOffer>, System.Boolean>)+C] (should have been resolved before IL gen)");
				}
			}
			else
			{
				Action action2 = this.m_onOffersRequestFailed;
				if (this.m_onOffersRequestFailed != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v138.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
		else
		{
			LogError("RefreshOffers should not be called before setting up the Offerwall");
			((List<T>)(object)_downloadedOffers).Clear();
			Action action3 = this.m_onOffersRequestFailed;
			if (this.m_onOffersRequestFailed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe void GetPendingRewards(bool bypassTimeLimitsEnforcedByOutside = false)
	{
		//IL_0081: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected I4, but got Unknown
		bool flag3;
		if (_dataManager != null)
		{
			bool flag = !bypassTimeLimitsEnforcedByOutside;
			bool flag2 = !flag;
			flag3 = true;
			if (!flag2)
			{
				bool flag4 = _offerWallConnectionState == TapJoyOfferwallConnectionState.Disconnected;
				flag3 = flag4;
			}
			object obj;
			if (_requestRewardState == RequestStates.Succeeded)
			{
				bool flag5 = _spendRewardState == RequestStates.Succeeded;
				obj = 3;
				if (flag5)
				{
					goto IL_0233;
				}
			}
			obj = 4;
			goto IL_0233;
		}
		LogError("GetPendingRewards should not be called before setting up the Offerwall");
		Action action = this.m_onPendingRewardsRequestFailed;
		if (this.m_onPendingRewardsRequestFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		return;
		IL_0233:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int timeInterval = default;
		if (flag3 || HasTimeIntervalPassedSinceDate(_lastTimeRewardsWereRequested, timeInterval))
		{
			IEnumerator pendingRewardsCoroutine = GetPendingRewardsCoroutine();
			Coroutine coroutine = CoroutineUtil.StartCoroutine(pendingRewardsCoroutine);
			return;
		}
		int num = this + 36;
		if (_amountApprovedToBeRewarded >= 0)
		{
			Action<int> action2 = this.m_onPendingRewardsReceived;
			if (this.m_onPendingRewardsReceived != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ S0_v49 (System.Action`1<System.Int32>)+C] (should have been resolved before IL gen)");
			}
			((int*)num)->m_value = 0;
			return;
		}
		string text = ((int*)num)->ToString();
		string msg = "The amount approved to be rewarded to the user is: " + text + ". It should never be below 0!";
		LogError(msg);
		Action action3 = this.m_onPendingRewardsRequestFailed;
		if (this.m_onPendingRewardsRequestFailed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v157.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public unsafe void UnloadProvider()
	{
		TapjoyConnectEvent tapjoyConnectEvent = default;
		tapjoyConnectEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.InitializeFinished));
		TapJoy.onInitializeFinished -= tapjoyConnectEvent;
		TapjoyEarnedPointsEvent tapjoyEarnedPointsEvent = default;
		tapjoyEarnedPointsEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.EarnedPoints));
		TapJoy.onEarnPoints -= tapjoyEarnedPointsEvent;
		TapjoyGetPointsEvent tapjoyGetPointsEvent = default;
		tapjoyGetPointsEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.GotPoints));
		TapJoy.onGetPoints -= tapjoyGetPointsEvent;
		TapjoyGetPointsErrorEvent tapjoyGetPointsErrorEvent = default;
		tapjoyGetPointsErrorEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.GetPointsError));
		TapJoy.onGetPointsError -= tapjoyGetPointsErrorEvent;
		TapjoySpendPointsEvent tapjoySpendPointsEvent = default;
		tapjoySpendPointsEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.SpentPoints));
		TapJoy.onSpendPoints -= tapjoySpendPointsEvent;
		TapjoySpendPointsErrorEvent tapjoySpendPointsErrorEvent = default;
		tapjoySpendPointsErrorEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.SpendPointsError));
		TapJoy.onSpendPointsError -= tapjoySpendPointsErrorEvent;
	}

	private void InitializeFinished(string result)
	{
		bool flag = result != "success";
		TapJoyOfferwallConnectionState offerWallConnectionState = TapJoyOfferwallConnectionState.Connected;
		if (flag)
		{
			offerWallConnectionState = TapJoyOfferwallConnectionState.Disconnected;
		}
		_offerWallConnectionState = offerWallConnectionState;
	}

	private void EarnedPoints(string amount)
	{
	}

	private unsafe void GotPoints(string amount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (int.TryParse(amount, out *(int*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				_amountPendingApprovalToBeRewarded = 0;
			}
		}
		_requestRewardState = RequestStates.Succeeded;
	}

	private void GetPointsError()
	{
		_requestRewardState = RequestStates.Failed;
	}

	private void SpentPoints(string amountOfPointsLeftInUsersBalance)
	{
		int amountApprovedToBeRewarded = _amountApprovedToBeRewarded + _amountPendingApprovalToBeRewarded;
		_spendRewardState = RequestStates.Succeeded;
		_amountPendingApprovalToBeRewarded = 0;
		_amountApprovedToBeRewarded = amountApprovedToBeRewarded;
	}

	private void SpendPointsError()
	{
		_spendRewardState = RequestStates.Failed;
	}

	private unsafe void InitializeSDK()
	{
		if (allowsSDKInitialize)
		{
			_offerWallConnectionState = TapJoyOfferwallConnectionState.Connecting;
			TapjoyConnectEvent tapjoyConnectEvent = default;
			tapjoyConnectEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.InitializeFinished));
			TapJoy.onInitializeFinished += tapjoyConnectEvent;
			TapjoyEarnedPointsEvent tapjoyEarnedPointsEvent = default;
			tapjoyEarnedPointsEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.EarnedPoints));
			TapJoy.onEarnPoints += tapjoyEarnedPointsEvent;
			TapjoyGetPointsEvent tapjoyGetPointsEvent = default;
			tapjoyGetPointsEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.GotPoints));
			TapJoy.onGetPoints += tapjoyGetPointsEvent;
			TapjoyGetPointsErrorEvent tapjoyGetPointsErrorEvent = default;
			tapjoyGetPointsErrorEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.GetPointsError));
			TapJoy.onGetPointsError += tapjoyGetPointsErrorEvent;
			TapjoySpendPointsEvent tapjoySpendPointsEvent = default;
			tapjoySpendPointsEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.SpentPoints));
			TapJoy.onSpendPoints += tapjoySpendPointsEvent;
			TapjoySpendPointsErrorEvent tapjoySpendPointsErrorEvent = default;
			tapjoySpendPointsErrorEvent._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider.SpendPointsError));
			TapJoy.onSpendPointsError += tapjoySpendPointsErrorEvent;
			if (TapJoy.isInitialized)
			{
				InitializeFinished("success");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			string appId = default;
			string appKey = default;
			string eventName = default;
			TapJoy.Initialize(appId, appKey, eventName);
		}
	}

	private IEnumerator RefreshOffersCoroutine(int amountOfOffersToRequest)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator GetPendingRewardsCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe bool HasTimeIntervalPassedSinceDate(DateTime lastRequestDateTime, int timeInterval)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected VT, but got Unknown
		//IL_0074: Expected Ref, but got VT
		//IL_001b: Expected Obj, but got VT
		//IL_0037: Invalid comparison between F8 and I4
		object obj2 = default;
		object obj = obj2 - 16;
		obj = 0;
		DateTime now = CDateTime.Now;
		DateTime dateTime = (DateTime)(obj + 8);
		TimeSpan timeSpan = ((DateTime*)dateTime)->Subtract(lastRequestDateTime);
		obj = timeSpan;
		double num = (double)obj * 1E-07;
		return num > (double)timeInterval;
	}

	private unsafe List<TapjoyOffer> FilterOffers(List<TapjoyOffer> unfilteredOffers)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		//IL_009e: Expected Obj, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_037a: Expected Obj, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_03d9: Expected Obj, but got I
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_047d: Expected Obj, but got I
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		object obj = default;
		ref int reference = ref *(int*)(obj - 16);
		_ = 0;
		_ = 0;
		_ = 0;
		reference = ref *(int*)null;
		List<TapjoyOffer> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Dictionary<OfferWallFilterType, string> dictionary = default;
		if (unfilteredOffers != null && dictionary != null)
		{
			int num = default;
			object obj4 = default;
			object obj6 = default;
			object obj7 = default;
			object obj10 = default;
			object obj12 = default;
			object obj13 = default;
			object obj16 = default;
			object obj18 = default;
			object obj19 = default;
			object obj22 = default;
			object obj24 = default;
			object obj25 = default;
			int num11 = default;
			while (num < unfilteredOffers._size)
			{
				TapjoyOffer tapjoyOffer = unfilteredOffers.get_Item(num);
				nint num2 = 0;
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S3_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Kiloo.Monetization.Offerwall.OfferWallFilterType, System.String>>)+54]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v124 @ S3_v6+4] (should have been resolved before IL gen)");
				object obj3 = obj4 ^ -1;
				object obj5 = obj3 >> 31;
				if (obj5 != null)
				{
					string s = dictionary.get_Item(OfferWallFilterType.minReward);
					if (int.TryParse(s, out System.Runtime.CompilerServices.Unsafe.Add(ref reference, 2)) && int.TryParse(tapjoyOffer._amount, out System.Runtime.CompilerServices.Unsafe.Add(ref reference, 3)))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+C]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+8]");
						bool flag = num4 >= 0;
						obj6 = obj7 | flag;
					}
				}
				nint num5 = 0;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S3_v10 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Kiloo.Monetization.Offerwall.OfferWallFilterType, System.String>>)+54]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ S3_v11+4] (should have been resolved before IL gen)");
				object obj9 = obj10 ^ -1;
				object obj11 = obj9 >> 31;
				if (obj11 != null)
				{
					string s2 = dictionary.get_Item(OfferWallFilterType.maxReward);
					if (int.TryParse(s2, out System.Runtime.CompilerServices.Unsafe.Add(ref reference, 1)) && int.TryParse(tapjoyOffer._amount, out reference))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32&)+4]");
						bool flag2 = (nint)0 >= (nint)reference;
						obj12 = obj13 | flag2;
					}
				}
				nint num7 = 0;
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S3_v15 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Kiloo.Monetization.Offerwall.OfferWallFilterType, System.String>>)+54]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ S3_v16+4] (should have been resolved before IL gen)");
				object obj15 = obj16 ^ -1;
				object obj17 = obj15 >> 31;
				if (obj17 != null)
				{
					string value = dictionary.get_Item(OfferWallFilterType.costForInstall);
					bool flag3 = tapjoyOffer._cost.Equals(value, StringComparison.InvariantCultureIgnoreCase);
					obj18 = flag3 | obj19;
				}
				nint num9 = 0;
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S3_v21 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Kiloo.Monetization.Offerwall.OfferWallFilterType, System.String>>)+54]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v244 @ S3_v22+4] (should have been resolved before IL gen)");
				object obj21 = obj22 ^ -1;
				object obj23 = obj21 >> 31;
				if (obj23 != null)
				{
					string value2 = dictionary.get_Item(OfferWallFilterType.offerType);
					bool flag4 = tapjoyOffer._type.Equals(value2, StringComparison.InvariantCultureIgnoreCase);
					obj24 = flag4 | obj25;
				}
				object obj26 = obj6 & obj12;
				object obj27 = obj26 & obj18;
				object obj28 = obj27 & 1;
				if (obj28 != null)
				{
					object obj29 = obj24 & 1;
					if (obj29 != null)
					{
						list.Add(tapjoyOffer);
					}
				}
				num = num11 + 1;
			}
		}
		return list;
	}

	private unsafe void MakeOfferwallRequest(int amountOfOffersToRequest)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected I8, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		string deviceIdentifier = DeviceUtility.GetDeviceIdentifier();
		string androidAdvertisingID = DeviceUtility.GetAndroidAdvertisingID();
		DateTime utcNow = CDateTime.UtcNow;
		long num = TimeUtility.ToUnixTime(utcNow);
		long num2 = obj + 8;
		string text = ((long*)num2)->ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private unsafe void PostOfferwallRequest(OfferwallRequest requestData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0125: Expected Obj, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I
		//IL_00b9: Expected native int or pointer, but got VT
		//IL_00ce: Expected native int or pointer, but got VT
		object obj = default;
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj - 32);
		_ = 0;
		_ = 0;
		DateTime now = CDateTime.Now;
		_lastTimeOffersWereRequested = now;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (System.Object)+C]");
		string uriString = ((OfferwallRequest)0).FormatToString();
		Uri uri = default;
		uri._002Ector(uriString);
		IRequest request = WebClient.CreateGet(uri);
		IRequest request2 = RequestExtensions.WithIgnoreCertificateErrors(request, ignoreCertificateErrors: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		float timeout = default;
		IRequest request3 = RequestExtensions.WithTimeout(request2, timeout);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		WebClient.RequestCompleteHandler requestCompleteHandler = default;
		object obj2 = default;
		requestCompleteHandler._002Ector(obj2, (nint)__ldftn(_003C_003Ec__DisplayClass56_0._003CPostOfferwallRequest_003Eb__0));
		object obj3 = sendOptions + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.WebClient+SendOptions)+18]");
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.WebClient+SendOptions)+10]");
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = false;
		Coroutine coroutine = WebClient.SendRequestAsync(request3, requestCompleteHandler, sendOptions);
	}

	private unsafe void PostExternalIpRequest()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I
		//IL_00cd: Expected native int or pointer, but got VT
		//IL_00e2: Expected native int or pointer, but got VT
		object obj = default;
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj - 48);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Uri uri = default;
		string uriString = default;
		uri._002Ector(uriString);
		IRequest request = KilooWebClient.CreateGet(uri);
		IRequest request2 = RequestExtensions.WithIgnoreCertificateErrors(request, ignoreCertificateErrors: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		float timeout = default;
		IRequest request3 = RequestExtensions.WithTimeout(request2, timeout);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		_requestExternalIpState = RequestStates.InProgress;
		WebClient.RequestCompleteHandler requestCompleteHandler = default;
		requestCompleteHandler._002Ector(this, (nint)__ldftn(TapJoyOfferWallProvider._003CPostExternalIpRequest_003Eb__57_0));
		object obj2 = sendOptions + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.WebClient+SendOptions)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.WebClient+SendOptions)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.WebClient+SendOptions)+18]");
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.WebClient+SendOptions)+10]");
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = false;
		Coroutine coroutine = WebClient.SendRequestAsync(request3, requestCompleteHandler, sendOptions);
	}

	private unsafe static List<TapjoyOffer> DeserializeJsonOffers(string jsonstring)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = Json.Deserialize(jsonstring);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		List<TapjoyOffer> list = default;
		list._002Ector();
		Dictionary<string, object> dictionary = default;
		bool flag = dictionary == null;
		List<TapjoyOffer> result = list;
		if (!flag)
		{
			if (dictionary.TryGetValue("OfferArray", out *(object*)(obj + 12)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
				List<object> resultObject = default;
				List<TapjoyOffer> list2 = ParseOffersFromList(resultObject);
				result = list2;
			}
			else
			{
				LogError("OfferWallResponse dictionary does not contain OfferArray field");
				result = list;
			}
		}
		return result;
	}

	private static List<TapjoyOffer> ParseOffersFromList(List<object> resultObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_1005: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Expected Obj, but got Unknown
		//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f15: Expected Obj, but got Unknown
		//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5e: Expected Obj, but got Unknown
		//IL_0265: Expected Obj, but got I4
		//IL_0246: Expected Obj, but got I4
		//IL_0391: Expected Obj, but got I4
		//IL_0372: Expected Obj, but got I4
		//IL_04bd: Expected Obj, but got I4
		//IL_049e: Expected Obj, but got I4
		//IL_05e9: Expected Obj, but got I4
		//IL_05ca: Expected Obj, but got I4
		//IL_0715: Expected Obj, but got I4
		//IL_06f6: Expected Obj, but got I4
		//IL_0841: Expected Obj, but got I4
		//IL_0822: Expected Obj, but got I4
		//IL_096d: Expected Obj, but got I4
		//IL_094e: Expected Obj, but got I4
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected Obj, but got Unknown
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		List<TapjoyOffer> list = default;
		if (resultObject != null)
		{
			list._002Ector();
			object obj3 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj4 = obj + 32;
			obj = obj4;
			_ = 0;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			object obj13 = default;
			object obj14 = default;
			object obj17 = default;
			object obj18 = default;
			object obj21 = default;
			object obj22 = default;
			object obj24 = default;
			string text = default;
			object obj25 = default;
			object obj26 = default;
			object obj28 = default;
			object obj29 = default;
			object obj30 = default;
			object obj31 = default;
			object obj32 = default;
			object obj33 = default;
			List<TapjoyOffer> list2 = default;
			List<TapjoyOffer> list3 = default;
			object obj35 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj11;
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj7 == null)
						{
							continue;
						}
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj8 == null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj9 == null)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										if (obj10 != null)
										{
											obj11 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S0_v148+8]");
											if ((nint)0 != 0)
											{
												goto IL_103f;
											}
										}
										obj11 = 1;
										goto IL_103f;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
				IL_0ca4:
				_ = 0;
				object obj12 = obj + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_0e78;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
				IL_103f:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj15;
				if ((nint)0 != 1)
				{
					if (obj11 != null)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj13 == null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								if (obj14 != null)
								{
									obj15 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S0_v190+8]");
									if ((nint)0 != 0)
									{
										goto IL_106a;
									}
								}
								obj15 = 1;
								goto IL_106a;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
				IL_10eb:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj16;
				object obj19;
				if ((nint)0 != 1)
				{
					if (obj16 != null)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj17 == null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								if (obj18 != null)
								{
									obj19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ S0_v358+8]");
									if ((nint)0 != 0)
									{
										goto IL_1116;
									}
								}
								obj19 = 1;
								goto IL_1116;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
				IL_1095:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj20;
				object obj23;
				if ((nint)0 != 1)
				{
					if (obj20 != null)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj21 == null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								if (obj22 != null)
								{
									obj23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S0_v274+8]");
									if ((nint)0 != 0)
									{
										goto IL_10c0;
									}
								}
								obj23 = 1;
								goto IL_10c0;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
				IL_0a97:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag = obj24 == null;
					string empty = string.Empty;
					if (flag)
					{
						goto IL_0ca4;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag2 = (nint)0 != 1;
						empty = text;
						if (flag2)
						{
							goto IL_0ca4;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
				IL_1116:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj27;
				if ((nint)0 != 1)
				{
					if (obj19 != null)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj25 == null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								if (obj26 != null)
								{
									obj27 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ S0_v400+8]");
									if ((nint)0 != 0)
									{
										goto IL_1141;
									}
								}
								obj27 = 1;
								goto IL_1141;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
				IL_10c0:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj23 != null)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj28 == null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								if (obj29 != null)
								{
									obj16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S0_v316+8]");
									if ((nint)0 != 0)
									{
										goto IL_10eb;
									}
								}
								obj16 = 1;
								goto IL_10eb;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
				IL_106a:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj15 != null)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj30 == null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								if (obj31 != null)
								{
									obj20 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S0_v232+8]");
									if ((nint)0 != 0)
									{
										goto IL_1095;
									}
								}
								obj20 = 1;
								goto IL_1095;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
				IL_0e78:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag3 = obj32 != obj33;
				List<TapjoyOffer> result = list2;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = list3;
				}
				_ = 0;
				object obj34 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result;
				IL_1141:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj27 != null)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj35 == null)
						{
							goto IL_0a97;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								object obj36 = obj + 28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									goto IL_0a97;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0e78;
			}
			object obj37 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A48");
		}
		return list;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "TapJoyOfferWallProvider: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public static void PrintRequestResponse(string response)
	{
		//IL_0058: Expected F8, but got I4
		//IL_002e: Expected F8, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_0020: Expected F8, but got I4
		//IL_009e: Invalid comparison between Obj and F8
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		int num = response._stringLength / 1000;
		double num2 = Math.Abs((double)num);
		double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)num));
		object obj = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3))
		{
			object obj2 = obj + 1;
			obj = obj2;
		}
	}

	public TapJoyOfferWallProvider()
	{
		List<IDisplayableOffer> list = default;
		list._002Ector();
		_downloadedOffers = list;
		_deviceExternalIP = string.Empty;
	}

	private void _003CPostExternalIpRequest_003Eb__57_0(IRequest request, bool isFromCache)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I4
		//IL_0075: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		bool flag = obj == null;
		string text = null;
		if (!flag)
		{
			object obj2 = obj;
			object obj3 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v26+D4] (should have been resolved before IL gen)");
			string text2 = default;
			text = text2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj4 = default;
		if (obj4 == null || obj == null)
		{
			goto IL_00ae;
		}
		object obj5;
		if (text != null)
		{
			obj5 = 0;
			if (text._stringLength != 0)
			{
				goto IL_013a;
			}
		}
		obj5 = 1;
		goto IL_013a;
		IL_0148:
		RequestStates requestExternalIpState;
		_requestExternalIpState = requestExternalIpState;
		return;
		IL_013a:
		if (obj5 != null)
		{
			goto IL_00ae;
		}
		_deviceExternalIP = text;
		requestExternalIpState = RequestStates.Succeeded;
		goto IL_0148;
		IL_00ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		string text3 = default;
		string msg = "Request external IP failed: " + text3;
		LogError(msg);
		requestExternalIpState = RequestStates.Failed;
		goto IL_0148;
	}
}
