using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class ColorTeleboardMenuEffect : BatTeleboardMenuEffect
{
	private int colorNumber;

	private List<Material> materials;

	private void OnDisable()
	{
		OnEnable();
	}

	public override void StartTeleboardEffect(float duration, CharacterModel characterModel)
	{
		//IL_000f: Expected I4, but got Obj
		IEnumerator routine = ((TableElementAlwaysVisible)(object)this).MovePanelAfterFrames(0f, (int)characterModel);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private List<Material> CollectMaterials(CharacterModel characterModel)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Material> list = default;
		list._items = null;
		object obj = list + 20;
		obj = this;
		object obj2 = list + 16;
		obj2 = characterModel;
		return list;
	}

	private unsafe void AddChildrenMaterials(Transform rootTransform, ref List<Material> materials)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01e2: Expected I, but got Obj
		//IL_01f8: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_0223: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_02a9: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_02ea: Expected I, but got Obj
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		if (base._cachedRenderers == null)
		{
			nint num = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)rootTransform).FindKernel((string)null) != 0)
			{
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v14 (Il2CppMethodInfo)+18]");
				object obj2 = 0;
				object obj3 = obj2;
				object obj4 = obj3 & 0x1FFF;
				object obj5 = obj4 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S3_v5 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<> list = default;
				_00210 item = default;
				((List<T>)(object)list).Add((T)item);
				int num4 = 0;
				while (num4 < list._size)
				{
					Renderer renderer = ((List<Renderer>)(object)list).get_Item(num4);
					string sortingLayerName = renderer.sortingLayerName;
					if (sortingLayerName == null)
					{
						((List<Renderer>)(object)list).RemoveAt(num4);
						continue;
					}
					int num5 = num4 + 1;
					num4 = num5;
				}
				object obj6 = this + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
				object obj7 = default;
				obj6 = obj7;
			}
		}
		if (base._cachedRenderers == null)
		{
			return;
		}
		Renderer[] cachedRenderers = base._cachedRenderers;
		if (cachedRenderers.Length == 0)
		{
			return;
		}
		object obj8 = base._cachedRenderers + 16;
		nint num6 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj8).FindKernel((string)null) == 0)
		{
			return;
		}
		object obj10 = 0;
		while (true)
		{
			Renderer[] cachedRenderers2 = base._cachedRenderers;
			if ((nint)obj10 >= cachedRenderers2.Length)
			{
				break;
			}
			object obj11 = base._cachedRenderers + 16;
			object obj12 = obj10 << 2;
			object obj13 = obj11 + obj12;
			nint num8 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num9 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj13).FindKernel((string)null) != 0)
			{
				object obj15 = base._cachedRenderers + 16;
				object obj16 = obj10 << 2;
				object obj17 = obj15 + obj16;
				((Renderer)obj17).shadowCastingMode = (ShadowCastingMode)(int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref materials);
			}
			object obj18 = obj10 + 1;
			obj10 = obj18;
		}
	}

	public ColorTeleboardMenuEffect()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02d9: Expected Obj, but got I4
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_0211: Expected Obj, but got I
		//IL_00de: Expected I, but got Obj
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 24;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 16;
		obj6 = obj;
		_ = -1;
		if (materials == null)
		{
			return;
		}
		List<Material> list = materials;
		if (list._size == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v85 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v100 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj4 = obj2;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj9 = obj6 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj6 + obj11;
		obj12 = 78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj6 + obj13;
			if ((nint)obj14 == 78)
			{
				object obj15 = obj6 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				return;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
