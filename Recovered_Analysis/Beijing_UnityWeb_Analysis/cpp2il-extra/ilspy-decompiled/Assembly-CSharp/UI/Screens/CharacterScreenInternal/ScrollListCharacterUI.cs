using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.DebugUtil;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo.Common.Plugins.Notifications.Internal;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using UI.Screens.BoardScreenInternal;
using UnityEngine;

namespace UI.Screens.CharacterScreenInternal;

public class ScrollListCharacterUI : MonoBehaviour
{
	private Characters.CharacterId _cachedId;

	private int _placementIndex;

	private Camera _3DClipCam;

	private Camera _2DOverlayCam;

	private bool _hasInited3D;

	private Transform _cachedTransform;

	private Transform _headTransform;

	private Transform _chestTransform;

	private Transform _headTrack;

	private float _xOffset;

	private float _yOffset;

	private UISprite _newBubble;

	private UISprite _limitedBubble;

	private UISprite _limitedIcon;

	private UISprite _giftBubble;

	private UISprite _eventBubble;

	private UISprite _collectBubble;

	private Transform _feetTrack;

	private UISprite _ownedSprite;

	private UISprite _selectedSprite;

	private GameObject _loadingUIContainer;

	private Characters.CharacterId? _eventCharId;

	public unsafe void Init(int index, Characters.CharacterId id, bool selected, Transform transformToTrack)
	{
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0249: Expected Obj, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I4
		//IL_027a: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected VT, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected I4, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected I4, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03d3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0074: Expected VT, but got I4
		//IL_0099: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_02c3: Expected F4, but got Obj
		//IL_02be: Expected native int or pointer, but got VT
		//IL_02d8: Expected F4, but got I
		//IL_02d3: Expected native int or pointer, but got VT
		//IL_02ed: Expected Obj, but got I
		//IL_0126: Expected F4, but got Obj
		//IL_0121: Expected native int or pointer, but got VT
		//IL_013b: Expected F4, but got I
		//IL_0136: Expected native int or pointer, but got VT
		//IL_0150: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I4
		//IL_00da: Expected I, but got Obj
		//IL_0188: Expected I4, but got Obj
		//IL_01c1: Expected Obj, but got I4
		//IL_01e3: Expected F4, but got Obj
		//IL_01de: Expected native int or pointer, but got VT
		//IL_01f5: Expected F4, but got I
		//IL_01f0: Expected native int or pointer, but got VT
		//IL_020f: Expected I4, but got VT
		object obj2 = default;
		object obj = obj2 + 84;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 72;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 60;
		obj4 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 132);
		GameObject gameObject = (GameObject)(obj2 + 120);
		int num3 = obj2 + 108;
		int num4 = obj2 + 96;
		Transform transform = (Transform)(obj2 + 48);
		object obj6 = obj2 + 36;
		object obj7 = obj2 + 24;
		object obj8 = obj2 + 12;
		if (((ComputeShader)index).FindKernel(null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.ScrollListCharacterUI)+68]");
		int layer = ((GameObject)0).layer;
		transform.position = (Vector3)layer;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v46 (Il2CppClass<UIScreenController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v88 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v51 (System.Boolean)+30]");
		Vector3 vector2 = ((Camera)0).WorldToViewportPoint(vector);
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33+8]");
		_ = 0;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33+8]");
		_ = 0;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v37+4]");
		_ = 0;
		_ = 3f;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v70 (System.Boolean)+20]");
		Vector3 vector3 = ((Camera)0).ScreenToViewportPoint(vector);
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		int layer2 = ((GameObject)index).layer;
		((int*)num4)->m_value = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		((int*)num3)->m_value = ((Characters.CharacterId*)(int)id)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L2 (SYBO.Subway.Info.Characters+CharacterId)+8]");
		_ = 0;
		gameObject = (GameObject)((bool*)(selected ? 1 : 0))->m_value;
		GameObject gameObject2 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [selected @ L3 (System.Boolean)+8]");
		((UnityEngine.Object)gameObject2).m_CachedPtr = (IntPtr)0;
		((Vector3*)(nint)vector)->x = (float)transformToTrack;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transformToTrack).m_CachedPtr;
		((CharacterListManager)null).OnModelLoaded((Characters.CharacterId)layer2, num4, num3, gameObject, (byte)(int)vector != 0);
	}

	public unsafe void Init2D(int index, Characters.CharacterId id, bool selected)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected VT, but got Unknown
		//IL_0036: Expected F4, but got Obj
		//IL_0031: Expected native int or pointer, but got VT
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_005e: Expected F4, but got Obj
		//IL_0059: Expected native int or pointer, but got VT
		//IL_0073: Expected F4, but got I
		//IL_006e: Expected native int or pointer, but got VT
		//IL_0082: Expected I4, but got VT
		//IL_0082: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I4
		//IL_00af: Expected F4, but got Obj
		//IL_00aa: Expected native int or pointer, but got VT
		//IL_00c9: Expected F4, but got Obj
		//IL_00c4: Expected native int or pointer, but got VT
		//IL_00de: Expected F4, but got I
		//IL_00d9: Expected native int or pointer, but got VT
		//IL_00ed: Expected I4, but got VT
		//IL_00ed: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 36;
		obj = ((int*)index)->m_value;
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 40);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		object obj3 = obj2 + 16;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)_cachedId).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj4 = obj2 + 32;
		obj4 = ((Characters.CharacterId*)(int)id)->value__;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)_placementIndex).rawPivot = (UIWidget.Pivot)matrix4x;
		_cachedTransform = (Transform)selected;
	}

	public void Init3D(Transform transformToTrack)
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0061: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)_hasInited3D).FindKernel(null) != 0)
		{
			((GameObject)_hasInited3D).tag = (string)(object)transformToTrack;
		}
	}

	public void OnModelDestroyed()
	{
		CancelInvoke();
	}

	private void OnEnable()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		_hasInited3D = false;
		object obj = this + 36;
		obj = 0;
		object obj2 = this + 40;
		obj2 = 0;
		_loadingUIContainer.tag = (string)1;
	}

	private unsafe void OnDisable()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0081: Expected VT, but got Obj
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		HoverboardOverlayHelper hoverboardOverlayHelper = default;
		hoverboardOverlayHelper.RefreshSelected(selected: false);
		object obj = hoverboardOverlayHelper + 8;
		obj = hoverboardOverlayHelper;
		_eventCharId = (Characters.CharacterId?)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(ScrollListCharacterUI.EnableEventRelatedElements);
		object obj2 = action + 16;
		obj2 = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v32 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventStartedHandler -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(ScrollListCharacterUI.EnableEventRelatedElements);
		object obj4 = action2 + 16;
		obj4 = this;
		SSEventsManagerController.OnSSEventFinishedHandler -= action2;
	}

	private unsafe void EnableEventRelatedElements()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(ScrollListCharacterUI.EnableEventRelatedElements);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v24 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventsManagerController.OnSSEventFinishedHandler += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(ScrollListCharacterUI.EnableEventRelatedElements);
		object obj3 = action2 + 16;
		obj3 = this;
		SSEventsManagerController.OnSSEventChangedHandler += action2;
	}

	public int GetIndex()
	{
		//IL_0007: Expected I4, but got Obj
		return (int)_cachedTransform;
	}

	public void RefreshOverlay()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_002e: Expected VT, but got Obj
		HoverboardOverlayHelper hoverboardOverlayHelper = default;
		hoverboardOverlayHelper.RefreshSelected(selected: false);
		object obj = hoverboardOverlayHelper + 8;
		obj = hoverboardOverlayHelper;
		_eventCharId = (Characters.CharacterId?)obj;
		SelectedInMenu();
	}

	public void SelectedInMenu()
	{
		Characters.CharacterId? characterId = ((ScrollListCharacterUI)null).EventCharacter();
	}

	private void RefreshSelection(bool selected)
	{
		//IL_00d9: Expected I, but got Obj
		//IL_00ef: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I4
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 36;
		CharacterRendering instance = CharacterRendering.Instance;
		Material cachedModelMaterial = instance._cachedModelMaterial;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v3 (UnityEngine.Material)+C0]");
		UnityEngine.Object key = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
		object obj3 = ((AndroidNotification)selected).get_Item((string)(object)key);
		obj2 = obj3;
		object obj4 = this + 40;
		CharacterRendering instance2 = CharacterRendering.Instance;
		Material cachedModelMaterial2 = instance2._cachedModelMaterial;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v8 (UnityEngine.Material)+B4]");
		UnityEngine.Object key2 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
		object obj5 = ((AndroidNotification)selected).get_Item((string)(object)key2);
		obj4 = obj5;
		_hasInited3D = true;
		_loadingUIContainer.tag = null;
	}

	public Characters.CharacterId GetCharacterType()
	{
		return (Characters.CharacterId)_placementIndex;
	}

	private Characters.CharacterId? EventCharacter()
	{
		//IL_0664: Expected Obj, but got I4
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_0016: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I4
		//IL_010d: Expected I, but got Obj
		//IL_003a: Expected Obj, but got I
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected Obj, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_0713: Expected I, but got Obj
		//IL_0729: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I4
		//IL_0219: Expected Obj, but got I4
		//IL_019b: Expected I, but got Obj
		//IL_00a6: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_01fd: Expected Obj, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_02f5: Expected I, but got Obj
		//IL_030b: Expected Obj, but got I
		//IL_029a: Expected I, but got Obj
		//IL_0336: Expected I, but got Obj
		//IL_0801: Expected I, but got Obj
		//IL_0817: Expected Obj, but got I
		//IL_04c8: Expected Obj, but got I4
		//IL_044a: Expected I, but got Obj
		//IL_03bc: Expected I, but got Obj
		//IL_03d2: Expected Obj, but got I
		//IL_0857: Expected Obj, but got I
		//IL_087a: Expected Obj, but got I4
		//IL_088b: Expected Obj, but got I
		//IL_049a: Expected Obj, but got I
		//IL_04ac: Expected Obj, but got I4
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_0507: Expected Obj, but got I4
		//IL_0518: Expected Obj, but got I
		//IL_03fd: Expected I, but got Obj
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_0568: Expected Obj, but got I4
		//IL_0579: Expected Obj, but got I
		//IL_05b6: Expected Obj, but got I4
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected Obj, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected Obj, but got Unknown
		//IL_08c0: Expected Obj, but got I4
		//IL_08d1: Expected Obj, but got I
		//IL_05a4: Expected Obj, but got I4
		//IL_05fa: Expected Obj, but got I4
		//IL_05df: Expected VT, but got Obj
		//IL_05e8: Expected Obj, but got I4
		//IL_092d: Expected Obj, but got I4
		//IL_091a: Expected Obj, but got I4
		//IL_091a: Expected Obj, but got VT
		//IL_09fd: Expected VT, but got Obj
		//IL_0643: Expected VT, but got Obj
		//IL_0651: Expected Obj, but got I4
		object obj = 0;
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+3C]");
			string text = ((Component)0).tag;
			((GameObject)(object)text).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+44]");
			string text2 = ((Component)0).tag;
			((GameObject)(object)text2).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+38]");
			string text3 = ((Component)0).tag;
			((GameObject)(object)text3).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+48]");
			string text4 = ((Component)0).tag;
			((GameObject)(object)text4).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+4C]");
			string text5 = ((Component)0).tag;
			((GameObject)(object)text5).tag = null;
			goto IL_0656;
		}
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v174 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, Characters.Model> characterData = Characters.characterData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
		Characters.Model model = characterData.get_Item(Characters.CharacterId.slick);
		object obj5;
		if (model.unlockType == PurchaseData.UnlockType.RewardForInApp)
		{
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v157 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v170 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.inAppLegacyPurchaseCount != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
				bool updateAutomatically = ((CoinBoxSizer)0).updateAutomatically;
				object obj4 = (updateAutomatically ? 1 : 0) ^ 1;
				obj5 = obj4 & 1;
			}
			else
			{
				obj5 = 0;
			}
		}
		else
		{
			obj5 = 0;
		}
		Characters.CharacterId? characterId = default;
		object obj6 = (Nullable)characterId + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v27+4]");
		object obj8;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+60]");
			obj = 0;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
			bool flag = obj7 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			bool flag2 = (nint)0 != 0;
			obj8 = flag & flag2;
		}
		else
		{
			obj8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
		bool flag3 = CharacterStickerManager.HasCharacterNewTheme(Characters.CharacterId.slick);
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v34 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v141 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4;
		if (UserSave.lastPurchasedBundle != InAppData.BundleTier.None)
		{
			flag4 = false;
		}
		else
		{
			nint num7 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v104 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v134 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Characters.CharacterId, Characters.Model> characterData2 = Characters.characterData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
			Characters.Model model2 = characterData2.get_Item(Characters.CharacterId.slick);
			if (~(model2.isNewInThisUpdate ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
				if (!CharacterStickerManager.IsCharacterUnlocked(Characters.CharacterId.slick))
				{
					nint num9 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v125 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num10 = (nint)typeof(CharacterManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v130 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
					bool flag5 = CharacterManager.IsCollectionComplete(Characters.CharacterId.slick);
					bool flag6 = !flag5;
					flag4 = true;
					if (flag6)
					{
						goto IL_07f3;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
			flag4 = CharacterStickerManager.HasCharacterBeenSeen(Characters.CharacterId.slick);
		}
		goto IL_07f3;
		IL_0656:
		return characterId;
		IL_07f3:
		nint num11 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v42 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num12 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v97 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<Characters.CharacterId, Characters.Model> characterData3 = Characters.characterData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
		Characters.Model model3 = characterData3.get_Item(Characters.CharacterId.slick);
		object obj14;
		if (~(model3.hasOnlineSettings ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+C]");
			bool updateAutomatically2 = ((CoinBoxSizer)0).updateAutomatically;
			object obj13 = (updateAutomatically2 ? 1 : 0) ^ 1;
			obj14 = obj13 & 1;
		}
		else
		{
			obj14 = 0;
		}
		bool flag7 = obj8 != null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+4C]");
		string text6 = ((Component)0).tag;
		bool flag8 = obj5 != null;
		((GameObject)(object)text6).tag = (string)flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+48]");
		string text7 = ((Component)0).tag;
		object obj15 = obj5 ^ 1;
		object obj16 = obj8 & obj15;
		bool flag9 = obj16 != null;
		((GameObject)(object)text7).tag = (string)flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+44]");
		string text8 = ((Component)0).tag;
		object obj17 = obj8 | obj5;
		object obj18 = obj17 ^ 1;
		object obj19 = obj18 & flag3;
		bool flag10 = obj19 != null;
		((GameObject)(object)text8).tag = (string)flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+38]");
		string text9 = ((Component)0).tag;
		object obj20;
		if (flag8)
		{
			obj20 = 0;
		}
		else
		{
			object obj21 = flag7 | flag3;
			object obj22 = obj21 ^ 1;
			obj20 = obj22 & 1;
		}
		object obj23 = obj20 & flag4;
		bool flag11 = obj23 != null;
		((GameObject)(object)text9).tag = (string)flag11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (System.Nullable`1<SYBO.Subway.Info.Characters+CharacterId>)+3C]");
		string text10 = ((Component)0).tag;
		object obj24;
		if (flag8)
		{
			characterId = (Characters.CharacterId?)(object)text10;
			obj24 = 0;
		}
		else
		{
			object obj25 = flag7 | flag3;
			string text11 = ((obj25 == null) ? null : text10);
			obj24 = (flag4 ? 1 : 0) ^ 1;
			bool flag12 = !flag3;
			bool flag13 = !flag12;
			string text12 = text11;
			if (!flag13)
			{
				text12 = text10;
			}
			bool flag14 = !flag7;
			bool flag15 = !flag14;
			characterId = (Characters.CharacterId?)(object)text10;
			if (!flag15)
			{
				characterId = (Characters.CharacterId?)(object)text12;
			}
			if (obj25 != null)
			{
				obj24 = 0;
			}
		}
		object obj26 = obj24 & obj14;
		bool flag16 = obj26 != null;
		((GameObject)characterId).tag = (string)flag16;
		goto IL_0656;
	}

	private void Update()
	{
		//IL_009d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		if (!CharacterStickerManager.IsCharacterUnlocked(_cachedId))
		{
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveGameDebug.lastLoadedSave = (string)_cachedId;
		}
		Characters.CharacterId? characterId = ((ScrollListCharacterUI)1).EventCharacter();
	}

	private void UpdateSelection()
	{
		//IL_003e: Expected Obj, but got I4
		LateUpdate();
		if (_limitedBubble.hasVertices && ((CoinBoxSizer)_cachedId).updateAutomatically)
		{
			string text = _limitedBubble.tag;
			((GameObject)(object)text).tag = null;
		}
	}

	private void LateUpdate()
	{
		//IL_0024: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		bool flag = currentBoardId == (Boards.BoardId)_cachedId;
		bool updateAutomatically = ((CoinBoxSizer)_cachedId).updateAutomatically;
		string text = _selectedSprite.tag;
		((GameObject)(object)text).tag = (string)flag;
		string text2 = _ownedSprite.tag;
		object obj = (flag ? 1 : 0) ^ 1;
		string text3 = (string)(updateAutomatically & obj);
		((GameObject)(object)text2).tag = text3;
	}

	public unsafe ScrollListCharacterUI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0178: Expected Obj, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I4
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got I4
		//IL_01e0: Expected VT, but got Obj
		//IL_01ef: Expected VT, but got Obj
		//IL_0203: Expected VT, but got Obj
		//IL_0240: Expected F4, but got Obj
		//IL_023b: Expected native int or pointer, but got VT
		//IL_0255: Expected F4, but got I
		//IL_0250: Expected native int or pointer, but got VT
		//IL_028f: Expected F4, but got Obj
		//IL_028a: Expected native int or pointer, but got VT
		//IL_02a4: Expected F4, but got I
		//IL_029f: Expected native int or pointer, but got VT
		//IL_02ed: Expected F4, but got Obj
		//IL_02e8: Expected native int or pointer, but got VT
		//IL_0302: Expected F4, but got I
		//IL_02fd: Expected native int or pointer, but got VT
		//IL_0313: Expected Ref, but got VT
		//IL_035e: Expected VT, but got Obj
		//IL_036c: Expected Obj, but got I4
		//IL_039e: Expected F4, but got Obj
		//IL_0399: Expected native int or pointer, but got VT
		//IL_03b3: Expected F4, but got I
		//IL_03ae: Expected native int or pointer, but got VT
		//IL_03bc: Expected Obj, but got VT
		//IL_03cf: Expected VT, but got Obj
		//IL_03e3: Expected VT, but got Obj
		//IL_03f2: Expected VT, but got Obj
		//IL_0410: Expected Obj, but got F4
		//IL_0434: Expected F4, but got Obj
		//IL_042f: Expected native int or pointer, but got VT
		//IL_0449: Expected F4, but got I
		//IL_0444: Expected native int or pointer, but got VT
		//IL_047e: Expected F4, but got Obj
		//IL_0479: Expected native int or pointer, but got VT
		//IL_0493: Expected F4, but got I
		//IL_048e: Expected native int or pointer, but got VT
		//IL_04dc: Expected F4, but got Obj
		//IL_04d7: Expected native int or pointer, but got VT
		//IL_04f1: Expected F4, but got I
		//IL_04ec: Expected native int or pointer, but got VT
		//IL_0502: Expected Ref, but got VT
		//IL_053a: Expected VT, but got Obj
		//IL_0549: Expected VT, but got Obj
		//IL_0566: Expected Obj, but got F4
		//IL_059a: Expected F4, but got Obj
		//IL_0595: Expected native int or pointer, but got VT
		//IL_05af: Expected F4, but got I
		//IL_05aa: Expected native int or pointer, but got VT
		//IL_05b8: Expected Obj, but got VT
		Transform transform = default;
		Vector3 vector = (Vector3)(transform + 300);
		Transform transform2 = (Transform)(transform + 216);
		Transform transform3 = (Transform)(transform + 204);
		Transform transform4 = (Transform)(transform + 192);
		object obj = transform + 180;
		object obj2 = transform + 168;
		Transform transform5 = (Transform)(transform + 156);
		object obj3 = transform + 144;
		object obj4 = transform + 132;
		Transform transform6 = (Transform)(transform + 120);
		object obj5 = transform + 108;
		Transform transform7 = (Transform)(transform + 96);
		Transform transform8 = (Transform)(transform + 84);
		Transform transform9 = (Transform)(transform + 72);
		object obj6 = transform + 60;
		object obj7 = transform + 48;
		Transform transform10 = (Transform)(transform + 36);
		object obj8 = transform + 24;
		Transform transform11 = (Transform)(transform + 12);
		object obj9 = transform + 288;
		obj9 = 0;
		_ = 0;
		object obj10 = transform + 276;
		obj10 = 0;
		_ = 0;
		object obj11 = transform + 264;
		obj11 = 0;
		_ = 0;
		object obj12 = transform + 252;
		obj12 = 0;
		_ = 0;
		object obj13 = transform + 240;
		obj13 = 0;
		_ = 0;
		object obj14 = transform + 228;
		obj14 = 0;
		_ = 0;
		if (~(_hasInited3D ? 1u : 0u) == 0)
		{
			transform2.position = (Vector3)_chestTransform;
			transform3.position = (Vector3)_headTransform;
			transform4.position = (Vector3)_chestTransform;
			obj9 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (UnityEngine.Transform)+4]");
			float num = 0f * _yOffset;
			_ = ((UnityEngine.Object)transform4).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v43+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = _3DClipCam.WorldToViewportPoint(vector);
			obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v46+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector3 = _2DOverlayCam.ScreenToViewportPoint(vector);
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15+8]");
			_ = 0;
			Transform parentInternal = _cachedTransform.parentInternal;
			((Vector3*)(nint)vector)->x = (float)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
			((Vector3*)(nint)vector)->z = 0f;
			transform5.Internal_LookAt_Injected(ref *(Vector3*)parentInternal, ref *(Vector3*)vector);
			obj11 = transform5;
			_ = ((UnityEngine.Object)transform5).m_CachedPtr;
			obj3 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
			_ = 0;
			obj4 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v49+8]");
			_ = 0;
			transform6.localPosition = (Vector3)_cachedTransform;
			obj5 = 0;
			_ = 0;
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform6).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v25+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 eulerAngles = ((Transform)vector).eulerAngles;
			transform7.position = (Vector3)_chestTransform;
			transform8.position = (Vector3)_chestTransform;
			transform9.position = (Vector3)_chestTransform;
			float num2 = (float)transform7 * _xOffset;
			obj12 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v29 (UnityEngine.Transform)+4]");
			_ = 0;
			_ = ((UnityEngine.Object)transform9).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v52+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector4 = _3DClipCam.WorldToViewportPoint(vector);
			obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v33+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v55+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector5 = _2DOverlayCam.ScreenToViewportPoint(vector);
			obj14 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v35+8]");
			_ = 0;
			Transform parentInternal2 = _cachedTransform.parentInternal;
			((Vector3*)(nint)vector)->x = (float)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+8]");
			((Vector3*)(nint)vector)->z = 0f;
			transform10.Internal_LookAt_Injected(ref *(Vector3*)parentInternal2, ref *(Vector3*)vector);
			obj14 = transform10;
			_ = ((UnityEngine.Object)transform10).m_CachedPtr;
			obj8 = transform10;
			_ = ((UnityEngine.Object)transform10).m_CachedPtr;
			transform11.localPosition = (Vector3)_cachedTransform;
			transform.localPosition = (Vector3)_cachedTransform;
			float num3 = (float)obj8 + 20f;
			obj14 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v41 (UnityEngine.Transform)+4]");
			float num4 = 0f - 20f;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v58+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 eulerAngles2 = ((Transform)vector).eulerAngles;
		}
	}
}
