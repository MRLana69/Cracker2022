using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Cloud;
using SYBO.Subway.Characters;
using UnityEngine;
using UnityEngine.Rendering;

public class CharacterStats : MonoBehaviour
{
	private GameStats stats;

	private Character character;

	public void Start()
	{
		//IL_0011: Expected Obj, but got F4
		//IL_001c: Expected Obj, but got F4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_0060: Expected Obj, but got F4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		stats = (GameStats)0.7f;
		character = (Character)0.6f;
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Material> list = default;
		list._002Ector();
		object obj = this + 44;
		obj = list;
		object obj2 = 0;
		_ = 0;
		obj2 = 1f;
		_ = 1f;
		_ = 1f;
		_ = 1f;
		object obj3 = obj2 + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 56;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23+8]");
		_ = 0;
		CancelInvoke();
	}

	private void OnJump(float jumpHeight, bool willPlaySound)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + -8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @51AC");
	}

	private unsafe void OnRoll()
	{
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		object obj = this + 12;
		string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
		obj = privacyPolicyUrl;
		object obj2 = this + 16;
		Character component = GetComponent<Character>();
		obj2 = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Character.OnJumpDelegate onJumpDelegate = default;
		((Delegate)onJumpDelegate).method_ptr = method_ptr;
		((Delegate)onJumpDelegate).method = (nint)__ldftn(CharacterStats.OnJump);
		object obj3 = onJumpDelegate + 16;
		obj3 = this;
		character.OnJump -= onJumpDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Character.OnRollDelegate onRollDelegate = default;
		((Delegate)onRollDelegate).method_ptr = method_ptr2;
		((Delegate)onRollDelegate).method = (nint)__ldftn(CharacterStats.OnRoll);
		object obj4 = onRollDelegate + 16;
		obj4 = this;
		character.OnRoll -= onRollDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Character.OnPassedObstacleDelegate onPassedObstacleDelegate = default;
		((Delegate)onPassedObstacleDelegate).method_ptr = method_ptr3;
		((Delegate)onPassedObstacleDelegate).method = (nint)__ldftn(CharacterStats.OnPassedObstacle);
		object obj5 = onPassedObstacleDelegate + 16;
		obj5 = this;
		character.OnPassedObstacle -= onPassedObstacleDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Character.OnJumpOverTrainDelegate onJumpOverTrainDelegate = default;
		((Delegate)onJumpOverTrainDelegate).method_ptr = method_ptr4;
		((Delegate)onJumpOverTrainDelegate).method = (nint)__ldftn(CharacterStats.OnJumpOverTrain);
		object obj6 = onJumpOverTrainDelegate + 16;
		obj6 = this;
		character.OnJumpOverTrain -= onJumpOverTrainDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr5 = 0;
		Character.OnCriticalHitDelegate onCriticalHitDelegate = default;
		((Delegate)onCriticalHitDelegate).method_ptr = method_ptr5;
		((Delegate)onCriticalHitDelegate).method = (nint)__ldftn(CharacterStats.OnCriticalHit);
		object obj7 = onCriticalHitDelegate + 16;
		obj7 = this;
		character.OnCriticalHit -= onCriticalHitDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr6 = 0;
		Character.OnStumbleDelegate onStumbleDelegate = default;
		((Delegate)onStumbleDelegate).method_ptr = method_ptr6;
		((Delegate)onStumbleDelegate).method = (nint)__ldftn(CharacterStats.OnStumble);
		object obj8 = onStumbleDelegate + 16;
		obj8 = this;
		character.OnStumble -= onStumbleDelegate;
	}

	private void OnPassedObstacle(Character.ObstaclePassType type)
	{
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02c8: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0336: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_014e: Expected I, but got Obj
		//IL_01dc: Expected I, but got Obj
		object obj = this - -64;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		Transform transform = (Transform)(obj3 + 32);
		object obj4 = obj3 + 16;
		if ((UnityEngine.Object)obj != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+3C]");
			GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)0);
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S3_v3 (Il2CppMethodInfo)+18]");
			object obj7 = 0;
			object obj8 = obj7;
			object obj9 = obj8 & 0x1FFF;
			object obj10 = obj9 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S4_v5 (should have been resolved before IL gen)");
			object obj11 = default;
			obj6 = obj11;
			int layer = gameObject.layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+5C]");
			GameObject parentInternal = ((Component)0).gameObject;
			((Transform)layer).parentInternal = (Transform)(object)parentInternal;
			int layer2 = gameObject.layer;
			nint num6 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v30 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num7 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v52 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero = Vector2.zero;
			transform = (Transform)obj4;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v12+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			int layer3 = gameObject.layer;
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v40 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v48 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj3;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
		}
		object obj14 = this - -64;
		if (type != Character.ObstaclePassType.None)
		{
			((ParticleSystem)obj14).Stop();
		}
		else
		{
			((ParticleSystem)obj14).Clear();
		}
	}

	private void OnJumpOverTrain()
	{
		stats.RollsLeftTrackCountIncrement();
		Character character = this.character;
		if (character.__trackIndex == 0)
		{
			stats.RollsCenterTrackCountIncrement();
		}
		Character character2 = this.character;
		if (character2.__trackIndex == 1)
		{
			stats.RollsRightTrackCountIncrement();
		}
		Character character3 = this.character;
		if (character3.__trackIndex == 2)
		{
			stats.DodgeBarrierCountIncrement();
		}
	}

	private void OnCriticalHit(Character.CriticalHitType type)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = type - 1;
		if (type != Character.CriticalHitType.Barrier)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					stats.JumpHighBarrierCountIncrement();
					GameStats gameStats = stats;
					int jumpHighBarrierCount = gameStats._jumpHighBarrierCount + 1;
					gameStats._jumpHighBarrierCount = jumpHighBarrierCount;
				}
			}
			else
			{
				stats.JumpHighBarrierCountIncrement();
			}
		}
		else
		{
			stats.JumpBarrierCountIncrement();
		}
	}

	private unsafe void OnStumble(Character.StumbleType stumbleType, Character.StumbleHorizontalHit horizontalHit, Character.StumbleVerticalHit verticalHit, string colliderName, bool safeStumble)
	{
		//IL_0379: Expected I, but got Obj
		//IL_038f: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I4
		//IL_0199: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b9: Expected Obj, but got I
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_03be: Expected Obj, but got I
		//IL_030d: Expected Obj, but got I
		//IL_0365: Expected Obj, but got I
		//IL_0365: Expected VT, but got I
		//IL_0365: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I
		//IL_0208: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)stumbleType != null)
		{
			return;
		}
		object obj2 = this + 200;
		obj2 = stumbleType;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+C8]");
		string obj3 = ((Component)0).tag;
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj3, (byte)horizontalHit != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+C8]");
		GameObject gameObject = ((Component)0).gameObject;
		GameObject parentInternal = base.gameObject;
		((Transform)(object)gameObject).parentInternal = (Transform)(object)parentInternal;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+90]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [stumbleType @ L1 (SYBO.Subway.Characters.Character+StumbleType)+C]");
		((Mesh)num3).PrintErrorCantAccessChannel(VertexAttribute.Position);
		object obj4 = this + 236;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+F0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v16+7C]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+98]");
		((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+98]");
		((Mesh)0).PrintErrorCantAccessChannel(VertexAttribute.Position);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+98]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [stumbleType @ L1 (SYBO.Subway.Characters.Character+StumbleType)+10]");
		((Mesh)num4).PrintErrorCantAccessChannel(VertexAttribute.Position);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+98]");
		Renderer component = ((Component)0).GetComponent<Renderer>();
		component.shadowCastingMode = ShadowCastingMode.On;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+EC]");
		((AvatarAnimations)0).StartCustomAnimations((AnimationClip[])stumbleType, (byte)verticalHit != 0);
		object obj6 = this + 232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [stumbleType @ L1 (SYBO.Subway.Characters.Character+StumbleType)+1C]");
		obj6 = 0;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+E8]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+F0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+F0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+F0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+F0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+E8]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+30]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+C0]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S3_v7+E4]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v6+E0]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S5_v6+DC]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S6_v6+E8]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+98]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [stumbleType @ L1 (SYBO.Subway.Characters.Character+StumbleType)+14]");
			((SocialManager)num7).FetchRegisterUserParams(out *(string*)num8, out *(string*)num9, out *(string*)num10, out *(string*)num11, out *(string*)num12, out *(string*)num13, out *(string*)num14, out *(string*)null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+F0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v44+80]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+90]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+94]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+98]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterStats)+F0]");
		((CloudWorkingCopy.LocalItem)num15)._002Ector((string)horizontalHit, (string)verticalHit, (DateTime?)(object)num16, (byte)num17 != 0, (byte)num18 != 0, (string)0, colliderName, safeStumble ? 1 : 0, null, bytesAreSaved: false, null);
	}

	public CharacterStats()
	{
		stats.RollCountIncrement();
	}
}
