using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.BuildSizeMonitor;
using SYBO.Components.ComponentsManager;
using SYBO.Components.Json.Internal;
using SYBO.Components.Logging;

namespace SYBO.Components.Settings;

public static class StaticSettings
{
	public static BuildSizeMonitorSettings BuildSizeMonitor;

	public static ComponentsManagerSettings ComponentsManager;

	public static LogSettings Log;

	public static RuntimeSettings Runtime;

	[NonSerialized]
	public static bool active;

	static StaticSettings()
	{
		//IL_0027: Expected I, but got Obj
		//IL_003d: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I
		//IL_008f: Expected Obj, but got I
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0147: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0183: Expected Obj, but got I
		//IL_0193: Expected Obj, but got I
		//IL_01a3: Expected Obj, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I
		//IL_024b: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0297: Expected Obj, but got I
		//IL_02a7: Expected Obj, but got I
		//IL_02b7: Expected Obj, but got I
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_02f3: Expected Obj, but got I
		//IL_0303: Expected Obj, but got I
		//IL_0313: Expected Obj, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_034f: Expected Obj, but got I
		//IL_035f: Expected Obj, but got I
		//IL_036f: Expected Obj, but got I
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_03ab: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_0407: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_0427: Expected Obj, but got I
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_0463: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I
		//IL_0483: Expected Obj, but got I
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04bf: Expected Obj, but got I
		//IL_04cf: Expected Obj, but got I
		//IL_04df: Expected Obj, but got I
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_051b: Expected Obj, but got I
		//IL_052b: Expected Obj, but got I
		//IL_053b: Expected Obj, but got I
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_0577: Expected Obj, but got I
		//IL_0587: Expected Obj, but got I
		//IL_0597: Expected Obj, but got I
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		//IL_05d3: Expected Obj, but got I
		//IL_05e3: Expected Obj, but got I
		//IL_05f3: Expected Obj, but got I
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected Obj, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected Obj, but got Unknown
		//IL_062f: Expected Obj, but got I
		//IL_063f: Expected Obj, but got I
		//IL_064f: Expected Obj, but got I
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_068b: Expected Obj, but got I
		//IL_069b: Expected Obj, but got I
		//IL_06ab: Expected Obj, but got I
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected Obj, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_06e7: Expected Obj, but got I
		//IL_06f7: Expected Obj, but got I
		//IL_0707: Expected Obj, but got I
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected Obj, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected Obj, but got Unknown
		//IL_0743: Expected Obj, but got I
		//IL_0753: Expected Obj, but got I
		//IL_0763: Expected Obj, but got I
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected Obj, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_079f: Expected Obj, but got I
		//IL_07af: Expected Obj, but got I
		//IL_07bf: Expected Obj, but got I
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Expected Obj, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected Obj, but got Unknown
		//IL_07fb: Expected Obj, but got I
		//IL_080b: Expected Obj, but got I
		//IL_081b: Expected Obj, but got I
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got Unknown
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got Unknown
		//IL_0857: Expected Obj, but got I
		//IL_0867: Expected Obj, but got I
		//IL_0877: Expected Obj, but got I
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_0885: Expected Obj, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected Obj, but got Unknown
		//IL_08b3: Expected Obj, but got I
		//IL_08c3: Expected Obj, but got I
		//IL_08d3: Expected Obj, but got I
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected Obj, but got Unknown
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_090f: Expected Obj, but got I
		//IL_091f: Expected Obj, but got I
		//IL_092f: Expected Obj, but got I
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected Obj, but got Unknown
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Expected Obj, but got Unknown
		//IL_096b: Expected Obj, but got I
		//IL_097b: Expected Obj, but got I
		//IL_098b: Expected Obj, but got I
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected Obj, but got Unknown
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Expected Obj, but got Unknown
		//IL_09c7: Expected Obj, but got I
		//IL_09d7: Expected Obj, but got I
		//IL_09e7: Expected Obj, but got I
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected Obj, but got Unknown
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected Obj, but got Unknown
		//IL_0a1b: Expected I, but got Obj
		//IL_0a31: Expected Obj, but got I
		JsonParser.BuilderCapacity = 2000;
		JsonParser._lastErrorIndex = -1;
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v12 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+5C]");
		object obj = (nint)0 + (nint)8;
		obj = "";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<> hashSet = default;
		((HashSet<T>)(object)hashSet).Clear();
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v4+38]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S3_v4 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v7 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v8+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S2_v9+38]");
		object obj9 = 0;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v60 @ S3_v8 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S2_v12 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v13+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v14+38]");
		object obj14 = 0;
		object obj15 = obj14 & 0x1FFF;
		object obj16 = obj15 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v75 @ S3_v12 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v17 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v18+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v19+38]");
		object obj19 = 0;
		object obj20 = obj19 & 0x1FFF;
		object obj21 = obj20 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S3_v16 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v22 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v23+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v24+38]");
		object obj24 = 0;
		object obj25 = obj24 & 0x1FFF;
		object obj26 = obj25 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S3_v20 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S2_v27 (Il2CppMethodInfo)+C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v28+60]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S2_v29+38]");
		object obj29 = 0;
		object obj30 = obj29 & 0x1FFF;
		object obj31 = obj30 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v120 @ S3_v24 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S2_v32 (Il2CppMethodInfo)+C]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v33+60]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v34+38]");
		object obj34 = 0;
		object obj35 = obj34 & 0x1FFF;
		object obj36 = obj35 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v135 @ S3_v28 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v37 (Il2CppMethodInfo)+C]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S2_v38+60]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v39+38]");
		object obj39 = 0;
		object obj40 = obj39 & 0x1FFF;
		object obj41 = obj40 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v150 @ S3_v32 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v42 (Il2CppMethodInfo)+C]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S2_v43+60]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v44+38]");
		object obj44 = 0;
		object obj45 = obj44 & 0x1FFF;
		object obj46 = obj45 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v165 @ S3_v36 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S2_v47 (Il2CppMethodInfo)+C]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S2_v48+60]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S2_v49+38]");
		object obj49 = 0;
		object obj50 = obj49 & 0x1FFF;
		object obj51 = obj50 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v180 @ S3_v40 (should have been resolved before IL gen)");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S2_v52 (Il2CppMethodInfo)+C]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S2_v53+60]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S2_v54+38]");
		object obj54 = 0;
		object obj55 = obj54 & 0x1FFF;
		object obj56 = obj55 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195 @ S3_v44 (should have been resolved before IL gen)");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S2_v57 (Il2CppMethodInfo)+C]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S2_v58+60]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S2_v59+38]");
		object obj59 = 0;
		object obj60 = obj59 & 0x1FFF;
		object obj61 = obj60 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v210 @ S3_v48 (should have been resolved before IL gen)");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S2_v62 (Il2CppMethodInfo)+C]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S2_v63+60]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S2_v64+38]");
		object obj64 = 0;
		object obj65 = obj64 & 0x1FFF;
		object obj66 = obj65 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v225 @ S3_v52 (should have been resolved before IL gen)");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S2_v67 (Il2CppMethodInfo)+C]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S2_v68+60]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S2_v69+38]");
		object obj69 = 0;
		object obj70 = obj69 & 0x1FFF;
		object obj71 = obj70 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v240 @ S3_v56 (should have been resolved before IL gen)");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S2_v72 (Il2CppMethodInfo)+C]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S2_v73+60]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S2_v74+38]");
		object obj74 = 0;
		object obj75 = obj74 & 0x1FFF;
		object obj76 = obj75 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v255 @ S3_v60 (should have been resolved before IL gen)");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S2_v77 (Il2CppMethodInfo)+C]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S2_v78+60]");
		object obj78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S2_v79+38]");
		object obj79 = 0;
		object obj80 = obj79 & 0x1FFF;
		object obj81 = obj80 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v270 @ S3_v64 (should have been resolved before IL gen)");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S2_v82 (Il2CppMethodInfo)+C]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S2_v83+60]");
		object obj83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S2_v84+38]");
		object obj84 = 0;
		object obj85 = obj84 & 0x1FFF;
		object obj86 = obj85 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v285 @ S3_v68 (should have been resolved before IL gen)");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S2_v87 (Il2CppMethodInfo)+C]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S2_v88+60]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S2_v89+38]");
		object obj89 = 0;
		object obj90 = obj89 & 0x1FFF;
		object obj91 = obj90 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v300 @ S3_v72 (should have been resolved before IL gen)");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S2_v92 (Il2CppMethodInfo)+C]");
		object obj92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S2_v93+60]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S2_v94+38]");
		object obj94 = 0;
		object obj95 = obj94 & 0x1FFF;
		object obj96 = obj95 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v315 @ S3_v76 (should have been resolved before IL gen)");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S2_v97 (Il2CppMethodInfo)+C]");
		object obj97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S2_v98+60]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S2_v99+38]");
		object obj99 = 0;
		object obj100 = obj99 & 0x1FFF;
		object obj101 = obj100 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v330 @ S3_v80 (should have been resolved before IL gen)");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S2_v102 (Il2CppMethodInfo)+C]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ S2_v103+60]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S2_v104+38]");
		object obj104 = 0;
		object obj105 = obj104 & 0x1FFF;
		object obj106 = obj105 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v345 @ S3_v84 (should have been resolved before IL gen)");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S2_v107 (Il2CppMethodInfo)+C]");
		object obj107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S2_v108+60]");
		object obj108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S2_v109+38]");
		object obj109 = 0;
		object obj110 = obj109 & 0x1FFF;
		object obj111 = obj110 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v360 @ S3_v88 (should have been resolved before IL gen)");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S2_v112 (Il2CppMethodInfo)+C]");
		object obj112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S2_v113+60]");
		object obj113 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S2_v114+38]");
		object obj114 = 0;
		object obj115 = obj114 & 0x1FFF;
		object obj116 = obj115 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v375 @ S3_v92 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S2_v117 (Il2CppMethodInfo)+C]");
		object obj117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S2_v118+60]");
		object obj118 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S2_v119+38]");
		object obj119 = 0;
		object obj120 = obj119 & 0x1FFF;
		object obj121 = obj120 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v390 @ S3_v96 (should have been resolved before IL gen)");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S2_v122 (Il2CppMethodInfo)+C]");
		object obj122 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S2_v123+60]");
		object obj123 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S2_v124+38]");
		object obj124 = 0;
		object obj125 = obj124 & 0x1FFF;
		object obj126 = obj125 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v405 @ S3_v100 (should have been resolved before IL gen)");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S2_v127 (Il2CppMethodInfo)+C]");
		object obj127 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S2_v128+60]");
		object obj128 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S2_v129+38]");
		object obj129 = 0;
		object obj130 = obj129 & 0x1FFF;
		object obj131 = obj130 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v420 @ S3_v104 (should have been resolved before IL gen)");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S2_v132 (Il2CppMethodInfo)+C]");
		object obj132 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S2_v133+60]");
		object obj133 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S2_v134+38]");
		object obj134 = 0;
		object obj135 = obj134 & 0x1FFF;
		object obj136 = obj135 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v435 @ S3_v108 (should have been resolved before IL gen)");
		nint num29 = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v73 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+5C]");
		object obj137 = (nint)0 + (nint)24;
		obj137 = hashSet;
	}
}
