using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Kiloo;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using Missions;
using SYBO.Subway;
using SYBO.Subway.Info;
using SYBO.Subway.Inputs;
using UI.Breadcrumbs;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UI.Pages.MissionsPageInternal;
using UI.Screens.CharacterScreenInternal;
using UI.Screens.PauseScreenInternal;
using UnityEngine;
using WordHunt;

namespace UI.Screens;

public class PauseScreen : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<MissionInfo, bool> _003C_003E9__56_0;

		public static Action<MissionCell> _003C_003E9__74_0;

		public static Action<MissionCell> _003C_003E9__75_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			FrontScreen._003C_003Ec obj = default;
			FrontScreen._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_00c1: Expected Obj, but got I
			//IL_00d3: Expected Obj, but got I
			//IL_00f9: Expected Obj, but got I
			//IL_0110: Expected Obj, but got I
			//IL_0022: Expected Obj, but got I
			//IL_0022: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I4
			//IL_003b: Expected Obj, but got I
			//IL_0054: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I
			//IL_007a: Expected Obj, but got I
			//IL_008a: Expected Obj, but got I
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected Obj, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PauseScreen+<>c)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+64]");
			((CoinEarnerLoadingOffer)0).Init(null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PauseScreen+<>c)+8]");
			InventorySave.IncreaseKeys(0, "DoubleCoinsVideo");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PauseScreen+<>c)+C]");
			object obj2 = 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PauseScreen+<>c)+C]");
			((GameOverScreen)0)._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PauseScreen+<>c)+C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PauseScreen+<>c)+8]");
			GameOverScreen.ActiveTabState activeTabState = ((GameOverScreen)num).GetActiveTabState((Action)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PauseScreen+<>c)+C]");
			Coroutine coroutine = ((MonoBehaviour)0).StartCoroutine_Auto((IEnumerator)activeTabState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PauseScreen+<>c)+C]");
			object obj3 = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S4_v2 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S4_v3+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S4_v4+48]");
			object obj6 = (object)((object)0 & 0x7FF) + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57 @ S5_v4 (should have been resolved before IL gen)");
		}

		internal bool _003CShow_003Eb__56_0(MissionInfo m)
		{
			//IL_0020: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			object obj = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			if ((nint)0 != 1)
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj == 2)
					{
						return true;
					}
					if ((nint)obj == 3)
					{
						return true;
					}
				}
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+8]");
			return false;
		}

		internal void _003CResetCellPositions_003Eb__74_0(MissionCell c)
		{
		}

		internal void _003CDestroyOtherMissionCells_003Eb__75_0(MissionCell cell)
		{
			Transform component = cell.GetComponent<Transform>();
			TransformExtensions.SetLocalPosY(component, 0f);
		}
	}

	private sealed class _003CMissionCompleteAnimation_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int completedMissionsCount;

		public PauseScreen _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e1: Expected Obj, but got Unknown
				//IL_00fd: Expected Obj, but got I4
				//IL_0157: Unknown result type (might be due to invalid IL or missing references)
				//IL_015c: Expected Obj, but got Unknown
				//IL_0178: Expected Obj, but got I4
				//IL_01da: Unknown result type (might be due to invalid IL or missing references)
				//IL_01df: Expected Obj, but got Unknown
				//IL_01fb: Expected Obj, but got I4
				//IL_02ae: Expected Obj, but got I4
				PauseScreen pauseScreen = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								pauseScreen.CreateNewMissionCells();
								pauseScreen.ResetCellPositions();
								pauseScreen.AnimateNewMissionSet();
								pauseScreen._missionSetProgress.BounceNextProgressDot();
								StayInOneLaneMission instance = StayInOneLaneMission.instance;
								int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
								StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
								int missionSetCount = ((MissionsManager)(object)instance2).missionSetCount;
								if (currentSkipForVideoMissionIndex >= missionSetCount)
								{
									pauseScreen._missionSetProgress.TestBounce((UISprite)1);
								}
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						pauseScreen.HomeButtonClicked();
						float num = pauseScreen._cellAnimationDelay * 2f;
						float num2 = num + pauseScreen._cellAnimationDuration;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = -1f;
						object obj = this + 12;
						object obj2 = default;
						obj = obj2;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					pauseScreen._missionSetProgress.TestBounce1();
					MissionSetProgress missionSetProgress = pauseScreen._missionSetProgress;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = -1f;
					_ = missionSetProgress._bounceEffectDuration;
					object obj3 = this + 12;
					object obj4 = default;
					obj3 = obj4;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				bool flag = completedMissionsCount == 0;
				pauseScreen._missionSetProgress.ChangeToMysteryBoxReward();
				if (flag)
				{
					MissionSetProgress missionSetProgress2 = pauseScreen._missionSetProgress;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = -1f;
					_ = missionSetProgress2._bounceEffectDuration;
					object obj5 = this + 12;
					object obj6 = default;
					obj5 = obj6;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CMissionCompleteAnimation_003Ed__78(int _003C_003E1__state)
		{
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0146: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_005b: Expected Obj, but got I4
			//IL_006d: Expected I, but got Obj
			//IL_0083: Expected Obj, but got I
			//IL_00ae: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_003C_003E1__state))
			{
				return;
			}
			string tag = ((Component)_003C_003E1__state).tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
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

	private sealed class _003CAnimateCell_003Ed__80(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PauseScreen _003C_003E4__this;

		public Transform cellTransform;

		public float startX;

		public float endX;

		public Action onComplete;

		private float _003CcurrentDuration_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0204: Expected I, but got Obj
				//IL_021a: Expected Obj, but got I
				//IL_027f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0284: Expected Obj, but got Unknown
				//IL_028d: Expected Obj, but got I4
				//IL_02a1: Expected Obj, but got I4
				//IL_0189: Expected I, but got Obj
				PauseScreen pauseScreen = _003C_003E4__this;
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
					_003CcurrentDuration_003E5__2 = 0f;
				}
				if (!(_003CcurrentDuration_003E5__2 < pauseScreen._cellAnimationDuration))
				{
					TransformExtensions.SetLocalPosY(cellTransform, endX);
					TransformExtensions.Reset((Transform)(object)onComplete);
					return null;
				}
				float fixedDeltaTime = Time.fixedDeltaTime;
				float num = _003CcurrentDuration_003E5__2 + fixedDeltaTime;
				_003CcurrentDuration_003E5__2 = num;
				float num2 = _003CcurrentDuration_003E5__2 / pauseScreen._cellAnimationDuration;
				float num3 = Easings.BounceEaseInOut(num2);
				bool flag = num2 > 372f / 1023f;
				bool flag2 = !flag;
				float num4 = num3;
				if (!flag2)
				{
					float num5 = num3 - 1f;
					float num6 = num5 * 0.125f;
					float num7 = num6 + 1f;
					num4 = num7;
				}
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num9 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num10 = endX - startX;
				float num11 = num10 * num4;
				float posY = startX + num11;
				TransformExtensions.SetLocalPosY(cellTransform, posY);
				object obj2 = this + 12;
				obj2 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_005e: Expected Obj, but got F4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			//IL_002b: Expected Obj, but got I4
			//IL_0044: Expected Obj, but got I4
			MissionCell missionCell = ((List<MissionCell>)startX).get_Item(2);
			GameObject gameObject = missionCell.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj2 = default;
			object obj = obj2 + 16;
			obj = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12166");
			IEnumerator routine = default;
			Coroutine coroutine = ((MonoBehaviour)_003C_003E1__state).StartCoroutine_Auto(routine);
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

	private UIWidget _guideWidget;

	private GameObject _dailyChallenge;

	private UILabel _dailyChallengeMainTitle;

	private UILabel _dailyChallengeSubTitle;

	private UIWidget _slotForDailyChallengeItemLoad;

	private DailyChallengeRewardHelper _dailyChallengeRewardHelper;

	private TimerHelper _timerPrefab;

	private TimerHelper _timer;

	private GameObject _topRun;

	private UILabel _topRunMainTitle;

	private UILabel _topRunSubTitle;

	private UILabel _topRunWeekLabel;

	private UILabel _topRunDaysLeftLabel;

	private UISprite _countryFlag;

	private Layout _topRunLayot;

	private bool _topRunReady;

	private GameObject _topRunMedalGuideSprite;

	private GameObject _diamondMedalPrefab;

	private GameObject _goldMedalPrefab;

	private GameObject _silverMedalPrefab;

	private GameObject _bronzeMedalPrefab;

	private readonly GameObject[] _topRunMedals;

	private const float MODEL_SCALE = 0.75f;

	private static readonly Vector3 DIAMOND_POSITION;

	private static readonly Vector3 DIAMOND_ROTATION;

	private static readonly Vector3 DIAMOND_SCALE;

	private static readonly Vector3 GOLD_POSITION;

	private static readonly Vector3 GOLD_ROTATION;

	private static readonly Vector3 GOLD_SCALE;

	private static readonly Vector3 SILVER_POSITION;

	private static readonly Vector3 SILVER_ROTATION;

	private static readonly Vector3 SILVER_SCALE;

	private static readonly Vector3 BRONZE_POSITION;

	private static readonly Vector3 BRONZE_ROTATION;

	private static readonly Vector3 BRONZE_SCALE;

	private UILabel _missionsMainTitle;

	private UILabel _missionSubTitle;

	private UIWidget _slotForMissionItemLoad;

	private GameObject _missionCellPrefab;

	private MissionSetProgress _missionSetProgressPrefab;

	private MissionSetProgress _missionSetProgress;

	private Layout[] _missionCellLayouts;

	private int _missionCellHeight;

	private float _cellAnimationDuration;

	private float _cellAnimationDelay;

	private int _currentSet;

	private const int MAX_MULTIPLIER = 30;

	private UIWidget _footerGuide;

	private ResumeButtonHelper _resumeButtonHelper;

	private UILabel _homeButtonLabel;

	private UILabel _settingsButtonLabel;

	private UILabel _resumeButtonLabel;

	public static bool pauseScreenIsShown;

	private const int NUMBER_OF_MISSIONS_IN_SET = 3;

	private MissionInfo[][] _missionInfos;

	private List<MissionCell>[] _missionCells;

	private int GetCurrentSetIndex()
	{
		((LeaderboardScreenManager)(object)this)._002Ector();
		return showOldFooterSection ? 1 : 0;
	}

	private int GetOtherSetIndex()
	{
		//IL_001e: Expected Obj, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		int num = _currentSet / 2;
		object obj = num * 2;
		return _currentSet - obj;
	}

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public unsafe override void Show()
	{
		//IL_0508: Expected I, but got Obj
		//IL_051e: Expected Obj, but got I
		//IL_0558: Expected I4, but got Obj
		//IL_006e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0090: Expected I4, but got Obj
		//IL_00b2: Expected I4, but got Obj
		//IL_00d4: Expected I4, but got Obj
		//IL_00f6: Expected I4, but got Obj
		//IL_0118: Expected I4, but got Obj
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_058a: Expected I, but got Obj
		//IL_05a0: Expected Obj, but got I
		//IL_05ce: Expected Obj, but got VT
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected I4, but got Unknown
		//IL_05e9: Expected I4, but got Obj
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_0186: Expected I, but got Obj
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_01d3: Expected I, but got Obj
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected Obj, but got Unknown
		//IL_0637: Expected Obj, but got I4
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected I4, but got Unknown
		//IL_0667: Expected I4, but got Obj
		//IL_0681: Expected I4, but got Obj
		//IL_06ad: Expected Obj, but got I4
		//IL_02bb: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I
		//IL_0261: Expected I, but got Obj
		//IL_06e3: Expected Obj, but got I4
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected Obj, but got Unknown
		//IL_0708: Expected I, but got Obj
		//IL_071e: Expected Obj, but got I
		//IL_02fc: Expected I, but got Obj
		//IL_044a: Expected I, but got Obj
		//IL_0460: Expected Obj, but got I
		//IL_0349: Expected I, but got Obj
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected Obj, but got Unknown
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected Obj, but got Unknown
		//IL_0802: Expected Obj, but got I4
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected Obj, but got Unknown
		//IL_03ad: Expected I, but got Obj
		//IL_03c3: Expected Obj, but got I
		//IL_04d4: Expected I4, but got Obj
		//IL_04e2: Expected I4, but got Obj
		//IL_048b: Expected I, but got Obj
		//IL_03ee: Expected I, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v116 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("DAILY_CHALLENGE_WORD_HUNT");
		_dailyChallengeMainTitle.fontSize = (int)text;
		string text2 = Strings.GetDefault("DAILY_CHALLENGE_COLLECT");
		string text3 = text2.ToUpperInvariant();
		_dailyChallengeSubTitle.fontSize = (int)text3;
		string text4 = Strings.GetDefault("MISSIONS_TITLE");
		_missionsMainTitle.fontSize = (int)text4;
		string text5 = Strings.GetDefault("FOOTER_HOME_BUTTON_TITLE");
		_homeButtonLabel.fontSize = (int)text5;
		string text6 = Strings.GetDefault("SETTINGS_TITLE");
		_settingsButtonLabel.fontSize = (int)text6;
		string text7 = Strings.GetDefault("PAUSE_UI_RESUME");
		_resumeButtonLabel.fontSize = (int)text7;
		string text8 = Strings.GetDefault("TOPRUN_TITLE");
		_topRunMainTitle.fontSize = (int)text8;
		object original = this - -64;
		GameObject parent = _slotForDailyChallengeItemLoad.gameObject;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S2_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimerHelper timerHelper = UnityEngine.Object.Instantiate((TimerHelper)original, (Transform)(object)parent);
		nint num5 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v28 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v107 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimeSpan wordHuntTimeLeft = EventsSave.wordHuntTimeLeft;
		object obj4 = wordHuntTimeLeft;
		HorizontalAlignment horizontalAlignment = (HorizontalAlignment)(obj4 + 8);
		((HorizontalAlignment*)(int)horizontalAlignment)->value__ = (int)obj4;
		timerHelper.SetAlignment(horizontalAlignment);
		object obj5 = obj4 + 40;
		Color black = Color.black;
		nint num7 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v39 (Il2CppClass<UI.ColorData>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v103 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj4 + 24;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj8 = (flag ? 1 : 0) + 204;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v48+8]");
		_ = 0;
		bool flag2 = (byte)(obj4 + 56) != 0;
		((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj5 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v37+8]");
		_ = 0;
		((HorizontalAlignment*)(int)horizontalAlignment)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v44+8]");
		_ = 0;
		timerHelper.AnimateClock(flag2, (byte)horizontalAlignment != 0);
		timerHelper.SetTimerText((string)2);
		GameObject gameObject = timerHelper.gameObject;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v65 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v112 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		((HorizontalAlignment*)(int)horizontalAlignment)->value__ = (((bool*)(flag2 ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v47 (System.Boolean)+8]");
		_ = 0;
		Vector3 eulerAngles = ((Transform)horizontalAlignment).eulerAngles;
		object obj10 = this + 68;
		obj10 = timerHelper;
		nint num11 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v58 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v99 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			UIWidget guideWidget = _guideWidget;
			UIRect.AnchorPoint topAnchor = guideWidget.topAnchor;
			nint num13 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v95 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num14 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v106 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int absolute = -IPhoneXSupport.OFFSET_TOP;
			topAnchor.absolute = absolute;
			UIWidget guideWidget2 = _guideWidget;
			UIRect.AnchorPoint bottomAnchor = guideWidget2.bottomAnchor;
			bottomAnchor.absolute = IPhoneXSupport.OFFSET_BOTTOM;
			((UIRect)_guideWidget).ParentHasChanged();
		}
		GameObject parent2 = _slotForMissionItemLoad.gameObject;
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v87 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj14 = this + 148;
		MissionSetProgress missionSetProgress = UnityEngine.Object.Instantiate(_missionSetProgressPrefab, (Transform)(object)parent2);
		obj14 = missionSetProgress;
		object obj15 = _missionCellLayouts + 16;
		int num17 = _currentSet / 2;
		object obj16 = num17 * 2;
		object obj17 = _currentSet - obj16;
		object obj18 = obj17 << 2;
		object obj19 = obj15 + obj18;
		UIWidget component = ((Component)obj19).GetComponent<UIWidget>();
		((UIRect)component).ParentHasChanged();
		IEnumerator enumerator = MissionCompleteAnimation((int)component);
		_missionCellHeight = (int)enumerator;
		CreateNewMissionCells();
		RefreshCurrentCells();
	}

	public override void Hide()
	{
		//IL_0529: Expected I, but got Obj
		//IL_053f: Expected Obj, but got I
		//IL_0573: Expected I, but got Obj
		//IL_0589: Expected Obj, but got I
		//IL_05b0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_05e8: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0211: Expected Obj, but got I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0249: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_074b: Expected Obj, but got I4
		//IL_028a: Expected I, but got Obj
		//IL_02d7: Expected I, but got Obj
		//IL_02ed: Expected Obj, but got I
		//IL_03aa: Expected I, but got Obj
		//IL_03c0: Expected Obj, but got I
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_0672: Expected I, but got Obj
		//IL_0688: Expected Obj, but got I
		//IL_0318: Expected I, but got Obj
		//IL_0448: Expected I, but got Obj
		//IL_045e: Expected Obj, but got I
		//IL_03eb: Expected I, but got Obj
		//IL_06e4: Expected Obj, but got I4
		//IL_06f2: Expected I, but got Obj
		//IL_0708: Expected Obj, but got I
		//IL_0489: Expected I, but got Obj
		//IL_04d6: Expected I, but got Obj
		base.Hide();
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v84 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)isInstantiated).FindKernel(null) != 0)
		{
			nint num5 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v74 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v80 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated2 = Game.IsInstantiated;
			((Game)isInstantiated2).HandleProductionInput(InputType.SwipeUp);
		}
		nint num7 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v16 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v69 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WordHuntManager._002Ecctor();
		RefreshTopRun();
		RefreshDailyChallenge();
		CreateNewMissionCells();
		ResetCellPositions();
		DestroyOtherMissionCells();
		RefreshMissionSubtitle();
		AnimateNewMissionSet();
		object obj5 = _missionInfos + 16;
		int num9 = _currentSet / 2;
		object obj6 = num9 * 2;
		object obj7 = _currentSet - obj6;
		object obj8 = obj7 << 2;
		object source = obj5 + obj8;
		nint num10 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v10 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num11 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S2_v52 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__56_0 == null;
		bool flag2 = !flag;
		Func<MissionInfo, bool> predicate = _003C_003Ec._003C_003E9__56_0;
		if (!flag2)
		{
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v26 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num13 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S2_v46 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num14 = 0;
			_ = 0;
			Func<MissionInfo, bool> func = default;
			object obj11 = func + 16;
			obj11 = _003C_003Ec._003C_003E9;
			nint num15 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S2_v43 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+5C]");
			object obj12 = (nint)0 + (nint)4;
			obj12 = func;
			predicate = func;
		}
		int num16 = Enumerable.Count((IEnumerable<MissionInfo>)source, predicate);
		_missionSetProgress.BounceNextProgressDot((Action)num16);
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		if (currentSkipForVideoMissionIndex >= 30)
		{
			_missionSetProgress.TestBounce((UISprite)null);
		}
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_resumeButtonHelper).FindKernel((string)null) != 0)
		{
			_resumeButtonHelper.DisableButton();
		}
		nint num19 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v41 (Il2CppClass<UI.Screens.PauseScreen>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num20 = (nint)typeof(PauseScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v59 (Il2CppClass<UI.Screens.PauseScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		pauseScreenIsShown = true;
		((Breadcrumb)null)._002Ector();
		((Breadcrumb)2)._002Ector();
		nint num21 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v50 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num22 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v55 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
	}

	private void SelectTopSection()
	{
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		base.LoseFocus();
		nint num = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UI.Screens.PauseScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PauseScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v16 (Il2CppClass<UI.Screens.PauseScreen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		pauseScreenIsShown = false;
		RefreshMissionInfos();
		_timer.HideIcon();
	}

	private void RefreshDailyChallenge()
	{
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I4
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text;
		if (WordHuntManager.IsActiveDailyLetterEvent())
		{
			bool topRunReady = _topRunReady;
			text = (string)((topRunReady ? 1 : 0) ^ 1);
		}
		else
		{
			text = (string)1;
		}
		_dailyChallenge.tag = text;
		string text2 = (string)(text ^ 1);
		_topRun.tag = text2;
		if (text != null)
		{
			RefreshMissionInfos();
		}
		else
		{
			Destroy3DMedals();
		}
	}

	private void RefreshTopRun()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_00af: Expected Obj, but got VT
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		_dailyChallengeRewardHelper._002Ector();
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v13 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime wordHuntExpireDeviceTime = EventsSave.wordHuntExpireDeviceTime;
		object obj2 = wordHuntExpireDeviceTime;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		throw new ArrayTypeMismatchException();
	}

	private unsafe static string FormatTopRunTimeLeft(TimeSpan ts)
	{
		//IL_004f: Invalid comparison between VT and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0018: Expected native int or pointer, but got VT
		if (ts > (object)255)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.ParamsArray paramsArray = default;
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)paramsArray, new System.ParamsArray("Value was either too large or too small for an unsigned byte."));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return null;
		}
		return (string)(ts & 0xFF);
	}

	private unsafe void Add3DModels()
	{
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected VT, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I
		//IL_042b: Expected I4, but got Obj
		//IL_0221: Expected I, but got Obj
		//IL_005c: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got VT
		//IL_02dd: Expected I8, but got Obj
		//IL_02d8: Expected native int or pointer, but got VT
		//IL_02f2: Expected Ref, but got VT
		//IL_0304: Expected I, but got Obj
		//IL_031a: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I8
		//IL_0371: Expected I, but got Obj
		//IL_0387: Expected Obj, but got I
		//IL_009d: Expected I, but got Obj
		//IL_00ea: Expected I, but got Obj
		//IL_0196: Expected I4, but got Obj
		//IL_0137: Expected I, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 32);
		DateTime dateTime = (DateTime)(obj + 24);
		object obj2 = obj + 16;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj4 = default;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj5 = default;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
				DateTime today = CDateTime.Today;
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v42 (Il2CppClass<System.DateTime>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v57 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj7 = default;
				obj2 = obj7;
				obj3 = today;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
				formatProvider = (IFormatProvider)obj3;
				long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
				nint num4 = (nint)typeof(PauseScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v33 (Il2CppClass<UI.Screens.PauseScreen>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num5 = (nint)typeof(PauseScreen);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v55 (Il2CppClass<UI.Screens.PauseScreen>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj = num3;
				formatProvider = (IFormatProvider)obj;
				bool fontSize = ((PauseScreen)formatProvider).IsWaiting();
				_topRunDaysLeftLabel.fontSize = (fontSize ? 1 : 0);
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v42 (Il2CppClass<Strings>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num7 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v51 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string format = Strings.GetDefault("TOPRUN_WEEK_TITLE");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj10 = default;
				formatProvider = (IFormatProvider)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args = default;
				string text = string.Format(format, args);
				_topRunWeekLabel.fontSize = (int)text;
				_topRunReady = true;
				goto IL_03d3;
			}
		}
		_topRunReady = false;
		goto IL_03d3;
		IL_03d3:
		((RewardForVideoButton)(object)_topRunLayot).Init((VideoButtonPayload)null);
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		IEnumerator enumerator = ((CountryPopup)(object)instance).DelayedSelect();
		UISprite countryFlag = _countryFlag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v24 (System.Collections.IEnumerator)+C]");
		countryFlag.fillCenter = false;
		nint num8 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v5 (Il2CppClass<Strings>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S2_v12 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v24 (System.Collections.IEnumerator)+8]");
		string text2 = Strings.GetDefault((string)0);
		string text3 = text2.ToUpperInvariant();
		_topRunSubTitle.fontSize = (int)text3;
	}

	private unsafe void Add3DModel(int index, GameObject prefab, Vector3 position, Vector3 rotation, Vector3 scale)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected I4, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected I4, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected I4, but got Unknown
		//IL_00e7: Invalid comparison between VT and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardCell leaderboardCell = default;
		leaderboardCell.cellType = LeaderboardCellType.Player;
		leaderboardCell.rank = ((int*)index)->m_value;
		object obj = prefab & 1;
		bool useDarkColour = obj == null;
		leaderboardCell.useDarkColour = useDarkColour;
		bool isPlayerRanked = (byte)(position & 1) != 0;
		leaderboardCell.isPlayerRanked = isPlayerRanked;
		bool lockList = (byte)(rotation & 1) != 0;
		leaderboardCell.lockList = lockList;
		bool adjustOverlay = (byte)(scale & 1) != 0;
		leaderboardCell.adjustOverlay = adjustOverlay;
		((List<LeaderboardCell>)(object)_countryFlag).Add(leaderboardCell);
		if (position != (Vector3)(object)0)
		{
			int value = ((int*)index)->m_value + 1;
			((int*)index)->m_value = value;
		}
		object obj2 = prefab + 1;
		GameObject gameObject = (GameObject)obj2;
	}

	private unsafe void MedalIconPositioning(GameObject medalGameObject, Vector3 positionOffset, Vector3 rotation, Vector3 scale)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0074: Expected I4, but got F4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		//IL_00bb: Expected native int or pointer, but got VT
		//IL_00dd: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LeaderboardCell leaderboardCell = default;
		leaderboardCell.cellType = LeaderboardCellType.Friend;
		object obj = leaderboardCell + 12;
		obj = medalGameObject;
		object obj2 = rotation.x & 1;
		bool useDarkColour = obj2 == null;
		leaderboardCell.useDarkColour = useDarkColour;
		leaderboardCell.rank = (int)positionOffset.x;
		bool lockList = (byte)(scale & 1) != 0;
		leaderboardCell.lockList = lockList;
		((List<LeaderboardCell>)(object)_countryFlag).Add(leaderboardCell);
		float x = positionOffset.x + 1f;
		((Vector3*)(nint)positionOffset)->x = x;
		float x2 = rotation.x + 1f;
		((Vector3*)(nint)rotation)->x = x2;
	}

	private unsafe void Destroy3DMedals()
	{
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_0212: Expected I, but got Obj
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0247: Expected Obj, but got VT
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_0270: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		//IL_02b7: Expected I, but got Obj
		//IL_02cd: Expected Obj, but got I
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected VT, but got Unknown
		//IL_02fd: Expected F4, but got Obj
		//IL_02f8: Expected native int or pointer, but got VT
		//IL_0312: Expected F4, but got I
		//IL_030d: Expected native int or pointer, but got VT
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected VT, but got Unknown
		//IL_032d: Expected F4, but got Obj
		//IL_0328: Expected native int or pointer, but got VT
		//IL_0342: Expected F4, but got I
		//IL_033d: Expected native int or pointer, but got VT
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected VT, but got Unknown
		//IL_035d: Expected F4, but got Obj
		//IL_0358: Expected native int or pointer, but got VT
		//IL_0372: Expected F4, but got I
		//IL_036d: Expected native int or pointer, but got VT
		//IL_038b: Expected VT, but got Obj
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_03a7: Expected I, but got Obj
		//IL_03bd: Expected Obj, but got I
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_03ee: Expected I, but got Obj
		//IL_0404: Expected Obj, but got I
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0435: Expected I, but got Obj
		//IL_044b: Expected Obj, but got I
		//IL_046d: Expected F4, but got Obj
		//IL_0468: Expected native int or pointer, but got VT
		//IL_0482: Expected F4, but got I
		//IL_047d: Expected native int or pointer, but got VT
		//IL_048f: Expected F4, but got Obj
		//IL_048a: Expected native int or pointer, but got VT
		//IL_04a4: Expected F4, but got I
		//IL_049f: Expected native int or pointer, but got VT
		//IL_04b1: Expected F4, but got Obj
		//IL_04ac: Expected native int or pointer, but got VT
		//IL_04c6: Expected F4, but got I
		//IL_04c1: Expected native int or pointer, but got VT
		//IL_04e3: Expected VT, but got Obj
		//IL_04e3: Expected Obj, but got I4
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_04ff: Expected I, but got Obj
		//IL_0515: Expected Obj, but got I
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected Obj, but got Unknown
		//IL_0546: Expected I, but got Obj
		//IL_055c: Expected Obj, but got I
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_058d: Expected I, but got Obj
		//IL_05a3: Expected Obj, but got I
		//IL_05c5: Expected F4, but got Obj
		//IL_05c0: Expected native int or pointer, but got VT
		//IL_05da: Expected F4, but got I
		//IL_05d5: Expected native int or pointer, but got VT
		//IL_05e7: Expected F4, but got Obj
		//IL_05e2: Expected native int or pointer, but got VT
		//IL_05fc: Expected F4, but got I
		//IL_05f7: Expected native int or pointer, but got VT
		//IL_0609: Expected F4, but got Obj
		//IL_0604: Expected native int or pointer, but got VT
		//IL_061e: Expected F4, but got I
		//IL_0619: Expected native int or pointer, but got VT
		//IL_063b: Expected VT, but got Obj
		//IL_063b: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_00d1: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0142: Expected F4, but got Obj
		//IL_013d: Expected native int or pointer, but got VT
		//IL_0157: Expected F4, but got I
		//IL_0152: Expected native int or pointer, but got VT
		//IL_0164: Expected F4, but got Obj
		//IL_015f: Expected native int or pointer, but got VT
		//IL_0179: Expected F4, but got I
		//IL_0174: Expected native int or pointer, but got VT
		//IL_0186: Expected F4, but got Obj
		//IL_0181: Expected native int or pointer, but got VT
		//IL_019b: Expected F4, but got I
		//IL_0196: Expected native int or pointer, but got VT
		//IL_01b8: Expected VT, but got Obj
		//IL_01b8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		UISprite component = _topRunMedalGuideSprite.GetComponent<UISprite>();
		((UIRect)component).ParentHasChanged();
		nint num = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<UI.Screens.PauseScreen>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(PauseScreen);
		if (!flag)
		{
			nint num3 = (nint)typeof(PauseScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v91 (Il2CppClass<UI.Screens.PauseScreen>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(PauseScreen);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(PauseScreen);
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 132;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ L1_v2 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		nint num4 = 0;
		obj2 = DIAMOND_POSITION;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v9 (Il2CppStaticFields<UI.Screens.PauseScreen>)+8]");
		_ = 0;
		object obj4 = obj3 + 120;
		nint num5 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v15 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v17+8]");
		_ = 0;
		object obj6 = obj3 + 108;
		nint num6 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v23 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj7 = (nint)0 + (nint)24;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v25+8]");
		_ = 0;
		Vector3 vector = (Vector3)(obj3 + 144);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj3 + 156);
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v22+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = (Vector3)(obj3 + 168);
		((Vector3*)(nint)vector3)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v25+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		ResetTransform(null, (Vector3)_diamondMedalPrefab, vector, vector2, vector3);
		object obj8 = obj3 + 96;
		nint num7 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v47 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj9 = (nint)0 + (nint)36;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v49+8]");
		_ = 0;
		object obj10 = obj3 + 84;
		nint num8 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v55 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj11 = (nint)0 + (nint)48;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v57+8]");
		_ = 0;
		object obj12 = obj3 + 72;
		nint num9 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v63 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj13 = (nint)0 + (nint)60;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v65+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v40+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v43+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v46+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		ResetTransform((Transform)1, (Vector3)_goldMedalPrefab, vector, vector2, vector3);
		object obj14 = obj3 + 60;
		nint num10 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v84 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj15 = (nint)0 + (nint)72;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v86+8]");
		_ = 0;
		object obj16 = obj3 + 48;
		nint num11 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v92 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj17 = (nint)0 + (nint)84;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v94+8]");
		_ = 0;
		object obj18 = obj3 + 36;
		nint num12 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S1_v100 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj19 = (nint)0 + (nint)96;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v102+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v58+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v61+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v64+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		ResetTransform((Transform)2, (Vector3)_silverMedalPrefab, vector, vector2, vector3);
		object obj20 = obj3 + 24;
		nint num13 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v121 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj21 = (nint)0 + (nint)108;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v123+8]");
		_ = 0;
		object obj22 = obj3 + 12;
		nint num14 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S1_v129 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj23 = (nint)0 + (nint)120;
		obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S1_v131+8]");
		_ = 0;
		nint num15 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v136 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj24 = (nint)0 + (nint)132;
		obj3 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S1_v138+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v76+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v79+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		ResetTransform((Transform)3, (Vector3)_bronzeMedalPrefab, vector, vector2, vector3);
	}

	private unsafe void ResetTransform(Transform trans, Vector3 newPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01cb: Expected I4, but got F4
		//IL_01f5: Expected I4, but got F4
		//IL_020d: Expected Obj, but got I4
		//IL_021a: Expected Obj, but got F4
		//IL_022c: Expected I, but got F4
		//IL_0242: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0258: Expected I4, but got VT
		//IL_0258: Expected Obj, but got I
		//IL_00aa: Expected I, but got Obj
		object obj = _topRunMedals + 16;
		object obj2 = (object)trans << 2;
		object obj3 = obj + obj2;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			bool isInstanced = UIScreenController.IsInstanced;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v41 (Il2CppClass<NGUITools>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v49 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v38 (System.Boolean)+20]");
			int num5 = NGUITools.CalculateNextDepth((GameObject)0, (byte)(int)newPosition != 0);
			throw new ArrayTypeMismatchException();
		}
		object obj6 = _topRunMedals + 16;
		object obj7 = (object)trans << 2;
		object obj8 = obj6 + obj7;
		((GameObject)obj8).tag = (string)1;
		object obj9 = _topRunMedals + 16;
		object obj10 = (object)trans << 2;
		object obj11 = obj9 + obj10;
		Characters.CharacterId characterId = default;
		((Characters.CharacterId*)(int)characterId)->value__ = (int)positionOffset.x;
		_ = positionOffset.z;
		bool flag = (byte)(characterId + 12) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)newRotation.x != 0;
		_ = newRotation.z;
		Transform transform = (Transform)(characterId + 24);
		transform = (Transform)newScale.x;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)newScale.z;
		((ScrollListCharacterUI)(object)this).Init((int)obj11, characterId, flag, transform);
	}

	private void RefreshMissionInfos()
	{
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		object obj = _topRunMedals + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _topRunMedals + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj5).FindKernel((string)null) != 0)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)obj5);
			}
			object obj8 = obj2 + 1;
			obj2 = obj8;
		}
	}

	private void CreateNewMissionCells()
	{
		//IL_001e: Expected Obj, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		int num = _currentSet / 2;
		object obj = num * 2;
		object obj2 = _currentSet - obj;
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		int currentMissionSet = ((MissionsManager)(object)instance).currentMissionSet;
		throw new ArrayTypeMismatchException();
	}

	private int CalculateCellHeight(UIWidget guideWidget)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 336;
		obj = guideWidget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PauseScreen)+14C]");
		return 0;
	}

	private void RefreshCurrentCells()
	{
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_025c: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 40;
		object obj3 = _missionInfos + 16;
		int num = _currentSet / 2;
		object obj4 = num * 2;
		object obj5 = _currentSet - obj4;
		object obj6 = obj5 << 2;
		object obj7 = obj3 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<MissionCell> list = default;
		list._002Ector();
		throw new ArrayTypeMismatchException();
	}

	private unsafe void ResetCellPositions()
	{
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected VT, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00e2: Expected VT, but got Obj
		//IL_00dd: Expected native int or pointer, but got VT
		//IL_00f7: Expected VT, but got I
		//IL_00f2: Expected native int or pointer, but got VT
		//IL_0121: Expected native int or pointer, but got VT
		object obj = default;
		MissionInfo missionInfo = (MissionInfo)(obj + 40);
		int num = default;
		int num4 = default;
		while (num <= 2)
		{
			object obj2 = _missionCells + 16;
			int num2 = _currentSet / 2;
			object obj3 = num2 * 2;
			object obj4 = _currentSet - obj3;
			object obj5 = obj4 << 2;
			object obj6 = obj2 + obj5;
			MissionCell missionCell = ((List<MissionCell>)obj6).get_Item(num);
			object obj7 = _missionInfos + 16;
			int num3 = _currentSet / 2;
			object obj8 = num3 * 2;
			object obj9 = _currentSet - obj8;
			object obj10 = obj9 << 2;
			object obj11 = obj7 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8283");
			((MissionInfo*)(nint)missionInfo)->mission = (Mission)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			System.Runtime.CompilerServices.Unsafe.Write(&((MissionInfo*)(nint)missionInfo)->template, (MissionTemplate)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
			((MissionInfo*)(nint)missionInfo)->progress = 0;
			missionCell.Refresh(missionInfo);
			num = num4 + 1;
		}
	}

	private void DestroyOtherMissionCells()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v8 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v45 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v19 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v39 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = _003C_003Ec._003C_003E9;
		nint num6 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v36 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+5C]");
		object obj5 = (nint)0 + (nint)8;
		obj5 = obj4;
		throw new NullReferenceException();
	}

	private void RefreshMissionSubtitle()
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0142: Expected Obj, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00e2: Expected I, but got Obj
		object obj = _missionCells + 16;
		object obj2 = _currentSet + 1;
		object obj3 = obj2 / 2;
		object obj4 = obj3 * 2;
		object obj5 = obj2 - obj4;
		object obj6 = obj5 << 2;
		object obj7 = obj + obj6;
		if (obj7 == null)
		{
			return;
		}
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v13 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v50 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v24 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v44 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		object obj11 = default;
		object obj10 = obj11 + 16;
		obj10 = _003C_003Ec._003C_003E9;
		nint num6 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v41 (Il2CppClass<UI.Screens.PauseScreen+<>c>)+5C]");
		object obj12 = (nint)0 + (nint)12;
		obj12 = obj11;
		throw new NullReferenceException();
	}

	private void OnMissionCellAnimationComplete(int completedMissionsCount)
	{
		if (((UnityEngine.Object)this).m_CachedPtr != (IntPtr)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CE4");
		}
	}

	private IEnumerator MissionCompleteAnimation(int completedMissionsCount)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00a8: Expected Obj, but got I4
		object obj = _missionCellLayouts + 16;
		int num = _currentSet / 2;
		object obj2 = num * 2;
		object obj3 = _currentSet - obj2;
		object obj4 = obj3 << 2;
		object obj5 = obj + obj4;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5+24]");
		object obj7 = (nint)0 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [completedMissionsCount @ L1 (System.Int32)+68]");
		object obj8 = 0 - obj7;
		float f = (float)obj8 / 3f;
		return (IEnumerator)NumberExtensions.CeilToInt(f);
	}

	private void AnimateNewMissionSet()
	{
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I4
		//IL_0072: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v12 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("MISSION_SET");
		int missionsVersion = PlayerSave.missionsVersion;
		object obj2 = missionsVersion;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = string.Format(format, args);
		_missionSubTitle.fontSize = (int)text;
	}

	private IEnumerator AnimateCell(Transform cellTransform, float startX, float endX, Action onComplete = null)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = cellTransform;
		object obj3 = enumerator + 32;
		obj3 = onComplete;
		return enumerator;
	}

	private float GetTotalMissionCellAnimationTime()
	{
		//IL_0007: Expected F4, but got Obj
		return (float)_dailyChallengeSubTitle;
	}

	private void OnApplicationPause(bool paused)
	{
		string text = tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 != null)
		{
			IEnumerator routine = ((UpgradeScreen)this).ReadYPanelPosAfterFrames(paused ? 1 : 0);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	public bool IsWaiting()
	{
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_025c: Expected I4, but got Obj
		//IL_00b8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		object obj3 = this / 864000000000L;
		if ((nint)obj3 < 1)
		{
			double num = (double)this * 1E-07;
			if (!(num < 0.0))
			{
				obj2 = this;
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A56A");
				bool result = default;
				return result;
			}
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v34 (Il2CppClass<Strings>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v41 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("TOPRUN_STATE_NEXT_SOON");
			return (byte)(int)text != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = this / 864000000000L;
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	public void HomeButtonClicked()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03c3: Expected Obj, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0470: Expected Obj, but got I4
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_0500: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = default;
		object obj5 = obj6 + 8;
		obj5 = this;
		_ = -350f;
		_ = 0f;
		_ = 350f;
		int currentSet = _currentSet + 1;
		_currentSet = currentSet;
		RefreshCurrentCells();
		object obj7 = obj6 + 12;
		object obj8 = _missionCells + 16;
		int num = _currentSet / 2;
		object obj9 = num * 2;
		object obj10 = _currentSet - obj9;
		object obj11 = obj10 << 2;
		object obj12 = obj8 + obj11;
		obj7 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj13 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj13 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
		}
		object obj14 = obj4 + 4;
		object obj15 = obj14 + 1;
		obj14 = obj15;
		object obj16 = obj15 << 2;
		object obj17 = obj4 + obj16;
		obj17 = 147;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj4 + obj18;
			if ((nint)obj19 == 147)
			{
				object obj20 = obj4 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_04ea;
			}
		}
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04ea;
		IL_04ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+C]");
		MissionCell missionCell = ((List<MissionCell>)0).get_Item(0);
		GameObject gameObject = missionCell.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12166");
		IEnumerator routine = default;
		Coroutine coroutine = StartCoroutine_Auto(routine);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj24 = default;
		object obj23 = obj24 + 16;
		obj23 = obj6;
		throw new ArrayTypeMismatchException();
	}

	public PauseScreen()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("HomeConfirmationPopup");
	}
}
