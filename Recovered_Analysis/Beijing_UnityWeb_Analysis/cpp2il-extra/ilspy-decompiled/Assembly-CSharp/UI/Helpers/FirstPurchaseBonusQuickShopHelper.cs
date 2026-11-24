using System;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UI.Screens;
using UnityEngine;

namespace UI.Helpers;

public class FirstPurchaseBonusQuickShopHelper : MonoBehaviour
{
	private const int POPUP_WIDTH = 310;

	private UIWidget _scrollViewWidget;

	private GameObject _dynamicContentRoot;

	private CoinScreen _coinScreen;

	private Vector2 _firstPurchaseBonusScrollViewWidgetSize;

	private float _yOffset;

	private GameObject _emptyOffsetWidget;

	private Vector2 _startSize;

	private void Awake()
	{
		CancelInvoke();
	}

	private unsafe void OnFirstPurchaseBonusBecameInactive()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00bd: Expected VT, but got Obj
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		UIWidget scrollViewWidget = _scrollViewWidget;
		UIWidget scrollViewWidget2 = _scrollViewWidget;
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		obj = scrollViewWidget.mWidth;
		_ = scrollViewWidget2.mHeight;
		obj2 = obj;
		object obj3 = obj2 + 16;
		obj3 = obj2;
		_startSize = (Vector2)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		FirstPurchaseBonusBecameInactive firstPurchaseBonusBecameInactive = default;
		((Delegate)firstPurchaseBonusBecameInactive).method_ptr = method_ptr;
		((Delegate)firstPurchaseBonusBecameInactive).method = (nint)__ldftn(FirstPurchaseBonusQuickShopHelper.OnFirstPurchaseBonusBecameInactive);
		object obj4 = firstPurchaseBonusBecameInactive + 16;
		obj4 = this;
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v37 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FirstPurchaseBonusManager.onFirstPurchaseBonusBecameInactive -= firstPurchaseBonusBecameInactive;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr2;
		((Delegate)action).method = (nint)__ldftn(FirstPurchaseBonusQuickShopHelper.OnCoinScreenHasAppeared);
		object obj6 = action + 16;
		obj6 = this;
		_coinScreen.coinScreenHasAppeared -= action;
	}

	private unsafe void OnCoinScreenHasAppeared()
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_006c: Expected Obj, but got VT
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected I4, but got Unknown
		//IL_0087: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_emptyOffsetWidget).FindKernel((string)null) != 0)
		{
			MiscExtensions.SafeInvoke((Action)(object)_emptyOffsetWidget);
		}
		object obj2 = _startSize;
		int num3 = obj2 + 8;
		((int*)num3)->m_value = (int)obj2;
		((MostPopularStickerHelper)this).SetDepthFrom(num3);
	}

	private void SetScrollWidgetSize(Vector2 size)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got VT
		object obj = this + 24;
		obj = size;
	}

	private void AddEmptyOffsetWidgetIfNotExist()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v8 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v12 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private GameObject CreateEmptyWidget(int height)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
		object obj = gameObject + 16;
		obj = this;
		return gameObject;
	}

	public FirstPurchaseBonusQuickShopHelper()
	{
		//IL_016e: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_010e: Expected I4, but got F4
		//IL_01be: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_0121: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_emptyOffsetWidget != null))
		{
			return;
		}
		int rewardIndex = ((_yOffset != _yOffset) ? int.MinValue : ((!(_yOffset < 2.1474836E+09f)) ? int.MinValue : ((_yOffset > -2.1474836E+09f) ? ((int)_yOffset) : int.MinValue)));
		bool layer = ((CelebrationPopup)null).IsTwoStepsCelebration(rewardIndex);
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v14 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v20 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 36;
		GameObject gameObject = NGUITools.AddChild(_dynamicContentRoot, layer ? 1 : 0);
		obj3 = gameObject;
	}
}
