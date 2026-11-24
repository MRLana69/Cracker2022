using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class NGUIDebug : MonoBehaviour
{
	private static bool mRayDebug;

	private static List<string> mLines;

	private static NGUIDebug mInstance;

	public static bool debugRaycast
	{
		get
		{
			return true;
		}
		set
		{
			//IL_00b7: Expected Obj, but got I4
			//IL_00c0: Expected Obj, but got I4
			//IL_0020: Expected I, but got Obj
			//IL_0036: Expected Obj, but got I
			//IL_0061: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			EventDelegate eventDelegate = default;
			eventDelegate.target = (MonoBehaviour)value;
			UnityEngine.Object key = UnityEngine.Object.Instantiate((UnityEngine.Object)value);
			BetterList<string> value2 = ((ByteReader)(object)eventDelegate).ReadCSV();
			nint num = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v4 (Il2CppClass<Localization>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v9 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Localization.Set((string)(object)key, (string)(object)value2);
		}
	}

	public static void CreateInstance()
	{
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I
		//IL_0101: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_013d: Expected I, but got Obj
		//IL_0153: Expected Obj, but got I
		//IL_017b: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		Localization.localizationHasBeenSet = false;
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<Localization>)+5C]");
		object obj = (nint)0 + (nint)12;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S4_v4 (should have been resolved before IL gen)");
		nint num3 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v16 (Il2CppClass<Localization>)+5C]");
		object obj7 = (nint)0 + (nint)16;
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S3_v8+60]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63 @ S4_v8 (should have been resolved before IL gen)");
		nint num5 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v23 (Il2CppClass<Localization>)+5C]");
		object obj14 = (nint)0 + (nint)20;
		object obj15 = default;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S3_v12 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S3_v13+60]");
		object obj17 = 0;
		object obj18 = obj17;
		object obj19 = obj18 & 0x1FFF;
		object obj20 = obj19 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S4_v12 (should have been resolved before IL gen)");
		nint num7 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v30 (Il2CppClass<Localization>)+5C]");
		object obj21 = (nint)0 + (nint)24;
		object obj22 = default;
		obj21 = obj22;
		Localization.mLanguageIndex = -1;
		Localization.mMerging = false;
	}

	private static void LogString(string text)
	{
		//IL_0114: Expected I, but got Obj
		//IL_012a: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		nint num = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<NGUIDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (byte)(text & 1) != 0;
		mRayDebug = flag;
		if (text == null || Application.platform == RuntimePlatform.OSXEditor)
		{
			return;
		}
		nint num3 = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v17 (Il2CppClass<NGUIDebug>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22 (Il2CppClass<NGUIDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Clear();
	}

	public static void Log(object[] objs)
	{
		//IL_01bd: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01fe: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0170: Expected I, but got Obj
		//IL_00e2: Expected I, but got Obj
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			nint num = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v19 (Il2CppClass<NGUIDebug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUIDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v60 (Il2CppClass<NGUIDebug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<string> list = mLines;
			if (list._size > 20)
			{
				nint num3 = (nint)typeof(NGUIDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v47 (Il2CppClass<NGUIDebug>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(NGUIDebug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v54 (Il2CppClass<NGUIDebug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				mLines.RemoveAt(0);
			}
			nint num5 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v32 (Il2CppClass<NGUIDebug>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(NGUIDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v40 (Il2CppClass<NGUIDebug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			mLines.Add((string)(object)objs);
			Clear();
			return;
		}
		nint num7 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v14 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(objs);
	}

	public static void Log(string s)
	{
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_00f8: Expected I, but got Obj
		//IL_0085: Expected I4, but got Obj
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		object obj = s + 12;
		string text = "";
		object obj2 = default;
		IFormatProvider formatProvider = default;
		object obj7 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = s + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text2;
			if (obj2 != null)
			{
				object obj6 = ((IConvertible)text).ToType((Type)(object)", ", formatProvider);
				text2 = (string)obj6;
			}
			else
			{
				text2 = string.ConcatArray((string[])(object)text, (int)formatProvider);
			}
			obj2 = obj7 + 1;
			text = text2;
		}
		nint num = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v13 (Il2CppClass<NGUIDebug>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v18 (Il2CppClass<NGUIDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log((object[])(object)text);
	}

	public static void Clear()
	{
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00b7: Expected I4, but got Obj
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I
		//IL_023c: Expected I, but got Obj
		//IL_0252: Expected Obj, but got I
		//IL_0126: Expected I, but got Obj
		//IL_0156: Expected I, but got Obj
		//IL_018f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		nint num = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIDebug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v44 (Il2CppClass<NGUIDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(mInstance != null))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"_NGUI Debug";
		NGUIDebug nGUIDebug = gameObject.AddComponent<NGUIDebug>();
		nint num5 = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v21 (Il2CppClass<NGUIDebug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		nint num6 = (nint)typeof(NGUIDebug);
		if (!flag)
		{
			nint num7 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v38 (Il2CppClass<NGUIDebug>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num6 = (nint)typeof(NGUIDebug);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num6 = (nint)typeof(NGUIDebug);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ L0_v6 (Il2CppClass<NGUIDebug>)+5C]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = nGUIDebug;
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
	}

	public static void DrawBounds(Bounds b)
	{
		//IL_0142: Invalid comparison between VT and I4
		//IL_0047: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got VT
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_00fa: Expected I, but got Obj
		bool flag;
		if (b != (Bounds)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 10;
		string text = ((string)b).Substring(num);
		object obj2 = text + 12;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = text + 16;
			object obj5 = obj3 << 2;
			object objs = obj4 + obj5;
			nint num2 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v15 (Il2CppClass<NGUIDebug>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num3 = (nint)typeof(NGUIDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v21 (Il2CppClass<NGUIDebug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Log((object[])objs);
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
	}

	private unsafe void OnGUI()
	{
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected Obj, but got Unknown
		//IL_06cb: Expected Obj, but got I4
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_06e8: Expected Obj, but got I4
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Obj, but got Unknown
		//IL_0705: Expected Obj, but got I4
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected Obj, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Expected VT, but got Unknown
		//IL_0788: Expected F4, but got Obj
		//IL_0783: Expected native int or pointer, but got VT
		//IL_079d: Expected F4, but got I
		//IL_0798: Expected native int or pointer, but got VT
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected VT, but got Unknown
		//IL_07b8: Expected F4, but got Obj
		//IL_07b3: Expected native int or pointer, but got VT
		//IL_07cd: Expected F4, but got I
		//IL_07c8: Expected native int or pointer, but got VT
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected Obj, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected Obj, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_00a0: Expected F4, but got Obj
		//IL_009b: Expected native int or pointer, but got VT
		//IL_00b5: Expected F4, but got I
		//IL_00b0: Expected native int or pointer, but got VT
		//IL_00c2: Expected F4, but got Obj
		//IL_00bd: Expected native int or pointer, but got VT
		//IL_00d7: Expected F4, but got I
		//IL_00d2: Expected native int or pointer, but got VT
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0233: Expected Obj, but got I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected Obj, but got Unknown
		//IL_086e: Expected F4, but got Obj
		//IL_0869: Expected native int or pointer, but got VT
		//IL_0883: Expected F4, but got I
		//IL_087e: Expected native int or pointer, but got VT
		//IL_0890: Expected F4, but got Obj
		//IL_088b: Expected native int or pointer, but got VT
		//IL_08a5: Expected F4, but got I
		//IL_08a0: Expected native int or pointer, but got VT
		//IL_08b6: Expected Obj, but got VT
		//IL_08b6: Expected Obj, but got VT
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected Obj, but got Unknown
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Expected Obj, but got Unknown
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected Obj, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected Obj, but got Unknown
		//IL_0936: Expected Obj, but got I4
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Expected Obj, but got Unknown
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected Obj, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected Obj, but got Unknown
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected Obj, but got Unknown
		//IL_09de: Expected Obj, but got I4
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected Obj, but got Unknown
		//IL_0a47: Expected F4, but got Obj
		//IL_0a42: Expected native int or pointer, but got VT
		//IL_0a5c: Expected F4, but got I
		//IL_0a57: Expected native int or pointer, but got VT
		//IL_0a69: Expected F4, but got Obj
		//IL_0a64: Expected native int or pointer, but got VT
		//IL_0a7e: Expected F4, but got I
		//IL_0a79: Expected native int or pointer, but got VT
		//IL_0a8f: Expected Obj, but got VT
		//IL_0a8f: Expected Obj, but got VT
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0385: Expected Obj, but got I4
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_042d: Expected Obj, but got I4
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_0496: Expected F4, but got Obj
		//IL_0491: Expected native int or pointer, but got VT
		//IL_04ab: Expected F4, but got I
		//IL_04a6: Expected native int or pointer, but got VT
		//IL_04b8: Expected F4, but got Obj
		//IL_04b3: Expected native int or pointer, but got VT
		//IL_04cd: Expected F4, but got I
		//IL_04c8: Expected native int or pointer, but got VT
		//IL_04de: Expected Obj, but got VT
		//IL_04de: Expected Obj, but got VT
		//IL_02c6: Expected I, but got Obj
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_0563: Expected Obj, but got I4
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_060b: Expected Obj, but got I4
		//IL_0666: Expected F4, but got Obj
		//IL_0661: Expected native int or pointer, but got VT
		//IL_067b: Expected F4, but got I
		//IL_0676: Expected native int or pointer, but got VT
		//IL_0688: Expected F4, but got Obj
		//IL_0683: Expected native int or pointer, but got VT
		//IL_069d: Expected F4, but got I
		//IL_0698: Expected native int or pointer, but got VT
		//IL_06ae: Expected Obj, but got VT
		//IL_06ae: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 556;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 544;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 532;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		_ = 0;
		object obj6 = obj2 + 508;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		object obj7 = obj2 + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v266 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 580);
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj2 + 592);
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v24+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj9 = obj2 + 484;
		Quaternion quaternion = Quaternion.FromToRotation(vector, vector2);
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v37+8]");
		_ = 0;
		object obj10 = obj2 + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		object obj11 = obj2 + 460;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		((Vector3*)(nint)vector)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v41+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v43+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj12 = obj2 + 448;
		Vector3 vector3 = vector - vector2;
		obj4 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v49+8]");
		_ = 0;
		object obj13 = obj2 + 436;
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj14 = obj2 + 424;
		obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj15 = obj2 + 412;
		obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj16 = obj2 + 400;
		obj16 = 0;
		_ = 0;
		obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v58+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v63+8]");
		_ = 0;
		object obj17 = obj2 + 388;
		obj17 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj18 = obj2 + 376;
		obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj19 = obj2 + 364;
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj20 = obj2 + 352;
		obj20 = 0;
		_ = 0;
		obj20 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v79+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v84+8]");
		_ = 0;
		object obj21 = obj2 + 336;
		Color green = Color.green;
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v97 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v262 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object obj23 = (UnityEngine.Object)(obj2 + 568);
		obj23 = (UnityEngine.Object)obj16;
		UnityEngine.Object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v68+8]");
		obj24.m_CachedPtr = (IntPtr)0;
		((Vector3*)(nint)vector)->x = (float)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v89+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v95+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Debug.LogFormat(obj23, (string)vector, (object[])vector2);
		object obj25 = obj2 + 324;
		obj25 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj26 = obj2 + 312;
		obj26 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj27 = obj2 + 300;
		obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj28 = obj2 + 288;
		obj28 = 0;
		_ = 0;
		obj28 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v115+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v120+8]");
		_ = 0;
		object obj29 = obj2 + 276;
		obj29 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj30 = obj2 + 264;
		obj30 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj31 = obj2 + 252;
		obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj32 = obj2 + 240;
		obj32 = 0;
		_ = 0;
		obj32 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v136+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v141+8]");
		_ = 0;
		object obj33 = obj2 + 224;
		Color green2 = Color.green;
		obj23 = (UnityEngine.Object)obj28;
		UnityEngine.Object obj34 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v125+8]");
		obj34.m_CachedPtr = (IntPtr)0;
		((Vector3*)(nint)vector)->x = (float)obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v146+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v152+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Debug.LogFormat(obj23, (string)vector, (object[])vector2);
		object obj35 = obj2 + 212;
		obj35 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj36 = obj2 + 200;
		obj36 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj37 = obj2 + 188;
		obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj38 = obj2 + 176;
		obj38 = 0;
		_ = 0;
		obj38 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v166+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v171+8]");
		_ = 0;
		object obj39 = obj2 + 164;
		obj39 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj40 = obj2 + 152;
		obj40 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj41 = obj2 + 140;
		obj41 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj42 = obj2 + 128;
		obj42 = 0;
		_ = 0;
		obj42 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v187+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ S0_v192+8]");
		_ = 0;
		object obj43 = obj2 + 112;
		Color green3 = Color.green;
		obj23 = (UnityEngine.Object)obj38;
		UnityEngine.Object obj44 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v176+8]");
		obj44.m_CachedPtr = (IntPtr)0;
		((Vector3*)(nint)vector)->x = (float)obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v197+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S0_v203+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Debug.LogFormat(obj23, (string)vector, (object[])vector2);
		object obj45 = obj2 + 100;
		obj45 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj46 = obj2 + 88;
		obj46 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj47 = obj2 + 76;
		obj47 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj48 = obj2 - -64;
		obj48 = 0;
		_ = 0;
		obj48 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S0_v217+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S0_v222+8]");
		_ = 0;
		object obj49 = obj2 + 52;
		obj49 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj50 = obj2 + 40;
		obj50 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj51 = obj2 + 28;
		obj51 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj52 = obj2 + 16;
		obj52 = 0;
		_ = 0;
		obj52 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S0_v238+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ S0_v243+8]");
		_ = 0;
		Color green4 = Color.green;
		obj23 = (UnityEngine.Object)obj48;
		UnityEngine.Object obj53 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ S0_v227+8]");
		obj53.m_CachedPtr = (IntPtr)0;
		((Vector3*)(nint)vector)->x = (float)obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S0_v248+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Debug.LogFormat(obj23, (string)vector, (object[])vector2);
	}

	public unsafe NGUIDebug()
	{
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Expected Obj, but got Unknown
		//IL_0b57: Expected Obj, but got I4
		//IL_0b66: Expected Obj, but got F4
		//IL_0b86: Expected I, but got Obj
		//IL_0b9c: Expected Obj, but got I
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f67: Expected VT, but got Unknown
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Expected Obj, but got Unknown
		//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f83: Expected Obj, but got Unknown
		//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f91: Expected Obj, but got Unknown
		//IL_0f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9f: Expected Obj, but got Unknown
		//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fad: Expected Obj, but got Unknown
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Expected Obj, but got Unknown
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected Obj, but got Unknown
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Expected Obj, but got Unknown
		//IL_1015: Expected I, but got Obj
		//IL_102b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0946: Expected I, but got Obj
		//IL_0bca: Expected Obj, but got I4
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_099c: Expected I, but got Obj
		//IL_09b2: Expected Obj, but got I
		//IL_0bf8: Expected F4, but got Obj
		//IL_0bf3: Expected native int or pointer, but got VT
		//IL_0c0d: Expected F4, but got I
		//IL_0c08: Expected native int or pointer, but got VT
		//IL_0c23: Expected F4, but got Obj
		//IL_0c1e: Expected native int or pointer, but got VT
		//IL_0c38: Expected F4, but got I
		//IL_0c33: Expected native int or pointer, but got VT
		//IL_0c7a: Expected Obj, but got F4
		//IL_0e35: Expected F4, but got Obj
		//IL_0e30: Expected native int or pointer, but got VT
		//IL_0e4a: Expected F4, but got I
		//IL_0e45: Expected native int or pointer, but got VT
		//IL_0e76: Expected I, but got Obj
		//IL_0e8c: Expected Obj, but got I
		//IL_0184: Expected F4, but got Obj
		//IL_017f: Expected native int or pointer, but got VT
		//IL_0199: Expected F4, but got I
		//IL_0194: Expected native int or pointer, but got VT
		//IL_01af: Expected F4, but got Obj
		//IL_01aa: Expected native int or pointer, but got VT
		//IL_01c4: Expected F4, but got I
		//IL_01bf: Expected native int or pointer, but got VT
		//IL_0138: Expected I, but got Obj
		//IL_0ec8: Expected F4, but got Obj
		//IL_0ec3: Expected native int or pointer, but got VT
		//IL_0edd: Expected F4, but got I
		//IL_0ed8: Expected native int or pointer, but got VT
		//IL_0f1f: Expected Obj, but got F4
		//IL_09dd: Expected I, but got Obj
		//IL_020b: Expected Obj, but got F4
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0a76: Expected F4, but got Obj
		//IL_0a71: Expected native int or pointer, but got VT
		//IL_0a8b: Expected F4, but got I
		//IL_0a86: Expected native int or pointer, but got VT
		//IL_0a2a: Expected I, but got Obj
		//IL_0c91: Expected I4, but got Obj
		//IL_0ca8: Expected I4, but got Obj
		//IL_0ca8: Expected I4, but got Obj
		//IL_0cba: Expected I4, but got Obj
		//IL_0acd: Expected F4, but got Obj
		//IL_0ac8: Expected native int or pointer, but got VT
		//IL_0ae2: Expected F4, but got I
		//IL_0add: Expected native int or pointer, but got VT
		//IL_0b24: Expected Obj, but got F4
		//IL_02b8: Expected F4, but got Obj
		//IL_02b3: Expected native int or pointer, but got VT
		//IL_02cd: Expected F4, but got I
		//IL_02c8: Expected native int or pointer, but got VT
		//IL_0263: Expected I, but got Obj
		//IL_02e8: Expected F4, but got Obj
		//IL_02e3: Expected native int or pointer, but got VT
		//IL_02fd: Expected F4, but got I
		//IL_02f8: Expected native int or pointer, but got VT
		//IL_033f: Expected Obj, but got F4
		//IL_035a: Expected F4, but got Obj
		//IL_0355: Expected native int or pointer, but got VT
		//IL_036f: Expected F4, but got I
		//IL_036a: Expected native int or pointer, but got VT
		//IL_0385: Expected F4, but got Obj
		//IL_0380: Expected native int or pointer, but got VT
		//IL_039a: Expected F4, but got I
		//IL_0395: Expected native int or pointer, but got VT
		//IL_03e1: Expected Obj, but got F4
		//IL_040f: Expected I4, but got Obj
		//IL_040f: Expected I4, but got Obj
		//IL_0421: Expected I4, but got Obj
		//IL_0440: Expected F4, but got Obj
		//IL_043b: Expected native int or pointer, but got VT
		//IL_0455: Expected F4, but got I
		//IL_0450: Expected native int or pointer, but got VT
		//IL_0470: Expected F4, but got Obj
		//IL_046b: Expected native int or pointer, but got VT
		//IL_0485: Expected F4, but got I
		//IL_0480: Expected native int or pointer, but got VT
		//IL_04c7: Expected Obj, but got F4
		//IL_04e2: Expected F4, but got Obj
		//IL_04dd: Expected native int or pointer, but got VT
		//IL_04f7: Expected F4, but got I
		//IL_04f2: Expected native int or pointer, but got VT
		//IL_050d: Expected F4, but got Obj
		//IL_0508: Expected native int or pointer, but got VT
		//IL_0522: Expected F4, but got I
		//IL_051d: Expected native int or pointer, but got VT
		//IL_0569: Expected Obj, but got F4
		//IL_057b: Expected I4, but got Obj
		//IL_0597: Expected I4, but got Obj
		//IL_0597: Expected I4, but got Obj
		//IL_05a9: Expected I4, but got Obj
		//IL_05c8: Expected F4, but got Obj
		//IL_05c3: Expected native int or pointer, but got VT
		//IL_05dd: Expected F4, but got I
		//IL_05d8: Expected native int or pointer, but got VT
		//IL_05f8: Expected F4, but got Obj
		//IL_05f3: Expected native int or pointer, but got VT
		//IL_060d: Expected F4, but got I
		//IL_0608: Expected native int or pointer, but got VT
		//IL_064f: Expected Obj, but got F4
		//IL_066a: Expected F4, but got Obj
		//IL_0665: Expected native int or pointer, but got VT
		//IL_067f: Expected F4, but got I
		//IL_067a: Expected native int or pointer, but got VT
		//IL_0695: Expected F4, but got Obj
		//IL_0690: Expected native int or pointer, but got VT
		//IL_06aa: Expected F4, but got I
		//IL_06a5: Expected native int or pointer, but got VT
		//IL_06f1: Expected Obj, but got F4
		//IL_0707: Expected F4, but got I4
		//IL_0702: Expected native int or pointer, but got VT
		//IL_0cd1: Expected I, but got Obj
		//IL_0ce7: Expected Obj, but got I
		//IL_0769: Expected I4, but got Obj
		//IL_1056: Expected I, but got Obj
		//IL_106c: Expected Obj, but got I
		//IL_0788: Expected I, but got Obj
		//IL_07d5: Expected I4, but got Obj
		//IL_0d41: Expected I, but got Obj
		//IL_0d57: Expected Obj, but got I
		//IL_07f4: Expected I, but got Obj
		//IL_0d81: Expected F4, but got Obj
		//IL_0d7c: Expected native int or pointer, but got VT
		//IL_0d96: Expected F4, but got I
		//IL_0d91: Expected native int or pointer, but got VT
		//IL_0dac: Expected F4, but got Obj
		//IL_0da7: Expected native int or pointer, but got VT
		//IL_0dc1: Expected F4, but got I
		//IL_0dbc: Expected native int or pointer, but got VT
		//IL_0e03: Expected Obj, but got F4
		//IL_0841: Expected I4, but got Obj
		//IL_08ac: Expected F4, but got Obj
		//IL_08a7: Expected native int or pointer, but got VT
		//IL_08c1: Expected F4, but got I
		//IL_08bc: Expected native int or pointer, but got VT
		//IL_08d7: Expected F4, but got Obj
		//IL_08d2: Expected native int or pointer, but got VT
		//IL_08ec: Expected F4, but got I
		//IL_08e7: Expected native int or pointer, but got VT
		//IL_0860: Expected I, but got Obj
		//IL_0933: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 144;
		obj = 0;
		_ = 0;
		obj = 5f;
		_ = 5f;
		_ = 1000f;
		_ = 22f;
		nint num = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<NGUIDebug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v306 (Il2CppClass<NGUIDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Rect rect = (Rect)(obj2 + 160);
		object obj4 = obj2 + 128;
		object obj5 = obj2 + 112;
		object obj6 = obj2 + 96;
		object obj7 = obj2 + 80;
		object obj8 = obj2 - -64;
		object obj9 = obj2 + 48;
		object obj10 = obj2 + 32;
		object obj11 = obj2 + 16;
		if (~(mRayDebug ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v119 (Il2CppClass<UICamera>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v302 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			KeyCode currentKey = UICamera.currentKey;
			obj4 = currentKey;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = default;
			string text = "Scheme: " + text2;
			Color yellow = Color.yellow;
			nint num5 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v132 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num6 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v298 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Rect*)(nint)rect)->m_XMin = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num7 = 0f - 1f;
			float num8 = (float)obj - 1f;
			obj = num8;
			Color black = Color.black;
			((Rect*)(nint)rect)->m_XMin = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor2 = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num9 = 0f + 18f;
			float num10 = (float)obj + 1f;
			obj = num10;
			GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
			nint num11 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S1_v112 (Il2CppClass<NGUITools>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num12 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S1_v280 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Camera camera = NGUITools.FindCameraForLayer((int)controllerNavigationObject);
			string text3 = ((string)(object)camera).Remove((int)"\"", (int)"");
			string text4 = string.ConcatArray((string[])(object)"Hover: ", (int)text3);
			Color yellow2 = Color.yellow;
			((Rect*)(nint)rect)->m_XMin = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v29+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor3 = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num13 = 0f - 1f;
			float num14 = (float)obj - 1f;
			obj = num14;
			Color black2 = Color.black;
			((Rect*)(nint)rect)->m_XMin = (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v31+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor4 = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num15 = 0f + 18f;
			float num16 = (float)obj + 1f;
			obj = num16;
			int touchCount = UICamera.touchCount;
			Camera camera2 = NGUITools.FindCameraForLayer(touchCount);
			string text5 = ((string)(object)camera2).Remove((int)"\"", (int)"");
			string text6 = string.ConcatArray((string[])(object)"Selection: ", (int)text5);
			Color yellow3 = Color.yellow;
			((Rect*)(nint)rect)->m_XMin = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor5 = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num17 = 0f - 1f;
			float num18 = (float)obj - 1f;
			obj = num18;
			Color black3 = Color.black;
			((Rect*)(nint)rect)->m_XMin = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor6 = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num19 = 0f + 18f;
			float num20 = (float)obj + 1f;
			obj = num20;
			GameObject selectedObject = UICamera.selectedObject;
			Camera camera3 = NGUITools.FindCameraForLayer((int)selectedObject);
			string text7 = ((string)(object)camera3).Remove((int)"\"", (int)"");
			string text8 = string.ConcatArray((string[])(object)"Controller: ", (int)text7);
			Color yellow4 = Color.yellow;
			((Rect*)(nint)rect)->m_XMin = (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v37+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor7 = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num21 = 0f - 1f;
			float num22 = (float)obj - 1f;
			obj = num22;
			Color black4 = Color.black;
			((Rect*)(nint)rect)->m_XMin = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor8 = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num23 = 0f + 18f;
			float num24 = (float)obj + 1f;
			obj = num24;
			int dragCount = UICamera.dragCount;
			((Rect*)(nint)rect)->m_XMin = dragCount;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text10 = default;
			string text9 = "Active events: " + text10;
			UICamera first = UICamera.first;
			bool flag = (object)first == null;
			string text11 = text9;
			if (!flag)
			{
				string text12 = string.ConcatArray((string[])(object)text9, (int)", disabled controller");
				text11 = text12;
			}
			nint num25 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ S0_v239 (Il2CppClass<UICamera>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num26 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ S0_v290 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(UICamera.ignoreControllerInput ? 1u : 0u) == 0)
			{
				string text13 = string.ConcatArray((string[])(object)text11, (int)", ignore controller");
				text11 = text13;
			}
			nint num27 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S0_v248 (Il2CppClass<UICamera>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num28 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ S0_v284 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject genericEventHandler = UICamera.genericEventHandler;
			if ((object)genericEventHandler != null)
			{
				string text14 = string.ConcatArray((string[])(object)text11, (int)", input focus");
				text11 = text14;
			}
			Color yellow5 = Color.yellow;
			nint num29 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ S0_v257 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num30 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ S0_v278 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Rect*)(nint)rect)->m_XMin = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor9 = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num31 = 0f - 1f;
			float num32 = (float)obj - 1f;
			obj = num32;
			Color black5 = Color.black;
			((Rect*)(nint)rect)->m_XMin = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor10 = GUI.backgroundColor;
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num33 = 0f + 18f;
			float num34 = (float)obj + 1f;
			obj = num34;
		}
		nint num35 = (nint)typeof(NGUIDebug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v44 (Il2CppClass<NGUIDebug>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num36 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v112 (Il2CppClass<NGUIDebug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<string> list = mLines;
		int num37 = 0;
		while (num37 < list._size)
		{
			Color yellow6 = Color.yellow;
			nint num38 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v61 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num39 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v108 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Rect*)(nint)rect)->m_XMin = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor11 = GUI.backgroundColor;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			nint num40 = (nint)typeof(NGUIDebug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v71 (Il2CppClass<NGUIDebug>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num41 = (nint)typeof(NGUIDebug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v102 (Il2CppClass<NGUIDebug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text15 = mLines.get_Item(num37);
			((Rect*)(nint)rect)->m_XMin = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num42 = 0f - 1f;
			float num43 = (float)obj - 1f;
			obj = num43;
			Color black6 = Color.black;
			((Rect*)(nint)rect)->m_XMin = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v27+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Color backgroundColor12 = GUI.backgroundColor;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			string text16 = mLines.get_Item(num37);
			((Rect*)(nint)rect)->m_XMin = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v29+8]");
			((Rect*)(nint)rect)->m_Width = 0f;
			GUI.Box(rect, text16);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num44 = 0f + 18f;
			float num45 = (float)obj + 1f;
			obj = num45;
			int num46 = num37 + 1;
			num37 = num46;
		}
	}

	static NGUIDebug()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
		throw new IndexOutOfRangeException();
	}
}
