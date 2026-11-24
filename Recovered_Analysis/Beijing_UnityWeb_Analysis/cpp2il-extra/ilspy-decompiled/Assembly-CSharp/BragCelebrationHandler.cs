using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Plugins.Facebook;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;

public class BragCelebrationHandler : MonoBehaviour
{
	public enum State
	{
		NotCalculated,
		BeatenOnlySelf,
		BeatenFriendsOnlyGcOnline,
		BeatenFriendsOnlineAll
	}

	private sealed class _003CUpdateUI_003Ed__26(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BragCelebrationHandler _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0576: Unknown result type (might be due to invalid IL or missing references)
				//IL_057b: Expected Obj, but got Unknown
				//IL_0584: Expected Obj, but got I4
				//IL_0173: Expected I, but got Obj
				//IL_0189: Expected Obj, but got I
				//IL_05f4: Expected I4, but got Obj
				//IL_01fb: Expected Obj, but got I4
				//IL_01b4: Expected I, but got Obj
				//IL_0093: Expected I4, but got Obj
				//IL_00a1: Expected I, but got Obj
				//IL_00b7: Expected Obj, but got I
				//IL_02c4: Expected I, but got Obj
				//IL_02da: Expected Obj, but got I
				//IL_024b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0250: Expected Obj, but got Unknown
				//IL_026c: Expected Obj, but got I4
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0145: Expected Obj, but got Unknown
				//IL_0160: Expected I4, but got Obj
				//IL_0160: Expected Obj, but got I4
				//IL_00e2: Expected I, but got Obj
				//IL_063c: Expected I4, but got Obj
				//IL_0375: Expected Obj, but got I4
				//IL_0305: Expected I, but got Obj
				//IL_040b: Expected Obj, but got I4
				//IL_0419: Expected I, but got Obj
				//IL_042f: Expected Obj, but got I
				//IL_067e: Expected Obj, but got I
				//IL_04bc: Expected I4, but got Obj
				//IL_045a: Expected I, but got Obj
				//IL_04cf: Expected I, but got Obj
				//IL_04e5: Expected Obj, but got I
				//IL_0510: Expected I, but got Obj
				object obj2 = default;
				object obj = obj2 + 4;
				obj = 0;
				BragCelebrationHandler bragCelebrationHandler = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						IEnumerator enumerator = _003C_003E4__this.UpdateUI();
						if ((nint)enumerator != 1)
						{
							nint num = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v45 (Il2CppClass<Strings>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							if (obj3 != null)
							{
								nint num2 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v84 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string text = Strings.GetDefault("BRAG_CELEBRATION_JUST_BEAT");
							bragCelebrationHandler._justBeatLabel.fontSize = (int)text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
							((UIScreenController)(object)_003C_003E4__this).CalculateCameraFieldOfView((Camera)(object)bragCelebrationHandler._friendPicture, 0f, 0f);
							bragCelebrationHandler._friendPicture.tag = (string)1;
							((UIScreenController)(object)_003C_003E4__this).CalculateCameraFieldOfView((Camera)(object)bragCelebrationHandler._friendPicture, 0.5f, 1f);
							State state = _003C_003E4__this.state;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v60 (BragCelebrationHandler+State)+C]");
							bool flag = (nint)0 < (nint)2;
							string tag = bragCelebrationHandler._beatenFriendsLeftLabel.tag;
							if (flag)
							{
								((GameObject)(object)tag).tag = null;
							}
							else
							{
								((GameObject)(object)tag).tag = (string)1;
								nint num3 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S1_v71 (Il2CppClass<Strings>)+BA]");
								object obj4 = (nint)0 & (nint)0x200;
								if (obj4 != null)
								{
									nint num4 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v79 (Il2CppClass<Strings>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string format = Strings.GetDefault("BRAG_CELEBRATION_FRIENDS_BEAT_LEFT");
								State state2 = _003C_003E4__this.state;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S2_v41 (BragCelebrationHandler+State)+C]");
								object obj5 = -1;
								obj2 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
								object[] args = default;
								string text2 = string.Format(format, args);
								bragCelebrationHandler._beatenFriendsLeftLabel.fontSize = (int)text2;
							}
							nint num5 = (nint)typeof(SocialManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v65 (Il2CppClass<SocialManager>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num6 = (nint)typeof(SocialManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v74 (Il2CppClass<SocialManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string saveDataPath = SocialManager.GetSaveDataPath();
							if (saveDataPath == null)
							{
								bragCelebrationHandler._bragGo.tag = null;
							}
						}
						_003C_003E4__this.CalculateState();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				List<Friend> surpassedFriends = _003C_003E4__this._surpassedFriends;
				if (surpassedFriends != null)
				{
					List<Friend> surpassedFriends2 = _003C_003E4__this._surpassedFriends;
					Texture2D image = ((Friend)(object)surpassedFriends2).image;
					bragCelebrationHandler._firstBeatenFriendLabel.fontSize = (int)image;
					nint num7 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v35 (Il2CppClass<SocialManager>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num8 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v41 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
					List<Friend> surpassedFriends3 = _003C_003E4__this._surpassedFriends;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num9 = 0;
					string text3 = default;
					text3.m_stringLength = (int)num9;
					_ = 0;
					object obj8 = text3 + 16;
					obj8 = _003C_003E4__this;
					((SocialManager)facebookDialogsSupported).OnGameCenterAuthentication((byte)(int)surpassedFriends3 != 0, text3);
				}
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v11 (Il2CppClass<Strings>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num11 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v29 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text4 = Strings.GetDefault("BRAG_CELEBRATION_NEW_HIGHSCORE");
				bragCelebrationHandler._newHighScoreTopTitle.fontSize = (int)text4;
				int bragScoreThreshold = PlayerSave.bragScoreThreshold;
				obj = bragScoreThreshold;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				int fontSize = default;
				bragCelebrationHandler._highScoreLabel.fontSize = fontSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 1f;
				object obj10 = this + 12;
				object obj11 = default;
				obj10 = obj11;
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

	private sealed class _003CAnimateWidgetAlpha_003Ed__30(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWidget label;

		public float duration;

		public float toAlpha;

		private float _003CfromAlpha_003E5__2;

		private float _003Cfactor_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00df: Expected I, but got Obj
				//IL_00f5: Expected Obj, but got I
				//IL_0120: Expected I, but got Obj
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Expected Obj, but got Unknown
				//IL_024f: Expected Obj, but got I4
				//IL_0263: Expected Obj, but got I4
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
					float num = default;
					_003CfromAlpha_003E5__2 = num;
					_003Cfactor_003E5__3 = 0f;
				}
				if (_003Cfactor_003E5__3 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime / duration;
					float num3 = _003Cfactor_003E5__3 + num2;
					_003Cfactor_003E5__3 = num3;
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num5 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num6;
					if (_003Cfactor_003E5__3 < 0f)
					{
						num6 = 0f;
					}
					else
					{
						num6 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
					}
					_003Cfactor_003E5__3 = num6;
					float num7 = Mathf.LerpUnclamped(_003CfromAlpha_003E5__2, toAlpha, _003Cfactor_003E5__3);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					object obj2 = this + 12;
					obj2 = 0;
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

	private GameObject _noFriendsStateGo;

	private GameObject _gcFriendsStateGo;

	private GameObject _allFriendsStateGo;

	private GameObject _friendPicture;

	private UILabel _newHighScoreTopTitle;

	private UILabel _highScoreLabel;

	private UILabel _justBeatLabel;

	private UILabel _firstBeatenFriendLabel;

	private UILabel _beatenFriendsLeftLabel;

	private UILabel _bragButtonTitle;

	private UILabel _competeWithFriendsButtonTitle;

	private UITexture _friendPictureTexture;

	private GameObject _bragGo;

	private Friend __bestSurpassedFriend;

	private List<Friend> __surpassedFriends;

	private State _socialState;

	private Friend _bestSurpassedFriend
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Friend friend = default;
			friend.userid = 0;
			object obj = friend + 16;
			obj = this;
			return friend;
		}
	}

	private List<Friend> _surpassedFriends
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0244: Expected Obj, but got Unknown
			//IL_024d: Expected Obj, but got I4
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Expected Obj, but got Unknown
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Expected Obj, but got Unknown
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Expected Obj, but got Unknown
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected Obj, but got Unknown
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Expected Obj, but got Unknown
			//IL_02ea: Expected Obj, but got I4
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected Obj, but got Unknown
			//IL_01a1: Expected Obj, but got I
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected Obj, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected Obj, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected Obj, but got Unknown
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected Obj, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			object obj5 = this - -64;
			if (obj5 == null)
			{
				State state = this.state;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj6 = default;
				object obj12 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj6 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj7 = this - -64;
					if (obj7 != null)
					{
						object obj8 = this - -64;
						if (obj8 == null)
						{
							continue;
						}
						object obj9 = this - -64;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v76+C]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S1_v58+C]");
						if (num <= 0)
						{
							continue;
						}
					}
					object obj11 = this - -64;
					obj11 = obj12;
				}
				object obj13 = obj4 + 4;
				object obj14 = obj13 + 1;
				obj13 = obj14;
				object obj15 = obj14 << 2;
				object obj16 = obj4 + obj15;
				obj16 = 97;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj17 = (nint)0 << 2;
					object obj18 = obj4 + obj17;
					if ((nint)obj18 == 97)
					{
						object obj19 = obj4 + 4;
						if ((nint)obj19 > -1)
						{
							object obj20 = obj19 + -1;
							obj19 = obj20;
						}
						goto IL_0358;
					}
				}
				object obj21 = default;
				if (obj21 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
			goto IL_0358;
			IL_0358:
			return (List<Friend>)(this - -64);
		}
	}

	public State state
	{
		get
		{
			//IL_01da: Expected I4, but got Obj
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			//IL_003f: Expected I, but got Obj
			//IL_0055: Expected Obj, but got I
			//IL_01c0: Expected Obj, but got I4
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected Obj, but got Unknown
			//IL_00df: Expected Obj, but got I4
			//IL_0080: Expected I, but got Obj
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected Obj, but got Unknown
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected Obj, but got Unknown
			if (__surpassedFriends == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
				object obj = this + 68;
				object obj2 = default;
				obj = obj2;
				nint num = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v17 (Il2CppClass<SocialManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v48 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
				Friend[] array = ((SocialManager)facebookDialogsSupported).FriendsSortedByCash();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76B9");
				int bragScoreThreshold = PlayerSave.bragScoreThreshold;
				object obj4 = array + 12;
				object obj5 = 0;
				object obj9 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					object obj6 = array + 16;
					object obj7 = obj5 << 2;
					object obj8 = obj6 + obj7;
					Friend friend = (Friend)obj8;
					if (friend.score >= (nint)obj9 && friend.score < bragScoreThreshold)
					{
						__surpassedFriends.Add(friend);
					}
					object obj10 = obj5 + 1;
					obj5 = obj10;
				}
			}
			return (State)__surpassedFriends;
		}
	}

	private void OnValidate()
	{
		((UpgradeScreen)this).Start();
	}

	private void Awake()
	{
		//IL_0628: Expected I, but got Obj
		//IL_063e: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_0298: Expected I, but got Obj
		//IL_02ae: Expected Obj, but got I
		//IL_024b: Expected I, but got Obj
		//IL_0326: Expected I, but got Obj
		//IL_033c: Expected Obj, but got I
		//IL_02d9: Expected I, but got Obj
		//IL_03b4: Expected I, but got Obj
		//IL_03ca: Expected Obj, but got I
		//IL_0367: Expected I, but got Obj
		//IL_0442: Expected I, but got Obj
		//IL_0458: Expected Obj, but got I
		//IL_03f5: Expected I, but got Obj
		//IL_04b6: Expected I, but got Obj
		//IL_04cc: Expected Obj, but got I
		//IL_0483: Expected I, but got Obj
		//IL_052a: Expected I, but got Obj
		//IL_0540: Expected Obj, but got I
		//IL_04f7: Expected I, but got Obj
		//IL_059e: Expected I, but got Obj
		//IL_05b4: Expected Obj, but got I
		//IL_056b: Expected I, but got Obj
		//IL_05df: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_noFriendsStateGo == null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v109 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_gcFriendsStateGo == null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v105 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (_allFriendsStateGo == null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v101 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (_newHighScoreTopTitle == null)
					{
						nint num9 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num10 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v97 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (_highScoreLabel == null)
						{
							nint num11 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num12 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v93 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (_justBeatLabel == null)
							{
								nint num13 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
								object obj7 = (nint)0 & (nint)0x200;
								if (obj7 != null)
								{
									nint num14 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v89 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (_firstBeatenFriendLabel == null)
								{
									nint num15 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
									object obj8 = (nint)0 & (nint)0x200;
									if (obj8 != null)
									{
										nint num16 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v85 (Il2CppClass<UnityEngine.Object>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									if (_beatenFriendsLeftLabel == null)
									{
										nint num17 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v50 (Il2CppClass<UnityEngine.Object>)+BA]");
										object obj9 = (nint)0 & (nint)0x200;
										if (obj9 != null)
										{
											nint num18 = (nint)typeof(UnityEngine.Object);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v82 (Il2CppClass<UnityEngine.Object>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										if (_bragButtonTitle == null)
										{
											nint num19 = (nint)typeof(UnityEngine.Object);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+BA]");
											object obj10 = (nint)0 & (nint)0x200;
											if (obj10 != null)
											{
												nint num20 = (nint)typeof(UnityEngine.Object);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											if (_competeWithFriendsButtonTitle == null)
											{
												nint num21 = (nint)typeof(UnityEngine.Object);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
												object obj11 = (nint)0 & (nint)0x200;
												if (obj11 != null)
												{
													nint num22 = (nint)typeof(UnityEngine.Object);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v76 (Il2CppClass<UnityEngine.Object>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												if (_friendPictureTexture == null)
												{
													nint num23 = (nint)typeof(UnityEngine.Object);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v68 (Il2CppClass<UnityEngine.Object>)+BA]");
													object obj12 = (nint)0 & (nint)0x200;
													if (obj12 != null)
													{
														nint num24 = (nint)typeof(UnityEngine.Object);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v73 (Il2CppClass<UnityEngine.Object>)+74]");
														if ((nint)0 == 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
														}
													}
													if (!(_bragGo != null))
													{
														return;
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
		SDebug.LogFormat("Set all variables in editor from BragCelebrationHandler prefab", (object[])(object)this);
	}

	private void Setup()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_013a: Expected I4, but got Obj
		//IL_00a2: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v25 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("BRAG_CELEBRATION_COMPETE_WITH_FRIENDS_BUTTON");
		_competeWithFriendsButtonTitle.fontSize = (int)text;
		string text2 = Strings.GetDefault("BRAG_CELEBRATION_BRAG_BUTTON");
		_bragButtonTitle.fontSize = (int)text2;
		_friendPicture.tag = null;
		_noFriendsStateGo.tag = null;
		_gcFriendsStateGo.tag = null;
		_allFriendsStateGo.tag = null;
		CollectCoinsScreenManager.CollectCoinsScreenState screenState = ((CollectCoinsScreenManager)(object)this).screenState;
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)screenState);
	}

	private IEnumerator UpdateUI()
	{
		//IL_003c: Expected Obj, but got I4
		if (_socialState == State.NotCalculated)
		{
			BragBtnClicked();
		}
		return (IEnumerator)_socialState;
	}

	private void CalculateState()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_00a1: Expected I4, but got Obj
		//IL_00b7: Expected I4, but got Obj
		//IL_00c8: Expected I4, but got Obj
		_friendPicture.tag = (string)1;
		IEnumerator enumerator = UpdateUI();
		object obj = enumerator - 1;
		if ((nint)enumerator != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					((CollectCoinsScreenManager)(object)this).screenState = (CollectCoinsScreenManager.CollectCoinsScreenState)_allFriendsStateGo;
				}
			}
			else
			{
				((CollectCoinsScreenManager)(object)this).screenState = (CollectCoinsScreenManager.CollectCoinsScreenState)_gcFriendsStateGo;
			}
		}
		else
		{
			_friendPicture.tag = null;
			((CollectCoinsScreenManager)(object)this).screenState = (CollectCoinsScreenManager.CollectCoinsScreenState)_noFriendsStateGo;
		}
	}

	private void SetStateGameObjectActive(GameObject go)
	{
		//IL_0014: Expected Obj, but got I
		//IL_002f: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I
		//IL_0047: Expected I4, but got Obj
		//IL_0075: Expected Obj, but got I4
		if ((object)go != null)
		{
			bool flag = ((MysteryBoxDoubleUpButton)null).IsDoublable((CelebrationReward)(nint)((UnityEngine.Object)go).m_CachedPtr);
			string text = string.Format((IFormatProvider)(object)"[c][004A80FF]{0}\n[0374A5FF]{1}", (string)(nint)((UnityEngine.Object)go).m_CachedPtr, flag);
			((UILabel)(object)_noFriendsStateGo).fontSize = (int)text;
			OfferWallManager instance = OfferWallManager.instance;
			bool flag2 = ((AdSystemManager)(object)instance).IsCaching((string)(object)go);
			_gcFriendsStateGo.tag = (string)flag2;
		}
	}

	private unsafe void AnimateUIGameObjectAlpha(GameObject go, float duration, float toAlpha)
	{
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01ca: Expected Obj, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_0204: Expected Obj, but got I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0221: Expected Obj, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected VT, but got Unknown
		//IL_003f: Expected F4, but got Obj
		//IL_003a: Expected native int or pointer, but got VT
		//IL_0054: Expected F4, but got I
		//IL_004f: Expected native int or pointer, but got VT
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected VT, but got Unknown
		//IL_006f: Expected F4, but got Obj
		//IL_006a: Expected native int or pointer, but got VT
		//IL_0084: Expected F4, but got I
		//IL_007f: Expected native int or pointer, but got VT
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00e7: Expected I, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_02a8: Expected F4, but got Obj
		//IL_02a3: Expected native int or pointer, but got VT
		//IL_02bd: Expected F4, but got I
		//IL_02b8: Expected native int or pointer, but got VT
		//IL_02ca: Expected F4, but got Obj
		//IL_02c5: Expected native int or pointer, but got VT
		//IL_02df: Expected F4, but got I
		//IL_02da: Expected native int or pointer, but got VT
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_033f: Expected Obj, but got I4
		//IL_034e: Expected Obj, but got F4
		//IL_0367: Expected F4, but got Obj
		//IL_0362: Expected native int or pointer, but got VT
		//IL_037c: Expected F4, but got I
		//IL_0377: Expected native int or pointer, but got VT
		//IL_0389: Expected F4, but got Obj
		//IL_0384: Expected native int or pointer, but got VT
		//IL_039e: Expected F4, but got I
		//IL_0399: Expected native int or pointer, but got VT
		//IL_0128: Expected I, but got Obj
		//IL_0174: Expected F4, but got Obj
		//IL_016f: Expected native int or pointer, but got VT
		//IL_0189: Expected F4, but got I
		//IL_0184: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 124;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 112;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 96;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 84;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 72;
		string debugText = ((CurveParent)(object)go).GetDebugText();
		float t = duration - toAlpha;
		Vector3 vector = ((Curve)(object)debugText).EvaluateDerivative(t);
		obj = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		_ = 0;
		object obj7 = obj2 + 60;
		Vector3 vector2 = ((Curve)(object)debugText).EvaluateDerivative(duration);
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v25+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		Vector3 vector3 = (Vector3)(obj2 + 136);
		((Vector3*)(nint)vector3)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = (Vector3)(obj2 + 148);
		((Vector3*)(nint)vector4)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F956");
		object obj8 = obj2 + 48;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj9 = obj2 + 36;
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v76 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector3)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v37+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector4)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v40+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		object obj11 = obj2 + 24;
		Quaternion quaternion = Quaternion.FromToRotation(vector3, vector4);
		obj5 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v52+8]");
		_ = 0;
		object obj12 = obj2 + 12;
		obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v52+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 0f;
		_ = 0f;
		_ = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v56+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector4)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		if ((Quaternion)vector3 == (Quaternion)vector4)
		{
			((Vector3*)(nint)vector4)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F94A");
		}
		BragCelebrationHandler bragCelebrationHandler = (BragCelebrationHandler)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
	}

	private unsafe IEnumerator AnimateWidgetAlpha(UIWidget label, float duration, float toAlpha)
	{
		//IL_0017: Expected VT, but got Obj
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected VT, but got Unknown
		//IL_0037: Expected F4, but got Obj
		//IL_0032: Expected native int or pointer, but got VT
		//IL_0049: Expected F4, but got I
		//IL_0044: Expected native int or pointer, but got VT
		//IL_007a: Expected Obj, but got I
		GameObject gameObject = base.gameObject;
		Transform transform = default;
		transform.position = (Vector3)gameObject;
		Vector3 vector = (Vector3)(transform + 12);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		return ((Sound)(object)this).playAudioClip((AudioClip)(nint)((UnityEngine.Object)label).m_CachedPtr, (AudioRolloffMode)label.updateAnchors, duration, duration, toAlpha, toAlpha, vector, false);
	}

	private void OnLargePictureDownloaded(Friend friend, Texture2D picture)
	{
		//IL_001c: Expected Obj, but got I
		GameObject allFriendsStateGo = _allFriendsStateGo;
		if ((string)(nint)((UnityEngine.Object)allFriendsStateGo).m_CachedPtr != (string)(object)friend)
		{
			SetStateGameObjectActive(_allFriendsStateGo);
		}
	}

	private void BragBtnClicked()
	{
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_017f: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			List<Friend> surpassedFriends = _surpassedFriends;
			State socialState = ((surpassedFriends == null) ? State.BeatenOnlySelf : State.BeatenFriendsOnlineAll);
			_socialState = socialState;
		}
		else if (((SocialManager)facebookDialogsSupported).gamecenterIsLoggedOut)
		{
			List<Friend> surpassedFriends2 = _surpassedFriends;
			State socialState2 = ((surpassedFriends2 == null) ? State.BeatenOnlySelf : State.BeatenFriendsOnlyGcOnline);
			_socialState = socialState2;
		}
		else
		{
			_socialState = State.BeatenOnlySelf;
		}
	}

	private void LoginToFacebookBtnClicked()
	{
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0115: Expected Obj, but got I4
		//IL_0115: Expected Obj, but got I4
		//IL_008e: Expected I, but got Obj
		if (this.state == State.NotCalculated)
		{
			return;
		}
		State state = this.state;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (BragCelebrationHandler+State)+C]");
		if ((nint)0 <= (nint)0)
		{
			return;
		}
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v13 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		State state2 = this.state;
		((SocialManager)facebookDialogsSupported).CollectFriendReward((Friend)state2);
	}

	public BragCelebrationHandler()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		bool flag = SocialManager.IsOAuthException((FacebookError)facebookDialogsSupported, null);
	}
}
