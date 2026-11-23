using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Plugins.GameCenter;
using SYBO.Common.Utilities;
using UnityEngine;

public class SocialManagerIOS : MonoBehaviour
{
	public enum GCState
	{
		LoggedOut,
		Authenticating,
		LoadingFriends,
		LoggedIn
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public SocialManagerIOS _003C_003E4__this;

		public int context;

		internal unsafe void _003CLoadFriends_003Eb__0(GameCenter.Leaderboard leaderboard, string leaderboardError)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Expected Obj, but got Unknown
			//IL_04cd: Expected Obj, but got I4
			//IL_0080: Expected Obj, but got I4
			//IL_01d2: Expected Obj, but got I
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected Obj, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected Obj, but got Unknown
			//IL_0221: Expected Obj, but got I
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected Obj, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected Obj, but got Unknown
			//IL_00b8: Expected Obj, but got VT
			//IL_00b8: Expected Obj, but got I
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0574: Expected Obj, but got Unknown
			//IL_0520: Unknown result type (might be due to invalid IL or missing references)
			//IL_0525: Expected Obj, but got Unknown
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03db: Expected Obj, but got Unknown
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0446: Expected Obj, but got Unknown
			//IL_054e: Expected Obj, but got I
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected Ref, but got Unknown
			//IL_0132: Expected Obj, but got I
			//IL_015f: Expected Obj, but got I
			//IL_02f1: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - 80;
			_ = 0;
			object obj3 = obj - -64;
			obj3 = 0;
			_ = 0;
			SocialManagerIOS socialManagerIOS = _003C_003E4__this;
			if (context != socialManagerIOS._loadFriendsContext)
			{
				return;
			}
			string[] array = default;
			if (leaderboard != null)
			{
				GameCenter.Score[] scores = leaderboard.scores;
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ S4_v6 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, GameCenterProfile>>>)+4] (should have been resolved before IL gen)");
				PlayerInfo instance = PlayerInfo.Instance;
				GameCenter.Score[] scores2 = leaderboard.scores;
				object obj9;
				object obj7 = default;
				for (object obj4 = 0; scores2.Length > (nint)obj4; obj9 = obj4 + 1, obj4 = obj9)
				{
					object obj5 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE9");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					if (!((string)0 != (string)leaderboard.localPlayerScore))
					{
						continue;
					}
					SocialManagerIOS socialManagerIOS2 = _003C_003E4__this;
					object obj6;
					if (socialManagerIOS2._gcFriends != null)
					{
						ref GameCenterProfile value = ref *(GameCenterProfile*)(obj + 76);
						Dictionary<string, GameCenterProfile> gcFriends = socialManagerIOS2._gcFriends;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						if (gcFriends.TryGetValue((string)0, out value))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
							obj6 = 0;
							goto IL_0532;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					_ = 0;
					obj6 = obj7;
					goto IL_0532;
					IL_0532:
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S5_v7 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, GameCenterProfile>>)+5C]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v335 @ S5_v8+4] (should have been resolved before IL gen)");
				}
				SocialManagerIOS socialManagerIOS3 = _003C_003E4__this;
				Dictionary<string, GameCenterProfile> gcFriends2 = default;
				socialManagerIOS3._gcFriends = gcFriends2;
				SocialManagerIOS socialManagerIOS4 = _003C_003E4__this;
				Dictionary<string, GameCenterProfile>.KeyCollection keys = socialManagerIOS4._gcFriends.Keys;
				nint num5 = 0;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S2_v7 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, GameCenterProfile>+KeyCollection<System.String, GameCenterProfile>>)+C]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ S2_v8+4] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object obj11 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
				object obj12 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				object obj13 = obj + 56;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj15 = default;
				object obj18 = default;
				object obj19 = default;
				object obj21 = default;
				object obj22 = default;
				GameCenter.LoadPlayersCompletionHandler loadPlayersCompletionHandler = default;
				while (true)
				{
					_ = 0;
					object obj14 = obj + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj15 == null)
						{
							goto IL_03cd;
						}
						_ = 0;
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
								object obj16 = 0 << 2;
								object obj17 = (object)array + obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
								_ = 0;
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
					bool flag = obj18 != obj19;
					object obj20 = obj21;
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
						goto IL_03cd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj20 = obj22;
					break;
					IL_03cd:
					object obj23 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238E");
					loadPlayersCompletionHandler._002Ector(this, (nint)__ldftn(_003C_003Ec__DisplayClass34_0._003CLoadFriends_003Eb__1));
					GameCenter.LoadPlayers(array, loadPlayersCompletionHandler);
					return;
				}
				_ = 0;
				object obj24 = obj + 16;
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
			array[0] = null;
		}

		internal unsafe void _003CLoadFriends_003Eb__1(GameCenter.Player[] players, string playersError)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0192: Expected Obj, but got I
			//IL_0041: Expected Obj, but got I4
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected Obj, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected Ref, but got Unknown
			//IL_00d3: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I
			//IL_011d: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			SocialManagerIOS socialManagerIOS = _003C_003E4__this;
			if (context != socialManagerIOS._loadFriendsContext)
			{
				return;
			}
			bool flag = players == null;
			MonoBehaviour monoBehaviour = socialManagerIOS;
			if (!flag)
			{
				object obj3 = 0;
				while (players.Length > (nint)obj3)
				{
					object obj4 = obj3 << 4;
					object obj5 = (object)players + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v15+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v15+10]");
					_ = 0;
					SocialManagerIOS socialManagerIOS2 = _003C_003E4__this;
					if (socialManagerIOS2._gcFriends != null)
					{
						ref GameCenterProfile value = ref *(GameCenterProfile*)(obj + 28);
						Dictionary<string, GameCenterProfile> gcFriends = socialManagerIOS2._gcFriends;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						if (gcFriends.TryGetValue((string)0, out value))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
							_ = 0;
						}
					}
					object obj8 = obj3 + 1;
					obj3 = obj8;
				}
				monoBehaviour = _003C_003E4__this;
			}
			MonoBehaviour monoBehaviour2 = monoBehaviour;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ L3_v3 (UnityEngine.MonoBehaviour)+10]");
			IEnumerator routine = ((SocialManagerIOS)monoBehaviour2).RefreshFriendImages((Dictionary<string, GameCenterProfile>)0);
			Coroutine coroutine = monoBehaviour.StartCoroutine(routine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public GameCenterProfile profile;

		internal void _003CRefreshFriendImages_003Eb__0(GameCenterProfile prof, Texture2D picture)
		{
			GameCenterProfile gameCenterProfile = profile;
			gameCenterProfile.image = picture;
		}
	}

	private sealed class _003CRefreshFriendImages_003Ed__35(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SocialManagerIOS _003C_003E4__this;

		public Dictionary<string, GameCenterProfile> gcProfiles;

		private int _003CphotoDownloadContext_003E5__2;

		private List<GameCenterProfile>.Enumerator _003C_003E7__wrap2;

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
				((_003CRefreshFriendImages_003Ed__35)obj6)._003C_003Em__Finally1();
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
			//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7a: Expected Obj, but got Unknown
			//IL_0ba2: Expected Obj, but got I
			//IL_0bb2: Expected Obj, but got I
			//IL_0088: Expected Obj, but got I
			//IL_009d: Expected Obj, but got I
			//IL_00b2: Expected Obj, but got I
			//IL_00d5: Expected Obj, but got I
			//IL_0603: Expected Obj, but got I
			//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab7: Expected Obj, but got Unknown
			//IL_0af1: Expected Obj, but got I
			//IL_0b11: Expected Obj, but got I
			//IL_075d: Expected Obj, but got I
			//IL_0638: Expected Obj, but got I4
			//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be5: Expected Obj, but got Unknown
			//IL_0186: Expected Obj, but got I
			//IL_068b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0690: Expected Obj, but got Unknown
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected Obj, but got Unknown
			//IL_0718: Expected Obj, but got I
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Expected Obj, but got Unknown
			//IL_06fd: Expected Obj, but got I
			//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c08: Expected Obj, but got Unknown
			//IL_02a5: Expected Obj, but got I
			//IL_07fb: Expected Obj, but got I
			//IL_028a: Expected Obj, but got I4
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0491: Expected Obj, but got Unknown
			//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c5c: Expected Obj, but got Unknown
			//IL_088e: Expected Obj, but got I4
			//IL_046f: Expected Obj, but got I4
			//IL_055f: Expected Obj, but got I
			//IL_0581: Expected Obj, but got I
			//IL_093f: Expected Obj, but got I
			//IL_0954: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 + -64;
			_ = 0;
			_ = 0;
			object obj3 = obj + 60;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+8]");
			object obj6;
			object obj8;
			bool result = default;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+8]");
					if ((nint)0 != 2)
					{
						obj6 = obj;
						goto IL_0bd7;
					}
				}
				_ = -3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15+18]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15+1C]");
				if (num != 0)
				{
					obj7 = 0;
				}
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+18]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15+1C]");
					bool flag = num2 != 0;
					obj8 = obj4;
					object obj9 = obj4;
					if (!flag)
					{
						goto IL_067c;
					}
					goto IL_0cf2;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				object obj10 = 0;
				_ = 2;
				result = true;
				obj6 = obj;
				goto IL_0bd7;
			}
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15+1C]");
			object obj11 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v164+14]");
			object obj13 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v166+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v166+18]");
			object obj14 = num3 - 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj20;
			bool flag4;
			object obj24;
			object obj29;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
						object obj15 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							object obj16 = obj + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94E");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
								_ = 0;
								object obj17 = obj + 40;
								obj = obj17;
								_ = 0;
								object obj19 = default;
								object obj22 = default;
								bool flag3 = default;
								object obj23 = default;
								object obj25 = default;
								bool flag6 = default;
								object obj26 = default;
								while (true)
								{
									_ = 0;
									object obj18 = obj + 40;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										if (obj19 == null)
										{
											obj20 = 9;
											goto IL_047d;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
										object obj21 = 0;
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
													if (obj22 == null)
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
									bool flag2 = (flag3 ? 1 : 0) != (nint)obj23;
									flag4 = flag3;
									obj24 = obj25;
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
									obj20 = 0;
									if (!flag5)
									{
										goto IL_047d;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									flag4 = flag6;
									obj24 = obj26;
									break;
									IL_047d:
									_ = 0;
									object obj27 = obj + 16;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										goto IL_04d4;
									}
									goto IL_0594;
								}
								_ = 0;
								object obj28 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									obj29 = obj;
									goto IL_0b1f;
								}
								goto IL_0cb3;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_09f7;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_09f7;
			IL_0594:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_09f7;
			IL_0cb3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj30 = default;
			if ((nint)obj30 == (flag4 ? 1 : 0))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag7 = (nint)0 != 1;
				result = false;
				obj6 = obj;
				if (flag7)
				{
					goto IL_0bd7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				flag4 = false;
				object obj31 = default;
				obj24 = obj31;
			}
			_ = 0;
			object obj32 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag8 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj29 = 0;
			result = flag4;
			object obj33 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			if (!flag8)
			{
				goto IL_0b1f;
			}
			goto IL_0d3b;
			IL_04d4:
			bool flag9 = (nint)obj20 != 9;
			if (obj20 == null)
			{
				flag9 = false;
			}
			result = false;
			obj6 = obj;
			if (!flag9)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
					object obj35 = 0;
					_ = -3;
					obj8 = obj35;
					goto IL_067c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_09f7;
			}
			goto IL_0bd7;
			IL_0d3b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_0bd7;
			IL_09f7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			bool flag10 = default;
			flag4 = flag10;
			object obj36 = default;
			obj24 = obj36;
			goto IL_0cb3;
			IL_0bd7:
			object obj37 = obj6 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B054");
			return result;
			IL_0b1f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			result = flag4;
			obj33 = obj24;
			obj6 = obj29;
			goto IL_0d3b;
			IL_0cf2:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				object obj38 = (nint)0 + (nint)28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
				result = false;
				obj6 = obj;
				goto IL_0bd7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_09f7;
			IL_067c:
			_ = 0;
			object obj39 = obj8 + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				object obj40 = default;
				if (obj40 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
					object obj9 = 0;
					goto IL_0cf2;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
						object obj41 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ S0_v102+28]");
							Texture2D texture2D = default;
							((UnityEngine.Object)texture2D).m_CachedPtr = (IntPtr)0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								GameCenterProfile prof = default;
								((_003C_003Ec__DisplayClass35_0)5299)._003CRefreshFriendImages_003Eb__0(prof, texture2D);
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
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
											object obj42 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
											object obj43 = 0;
											_ = 1;
											result = true;
											obj6 = obj;
											goto IL_0bd7;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									goto IL_09f7;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_09f7;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_09f7;
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

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public GameCenterProfile profile;

		public Action<GameCenterProfile, Texture2D> handler;

		internal void _003CDownloadPictureForProfile_003Eb__0(string playerID, Texture2D photo, string error)
		{
			GameCenterProfile gameCenterProfile = profile;
			DateTime now = CDateTime.Now;
			gameCenterProfile.refreshedTime = now;
			if (error == null)
			{
				Action<GameCenterProfile, Texture2D> action = handler;
				if (handler != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S0_v6 (System.Action`2<GameCenterProfile, UnityEngine.Texture2D>)+C] (should have been resolved before IL gen)");
				}
			}
		}
	}

	private sealed class _003CDownloadPictureForProfile_003Ed__36(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCenterProfile profile;

		public Action<GameCenterProfile, Texture2D> handler;

		public SocialManager.SocialPictureSize pictureSize;

		private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

		private DateTime _003ClastRefresh_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_021a;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				_003C_003Ec__DisplayClass36_0 obj3 = default;
				_003C_003E8__1 = obj3;
				_003C_003Ec__DisplayClass36_0 obj4 = _003C_003E8__1;
				obj4.profile = profile;
				_003C_003Ec__DisplayClass36_0 obj5 = _003C_003E8__1;
				obj5.handler = handler;
				_003C_003Ec__DisplayClass36_0 obj6 = _003C_003E8__1;
				GameCenterProfile gameCenterProfile = obj6.profile;
				_003ClastRefresh_003E5__2 = gameCenterProfile.refreshedTime;
				GameCenterProfile gameCenterProfile2 = obj6.profile;
				if (!(gameCenterProfile2.image == null))
				{
					DateTime now = CDateTime.Now;
					TimeSpan timeSpan = now - _003ClastRefresh_003E5__2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					double num = 0.0 * 1E-07;
					if (!(num > 3600.0))
					{
						goto IL_021a;
					}
				}
				_003C_003Ec__DisplayClass36_0 obj7 = _003C_003E8__1;
				GameCenterProfile gameCenterProfile3 = obj7.profile;
				GameCenter.LoadPhotoCompletionHandler loadPhotoCompletionHandler = default;
				loadPhotoCompletionHandler._002Ector(obj7, (nint)__ldftn(_003C_003Ec__DisplayClass36_0._003CDownloadPictureForProfile_003Eb__0));
				bool flag = pictureSize == SocialManager.SocialPictureSize.Large;
				int num2 = 250;
				if (!flag)
				{
					num2 = 50;
				}
				GameCenter.LoadPhoto(gameCenterProfile3.id, GameCenter.PhotoSize.Small, num2, num2, loadPhotoCompletionHandler);
			}
			_003C_003Ec__DisplayClass36_0 obj8 = _003C_003E8__1;
			GameCenterProfile gameCenterProfile4 = obj8.profile;
			bool flag2 = gameCenterProfile4.refreshedTime == _003ClastRefresh_003E5__2;
			bool flag3 = !flag2;
			bool result = false;
			if (!flag3)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				result = true;
			}
			goto IL_021a;
			IL_021a:
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static GameCenter.RequestCompleteHandler _003C_003E9__41_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CReportScore_003Eb__41_0(string error)
		{
			if (error == null)
			{
			}
		}
	}

	private const string ONLINESETTINGS_FILTER_GC_FRIENDS_KEY = "social_filter_gc_friends";

	private const bool FILTER_GC_FRIENDS_USING_LEADERBOARD_DEFAULT = true;

	private const string GC_LEADERBOARD_ID = "com.kiloo.subwaysurfers.ScoreLeaderboard";

	private static SocialManagerIOS _instance;

	private GCState _gcState;

	private Dictionary<string, GameCenterProfile> _gcFriends;

	private Action<GameCenterProfile> _playerPhotoDownloadedHandler;

	private bool _pausePhotoDownloading;

	private int _photoDownloadContext;

	private List<string> _latestPreConsolidationGCIds;

	private List<string> _latestSuccesfullyConsolidationGCIds;

	private Action _gameCenterStateChanged;

	private static bool _applicationIsQuiting;

	private int _loadFriendsContext;

	private GameCenter.ShowViewState _lastViewState;

	private string _lastLeaderboardCategory = "com.kiloo.subwaysurfers.ScoreLeaderboard";

	private GameCenter.LeaderboardTimeScope _lastTimeScope;

	private Action _invalidate;

	public GCState gameCenterState
	{
		get
		{
			return _gcState;
		}
		set
		{
			if (_gcState != value)
			{
				_gcState = value;
				Action gameCenterStateChanged = _gameCenterStateChanged;
				if (_gameCenterStateChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v9.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
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
			_pausePhotoDownloading = value;
		}
	}

	public static SocialManagerIOS instance
	{
		get
		{
			Init();
			return _instance;
		}
	}

	public static bool isInstanced => _instance != null;

	public void AddGameCenterStateChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_gameCenterStateChanged, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action gameCenterStateChanged = default;
		_gameCenterStateChanged = gameCenterStateChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RemoveGameCenterStateChangedHandler(Action handler)
	{
		Delegate obj = Delegate.Remove(_gameCenterStateChanged, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action gameCenterStateChanged = default;
		_gameCenterStateChanged = gameCenterStateChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private void OnApplicationQuit()
	{
		_applicationIsQuiting = true;
	}

	private static void Init()
	{
		if (_instance == null && !_applicationIsQuiting)
		{
			GameObject gameObject = default;
			gameObject._002Ector();
			gameObject.name = "SocialManagerIOS";
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			SocialManagerIOS socialManagerIOS = gameObject.AddComponent<SocialManagerIOS>();
			Transform childTransform = gameObject.transform;
			HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.Dynamic);
			Transform asLastSibling = gameObject.transform;
			HierarchyUtility.SetAsLastSibling(asLastSibling);
			Transform childTransform2 = gameObject.transform;
			HierarchyUtility.ReparentByHierarchyPathType(childTransform2, HierarchyPathType.DynamicManagers);
		}
	}

	private void Awake()
	{
		_instance = this;
	}

	public unsafe void LoadFriends()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		GameCenter.LocalPlayer localPlayer = GameCenter.GetLocalPlayer();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			int loadFriendsContext = _loadFriendsContext + 1;
			_loadFriendsContext = loadFriendsContext;
			gameCenterState = GCState.LoadingFriends;
			GameCenter.LoadLeaderboardCompletionHandler loadLeaderboardCompletionHandler = default;
			object obj4 = default;
			loadLeaderboardCompletionHandler._002Ector(obj4, (nint)__ldftn(_003C_003Ec__DisplayClass34_0._003CLoadFriends_003Eb__0));
			GameCenter.LoadLeaderboard("com.kiloo.subwaysurfers.ScoreLeaderboard", GameCenter.LeaderboardPlayerScope.FriendsOnly, GameCenter.LeaderboardTimeScope.AllTime, 1, 100, loadLeaderboardCompletionHandler);
		}
	}

	private IEnumerator RefreshFriendImages(Dictionary<string, GameCenterProfile> gcProfiles)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public IEnumerator DownloadPictureForProfile(GameCenterProfile profile, SocialManager.SocialPictureSize pictureSize, Action<GameCenterProfile, Texture2D> handler)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void AbortAsynchronousProcesses()
	{
		int photoDownloadContext = _photoDownloadContext + 1;
		_photoDownloadContext = photoDownloadContext;
		int loadFriendsContext = _loadFriendsContext + 1;
		_loadFriendsContext = loadFriendsContext;
	}

	private void FlurryLogGCFriendsRetrieved(int total, int withGameInstalled)
	{
		if (Flurry.ShouldLogDailyEvent("Social GameCenter Friends Retrieved"))
		{
			string text = Flurry.ConvertFriendCountToBracket(total);
			string text2 = Flurry.ConvertFriendCountToBracket(withGameInstalled);
			string text3 = text + ";" + text2;
		}
	}

	private void PerformLoadFriendsDoneActions()
	{
		gameCenterState = GCState.LoggedIn;
		Action invalidate = _invalidate;
		if (_invalidate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v5.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public bool IsDoneAuthenticating()
	{
		bool flag = _gcState == GCState.LoggedIn;
		bool flag2 = _gcState == GCState.LoggedOut;
		return flag | flag2;
	}

	public unsafe void ReportScore(int newScore)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I
		//IL_00c3: Expected I8, but got I4
		//IL_00c3: Expected I8, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		GameCenter.LocalPlayer localPlayer = GameCenter.GetLocalPlayer();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			bool flag = _003C_003Ec._003C_003E9__41_0 == null;
			bool flag2 = !flag;
			GameCenter.RequestCompleteHandler completionHandler = _003C_003Ec._003C_003E9__41_0;
			if (!flag2)
			{
				GameCenter.RequestCompleteHandler requestCompleteHandler = default;
				requestCompleteHandler._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CReportScore_003Eb__41_0));
				_003C_003Ec._003C_003E9__41_0 = requestCompleteHandler;
				completionHandler = requestCompleteHandler;
			}
			GameCenter.ReportScore("com.kiloo.subwaysurfers.ScoreLeaderboard", newScore, 0uL, completionHandler);
		}
	}

	public unsafe void ShowLeaderBoard()
	{
		GameCenter.ViewDismissedHandler viewDismissedHandler = default;
		viewDismissedHandler._002Ector(this, (nint)__ldftn(SocialManagerIOS._003CShowLeaderBoard_003Eb__42_0));
		GameCenter.ShowView(_lastViewState, _lastLeaderboardCategory, _lastTimeScope, viewDismissedHandler);
	}

	public string GetGCListAsStringAndSaveAsPreConsolidated()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got I
		//IL_0198: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		if (_latestPreConsolidationGCIds == null)
		{
			List<string> list = default;
			list._002Ector();
			_latestPreConsolidationGCIds = list;
		}
		else
		{
			((List<T>)(object)_latestPreConsolidationGCIds).Clear();
		}
		if (_gcFriends != null)
		{
			Dictionary<string, GameCenterProfile>.KeyCollection keys = _gcFriends.Keys;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, GameCenterProfile>+KeyCollection<System.String, GameCenterProfile>>)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S2_v6+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj4 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj5 = obj + 32;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj7 = default;
			string[] array = default;
			object obj10 = default;
			object obj11 = default;
			object obj13 = default;
			object obj14 = default;
			while (true)
			{
				_ = 0;
				object obj6 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj7 == null)
					{
						goto IL_0274;
					}
					_ = 0;
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
							object obj8 = 0 << 2;
							object obj9 = (object)array + obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							_ = 0;
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
					goto IL_0274;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
				break;
				IL_0274:
				object obj15 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238E");
				string result = string.Join(";", array);
				List<string> latestPreConsolidationGCIds = _latestPreConsolidationGCIds;
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S4_v4 (Il2CppRgctx<System.Collections.Generic.List`1<System.String>>)+3C]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v263 @ S4_v5+4] (should have been resolved before IL gen)");
				return result;
			}
			_ = 0;
			object obj17 = obj + 16;
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

	public void HandleConsolidatedFriendsSuccess()
	{
		_latestSuccesfullyConsolidationGCIds = _latestPreConsolidationGCIds;
		_latestPreConsolidationGCIds = null;
	}

	public bool HasUnconsolidatedGCFriends()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		bool result = default;
		if (_gcFriends != null)
		{
			if (_latestSuccesfullyConsolidationGCIds == null)
			{
				result = true;
			}
			else
			{
				object obj3 = obj + 16;
				Dictionary<string, GameCenterProfile>.KeyCollection keys = _gcFriends.Keys;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				object obj4 = obj + 32;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				bool flag2 = default;
				object obj6 = default;
				object obj7 = default;
				object obj8 = default;
				object obj10 = default;
				object obj11 = default;
				bool result2 = default;
				while (true)
				{
					_ = 0;
					object obj5 = obj + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
								if (obj6 == null)
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
					bool flag3 = obj7 != obj8;
					object obj9 = obj10;
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
						obj9 = obj11;
					}
					_ = 0;
					object obj12 = obj + 16;
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
				object obj13 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238E");
			}
		}
		return result;
	}

	public void ClearFriends()
	{
		_latestSuccesfullyConsolidationGCIds = null;
		_latestPreConsolidationGCIds = null;
		_gcFriends = null;
	}

	public bool GCFriendsContainKey(string key)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		if (_gcFriends != null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, GameCenterProfile>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			return (byte)(obj2 >> 31) != 0;
		}
		return false;
	}

	public unsafe GameCenterProfile TryGetUserProfileFromKey(string key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_0048: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		GameCenterProfile result = default;
		if (_gcFriends != null)
		{
			bool flag = _gcFriends.TryGetValue(key, out *(GameCenterProfile*)(obj + 12));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			result = (GameCenterProfile)0;
			if (!flag)
			{
				result = null;
			}
		}
		return result;
	}

	public void AddInvalidateHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_invalidate, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action invalidate = default;
		_invalidate = invalidate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void AddPlayerPhotoDownloadedHandler(Action<GameCenterProfile> handler)
	{
		Delegate obj = Delegate.Combine(_playerPhotoDownloadedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<GameCenterProfile> playerPhotoDownloadedHandler = default;
		_playerPhotoDownloadedHandler = playerPhotoDownloadedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
	}

	public void RemovePlayerPhotoDownloadedHandler(Action<GameCenterProfile> handler)
	{
		Delegate obj = Delegate.Remove(_playerPhotoDownloadedHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Action<GameCenterProfile> playerPhotoDownloadedHandler = default;
		_playerPhotoDownloadedHandler = playerPhotoDownloadedHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
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

	private void _003CShowLeaderBoard_003Eb__42_0(GameCenter.ShowViewState viewState, string leaderboardCategory, GameCenter.LeaderboardTimeScope leaderboardTimescope)
	{
		_lastLeaderboardCategory = leaderboardCategory;
		_lastViewState = viewState;
		_lastTimeScope = leaderboardTimescope;
	}
}
