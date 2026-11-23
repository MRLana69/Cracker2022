using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Cameras;
using SYBO.Subway.Coins;
using SYBO.Subway.Inputs;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Characters.States;

public class JetpackState : CharacterState
{
	public delegate void OnStartDelegate(bool isHeadStart);

	public delegate void OnStopDelegate(bool isHeadstart);

	public delegate void OnFlyAheadStartDelegate();

	public delegate void OnFlyAheadUpdateDelegate(float ratio);

	public delegate void OnActivateTurboHeadstartDelegate();

	public delegate void OnDeactivateTurboHeadstartDelegate();

	public delegate void OnHidTurboHeadstartButtonsDelegate();

	[Serializable]
	public class FlyAheadInfo
	{
		public AnimationCurve cameraMovement;
	}

	private sealed class _003CBegin_003Ed__103(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public JetpackState _003C_003E4__this;

		private Vector3 _003CstartCameraOffset_003E5__2;

		private float _003CstartCameraAimOffset_003E5__3;

		private float _003CstartY_003E5__4;

		private SmoothDampFloat _003CsmoothCameraX_003E5__5;

		private float _003CcameraZ_003E5__6;

		private Vector3 _003CcameraPositionStart_003E5__7;

		private Vector3 _003CcameraTargetStart_003E5__8;

		private bool _003ChasExploded_003E5__9;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_1c29: Expected Obj, but got I
			//IL_1c6c: Expected Obj, but got I
			//IL_1e21: Expected I, but got Obj
			//IL_1f88: Expected F4, but got I
			//IL_1f83: Expected native int or pointer, but got VT
			//IL_1fbe: Expected F4, but got I
			//IL_1fb9: Expected native int or pointer, but got VT
			//IL_0975: Expected Obj, but got I4
			//IL_14c4: Expected Obj, but got I4
			//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb8: Expected Obj, but got Unknown
			//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa0: Expected Obj, but got Unknown
			//IL_2063: Expected I, but got Obj
			//IL_20fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_20ff: Expected Obj, but got Unknown
			//IL_21ad: Expected Obj, but got F4
			//IL_21b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_21ba: Expected Obj, but got Unknown
			//IL_21d1: Expected VT, but got F4
			//IL_21f0: Expected VT, but got F4
			//IL_228e: Expected Obj, but got F4
			//IL_2296: Unknown result type (might be due to invalid IL or missing references)
			//IL_229b: Expected Obj, but got Unknown
			//IL_1924: Expected I, but got Obj
			//IL_19f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_19fd: Expected VT, but got Unknown
			//IL_1613: Expected I, but got Obj
			//IL_16e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ec: Expected VT, but got Unknown
			//IL_0e6e: Expected Obj, but got I
			//IL_0e8b: Expected Obj, but got I
			//IL_0eb4: Expected VT, but got F4
			//IL_1a1d: Expected I, but got Obj
			//IL_1ad3: Expected VT, but got F4
			//IL_151a: Expected I, but got Obj
			//IL_15ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f3: Expected VT, but got Unknown
			//IL_182b: Expected I, but got Obj
			//IL_18ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1904: Expected VT, but got Unknown
			//IL_1732: Expected I, but got Obj
			//IL_1806: Unknown result type (might be due to invalid IL or missing references)
			//IL_180b: Expected VT, but got Unknown
			object obj = default;
			Vector3 vector = (Vector3)(obj - 208);
			JetpackState jetpackState = _003C_003E4__this;
			PowerupType type;
			if (_003C_003E1__state != 0)
			{
				float ratioRemainingForFlying;
				if (_003C_003E1__state != 1)
				{
					bool result = default;
					if (_003C_003E1__state != 2)
					{
						return result;
					}
					_003C_003E1__state = -1;
					ratioRemainingForFlying = jetpackState.GetRatioRemainingForFlying();
				}
				else
				{
					_003C_003E1__state = -1;
					float ratioRemainingForFlyAhead = jetpackState.GetRatioRemainingForFlyAhead();
					float num = ratioRemainingForFlyAhead;
					if (num < 1f)
					{
						if (~(jetpackState._canActivateLongHeadstart ? 1u : 0u) != 0)
						{
							jetpackState._canActivateLongHeadstart = true;
						}
						float num2 = Math.Min(num, 1f);
						bool flag = num < 0f;
						float num3 = 0f;
						if (!flag)
						{
							num3 = num2;
						}
						float num4 = num3 * -2f;
						float num5 = num4 * num3;
						float num6 = num5 * num3;
						float num7 = num3 * 3f;
						float num8 = num7 * num3;
						float num9 = num6 + num8;
						float num10 = num9 * 1f;
						float num11 = 1f - num9;
						float num12 = num11 * 0f;
						float num13 = num10 + num12;
						float num14 = Math.Min(num13, 1f);
						bool flag2 = num13 < 0f;
						float num15 = 0f;
						if (!flag2)
						{
							num15 = num14;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Characters.States.JetpackState)+4C]");
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+18]");
						object obj2 = num16 - 0;
						float num17 = (float)obj2 * num15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+18]");
						float num18 = 0f + num17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Characters.States.JetpackState)+50]");
						nint num19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+1C]");
						object obj3 = num19 - 0;
						float num20 = (float)obj3 * num15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+1C]");
						float num21 = 0f + num20;
						float num22 = jetpackState.cameraAimOffset - _003CstartCameraAimOffset_003E5__3;
						float num23 = num3 * -2f;
						float num24 = num23 * num3;
						float num25 = num24 * num3;
						float num26 = num3 * 3f;
						float num27 = num26 * num3;
						float num28 = num25 + num27;
						float num29 = num28 * 1f;
						float num30 = 1f - num28;
						float num31 = num30 * 0f;
						float num32 = num29 + num31;
						float num33 = Math.Min(num32, 1f);
						bool flag3 = num32 < 0f;
						float num34 = 0f;
						if (!flag3)
						{
							num34 = num33;
						}
						float num35 = num22 * num34;
						float num36 = _003CstartCameraAimOffset_003E5__3 + num35;
						Character character = jetpackState._character;
						float deltaTime = Time.deltaTime;
						float num37 = jetpackState._jetpackSpeed * deltaTime;
						float z = character.z + num37;
						character.z = z;
						Character character2 = jetpackState._character;
						Vector3 position = Route.GetPosition(character2.x, character2.z);
						nint num38 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ S0_v45 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num39 = 0;
						float num40 = jetpackState.flyHeight - _003CstartY_003E5__4;
						float num41 = num3 * -2f;
						float num42 = num41 * num3;
						float num43 = num42 * num3;
						float num44 = num3 * 3f;
						float num45 = num44 * num3;
						float num46 = num43 + num45;
						float num47 = num46 * 1f;
						float num48 = 1f - num46;
						float num49 = num48 * 0f;
						float num50 = num47 + num49;
						float num51 = num40 * num50;
						float num52 = _003CstartY_003E5__4 + num51;
						float num53 = (float)Vector3.upVector * num52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ S0_v46 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
						float num54 = 0f * num52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
						float num55 = 0f + num54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ S0_v46 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
						float num56 = 0f * num52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
						float num57 = 0f + num56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B8]");
						((Vector3*)(nint)vector)->z = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
						float num58 = 0f + num53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+B0]");
						((Vector3*)(nint)vector)->x = 0f;
						jetpackState._characterTransform.position = vector;
						_003CsmoothCameraX_003E5__5.Update();
						SmoothDampFloat smoothDampFloat = _003CsmoothCameraX_003E5__5;
						Vector3 currentTransformPosition = jetpackState._character.CurrentTransformPosition;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
						float target = 0f * 0.9f;
						smoothDampFloat._target = target;
						object obj4 = ((~(jetpackState._isHeadStart ? 1u : 0u) != 0) ? ((object)(jetpackState._game + 52)) : ((object)(jetpackState + 164)));
						float deltaTime2 = Time.deltaTime;
						float num59 = (float)obj4 * deltaTime2;
						float num60 = _003CcameraZ_003E5__6 + num59;
						_003CcameraZ_003E5__6 = num60;
						Character character3 = jetpackState._character;
						float num61 = character3.z + num21;
						nint num62 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1450 @ S0_v85 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num63 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1451 @ S0_v86 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
						float num64 = 0f * num36;
						float num65 = num55 + num64;
						FlyAheadInfo flyAhead = jetpackState.flyAhead;
						float num66 = flyAhead.cameraMovement.Evaluate(num);
						float num67 = Math.Min(num66, 1f);
						bool flag4 = num66 < 0f;
						float num68 = 0f;
						if (!flag4)
						{
							num68 = num67;
						}
						object obj5 = this - -64;
						SmoothDampFloat smoothDampFloat2 = _003CsmoothCameraX_003E5__5;
						CharacterCamera characterCamera = jetpackState._characterCamera;
						float num69 = num55 + num18;
						float num70 = num69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+34]");
						float num71 = num70 - 0f;
						float num72 = num71 * num68;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+34]");
						float num73 = 0f + num72;
						float num74 = num61;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+38]");
						float num75 = num74 - 0f;
						float num76 = num75 * num68;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+38]");
						float num77 = 0f + num76;
						object obj6 = num77 << 32;
						object obj7 = num73 | obj6;
						characterCamera._position = (Vector3)smoothDampFloat2._value;
						CharacterCamera characterCamera2 = jetpackState._characterCamera;
						characterCamera2._target = (Vector3)smoothDampFloat2._value;
						float num78 = num65 - (float)obj5;
						float num79 = num78 * num68;
						float num80 = (float)obj5 + num79;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1451 @ S0_v86 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
						float num81 = 0f * num36;
						float num82 = num57 + num81;
						float num83 = num82;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+44]");
						float num84 = num83 - 0f;
						float num85 = num84 * num68;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Characters.States.JetpackState+<Begin>d__103)+44]");
						float num86 = 0f + num85;
						object obj8 = num86 << 32;
						object obj9 = num80 | obj8;
						OnFlyAheadUpdateDelegate onFlyAheadUpdate = jetpackState.OnFlyAheadUpdate;
						if (jetpackState.OnFlyAheadUpdate != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1581.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						}
						if (!_003ChasExploded_003E5__9)
						{
							Character character4 = jetpackState._character;
							if (num55 > character4.SubwayMaxY && ~(character4._isInsideSubway ? 1u : 0u) == 0)
							{
								GameObject gameObject = jetpackState._ceilingBrickExpolsion.gameObject;
								gameObject.SetActive(value: true);
								jetpackState._ceilingBrickExpolsion.Play();
								_003ChasExploded_003E5__9 = true;
								jetpackState._character.ForceLeaveSubway();
							}
						}
						jetpackState._game.UpdateMeters();
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
					Character character5 = jetpackState._character;
					character5.CharacterTrigger.enabled = true;
					float time = Time.time;
					jetpackState._startTime = time;
					ratioRemainingForFlying = jetpackState.GetRatioRemainingForFlying();
				}
				if (!(ratioRemainingForFlying < 1f))
				{
					jetpackState._activateTurboHeadstart = false;
					jetpackState._canActivateLongHeadstart = false;
					jetpackState.isActive = false;
					jetpackState._characterCamera.ResetShake();
					jetpackState._characterController.detectCollisions = true;
					Character character6 = jetpackState._character;
					float verticalSpeed = jetpackState._character.CalculateJumpVerticalSpeed(0f);
					character6.verticalSpeed = verticalSpeed;
					if (~(jetpackState._isHeadStart ? 1u : 0u) == 0)
					{
						jetpackState.RevertFOV();
						if (~(jetpackState._isHeadStart ? 1u : 0u) == 0 && jetpackState._turboHeadstart == 0)
						{
							type = PowerupType.headstart;
							goto IL_1389;
						}
					}
					object obj10 = jetpackState._turboHeadstart - 1;
					bool flag5 = jetpackState._turboHeadstart == 1;
					type = PowerupType.turboHeadstart1;
					if (!flag5)
					{
						if ((nint)obj10 != 1)
						{
							goto IL_13c2;
						}
						type = PowerupType.turboHeadstart2;
					}
					goto IL_1389;
				}
				if (ratioRemainingForFlying > 0.8f && !jetpackState._deactivateTurboHeadstart)
				{
					OnHidTurboHeadstartButtonsDelegate onHidTurboHeadstartButtons = jetpackState.m_OnHidTurboHeadstartButtons;
					if (jetpackState.m_OnHidTurboHeadstartButtons != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v299.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
				if (ratioRemainingForFlying > 0.9f && !jetpackState._deactivateTurboHeadstart)
				{
					jetpackState._deactivateTurboHeadstart = true;
					OnDeactivateTurboHeadstartDelegate onDeactivateTurboHeadstart = jetpackState.m_OnDeactivateTurboHeadstart;
					if (jetpackState.m_OnDeactivateTurboHeadstart != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v333.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
				if (~(jetpackState._isHeadStart ? 1u : 0u) == 0)
				{
					float deltaTime3 = Time.deltaTime;
					float currentHeadstartTime = jetpackState._currentHeadstartTime + deltaTime3;
					jetpackState._currentHeadstartTime = currentHeadstartTime;
				}
				if (~(jetpackState._activateTurboHeadstart ? 1u : 0u) == 0)
				{
					jetpackState.ExtraHeadstart();
					jetpackState._activateTurboHeadstart = false;
				}
				Character character7 = jetpackState._character;
				float deltaTime4 = Time.deltaTime;
				float num87 = jetpackState._jetpackSpeed * deltaTime4;
				float z2 = character7.z + num87;
				character7.z = z2;
				object obj11 = jetpackState._turboHeadstart - 1;
				if (jetpackState._turboHeadstart != 1)
				{
					if ((nint)obj11 != 1)
					{
						goto IL_0dc1;
					}
					if (jetpackState._newflyHeight < jetpackState._turboHeadstart2FlyHeight)
					{
						Vector3 currentTransformPosition2 = jetpackState._character.CurrentTransformPosition;
						float deltaTime5 = Time.deltaTime;
						float num88 = jetpackState._turboHeadstart2FlyHeight;
						float num89 = deltaTime5 * jetpackState.changeHeightSpeed;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
						float num90 = 0f + num89;
						if (!(num90 > jetpackState._turboHeadstart2FlyHeight))
						{
							num88 = num90;
						}
						bool flag6 = num90 < 0f;
						float newflyHeight = 0f;
						if (!flag6)
						{
							newflyHeight = num88;
						}
						jetpackState._newflyHeight = newflyHeight;
						Character character8 = jetpackState._character;
						Vector3 position2 = Route.GetPosition(character8.x, character8.z);
						nint num91 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ S0_v383 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num92 = 0;
						float num93 = (float)Vector3.upVector * jetpackState._newflyHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ S0_v384 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
						float num94 = 0f * jetpackState._newflyHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
						float num95 = 0f + num94;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ S0_v384 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
						float num96 = 0f * jetpackState._newflyHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
						float num97 = 0f + num96;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
						float num98 = 0f + num93;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
						_ = 0;
						Vector3 currentTransformPosition3 = vector - -64;
						character8.CurrentTransformPosition = currentTransformPosition3;
					}
					else
					{
						if (jetpackState._newflyHeight != jetpackState._turboHeadstart2FlyHeight)
						{
							goto IL_0dc1;
						}
						Character character9 = jetpackState._character;
						Vector3 position3 = Route.GetPosition(character9.x, character9.z);
						nint num99 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1087 @ S0_v347 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num100 = 0;
						float num101 = (float)Vector3.upVector * jetpackState._turboHeadstart2FlyHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ S0_v348 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
						float num102 = 0f * jetpackState._turboHeadstart2FlyHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
						float num103 = 0f + num102;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ S0_v348 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
						float num104 = 0f * jetpackState._turboHeadstart2FlyHeight;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
						float num105 = 0f + num104;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
						float num106 = 0f + num101;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
						_ = 0;
						Vector3 currentTransformPosition4 = vector + 80;
						character9.CurrentTransformPosition = currentTransformPosition4;
					}
				}
				else if (jetpackState._newflyHeight < jetpackState._turboHeadstart1FlyHeight)
				{
					Vector3 currentTransformPosition5 = jetpackState._character.CurrentTransformPosition;
					float deltaTime6 = Time.deltaTime;
					float num107 = jetpackState._turboHeadstart1FlyHeight;
					float num108 = deltaTime6 * jetpackState.changeHeightSpeed;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
					float num109 = 0f + num108;
					if (!(num109 > jetpackState._turboHeadstart1FlyHeight))
					{
						num107 = num109;
					}
					bool flag7 = num109 < 0f;
					float newflyHeight2 = 0f;
					if (!flag7)
					{
						newflyHeight2 = num107;
					}
					jetpackState._newflyHeight = newflyHeight2;
					Character character10 = jetpackState._character;
					Vector3 position4 = Route.GetPosition(character10.x, character10.z);
					nint num110 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1217 @ S0_v313 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num111 = 0;
					float num112 = (float)Vector3.upVector * jetpackState._newflyHeight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1218 @ S0_v314 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
					float num113 = 0f * jetpackState._newflyHeight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
					float num114 = 0f + num113;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1218 @ S0_v314 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
					float num115 = 0f * jetpackState._newflyHeight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
					float num116 = 0f + num115;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
					float num117 = 0f + num112;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
					_ = 0;
					Vector3 currentTransformPosition6 = vector + 32;
					character10.CurrentTransformPosition = currentTransformPosition6;
				}
				else
				{
					if (jetpackState._newflyHeight != jetpackState._turboHeadstart1FlyHeight)
					{
						goto IL_0dc1;
					}
					Character character11 = jetpackState._character;
					Vector3 position5 = Route.GetPosition(character11.x, character11.z);
					nint num118 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ S0_v277 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num119 = 0;
					float num120 = (float)Vector3.upVector * jetpackState._turboHeadstart1FlyHeight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ S0_v278 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
					float num121 = 0f * jetpackState._turboHeadstart1FlyHeight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
					float num122 = 0f + num121;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ S0_v278 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
					float num123 = 0f * jetpackState._turboHeadstart1FlyHeight;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
					float num124 = 0f + num123;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
					float num125 = 0f + num120;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
					_ = 0;
					Vector3 currentTransformPosition7 = vector + 48;
					character11.CurrentTransformPosition = currentTransformPosition7;
				}
				goto IL_0dee;
			}
			_003C_003E1__state = -1;
			jetpackState.isActive = true;
			CharacterRendering instance = CharacterRendering.Instance;
			instance.ResetTeleportFx();
			throw new NullReferenceException();
			IL_0dc1:
			Character character12 = jetpackState._character;
			Vector3 position6 = Route.GetPosition(character12.x, character12.z);
			nint num126 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ S0_v243 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num127 = 0;
			float num128 = (float)Vector3.upVector * jetpackState.flyHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ S0_v244 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
			float num129 = 0f * jetpackState.flyHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
			float num130 = 0f + num129;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ S0_v244 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
			float num131 = 0f * jetpackState.flyHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			float num132 = 0f + num131;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			float num133 = 0f + num128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 currentTransformPosition8 = vector + 16;
			character12.CurrentTransformPosition = currentTransformPosition8;
			goto IL_0dee;
			IL_0dee:
			_003CsmoothCameraX_003E5__5.Update();
			SmoothDampFloat smoothDampFloat3 = _003CsmoothCameraX_003E5__5;
			Vector3 currentTransformPosition9 = jetpackState._character.CurrentTransformPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
			float target2 = 0f * 0.9f;
			smoothDampFloat3._target = target2;
			Vector3 currentTransformPosition10 = jetpackState._character.CurrentTransformPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
			nint num134 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Characters.States.JetpackState)+4C]");
			object obj12 = num134 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			nint num135 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (SYBO.Subway.Characters.States.JetpackState)+50]");
			object obj13 = num135 + 0;
			CharacterCamera characterCamera3 = jetpackState._characterCamera;
			SmoothDampFloat smoothDampFloat4 = _003CsmoothCameraX_003E5__5;
			characterCamera3._position = (Vector3)smoothDampFloat4._value;
			object obj14 = obj13 << 32;
			object obj15 = obj12 | obj14;
			CharacterCamera characterCamera4 = jetpackState._characterCamera;
			SmoothDampFloat smoothDampFloat5 = _003CsmoothCameraX_003E5__5;
			nint num136 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1364 @ S0_v211 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num137 = 0;
			float num138 = (float)Vector3.upVector * jetpackState.cameraAimOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ S0_v212 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
			float num139 = 0f * jetpackState.cameraAimOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C4]");
			float num140 = 0f + num139;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1365 @ S0_v212 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
			float num141 = 0f * jetpackState.cameraAimOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
			float num142 = 0f + num141;
			float num143 = smoothDampFloat5._value + num138;
			characterCamera4._target = (Vector3)num143;
			jetpackState._game.UpdateMeters();
			_003C_003E2__current = null;
			_003C_003E1__state = 2;
			return true;
			IL_1389:
			Game game = jetpackState._game;
			Game.SpeedInfo speed = game.speed;
			PlayerInfo instance2 = PlayerInfo.Instance;
			float powerupLandSpeed = instance2.GetPowerupLandSpeed(type);
			float num144 = speed.rampUpDuration * powerupLandSpeed;
			float offsetGameStartTime = game._offsetGameStartTime - num144;
			game._offsetGameStartTime = offsetGameStartTime;
			goto IL_13c2;
			IL_13c2:
			jetpackState._turboHeadstart = 0;
			RunningState runningState = jetpackState._game.RunningState;
			jetpackState._game.CharacterState = runningState;
			Game game2 = jetpackState._game;
			game2._modifiers.Resume();
			OnStopDelegate onStop = jetpackState.OnStop;
			if (jetpackState.OnStop != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v779.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
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

	private sealed class _003CSpawnCoinCurve_003Ed__112(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float startZ;

		public float height;

		public AnimationCurve curve;

		public JetpackState _003C_003E4__this;

		public float length;

		private CoinManager _003CcoinManager_003E5__2;

		private float _003Cz_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_004b: Expected VT, but got Obj
			//IL_0055: Expected Obj, but got VT
			//IL_018b: Expected I, but got Obj
			//IL_0266: Expected F4, but got I
			//IL_0261: Expected native int or pointer, but got VT
			//IL_0285: Expected F4, but got I
			//IL_0280: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			JetpackState jetpackState = _003C_003E4__this;
			float num;
			float num2;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_013f;
				}
				_003C_003E1__state = -1;
				num = _003Cz_003E5__3;
				num2 = startZ;
			}
			else
			{
				_003C_003E1__state = -1;
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				_003CcoinManager_003E5__2 = (CoinManager)val;
				_003Cz_003E5__3 = startZ;
				num2 = startZ;
				num = startZ;
			}
			float num3 = num2 + length;
			if (num < num3)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v20 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num5 = 0;
				float num6 = (float)Vector3.upVector * height;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v21 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
				float num7 = 0f * height;
				float x = curve.Evaluate(_003Cz_003E5__3);
				Vector3 position = Route.GetPosition(x, _003Cz_003E5__3);
				float num8 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				float num9 = num8 + 0f;
				float num10 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				float num11 = num10 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v21 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
				float num12 = 0f * height;
				float num13 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				float num14 = num13 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				Coin item = _003CcoinManager_003E5__2.SpawnCoin(vector);
				jetpackState._dynamicSpawnedCoins.Add(item);
				CoinStats coinStats = CoinStats.New;
				int num15 = coinStats.DynamicCoinSpawns__BackingField + 1;
				coinStats.DynamicCoinSpawns__BackingField = num15;
				float num16 = _003Cz_003E5__3 + 30f;
				_003C_003E2__current = null;
				_003Cz_003E5__3 = num16;
				_003C_003E1__state = 1;
			}
			goto IL_013f;
			IL_013f:
			return true;
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

	private const float MaxJetpackFlightDurationIncreaseSeconds = 4f;

	private float megaHeadstartFOVIncrease = 10f;

	private float trasitionTime;

	public OnStartDelegate OnStart;

	public OnStopDelegate OnStop;

	public OnFlyAheadStartDelegate OnFlyAheadStart;

	public OnFlyAheadUpdateDelegate OnFlyAheadUpdate;

	public const int TURBO_HEADSTART_MAX_GEARS = 3;

	public bool isActive;

	public AudioClipInfo powerDownSound;

	public Vector3 cameraOffset = (Vector3)4756927106410086400L;

	public float smoothCameraXDuration;

	public float cameraAimOffset = 20f;

	public float ySmoothDuration;

	public float cameraFOV = 68f;

	public float speedup;

	public float flyHeight = 95f;

	public float coinOffset;

	public float flyAheadDuration = 1.5f;

	public float stopBeforeLandingChunkDistance;

	public float characterChangeTrackLength = 60f;

	private bool _isHeadStart;

	public FlyAheadInfo flyAhead;

	private PowerupType _powerupType;

	private float _powerupTimeLeftMax;

	private ActivePowerup Powerup;

	private float _startTime;

	private bool _canActivateLongHeadstart;

	private float _flyingDuration;

	private float _flyAheadDistance;

	private float _jetpackDurationExtended;

	private float _jetpackSpeed;

	private int _turboHeadstart;

	private float _currentHeadstartTime;

	private float _headStartDistance;

	private float _headStartSpeed;

	private float _headStartTopSpeed;

	private float _newDuration;

	private float _newSpeed;

	private bool _activateTurboHeadstart;

	private bool _deactivateTurboHeadstart;

	private float _newflyHeight;

	private float _turboHeadstart1FlyHeight = 105f;

	private float _turboHeadstart2FlyHeight;

	private ParticleSystem _ceilingBrickExpolsion;

	private const float _coinStayInTrackDistance = 60f;

	private const float _coinSpacingInZ = 30f;

	private GameObject[] _pickupSpawnPointPrefabInstances;

	private PickupType[] _pickupTypes;

	private float headstartLongStartPosition;

	private float changeHeightSpeed = 50f;

	private float startPosition;

	private int _targetPosZ;

	private Transform _characterTransform;

	private Transform _characterCameraTransform;

	private Animation _characterAnimation;

	private Vector3 _jetpackParticlesInitialRotation;

	private Vector3 _jetpackParticlesInitialScale;

	private static JetpackState instance;

	private List<Coin> _dynamicSpawnedCoins;

	private OnActivateTurboHeadstartDelegate m_OnActivateTurboHeadstart;

	private OnDeactivateTurboHeadstartDelegate m_OnDeactivateTurboHeadstart;

	private OnHidTurboHeadstartButtonsDelegate m_OnHidTurboHeadstartButtons;

	public bool CanActivateLongHeadstart => _canActivateLongHeadstart;

	public bool IsHeadStart
	{
		get
		{
			return _isHeadStart;
		}
		set
		{
			_isHeadStart = value;
		}
	}

	public int TurboHeadstart => _turboHeadstart;

	public override bool WillPauseActiveModifiers => true;

	public PowerupType PowerupType
	{
		get
		{
			return _powerupType;
		}
		set
		{
			_powerupType = value;
		}
	}

	public float PowerupTimeLeftMax => _powerupTimeLeftMax;

	public float JetpackDurationExtended => _jetpackDurationExtended;

	public int TargetPosZ => _targetPosZ;

	public static JetpackState Instance
	{
		get
		{
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			JetpackState result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(JetpackState));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				JetpackState jetpackState = default;
				instance = jetpackState;
				result = jetpackState;
			}
			return result;
		}
	}

	public event OnActivateTurboHeadstartDelegate OnActivateTurboHeadstart
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 280;
			Delegate obj2 = this.m_OnActivateTurboHeadstart;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 280;
			Delegate obj2 = this.m_OnActivateTurboHeadstart;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event OnDeactivateTurboHeadstartDelegate OnDeactivateTurboHeadstart
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 284;
			Delegate obj2 = this.m_OnDeactivateTurboHeadstart;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 284;
			Delegate obj2 = this.m_OnDeactivateTurboHeadstart;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event OnHidTurboHeadstartButtonsDelegate OnHidTurboHeadstartButtons
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 288;
			Delegate obj2 = this.m_OnHidTurboHeadstartButtons;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 288;
			Delegate obj2 = this.m_OnHidTurboHeadstartButtons;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	protected unsafe override void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00d1: Expected Obj, but got I4
		//IL_00df: Expected VT, but got Obj
		//IL_00e8: Expected Obj, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		base.Awake();
		Action action = default;
		action._002Ector(this, (nint)__ldftn(JetpackState.HandleOnStageMenuSequence));
		_game.OnStageMenuSequence += action;
		Transform transform = _character.transform;
		Transform transform2 = transform.Find("turboHeadstartPuff");
		ParticleSystem component = transform2.GetComponent<ParticleSystem>();
		_ceilingBrickExpolsion = component;
		Transform characterTransform = _characterController.transform;
		_characterTransform = characterTransform;
		Character character = _character;
		_characterController = character._characterController;
		Transform characterCameraTransform = _characterCamera.transform;
		_characterCameraTransform = characterCameraTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GameObject[] pickupSpawnPointPrefabInstances = default;
		_pickupSpawnPointPrefabInstances = pickupSpawnPointPrefabInstances;
		object obj2 = 0;
		if ((nint)obj2 < 3)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			GameObject gameObject = ((PickupManager)val).SpawnPickupSpawnPoint();
			throw new ArrayTypeMismatchException();
		}
	}

	public void ExtraHeadstart()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0079: Expected I4, but got Obj
		object obj = _turboHeadstart - 1;
		bool flag = _turboHeadstart == 1;
		PowerupType powerType = PowerupType.turboHeadstart1;
		if (!flag)
		{
			if ((nint)obj != 1)
			{
				return;
			}
			powerType = PowerupType.turboHeadstart2;
		}
		UpdateHeadstart(powerType, 0f, (int)this);
	}

	public override void HandleSwipe(SwipeDir swipeDir)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = swipeDir - 2;
		bool flag = swipeDir == SwipeDir.Left;
		int trackDelta = -1;
		if (!flag)
		{
			if ((nint)obj != 1)
			{
				return;
			}
			trackDelta = 1;
		}
		Game game = _game;
		float duration = characterChangeTrackLength / game.__currentSpeed;
		_character.ChangeTrackBy(trackDelta, duration);
	}

	public void ActivateLongHeadstart()
	{
		if (~(_deactivateTurboHeadstart ? 1u : 0u) != 0)
		{
			_activateTurboHeadstart = true;
			int turboHeadstart = _turboHeadstart + 1;
			_turboHeadstart = turboHeadstart;
		}
	}

	public void ResetTurboHeadstart()
	{
		_canActivateLongHeadstart = false;
		_activateTurboHeadstart = false;
		_turboHeadstart = 0;
	}

	public float GetFlightDistanceJetpack()
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		float powerupDuration = playerInfo.GetPowerupDuration(PowerupType.jetpack);
		Game game = _game;
		float num = game.__currentLevelSpeed * speedup;
		float num2 = num * powerupDuration;
		float num3 = _jetpackSpeed * powerupDuration;
		return num2 + num3;
	}

	public override IEnumerator Begin()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private float GetRatioRemainingForFlyAhead()
	{
		float time = Time.time;
		float num = time - _startTime;
		return num / flyAheadDuration;
	}

	private float GetRatioRemainingForFlying()
	{
		float time = Time.time;
		float num = time - _startTime;
		return num / _jetpackDurationExtended;
	}

	public float GetTotalRemainingHeadstartRatio()
	{
		if (~(_isHeadStart ? 1u : 0u) != 0)
		{
			return 0f;
		}
		ActivePowerup powerup = Powerup;
		float time = Time.time;
		ActivePowerup powerup2 = Powerup;
		float num = time - powerup2.timeActivated;
		float num2 = num + powerup2.timeLeft;
		return powerup.timeLeft / num2;
	}

	private void UpdatePowerupTimeLeft(float newTimeLeft)
	{
		ActivePowerup powerup = Powerup;
		powerup.timeLeft = newTimeLeft;
		_powerupTimeLeftMax = newTimeLeft;
	}

	public unsafe void PlacePickups(float z)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_024f: Expected Obj, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_028c: Expected Obj, but got I
		//IL_02c7: Expected VT, but got Obj
		//IL_02d0: Expected Obj, but got VT
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got I
		//IL_0321: Expected F4, but got I
		//IL_031c: Expected native int or pointer, but got VT
		//IL_0344: Expected Obj, but got I4
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_036c: Expected F4, but got I
		//IL_0367: Expected native int or pointer, but got VT
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		ResetPickups();
		if (~(_isHeadStart ? 1u : 0u) != 0)
		{
			return;
		}
		object obj2;
		if (_turboHeadstart != 0)
		{
			if (_turboHeadstart != 1)
			{
				if (_turboHeadstart != 2)
				{
					goto IL_03c8;
				}
				obj2 = this + 208;
			}
			else
			{
				obj2 = this + 204;
			}
		}
		else
		{
			obj2 = this + 104;
		}
		float num = (float)obj2 - 5f;
		goto IL_03c8;
		IL_03c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E._8688D249E9D047B4FC2FB89CE05AFE9EC89252FFCCDD969DE6EEF260DD7FFB21));
		object obj3 = default;
		object obj6 = default;
		while (true)
		{
			bool flag = (nint)obj3 < 3;
			bool flag2 = !flag;
			int num2 = -1;
			if (flag2)
			{
				break;
			}
			while (true)
			{
				int num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22 (System.Array)+10]");
				if ((nint)num3 != 0)
				{
					int num4 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22 (System.Array)+14]");
					if ((nint)num4 != 0)
					{
						int num5 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22 (System.Array)+18]");
						if ((nint)num5 != 0)
						{
							break;
						}
					}
				}
				PickupType[] pickupTypes = _pickupTypes;
				int num6 = UnityEngine.Random.Range(0, pickupTypes.Length);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22 (System.Array)+10]");
				bool flag3 = (nint)num6 == 0;
				num2 = num6;
				if (flag3)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22 (System.Array)+14]");
				bool flag4 = (nint)num6 == 0;
				num2 = num6;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v22 (System.Array)+18]");
					bool flag5 = (nint)num6 == 0;
					num2 = num6;
					if (!flag5)
					{
						object obj4 = obj3 << 2;
						object obj5 = (object)array + obj4;
						break;
					}
				}
			}
			obj3 = obj6 + 1;
		}
		int num7 = 0;
		while (num7 < 3)
		{
			int num8 = num7 << 2;
			object obj7 = array + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v17+10]");
			object obj8 = (nint)0 << 2;
			object obj9 = (object)_pickupTypes + obj8;
			int num9 = num7 << 2;
			object obj10 = _pickupSpawnPointPrefabInstances + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v37+10]");
			PickupSpawnPoint component = ((GameObject)0).GetComponent<PickupSpawnPoint>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v33+10]");
			component.SetSpawnPointForced((PickupType)0, SpawnPointDifficulty.Easy, willOffsetYPosition: false, willIgnoreZPositionBeforeSpawn: true, willIgnoreJetpackZ: true);
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((PickupManager)val).UpdatePickerCollectionForced();
			int num10 = num7 << 2;
			object obj11 = _pickupSpawnPointPrefabInstances + num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v45+10]");
			Transform transform = ((GameObject)0).transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			float num11 = num + 10f;
			object obj12 = num7 * 20;
			object obj13 = obj12 - 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.position = vector;
			SetActivePickupSpawnPointPrefabInstances(num7, isActive: true);
			int num12 = num7 + 1;
			num7 = num12;
		}
	}

	private void ResetPickups()
	{
		int num = 0;
		while (true)
		{
			GameObject[] pickupSpawnPointPrefabInstances = _pickupSpawnPointPrefabInstances;
			if (pickupSpawnPointPrefabInstances.Length > num)
			{
				SetActivePickupSpawnPointPrefabInstances(num, isActive: false);
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	private void SetActivePickupSpawnPointPrefabInstances(int i, bool isActive)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I
		int num = i << 2;
		object obj = _pickupSpawnPointPrefabInstances + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v3+10]");
		((GameObject)0).SetActive(isActive);
	}

	private unsafe void SpawnCoins(float startZ, float length, float height)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0219: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected VT, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected VT, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_02cb: Expected F4, but got I
		//IL_02c6: Expected native int or pointer, but got VT
		//IL_02db: Expected native int or pointer, but got VT
		//IL_02f5: Expected F4, but got I
		//IL_02f0: Expected native int or pointer, but got VT
		//IL_030a: Expected F4, but got I
		//IL_0305: Expected native int or pointer, but got VT
		//IL_01be: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		object obj = default;
		Keyframe keyframe = (Keyframe)(obj - 192);
		AnimationCurve animationCurve = default;
		animationCurve._002Ector();
		float num = startZ;
		object obj2 = 1;
		while (true)
		{
			float num2 = startZ + length;
			if (!(num < num2))
			{
				break;
			}
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj2 * 20;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+A0]");
			_ = 0;
			Keyframe key = (Keyframe)(keyframe - -64);
			int num3 = animationCurve.AddKey(key);
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 * 20;
			float num4 = num + 60f;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+80]");
			_ = 0;
			Keyframe key2 = (Keyframe)(keyframe + 32);
			int num5 = animationCurve.AddKey(key2);
			int num6 = UnityEngine.Random.Range(-1, 2);
			object obj5 = num6 + obj2;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			bool flag = (nint)obj5 < 2;
			object obj6 = obj5;
			if (!flag)
			{
				obj6 = 2;
			}
			if ((nint)obj6 <= 0)
			{
				obj6 = 0;
			}
			object obj7 = obj6 * 20;
			float num7 = num + 60f;
			float num8 = num7 + characterChangeTrackLength;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+78]");
			((Keyframe*)(nint)keyframe)->m_OutWeight = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+70]");
			((Keyframe*)(nint)keyframe)->m_WeightedMode = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+68]");
			((Keyframe*)(nint)keyframe)->m_InTangent = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Keyframe)+60]");
			((Keyframe*)(nint)keyframe)->m_Time = 0f;
			int num9 = animationCurve.AddKey(keyframe);
			float num10 = characterChangeTrackLength + 60f;
			float num11 = num + num10;
			num = num11;
			obj2 = obj6;
		}
		IEnumerator routine = SpawnCoinCurve(animationCurve, startZ, length, height);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator SpawnCoinCurve(AnimationCurve curve, float startZ, float length, float height)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void DespawnCoins()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0033: Expected Obj, but got VT
		CoinStats coinStats = CoinStats.New;
		List<Coin> dynamicSpawnedCoins = _dynamicSpawnedCoins;
		int num = coinStats.DynamicCoinDespawns__BackingField + dynamicSpawnedCoins._size;
		coinStats.DynamicCoinDespawns__BackingField = num;
		int num2 = 0;
		while (true)
		{
			List<Coin> dynamicSpawnedCoins2 = _dynamicSpawnedCoins;
			if (num2 >= dynamicSpawnedCoins2._size)
			{
				break;
			}
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Coin coin = _dynamicSpawnedCoins.get_Item(num2);
			if (((CoinManager)val).IsSpawned(coin))
			{
				Coin coin2 = _dynamicSpawnedCoins.get_Item(num2);
				coin2.Deactivate();
			}
			int num3 = num2 + 1;
			num2 = num3;
		}
		((List<T>)(object)_dynamicSpawnedCoins).Clear();
	}

	private void HandleOnStageMenuSequence()
	{
		_targetPosZ = 0;
		DespawnCoins();
		ResetPickups();
		isActive = false;
	}

	private void UpdateHeadstart(PowerupType powerType, float height, int version)
	{
		//IL_00aa: Expected F8, but got I4
		//IL_01a4: Expected I4, but got F8
		//IL_01ad: Expected VT, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_0117: Expected F4, but got I4
		PlayerInfo playerInfo = PlayerInfo.Instance;
		float powerupDuration = playerInfo.GetPowerupDuration(powerType);
		float num = powerupDuration - flyAheadDuration;
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		float headStartDistance = num * (_headStartTopSpeed = playerInfo2.GetPowerupSpeed(powerType));
		_headStartDistance = headStartDistance;
		float time = Time.time;
		_startTime = time;
		_jetpackSpeed = _headStartTopSpeed;
		Character character = _character;
		float num2 = _headStartDistance + character.z;
		double num3 = (double)num2 / 180.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
		double num4 = Math.Abs(num3);
		if (!(num4 < 2147483648.0))
		{
			num3 = -2147483648.0;
		}
		double num5 = num3 * 180.0;
		_targetPosZ = (int)num5;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v27 (T)+3C]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S1_v25+DC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		DefaultRouteBuilder defaultRouteBuilder = default;
		defaultRouteBuilder.EnqueueJetpackEndSection(_targetPosZ);
		Character character2 = _character;
		float num6 = (float)_targetPosZ - character2.z;
		float num7 = (_jetpackDurationExtended = num6 / _headStartTopSpeed);
		ActivePowerup powerup = Powerup;
		powerup.timeLeft = num7;
		_powerupTimeLeftMax = num7;
		PlacePickups(_targetPosZ);
	}

	private void SetFOV()
	{
		CharacterCamera characterCamera = _characterCamera;
		float fieldOfView = characterCamera._camera.fieldOfView;
		RunningState runningState = RunningState.Instance;
		float num = runningState.cameraFOV + megaHeadstartFOVIncrease;
		throw new ArgumentException();
	}

	private void RevertFOV()
	{
		CharacterCamera characterCamera = _characterCamera;
		float fieldOfView = characterCamera._camera.fieldOfView;
		_ = 0;
		Hoverboard hoverboard = Hoverboard.Instance;
		float num;
		if (~(hoverboard.isActive ? 1u : 0u) == 0)
		{
			Hoverboard hoverboard2 = Hoverboard.Instance;
			if (~(hoverboard2.isHighSpeedBoard ? 1u : 0u) == 0)
			{
				RunningState runningState = RunningState.Instance;
				Game game = _game;
				num = runningState.cameraFOV + game.highSpeedFOVIncrease;
				goto IL_0153;
			}
		}
		Hoverboard hoverboard3 = Hoverboard.Instance;
		if (~(hoverboard3.isActive ? 1u : 0u) == 0)
		{
			Hoverboard hoverboard4 = Hoverboard.Instance;
			if (~(hoverboard4.isSpeedBoard ? 1u : 0u) == 0)
			{
				RunningState runningState2 = RunningState.Instance;
				Game game2 = _game;
				num = runningState2.cameraFOV + game2.speedFOVIncrease;
				goto IL_0153;
			}
		}
		RunningState runningState3 = RunningState.Instance;
		num = runningState3.cameraFOV;
		goto IL_0153;
		IL_0153:
		throw new ArgumentException();
	}

	private void NotifyOnStart(bool isHeadstart)
	{
		OnStartDelegate onStart = OnStart;
		if (OnStart != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void NotifyOnStop(bool isHeadstart)
	{
		OnStopDelegate onStop = OnStop;
		if (OnStop != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public JetpackState()
	{
		//IL_0062: Expected VT, but got I8
		_ = 4417130518639017984L;
		List<Coin> list = default;
		list._002Ector();
		_dynamicSpawnedCoins = list;
		base._002Ector();
	}
}
