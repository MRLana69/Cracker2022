using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;
using UnityEngine.Rendering;

public class ProductPlacer : MonoBehaviour
{
	public enum BillboardType
	{
		Tunnel,
		Train,
		Billboard
	}

	public MeshRenderer billboardMesh;

	public BillboardType type;

	public float minTimeBetweenAds;

	private void OnEnable()
	{
	}

	public ProductPlacer()
	{
		//IL_0051: Expected VT, but got Obj
		//IL_0061: Expected Obj, but got I
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0429: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		//IL_0186: Expected VT, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_01a4: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0461: Expected Obj, but got I
		//IL_0126: Expected VT, but got Obj
		//IL_0137: Invalid comparison between I and F4
		//IL_01e5: Expected I, but got Obj
		//IL_02bb: Expected VT, but got Obj
		//IL_02cb: Expected Obj, but got I
		//IL_02d9: Expected I, but got Obj
		//IL_02ef: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I
		//IL_0499: Expected Obj, but got I
		//IL_0162: Expected VT, but got Obj
		//IL_025b: Expected VT, but got Obj
		//IL_026c: Invalid comparison between I and F4
		//IL_031a: Expected I, but got Obj
		//IL_037e: Expected Obj, but got I
		//IL_0297: Expected VT, but got Obj
		//IL_0390: Expected VT, but got Obj
		//IL_03a1: Invalid comparison between I and F4
		//IL_03cc: Expected VT, but got Obj
		billboardMesh.shadowCastingMode = ShadowCastingMode.Off;
		if (type != BillboardType.Tunnel)
		{
			if (type != BillboardType.Train)
			{
				if (type != BillboardType.Billboard)
				{
					return;
				}
				_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v72 (T)+14]");
				object obj = 0;
				nint num = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v76 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v95 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v73+8]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Material sharedMaterial = billboardMesh.sharedMaterial;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v73+8]");
					Color color = ((Material)(object)"_MainTex").GetColor((string)0);
					_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v87 (T)+2C]");
					if (!(0f < 5f))
					{
						_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
						_ = 0f;
						billboardMesh.shadowCastingMode = ShadowCastingMode.On;
					}
				}
				return;
			}
			_00210 val4 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v42 (T)+18]");
			object obj3 = 0;
			nint num3 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v43+8]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Material sharedMaterial2 = billboardMesh.sharedMaterial;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v43+8]");
				Color color2 = ((Material)(object)"_MainTex").GetColor((string)0);
				_00210 val5 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v58 (T)+28]");
				if (!(0f < 6f))
				{
					_00210 val6 = (_00210)SingletonMonoBehaviour<>.Instantiate();
					_ = 0f;
					billboardMesh.shadowCastingMode = ShadowCastingMode.On;
				}
			}
			return;
		}
		_00210 val7 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (T)+10]");
		object obj5 = 0;
		nint num5 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Material sharedMaterial3 = billboardMesh.sharedMaterial;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			Color color3 = ((Material)(object)"_MainTex").GetColor((string)0);
			_00210 val8 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v28 (T)+24]");
			if (!(0f < 7f))
			{
				_00210 val9 = (_00210)SingletonMonoBehaviour<>.Instantiate();
				_ = 0f;
				billboardMesh.shadowCastingMode = ShadowCastingMode.On;
			}
		}
	}
}
