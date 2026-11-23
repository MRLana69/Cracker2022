using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Cameras;
using SYBO.Subway.Coins;
using SYBO.Subway.Inputs;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Characters.States;

public class PogoStickState : CharacterState
{
	[Serializable]
	public class PickupWeight
	{
		public PowerupType PowerupType;

		public PickupType PickupType;
	}

	[Serializable]
	public class MovementCurve
	{
		public AnimationCurve curve;
	}

	public delegate void OnStartDelegate();

	public delegate void OnReachedTopDelegate();

	public delegate void OnStopDelegate();

	private sealed class _003CBegin_003Ed__43(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PogoStickState _003C_003E4__this;

		private Vector3 _003CstartPosition_003E5__2;

		private Vector3 _003CendPosition_003E5__3;

		private float _003Cspeed_003E5__4;

		private Vector3 _003CcameraPositionStart_003E5__5;

		private Vector3 _003CCameraTargetStartOffset_003E5__6;

		private Vector3 _003CcameraOffset_003E5__7;

		private Vector3 _003CstartCameraOffset_003E5__8;

		private SmoothDampFloat _003CsmoothCameraX_003E5__9;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0a68: Invalid comparison between F4 and I
			//IL_0aa0: Expected I, but got Obj
			//IL_0c56: Expected F4, but got I
			//IL_0c51: Expected native int or pointer, but got VT
			//IL_0c75: Expected F4, but got I
			//IL_0c70: Expected native int or pointer, but got VT
			//IL_0ca1: Expected VT, but got F4
			//IL_0d0e: Expected VT, but got F4
			//IL_0e3f: Expected Obj, but got I
			//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef4: Expected Obj, but got Unknown
			//IL_0f2d: Expected Obj, but got I
			//IL_0fb0: Expected I, but got Obj
			//IL_1081: Expected VT, but got F4
			//IL_10a0: Expected VT, but got F4
			//IL_113b: Expected Obj, but got F4
			//IL_1143: Unknown result type (might be due to invalid IL or missing references)
			//IL_1148: Expected Obj, but got Unknown
			object obj = default;
			Vector3 vector = (Vector3)(obj - 96);
			PogoStickState pogoStickState = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Character character = pogoStickState._character;
					float z = character.z;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+28]");
					if (!(z < 0f))
					{
						pogoStickState.EndPogo();
					}
					else
					{
						float deltaTime = Time.deltaTime;
						float num = _003Cspeed_003E5__4 * deltaTime;
						float z2 = character.z + num;
						character.z = z2;
						Character character2 = pogoStickState._character;
						float num2 = character2.z;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+1C]");
						float num3 = num2 - 0f;
						Character character3 = pogoStickState._character;
						Vector3 position = Route.GetPosition(character3.x, character3.z);
						nint num4 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num5 = 0;
						MovementCurve jumpCurve = pogoStickState.jumpCurve;
						float num6 = num3 / pogoStickState.jumpDistance;
						float num7 = jumpCurve.curve.Evaluate(num6);
						float num8 = (float)Vector3.upVector * num7;
						float num9 = num8 * pogoStickState.jumpHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
						float num10 = 0f + num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
						float num11 = 0f * num7;
						float num12 = num11 * pogoStickState.jumpHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
						float num13 = 0f + num12;
						bool flag = !(pogoStickState.fadeInPosition < num6);
						bool flag2 = !flag;
						float num14 = num13;
						if (!flag2)
						{
							float num15 = num13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+18]");
							float num16 = num15 - 0f;
							float num17 = num6 / pogoStickState.fadeInPosition;
							float num18 = Math.Min(num17, 1f);
							bool flag3 = num17 < 0f;
							float num19 = 0f;
							if (!flag3)
							{
								num19 = num18;
							}
							float num20 = num16 * num19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+18]");
							float num21 = 0f + num20;
							num14 = num21;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
						float num22 = 0f * num7;
						float num23 = num22 * pogoStickState.jumpHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
						float num24 = 0f + num23;
						if (num6 > pogoStickState.hangtimePosition && !pogoStickState._reachedHangtime)
						{
							OnStartDelegate onHangtime = pogoStickState.OnHangtime;
							if (pogoStickState.OnHangtime != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v377.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							}
							pogoStickState._reachedHangtime = true;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
						((Vector3*)(nint)vector)->z = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
						((Vector3*)(nint)vector)->x = 0f;
						pogoStickState._characterTransform.position = vector;
						CharacterCamera characterCamera = pogoStickState._characterCamera;
						characterCamera._target = (Vector3)num10;
						float num25 = num10 + (float)_003CcameraOffset_003E5__7;
						float num26 = num14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+4C]");
						float num27 = num26 + 0f;
						CharacterCamera characterCamera2 = pogoStickState._characterCamera;
						float num28 = num24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+50]");
						float num29 = num28 + 0f;
						characterCamera2._position = (Vector3)num25;
						Transform transform = pogoStickState._character.transform;
						Vector3 position2 = transform.position;
						_003CsmoothCameraX_003E5__9.Update();
						SmoothDampFloat smoothDampFloat = _003CsmoothCameraX_003E5__9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
						float target = 0f * 0.75f;
						smoothDampFloat._target = target;
						MovementCurve cameraCurve = pogoStickState.cameraCurve;
						float num30 = cameraCurve.curve.Evaluate(num6);
						float num31 = Math.Min(num6, 1f);
						bool flag4 = num6 < 0f;
						float num32 = 0f;
						if (!flag4)
						{
							num32 = num31;
						}
						float num33 = num32 * -2f;
						float num34 = num33 * num32;
						float num35 = num34 * num32;
						float num36 = num32 * 3f;
						float num37 = num36 * num32;
						float num38 = num35 + num37;
						float num39 = num38 * 1f;
						float num40 = 1f - num38;
						float num41 = num40 * 0f;
						float num42 = num39 + num41;
						float num43 = Math.Min(num42, 1f);
						bool flag5 = num42 < 0f;
						float num44 = 0f;
						if (!flag5)
						{
							num44 = num43;
						}
						SmoothDampFloat smoothDampFloat2 = _003CsmoothCameraX_003E5__9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+4C]");
						nint num45 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+58]");
						object obj2 = num45 - 0;
						float num46 = (float)obj2 * num44;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+58]");
						float num47 = 0f + num46;
						float num48 = num14 + num47;
						float num49 = num48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+34]");
						float num50 = num49 - 0f;
						float num51 = Math.Min(num30, 1f);
						bool flag6 = num30 < 0f;
						float num52 = 0f;
						if (!flag6)
						{
							num52 = num51;
						}
						float num53 = num50 * num52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+34]");
						float num54 = 0f + num53;
						object obj3 = this - -64;
						float num55 = num54 - (float)obj3;
						Character character4 = pogoStickState._character;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+50]");
						nint num56 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+5C]");
						object obj4 = num56 - 0;
						float num57 = (float)obj4 * num44;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+5C]");
						float num58 = 0f + num57;
						float num59 = character4.z + num58;
						float num60 = num59;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.PogoStickState+<Begin>d__43)+44]");
						float num61 = num60 - 0f;
						Transform transform2 = pogoStickState._character.transform;
						Vector3 position3 = transform2.position;
						nint num62 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ S0_v118 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num63 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ S0_v119 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
						float num64 = 0f * pogoStickState.cameraAimOffset;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
						float num65 = 0f + num64;
						MovementCurve cameraAimFollowCurve = pogoStickState.cameraAimFollowCurve;
						float num66 = cameraAimFollowCurve.curve.Evaluate(num6);
						float num67 = Math.Min(num66, 1f);
						bool flag7 = num66 < 0f;
						float num68 = 0f;
						if (!flag7)
						{
							num68 = num67;
						}
						SmoothDampFloat smoothDampFloat3 = _003CsmoothCameraX_003E5__9;
						CharacterCamera characterCamera3 = pogoStickState._characterCamera;
						characterCamera3._position = (Vector3)smoothDampFloat2._value;
						CharacterCamera characterCamera4 = pogoStickState._characterCamera;
						characterCamera4._target = (Vector3)smoothDampFloat3._value;
						float num69 = num65 - num55;
						float num70 = num69 * num68;
						float num71 = num55 + num70;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ S0_v119 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
						float num72 = 0f * pogoStickState.cameraAimOffset;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
						float num73 = 0f + num72;
						float num74 = num73 - num61;
						float num75 = num74 * num68;
						float num76 = num61 + num75;
						object obj5 = num76 << 32;
						object obj6 = num71 | obj5;
						pogoStickState._game.UpdateMeters();
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
					}
				}
				return true;
			}
			_003C_003E1__state = -1;
			pogoStickState.isActive = true;
			pogoStickState._game.ResetEnemy();
			Character character5 = pogoStickState._character;
			character5.inAirJump = false;
			throw new NullReferenceException();
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

	private sealed class _003CRemovePickups_003Ed__47(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PogoStickState _003C_003E4__this;

		public float endPosition;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0094: Expected VT, but got Obj
			//IL_00b8: Expected Obj, but got VT
			//IL_00de: Expected VT, but got Obj
			//IL_0102: Expected Obj, but got VT
			if (_003C_003E1__state < 2)
			{
				PogoStickState pogoStickState = _003C_003E4__this;
				_003C_003E1__state = -1;
				Character character = pogoStickState._character;
				float num = endPosition + 100f;
				if (character.z < num)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				if (pogoStickState._pickupSpawnPointPrefabInstance != null)
				{
					_00210 val = (_00210)SingletonMonobehavior<>.Instance;
					Transform transform = pogoStickState._pickupSpawnPointPrefabInstance.transform;
					if (((PickupManager)val).IsSpawned(transform))
					{
						_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
						Transform transform2 = pogoStickState._pickupSpawnPointPrefabInstance.transform;
						((PickupManager)val2).Despawn(transform2);
						pogoStickState._pickupSpawnPointPrefabInstance = null;
					}
				}
				CoinStats coinStats = CoinStats.New;
				int num2 = coinStats.DynamicCoinDespawns__BackingField + pogoStickState._dynamicCoinsSpawned;
				coinStats.DynamicCoinDespawns__BackingField = num2;
				pogoStickState._dynamicCoinsSpawned = 0;
			}
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

	private int rows = 5;

	private int startRowPosition;

	private int endRowPosition = 1;

	private PickupWeight[] _pickupList;

	public bool isActive;

	public AudioClipInfo powerDownSound;

	public float cameraAimOffset = 20f;

	public float jumpHeight;

	public float jumpDistance = 800f;

	public float characterChangeTrackLength;

	public PowerupType powerType = PowerupType.pogostick;

	public ActivePowerup Powerup;

	public MovementCurve jumpCurve;

	public MovementCurve cameraCurve;

	public MovementCurve cameraAimFollowCurve;

	public float smoothCameraXDuration = 0.05f;

	public float topPosition;

	public float fadeInPosition = 0.1f;

	public float hangtimePosition;

	public float finalJumpSpeed;

	public OnStartDelegate OnStart;

	public OnStartDelegate OnHangtime;

	public OnStopDelegate OnStop;

	private int _dynamicCoinsSpawned;

	private Transform _characterTransform;

	private Transform _characterCameraTransform;

	private Animation _characterAnimation;

	private PickupType[] _pickupWeightedList;

	private float _characterAimOffset;

	private bool _reachedHangtime;

	private GameObject _pickupSpawnPointPrefabInstance;

	private static PogoStickState instance;

	public override bool WillPauseActiveModifiers => true;

	public static PogoStickState Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			PogoStickState result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(PogoStickState));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				PogoStickState pogoStickState = default;
				instance = pogoStickState;
				result = pogoStickState;
			}
			return result;
		}
	}

	protected unsafe override void Awake()
	{
		//IL_0087: Expected Obj, but got I4
		//IL_0090: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I4
		//IL_01f9: Expected Obj, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		base.Awake();
		Action action = default;
		action._002Ector(this, (nint)__ldftn(PogoStickState.HandleOnStageMenu));
		_game.OnStageMenuSequence += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(PogoStickState.Game_OnCharacterModelRecreated));
		_game.OnCharacterModelRecreated += action2;
		Transform characterTransform = _characterController.transform;
		_characterTransform = characterTransform;
		Transform characterCameraTransform = _characterCamera.transform;
		_characterCameraTransform = characterCameraTransform;
		PickupWeight[] pickupList = _pickupList;
		object obj = 0;
		object obj2 = 0;
		while (pickupList.Length > (nint)obj)
		{
			object obj3 = obj << 2;
			object obj4 = (object)pickupList + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v57+10]");
			object obj5 = 0;
			Dictionary<PowerupType, Upgrade> upgrades = Upgrades.upgrades;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v58+8]");
			Upgrade upgrade = upgrades.get_Item(PowerupType._notset);
			object obj6 = upgrade.spawnProbability + obj2;
			object obj7 = obj + 1;
			obj = obj7;
			obj2 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		PickupType[] pickupWeightedList = default;
		_pickupWeightedList = pickupWeightedList;
		object obj8 = 0;
		while (true)
		{
			PickupWeight[] pickupList2 = _pickupList;
			bool flag = pickupList2.Length > (nint)obj8;
			bool flag2 = !flag;
			object obj9 = 0;
			if (flag2)
			{
				break;
			}
			while (true)
			{
				object obj10 = obj8 << 2;
				object obj11 = (object)_pickupList + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v23+10]");
				object obj12 = 0;
				Dictionary<PowerupType, Upgrade> upgrades2 = Upgrades.upgrades;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v24+8]");
				Upgrade upgrade2 = upgrades2.get_Item(PowerupType._notset);
				if (upgrade2.spawnProbability <= (nint)obj9)
				{
					break;
				}
				object obj13 = 0 << 2;
				object obj14 = (object)_pickupWeightedList + obj13;
				object obj15 = obj8 << 2;
				object obj16 = (object)_pickupList + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v32+10]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v33+C]");
				_ = 0;
				object obj18 = obj9 + 1;
				obj9 = obj18;
			}
			object obj19 = obj8 + 1;
			obj8 = obj19;
		}
	}

	private void Game_OnCharacterModelRecreated()
	{
	}

	public override IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void HandleSwipe(SwipeDir swipeDir)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = swipeDir - 1;
		if (swipeDir != SwipeDir.Down)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					Game game = _game;
					float duration = characterChangeTrackLength / game.__currentSpeed;
					_character.ChangeTrackBy(1, duration);
				}
			}
			else
			{
				Game game2 = _game;
				float duration2 = characterChangeTrackLength / game2.__currentSpeed;
				_character.ChangeTrackBy(-1, duration2);
			}
		}
		else
		{
			EndPogo();
			_character.Roll();
		}
	}

	public void StopHack()
	{
		isActive = false;
		OnStopDelegate onStop = OnStop;
		if (OnStop != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void EndPogo()
	{
		isActive = false;
		_characterController.detectCollisions = true;
		RunningState runningState = RunningState.Instance;
		runningState.transitionFromPogostick = true;
		RunningState runningState2 = _game.RunningState;
		_game.CharacterState = runningState2;
		if (!_character.IsGliderboard)
		{
			Character character = _character;
			float verticalSpeed = _character.CalculateJumpVerticalSpeed(finalJumpSpeed);
			character.verticalSpeed = verticalSpeed;
		}
		Game game = _game;
		game._modifiers.Resume();
		OnStopDelegate onStop = OnStop;
		if (OnStop != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		_reachedHangtime = false;
	}

	private IEnumerator RemovePickups(float endPosition)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void HandleOnStageMenu()
	{
		SetActiveForPickupPrefabInstance(isActive: false);
	}

	private void SetActiveForPickupPrefabInstance(bool isActive)
	{
		if (_pickupSpawnPointPrefabInstance != null)
		{
			_pickupSpawnPointPrefabInstance.SetActive(isActive);
		}
	}

	private unsafe void SpawnCoinRow(float z, float height)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00df: Expected VT, but got Obj
		//IL_002d: Expected F4, but got I
		//IL_0028: Expected native int or pointer, but got VT
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		//IL_0068: Expected F4, but got I
		//IL_0063: Expected native int or pointer, but got VT
		//IL_0076: Expected Obj, but got VT
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		object obj2 = default;
		object obj5 = default;
		while ((nint)obj2 < 3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj3 = obj2 - 1;
			object obj4 = obj3 * 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			Coin coin = ((CoinManager)val).SpawnCoin(vector);
			CoinStats coinStats = CoinStats.New;
			int num = coinStats.DynamicCoinSpawns__BackingField + 1;
			coinStats.DynamicCoinSpawns__BackingField = num;
			int dynamicCoinsSpawned = _dynamicCoinsSpawned + 1;
			_dynamicCoinsSpawned = dynamicCoinsSpawned;
			obj2 = obj5 + 1;
		}
	}

	private void NotifyOnStart()
	{
		OnStartDelegate onStart = OnStart;
		if (OnStart != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyHangtime()
	{
		OnStartDelegate onHangtime = OnHangtime;
		if (OnHangtime != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnStop()
	{
		OnStopDelegate onStop = OnStop;
		if (OnStop != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static bool IsAPogoStickPickup(GameObject go)
	{
		string text = go.name;
		string text2 = text.ToLower();
		return text2.Contains("pogo");
	}

	public PogoStickState()
	{
		//IL_0051: Expected I4, but got I8
	}
}
