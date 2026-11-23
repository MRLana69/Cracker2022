using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Info;
using Kiloo;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using Kiloo.Plugins.Facebook;
using Kiloo.Plugins.GameCenter;
using SYBO.Common.Utilities;
using TopRun;
using UI.Screens;
using UnityEngine;

public class SocialManager : MonoBehaviour
{
	public enum SocialPictureSize
	{
		Normal,
		Large
	}

	public enum FacebookState
	{
		None,
		Error,
		LoggingIn,
		LoggedIn,
		Opening
	}

	private enum FacebookPermissionCheckState
	{
		Waiting,
		Ok,
		Missing,
		LoggedOut,
		Error
	}

	private class FacebookPermissionCheck
	{
		public FacebookPermissionCheckState state;
	}

	public enum WWWRequestResult
	{
		Success,
		Error
	}

	public delegate void WWWComplete(WWWRequestResult result, string output, object cookie);

	public enum PokeType
	{
		Poke,
		Duel
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Friend> _003C_003E9__138_0;

		public static Comparison<Friend> _003C_003E9__139_0;

		public static Action _003C_003E9__141_0;

		public static Predicate<Friend> _003C_003E9__143_0;

		public static Action<Friend> _003C_003E9__143_1;

		public static Predicate<Friend> _003C_003E9__152_0;

		public static Action<Friend> _003C_003E9__152_1;

		public static Comparison<FacebookProfile> _003C_003E9__161_3;

		public static FacebookSession.DialogCompleteHandler _003C_003E9__163_0;

		public static Comparison<Friend> _003C_003E9__164_0;

		public static FacebookSession.DialogCompleteHandler _003C_003E9__164_1;

		public static Action<bool> _003C_003E9__168_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal int _003CFriendsSortedByScore_003Eb__138_0(Friend x, Friend y)
		{
			return y.score - x.score;
		}

		internal int _003CFriendsSortedByCash_003Eb__139_0(Friend x, Friend y)
		{
			//IL_00a5: Expected Obj, but got I4
			//IL_0102: Expected Obj, but got I4
			//IL_010f: Expected I4, but got Obj
			Friend.Status status = y.status;
			bool flag = y.games < status.gamesCashedIn;
			bool flag2 = !flag;
			int num = status.gamesCashedIn;
			if (!flag2)
			{
				status.gamesCashedIn = y.games;
				num = y.games;
			}
			object obj = y.games - num;
			Friend.Status status2 = x.status;
			bool flag3 = x.games < status2.gamesCashedIn;
			bool flag4 = !flag3;
			int num2 = status2.gamesCashedIn;
			if (!flag4)
			{
				status2.gamesCashedIn = x.games;
				num2 = x.games;
			}
			object obj2 = x.games - num2;
			return obj - obj2;
		}

		internal void _003CInit_003Eb__141_0()
		{
			if (AgeRestriction.isRestricted)
			{
				SocialManager instance = SocialManager.instance;
				instance.FacebookLogout();
				CachedLeaderboard.RemoveFacebookFriends();
				if (TopRunRoot.manager__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
				}
			}
		}

		internal bool _003CClearGameCenter_003Eb__143_0(Friend item)
		{
			if (item.gcProfile == null)
			{
				return false;
			}
			return item.fbProfile == null;
		}

		internal void _003CClearGameCenter_003Eb__143_1(Friend item)
		{
			item.gcProfile = null;
		}

		internal bool _003CFacebookLogout_003Eb__152_0(Friend item)
		{
			if (item.gcProfile != null)
			{
				return false;
			}
			return item.fbProfile != null;
		}

		internal void _003CFacebookLogout_003Eb__152_1(Friend item)
		{
			item.fbProfile = null;
		}

		internal int _003CFacebookLoginCoroutine_003Eb__161_3(FacebookProfile p1, FacebookProfile p2)
		{
			return string.Compare(p1.id, p2.id, StringComparison.InvariantCulture);
		}

		internal void _003CRecommendAppFacebook_003Eb__163_0(IDictionary<string, object> result, FacebookError error)
		{
			if (result != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				object obj = default;
				if (obj != null)
				{
					return;
				}
			}
			if (error != null)
			{
				string title = Strings.Get(StringID.FACEBOOK);
				string message = Strings.Get(StringID.FACEBOOK_DIALOG_ERROR_MESSAGE);
				string dismissButton = Strings.Get(StringID.OK);
				DeviceUtility.ShowNativePopup(title, message, dismissButton);
			}
		}

		internal int _003CBragFacebook_003Eb__164_0(Friend x, Friend y)
		{
			return y.score - x.score;
		}

		internal void _003CBragFacebook_003Eb__164_1(IDictionary<string, object> result, FacebookError error)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj = default;
			if (obj != null)
			{
				if (UIScreenController.IsInstanced)
				{
					UIScreenController instance = UIScreenController.Instance;
					UIScreenController.SlideIn slideIn = default;
					slideIn._002Ector(UIScreenController.SlideInType.Brag);
					instance.QueueSlideIn(slideIn);
				}
			}
			else if (error != null)
			{
				string title = Strings.Get(StringID.FACEBOOK);
				string message = Strings.Get(StringID.FACEBOOK_DIALOG_ERROR_MESSAGE);
				string dismissButton = Strings.Get(StringID.OK);
				DeviceUtility.ShowNativePopup(title, message, dismissButton);
			}
		}

		internal void _003CInvalidate_003Eb__168_0(bool _003Cp0_003E)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass158_0
	{
		public FacebookPermissionCheck check;

		public SocialManager _003C_003E4__this;

		internal void _003CFacebookCheckPermissionsCoroutine_003Eb__0(IDictionary<string, object> result, FacebookError error, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b45: Expected Obj, but got Unknown
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected Obj, but got Unknown
			//IL_0aa6: Expected Obj, but got I
			//IL_0abe: Expected Obj, but got I
			//IL_0a37: Expected Obj, but got I
			//IL_0981: Expected Obj, but got I
			//IL_09ac: Expected Obj, but got I
			//IL_09d6: Expected Obj, but got I
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected Obj, but got Unknown
			//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c2c: Expected Obj, but got Unknown
			//IL_02cc: Expected Obj, but got I4
			//IL_05bd: Expected Obj, but got I4
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Expected Obj, but got Unknown
			//IL_0670: Expected Obj, but got I4
			//IL_0679: Expected Obj, but got I4
			//IL_03b7: Expected Obj, but got I4
			//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fc: Expected Obj, but got Unknown
			//IL_0415: Expected Obj, but got I4
			//IL_03f8: Expected Obj, but got I4
			//IL_0456: Expected Obj, but got I4
			//IL_0807: Unknown result type (might be due to invalid IL or missing references)
			//IL_080c: Expected Obj, but got Unknown
			//IL_07f0: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj + 24;
			_ = 0;
			FacebookPermissionCheck facebookPermissionCheck = check;
			if (facebookPermissionCheck.state != FacebookPermissionCheckState.Waiting)
			{
				return;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj16;
			object obj19;
			_003C_003Ec__DisplayClass158_0 obj23;
			object obj24;
			object obj17;
			if ((nint)0 != 1)
			{
				object obj4 = default;
				if (obj4 != null)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_08a2;
					}
					FacebookPermissionCheck facebookPermissionCheck2 = check;
					facebookPermissionCheck2.state = FacebookPermissionCheckState.LoggedOut;
				}
				else if (result != null)
				{
					_ = 0;
					object obj5 = obj + 44;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
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
							if (obj6 != null)
							{
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
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj7 = obj + 40;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
											_ = 0;
											object obj8 = default;
											object obj9 = default;
											object obj10 = default;
											object obj12 = default;
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
												if (obj8 == null)
												{
													goto IL_02c3;
												}
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
												if (obj9 == null)
												{
													continue;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												bool flag = obj10 == null;
												object obj11 = 0;
												if (!flag)
												{
													bool flag2 = obj10 == typeof(string);
													obj11 = obj10;
													if (!flag2)
													{
														obj11 = 0;
													}
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												bool flag3 = obj12 == null;
												object obj13 = 0;
												if (!flag3)
												{
													bool flag4 = obj12 == typeof(string);
													obj13 = obj12;
													if (!flag4)
													{
														obj13 = 0;
													}
												}
												if (obj11 != null && obj13 != null)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														break;
													}
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
											object obj14 = default;
											object obj15 = default;
											bool flag5 = obj14 != obj15;
											obj16 = obj14;
											object obj18 = default;
											obj17 = obj18;
											if (!flag5)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag6 = (nint)0 == 1;
												obj19 = 0;
												if (!flag6)
												{
													goto IL_05cb;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
												object obj20 = default;
												obj16 = obj20;
												object obj21 = default;
												obj17 = obj21;
											}
											_ = 0;
											object obj22 = obj + 16;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												obj23 = this;
												obj24 = obj17;
												goto IL_0ad4;
											}
											goto IL_0c72;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										goto IL_08a2;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
							else
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									goto IL_0b68;
								}
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
					goto IL_08a2;
				}
				goto IL_0b68;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_08a2;
			IL_05cb:
			_ = 0;
			object obj25 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag7 = (nint)obj19 != 9;
				if (obj19 == null)
				{
					flag7 = false;
				}
				if (flag7)
				{
					return;
				}
				SocialManager socialManager = _003C_003E4__this;
				string[] requiredPermissions = socialManager.requiredPermissions;
				object obj26 = 1;
				object obj32;
				object obj31 = default;
				for (object obj27 = 0; requiredPermissions.Length > (nint)obj27; obj32 = obj27 + 1, obj27 = obj32)
				{
					object obj28 = obj27 << 2;
					object obj29 = (object)requiredPermissions + obj28;
					_ = 0;
					object obj30 = obj + 36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_0848;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj31 == null)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag8 = (nint)0 == 1;
							obj26 = 0;
							if (!flag8)
							{
								continue;
							}
						}
						goto IL_0857;
					}
					goto IL_0866;
				}
				FacebookPermissionCheck facebookPermissionCheck3 = check;
				FacebookPermissionCheckState state = FacebookPermissionCheckState.Ok;
				if (obj26 == null)
				{
					state = FacebookPermissionCheckState.Missing;
				}
				facebookPermissionCheck3.state = state;
				goto IL_0b68;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_08a2;
			IL_08a2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj33 = default;
			obj16 = obj33;
			object obj34 = default;
			obj17 = obj34;
			goto IL_0c72;
			IL_0cd6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_0b68;
			IL_0857:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_08a2;
			IL_0ad4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			goto IL_0afc;
			IL_0b68:
			FacebookPermissionCheck facebookPermissionCheck4 = check;
			if (facebookPermissionCheck4.state == FacebookPermissionCheckState.Waiting)
			{
				facebookPermissionCheck4.state = FacebookPermissionCheckState.Error;
			}
			return;
			IL_0848:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_08a2;
			IL_02c3:
			obj19 = 9;
			goto IL_05cb;
			IL_0866:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_08a2;
			IL_0c72:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj35 = default;
			_003C_003Ec__DisplayClass158_0 obj45;
			if (obj35 == obj16)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj37 = default;
					object obj36 = obj37;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj38 = default;
						if (obj38 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
							object obj39 = (nint)0 << 2;
							object obj40 = obj3 + obj39;
							obj40 = obj37;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
							object obj41 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
							object obj42 = -1;
							goto IL_0b68;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj43 = obj37;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag9 = (nint)0 != 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj23 = (_003C_003Ec__DisplayClass158_0)0;
						obj24 = obj38;
						if (flag9)
						{
							goto IL_0afc;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag10 = (nint)0 != 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj23 = (_003C_003Ec__DisplayClass158_0)0;
				object obj44 = default;
				obj24 = obj44;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj45 = (_003C_003Ec__DisplayClass158_0)0;
				obj17 = obj44;
				if (!flag10)
				{
					goto IL_0ad4;
				}
			}
			goto IL_0cd6;
			IL_0afc:
			obj45 = obj23;
			obj17 = obj24;
			goto IL_0cd6;
		}
	}

	private sealed class _003CFacebookCheckPermissionsCoroutine_003Ed__158(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FacebookPermissionCheck check;

		public SocialManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass158_0 _003C_003E8__1;

		private float _003ClastRealTime_003E5__2;

		private float _003CtimeLeftBeforeGivingUp_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected Ref, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected Ref, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected Ref, but got Unknown
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected Ref, but got Unknown
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_00e9;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003Ec__DisplayClass158_0 obj = default;
				_003C_003E8__1 = obj;
				_003C_003Ec__DisplayClass158_0 obj2 = _003C_003E8__1;
				obj2.check = check;
				_003C_003Ec__DisplayClass158_0 obj3 = _003C_003E8__1;
				obj3._003C_003E4__this = _003C_003E4__this;
				_003C_003Ec__DisplayClass158_0 obj4 = _003C_003E8__1;
				FacebookPermissionCheck facebookPermissionCheck = obj4.check;
				facebookPermissionCheck.state = FacebookPermissionCheckState.Waiting;
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ S4_v6 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
				FacebookSession.RequestCompleteHandler requestCompleteHandler = default;
				requestCompleteHandler._002Ector(_003C_003E8__1, (nint)__ldftn(_003C_003Ec__DisplayClass158_0._003CFacebookCheckPermissionsCoroutine_003Eb__0));
				IDictionary<string, object> parameters = default;
				FacebookSession._instance.GraphRequest("me/permissions", parameters, HttpMethod.GET, requestCompleteHandler);
				ResetTimeLeft(out *(float*)(this + 28), out *(float*)(this + 32));
			}
			_003C_003Ec__DisplayClass158_0 obj5 = _003C_003E8__1;
			FacebookPermissionCheck facebookPermissionCheck2 = obj5.check;
			if (facebookPermissionCheck2.state == FacebookPermissionCheckState.Waiting)
			{
				_003C_003E4__this.UpdateTimeLeft(ref *(float*)(this + 28), ref *(float*)(this + 32));
				if (!(_003CtimeLeftBeforeGivingUp_003E5__3 > 0f))
				{
					_003C_003Ec__DisplayClass158_0 obj6 = _003C_003E8__1;
					FacebookPermissionCheck facebookPermissionCheck3 = obj6.check;
					facebookPermissionCheck3.state = FacebookPermissionCheckState.Error;
					return false;
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_00e9;
			IL_00e9:
			return false;
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

	private sealed class _003C_003Ec__DisplayClass161_0
	{
		public float timeLeftBeforeGivingUp;

		public SocialManager _003C_003E4__this;

		public FacebookSession fbSession;

		public bool asynchronousRequestsCompleted;

		public Action<bool> onComplete;

		internal void _003CFacebookLoginCoroutine_003Eb__0(IDictionary<string, object> result, FacebookError error, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected Obj, but got Unknown
			//IL_031f: Expected I, but got Obj
			//IL_00c5: Expected Obj, but got I
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Expected Obj, but got Unknown
			//IL_045a: Expected Obj, but got I
			//IL_0118: Expected Obj, but got I
			//IL_048d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Expected Obj, but got Unknown
			//IL_04c3: Expected Obj, but got I
			//IL_0159: Expected Obj, but got I
			//IL_019a: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			_ = 0;
			if (!(timeLeftBeforeGivingUp > 0f))
			{
				return;
			}
			if (IsOAuthException(error, obj))
			{
				_003C_003E4__this.FacebookLogout();
			}
			else if (result != null)
			{
				SocialManager socialManager = _003C_003E4__this;
				FacebookProfile fbProfile = default;
				socialManager._fbProfile = fbProfile;
				object obj3 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
				SocialManager socialManager2 = _003C_003E4__this;
				FacebookProfile fbProfile2 = socialManager2._fbProfile;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
				string text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
				bool flag = (nint)0 == 0;
				string id = null;
				if (!flag)
				{
					bool flag2 = (object)text.GetType() == typeof(string);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
					id = (string)0;
					if (!flag2)
					{
						id = null;
					}
				}
				fbProfile2.id = id;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
				FacebookProfile fbProfile3 = default;
				string name = default;
				if ((nint)0 == 0)
				{
					object obj4 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
					SocialManager socialManager3 = _003C_003E4__this;
					fbProfile3 = socialManager3._fbProfile;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
					string text2 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
					bool flag3 = (nint)0 == 0;
					name = null;
					if (!flag3)
					{
						bool flag4 = (object)text2.GetType() == typeof(string);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
						name = (string)0;
						if (!flag4)
						{
							name = null;
						}
					}
				}
				fbProfile3.name = name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
				FacebookProfile fbProfile4 = default;
				string fullName = default;
				if ((nint)0 == 0)
				{
					object obj5 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
					SocialManager socialManager4 = _003C_003E4__this;
					fbProfile4 = socialManager4._fbProfile;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
					string text3 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
					bool flag5 = (nint)0 == 0;
					fullName = null;
					if (!flag5)
					{
						bool flag6 = (object)text3.GetType() == typeof(string);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
						fullName = (string)0;
						if (!flag6)
						{
							fullName = null;
						}
					}
				}
				fbProfile4.fullName = fullName;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Object)+C]");
				if ((nint)0 != 0)
				{
					goto IL_03ee;
				}
				SocialManager socialManager5 = _003C_003E4__this;
				FacebookProfile fbProfile5 = socialManager5._fbProfile;
				if (fbProfile5.id != null)
				{
					throw new ArgumentException();
				}
			}
			asynchronousRequestsCompleted = true;
			string text4 = default;
			if (error != null)
			{
				nint num = (nint)error;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S2_v9 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookError>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text4 = null;
			}
			goto IL_03ee;
			IL_03ee:
			string text5 = "FacebookLogin: Error getting user info, error: " + text4;
			_003C_003E4__this.HandleLoggingIntoFacebookComplete(success: false, onComplete);
		}

		internal void _003CFacebookLoginCoroutine_003Eb__2(IDictionary<string, object> friendsResult, FacebookError friendsError, bool friendsIsFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_1688: Unknown result type (might be due to invalid IL or missing references)
			//IL_168d: Expected Obj, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected Obj, but got Unknown
			//IL_149c: Expected Obj, but got I
			//IL_14c7: Expected Obj, but got I
			//IL_14ec: Expected Obj, but got I
			//IL_1502: Unknown result type (might be due to invalid IL or missing references)
			//IL_1507: Expected Obj, but got Unknown
			//IL_192e: Expected Obj, but got I
			//IL_030d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0312: Expected Obj, but got Unknown
			//IL_0320: Expected Obj, but got I4
			//IL_084e: Expected Obj, but got I4
			//IL_0a1c: Expected Obj, but got I4
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Expected Obj, but got Unknown
			//IL_04ef: Expected Obj, but got I
			//IL_050f: Expected Obj, but got I4
			//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d60: Expected Obj, but got Unknown
			//IL_0d6e: Expected Obj, but got I4
			//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c5a: Expected Obj, but got Unknown
			//IL_0541: Expected Obj, but got I
			//IL_186d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1872: Expected Obj, but got Unknown
			//IL_0558: Expected Obj, but got I4
			//IL_0bfd: Expected Obj, but got I4
			//IL_0e48: Expected Obj, but got I
			//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Expected Obj, but got Unknown
			//IL_1729: Unknown result type (might be due to invalid IL or missing references)
			//IL_172e: Expected Obj, but got Unknown
			//IL_06c4: Expected Obj, but got I
			//IL_06d4: Expected Obj, but got I
			//IL_06f4: Expected Obj, but got I4
			//IL_1947: Unknown result type (might be due to invalid IL or missing references)
			//IL_194c: Expected Obj, but got Unknown
			//IL_0726: Expected Obj, but got I
			//IL_0752: Expected Obj, but got I
			//IL_0762: Expected Obj, but got I
			//IL_0783: Expected Obj, but got I4
			//IL_073d: Expected Obj, but got I4
			//IL_07b6: Expected Obj, but got I
			//IL_07ce: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + -64;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj + 24;
			_ = 0;
			if (!(timeLeftBeforeGivingUp > 0f))
			{
				return;
			}
			asynchronousRequestsCompleted = true;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj9;
			object obj19;
			object obj33;
			object obj20;
			if ((nint)0 != 1)
			{
				object obj4 = default;
				if (obj4 != null)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_0896;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (friendsResult == null)
					{
						goto IL_0896;
					}
					_ = 0;
					object obj5 = obj + 60;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
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
							if (obj6 != null)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_13ae;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
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
													object obj7 = obj + 56;
													obj = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
													_ = 0;
													object obj8 = default;
													object obj10 = default;
													object obj11 = default;
													IntPtr intPtr = default;
													object obj16 = default;
													object obj17 = default;
													object obj18 = default;
													object obj21 = default;
													object obj22 = default;
													object obj23 = default;
													object obj24 = default;
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
															if (obj8 == null)
															{
																obj9 = 11;
																goto IL_0a2a;
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
																	if (obj10 == null)
																	{
																		goto IL_080f;
																	}
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																	_ = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																	if ((nint)0 != 1)
																	{
																		if (obj11 == null)
																		{
																			goto IL_080f;
																		}
																		_ = 0;
																		object obj12 = obj + 60;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																		_ = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																		if ((nint)0 != 1)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
																			object obj13 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
																			bool flag = (nint)0 == 0;
																			object obj14 = 0;
																			if (!flag)
																			{
																				bool flag2 = obj13 == typeof(string);
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
																				obj14 = 0;
																				if (!flag2)
																				{
																					obj14 = 0;
																				}
																			}
																			if (obj14 == null)
																			{
																				continue;
																			}
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
																			_ = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																			if ((nint)0 != 1)
																			{
																				if (intPtr == (IntPtr)0)
																				{
																					continue;
																				}
																				SocialManager socialManager = _003C_003E4__this;
																				if (socialManager._fbProfiles != null)
																				{
																					_ = 0;
																					object obj15 = obj + 52;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																					_ = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																					if ((nint)0 == 1)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																						goto IL_0987;
																					}
																					if (obj16 != null)
																					{
																						goto IL_171a;
																					}
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
																						goto IL_171a;
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
																	goto IL_0987;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														}
														goto IL_0987;
														IL_0987:
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
														bool flag3 = obj17 != obj18;
														obj19 = obj17;
														obj20 = obj21;
														if (flag3)
														{
															break;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
														obj = obj22;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														bool flag4 = (nint)0 == 1;
														obj9 = 0;
														if (!flag4)
														{
															goto IL_0a2a;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
														obj19 = obj23;
														obj20 = obj24;
														break;
														IL_0a2a:
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															goto IL_0a73;
														}
														goto IL_0d80;
														IL_171a:
														_ = 0;
														object obj25 = obj + 60;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
															object obj26 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
															object obj27 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
															bool flag5 = (nint)0 == 0;
															object obj28 = 0;
															if (!flag5)
															{
																bool flag6 = obj27 == typeof(string);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
																obj28 = 0;
																if (!flag6)
																{
																	obj28 = 0;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
															if ((nint)0 == 0)
															{
																_ = 0;
																object obj29 = obj + 60;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																if ((nint)0 == 1)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
																	goto IL_0987;
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
																object obj30 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
																object obj31 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
																bool flag7 = (nint)0 == 0;
																object obj32 = 0;
																if (!flag7)
																{
																	bool flag8 = obj31 == typeof(string);
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
																	obj32 = 0;
																	if (!flag8)
																	{
																		obj32 = 0;
																	}
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
															if ((nint)0 != 0)
															{
																return;
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
														goto IL_0987;
														IL_080f:
														_ = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															continue;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														goto IL_0987;
													}
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														obj33 = obj20;
														goto IL_162b;
													}
													goto IL_1835;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												goto IL_13bd;
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
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									goto IL_0896;
								}
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
			goto IL_13bd;
			IL_0896:
			SocialManager socialManager2 = _003C_003E4__this;
			socialManager2._fbProfiles = null;
			SocialManager socialManager3 = _003C_003E4__this;
			socialManager3._fbReady = true;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_13bd;
			}
			return;
			IL_128e:
			SocialManager socialManager4 = _003C_003E4__this;
			socialManager4._fbReady = true;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				SocialManager socialManager5 = _003C_003E4__this;
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
			goto IL_13bd;
			IL_162b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			goto IL_1653;
			IL_1653:
			obj20 = obj33;
			goto IL_18e5;
			IL_18a7:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				obj33 = obj20;
				goto IL_162b;
			}
			goto IL_1835;
			IL_0c8f:
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						object obj34 = obj + 32;
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						_ = 0;
						object obj36 = default;
						object obj38 = default;
						object obj39 = default;
						object obj40 = default;
						object obj41 = default;
						object obj42 = default;
						object obj43 = default;
						while (true)
						{
							_ = 0;
							object obj35 = obj + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj36 == null)
								{
									break;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
								object obj37 = 0;
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
							bool flag9 = obj38 != obj39;
							obj19 = obj38;
							obj20 = obj40;
							if (!flag9)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								obj = obj41;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								obj19 = obj42;
								obj20 = obj43;
							}
							goto IL_18a7;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							SocialManager socialManager6 = _003C_003E4__this;
							IDictionary<string, FacebookProfile> fbProfiles = default;
							socialManager6._fbProfiles = fbProfiles;
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
									object obj44 = default;
									if (obj44 == null)
									{
										goto IL_128e;
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
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														_ = 0;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															goto IL_128e;
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
											goto IL_13bd;
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
					goto IL_13bd;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_13bd;
			IL_18e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_13ae:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_13bd;
			IL_17fa:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_13ae;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v197+C]");
			object obj46 = default;
			object obj45 = 0 - obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0c8f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_13bd;
			IL_1835:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj47 = default;
			if (obj47 == obj19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj49 = default;
					object obj48 = obj49;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj50 = default;
						if (obj50 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
							object obj51 = (nint)0 << 2;
							object obj52 = obj3 + obj51;
							obj52 = obj49;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
							object obj53 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
							object obj54 = (nint)0 << 2;
							object obj55 = obj54 + obj3;
							object obj56 = obj55 - 4;
							object obj57 = obj56;
							bool flag10 = obj56 == null;
							string text = "Error: ";
							string text2 = null;
							if (!flag10)
							{
								object obj58 = obj57;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v719 @ S1_v58+D4] (should have been resolved before IL gen)");
								text = "Error: ";
								string text3 = default;
								text2 = text3;
							}
							string text4 = text + text2;
							_003C_003E4__this.HandleLoggingIntoFacebookComplete(success: false, onComplete);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
							object obj59 = -1;
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						object obj60 = obj49;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag11 = (nint)0 != 1;
						obj33 = obj50;
						if (flag11)
						{
							goto IL_1653;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag12 = (nint)0 != 1;
				object obj61 = default;
				obj33 = obj61;
				obj20 = obj61;
				if (!flag12)
				{
					goto IL_162b;
				}
			}
			goto IL_18e5;
			IL_0a73:
			bool flag13 = (nint)obj9 != 11;
			if (obj9 == null)
			{
				flag13 = false;
			}
			if (flag13)
			{
				return;
			}
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v197+C]");
				if (0 <= (nint)obj46)
				{
					goto IL_0c8f;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					bool flag14 = _003C_003Ec._003C_003E9__161_3 == null;
					bool flag15 = !flag14;
					FacebookProfile facebookProfile = (FacebookProfile)(object)_003C_003Ec._003C_003E9__161_3;
					if (flag15)
					{
						goto IL_17fa;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_13ae;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						FacebookProfile facebookProfile2 = default;
						((_003C_003Ec)5260)._003CFacebookLoginCoroutine_003Eb__161_3(facebookProfile2, (FacebookProfile)(object)_003C_003Ec._003C_003E9);
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_003C_003Ec._003C_003E9__161_3 = (Comparison<FacebookProfile>)(object)facebookProfile2;
							facebookProfile = facebookProfile2;
							goto IL_17fa;
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
			goto IL_13bd;
			IL_0d80:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_13bd;
			IL_13bd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj62 = default;
			obj19 = obj62;
			object obj63 = default;
			obj20 = obj63;
			goto IL_1835;
		}
	}

	private sealed class _003C_003Ec__DisplayClass161_1
	{
		public FacebookSession.StatusChangedHandler statusChangedHandler;

		public bool statusDidChange;

		internal void _003CFacebookLoginCoroutine_003Eb__1(FacebookSession.State _003Cp0_003E, FacebookError _003Cp1_003E)
		{
			FacebookSession.statusChangedEvent -= statusChangedHandler;
			statusDidChange = true;
		}
	}

	private sealed class _003CFacebookLoginCoroutine_003Ed__161(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SocialManager _003C_003E4__this;

		public Action<bool> onComplete;

		private _003C_003Ec__DisplayClass161_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass161_1 _003C_003E8__2;

		private float _003ClastRealTime_003E5__2;

		private FacebookPermissionCheck _003CpermissionsCheck_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_07ce: Expected Obj, but got I4
			//IL_07fe: Expected Obj, but got I4
			//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b1: Expected Ref, but got Unknown
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Expected Ref, but got Unknown
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Expected Ref, but got Unknown
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Expected Ref, but got Unknown
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected Ref, but got Unknown
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Expected Ref, but got Unknown
			//IL_04c9: Expected Obj, but got I
			//IL_061c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Expected Ref, but got Unknown
			//IL_062c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0631: Expected Ref, but got Unknown
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Expected Ref, but got Unknown
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_039a: Expected Ref, but got Unknown
			//IL_0555: Unknown result type (might be due to invalid IL or missing references)
			//IL_055a: Expected Ref, but got Unknown
			//IL_0563: Unknown result type (might be due to invalid IL or missing references)
			//IL_0568: Expected Ref, but got Unknown
			SocialManager socialManager = _003C_003E4__this;
			FacebookPermissionCheckState state;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state != 3)
						{
							if (_003C_003E1__state != 4)
							{
								if (_003C_003E1__state != 5)
								{
									goto IL_0610;
								}
								_003C_003E1__state = -1;
								goto IL_0841;
							}
							_003C_003E8__2 = null;
							_003C_003E1__state = -1;
							FacebookPermissionCheck facebookPermissionCheck = _003CpermissionsCheck_003E5__3;
							state = facebookPermissionCheck.state;
							goto IL_07f0;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						FacebookPermissionCheck facebookPermissionCheck2 = _003CpermissionsCheck_003E5__3;
						bool flag = facebookPermissionCheck2.state != FacebookPermissionCheckState.Missing;
						state = facebookPermissionCheck2.state;
						if (flag)
						{
							goto IL_07f0;
						}
						_003C_003Ec__DisplayClass161_1 obj = default;
						_003C_003E8__2 = obj;
						_003C_003Ec__DisplayClass161_1 obj2 = _003C_003E8__2;
						obj2.statusChangedHandler = null;
						obj2.statusDidChange = false;
						_003C_003Ec__DisplayClass161_1 obj3 = _003C_003E8__2;
						FacebookSession.StatusChangedHandler statusChangedHandler = default;
						statusChangedHandler._002Ector(_003C_003E8__2, (nint)__ldftn(_003C_003Ec__DisplayClass161_1._003CFacebookLoginCoroutine_003Eb__1));
						_003C_003Ec__DisplayClass161_1 obj4 = _003C_003E8__2;
						FacebookSession.statusChangedEvent += obj4.statusChangedHandler;
						_003C_003Ec__DisplayClass161_0 obj5 = _003C_003E8__1;
						string permissions = string.Join(",", socialManager.requiredPermissions);
						obj5.fbSession.RequestNewReadPermissions(permissions);
						ResetTimeLeft(out *(float*)(this + 32), out *(float*)(_003C_003E8__1 + 8));
					}
					_003C_003Ec__DisplayClass161_1 obj6 = _003C_003E8__2;
					if (~(obj6.statusDidChange ? 1u : 0u) == 0)
					{
						Coroutine coroutine = _003C_003E4__this.FacebookCheckPermissionsAsync(_003CpermissionsCheck_003E5__3);
						_003C_003E2__current = coroutine;
						_003C_003E1__state = 4;
						return true;
					}
					ref float lastRealTime = ref *(float*)(this + 32);
					ref float timeLeft = ref *(float*)(_003C_003E8__1 + 8);
					_003C_003E4__this.UpdateTimeLeft(ref lastRealTime, ref timeLeft);
					_003C_003Ec__DisplayClass161_0 obj7 = _003C_003E8__1;
					if (!(obj7.timeLeftBeforeGivingUp > 0f))
					{
						_003C_003E4__this.FacebookLogout();
						goto IL_0754;
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003Ec__DisplayClass161_0 obj8 = default;
				_003C_003E8__1 = obj8;
				_003C_003Ec__DisplayClass161_0 obj9 = _003C_003E8__1;
				obj9._003C_003E4__this = _003C_003E4__this;
				_003C_003Ec__DisplayClass161_0 obj10 = _003C_003E8__1;
				obj10.onComplete = onComplete;
				_003C_003Ec__DisplayClass161_0 obj11 = _003C_003E8__1;
				FacebookSession fbSession = _003C_003E4__this.CreateFacebookSessionIfNeeded();
				obj11.fbSession = fbSession;
				_003C_003Ec__DisplayClass161_0 obj12 = _003C_003E8__1;
				bool flag2 = obj12.fbSession == null;
				_003C_003Ec__DisplayClass161_0 obj13 = _003C_003E8__1;
				if (flag2)
				{
					_003C_003E4__this.HandleLoggingIntoFacebookComplete(success: false, obj13.onComplete);
					return false;
				}
				obj13.asynchronousRequestsCompleted = false;
				if (FacebookSession.HasOpenInstance())
				{
					goto IL_024f;
				}
				_003C_003E4__this.facebookState = FacebookState.LoggingIn;
				_003C_003Ec__DisplayClass161_0 obj14 = _003C_003E8__1;
				obj14.fbSession.OpenForRead();
				ResetTimeLeft(out *(float*)(this + 32), out *(float*)(_003C_003E8__1 + 8));
			}
			object obj15 = socialManager._fbState - 1;
			if (socialManager._fbState != FacebookState.Error)
			{
				if ((nint)obj15 != 1 && (nint)obj15 == 2)
				{
					goto IL_024f;
				}
				ref float lastRealTime2 = ref *(float*)(this + 32);
				ref float timeLeft2 = ref *(float*)(_003C_003E8__1 + 8);
				_003C_003E4__this.UpdateTimeLeft(ref lastRealTime2, ref timeLeft2);
				_003C_003Ec__DisplayClass161_0 obj16 = _003C_003E8__1;
				if (!(obj16.timeLeftBeforeGivingUp > 0f))
				{
					goto IL_0754;
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			_003C_003Ec__DisplayClass161_0 obj17 = _003C_003E8__1;
			_003C_003E4__this.HandleLoggingIntoFacebookComplete(success: false, obj17.onComplete);
			return false;
			IL_0754:
			_003C_003E4__this.facebookState = FacebookState.Error;
			_003C_003Ec__DisplayClass161_0 obj18 = _003C_003E8__1;
			_003C_003E4__this.HandleLoggingIntoFacebookComplete(success: false, obj18.onComplete);
			return false;
			IL_0610:
			return false;
			IL_0841:
			_003C_003Ec__DisplayClass161_0 obj19 = _003C_003E8__1;
			if (!obj19.asynchronousRequestsCompleted && obj19.timeLeftBeforeGivingUp > 0f)
			{
				_003C_003E4__this.UpdateTimeLeft(ref *(float*)(this + 32), ref *(float*)(obj19 + 8));
				_003C_003Ec__DisplayClass161_0 obj20 = _003C_003E8__1;
				if (obj20.timeLeftBeforeGivingUp > 0f)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E4__this.facebookState = FacebookState.Error;
				_003C_003Ec__DisplayClass161_0 obj21 = _003C_003E8__1;
				_003C_003E4__this.HandleLoggingIntoFacebookComplete(success: false, obj21.onComplete);
			}
			goto IL_0610;
			IL_024f:
			FacebookPermissionCheck facebookPermissionCheck3 = default;
			_003CpermissionsCheck_003E5__3 = facebookPermissionCheck3;
			Coroutine coroutine2 = _003C_003E4__this.FacebookCheckPermissionsAsync(_003CpermissionsCheck_003E5__3);
			_003C_003E2__current = coroutine2;
			_003C_003E1__state = 2;
			return true;
			IL_07f0:
			object obj22 = state - 1;
			if (state != FacebookPermissionCheckState.Ok)
			{
				if ((nint)obj22 == 1)
				{
					_003C_003E4__this.FacebookLogout();
				}
				goto IL_0754;
			}
			ResetTimeLeft(out *(float*)(this + 32), out *(float*)(_003C_003E8__1 + 8));
			_003C_003Ec__DisplayClass161_0 obj23 = _003C_003E8__1;
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v346 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v363 @ S5_v5+4] (should have been resolved before IL gen)");
			FacebookSession.RequestCompleteHandler requestCompleteHandler = default;
			requestCompleteHandler._002Ector(_003C_003E8__1, (nint)__ldftn(_003C_003Ec__DisplayClass161_0._003CFacebookLoginCoroutine_003Eb__0));
			IDictionary<string, object> parameters = default;
			obj23.fbSession.GraphRequest("me", parameters, HttpMethod.GET, requestCompleteHandler);
			goto IL_0841;
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

	private sealed class _003CDownloadPictureForProfile_003Ed__165(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FacebookProfile profile;

		public SocialPictureSize pictureSize;

		public Action<FacebookProfile, Texture2D> handler;

		private WWW _003Cwww_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					string error = _003Cwww_003E5__2.error;
					Action<FacebookProfile, Texture2D> action = handler;
					if (handler != null)
					{
						Texture2D texture = _003Cwww_003E5__2.texture;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S0_v31 (System.Action`2<FacebookProfile, UnityEngine.Texture2D>)+C] (should have been resolved before IL gen)");
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			FacebookProfile facebookProfile = profile;
			if (profile == null)
			{
				return false;
			}
			object obj = "/picture?width=300&height=300";
			if (pictureSize == SocialPictureSize.Normal)
			{
				obj = "/picture?type=square";
			}
			string url = "http://graph.facebook.com/" + facebookProfile.id + (string)obj;
			WWW wWW = default;
			wWW._002Ector(url);
			_003Cwww_003E5__2 = wWW;
			_003C_003E2__current = _003Cwww_003E5__2;
			_003C_003E1__state = 1;
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

	private sealed class _003CDownloadFacebookPictures_003Ed__167(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SocialManager _003C_003E4__this;

		public IDictionary<string, FacebookProfile> fbProfiles;

		private int _003CdownloadFacebookPicturesContext_003E5__2;

		private List<FacebookProfile>.Enumerator _003C_003E7__wrap2;

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
				((_003CDownloadFacebookPictures_003Ed__167)obj6)._003C_003Em__Finally1();
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
			//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad0: Expected Obj, but got Unknown
			//IL_0af8: Expected Obj, but got I
			//IL_0b08: Expected Obj, but got I
			//IL_0088: Expected Obj, but got I
			//IL_009d: Expected Obj, but got I
			//IL_05b7: Expected Obj, but got I
			//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a13: Expected Obj, but got Unknown
			//IL_0a4d: Expected Obj, but got I
			//IL_0a6d: Expected Obj, but got I
			//IL_08fb: Expected Obj, but got I
			//IL_05ec: Expected Obj, but got I4
			//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b3b: Expected Obj, but got Unknown
			//IL_0163: Expected Obj, but got I
			//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4e: Expected Obj, but got Unknown
			//IL_08b6: Expected Obj, but got I
			//IL_064f: Expected Obj, but got I
			//IL_066e: Expected Obj, but got I
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Expected Obj, but got Unknown
			//IL_0244: Expected Obj, but got I4
			//IL_06e1: Expected Obj, but got I
			//IL_0440: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Expected Obj, but got Unknown
			//IL_0748: Expected Obj, but got I4
			//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba4: Expected Obj, but got Unknown
			//IL_0423: Expected Obj, but got I4
			//IL_07f9: Expected Obj, but got I
			//IL_080e: Expected Obj, but got I
			//IL_0513: Expected Obj, but got I
			//IL_0535: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			object obj3 = obj + 44;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+10]");
			Texture2D picture = (Texture2D)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
			object obj5;
			object obj8;
			bool result = default;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+8]");
					if ((nint)0 != 2)
					{
						obj5 = obj;
						goto IL_0b2d;
					}
				}
				_ = -3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (UnityEngine.Texture2D)+88]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (UnityEngine.Texture2D)+6C]");
				if (num != 0)
				{
					obj6 = 0;
				}
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13+18]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (UnityEngine.Texture2D)+6C]");
					bool flag = num2 != 0;
					object obj7 = obj4;
					obj8 = obj4;
					if (flag)
					{
						goto IL_0857;
					}
					goto IL_0c3a;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj9 = 0;
				_ = 2;
				result = true;
				obj5 = obj;
				goto IL_0b2d;
			}
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (UnityEngine.Texture2D)+6C]");
			object obj10 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			object obj11 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj15;
			bool flag4;
			object obj18;
			object obj23;
			if ((nint)0 != 1)
			{
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj12 = 0;
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
								object obj13 = obj + 40;
								obj = obj13;
								_ = 0;
								object obj14 = default;
								object obj16 = default;
								bool flag3 = default;
								object obj17 = default;
								object obj19 = default;
								bool flag6 = default;
								object obj20 = default;
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
										if (obj14 == null)
										{
											obj15 = 9;
											goto IL_0431;
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
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													if (obj16 == null)
													{
														continue;
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
									bool flag2 = (flag3 ? 1 : 0) != (nint)obj17;
									flag4 = flag3;
									obj18 = obj19;
									if (flag2)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag5 = (nint)0 == 1;
									obj15 = 0;
									if (!flag5)
									{
										goto IL_0431;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									flag4 = flag6;
									obj18 = obj20;
									break;
									IL_0431:
									_ = 0;
									object obj21 = obj + 16;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										goto IL_0488;
									}
									goto IL_0548;
								}
								_ = 0;
								object obj22 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									obj23 = obj;
									goto IL_0a7b;
								}
								goto IL_0bfb;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_0953;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0953;
			IL_0bfb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj24 = default;
			if ((nint)obj24 == (flag4 ? 1 : 0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag7 = (nint)0 != 1;
				result = false;
				obj5 = obj;
				if (flag7)
				{
					goto IL_0b2d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				flag4 = false;
				object obj25 = default;
				obj18 = obj25;
			}
			_ = 0;
			object obj26 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag8 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj23 = 0;
			result = flag4;
			object obj27 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj5 = 0;
			if (!flag8)
			{
				goto IL_0a7b;
			}
			goto IL_0c8e;
			IL_0a7b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			result = flag4;
			obj27 = obj18;
			obj5 = obj23;
			goto IL_0c8e;
			IL_0b2d:
			object obj28 = obj5 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B05A");
			return result;
			IL_0953:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			bool flag9 = default;
			flag4 = flag9;
			object obj29 = default;
			obj18 = obj29;
			goto IL_0bfb;
			IL_0857:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj30 = (nint)0 + (nint)28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				result = false;
				obj5 = obj;
				goto IL_0b2d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0953;
			IL_0c3a:
			object obj33 = default;
			while (true)
			{
				_ = 0;
				object obj31 = obj8 + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj32 = 0;
				bool flag10 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
				if (!flag10)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_06e6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v29+28]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						obj8 = 0;
						continue;
					}
					goto IL_06f5;
				}
				goto IL_0857;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0953;
			IL_0488:
			bool flag11 = (nint)obj15 != 9;
			if (obj15 == null)
			{
				flag11 = false;
			}
			result = false;
			obj5 = obj;
			if (flag11)
			{
				goto IL_0b2d;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj35 = 0;
				_ = -3;
				obj8 = obj35;
				goto IL_0c3a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0953;
			IL_0c8e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_0b2d;
			IL_06f5:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				FacebookProfile profile = default;
				((SocialManager)5277).OnDownloadedFacebookPicture(profile, picture);
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj37 = 0;
							_ = 1;
							result = true;
							obj5 = obj;
							goto IL_0b2d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					goto IL_0953;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0953;
			IL_06e6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0953;
			IL_0548:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0953;
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

	private sealed class _003C_003Ec__DisplayClass186_0
	{
		public SocialManager _003C_003E4__this;

		public int context;

		internal void _003CInitAchievements_003Eb__0(GameCenter.Achievement[] achievements, string error)
		{
			//IL_0113: Expected Obj, but got I4
			//IL_00b4: Expected Obj, but got I
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected Obj, but got Unknown
			SocialManager socialManager = _003C_003E4__this;
			if (context == socialManager._initAchievementsContext && achievements != null)
			{
				if (socialManager._achievements == null)
				{
					nint num = 0;
					nint num2 = 0;
					IntPtr intPtr = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S4_v10 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, Kiloo.Plugins.GameCenter.GameCenter+Achievement>>>)+4] (should have been resolved before IL gen)");
					IDictionary<string, GameCenter.Achievement> achievements2 = default;
					socialManager._achievements = achievements2;
				}
				object obj = 0;
				while ((nint)obj < achievements.Length)
				{
					SocialManager socialManager2 = _003C_003E4__this;
					object obj2 = obj << 2;
					object obj3 = (object)achievements + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S3_v5+10]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					object obj5 = obj + 1;
					obj = obj5;
				}
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass187_0
	{
		public SocialManager _003C_003E4__this;

		public string achievementId;

		public float percentCompleted;

		internal void _003CReportAchievement_003Eb__0(string error)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			//IL_00b4: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			if (error != null)
			{
				return;
			}
			SocialManager socialManager = _003C_003E4__this;
			if (socialManager._achievements != null)
			{
				object obj3 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
				object obj4 = default;
				if (obj4 == null)
				{
					_ = achievementId;
					SocialManager socialManager2 = _003C_003E4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj5 = 0;
				_ = percentCompleted;
				DateTime now = CDateTime.Now;
			}
		}
	}

	private sealed class _003CWWWRequestCoroutine_003Ed__191(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string relativeUrl;

		public string[] postItems;

		public WWWComplete onWWWComplete;

		public object cookie;

		private StringBuilder _003Csb_003E5__2;

		private WWW _003Cwww_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00c6: Expected Obj, but got I4
			//IL_026a: Expected I, but got Obj
			//IL_0160: Expected Obj, but got I4
			//IL_07d5: Expected Obj, but got I4
			//IL_0807: Expected Obj, but got I
			//IL_0111: Expected Obj, but got I4
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected I4, but got Unknown
			//IL_01bb: Expected Obj, but got I4
			//IL_01e5: Expected Obj, but got I
			//IL_0317: Expected Obj, but got I4
			//IL_0362: Expected Obj, but got I
			//IL_0386: Unknown result type (might be due to invalid IL or missing references)
			//IL_038b: Expected Obj, but got Unknown
			//IL_03bd: Expected Obj, but got I
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Expected Obj, but got Unknown
			//IL_0440: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Expected Obj, but got Unknown
			//IL_0483: Expected Obj, but got I
			//IL_0483: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			bool result;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					string error = _003Cwww_003E5__3.error;
					StringBuilder stringBuilder2;
					if (error != null)
					{
						StringBuilder stringBuilder = _003Csb_003E5__2.Append("Error: \"");
						string error2 = _003Cwww_003E5__3.error;
						stringBuilder2 = stringBuilder.Append(error2);
					}
					else
					{
						string text = _003Cwww_003E5__3.text;
						if (text == null)
						{
							goto IL_05df;
						}
						StringBuilder stringBuilder3 = _003Csb_003E5__2.Append("Text: \"");
						string text2 = _003Cwww_003E5__3.text;
						stringBuilder2 = stringBuilder3.Append(text2);
					}
					StringBuilder stringBuilder4 = stringBuilder2.Append("\"\n");
					goto IL_05df;
				}
				result = false;
			}
			else
			{
				_003C_003E1__state = -1;
				string text3 = "http://hoodrunner.kiloo.com" + relativeUrl;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A95");
				StringBuilder stringBuilder5 = default;
				stringBuilder5._002Ector();
				bool flag = false;
				while (true)
				{
					string[] array = postItems;
					if (array.Length <= (flag ? 1 : 0))
					{
						break;
					}
					object obj3 = (flag ? 1u : 0u) << 2;
					object obj4 = (object)array + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v75+10]");
					if ((nint)0 == 0)
					{
						object obj5 = (flag ? 1 : 0) / 2;
						int num = obj + 12;
						string text4 = ((int*)num)->ToString();
						string text5 = "WWWRequestCoroutine: Post item key " + text4 + " is null, excluding item";
					}
					else
					{
						object obj6 = (flag ? 1 : 0) + 1;
						object obj7 = obj6 << 2;
						object obj8 = (object)postItems + obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v83+10]");
						if ((nint)0 == 0)
						{
							object obj9 = (flag ? 1u : 0u) << 2;
							object obj10 = (object)postItems + obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v73+10]");
							string text6 = "WWWRequestCoroutine: Value for Post item " + (string)0 + " is null, using empty string";
							throw new ArrayTypeMismatchException();
						}
						object obj11 = (flag ? 1 : 0) + 1;
						object obj12 = obj11 << 2;
						object obj13 = (object)postItems + obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v69+10]");
						StringBuilder stringBuilder6 = stringBuilder5.Append((string)0);
					}
					bool flag2 = (byte)((flag ? 1u : 0u) + 2u) != 0;
					flag = flag2;
				}
				string text7 = default;
				if (stringBuilder5 != null)
				{
					nint num2 = (nint)stringBuilder5;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ S2_v32 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
				}
				else
				{
					text7 = null;
				}
				string text8 = default;
				string data = text8 + text7;
				string checksum = GetChecksum(data);
				WWWForm wWWForm = default;
				wWWForm._002Ector();
				wWWForm.AddField("identifier", text8);
				wWWForm.AddField("checksum", checksum);
				StringBuilder stringBuilder7 = default;
				stringBuilder7._002Ector();
				_003Csb_003E5__2 = stringBuilder7;
				StringBuilder stringBuilder8 = _003Csb_003E5__2.Append("WWWRequest(");
				StringBuilder stringBuilder9 = stringBuilder8.Append(text3);
				StringBuilder stringBuilder10 = stringBuilder9.Append(")\n");
				object obj14 = 0;
				while (true)
				{
					string[] array2 = postItems;
					if (array2.Length <= (nint)obj14)
					{
						break;
					}
					StringBuilder stringBuilder11 = _003Csb_003E5__2.Append("Adding post data: \"");
					object obj15 = obj14 << 2;
					object obj16 = (object)postItems + obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S1_v38+10]");
					StringBuilder stringBuilder12 = stringBuilder11.Append((string)0);
					StringBuilder stringBuilder13 = stringBuilder12.Append("\" = \"");
					object obj17 = obj14 + 1;
					object obj18 = obj17 << 2;
					object obj19 = (object)postItems + obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S1_v44+10]");
					StringBuilder stringBuilder14 = stringBuilder13.Append((string)0);
					StringBuilder stringBuilder15 = stringBuilder14.Append("\"\n");
					object obj20 = obj14 << 2;
					object obj21 = (object)postItems + obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v68+10]");
					if ((nint)0 != 0)
					{
						object obj22 = obj14 << 2;
						object obj23 = (object)postItems + obj22;
						object obj24 = obj14 + 1;
						object obj25 = obj24 << 2;
						object obj26 = (object)postItems + obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S1_v54+10]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S2_v29+10]");
						wWWForm.AddField((string)num3, (string)0);
					}
					object obj27 = obj14 + 2;
					obj14 = obj27;
				}
				WWW wWW = default;
				wWW._002Ector(text3, wWWForm);
				_003Cwww_003E5__3 = wWW;
				_003C_003E2__current = _003Cwww_003E5__3;
				_003C_003E1__state = 1;
				result = true;
			}
			goto IL_07c2;
			IL_05df:
			bool flag3 = onWWWComplete == null;
			result = false;
			if (!flag3)
			{
				string error3 = _003Cwww_003E5__3.error;
				if (error3 != null)
				{
					WWWComplete wWWComplete = onWWWComplete;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v274.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					result = false;
				}
				else
				{
					string text9 = _003Cwww_003E5__3.text;
					string text14 = default;
					if (text9 != null)
					{
						string text10 = _003Cwww_003E5__3.text;
						int num4 = text10.IndexOf("<result>", StringComparison.OrdinalIgnoreCase);
						if (num4 >= 0)
						{
							string text11 = _003Cwww_003E5__3.text;
							int num5 = num4 + 8;
							int num6 = text11.IndexOf("</result>", num5, StringComparison.OrdinalIgnoreCase);
							if (num6 > num5)
							{
								string text12 = _003Cwww_003E5__3.text;
								int length = num6 - num5;
								string text13 = text12.Substring(num5, length);
								text14 = text13;
							}
							else if (num5 == num6)
							{
								text14 = string.Empty;
							}
						}
					}
					WWWComplete wWWComplete2 = onWWWComplete;
					bool flag4 = text14 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v336.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					result = false;
				}
			}
			goto IL_07c2;
			IL_07c2:
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

	private const byte VERSION = 2;

	private const string UNREGISTER_DEVICE_URL = "/unregisterdevice.php?android";

	private const string REGISTER_DEVICE_URL = "/register2.php?android";

	private const string REPORT_SCORE_URL = "/report2.php?android";

	private const string CONSOLIDATE_FRIENDS_URL = "/friends2.php?android";

	private const string UPDATE_FRIEND_SCORES_URL = "/scores2.php?android";

	private const string POKE_URL = "/poke.php?android";

	private const string BRAG_URL = "/brag.php?android";

	private const string ANNOUNCE_URL = "/announce.php?android";

	private const float FACEBOOK_LOGIN_TIMEOUT = 10f;

	public const string NOTIFICATION_SOUND_NAME = "cpush.wav";

	private const string FACEBOOK_APPID = "254616967963463";

	public const string SECRET = "resxrctrv7tgv7gb8h9h9u0909kllfmolkjnhghgjjkhjghg";

	private const string ONLINESETTINGS_CONSOLIDATE_MIN_SECONDS_KEY = "social_consolidate_min_seconds";

	private const int CONSOLIDATE_MIN_SECONDS_DEFAULT = 3600;

	public const float USER_DATA_REFRESH_ON_AUTHENTICATE_AGE = 600f;

	public const float FRIEND_DATA_REFRESH_ON_RESUME_AGE = 3600f;

	private float _lastConsolidateFriendCompleteTime;

	private List<string> _latestPreConsolidationFacebookIds;

	private List<string> _latestSuccesfullyConsolidatedFacebookIds;

	private const string ONLINESETTINGS_REPORT_GAMES_COUNT_KEY = "social_report_games_count";

	private const int REPORT_GAMES_COUNT_DEFAULT = 5;

	private const string ONLINESETTINGS_REPORT_MIN_SECONDS_KEY = "social_report_min_seconds";

	private const int REPOST_MIN_SECONDS_DEFAULT = 1200;

	private const string LAST_REGISTER_TIMESTAMPTICKS_PLAYERPREFSKEY = "socmanlastregtime";

	private const string LAST_REGISTER_DATA_PLAYERPREFSKEY = "socmanlastregdata";

	private const string ONLINESETTINGS_REGISTER_MIN_SECONDS_KEY = "social_register_min_seconds";

	private const int REGISTER_MIN_SECONDS_DEFAULT = 3600;

	private const string ONLINESETTINGS_FACEBOOK_FETCH_MAX_USERS_KEY = "social_facebook_fetch_max_users";

	private const int FACEBOOK_FETCH_MAX_USERS_DEFAULT = 5000;

	private const string ONLINESETTINGS_FACEBOOK_KEEP_MAX_USERS_KEY = "social_facebook_keep_max_users";

	private const int FACEBOOK_KEEP_MAX_USERS_DEFAULT = 200;

	private string _tempRegisterUserData;

	private bool _appHasFocus;

	private const string ONLINESETTINGS_FRIENDSCORES_MIN_SECONDS_KEY = "social_friendscores_min_seconds";

	private const int FRIENDSCORES_MIN_SECONDS_DEFAULT = 120;

	private static SocialManager _instance;

	private int _userid;

	private Action<FacebookProfile> _facebookPictureDownloadedHandler;

	private bool _registerUserCompleted;

	private Action<bool> _friendsConsolidatedHandler;

	private Action _friendsChangedHandler;

	private FacebookProfile _fbProfile;

	private GameCenterProfile _gcProfile;

	private Action _localUserUpdatedHandler;

	private List<Friend> _friends;

	private IDictionary<string, FacebookProfile> _fbProfiles;

	private bool _fbReady;

	private DateTime _lastFriendScoreUpdateTimestamp;

	private bool _didAddAuthenticationHandlerToGameCenter;

	private Action _onFacebookStateChanged;

	private FacebookState _fbState;

	private bool _didAddChangeHandlerToFacebookSession;

	private readonly string[] requiredPermissions;

	private int _downloadFacebookPicturesContext;

	public const int FACEBOOK_CONSOLIDATED = 1;

	public const int GAMECENTER_CONSOLIDATED = 2;

	private int _consolidationState;

	private bool _consolidatedFriendsCompleted;

	private IDictionary<string, Friend.Status> _friendStatus;

	private bool _dirty;

	private static bool _applicationIsQuiting;

	private IDictionary<string, GameCenter.Achievement> _achievements;

	private int _initAchievementsContext;

	private bool _pausePhotoDownloading;

	private bool isRunningFacebookLogin__BackingField;

	private bool requestInvolvingDevicetokenInProgress__BackingField;

	private bool canUnregisterDevice__BackingField;

	private Action<bool> m_onRegisterUserCompleted;

	public int localUserId => _userid;

	public bool isRunningFacebookLogin
	{
		get
		{
			return isRunningFacebookLogin__BackingField;
		}
		private set
		{
			isRunningFacebookLogin__BackingField = value;
		}
	}

	public bool isRegisterUserCompleted => _registerUserCompleted;

	public FacebookProfile facebookProfile => _fbProfile;

	public GameCenterProfile gamecenterProfile => _gcProfile;

	public Texture2D localUserImage
	{
		get
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected Obj, but got Unknown
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected Obj, but got Unknown
			if (_fbProfile != null)
			{
				return (Texture2D)(_fbProfile + 20);
			}
			if (_gcProfile == null)
			{
				return null;
			}
			return (Texture2D)(_gcProfile + 20);
		}
	}

	public string localUserName
	{
		get
		{
			FacebookProfile fbProfile = _fbProfile;
			if (_fbProfile != null)
			{
				return fbProfile.name;
			}
			GameCenterProfile gcProfile = _gcProfile;
			if (_gcProfile != null)
			{
				return gcProfile.displayName;
			}
			return Strings.Get(StringID.PLAYER_SELF_REFERENCE);
		}
	}

	public bool IsIdentified
	{
		get
		{
			if (_fbProfile == null)
			{
				return _gcProfile != null;
			}
			return true;
		}
	}

	public static SocialManager instance
	{
		get
		{
			Init();
			return _instance;
		}
	}

	public bool hasGameCenterShowLoginView => GameCenter.hasLoginView;

	public bool gamecenterIsLoggedIn
	{
		get
		{
			SocialManagerIOS socialManagerIOS = SocialManagerIOS.instance;
			if (socialManagerIOS._gcState != SocialManagerIOS.GCState.Authenticating)
			{
				return _gcProfile != null;
			}
			return false;
		}
	}

	public bool gamecenterIsLoggedOut
	{
		get
		{
			SocialManagerIOS socialManagerIOS = SocialManagerIOS.instance;
			return socialManagerIOS._gcState == SocialManagerIOS.GCState.LoggedOut;
		}
	}

	public FacebookState facebookState
	{
		get
		{
			return _fbState;
		}
		private set
		{
			if (_fbState != value)
			{
				_fbState = value;
				Action onFacebookStateChanged = _onFacebookStateChanged;
				if (_onFacebookStateChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v9.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
		}
	}

	public bool facebookIsLoggedIn => FacebookSession.HasOpenInstance();

	public static bool facebookDialogsSupported => true;

	public int consolidationState => _consolidationState;

	public bool consolidatedFriendsCompleted => _consolidatedFriendsCompleted;

	public bool dirty => _dirty;

	public bool requestInvolvingDevicetokenInProgress
	{
		get
		{
			return requestInvolvingDevicetokenInProgress__BackingField;
		}
		private set
		{
			requestInvolvingDevicetokenInProgress__BackingField = value;
		}
	}

	public bool canUnregisterDevice
	{
		get
		{
			return canUnregisterDevice__BackingField;
		}
		private set
		{
			canUnregisterDevice__BackingField = value;
		}
	}

	public bool pausePhotoDownloading
	{
		get
		{
			return _pausePhotoDownloading;
		}
		set
		{
			if (SocialManagerIOS.isInstanced)
			{
				SocialManagerIOS socialManagerIOS = SocialManagerIOS.instance;
				socialManagerIOS._pausePhotoDownloading = value;
			}
			_pausePhotoDownloading = value;
		}
	}

	public event Action<bool> onRegisterUserCompleted
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 140;
			Delegate obj2 = this.m_onRegisterUserCompleted;
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
			object obj = this + 140;
			Delegate obj2 = this.m_onRegisterUserCompleted;
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

	public void AddFacebookPictureDownloadedHandler(Action<FacebookProfile> handler)
	{
		Delegate obj = Delegate.Combine(_facebookPictureDownloadedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<FacebookProfile> facebookPictureDownloadedHandler = default;
		_facebookPictureDownloadedHandler = facebookPictureDownloadedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void RemoveFacebookPictureDownloadedHandler(Action<FacebookProfile> handler)
	{
		Delegate obj = Delegate.Remove(_facebookPictureDownloadedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<FacebookProfile> facebookPictureDownloadedHandler = default;
		_facebookPictureDownloadedHandler = facebookPictureDownloadedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void AddGameCenterSmallSizePictureDownloadedHandler(Action<GameCenterProfile> handler)
	{
	}

	public void RemoveGameCenterSmallSizePictureDownloadedHandler(Action<GameCenterProfile> handler)
	{
	}

	public void AddFriendsConsolidatedHandler(Action<bool> handler)
	{
		Delegate obj = Delegate.Combine(_friendsConsolidatedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<bool> friendsConsolidatedHandler = default;
		_friendsConsolidatedHandler = friendsConsolidatedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void RemoveFriendsConsolidatedHandler(Action<bool> handler)
	{
		Delegate obj = Delegate.Remove(_friendsConsolidatedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<bool> friendsConsolidatedHandler = default;
		_friendsConsolidatedHandler = friendsConsolidatedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	private void FriendConsolidationDidFinish(bool success)
	{
		Action<bool> friendsConsolidatedHandler = _friendsConsolidatedHandler;
		if (_friendsConsolidatedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S0_v6 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
		Action friendsChangedHandler = _friendsChangedHandler;
		if (_friendsChangedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (success)
		{
			Friend[] friends = FriendsSortedByScore();
			CachedLeaderboard.Save(friends);
		}
	}

	public void AddFriendsChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_friendsChangedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action friendsChangedHandler = default;
		_friendsChangedHandler = friendsChangedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RemoveFriendsChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Remove(_friendsChangedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action friendsChangedHandler = default;
		_friendsChangedHandler = friendsChangedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private void FriendsDidChange()
	{
		Action friendsChangedHandler = _friendsChangedHandler;
		if (_friendsChangedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void AddLocalUserUpdatedHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_localUserUpdatedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action localUserUpdatedHandler = default;
		_localUserUpdatedHandler = localUserUpdatedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RemoveLocalUserUpdatedHandler(Action handler)
	{
		Delegate obj = Delegate.Remove(_localUserUpdatedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action localUserUpdatedHandler = default;
		_localUserUpdatedHandler = localUserUpdatedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public Friend FindFriend(int userid)
	{
		throw new ArgumentException();
	}

	public Friend[] FriendsSortedByScore()
	{
		if (_friends != null)
		{
			Friend[] array = _friends.ToArray();
			bool flag = _003C_003Ec._003C_003E9__138_0 == null;
			bool flag2 = !flag;
			Comparison<Friend> comparison = _003C_003Ec._003C_003E9__138_0;
			if (!flag2)
			{
				throw new ArgumentException();
			}
			Array.Sort(array, comparison);
			return array;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Friend[] result = default;
		return result;
	}

	public Friend[] FriendsSortedByCash()
	{
		if (_friends != null)
		{
			Friend[] array = _friends.ToArray();
			bool flag = _003C_003Ec._003C_003E9__139_0 == null;
			bool flag2 = !flag;
			Comparison<Friend> comparison = _003C_003Ec._003C_003E9__139_0;
			if (!flag2)
			{
				throw new ArgumentException();
			}
			Array.Sort(array, comparison);
			return array;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Friend[] result = default;
		return result;
	}

	public void DownloadLargePictureForUser(Friend friend, Action<Friend, Texture2D> handler)
	{
		//IL_0130: Expected I, but got Obj
		//IL_013d: Expected F4, but got Obj
		//IL_00aa: Expected Obj, but got I4
		SocialManager socialManager = default;
		((UnityEngine.Object)socialManager).m_CachedPtr = (IntPtr)handler;
		socialManager._lastConsolidateFriendCompleteTime = (float)friend;
		if (((UnityEngine.Object)socialManager).m_CachedPtr != (IntPtr)0)
		{
			float lastConsolidateFriendCompleteTime = socialManager._lastConsolidateFriendCompleteTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v6 (System.Single)+20]");
			bool flag = (nint)0 != 0;
			bool flag2 = (byte)((flag ? 1u : 0u) | 2u) != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v6 (System.Single)+1C]");
			if ((nint)0 == 0)
			{
				flag2 = flag;
			}
			if (flag2)
			{
				float lastConsolidateFriendCompleteTime2 = socialManager._lastConsolidateFriendCompleteTime;
				throw new ArgumentException();
			}
			object obj = (flag2 ? 1 : 0) & 2;
			if (obj != null)
			{
				SocialManagerIOS socialManagerIOS = SocialManagerIOS.instance;
				float lastConsolidateFriendCompleteTime3 = socialManager._lastConsolidateFriendCompleteTime;
				throw new ArgumentException();
			}
		}
	}

	public unsafe static void Init()
	{
		if (_instance == null && !_applicationIsQuiting)
		{
			GameObject gameObject = default;
			gameObject._002Ector("SocialManager");
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			SocialManager socialManager = gameObject.AddComponent<SocialManager>();
			Transform childTransform = gameObject.transform;
			HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.Dynamic);
			Transform asLastSibling = gameObject.transform;
			HierarchyUtility.SetAsLastSibling(asLastSibling);
			bool flag = _003C_003Ec._003C_003E9__141_0 == null;
			bool flag2 = !flag;
			Action value = _003C_003Ec._003C_003E9__141_0;
			if (!flag2)
			{
				Action action = default;
				action._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CInit_003Eb__141_0));
				_003C_003Ec._003C_003E9__141_0 = action;
				value = action;
			}
			AgeRestriction.restrictionChanged += value;
		}
	}

	public void ShowGameCenterLoginView()
	{
		GameCenter.ShowLoginView();
	}

	private void ClearGameCenter()
	{
		_gcProfile = null;
		if (_friends != null)
		{
			if (_003C_003Ec._003C_003E9__143_0 == null)
			{
				throw new ArgumentException();
			}
			throw new IndexOutOfRangeException();
		}
		SocialManagerIOS socialManagerIOS = SocialManagerIOS.instance;
		socialManagerIOS._latestSuccesfullyConsolidationGCIds = null;
		socialManagerIOS._latestPreConsolidationGCIds = null;
		socialManagerIOS._gcFriends = null;
		SocialManagerIOS socialManagerIOS2 = SocialManagerIOS.instance;
		int photoDownloadContext = socialManagerIOS2._photoDownloadContext + 1;
		socialManagerIOS2._photoDownloadContext = photoDownloadContext;
		int loadFriendsContext = socialManagerIOS2._loadFriendsContext + 1;
		socialManagerIOS2._loadFriendsContext = loadFriendsContext;
		int num = _consolidationState & -3;
		_consolidationState = num;
	}

	private unsafe void OnGameCenterAuthentication(bool hasLoginView, string error)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got F4
		//IL_012c: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0187: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got VT
		object obj = default;
		SocialManager socialManager = (SocialManager)(obj - 32);
		socialManager._tempRegisterUserData = null;
		GameCenter.LocalPlayer localPlayer = GameCenter.GetLocalPlayer();
		object obj2 = socialManager._latestSuccesfullyConsolidatedFacebookIds & 0x100;
		if (obj2 != null)
		{
			GameCenterProfile gcProfile = _gcProfile;
			if (_gcProfile != null)
			{
				if (gcProfile.id == (string)(nint)((UnityEngine.Object)socialManager).m_CachedPtr)
				{
					DateTime now = CDateTime.Now;
					GameCenterProfile gcProfile2 = _gcProfile;
					TimeSpan timeSpan = now - gcProfile2.refreshedTime;
					socialManager._tempRegisterUserData = (string)timeSpan;
					double num = (double)socialManager._tempRegisterUserData * 1E-07;
					if (num > 600.0)
					{
						_gcProfile = null;
					}
				}
				if (_gcProfile != null)
				{
					goto IL_0192;
				}
			}
			GameCenterProfile gameCenterProfile = default;
			gameCenterProfile.alias = (string)socialManager._lastConsolidateFriendCompleteTime;
			gameCenterProfile.displayName = (string)(object)socialManager._latestPreConsolidationFacebookIds;
			gameCenterProfile.id = (string)(nint)((UnityEngine.Object)socialManager).m_CachedPtr;
			DateTime now2 = CDateTime.Now;
			gameCenterProfile.refreshedTime = now2;
			_gcProfile = gameCenterProfile;
			GameCenter.LoadPhotoCompletionHandler loadPhotoCompletionHandler = default;
			loadPhotoCompletionHandler._002Ector(this, (nint)__ldftn(SocialManager._003COnGameCenterAuthentication_003Eb__144_0));
			GameCenter.LoadPhoto((string)(nint)((UnityEngine.Object)socialManager).m_CachedPtr, GameCenter.PhotoSize.Small, 50, 50, loadPhotoCompletionHandler);
			InitAchievements();
			goto IL_0192;
		}
		if (!socialManager.gamecenterIsLoggedOut)
		{
			SocialManagerIOS socialManagerIOS = SocialManagerIOS.instance;
			socialManagerIOS.gameCenterState = SocialManagerIOS.GCState.LoggedOut;
			Invalidate();
			Action friendsChangedHandler = _friendsChangedHandler;
			if (_friendsChangedHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v121.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		return;
		IL_0192:
		Flurry.LogGameCenterLogin();
	}

	public unsafe void InitGameCenter()
	{
		SocialManagerIOS socialManagerIOS = SocialManagerIOS.instance;
		socialManagerIOS.gameCenterState = SocialManagerIOS.GCState.Authenticating;
		if (~(_didAddAuthenticationHandlerToGameCenter ? 1u : 0u) != 0)
		{
			GameCenter.AuthenticateHandler authenticateHandler = default;
			authenticateHandler._002Ector(this, (nint)__ldftn(SocialManager.OnGameCenterAuthentication));
			GameCenter.authenticationEvent += authenticateHandler;
			_didAddAuthenticationHandlerToGameCenter = true;
		}
		if (GameCenter.initialAuthenticationComplete)
		{
			bool hasLoginView = GameCenter.hasLoginView;
			OnGameCenterAuthentication(hasLoginView: false, (string)(object)this);
		}
		else
		{
			GameCenter.Init();
		}
	}

	private void OnGameCenterPhotoDownloaded(GameCenterProfile gcProfile)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (_gcProfile == gcProfile)
		{
			Action localUserUpdatedHandler = _localUserUpdatedHandler;
			if (_localUserUpdatedHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		else
		{
			if (_friends == null)
			{
				return;
			}
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						goto IL_0203;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v88+1C]");
						if (0 != (nint)gcProfile)
						{
							obj7 = obj7;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj8 != obj9;
				object obj10 = obj11;
				if (flag)
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
					goto IL_0203;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
				break;
				IL_0203:
				object obj13 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CFE");
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v88+2C]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v88+2C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S0_v41+C] (should have been resolved before IL gen)");
					}
				}
				return;
			}
			_ = 0;
			object obj15 = obj + 16;
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
		}
	}

	private void OnFacebookPhotoDownloaded(FacebookProfile fbProfile)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (_fbProfile == fbProfile)
		{
			Action localUserUpdatedHandler = _localUserUpdatedHandler;
			if (_localUserUpdatedHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		else
		{
			if (_friends == null)
			{
				return;
			}
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						goto IL_0203;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v88+20]");
						if (0 != (nint)fbProfile)
						{
							obj7 = obj7;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj8 != obj9;
				object obj10 = obj11;
				if (flag)
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
					goto IL_0203;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
				break;
				IL_0203:
				object obj13 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CFE");
				if (obj7 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v88+2C]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v88+2C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S0_v41+C] (should have been resolved before IL gen)");
					}
				}
				return;
			}
			_ = 0;
			object obj15 = obj + 16;
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
		}
	}

	public void AddFacebookStateChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_onFacebookStateChanged, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onFacebookStateChanged = default;
		_onFacebookStateChanged = onFacebookStateChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RemoveFacebookStateChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Remove(_onFacebookStateChanged, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onFacebookStateChanged = default;
		_onFacebookStateChanged = onFacebookStateChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public bool FacebookLogin(Action<bool> onComplete)
	{
		bool isRestricted = AgeRestriction.isRestricted;
		bool result = false;
		if (!isRestricted)
		{
			result = false;
			if (!isRunningFacebookLogin__BackingField)
			{
				isRunningFacebookLogin__BackingField = true;
				_fbReady = false;
				IEnumerator routine = FacebookLoginCoroutine(onComplete);
				Coroutine coroutine = StartCoroutine(routine);
				result = true;
			}
		}
		return result;
	}

	private void HandleLoggingIntoFacebookComplete(bool success, Action<bool> onComplete)
	{
		//IL_0021: Expected Obj, but got I
		Invalidate();
		isRunningFacebookLogin__BackingField = false;
		if (onComplete != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S3_v3 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S3_v4+4] (should have been resolved before IL gen)");
		}
	}

	public void FacebookLogout()
	{
		if (FacebookSession._instance != null)
		{
			FacebookSession._instance.Close(clearToken: true);
		}
		if (_friends != null)
		{
			if (_003C_003Ec._003C_003E9__152_0 == null)
			{
				throw new ArgumentException();
			}
			throw new IndexOutOfRangeException();
		}
		_latestSuccesfullyConsolidatedFacebookIds = null;
		_fbProfiles = null;
		_fbProfile = null;
		Action friendsChangedHandler = _friendsChangedHandler;
		if (_friendsChangedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v80.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		int num = _consolidationState & -2;
		_consolidationState = num;
		CharacterScreenManager characterScreenManager = CharacterScreenManager.Instance;
		Action onFacebookStatusChanged = characterScreenManager.OnFacebookStatusChanged;
		if (characterScreenManager.OnFacebookStatusChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v128.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static bool IsOAuthException(FacebookError error, object obj)
	{
		//IL_0018: Expected Obj, but got I4
		if (error == null)
		{
			goto IL_006c;
		}
		object obj2 = error.category & (FacebookError.Category)(-2);
		bool flag = (nint)obj2 == 2;
		bool result = true;
		if (!flag)
		{
			bool flag2 = error.errorType != "OAuthException";
			result = true;
			if (flag2)
			{
				goto IL_006c;
			}
		}
		goto IL_0097;
		IL_006c:
		result = false;
		goto IL_0097;
		IL_0097:
		return result;
	}

	private void OnFacebookSessionStatusChanged(FacebookSession.State status, FacebookError error)
	{
		//IL_0048: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I4
		if (status == FacebookSession.State.OPENING)
		{
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.MetroPlayerARM)
			{
				facebookState = FacebookState.Opening;
			}
			return;
		}
		object obj = status - 3;
		if ((nint)obj < 2)
		{
			if (_fbState == FacebookState.LoggingIn)
			{
				Flurry.LogFacebookLogin();
			}
			facebookState = FacebookState.LoggedIn;
			return;
		}
		object obj2;
		if (status == FacebookSession.State.CLOSED_LOGIN_FAILED)
		{
			if (error == null || _fbState != FacebookState.LoggingIn || ~(error.shouldNotifyUser ? 1u : 0u) != 0)
			{
				goto IL_01c9;
			}
			string userActionMessage = error.userActionMessage;
			if (error.userActionMessage != null)
			{
				obj2 = 0;
				if (userActionMessage._stringLength != 0)
				{
					goto IL_0237;
				}
			}
			obj2 = 1;
			goto IL_0237;
		}
		if (error != null)
		{
			facebookState = FacebookState.Error;
		}
		else
		{
			facebookState = FacebookState.None;
		}
		return;
		IL_01c9:
		facebookState = FacebookState.Error;
		return;
		IL_0237:
		if (obj2 == null)
		{
			string title = Strings.Get(StringID.FACEBOOK);
			string dismissButton = Strings.Get(StringID.OK);
			DeviceUtility.ShowNativePopup(title, error.userActionMessage, dismissButton);
		}
		goto IL_01c9;
	}

	public bool HasFacebookAccessToken()
	{
		bool isRestricted = AgeRestriction.isRestricted;
		bool result = false;
		if (!isRestricted)
		{
			bool flag = FacebookSession._instance != null;
			bool flag2 = !flag;
			result = false;
			if (!flag2)
			{
				FacebookSession.State state = FacebookSession._instance.GetState();
				result = true;
			}
		}
		return result;
	}

	private unsafe FacebookSession CreateFacebookSessionIfNeeded()
	{
		if (~(_didAddChangeHandlerToFacebookSession ? 1u : 0u) != 0)
		{
			FacebookSession.StatusChangedHandler statusChangedHandler = default;
			statusChangedHandler._002Ector(this, (nint)__ldftn(SocialManager.OnFacebookSessionStatusChanged));
			FacebookSession.statusChangedEvent += statusChangedHandler;
			_didAddChangeHandlerToFacebookSession = true;
		}
		if (!FacebookSession.HasOpenInstance())
		{
			FacebookSession.appId__BackingField = "254616967963463";
			FacebookSession facebookSession = FacebookSession.Create(null, FacebookDefaultAudience.FRIENDS);
			FacebookSession.State state = FacebookSession._instance.GetState();
			if (state != FacebookSession.State.CREATED_TOKEN_LOADED)
			{
				FacebookSession._instance.Close(clearToken: false);
				string permissions = string.Join(",", requiredPermissions);
				FacebookSession facebookSession2 = FacebookSession.Create(permissions, FacebookDefaultAudience.FRIENDS);
			}
		}
		return FacebookSession._instance;
	}

	private Coroutine FacebookCheckPermissionsAsync(FacebookPermissionCheck check)
	{
		IEnumerator routine = FacebookCheckPermissionsCoroutine(check);
		return StartCoroutine(routine);
	}

	private IEnumerator FacebookCheckPermissionsCoroutine(FacebookPermissionCheck check)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void ResetTimeLeft(out float lastRealTime, out float timeLeft)
	{
		//IL_001a: Expected Ref, but got F4
		ref float reference = ref *(float*)1092616192;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		ref float reference2 = ref *(float*)realtimeSinceStartup;
	}

	private unsafe void UpdateTimeLeft(ref float lastRealTime, ref float timeLeft)
	{
		//IL_0044: Expected Ref, but got F4
		//IL_00a1: Expected Ref, but got F4
		if (_fbState != FacebookState.Opening)
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			float num = realtimeSinceStartup - lastRealTime;
			ref float reference = ref *(float*)realtimeSinceStartup;
			if (num < 0.5f && ~(_appHasFocus ? 1u : 0u) == 0)
			{
				float num2 = timeLeft - num;
				ref float reference2 = ref *(float*)num2;
			}
		}
	}

	private IEnumerator FacebookLoginCoroutine(Action<bool> onComplete)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private bool HasUnconsolidatedFacebookFriends()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		bool result = default;
		if (_fbProfiles != null)
		{
			if (_latestSuccesfullyConsolidatedFacebookIds == null)
			{
				result = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj3 = obj + 28;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				bool flag2 = default;
				object obj4 = default;
				object obj5 = default;
				object obj6 = default;
				object obj8 = default;
				object obj9 = default;
				bool result2 = default;
				while (true)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						bool flag = !flag2;
						result = flag2;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj4 == null)
								{
									result = flag2;
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
					bool flag3 = obj5 != obj6;
					object obj7 = obj8;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag4 = (nint)0 == 1;
						result = false;
						if (!flag4)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						obj7 = obj9;
					}
					_ = 0;
					object obj10 = obj + 16;
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
				object obj11 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
			}
		}
		return result;
	}

	public unsafe void RecommendAppFacebook()
	{
		//IL_003f: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		if (FacebookSession.HasOpenInstance())
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>>)+4] (should have been resolved before IL gen)");
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S5_v4+4] (should have been resolved before IL gen)");
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ S5_v9+4] (should have been resolved before IL gen)");
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S5_v14+4] (should have been resolved before IL gen)");
			string text = Strings.Get(StringID.FACEBOOK_RECOMMEND_CAPTION);
			nint num9 = 0;
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+5C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ S5_v19+4] (should have been resolved before IL gen)");
			bool flag = _003C_003Ec._003C_003E9__163_0 == null;
			bool flag2 = !flag;
			FacebookSession.DialogCompleteHandler dialogCompleteHandler = _003C_003Ec._003C_003E9__163_0;
			if (!flag2)
			{
				FacebookSession.DialogCompleteHandler dialogCompleteHandler2 = default;
				dialogCompleteHandler2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CRecommendAppFacebook_003Eb__163_0));
				_003C_003Ec._003C_003E9__163_0 = dialogCompleteHandler2;
				dialogCompleteHandler = dialogCompleteHandler2;
			}
			IDictionary<string, object> parameters = default;
			FacebookSession._instance.ShowDialog("feed", parameters, dialogCompleteHandler);
		}
	}

	public void BragFacebook(List<Friend> friends)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		if (!FacebookSession.HasOpenInstance())
		{
			return;
		}
		if (friends != null)
		{
			List<Friend> list = default;
			list._002Ector(friends._size);
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
			object obj8 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj6 == null)
					{
						goto IL_02e4;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v291+20]");
						if ((nint)0 == 0)
						{
							continue;
						}
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
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v291+C]");
								nint num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S0_v315+1C]");
								if (num >= 0)
								{
									continue;
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
				bool flag = obj8 != obj9;
				object obj10 = obj11;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_02e4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj10 = obj12;
				}
				_ = 0;
				object obj13 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj14;
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj14 = 0;
					goto IL_0ce7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
				IL_02e4:
				object obj15 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CFE");
				bool flag2 = _003C_003Ec._003C_003E9__164_0 == null;
				bool flag3 = !flag2;
				Comparison<Friend> comparison = _003C_003Ec._003C_003E9__164_0;
				if (!flag3)
				{
					throw new ArgumentException();
				}
				list.Sort(comparison);
				if (list == null)
				{
					break;
				}
				obj14 = obj;
				if (list._size == 0)
				{
					break;
				}
				goto IL_0ce7;
				IL_0ce7:
				if (list._size != 1)
				{
					if (list._size != 2)
					{
						if (list._size == 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
							throw new ArrayTypeMismatchException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					throw new ArrayTypeMismatchException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private IEnumerator DownloadPictureForProfile(FacebookProfile profile, SocialPictureSize pictureSize, Action<FacebookProfile, Texture2D> handler)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void OnDownloadedFacebookPicture(FacebookProfile profile, Texture2D picture)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0055: Expected I, but got Obj
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		if (!(picture != null))
		{
			return;
		}
		nint num = (nint)picture;
		object obj = picture + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S1_v5 (Il2CppClass<UnityEngine.Texture2D>)+DC] (should have been resolved before IL gen)");
		object obj2 = default;
		if ((nint)obj2 == 8)
		{
			nint num2 = (nint)picture;
			object obj3 = picture + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S1_v13 (Il2CppClass<UnityEngine.Texture2D>)+EC] (should have been resolved before IL gen)");
			object obj4 = default;
			if ((nint)obj4 == 8)
			{
				return;
			}
		}
		profile.image = picture;
		Action<FacebookProfile> facebookPictureDownloadedHandler = _facebookPictureDownloadedHandler;
		if (_facebookPictureDownloadedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S0_v16 (System.Action`1<FacebookProfile>)+C] (should have been resolved before IL gen)");
		}
	}

	private IEnumerator DownloadFacebookPictures(IDictionary<string, FacebookProfile> fbProfiles)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void Invalidate()
	{
		//IL_0043: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			SocialManagerIOS socialManagerIOS = SocialManagerIOS.instance;
			bool flag = socialManagerIOS._gcState == SocialManagerIOS.GCState.LoggedIn;
			bool flag2 = socialManagerIOS._gcState == SocialManagerIOS.GCState.LoggedOut;
			object obj = flag | flag2;
			if (obj == null)
			{
				return;
			}
		}
		string deviceToken = RemoteNotificationControl.GetDeviceToken();
		if (deviceToken == null || (HasFacebookAccessToken() && ~(_fbReady ? 1u : 0u) != 0))
		{
			return;
		}
		if (ShouldRegisterUser())
		{
			bool flag3 = _003C_003Ec._003C_003E9__168_0 == null;
			bool flag4 = !flag3;
			Action<bool> registerUserCompleted = _003C_003Ec._003C_003E9__168_0;
			if (!flag4)
			{
				throw new ArgumentException();
			}
			RegisterUser(registerUserCompleted);
		}
		if (ShouldConsolidateFriends())
		{
			throw new ArgumentException();
		}
		Action<bool> friendsConsolidatedHandler = _friendsConsolidatedHandler;
		if (_friendsConsolidatedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v119 @ S0_v22 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
	}

	private unsafe bool ShouldRegisterUser()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Ref, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected VT, but got Unknown
		//IL_0081: Expected I8, but got I
		//IL_007c: Expected native int or pointer, but got VT
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected VT, but got Unknown
		//IL_00df: Expected native int or pointer, but got VT
		//IL_0101: Expected VT, but got I
		//IL_0101: Expected VT, but got I
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Ref, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Ref, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Ref, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Ref, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Ref, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Ref, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Ref, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Ref, but got Unknown
		//IL_01d8: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I4
		//IL_0206: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I4
		//IL_0268: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = PlayerPrefs.HasKey("socmanlastregtime");
		bool flag2 = !flag;
		bool result = true;
		object obj4;
		if (!flag2)
		{
			string text = PlayerPrefs.GetString("socmanlastregtime");
			if (long.TryParse(text, out *(long*)(obj + 56)))
			{
				DateTime dateTime = (DateTime)(obj + 48);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
				*(DateTime*)(nint)dateTime = new DateTime(0L);
				OnlineSettings onlineSettings = OnlineSettings.instance;
				int value = onlineSettings.GetValue("social_register_min_seconds", 3600);
				DateTime now = CDateTime.Now;
				_ = 0;
				TimeSpan timeSpan = (TimeSpan)(obj + 8);
				*(TimeSpan*)(nint)timeSpan = new TimeSpan(0, 0, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				DateTime dateTime2 = (DateTime)num + (TimeSpan)0;
				bool flag3 = now >= dateTime2;
				result = true;
				if (!flag3)
				{
					FetchRegisterUserParams(out *(string*)(obj + 44), out *(string*)(obj + 40), out *(string*)(obj + 32), out *(string*)(obj + 28), out *(string*)(obj + 24), out *(string*)(obj + 36), out *(string*)(obj + 20), out *(string*)(obj + 16));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					if ((nint)0 != 0)
					{
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v55+8]");
						if ((nint)0 != 0)
						{
							goto IL_0383;
						}
					}
					obj4 = 1;
					goto IL_0383;
				}
			}
			else
			{
				string text2 = "SocialManager.ShouldRegisterUser() Invalid ticks in playerprefs: " + text;
				result = true;
			}
		}
		goto IL_0312;
		IL_02b4:
		string text3 = PlayerPrefs.GetString("socmanlastregdata", string.Empty);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
		bool flag4 = text3 != (string)0;
		result = flag4;
		goto IL_0312;
		IL_028c:
		bool flag5 = _userid == 0;
		result = true;
		if (!flag5)
		{
			goto IL_02b4;
		}
		goto IL_0312;
		IL_0383:
		if (obj4 == null)
		{
			goto IL_028c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v67+8]");
			if ((nint)0 != 0)
			{
				goto IL_03a0;
			}
		}
		obj6 = 1;
		goto IL_03a0;
		IL_0312:
		return result;
		IL_03a0:
		if (obj6 == null)
		{
			goto IL_028c;
		}
		goto IL_02b4;
	}

	private bool ShouldConsolidateFriends()
	{
		//IL_0069: Invalid comparison between I4 and F4
		if (~(_consolidatedFriendsCompleted ? 1u : 0u) == 0 && !HasUnconsolidatedFacebookFriends())
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			OnlineSettings onlineSettings = OnlineSettings.instance;
			int value = onlineSettings.GetValue("social_consolidate_min_seconds", 3600);
			float num = realtimeSinceStartup - _lastConsolidateFriendCompleteTime;
			return !((float)value > num);
		}
		return true;
	}

	public void CollectFriendReward(Friend friend)
	{
		Friend.Status status = friend.status;
		status.gamesCashedIn = friend.games;
		_dirty = true;
	}

	public int CashIn(Friend friend, int max)
	{
		Friend.Status status = friend.status;
		int num = friend.games - status.gamesCashedIn;
		if (num < 1)
		{
			return 0;
		}
		Friend.Status status2 = friend.status;
		status2.gamesCashedIn = friend.games;
		_dirty = true;
		if (max >= num)
		{
			num = max;
		}
		return num;
	}

	public int CashInAll(int maxPerFriend)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		int result = default;
		if (_friends != null)
		{
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = default;
			int num2 = default;
			object obj7 = default;
			object obj8 = default;
			int num3 = default;
			int num4 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						break;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						int num = CashIn((Friend)0, maxPerFriend);
						result = num + num2;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj7 != obj8;
				int result2 = num3;
				if (!flag)
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
					result2 = num4;
				}
				_ = 0;
				object obj9 = obj + 16;
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
				return result2;
			}
			object obj10 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CFE");
		}
		return result;
	}

	public void WriteTo(Stream stream)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_04c0: Expected I, but got Obj
		//IL_0025: Expected I, but got Obj
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_0165: Expected Obj, but got I
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		BinaryWriter binaryWriter = default;
		binaryWriter._002Ector(stream);
		object obj3 = binaryWriter - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S2_v4+BC] (should have been resolved before IL gen)");
		if (_friendStatus != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			nint num = (nint)binaryWriter;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S2_v14 (Il2CppClass<System.IO.BinaryWriter>)+13C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj4 = obj + 28;
			obj = obj4;
			_ = 0;
			object obj5 = default;
			object obj9 = default;
			object obj10 = default;
			object obj12 = default;
			object obj13 = default;
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
					if (obj5 == null)
					{
						goto IL_05bf;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
								object obj6 = 0;
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
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
												object obj7 = (nint)0 + (nint)8;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1478");
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
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
															object obj8 = (nint)0 + (nint)16;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1478");
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
														goto IL_040c;
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
								goto IL_040c;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				goto IL_040c;
				IL_040c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj9 != obj10;
				object obj11 = obj12;
				if (!flag)
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
					obj11 = obj13;
				}
				_ = 0;
				object obj14 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					goto IL_05bf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
				IL_05bf:
				object obj15 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
				return;
			}
			object obj16 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		}
		nint num2 = (nint)binaryWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S2_v9 (Il2CppClass<System.IO.BinaryWriter>)+13C] (should have been resolved before IL gen)");
	}

	public void ReadFrom(Stream stream)
	{
		//IL_02b5: Expected I, but got Obj
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02f2: Expected I, but got Obj
		//IL_032d: Expected Obj, but got I4
		//IL_002f: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I4
		//IL_0187: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_01f1: Expected I, but got Obj
		//IL_0210: Expected I, but got Obj
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_00e1: Expected I, but got Obj
		//IL_0100: Expected I, but got Obj
		//IL_0131: Expected I, but got Obj
		BinaryReader binaryReader = default;
		binaryReader._002Ector(stream);
		nint num = (nint)binaryReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S1_v4 (Il2CppClass<System.IO.BinaryReader>)+10C] (should have been resolved before IL gen)");
		object obj2 = default;
		object obj = obj2 - 1;
		if ((nint)obj2 != 1)
		{
			if ((nint)obj == 1)
			{
				nint num2 = (nint)binaryReader;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S1_v35 (Il2CppClass<System.IO.BinaryReader>)+134] (should have been resolved before IL gen)");
				nint num3 = 0;
				nint num4 = 0;
				IntPtr intPtr = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ S4_v13 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, Friend+Status>>>)+4] (should have been resolved before IL gen)");
				IDictionary<string, Friend.Status> friendStatus = default;
				_friendStatus = friendStatus;
				object obj3 = 0;
				object obj4 = default;
				IntPtr intPtr2 = default;
				Friend.Status status = default;
				int gamesCashedIn = default;
				long dateData = default;
				long dateData2 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					nint num5 = (nint)binaryReader;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ S1_v42 (Il2CppClass<System.IO.BinaryReader>)+16C] (should have been resolved before IL gen)");
					object obj5;
					if (intPtr2 != (IntPtr)0)
					{
						obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v55 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, Friend+Status>>>)+8]");
						if ((nint)0 != 0)
						{
							goto IL_0333;
						}
					}
					obj5 = 1;
					goto IL_0333;
					IL_0333:
					if (obj5 == null)
					{
						status._002Ector();
						nint num6 = (nint)binaryReader;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v286 @ S2_v28 (Il2CppClass<System.IO.BinaryReader>)+134] (should have been resolved before IL gen)");
						status.gamesCashedIn = gamesCashedIn;
						nint num7 = (nint)binaryReader;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ S1_v51 (Il2CppClass<System.IO.BinaryReader>)+144] (should have been resolved before IL gen)");
						DateTime lastPokeTime = DateTime.FromBinary(dateData);
						status.lastPokeTime = lastPokeTime;
						nint num8 = (nint)binaryReader;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v315 @ S2_v34 (Il2CppClass<System.IO.BinaryReader>)+144] (should have been resolved before IL gen)");
						DateTime lastDuelPokeTime = DateTime.FromBinary(dateData2);
						status.lastDuelPokeTime = lastDuelPokeTime;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
					}
					object obj6 = obj3 + 1;
					obj3 = obj6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				IOException ex = default;
				ex._002Ector("Unsupported playerdata file version");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			return;
		}
		nint num9 = (nint)binaryReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S1_v9 (Il2CppClass<System.IO.BinaryReader>)+134] (should have been resolved before IL gen)");
		nint num10 = 0;
		nint num11 = 0;
		IntPtr intPtr3 = num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, Friend+Status>>>)+4] (should have been resolved before IL gen)");
		IDictionary<string, Friend.Status> friendStatus2 = default;
		_friendStatus = friendStatus2;
		object obj7 = 0;
		object obj8 = default;
		IntPtr intPtr4 = default;
		Friend.Status status2 = default;
		int gamesCashedIn2 = default;
		long dateData3 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			nint num12 = (nint)binaryReader;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S1_v16 (Il2CppClass<System.IO.BinaryReader>)+16C] (should have been resolved before IL gen)");
			object obj9;
			if (intPtr4 != (IntPtr)0)
			{
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v24 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, Friend+Status>>>)+8]");
				if ((nint)0 != 0)
				{
					goto IL_037a;
				}
			}
			obj9 = 1;
			goto IL_037a;
			IL_037a:
			if (obj9 == null)
			{
				status2._002Ector();
				nint num13 = (nint)binaryReader;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v268 @ S2_v13 (Il2CppClass<System.IO.BinaryReader>)+134] (should have been resolved before IL gen)");
				status2.gamesCashedIn = gamesCashedIn2;
				nint num14 = (nint)binaryReader;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v276 @ S1_v25 (Il2CppClass<System.IO.BinaryReader>)+144] (should have been resolved before IL gen)");
				DateTime lastPokeTime2 = DateTime.FromBinary(dateData3);
				status2.lastPokeTime = lastPokeTime2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			}
			object obj10 = obj7 + 1;
			obj7 = obj10;
		}
	}

	private static string GetSaveDataPath()
	{
		string userDataPath = DeviceUtility.GetUserDataPath();
		return userDataPath + "/socialdata";
	}

	public void Load()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_055d: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I
		//IL_05ad: Expected Obj, but got I
		//IL_03c7: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_04b5: Expected Obj, but got I
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_dirty = false;
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_0195;
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
		goto IL_0195;
		IL_0195:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 == obj5;
		bool flag2 = !flag;
		object obj6 = obj3;
		object obj8 = default;
		object obj7 = obj8;
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
					obj6 = obj3;
					obj7 = obj10;
					object obj11 = default;
					if (obj11 != null)
					{
						goto IL_0547;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj12 = obj10;
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
								obj15 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj16 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj17 = (nint)0 << 2;
								object obj18 = obj17 + obj3;
								object obj19 = obj18 - 4;
								object obj20 = obj19;
								object obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ S1_v63+E4] (should have been resolved before IL gen)");
								string text2 = default;
								string text = "Could not load data: " + text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj22 = -1;
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj23 = obj10;
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
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			object obj24 = default;
			obj7 = obj24;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0547;
		IL_0547:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ L1_v3+4]");
		object obj25 = (nint)0 << 2;
		object obj26 = obj6 + obj25;
		obj26 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ L1_v3+4]");
		object obj27 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ L1_v3+4]");
		object obj28 = -1;
	}

	public void SaveIfDirty()
	{
		if (~(_dirty ? 1u : 0u) == 0)
		{
			bool flag = Save();
		}
	}

	public bool Save()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected Obj, but got Unknown
		//IL_03a3: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I
		//IL_03f3: Expected Obj, but got I
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag = (nint)0 == 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag2 = false;
		if (!flag)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			flag2 = false;
			if (!flag3)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag5 = default;
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 == 1;
							flag2 = flag5;
							if (!flag4)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag6 = (nint)0 == 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								flag2 = false;
								if (!flag6)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_dirty = false;
										flag2 = true;
										goto IL_06e2;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									flag2 = false;
									goto IL_0283;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							flag2 = flag5;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						flag2 = false;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					flag2 = false;
				}
				goto IL_0283;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0283;
		IL_0283:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag7 = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		bool flag11;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag8 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			flag2 = false;
			if (!flag8)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag9 = (nint)0 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				flag2 = false;
				if (!flag9)
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						throw new ArrayTypeMismatchException();
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj18 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag10 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					flag2 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					flag11 = false;
					obj6 = obj18;
					if (flag10)
					{
						goto IL_0675;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag12 = (nint)0 != 1;
			object obj19 = default;
			obj6 = obj19;
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				flag11 = flag2;
				obj6 = obj19;
				goto IL_0675;
			}
		}
		goto IL_06e7;
		IL_06e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_06e2;
		IL_06e2:
		return flag2;
		IL_0675:
		flag2 = flag11;
		goto IL_06e7;
	}

	private void OnRemoteNotificationsEnabled(string deviceToken, string oldDeviceToken)
	{
		//IL_0047: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.IPhonePlayer)
		{
			goto IL_005b;
		}
		object obj;
		if (oldDeviceToken != null)
		{
			obj = 0;
			if (oldDeviceToken._stringLength != 0)
			{
				goto IL_0088;
			}
		}
		obj = 1;
		goto IL_0088;
		IL_0088:
		if (obj == null)
		{
			FireAndForgetUnregisterDevice(oldDeviceToken);
		}
		goto IL_005b;
		IL_005b:
		Invalidate();
	}

	private unsafe void Awake()
	{
		if (_instance != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		_instance = this;
		Load();
		PlayerInfo playerInfo = PlayerInfo.Instance;
		if (~(playerInfo._remoteNotificationsEnabled ? 1u : 0u) == 0)
		{
			RemoteNotificationControl.RemoteNotificationsEnabledHandler remoteNotificationsEnabledHandler = default;
			remoteNotificationsEnabledHandler._002Ector(this, (nint)__ldftn(SocialManager.OnRemoteNotificationsEnabled));
			RemoteNotificationControl.Enable(remoteNotificationsEnabledHandler, "cpush.wav");
		}
		throw new ArgumentException();
	}

	private void AttemptRelogin()
	{
		if (HasFacebookAccessToken())
		{
			bool flag = FacebookLogin(null);
		}
	}

	private void OnApplicationFocus(bool focus)
	{
		_appHasFocus = focus;
	}

	private unsafe void OnApplicationPause(bool pause)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		object obj = default;
		SocialManager socialManager = (SocialManager)(obj - 16);
		if (pause)
		{
			SaveIfDirty();
			return;
		}
		if (socialManager.HasFacebookAccessToken())
		{
			bool flag = FacebookLogin(null);
		}
		GameCenter.LocalPlayer localPlayer = GameCenter.GetLocalPlayer();
		PlayerInfo playerInfo = PlayerInfo.Instance;
		if (~(playerInfo._remoteNotificationsEnabled ? 1u : 0u) != 0)
		{
			return;
		}
		string deviceToken = RemoteNotificationControl.GetDeviceToken();
		object obj2;
		if (deviceToken != null)
		{
			obj2 = 0;
			if (deviceToken._stringLength != 0)
			{
				goto IL_0119;
			}
		}
		obj2 = 1;
		goto IL_0119;
		IL_0119:
		if (obj2 != null)
		{
			RemoteNotificationControl.RemoteNotificationsEnabledHandler remoteNotificationsEnabledHandler = default;
			remoteNotificationsEnabledHandler._002Ector(this, (nint)__ldftn(SocialManager.OnRemoteNotificationsEnabled));
			RemoteNotificationControl.Enable(remoteNotificationsEnabledHandler, "cpush.wav");
		}
	}

	private void OnApplicationQuit()
	{
		_applicationIsQuiting = true;
	}

	private unsafe void InitAchievements()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		GameCenter.LocalPlayer localPlayer = GameCenter.GetLocalPlayer();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			int initAchievementsContext = _initAchievementsContext + 1;
			_initAchievementsContext = initAchievementsContext;
			GameCenter.LoadAchievementsCompletionHandler loadAchievementsCompletionHandler = default;
			object obj4 = default;
			loadAchievementsCompletionHandler._002Ector(obj4, (nint)__ldftn(_003C_003Ec__DisplayClass186_0._003CInitAchievements_003Eb__0));
			GameCenter.LoadAchievements(loadAchievementsCompletionHandler);
		}
	}

	public unsafe void ReportAchievement(string achievementId, float percentCompleted)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I
		//IL_0029: Expected Ref, but got F4
		//IL_0160: Expected F4, but got I
		//IL_0160: Expected Obj, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I
		//IL_00f2: Expected native int or pointer, but got F4
		//IL_0103: Invalid comparison between F4 and I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		object obj3 = default;
		float num = (float)obj3 + 16f;
		bool flag = percentCompleted < 0f;
		bool flag2 = percentCompleted > 100f;
		bool flag3 = true;
		if (!flag2)
		{
			flag3 = flag;
		}
		if (flag3)
		{
			string text = ((float*)num)->ToString();
			string text2 = "SocialManager.ReportAchievement: percentCompleted has invalid value: " + text + " (must be >= 0  and <= 100)";
			return;
		}
		GameCenter.LocalPlayer localPlayer = GameCenter.GetLocalPlayer();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+15]");
		object obj4 = (nint)0 & (nint)1;
		if (obj4 == null)
		{
			return;
		}
		if (_achievements != null)
		{
			object obj5 = obj + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
			object obj6 = default;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
				object obj7 = 0;
				float value = ((float*)(nint)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v21+C]");
				if (!(value > 0f))
				{
					return;
				}
			}
		}
		GameCenter.RequestCompleteHandler requestCompleteHandler = default;
		requestCompleteHandler._002Ector(obj3, (nint)__ldftn(_003C_003Ec__DisplayClass187_0._003CReportAchievement_003Eb__0));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (System.Object)+C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (System.Object)+10]");
		GameCenter.ReportAchievement((string)num2, 0f, showsCompletionBanner: false, requestCompleteHandler);
	}

	private unsafe static string GetRandomIdentifier()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected VT, but got Unknown
		//IL_004c: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		Guid guid = Guid.NewGuid();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Guid guid2 = (Guid)(obj + 16);
		return ((Guid*)guid2)->ToString();
	}

	public static string GetChecksum(string data)
	{
		string data2 = data + "resxrctrv7tgv7gb8h9h9u0909kllfmolkjnhghgjjkhjghg";
		byte[] bytes = Checksum.ComputeSHA1(data2);
		return StringUtility.ToHexString(bytes, lowerCase: true);
	}

	private static string GetChecksum(string[] data)
	{
		string data2 = string.Join(null, data);
		return GetChecksum(data2);
	}

	public static IEnumerator WWWRequestCoroutine(WWWComplete onWWWComplete, string relativeUrl, object cookie, string[] postItems)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void FireAndForgetUnregisterDevice(string token)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		object obj;
		if (token != null)
		{
			obj = 0;
			if (token._stringLength != 0)
			{
				goto IL_00b9;
			}
		}
		obj = 1;
		goto IL_00b9;
		IL_00b9:
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
	}

	private unsafe void UnregisterDevice(Action<bool> completionHandler)
	{
		//IL_008f: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		object obj;
		if (~(canUnregisterDevice__BackingField ? 1u : 0u) == 0)
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			if (~(playerInfo._remoteNotificationsEnabled ? 1u : 0u) == 0)
			{
				string deviceToken = RemoteNotificationControl.GetDeviceToken();
				if (deviceToken != null)
				{
					obj = 0;
					if (deviceToken._stringLength != 0)
					{
						goto IL_0159;
					}
				}
				obj = 1;
				goto IL_0159;
			}
		}
		goto IL_0168;
		IL_0168:
		if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [completionHandler @ L1 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
		return;
		IL_0159:
		if (obj == null)
		{
			requestInvolvingDevicetokenInProgress__BackingField = true;
			WWWComplete wWWComplete = default;
			wWWComplete._002Ector(this, (nint)__ldftn(SocialManager.WWWUnregisterDeviceCompleted));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		goto IL_0168;
	}

	private void WWWUnregisterDeviceCompleted(WWWRequestResult result, string output, object cookie)
	{
		if (result == WWWRequestResult.Success)
		{
			RemoteNotificationControl.Disable();
			PlayerPrefs.SetString("socmanlastregdata", string.Empty);
		}
		if (cookie != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			bool flag = result == WWWRequestResult.Success;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S0_v11+C] (should have been resolved before IL gen)");
		}
	}

	private unsafe void RegisterUser(Action<bool> registerUserCompleted)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Ref, but got Unknown
		//IL_04f1: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I4
		//IL_00e0: Expected Obj, but got I4
		object obj = default;
		int num = obj - 32;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		((int*)num)->m_value = 0;
		FetchRegisterUserParams(out *(string*)(num + 28), out *(string*)(num + 24), out *(string*)(num + 20), out *(string*)(num + 16), out *(string*)(num + 12), out *(string*)(this + 24), out *(string*)(num + 8), out *(string*)(num + 4));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+1C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+1C]");
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v17+8]");
			if ((nint)0 != 0)
			{
				goto IL_0516;
			}
		}
		obj3 = 1;
		goto IL_0516;
		IL_0550:
		object obj4;
		if (obj4 != null)
		{
			if (registerUserCompleted != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [registerUserCompleted @ L1 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
			}
			return;
		}
		goto IL_0130;
		IL_0130:
		PlayerInfo playerInfo = PlayerInfo.Instance;
		WWWComplete wWWComplete = default;
		wWWComplete._002Ector(this, (nint)__ldftn(SocialManager.WWWRegisterUserCompleted));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
		IL_0516:
		if (obj3 == null)
		{
			goto IL_0130;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+18]");
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v78+8]");
			if ((nint)0 != 0)
			{
				goto IL_0533;
			}
		}
		obj6 = 1;
		goto IL_0533;
		IL_0533:
		if (obj6 == null)
		{
			goto IL_0130;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+14]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+14]");
		if ((nint)0 != 0)
		{
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v82+8]");
			if ((nint)0 != 0)
			{
				goto IL_0550;
			}
		}
		obj4 = 1;
		goto IL_0550;
	}

	private unsafe void FetchRegisterUserParams(out string fbid, out string gcid, out string deviceToken, out string bundleVersion, out string highestScore, out string registerUserData, out string timezone, out string locale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected I4, but got Unknown
		//IL_00b6: Expected Ref, but got F8
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		if (_fbProfile == null)
		{
		}
		ref string reference = ref *(string*)string.Empty;
		string bundleVersion2 = DeviceUtility.GetBundleVersion();
		ref string reference2 = ref *(string*)bundleVersion2;
		PlayerInfo playerInfo = PlayerInfo.Instance;
		_ = playerInfo._highScore;
		int num = obj + 28;
		string text = ((int*)num)->ToString();
		ref string reference3 = ref *(string*)text;
		DateTime now = CDateTime.Now;
		TimeSpan currentTimeZoneUTCOffset = TimeUtility.GetCurrentTimeZoneUTCOffset(now);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		double num2 = 0.0 * 2.7777777777777777E-11;
		double num3 = (double)obj + 8.0;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		string text2 = ((double*)num3)->ToString(invariantCulture);
		ref string reference4 = ref *(string*)text2;
		string locale2 = DeviceUtility.GetLocale();
		ref string reference5 = ref *(string*)locale2;
		string deviceToken2 = RemoteNotificationControl.GetDeviceToken();
		ref string reference6 = ref *(string*)deviceToken2;
		ref string reference7 = ref *(string*)string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private unsafe void WWWRegisterUserCompleted(WWWRequestResult result, string output, object cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0786: Expected Obj, but got I4
		//IL_067b: Expected Obj, but got I4
		//IL_0801: Expected Obj, but got I4
		//IL_065f: Expected Obj, but got I4
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected VT, but got Unknown
		//IL_06aa: Expected Ref, but got VT
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected I8, but got Unknown
		//IL_0706: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		_ = 0;
		object obj4 = 0;
		if (result != WWWRequestResult.Success)
		{
			goto IL_07cd;
		}
		requestInvolvingDevicetokenInProgress__BackingField = false;
		Dictionary<string, string> dictionary = StringUtility.ParseProperties(output);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		object obj5 = default;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		string tempRegisterUserData = _tempRegisterUserData;
		object obj6;
		if (_tempRegisterUserData != null)
		{
			obj6 = 0;
			if (tempRegisterUserData._stringLength != 0)
			{
				goto IL_07f8;
			}
		}
		obj6 = 1;
		goto IL_07f8;
		IL_07cd:
		SocialManager socialManager = default;
		socialManager._registerUserCompleted = true;
		if (cookie != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S0_v25+C] (should have been resolved before IL gen)");
		}
		Action<bool> action = socialManager.m_onRegisterUserCompleted;
		if (socialManager.m_onRegisterUserCompleted != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ S0_v18 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
		}
		return;
		IL_07f8:
		obj4 = 1;
		if (obj6 == null)
		{
			DateTime now = CDateTime.Now;
			DateTime dateTime = (DateTime)(obj + 24);
			long ticks = ((DateTime*)dateTime)->Ticks;
			long num = obj + 16;
			string value = ((long*)num)->ToString();
			PlayerPrefs.SetString("socmanlastregtime", value);
			PlayerPrefs.SetString("socmanlastregdata", _tempRegisterUserData);
			_tempRegisterUserData = null;
			obj4 = 1;
		}
		goto IL_07cd;
	}

	private string GetFBListAsStringAndSaveAsPreConsolidated()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_0351: Expected I, but got Obj
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (_fbProfiles != null)
		{
			if (_latestPreConsolidationFacebookIds == null)
			{
				List<string> list = default;
				list._002Ector();
				_latestPreConsolidationFacebookIds = list;
			}
			else
			{
				((List<T>)(object)_latestPreConsolidationFacebookIds).Clear();
			}
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj4 = default;
			object obj6 = default;
			object obj7 = default;
			object obj9 = default;
			object obj10 = default;
			string result = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj4 == null)
					{
						goto IL_0331;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj5 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if ((nint)obj5 >= 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_02a2;
								}
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
				goto IL_02a2;
				IL_02a2:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj6 != obj7;
				object obj8 = obj9;
				if (flag)
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
					goto IL_0331;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
				break;
				IL_0331:
				object obj11 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
				nint num = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v217 @ S1_v26 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
				return result;
			}
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				string result2 = default;
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		return string.Empty;
	}

	private unsafe void ConsolidateFriends(Action<bool> consolidateFriendsCompleted)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		string fBListAsStringAndSaveAsPreConsolidated = GetFBListAsStringAndSaveAsPreConsolidated();
		string empty = string.Empty;
		object obj;
		if (fBListAsStringAndSaveAsPreConsolidated != null)
		{
			obj = 0;
			if (fBListAsStringAndSaveAsPreConsolidated._stringLength != 0)
			{
				goto IL_018d;
			}
		}
		obj = 1;
		goto IL_018d;
		IL_00a3:
		WWWComplete wWWComplete = default;
		wWWComplete._002Ector(this, (nint)__ldftn(SocialManager.WWWConsolidateFriendsCompleted));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
		IL_01aa:
		object obj2;
		if (obj2 != null)
		{
			if (consolidateFriendsCompleted != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [consolidateFriendsCompleted @ L1 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
			}
			FriendConsolidationDidFinish(success: true);
			return;
		}
		goto IL_00a3;
		IL_018d:
		if (obj == null)
		{
			goto IL_00a3;
		}
		if (string.Empty != null)
		{
			obj2 = 0;
			if (empty._stringLength != 0)
			{
				goto IL_01aa;
			}
		}
		obj2 = 1;
		goto IL_01aa;
	}

	private void WWWConsolidateFriendsCompleted(WWWRequestResult result, string output, object cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_12f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_00cc: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0134: Expected I, but got Obj
		//IL_0147: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I
		//IL_0e92: Expected I, but got Obj
		//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected Obj, but got Unknown
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected Obj, but got Unknown
		//IL_157d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1582: Expected Obj, but got Unknown
		//IL_10da: Unknown result type (might be due to invalid IL or missing references)
		//IL_10df: Expected Obj, but got Unknown
		//IL_0312: Expected Obj, but got I
		//IL_122d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1232: Expected Obj, but got Unknown
		//IL_126c: Expected Obj, but got I
		//IL_0fa0: Expected Obj, but got I
		//IL_0e49: Expected Obj, but got I
		//IL_13c7: Expected Obj, but got I
		//IL_04ce: Expected Obj, but got I
		//IL_045f: Expected Obj, but got I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_03d8: Expected Obj, but got I4
		//IL_0402: Expected I, but got Obj
		//IL_0ddd: Expected Obj, but got I
		//IL_0c9a: Expected Obj, but got I
		//IL_0cc5: Expected Obj, but got I
		//IL_0cea: Expected Obj, but got I
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected Obj, but got Unknown
		//IL_053e: Expected Obj, but got I
		//IL_0d4c: Expected Obj, but got I
		//IL_0420: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I4
		//IL_0451: Expected I, but got Obj
		//IL_0576: Expected Obj, but got I4
		//IL_13ef: Expected Obj, but got I
		//IL_05e9: Expected Obj, but got I
		//IL_088c: Expected Obj, but got I
		//IL_0683: Expected Obj, but got I
		//IL_0a7f: Expected Obj, but got I
		//IL_0760: Expected Obj, but got I
		//IL_0770: Expected Obj, but got I
		//IL_077a: Expected I, but got Obj
		//IL_0906: Expected Obj, but got I
		//IL_0916: Expected Obj, but got I
		//IL_0920: Expected I, but got Obj
		//IL_06ee: Expected Obj, but got I
		//IL_0aea: Expected Obj, but got I
		//IL_07a7: Expected Obj, but got I
		//IL_07b1: Expected I, but got Obj
		//IL_094d: Expected Obj, but got I
		//IL_0957: Expected I, but got Obj
		//IL_07cf: Expected Obj, but got I
		//IL_080f: Expected Obj, but got I
		//IL_081f: Expected Obj, but got I
		//IL_0b5b: Expected Obj, but got I
		//IL_0975: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got I
		//IL_09c5: Expected Obj, but got I
		//IL_14ea: Expected I, but got Obj
		//IL_0b40: Expected Obj, but got I
		//IL_085d: Expected Obj, but got I
		//IL_086d: Expected Obj, but got I
		//IL_0877: Expected I, but got Obj
		//IL_0a03: Expected Obj, but got I
		//IL_0a13: Expected Obj, but got I
		//IL_0a1d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 32;
		_ = 0;
		string text = default;
		object obj5;
		if (result == WWWRequestResult.Success)
		{
			Dictionary<string, string> dictionary = StringUtility.ParseProperties(output);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj4 = default;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				string checksum = GetChecksum(text);
				string a = default;
				if (string.Equals(a, checksum, StringComparison.InvariantCultureIgnoreCase))
				{
					if (text != null)
					{
						obj5 = 0;
						if (text._stringLength != 0)
						{
							goto IL_1326;
						}
					}
					obj5 = 1;
					goto IL_1326;
				}
			}
		}
		goto IL_1309;
		IL_1309:
		if (cookie != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S0_v20+C] (should have been resolved before IL gen)");
		}
		bool flag = default;
		FriendConsolidationDidFinish(flag);
		return;
		IL_121e:
		_ = 0;
		object obj6 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag2 = (nint)0 != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		SocialManager socialManager = (SocialManager)0;
		if (!flag2)
		{
			goto IL_127a;
		}
		goto IL_12c9;
		IL_12c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_0deb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag3 = (nint)0 == 1;
		int num = (flag ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		socialManager = (SocialManager)0;
		if (flag3)
		{
			goto IL_127a;
		}
		object obj8 = default;
		object obj7 = obj8;
		goto IL_12c9;
		IL_127a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		flag = (byte)num != 0;
		goto IL_1309;
		IL_1326:
		object obj23 = default;
		if (obj5 != null)
		{
			_friends = null;
		}
		else
		{
			string[][] array = StringUtility.ParseSets(text);
			List<Friend> list = default;
			list._002Ector(array.Length);
			_friends = list;
			object obj9 = this - -64;
			bool flag27;
			nint num3;
			object obj13 = default;
			object obj15 = default;
			string text5 = default;
			IDictionary<string, FacebookProfile> dictionary3 = default;
			IDictionary<string, FacebookProfile> dictionary5 = default;
			string text6 = default;
			int stringLength = default;
			char firstChar = default;
			object obj18 = default;
			IDictionary<string, Friend.Status> friendStatus = default;
			object obj19 = default;
			object obj20 = default;
			object obj21 = default;
			object obj24 = default;
			string text11 = default;
			string text12 = default;
			object obj36 = default;
			string text14 = default;
			object obj39 = default;
			string text15 = default;
			for (nint num2 = unchecked((nint)null); (flag ? 1 : 0) < array.Length; flag27 = (byte)((flag ? 1u : 0u) + 1u) != 0, flag = flag27, num2 = num3)
			{
				object obj10 = (flag ? 1u : 0u) << 2;
				object obj11 = (object)array + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v180+10]");
				string[] array2 = (string[])0;
				object obj12;
				object obj14;
				string text4;
				IDictionary<string, FacebookProfile> dictionary2;
				IDictionary<string, FacebookProfile> dictionary4;
				if (array2.Length >= 6)
				{
					string text2 = array2[1];
					if (text2._stringLength <= 0)
					{
						string text3 = array2[2];
						if (text3._stringLength < 1)
						{
							goto IL_0e64;
						}
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 == 1;
					obj12 = obj13;
					obj14 = obj15;
					text4 = text5;
					dictionary2 = dictionary3;
					dictionary4 = dictionary5;
					if (!flag4)
					{
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag5 = (nint)0 == 1;
						obj12 = obj13;
						obj14 = obj15;
						text4 = text5;
						dictionary2 = dictionary3;
						dictionary4 = dictionary5;
						if (!flag5)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag6 = (nint)0 == 1;
							obj12 = obj13;
							obj14 = obj15;
							text4 = text5;
							dictionary2 = dictionary3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							dictionary4 = (IDictionary<string, FacebookProfile>)0;
							if (!flag6)
							{
								text6._stringLength = stringLength;
								string text7 = array2[2];
								if (text7._stringLength >= 1)
								{
									_ = 0;
									if (_fbProfiles != null)
									{
										_ = 0;
										obj14 = obj + 60;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag7 = (nint)0 == 1;
										obj12 = 60;
										text4 = text7;
										dictionary2 = _fbProfiles;
										dictionary4 = _fbProfiles;
										num2 = (nint)typeof(IDictionary<string, FacebookProfile>);
										if (flag7)
										{
											goto IL_0b90;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
										object obj16 = 0;
										obj13 = 60;
										obj15 = obj14;
										text5 = text7;
										dictionary3 = _fbProfiles;
										num2 = (nint)typeof(IDictionary<string, FacebookProfile>);
									}
									else
									{
										object obj16 = 0;
									}
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag8 = (nint)0 == 1;
								obj12 = obj13;
								obj14 = obj15;
								text4 = text5;
								dictionary2 = dictionary3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								dictionary4 = (IDictionary<string, FacebookProfile>)0;
								if (!flag8)
								{
									text6._firstChar = firstChar;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag9 = (nint)0 == 1;
									obj12 = obj13;
									obj14 = obj15;
									text4 = text5;
									dictionary2 = dictionary3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									dictionary4 = (IDictionary<string, FacebookProfile>)0;
									if (!flag9)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag10 = (nint)0 == 1;
										obj12 = obj13;
										obj14 = obj15;
										text4 = text5;
										dictionary2 = dictionary3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										dictionary4 = (IDictionary<string, FacebookProfile>)0;
										if (!flag10)
										{
											bool flag11 = array2.Length > 6;
											bool flag12 = !flag11;
											object obj17 = 0;
											if (!flag12)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag13 = (nint)0 == 1;
												obj17 = obj18;
												obj12 = obj13;
												obj14 = obj15;
												text4 = text5;
												dictionary2 = dictionary3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												dictionary4 = (IDictionary<string, FacebookProfile>)0;
												if (flag13)
												{
													goto IL_0b90;
												}
											}
											if (_friendStatus != null)
											{
												goto IL_13df;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag14 = (nint)0 == 1;
											obj12 = obj13;
											obj14 = obj15;
											text4 = text5;
											dictionary2 = dictionary3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											dictionary4 = (IDictionary<string, FacebookProfile>)0;
											if (!flag14)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag15 = (nint)0 == 1;
												obj12 = obj13;
												obj14 = obj15;
												text4 = text5;
												dictionary2 = dictionary3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												dictionary4 = (IDictionary<string, FacebookProfile>)0;
												if (!flag15)
												{
													_friendStatus = friendStatus;
													goto IL_13df;
												}
											}
										}
									}
								}
							}
						}
					}
					goto IL_0b90;
				}
				goto IL_0e64;
				IL_0e64:
				string text8 = string.Join(";", array2);
				string text9 = "Malformed friend: (" + text8 + ")";
				num3 = unchecked((nint)null);
				continue;
				IL_0b90:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag16 = obj19 != obj20;
				obj7 = obj21;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj22 = obj23;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj24 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
								object obj25 = (nint)0 << 2;
								object obj26 = obj3 + obj25;
								obj26 = obj23;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
								object obj27 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
								object obj28 = (nint)0 << 2;
								object obj29 = obj28 + obj3;
								object obj30 = obj29 - 4;
								object obj31 = obj30;
								object obj32 = obj31;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v968 @ S1_v149+D4] (should have been resolved before IL gen)");
								string text10 = "Friend parse error " + text11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
								object obj33 = -1;
								obj13 = obj12;
								obj15 = obj14;
								text5 = text4;
								dictionary3 = dictionary2;
								dictionary5 = dictionary4;
								num3 = num2;
								continue;
							}
							goto IL_0d86;
						}
					}
					goto IL_0deb;
				}
				goto IL_12c9;
				IL_0a22:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag17 = (nint)0 == 1;
				obj12 = obj13;
				obj14 = obj15;
				text4 = text5;
				dictionary2 = dictionary3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				dictionary4 = (IDictionary<string, FacebookProfile>)0;
				if (!flag17)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag18 = (nint)0 == 1;
					obj12 = obj13;
					obj14 = obj15;
					text4 = text5;
					dictionary2 = dictionary3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					dictionary4 = (IDictionary<string, FacebookProfile>)0;
					if (!flag18)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+14]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+20]");
						object obj34;
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+20]");
							obj34 = (nint)0 + (nint)8;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+1C]");
							obj34 = (nint)0 + (nint)8;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag19 = (nint)0 == 1;
						obj12 = obj13;
						obj14 = obj15;
						text4 = text12;
						dictionary2 = (IDictionary<string, FacebookProfile>)obj34;
						dictionary4 = (IDictionary<string, FacebookProfile>)obj34;
						num2 = (nint)_friendStatus;
						if (!flag19)
						{
							_dirty = true;
							text5 = text12;
							dictionary2 = (IDictionary<string, FacebookProfile>)obj34;
							dictionary4 = (IDictionary<string, FacebookProfile>)obj34;
							string text13 = text12;
							goto IL_1414;
						}
					}
				}
				goto IL_0b90;
				IL_087c:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+1C]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+1C]");
				if ((nint)0 == 0)
				{
					goto IL_0a22;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag20 = (nint)0 == 1;
				obj12 = obj13;
				obj14 = obj15;
				text4 = text5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ S0_v351+8]");
				dictionary2 = (IDictionary<string, FacebookProfile>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				dictionary4 = (IDictionary<string, FacebookProfile>)0;
				num2 = (nint)_friendStatus;
				if (!flag20)
				{
					bool flag21 = obj36 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ S0_v351+8]");
					dictionary3 = (IDictionary<string, FacebookProfile>)0;
					num2 = (nint)_friendStatus;
					if (flag21)
					{
						goto IL_0a22;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+1C]");
					object obj37 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag22 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ S0_v406+8]");
					dictionary2 = (IDictionary<string, FacebookProfile>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					dictionary4 = (IDictionary<string, FacebookProfile>)0;
					string text13 = text14;
					if (flag22)
					{
						goto IL_1414;
					}
					obj12 = obj13;
					obj14 = obj15;
					text4 = text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ S0_v406+8]");
					dictionary2 = (IDictionary<string, FacebookProfile>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					dictionary4 = (IDictionary<string, FacebookProfile>)0;
					num2 = (nint)_friendStatus;
				}
				goto IL_0b90;
				IL_1414:
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag23 = (nint)0 != 1;
				obj12 = obj13;
				obj14 = obj15;
				text4 = text5;
				num2 = 0;
				dictionary3 = dictionary2;
				dictionary5 = dictionary4;
				num3 = 0;
				if (flag23)
				{
					continue;
				}
				goto IL_0b90;
				IL_13df:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+20]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+20]");
				if ((nint)0 == 0)
				{
					goto IL_087c;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag24 = (nint)0 == 1;
				obj12 = obj13;
				obj14 = obj15;
				text4 = text5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ S0_v336+8]");
				dictionary2 = (IDictionary<string, FacebookProfile>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				dictionary4 = (IDictionary<string, FacebookProfile>)0;
				num2 = (nint)_friendStatus;
				if (!flag24)
				{
					bool flag25 = obj39 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ S0_v336+8]");
					dictionary3 = (IDictionary<string, FacebookProfile>)0;
					num2 = (nint)_friendStatus;
					if (flag25)
					{
						goto IL_087c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v201 (System.String)+20]");
					object obj40 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag26 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ S0_v433+8]");
					dictionary2 = (IDictionary<string, FacebookProfile>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					dictionary4 = (IDictionary<string, FacebookProfile>)0;
					string text13 = text15;
					if (flag26)
					{
						goto IL_1414;
					}
					obj12 = obj13;
					obj14 = obj15;
					text4 = text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ S0_v433+8]");
					dictionary2 = (IDictionary<string, FacebookProfile>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					dictionary4 = (IDictionary<string, FacebookProfile>)0;
					num2 = (nint)_friendStatus;
				}
				goto IL_0b90;
			}
		}
		if (Flurry.ShouldLogDailyEvent("Social Friends Consolidated"))
		{
			List<Friend> friends = _friends;
			bool flag28 = _friends == null;
			num = 0;
			int count = 0;
			int num4 = 0;
			if (!flag28)
			{
				object obj41 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				object obj42 = obj + 40;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				num = 0;
				num4 = 0;
				object obj44 = default;
				object obj46 = default;
				object obj47 = default;
				object obj48 = default;
				object obj49 = default;
				while (true)
				{
					_ = 0;
					object obj43 = obj + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj44 == null)
						{
							break;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
						object obj45 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							int num5 = num4 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v144+20]");
							if ((nint)0 == 0)
							{
								num5 = num4;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S0_v144+1C]");
							bool flag29 = (nint)0 == 0;
							num4 = num5;
							if (!flag29)
							{
								int num6 = num + 1;
								num = num6;
								num4 = num5;
							}
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag30 = obj46 != obj47;
					obj7 = obj48;
					if (!flag30)
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
						obj7 = obj49;
					}
					goto IL_121e;
				}
				object obj50 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CFE");
				count = friends._size;
			}
			string text16 = Flurry.ConvertFriendCountToBracket(count);
			string text17 = Flurry.ConvertFriendCountToBracket(num4);
			string text18 = Flurry.ConvertFriendCountToBracket(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		bool flag31 = _latestPreConsolidationFacebookIds == null;
		flag = true;
		if (!flag31)
		{
			List<string> list2 = default;
			list2._002Ector((IEnumerable<string>)_latestPreConsolidationFacebookIds);
			_latestSuccesfullyConsolidatedFacebookIds = list2;
			flag = true;
		}
		goto IL_1309;
		IL_0d86:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
		object obj51 = obj23;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag32 = (nint)0 != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		socialManager = (SocialManager)0;
		if (!flag32)
		{
			goto IL_0deb;
		}
		goto IL_1309;
	}

	public unsafe void ReportScore(int newScore, bool isNewHighscore, int newMeters)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		if (_userid < 1)
		{
			return;
		}
		PlayerInfo playerInfo = PlayerInfo.Instance;
		int num = playerInfo.IncrementUnreportedGames();
		if (!isNewHighscore)
		{
			OnlineSettings onlineSettings = OnlineSettings.instance;
			int value = onlineSettings.GetValue("social_report_games_count", 5);
			if (value > num)
			{
				if (num < 2)
				{
					return;
				}
				DateTime now = CDateTime.Now;
				PlayerInfo playerInfo2 = PlayerInfo.Instance;
				DateTime firstUnreportedGameTimestamp = playerInfo2.GetFirstUnreportedGameTimestamp();
				TimeSpan forceReportScoreTimeSpan = ((SocialManager)num).GetForceReportScoreTimeSpan();
				DateTime dateTime = firstUnreportedGameTimestamp + forceReportScoreTimeSpan;
				if (!(now > dateTime))
				{
					return;
				}
			}
		}
		WWWComplete wWWComplete = default;
		wWWComplete._002Ector(this, (nint)__ldftn(SocialManager.WWWReportScoreCompleted));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void WWWReportScoreCompleted(WWWRequestResult result, string output, object cookie)
	{
		if (result == WWWRequestResult.Success)
		{
			PlayerInfo playerInfo = PlayerInfo.Instance;
			playerInfo._dirty = true;
			playerInfo._unreportedGames = 0;
		}
	}

	private unsafe TimeSpan GetForceReportScoreTimeSpan()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected VT, but got Unknown
		//IL_0091: Expected native int or pointer, but got VT
		//IL_00a3: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		OnlineSettings onlineSettings = OnlineSettings.instance;
		int value = onlineSettings.GetValue("social_report_min_seconds", 1200);
		_ = 0;
		TimeSpan timeSpan = (TimeSpan)(obj + 8);
		bool flag = value > -1;
		int seconds = value;
		if (!flag)
		{
			seconds = 1200;
		}
		*(TimeSpan*)(nint)timeSpan = new TimeSpan(0, 0, seconds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		return (TimeSpan)0;
	}

	public unsafe void UpdateFriendScores(Action<bool> updateFriendsScoresCompleted)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a9: Invalid comparison between F8 and I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected Obj, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0371: Expected I, but got Obj
		//IL_016f: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I4
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<Friend> friends = _friends;
		if (_friends == null || friends._size == 0)
		{
			return;
		}
		DateTime now = CDateTime.Now;
		TimeSpan timeSpan = now - _lastFriendScoreUpdateTimestamp;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		double num = 0.0 * 1E-07;
		OnlineSettings onlineSettings = OnlineSettings.instance;
		int value = onlineSettings.GetValue("social_friendscores_min_seconds", 120);
		if (num < (double)value)
		{
			return;
		}
		_lastFriendScoreUpdateTimestamp = now;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 24;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		WWWComplete wWWComplete = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					goto IL_0351;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj8 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if ((nint)obj8 >= 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_02c2;
							}
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
			goto IL_02c2;
			IL_0351:
			object obj9 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CFE");
			nint num2 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ S1_v36 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			wWWComplete._002Ector(this, (nint)__ldftn(SocialManager.WWWUpdateFriendScoresCompleted));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
			IL_02c2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj10 != obj11;
			object obj12 = obj13;
			if (flag)
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
				goto IL_0351;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj12 = obj14;
			break;
		}
		_ = 0;
		object obj15 = obj + 8;
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
	}

	private void WWWUpdateFriendScoresCompleted(WWWRequestResult result, string output, object cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected Obj, but got Unknown
		//IL_09fb: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0a2f: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_072d: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0873: Expected Obj, but got I
		//IL_089e: Expected Obj, but got I
		//IL_08c8: Expected Obj, but got I
		//IL_08d6: Expected Obj, but got I4
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected Obj, but got Unknown
		//IL_068d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		object obj4 = 0;
		if (result == WWWRequestResult.Success)
		{
			Dictionary<string, string> dictionary = StringUtility.ParseProperties(output);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj5 = default;
			bool flag = obj5 == null;
			obj4 = 0;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
				string data = default;
				string checksum = GetChecksum(data);
				string a = default;
				if (string.Equals(a, checksum, StringComparison.InvariantCultureIgnoreCase))
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_076b;
					}
					object obj6 = 0;
					object obj9 = default;
					object obj11 = default;
					object obj13 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v38+C]");
						if (0 <= (nint)obj6)
						{
							break;
						}
						object obj7 = obj6 << 2;
						object obj8 = obj9 + obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v119+10]");
						object obj10 = 0;
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
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v120+C]");
								if ((nint)0 <= (nint)3)
								{
									goto IL_01c2;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									goto IL_0567;
								}
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
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											goto IL_0585;
										}
										if (obj11 == null)
										{
											goto IL_0741;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											goto IL_06e8;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											goto IL_06f7;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											goto IL_0706;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v120+C]");
										bool flag2 = (nint)0 > (nint)4;
										bool flag3 = !flag2;
										object obj12 = 0;
										if (!flag3)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag4 = (nint)0 == 1;
											obj12 = obj13;
											if (!flag4)
											{
												goto IL_0741;
											}
											goto IL_0715;
										}
										goto IL_0741;
									}
								}
								goto IL_0576;
							}
						}
						goto IL_0732;
						IL_0741:
						object obj14 = obj6 + 1;
						obj6 = obj14;
					}
					obj4 = 1;
				}
				else
				{
					obj4 = 0;
				}
			}
		}
		goto IL_0a09;
		IL_06e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_076b;
		IL_0706:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_076b;
		IL_0715:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_076b;
		IL_0567:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_076b;
		IL_0576:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_076b;
		IL_06f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_076b;
		IL_076b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj15 = default;
		object obj16 = default;
		bool flag5 = obj15 == obj16;
		bool flag6 = !flag5;
		object obj17 = default;
		obj4 = obj17;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj19 = default;
				object obj18 = obj19;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj20 = default;
					if (obj20 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj21 = (nint)0 << 2;
						object obj22 = obj3 + obj21;
						obj22 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj23 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
						object obj24 = -1;
						obj4 = 0;
						goto IL_0a09;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj25 = obj19;
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
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag7 = (nint)0 == 1;
			object obj26 = default;
			obj4 = obj26;
			if (flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_0a09;
		IL_0585:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_076b;
		IL_01c2:
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
													return;
												}
											}
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_076b;
							}
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_076b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_076b;
		IL_0a09:
		if (cookie != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S0_v17+C] (should have been resolved before IL gen)");
		}
		return;
		IL_0732:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_076b;
	}

	public string GetNameForRelation(Friend friend)
	{
		if (friend.fbProfile != null)
		{
			FacebookProfile fbProfile = _fbProfile;
			if (_fbProfile != null)
			{
				return fbProfile.fullName;
			}
		}
		else
		{
			GameCenterProfile gcProfile = _gcProfile;
			if (_gcProfile != null)
			{
				return gcProfile.alias;
			}
		}
		return null;
	}

	public void Poke(Friend friend, PokeType pokeType)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got VT
		//IL_0034: Expected Obj, but got I4
		MissionsManager missionsManager = MissionsManager.Instance;
		missionsManager.PlayerDidThis(MissionTarget.PokeFriend);
		string nameForRelation = GetNameForRelation(friend);
		bool flag = pokeType == PokeType.Duel;
		object obj = 16;
		if (!flag)
		{
			obj = 8;
		}
		object obj2 = (object)friend.status + obj;
		DateTime utcNow = CDateTime.UtcNow;
		obj2 = utcNow;
		if (!flag)
		{
		}
		_dirty = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void SetPokeFirstTime(Friend friend)
	{
		Friend.Status status = friend.status;
		DateTime utcNow = CDateTime.UtcNow;
		status.lastPokeTime = utcNow;
		_dirty = true;
	}

	public void BragNotify(int oldScore, List<Friend> friends)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected Obj, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_0444: Expected Obj, but got I4
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected Obj, but got Unknown
		//IL_00f2: Expected Obj, but got I
		//IL_07c2: Expected Obj, but got I
		//IL_0512: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		if (friends == null)
		{
			return;
		}
		int capacity = friends._size << 3;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(capacity);
		int capacity2 = friends._size << 1;
		StringBuilder stringBuilder2 = default;
		stringBuilder2._002Ector(capacity2);
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 40;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_0415;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v142+20]");
					bool flag = (nint)0 != 0;
					bool flag2 = (byte)((flag ? 1u : 0u) | 2u) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v142+1C]");
					if ((nint)0 == 0)
					{
						flag2 = flag;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (!flag2)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v142+8]");
						if ((nint)0 == 0)
						{
							continue;
						}
						_ = 0;
						object obj8 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if ((nint)obj8 < 1)
							{
								goto IL_0295;
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
									goto IL_0295;
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
			goto IL_0386;
			IL_0386:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj9 != obj10;
			object obj11 = obj12;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0415;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_0415:
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CFE");
			object obj16 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
			if ((nint)obj16 > 0)
			{
				if (_fbProfile == null)
				{
				}
				break;
			}
			return;
			IL_0295:
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
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0386;
		}
		GameCenter.LocalPlayer localPlayer = GameCenter.GetLocalPlayer();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
			string text = (string)0;
		}
		else
		{
			string text = string.Empty;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void AnnounceToFriends(int relationsMask)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0450: Expected Obj, but got I4
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_00ed: Expected Obj, but got I
		//IL_0566: Expected Obj, but got I
		//IL_0593: Expected Obj, but got I
		//IL_05a3: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<Friend> friends = _friends;
		if (_friends == null)
		{
			return;
		}
		int capacity = friends._size << 3;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector(capacity);
		int capacity2 = friends._size << 1;
		StringBuilder stringBuilder2 = default;
		stringBuilder2._002Ector(capacity2);
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_0421;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v155+20]");
					bool flag = (nint)0 != 0;
					bool flag2 = (byte)((flag ? 1u : 0u) | 2u) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v155+1C]");
					if ((nint)0 == 0)
					{
						flag2 = flag;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (((uint)relationsMask & (flag2 ? 1u : 0u)) == 0)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v155+8]");
						if ((nint)0 == 0)
						{
							continue;
						}
						_ = 0;
						object obj8 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if ((nint)obj8 < 1)
							{
								goto IL_02a1;
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
									goto IL_02a1;
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
			goto IL_0392;
			IL_07f3:
			string empty = string.Empty;
			break;
			IL_02a1:
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
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0392;
			IL_0392:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj9 != obj10;
			object obj11 = obj12;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0421;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				goto IL_07f3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_0421:
			object obj15 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CFE");
			object obj16 = stringBuilder.m_ChunkOffset + stringBuilder.m_ChunkLength;
			if ((nint)obj16 <= 0)
			{
				return;
			}
			if ((relationsMask & 1) != 0)
			{
				FacebookProfile fbProfile = _fbProfile;
				if (_fbProfile != null)
				{
					empty = fbProfile.fullName;
					break;
				}
			}
			goto IL_07f3;
		}
		GameCenter.LocalPlayer localPlayer = GameCenter.GetLocalPlayer();
		string text;
		string text2;
		if ((relationsMask & 2) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1D]");
			object obj17 = (nint)0 & (nint)1;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
				text2 = (string)0;
				goto IL_0835;
			}
		}
		text = string.Empty;
		text2 = string.Empty;
		goto IL_0835;
		IL_0835:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private static string GetDeviceTypeString()
	{
		return "Android Device";
	}

	public unsafe void UpdateRemoteNotificationControl(bool newValue)
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		if (~(playerInfo._remoteNotificationsEnabled ? 1u : 0u) == 0 && !newValue)
		{
			if (~(canUnregisterDevice__BackingField ? 1u : 0u) == 0)
			{
				throw new ArgumentException();
			}
		}
		else
		{
			requestInvolvingDevicetokenInProgress__BackingField = true;
			RemoteNotificationControl.RemoteNotificationsEnabledHandler remoteNotificationsEnabledHandler = default;
			remoteNotificationsEnabledHandler._002Ector(this, (nint)__ldftn(SocialManager.OnRemoteNotificationsEnabled));
			RemoteNotificationControl.Enable(remoteNotificationsEnabledHandler, "cpush.wav");
		}
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public unsafe SocialManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected VT, but got Unknown
		//IL_0082: Expected I8, but got I4
		//IL_007d: Expected native int or pointer, but got VT
		//IL_0094: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_appHasFocus = true;
		_ = 0;
		DateTime dateTime = (DateTime)(obj + 8);
		*(DateTime*)(nint)dateTime = new DateTime(0L);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_lastFriendScoreUpdateTimestamp = (DateTime)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private void _003COnGameCenterAuthentication_003Eb__144_0(string playerID, Texture2D photo, string photoError)
	{
		GameCenterProfile gcProfile = _gcProfile;
		if (_gcProfile != null)
		{
			gcProfile.image = photo;
		}
	}

	private void _003CInvalidate_003Eb__168_1(bool success)
	{
		if (success)
		{
			if (FacebookSession.HasOpenInstance())
			{
				int num = _consolidationState | 1;
				_consolidationState = num;
			}
			SocialManagerIOS socialManagerIOS = SocialManagerIOS.instance;
			if (socialManagerIOS._gcState == SocialManagerIOS.GCState.LoggedIn)
			{
				int num2 = _consolidationState | 2;
				_consolidationState = num2;
			}
		}
		_consolidatedFriendsCompleted = true;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		_lastConsolidateFriendCompleteTime = realtimeSinceStartup;
	}

	private void _003CAwake_003Eb__181_0(bool _003Cp0_003E)
	{
		AttemptRelogin();
		Invalidate();
	}

	private void _003CUpdateRemoteNotificationControl_003Eb__212_0(bool _003Cp0_003E)
	{
		requestInvolvingDevicetokenInProgress__BackingField = false;
	}
}
