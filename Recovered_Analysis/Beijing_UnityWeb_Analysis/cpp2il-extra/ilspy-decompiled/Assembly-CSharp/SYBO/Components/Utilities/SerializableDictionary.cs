using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

[Serializable]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
	private readonly string ErrorMsgFormat;

	private List<TKey> _keys;

	private List<TValue> _values;

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v3+C]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13 @ S2_v4 (should have been resolved before IL gen)");
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_041a: Expected Obj, but got I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_043d: Expected Obj, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I
		//IL_047f: Expected Obj, but got I
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_04c5: Expected Obj, but got I
		//IL_04d5: Expected Obj, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected Obj, but got Unknown
		//IL_0513: Expected Obj, but got I
		//IL_0523: Expected Obj, but got I
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0588: Expected Obj, but got I
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got I4
		//IL_05e0: Expected Obj, but got I
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0613: Expected Obj, but got I4
		//IL_0048: Expected Obj, but got I
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected Obj, but got Unknown
		//IL_063c: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_009e: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_02a7: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_010c: Expected Obj, but got I
		//IL_0359: Expected Obj, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = 0;
		object obj5 = obj2 + 40;
		obj5 = obj;
		_ = -1;
		nint num = default;
		object obj6 = num + 12;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v15+60]");
		object obj8 = 0;
		object obj9 = obj8;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S2_v5 (should have been resolved before IL gen)");
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v19+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v20+4]");
		object obj14 = 0;
		object obj15 = obj14 & 0x3FFF;
		object obj16 = obj15 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v76 @ S2_v9 (should have been resolved before IL gen)");
		object obj17 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v11+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v12+8]");
		object obj19 = 0;
		object obj20 = obj19 & 0x3FFF;
		object obj21 = obj20 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S3_v8 (should have been resolved before IL gen)");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj24 = default;
		while (true)
		{
			object obj22 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v30+60]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj24 == null)
			{
				break;
			}
			object obj25 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v88+60]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			object obj27 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v103+60]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj29 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v112+60]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v113+14]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			object obj32 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v121+60]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj34 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ S0_v130+60]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v131+1C]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj37 = obj5 + 4;
		object obj38 = obj37 + 1;
		obj37 = obj38;
		object obj39 = obj38 << 2;
		object obj40 = obj5 + obj39;
		obj40 = 100;
		object obj41 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v35+60]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @91BB");
		object obj43 = obj2;
		object obj44 = obj2 + 88;
		object obj45 = 0;
		object obj58 = default;
		while (true)
		{
			object obj46 = obj45 & 0xFFFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v41+B2]");
			object obj47 = (nint)0 & (nint)0xFFFF;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47))
			{
				object obj48 = obj45 + 1;
				object obj49 = obj48 << 16;
				object obj50 = obj49 >> 16;
				object obj51 = obj45 & 0xFFFF;
				object obj52 = obj51 << 3;
				object obj53 = obj44 + obj52;
				if (obj53 != typeof(IDisposable))
				{
					obj45 = obj50;
					continue;
				}
				object obj54 = obj2 + 188;
				object obj55 = obj51 << 3;
				object obj56 = obj44 + obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S2_v46+4]");
				object obj57 = (nint)0 << 3;
				obj58 = obj54 + obj57;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11C74");
			break;
		}
		object obj59 = obj58 & 0x3FFF;
		object obj60 = obj59 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v364 @ S2_v28 (should have been resolved before IL gen)");
		object obj61 = obj2 + 8;
		obj3 = obj61;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S1_v47+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S1_v47+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj62 = (nint)0 << 2;
			object obj63 = obj5 + obj62;
			if ((nint)obj63 == 100)
			{
				object obj64 = obj5 + 4;
				if ((nint)obj64 > -1)
				{
					object obj65 = obj64 + -1;
					obj64 = obj65;
				}
				return;
			}
		}
		object obj66 = default;
		if (obj66 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public SerializableDictionary()
	{
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0242: Expected Obj, but got I
		//IL_025a: Expected Obj, but got I
		//IL_026a: Expected Obj, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02a8: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got I
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I
		//IL_0306: Expected Obj, but got I
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got I4
		//IL_036e: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected Obj, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00e3: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_0148: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0186: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01d4: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0103: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		nint num = default;
		object obj3 = num + 12;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v6+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v7+28]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S2_v5 (should have been resolved before IL gen)");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v10+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v11+2C]");
		object obj11 = 0;
		object obj12 = obj11 & 0x3FFF;
		object obj13 = obj12 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S2_v9 (should have been resolved before IL gen)");
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v11+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S2_v12+30]");
		object obj16 = 0;
		object obj17 = obj16 & 0x3FFF;
		object obj18 = obj17 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65 @ S3_v8 (should have been resolved before IL gen)");
		object obj19 = default;
		object obj20 = default;
		if (obj19 != obj20)
		{
			object obj21 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S3_v25+60]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S3_v26+2C]");
			object obj23 = 0;
			object obj24 = obj23 & 0x3FFF;
			object obj25 = obj24 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S4_v22 (should have been resolved before IL gen)");
			object obj26 = default;
			obj = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object obj27 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S4_v24+60]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v25+30]");
			object obj29 = 0;
			object obj30 = obj29 & 0x3FFF;
			object obj31 = obj30 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98 @ S5_v16 (should have been resolved before IL gen)");
			object obj32 = default;
			obj2 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Utilities.SerializableDictionary`2<TKey, TValue>)+30]");
			string format = default;
			object arg = default;
			string text = string.Format((IFormatProvider)0, format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		object obj33 = 0;
		object obj39 = default;
		while (true)
		{
			object obj34 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S2_v17+60]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v18+2C]");
			object obj36 = 0;
			object obj37 = obj36 & 0x3FFF;
			object obj38 = obj37 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v165 @ S3_v14 (should have been resolved before IL gen)");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj39))
			{
				object obj40 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S3_v16+60]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S3_v17+34]");
				object obj42 = 0;
				object obj43 = obj42 & 0x1FFF;
				object obj44 = obj43 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v183 @ S4_v10 (should have been resolved before IL gen)");
				object obj45 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S4_v12+60]");
				object obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S4_v13+38]");
				object obj47 = 0;
				object obj48 = obj47 & 0x1FFF;
				object obj49 = obj48 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S5_v8 (should have been resolved before IL gen)");
				object obj50 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S3_v21+60]");
				object obj51 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S3_v22+3C]");
				object obj52 = 0;
				object obj53 = obj52 & 0x1FFF;
				object obj54 = obj53 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v141 @ S4_v18 (should have been resolved before IL gen)");
				object obj55 = obj33 + 1;
				obj33 = obj55;
				continue;
			}
			break;
		}
	}
}
