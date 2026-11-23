using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class BackgroundObject : MonoBehaviour
{
	private bool _alwaysVisible;

	private bool _movable;

	private MoveGameObject _moveGameObject;

	private Transform _transform;

	private Renderer[] _renderers;

	private List<MeshRenderer> _meshRenderers;

	private List<ParticleSystemRenderer> _particleSystemRenderers;

	private List<Material> _materialInstances;

	public bool AlwaysVisible => _alwaysVisible;

	public bool Movable => _movable;

	public Renderer[] Renderers => _renderers;

	public List<MeshRenderer> MeshRenderers => _meshRenderers;

	public List<ParticleSystemRenderer> ParticleSystemRenderers => _particleSystemRenderers;

	private void Awake()
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I
		Transform component = GetComponent<Transform>();
		_transform = component;
		MoveGameObject component2 = GetComponent<MoveGameObject>();
		_moveGameObject = component2;
		Renderer[] componentsInChildren = GetComponentsInChildren<Renderer>(includeInactive: true);
		_renderers = componentsInChildren;
		object obj = 0;
		object obj4 = default;
		MeshRenderer item = default;
		while (true)
		{
			Renderer[] renderers = _renderers;
			if (renderers.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)renderers + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v15+10]");
			ParticleSystemRenderer particleSystemRenderer = (ParticleSystemRenderer)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				_meshRenderers.Add(item);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v15+10]");
				bool flag = (nint)0 == 0;
				ParticleSystemRenderer particleSystemRenderer2 = null;
				if (!flag)
				{
					bool flag2 = (object)particleSystemRenderer.GetType() == typeof(ParticleSystemRenderer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v15+10]");
					particleSystemRenderer2 = (ParticleSystemRenderer)0;
					if (!flag2)
					{
						particleSystemRenderer2 = null;
					}
				}
				if ((object)particleSystemRenderer2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v15+10]");
					bool flag3 = (nint)0 == 0;
					ParticleSystemRenderer item2 = null;
					if (!flag3)
					{
						bool flag4 = (object)particleSystemRenderer.GetType() == typeof(ParticleSystemRenderer);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v15+10]");
						item2 = (ParticleSystemRenderer)0;
						if (!flag4)
						{
							item2 = null;
						}
					}
					_particleSystemRenderers.Add(item2);
				}
			}
			object obj5 = obj + 1;
			obj = obj5;
		}
	}

	public unsafe void Initialize(BackgroundLayer layer, Transform parent, Vector3 localPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected VT, but got Unknown
		//IL_028f: Expected I, but got Obj
		//IL_02c1: Expected F4, but got I
		//IL_02bc: Expected native int or pointer, but got VT
		//IL_02dc: Expected F4, but got I
		//IL_02d7: Expected native int or pointer, but got VT
		//IL_02f4: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I
		//IL_0145: Expected Obj, but got I
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 48);
		string text = name;
		string text2 = layer.Name + " - " + text;
		name = text2;
		if (_moveGameObject != null)
		{
			MoveGameObject moveGameObject = _moveGameObject;
			moveGameObject._speedMultiplier = layer._speed;
		}
		_transform.parent = parent;
		_ = localPosition.z;
		_ = localPosition.x;
		Vector3 localPosition2 = (Vector3)(quaternion + 16);
		_transform.localPosition = localPosition2;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v33 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v34 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		_transform.localRotation = quaternion;
		object obj2 = 0;
		Material material = default;
		while (true)
		{
			Renderer[] renderers = _renderers;
			if (renderers.Length <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)renderers + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v51+10]");
			Material[] sharedMaterials = ((Renderer)0).sharedMaterials;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v51+10]");
			Material[] sharedMaterials2 = ((Renderer)0).sharedMaterials;
			if (sharedMaterials2.Length > (nint)obj5)
			{
				if (~(layer._useCommonMaterial ? 1u : 0u) == 0)
				{
					throw new ArrayTypeMismatchException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v51+10]");
				Material[] sharedMaterials3 = ((Renderer)0).sharedMaterials;
				object obj6 = obj5 << 2;
				object obj7 = (object)sharedMaterials3 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v75+10]");
				material._002Ector((Material)0);
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
			object obj8 = obj2 + 1;
			obj2 = obj8;
		}
	}

	private void OnDestroy()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			break;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3A6");
	}

	public BackgroundObject()
	{
		List<MeshRenderer> list = default;
		list._002Ector();
		_meshRenderers = list;
		List<ParticleSystemRenderer> list2 = default;
		list2._002Ector();
		_particleSystemRenderers = list2;
		List<Material> list3 = default;
		list3._002Ector();
		_materialInstances = list3;
		base._002Ector();
	}
}
