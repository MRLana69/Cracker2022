using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common;
using Kiloo.Common.Backend;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using UnityEngine;

namespace TopRun.Internal;

internal class Manager : IManager, ITournamentPlayerManager
{
	private class Rank : IRank
	{
		private string country__BackingField;

		public int rank
		{
			get
			{
				return field;
			}
			internal set
			{
				field = value;
			}
		}

		public string country
		{
			get
			{
				return country__BackingField;
			}
			internal set
			{
				country__BackingField = value;
			}
		}
	}

	private enum FacebookLoginResult
	{
		Success,
		Failed,
		NotFound
	}

	private sealed class _003CRefreshTournamentCoroutine_003Ed__111(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			Manager manager = _003C_003E4__this;
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 2;
					num = -1;
					if (flag)
					{
						goto IL_0111;
					}
					goto IL_0120;
				}
				_003C_003E1__state = -1;
				if (manager._isRefreshingTournament)
				{
					goto IL_00f3;
				}
				manager._isRefreshPending = false;
			}
			else
			{
				_003C_003E1__state = -1;
				if (manager._isRefreshPending)
				{
					goto IL_0120;
				}
				if (~(manager._isRefreshingTournament ? 1u : 0u) == 0)
				{
					manager._isRefreshPending = true;
					goto IL_00f3;
				}
			}
			manager._isRefreshingTournament = true;
			IEnumerator coroutine = manager.InProcessRefreshTournamentCoroutine();
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			bool result = true;
			num = 2;
			goto IL_0111;
			IL_00f3:
			_003C_003E2__current = null;
			result = true;
			num = 1;
			goto IL_0111;
			IL_0111:
			_003C_003E1__state = num;
			goto IL_0120;
			IL_0120:
			return result;
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

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public bool mustFetchNewTournament;

		internal void _003CInProcessRefreshTournamentCoroutine_003Eb__0(bool isTournamentNotFound)
		{
			if (isTournamentNotFound)
			{
				mustFetchNewTournament = true;
			}
		}
	}

	private sealed class _003CInProcessRefreshTournamentCoroutine_003Ed__112(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private _003C_003Ec__DisplayClass112_0 _003C_003E8__1;

		private SocialManager _003CsocialManager_003E5__2;

		private bool _003CisNewTournament_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0209: Expected Obj, but got I4
			//IL_01ea: Expected Obj, but got I4
			Manager manager = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							if (_003C_003E1__state != 4 && _003C_003E1__state != 5)
							{
								if (_003C_003E1__state != 6 && _003C_003E1__state != 7)
								{
									if (_003C_003E1__state != 8 && _003C_003E1__state != 9)
									{
										if (_003C_003E1__state == 10)
										{
											_003C_003E1__state = -1;
											manager.Save();
											manager.CompleteRefreshProcess(_003CisNewTournament_003E5__3);
										}
										return false;
									}
									_003C_003E1__state = -1;
									if (!manager._pauseRefreshing)
									{
										_003C_003Ec__DisplayClass112_0 obj = _003C_003E8__1;
										if (~(obj.mustFetchNewTournament ? 1u : 0u) == 0)
										{
											manager._isRefreshPending = false;
											manager.InProcessFetchNextTournament();
											return false;
										}
										manager.GetMissingFacebookInfo();
										int num = manager.PropagateUnsubmittedScore();
										if (num >= 1)
										{
											IEnumerator coroutine = manager.RequestSubmitScoreCoroutine(manager.multiplier__BackingField, num, isRetry: false, previouslySavedScore: true);
											Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
										IEnumerator coroutine3 = manager.RequestRanksForPlayers();
										Coroutine coroutine4 = CoroutineUtil.StartCoroutine(coroutine3);
										throw new ArrayTypeMismatchException();
									}
									_003C_003E2__current = null;
									_003C_003E1__state = 9;
								}
								else
								{
									_003C_003E1__state = -1;
									if (!manager._pauseRefreshing)
									{
										manager.PurgeSelfFromParticipants();
										manager.PurgeUnneededIds();
										_003C_003Ec__DisplayClass112_0 obj2 = _003C_003E8__1;
										obj2.mustFetchNewTournament = false;
										throw new ArgumentException();
									}
									_003C_003E2__current = null;
									_003C_003E1__state = 7;
								}
							}
							else
							{
								_003C_003E1__state = -1;
								if (!manager._pauseRefreshing)
								{
									IEnumerator coroutine5 = manager.RequestFindMatchedPlayersByCurrentScore();
									Coroutine coroutine6 = CoroutineUtil.StartCoroutine(coroutine5);
									_003C_003E2__current = coroutine6;
									_003C_003E1__state = 6;
								}
								else
								{
									_003C_003E2__current = null;
									_003C_003E1__state = 5;
								}
							}
							goto IL_06de;
						}
						_003C_003E1__state = -1;
						goto IL_0738;
					}
					_003C_003E1__state = -1;
					SocialManager socialManager = _003CsocialManager_003E5__2;
					if (~(socialManager._consolidatedFriendsCompleted ? 1u : 0u) == 0)
					{
						goto IL_02a2;
					}
					goto IL_0679;
				}
				_003C_003E1__state = -1;
				goto IL_0690;
			}
			_003C_003E1__state = -1;
			_003C_003Ec__DisplayClass112_0 obj3 = default;
			_003C_003E8__1 = obj3;
			object dataSubObjectValue = GetDataSubObjectValue(manager._managerData, "currentTournament", "id");
			bool flag = dataSubObjectValue == null;
			object obj4 = null;
			if (!flag)
			{
				bool flag2 = (object)dataSubObjectValue.GetType() == typeof(string);
				obj4 = dataSubObjectValue;
				if (!flag2)
				{
					obj4 = null;
				}
			}
			object obj5;
			if (obj4 != null)
			{
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v50 (System.Object)+8]");
				if ((nint)0 != 0)
				{
					goto IL_072a;
				}
			}
			obj5 = 1;
			goto IL_072a;
			IL_02a2:
			_003CisNewTournament_003E5__3 = manager._fetchingNewTournament;
			manager._fetchingNewTournament = false;
			goto IL_0738;
			IL_0690:
			if (~(manager._pauseRefreshing ? 1u : 0u) != 0)
			{
				manager.InProcessFetchNextTournament();
				return false;
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_06de:
			return true;
			IL_0738:
			if (!manager._pauseRefreshing)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				IEnumerator coroutine7 = manager.RequestPlayersByFacebookIds();
				Coroutine coroutine8 = CoroutineUtil.StartCoroutine(coroutine7);
				throw new ArrayTypeMismatchException();
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 3;
			goto IL_06de;
			IL_0679:
			_003C_003E2__current = null;
			_003C_003E1__state = 2;
			goto IL_06de;
			IL_072a:
			if (obj5 == null)
			{
				SocialManager instance = SocialManager.instance;
				_003CsocialManager_003E5__2 = instance;
				if (_003CsocialManager_003E5__2 != null)
				{
					SocialManager socialManager2 = _003CsocialManager_003E5__2;
					if (!socialManager2._consolidatedFriendsCompleted)
					{
						goto IL_0679;
					}
				}
				goto IL_02a2;
			}
			goto IL_0690;
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

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public Manager _003C_003E4__this;

		public string newTournamentCountry;

		internal void _003CInProcessFetchNextTournament_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_06af: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b4: Expected Obj, but got Unknown
			//IL_001b: Expected I, but got Obj
			//IL_02f6: Expected Obj, but got I
			//IL_020e: Expected Obj, but got I
			//IL_0239: Expected Obj, but got I
			//IL_025e: Expected Obj, but got I
			//IL_05ce: Expected Obj, but got I
			//IL_05f4: Expected Obj, but got I
			//IL_0526: Expected Obj, but got I4
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_055e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 8;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			IResponse response = default;
			if (response != null)
			{
				nint num = (nint)response;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S1_v115 (Il2CppClass<Kiloo.Common.HTTP.IResponse>)+D4] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = default;
			if (obj4 == null || response == null || !ResponseExtensions.IsJSON(response))
			{
				goto IL_039e;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj5;
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 != 1;
				object obj6 = default;
				obj5 = obj6;
				if (flag)
				{
					goto IL_0708;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj7 = default;
			object obj8 = default;
			bool flag2 = obj7 == obj8;
			bool flag3 = !flag2;
			object obj9 = default;
			obj5 = obj9;
			_003C_003Ec__DisplayClass114_0 obj18 = default;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj11 = default;
					object obj10 = obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj12 = default;
						if (obj12 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
							object obj13 = (nint)0 << 2;
							object obj14 = obj3 + obj13;
							obj14 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
							object obj15 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
							object obj16 = -1;
							goto IL_039e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj17 = obj11;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							return;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj18 = (_003C_003Ec__DisplayClass114_0)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 == 1;
				object obj19 = default;
				obj5 = obj19;
				if (flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_0708;
			IL_0587:
			Manager manager = obj18._003C_003E4__this;
			nint num2 = 0;
			nint num3 = 0;
			IntPtr intPtr = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v496 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S5_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v513 @ S5_v7+4] (should have been resolved before IL gen)");
			nint num6 = 0;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ S5_v11 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v531 @ S5_v12+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			Manager manager2 = obj18._003C_003E4__this;
			nint num8 = 0;
			nint num9 = 0;
			IntPtr intPtr2 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v570 @ S4_v25 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Player>>>)+4] (should have been resolved before IL gen)");
			Dictionary<string, Player> currentTournamentPlayers = default;
			manager2._currentTournamentPlayers = currentTournamentPlayers;
			Manager manager3 = obj18._003C_003E4__this;
			manager3._fetchingNewTournament = true;
			manager3._managerDataIsDirty = true;
			Manager manager4 = manager3;
			goto IL_0782;
			IL_0708:
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				string text = default;
				bool flag5 = text == null;
				string text2 = null;
				if (!flag5)
				{
					bool flag6 = (object)text.GetType() == typeof(string);
					text2 = text;
					if (!flag6)
					{
						text2 = null;
					}
				}
				if (text2 != null)
				{
					Manager manager5 = obj18._003C_003E4__this;
					object dataSubObjectValue = GetDataSubObjectValue(manager5._managerData, "currentTournament", "id");
					bool flag7 = dataSubObjectValue == null;
					string value = null;
					if (!flag7)
					{
						bool flag8 = (object)dataSubObjectValue.GetType() == typeof(string);
						value = (string)dataSubObjectValue;
						if (!flag8)
						{
							value = null;
						}
					}
					bool flag9 = text2.Equals(value);
					Manager manager6 = obj18._003C_003E4__this;
					bool flag10 = !flag9;
					bool flag11 = !flag10;
					manager4 = obj18._003C_003E4__this;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
						Manager manager7 = obj18._003C_003E4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
						object obj22 = default;
						if (obj22 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
							object obj23 = default;
							if (obj23 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
								object obj24 = default;
								if (obj24 == null)
								{
									goto IL_0587;
								}
							}
							string[] tOURNAMENT_PARTICIPANT_LIST_KEYS = TOURNAMENT_PARTICIPANT_LIST_KEYS;
							object obj25 = 0;
							while (tOURNAMENT_PARTICIPANT_LIST_KEYS.Length > (nint)obj25)
							{
								object obj26 = obj25 << 2;
								object obj27 = (object)tOURNAMENT_PARTICIPANT_LIST_KEYS + obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
								object obj28 = obj25 + 1;
								obj25 = obj28;
							}
							Manager manager8 = obj18._003C_003E4__this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
						}
						goto IL_0587;
					}
					goto IL_0782;
				}
			}
			goto IL_039e;
			IL_039e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text3 = default;
			string msg = "FetchNextTournament: Request failed or bad response, status: " + text3;
			LogError(msg);
			obj18._003C_003E4__this.CompleteRefreshProcess(isNewTournament: false);
			return;
			IL_0782:
			IEnumerator coroutine = manager4.InProcessRefreshTournamentCoroutine();
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
		}
	}

	private sealed class _003CRequestPlayersByFacebookIds_003Ed__117(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private IRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_1234: Expected I8, but got I4
			//IL_1243: Unknown result type (might be due to invalid IL or missing references)
			//IL_1248: Expected Obj, but got Unknown
			//IL_0099: Expected Obj, but got I8
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected Obj, but got Unknown
			//IL_0178: Expected I4, but got Obj
			//IL_104b: Expected Obj, but got I4
			//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bd: Expected Obj, but got Unknown
			//IL_0197: Expected Obj, but got I
			//IL_107b: Expected Obj, but got I
			//IL_108b: Expected Obj, but got I
			//IL_0506: Expected Obj, but got I
			//IL_1363: Unknown result type (might be due to invalid IL or missing references)
			//IL_1368: Expected Obj, but got Unknown
			//IL_03bd: Expected Obj, but got I
			//IL_10cf: Expected Obj, but got I
			//IL_0672: Unknown result type (might be due to invalid IL or missing references)
			//IL_0677: Expected Obj, but got Unknown
			//IL_06ae: Expected Obj, but got I
			//IL_0a20: Expected Obj, but got I
			//IL_03dc: Expected Obj, but got I
			//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adb: Expected Obj, but got Unknown
			//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af6: Expected Obj, but got Unknown
			//IL_0b1f: Expected I4, but got Obj
			//IL_0992: Expected Obj, but got I
			//IL_08d8: Expected Obj, but got I
			//IL_0903: Expected Obj, but got I
			//IL_0928: Expected Obj, but got I
			//IL_113e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1143: Expected Ref, but got Unknown
			//IL_118f: Expected Obj, but got I
			//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dd: Expected Obj, but got Unknown
			//IL_05f9: Expected Obj, but got I4
			//IL_0616: Expected VT, but got Obj
			//IL_028c: Expected Obj, but got I
			//IL_028c: Expected Obj, but got I4
			//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed7: Expected Obj, but got Unknown
			//IL_0413: Expected Obj, but got I
			//IL_11c4: Expected Obj, but got I
			//IL_11de: Expected Obj, but got I
			//IL_0f1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f23: Expected Obj, but got Unknown
			//IL_0f5d: Expected Obj, but got I
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ff: Expected Obj, but got Unknown
			//IL_039e: Expected Obj, but got I
			//IL_0bfe: Expected Obj, but got I4
			//IL_0c55: Expected Obj, but got I4
			//IL_0d0d: Expected Obj, but got I4
			//IL_0d9e: Expected Obj, but got I4
			//IL_0d9e: Expected Obj, but got I4
			object obj = default;
			Manager manager = (Manager)(obj - 96);
			manager.m_playerInfoChanged = null;
			manager.rank__BackingField = null;
			manager.multiplier__BackingField = 0;
			manager._lastTournamentUpdateParticipantsPublicKeys = null;
			_ = 0;
			manager._lastTournamentUpdate = 0L;
			_ = 0;
			List<object> list = (List<object>)(manager + 40);
			_ = 0;
			Manager manager2 = _003C_003E4__this;
			Manager manager3;
			bool result;
			bool flag17;
			bool result2 = default;
			bool flag5;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj2 = default;
					if (obj2 != null)
					{
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v190 @ S1_v266+D4] (should have been resolved before IL gen)");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj4 = default;
					bool flag = obj4 == null;
					manager3 = manager2;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						IResponse response = default;
						bool flag2 = ResponseExtensions.IsJSON(response);
						bool flag3 = !flag2;
						manager3 = manager2;
						if (!flag3)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 != 1;
							flag5 = !flag4;
							if (!flag5)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									object obj5 = default;
									bool flag6 = obj5 == null;
									manager3 = manager2;
									if (!flag6)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
										object obj6 = default;
										bool flag7 = obj6 == null;
										manager3 = manager2;
										if (!flag7)
										{
											DateTime utcNow = CDateTime.UtcNow;
											long lastFriendsUpdate = TimeUtility.ToUnixTime(utcNow);
											manager2._lastFriendsUpdate = lastFriendsUpdate;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
											Rank[] currentTournamentRanks = (Rank[])(manager + 56);
											manager._currentTournamentRanks = currentTournamentRanks;
											Dictionary<string, Rank> ranks = (Dictionary<string, Rank>)(manager + 60);
											manager._ranks = ranks;
											manager._playerIdData = null;
											manager._playerIdDataIsDirty = (byte)(int)manager._ranks != 0;
											object obj7 = default;
											string text = default;
											object obj8 = default;
											object obj9 = default;
											bool flag11 = default;
											object playerIdData = default;
											bool flag12 = default;
											while (true)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag8 = (nint)0 == 1;
												flag5 = !flag8;
												if (!flag5)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												else
												{
													if (obj7 == null)
													{
														goto IL_0ec9;
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
															if (text == null)
															{
																continue;
															}
															_ = 0;
															string text2 = JsonObject.Get(10404, text, "FacebookId");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															bool flag9 = (nint)0 != 1;
															flag5 = !flag9;
															if (!flag5)
															{
																_ = 0;
																List<object> list2 = (List<object>)(object)JsonObject.Get(10404, text, "PublicKey");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	if (text2 == null || list2 == null)
																	{
																		continue;
																	}
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		((Dictionary<string, object>)7295)._002Ector();
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				_ = 0;
																				JsonObject.Get(2148, (string)1, (string)(object)typeof(IDictionary), (IFormatProvider)manager2._playerIdData);
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					manager2._playerIdDataIsDirty = true;
																					continue;
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			goto IL_0e32;
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
															goto IL_0e32;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
												goto IL_0e32;
												IL_0e32:
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
												bool flag10 = obj8 != obj9;
												result = flag11;
												if (flag10)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
												manager._playerIdData = (IDictionary)playerIdData;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													goto IL_0ec9;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
												result = flag12;
												break;
												IL_0ec9:
												object obj10 = manager + 16;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
												manager3 = manager2;
												goto IL_0fbf;
											}
											_ = 0;
											object obj11 = manager + 16;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag13 = (nint)0 != 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											_003CRequestPlayersByFacebookIds_003Ed__117 obj12 = (_003CRequestPlayersByFacebookIds_003Ed__117)0;
											manager3 = manager2;
											if (!flag13)
											{
												goto IL_0f73;
											}
											goto IL_11e4;
										}
									}
									goto IL_12f2;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							object obj13 = default;
							object obj14 = default;
							bool flag14 = obj13 != obj14;
							bool flag15 = default;
							result = flag15;
							if (!flag14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									object obj16 = default;
									object obj15 = obj16;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										object obj17 = default;
										flag5 = obj17 == null;
										if (!flag5)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (System.Collections.Generic.List`1<System.Object>)+4]");
											object obj18 = (nint)0 << 2;
											object obj19 = (object)list + obj18;
											obj19 = obj16;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (System.Collections.Generic.List`1<System.Object>)+4]");
											object obj20 = (nint)0 + (nint)1;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (System.Collections.Generic.List`1<System.Object>)+4]");
											object obj21 = -1;
											manager3 = manager2;
											goto IL_12f2;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
										object obj22 = obj16;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag16 = (nint)0 != 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										_003CRequestPlayersByFacebookIds_003Ed__117 obj12 = (_003CRequestPlayersByFacebookIds_003Ed__117)0;
										manager3 = manager2;
										flag17 = flag5;
										if (flag16)
										{
											goto IL_0fa3;
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag18 = (nint)0 != 1;
								bool flag19 = default;
								result = flag19;
								if (!flag18)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									_003CRequestPlayersByFacebookIds_003Ed__117 obj12 = (_003CRequestPlayersByFacebookIds_003Ed__117)0;
									manager3 = manager2;
									goto IL_0f73;
								}
							}
							goto IL_11e4;
						}
					}
					goto IL_12f2;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("toprun_friends_refresh_interval", 1800);
				DateTime utcNow2 = CDateTime.UtcNow;
				long num = TimeUtility.ToUnixTime(utcNow2);
				object obj23 = value + manager2._lastFriendsUpdate;
				if (num > (long)obj23)
				{
					IList<FacebookProfile> facebookFriendsWithNoPublicKeys = manager2.GetFacebookFriendsWithNoPublicKeys();
					if (facebookFriendsWithNoPublicKeys != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj24 = default;
						if ((nint)obj24 >= 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							List<object> list3 = default;
							int capacity = default;
							list3._002Ector(capacity);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							EventHandler<PlayerInfoChangedEventArgs> playerInfoChanged = default;
							manager.m_playerInfoChanged = playerInfoChanged;
							Dictionary<string, Rank> ranks2 = (Dictionary<string, Rank>)(manager + 92);
							manager._ranks = ranks2;
							manager._playerIdData = null;
							manager._playerIdDataIsDirty = (byte)(int)manager._ranks != 0;
							object obj25 = default;
							Manager manager4 = default;
							object obj27 = default;
							object obj28 = default;
							bool flag23 = default;
							object playerIdData2 = default;
							bool flag24 = default;
							Uri uri = default;
							object jsonData = default;
							while (true)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag20 = (nint)0 == 1;
								flag5 = !flag20;
								if (!flag5)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									manager3 = (Manager)0;
								}
								else
								{
									if (obj25 == null)
									{
										goto IL_04af;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v188+8]");
												string text3 = JsonObject.Get<string>(10419, (string)0, null, (IFormatProvider)manager4);
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													if (text3 == null)
													{
														continue;
													}
													_ = 0;
													manager._ranks = (Dictionary<string, Rank>)manager.rank__BackingField;
													object obj26 = manager + 32;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag21 = (nint)0 != 1;
													flag5 = !flag21;
													if (!flag5)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															continue;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													manager3 = (Manager)0;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													manager3 = (Manager)0;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												manager3 = manager4;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											manager3 = (Manager)0;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										manager3 = (Manager)0;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								bool flag22 = obj27 != obj28;
								result = flag23;
								if (flag22)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								manager._playerIdData = (IDictionary)playerIdData2;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									goto IL_04af;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								result = flag24;
								break;
								IL_04af:
								object obj29 = manager + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
								nint num2 = 0;
								nint num3 = 0;
								IntPtr intPtr = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v825 @ S4_v20 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
								nint num4 = 0;
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ S5_v19 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v841 @ S5_v20+4] (should have been resolved before IL gen)");
								string uriString = manager.MakeApiURL("/facebook/getplayersbyfacebookids");
								uri._002Ector(uriString);
								IRequest request = KilooWebClient.CreatePost(uri);
								IRequest request2 = RequestExtensions.WithJsonContent(request, jsonData);
								float requestTimeout = manager.requestTimeout;
								IRequest request3 = RequestExtensions.WithTimeout(request2, requestTimeout);
								float requestMinBackOffTime = manager.requestMinBackOffTime;
								IRequest request4 = RequestExtensions.WithMinBackOffTime(request3, requestMinBackOffTime);
								float requestMaxBackOffTime = manager.requestMaxBackOffTime;
								IRequest request5 = RequestExtensions.WithMaxBackOffTime(request4, requestMaxBackOffTime);
								_003Crequest_003E5__2 = request5;
								object obj31 = manager - -64;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
								manager._managerData = (IDictionary)manager.multiplier__BackingField;
								manager = (Manager)manager._lastTournamentUpdateParticipantsPublicKeys;
								Coroutine coroutine = RequestExtensions.SendAsync(_003Crequest_003E5__2, null, (WebClient.SendOptions)manager);
								_003C_003E2__current = coroutine;
								_003C_003E1__state = 1;
								result2 = true;
								goto IL_1277;
							}
							_ = 0;
							object obj32 = manager + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag25 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							_003CRequestPlayersByFacebookIds_003Ed__117 obj12 = (_003CRequestPlayersByFacebookIds_003Ed__117)0;
							if (flag25)
							{
								goto IL_0f73;
							}
							goto IL_11e4;
						}
					}
				}
			}
			goto IL_1277;
			IL_0fa3:
			flag5 = flag17;
			goto IL_12f2;
			IL_0f73:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			flag17 = flag5;
			goto IL_0fa3;
			IL_11e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
			IL_12f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text4 = default;
			string msg = "LookupFriendPublicKeys: Request failed or bad response, status: " + text4;
			LogError(msg);
			goto IL_0fbf;
			IL_0fbf:
			SocialManager instance2 = SocialManager.instance;
			bool facebookIsLoggedIn = instance2.facebookIsLoggedIn;
			bool flag26 = !facebookIsLoggedIn;
			result2 = false;
			if (!flag26)
			{
				int num6 = instance2._consolidationState & 1;
				bool flag27 = num6 == 0;
				result2 = false;
				if (!flag27)
				{
					Friend[] array = instance2.FriendsSortedByScore();
					object obj33 = 0;
					while (true)
					{
						bool flag28 = (nint)obj33 >= array.Length;
						result2 = false;
						if (flag28)
						{
							break;
						}
						object obj34 = obj33 << 2;
						object obj35 = (object)array + obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S0_v52+10]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v53+20]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v53+20]");
						if ((nint)0 != 0)
						{
							IDictionary playerIdData3 = manager3._playerIdData;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v54+8]");
							object dataSubObjectValue = GetDataSubObjectValue(playerIdData3, (string)0, "publicKey");
							bool flag29 = dataSubObjectValue == null;
							object obj38 = null;
							if (!flag29)
							{
								bool flag30 = (object)dataSubObjectValue.GetType() == typeof(string);
								obj38 = dataSubObjectValue;
								if (!flag30)
								{
									obj38 = null;
								}
							}
							if (obj38 != null)
							{
								bool flag31 = manager3._currentTournamentPlayers.TryGetValue((string)obj38, out *(Player*)(manager + 52));
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (TopRun.Internal.Manager)+34]");
								bool flag32 = (nint)0 == 0;
								flag5 = !flag32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (TopRun.Internal.Manager)+34]");
								object obj39 = 0;
								if (!flag5)
								{
									nint num7 = 0;
									nint num8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ S5_v10 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Player>>)+5C]");
									object obj40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v968 @ S5_v11+4] (should have been resolved before IL gen)");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (TopRun.Internal.Manager)+34]");
									obj39 = 0;
								}
								_ = 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S0_v53+20]");
								_ = 0;
							}
						}
						object obj41 = obj33 + 1;
						obj33 = obj41;
					}
				}
			}
			goto IL_1277;
			IL_1277:
			return result2;
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

	private sealed class _003CRequestFindMatchedPlayers_003Ed__119(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private IRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected Obj, but got Unknown
			//IL_00c7: Expected Obj, but got I4
			//IL_0214: Expected Obj, but got I4
			//IL_01f5: Expected Obj, but got I4
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected I4, but got Unknown
			object obj = default;
			Manager manager = (Manager)(obj - 48);
			manager._fetchingNewTournament = false;
			manager._ranks = null;
			Manager manager2 = _003C_003E4__this;
			object obj8;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (!manager2.HandleFindMatchedPlayersResponse(_003Crequest_003E5__2, "participants", "participantsTimeStamp"))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						string text = default;
						string msg = "RequestFindMatchedPlayers: Request failed or bad response, status: " + text;
						LogError(msg);
					}
					_003Crequest_003E5__2 = null;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				IDictionary dictionary = JsonObject.Get<IDictionary>(manager2._managerData, "currentTournament", null, null);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
				DateTime utcNow = CDateTime.UtcNow;
				long num = TimeUtility.ToUnixTime(utcNow);
				object obj2 = default;
				bool flag = num < (long)obj2;
				bool flag2 = !flag;
				object obj3 = obj2;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
					obj3 = 0;
				}
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("toprun_stranger_amount_retry_interval", 3600);
				object obj4 = value + obj3;
				int num2 = default;
				if (num > (long)obj4)
				{
					OnlineSettings instance2 = OnlineSettings.instance;
					int value2 = instance2.GetValue("toprun_stranger_amount", 10);
					object dataSubObjectValue = GetDataSubObjectValue(manager2._managerData, "currentTournament", "participants");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
					object obj5 = default;
					bool flag3 = obj5 == null;
					num2 = value2;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj6 = default;
						int num3 = value2 - obj6;
						num2 = num3;
					}
				}
				object dataSubObjectValue2 = GetDataSubObjectValue(manager2._managerData, "currentTournament", "id");
				bool flag4 = dataSubObjectValue2 == null;
				object obj7 = null;
				if (!flag4)
				{
					bool flag5 = (object)dataSubObjectValue2.GetType() == typeof(string);
					obj7 = dataSubObjectValue2;
					if (!flag5)
					{
						obj7 = null;
					}
				}
				if (num2 >= 1)
				{
					if (obj7 != null)
					{
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v44 (System.Object)+8]");
						if ((nint)0 != 0)
						{
							goto IL_05b3;
						}
					}
					obj8 = 1;
					goto IL_05b3;
				}
			}
			goto IL_052d;
			IL_052d:
			return true;
			IL_05b3:
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				string text2 = manager.MakeApiURL("/tournaments/findmatchedplayers");
				throw new ArrayTypeMismatchException();
			}
			goto IL_052d;
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

	private sealed class _003CRequestFindMatchedPlayersByCurrentScore_003Ed__121(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private IRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected I4, but got Unknown
			object obj = default;
			Manager manager = (Manager)(obj - 48);
			manager._fetchingNewTournament = false;
			manager._ranks = null;
			Manager manager2 = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (!manager2.HandleFindMatchedPlayersResponse(_003Crequest_003E5__2, "scoreMatchedParticipants", "scoreMatchedParticipantsTimeStamp"))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						string text = default;
						string msg = "RequestFindMatchedPlayersByCurrentScore: Request failed or bad response, status: " + text;
						LogError(msg);
					}
					_003Crequest_003E5__2 = null;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				IDictionary jsonObject = JsonObject.Get<IDictionary>(manager2._managerData, "currentTournament", null, null);
				int amountOfChallengersToRequest = manager2.GetAmountOfChallengersToRequest();
				if (amountOfChallengersToRequest >= 1)
				{
					IList list = JsonObject.Get<IList>(jsonObject, "scoreMatchedParticipants", null, null);
					bool flag = list == null;
					int num = amountOfChallengersToRequest;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj2 = default;
						int num2 = amountOfChallengersToRequest - obj2;
						bool flag2 = num2 < 1;
						num = num2;
						if (flag2)
						{
							goto IL_0438;
						}
					}
					string text2 = JsonObject.Get(jsonObject, "id", string.Empty);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string text3 = manager.MakeApiURL("/tournaments/findmatchedplayersbycurrentscore");
					throw new ArrayTypeMismatchException();
				}
			}
			goto IL_0438;
			IL_0438:
			return true;
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

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public FacebookProfile profile;

		public Player player;

		public Manager _003C_003E4__this;

		internal void _003CGetMissingFacebookInfoCoroutine_003Eb__0(Texture2D image)
		{
			//IL_000d: Expected I, but got Obj
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected Obj, but got Unknown
			//IL_004d: Expected I, but got Obj
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected Obj, but got Unknown
			Texture2D texture2D = default;
			Texture2D texture2D2 = default;
			if (texture2D != null)
			{
				nint num = (nint)texture2D;
				object obj = texture2D + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v10 (Il2CppClass<UnityEngine.Texture2D>)+DC] (should have been resolved before IL gen)");
				object obj2 = default;
				if ((nint)obj2 == 8)
				{
					nint num2 = (nint)texture2D;
					object obj3 = texture2D + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S3_v3 (Il2CppClass<UnityEngine.Texture2D>)+EC] (should have been resolved before IL gen)");
					object obj4 = default;
					bool flag = (nint)obj4 == 8;
					texture2D2 = null;
					if (!flag)
					{
						texture2D2 = texture2D;
					}
				}
			}
			if (texture2D2 != null)
			{
				FacebookProfile facebookProfile = profile;
				facebookProfile.image = texture2D2;
				_003C_003E4__this.FirePlayerInfoChangedEvent(player);
			}
		}
	}

	private sealed class _003CGetMissingFacebookInfoCoroutine_003Ed__123(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private _003C_003Ec__DisplayClass123_0 _003C_003E8__1;

		private List<Player>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0034: Expected Obj, but got I4
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected Obj, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			bool flag = _003C_003E1__state != -3;
			object obj3 = _003C_003E1__state - 1;
			if ((nint)obj3 <= 1)
			{
				flag = false;
			}
			if (!flag)
			{
				object obj4 = obj + 28;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj5 = obj + 20;
				object obj6 = obj5;
				((_003CGetMissingFacebookInfoCoroutine_003Ed__123)obj6)._003C_003Em__Finally1();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @254");
				}
			}
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0885: Unknown result type (might be due to invalid IL or missing references)
			//IL_088a: Expected Obj, but got Unknown
			//IL_08b2: Expected Obj, but got I
			//IL_08c2: Expected Obj, but got I
			//IL_0914: Expected Obj, but got I
			//IL_0924: Expected Obj, but got I
			//IL_080e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0813: Expected Obj, but got Unknown
			//IL_0121: Expected Obj, but got I
			//IL_09ad: Expected Obj, but got I
			//IL_0167: Expected Obj, but got I4
			//IL_0992: Expected Obj, but got I
			//IL_018b: Expected Obj, but got I
			//IL_0194: Expected Obj, but got I4
			//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f5: Expected Obj, but got Unknown
			//IL_0604: Expected Obj, but got I
			//IL_0614: Expected Obj, but got I
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected Obj, but got Unknown
			//IL_0240: Expected Obj, but got I
			//IL_01a9: Expected Obj, but got I
			//IL_01bf: Expected Obj, but got I
			//IL_01c8: Expected Obj, but got I4
			//IL_06d5: Expected Obj, but got I
			//IL_06ea: Expected Obj, but got I
			//IL_05c6: Expected Obj, but got I
			//IL_0318: Expected Obj, but got I
			//IL_032d: Expected Obj, but got I
			//IL_033d: Expected Obj, but got I
			//IL_035a: Expected Obj, but got I
			//IL_036a: Expected Obj, but got I
			//IL_0387: Expected Obj, but got I
			//IL_0397: Expected Obj, but got I
			//IL_03a7: Expected Obj, but got I
			//IL_03c4: Expected Obj, but got I
			//IL_03d4: Expected Obj, but got I
			//IL_03e4: Expected Obj, but got I
			//IL_05ef: Expected Obj, but got I4
			//IL_04ad: Expected Obj, but got I
			//IL_04bd: Expected Obj, but got I
			//IL_04cd: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 48;
			object obj3 = obj + 44;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
			bool result;
			object obj6;
			object obj7;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
					if ((nint)0 != 2)
					{
						result = false;
						obj6 = obj;
						goto IL_08e7;
					}
					_ = -3;
					obj7 = 0;
					goto IL_0942;
				}
				_ = -3;
				goto IL_0904;
			}
			_ = -1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj9 = default;
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					_ = -3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					obj9 = 0;
					obj7 = 1;
					goto IL_0942;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0733;
			IL_08e7:
			object obj10 = obj6 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95F3");
			return result;
			IL_0566:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0733;
			IL_052a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0733;
			IL_0539:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0733;
			IL_0904:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			object obj12 = 0;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+44]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v146+14]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v150+8]");
				object obj14 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj16 = 0;
							_ = 2;
							result = true;
							obj6 = obj;
							goto IL_08e7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_0733;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0733;
			}
			goto IL_0997;
			IL_0548:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0733;
			IL_0733:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj17 = default;
			object obj18 = default;
			bool flag = obj17 == obj18;
			bool flag2 = !flag;
			object obj19 = default;
			obj12 = obj19;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 != 1;
				result = false;
				obj6 = obj;
				if (flag3)
				{
					goto IL_08e7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj20 = default;
				obj12 = obj20;
			}
			_ = 0;
			object obj21 = obj + 32;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			goto IL_0997;
			IL_0575:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj22 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				result = false;
				obj6 = obj;
				goto IL_08e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0733;
			IL_0997:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ L1_v3+2C]");
			object obj23 = 0;
			_ = 1;
			result = true;
			goto IL_08e7;
			IL_0942:
			object obj24 = obj7;
			object obj28 = default;
			object obj40 = default;
			object obj44 = default;
			while (true)
			{
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj25 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					obj9 = 0;
					obj24 = 1;
					continue;
				}
				_ = 0;
				object obj26 = obj9 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj27 = 0;
				if (obj28 != null)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_052a;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj29 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v82+14]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj32 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S0_v85+14]");
							object obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v35+24]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S0_v88+14]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S0_v89+C]");
							object obj36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S1_v41+14]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj37 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v91+14]");
							object obj38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S0_v92+8]");
							object obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S0_v92+8]");
							if ((nint)0 != 0)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_0548;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_0557;
								}
								if (obj40 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
									object obj41 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S0_v121+14]");
									object obj42 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S0_v122+8]");
									object obj43 = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										goto IL_0566;
									}
									if (obj44 == null)
									{
										goto IL_0904;
									}
								}
							}
							obj24 = 0;
							continue;
						}
					}
					goto IL_0539;
				}
				goto IL_0575;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0733;
			IL_0557:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0733;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
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

	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public Action<Texture2D> onComplete;

		internal void _003CDownloadFacebookImage_003Eb__0(IRequest request, bool cache)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			bool flag = obj == null;
			Texture2D texture2D = null;
			Texture2D texture2D3;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				IResponse response = default;
				bool flag2 = ResponseExtensions.IsTexture(response);
				bool flag3 = !flag2;
				texture2D = null;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					IResponse response2 = default;
					Texture2D texture2D2 = ResponseExtensions.AsTexture(response2);
					bool flag4 = texture2D2 == null;
					texture2D = texture2D2;
					texture2D3 = texture2D2;
					if (!flag4)
					{
						goto IL_00c3;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text = default;
			string msg = "RequestUserInfoFromFacebook: Request failed or bad response, status: " + text;
			LogError(msg);
			texture2D3 = texture2D;
			goto IL_00c3;
			IL_00c3:
			Action<Texture2D> action = onComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S0_v11 (System.Action`1<UnityEngine.Texture2D>)+C] (should have been resolved before IL gen)");
		}
	}

	private sealed class _003CRequestTournamentData_003Ed__129(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		public Action<bool> onComplete;

		private IRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_1c96: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c9b: Expected Obj, but got Unknown
			//IL_06c4: Expected I, but got Obj
			//IL_1cd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd8: Expected I4, but got Unknown
			//IL_03a8: Expected Obj, but got I
			//IL_03ce: Expected Obj, but got I
			//IL_060e: Expected Obj, but got I4
			//IL_1c3c: Expected Obj, but got I4
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected Obj, but got Unknown
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0272: Expected I8, but got Unknown
			//IL_029b: Expected I4, but got I8
			//IL_1d76: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d7b: Expected Obj, but got Unknown
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Expected Obj, but got Unknown
			//IL_04c9: Expected Obj, but got I
			//IL_04d9: Expected Obj, but got I
			//IL_04e9: Expected VT, but got Obj
			//IL_050b: Expected Obj, but got I4
			//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e2: Expected Obj, but got Unknown
			//IL_1d4c: Expected Obj, but got I8
			//IL_01d2: Expected I8, but got I4
			//IL_01db: Expected I8, but got I4
			//IL_0643: Unknown result type (might be due to invalid IL or missing references)
			//IL_0648: Expected Obj, but got Unknown
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Expected Obj, but got Unknown
			//IL_1b32: Expected Obj, but got I4
			//IL_1a19: Expected Obj, but got I
			//IL_1a33: Expected Obj, but got I4
			//IL_1a49: Expected Obj, but got I
			//IL_1a6e: Expected Obj, but got I
			//IL_1a84: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a89: Expected Obj, but got Unknown
			//IL_1b08: Expected Obj, but got I
			//IL_0aca: Expected Obj, but got I4
			//IL_0918: Expected Obj, but got I
			//IL_0943: Expected Obj, but got I
			//IL_09b3: Expected Obj, but got I
			//IL_09c1: Expected Obj, but got I4
			//IL_0b0b: Expected Obj, but got I4
			//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bef: Expected Obj, but got Unknown
			//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cbb: Expected Obj, but got Unknown
			//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d87: Expected Obj, but got Unknown
			//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e15: Expected Obj, but got Unknown
			//IL_0eb5: Expected Obj, but got I4
			//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec3: Expected Obj, but got Unknown
			//IL_1eb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ebd: Expected Obj, but got Unknown
			//IL_13e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e9: Expected I8, but got Unknown
			//IL_1412: Expected I4, but got I8
			//IL_1f01: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f06: Expected Obj, but got Unknown
			//IL_16a9: Expected Obj, but got I4
			//IL_10b0: Expected Obj, but got I4
			//IL_10b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_10be: Expected Obj, but got Unknown
			//IL_17e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_17ed: Expected Obj, but got Unknown
			//IL_14b8: Expected I8, but got I
			//IL_1503: Expected Obj, but got I8
			//IL_1f55: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f5a: Expected Obj, but got Unknown
			//IL_1304: Unknown result type (might be due to invalid IL or missing references)
			//IL_1309: Expected Obj, but got Unknown
			//IL_188c: Expected Obj, but got I
			//IL_169b: Expected Obj, but got I4
			object obj = default;
			Manager manager = (Manager)(obj - 144);
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			manager.m_tournamentChanged = null;
			manager.rank__BackingField = null;
			object obj2 = manager - -64;
			_ = 0;
			Manager manager2 = _003C_003E4__this;
			object obj8;
			bool result;
			bool flag4;
			bool flag7;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_1cca;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				IResponse response = default;
				if (response != null)
				{
					nint num = (nint)response;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ S1_v465 (Il2CppClass<Kiloo.Common.HTTP.IResponse>)+D4] (should have been resolved before IL gen)");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj3 = default;
				if (obj3 != null && response != null && ResponseExtensions.IsJSON(response))
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag = (nint)0 != 1;
							object obj5 = default;
							object obj4 = obj5;
							if (!flag)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								object obj6 = default;
								object obj7 = default;
								bool flag2 = obj6 != obj7;
								obj8 = obj6;
								bool flag3 = default;
								result = flag3;
								if (!flag2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										object obj10 = default;
										object obj9 = obj10;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj11 = default;
											if (obj11 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+8]");
												object obj12 = (nint)0 << 2;
												object obj13 = obj2 + obj12;
												obj13 = obj10;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+8]");
												object obj14 = (nint)0 + (nint)1;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													goto IL_18a0;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+8]");
												object obj15 = -1;
												obj4 = 0;
												goto IL_1e0a;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
											object obj16 = obj10;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												flag4 = false;
												goto IL_1db0;
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag5 = (nint)0 == 1;
									object obj17 = default;
									obj8 = obj17;
									bool flag6 = default;
									result = flag6;
									flag4 = flag6;
									if (flag5)
									{
										goto IL_1db0;
									}
								}
								goto IL_192b;
							}
							goto IL_1e0a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					goto IL_18a0;
				}
				if (response == null)
				{
					flag7 = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj18 = default;
					bool flag8 = (nint)obj18 == 404;
					flag7 = flag8;
				}
				goto IL_1be9;
			}
			_003C_003E1__state = -1;
			object dataSubObjectValue = GetDataSubObjectValue(manager2._managerData, "currentTournament", "id");
			bool flag9 = dataSubObjectValue == null;
			object obj19 = null;
			if (!flag9)
			{
				bool flag10 = (object)dataSubObjectValue.GetType() == typeof(string);
				obj19 = dataSubObjectValue;
				if (!flag10)
				{
					obj19 = null;
				}
			}
			DateTime utcNow = CDateTime.UtcNow;
			long num2 = TimeUtility.ToUnixTime(utcNow);
			bool flag11 = manager2.tournament__BackingField == null;
			bool flag12 = true;
			object key;
			int defaultValue;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				string text = default;
				bool flag13 = (string)obj19 == text;
				bool flag14 = !flag13;
				flag12 = true;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj20 = default;
					if (obj20 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						object obj21 = default;
						if (obj21 == null)
						{
							key = "toprun_refresh_interval_when_result_is_due";
							defaultValue = 30;
							goto IL_1d1c;
						}
					}
					key = "toprun_refresh_interval";
					defaultValue = 300;
					goto IL_1d1c;
				}
			}
			goto IL_1cf8;
			IL_1dd3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
			IL_116e:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			IRank rank;
			Tournament tournament = default;
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj22 = default;
					bool flag15 = obj22 == null;
					rank = null;
					if (!flag15)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj23 = default;
							bool flag16 = (nint)obj23 < 0;
							rank = null;
							if (flag16)
							{
								goto IL_1e8e;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								object obj24 = default;
								bool flag17 = obj24 == null;
								rank = null;
								if (flag17)
								{
									goto IL_1e8e;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									object obj26 = default;
									object obj25 = obj26 + 1;
									bool flag18 = tournament.sequenceId__BackingField != (nint)obj25;
									rank = null;
									if (flag18)
									{
										goto IL_1e8e;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											IRank rank2 = default;
											rank = rank2;
											goto IL_1e8e;
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
						goto IL_18a0;
					}
					goto IL_1e8e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_18a0;
			IL_1cca:
			object obj27 = default;
			return (byte)(obj27 & 1) != 0;
			IL_1db0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			result = flag4;
			goto IL_1dd3;
			IL_1830:
			object obj28;
			bool flag19 = obj28 == null;
			flag7 = false;
			if (!flag19)
			{
				bool flag20 = (nint)obj28 == 21;
				flag7 = false;
				if (!flag20)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj27 = 0;
					goto IL_1cca;
				}
			}
			goto IL_1c18;
			IL_05f1:
			Action<bool> action = onComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v710 @ S0_v95 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
			obj27 = 0;
			goto IL_1cca;
			IL_1be9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text2 = default;
			string msg = "GetTournamentData: Request failed or bad response, status: " + text2;
			LogError(msg);
			goto IL_1c18;
			IL_1e8e:
			manager2.rank__BackingField = rank;
			manager2._managerDataIsDirty = true;
			_ = 0;
			object obj29 = manager + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = manager._ranks;
				_ = manager._rankData;
				manager.m_tournamentChanged = (EventHandler<TournamentChangedEventArgs>)(object)manager._playerIdData;
				long lastTournamentUpdate = manager + 88;
				manager._lastTournamentUpdate = lastTournamentUpdate;
				manager._playerIdData = null;
				manager._playerIdDataIsDirty = (byte)manager._lastTournamentUpdate != 0;
				object obj31 = default;
				object obj32 = default;
				object obj33 = default;
				bool flag22 = default;
				object playerIdData = default;
				object obj34 = default;
				bool flag23 = default;
				while (true)
				{
					_ = 0;
					object obj30 = manager + 88;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						if (obj31 == null)
						{
							obj28 = 21;
							goto IL_17d9;
						}
						_ = 0;
						Manager manager3 = manager;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (TopRun.Internal.Manager)+64]");
						manager3._lastTournamentUpdate = 0L;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							manager.rank__BackingField = (IRank)manager._lastTournamentUpdate;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									ITournament tournament2 = manager.tournament__BackingField;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag21 = obj32 != obj33;
					obj8 = obj32;
					flag4 = flag22;
					if (flag21)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					manager._playerIdData = (IDictionary)playerIdData;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						obj28 = 0;
						goto IL_17d9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj8 = obj34;
					flag4 = flag23;
					break;
					IL_17d9:
					_ = 0;
					object obj35 = manager + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_1830;
					}
					goto IL_1891;
				}
				_ = 0;
				object obj36 = manager + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					result = flag4;
					goto IL_192b;
				}
				goto IL_1db0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_18a0;
			IL_192b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj37 = default;
			if (obj37 == obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag24 = default;
					bool value = ((bool*)(flag24 ? 1 : 0))->m_value;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj38 = default;
						if (obj38 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+8]");
							object obj39 = (nint)0 << 2;
							object obj40 = obj2 + obj39;
							obj40 = ((bool*)(flag24 ? 1 : 0))->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+8]");
							object obj41 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+8]");
							object obj42 = (nint)0 << 2;
							object obj43 = obj42 + obj2;
							object obj44 = obj43 - 4;
							object obj45 = obj44;
							bool flag25 = obj44 == null;
							string text3 = null;
							string text4 = "GetTournamentData: Error creating tournament object from received data: ";
							if (!flag25)
							{
								object obj46 = obj45;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1424 @ S1_v176+D4] (should have been resolved before IL gen)");
								string text5 = default;
								text3 = text5;
								text4 = "GetTournamentData: Error creating tournament object from received data: ";
							}
							string msg2 = text4 + text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
							LogError(msg2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16+8]");
							object obj47 = -1;
							flag7 = false;
							goto IL_1be9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj48 = ((bool*)(flag24 ? 1 : 0))->m_value;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag26 = (nint)0 != 1;
						flag4 = flag24;
						if (flag26)
						{
							goto IL_1db0;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag27 = (nint)0 != 1;
				bool flag28 = default;
				result = flag28;
				if (!flag27)
				{
					flag4 = flag28;
					goto IL_1db0;
				}
			}
			goto IL_1dd3;
			IL_1d1c:
			OnlineSettings instance = OnlineSettings.instance;
			int value2 = instance.GetValue((string)key, defaultValue);
			long num3;
			if (num2 < manager2._lastTournamentUpdate)
			{
				manager2._lastTournamentUpdate = 0L;
				num3 = 0L;
			}
			else
			{
				num3 = manager2._lastTournamentUpdate;
			}
			object obj49 = num2 - num3;
			bool flag29 = value2 < (nint)obj49;
			flag12 = flag29;
			goto IL_1cf8;
			IL_0634:
			_ = 0;
			object obj50 = manager + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_1db0;
			}
			result = flag4;
			goto IL_1dd3;
			IL_1891:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_18a0;
			IL_1e0a:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
								object obj51 = default;
								bool flag30 = obj51 == null;
								object obj52 = 0;
								if (!flag30)
								{
									bool flag31 = obj51 == typeof(string);
									obj52 = obj51;
									if (!flag31)
									{
										obj52 = 0;
									}
								}
								_ = 0;
								object obj54 = default;
								object obj53 = obj54 >> 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F1");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									ITournament tournament3 = default;
									manager2.tournament__BackingField = tournament3;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16B9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												IDictionary playerIdData2 = default;
												manager._playerIdData = playerIdData2;
												_ = 0;
												object obj55 = manager + 16;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16B9");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															long lastTournamentUpdate2 = default;
															manager._lastTournamentUpdate = lastTournamentUpdate2;
															_ = 0;
															object obj56 = manager + 56;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16B9");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		long lastFriendsUpdate = default;
																		manager._lastFriendsUpdate = lastFriendsUpdate;
																		_ = 0;
																		object obj57 = manager + 48;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				_ = 0;
																				_ = tournament.sequenceId__BackingField;
																				object obj58 = manager + 44;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						if (~(tournament.hasResult__BackingField ? 1u : 0u) != 0)
																						{
																							goto IL_116e;
																						}
																						_ = 0;
																						manager._playerIdData = (IDictionary)1;
																						object obj59 = manager + 16;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																						_ = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																						if ((nint)0 != 1)
																						{
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																							_ = 0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																							if ((nint)0 != 1)
																							{
																								_ = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
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
																										int num4 = default;
																										if (num4 < 1)
																										{
																											goto IL_116e;
																										}
																										int rankForScore = tournament.GetRankForScore(num4);
																										_ = 0;
																										manager._playerIdData = (IDictionary)rankForScore;
																										object obj60 = manager + 16;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
																										_ = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																										if ((nint)0 != 1)
																										{
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
																											_ = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																											if ((nint)0 != 1)
																											{
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																												_ = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																												if ((nint)0 != 1)
																												{
																													goto IL_116e;
																												}
																											}
																										}
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																									}
																									else
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																									}
																									goto IL_18a0;
																								}
																							}
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																						goto IL_18a0;
																					}
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																				goto IL_18a0;
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	}
																	goto IL_18a0;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														goto IL_18a0;
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
									goto IL_18a0;
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
					goto IL_18a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_18a0;
			IL_1cf8:
			Dictionary<string, Player>.KeyCollection keys = manager2._currentTournamentPlayers.Keys;
			List<string> list = default;
			list._002Ector((IEnumerable<string>)keys);
			if (!flag12)
			{
				if (manager2._lastTournamentUpdateParticipantsPublicKeys == null)
				{
					goto IL_05f1;
				}
				object obj61 = manager + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				_ = manager._rankData;
				_ = manager._playerIdData;
				long lastTournamentUpdate3 = manager + 128;
				manager._lastTournamentUpdate = lastTournamentUpdate3;
				manager._playerIdData = null;
				manager._playerIdDataIsDirty = (byte)manager._lastTournamentUpdate != 0;
				object obj63 = default;
				object obj64 = default;
				object obj65 = default;
				object obj66 = default;
				bool flag33 = default;
				object playerIdData3 = default;
				bool flag34 = default;
				while (true)
				{
					_ = 0;
					object obj62 = manager + 128;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj63 == null)
						{
							goto IL_05d4;
						}
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj64 == null)
								{
									break;
								}
								continue;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag32 = obj65 != obj66;
					flag4 = flag33;
					if (!flag32)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						manager._playerIdData = (IDictionary)playerIdData3;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_05d4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						flag4 = flag34;
					}
					goto IL_0634;
					IL_05d4:
					object obj67 = manager + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
					goto IL_05f1;
				}
				object obj68 = manager + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
			}
			manager2._lastTournamentUpdateParticipantsPublicKeys = list;
			manager2._lastTournamentUpdate = num2;
			nint num5 = 0;
			nint num6 = 0;
			IntPtr intPtr = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v725 @ S4_v8 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S5_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v741 @ S5_v7+4] (should have been resolved before IL gen)");
			nint num9 = 0;
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ S5_v11 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj70 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v758 @ S5_v12+4] (should have been resolved before IL gen)");
			string uriString = manager.MakeApiURL("/tournaments/gettournamentbyid");
			Uri uri = default;
			uri._002Ector(uriString);
			IRequest request = KilooWebClient.CreatePost(uri);
			object jsonData = default;
			IRequest request2 = RequestExtensions.WithJsonContent(request, jsonData);
			float requestTimeout = manager.requestTimeout;
			IRequest request3 = RequestExtensions.WithTimeout(request2, requestTimeout);
			float requestMinBackOffTime = manager.requestMinBackOffTime;
			IRequest request4 = RequestExtensions.WithMinBackOffTime(request3, requestMinBackOffTime);
			float requestMaxBackOffTime = manager.requestMaxBackOffTime;
			IRequest request5 = RequestExtensions.WithMaxBackOffTime(request4, requestMaxBackOffTime);
			_003Crequest_003E5__2 = request5;
			object obj71 = manager + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Manager manager4 = manager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (TopRun.Internal.Manager)+78]");
			manager4._managerData = (IDictionary)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (TopRun.Internal.Manager)+70]");
			manager = (Manager)0;
			Coroutine coroutine = RequestExtensions.SendAsync(_003Crequest_003E5__2, null, (WebClient.SendOptions)manager);
			_003C_003E2__current = coroutine;
			_003C_003E1__state = 1;
			obj27 = 1;
			goto IL_1cca;
			IL_1c18:
			Action<bool> action2 = onComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v437 @ S0_v203 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
			_003Crequest_003E5__2 = null;
			obj27 = 0;
			goto IL_1cca;
			IL_18a0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj72 = default;
			obj8 = obj72;
			bool flag35 = default;
			result = flag35;
			goto IL_192b;
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

	private sealed class _003CRequestNextTournamentFetchTime_003Ed__130(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private IRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_07f6: Expected I8, but got I4
			//IL_0804: Expected I8, but got I4
			//IL_081b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0820: Expected Obj, but got Unknown
			//IL_0307: Expected I, but got Obj
			//IL_0740: Expected Obj, but got I8
			//IL_0749: Unknown result type (might be due to invalid IL or missing references)
			//IL_074e: Expected Obj, but got Unknown
			//IL_0662: Unknown result type (might be due to invalid IL or missing references)
			//IL_0667: Expected Ref, but got Unknown
			//IL_06a9: Expected VT, but got I4
			//IL_06bf: Expected I4, but got VT
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Expected Obj, but got Unknown
			//IL_06de: Expected Obj, but got I8
			//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ec: Expected Obj, but got Unknown
			//IL_0276: Expected Obj, but got I8
			//IL_0288: Expected Obj, but got I8
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected VT, but got Unknown
			//IL_0536: Expected Obj, but got I
			//IL_0561: Expected Obj, but got I
			//IL_0586: Expected Obj, but got I
			object obj = default;
			Manager manager = (Manager)(obj + -64);
			manager._lastTournamentUpdate = 0L;
			manager._lastFriendsUpdate = 0L;
			manager._fetchingNewTournament = false;
			object obj2 = manager + 32;
			_ = 0;
			Manager manager2 = _003C_003E4__this;
			TimeSpan clientTimeOffset;
			object obj4;
			Manager manager3;
			bool flag = default;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					IResponse response = default;
					if (response != null)
					{
						nint num = (nint)response;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ S1_v134 (Il2CppClass<Kiloo.Common.HTTP.IResponse>)+D4] (should have been resolved before IL gen)");
						bool flag2 = default;
						flag = flag2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj3 = default;
					if (obj3 != null && response != null && ResponseExtensions.IsJSON(response))
					{
						clientTimeOffset = GetClientTimeOffset(_003Crequest_003E5__2);
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag3 = (nint)0 != 1;
							object obj5 = default;
							obj4 = obj5;
							manager3 = manager2;
							if (flag3)
							{
								goto IL_08d3;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
						object obj6 = default;
						object obj7 = default;
						bool flag4 = obj6 == obj7;
						bool flag5 = !flag4;
						object obj8 = default;
						obj4 = obj8;
						manager3 = manager2;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag6 = (nint)0 == 1;
							Manager manager4 = default;
							manager3 = manager4;
							if (!flag6)
							{
								object obj10 = default;
								object obj9 = obj10;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag7 = (nint)0 == 1;
								Manager manager5 = default;
								manager3 = manager5;
								if (!flag7)
								{
									if (manager5 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
										object obj11 = (nint)0 << 2;
										object obj12 = obj2 + obj11;
										obj12 = obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
										object obj13 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
										object obj14 = -1;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
										object obj15 = obj10;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag8 = (nint)0 != 1;
										manager3 = manager5;
										if (!flag8)
										{
											goto IL_05ed;
										}
									}
									goto IL_08b2;
								}
							}
							goto IL_05ed;
						}
						goto IL_0649;
					}
					goto IL_08b2;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj16 = default;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
					object obj17 = default;
					if (obj17 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						string text = default;
						bool flag9 = text == null;
						string text2 = null;
						if (!flag9)
						{
							bool flag10 = (object)text.GetType() == typeof(string);
							text2 = text;
							if (!flag10)
							{
								text2 = null;
							}
						}
						string country = manager2.country;
						if (country != text2)
						{
							int num2 = JsonObject.Get(obj17, "submittedScore", 0);
							if (num2 >= 1)
							{
								string text3 = JsonObject.Get<string>(manager2._managerData, "localPlayerPrivateKey", null, null);
								if (text3 != null)
								{
									string arg = manager.MakeApiURL("/players/getcountrychangedate");
									string arg2 = Uri.EscapeDataString(text3);
									string country2 = manager2.country;
									string uriString = $"{arg}?PrivateKey={arg2}&ToCountry={country2}";
									Uri uri = default;
									uri._002Ector(uriString);
									IRequest request = KilooWebClient.CreateGet(uri);
									float requestTimeout = manager.requestTimeout;
									IRequest request2 = RequestExtensions.WithTimeout(request, requestTimeout);
									float requestMinBackOffTime = manager.requestMinBackOffTime;
									IRequest request3 = RequestExtensions.WithMinBackOffTime(request2, requestMinBackOffTime);
									float requestMaxBackOffTime = manager.requestMaxBackOffTime;
									IRequest request4 = RequestExtensions.WithMaxBackOffTime(request3, requestMaxBackOffTime);
									_003Crequest_003E5__2 = request4;
									object obj18 = manager + 48;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
									manager._playerIdData = (IDictionary)manager._lastTournamentUpdate;
									manager._managerData = (IDictionary)manager._lastFriendsUpdate;
									WebClient.SendOptions options = (WebClient.SendOptions)(manager + 8);
									Coroutine coroutine = RequestExtensions.SendAsync(_003Crequest_003E5__2, null, options);
									_003C_003E2__current = coroutine;
									_003C_003E1__state = 1;
									return true;
								}
							}
							else
							{
								DateTime utcNow = CDateTime.UtcNow;
								long num3 = TimeUtility.ToUnixTime(utcNow);
								manager._rankData = (IDictionary)num3;
								object obj19 = manager + 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
								manager2._managerDataIsDirty = true;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
							manager2._managerDataIsDirty = true;
						}
					}
				}
			}
			return flag;
			IL_07d3:
			_003Crequest_003E5__2 = null;
			return false;
			IL_05ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag11 = (nint)0 == 1;
			object obj20 = default;
			obj4 = obj20;
			if (!flag11)
			{
				goto IL_0649;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			goto IL_08b2;
			IL_0649:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_08d3;
			IL_08d3:
			if (obj4 != null && JsonObject.TryGet<DateTime>(obj4, "ChangeDateUtc", out *(DateTime*)(manager + 40)))
			{
				DateTime dateTime = (DateTime)manager._fetchingNewTournament + clientTimeOffset;
				manager._fetchingNewTournament = (byte)(int)dateTime != 0;
				long num4 = TimeUtility.ToUnixTime(dateTime);
				manager._rankData = (IDictionary)num4;
				object obj21 = manager + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
				manager3._managerDataIsDirty = true;
				goto IL_07d3;
			}
			goto IL_08b2;
			IL_08b2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text4 = default;
			string msg = "GetNextTournamentFetchTime: Request failed or bad response, status: " + text4;
			LogError(msg);
			goto IL_07d3;
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

	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public Manager _003C_003E4__this;

		public string currentTournamentId;

		public IList<string> keysToGetRanksFor;

		internal void _003CRequestRanksForPlayers_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ddc: Expected Obj, but got Unknown
			//IL_001b: Expected I, but got Obj
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bf: Expected Obj, but got Unknown
			//IL_01fe: Expected Obj, but got I
			//IL_0229: Expected Obj, but got I
			//IL_024e: Expected Obj, but got I
			//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca1: Expected Obj, but got Unknown
			//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d27: Expected Obj, but got Unknown
			//IL_0d06: Expected Obj, but got I
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Expected Obj, but got Unknown
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a3: Expected Obj, but got Unknown
			//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f6d: Expected Obj, but got Unknown
			//IL_0ae7: Expected Obj, but got I4
			//IL_0af0: Expected Obj, but got I4
			//IL_0f11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f16: Expected Obj, but got Unknown
			//IL_0ad0: Expected Obj, but got I4
			//IL_0ad9: Expected Obj, but got I4
			//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c07: Expected Obj, but got Unknown
			//IL_0691: Expected Obj, but got I4
			//IL_06d2: Expected Obj, but got I4
			//IL_073f: Expected Obj, but got I4
			//IL_0720: Expected Obj, but got I4
			//IL_0921: Expected Obj, but got I4
			//IL_092a: Expected Obj, but got I4
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_081c: Expected Obj, but got Unknown
			//IL_0895: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + -64;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj + 40;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			IResponse response = default;
			if (response != null)
			{
				nint num = (nint)response;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S1_v251 (Il2CppClass<Kiloo.Common.HTTP.IResponse>)+D4] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = default;
			if (obj4 == null || response == null || !ResponseExtensions.IsJSON(response))
			{
				goto IL_0e30;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			IRequest request2;
			object obj15;
			IRequest request6 = default;
			object obj32;
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj5 = default;
					if (obj5 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
						object obj6 = default;
						if (obj6 != null)
						{
							Manager manager = _003C_003E4__this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							object obj7 = obj + 60;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
							_ = 0;
							object obj8 = default;
							object obj11 = default;
							object obj12 = default;
							object obj13 = default;
							object obj14 = default;
							IRequest request3 = default;
							object obj16 = default;
							object obj21 = default;
							IRequest request4 = default;
							object obj22 = default;
							object obj23 = default;
							IRequest request5 = default;
							object obj24 = default;
							object obj26 = default;
							object obj28 = default;
							object obj29 = default;
							object obj30 = default;
							while (true)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj8 == null)
									{
										goto IL_0c93;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj9 = obj + 52;
											object obj10 = obj + 56;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
											_ = 0;
											while (true)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												if (obj11 != null)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														break;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														break;
													}
													if (obj12 != null)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 == 1)
														{
															break;
														}
														if (obj13 != null)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 == 1)
															{
																break;
															}
															if (obj14 == null)
															{
																continue;
															}
															goto IL_063e;
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 == 1)
														{
															break;
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 == 1)
														{
															break;
														}
														continue;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														break;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														break;
													}
													continue;
												}
												goto IL_0ade;
											}
											goto IL_0a26;
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
								goto IL_0c25;
								IL_0c25:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								request2 = request3;
								obj15 = obj16;
								goto IL_0fee;
								IL_08a2:
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								object obj17;
								object obj18;
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										obj17 = 14;
										obj18 = 0;
										goto IL_0f02;
									}
								}
								goto IL_0a26;
								IL_0ade:
								obj17 = 14;
								obj18 = 0;
								goto IL_0f02;
								IL_0ed7:
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								object obj19;
								if ((nint)0 != 1)
								{
									if (obj19 != null)
									{
										goto IL_08a2;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												object obj20 = obj + 8;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														obj17 = 14;
														obj18 = obj21;
														goto IL_0f02;
													}
												}
											}
										}
									}
								}
								goto IL_0a26;
								IL_0a26:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								bool flag = request4 != obj22;
								request2 = request4;
								obj15 = obj23;
								if (!flag)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										obj17 = 0;
										obj18 = 0;
										goto IL_0f02;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									request2 = request5;
									obj15 = obj24;
								}
								_ = 0;
								object obj25 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									break;
								}
								goto IL_0fee;
								IL_063e:
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									bool flag2 = obj26 == null;
									object obj27 = 0;
									if (!flag2)
									{
										bool flag3 = obj26 == typeof(string);
										obj27 = obj26;
										if (!flag3)
										{
											obj27 = 0;
										}
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										if ((nint)obj28 < 0)
										{
											goto IL_08a2;
										}
										_ = 0;
										if (obj27 != null)
										{
											obj19 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v975 @ S0_v357+8]");
											if ((nint)0 != 0)
											{
												goto IL_0ed7;
											}
										}
										obj19 = 1;
										goto IL_0ed7;
									}
								}
								goto IL_0a26;
								IL_0fee:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								if (obj29 == request2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										goto IL_0c93;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									request2 = (IRequest)0;
									obj15 = obj30;
								}
								_ = 0;
								object obj31 = obj + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag4 = (nint)0 != 1;
								request6 = request2;
								obj32 = obj15;
								if (!flag4)
								{
									break;
								}
								goto IL_0e51;
								IL_0f02:
								_ = 0;
								object obj33 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									bool flag5 = (nint)obj17 != 14;
									if (obj17 == null)
									{
										flag5 = false;
									}
									if (flag5)
									{
										object obj34 = obj + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
										return;
									}
									Manager manager2 = _003C_003E4__this;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								goto IL_0c25;
								IL_0c93:
								object obj35 = obj + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
								Manager manager3 = _003C_003E4__this;
								SaveJsonFile("toprun_ranks", manager3._rankData);
								_003C_003E4__this.InitializeRanksFromSaveData();
								return;
							}
							goto IL_0d6f;
						}
					}
					goto IL_0e30;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj36 = default;
			object obj37 = default;
			bool flag6 = obj36 != obj37;
			object obj38 = default;
			obj32 = obj38;
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj40 = default;
					object obj39 = obj40;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj41 = default;
						if (obj41 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
							object obj42 = (nint)0 << 2;
							object obj43 = obj3 + obj42;
							obj43 = obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
							object obj44 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
							object obj45 = -1;
							goto IL_0e30;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						IRequest request7 = (IRequest)obj40;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag7 = (nint)0 != 1;
						request6 = request7;
						request2 = request7;
						obj15 = obj41;
						if (flag7)
						{
							goto IL_0d97;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag8 = (nint)0 == 1;
				request2 = request6;
				object obj46 = default;
				obj15 = obj46;
				if (flag8)
				{
					goto IL_0d6f;
				}
				obj32 = obj46;
			}
			goto IL_0e51;
			IL_0d6f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			goto IL_0d97;
			IL_0d97:
			request6 = request2;
			obj32 = obj15;
			goto IL_0e51;
			IL_0e30:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text = default;
			string msg = "GetRanksForPlayers: Request failed or bad response, status: " + text;
			LogError(msg);
			return;
			IL_0e51:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_0e30;
		}
	}

	private sealed class _003CRequestRanksForPlayers_003Ed__132(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00ba: Expected Obj, but got I4
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected Obj, but got Unknown
			//IL_014e: Expected Obj, but got I
			//IL_00fb: Expected Obj, but got I4
			//IL_0240: Expected Obj, but got I
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Expected Obj, but got Unknown
			//IL_0364: Expected VT, but got Obj
			object obj = default;
			Manager manager = (Manager)(obj - 32);
			manager._rankData = null;
			manager._playerIdData = null;
			int num;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				if (flag)
				{
					goto IL_03bc;
				}
				goto IL_03cb;
			}
			Manager manager2 = _003C_003E4__this;
			_003C_003E1__state = -1;
			_ = _003C_003E4__this;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj3 = default;
				bool flag2 = obj3 == null;
				object obj4 = 0;
				if (!flag2)
				{
					bool flag3 = obj3 == typeof(string);
					obj4 = obj3;
					if (!flag3)
					{
						obj4 = 0;
					}
				}
				if (obj3 != null)
				{
					goto IL_0419;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			string text = default;
			bool flag4 = text == null;
			string text2 = null;
			if (!flag4)
			{
				bool flag5 = (object)text.GetType() == typeof(string);
				text2 = text;
				if (!flag5)
				{
					text2 = null;
				}
			}
			goto IL_0419;
			IL_01bf:
			IList<string> publicKeysForPlayersWeHaveNotRequestedRanksFor = manager2.GetPublicKeysForPlayersWeHaveNotRequestedRanksFor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj5 = default;
			bool flag6 = (nint)obj5 < 1;
			bool result = false;
			if (!flag6)
			{
				nint num2 = 0;
				nint num3 = 0;
				IntPtr intPtr = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ S4_v8 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
				nint num4 = 0;
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ S5_v6+4] (should have been resolved before IL gen)");
				string uriString = manager.MakeApiURL("/tournaments/getprevioustournamentresultsforplayers");
				Uri uri = default;
				uri._002Ector(uriString);
				IRequest request = KilooWebClient.CreatePost(uri);
				object jsonData = default;
				IRequest request2 = RequestExtensions.WithJsonContent(request, jsonData);
				float requestTimeout = manager.requestTimeout;
				IRequest request3 = RequestExtensions.WithTimeout(request2, requestTimeout);
				float requestMinBackOffTime = manager.requestMinBackOffTime;
				IRequest request4 = RequestExtensions.WithMinBackOffTime(request3, requestMinBackOffTime);
				float requestMaxBackOffTime = manager.requestMaxBackOffTime;
				IRequest request5 = RequestExtensions.WithMaxBackOffTime(request4, requestMaxBackOffTime);
				WebClient.RequestCompleteHandler requestCompleteHandler = default;
				object obj7 = default;
				requestCompleteHandler._002Ector(obj7, (nint)__ldftn(_003C_003Ec__DisplayClass132_0._003CRequestRanksForPlayers_003Eb__0));
				object obj8 = manager + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				manager._managerData = manager._rankData;
				manager = (Manager)manager._playerIdData;
				Coroutine coroutine = RequestExtensions.ThenMakeTheRequestAsync(request5, requestCompleteHandler, (WebClient.SendOptions)manager);
				_003C_003E2__current = coroutine;
				result = true;
				num = 1;
				goto IL_03bc;
			}
			goto IL_03cb;
			IL_03cb:
			return result;
			IL_03bc:
			_003C_003E1__state = num;
			goto IL_03cb;
			IL_0419:
			if (text2 != null)
			{
				string text3 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v23 (System.Object)+C]");
				if (!(text3 != (string)0))
				{
					goto IL_01bf;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj10 = default;
			object obj9 = obj10 + 1;
			nint num6 = 0;
			nint num7 = 0;
			IntPtr intPtr2 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ S4_v19 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			goto IL_01bf;
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

	private sealed class _003CRequestSubmitScoreCoroutine_003Ed__133(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		public int multiplier;

		public int scoreToSubmit;

		public bool previouslySavedScore;

		public bool isRetry;

		private IDictionary _003Ctour_003E5__2;

		private bool _003CscoreWasUpdated_003E5__3;

		private int _003CunsubmittedScore_003E5__4;

		private string _003CtournamentId_003E5__5;

		private string _003CtournamentCountry_003E5__6;

		private long _003CtournamentStart_003E5__7;

		private long _003CtournamentEnd_003E5__8;

		private IRequest _003Crequest_003E5__9;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dce: Expected Obj, but got Unknown
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Expected Obj, but got Unknown
			//IL_0371: Expected Obj, but got I4
			//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b8: Expected Obj, but got Unknown
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected Obj, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected Obj, but got Unknown
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected Obj, but got Unknown
			//IL_03b2: Expected Obj, but got I4
			//IL_0775: Expected I, but got Obj
			//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0b: Expected Obj, but got Unknown
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d6: Expected Obj, but got Unknown
			//IL_0501: Expected Obj, but got I
			//IL_051b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0520: Expected Obj, but got Unknown
			//IL_0546: Expected Obj, but got I
			//IL_056c: Expected Obj, but got I
			//IL_0592: Expected Obj, but got I
			//IL_05c7: Expected Obj, but got I
			//IL_062d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0632: Expected Obj, but got Unknown
			//IL_0651: Expected Obj, but got I
			//IL_064c: Expected native int or pointer, but got VT
			//IL_0661: Expected native int or pointer, but got VT
			//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b86: Expected Obj, but got Unknown
			//IL_0a85: Expected Obj, but got I
			//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae9: Expected Obj, but got Unknown
			//IL_0da9: Expected Obj, but got I
			//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b26: Expected Obj, but got Unknown
			//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b54: Expected Obj, but got Unknown
			//IL_0a19: Expected Obj, but got I
			//IL_0968: Expected Obj, but got I
			//IL_0993: Expected Obj, but got I
			//IL_09b8: Expected Obj, but got I
			object obj = default;
			WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + -64);
			_ = 0;
			_ = 0;
			object obj2 = sendOptions + 40;
			_ = 0;
			Manager manager = _003C_003E4__this;
			bool result = default;
			object obj15;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (!manager._isRefreshingTournament)
					{
						goto IL_02e6;
					}
					goto IL_0e4f;
				}
				if (_003C_003E1__state == 2)
				{
					_003C_003E1__state = -1;
					manager.Save();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					object obj3 = default;
					bool flag = obj3 == null;
					object obj4 = 0;
					if (!flag)
					{
						bool flag2 = obj3 == typeof(string);
						obj4 = obj3;
						if (!flag2)
						{
							obj4 = 0;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					string text = default;
					bool flag3 = text == null;
					string text2 = null;
					if (!flag3)
					{
						bool flag4 = (object)text.GetType() == typeof(string);
						text2 = text;
						if (!flag4)
						{
							text2 = null;
						}
					}
					_003CtournamentId_003E5__5 = text2;
					string text3 = default;
					string text4 = default;
					if (text == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						bool flag5 = text3 == null;
						text4 = null;
						if (!flag5)
						{
							bool flag6 = (object)text3.GetType() == typeof(string);
							text4 = text3;
							if (!flag6)
							{
								text4 = null;
							}
						}
					}
					_003CtournamentCountry_003E5__6 = text4;
					if (text3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
						long num = default;
						_003CtournamentStart_003E5__7 = num;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
						long num2 = default;
						_003CtournamentEnd_003E5__8 = num2;
						if (obj4 != null && _003CtournamentId_003E5__5 != null && _003CtournamentCountry_003E5__6 != null && _003CtournamentStart_003E5__7 != 0 && num2 != 0)
						{
							nint num3 = 0;
							nint num4 = 0;
							IntPtr intPtr = num4;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v735 @ S4_v23 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
							_ = _003CunsubmittedScore_003E5__4;
							object obj5 = sendOptions + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							nint num5 = 0;
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v782 @ S5_v9+4] (should have been resolved before IL gen)");
							_ = multiplier;
							object obj7 = sendOptions + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							nint num7 = 0;
							nint num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v825 @ S5_v14+4] (should have been resolved before IL gen)");
							nint num9 = 0;
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v842 @ S5_v19+4] (should have been resolved before IL gen)");
							nint num11 = 0;
							nint num12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v860 @ S5_v24+4] (should have been resolved before IL gen)");
							string nameFromSocialManager = GetNameFromSocialManager();
							nint num13 = 0;
							nint num14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v904 @ S5_v29+4] (should have been resolved before IL gen)");
							string uriString = MakeApiURL("/scores/submitscore");
							Uri uri = default;
							uri._002Ector(uriString);
							IRequest request = KilooWebClient.CreatePost(uri);
							object jsonData = default;
							IRequest request2 = RequestExtensions.WithJsonContent(request, jsonData);
							_003Crequest_003E5__9 = request2;
							object obj12 = sendOptions + 48;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.WebClient+SendOptions)+38]");
							System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Common.HTTP.WebClient+SendOptions)+30]");
							((WebClient.SendOptions*)(nint)sendOptions)->disableCache = false;
							Coroutine coroutine = RequestExtensions.SendAsync(_003Crequest_003E5__9, null, sendOptions);
							_003C_003E2__current = coroutine;
							_003C_003E1__state = 3;
							result = true;
							goto IL_0dfd;
						}
					}
					goto IL_0edf;
				}
				if (_003C_003E1__state == 3)
				{
					_003C_003E1__state = -1;
					object obj13 = this + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F4A");
					if (_003Ctour_003E5__2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						string text5 = default;
						bool flag7 = text5 == null;
						string text6 = null;
						if (!flag7)
						{
							bool flag8 = (object)text5.GetType() == typeof(string);
							text6 = text5;
							if (!flag8)
							{
								text6 = null;
							}
						}
						if (_003CtournamentId_003E5__5 == text6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							IResponse response = default;
							if (response != null)
							{
								nint num15 = (nint)response;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v527 @ S1_v264 (Il2CppClass<Kiloo.Common.HTTP.IResponse>)+D4] (should have been resolved before IL gen)");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
							object obj14 = default;
							if (obj14 != null && response != null && ResponseExtensions.IsJSON(response))
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag9 = (nint)0 != 1;
									object obj16 = default;
									obj15 = obj16;
									if (flag9)
									{
										goto IL_0f62;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
								object obj17 = default;
								object obj18 = default;
								bool flag10 = obj17 == obj18;
								bool flag11 = !flag10;
								object obj19 = default;
								obj15 = obj19;
								if (!flag11)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									_003CRequestSubmitScoreCoroutine_003Ed__133 obj28;
									if ((nint)0 != 1)
									{
										object obj21 = default;
										object obj20 = obj21;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj22 = default;
											if (obj22 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
												object obj23 = (nint)0 << 2;
												object obj24 = obj2 + obj23;
												obj24 = obj21;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
												object obj25 = (nint)0 + (nint)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
												object obj26 = -1;
												goto IL_0f7f;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
											object obj27 = obj21;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag12 = (nint)0 != 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											obj28 = (_003CRequestSubmitScoreCoroutine_003Ed__133)0;
											if (flag12)
											{
												goto IL_0e4f;
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag13 = (nint)0 == 1;
									object obj29 = default;
									obj15 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									obj28 = (_003CRequestSubmitScoreCoroutine_003Ed__133)0;
									if (flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										obj28 = (_003CRequestSubmitScoreCoroutine_003Ed__133)0;
										goto IL_0e4f;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
								goto IL_0f62;
							}
							if (response != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
								object obj30 = default;
								if ((nint)obj30 == 400)
								{
									string text7 = default;
									if (text7.Contains("Invalid PrivateKey"))
									{
										LogError("SubmitScore: Invalid User Info, discarding and retrying (once)");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
										manager._managerDataIsDirty = true;
										if (!isRetry)
										{
											manager._isRefreshingTournament = false;
											IEnumerator coroutine2 = manager.RequestSubmitScoreCoroutine(multiplier, scoreToSubmit, isRetry: true, previouslySavedScore: true);
											Coroutine coroutine3 = CoroutineUtil.StartCoroutine(coroutine2);
											result = false;
											goto IL_0dfd;
										}
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
									object obj31 = default;
									if ((nint)obj31 == 404)
									{
										_ = 1;
										object obj32 = sendOptions + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
										manager._managerDataIsDirty = true;
									}
								}
							}
							goto IL_0f7f;
						}
					}
					_003CscoreWasUpdated_003E5__3 = false;
					goto IL_0fa0;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				manager.multiplier__BackingField = multiplier;
				if (scoreToSubmit > manager.highScore__BackingField)
				{
					manager.highScore__BackingField = scoreToSubmit;
				}
				if (!manager.canSubmitScore)
				{
					if (!previouslySavedScore)
					{
						int num16 = JsonObject.Get(manager._managerData, "unsubmittedScoreNoTournament", 0);
						if (num16 < scoreToSubmit)
						{
							_ = scoreToSubmit;
							object obj33 = sendOptions + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
							DateTime utcNow = CDateTime.UtcNow;
							long num17 = TimeUtility.ToUnixTime(utcNow);
							object obj34 = sendOptions + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
							manager._managerDataIsDirty = true;
							manager.Save();
						}
					}
				}
				else
				{
					object obj35 = this + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F4A");
					int num18 = JsonObject.Get(_003Ctour_003E5__2, "submittedScore", 0);
					if (num18 < scoreToSubmit)
					{
						_003CscoreWasUpdated_003E5__3 = false;
						if ((_003CunsubmittedScore_003E5__4 = JsonObject.Get(_003Ctour_003E5__2, "unsubmittedScore", 0)) < scoreToSubmit)
						{
							_003CunsubmittedScore_003E5__4 = scoreToSubmit;
							_ = scoreToSubmit;
							object obj36 = sendOptions + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
							manager._managerDataIsDirty = true;
							manager.Save();
							_003CscoreWasUpdated_003E5__3 = true;
						}
						if (~(manager._isRefreshingTournament ? 1u : 0u) != 0)
						{
							goto IL_02e6;
						}
						goto IL_0e4f;
					}
				}
			}
			goto IL_0dfd;
			IL_0f7f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text8 = default;
			string msg = "SubmitScore: Request failed or bad response, status: " + text8;
			LogError(msg);
			goto IL_0fa0;
			IL_0f62:
			if (obj15 == null)
			{
				goto IL_0f7f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F4C");
			object obj37 = default;
			if (obj37 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
				_ = _003CunsubmittedScore_003E5__4;
				object obj38 = sendOptions + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
				_ = _003CtournamentStart_003E5__7;
				object obj39 = sendOptions + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
				_ = _003CtournamentEnd_003E5__8;
				object obj40 = sendOptions + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			}
			else
			{
				_ = 1;
				object obj41 = sendOptions + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			}
			manager._managerDataIsDirty = true;
			goto IL_0fa0;
			IL_0e4f:
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			result = true;
			goto IL_0dfd;
			IL_0fa0:
			_003Crequest_003E5__9 = null;
			goto IL_0edf;
			IL_0edf:
			manager._isRefreshingTournament = false;
			bool flag14 = (byte)(~(_003CscoreWasUpdated_003E5__3 ? 1u : 0u)) != 0;
			result = false;
			if (!flag14)
			{
				manager.FireTournamentChangedEvent(wasUpdated: true, didChange: false);
				result = false;
			}
			goto IL_0dfd;
			IL_0dfd:
			return result;
			IL_02e6:
			manager._isRefreshingTournament = true;
			IEnumerator coroutine4 = manager.RefreshKeysIfNecessary();
			Coroutine coroutine5 = CoroutineUtil.StartCoroutine(coroutine4);
			_003C_003E2__current = coroutine5;
			_003C_003E1__state = 2;
			result = true;
			goto IL_0dfd;
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

	private sealed class _003CRefreshKeysIfNecessary_003Ed__136(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00dd: Expected Obj, but got I4
			//IL_011e: Expected Obj, but got I4
			int num;
			bool result;
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				num = -1;
				result = false;
				if (!flag)
				{
					bool flag2 = _003C_003E1__state == 2;
					num = -1;
					result = false;
					if (!flag2)
					{
						bool flag3 = _003C_003E1__state == 3;
						num = -1;
						result = false;
						if (!flag3)
						{
							result = false;
							goto IL_02c7;
						}
					}
				}
			}
			else
			{
				Manager manager = _003C_003E4__this;
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj = default;
				bool flag4 = obj == null;
				object obj2 = 0;
				if (!flag4)
				{
					bool flag5 = obj == typeof(string);
					obj2 = obj;
					if (!flag5)
					{
						obj2 = 0;
					}
				}
				int num2;
				if (obj2 != null)
				{
					string facebookIdFromSocialManager = GetFacebookIdFromSocialManager();
					bool flag6 = facebookIdFromSocialManager == null;
					result = false;
					if (flag6)
					{
						goto IL_02c7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					string text = default;
					bool flag7 = text == null;
					string text2 = null;
					if (!flag7)
					{
						bool flag8 = (object)text.GetType() == typeof(string);
						text2 = text;
						if (!flag8)
						{
							text2 = null;
						}
					}
					if (text2 != null)
					{
						bool flag9 = facebookIdFromSocialManager != text2;
						bool flag10 = !flag9;
						result = false;
						if (flag10)
						{
							goto IL_02c7;
						}
						manager.ClearKeys();
						IEnumerator coroutine = manager.LoginOrCreatePlayer();
						Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
						_003C_003E2__current = coroutine2;
						num2 = 1;
					}
					else
					{
						IEnumerator coroutine3 = manager.LoginOrRegisterFacebook();
						Coroutine coroutine4 = CoroutineUtil.StartCoroutine(coroutine3);
						_003C_003E2__current = coroutine4;
						num2 = 2;
					}
				}
				else
				{
					IEnumerator coroutine5 = manager.LoginOrCreatePlayer();
					Coroutine coroutine6 = CoroutineUtil.StartCoroutine(coroutine5);
					_003C_003E2__current = coroutine6;
					num2 = 3;
				}
				num = num2;
				result = true;
			}
			_003C_003E1__state = num;
			goto IL_02c7;
			IL_02c7:
			return result;
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

	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public FacebookLoginResult facebookLoginResult;

		internal void _003CLoginOrRegisterFacebook_003Eb__0(FacebookLoginResult result)
		{
			facebookLoginResult = result;
		}
	}

	private sealed class _003CLoginOrRegisterFacebook_003Ed__137(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private _003C_003Ec__DisplayClass137_0 _003C_003E8__1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			bool result;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 2;
					num = -1;
					result = false;
					if (flag)
					{
						goto IL_0173;
					}
					result = false;
				}
				else
				{
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass137_0 obj = _003C_003E8__1;
					bool flag2 = obj.facebookLoginResult != FacebookLoginResult.NotFound;
					result = false;
					if (!flag2)
					{
						IEnumerator coroutine = _003C_003E4__this.RequestFacebookRegister();
						Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
						_003C_003E2__current = coroutine2;
						num = 2;
						result = true;
						goto IL_0173;
					}
				}
				goto IL_0182;
			}
			_003C_003E1__state = -1;
			_003C_003Ec__DisplayClass137_0 obj2 = default;
			_003C_003E8__1 = obj2;
			_003C_003Ec__DisplayClass137_0 obj3 = _003C_003E8__1;
			obj3.facebookLoginResult = FacebookLoginResult.Failed;
			throw new ArgumentException();
			IL_0182:
			return result;
			IL_0173:
			_003C_003E1__state = num;
			goto IL_0182;
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

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public FacebookLoginResult facebookLoginResult;

		internal void _003CLoginOrCreatePlayer_003Eb__0(FacebookLoginResult result)
		{
			facebookLoginResult = result;
		}
	}

	private sealed class _003CLoginOrCreatePlayer_003Ed__138(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private _003C_003Ec__DisplayClass138_0 _003C_003E8__1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			bool result;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 2;
					num = -1;
					result = false;
					if (flag)
					{
						goto IL_016d;
					}
					result = false;
				}
				else
				{
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass138_0 obj = _003C_003E8__1;
					bool flag2 = obj.facebookLoginResult != FacebookLoginResult.NotFound;
					result = false;
					if (!flag2)
					{
						_003C_003E8__1 = null;
						goto IL_0181;
					}
				}
				goto IL_017c;
			}
			_003C_003E1__state = -1;
			string facebookIdFromSocialManager = GetFacebookIdFromSocialManager();
			if (facebookIdFromSocialManager != null)
			{
				_003C_003Ec__DisplayClass138_0 obj2 = default;
				_003C_003E8__1 = obj2;
				_003C_003Ec__DisplayClass138_0 obj3 = _003C_003E8__1;
				obj3.facebookLoginResult = FacebookLoginResult.Failed;
				throw new ArgumentException();
			}
			goto IL_0181;
			IL_016d:
			_003C_003E1__state = num;
			goto IL_017c;
			IL_017c:
			return result;
			IL_0181:
			IEnumerator coroutine = _003C_003E4__this.RequestCreatePlayer();
			Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
			_003C_003E2__current = coroutine2;
			int num2 = 2;
			num = num2;
			result = true;
			goto IL_016d;
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

	private sealed class _003C_003Ec__DisplayClass139_0
	{
		public Manager _003C_003E4__this;

		public string facebookId;

		public Action<FacebookLoginResult> onComplete;

		internal void _003CRequestFacebookLogin_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Expected Obj, but got Unknown
			//IL_001b: Expected I, but got Obj
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_0531: Expected Obj, but got I
			//IL_053a: Expected Obj, but got I4
			//IL_04e4: Expected Obj, but got I4
			//IL_0369: Expected Obj, but got I4
			//IL_060a: Expected Obj, but got I4
			//IL_0304: Expected Obj, but got I
			//IL_03aa: Expected Obj, but got I4
			//IL_03e2: Expected Obj, but got I4
			//IL_021c: Expected Obj, but got I
			//IL_0247: Expected Obj, but got I
			//IL_026c: Expected Obj, but got I
			//IL_0479: Expected Obj, but got I
			//IL_0482: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 8;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			IResponse response = default;
			if (response != null)
			{
				nint num = (nint)response;
				object obj4 = response + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S1_v95 (Il2CppClass<Kiloo.Common.HTTP.IResponse>)+D4] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj5 = default;
			object obj6;
			_003C_003Ec__DisplayClass139_0 obj19 = default;
			if (obj5 != null && response != null && ResponseExtensions.IsJSON(response))
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 != 1;
					object obj7 = default;
					obj6 = obj7;
					if (flag)
					{
						goto IL_05cb;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj8 = default;
				object obj9 = default;
				bool flag2 = obj8 == obj9;
				bool flag3 = !flag2;
				object obj10 = default;
				obj6 = obj10;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj12 = default;
						object obj11 = obj12;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj13 = default;
							if (obj13 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj14 = (nint)0 << 2;
								object obj15 = obj3 + obj14;
								obj15 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj16 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj17 = -1;
								goto IL_04f2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj18 = obj12;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								return;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj19 = (_003C_003Ec__DisplayClass139_0)0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 == 1;
					object obj20 = default;
					obj6 = obj20;
					if (flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						return;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				goto IL_05cb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj21 = default;
			_003C_003Ec__DisplayClass139_0 obj23;
			object obj24;
			if (obj21 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj22 = default;
				bool flag5 = (nint)obj22 == 404;
				obj23 = this;
				obj24 = 2;
				if (flag5)
				{
					goto IL_0635;
				}
			}
			goto IL_04f2;
			IL_0635:
			Action<FacebookLoginResult> action = obj23.onComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v196 @ S0_v18 (System.Action`1<TopRun.Internal.Manager+FacebookLoginResult>)+C] (should have been resolved before IL gen)");
			return;
			IL_05cb:
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj25 = default;
				bool flag6 = obj25 == null;
				object obj26 = 0;
				if (!flag6)
				{
					bool flag7 = obj25 == typeof(string);
					obj26 = obj25;
					if (!flag7)
					{
						obj26 = 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj27 = default;
				bool flag8 = obj27 == null;
				object obj28 = 0;
				if (!flag8)
				{
					bool flag9 = obj27 == typeof(string);
					obj28 = obj27;
					if (!flag9)
					{
						obj28 = 0;
					}
				}
				if (obj26 != null && obj28 != null)
				{
					Manager manager = obj19._003C_003E4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					Manager manager2 = obj19._003C_003E4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					Manager manager3 = obj19._003C_003E4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					Manager manager4 = obj19._003C_003E4__this;
					manager4._managerDataIsDirty = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj23 = (_003C_003Ec__DisplayClass139_0)0;
					obj24 = 0;
					goto IL_0635;
				}
			}
			goto IL_04f2;
			IL_04f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text = default;
			string msg = "FacebookLogin: Request failed or bad response, status: " + text;
			LogError(msg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj23 = (_003C_003Ec__DisplayClass139_0)0;
			obj24 = 1;
			goto IL_0635;
		}
	}

	private sealed class _003CRequestFacebookLogin_003Ed__139(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		public Action<FacebookLoginResult> onComplete;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02ae: Expected Obj, but got I
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected Ref, but got Unknown
			//IL_00c6: Expected Obj, but got I
			//IL_0113: Expected Obj, but got I4
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected Obj, but got Unknown
			//IL_014c: Expected Obj, but got I
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected Obj, but got Unknown
			//IL_026b: Expected VT, but got Obj
			object obj = default;
			Manager manager = (Manager)(obj - 48);
			manager._fetchingNewTournament = false;
			manager._ranks = null;
			manager._rankData = null;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_ = _003C_003E4__this;
				_ = onComplete;
				string facebookIdFromSocialManager = manager.GetFacebookIdFromSocialManager();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (System.Object)+C]");
				if ((nint)0 != 0)
				{
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					ref ulong result = ref *(ulong*)(manager + 40);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (System.Object)+C]");
					if (ulong.TryParse((string)0, NumberStyles.None, invariantCulture, out result))
					{
						nint num = 0;
						nint num2 = 0;
						IntPtr intPtr = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ S4_v8 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
						manager._playerIdData = (IDictionary)manager._fetchingNewTournament;
						object obj2 = manager + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
						nint num3 = 0;
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
						object obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ S5_v5+4] (should have been resolved before IL gen)");
						string uriString = manager.MakeApiURL("/facebook/login");
						Uri uri = default;
						uri._002Ector(uriString);
						IRequest request = KilooWebClient.CreatePost(uri);
						object jsonData = default;
						IRequest request2 = RequestExtensions.WithJsonContent(request, jsonData);
						float requestTimeout = manager.requestTimeout;
						IRequest request3 = RequestExtensions.WithTimeout(request2, requestTimeout);
						float requestMinBackOffTime = manager.requestMinBackOffTime;
						IRequest request4 = RequestExtensions.WithMinBackOffTime(request3, requestMinBackOffTime);
						float requestMaxBackOffTime = manager.requestMaxBackOffTime;
						IRequest request5 = RequestExtensions.WithMaxBackOffTime(request4, requestMaxBackOffTime);
						WebClient.RequestCompleteHandler requestCompleteHandler = default;
						object obj4 = default;
						requestCompleteHandler._002Ector(obj4, (nint)__ldftn(_003C_003Ec__DisplayClass139_0._003CRequestFacebookLogin_003Eb__0));
						object obj5 = manager + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
						manager._managerData = manager._ranks;
						manager = (Manager)manager._rankData;
						Coroutine coroutine = RequestExtensions.ThenMakeTheRequestAsync(request5, requestCompleteHandler, (WebClient.SendOptions)manager);
						_003C_003E2__current = coroutine;
						_003C_003E1__state = 1;
						goto IL_02fe;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (System.Object)+10]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ S0_v27+C] (should have been resolved before IL gen)");
			}
			goto IL_02fe;
			IL_02fe:
			return true;
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

	private sealed class _003C_003Ec__DisplayClass140_0
	{
		public Manager _003C_003E4__this;

		public string facebookId;

		internal void _003CRequestCreatePlayer_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f5: Expected Obj, but got Unknown
			//IL_001b: Expected I, but got Obj
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_03a1: Expected Obj, but got I4
			//IL_05a9: Expected Obj, but got I4
			//IL_0351: Expected Obj, but got I
			//IL_04cd: Expected Obj, but got I
			//IL_03e2: Expected Obj, but got I4
			//IL_041a: Expected Obj, but got I4
			//IL_023c: Expected Obj, but got I
			//IL_0267: Expected Obj, but got I
			//IL_028c: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 8;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			IResponse response = default;
			if (response != null)
			{
				nint num = (nint)response;
				object obj4 = response + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S1_v85 (Il2CppClass<Kiloo.Common.HTTP.IResponse>)+D4] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj5 = default;
			object obj6;
			object obj9;
			_003C_003Ec__DisplayClass140_0 obj12;
			IRequest request3;
			if (obj5 != null && response != null && ResponseExtensions.IsJSON(response))
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 != 1;
				bool flag2 = !flag;
				object obj7 = default;
				obj6 = obj7;
				if (!flag2)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					object obj8 = default;
					obj6 = obj8;
					obj9 = obj8;
					if (flag3)
					{
						goto IL_056a;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj10 = default;
				object obj11 = default;
				bool flag4 = obj10 == obj11;
				bool flag5 = !flag4;
				_003C_003Ec__DisplayClass140_0 obj13 = default;
				obj12 = obj13;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 == 1;
					object obj14 = default;
					obj6 = obj14;
					if (!flag6)
					{
						object obj16 = default;
						object obj15 = obj16;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag7 = (nint)0 == 1;
						object obj17 = default;
						obj6 = obj17;
						if (!flag7)
						{
							if (obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj18 = (nint)0 << 2;
								object obj19 = obj3 + obj18;
								obj19 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj20 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj21 = -1;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
								IRequest request2 = (IRequest)obj16;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag8 = (nint)0 != 1;
								obj6 = obj17;
								request3 = request2;
								if (!flag8)
								{
									goto IL_02fb;
								}
							}
							goto IL_0549;
						}
					}
					goto IL_02fb;
				}
				goto IL_0367;
			}
			goto IL_0549;
			IL_0549:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text = default;
			string msg = "CreatePlayer: Request failed or bad response, status: " + text;
			LogError(msg);
			return;
			IL_056a:
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj22 = default;
				bool flag9 = obj22 == null;
				object obj23 = 0;
				if (!flag9)
				{
					bool flag10 = obj22 == typeof(string);
					obj23 = obj22;
					if (!flag10)
					{
						obj23 = 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj24 = default;
				bool flag11 = obj24 == null;
				object obj25 = 0;
				if (!flag11)
				{
					bool flag12 = obj24 == typeof(string);
					obj25 = obj24;
					if (!flag12)
					{
						obj25 = 0;
					}
				}
				if (obj23 != null && obj25 != null)
				{
					Manager manager = _003C_003E4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					Manager manager2 = _003C_003E4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					Manager manager3 = _003C_003E4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					Manager manager4 = _003C_003E4__this;
					manager4._managerDataIsDirty = true;
					return;
				}
			}
			goto IL_0549;
			IL_0367:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			obj9 = obj6;
			goto IL_056a;
			IL_02fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag13 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			request3 = (IRequest)0;
			_003C_003Ec__DisplayClass140_0 obj26 = default;
			obj12 = obj26;
			if (!flag13)
			{
				goto IL_0367;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			request3 = (IRequest)0;
			goto IL_0549;
		}
	}

	private sealed class _003CRequestCreatePlayer_003Ed__140(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_029b: Expected Obj, but got I4
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Expected Obj, but got Unknown
			//IL_02cf: Expected Obj, but got I
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Ref, but got Unknown
			//IL_00cd: Expected Obj, but got I
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected Obj, but got Unknown
			//IL_0204: Expected VT, but got Obj
			object obj = default;
			Manager manager = (Manager)(obj - 48);
			manager._ranks = null;
			manager._rankData = null;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_ = _003C_003E4__this;
				string facebookIdFromSocialManager = manager.GetFacebookIdFromSocialManager();
				manager._fetchingNewTournament = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (System.Object)+C]");
				if ((nint)0 != 0)
				{
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					ref ulong result = ref *(ulong*)(manager + 40);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (System.Object)+C]");
					bool flag = ulong.TryParse((string)0, NumberStyles.None, invariantCulture, out result);
					if (!manager._fetchingNewTournament)
					{
						_ = 0;
					}
				}
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ S4_v6 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
				manager._playerIdData = (IDictionary)manager._fetchingNewTournament;
				object obj2 = manager + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v148 @ S5_v5+4] (should have been resolved before IL gen)");
				string uriString = manager.MakeApiURL("/players/createplayer");
				Uri uri = default;
				uri._002Ector(uriString);
				IRequest request = KilooWebClient.CreatePost(uri);
				object jsonData = default;
				IRequest request2 = RequestExtensions.WithJsonContent(request, jsonData);
				float requestTimeout = manager.requestTimeout;
				IRequest request3 = RequestExtensions.WithTimeout(request2, requestTimeout);
				float requestMinBackOffTime = manager.requestMinBackOffTime;
				IRequest request4 = RequestExtensions.WithMinBackOffTime(request3, requestMinBackOffTime);
				float requestMaxBackOffTime = manager.requestMaxBackOffTime;
				IRequest request5 = RequestExtensions.WithMaxBackOffTime(request4, requestMaxBackOffTime);
				WebClient.RequestCompleteHandler requestCompleteHandler = default;
				object obj4 = default;
				requestCompleteHandler._002Ector(obj4, (nint)__ldftn(_003C_003Ec__DisplayClass140_0._003CRequestCreatePlayer_003Eb__0));
				object obj5 = manager + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				manager._managerData = manager._ranks;
				manager = (Manager)manager._rankData;
				Coroutine coroutine = RequestExtensions.ThenMakeTheRequestAsync(request5, requestCompleteHandler, (WebClient.SendOptions)manager);
				_003C_003E2__current = coroutine;
				_003C_003E1__state = 1;
			}
			return true;
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

	private sealed class _003C_003Ec__DisplayClass141_0
	{
		public Manager _003C_003E4__this;

		public string facebookId;

		internal void _003CRequestFacebookRegister_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_042d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0432: Expected Obj, but got Unknown
			//IL_001b: Expected I, but got Obj
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_0351: Expected Obj, but got I
			//IL_040a: Expected Obj, but got I
			//IL_023c: Expected Obj, but got I
			//IL_0267: Expected Obj, but got I
			//IL_028c: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 8;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			IResponse response = default;
			if (response != null)
			{
				nint num = (nint)response;
				object obj4 = response + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S1_v71 (Il2CppClass<Kiloo.Common.HTTP.IResponse>)+D4] (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj5 = default;
			object obj6;
			object obj9;
			_003C_003Ec__DisplayClass141_0 obj12;
			IRequest request3;
			if (obj5 != null && response != null && ResponseExtensions.IsJSON(response))
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 != 1;
				bool flag2 = !flag;
				object obj7 = default;
				obj6 = obj7;
				if (!flag2)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					object obj8 = default;
					obj6 = obj8;
					obj9 = obj8;
					if (flag3)
					{
						goto IL_04a7;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj10 = default;
				object obj11 = default;
				bool flag4 = obj10 == obj11;
				bool flag5 = !flag4;
				_003C_003Ec__DisplayClass141_0 obj13 = default;
				obj12 = obj13;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 == 1;
					object obj14 = default;
					obj6 = obj14;
					if (!flag6)
					{
						object obj16 = default;
						object obj15 = obj16;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag7 = (nint)0 == 1;
						object obj17 = default;
						obj6 = obj17;
						if (!flag7)
						{
							if (obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj18 = (nint)0 << 2;
								object obj19 = obj3 + obj18;
								obj19 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj20 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj21 = -1;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
								IRequest request2 = (IRequest)obj16;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag8 = (nint)0 != 1;
								obj6 = obj17;
								request3 = request2;
								if (!flag8)
								{
									goto IL_02fb;
								}
							}
							goto IL_0486;
						}
					}
					goto IL_02fb;
				}
				goto IL_0367;
			}
			goto IL_0486;
			IL_04a7:
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F4C");
				object obj22 = default;
				if (obj22 != null)
				{
					Manager manager = _003C_003E4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					Manager manager2 = _003C_003E4__this;
					manager2._managerDataIsDirty = true;
					return;
				}
			}
			goto IL_0486;
			IL_0486:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			string text = default;
			string msg = "FacebookRegister: Request failed or bad response, status: " + text;
			LogError(msg);
			return;
			IL_0367:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			obj9 = obj6;
			goto IL_04a7;
			IL_02fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag9 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			request3 = (IRequest)0;
			_003C_003Ec__DisplayClass141_0 obj23 = default;
			obj12 = obj23;
			if (!flag9)
			{
				goto IL_0367;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			request3 = (IRequest)0;
			goto IL_0486;
		}
	}

	private sealed class _003CRequestFacebookRegister_003Ed__141(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_007a: Expected Obj, but got I4
			//IL_00bb: Expected Obj, but got I4
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected Ref, but got Unknown
			//IL_011f: Expected Obj, but got I
			//IL_0176: Expected Obj, but got I
			//IL_0192: Expected Obj, but got I4
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected Obj, but got Unknown
			//IL_01cb: Expected Obj, but got I
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected Obj, but got Unknown
			//IL_02ea: Expected VT, but got Obj
			object obj = default;
			Manager manager = (Manager)(obj - 48);
			manager._fetchingNewTournament = false;
			manager._ranks = null;
			manager._rankData = null;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				Manager manager2 = _003C_003E4__this;
				_ = _003C_003E4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj2 = default;
				bool flag = obj2 == null;
				object obj3 = 0;
				if (!flag)
				{
					bool flag2 = obj2 == typeof(string);
					obj3 = obj2;
					if (!flag2)
					{
						obj3 = 0;
					}
				}
				string facebookIdFromSocialManager = manager.GetFacebookIdFromSocialManager();
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v21 (System.Object)+C]");
					if ((nint)0 != 0)
					{
						CultureInfo invariantCulture = CultureInfo.InvariantCulture;
						ref ulong result = ref *(ulong*)(manager + 40);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v21 (System.Object)+C]");
						if (ulong.TryParse((string)0, NumberStyles.None, invariantCulture, out result))
						{
							nint num = 0;
							nint num2 = 0;
							IntPtr intPtr = num2;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ S4_v8 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
							nint num3 = 0;
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
							object obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v178 @ S5_v5+4] (should have been resolved before IL gen)");
							manager._playerIdData = (IDictionary)manager._fetchingNewTournament;
							object obj5 = manager + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
							nint num5 = 0;
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S5_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v206 @ S5_v10+4] (should have been resolved before IL gen)");
							string uriString = manager.MakeApiURL("/facebook/register");
							Uri uri = default;
							uri._002Ector(uriString);
							IRequest request = KilooWebClient.CreatePost(uri);
							object jsonData = default;
							IRequest request2 = RequestExtensions.WithJsonContent(request, jsonData);
							float requestTimeout = manager.requestTimeout;
							IRequest request3 = RequestExtensions.WithTimeout(request2, requestTimeout);
							float requestMinBackOffTime = manager.requestMinBackOffTime;
							IRequest request4 = RequestExtensions.WithMinBackOffTime(request3, requestMinBackOffTime);
							float requestMaxBackOffTime = manager.requestMaxBackOffTime;
							IRequest request5 = RequestExtensions.WithMaxBackOffTime(request4, requestMaxBackOffTime);
							WebClient.RequestCompleteHandler requestCompleteHandler = default;
							object obj7 = default;
							requestCompleteHandler._002Ector(obj7, (nint)__ldftn(_003C_003Ec__DisplayClass141_0._003CRequestFacebookRegister_003Eb__0));
							object obj8 = manager + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
							manager._managerData = manager._ranks;
							manager = (Manager)manager._rankData;
							Coroutine coroutine = RequestExtensions.ThenMakeTheRequestAsync(request5, requestCompleteHandler, (WebClient.SendOptions)manager);
							_003C_003E2__current = coroutine;
							_003C_003E1__state = 1;
							goto IL_032c;
						}
					}
				}
				LogError("FacebookRegister: Cannot register now, missing private key and/or facebook id.");
			}
			goto IL_032c;
			IL_032c:
			return true;
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

	private const string KEY_COUNTRY = "country";

	private const string KEY_NEXT_TOURNAMENT_TIME = "nextTournamentTime";

	private const string KEY_LOCAL_PLAYER_FACEBOOK_ID = "localPlayerFacebookId";

	private const string KEY_LOCAL_PLAYER_PRIVATE_KEY = "localPlayerPrivateKey";

	private const string KEY_LOCAL_PLAYER_PUBLIC_KEY = "localPlayerPublicKey";

	private const string KEY_LAST_SUBMITTED_SCORE_START_TIME = "lastSubmittedScoreStartTime";

	private const string KEY_LAST_SUBMITTED_SCORE_END_TIME = "lastSubmittedScoreEndTime";

	private const string KEY_LAST_SUBMITTED_SCORE_COUNTRY = "lastSubmittedScoreCountry";

	private const string KEY_UNSUBMITTED_SCORE_NO_TOURNAMENT = "unsubmittedScoreNoTournament";

	private const string KEY_UNSUBMITTED_SCORE_NO_TOURNAMENT_TIME = "unsubmittedScoreNoTournamentTime";

	private const string KEY_CURRENT_TOURNAMENT = "currentTournament";

	private const string KEY_ID = "id";

	private const string KEY_SEQUENCE_ID = "sequenceId";

	private const string KEY_SUBMITTED_SCORE = "submittedScore";

	private const string KEY_UNSUBMITTED_SCORE = "unsubmittedScore";

	private const string KEY_START_TIME = "startTime";

	private const string KEY_END_TIME = "endTime";

	private const string KEY_NEXT_START_TIME = "nextStartTime";

	private const string KEY_CLOSED = "closed";

	private const string KEY_PARTICIPANTS = "participants";

	private const string KEY_PARTICIPANTS_TIME_STAMP = "participantsTimeStamp";

	private const string KEY_SCORE_MATCHED_PARTICIPANTS = "scoreMatchedParticipants";

	private const string KEY_SCORE_MATCHED_PARTICIPANTS_TIME_STAMP = "scoreMatchedParticipantsTimeStamp";

	private const string KEY_PREV_TOURNAMENT = "previousTournament";

	private const string KEY_RANKS = "ranks";

	private const string KEY_TOURNAMENT_ID = "tournamentId";

	private const string KEY_RANK = "rank";

	private const string KEY_PLAYER_ID_PUBLIC_KEY = "publicKey";

	private const string KEY_PLAYER_ID_NAME = "name";

	private readonly IDictionary _managerData;

	private bool _managerDataIsDirty;

	private readonly IDictionary _playerIdData;

	private bool _playerIdDataIsDirty;

	private readonly IDictionary _rankData;

	private Dictionary<string, Player> _currentTournamentPlayers;

	private Dictionary<string, Rank> _ranks;

	private Rank[] _currentTournamentRanks;

	private bool _fetchingNewTournament;

	private bool _isRefreshingTournament;

	private bool _isRefreshPending;

	private long _lastFriendsUpdate;

	private long _lastTournamentUpdate;

	private IList<string> _lastTournamentUpdateParticipantsPublicKeys;

	private bool _pauseRefreshing;

	private static readonly string[] TOURNAMENT_PARTICIPANT_LIST_KEYS;

	private int multiplier__BackingField;

	private int highScore__BackingField;

	private IRank rank__BackingField;

	private ITournament tournament__BackingField;

	private EventHandler<TournamentChangedEventArgs> m_tournamentChanged;

	private EventHandler<PlayerInfoChangedEventArgs> m_playerInfoChanged;

	public string country
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			string text = default;
			bool flag = text == null;
			string result = null;
			if (!flag)
			{
				bool flag2 = (object)text.GetType() == typeof(string);
				result = text;
				if (!flag2)
				{
					result = null;
				}
			}
			return result;
		}
		set
		{
			//IL_002a: Expected Obj, but got I4
			//IL_000e: Expected Obj, but got I4
			object obj;
			if (value != null)
			{
				obj = 0;
				if (value._stringLength != 0)
				{
					goto IL_010d;
				}
			}
			obj = 1;
			goto IL_010d;
			IL_010d:
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				string text = default;
				bool flag = text == null;
				string text2 = null;
				if (!flag)
				{
					bool flag2 = (object)text.GetType() == typeof(string);
					text2 = text;
					if (!flag2)
					{
						text2 = null;
					}
				}
				if (!(text2 == value))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
					_managerDataIsDirty = true;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ArgumentException ex = default;
				ex._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
		}
	}

	public int multiplier
	{
		get
		{
			return multiplier__BackingField;
		}
		set
		{
			multiplier__BackingField = value;
		}
	}

	public int highScore
	{
		get
		{
			return highScore__BackingField;
		}
		set
		{
			highScore__BackingField = value;
		}
	}

	public bool canSubmitScore
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			object obj = default;
			bool flag = obj == null;
			bool result = false;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F4C");
				result = false;
				object obj2 = default;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
					DateTime utcNow = CDateTime.UtcNow;
					long num = TimeUtility.ToUnixTime(utcNow);
					object obj3 = default;
					bool flag2 = (long)obj3 <= num;
					result = false;
					if (!flag2)
					{
						string text = JsonObject.Get<string>(_managerData, "lastSubmittedScoreCountry", null, null);
						if (text != null)
						{
							object dataSubObjectValue = GetDataSubObjectValue(_managerData, "currentTournament", "country");
							bool flag3 = dataSubObjectValue == null;
							string text2 = null;
							if (!flag3)
							{
								bool flag4 = (object)dataSubObjectValue.GetType() == typeof(string);
								text2 = (string)dataSubObjectValue;
								if (!flag4)
								{
									text2 = null;
								}
							}
							if (text != text2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
								object obj4 = default;
								bool flag5 = (long)obj4 > num;
								result = false;
								if (flag5)
								{
									goto IL_019b;
								}
							}
						}
						result = true;
					}
				}
			}
			goto IL_019b;
			IL_019b:
			return result;
		}
	}

	public bool isRefreshing
	{
		get
		{
			if (~(_isRefreshingTournament ? 1u : 0u) == 0)
			{
				return true;
			}
			return _isRefreshPending;
		}
	}

	public bool pauseRefreshing
	{
		get
		{
			return _pauseRefreshing;
		}
		set
		{
			_pauseRefreshing = value;
		}
	}

	public bool hasFetchedTournament
	{
		get
		{
			//IL_0066: Expected Obj, but got I4
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected I4, but got Unknown
			//IL_0047: Expected Obj, but got I4
			object dataSubObjectValue = GetDataSubObjectValue(_managerData, "currentTournament", "id");
			bool flag = dataSubObjectValue == null;
			object obj = null;
			if (!flag)
			{
				bool flag2 = (object)dataSubObjectValue.GetType() == typeof(string);
				obj = dataSubObjectValue;
				if (!flag2)
				{
					obj = null;
				}
			}
			object obj2;
			if (obj != null)
			{
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (System.Object)+8]");
				if ((nint)0 != 0)
				{
					goto IL_00c3;
				}
			}
			obj2 = 1;
			goto IL_00c3;
			IL_00c3:
			return (byte)(obj2 ^ 1) != 0;
		}
	}

	public unsafe int score
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Ref, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			object jsonObject = JsonObject.Get<object>(_managerData, "currentTournament");
			if (JsonObject.TryGet<int>(jsonObject, "unsubmittedScore", out *(int*)(obj + 12)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				return 0;
			}
			return JsonObject.Get(jsonObject, "submittedScore", 0);
		}
	}

	public IRank rank
	{
		get
		{
			return rank__BackingField;
		}
		private set
		{
			rank__BackingField = value;
		}
	}

	public DateTime nextTournamentFetchTime
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
			long num = default;
			bool flag = num == 0;
			bool flag2 = !flag;
			long unixtime = num;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
				object obj = default;
				if (obj == null)
				{
					return DateTime.MinValue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
				long num2 = default;
				bool flag3 = num2 >= 1;
				unixtime = num2;
				if (!flag3)
				{
					return DateTime.MaxValue;
				}
			}
			return TimeUtility.FromUnixTime(unixtime);
		}
	}

	public ITournament tournament
	{
		get
		{
			return tournament__BackingField;
		}
		private set
		{
			tournament__BackingField = value;
		}
	}

	private float requestTimeout
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return (float)instance.GetValue("toprun_request_timeout", 10.0);
		}
	}

	private float requestMinBackOffTime
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return (float)instance.GetValue("toprun_request_min_back_off_time", 1.0);
		}
	}

	private float requestMaxBackOffTime
	{
		get
		{
			OnlineSettings instance = OnlineSettings.instance;
			return (float)instance.GetValue("toprun_request_max_back_off_time", 120.0);
		}
	}

	public event EventHandler<TournamentChangedEventArgs> tournamentChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 88;
			Delegate obj2 = this.m_tournamentChanged;
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
			object obj = this + 88;
			Delegate obj2 = this.m_tournamentChanged;
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

	public event EventHandler<PlayerInfoChangedEventArgs> playerInfoChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 92;
			Delegate obj2 = this.m_playerInfoChanged;
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
			object obj = this + 92;
			Delegate obj2 = this.m_playerInfoChanged;
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

	public unsafe Manager(string defaultCountry, int multiplier, int highScore)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Rank[] currentTournamentRanks = default;
		_currentTournamentRanks = currentTournamentRanks;
		object obj;
		if (defaultCountry != null)
		{
			obj = 0;
			if (defaultCountry._stringLength != 0)
			{
				goto IL_0284;
			}
		}
		obj = 1;
		goto IL_0284;
		IL_0284:
		if (obj == null)
		{
			object obj2 = LoadJsonFile("toprun_manager");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			IDictionary dictionary = default;
			bool flag = dictionary != null;
			IDictionary managerData = dictionary;
			if (!flag)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ S4_v17 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
				IDictionary dictionary2 = default;
				managerData = dictionary2;
			}
			_managerData = managerData;
			_managerDataIsDirty = false;
			object obj3 = LoadJsonFile("toprun_playerids");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			IDictionary dictionary3 = default;
			bool flag2 = dictionary3 != null;
			IDictionary playerIdData = dictionary3;
			if (!flag2)
			{
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ S4_v12 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
				IDictionary dictionary4 = default;
				playerIdData = dictionary4;
			}
			_playerIdData = playerIdData;
			_playerIdDataIsDirty = false;
			object obj4 = LoadJsonFile("toprun_ranks");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			IDictionary dictionary5 = default;
			bool flag3 = dictionary5 != null;
			IDictionary rankData = dictionary5;
			if (!flag3)
			{
				nint num5 = 0;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ S4_v7 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
				IDictionary dictionary6 = default;
				rankData = dictionary6;
			}
			_rankData = rankData;
			InitializeRanksFromSaveData();
			InitializeCurrentTournamentPlayers();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj5 = default;
			bool flag4 = obj5 == null;
			object obj6 = 0;
			if (!flag4)
			{
				bool flag5 = obj5 == typeof(string);
				obj6 = obj5;
				if (!flag5)
				{
					obj6 = 0;
				}
			}
			if (obj6 == null)
			{
				country = defaultCountry;
			}
			this.highScore__BackingField = highScore;
			this.multiplier__BackingField = multiplier;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(Manager.OnPaused));
			ApplicationState.paused += action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(Manager.OnQuit));
			ApplicationState.quit += action2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private void OnQuit()
	{
		Save();
	}

	private void OnPaused()
	{
		Save();
	}

	private void InitializeCurrentTournamentPlayers()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Player>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, Player> currentTournamentPlayers = default;
		_currentTournamentPlayers = currentTournamentPlayers;
		AddFacebookFriendsWithIdsToCurrentTournamentPlayers();
		AddCurrentTournamentParticipantsToCurrentTournamentPlayers();
	}

	private void AddCurrentTournamentParticipantsToCurrentTournamentPlayers()
	{
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I4
		//IL_027a: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_01f7: Expected Obj, but got I4
		//IL_01d8: Expected Obj, but got I4
		//IL_023c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [532B4A]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		string[] tOURNAMENT_PARTICIPANT_LIST_KEYS = TOURNAMENT_PARTICIPANT_LIST_KEYS;
		object obj2 = default;
		object obj5 = default;
		IntPtr intPtr = default;
		string text = default;
		object obj11 = default;
		while ((nint)obj2 < tOURNAMENT_PARTICIPANT_LIST_KEYS.Length)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)tOURNAMENT_PARTICIPANT_LIST_KEYS + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				nint num = intPtr;
				while (true)
				{
					nint num2 = num - 1;
					if (num2 <= -1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					bool flag3 = text == null;
					string text2 = null;
					if (!flag3)
					{
						bool flag4 = (object)text.GetType() == typeof(string);
						text2 = text;
						if (!flag4)
						{
							text2 = null;
						}
					}
					bool flag5 = text2 == null;
					string text3 = null;
					if (flag5)
					{
						goto IL_0254;
					}
					string text4 = FindFacebookIdFromPublicKey(text2);
					object obj6;
					if (text4 != null)
					{
						obj6 = 0;
						if (text4._stringLength != 0)
						{
							goto IL_0335;
						}
					}
					obj6 = 1;
					goto IL_0335;
					IL_0254:
					object obj7;
					if (text3 != null)
					{
						obj7 = 0;
						if (text3._stringLength != 0)
						{
							goto IL_03ac;
						}
					}
					obj7 = 1;
					goto IL_03ac;
					IL_03ac:
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
						_playerIdDataIsDirty = true;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
					_managerDataIsDirty = true;
					num = num2;
					continue;
					IL_0335:
					text3 = text4;
					if (obj6 != null)
					{
						goto IL_0254;
					}
					object dataSubObjectValue = GetDataSubObjectValue(_playerIdData, text4, "name");
					bool flag6 = dataSubObjectValue == null;
					object obj8 = null;
					if (!flag6)
					{
						bool flag7 = (object)dataSubObjectValue.GetType() == typeof(string);
						obj8 = dataSubObjectValue;
						if (!flag7)
						{
							obj8 = null;
						}
					}
					object obj9;
					if (obj8 != null)
					{
						obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v66 (System.Object)+8]");
						if ((nint)0 != 0)
						{
							goto IL_0368;
						}
					}
					obj9 = 1;
					goto IL_0368;
					IL_0368:
					text3 = text4;
					if (obj9 == null)
					{
						_ = 0;
						nint num3 = 0;
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Player>>)+5C]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v309 @ S5_v9+4] (should have been resolved before IL gen)");
						num = num2;
						continue;
					}
					goto IL_0254;
				}
			}
			obj2 = obj11 + 1;
		}
	}

	private void AddFacebookFriendsWithIdsToCurrentTournamentPlayers()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		IList<Player> facebookFriendsWithPublicKeysAsPlayers = GetFacebookFriendsWithPublicKeysAsPlayers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = default;
		object obj5;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj4 == null;
				obj5 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj6 == obj7;
			bool flag3 = !flag2;
			object obj8 = obj9;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj5 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj5 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj12 = obj5 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	public unsafe IRank GetPlayerRank(string facebookId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Ref, but got Unknown
		//IL_0287: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Ref, but got Unknown
		//IL_00e0: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		object dataSubObjectValue = GetDataSubObjectValue(_playerIdData, facebookId, "publicKey");
		bool flag = dataSubObjectValue == null;
		object obj3 = null;
		if (!flag)
		{
			bool flag2 = (object)dataSubObjectValue.GetType() == typeof(string);
			obj3 = dataSubObjectValue;
			if (!flag2)
			{
				obj3 = null;
			}
		}
		bool flag3 = obj3 == null;
		IRank rank = null;
		object obj6 = default;
		if (!flag3)
		{
			if (tournament__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj4 = default;
				if (obj4 != null && _currentTournamentPlayers.TryGetValue((string)obj3, out *(Player*)(obj + 8)))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					Rank[] currentTournamentRanks = _currentTournamentRanks;
					if ((nint)obj6 < currentTournamentRanks.Length)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						Rank[] currentTournamentRanks2 = _currentTournamentRanks;
						Rank rank2 = currentTournamentRanks2[0];
						string text = default;
						if (!(text != rank2.country__BackingField))
						{
							goto IL_02f4;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					Rank[] currentTournamentRanks3 = default;
					_currentTournamentRanks = currentTournamentRanks3;
					IRank rank3 = null;
					object obj7 = default;
					if (System.Runtime.CompilerServices.Unsafe.As<IRank, UIntPtr>(ref rank3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						throw new ArrayTypeMismatchException();
					}
					goto IL_02f4;
				}
			}
			goto IL_023d;
		}
		goto IL_034c;
		IL_02f4:
		Rank[] currentTournamentRanks4 = _currentTournamentRanks;
		if ((nint)obj6 >= currentTournamentRanks4.Length)
		{
			goto IL_023d;
		}
		object obj8 = obj6 << 2;
		object obj9 = (object)currentTournamentRanks4 + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v27+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v27+10]");
		rank = (IRank)0;
		goto IL_033e;
		IL_023d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		rank = (IRank)0;
		goto IL_033e;
		IL_034c:
		return rank;
		IL_033e:
		if (rank == null)
		{
			bool flag4 = _ranks.TryGetValue((string)obj3, out *(Rank*)(obj + 12));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			rank = (IRank)0;
		}
		goto IL_034c;
	}

	public void FetchNextTournament()
	{
		if (~(_isRefreshingTournament ? 1u : 0u) != 0)
		{
			_isRefreshingTournament = true;
			InProcessFetchNextTournament();
		}
	}

	public void RefreshTournament()
	{
		IEnumerator coroutine = RefreshTournamentCoroutine();
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	public void SubmitScore(int multiplier, int scoreToSubmit, DateTime gameStartedTime)
	{
		IEnumerator coroutine = RequestSubmitScoreCoroutine(multiplier, scoreToSubmit, isRetry: false, previouslySavedScore: false);
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
	}

	public unsafe IPlayer GetPlayerByPublicKey(string publicKey)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		do
		{
			_ = 0;
		}
		while (_currentTournamentPlayers != null && _currentTournamentPlayers.TryGetValue(publicKey, out *(Player*)(obj + 12)));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (IPlayer)0;
	}

	internal static void ClearSavedData()
	{
		SaveJsonFile("toprun_manager", null);
		SaveJsonFile("toprun_playerids", null);
		SaveJsonFile("toprun_ranks", null);
	}

	private void FirePlayerInfoChangedEvent(IPlayer player)
	{
		EventHandler<PlayerInfoChangedEventArgs> eventHandler = this.m_playerInfoChanged;
		if (this.m_playerInfoChanged != null)
		{
			PlayerInfoChangedEventArgs e = default;
			e._002Ector();
			e.player__BackingField = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S0_v6 (System.EventHandler`1<TopRun.PlayerInfoChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private void FireTournamentChangedEvent(bool wasUpdated, bool didChange)
	{
		EventHandler<TournamentChangedEventArgs> eventHandler = this.m_tournamentChanged;
		if (this.m_tournamentChanged != null)
		{
			TournamentChangedEventArgs e = default;
			e._002Ector();
			e.tournamentDidChange__BackingField = didChange;
			e.tournamentWasUpdated__BackingField = wasUpdated;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S0_v6 (System.EventHandler`1<TopRun.TournamentChangedEventArgs>)+C] (should have been resolved before IL gen)");
		}
	}

	private string MakeApiURL(string apiResource)
	{
		OnlineSettings instance = OnlineSettings.instance;
		string value = instance.GetValue("toprun_base_url", "https://subwaysurfers.kiloo-games.com/api/v3");
		return value + apiResource;
	}

	private string FindFacebookIdFromPublicKey(string publicKey)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		string text = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			string result;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj5 == null)
				{
					result = null;
					goto IL_02fd;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj6 == null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								bool flag = obj7 == null;
								object obj8 = 0;
								if (!flag)
								{
									bool flag2 = obj7 == typeof(string);
									obj8 = obj7;
									if (!flag2)
									{
										obj8 = 0;
									}
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag3 = (nint)0 != 1;
									result = text;
									if (flag3)
									{
										goto IL_02fd;
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
						goto IL_0269;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0269;
			IL_02fd:
			object obj10 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			return result;
			IL_0269:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag4 = obj11 != obj12;
			object obj13 = obj14;
			if (flag4)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 == 1;
			result = null;
			if (!flag5)
			{
				goto IL_02fd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj13 = obj15;
			break;
		}
		_ = 0;
		object obj16 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		string result2 = default;
		return result2;
	}

	private static object GetDataSubObjectValue(IDictionary data, string subObjectKey, string subObjectValueKey)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object result = default;
			return result;
		}
		return null;
	}

	private static void SetDataSubObjectValue(IDictionary data, string subObjectKey, string subObjectValueKey, object value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F4A");
		object obj4 = default;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj5 = 0;
		}
		else
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S4_v6 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			object obj6 = default;
			object obj5 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
	}

	private static TimeSpan GetClientTimeOffset(IRequest request)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Headers headers = default;
			if (headers.Contains("Date"))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Headers headers2 = default;
				DateTime dateTime = headers2.Get("Date", DateTime.MinValue);
				if (dateTime != DateTime.MinValue)
				{
					DateTime utcNow = CDateTime.UtcNow;
					return utcNow - dateTime;
				}
			}
		}
		return TimeSpan.Zero;
	}

	private void CompleteRefreshProcess(bool isNewTournament)
	{
		_isRefreshingTournament = false;
		FireTournamentChangedEvent(wasUpdated: true, isNewTournament);
	}

	private IEnumerator RefreshTournamentCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator InProcessRefreshTournamentCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private int PropagateUnsubmittedScore()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		object obj3 = default;
		bool flag = obj3 == null;
		int result = 0;
		if (!flag)
		{
			int num = JsonObject.Get(obj3, "unsubmittedScore", 0);
			int num2 = JsonObject.Get(_managerData, "unsubmittedScoreNoTournament", 0);
			bool flag2 = num2 < 1;
			result = num;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13CB");
				object obj4 = default;
				bool flag3 = obj4 == null;
				result = num;
				if (!flag3)
				{
					object obj5 = default;
					bool flag4 = obj5 == null;
					result = num;
					if (!flag4)
					{
						object obj6 = default;
						bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5);
						result = num;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
							bool flag6 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
							result = num;
							if (!flag6)
							{
								bool flag7 = num >= num2;
								result = num;
								if (!flag7)
								{
									object obj7 = obj + 12;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
									result = num2;
								}
							}
							_managerDataIsDirty = true;
							Save();
						}
					}
				}
			}
		}
		return result;
	}

	private unsafe void InProcessFetchNextTournament()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0187: Expected VT, but got Obj
		object obj = default;
		Manager manager = (Manager)(obj - 32);
		manager._rankData = null;
		manager._playerIdData = null;
		string text = country;
		object obj2;
		if (text != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_01ce;
			}
		}
		obj2 = 1;
		goto IL_01ce;
		IL_01ce:
		if (obj2 != null)
		{
			LogError("FetchNextTournament: Country must be set first");
			return;
		}
		string text2 = country;
		string arg = manager.MakeApiURL("/tournaments/getlatesttournamentidbycountry");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (System.Object)+C]");
		string uriString = $"{arg}?Country={0}";
		Uri uri = default;
		uri._002Ector(uriString);
		IRequest request = KilooWebClient.CreateGet(uri);
		float timeout = manager.requestTimeout;
		IRequest request2 = RequestExtensions.WithTimeout(request, timeout);
		float minBackOffTime = manager.requestMinBackOffTime;
		IRequest request3 = RequestExtensions.WithMinBackOffTime(request2, minBackOffTime);
		float maxBackOffTime = manager.requestMaxBackOffTime;
		IRequest request4 = RequestExtensions.WithMaxBackOffTime(request3, maxBackOffTime);
		WebClient.RequestCompleteHandler requestCompleteHandler = default;
		object obj3 = default;
		requestCompleteHandler._002Ector(obj3, (nint)__ldftn(_003C_003Ec__DisplayClass114_0._003CInProcessFetchNextTournament_003Eb__0));
		object obj4 = manager + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		manager._managerData = manager._rankData;
		manager = (Manager)manager._playerIdData;
		Coroutine coroutine = RequestExtensions.ThenMakeTheRequestAsync(request4, requestCompleteHandler, (WebClient.SendOptions)manager);
	}

	private IList<FacebookProfile> GetFacebookFriendsWithNoPublicKeys()
	{
		//IL_0071: Expected Obj, but got I4
		//IL_00a1: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I
		List<FacebookProfile> list = default;
		list._002Ector();
		SocialManager instance = SocialManager.instance;
		if (instance.facebookIsLoggedIn && (instance._consolidationState & 1) != 0)
		{
			Friend[] array = instance.FriendsSortedByScore();
			object obj = 0;
			object obj6 = default;
			while ((nint)obj < array.Length)
			{
				object obj2 = obj << 2;
				object obj3 = (object)array + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v25+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v26+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v26+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v26+20]");
						list.Add((FacebookProfile)0);
					}
				}
				object obj7 = obj + 1;
				obj = obj7;
			}
		}
		return list;
	}

	private IList<Player> GetFacebookFriendsWithPublicKeysAsPlayers()
	{
		//IL_007b: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_0181: Expected Obj, but got I
		List<Player> list = default;
		list._002Ector();
		if (_playerIdData != null)
		{
			SocialManager instance = SocialManager.instance;
			if (instance.facebookIsLoggedIn && (instance._consolidationState & 1) != 0)
			{
				Friend[] array = instance.FriendsSortedByScore();
				nint num = unchecked((nint)null);
				Player player = default;
				while (num < array.Length)
				{
					object obj = num << 2;
					object obj2 = (object)array + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v28+10]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v29+20]");
					FacebookProfile facebookProfile = (FacebookProfile)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v29+20]");
					if ((nint)0 != 0)
					{
						object dataSubObjectValue = GetDataSubObjectValue(_playerIdData, facebookProfile.id, "publicKey");
						bool flag = dataSubObjectValue == null;
						object obj4 = null;
						if (!flag)
						{
							bool flag2 = (object)dataSubObjectValue.GetType() == typeof(string);
							obj4 = dataSubObjectValue;
							if (!flag2)
							{
								obj4 = null;
							}
						}
						if (obj4 != null)
						{
							player.publicKey__BackingField = (string)obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v29+20]");
							player.facebookProfile__BackingField = (FacebookProfile)0;
							player.isFriend__BackingField = true;
							list.Add(player);
						}
					}
					nint num2 = num + 1;
					num = num2;
				}
			}
		}
		return list;
	}

	private IEnumerator RequestPlayersByFacebookIds()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private bool HandleFindMatchedPlayersResponse(IRequest request, string managerDataTournamentParticipantListKey, string managerDataTournamentParticipantListTimeStampKey)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_13a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a8: Expected Obj, but got Unknown
		//IL_13f7: Expected Obj, but got I4
		//IL_140e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1413: Expected I4, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_1421: Expected Obj, but got I4
		//IL_123a: Expected Obj, but got I
		//IL_1265: Expected Obj, but got I
		//IL_128a: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_0deb: Expected Obj, but got I4
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Expected Obj, but got Unknown
		//IL_0920: Expected Obj, but got I
		//IL_14b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bb: Expected Obj, but got Unknown
		//IL_093f: Expected Obj, but got I
		//IL_0ebf: Expected Obj, but got I4
		//IL_1017: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Expected Obj, but got Unknown
		//IL_10d0: Expected Obj, but got I4
		//IL_0daf: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		IResponse response = default;
		if (response != null)
		{
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S1_v323 (Il2CppClass<Kiloo.Common.HTTP.IResponse>)+D4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj4 = default;
		bool flag = obj4 == null;
		object obj5 = 0;
		if (!flag)
		{
			bool flag2 = response == null;
			obj5 = 0;
			if (!flag2)
			{
				bool flag3 = ResponseExtensions.IsJSON(response);
				bool flag4 = !flag3;
				obj5 = 0;
				if (!flag4)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
							object obj6 = default;
							if (obj6 == null)
							{
								goto IL_1418;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
									object obj7 = default;
									if (obj7 != null)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
													object obj8 = default;
													bool flag5 = obj8 == null;
													bool flag6 = !flag5;
													object obj9 = obj8;
													if (flag6)
													{
														goto IL_038d;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																bool flag7 = (nint)0 == 1;
																object obj10 = default;
																obj9 = obj10;
																if (!flag7)
																{
																	goto IL_038d;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															goto IL_115b;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													goto IL_115b;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										goto IL_115b;
									}
									goto IL_1418;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_115b;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					goto IL_115b;
				}
			}
		}
		goto IL_1405;
		IL_1501:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj11 = default;
		object obj12;
		object obj21;
		object obj23;
		if (obj11 == obj12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj14 = default;
				object obj13 = obj14;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj15 = default;
					if (obj15 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj16 = (nint)0 << 2;
						object obj17 = obj3 + obj16;
						obj17 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj18 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
						object obj19 = -1;
						goto IL_1418;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj20 = obj14;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag8 = (nint)0 != 1;
					obj21 = obj20;
					if (flag8)
					{
						goto IL_1380;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag9 = (nint)0 != 1;
			object obj22 = default;
			obj21 = obj22;
			obj23 = obj22;
			if (!flag9)
			{
				goto IL_1358;
			}
		}
		goto IL_152a;
		IL_115b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		object obj24 = default;
		obj12 = obj24;
		object obj25 = default;
		obj23 = obj25;
		goto IL_1501;
		IL_0f24:
		object obj26;
		bool flag10 = (nint)obj26 != 11;
		if (obj26 == null)
		{
			flag10 = false;
		}
		if (!flag10)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @691");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16B9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj27 = obj + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									obj5 = 1;
									goto IL_1405;
								}
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
			goto IL_115b;
		}
		goto IL_1405;
		IL_038d:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			object obj28 = obj + 40;
			object obj29 = obj + 44;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj30 = default;
			object obj31 = default;
			object obj32 = default;
			object obj33 = default;
			object obj34 = default;
			object obj35 = default;
			object obj36 = default;
			object obj37 = default;
			object obj39 = default;
			object obj40 = default;
			object obj41 = default;
			object obj42 = default;
			object obj43 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					obj5 = obj30;
				}
				else
				{
					if (obj30 == null)
					{
						obj26 = 11;
						obj5 = obj30;
						goto IL_0ecd;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									if (obj31 != null && obj32 != null && obj33 != null)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											if (obj34 == null)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													obj5 = obj32;
													goto IL_0e2d;
												}
												_managerDataIsDirty = true;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_playerIdDataIsDirty = true;
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 != 1)
																{
																	if (obj35 != null)
																	{
																		continue;
																	}
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
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
																				_ = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																				if ((nint)0 != 1)
																				{
																					_ = 0;
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 != 1)
																					{
																						continue;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					obj5 = obj32;
																					goto IL_0e2d;
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			obj5 = obj32;
																			goto IL_0e2d;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	obj5 = obj32;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	obj5 = obj32;
																}
																goto IL_0e2d;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														obj5 = obj32;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														obj5 = obj32;
													}
													goto IL_0e2d;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											obj5 = obj32;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											obj5 = obj32;
										}
									}
									else
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
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
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
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
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
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
																						continue;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																					obj5 = obj36;
																					goto IL_0e2d;
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			obj5 = obj36;
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			obj5 = 0;
																		}
																		goto IL_0e2d;
																	}
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																obj5 = obj37;
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																obj5 = obj32;
															}
															goto IL_0e2d;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													obj5 = obj32;
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													obj5 = obj32;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												obj5 = obj32;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											obj5 = obj32;
										}
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									obj5 = obj32;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								obj5 = obj32;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj5 = 0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj5 = 0;
					}
				}
				goto IL_0e2d;
				IL_0ecd:
				_ = 0;
				object obj38 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0f24;
				}
				goto IL_10d5;
				IL_0e2d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag11 = obj39 != obj40;
				obj12 = obj39;
				obj23 = obj41;
				if (flag11)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag12 = (nint)0 == 1;
				obj26 = 0;
				if (!flag12)
				{
					goto IL_0ecd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj42;
				obj23 = obj43;
				break;
			}
			_ = 0;
			object obj44 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				obj21 = obj23;
				goto IL_1358;
			}
			goto IL_1501;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_115b;
		IL_1405:
		return (byte)(obj5 & 1) != 0;
		IL_1358:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_1380;
		IL_152a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_1418;
		IL_1380:
		obj23 = obj21;
		goto IL_152a;
		IL_1418:
		obj5 = 0;
		goto IL_1405;
		IL_10d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_115b;
	}

	private IEnumerator RequestFindMatchedPlayers()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private int GetAmountOfChallengersToRequest()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I8
		//IL_012b: Expected Obj, but got I8
		//IL_016e: Invalid comparison between F8 and Obj
		//IL_01bc: Invalid comparison between F8 and Obj
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_024e: Expected Obj, but got I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected Obj, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		bool flag = tournament__BackingField == null;
		int result = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			result = 0;
			object obj3 = default;
			if (obj3 == null)
			{
				OnlineSettings instance = OnlineSettings.instance;
				int value = instance.GetValue("toprun_challengers_amount", 0);
				bool flag2 = value < 1;
				result = 0;
				if (!flag2)
				{
					object dataSubObjectValue = GetDataSubObjectValue(_managerData, "currentTournament", "scoreMatchedParticipants");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
					result = 0;
					object obj4 = default;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
						DateTime time = default;
						long num = TimeUtility.ToUnixTime(time);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
						DateTime time2 = default;
						long num2 = TimeUtility.ToUnixTime(time2);
						object obj5 = num2 - num;
						DateTime utcNow = CDateTime.UtcNow;
						long num3 = TimeUtility.ToUnixTime(utcNow);
						object obj6 = num3 - num;
						OnlineSettings instance2 = OnlineSettings.instance;
						double value2 = instance2.GetValue("toprun_challengers_period_normalized_start", 0.5);
						object obj7 = obj6 / obj5;
						bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)value2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
						result = 0;
						if (!flag3)
						{
							OnlineSettings instance3 = OnlineSettings.instance;
							double value3 = instance3.GetValue("toprun_challengers_period_normalized_end", 2925.0 / 4095.0);
							bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)value3) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
							result = 0;
							if (!flag4)
							{
								OnlineSettings instance4 = OnlineSettings.instance;
								int value4 = instance4.GetValue("toprun_challengers_placement_requirement", 4);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
								object obj8 = obj + 28;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
								_ = 0;
								object obj9 = 1;
								object obj10 = default;
								object obj11 = default;
								object obj12 = default;
								object obj14 = default;
								object obj15 = default;
								object obj17 = default;
								object obj18 = default;
								int result2 = default;
								while (true)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										if (obj10 == null)
										{
											break;
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
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
													{
														break;
													}
													object obj13 = obj9 + 1;
													obj9 = obj13;
													continue;
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
									bool flag5 = obj14 != obj15;
									object obj16 = obj17;
									if (!flag5)
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
										obj16 = obj18;
									}
									_ = 0;
									object obj19 = obj + 16;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
									return result2;
								}
								bool flag6 = (nint)obj9 > value4;
								int num4 = 0;
								if (!flag6)
								{
									num4 = value;
								}
								object obj20 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
								result = num4;
							}
						}
					}
				}
			}
		}
		return result;
	}

	private IEnumerator RequestFindMatchedPlayersByCurrentScore()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void GetMissingFacebookInfo()
	{
		IEnumerator missingFacebookInfoCoroutine = GetMissingFacebookInfoCoroutine();
		Coroutine coroutine = CoroutineUtil.StartCoroutine(missingFacebookInfoCoroutine);
	}

	private IEnumerator GetMissingFacebookInfoCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe bool IsFacebookIDInvalid(string facebookId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = int.TryParse(facebookId, out *(int*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		bool flag2 = (nint)0 == 0;
		return flag & flag2;
	}

	private unsafe Coroutine DownloadFacebookImage(string facebookId, Action<Texture2D> onComplete)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0113: Expected VT, but got Obj
		object obj = default;
		Manager manager = (Manager)(obj - 32);
		manager._rankData = null;
		manager._playerIdData = null;
		string uriString = "http://graph.facebook.com/" + facebookId + "/picture?type=square";
		Uri uri = default;
		uri._002Ector(uriString);
		IRequest request = WebClient.CreateGet(uri);
		float timeout = manager.requestTimeout;
		IRequest request2 = RequestExtensions.WithTimeout(request, timeout);
		float minBackOffTime = manager.requestMinBackOffTime;
		IRequest request3 = RequestExtensions.WithMinBackOffTime(request2, minBackOffTime);
		float maxBackOffTime = manager.requestMaxBackOffTime;
		IRequest request4 = RequestExtensions.WithMaxBackOffTime(request3, maxBackOffTime);
		IRequest request5 = RequestExtensions.WithIgnoreCertificateErrors(request4, ignoreCertificateErrors: true);
		WebClient.RequestCompleteHandler requestCompleteHandler = default;
		object obj2 = default;
		requestCompleteHandler._002Ector(obj2, (nint)__ldftn(_003C_003Ec__DisplayClass125_0._003CDownloadFacebookImage_003Eb__0));
		object obj3 = manager + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		manager._managerData = manager._rankData;
		manager = (Manager)manager._playerIdData;
		return RequestExtensions.ThenMakeTheRequestAsync(request5, requestCompleteHandler, (WebClient.SendOptions)manager);
	}

	private List<Player> GetTournamentPlayersWithMissingFacebookInfo()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_03dc: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		List<Player> list = default;
		list._002Ector();
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		List<Player> list2 = default;
		List<Player> list3 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
					object obj8 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v82+10]");
						if ((nint)0 != 0)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v82+14]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v82+14]");
						if ((nint)0 == 0)
						{
							goto IL_024c;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj10 == null)
								{
									continue;
								}
								goto IL_024c;
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
			goto IL_0299;
			IL_0299:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj11 == obj12;
			bool flag3 = !flag2;
			List<Player> result = list2;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = list3;
			}
			_ = 0;
			object obj13 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
			IL_024c:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0299;
		}
		object obj14 = obj7 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4F46");
		return list;
	}

	private void PurgeSelfFromParticipants()
	{
		//IL_0153: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		string text = JsonObject.Get<string>(_managerData, "localPlayerPublicKey", null, null);
		bool flag = text == null;
		bool flag2 = !flag;
		string key = text;
		if (!flag2)
		{
			SocialManager instance = SocialManager.instance;
			if (!instance.facebookIsLoggedIn || (instance._consolidationState & 1) == 0)
			{
				return;
			}
			FacebookProfile fbProfile = instance._fbProfile;
			if (instance._fbProfile == null)
			{
				return;
			}
			object dataSubObjectValue = GetDataSubObjectValue(_playerIdData, fbProfile.id, "publicKey");
			bool flag3 = dataSubObjectValue == null;
			object obj = null;
			if (!flag3)
			{
				bool flag4 = (object)dataSubObjectValue.GetType() == typeof(string);
				obj = dataSubObjectValue;
				if (!flag4)
				{
					obj = null;
				}
			}
			bool flag5 = obj == null;
			key = (string)obj;
			if (flag5)
			{
				return;
			}
		}
		if (!_currentTournamentPlayers.Remove(key))
		{
			return;
		}
		string[] tOURNAMENT_PARTICIPANT_LIST_KEYS = TOURNAMENT_PARTICIPANT_LIST_KEYS;
		object obj2 = 0;
		object obj6 = default;
		while ((nint)obj2 < tOURNAMENT_PARTICIPANT_LIST_KEYS.Length)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)tOURNAMENT_PARTICIPANT_LIST_KEYS + obj3;
			IDictionary managerData = _managerData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v26+10]");
			object dataSubObjectValue2 = GetDataSubObjectValue(managerData, "currentTournament", (string)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			object obj5 = obj6;
			if (obj6 == null)
			{
				obj5 = obj5;
			}
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			}
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
	}

	private void PurgeUnneededIds()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00a1: Expected Obj, but got I4
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected Obj, but got Unknown
		//IL_05e3: Expected Obj, but got I4
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected Obj, but got Unknown
		//IL_026b: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got I4
		//IL_02ac: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I
		//IL_03be: Expected Obj, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_0436: Expected Obj, but got I
		//IL_0447: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		SocialManager instance = SocialManager.instance;
		if (!instance.facebookIsLoggedIn || (instance._consolidationState & 1) == 0)
		{
			return;
		}
		Friend[] array = instance.FriendsSortedByScore();
		List<string> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 40;
		object obj4 = obj + 44;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj16 = default;
		object obj17 = default;
		object obj19 = default;
		object obj20 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		object obj28 = default;
		object obj29 = default;
		object obj30 = default;
		object obj31 = default;
		object obj32 = default;
		object obj33 = default;
		while (true)
		{
			IL_08ae:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_057c;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
								if (obj6 == null)
								{
									goto IL_02b1;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									bool flag = obj7 == null;
									object obj8 = 0;
									if (!flag)
									{
										bool flag2 = obj7 == typeof(string);
										obj8 = obj7;
										if (!flag2)
										{
											obj8 = 0;
										}
									}
									if (obj8 == null)
									{
										goto IL_02b1;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										bool flag3 = obj9 == null;
										object obj10 = 0;
										if (!flag3)
										{
											continue;
										}
										object obj18;
										object obj15;
										for (; array.Length > (nint)obj10; obj18 = obj10 + 1, obj16 = obj15, obj10 = obj18)
										{
											object obj11 = obj10 << 2;
											object obj12 = (object)array + obj11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S0_v244+10]");
											object obj13 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ S0_v245+20]");
											object obj14 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ S0_v245+20]");
											bool flag4 = (nint)0 == 0;
											obj15 = obj16;
											if (flag4)
											{
												continue;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												obj15 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												obj16 = 0;
												if (obj17 == null)
												{
													continue;
												}
												goto IL_08ae;
											}
											goto IL_04cc;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
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
						goto IL_04ea;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_04ea;
			IL_04cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_04ea;
			IL_04ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag5 = obj19 != obj20;
			object obj21 = obj22;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				obj = obj23;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_057c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj21 = obj24;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj25;
			if ((nint)0 != 1)
			{
				obj25 = obj21;
				break;
			}
			goto IL_082d;
			IL_02b1:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_04ea;
			IL_057c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			if (list._size <= 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj26 = obj + 24;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj27 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj28 == null)
					{
						goto IL_07b6;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_playerIdDataIsDirty = true;
							continue;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag6 = obj29 != obj30;
				obj21 = obj31;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				obj = obj32;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_07b6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj21 = obj33;
				break;
				IL_07b6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5C5");
				return;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 != 1;
			obj25 = obj21;
			if (flag7)
			{
				break;
			}
			goto IL_082d;
			IL_082d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			obj25 = obj21;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private IEnumerator RequestTournamentData(Action<bool> onComplete)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator RequestNextTournamentFetchTime()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IList<string> GetPublicKeysForPlayersWeHaveNotRequestedRanksFor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0545: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I4
		//IL_020b: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		List<string> list = default;
		int capacity = default;
		list._002Ector(capacity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		List<string> result;
		object obj6;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		object obj14 = default;
		object obj15 = default;
		object obj17 = default;
		object obj18 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = obj5 == null;
				result = list;
				obj6 = obj;
				if (flag)
				{
					break;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj7 == null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								bool flag2 = obj8 == null;
								object obj9 = 0;
								if (!flag2)
								{
									bool flag3 = obj8 == typeof(string);
									obj9 = obj8;
									if (!flag3)
									{
										obj9 = 0;
									}
								}
								if (obj9 == null)
								{
									continue;
								}
								bool flag4 = obj10 == null;
								object obj11 = obj12;
								if (!flag4)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										goto IL_032f;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									obj11 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									obj12 = 0;
									if (obj13 != null)
									{
										continue;
									}
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag5 = (nint)0 != 1;
								obj12 = obj11;
								if (flag5)
								{
									continue;
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
						goto IL_032f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_032f;
			IL_032f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag6 = obj14 == obj15;
			bool flag7 = !flag6;
			object obj16 = obj17;
			result = list;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag8 = (nint)0 != 1;
				result = null;
				obj6 = obj;
				if (flag8)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj16 = obj18;
				result = null;
			}
			_ = 0;
			object obj19 = obj + 8;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			break;
		}
		object obj20 = obj6 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
		return result;
	}

	private IEnumerator RequestRanksForPlayers()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator RequestSubmitScoreCoroutine(int multiplier, int scoreToSubmit, bool isRetry, bool previouslySavedScore)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private string GetFacebookIdFromSocialManager()
	{
		SocialManager instance = SocialManager.instance;
		bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
		bool flag = !facebookIsLoggedIn;
		string result = null;
		if (!flag)
		{
			FacebookProfile fbProfile = instance._fbProfile;
			bool flag2 = instance._fbProfile == null;
			result = null;
			if (!flag2)
			{
				result = fbProfile.id;
			}
		}
		return result;
	}

	private string GetNameFromSocialManager()
	{
		SocialManager instance = SocialManager.instance;
		bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
		bool flag = !facebookIsLoggedIn;
		string result = null;
		if (!flag)
		{
			FacebookProfile fbProfile = instance._fbProfile;
			bool flag2 = instance._fbProfile == null;
			result = null;
			if (!flag2)
			{
				result = fbProfile.name;
			}
		}
		return result;
	}

	private IEnumerator RefreshKeysIfNecessary()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator LoginOrRegisterFacebook()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator LoginOrCreatePlayer()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator RequestFacebookLogin(Action<FacebookLoginResult> onComplete)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator RequestCreatePlayer()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator RequestFacebookRegister()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void InitializeRanksFromSaveData()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_01c5: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I4
		//IL_030c: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I4
		//IL_02ed: Expected Obj, but got I4
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (_rankData != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
			object obj3 = default;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ S4_v11 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Manager+Rank>>>)+4] (should have been resolved before IL gen)");
				Dictionary<string, Rank> ranks = default;
				_ranks = ranks;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj4 = obj + 24;
				object obj5 = obj + 28;
				obj = obj5;
				_ = 0;
				object obj6 = default;
				object obj8 = default;
				object obj10 = default;
				object obj11 = default;
				object obj15 = default;
				object obj16 = default;
				Manager manager2 = default;
				Manager manager3 = default;
				object obj17 = default;
				while (true)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					object obj13;
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						if (obj6 == null)
						{
							goto IL_04e7;
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
								object obj7 = obj8;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									bool flag = obj8 == null;
									object obj9 = 0;
									if (!flag)
									{
										bool flag2 = obj7 == typeof(string);
										obj9 = obj8;
										if (!flag2)
										{
											obj9 = 0;
										}
									}
									if (obj10 == null || obj9 == null)
									{
										continue;
									}
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										bool flag3 = obj11 == null;
										object obj12 = 0;
										if (!flag3)
										{
											bool flag4 = obj11 == typeof(string);
											obj12 = obj11;
											if (!flag4)
											{
												obj12 = 0;
											}
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											if (obj12 != null)
											{
												obj13 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S0_v129+8]");
												if ((nint)0 != 0)
												{
													goto IL_0693;
												}
											}
											obj13 = 1;
											goto IL_0693;
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
								goto IL_0458;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					goto IL_0458;
					IL_04e7:
					object obj14 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
					return;
					IL_0458:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag5 = obj15 != obj16;
					Manager manager = manager2;
					if (flag5)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_04e7;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					manager = manager3;
					break;
					IL_0693:
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						bool flag6 = (nint)obj17 < 0;
						object obj18 = obj13 | flag6;
						if (obj18 != null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_0458;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					goto IL_0458;
				}
				_ = 0;
				object obj19 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
		}
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ S4_v6 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Manager+Rank>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, Rank> ranks2 = default;
		_ranks = ranks2;
	}

	private void ClearKeys()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
		_managerDataIsDirty = true;
	}

	private static object LoadJsonFile(string file)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_0619: Expected Obj, but got I
		//IL_0644: Expected Obj, but got I
		//IL_0564: Expected Obj, but got I
		//IL_0423: Expected Obj, but got I
		//IL_045f: Expected Obj, but got I
		//IL_048a: Expected Obj, but got I
		//IL_04af: Expected Obj, but got I
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_03bf: Expected Obj, but got I4
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag = (nint)0 != 1;
								object obj4 = default;
								result = obj4;
								if (flag)
								{
									goto IL_05fe;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag2 = obj5 == obj6;
		bool flag3 = !flag2;
		object obj7 = obj3;
		object obj9 = default;
		object obj8 = obj9;
		object result2 = default;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj11 = default;
				object obj10 = obj11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					obj7 = obj3;
					obj8 = obj11;
					object obj12 = default;
					if (obj12 != null)
					{
						goto IL_0603;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj13 = obj11;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj14 = default;
							if (obj14 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj15 = (nint)0 << 2;
								object obj16 = obj3 + obj15;
								obj16 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj17 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj18 = (nint)0 << 2;
								object obj19 = obj18 + obj3;
								object obj20 = obj19 - 4;
								object obj21 = obj20;
								bool flag4 = obj20 == null;
								string text = "LoadJsonFile failed: ";
								string text2 = null;
								if (!flag4)
								{
									object obj22 = obj21;
									object obj23 = obj21 + 24;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v434 @ S1_v67+D4] (should have been resolved before IL gen)");
									text = "LoadJsonFile failed: ";
									string text3 = default;
									text2 = text3;
								}
								string msg = text + text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
								LogError(msg);
								obj7 = obj3;
								goto IL_054e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj24 = obj11;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag5 = (nint)0 != 1;
							result2 = flag5;
							if (flag5)
							{
								goto IL_059b;
							}
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			object obj25 = default;
			obj8 = obj25;
			if (flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				goto IL_059b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0603;
		IL_059b:
		return result2;
		IL_0603:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ L1_v4+4]");
		object obj26 = (nint)0 << 2;
		object obj27 = obj7 + obj26;
		obj27 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ L1_v4+4]");
		object obj28 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
		goto IL_054e;
		IL_05fe:
		return result;
		IL_054e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ L1_v4+4]");
		object obj29 = -1;
		result = null;
		goto IL_05fe;
	}

	private static void SaveJsonFile(string file, object json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_04a3: Expected Obj, but got I
		//IL_034a: Expected Obj, but got I
		//IL_0375: Expected Obj, but got I
		//IL_039a: Expected Obj, but got I
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_0442: Expected Obj, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (json == null)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						_ = 0;
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
										return;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj11 = (nint)0 << 2;
						object obj12 = obj3 + obj11;
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = (nint)0 << 2;
						object obj15 = obj14 + obj3;
						object obj16 = obj15 - 4;
						object obj17 = obj16;
						bool flag2 = obj16 == null;
						string text = "SaveJsonFile failed: ";
						string text2 = null;
						if (!flag2)
						{
							object obj18 = obj17;
							object obj19 = obj17 + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v387 @ S1_v53+D4] (should have been resolved before IL gen)");
							text = "SaveJsonFile failed: ";
							string text3 = default;
							text2 = text3;
						}
						string msg = text + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						LogError(msg);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj20 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj21 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj6 = 0;
					if (flag3)
					{
						goto IL_05a4;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj22 = default;
			obj6 = obj22;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj6 = obj22;
			}
		}
		goto IL_05a4;
		IL_05a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private void Save()
	{
		if (~(_managerDataIsDirty ? 1u : 0u) == 0)
		{
			SaveJsonFile("toprun_manager", _managerData);
			_managerDataIsDirty = false;
		}
		if (~(_playerIdDataIsDirty ? 1u : 0u) == 0)
		{
			SaveJsonFile("toprun_playerids", _playerIdData);
			_playerIdDataIsDirty = false;
		}
	}

	public static string QuoteString(string s)
	{
		if (s != null)
		{
			return "\"" + s + "\"";
		}
		return "null";
	}

	public static void LogError(object msg)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		string text = default;
		if (msg != null)
		{
			nint num = (nint)msg;
			object obj = msg + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S2_v4 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
		}
		else
		{
			text = null;
		}
		string text2 = "[TopRun.Manager] " + text;
	}

	public static void LogWarning(object msg)
	{
	}

	public static void Log(object msg)
	{
	}

	static Manager()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
