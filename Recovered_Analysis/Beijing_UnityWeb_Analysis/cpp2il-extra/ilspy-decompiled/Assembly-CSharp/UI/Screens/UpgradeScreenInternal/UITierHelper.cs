using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using UnityEngine;

namespace UI.Screens.UpgradeScreenInternal;

public class UITierHelper : MonoBehaviour
{
	public UIAtlas usedAtlas;

	private UpgradeType _type;

	private int _currentTier;

	public bool ResetTiers()
	{
		return (byte)_type != 0;
	}

	public void SetupTiers(UpgradeType type)
	{
		_type = type;
	}

	private void AddActiveIndicator(UISprite parentSprite)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_0603: Expected I4, but got Obj
		//IL_0611: Expected I, but got Obj
		//IL_0627: Expected Obj, but got I
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected Obj, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected Obj, but got Unknown
		//IL_07e3: Expected I4, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_0838: Expected I, but got Obj
		//IL_084e: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_00de: Expected I, but got Obj
		//IL_00f4: Expected Obj, but got I
		//IL_06a7: Expected Obj, but got I4
		//IL_06b9: Expected I4, but got Obj
		//IL_06cc: Expected Obj, but got I4
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected I4, but got Unknown
		//IL_0368: Expected Obj, but got I4
		//IL_031f: Expected I, but got Obj
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_011f: Expected I, but got Obj
		//IL_039a: Expected I, but got Obj
		//IL_03b0: Expected Obj, but got I
		//IL_0729: Expected Obj, but got I4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_0423: Expected Obj, but got I4
		//IL_03db: Expected I, but got Obj
		//IL_079a: Expected Obj, but got I4
		//IL_0440: Expected I, but got Obj
		//IL_0456: Expected Obj, but got I
		//IL_074c: Expected Obj, but got I4
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected Obj, but got Unknown
		//IL_04cd: Expected I4, but got Obj
		//IL_0481: Expected I, but got Obj
		//IL_04f6: Expected Obj, but got I4
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_0522: Expected Obj, but got F4
		//IL_0575: Expected Obj, but got I4
		//IL_0588: Expected Obj, but got I4
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_05bd: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = obj;
		_ = -1;
		_type = (UpgradeType)parentSprite;
		nint num = (nint)typeof(Upgrades);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<Info.Upgrades>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Upgrades);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v154 (Il2CppClass<Info.Upgrades>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 32);
		object obj5 = obj2 + 12;
		Upgrade upgrade = Upgrades.upgrades.get_Item((UpgradeType)parentSprite);
		CollectCoinsDummy[] array = MigrationSave.ParseDummyData((string)(object)parentSprite);
		if ((nint)array == _currentTier)
		{
			return;
		}
		_currentTier = (int)array;
		GameObject gameObject = base.gameObject;
		object current = ((Transform.Enumerator)(object)gameObject).Current;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v138 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v147 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj8 = obj3 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj3 + obj10;
		obj11 = 110;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj3 + obj13;
			if ((nint)obj14 == 110)
			{
				object obj15 = obj3 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				goto IL_0820;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0820;
		IL_0820:
		string panel = tag;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S2_v12 (Il2CppClass<NGUITools>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S2_v65 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIDrawCall uIDrawCall = UIDrawCall.Create((UIPanel)(object)panel, (Material)(object)usedAtlas, (Texture)(object)"progressbar_background", (Shader)int.MaxValue);
		UnityEngine.Object.DestroyImmediate(uIDrawCall, (byte)(int)"Background" != 0);
		object obj19 = upgrade.numberOfTiers * 20;
		int height = obj19 - 10;
		((UIWidget)(object)uIDrawCall).height = height;
		Color color = ((UIWidget)16).color;
		((UIWidget)(object)uIDrawCall).depth = 6;
		Camera anchorCamera = ((UIRect)(object)uIDrawCall).anchorCamera;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S1_v41 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S1_v79 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		transform = (Transform)obj5;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Vector2 localSize = ((UIWidget)11).localSize;
		object obj21 = 0;
		string text2 = default;
		while (true)
		{
			object obj22 = upgrade.numberOfTiers - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
			{
				break;
			}
			string panel2 = tag;
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S2_v35 (Il2CppClass<NGUITools>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S2_v61 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIDrawCall uIDrawCall2 = UIDrawCall.Create((UIPanel)(object)panel2, (Material)(object)usedAtlas, (Texture)(object)"progressbar_bar_off", (Shader)int.MaxValue);
			object obj24 = obj21 + 1;
			obj5 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = "slot" + text2;
			UnityEngine.Object.DestroyImmediate(uIDrawCall2, (byte)(int)text != 0);
			((UIWidget)(object)uIDrawCall2).depth = 6;
			Camera anchorCamera2 = ((UIRect)(object)uIDrawCall2).anchorCamera;
			obj2 = 0;
			_ = 0;
			object obj25 = obj21 * 20;
			float num11 = 5f + (float)obj25;
			obj2 = num11;
			_ = 3f;
			_ = 0f;
			transform = (Transform)obj2;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles2 = transform.eulerAngles;
			((UIWidget)(object)uIDrawCall2).height = 16;
			Color color2 = ((UIWidget)10).color;
			Vector2 localSize2 = ((UIWidget)12).localSize;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<CollectCoinsDummy[], UIntPtr>(ref array))
			{
				((UpgradeHelper)this).UpgradePurchased((UpgradeType)uIDrawCall2);
			}
			object obj26 = obj21 + 1;
			obj21 = obj26;
		}
	}

	public UITierHelper()
	{
		CancelInvoke();
	}
}
