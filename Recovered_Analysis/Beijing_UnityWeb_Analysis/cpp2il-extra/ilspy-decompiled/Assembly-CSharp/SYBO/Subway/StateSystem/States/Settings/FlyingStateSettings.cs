using System;
using System.Collections;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Subway.StateSystem.States.Settings;

public class FlyingStateSettings : ScriptableSingleton<FlyingStateSettings>
{
	private float _characterChangeTrackLength;

	private float _flyHeight;

	private float _flyAheadDuration;

	private float _stopBeforeLandingChunkDistance;

	private float _smoothCameraXDuration;

	private float _smoothYDuration;

	private float _cameraAimOffsetY;

	private AnimationCurve _flyAheadCameraMovement;

	public float CharacterChangeTrackLength
	{
		get
		{
			//IL_001a: Expected Obj, but got I
			float characterChangeTrackLength = _characterChangeTrackLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.StateSystem.States.Settings.FlyingStateSettings)+78]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (System.Single)+48]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+C]");
			return num * 0f;
		}
	}

	public float FlyHeight => _characterChangeTrackLength;

	public float FlyAheadDuration => _flyHeight;

	public float StopBeforeLandingChunkDistance => _flyAheadDuration;

	public float SmoothCameraXDuration => _stopBeforeLandingChunkDistance;

	public float SmoothYDuration => _smoothCameraXDuration;

	public float CameraAimOffsetY => _smoothYDuration;

	public AnimationCurve FlyAheadCameraMovement
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (AnimationCurve)6;
		}
	}

	public FlyingStateSettings()
	{
		//IL_03e5: Expected I, but got Obj
		//IL_03fb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02e8: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I
		//IL_0336: Expected I, but got Obj
		//IL_034c: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_0377: Expected I, but got Obj
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I4
		//IL_0221: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v72 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_DISABLE_HOVERBOARD ? 1u : 0u) == 0)
		{
			return;
		}
		int tier = InventorySave.GetTier(UpgradeType.hoverboard);
		bool flag = tier < 1;
		float characterChangeTrackLength = _characterChangeTrackLength;
		float characterChangeTrackLength2 = _characterChangeTrackLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v3 (System.Single)+8C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v7 (System.Single)+8C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v4+14]");
		IEnumerator enumerator = ((LongMagnet)num3).PullPickupSpawnPoint((PickupSpawnPoint)0);
		object obj3 = flag | enumerator;
		if (obj3 != null)
		{
			if (tier == 0)
			{
				float characterChangeTrackLength3 = _characterChangeTrackLength;
				float characterChangeTrackLength4 = _characterChangeTrackLength;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v20 (System.Single)+8C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v48 (System.Single)+8C]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v21+14]");
				IEnumerator enumerator2 = ((LongMagnet)num4).PullPickupSpawnPoint((PickupSpawnPoint)0);
				if (enumerator2 == null)
				{
					float characterChangeTrackLength5 = _characterChangeTrackLength;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v53 (System.Single)+8C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v54+14]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55+55]");
					if ((nint)0 == 0)
					{
						nint num5 = (nint)typeof(SellableConsumable);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v59 (Il2CppClass<Info.SellableConsumable>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num6 = (nint)typeof(SellableConsumable);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v66 (Il2CppClass<Info.SellableConsumable>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						SellConsumable.completed += (Action<UpgradeType, int>)(object)SellableConsumable.hoverboard;
					}
				}
			}
		}
		else
		{
			float characterChangeTrackLength6 = _characterChangeTrackLength;
			float characterChangeTrackLength7 = _characterChangeTrackLength;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v15 (System.Single)+8C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v42 (System.Single)+8C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v16+14]");
			((CharacterModifierCollection)num7).RaiseOnEventChanged((CharacterModifierCollectionChangedEventArgs)0);
		}
		if (enumerator != null)
		{
			return;
		}
		float characterChangeTrackLength8 = _characterChangeTrackLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v23 (System.Single)+8C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v24+14]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v25+55]");
		if ((nint)0 != 0)
		{
			return;
		}
		nint num8 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v29 (Il2CppClass<Hoverboard>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num9 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v37 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v34 (CharacterModifier)+56]");
		if ((nint)0 != 0)
		{
			bool flag2 = tier > 0;
			Vector3 cameraAimOffset = ((PogostickStateSettings)flag2).CameraAimOffset;
		}
	}
}
