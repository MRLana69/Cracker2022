using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Common.HTTP;
using SYBO.Common.StateSystem;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
using SYBO.Subway.Visuals;
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

	private int _coinIndexToSkip;

	private bool _redistributeAlongCurveOnSpeedChange;

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
			//IL_0007: Expected F4, but got Obj
			return (float)_curveParent;
		}
	}

	private float UnscaledCoinSpacing
	{
		get
		{
			//IL_00cf: Expected I, but got Obj
			//IL_00e5: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_game).FindKernel((string)null) != 0)
			{
				RuntimePlatform platform = Application.platform;
				Game game = _game;
				if (platform != RuntimePlatform.OSXEditor)
				{
					return game.__currentLevelSpeed;
				}
				Game.SpeedInfo speed = game.speed;
				return speed.min;
			}
			return 110f;
		}
	}

	private bool IsOnTopLevel
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	protected void Awake()
	{
		CancelInvoke();
	}

	protected unsafe void OnValidate()
	{
		//IL_0366: Expected I, but got Obj
		//IL_037c: Expected Obj, but got I
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0431: Expected Obj, but got I4
		//IL_0441: Expected VT, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Expected VT, but got Obj
		//IL_009d: Expected Obj, but got VT
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I4
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03db: Expected Obj, but got I4
		//IL_0211: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_01c4: Expected I, but got Obj
		//IL_02ad: Expected Obj, but got I4
		//IL_0252: Expected I, but got Obj
		//IL_0305: Expected Obj, but got I4
		//IL_0351: Expected Obj, but got I4
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v62 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 52;
		bool isInstantiated = Game.IsInstantiated;
		obj2 = isInstantiated;
		_curveParent.DrawCurve((Color)1);
		Game game = _game;
		Game.SpeedInfo speed = game.speed;
		bool capacity = IsSkippingCoin(speed.max);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Coin> list = default;
		list._002Ector(capacity ? 1 : 0);
		object obj3 = this + 48;
		obj3 = list;
		object obj4 = this + 36;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		obj4 = val;
		object obj5 = this + 44;
		TrackObject component = GetComponent<TrackObject>();
		obj5 = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CoinCurve.TrackObject_OnActivate);
		object obj6 = action + 16;
		obj6 = this;
		_trackObject.OnActivate -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(CoinCurve.TrackObject_OnDeactivate);
		object obj7 = action2 + 16;
		obj7 = this;
		_trackObject.OnDeactivate -= action2;
		((Tunnel)(object)_trackObject).OnTriggerEnter((Collider)1);
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v32 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v58 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = this + 40;
		CharacterRendering instance = CharacterRendering.Instance;
		obj9 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		bool flag = default;
		object obj10 = (flag ? 1 : 0) + 16;
		obj10 = this;
		_game.TriggerPause(flag);
		nint num6 = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v41 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num7 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v54 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		bool flag2 = default;
		object obj12 = (flag2 ? 1 : 0) + 16;
		obj12 = this;
		((PogostickState)(object)ex).SetActiveForPickupPrefabInstance(flag2);
		bool useBenchmarkRoute2 = RouteManager.UseBenchmarkRoute;
		int num9 = default;
		ArrayTypeMismatchException ex2 = (ArrayTypeMismatchException)(object)new HeadstartState(num9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		object obj13 = num9 + 16;
		obj13 = this;
		bool useBenchmarkRoute3 = RouteManager.UseBenchmarkRoute;
		int num11 = default;
		ArrayTypeMismatchException ex3 = (ArrayTypeMismatchException)(object)new HeadstartState(num11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		_ = 0;
		object obj14 = num11 + 16;
		obj14 = this;
	}

	private void SpeedChanged(float newSpeed)
	{
		//IL_0010: Expected Obj, but got I4
		((Collider)_coinIndexToSkip).isTrigger = false;
		_game(newSpeed);
	}

	private void PogostickStart()
	{
		//IL_0010: Expected VT, but got I4
		_curveParent.DrawCurve((Color)1);
	}

	private void JetpackStart()
	{
		TrackObject trackObject = _trackObject;
		if (~(trackObject._active ? 1u : 0u) == 0)
		{
			OnDrawGizmos();
		}
	}

	private Vector3 GetCoinPosition(int index)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_00ff: Expected I4, but got Obj
		//IL_00ff: Expected Obj, but got VT
		//IL_0080: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		object obj = index;
		EventHandler<InputEventArgs> value;
		switch (index)
		{
		case 0:
			value = (EventHandler<InputEventArgs>)1;
			break;
		case 1:
			value = (EventHandler<InputEventArgs>)2;
			break;
		case 2:
			value = (EventHandler<InputEventArgs>)3;
			break;
		case 3:
			value = (EventHandler<InputEventArgs>)4;
			break;
		default:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InputManager inputManager = default;
		inputManager.OnInputEvent += value;
		Vector3 vector = default;
		((Coin)vector).ToggleRenderer((byte)(int)inputManager != 0);
		return vector;
	}

	private Vector3 GetCoinPosition(int index, float speed, bool speedChanged = false)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [456F6F]");
		Vector3 result = default;
		if ((nint)0 != 0)
		{
			return result;
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @467B");
		return result;
	}

	private unsafe Vector3 EvaluateCurve(float t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got Unknown
		//IL_06e5: Expected Obj, but got I4
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0702: Expected Obj, but got I4
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected Obj, but got Unknown
		//IL_071f: Expected Obj, but got I4
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected Ref, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected Obj, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected Obj, but got Unknown
		//IL_077b: Expected Obj, but got I4
		//IL_0799: Expected I, but got Obj
		//IL_07af: Expected Obj, but got I
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected VT, but got Unknown
		//IL_00c1: Expected VT, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_0836: Expected I, but got Obj
		//IL_084c: Expected Obj, but got I
		//IL_0a9d: Expected VT, but got Obj
		//IL_0a9d: Expected Obj, but got I4
		//IL_0aae: Expected Obj, but got F4
		//IL_00a8: Expected Obj, but got F4
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_00e6: Expected I, but got Obj
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected Obj, but got Unknown
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected Obj, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected Obj, but got Unknown
		//IL_08ab: Expected Obj, but got VT
		//IL_03e2: Invalid comparison between I and F4
		//IL_0174: Expected I, but got Obj
		//IL_042b: Expected I, but got Obj
		//IL_0441: Expected Obj, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0259: Expected Obj, but got I4
		//IL_046c: Expected I, but got Obj
		//IL_04b9: Expected I, but got Obj
		//IL_04cf: Expected Obj, but got I
		//IL_097c: Expected I, but got Obj
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected Obj, but got Unknown
		//IL_09b4: Expected Obj, but got I4
		//IL_04fa: Expected I, but got Obj
		//IL_0323: Expected Obj, but got I
		//IL_05ac: Expected Obj, but got I
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_05de: Expected VT, but got Obj
		//IL_060e: Expected VT, but got Obj
		//IL_060e: Expected Obj, but got I
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected Obj, but got Unknown
		//IL_0918: Expected VT, but got Obj
		//IL_061d: Expected VT, but got Obj
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_064e: Expected I, but got Obj
		//IL_0664: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_09ed: Expected F4, but got Obj
		//IL_09e8: Expected native int or pointer, but got VT
		//IL_09ff: Expected F4, but got I
		//IL_09fa: Expected native int or pointer, but got VT
		//IL_0a29: Expected VT, but got Obj
		//IL_0a65: Expected VT, but got Obj
		//IL_068f: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 176;
		object obj3 = obj2 + 124;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 112;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 88;
		obj5 = 0;
		_ = 0;
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)(obj2 + 72);
		reference = ref *(Vector3*)null;
		_ = 0;
		object obj6 = obj2 - -64;
		obj6 = obj;
		_ = -1;
		object obj7 = obj2 + 48;
		obj7 = 0;
		_ = 0;
		Collider component = GetComponent<Collider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v222 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Collider collider = (Collider)(obj2 + 152);
		Vector3 vector = (Vector3)(obj2 + 136);
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			collider.get_bounds_Injected(out *(Bounds*)component);
			obj5 = collider;
			_ = ((UnityEngine.Object)collider).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v38 (UnityEngine.Collider)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			obj7 = vector.x;
			_ = vector.z;
		}
		else
		{
			((Transform)(object)collider).position = (Vector3)this;
			obj7 = collider;
			_ = ((UnityEngine.Object)collider).m_CachedPtr;
		}
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28+8]");
		_ = 0;
		nint num3 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v47 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v208 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		collider = (Collider)obj3;
		Collider collider2 = collider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)collider2).m_CachedPtr = (IntPtr)0;
		Vector3 worldPosition = ((GamePositionRoot)isRestricted).GetWorldPosition((Vector3)collider);
		obj4 = vector.x;
		_ = vector.z;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v61 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v204 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = obj2 + 84;
		Transform transform = (Transform)(obj2 + 36);
		Transform transform2 = (Transform)(obj2 + 24);
		object obj12 = obj2 + 12;
		if (((ComputeShader)componentInChildren).FindKernel(null) == 0)
		{
			object current = ((Transform.Enumerator)(object)this).Current;
			object obj13 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj13 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27");
			}
			object obj14 = obj6 + 4;
			object obj15 = obj14 + 1;
			obj14 = obj15;
			object obj16 = obj15 << 2;
			object obj17 = obj6 + obj16;
			obj17 = 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj18 = default;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25+4]");
				object obj19 = (nint)0 << 2;
				object obj20 = obj6 + obj19;
				if ((nint)obj20 == 280)
				{
					object obj21 = obj6 + 4;
					if ((nint)obj21 > -1)
					{
						object obj22 = obj21 + -1;
						obj21 = obj22;
					}
					return (Vector3)obj21;
				}
			}
			object obj23 = default;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				goto IL_091d;
			}
		}
		collider = (Collider)obj4;
		Collider collider3 = collider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((UnityEngine.Object)collider3).m_CachedPtr = (IntPtr)0;
		Vector3 vector2 = default;
		if ((float)(nint)((UnityEngine.Object)collider).m_CachedPtr < t)
		{
			string text = tag;
			bool activeSelf = ((GameObject)(object)text).activeSelf;
			nint num7 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S1_v62 (Il2CppClass<Layers>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num8 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S1_v110 (Il2CppClass<Layers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool startupFinished = LoadLevelCtrl.StartupFinished;
			bool flag = activeSelf;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S1_v67 (System.Boolean)+10]");
			if ((nint)(flag ? 1 : 0) != 0)
			{
				nint num9 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v90 (Il2CppClass<System.Type>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				if (obj25 != null)
				{
					nint num10 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v132 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj11 = typeof(IHideable);
				collider = (Collider)obj11;
				Type type = Type.internal_from_handle((IntPtr)collider);
				Component[] componentsInChildrenBFS = SYBO.Common.Utilities.GameObjectUtil.GetComponentsInChildrenBFS((GameObject)(object)this, type, includeInactive: false, includeSelf: true, 1);
				object obj26 = componentsInChildrenBFS + 12;
				object obj27 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26))
				{
					object obj28 = componentsInChildrenBFS + 16;
					object obj29 = obj27 << 2;
					object obj30 = obj28 + obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
					object obj31 = obj27 + 1;
					obj27 = obj31;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+70]");
				if (!((Dictionary<Transform, Vector3>)0).TryGetValue((Transform)(object)this, out reference))
				{
					transform.localPosition = (Vector3)this;
					collider = (Collider)(object)transform;
					((UnityEngine.Object)collider).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+70]");
					((Dictionary<Transform, Vector3>)0).set_Item((Transform)(object)this, (Vector3)collider);
					transform2.localPosition = (Vector3)this;
					object obj32 = vector2 + 12;
					obj12 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S1_v88+8]");
					_ = 0;
					nint num11 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ S0_v113 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj33 = (nint)0 & (nint)0x200;
					if (obj33 != null)
					{
						Vector3 vector3 = (Vector3)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S0_v125 (UnityEngine.Vector3)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector)->x = (float)transform2;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
					collider = (Collider)obj12;
					Collider collider4 = collider;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v72+8]");
					((UnityEngine.Object)collider4).m_CachedPtr = (IntPtr)0;
					Vector3 vector4 = vector - (Vector3)collider;
					collider = (Collider)obj2;
					Collider collider5 = collider;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)collider5).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles = ((Transform)(object)collider).eulerAngles;
					return (Vector3)typeof(Vector3);
				}
			}
		}
		goto IL_091d;
		IL_091d:
		return vector2;
	}

	private unsafe Vector3 EvaluateCurve(float t, float speed)
	{
		//IL_1fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb1: Expected VT, but got Unknown
		//IL_1fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbf: Expected VT, but got Unknown
		//IL_1fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcd: Expected Obj, but got Unknown
		//IL_1fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fdb: Expected Obj, but got Unknown
		//IL_1fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe9: Expected Obj, but got Unknown
		//IL_1ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff7: Expected Obj, but got Unknown
		//IL_2000: Unknown result type (might be due to invalid IL or missing references)
		//IL_2005: Expected Obj, but got Unknown
		//IL_200e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2013: Expected Obj, but got Unknown
		//IL_201c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2021: Expected Obj, but got Unknown
		//IL_202a: Unknown result type (might be due to invalid IL or missing references)
		//IL_202f: Expected Obj, but got Unknown
		//IL_2038: Unknown result type (might be due to invalid IL or missing references)
		//IL_203d: Expected Obj, but got Unknown
		//IL_204b: Expected I, but got Obj
		//IL_2061: Expected Obj, but got I
		//IL_285b: Expected I, but got Obj
		//IL_2871: Expected Obj, but got I
		//IL_33f8: Expected VT, but got Obj
		//IL_0ef6: Expected I, but got Obj
		//IL_2098: Expected I, but got Obj
		//IL_20ae: Expected Obj, but got I
		//IL_0f43: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		//IL_0f90: Expected I, but got Obj
		//IL_0fa6: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		//IL_2898: Unknown result type (might be due to invalid IL or missing references)
		//IL_289d: Expected Obj, but got Unknown
		//IL_28c7: Expected Obj, but got I
		//IL_28dd: Invalid comparison between Obj and F4
		//IL_00d1: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_10f9: Expected I, but got Obj
		//IL_110f: Expected Obj, but got I
		//IL_0fd1: Expected I, but got Obj
		//IL_31bb: Expected I, but got Obj
		//IL_31d1: Expected Obj, but got I
		//IL_01a9: Expected I, but got Obj
		//IL_2965: Expected Obj, but got VT
		//IL_297b: Expected Obj, but got VT
		//IL_2989: Expected I, but got Obj
		//IL_299f: Expected Obj, but got I
		//IL_101e: Expected I, but got Obj
		//IL_1034: Expected Obj, but got I
		//IL_21a3: Expected native int or pointer, but got VT
		//IL_21c9: Expected I4, but got Obj
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0112: Expected I, but got Obj
		//IL_3469: Expected F4, but got Obj
		//IL_3464: Expected native int or pointer, but got VT
		//IL_3476: Expected F4, but got Obj
		//IL_3471: Expected native int or pointer, but got VT
		//IL_349c: Expected F4, but got Obj
		//IL_3497: Expected native int or pointer, but got VT
		//IL_34ae: Expected VT, but got F4
		//IL_34b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_34bd: Expected Obj, but got Unknown
		//IL_34e7: Expected Obj, but got I
		//IL_113a: Expected I, but got Obj
		//IL_291c: Expected I, but got Obj
		//IL_2932: Expected Obj, but got I
		//IL_035f: Expected I, but got Obj
		//IL_2146: Expected I, but got Obj
		//IL_215c: Expected Obj, but got I
		//IL_1527: Expected I, but got Obj
		//IL_153d: Expected Obj, but got I
		//IL_1187: Expected I, but got Obj
		//IL_343e: Expected VT, but got Obj
		//IL_105f: Expected I, but got Obj
		//IL_21e5: Expected I, but got Obj
		//IL_21fb: Expected Obj, but got I
		//IL_0237: Expected I, but got Obj
		//IL_2bbc: Invalid comparison between Obj and F4
		//IL_2bf0: Expected Obj, but got I4
		//IL_2bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bfd: Expected Obj, but got Unknown
		//IL_11d4: Expected I, but got Obj
		//IL_11ea: Expected Obj, but got I
		//IL_10ac: Expected VT, but got Obj
		//IL_3223: Unknown result type (might be due to invalid IL or missing references)
		//IL_3228: Expected Obj, but got Unknown
		//IL_3248: Unknown result type (might be due to invalid IL or missing references)
		//IL_324d: Expected Obj, but got Unknown
		//IL_3291: Expected I, but got Obj
		//IL_32a7: Expected Obj, but got I
		//IL_03d4: Expected I, but got Obj
		//IL_03ea: Expected Obj, but got I
		//IL_0284: Expected I, but got Obj
		//IL_163e: Expected Obj, but got I4
		//IL_1568: Expected I, but got Obj
		//IL_29dc: Expected I, but got Obj
		//IL_29f2: Expected Obj, but got I
		//IL_35cf: Expected Obj, but got F4
		//IL_35dc: Expected F4, but got Obj
		//IL_35d7: Expected native int or pointer, but got VT
		//IL_35ee: Expected VT, but got F4
		//IL_0618: Expected I, but got Obj
		//IL_222f: Expected I, but got Obj
		//IL_2245: Expected Obj, but got I
		//IL_02d1: Expected I, but got Obj
		//IL_02e7: Expected Obj, but got I
		//IL_2b73: Expected I, but got Obj
		//IL_2b89: Expected Obj, but got I
		//IL_2ba6: Expected VT, but got Obj
		//IL_15b5: Expected I, but got Obj
		//IL_15cb: Expected Obj, but got I
		//IL_1215: Expected I, but got Obj
		//IL_22fd: Expected I, but got Obj
		//IL_2313: Expected Obj, but got I
		//IL_0665: Expected I, but got Obj
		//IL_0415: Expected I, but got Obj
		//IL_3558: Expected Obj, but got I
		//IL_3568: Expected Obj, but got I
		//IL_2c55: Expected F4, but got VT
		//IL_2c50: Expected native int or pointer, but got VT
		//IL_2c62: Expected Obj, but got F4
		//IL_2c6f: Expected F4, but got Obj
		//IL_2c6a: Expected native int or pointer, but got VT
		//IL_2c81: Expected VT, but got F4
		//IL_2c8a: Expected Obj, but got I4
		//IL_1262: Expected I, but got Obj
		//IL_330b: Expected F4, but got I4
		//IL_3306: Expected native int or pointer, but got VT
		//IL_332c: Expected I4, but got Obj
		//IL_3343: Expected I, but got Obj
		//IL_3359: Expected Obj, but got I
		//IL_06b2: Expected I, but got Obj
		//IL_06c8: Expected Obj, but got I
		//IL_0462: Expected I, but got Obj
		//IL_0312: Expected I, but got Obj
		//IL_1651: Expected I, but got Obj
		//IL_1681: Expected VT, but got Obj
		//IL_15f6: Expected I, but got Obj
		//IL_12af: Expected I, but got Obj
		//IL_12c5: Expected Obj, but got I
		//IL_23c6: Expected VT, but got Obj
		//IL_081b: Expected I, but got Obj
		//IL_2347: Expected I, but got Obj
		//IL_235d: Expected Obj, but got I
		//IL_04af: Expected I, but got Obj
		//IL_04c5: Expected Obj, but got I
		//IL_16ba: Expected I, but got Obj
		//IL_16d0: Expected Obj, but got I
		//IL_2a4a: Expected F4, but got VT
		//IL_2a45: Expected native int or pointer, but got VT
		//IL_2a57: Expected Obj, but got F4
		//IL_2a64: Expected F4, but got Obj
		//IL_2a5f: Expected native int or pointer, but got VT
		//IL_2a76: Expected VT, but got F4
		//IL_0868: Expected I, but got Obj
		//IL_06f3: Expected I, but got Obj
		//IL_22a0: Expected I, but got Obj
		//IL_22b6: Expected Obj, but got I
		//IL_2c9d: Expected I, but got Obj
		//IL_2cb3: Expected Obj, but got I
		//IL_16a7: Expected VT, but got Obj
		//IL_13b1: Expected I, but got Obj
		//IL_13c7: Expected Obj, but got I
		//IL_12f0: Expected I, but got Obj
		//IL_08b5: Expected I, but got Obj
		//IL_08cb: Expected Obj, but got I
		//IL_0740: Expected I, but got Obj
		//IL_04f0: Expected I, but got Obj
		//IL_16fb: Expected I, but got Obj
		//IL_2ae0: Expected I4, but got Obj
		//IL_133d: Expected I, but got Obj
		//IL_1353: Expected Obj, but got I
		//IL_23ec: Expected I, but got Obj
		//IL_2402: Expected Obj, but got I
		//IL_078d: Expected I, but got Obj
		//IL_07a3: Expected Obj, but got I
		//IL_053d: Expected I, but got Obj
		//IL_1823: Expected I, but got Obj
		//IL_1839: Expected Obj, but got I
		//IL_1748: Expected I, but got Obj
		//IL_14b3: Expected I, but got Obj
		//IL_14c9: Expected Obj, but got I
		//IL_13f2: Expected I, but got Obj
		//IL_08f6: Expected I, but got Obj
		//IL_058a: Expected I, but got Obj
		//IL_05a0: Expected Obj, but got I
		//IL_2d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d14: Expected Obj, but got Unknown
		//IL_2d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d21: Expected Obj, but got Unknown
		//IL_2d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d2f: Expected I4, but got Unknown
		//IL_2d3d: Expected I, but got Obj
		//IL_2d53: Expected Obj, but got I
		//IL_1795: Expected I, but got Obj
		//IL_17ab: Expected Obj, but got I
		//IL_2b4d: Expected I4, but got Obj
		//IL_2b4d: Expected I4, but got Obj
		//IL_2b60: Expected Obj, but got I4
		//IL_143f: Expected I, but got Obj
		//IL_1455: Expected Obj, but got I
		//IL_137e: Expected I, but got Obj
		//IL_2476: Expected I, but got Obj
		//IL_248c: Expected Obj, but got I
		//IL_0943: Expected I, but got Obj
		//IL_07ce: Expected I, but got Obj
		//IL_1864: Expected I, but got Obj
		//IL_14f4: Expected I, but got Obj
		//IL_24c6: Expected I, but got Obj
		//IL_24dc: Expected Obj, but got I
		//IL_2509: Expected I, but got Obj
		//IL_251f: Expected Obj, but got I
		//IL_0990: Expected I, but got Obj
		//IL_09a6: Expected Obj, but got I
		//IL_05cb: Expected I, but got Obj
		//IL_2e0c: Expected I, but got Obj
		//IL_2e22: Expected Obj, but got I
		//IL_17d6: Expected I, but got Obj
		//IL_1480: Expected I, but got Obj
		//IL_0a78: Expected I, but got Obj
		//IL_2428: Expected native int or pointer, but got VT
		//IL_244a: Expected I4, but got Obj
		//IL_1a14: Expected I, but got Obj
		//IL_2601: Expected I, but got Obj
		//IL_2617: Expected Obj, but got I
		//IL_0aab: Expected I, but got Obj
		//IL_09d1: Expected I, but got Obj
		//IL_1a87: Expected I, but got Obj
		//IL_1a9d: Expected Obj, but got I
		//IL_1a47: Expected I, but got Obj
		//IL_197c: Expected I, but got Obj
		//IL_1992: Expected Obj, but got I
		//IL_18d5: Expected I, but got Obj
		//IL_266c: Expected I, but got Obj
		//IL_2682: Expected Obj, but got I
		//IL_0ade: Expected I, but got Obj
		//IL_0af4: Expected Obj, but got I
		//IL_0a04: Expected I, but got Obj
		//IL_0a1a: Expected Obj, but got I
		//IL_2ddf: Expected I4, but got Obj
		//IL_1908: Expected I, but got Obj
		//IL_191e: Expected Obj, but got I
		//IL_26c6: Expected VT, but got Obj
		//IL_0bf9: Expected I, but got Obj
		//IL_2595: Expected I, but got Obj
		//IL_25ab: Expected Obj, but got I
		//IL_1ac8: Expected I, but got Obj
		//IL_1cb5: Expected I, but got Obj
		//IL_1ccb: Expected Obj, but got I
		//IL_19bd: Expected I, but got Obj
		//IL_0c2c: Expected VT, but got Obj
		//IL_0b1f: Expected I, but got Obj
		//IL_0a45: Expected I, but got Obj
		//IL_2ed7: Expected I, but got Obj
		//IL_2eed: Expected Obj, but got I
		//IL_1afb: Expected I, but got Obj
		//IL_1b11: Expected Obj, but got I
		//IL_1c41: Expected I, but got Obj
		//IL_1c57: Expected Obj, but got I
		//IL_1949: Expected I, but got Obj
		//IL_0c5f: Expected I, but got Obj
		//IL_0c75: Expected Obj, but got I
		//IL_0b52: Expected I, but got Obj
		//IL_2f38: Expected I4, but got Obj
		//IL_2f38: Expected I4, but got Obj
		//IL_1d9d: Expected I, but got Obj
		//IL_1db3: Expected Obj, but got I
		//IL_1cf6: Expected I, but got Obj
		//IL_2f8c: Expected I4, but got Obj
		//IL_2f8c: Expected I4, but got Obj
		//IL_1bcd: Expected I, but got Obj
		//IL_1be3: Expected Obj, but got I
		//IL_0b85: Expected I, but got Obj
		//IL_0b9b: Expected Obj, but got I
		//IL_1b7c: Expected I, but got Obj
		//IL_1b3c: Expected I, but got Obj
		//IL_300e: Expected F4, but got VT
		//IL_3009: Expected native int or pointer, but got VT
		//IL_301b: Expected native int or pointer, but got VT
		//IL_3041: Expected I4, but got Obj
		//IL_304b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3050: Expected Obj, but got Unknown
		//IL_307e: Expected I, but got Obj
		//IL_3094: Expected Obj, but got I
		//IL_1d29: Expected I, but got Obj
		//IL_1d3f: Expected Obj, but got I
		//IL_1c82: Expected I, but got Obj
		//IL_0ca0: Expected I, but got Obj
		//IL_263e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2643: Expected Obj, but got Unknown
		//IL_1ea8: Expected VT, but got Obj
		//IL_1dde: Expected I, but got Obj
		//IL_2fce: Expected Obj, but got VT
		//IL_2fdb: Expected F4, but got Obj
		//IL_2fd6: Expected native int or pointer, but got VT
		//IL_1c0e: Expected I, but got Obj
		//IL_2782: Expected I, but got Obj
		//IL_2798: Expected Obj, but got I
		//IL_0cd3: Expected I, but got Obj
		//IL_0ce9: Expected Obj, but got I
		//IL_0bc6: Expected I, but got Obj
		//IL_30ef: Invalid comparison between Obj and F4
		//IL_3105: Expected Obj, but got I
		//IL_3115: Expected Obj, but got I
		//IL_3139: Expected Obj, but got I4
		//IL_1e27: Expected VT, but got Obj
		//IL_1d6a: Expected I, but got Obj
		//IL_2720: Expected I, but got Obj
		//IL_2736: Expected Obj, but got I
		//IL_1ec4: Expected I, but got Obj
		//IL_1ed2: Expected VT, but got Obj
		//IL_30cc: Expected Obj, but got I
		//IL_30dc: Expected Obj, but got I
		//IL_0e2f: Expected I, but got Obj
		//IL_0e45: Expected Obj, but got I
		//IL_0e62: Expected VT, but got Obj
		//IL_0d88: Expected I, but got Obj
		//IL_0d14: Expected I, but got Obj
		//IL_1f13: Expected I, but got Obj
		//IL_1f29: Expected Obj, but got I
		//IL_1f46: Expected VT, but got Obj
		//IL_1e43: Expected I, but got Obj
		//IL_1e51: Expected VT, but got Obj
		//IL_280d: Expected Obj, but got I
		//IL_281b: Expected F4, but got I4
		//IL_2816: Expected native int or pointer, but got VT
		//IL_283f: Expected I4, but got Obj
		//IL_283f: Expected Obj, but got I
		//IL_0dbb: Expected I, but got Obj
		//IL_0dd1: Expected Obj, but got I
		//IL_0d47: Expected I, but got Obj
		//IL_3166: Expected Obj, but got I
		//IL_3176: Expected Obj, but got I
		//IL_1f00: Expected VT, but got Obj
		//IL_0e7e: Expected I, but got Obj
		//IL_0e8c: Expected VT, but got Obj
		//IL_1f62: Expected I, but got Obj
		//IL_1f70: Expected VT, but got Obj
		//IL_1e7f: Expected VT, but got Obj
		//IL_0dfc: Expected I, but got Obj
		//IL_0eba: Expected VT, but got Obj
		//IL_1f9e: Expected VT, but got Obj
		object obj = default;
		Vector2 vector = (Vector2)(obj + 88);
		Vector2 vector2 = (Vector2)(obj + 72);
		object obj2 = obj + 80;
		object obj3 = obj + 16;
		object obj4 = obj + 8;
		object obj5 = obj - -64;
		object obj6 = obj + 56;
		object obj7 = obj + 48;
		object obj8 = obj + 40;
		object obj9 = obj + 32;
		object obj10 = obj + 24;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (Il2CppClass<UICamera>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		bool flag = obj11 == null;
		Vector3 result;
		object obj66;
		object obj74;
		if ((object)this != null)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v1002 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v218 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v427 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)UICamera.mTooltip).FindKernel((string)null) != 0)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v992 (Il2CppClass<UICamera>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v998 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BMFont bmFont = ((UIFont)null).bmFont;
			}
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			nint num7 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v579 (Il2CppClass<UICamera>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num8 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v985 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num9 = unscaledDeltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ L0+24]");
			float mTooltipTime = num9 + 0f;
			UICamera.mTooltipTime = mTooltipTime;
			UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
			currentTouch.pressStarted = true;
			if (UICamera.onPress != null)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S0_v956 (Il2CppClass<UICamera>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num11 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v979 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S1_v410 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num13 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S1_v421 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)currentTouch2.pressed))
				{
					nint num14 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S0_v966 (Il2CppClass<UICamera>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num15 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v973 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch3 = UICamera.currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				}
			}
			nint num16 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S0_v595 (Il2CppClass<UICamera>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num17 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v949 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch4 = UICamera.currentTouch;
			((Vector2*)(nint)vector)->x = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			bool released = default;
			((UICamera)(object)currentTouch4.pressed).ProcessTouch((byte)(int)"OnPress" != 0, released);
			if (UICamera.currentKey == KeyCode.None)
			{
				nint num18 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ S0_v907 (Il2CppClass<UICamera>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num19 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S0_v945 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ S1_v386 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num21 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S1_v404 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (controllerNavigationObject != null)
				{
					nint num22 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ S0_v915 (Il2CppClass<UICamera>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num23 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ S0_v939 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch5 = UICamera.currentTouch;
					nint num24 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ S1_v393 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj22 = (nint)0 & (nint)0x200;
					if (obj22 != null)
					{
						nint num25 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ S1_v400 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)currentTouch5.current).FindKernel((string)null) != 0)
					{
						nint num26 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1257 @ S0_v925 (Il2CppClass<UICamera>)+BA]");
						object obj23 = (nint)0 & (nint)0x200;
						if (obj23 != null)
						{
							nint num27 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ S0_v933 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UICamera.MouseOrTouch currentTouch6 = UICamera.currentTouch;
						UICamera.controllerNavigationObject = currentTouch6.current;
					}
				}
			}
			nint num28 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v608 (Il2CppClass<UICamera>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num29 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ S0_v900 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj25 = UICamera.currentTouch + 56;
			UICamera.MouseOrTouch currentTouch7 = UICamera.currentTouch;
			obj25 = currentTouch7.current;
			object obj26 = UICamera.currentTouch + 60;
			UICamera.MouseOrTouch currentTouch8 = UICamera.currentTouch;
			obj26 = currentTouch8.current;
			UICamera.MouseOrTouch currentTouch9 = UICamera.currentTouch;
			currentTouch9.clickNotification = UICamera.ClickNotification.BasedOnDelta;
			UICamera.MouseOrTouch currentTouch10 = UICamera.currentTouch;
			nint num30 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ S1_v252 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num31 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S1_v380 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 one = Vector2.one;
			obj2 = vector2.x;
			((Vector2*)(nint)vector)->x = (float)obj2;
			currentTouch10.totalDelta = (Vector2)vector.x;
			UICamera.MouseOrTouch currentTouch11 = UICamera.currentTouch;
			currentTouch11.dragStarted = false;
			if (UICamera.onPress != null)
			{
				nint num32 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ S0_v871 (Il2CppClass<UICamera>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num33 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ S0_v894 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch12 = UICamera.currentTouch;
				nint num34 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ S1_v365 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num35 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ S1_v376 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)currentTouch12.pressed))
				{
					nint num36 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ S0_v881 (Il2CppClass<UICamera>)+BA]");
					object obj30 = (nint)0 & (nint)0x200;
					if (obj30 != null)
					{
						nint num37 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ S0_v888 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch13 = UICamera.currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				}
			}
			nint num38 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ S0_v639 (Il2CppClass<UICamera>)+BA]");
			object obj31 = (nint)0 & (nint)0x200;
			if (obj31 != null)
			{
				nint num39 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S0_v864 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch14 = UICamera.currentTouch;
			((Vector2*)(nint)vector)->x = 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			bool released2 = default;
			((UICamera)(object)currentTouch14.pressed).ProcessTouch((byte)(int)"OnPress" != 0, released2);
			UICamera.MouseOrTouch currentTouch15 = UICamera.currentTouch;
			nint num40 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ S2_v138 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num41 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ S2_v163 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num42 = ((ComputeShader)(object)UICamera.mSelected).FindKernel((string)(object)currentTouch15.pressed);
			bool flag2 = num42 == 0;
			result = (Vector3)typeof(UnityEngine.Object);
			if (!flag2)
			{
				nint num43 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1301 @ S0_v654 (Il2CppClass<UICamera>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num44 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ S0_v858 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.mInputFocus = false;
				nint num45 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ S0_v665 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj34 = (nint)0 & (nint)0x200;
				if (obj34 != null)
				{
					nint num46 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S0_v854 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)UICamera.mSelected))
				{
					nint num47 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1461 @ S0_v824 (Il2CppClass<UICamera>)+BA]");
					object obj35 = (nint)0 & (nint)0x200;
					if (obj35 != null)
					{
						nint num48 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1542 @ S0_v849 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector2*)(nint)vector)->x = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					bool released3 = default;
					((UICamera)(object)UICamera.mSelected).ProcessTouch((byte)(int)"OnSelect" != 0, released3);
					if (UICamera.onSelect != null)
					{
						nint num49 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1793 @ S0_v837 (Il2CppClass<UICamera>)+BA]");
						object obj36 = (nint)0 & (nint)0x200;
						if (obj36 != null)
						{
							nint num50 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1835 @ S0_v844 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
					}
				}
				nint num51 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1486 @ S0_v673 (Il2CppClass<UICamera>)+BA]");
				object obj37 = (nint)0 & (nint)0x200;
				if (obj37 != null)
				{
					nint num52 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ S0_v818 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num53 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1563 @ S0_v678 (Il2CppClass<UICamera>)+5C]");
				object obj38 = (nint)0 + (nint)312;
				UICamera.MouseOrTouch currentTouch16 = UICamera.currentTouch;
				obj38 = currentTouch16.pressed;
				UICamera.MouseOrTouch currentTouch17 = UICamera.currentTouch;
				nint num54 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1577 @ S0_v687 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num55 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1630 @ S0_v815 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)currentTouch17.pressed).FindKernel((string)null) != 0)
				{
					nint num56 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1799 @ S0_v785 (Il2CppClass<UICamera>)+BA]");
					object obj40 = (nint)0 & (nint)0x200;
					if (obj40 != null)
					{
						nint num57 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1845 @ S0_v810 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch18 = UICamera.currentTouch;
					UIKeyNavigation component = currentTouch18.pressed.GetComponent<UIKeyNavigation>();
					nint num58 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ S1_v336 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj41 = (nint)0 & (nint)0x200;
					if (obj41 != null)
					{
						nint num59 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1917 @ S1_v348 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
					{
						nint num60 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1959 @ S0_v797 (Il2CppClass<UICamera>)+BA]");
						object obj42 = (nint)0 & (nint)0x200;
						if (obj42 != null)
						{
							nint num61 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1984 @ S0_v805 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj43 = UICamera.controller + 52;
						UICamera.MouseOrTouch currentTouch19 = UICamera.currentTouch;
						obj43 = currentTouch19.pressed;
					}
				}
				nint num62 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ S0_v695 (Il2CppClass<UICamera>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num63 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1858 @ S0_v779 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num64 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1868 @ S1_v292 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj45 = (nint)0 & (nint)0x200;
				if (obj45 != null)
				{
					Vector3 vector3 = (Vector3)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1906 @ S1_v329 (UnityEngine.Vector3)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)UICamera.mSelected);
				bool flag4 = !flag3;
				result = (Vector3)typeof(UnityEngine.Object);
				if (!flag4)
				{
					nint num65 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1944 @ S0_v705 (Il2CppClass<UICamera>)+BA]");
					object obj46 = (nint)0 & (nint)0x200;
					if (obj46 != null)
					{
						nint num66 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ S0_v774 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = UICamera.mSelected.tag;
					int num72;
					if (text != null)
					{
						nint num67 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2003 @ S0_v759 (Il2CppClass<UICamera>)+BA]");
						object obj47 = (nint)0 & (nint)0x200;
						if (obj47 != null)
						{
							nint num68 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2012 @ S0_v769 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UIInput component2 = UICamera.mSelected.GetComponent<UIInput>();
						nint num69 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2044 @ S1_v320 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj48 = (nint)0 & (nint)0x200;
						if (obj48 != null)
						{
							nint num70 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2065 @ S1_v326 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num71 = ((ComputeShader)(object)component2).FindKernel((string)null);
						num72 = num71 & 1;
					}
					else
					{
						num72 = 0;
					}
					nint num73 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2036 @ S0_v715 (Il2CppClass<UICamera>)+BA]");
					object obj49 = (nint)0 & (nint)0x200;
					if (obj49 != null)
					{
						nint num74 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2048 @ S0_v752 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool mInputFocus = num72 != 0;
					UICamera.mInputFocus = mInputFocus;
					if (UICamera.onSelect != null)
					{
						nint num75 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2073 @ S0_v740 (Il2CppClass<UICamera>)+BA]");
						object obj50 = (nint)0 & (nint)0x200;
						if (obj50 != null)
						{
							nint num76 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2097 @ S0_v747 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
					}
					nint num77 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2091 @ S0_v727 (Il2CppClass<UICamera>)+BA]");
					object obj51 = (nint)0 & (nint)0x200;
					bool flag5 = obj51 == null;
					result = (Vector3)typeof(UICamera);
					if (!flag5)
					{
						nint num78 = (nint)typeof(UICamera);
						result = (Vector3)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2107 @ S0_v734 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							result = (Vector3)typeof(UICamera);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+5C]");
					object obj52 = 0;
					((Vector2*)(nint)vector)->x = 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2113 @ S0_v732+138]");
					bool released4 = default;
					((UICamera)0).ProcessTouch((byte)(int)"OnSelect" != 0, released4);
				}
			}
		}
		else
		{
			if (!flag)
			{
				nint num79 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v560 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch20 = UICamera.currentTouch;
			nint num80 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj53 = (nint)0 & (nint)0x200;
			if (obj53 != null)
			{
				nint num81 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v213 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num82 = ((ComputeShader)(object)currentTouch20.pressed).FindKernel((string)null);
			bool flag6 = num82 == 0;
			result = (Vector3)typeof(UnityEngine.Object);
			if (!flag6)
			{
				nint num83 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v47 (Il2CppClass<UICamera>)+BA]");
				object obj54 = (nint)0 & (nint)0x200;
				if (obj54 != null)
				{
					nint num84 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v554 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj55 = UICamera.currentTouch + 28;
				object obj56 = obj55 * obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v54+4]");
				nint num85 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v54+4]");
				object obj57 = num85 * 0;
				object obj58 = obj56 + obj57;
				if (obj58 == (object)0f)
				{
					nint num86 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v538 (Il2CppClass<UICamera>)+BA]");
					object obj59 = (nint)0 & (nint)0x200;
					if (obj59 != null)
					{
						nint num87 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S0_v548 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch21 = UICamera.currentTouch;
					UICamera.MouseOrTouch currentTouch22 = UICamera.currentTouch;
					nint num88 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S2_v110 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj60 = (nint)0 & (nint)0x200;
					if (obj60 != null)
					{
						Vector3 vector4 = (Vector3)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S2_v115 (UnityEngine.Vector3)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num89 = ((ComputeShader)(object)currentTouch21.current).FindKernel((string)(object)currentTouch22.last);
					bool flag7 = num89 == 0;
					result = (Vector3)typeof(UnityEngine.Object);
					if (flag7)
					{
						goto IL_26d4;
					}
				}
				nint num90 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v61 (Il2CppClass<UICamera>)+BA]");
				object obj61 = (nint)0 & (nint)0x200;
				if (obj61 != null)
				{
					nint num91 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v531 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch23 = UICamera.currentTouch;
				obj3 = currentTouch23.totalDelta;
				UICamera.MouseOrTouch currentTouch24 = UICamera.currentTouch;
				obj4 = currentTouch24.delta;
				nint num92 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S0_v68 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj62 = (nint)0 & (nint)0x200;
				if (obj62 != null)
				{
					nint num93 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v527 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj5 = obj3;
				obj6 = obj4;
				((Vector2*)(nint)vector2)->x = (float)obj5;
				((Vector2*)(nint)vector)->x = (float)obj6;
				Vector2 vector5 = vector2 - vector;
				obj7 = obj;
				((Vector2*)(nint)vector)->x = (float)obj7;
				currentTouch23.totalDelta = (Vector2)vector.x;
				object obj63 = UICamera.currentTouch + 36;
				object obj64 = obj63 * obj63;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S0_v84+4]");
				nint num94 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ S0_v84+4]");
				object obj65 = num94 * 0;
				obj66 = obj64 + obj65;
				UICamera.MouseOrTouch currentTouch25 = UICamera.currentTouch;
				if (!currentTouch25.dragStarted)
				{
					nint num95 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S0_v421 (Il2CppClass<UICamera>)+BA]");
					object obj67 = (nint)0 & (nint)0x200;
					if (obj67 != null)
					{
						nint num96 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ S0_v521 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch26 = UICamera.currentTouch;
					UICamera.MouseOrTouch currentTouch27 = UICamera.currentTouch;
					nint num97 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S2_v77 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj68 = (nint)0 & (nint)0x200;
					if (obj68 != null)
					{
						nint num98 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S2_v105 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)currentTouch26.last).FindKernel((string)(object)currentTouch27.current) != 0)
					{
						nint num99 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ S0_v432 (Il2CppClass<UICamera>)+BA]");
						object obj69 = (nint)0 & (nint)0x200;
						if (obj69 != null)
						{
							nint num100 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ S0_v515 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UICamera.MouseOrTouch currentTouch28 = UICamera.currentTouch;
						currentTouch28.dragStarted = true;
						UICamera.MouseOrTouch currentTouch29 = UICamera.currentTouch;
						UICamera.MouseOrTouch currentTouch30 = UICamera.currentTouch;
						((Vector2*)(nint)vector2)->x = (float)currentTouch30.totalDelta;
						obj8 = vector2.x;
						((Vector2*)(nint)vector)->x = (float)obj8;
						currentTouch29.delta = (Vector2)vector.x;
						UICamera.isDragging = true;
						if (UICamera.onDragStart != null)
						{
							nint num101 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ S0_v503 (Il2CppClass<UICamera>)+BA]");
							object obj70 = (nint)0 & (nint)0x200;
							if (obj70 != null)
							{
								nint num102 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ S0_v510 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							UICamera.MouseOrTouch currentTouch31 = UICamera.currentTouch;
							UICamera.onDragStart.EndInvoke((IAsyncResult)(object)currentTouch31.dragged);
						}
						nint num103 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S0_v452 (Il2CppClass<UICamera>)+BA]");
						object obj71 = (nint)0 & (nint)0x200;
						if (obj71 != null)
						{
							nint num104 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ S0_v496 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UICamera.MouseOrTouch currentTouch32 = UICamera.currentTouch;
						((UICamera)(object)currentTouch32.dragged).ProcessTouch((byte)(int)"OnDragStart" != 0, false);
						if (UICamera.onDragOver != null)
						{
							nint num105 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ S0_v484 (Il2CppClass<UICamera>)+BA]");
							object obj72 = (nint)0 & (nint)0x200;
							if (obj72 != null)
							{
								nint num106 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S0_v491 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							UICamera.MouseOrTouch currentTouch33 = UICamera.currentTouch;
							UICamera.MouseOrTouch currentTouch34 = UICamera.currentTouch;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
						}
						nint num107 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ S0_v466 (Il2CppClass<UICamera>)+BA]");
						object obj73 = (nint)0 & (nint)0x200;
						if (obj73 != null)
						{
							nint num108 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ S0_v478 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UICamera.MouseOrTouch currentTouch35 = UICamera.currentTouch;
						UICamera.MouseOrTouch currentTouch36 = UICamera.currentTouch;
						((UICamera)(object)currentTouch35.last).ProcessTouch((byte)(int)"OnDragOver" != 0, (byte)(int)currentTouch36.dragged != 0);
						UICamera.isDragging = false;
						obj74 = 0;
						goto IL_2b65;
					}
				}
				nint num109 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v387 (Il2CppClass<UICamera>)+BA]");
				object obj75 = (nint)0 & (nint)0x200;
				if (obj75 != null)
				{
					nint num110 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ S0_v414 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag8 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj66) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)speed);
				UICamera.MouseOrTouch currentTouch37 = UICamera.currentTouch;
				bool dragStarted = currentTouch37.dragStarted;
				object obj76 = (dragStarted ? 1 : 0) ^ 1;
				object obj77 = flag8 & obj76;
				if (obj77 != null)
				{
					nint num111 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ S0_v396 (Il2CppClass<UICamera>)+BA]");
					object obj78 = (nint)0 & (nint)0x200;
					if (obj78 != null)
					{
						nint num112 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S0_v408 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch38 = UICamera.currentTouch;
					currentTouch38.dragStarted = true;
					UICamera.MouseOrTouch currentTouch39 = UICamera.currentTouch;
					UICamera.MouseOrTouch currentTouch40 = UICamera.currentTouch;
					((Vector2*)(nint)vector2)->x = (float)currentTouch40.totalDelta;
					obj9 = vector2.x;
					((Vector2*)(nint)vector)->x = (float)obj9;
					currentTouch39.delta = (Vector2)vector.x;
					obj74 = 1;
				}
				else
				{
					obj74 = 0;
				}
				goto IL_2b65;
			}
		}
		goto IL_26d4;
		IL_1ca7:
		nint num113 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1526 @ S0_v137 (Il2CppClass<UICamera>)+BA]");
		object obj79 = (nint)0 & (nint)0x200;
		if (obj79 != null)
		{
			nint num114 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1607 @ S0_v222 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.onDrag != null)
		{
			nint num115 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1668 @ S0_v210 (Il2CppClass<UICamera>)+BA]");
			object obj80 = (nint)0 & (nint)0x200;
			if (obj80 != null)
			{
				nint num116 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1735 @ S0_v217 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch41 = UICamera.currentTouch;
			UICamera.MouseOrTouch currentTouch42 = UICamera.currentTouch;
			obj10 = currentTouch42.delta;
			((Vector2*)(nint)vector)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A09E");
		}
		nint num117 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1686 @ S0_v146 (Il2CppClass<UICamera>)+BA]");
		object obj81 = (nint)0 & (nint)0x200;
		if (obj81 != null)
		{
			nint num118 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1755 @ S0_v204 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch43 = UICamera.currentTouch;
		UICamera.MouseOrTouch currentTouch44 = UICamera.currentTouch;
		((Vector2*)(nint)vector)->x = (float)currentTouch44.delta;
		((Vector2*)(nint)vector2)->x = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		bool released5 = default;
		((UICamera)(object)currentTouch43.dragged).ProcessTouch((byte)(int)"OnDrag" != 0, released5);
		object obj82 = UICamera.currentTouch + 48;
		UICamera.MouseOrTouch currentTouch45 = UICamera.currentTouch;
		obj82 = currentTouch45.current;
		UICamera.isDragging = false;
		nint num119 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1889 @ S0_v163 (Il2CppClass<UICamera>)+BA]");
		object obj83 = (nint)0 & (nint)0x200;
		bool flag9 = obj83 == null;
		bool flag10;
		if (flag10)
		{
			bool flag11 = !flag9;
			bool flag12 = !flag11;
			result = (Vector3)typeof(UICamera);
			if (!flag12)
			{
				nint num120 = (nint)typeof(UICamera);
				result = (Vector3)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1923 @ S0_v199 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					result = (Vector3)typeof(UICamera);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+5C]");
			object obj84 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1929 @ S0_v197+A0]");
			object obj85 = 0;
			_ = 0;
		}
		else
		{
			bool flag13 = !flag9;
			bool flag14 = !flag13;
			result = (Vector3)typeof(UICamera);
			if (!flag14)
			{
				nint num121 = (nint)typeof(UICamera);
				result = (Vector3)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1930 @ S0_v188 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					result = (Vector3)typeof(UICamera);
				}
			}
			bool flag15 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj66) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)t);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+5C]");
			object obj86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1939 @ S1_v100+A0]");
			object obj87 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1940 @ S1_v101+48]");
			bool flag16 = (nint)0 == 2;
			object obj88 = flag15 & flag16;
			if (obj88 != null)
			{
				nint num122 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1953 @ S0_v176 (Il2CppClass<UICamera>)+BA]");
				object obj89 = (nint)0 & (nint)0x200;
				bool flag17 = obj89 == null;
				result = (Vector3)typeof(UICamera);
				if (!flag17)
				{
					nint num123 = (nint)typeof(UICamera);
					result = (Vector3)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1977 @ S0_v183 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						result = (Vector3)typeof(UICamera);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+5C]");
				object obj90 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1983 @ S0_v181+A0]");
				object obj91 = 0;
				_ = 0;
			}
		}
		goto IL_26d4;
		IL_26d4:
		return result;
		IL_2b65:
		nint num124 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S0_v95 (Il2CppClass<UICamera>)+BA]");
		object obj92 = (nint)0 & (nint)0x200;
		bool flag18 = obj92 == null;
		result = (Vector3)typeof(UICamera);
		if (!flag18)
		{
			nint num125 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ S0_v379 (Il2CppClass<UICamera>)+74]");
			bool flag19 = (nint)0 == 0;
			bool flag20 = !flag19;
			result = (Vector3)typeof(UICamera);
			if (!flag20)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				result = (Vector3)typeof(UICamera);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+5C]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ S0_v100+A0]");
		object obj94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ S0_v101+4E]");
		if ((nint)0 != 0)
		{
			nint num126 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ S0_v104 (Il2CppClass<UICamera>)+BA]");
			object obj95 = (nint)0 & (nint)0x200;
			if (obj95 != null)
			{
				nint num127 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ S0_v373 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num128 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ S1_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj96 = (nint)0 & (nint)0x200;
			if (obj96 != null)
			{
				nint num129 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ S1_v152 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)UICamera.mTooltip).FindKernel((string)null) != 0)
			{
				nint num130 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ S0_v363 (Il2CppClass<UICamera>)+BA]");
				object obj97 = (nint)0 & (nint)0x200;
				if (obj97 != null)
				{
					nint num131 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ S0_v369 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BMFont bmFont2 = ((UIFont)null).bmFont;
			}
			nint num132 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ S0_v114 (Il2CppClass<UICamera>)+BA]");
			object obj98 = (nint)0 & (nint)0x200;
			if (obj98 != null)
			{
				nint num133 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ S0_v356 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.isDragging = true;
			UICamera.MouseOrTouch currentTouch46 = UICamera.currentTouch;
			bool flag21 = currentTouch46.clickNotification == UICamera.ClickNotification.None;
			object obj99 = obj74 ^ 1;
			object obj100 = flag21 & obj99;
			bool flag22 = (byte)(obj100 & 1) != 0;
			nint num134 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1248 @ S0_v130 (Il2CppClass<UICamera>)+BA]");
			object obj101 = (nint)0 & (nint)0x200;
			bool flag23 = obj101 == null;
			if (obj74 != null)
			{
				if (!flag23)
				{
					nint num135 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1317 @ S0_v351 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UICamera.onDragStart != null)
				{
					nint num136 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1377 @ S0_v339 (Il2CppClass<UICamera>)+BA]");
					object obj102 = (nint)0 & (nint)0x200;
					if (obj102 != null)
					{
						nint num137 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ S0_v346 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch47 = UICamera.currentTouch;
					UICamera.onDragStart.EndInvoke((IAsyncResult)(object)currentTouch47.dragged);
				}
				nint num138 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1393 @ S0_v325 (Il2CppClass<UICamera>)+BA]");
				object obj103 = (nint)0 & (nint)0x200;
				if (obj103 != null)
				{
					nint num139 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1430 @ S0_v333 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch48 = UICamera.currentTouch;
				((UICamera)(object)currentTouch48.dragged).ProcessTouch((byte)(int)"OnDragStart" != 0, false);
				flag10 = flag21;
			}
			else
			{
				if (!flag23)
				{
					nint num140 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1327 @ S0_v312 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch49 = UICamera.currentTouch;
				UICamera.MouseOrTouch currentTouch50 = UICamera.currentTouch;
				nint num141 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1343 @ S2_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj104 = (nint)0 & (nint)0x200;
				if (obj104 != null)
				{
					nint num142 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1400 @ S2_v58 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)currentTouch49.last).FindKernel((string)(object)currentTouch50.current) == 0)
				{
					flag10 = flag22;
					goto IL_1ca7;
				}
				nint num143 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1454 @ S0_v270 (Il2CppClass<UICamera>)+BA]");
				object obj105 = (nint)0 & (nint)0x200;
				if (obj105 != null)
				{
					nint num144 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ S0_v306 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UICamera.onDragOut != null)
				{
					nint num145 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1619 @ S0_v294 (Il2CppClass<UICamera>)+BA]");
					object obj106 = (nint)0 & (nint)0x200;
					if (obj106 != null)
					{
						nint num146 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1693 @ S0_v301 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UICamera.MouseOrTouch currentTouch51 = UICamera.currentTouch;
					UICamera.MouseOrTouch currentTouch52 = UICamera.currentTouch;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
					flag10 = flag21;
				}
				else
				{
					flag10 = flag22;
				}
				nint num147 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1720 @ S0_v279 (Il2CppClass<UICamera>)+BA]");
				object obj107 = (nint)0 & (nint)0x200;
				if (obj107 != null)
				{
					nint num148 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1779 @ S0_v287 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch53 = UICamera.currentTouch;
				UICamera.MouseOrTouch currentTouch54 = UICamera.currentTouch;
				((UICamera)(object)currentTouch53.last).ProcessTouch((byte)(int)"OnDragOut" != 0, (byte)(int)currentTouch54.dragged != 0);
			}
			if (UICamera.onDragOver != null)
			{
				nint num149 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1584 @ S0_v248 (Il2CppClass<UICamera>)+BA]");
				object obj108 = (nint)0 & (nint)0x200;
				if (obj108 != null)
				{
					nint num150 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1638 @ S0_v255 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch55 = UICamera.currentTouch;
				UICamera.MouseOrTouch currentTouch56 = UICamera.currentTouch;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
			nint num151 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1602 @ S0_v234 (Il2CppClass<UICamera>)+BA]");
			object obj109 = (nint)0 & (nint)0x200;
			if (obj109 != null)
			{
				nint num152 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1653 @ S0_v242 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera.MouseOrTouch currentTouch57 = UICamera.currentTouch;
			UICamera.MouseOrTouch currentTouch58 = UICamera.currentTouch;
			((UICamera)(object)currentTouch57.current).ProcessTouch((byte)(int)"OnDragOver" != 0, (byte)(int)currentTouch58.dragged != 0);
			goto IL_1ca7;
		}
		goto IL_26d4;
	}

	private void RepositionCoins(float speed)
	{
		TrackObject trackObject = _trackObject;
		if (~(trackObject._active ? 1u : 0u) == 0 && _scaleMode != ScaleMode.NoScale)
		{
			((Character)this).OffsetFromFloorY = speed;
		}
	}

	private unsafe void ResizeIfNeeded(float speed)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Ref, but got Unknown
		//IL_0118: Expected Obj, but got I4
		if (~(_redistributeAlongCurveOnSpeedChange ? 1u : 0u) != 0)
		{
			Game_OnSpeedChanged(speed);
		}
		IRequest request = default;
		Transform transform = (Transform)(request + 12);
		List<Coin> placedCoins = _placedCoins;
		object obj = _coinsAtSpawn - placedCoins._size;
		int num = 0;
		while (true)
		{
			List<Coin> placedCoins2 = _placedCoins;
			if (num < placedCoins2._size)
			{
				ref float reference = ref *(float*)(obj + num);
				IEnumerator enumerator = ((Character)this).ToggleDustWithDelay(speed);
				int index;
				if (enumerator == null)
				{
					index = num;
				}
				else
				{
					index = ((num <= _coinIndexToSkip) ? num : (num - 1));
				}
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != (void*)_coinIndexToSkip)
				{
					Coin coin = _placedCoins.get_Item(index);
					GameObject gameObject = coin.gameObject;
					WebClient.DoSimulation(request, ref *(Action*)this, ref reference, speed, (IList<SimulatedRequestResult>)1);
					transform = (Transform)request;
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (Kiloo.Common.HTTP.IRequest)+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					Vector3 localPosition = transform.localPosition;
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	private unsafe Coin SpawnCoin(Vector3 spawnPos)
	{
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_0546: Expected Obj, but got I4
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_0563: Expected Obj, but got I4
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_0580: Expected Obj, but got I4
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_059d: Expected Obj, but got I4
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_05ba: Expected Obj, but got I4
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_05d7: Expected Obj, but got I4
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_05f4: Expected Obj, but got I4
		//IL_0612: Expected I, but got Obj
		//IL_0628: Expected Obj, but got I
		//IL_0666: Expected I4, but got Obj
		//IL_0682: Expected I, but got Obj
		//IL_0698: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected VT, but got Unknown
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected VT, but got Unknown
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Expected Obj, but got Unknown
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected Obj, but got Unknown
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected Obj, but got Unknown
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected Obj, but got Unknown
		//IL_09f0: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00db: Expected Obj, but got I4
		//IL_0109: Expected F4, but got Obj
		//IL_0104: Expected native int or pointer, but got VT
		//IL_011e: Expected F4, but got I
		//IL_0119: Expected native int or pointer, but got VT
		//IL_012b: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0169: Expected Obj, but got I4
		//IL_0197: Expected F4, but got Obj
		//IL_0192: Expected native int or pointer, but got VT
		//IL_01ac: Expected F4, but got I
		//IL_01a7: Expected native int or pointer, but got VT
		//IL_01b9: Expected Obj, but got I4
		//IL_01e5: Expected I, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_06c2: Expected F4, but got Obj
		//IL_06bd: Expected native int or pointer, but got VT
		//IL_06d7: Expected F4, but got I
		//IL_06d2: Expected native int or pointer, but got VT
		//IL_06e4: Expected F4, but got Obj
		//IL_06df: Expected native int or pointer, but got VT
		//IL_06f9: Expected F4, but got I
		//IL_06f4: Expected native int or pointer, but got VT
		//IL_0724: Invalid comparison between F4 and I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02c7: Expected I, but got Obj
		//IL_02dd: Expected Obj, but got I
		//IL_0226: Expected I, but got Obj
		//IL_0755: Expected F4, but got Obj
		//IL_0750: Expected native int or pointer, but got VT
		//IL_076a: Expected F4, but got I
		//IL_0765: Expected native int or pointer, but got VT
		//IL_0777: Expected F4, but got Obj
		//IL_0772: Expected native int or pointer, but got VT
		//IL_078c: Expected F4, but got I
		//IL_0787: Expected native int or pointer, but got VT
		//IL_07c8: Expected F4, but got Obj
		//IL_07c3: Expected native int or pointer, but got VT
		//IL_07dd: Expected F4, but got I
		//IL_07d8: Expected native int or pointer, but got VT
		//IL_07ea: Expected F4, but got Obj
		//IL_07e5: Expected native int or pointer, but got VT
		//IL_07ff: Expected F4, but got I
		//IL_07fa: Expected native int or pointer, but got VT
		//IL_026e: Expected Obj, but got I4
		//IL_0395: Expected Obj, but got I4
		//IL_0308: Expected I, but got Obj
		//IL_08c8: Expected I, but got Obj
		//IL_08de: Expected Obj, but got I
		//IL_0a2c: Expected F4, but got Obj
		//IL_0a27: Expected native int or pointer, but got VT
		//IL_0a41: Expected F4, but got I
		//IL_0a3c: Expected native int or pointer, but got VT
		//IL_0a4e: Expected F4, but got Obj
		//IL_0a49: Expected native int or pointer, but got VT
		//IL_0a63: Expected F4, but got I
		//IL_0a5e: Expected native int or pointer, but got VT
		//IL_03a8: Expected I, but got Obj
		//IL_091e: Expected I, but got Obj
		//IL_0934: Expected Obj, but got I
		//IL_0405: Expected Obj, but got I4
		//IL_0b1e: Expected F4, but got Obj
		//IL_0b19: Expected native int or pointer, but got VT
		//IL_0b33: Expected F4, but got I
		//IL_0b2e: Expected native int or pointer, but got VT
		//IL_0b40: Expected F4, but got Obj
		//IL_0b3b: Expected native int or pointer, but got VT
		//IL_0b55: Expected F4, but got I
		//IL_0b50: Expected native int or pointer, but got VT
		//IL_0442: Expected I, but got Obj
		//IL_095f: Expected I, but got Obj
		//IL_0975: Expected Obj, but got I
		//IL_049f: Expected Obj, but got I4
		//IL_0c10: Expected F4, but got Obj
		//IL_0c0b: Expected native int or pointer, but got VT
		//IL_0c25: Expected F4, but got I
		//IL_0c20: Expected native int or pointer, but got VT
		//IL_0c32: Expected F4, but got Obj
		//IL_0c2d: Expected native int or pointer, but got VT
		//IL_0c47: Expected F4, but got I
		//IL_0c42: Expected native int or pointer, but got VT
		//IL_04d4: Expected I, but got Obj
		//IL_051c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 132;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 120;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 108;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 96;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 84;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 72;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 60;
		obj8 = 0;
		_ = 0;
		Camera menuCamera = ((InputManager)this)._menuCamera;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v245 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = menuCamera != null;
		bool flag2 = !flag;
		bool flag3 = (byte)(int)menuCamera != 0;
		if (!flag2)
		{
			bool flag4 = ((InputManager)this).HandleTap();
			flag3 = flag4;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v239 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 156);
		Quaternion quaternion = (Quaternion)(obj2 + 144);
		object obj11 = obj2 + 48;
		object obj12 = obj2 + 36;
		object obj13 = obj2 + 24;
		object obj14 = obj2 + 12;
		Coin result;
		if (((ComputeShader)flag3).FindKernel(null) != 0)
		{
			object obj15 = spawnPos + 8;
			object obj16 = spawnPos + 8;
			obj11 = 0;
			_ = 0;
			obj11 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v66+4]");
			_ = 0;
			_ = 2f;
			((Vector3*)(nint)vector)->x = (float)obj11;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = ((Camera)flag3).ScreenToViewportPoint(vector);
			obj = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v51+8]");
			_ = 0;
			object obj17 = spawnPos + 20;
			object obj18 = spawnPos + 20;
			obj13 = 0;
			_ = 0;
			obj13 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v82+4]");
			_ = 0;
			_ = 2f;
			((Vector3*)(nint)vector)->x = (float)obj13;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v53+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			Vector3 vector5 = ((Camera)flag3).ScreenToViewportPoint(vector);
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v95 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v235 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Quaternion*)(nint)quaternion)->x = (float)obj14;
			Quaternion quaternion2 = quaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v55+8]");
			((Quaternion*)(nint)quaternion2)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector6 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			float num7 = Quaternion.Dot(quaternion, (Quaternion)vector);
			CoinSpaceMode spacingMode = _spacingMode;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v80 (SYBO.Subway.Coins.CoinCurve+CoinSpaceMode)+8]");
			if (num7 < 0f)
			{
				result = (Coin)4;
			}
			else
			{
				object obj20 = spawnPos + 20;
				obj11 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S1_v84+8]");
				_ = 0;
				object obj21 = spawnPos + 8;
				obj12 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S1_v89+8]");
				_ = 0;
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v112 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num9 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v230 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Quaternion*)(nint)quaternion)->x = (float)obj11;
				Quaternion quaternion3 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49+8]");
				((Quaternion*)(nint)quaternion3)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)obj12;
				Vector3 vector7 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v51+8]");
				((Vector3*)(nint)vector7)->z = 0f;
				Quaternion quaternion4 = Quaternion.FromToRotation((Vector3)quaternion, vector);
				obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v53+8]");
				_ = 0;
				Vector3 down = Vector3.down;
				((Quaternion*)(nint)quaternion)->x = (float)obj14;
				Quaternion quaternion5 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v55+8]");
				((Quaternion*)(nint)quaternion5)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector8 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector8)->z = 0f;
				float num10 = quaternion.x * vector.x;
				float num11 = quaternion.y * vector.y;
				float num12 = num10 + num11;
				float num13 = quaternion.z * vector.z;
				float num14 = num12 + num13;
				obj4 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v55+8]");
				_ = 0;
				float num15;
				Coin coin;
				if (num14 > 0f)
				{
					obj3 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
					_ = 0;
					num15 = num14;
					coin = null;
				}
				else
				{
					obj3 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v55+8]");
					_ = 0;
					num15 = 0f;
					coin = (Coin)4;
				}
				obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				nint num16 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v141 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj23 = (nint)0 & (nint)0x200;
				if (obj23 != null)
				{
					nint num17 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v219 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 left = Vector3.left;
				((Quaternion*)(nint)quaternion)->x = (float)obj11;
				Quaternion quaternion6 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49+8]");
				((Quaternion*)(nint)quaternion6)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)obj12;
				Vector3 vector9 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v51+8]");
				((Vector3*)(nint)vector9)->z = 0f;
				float num18 = quaternion.x * vector.x;
				float num19 = quaternion.y * vector.y;
				float num20 = num18 + num19;
				float num21 = quaternion.z * vector.z;
				float num22 = num20 + num21;
				obj6 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49+8]");
				_ = 0;
				if (num22 > num15)
				{
					obj5 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
					_ = 0;
					result = (Coin)1;
					num15 = num22;
				}
				else
				{
					obj5 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49+8]");
					_ = 0;
					result = coin;
				}
				obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
				_ = 0;
				nint num23 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v163 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num24 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S0_v209 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 right = Vector3.right;
				((Quaternion*)(nint)quaternion)->x = (float)obj11;
				Quaternion quaternion7 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49+8]");
				((Quaternion*)(nint)quaternion7)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)obj12;
				Vector3 vector10 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v51+8]");
				((Vector3*)(nint)vector10)->z = 0f;
				float num25 = quaternion.x * vector.x;
				float num26 = quaternion.y * vector.y;
				float num27 = num25 + num26;
				float num28 = quaternion.z * vector.z;
				float num29 = num27 + num28;
				obj8 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49+8]");
				_ = 0;
				if (num29 > num15)
				{
					obj7 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
					_ = 0;
					result = (Coin)2;
					num15 = num29;
				}
				else
				{
					obj7 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49+8]");
					_ = 0;
				}
				nint num30 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S0_v183 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				if (obj25 != null)
				{
					nint num31 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v199 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Quaternion identity = Quaternion.identity;
				((Quaternion*)(nint)quaternion)->x = (float)obj7;
				Quaternion quaternion8 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
				((Quaternion*)(nint)quaternion8)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)obj11;
				Vector3 vector11 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v49+8]");
				((Vector3*)(nint)vector11)->z = 0f;
				float num32 = quaternion.x * vector.x;
				float num33 = quaternion.y * vector.y;
				float num34 = num32 + num33;
				float num35 = quaternion.z * vector.z;
				float num36 = num34 + num35;
				if (num36 > num15)
				{
					result = (Coin)3;
				}
			}
		}
		else
		{
			result = (Coin)4;
		}
		return result;
	}

	private float ScaleZ(float speed, float z)
	{
		if (!(z > speed))
		{
			return speed;
		}
		float num = ((SyboRandom)(object)this).Value();
		float num2 = z - speed;
		float num3 = num * num2;
		return num3 + speed;
	}

	private float JumpLength(float speed)
	{
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I4
		//IL_0250: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I4
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_013b: Expected I, but got Obj
		object obj = this - -64;
		float heightOffset = ((DizzyStarsHeightControl)obj).HeightOffset;
		object obj2 = lastSpawnedCoinIndex + 236;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v7+8]");
		_ = 0;
		float num = speed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float num2 = num - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v64 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		int num5 = computeShader.FindKernel(null);
		bool flag = num5 == 0;
		float num6 = num2;
		float gamePositionZ = heightOffset;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v34+90]");
			bool flag2;
			if ((nint)0 != 0)
			{
				flag2 = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v34+84]");
				flag2 = (nint)0 == 3;
			}
			bool flag3 = !flag2;
			num6 = num2;
			gamePositionZ = heightOffset;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				RouteBuilder routeBuilder = default;
				int spawnedLeadingEdgeWorldPositionZ = routeBuilder.SpawnedLeadingEdgeWorldPositionZ;
				object obj5 = lastSpawnedCoinIndex + 236;
				obj3 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v31+8]");
				_ = 0;
				nint num7 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v45 (Il2CppClass<System.Math>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(Math);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v56 (Il2CppClass<System.Math>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj7 = this - -64;
				object obj8 = obj7;
				float num9 = spawnedLeadingEdgeWorldPositionZ;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				float num10 = num9 - 0f;
				float num11;
				float num12;
				if (0f > num10)
				{
					num11 = 0f;
					num12 = 0f;
				}
				else
				{
					num11 = num10;
					num12 = num10;
				}
				float num13 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v51+44]");
				float num14 = num13 / 0f;
				float num15 = heightOffset + num14;
				float num16 = num2 - num11;
				num6 = num16;
				gamePositionZ = num15;
			}
		}
		if (num6 < 0f)
		{
			return 0f;
		}
		object obj9 = this - -64;
		float num17 = ((RouteManager)obj9).ComputeDefaultRouteTimeUntilPosition(gamePositionZ);
		return num6 / num17;
	}

	private float LengthOfCurve(float speed)
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
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
		if (_character != null)
		{
			nint num3 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v13 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Character);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = this + 40;
			CharacterRendering instance = CharacterRendering.Instance;
			obj3 = instance;
		}
		Character character = _character;
		return UIExtensions.CenterTransformsHorizontalFixedWidth((Transform[])(object)_character, speed, character.jumpHeightNormal);
	}

	private float CoinSpacing(float speed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I
		SocialManager socialManager2 = default;
		SocialManager socialManager = (SocialManager)(socialManager2 + 12);
		socialManager.ReportAchievement((string)(object)_curveParent, 1f);
		socialManager2.ReportAchievement((string)(object)_curveParent, 0f);
		object obj = (nint)((UnityEngine.Object)socialManager).m_CachedPtr - (nint)((UnityEngine.Object)socialManager2).m_CachedPtr;
		float num = speed / 110f;
		if (_scaleMode == ScaleMode.NoScale)
		{
			num = 1f;
		}
		return num * (float)obj;
	}

	private int NumberOfCoinsIgnoringSkip(float speed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_038b: Expected Obj, but got I4
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_03c3: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_01a6: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_04e1: Expected I4, but got Obj
		//IL_0113: Invalid comparison between I and F4
		//IL_022e: Expected Obj, but got I
		//IL_04f2: Expected Obj, but got I
		//IL_02ca: Expected Obj, but got I
		//IL_0145: Invalid comparison between I and F4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_0456: Expected Obj, but got I4
		//IL_0466: Expected Obj, but got I
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected Obj, but got Unknown
		LinkedList<> linkedList = default;
		object obj = linkedList - -64;
		object obj2 = linkedList + 32;
		obj2 = 0;
		_ = 0;
		_ = 0;
		object obj3 = linkedList + 24;
		obj3 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinCurve)+CC]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v21+C]");
		GamePositionRoot gamePositionRoot;
		if ((nint)0 < (nint)1)
		{
			nint num = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v121 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v127 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			gamePositionRoot = GamePositionRoot.Instance;
			goto IL_0401;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinCurve)+CC]");
		((LinkedList<T>)(object)linkedList).Remove((LinkedListNode<T>)0);
		obj2 = linkedList;
		_ = linkedList.head;
		_ = linkedList.version;
		object obj6 = default;
		GamePositionRoot gamePositionRoot2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v100+C]");
				if (!(0f > speed))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v100+10]");
					if (0f > speed)
					{
						object obj7 = obj3 + 4;
						object obj8 = obj7 + 1;
						obj7 = obj8;
						object obj9 = obj8 << 2;
						object obj10 = obj3 + obj9;
						obj10 = 111;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v100+8]");
						gamePositionRoot2 = (GamePositionRoot)0;
						break;
					}
				}
				continue;
			}
			object obj11 = obj3 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj3 + obj13;
			obj14 = 88;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj3 + obj15;
			if ((nint)obj16 == 111)
			{
				object obj17 = obj3 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_04dc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj3 + obj19;
			if ((nint)obj20 == 88)
			{
				object obj21 = obj3 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_04e1;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04e1;
		IL_0401:
		gamePositionRoot2 = gamePositionRoot;
		goto IL_04dc;
		IL_04e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Coins.CoinCurve)+CC]");
		RouteBuilder.EnvironmentRangeWrapper environmentRangeWrapper = Enumerable.Last((IEnumerable<RouteBuilder.EnvironmentRangeWrapper>)0);
		gamePositionRoot = (GamePositionRoot)(object)environmentRangeWrapper.EnvironmentKind;
		goto IL_0401;
		IL_04dc:
		return (int)gamePositionRoot2;
	}

	private int NumberOfCoins(float speed)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		float value = CoinSpacing(speed);
		float num = ((Character)this).CalculateJumpVerticalSpeed(speed);
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v13 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num4 = Math.Abs(value);
		float f = num4 / num;
		int num5 = Mathf.RoundToInt(f);
		return num5 + 1;
	}

	private bool IsSkippingCoin(float speed)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected I4, but got Unknown
		int num = NumberOfCoins(speed);
		IEnumerator enumerator = ((Character)this).ToggleDustWithDelay(speed);
		object obj = enumerator & 1;
		return (byte)(num - obj) != 0;
	}

	private void ToggleRenderers(bool doRender)
	{
		//IL_0038: Expected Obj, but got I4
		//IL_000e: Expected VT, but got Obj
		//IL_001c: Expected Obj, but got VT
		if (~(_redistributeAlongCurveOnSpeedChange ? 1u : 0u) == 0)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((CoinRenderer)val).ToggleRenderers(enabled: false);
		}
		GameObject value = gameObject;
		((CharacterRenderingEffects)doRender).OnDoubleJump += (CharacterRenderingEffects.OnDoubleJumpDelegate)(object)value;
		((Coin)this).Activate(false);
	}

	private void TrackObject_OnActivate()
	{
		TrackObject trackObject = _trackObject;
		if (~(trackObject._active ? 1u : 0u) == 0)
		{
			PogoStick_OnStart();
		}
	}

	private void ActivateOneCoinUtilDone()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I4
		_coinsAtSpawn = 0;
		List<Vector3> coinPositions = GetCoinPositions();
		if (coinPositions != null)
		{
			float unscaledCoinSpacing = UnscaledCoinSpacing;
			int coinsAtSpawn = NumberOfCoins(unscaledCoinSpacing);
			_coinsAtSpawn = coinsAtSpawn;
			lastSpawnedCoinIndex = -1;
			object obj = this - -64;
			obj = 1;
		}
	}

	private void Update()
	{
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I4
		//IL_0105: Expected I, but got Obj
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0182: Invalid comparison between I and F4
		//IL_01b9: Expected Obj, but got I4
		Character character = default;
		Coin coin = (Coin)(character + 12);
		int num = lastSpawnedCoinIndex + 1;
		lastSpawnedCoinIndex = num;
		if (lastSpawnedCoinIndex < _coinsAtSpawn)
		{
			if (lastSpawnedCoinIndex == _coinIndexToSkip)
			{
				return;
			}
			character.RouteManager_OnRouteCreated((object)this, (RouteManager.RouteCreatedEventArgs)lastSpawnedCoinIndex);
			coin = (Coin)(object)character;
			((UnityEngine.Object)coin).m_CachedPtr = ((UnityEngine.Object)character).m_CachedPtr;
			bool flag = ((CoinManager)this).IsSpawned(coin);
		}
		object obj = _coinsAtSpawn - 1;
		if ((nint)obj > lastSpawnedCoinIndex)
		{
			return;
		}
		nint num2 = (nint)typeof(CoinStats);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v22 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(CoinStats);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v38 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinStats coinStats = CoinStats.New;
		int num4 = _coinsAtSpawn + coinStats.ActivatedSpawnPoints__BackingField;
		coinStats.ActivatedSpawnPoints__BackingField = num4;
		if (IsZAvailableToJetpackState())
		{
			object obj3 = _character + 236;
			coin = (Coin)obj3;
			Coin coin2 = coin;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v25+8]");
			((UnityEngine.Object)coin2).m_CachedPtr = (IntPtr)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (SYBO.Subway.Coins.Coin)+4]");
			Coin coin3;
			if (0f > 70f)
			{
				bool isInPogostickMode = ((Game)null).IsInPogostickMode;
				coin3 = (Coin)((isInPogostickMode ? 1 : 0) ^ 1);
			}
			else
			{
				coin3 = null;
			}
			DeactivateCoin(coin3);
		}
		_allCoinsActive = true;
		object obj4 = this - -64;
		obj4 = 0;
	}

	protected bool IsZAvailableToJetpackState()
	{
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected VT, but got Obj
		//IL_007f: Invalid comparison between I and F4
		string text = tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)text).FindKernel((string)null) != 0)
		{
			GameObject gameObject = base.gameObject;
			Transform transform = default;
			transform.position = (Vector3)gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
			return 0f > 70f;
		}
		return false;
	}

	private void TrackObject_OnDeactivate()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this - -64;
		if (obj != null)
		{
			Update();
		}
	}

	public void DeactivateCoin(Coin coin)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
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

	private void Game_OnSpeedChanged(float newSpeed)
	{
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I4
		//IL_0331: Expected I, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected I4, but got Unknown
		//IL_0051: Expected I, but got Obj
		//IL_01c3: Expected I, but got Obj
		//IL_01d9: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected I4, but got Unknown
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0204: Expected I, but got Obj
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected I4, but got Unknown
		//IL_014f: Expected I, but got Obj
		Character character = default;
		Coin coin = (Coin)(character + 12);
		if (~(_allCoinsActive ? 1u : 0u) != 0)
		{
			return;
		}
		bool flag = IsSkippingCoin(newSpeed);
		List<Coin> placedCoins = _placedCoins;
		int[] array = (int[])((flag ? 1 : 0) - placedCoins._size);
		bool flag2 = (nint)array > -1;
		object obj2 = default;
		object obj5 = default;
		while (true)
		{
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v68 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = Mathf.Min(array);
			if ((nint)obj2 >= num3)
			{
				break;
			}
			List<Coin> placedCoins2 = _placedCoins;
			if (flag2)
			{
				RouteManager.RouteCreatedEventArgs args = (RouteManager.RouteCreatedEventArgs)(obj2 + placedCoins2._size);
				character.RouteManager_OnRouteCreated((object)this, args);
				coin = (Coin)(object)character;
				((UnityEngine.Object)coin).m_CachedPtr = ((UnityEngine.Object)character).m_CachedPtr;
				bool flag3 = ((CoinManager)this).IsSpawned(coin);
				nint num4 = (nint)typeof(CoinStats);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(CoinStats);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v62 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CoinStats coinStats = CoinStats.New;
				int num6 = array + coinStats.ActivatedSpawnPoints__BackingField;
				coinStats.ActivatedSpawnPoints__BackingField = num6;
			}
			else
			{
				Coin coin2 = _placedCoins.get_Item(0);
				coin2.Activate();
				nint num7 = (nint)typeof(CoinStats);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v36 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(CoinStats);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v43 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CoinStats coinStats2 = CoinStats.New;
				int num9 = array + coinStats2.DeactivatedSpawnPoints__BackingField;
				coinStats2.DeactivatedSpawnPoints__BackingField = num9;
			}
			obj2 = obj5 + 1;
		}
		int coinsAtSpawn = array + _coinsAtSpawn;
		_coinsAtSpawn = coinsAtSpawn;
	}

	private void Jetpack_OnStart()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CoinStats);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CoinStats);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Subway.Coins.CoinStats>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinStats coinStats = CoinStats.New;
		int num3 = _coinsAtSpawn + coinStats.DeactivatedSpawnPoints__BackingField;
		coinStats.DeactivatedSpawnPoints__BackingField = num3;
	}

	private void PogoStick_OnStart()
	{
		if (IsZAvailableToJetpackState())
		{
			_trackObject._002Ector();
		}
	}

	public void OnDrawGizmos()
	{
		//IL_002e: Expected Obj, but got I4
		if (IsZAvailableToJetpackState())
		{
			DeactivateCoin((Coin)1);
		}
	}

	public unsafe void DrawCurve(float speed, Color color)
	{
		//IL_0022: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I
		//IL_006d: Expected Obj, but got I
		//IL_0082: Expected Obj, but got VT
		//IL_00b5: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0135: Expected VT, but got Obj
		if ((object)_curveParent != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Queue<_00210> queue = default;
			queue._array = (_00210[])num;
			queue._size = 0;
			object obj = queue + 16;
			obj = this;
			System.Runtime.CompilerServices.Unsafe.Write((void*)((UnityEngine.Object)this).m_CachedPtr, new Queue<T>.Enumerator((Queue<T>)(object)queue));
			_curveParent = null;
		}
		IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v11 (System.IntPtr)+C]");
		int num2 = 0;
		IntPtr cachedPtr2;
		while (true)
		{
			cachedPtr2 = ((UnityEngine.Object)this).m_CachedPtr;
			int num3 = num2 - 1;
			if (num3 < 0)
			{
				break;
			}
			Route route = ((List<Route>)(nint)cachedPtr2).get_Item(num3);
			((RouteCollection)(object)route).Update(speed, (SyboRandom)color);
			num2 = num3;
		}
		int num4 = ((List<Route>)(nint)cachedPtr2)._size;
		RouteBuilder routeBuilder = default;
		while (true)
		{
			int num5 = num4 - 1;
			if (num5 >= 0)
			{
				Route route2 = ((List<Route>)(nint)((UnityEngine.Object)this).m_CachedPtr).get_Item(num5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				if (routeBuilder.IsDoneLayingSections && routeBuilder.SpawnedChunkCount != 0)
				{
					Route route3 = ((List<Route>)(nint)((UnityEngine.Object)this).m_CachedPtr).get_Item(num5);
					((RouteCollection)(object)this).DrawBounds((Bounds)route3);
				}
				num4 = num5;
				continue;
			}
			break;
		}
	}

	public List<Vector3> GetCoinPositions()
	{
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_01a0: Expected Obj, but got I4
		//IL_011a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0180: Expected VT, but got Obj
		//IL_0180: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(GameStateMachine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v31 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
		FlyingState flyingState = ((StateMachine)useBenchmarkRoute).TryGetCurrentState<FlyingState>();
		if (flyingState != null)
		{
			nint num3 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v27 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isRestricted = AgeRestriction.isRestricted;
			GameObject gameObject = base.gameObject;
			Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
			object obj3 = flyingState - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			bool flag = 0 > (nint)obj3;
			return (List<Vector3>)flag;
		}
		return (List<Vector3>)1;
	}

	public unsafe CoinCurve()
	{
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Ref, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected VT, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected Obj, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04ce: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_053d: Expected I, but got Obj
		//IL_0553: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_058c: Expected Obj, but got I4
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_05a7: Expected Obj, but got F4
		//IL_01bd: Expected I, but got Obj
		//IL_03db: Expected Ref, but got F4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_0275: Expected I, but got Obj
		//IL_028b: Expected Obj, but got I
		//IL_05e7: Expected F4, but got Obj
		//IL_05e2: Expected native int or pointer, but got VT
		//IL_05fc: Expected F4, but got I
		//IL_05f7: Expected native int or pointer, but got VT
		//IL_061e: Expected VT, but got Ref
		//IL_0645: Expected VT, but got Ref
		//IL_0652: Expected F4, but got Obj
		//IL_064d: Expected native int or pointer, but got VT
		//IL_0667: Expected F4, but got I
		//IL_0662: Expected native int or pointer, but got VT
		//IL_0689: Expected VT, but got Ref
		//IL_0321: Expected VT, but got Ref
		//IL_02b6: Expected I, but got Obj
		//IL_0337: Expected F4, but got Obj
		//IL_0332: Expected native int or pointer, but got VT
		//IL_034c: Expected F4, but got I
		//IL_0347: Expected native int or pointer, but got VT
		//IL_036e: Expected Ref, but got VT
		object obj = default;
		ref Color reference = ref *(Color*)(obj + 120);
		Vector3 vector = (Vector3)(obj + 104);
		Character character = (Character)(obj + 72);
		object obj2 = obj + 60;
		object obj3 = obj + 48;
		object obj4 = obj + 36;
		object obj5 = obj + 24;
		object obj6 = obj + 12;
		object obj7 = obj + 88;
		obj7 = 0;
		_ = 0;
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v115 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_game != null)
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v120 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v126 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj10 = this + 52;
			bool isInstantiated = Game.IsInstantiated;
			obj10 = isInstantiated;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v107 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_game != null)
		{
			return;
		}
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v115 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj7 = vector.x;
		_ = vector.z;
		Color green = Color.green;
		reference = ref *(Color*)character;
		_ = ((UnityEngine.Object)character).m_CachedPtr;
		Gizmos.set_color_Injected(ref reference);
		RouteManager.RouteCreatedEventArgs e = null;
		while (true)
		{
			Game game = _game;
			Game.SpeedInfo speed = game.speed;
			int num9 = NumberOfCoins(speed.min);
			if ((nint)e >= num9)
			{
				break;
			}
			if ((nint)e != _coinIndexToSkip)
			{
				character.RouteManager_OnRouteCreated((object)this, e);
				obj2 = character;
				_ = ((UnityEngine.Object)character).m_CachedPtr;
				obj3 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
				_ = 0;
				nint num10 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v85 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num11 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v111 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector2 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				reference = ref *(Color*)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				Vector3 vector3 = vector - (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				reference = ref *(Color*)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				_ = 0;
				Gizmos.DrawSphere((Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), 1.5f);
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector4 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Vector3*)(nint)vector4)->z = 0f;
				reference = ref *(Color*)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
				_ = 0;
				Vector3 vector5 = vector - (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
				Vector3 right = Vector3.right;
				reference = ref *(Color*)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
				_ = 0;
				Vector3 vector6 = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) / 5f;
				((Vector3*)(nint)vector)->x = (float)obj5;
				Vector3 vector7 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
				((Vector3*)(nint)vector7)->z = 0f;
				reference = ref *(Color*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Gizmos.DrawLine_Injected(ref *(Vector3*)vector, ref System.Runtime.CompilerServices.Unsafe.As<Color, Vector3>(ref reference));
			}
			RouteManager.RouteCreatedEventArgs e2 = (RouteManager.RouteCreatedEventArgs)(e + 1);
			e = e2;
		}
		if (_scaleMode != ScaleMode.NoScale)
		{
			Game game2 = _game;
			Game.SpeedInfo speed2 = game2.speed;
			Color black = Color.black;
			reference = ref *(Color*)vector.x;
			_ = vector.z;
			((Character)this).NotifyOnJump(speed2.min, (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0);
			Game game3 = _game;
			Game.SpeedInfo speed3 = game3.speed;
			Color black2 = Color.black;
			reference = ref *(Color*)character;
			_ = ((UnityEngine.Object)character).m_CachedPtr;
			((Character)this).NotifyOnJump(speed3.max, (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) != 0);
		}
	}
}
