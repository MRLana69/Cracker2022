using System;
using System.Collections;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Ads;

public class AdProviderConfiguration
{
	private bool isRestricted__BackingField;

	private string appID__BackingField;

	private string appSDKKey__BackingField;

	private string appSignature__BackingField;

	private string[] zoneIDs__BackingField;

	public bool isRestricted
	{
		get
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected I4, but got Unknown
			if (~(isRestricted__BackingField ? 1u : 0u) == 0)
			{
				bool flag = isRestricted__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v6 (System.Boolean)+18]");
				if ((nint)0 == 2)
				{
					bool flag2 = isRestricted__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v12 (System.Boolean)+28]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj = default;
						return (byte)(obj ^ 1) != 0;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		set
		{
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected Obj, but got Unknown
			//IL_007c: Expected Obj, but got I4
			//IL_0029: Expected Obj, but got I
			//IL_003e: Expected Obj, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected Obj, but got Unknown
			//IL_0064: Expected Obj, but got I4
			if (value)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdProviderConfiguration)+24]");
				object obj = 0;
				bool flag = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v6+C]");
				if (!AbstractAdProvider.IsProviderSupportedOnPlatform((string)flag, AdType.Interstitial))
				{
					object obj2 = this + 8;
					obj2 = 0;
					return;
				}
			}
			object obj3 = this + 8;
			obj3 = value;
		}
	}

	public string appID
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = isRestricted__BackingField;
			return (string)flag;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			isRestricted__BackingField = flag;
		}
	}

	public string appSDKKey
	{
		get
		{
			return appID__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
		}
	}

	public string appSignature
	{
		get
		{
			return appSDKKey__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public string[] zoneIDs
	{
		get
		{
			return (string[])(object)appSignature__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 20;
			obj = value;
		}
	}

	public string initializePlacementId
	{
		get
		{
			return (string)(object)zoneIDs__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
		}
	}

	public AdProviderConfiguration()
	{
		//IL_0102: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0170: Expected I, but got Obj
		//IL_01d9: Expected Obj, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0207: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I4
		//IL_00a2: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I4
		if (~(isRestricted__BackingField ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = default;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdProviderConfiguration)+24]");
				object obj2 = 0;
				bool flag = ((AdLocation)this).IsCached();
				bool flag2 = isRestricted__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v16+C]");
				IEnumerator enumerator = ((DebugAdProvider)flag2).CacheInterstitialCoroutine((string)0, (string)flag);
				if (enumerator != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdProviderConfiguration)+24]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdProviderConfiguration)+24]");
					object obj4 = 0;
					bool flag3 = ((AdLocation)this).IsCached();
					bool flag4 = isRestricted__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v19+C]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v9+8]");
					((AbstractAdProvider)flag4).FailedToCacheAd((AdType)num, (string)0, (string)flag3);
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdProviderConfiguration)+20]");
			CoroutineUtil.StopCoroutine((Coroutine)0);
			object obj5 = this + 32;
			IEnumerator enumerator2 = ((AdLocation)this).CacheCoroutine();
			obj5 = enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdProviderConfiguration)+20]");
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])0);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AdProviderConfiguration)+24]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4+8]");
		object obj7 = ((IConvertible)"Unable to cache adLocationId ").ToType((Type)0, (IFormatProvider)(object)", provider was null");
		nint num2 = (nint)typeof(AdSystemLog);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v12 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v15 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
