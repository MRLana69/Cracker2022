using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Common;
using Kiloo.Common.Backend;
using Kiloo.Common.Extensions;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin.Internal;
using Missions;
using Onboarding;
using SYBO.Common.Utilities.Flags;
using SYBO.Components.Utilities;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace TopRun.Internal;

internal class Manager : IManager, ITournamentPlayerManager
{
	private delegate IList ParticipantSelector(TournamentData tour);

	private delegate void ParticipantSetter(TournamentData tour, IList list);

	private delegate void TimestampSetter(TournamentData tour, DateTime? timestamp);

	private enum FacebookLoginResult
	{
		Success,
		Failed,
		NotFound
	}

	private sealed class _003CRefreshTournamentCoroutine_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0175: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Expected Obj, but got Unknown
				//IL_0190: Expected Obj, but got I4
				//IL_01b5: Expected Obj, but got I4
				//IL_0122: Unknown result type (might be due to invalid IL or missing references)
				//IL_0127: Expected Obj, but got Unknown
				//IL_0130: Expected Obj, but got I4
				//IL_015c: Expected Obj, but got I4
				Manager manager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (~(manager._isRefreshPending ? 1u : 0u) == 0)
					{
						return null;
					}
					if (~(manager._isRefreshingTournament ? 1u : 0u) != 0)
					{
						goto IL_0161;
					}
					manager._isRefreshPending = true;
				}
				if (~(manager._isRefreshingTournament ? 1u : 0u) == 0)
				{
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				manager._isRefreshPending = false;
				goto IL_0161;
				IL_0161:
				manager._isRefreshingTournament = true;
				object obj2 = this + 12;
				int num = manager.PropagateUnsubmittedScore();
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])num);
				obj2 = coroutine;
				_003C_003E1__state = 2;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CRefreshTournamentCoroutine_003Ed__80(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

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

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public bool mustFetchNewTournament;

		public _003C_003Ec__DisplayClass81_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CInProcessRefreshTournamentCoroutine_003Eb__0(bool isTournamentNotFound)
		{
			mustFetchNewTournament = isTournamentNotFound;
		}
	}

	private sealed class _003CInProcessRefreshTournamentCoroutine_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private _003C_003Ec__DisplayClass81_0 _003C_003E8__1;

		private SocialManager _003CsocialManager_003E5__2;

		private bool _003CisNewTournament_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0156: Expected Obj, but got Unknown
				//IL_038e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0393: Expected Obj, but got Unknown
				//IL_039c: Expected Obj, but got I4
				//IL_03b0: Expected Obj, but got I4
				//IL_020c: Expected I, but got Obj
				//IL_0222: Expected Obj, but got I
				//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d3: Expected Obj, but got Unknown
				//IL_03dc: Expected Obj, but got I4
				//IL_03f0: Expected Obj, but got I4
				//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_08b0: Expected Obj, but got Unknown
				//IL_08c1: Expected Obj, but got I4
				//IL_08cf: Expected I, but got Obj
				//IL_08e5: Expected Obj, but got I
				//IL_024d: Expected I, but got Obj
				//IL_0796: Unknown result type (might be due to invalid IL or missing references)
				//IL_079b: Expected Obj, but got Unknown
				//IL_07a4: Expected Obj, but got I4
				//IL_029a: Expected I, but got Obj
				//IL_0976: Expected Obj, but got I4
				//IL_047a: Unknown result type (might be due to invalid IL or missing references)
				//IL_047f: Expected Obj, but got Unknown
				//IL_0456: Unknown result type (might be due to invalid IL or missing references)
				//IL_045b: Expected Obj, but got Unknown
				//IL_0464: Expected Obj, but got I4
				//IL_095a: Expected Obj, but got I4
				//IL_0551: Unknown result type (might be due to invalid IL or missing references)
				//IL_0556: Expected Obj, but got Unknown
				//IL_0566: Unknown result type (might be due to invalid IL or missing references)
				//IL_056b: Expected Obj, but got Unknown
				//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e8: Expected Obj, but got Unknown
				//IL_04f1: Expected Obj, but got I4
				//IL_0968: Expected Obj, but got I4
				//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_05d8: Expected Obj, but got Unknown
				//IL_05e1: Expected Obj, but got I4
				//IL_05f5: Expected Obj, but got I4
				//IL_0358: Expected Obj, but got I4
				//IL_069b: Expected VT, but got I4
				//IL_069b: Expected VT, but got I4
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
												bool flag = _003CisNewTournament_003E5__3;
												((Player)(object)manager).publicKey = (string)flag;
												return null;
											}
											return null;
										}
										_003C_003E1__state = -1;
										if (~(manager._pauseRefreshing ? 1u : 0u) == 0)
										{
											object obj = this + 12;
											obj = 0;
											_003C_003E1__state = 9;
											return 1;
										}
										_003C_003Ec__DisplayClass81_0 obj2 = _003C_003E8__1;
										if (~(obj2.mustFetchNewTournament ? 1u : 0u) == 0)
										{
											manager._isRefreshPending = false;
											manager.GetMissingFacebookInfo();
											return null;
										}
										manager.PurgeSelfFromParticipants();
										IList<FacebookProfile> facebookFriendsToRequestPublicKeysFor = ((Manager)null).GetFacebookFriendsToRequestPublicKeysFor();
										if ((nint)facebookFriendsToRequestPublicKeysFor >= 1)
										{
											GameObject list = ((SpawnPool)(object)manager).InstantiatePrefab((GameObject)(object)facebookFriendsToRequestPublicKeysFor, (Vector3)0, (Quaternion)1);
											Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
										string facebookIdFromSocialManager = manager.GetFacebookIdFromSocialManager();
										Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)facebookIdFromSocialManager);
										throw new ArrayTypeMismatchException();
									}
									_003C_003E1__state = -1;
									if (~(manager._pauseRefreshing ? 1u : 0u) == 0)
									{
										object obj3 = this + 12;
										obj3 = 0;
										_003C_003E1__state = 7;
									}
									else
									{
										manager.PurgeUnneededIds();
										manager.ClearKeys();
										_003C_003Ec__DisplayClass81_0 obj4 = _003C_003E8__1;
										obj4.mustFetchNewTournament = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
										nint num = 0;
										_ = 0;
										Action<FacebookLoginResult> action = default;
										object obj5 = action + 16;
										obj5 = _003C_003E8__1;
										object obj6 = this + 12;
										IEnumerator list2 = manager.RequestFacebookLogin(action);
										Coroutine coroutine3 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list2);
										obj6 = coroutine3;
										_003C_003E1__state = 8;
									}
									return 1;
								}
								_003C_003E1__state = -1;
								if (~(manager._pauseRefreshing ? 1u : 0u) == 0)
								{
									object obj7 = this + 12;
									obj7 = 0;
									_003C_003E1__state = 5;
								}
								else
								{
									object obj8 = this + 12;
									IEnumerator missingFacebookInfoCoroutine = manager.GetMissingFacebookInfoCoroutine();
									Coroutine coroutine4 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)missingFacebookInfoCoroutine);
									obj8 = coroutine4;
									_003C_003E1__state = 6;
								}
								return 1;
							}
							_003C_003E1__state = -1;
							goto IL_0774;
						}
						_003C_003E1__state = -1;
						goto IL_092f;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj9 = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj10 = default;
					obj9 = obj10;
					RanksData ranksData = TopRunSave.ranksData;
					Dictionary<string, Rank> ranks = ranksData.ranks;
					if (ranksData.ranks != null)
					{
						int[] buckets = ranks.buckets;
						bool flag2;
						if (ranks.buckets != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v57 (System.Int32[])+8]");
							flag2 = (nint)0 == 0;
						}
						else
						{
							flag2 = true;
						}
						if (!flag2)
						{
							nint num2 = (nint)typeof(SocialManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v60 (Il2CppClass<SocialManager>)+BA]");
							object obj11 = (nint)0 & (nint)0x200;
							if (obj11 != null)
							{
								nint num3 = (nint)typeof(SocialManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v70 (Il2CppClass<SocialManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj12 = this + 24;
							bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
							obj12 = facebookDialogsSupported;
							nint num4 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj13 = (nint)0 & (nint)0x200;
							if (obj13 != null)
							{
								nint num5 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)(object)_003CsocialManager_003E5__2).FindKernel((string)null) == 0)
							{
								goto IL_03f5;
							}
							goto IL_092f;
						}
					}
				}
				if (~(manager._pauseRefreshing ? 1u : 0u) == 0)
				{
					object obj14 = this + 12;
					obj14 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				manager.GetMissingFacebookInfo();
				return null;
				IL_0774:
				if (~(manager._pauseRefreshing ? 1u : 0u) == 0)
				{
					object obj15 = this + 12;
					obj15 = 0;
					_003C_003E1__state = 3;
					return 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				IEnumerator list3 = manager.RequestFindMatchedPlayers();
				Coroutine coroutine5 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list3);
				throw new ArrayTypeMismatchException();
				IL_03f5:
				bool fetchingNewTournament = manager._fetchingNewTournament;
				_003CisNewTournament_003E5__3 = fetchingNewTournament;
				manager._fetchingNewTournament = false;
				goto IL_0774;
				IL_092f:
				SocialManager socialManager = _003CsocialManager_003E5__2;
				if (!socialManager._consolidatedFriendsCompleted)
				{
					object obj16 = this + 12;
					obj16 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				goto IL_03f5;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CInProcessRefreshTournamentCoroutine_003Ed__81(int _003C_003E1__state)
		{
			if (_003C_003E1__state != 0)
			{
				this._003C_003E1__state = 1;
			}
		}

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

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public Manager _003C_003E4__this;

		public string newTournamentCountry;

		public _003C_003Ec__DisplayClass83_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal unsafe void _003CInProcessFetchNextTournament_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0023: Expected Obj, but got I
			//IL_008c: Expected Obj, but got I4
			//IL_005e: Expected Obj, but got I
			//IL_006e: Expected Obj, but got I
			//IL_00c4: Expected Obj, but got I
			//IL_00d4: Expected Obj, but got I
			//IL_0140: Expected Obj, but got I
			//IL_015d: Expected Obj, but got I4
			//IL_074c: Expected Obj, but got I4
			//IL_076f: Expected Obj, but got I
			//IL_0778: Unknown result type (might be due to invalid IL or missing references)
			//IL_077d: Expected Obj, but got Unknown
			//IL_01f6: Expected Obj, but got I4
			//IL_0219: Expected Obj, but got I
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Expected Obj, but got Unknown
			//IL_0735: Unknown result type (might be due to invalid IL or missing references)
			//IL_073a: Expected Obj, but got Unknown
			//IL_06a2: Expected Obj, but got I4
			//IL_06c5: Expected Obj, but got I
			//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d3: Expected Obj, but got Unknown
			//IL_06e6: Expected Obj, but got I4
			//IL_01a0: Expected Obj, but got I4
			//IL_01c3: Expected Obj, but got I
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_048f: Expected Obj, but got I
			//IL_02d9: Expected Obj, but got I
			//IL_056f: Expected Obj, but got I
			//IL_0333: Expected Obj, but got I
			//IL_0510: Expected Obj, but got I4
			//IL_0533: Expected Obj, but got I
			//IL_053c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Expected Obj, but got Unknown
			//IL_0554: Expected Obj, but got I4
			//IL_0666: Expected Obj, but got I4
			//IL_0412: Expected Obj, but got I4
			//IL_062d: Expected Obj, but got I4
			//IL_05fc: Expected Obj, but got I4
			//IL_03e1: Expected Obj, but got I4
			//IL_03b8: Expected Obj, but got I4
			//IL_05cb: Expected Obj, but got I4
			//IL_038f: Expected Obj, but got I4
			IRequest request2 = default;
			object obj = request2 + 16;
			obj = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager+<>c__DisplayClass83_0)+34]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager+<>c__DisplayClass83_0)+34]");
			object obj4;
			object obj5;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager+<>c__DisplayClass83_0)+34]");
				object obj3 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7+C]");
				obj4 = 0;
				obj5 = obj3;
			}
			else
			{
				obj5 = obj;
				obj4 = 1;
			}
			object obj6 = default;
			object obj26 = default;
			object obj18 = default;
			object obj24 = default;
			for (; obj6 != obj4; obj6 = obj26 + 1)
			{
				object obj7 = obj6 << 2;
				object obj8 = obj5 + obj7;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+10]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+14]");
				IRequest request3 = (IRequest)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20 (Kiloo.Common.HTTP.IRequest)+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20 (Kiloo.Common.HTTP.IRequest)+2A]");
				bool flag = (nint)0 == 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20 (Kiloo.Common.HTTP.IRequest)+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag2 = obj11 == null;
				object obj12 = (flag2 ? 1 : 0) ^ 1;
				IRequest request5;
				IRequest request4;
				if (obj12 != null)
				{
					if (flag)
					{
						request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						request4 = (IRequest)(obj13 + 97173);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v214 @ S3_v15 (Kiloo.Common.HTTP.IRequest) (should have been resolved before IL gen)");
						request5 = (IRequest)97173;
					}
					else
					{
						request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+8]");
						object obj14 = (nint)0 & (nint)0x1FFF;
						request5 = (IRequest)(obj14 + 113696);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v213 @ S4_v6 (Kiloo.Common.HTTP.IRequest) (should have been resolved before IL gen)");
						request4 = request3;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20 (Kiloo.Common.HTTP.IRequest)+28]");
				bool flag3 = (nint)0 != -1;
				if (!flag)
				{
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+10]");
						bool flag4;
						if ((nint)0 != 0)
						{
							object obj15 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v119+9C]");
							object obj16 = (nint)0 & (nint)0x100;
							flag4 = obj16 != null;
						}
						else
						{
							flag4 = false;
						}
						if (!flag4 && newTournamentCountry != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20 (Kiloo.Common.HTTP.IRequest)+2B]");
							object obj17 = (nint)0 & (nint)3;
							bool flag5 = (nint)obj17 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag5)
							{
								if (obj18 != null)
								{
									request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E01");
								}
								else
								{
									request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E02");
								}
							}
							else if (obj18 != null)
							{
								request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E03");
								request4 = request2;
							}
							else
							{
								request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E04");
							}
							continue;
						}
					}
					request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+8]");
					object obj19 = (nint)0 & (nint)0x3FFF;
					request4 = (IRequest)(obj19 + 97173);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v214 @ S3_v15 (Kiloo.Common.HTTP.IRequest) (should have been resolved before IL gen)");
					request5 = (IRequest)97173;
					continue;
				}
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+10]");
					bool flag6;
					if ((nint)0 != 0)
					{
						object obj20 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v80+9C]");
						object obj21 = (nint)0 & (nint)0x100;
						flag6 = obj21 != null;
					}
					else
					{
						flag6 = false;
					}
					if (!flag6 && newTournamentCountry != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+10]");
						if ((nint)0 == 0)
						{
							request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+8]");
							object obj22 = (nint)0 & (nint)0x3FFF;
							request4 = (IRequest)(obj22 + 97173);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v214 @ S3_v15 (Kiloo.Common.HTTP.IRequest) (should have been resolved before IL gen)");
							request5 = (IRequest)97173;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20 (Kiloo.Common.HTTP.IRequest)+2B]");
						object obj23 = (nint)0 & (nint)3;
						bool flag7 = (nint)obj23 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag7)
						{
							if (obj24 != null)
							{
								request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E05");
								request4 = request2;
							}
							else
							{
								request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E06");
								request4 = request2;
							}
						}
						else if (obj24 != null)
						{
							request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E07");
							request5 = request2;
							request4 = request;
						}
						else
						{
							request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E08");
							request4 = request2;
						}
						continue;
					}
				}
				request2 = (IRequest)((bool*)(isFromCache ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isFromCache @ L2 (System.Boolean)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v15+8]");
				object obj25 = (nint)0 & (nint)0x1FFF;
				request5 = (IRequest)(obj25 + 113696);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v213 @ S4_v6 (Kiloo.Common.HTTP.IRequest) (should have been resolved before IL gen)");
				request4 = request3;
			}
		}
	}

	private sealed class _003CRequestPlayersByFacebookIds_003Ed__86(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private IRequest _003Crequest_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_1334: Unknown result type (might be due to invalid IL or missing references)
				//IL_1339: Expected Obj, but got Unknown
				//IL_1342: Unknown result type (might be due to invalid IL or missing references)
				//IL_1347: Expected Obj, but got Unknown
				//IL_1350: Unknown result type (might be due to invalid IL or missing references)
				//IL_1355: Expected I, but got Unknown
				//IL_135e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1363: Expected Obj, but got Unknown
				//IL_136c: Unknown result type (might be due to invalid IL or missing references)
				//IL_1371: Expected I, but got Unknown
				//IL_1383: Unknown result type (might be due to invalid IL or missing references)
				//IL_1388: Expected Obj, but got Unknown
				//IL_1391: Expected Obj, but got I4
				//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_13a5: Expected Ref, but got Unknown
				//IL_13b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_13bc: Expected Ref, but got Unknown
				//IL_13ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_13d3: Expected Obj, but got Unknown
				//IL_0050: Expected I, but got Obj
				//IL_0066: Expected Obj, but got I
				//IL_00de: Expected I, but got Obj
				//IL_00f4: Expected Obj, but got I
				//IL_0091: Expected I, but got Obj
				//IL_1440: Expected Obj, but got VT
				//IL_145a: Expected Obj, but got I8
				//IL_011f: Expected I, but got Obj
				//IL_1068: Expected I, but got Obj
				//IL_107e: Expected Obj, but got I
				//IL_1643: Expected Obj, but got I4
				//IL_1666: Unknown result type (might be due to invalid IL or missing references)
				//IL_166b: Expected Obj, but got Unknown
				//IL_1674: Expected Obj, but got I4
				//IL_10a9: Expected I, but got Obj
				//IL_10fe: Expected Obj, but got I
				//IL_1124: Expected Obj, but got I4
				//IL_1131: Unknown result type (might be due to invalid IL or missing references)
				//IL_1136: Expected Obj, but got Unknown
				//IL_113f: Expected Obj, but got I4
				//IL_1499: Unknown result type (might be due to invalid IL or missing references)
				//IL_149e: Expected Obj, but got Unknown
				//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_14ac: Expected Obj, but got Unknown
				//IL_14d8: Expected Obj, but got I4
				//IL_14e1: Expected Obj, but got I4
				//IL_022b: Expected I, but got Obj
				//IL_0241: Expected Obj, but got I
				//IL_114d: Unknown result type (might be due to invalid IL or missing references)
				//IL_1152: Expected Obj, but got Unknown
				//IL_1687: Unknown result type (might be due to invalid IL or missing references)
				//IL_168c: Expected Obj, but got Unknown
				//IL_16e3: Expected Obj, but got I
				//IL_16f3: Expected Obj, but got I
				//IL_1704: Unknown result type (might be due to invalid IL or missing references)
				//IL_1709: Expected Obj, but got Unknown
				//IL_1712: Unknown result type (might be due to invalid IL or missing references)
				//IL_1717: Expected Obj, but got Unknown
				//IL_1737: Expected Obj, but got I
				//IL_1747: Expected Obj, but got I
				//IL_1757: Expected Obj, but got I
				//IL_1760: Unknown result type (might be due to invalid IL or missing references)
				//IL_1765: Expected Obj, but got Unknown
				//IL_176e: Unknown result type (might be due to invalid IL or missing references)
				//IL_1773: Expected Obj, but got Unknown
				//IL_03df: Expected Obj, but got I
				//IL_02c6: Expected Obj, but got I
				//IL_02c6: Expected Obj, but got I4
				//IL_026c: Expected I, but got Obj
				//IL_11b3: Expected Obj, but got I
				//IL_11d1: Expected Obj, but got I
				//IL_11d1: Expected Obj, but got I4
				//IL_04a4: Expected I, but got Obj
				//IL_04ba: Expected Obj, but got I
				//IL_150f: Unknown result type (might be due to invalid IL or missing references)
				//IL_1514: Expected Obj, but got Unknown
				//IL_0415: Unknown result type (might be due to invalid IL or missing references)
				//IL_041a: Expected Obj, but got Unknown
				//IL_0531: Expected Obj, but got I4
				//IL_04e5: Expected I, but got Obj
				//IL_02f4: Expected Obj, but got I
				//IL_044b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0450: Expected Obj, but got Unknown
				//IL_057d: Expected Obj, but got VT
				//IL_05af: Unknown result type (might be due to invalid IL or missing references)
				//IL_05b4: Expected Obj, but got Unknown
				//IL_05c4: Expected VT, but got Obj
				//IL_05e4: Expected Obj, but got I4
				//IL_16a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_16ae: Expected Obj, but got Unknown
				//IL_16be: Expected Obj, but got I
				//IL_1285: Unknown result type (might be due to invalid IL or missing references)
				//IL_128a: Expected Obj, but got Unknown
				//IL_12c7: Expected Obj, but got I
				//IL_12d7: Expected Obj, but got I
				//IL_12f5: Expected Obj, but got I
				//IL_12fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_1303: Expected I, but got Unknown
				object obj2 = default;
				object obj = obj2 + 96;
				string text = (string)(obj2 + 48);
				object obj3 = obj2 + 32;
				nint num = (nint)(obj2 + 24);
				object obj4 = obj2 + 16;
				nint num2 = (nint)(obj2 + 40);
				num2 = 0;
				object obj5 = obj2 + 80;
				obj5 = 0;
				_ = 0;
				ref PlayerIdsData.PlayerIdData reference = ref *(PlayerIdsData.PlayerIdData*)(obj2 + 76);
				reference = ref *(PlayerIdsData.PlayerIdData*)null;
				ref Player reference2 = ref *(Player*)(obj2 + 72);
				reference2 = ref *(Player*)null;
				object obj6 = obj2 - -64;
				obj6 = obj;
				_ = -1;
				Manager manager = _003C_003E4__this;
				object result;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						X509Certificate2 x509Certificate = default;
						if (x509Certificate != null)
						{
							bool flag = TrustedRoots.VerifyTrust(x509Certificate);
						}
						else
						{
							bool flag = false;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj7 = default;
						if (obj7 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							IResponse response = default;
							if (ResponseExtensions.IsBson(response))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
								object obj8 = default;
								object obj9 = default;
								bool flag2 = obj8 != obj9;
								object obj11 = default;
								object obj10 = obj11;
								if (!flag2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
									object obj13 = default;
									object obj12 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
									object obj14 = default;
									obj10 = obj14;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
								return null;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						int totalLength = default;
						string msg = string.ConcatArray((string[])(object)"LookupFriendPublicKeys: Request failed or bad response, status: ", totalLength);
						LogWarning(msg);
						nint num3 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v203 (Il2CppClass<SocialManager>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num4 = (nint)typeof(SocialManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v260 (Il2CppClass<SocialManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
						if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S0_v208 (System.Boolean)+70]");
							object obj16 = (nint)0 & (nint)1;
							if (obj16 != null)
							{
								Friend[] array = ((SocialManager)facebookDialogsSupported).FriendsSortedByCash();
								object obj17 = array + 12;
								object obj18 = 0;
								object obj25 = default;
								while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
								{
									object obj19 = array + 16;
									object obj20 = obj18 << 2;
									object obj21 = obj19 + obj20;
									object obj22 = obj21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v227+20]");
									if ((nint)0 != 0)
									{
										string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v227+20]");
										object obj23 = 0;
										int stringLength = lastTopRunResultAwardedID.m_stringLength;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ S1_v145+8]");
										if (((Dictionary<string, PlayerIdsData.PlayerIdData>)stringLength).TryGetValue((string)0, out reference))
										{
											PlayerIdsData.PlayerIdData playerIdData = reference;
											if (playerIdData.publicKey != null)
											{
												PlayerIdsData.PlayerIdData playerIdData2 = reference;
												bool flag3 = manager._currentTournamentPlayers.TryGetValue(playerIdData2.publicKey, out reference2);
												if (reference2 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
													object obj24 = obj25 + 8;
													PlayerIdsData.PlayerIdData playerIdData3 = reference;
													obj24 = playerIdData3.publicKey;
													reference2 = ref *(Player*)obj25;
													PlayerIdsData.PlayerIdData playerIdData4 = reference;
													nint num5 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ S4_v23 (Il2CppMethodInfo)+C]");
													object obj26 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ S4_v24+60]");
													object obj27 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ S4_v25+48]");
													nint num6 = 0;
													object obj28 = num6 & 0x7FF;
													nint num7 = (nint)(obj28 + 39195);
													Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v635 @ S5_v17 (Il2CppMethodInfo) (should have been resolved before IL gen)");
												}
												_ = 1;
												object obj29 = reference2 + 20;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v227+20]");
												obj29 = 0;
											}
										}
									}
									object obj30 = obj18 + 1;
									obj18 = obj30;
								}
							}
						}
						object obj31 = this + 20;
						obj31 = 0;
						result = null;
					}
					else
					{
						result = null;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					nint num8 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v43 (Il2CppClass<Info.OnlineSettings>)+BA]");
					object obj32 = (nint)0 & (nint)0x200;
					if (obj32 != null)
					{
						nint num9 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v190 (Il2CppClass<Info.OnlineSettings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string saveDataPath = OnlineSettings.GetSaveDataPath();
					uint value = ((OnlineSettings)(object)saveDataPath).GetValue("toprun_friends_refresh_interval", 1800u);
					DateTime today = CDateTime.Today;
					nint num10 = (nint)typeof(TimeUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v53 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
					object obj33 = (nint)0 & (nint)0x200;
					if (obj33 != null)
					{
						nint num11 = (nint)typeof(TimeUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v186 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj3 = today;
					text = (string)obj3;
					object obj34 = (int)value + manager._lastFriendsUpdate;
					long num12 = TimeUtility.RFC1123StringToUnixTime(text);
					bool flag4 = (long)obj34 >= num12;
					result = null;
					if (!flag4)
					{
						IList<Player> facebookFriendsWithPublicKeysAsPlayers = manager.GetFacebookFriendsWithPublicKeysAsPlayers();
						bool flag5 = facebookFriendsWithPublicKeysAsPlayers == null;
						result = null;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							object obj35 = default;
							bool flag6 = (nint)obj35 <= 0;
							result = null;
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								List<object> list = default;
								int capacity = default;
								list._002Ector(capacity);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								object obj36 = default;
								IFormatProvider provider = default;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									if (obj36 == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									nint num13 = (nint)typeof(CultureInfo);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ S0_v152 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
									object obj37 = (nint)0 & (nint)0x200;
									if (obj37 != null)
									{
										nint num14 = (nint)typeof(CultureInfo);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ S0_v179 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ S0_v149+8]");
									string text2 = ((JsonObject)830).Get<string>((string)0, null, provider);
									if (text2 != null)
									{
										text = (string)num2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
									}
								}
								object obj38 = obj6 + 4;
								object obj39 = obj38 + 1;
								obj38 = obj39;
								object obj40 = obj39 << 2;
								object obj41 = obj6 + obj40;
								obj41 = 185;
								object obj42 = 0;
								object obj43 = default;
								if (obj43 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+4]");
								if ((nint)0 != -1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+4]");
									object obj44 = (nint)0 << 2;
									object obj45 = obj6 + obj44;
									if ((nint)obj45 == 185)
									{
										object obj46 = obj6 + 4;
										if ((nint)obj46 > -1)
										{
											object obj47 = obj46 + -1;
											obj46 = obj47;
										}
										goto IL_16c3;
									}
								}
								if (obj42 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
								}
								goto IL_16c3;
							}
						}
					}
				}
				goto IL_148b;
				IL_148b:
				return result;
				IL_16c3:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S3_v10 (Il2CppMethodInfo)+C]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ S3_v11+60]");
				object obj49 = 0;
				object obj50 = obj49;
				object obj51 = obj50 & 0x1FFF;
				object obj52 = obj51 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v950 @ S4_v8 (should have been resolved before IL gen)");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ S4_v10 (Il2CppMethodInfo)+C]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ S4_v11+60]");
				object obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v959 @ S4_v12+48]");
				object obj55 = 0;
				object obj56 = obj55 & 0x7FF;
				object obj57 = obj56 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v137 @ S5_v10 (should have been resolved before IL gen)");
				string otherUri = ((Manager)null).FindFacebookIdFromPublicKey("/facebook/getplayersbyfacebookids");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Uri uri = default;
				uri.CreateThisFromUri((Uri)(object)otherUri);
				nint num17 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ S0_v93 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
				object obj58 = (nint)0 & (nint)0x200;
				if (obj58 != null)
				{
					nint num18 = (nint)typeof(KilooWebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ S0_v108 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj59 = this + 20;
				IRequest request = KilooWebClient.CreateGet(uri);
				string adSpace = default;
				bool flag7 = ((FlurryVideoAdsAndroid)request).IsReady(adSpace);
				float requestMinBackOffTime = ((Manager)null).requestMinBackOffTime;
				IRequest request2 = RequestExtensions.WithKeepAlive((IRequest)flag7, requestMinBackOffTime);
				float requestMaxBackOffTime = ((Manager)null).requestMaxBackOffTime;
				IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, requestMaxBackOffTime);
				float awardsPercentageComplete = ((AwardsManager)null).GetAwardsPercentageComplete();
				Wait.Config.TimeConfig timeConfig = ((Wait.Config)request3).For(awardsPercentageComplete);
				obj59 = timeConfig;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				text = (string)obj5;
				string text3 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+8]");
				text3.m_stringLength = 0;
				object obj60 = this + 12;
				Coroutine coroutine = WebClient.RequestAsync(_003Crequest_003E5__2, null, (WebClient.SendOptions)text);
				obj60 = coroutine;
				_003C_003E1__state = 1;
				result = 1;
				goto IL_148b;
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ParticipantSelector _003C_003E9__91_0;

		public static ParticipantSetter _003C_003E9__91_1;

		public static TimestampSetter _003C_003E9__91_2;

		public static ParticipantSelector _003C_003E9__93_0;

		public static ParticipantSetter _003C_003E9__93_1;

		public static TimestampSetter _003C_003E9__93_2;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CelebrationReward._003C_003Ec obj = default;
			CelebrationReward._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal IList _003CRequestFindMatchedPlayers_003Eb__91_0(TournamentData tour)
		{
			//IL_0015: Expected Obj, but got I
			//IL_0032: Expected Obj, but got I
			//IL_0032: Expected Obj, but got I
			//IL_0036: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tour @ L1 (TopRun.Internal.TournamentData)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager+<>c)+8]");
			return (IList)((string)num != (string)0);
		}

		internal void _003CRequestFindMatchedPlayers_003Eb__91_1(TournamentData tour, IList list)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_041f: Expected Obj, but got I
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			X509Certificate2 x509Certificate = default;
			bool flag = x509Certificate != null;
			if (flag)
			{
				bool flag2 = TrustedRoots.VerifyTrust(x509Certificate);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj4 = default;
				object obj3 = flag & obj4;
				if (obj3 != null && ResponseExtensions.IsBson((IResponse)x509Certificate))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj5 = default;
					object obj6 = default;
					if (obj5 == obj6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj8 = default;
						object obj7 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj10 = default;
						object obj9 = obj10;
					}
					else
					{
						object obj11 = default;
						object obj9 = obj11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int totalLength = default;
			string msg = string.ConcatArray((string[])(object)"FetchNextTournament: Request failed or bad response, status: ", totalLength);
			LogWarning(msg);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager+<>c)+8]");
			((Player)0).publicKey = null;
		}

		internal void _003CRequestFindMatchedPlayers_003Eb__91_2(TournamentData tour, DateTime? timestamp)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Expected Obj, but got VT
			object obj = tour + 16;
			obj = timestamp;
		}

		internal IList _003CRequestFindMatchedPlayersByCurrentScore_003Eb__93_0(TournamentData tour)
		{
			return tour.participants;
		}

		internal void _003CRequestFindMatchedPlayersByCurrentScore_003Eb__93_1(TournamentData tour, IList list)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [list @ L2 (System.Collections.IList)+8]");
			_ = 0;
			object obj = tour + 24;
			obj = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}

		internal void _003CRequestFindMatchedPlayersByCurrentScore_003Eb__93_2(TournamentData tour, DateTime? timestamp)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0016: Expected Obj, but got VT
			object obj = tour + 20;
			obj = timestamp;
		}
	}

	private sealed class _003CRequestFindMatchedPlayers_003Ed__91(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private IRequest _003Crequest_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a85: Expected VT, but got Unknown
				//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a93: Expected Obj, but got Unknown
				//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0aa1: Expected Obj, but got Unknown
				//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0aaf: Expected Obj, but got Unknown
				//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0abd: Expected Obj, but got Unknown
				//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0acb: Expected Obj, but got Unknown
				//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ad9: Expected Obj, but got Unknown
				//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ae7: Expected Obj, but got Unknown
				//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0af5: Expected Obj, but got Unknown
				//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b03: Expected Obj, but got Unknown
				//IL_0b0c: Expected Obj, but got I4
				//IL_0058: Expected I, but got Obj
				//IL_006e: Expected Obj, but got I
				//IL_0f84: Expected I, but got Obj
				//IL_0f9a: Expected Obj, but got I
				//IL_0099: Expected I, but got Obj
				//IL_075c: Expected I, but got Obj
				//IL_0772: Expected Obj, but got I
				//IL_0b72: Expected Obj, but got VT
				//IL_0b7a: Expected Obj, but got VT
				//IL_0b8f: Expected I4, but got Obj
				//IL_0b8a: Expected native int or pointer, but got VT
				//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ba1: Expected Obj, but got Unknown
				//IL_0bb8: Expected Obj, but got I8
				//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Expected Obj, but got Unknown
				//IL_0dab: Expected VT, but got Obj
				//IL_0fc5: Expected I, but got Obj
				//IL_0fdb: Expected Obj, but got I
				//IL_0154: Expected I, but got Obj
				//IL_1033: Expected I, but got Obj
				//IL_1049: Expected Obj, but got I
				//IL_079d: Expected I, but got Obj
				//IL_111e: Expected I, but got Obj
				//IL_1134: Expected Obj, but got I
				//IL_0127: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Expected VT, but got Unknown
				//IL_0135: Expected Ref, but got VT
				//IL_0e4d: Expected VT, but got Obj
				//IL_07ea: Expected I, but got Obj
				//IL_0800: Expected Obj, but got I
				//IL_0c05: Expected I, but got Obj
				//IL_0c1b: Expected Obj, but got I
				//IL_026a: Expected I, but got Obj
				//IL_01dc: Expected I, but got Obj
				//IL_01f2: Expected Obj, but got I
				//IL_1074: Expected I, but got Obj
				//IL_108a: Expected Obj, but got I
				//IL_0878: Expected I, but got Obj
				//IL_0dd6: Expected F4, but got I
				//IL_0dd1: Expected native int or pointer, but got VT
				//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0de7: Expected Obj, but got Unknown
				//IL_0dfe: Expected I, but got Obj
				//IL_0e14: Expected Obj, but got I
				//IL_0e1c: Expected Obj, but got VT
				//IL_0c40: Expected Obj, but got VT
				//IL_0c5d: Expected I4, but got Obj
				//IL_0c58: Expected native int or pointer, but got VT
				//IL_0c77: Expected Obj, but got VT
				//IL_0c8c: Expected I4, but got Obj
				//IL_0c87: Expected native int or pointer, but got VT
				//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c9e: Expected Obj, but got Unknown
				//IL_0cb5: Expected Obj, but got I8
				//IL_02b7: Expected I, but got Obj
				//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bf: Expected Obj, but got Unknown
				//IL_08c5: Expected I, but got Obj
				//IL_08db: Expected Obj, but got I
				//IL_082b: Expected I, but got Obj
				//IL_0304: Expected I, but got Obj
				//IL_021d: Expected I, but got Obj
				//IL_0953: Expected I, but got Obj
				//IL_0e78: Expected F4, but got I
				//IL_0e73: Expected native int or pointer, but got VT
				//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e89: Expected Obj, but got Unknown
				//IL_0ea0: Expected I, but got Obj
				//IL_0eb6: Expected Obj, but got I
				//IL_0ebe: Expected Obj, but got VT
				//IL_0351: Expected I, but got Obj
				//IL_0367: Expected Obj, but got I
				//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a5a: Expected Obj, but got Unknown
				//IL_0a63: Expected Obj, but got I4
				//IL_09a0: Expected I, but got Obj
				//IL_09b6: Expected Obj, but got I
				//IL_0906: Expected I, but got Obj
				//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f2b: Expected Obj, but got Unknown
				//IL_0f42: Expected I, but got Obj
				//IL_0f58: Expected Obj, but got I
				//IL_0392: Expected I, but got Obj
				//IL_09e1: Expected I, but got Obj
				//IL_040d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0412: Expected I4, but got Unknown
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 56);
				object obj2 = obj + 48;
				object obj3 = obj + 40;
				object obj4 = obj + 32;
				object obj5 = obj + 24;
				object obj6 = obj + 16;
				object obj7 = obj + 8;
				object obj8 = obj + 76;
				object obj9 = obj + 72;
				object obj10 = obj + 80;
				obj10 = 0;
				_ = 0;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v223 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num2 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v348 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = _003C_003Ec._003C_003E9__91_0 == null;
						bool flag2 = !flag;
						Vector3 pos = (Vector3)_003C_003Ec._003C_003E9__91_0;
						if (!flag2)
						{
							nint num3 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v325 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
							object obj12 = (nint)0 & (nint)0x200;
							if (obj12 != null)
							{
								nint num4 = (nint)typeof(_003C_003Ec);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v342 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num5 = 0;
							Vector3 vector = default;
							((Vector3*)(nint)vector)->z = num5;
							_ = 0;
							object obj13 = vector + 16;
							obj13 = _003C_003Ec._003C_003E9;
							nint num6 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v339 (Il2CppClass<TopRun.Internal.Manager+<>c>)+5C]");
							object obj14 = (nint)0 + (nint)4;
							obj14 = vector;
							pos = vector;
						}
						nint num7 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v233 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num8 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v318 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag3 = _003C_003Ec._003C_003E9__91_1 == null;
						bool flag4 = !flag3;
						Quaternion rot = (Quaternion)_003C_003Ec._003C_003E9__91_1;
						if (!flag4)
						{
							nint num9 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v295 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
							object obj16 = (nint)0 & (nint)0x200;
							if (obj16 != null)
							{
								nint num10 = (nint)typeof(_003C_003Ec);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S0_v312 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num11 = 0;
							Quaternion quaternion = default;
							((Quaternion*)(nint)quaternion)->z = num11;
							_ = 0;
							object obj17 = quaternion + 16;
							obj17 = _003C_003Ec._003C_003E9;
							nint num12 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v309 (Il2CppClass<TopRun.Internal.Manager+<>c>)+5C]");
							object obj18 = (nint)0 + (nint)8;
							obj18 = quaternion;
							rot = quaternion;
						}
						nint num13 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v243 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num14 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S0_v288 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag5 = _003C_003Ec._003C_003E9__91_2 == null;
						bool flag6 = !flag5;
						Transform parent = (Transform)(object)_003C_003Ec._003C_003E9__91_2;
						if (!flag6)
						{
							nint num15 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v265 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
							object obj20 = (nint)0 & (nint)0x200;
							if (obj20 != null)
							{
								nint num16 = (nint)typeof(_003C_003Ec);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S0_v282 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint cachedPtr = 0;
							Transform transform = default;
							((UnityEngine.Object)transform).m_CachedPtr = cachedPtr;
							_ = 0;
							object obj21 = transform + 16;
							obj21 = _003C_003Ec._003C_003E9;
							nint num17 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S0_v279 (Il2CppClass<TopRun.Internal.Manager+<>c>)+5C]");
							object obj22 = (nint)0 + (nint)12;
							obj22 = transform;
							parent = transform;
						}
						Transform transform2 = ((SpawnPool)(object)_003C_003E4__this).Spawn((Transform)_003Crequest_003E5__2, pos, rot, parent);
						if ((object)transform2 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							int totalLength = default;
							string msg = string.ConcatArray((string[])(object)"RequestFindMatchedPlayers: Request failed or bad response, status: ", totalLength);
							LogWarning(msg);
						}
						object obj23 = this + 20;
						obj23 = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				RanksData ranksData = TopRunSave.ranksData;
				Dictionary<string, Rank> ranks = ranksData.ranks;
				nint num18 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v39 (Il2CppClass<System.DateTime>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num19 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v213 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag7 = ranksData.ranks != null;
				bool flag8 = !flag7;
				DateTime dateTime = DateTime.MinValue;
				if (!flag8)
				{
					object obj25 = ranksData.ranks + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v208+8]");
					bool flag9 = (nint)0 == 0;
					dateTime = DateTime.MinValue;
					if (!flag9)
					{
						DateTime? dateTime2 = (DateTime?)(object)(ranksData.ranks + 24);
						DateTime value = ((DateTime?*)dateTime2)->Value;
						dateTime = value;
					}
				}
				DateTime today = CDateTime.Today;
				nint num20 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v52 (Il2CppClass<System.DateTime>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num21 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v201 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = dateTime;
				obj4 = today;
				obj2 = obj3;
				((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj4 != 0;
				object obj27 = obj2 & 0x3FFFFFFFFFFFFFFFL;
				object obj28 = (sendOptions.disableCache ? 1 : 0) & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28))
				{
					if (flag7)
					{
						object obj29 = ranksData.ranks + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					}
					nint num22 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v186 (Il2CppClass<System.DateTime>)+BA]");
					object obj30 = (nint)0 & (nint)0x200;
					if (obj30 != null)
					{
						nint num23 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ S0_v193 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					dateTime = DateTime.MinValue;
				}
				nint num24 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v66 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj31 = (nint)0 & (nint)0x200;
				if (obj31 != null)
				{
					nint num25 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v179 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath = OnlineSettings.GetSaveDataPath();
				uint value2 = ((OnlineSettings)(object)saveDataPath).GetValue("toprun_stranger_amount_retry_interval", 3600u);
				nint num26 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ S1_v37 (Il2CppClass<System.TimeSpan>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num27 = (nint)typeof(TimeSpan);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S1_v117 (Il2CppClass<System.TimeSpan>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
				nint num28 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ S0_v75 (Il2CppClass<System.DateTime>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num29 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v175 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj5 = dateTime;
				object obj34 = default;
				obj6 = obj34;
				obj2 = obj5;
				((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj6 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
				object obj35 = default;
				obj7 = obj35;
				obj = today;
				obj2 = obj7;
				((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
				object obj36 = obj2 & 0x3FFFFFFFFFFFFFFFL;
				object obj37 = (sendOptions.disableCache ? 1 : 0) & 0x3FFFFFFFFFFFFFFFL;
				uint num32;
				int[] array;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37))
				{
					nint num30 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S0_v157 (Il2CppClass<Info.OnlineSettings>)+BA]");
					object obj38 = (nint)0 & (nint)0x200;
					if (obj38 != null)
					{
						nint num31 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S0_v171 (Il2CppClass<Info.OnlineSettings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string saveDataPath2 = OnlineSettings.GetSaveDataPath();
					uint value3 = ((OnlineSettings)(object)saveDataPath2).GetValue("toprun_stranger_amount", 10u);
					if (!flag7)
					{
						num32 = value3;
						array = null;
						goto IL_0ff8;
					}
					bool flag10 = ranks.count == 0;
					num32 = value3;
					if (!flag10)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj39 = default;
						uint num33 = (uint)(int)(value3 - obj39);
						num32 = num33;
					}
				}
				else
				{
					if (!flag7)
					{
						return null;
					}
					num32 = 0u;
				}
				array = ranks.buckets;
				goto IL_0ff8;
				IL_0ff8:
				if ((int)num32 > 0)
				{
					bool flag11;
					if (array != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v91 (System.Int32[])+8]");
						flag11 = (nint)0 == 0;
					}
					else
					{
						flag11 = true;
					}
					if (flag11)
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					string text = ((Manager)null).FindFacebookIdFromPublicKey("/tournaments/findmatchedplayers");
					throw new ArrayTypeMismatchException();
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

	private sealed class _003CRequestFindMatchedPlayersByCurrentScore_003Ed__93(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private IRequest _003Crequest_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_06e8: Expected VT, but got Unknown
				//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_06f6: Expected Obj, but got Unknown
				//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0704: Expected Obj, but got Unknown
				//IL_070d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0712: Expected Obj, but got Unknown
				//IL_071b: Expected Obj, but got I4
				//IL_03bf: Expected I, but got Obj
				//IL_03d5: Expected Obj, but got I
				//IL_07ca: Expected VT, but got Obj
				//IL_099a: Expected I, but got Obj
				//IL_09b0: Expected Obj, but got I
				//IL_0400: Expected I, but got Obj
				//IL_086c: Expected VT, but got Obj
				//IL_044d: Expected I, but got Obj
				//IL_0463: Expected Obj, but got I
				//IL_09db: Expected I, but got Obj
				//IL_09f1: Expected Obj, but got I
				//IL_04db: Expected I, but got Obj
				//IL_07f5: Expected F4, but got I
				//IL_07f0: Expected native int or pointer, but got VT
				//IL_0801: Unknown result type (might be due to invalid IL or missing references)
				//IL_0806: Expected Obj, but got Unknown
				//IL_081d: Expected I, but got Obj
				//IL_0833: Expected Obj, but got I
				//IL_083b: Expected Obj, but got VT
				//IL_0528: Expected I, but got Obj
				//IL_053e: Expected Obj, but got I
				//IL_048e: Expected I, but got Obj
				//IL_05b6: Expected I, but got Obj
				//IL_0897: Expected F4, but got I
				//IL_0892: Expected native int or pointer, but got VT
				//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_08a8: Expected Obj, but got Unknown
				//IL_08bf: Expected I, but got Obj
				//IL_08d5: Expected Obj, but got I
				//IL_08dd: Expected Obj, but got VT
				//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_06bd: Expected Obj, but got Unknown
				//IL_06c6: Expected Obj, but got I4
				//IL_0603: Expected I, but got Obj
				//IL_0619: Expected Obj, but got I
				//IL_0569: Expected I, but got Obj
				//IL_0945: Unknown result type (might be due to invalid IL or missing references)
				//IL_094a: Expected Obj, but got Unknown
				//IL_0961: Expected I, but got Obj
				//IL_0977: Expected Obj, but got I
				//IL_0644: Expected I, but got Obj
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 32);
				object obj2 = obj + 8;
				object obj3 = obj + 4;
				object obj4 = obj + 16;
				obj4 = 0;
				_ = 0;
				object result;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v93 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num2 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v218 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = _003C_003Ec._003C_003E9__93_0 == null;
						bool flag2 = !flag;
						Vector3 pos = (Vector3)_003C_003Ec._003C_003E9__93_0;
						if (!flag2)
						{
							nint num3 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v195 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num4 = (nint)typeof(_003C_003Ec);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v212 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num5 = 0;
							Vector3 vector = default;
							((Vector3*)(nint)vector)->z = num5;
							_ = 0;
							object obj7 = vector + 16;
							obj7 = _003C_003Ec._003C_003E9;
							nint num6 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v209 (Il2CppClass<TopRun.Internal.Manager+<>c>)+5C]");
							object obj8 = (nint)0 + (nint)16;
							obj8 = vector;
							pos = vector;
						}
						nint num7 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v103 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
						object obj9 = (nint)0 & (nint)0x200;
						if (obj9 != null)
						{
							nint num8 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v188 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag3 = _003C_003Ec._003C_003E9__93_1 == null;
						bool flag4 = !flag3;
						Quaternion rot = (Quaternion)_003C_003Ec._003C_003E9__93_1;
						if (!flag4)
						{
							nint num9 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v165 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
							object obj10 = (nint)0 & (nint)0x200;
							if (obj10 != null)
							{
								nint num10 = (nint)typeof(_003C_003Ec);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v182 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num11 = 0;
							Quaternion quaternion = default;
							((Quaternion*)(nint)quaternion)->z = num11;
							_ = 0;
							object obj11 = quaternion + 16;
							obj11 = _003C_003Ec._003C_003E9;
							nint num12 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v179 (Il2CppClass<TopRun.Internal.Manager+<>c>)+5C]");
							object obj12 = (nint)0 + (nint)20;
							obj12 = quaternion;
							rot = quaternion;
						}
						nint num13 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v113 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num14 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v158 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag5 = _003C_003Ec._003C_003E9__93_2 == null;
						bool flag6 = !flag5;
						Transform parent = (Transform)(object)_003C_003Ec._003C_003E9__93_2;
						if (!flag6)
						{
							nint num15 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S0_v135 (Il2CppClass<TopRun.Internal.Manager+<>c>)+BA]");
							object obj14 = (nint)0 & (nint)0x200;
							if (obj14 != null)
							{
								nint num16 = (nint)typeof(_003C_003Ec);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v152 (Il2CppClass<TopRun.Internal.Manager+<>c>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint cachedPtr = 0;
							Transform transform = default;
							((UnityEngine.Object)transform).m_CachedPtr = cachedPtr;
							_ = 0;
							object obj15 = transform + 16;
							obj15 = _003C_003Ec._003C_003E9;
							nint num17 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S0_v149 (Il2CppClass<TopRun.Internal.Manager+<>c>)+5C]");
							object obj16 = (nint)0 + (nint)24;
							obj16 = transform;
							parent = transform;
						}
						Transform transform2 = ((SpawnPool)(object)_003C_003E4__this).Spawn((Transform)_003Crequest_003E5__2, pos, rot, parent);
						if ((object)transform2 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							int totalLength = default;
							string msg = string.ConcatArray((string[])(object)"RequestFindMatchedPlayersByCurrentScore: Request failed or bad response, status: ", totalLength);
							LogWarning(msg);
						}
						object obj17 = this + 20;
						obj17 = 0;
						result = null;
					}
					else
					{
						result = null;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					RanksData ranksData = TopRunSave.ranksData;
					Dictionary<string, Rank> ranks = ranksData.ranks;
					IEnumerator enumerator = _003C_003E4__this.RequestFindMatchedPlayersByCurrentScore();
					if ((nint)enumerator >= 1)
					{
						if (ranksData.ranks != null)
						{
							bool flag7 = ranks.version == 0;
							IEnumerator enumerator2 = enumerator;
							if (!flag7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								object obj18 = default;
								IEnumerator enumerator3 = (IEnumerator)((object)enumerator - obj18);
								bool flag8 = (nint)enumerator3 <= 0;
								enumerator2 = enumerator3;
								result = null;
								if (flag8)
								{
									goto IL_0745;
								}
							}
							string buckets = (string)(object)ranks.buckets;
						}
						else
						{
							string buckets = string.Empty;
							IEnumerator enumerator2 = enumerator;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						string text = ((Manager)null).FindFacebookIdFromPublicKey("/tournaments/findmatchedplayersbycurrentscore");
						throw new ArrayTypeMismatchException();
					}
					result = null;
				}
				goto IL_0745;
				IL_0745:
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

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public FacebookProfile profile;

		public Player player;

		public Manager _003C_003E4__this;

		public _003C_003Ec__DisplayClass95_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CGetMissingFacebookInfoCoroutine_003Eb__0(Texture2D image)
		{
			profile = (FacebookProfile)(object)image;
		}
	}

	private sealed class _003CGetMissingFacebookInfoCoroutine_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private _003C_003Ec__DisplayClass95_0 _003C_003E8__1;

		private List<Player>.Enumerator _003C_003E7__wrap1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_073a: Unknown result type (might be due to invalid IL or missing references)
				//IL_073f: Expected Obj, but got Unknown
				//IL_0748: Unknown result type (might be due to invalid IL or missing references)
				//IL_074d: Expected I, but got Unknown
				//IL_0755: Expected I, but got Obj
				//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f4: Expected I, but got Unknown
				//IL_00fc: Expected I, but got Obj
				//IL_0120: Expected Obj, but got I4
				//IL_0798: Expected Obj, but got I4
				//IL_0139: Expected Obj, but got I4
				//IL_0147: Expected Obj, but got I4
				//IL_0287: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Expected Obj, but got Unknown
				//IL_0295: Expected Obj, but got I4
				//IL_029e: Expected Obj, but got I4
				//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d6: Expected Obj, but got Unknown
				//IL_07e5: Expected Obj, but got I4
				//IL_016e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0173: Expected Obj, but got Unknown
				//IL_017c: Expected Obj, but got I4
				//IL_0190: Expected Obj, but got I4
				//IL_0199: Expected Obj, but got I4
				//IL_039d: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a2: Expected Obj, but got Unknown
				//IL_0833: Expected Obj, but got I4
				//IL_0375: Unknown result type (might be due to invalid IL or missing references)
				//IL_037a: Expected Obj, but got Unknown
				//IL_0392: Expected Obj, but got I4
				//IL_06e9: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 48;
				object obj3 = obj2 + 24;
				nint num = (nint)(obj2 + 16);
				num = (nint)obj;
				_ = -1;
				Manager manager = _003C_003E4__this;
				object obj4;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -3;
							obj4 = 36;
						}
						else
						{
							obj4 = 45;
						}
					}
					else
					{
						_003C_003E1__state = -3;
						obj4 = 28;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					nint num2 = (nint)(this + 24);
					num2 = (nint)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					_003C_003E1__state = -3;
					obj4 = 37;
				}
				object obj5 = obj4;
				object result = default;
				object obj8 = default;
				object obj9 = default;
				object obj11 = default;
				object obj14 = default;
				object obj18 = default;
				object obj19 = default;
				object obj20 = default;
				while (true)
				{
					if ((nint)obj5 == 28)
					{
						if (~(manager._pauseRefreshing ? 1u : 0u) == 0)
						{
							object obj6 = this + 12;
							obj6 = 0;
							_003C_003E1__state = 1;
							obj5 = 45;
							result = 1;
						}
						else
						{
							_003C_003Ec__DisplayClass95_0 obj7 = _003C_003E8__1;
							FacebookProfile profile = obj7.profile;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							obj5 = 42;
							obj8 = obj9;
							object obj10 = obj11;
						}
					}
					else if ((nint)obj5 == 36)
					{
						object obj12 = this + 20;
						obj12 = 0;
						obj5 = 37;
					}
					else if ((nint)obj5 == 37)
					{
						object obj13 = this + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj15 = this + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							result = null;
							object obj16 = 45;
							obj5 = obj16;
						}
						else
						{
							object obj17 = this + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							obj5 = 42;
							obj8 = obj9;
							object obj10 = obj18;
						}
					}
					else if ((nint)obj5 == 42)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
						if (obj8 != obj19)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						_003C_003Em__Finally1();
						if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
							break;
						}
						obj5 = 45;
						result = null;
					}
					else if ((nint)obj5 == 45)
					{
						return result;
					}
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetMissingFacebookInfoCoroutine_003Ed__95(int _003C_003E1__state)
		{
			//IL_013c: Expected I, but got Obj
			//IL_0152: Expected Obj, but got I
			//IL_01ba: Expected Obj, but got I4
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00bf: Expected I, but got Obj
			//IL_010e: Expected Obj, but got I4
			//IL_0117: Expected Obj, but got I4
			//IL_0128: Expected I4, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = default;
			if (((ComputeShader)num3).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj2 = default;
				if ((nint)obj2 == 8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj3 = default;
					if ((nint)obj3 == 8)
					{
						goto IL_00b1;
					}
				}
			}
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				goto IL_00b1;
			}
			goto IL_01db;
			IL_00b1:
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
			goto IL_01db;
			IL_01db:
			if (((ComputeShader)null).FindKernel((string)null) != 0)
			{
				object obj5 = this._003C_003E1__state + 20;
				obj5 = 0;
				_003C_003E4__this.CompleteRefreshProcess((byte)(int)_003C_003E2__current != 0);
			}
		}

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

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			//IL_00b5: Expected Obj, but got I4
			//IL_004b: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected Obj, but got Unknown
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			if (_003C_003E1__state != -3)
			{
				object obj3 = _003C_003E1__state - 1;
				if ((nint)obj3 >= 2)
				{
					return;
				}
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 28;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 28)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
		}
	}

	private sealed class _003CRequestTournamentData_003Ed__101(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		public Action<bool> onComplete;

		private IRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f3e: Expected Obj, but got Unknown
				//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f4c: Expected Obj, but got Unknown
				//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f5a: Expected Obj, but got Unknown
				//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f68: Expected Obj, but got Unknown
				//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f76: Expected Obj, but got Unknown
				//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f84: Expected Obj, but got Unknown
				//IL_0f8d: Expected Obj, but got I4
				//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fa1: Expected Obj, but got Unknown
				//IL_0faa: Expected Obj, but got I4
				//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fbe: Expected Obj, but got Unknown
				//IL_0fc7: Expected Obj, but got I4
				//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fe1: Expected Obj, but got Unknown
				//IL_0fea: Expected Obj, but got I4
				//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ff8: Expected Obj, but got Unknown
				//IL_1046: Expected I, but got Obj
				//IL_105c: Expected Obj, but got I
				//IL_1081: Expected Obj, but got VT
				//IL_00a4: Expected I, but got Obj
				//IL_1341: Unknown result type (might be due to invalid IL or missing references)
				//IL_1346: Expected Obj, but got Unknown
				//IL_11b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_11b6: Expected Obj, but got Unknown
				//IL_11de: Expected Obj, but got I
				//IL_11ee: Expected Obj, but got I
				//IL_11ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_1204: Expected Obj, but got Unknown
				//IL_120d: Unknown result type (might be due to invalid IL or missing references)
				//IL_1212: Expected Obj, but got Unknown
				//IL_1232: Expected Obj, but got I
				//IL_1242: Expected Obj, but got I
				//IL_1252: Expected Obj, but got I
				//IL_125b: Unknown result type (might be due to invalid IL or missing references)
				//IL_1260: Expected Obj, but got Unknown
				//IL_1269: Unknown result type (might be due to invalid IL or missing references)
				//IL_126e: Expected Obj, but got Unknown
				//IL_128e: Expected Obj, but got I
				//IL_129e: Expected Obj, but got I
				//IL_12ae: Expected Obj, but got I
				//IL_12b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_12bc: Expected Obj, but got Unknown
				//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
				//IL_12ca: Expected Obj, but got Unknown
				//IL_055c: Expected I, but got Obj
				//IL_0572: Expected Obj, but got I
				//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f07: Expected Obj, but got Unknown
				//IL_0f10: Expected Obj, but got I4
				//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_1302: Expected Obj, but got Unknown
				//IL_01f7: Expected I, but got Obj
				//IL_020d: Expected Obj, but got I
				//IL_05e9: Expected Obj, but got I4
				//IL_059d: Expected I, but got Obj
				//IL_0238: Expected I, but got Obj
				//IL_0635: Expected Obj, but got VT
				//IL_10f8: Expected Obj, but got I8
				//IL_0169: Expected I, but got Obj
				//IL_017f: Expected Obj, but got I
				//IL_0667: Unknown result type (might be due to invalid IL or missing references)
				//IL_066c: Expected Obj, but got Unknown
				//IL_067c: Expected VT, but got Obj
				//IL_069c: Expected Obj, but got I4
				//IL_03be: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c3: Expected Obj, but got Unknown
				//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d1: Expected Obj, but got Unknown
				//IL_03fd: Expected Obj, but got I4
				//IL_0406: Expected Obj, but got I4
				//IL_040f: Expected Obj, but got I4
				//IL_0285: Expected I8, but got I4
				//IL_01aa: Expected I, but got Obj
				//IL_0499: Expected Obj, but got I
				//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_04dc: Expected Obj, but got Unknown
				//IL_035f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0364: Expected Obj, but got Unknown
				//IL_036d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0372: Expected Obj, but got Unknown
				//IL_039e: Expected Obj, but got I4
				//IL_03a7: Expected Obj, but got I4
				//IL_03b0: Expected Obj, but got I4
				//IL_050d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0512: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 + 144;
				string text = (string)(obj2 + 48);
				object obj3 = obj2 + 40;
				object obj4 = obj2 + 32;
				object obj5 = obj2 + 24;
				object obj6 = obj2 + 16;
				object obj7 = obj2 + 120;
				obj7 = 0;
				_ = 0;
				object obj8 = obj2 + 104;
				obj8 = 0;
				_ = 0;
				object obj9 = obj2 + 80;
				obj9 = 0;
				_ = 0;
				_ = 0;
				object obj10 = obj2 + 8;
				obj10 = 0;
				object obj11 = obj2 + 72;
				obj11 = obj;
				_ = -1;
				Manager manager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						X509Certificate2 x509Certificate = default;
						bool flag = x509Certificate != null;
						if (flag)
						{
							bool flag2 = TrustedRoots.VerifyTrust(x509Certificate);
						}
						else
						{
							bool flag2 = false;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj13 = default;
						object obj12 = flag & obj13;
						if (obj12 != null && ResponseExtensions.IsBson((IResponse)x509Certificate))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
							object obj15 = default;
							object obj14 = obj15 << 32;
							object obj17 = default;
							object obj16 = obj17 | obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj18 = obj15;
							object obj20 = default;
							object obj19 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
							object obj21 = default;
							if (obj18 == obj21)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
								object obj22 = default;
								string text2 = (string)obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
								object obj23 = default;
								obj19 = obj23;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
							return null;
						}
						bool obj24;
						if (flag)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							object obj25 = default;
							obj24 = (nint)obj25 == 404;
						}
						else
						{
							obj24 = false;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						int totalLength = default;
						string msg = string.ConcatArray((string[])(object)"GetTournamentData: Request failed or bad response, status: ", totalLength);
						LogWarning(msg);
						onComplete(obj24);
						object obj26 = this + 24;
						obj26 = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				RanksData ranksData = TopRunSave.ranksData;
				Dictionary<string, Rank> ranks = ranksData.ranks;
				int[] array = ((ranksData.ranks == null) ? null : ranks.buckets);
				DateTime today = CDateTime.Today;
				nint num = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v52 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					nint num2 = (nint)typeof(TimeUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v233 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = today;
				text = (string)obj3;
				long num3 = TimeUtility.RFC1123StringToUnixTime(text);
				object key;
				uint defaultValue;
				bool flag3;
				if (manager.tournament__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					string text3 = default;
					if ((string)(object)array != text3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj28 = default;
						if (obj28 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							object obj29 = default;
							if (obj29 == null)
							{
								nint num4 = (nint)typeof(OnlineSettings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ S0_v223 (Il2CppClass<Info.OnlineSettings>)+BA]");
								object obj30 = (nint)0 & (nint)0x200;
								if (obj30 != null)
								{
									nint num5 = (nint)typeof(OnlineSettings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ S0_v229 (Il2CppClass<Info.OnlineSettings>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								key = "toprun_refresh_interval_when_result_is_due";
								defaultValue = 30u;
								goto IL_14f2;
							}
						}
						nint num6 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S0_v210 (Il2CppClass<Info.OnlineSettings>)+BA]");
						object obj31 = (nint)0 & (nint)0x200;
						if (obj31 != null)
						{
							nint num7 = (nint)typeof(OnlineSettings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ S0_v216 (Il2CppClass<Info.OnlineSettings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						key = "toprun_refresh_interval";
						defaultValue = 300u;
						goto IL_14f2;
					}
					flag3 = true;
				}
				else
				{
					flag3 = true;
				}
				goto IL_110b;
				IL_110b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<string> list = default;
				IEnumerable<string> collection = default;
				list._002Ector(collection);
				if (!flag3)
				{
					if (manager._lastTournamentUpdateParticipantsPublicKeys != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
						obj7 = text;
						_ = text.m_stringLength;
						object obj32 = default;
						object obj33 = default;
						object obj38;
						object obj39;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if (obj32 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
								if (obj33 == null)
								{
									object obj34 = obj11 + 4;
									object obj35 = obj34 + 1;
									obj34 = obj35;
									object obj36 = obj35 << 2;
									object obj37 = obj11 + obj36;
									obj37 = 296;
									obj38 = 0;
									obj39 = 1;
									break;
								}
								continue;
							}
							object obj40 = obj11 + 4;
							object obj41 = obj40 + 1;
							obj40 = obj41;
							object obj42 = obj41 << 2;
							object obj43 = obj11 + obj42;
							obj43 = 296;
							obj38 = 0;
							obj39 = 0;
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v34+4]");
						if ((nint)0 != -1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v34+4]");
							object obj44 = (nint)0 << 2;
							object obj45 = obj11 + obj44;
							if ((nint)obj45 == 296)
							{
								object obj46 = obj11 + 4;
								if ((nint)obj46 > -1)
								{
									object obj47 = obj46 + -1;
									obj46 = obj47;
								}
								if (obj39 == null)
								{
									goto IL_1181;
								}
								goto IL_119b;
							}
						}
						if (obj38 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
						}
						else if (obj39 != null)
						{
							goto IL_119b;
						}
					}
					goto IL_1181;
				}
				goto IL_119b;
				IL_119b:
				manager._lastTournamentUpdate = num3;
				object obj48 = manager + 40;
				obj48 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ S3_v6 (Il2CppMethodInfo)+C]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ S3_v7+60]");
				object obj50 = 0;
				object obj51 = obj50;
				object obj52 = obj51 & 0x1FFF;
				object obj53 = obj52 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v745 @ S4_v7 (should have been resolved before IL gen)");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ S4_v9 (Il2CppMethodInfo)+C]");
				object obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S4_v10+60]");
				object obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ S4_v11+48]");
				object obj56 = 0;
				object obj57 = obj56 & 0x7FF;
				object obj58 = obj57 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v762 @ S5_v8 (should have been resolved before IL gen)");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ S4_v14 (Il2CppMethodInfo)+C]");
				object obj59 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ S4_v15+60]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ S4_v16+48]");
				object obj61 = 0;
				object obj62 = obj61 & 0x7FF;
				object obj63 = obj62 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v132 @ S5_v12 (should have been resolved before IL gen)");
				string otherUri = ((Manager)null).FindFacebookIdFromPublicKey("/tournaments/gettournamentbyid");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Uri uri = default;
				uri.CreateThisFromUri((Uri)(object)otherUri);
				nint num11 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ S0_v88 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
				object obj64 = (nint)0 & (nint)0x200;
				if (obj64 != null)
				{
					nint num12 = (nint)typeof(KilooWebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ S0_v103 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj65 = this + 24;
				IRequest request = KilooWebClient.CreateGet(uri);
				string adSpace = default;
				bool flag4 = ((FlurryVideoAdsAndroid)request).IsReady(adSpace);
				float requestMinBackOffTime = ((Manager)null).requestMinBackOffTime;
				IRequest request2 = RequestExtensions.WithKeepAlive((IRequest)flag4, requestMinBackOffTime);
				float requestMaxBackOffTime = ((Manager)null).requestMaxBackOffTime;
				IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, requestMaxBackOffTime);
				float awardsPercentageComplete = ((AwardsManager)null).GetAwardsPercentageComplete();
				Wait.Config.TimeConfig timeConfig = ((Wait.Config)request3).For(awardsPercentageComplete);
				obj65 = timeConfig;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				text = (string)obj8;
				string text4 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22+8]");
				text4.m_stringLength = 0;
				object obj66 = this + 12;
				Coroutine coroutine = WebClient.RequestAsync(_003Crequest_003E5__2, null, (WebClient.SendOptions)text);
				obj66 = coroutine;
				_003C_003E1__state = 1;
				return 1;
				IL_14f2:
				string saveDataPath = OnlineSettings.GetSaveDataPath();
				uint value = ((OnlineSettings)(object)saveDataPath).GetValue((string)key, defaultValue);
				if (manager._lastTournamentUpdate > num3)
				{
					manager._lastTournamentUpdate = 0L;
				}
				object obj67 = num3 - manager._lastTournamentUpdate;
				flag3 = (nint)obj67 > (int)value;
				goto IL_110b;
				IL_1181:
				onComplete(obj: false);
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

	private sealed class _003CRequestNextTournamentFetchTime_003Ed__102(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private IRequest _003Crequest_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_000e: Expected Obj, but got Ref
				//IL_076d: Expected VT, but got Ref
				//IL_077b: Expected VT, but got Ref
				//IL_0789: Expected Obj, but got Ref
				//IL_0797: Expected Obj, but got Ref
				//IL_07a5: Expected Obj, but got Ref
				//IL_07b3: Expected Obj, but got Ref
				//IL_07c1: Expected Obj, but got Ref
				//IL_07ca: Expected Obj, but got I4
				//IL_07e7: Expected Obj, but got Ref
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_00e1: Expected I4, but got Obj
				//IL_00e1: Expected Obj, but got I4
				//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_08ce: Expected Obj, but got Unknown
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Expected Obj, but got Unknown
				//IL_018d: Expected VT, but got I4
				//IL_019b: Expected Obj, but got VT
				//IL_01a8: Expected I4, but got Obj
				//IL_01a3: Expected native int or pointer, but got VT
				//IL_01b0: Expected native int or pointer, but got VT
				//IL_073d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0742: Expected Obj, but got Unknown
				//IL_074b: Expected Obj, but got I4
				//IL_01c7: Expected I4, but got VT
				//IL_01c2: Expected native int or pointer, but got VT
				//IL_01dc: Expected Obj, but got I
				//IL_01d7: Expected native int or pointer, but got VT
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Expected Obj, but got Unknown
				//IL_01f7: Expected Obj, but got I4
				//IL_0291: Expected I, but got Obj
				//IL_02a7: Expected Obj, but got I
				//IL_0876: Expected Obj, but got I4
				//IL_0876: Expected Obj, but got I4
				//IL_02d2: Expected I, but got Obj
				//IL_033b: Expected I, but got Obj
				//IL_0351: Expected Obj, but got I
				//IL_0885: Unknown result type (might be due to invalid IL or missing references)
				//IL_088a: Expected Obj, but got Unknown
				//IL_037c: Expected I, but got Obj
				//IL_0403: Expected Obj, but got VT
				//IL_041a: Expected I4, but got Obj
				//IL_0415: Expected native int or pointer, but got VT
				//IL_042f: Expected Obj, but got I
				//IL_042a: Expected native int or pointer, but got VT
				//IL_0435: Unknown result type (might be due to invalid IL or missing references)
				//IL_043a: Expected Obj, but got Unknown
				//IL_046f: Expected Obj, but got I4
				ref _0021_00210 reference = default;
				object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 96));
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 56));
				DateTime? dateTime = (DateTime?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 40));
				object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32));
				object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 24));
				object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
				object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 8));
				object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 80));
				obj6 = 0;
				_ = 0;
				object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref *(byte*)null, 72));
				obj7 = obj;
				_ = -1;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						X509Certificate2 x509Certificate = default;
						bool flag = x509Certificate != null;
						if (flag)
						{
							bool flag2 = TrustedRoots.VerifyTrust(x509Certificate);
						}
						else
						{
							bool flag2 = false;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj9 = default;
						object obj8 = flag & obj9;
						if (obj8 != null && ResponseExtensions.IsBson((IResponse)x509Certificate))
						{
							DateTime startTimeUTC = ((Tournament)_003Crequest_003E5__2).startTimeUTC;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
							object obj10 = default;
							object obj11 = default;
							if (obj10 == obj11)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
								object obj13 = default;
								object obj12 = obj13;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
								object obj15 = default;
								object obj14 = obj15;
							}
							else
							{
								object obj16 = default;
								object obj14 = obj16;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							int totalLength = default;
							string msg = string.ConcatArray((string[])(object)"GetNextTournamentFetchTime: Request failed or bad response, status: ", totalLength);
							LogWarning(msg);
						}
						object obj17 = this + 20;
						obj17 = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				RanksData ranksData = TopRunSave.ranksData;
				object obj18 = ranksData + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v38+8]");
				if ((nint)0 != 0)
				{
					return null;
				}
				RanksData ranksData2 = TopRunSave.ranksData;
				Dictionary<string, Rank> ranks = ranksData2.ranks;
				if (ranksData2.ranks != null)
				{
					int multiplier = _003C_003E4__this.multiplier;
					if (((string)multiplier).get_Chars((int)ranks.entries) == '\0')
					{
						RanksData ranksData3 = TopRunSave.ranksData;
						object obj19 = ranksData3 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v43 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+58]");
					bool flag3 = (nint)0 < (nint)1;
					RanksData ranksData4 = TopRunSave.ranksData;
					if (flag3)
					{
						DateTime today = CDateTime.Today;
						dateTime = (DateTime?)(object)0;
						_ = 0;
						obj5 = today;
						((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj5 != 0;
						*(DateTime?*)(nint)dateTime = (DateTime)sendOptions;
						((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)dateTime != 0;
						WebClient.SendOptions sendOptions2 = sendOptions;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (System.Nullable`1<System.DateTime>)+8]");
						System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions2)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
						object obj20 = ranksData4 + 48;
						obj20 = sendOptions.disableCache;
						_ = sendOptions.simulatedRequestResults;
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v28 (TopRun.Internal.RanksData)+10]");
					char c = '\0';
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v28 (TopRun.Internal.RanksData)+10]");
					bool flag4;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v55 (System.Char)+8]");
						flag4 = (nint)0 == 0;
					}
					else
					{
						flag4 = true;
					}
					if (flag4)
					{
						return null;
					}
					string format = ((Manager)null).FindFacebookIdFromPublicKey("/players/getcountrychangedate");
					nint num = (nint)typeof(Uri);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v61 (Il2CppClass<System.Uri>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num2 = (nint)typeof(Uri);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v95 (Il2CppClass<System.Uri>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v28 (TopRun.Internal.RanksData)+10]");
					bool flag5 = System.UriHelper.IsNotSafeForUnescape('\0');
					int multiplier2 = _003C_003E4__this.multiplier;
					string otherUri = string.Format((IFormatProvider)(object)"{0}?PrivateKey={1}&ToCountry={2}", format, flag5, multiplier2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Uri uri = default;
					uri.CreateThisFromUri((Uri)(object)otherUri);
					nint num3 = (nint)typeof(KilooWebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S0_v76 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
					object obj22 = (nint)0 & (nint)0x200;
					if (obj22 != null)
					{
						nint num4 = (nint)typeof(KilooWebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S0_v91 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj23 = this + 20;
					IRequest request = KilooWebClient.CreatePut(uri);
					float requestMinBackOffTime = ((Manager)null).requestMinBackOffTime;
					IRequest request2 = RequestExtensions.WithKeepAlive(request, requestMinBackOffTime);
					float requestMaxBackOffTime = ((Manager)null).requestMaxBackOffTime;
					IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, requestMaxBackOffTime);
					float awardsPercentageComplete = ((AwardsManager)null).GetAwardsPercentageComplete();
					Wait.Config.TimeConfig timeConfig = ((Wait.Config)request3).For(awardsPercentageComplete);
					obj23 = timeConfig;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj6 != 0;
					WebClient.SendOptions sendOptions3 = sendOptions;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
					System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions3)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
					object obj24 = this + 12;
					Coroutine coroutine = WebClient.RequestAsync(_003Crequest_003E5__2, null, sendOptions);
					obj24 = coroutine;
					_003C_003E1__state = 1;
					return 1;
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

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public Manager _003C_003E4__this;

		public string currentTournamentId;

		public IList<string> keysToGetRanksFor;

		public _003C_003Ec__DisplayClass104_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CRequestRanksForPlayers_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0068: Expected I, but got Obj
			//IL_007e: Expected Obj, but got I
			//IL_00a9: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj = default;
			string obj3;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				IResponse response = default;
				Texture2D texture2D = ResponseExtensions.AsTexture(response);
				if ((object)texture2D != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					IResponse response2 = default;
					string text = ResponseExtensions.AsString(response2);
					nint num = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num3 = ((ComputeShader)(object)text).FindKernel((string)null);
					bool flag = num3 == 0;
					obj3 = text;
					if (!flag)
					{
						obj3 = text;
						goto IL_0142;
					}
				}
				else
				{
					obj3 = null;
				}
			}
			else
			{
				obj3 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int totalLength = default;
			string msg = string.ConcatArray((string[])(object)"RequestUserInfoFromFacebook: Request failed or bad response, status: ", totalLength);
			LogWarning(msg);
			goto IL_0142;
			IL_0142:
			_003C_003E4__this((Texture2D)(object)obj3);
		}
	}

	private sealed class _003CRequestRanksForPlayers_003Ed__104(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ec: Expected VT, but got Unknown
				//IL_04f5: Expected Obj, but got I4
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected Obj, but got Unknown
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected Obj, but got Unknown
				//IL_006d: Expected Obj, but got I4
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Expected Obj, but got Unknown
				//IL_0146: Expected Obj, but got I
				//IL_015e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0163: Expected Obj, but got Unknown
				//IL_0179: Expected Obj, but got I
				//IL_0189: Expected Obj, but got I
				//IL_019a: Unknown result type (might be due to invalid IL or missing references)
				//IL_019f: Expected Obj, but got Unknown
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ad: Expected Obj, but got Unknown
				//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c5: Expected Obj, but got Unknown
				//IL_01d7: Expected I4, but got Obj
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ea: Expected Obj, but got Unknown
				//IL_0253: Expected Obj, but got I
				//IL_0263: Expected Obj, but got I
				//IL_0274: Unknown result type (might be due to invalid IL or missing references)
				//IL_0279: Expected Obj, but got Unknown
				//IL_0282: Unknown result type (might be due to invalid IL or missing references)
				//IL_0287: Expected Obj, but got Unknown
				//IL_02a7: Expected Obj, but got I
				//IL_02b7: Expected Obj, but got I
				//IL_02c7: Expected Obj, but got I
				//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d5: Expected Obj, but got Unknown
				//IL_02de: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e3: Expected Obj, but got Unknown
				//IL_032b: Expected I, but got Obj
				//IL_0341: Expected Obj, but got I
				//IL_03b8: Expected Obj, but got I4
				//IL_036c: Expected I, but got Obj
				//IL_0436: Unknown result type (might be due to invalid IL or missing references)
				//IL_043b: Expected Obj, but got Unknown
				//IL_045a: Expected I4, but got Obj
				//IL_0455: Expected native int or pointer, but got VT
				//IL_046f: Expected Obj, but got I
				//IL_046a: Expected native int or pointer, but got VT
				//IL_0475: Unknown result type (might be due to invalid IL or missing references)
				//IL_047a: Expected Obj, but got Unknown
				//IL_048b: Expected Obj, but got VT
				//IL_04b0: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
				obj = 0;
				_ = 0;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj3 = default;
				object obj2 = obj3 + 8;
				obj2 = _003C_003E4__this;
				object obj4 = obj3 + 12;
				obj4 = 0;
				RanksData ranksData = TopRunSave.ranksData;
				Dictionary<string, Rank> ranks = ranksData.ranks;
				if (ranksData.ranks != null)
				{
					object obj5 = obj3 + 12;
					obj5 = ranks.buckets;
				}
				PlayerIdsData playerIdsData = TopRunSave.playerIdsData;
				if (playerIdsData.players != null)
				{
					Dictionary<string, PlayerIdsData.PlayerIdData> players = playerIdsData.players;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v20+C]");
					if (((string)(object)players).get_Chars(0) == '\0')
					{
						goto IL_01dc;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				TournamentData tournamentData = default;
				tournamentData._002Ector();
				string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
				int stringLength = lastTopRunResultAwardedID.m_stringLength;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v84 (System.Int32)+10]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v84 (System.Int32)+1C]");
				object obj6 = num - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj7 = obj6 + 1;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S3_v12 (Il2CppMethodInfo)+C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S3_v13+60]");
				object obj9 = 0;
				object obj10 = obj9;
				object obj11 = obj10 & 0x1FFF;
				object obj12 = obj11 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v127 @ S4_v17 (should have been resolved before IL gen)");
				object obj13 = tournamentData + 12;
				object obj14 = default;
				obj13 = obj14;
				((Manager)null).AppHasRefreshed((RefreshType)tournamentData);
				goto IL_01dc;
				IL_01dc:
				object obj15 = obj3 + 16;
				IEnumerator enumerator = ((Manager)null).RequestRanksForPlayers();
				obj15 = enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj16 = default;
				if ((nint)obj16 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S3_v5 (Il2CppMethodInfo)+C]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S3_v6+60]");
					object obj18 = 0;
					object obj19 = obj18;
					object obj20 = obj19 & 0x1FFF;
					object obj21 = obj20 + 113696;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v203 @ S4_v7 (should have been resolved before IL gen)");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S4_v9 (Il2CppMethodInfo)+C]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S4_v10+60]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S4_v11+48]");
					object obj24 = 0;
					object obj25 = obj24 & 0x7FF;
					object obj26 = obj25 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v222 @ S5_v9 (should have been resolved before IL gen)");
					string otherUri = ((Manager)null).FindFacebookIdFromPublicKey("/tournaments/getprevioustournamentresultsforplayers");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Uri uri = default;
					uri.CreateThisFromUri((Uri)(object)otherUri);
					nint num5 = (nint)typeof(KilooWebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v51 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
					object obj27 = (nint)0 & (nint)0x200;
					if (obj27 != null)
					{
						nint num6 = (nint)typeof(KilooWebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v74 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					IRequest request = KilooWebClient.CreateGet(uri);
					string adSpace = default;
					bool flag = ((FlurryVideoAdsAndroid)request).IsReady(adSpace);
					float requestMinBackOffTime = ((Manager)null).requestMinBackOffTime;
					IRequest request2 = RequestExtensions.WithKeepAlive((IRequest)flag, requestMinBackOffTime);
					float requestMaxBackOffTime = ((Manager)null).requestMaxBackOffTime;
					IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, requestMaxBackOffTime);
					float awardsPercentageComplete = ((AwardsManager)null).GetAwardsPercentageComplete();
					Wait.Config.TimeConfig timeConfig = ((Wait.Config)request3).For(awardsPercentageComplete);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					WebClient.RequestCompleteHandler requestCompleteHandler = default;
					((Delegate)requestCompleteHandler).method_ptr = method_ptr;
					((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass104_0._003CRequestRanksForPlayers_003Eb__0);
					object obj28 = requestCompleteHandler + 16;
					obj28 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
					object obj29 = this + 12;
					Coroutine coroutine = RequestExtensions.SendAsync((IRequest)timeConfig, requestCompleteHandler, sendOptions);
					obj29 = coroutine;
					_003C_003E1__state = 1;
					return 1;
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

	private sealed class _003CRequestSubmitScoreCoroutine_003Ed__105(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		public bool previouslySavedScore;

		public int scoreToSubmit;

		public bool isRetry;

		private TournamentData _003Ctour_003E5__2;

		private bool _003CscoreWasUpdated_003E5__3;

		private int _003CunsubmittedScore_003E5__4;

		private string _003CtournamentId_003E5__5;

		private string _003CtournamentCountry_003E5__6;

		private DateTime _003CtournamentStart_003E5__7;

		private DateTime _003CtournamentEnd_003E5__8;

		private IRequest _003Crequest_003E5__9;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e16: Expected VT, but got Unknown
				//IL_0e1f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e24: Expected VT, but got Unknown
				//IL_0e2d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e32: Expected Obj, but got Unknown
				//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e40: Expected Obj, but got Unknown
				//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e4e: Expected Obj, but got Unknown
				//IL_0e57: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e5c: Expected Obj, but got Unknown
				//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e6a: Expected Obj, but got Unknown
				//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e78: Expected Obj, but got Unknown
				//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e86: Expected Obj, but got Unknown
				//IL_0e8f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e94: Expected Obj, but got Unknown
				//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ea2: Expected Obj, but got Unknown
				//IL_0eab: Unknown result type (might be due to invalid IL or missing references)
				//IL_0eb0: Expected Obj, but got Unknown
				//IL_0eb9: Expected Obj, but got I4
				//IL_0ec8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ecd: Expected Obj, but got Unknown
				//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b3: Expected Obj, but got Unknown
				//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d44: Expected Obj, but got Unknown
				//IL_0d4d: Expected Obj, but got I4
				//IL_0d61: Expected Obj, but got I4
				//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d6: Expected Obj, but got Unknown
				//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f8: Expected Obj, but got Unknown
				//IL_0326: Expected Obj, but got VT
				//IL_0333: Expected I4, but got Obj
				//IL_032e: Expected native int or pointer, but got VT
				//IL_0342: Expected VT, but got I4
				//IL_034d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0352: Expected Obj, but got Unknown
				//IL_0367: Expected I4, but got Obj
				//IL_0362: Expected native int or pointer, but got VT
				//IL_036d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0372: Expected Obj, but got Unknown
				//IL_037f: Expected Obj, but got I4
				//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d7f: Expected Obj, but got Unknown
				//IL_0dba: Expected Obj, but got I4
				//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_08ad: Expected Obj, but got Unknown
				//IL_012a: Expected VT, but got I4
				//IL_0138: Expected Obj, but got VT
				//IL_0145: Expected I4, but got Obj
				//IL_0140: Expected native int or pointer, but got VT
				//IL_014d: Expected native int or pointer, but got VT
				//IL_0df9: Expected Obj, but got I4
				//IL_0164: Expected I4, but got VT
				//IL_015f: Expected native int or pointer, but got VT
				//IL_0179: Expected Obj, but got I
				//IL_0174: Expected native int or pointer, but got VT
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Expected Obj, but got Unknown
				//IL_0194: Expected Obj, but got I4
				//IL_10f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_10fb: Expected Obj, but got Unknown
				//IL_1104: Expected Obj, but got I4
				//IL_03f0: Expected I, but got Obj
				//IL_0406: Expected Obj, but got I
				//IL_0f26: Expected Obj, but got VT
				//IL_0f2f: Expected Obj, but got VT
				//IL_0f37: Expected VT, but got Obj
				//IL_0f44: Expected I4, but got Obj
				//IL_0f3f: Expected native int or pointer, but got VT
				//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f56: Expected Obj, but got Unknown
				//IL_0f6d: Expected Obj, but got I8
				//IL_0431: Expected I, but got Obj
				//IL_1046: Unknown result type (might be due to invalid IL or missing references)
				//IL_104b: Expected Obj, but got Unknown
				//IL_0476: Unknown result type (might be due to invalid IL or missing references)
				//IL_047b: Expected Obj, but got Unknown
				//IL_0489: Expected I, but got Obj
				//IL_049f: Expected Obj, but got I
				//IL_0f9a: Expected Obj, but got VT
				//IL_0fa2: Expected VT, but got Obj
				//IL_0faf: Expected I4, but got Obj
				//IL_0faa: Expected native int or pointer, but got VT
				//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fc1: Expected Obj, but got Unknown
				//IL_0fd8: Expected Obj, but got I8
				//IL_04ca: Expected I, but got Obj
				//IL_0529: Expected Obj, but got I
				//IL_0539: Expected Obj, but got I
				//IL_054a: Unknown result type (might be due to invalid IL or missing references)
				//IL_054f: Expected Obj, but got Unknown
				//IL_0558: Unknown result type (might be due to invalid IL or missing references)
				//IL_055d: Expected Obj, but got Unknown
				//IL_0571: Expected VT, but got I4
				//IL_0c1e: Expected Obj, but got I4
				//IL_0596: Expected Obj, but got I
				//IL_05a6: Expected Obj, but got I
				//IL_05b6: Expected Obj, but got I
				//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_05c4: Expected Obj, but got Unknown
				//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_05d2: Expected Obj, but got Unknown
				//IL_05ee: Expected Obj, but got I4
				//IL_0613: Expected Obj, but got I
				//IL_0623: Expected Obj, but got I
				//IL_0633: Expected Obj, but got I
				//IL_063c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0641: Expected Obj, but got Unknown
				//IL_064a: Unknown result type (might be due to invalid IL or missing references)
				//IL_064f: Expected Obj, but got Unknown
				//IL_066f: Expected Obj, but got I
				//IL_067f: Expected Obj, but got I
				//IL_068f: Expected Obj, but got I
				//IL_0698: Unknown result type (might be due to invalid IL or missing references)
				//IL_069d: Expected Obj, but got Unknown
				//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_06ab: Expected Obj, but got Unknown
				//IL_06cb: Expected Obj, but got I
				//IL_06db: Expected Obj, but got I
				//IL_06eb: Expected Obj, but got I
				//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_06f9: Expected Obj, but got Unknown
				//IL_0702: Unknown result type (might be due to invalid IL or missing references)
				//IL_0707: Expected Obj, but got Unknown
				//IL_0731: Expected Obj, but got I
				//IL_0741: Expected Obj, but got I
				//IL_0751: Expected Obj, but got I
				//IL_075a: Unknown result type (might be due to invalid IL or missing references)
				//IL_075f: Expected Obj, but got Unknown
				//IL_0768: Unknown result type (might be due to invalid IL or missing references)
				//IL_076d: Expected Obj, but got Unknown
				//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c61: Expected Obj, but got Unknown
				//IL_0c6a: Expected Obj, but got I4
				//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c81: Expected Obj, but got Unknown
				//IL_0c8a: Expected Obj, but got I4
				//IL_07b5: Expected I, but got Obj
				//IL_07cb: Expected Obj, but got I
				//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0ca6: Expected Obj, but got Unknown
				//IL_0caf: Expected Obj, but got I4
				//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fff: Expected Obj, but got Unknown
				//IL_1025: Expected Obj, but got I4
				//IL_0842: Expected I4, but got Obj
				//IL_083d: Expected native int or pointer, but got VT
				//IL_0857: Expected Obj, but got I
				//IL_0852: Expected native int or pointer, but got VT
				//IL_085d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0862: Expected Obj, but got Unknown
				//IL_0892: Expected Obj, but got I4
				//IL_07f6: Expected I, but got Obj
				//IL_0cfa: Expected VT, but got I4
				//IL_0cfa: Expected VT, but got I4
				//IL_0cfa: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 144;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj2 + 88);
				DateTime? dateTime = (DateTime?)(object)(obj2 - -64);
				object obj3 = obj2 + 80;
				object obj4 = obj2 + 56;
				object obj5 = obj2 + 48;
				object obj6 = obj2 + 40;
				object obj7 = obj2 + 32;
				object obj8 = obj2 + 24;
				object obj9 = obj2 + 16;
				object obj10 = obj2 + 104;
				object obj11 = obj2 + 8;
				object obj12 = obj2 + 120;
				obj12 = 0;
				_ = 0;
				object obj13 = obj2 + 112;
				obj13 = obj;
				_ = -1;
				Manager manager = _003C_003E4__this;
				object result;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						if (manager._isRefreshingTournament)
						{
							goto IL_0d39;
						}
						goto IL_0d66;
					}
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						RanksData ranksData = TopRunSave.ranksData;
						object obj14 = this + 44;
						TournamentData tournamentData = _003Ctour_003E5__2;
						obj14 = tournamentData.id;
						object obj15 = this + 48;
						TournamentData tournamentData2 = _003Ctour_003E5__2;
						obj15 = tournamentData2.country;
						TournamentData tournamentData3 = _003Ctour_003E5__2;
						obj4 = tournamentData3.startTime;
						((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj4 != 0;
						_003CtournamentStart_003E5__7 = (DateTime)sendOptions.disableCache;
						object obj16 = _003Ctour_003E5__2 - -64;
						obj5 = obj16;
						((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj5 != 0;
						object obj17 = this - -64;
						obj17 = sendOptions.disableCache;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v100 (TopRun.Internal.RanksData)+10]");
						if ((nint)0 != 0 && _003CtournamentId_003E5__5 != null && _003CtournamentCountry_003E5__6 != null)
						{
							nint num = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S0_v124 (Il2CppClass<System.DateTime>)+BA]");
							object obj18 = (nint)0 & (nint)0x200;
							if (obj18 != null)
							{
								nint num2 = (nint)typeof(DateTime);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v212 (Il2CppClass<System.DateTime>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj6 = _003CtournamentStart_003E5__7;
							obj7 = DateTime.MinValue;
							dateTime = (DateTime?)obj6;
							((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj7 != 0;
							object obj19 = (Nullable)dateTime & 0x3FFFFFFFFFFFFFFFL;
							object obj20 = (sendOptions.disableCache ? 1 : 0) & 0x3FFFFFFFFFFFFFFFL;
							if (obj19 != obj20)
							{
								object obj21 = this - -64;
								nint num3 = (nint)typeof(DateTime);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v143 (Il2CppClass<System.DateTime>)+BA]");
								object obj22 = (nint)0 & (nint)0x200;
								if (obj22 != null)
								{
									nint num4 = (nint)typeof(DateTime);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v206 (Il2CppClass<System.DateTime>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								obj8 = obj21;
								obj9 = DateTime.MinValue;
								dateTime = (DateTime?)obj8;
								((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj9 != 0;
								object obj23 = (Nullable)dateTime & 0x3FFFFFFFFFFFFFFFL;
								object obj24 = (sendOptions.disableCache ? 1 : 0) & 0x3FFFFFFFFFFFFFFFL;
								if (obj23 != obj24)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									nint num5 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ S3_v7 (Il2CppMethodInfo)+C]");
									object obj25 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ S3_v8+60]");
									object obj26 = 0;
									object obj27 = obj26;
									object obj28 = obj27 & 0x1FFF;
									object obj29 = obj28 + 113696;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v547 @ S4_v6 (should have been resolved before IL gen)");
									dateTime = (DateTime?)(object)_003CunsubmittedScore_003E5__4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
									nint num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S4_v8 (Il2CppMethodInfo)+C]");
									object obj30 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S4_v9+60]");
									object obj31 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S4_v10+48]");
									object obj32 = 0;
									object obj33 = obj32 & 0x7FF;
									object obj34 = obj33 + 39195;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v580 @ S5_v7 (should have been resolved before IL gen)");
									int highScore = ((Manager)null).highScore;
									obj10 = highScore;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
									nint num7 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S4_v13 (Il2CppMethodInfo)+C]");
									object obj35 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S4_v14+60]");
									object obj36 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ S4_v15+48]");
									object obj37 = 0;
									object obj38 = obj37 & 0x7FF;
									object obj39 = obj38 + 39195;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v668 @ S5_v11 (should have been resolved before IL gen)");
									nint num8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S4_v18 (Il2CppMethodInfo)+C]");
									object obj40 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ S4_v19+60]");
									object obj41 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ S4_v20+48]");
									object obj42 = 0;
									object obj43 = obj42 & 0x7FF;
									object obj44 = obj43 + 39195;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v686 @ S5_v15 (should have been resolved before IL gen)");
									nint num9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S4_v23 (Il2CppMethodInfo)+C]");
									object obj45 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S4_v24+60]");
									object obj46 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S4_v25+48]");
									object obj47 = 0;
									object obj48 = obj47 & 0x7FF;
									object obj49 = obj48 + 39195;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v705 @ S5_v19 (should have been resolved before IL gen)");
									IEnumerator enumerator = ((Manager)null).RefreshKeysIfNecessary();
									nint num10 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ S4_v28 (Il2CppMethodInfo)+C]");
									object obj50 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S4_v29+60]");
									object obj51 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ S4_v30+48]");
									object obj52 = 0;
									object obj53 = obj52 & 0x7FF;
									object obj54 = obj53 + 39195;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v212 @ S5_v23 (should have been resolved before IL gen)");
									string otherUri = ((Manager)null).FindFacebookIdFromPublicKey("/scores/submitscore");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									Uri uri = default;
									uri.CreateThisFromUri((Uri)(object)otherUri);
									nint num11 = (nint)typeof(KilooWebClient);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S0_v187 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
									object obj55 = (nint)0 & (nint)0x200;
									if (obj55 != null)
									{
										nint num12 = (nint)typeof(KilooWebClient);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ S0_v202 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									object obj56 = this + 72;
									IRequest request = KilooWebClient.CreateGet(uri);
									string adSpace = default;
									bool flag = ((FlurryVideoAdsAndroid)request).IsReady(adSpace);
									obj56 = flag;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
									((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj12 != 0;
									WebClient.SendOptions sendOptions2 = sendOptions;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
									System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions2)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
									object obj57 = this + 12;
									Coroutine coroutine = WebClient.RequestAsync(_003Crequest_003E5__9, null, sendOptions);
									obj57 = coroutine;
									_003C_003E1__state = 3;
									result = 1;
									goto IL_0f04;
								}
							}
						}
						goto IL_0dbf;
					}
					if (_003C_003E1__state == 3)
					{
						_003C_003E1__state = -1;
						object obj58 = this + 32;
						RanksData ranksData2 = TopRunSave.ranksData;
						obj58 = ranksData2.ranks;
						if (_003Ctour_003E5__2 != null)
						{
							TournamentData tournamentData4 = _003Ctour_003E5__2;
							if (_003CtournamentId_003E5__5 != tournamentData4.id)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								X509Certificate2 x509Certificate = default;
								bool flag2 = x509Certificate != null;
								bool flag3 = flag2 && TrustedRoots.VerifyTrust(x509Certificate);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								object obj60 = default;
								object obj59 = flag2 & obj60;
								if (obj59 != null && ResponseExtensions.IsBson((IResponse)x509Certificate))
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
									object obj61 = default;
									object obj62 = default;
									if (obj61 == obj62)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
										object obj64 = default;
										object obj63 = obj64;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
										object obj66 = default;
										object obj65 = obj66;
									}
									else
									{
										object obj67 = default;
										object obj65 = obj67;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
								}
								else if (flag2)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
									object obj68 = default;
									if ((nint)obj68 != 400)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
										object obj69 = default;
										if ((nint)obj69 == 404)
										{
											TournamentData tournamentData5 = _003Ctour_003E5__2;
											tournamentData5.closed = true;
										}
									}
									else if (((string)flag3).EndsWith("Invalid PrivateKey"))
									{
										LogWarning("SubmitScore: Invalid User Info, discarding and retrying (once)");
										RanksData ranksData3 = TopRunSave.ranksData;
										object obj70 = ranksData3 + 24;
										obj70 = 0;
										RanksData ranksData4 = TopRunSave.ranksData;
										object obj71 = ranksData4 + 16;
										obj71 = 0;
										RanksData ranksData5 = TopRunSave.ranksData;
										object obj72 = ranksData5 + 20;
										obj72 = 0;
										if (~(isRetry ? 1u : 0u) != 0)
										{
											manager._isRefreshingTournament = false;
											GameObject list = ((SpawnPool)(object)manager).InstantiatePrefab((GameObject)scoreToSubmit, (Vector3)1, (Quaternion)1);
											Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
											result = null;
											goto IL_0f04;
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								int totalLength = default;
								string msg = string.ConcatArray((string[])(object)"SubmitScore: Request failed or bad response, status: ", totalLength);
								LogWarning(msg);
								goto IL_10f0;
							}
						}
						_003CscoreWasUpdated_003E5__3 = false;
						goto IL_10f0;
					}
					result = null;
				}
				else
				{
					_003C_003E1__state = -1;
					if (!((Manager)null).isRefreshing)
					{
						result = null;
						if (!previouslySavedScore)
						{
							RanksData ranksData6 = TopRunSave.ranksData;
							int num13 = scoreToSubmit;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v78 (TopRun.Internal.RanksData)+44]");
							bool flag4 = (nint)num13 <= (nint)0;
							result = null;
							if (!flag4)
							{
								RanksData ranksData7 = TopRunSave.ranksData;
								_ = scoreToSubmit;
								RanksData ranksData8 = TopRunSave.ranksData;
								DateTime today = CDateTime.Today;
								dateTime = (DateTime?)(object)0;
								_ = 0;
								obj3 = today;
								((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj3 != 0;
								*(DateTime?*)(nint)dateTime = (DateTime)sendOptions;
								((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)dateTime != 0;
								WebClient.SendOptions sendOptions3 = sendOptions;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (System.Nullable`1<System.DateTime>)+8]");
								System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions3)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
								object obj73 = ranksData8 + 72;
								obj73 = sendOptions.disableCache;
								_ = sendOptions.simulatedRequestResults;
								result = null;
							}
						}
					}
					else
					{
						object obj74 = this + 32;
						RanksData ranksData9 = TopRunSave.ranksData;
						obj74 = ranksData9.ranks;
						TournamentData tournamentData6 = _003Ctour_003E5__2;
						if (scoreToSubmit > tournamentData6.submittedScore)
						{
							_003CscoreWasUpdated_003E5__3 = false;
							TournamentData tournamentData7 = _003Ctour_003E5__2;
							_003CunsubmittedScore_003E5__4 = tournamentData7.unsubmittedScore;
							if (scoreToSubmit > _003CunsubmittedScore_003E5__4)
							{
								TournamentData tournamentData8 = _003Ctour_003E5__2;
								_003CunsubmittedScore_003E5__4 = scoreToSubmit;
								tournamentData8.unsubmittedScore = scoreToSubmit;
								_003CscoreWasUpdated_003E5__3 = true;
							}
							if (manager._isRefreshingTournament)
							{
								goto IL_0d39;
							}
							goto IL_0d66;
						}
						result = null;
					}
				}
				goto IL_0f04;
				IL_0d66:
				manager._isRefreshingTournament = true;
				object obj75 = this + 12;
				IEnumerator list2 = manager.LoginOrRegisterFacebook();
				Coroutine coroutine3 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list2);
				obj75 = coroutine3;
				_003C_003E1__state = 2;
				result = 1;
				goto IL_0f04;
				IL_10f0:
				object obj76 = this + 72;
				obj76 = 0;
				goto IL_0dbf;
				IL_0dbf:
				manager._isRefreshingTournament = false;
				if (~(_003CscoreWasUpdated_003E5__3 ? 1u : 0u) == 0)
				{
					((Rank)(object)manager)._002Ector((string)1, 0);
				}
				result = null;
				goto IL_0f04;
				IL_0d39:
				object obj77 = this + 12;
				obj77 = 0;
				_003C_003E1__state = 1;
				result = 1;
				goto IL_0f04;
				IL_0f04:
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

	private sealed class _003CRefreshKeysIfNecessary_003Ed__108(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Expected Obj, but got Unknown
				//IL_010d: Expected Obj, but got I4
				//IL_0178: Unknown result type (might be due to invalid IL or missing references)
				//IL_017d: Expected Obj, but got Unknown
				//IL_0201: Unknown result type (might be due to invalid IL or missing references)
				//IL_0206: Expected Obj, but got Unknown
				//IL_01ba: Expected Obj, but got I4
				//IL_0243: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						return null;
					}
					_003C_003E1__state = -1;
					return null;
				}
				_003C_003E1__state = -1;
				RanksData ranksData = TopRunSave.ranksData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v8 (TopRun.Internal.RanksData)+10]");
				if ((nint)0 == 0)
				{
					object obj = this + 12;
					IEnumerator list = _003C_003E4__this.RequestCreatePlayer();
					Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
					obj = coroutine;
					_003C_003E1__state = 3;
					return 1;
				}
				string nameFromSocialManager = ((Manager)null).GetNameFromSocialManager();
				if (nameFromSocialManager != null)
				{
					RanksData ranksData2 = TopRunSave.ranksData;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v16 (TopRun.Internal.RanksData)+18]");
					if ((nint)0 == 0)
					{
						object obj2 = this + 12;
						IEnumerator list2 = _003C_003E4__this.LoginOrCreatePlayer();
						Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list2);
						obj2 = coroutine2;
						_003C_003E1__state = 2;
						return 1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v16 (TopRun.Internal.RanksData)+18]");
					if (nameFromSocialManager.get_Chars(0) != '\0')
					{
						LogError(null);
						object obj3 = this + 12;
						IEnumerator list3 = _003C_003E4__this.RequestCreatePlayer();
						Coroutine coroutine3 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list3);
						obj3 = coroutine3;
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

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public FacebookLoginResult facebookLoginResult;

		public _003C_003Ec__DisplayClass109_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CLoginOrRegisterFacebook_003Eb__0(FacebookLoginResult result)
		{
			facebookLoginResult = result;
		}
	}

	private sealed class _003CLoginOrRegisterFacebook_003Ed__109(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private _003C_003Ec__DisplayClass109_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected Obj, but got Unknown
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Expected Obj, but got Unknown
				//IL_00ec: Expected Obj, but got I4
				//IL_0111: Expected Obj, but got I4
				//IL_015e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0163: Expected Obj, but got Unknown
				//IL_01a0: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass109_0 obj = _003C_003E8__1;
					if (obj.facebookLoginResult == FacebookLoginResult.NotFound)
					{
						object obj2 = this + 12;
						string list = QuoteString((string)(object)_003C_003E4__this);
						Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
						obj2 = coroutine;
						_003C_003E1__state = 2;
						return 1;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj4 = default;
				obj3 = obj4;
				_003C_003Ec__DisplayClass109_0 obj5 = _003C_003E8__1;
				obj5.facebookLoginResult = FacebookLoginResult.Failed;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				string text = default;
				text.m_stringLength = (int)num;
				_ = 0;
				object obj6 = text + 16;
				obj6 = _003C_003E8__1;
				object obj7 = this + 12;
				int num2 = ((Tournament)(object)_003C_003E4__this).FindParticipantScoreByPublicKey(text);
				Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])num2);
				obj7 = coroutine2;
				_003C_003E1__state = 1;
				return 1;
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

	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public FacebookLoginResult facebookLoginResult;

		public _003C_003Ec__DisplayClass110_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CLoginOrCreatePlayer_003Eb__0(FacebookLoginResult result)
		{
			facebookLoginResult = result;
		}
	}

	private sealed class _003CLoginOrCreatePlayer_003Ed__110(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		private _003C_003Ec__DisplayClass110_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cc: Expected Obj, but got Unknown
				//IL_0209: Expected Obj, but got I4
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0085: Expected Obj, but got Unknown
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e2: Expected Obj, but got Unknown
				//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Expected Obj, but got Unknown
				//IL_0113: Expected Obj, but got I4
				//IL_0138: Expected Obj, but got I4
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018a: Expected Obj, but got Unknown
				//IL_0193: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass110_0 obj = _003C_003E8__1;
					if (obj.facebookLoginResult != FacebookLoginResult.NotFound)
					{
						return null;
					}
					object obj2 = this + 20;
					obj2 = 0;
				}
				else
				{
					_003C_003E1__state = -1;
					string nameFromSocialManager = ((Manager)null).GetNameFromSocialManager();
					if (nameFromSocialManager != null)
					{
						object obj3 = this + 20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj4 = default;
						obj3 = obj4;
						_003C_003Ec__DisplayClass110_0 obj5 = _003C_003E8__1;
						obj5.facebookLoginResult = FacebookLoginResult.Failed;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num = 0;
						string text = default;
						text.m_stringLength = (int)num;
						_ = 0;
						object obj6 = text + 16;
						obj6 = _003C_003E8__1;
						object obj7 = this + 12;
						int num2 = ((Tournament)(object)_003C_003E4__this).FindParticipantScoreByPublicKey(text);
						Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])num2);
						obj7 = coroutine;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				object obj8 = this + 12;
				IEnumerator list = _003C_003E4__this.RequestFacebookRegister();
				Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
				obj8 = coroutine2;
				_003C_003E1__state = 2;
				return 1;
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

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public Manager _003C_003E4__this;

		public string facebookId;

		public Action<FacebookLoginResult> onComplete;

		public _003C_003Ec__DisplayClass112_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CRequestFacebookLogin_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected Obj, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected Obj, but got Unknown
			//IL_0129: Expected Obj, but got I4
			//IL_13c0: Expected Obj, but got I4
			//IL_0146: Expected Obj, but got I4
			//IL_131f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1324: Expected Obj, but got Unknown
			//IL_0e77: Expected Obj, but got I4
			//IL_0167: Expected Obj, but got I4
			//IL_017f: Expected Obj, but got I4
			//IL_0e9f: Expected Obj, but got I4
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Expected Obj, but got Unknown
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Expected Obj, but got Unknown
			//IL_04ae: Expected Obj, but got I4
			//IL_110f: Expected Obj, but got I
			//IL_139b: Expected Obj, but got I4
			//IL_114d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1152: Expected Obj, but got Unknown
			//IL_0656: Expected Obj, but got I4
			//IL_058f: Expected Obj, but got I4
			//IL_1183: Unknown result type (might be due to invalid IL or missing references)
			//IL_1188: Expected Obj, but got Unknown
			//IL_05cf: Expected Obj, but got I
			//IL_01fe: Expected I, but got Obj
			//IL_0605: Unknown result type (might be due to invalid IL or missing references)
			//IL_060a: Expected Obj, but got Unknown
			//IL_0265: Expected I, but got Obj
			//IL_13a8: Expected I, but got Obj
			//IL_023e: Expected I, but got Obj
			//IL_063b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0640: Expected Obj, but got Unknown
			//IL_1361: Expected I, but got Obj
			//IL_024d: Expected I, but got Obj
			//IL_0282: Expected I, but got Obj
			//IL_040b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0410: Expected Obj, but got Unknown
			//IL_0419: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Expected Obj, but got Unknown
			//IL_044a: Expected Obj, but got I4
			//IL_051c: Expected Obj, but got I4
			//IL_0ec7: Expected Obj, but got I4
			//IL_0eef: Expected Obj, but got I4
			//IL_0f17: Expected Obj, but got I4
			//IL_0f4e: Expected Obj, but got I4
			//IL_0f76: Expected Obj, but got I4
			//IL_0f9e: Expected Obj, but got I4
			//IL_0fc6: Expected Obj, but got I4
			//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe9: Expected Obj, but got Unknown
			//IL_0ff2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff7: Expected Obj, but got Unknown
			//IL_1023: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			X509Certificate2 x509Certificate = default;
			bool flag = x509Certificate != null;
			if (flag)
			{
				bool flag2 = TrustedRoots.VerifyTrust(x509Certificate);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj4 = default;
				object obj3 = flag & obj4;
				if (obj3 != null && ResponseExtensions.IsBson((IResponse)x509Certificate))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj5 = default;
					if (obj5 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
						object obj6 = default;
						if (obj6 != null)
						{
							PlayerIdsData playerIdsData = TopRunSave.playerIdsData;
							object obj7 = playerIdsData + 8;
							obj7 = facebookId;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							object obj8 = 0;
							object obj10 = default;
							object obj11 = default;
							object obj12 = default;
							object obj13 = default;
							object obj14 = default;
							object obj20 = default;
							object obj9;
							Rank rank = default;
							IntPtr intPtr = default;
							object obj25 = default;
							object obj26 = default;
							object obj27 = default;
							object obj28 = default;
							object obj29 = default;
							object obj30 = default;
							nint num = default;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								obj9 = 74;
								bool flag3 = obj10 == null;
								obj9 = 77;
								if (flag3)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								obj9 = 22;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								obj9 = 23;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									if (obj11 == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									nint num2;
									if (obj12 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
										num = unchecked((nint)"PublicKey");
										if (obj13 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
											num = unchecked((nint)"PublicKey");
											num2 = unchecked((nint)"PublicKey");
											goto IL_1341;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
										num = unchecked((nint)"PublicKey");
										if (obj14 == null)
										{
											num2 = unchecked((nint)"PublicKey");
											goto IL_1341;
										}
										goto IL_134e;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
									num2 = num;
									goto IL_1341;
									IL_1341:
									num = num2;
								}
								object obj15 = obj2 + 4;
								object obj16 = obj15 + 1;
								obj15 = obj16;
								object obj17 = obj16 << 2;
								object obj18 = obj2 + obj17;
								obj18 = 345;
								object obj19 = obj8;
								string text = null;
								goto IL_1388;
								IL_0664:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
								obj8 = obj19;
								continue;
								IL_1388:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								obj9 = 60;
								if (obj20 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
									obj9 = 62;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
								if ((nint)0 != -1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
									object obj21 = (nint)0 << 2;
									object obj22 = obj2 + obj21;
									if ((nint)obj22 == 345)
									{
										object obj23 = obj2 + 4;
										if ((nint)obj23 > -1)
										{
											object obj24 = obj23 + -1;
											obj23 = obj24;
										}
										num = (nint)obj23;
										goto IL_0664;
									}
								}
								obj9 = 67;
								if (obj19 != null)
								{
									break;
								}
								goto IL_0664;
								IL_134e:
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
								num = unchecked((nint)"Country");
								if (rank != null)
								{
									if ((object)rank.GetType() != typeof(string))
									{
										rank = null;
									}
								}
								else
								{
									rank = null;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
								num = intPtr;
								if ((nint)intPtr >= 0 && rank != null && rank.rank__BackingField != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
									num = intPtr;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
									if (obj25 != obj26)
									{
										obj27 = obj25;
										obj28 = obj29;
										obj9 = 75;
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
									obj19 = obj30;
									text = null;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
									num = intPtr;
									object obj31 = obj2 + 4;
									object obj32 = obj31 + 1;
									obj31 = obj32;
									object obj33 = obj32 << 2;
									object obj34 = obj2 + obj33;
									obj34 = 345;
									obj19 = obj8;
									num = intPtr;
									text = null;
								}
								goto IL_1388;
							}
							object obj35 = obj9 - 22;
							object obj36;
							object obj41 = default;
							if ((nint)obj9 != 22)
							{
								if ((nint)obj35 != 1)
								{
									bool flag4 = (nint)obj35 == 2;
									obj36 = obj9;
									if (!flag4)
									{
										bool flag5 = (nint)obj35 == 3;
										obj36 = obj9;
										if (!flag5)
										{
											bool flag6 = (nint)obj35 == 4;
											obj36 = obj9;
											if (!flag6)
											{
												bool flag7 = (nint)obj35 == 5;
												obj36 = obj9;
												if (!flag7)
												{
													bool flag8 = (nint)obj35 == 6;
													obj36 = obj9;
													if (!flag8)
													{
														bool flag9 = (nint)obj35 == 7;
														obj36 = obj9;
														if (!flag9)
														{
															bool flag10 = (nint)obj35 == 8;
															obj36 = obj9;
															if (!flag10)
															{
																bool flag11 = (nint)obj35 == 9;
																obj36 = obj9;
																if (!flag11)
																{
																	bool flag12 = (nint)obj35 == 10;
																	obj36 = obj9;
																	if (!flag12)
																	{
																		bool flag13 = (nint)obj35 == 11;
																		obj36 = obj9;
																		if (!flag13)
																		{
																			bool flag14 = (nint)obj35 == 12;
																			obj36 = obj9;
																			if (!flag14)
																			{
																				bool flag15 = (nint)obj35 == 13;
																				obj36 = obj9;
																				if (!flag15)
																				{
																					bool flag16 = (nint)obj35 == 14;
																					obj36 = obj9;
																					if (!flag16)
																					{
																						bool flag17 = (nint)obj35 == 15;
																						obj36 = obj9;
																						if (!flag17)
																						{
																							bool flag18 = (nint)obj35 == 16;
																							obj36 = obj9;
																							if (!flag18)
																							{
																								bool flag19 = (nint)obj35 == 17;
																								obj36 = obj9;
																								if (!flag19)
																								{
																									bool flag20 = (nint)obj35 == 18;
																									obj36 = obj9;
																									if (!flag20)
																									{
																										bool flag21 = (nint)obj35 == 19;
																										obj36 = obj9;
																										if (!flag21)
																										{
																											bool flag22 = (nint)obj35 == 20;
																											obj36 = obj9;
																											if (!flag22)
																											{
																												bool flag23 = (nint)obj35 == 21;
																												obj36 = obj9;
																												if (!flag23)
																												{
																													bool flag24 = (nint)obj35 == 22;
																													obj36 = obj9;
																													if (!flag24)
																													{
																														bool flag25 = (nint)obj35 == 23;
																														obj36 = obj9;
																														if (!flag25)
																														{
																															bool flag26 = (nint)obj35 == 24;
																															obj36 = obj9;
																															if (!flag26)
																															{
																																bool flag27 = (nint)obj35 == 25;
																																obj36 = obj9;
																																if (!flag27)
																																{
																																	bool flag28 = (nint)obj35 == 26;
																																	obj36 = obj9;
																																	if (!flag28)
																																	{
																																		bool flag29 = (nint)obj35 == 27;
																																		obj36 = obj9;
																																		if (!flag29)
																																		{
																																			bool flag30 = (nint)obj35 == 28;
																																			obj36 = obj9;
																																			if (!flag30)
																																			{
																																				bool flag31 = (nint)obj35 == 29;
																																				obj36 = obj9;
																																				if (!flag31)
																																				{
																																					bool flag32 = (nint)obj35 == 30;
																																					obj36 = obj9;
																																					if (!flag32)
																																					{
																																						bool flag33 = (nint)obj35 == 31;
																																						obj36 = obj9;
																																						if (!flag33)
																																						{
																																							bool flag34 = (nint)obj35 == 32;
																																							obj36 = obj9;
																																							if (!flag34)
																																							{
																																								bool flag35 = (nint)obj35 == 33;
																																								obj36 = obj9;
																																								if (!flag35)
																																								{
																																									bool flag36 = (nint)obj35 == 34;
																																									obj36 = obj9;
																																									if (!flag36)
																																									{
																																										if ((nint)obj35 != 35)
																																										{
																																											bool flag37 = (nint)obj35 == 36;
																																											obj36 = obj9;
																																											if (!flag37)
																																											{
																																												bool flag38 = (nint)obj35 == 37;
																																												obj36 = obj9;
																																												if (!flag38)
																																												{
																																													if ((nint)obj35 != 38)
																																													{
																																														bool flag39 = (nint)obj35 == 39;
																																														obj36 = obj9;
																																														if (!flag39)
																																														{
																																															if ((nint)obj35 != 40)
																																															{
																																																bool flag40 = (nint)obj35 == 41;
																																																obj36 = obj9;
																																																if (!flag40)
																																																{
																																																	bool flag41 = (nint)obj35 == 42;
																																																	obj36 = obj9;
																																																	if (!flag41)
																																																	{
																																																		bool flag42 = (nint)obj35 == 43;
																																																		obj36 = obj9;
																																																		if (!flag42)
																																																		{
																																																			bool flag43 = (nint)obj35 == 44;
																																																			obj36 = obj9;
																																																			if (!flag43)
																																																			{
																																																				if ((nint)obj35 != 45)
																																																				{
																																																					bool flag44 = (nint)obj35 == 46;
																																																					obj36 = obj9;
																																																					if (!flag44)
																																																					{
																																																						bool flag45 = (nint)obj35 == 47;
																																																						obj36 = obj9;
																																																						if (!flag45)
																																																						{
																																																							bool flag46 = (nint)obj35 == 48;
																																																							obj36 = obj9;
																																																							if (!flag46)
																																																							{
																																																								bool flag47 = (nint)obj35 == 49;
																																																								obj36 = obj9;
																																																								if (!flag47)
																																																								{
																																																									if ((nint)obj35 != 50)
																																																									{
																																																										if ((nint)obj35 != 51)
																																																										{
																																																											if ((nint)obj35 != 52)
																																																											{
																																																												bool flag48 = (nint)obj35 == 53;
																																																												obj36 = obj9;
																																																												if (!flag48)
																																																												{
																																																													bool flag49 = (nint)obj35 == 54;
																																																													obj36 = obj9;
																																																													if (!flag49)
																																																													{
																																																														if ((nint)obj35 != 55)
																																																														{
																																																															obj36 = obj9;
																																																														}
																																																														else
																																																														{
																																																															object obj37 = obj2 + 4;
																																																															object obj38 = obj37 + 1;
																																																															obj37 = obj38;
																																																															object obj39 = obj38 << 2;
																																																															object obj40 = obj2 + obj39;
																																																															obj40 = 396;
																																																															obj41 = obj8;
																																																															obj36 = obj9;
																																																														}
																																																													}
																																																												}
																																																											}
																																																											else
																																																											{
																																																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																												obj36 = 75;
																																																												obj27 = obj25;
																																																												object obj42 = default;
																																																												obj28 = obj42;
																																																											}
																																																										}
																																																										else
																																																										{
																																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																											obj36 = 75;
																																																											obj27 = obj25;
																																																											object obj43 = default;
																																																											obj28 = obj43;
																																																										}
																																																									}
																																																									else
																																																									{
																																																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																										obj36 = 75;
																																																										obj27 = obj25;
																																																										object obj44 = default;
																																																										obj28 = obj44;
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																				else
																																																				{
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
																																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																					obj36 = 75;
																																																					obj27 = obj25;
																																																					object obj45 = default;
																																																					obj28 = obj45;
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																															else
																																															{
																																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																																obj36 = 75;
																																																obj27 = obj25;
																																																object obj46 = default;
																																																obj28 = obj46;
																																															}
																																														}
																																													}
																																													else
																																													{
																																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																														obj36 = 75;
																																														obj27 = obj25;
																																														object obj47 = default;
																																														obj28 = obj47;
																																													}
																																												}
																																											}
																																										}
																																										else
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																																											obj36 = 75;
																																											obj27 = obj25;
																																											object obj48 = default;
																																											obj28 = obj48;
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									obj36 = 75;
									obj27 = obj25;
									object obj49 = default;
									obj28 = obj49;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj36 = 75;
								obj27 = obj25;
								object obj50 = default;
								obj28 = obj50;
							}
							if ((nint)obj36 == 75)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
								object obj51 = default;
								if (obj27 != obj51)
								{
									object obj52 = obj28;
									goto IL_13ed;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
								object obj53 = default;
								obj41 = obj53;
							}
							object obj54 = default;
							if (obj54 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
							if ((nint)0 != -1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
								object obj55 = (nint)0 << 2;
								object obj56 = obj2 + obj55;
								if ((nint)obj56 == 396)
								{
									object obj57 = obj2 + 4;
									if ((nint)obj57 > -1)
									{
										object obj58 = obj57 + -1;
										obj57 = obj58;
									}
									return;
								}
							}
							if (obj41 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
								goto IL_13ed;
							}
							return;
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int totalLength = default;
			string msg = string.ConcatArray((string[])(object)"GetRanksForPlayers: Request failed or bad response, status: ", totalLength);
			LogWarning(msg);
			return;
			IL_13ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	private sealed class _003CRequestFacebookLogin_003Ed__112(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		public Action<FacebookLoginResult> onComplete;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0407: Unknown result type (might be due to invalid IL or missing references)
				//IL_040c: Expected VT, but got Unknown
				//IL_0415: Unknown result type (might be due to invalid IL or missing references)
				//IL_041a: Expected I4, but got Unknown
				//IL_0431: Unknown result type (might be due to invalid IL or missing references)
				//IL_0436: Expected Obj, but got Unknown
				//IL_043f: Expected Obj, but got I4
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected Obj, but got Unknown
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected Obj, but got Unknown
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Expected Obj, but got Unknown
				//IL_047a: Expected Obj, but got I
				//IL_00c6: Expected I, but got Obj
				//IL_00dc: Expected Obj, but got I
				//IL_04a7: Expected Obj, but got I
				//IL_0107: Expected I, but got Obj
				//IL_0166: Expected Obj, but got I
				//IL_0176: Expected Obj, but got I
				//IL_0187: Unknown result type (might be due to invalid IL or missing references)
				//IL_018c: Expected Obj, but got Unknown
				//IL_0195: Unknown result type (might be due to invalid IL or missing references)
				//IL_019a: Expected Obj, but got Unknown
				//IL_01b1: Expected Obj, but got I4
				//IL_01d6: Expected Obj, but got I
				//IL_01e6: Expected Obj, but got I
				//IL_01f6: Expected Obj, but got I
				//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0204: Expected Obj, but got Unknown
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0212: Expected Obj, but got Unknown
				//IL_0255: Expected I, but got Obj
				//IL_026b: Expected Obj, but got I
				//IL_02e2: Expected Obj, but got I4
				//IL_0296: Expected I, but got Obj
				//IL_0360: Unknown result type (might be due to invalid IL or missing references)
				//IL_0365: Expected Obj, but got Unknown
				//IL_0384: Expected I4, but got Obj
				//IL_037f: Expected native int or pointer, but got VT
				//IL_0399: Expected Obj, but got I
				//IL_0394: Expected native int or pointer, but got VT
				//IL_039f: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a4: Expected Obj, but got Unknown
				//IL_03b5: Expected Obj, but got VT
				//IL_03da: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 32);
				bool flag = (byte)(obj + 8) != 0;
				((bool*)(flag ? 1 : 0))->m_value = false;
				object obj2 = obj + 16;
				obj2 = 0;
				_ = 0;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj4 = default;
				object obj3 = obj4 + 8;
				obj3 = _003C_003E4__this;
				object obj5 = obj4 + 16;
				obj5 = onComplete;
				object obj6 = obj4 + 12;
				string nameFromSocialManager = ((Manager)null).GetNameFromSocialManager();
				obj6 = nameFromSocialManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23+C]");
				if ((nint)0 != 0)
				{
					nint num = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v24 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num2 = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v62 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23+C]");
					Assembly assembly = ((AppDomain)0).LoadAssembly((string)null, (Evidence)(object)currentCulture, flag);
					if ((object)assembly != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S3_v5 (Il2CppMethodInfo)+C]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S3_v6+60]");
						object obj9 = 0;
						object obj10 = obj9;
						object obj11 = obj10 & 0x1FFF;
						object obj12 = obj11 + 113696;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v160 @ S4_v7 (should have been resolved before IL gen)");
						obj = ((bool*)(flag ? 1 : 0))->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S4_v9 (Il2CppMethodInfo)+C]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S4_v10+60]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S4_v11+48]");
						object obj15 = 0;
						object obj16 = obj15 & 0x7FF;
						object obj17 = obj16 + 39195;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v78 @ S5_v7 (should have been resolved before IL gen)");
						string otherUri = ((Manager)null).FindFacebookIdFromPublicKey("/facebook/login");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Uri uri = default;
						uri.CreateThisFromUri((Uri)(object)otherUri);
						nint num5 = (nint)typeof(KilooWebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v53 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
						object obj18 = (nint)0 & (nint)0x200;
						if (obj18 != null)
						{
							nint num6 = (nint)typeof(KilooWebClient);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v76 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						IRequest request = KilooWebClient.CreateGet(uri);
						string adSpace = default;
						bool flag2 = ((FlurryVideoAdsAndroid)request).IsReady(adSpace);
						float requestMinBackOffTime = ((Manager)null).requestMinBackOffTime;
						IRequest request2 = RequestExtensions.WithKeepAlive((IRequest)flag2, requestMinBackOffTime);
						float requestMaxBackOffTime = ((Manager)null).requestMaxBackOffTime;
						IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, requestMaxBackOffTime);
						float awardsPercentageComplete = ((AwardsManager)null).GetAwardsPercentageComplete();
						Wait.Config.TimeConfig timeConfig = ((Wait.Config)request3).For(awardsPercentageComplete);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint method_ptr = 0;
						WebClient.RequestCompleteHandler requestCompleteHandler = default;
						((Delegate)requestCompleteHandler).method_ptr = method_ptr;
						((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass112_0._003CRequestFacebookLogin_003Eb__0);
						object obj19 = requestCompleteHandler + 16;
						obj19 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj2 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
						System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
						object obj20 = this + 12;
						Coroutine coroutine = RequestExtensions.SendAsync((IRequest)timeConfig, requestCompleteHandler, sendOptions);
						obj20 = coroutine;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23+10]");
				((Action<FacebookLoginResult>)0)(FacebookLoginResult.Failed);
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

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public Manager _003C_003E4__this;

		public string facebookId;

		public _003C_003Ec__DisplayClass113_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CRequestCreatePlayer_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected Obj, but got Unknown
			//IL_03e8: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			X509Certificate2 x509Certificate = default;
			bool flag = x509Certificate != null;
			if (flag)
			{
				bool flag2 = TrustedRoots.VerifyTrust(x509Certificate);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj4 = default;
				object obj3 = flag & obj4;
				if (obj3 != null && ResponseExtensions.IsBson((IResponse)x509Certificate))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj5 = default;
					object obj6 = default;
					if (obj5 == obj6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj8 = default;
						object obj7 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj10 = default;
						object obj9 = obj10;
					}
					else
					{
						object obj11 = default;
						object obj9 = obj11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					goto IL_03d3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj12 = default;
			FacebookLoginResult obj14 = default;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj13 = default;
				if ((nint)obj13 == 404)
				{
					obj14 = FacebookLoginResult.NotFound;
					goto IL_03d3;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int totalLength = default;
			string msg = string.ConcatArray((string[])(object)"FacebookLogin: Request failed or bad response, status: ", totalLength);
			LogWarning(msg);
			obj14 = FacebookLoginResult.Failed;
			goto IL_03d3;
			IL_03d3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager+<>c__DisplayClass113_0)+10]");
			((Action<FacebookLoginResult>)0)(obj14);
		}
	}

	private sealed class _003CRequestCreatePlayer_003Ed__113(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0334: Unknown result type (might be due to invalid IL or missing references)
				//IL_0339: Expected VT, but got Unknown
				//IL_0342: Unknown result type (might be due to invalid IL or missing references)
				//IL_0347: Expected I4, but got Unknown
				//IL_035e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0363: Expected Obj, but got Unknown
				//IL_036c: Expected Obj, but got I4
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected Obj, but got Unknown
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected Obj, but got Unknown
				//IL_03b1: Expected Obj, but got I
				//IL_03c1: Expected Obj, but got I
				//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d7: Expected Obj, but got Unknown
				//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e5: Expected Obj, but got Unknown
				//IL_03fc: Expected Obj, but got I4
				//IL_041c: Expected Obj, but got I
				//IL_042c: Expected Obj, but got I
				//IL_043c: Expected Obj, but got I
				//IL_0445: Unknown result type (might be due to invalid IL or missing references)
				//IL_044a: Expected Obj, but got Unknown
				//IL_0453: Unknown result type (might be due to invalid IL or missing references)
				//IL_0458: Expected Obj, but got Unknown
				//IL_00bc: Expected I, but got Obj
				//IL_00d2: Expected Obj, but got I
				//IL_0182: Expected I, but got Obj
				//IL_0198: Expected Obj, but got I
				//IL_0499: Expected Obj, but got I
				//IL_00fd: Expected I, but got Obj
				//IL_020f: Expected Obj, but got I4
				//IL_01c3: Expected I, but got Obj
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Expected Obj, but got Unknown
				//IL_0153: Expected Obj, but got I4
				//IL_028d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0292: Expected Obj, but got Unknown
				//IL_02b1: Expected I4, but got Obj
				//IL_02ac: Expected native int or pointer, but got VT
				//IL_02c6: Expected Obj, but got I
				//IL_02c1: Expected native int or pointer, but got VT
				//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d1: Expected Obj, but got Unknown
				//IL_02e2: Expected Obj, but got VT
				//IL_0307: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 32);
				bool flag = (byte)(obj + 8) != 0;
				((bool*)(flag ? 1 : 0))->m_value = false;
				object obj2 = obj + 16;
				obj2 = 0;
				_ = 0;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj4 = default;
				object obj3 = obj4 + 8;
				obj3 = _003C_003E4__this;
				object obj5 = obj4 + 12;
				string nameFromSocialManager = ((Manager)null).GetNameFromSocialManager();
				obj5 = nameFromSocialManager;
				((bool*)(flag ? 1 : 0))->m_value = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23+C]");
				if ((nint)0 != 0)
				{
					nint num = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v54 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num2 = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v62 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23+C]");
					Assembly assembly = ((AppDomain)0).LoadAssembly((string)null, (Evidence)(object)currentCulture, flag);
					if (!((bool*)(flag ? 1 : 0))->m_value)
					{
						object obj7 = obj4 + 12;
						obj7 = 0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S3_v4 (Il2CppMethodInfo)+C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S3_v5+60]");
				object obj9 = 0;
				object obj10 = obj9;
				object obj11 = obj10 & 0x1FFF;
				object obj12 = obj11 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v154 @ S4_v6 (should have been resolved before IL gen)");
				obj = ((bool*)(flag ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S4_v8 (Il2CppMethodInfo)+C]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S4_v9+60]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S4_v10+48]");
				object obj15 = 0;
				object obj16 = obj15 & 0x7FF;
				object obj17 = obj16 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S5_v7 (should have been resolved before IL gen)");
				string otherUri = ((Manager)null).FindFacebookIdFromPublicKey("/players/createplayer");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Uri uri = default;
				uri.CreateThisFromUri((Uri)(object)otherUri);
				nint num5 = (nint)typeof(KilooWebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v46 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num6 = (nint)typeof(KilooWebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v69 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				IRequest request = KilooWebClient.CreateGet(uri);
				string adSpace = default;
				bool flag2 = ((FlurryVideoAdsAndroid)request).IsReady(adSpace);
				float requestMinBackOffTime = ((Manager)null).requestMinBackOffTime;
				IRequest request2 = RequestExtensions.WithKeepAlive((IRequest)flag2, requestMinBackOffTime);
				float requestMaxBackOffTime = ((Manager)null).requestMaxBackOffTime;
				IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, requestMaxBackOffTime);
				float awardsPercentageComplete = ((AwardsManager)null).GetAwardsPercentageComplete();
				Wait.Config.TimeConfig timeConfig = ((Wait.Config)request3).For(awardsPercentageComplete);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				WebClient.RequestCompleteHandler requestCompleteHandler = default;
				((Delegate)requestCompleteHandler).method_ptr = method_ptr;
				((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass113_0._003CRequestCreatePlayer_003Eb__0);
				object obj19 = requestCompleteHandler + 16;
				obj19 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj2 != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
				System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
				object obj20 = this + 12;
				Coroutine coroutine = RequestExtensions.SendAsync((IRequest)timeConfig, requestCompleteHandler, sendOptions);
				obj20 = coroutine;
				_003C_003E1__state = 1;
				return 1;
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

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public Manager _003C_003E4__this;

		public string facebookId;

		public _003C_003Ec__DisplayClass114_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CRequestFacebookRegister_003Eb__0(IRequest request, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			X509Certificate2 x509Certificate = default;
			bool flag = x509Certificate != null;
			if (flag)
			{
				bool flag2 = TrustedRoots.VerifyTrust(x509Certificate);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj4 = default;
				object obj3 = flag & obj4;
				if (obj3 != null && ResponseExtensions.IsBson((IResponse)x509Certificate))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj5 = default;
					object obj6 = default;
					if (obj5 == obj6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj8 = default;
						object obj7 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj10 = default;
						object obj9 = obj10;
					}
					else
					{
						object obj11 = default;
						object obj9 = obj11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int totalLength = default;
			string msg = string.ConcatArray((string[])(object)"CreatePlayer: Request failed or bad response, status: ", totalLength);
			LogWarning(msg);
		}
	}

	private sealed class _003CRequestFacebookRegister_003Ed__114(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Manager _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0479: Unknown result type (might be due to invalid IL or missing references)
				//IL_047e: Expected VT, but got Unknown
				//IL_0487: Unknown result type (might be due to invalid IL or missing references)
				//IL_048c: Expected I4, but got Unknown
				//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a8: Expected Obj, but got Unknown
				//IL_04b1: Expected Obj, but got I4
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Expected Obj, but got Unknown
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Expected Obj, but got Unknown
				//IL_00dc: Expected I, but got Obj
				//IL_00f2: Expected Obj, but got I
				//IL_050d: Expected Obj, but got I
				//IL_011d: Expected I, but got Obj
				//IL_017c: Expected Obj, but got I
				//IL_018c: Expected Obj, but got I
				//IL_019d: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a2: Expected Obj, but got Unknown
				//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b0: Expected Obj, but got Unknown
				//IL_01d0: Expected Obj, but got I
				//IL_01e0: Expected Obj, but got I
				//IL_01f0: Expected Obj, but got I
				//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fe: Expected Obj, but got Unknown
				//IL_0207: Unknown result type (might be due to invalid IL or missing references)
				//IL_020c: Expected Obj, but got Unknown
				//IL_0223: Expected Obj, but got I4
				//IL_0248: Expected Obj, but got I
				//IL_0258: Expected Obj, but got I
				//IL_0268: Expected Obj, but got I
				//IL_0271: Unknown result type (might be due to invalid IL or missing references)
				//IL_0276: Expected Obj, but got Unknown
				//IL_027f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0284: Expected Obj, but got Unknown
				//IL_02c7: Expected I, but got Obj
				//IL_02dd: Expected Obj, but got I
				//IL_0354: Expected Obj, but got I4
				//IL_0308: Expected I, but got Obj
				//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03d7: Expected Obj, but got Unknown
				//IL_03f6: Expected I4, but got Obj
				//IL_03f1: Expected native int or pointer, but got VT
				//IL_040b: Expected Obj, but got I
				//IL_0406: Expected native int or pointer, but got VT
				//IL_0411: Unknown result type (might be due to invalid IL or missing references)
				//IL_0416: Expected Obj, but got Unknown
				//IL_0427: Expected Obj, but got VT
				//IL_044c: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 32);
				bool flag = (byte)(obj + 8) != 0;
				((bool*)(flag ? 1 : 0))->m_value = false;
				object obj2 = obj + 16;
				obj2 = 0;
				_ = 0;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj4 = default;
				object obj3 = obj4 + 8;
				obj3 = _003C_003E4__this;
				RanksData ranksData = TopRunSave.ranksData;
				object obj5 = obj4 + 12;
				string nameFromSocialManager = ((Manager)null).GetNameFromSocialManager();
				obj5 = nameFromSocialManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v26 (TopRun.Internal.RanksData)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23+C]");
					if ((nint)0 != 0)
					{
						nint num = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v21 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num2 = (nint)typeof(CultureInfo);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v61 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CultureInfo currentCulture = CultureInfo.CurrentCulture;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23+C]");
						Assembly assembly = ((AppDomain)0).LoadAssembly((string)null, (Evidence)(object)currentCulture, flag);
						if ((object)assembly != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S3_v5 (Il2CppMethodInfo)+C]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S3_v6+60]");
							object obj8 = 0;
							object obj9 = obj8;
							object obj10 = obj9 & 0x1FFF;
							object obj11 = obj10 + 113696;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159 @ S4_v7 (should have been resolved before IL gen)");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S4_v9 (Il2CppMethodInfo)+C]");
							object obj12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S4_v10+60]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S4_v11+48]");
							object obj14 = 0;
							object obj15 = obj14 & 0x7FF;
							object obj16 = obj15 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v176 @ S5_v7 (should have been resolved before IL gen)");
							obj = ((bool*)(flag ? 1 : 0))->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S4_v14 (Il2CppMethodInfo)+C]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S4_v15+60]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S4_v16+48]");
							object obj19 = 0;
							object obj20 = obj19 & 0x7FF;
							object obj21 = obj20 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v66 @ S5_v11 (should have been resolved before IL gen)");
							string otherUri = ((Manager)null).FindFacebookIdFromPublicKey("/facebook/register");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							Uri uri = default;
							uri.CreateThisFromUri((Uri)(object)otherUri);
							nint num6 = (nint)typeof(KilooWebClient);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v57 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
							object obj22 = (nint)0 & (nint)0x200;
							if (obj22 != null)
							{
								nint num7 = (nint)typeof(KilooWebClient);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v80 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							IRequest request = KilooWebClient.CreateGet(uri);
							string adSpace = default;
							bool flag2 = ((FlurryVideoAdsAndroid)request).IsReady(adSpace);
							float requestMinBackOffTime = ((Manager)null).requestMinBackOffTime;
							IRequest request2 = RequestExtensions.WithKeepAlive((IRequest)flag2, requestMinBackOffTime);
							float requestMaxBackOffTime = ((Manager)null).requestMaxBackOffTime;
							IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, requestMaxBackOffTime);
							float awardsPercentageComplete = ((AwardsManager)null).GetAwardsPercentageComplete();
							Wait.Config.TimeConfig timeConfig = ((Wait.Config)request3).For(awardsPercentageComplete);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint method_ptr = 0;
							WebClient.RequestCompleteHandler requestCompleteHandler = default;
							((Delegate)requestCompleteHandler).method_ptr = method_ptr;
							((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass114_0._003CRequestFacebookRegister_003Eb__0);
							object obj23 = requestCompleteHandler + 16;
							obj23 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj2 != 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
							System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
							object obj24 = this + 12;
							Coroutine coroutine = RequestExtensions.SendAsync((IRequest)timeConfig, requestCompleteHandler, sendOptions);
							obj24 = coroutine;
							_003C_003E1__state = 1;
							return 1;
						}
					}
				}
				LogWarning("FacebookRegister: Cannot register now, missing private key and/or facebook id.");
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

	private Dictionary<string, Player> _currentTournamentPlayers;

	private Rank[] _currentTournamentRanks;

	private bool _fetchingNewTournament;

	private bool _isRefreshingTournament;

	private bool _isRefreshPending;

	private long _lastFriendsUpdate;

	private long _lastTournamentUpdate;

	private IList<string> _lastTournamentUpdateParticipantsPublicKeys;

	private bool _pauseRefreshing;

	private EventHandler<TournamentChangedEventArgs> m_tournamentChanged;

	private EventHandler<PlayerInfoChangedEventArgs> m_playerInfoChanged;

	private IRank rank__BackingField;

	private ITournament tournament__BackingField;

	private ManagerData managerData
	{
		get
		{
			//IL_00e1: Expected Obj, but got I4
			//IL_000e: Expected Obj, but got I4
			//IL_00f6: Expected Obj, but got I
			//IL_0028: Expected Obj, but got I
			//IL_006e: Expected Obj, but got I
			//IL_0096: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager)+AC]");
			ManagerData result;
			if ((nint)0 != 0)
			{
				result = (ManagerData)(-1);
				int num2 = default;
				int num3 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager)+AC]");
					object obj = 0;
					int num = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5+C]");
					if ((nint)num >= (nint)0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager)+AC]");
					TopRunCell topRunCell = ((List<TopRunCell>)0).get_Item(num2);
					if (topRunCell.cellType == TopRunCellType.PLAYER)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager)+AC]");
						TopRunCell topRunCell2 = ((List<TopRunCell>)0).get_Item(num2);
						if (~(topRunCell2.isLocalUser ? 1u : 0u) == 0)
						{
							result = (ManagerData)num2;
						}
					}
					num2 = num3 + 1;
				}
			}
			else
			{
				result = (ManagerData)(-1);
			}
			return result;
		}
	}

	private RanksData rankData
	{
		get
		{
			return TopRunSave.ranksData;
		}
		set
		{
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected Obj, but got Unknown
			//IL_00c1: Expected Obj, but got I4
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected Obj, but got Unknown
			//IL_00de: Expected Obj, but got I4
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected Obj, but got Unknown
			//IL_00fb: Expected Obj, but got I4
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected Obj, but got Unknown
			//IL_013b: Expected Obj, but got I
			//IL_0017: Expected Obj, but got I4
			//IL_0017: Expected Obj, but got I4
			//IL_0029: Expected I, but got Obj
			//IL_003f: Expected Obj, but got I
			//IL_016b: Expected Obj, but got F4
			//IL_0180: Expected Obj, but got F4
			//IL_01a2: Expected Obj, but got I
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected Obj, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected Obj, but got Unknown
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Expected Obj, but got Unknown
			//IL_006a: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 36;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 12;
			obj4 = 0;
			_ = 0;
			object obj5 = this + 156;
			obj5 = value;
			string tag = ((Component)(object)value).tag;
			bool isInstanced = UIScreenController.IsInstanced;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v16 (System.Boolean)+18]");
			int layer = ((GameObject)0).layer;
			Coroutine coroutine = ((Manager)(object)tag).DownloadFacebookImage((string)layer, (Action<Texture2D>)31);
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			obj3 = 9f;
			_ = -165f;
			_ = 0f;
			obj4 = 13f;
			_ = 13f;
			_ = 13f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager)+9C]");
			((CharacterScreenController)0).SetFreeze(0f);
			object obj7 = obj2 + 48;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj8 = obj2 + 60;
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			object obj9 = obj2 + 72;
			obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
	}

	private PlayerIdsData playerIdData => TopRunSave.playerIdsData;

	public string country
	{
		get
		{
			return TopRunSave.lastTopRunResultAwardedID;
		}
		set
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_playerInfoChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 52;
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

	public int multiplier
	{
		get
		{
			//IL_009c: Expected I4, but got Obj
			//IL_0084: Expected I4, but got Obj
			RanksData ranksData = TopRunSave.ranksData;
			string tournamentId = ranksData.tournamentId;
			if (ranksData.tournamentId == null || tournamentId.m_stringLength == 0)
			{
				TopRunEventsHandler instance = TopRunEventsHandler.instance;
				List<Country> listOfCountries = ((CountryManager)(object)instance).GetListOfCountries();
				((Manager)null).pauseRefreshing = (byte)(int)listOfCountries != 0;
			}
			RanksData ranksData2 = TopRunSave.ranksData;
			return (int)ranksData2.tournamentId;
		}
	}

	public int highScore
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return SellConsumable.allowSellConsumablesDuringRun ? 1 : 0;
		}
	}

	public bool canSubmitScore => (byte)PlayerSave.bragScoreThreshold != 0;

	public bool isRefreshing
	{
		get
		{
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected Obj, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected Obj, but got Unknown
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Expected Obj, but got Unknown
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected Obj, but got Unknown
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0244: Expected Obj, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected Obj, but got Unknown
			//IL_0062: Expected I, but got Obj
			//IL_0078: Expected Obj, but got I
			//IL_0289: Expected Obj, but got VT
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected Obj, but got Unknown
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Expected Obj, but got Unknown
			//IL_00a3: Expected I, but got Obj
			//IL_0138: Expected I4, but got Obj
			//IL_0138: Expected Obj, but got I
			//IL_0170: Expected I, but got Obj
			//IL_0186: Expected Obj, but got I
			//IL_030d: Expected Obj, but got I
			//IL_0315: Expected Obj, but got VT
			//IL_0332: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Expected Obj, but got Unknown
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Expected Obj, but got Unknown
			//IL_01b1: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 40;
			object obj3 = obj2 + 32;
			object obj4 = obj2 + 24;
			object obj5 = obj2 + 16;
			object obj6 = obj2 + 8;
			RanksData ranksData = TopRunSave.ranksData;
			Dictionary<string, Rank> ranks = ranksData.ranks;
			bool result;
			if (ranksData.ranks != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+5C]");
				if ((nint)0 != 0)
				{
					result = false;
				}
				else
				{
					object obj7 = ranksData.ranks - -64;
					DateTime today = CDateTime.Today;
					nint num = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v32 (Il2CppClass<System.DateTime>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num2 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v69 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj4 = today;
					obj5 = obj7;
					obj3 = obj4;
					obj = obj5;
					object obj9 = obj3 & 0x3FFFFFFFFFFFFFFFL;
					object obj10 = obj & 0x3FFFFFFFFFFFFFFFL;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
					{
						result = false;
					}
					else
					{
						RanksData ranksData2 = TopRunSave.ranksData;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v45 (TopRun.Internal.RanksData)+1C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v45 (TopRun.Internal.RanksData)+1C]");
							if (((string)0).get_Chars((int)ranks.entries) != '\0')
							{
								RanksData ranksData3 = TopRunSave.ranksData;
								nint num3 = (nint)typeof(DateTime);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v55 (Il2CppClass<System.DateTime>)+BA]");
								object obj11 = (nint)0 & (nint)0x200;
								if (obj11 != null)
								{
									nint num4 = (nint)typeof(DateTime);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v64 (Il2CppClass<System.DateTime>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v52 (TopRun.Internal.RanksData)+28]");
								obj6 = 0;
								obj2 = today;
								obj3 = obj6;
								obj = obj2;
								object obj12 = obj3 & 0x3FFFFFFFFFFFFFFFL;
								object obj13 = obj & 0x3FFFFFFFFFFFFFFFL;
								bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13);
								result = false;
								if (flag)
								{
									goto IL_036e;
								}
							}
						}
						result = true;
					}
				}
			}
			else
			{
				result = false;
			}
			goto IL_036e;
			IL_036e:
			return result;
		}
	}

	public bool pauseRefreshing
	{
		get
		{
			if (~(_isRefreshingTournament ? 1u : 0u) == 0)
			{
				return true;
			}
			return _isRefreshPending;
		}
		set
		{
			//IL_001b: Expected Obj, but got I4
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected Obj, but got Unknown
			//IL_0067: Expected Obj, but got I4
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected Obj, but got Unknown
			RanksData ranksData = TopRunSave.ranksData;
			if (!(ranksData.tournamentId != (string)value))
			{
				RanksData ranksData2 = TopRunSave.ranksData;
				object obj = ranksData2 + 8;
				obj = value;
				RanksData ranksData3 = TopRunSave.ranksData;
				object obj2 = ranksData3 + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			}
		}
	}

	public bool hasFetchedTournament => _pauseRefreshing;

	public int score
	{
		get
		{
			RanksData ranksData = TopRunSave.ranksData;
			Dictionary<string, Rank> ranks = ranksData.ranks;
			if (ranksData.ranks != null)
			{
				int[] buckets = ranks.buckets;
				bool flag;
				if (ranks.buckets != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v7 (System.Int32[])+8]");
					flag = (nint)0 == 0;
				}
				else
				{
					flag = true;
				}
				return (flag ? 1 : 0) ^ 1;
			}
			return 0;
		}
	}

	public IRank rank
	{
		get
		{
			//IL_007b: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I
			RanksData ranksData = TopRunSave.ranksData;
			Dictionary<string, Rank> ranks = ranksData.ranks;
			if (ranksData.ranks != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
				if ((nint)0 >= (nint)1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
					return (IRank)0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+58]");
				if ((nint)0 > (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v3 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+58]");
					return (IRank)0;
				}
				return null;
			}
			return null;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			_pauseRefreshing = flag;
		}
	}

	public DateTime nextTournamentFetchTime
	{
		get
		{
			//IL_0026: Expected Obj, but got I4
			//IL_0026: Expected Obj, but got I4
			//IL_0040: Expected Obj, but got VT
			int num = ((Manager)null).facebookFriendPublicKeyExpirySecondsMax;
			int num2 = ((Manager)null).maxFriendPublicKeyRequestsToSend;
			bool boolean = ((ObfuscatedMemory)num).GetBoolean((string)num2);
			DateTime today = CDateTime.Today;
			object obj = today;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
			DateTime result = default;
			return result;
		}
	}

	public ITournament tournament
	{
		get
		{
			return (ITournament)rank__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 56;
			obj = value;
		}
	}

	private float requestTimeout
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager)+A4]");
			float num = 0f * 2f;
			float num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.Internal.Manager)+A0]");
			return num2 + 0f;
		}
	}

	private float requestMinBackOffTime
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
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
			return (float)((IConvertible)saveDataPath).ToDouble((IFormatProvider)(object)"toprun_request_timeout");
		}
	}

	private float requestMaxBackOffTime
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
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
			return (float)((IConvertible)saveDataPath).ToDouble((IFormatProvider)(object)"toprun_request_min_back_off_time");
		}
	}

	private int facebookFriendPublicKeyExpirySecondsMin
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)tournament__BackingField;
		}
	}

	private int facebookFriendPublicKeyExpirySecondsMax
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
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
			return (int)((OnlineSettings)(object)saveDataPath).GetValue("toprun_facebook_friend_public_key_expiry_min", 86400u);
		}
	}

	private int maxFriendPublicKeyRequestsToSend
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
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
			return (int)((OnlineSettings)(object)saveDataPath).GetValue("toprun_facebook_friend_public_key_expiry_max", 604800u);
		}
	}

	public event EventHandler<TournamentChangedEventArgs> tournamentChanged
	{
		add
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected Obj, but got Unknown
			//IL_0053: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 4;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Enum obj3 = default;
			IFormatProvider provider = default;
			if (obj3.System_002EIConvertible_002EToBoolean(provider))
			{
				AddCurrentTournamentParticipantsToCurrentTournamentPlayers();
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_tournamentChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 48;
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

	public event EventHandler<PlayerInfoChangedEventArgs> playerInfoChanged
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_tournamentChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 48;
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
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_playerInfoChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 52;
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

	public Manager()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		_ = 2;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<TopRunCell> list = default;
		list._002Ector();
		object obj = this + 172;
		obj = list;
		((UpgradeScreen)this).Start();
	}

	private void AppHasRefreshed(RefreshType refreshType)
	{
		//IL_0009: Expected Obj, but got I4
		TopRunSave.playerIdsData = (PlayerIdsData)refreshType;
	}

	private DateTime GetRandomisedPlayerIdExpiry()
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got VT
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00c7: Expected VT, but got I8
		//IL_0013: Expected I, but got Obj
		DateTime utcNow = CDateTime.UtcNow;
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v20 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = utcNow;
		string text = (string)(obj2 + 8);
		text = (string)obj2;
		return (DateTime)TimeUtility.RFC1123StringToUnixTime(text);
	}

	private unsafe void InitializeCurrentTournamentPlayers()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02d0: Expected Obj, but got I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Ref, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_037d: Expected Obj, but got I4
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_0200: Expected Obj, but got I
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 40;
		obj5 = obj;
		_ = -1;
		object obj6 = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = default;
		obj6 = obj7;
		ref _0021_00210 reference = ref *(_0021_00210*)(obj2 + 24);
		string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
		_0021_00210 flag = default;
		FlagsHelper.Set<T>(ref System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (T)flag);
		obj4 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22 (T&)+8]");
		_ = 0;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj13 = default;
		object obj15 = default;
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
				object obj10 = obj9 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
					object obj12 = obj13 << 32;
					object obj14 = obj15 | obj12;
					obj2 = 0;
					_ = 0;
					obj3 = obj14;
					reference = ref *(_0021_00210*)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					reference = ref *(_0021_00210*)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					object obj16 = obj9 + 16;
					obj16 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22 (T&)+8]");
					_ = 0;
				}
			}
		}
		object obj17 = obj5 + 4;
		object obj18 = obj17 + 1;
		obj17 = obj18;
		object obj19 = obj18 << 2;
		object obj20 = obj5 + obj19;
		obj20 = 126;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj5 + obj21;
			if ((nint)obj22 == 126)
			{
				object obj23 = obj5 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_03c0;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03c0;
		IL_03c0:
		AddCurrentTournamentParticipantsToCurrentTournamentPlayers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<RefreshType> action = default;
		object obj26 = action + 16;
		obj26 = this;
		AppRefreshHandler.hasRefreshed -= action;
	}

	private void AddCurrentTournamentParticipantsToCurrentTournamentPlayers()
	{
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
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
		FetchNextTournament();
		AddFacebookFriendsWithIdsToCurrentTournamentPlayers();
	}

	private unsafe void AddFacebookFriendsWithIdsToCurrentTournamentPlayers()
	{
		ref PlayerIdsData.PlayerIdData reference = ref *(PlayerIdsData.PlayerIdData*)null;
		RanksData ranksData = TopRunSave.ranksData;
		Dictionary<string, Rank> ranks = ranksData.ranks;
		if (ranksData.ranks != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
	}

	public IRank GetPlayerRank(string facebookId)
	{
		//IL_002c: Expected Obj, but got I4
		//IL_01da: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I
		//IL_003f: Expected I, but got Obj
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got I
		//IL_015b: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		if (facebookId != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}
		else
		{
			object obj = 0;
		}
		_ = 1;
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v10 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v43 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (System.Boolean)+60]");
		IRank rank = default;
		if ((nint)0 == 3)
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21 (Il2CppClass<SocialManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v39 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v26 (System.Boolean)+38]");
			if ((nint)0 != 0)
			{
				nint num5 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v29 (Il2CppClass<SocialManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v35 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj5 = rank + 20;
				bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v12 (System.Boolean)+38]");
				obj5 = 0;
			}
		}
		return rank;
	}

	public void FetchNextTournament()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		IEnumerator enumerator = ((Manager)null).RequestPlayersByFacebookIds();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 59;
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 59)
			{
				object obj11 = obj2 + 4;
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

	public void RefreshTournament()
	{
		if (~(_isRefreshingTournament ? 1u : 0u) != 0)
		{
			_isRefreshingTournament = true;
			GetMissingFacebookInfo();
		}
	}

	public void SubmitScore(int scoreToSubmit, DateTime gameStartedTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector("Collection is of a fixed size");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public unsafe IPlayer GetPlayerByPublicKey(string publicKey)
	{
		//IL_02b2: Expected Obj, but got Ref
		//IL_02bb: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0171: Expected Obj, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		ref Player reference2 = default;
		ref PlayerIdsData.PlayerIdData reference = ref System.Runtime.CompilerServices.Unsafe.As<Player, PlayerIdsData.PlayerIdData>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 4));
		reference = ref *(PlayerIdsData.PlayerIdData*)null;
		reference2 = ref *(Player*)null;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 8));
		obj = 0;
		string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
		object obj3 = default;
		IPlayer player2;
		if (((Dictionary<string, PlayerIdsData.PlayerIdData>)lastTopRunResultAwardedID.m_stringLength).TryGetValue(publicKey, out reference))
		{
			PlayerIdsData.PlayerIdData playerIdData = reference;
			if (playerIdData.publicKey != null)
			{
				if (tournament__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj2 = default;
					if (obj2 != null && _currentTournamentPlayers.TryGetValue(playerIdData.publicKey, out reference2))
					{
						Player player = reference2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
						Rank[] currentTournamentRanks = _currentTournamentRanks;
						if ((nint)obj3 < currentTournamentRanks.Length)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							object obj4 = _currentTournamentRanks + 16;
							object obj5 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v57+C]");
							string text = default;
							if (text.get_Chars(0) == '\0')
							{
								goto IL_02f7;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj6 = this + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
						object obj7 = default;
						obj6 = obj7;
						object obj8 = 0;
						object obj9 = default;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							object obj11 = default;
							object obj10 = obj11 + 12;
							object obj12 = default;
							obj10 = obj12;
							throw new ArrayTypeMismatchException();
						}
						goto IL_02f7;
					}
				}
				goto IL_023e;
			}
			player2 = null;
		}
		else
		{
			player2 = null;
		}
		goto IL_0373;
		IL_0341:
		if (player2 == null)
		{
			PlayerIdsData playerIdsData = TopRunSave.playerIdsData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
			player2 = (IPlayer)obj;
		}
		goto IL_0373;
		IL_023e:
		player2 = (IPlayer)obj;
		goto IL_0341;
		IL_0373:
		return player2;
		IL_02f7:
		Rank[] currentTournamentRanks2 = _currentTournamentRanks;
		if ((nint)obj3 >= currentTournamentRanks2.Length)
		{
			goto IL_023e;
		}
		object obj13 = _currentTournamentRanks + 16;
		object obj14 = obj3 << 2;
		object obj15 = obj13 + obj14;
		obj = obj15;
		player2 = (IPlayer)obj15;
		goto IL_0341;
	}

	internal static void ClearSavedData()
	{
		OnboardingTracking.OnApplicationQuit();
	}

	private void FirePlayerInfoChangedEvent(IPlayer player)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 60;
		obj = player;
	}

	private void FireTournamentChangedEvent(bool wasUpdated, bool didChange)
	{
		//IL_0014: Expected VT, but got I4
		//IL_0014: Expected VT, but got I4
		//IL_0014: Expected Obj, but got I4
		GameObject list = ((SpawnPool)this).InstantiatePrefab((GameObject)wasUpdated, (Vector3)0, (Quaternion)0);
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private unsafe string MakeApiURL(string apiResource)
	{
		ref Player reference = ref *(Player*)null;
		if (_currentTournamentPlayers != null)
		{
			if (_currentTournamentPlayers.TryGetValue(apiResource, out reference))
			{
				return (string)(object)reference;
			}
			return null;
		}
		return null;
	}

	private string FindFacebookIdFromPublicKey(string publicKey)
	{
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00b4: Expected I4, but got Obj
		//IL_00c5: Expected I4, but got Obj
		//IL_00c5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
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
		bool value = ((OnlineSettings)(object)saveDataPath).GetValue("toprun_base_url", (byte)(int)"https://subwaysurfers.kiloo-games.com/api/v3" != 0);
		return string.ConcatArray((string[])value, (int)publicKey);
	}

	private unsafe static TimeSpan GetClientTimeOffset(IRequest request)
	{
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected VT, but got Unknown
		//IL_030b: Expected VT, but got I4
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0353: Expected VT, but got Obj
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_000e: Expected Ref, but got VT
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_040c: Expected Obj, but got I
		//IL_0415: Expected Obj, but got VT
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_038d: Expected Obj, but got VT
		//IL_0396: Expected Obj, but got VT
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_023c: Expected I, but got Obj
		//IL_0252: Expected Obj, but got I
		//IL_01da: Expected I, but got Obj
		//IL_0061: Expected I, but got Obj
		//IL_0229: Expected VT, but got I
		//IL_014c: Expected I, but got Obj
		//IL_00a9: Expected Ref, but got VT
		//IL_027d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 8;
		DateTime? dateTime = (DateTime?)(object)(obj2 + 24);
		dateTime = (DateTime?)(object)0;
		_ = 0;
		object obj6 = obj2 + 56;
		RanksData ranksData = TopRunSave.ranksData;
		object obj7 = ranksData + 48;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v13+8]");
		_ = 0;
		dateTime = (DateTime?)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v20+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (System.Nullable`1<System.DateTime>)+8]");
		if ((nint)0 != 0)
		{
			DateTime value = ((DateTime?*)dateTime)->Value;
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v92 (Il2CppClass<System.DateTime>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v109 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = value;
			obj4 = DateTime.MinValue;
			obj = obj3;
			obj6 = obj4;
			object obj9 = obj & 0x3FFFFFFFFFFFFFFFL;
			object obj10 = obj6 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
			{
				return (TimeSpan)((DateTime?*)dateTime)->Value;
			}
		}
		RanksData ranksData2 = TopRunSave.ranksData;
		Dictionary<string, Rank> ranks = ranksData2.ranks;
		if (ranksData2.ranks == null)
		{
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v76 (Il2CppClass<System.DateTime>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v83 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (TimeSpan)DateTime.MinValue;
		}
		nint num5 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v38 (Il2CppClass<System.DateTime>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num6 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v69 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v33 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+48]");
		obj5 = 0;
		obj2 = DateTime.MinValue;
		obj = obj5;
		obj6 = obj2;
		object obj13 = obj & 0x3FFFFFFFFFFFFFFFL;
		object obj14 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v33 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+48]");
			return (TimeSpan)0;
		}
		nint num7 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v54 (Il2CppClass<System.DateTime>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num8 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v61 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (TimeSpan)DateTime.MaxValue;
	}

	private void CompleteRefreshProcess(bool isNewTournament)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		if (this.m_playerInfoChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			IManager manager = default;
			TopRunRoot.manager = manager;
			object obj = manager + 8;
			obj = isNewTournament;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	private IEnumerator RefreshTournamentCoroutine()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b3: Expected Obj, but got I4
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
		return (IEnumerator)((OnlineSettings)(object)saveDataPath).GetValue("toprun_max_facebook_public_key_requests", 20u);
	}

	private IEnumerator InProcessRefreshTournamentCoroutine()
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

	private int PropagateUnsubmittedScore()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = this;
		return num;
	}

	private void InProcessFetchNextTournament()
	{
		IEnumerator list = InProcessRefreshTournamentCoroutine();
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private IList<FacebookProfile> GetFacebookFriendsToRequestPublicKeysFor()
	{
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_0472: Expected Obj, but got I4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_048f: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_04e2: Expected Obj, but got I
		//IL_04eb: Expected Obj, but got VT
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0548: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_0567: Expected Obj, but got VT
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected Obj, but got Unknown
		//IL_05c4: Expected Obj, but got I
		//IL_017f: Expected I, but got Obj
		//IL_01fa: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_063f: Expected Obj, but got I
		//IL_0257: Expected I, but got Obj
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_0307: Expected Obj, but got I
		//IL_0323: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_0665: Expected Obj, but got I
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected Obj, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected Obj, but got Unknown
		//IL_06d5: Expected Obj, but got I4
		//IL_06f4: Expected Obj, but got I
		//IL_0364: Expected I, but got Obj
		//IL_03c0: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 120;
		object obj3 = obj2 + 112;
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 104;
		object obj6 = obj2 + 96;
		object obj7 = obj2 + 88;
		object obj8 = obj2 - -64;
		object obj9 = obj2 + 40;
		object obj10 = obj2 + 16;
		object obj11 = obj2 + 8;
		object obj12 = obj2 + 72;
		obj12 = 0;
		_ = 0;
		object obj13 = obj2 + 48;
		obj13 = 0;
		_ = 0;
		RanksData ranksData = TopRunSave.ranksData;
		Dictionary<string, Rank> ranks = ranksData.ranks;
		IList<FacebookProfile> result;
		if (ranksData.ranks != null)
		{
			RanksData ranksData2 = TopRunSave.ranksData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v44 (TopRun.Internal.RanksData)+44]");
			bool flag = (nint)0 > (nint)0;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
			result = (IList<FacebookProfile>)0;
			if (!flag2)
			{
				RanksData ranksData3 = TopRunSave.ranksData;
				object obj14 = ranksData3 + 72;
				obj4 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v24+8]");
				_ = 0;
				obj12 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				object obj15 = ranksData.ranks - -64;
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v58 (Il2CppClass<System.DateTime>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v155 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+38]");
				obj5 = 0;
				obj6 = DateTime.MinValue;
				obj3 = obj5;
				obj = obj6;
				object obj17 = obj3 & 0x3FFFFFFFFFFFFFFFL;
				object obj18 = obj & 0x3FFFFFFFFFFFFFFFL;
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
				bool flag4 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
				result = (IList<FacebookProfile>)0;
				if (!flag4)
				{
					nint num3 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v74 (Il2CppClass<System.DateTime>)+BA]");
					object obj19 = (nint)0 & (nint)0x200;
					if (obj19 != null)
					{
						nint num4 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v149 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj7 = obj15;
					obj8 = DateTime.MinValue;
					obj3 = obj7;
					obj = obj8;
					object obj20 = obj3 & 0x3FFFFFFFFFFFFFFFL;
					object obj21 = obj & 0x3FFFFFFFFFFFFFFFL;
					bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21);
					bool flag6 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
					result = (IList<FacebookProfile>)0;
					if (!flag6)
					{
						obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
						bool flag7 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
						result = (IList<FacebookProfile>)0;
						if (!flag7)
						{
							nint num5 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v100 (Il2CppClass<System.DateTime>)+BA]");
							object obj22 = (nint)0 & (nint)0x200;
							if (obj22 != null)
							{
								nint num6 = (nint)typeof(DateTime);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v145 (Il2CppClass<System.DateTime>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj9 = obj13;
							obj10 = obj15;
							obj3 = obj9;
							obj = obj10;
							object obj23 = obj3 & 0x3FFFFFFFFFFFFFFFL;
							object obj24 = obj & 0x3FFFFFFFFFFFFFFFL;
							bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24);
							bool flag9 = !flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
							result = (IList<FacebookProfile>)0;
							if (!flag9)
							{
								RanksData ranksData4 = TopRunSave.ranksData;
								_ = 0;
								RanksData ranksData5 = TopRunSave.ranksData;
								object obj25 = ranksData5 + 72;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
								obj13 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32+8]");
								bool flag10 = (nint)0 == 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
								result = (IList<FacebookProfile>)0;
								if (!flag10)
								{
									nint num7 = (nint)typeof(DateTime);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v128 (Il2CppClass<System.DateTime>)+BA]");
									object obj26 = (nint)0 & (nint)0x200;
									if (obj26 != null)
									{
										nint num8 = (nint)typeof(DateTime);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v141 (Il2CppClass<System.DateTime>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									obj11 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+38]");
									obj2 = 0;
									obj3 = obj11;
									obj = obj2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v44 (TopRun.Internal.RanksData)+44]");
									nint num9 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
									bool flag11 = num9 > 0;
									object obj27 = obj3 & 0x3FFFFFFFFFFFFFFFL;
									object obj28 = obj & 0x3FFFFFFFFFFFFFFFL;
									bool flag12 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28);
									object obj29 = flag11 & flag12;
									bool flag13 = obj29 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Rank>)+54]");
									result = (IList<FacebookProfile>)0;
									if (!flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v44 (TopRun.Internal.RanksData)+44]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v44 (TopRun.Internal.RanksData)+44]");
										result = (IList<FacebookProfile>)0;
									}
								}
							}
						}
					}
				}
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	private unsafe IList<Player> GetFacebookFriendsWithPublicKeysAsPlayers()
	{
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Ref, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected Obj, but got Unknown
		//IL_06c8: Expected Obj, but got I4
		//IL_06e8: Expected Obj, but got I
		//IL_06f8: Expected Obj, but got I
		//IL_0700: Expected I, but got Obj
		//IL_070e: Expected Obj, but got I
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected Obj, but got Unknown
		//IL_0734: Expected I, but got Obj
		//IL_074a: Expected Obj, but got I
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected VT, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected VT, but got Unknown
		//IL_0795: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_0153: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected I, but got Unknown
		//IL_019f: Expected Obj, but got I4
		//IL_05d5: Expected Obj, but got VT
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected Obj, but got Unknown
		//IL_0312: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I
		//IL_0809: Expected Obj, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01f3: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I
		//IL_0216: Expected VT, but got I4
		//IL_0224: Expected Obj, but got VT
		//IL_0231: Expected I8, but got Obj
		//IL_022c: Expected native int or pointer, but got VT
		//IL_0239: Expected native int or pointer, but got VT
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0250: Expected I8, but got VT
		//IL_024b: Expected native int or pointer, but got VT
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0278: Expected Obj, but got I8
		//IL_029b: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_02eb: Expected I8, but got I4
		//IL_0653: Expected I4, but got Obj
		//IL_0400: Expected Obj, but got VT
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected VT, but got Unknown
		//IL_039e: Expected Ref, but got VT
		//IL_03aa: Expected Obj, but got VT
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected I8, but got Unknown
		//IL_044f: Expected Obj, but got I
		//IL_045f: Expected Obj, but got I
		//IL_046f: Expected Obj, but got I
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected I, but got Unknown
		//IL_04bb: Expected Obj, but got I4
		//IL_0870: Expected Obj, but got I
		//IL_04f7: Expected Obj, but got I
		//IL_0507: Expected Obj, but got I
		//IL_0517: Expected Obj, but got I
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		object obj = default;
		ref PlayerIdsData.PlayerIdData reference = ref *(PlayerIdsData.PlayerIdData*)(obj + 48);
		reference = ref *(PlayerIdsData.PlayerIdData*)null;
		object obj2 = obj + 24;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S3_v3+60]");
		object obj4 = 0;
		nint num2 = (nint)obj4;
		object obj5 = num2 & 0x1FFF;
		object obj6 = obj5 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v137 @ S4_v12 (should have been resolved before IL gen)");
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<SocialManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v118 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime dateTime = (DateTime)(obj + 32);
		DateTime? dateTime2 = (DateTime?)(object)(obj + 8);
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Dictionary<long, List<FacebookProfile>> dictionary = default;
		if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v25 (System.Boolean)+70]");
			object obj8 = (nint)0 & (nint)1;
			if (obj8 != null)
			{
				Friend[] array = ((SocialManager)facebookDialogsSupported).FriendsSortedByCash();
				object obj9 = array + 12;
				object obj10 = 113696;
				object obj11 = default;
				object obj42 = default;
				object obj21 = default;
				object obj24 = default;
				object obj38 = default;
				List<FacebookProfile> list = default;
				for (; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9); obj11 = obj42 + 1)
				{
					object obj12 = array + 16;
					object obj13 = obj11 << 2;
					object obj14 = obj12 + obj13;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v65+20]");
					long num7;
					if ((nint)0 != 0)
					{
						string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v65+20]");
						object obj16 = 0;
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S2_v44 (Il2CppMethodInfo)+C]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S2_v45+60]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S2_v46+44]");
						object obj19 = 0;
						object obj20 = obj19 & 0x1FFF;
						num2 = (nint)(obj20 + 22691);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v139 @ S3_v17 (Il2CppMethodInfo) (should have been resolved before IL gen)");
						bool flag = (nint)obj21 <= -1;
						bool flag2 = !flag;
						obj6 = 22691;
						if (!flag2)
						{
							string lastTopRunResultAwardedID2 = TopRunSave.lastTopRunResultAwardedID;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v65+20]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							object obj23 = obj24 + 12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v65+20]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S3_v35+C]");
							obj23 = 0;
							DateTime dateTime3 = nextTournamentFetchTime;
							dateTime2 = (DateTime?)(object)0;
							_ = 0;
							obj = dateTime3;
							((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj;
							*(DateTime?*)(nint)dateTime2 = dateTime;
							((DateTime*)(nint)dateTime)->dateData = (ulong)(long)dateTime2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v23 (System.Nullable`1<System.DateTime>)+8]");
							_ = 0;
							object obj26 = obj24 + 16;
							obj26 = dateTime.dateData;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v21 (System.DateTime)+8]");
							_ = 0;
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S4_v27 (Il2CppMethodInfo)+C]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S4_v28+60]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S4_v29+48]");
							obj6 = 0;
							object obj29 = obj6 & 0x7FF;
							obj10 = obj29 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v247 @ S5_v9 (should have been resolved before IL gen)");
							num7 = 0L;
							num2 = 1;
							goto IL_03ef;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v65+20]");
					if ((nint)0 == 0)
					{
						continue;
					}
					string lastTopRunResultAwardedID3 = TopRunSave.lastTopRunResultAwardedID;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v65+20]");
					object obj30 = 0;
					int stringLength = lastTopRunResultAwardedID3.m_stringLength;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v52+8]");
					if (((Dictionary<string, PlayerIdsData.PlayerIdData>)stringLength).TryGetValue((string)0, out reference))
					{
						object obj31 = reference + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v86+8]");
						if ((nint)0 != 0)
						{
							DateTime? dateTime4 = (DateTime?)(object)(reference + 16);
							DateTime value = ((DateTime?*)dateTime4)->Value;
							obj2 = value;
							long num8 = obj2 & 0x3FFFFFFFFFFFFFFFL;
							bool flag3 = num8 != -1;
							num7 = num8;
							num2 = 0;
							if (flag3)
							{
								goto IL_03ef;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v65+20]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S1_v56+8]");
					string msg = string.ConcatArray((string[])(object)"[Friends] Friend in _playerIdData already, but without an expiry! friend.fbProfile.id: ", 0);
					LogWarning(msg);
					num2 = 0;
					continue;
					IL_03ef:
					DateTime today = CDateTime.Today;
					obj2 = today;
					object obj33 = obj2 & 0x3FFFFFFFFFFFFFFFL;
					if (num7 < (long)obj33)
					{
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S2_v33 (Il2CppMethodInfo)+C]");
						object obj34 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S2_v34+60]");
						object obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S2_v35+44]");
						object obj36 = 0;
						object obj37 = obj36 & 0x7F;
						num2 = (nint)(obj37 + 43347);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v139 @ S3_v17 (Il2CppMethodInfo) (should have been resolved before IL gen)");
						bool flag4 = (nint)obj38 <= -1;
						bool flag5 = !flag4;
						obj6 = 43347;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							list._002Ector();
							nint num10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S4_v19 (Il2CppMethodInfo)+C]");
							object obj39 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S4_v20+60]");
							object obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S4_v21+48]");
							obj6 = 0;
							object obj41 = obj6 & 0xF;
							obj10 = obj41 + 43491;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v247 @ S5_v9 (should have been resolved before IL gen)");
							num2 = 1;
						}
						List<FacebookProfile> list2 = dictionary.get_Item(num7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v65+20]");
						list2.Add((FacebookProfile)0);
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<FacebookProfile> list3 = default;
		list3._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
		IEnumerable<long> source = default;
		List<long> list4 = Enumerable.ToList(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA5");
		int num11 = 0;
		object obj43 = default;
		object obj45 = default;
		while (true)
		{
			int num12 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v33 (System.Collections.Generic.List`1<System.Int64>)+C]");
			if ((nint)num12 >= (nint)0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			IEnumerator enumerator = ((Manager)null).RefreshTournamentCoroutine();
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj43) >= System.Runtime.CompilerServices.Unsafe.As<IEnumerator, UIntPtr>(ref enumerator))
			{
				break;
			}
			long num13 = list4.get_Item(num11);
			DateTime today2 = CDateTime.Today;
			obj2 = today2;
			object obj44 = obj2 & 0x3FFFFFFFFFFFFFFFL;
			if (num13 >= (long)obj44)
			{
				break;
			}
			long key = list4.get_Item(num11);
			List<FacebookProfile> source2 = dictionary.get_Item(key);
			IEnumerator enumerator2 = ((Manager)null).RefreshTournamentCoroutine();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int count = (object)enumerator2 - obj45;
			IEnumerable<_0021_00210> values = (IEnumerable<_0021_00210>)Enumerable.TakeIterator<TSource>((IEnumerable<TSource>)source2, count);
			bool flag6 = Kiloo.Common.Extensions.CollectionExtensions.AddRangeDistinct(list3, (IEnumerable<FacebookProfile>)values);
			int num14 = num11 + 1;
			num11 = num14;
		}
		return (IList<Player>)list3;
	}

	private unsafe IEnumerator RequestPlayersByFacebookIds()
	{
		//IL_0221: Expected I, but got Obj
		//IL_0237: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00ef: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01d6: Expected Obj, but got I
		ref PlayerIdsData.PlayerIdData reference = ref *(PlayerIdsData.PlayerIdData*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Player> list = default;
		list._002Ector();
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v56 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (System.Boolean)+70]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				Friend[] array = ((SocialManager)facebookDialogsSupported).FriendsSortedByCash();
				object obj3 = array + 12;
				object obj4 = 0;
				Player player = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					object obj5 = array + 16;
					object obj6 = obj4 << 2;
					object obj7 = obj5 + obj6;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v36+20]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v36+20]");
					if ((nint)0 != 0)
					{
						string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
						int stringLength = lastTopRunResultAwardedID.m_stringLength;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v37+8]");
						if (((Dictionary<string, PlayerIdsData.PlayerIdData>)stringLength).TryGetValue((string)0, out reference))
						{
							PlayerIdsData.PlayerIdData playerIdData = reference;
							if (playerIdData.publicKey != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								object obj10 = player + 8;
								PlayerIdsData.PlayerIdData playerIdData2 = reference;
								obj10 = playerIdData2.publicKey;
								object obj11 = player + 20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v36+20]");
								obj11 = 0;
								player.isFriend__BackingField = true;
								list.Add(player);
							}
						}
					}
					object obj12 = obj4 + 1;
					obj4 = obj12;
				}
			}
		}
		return (IEnumerator)list;
	}

	private bool HandleFindMatchedPlayersResponse(IRequest request, ParticipantSelector participantSelector, ParticipantSetter participantSetter, TimestampSetter timestampSetter)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		object obj3 = participantSelector & 1;
		obj = obj3;
		_ = 0;
		obj2 = request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		bool result = default;
		return result;
	}

	private IEnumerator RequestFindMatchedPlayers()
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

	private int GetAmountOfChallengersToRequest()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = this;
		return num;
	}

	private IEnumerator RequestFindMatchedPlayersByCurrentScore()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected Obj, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_013a: Expected I, but got Obj
		//IL_0150: Expected Obj, but got I
		//IL_01c7: Expected Obj, but got I8
		//IL_01d8: Expected Obj, but got VT
		//IL_017b: Expected I, but got Obj
		//IL_01ff: Expected Obj, but got I8
		//IL_020d: Expected I, but got Obj
		//IL_0223: Expected Obj, but got I
		//IL_075f: Invalid comparison between Obj and F8
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_024e: Expected I, but got Obj
		//IL_07a6: Invalid comparison between Obj and F8
		//IL_033d: Expected I, but got Obj
		//IL_0353: Expected Obj, but got I
		//IL_02e6: Expected I, but got Obj
		//IL_03d0: Expected Obj, but got I4
		//IL_037e: Expected I, but got Obj
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_049e: Expected Obj, but got I4
		//IL_055a: Expected Obj, but got I
		//IL_0616: Expected Obj, but got I4
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_083f: Expected Obj, but got I4
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		string text = (string)(obj2 + 24);
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		IEnumerator result;
		uint value;
		uint value2;
		object obj17;
		if (tournament__BackingField != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj6 = default;
			if (obj6 != null)
			{
				result = null;
			}
			else
			{
				nint num = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v28 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v171 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath = OnlineSettings.GetSaveDataPath();
				value = ((OnlineSettings)(object)saveDataPath).GetValue("toprun_challengers_amount", 0u);
				if ((int)value > 0)
				{
					RanksData ranksData = TopRunSave.ranksData;
					Dictionary<string, Rank> ranks = ranksData.ranks;
					if (ranksData.ranks != null)
					{
						result = null;
						if (ranks.version != 0)
						{
							goto IL_06e1;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
					nint num3 = (nint)typeof(TimeUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v44 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num4 = (nint)typeof(TimeUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v166 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj9 = default;
					obj3 = obj9;
					text = (string)obj3;
					long num5 = TimeUtility.RFC1123StringToUnixTime(text);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
					object obj10 = default;
					obj4 = obj10;
					text = (string)obj4;
					long num6 = TimeUtility.RFC1123StringToUnixTime(text);
					object obj11 = num6 - num5;
					DateTime today = CDateTime.Today;
					obj2 = today;
					text = (string)obj2;
					long num7 = TimeUtility.RFC1123StringToUnixTime(text);
					object obj12 = num7 - num5;
					nint num8 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v40 (Il2CppClass<Info.OnlineSettings>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num9 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v109 (Il2CppClass<Info.OnlineSettings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj14 = obj12 / obj11;
					string saveDataPath2 = OnlineSettings.GetSaveDataPath();
					double num10 = ((IConvertible)saveDataPath2).ToDouble((IFormatProvider)(object)"toprun_challengers_period_normalized_start");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num10))
					{
						result = null;
					}
					else
					{
						nint num11 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v66 (Il2CppClass<Info.OnlineSettings>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num12 = (nint)typeof(OnlineSettings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v161 (Il2CppClass<Info.OnlineSettings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string saveDataPath3 = OnlineSettings.GetSaveDataPath();
						double num13 = ((IConvertible)saveDataPath3).ToDouble((IFormatProvider)(object)"toprun_challengers_period_normalized_end");
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num13))
						{
							nint num14 = (nint)typeof(OnlineSettings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v73 (Il2CppClass<Info.OnlineSettings>)+BA]");
							object obj16 = (nint)0 & (nint)0x200;
							if (obj16 != null)
							{
								nint num15 = (nint)typeof(OnlineSettings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v156 (Il2CppClass<Info.OnlineSettings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string saveDataPath4 = OnlineSettings.GetSaveDataPath();
							value2 = ((OnlineSettings)(object)saveDataPath4).GetValue("toprun_challengers_placement_requirement", 4u);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							obj17 = 1;
							object obj18 = default;
							object obj19 = default;
							object obj20 = default;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								if (obj18 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
									{
										object obj21 = obj17 + 1;
										obj17 = obj21;
										continue;
									}
									object obj22 = obj5 + 4;
									object obj23 = obj22 + 1;
									obj22 = obj23;
									object obj24 = obj23 << 2;
									object obj25 = obj5 + obj24;
									obj25 = 292;
									break;
								}
								object obj26 = obj5 + 4;
								object obj27 = obj26 + 1;
								obj26 = obj27;
								object obj28 = obj27 << 2;
								object obj29 = obj5 + obj28;
								obj29 = 292;
								break;
							}
							object obj30 = default;
							if (obj30 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18+4]");
							if ((nint)0 != -1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18+4]");
								object obj31 = (nint)0 << 2;
								object obj32 = obj5 + obj31;
								if ((nint)obj32 == 292)
								{
									object obj33 = obj5 + 4;
									if ((nint)obj33 > -1)
									{
										object obj34 = obj33 + -1;
										obj33 = obj34;
									}
									goto IL_0875;
								}
							}
							object obj35 = default;
							if (obj35 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
							}
							goto IL_0875;
						}
						result = null;
					}
				}
				else
				{
					result = null;
				}
			}
		}
		else
		{
			result = null;
		}
		goto IL_06e1;
		IL_0875:
		result = (((nint)obj17 <= (int)value2) ? ((IEnumerator)value) : null);
		goto IL_06e1;
		IL_06e1:
		return result;
	}

	private unsafe void GetMissingFacebookInfo()
	{
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected VT, but got Unknown
		//IL_021f: Expected Obj, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005e: Expected Obj, but got I4
		//IL_008c: Expected Obj, but got I
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_00fb: Expected I, but got Obj
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_01d8: Expected I4, but got Obj
		//IL_01d3: Expected native int or pointer, but got VT
		//IL_01ed: Expected Obj, but got I
		//IL_01e8: Expected native int or pointer, but got VT
		//IL_01fe: Expected Obj, but got VT
		object obj = default;
		WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
		obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = this;
		bool flag;
		if (multiplier != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (System.Int32)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			LogWarning("FetchNextTournament: Country must be set first");
			return;
		}
		object obj4 = obj3 + 12;
		int num = multiplier;
		obj4 = num;
		string format = ((Manager)null).FindFacebookIdFromPublicKey("/tournaments/getlatesttournamentidbycountry");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+C]");
		string otherUri = string.Format((IFormatProvider)(object)"{0}?Country={1}", format, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)(object)otherUri);
		nint num2 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v32 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v42 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IRequest request = KilooWebClient.CreatePut(uri);
		float keepAlive = ((Manager)null).requestMinBackOffTime;
		IRequest request2 = RequestExtensions.WithKeepAlive(request, keepAlive);
		float maxBackOffTime = ((Manager)null).requestMaxBackOffTime;
		IRequest request3 = RequestExtensions.WithMaxBackOffTime(request2, maxBackOffTime);
		float awardsPercentageComplete = ((AwardsManager)null).GetAwardsPercentageComplete();
		Wait.Config.TimeConfig timeConfig = ((Wait.Config)request3).For(awardsPercentageComplete);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		WebClient.RequestCompleteHandler requestCompleteHandler = default;
		((Delegate)requestCompleteHandler).method_ptr = method_ptr;
		((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass83_0._003CInProcessFetchNextTournament_003Eb__0);
		object obj6 = requestCompleteHandler + 16;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
		Coroutine coroutine = RequestExtensions.SendAsync((IRequest)timeConfig, requestCompleteHandler, sendOptions);
	}

	private IEnumerator GetMissingFacebookInfoCoroutine()
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

	private bool IsFacebookIDInvalid(string facebookId)
	{
		//IL_0041: Expected Obj, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0038: Expected I4, but got Obj
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = facebookId;
		string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj5 = default;
		object obj4 = obj5 + 16;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BD89");
		return (byte)(int)obj != 0;
	}

	private Coroutine DownloadFacebookImage(string facebookId, Action<Texture2D> onComplete)
	{
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_021c: Expected VT, but got Obj
		//IL_0237: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I4
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v24 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = NGUITools.Round((Vector3)onComplete);
		int layer = ((GameObject)this).layer;
		((Transform)layer).parentInternal = (Transform)(object)facebookId;
		int layer2 = ((GameObject)this).layer;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v30 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 24;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj4 + 36);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v14+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		int layer3 = ((GameObject)this).layer;
		object obj5 = obj4 + 12;
		Vector3 one2 = Vector3.one;
		transform = (Transform)obj5;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v21+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 right = transform.right;
		int layer4 = ((GameObject)this).layer;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj4;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)layer4).parent = transform;
		return (Coroutine)(object)this;
	}

	private List<Player> GetTournamentPlayersWithMissingFacebookInfo()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Player> list = default;
		list._items = null;
		object obj = list + 16;
		obj = this;
		return list;
	}

	private void PurgeSelfFromParticipants()
	{
		List<Player> tournamentPlayersWithMissingFacebookInfo = GetTournamentPlayersWithMissingFacebookInfo();
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)tournamentPlayersWithMissingFacebookInfo);
	}

	private unsafe void PurgeUnneededIds()
	{
		//IL_02c0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I4
		ref PlayerIdsData.PlayerIdData reference = ref *(PlayerIdsData.PlayerIdData*)null;
		RanksData ranksData = TopRunSave.ranksData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (TopRun.Internal.RanksData)+14]");
		string key = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (TopRun.Internal.RanksData)+14]");
		if ((nint)0 == 0)
		{
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v43 (Il2CppClass<SocialManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v63 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			if (!((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v48 (System.Boolean)+70]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v48 (System.Boolean)+38]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v48 (System.Boolean)+38]");
			if ((nint)0 == 0)
			{
				return;
			}
			string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
			int stringLength = lastTopRunResultAwardedID.m_stringLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v55+8]");
			if (!((Dictionary<string, PlayerIdsData.PlayerIdData>)stringLength).TryGetValue((string)0, out reference))
			{
				return;
			}
			PlayerIdsData.PlayerIdData playerIdData = reference;
			key = playerIdData.publicKey;
			if (playerIdData.publicKey == null)
			{
				return;
			}
		}
		if (_currentTournamentPlayers.Remove(key))
		{
			RanksData ranksData2 = TopRunSave.ranksData;
			Dictionary<string, Rank> ranks = ranksData2.ranks;
			if (ranksData2.ranks != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
		}
	}

	private unsafe IEnumerator RequestTournamentData(Action<bool> onComplete)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		IFormatProvider formatProvider = (IFormatProvider)0;
		bool flag = ((int*)onComplete)->System_002EIConvertible_002EToBoolean(formatProvider);
		bool flag2 = formatProvider == null;
		return (IEnumerator)(flag & flag2);
	}

	private IEnumerator RequestNextTournamentFetchTime()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_03a1: Expected Obj, but got I4
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03c4: Expected Obj, but got I4
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0279: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_00f2: Expected Obj, but got I
		//IL_0100: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_0141: Expected I, but got Obj
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Player> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = obj;
		object obj7 = default;
		object obj11 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v89+10]");
			if ((nint)0 != 0)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v89+14]");
			bool flag = (nint)0 == 0;
			object obj8 = obj6;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v89+14]");
				object obj9 = 0;
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v112 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v123 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				bool flag2 = obj11 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v109+14]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v109+14]");
				obj6 = 0;
				if (flag2)
				{
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj6 = obj8;
		}
		object obj12 = obj5 + 4;
		object obj13 = obj12 + 1;
		obj12 = obj13;
		object obj14 = obj13 << 2;
		object obj15 = obj5 + obj14;
		obj15 = 103;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj5 + obj16;
			if ((nint)obj17 == 103)
			{
				object obj18 = obj5 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_049f;
			}
		}
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_049f;
		IL_049f:
		return (IEnumerator)list;
	}

	private IList<string> GetPublicKeysForPlayersWeHaveNotRequestedRanksFor()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IList<string> list = default;
		object obj = list + 16;
		obj = this;
		return list;
	}

	private IEnumerator RequestRanksForPlayers()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_02f9: Expected Obj, but got I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0374: Expected Obj, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01d1: Expected Obj, but got I4
		//IL_0238: Expected Obj, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
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
		PlayerIdsData playerIdsData = TopRunSave.playerIdsData;
		string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
		int stringLength = lastTopRunResultAwardedID.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (System.Int32)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (System.Int32)+1C]");
		IEnumerable<_00210> collection = (IEnumerable<_00210>)(num - 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)collection);
		string lastTopRunResultAwardedID2 = TopRunSave.lastTopRunResultAwardedID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (TopRun.Internal.PlayerIdsData)+C]");
		bool flag = (nint)0 == 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
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
			if (obj7 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v102+8]");
			if ((nint)0 == 0)
			{
				continue;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj8 != null)
				{
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj9 = obj5 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj5 + obj11;
		obj12 = 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj5 + obj13;
			if ((nint)obj14 == 136)
			{
				object obj15 = obj5 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				goto IL_0411;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0411;
		IL_0411:
		return (IEnumerator)list;
	}

	private IEnumerator RequestSubmitScoreCoroutine(int scoreToSubmit, bool isRetry, bool previouslySavedScore)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00c3: Expected Obj, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Math);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Math>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<System.Math>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = (isRetry ? 1 : 0) - scoreToSubmit;
		object obj3 = 0 - obj2;
		if ((nint)obj2 > -1)
		{
			obj3 = obj2;
		}
		bool flag = (nint)obj3 <= (previouslySavedScore ? 1 : 0);
		return (IEnumerator)flag;
	}

	private string GetFacebookIdFromSocialManager()
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

	private string GetNameFromSocialManager()
	{
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+38]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16+8]");
				return (string)0;
			}
			return null;
		}
		return null;
	}

	private IEnumerator RefreshKeysIfNecessary()
	{
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0097: Expected Obj, but got I
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+38]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16+C]");
				return (IEnumerator)0;
			}
			return null;
		}
		return null;
	}

	private IEnumerator LoginOrRegisterFacebook()
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

	private IEnumerator LoginOrCreatePlayer()
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

	private IEnumerator RequestFacebookLogin(Action<FacebookLoginResult> onComplete)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = onComplete;
		return enumerator;
	}

	private IEnumerator RequestCreatePlayer()
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

	private IEnumerator RequestFacebookRegister()
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

	private void ClearKeys()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected Obj, but got Unknown
		//IL_06e2: Expected Obj, but got I4
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Obj, but got Unknown
		//IL_0705: Expected Obj, but got I4
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I4
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected Obj, but got Unknown
		//IL_074c: Expected I, but got Obj
		//IL_0762: Expected Obj, but got I
		//IL_084e: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got I4
		//IL_0403: Expected Obj, but got I
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_0568: Expected Obj, but got I4
		//IL_0627: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I4
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 56;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 40;
		obj5 = 0;
		_ = 0;
		Dictionary<string, Player> dictionary = (Dictionary<string, Player>)(obj2 + 32);
		dictionary = (Dictionary<string, Player>)obj;
		_ = -1;
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24 (Il2CppClass<SocialManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v250 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (!((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29 (System.Boolean)+70]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 == null)
		{
			return;
		}
		Friend[] array = ((SocialManager)facebookDialogsSupported).FriendsSortedByCash();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		string lastTopRunResultAwardedID = TopRunSave.lastTopRunResultAwardedID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj8 = array + 12;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj16 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S0_v189+8]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj11 != null)
					{
						continue;
					}
					object obj12 = 0;
					while (true)
					{
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
						{
							object obj13 = array + 16;
							object obj14 = obj12 << 2;
							object obj15 = obj13 + obj14;
							Dictionary<string, Player> dictionary2 = (Dictionary<string, Player>)obj15;
							if (dictionary2.comparer != null)
							{
								IEqualityComparer<string> comparer = dictionary2.comparer;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								if (obj16 != null)
								{
									break;
								}
							}
							object obj17 = obj12 + 1;
							obj12 = obj17;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						break;
					}
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj18 = dictionary + 4;
		object obj19 = obj18 + 1;
		obj18 = obj19;
		object obj20 = obj19 << 2;
		object obj21 = (object)dictionary + obj20;
		obj21 = 244;
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Player>)+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Player>)+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = (object)dictionary + obj23;
			if ((nint)obj24 == 244)
			{
				object obj25 = dictionary + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_086b;
			}
		}
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_086b;
		IL_086b:
		if (list._size <= 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj27 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj27 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		}
		object obj28 = dictionary + 4;
		object obj29 = obj28 + 1;
		obj28 = obj29;
		object obj30 = obj29 << 2;
		object obj31 = (object)dictionary + obj30;
		obj31 = 316;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Player>)+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (System.Collections.Generic.Dictionary`2<System.String, TopRun.Internal.Player>)+4]");
			object obj32 = (nint)0 << 2;
			object obj33 = (object)dictionary + obj32;
			if ((nint)obj33 == 316)
			{
				object obj34 = dictionary + 4;
				if ((nint)obj34 > -1)
				{
					object obj35 = obj34 + -1;
					obj34 = obj35;
				}
				return;
			}
		}
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	public static string QuoteString(string s)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = s;
		return text;
	}

	public static void LogError(object msg)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		RanksData ranksData = TopRunSave.ranksData;
		object obj = ranksData + 24;
		obj = 0;
		RanksData ranksData2 = TopRunSave.ranksData;
		object obj2 = ranksData2 + 16;
		obj2 = 0;
		RanksData ranksData3 = TopRunSave.ranksData;
		object obj3 = ranksData3 + 20;
		obj3 = 0;
	}

	public static void LogWarning(object msg)
	{
		string msg2 = "[TopRun.Manager] " + (string)msg;
		SDebug.LogFormat(msg2, null);
	}

	public static void Log(object msg)
	{
	}
}
