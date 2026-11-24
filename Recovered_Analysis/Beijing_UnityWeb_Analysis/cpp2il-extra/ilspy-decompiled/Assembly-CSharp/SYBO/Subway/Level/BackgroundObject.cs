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

	public bool AlwaysVisible
	{
		get
		{
			int hashCode = base.GetHashCode();
			return (byte)(hashCode * 29) != 0;
		}
	}

	public bool Movable => _alwaysVisible;

	public Renderer[] Renderers
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool movable = _movable;
			return (Renderer[])movable;
		}
	}

	public List<MeshRenderer> MeshRenderers => (List<MeshRenderer>)(object)_renderers;

	public List<ParticleSystemRenderer> ParticleSystemRenderers => (List<ParticleSystemRenderer>)(object)_meshRenderers;

	private void Awake()
	{
		//IL_00a2: Expected Obj, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_002d: Expected Obj, but got I
		//IL_003d: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)20);
		object obj = this + 12;
		obj = list;
		object obj2 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v3+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S4_v4 (should have been resolved before IL gen)");
		object obj9 = this + 20;
		object obj10 = default;
		obj9 = obj10;
		CancelInvoke();
	}

	public void Initialize(BackgroundLayer layer, Transform parent, Vector3 localPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_03aa: Expected Obj, but got I4
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_0447: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_014c: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj5 = default;
		if ((nint)obj5 != 1)
		{
			return;
		}
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
			string text = layer.Name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.BackgroundObject)+30]");
			bool flag = text == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v77+8]");
			if (0 == (nint)layer.Name)
			{
				if (flag)
				{
					object obj7 = parent + 16200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				nint num = (nint)typeof(EnvironmentInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v101 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(EnvironmentInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v124 (Il2CppClass<SYBO.Subway.Level.EnvironmentInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v107+C]");
				object obj10;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v107+18]");
					object obj9 = (nint)0 << 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v107+14]");
					obj10 = 0 + obj9;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v107+14]");
					obj10 = 0;
				}
				object obj11 = obj10 * 90;
				object obj12 = obj11 + (object)parent;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			else if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v77+8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.BackgroundObject)+30]");
				if (num3 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
			}
		}
		object obj13 = obj4 + 4;
		object obj14 = obj13 + 1;
		obj13 = obj14;
		object obj15 = obj14 << 2;
		object obj16 = obj4 + obj15;
		obj16 = 158;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj4 + obj17;
			if ((nint)obj18 == 158)
			{
				object obj19 = obj4 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_04c3;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04c3;
		IL_04c3:
		_ = layer.Name;
	}

	private void OnDestroy()
	{
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		object obj = this + 20;
		Transform component = GetComponent<Transform>();
		obj = component;
		object obj2 = this + 16;
		MoveGameObject component2 = GetComponent<MoveGameObject>();
		obj2 = component2;
		object obj3 = this + 24;
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>(true);
		obj3 = componentsInParent;
		object obj4 = 0;
		object obj9 = default;
		while (true)
		{
			Renderer[] renderers = _renderers;
			if ((nint)obj4 >= renderers.Length)
			{
				break;
			}
			object obj5 = _renderers + 16;
			object obj6 = obj4 << 2;
			object obj7 = obj5 + obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			}
			else
			{
				object obj10;
				if (obj7 == null)
				{
					obj10 = 0;
				}
				else
				{
					obj10 = ((obj8 != typeof(ParticleSystemRenderer)) ? ((object)0) : obj7);
				}
				if (obj10 != null)
				{
					if (obj7 != null)
					{
						if (obj8 == typeof(ParticleSystemRenderer))
						{
							object obj11 = obj7;
						}
						else
						{
							object obj11 = 0;
						}
					}
					else
					{
						object obj11 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
				}
			}
			object obj12 = obj4 + 1;
			obj4 = obj12;
		}
	}

	public BackgroundObject()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0263: Expected Obj, but got I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v74 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v83 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 51)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				return;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
