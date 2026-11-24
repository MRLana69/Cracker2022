using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

namespace AdHandling.AdConstants.Internal;

public class AdConstantsKindleRestricted : IAdConstants
{
	private readonly Dictionary<AdLocationInfo, string> _flurryAdCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _adColonyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _tapjoyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _chartboostCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _inmobiCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _vungleCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _supersonicCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _facebookCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _yeahMobiCacheIDs;

	public bool isRestricted
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_yeahMobiCacheIDs != 0;
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

	public string AdColonyAppId => (string)(object)_flurryAdCacheIDs;

	public Dictionary<AdLocationInfo, string> AdColonyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"app60a5688ed75a4ef595";

	public string TapJoyAppId => (string)(object)_adColonyCacheIDs;

	public string TapJoyAppKey => "";

	public Dictionary<AdLocationInfo, string> TapJoyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public string ChartboostAppId => (string)(object)_tapjoyCacheIDs;

	public string ChartboostAppSignature => "5922afa143150f6edddd6c23";

	public Dictionary<AdLocationInfo, string> ChartboostCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"bbf5160efc2c49b4fc3e7d22fb9272f5eb3768df";

	public string InmobiAccountId => (string)(object)_chartboostCacheIDs;

	public Dictionary<AdLocationInfo, string> InmobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"6c7ea8566bfd4b2c82269e3647046624";

	public string VungleAppId => (string)(object)_inmobiCacheIDs;

	public Dictionary<AdLocationInfo, string> VungleCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"5a3a17ab7f1834bc71006e8a";

	public string SupersonicAppId => (string)(object)_vungleCacheIDs;

	public Dictionary<AdLocationInfo, string> SupersonicCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public Dictionary<AdLocationInfo, string> FacebookCacheIDs => _supersonicCacheIDs;

	public Dictionary<AdLocationInfo, string> MobVistaCacheIDs => _facebookCacheIDs;

	public string MobVistaAppId
	{
		get
		{
			//IL_0025: Expected Obj, but got I
			//IL_0035: Expected Obj, but got I
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected Obj, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected Obj, but got Unknown
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
			string result = default;
			return result;
		}
	}

	public string MobVistaAppSdkKey => "";

	public Dictionary<AdLocationInfo, string> YeahMobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"";

	public AdConstantsKindleRestricted()
	{
		//IL_02c7: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_03ae: Expected Obj, but got I
		//IL_03be: Expected Obj, but got I
		//IL_03ce: Expected Obj, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected Obj, but got Unknown
		//IL_040a: Expected Obj, but got I
		//IL_041a: Expected Obj, but got I
		//IL_042a: Expected Obj, but got I
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_0466: Expected Obj, but got I
		//IL_0476: Expected Obj, but got I
		//IL_0486: Expected Obj, but got I
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04c2: Expected Obj, but got I
		//IL_04d2: Expected Obj, but got I
		//IL_04e2: Expected Obj, but got I
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_051e: Expected Obj, but got I
		//IL_052e: Expected Obj, but got I
		//IL_053e: Expected Obj, but got I
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected Obj, but got Unknown
		//IL_057a: Expected Obj, but got I
		//IL_058a: Expected Obj, but got I
		//IL_059a: Expected Obj, but got I
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got Unknown
		//IL_05d6: Expected Obj, but got I
		//IL_05e6: Expected Obj, but got I
		//IL_05f6: Expected Obj, but got I
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected Obj, but got Unknown
		//IL_0632: Expected Obj, but got I
		//IL_0642: Expected Obj, but got I
		//IL_0652: Expected Obj, but got I
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected Obj, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected Obj, but got Unknown
		//IL_068e: Expected Obj, but got I
		//IL_069e: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_0707: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected Obj, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected Obj, but got Unknown
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected Obj, but got Unknown
		//IL_0778: Expected Obj, but got I
		//IL_0788: Expected Obj, but got I
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected Obj, but got Unknown
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01df: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0119: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
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
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v7 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v8+60]");
		object obj9 = 0;
		object obj10 = obj9;
		object obj11 = obj10 & 0x1FFF;
		object obj12 = obj11 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S4_v8 (should have been resolved before IL gen)");
		object obj13 = this + 12;
		object obj14 = default;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S3_v12 (Il2CppMethodInfo)+C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S3_v13+60]");
		object obj16 = 0;
		object obj17 = obj16;
		object obj18 = obj17 & 0x1FFF;
		object obj19 = obj18 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v75 @ S4_v12 (should have been resolved before IL gen)");
		object obj20 = this + 16;
		object obj21 = default;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S3_v17 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S3_v18+60]");
		object obj23 = 0;
		object obj24 = obj23;
		object obj25 = obj24 & 0x1FFF;
		object obj26 = obj25 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98 @ S4_v16 (should have been resolved before IL gen)");
		nint num5 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v24 (Il2CppClass<AdLocations>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num6 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v73 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S4_v18 (Il2CppMethodInfo)+C]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S4_v19+60]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S4_v20+48]");
		object obj30 = 0;
		object obj31 = obj30 & 0x7FF;
		object obj32 = obj31 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v134 @ S5_v12 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S4_v23 (Il2CppMethodInfo)+C]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S4_v24+60]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S4_v25+48]");
		object obj35 = 0;
		object obj36 = obj35 & 0x7FF;
		object obj37 = obj36 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v155 @ S5_v16 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S4_v28 (Il2CppMethodInfo)+C]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S4_v29+60]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S4_v30+48]");
		object obj40 = 0;
		object obj41 = obj40 & 0x7FF;
		object obj42 = obj41 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v176 @ S5_v20 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S4_v33 (Il2CppMethodInfo)+C]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S4_v34+60]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S4_v35+48]");
		object obj45 = 0;
		object obj46 = obj45 & 0x7FF;
		object obj47 = obj46 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S5_v24 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S4_v38 (Il2CppMethodInfo)+C]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S4_v39+60]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S4_v40+48]");
		object obj50 = 0;
		object obj51 = obj50 & 0x7FF;
		object obj52 = obj51 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v218 @ S5_v28 (should have been resolved before IL gen)");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S4_v43 (Il2CppMethodInfo)+C]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S4_v44+60]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S4_v45+48]");
		object obj55 = 0;
		object obj56 = obj55 & 0x7FF;
		object obj57 = obj56 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v239 @ S5_v32 (should have been resolved before IL gen)");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S4_v48 (Il2CppMethodInfo)+C]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S4_v49+60]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S4_v50+48]");
		object obj60 = 0;
		object obj61 = obj60 & 0x7FF;
		object obj62 = obj61 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v260 @ S5_v36 (should have been resolved before IL gen)");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S4_v53 (Il2CppMethodInfo)+C]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S4_v54+60]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S4_v55+48]");
		object obj65 = 0;
		object obj66 = obj65 & 0x7FF;
		object obj67 = obj66 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v281 @ S5_v40 (should have been resolved before IL gen)");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S4_v58 (Il2CppMethodInfo)+C]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S4_v59+60]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S4_v60+48]");
		object obj70 = 0;
		object obj71 = obj70 & 0x7FF;
		object obj72 = obj71 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v302 @ S5_v44 (should have been resolved before IL gen)");
		object obj73 = this + 20;
		object obj74 = default;
		obj73 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S3_v31 (Il2CppMethodInfo)+C]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S3_v32+60]");
		object obj76 = 0;
		object obj77 = obj76;
		object obj78 = obj77 & 0x1FFF;
		object obj79 = obj78 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v326 @ S4_v65 (should have been resolved before IL gen)");
		object obj80 = this + 24;
		object obj81 = default;
		obj80 = obj81;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S3_v36 (Il2CppMethodInfo)+C]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S3_v37+60]");
		object obj83 = 0;
		object obj84 = obj83;
		object obj85 = obj84 & 0x1FFF;
		object obj86 = obj85 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v350 @ S4_v69 (should have been resolved before IL gen)");
		object obj87 = this + 28;
		object obj88 = default;
		obj87 = obj88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S3_v41 (Il2CppMethodInfo)+C]");
		object obj89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S3_v42+60]");
		object obj90 = 0;
		object obj91 = obj90;
		object obj92 = obj91 & 0x1FFF;
		object obj93 = obj92 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v373 @ S4_v73 (should have been resolved before IL gen)");
		object obj94 = this + 32;
		object obj95 = default;
		obj94 = obj95;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S3_v46 (Il2CppMethodInfo)+C]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S3_v47+60]");
		object obj97 = 0;
		object obj98 = obj97;
		object obj99 = obj98 & 0x1FFF;
		object obj100 = obj99 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v396 @ S4_v77 (should have been resolved before IL gen)");
		object obj101 = this + 36;
		object obj102 = default;
		obj101 = obj102;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S3_v51 (Il2CppMethodInfo)+C]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S3_v52+60]");
		object obj104 = 0;
		object obj105 = obj104;
		object obj106 = obj105 & 0x1FFF;
		object obj107 = obj106 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v419 @ S4_v81 (should have been resolved before IL gen)");
		object obj108 = this + 40;
		object obj109 = default;
		obj108 = obj109;
	}
}
