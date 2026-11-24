using System;
using AppRefresh;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

namespace UI.Helpers;

public class FirstPurchaseBonusStoreHelper : MonoBehaviour
{
	private float FIRST_PURCHASE_BONUS_STATIC_OBJECTS_HEIGHT;

	private float FIRST_PURCHASE_BONUS_TOP_STATIC_OBJECTS_HEIGHT;

	private ScrollViewHeightResizer _scrollViewHeightResizer;

	private float _staticObjectsHeightStartValue;

	private float _topStaticObjectsHeightStartValue;

	private bool _hasSetiPhoneXOffsetsIfNecessary;

	private void OnFirstPurchaseBonusBecameInactive()
	{
		CancelInvoke();
	}

	private void Awake()
	{
		ScrollViewHeightResizer scrollViewHeightResizer = _scrollViewHeightResizer;
		scrollViewHeightResizer._staticObjectsHeight = _staticObjectsHeightStartValue;
		ScrollViewHeightResizer scrollViewHeightResizer2 = _scrollViewHeightResizer;
		scrollViewHeightResizer2._topStaticObjectsHeight = _topStaticObjectsHeightStartValue;
		_scrollViewHeightResizer.AddColliders();
	}

	private unsafe void OnEnable()
	{
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_0275: Expected I, but got Obj
		//IL_028b: Expected Obj, but got I
		//IL_02bf: Expected I, but got Obj
		//IL_02d5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_011c: Expected I, but got Obj
		//IL_0176: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_034f: Expected Obj, but got I4
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected I4, but got Unknown
		//IL_01b7: Expected I, but got Obj
		ScrollViewHeightResizer scrollViewHeightResizer = _scrollViewHeightResizer;
		_staticObjectsHeightStartValue = scrollViewHeightResizer._staticObjectsHeight;
		ScrollViewHeightResizer scrollViewHeightResizer2 = _scrollViewHeightResizer;
		_topStaticObjectsHeightStartValue = scrollViewHeightResizer2._topStaticObjectsHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		FirstPurchaseBonusBecameInactive firstPurchaseBonusBecameInactive = default;
		((Delegate)firstPurchaseBonusBecameInactive).method_ptr = method_ptr;
		((Delegate)firstPurchaseBonusBecameInactive).method = (nint)__ldftn(FirstPurchaseBonusStoreHelper.OnFirstPurchaseBonusBecameInactive);
		object obj = firstPurchaseBonusBecameInactive + 16;
		obj = this;
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v14 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v63 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FirstPurchaseBonusManager.onFirstPurchaseBonusBecameInactive -= firstPurchaseBonusBecameInactive;
		nint num3 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v59 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice() || ~(_hasSetiPhoneXOffsetsIfNecessary ? 1u : 0u) == 0)
		{
			return;
		}
		UIWidget component = GetComponent<UIWidget>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			return;
		}
		UIRect.AnchorPoint topAnchor = component.topAnchor;
		nint num7 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v43 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v49 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = IPhoneXSupport.OFFSET_BOTTOM + IPhoneXSupport.OFFSET_TOP;
		int absolute = topAnchor.absolute - obj6;
		topAnchor.absolute = absolute;
		_hasSetiPhoneXOffsetsIfNecessary = true;
	}

	private void OnDestroy()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void SetPropertiesNeededForFirstPurchaseBonus()
	{
		//IL_0078: Expected Obj, but got I4
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		RefreshType refreshType = default;
		object obj = refreshType + 16;
		obj = this;
		nint num2 = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FirstPurchaseBonusManager.AppWillRefresh(refreshType);
	}

	private void ResetProperties()
	{
		ScrollViewHeightResizer scrollViewHeightResizer = _scrollViewHeightResizer;
		scrollViewHeightResizer._staticObjectsHeight = FIRST_PURCHASE_BONUS_STATIC_OBJECTS_HEIGHT;
		ScrollViewHeightResizer scrollViewHeightResizer2 = _scrollViewHeightResizer;
		scrollViewHeightResizer2._topStaticObjectsHeight = FIRST_PURCHASE_BONUS_TOP_STATIC_OBJECTS_HEIGHT;
	}

	public FirstPurchaseBonusStoreHelper()
	{
		ScrollViewHeightResizer scrollViewHeightResizer = _scrollViewHeightResizer;
		scrollViewHeightResizer._staticObjectsHeight = _staticObjectsHeightStartValue;
		ScrollViewHeightResizer scrollViewHeightResizer2 = _scrollViewHeightResizer;
		scrollViewHeightResizer2._topStaticObjectsHeight = _topStaticObjectsHeightStartValue;
	}
}
