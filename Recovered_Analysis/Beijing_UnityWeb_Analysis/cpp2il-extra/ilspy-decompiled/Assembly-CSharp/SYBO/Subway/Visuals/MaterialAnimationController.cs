using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class MaterialAnimationController : MonoBehaviour
{
	private Shader _targetShader;

	private string _materialNameSubstring;

	private bool _searchChildrenForRenderer;

	private float _colorMultiplier;

	private List<Renderer> _targetRenderers;

	private List<Material> _targetMaterials;

	private bool _targetSet;

	private static MaterialPropertyBlock _propertyBlock;

	public float ColorMultiplier
	{
		set
		{
			//IL_000a: Expected Obj, but got F4
			_targetShader = (Shader)value;
		}
	}

	private void Update()
	{
		//IL_000b: Expected Obj, but got F4
		_targetShader = (Shader)0.5f;
		CancelInvoke();
	}

	private bool SetTargetMaterials()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	public MaterialAnimationController()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_04e1: Expected Obj, but got I4
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0531: Expected I4, but got Obj
		//IL_0062: Expected I, but got Obj
		//IL_033a: Expected Obj, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_037e: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_044a: Expected I, but got Obj
		//IL_0460: Expected Obj, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		//IL_05ec: Expected Obj, but got I
		//IL_048b: Expected I, but got Obj
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I
		//IL_011c: Expected I, but got Obj
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (~(_targetSet ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(MaterialAnimationController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v65 (Il2CppClass<SYBO.Subway.Visuals.MaterialAnimationController>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(MaterialAnimationController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v149 (Il2CppClass<SYBO.Subway.Visuals.MaterialAnimationController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Material)(object)_propertyBlock).SetFloatImpl((int)"_ColorMultiplier", _colorMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num3 = (nint)typeof(MaterialAnimationController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v128 (Il2CppClass<SYBO.Subway.Visuals.MaterialAnimationController>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(MaterialAnimationController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v140 (Il2CppClass<SYBO.Subway.Visuals.MaterialAnimationController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj8 = obj4 + 4;
			object obj9 = obj8 + 1;
			obj8 = obj9;
			object obj10 = obj9 << 2;
			object obj11 = obj4 + obj10;
			obj11 = 194;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj12 = (nint)0 << 2;
				object obj13 = obj4 + obj12;
				if ((nint)obj13 == 194)
				{
					object obj14 = obj4 + 4;
					if ((nint)obj14 > -1)
					{
						object obj15 = obj14 + -1;
						obj14 = obj15;
					}
					return;
				}
			}
			object obj16 = default;
			if (obj16 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			return;
		}
		List<Renderer> targetRenderers = _targetRenderers;
		if (targetRenderers._size == 0)
		{
			List<Renderer> targetRenderers2 = _targetRenderers;
			if (~(_searchChildrenForRenderer ? 1u : 0u) == 0)
			{
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S2_v8 (Il2CppMethodInfo)+18]");
				object obj17 = 0;
				object obj18 = obj17;
				object obj19 = obj18 & 0x1FFF;
				object obj20 = obj19 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v132 @ S3_v6 (should have been resolved before IL gen)");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S3_v8 (Il2CppMethodInfo)+C]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S3_v9+60]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S3_v10+38]");
				object obj23 = 0;
				object obj24 = obj23 & 0x1FFF;
				object obj25 = obj24 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v87 @ S4_v8 (should have been resolved before IL gen)");
			}
			else
			{
				Renderer component = GetComponent<Renderer>();
				_targetRenderers.Add(component);
			}
		}
		List<Renderer> targetRenderers3 = _targetRenderers;
		if (targetRenderers3._size <= 0)
		{
			return;
		}
		RoofedCulling.CullingBlock currentCullingBlock = ((RoofedCulling)(object)this).CurrentCullingBlock;
		if (currentCullingBlock == null)
		{
			throw new IndexOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IntPtr intPtr = default;
		MaterialPropertyBlock.DestroyImpl(intPtr);
		nint num7 = (nint)typeof(MaterialAnimationController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v41 (Il2CppClass<SYBO.Subway.Visuals.MaterialAnimationController>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num8 = (nint)typeof(MaterialAnimationController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v48 (Il2CppClass<SYBO.Subway.Visuals.MaterialAnimationController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_propertyBlock = (MaterialPropertyBlock)(nint)intPtr;
		_targetSet = true;
	}

	static MaterialAnimationController()
	{
		//IL_002d: Expected I, but got Obj
		//IL_0043: Expected Obj, but got I
		//IL_004c: Expected Obj, but got I4
		Game._characterController = null;
		Game.GAME_DEFAULT_GAME_SPEED = 110f;
		Game.HasLoaded = false;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v15 (Il2CppClass<SYBO.Subway.Game>)+5C]");
		object obj = (nint)0 + (nint)52;
		obj = 0;
	}
}
