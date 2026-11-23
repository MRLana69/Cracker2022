using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Characters;
using SYBO.Subway.Characters.States;
using UnityEngine;

namespace SYBO.Subway.Coins;

public class CoinCurve : MonoBehaviour
{
	public enum CoinSpaceMode
	{
		NonStraight,
		Straight
	}

	public enum ScaleMode
	{
		NoScale,
		PreserveSpacing,
		ScaleSpacing
	}

	public const float TOP_LEVEL_HEIGHT_THRESHOLD = 70f;

	public const float StraightSpacing = 30f;

	public const float NonStraightSpacing = 15f;

	private CurveParent _curveParent;

	private ScaleMode _scaleMode;

	private CoinSpaceMode _spacingMode;

	private float _curveOffset;

	private int _coinIndexToSkip = -1;

	private bool _redistributeAlongCurveOnSpeedChange = true;

	private bool _debugIsMovingTrain;

	private CoinManager _coinManager;

	private Character _character;

	private TrackObject _trackObject;

	private List<Coin> _placedCoins;

	private Game _game;

	private bool _allCoinsActive;

	private int _coinsAtSpawn;

	private bool _activating;

	private int lastSpawnedCoinIndex;

	private float SpeedForCurve
	{
		get
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_009b: Expected F4, but got Obj
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected Obj, but got Unknown
			if (_game != null)
			{
				bool isPlaying = Application.isPlaying;
				Game game = _game;
				object obj = ((!isPlaying) ? ((object)(game.speed + 8)) : ((object)(game + 52)));
				return (float)obj;
			}
			return 110f;
		}
	}

	private float UnscaledCoinSpacing
	{
		get
		{
			bool flag = _spacingMode == CoinSpaceMode.Straight;
			float result = 30f;
			if (!flag)
			{
				result = 15f;
			}
			return result;
		}
	}

	private bool IsOnTopLevel
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0059: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 - 16;
			do
			{
				GameObject gameObject = base.gameObject;
				if (!(gameObject != null))
				{
					break;
				}
				Transform transform = base.transform;
				Vector3 position = transform.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			}
			while (0f > 70f);
			return true;
		}
	}

	protected unsafe void Awake()
	{
		//IL_002a: Expected VT, but got Obj
		//IL_0034: Expected Obj, but got VT
		Game instance = Game.Instance;
		_game = instance;
		Game game = _game;
		Game.SpeedInfo speed = game.speed;
		int capacity = NumberOfCoins(speed.max);
		List<Coin> list = default;
		list._002Ector(capacity);
		_placedCoins = list;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_coinManager = (CoinManager)val;
		TrackObject component = GetComponent<TrackObject>();
		_trackObject = component;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(CoinCurve.TrackObject_OnActivate));
		_trackObject.OnActivate += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(CoinCurve.TrackObject_OnDeactivate));
		_trackObject.OnDeactivate += action2;
		_trackObject.PropagateActivationStateToChildren = true;
		Character instance2 = Character.Instance;
		_character = instance2;
		_curveParent.ForceLinearZ(v: true);
		throw new ArgumentException();
	}

	protected void OnValidate()
	{
		_curveParent.ForceLinearZ(v: true);
	}

	private unsafe Vector3 GetCoinPosition(int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0049: Expected F4, but got I
		//IL_0044: Expected native int or pointer, but got VT
		//IL_0056: Expected F4, but got Obj
		//IL_0051: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		float speedForCurve = SpeedForCurve;
		Vector3 coinPosition = GetCoinPosition(index, speedForCurve);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		return vector;
	}

	private unsafe Vector3 GetCoinPosition(int index, float speed, bool speedChanged = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0114: Expected F4, but got I
		//IL_010f: Expected native int or pointer, but got VT
		//IL_0121: Expected F4, but got Obj
		//IL_011c: Expected native int or pointer, but got VT
		//IL_00a1: Expected Obj, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected I4, but got Unknown
		//IL_00b6: Expected F4, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		if (!(_curveParent == null))
		{
			int num = NumberOfCoinsIgnoringSkip(speed);
			if (num > 1)
			{
				float t;
				if (~(_redistributeAlongCurveOnSpeedChange ? 1u : 0u) == 0 && speedChanged)
				{
					object obj3 = _coinsAtSpawn - 1;
					int num2 = index / obj3;
					t = num2;
				}
				else
				{
					float num3 = CoinSpacing(speed);
					float num4 = (float)index * num3;
					float num5 = LengthOfCurve(speed);
					t = num4 / num5;
				}
				Vector3 vector = EvaluateCurve(t, speed);
				goto IL_00ff;
			}
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		goto IL_00ff;
		IL_00ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Vector3 vector2 = default;
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj;
		return vector2;
	}

	private unsafe Vector3 EvaluateCurve(float t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Expected F4, but got I
		//IL_003f: Expected native int or pointer, but got VT
		//IL_0051: Expected F4, but got Obj
		//IL_004c: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		float speedForCurve = SpeedForCurve;
		Vector3 vector = EvaluateCurve(t, speedForCurve);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Vector3 vector2 = default;
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj;
		return vector2;
	}

	private unsafe Vector3 EvaluateCurve(float t, float speed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_0177: Expected native int or pointer, but got VT
		//IL_0189: Expected F4, but got Obj
		//IL_0184: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		float minTime = _curveParent.MinTime;
		Vector3 worldPositionForTime = _curveParent.GetWorldPositionForTime(minTime);
		float maxTime = _curveParent.MaxTime;
		Vector3 worldPositionForTime2 = _curveParent.GetWorldPositionForTime(maxTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = num - 0;
		float num2 = (float)obj3 * t;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float z = 0f + num2;
		float timeForWorldZ = _curveParent.GetTimeForWorldZ(z, clampForInvalidTime: true);
		Vector3 worldPositionForTime3 = _curveParent.GetWorldPositionForTime(timeForWorldZ, clampForInvalidTime: true);
		float num3 = speed / 110f;
		if (_scaleMode == ScaleMode.NoScale)
		{
			num3 = 1f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj4 = num4 - 0;
		float num5 = t - _curveOffset;
		float num6 = (float)obj4 * num5;
		float num7 = num3 * num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float z2 = 0f + num7;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = z2;
		((Vector3*)(nint)vector)->x = (float)obj;
		return vector;
	}

	private unsafe void RepositionCoins(float speed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0040: Expected Obj, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
		//IL_0117: Expected F4, but got I
		//IL_0112: Expected native int or pointer, but got VT
		//IL_012c: Expected F4, but got I
		//IL_0127: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (~(_redistributeAlongCurveOnSpeedChange ? 1u : 0u) != 0)
		{
			ResizeIfNeeded(speed);
		}
		List<Coin> placedCoins = _placedCoins;
		object obj2 = _coinsAtSpawn - placedCoins._size;
		int num = 0;
		while (true)
		{
			List<Coin> placedCoins2 = _placedCoins;
			if (num >= placedCoins2._size)
			{
				break;
			}
			int num2 = num + obj2;
			bool flag = IsSkippingCoin(speed);
			bool flag2 = !flag;
			int index = num;
			if (!flag2)
			{
				bool flag3 = num <= _coinIndexToSkip;
				index = num;
				if (!flag3)
				{
					index = num - 1;
				}
			}
			if (_coinIndexToSkip != num2)
			{
				Coin coin = _placedCoins.get_Item(index);
				Transform transform = coin.transform;
				Vector3 coinPosition = GetCoinPosition(num2, speed, speedChanged: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				transform.position = vector;
			}
			int num3 = num + 1;
			num = num3;
		}
	}

	private unsafe void ResizeIfNeeded(float speed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003d: Expected Obj, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected I4, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected I4, but got Unknown
		//IL_0106: Expected F4, but got I
		//IL_0101: Expected native int or pointer, but got VT
		//IL_011b: Expected F4, but got I
		//IL_0116: Expected native int or pointer, but got VT
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected I4, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected I4, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		_ = 0;
		_ = 0;
		if (~(_allCoinsActive ? 1u : 0u) != 0)
		{
			return;
		}
		int num = NumberOfCoins(speed);
		List<Coin> placedCoins = _placedCoins;
		object obj2 = num - placedCoins._size;
		bool flag = (nint)obj2 > -1;
		object obj6 = default;
		object obj7 = default;
		while (true)
		{
			object obj3 = obj2 >> 31;
			object obj4 = obj2 + obj3;
			object obj5 = obj4 ^ obj3;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				break;
			}
			List<Coin> placedCoins2 = _placedCoins;
			if (!flag)
			{
				Coin coin = placedCoins2.get_Item(0);
				coin.Deactivate();
				CoinStats coinStats = CoinStats.New;
				int num2 = obj2 + coinStats.DeactivatedSpawnPoints__BackingField;
				coinStats.DeactivatedSpawnPoints__BackingField = num2;
			}
			else
			{
				int index = obj6 + placedCoins2._size;
				Vector3 coinPosition = GetCoinPosition(index);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				Coin coin2 = SpawnCoin(vector);
				CoinStats coinStats2 = CoinStats.New;
				int num3 = obj2 + coinStats2.ActivatedSpawnPoints__BackingField;
				coinStats2.ActivatedSpawnPoints__BackingField = num3;
			}
			obj6 = obj7 + 1;
		}
		int coinsAtSpawn = obj2 + _coinsAtSpawn;
		_coinsAtSpawn = coinsAtSpawn;
	}

	private unsafe Coin SpawnCoin(Vector3 spawnPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002f: Expected native int or pointer, but got VT
		//IL_0041: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		Transform parentTransform = transform;
		((Vector3*)(nint)vector)->z = spawnPos.z;
		((Vector3*)(nint)vector)->x = spawnPos.x;
		Coin coin = _coinManager.SpawnCoin(vector, parentTransform);
		coin._curve = this;
		_placedCoins.Add(coin);
		return coin;
	}

	private float ScaleZ(float speed, float z)
	{
		float num = speed / 110f;
		if (_scaleMode == ScaleMode.NoScale)
		{
			num = 1f;
		}
		return num * z;
	}

	private float JumpLength(float speed)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		object obj = this + 40;
		if (_character == null)
		{
			Character instance = Character.Instance;
			obj = instance;
		}
		Character character = (Character)obj;
		return ((Character)obj).JumpLength(speed, character.jumpHeightNormal);
	}

	private float LengthOfCurve(float speed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 localPositionForTime = _curveParent.GetLocalPositionForTime(1f);
		Vector3 localPositionForTime2 = _curveParent.GetLocalPositionForTime(0f);
		float num = speed / 110f;
		if (_scaleMode == ScaleMode.NoScale)
		{
			num = 1f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = num2 - 0;
		return num * (float)obj3;
	}

	private float CoinSpacing(float speed)
	{
		bool flag = _spacingMode == CoinSpaceMode.Straight;
		float num = 30f;
		if (!flag)
		{
			num = 15f;
		}
		if (_scaleMode == ScaleMode.ScaleSpacing)
		{
			float num2 = speed / 110f;
			if (_scaleMode == ScaleMode.NoScale)
			{
				num2 = 1f;
			}
			num = num2 * num;
		}
		return num;
	}

	private int NumberOfCoinsIgnoringSkip(float speed)
	{
		//IL_0060: Expected F8, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected I4, but got Unknown
		float value = LengthOfCurve(speed);
		float num = CoinSpacing(speed);
		float num2 = Math.Abs(value);
		double num3 = (double)num2 / (double)num;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num4 = Math.Abs(num3);
		if (!(num4 < 2147483648.0))
		{
			num3 = -2147483648.0;
		}
		return (int)(num3 + 1);
	}

	private int NumberOfCoins(float speed)
	{
		int num = NumberOfCoinsIgnoringSkip(speed);
		bool flag = IsSkippingCoin(speed);
		return num - (flag ? 1 : 0);
	}

	private bool IsSkippingCoin(float speed)
	{
		if (_coinIndexToSkip >= 0)
		{
			int num = NumberOfCoinsIgnoringSkip(speed);
			return num > _coinIndexToSkip;
		}
		return false;
	}

	private void ToggleRenderers(bool doRender)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
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
		object obj10 = default;
		object obj11 = default;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 == obj8;
			bool flag2 = !flag;
			object obj9 = obj10;
			if (!flag2)
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
				obj9 = obj11;
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
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B158");
	}

	private void TrackObject_OnActivate()
	{
		_coinsAtSpawn = 0;
		if (IsZAvailableToJetpackState())
		{
			float speedForCurve = SpeedForCurve;
			int coinsAtSpawn = NumberOfCoinsIgnoringSkip(speedForCurve);
			lastSpawnedCoinIndex = -1;
			_coinsAtSpawn = coinsAtSpawn;
			_activating = true;
		}
	}

	private unsafe void ActivateOneCoinUtilDone()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0202: Expected Obj, but got I4
		//IL_0054: Expected F4, but got I
		//IL_004f: Expected native int or pointer, but got VT
		//IL_0069: Expected F4, but got I
		//IL_0064: Expected native int or pointer, but got VT
		//IL_0119: Invalid comparison between I and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		_ = 0;
		_ = 0;
		int num = ++lastSpawnedCoinIndex;
		bool flag = _coinsAtSpawn > num;
		bool flag2 = !flag;
		int num2 = num;
		int coinsAtSpawn = _coinsAtSpawn;
		if (!flag2)
		{
			if (num == _coinIndexToSkip)
			{
				return;
			}
			Vector3 coinPosition = GetCoinPosition(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			Coin coin = SpawnCoin(vector);
			num2 = lastSpawnedCoinIndex;
			coinsAtSpawn = _coinsAtSpawn;
		}
		object obj2 = coinsAtSpawn - 1;
		if (num2 < (nint)obj2)
		{
			return;
		}
		CoinStats coinStats = CoinStats.New;
		int num3 = coinStats.ActivatedSpawnPoints__BackingField + _coinsAtSpawn;
		coinStats.ActivatedSpawnPoints__BackingField = num3;
		if (IsOnTopLevel)
		{
			Transform transform = _character.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+14]");
			bool doRender;
			if (0f > 70f)
			{
				bool isInJetpackMode = _game.IsInJetpackMode;
				doRender = (byte)((isInJetpackMode ? 1u : 0u) ^ 1u) != 0;
			}
			else
			{
				doRender = false;
			}
			ToggleRenderers(doRender);
		}
		_activating = false;
		_allCoinsActive = true;
	}

	private void Update()
	{
		if (~(_activating ? 1u : 0u) == 0)
		{
			ActivateOneCoinUtilDone();
		}
	}

	protected bool IsZAvailableToJetpackState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Game instance = Game.Instance;
		bool isInJetpackMode = instance.IsInJetpackMode;
		bool flag = !isInJetpackMode;
		bool result = true;
		if (!flag)
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			JetpackState instance2 = JetpackState.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			bool flag2 = (nint)0 > (nint)instance2._targetPosZ;
			bool flag3 = !flag2;
			result = false;
			if (!flag3)
			{
				result = true;
			}
		}
		return result;
	}

	private void TrackObject_OnDeactivate()
	{
		CoinStats coinStats = CoinStats.New;
		int num = coinStats.DeactivatedSpawnPoints__BackingField + _coinsAtSpawn;
		coinStats.DeactivatedSpawnPoints__BackingField = num;
	}

	public void DeactivateCoin(Coin coin)
	{
		_activating = false;
		_allCoinsActive = false;
		bool flag = _placedCoins.Remove(coin);
	}

	private void Game_OnSpeedChanged(float newSpeed)
	{
		_redistributeAlongCurveOnSpeedChange = true;
		RepositionCoins(newSpeed);
	}

	private void Jetpack_OnStart(bool isHeadStart)
	{
		if (IsOnTopLevel)
		{
			_trackObject.Deactivate();
		}
	}

	private void PogoStick_OnStart()
	{
		if (IsOnTopLevel)
		{
			ToggleRenderers(doRender: true);
		}
	}

	public unsafe void OnDrawGizmos()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_02d9: Expected I, but got Obj
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected VT, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected VT, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected VT, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected VT, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_0173: Expected Obj, but got I
		//IL_0190: Expected Obj, but got I
		//IL_033f: Expected I, but got Obj
		//IL_03c3: Expected F4, but got I
		//IL_03be: Expected native int or pointer, but got VT
		//IL_03f9: Expected F4, but got I
		//IL_03f4: Expected native int or pointer, but got VT
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 208);
		if (Application.isPlaying)
		{
			return;
		}
		object obj2 = this + 52;
		if (_game == null)
		{
			Game instance = Game.Instance;
			obj2 = instance;
		}
		if (!((UnityEngine.Object)obj2 != null))
		{
			return;
		}
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		_ = 4575657221408423936L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		_ = 0;
		_ = 1065353216;
		_ = 1065353216;
		Color color = (Color)(vector + 80);
		Gizmos.color = color;
		int num3 = 0;
		while (true)
		{
			Game game = _game;
			Game.SpeedInfo speed = game.speed;
			int num4 = NumberOfCoinsIgnoringSkip(speed.min);
			if (num4 <= num3)
			{
				break;
			}
			if (_coinIndexToSkip != num3)
			{
				Vector3 coinPosition = GetCoinPosition(num3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
				object obj3 = 0 + Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				object obj4 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				object obj5 = num6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
				_ = 0;
				Vector3 center = vector + 32;
				Gizmos.DrawWireSphere(center, 1.5f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
				object obj6 = 0 + Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B4]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				object obj7 = num7 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v33 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				object obj8 = num8 + 0;
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v102 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v103 (Il2CppStaticFields<UnityEngine.Vector3>)+30]");
				float num11 = 0f * 5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v103 (Il2CppStaticFields<UnityEngine.Vector3>)+34]");
				float num12 = 0f * 5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v103 (Il2CppStaticFields<UnityEngine.Vector3>)+38]");
				float num13 = 0f * 5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				((Vector3*)(nint)vector)->x = 0f;
				Vector3 vector2 = vector + 16;
				Gizmos.DrawRay(vector2, vector);
			}
			int num14 = num3 + 1;
			num3 = num14;
		}
		if (_scaleMode != ScaleMode.NoScale)
		{
			Game game2 = _game;
			Game.SpeedInfo speed2 = game2.speed;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color2 = (Color)(vector - -64);
			DrawCurve(speed2.min, color2);
			Game game3 = _game;
			Game.SpeedInfo speed3 = game3.speed;
			_ = 4575657222473777152L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color3 = (Color)(vector + 48);
			DrawCurve(speed3.max, color3);
		}
	}

	public unsafe void DrawCurve(float speed, Color color)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected VT, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00fa: Expected F4, but got I
		//IL_00f5: Expected native int or pointer, but got VT
		//IL_011c: Expected F4, but got I
		//IL_0117: Expected native int or pointer, but got VT
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected VT, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		_ = 0;
		_ = color.b;
		_ = color.r;
		Color color2 = (Color)(vector + 32);
		Gizmos.color = color2;
		Curve cachedCurve = _curveParent.CachedCurve;
		Curve cachedCurve2 = _curveParent.CachedCurve;
		float num = cachedCurve.MaxTime__BackingField - cachedCurve2.MinTime__BackingField;
		Vector3 vector2 = EvaluateCurve(0f, speed);
		object obj2 = 0;
		while ((nint)obj2 < 13)
		{
			float num2 = num * (float)obj2;
			float t = num2 / 12f;
			Vector3 vector3 = EvaluateCurve(t, speed);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			Vector3 vector4 = vector + 16;
			Gizmos.DrawLine(vector4, vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			object obj3 = obj2 + 1;
			obj2 = obj3;
		}
	}

	public unsafe List<Vector3> GetCoinPositions()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_007a: Expected F4, but got I
		//IL_0075: Expected native int or pointer, but got VT
		//IL_008f: Expected F4, but got I
		//IL_008a: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		_ = 0;
		_ = 0;
		List<Vector3> list = default;
		list._002Ector();
		int num2 = default;
		int num3 = default;
		while (true)
		{
			float speedForCurve = SpeedForCurve;
			int num = NumberOfCoins(speedForCurve);
			if (num <= num2)
			{
				break;
			}
			Vector3 coinPosition = GetCoinPosition(num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			list.Add(vector);
			num2 = num3 + 1;
		}
		return list;
	}

	private void _003CAwake_003Eb__27_0(float newSpeed)
	{
		TrackObject trackObject = _trackObject;
		if (~(trackObject._active ? 1u : 0u) == 0 && _scaleMode != ScaleMode.NoScale)
		{
			Game_OnSpeedChanged(newSpeed);
		}
	}

	private void _003CAwake_003Eb__27_1()
	{
		TrackObject trackObject = _trackObject;
		if (~(trackObject._active ? 1u : 0u) == 0)
		{
			PogoStick_OnStart();
		}
	}

	private void _003CAwake_003Eb__27_2(bool isHeadStart)
	{
		TrackObject trackObject = _trackObject;
		if (~(trackObject._active ? 1u : 0u) == 0)
		{
			Jetpack_OnStart(isHeadStart: false);
		}
	}
}
