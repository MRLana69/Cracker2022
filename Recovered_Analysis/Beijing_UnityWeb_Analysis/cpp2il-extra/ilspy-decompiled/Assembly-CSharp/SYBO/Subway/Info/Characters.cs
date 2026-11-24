using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Level;
using SYBO.Subway.Level.Environments;
using UnityEngine;

namespace SYBO.Subway.Info;

public class Characters
{
	public enum CharacterId
	{
		slick,
		tricky,
		fresh,
		spike,
		yutani,
		frank,
		frizzy,
		king,
		lucy,
		ninja,
		tag,
		tasha,
		zoe,
		brody,
		princek,
		tony,
		seoulCharacter01,
		amsterdamCharacter01
	}

	public class Model
	{
		public string name;

		public string modelName;

		public int Price;

		public PurchaseData.UnlockType unlockType;

		public string tokenName;

		public string tokenSprite2dName;

		public MissionTarget missionTargetKey;

		public string characterLimitedDescription;

		public bool isNewInThisUpdate;

		public bool hasOnlineSettings;

		public DateTime defaultExpirationDate;

		public DateTime defaultStartDate;

		public bool overrideDynamicIapIdAndroid;

		public bool overrideDynamicIapIdiOS;

		public bool overrideDynamicIapIdKindle;

		public string dynamicIapId;

		public Model()
		{
			//IL_0010: Expected Obj, but got I4
			//IL_001b: Expected Obj, but got I4
			modelName = (string)1;
			modelName = (string)1;
		}
	}

	public const string ONLINE_SETTINGS_CHARACTER_PREFIX_EXPIRE = "character_expiretime_";

	public const string ONLINE_SETTINGS_CHARACTER_PREFIX_START = "character_starttime_";

	public static readonly Dictionary<CharacterId, Model> characterData;

	public static List<CharacterId> characterOrder;

	public unsafe static CharacterId? GetCharacterTypeForName(string name)
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0170: Expected Obj, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01f2: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected VT, but got Unknown
		//IL_03d1: Expected F4, but got Obj
		//IL_03cc: Expected native int or pointer, but got VT
		//IL_03e6: Expected F4, but got I
		//IL_03e1: Expected native int or pointer, but got VT
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected VT, but got Unknown
		//IL_0401: Expected F4, but got Obj
		//IL_03fc: Expected native int or pointer, but got VT
		//IL_0416: Expected F4, but got I
		//IL_0411: Expected native int or pointer, but got VT
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0465: Expected F4, but got Obj
		//IL_0460: Expected native int or pointer, but got VT
		//IL_047a: Expected F4, but got I
		//IL_0475: Expected native int or pointer, but got VT
		//IL_0487: Expected Obj, but got F4
		//IL_04a2: Invalid comparison between I and F4
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_025b: Expected I, but got Obj
		//IL_0271: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_034e: Expected F4, but got Obj
		//IL_0349: Expected native int or pointer, but got VT
		//IL_0363: Expected F4, but got I
		//IL_035e: Expected native int or pointer, but got VT
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_0382: Expected I4, but got VT
		//IL_0382: Expected Obj, but got I4
		//IL_038f: Expected F4, but got Obj
		//IL_038a: Expected native int or pointer, but got VT
		//IL_03a4: Expected F4, but got I
		//IL_039f: Expected native int or pointer, but got VT
		//IL_03ad: Expected Obj, but got VT
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_0159: Expected VT, but got Obj
		//IL_0115: Expected I, but got Obj
		//IL_029b: Expected F4, but got Obj
		//IL_0296: Expected native int or pointer, but got VT
		//IL_02b0: Expected F4, but got I
		//IL_02ab: Expected native int or pointer, but got VT
		//IL_02c5: Expected F4, but got I
		//IL_02d6: Expected F4, but got Obj
		//IL_02d1: Expected native int or pointer, but got VT
		//IL_02eb: Expected F4, but got I
		//IL_02e6: Expected native int or pointer, but got VT
		//IL_02f8: Expected F4, but got Obj
		//IL_02f3: Expected native int or pointer, but got VT
		//IL_030d: Expected F4, but got I
		//IL_0308: Expected native int or pointer, but got VT
		//IL_00c8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 60;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 36;
		Component component = default;
		object obj5 = component + 12;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v11+8]");
		_ = 0;
		object obj6 = obj2 + 24;
		obj6 = name;
		_ = name.m_stringLength;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v72 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 84);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 96);
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		object obj8 = obj2 + 12;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		obj = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v32+8]");
		_ = 0;
		object obj9 = component + 12;
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Vector3 vector4 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v38+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		obj3 = vector2.x;
		_ = vector2.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ L0 (UnityEngine.Component)+18]");
		if (0f > 0f)
		{
			obj4 = name;
			_ = name.m_stringLength;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v54 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v68 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj6;
			Vector3 vector5 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			Vector3 vector6 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ L0 (UnityEngine.Component)+18]");
			Vector3 vector7 = vector6 / 0f;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector2)->x = (float)obj8;
			Vector3 vector8 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v32+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			Vector3 vector9 = vector - vector2;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
		object obj11 = component + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v49+4]");
		_ = 0;
		GameObject gameObject = component.gameObject;
		nint num5 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v53 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num6 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v66 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Vector3 vector10 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		BackgroundCulling backgroundCulling = (BackgroundCulling)(obj2 + 48);
		backgroundCulling.Initialize((Material)isRestricted, (int)vector2);
		((Vector3*)(nint)vector2)->x = (float)backgroundCulling;
		Vector3 vector11 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v62 (SYBO.Subway.Level.BackgroundCulling)+8]");
		((Vector3*)(nint)vector11)->z = 0f;
		Vector3 localPosition = ((Transform)vector2).localPosition;
		return (CharacterId?)(object)backgroundCulling;
	}

	public Characters()
	{
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj = this + 8;
		obj = GamePositionRoot.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TransitionConfig.WeightedTransitionPrefab weightedTransitionPrefab = default;
		weightedTransitionPrefab._002Ector();
		object obj2 = this + 12;
		obj2 = weightedTransitionPrefab;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		TransitionConfig.WeightedTransitionPrefab weightedTransitionPrefab2 = default;
		weightedTransitionPrefab2._002Ector();
		object obj3 = this + 16;
		obj3 = weightedTransitionPrefab2;
	}
}
