using System;
using System.Collections;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Utility;
using SYBO.Common.StateSystem;
using SYBO.Components.Utilities;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using SYBO.Subway.StateSystem.States.Settings;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States;

public class HeadstartState : FlyingState
{
	private const float ChangeHeightSpeed = 50f;

	private HeadstartStateSettings _settings;

	public Action OnActivateTurboHeadstart;

	public Action OnDeactivateTurboHeadstart;

	public Action OnHidTurboHeadstartButtons;

	private GameObject[] _pickupSpawnPointPrefabInstances;

	private bool _activateTurboHeadstart;

	private bool _deactivateTurboHeadstart;

	private int _turboHeadstart;

	protected override UpgradeType UpgradeType
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0010: Expected I4, but got Obj
			object obj = this - -64;
			return (UpgradeType)obj;
		}
	}

	public int TurboHeadstart => 3;

	public HeadstartState(int id)
	{
		//IL_0014: Expected Obj, but got I4
		base._startHandlers.Add((Action)id);
	}

	public override void Enter(State fromState)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		base.Enter(fromState);
		object obj = this + 120;
		_0021_00210[] array = (_0021_00210[])(object)NGUITools.FindActive<T>();
		obj = array;
		ResetPickups();
	}

	public override void Leave(State toState)
	{
		//IL_000a: Expected I4, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		base.HandleSwipe((SwipeDir)toState);
		object obj = this - -64;
		float endGamePositionZ = (float)obj - _speedPositionAdjustment;
		((PogostickState)(object)this).SpawnPickup(endGamePositionZ);
		RevertFOV();
		if (OnActivateTurboHeadstart != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	protected unsafe override void UpdateFlying(float remainingRatio)
	{
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_04f0: Expected Obj, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_050d: Expected Obj, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_052a: Expected Obj, but got I4
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0584: Expected I, but got Obj
		//IL_059a: Expected Obj, but got I
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected Obj, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected VT, but got Unknown
		//IL_05e9: Expected F4, but got Obj
		//IL_05e4: Expected native int or pointer, but got VT
		//IL_05fe: Expected F4, but got I
		//IL_05f9: Expected native int or pointer, but got VT
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected VT, but got Unknown
		//IL_064c: Expected F4, but got Obj
		//IL_0647: Expected native int or pointer, but got VT
		//IL_0661: Expected F4, but got I
		//IL_065c: Expected native int or pointer, but got VT
		//IL_066e: Expected F4, but got Obj
		//IL_0669: Expected native int or pointer, but got VT
		//IL_0683: Expected F4, but got I
		//IL_067e: Expected native int or pointer, but got VT
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00c0: Expected F4, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00f3: Expected F4, but got Obj
		//IL_00ee: Expected native int or pointer, but got VT
		//IL_0108: Expected F4, but got I
		//IL_0103: Expected native int or pointer, but got VT
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0139: Expected F4, but got Obj
		//IL_0134: Expected native int or pointer, but got VT
		//IL_014b: Expected F4, but got Obj
		//IL_0146: Expected native int or pointer, but got VT
		//IL_0158: Expected F4, but got Obj
		//IL_0153: Expected native int or pointer, but got VT
		//IL_016d: Expected F4, but got I
		//IL_0168: Expected native int or pointer, but got VT
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_01ae: Expected F4, but got Obj
		//IL_01a9: Expected native int or pointer, but got VT
		//IL_01c3: Expected F4, but got I
		//IL_01be: Expected native int or pointer, but got VT
		//IL_01d2: Expected Obj, but got VT
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02f4: Expected F4, but got Obj
		//IL_02ef: Expected native int or pointer, but got VT
		//IL_0309: Expected F4, but got I
		//IL_0304: Expected native int or pointer, but got VT
		//IL_0316: Expected F4, but got Obj
		//IL_0311: Expected native int or pointer, but got VT
		//IL_032b: Expected F4, but got I
		//IL_0326: Expected native int or pointer, but got VT
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_037b: Expected Obj, but got F4
		//IL_0388: Expected F4, but got Obj
		//IL_0383: Expected native int or pointer, but got VT
		//IL_039d: Expected F4, but got I
		//IL_0398: Expected native int or pointer, but got VT
		//IL_03be: Expected Obj, but got F4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_0414: Expected F4, but got Obj
		//IL_040f: Expected native int or pointer, but got VT
		//IL_0429: Expected F4, but got I
		//IL_0424: Expected native int or pointer, but got VT
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_045a: Expected F4, but got Obj
		//IL_0455: Expected native int or pointer, but got VT
		//IL_046f: Expected F4, but got I
		//IL_046a: Expected native int or pointer, but got VT
		//IL_047c: Expected F4, but got Obj
		//IL_0477: Expected native int or pointer, but got VT
		//IL_0491: Expected F4, but got I
		//IL_048c: Expected native int or pointer, but got VT
		//IL_04b4: Expected F4, but got Obj
		//IL_04af: Expected native int or pointer, but got VT
		//IL_04c9: Expected F4, but got I
		//IL_04c4: Expected native int or pointer, but got VT
		//IL_04d8: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 240;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 228;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 216;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 204;
		object obj6 = _character + 236;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v15+8]");
		_ = 0;
		Game game = _game;
		float unscaledTime = Time.unscaledTime;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v102 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = obj2 + 192;
		Vector3 back = Vector3.back;
		Vector3 vector = (Vector3)(obj2 + 264);
		((Vector3*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v31+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj9 = obj2 + 180;
		float angle = game.__currentSpeed * unscaledTime;
		Quaternion quaternion = Quaternion.AngleAxis(angle, vector);
		Vector3 vector2 = (Vector3)(obj2 + 252);
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v36+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj10 = obj2 + 168;
		Vector3 vector3 = vector2 - vector;
		obj = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v43+8]");
		_ = 0;
		Character character = _character;
		object obj11 = obj2 + 156;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		RouteBuilder routeBuilder = (RouteBuilder)(obj2 + 144);
		float x = character.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v50+8]");
		routeBuilder.HideLogic(x, 0f);
		object obj12 = obj2 + 132;
		Vector3 down = Vector3.down;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		((Vector3*)(nint)vector)->x = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v55+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj13 = obj2 + 120;
		float num3 = default;
		Vector3 vector4 = vector / num3;
		((Vector3*)(nint)vector2)->x = (float)routeBuilder;
		((Vector3*)(nint)vector2)->z = (float)routeBuilder.OnCompletedLayingSections;
		((Vector3*)(nint)vector)->x = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v61+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj14 = obj2 + 108;
		Vector3 vector5 = vector2 - vector;
		obj = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v67+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		_character.UpdateGroundTag((Character)vector);
		((SmoothDampVector3)(object)base._smoothCameraX).Update();
		SmoothDampFloat smoothCameraX = base._smoothCameraX;
		object obj15 = obj2 + 96;
		object obj16 = _character + 236;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S2_v17+8]");
		_ = 0;
		float target = (float)obj15 * 0.9f;
		smoothCameraX._target = target;
		object obj17 = obj2 + 84;
		object obj18 = _character + 248;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v88+8]");
		_ = 0;
		obj3 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v77+8]");
		_ = 0;
		object obj19 = obj2 + 72;
		obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v77+8]");
		_ = 0;
		object obj20 = obj2 + 60;
		CharacterCamera characterCamera = _characterCamera;
		object obj21 = characterCamera._currentCameraData + 44;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v105+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v82+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v85+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj22 = obj2 + 48;
		Vector3 vector6 = vector2 - vector;
		obj4 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v92+8]");
		_ = 0;
		SmoothDampFloat smoothCameraX2 = base._smoothCameraX;
		obj4 = smoothCameraX2._value;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7516");
		SmoothDampFloat smoothCameraX3 = base._smoothCameraX;
		obj3 = smoothCameraX3._value;
		object obj23 = obj2 + 36;
		obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj24 = obj2 + 24;
		Vector3 down2 = Vector3.down;
		FlyingStateSettings settings = base._settings;
		((Vector3*)(nint)vector)->x = (float)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S1_v136+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj25 = obj2 + 12;
		Vector3 vector7 = vector / settings._cameraAimOffsetY;
		((Vector3*)(nint)vector2)->x = (float)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S1_v133+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S1_v143+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector8 = vector2 - vector;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		_characterCamera.SetCameraDataForcefully((CameraData)vector);
	}

	public void ActivateLongHeadstart()
	{
		if (OnStop != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private void ExtraHeadstart()
	{
		if (~(_deactivateTurboHeadstart ? 1u : 0u) != 0)
		{
			_activateTurboHeadstart = true;
			int turboHeadstart = _turboHeadstart + 1;
			_turboHeadstart = turboHeadstart;
		}
	}

	private void UpdateHeadstart(HeadstartTier tier)
	{
		//IL_005e: Expected I, but got Obj
		//IL_0074: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		RegisterStartHandler((Action)(object)tier);
		SetFOV();
		_activateTurboHeadstart = false;
		if (_turboHeadstart > -1 && _turboHeadstart < 3)
		{
			Game game = _game;
			Game game2 = _game;
			Game.SpeedInfo speed = game2.speed;
			nint num = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v26 (Il2CppClass<Info.Upgrades>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Upgrades);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v31 (Il2CppClass<Info.Upgrades>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = Upgrades.HEADSTART_TIERS + 16;
			int num3 = _turboHeadstart << 2;
			object obj3 = obj2 + num3;
			object obj4 = obj3;
			float num4 = speed.rampUpDuration;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S3_v7+C]");
			float num5 = num4 * 0f;
			float offsetGameStartTime = game._offsetGameStartTime - num5;
			game._offsetGameStartTime = offsetGameStartTime;
		}
		_deactivateTurboHeadstart = false;
		_activateTurboHeadstart = false;
		_turboHeadstart = 0;
		((InGameState)this).OnUpdate();
	}

	protected override float GetFlyHeight()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		object obj = this - -64;
		object obj2 = _character + 236;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v3+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		object obj4 = obj - 0;
		object obj5 = this - -64;
		float num = (float)obj5 - base._startGamePositionZ;
		return (float)obj4 / num;
	}

	protected override float GetFlyingSpeed()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_00bb: Expected I, but got Obj
		float num5;
		if (_turboHeadstart != 0)
		{
			float num;
			if (_turboHeadstart == 1)
			{
				HeadstartStateSettings settings = _settings;
				num = settings._turboHeadstart1FlyHeight;
			}
			else if (_turboHeadstart == 2)
			{
				HeadstartStateSettings settings2 = _settings;
				num = settings2._turboHeadstart2FlyHeight;
			}
			else
			{
				FlyingStateSettings settings3 = base._settings;
				num = settings3._flyHeight;
			}
			object obj = _character + 236;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v9+8]");
			_ = 0;
			float unscaledTime = Time.unscaledTime;
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num4 = unscaledTime * 50f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			num5 = 0f + num4;
			if (!(num5 < num))
			{
				num5 = num;
			}
		}
		else
		{
			FlyingStateSettings settings4 = base._settings;
			num5 = settings4._flyHeight;
		}
		return num5;
	}

	public void ResetTurboHeadstart()
	{
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_010d: Expected I4, but got Obj
		//IL_0078: Expected I, but got Obj
		if (_turboHeadstart != 1 && _turboHeadstart != 2)
		{
			return;
		}
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v16 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = Upgrades.HEADSTART_TIERS + 16;
		int num3 = _turboHeadstart << 2;
		object obj3 = obj2 + num3;
		((InGameState)this)._002Ector((int)obj3);
	}

	private void InitializePickups()
	{
		_deactivateTurboHeadstart = false;
		_activateTurboHeadstart = false;
		_turboHeadstart = 0;
	}

	private void PlacePickups(float gamePositionZ)
	{
		UpdateFlying(0f);
		if (gamePositionZ > 0.8f && ~(_deactivateTurboHeadstart ? 1u : 0u) != 0 && OnHidTurboHeadstartButtons != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
		if (gamePositionZ > 0.9f && ~(_deactivateTurboHeadstart ? 1u : 0u) != 0)
		{
			_deactivateTurboHeadstart = true;
			if (OnDeactivateTurboHeadstart != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
		}
		if (~(_activateTurboHeadstart ? 1u : 0u) == 0)
		{
			ResetTurboHeadstart();
			_activateTurboHeadstart = false;
		}
	}

	private float GetFlyHeightFromHeadstart()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		UpgradeType key = default;
		Upgrade upgrade = Upgrades.upgrades.get_Item(key);
		return upgrade.speed;
	}

	private void ResetPickups()
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected I4, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_000e: Expected VT, but got Obj
		//IL_0017: Expected Obj, but got VT
		object obj = default;
		bool flag = (byte)(obj + 12) != 0;
		object obj2 = this + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = default;
		obj2 = obj3;
		object obj4 = default;
		if ((nint)obj4 <= 2)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			bool flag2 = ((PickupManagerController)val).IsCharacterNameEventActive();
			throw new ArrayTypeMismatchException();
		}
	}

	private void SetActivePickupSpawnPointPrefabInstance(int i, bool isActive)
	{
		//IL_0010: Expected Obj, but got I4
		((Component)(object)OnStart).tag = (string)1;
		IEnumerator enumerator = ((Animation)(object)OnStart).GetEnumerator();
	}

	private void SetFOV()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Route route = default;
		Route route2 = default;
		while (true)
		{
			GameObject[] pickupSpawnPointPrefabInstances = _pickupSpawnPointPrefabInstances;
			if ((nint)route < pickupSpawnPointPrefabInstances.Length)
			{
				((Route)(object)this).CharacterStartEntryTransition(route2, (Route)null);
				route = (Route)(route2 + 1);
				continue;
			}
			break;
		}
	}

	private void RevertFOV()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		CharacterCamera characterCamera = _characterCamera;
		float orthographicSize = characterCamera._camera.orthographicSize;
		HeadstartStateSettings settings = _settings;
		float num = 68f + settings._megaHeadstartFOVIncrease;
		HeadstartStateSettings settings2 = _settings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		YieldInstruction[] list = default;
		Coroutine coroutine = CoroutineUtil.WaitForAll(list);
	}
}
