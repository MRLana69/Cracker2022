using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using UnityEngine;
using UnityEngine.Events;

namespace SYBO.Components.Utilities;

public class AssetLoader : ScriptableObject
{
	protected static bool CanUpdateAssets
	{
		get
		{
			//IL_004c: Expected I4, but got Obj
			if (PrefabPool._comparer == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				IComparer<PrefabPool> comparer = default;
				PrefabPool._comparer = comparer;
			}
			return (byte)(int)PrefabPool._comparer != 0;
		}
	}

	public AssetLoader()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
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
	}
}
public class AssetLoader<T, Loader> : AssetLoader where T : UnityEngine.Object where Loader : AssetLoader<T, Loader>
{
	public UnityEvent OnAssetsChanged;

	protected string[] _assetPaths;

	protected List<T> _includedAssets;

	protected List<AssetInfo> _assetInfo;

	private static Loader _instance;

	public static bool HasInstance
	{
		get
		{
			//IL_001a: Expected Obj, but got I
			//IL_0039: Expected Obj, but got I
			//IL_003e: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v3+60]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v6+5C]");
			object obj2 = 0;
			return (byte)(int)obj2 != 0;
		}
	}

	private static string LoaderPath
	{
		get
		{
			//IL_006c: Expected Obj, but got I
			//IL_0086: Expected Obj, but got I
			//IL_0094: Expected I, but got Obj
			//IL_00aa: Expected Obj, but got I
			//IL_00d5: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v7+60]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10+5C]");
			object obj2 = 0;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (string)((ComputeShader)obj2).FindKernel((string)null);
		}
	}

	private unsafe static string LoaderName
	{
		get
		{
			//IL_02a0: Expected Obj, but got I
			//IL_02ba: Expected Obj, but got I
			//IL_02c8: Expected I, but got Obj
			//IL_02de: Expected Obj, but got I
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Expected Obj, but got Unknown
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Expected Obj, but got Unknown
			//IL_0327: Expected Obj, but got I
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Expected I, but got Unknown
			//IL_0342: Expected I, but got Obj
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Expected Obj, but got Unknown
			//IL_0378: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			//IL_008f: Expected I4, but got Obj
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Obj, but got Unknown
			//IL_00e2: Expected I, but got Obj
			//IL_00f8: Expected Obj, but got I
			//IL_01c0: Expected I, but got Obj
			//IL_01d6: Expected Obj, but got I
			//IL_03cc: Expected I, but got Obj
			//IL_009c: Expected Obj, but got I4
			//IL_0446: Expected Obj, but got I
			//IL_0454: Expected I, but got Obj
			//IL_046a: Expected Obj, but got I
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Expected Obj, but got Unknown
			//IL_0123: Expected I, but got Obj
			//IL_0497: Expected Obj, but got I
			//IL_04a4: Expected I, but got Obj
			//IL_0201: Expected I, but got Obj
			//IL_024e: Expected I, but got Obj
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13+60]");
			object obj2 = 0;
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v77 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = default;
			object obj4 = obj5 + 4;
			object obj6 = obj5 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
			obj6 = 0;
			nint num4 = (nint)(obj5 + 16);
			((IntPtr*)num4)->m_value = (void*)(nint)obj6;
			Type type = Type.internal_from_handle((IntPtr)num4);
			object obj7 = obj5 + 8;
			obj7 = typeof(AssetLoaderPathAttribute);
			((IntPtr*)num4)->m_value = (void*)(nint)obj7;
			Type type2 = Type.internal_from_handle((IntPtr)num4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
			object obj8 = default;
			bool flag = obj8 == null;
			string text = "";
			if (!flag)
			{
				object obj9 = obj8 + 12;
				bool flag2 = (byte)(int)"" != 0;
				object obj10 = default;
				object obj15 = default;
				string text2 = default;
				object obj16 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
				{
					object obj11 = obj8 + 16;
					object obj12 = obj10 << 2;
					object obj13 = obj11 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v51 (Il2CppClass<System.Type>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num6 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v64 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj4 = typeof(AssetLoaderPathAttribute);
					((IntPtr*)num4)->m_value = (void*)(nint)obj4;
					Type type3 = Type.internal_from_handle((IntPtr)num4);
					if (obj15 == type3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
						bool flag3 = EnvironmentUtility.HasEnvironmentVariable(text2);
						flag2 = flag3;
					}
					obj10 = obj16 + 1;
				}
				text = (string)flag2;
			}
			if (text == null || text.m_stringLength == 0)
			{
				nint num7 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v41 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num8 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v48 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v23+60]");
				object obj18 = 0;
				nint num9 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v27 (Il2CppClass<System.Type>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num10 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v37 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v24+8]");
				obj5 = 0;
				((IntPtr*)num4)->m_value = (void*)(nint)obj5;
				Type type4 = Type.internal_from_handle((IntPtr)num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object[] args = default;
				Log.Utilities.LogErrorFormat("AssetLoader was unable to find a reasonable path for loader of type {0}", args);
			}
			return text;
		}
	}

	public unsafe static Loader Instance
	{
		get
		{
			//IL_0299: Expected Obj, but got I
			//IL_02b3: Expected Obj, but got I
			//IL_02c1: Expected I, but got Obj
			//IL_02d7: Expected Obj, but got I
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Expected Obj, but got Unknown
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected Obj, but got Unknown
			//IL_0320: Expected Obj, but got I
			//IL_0329: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Expected I, but got Unknown
			//IL_033b: Expected I, but got Obj
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0356: Expected Obj, but got Unknown
			//IL_0371: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected Obj, but got Unknown
			//IL_00e2: Expected I, but got Obj
			//IL_00f8: Expected Obj, but got I
			//IL_01b9: Expected I, but got Obj
			//IL_01cf: Expected Obj, but got I
			//IL_03c5: Expected I, but got Obj
			//IL_043f: Expected Obj, but got I
			//IL_044d: Expected I, but got Obj
			//IL_0463: Expected Obj, but got I
			//IL_0402: Unknown result type (might be due to invalid IL or missing references)
			//IL_0407: Expected Obj, but got Unknown
			//IL_0123: Expected I, but got Obj
			//IL_0490: Expected Obj, but got I
			//IL_049d: Expected I, but got Obj
			//IL_01fa: Expected I, but got Obj
			//IL_017c: Expected Obj, but got I
			//IL_0247: Expected I, but got Obj
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13+60]");
			object obj2 = 0;
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v17 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v77 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = default;
			object obj4 = obj5 + 4;
			object obj6 = obj5 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
			obj6 = 0;
			nint num4 = (nint)(obj5 + 16);
			((IntPtr*)num4)->m_value = (void*)(nint)obj6;
			Type type = Type.internal_from_handle((IntPtr)num4);
			object obj7 = obj5 + 8;
			obj7 = typeof(AssetLoaderPathAttribute);
			((IntPtr*)num4)->m_value = (void*)(nint)obj7;
			Type type2 = Type.internal_from_handle((IntPtr)num4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
			object obj8 = default;
			bool flag = obj8 == null;
			Loader val = (Loader)(object)"";
			if (!flag)
			{
				object obj9 = obj8 + 12;
				Loader val2 = (Loader)(object)"";
				object obj10 = default;
				object obj15 = default;
				object obj16 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
				{
					object obj11 = obj8 + 16;
					object obj12 = obj10 << 2;
					object obj13 = obj11 + obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v51 (Il2CppClass<System.Type>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num6 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v63 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj4 = typeof(AssetLoaderPathAttribute);
					((IntPtr*)num4)->m_value = (void*)(nint)obj4;
					Type type3 = Type.internal_from_handle((IntPtr)num4);
					if (obj15 == type3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v74+C]");
						val2 = (Loader)0;
					}
					obj10 = obj16 + 1;
				}
				val = val2;
			}
			bool flag2;
			if ((object)val != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ L2_v2 (Loader)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				nint num7 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v41 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num8 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v48 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v23+60]");
				object obj18 = 0;
				nint num9 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S1_v27 (Il2CppClass<System.Type>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num10 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S1_v37 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v24+8]");
				obj5 = 0;
				((IntPtr*)num4)->m_value = (void*)(nint)obj5;
				Type type4 = Type.internal_from_handle((IntPtr)num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object[] args = default;
				Log.Utilities.LogErrorFormat("AssetLoader was unable to find an assetName for loader of type {0}", args);
			}
			return val;
		}
	}

	public List<T> LoadAssets()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		List<T> result = default;
		return result;
	}

	private void SetIncludedAssets(List<T> value)
	{
		throw new InvalidOperationException();
	}
}
