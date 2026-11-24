using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2ILInjected;
using Kiloo;
using SYBO.Common;
using SYBO.Components.Logging;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Analytics;

public class SyboRandom
{
	private IRandomGen _randomGen;

	public static IRandomGen MakeRandomGen()
	{
		//IL_0066: Expected I4, but got Obj
		//IL_0066: Expected I4, but got Obj
		//IL_0034: Expected I4, but got Obj
		//IL_0038: Expected Obj, but got I4
		string graphicsDeviceVersion = SystemInfo.GetGraphicsDeviceVersion();
		string text = graphicsDeviceVersion.ToLowerInvariant();
		string text2 = text.Remove((int)"(tm)", (int)string.Empty);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		System.Text.RegularExpressions.ExclusiveReference exclusiveReference = default;
		exclusiveReference.Release((object)"[^a-z0-9]");
		return (IRandomGen)((System.Text.RegularExpressions.RegexBoyerMoore)(object)exclusiveReference).MatchPattern(text2, (int)"");
	}

	public SyboRandom()
	{
	}

	public SyboRandom(IRandomGen randomGen)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_1487: Expected Obj, but got Unknown
		//IL_1490: Expected Obj, but got I4
		//IL_14a7: Expected Obj, but got I4
		//IL_141b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1420: Expected Obj, but got Unknown
		//IL_1429: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected I, but got Unknown
		//IL_00c5: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_01ad: Expected Obj, but got I
		//IL_04d0: Expected Obj, but got I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_14d1: Expected I, but got Obj
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected Obj, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03f4: Expected Obj, but got I4
		//IL_1796: Unknown result type (might be due to invalid IL or missing references)
		//IL_179b: Expected Obj, but got Unknown
		//IL_0b2f: Expected Obj, but got I4
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1033: Expected Obj, but got Unknown
		//IL_134e: Expected I, but got Obj
		//IL_1364: Expected Obj, but got I
		//IL_1084: Expected I, but got Obj
		//IL_109a: Expected Obj, but got I
		//IL_1821: Expected I, but got Obj
		//IL_17b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bd: Expected Obj, but got Unknown
		//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Expected Obj, but got Unknown
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected Obj, but got Unknown
		//IL_0c0a: Expected Obj, but got I4
		//IL_138f: Expected I, but got Obj
		//IL_10c5: Expected I, but got Obj
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected Obj, but got Unknown
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Expected Obj, but got Unknown
		//IL_0bbd: Expected Obj, but got I4
		//IL_1160: Unknown result type (might be due to invalid IL or missing references)
		//IL_1165: Expected Obj, but got Unknown
		//IL_116d: Expected Obj, but got I
		//IL_1173: Unknown result type (might be due to invalid IL or missing references)
		//IL_1178: Expected Obj, but got Unknown
		//IL_11df: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e4: Expected Obj, but got Unknown
		//IL_0d05: Expected Obj, but got I
		//IL_0d99: Expected Obj, but got I
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Expected Obj, but got Unknown
		//IL_0e56: Expected Obj, but got I4
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Expected Obj, but got Unknown
		//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Expected Obj, but got Unknown
		//IL_0e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		object obj4 = 0;
		object obj5 = default;
		object obj7 = default;
		object obj16 = default;
		object obj19 = default;
		object obj20 = default;
		object obj23 = default;
		object obj26 = default;
		object obj27 = default;
		object obj28 = default;
		object obj29 = default;
		object obj31 = default;
		object obj48 = default;
		object obj49 = default;
		object obj52 = default;
		object obj55 = default;
		object obj58 = default;
		object obj59 = default;
		object obj60 = default;
		object obj61 = default;
		object obj62 = default;
		IntPtr intPtr2 = default;
		object obj70 = default;
		object obj73 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+3C]");
			object obj6;
			nint num;
			if ((nint)0 != 0)
			{
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				num = 0;
				if ((nint)obj5 < 1)
				{
					obj6 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj6 = obj7;
					num = 0;
				}
				nint num2 = (nint)(obj2 + 4);
				nint num3 = num2 + 1;
				num2 = num3;
				object obj8 = num3 << 2;
				object obj9 = obj2 + obj8;
				obj9 = 68;
				num = num3;
				if (obj3 != null)
				{
					throw new ArgumentNullException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj10 = (nint)0 << 2;
					object obj11 = obj2 + obj10;
					if ((nint)obj11 == 68)
					{
						object obj12 = obj2 + 4;
						if ((nint)obj12 > -1)
						{
							object obj13 = obj12 + -1;
							obj12 = obj13;
						}
						num = (nint)obj12;
						goto IL_0239;
					}
				}
				if (obj4 == null)
				{
					goto IL_0239;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				break;
			}
			object obj14 = this + 56;
			obj14 = 0;
			_ = 0;
			return;
			IL_14d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj15;
			object obj18;
			object obj17;
			if (obj15 != obj16)
			{
				obj17 = obj18;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object message = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num6;
			if (obj20 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				nint num4 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ S0_v73 (Il2CppClass<UnityEngine.Debug>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num5 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ S0_v78 (Il2CppClass<UnityEngine.Debug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Debug.LogWarning(message);
				num6 = (nint)typeof(Exception);
				goto IL_13ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
			object obj22 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			obj17 = obj23;
			break;
			IL_04e2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+3D]");
			bool flag = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			if (!flag)
			{
				object obj24 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				if (obj24 == null)
				{
					goto IL_1237;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+3D]");
			bool flag2 = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			if (flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				num6 = 1;
				object obj25 = obj26;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					nint intPtr = num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+30]");
					if (intPtr >= 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					nint num7 = num6 + 1;
					num6 = num7;
					obj25 = obj27;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				obj18 = obj28;
				obj15 = obj29;
				goto IL_14d6;
			}
			object obj30 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			if (obj30 == null)
			{
				goto IL_1237;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+30]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num6 = num;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+50]");
				bool flag5 = (nint)0 == 0;
				num6 = num;
				if (!flag5)
				{
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if ((nint)obj31 < 1)
					{
						object obj32 = obj2 + 4;
						object obj33 = obj32 + 1;
						obj32 = obj33;
						object obj34 = obj33 << 2;
						object obj35 = obj2 + obj34;
						obj35 = 536;
					}
					else
					{
						object obj36 = obj2 + 4;
						object obj37 = obj36 + 1;
						obj36 = obj37;
						object obj38 = obj37 << 2;
						object obj39 = obj2 + obj38;
						obj39 = 776;
					}
					if (obj3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						object obj40 = (nint)0 << 2;
						object obj41 = obj2 + obj40;
						if ((nint)obj41 == 776)
						{
							object obj42 = obj2 + 4;
							if ((nint)obj42 > -1)
							{
								object obj43 = obj42 + -1;
								obj42 = obj43;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+24]");
							num6 = 0;
							goto IL_13ce;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						object obj44 = (nint)0 << 2;
						object obj45 = obj2 + obj44;
						if ((nint)obj45 == 536)
						{
							object obj46 = obj2 + 4;
							if ((nint)obj46 > -1)
							{
								object obj47 = obj46 + -1;
								obj46 = obj47;
							}
							goto IL_0e6b;
						}
					}
					if (obj4 == null)
					{
						goto IL_0e6b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					obj4 = 0;
					obj18 = obj48;
					obj15 = obj29;
					goto IL_14d6;
				}
			}
			goto IL_1762;
			IL_0239:
			object obj57;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj49 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
					object obj50 = obj29 << 32;
					object obj51 = obj52 | obj50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+10]");
					if ((nint)obj51 <= 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
						object obj53 = obj29 << 32;
						object obj54 = obj55 | obj53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+48]");
						object obj56 = 0 + obj54;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+18]");
						if ((nint)obj56 < 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ L2_v4+C]");
							num = 0;
							obj57 = 0;
							goto IL_04e2;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					obj18 = obj58;
					obj15 = obj29;
					goto IL_14d6;
				}
				num6 = num;
				goto IL_13ce;
			}
			obj57 = 1;
			goto IL_04e2;
			IL_1237:
			bool flag6 = obj57 == null;
			num6 = num;
			if (flag6)
			{
				goto IL_13ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			num6 = num;
			if (obj59 != null)
			{
				goto IL_13ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj18 = obj60;
			obj15 = obj29;
			goto IL_14d6;
			IL_13ce:
			num = num6;
			continue;
			IL_0e6b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			bool flag7 = obj61 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+24]");
			num6 = 0;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				obj18 = obj62;
				obj15 = obj29;
				goto IL_14d6;
			}
			goto IL_1762;
			IL_1762:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+30]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj63 = this - -64;
				object obj64 = obj63;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1198 @ S0_v146+C]");
				_ = 0;
				nint num8 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1380 @ S0_v153 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj65 = (nint)0 & (nint)0x200;
				if (obj65 != null)
				{
					nint num9 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1419 @ S0_v185 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				object obj66 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj67 = obj66 + 16;
				obj67 = (nint)intPtr2;
				object obj68 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj69 = obj68 + 20;
				obj69 = obj70;
				num6 = intPtr2;
			}
			object obj71 = this - -64;
			object obj72 = obj71;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj18 = obj73;
			obj15 = obj29;
			goto IL_14d6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	public void SetGenerator(IRandomGen randomGen)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = randomGen;
	}

	public uint NextUint()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		bool hasWorkerThread = ((PersistentAnalyticsEventLog)this).HasWorkerThread;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
		object obj4 = default;
		object obj3 = obj4 << 32;
		object obj6 = default;
		object obj5 = obj6 | obj3;
		object obj9;
		if ((nint)obj5 > int.MaxValue)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj8 = default;
			object obj7 = obj8;
			obj9 = obj4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
			object obj10 = obj4 << 32;
			object obj12 = default;
			object obj11 = obj12 | obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj13 = default;
			object obj7 = obj13;
			obj9 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj14 = default;
		if (obj9 == obj14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		if (hasWorkerThread)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj2 + obj15;
			if ((nint)obj16 == 50)
			{
				object obj17 = obj2 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_02fd;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02fd;
		IL_02fd:
		uint result = default;
		return result;
	}

	public float NextFloat()
	{
		//IL_000d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+28]");
		return 0f;
	}

	public unsafe double NextDouble()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00ea: Expected Obj, but got VT
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected VT, but got Unknown
		//IL_010d: Expected I8, but got Obj
		//IL_0108: Expected native int or pointer, but got VT
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0130: Expected Ref, but got VT
		//IL_013c: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		DateTime today = CDateTime.Today;
		object obj3 = obj2 + 16;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v31 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 8;
		obj5 = today;
		obj2 = obj3;
		DateTime dateTime = (DateTime)(obj2 + 32);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 40);
		formatProvider = (IFormatProvider)obj2;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num3;
		return (double)obj * 1E-07;
	}

	public float Value()
	{
		bool flag = Bool();
		return (float)(flag ? 1 : 0) * 2.3283064E-10f;
	}

	public bool Bool()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		bool result = default;
		return result;
	}

	public int Range(int min, int max)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = min;
		object obj2 = num + 20;
		obj2 = max;
		return num;
	}

	public float Range(float min, float max)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public unsafe T RandomElement<T>(T[] array)
	{
		//IL_00b0: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_018e: Expected VT, but got Obj
		//IL_0013: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_0143: Expected Obj, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_017a: Expected VT, but got I4
		//IL_005c: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		int domainID = Thread.GetDomainID();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.SyboRandom)+14]");
		nint num = default;
		if ((nint)0 != domainID)
		{
			object obj = num + 12;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v19+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v13+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S2_v14+10]");
			object obj6 = 0;
			object obj7 = obj6 & 0x3FFF;
			object obj8 = obj7 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v12 (should have been resolved before IL gen)");
			ThreadedAlternatingReadWriteQueue<object> threadedAlternatingReadWriteQueue = default;
			threadedAlternatingReadWriteQueue.TryDequeue(out *(object*)null);
		}
		object obj9 = num + 12;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v7+60]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v8+14]");
		object obj12 = 0;
		object obj13 = obj12 & 0x3FFF;
		object obj14 = obj13 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v64 @ S2_v6 (should have been resolved before IL gen)");
		object obj15 = default;
		if (obj15 != null)
		{
			object obj16 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v9+60]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v10+1C]");
			object obj18 = 0;
			object obj19 = obj18 & 0x3FFF;
			object obj20 = obj19 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S3_v8 (should have been resolved before IL gen)");
			object obj21 = default;
			T[] array2 = (T[])obj21;
			return (T)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return (T)null;
	}

	public T RandomElementNoRepeats<T>(T[] array, T lastPickedElement) where T : class
	{
		//IL_00bd: Expected Obj, but got I4
		//IL_00ea: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		object result = 0;
		GameObject gameObject = ((Component)(object)array).gameObject;
		Transform transform = ((SpawnPool)this).Spawn(gameObject, (Transform)(object)lastPickedElement);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)transform).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v12+4]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v60 @ S2_v8 (should have been resolved before IL gen)");
			T result2 = default;
			return result2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return (T)result;
	}

	public T RandomElementNoRepeats<T>(IList<T> array, T lastPickedElement) where T : class
	{
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0396: Expected VT, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03e1: Expected VT, but got I4
		//IL_03e1: Expected VT, but got Obj
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0114: Expected VT, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0199: Invalid comparison between VT and I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		//IL_02c4: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_01bc: Expected VT, but got I4
		//IL_01bc: Expected VT, but got Obj
		//IL_01c9: Expected Obj, but got I4
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected VT, but got Unknown
		//IL_0305: Expected I, but got Obj
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_01de: Expected VT, but got Obj
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		object obj = array + 12;
		T val = default;
		if ((nint)obj == 1)
		{
			object obj2 = array + 16;
			if (obj2 == val)
			{
				nint num = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v86 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v93 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Log.Analytics.LogException((Exception)(object)"SyboRandom - RandomElementNoRepeats, unable to pick another value.");
			}
			return (T)(array + 16);
		}
		object obj4 = default;
		object obj17 = default;
		while (true)
		{
			Vector3 point;
			if ((nint)obj4 == 16)
			{
				Vector3 vector = (Vector3)0;
				object obj5 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
				{
					object obj6 = array + 16;
					object obj7 = obj5 << 2;
					object obj8 = obj6 + obj7;
					if (obj8 != val)
					{
						Vector3 vector2 = vector + 1;
						vector = vector2;
					}
					object obj9 = obj5 + 1;
					obj5 = obj9;
				}
				if (vector == (Vector3)(object)0)
				{
					break;
				}
				int num3 = Math3D.PointOnWhichSideOfLineSegment((Vector3)this, (Vector3)0, vector);
				object obj10 = 0;
				int num4 = num3;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
				{
					object obj11 = array + 16;
					object obj12 = obj10 << 2;
					object obj13 = obj11 + obj12;
					if (obj13 != val)
					{
						int num5 = num4 - 1;
						if (num4 == 0)
						{
							object obj14 = array + 16;
							object obj15 = obj10 << 2;
							return (T)(object)(obj14 + obj15);
						}
						num4 = num5;
					}
					object obj16 = obj10 + 1;
					obj10 = obj16;
				}
				point = (Vector3)obj;
			}
			else
			{
				point = (Vector3)obj;
			}
			obj4 = obj17 + 1;
			object obj18 = array + 16;
			int num6 = Math3D.PointOnWhichSideOfLineSegment((Vector3)this, (Vector3)0, point);
			int num7 = num6 << 2;
			object obj19 = obj18 + num7;
			if (obj19 != val)
			{
				return (T)obj19;
			}
		}
		nint num8 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v33 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num9 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v40 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log.Analytics.LogException((Exception)(object)"SyboRandom - RandomElementNoRepeats, unable to pick another value.");
		return val;
	}

	public T RandomElement<T>(IList<T> array)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Expected VT, but got I
		//IL_0025: Expected VT, but got I4
		//IL_0025: Expected VT, but got Obj
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0049: Expected VT, but got Obj
		object obj = array + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [array @ L1 (System.Collections.Generic.IList`1<T>)+C]");
		int num = Math3D.PointOnWhichSideOfLineSegment((Vector3)this, (Vector3)0, (Vector3)0);
		int num2 = num << 2;
		object obj2 = obj + num2;
		return (T)obj2;
	}

	public int RandomElementIndex<T>(ICollection<T> array)
	{
		//IL_000e: Expected Obj, but got I
		//IL_003e: Expected VT, but got I4
		//IL_003e: Expected VT, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Vector3 point = default;
		int num2 = Math3D.PointOnWhichSideOfLineSegment((Vector3)this, (Vector3)0, point);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		int result = default;
		return result;
	}

	public void Shuffle<T>(IList<T> list)
	{
		//IL_0035: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num = default;
			object obj = num + 24;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S3_v3+8]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57 @ S4_v5 (should have been resolved before IL gen)");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S3_v6+C]");
			object obj8 = 0;
			object obj9 = obj8 & 0x1FFF;
			object obj10 = obj9 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S4_v9 (should have been resolved before IL gen)");
			ProcessAnalyticsEventsResponse response = default;
			((AnalyticsManager)this).HandlePostAnalyticsReponse(response);
		}
	}
}
