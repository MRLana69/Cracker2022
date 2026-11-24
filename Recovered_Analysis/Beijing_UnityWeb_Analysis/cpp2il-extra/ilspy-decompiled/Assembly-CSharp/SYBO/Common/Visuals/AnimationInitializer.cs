using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities.Validators;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class AnimationInitializer : MonoBehaviour
{
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 8)]
	public struct Config
	{
		public float StartTimeMin;

		public float StartTimeMax;
	}

	private Config _config;

	private Animation _animation;

	private bool _initialized;

	private void OnEnable()
	{
		//IL_00a1: Expected Obj, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0029: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)64);
		object obj = this + 16;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = default;
		object obj2 = obj3 + 8;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v7 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v8+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0xFFF;
		object obj8 = obj7 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S2_v6 (should have been resolved before IL gen)");
		object obj9 = default;
		obj2 = obj9;
		object obj10 = this + 20;
		obj10 = obj3;
		((Validator<>)(object)this)._002Ector();
	}

	private void OnValidate()
	{
		//IL_0010: Expected Obj, but got VT
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		this._002Ector();
		object obj = _config;
		ModelInfo modelInfo = (ModelInfo)(obj + 8);
		modelInfo = (ModelInfo)obj;
		((CombineableMesh)this).UpdateToCombinedMesh(modelInfo);
	}

	private unsafe void Initialize()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_003a: Expected Obj, but got VT
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected I4, but got Unknown
		//IL_0055: Expected I4, but got Obj
		//IL_0071: Expected I4, but got Obj
		//IL_0080: Expected VT, but got I4
		object obj = this + 20;
		Animation component = GetComponent<Animation>();
		obj = component;
		SubMeshInfo subMeshInfo = default;
		object obj2 = subMeshInfo + 8;
		obj2 = _config;
		int num = subMeshInfo + 16;
		((int*)num)->m_value = (int)obj2;
		subMeshInfo._002Ector((MeshFilter)(object)this, num, null);
		((int*)num)->m_value = (int)subMeshInfo;
		_config = (Config)((int*)num)->m_value;
	}

	public void InitializeAnimation(Config config)
	{
		//IL_0065: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got VT
		//IL_0029: Expected Obj, but got I
		IEnumerable<_0021_00210> enumerable = (IEnumerable<_0021_00210>)Enumerable.Where<TSource>((IEnumerable<TSource>)(object)_animation, (Func<TSource, bool>)config);
		if (enumerable != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DB6C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Visuals.AnimationInitializer)+10]");
		if (((List<IEnumerator>)0).Contains((IEnumerator)config))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		}
	}

	public Config ClampToDefaultAnimationLength(Config config, bool validating = false)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((SocialManager)this).CashIn((Friend)config, validating ? 1 : 0);
		Config result = default;
		return result;
	}

	public AnimationInitializer()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			object obj = this + 20;
			Animation component = GetComponent<Animation>();
			obj = component;
			_initialized = true;
		}
	}
}
