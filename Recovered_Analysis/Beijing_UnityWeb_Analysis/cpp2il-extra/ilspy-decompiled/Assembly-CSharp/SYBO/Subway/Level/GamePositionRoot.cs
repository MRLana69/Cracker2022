using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Data;
using SYBO.Common.Events;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Utilities;
using UnityEngine;

namespace SYBO.Subway.Level;

public class GamePositionRoot : SingletonMonoBehaviour<GamePositionRoot>
{
	public const int ZDistanceThreshold = 50000;

	public const int ZDistanceTargetPosition = 1000;

	public const int DebugZDistanceTargetOffset = 5000;

	private int _currentGameOffsetZ;

	private Character _character;

	private HashSet<Transform> _offsetTransforms;

	private HashSet<object> _locks;

	private static GamePositionRoot _instance;

	private static bool _instantiated;

	public float CurrentGameOffsetZ
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.GamePositionRoot)+3C]");
			return 0f;
		}
	}

	public new static GamePositionRoot Instance
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			_ = 0;
			GamePositionRoot result = default;
			return result;
		}
	}

	private void Start()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private int GetZDistanceTargetPosition()
	{
		//IL_03b1: Expected I4, but got Obj
		if ((object)this != null && (nint)this != 1 && (nint)this != 2 && ((nint)this == 3 || ((nint)this != 4 && ((nint)this == 5 || (nint)this == 6 || (nint)this == 7 || ((nint)this != 8 && ((nint)this == 9 || (nint)this == 10 || (nint)this == 11 || (nint)this == 12 || (nint)this == 13 || (nint)this == 14 || (nint)this == 15 || ((nint)this != 16 && ((nint)this == 17 || (nint)this == 18 || (nint)this == 19 || (nint)this == 20 || (nint)this == 21 || (nint)this == 22 || (nint)this == 23 || (nint)this == 24 || (nint)this == 25 || (nint)this == 26 || (nint)this == 27 || (nint)this == 28 || (nint)this == 29 || (nint)this == 30 || (nint)this == 31 || (nint)this != 32))))))))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string value = "Missing switch case for " + text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GatedValue gatedValue = default;
			gatedValue.OnValueChanged += (EventHandler<ValueChangedEventArgs>)(object)value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		return (int)this;
	}

	private unsafe void LateUpdate()
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v35 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 20;
		CharacterRendering instance = CharacterRendering.Instance;
		obj2 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(GamePositionRoot.Game_OnGameEnded);
		object obj3 = action + 16;
		obj3 = this;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v31 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameEnded -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(GamePositionRoot.Game_OnGameStarted);
		object obj5 = action2 + 16;
		obj5 = this;
		Game.OnGameStarted -= action2;
	}

	public void AddOffsetTransform(Transform transform)
	{
		//IL_0042: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I
		//IL_0083: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.GamePositionRoot)+C]");
		if ((nint)0 == 0)
		{
			return;
		}
		Component component = ((GameObject)(object)transform).GetComponent((Type)(object)"Player");
		if ((object)component == null)
		{
			return;
		}
		nint num = (nint)typeof(EventArgs);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v6 (Il2CppClass<System.EventArgs>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v11 (Il2CppClass<System.EventArgs>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
	}

	public void RemoveOffsetTransform(Transform transform)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+38]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
	}

	public unsafe Vector3 GetGamePosition(Transform transform)
	{
		//IL_000a: Expected F4, but got Obj
		//IL_0005: Expected native int or pointer, but got VT
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = (float)this;
		return vector;
	}

	public unsafe Vector3 GetGamePosition(Vector3 worldPosition)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected VT, but got Unknown
		//IL_0028: Expected F4, but got Obj
		//IL_0023: Expected native int or pointer, but got VT
		//IL_003a: Expected F4, but got I
		//IL_0035: Expected native int or pointer, but got VT
		Transform transform = default;
		transform.position = worldPosition;
		Vector3 vector = (Vector3)(transform + 12);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 worldPosition2 = GetWorldPosition(vector);
		Vector3 result = default;
		return result;
	}

	public unsafe Vector3 GetWorldPosition(Vector3 gamePosition)
	{
		//IL_000d: Expected Obj, but got F4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0049: Expected F4, but got Obj
		//IL_0044: Expected native int or pointer, but got VT
		//IL_005e: Expected F4, but got I
		//IL_0059: Expected native int or pointer, but got VT
		object obj = gamePosition.x;
		_ = gamePosition.z;
		object obj2 = obj + 8;
		object obj3 = obj2 + _currentGameOffsetZ;
		obj2 = obj3;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		return vector;
	}

	public float GetWorldPositionZ(float gamePositionZ)
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
		float value = gamePositionZ - 1.5f;
		float num3 = Math.Abs(value);
		float t = num3 / 0.70000005f;
		return Mathf.LerpUnclamped(71f, 80f, t);
	}

	public void AddLock(object lockObject)
	{
		//IL_0014: Expected VT, but got Obj
		bool flag = ((HashSet<T>)(object)_offsetTransforms).Add((T)lockObject);
	}

	public void RemoveLock(object lockObject)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+38]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
	}

	private unsafe void Game_OnGameStarted()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected VT, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_041b: Expected Obj, but got I4
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0438: Expected Obj, but got I4
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected Obj, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected VT, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_0485: Expected F4, but got Obj
		//IL_0480: Expected native int or pointer, but got VT
		//IL_049a: Expected F4, but got I
		//IL_0495: Expected native int or pointer, but got VT
		//IL_0058: Expected I, but got Obj
		//IL_006e: Expected Obj, but got I
		//IL_0510: Expected I4, but got F4
		//IL_051e: Expected I, but got Obj
		//IL_0534: Expected Obj, but got I
		//IL_0567: Expected native int or pointer, but got VT
		//IL_0579: Expected native int or pointer, but got VT
		//IL_0099: Expected I, but got Obj
		//IL_0132: Expected Obj, but got F4
		//IL_00e6: Expected I, but got Obj
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_05c0: Expected F4, but got Obj
		//IL_05bb: Expected native int or pointer, but got VT
		//IL_05d5: Expected F4, but got I
		//IL_05d0: Expected native int or pointer, but got VT
		//IL_05e2: Expected F4, but got Obj
		//IL_05dd: Expected native int or pointer, but got VT
		//IL_05f7: Expected F4, but got I
		//IL_05f2: Expected native int or pointer, but got VT
		//IL_0615: Expected F4, but got Obj
		//IL_0610: Expected native int or pointer, but got VT
		//IL_062a: Expected F4, but got I
		//IL_0625: Expected native int or pointer, but got VT
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_01e0: Expected I, but got Obj
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 112;
		Vector3 vector = (Vector3)(obj2 + 76);
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 12;
		object obj5 = obj2 - -64;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 48;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 40;
		obj7 = obj;
		_ = -1;
		Vector3 vector2 = (Vector3)(obj2 + 88);
		object obj8 = _character + 248;
		((Vector3*)(nint)vector2)->x = (float)obj8;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v19+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		if (vector2.z < 50000f)
		{
			return;
		}
		HashSet<object> locks = _locks;
		if (locks._count != 0)
		{
			return;
		}
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v41 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v158 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Mathf.RoundToInt(vector2.z);
		DeviceInfo.PerformanceLevel requiredPerformanceLevel = ((BackgroundLayer)null).RequiredPerformanceLevel;
		float num4 = (float)num3 - (float)requiredPerformanceLevel;
		float num5 = num4 + (float)_currentGameOffsetZ;
		_currentGameOffsetZ = (int)num5;
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v47 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v154 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 back = Vector3.back;
		((Vector3*)(nint)vector2)->x = vector.x;
		((Vector3*)(nint)vector2)->z = vector.z;
		Vector3 vector4 = vector2 / num4;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9856");
		obj6 = vector2.x;
		_ = vector2.z;
		object obj11 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj11 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
			_ = 0;
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v127 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ S0_v147 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj4;
			Vector3 vector6 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Vector3 vector7 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj13 = obj7 + 4;
		object obj14 = obj13 + 1;
		obj13 = obj14;
		object obj15 = obj14 << 2;
		object obj16 = obj7 + obj15;
		obj16 = 145;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj7 + obj17;
			if ((nint)obj18 == 145)
			{
				object obj19 = obj7 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_06a4;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_06a4;
		IL_06a4:
		_character.EndRoll();
	}

	private unsafe void Game_OnGameEnded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected VT, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected VT, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_0446: Expected Obj, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		//IL_0463: Expected Obj, but got I4
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0052: Expected F4, but got Obj
		//IL_004d: Expected native int or pointer, but got VT
		//IL_0067: Expected F4, but got I
		//IL_0062: Expected native int or pointer, but got VT
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_04ea: Expected I4, but got F4
		//IL_04f8: Expected I, but got Obj
		//IL_050e: Expected Obj, but got I
		//IL_0541: Expected F4, but got Obj
		//IL_053c: Expected native int or pointer, but got VT
		//IL_0556: Expected F4, but got I
		//IL_0551: Expected native int or pointer, but got VT
		//IL_00b6: Expected I, but got Obj
		//IL_014f: Expected Obj, but got F4
		//IL_0103: Expected I, but got Obj
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got I4
		//IL_034d: Expected Obj, but got I
		//IL_01bc: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I
		//IL_0598: Expected F4, but got Obj
		//IL_0593: Expected native int or pointer, but got VT
		//IL_05ad: Expected F4, but got I
		//IL_05a8: Expected native int or pointer, but got VT
		//IL_05ba: Expected F4, but got Obj
		//IL_05b5: Expected native int or pointer, but got VT
		//IL_05cf: Expected F4, but got I
		//IL_05ca: Expected native int or pointer, but got VT
		//IL_05ed: Expected F4, but got Obj
		//IL_05e8: Expected native int or pointer, but got VT
		//IL_0602: Expected F4, but got I
		//IL_05fd: Expected native int or pointer, but got VT
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_01fd: Expected I, but got Obj
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 112;
		Vector3 vector = (Vector3)(obj2 + 88);
		Vector3 vector2 = (Vector3)(obj2 + 76);
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 12;
		object obj5 = obj2 - -64;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 48;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 40;
		obj7 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80D1");
		object obj8 = default;
		if (obj8 == null || !DebugSettings.UseQueuedEnvironmentKinds)
		{
			return;
		}
		object obj9 = _character + 248;
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v20+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v39 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v156 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Mathf.RoundToInt(vector2.z);
		float num4 = (float)num3 - 45000f;
		float num5 = num4 + (float)_currentGameOffsetZ;
		_currentGameOffsetZ = (int)num5;
		nint num6 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v45 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v152 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 back = Vector3.back;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Vector3 vector5 = vector / num4;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9856");
		obj6 = vector.x;
		_ = vector.z;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj12 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17+8]");
			_ = 0;
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S0_v125 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num9 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v145 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Vector3 vector6 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector7 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
			((Vector3*)(nint)vector)->x = (float)obj2;
			Vector3 vector8 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj14 = obj7 + 4;
		object obj15 = obj14 + 1;
		obj14 = obj15;
		object obj16 = obj15 << 2;
		object obj17 = obj7 + obj16;
		obj17 = 138;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj7 + obj18;
			if ((nint)obj19 == 138)
			{
				object obj20 = obj7 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_067b;
			}
		}
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_067b;
		IL_067b:
		_character.EndRoll();
	}

	private void ResetGamePosition()
	{
		this._002Ector();
	}

	public GamePositionRoot()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Obj, but got Unknown
		//IL_026a: Expected Obj, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		_currentGameOffsetZ = 0;
		object obj5 = obj2 + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9856");
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19+8]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v78 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v93 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 63)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0311;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		goto IL_0311;
		IL_0311:
		throw new IndexOutOfRangeException();
	}

	static GamePositionRoot()
	{
		//IL_04ed: Expected I, but got Obj
		//IL_0503: Expected Obj, but got I
		//IL_001f: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_00ea: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_0131: Expected I, but got Obj
		//IL_0147: Expected Obj, but got I
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_01ba: Expected I, but got Obj
		//IL_01d0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EnvironmentKind environmentKind = default;
		environmentKind._type = EnvironmentType.Empty;
		environmentKind._density = EnvironmentDensity.Default;
		EnvironmentKind.Empty = environmentKind;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		_ = 1;
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v17 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+5C]");
		object obj = (nint)0 + (nint)4;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		_ = 2;
		nint num2 = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v25 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+5C]");
		object obj3 = (nint)0 + (nint)8;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		_ = 4;
		nint num3 = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v33 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+5C]");
		object obj5 = (nint)0 + (nint)12;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 8;
		_ = 0;
		nint num4 = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v41 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+5C]");
		object obj7 = (nint)0 + (nint)16;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 2;
		_ = 0;
		nint num5 = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v49 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+5C]");
		object obj9 = (nint)0 + (nint)20;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 4;
		_ = 0;
		nint num6 = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v57 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+5C]");
		object obj11 = (nint)0 + (nint)24;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 16;
		_ = 0;
		nint num7 = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v65 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+5C]");
		object obj13 = (nint)0 + (nint)28;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 32;
		_ = 0;
		nint num8 = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v73 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+5C]");
		object obj15 = (nint)0 + (nint)32;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
