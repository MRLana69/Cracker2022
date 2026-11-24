using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using SYBO.Components.Utilities;

namespace SYBO.Components.Singletons;

public abstract class Singleton<T> where T : Singleton<T>
{
	private static object _lockObject;

	private static T _instance;

	public unsafe static T Instance
	{
		get
		{
			//IL_0062: Expected Obj, but got I
			//IL_0070: Expected I, but got Obj
			//IL_0086: Expected Obj, but got I
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected I, but got Unknown
			//IL_00c6: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L0 (Il2CppMethodInfo)+18]");
			object obj = 0;
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<System.Type>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v22 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = obj;
			nint num3 = (nint)(obj3 + 4);
			((IntPtr*)num3)->m_value = (void*)(nint)obj3;
			Type assembly = Type.internal_from_handle((IntPtr)num3);
			return (T)SubTypeReflector.IsUnwantedAssembly((Assembly)(object)assembly);
		}
	}

	public Singleton()
	{
	}

	public unsafe static T GetInstance()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected Obj, but got Unknown
		//IL_08ce: Expected Obj, but got I4
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected Obj, but got Unknown
		//IL_08f8: Expected Obj, but got I
		//IL_0912: Expected Obj, but got I
		//IL_0932: Expected Obj, but got I
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_095d: Expected I, but got Unknown
		//IL_0977: Expected Obj, but got I
		//IL_0991: Expected Obj, but got I
		//IL_0c0f: Expected Obj, but got I
		//IL_0c2f: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0bb1: Expected Obj, but got I
		//IL_0bcb: Expected Obj, but got I
		//IL_0bd8: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_0840: Expected Obj, but got I
		//IL_09d1: Expected Obj, but got I
		//IL_09de: Expected I, but got Obj
		//IL_09f9: Expected Obj, but got I4
		//IL_01a6: Expected Obj, but got I4
		//IL_010d: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0226: Expected Obj, but got I4
		//IL_0899: Expected Obj, but got I
		//IL_02bb: Expected Obj, but got I
		//IL_0184: Expected I4, but got Obj
		//IL_02e0: Expected Obj, but got I
		//IL_0204: Expected I4, but got Obj
		//IL_0a4a: Expected Obj, but got I
		//IL_0a64: Expected Obj, but got I
		//IL_0a6d: Expected Obj, but got I4
		//IL_028d: Expected I4, but got Obj
		//IL_0317: Expected Obj, but got I
		//IL_03b2: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I
		//IL_0413: Expected Obj, but got I
		//IL_0471: Expected Obj, but got I
		//IL_0791: Expected Obj, but got I
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 20;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		nint num = default;
		object obj5 = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v22+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v371+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v374+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v379+60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num2 = (nint)(obj2 + 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v30+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v33+5C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v34+4]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v71+60]");
			object obj12 = 0;
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v75 (Il2CppClass<System.Type>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v365 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v72+C]");
			obj2 = 0;
			((IntPtr*)num2)->m_value = (void*)(nint)obj2;
			Type type = Type.internal_from_handle((IntPtr)num2);
			bool flag = ReflectionWrapper.DerivesFrom(type, (Type)52);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v83 (System.Boolean)+C]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object[] args = default;
				string text = $"Singleton {args} has an invalid number of constructors!\nSingletons must have exactly one constructor, it must be private and without parameters.";
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				SingletonsLogCategory singletonsLogCategory = default;
				singletonsLogCategory._002Ector((int)text);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			object obj14 = (flag ? 1 : 0) + 16;
			if (((MethodBase)obj14).IsStatic)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object[] args2 = default;
				string text2 = $"Singleton {args2} has a public constructor!\nSingletons must have exactly one constructor, it must be private and without parameters.";
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				SingletonsLogCategory singletonsLogCategory2 = default;
				singletonsLogCategory2._002Ector((int)text2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			object obj15 = (flag ? 1 : 0) + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v93+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object[] args3 = default;
				string text3 = $"Singleton {args3} constructor has parameters!\nSingletons must have exactly one constructor, it must be private and without parameters.";
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				SingletonsLogCategory singletonsLogCategory3 = default;
				singletonsLogCategory3._002Ector((int)text3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v98+60]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v101+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v326+60]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v329+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v334+60]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v107+60]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v110+5C]");
			object obj21 = 0;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v156+60]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S0_v161+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v300+60]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v305+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v312+60]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj27 = default;
			object obj26 = obj27;
			object obj29 = default;
			object obj28 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj30 = default;
			if (obj28 == obj30)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			if (obj3 != null)
			{
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
				object obj31 = (nint)0 << 2;
				object obj32 = obj4 + obj31;
				if ((nint)obj32 == 207)
				{
					object obj33 = obj4 + 4;
					if ((nint)obj33 > -1)
					{
						object obj34 = obj33 + -1;
						obj33 = obj34;
					}
					goto IL_0bf5;
				}
			}
			object obj35 = default;
			if (obj35 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_0bf5;
		IL_0bf5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v40+60]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v43+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v57+60]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v60+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v65+60]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v49+60]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v52+5C]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v53+4]");
		return (T)0;
	}

	public virtual void Initialize()
	{
	}

	unsafe static Singleton()
	{
		//IL_0191: Expected Obj, but got I
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected I, but got Unknown
		//IL_0255: Expected I, but got Obj
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_028b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_01e2: Expected Obj, but got I
		//IL_0206: Expected Obj, but got I
		//IL_010a: Expected I, but got Obj
		//IL_013a: Expected I, but got Obj
		//IL_0160: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L0 (Il2CppMethodInfo)+18]");
		object obj = 0;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v47 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj;
		nint num3 = (nint)(obj3 + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Type type = Type.internal_from_handle((IntPtr)num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj5 = default;
		object obj4 = obj5 + 12;
		nint num4 = num3;
		object obj6 = 0;
		object obj10 = default;
		object[] args = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj7 = obj5 + 16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			if (obj10 == null)
			{
				nint num5 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v34 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				bool flag = obj11 == null;
				num4 = (nint)typeof(Log);
				if (!flag)
				{
					nint num6 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v41 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(Log);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(Log);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ L0_v4 (System.IntPtr)+5C]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v39+34]");
				((LogCategory)0).LogErrorFormat("Field {0} was found to be null", args);
			}
			object obj13 = obj6 + 1;
			obj6 = obj13;
		}
	}
}
