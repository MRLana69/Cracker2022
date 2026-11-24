using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Common.Extensions;
using SYBO.Common;
using SYBO.Common.Builders;
using SYBO.Common.Data;
using SYBO.Common.Managers;
using SYBO.Common.StateSystem;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using SYBO.Subway.Info;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using SYBO.Subway.Managers;
using SYBO.Subway.Pickups;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
using SYBO.Subway.Utilities;
using SYBO.Subway.Visuals;
using UnityEngine;
using UnityEngine.Networking;

namespace SYBO.Subway;

public class Game : MonoBehaviour
{
	public enum SpeedBoostType
	{
		Normal,
		High
	}

	[Serializable]
	public class SwipeInfo
	{
		public float distanceMin;

		public float doubleTapDuration;

		public SwipeInfo()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	[Serializable]
	public class SpeedInfo
	{
		public float min = 0.1f;

		public float max = 0.3f;

		public float rampUpDuration;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<RefreshType> _003C_003E9__154_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			SYBO.Common.Utilities.GameObjectUtil._003C_003Ec obj = default;
			SYBO.Common.Utilities.GameObjectUtil._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			_ = 110f;
			_ = 220f;
			_ = 200f;
		}

		internal void _003CAwake_003Eb__154_0(RefreshType type)
		{
		}
	}

	private sealed class _003CSkipRevive_003Ed__191 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Expected Obj, but got Unknown
				//IL_0087: Expected Obj, but got I4
				//IL_00a5: Expected I, but got Obj
				//IL_00bb: Expected Obj, but got I
				//IL_01bc: Expected Obj, but got I4
				//IL_01ca: Expected I, but got Obj
				//IL_01e0: Expected Obj, but got I
				//IL_0214: Expected Obj, but got I4
				//IL_0214: Expected Obj, but got I4
				//IL_00e6: Expected I, but got Obj
				//IL_0133: Expected I, but got Obj
				Game game = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v40 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						((UIScreenController)flag).PayWeeklyHuntIfNeeded();
						nint num3 = (nint)typeof(GameStateMachine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(GameStateMachine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v36 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
						((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)100);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				game.ingameTouchDetection = false;
				game.canRevive = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.1f;
				object obj3 = this + 12;
				object obj4 = default;
				obj3 = obj4;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CSkipRevive_003Ed__191(int _003C_003E1__state)
		{
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected Obj, but got Unknown
			//IL_007c: Expected Obj, but got I4
			//IL_008f: Expected Obj, but got I4
			//IL_0058: Expected VT, but got Obj
			//IL_0061: Expected Obj, but got VT
			object obj2 = default;
			object obj = obj2 + 4;
			obj = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Enum obj3 = default;
			IFormatProvider provider = default;
			if (obj3.System_002EIConvertible_002EToBoolean(provider) && OnboardingSave.numberOfRunsSinceLastGuideline == 0)
			{
				_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
				((RouteManager)val).Update();
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

	private sealed class _003CEnableCharacterDayEventAnimation_003Ed__195(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
						((GameStats)(object)privacyPolicyUrl).IsPausedPowerups = true;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj2 = default;
				obj = obj2;
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

	private sealed class _003CDebugRepeatedlySwipeLeftRightCoroutine_003Ed__196(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e1: Expected Obj, but got Unknown
				//IL_01fd: Expected Obj, but got I4
				//IL_0071: Expected I, but got Obj
				//IL_0087: Expected Obj, but got I
				//IL_0238: Expected Obj, but got I4
				//IL_0238: Expected Obj, but got I4
				//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Expected Obj, but got Unknown
				//IL_011e: Expected Obj, but got I4
				//IL_00b2: Expected I, but got Obj
				//IL_013c: Expected I, but got Obj
				//IL_0152: Expected Obj, but got I
				//IL_0263: Expected Obj, but got I4
				//IL_0263: Expected Obj, but got I4
				//IL_017d: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(GameStateMachine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v19 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(GameStateMachine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v32 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
						((MonobehaviourScheduler)useBenchmarkRoute).RegisterUpdateHandler((Action)2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.05f;
						object obj2 = this + 12;
						object obj3 = default;
						obj2 = obj3;
						_003C_003E1__state = 2;
						return 1;
					}
					if (_003C_003E1__state != 2)
					{
						return null;
					}
					_003C_003E1__state = -1;
					nint num3 = (nint)typeof(GameStateMachine);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v38 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num4 = (nint)typeof(GameStateMachine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v44 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
					((MonobehaviourScheduler)useBenchmarkRoute2).RegisterUpdateHandler((Action)3);
				}
				else
				{
					_003C_003E1__state = -1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.05f;
				object obj5 = this + 12;
				object obj6 = default;
				obj5 = obj6;
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

	private sealed class _003CStumbleDeathSequence_003Ed__203(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Game _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Expected Obj, but got Unknown
				//IL_0098: Expected Obj, but got I4
				//IL_0265: Unknown result type (might be due to invalid IL or missing references)
				//IL_026a: Expected Obj, but got Unknown
				//IL_0273: Expected Obj, but got I4
				//IL_0196: Expected I, but got Obj
				//IL_01ac: Expected Obj, but got I
				//IL_028f: Expected Obj, but got I4
				//IL_01d7: Expected I, but got Obj
				Game game = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Variable<bool> isInGame = game.IsInGame;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v24 (Variable`1<System.Boolean>)+8]");
						if ((nint)0 != 0 && !game.HasSuperSneakers && !game.IsInPogostickMode)
						{
							Character character = game._character;
							character.LastDeathCause = Character.DeathCause.RepeatedStumble;
							if (game.m_OnEndStumbleDeathSequence != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
							}
							nint num = (nint)typeof(GameStateMachine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v43 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
							object obj = (nint)0 & (nint)0x200;
							if (obj != null)
							{
								nint num2 = (nint)typeof(GameStateMachine);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v49 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
							((MonobehaviourScheduler)useBenchmarkRoute)._002Ector();
						}
						game._isInStumbleDeathSequence = false;
						object obj2 = game + 156;
						obj2 = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				game._isInStumbleDeathSequence = true;
				SpeedInfo speed = game.speed;
				game.__currentSpeed = speed.min;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.2f;
				object obj3 = this + 12;
				object obj4 = default;
				obj3 = obj4;
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

	public const float Z_OFFSET_BACKGROUND_TO_CHARACTER_CAMERA = 900f;

	private static CharacterController _characterController;

	public const float DISTANCE_PER_METER = 8f;

	public static float GAME_DEFAULT_GAME_SPEED;

	public static bool HasLoaded;

	private static Action m_OnGameAwake;

	private static Action m_OnGameStarted;

	private static Action<bool, bool, bool, bool> m_OnRunStarted;

	private static Action m_OnGameRevived;

	private static Action<bool> m_OnPlayerDied;

	private static Action<bool> m_OnRunEnded;

	private static Action m_OnGameReviveOffer;

	private static Action m_OnGameEnded;

	private static Action m_OnMenuScreenShown;

	private static Action m_OnGameDestroyed;

	private Action<int> m_OnTurboHeadstartInput;

	private Action m_OnEndStumbleDeathSequence;

	private Action<bool> m_OnPauseChange;

	private Action m_OnStageMenuSequence;

	private Action m_OnIntroRun;

	private Action m_OnCharacterModelRecreated;

	private float highSpeedFOVIncrease;

	private SpeedInfo hotrodSpeedInfo;

	private GameObject characterModelPreviewFactoryPrefab;

	private GameObject hoverboardFactoryPrefab;

	private SpeedInfo highSpeedInfo;

	private float _speedChangeTransitionTime;

	private float speedFOVIncrease;

	public bool isDead;

	public bool ingameTouchDetection;

	public bool canRevive;

	private bool IsRunningOnTutorialTrack__BackingField;

	private float __currentSpeed;

	private float __currentLevelSpeed;

	private bool _isLockedGameSpeed;

	public float SpeedAtLastObstacleHit;

	public SwipeInfo swipe;

	public SpeedInfo speed;

	private float _elapsedGameDuration;

	public Variable<bool> IsInGame;

	public Variable<bool> IsInTopMenu;

	public AudioClipInfo DieSound;

	public bool awakeDone;

	private bool isReadyForSlideinPowerups__BackingField;

	public DateTime gameStartTime;

	public string startCharacterName;

	public int startCharacterTheme;

	public int pogoLevel;

	public int pogoJumpsLeft;

	private Character _character;

	private CharacterModifierCollection _modifiers;

	private SpeedInfo _selectedBoardSpeedInfo;

	private SpeedInfo _currentSpeedInfo;

	private SpeedInfo _originalSpeed;

	private IEnumerator _stumbleDeathSequenceRoutine;

	private Swipe _currentSwipe;

	private CharacterRendering _characterRendering;

	private CharacterCamera _characterCamera;

	private FollowingGuard _followingGuard;

	private GameObject[] _menuFactories;

	private GameStats _gameStats;

	private float _elapsedRunDuration;

	private float _offsetGameStartTime;

	private List<Action<float>> _speedChangeHandlers;

	private bool _isPaused;

	private PickupManagerController _pickupManagerController;

	private SyboRandom _randomGenerator;

	private static Game instance;

	private bool _isPausedPowerups;

	private IEnumerator _debugRepeatedlySwipeLeftRightCoroutine;

	private bool _isInStumbleDeathSequence;

	public static CharacterController Charactercontroller
	{
		get
		{
			//IL_002c: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @947C");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @947C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				CharacterController result = default;
				return result;
			}
			return (CharacterController)32;
		}
	}

	public float HighSpeedFOVIncrease
	{
		get
		{
			float maxDelay = NetworkServer.maxDelay;
			return maxDelay - (float)this.m_OnPauseChange;
		}
	}

	public float SpeedFOVIncrease => highSpeedFOVIncrease;

	public bool IsRunningOnTutorialTrack
	{
		get
		{
			//IL_0025: Expected Obj, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected Obj, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected Obj, but got Unknown
			IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (System.IntPtr)+C]");
			if ((nint)0 != 0)
			{
				IntPtr cachedPtr2 = ((UnityEngine.Object)this).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3 (System.IntPtr)+C]");
				object obj = (nint)0 << 2;
				object obj2 = (nint)((UnityEngine.Object)this).m_CachedPtr + obj;
				object obj3 = obj2 + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				bool result = default;
				return result;
			}
			return true;
		}
		set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCharacterModelRecreated;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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

	public float CurrentSpeed => speedFOVIncrease;

	public float CurrentLevelSpeed => __currentSpeed;

	public bool IsLockedGameSpeed
	{
		get
		{
			return IsRunningOnTutorialTrack__BackingField;
		}
		set
		{
			IsRunningOnTutorialTrack__BackingField = value;
		}
	}

	public float ElapsedGameDuration => __currentLevelSpeed;

	public bool isReadyForSlideinPowerups
	{
		get
		{
			return _isLockedGameSpeed;
		}
		set
		{
			_isLockedGameSpeed = value;
		}
	}

	public Character Character
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = isReadyForSlideinPowerups__BackingField;
			return (Character)flag;
		}
	}

	public CharacterModifierCollection Modifiers => (CharacterModifierCollection)(object)_character;

	public bool IsInJetpackMode
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_modifiers != 0;
		}
	}

	public bool IsInPogostickMode
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
			//IL_00a9: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
			return (byte)(int)((StateMachine)useBenchmarkRoute).TryGetCurrentState<T>() != 0;
		}
	}

	public bool HasSuperSneakers
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
			//IL_00a9: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
			return (byte)(int)((StateMachine)useBenchmarkRoute).TryGetCurrentState<T>() != 0;
		}
	}

	public float CurrentSpeedNormalized => _elapsedGameDuration;

	public float ElapsedRunDuration
	{
		get
		{
			SpeedInfo speedInfo = speed;
			return __currentSpeed / speedInfo.min;
		}
	}

	public SyboRandom RandomGenerator
	{
		get
		{
			//IL_0033: Expected Obj, but got I4
			CharacterModifierCollection modifiers = _modifiers;
			SuperSneakers superSneakers = modifiers.superSneakers;
			bool isActive = superSneakers.isActive;
			return (SyboRandom)isActive;
		}
	}

	public float OffsetGameStartTime => _elapsedRunDuration;

	public bool IsPaused
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_randomGenerator != 0;
		}
	}

	public unsafe static Game Instance
	{
		get
		{
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected I, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_01d6: Expected I, but got Obj
			//IL_01f1: Expected I, but got Obj
			//IL_0207: Expected Obj, but got I
			//IL_0249: Expected I, but got Obj
			//IL_025f: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			nint num3 = (nint)(obj2 + 4);
			bool flag = (object)_characterController == null;
			bool flag2 = !flag;
			Game result = (Game)(object)_characterController;
			if (!flag2)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v49 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(CharacterController);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				nint num8 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Game game = default;
				_characterController = (CharacterController)(object)game;
				result = game;
			}
			return result;
		}
	}

	public static bool IsInstantiated
	{
		get
		{
			//IL_0157: Expected I, but got Obj
			//IL_016d: Expected Obj, but got I
			//IL_0232: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0194: Expected VT, but got Obj
			//IL_01a2: Expected I, but got Obj
			//IL_01b8: Expected Obj, but got I
			//IL_01d5: Expected I, but got Obj
			//IL_01f9: Expected Obj, but got I
			//IL_0201: Expected Obj, but got VT
			//IL_0209: Expected I4, but got VT
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_011e: Expected I, but got Obj
			//IL_0144: Expected I, but got Obj
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v42 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			bool result = (byte)(int)instance != 0;
			if (!flag2)
			{
				nint num3 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<Utils>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v38 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_0021_00210 val = (_0021_00210)Utils.FindComponentInThisOrParents<T>((MonoBehaviour)null);
				nint num5 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v24 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag3 = obj3 == null;
				nint num6 = (nint)typeof(Game);
				if (!flag3)
				{
					nint num7 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag4 = (nint)0 == 0;
					bool flag5 = !flag4;
					num6 = (nint)typeof(Game);
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num6 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ L0_v7 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj4 = (nint)0 + (nint)52;
				obj4 = val;
				result = (byte)(int)val != 0;
			}
			return result;
		}
	}

	public bool IsPausedPowerups
	{
		get
		{
			return _isPaused;
		}
		set
		{
			isReadyForSlideinPowerups__BackingField = value;
		}
	}

	public bool isInStumbleDeathSequence
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool result = default;
			return result;
		}
	}

	public static event Action OnGameAwake
	{
		add
		{
			((Delegate)value).method_ptr = (IntPtr)1;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameAwake;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)12;
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

	public static event Action OnGameStarted
	{
		add
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameAwake;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)12;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameStarted;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)16;
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

	public static event Action<bool, bool, bool, bool> OnRunStarted
	{
		add
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameStarted;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)16;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnRunStarted;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)20;
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

	public static event Action OnGameRevived
	{
		add
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnRunStarted;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)20;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameRevived;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)24;
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

	public static event Action<bool> OnPlayerDied
	{
		add
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameRevived;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)24;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnPlayerDied;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)28;
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

	public static event Action<bool> OnRunEnded
	{
		add
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnPlayerDied;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)28;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnRunEnded;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)32;
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

	public static event Action OnGameReviveOffer
	{
		add
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnRunEnded;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)32;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameReviveOffer;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)36;
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

	public static event Action OnGameEnded
	{
		add
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameReviveOffer;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)36;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameEnded;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)40;
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

	public static event Action OnMenuScreenShown
	{
		add
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameEnded;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)40;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnMenuScreenShown;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)44;
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

	public static event Action OnGameDestroyed
	{
		add
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnMenuScreenShown;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)44;
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
			nint num = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = Game.m_OnGameDestroyed;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(Game);
				if (!flag)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Game);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Game);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
				object obj5 = (nint)0 + (nint)48;
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

	public event Action<int> OnTurboHeadstartInput
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnTurboHeadstartInput;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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

	public event Action OnEndStumbleDeathSequence
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnTurboHeadstartInput;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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
			Delegate obj = this.m_OnEndStumbleDeathSequence;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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

	public event Action<bool> OnPauseChange
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnEndStumbleDeathSequence;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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
			Delegate obj = this.m_OnPauseChange;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
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

	public event Action OnStageMenuSequence
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPauseChange;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
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
			Delegate obj = this.m_OnStageMenuSequence;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
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

	public event Action OnIntroRun
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnStageMenuSequence;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
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
			Delegate obj = this.m_OnIntroRun;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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

	public event Action OnCharacterModelRecreated
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnIntroRun;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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
			Delegate obj = this.m_OnCharacterModelRecreated;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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

	public static float ConvertUnityUnitsToGameMeters(float unityUnits)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Mathf.RoundToInt(unityUnits);
		return unityUnits - (float)num3;
	}

	public static float ConvertGameMetersToUnityUnits(float meters)
	{
		return meters * 0.125f;
	}

	public void SetCurrentSpeed(float speed)
	{
	}

	public void SetInitialSpeed()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = Game.m_OnGameDestroyed;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(Game);
			if (!flag)
			{
				nint num5 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(Game);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(Game);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SYBO.Subway.Game>)+5C]");
			object obj5 = (nint)0 + (nint)48;
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

	public void SetCurrentLevelSpeed(float levelSpeed)
	{
		__currentSpeed = levelSpeed;
	}

	public Game()
	{
		SpeedInfo speedInfo = speed;
		SpeedInfo originalSpeed = _originalSpeed;
		speedInfo.min = originalSpeed.min;
		SpeedInfo speedInfo2 = speed;
		SpeedInfo originalSpeed2 = _originalSpeed;
		speedInfo2.max = originalSpeed2.max;
		SpeedInfo speedInfo3 = speed;
		SpeedInfo originalSpeed3 = _originalSpeed;
		speedInfo3.rampUpDuration = originalSpeed3.rampUpDuration;
		float _currentLevelSpeed = UIExtensions.CenterChildrenHorizontally((Transform[])(object)this, 0f, (Transform)(object)_currentSpeedInfo);
		__currentLevelSpeed = _currentLevelSpeed;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		_offsetGameStartTime = timeSinceLevelLoad;
	}

	protected void Awake()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		highSpeedFOVIncrease = 10f;
		_speedChangeTransitionTime = 0.5f;
		speedFOVIncrease = 5f;
		ingameTouchDetection = true;
		__currentLevelSpeed = 30f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 110f;
		_ = 220f;
		_ = 200f;
		object obj = this + 148;
		object obj2 = default;
		obj = obj2;
		object obj3 = this + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj5 = this + 192;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UnityRandomGen unityRandomGen = default;
		unityRandomGen._002Ector();
		object obj7 = this + 204;
		obj7 = unityRandomGen;
		CancelInvoke();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		object obj8 = this + 96;
		object obj9 = default;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		object obj10 = this + 100;
		object obj11 = default;
		obj10 = obj11;
	}

	protected unsafe void Start()
	{
		//IL_0814: Expected I, but got Obj
		//IL_082a: Expected Obj, but got I
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_085f: Expected I, but got Obj
		//IL_0875: Expected Obj, but got I
		//IL_0aa9: Expected I, but got Obj
		//IL_0abf: Expected Obj, but got I
		//IL_00bc: Expected I, but got Obj
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected Obj, but got Unknown
		//IL_08bc: Expected I, but got Obj
		//IL_08d2: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_090b: Expected Obj, but got I4
		//IL_0919: Expected I, but got Obj
		//IL_092f: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Expected Obj, but got Unknown
		//IL_01a3: Expected I, but got Obj
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_01f0: Expected I, but got Obj
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03f3: Expected Obj, but got I
		//IL_0425: Expected VT, but got Obj
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_0458: Expected Obj, but got VT
		//IL_046a: Expected VT, but got Obj
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04b1: Expected Obj, but got VT
		//IL_04c8: Expected VT, but got Obj
		//IL_04e4: Expected Obj, but got VT
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_0517: Expected VT, but got Obj
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected Obj, but got Unknown
		//IL_0554: Expected Obj, but got VT
		//IL_0990: Expected I, but got Obj
		//IL_09a6: Expected Obj, but got I
		//IL_0b25: Expected I, but got Obj
		//IL_0b3b: Expected Obj, but got I
		//IL_065d: Expected I, but got Obj
		//IL_06aa: Expected I, but got Obj
		//IL_06c0: Expected Obj, but got I
		//IL_05cd: Expected VT, but got Obj
		//IL_05dc: Expected VT, but got Obj
		//IL_0738: Expected I, but got Obj
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected Obj, but got Unknown
		//IL_0a00: Expected I, but got Obj
		//IL_0a16: Expected Obj, but got I
		//IL_0785: Expected I, but got Obj
		//IL_079b: Expected Obj, but got I
		//IL_06eb: Expected I, but got Obj
		//IL_060f: Expected VT, but got Obj
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_0630: Expected VT, but got Obj
		//IL_07c6: Expected I, but got Obj
		//IL_0644: Expected VT, but got Obj
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v259 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 136;
		CharacterRendering characterRendering = CharacterRendering.Instance;
		obj2 = characterRendering;
		bool flag = SingletonMonoBehaviour<>.IsInstantiated();
		bool flag2 = SingletonMonoBehaviour<>.IsInstantiated();
		object obj3 = this + 152;
		obj3 = speed;
		RewardCoin();
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v253 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HasLoaded = true;
		nint num5 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v249 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine._002Ecctor();
		_character.RecreateCharacterModel();
		nint num7 = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v37 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v245 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = this + 164;
		CharacterCamera characterCamera = CharacterCamera.Instance;
		obj7 = characterCamera;
		nint num9 = (nint)typeof(CharacterCamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v44 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(CharacterCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v241 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = this + 168;
		int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
		obj9 = selectedBenchmarkIndex;
		nint num11 = (nint)typeof(FollowingGuard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v51 (Il2CppClass<FollowingGuard>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num12 = (nint)typeof(FollowingGuard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v237 (Il2CppClass<FollowingGuard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = this + 172;
		IEnumerator enumerator = HouseKeeper.InitAuthAndCloudSave();
		obj11 = enumerator;
		_followingGuard.ReplaceSharedPrefab();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterModifierCollection characterModifierCollection = default;
		characterModifierCollection.Update();
		object obj12 = this + 140;
		obj12 = characterModifierCollection;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		_ = 0;
		EventHandler<CharacterModifierCollectionChangedEventArgs> eventHandler = default;
		object obj13 = eventHandler + 16;
		obj13 = _characterCamera;
		_modifiers.OnChanged -= eventHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnStumbleDelegate onStumbleDelegate = default;
		((Delegate)onStumbleDelegate).method_ptr = method_ptr;
		((Delegate)onStumbleDelegate).method = (nint)__ldftn(Game.OnStumble);
		object obj14 = onStumbleDelegate + 16;
		obj14 = this;
		_character.OnStumble -= onStumbleDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Character.OnCriticalHitDelegate onCriticalHitDelegate = default;
		((Delegate)onCriticalHitDelegate).method_ptr = method_ptr2;
		((Delegate)onCriticalHitDelegate).method = (nint)__ldftn(Game.OnCriticalHit);
		object obj15 = onCriticalHitDelegate + 16;
		obj15 = this;
		_character.OnCriticalHit -= onCriticalHitDelegate;
		float heightOffset = UIExtensions.CenterChildrenHorizontally((Transform[])(object)this, 0f, (Transform)(object)_currentSpeedInfo);
		((DizzyStarsHeightControl)this).HeightOffset = heightOffset;
		object obj16 = this + 180;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		obj16 = privacyPolicyUrl;
		awakeDone = true;
		Variable<bool> isInTopMenu = IsInTopMenu;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Delegate obj17 = default;
		obj17.method_ptr = method_ptr3;
		obj17.method = (nint)__ldftn(Game._003CAwake_003Eb__154_1);
		object obj18 = obj17 + 16;
		obj18 = this;
		object obj19 = IsInTopMenu + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v75 (Variable`1<System.Boolean>)+C]");
		Delegate obj20 = ((Delegate)0).CombineImpl(obj17);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj21 = default;
		obj19 = obj21;
		bool flag3 = SingletonMonoBehaviour<>.IsInstantiated();
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num14 = 0;
		_ = 0;
		Action<bool, bool, bool, bool> action = default;
		object obj22 = action + 16;
		obj22 = val;
		OnRunStarted -= action;
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr4;
		((Delegate)action2).method = (nint)__ldftn(PickupManager.Game_OnGameStarted);
		object obj23 = action2 + 16;
		obj23 = val2;
		OnGameStarted -= action2;
		_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		PickupManagerController pickupManagerController = default;
		pickupManagerController.PickupManager_OnPickerRemoved((PickerRemoveRequestEventArgs)val3);
		object obj24 = this + 200;
		obj24 = pickupManagerController;
		bool flag4 = SingletonMonoBehaviour<>.IsInstantiated();
		bool flag5 = SingletonMonoBehaviour<>.IsInstantiated();
		_00210 val4 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num15 = 0;
		_ = 0;
		EventHandler<InputEventArgs> eventHandler2 = default;
		object obj25 = eventHandler2 + 16;
		obj25 = this;
		((InputManager)val4).OnInputEvent -= eventHandler2;
		bool flag6 = SingletonMonoBehaviour<>.IsInstantiated();
		bool flag7 = SingletonMonoBehaviour<>.IsInstantiated();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80D1");
		object obj26 = default;
		if (obj26 != null && !DebugSettings.CharacterInvincible)
		{
			_00210 val5 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			_ = 0;
			_00210 val6 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v221 (T)+14]");
			if ((nint)0 != 0)
			{
				_00210 val7 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				object obj27 = val7 + 16;
				obj27 = _character;
				_00210 val8 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				_ = 0;
				_00210 val9 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				_ = 0;
			}
		}
		nint num16 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v141 (Il2CppClass<SYBO.Subway.Game+<>c>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num17 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v207 (Il2CppClass<SYBO.Subway.Game+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag8 = _003C_003Ec._003C_003E9__154_0 == null;
		bool flag9 = !flag8;
		Action<RefreshType> value = _003C_003Ec._003C_003E9__154_0;
		if (!flag9)
		{
			nint num18 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v181 (Il2CppClass<SYBO.Subway.Game+<>c>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num19 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v201 (Il2CppClass<SYBO.Subway.Game+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num20 = 0;
			_ = 0;
			Action<RefreshType> action3 = default;
			object obj30 = action3 + 16;
			obj30 = _003C_003Ec._003C_003E9;
			nint num21 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S0_v198 (Il2CppClass<SYBO.Subway.Game+<>c>)+5C]");
			object obj31 = (nint)0 + (nint)4;
			obj31 = action3;
			value = action3;
		}
		AppRefreshHandler.hasRefreshed -= value;
		nint num22 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v152 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj32 = (nint)0 & (nint)0x200;
		if (obj32 != null)
		{
			nint num23 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ S0_v174 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Game.m_OnGameAwake == null)
		{
			return;
		}
		nint num24 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v161 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num25 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ S0_v168 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
	}

	protected void OnDestroy()
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v24 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v30 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag).GameOverTriggered();
		}
		nint num5 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v14 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v19 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine.GenerateStateMachine();
	}

	public static void InvokeReviveOffer()
	{
		StackablePrefabBuilder._STACKABLE_PREFAB_BUILDER_NAME = "StackablePrefabBuilder";
	}

	public static void InvokeOnGameEnded()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)Game.m_OnGameReviveOffer);
	}

	public static void InvokeOnMenuScreenShown()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)Game.m_OnGameEnded);
	}

	public void InvokeOnStageMenuSequence()
	{
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_0045: Expected I, but got Obj
		//IL_005b: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_037a: Expected VT, but got Obj
		//IL_03a0: Expected Obj, but got I4
		//IL_03b2: Expected Obj, but got VT
		//IL_0448: Expected I, but got Obj
		//IL_045e: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_03c0: Expected VT, but got Obj
		//IL_03e8: Expected Obj, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got VT
		//IL_0086: Expected I, but got Obj
		//IL_0136: Expected I, but got Obj
		//IL_0284: Expected I, but got Obj
		//IL_02d1: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0312: Expected I, but got Obj
		if (_pickupManagerController != null)
		{
			_pickupManagerController.Update();
		}
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			nint num = (nint)typeof(SingletonMonoBehaviour);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v66 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SingletonMonoBehaviour);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v73 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			bool flag = default;
			object obj2 = (flag ? 1 : 0) + 16;
			obj2 = this;
			((InputManager)val).IsEnabled = flag;
		}
		if (SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			nint num4 = (nint)typeof(SingletonMonoBehaviour);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v54 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(SingletonMonoBehaviour);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v61 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			Coin coin = default;
			((UnityEngine.Object)coin).m_CachedPtr = cachedPtr;
			coin._pickupDefault = (PickupDefault)0;
			object obj4 = coin + 16;
			obj4 = this;
			((CoinManager)val2).NotifyCoinActivated(coin);
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_characterCamera).FindKernel((string)null) != 0 && _modifiers != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr2 = 0;
			CharacterModifier characterModifier = default;
			((UnityEngine.Object)characterModifier).m_CachedPtr = cachedPtr2;
			characterModifier._powerup = (ActivePowerup)0;
			object obj6 = characterModifier + 16;
			obj6 = _characterCamera;
			_modifiers.Add(characterModifier);
		}
		nint num8 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v21 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v43 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Game.m_OnGameDestroyed == null)
		{
			return;
		}
		nint num10 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v30 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num11 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v37 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
	}

	public float EvaluatePlayerDistanceTravelTime(float distanceFromCharacter)
	{
		//IL_003b: Expected F4, but got Obj
		float defaultValue = (float)this.m_OnTurboHeadstartInput - distanceFromCharacter;
		float value = ((OnlineSettings)(object)this.m_OnPauseChange).GetValue((string)null, defaultValue);
		((Score)(object)this)._002Ector(distanceFromCharacter);
		return (float)this.m_OnTurboHeadstartInput;
	}

	public void RecreateCharacterModel()
	{
		TransformExtensions.Reset((Transform)(object)this.m_OnStageMenuSequence);
	}

	public void ChangeCurrentSpeed(float timeOffset)
	{
		__currentLevelSpeed = timeOffset;
	}

	public void StartNewGame()
	{
		_character.Awake();
		if (this.m_OnCharacterModelRecreated != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public void Update()
	{
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_03d9: Expected Obj, but got I4
		//IL_03ea: Expected Obj, but got VT
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_040a: Expected VT, but got Obj
		//IL_04a4: Expected I, but got Obj
		//IL_04ba: Expected Obj, but got I
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected Obj, but got Unknown
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_0030: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		DateTime today = CDateTime.Today;
		obj2 = today;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		gameStartTime = (DateTime)obj3;
		_elapsedGameDuration = 0f;
		_elapsedRunDuration = 0f;
		Character character = _character;
		character._killSwitchEnabled = true;
		_isInStumbleDeathSequence = false;
		int numberOfRunsSinceLastGuideline = OnboardingSave.numberOfRunsSinceLastGuideline;
		int num = numberOfRunsSinceLastGuideline ^ 1;
		int num2 = num & 1;
		IsRunningOnTutorialTrack__BackingField = (byte)num2 != 0;
		isReadyForSlideinPowerups__BackingField = false;
		if (~(IsRunningOnTutorialTrack__BackingField ? 1u : 0u) == 0)
		{
			Character character2 = _character;
			character2._lastCheckpointGamePositionZ = 0f;
		}
		nint num3 = (nint)typeof(SYBO.Subway.Info.Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v25 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(SYBO.Subway.Info.Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v124 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 120;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		SYBO.Subway.Info.Characters.Model model = SYBO.Subway.Info.Characters.characterData.get_Item((SYBO.Subway.Info.Characters.CharacterId)currentBoardId);
		obj5 = model.modelName;
		SYBO.Subway.Info.Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
		startCharacterTheme = (int)currentCharacterId;
		nint num5 = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v33 (Il2CppClass<SaveMeManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v118 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveMeManager.isPurchaseRunningIngame = false;
		throw new NullReferenceException();
	}

	public void UpdateMeters()
	{
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_0065: Expected I, but got Obj
		//IL_023c: Expected I, but got Obj
		//IL_0252: Expected Obj, but got I
		//IL_02c2: Expected Obj, but got I4
		//IL_014d: Expected I, but got Obj
		Variable<bool> isInGame = IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 != 0)
		{
			float unscaledTime = Time.unscaledTime;
			float elapsedGameDuration = _elapsedGameDuration + unscaledTime;
			_elapsedGameDuration = elapsedGameDuration;
			float unscaledTime2 = Time.unscaledTime;
			float elapsedRunDuration = _elapsedRunDuration + unscaledTime2;
			_elapsedRunDuration = elapsedRunDuration;
		}
		nint num = (nint)typeof(SaveMeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v12 (Il2CppClass<SaveMeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v54 (Il2CppClass<SaveMeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!SaveMeManager.isPurchaseRunningIngame)
		{
			Variable<bool> isInTopMenu = IsInTopMenu;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v47 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 == 0 && !IsRunningOnTutorialTrack__BackingField && !_isLockedGameSpeed)
			{
				float heightOffset = ((DizzyStarsHeightControl)this).HeightOffset;
				float _currentLevelSpeed = UIExtensions.CenterChildrenHorizontally((Transform[])(object)this, heightOffset, (Transform)(object)_currentSpeedInfo);
				__currentLevelSpeed = _currentLevelSpeed;
				goto IL_022e;
			}
		}
		float unscaledTime3 = Time.unscaledTime;
		float offsetGameStartTime = _offsetGameStartTime + unscaledTime3;
		_offsetGameStartTime = offsetGameStartTime;
		goto IL_022e;
		IL_022e:
		nint num3 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v21 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v38 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		IEnumerator enumerator = ((DeathState)useBenchmarkRoute).DelayGameOverScreen();
		if (enumerator != null)
		{
			_modifiers.StopWithNoEnding();
		}
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		float unscaledTime4 = Time.unscaledTime;
		((GameStats)(object)privacyPolicyUrl).MetersInCurrentGame = unscaledTime4;
		if (_pickupManagerController != null)
		{
			_pickupManagerController.SetupEventSpecificPickups();
		}
	}

	public void ActivateHighSpeed(SpeedBoostType speedBoostType)
	{
		bool isPausedPowerups = (byte)(speedBoostType & SpeedBoostType.High) != 0;
		_isPausedPowerups = isPausedPowerups;
		bool isPausedPowerups2 = _isPausedPowerups;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		if (isPausedPowerups2)
		{
			_ = 1;
			_modifiers.PauseInJetpackMode();
		}
		else
		{
			_ = 0;
			_modifiers.Reset();
		}
	}

	public void DeactivateHighSpeed()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_008f: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_00f4: Expected F4, but got Obj
		//IL_0013: Expected I, but got Obj
		GameStats gameStats = _gameStats;
		object obj = _character + 236;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v3+8]");
		_ = 0;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S2_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float width = 0f * 0.125f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		gameStats._metersInCurrentGame = (float)gUILayoutOption;
	}

	public void RegisterSpeedChangeHandler(Action<float> handler)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		float num;
		if (handler != null)
		{
			if ((nint)handler == 1)
			{
				object obj3 = this + 144;
				obj3 = highSpeedInfo;
				num = highSpeedFOVIncrease;
			}
			else
			{
				num = 0f;
			}
		}
		else
		{
			object obj4 = this + 144;
			obj4 = hotrodSpeedInfo;
			num = speedFOVIncrease;
		}
		CharacterCamera characterCamera = _characterCamera;
		float orthographicSize = characterCamera._camera.orthographicSize;
		float num2 = 68f + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine = default;
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private void RegisterSpeedChange(float newSpeed)
	{
		float offsetGameStartTime = _offsetGameStartTime - newSpeed;
		_offsetGameStartTime = offsetGameStartTime;
	}

	public void PickupJetpack()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		CharacterCamera characterCamera = _characterCamera;
		float orthographicSize = characterCamera._camera.orthographicSize;
		_ = 68f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine = default;
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public void StartJetpack()
	{
		((Game)null).PickupPogostick();
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		((GameStats)(object)privacyPolicyUrl).SuperSneakerPickupsCollectedIncrement();
	}

	public void PickupPogostick()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)104);
	}

	public void StartPogostick()
	{
		pogoJumpsLeft = pogoLevel;
		((Game)null).StartTopMenu();
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		((GameStats)(object)privacyPolicyUrl).DailyLetterPickupsCollectedIncrement();
	}

	public void StartTopMenu()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)105);
	}

	public void Megaheadstart()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)100);
	}

	public void Die()
	{
		//IL_0202: Expected I, but got Obj
		//IL_0218: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I4
		//IL_0175: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
		if (((StateMachine)useBenchmarkRoute2).IsCurrentState<HeadstartState>())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (System.ArrayTypeMismatchException)+90]");
			if ((nint)0 <= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (System.ArrayTypeMismatchException)+8D]");
				if ((nint)0 == 0)
				{
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (System.ArrayTypeMismatchException)+90]");
					object obj2 = (nint)0 + (nint)1;
				}
			}
		}
		else
		{
			object obj3 = this - -64;
			if (obj3 != null)
			{
				return;
			}
			nint num3 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v27 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v33 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute3 = RouteManager.UseBenchmarkRoute;
			((StateMachine)useBenchmarkRoute3).Trigger_OnTriggered((StateMachine.Trigger)103);
		}
		if (this.m_OnTurboHeadstartInput != null)
		{
			Action<int> onTurboHeadstartInput = this.m_OnTurboHeadstartInput;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (System.ArrayTypeMismatchException)+90]");
			onTurboHeadstartInput(0);
		}
	}

	public void Revive(bool revivedWithAds = false, bool adsWasAvailable = true, bool adsFailed = false)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0039: Expected Obj, but got I4
		object obj = this + 8;
		obj = revivedWithAds;
		object obj2 = this + 24;
		obj2 = adsWasAvailable;
		object obj3 = this + 28;
		obj3 = adsFailed;
	}

	public void ResetEnemy()
	{
		//IL_026b: Expected Obj, but got I4
		//IL_0287: Expected I4, but got Obj
		//IL_0287: Expected Obj, but got I4
		//IL_01d9: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_02c8: Expected I, but got Obj
		//IL_02de: Expected Obj, but got I
		//IL_06c4: Expected Obj, but got I4
		//IL_06c4: Expected Obj, but got I4
		//IL_0046: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_06e0: Expected I, but got Obj
		//IL_06f6: Expected Obj, but got I
		//IL_021a: Expected I, but got Obj
		//IL_075e: Expected I, but got Obj
		//IL_0774: Expected Obj, but got I
		//IL_0309: Expected I, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_07a8: Expected Obj, but got I4
		//IL_07a8: Expected Obj, but got I4
		//IL_0372: Expected I4, but got Obj
		//IL_037f: Expected Obj, but got I4
		//IL_053a: Expected I, but got Obj
		//IL_0550: Expected Obj, but got I
		//IL_045f: Expected I, but got Obj
		//IL_0412: Expected I, but got Obj
		//IL_04ac: Expected I, but got Obj
		//IL_04c2: Expected Obj, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a2: Expected Obj, but got I4
		//IL_03dc: Expected Obj, but got I4
		//IL_057b: Expected I, but got Obj
		//IL_05c8: Expected I, but got Obj
		//IL_05de: Expected Obj, but got I
		//IL_04ed: Expected I, but got Obj
		//IL_0609: Expected I, but got Obj
		CharacterModifierCollection modifiers = _modifiers;
		IEnumerator enumerator = ((LongMagnet)(object)_modifiers).PullPickupSpawnPoint((PickupSpawnPoint)(object)modifiers.hoverboard);
		bool obj3;
		if (enumerator != null)
		{
			CharacterModifierCollection modifiers2 = _modifiers;
			Hoverboard hoverboard = modifiers2.hoverboard;
			if (~(hoverboard.isTeleporter ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(CharacterRendering);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v158 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(CharacterRendering);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v164 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterCamera characterCamera = CharacterCamera.Instance;
				((CharacterRendering)(object)characterCamera).Character_OnEnterRoute();
			}
			_followingGuard.OnChangeTrack(Character.OnChangeTrackDirection.Right);
			CharacterModifierCollection modifiers3 = _modifiers;
			Hoverboard hoverboard2 = modifiers3.hoverboard;
			((CharacterModifier)hoverboard2).stop = CharacterModifier.StopSignal.STOP;
			_followingGuard.PlayIntro();
			_followingGuard.MuteProximityLoop();
			Character character = _character;
			if (~(character._isStumbling ? 1u : 0u) == 0)
			{
				_character.HitByTrainSequence();
			}
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			((GameStats)(object)privacyPolicyUrl).StumbleCountIncrement();
			if (_stumbleDeathSequenceRoutine != null)
			{
				StopCoroutine((Coroutine)(object)_stumbleDeathSequenceRoutine);
				object obj2 = this + 156;
				obj2 = 0;
				_isInStumbleDeathSequence = false;
			}
			obj3 = true;
		}
		else if (~(IsRunningOnTutorialTrack__BackingField ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v116 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v123 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
			((StateMachine)useBenchmarkRoute).Trigger_OnTriggered((StateMachine.Trigger)106);
			obj3 = false;
		}
		else
		{
			bool isInitialized = AdSystemManager.isInitialized;
			((PokiUnitySDK)isInitialized).commercialBreak();
			bool isInitialized2 = AdSystemManager.isInitialized;
			((PokiUnitySDK)isInitialized2).setPlayerAge((int)"run");
			canRevive = true;
			string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
			_ = 1;
			object obj5 = this - -64;
			obj5 = 1;
			nint num5 = (nint)typeof(MovingTrain);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v79 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(MovingTrain);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v111 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MovingTrain._002Ecctor();
			FollowingGuard followingGuard = _followingGuard;
			if (~(followingGuard.isShowing ? 1u : 0u) == 0)
			{
				CharacterRendering characterRendering = _characterRendering;
				SafeAnimation characterSafeAnimation = characterRendering._characterSafeAnimation;
				bool flag = characterSafeAnimation._animation.Play((PlayMode)"death_movingTrain");
				if (((AnimationState)flag).wrapMode != WrapMode.Default)
				{
					_followingGuard.LateUpdate();
				}
				else
				{
					Character character2 = _character;
					Character character3 = _character;
					object obj7 = character3.__trackIndex * 20;
					float t = character2.x - (float)obj7;
					_followingGuard._003CCatchUp_003Eb__54_1(t);
				}
			}
			_followingGuard.tag = null;
			MonoBehaviour.print(this);
			nint num7 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v92 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v99 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
			((StateMachine)useBenchmarkRoute2).Trigger_OnTriggered((StateMachine.Trigger)107);
			obj3 = false;
		}
		nint num9 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v10 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v61 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Game.m_OnPlayerDied != null)
		{
			nint num11 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v48 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num12 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v55 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Game.m_OnPlayerDied(obj3);
		}
		nint num13 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v19 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num14 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v41 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Game.m_OnRunEnded == null)
		{
			return;
		}
		nint num15 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num16 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v35 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.m_OnRunEnded(obj3);
	}

	public void ResetEnemyForEnterPlay()
	{
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_followingGuard).FindKernel((string)null) != 0)
		{
			_followingGuard.tag = (string)1;
			_followingGuard.PlayIntro();
			_followingGuard.MuteProximityLoop();
			_followingGuard.OnEnable();
			((HouseKeeper)(object)_followingGuard).OnAppHasRefreshed((RefreshType)0);
		}
	}

	public void DisableEnemy()
	{
		//IL_0010: Expected Obj, but got I4
		_followingGuard.tag = (string)1;
		_followingGuard.PlayIntro();
		_followingGuard.OnChangeTrack(Character.OnChangeTrackDirection.Right);
		((HouseKeeper)(object)_followingGuard).OnAppHasRefreshed(RefreshType.UI);
		_followingGuard.OnRoll();
	}

	public void EnableEnemy()
	{
		MonoBehaviour.print(_followingGuard);
		_followingGuard.MuteProximityLoop();
		_followingGuard.PlayIntro();
		_followingGuard.tag = null;
		((HouseKeeper)(object)_followingGuard).OnAppHasRefreshed((RefreshType)0);
	}

	public void LockGameSpeedTo(float gameSpeed = -1f)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 52)
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

	public void UnlockGameSpeed()
	{
		ResetEnemyForEnterPlay();
	}

	public void SetGameSpeed(float gameSpeed)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = IsInstantiated;
		_ = 1;
		((DizzyStarsHeightControl)this).HeightOffset = gameSpeed;
	}

	public void ResetGameSpeed()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = IsInstantiated;
		_ = 0;
	}

	public IEnumerator SkipRevive()
	{
		//IL_0019: Expected Obj, but got I4
		bool isPausedPowerups = _isPausedPowerups;
		return (IEnumerator)isPausedPowerups;
	}

	private void LoadFactories()
	{
		float heightOffset = UIExtensions.CenterChildrenHorizontally((Transform[])(object)this, 0f, (Transform)(object)_currentSpeedInfo);
		((DizzyStarsHeightControl)this).HeightOffset = heightOffset;
	}

	public void TriggerPause(bool pauseGame)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
	}

	public void RewardCoin()
	{
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_018c: Expected I, but got Obj
		//IL_01a2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		object obj = _menuFactories + 16;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!((UnityEngine.Object)obj != null))
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate(characterModelPreviewFactoryPrefab);
		throw new ArrayTypeMismatchException();
	}

	private IEnumerator EnableCharacterDayEventAnimation()
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

	private IEnumerator DebugRepeatedlySwipeLeftRightCoroutine()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private float Speed(float time, SpeedInfo speedInfo)
	{
		//IL_0017: Expected VT, but got Obj
		//IL_003e: Expected I4, but got Obj
		GameObject gameObject = base.gameObject;
		Transform transform = default;
		transform.position = (Vector3)gameObject;
		float z = time - (float)(nint)((UnityEngine.Object)transform).m_CachedPtr;
		return ((CurveParent)this).GetTimeForWorldZ(z, (byte)(int)speedInfo != 0);
	}

	public float GetSpeedAtTime(float t)
	{
		return t / __currentSpeed;
	}

	private IEnumerator StumbleDeathSequence()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = _isInStumbleDeathSequence;
		return (IEnumerator)flag;
	}

	private void HandleProductionInput(InputType inputType)
	{
		//IL_00a2: Expected VT, but got Obj
		//IL_00ab: Expected VT, but got Obj
		//IL_0017: Expected Obj, but got I4
		//IL_00c5: Expected F4, but got I
		//IL_00c5: Expected Obj, but got VT
		//IL_0089: Expected Obj, but got I4
		//IL_0030: Expected VT, but got Obj
		//IL_003e: Expected Obj, but got VT
		bool isPaused = (byte)(inputType & InputType.SwipeUp) != 0;
		_isPaused = isPaused;
		if (inputType != InputType.None)
		{
			bool isInitialized = AdSystemManager.isInitialized;
			((PokiUnitySDK)isInitialized).commercialBreak();
			ingameTouchDetection = false;
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((TimeScaleManager)val).TimeScaleInMenuDefault = 0f;
		}
		else
		{
			Variable<bool> isInGame = IsInGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v16 (Variable`1<System.Boolean>)+8]");
			if ((nint)0 != 0)
			{
				bool isInitialized2 = AdSystemManager.isInitialized;
				((PokiUnitySDK)isInitialized2).gameplayStop();
			}
			ingameTouchDetection = true;
			_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v13 (T)+14]");
			((TimeScaleManager)val2).TimeScaleInMenuDefault = 0f;
		}
		if (this.m_OnPauseChange != null)
		{
			bool isPaused2 = _isPaused;
			this.m_OnPauseChange(isPaused2);
		}
	}

	private void ToggleSwipeLeftRight()
	{
		int coinsWithJetpack = _gameStats.CoinsWithJetpack;
		_gameStats.CoinsCollectedRun = coinsWithJetpack;
		if (_character.IsJumpingHigher)
		{
			_gameStats.CoinsCollectedOnLeftTrackIncrement();
		}
		if (((Game)null).IsInPogostickMode)
		{
			_gameStats.CoinsWithPogoStickIncrement();
		}
		if (((Game)null).HasSuperSneakers)
		{
			_gameStats.CoinsInAirIncrement();
		}
		Character character = _character;
		if (character.__trackIndex != 0)
		{
			Character character2 = _character;
			if (character2.__trackIndex == 1)
			{
				_gameStats.CoinsCollectedOnRightTrackIncrement();
				return;
			}
			Character character3 = _character;
			if (character3.__trackIndex == 2)
			{
				_gameStats.CoinMagnetCountIncrement();
			}
		}
		else
		{
			_gameStats.CoinsCollectedOnCenterTrackIncrement();
		}
	}

	private void SimulateOnApplicationPause()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0061: Expected Obj, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I4
		if (_debugRepeatedlySwipeLeftRightCoroutine != null)
		{
			StopCoroutine((Coroutine)(object)_debugRepeatedlySwipeLeftRightCoroutine);
			object obj = this + 212;
			obj = 0;
		}
		else
		{
			object obj2 = this + 212;
			bool flag = ((Game)null).isInStumbleDeathSequence;
			obj2 = flag;
			Coroutine coroutine = StartCoroutine_Auto(_debugRepeatedlySwipeLeftRightCoroutine);
		}
	}

	private void SimulateOnApplicationFocus()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v6 (System.Boolean)+79]");
		bool flag3 = (nint)0 != 0;
		bool isApplicationFocused = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		((UIScreenController)flag).DebugSetApplicationFocus(isApplicationFocused);
	}

	public void ShowNextSceneViewCameraTargetType()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController uIScreenController = UIScreenController.Instance;
		if ((object)uIScreenController == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v6 (System.Boolean)+58]");
		bool flag3 = (nint)0 != 0;
		bool isApplicationPaused = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		((UIScreenController)flag).OnApplicationPause(isApplicationPaused);
	}

	public void ShowNextSceneViewZoomType()
	{
		//IL_0026: Expected VT, but got Obj
		//IL_000e: Expected VT, but got Obj
		//IL_0017: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (T)+14]");
		if ((nint)0 != 0)
		{
			_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((SceneViewWindowManager)val2).ShowNextSceneViewZoomType();
		}
	}

	private void HandleDebugInput(KeyCode keyCode)
	{
		//IL_0370: Expected Obj, but got I4
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_03a0: Expected Obj, but got I4
		//IL_00ea: Expected I, but got Obj
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I4
		//IL_03bc: Expected Obj, but got I4
		//IL_0178: Expected I, but got Obj
		//IL_01c5: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_03d8: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got I4
		//IL_0206: Expected I, but got Obj
		//IL_0253: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_03f4: Expected Obj, but got I4
		//IL_03f4: Expected Obj, but got I4
		//IL_0294: Expected I, but got Obj
		//IL_02e1: Expected I, but got Obj
		//IL_02f7: Expected Obj, but got I
		//IL_040b: Expected Obj, but got I4
		//IL_0322: Expected I, but got Obj
		object obj = keyCode - 1;
		if (keyCode != (KeyCode)1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj == 4 || (nint)obj != 5)
						{
							return;
						}
						nint num = (nint)typeof(GameStateMachine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v53 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num2 = (nint)typeof(GameStateMachine);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v59 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
						((GameStateMachine)useBenchmarkRoute).HandleCriticalHit();
						return;
					}
					nint num3 = (nint)typeof(GameStateMachine);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v42 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(GameStateMachine);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v48 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
					((MonobehaviourScheduler)useBenchmarkRoute2).RegisterUpdateHandler((Action)3);
					return;
				}
				nint num5 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v31 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(GameStateMachine);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v37 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool useBenchmarkRoute3 = RouteManager.UseBenchmarkRoute;
				((MonobehaviourScheduler)useBenchmarkRoute3).RegisterUpdateHandler((Action)2);
				return;
			}
			nint num7 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v20 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v26 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute4 = RouteManager.UseBenchmarkRoute;
			((MonobehaviourScheduler)useBenchmarkRoute4).RegisterUpdateHandler((Action)1);
			return;
		}
		nint num9 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute5 = RouteManager.UseBenchmarkRoute;
		((MonobehaviourScheduler)useBenchmarkRoute5).RegisterUpdateHandler(null);
	}

	private void AddModifierSafe(CharacterModifier characterModifier)
	{
		//IL_08ab: Expected I, but got Obj
		//IL_08c1: Expected Obj, but got I
		//IL_0942: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_026d: Expected I4, but got Obj
		//IL_05bf: Expected I, but got Obj
		//IL_05d5: Expected Obj, but got I
		//IL_08f7: Expected I4, but got Obj
		//IL_0600: Expected I, but got Obj
		//IL_06d7: Expected I4, but got Obj
		//IL_06f5: Expected I4, but got Obj
		//IL_07e9: Expected I4, but got Obj
		//IL_07fc: Expected I, but got Obj
		//IL_0812: Expected Obj, but got I
		//IL_091e: Expected Obj, but got I4
		//IL_0922: Expected VT, but got Obj
		//IL_083d: Expected I, but got Obj
		//IL_073b: Expected I4, but got Obj
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v86 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		IEnumerator enumerator = ((DeathState)useBenchmarkRoute).DelayGameOverScreen();
		if (enumerator == null)
		{
			return;
		}
		if ((nint)characterModifier < 47)
		{
			object obj2 = characterModifier - 32;
			if ((nint)characterModifier == 32)
			{
				CharacterModifierCollection modifiers = _modifiers;
				OnCriticalHit((Character.CriticalHitType)modifiers.hoverboard);
				return;
			}
			if ((nint)obj2 == 1 || (nint)obj2 == 2 || (nint)obj2 == 3 || (nint)obj2 == 4 || (nint)obj2 == 5 || (nint)obj2 == 6 || (nint)obj2 == 7 || (nint)obj2 == 8 || (nint)obj2 == 9 || (nint)obj2 == 10 || (nint)obj2 == 11)
			{
				return;
			}
			if ((nint)obj2 == 12)
			{
				goto IL_0887;
			}
			if ((nint)obj2 == 13 || (nint)obj2 != 14)
			{
				return;
			}
		}
		else
		{
			object obj3 = characterModifier - 60;
			if ((nint)characterModifier == 60)
			{
				goto IL_0887;
			}
			if ((nint)obj3 == 1 || (nint)obj3 != 2)
			{
				object obj4 = characterModifier - 97;
				if ((nint)characterModifier != 97)
				{
					if ((nint)obj4 == 1)
					{
						return;
					}
					if ((nint)obj4 != 2)
					{
						if ((nint)obj4 != 3)
						{
							if ((nint)obj4 != 4)
							{
								if ((nint)obj4 != 5)
								{
									if ((nint)obj4 == 6 || (nint)obj4 == 7 || (nint)obj4 == 8)
									{
										return;
									}
									if ((nint)obj4 != 9)
									{
										if ((nint)obj4 == 10 || (nint)obj4 == 11)
										{
											return;
										}
										if ((nint)obj4 != 12)
										{
											if ((nint)obj4 != 13)
											{
												if ((nint)obj4 != 14)
												{
													if ((nint)obj4 != 15)
													{
														if ((nint)obj4 != 16)
														{
															if ((nint)obj4 == 17)
															{
																return;
															}
															if ((nint)obj4 != 18)
															{
																if ((nint)obj4 == 19 || (nint)obj4 == 20 || (nint)obj4 == 21)
																{
																	return;
																}
																if ((nint)obj4 != 22)
																{
																	if ((nint)obj4 == 23)
																	{
																		if (!Input.GetKeyUp(KeyCode.LeftShift) && !Input.GetKeyUp(KeyCode.RightShift))
																		{
																			_modifiers.ExpireSoon();
																		}
																		else
																		{
																			_modifiers.Pause();
																		}
																	}
																}
																else
																{
																	Character character = _character;
																	character._characterCamera.ResetShake();
																}
															}
															else
															{
																CharacterModifierCollection modifiers2 = _modifiers;
																OnCriticalHit((Character.CriticalHitType)modifiers2.superSneakers);
															}
														}
														else if (pogoJumpsLeft == 0)
														{
															Character character2 = _character;
															Variable<bool> isGrounded = character2.IsGrounded;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v64 (Variable`1<System.Boolean>)+8]");
															if ((nint)0 != 0)
															{
																StartPogostick();
															}
														}
													}
													else
													{
														((Game)null).SimulateOnApplicationFocus();
													}
												}
												else
												{
													SimulateOnApplicationPause();
												}
												return;
											}
											nint num3 = (nint)typeof(GameStateMachine);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v44 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
											object obj5 = (nint)0 & (nint)0x200;
											if (obj5 != null)
											{
												nint num4 = (nint)typeof(GameStateMachine);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v52 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
											_0021_00210 val = (_0021_00210)((StateMachine)useBenchmarkRoute2).TryGetCurrentState<T>();
											if ((int)val == 0)
											{
												Die();
											}
										}
										else
										{
											CharacterModifierCollection modifiers3 = _modifiers;
											OnCriticalHit((Character.CriticalHitType)modifiers3.coinMagnet);
										}
									}
									else if (!((Game)null).IsInPogostickMode)
									{
										((Game)null).PickupPogostick();
									}
								}
								else
								{
									((Game)null).ShowNextSceneViewCameraTargetType();
								}
							}
							else
							{
								CharacterModifierCollection modifiers4 = _modifiers;
								OnCriticalHit((Character.CriticalHitType)modifiers4.doubleScoreMultiplier);
							}
						}
						else
						{
							CharacterModifierCollection modifiers5 = _modifiers;
							OnCriticalHit((Character.CriticalHitType)modifiers5.doubleJump);
						}
					}
					else
					{
						ToggleSwipeLeftRight();
					}
					return;
				}
				nint num5 = (nint)typeof(MysteryPowerup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v26 (Il2CppClass<MysteryPowerup>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(MysteryPowerup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v31 (Il2CppClass<MysteryPowerup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<Boards.BoardId> randomBoardList = MysteryPowerup.GetRandomBoardList();
				OnCriticalHit((Character.CriticalHitType)randomBoardList);
				return;
			}
		}
		((RouteTransitionState)null).Initialize();
		return;
		IL_0887:
		((Game)null).ShowNextSceneViewZoomType();
	}

	private void InputManager_OnInputEvent(object sender, InputEventArgs inputEventArgs)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 12;
		obj = inputEventArgs;
		_ = inputEventArgs._inputType;
		object obj3 = this + 20;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj = sender;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+8]");
		_ = 0;
		object obj4 = this + 32;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj = sender;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+8]");
		_ = 0;
		object obj5 = this + 8;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v36 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = this + 44;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
	}

	private void CoinManager_OnCoinCollected(object sender, EventArgs args)
	{
		//IL_003a: Expected Obj, but got I
		if (~(_isPaused ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
			object obj = -1;
			if ((nint)obj < 6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
				((Game)null).HandleDebugInput(KeyCode.None);
			}
		}
	}

	public unsafe void OnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected VT, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0427: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_02c0: Expected I, but got Obj
		//IL_02d6: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_05fe: Expected native int or pointer, but got Obj
		//IL_060c: Expected Obj, but got I4
		//IL_0301: Expected I, but got Obj
		//IL_034e: Expected I, but got Obj
		//IL_0364: Expected Obj, but got I
		//IL_00f2: Expected I, but got Obj
		//IL_0576: Expected Obj, but got I
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected Obj, but got Unknown
		//IL_05a6: Expected I, but got Obj
		//IL_05bc: Expected Obj, but got I
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04f4: Expected I, but got Obj
		//IL_050a: Expected Obj, but got I
		//IL_038f: Expected I, but got Obj
		//IL_0491: Expected Obj, but got I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected Obj, but got Unknown
		//IL_01ee: Expected I, but got Obj
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_017d: Expected native int or pointer, but got VT
		//IL_0192: Expected native int or pointer, but got VT
		//IL_0235: Expected native int or pointer, but got VT
		//IL_024a: Expected native int or pointer, but got VT
		//IL_0286: Expected native int or pointer, but got VT
		//IL_029b: Expected native int or pointer, but got VT
		object obj = default;
		SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer hierarchyDepthContainer = (SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer)(obj + 24);
		object obj2 = obj + 12;
		obj2 = 0;
		_ = 0;
		if (verticalHit == Character.StumbleVerticalHit.Upper)
		{
			return;
		}
		Coroutine coroutine = StartCoroutine((string)stumbleType, horizontalHit);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = coroutine + 12;
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)obj3);
		object obj4 = default;
		object obj12 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			object obj5 = coroutine + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			string text = ((Component)obj7).tag;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v80 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)(object)text != this)
			{
				if (colliderName != null)
				{
					obj = 0;
					_ = 0;
					obj = obj7;
					_ = 0;
					_ = list._size;
					System.Runtime.CompilerServices.Unsafe.Write(&((SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer*)(nint)hierarchyDepthContainer)->Component, obj);
					SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer hierarchyDepthContainer2 = hierarchyDepthContainer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer*)(nint)hierarchyDepthContainer2)->Index = 0;
					((List<SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer>)(object)list).Add(hierarchyDepthContainer);
				}
			}
			else
			{
				obj2 = obj7;
				_ = 0;
				_ = list._size;
				GameObject gameObject = ((Component)obj7).gameObject;
				GameObject gameObject2 = gameObject;
				int num5;
				do
				{
					object obj9 = obj2 + 4;
					object obj10 = obj9 + 1;
					obj9 = obj10;
					Transform parentInternal = ((Transform)(object)gameObject2).parentInternal;
					int layer = ((GameObject)(object)this).layer;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v104 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v120 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					num5 = ((ComputeShader)(object)parentInternal).FindKernel((string)layer);
					gameObject2 = (GameObject)(object)parentInternal;
				}
				while (num5 != 0);
				System.Runtime.CompilerServices.Unsafe.Write(&((SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer*)(nint)hierarchyDepthContainer)->Component, obj2);
				SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer hierarchyDepthContainer3 = hierarchyDepthContainer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer*)(nint)hierarchyDepthContainer3)->Index = 0;
				if (hierarchyDepthContainer.HierarchyCount <= (safeStumble ? 1 : 0))
				{
					System.Runtime.CompilerServices.Unsafe.Write(&((SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer*)(nint)hierarchyDepthContainer)->Component, obj2);
					SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer hierarchyDepthContainer4 = hierarchyDepthContainer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer*)(nint)hierarchyDepthContainer4)->Index = 0;
					((List<SYBO.Common.Utilities.GameObjectUtil.HierarchyDepthContainer>)(object)list).Add(hierarchyDepthContainer);
				}
			}
			obj4 = obj12 + 1;
		}
		nint num6 = (nint)typeof(SYBO.Common.Utilities.GameObjectUtil._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v25 (Il2CppClass<SYBO.Common.Utilities.GameObjectUtil+<>c>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num7 = (nint)typeof(SYBO.Common.Utilities.GameObjectUtil._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v72 (Il2CppClass<SYBO.Common.Utilities.GameObjectUtil+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = SYBO.Common.Utilities.GameObjectUtil._003C_003Ec._003C_003E9__43_0 == null;
		bool flag2 = !flag;
		Queue<_00210> q = (Queue<_00210>)(object)SYBO.Common.Utilities.GameObjectUtil._003C_003Ec._003C_003E9__43_0;
		if (!flag2)
		{
			nint num8 = (nint)typeof(SYBO.Common.Utilities.GameObjectUtil._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v46 (Il2CppClass<SYBO.Common.Utilities.GameObjectUtil+<>c>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num9 = (nint)typeof(SYBO.Common.Utilities.GameObjectUtil._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v66 (Il2CppClass<SYBO.Common.Utilities.GameObjectUtil+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num10 = 0;
			Queue<_00210> queue = default;
			queue._array = (_00210[])num10;
			queue._size = 0;
			object obj15 = queue + 16;
			obj15 = SYBO.Common.Utilities.GameObjectUtil._003C_003Ec._003C_003E9;
			nint num11 = (nint)typeof(SYBO.Common.Utilities.GameObjectUtil._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v63 (Il2CppClass<SYBO.Common.Utilities.GameObjectUtil+<>c>)+5C]");
			object obj16 = (nint)0 + (nint)4;
			obj16 = queue;
			q = queue;
		}
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)list, new Queue<T>.Enumerator((Queue<T>)(object)q));
		object obj17 = 0;
		while ((nint)obj17 < list._size)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			object obj18 = obj17 + 1;
			obj17 = obj18;
		}
	}

	public void OnCriticalHit(Character.CriticalHitType type)
	{
		//IL_05ad: Expected VT, but got Obj
		//IL_05ba: Expected Obj, but got VT
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_05ed: Expected Obj, but got I4
		//IL_0622: Expected I, but got Obj
		//IL_0638: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_078a: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_0229: Expected I, but got Obj
		//IL_023f: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_068b: Expected Obj, but got I4
		//IL_00ec: Expected I, but got Obj
		//IL_02ec: Expected I, but got Obj
		//IL_0302: Expected Obj, but got I
		//IL_026a: Expected I, but got Obj
		//IL_06ba: Expected Obj, but got I4
		//IL_038c: Expected I, but got Obj
		//IL_03a2: Expected Obj, but got I
		//IL_032d: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got I4
		//IL_06f3: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I4
		//IL_042c: Expected I, but got Obj
		//IL_0442: Expected Obj, but got I
		//IL_03cd: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I4
		//IL_072c: Expected Obj, but got I4
		//IL_0419: Expected Obj, but got I4
		//IL_04ef: Expected I, but got Obj
		//IL_0505: Expected Obj, but got I
		//IL_046d: Expected I, but got Obj
		//IL_075b: Expected Obj, but got I4
		//IL_0591: Expected Obj, but got I4
		//IL_0530: Expected I, but got Obj
		//IL_04d2: Expected Obj, but got I4
		//IL_057e: Expected Obj, but got I4
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Route routePrefab = ((RouteManager)val).GetRoutePrefab((RouteType)type);
		if ((object)routePrefab == null)
		{
			return;
		}
		CharacterModifierCollection modifiers = _modifiers;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v147 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)type != modifiers.hoverboard)
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v127 (Il2CppClass<Globals>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v141 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_DISABLE_HOVERBOARD ? 1u : 0u) != 0)
			{
				CharacterModifierCollection modifiers2 = _modifiers;
				Hoverboard hoverboard = modifiers2.hoverboard;
				if (!hoverboard.isActive)
				{
					_modifiers.RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)type);
				}
				return;
			}
		}
		CharacterModifierCollection modifiers3 = _modifiers;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v122 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)type != modifiers3.superSneakers)
		{
			if (!((Game)null).IsInPogostickMode && !((Game)null).HasSuperSneakers)
			{
				string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
				((GameStats)(object)privacyPolicyUrl).PogoStickPickupsCollectedIncrement();
				_modifiers.RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)type);
			}
			return;
		}
		CharacterModifierCollection modifiers4 = _modifiers;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v110 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)type != modifiers4.doubleScoreMultiplier)
		{
			string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
			((GameStats)(object)privacyPolicyUrl2).HuntTokensCollectedIncrement();
			_modifiers.RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)type);
			return;
		}
		CharacterModifierCollection modifiers5 = _modifiers;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v102 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (UnityEngine.Object)type != modifiers5.doubleCoins;
		CharacterModifierCollection modifiers6 = _modifiers;
		if (flag)
		{
			modifiers6.RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)type);
			return;
		}
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v97 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = (UnityEngine.Object)type != modifiers6.plusMultiplier;
		CharacterModifierCollection modifiers7 = _modifiers;
		if (flag2)
		{
			modifiers7.RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)type);
			return;
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v63 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)type != modifiers7.coinMagnet)
		{
			string privacyPolicyUrl3 = Globals.GetPrivacyPolicyUrl();
			((GameStats)(object)privacyPolicyUrl3).MysteryBoxPickupsCollectedInrement();
			_modifiers.RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)type);
			return;
		}
		CharacterModifierCollection modifiers8 = _modifiers;
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S0_v73 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v84 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)type != modifiers8.doubleJump)
		{
			_modifiers.RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)type);
			return;
		}
		string msg = "Add an 'if-else' for : " + (string)type;
		SDebug.LogFormat(msg, null);
	}

	static Game()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)Game.m_OnMenuScreenShown);
	}

	private void _003CAwake_003Eb__154_1(bool value)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<So>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)(object)DieSound, false);
		nint num3 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		((MonobehaviourScheduler)useBenchmarkRoute)._002Ector();
	}
}
