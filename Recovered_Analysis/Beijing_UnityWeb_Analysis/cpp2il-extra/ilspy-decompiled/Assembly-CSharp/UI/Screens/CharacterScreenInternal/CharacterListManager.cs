using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Extensions;
using Kiloo.Common.UI;
using SYBO.Subway.Info;
using TopRun.Internal;
using TopRun.UI;
using UI.Pages;
using UI.Popups.AgeRestrictionPopupInternal;
using UI.Screens.BoardScreenInternal;
using UI.Screens.UpgradeScreenInternal;
using UnityEngine;

namespace UI.Screens.CharacterScreenInternal;

public class CharacterListManager
{
	private const string CHARACTER_LIST_MANAGER_DEBUG_LOG_TAG = "Character List manager: ";

	public readonly CharacterScrollListSlot[] _characterSlots;

	private readonly CharacterScreenManager _screenManager;

	private readonly CharacterScreen _characterScreen;

	private bool allModelsLoaded__BackingField;

	public int size => allModelsLoaded__BackingField ? 1 : 0;

	public bool allModelsLoaded
	{
		get
		{
			CharacterScrollListSlot[] characterSlots = _characterSlots;
			return (byte)characterSlots.Length != 0;
		}
		private set
		{
			//IL_0030: Expected Obj, but got I
			//IL_006c: Expected Obj, but got I4
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+18]");
			Delegate obj = (Delegate)0;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
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

	// C# has no syntax for parameterized property 'Item'.
	public CharacterScrollListSlot get_Item(int index)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0033: Expected Obj, but got I4
		int layer = ((GameObject)index).layer;
		GameObject gameObject = _characterScreen.gameObject;
		((Transform)layer).parentInternal = (Transform)(object)gameObject;
		return (CharacterScrollListSlot)index;
	}

	public void set_Item(int index, CharacterScrollListSlot value)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I4
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		allModelsLoaded__BackingField = false;
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		nint num = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v9 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v17 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 12;
		bool running = FirstPurchaseBonusManager.running;
		obj4 = running;
		object obj5 = this + 16;
		obj5 = value;
	}

	// C# has no syntax for parameterized property 'Item'.
	public CharacterScrollListSlot get_Item(Characters.CharacterId characterId)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0023: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		if (Kiloo.Common.Extensions.CollectionExtensions.ValidIndex(_characterSlots, (int)characterId))
		{
			object obj3 = _characterSlots + 16;
			object obj4 = (int)characterId << 2;
			return (CharacterScrollListSlot)(object)(obj3 + obj4);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public CharacterListManager(int size, CharacterScreen characterSscreen)
	{
		if (size == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			int fontSize = default;
			((UILabel)(object)_screenManager).fontSize = fontSize;
		}
	}

	public IEnumerator GetEnumerator()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = allModelsLoaded__BackingField;
		return (IEnumerator)flag;
	}

	public void EnableSlots(bool modelEnabled, bool uiEnabled)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		if (Kiloo.Common.Extensions.CollectionExtensions.ValidIndex(_characterSlots, modelEnabled ? 1 : 0))
		{
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public void SetLoadedState(int slotIndex, bool shouldBeLoaded, int priority)
	{
		((GameOverScreen)this).onTabClicked += null;
		((GameOverScreen)this).OnCoinsChanged();
	}

	public void RefreshCharacter(Characters.CharacterId characterId, int themeIndex)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		object obj = _characterSlots + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _characterSlots + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((CharacterSelectButton)obj5).ReloadButton((byte)characterId != 0, (Characters.CharacterId)themeIndex);
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}

	public void LoadAInitialModels()
	{
		//IL_000b: Expected Obj, but got F4
		_screenManager = (CharacterScreenManager)(-59.5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private List<CharacterScrollListSlot> GetPrioritizedPendingSlots(int centerIndex, bool fullList = false)
	{
		//IL_0224: Expected Obj, but got I
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I
		//IL_0314: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I4
		//IL_0100: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I
		//IL_00a4: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_016a: Expected I4, but got Obj
		//IL_0178: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I
		//IL_020e: Expected Obj, but got I
		//IL_020e: Expected I4, but got Obj
		//IL_01b9: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+30]");
		string tag = ((Component)0).tag;
		GameObject gameObject;
		if (fullList)
		{
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v57 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v69 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+2C]");
			int num3 = NGUITools.CalculateNextDepth((GameObject)(object)tag, ignoreChildrenWithColliders: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+38]");
			UIPanel component = ((Component)0).GetComponent<UIPanel>();
			UpgradeHelper component2 = ((GameObject)num3).GetComponent<UpgradeHelper>();
			component2.RefreshEvent((UpgradeType)centerIndex, (int)component);
			gameObject = (GameObject)num3;
		}
		else
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v38 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v50 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+28]");
			int num6 = NGUITools.CalculateNextDepth((GameObject)(object)tag, ignoreChildrenWithColliders: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+38]");
			UIPanel component3 = ((Component)0).GetComponent<UIPanel>();
			UpgradeHelper component4 = ((GameObject)num6).GetComponent<UpgradeHelper>();
			component4.InitPermanent((UpgradeType)centerIndex, component3);
			gameObject = (GameObject)num6;
		}
		UIDragScrollView component5 = gameObject.GetComponent<UIDragScrollView>();
		object obj3 = component5 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+38]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+74]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = $"{args:000}";
		UnityEngine.Object.DestroyImmediate(gameObject, (byte)(int)text != 0);
		nint num7 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v21 (Il2CppClass<NGUITools>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v31 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.UpdateWidgetCollider(gameObject);
		UpgradeHelper component6 = gameObject.GetComponent<UpgradeHelper>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		GameObject gameObject2 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+74]");
		((UpgradeHelper)null).InitSingle((UpgradeType)gameObject2, (UIPanel)0);
		return (List<CharacterScrollListSlot>)(object)gameObject;
	}

	private void LoadModelsSynchronously(List<CharacterScrollListSlot> pendingSlots)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(pendingSlots & 1) != 0;
		allModelsLoaded__BackingField = flag;
	}

	public unsafe void OnModelLoaded(Characters.CharacterId characterId, int themeIndex, int scrollIndex, GameObject characterModel, bool synchronous)
	{
		//IL_00ae: Expected Obj, but got Ref
		//IL_00bb: Expected Obj, but got I4
		//IL_00eb: Expected Obj, but got Ref
		//IL_00f8: Expected VT, but got I4
		//IL_0106: Expected Obj, but got Ref
		//IL_0113: Expected Obj, but got I4
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_016f: Expected VT, but got Ref
		//IL_017c: Expected F4, but got Obj
		//IL_0177: Expected native int or pointer, but got VT
		//IL_018e: Expected F4, but got I
		//IL_0189: Expected native int or pointer, but got VT
		//IL_01b9: Expected Obj, but got Ref
		//IL_01c6: Expected VT, but got Obj
		//IL_0201: Expected F4, but got Obj
		//IL_01fc: Expected native int or pointer, but got VT
		//IL_0213: Expected F4, but got I
		//IL_020e: Expected native int or pointer, but got VT
		//IL_0221: Expected I, but got Obj
		//IL_0237: Expected Obj, but got I
		//IL_0261: Expected Obj, but got F4
		//IL_0273: Expected I, but got F4
		//IL_028d: Expected Obj, but got VT
		//IL_02bc: Expected Obj, but got I4
		//IL_02de: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		ref Quaternion reference = default;
		Transform transform = (Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference, -64));
		transform = (Transform)((int*)themeIndex)->m_value;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [themeIndex @ L2 (System.Int32)+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform.localPosition;
		Transform transform3 = (Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 40));
		transform3.localPosition = (Vector3)characterId;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 28));
		obj = ((int*)scrollIndex)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [scrollIndex @ L3 (System.Int32)+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v53 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 52));
		((Vector3*)(nint)vector)->x = (float)transform3;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
		transform = (Transform)obj;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v15+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		Vector3 vector2 = vector - (Vector3)transform;
		transform = (Transform)obj3;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v28+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		((Vector3*)(nint)vector)->x = (float)characterModel;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)characterModel).m_CachedPtr;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v35 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v49 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = (Transform)vector.x;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
		Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)transform);
		transform = (Transform)reference;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		transform = (Transform)((bool*)(synchronous ? 1 : 0))->m_value;
		Transform transform7 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [synchronous @ L5 (System.Boolean)+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		((Transform)characterId).parent = transform;
	}

	private void OnInitialModelLoadingComplete()
	{
		//IL_009e: Expected Obj, but got I4
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_012f: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		CharacterScreen characterScreen = _characterScreen;
		bool flag = ((HoverboardOverlayHelper)this).BoardHasFreeThemes((Boards.BoardId)characterScreen._initiallyCenteredCharacterId);
		CharacterScrollListSlot[] characterSlots = _characterSlots;
		Transform transform = (Transform)(characterSlots.Length / 2);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((ComputeShader)flag).FindKernel(null);
		bool flag2 = num3 == 0;
		Transform anchor = transform;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v6 (System.Boolean)+C]");
			anchor = (Transform)0;
		}
		GameObject gameObject = TopRunOnlineScreen.PlaceModelUnderAnchor((GameObject)(object)this, anchor, 0);
		UpdateSlotsState((int)gameObject);
	}

	public void UpdateSlotsState(int centerIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_0259: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj7 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E");
			object obj6 = obj7 + 32;
			obj6 = obj8;
		}
		object obj9 = obj4 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj4 + obj11;
		obj12 = 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj4 + obj13;
			if ((nint)obj14 == 88)
			{
				object obj15 = obj4 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				goto IL_0297;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0297;
		IL_0297:
		allModelsLoaded__BackingField = true;
		CharacterScreen characterScreen = _characterScreen;
		characterScreen._scrollListInitialized = true;
	}

	private bool IsWithinRange(int center, int position, int threshold)
	{
		//IL_012f: Expected Obj, but got I4
		//IL_010d: Expected I4, but got Obj
		//IL_001e: Expected I4, but got Obj
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		bool flag = center == 0;
		bool flag2 = !flag;
		Container container = (Container)center;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Container container2 = default;
			container2.Measure((byte)(int)_characterScreen != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 8;
			ListElementHelper component = container2.model.GetComponent<ListElementHelper>();
			obj = component;
			object obj3 = obj2 + 12;
			obj3 = allModelsLoaded__BackingField;
			object obj4 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+18]");
			obj4 = 0;
			object obj5 = obj2 + 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.CharacterScreenInternal.CharacterListManager)+1C]");
			obj5 = 0;
			object obj6 = container2 + 84;
			obj6 = obj2;
			container = container2;
		}
		if (threshold == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v14 (System.Boolean)+8]");
			string newText = default;
			bool useEffect = default;
			((PageTop)0).UpdateMultiplierText(newText, useEffect);
		}
		return (byte)(int)container != 0;
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_0024: Expected I, but got Obj
		//IL_003a: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		//IL_0194: Expected I4, but got Obj
		//IL_0065: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I4
		//IL_01d8: Expected I4, but got Obj
		//IL_01f6: Expected VT, but got Obj
		//IL_01f6: Expected VT, but got I4
		//IL_00d1: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		GameObject gameObject = TopRunOnlineScreen.PlaceModelUnderAnchor((GameObject)(object)msg, (Transform)context, 1);
		int num2 = default;
		int num5 = default;
		while (true)
		{
			int num = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v6 (UnityEngine.GameObject)+C]");
			if ((nint)num >= (nint)0)
			{
				break;
			}
			CharacterScrollListSlot characterScrollListSlot = ((List<CharacterScrollListSlot>)(object)gameObject).get_Item(num2);
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			bool flag2 = ((UIScreenController)flag).IsPopupQueueEmpty();
			IEnumerator enumerator = ((Manager)null).RequestSubmitScoreCoroutine((int)context, (byte)characterScrollListSlot.index != 0, true);
			object obj3;
			Characters.CharacterId newCharacter;
			if (enumerator != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+10]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v21+AA]");
				bool flag3 = (nint)0 != 0;
				Characters.CharacterId characterId = (Characters.CharacterId)((flag2 ? 1 : 0) ^ 1);
				obj3 = (flag3 ? 1 : 0) & (int)characterId;
				newCharacter = characterId;
			}
			else
			{
				Characters.CharacterId characterId2 = (Characters.CharacterId)((flag2 ? 1 : 0) ^ 1);
				newCharacter = characterId2;
				obj3 = 0;
			}
			bool overrideCharacter = obj3 != null;
			((CharacterSelectButton)(object)characterScrollListSlot).ReloadButton(overrideCharacter, newCharacter);
			IEnumerator enumerator2 = ((Manager)null).RequestSubmitScoreCoroutine((int)context, (byte)characterScrollListSlot.index != 0, true);
			((CharacterThemeButton)(object)msg).SetOutfitColors((Color32)characterScrollListSlot.index, (Color32)enumerator2, num2);
			num2 = num5 + 1;
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}
}
