using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using UnityEngine;

public class HoverboardBundle : MonoBehaviour
{
	[Serializable]
	public class CustomSet
	{
		public Hoverboard.BoardAbility ability;

		public GameObject baseModelPrefab;

		public GameObject modelPrefab;

		public GameObject VanityFxPrefab;

		public GameObject VanityMenuFxPrefab;

		public bool useDefaultmodel;

		public bool useSuperSneakers;

		public GameObject ExtraFXPrefab;

		public GameObject ExtraMenuFXPrefab;
	}

	private CustomSet[] customSets;

	private bool converted;

	private Boards.BoardId _boardId;

	private string _serializedBoardId;

	private GameObject modelPrefab;

	private GameObject previewModelPrefab;

	private CharacterModel _charactermodel;

	public CustomSet[] CustomSets
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (CustomSet[])_boardId;
		}
	}

	public Boards.BoardId boardId
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (Boards.BoardId)customSets;
		}
	}

	public unsafe CharacterModel Charactermodel
	{
		get
		{
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected I, but got Unknown
			//IL_01b5: Expected Obj, but got I4
			//IL_001e: Expected I, but got Obj
			//IL_0034: Expected Obj, but got I
			//IL_0138: Expected I, but got Obj
			//IL_0153: Expected I, but got Obj
			//IL_0169: Expected Obj, but got I
			//IL_005f: Expected I, but got Obj
			//IL_00ac: Expected I, but got Obj
			object obj = default;
			nint num = (nint)(obj + 4);
			if (~(converted ? 1u : 0u) != 0)
			{
				converted = true;
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num3 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v40 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj = typeof(Boards.BoardId);
				((IntPtr*)num)->m_value = (void*)(nint)obj;
				Type enumType = Type.internal_from_handle((IntPtr)num);
				nint num4 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v31 (Il2CppClass<System.Enum>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v36 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Enum.GetName(enumType, _serializedBoardId);
				throw new NullReferenceException();
			}
			return (CharacterModel)_boardId;
		}
		set
		{
			//IL_005c: Expected I4, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			converted = (byte)(int)value != 0;
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.BoardId? eventBoardType = BoardManager.GetEventBoardType();
		}
	}

	public void AddModel(bool isMenu)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 36;
		obj = isMenu;
	}

	public void AddCustomPreviewModel()
	{
	}

	public void AddCustomBaseModel(int customSet, bool isMenu)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_000d: Expected Obj, but got I4
		((GameObject)customSet).tag = (string)isMenu;
	}

	public void AddCustomSetModelAndEffect(int customSet, bool isMenu, bool addEffect)
	{
		//IL_0008: Expected Obj, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I4
		object obj = customSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = this;
		object obj4 = obj3 + 12;
		obj4 = addEffect;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private unsafe GameObject InstatiateAndParentModelPrefab(GameObject prefab)
	{
		//IL_0198: Expected I4, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0124: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Material> list = default;
		list._002Ector();
		bool flag = default;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)list != 0;
		GameObject gameObject = base.gameObject;
		((EffectPlayer)null).Toggle(gameObject, flag);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)prefab).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [prefab @ L1 (UnityEngine.GameObject)+6C]");
			((EffectPlayer)null).Toggle((GameObject)0, flag);
		}
		if (~(converted ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)customSets).FindKernel((string)null) != 0)
			{
				((EffectPlayer)null).Toggle((GameObject)(object)customSets, flag);
			}
		}
		return (GameObject)(object)list;
	}

	public HoverboardBundle()
	{
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I4
		//IL_0173: Expected I4, but got Obj
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_00b1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)previewModelPrefab).FindKernel((string)null) != 0)
		{
			HoverboardBundle hoverboardBundle = ((HoverboardModelFactory)this).RequestHoverboardInstance((string)(object)previewModelPrefab);
			nint num3 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v13 (Il2CppClass<Layers>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v24 (Il2CppClass<Layers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool startupFinished = LoadLevelCtrl.StartupFinished;
			object obj3 = (startupFinished ? 1 : 0) - -64;
			((GameObject)(object)hoverboardBundle).SetActive((byte)(int)obj3 != 0);
			object obj4 = _charactermodel + 68;
			Renderer component = ((GameObject)(object)hoverboardBundle).GetComponent<Renderer>();
			obj4 = component;
		}
		else
		{
			((HoverboardModelPreviewFactory)this).HandleOnPopupShown((string)1);
		}
	}
}
