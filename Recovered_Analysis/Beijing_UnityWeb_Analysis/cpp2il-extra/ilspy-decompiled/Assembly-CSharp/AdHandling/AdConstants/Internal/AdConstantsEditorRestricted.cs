using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

namespace AdHandling.AdConstants.Internal;

public class AdConstantsEditorRestricted : IAdConstants
{
	private readonly Dictionary<AdLocationInfo, string> _editorCacheIDs;

	public bool isRestricted
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_editorCacheIDs != 0;
		}
	}

	public Dictionary<AdLocationInfo, string> FlurryAdCacheIDs
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (Dictionary<AdLocationInfo, string>)1;
		}
	}

	public string AdColonyAppId => (string)(object)_editorCacheIDs;

	public Dictionary<AdLocationInfo, string> AdColonyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string TapJoyAppId => (string)(object)_editorCacheIDs;

	public string TapJoyAppKey => "";

	public Dictionary<AdLocationInfo, string> TapJoyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string ChartboostAppId => (string)(object)_editorCacheIDs;

	public string ChartboostAppSignature => "";

	public Dictionary<AdLocationInfo, string> ChartboostCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string InmobiAccountId => (string)(object)_editorCacheIDs;

	public Dictionary<AdLocationInfo, string> InmobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string VungleAppId => (string)(object)_editorCacheIDs;

	public Dictionary<AdLocationInfo, string> VungleCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string SupersonicAppId => (string)(object)_editorCacheIDs;

	public Dictionary<AdLocationInfo, string> SupersonicCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public Dictionary<AdLocationInfo, string> FacebookCacheIDs => _editorCacheIDs;

	public string MobVistaAppId => (string)(object)_editorCacheIDs;

	public string MobVistaAppSdkKey => "";

	public Dictionary<AdLocationInfo, string> MobVistaCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public Dictionary<AdLocationInfo, string> YeahMobiCacheIDs => _editorCacheIDs;

	public AdConstantsEditorRestricted()
	{
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_0107: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_0183: Expected Obj, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_021b: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_023b: Expected Obj, but got I
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0277: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02d3: Expected Obj, but got I
		//IL_02e3: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_032f: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_038b: Expected Obj, but got I
		//IL_039b: Expected Obj, but got I
		//IL_03ab: Expected Obj, but got I
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_03e7: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_0407: Expected Obj, but got I
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_0443: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I
		//IL_0463: Expected Obj, but got I
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_049f: Expected Obj, but got I
		//IL_04af: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got I
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_04fb: Expected Obj, but got I
		//IL_050b: Expected Obj, but got I
		//IL_051b: Expected Obj, but got I
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected Obj, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got Unknown
		//IL_0557: Expected Obj, but got I
		//IL_0567: Expected Obj, but got I
		//IL_0577: Expected Obj, but got I
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected Obj, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected Obj, but got Unknown
		//IL_05b3: Expected Obj, but got I
		//IL_05c3: Expected Obj, but got I
		//IL_05d3: Expected Obj, but got I
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected Obj, but got Unknown
		//IL_0607: Expected I, but got Obj
		//IL_061d: Expected Obj, but got I
		//IL_0633: Expected Obj, but got I
		//IL_0643: Expected Obj, but got I
		//IL_0653: Expected Obj, but got I
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected Obj, but got Unknown
		//IL_068f: Expected Obj, but got I
		//IL_069f: Expected Obj, but got I
		//IL_06af: Expected Obj, but got I
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected Obj, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected Obj, but got Unknown
		//IL_06eb: Expected Obj, but got I
		//IL_06fb: Expected Obj, but got I
		//IL_070b: Expected Obj, but got I
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Obj, but got Unknown
		//IL_0747: Expected Obj, but got I
		//IL_0757: Expected Obj, but got I
		//IL_0767: Expected Obj, but got I
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected Obj, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_07a3: Expected Obj, but got I
		//IL_07b3: Expected Obj, but got I
		//IL_07c3: Expected Obj, but got I
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected Obj, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected Obj, but got Unknown
		//IL_07ff: Expected Obj, but got I
		//IL_080f: Expected Obj, but got I
		//IL_081f: Expected Obj, but got I
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected Obj, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Expected Obj, but got Unknown
		//IL_085b: Expected Obj, but got I
		//IL_086b: Expected Obj, but got I
		//IL_087b: Expected Obj, but got I
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected Obj, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected Obj, but got Unknown
		//IL_08b7: Expected Obj, but got I
		//IL_08c7: Expected Obj, but got I
		//IL_08d7: Expected Obj, but got I
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected Obj, but got Unknown
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected Obj, but got Unknown
		//IL_0913: Expected Obj, but got I
		//IL_0923: Expected Obj, but got I
		//IL_0933: Expected Obj, but got I
		//IL_093c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Expected Obj, but got Unknown
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected Obj, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0964: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v9 (Il2CppClass<AdLocations>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v61 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S4_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S4_v8+48]");
		object obj9 = 0;
		object obj10 = obj9 & 0x7FF;
		object obj11 = obj10 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v64 @ S5_v6 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S4_v12+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S4_v13+48]");
		object obj14 = 0;
		object obj15 = obj14 & 0x7FF;
		object obj16 = obj15 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v85 @ S5_v10 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v17+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v18+48]");
		object obj19 = 0;
		object obj20 = obj19 & 0x7FF;
		object obj21 = obj20 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v106 @ S5_v14 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S4_v22+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S4_v23+48]");
		object obj24 = 0;
		object obj25 = obj24 & 0x7FF;
		object obj26 = obj25 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v127 @ S5_v18 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S4_v27+60]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S4_v28+48]");
		object obj29 = 0;
		object obj30 = obj29 & 0x7FF;
		object obj31 = obj30 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v148 @ S5_v22 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S4_v32+60]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S4_v33+48]");
		object obj34 = 0;
		object obj35 = obj34 & 0x7FF;
		object obj36 = obj35 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v169 @ S5_v26 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S4_v37+60]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S4_v38+48]");
		object obj39 = 0;
		object obj40 = obj39 & 0x7FF;
		object obj41 = obj40 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v190 @ S5_v30 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S4_v42+60]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S4_v43+48]");
		object obj44 = 0;
		object obj45 = obj44 & 0x7FF;
		object obj46 = obj45 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v211 @ S5_v34 (should have been resolved before IL gen)");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S4_v47+60]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S4_v48+48]");
		object obj49 = 0;
		object obj50 = obj49 & 0x7FF;
		object obj51 = obj50 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v232 @ S5_v38 (should have been resolved before IL gen)");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S4_v51 (Il2CppMethodInfo)+C]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S4_v52+60]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S4_v53+48]");
		object obj54 = 0;
		object obj55 = obj54 & 0x7FF;
		object obj56 = obj55 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v253 @ S5_v42 (should have been resolved before IL gen)");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S4_v56 (Il2CppMethodInfo)+C]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S4_v57+60]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S4_v58+48]");
		object obj59 = 0;
		object obj60 = obj59 & 0x7FF;
		object obj61 = obj60 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v274 @ S5_v46 (should have been resolved before IL gen)");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S4_v61 (Il2CppMethodInfo)+C]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S4_v62+60]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S4_v63+48]");
		object obj64 = 0;
		object obj65 = obj64 & 0x7FF;
		object obj66 = obj65 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v295 @ S5_v50 (should have been resolved before IL gen)");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S4_v66 (Il2CppMethodInfo)+C]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S4_v67+60]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S4_v68+48]");
		object obj69 = 0;
		object obj70 = obj69 & 0x7FF;
		object obj71 = obj70 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v316 @ S5_v54 (should have been resolved before IL gen)");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S4_v71 (Il2CppMethodInfo)+C]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S4_v72+60]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S4_v73+48]");
		object obj74 = 0;
		object obj75 = obj74 & 0x7FF;
		object obj76 = obj75 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v337 @ S5_v58 (should have been resolved before IL gen)");
		nint num18 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S1_v60 (Il2CppClass<AdLocations>)+5C]");
		object obj77 = -(-64);
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ S4_v76 (Il2CppMethodInfo)+C]");
		object obj78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S4_v77+60]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S4_v78+48]");
		object obj80 = 0;
		object obj81 = obj80 & 0x7FF;
		object obj82 = obj81 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v360 @ S5_v62 (should have been resolved before IL gen)");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S4_v81 (Il2CppMethodInfo)+C]");
		object obj83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S4_v82+60]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S4_v83+48]");
		object obj85 = 0;
		object obj86 = obj85 & 0x7FF;
		object obj87 = obj86 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v381 @ S5_v66 (should have been resolved before IL gen)");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S4_v86 (Il2CppMethodInfo)+C]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S4_v87+60]");
		object obj89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S4_v88+48]");
		object obj90 = 0;
		object obj91 = obj90 & 0x7FF;
		object obj92 = obj91 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v402 @ S5_v70 (should have been resolved before IL gen)");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S4_v91 (Il2CppMethodInfo)+C]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S4_v92+60]");
		object obj94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S4_v93+48]");
		object obj95 = 0;
		object obj96 = obj95 & 0x7FF;
		object obj97 = obj96 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v423 @ S5_v74 (should have been resolved before IL gen)");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S4_v96 (Il2CppMethodInfo)+C]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S4_v97+60]");
		object obj99 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ S4_v98+48]");
		object obj100 = 0;
		object obj101 = obj100 & 0x7FF;
		object obj102 = obj101 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v444 @ S5_v78 (should have been resolved before IL gen)");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S4_v101 (Il2CppMethodInfo)+C]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S4_v102+60]");
		object obj104 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S4_v103+48]");
		object obj105 = 0;
		object obj106 = obj105 & 0x7FF;
		object obj107 = obj106 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v465 @ S5_v82 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S4_v106 (Il2CppMethodInfo)+C]");
		object obj108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S4_v107+60]");
		object obj109 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S4_v108+48]");
		object obj110 = 0;
		object obj111 = obj110 & 0x7FF;
		object obj112 = obj111 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v486 @ S5_v86 (should have been resolved before IL gen)");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S4_v111 (Il2CppMethodInfo)+C]");
		object obj113 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S4_v112+60]");
		object obj114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S4_v113+48]");
		object obj115 = 0;
		object obj116 = obj115 & 0x7FF;
		object obj117 = obj116 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v507 @ S5_v90 (should have been resolved before IL gen)");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S4_v116 (Il2CppMethodInfo)+C]");
		object obj118 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S4_v117+60]");
		object obj119 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S4_v118+48]");
		object obj120 = 0;
		object obj121 = obj120 & 0x7FF;
		object obj122 = obj121 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v528 @ S5_v94 (should have been resolved before IL gen)");
		object obj123 = this + 8;
		object obj124 = default;
		obj123 = obj124;
	}
}
