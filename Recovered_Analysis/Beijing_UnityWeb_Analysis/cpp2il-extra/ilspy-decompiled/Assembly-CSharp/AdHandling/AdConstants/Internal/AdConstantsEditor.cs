using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

namespace AdHandling.AdConstants.Internal;

public class AdConstantsEditor : IAdConstants
{
	private readonly Dictionary<AdLocationInfo, string> _editorCacheIDs;

	public bool isRestricted
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AdHandling.AdConstants.Internal.AdConstantsEditor)+2C]");
			return false;
		}
	}

	public Dictionary<AdLocationInfo, string> FlurryAdCacheIDs => null;

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

	public AdConstantsEditor()
	{
		//IL_21d9: Expected Obj, but got I
		//IL_21e9: Expected Obj, but got I
		//IL_21fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ff: Expected Obj, but got Unknown
		//IL_2208: Unknown result type (might be due to invalid IL or missing references)
		//IL_220d: Expected Obj, but got Unknown
		//IL_221d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2222: Expected Obj, but got Unknown
		//IL_224a: Expected Obj, but got I
		//IL_225a: Expected Obj, but got I
		//IL_226b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2270: Expected Obj, but got Unknown
		//IL_2279: Unknown result type (might be due to invalid IL or missing references)
		//IL_227e: Expected Obj, but got Unknown
		//IL_2296: Expected I, but got Obj
		//IL_22ac: Expected Obj, but got I
		//IL_22df: Expected Obj, but got I
		//IL_22ef: Expected Obj, but got I
		//IL_22ff: Expected Obj, but got I
		//IL_2308: Unknown result type (might be due to invalid IL or missing references)
		//IL_230d: Expected Obj, but got Unknown
		//IL_2316: Unknown result type (might be due to invalid IL or missing references)
		//IL_231b: Expected Obj, but got Unknown
		//IL_233b: Expected Obj, but got I
		//IL_234b: Expected Obj, but got I
		//IL_235b: Expected Obj, but got I
		//IL_2364: Unknown result type (might be due to invalid IL or missing references)
		//IL_2369: Expected Obj, but got Unknown
		//IL_2372: Unknown result type (might be due to invalid IL or missing references)
		//IL_2377: Expected Obj, but got Unknown
		//IL_2397: Expected Obj, but got I
		//IL_23a7: Expected Obj, but got I
		//IL_23b7: Expected Obj, but got I
		//IL_23c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c5: Expected Obj, but got Unknown
		//IL_23ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d3: Expected Obj, but got Unknown
		//IL_23f3: Expected Obj, but got I
		//IL_2403: Expected Obj, but got I
		//IL_2413: Expected Obj, but got I
		//IL_241c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2421: Expected Obj, but got Unknown
		//IL_242a: Unknown result type (might be due to invalid IL or missing references)
		//IL_242f: Expected Obj, but got Unknown
		//IL_244f: Expected Obj, but got I
		//IL_245f: Expected Obj, but got I
		//IL_246f: Expected Obj, but got I
		//IL_2478: Unknown result type (might be due to invalid IL or missing references)
		//IL_247d: Expected Obj, but got Unknown
		//IL_2486: Unknown result type (might be due to invalid IL or missing references)
		//IL_248b: Expected Obj, but got Unknown
		//IL_24ab: Expected Obj, but got I
		//IL_24bb: Expected Obj, but got I
		//IL_24cb: Expected Obj, but got I
		//IL_24d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d9: Expected Obj, but got Unknown
		//IL_24e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24e7: Expected Obj, but got Unknown
		//IL_2507: Expected Obj, but got I
		//IL_2517: Expected Obj, but got I
		//IL_2527: Expected Obj, but got I
		//IL_2530: Unknown result type (might be due to invalid IL or missing references)
		//IL_2535: Expected Obj, but got Unknown
		//IL_253e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2543: Expected Obj, but got Unknown
		//IL_2563: Expected Obj, but got I
		//IL_2573: Expected Obj, but got I
		//IL_2583: Expected Obj, but got I
		//IL_258c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2591: Expected Obj, but got Unknown
		//IL_259a: Unknown result type (might be due to invalid IL or missing references)
		//IL_259f: Expected Obj, but got Unknown
		//IL_25bf: Expected Obj, but got I
		//IL_25cf: Expected Obj, but got I
		//IL_25df: Expected Obj, but got I
		//IL_25e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ed: Expected Obj, but got Unknown
		//IL_25f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_25fb: Expected Obj, but got Unknown
		//IL_261b: Expected Obj, but got I
		//IL_262b: Expected Obj, but got I
		//IL_263b: Expected Obj, but got I
		//IL_2644: Unknown result type (might be due to invalid IL or missing references)
		//IL_2649: Expected Obj, but got Unknown
		//IL_2652: Unknown result type (might be due to invalid IL or missing references)
		//IL_2657: Expected Obj, but got Unknown
		//IL_266f: Expected I, but got Obj
		//IL_2685: Expected Obj, but got I
		//IL_269b: Expected Obj, but got I
		//IL_26ab: Expected Obj, but got I
		//IL_26bb: Expected Obj, but got I
		//IL_26c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c9: Expected Obj, but got Unknown
		//IL_26d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d7: Expected Obj, but got Unknown
		//IL_26f7: Expected Obj, but got I
		//IL_2707: Expected Obj, but got I
		//IL_2717: Expected Obj, but got I
		//IL_2720: Unknown result type (might be due to invalid IL or missing references)
		//IL_2725: Expected Obj, but got Unknown
		//IL_272e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2733: Expected Obj, but got Unknown
		//IL_2753: Expected Obj, but got I
		//IL_2763: Expected Obj, but got I
		//IL_2773: Expected Obj, but got I
		//IL_277c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2781: Expected Obj, but got Unknown
		//IL_278a: Unknown result type (might be due to invalid IL or missing references)
		//IL_278f: Expected Obj, but got Unknown
		//IL_27af: Expected Obj, but got I
		//IL_27bf: Expected Obj, but got I
		//IL_27cf: Expected Obj, but got I
		//IL_27d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27dd: Expected Obj, but got Unknown
		//IL_27e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_27eb: Expected Obj, but got Unknown
		//IL_280b: Expected Obj, but got I
		//IL_281b: Expected Obj, but got I
		//IL_282b: Expected Obj, but got I
		//IL_2834: Unknown result type (might be due to invalid IL or missing references)
		//IL_2839: Expected Obj, but got Unknown
		//IL_2842: Unknown result type (might be due to invalid IL or missing references)
		//IL_2847: Expected Obj, but got Unknown
		//IL_2867: Expected Obj, but got I
		//IL_2877: Expected Obj, but got I
		//IL_2887: Expected Obj, but got I
		//IL_2890: Unknown result type (might be due to invalid IL or missing references)
		//IL_2895: Expected Obj, but got Unknown
		//IL_289e: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a3: Expected Obj, but got Unknown
		//IL_28c3: Expected Obj, but got I
		//IL_28d3: Expected Obj, but got I
		//IL_28e3: Expected Obj, but got I
		//IL_28ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f1: Expected Obj, but got Unknown
		//IL_28fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ff: Expected Obj, but got Unknown
		//IL_291f: Expected Obj, but got I
		//IL_292f: Expected Obj, but got I
		//IL_293f: Expected Obj, but got I
		//IL_2948: Unknown result type (might be due to invalid IL or missing references)
		//IL_294d: Expected Obj, but got Unknown
		//IL_2956: Unknown result type (might be due to invalid IL or missing references)
		//IL_295b: Expected Obj, but got Unknown
		//IL_297b: Expected Obj, but got I
		//IL_298b: Expected Obj, but got I
		//IL_299b: Expected Obj, but got I
		//IL_29a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a9: Expected Obj, but got Unknown
		//IL_29b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b7: Expected Obj, but got Unknown
		//IL_29d7: Expected Obj, but got I
		//IL_29e7: Expected Obj, but got I
		//IL_29f7: Expected Obj, but got I
		//IL_2a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a05: Expected Obj, but got Unknown
		//IL_2a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a13: Expected Obj, but got Unknown
		//IL_2a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a28: Expected Obj, but got Unknown
		//IL_2a50: Expected Obj, but got I
		//IL_2a60: Expected Obj, but got I
		//IL_2a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a76: Expected Obj, but got Unknown
		//IL_2a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a84: Expected Obj, but got Unknown
		//IL_2a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a99: Expected Obj, but got Unknown
		//IL_2ac1: Expected Obj, but got I
		//IL_2ad1: Expected Obj, but got I
		//IL_2ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae7: Expected Obj, but got Unknown
		//IL_2af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af5: Expected Obj, but got Unknown
		//IL_2b15: Expected Obj, but got I
		//IL_2b25: Expected Obj, but got I
		//IL_2b35: Expected Obj, but got I
		//IL_2b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b43: Expected Obj, but got Unknown
		//IL_2b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b51: Expected Obj, but got Unknown
		//IL_2b71: Expected Obj, but got I
		//IL_2b81: Expected Obj, but got I
		//IL_2b91: Expected Obj, but got I
		//IL_2b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b9f: Expected Obj, but got Unknown
		//IL_2ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bad: Expected Obj, but got Unknown
		//IL_2bcd: Expected Obj, but got I
		//IL_2bdd: Expected Obj, but got I
		//IL_2bed: Expected Obj, but got I
		//IL_2bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bfb: Expected Obj, but got Unknown
		//IL_2c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c09: Expected Obj, but got Unknown
		//IL_2c29: Expected Obj, but got I
		//IL_2c39: Expected Obj, but got I
		//IL_2c49: Expected Obj, but got I
		//IL_2c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c57: Expected Obj, but got Unknown
		//IL_2c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c65: Expected Obj, but got Unknown
		//IL_2c85: Expected Obj, but got I
		//IL_2c95: Expected Obj, but got I
		//IL_2ca5: Expected Obj, but got I
		//IL_2cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb3: Expected Obj, but got Unknown
		//IL_2cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc1: Expected Obj, but got Unknown
		//IL_2ce1: Expected Obj, but got I
		//IL_2cf1: Expected Obj, but got I
		//IL_2d01: Expected Obj, but got I
		//IL_2d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d0f: Expected Obj, but got Unknown
		//IL_2d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1d: Expected Obj, but got Unknown
		//IL_2d3d: Expected Obj, but got I
		//IL_2d4d: Expected Obj, but got I
		//IL_2d5d: Expected Obj, but got I
		//IL_2d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d6b: Expected Obj, but got Unknown
		//IL_2d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d79: Expected Obj, but got Unknown
		//IL_2d99: Expected Obj, but got I
		//IL_2da9: Expected Obj, but got I
		//IL_2db9: Expected Obj, but got I
		//IL_2dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc7: Expected Obj, but got Unknown
		//IL_2dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dd5: Expected Obj, but got Unknown
		//IL_2df5: Expected Obj, but got I
		//IL_2e05: Expected Obj, but got I
		//IL_2e15: Expected Obj, but got I
		//IL_2e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e23: Expected Obj, but got Unknown
		//IL_2e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e31: Expected Obj, but got Unknown
		//IL_2e51: Expected Obj, but got I
		//IL_2e61: Expected Obj, but got I
		//IL_2e71: Expected Obj, but got I
		//IL_2e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e7f: Expected Obj, but got Unknown
		//IL_2e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e8d: Expected Obj, but got Unknown
		//IL_2ead: Expected Obj, but got I
		//IL_2ebd: Expected Obj, but got I
		//IL_2ecd: Expected Obj, but got I
		//IL_2ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2edb: Expected Obj, but got Unknown
		//IL_2ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee9: Expected Obj, but got Unknown
		//IL_2f09: Expected Obj, but got I
		//IL_2f19: Expected Obj, but got I
		//IL_2f29: Expected Obj, but got I
		//IL_2f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f37: Expected Obj, but got Unknown
		//IL_2f40: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f45: Expected Obj, but got Unknown
		//IL_2f65: Expected Obj, but got I
		//IL_2f75: Expected Obj, but got I
		//IL_2f85: Expected Obj, but got I
		//IL_2f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f93: Expected Obj, but got Unknown
		//IL_2f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa1: Expected Obj, but got Unknown
		//IL_2fb9: Expected I, but got Obj
		//IL_2fcf: Expected Obj, but got I
		//IL_2fe5: Expected Obj, but got I
		//IL_2ff5: Expected Obj, but got I
		//IL_3005: Expected Obj, but got I
		//IL_300e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3013: Expected Obj, but got Unknown
		//IL_301c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3021: Expected Obj, but got Unknown
		//IL_3041: Expected Obj, but got I
		//IL_3051: Expected Obj, but got I
		//IL_3061: Expected Obj, but got I
		//IL_306a: Unknown result type (might be due to invalid IL or missing references)
		//IL_306f: Expected Obj, but got Unknown
		//IL_3078: Unknown result type (might be due to invalid IL or missing references)
		//IL_307d: Expected Obj, but got Unknown
		//IL_309d: Expected Obj, but got I
		//IL_30ad: Expected Obj, but got I
		//IL_30bd: Expected Obj, but got I
		//IL_30c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_30cb: Expected Obj, but got Unknown
		//IL_30d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d9: Expected Obj, but got Unknown
		//IL_30f9: Expected Obj, but got I
		//IL_3109: Expected Obj, but got I
		//IL_3119: Expected Obj, but got I
		//IL_3122: Unknown result type (might be due to invalid IL or missing references)
		//IL_3127: Expected Obj, but got Unknown
		//IL_3130: Unknown result type (might be due to invalid IL or missing references)
		//IL_3135: Expected Obj, but got Unknown
		//IL_3155: Expected Obj, but got I
		//IL_3165: Expected Obj, but got I
		//IL_3175: Expected Obj, but got I
		//IL_317e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3183: Expected Obj, but got Unknown
		//IL_318c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3191: Expected Obj, but got Unknown
		//IL_31b1: Expected Obj, but got I
		//IL_31c1: Expected Obj, but got I
		//IL_31d1: Expected Obj, but got I
		//IL_31da: Unknown result type (might be due to invalid IL or missing references)
		//IL_31df: Expected Obj, but got Unknown
		//IL_31e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ed: Expected Obj, but got Unknown
		//IL_320d: Expected Obj, but got I
		//IL_321d: Expected Obj, but got I
		//IL_322d: Expected Obj, but got I
		//IL_3236: Unknown result type (might be due to invalid IL or missing references)
		//IL_323b: Expected Obj, but got Unknown
		//IL_3244: Unknown result type (might be due to invalid IL or missing references)
		//IL_3249: Expected Obj, but got Unknown
		//IL_3269: Expected Obj, but got I
		//IL_3279: Expected Obj, but got I
		//IL_3289: Expected Obj, but got I
		//IL_3292: Unknown result type (might be due to invalid IL or missing references)
		//IL_3297: Expected Obj, but got Unknown
		//IL_32a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a5: Expected Obj, but got Unknown
		//IL_32c5: Expected Obj, but got I
		//IL_32d5: Expected Obj, but got I
		//IL_32e5: Expected Obj, but got I
		//IL_32ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_32f3: Expected Obj, but got Unknown
		//IL_32fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3301: Expected Obj, but got Unknown
		//IL_3311: Unknown result type (might be due to invalid IL or missing references)
		//IL_3316: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0078: Expected Obj, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got I
		//IL_0128: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0174: Expected Obj, but got I
		//IL_0184: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I
		//IL_0298: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got I
		//IL_02f4: Expected Obj, but got I
		//IL_0304: Expected Obj, but got I
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0340: Expected Obj, but got I
		//IL_0350: Expected Obj, but got I
		//IL_0360: Expected Obj, but got I
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got I
		//IL_03ac: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_03f8: Expected Obj, but got I
		//IL_0408: Expected Obj, but got I
		//IL_0418: Expected Obj, but got I
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected Obj, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_0454: Expected Obj, but got I
		//IL_0464: Expected Obj, but got I
		//IL_0474: Expected Obj, but got I
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected Obj, but got Unknown
		//IL_04b0: Expected Obj, but got I
		//IL_04c0: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got Unknown
		//IL_050c: Expected Obj, but got I
		//IL_051c: Expected Obj, but got I
		//IL_052c: Expected Obj, but got I
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_0560: Expected I, but got Obj
		//IL_0576: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I
		//IL_059c: Expected Obj, but got I
		//IL_05ac: Expected Obj, but got I
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_05e8: Expected Obj, but got I
		//IL_05f8: Expected Obj, but got I
		//IL_0608: Expected Obj, but got I
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_0644: Expected Obj, but got I
		//IL_0654: Expected Obj, but got I
		//IL_0664: Expected Obj, but got I
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected Obj, but got Unknown
		//IL_06a0: Expected Obj, but got I
		//IL_06b0: Expected Obj, but got I
		//IL_06c0: Expected Obj, but got I
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected Obj, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got Unknown
		//IL_06fc: Expected Obj, but got I
		//IL_070c: Expected Obj, but got I
		//IL_071c: Expected Obj, but got I
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected Obj, but got Unknown
		//IL_0758: Expected Obj, but got I
		//IL_0768: Expected Obj, but got I
		//IL_0778: Expected Obj, but got I
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected Obj, but got Unknown
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected Obj, but got Unknown
		//IL_07b4: Expected Obj, but got I
		//IL_07c4: Expected Obj, but got I
		//IL_07d4: Expected Obj, but got I
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected Obj, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_0810: Expected Obj, but got I
		//IL_0820: Expected Obj, but got I
		//IL_0830: Expected Obj, but got I
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected Obj, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected Obj, but got Unknown
		//IL_086c: Expected Obj, but got I
		//IL_087c: Expected Obj, but got I
		//IL_088c: Expected Obj, but got I
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected Obj, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected Obj, but got Unknown
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected Obj, but got Unknown
		//IL_08e5: Expected Obj, but got I
		//IL_08f5: Expected Obj, but got I
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected Obj, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected Obj, but got Unknown
		//IL_0939: Expected Obj, but got I
		//IL_0949: Expected Obj, but got I
		//IL_0959: Expected Obj, but got I
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got Unknown
		//IL_0995: Expected Obj, but got I
		//IL_09a5: Expected Obj, but got I
		//IL_09b5: Expected Obj, but got I
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected Obj, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected Obj, but got Unknown
		//IL_09f1: Expected Obj, but got I
		//IL_0a01: Expected Obj, but got I
		//IL_0a11: Expected Obj, but got I
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1f: Expected Obj, but got Unknown
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2d: Expected Obj, but got Unknown
		//IL_0a4d: Expected Obj, but got I
		//IL_0a5d: Expected Obj, but got I
		//IL_0a6d: Expected Obj, but got I
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected Obj, but got Unknown
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected Obj, but got Unknown
		//IL_0aa9: Expected Obj, but got I
		//IL_0ab9: Expected Obj, but got I
		//IL_0ac9: Expected Obj, but got I
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Expected Obj, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected Obj, but got Unknown
		//IL_0b05: Expected Obj, but got I
		//IL_0b15: Expected Obj, but got I
		//IL_0b25: Expected Obj, but got I
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected Obj, but got Unknown
		//IL_0b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b41: Expected Obj, but got Unknown
		//IL_0b61: Expected Obj, but got I
		//IL_0b71: Expected Obj, but got I
		//IL_0b81: Expected Obj, but got I
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8f: Expected Obj, but got Unknown
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Expected Obj, but got Unknown
		//IL_0bbd: Expected Obj, but got I
		//IL_0bcd: Expected Obj, but got I
		//IL_0bdd: Expected Obj, but got I
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Expected Obj, but got Unknown
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf9: Expected Obj, but got Unknown
		//IL_0c19: Expected Obj, but got I
		//IL_0c29: Expected Obj, but got I
		//IL_0c39: Expected Obj, but got I
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Expected Obj, but got Unknown
		//IL_0c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Expected Obj, but got Unknown
		//IL_0c75: Expected Obj, but got I
		//IL_0c85: Expected Obj, but got I
		//IL_0c95: Expected Obj, but got I
		//IL_0c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected Obj, but got Unknown
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Expected Obj, but got Unknown
		//IL_0cc9: Expected I, but got Obj
		//IL_0cdf: Expected Obj, but got I
		//IL_0cf5: Expected Obj, but got I
		//IL_0d05: Expected Obj, but got I
		//IL_0d15: Expected Obj, but got I
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d23: Expected Obj, but got Unknown
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected Obj, but got Unknown
		//IL_0d51: Expected Obj, but got I
		//IL_0d61: Expected Obj, but got I
		//IL_0d71: Expected Obj, but got I
		//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7f: Expected Obj, but got Unknown
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Expected Obj, but got Unknown
		//IL_0dad: Expected Obj, but got I
		//IL_0dbd: Expected Obj, but got I
		//IL_0dcd: Expected Obj, but got I
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddb: Expected Obj, but got Unknown
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Expected Obj, but got Unknown
		//IL_0e09: Expected Obj, but got I
		//IL_0e19: Expected Obj, but got I
		//IL_0e29: Expected Obj, but got I
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e37: Expected Obj, but got Unknown
		//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected Obj, but got Unknown
		//IL_0e65: Expected Obj, but got I
		//IL_0e75: Expected Obj, but got I
		//IL_0e85: Expected Obj, but got I
		//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e93: Expected Obj, but got Unknown
		//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea1: Expected Obj, but got Unknown
		//IL_0ec1: Expected Obj, but got I
		//IL_0ed1: Expected Obj, but got I
		//IL_0ee1: Expected Obj, but got I
		//IL_0eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Expected Obj, but got Unknown
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Expected Obj, but got Unknown
		//IL_0f1d: Expected Obj, but got I
		//IL_0f2d: Expected Obj, but got I
		//IL_0f3d: Expected Obj, but got I
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Expected Obj, but got Unknown
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Expected Obj, but got Unknown
		//IL_0f79: Expected Obj, but got I
		//IL_0f89: Expected Obj, but got I
		//IL_0f99: Expected Obj, but got I
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa7: Expected Obj, but got Unknown
		//IL_0fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb5: Expected Obj, but got Unknown
		//IL_0fd5: Expected Obj, but got I
		//IL_0fe5: Expected Obj, but got I
		//IL_0ff5: Expected Obj, but got I
		//IL_0ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Expected Obj, but got Unknown
		//IL_100c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Expected Obj, but got Unknown
		//IL_1031: Expected Obj, but got I
		//IL_1041: Expected Obj, but got I
		//IL_1051: Expected Obj, but got I
		//IL_105a: Unknown result type (might be due to invalid IL or missing references)
		//IL_105f: Expected Obj, but got Unknown
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_106d: Expected Obj, but got Unknown
		//IL_107d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1082: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_10af: Expected Obj, but got I
		//IL_10bf: Expected Obj, but got I
		//IL_10d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d5: Expected Obj, but got Unknown
		//IL_10de: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e3: Expected Obj, but got Unknown
		//IL_1103: Expected Obj, but got I
		//IL_1113: Expected Obj, but got I
		//IL_1123: Expected Obj, but got I
		//IL_112c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1131: Expected Obj, but got Unknown
		//IL_113a: Unknown result type (might be due to invalid IL or missing references)
		//IL_113f: Expected Obj, but got Unknown
		//IL_115f: Expected Obj, but got I
		//IL_116f: Expected Obj, but got I
		//IL_117f: Expected Obj, but got I
		//IL_1188: Unknown result type (might be due to invalid IL or missing references)
		//IL_118d: Expected Obj, but got Unknown
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Expected Obj, but got Unknown
		//IL_11bb: Expected Obj, but got I
		//IL_11cb: Expected Obj, but got I
		//IL_11db: Expected Obj, but got I
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e9: Expected Obj, but got Unknown
		//IL_11f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f7: Expected Obj, but got Unknown
		//IL_1217: Expected Obj, but got I
		//IL_1227: Expected Obj, but got I
		//IL_1237: Expected Obj, but got I
		//IL_1240: Unknown result type (might be due to invalid IL or missing references)
		//IL_1245: Expected Obj, but got Unknown
		//IL_124e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Expected Obj, but got Unknown
		//IL_1273: Expected Obj, but got I
		//IL_1283: Expected Obj, but got I
		//IL_1293: Expected Obj, but got I
		//IL_129c: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a1: Expected Obj, but got Unknown
		//IL_12aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_12af: Expected Obj, but got Unknown
		//IL_12cf: Expected Obj, but got I
		//IL_12df: Expected Obj, but got I
		//IL_12ef: Expected Obj, but got I
		//IL_12f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fd: Expected Obj, but got Unknown
		//IL_1306: Unknown result type (might be due to invalid IL or missing references)
		//IL_130b: Expected Obj, but got Unknown
		//IL_132b: Expected Obj, but got I
		//IL_133b: Expected Obj, but got I
		//IL_134b: Expected Obj, but got I
		//IL_1354: Unknown result type (might be due to invalid IL or missing references)
		//IL_1359: Expected Obj, but got Unknown
		//IL_1362: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected Obj, but got Unknown
		//IL_1387: Expected Obj, but got I
		//IL_1397: Expected Obj, but got I
		//IL_13a7: Expected Obj, but got I
		//IL_13b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b5: Expected Obj, but got Unknown
		//IL_13be: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c3: Expected Obj, but got Unknown
		//IL_13e3: Expected Obj, but got I
		//IL_13f3: Expected Obj, but got I
		//IL_1403: Expected Obj, but got I
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1411: Expected Obj, but got Unknown
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected Obj, but got Unknown
		//IL_143f: Expected Obj, but got I
		//IL_144f: Expected Obj, but got I
		//IL_145f: Expected Obj, but got I
		//IL_1468: Unknown result type (might be due to invalid IL or missing references)
		//IL_146d: Expected Obj, but got Unknown
		//IL_1476: Unknown result type (might be due to invalid IL or missing references)
		//IL_147b: Expected Obj, but got Unknown
		//IL_149b: Expected Obj, but got I
		//IL_14ab: Expected Obj, but got I
		//IL_14bb: Expected Obj, but got I
		//IL_14c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c9: Expected Obj, but got Unknown
		//IL_14d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d7: Expected Obj, but got Unknown
		//IL_14f7: Expected Obj, but got I
		//IL_1507: Expected Obj, but got I
		//IL_1517: Expected Obj, but got I
		//IL_1520: Unknown result type (might be due to invalid IL or missing references)
		//IL_1525: Expected Obj, but got Unknown
		//IL_152e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1533: Expected Obj, but got Unknown
		//IL_1553: Expected Obj, but got I
		//IL_1563: Expected Obj, but got I
		//IL_1573: Expected Obj, but got I
		//IL_157c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1581: Expected Obj, but got Unknown
		//IL_158a: Unknown result type (might be due to invalid IL or missing references)
		//IL_158f: Expected Obj, but got Unknown
		//IL_15a7: Expected I, but got Obj
		//IL_15bd: Expected Obj, but got I
		//IL_15d3: Expected Obj, but got I
		//IL_15e3: Expected Obj, but got I
		//IL_15f3: Expected Obj, but got I
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1601: Expected Obj, but got Unknown
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected Obj, but got Unknown
		//IL_162f: Expected Obj, but got I
		//IL_163f: Expected Obj, but got I
		//IL_164f: Expected Obj, but got I
		//IL_1658: Unknown result type (might be due to invalid IL or missing references)
		//IL_165d: Expected Obj, but got Unknown
		//IL_1666: Unknown result type (might be due to invalid IL or missing references)
		//IL_166b: Expected Obj, but got Unknown
		//IL_168b: Expected Obj, but got I
		//IL_169b: Expected Obj, but got I
		//IL_16ab: Expected Obj, but got I
		//IL_16b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b9: Expected Obj, but got Unknown
		//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Expected Obj, but got Unknown
		//IL_16e7: Expected Obj, but got I
		//IL_16f7: Expected Obj, but got I
		//IL_1707: Expected Obj, but got I
		//IL_1710: Unknown result type (might be due to invalid IL or missing references)
		//IL_1715: Expected Obj, but got Unknown
		//IL_171e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1723: Expected Obj, but got Unknown
		//IL_1743: Expected Obj, but got I
		//IL_1753: Expected Obj, but got I
		//IL_1763: Expected Obj, but got I
		//IL_176c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1771: Expected Obj, but got Unknown
		//IL_177a: Unknown result type (might be due to invalid IL or missing references)
		//IL_177f: Expected Obj, but got Unknown
		//IL_179f: Expected Obj, but got I
		//IL_17af: Expected Obj, but got I
		//IL_17bf: Expected Obj, but got I
		//IL_17c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cd: Expected Obj, but got Unknown
		//IL_17d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17db: Expected Obj, but got Unknown
		//IL_17fb: Expected Obj, but got I
		//IL_180b: Expected Obj, but got I
		//IL_181b: Expected Obj, but got I
		//IL_1824: Unknown result type (might be due to invalid IL or missing references)
		//IL_1829: Expected Obj, but got Unknown
		//IL_1832: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected Obj, but got Unknown
		//IL_1857: Expected Obj, but got I
		//IL_1867: Expected Obj, but got I
		//IL_1877: Expected Obj, but got I
		//IL_1880: Unknown result type (might be due to invalid IL or missing references)
		//IL_1885: Expected Obj, but got Unknown
		//IL_188e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1893: Expected Obj, but got Unknown
		//IL_18b3: Expected Obj, but got I
		//IL_18c3: Expected Obj, but got I
		//IL_18d3: Expected Obj, but got I
		//IL_18dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e1: Expected Obj, but got Unknown
		//IL_18ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ef: Expected Obj, but got Unknown
		//IL_18ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1904: Expected Obj, but got Unknown
		//IL_192c: Expected Obj, but got I
		//IL_193c: Expected Obj, but got I
		//IL_194d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1952: Expected Obj, but got Unknown
		//IL_195b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1960: Expected Obj, but got Unknown
		//IL_1970: Unknown result type (might be due to invalid IL or missing references)
		//IL_1975: Expected Obj, but got Unknown
		//IL_19a2: Expected Obj, but got I
		//IL_19b2: Expected Obj, but got I
		//IL_19c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c8: Expected Obj, but got Unknown
		//IL_19d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d6: Expected Obj, but got Unknown
		//IL_19f6: Expected Obj, but got I
		//IL_1a06: Expected Obj, but got I
		//IL_1a16: Expected Obj, but got I
		//IL_1a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a24: Expected Obj, but got Unknown
		//IL_1a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a32: Expected Obj, but got Unknown
		//IL_1a52: Expected Obj, but got I
		//IL_1a62: Expected Obj, but got I
		//IL_1a72: Expected Obj, but got I
		//IL_1a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a80: Expected Obj, but got Unknown
		//IL_1a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8e: Expected Obj, but got Unknown
		//IL_1aae: Expected Obj, but got I
		//IL_1abe: Expected Obj, but got I
		//IL_1ace: Expected Obj, but got I
		//IL_1ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adc: Expected Obj, but got Unknown
		//IL_1ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aea: Expected Obj, but got Unknown
		//IL_1b0a: Expected Obj, but got I
		//IL_1b1a: Expected Obj, but got I
		//IL_1b2a: Expected Obj, but got I
		//IL_1b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b38: Expected Obj, but got Unknown
		//IL_1b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b46: Expected Obj, but got Unknown
		//IL_1b66: Expected Obj, but got I
		//IL_1b76: Expected Obj, but got I
		//IL_1b86: Expected Obj, but got I
		//IL_1b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b94: Expected Obj, but got Unknown
		//IL_1b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba2: Expected Obj, but got Unknown
		//IL_1bc2: Expected Obj, but got I
		//IL_1bd2: Expected Obj, but got I
		//IL_1be2: Expected Obj, but got I
		//IL_1beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf0: Expected Obj, but got Unknown
		//IL_1bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfe: Expected Obj, but got Unknown
		//IL_1c1e: Expected Obj, but got I
		//IL_1c2e: Expected Obj, but got I
		//IL_1c3e: Expected Obj, but got I
		//IL_1c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4c: Expected Obj, but got Unknown
		//IL_1c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5a: Expected Obj, but got Unknown
		//IL_1c7a: Expected Obj, but got I
		//IL_1c8a: Expected Obj, but got I
		//IL_1c9a: Expected Obj, but got I
		//IL_1ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca8: Expected Obj, but got Unknown
		//IL_1cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb6: Expected Obj, but got Unknown
		//IL_1cd6: Expected Obj, but got I
		//IL_1ce6: Expected Obj, but got I
		//IL_1cf6: Expected Obj, but got I
		//IL_1cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d04: Expected Obj, but got Unknown
		//IL_1d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d12: Expected Obj, but got Unknown
		//IL_1d32: Expected Obj, but got I
		//IL_1d42: Expected Obj, but got I
		//IL_1d52: Expected Obj, but got I
		//IL_1d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d60: Expected Obj, but got Unknown
		//IL_1d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6e: Expected Obj, but got Unknown
		//IL_1d86: Expected I, but got Obj
		//IL_1d9c: Expected Obj, but got I
		//IL_1db2: Expected Obj, but got I
		//IL_1dc2: Expected Obj, but got I
		//IL_1dd2: Expected Obj, but got I
		//IL_1ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de0: Expected Obj, but got Unknown
		//IL_1de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dee: Expected Obj, but got Unknown
		//IL_1e0e: Expected Obj, but got I
		//IL_1e1e: Expected Obj, but got I
		//IL_1e2e: Expected Obj, but got I
		//IL_1e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3c: Expected Obj, but got Unknown
		//IL_1e45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4a: Expected Obj, but got Unknown
		//IL_1e6a: Expected Obj, but got I
		//IL_1e7a: Expected Obj, but got I
		//IL_1e8a: Expected Obj, but got I
		//IL_1e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e98: Expected Obj, but got Unknown
		//IL_1ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea6: Expected Obj, but got Unknown
		//IL_1ec6: Expected Obj, but got I
		//IL_1ed6: Expected Obj, but got I
		//IL_1ee6: Expected Obj, but got I
		//IL_1eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef4: Expected Obj, but got Unknown
		//IL_1efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f02: Expected Obj, but got Unknown
		//IL_1f22: Expected Obj, but got I
		//IL_1f32: Expected Obj, but got I
		//IL_1f42: Expected Obj, but got I
		//IL_1f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f50: Expected Obj, but got Unknown
		//IL_1f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5e: Expected Obj, but got Unknown
		//IL_1f7e: Expected Obj, but got I
		//IL_1f8e: Expected Obj, but got I
		//IL_1f9e: Expected Obj, but got I
		//IL_1fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fac: Expected Obj, but got Unknown
		//IL_1fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fba: Expected Obj, but got Unknown
		//IL_1fda: Expected Obj, but got I
		//IL_1fea: Expected Obj, but got I
		//IL_1ffa: Expected Obj, but got I
		//IL_2003: Unknown result type (might be due to invalid IL or missing references)
		//IL_2008: Expected Obj, but got Unknown
		//IL_2011: Unknown result type (might be due to invalid IL or missing references)
		//IL_2016: Expected Obj, but got Unknown
		//IL_2036: Expected Obj, but got I
		//IL_2046: Expected Obj, but got I
		//IL_2056: Expected Obj, but got I
		//IL_205f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2064: Expected Obj, but got Unknown
		//IL_206d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2072: Expected Obj, but got Unknown
		//IL_2092: Expected Obj, but got I
		//IL_20a2: Expected Obj, but got I
		//IL_20b2: Expected Obj, but got I
		//IL_20bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c0: Expected Obj, but got Unknown
		//IL_20c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ce: Expected Obj, but got Unknown
		//IL_20ee: Expected Obj, but got I
		//IL_20fe: Expected Obj, but got I
		//IL_210e: Expected Obj, but got I
		//IL_2117: Unknown result type (might be due to invalid IL or missing references)
		//IL_211c: Expected Obj, but got Unknown
		//IL_2125: Unknown result type (might be due to invalid IL or missing references)
		//IL_212a: Expected Obj, but got Unknown
		//IL_213a: Unknown result type (might be due to invalid IL or missing references)
		//IL_213f: Expected Obj, but got Unknown
		//IL_2167: Expected Obj, but got I
		//IL_2177: Expected Obj, but got I
		//IL_2188: Unknown result type (might be due to invalid IL or missing references)
		//IL_218d: Expected Obj, but got Unknown
		//IL_2196: Unknown result type (might be due to invalid IL or missing references)
		//IL_219b: Expected Obj, but got Unknown
		//IL_21ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b0: Expected Obj, but got Unknown
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
		nint num3 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v14 (Il2CppClass<AdLocations>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v312 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v10 (Il2CppMethodInfo)+C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v11+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v12+48]");
		object obj16 = 0;
		object obj17 = obj16 & 0x7FF;
		object obj18 = obj17 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88 @ S5_v8 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v15 (Il2CppMethodInfo)+C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v16+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v17+48]");
		object obj21 = 0;
		object obj22 = obj21 & 0x7FF;
		object obj23 = obj22 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S5_v12 (should have been resolved before IL gen)");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v20 (Il2CppMethodInfo)+C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S4_v21+60]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S4_v22+48]");
		object obj26 = 0;
		object obj27 = obj26 & 0x7FF;
		object obj28 = obj27 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v130 @ S5_v16 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S4_v25 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S4_v26+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v27+48]");
		object obj31 = 0;
		object obj32 = obj31 & 0x7FF;
		object obj33 = obj32 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v151 @ S5_v20 (should have been resolved before IL gen)");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v30 (Il2CppMethodInfo)+C]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v31+60]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S4_v32+48]");
		object obj36 = 0;
		object obj37 = obj36 & 0x7FF;
		object obj38 = obj37 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172 @ S5_v24 (should have been resolved before IL gen)");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S4_v35 (Il2CppMethodInfo)+C]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S4_v36+60]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S4_v37+48]");
		object obj41 = 0;
		object obj42 = obj41 & 0x7FF;
		object obj43 = obj42 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v193 @ S5_v28 (should have been resolved before IL gen)");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S4_v40 (Il2CppMethodInfo)+C]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S4_v41+60]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S4_v42+48]");
		object obj46 = 0;
		object obj47 = obj46 & 0x7FF;
		object obj48 = obj47 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v214 @ S5_v32 (should have been resolved before IL gen)");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S4_v45 (Il2CppMethodInfo)+C]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S4_v46+60]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S4_v47+48]");
		object obj51 = 0;
		object obj52 = obj51 & 0x7FF;
		object obj53 = obj52 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v235 @ S5_v36 (should have been resolved before IL gen)");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S4_v50 (Il2CppMethodInfo)+C]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S4_v51+60]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S4_v52+48]");
		object obj56 = 0;
		object obj57 = obj56 & 0x7FF;
		object obj58 = obj57 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v256 @ S5_v40 (should have been resolved before IL gen)");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S4_v55 (Il2CppMethodInfo)+C]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S4_v56+60]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S4_v57+48]");
		object obj61 = 0;
		object obj62 = obj61 & 0x7FF;
		object obj63 = obj62 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v277 @ S5_v44 (should have been resolved before IL gen)");
		nint num15 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S1_v47 (Il2CppClass<AdLocations>)+5C]");
		object obj64 = -(-64);
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S4_v60 (Il2CppMethodInfo)+C]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S4_v61+60]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S4_v62+48]");
		object obj67 = 0;
		object obj68 = obj67 & 0x7FF;
		object obj69 = obj68 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v300 @ S5_v48 (should have been resolved before IL gen)");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S4_v65 (Il2CppMethodInfo)+C]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S4_v66+60]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S4_v67+48]");
		object obj72 = 0;
		object obj73 = obj72 & 0x7FF;
		object obj74 = obj73 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v321 @ S5_v52 (should have been resolved before IL gen)");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S4_v70 (Il2CppMethodInfo)+C]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S4_v71+60]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S4_v72+48]");
		object obj77 = 0;
		object obj78 = obj77 & 0x7FF;
		object obj79 = obj78 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v342 @ S5_v56 (should have been resolved before IL gen)");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S4_v75 (Il2CppMethodInfo)+C]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S4_v76+60]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S4_v77+48]");
		object obj82 = 0;
		object obj83 = obj82 & 0x7FF;
		object obj84 = obj83 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v363 @ S5_v60 (should have been resolved before IL gen)");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S4_v80 (Il2CppMethodInfo)+C]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S4_v81+60]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S4_v82+48]");
		object obj87 = 0;
		object obj88 = obj87 & 0x7FF;
		object obj89 = obj88 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v384 @ S5_v64 (should have been resolved before IL gen)");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S4_v85 (Il2CppMethodInfo)+C]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S4_v86+60]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S4_v87+48]");
		object obj92 = 0;
		object obj93 = obj92 & 0x7FF;
		object obj94 = obj93 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v405 @ S5_v68 (should have been resolved before IL gen)");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S4_v90 (Il2CppMethodInfo)+C]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S4_v91+60]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S4_v92+48]");
		object obj97 = 0;
		object obj98 = obj97 & 0x7FF;
		object obj99 = obj98 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v426 @ S5_v72 (should have been resolved before IL gen)");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S4_v95 (Il2CppMethodInfo)+C]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S4_v96+60]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S4_v97+48]");
		object obj102 = 0;
		object obj103 = obj102 & 0x7FF;
		object obj104 = obj103 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v447 @ S5_v76 (should have been resolved before IL gen)");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S4_v100 (Il2CppMethodInfo)+C]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S4_v101+60]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S4_v102+48]");
		object obj107 = 0;
		object obj108 = obj107 & 0x7FF;
		object obj109 = obj108 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v468 @ S5_v80 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S4_v105 (Il2CppMethodInfo)+C]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S4_v106+60]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S4_v107+48]");
		object obj112 = 0;
		object obj113 = obj112 & 0x7FF;
		object obj114 = obj113 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v489 @ S5_v84 (should have been resolved before IL gen)");
		object obj115 = this + 12;
		object obj116 = default;
		obj115 = obj116;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S3_v32 (Il2CppMethodInfo)+C]");
		object obj117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S3_v33+60]");
		object obj118 = 0;
		object obj119 = obj118;
		object obj120 = obj119 & 0x1FFF;
		object obj121 = obj120 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v513 @ S4_v112 (should have been resolved before IL gen)");
		object obj122 = this + 16;
		object obj123 = default;
		obj122 = obj123;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S3_v37 (Il2CppMethodInfo)+C]");
		object obj124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ S3_v38+60]");
		object obj125 = 0;
		object obj126 = obj125;
		object obj127 = obj126 & 0x1FFF;
		object obj128 = obj127 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v537 @ S4_v116 (should have been resolved before IL gen)");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S4_v118 (Il2CppMethodInfo)+C]");
		object obj129 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S4_v119+60]");
		object obj130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S4_v120+48]");
		object obj131 = 0;
		object obj132 = obj131 & 0x7FF;
		object obj133 = obj132 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v558 @ S5_v92 (should have been resolved before IL gen)");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S4_v123 (Il2CppMethodInfo)+C]");
		object obj134 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S4_v124+60]");
		object obj135 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S4_v125+48]");
		object obj136 = 0;
		object obj137 = obj136 & 0x7FF;
		object obj138 = obj137 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v579 @ S5_v96 (should have been resolved before IL gen)");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S4_v128 (Il2CppMethodInfo)+C]");
		object obj139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S4_v129+60]");
		object obj140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ S4_v130+48]");
		object obj141 = 0;
		object obj142 = obj141 & 0x7FF;
		object obj143 = obj142 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v600 @ S5_v100 (should have been resolved before IL gen)");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S4_v133 (Il2CppMethodInfo)+C]");
		object obj144 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S4_v134+60]");
		object obj145 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S4_v135+48]");
		object obj146 = 0;
		object obj147 = obj146 & 0x7FF;
		object obj148 = obj147 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v621 @ S5_v104 (should have been resolved before IL gen)");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S4_v138 (Il2CppMethodInfo)+C]");
		object obj149 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S4_v139+60]");
		object obj150 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S4_v140+48]");
		object obj151 = 0;
		object obj152 = obj151 & 0x7FF;
		object obj153 = obj152 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v642 @ S5_v108 (should have been resolved before IL gen)");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ S4_v143 (Il2CppMethodInfo)+C]");
		object obj154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S4_v144+60]");
		object obj155 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ S4_v145+48]");
		object obj156 = 0;
		object obj157 = obj156 & 0x7FF;
		object obj158 = obj157 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v663 @ S5_v112 (should have been resolved before IL gen)");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S4_v148 (Il2CppMethodInfo)+C]");
		object obj159 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ S4_v149+60]");
		object obj160 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S4_v150+48]");
		object obj161 = 0;
		object obj162 = obj161 & 0x7FF;
		object obj163 = obj162 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v684 @ S5_v116 (should have been resolved before IL gen)");
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S4_v153 (Il2CppMethodInfo)+C]");
		object obj164 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S4_v154+60]");
		object obj165 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S4_v155+48]");
		object obj166 = 0;
		object obj167 = obj166 & 0x7FF;
		object obj168 = obj167 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v705 @ S5_v120 (should have been resolved before IL gen)");
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ S4_v158 (Il2CppMethodInfo)+C]");
		object obj169 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S4_v159+60]");
		object obj170 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ S4_v160+48]");
		object obj171 = 0;
		object obj172 = obj171 & 0x7FF;
		object obj173 = obj172 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v726 @ S5_v124 (should have been resolved before IL gen)");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S4_v163 (Il2CppMethodInfo)+C]");
		object obj174 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S4_v164+60]");
		object obj175 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ S4_v165+48]");
		object obj176 = 0;
		object obj177 = obj176 & 0x7FF;
		object obj178 = obj177 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v747 @ S5_v128 (should have been resolved before IL gen)");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S4_v168 (Il2CppMethodInfo)+C]");
		object obj179 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S4_v169+60]");
		object obj180 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S4_v170+48]");
		object obj181 = 0;
		object obj182 = obj181 & 0x7FF;
		object obj183 = obj182 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v768 @ S5_v132 (should have been resolved before IL gen)");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ S4_v173 (Il2CppMethodInfo)+C]");
		object obj184 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ S4_v174+60]");
		object obj185 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S4_v175+48]");
		object obj186 = 0;
		object obj187 = obj186 & 0x7FF;
		object obj188 = obj187 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v789 @ S5_v136 (should have been resolved before IL gen)");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ S4_v178 (Il2CppMethodInfo)+C]");
		object obj189 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ S4_v179+60]");
		object obj190 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ S4_v180+48]");
		object obj191 = 0;
		object obj192 = obj191 & 0x7FF;
		object obj193 = obj192 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v810 @ S5_v140 (should have been resolved before IL gen)");
		nint num41 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ S1_v146 (Il2CppClass<AdLocations>)+5C]");
		object obj194 = -(-64);
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ S4_v183 (Il2CppMethodInfo)+C]");
		object obj195 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ S4_v184+60]");
		object obj196 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ S4_v185+48]");
		object obj197 = 0;
		object obj198 = obj197 & 0x7FF;
		object obj199 = obj198 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v833 @ S5_v144 (should have been resolved before IL gen)");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ S4_v188 (Il2CppMethodInfo)+C]");
		object obj200 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S4_v189+60]");
		object obj201 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S4_v190+48]");
		object obj202 = 0;
		object obj203 = obj202 & 0x7FF;
		object obj204 = obj203 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v854 @ S5_v148 (should have been resolved before IL gen)");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ S4_v193 (Il2CppMethodInfo)+C]");
		object obj205 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S4_v194+60]");
		object obj206 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ S4_v195+48]");
		object obj207 = 0;
		object obj208 = obj207 & 0x7FF;
		object obj209 = obj208 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v875 @ S5_v152 (should have been resolved before IL gen)");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S4_v198 (Il2CppMethodInfo)+C]");
		object obj210 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ S4_v199+60]");
		object obj211 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ S4_v200+48]");
		object obj212 = 0;
		object obj213 = obj212 & 0x7FF;
		object obj214 = obj213 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v896 @ S5_v156 (should have been resolved before IL gen)");
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S4_v203 (Il2CppMethodInfo)+C]");
		object obj215 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ S4_v204+60]");
		object obj216 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ S4_v205+48]");
		object obj217 = 0;
		object obj218 = obj217 & 0x7FF;
		object obj219 = obj218 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v917 @ S5_v160 (should have been resolved before IL gen)");
		nint num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S4_v208 (Il2CppMethodInfo)+C]");
		object obj220 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ S4_v209+60]");
		object obj221 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ S4_v210+48]");
		object obj222 = 0;
		object obj223 = obj222 & 0x7FF;
		object obj224 = obj223 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v938 @ S5_v164 (should have been resolved before IL gen)");
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S4_v213 (Il2CppMethodInfo)+C]");
		object obj225 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ S4_v214+60]");
		object obj226 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ S4_v215+48]");
		object obj227 = 0;
		object obj228 = obj227 & 0x7FF;
		object obj229 = obj228 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v959 @ S5_v168 (should have been resolved before IL gen)");
		nint num49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ S4_v218 (Il2CppMethodInfo)+C]");
		object obj230 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v971 @ S4_v219+60]");
		object obj231 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ S4_v220+48]");
		object obj232 = 0;
		object obj233 = obj232 & 0x7FF;
		object obj234 = obj233 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v980 @ S5_v172 (should have been resolved before IL gen)");
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S4_v223 (Il2CppMethodInfo)+C]");
		object obj235 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ S4_v224+60]");
		object obj236 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ S4_v225+48]");
		object obj237 = 0;
		object obj238 = obj237 & 0x7FF;
		object obj239 = obj238 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1001 @ S5_v176 (should have been resolved before IL gen)");
		object obj240 = this + 20;
		object obj241 = default;
		obj240 = obj241;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ S3_v64 (Il2CppMethodInfo)+C]");
		object obj242 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ S3_v65+60]");
		object obj243 = 0;
		object obj244 = obj243;
		object obj245 = obj244 & 0x1FFF;
		object obj246 = obj245 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1024 @ S4_v230 (should have been resolved before IL gen)");
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ S4_v232 (Il2CppMethodInfo)+C]");
		object obj247 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ S4_v233+60]");
		object obj248 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ S4_v234+48]");
		object obj249 = 0;
		object obj250 = obj249 & 0x7FF;
		object obj251 = obj250 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1045 @ S5_v182 (should have been resolved before IL gen)");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ S4_v237 (Il2CppMethodInfo)+C]");
		object obj252 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ S4_v238+60]");
		object obj253 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ S4_v239+48]");
		object obj254 = 0;
		object obj255 = obj254 & 0x7FF;
		object obj256 = obj255 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1066 @ S5_v186 (should have been resolved before IL gen)");
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ S4_v242 (Il2CppMethodInfo)+C]");
		object obj257 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1078 @ S4_v243+60]");
		object obj258 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ S4_v244+48]");
		object obj259 = 0;
		object obj260 = obj259 & 0x7FF;
		object obj261 = obj260 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1087 @ S5_v190 (should have been resolved before IL gen)");
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ S4_v247 (Il2CppMethodInfo)+C]");
		object obj262 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ S4_v248+60]");
		object obj263 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ S4_v249+48]");
		object obj264 = 0;
		object obj265 = obj264 & 0x7FF;
		object obj266 = obj265 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1108 @ S5_v194 (should have been resolved before IL gen)");
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1119 @ S4_v252 (Il2CppMethodInfo)+C]");
		object obj267 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1120 @ S4_v253+60]");
		object obj268 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ S4_v254+48]");
		object obj269 = 0;
		object obj270 = obj269 & 0x7FF;
		object obj271 = obj270 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1129 @ S5_v198 (should have been resolved before IL gen)");
		nint num57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ S4_v257 (Il2CppMethodInfo)+C]");
		object obj272 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ S4_v258+60]");
		object obj273 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ S4_v259+48]");
		object obj274 = 0;
		object obj275 = obj274 & 0x7FF;
		object obj276 = obj275 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1150 @ S5_v202 (should have been resolved before IL gen)");
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ S4_v262 (Il2CppMethodInfo)+C]");
		object obj277 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ S4_v263+60]");
		object obj278 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ S4_v264+48]");
		object obj279 = 0;
		object obj280 = obj279 & 0x7FF;
		object obj281 = obj280 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1171 @ S5_v206 (should have been resolved before IL gen)");
		nint num59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S4_v267 (Il2CppMethodInfo)+C]");
		object obj282 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ S4_v268+60]");
		object obj283 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ S4_v269+48]");
		object obj284 = 0;
		object obj285 = obj284 & 0x7FF;
		object obj286 = obj285 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1192 @ S5_v210 (should have been resolved before IL gen)");
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ S4_v272 (Il2CppMethodInfo)+C]");
		object obj287 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1204 @ S4_v273+60]");
		object obj288 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ S4_v274+48]");
		object obj289 = 0;
		object obj290 = obj289 & 0x7FF;
		object obj291 = obj290 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1213 @ S5_v214 (should have been resolved before IL gen)");
		nint num61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ S4_v277 (Il2CppMethodInfo)+C]");
		object obj292 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ S4_v278+60]");
		object obj293 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ S4_v279+48]");
		object obj294 = 0;
		object obj295 = obj294 & 0x7FF;
		object obj296 = obj295 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1234 @ S5_v218 (should have been resolved before IL gen)");
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ S4_v282 (Il2CppMethodInfo)+C]");
		object obj297 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ S4_v283+60]");
		object obj298 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ S4_v284+48]");
		object obj299 = 0;
		object obj300 = obj299 & 0x7FF;
		object obj301 = obj300 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1255 @ S5_v222 (should have been resolved before IL gen)");
		nint num63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ S4_v287 (Il2CppMethodInfo)+C]");
		object obj302 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ S4_v288+60]");
		object obj303 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ S4_v289+48]");
		object obj304 = 0;
		object obj305 = obj304 & 0x7FF;
		object obj306 = obj305 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1276 @ S5_v226 (should have been resolved before IL gen)");
		nint num64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ S4_v292 (Il2CppMethodInfo)+C]");
		object obj307 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1288 @ S4_v293+60]");
		object obj308 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ S4_v294+48]");
		object obj309 = 0;
		object obj310 = obj309 & 0x7FF;
		object obj311 = obj310 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1297 @ S5_v230 (should have been resolved before IL gen)");
		nint num65 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1301 @ S1_v238 (Il2CppClass<AdLocations>)+5C]");
		object obj312 = -(-64);
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1310 @ S4_v297 (Il2CppMethodInfo)+C]");
		object obj313 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ S4_v298+60]");
		object obj314 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ S4_v299+48]");
		object obj315 = 0;
		object obj316 = obj315 & 0x7FF;
		object obj317 = obj316 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1320 @ S5_v234 (should have been resolved before IL gen)");
		nint num67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1331 @ S4_v302 (Il2CppMethodInfo)+C]");
		object obj318 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1332 @ S4_v303+60]");
		object obj319 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1333 @ S4_v304+48]");
		object obj320 = 0;
		object obj321 = obj320 & 0x7FF;
		object obj322 = obj321 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1341 @ S5_v238 (should have been resolved before IL gen)");
		nint num68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ S4_v307 (Il2CppMethodInfo)+C]");
		object obj323 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ S4_v308+60]");
		object obj324 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ S4_v309+48]");
		object obj325 = 0;
		object obj326 = obj325 & 0x7FF;
		object obj327 = obj326 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1362 @ S5_v242 (should have been resolved before IL gen)");
		nint num69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ S4_v312 (Il2CppMethodInfo)+C]");
		object obj328 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1374 @ S4_v313+60]");
		object obj329 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1375 @ S4_v314+48]");
		object obj330 = 0;
		object obj331 = obj330 & 0x7FF;
		object obj332 = obj331 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1383 @ S5_v246 (should have been resolved before IL gen)");
		nint num70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ S4_v317 (Il2CppMethodInfo)+C]");
		object obj333 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1395 @ S4_v318+60]");
		object obj334 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1396 @ S4_v319+48]");
		object obj335 = 0;
		object obj336 = obj335 & 0x7FF;
		object obj337 = obj336 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1404 @ S5_v250 (should have been resolved before IL gen)");
		nint num71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ S4_v322 (Il2CppMethodInfo)+C]");
		object obj338 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1416 @ S4_v323+60]");
		object obj339 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1417 @ S4_v324+48]");
		object obj340 = 0;
		object obj341 = obj340 & 0x7FF;
		object obj342 = obj341 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1425 @ S5_v254 (should have been resolved before IL gen)");
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ S4_v327 (Il2CppMethodInfo)+C]");
		object obj343 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1437 @ S4_v328+60]");
		object obj344 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ S4_v329+48]");
		object obj345 = 0;
		object obj346 = obj345 & 0x7FF;
		object obj347 = obj346 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1446 @ S5_v258 (should have been resolved before IL gen)");
		nint num73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1457 @ S4_v332 (Il2CppMethodInfo)+C]");
		object obj348 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1458 @ S4_v333+60]");
		object obj349 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1459 @ S4_v334+48]");
		object obj350 = 0;
		object obj351 = obj350 & 0x7FF;
		object obj352 = obj351 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1467 @ S5_v262 (should have been resolved before IL gen)");
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ S4_v337 (Il2CppMethodInfo)+C]");
		object obj353 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1479 @ S4_v338+60]");
		object obj354 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1480 @ S4_v339+48]");
		object obj355 = 0;
		object obj356 = obj355 & 0x7FF;
		object obj357 = obj356 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1488 @ S5_v266 (should have been resolved before IL gen)");
		object obj358 = this + 24;
		object obj359 = default;
		obj358 = obj359;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ S3_v91 (Il2CppMethodInfo)+C]");
		object obj360 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1502 @ S3_v92+60]");
		object obj361 = 0;
		object obj362 = obj361;
		object obj363 = obj362 & 0x1FFF;
		object obj364 = obj363 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1511 @ S4_v344 (should have been resolved before IL gen)");
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1522 @ S4_v346 (Il2CppMethodInfo)+C]");
		object obj365 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1523 @ S4_v347+60]");
		object obj366 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1524 @ S4_v348+48]");
		object obj367 = 0;
		object obj368 = obj367 & 0x7FF;
		object obj369 = obj368 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1532 @ S5_v272 (should have been resolved before IL gen)");
		nint num77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1543 @ S4_v351 (Il2CppMethodInfo)+C]");
		object obj370 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ S4_v352+60]");
		object obj371 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1545 @ S4_v353+48]");
		object obj372 = 0;
		object obj373 = obj372 & 0x7FF;
		object obj374 = obj373 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1553 @ S5_v276 (should have been resolved before IL gen)");
		nint num78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1564 @ S4_v356 (Il2CppMethodInfo)+C]");
		object obj375 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1565 @ S4_v357+60]");
		object obj376 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1566 @ S4_v358+48]");
		object obj377 = 0;
		object obj378 = obj377 & 0x7FF;
		object obj379 = obj378 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1574 @ S5_v280 (should have been resolved before IL gen)");
		nint num79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1585 @ S4_v361 (Il2CppMethodInfo)+C]");
		object obj380 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1586 @ S4_v362+60]");
		object obj381 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1587 @ S4_v363+48]");
		object obj382 = 0;
		object obj383 = obj382 & 0x7FF;
		object obj384 = obj383 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1595 @ S5_v284 (should have been resolved before IL gen)");
		nint num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ S4_v366 (Il2CppMethodInfo)+C]");
		object obj385 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1607 @ S4_v367+60]");
		object obj386 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1608 @ S4_v368+48]");
		object obj387 = 0;
		object obj388 = obj387 & 0x7FF;
		object obj389 = obj388 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1616 @ S5_v288 (should have been resolved before IL gen)");
		nint num81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1627 @ S4_v371 (Il2CppMethodInfo)+C]");
		object obj390 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1628 @ S4_v372+60]");
		object obj391 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1629 @ S4_v373+48]");
		object obj392 = 0;
		object obj393 = obj392 & 0x7FF;
		object obj394 = obj393 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1637 @ S5_v292 (should have been resolved before IL gen)");
		nint num82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ S4_v376 (Il2CppMethodInfo)+C]");
		object obj395 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1649 @ S4_v377+60]");
		object obj396 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ S4_v378+48]");
		object obj397 = 0;
		object obj398 = obj397 & 0x7FF;
		object obj399 = obj398 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1658 @ S5_v296 (should have been resolved before IL gen)");
		nint num83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1669 @ S4_v381 (Il2CppMethodInfo)+C]");
		object obj400 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1670 @ S4_v382+60]");
		object obj401 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1671 @ S4_v383+48]");
		object obj402 = 0;
		object obj403 = obj402 & 0x7FF;
		object obj404 = obj403 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1679 @ S5_v300 (should have been resolved before IL gen)");
		nint num84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1690 @ S4_v386 (Il2CppMethodInfo)+C]");
		object obj405 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1691 @ S4_v387+60]");
		object obj406 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1692 @ S4_v388+48]");
		object obj407 = 0;
		object obj408 = obj407 & 0x7FF;
		object obj409 = obj408 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1700 @ S5_v304 (should have been resolved before IL gen)");
		nint num85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ S4_v391 (Il2CppMethodInfo)+C]");
		object obj410 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1712 @ S4_v392+60]");
		object obj411 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1713 @ S4_v393+48]");
		object obj412 = 0;
		object obj413 = obj412 & 0x7FF;
		object obj414 = obj413 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1721 @ S5_v308 (should have been resolved before IL gen)");
		nint num86 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1725 @ S1_v318 (Il2CppClass<AdLocations>)+5C]");
		object obj415 = -(-64);
		nint num87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1734 @ S4_v396 (Il2CppMethodInfo)+C]");
		object obj416 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1735 @ S4_v397+60]");
		object obj417 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1736 @ S4_v398+48]");
		object obj418 = 0;
		object obj419 = obj418 & 0x7FF;
		object obj420 = obj419 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1744 @ S5_v312 (should have been resolved before IL gen)");
		nint num88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1755 @ S4_v401 (Il2CppMethodInfo)+C]");
		object obj421 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1756 @ S4_v402+60]");
		object obj422 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1757 @ S4_v403+48]");
		object obj423 = 0;
		object obj424 = obj423 & 0x7FF;
		object obj425 = obj424 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1765 @ S5_v316 (should have been resolved before IL gen)");
		nint num89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1776 @ S4_v406 (Il2CppMethodInfo)+C]");
		object obj426 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1777 @ S4_v407+60]");
		object obj427 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1778 @ S4_v408+48]");
		object obj428 = 0;
		object obj429 = obj428 & 0x7FF;
		object obj430 = obj429 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1786 @ S5_v320 (should have been resolved before IL gen)");
		nint num90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1797 @ S4_v411 (Il2CppMethodInfo)+C]");
		object obj431 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1798 @ S4_v412+60]");
		object obj432 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1799 @ S4_v413+48]");
		object obj433 = 0;
		object obj434 = obj433 & 0x7FF;
		object obj435 = obj434 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1807 @ S5_v324 (should have been resolved before IL gen)");
		nint num91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1818 @ S4_v416 (Il2CppMethodInfo)+C]");
		object obj436 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1819 @ S4_v417+60]");
		object obj437 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ S4_v418+48]");
		object obj438 = 0;
		object obj439 = obj438 & 0x7FF;
		object obj440 = obj439 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1828 @ S5_v328 (should have been resolved before IL gen)");
		nint num92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ S4_v421 (Il2CppMethodInfo)+C]");
		object obj441 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1840 @ S4_v422+60]");
		object obj442 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1841 @ S4_v423+48]");
		object obj443 = 0;
		object obj444 = obj443 & 0x7FF;
		object obj445 = obj444 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1849 @ S5_v332 (should have been resolved before IL gen)");
		nint num93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1860 @ S4_v426 (Il2CppMethodInfo)+C]");
		object obj446 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1861 @ S4_v427+60]");
		object obj447 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1862 @ S4_v428+48]");
		object obj448 = 0;
		object obj449 = obj448 & 0x7FF;
		object obj450 = obj449 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1870 @ S5_v336 (should have been resolved before IL gen)");
		nint num94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1881 @ S4_v431 (Il2CppMethodInfo)+C]");
		object obj451 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ S4_v432+60]");
		object obj452 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1883 @ S4_v433+48]");
		object obj453 = 0;
		object obj454 = obj453 & 0x7FF;
		object obj455 = obj454 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1891 @ S5_v340 (should have been resolved before IL gen)");
		nint num95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1902 @ S4_v436 (Il2CppMethodInfo)+C]");
		object obj456 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1903 @ S4_v437+60]");
		object obj457 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1904 @ S4_v438+48]");
		object obj458 = 0;
		object obj459 = obj458 & 0x7FF;
		object obj460 = obj459 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1912 @ S5_v344 (should have been resolved before IL gen)");
		nint num96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1923 @ S4_v441 (Il2CppMethodInfo)+C]");
		object obj461 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1924 @ S4_v442+60]");
		object obj462 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1925 @ S4_v443+48]");
		object obj463 = 0;
		object obj464 = obj463 & 0x7FF;
		object obj465 = obj464 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1933 @ S5_v348 (should have been resolved before IL gen)");
		object obj466 = this + 28;
		object obj467 = default;
		obj466 = obj467;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1946 @ S3_v116 (Il2CppMethodInfo)+C]");
		object obj468 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1947 @ S3_v117+60]");
		object obj469 = 0;
		object obj470 = obj469;
		object obj471 = obj470 & 0x1FFF;
		object obj472 = obj471 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1956 @ S4_v448 (should have been resolved before IL gen)");
		nint num98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1967 @ S4_v450 (Il2CppMethodInfo)+C]");
		object obj473 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1968 @ S4_v451+60]");
		object obj474 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1969 @ S4_v452+48]");
		object obj475 = 0;
		object obj476 = obj475 & 0x7FF;
		object obj477 = obj476 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1977 @ S5_v354 (should have been resolved before IL gen)");
		nint num99 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1988 @ S4_v455 (Il2CppMethodInfo)+C]");
		object obj478 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1989 @ S4_v456+60]");
		object obj479 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1990 @ S4_v457+48]");
		object obj480 = 0;
		object obj481 = obj480 & 0x7FF;
		object obj482 = obj481 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1998 @ S5_v358 (should have been resolved before IL gen)");
		nint num100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2009 @ S4_v460 (Il2CppMethodInfo)+C]");
		object obj483 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2010 @ S4_v461+60]");
		object obj484 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2011 @ S4_v462+48]");
		object obj485 = 0;
		object obj486 = obj485 & 0x7FF;
		object obj487 = obj486 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2019 @ S5_v362 (should have been resolved before IL gen)");
		nint num101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2030 @ S4_v465 (Il2CppMethodInfo)+C]");
		object obj488 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2031 @ S4_v466+60]");
		object obj489 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2032 @ S4_v467+48]");
		object obj490 = 0;
		object obj491 = obj490 & 0x7FF;
		object obj492 = obj491 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2040 @ S5_v366 (should have been resolved before IL gen)");
		nint num102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2051 @ S4_v470 (Il2CppMethodInfo)+C]");
		object obj493 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2052 @ S4_v471+60]");
		object obj494 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2053 @ S4_v472+48]");
		object obj495 = 0;
		object obj496 = obj495 & 0x7FF;
		object obj497 = obj496 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2061 @ S5_v370 (should have been resolved before IL gen)");
		nint num103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2072 @ S4_v475 (Il2CppMethodInfo)+C]");
		object obj498 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2073 @ S4_v476+60]");
		object obj499 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2074 @ S4_v477+48]");
		object obj500 = 0;
		object obj501 = obj500 & 0x7FF;
		object obj502 = obj501 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2082 @ S5_v374 (should have been resolved before IL gen)");
		nint num104 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2093 @ S4_v480 (Il2CppMethodInfo)+C]");
		object obj503 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2094 @ S4_v481+60]");
		object obj504 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2095 @ S4_v482+48]");
		object obj505 = 0;
		object obj506 = obj505 & 0x7FF;
		object obj507 = obj506 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2103 @ S5_v378 (should have been resolved before IL gen)");
		nint num105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2114 @ S4_v485 (Il2CppMethodInfo)+C]");
		object obj508 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2115 @ S4_v486+60]");
		object obj509 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2116 @ S4_v487+48]");
		object obj510 = 0;
		object obj511 = obj510 & 0x7FF;
		object obj512 = obj511 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2124 @ S5_v382 (should have been resolved before IL gen)");
		nint num106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2135 @ S4_v490 (Il2CppMethodInfo)+C]");
		object obj513 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2136 @ S4_v491+60]");
		object obj514 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2137 @ S4_v492+48]");
		object obj515 = 0;
		object obj516 = obj515 & 0x7FF;
		object obj517 = obj516 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2145 @ S5_v386 (should have been resolved before IL gen)");
		nint num107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2156 @ S4_v495 (Il2CppMethodInfo)+C]");
		object obj518 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2157 @ S4_v496+60]");
		object obj519 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2158 @ S4_v497+48]");
		object obj520 = 0;
		object obj521 = obj520 & 0x7FF;
		object obj522 = obj521 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2166 @ S5_v390 (should have been resolved before IL gen)");
		nint num108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2177 @ S4_v500 (Il2CppMethodInfo)+C]");
		object obj523 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2178 @ S4_v501+60]");
		object obj524 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2179 @ S4_v502+48]");
		object obj525 = 0;
		object obj526 = obj525 & 0x7FF;
		object obj527 = obj526 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2187 @ S5_v394 (should have been resolved before IL gen)");
		nint num109 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ S4_v505 (Il2CppMethodInfo)+C]");
		object obj528 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2199 @ S4_v506+60]");
		object obj529 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2200 @ S4_v507+48]");
		object obj530 = 0;
		object obj531 = obj530 & 0x7FF;
		object obj532 = obj531 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2208 @ S5_v398 (should have been resolved before IL gen)");
		nint num110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2219 @ S4_v510 (Il2CppMethodInfo)+C]");
		object obj533 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2220 @ S4_v511+60]");
		object obj534 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2221 @ S4_v512+48]");
		object obj535 = 0;
		object obj536 = obj535 & 0x7FF;
		object obj537 = obj536 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2229 @ S5_v402 (should have been resolved before IL gen)");
		nint num111 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2233 @ S1_v414 (Il2CppClass<AdLocations>)+5C]");
		object obj538 = -(-64);
		nint num112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2242 @ S4_v515 (Il2CppMethodInfo)+C]");
		object obj539 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2243 @ S4_v516+60]");
		object obj540 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2244 @ S4_v517+48]");
		object obj541 = 0;
		object obj542 = obj541 & 0x7FF;
		object obj543 = obj542 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2252 @ S5_v406 (should have been resolved before IL gen)");
		nint num113 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2263 @ S4_v520 (Il2CppMethodInfo)+C]");
		object obj544 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2264 @ S4_v521+60]");
		object obj545 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2265 @ S4_v522+48]");
		object obj546 = 0;
		object obj547 = obj546 & 0x7FF;
		object obj548 = obj547 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2273 @ S5_v410 (should have been resolved before IL gen)");
		nint num114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2284 @ S4_v525 (Il2CppMethodInfo)+C]");
		object obj549 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2285 @ S4_v526+60]");
		object obj550 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2286 @ S4_v527+48]");
		object obj551 = 0;
		object obj552 = obj551 & 0x7FF;
		object obj553 = obj552 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2294 @ S5_v414 (should have been resolved before IL gen)");
		nint num115 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ S4_v530 (Il2CppMethodInfo)+C]");
		object obj554 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2306 @ S4_v531+60]");
		object obj555 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2307 @ S4_v532+48]");
		object obj556 = 0;
		object obj557 = obj556 & 0x7FF;
		object obj558 = obj557 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2315 @ S5_v418 (should have been resolved before IL gen)");
		nint num116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2326 @ S4_v535 (Il2CppMethodInfo)+C]");
		object obj559 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2327 @ S4_v536+60]");
		object obj560 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2328 @ S4_v537+48]");
		object obj561 = 0;
		object obj562 = obj561 & 0x7FF;
		object obj563 = obj562 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2336 @ S5_v422 (should have been resolved before IL gen)");
		nint num117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ S4_v540 (Il2CppMethodInfo)+C]");
		object obj564 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2348 @ S4_v541+60]");
		object obj565 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2349 @ S4_v542+48]");
		object obj566 = 0;
		object obj567 = obj566 & 0x7FF;
		object obj568 = obj567 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2357 @ S5_v426 (should have been resolved before IL gen)");
		nint num118 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2368 @ S4_v545 (Il2CppMethodInfo)+C]");
		object obj569 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2369 @ S4_v546+60]");
		object obj570 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2370 @ S4_v547+48]");
		object obj571 = 0;
		object obj572 = obj571 & 0x7FF;
		object obj573 = obj572 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2378 @ S5_v430 (should have been resolved before IL gen)");
		nint num119 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2389 @ S4_v550 (Il2CppMethodInfo)+C]");
		object obj574 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2390 @ S4_v551+60]");
		object obj575 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2391 @ S4_v552+48]");
		object obj576 = 0;
		object obj577 = obj576 & 0x7FF;
		object obj578 = obj577 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2399 @ S5_v434 (should have been resolved before IL gen)");
		nint num120 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2410 @ S4_v555 (Il2CppMethodInfo)+C]");
		object obj579 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2411 @ S4_v556+60]");
		object obj580 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2412 @ S4_v557+48]");
		object obj581 = 0;
		object obj582 = obj581 & 0x7FF;
		object obj583 = obj582 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2420 @ S5_v438 (should have been resolved before IL gen)");
		object obj584 = this + 32;
		object obj585 = default;
		obj584 = obj585;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2433 @ S3_v143 (Il2CppMethodInfo)+C]");
		object obj586 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2434 @ S3_v144+60]");
		object obj587 = 0;
		object obj588 = obj587;
		object obj589 = obj588 & 0x1FFF;
		object obj590 = obj589 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2443 @ S4_v562 (should have been resolved before IL gen)");
		object obj591 = this + 36;
		object obj592 = default;
		obj591 = obj592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num122 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2456 @ S3_v148 (Il2CppMethodInfo)+C]");
		object obj593 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2457 @ S3_v149+60]");
		object obj594 = 0;
		object obj595 = obj594;
		object obj596 = obj595 & 0x1FFF;
		object obj597 = obj596 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2466 @ S4_v566 (should have been resolved before IL gen)");
		nint num123 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2477 @ S4_v568 (Il2CppMethodInfo)+C]");
		object obj598 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2478 @ S4_v569+60]");
		object obj599 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2479 @ S4_v570+48]");
		object obj600 = 0;
		object obj601 = obj600 & 0x7FF;
		object obj602 = obj601 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2487 @ S5_v446 (should have been resolved before IL gen)");
		nint num124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2498 @ S4_v573 (Il2CppMethodInfo)+C]");
		object obj603 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2499 @ S4_v574+60]");
		object obj604 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2500 @ S4_v575+48]");
		object obj605 = 0;
		object obj606 = obj605 & 0x7FF;
		object obj607 = obj606 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2508 @ S5_v450 (should have been resolved before IL gen)");
		nint num125 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2519 @ S4_v578 (Il2CppMethodInfo)+C]");
		object obj608 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2520 @ S4_v579+60]");
		object obj609 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2521 @ S4_v580+48]");
		object obj610 = 0;
		object obj611 = obj610 & 0x7FF;
		object obj612 = obj611 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2529 @ S5_v454 (should have been resolved before IL gen)");
		nint num126 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2540 @ S4_v583 (Il2CppMethodInfo)+C]");
		object obj613 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2541 @ S4_v584+60]");
		object obj614 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2542 @ S4_v585+48]");
		object obj615 = 0;
		object obj616 = obj615 & 0x7FF;
		object obj617 = obj616 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2550 @ S5_v458 (should have been resolved before IL gen)");
		nint num127 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2561 @ S4_v588 (Il2CppMethodInfo)+C]");
		object obj618 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2562 @ S4_v589+60]");
		object obj619 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2563 @ S4_v590+48]");
		object obj620 = 0;
		object obj621 = obj620 & 0x7FF;
		object obj622 = obj621 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2571 @ S5_v462 (should have been resolved before IL gen)");
		nint num128 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2582 @ S4_v593 (Il2CppMethodInfo)+C]");
		object obj623 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2583 @ S4_v594+60]");
		object obj624 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2584 @ S4_v595+48]");
		object obj625 = 0;
		object obj626 = obj625 & 0x7FF;
		object obj627 = obj626 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2592 @ S5_v466 (should have been resolved before IL gen)");
		nint num129 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2603 @ S4_v598 (Il2CppMethodInfo)+C]");
		object obj628 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2604 @ S4_v599+60]");
		object obj629 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2605 @ S4_v600+48]");
		object obj630 = 0;
		object obj631 = obj630 & 0x7FF;
		object obj632 = obj631 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2613 @ S5_v470 (should have been resolved before IL gen)");
		nint num130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2624 @ S4_v603 (Il2CppMethodInfo)+C]");
		object obj633 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2625 @ S4_v604+60]");
		object obj634 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2626 @ S4_v605+48]");
		object obj635 = 0;
		object obj636 = obj635 & 0x7FF;
		object obj637 = obj636 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2634 @ S5_v474 (should have been resolved before IL gen)");
		nint num131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2645 @ S4_v608 (Il2CppMethodInfo)+C]");
		object obj638 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2646 @ S4_v609+60]");
		object obj639 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2647 @ S4_v610+48]");
		object obj640 = 0;
		object obj641 = obj640 & 0x7FF;
		object obj642 = obj641 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2655 @ S5_v478 (should have been resolved before IL gen)");
		nint num132 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2666 @ S4_v613 (Il2CppMethodInfo)+C]");
		object obj643 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2667 @ S4_v614+60]");
		object obj644 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2668 @ S4_v615+48]");
		object obj645 = 0;
		object obj646 = obj645 & 0x7FF;
		object obj647 = obj646 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2676 @ S5_v482 (should have been resolved before IL gen)");
		nint num133 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2680 @ S1_v497 (Il2CppClass<AdLocations>)+5C]");
		object obj648 = -(-64);
		nint num134 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2689 @ S4_v618 (Il2CppMethodInfo)+C]");
		object obj649 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2690 @ S4_v619+60]");
		object obj650 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2691 @ S4_v620+48]");
		object obj651 = 0;
		object obj652 = obj651 & 0x7FF;
		object obj653 = obj652 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2699 @ S5_v486 (should have been resolved before IL gen)");
		nint num135 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2710 @ S4_v623 (Il2CppMethodInfo)+C]");
		object obj654 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2711 @ S4_v624+60]");
		object obj655 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2712 @ S4_v625+48]");
		object obj656 = 0;
		object obj657 = obj656 & 0x7FF;
		object obj658 = obj657 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2720 @ S5_v490 (should have been resolved before IL gen)");
		nint num136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2731 @ S4_v628 (Il2CppMethodInfo)+C]");
		object obj659 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2732 @ S4_v629+60]");
		object obj660 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2733 @ S4_v630+48]");
		object obj661 = 0;
		object obj662 = obj661 & 0x7FF;
		object obj663 = obj662 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2741 @ S5_v494 (should have been resolved before IL gen)");
		nint num137 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2752 @ S4_v633 (Il2CppMethodInfo)+C]");
		object obj664 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2753 @ S4_v634+60]");
		object obj665 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2754 @ S4_v635+48]");
		object obj666 = 0;
		object obj667 = obj666 & 0x7FF;
		object obj668 = obj667 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2762 @ S5_v498 (should have been resolved before IL gen)");
		nint num138 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2773 @ S4_v638 (Il2CppMethodInfo)+C]");
		object obj669 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2774 @ S4_v639+60]");
		object obj670 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2775 @ S4_v640+48]");
		object obj671 = 0;
		object obj672 = obj671 & 0x7FF;
		object obj673 = obj672 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2783 @ S5_v502 (should have been resolved before IL gen)");
		nint num139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2794 @ S4_v643 (Il2CppMethodInfo)+C]");
		object obj674 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2795 @ S4_v644+60]");
		object obj675 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2796 @ S4_v645+48]");
		object obj676 = 0;
		object obj677 = obj676 & 0x7FF;
		object obj678 = obj677 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2804 @ S5_v506 (should have been resolved before IL gen)");
		nint num140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2815 @ S4_v648 (Il2CppMethodInfo)+C]");
		object obj679 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2816 @ S4_v649+60]");
		object obj680 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2817 @ S4_v650+48]");
		object obj681 = 0;
		object obj682 = obj681 & 0x7FF;
		object obj683 = obj682 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2825 @ S5_v510 (should have been resolved before IL gen)");
		nint num141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2836 @ S4_v653 (Il2CppMethodInfo)+C]");
		object obj684 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2837 @ S4_v654+60]");
		object obj685 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2838 @ S4_v655+48]");
		object obj686 = 0;
		object obj687 = obj686 & 0x7FF;
		object obj688 = obj687 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2846 @ S5_v514 (should have been resolved before IL gen)");
		nint num142 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2857 @ S4_v658 (Il2CppMethodInfo)+C]");
		object obj689 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2858 @ S4_v659+60]");
		object obj690 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2859 @ S4_v660+48]");
		object obj691 = 0;
		object obj692 = obj691 & 0x7FF;
		object obj693 = obj692 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2867 @ S5_v518 (should have been resolved before IL gen)");
		nint num143 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2878 @ S4_v663 (Il2CppMethodInfo)+C]");
		object obj694 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2879 @ S4_v664+60]");
		object obj695 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2880 @ S4_v665+48]");
		object obj696 = 0;
		object obj697 = obj696 & 0x7FF;
		object obj698 = obj697 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2888 @ S5_v522 (should have been resolved before IL gen)");
		object obj699 = this + 40;
		object obj700 = default;
		obj699 = obj700;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num144 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2901 @ S3_v173 (Il2CppMethodInfo)+C]");
		object obj701 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2902 @ S3_v174+60]");
		object obj702 = 0;
		object obj703 = obj702;
		object obj704 = obj703 & 0x1FFF;
		object obj705 = obj704 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2911 @ S4_v670 (should have been resolved before IL gen)");
		object obj706 = this + 44;
		object obj707 = default;
		obj706 = obj707;
	}
}
