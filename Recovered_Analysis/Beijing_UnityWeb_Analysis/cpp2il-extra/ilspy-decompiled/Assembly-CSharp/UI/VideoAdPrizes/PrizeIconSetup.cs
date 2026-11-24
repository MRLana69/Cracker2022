using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.VideoAdPrizes;

public abstract class PrizeIconSetup
{
	private const string ICON_NAME_MYSTERY_BOX = "icon_MysteryBox_big";

	private const string ICON_NAME_MINI_MYSTERY_BOX = "icon_big_mini_mysteryBox";

	private const string ICON_NAME_SUPER_MYSTERY_BOX = "icon_bigSuperMysteryBox";

	private const string ICON_NAME_COINS = "Icon_coin_pouch_larger";

	private const string ICON_NAME_KEY = "icon_key_cloud";

	protected VideoAdPrizeType _prizeType;

	protected Vector3 _iconPosition;

	protected Vector3 _iconRotation;

	protected int _iconHeight;

	public VideoAdPrizeType prizeType
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.VideoAdPrizes.PrizeIconSetup)+28]");
			return VideoAdPrizeType.NotSet;
		}
	}

	public abstract UISprite iconSprite { get; set; }

	public void Setup()
	{
		_iconHeight = 52;
	}

	public void Deactivate()
	{
		DeactivateSetupIconSprite();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	private void SetupIconSprite()
	{
		OnSetup();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	private void DeactivateSetupIconSprite()
	{
		//IL_03a2: Expected I, but got Obj
		//IL_03b8: Expected Obj, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		//IL_014c: Expected I4, but got Obj
		//IL_016e: Expected I4, but got Obj
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0190: Expected I4, but got Obj
		//IL_01b2: Expected I4, but got Obj
		//IL_0380: Expected Obj, but got I4
		//IL_01d4: Expected I4, but got Obj
		//IL_01ec: Expected I, but got Obj
		//IL_0202: Expected Obj, but got I
		//IL_022d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 24);
		object obj3 = obj2 + 12;
		UnityEngine.Object obj4 = default;
		if (obj4 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Component component = default;
		component.tag = (string)1;
		object obj5 = _prizeType - 1;
		if (_prizeType != VideoAdPrizeType.SuperMysteryBox)
		{
			if ((nint)obj5 != 1)
			{
				if ((nint)obj5 != 2)
				{
					if ((nint)obj5 == 3)
					{
						goto IL_019a;
					}
					if ((nint)obj5 != 4)
					{
						if ((nint)obj5 == 5)
						{
							goto IL_019a;
						}
						nint num3 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v42 (Il2CppClass<UnityEngine.Debug>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num4 = (nint)typeof(Debug);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v48 (Il2CppClass<UnityEngine.Debug>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Debug.LogException((Exception)(object)"PrizeIconSetup: Could not associate VideoAdPrizeType with icon name.");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						UISprite uISprite = default;
						uISprite.fillCenter = (byte)(int)"Icon_coin_pouch_larger" != 0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					UISprite uISprite2 = default;
					uISprite2.fillCenter = (byte)(int)"icon_big_mini_mysteryBox" != 0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				UISprite uISprite3 = default;
				uISprite3.fillCenter = (byte)(int)"icon_MysteryBox_big" != 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			UISprite uISprite4 = default;
			uISprite4.fillCenter = (byte)(int)"icon_bigSuperMysteryBox" != 0;
		}
		goto IL_026c;
		IL_019a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		UISprite uISprite5 = default;
		uISprite5.fillCenter = (byte)(int)"icon_key_cloud" != 0;
		goto IL_026c;
		IL_026c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Component component2 = default;
		GameObject gameObject = component2.gameObject;
		object obj7 = this + 12;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S2_v9+8]");
		_ = 0;
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v12+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Component component3 = default;
		GameObject gameObject2 = component3.gameObject;
		object obj8 = this + 24;
		obj2 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S2_v19+8]");
		_ = 0;
		transform = (Transform)obj2;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 right = transform.right;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		_ = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Color color = ((UIWidget)_iconHeight).color;
	}

	protected virtual void OnSetup()
	{
		//IL_0098: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Component component = default;
			component.tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			_ = 0;
		}
	}

	protected virtual void OnDeactivate()
	{
	}

	public static List<T> GetPrizeIconSetupsWithTypeAndDeactivateTheRest<T>(IEnumerable<T> prizeIconSetups, VideoAdPrizeType prizeType) where T : PrizeIconSetup
	{
		//IL_0808: Expected Obj, but got I4
		//IL_0816: Expected I, but got Obj
		//IL_082c: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_089e: Expected I, but got Obj
		//IL_08b4: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_014a: Expected I, but got Obj
		//IL_0713: Expected I, but got Obj
		//IL_0729: Expected Obj, but got I
		//IL_0197: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0ac9: Expected Obj, but got I
		//IL_0ae1: Expected Obj, but got I
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected Obj, but got Unknown
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Expected Obj, but got Unknown
		//IL_0b1c: Expected I4, but got Obj
		//IL_0b32: Expected Obj, but got I
		//IL_0b42: Expected Obj, but got I
		//IL_0b52: Expected Obj, but got I
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected Obj, but got Unknown
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected Obj, but got Unknown
		//IL_01e4: Expected I, but got Obj
		//IL_01fa: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I
		//IL_0754: Expected I, but got Obj
		//IL_07ab: Expected Obj, but got I
		//IL_0281: Expected I, but got Obj
		//IL_0297: Expected Obj, but got I
		//IL_0225: Expected I, but got Obj
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected Obj, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_0929: Expected I, but got Obj
		//IL_093f: Expected Obj, but got I
		//IL_02c2: Expected I, but got Obj
		//IL_0494: Expected I, but got Obj
		//IL_04aa: Expected Obj, but got I
		//IL_030f: Expected I, but got Obj
		//IL_05cb: Expected I, but got Obj
		//IL_05e1: Expected Obj, but got I
		//IL_04d5: Expected I, but got Obj
		//IL_037b: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_0530: Expected I, but got Obj
		//IL_0546: Expected Obj, but got I
		//IL_099e: Expected Obj, but got I4
		//IL_09b0: Expected I, but got Obj
		//IL_09c6: Expected Obj, but got I
		//IL_0659: Expected I, but got Obj
		//IL_066f: Expected Obj, but got I
		//IL_0685: Expected I, but got Obj
		//IL_069b: Expected Obj, but got I
		//IL_060c: Expected I, but got Obj
		//IL_0a3b: Expected Obj, but got I4
		//IL_0a47: Expected Obj, but got I4
		//IL_09ec: Expected Obj, but got I4
		//IL_03bc: Expected I, but got Obj
		//IL_0a89: Expected I, but got Obj
		//IL_0a9f: Expected Obj, but got I
		//IL_0ab6: Expected I4, but got Obj
		//IL_0571: Expected I, but got Obj
		//IL_0409: Expected I, but got Obj
		//IL_06c6: Expected I, but got Obj
		//IL_0451: Expected Obj, but got I4
		//IL_045e: Expected Obj, but got I4
		//IL_046f: Expected Obj, but got I4
		object o = 0;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v196 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		object obj2 = default;
		nint num5 = default;
		object obj5;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v92 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v98 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)o))
			{
				object obj4 = num5 + 24;
				obj5 = obj4;
				goto IL_086f;
			}
		}
		nint num6 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v25 (Il2CppClass<NGUITools>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v184 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v87 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUITools.mRoot != null)
		{
			int num12 = default;
			UnityEngine.Object obj9;
			Component component;
			int num21 = default;
			while (true)
			{
				nint num10 = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v60 (Il2CppClass<UIRoot>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num11 = (nint)typeof(UIRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v178 (Il2CppClass<UIRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				List<UIRoot> list = UIRoot.list;
				if (num12 >= list._size)
				{
					obj9 = null;
					component = null;
					break;
				}
				nint num13 = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v130 (Il2CppClass<UIRoot>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num14 = (nint)typeof(UIRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v170 (Il2CppClass<UIRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIRoot uIRoot = UIRoot.list.get_Item(num12);
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v139 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num16 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v166 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)uIRoot))
				{
					string tag = uIRoot.tag;
					bool activeSelf = ((GameObject)(object)tag).activeSelf;
					nint num17 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S1_v74 (Il2CppClass<UICamera>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num18 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S1_v83 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int direction = UICamera.GetDirection((string)activeSelf);
					nint num19 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v153 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num20 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v162 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)direction))
					{
						bool flag = UICamera.IsPartOfUI((GameObject)direction);
						TransparencySortMode transparencySortMode = ((Camera)flag).transparencySortMode;
						obj9 = (UnityEngine.Object)direction;
						component = uIRoot;
						if (transparencySortMode != TransparencySortMode.Default)
						{
							break;
						}
					}
				}
				num12 = num21 + 1;
			}
			nint num22 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num23 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v125 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			T val;
			if (obj9 != null)
			{
				bool flag2 = ((MonoBehaviour)(object)"UI").IsInvoking();
				nint num24 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v115 (Il2CppClass<NGUITools>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num25 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ S0_v121 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = NGUITools.IsChild(null, (Transform)flag2);
				val = (T)flag3;
			}
			else
			{
				string tag2 = component.tag;
				nint num26 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S1_v52 (Il2CppClass<NGUITools>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num27 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v58 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				val = (T)(object)NGUITools.FindInParents<T>((GameObject)(object)tag2);
			}
			nint num28 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v78 (Il2CppClass<NGUITools>)+5C]");
			object obj17 = (nint)0 + (nint)40;
			obj17 = val;
			nint num29 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v82 (Il2CppClass<NGUITools>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num30 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S0_v102 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUITools.mRoot.sortingOrder = 100000;
			string tag3 = NGUITools.mRoot.tag;
			nint num31 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S0_v95 (Il2CppClass<NGUITools>)+5C]");
			object obj19 = (nint)0 + (nint)44;
			obj19 = tag3;
			UnityEngine.Object.DestroyImmediate(NGUITools.mGo, (byte)(int)"Immediate Mode GUI" != 0);
		}
		nint num32 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v35 (Il2CppClass<NGUITools>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num33 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v52 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj21 = num5 + 24;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S3_v6+4]");
		object obj23 = 0;
		object obj24 = obj23 & 0x1FFF;
		object obj25 = obj24 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v252 @ S4_v6 (should have been resolved before IL gen)");
		UnityEngine.Object obj26 = default;
		o = obj26;
		UnityEngine.Object.DestroyImmediate(obj26, (byte)(int)prizeIconSetups != 0);
		nint num34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S4_v8 (Il2CppMethodInfo)+C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S4_v9+60]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S4_v10+48]");
		object obj29 = 0;
		object obj30 = obj29 & 0x7FF;
		object obj31 = obj30 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v123 @ S5_v7 (should have been resolved before IL gen)");
		bool flag4 = prizeType == VideoAdPrizeType.NotSet;
		obj5 = obj21;
		if (!flag4)
		{
			object obj32 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v48+8]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			object obj34 = obj21;
			object obj35 = obj33 & 0x3FFF;
			object obj36 = obj35 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v132 @ S3_v11 (should have been resolved before IL gen)");
			obj5 = obj21;
		}
		goto IL_086f;
		IL_086f:
		object obj37 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		List<T> result = default;
		return result;
	}
}
