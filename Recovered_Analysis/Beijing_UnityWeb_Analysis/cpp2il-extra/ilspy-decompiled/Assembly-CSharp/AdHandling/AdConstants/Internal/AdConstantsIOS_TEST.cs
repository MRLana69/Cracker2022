using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

namespace AdHandling.AdConstants.Internal;

public class AdConstantsIOS_TEST : IAdConstants
{
	private readonly Dictionary<AdLocationInfo, string> _flurryAdCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _adColonyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _tapjoyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _chartboostCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _inmobiCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _vungleCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _supersonicCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _facebookCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _mobvistaCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _yeahMobiCacheIDs;

	public bool isRestricted
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_yeahMobiCacheIDs != 0;
		}
	}

	public Dictionary<AdLocationInfo, string> FlurryAdCacheIDs => null;

	public string AdColonyAppId => (string)(object)_flurryAdCacheIDs;

	public Dictionary<AdLocationInfo, string> AdColonyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"appe16ddc2239b94013abd6b2";

	public string TapJoyAppId => (string)(object)_adColonyCacheIDs;

	public string TapJoyAppKey => "feb4000a-c9ee-4388-941f-e0391e462ec5";

	public Dictionary<AdLocationInfo, string> TapJoyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"_rQACsnuQ4iUH-A5HkYuxQEBElEQtlcZKs1W2D9sa6g1grIoAafYJ9EJffsN";

	public string ChartboostAppId => (string)(object)_tapjoyCacheIDs;

	public string ChartboostAppSignature => "5024e3582284bb9a5a00003d";

	public Dictionary<AdLocationInfo, string> ChartboostCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"73a9d4bbe6eee00ee592f4aa73604c78fddd717e";

	public string InmobiAccountId => (string)(object)_chartboostCacheIDs;

	public Dictionary<AdLocationInfo, string> InmobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"65f49e71333d405686b652d839b89af9";

	public string VungleAppId => (string)(object)_inmobiCacheIDs;

	public Dictionary<AdLocationInfo, string> VungleCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"586f90feee0dcc35280004c3";

	public string SupersonicAppId => (string)(object)_vungleCacheIDs;

	public Dictionary<AdLocationInfo, string> SupersonicCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"4cbeec05";

	public Dictionary<AdLocationInfo, string> FacebookCacheIDs => _supersonicCacheIDs;

	public Dictionary<AdLocationInfo, string> MobVistaCacheIDs => _facebookCacheIDs;

	public string MobVistaAppId => (string)(object)_mobvistaCacheIDs;

	public string MobVistaAppSdkKey => "92763";

	public Dictionary<AdLocationInfo, string> YeahMobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"936dcbdd57fe235fd7cf61c2e93da3c4";

	public AdConstantsIOS_TEST()
	{
		//IL_37ef: Expected Obj, but got I
		//IL_37ff: Expected Obj, but got I
		//IL_3810: Unknown result type (might be due to invalid IL or missing references)
		//IL_3815: Expected Obj, but got Unknown
		//IL_381e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3823: Expected Obj, but got Unknown
		//IL_383b: Expected I, but got Obj
		//IL_3851: Expected Obj, but got I
		//IL_3884: Expected Obj, but got I
		//IL_3894: Expected Obj, but got I
		//IL_38a4: Expected Obj, but got I
		//IL_38ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b2: Expected Obj, but got Unknown
		//IL_38bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_38c0: Expected Obj, but got Unknown
		//IL_38e0: Expected Obj, but got I
		//IL_38f0: Expected Obj, but got I
		//IL_3900: Expected Obj, but got I
		//IL_3909: Unknown result type (might be due to invalid IL or missing references)
		//IL_390e: Expected Obj, but got Unknown
		//IL_3917: Unknown result type (might be due to invalid IL or missing references)
		//IL_391c: Expected Obj, but got Unknown
		//IL_393c: Expected Obj, but got I
		//IL_394c: Expected Obj, but got I
		//IL_395c: Expected Obj, but got I
		//IL_3965: Unknown result type (might be due to invalid IL or missing references)
		//IL_396a: Expected Obj, but got Unknown
		//IL_3973: Unknown result type (might be due to invalid IL or missing references)
		//IL_3978: Expected Obj, but got Unknown
		//IL_3998: Expected Obj, but got I
		//IL_39a8: Expected Obj, but got I
		//IL_39b8: Expected Obj, but got I
		//IL_39c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_39c6: Expected Obj, but got Unknown
		//IL_39cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d4: Expected Obj, but got Unknown
		//IL_39f4: Expected Obj, but got I
		//IL_3a04: Expected Obj, but got I
		//IL_3a14: Expected Obj, but got I
		//IL_3a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a22: Expected Obj, but got Unknown
		//IL_3a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a30: Expected Obj, but got Unknown
		//IL_3a50: Expected Obj, but got I
		//IL_3a60: Expected Obj, but got I
		//IL_3a70: Expected Obj, but got I
		//IL_3a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a7e: Expected Obj, but got Unknown
		//IL_3a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a8c: Expected Obj, but got Unknown
		//IL_3aac: Expected Obj, but got I
		//IL_3abc: Expected Obj, but got I
		//IL_3acc: Expected Obj, but got I
		//IL_3ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ada: Expected Obj, but got Unknown
		//IL_3ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ae8: Expected Obj, but got Unknown
		//IL_3b08: Expected Obj, but got I
		//IL_3b18: Expected Obj, but got I
		//IL_3b28: Expected Obj, but got I
		//IL_3b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b36: Expected Obj, but got Unknown
		//IL_3b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b44: Expected Obj, but got Unknown
		//IL_3b64: Expected Obj, but got I
		//IL_3b74: Expected Obj, but got I
		//IL_3b84: Expected Obj, but got I
		//IL_3b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b92: Expected Obj, but got Unknown
		//IL_3b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba0: Expected Obj, but got Unknown
		//IL_3bc0: Expected Obj, but got I
		//IL_3bd0: Expected Obj, but got I
		//IL_3be0: Expected Obj, but got I
		//IL_3be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bee: Expected Obj, but got Unknown
		//IL_3bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bfc: Expected Obj, but got Unknown
		//IL_3c1c: Expected Obj, but got I
		//IL_3c2c: Expected Obj, but got I
		//IL_3c3c: Expected Obj, but got I
		//IL_3c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c4a: Expected Obj, but got Unknown
		//IL_3c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c58: Expected Obj, but got Unknown
		//IL_3c70: Expected I, but got Obj
		//IL_3c86: Expected Obj, but got I
		//IL_3c9c: Expected Obj, but got I
		//IL_3cac: Expected Obj, but got I
		//IL_3cbc: Expected Obj, but got I
		//IL_3cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cca: Expected Obj, but got Unknown
		//IL_3cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd8: Expected Obj, but got Unknown
		//IL_3cf8: Expected Obj, but got I
		//IL_3d08: Expected Obj, but got I
		//IL_3d18: Expected Obj, but got I
		//IL_3d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d26: Expected Obj, but got Unknown
		//IL_3d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d34: Expected Obj, but got Unknown
		//IL_3d54: Expected Obj, but got I
		//IL_3d64: Expected Obj, but got I
		//IL_3d74: Expected Obj, but got I
		//IL_3d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d82: Expected Obj, but got Unknown
		//IL_3d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d90: Expected Obj, but got Unknown
		//IL_3db0: Expected Obj, but got I
		//IL_3dc0: Expected Obj, but got I
		//IL_3dd0: Expected Obj, but got I
		//IL_3dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dde: Expected Obj, but got Unknown
		//IL_3de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dec: Expected Obj, but got Unknown
		//IL_3e0c: Expected Obj, but got I
		//IL_3e1c: Expected Obj, but got I
		//IL_3e2c: Expected Obj, but got I
		//IL_3e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3a: Expected Obj, but got Unknown
		//IL_3e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e48: Expected Obj, but got Unknown
		//IL_3e68: Expected Obj, but got I
		//IL_3e78: Expected Obj, but got I
		//IL_3e88: Expected Obj, but got I
		//IL_3e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e96: Expected Obj, but got Unknown
		//IL_3e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ea4: Expected Obj, but got Unknown
		//IL_3ec4: Expected Obj, but got I
		//IL_3ed4: Expected Obj, but got I
		//IL_3ee4: Expected Obj, but got I
		//IL_3eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ef2: Expected Obj, but got Unknown
		//IL_3efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f00: Expected Obj, but got Unknown
		//IL_3f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f15: Expected Obj, but got Unknown
		//IL_3f3d: Expected Obj, but got I
		//IL_3f4d: Expected Obj, but got I
		//IL_3f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f63: Expected Obj, but got Unknown
		//IL_3f6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f71: Expected Obj, but got Unknown
		//IL_3f91: Expected Obj, but got I
		//IL_3fa1: Expected Obj, but got I
		//IL_3fb1: Expected Obj, but got I
		//IL_3fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fbf: Expected Obj, but got Unknown
		//IL_3fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fcd: Expected Obj, but got Unknown
		//IL_3fed: Expected Obj, but got I
		//IL_3ffd: Expected Obj, but got I
		//IL_400d: Expected Obj, but got I
		//IL_4016: Unknown result type (might be due to invalid IL or missing references)
		//IL_401b: Expected Obj, but got Unknown
		//IL_4024: Unknown result type (might be due to invalid IL or missing references)
		//IL_4029: Expected Obj, but got Unknown
		//IL_4049: Expected Obj, but got I
		//IL_4059: Expected Obj, but got I
		//IL_4069: Expected Obj, but got I
		//IL_4072: Unknown result type (might be due to invalid IL or missing references)
		//IL_4077: Expected Obj, but got Unknown
		//IL_4080: Unknown result type (might be due to invalid IL or missing references)
		//IL_4085: Expected Obj, but got Unknown
		//IL_40a5: Expected Obj, but got I
		//IL_40b5: Expected Obj, but got I
		//IL_40c5: Expected Obj, but got I
		//IL_40ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_40d3: Expected Obj, but got Unknown
		//IL_40dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_40e1: Expected Obj, but got Unknown
		//IL_4101: Expected Obj, but got I
		//IL_4111: Expected Obj, but got I
		//IL_4121: Expected Obj, but got I
		//IL_412a: Unknown result type (might be due to invalid IL or missing references)
		//IL_412f: Expected Obj, but got Unknown
		//IL_4138: Unknown result type (might be due to invalid IL or missing references)
		//IL_413d: Expected Obj, but got Unknown
		//IL_415d: Expected Obj, but got I
		//IL_416d: Expected Obj, but got I
		//IL_417d: Expected Obj, but got I
		//IL_4186: Unknown result type (might be due to invalid IL or missing references)
		//IL_418b: Expected Obj, but got Unknown
		//IL_4194: Unknown result type (might be due to invalid IL or missing references)
		//IL_4199: Expected Obj, but got Unknown
		//IL_41b9: Expected Obj, but got I
		//IL_41c9: Expected Obj, but got I
		//IL_41d9: Expected Obj, but got I
		//IL_41e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_41e7: Expected Obj, but got Unknown
		//IL_41f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_41f5: Expected Obj, but got Unknown
		//IL_4215: Expected Obj, but got I
		//IL_4225: Expected Obj, but got I
		//IL_4235: Expected Obj, but got I
		//IL_423e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4243: Expected Obj, but got Unknown
		//IL_424c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4251: Expected Obj, but got Unknown
		//IL_4271: Expected Obj, but got I
		//IL_4281: Expected Obj, but got I
		//IL_4291: Expected Obj, but got I
		//IL_429a: Unknown result type (might be due to invalid IL or missing references)
		//IL_429f: Expected Obj, but got Unknown
		//IL_42a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_42ad: Expected Obj, but got Unknown
		//IL_42cd: Expected Obj, but got I
		//IL_42dd: Expected Obj, but got I
		//IL_42ed: Expected Obj, but got I
		//IL_42f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_42fb: Expected Obj, but got Unknown
		//IL_4304: Unknown result type (might be due to invalid IL or missing references)
		//IL_4309: Expected Obj, but got Unknown
		//IL_4329: Expected Obj, but got I
		//IL_4339: Expected Obj, but got I
		//IL_4349: Expected Obj, but got I
		//IL_4352: Unknown result type (might be due to invalid IL or missing references)
		//IL_4357: Expected Obj, but got Unknown
		//IL_4360: Unknown result type (might be due to invalid IL or missing references)
		//IL_4365: Expected Obj, but got Unknown
		//IL_437d: Expected I, but got Obj
		//IL_4393: Expected Obj, but got I
		//IL_43a9: Expected Obj, but got I
		//IL_43b9: Expected Obj, but got I
		//IL_43c9: Expected Obj, but got I
		//IL_43d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_43d7: Expected Obj, but got Unknown
		//IL_43e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_43e5: Expected Obj, but got Unknown
		//IL_4405: Expected Obj, but got I
		//IL_4415: Expected Obj, but got I
		//IL_4425: Expected Obj, but got I
		//IL_442e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4433: Expected Obj, but got Unknown
		//IL_443c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4441: Expected Obj, but got Unknown
		//IL_4461: Expected Obj, but got I
		//IL_4471: Expected Obj, but got I
		//IL_4481: Expected Obj, but got I
		//IL_448a: Unknown result type (might be due to invalid IL or missing references)
		//IL_448f: Expected Obj, but got Unknown
		//IL_4498: Unknown result type (might be due to invalid IL or missing references)
		//IL_449d: Expected Obj, but got Unknown
		//IL_44bd: Expected Obj, but got I
		//IL_44cd: Expected Obj, but got I
		//IL_44dd: Expected Obj, but got I
		//IL_44e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_44eb: Expected Obj, but got Unknown
		//IL_44f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_44f9: Expected Obj, but got Unknown
		//IL_4519: Expected Obj, but got I
		//IL_4529: Expected Obj, but got I
		//IL_4539: Expected Obj, but got I
		//IL_4542: Unknown result type (might be due to invalid IL or missing references)
		//IL_4547: Expected Obj, but got Unknown
		//IL_4550: Unknown result type (might be due to invalid IL or missing references)
		//IL_4555: Expected Obj, but got Unknown
		//IL_4575: Expected Obj, but got I
		//IL_4585: Expected Obj, but got I
		//IL_4595: Expected Obj, but got I
		//IL_459e: Unknown result type (might be due to invalid IL or missing references)
		//IL_45a3: Expected Obj, but got Unknown
		//IL_45ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_45b1: Expected Obj, but got Unknown
		//IL_45d1: Expected Obj, but got I
		//IL_45e1: Expected Obj, but got I
		//IL_45f1: Expected Obj, but got I
		//IL_45fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_45ff: Expected Obj, but got Unknown
		//IL_4608: Unknown result type (might be due to invalid IL or missing references)
		//IL_460d: Expected Obj, but got Unknown
		//IL_462d: Expected Obj, but got I
		//IL_463d: Expected Obj, but got I
		//IL_464d: Expected Obj, but got I
		//IL_4656: Unknown result type (might be due to invalid IL or missing references)
		//IL_465b: Expected Obj, but got Unknown
		//IL_4664: Unknown result type (might be due to invalid IL or missing references)
		//IL_4669: Expected Obj, but got Unknown
		//IL_4689: Expected Obj, but got I
		//IL_4699: Expected Obj, but got I
		//IL_46a9: Expected Obj, but got I
		//IL_46b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_46b7: Expected Obj, but got Unknown
		//IL_46c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_46c5: Expected Obj, but got Unknown
		//IL_46d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_46da: Expected Obj, but got Unknown
		//IL_4702: Expected Obj, but got I
		//IL_4712: Expected Obj, but got I
		//IL_4723: Unknown result type (might be due to invalid IL or missing references)
		//IL_4728: Expected Obj, but got Unknown
		//IL_4731: Unknown result type (might be due to invalid IL or missing references)
		//IL_4736: Expected Obj, but got Unknown
		//IL_4756: Expected Obj, but got I
		//IL_4766: Expected Obj, but got I
		//IL_4776: Expected Obj, but got I
		//IL_477f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4784: Expected Obj, but got Unknown
		//IL_478d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4792: Expected Obj, but got Unknown
		//IL_47b2: Expected Obj, but got I
		//IL_47c2: Expected Obj, but got I
		//IL_47d2: Expected Obj, but got I
		//IL_47db: Unknown result type (might be due to invalid IL or missing references)
		//IL_47e0: Expected Obj, but got Unknown
		//IL_47e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_47ee: Expected Obj, but got Unknown
		//IL_480e: Expected Obj, but got I
		//IL_481e: Expected Obj, but got I
		//IL_482e: Expected Obj, but got I
		//IL_4837: Unknown result type (might be due to invalid IL or missing references)
		//IL_483c: Expected Obj, but got Unknown
		//IL_4845: Unknown result type (might be due to invalid IL or missing references)
		//IL_484a: Expected Obj, but got Unknown
		//IL_486a: Expected Obj, but got I
		//IL_487a: Expected Obj, but got I
		//IL_488a: Expected Obj, but got I
		//IL_4893: Unknown result type (might be due to invalid IL or missing references)
		//IL_4898: Expected Obj, but got Unknown
		//IL_48a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_48a6: Expected Obj, but got Unknown
		//IL_48c6: Expected Obj, but got I
		//IL_48d6: Expected Obj, but got I
		//IL_48e6: Expected Obj, but got I
		//IL_48ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_48f4: Expected Obj, but got Unknown
		//IL_48fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4902: Expected Obj, but got Unknown
		//IL_4922: Expected Obj, but got I
		//IL_4932: Expected Obj, but got I
		//IL_4942: Expected Obj, but got I
		//IL_494b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4950: Expected Obj, but got Unknown
		//IL_4959: Unknown result type (might be due to invalid IL or missing references)
		//IL_495e: Expected Obj, but got Unknown
		//IL_497e: Expected Obj, but got I
		//IL_498e: Expected Obj, but got I
		//IL_499e: Expected Obj, but got I
		//IL_49a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_49ac: Expected Obj, but got Unknown
		//IL_49b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_49ba: Expected Obj, but got Unknown
		//IL_49da: Expected Obj, but got I
		//IL_49ea: Expected Obj, but got I
		//IL_49fa: Expected Obj, but got I
		//IL_4a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a08: Expected Obj, but got Unknown
		//IL_4a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a16: Expected Obj, but got Unknown
		//IL_4a36: Expected Obj, but got I
		//IL_4a46: Expected Obj, but got I
		//IL_4a56: Expected Obj, but got I
		//IL_4a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a64: Expected Obj, but got Unknown
		//IL_4a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a72: Expected Obj, but got Unknown
		//IL_4a92: Expected Obj, but got I
		//IL_4aa2: Expected Obj, but got I
		//IL_4ab2: Expected Obj, but got I
		//IL_4abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ac0: Expected Obj, but got Unknown
		//IL_4ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ace: Expected Obj, but got Unknown
		//IL_4aee: Expected Obj, but got I
		//IL_4afe: Expected Obj, but got I
		//IL_4b0e: Expected Obj, but got I
		//IL_4b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b1c: Expected Obj, but got Unknown
		//IL_4b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b2a: Expected Obj, but got Unknown
		//IL_4b42: Expected I, but got Obj
		//IL_4b58: Expected Obj, but got I
		//IL_4b6e: Expected Obj, but got I
		//IL_4b7e: Expected Obj, but got I
		//IL_4b8e: Expected Obj, but got I
		//IL_4b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b9c: Expected Obj, but got Unknown
		//IL_4ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4baa: Expected Obj, but got Unknown
		//IL_4bca: Expected Obj, but got I
		//IL_4bda: Expected Obj, but got I
		//IL_4bea: Expected Obj, but got I
		//IL_4bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bf8: Expected Obj, but got Unknown
		//IL_4c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c06: Expected Obj, but got Unknown
		//IL_4c26: Expected Obj, but got I
		//IL_4c36: Expected Obj, but got I
		//IL_4c46: Expected Obj, but got I
		//IL_4c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c54: Expected Obj, but got Unknown
		//IL_4c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c62: Expected Obj, but got Unknown
		//IL_4c82: Expected Obj, but got I
		//IL_4c92: Expected Obj, but got I
		//IL_4ca2: Expected Obj, but got I
		//IL_4cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cb0: Expected Obj, but got Unknown
		//IL_4cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cbe: Expected Obj, but got Unknown
		//IL_4cde: Expected Obj, but got I
		//IL_4cee: Expected Obj, but got I
		//IL_4cfe: Expected Obj, but got I
		//IL_4d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d0c: Expected Obj, but got Unknown
		//IL_4d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d1a: Expected Obj, but got Unknown
		//IL_4d3a: Expected Obj, but got I
		//IL_4d4a: Expected Obj, but got I
		//IL_4d5a: Expected Obj, but got I
		//IL_4d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d68: Expected Obj, but got Unknown
		//IL_4d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d76: Expected Obj, but got Unknown
		//IL_4d96: Expected Obj, but got I
		//IL_4da6: Expected Obj, but got I
		//IL_4db6: Expected Obj, but got I
		//IL_4dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dc4: Expected Obj, but got Unknown
		//IL_4dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4dd2: Expected Obj, but got Unknown
		//IL_4df2: Expected Obj, but got I
		//IL_4e02: Expected Obj, but got I
		//IL_4e12: Expected Obj, but got I
		//IL_4e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e20: Expected Obj, but got Unknown
		//IL_4e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e2e: Expected Obj, but got Unknown
		//IL_4e4e: Expected Obj, but got I
		//IL_4e5e: Expected Obj, but got I
		//IL_4e6e: Expected Obj, but got I
		//IL_4e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e7c: Expected Obj, but got Unknown
		//IL_4e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e8a: Expected Obj, but got Unknown
		//IL_4e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e9f: Expected Obj, but got Unknown
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
		//IL_0568: Expected Obj, but got I
		//IL_0578: Expected Obj, but got I
		//IL_0588: Expected Obj, but got I
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05bc: Expected I, but got Obj
		//IL_05d2: Expected Obj, but got I
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
		//IL_0cd1: Expected Obj, but got I
		//IL_0ce1: Expected Obj, but got I
		//IL_0cf1: Expected Obj, but got I
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected Obj, but got Unknown
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected Obj, but got Unknown
		//IL_0d2d: Expected Obj, but got I
		//IL_0d3d: Expected Obj, but got I
		//IL_0d4d: Expected Obj, but got I
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected Obj, but got Unknown
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d69: Expected Obj, but got Unknown
		//IL_0d89: Expected Obj, but got I
		//IL_0d99: Expected Obj, but got I
		//IL_0da9: Expected Obj, but got I
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db7: Expected Obj, but got Unknown
		//IL_0dc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc5: Expected Obj, but got Unknown
		//IL_0de5: Expected Obj, but got I
		//IL_0df5: Expected Obj, but got I
		//IL_0e05: Expected Obj, but got I
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected Obj, but got Unknown
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e21: Expected Obj, but got Unknown
		//IL_0e39: Expected I, but got Obj
		//IL_0e4f: Expected Obj, but got I
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
		//IL_1021: Unknown result type (might be due to invalid IL or missing references)
		//IL_1026: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_1053: Expected Obj, but got I
		//IL_1063: Expected Obj, but got I
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_1079: Expected Obj, but got Unknown
		//IL_1082: Unknown result type (might be due to invalid IL or missing references)
		//IL_1087: Expected Obj, but got Unknown
		//IL_10a7: Expected Obj, but got I
		//IL_10b7: Expected Obj, but got I
		//IL_10c7: Expected Obj, but got I
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
		//IL_1493: Expected I, but got Obj
		//IL_14a9: Expected Obj, but got I
		//IL_14bf: Expected Obj, but got I
		//IL_14cf: Expected Obj, but got I
		//IL_14df: Expected Obj, but got I
		//IL_14e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ed: Expected Obj, but got Unknown
		//IL_14f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fb: Expected Obj, but got Unknown
		//IL_151b: Expected Obj, but got I
		//IL_152b: Expected Obj, but got I
		//IL_153b: Expected Obj, but got I
		//IL_1544: Unknown result type (might be due to invalid IL or missing references)
		//IL_1549: Expected Obj, but got Unknown
		//IL_1552: Unknown result type (might be due to invalid IL or missing references)
		//IL_1557: Expected Obj, but got Unknown
		//IL_1577: Expected Obj, but got I
		//IL_1587: Expected Obj, but got I
		//IL_1597: Expected Obj, but got I
		//IL_15a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a5: Expected Obj, but got Unknown
		//IL_15ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b3: Expected Obj, but got Unknown
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
		//IL_17eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f0: Expected Obj, but got Unknown
		//IL_1818: Expected Obj, but got I
		//IL_1828: Expected Obj, but got I
		//IL_1839: Unknown result type (might be due to invalid IL or missing references)
		//IL_183e: Expected Obj, but got Unknown
		//IL_1847: Unknown result type (might be due to invalid IL or missing references)
		//IL_184c: Expected Obj, but got Unknown
		//IL_186c: Expected Obj, but got I
		//IL_187c: Expected Obj, but got I
		//IL_188c: Expected Obj, but got I
		//IL_1895: Unknown result type (might be due to invalid IL or missing references)
		//IL_189a: Expected Obj, but got Unknown
		//IL_18a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a8: Expected Obj, but got Unknown
		//IL_18c8: Expected Obj, but got I
		//IL_18d8: Expected Obj, but got I
		//IL_18e8: Expected Obj, but got I
		//IL_18f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f6: Expected Obj, but got Unknown
		//IL_18ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1904: Expected Obj, but got Unknown
		//IL_1924: Expected Obj, but got I
		//IL_1934: Expected Obj, but got I
		//IL_1944: Expected Obj, but got I
		//IL_194d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1952: Expected Obj, but got Unknown
		//IL_195b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1960: Expected Obj, but got Unknown
		//IL_1980: Expected Obj, but got I
		//IL_1990: Expected Obj, but got I
		//IL_19a0: Expected Obj, but got I
		//IL_19a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ae: Expected Obj, but got Unknown
		//IL_19b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bc: Expected Obj, but got Unknown
		//IL_19dc: Expected Obj, but got I
		//IL_19ec: Expected Obj, but got I
		//IL_19fc: Expected Obj, but got I
		//IL_1a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0a: Expected Obj, but got Unknown
		//IL_1a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a18: Expected Obj, but got Unknown
		//IL_1a38: Expected Obj, but got I
		//IL_1a48: Expected Obj, but got I
		//IL_1a58: Expected Obj, but got I
		//IL_1a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a66: Expected Obj, but got Unknown
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a74: Expected Obj, but got Unknown
		//IL_1a94: Expected Obj, but got I
		//IL_1aa4: Expected Obj, but got I
		//IL_1ab4: Expected Obj, but got I
		//IL_1abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac2: Expected Obj, but got Unknown
		//IL_1acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad0: Expected Obj, but got Unknown
		//IL_1af0: Expected Obj, but got I
		//IL_1b00: Expected Obj, but got I
		//IL_1b10: Expected Obj, but got I
		//IL_1b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1e: Expected Obj, but got Unknown
		//IL_1b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2c: Expected Obj, but got Unknown
		//IL_1b4c: Expected Obj, but got I
		//IL_1b5c: Expected Obj, but got I
		//IL_1b6c: Expected Obj, but got I
		//IL_1b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7a: Expected Obj, but got Unknown
		//IL_1b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b88: Expected Obj, but got Unknown
		//IL_1ba8: Expected Obj, but got I
		//IL_1bb8: Expected Obj, but got I
		//IL_1bc8: Expected Obj, but got I
		//IL_1bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd6: Expected Obj, but got Unknown
		//IL_1bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be4: Expected Obj, but got Unknown
		//IL_1c04: Expected Obj, but got I
		//IL_1c14: Expected Obj, but got I
		//IL_1c24: Expected Obj, but got I
		//IL_1c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c32: Expected Obj, but got Unknown
		//IL_1c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c40: Expected Obj, but got Unknown
		//IL_1c60: Expected Obj, but got I
		//IL_1c70: Expected Obj, but got I
		//IL_1c80: Expected Obj, but got I
		//IL_1c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8e: Expected Obj, but got Unknown
		//IL_1c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9c: Expected Obj, but got Unknown
		//IL_1cbc: Expected Obj, but got I
		//IL_1ccc: Expected Obj, but got I
		//IL_1cdc: Expected Obj, but got I
		//IL_1ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cea: Expected Obj, but got Unknown
		//IL_1cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf8: Expected Obj, but got Unknown
		//IL_1d18: Expected Obj, but got I
		//IL_1d28: Expected Obj, but got I
		//IL_1d38: Expected Obj, but got I
		//IL_1d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d46: Expected Obj, but got Unknown
		//IL_1d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d54: Expected Obj, but got Unknown
		//IL_1d6c: Expected I, but got Obj
		//IL_1d82: Expected Obj, but got I
		//IL_1d98: Expected Obj, but got I
		//IL_1da8: Expected Obj, but got I
		//IL_1db8: Expected Obj, but got I
		//IL_1dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc6: Expected Obj, but got Unknown
		//IL_1dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd4: Expected Obj, but got Unknown
		//IL_1df4: Expected Obj, but got I
		//IL_1e04: Expected Obj, but got I
		//IL_1e14: Expected Obj, but got I
		//IL_1e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e22: Expected Obj, but got Unknown
		//IL_1e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e30: Expected Obj, but got Unknown
		//IL_1e50: Expected Obj, but got I
		//IL_1e60: Expected Obj, but got I
		//IL_1e70: Expected Obj, but got I
		//IL_1e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7e: Expected Obj, but got Unknown
		//IL_1e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8c: Expected Obj, but got Unknown
		//IL_1eac: Expected Obj, but got I
		//IL_1ebc: Expected Obj, but got I
		//IL_1ecc: Expected Obj, but got I
		//IL_1ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eda: Expected Obj, but got Unknown
		//IL_1ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee8: Expected Obj, but got Unknown
		//IL_1f08: Expected Obj, but got I
		//IL_1f18: Expected Obj, but got I
		//IL_1f28: Expected Obj, but got I
		//IL_1f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f36: Expected Obj, but got Unknown
		//IL_1f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f44: Expected Obj, but got Unknown
		//IL_1f64: Expected Obj, but got I
		//IL_1f74: Expected Obj, but got I
		//IL_1f84: Expected Obj, but got I
		//IL_1f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f92: Expected Obj, but got Unknown
		//IL_1f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa0: Expected Obj, but got Unknown
		//IL_1fc0: Expected Obj, but got I
		//IL_1fd0: Expected Obj, but got I
		//IL_1fe0: Expected Obj, but got I
		//IL_1fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fee: Expected Obj, but got Unknown
		//IL_1ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffc: Expected Obj, but got Unknown
		//IL_201c: Expected Obj, but got I
		//IL_202c: Expected Obj, but got I
		//IL_203c: Expected Obj, but got I
		//IL_2045: Unknown result type (might be due to invalid IL or missing references)
		//IL_204a: Expected Obj, but got Unknown
		//IL_2053: Unknown result type (might be due to invalid IL or missing references)
		//IL_2058: Expected Obj, but got Unknown
		//IL_2068: Unknown result type (might be due to invalid IL or missing references)
		//IL_206d: Expected Obj, but got Unknown
		//IL_209a: Expected Obj, but got I
		//IL_20aa: Expected Obj, but got I
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
		//IL_214a: Expected Obj, but got I
		//IL_215a: Expected Obj, but got I
		//IL_216a: Expected Obj, but got I
		//IL_2173: Unknown result type (might be due to invalid IL or missing references)
		//IL_2178: Expected Obj, but got Unknown
		//IL_2181: Unknown result type (might be due to invalid IL or missing references)
		//IL_2186: Expected Obj, but got Unknown
		//IL_21a6: Expected Obj, but got I
		//IL_21b6: Expected Obj, but got I
		//IL_21c6: Expected Obj, but got I
		//IL_21cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d4: Expected Obj, but got Unknown
		//IL_21dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e2: Expected Obj, but got Unknown
		//IL_2202: Expected Obj, but got I
		//IL_2212: Expected Obj, but got I
		//IL_2222: Expected Obj, but got I
		//IL_222b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2230: Expected Obj, but got Unknown
		//IL_2239: Unknown result type (might be due to invalid IL or missing references)
		//IL_223e: Expected Obj, but got Unknown
		//IL_225e: Expected Obj, but got I
		//IL_226e: Expected Obj, but got I
		//IL_227e: Expected Obj, but got I
		//IL_2287: Unknown result type (might be due to invalid IL or missing references)
		//IL_228c: Expected Obj, but got Unknown
		//IL_2295: Unknown result type (might be due to invalid IL or missing references)
		//IL_229a: Expected Obj, but got Unknown
		//IL_22ba: Expected Obj, but got I
		//IL_22ca: Expected Obj, but got I
		//IL_22da: Expected Obj, but got I
		//IL_22e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e8: Expected Obj, but got Unknown
		//IL_22f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f6: Expected Obj, but got Unknown
		//IL_2316: Expected Obj, but got I
		//IL_2326: Expected Obj, but got I
		//IL_2336: Expected Obj, but got I
		//IL_233f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2344: Expected Obj, but got Unknown
		//IL_234d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2352: Expected Obj, but got Unknown
		//IL_2372: Expected Obj, but got I
		//IL_2382: Expected Obj, but got I
		//IL_2392: Expected Obj, but got I
		//IL_239b: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a0: Expected Obj, but got Unknown
		//IL_23a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ae: Expected Obj, but got Unknown
		//IL_23ce: Expected Obj, but got I
		//IL_23de: Expected Obj, but got I
		//IL_23ee: Expected Obj, but got I
		//IL_23f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fc: Expected Obj, but got Unknown
		//IL_2405: Unknown result type (might be due to invalid IL or missing references)
		//IL_240a: Expected Obj, but got Unknown
		//IL_242a: Expected Obj, but got I
		//IL_243a: Expected Obj, but got I
		//IL_244a: Expected Obj, but got I
		//IL_2453: Unknown result type (might be due to invalid IL or missing references)
		//IL_2458: Expected Obj, but got Unknown
		//IL_2461: Unknown result type (might be due to invalid IL or missing references)
		//IL_2466: Expected Obj, but got Unknown
		//IL_2486: Expected Obj, but got I
		//IL_2496: Expected Obj, but got I
		//IL_24a6: Expected Obj, but got I
		//IL_24af: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b4: Expected Obj, but got Unknown
		//IL_24bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c2: Expected Obj, but got Unknown
		//IL_24e2: Expected Obj, but got I
		//IL_24f2: Expected Obj, but got I
		//IL_2502: Expected Obj, but got I
		//IL_250b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2510: Expected Obj, but got Unknown
		//IL_2519: Unknown result type (might be due to invalid IL or missing references)
		//IL_251e: Expected Obj, but got Unknown
		//IL_253e: Expected Obj, but got I
		//IL_254e: Expected Obj, but got I
		//IL_255e: Expected Obj, but got I
		//IL_2567: Unknown result type (might be due to invalid IL or missing references)
		//IL_256c: Expected Obj, but got Unknown
		//IL_2575: Unknown result type (might be due to invalid IL or missing references)
		//IL_257a: Expected Obj, but got Unknown
		//IL_2592: Expected I, but got Obj
		//IL_25a8: Expected Obj, but got I
		//IL_25be: Expected Obj, but got I
		//IL_25ce: Expected Obj, but got I
		//IL_25de: Expected Obj, but got I
		//IL_25e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ec: Expected Obj, but got Unknown
		//IL_25f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_25fa: Expected Obj, but got Unknown
		//IL_261a: Expected Obj, but got I
		//IL_262a: Expected Obj, but got I
		//IL_263a: Expected Obj, but got I
		//IL_2643: Unknown result type (might be due to invalid IL or missing references)
		//IL_2648: Expected Obj, but got Unknown
		//IL_2651: Unknown result type (might be due to invalid IL or missing references)
		//IL_2656: Expected Obj, but got Unknown
		//IL_2676: Expected Obj, but got I
		//IL_2686: Expected Obj, but got I
		//IL_2696: Expected Obj, but got I
		//IL_269f: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a4: Expected Obj, but got Unknown
		//IL_26ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b2: Expected Obj, but got Unknown
		//IL_26d2: Expected Obj, but got I
		//IL_26e2: Expected Obj, but got I
		//IL_26f2: Expected Obj, but got I
		//IL_26fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2700: Expected Obj, but got Unknown
		//IL_2709: Unknown result type (might be due to invalid IL or missing references)
		//IL_270e: Expected Obj, but got Unknown
		//IL_272e: Expected Obj, but got I
		//IL_273e: Expected Obj, but got I
		//IL_274e: Expected Obj, but got I
		//IL_2757: Unknown result type (might be due to invalid IL or missing references)
		//IL_275c: Expected Obj, but got Unknown
		//IL_2765: Unknown result type (might be due to invalid IL or missing references)
		//IL_276a: Expected Obj, but got Unknown
		//IL_278a: Expected Obj, but got I
		//IL_279a: Expected Obj, but got I
		//IL_27aa: Expected Obj, but got I
		//IL_27b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b8: Expected Obj, but got Unknown
		//IL_27c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c6: Expected Obj, but got Unknown
		//IL_27e6: Expected Obj, but got I
		//IL_27f6: Expected Obj, but got I
		//IL_2806: Expected Obj, but got I
		//IL_280f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2814: Expected Obj, but got Unknown
		//IL_281d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2822: Expected Obj, but got Unknown
		//IL_2842: Expected Obj, but got I
		//IL_2852: Expected Obj, but got I
		//IL_2862: Expected Obj, but got I
		//IL_286b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2870: Expected Obj, but got Unknown
		//IL_2879: Unknown result type (might be due to invalid IL or missing references)
		//IL_287e: Expected Obj, but got Unknown
		//IL_289e: Expected Obj, but got I
		//IL_28ae: Expected Obj, but got I
		//IL_28be: Expected Obj, but got I
		//IL_28c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_28cc: Expected Obj, but got Unknown
		//IL_28d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_28da: Expected Obj, but got Unknown
		//IL_28ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ef: Expected Obj, but got Unknown
		//IL_2917: Expected Obj, but got I
		//IL_2927: Expected Obj, but got I
		//IL_2938: Unknown result type (might be due to invalid IL or missing references)
		//IL_293d: Expected Obj, but got Unknown
		//IL_2946: Unknown result type (might be due to invalid IL or missing references)
		//IL_294b: Expected Obj, but got Unknown
		//IL_296b: Expected Obj, but got I
		//IL_297b: Expected Obj, but got I
		//IL_298b: Expected Obj, but got I
		//IL_2994: Unknown result type (might be due to invalid IL or missing references)
		//IL_2999: Expected Obj, but got Unknown
		//IL_29a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a7: Expected Obj, but got Unknown
		//IL_29c7: Expected Obj, but got I
		//IL_29d7: Expected Obj, but got I
		//IL_29e7: Expected Obj, but got I
		//IL_29f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f5: Expected Obj, but got Unknown
		//IL_29fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a03: Expected Obj, but got Unknown
		//IL_2a23: Expected Obj, but got I
		//IL_2a33: Expected Obj, but got I
		//IL_2a43: Expected Obj, but got I
		//IL_2a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a51: Expected Obj, but got Unknown
		//IL_2a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5f: Expected Obj, but got Unknown
		//IL_2a7f: Expected Obj, but got I
		//IL_2a8f: Expected Obj, but got I
		//IL_2a9f: Expected Obj, but got I
		//IL_2aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aad: Expected Obj, but got Unknown
		//IL_2ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2abb: Expected Obj, but got Unknown
		//IL_2adb: Expected Obj, but got I
		//IL_2aeb: Expected Obj, but got I
		//IL_2afb: Expected Obj, but got I
		//IL_2b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b09: Expected Obj, but got Unknown
		//IL_2b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b17: Expected Obj, but got Unknown
		//IL_2b37: Expected Obj, but got I
		//IL_2b47: Expected Obj, but got I
		//IL_2b57: Expected Obj, but got I
		//IL_2b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b65: Expected Obj, but got Unknown
		//IL_2b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b73: Expected Obj, but got Unknown
		//IL_2b93: Expected Obj, but got I
		//IL_2ba3: Expected Obj, but got I
		//IL_2bb3: Expected Obj, but got I
		//IL_2bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc1: Expected Obj, but got Unknown
		//IL_2bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bcf: Expected Obj, but got Unknown
		//IL_2bef: Expected Obj, but got I
		//IL_2bff: Expected Obj, but got I
		//IL_2c0f: Expected Obj, but got I
		//IL_2c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1d: Expected Obj, but got Unknown
		//IL_2c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2b: Expected Obj, but got Unknown
		//IL_2c4b: Expected Obj, but got I
		//IL_2c5b: Expected Obj, but got I
		//IL_2c6b: Expected Obj, but got I
		//IL_2c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c79: Expected Obj, but got Unknown
		//IL_2c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c87: Expected Obj, but got Unknown
		//IL_2ca7: Expected Obj, but got I
		//IL_2cb7: Expected Obj, but got I
		//IL_2cc7: Expected Obj, but got I
		//IL_2cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd5: Expected Obj, but got Unknown
		//IL_2cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce3: Expected Obj, but got Unknown
		//IL_2d03: Expected Obj, but got I
		//IL_2d13: Expected Obj, but got I
		//IL_2d23: Expected Obj, but got I
		//IL_2d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d31: Expected Obj, but got Unknown
		//IL_2d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d3f: Expected Obj, but got Unknown
		//IL_2d5f: Expected Obj, but got I
		//IL_2d6f: Expected Obj, but got I
		//IL_2d7f: Expected Obj, but got I
		//IL_2d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8d: Expected Obj, but got Unknown
		//IL_2d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9b: Expected Obj, but got Unknown
		//IL_2dbb: Expected Obj, but got I
		//IL_2dcb: Expected Obj, but got I
		//IL_2ddb: Expected Obj, but got I
		//IL_2de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de9: Expected Obj, but got Unknown
		//IL_2df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df7: Expected Obj, but got Unknown
		//IL_2e0f: Expected I, but got Obj
		//IL_2e25: Expected Obj, but got I
		//IL_2e3b: Expected Obj, but got I
		//IL_2e4b: Expected Obj, but got I
		//IL_2e5b: Expected Obj, but got I
		//IL_2e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e69: Expected Obj, but got Unknown
		//IL_2e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e77: Expected Obj, but got Unknown
		//IL_2e97: Expected Obj, but got I
		//IL_2ea7: Expected Obj, but got I
		//IL_2eb7: Expected Obj, but got I
		//IL_2ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec5: Expected Obj, but got Unknown
		//IL_2ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed3: Expected Obj, but got Unknown
		//IL_2ef3: Expected Obj, but got I
		//IL_2f03: Expected Obj, but got I
		//IL_2f13: Expected Obj, but got I
		//IL_2f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f21: Expected Obj, but got Unknown
		//IL_2f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f2f: Expected Obj, but got Unknown
		//IL_2f4f: Expected Obj, but got I
		//IL_2f5f: Expected Obj, but got I
		//IL_2f6f: Expected Obj, but got I
		//IL_2f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7d: Expected Obj, but got Unknown
		//IL_2f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8b: Expected Obj, but got Unknown
		//IL_2fab: Expected Obj, but got I
		//IL_2fbb: Expected Obj, but got I
		//IL_2fcb: Expected Obj, but got I
		//IL_2fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd9: Expected Obj, but got Unknown
		//IL_2fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe7: Expected Obj, but got Unknown
		//IL_3007: Expected Obj, but got I
		//IL_3017: Expected Obj, but got I
		//IL_3027: Expected Obj, but got I
		//IL_3030: Unknown result type (might be due to invalid IL or missing references)
		//IL_3035: Expected Obj, but got Unknown
		//IL_303e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3043: Expected Obj, but got Unknown
		//IL_3063: Expected Obj, but got I
		//IL_3073: Expected Obj, but got I
		//IL_3083: Expected Obj, but got I
		//IL_308c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3091: Expected Obj, but got Unknown
		//IL_309a: Unknown result type (might be due to invalid IL or missing references)
		//IL_309f: Expected Obj, but got Unknown
		//IL_30af: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b4: Expected Obj, but got Unknown
		//IL_30e1: Expected Obj, but got I
		//IL_30f1: Expected Obj, but got I
		//IL_3102: Unknown result type (might be due to invalid IL or missing references)
		//IL_3107: Expected Obj, but got Unknown
		//IL_3110: Unknown result type (might be due to invalid IL or missing references)
		//IL_3115: Expected Obj, but got Unknown
		//IL_3135: Expected Obj, but got I
		//IL_3145: Expected Obj, but got I
		//IL_3155: Expected Obj, but got I
		//IL_315e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3163: Expected Obj, but got Unknown
		//IL_316c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3171: Expected Obj, but got Unknown
		//IL_3191: Expected Obj, but got I
		//IL_31a1: Expected Obj, but got I
		//IL_31b1: Expected Obj, but got I
		//IL_31ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_31bf: Expected Obj, but got Unknown
		//IL_31c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_31cd: Expected Obj, but got Unknown
		//IL_31ed: Expected Obj, but got I
		//IL_31fd: Expected Obj, but got I
		//IL_320d: Expected Obj, but got I
		//IL_3216: Unknown result type (might be due to invalid IL or missing references)
		//IL_321b: Expected Obj, but got Unknown
		//IL_3224: Unknown result type (might be due to invalid IL or missing references)
		//IL_3229: Expected Obj, but got Unknown
		//IL_3249: Expected Obj, but got I
		//IL_3259: Expected Obj, but got I
		//IL_3269: Expected Obj, but got I
		//IL_3272: Unknown result type (might be due to invalid IL or missing references)
		//IL_3277: Expected Obj, but got Unknown
		//IL_3280: Unknown result type (might be due to invalid IL or missing references)
		//IL_3285: Expected Obj, but got Unknown
		//IL_32a5: Expected Obj, but got I
		//IL_32b5: Expected Obj, but got I
		//IL_32c5: Expected Obj, but got I
		//IL_32ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d3: Expected Obj, but got Unknown
		//IL_32dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e1: Expected Obj, but got Unknown
		//IL_3301: Expected Obj, but got I
		//IL_3311: Expected Obj, but got I
		//IL_3321: Expected Obj, but got I
		//IL_332a: Unknown result type (might be due to invalid IL or missing references)
		//IL_332f: Expected Obj, but got Unknown
		//IL_3338: Unknown result type (might be due to invalid IL or missing references)
		//IL_333d: Expected Obj, but got Unknown
		//IL_335d: Expected Obj, but got I
		//IL_336d: Expected Obj, but got I
		//IL_337d: Expected Obj, but got I
		//IL_3386: Unknown result type (might be due to invalid IL or missing references)
		//IL_338b: Expected Obj, but got Unknown
		//IL_3394: Unknown result type (might be due to invalid IL or missing references)
		//IL_3399: Expected Obj, but got Unknown
		//IL_33b9: Expected Obj, but got I
		//IL_33c9: Expected Obj, but got I
		//IL_33d9: Expected Obj, but got I
		//IL_33e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_33e7: Expected Obj, but got Unknown
		//IL_33f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f5: Expected Obj, but got Unknown
		//IL_3415: Expected Obj, but got I
		//IL_3425: Expected Obj, but got I
		//IL_3435: Expected Obj, but got I
		//IL_343e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3443: Expected Obj, but got Unknown
		//IL_344c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3451: Expected Obj, but got Unknown
		//IL_3471: Expected Obj, but got I
		//IL_3481: Expected Obj, but got I
		//IL_3491: Expected Obj, but got I
		//IL_349a: Unknown result type (might be due to invalid IL or missing references)
		//IL_349f: Expected Obj, but got Unknown
		//IL_34a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ad: Expected Obj, but got Unknown
		//IL_34cd: Expected Obj, but got I
		//IL_34dd: Expected Obj, but got I
		//IL_34ed: Expected Obj, but got I
		//IL_34f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34fb: Expected Obj, but got Unknown
		//IL_3504: Unknown result type (might be due to invalid IL or missing references)
		//IL_3509: Expected Obj, but got Unknown
		//IL_3529: Expected Obj, but got I
		//IL_3539: Expected Obj, but got I
		//IL_3549: Expected Obj, but got I
		//IL_3552: Unknown result type (might be due to invalid IL or missing references)
		//IL_3557: Expected Obj, but got Unknown
		//IL_3560: Unknown result type (might be due to invalid IL or missing references)
		//IL_3565: Expected Obj, but got Unknown
		//IL_3585: Expected Obj, but got I
		//IL_3595: Expected Obj, but got I
		//IL_35a5: Expected Obj, but got I
		//IL_35ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b3: Expected Obj, but got Unknown
		//IL_35bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c1: Expected Obj, but got Unknown
		//IL_35d9: Expected I, but got Obj
		//IL_35ef: Expected Obj, but got I
		//IL_3605: Expected Obj, but got I
		//IL_3615: Expected Obj, but got I
		//IL_3625: Expected Obj, but got I
		//IL_362e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3633: Expected Obj, but got Unknown
		//IL_363c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3641: Expected Obj, but got Unknown
		//IL_3661: Expected Obj, but got I
		//IL_3671: Expected Obj, but got I
		//IL_3681: Expected Obj, but got I
		//IL_368a: Unknown result type (might be due to invalid IL or missing references)
		//IL_368f: Expected Obj, but got Unknown
		//IL_3698: Unknown result type (might be due to invalid IL or missing references)
		//IL_369d: Expected Obj, but got Unknown
		//IL_36bd: Expected Obj, but got I
		//IL_36cd: Expected Obj, but got I
		//IL_36dd: Expected Obj, but got I
		//IL_36e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_36eb: Expected Obj, but got Unknown
		//IL_36f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f9: Expected Obj, but got Unknown
		//IL_3719: Expected Obj, but got I
		//IL_3729: Expected Obj, but got I
		//IL_3739: Expected Obj, but got I
		//IL_3742: Unknown result type (might be due to invalid IL or missing references)
		//IL_3747: Expected Obj, but got Unknown
		//IL_3750: Unknown result type (might be due to invalid IL or missing references)
		//IL_3755: Expected Obj, but got Unknown
		//IL_3775: Expected Obj, but got I
		//IL_3785: Expected Obj, but got I
		//IL_3795: Expected Obj, but got I
		//IL_379e: Unknown result type (might be due to invalid IL or missing references)
		//IL_37a3: Expected Obj, but got Unknown
		//IL_37ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_37b1: Expected Obj, but got Unknown
		//IL_37c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_37c6: Expected Obj, but got Unknown
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v462 (Il2CppClass<AdLocations>)+74]");
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
		nint num15 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v48 (Il2CppClass<AdLocations>)+5C]");
		object obj62 = -(-64);
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S4_v61 (Il2CppMethodInfo)+C]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S4_v62+60]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S4_v63+48]");
		object obj65 = 0;
		object obj66 = obj65 & 0x7FF;
		object obj67 = obj66 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v297 @ S5_v50 (should have been resolved before IL gen)");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S4_v66 (Il2CppMethodInfo)+C]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S4_v67+60]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S4_v68+48]");
		object obj70 = 0;
		object obj71 = obj70 & 0x7FF;
		object obj72 = obj71 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v318 @ S5_v54 (should have been resolved before IL gen)");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S4_v71 (Il2CppMethodInfo)+C]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S4_v72+60]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S4_v73+48]");
		object obj75 = 0;
		object obj76 = obj75 & 0x7FF;
		object obj77 = obj76 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v339 @ S5_v58 (should have been resolved before IL gen)");
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
		object obj98 = this + 8;
		object obj99 = default;
		obj98 = obj99;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S3_v25 (Il2CppMethodInfo)+C]");
		object obj100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S3_v26+60]");
		object obj101 = 0;
		object obj102 = obj101;
		object obj103 = obj102 & 0x1FFF;
		object obj104 = obj103 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v448 @ S4_v98 (should have been resolved before IL gen)");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S4_v100 (Il2CppMethodInfo)+C]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S4_v101+60]");
		object obj106 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S4_v102+48]");
		object obj107 = 0;
		object obj108 = obj107 & 0x7FF;
		object obj109 = obj108 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v469 @ S5_v80 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S4_v105 (Il2CppMethodInfo)+C]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S4_v106+60]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S4_v107+48]");
		object obj112 = 0;
		object obj113 = obj112 & 0x7FF;
		object obj114 = obj113 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v490 @ S5_v84 (should have been resolved before IL gen)");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S4_v110 (Il2CppMethodInfo)+C]");
		object obj115 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S4_v111+60]");
		object obj116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S4_v112+48]");
		object obj117 = 0;
		object obj118 = obj117 & 0x7FF;
		object obj119 = obj118 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v511 @ S5_v88 (should have been resolved before IL gen)");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S4_v115 (Il2CppMethodInfo)+C]");
		object obj120 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S4_v116+60]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S4_v117+48]");
		object obj122 = 0;
		object obj123 = obj122 & 0x7FF;
		object obj124 = obj123 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v532 @ S5_v92 (should have been resolved before IL gen)");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ S4_v120 (Il2CppMethodInfo)+C]");
		object obj125 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S4_v121+60]");
		object obj126 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S4_v122+48]");
		object obj127 = 0;
		object obj128 = obj127 & 0x7FF;
		object obj129 = obj128 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v553 @ S5_v96 (should have been resolved before IL gen)");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S4_v125 (Il2CppMethodInfo)+C]");
		object obj130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S4_v126+60]");
		object obj131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S4_v127+48]");
		object obj132 = 0;
		object obj133 = obj132 & 0x7FF;
		object obj134 = obj133 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v574 @ S5_v100 (should have been resolved before IL gen)");
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S4_v130 (Il2CppMethodInfo)+C]");
		object obj135 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S4_v131+60]");
		object obj136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S4_v132+48]");
		object obj137 = 0;
		object obj138 = obj137 & 0x7FF;
		object obj139 = obj138 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v595 @ S5_v104 (should have been resolved before IL gen)");
		nint num31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ S4_v135 (Il2CppMethodInfo)+C]");
		object obj140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S4_v136+60]");
		object obj141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S4_v137+48]");
		object obj142 = 0;
		object obj143 = obj142 & 0x7FF;
		object obj144 = obj143 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v616 @ S5_v108 (should have been resolved before IL gen)");
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ S4_v140 (Il2CppMethodInfo)+C]");
		object obj145 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S4_v141+60]");
		object obj146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S4_v142+48]");
		object obj147 = 0;
		object obj148 = obj147 & 0x7FF;
		object obj149 = obj148 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v637 @ S5_v112 (should have been resolved before IL gen)");
		nint num33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ S4_v145 (Il2CppMethodInfo)+C]");
		object obj150 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S4_v146+60]");
		object obj151 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S4_v147+48]");
		object obj152 = 0;
		object obj153 = obj152 & 0x7FF;
		object obj154 = obj153 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v658 @ S5_v116 (should have been resolved before IL gen)");
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S4_v150 (Il2CppMethodInfo)+C]");
		object obj155 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ S4_v151+60]");
		object obj156 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ S4_v152+48]");
		object obj157 = 0;
		object obj158 = obj157 & 0x7FF;
		object obj159 = obj158 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v679 @ S5_v120 (should have been resolved before IL gen)");
		nint num35 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S1_v124 (Il2CppClass<AdLocations>)+5C]");
		object obj160 = -(-64);
		nint num36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S4_v155 (Il2CppMethodInfo)+C]");
		object obj161 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S4_v156+60]");
		object obj162 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S4_v157+48]");
		object obj163 = 0;
		object obj164 = obj163 & 0x7FF;
		object obj165 = obj164 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v702 @ S5_v124 (should have been resolved before IL gen)");
		nint num37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ S4_v160 (Il2CppMethodInfo)+C]");
		object obj166 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ S4_v161+60]");
		object obj167 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S4_v162+48]");
		object obj168 = 0;
		object obj169 = obj168 & 0x7FF;
		object obj170 = obj169 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v723 @ S5_v128 (should have been resolved before IL gen)");
		nint num38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S4_v165 (Il2CppMethodInfo)+C]");
		object obj171 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ S4_v166+60]");
		object obj172 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ S4_v167+48]");
		object obj173 = 0;
		object obj174 = obj173 & 0x7FF;
		object obj175 = obj174 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v744 @ S5_v132 (should have been resolved before IL gen)");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S4_v170 (Il2CppMethodInfo)+C]");
		object obj176 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ S4_v171+60]");
		object obj177 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ S4_v172+48]");
		object obj178 = 0;
		object obj179 = obj178 & 0x7FF;
		object obj180 = obj179 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v765 @ S5_v136 (should have been resolved before IL gen)");
		nint num40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ S4_v175 (Il2CppMethodInfo)+C]");
		object obj181 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ S4_v176+60]");
		object obj182 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ S4_v177+48]");
		object obj183 = 0;
		object obj184 = obj183 & 0x7FF;
		object obj185 = obj184 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v786 @ S5_v140 (should have been resolved before IL gen)");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ S4_v180 (Il2CppMethodInfo)+C]");
		object obj186 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ S4_v181+60]");
		object obj187 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ S4_v182+48]");
		object obj188 = 0;
		object obj189 = obj188 & 0x7FF;
		object obj190 = obj189 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v807 @ S5_v144 (should have been resolved before IL gen)");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ S4_v185 (Il2CppMethodInfo)+C]");
		object obj191 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ S4_v186+60]");
		object obj192 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S4_v187+48]");
		object obj193 = 0;
		object obj194 = obj193 & 0x7FF;
		object obj195 = obj194 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v828 @ S5_v148 (should have been resolved before IL gen)");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ S4_v190 (Il2CppMethodInfo)+C]");
		object obj196 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ S4_v191+60]");
		object obj197 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ S4_v192+48]");
		object obj198 = 0;
		object obj199 = obj198 & 0x7FF;
		object obj200 = obj199 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v849 @ S5_v152 (should have been resolved before IL gen)");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ S4_v195 (Il2CppMethodInfo)+C]");
		object obj201 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v861 @ S4_v196+60]");
		object obj202 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ S4_v197+48]");
		object obj203 = 0;
		object obj204 = obj203 & 0x7FF;
		object obj205 = obj204 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v870 @ S5_v156 (should have been resolved before IL gen)");
		object obj206 = this + 12;
		object obj207 = default;
		obj206 = obj207;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ S3_v50 (Il2CppMethodInfo)+C]");
		object obj208 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ S3_v51+60]");
		object obj209 = 0;
		object obj210 = obj209;
		object obj211 = obj210 & 0x1FFF;
		object obj212 = obj211 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v894 @ S4_v202 (should have been resolved before IL gen)");
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S4_v204 (Il2CppMethodInfo)+C]");
		object obj213 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ S4_v205+60]");
		object obj214 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ S4_v206+48]");
		object obj215 = 0;
		object obj216 = obj215 & 0x7FF;
		object obj217 = obj216 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v915 @ S5_v162 (should have been resolved before IL gen)");
		nint num47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ S4_v209 (Il2CppMethodInfo)+C]");
		object obj218 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ S4_v210+60]");
		object obj219 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ S4_v211+48]");
		object obj220 = 0;
		object obj221 = obj220 & 0x7FF;
		object obj222 = obj221 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v936 @ S5_v166 (should have been resolved before IL gen)");
		nint num48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ S4_v214 (Il2CppMethodInfo)+C]");
		object obj223 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ S4_v215+60]");
		object obj224 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S4_v216+48]");
		object obj225 = 0;
		object obj226 = obj225 & 0x7FF;
		object obj227 = obj226 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v957 @ S5_v170 (should have been resolved before IL gen)");
		nint num49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ S4_v219 (Il2CppMethodInfo)+C]");
		object obj228 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ S4_v220+60]");
		object obj229 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ S4_v221+48]");
		object obj230 = 0;
		object obj231 = obj230 & 0x7FF;
		object obj232 = obj231 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v978 @ S5_v174 (should have been resolved before IL gen)");
		nint num50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ S4_v224 (Il2CppMethodInfo)+C]");
		object obj233 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ S4_v225+60]");
		object obj234 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S4_v226+48]");
		object obj235 = 0;
		object obj236 = obj235 & 0x7FF;
		object obj237 = obj236 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v999 @ S5_v178 (should have been resolved before IL gen)");
		nint num51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ S4_v229 (Il2CppMethodInfo)+C]");
		object obj238 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ S4_v230+60]");
		object obj239 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ S4_v231+48]");
		object obj240 = 0;
		object obj241 = obj240 & 0x7FF;
		object obj242 = obj241 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1020 @ S5_v182 (should have been resolved before IL gen)");
		nint num52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ S4_v234 (Il2CppMethodInfo)+C]");
		object obj243 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ S4_v235+60]");
		object obj244 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ S4_v236+48]");
		object obj245 = 0;
		object obj246 = obj245 & 0x7FF;
		object obj247 = obj246 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1041 @ S5_v186 (should have been resolved before IL gen)");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ S4_v239 (Il2CppMethodInfo)+C]");
		object obj248 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ S4_v240+60]");
		object obj249 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ S4_v241+48]");
		object obj250 = 0;
		object obj251 = obj250 & 0x7FF;
		object obj252 = obj251 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1062 @ S5_v190 (should have been resolved before IL gen)");
		nint num54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ S4_v244 (Il2CppMethodInfo)+C]");
		object obj253 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ S4_v245+60]");
		object obj254 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ S4_v246+48]");
		object obj255 = 0;
		object obj256 = obj255 & 0x7FF;
		object obj257 = obj256 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1083 @ S5_v194 (should have been resolved before IL gen)");
		nint num55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ S4_v249 (Il2CppMethodInfo)+C]");
		object obj258 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ S4_v250+60]");
		object obj259 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1096 @ S4_v251+48]");
		object obj260 = 0;
		object obj261 = obj260 & 0x7FF;
		object obj262 = obj261 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1104 @ S5_v198 (should have been resolved before IL gen)");
		nint num56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ S4_v254 (Il2CppMethodInfo)+C]");
		object obj263 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1116 @ S4_v255+60]");
		object obj264 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ S4_v256+48]");
		object obj265 = 0;
		object obj266 = obj265 & 0x7FF;
		object obj267 = obj266 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1125 @ S5_v202 (should have been resolved before IL gen)");
		nint num57 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1129 @ S1_v208 (Il2CppClass<AdLocations>)+5C]");
		object obj268 = -(-64);
		nint num58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ S4_v259 (Il2CppMethodInfo)+C]");
		object obj269 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ S4_v260+60]");
		object obj270 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ S4_v261+48]");
		object obj271 = 0;
		object obj272 = obj271 & 0x7FF;
		object obj273 = obj272 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1148 @ S5_v206 (should have been resolved before IL gen)");
		nint num59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ S4_v264 (Il2CppMethodInfo)+C]");
		object obj274 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ S4_v265+60]");
		object obj275 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ S4_v266+48]");
		object obj276 = 0;
		object obj277 = obj276 & 0x7FF;
		object obj278 = obj277 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1169 @ S5_v210 (should have been resolved before IL gen)");
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ S4_v269 (Il2CppMethodInfo)+C]");
		object obj279 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ S4_v270+60]");
		object obj280 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S4_v271+48]");
		object obj281 = 0;
		object obj282 = obj281 & 0x7FF;
		object obj283 = obj282 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1190 @ S5_v214 (should have been resolved before IL gen)");
		nint num61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ S4_v274 (Il2CppMethodInfo)+C]");
		object obj284 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ S4_v275+60]");
		object obj285 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ S4_v276+48]");
		object obj286 = 0;
		object obj287 = obj286 & 0x7FF;
		object obj288 = obj287 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1211 @ S5_v218 (should have been resolved before IL gen)");
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ S4_v279 (Il2CppMethodInfo)+C]");
		object obj289 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ S4_v280+60]");
		object obj290 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ S4_v281+48]");
		object obj291 = 0;
		object obj292 = obj291 & 0x7FF;
		object obj293 = obj292 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1232 @ S5_v222 (should have been resolved before IL gen)");
		nint num63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1243 @ S4_v284 (Il2CppMethodInfo)+C]");
		object obj294 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ S4_v285+60]");
		object obj295 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ S4_v286+48]");
		object obj296 = 0;
		object obj297 = obj296 & 0x7FF;
		object obj298 = obj297 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1253 @ S5_v226 (should have been resolved before IL gen)");
		nint num64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ S4_v289 (Il2CppMethodInfo)+C]");
		object obj299 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1265 @ S4_v290+60]");
		object obj300 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ S4_v291+48]");
		object obj301 = 0;
		object obj302 = obj301 & 0x7FF;
		object obj303 = obj302 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1274 @ S5_v230 (should have been resolved before IL gen)");
		nint num65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S4_v294 (Il2CppMethodInfo)+C]");
		object obj304 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1286 @ S4_v295+60]");
		object obj305 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ S4_v296+48]");
		object obj306 = 0;
		object obj307 = obj306 & 0x7FF;
		object obj308 = obj307 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1295 @ S5_v234 (should have been resolved before IL gen)");
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ S4_v299 (Il2CppMethodInfo)+C]");
		object obj309 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ S4_v300+60]");
		object obj310 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1308 @ S4_v301+48]");
		object obj311 = 0;
		object obj312 = obj311 & 0x7FF;
		object obj313 = obj312 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1316 @ S5_v238 (should have been resolved before IL gen)");
		object obj314 = this + 16;
		object obj315 = default;
		obj314 = obj315;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ S3_v75 (Il2CppMethodInfo)+C]");
		object obj316 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1330 @ S3_v76+60]");
		object obj317 = 0;
		object obj318 = obj317;
		object obj319 = obj318 & 0x1FFF;
		object obj320 = obj319 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1339 @ S4_v306 (should have been resolved before IL gen)");
		nint num68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ S4_v308 (Il2CppMethodInfo)+C]");
		object obj321 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ S4_v309+60]");
		object obj322 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ S4_v310+48]");
		object obj323 = 0;
		object obj324 = obj323 & 0x7FF;
		object obj325 = obj324 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1360 @ S5_v244 (should have been resolved before IL gen)");
		nint num69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1371 @ S4_v313 (Il2CppMethodInfo)+C]");
		object obj326 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1372 @ S4_v314+60]");
		object obj327 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ S4_v315+48]");
		object obj328 = 0;
		object obj329 = obj328 & 0x7FF;
		object obj330 = obj329 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1381 @ S5_v248 (should have been resolved before IL gen)");
		nint num70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ S4_v318 (Il2CppMethodInfo)+C]");
		object obj331 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1393 @ S4_v319+60]");
		object obj332 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ S4_v320+48]");
		object obj333 = 0;
		object obj334 = obj333 & 0x7FF;
		object obj335 = obj334 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1402 @ S5_v252 (should have been resolved before IL gen)");
		nint num71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ S4_v323 (Il2CppMethodInfo)+C]");
		object obj336 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1414 @ S4_v324+60]");
		object obj337 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ S4_v325+48]");
		object obj338 = 0;
		object obj339 = obj338 & 0x7FF;
		object obj340 = obj339 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1423 @ S5_v256 (should have been resolved before IL gen)");
		nint num72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1434 @ S4_v328 (Il2CppMethodInfo)+C]");
		object obj341 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1435 @ S4_v329+60]");
		object obj342 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1436 @ S4_v330+48]");
		object obj343 = 0;
		object obj344 = obj343 & 0x7FF;
		object obj345 = obj344 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1444 @ S5_v260 (should have been resolved before IL gen)");
		nint num73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1455 @ S4_v333 (Il2CppMethodInfo)+C]");
		object obj346 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1456 @ S4_v334+60]");
		object obj347 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1457 @ S4_v335+48]");
		object obj348 = 0;
		object obj349 = obj348 & 0x7FF;
		object obj350 = obj349 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1465 @ S5_v264 (should have been resolved before IL gen)");
		nint num74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ S4_v338 (Il2CppMethodInfo)+C]");
		object obj351 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1477 @ S4_v339+60]");
		object obj352 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ S4_v340+48]");
		object obj353 = 0;
		object obj354 = obj353 & 0x7FF;
		object obj355 = obj354 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1486 @ S5_v268 (should have been resolved before IL gen)");
		nint num75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ S4_v343 (Il2CppMethodInfo)+C]");
		object obj356 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1498 @ S4_v344+60]");
		object obj357 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1499 @ S4_v345+48]");
		object obj358 = 0;
		object obj359 = obj358 & 0x7FF;
		object obj360 = obj359 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1507 @ S5_v272 (should have been resolved before IL gen)");
		nint num76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1518 @ S4_v348 (Il2CppMethodInfo)+C]");
		object obj361 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ S4_v349+60]");
		object obj362 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ S4_v350+48]");
		object obj363 = 0;
		object obj364 = obj363 & 0x7FF;
		object obj365 = obj364 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1528 @ S5_v276 (should have been resolved before IL gen)");
		nint num77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1539 @ S4_v353 (Il2CppMethodInfo)+C]");
		object obj366 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1540 @ S4_v354+60]");
		object obj367 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1541 @ S4_v355+48]");
		object obj368 = 0;
		object obj369 = obj368 & 0x7FF;
		object obj370 = obj369 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1549 @ S5_v280 (should have been resolved before IL gen)");
		nint num78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1560 @ S4_v358 (Il2CppMethodInfo)+C]");
		object obj371 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1561 @ S4_v359+60]");
		object obj372 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1562 @ S4_v360+48]");
		object obj373 = 0;
		object obj374 = obj373 & 0x7FF;
		object obj375 = obj374 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1570 @ S5_v284 (should have been resolved before IL gen)");
		nint num79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1581 @ S4_v363 (Il2CppMethodInfo)+C]");
		object obj376 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1582 @ S4_v364+60]");
		object obj377 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1583 @ S4_v365+48]");
		object obj378 = 0;
		object obj379 = obj378 & 0x7FF;
		object obj380 = obj379 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1591 @ S5_v288 (should have been resolved before IL gen)");
		nint num80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1602 @ S4_v368 (Il2CppMethodInfo)+C]");
		object obj381 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1603 @ S4_v369+60]");
		object obj382 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1604 @ S4_v370+48]");
		object obj383 = 0;
		object obj384 = obj383 & 0x7FF;
		object obj385 = obj384 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1612 @ S5_v292 (should have been resolved before IL gen)");
		nint num81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1623 @ S4_v373 (Il2CppMethodInfo)+C]");
		object obj386 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1624 @ S4_v374+60]");
		object obj387 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1625 @ S4_v375+48]");
		object obj388 = 0;
		object obj389 = obj388 & 0x7FF;
		object obj390 = obj389 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1633 @ S5_v296 (should have been resolved before IL gen)");
		nint num82 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ S1_v304 (Il2CppClass<AdLocations>)+5C]");
		object obj391 = -(-64);
		nint num83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1646 @ S4_v378 (Il2CppMethodInfo)+C]");
		object obj392 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ S4_v379+60]");
		object obj393 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1648 @ S4_v380+48]");
		object obj394 = 0;
		object obj395 = obj394 & 0x7FF;
		object obj396 = obj395 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1656 @ S5_v300 (should have been resolved before IL gen)");
		nint num84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1667 @ S4_v383 (Il2CppMethodInfo)+C]");
		object obj397 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1668 @ S4_v384+60]");
		object obj398 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1669 @ S4_v385+48]");
		object obj399 = 0;
		object obj400 = obj399 & 0x7FF;
		object obj401 = obj400 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1677 @ S5_v304 (should have been resolved before IL gen)");
		nint num85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1688 @ S4_v388 (Il2CppMethodInfo)+C]");
		object obj402 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1689 @ S4_v389+60]");
		object obj403 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1690 @ S4_v390+48]");
		object obj404 = 0;
		object obj405 = obj404 & 0x7FF;
		object obj406 = obj405 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1698 @ S5_v308 (should have been resolved before IL gen)");
		nint num86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1709 @ S4_v393 (Il2CppMethodInfo)+C]");
		object obj407 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1710 @ S4_v394+60]");
		object obj408 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1711 @ S4_v395+48]");
		object obj409 = 0;
		object obj410 = obj409 & 0x7FF;
		object obj411 = obj410 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1719 @ S5_v312 (should have been resolved before IL gen)");
		nint num87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1730 @ S4_v398 (Il2CppMethodInfo)+C]");
		object obj412 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1731 @ S4_v399+60]");
		object obj413 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1732 @ S4_v400+48]");
		object obj414 = 0;
		object obj415 = obj414 & 0x7FF;
		object obj416 = obj415 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1740 @ S5_v316 (should have been resolved before IL gen)");
		nint num88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1751 @ S4_v403 (Il2CppMethodInfo)+C]");
		object obj417 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1752 @ S4_v404+60]");
		object obj418 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1753 @ S4_v405+48]");
		object obj419 = 0;
		object obj420 = obj419 & 0x7FF;
		object obj421 = obj420 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1761 @ S5_v320 (should have been resolved before IL gen)");
		nint num89 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1772 @ S4_v408 (Il2CppMethodInfo)+C]");
		object obj422 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1773 @ S4_v409+60]");
		object obj423 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1774 @ S4_v410+48]");
		object obj424 = 0;
		object obj425 = obj424 & 0x7FF;
		object obj426 = obj425 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1782 @ S5_v324 (should have been resolved before IL gen)");
		nint num90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1793 @ S4_v413 (Il2CppMethodInfo)+C]");
		object obj427 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1794 @ S4_v414+60]");
		object obj428 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1795 @ S4_v415+48]");
		object obj429 = 0;
		object obj430 = obj429 & 0x7FF;
		object obj431 = obj430 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1803 @ S5_v328 (should have been resolved before IL gen)");
		object obj432 = this + 20;
		object obj433 = default;
		obj432 = obj433;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1816 @ S3_v102 (Il2CppMethodInfo)+C]");
		object obj434 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1817 @ S3_v103+60]");
		object obj435 = 0;
		object obj436 = obj435;
		object obj437 = obj436 & 0x1FFF;
		object obj438 = obj437 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1826 @ S4_v420 (should have been resolved before IL gen)");
		nint num92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1837 @ S4_v422 (Il2CppMethodInfo)+C]");
		object obj439 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1838 @ S4_v423+60]");
		object obj440 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1839 @ S4_v424+48]");
		object obj441 = 0;
		object obj442 = obj441 & 0x7FF;
		object obj443 = obj442 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1847 @ S5_v334 (should have been resolved before IL gen)");
		nint num93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1858 @ S4_v427 (Il2CppMethodInfo)+C]");
		object obj444 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1859 @ S4_v428+60]");
		object obj445 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1860 @ S4_v429+48]");
		object obj446 = 0;
		object obj447 = obj446 & 0x7FF;
		object obj448 = obj447 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1868 @ S5_v338 (should have been resolved before IL gen)");
		nint num94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1879 @ S4_v432 (Il2CppMethodInfo)+C]");
		object obj449 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1880 @ S4_v433+60]");
		object obj450 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1881 @ S4_v434+48]");
		object obj451 = 0;
		object obj452 = obj451 & 0x7FF;
		object obj453 = obj452 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1889 @ S5_v342 (should have been resolved before IL gen)");
		nint num95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1900 @ S4_v437 (Il2CppMethodInfo)+C]");
		object obj454 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1901 @ S4_v438+60]");
		object obj455 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1902 @ S4_v439+48]");
		object obj456 = 0;
		object obj457 = obj456 & 0x7FF;
		object obj458 = obj457 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1910 @ S5_v346 (should have been resolved before IL gen)");
		nint num96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1921 @ S4_v442 (Il2CppMethodInfo)+C]");
		object obj459 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1922 @ S4_v443+60]");
		object obj460 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1923 @ S4_v444+48]");
		object obj461 = 0;
		object obj462 = obj461 & 0x7FF;
		object obj463 = obj462 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1931 @ S5_v350 (should have been resolved before IL gen)");
		nint num97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1942 @ S4_v447 (Il2CppMethodInfo)+C]");
		object obj464 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1943 @ S4_v448+60]");
		object obj465 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1944 @ S4_v449+48]");
		object obj466 = 0;
		object obj467 = obj466 & 0x7FF;
		object obj468 = obj467 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1952 @ S5_v354 (should have been resolved before IL gen)");
		nint num98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1963 @ S4_v452 (Il2CppMethodInfo)+C]");
		object obj469 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ S4_v453+60]");
		object obj470 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1965 @ S4_v454+48]");
		object obj471 = 0;
		object obj472 = obj471 & 0x7FF;
		object obj473 = obj472 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1973 @ S5_v358 (should have been resolved before IL gen)");
		nint num99 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1984 @ S4_v457 (Il2CppMethodInfo)+C]");
		object obj474 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1985 @ S4_v458+60]");
		object obj475 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1986 @ S4_v459+48]");
		object obj476 = 0;
		object obj477 = obj476 & 0x7FF;
		object obj478 = obj477 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1994 @ S5_v362 (should have been resolved before IL gen)");
		nint num100 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2005 @ S4_v462 (Il2CppMethodInfo)+C]");
		object obj479 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2006 @ S4_v463+60]");
		object obj480 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2007 @ S4_v464+48]");
		object obj481 = 0;
		object obj482 = obj481 & 0x7FF;
		object obj483 = obj482 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2015 @ S5_v366 (should have been resolved before IL gen)");
		nint num101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2026 @ S4_v467 (Il2CppMethodInfo)+C]");
		object obj484 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2027 @ S4_v468+60]");
		object obj485 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2028 @ S4_v469+48]");
		object obj486 = 0;
		object obj487 = obj486 & 0x7FF;
		object obj488 = obj487 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2036 @ S5_v370 (should have been resolved before IL gen)");
		nint num102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2047 @ S4_v472 (Il2CppMethodInfo)+C]");
		object obj489 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2048 @ S4_v473+60]");
		object obj490 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2049 @ S4_v474+48]");
		object obj491 = 0;
		object obj492 = obj491 & 0x7FF;
		object obj493 = obj492 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2057 @ S5_v374 (should have been resolved before IL gen)");
		nint num103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2068 @ S4_v477 (Il2CppMethodInfo)+C]");
		object obj494 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2069 @ S4_v478+60]");
		object obj495 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2070 @ S4_v479+48]");
		object obj496 = 0;
		object obj497 = obj496 & 0x7FF;
		object obj498 = obj497 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2078 @ S5_v378 (should have been resolved before IL gen)");
		nint num104 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2089 @ S4_v482 (Il2CppMethodInfo)+C]");
		object obj499 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2090 @ S4_v483+60]");
		object obj500 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2091 @ S4_v484+48]");
		object obj501 = 0;
		object obj502 = obj501 & 0x7FF;
		object obj503 = obj502 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2099 @ S5_v382 (should have been resolved before IL gen)");
		nint num105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2110 @ S4_v487 (Il2CppMethodInfo)+C]");
		object obj504 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2111 @ S4_v488+60]");
		object obj505 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2112 @ S4_v489+48]");
		object obj506 = 0;
		object obj507 = obj506 & 0x7FF;
		object obj508 = obj507 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2120 @ S5_v386 (should have been resolved before IL gen)");
		nint num106 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2124 @ S1_v396 (Il2CppClass<AdLocations>)+5C]");
		object obj509 = -(-64);
		nint num107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2133 @ S4_v492 (Il2CppMethodInfo)+C]");
		object obj510 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2134 @ S4_v493+60]");
		object obj511 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2135 @ S4_v494+48]");
		object obj512 = 0;
		object obj513 = obj512 & 0x7FF;
		object obj514 = obj513 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2143 @ S5_v390 (should have been resolved before IL gen)");
		nint num108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2154 @ S4_v497 (Il2CppMethodInfo)+C]");
		object obj515 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2155 @ S4_v498+60]");
		object obj516 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2156 @ S4_v499+48]");
		object obj517 = 0;
		object obj518 = obj517 & 0x7FF;
		object obj519 = obj518 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2164 @ S5_v394 (should have been resolved before IL gen)");
		nint num109 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2175 @ S4_v502 (Il2CppMethodInfo)+C]");
		object obj520 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2176 @ S4_v503+60]");
		object obj521 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2177 @ S4_v504+48]");
		object obj522 = 0;
		object obj523 = obj522 & 0x7FF;
		object obj524 = obj523 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2185 @ S5_v398 (should have been resolved before IL gen)");
		nint num110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2196 @ S4_v507 (Il2CppMethodInfo)+C]");
		object obj525 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2197 @ S4_v508+60]");
		object obj526 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2198 @ S4_v509+48]");
		object obj527 = 0;
		object obj528 = obj527 & 0x7FF;
		object obj529 = obj528 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2206 @ S5_v402 (should have been resolved before IL gen)");
		nint num111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2217 @ S4_v512 (Il2CppMethodInfo)+C]");
		object obj530 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2218 @ S4_v513+60]");
		object obj531 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2219 @ S4_v514+48]");
		object obj532 = 0;
		object obj533 = obj532 & 0x7FF;
		object obj534 = obj533 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2227 @ S5_v406 (should have been resolved before IL gen)");
		object obj535 = this + 24;
		object obj536 = default;
		obj535 = obj536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2240 @ S3_v126 (Il2CppMethodInfo)+C]");
		object obj537 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2241 @ S3_v127+60]");
		object obj538 = 0;
		object obj539 = obj538;
		object obj540 = obj539 & 0x1FFF;
		object obj541 = obj540 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2250 @ S4_v519 (should have been resolved before IL gen)");
		nint num113 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2261 @ S4_v521 (Il2CppMethodInfo)+C]");
		object obj542 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2262 @ S4_v522+60]");
		object obj543 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2263 @ S4_v523+48]");
		object obj544 = 0;
		object obj545 = obj544 & 0x7FF;
		object obj546 = obj545 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2271 @ S5_v412 (should have been resolved before IL gen)");
		nint num114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2282 @ S4_v526 (Il2CppMethodInfo)+C]");
		object obj547 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2283 @ S4_v527+60]");
		object obj548 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2284 @ S4_v528+48]");
		object obj549 = 0;
		object obj550 = obj549 & 0x7FF;
		object obj551 = obj550 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2292 @ S5_v416 (should have been resolved before IL gen)");
		nint num115 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2303 @ S4_v531 (Il2CppMethodInfo)+C]");
		object obj552 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2304 @ S4_v532+60]");
		object obj553 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2305 @ S4_v533+48]");
		object obj554 = 0;
		object obj555 = obj554 & 0x7FF;
		object obj556 = obj555 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2313 @ S5_v420 (should have been resolved before IL gen)");
		nint num116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2324 @ S4_v536 (Il2CppMethodInfo)+C]");
		object obj557 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2325 @ S4_v537+60]");
		object obj558 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2326 @ S4_v538+48]");
		object obj559 = 0;
		object obj560 = obj559 & 0x7FF;
		object obj561 = obj560 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2334 @ S5_v424 (should have been resolved before IL gen)");
		nint num117 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2345 @ S4_v541 (Il2CppMethodInfo)+C]");
		object obj562 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2346 @ S4_v542+60]");
		object obj563 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2347 @ S4_v543+48]");
		object obj564 = 0;
		object obj565 = obj564 & 0x7FF;
		object obj566 = obj565 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2355 @ S5_v428 (should have been resolved before IL gen)");
		nint num118 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2366 @ S4_v546 (Il2CppMethodInfo)+C]");
		object obj567 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2367 @ S4_v547+60]");
		object obj568 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2368 @ S4_v548+48]");
		object obj569 = 0;
		object obj570 = obj569 & 0x7FF;
		object obj571 = obj570 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2376 @ S5_v432 (should have been resolved before IL gen)");
		nint num119 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2387 @ S4_v551 (Il2CppMethodInfo)+C]");
		object obj572 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2388 @ S4_v552+60]");
		object obj573 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2389 @ S4_v553+48]");
		object obj574 = 0;
		object obj575 = obj574 & 0x7FF;
		object obj576 = obj575 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2397 @ S5_v436 (should have been resolved before IL gen)");
		nint num120 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2408 @ S4_v556 (Il2CppMethodInfo)+C]");
		object obj577 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2409 @ S4_v557+60]");
		object obj578 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2410 @ S4_v558+48]");
		object obj579 = 0;
		object obj580 = obj579 & 0x7FF;
		object obj581 = obj580 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2418 @ S5_v440 (should have been resolved before IL gen)");
		nint num121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2429 @ S4_v561 (Il2CppMethodInfo)+C]");
		object obj582 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2430 @ S4_v562+60]");
		object obj583 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2431 @ S4_v563+48]");
		object obj584 = 0;
		object obj585 = obj584 & 0x7FF;
		object obj586 = obj585 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2439 @ S5_v444 (should have been resolved before IL gen)");
		nint num122 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2450 @ S4_v566 (Il2CppMethodInfo)+C]");
		object obj587 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2451 @ S4_v567+60]");
		object obj588 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2452 @ S4_v568+48]");
		object obj589 = 0;
		object obj590 = obj589 & 0x7FF;
		object obj591 = obj590 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2460 @ S5_v448 (should have been resolved before IL gen)");
		nint num123 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2471 @ S4_v571 (Il2CppMethodInfo)+C]");
		object obj592 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2472 @ S4_v572+60]");
		object obj593 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2473 @ S4_v573+48]");
		object obj594 = 0;
		object obj595 = obj594 & 0x7FF;
		object obj596 = obj595 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2481 @ S5_v452 (should have been resolved before IL gen)");
		nint num124 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2485 @ S1_v464 (Il2CppClass<AdLocations>)+5C]");
		object obj597 = -(-64);
		nint num125 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2494 @ S4_v576 (Il2CppMethodInfo)+C]");
		object obj598 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2495 @ S4_v577+60]");
		object obj599 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2496 @ S4_v578+48]");
		object obj600 = 0;
		object obj601 = obj600 & 0x7FF;
		object obj602 = obj601 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2504 @ S5_v456 (should have been resolved before IL gen)");
		nint num126 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2515 @ S4_v581 (Il2CppMethodInfo)+C]");
		object obj603 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2516 @ S4_v582+60]");
		object obj604 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2517 @ S4_v583+48]");
		object obj605 = 0;
		object obj606 = obj605 & 0x7FF;
		object obj607 = obj606 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2525 @ S5_v460 (should have been resolved before IL gen)");
		nint num127 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2536 @ S4_v586 (Il2CppMethodInfo)+C]");
		object obj608 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2537 @ S4_v587+60]");
		object obj609 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2538 @ S4_v588+48]");
		object obj610 = 0;
		object obj611 = obj610 & 0x7FF;
		object obj612 = obj611 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2546 @ S5_v464 (should have been resolved before IL gen)");
		nint num128 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2557 @ S4_v591 (Il2CppMethodInfo)+C]");
		object obj613 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2558 @ S4_v592+60]");
		object obj614 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2559 @ S4_v593+48]");
		object obj615 = 0;
		object obj616 = obj615 & 0x7FF;
		object obj617 = obj616 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2567 @ S5_v468 (should have been resolved before IL gen)");
		nint num129 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2578 @ S4_v596 (Il2CppMethodInfo)+C]");
		object obj618 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2579 @ S4_v597+60]");
		object obj619 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2580 @ S4_v598+48]");
		object obj620 = 0;
		object obj621 = obj620 & 0x7FF;
		object obj622 = obj621 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2588 @ S5_v472 (should have been resolved before IL gen)");
		nint num130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2599 @ S4_v601 (Il2CppMethodInfo)+C]");
		object obj623 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2600 @ S4_v602+60]");
		object obj624 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2601 @ S4_v603+48]");
		object obj625 = 0;
		object obj626 = obj625 & 0x7FF;
		object obj627 = obj626 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2609 @ S5_v476 (should have been resolved before IL gen)");
		nint num131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2620 @ S4_v606 (Il2CppMethodInfo)+C]");
		object obj628 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2621 @ S4_v607+60]");
		object obj629 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2622 @ S4_v608+48]");
		object obj630 = 0;
		object obj631 = obj630 & 0x7FF;
		object obj632 = obj631 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2630 @ S5_v480 (should have been resolved before IL gen)");
		nint num132 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2641 @ S4_v611 (Il2CppMethodInfo)+C]");
		object obj633 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2642 @ S4_v612+60]");
		object obj634 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2643 @ S4_v613+48]");
		object obj635 = 0;
		object obj636 = obj635 & 0x7FF;
		object obj637 = obj636 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2651 @ S5_v484 (should have been resolved before IL gen)");
		nint num133 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2662 @ S4_v616 (Il2CppMethodInfo)+C]");
		object obj638 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2663 @ S4_v617+60]");
		object obj639 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2664 @ S4_v618+48]");
		object obj640 = 0;
		object obj641 = obj640 & 0x7FF;
		object obj642 = obj641 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2672 @ S5_v488 (should have been resolved before IL gen)");
		object obj643 = this + 28;
		object obj644 = default;
		obj643 = obj644;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num134 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2685 @ S3_v151 (Il2CppMethodInfo)+C]");
		object obj645 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2686 @ S3_v152+60]");
		object obj646 = 0;
		object obj647 = obj646;
		object obj648 = obj647 & 0x1FFF;
		object obj649 = obj648 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2695 @ S4_v623 (should have been resolved before IL gen)");
		nint num135 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2706 @ S4_v625 (Il2CppMethodInfo)+C]");
		object obj650 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2707 @ S4_v626+60]");
		object obj651 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2708 @ S4_v627+48]");
		object obj652 = 0;
		object obj653 = obj652 & 0x7FF;
		object obj654 = obj653 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2716 @ S5_v494 (should have been resolved before IL gen)");
		nint num136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2727 @ S4_v630 (Il2CppMethodInfo)+C]");
		object obj655 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2728 @ S4_v631+60]");
		object obj656 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2729 @ S4_v632+48]");
		object obj657 = 0;
		object obj658 = obj657 & 0x7FF;
		object obj659 = obj658 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2737 @ S5_v498 (should have been resolved before IL gen)");
		nint num137 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2748 @ S4_v635 (Il2CppMethodInfo)+C]");
		object obj660 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2749 @ S4_v636+60]");
		object obj661 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2750 @ S4_v637+48]");
		object obj662 = 0;
		object obj663 = obj662 & 0x7FF;
		object obj664 = obj663 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2758 @ S5_v502 (should have been resolved before IL gen)");
		nint num138 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2769 @ S4_v640 (Il2CppMethodInfo)+C]");
		object obj665 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2770 @ S4_v641+60]");
		object obj666 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2771 @ S4_v642+48]");
		object obj667 = 0;
		object obj668 = obj667 & 0x7FF;
		object obj669 = obj668 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2779 @ S5_v506 (should have been resolved before IL gen)");
		nint num139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2790 @ S4_v645 (Il2CppMethodInfo)+C]");
		object obj670 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2791 @ S4_v646+60]");
		object obj671 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2792 @ S4_v647+48]");
		object obj672 = 0;
		object obj673 = obj672 & 0x7FF;
		object obj674 = obj673 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2800 @ S5_v510 (should have been resolved before IL gen)");
		nint num140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2811 @ S4_v650 (Il2CppMethodInfo)+C]");
		object obj675 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2812 @ S4_v651+60]");
		object obj676 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2813 @ S4_v652+48]");
		object obj677 = 0;
		object obj678 = obj677 & 0x7FF;
		object obj679 = obj678 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2821 @ S5_v514 (should have been resolved before IL gen)");
		nint num141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2832 @ S4_v655 (Il2CppMethodInfo)+C]");
		object obj680 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2833 @ S4_v656+60]");
		object obj681 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2834 @ S4_v657+48]");
		object obj682 = 0;
		object obj683 = obj682 & 0x7FF;
		object obj684 = obj683 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2842 @ S5_v518 (should have been resolved before IL gen)");
		nint num142 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2853 @ S4_v660 (Il2CppMethodInfo)+C]");
		object obj685 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2854 @ S4_v661+60]");
		object obj686 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2855 @ S4_v662+48]");
		object obj687 = 0;
		object obj688 = obj687 & 0x7FF;
		object obj689 = obj688 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2863 @ S5_v522 (should have been resolved before IL gen)");
		nint num143 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2874 @ S4_v665 (Il2CppMethodInfo)+C]");
		object obj690 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2875 @ S4_v666+60]");
		object obj691 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2876 @ S4_v667+48]");
		object obj692 = 0;
		object obj693 = obj692 & 0x7FF;
		object obj694 = obj693 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2884 @ S5_v526 (should have been resolved before IL gen)");
		nint num144 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2895 @ S4_v670 (Il2CppMethodInfo)+C]");
		object obj695 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2896 @ S4_v671+60]");
		object obj696 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2897 @ S4_v672+48]");
		object obj697 = 0;
		object obj698 = obj697 & 0x7FF;
		object obj699 = obj698 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2905 @ S5_v530 (should have been resolved before IL gen)");
		nint num145 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2916 @ S4_v675 (Il2CppMethodInfo)+C]");
		object obj700 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2917 @ S4_v676+60]");
		object obj701 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2918 @ S4_v677+48]");
		object obj702 = 0;
		object obj703 = obj702 & 0x7FF;
		object obj704 = obj703 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2926 @ S5_v534 (should have been resolved before IL gen)");
		nint num146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2937 @ S4_v680 (Il2CppMethodInfo)+C]");
		object obj705 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2938 @ S4_v681+60]");
		object obj706 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2939 @ S4_v682+48]");
		object obj707 = 0;
		object obj708 = obj707 & 0x7FF;
		object obj709 = obj708 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2947 @ S5_v538 (should have been resolved before IL gen)");
		nint num147 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2958 @ S4_v685 (Il2CppMethodInfo)+C]");
		object obj710 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2959 @ S4_v686+60]");
		object obj711 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2960 @ S4_v687+48]");
		object obj712 = 0;
		object obj713 = obj712 & 0x7FF;
		object obj714 = obj713 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2968 @ S5_v542 (should have been resolved before IL gen)");
		nint num148 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2979 @ S4_v690 (Il2CppMethodInfo)+C]");
		object obj715 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2980 @ S4_v691+60]");
		object obj716 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2981 @ S4_v692+48]");
		object obj717 = 0;
		object obj718 = obj717 & 0x7FF;
		object obj719 = obj718 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2989 @ S5_v546 (should have been resolved before IL gen)");
		nint num149 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2993 @ S1_v560 (Il2CppClass<AdLocations>)+5C]");
		object obj720 = -(-64);
		nint num150 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3002 @ S4_v695 (Il2CppMethodInfo)+C]");
		object obj721 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3003 @ S4_v696+60]");
		object obj722 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3004 @ S4_v697+48]");
		object obj723 = 0;
		object obj724 = obj723 & 0x7FF;
		object obj725 = obj724 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3012 @ S5_v550 (should have been resolved before IL gen)");
		nint num151 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3023 @ S4_v700 (Il2CppMethodInfo)+C]");
		object obj726 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3024 @ S4_v701+60]");
		object obj727 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3025 @ S4_v702+48]");
		object obj728 = 0;
		object obj729 = obj728 & 0x7FF;
		object obj730 = obj729 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3033 @ S5_v554 (should have been resolved before IL gen)");
		nint num152 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3044 @ S4_v705 (Il2CppMethodInfo)+C]");
		object obj731 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3045 @ S4_v706+60]");
		object obj732 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3046 @ S4_v707+48]");
		object obj733 = 0;
		object obj734 = obj733 & 0x7FF;
		object obj735 = obj734 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3054 @ S5_v558 (should have been resolved before IL gen)");
		nint num153 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3065 @ S4_v710 (Il2CppMethodInfo)+C]");
		object obj736 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3066 @ S4_v711+60]");
		object obj737 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3067 @ S4_v712+48]");
		object obj738 = 0;
		object obj739 = obj738 & 0x7FF;
		object obj740 = obj739 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3075 @ S5_v562 (should have been resolved before IL gen)");
		nint num154 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3086 @ S4_v715 (Il2CppMethodInfo)+C]");
		object obj741 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3087 @ S4_v716+60]");
		object obj742 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3088 @ S4_v717+48]");
		object obj743 = 0;
		object obj744 = obj743 & 0x7FF;
		object obj745 = obj744 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3096 @ S5_v566 (should have been resolved before IL gen)");
		nint num155 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3107 @ S4_v720 (Il2CppMethodInfo)+C]");
		object obj746 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3108 @ S4_v721+60]");
		object obj747 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3109 @ S4_v722+48]");
		object obj748 = 0;
		object obj749 = obj748 & 0x7FF;
		object obj750 = obj749 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3117 @ S5_v570 (should have been resolved before IL gen)");
		nint num156 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3128 @ S4_v725 (Il2CppMethodInfo)+C]");
		object obj751 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3129 @ S4_v726+60]");
		object obj752 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3130 @ S4_v727+48]");
		object obj753 = 0;
		object obj754 = obj753 & 0x7FF;
		object obj755 = obj754 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3138 @ S5_v574 (should have been resolved before IL gen)");
		nint num157 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3149 @ S4_v730 (Il2CppMethodInfo)+C]");
		object obj756 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3150 @ S4_v731+60]");
		object obj757 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3151 @ S4_v732+48]");
		object obj758 = 0;
		object obj759 = obj758 & 0x7FF;
		object obj760 = obj759 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3159 @ S5_v578 (should have been resolved before IL gen)");
		object obj761 = this + 32;
		object obj762 = default;
		obj761 = obj762;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num158 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3172 @ S3_v178 (Il2CppMethodInfo)+C]");
		object obj763 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3173 @ S3_v179+60]");
		object obj764 = 0;
		object obj765 = obj764;
		object obj766 = obj765 & 0x1FFF;
		object obj767 = obj766 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3182 @ S4_v737 (should have been resolved before IL gen)");
		nint num159 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3193 @ S4_v739 (Il2CppMethodInfo)+C]");
		object obj768 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3194 @ S4_v740+60]");
		object obj769 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3195 @ S4_v741+48]");
		object obj770 = 0;
		object obj771 = obj770 & 0x7FF;
		object obj772 = obj771 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3203 @ S5_v584 (should have been resolved before IL gen)");
		nint num160 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3214 @ S4_v744 (Il2CppMethodInfo)+C]");
		object obj773 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3215 @ S4_v745+60]");
		object obj774 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3216 @ S4_v746+48]");
		object obj775 = 0;
		object obj776 = obj775 & 0x7FF;
		object obj777 = obj776 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3224 @ S5_v588 (should have been resolved before IL gen)");
		nint num161 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3235 @ S4_v749 (Il2CppMethodInfo)+C]");
		object obj778 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3236 @ S4_v750+60]");
		object obj779 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3237 @ S4_v751+48]");
		object obj780 = 0;
		object obj781 = obj780 & 0x7FF;
		object obj782 = obj781 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3245 @ S5_v592 (should have been resolved before IL gen)");
		nint num162 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3256 @ S4_v754 (Il2CppMethodInfo)+C]");
		object obj783 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3257 @ S4_v755+60]");
		object obj784 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3258 @ S4_v756+48]");
		object obj785 = 0;
		object obj786 = obj785 & 0x7FF;
		object obj787 = obj786 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3266 @ S5_v596 (should have been resolved before IL gen)");
		nint num163 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3277 @ S4_v759 (Il2CppMethodInfo)+C]");
		object obj788 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3278 @ S4_v760+60]");
		object obj789 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3279 @ S4_v761+48]");
		object obj790 = 0;
		object obj791 = obj790 & 0x7FF;
		object obj792 = obj791 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3287 @ S5_v600 (should have been resolved before IL gen)");
		nint num164 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3298 @ S4_v764 (Il2CppMethodInfo)+C]");
		object obj793 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3299 @ S4_v765+60]");
		object obj794 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3300 @ S4_v766+48]");
		object obj795 = 0;
		object obj796 = obj795 & 0x7FF;
		object obj797 = obj796 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3308 @ S5_v604 (should have been resolved before IL gen)");
		nint num165 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3319 @ S4_v769 (Il2CppMethodInfo)+C]");
		object obj798 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3320 @ S4_v770+60]");
		object obj799 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3321 @ S4_v771+48]");
		object obj800 = 0;
		object obj801 = obj800 & 0x7FF;
		object obj802 = obj801 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3329 @ S5_v608 (should have been resolved before IL gen)");
		nint num166 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3340 @ S4_v774 (Il2CppMethodInfo)+C]");
		object obj803 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3341 @ S4_v775+60]");
		object obj804 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3342 @ S4_v776+48]");
		object obj805 = 0;
		object obj806 = obj805 & 0x7FF;
		object obj807 = obj806 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3350 @ S5_v612 (should have been resolved before IL gen)");
		nint num167 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3361 @ S4_v779 (Il2CppMethodInfo)+C]");
		object obj808 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3362 @ S4_v780+60]");
		object obj809 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3363 @ S4_v781+48]");
		object obj810 = 0;
		object obj811 = obj810 & 0x7FF;
		object obj812 = obj811 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3371 @ S5_v616 (should have been resolved before IL gen)");
		nint num168 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3382 @ S4_v784 (Il2CppMethodInfo)+C]");
		object obj813 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3383 @ S4_v785+60]");
		object obj814 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3384 @ S4_v786+48]");
		object obj815 = 0;
		object obj816 = obj815 & 0x7FF;
		object obj817 = obj816 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3392 @ S5_v620 (should have been resolved before IL gen)");
		nint num169 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3403 @ S4_v789 (Il2CppMethodInfo)+C]");
		object obj818 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3404 @ S4_v790+60]");
		object obj819 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3405 @ S4_v791+48]");
		object obj820 = 0;
		object obj821 = obj820 & 0x7FF;
		object obj822 = obj821 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3413 @ S5_v624 (should have been resolved before IL gen)");
		nint num170 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3424 @ S4_v794 (Il2CppMethodInfo)+C]");
		object obj823 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3425 @ S4_v795+60]");
		object obj824 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3426 @ S4_v796+48]");
		object obj825 = 0;
		object obj826 = obj825 & 0x7FF;
		object obj827 = obj826 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3434 @ S5_v628 (should have been resolved before IL gen)");
		nint num171 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3445 @ S4_v799 (Il2CppMethodInfo)+C]");
		object obj828 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3446 @ S4_v800+60]");
		object obj829 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3447 @ S4_v801+48]");
		object obj830 = 0;
		object obj831 = obj830 & 0x7FF;
		object obj832 = obj831 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3455 @ S5_v632 (should have been resolved before IL gen)");
		nint num172 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3459 @ S1_v648 (Il2CppClass<AdLocations>)+5C]");
		object obj833 = -(-64);
		nint num173 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3468 @ S4_v804 (Il2CppMethodInfo)+C]");
		object obj834 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3469 @ S4_v805+60]");
		object obj835 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3470 @ S4_v806+48]");
		object obj836 = 0;
		object obj837 = obj836 & 0x7FF;
		object obj838 = obj837 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3478 @ S5_v636 (should have been resolved before IL gen)");
		nint num174 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3489 @ S4_v809 (Il2CppMethodInfo)+C]");
		object obj839 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3490 @ S4_v810+60]");
		object obj840 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3491 @ S4_v811+48]");
		object obj841 = 0;
		object obj842 = obj841 & 0x7FF;
		object obj843 = obj842 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3499 @ S5_v640 (should have been resolved before IL gen)");
		nint num175 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3510 @ S4_v814 (Il2CppMethodInfo)+C]");
		object obj844 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3511 @ S4_v815+60]");
		object obj845 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3512 @ S4_v816+48]");
		object obj846 = 0;
		object obj847 = obj846 & 0x7FF;
		object obj848 = obj847 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3520 @ S5_v644 (should have been resolved before IL gen)");
		nint num176 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3531 @ S4_v819 (Il2CppMethodInfo)+C]");
		object obj849 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3532 @ S4_v820+60]");
		object obj850 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3533 @ S4_v821+48]");
		object obj851 = 0;
		object obj852 = obj851 & 0x7FF;
		object obj853 = obj852 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3541 @ S5_v648 (should have been resolved before IL gen)");
		nint num177 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3552 @ S4_v824 (Il2CppMethodInfo)+C]");
		object obj854 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3553 @ S4_v825+60]");
		object obj855 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3554 @ S4_v826+48]");
		object obj856 = 0;
		object obj857 = obj856 & 0x7FF;
		object obj858 = obj857 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3562 @ S5_v652 (should have been resolved before IL gen)");
		nint num178 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3573 @ S4_v829 (Il2CppMethodInfo)+C]");
		object obj859 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3574 @ S4_v830+60]");
		object obj860 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3575 @ S4_v831+48]");
		object obj861 = 0;
		object obj862 = obj861 & 0x7FF;
		object obj863 = obj862 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3583 @ S5_v656 (should have been resolved before IL gen)");
		nint num179 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3594 @ S4_v834 (Il2CppMethodInfo)+C]");
		object obj864 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3595 @ S4_v835+60]");
		object obj865 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3596 @ S4_v836+48]");
		object obj866 = 0;
		object obj867 = obj866 & 0x7FF;
		object obj868 = obj867 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3604 @ S5_v660 (should have been resolved before IL gen)");
		nint num180 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3615 @ S4_v839 (Il2CppMethodInfo)+C]");
		object obj869 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3616 @ S4_v840+60]");
		object obj870 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3617 @ S4_v841+48]");
		object obj871 = 0;
		object obj872 = obj871 & 0x7FF;
		object obj873 = obj872 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3625 @ S5_v664 (should have been resolved before IL gen)");
		nint num181 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3636 @ S4_v844 (Il2CppMethodInfo)+C]");
		object obj874 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3637 @ S4_v845+60]");
		object obj875 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3638 @ S4_v846+48]");
		object obj876 = 0;
		object obj877 = obj876 & 0x7FF;
		object obj878 = obj877 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3646 @ S5_v668 (should have been resolved before IL gen)");
		object obj879 = this + 36;
		object obj880 = default;
		obj879 = obj880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num182 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3659 @ S3_v205 (Il2CppMethodInfo)+C]");
		object obj881 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3660 @ S3_v206+60]");
		object obj882 = 0;
		object obj883 = obj882;
		object obj884 = obj883 & 0x1FFF;
		object obj885 = obj884 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3669 @ S4_v851 (should have been resolved before IL gen)");
		nint num183 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3680 @ S4_v853 (Il2CppMethodInfo)+C]");
		object obj886 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3681 @ S4_v854+60]");
		object obj887 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3682 @ S4_v855+48]");
		object obj888 = 0;
		object obj889 = obj888 & 0x7FF;
		object obj890 = obj889 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3690 @ S5_v674 (should have been resolved before IL gen)");
		nint num184 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3701 @ S4_v858 (Il2CppMethodInfo)+C]");
		object obj891 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3702 @ S4_v859+60]");
		object obj892 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3703 @ S4_v860+48]");
		object obj893 = 0;
		object obj894 = obj893 & 0x7FF;
		object obj895 = obj894 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3711 @ S5_v678 (should have been resolved before IL gen)");
		nint num185 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3722 @ S4_v863 (Il2CppMethodInfo)+C]");
		object obj896 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3723 @ S4_v864+60]");
		object obj897 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3724 @ S4_v865+48]");
		object obj898 = 0;
		object obj899 = obj898 & 0x7FF;
		object obj900 = obj899 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3732 @ S5_v682 (should have been resolved before IL gen)");
		nint num186 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3743 @ S4_v868 (Il2CppMethodInfo)+C]");
		object obj901 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3744 @ S4_v869+60]");
		object obj902 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3745 @ S4_v870+48]");
		object obj903 = 0;
		object obj904 = obj903 & 0x7FF;
		object obj905 = obj904 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3753 @ S5_v686 (should have been resolved before IL gen)");
		nint num187 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3764 @ S4_v873 (Il2CppMethodInfo)+C]");
		object obj906 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3765 @ S4_v874+60]");
		object obj907 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3766 @ S4_v875+48]");
		object obj908 = 0;
		object obj909 = obj908 & 0x7FF;
		object obj910 = obj909 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3774 @ S5_v690 (should have been resolved before IL gen)");
		nint num188 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3785 @ S4_v878 (Il2CppMethodInfo)+C]");
		object obj911 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3786 @ S4_v879+60]");
		object obj912 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3787 @ S4_v880+48]");
		object obj913 = 0;
		object obj914 = obj913 & 0x7FF;
		object obj915 = obj914 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3795 @ S5_v694 (should have been resolved before IL gen)");
		nint num189 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3806 @ S4_v883 (Il2CppMethodInfo)+C]");
		object obj916 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3807 @ S4_v884+60]");
		object obj917 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3808 @ S4_v885+48]");
		object obj918 = 0;
		object obj919 = obj918 & 0x7FF;
		object obj920 = obj919 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3816 @ S5_v698 (should have been resolved before IL gen)");
		nint num190 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3827 @ S4_v888 (Il2CppMethodInfo)+C]");
		object obj921 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3828 @ S4_v889+60]");
		object obj922 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3829 @ S4_v890+48]");
		object obj923 = 0;
		object obj924 = obj923 & 0x7FF;
		object obj925 = obj924 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3837 @ S5_v702 (should have been resolved before IL gen)");
		nint num191 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3848 @ S4_v893 (Il2CppMethodInfo)+C]");
		object obj926 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3849 @ S4_v894+60]");
		object obj927 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3850 @ S4_v895+48]");
		object obj928 = 0;
		object obj929 = obj928 & 0x7FF;
		object obj930 = obj929 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3858 @ S5_v706 (should have been resolved before IL gen)");
		nint num192 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3869 @ S4_v898 (Il2CppMethodInfo)+C]");
		object obj931 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3870 @ S4_v899+60]");
		object obj932 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3871 @ S4_v900+48]");
		object obj933 = 0;
		object obj934 = obj933 & 0x7FF;
		object obj935 = obj934 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3879 @ S5_v710 (should have been resolved before IL gen)");
		nint num193 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3890 @ S4_v903 (Il2CppMethodInfo)+C]");
		object obj936 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3891 @ S4_v904+60]");
		object obj937 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3892 @ S4_v905+48]");
		object obj938 = 0;
		object obj939 = obj938 & 0x7FF;
		object obj940 = obj939 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3900 @ S5_v714 (should have been resolved before IL gen)");
		nint num194 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3911 @ S4_v908 (Il2CppMethodInfo)+C]");
		object obj941 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3912 @ S4_v909+60]");
		object obj942 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3913 @ S4_v910+48]");
		object obj943 = 0;
		object obj944 = obj943 & 0x7FF;
		object obj945 = obj944 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3921 @ S5_v718 (should have been resolved before IL gen)");
		nint num195 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3932 @ S4_v913 (Il2CppMethodInfo)+C]");
		object obj946 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3933 @ S4_v914+60]");
		object obj947 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3934 @ S4_v915+48]");
		object obj948 = 0;
		object obj949 = obj948 & 0x7FF;
		object obj950 = obj949 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3942 @ S5_v722 (should have been resolved before IL gen)");
		nint num196 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3946 @ S1_v740 (Il2CppClass<AdLocations>)+5C]");
		object obj951 = -(-64);
		nint num197 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3955 @ S4_v918 (Il2CppMethodInfo)+C]");
		object obj952 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3956 @ S4_v919+60]");
		object obj953 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3957 @ S4_v920+48]");
		object obj954 = 0;
		object obj955 = obj954 & 0x7FF;
		object obj956 = obj955 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3965 @ S5_v726 (should have been resolved before IL gen)");
		nint num198 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3976 @ S4_v923 (Il2CppMethodInfo)+C]");
		object obj957 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3977 @ S4_v924+60]");
		object obj958 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3978 @ S4_v925+48]");
		object obj959 = 0;
		object obj960 = obj959 & 0x7FF;
		object obj961 = obj960 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3986 @ S5_v730 (should have been resolved before IL gen)");
		nint num199 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3997 @ S4_v928 (Il2CppMethodInfo)+C]");
		object obj962 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3998 @ S4_v929+60]");
		object obj963 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3999 @ S4_v930+48]");
		object obj964 = 0;
		object obj965 = obj964 & 0x7FF;
		object obj966 = obj965 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4007 @ S5_v734 (should have been resolved before IL gen)");
		nint num200 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4018 @ S4_v933 (Il2CppMethodInfo)+C]");
		object obj967 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4019 @ S4_v934+60]");
		object obj968 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4020 @ S4_v935+48]");
		object obj969 = 0;
		object obj970 = obj969 & 0x7FF;
		object obj971 = obj970 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4028 @ S5_v738 (should have been resolved before IL gen)");
		nint num201 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4039 @ S4_v938 (Il2CppMethodInfo)+C]");
		object obj972 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4040 @ S4_v939+60]");
		object obj973 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4041 @ S4_v940+48]");
		object obj974 = 0;
		object obj975 = obj974 & 0x7FF;
		object obj976 = obj975 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4049 @ S5_v742 (should have been resolved before IL gen)");
		nint num202 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4060 @ S4_v943 (Il2CppMethodInfo)+C]");
		object obj977 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4061 @ S4_v944+60]");
		object obj978 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4062 @ S4_v945+48]");
		object obj979 = 0;
		object obj980 = obj979 & 0x7FF;
		object obj981 = obj980 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4070 @ S5_v746 (should have been resolved before IL gen)");
		nint num203 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4081 @ S4_v948 (Il2CppMethodInfo)+C]");
		object obj982 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4082 @ S4_v949+60]");
		object obj983 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4083 @ S4_v950+48]");
		object obj984 = 0;
		object obj985 = obj984 & 0x7FF;
		object obj986 = obj985 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4091 @ S5_v750 (should have been resolved before IL gen)");
		object obj987 = this + 40;
		object obj988 = default;
		obj987 = obj988;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num204 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4104 @ S3_v230 (Il2CppMethodInfo)+C]");
		object obj989 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4105 @ S3_v231+60]");
		object obj990 = 0;
		object obj991 = obj990;
		object obj992 = obj991 & 0x1FFF;
		object obj993 = obj992 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4114 @ S4_v955 (should have been resolved before IL gen)");
		nint num205 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4125 @ S4_v957 (Il2CppMethodInfo)+C]");
		object obj994 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4126 @ S4_v958+60]");
		object obj995 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4127 @ S4_v959+48]");
		object obj996 = 0;
		object obj997 = obj996 & 0x7FF;
		object obj998 = obj997 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4135 @ S5_v756 (should have been resolved before IL gen)");
		nint num206 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4146 @ S4_v962 (Il2CppMethodInfo)+C]");
		object obj999 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4147 @ S4_v963+60]");
		object obj1000 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4148 @ S4_v964+48]");
		object obj1001 = 0;
		object obj1002 = obj1001 & 0x7FF;
		object obj1003 = obj1002 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4156 @ S5_v760 (should have been resolved before IL gen)");
		nint num207 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4167 @ S4_v967 (Il2CppMethodInfo)+C]");
		object obj1004 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4168 @ S4_v968+60]");
		object obj1005 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4169 @ S4_v969+48]");
		object obj1006 = 0;
		object obj1007 = obj1006 & 0x7FF;
		object obj1008 = obj1007 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4177 @ S5_v764 (should have been resolved before IL gen)");
		nint num208 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4188 @ S4_v972 (Il2CppMethodInfo)+C]");
		object obj1009 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4189 @ S4_v973+60]");
		object obj1010 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4190 @ S4_v974+48]");
		object obj1011 = 0;
		object obj1012 = obj1011 & 0x7FF;
		object obj1013 = obj1012 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4198 @ S5_v768 (should have been resolved before IL gen)");
		nint num209 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4209 @ S4_v977 (Il2CppMethodInfo)+C]");
		object obj1014 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4210 @ S4_v978+60]");
		object obj1015 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4211 @ S4_v979+48]");
		object obj1016 = 0;
		object obj1017 = obj1016 & 0x7FF;
		object obj1018 = obj1017 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4219 @ S5_v772 (should have been resolved before IL gen)");
		nint num210 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4230 @ S4_v982 (Il2CppMethodInfo)+C]");
		object obj1019 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4231 @ S4_v983+60]");
		object obj1020 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4232 @ S4_v984+48]");
		object obj1021 = 0;
		object obj1022 = obj1021 & 0x7FF;
		object obj1023 = obj1022 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4240 @ S5_v776 (should have been resolved before IL gen)");
		nint num211 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4251 @ S4_v987 (Il2CppMethodInfo)+C]");
		object obj1024 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4252 @ S4_v988+60]");
		object obj1025 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4253 @ S4_v989+48]");
		object obj1026 = 0;
		object obj1027 = obj1026 & 0x7FF;
		object obj1028 = obj1027 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4261 @ S5_v780 (should have been resolved before IL gen)");
		nint num212 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4272 @ S4_v992 (Il2CppMethodInfo)+C]");
		object obj1029 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4273 @ S4_v993+60]");
		object obj1030 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4274 @ S4_v994+48]");
		object obj1031 = 0;
		object obj1032 = obj1031 & 0x7FF;
		object obj1033 = obj1032 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4282 @ S5_v784 (should have been resolved before IL gen)");
		nint num213 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4293 @ S4_v997 (Il2CppMethodInfo)+C]");
		object obj1034 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4294 @ S4_v998+60]");
		object obj1035 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4295 @ S4_v999+48]");
		object obj1036 = 0;
		object obj1037 = obj1036 & 0x7FF;
		object obj1038 = obj1037 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4303 @ S5_v788 (should have been resolved before IL gen)");
		nint num214 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4314 @ S4_v1002 (Il2CppMethodInfo)+C]");
		object obj1039 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4315 @ S4_v1003+60]");
		object obj1040 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4316 @ S4_v1004+48]");
		object obj1041 = 0;
		object obj1042 = obj1041 & 0x7FF;
		object obj1043 = obj1042 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4324 @ S5_v792 (should have been resolved before IL gen)");
		nint num215 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4335 @ S4_v1007 (Il2CppMethodInfo)+C]");
		object obj1044 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4336 @ S4_v1008+60]");
		object obj1045 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4337 @ S4_v1009+48]");
		object obj1046 = 0;
		object obj1047 = obj1046 & 0x7FF;
		object obj1048 = obj1047 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4345 @ S5_v796 (should have been resolved before IL gen)");
		nint num216 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4356 @ S4_v1012 (Il2CppMethodInfo)+C]");
		object obj1049 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4357 @ S4_v1013+60]");
		object obj1050 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4358 @ S4_v1014+48]");
		object obj1051 = 0;
		object obj1052 = obj1051 & 0x7FF;
		object obj1053 = obj1052 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4366 @ S5_v800 (should have been resolved before IL gen)");
		nint num217 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4377 @ S4_v1017 (Il2CppMethodInfo)+C]");
		object obj1054 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4378 @ S4_v1018+60]");
		object obj1055 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4379 @ S4_v1019+48]");
		object obj1056 = 0;
		object obj1057 = obj1056 & 0x7FF;
		object obj1058 = obj1057 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4387 @ S5_v804 (should have been resolved before IL gen)");
		nint num218 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4391 @ S1_v824 (Il2CppClass<AdLocations>)+5C]");
		object obj1059 = -(-64);
		nint num219 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4400 @ S4_v1022 (Il2CppMethodInfo)+C]");
		object obj1060 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4401 @ S4_v1023+60]");
		object obj1061 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4402 @ S4_v1024+48]");
		object obj1062 = 0;
		object obj1063 = obj1062 & 0x7FF;
		object obj1064 = obj1063 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4410 @ S5_v808 (should have been resolved before IL gen)");
		nint num220 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4421 @ S4_v1027 (Il2CppMethodInfo)+C]");
		object obj1065 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4422 @ S4_v1028+60]");
		object obj1066 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4423 @ S4_v1029+48]");
		object obj1067 = 0;
		object obj1068 = obj1067 & 0x7FF;
		object obj1069 = obj1068 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4431 @ S5_v812 (should have been resolved before IL gen)");
		nint num221 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4442 @ S4_v1032 (Il2CppMethodInfo)+C]");
		object obj1070 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4443 @ S4_v1033+60]");
		object obj1071 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4444 @ S4_v1034+48]");
		object obj1072 = 0;
		object obj1073 = obj1072 & 0x7FF;
		object obj1074 = obj1073 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4452 @ S5_v816 (should have been resolved before IL gen)");
		nint num222 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4463 @ S4_v1037 (Il2CppMethodInfo)+C]");
		object obj1075 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4464 @ S4_v1038+60]");
		object obj1076 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4465 @ S4_v1039+48]");
		object obj1077 = 0;
		object obj1078 = obj1077 & 0x7FF;
		object obj1079 = obj1078 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4473 @ S5_v820 (should have been resolved before IL gen)");
		nint num223 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4484 @ S4_v1042 (Il2CppMethodInfo)+C]");
		object obj1080 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4485 @ S4_v1043+60]");
		object obj1081 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4486 @ S4_v1044+48]");
		object obj1082 = 0;
		object obj1083 = obj1082 & 0x7FF;
		object obj1084 = obj1083 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4494 @ S5_v824 (should have been resolved before IL gen)");
		object obj1085 = this + 44;
		object obj1086 = default;
		obj1085 = obj1086;
	}
}
