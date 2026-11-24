using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Utilities;

public class SubMeshInfo
{
	public MeshFilter MeshFilter;

	public int SubmeshIndex;

	public Material Material;

	public unsafe SubMeshInfo(MeshFilter meshFilter, int submeshIndex, Material material)
	{
		//IL_029e: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_03a4: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I4
		//IL_00b6: Expected I, but got Obj
		//IL_0131: Expected I4, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_0162: Expected I, but got Obj
		//IL_0178: Expected Obj, but got I
		//IL_0304: Invalid comparison between Obj and F4
		//IL_01f8: Invalid comparison between Obj and F4
		//IL_01a3: Expected I, but got Obj
		//IL_022c: Expected F4, but got Obj
		//IL_0330: Expected I4, but got F4
		//IL_033d: Expected Obj, but got I4
		//IL_035b: Invalid comparison between I and F4
		//IL_024f: Invalid comparison between I and F4
		//IL_028b: Expected F4, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [meshFilter @ L1 (UnityEngine.MeshFilter)+14]");
		if ((UnityEngine.Object)0 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [meshFilter @ L1 (UnityEngine.MeshFilter)+14]");
			bool isPlaying = ((Animation)0).isPlaying;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)isPlaying == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [meshFilter @ L1 (UnityEngine.MeshFilter)+14]");
				bool isPlaying2 = ((Animation)0).isPlaying;
				UnityEngine.Object obj5 = UnityEngine.Object.Instantiate((UnityEngine.Object)isPlaying2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [meshFilter @ L1 (UnityEngine.MeshFilter)+14]");
				bool flag = ((Animation)0).Play((PlayMode)obj5);
				obj2 = ((int*)submeshIndex)->m_value;
				float distance = (flag ? ((RaycastHit*)1) : ((RaycastHit*)null))->distance;
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v35 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v46 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num7 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f)) ? 0f : ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)distance)) ? ((float)obj2) : distance));
				((int*)submeshIndex)->m_value = (int)num7;
				obj3 = ((int*)submeshIndex)->m_value;
				float distance2 = (flag ? ((RaycastHit*)1) : ((RaycastHit*)null))->distance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if (0f < 0f)
				{
					float num8 = 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					if (0f > distance2)
					{
						float num8 = distance2;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						float num8 = 0f;
					}
				}
			}
		}
		SubMeshInfo subMeshInfo = (SubMeshInfo)((int*)submeshIndex)->m_value;
	}
}
