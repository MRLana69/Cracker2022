using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway.Level.Environments;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.U2D;

namespace SYBO.Subway.Level;

public class Selector : MonoBehaviour
{
	private bool _initialized;

	protected Transform _transform;

	private Action<List<Selector>> m_PerformingSelection;

	public bool Initialized
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)this.m_PerformingSelection != 0;
		}
	}

	internal event Action<List<Selector>> PerformingSelection
	{
		add
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PoolManager.AddPool((PrefabPool)(object)value);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_PerformingSelection;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void Awake()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DistantEnvironmentController.DistantObjectGlobalConfig distantObjectGlobalConfig = default;
		distantObjectGlobalConfig._002Ector();
		object obj = this + 16;
		obj = distantObjectGlobalConfig;
		object obj2 = this + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = default;
		obj2 = obj3;
		((Validator<>)(object)this)._002Ector();
	}

	private void OnDisable()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected virtual void Start()
	{
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_010a: Expected Obj, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0067: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I4
		Sprite sprite = null;
		while (true)
		{
			int siblingIndex = _transform.GetSiblingIndex();
			if ((nint)sprite >= siblingIndex)
			{
				break;
			}
			bool flag = ((SpriteAtlas)(object)_transform).CanBindTo(sprite);
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				bool flag2 = ((SpriteAtlas)(object)_transform).CanBindTo(sprite);
				string text = ((Component)flag2).tag;
				((GameObject)(object)text).tag = null;
			}
			Sprite sprite2 = (Sprite)(sprite + 1);
			sprite = sprite2;
		}
	}

	protected virtual void Initialize()
	{
	}

	public virtual void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_PerformingSelection;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)objectsToVisit);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 20;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public void PerformSelection(List<GameObject> objectsToVisit, List<Selector> subSelectors)
	{
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_0259: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_00b6: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_01b7: Expected I4, but got Obj
		//IL_01d2: Expected Obj, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Selector)+18]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Selector)+18]");
			string obj2 = ((Component)0).tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
		MeshFilter meshFilter = ((GameObject)(object)stream).AddComponent<MeshFilter>();
		meshFilter.mesh = (Mesh)_initialized;
		object obj4 = this + 28;
		MeshRenderer meshRenderer = ((GameObject)(object)stream).AddComponent<MeshRenderer>();
		obj4 = meshRenderer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Selector)+1C]");
		((Renderer)0).sharedMaterials = (Material[])(object)objectsToVisit;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Selector)+1C]");
		Material sharedMaterial = ((Renderer)0).sharedMaterial;
		sharedMaterial.EnableKeyword((string)(object)subSelectors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Selector)+1C]");
		Material sharedMaterial2 = ((Renderer)0).sharedMaterial;
		((SkinnedMeshRenderer)(object)sharedMaterial2).SetBlendShapeWeight((int)"_BackgroundCullingAlpha", 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Selector)+1C]");
		((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
		object obj5 = this + 24;
		int layer = ((GameObject)(object)stream).layer;
		obj5 = layer;
	}

	protected void InitializeCheck()
	{
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0067: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I4
		object obj = this + 16;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		Sprite sprite = null;
		while (true)
		{
			int siblingIndex = _transform.GetSiblingIndex();
			if ((nint)sprite >= siblingIndex)
			{
				break;
			}
			bool flag = ((SpriteAtlas)(object)_transform).CanBindTo(sprite);
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				bool flag2 = ((SpriteAtlas)(object)_transform).CanBindTo(sprite);
				string text = ((Component)flag2).tag;
				((GameObject)(object)text).tag = null;
			}
			Sprite sprite2 = (Sprite)(sprite + 1);
			sprite = sprite2;
		}
		_initialized = true;
	}

	public Selector()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
