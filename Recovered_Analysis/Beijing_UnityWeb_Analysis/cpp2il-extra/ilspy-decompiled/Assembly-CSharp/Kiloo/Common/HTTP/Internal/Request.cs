using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;

namespace Kiloo.Common.HTTP.Internal;

internal abstract class Request : IRequest
{
	private string method__BackingField;

	private IResponse response__BackingField;

	private uint maxRedirectCount__BackingField;

	private Exception exception__BackingField;

	private RequestState state__BackingField;

	private bool ignoreCertificateErrors__BackingField;

	private bool ignoreContentMD5__BackingField;

	private float timeout__BackingField;

	private float minBackOffTime__BackingField;

	private float maxBackOffTime__BackingField;

	private bool acceptGzip__BackingField;

	private Uri uri__BackingField;

	private byte[] bytes__BackingField;

	private DateTime _startTime;

	public string method
	{
		get
		{
			//IL_000d: Expected Obj, but got F4
			Connection.Log((string)(object)this);
			return (string)timeout__BackingField;
		}
		protected set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Expected Obj, but got Unknown
			//IL_0540: Expected Obj, but got I4
			//IL_0549: Unknown result type (might be due to invalid IL or missing references)
			//IL_054e: Expected Obj, but got Unknown
			//IL_0557: Expected Obj, but got I4
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_0565: Expected Obj, but got Unknown
			//IL_056e: Expected Obj, but got I4
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_057c: Expected Obj, but got Unknown
			//IL_0598: Expected I, but got Obj
			//IL_05ae: Expected Obj, but got I
			//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Expected Obj, but got Unknown
			//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0703: Expected Obj, but got Unknown
			//IL_070c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0711: Expected Obj, but got Unknown
			//IL_071a: Unknown result type (might be due to invalid IL or missing references)
			//IL_071f: Expected Obj, but got Unknown
			//IL_0728: Expected Obj, but got I4
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_00af: Expected I, but got Obj
			//IL_0252: Expected I, but got Obj
			//IL_0268: Expected Obj, but got I
			//IL_0293: Expected I, but got Obj
			//IL_03b7: Invalid comparison between I and F8
			//IL_069e: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a3: Expected Obj, but got Unknown
			//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b1: Expected Obj, but got Unknown
			//IL_06dd: Expected Obj, but got I4
			//IL_047f: Expected Obj, but got I
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Expected Obj, but got Unknown
			//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f0: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 60;
			obj3 = 0;
			object obj4 = obj2 + 56;
			obj4 = 0;
			object obj5 = obj2 + 24;
			obj5 = 0;
			object obj6 = obj2 + 48;
			obj6 = obj;
			_ = -1;
			nint num = (nint)typeof(Hosts);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Hosts);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v179 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj8 = obj2 + 40;
			object obj9 = obj2 + 32;
			object obj10 = obj2 + 16;
			object obj11 = obj2 + 8;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num3 = (nint)typeof(Hosts);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v78 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num4 = (nint)typeof(Hosts);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v170 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj13 = default;
			object obj17 = default;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj15 = default;
				object obj14 = obj15;
				object obj16 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj18 = default;
				if (obj16 == obj18)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
			}
			else
			{
				object obj19 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DB");
				object obj20 = obj17 << 32;
				object obj22 = default;
				object obj21 = obj22 | obj20;
				obj10 = obj21;
				obj8 = obj10;
				object obj23 = obj4;
				nint num5 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S1_v58 (Il2CppClass<System.DateTime>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num6 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v97 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D9");
				object obj25 = obj17 << 32;
				object obj27 = default;
				object obj26 = obj27 | obj25;
				obj11 = value;
				obj2 = obj26;
				obj9 = obj11;
				obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
				object obj28 = obj17 << 32;
				object obj30 = default;
				object obj29 = obj30 | obj28;
				obj5 = obj29;
				double num7 = (double)obj5 * 1E-07;
				object obj31 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v100+10]");
				if (0.0 < 0.0)
				{
					object obj32 = obj4;
					_ = 0.0;
				}
				object obj33 = obj6 + 4;
				object obj34 = obj33 + 1;
				obj33 = obj34;
				object obj35 = obj34 << 2;
				object obj36 = obj6 + obj35;
				obj36 = 131;
			}
			if (obj3 != null)
			{
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
				object obj37 = (nint)0 << 2;
				object obj38 = obj6 + obj37;
				if ((nint)obj38 == 131)
				{
					object obj39 = obj6 + 4;
					if ((nint)obj39 > -1)
					{
						object obj40 = obj39 + -1;
						obj39 = obj40;
					}
					return;
				}
			}
			object obj41 = default;
			if (obj41 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
	}

	public IResponse response
	{
		get
		{
			return (IResponse)(object)method__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	public uint maxRedirectCount
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (uint)(int)response__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 12;
			obj = value;
		}
	}

	public Exception exception
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (Exception)maxRedirectCount__BackingField;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			maxRedirectCount__BackingField = (uint)(int)value;
		}
	}

	public RequestState state
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (RequestState)exception__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 20;
			obj = value;
		}
	}

	public bool ignoreCertificateErrors
	{
		get
		{
			return (byte)state__BackingField != 0;
		}
		set
		{
			state__BackingField = (value ? RequestState.Waiting : RequestState.None);
		}
	}

	public bool ignoreContentMD5
	{
		get
		{
			return ignoreCertificateErrors__BackingField;
		}
		set
		{
			ignoreCertificateErrors__BackingField = value;
		}
	}

	public float timeout
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Expected Obj, but got Unknown
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected Obj, but got Unknown
			//IL_0271: Expected Obj, but got I4
			//IL_005f: Invalid comparison between I and F4
			//IL_015f: Expected Obj, but got I
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Expected Obj, but got Unknown
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			if (this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj3 = default;
				float num2 = default;
				float result = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj3 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v70+8]");
					if (0f > 0f)
					{
						float num = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v70+8]");
						result = num + 0f;
					}
				}
				object obj4 = obj2 + 4;
				object obj5 = obj4 + 1;
				obj4 = obj5;
				object obj6 = obj5 << 2;
				object obj7 = obj2 + obj6;
				obj7 = 67;
				object obj8 = default;
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj9 = (nint)0 << 2;
					object obj10 = obj2 + obj9;
					if ((nint)obj10 == 67)
					{
						object obj11 = obj2 + 4;
						if ((nint)obj11 > -1)
						{
							object obj12 = obj11 + -1;
							obj11 = obj12;
						}
						return result;
					}
				}
				object obj13 = default;
				if (obj13 == null)
				{
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			float result2 = default;
			return result2;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6c: Expected Obj, but got Unknown
			//IL_0b75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7a: Expected Obj, but got Unknown
			//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b88: Expected Obj, but got Unknown
			//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b96: Expected Obj, but got Unknown
			//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba4: Expected Obj, but got Unknown
			//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb2: Expected Obj, but got Unknown
			//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc0: Expected Obj, but got Unknown
			//IL_0bc9: Expected Obj, but got I4
			//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd7: Expected Obj, but got Unknown
			//IL_0bf3: Expected I, but got Obj
			//IL_0c09: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Expected Obj, but got Unknown
			//IL_01bc: Expected I, but got Obj
			//IL_01d2: Expected Obj, but got I
			//IL_01fd: Expected I, but got Obj
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected Obj, but got Unknown
			//IL_0137: Expected Obj, but got I4
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Expected Obj, but got Unknown
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Expected Obj, but got Unknown
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Expected Obj, but got Unknown
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected Obj, but got Unknown
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Expected Obj, but got Unknown
			//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d36: Expected Obj, but got Unknown
			//IL_0333: Expected I, but got Obj
			//IL_0349: Expected Obj, but got I
			//IL_0374: Expected I, but got Obj
			//IL_03e5: Expected I, but got Obj
			//IL_03fb: Expected Obj, but got I
			//IL_04c4: Expected I, but got Obj
			//IL_04da: Expected Obj, but got I
			//IL_0ce6: Expected Obj, but got I
			//IL_0d44: Expected Obj, but got VT
			//IL_0426: Expected I, but got Obj
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Expected Obj, but got Unknown
			//IL_0569: Unknown result type (might be due to invalid IL or missing references)
			//IL_056e: Expected Obj, but got Unknown
			//IL_0505: Expected I, but got Obj
			//IL_085e: Expected I, but got Obj
			//IL_0874: Expected Obj, but got I
			//IL_089f: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 80;
			object obj3 = obj2 + 56;
			object obj4 = obj2 + 48;
			object obj5 = obj2 + 40;
			object obj6 = obj2 + 24;
			object obj7 = obj2 + 16;
			object obj8 = obj2 + 8;
			object obj9 = obj2 + 32;
			obj9 = 0;
			object obj10 = obj2 - -64;
			obj10 = obj;
			_ = -1;
			nint num = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v29 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num2 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v435 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj12 = default;
			if (obj12 == null)
			{
				return;
			}
			object obj13 = this & 1;
			object obj20;
			object obj21 = default;
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj15 = default;
				object obj14 = obj15 + 12;
				object obj16 = 0;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
				{
					return;
				}
				object obj17 = obj15 + 16;
				object obj18 = obj16 << 2;
				object obj19 = obj17 + obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				obj20 = obj21;
				object obj23 = default;
				object obj22 = obj23;
			}
			else
			{
				nint num3 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v45 (Il2CppClass<System.DateTime>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num4 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S0_v351 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D9");
				object obj25 = obj21 << 32;
				object obj27 = default;
				object obj26 = obj27 | obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj29 = default;
				object obj28 = obj29 + 12;
				object obj30 = this & 4;
				bool flag = obj30 == null;
				object obj31 = this & 2;
				bool flag2 = obj31 == null;
				object obj32 = default;
				object obj36 = default;
				object obj41 = default;
				object obj47 = default;
				object obj50 = default;
				object obj51 = default;
				object obj53 = default;
				object obj55 = default;
				object obj56 = default;
				object obj59 = default;
				while (true)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj28))
					{
						return;
					}
					object obj33 = obj29 + 16;
					object obj34 = obj32 << 2;
					object obj35 = obj33 + obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj36 == null)
					{
						goto IL_0d28;
					}
					nint num5 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ S0_v91 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
					object obj37 = (nint)0 & (nint)0x200;
					if (obj37 != null)
					{
						nint num6 = (nint)typeof(WebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ S0_v338 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj43;
					object obj42;
					if (!flag)
					{
						nint num7 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S0_v143 (Il2CppClass<System.DateTime>)+BA]");
						object obj38 = (nint)0 & (nint)0x200;
						if (obj38 != null)
						{
							nint num8 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S0_v162 (Il2CppClass<System.DateTime>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						obj5 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ S0_v97+8]");
						obj6 = 0;
						obj4 = obj5;
						obj3 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
						object obj39 = obj21 << 32;
						object obj40 = obj41 | obj39;
						obj42 = obj40;
						obj9 = obj40;
						double num9 = (double)obj9 * 1E-07;
						bool flag3 = num9 > (double)value;
						obj42 = obj40;
						obj43 = obj40;
						if (flag3)
						{
							goto IL_06c0;
						}
					}
					if (flag2)
					{
						goto IL_0d28;
					}
					nint num10 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ S0_v107 (Il2CppClass<System.DateTime>)+BA]");
					object obj44 = (nint)0 & (nint)0x200;
					if (obj44 != null)
					{
						nint num11 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ S0_v132 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					obj7 = DateTime.MaxValue;
					obj3 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DE");
					object obj45 = obj21 << 32;
					object obj46 = obj47 | obj45;
					obj42 = obj46;
					obj8 = obj46;
					obj2 = obj26;
					obj4 = obj8;
					obj3 = obj2;
					object obj48 = obj4 & 0x3FFFFFFFFFFFFFFFL;
					object obj49 = obj3 & 0x3FFFFFFFFFFFFFFFL;
					bool flag4 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj48) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj49);
					obj42 = obj46;
					if (flag4)
					{
						goto IL_0d28;
					}
					obj43 = obj46;
					goto IL_06c0;
					IL_0d28:
					obj32 = obj50 + 1;
					continue;
					IL_06c0:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj22 = obj51;
					object obj52 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					bool flag5 = obj52 != obj53;
					obj20 = obj52;
					if (flag5)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj54 = obj55;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj56 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						nint num12 = (nint)typeof(WebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ S0_v222 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
						object obj57 = (nint)0 & (nint)0x200;
						if (obj57 != null)
						{
							nint num13 = (nint)typeof(WebClient);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ S0_v230 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						obj42 = obj43;
						goto IL_0d28;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
					object obj58 = obj55;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					obj20 = obj21;
					obj22 = obj59;
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj60 = default;
			if (obj20 == obj60)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj61 = default;
				string text = (string)obj61;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj62 = default;
				object obj22 = obj62;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}

	public float minBackOffTime
	{
		get
		{
			return timeout__BackingField;
		}
		set
		{
			timeout__BackingField = value;
		}
	}

	public float maxBackOffTime
	{
		get
		{
			return minBackOffTime__BackingField;
		}
		set
		{
			minBackOffTime__BackingField = value;
		}
	}

	public bool acceptGzip
	{
		get
		{
			return ignoreContentMD5__BackingField;
		}
		set
		{
			ignoreContentMD5__BackingField = value;
		}
	}

	public Uri uri
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = acceptGzip__BackingField;
			return (Uri)flag;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			acceptGzip__BackingField = flag;
		}
	}

	public byte[] bytes
	{
		get
		{
			return (byte[])(object)uri__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 48;
			obj = value;
		}
	}

	public float keepAlive
	{
		get
		{
			return maxBackOffTime__BackingField;
		}
		set
		{
			maxBackOffTime__BackingField = value;
		}
	}

	public Headers headers
	{
		get
		{
			return (Headers)(object)bytes__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 52;
			obj = value;
		}
	}

	public bool isFinished
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected Obj, but got Unknown
			object obj = this - 3;
			if ((nint)this == 3 || ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3))
			{
				return true;
			}
			object obj2 = this | 1;
			return (nint)obj2 == 5;
		}
	}

	public bool isSuccessful
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_00a9: Expected Obj, but got I4
			object obj = state__BackingField - 3;
			if (state__BackingField == RequestState.Done || ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3))
			{
				return true;
			}
			object obj2 = state__BackingField | RequestState.Waiting;
			return (nint)obj2 == 5;
		}
	}

	public string statusMessage
	{
		get
		{
			//IL_0026: Expected Obj, but got I4
			if (state__BackingField == RequestState.Done)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj = default;
				bool flag = (nint)obj == 2;
				return (string)flag;
			}
			return null;
		}
	}

	protected static bool IsFinalState(RequestState state)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ L0 (Kiloo.Common.HTTP.RequestState)+3C]");
		return false;
	}

	protected Request(string method, Uri uri, byte[] bytes)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_00b5: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		object obj = this + 8;
		obj = method;
		object obj2 = this + 12;
		obj2 = uri;
		nint num = (nint)typeof(StringComparer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<System.StringComparer>)+BA]");
		bool flag = (object)((nint)0 & (nint)0x200) == null;
		Dictionary<string, string> dictionary2;
		if (bytes != null)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(StringComparer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v38 (Il2CppClass<System.StringComparer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4FA");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Dictionary<string, string> dictionary = default;
			IEqualityComparer<string> comparer = default;
			dictionary._002Ector((IDictionary<string, string>)(object)bytes, comparer);
			dictionary2 = dictionary;
		}
		else
		{
			if (!flag)
			{
				nint num3 = (nint)typeof(StringComparer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v26 (Il2CppClass<System.StringComparer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4FA");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S3_v3 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S3_v4+60]");
			object obj4 = 0;
			object obj5 = obj4;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v84 @ S4_v5 (should have been resolved before IL gen)");
			Dictionary<string, string> dictionary3 = default;
			dictionary2 = dictionary3;
		}
		object obj8 = this + 16;
		obj8 = dictionary2;
	}

	public void CheckBackOff()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[Hosts] ", (int)this);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(message);
	}

	public void UpdateBackOffError()
	{
		//IL_0155: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_0191: Expected I8, but got I4
		//IL_0013: Expected I, but got Obj
		bool flag = Uri.StaticIsFile((UriParser)(object)uri__BackingField);
		nint num = (nint)typeof(Hosts);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hosts);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v37 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		double num3 = UnityEngine.Networking.FloatConversion.ToDouble((ulong)(flag ? 1 : 0));
		if (num3 > 0.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			bool flag2 = Uri.StaticIsFile((UriParser)(object)uri__BackingField);
			throw new ArrayTypeMismatchException();
		}
	}

	public void UpdateBackOff(IResponse response)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 60;
		obj = response;
	}

	public abstract void PrepareFetchResponse();

	public abstract void FetchResponseAsync();

	public abstract void FetchResponse();

	protected void InternalPrepareFetchResponse()
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_0063: Expected I, but got Obj
		if (!(maxBackOffTime__BackingField > 0f))
		{
			return;
		}
		bool flag = Uri.StaticIsFile((UriParser)(object)uri__BackingField);
		nint num = (nint)typeof(Hosts);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v5 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Hosts);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S2_v10 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A5EE");
	}

	protected void AssertNotCanceled(string step)
	{
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0079: Expected VT, but got Obj
		//IL_0275: Expected I, but got Obj
		//IL_028b: Expected Obj, but got I
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I4
		//IL_01e2: Expected I, but got Obj
		//IL_01f8: Expected Obj, but got I
		//IL_03b3: Expected Obj, but got VT
		//IL_03de: Expected Obj, but got I8
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_02b6: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_0223: Expected I, but got Obj
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_0456: Expected Obj, but got I4
		//IL_0186: Expected I, but got Obj
		object obj = default;
		string text = (string)(obj + 40);
		object obj2 = obj + 32;
		object obj3 = obj + 24;
		object obj4 = obj + 16;
		object obj5 = obj + 8;
		bool flag = Uri.StaticIsFile((UriParser)(object)uri__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj7 = default;
		object obj6 = obj7 - 500;
		if ((nint)obj7 == 500 || ((nint)obj6 != 1 && (nint)obj6 != 2 && (nint)obj6 == 3))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Headers headers2 = default;
			Headers headers = headers2.Add((KeyValuePair<string, string>)"Retry-After");
			if (headers != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v26 (Il2CppClass<System.DateTime>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v50 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = DateTime.MinValue;
				text = (string)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4E5");
				long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
				object obj9 = default;
				obj4 = obj9;
				obj5 = systemTimeAsFileTime;
				obj2 = obj4;
				text = (string)obj5;
				object obj10 = obj2 & 0x3FFFFFFFFFFFFFFFL;
				object obj11 = text & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
				{
					nint num3 = (nint)typeof(Hosts);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v51 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num4 = (nint)typeof(Hosts);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v58 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj = obj9;
					text = (string)obj;
					((Request)flag).method = text;
					return;
				}
			}
			if (!(maxBackOffTime__BackingField > 0f))
			{
				return;
			}
			bool flag2 = Uri.StaticIsFile((UriParser)(object)uri__BackingField);
			nint num5 = (nint)typeof(Hosts);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S2_v10 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num6 = (nint)typeof(Hosts);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S2_v15 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A5EE");
			return;
		}
		nint num7 = (nint)typeof(Hosts);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v63 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num8 = (nint)typeof(Hosts);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v68 (Il2CppClass<Kiloo.Common.HTTP.Internal.Hosts>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Hosts.Log((string)flag);
	}

	private static void Log(string msg)
	{
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_01f5: Expected Obj, but got I4
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I4
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_01a7: Expected Obj, but got I8
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_010e: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+18]");
			object obj = -3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+18]");
			bool flag;
			if ((nint)0 == 3 || ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3))
			{
				flag = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+18]");
				object obj2 = (nint)0 | (nint)1;
				flag = (nint)obj2 == 5;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InvalidProgramException ex = default;
				ex._002Ector("Fetch already in process");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		object obj3 = msg + 12;
		obj3 = 0;
		object obj4 = msg + 20;
		obj4 = 0;
		_ = 1;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v17 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		object obj6 = systemTimeAsFileTime;
		object obj7 = obj6 + 8;
		obj7 = obj6;
		object obj8 = msg - -64;
		obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}
}
