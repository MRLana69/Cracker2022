using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.Google.Internal;
using Kiloo.Plugins;
using Kiloo.Plugins.Facebook;
using SYBO.Subway.Level;
using SYBO.Subway.Level.Environments;
using UnityEngine;
using UnityEngine.Networking;

namespace Kiloo.GameCenter;

public class GameCenterPlugin : MonoBehaviour
{
	[StructLayout((LayoutKind)0, Size = 16)]
	public struct Player
	{
		public string playerID;

		public string alias;

		public string displayName;

		public bool isFriend;
	}

	[StructLayout((LayoutKind)0, Size = 20)]
	public struct LocalPlayer
	{
		public string playerID;

		public string alias;

		public string displayName;

		public bool underage;

		public bool authenticated;
	}

	public struct Score
	{
		public string playerID;

		public int rank;

		public long value;

		public string formattedValue;

		public DateTime date;

		public ulong context;
	}

	public class Leaderboard
	{
		public string category;

		public int rangeBegin;

		public int rangeCount;

		public LeaderboardPlayerScope playerScope;

		public LeaderboardTimeScope timeScope;

		public Score localPlayerScore;

		public Score[] scores;

		public string groupIdentifier;

		public uint maxRange;

		public string title;

		public Leaderboard()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public class Achievement
	{
		public string identifier;

		public float percentComplete;

		public DateTime lastReportedDate;

		public bool complete
		{
			get
			{
				//IL_0007: Expected I4, but got F4
				return (byte)(int)percentComplete != 0;
			}
		}
	}

	public class AchievementDescription
	{
		public string identifier;

		public string title;

		public string unachievedDescription;

		public string achievedDescription;

		public int maximumPoints;

		public bool replayable;

		public bool hidden;

		public string groupIdentifier;
	}

	public enum PhotoSize
	{
		Small,
		Normal
	}

	public enum ShowViewState
	{
		Default = -1,
		LeaderBoards,
		Achievements,
		Challenges
	}

	public enum LeaderboardTimeScope
	{
		Today,
		Week,
		AllTime
	}

	public enum LeaderboardPlayerScope
	{
		Global,
		FriendsOnly
	}

	public delegate void AuthenticateHandler(bool hasLoginView, string error);

	public delegate void GenerateIdentityVerificationSignatureCompletionHandler(string publicKeyUrl, byte[] signature, byte[] salt, ulong timestamp, string error);

	public delegate void LoadFriendsCompletionHandler(string[] friends, string error);

	public delegate void LoadPlayersCompletionHandler(Player[] players, string error);

	public delegate void LoadPhotoCompletionHandler(string playerID, Texture2D photo, string error);

	private delegate void InternalLoadPhotoCompletionHandler(int imgWidth, int imgHeight, string error);

	public delegate void ViewDismissedHandler(ShowViewState viewState, string leaderboardCategory, LeaderboardTimeScope leaderboardTimeScope);

	public delegate void RequestCompleteHandler(string error);

	public delegate void LoadLeaderboardCompletionHandler(Leaderboard leaderboard, string error);

	public delegate void LoadAchievementsCompletionHandler(Achievement[] achievements, string error);

	public delegate void LoadAchievementDescriptionsCompletionHandler(AchievementDescription[] achievements, string error);

	private class GenerateIdentityVerificationSignatureResult
	{
		public int context;

		public string publicKeyUrl;

		public string signature;

		public string salt;

		public ulong timestamp;

		public string error;
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public bool canceled;

		public GameCenterGenerateIdentityVerificationSignatureRequest request;

		public bool working;

		internal void _003CGenerateIdentityVerificationSignatureCoroutine_003Eb__0(string publicKeyUrl, byte[] signature, byte[] salt, ulong timestamp, string error)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected Obj, but got Unknown
			//IL_0012: Expected I, but got Obj
			//IL_0028: Expected Obj, but got I
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected Obj, but got Unknown
			//IL_006d: Expected I, but got Obj
			//IL_0083: Expected Obj, but got I
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected Obj, but got Unknown
			//IL_00ab: Expected Obj, but got I4
			//IL_00d4: Expected Obj, but got I4
			//IL_00f0: Expected Obj, but got I4
			//IL_0116: Expected Obj, but got I4
			object obj = error - timestamp;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S4_v3 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin+<>c__DisplayClass51_0>)+134]");
			object obj2 = (nint)0 & (nint)0x1FFF;
			object obj3 = obj2 + 30963;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S4_v6 (should have been resolved before IL gen)");
			if ((nint)salt > 0)
			{
				object obj7 = default;
				object obj12;
				do
				{
					object obj4 = 0 * 12;
					object obj5 = (object)signature + obj4;
					object obj6 = obj7 + obj5;
					object obj8 = 0 * 12;
					object obj9 = (object)signature + obj8;
					object obj10 = 0 * 12;
					object obj11 = (object)signature + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12367");
					obj12 = 0 + 1;
				}
				while (obj12 != salt);
			}
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v5 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin+<>c__DisplayClass51_0>)+138]");
			object obj13 = (nint)0 & (nint)0x3FFF;
			object obj14 = obj13 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S3_v8 (should have been resolved before IL gen)");
		}
	}

	private sealed class _003CGenerateIdentityVerificationSignatureCoroutine_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterGenerateIdentityVerificationSignatureRequest request;

		private _003C_003Ec__DisplayClass51_0 _003C_003E8__1;

		private float _003CstartTime_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Expected Obj, but got Unknown
				//IL_0117: Expected I, but got Obj
				//IL_012d: Expected Obj, but got I
				//IL_0158: Expected I, but got Obj
				//IL_0305: Unknown result type (might be due to invalid IL or missing references)
				//IL_030a: Expected Obj, but got Unknown
				//IL_0313: Expected Obj, but got I4
				//IL_0327: Expected Obj, but got I4
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
					object obj = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					object obj3 = _003C_003E8__1 + 12;
					obj3 = request;
					_003C_003Ec__DisplayClass51_0 obj4 = _003C_003E8__1;
					obj4.working = true;
					_003C_003Ec__DisplayClass51_0 obj5 = _003C_003E8__1;
					obj5.canceled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					LoadFriendsCompletionHandler loadFriendsCompletionHandler = default;
					((Delegate)loadFriendsCompletionHandler).method_ptr = method_ptr;
					((Delegate)loadFriendsCompletionHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass51_0._003CGenerateIdentityVerificationSignatureCoroutine_003Eb__0);
					object obj6 = loadFriendsCompletionHandler + 16;
					obj6 = _003C_003E8__1;
					_003C_003Ec__DisplayClass51_0 obj7 = _003C_003E8__1;
					GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest = obj7.request;
					((GameCenterRequest)gameCenterGenerateIdentityVerificationSignatureRequest).isDone__BackingField = false;
					nint num = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num2 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v64 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					LoadFriends(loadFriendsCompletionHandler);
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
				}
				_003C_003Ec__DisplayClass51_0 obj9 = _003C_003E8__1;
				if (~(obj9.working ? 1u : 0u) == 0)
				{
					_003C_003Ec__DisplayClass51_0 obj10 = _003C_003E8__1;
					GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest2 = obj10.request;
					if (((GameCenterRequest)gameCenterGenerateIdentityVerificationSignatureRequest2).timeout__BackingField > 0f)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num3 = maxDelay2 - _003CstartTime_003E5__2;
						_003C_003Ec__DisplayClass51_0 obj11 = _003C_003E8__1;
						GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest3 = obj11.request;
						if (num3 > ((GameCenterRequest)gameCenterGenerateIdentityVerificationSignatureRequest3).timeout__BackingField)
						{
							_003C_003Ec__DisplayClass51_0 obj12 = _003C_003E8__1;
							obj12.canceled = true;
							_003C_003Ec__DisplayClass51_0 obj13 = _003C_003E8__1;
							GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest4 = obj13.request;
							((GameCenterRequest)gameCenterGenerateIdentityVerificationSignatureRequest4).didTimeout__BackingField = true;
							goto IL_032c;
						}
					}
					object obj14 = this + 12;
					obj14 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_032c;
				IL_032c:
				_003C_003Ec__DisplayClass51_0 obj15 = _003C_003E8__1;
				GameCenterGenerateIdentityVerificationSignatureRequest gameCenterGenerateIdentityVerificationSignatureRequest5 = obj15.request;
				((GameCenterRequest)gameCenterGenerateIdentityVerificationSignatureRequest5).isDone__BackingField = true;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGenerateIdentityVerificationSignatureCoroutine_003Ed__51(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_000b: Invalid comparison between Obj and F4
			return System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref _003C_003E2__current) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)100f);
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

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public bool canceled;

		public GameCenterLoadFriendsRequest request;

		public bool working;

		public _003C_003Ec__DisplayClass55_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CLoadFriendsCoroutine_003Eb__0(string[] result, string error)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_061e: Expected Obj, but got I
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_062c: Expected Obj, but got Unknown
			//IL_01d7: Expected Obj, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected Obj, but got Unknown
			//IL_0671: Unknown result type (might be due to invalid IL or missing references)
			//IL_0676: Expected Obj, but got Unknown
			//IL_05b9: Expected Obj, but got I
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c7: Expected Obj, but got Unknown
			//IL_05da: Expected Obj, but got I4
			//IL_019b: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			//IL_01bc: Expected Obj, but got I4
			//IL_0402: Expected Obj, but got I
			//IL_0297: Expected Obj, but got I
			//IL_04c8: Expected Obj, but got I
			//IL_02f1: Expected Obj, but got I
			//IL_048c: Expected Obj, but got I
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Expected Obj, but got Unknown
			//IL_04ad: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.GameCenter.GameCenterPlugin+<>c__DisplayClass55_0)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.GameCenter.GameCenterPlugin+<>c__DisplayClass55_0)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.GameCenter.GameCenterPlugin+<>c__DisplayClass55_0)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj25 = default;
			object obj17 = default;
			object obj23 = default;
			for (; obj5 != obj3; obj5 = obj25 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+14]");
				string text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String)+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String)+2A]");
				bool flag = (nint)0 == 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String)+24]");
				object obj10 = (nint)0 & (nint)0x10;
				bool flag2 = obj10 == null;
				object obj11 = (flag2 ? 1 : 0) ^ 1;
				string text3;
				string text2;
				if (obj11 != null)
				{
					if (flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj12 = (nint)0 & (nint)0x3FFF;
						text2 = (string)(obj12 + 97173);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.String) (should have been resolved before IL gen)");
						text3 = (string)97173;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x1FFF;
						text3 = (string)(obj13 + 113696);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (System.String) (should have been resolved before IL gen)");
						text2 = text;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String)+28]");
				bool flag3 = (nint)0 != -1;
				if (!flag)
				{
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
						bool flag4;
						if ((nint)0 != 0)
						{
							object obj14 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v94+9C]");
							object obj15 = (nint)0 & (nint)0x100;
							flag4 = obj15 != null;
						}
						else
						{
							flag4 = false;
						}
						if (!flag4 && request != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String)+2B]");
							object obj16 = (nint)0 & (nint)3;
							bool flag5 = (nint)obj16 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag5)
							{
								if (obj17 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A75");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A76");
								}
							}
							else if (obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
								text2 = error;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
							}
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
					object obj18 = (nint)0 & (nint)0x3FFF;
					text2 = (string)(obj18 + 97173);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.String) (should have been resolved before IL gen)");
					text3 = (string)97173;
					continue;
				}
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
					bool flag6;
					if ((nint)0 != 0)
					{
						object obj19 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v66+9C]");
						object obj20 = (nint)0 & (nint)0x100;
						flag6 = obj20 != null;
					}
					else
					{
						flag6 = false;
					}
					if (!flag6 && request != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
							object obj21 = (nint)0 & (nint)0x3FFF;
							text2 = (string)(obj21 + 97173);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.String) (should have been resolved before IL gen)");
							text3 = (string)97173;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String)+2B]");
						object obj22 = (nint)0 & (nint)3;
						bool flag7 = (nint)obj22 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag7)
						{
							if (obj23 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
								text2 = error;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
								text2 = error;
							}
						}
						else if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
							text3 = error;
							text2 = (string)(object)result;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
							text2 = error;
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
				object obj24 = (nint)0 & (nint)0x1FFF;
				text3 = (string)(obj24 + 113696);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (System.String) (should have been resolved before IL gen)");
				text2 = text;
			}
		}
	}

	private sealed class _003CLoadFriendsCoroutine_003Ed__55(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterLoadFriendsRequest request;

		private _003C_003Ec__DisplayClass55_0 _003C_003E8__1;

		private float _003CstartTime_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Expected Obj, but got Unknown
				//IL_0117: Expected I, but got Obj
				//IL_012d: Expected Obj, but got I
				//IL_0158: Expected I, but got Obj
				//IL_0305: Unknown result type (might be due to invalid IL or missing references)
				//IL_030a: Expected Obj, but got Unknown
				//IL_0313: Expected Obj, but got I4
				//IL_0327: Expected Obj, but got I4
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
					object obj = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					object obj3 = _003C_003E8__1 + 12;
					obj3 = request;
					_003C_003Ec__DisplayClass55_0 obj4 = _003C_003E8__1;
					obj4.working = true;
					_003C_003Ec__DisplayClass55_0 obj5 = _003C_003E8__1;
					obj5.canceled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					LoadAchievementsCompletionHandler loadAchievementsCompletionHandler = default;
					((Delegate)loadAchievementsCompletionHandler).method_ptr = method_ptr;
					((Delegate)loadAchievementsCompletionHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass55_0._003CLoadFriendsCoroutine_003Eb__0);
					object obj6 = loadAchievementsCompletionHandler + 16;
					obj6 = _003C_003E8__1;
					_003C_003Ec__DisplayClass55_0 obj7 = _003C_003E8__1;
					GameCenterLoadFriendsRequest gameCenterLoadFriendsRequest = obj7.request;
					((GameCenterRequest)gameCenterLoadFriendsRequest).isDone__BackingField = false;
					nint num = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num2 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v64 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					LoadAchievements(loadAchievementsCompletionHandler);
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
				}
				_003C_003Ec__DisplayClass55_0 obj9 = _003C_003E8__1;
				if (~(obj9.working ? 1u : 0u) == 0)
				{
					_003C_003Ec__DisplayClass55_0 obj10 = _003C_003E8__1;
					GameCenterLoadFriendsRequest gameCenterLoadFriendsRequest2 = obj10.request;
					if (((GameCenterRequest)gameCenterLoadFriendsRequest2).timeout__BackingField > 0f)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num3 = maxDelay2 - _003CstartTime_003E5__2;
						_003C_003Ec__DisplayClass55_0 obj11 = _003C_003E8__1;
						GameCenterLoadFriendsRequest gameCenterLoadFriendsRequest3 = obj11.request;
						if (num3 > ((GameCenterRequest)gameCenterLoadFriendsRequest3).timeout__BackingField)
						{
							_003C_003Ec__DisplayClass55_0 obj12 = _003C_003E8__1;
							obj12.canceled = true;
							_003C_003Ec__DisplayClass55_0 obj13 = _003C_003E8__1;
							GameCenterLoadFriendsRequest gameCenterLoadFriendsRequest4 = obj13.request;
							((GameCenterRequest)gameCenterLoadFriendsRequest4).didTimeout__BackingField = true;
							goto IL_032c;
						}
					}
					object obj14 = this + 12;
					obj14 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_032c;
				IL_032c:
				_003C_003Ec__DisplayClass55_0 obj15 = _003C_003E8__1;
				GameCenterLoadFriendsRequest gameCenterLoadFriendsRequest5 = obj15.request;
				((GameCenterRequest)gameCenterLoadFriendsRequest5).isDone__BackingField = true;
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

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public bool canceled;

		public GameCenterLoadPlayersRequest request;

		public bool working;

		public _003C_003Ec__DisplayClass59_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CLoadPlayersCoroutine_003Eb__0(Player[] result, string error)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			if (~(canceled ? 1u : 0u) != 0)
			{
				object obj = request + 20;
				obj = result;
				object obj2 = request + 16;
				obj2 = error;
			}
			working = false;
		}
	}

	private sealed class _003CLoadPlayersCoroutine_003Ed__59(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterLoadPlayersRequest request;

		private _003C_003Ec__DisplayClass59_0 _003C_003E8__1;

		private float _003CstartTime_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Expected Obj, but got Unknown
				//IL_010b: Expected I, but got Obj
				//IL_0121: Expected Obj, but got I
				//IL_014c: Expected I, but got Obj
				//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ff: Expected Obj, but got Unknown
				//IL_0308: Expected Obj, but got I4
				//IL_031c: Expected Obj, but got I4
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
					object obj = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					object obj3 = _003C_003E8__1 + 12;
					obj3 = request;
					_003C_003Ec__DisplayClass59_0 obj4 = _003C_003E8__1;
					obj4.working = true;
					_003C_003Ec__DisplayClass59_0 obj5 = _003C_003E8__1;
					obj5.canceled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num = 0;
					string text = default;
					text.m_stringLength = (int)num;
					_ = 0;
					object obj6 = text + 16;
					obj6 = _003C_003E8__1;
					_003C_003Ec__DisplayClass59_0 obj7 = _003C_003E8__1;
					GameCenterLoadPlayersRequest gameCenterLoadPlayersRequest = obj7.request;
					((GameCenterRequest)gameCenterLoadPlayersRequest).isDone__BackingField = false;
					nint num2 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v62 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num3 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v68 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((GameCenterPlugin)null).OnGameCenterAuthenticationEvent(text);
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
				}
				_003C_003Ec__DisplayClass59_0 obj9 = _003C_003E8__1;
				if (~(obj9.working ? 1u : 0u) == 0)
				{
					_003C_003Ec__DisplayClass59_0 obj10 = _003C_003E8__1;
					GameCenterLoadPlayersRequest gameCenterLoadPlayersRequest2 = obj10.request;
					if (((GameCenterRequest)gameCenterLoadPlayersRequest2).timeout__BackingField > 0f)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num4 = maxDelay2 - _003CstartTime_003E5__2;
						_003C_003Ec__DisplayClass59_0 obj11 = _003C_003E8__1;
						GameCenterLoadPlayersRequest gameCenterLoadPlayersRequest3 = obj11.request;
						if (num4 > ((GameCenterRequest)gameCenterLoadPlayersRequest3).timeout__BackingField)
						{
							_003C_003Ec__DisplayClass59_0 obj12 = _003C_003E8__1;
							obj12.canceled = true;
							_003C_003Ec__DisplayClass59_0 obj13 = _003C_003E8__1;
							GameCenterLoadPlayersRequest gameCenterLoadPlayersRequest4 = obj13.request;
							((GameCenterRequest)gameCenterLoadPlayersRequest4).didTimeout__BackingField = true;
							goto IL_0321;
						}
					}
					object obj14 = this + 12;
					obj14 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_0321;
				IL_0321:
				_003C_003Ec__DisplayClass59_0 obj15 = _003C_003E8__1;
				GameCenterLoadPlayersRequest gameCenterLoadPlayersRequest5 = obj15.request;
				((GameCenterRequest)gameCenterLoadPlayersRequest5).isDone__BackingField = true;
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

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public bool canceled;

		public GameCenterLoadPhotoRequest request;

		public bool working;

		internal void _003CLoadPhotoCoroutine_003Eb__0(string id, Texture2D result, string error)
		{
			//IL_014c: Expected Obj, but got I4
			//IL_0177: Expected Obj, but got I4
			//IL_004a: Expected VT, but got I4
			//IL_005b: Expected Obj, but got I4
			//IL_0073: Expected I, but got Obj
			//IL_0089: Expected Obj, but got I
			//IL_00b4: Expected I, but got Obj
			object obj = 0;
			bool flag = id == null;
			bool flag2 = (object)result == null;
			object obj2 = flag | flag2;
			if (obj2 == null)
			{
				GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest = request;
				GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest2 = request;
				float num = (float)(((GameCenterRequest)gameCenterLoadPhotoRequest).didTimeout__BackingField ? 1 : 0) * ((GameCenterRequest)gameCenterLoadPhotoRequest2).timeout__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				GCHandle gCHandle = default;
				bool flag3 = gCHandle == (GCHandle)3;
				obj = flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B409");
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v34 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num3 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v39 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B40E");
			}
			GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest3 = request;
			if (((GameCenterRequest)gameCenterLoadPhotoRequest3).error__BackingField != null)
			{
				GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest4 = request;
				GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest5 = request;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
			}
		}
	}

	private sealed class _003CLoadPhotoCoroutine_003Ed__65(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterLoadPhotoRequest request;

		private _003C_003Ec__DisplayClass65_0 _003C_003E8__1;

		private float _003CstartTime_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Expected Obj, but got Unknown
				//IL_015c: Expected I, but got Obj
				//IL_0172: Expected Obj, but got I
				//IL_0343: Expected Obj, but got I4
				//IL_019d: Expected I, but got Obj
				//IL_0366: Unknown result type (might be due to invalid IL or missing references)
				//IL_036b: Expected Obj, but got Unknown
				//IL_0374: Expected Obj, but got I4
				//IL_0388: Expected Obj, but got I4
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
					object obj = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					object obj3 = _003C_003E8__1 + 12;
					obj3 = request;
					_003C_003Ec__DisplayClass65_0 obj4 = _003C_003E8__1;
					obj4.working = true;
					_003C_003Ec__DisplayClass65_0 obj5 = _003C_003E8__1;
					obj5.canceled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					FacebookSession.RequestCompleteHandler requestCompleteHandler = default;
					((Delegate)requestCompleteHandler).method_ptr = method_ptr;
					((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass65_0._003CLoadPhotoCoroutine_003Eb__0);
					object obj6 = requestCompleteHandler + 16;
					obj6 = _003C_003E8__1;
					_003C_003Ec__DisplayClass65_0 obj7 = _003C_003E8__1;
					GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest = obj7.request;
					((GameCenterRequest)gameCenterLoadPhotoRequest).isDone__BackingField = false;
					_003C_003Ec__DisplayClass65_0 obj8 = _003C_003E8__1;
					GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest2 = obj8.request;
					_003C_003Ec__DisplayClass65_0 obj9 = _003C_003E8__1;
					GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest3 = obj9.request;
					_003C_003Ec__DisplayClass65_0 obj10 = _003C_003E8__1;
					GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest4 = obj10.request;
					nint num = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num2 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v56 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((FacebookSession)(object)gameCenterLoadPhotoRequest2.playerID__BackingField).GraphRequest((string)null, (IDictionary<string, object>)gameCenterLoadPhotoRequest3.textureWidth__BackingField, (HttpMethod)gameCenterLoadPhotoRequest4.textureHeight__BackingField, requestCompleteHandler);
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
				}
				_003C_003Ec__DisplayClass65_0 obj12 = _003C_003E8__1;
				if (~(obj12.working ? 1u : 0u) == 0)
				{
					_003C_003Ec__DisplayClass65_0 obj13 = _003C_003E8__1;
					GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest5 = obj13.request;
					if (((GameCenterRequest)gameCenterLoadPhotoRequest5).timeout__BackingField > 0f)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num3 = maxDelay2 - _003CstartTime_003E5__2;
						_003C_003Ec__DisplayClass65_0 obj14 = _003C_003E8__1;
						GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest6 = obj14.request;
						if (num3 > ((GameCenterRequest)gameCenterLoadPhotoRequest6).timeout__BackingField)
						{
							_003C_003Ec__DisplayClass65_0 obj15 = _003C_003E8__1;
							obj15.canceled = true;
							_003C_003Ec__DisplayClass65_0 obj16 = _003C_003E8__1;
							GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest7 = obj16.request;
							((GameCenterRequest)gameCenterLoadPhotoRequest7).didTimeout__BackingField = true;
							goto IL_038d;
						}
					}
					object obj17 = this + 12;
					obj17 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_038d;
				IL_038d:
				_003C_003Ec__DisplayClass65_0 obj18 = _003C_003E8__1;
				GameCenterLoadPhotoRequest gameCenterLoadPhotoRequest8 = obj18.request;
				((GameCenterRequest)gameCenterLoadPhotoRequest8).isDone__BackingField = true;
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

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public bool canceled;

		public GameCenterLoadLeaderboardRequest request;

		public bool working;

		internal void _003CLoadLeaderboardCoroutine_003Eb__0(Leaderboard result, string error)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			if (~(canceled ? 1u : 0u) == 0)
			{
				if (result != null)
				{
					object obj = result + 8;
					obj = request;
					result.playerScope = (working ? LeaderboardPlayerScope.FriendsOnly : LeaderboardPlayerScope.Global);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.GameCenter.GameCenterPlugin+<>c__DisplayClass74_0)+14]");
					result.timeScope = LeaderboardTimeScope.Today;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.GameCenter.GameCenterPlugin+<>c__DisplayClass74_0)+18]");
					result.rangeBegin = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.GameCenter.GameCenterPlugin+<>c__DisplayClass74_0)+1C]");
					result.rangeCount = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
		}
	}

	private sealed class _003CLoadLeaderboardCoroutine_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterLoadLeaderboardRequest request;

		private _003C_003Ec__DisplayClass74_0 _003C_003E8__1;

		private float _003CstartTime_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Expected Obj, but got Unknown
				//IL_0268: Expected I, but got Obj
				//IL_027e: Expected Obj, but got I
				//IL_0499: Expected Obj, but got I4
				//IL_0499: Expected Obj, but got I4
				//IL_0499: Expected Obj, but got I4
				//IL_0499: Expected Obj, but got I4
				//IL_0195: Expected I, but got Obj
				//IL_01ab: Expected Obj, but got I
				//IL_02a9: Expected I, but got Obj
				//IL_045e: Expected Obj, but got I4
				//IL_01d6: Expected I, but got Obj
				//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ae: Expected Obj, but got Unknown
				//IL_04b7: Expected Obj, but got I4
				//IL_04cb: Expected Obj, but got I4
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
					object obj = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					object obj3 = _003C_003E8__1 + 12;
					obj3 = request;
					_003C_003Ec__DisplayClass74_0 obj4 = _003C_003E8__1;
					obj4.working = true;
					_003C_003Ec__DisplayClass74_0 obj5 = _003C_003E8__1;
					obj5.canceled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					FacebookSession.DialogCompleteHandler dialogCompleteHandler = default;
					((Delegate)dialogCompleteHandler).method_ptr = method_ptr;
					((Delegate)dialogCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass74_0._003CLoadLeaderboardCoroutine_003Eb__0);
					object obj6 = dialogCompleteHandler + 16;
					obj6 = _003C_003E8__1;
					_003C_003Ec__DisplayClass74_0 obj7 = _003C_003E8__1;
					GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest = obj7.request;
					((GameCenterRequest)gameCenterLoadLeaderboardRequest).isDone__BackingField = false;
					_003C_003Ec__DisplayClass74_0 obj8 = _003C_003E8__1;
					GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest2 = obj8.request;
					_003C_003Ec__DisplayClass74_0 obj9 = _003C_003E8__1;
					GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest3 = obj9.request;
					_003C_003Ec__DisplayClass74_0 obj10 = _003C_003E8__1;
					GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest4 = obj10.request;
					if (gameCenterLoadLeaderboardRequest4.playerIDs__BackingField != null)
					{
						_003C_003Ec__DisplayClass74_0 obj11 = _003C_003E8__1;
						GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest5 = obj11.request;
						nint num = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v101 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num2 = (nint)typeof(GameCenterPlugin);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v106 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((FacebookSession)(object)gameCenterLoadLeaderboardRequest2.category__BackingField).ShowDialog((string)null, (IDictionary<string, object>)gameCenterLoadLeaderboardRequest5.timeScope__BackingField, dialogCompleteHandler);
					}
					else
					{
						_003C_003Ec__DisplayClass74_0 obj13 = _003C_003E8__1;
						GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest6 = obj13.request;
						_003C_003Ec__DisplayClass74_0 obj14 = _003C_003E8__1;
						GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest7 = obj14.request;
						_003C_003Ec__DisplayClass74_0 obj15 = _003C_003E8__1;
						GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest8 = obj15.request;
						nint num3 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v85 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num4 = (nint)typeof(GameCenterPlugin);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v90 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						DeviceUtility.ShowNativePopup(gameCenterLoadLeaderboardRequest2.category__BackingField, (string)gameCenterLoadLeaderboardRequest3.playerScope__BackingField, (string)gameCenterLoadLeaderboardRequest6.timeScope__BackingField, (string)gameCenterLoadLeaderboardRequest7.rangeBegin__BackingField, (string)gameCenterLoadLeaderboardRequest8.rangeCount__BackingField, (Action<string>)(object)dialogCompleteHandler);
					}
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
				}
				_003C_003Ec__DisplayClass74_0 obj17 = _003C_003E8__1;
				if (~(obj17.working ? 1u : 0u) == 0)
				{
					_003C_003Ec__DisplayClass74_0 obj18 = _003C_003E8__1;
					GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest9 = obj18.request;
					if (((GameCenterRequest)gameCenterLoadLeaderboardRequest9).timeout__BackingField > 0f)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num5 = maxDelay2 - _003CstartTime_003E5__2;
						_003C_003Ec__DisplayClass74_0 obj19 = _003C_003E8__1;
						GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest10 = obj19.request;
						if (num5 > ((GameCenterRequest)gameCenterLoadLeaderboardRequest10).timeout__BackingField)
						{
							_003C_003Ec__DisplayClass74_0 obj20 = _003C_003E8__1;
							obj20.canceled = true;
							_003C_003Ec__DisplayClass74_0 obj21 = _003C_003E8__1;
							GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest11 = obj21.request;
							((GameCenterRequest)gameCenterLoadLeaderboardRequest11).didTimeout__BackingField = true;
							goto IL_04d0;
						}
					}
					object obj22 = this + 12;
					obj22 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_04d0;
				IL_04d0:
				_003C_003Ec__DisplayClass74_0 obj23 = _003C_003E8__1;
				GameCenterLoadLeaderboardRequest gameCenterLoadLeaderboardRequest12 = obj23.request;
				((GameCenterRequest)gameCenterLoadLeaderboardRequest12).isDone__BackingField = true;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CLoadLeaderboardCoroutine_003Ed__74(int _003C_003E1__state)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v15 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v20 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D7CC");
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
		public bool canceled;

		public GameCenterLoadAchievementsRequest request;

		public bool working;

		internal void _003CLoadAchievementsCoroutine_003Eb__0(Achievement[] result, string error)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_0062: Expected Obj, but got I4
			if (~(canceled ? 1u : 0u) == 0)
			{
				if (result != null)
				{
					object obj = result + 8;
					obj = request;
					result[2] = (Achievement)working;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
		}
	}

	private sealed class _003CLoadAchievementsCoroutine_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterLoadAchievementsRequest request;

		private _003C_003Ec__DisplayClass83_0 _003C_003E8__1;

		private float _003CstartTime_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Expected Obj, but got Unknown
				//IL_0117: Expected I, but got Obj
				//IL_012d: Expected Obj, but got I
				//IL_0158: Expected I, but got Obj
				//IL_0305: Unknown result type (might be due to invalid IL or missing references)
				//IL_030a: Expected Obj, but got Unknown
				//IL_0313: Expected Obj, but got I4
				//IL_0327: Expected Obj, but got I4
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
					object obj = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					object obj3 = _003C_003E8__1 + 12;
					obj3 = request;
					_003C_003Ec__DisplayClass83_0 obj4 = _003C_003E8__1;
					obj4.working = true;
					_003C_003Ec__DisplayClass83_0 obj5 = _003C_003E8__1;
					obj5.canceled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					LoadAchievementDescriptionsCompletionHandler loadAchievementDescriptionsCompletionHandler = default;
					((Delegate)loadAchievementDescriptionsCompletionHandler).method_ptr = method_ptr;
					((Delegate)loadAchievementDescriptionsCompletionHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass83_0._003CLoadAchievementsCoroutine_003Eb__0);
					object obj6 = loadAchievementDescriptionsCompletionHandler + 16;
					obj6 = _003C_003E8__1;
					_003C_003Ec__DisplayClass83_0 obj7 = _003C_003E8__1;
					GameCenterLoadAchievementsRequest gameCenterLoadAchievementsRequest = obj7.request;
					((GameCenterRequest)gameCenterLoadAchievementsRequest).isDone__BackingField = false;
					nint num = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num2 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v64 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					LoadAchievementDescriptions(loadAchievementDescriptionsCompletionHandler);
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
				}
				_003C_003Ec__DisplayClass83_0 obj9 = _003C_003E8__1;
				if (~(obj9.working ? 1u : 0u) == 0)
				{
					_003C_003Ec__DisplayClass83_0 obj10 = _003C_003E8__1;
					GameCenterLoadAchievementsRequest gameCenterLoadAchievementsRequest2 = obj10.request;
					if (((GameCenterRequest)gameCenterLoadAchievementsRequest2).timeout__BackingField > 0f)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num3 = maxDelay2 - _003CstartTime_003E5__2;
						_003C_003Ec__DisplayClass83_0 obj11 = _003C_003E8__1;
						GameCenterLoadAchievementsRequest gameCenterLoadAchievementsRequest3 = obj11.request;
						if (num3 > ((GameCenterRequest)gameCenterLoadAchievementsRequest3).timeout__BackingField)
						{
							_003C_003Ec__DisplayClass83_0 obj12 = _003C_003E8__1;
							obj12.canceled = true;
							_003C_003Ec__DisplayClass83_0 obj13 = _003C_003E8__1;
							GameCenterLoadAchievementsRequest gameCenterLoadAchievementsRequest4 = obj13.request;
							((GameCenterRequest)gameCenterLoadAchievementsRequest4).didTimeout__BackingField = true;
							goto IL_032c;
						}
					}
					object obj14 = this + 12;
					obj14 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_032c;
				IL_032c:
				_003C_003Ec__DisplayClass83_0 obj15 = _003C_003E8__1;
				GameCenterLoadAchievementsRequest gameCenterLoadAchievementsRequest5 = obj15.request;
				((GameCenterRequest)gameCenterLoadAchievementsRequest5).isDone__BackingField = true;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CLoadAchievementsCoroutine_003Ed__83(int _003C_003E1__state)
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			int num = this._003C_003E1__state;
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num3 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v11 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.Int32)+14]");
			((GameCenterReportAchievementsRequest)0)._002Ector((Achievement[])null, (byte)_003C_003E1__state != 0);
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

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public bool canceled;

		public GameCenterLoadAchievementDescriptionsRequest request;

		public bool working;

		public _003C_003Ec__DisplayClass87_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CLoadAchievementDescriptionsCoroutine_003Eb__0(AchievementDescription[] result, string error)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			if (~(canceled ? 1u : 0u) != 0)
			{
				object obj = request + 20;
				obj = result;
				object obj2 = request + 16;
				obj2 = error;
			}
			working = false;
		}
	}

	private sealed class _003CLoadAchievementDescriptionsCoroutine_003Ed__87(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterLoadAchievementDescriptionsRequest request;

		private _003C_003Ec__DisplayClass87_0 _003C_003E8__1;

		private float _003CstartTime_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_00da: Expected Obj, but got Unknown
				//IL_0117: Expected I, but got Obj
				//IL_012d: Expected Obj, but got I
				//IL_0158: Expected I, but got Obj
				//IL_0305: Unknown result type (might be due to invalid IL or missing references)
				//IL_030a: Expected Obj, but got Unknown
				//IL_0313: Expected Obj, but got I4
				//IL_0327: Expected Obj, but got I4
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
					object obj = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					object obj3 = _003C_003E8__1 + 12;
					obj3 = request;
					_003C_003Ec__DisplayClass87_0 obj4 = _003C_003E8__1;
					obj4.working = true;
					_003C_003Ec__DisplayClass87_0 obj5 = _003C_003E8__1;
					obj5.canceled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					RequestCompleteHandler requestCompleteHandler = default;
					((Delegate)requestCompleteHandler).method_ptr = method_ptr;
					((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass87_0._003CLoadAchievementDescriptionsCoroutine_003Eb__0);
					object obj6 = requestCompleteHandler + 16;
					obj6 = _003C_003E8__1;
					_003C_003Ec__DisplayClass87_0 obj7 = _003C_003E8__1;
					GameCenterLoadAchievementDescriptionsRequest gameCenterLoadAchievementDescriptionsRequest = obj7.request;
					((GameCenterRequest)gameCenterLoadAchievementDescriptionsRequest).isDone__BackingField = false;
					nint num = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v58 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num2 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v64 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					ResetAchievements(requestCompleteHandler);
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
				}
				_003C_003Ec__DisplayClass87_0 obj9 = _003C_003E8__1;
				if (~(obj9.working ? 1u : 0u) == 0)
				{
					_003C_003Ec__DisplayClass87_0 obj10 = _003C_003E8__1;
					GameCenterLoadAchievementDescriptionsRequest gameCenterLoadAchievementDescriptionsRequest2 = obj10.request;
					if (((GameCenterRequest)gameCenterLoadAchievementDescriptionsRequest2).timeout__BackingField > 0f)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num3 = maxDelay2 - _003CstartTime_003E5__2;
						_003C_003Ec__DisplayClass87_0 obj11 = _003C_003E8__1;
						GameCenterLoadAchievementDescriptionsRequest gameCenterLoadAchievementDescriptionsRequest3 = obj11.request;
						if (num3 > ((GameCenterRequest)gameCenterLoadAchievementDescriptionsRequest3).timeout__BackingField)
						{
							_003C_003Ec__DisplayClass87_0 obj12 = _003C_003E8__1;
							obj12.canceled = true;
							_003C_003Ec__DisplayClass87_0 obj13 = _003C_003E8__1;
							GameCenterLoadAchievementDescriptionsRequest gameCenterLoadAchievementDescriptionsRequest4 = obj13.request;
							((GameCenterRequest)gameCenterLoadAchievementDescriptionsRequest4).didTimeout__BackingField = true;
							goto IL_032c;
						}
					}
					object obj14 = this + 12;
					obj14 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_032c;
				IL_032c:
				_003C_003Ec__DisplayClass87_0 obj15 = _003C_003E8__1;
				GameCenterLoadAchievementDescriptionsRequest gameCenterLoadAchievementDescriptionsRequest5 = obj15.request;
				((GameCenterRequest)gameCenterLoadAchievementDescriptionsRequest5).isDone__BackingField = true;
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

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public bool canceled;

		public GameCenterRequest request;

		public bool working;

		public _003C_003Ec__DisplayClass90_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CRequestCoroutine_003Eb__0(string error)
		{
			//IL_000a: Expected I4, but got Obj
			canceled = (byte)(int)error != 0;
		}
	}

	private sealed class _003CRequestCoroutine_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterRequest request;

		public Action<RequestCompleteHandler> requestFunction;

		private _003C_003Ec__DisplayClass90_0 _003C_003E8__1;

		private float _003CstartTime_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Expected Obj, but got Unknown
				//IL_0269: Unknown result type (might be due to invalid IL or missing references)
				//IL_026e: Expected Obj, but got Unknown
				//IL_0277: Expected Obj, but got I4
				//IL_028b: Expected Obj, but got I4
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
					object obj = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					object obj3 = _003C_003E8__1 + 12;
					obj3 = request;
					_003C_003Ec__DisplayClass90_0 obj4 = _003C_003E8__1;
					obj4.working = true;
					_003C_003Ec__DisplayClass90_0 obj5 = _003C_003E8__1;
					obj5.canceled = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num = 0;
					_ = 0;
					object obj7 = default;
					object obj6 = obj7 + 16;
					obj6 = _003C_003E8__1;
					_003C_003Ec__DisplayClass90_0 obj8 = _003C_003E8__1;
					GameCenterRequest gameCenterRequest = obj8.request;
					gameCenterRequest.isDone__BackingField = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
					float maxDelay = NetworkServer.maxDelay;
					_003CstartTime_003E5__2 = maxDelay;
				}
				_003C_003Ec__DisplayClass90_0 obj9 = _003C_003E8__1;
				if (~(obj9.working ? 1u : 0u) == 0)
				{
					_003C_003Ec__DisplayClass90_0 obj10 = _003C_003E8__1;
					GameCenterRequest gameCenterRequest2 = obj10.request;
					if (gameCenterRequest2.timeout__BackingField > 0f)
					{
						float maxDelay2 = NetworkServer.maxDelay;
						float num2 = maxDelay2 - _003CstartTime_003E5__2;
						_003C_003Ec__DisplayClass90_0 obj11 = _003C_003E8__1;
						GameCenterRequest gameCenterRequest3 = obj11.request;
						if (num2 > gameCenterRequest3.timeout__BackingField)
						{
							_003C_003Ec__DisplayClass90_0 obj12 = _003C_003E8__1;
							obj12.canceled = true;
							_003C_003Ec__DisplayClass90_0 obj13 = _003C_003E8__1;
							GameCenterRequest gameCenterRequest4 = obj13.request;
							gameCenterRequest4.didTimeout__BackingField = true;
							goto IL_0290;
						}
					}
					object obj14 = this + 12;
					obj14 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				goto IL_0290;
				IL_0290:
				_003C_003Ec__DisplayClass90_0 obj15 = _003C_003E8__1;
				GameCenterRequest gameCenterRequest5 = obj15.request;
				gameCenterRequest5.isDone__BackingField = true;
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CRequestCoroutine_003Ed__90(int _003C_003E1__state)
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected Obj, but got Unknown
			//IL_0042: Expected Obj, but got I4
			if (this._003C_003E1__state == 0)
			{
				object obj = _003C_003E2__current + 16;
				obj = _003C_003E1__state;
			}
			request = null;
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

	private const char SEPARATION_CHAR = '|';

	private const string ESCAPED_SEPARATION_CHAR = "&#124;";

	private bool _hasLoginView;

	private bool _initialAuthenticationComplete;

	private ViewDismissedHandler _viewDismissedHandler;

	private static GameCenterPlugin _instance;

	private static AuthenticateHandler m_authenticationEvent;

	public static bool isSupported => false;

	public static bool hasLoginView
	{
		get
		{
			string dataPath = Application.dataPath;
			return (nint)dataPath == 8;
		}
	}

	public static bool initialAuthenticationComplete
	{
		get
		{
			//IL_0149: Expected I, but got Obj
			//IL_015f: Expected Obj, but got I
			//IL_01af: Expected I, but got Obj
			//IL_01c5: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_instance).FindKernel((string)null) != 0)
			{
				nint num5 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameCenterPlugin instance = _instance;
				return instance._hasLoginView;
			}
			return false;
		}
	}

	public static event AuthenticateHandler authenticationEvent
	{
		add
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94");
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = GameCenterPlugin.m_authenticationEvent;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(GameCenterPlugin);
				if (!flag)
				{
					nint num5 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(GameCenterPlugin);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(GameCenterPlugin);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	[PreserveSig]
	private static extern void _GameCenterInit(string gameObject);

	[PreserveSig]
	private static extern void _GameCenterShowLoginView();

	[PreserveSig]
	private static extern void _GameCenterGetLocalPlayer(ref LocalPlayer localPlayer);

	[PreserveSig]
	private static extern void _GameCenterGenerateIdentityVerificationSignature(int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterLoadFriends(int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterLoadPlayers(string playerIDs, int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterLoadPhoto(string playerID, int size, int handlerContext);

	private static bool _GameCenterArePhotosSupported()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a2: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)PluginUtil.CreateBridgeObject<SimulatedGoogleSignInBridge>() != 0;
	}

	private static bool _GameCenterGetPhotoPixels(int context, int width, int height, IntPtr pixels)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0011: Expected Obj, but got I4
		object obj = 0;
		obj = width;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		bool result = default;
		return result;
	}

	[PreserveSig]
	private static extern void _GameCenterShowView(int viewState, string leaderboardCategory, int leaderboardTimeScope);

	[PreserveSig]
	private static extern void _GameCenterReportScore(string category, long scoreValue, ulong scoreContext, int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterLoadLeaderboard(string category, int playerScope, int timeScope, int rangeBegin, int rangeCount, int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterLoadLeaderboardForIDs(string category, string playerIDs, int timeScope, int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterReportAchievement(string achievementID, float percentComplete, int showsCompletionBanner, int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterReportAchievements(string interleavedAchievements, int showsCompletionBanner, int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterLoadAchievements(int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterLoadAchievementDescriptions(int handlerContext);

	[PreserveSig]
	private static extern void _GameCenterResetAchievements(int handlerContext);

	public static void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @95");
	}

	public static void ShowLoginView()
	{
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_01ba: Expected I, but got Obj
		//IL_026f: Expected I, but got Obj
		//IL_0285: Expected Obj, but got I
		//IL_002c: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_02c4: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		string dataPath = Application.dataPath;
		bool flag = (nint)dataPath == 8;
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag2 = obj != null;
		if (flag)
		{
			if (flag2)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v48 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!(_instance != null))
			{
				return;
			}
			nint num5 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v25 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v44 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameCenterPlugin instance = PluginUtil.CreateBridgeObject<GameCenterPlugin>();
			nint num7 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v32 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_instance = instance;
			return;
		}
		if (flag2)
		{
			nint num9 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning("Could not authenticate local player (not on iOS)");
	}

	public static LocalPlayer GetLocalPlayer()
	{
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_0165: Expected Obj, but got VT
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_01b4: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = GameCenterPlugin.m_authenticationEvent;
		LocalPlayer localPlayer = default;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)localPlayer);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(GameCenterPlugin);
			if (!flag)
			{
				nint num5 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(GameCenterPlugin);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(GameCenterPlugin);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 == obj2)
			{
				break;
			}
			obj2 = (Delegate)obj5;
		}
		return localPlayer;
	}

	public unsafe static void GetLocalPlayer(ref LocalPlayer player)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			if ((nint)0 == 0)
			{
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
				_ = 0;
				object obj3 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				obj3 = 0;
			}
		}
		ref LocalPlayer reference = ref *(LocalPlayer*)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
	}

	public static void GenerateIdentityVerificationSignature(GenerateIdentityVerificationSignatureCompletionHandler completionHandler)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_007c: Expected Obj, but got I
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			if (((Delegate)completionHandler).method_ptr == (IntPtr)0)
			{
				object obj = completionHandler + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [completionHandler @ L0 (Kiloo.GameCenter.GameCenterPlugin+GenerateIdentityVerificationSignatureCompletionHandler)+4]");
				obj = 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		}
	}

	public static Coroutine GenerateIdentityVerificationSignature(GameCenterGenerateIdentityVerificationSignatureRequest request)
	{
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private static IEnumerator GenerateIdentityVerificationSignatureCoroutine(GameCenterGenerateIdentityVerificationSignatureRequest request)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Coroutine list = LoadFriends((GameCenterLoadFriendsRequest)(object)request);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public static void LoadFriends(LoadFriendsCompletionHandler completionHandler)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_027a: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I
		//IL_031b: Expected I, but got Obj
		//IL_0331: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_02cb: Expected I, but got Obj
		//IL_02e1: Expected Obj, but got I
		//IL_0183: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v53 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)_instance).FindKernel((string)null);
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			if (num5 == 0)
			{
				if (!flag)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning("GenerateIdentityVerificationSignature was called before Init");
				return;
			}
			if (!flag)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num9 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v28 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v34 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num11 = FileUtil.CopyTo((Stream)(object)completionHandler, (Stream)(object)_instance);
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D7B5");
		}
	}

	public static Coroutine LoadFriends(GameCenterLoadFriendsRequest request)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = request;
		return coroutine;
	}

	private static IEnumerator LoadFriendsCoroutine(GameCenterLoadFriendsRequest request)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Coroutine list = LoadPlayers((GameCenterLoadPlayersRequest)(object)request);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public static void LoadPlayers(string[] playerIDs, LoadPlayersCompletionHandler completionHandler)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @91");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
	}

	public static Coroutine LoadPlayers(GameCenterLoadPlayersRequest request)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = request;
		return coroutine;
	}

	private static IEnumerator LoadPlayersCoroutine(GameCenterLoadPlayersRequest request)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Coroutine list = LoadPhoto((GameCenterLoadPhotoRequest)(object)request);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public static bool ArePhotosSupported()
	{
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_01af: Expected I, but got Obj
		//IL_01c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_instance).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameCenterPlugin instance = _instance;
			return instance._initialAuthenticationComplete;
		}
		return false;
	}

	public static void LoadPhoto(string playerID, PhotoSize size, int textureWidth, int textureHeight, LoadPhotoCompletionHandler completionHandler)
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_0063: Expected I, but got Obj
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_00f1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [playerID @ L0 (System.String)+28]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController instance = UIScreenController.Instance;
		if ((object)instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DelayedHideInAppPurchaseOverlay();
	}

	public static Coroutine LoadPhoto(GameCenterLoadPhotoRequest request)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = request;
		return coroutine;
	}

	private static IEnumerator LoadPhotoCoroutine(GameCenterLoadPhotoRequest request)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Coroutine list = ReportScore((GameCenterReportScoreRequest)(object)request);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public static void ShowView(ShowViewState viewState, string leaderboardCategory = null, LeaderboardTimeScope leaderboardTimeScope = LeaderboardTimeScope.AllTime, ViewDismissedHandler viewDismissedHandler = null)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
	}

	public static void ReportScore(string category, long scoreValue, ulong scoreContext, RequestCompleteHandler completionHandler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = category + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC81");
	}

	public static Coroutine ReportScore(GameCenterReportScoreRequest request)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = request;
		return coroutine;
	}

	public static void LoadLeaderboard(string category, LeaderboardPlayerScope playerScope, LeaderboardTimeScope timeScope, int rangeBegin, int rangeCount, LoadLeaderboardCompletionHandler completionHandler)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
	}

	public static Coroutine LoadLeaderboard(GameCenterLoadLeaderboardRequest request)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		nint num2 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v14 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v20 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		int num4 = PluginUtil.CheckInHandler((Delegate)0, obj4);
		return CoroutineUtil.WaitForAll((YieldInstruction[])num4);
	}

	private static IEnumerator LoadLeaderboardCoroutine(GameCenterLoadLeaderboardRequest request)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Coroutine list = ReportAchievements((GameCenterReportAchievementsRequest)(object)request);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public static void LoadLeaderboardForIDs(string category, string[] playerIDs, LeaderboardTimeScope timeScope, LoadLeaderboardCompletionHandler completionHandler)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0307: Expected I, but got Obj
		//IL_031d: Expected Obj, but got I
		//IL_03bd: Expected I, but got Obj
		//IL_03d3: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_016d: Expected I, but got Obj
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_01ba: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_0289: Expected I, but got Obj
		//IL_01fb: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath != 8)
		{
			return;
		}
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v66 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = ((ComputeShader)(object)_instance).FindKernel((string)null);
		nint num6 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 != null;
		if (num5 == 0)
		{
			if (flag)
			{
				nint num7 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v62 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LogWarning("ShowView was called before Init");
			return;
		}
		if (flag)
		{
			nint num8 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v52 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameCenterPlugin instance = _instance;
		if (instance._viewDismissedHandler != null)
		{
			nint num9 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v42 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v48 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Log("ShowView called while a view is already shown. Only one dismissed handler can be set at a time.");
		}
		nint num11 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v27 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num12 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v35 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = _instance + 16;
		obj6 = completionHandler;
	}

	public static void ReportAchievement(string identifier, float percentComplete, bool showsCompletionBanner, RequestCompleteHandler completionHandler)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @92");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
	}

	public static void ReportAchievement(Achievement achievement, bool showsCompletionBanner, RequestCompleteHandler completionHandler)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D38");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @93");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11D37");
	}

	public static void ReportAchievements(Achievement[] achievements, bool showsCompletionBanner, RequestCompleteHandler completionHandler)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a7: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v15 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DistantEnvironmentController.DistantObjectSpawner)null).Spawn(0f, (Vector3)0, (Transform)(object)completionHandler);
	}

	public static Coroutine ReportAchievements(GameCenterReportAchievementsRequest request)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = request;
		return coroutine;
	}

	public static void LoadAchievements(LoadAchievementsCompletionHandler completionHandler)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_023b: Expected I, but got Obj
		//IL_027f: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_0320: Expected I, but got Obj
		//IL_0336: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_02d0: Expected I, but got Obj
		//IL_02e6: Expected Obj, but got I
		//IL_0183: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v53 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)_instance).FindKernel((string)null);
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			if (num5 == 0)
			{
				if (!flag)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning("LoadFriends was called before Init");
				return;
			}
			if (!flag)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num9 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v28 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v34 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num11 = FileUtil.CopyTo((Stream)(object)completionHandler, (Stream)(object)_instance);
		}
		else
		{
			completionHandler?._002Ector(null, (IntPtr)"Could not load friends (not on iOS)");
		}
	}

	public static Coroutine LoadAchievements(GameCenterLoadAchievementsRequest request)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		nint num2 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v14 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v20 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		int num4 = PluginUtil.CheckInHandler((Delegate)0, obj4);
		return CoroutineUtil.WaitForAll((YieldInstruction[])num4);
	}

	private static IEnumerator LoadAchievementsCoroutine(GameCenterLoadAchievementsRequest request)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Coroutine list = LoadAchievementDescriptions((GameCenterLoadAchievementDescriptionsRequest)(object)request);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public static void LoadAchievementDescriptions(LoadAchievementDescriptionsCompletionHandler completionHandler)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_023b: Expected I, but got Obj
		//IL_027f: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_0320: Expected I, but got Obj
		//IL_0336: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_02d0: Expected I, but got Obj
		//IL_02e6: Expected Obj, but got I
		//IL_0183: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v53 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)_instance).FindKernel((string)null);
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			if (num5 == 0)
			{
				if (!flag)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning("LoadAchievements was called before Init");
				return;
			}
			if (!flag)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num9 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v28 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v34 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num11 = FileUtil.CopyTo((Stream)(object)completionHandler, (Stream)(object)_instance);
		}
		else
		{
			completionHandler?._002Ector(null, (IntPtr)"Could not load achievements (not on iOS)");
		}
	}

	public static Coroutine LoadAchievementDescriptions(GameCenterLoadAchievementDescriptionsRequest request)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = request;
		return coroutine;
	}

	private static IEnumerator LoadAchievementDescriptionsCoroutine(GameCenterLoadAchievementDescriptionsRequest request)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Coroutine list = ResetAchievements(request);
		return (IEnumerator)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public static void ResetAchievements(RequestCompleteHandler completionHandler)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_027a: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I
		//IL_031b: Expected I, but got Obj
		//IL_0331: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_02cb: Expected I, but got Obj
		//IL_02e1: Expected Obj, but got I
		//IL_0183: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v53 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)_instance).FindKernel((string)null);
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			if (num5 == 0)
			{
				if (!flag)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning("LoadAchievementDescriptions was called before Init");
				return;
			}
			if (!flag)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num9 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v28 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v34 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num11 = FileUtil.CopyTo((Stream)(object)completionHandler, (Stream)(object)_instance);
		}
		else if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	public static Coroutine ResetAchievements(GameCenterRequest request)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = request;
		return coroutine;
	}

	private static IEnumerator RequestCoroutine(GameCenterRequest request, Action<RequestCompleteHandler> requestFunction)
	{
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01f9: Expected Obj, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0290: Expected F4, but got I
		//IL_02a1: Expected Obj, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_017c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = request;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.GameCenter.GameCenterRequest)+24]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.GameCenter.GameCenterRequest)+24]");
			_ = 0;
			Texture2D texture2D = default;
			object obj3 = texture2D + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.GameCenter.GameCenterRequest)+28]");
			obj3 = 0;
			object obj4 = obj2 + 12;
			byte[] array = ImageConversion.EncodeToPNG(texture2D);
			obj4 = array;
		}
		else
		{
			if (requestFunction != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.GameCenter.GameCenterRequest)+31]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 4;
					Texture2D texture2D2 = default;
					object obj5 = texture2D2 + 16;
					obj5 = "Sign in required";
					object obj6 = obj2 + 12;
					byte[] array2 = ImageConversion.EncodeToPNG(texture2D2);
					obj6 = array2;
					goto IL_0244;
				}
			}
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj8 = default;
			object obj7 = obj8 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.GameCenter.GameCenterRequest)+1C]");
			obj7 = 0;
			object obj9 = obj8 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.GameCenter.GameCenterRequest)+20]");
			obj9 = 0;
			object obj10 = obj8 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.GameCenter.GameCenterRequest)+1C]");
			string text = $"http://imaginary-photo-cdn.com/{(object[])0}/picture";
			obj10 = text;
			object obj11 = obj8 + 20;
			Coroutine coroutine = GenerateIdentityVerificationSignature((GameCenterGenerateIdentityVerificationSignatureRequest)request);
			obj11 = coroutine;
			Texture2D texture2D3 = default;
			object obj12 = texture2D3 + 8;
			obj12 = obj8;
			object obj13 = obj2 + 12;
			byte[] array3 = ImageConversion.EncodeToPNG(texture2D3);
			obj13 = array3;
		}
		goto IL_0244;
		IL_0244:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		EnvironmentKind environmentKind = default;
		environmentKind._type = (EnvironmentType)num;
		_ = 0;
		object obj14 = environmentKind + 16;
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [request @ L0 (Kiloo.GameCenter.GameCenterRequest)+2C]");
		bool flag = ((DistantEnvironmentController.DistantObjectSpawner)null).CanSpawnAt(0f, environmentKind);
		Coroutine coroutine2 = ((MonoBehaviour)(object)request).StartCoroutine_Auto((IEnumerator)flag);
		return (IEnumerator)1;
	}

	private void OnGameCenterAuthenticationEvent(string param)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_027a: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I
		//IL_031b: Expected I, but got Obj
		//IL_0331: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_02cb: Expected I, but got Obj
		//IL_02e1: Expected Obj, but got I
		//IL_0183: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v53 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)_instance).FindKernel((string)null);
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			if (num5 == 0)
			{
				if (!flag)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning("LoadPlayers was called before Init");
				return;
			}
			if (!flag)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num9 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v28 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v34 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num11 = FileUtil.CopyTo((Stream)(object)param, (Stream)(object)_instance);
		}
		else if (param != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	private void OnGameCenterGenerateIdentityVerificationSignatureComplete(string json)
	{
		//IL_02a9: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0201: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_0242: Expected I, but got Obj
		//IL_0136: Expected I, but got Obj
		_initialAuthenticationComplete = true;
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v48 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (GameCenterPlugin.m_authenticationEvent == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num3 = default;
		object obj2 = num3 + 16;
		obj2 = 124;
		string text = json.Substring(num3);
		if (text.m_firstChar != '\u0002')
		{
			object obj3 = text.m_firstChar;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string msg = "OnGameCenterAuthenticationEvent: Unexpected number of parameters :" + text2;
			nint num4 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v43 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LogWarning(msg);
		}
		object obj5 = text + 16;
		bool flag = (string)obj5 != "true";
		_hasLoginView = flag;
		object obj6 = text + 20;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v31+8]");
		if ((nint)0 > (nint)0)
		{
			object obj8 = text + 20;
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v25 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v30 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool didTimeout = ((GameCenterRequest)obj8).didTimeout;
		}
		else
		{
			bool didTimeout = false;
		}
		bool flag2 = _hasLoginView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
	}

	private unsafe void OnGameCenterLoadFriendsComplete(string param)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_04b7: Expected Obj, but got I
		//IL_01e6: Expected I, but got Obj
		//IL_027e: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I
		//IL_0331: Expected I, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_02bf: Expected I, but got Obj
		//IL_03cd: Expected I, but got Obj
		//IL_03e3: Expected Obj, but got I
		//IL_0372: Expected I, but got Obj
		//IL_040e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		nint num = (nint)typeof(Depository);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v27 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v71 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
		IDictionary<int, object> dictionary = Depository.RemoveByContext(0);
		if (dictionary != null)
		{
			if ((object)dictionary.GetType() != typeof(GenerateIdentityVerificationSignatureCompletionHandler))
			{
				dictionary = null;
			}
		}
		else
		{
			dictionary = null;
		}
		if (dictionary == null)
		{
			nint num3 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v54 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v60 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LogWarning("OnGameCenterGenerateIdentityVerificationSignatureComplete: Handler not registered");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+10]");
		if ((nint)0 != 0)
		{
			nint num5 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v27 (Il2CppClass<System.Convert>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v32 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+10]");
			int day = ((DateTime*)null)->Day;
		}
		else
		{
			int day = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+14]");
		if ((nint)0 != 0)
		{
			nint num7 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v17 (Il2CppClass<System.Convert>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v22 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+14]");
			int day2 = ((DateTime*)null)->Day;
		}
		else
		{
			int day2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D7B5");
	}

	private unsafe void OnGameCenterLoadPlayersComplete(string param)
	{
		//IL_0400: Expected Obj, but got I4
		//IL_0409: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I4
		//IL_0368: Expected I, but got Obj
		//IL_037e: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_0450: Expected Obj, but got I4
		//IL_03a9: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0107: Expected I, but got Obj
		//IL_011d: Expected Obj, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e9: Expected I, but got Obj
		//IL_01ff: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_0148: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I4
		//IL_022a: Expected I, but got Obj
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 124;
		string text = param.Substring(num);
		if (text.m_firstChar > '\u0001')
		{
			object obj2 = text + 16;
			TypeCode typeCode = ((int*)obj2)->GetTypeCode();
			nint num2 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v30 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v90 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IDictionary<int, object> dictionary = Depository.RemoveByContext(typeCode);
			if (dictionary != null)
			{
				if ((object)dictionary.GetType() != typeof(LoadFriendsCompletionHandler))
				{
					dictionary = null;
				}
			}
			else
			{
				dictionary = null;
			}
			if (dictionary == null)
			{
				nint num4 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v73 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num5 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v79 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning("OnGameCenterLoadFriendsComplete: Handler not registered");
				return;
			}
			object obj5 = text + 20;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v43+8]");
			if ((nint)0 > (nint)0)
			{
				object obj7 = text + 20;
				nint num6 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v54 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool didTimeout = ((GameCenterRequest)obj7).didTimeout;
			}
			else
			{
				bool didTimeout = false;
			}
			if (text.m_firstChar < '\u0003')
			{
				object obj9 = 0;
			}
			else
			{
				object obj10 = text.m_firstChar - 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj11 = 2;
				bool flag = (nint)obj11 < (int)text.m_firstChar;
				bool flag2 = !flag;
				object obj12 = default;
				object obj9 = obj12;
				if (!flag2)
				{
					object obj13 = text + 16;
					object obj14 = obj11 << 2;
					object obj15 = obj13 + obj14;
					throw new ArrayTypeMismatchException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			return;
		}
		object obj16 = text.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string msg = "OnGameCenterLoadFriendsComplete: Unexpected number of parameters :" + text2;
		nint num8 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num9 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v18 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning(msg);
	}

	private unsafe void OnGameCenterLoadPhotoComplete(string param)
	{
		//IL_05ac: Expected Obj, but got I4
		//IL_05b5: Expected Obj, but got I4
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_0513: Expected I, but got Obj
		//IL_0529: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0554: Expected I, but got Obj
		//IL_0602: Expected Obj, but got I4
		//IL_00b5: Expected I, but got Obj
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02f1: Expected Obj, but got I4
		//IL_018e: Expected I, but got Obj
		//IL_0270: Expected I, but got Obj
		//IL_067a: Expected Obj, but got I4
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_0387: Expected I, but got Obj
		//IL_039d: Expected Obj, but got I
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected Obj, but got Unknown
		//IL_06cc: Expected Obj, but got I4
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected Obj, but got Unknown
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_0733: Expected Obj, but got I4
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Obj, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_0445: Expected Obj, but got I
		//IL_03c8: Expected I, but got Obj
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Obj, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_04d7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 124;
		string text = param.Substring(num);
		object obj2 = text + 12;
		bool flag = (nint)obj2 < 2;
		object obj3 = obj2;
		if (!flag)
		{
			object obj4 = obj2 - 2;
			object obj5 = obj4 & 3;
			if (obj5 == null)
			{
				object obj6 = text + 16;
				TypeCode typeCode = ((int*)obj6)->GetTypeCode();
				nint num2 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num3 = (nint)typeof(Depository);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v126 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				IDictionary<int, object> dictionary = Depository.RemoveByContext(typeCode);
				if (dictionary != null)
				{
					if ((object)dictionary.GetType() != typeof(LoadPlayersCompletionHandler))
					{
						dictionary = null;
					}
				}
				else
				{
					dictionary = null;
				}
				if (dictionary == null)
				{
					nint num4 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v109 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num5 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v115 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					LogWarning("OnGameCenterLoadPlayersComplete: Handler not registered");
					return;
				}
				object obj9 = text + 20;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v48+8]");
				if ((nint)0 > (nint)0)
				{
					object obj11 = text + 20;
					nint num6 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v90 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num7 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v95 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool didTimeout = ((GameCenterRequest)obj11).didTimeout;
				}
				else
				{
					bool didTimeout = false;
				}
				if ((nint)obj2 >= 3)
				{
					object obj13 = obj2 - 2;
					object obj14 = obj13 / 4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj15 = 2;
					object obj16 = default;
					object obj18 = default;
					object obj55 = default;
					while (true)
					{
						bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
						object obj17 = obj18;
						if (flag2)
						{
							break;
						}
						object obj19 = obj18 + 16;
						object obj20 = obj16 << 4;
						object obj21 = obj19 + obj20;
						object obj22 = text + 16;
						object obj23 = obj15 << 2;
						object obj24 = obj22 + obj23;
						obj21 = obj24;
						object obj25 = obj15 << 2;
						object obj26 = text + obj25;
						object obj27 = obj26 + 20;
						nint num8 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v71 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
						object obj28 = (nint)0 & (nint)0x200;
						if (obj28 != null)
						{
							nint num9 = (nint)typeof(GameCenterPlugin);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v98 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj29 = obj16 << 4;
						object obj30 = obj18 + obj29;
						object obj31 = obj30 + 20;
						bool didTimeout2 = ((GameCenterRequest)obj27).didTimeout;
						obj31 = didTimeout2;
						object obj32 = obj16 << 4;
						object obj33 = obj18 + obj32;
						object obj34 = obj33 + 24;
						object obj35 = obj15 << 2;
						object obj36 = text + obj35;
						object obj37 = obj36 + 24;
						bool didTimeout3 = ((GameCenterRequest)obj37).didTimeout;
						obj34 = didTimeout3;
						object obj38 = obj18 + 16;
						object obj39 = obj16 << 4;
						object obj40 = obj38 + obj39;
						object obj41 = obj15 << 2;
						object obj42 = text + obj41;
						object obj43 = obj42 + 28;
						bool flag3 = (string)obj43 != "true";
						object obj44 = obj18 + 16;
						object obj45 = obj16 << 4;
						object obj46 = obj44 + obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v86+8]");
						object obj47 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v87+8]");
						if ((nint)0 == 0)
						{
							object obj48 = obj16 << 4;
							object obj49 = obj18 + obj48;
							object obj50 = obj49 + 24;
							object obj51 = obj18 + 16;
							object obj52 = obj16 << 4;
							object obj53 = obj51 + obj52;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v86+4]");
							obj50 = 0;
						}
						object obj54 = obj15 + 4;
						obj16 = obj55 + 1;
						obj15 = obj54;
					}
				}
				else
				{
					object obj17 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				return;
			}
			obj3 = obj2;
		}
		object obj56 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string msg = "OnGameCenterLoadPlayersComplete: Unexpected number of parameters :" + text2;
		nint num10 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v15 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj57 = (nint)0 & (nint)0x200;
		if (obj57 != null)
		{
			nint num11 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v20 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning(msg);
	}

	private unsafe void OnGameCenterRequestComplete(string param)
	{
		//IL_0379: Expected Obj, but got I4
		//IL_0382: Expected Obj, but got I4
		//IL_02b2: Expected Obj, but got I4
		//IL_02e1: Expected I, but got Obj
		//IL_02f7: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_03c9: Expected Obj, but got I4
		//IL_0322: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_0212: Expected I, but got Obj
		//IL_0228: Expected Obj, but got I
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_0253: Expected I, but got Obj
		//IL_0171: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 124;
		string text = param.Substring(num);
		object obj4;
		if (text.m_firstChar == '\u0004')
		{
			object obj2 = text + 16;
			TypeCode typeCode = ((int*)obj2)->GetTypeCode();
			nint num2 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v30 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v67 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IDictionary<int, object> dictionary = Depository.RemoveByContext(typeCode);
			if (dictionary != null)
			{
				if ((object)dictionary.GetType() != typeof(InternalLoadPhotoCompletionHandler))
				{
					dictionary = null;
				}
			}
			else
			{
				dictionary = null;
			}
			if (dictionary == null)
			{
				obj4 = typeCode;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text2 = default;
				string msg = "OnGameCenterLoadPhotoComplete: Handler not registered: " + text2;
				nint num4 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num5 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v54 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning(msg);
				return;
			}
			object obj6 = text + 20;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v43+8]");
			if ((nint)0 > (nint)0)
			{
				object obj8 = text + 20;
				nint num6 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v36 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v41 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool didTimeout = ((GameCenterRequest)obj8).didTimeout;
			}
			else
			{
				bool didTimeout = false;
			}
			object obj10 = text + 24;
			TypeCode typeCode2 = ((int*)obj10)->GetTypeCode();
			object obj11 = text + 28;
			TypeCode typeCode3 = ((int*)obj11)->GetTypeCode();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A32E");
			return;
		}
		obj4 = text.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text3 = default;
		string msg2 = "OnGameCenterLoadPhotoComplete: Unexpected number of parameters :" + text3;
		nint num8 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num9 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v18 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning(msg2);
	}

	private unsafe void OnGameCenterLoadLeaderboardComplete(string param)
	{
		//IL_0374: Expected Obj, but got I4
		//IL_037d: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I4
		//IL_02dc: Expected I, but got Obj
		//IL_02f2: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_03c4: Expected Obj, but got I4
		//IL_031d: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		//IL_0212: Expected I, but got Obj
		//IL_0228: Expected Obj, but got I
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_0253: Expected I, but got Obj
		//IL_0171: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 124;
		string text = param.Substring(num);
		object obj4;
		if (text.m_firstChar == '\u0002')
		{
			object obj2 = text + 16;
			TypeCode typeCode = ((int*)obj2)->GetTypeCode();
			nint num2 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v30 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v56 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IDictionary<int, object> dictionary = Depository.RemoveByContext(typeCode);
			if (dictionary != null)
			{
				if ((object)dictionary.GetType() != typeof(RequestCompleteHandler))
				{
					dictionary = null;
				}
			}
			else
			{
				dictionary = null;
			}
			if (dictionary == null)
			{
				obj4 = typeCode;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text2 = default;
				string msg = "OnGameCenterRequestComplete: Handler not registered: " + text2;
				nint num4 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v42 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num5 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v47 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning(msg);
				return;
			}
			object obj6 = text + 20;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v29+8]");
			if ((nint)0 > (nint)0)
			{
				object obj8 = text + 20;
				nint num6 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v11 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S2_v16 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool didTimeout = ((GameCenterRequest)obj8).didTimeout;
			}
			else
			{
				bool didTimeout = false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
			return;
		}
		obj4 = text.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text3 = default;
		string msg2 = "OnGameCenterRequestComplete: Unexpected number of parameters :" + text3;
		nint num8 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v13 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num9 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v18 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning(msg2);
	}

	private unsafe void OnGameCenterLoadAchievementsComplete(string param)
	{
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected Obj, but got Unknown
		//IL_078e: Expected Obj, but got I4
		//IL_0797: Expected Obj, but got I4
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_084f: Expected Obj, but got I4
		//IL_0142: Expected I, but got Obj
		//IL_0805: Expected I, but got Obj
		//IL_081b: Expected Obj, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0099: Expected I, but got Obj
		//IL_01da: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02bc: Expected I, but got Obj
		//IL_02d2: Expected Obj, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_021b: Expected I, but got Obj
		//IL_03f3: Expected Obj, but got I4
		//IL_0353: Expected Obj, but got I4
		//IL_02fd: Expected I, but got Obj
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected Obj, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected Obj, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected Obj, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected Obj, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected Obj, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected Obj, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Expected Obj, but got Unknown
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_0427: Expected I, but got Obj
		//IL_043d: Expected Obj, but got I
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected Obj, but got Unknown
		//IL_09b4: Expected Obj, but got I4
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected Obj, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Expected Obj, but got Unknown
		//IL_09eb: Expected I, but got Obj
		//IL_0a01: Expected Obj, but got I
		//IL_0a27: Expected VT, but got I4
		//IL_0a33: Expected Obj, but got VT
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected Obj, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected Obj, but got Unknown
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected Obj, but got Unknown
		//IL_0468: Expected I, but got Obj
		//IL_04fd: Expected Obj, but got I4
		//IL_0506: Expected Obj, but got I4
		//IL_04b5: Expected I, but got Obj
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected Obj, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected Obj, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected Obj, but got Unknown
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_0669: Expected I, but got Obj
		//IL_067f: Expected Obj, but got I
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected Obj, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected Obj, but got Unknown
		//IL_0ac9: Expected Obj, but got I4
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Expected Obj, but got Unknown
		//IL_0b0d: Expected I, but got Obj
		//IL_0b23: Expected Obj, but got I
		//IL_0b49: Expected VT, but got I4
		//IL_0b55: Expected Obj, but got VT
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Expected Obj, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected Obj, but got Unknown
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Expected Obj, but got Unknown
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Expected Obj, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Expected Obj, but got Unknown
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected Obj, but got Unknown
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Expected Obj, but got Unknown
		//IL_06aa: Expected I, but got Obj
		//IL_06f7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj4 = num + 16;
		obj4 = 124;
		string text = param.Substring(num);
		object obj5 = text + 12;
		if ((nint)obj5 != 2)
		{
			bool flag = (nint)obj5 >= 11;
			bool flag2 = !flag;
			object obj6 = obj5;
			if (!flag2)
			{
				object obj7 = obj5 - 5;
				object obj8 = obj7 / 6;
				object obj9 = obj8 * 6;
				if (obj7 == obj9)
				{
					goto IL_00d8;
				}
				obj6 = obj5;
			}
			obj = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string msg = "OnGameCenterLoadLeaderboardComplete: Unexpected number of parameters :" + text2;
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v179 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num3 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v184 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LogWarning(msg);
			return;
		}
		goto IL_00d8;
		IL_00d8:
		object obj11 = text + 16;
		TypeCode typeCode = ((int*)obj11)->GetTypeCode();
		nint num4 = (nint)typeof(Depository);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v30 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num5 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v159 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IDictionary<int, object> dictionary = Depository.RemoveByContext(typeCode);
		if (dictionary != null)
		{
			if ((object)dictionary.GetType() != typeof(LoadLeaderboardCompletionHandler))
			{
				dictionary = null;
			}
		}
		else
		{
			dictionary = null;
		}
		if (dictionary == null)
		{
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v142 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num7 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v148 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LogWarning("OnGameCenterLoadLeaderboardComplete: Handler not registered");
			return;
		}
		object obj14 = text + 20;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v43+8]");
		if ((nint)0 > (nint)0)
		{
			object obj16 = text + 20;
			nint num8 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v161 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num9 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v166 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool didTimeout = ((GameCenterRequest)obj16).didTimeout;
		}
		else
		{
			bool didTimeout = false;
		}
		if ((nint)obj5 < 3)
		{
			object obj18 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj20 = default;
			object obj19 = obj20 + 84;
			object obj21 = text + 24;
			obj19 = obj21;
			object obj22 = obj20 + 76;
			object obj23 = text + 28;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S1_v31+8]");
			object obj26;
			if ((nint)0 != 0)
			{
				object obj25 = text + 28;
				obj26 = obj25;
			}
			else
			{
				obj26 = 0;
			}
			obj22 = obj26;
			object obj27 = text + 32;
			TypeCode typeCode2 = ((uint*)obj27)->GetTypeCode();
			object obj28 = obj5 - 5;
			object obj29 = obj28 / 6;
			object obj30 = obj20 + 32;
			object obj31 = text + 36;
			obj30 = obj31;
			object obj32 = obj20 + 32;
			object obj33 = text + 40;
			TypeCode typeCode3 = ((int*)obj33)->GetTypeCode();
			object obj34 = obj20 + 32;
			object obj35 = text + 44;
			long ticks = ((TimeSpan*)obj35)->Ticks;
			object obj36 = obj20 + 32;
			object obj37 = text + 48;
			nint num10 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S1_v59 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num11 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S1_v151 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj39 = obj36 + 16;
			bool didTimeout2 = ((GameCenterRequest)obj37).didTimeout;
			obj39 = didTimeout2;
			object obj40 = obj20 + 32;
			object obj41 = text + 52;
			TypeCode typeCode4 = ((int*)obj41)->GetTypeCode();
			nint num12 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S1_v72 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj42 = (nint)0 & (nint)0x200;
			if (obj42 != null)
			{
				nint num13 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v147 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime dateTime = TimeUtility.TrimToWholeMilliSeconds((DateTime)typeCode4);
			obj3 = dateTime;
			obj = obj3;
			object obj43 = obj20 + 32;
			object obj44 = text + 56;
			long num14 = ((IntPtr*)obj44)->ToInt64();
			object obj45 = obj29 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj46 = 0;
			object obj47 = 11;
			object obj49 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45))
			{
				object obj48 = obj49 + 16;
				object obj50 = obj46 * 40;
				object obj51 = obj48 + obj50;
				object obj52 = text + 16;
				object obj53 = obj47 << 2;
				object obj54 = obj52 + obj53;
				obj51 = obj54;
				object obj55 = obj49 + 16;
				object obj56 = obj46 * 40;
				object obj57 = obj55 + obj56;
				object obj58 = obj47 << 2;
				object obj59 = text + obj58;
				object obj60 = obj59 + 20;
				TypeCode typeCode5 = ((int*)obj60)->GetTypeCode();
				object obj61 = obj49 + 16;
				object obj62 = obj46 * 40;
				object obj63 = obj61 + obj62;
				object obj64 = obj47 << 2;
				object obj65 = text + obj64;
				object obj66 = obj65 + 24;
				long ticks2 = ((TimeSpan*)obj66)->Ticks;
				object obj67 = obj47 << 2;
				object obj68 = text + obj67;
				object obj69 = obj68 + 28;
				nint num15 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ S0_v98 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj70 = (nint)0 & (nint)0x200;
				if (obj70 != null)
				{
					nint num16 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v131 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj71 = obj46 * 40;
				object obj72 = obj49 + obj71;
				object obj73 = obj72 + 32;
				bool didTimeout3 = ((GameCenterRequest)obj69).didTimeout;
				obj73 = didTimeout3;
				object obj74 = obj47 << 2;
				object obj75 = text + obj74;
				object obj76 = obj75 + 32;
				TypeCode typeCode6 = ((int*)obj76)->GetTypeCode();
				nint num17 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v111 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
				object obj77 = (nint)0 & (nint)0x200;
				if (obj77 != null)
				{
					nint num18 = (nint)typeof(TimeUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S0_v127 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DateTime dateTime2 = TimeUtility.TrimToWholeMilliSeconds((DateTime)typeCode6);
				obj2 = dateTime2;
				obj = obj2;
				object obj78 = obj49 + 16;
				object obj79 = obj46 * 40;
				object obj80 = obj78 + obj79;
				object obj81 = obj49 + 16;
				object obj82 = obj46 * 40;
				object obj83 = obj81 + obj82;
				object obj84 = obj47 << 2;
				object obj85 = text + obj84;
				object obj86 = obj85 + 36;
				long num19 = ((IntPtr*)obj86)->ToInt64();
				object obj87 = obj47 + 6;
				object obj88 = obj46 + 1;
				obj46 = obj88;
				obj47 = obj87;
			}
			object obj89 = obj20 + 72;
			obj89 = obj49;
			object obj18 = obj20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
	}

	private unsafe void OnGameCenterLoadAchievementDescriptionsComplete(string param)
	{
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_052e: Expected Obj, but got I4
		//IL_0537: Expected Obj, but got I4
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected Obj, but got Unknown
		//IL_0487: Expected I, but got Obj
		//IL_049d: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_04c8: Expected I, but got Obj
		//IL_0584: Expected Obj, but got I4
		//IL_00c2: Expected I, but got Obj
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_023c: Expected I, but got Obj
		//IL_0252: Expected Obj, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02fe: Expected Obj, but got I4
		//IL_019b: Expected I, but got Obj
		//IL_027d: Expected I, but got Obj
		//IL_05fc: Expected Obj, but got I4
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03d0: Expected I, but got Obj
		//IL_03e6: Expected Obj, but got I
		//IL_0619: Expected VT, but got I4
		//IL_0625: Expected Obj, but got VT
		//IL_0411: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj3 = num + 16;
		obj3 = 124;
		string text = param.Substring(num);
		object obj4 = text + 12;
		bool flag = (nint)obj4 < 2;
		object obj5 = obj4;
		if (!flag)
		{
			object obj6 = obj4 - 2;
			object obj7 = obj6 / 3;
			object obj8 = obj7 * 3;
			if (obj6 == obj8)
			{
				object obj9 = text + 16;
				TypeCode typeCode = ((int*)obj9)->GetTypeCode();
				nint num2 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v37 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num3 = (nint)typeof(Depository);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v119 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				IDictionary<int, object> dictionary = Depository.RemoveByContext(typeCode);
				if (dictionary != null)
				{
					if ((object)dictionary.GetType() != typeof(LoadAchievementsCompletionHandler))
					{
						dictionary = null;
					}
				}
				else
				{
					dictionary = null;
				}
				if (dictionary == null)
				{
					nint num4 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v102 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num5 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v108 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					LogWarning("OnGameCenterLoadAchievementsComplete: Handler not registered");
					return;
				}
				object obj12 = text + 20;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v50+8]");
				if ((nint)0 > (nint)0)
				{
					object obj14 = text + 20;
					nint num6 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v73 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num7 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v78 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool didTimeout = ((GameCenterRequest)obj14).didTimeout;
				}
				else
				{
					bool didTimeout = false;
				}
				if ((nint)obj4 >= 3)
				{
					object obj16 = obj4 - 2;
					object obj17 = obj16 / 3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj18 = 2;
					object obj19 = default;
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
					object obj21 = default;
					object obj20 = obj21;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj23 = default;
						object obj22 = obj23 + 8;
						object obj24 = text + 16;
						object obj25 = obj18 << 2;
						object obj26 = obj24 + obj25;
						obj22 = obj26;
						object obj27 = obj18 << 2;
						object obj28 = text + obj27;
						object obj29 = obj28 + 20;
						float num8 = ((BinaryReader)obj29).ReadSingle();
						object obj30 = obj18 << 2;
						object obj31 = text + obj30;
						object obj32 = obj31 + 24;
						TypeCode typeCode2 = ((int*)obj32)->GetTypeCode();
						nint num9 = (nint)typeof(TimeUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v76 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
						object obj33 = (nint)0 & (nint)0x200;
						if (obj33 != null)
						{
							nint num10 = (nint)typeof(TimeUtility);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v91 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						DateTime dateTime = TimeUtility.TrimToWholeMilliSeconds((DateTime)typeCode2);
						obj2 = dateTime;
						obj = obj2;
						throw new ArrayTypeMismatchException();
					}
				}
				else
				{
					object obj20 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				return;
			}
			obj5 = obj4;
		}
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string msg = "OnGameCenterLoadAchievementsComplete: Unexpected number of parameters :" + text2;
		nint num11 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v16 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num12 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v21 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning(msg);
	}

	private unsafe void OnGameCenterViewDismissed(string param)
	{
		//IL_0636: Expected Obj, but got I4
		//IL_063f: Expected Obj, but got I4
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected Obj, but got Unknown
		//IL_059d: Expected I, but got Obj
		//IL_05b3: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_05de: Expected I, but got Obj
		//IL_068c: Expected Obj, but got I4
		//IL_00b5: Expected I, but got Obj
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02f1: Expected Obj, but got I4
		//IL_018e: Expected I, but got Obj
		//IL_0270: Expected I, but got Obj
		//IL_0704: Expected Obj, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0376: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected Obj, but got Unknown
		//IL_073b: Expected Obj, but got I4
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected Obj, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected Obj, but got Unknown
		//IL_0787: Expected Obj, but got I4
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected Obj, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_03fe: Expected Obj, but got I4
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_03b7: Expected I, but got Obj
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got I4
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 124;
		string text = param.Substring(num);
		object obj2 = text + 12;
		bool flag = (nint)obj2 < 2;
		object obj3 = obj2;
		if (!flag)
		{
			object obj4 = obj2 - 2;
			object obj5 = obj4 & 7;
			if (obj5 == null)
			{
				object obj6 = text + 16;
				TypeCode typeCode = ((int*)obj6)->GetTypeCode();
				nint num2 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num3 = (nint)typeof(Depository);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v123 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				IDictionary<int, object> dictionary = Depository.RemoveByContext(typeCode);
				if (dictionary != null)
				{
					if ((object)dictionary.GetType() != typeof(LoadAchievementDescriptionsCompletionHandler))
					{
						dictionary = null;
					}
				}
				else
				{
					dictionary = null;
				}
				if (dictionary == null)
				{
					nint num4 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v106 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num5 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v112 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					LogWarning("OnGameCenterLoadAchievementDescriptionsComplete: Handler not registered");
					return;
				}
				object obj9 = text + 20;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v48+8]");
				if ((nint)0 > (nint)0)
				{
					object obj11 = text + 20;
					nint num6 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v104 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num7 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v109 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool didTimeout = ((GameCenterRequest)obj11).didTimeout;
				}
				else
				{
					bool didTimeout = false;
				}
				if ((nint)obj2 >= 3)
				{
					object obj13 = obj2 - 2;
					object obj14 = obj13 / 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj15 = 2;
					object obj16 = default;
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
					object obj18 = default;
					object obj17 = obj18;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj20 = default;
						object obj19 = obj20 + 8;
						object obj21 = text + 16;
						object obj22 = obj15 << 2;
						object obj23 = obj21 + obj22;
						obj19 = obj23;
						object obj24 = obj15 << 2;
						object obj25 = text + obj24;
						object obj26 = obj25 + 20;
						nint num8 = (nint)typeof(GameCenterPlugin);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v72 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
						object obj27 = (nint)0 & (nint)0x200;
						if (obj27 != null)
						{
							nint num9 = (nint)typeof(GameCenterPlugin);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v95 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj28 = obj20 + 12;
						bool didTimeout2 = ((GameCenterRequest)obj26).didTimeout;
						obj28 = didTimeout2;
						object obj29 = obj20 + 16;
						object obj30 = obj15 << 2;
						object obj31 = text + obj30;
						object obj32 = obj31 + 24;
						bool didTimeout3 = ((GameCenterRequest)obj32).didTimeout;
						obj29 = didTimeout3;
						object obj33 = obj20 + 20;
						object obj34 = obj15 << 2;
						object obj35 = text + obj34;
						object obj36 = obj35 + 28;
						bool didTimeout4 = ((GameCenterRequest)obj36).didTimeout;
						obj33 = didTimeout4;
						object obj37 = obj15 << 2;
						object obj38 = text + obj37;
						object obj39 = obj38 + 32;
						TypeCode typeCode2 = ((int*)obj39)->GetTypeCode();
						object obj40 = obj15 << 2;
						object obj41 = text + obj40;
						object obj42 = obj41 + 36;
						bool flag3 = (string)obj42 != "true";
						object obj43 = obj15 << 2;
						object obj44 = text + obj43;
						object obj45 = obj44 + 40;
						bool flag4 = (string)obj45 != "true";
						object obj46 = obj20 + 32;
						object obj47 = obj15 << 2;
						object obj48 = text + obj47;
						object obj49 = obj48 + 44;
						object obj50 = obj49;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S1_v87+8]");
						object obj54;
						if ((nint)0 != 0)
						{
							object obj51 = obj15 << 2;
							object obj52 = text + obj51;
							object obj53 = obj52 + 44;
							obj54 = obj53;
						}
						else
						{
							obj54 = 0;
						}
						obj46 = obj54;
						throw new ArrayTypeMismatchException();
					}
				}
				else
				{
					object obj17 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				return;
			}
			obj3 = obj2;
		}
		object obj55 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string msg = "OnGameCenterLoadAchievementDescriptionsComplete: Unexpected number of parameters :" + text2;
		nint num10 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v15 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj56 = (nint)0 & (nint)0x200;
		if (obj56 != null)
		{
			nint num11 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v20 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning(msg);
	}

	private static string UnescapeResultString(string s)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I4
		//IL_008f: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num2 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v22 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num4 = PluginUtil.CheckInHandler((Delegate)(object)s, obj2);
		return (string)(object)CoroutineUtil.WaitForAll((YieldInstruction[])num4);
	}

	private static void LogError(string msg)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_027a: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I
		//IL_031b: Expected I, but got Obj
		//IL_0331: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_02cb: Expected I, but got Obj
		//IL_02e1: Expected Obj, but got I
		//IL_0183: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v53 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)_instance).FindKernel((string)null);
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v14 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			if (num5 == 0)
			{
				if (!flag)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v49 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning("ResetAchievements was called before Init");
				return;
			}
			if (!flag)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num9 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v28 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v34 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num11 = FileUtil.CopyTo((Stream)(object)msg, (Stream)(object)_instance);
		}
		else if (msg != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	private static void LogWarning(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[GameCenterPlugin] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[GameCenterPlugin] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogAssertion(message);
	}

	public GameCenterPlugin()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[GameCenterPlugin] ", (int)this);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(message);
	}

	static GameCenterPlugin()
	{
		//IL_029e: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_0239: Expected I, but got Obj
		//IL_02ed: Expected I, but got Obj
		//IL_0303: Expected Obj, but got I
		//IL_039d: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I
		//IL_002c: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_0145: Expected I, but got Obj
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_00df: Expected I, but got Obj
		//IL_01d3: Expected I, but got Obj
		string dataPath = Application.dataPath;
		bool flag = (nint)dataPath == 8;
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag2 = obj != null;
		if (flag)
		{
			if (flag2)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v65 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)_instance).FindKernel((string)null);
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v14 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag3 = obj3 != null;
			if (num5 == 0)
			{
				if (flag3)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v61 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning("ShowLoginView was called before Init");
				return;
			}
			if (flag3)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v51 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameCenterPlugin instance = _instance;
			if (~(instance._hasLoginView ? 1u : 0u) != 0)
			{
				return;
			}
			nint num9 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v38 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num10 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v45 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameCenterPlugin instance2 = _instance;
			instance2._hasLoginView = false;
			return;
		}
		if (flag2)
		{
			nint num11 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v19 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogWarning("Could not show login view (not on iOS)");
	}
}
