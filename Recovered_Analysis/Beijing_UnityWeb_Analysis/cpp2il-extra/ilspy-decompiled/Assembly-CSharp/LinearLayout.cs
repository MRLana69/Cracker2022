using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.U2D;

public class LinearLayout : MonoBehaviour
{
	public enum LayoutDirection
	{
		Horizontal
	}

	public enum LayoutAlignment
	{
		Center
	}

	private bool _updateManually;

	private int _horizontalSpacing;

	private bool _useHorizontalWeights;

	private WeightList _layoutWeights;

	public WeightList LayoutWeights
	{
		get
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			WeightList weightList = default;
			weightList._entries = null;
			object obj = weightList + 16;
			obj = this;
			return weightList;
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
		//IL_0019: Expected I4, but got Obj
		GameObject gameObject = base.gameObject;
		((OverlayIndex)(object)_layoutWeights).index = (int)gameObject;
	}

	public void UpdateChildren()
	{
		if (~(_updateManually ? 1u : 0u) != 0)
		{
			this._002Ector();
		}
	}

	private void UpdateWidgetAnchors(UIWidget widget)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LinearLayout)+2D]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LinearLayout)+2E]");
		if ((nint)0 == 0)
		{
			object obj = widget & 1;
			float maxDelay = NetworkServer.maxDelay;
			if ((object)widget == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LinearLayout)+20]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LinearLayout)+1C]");
				object obj2 = num - 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LinearLayout)+24]");
				object obj3 = 0 + obj2;
			}
		}
	}

	public unsafe LinearLayout()
	{
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected Obj, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected Obj, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected Obj, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected Obj, but got Unknown
		//IL_09ed: Expected Obj, but got I4
		//IL_0794: Expected Obj, but got I4
		//IL_00a1: Invalid comparison between I4 and F4
		//IL_03af: Expected Obj, but got I4
		//IL_00df: Invalid comparison between I4 and F4
		//IL_09a1: Expected Obj, but got I4
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected Obj, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected Obj, but got Unknown
		//IL_07f2: Expected Obj, but got I4
		//IL_07ff: Expected Obj, but got I4
		//IL_0815: Expected VT, but got Obj
		//IL_081e: Expected Obj, but got I4
		//IL_0a7c: Expected Obj, but got I4
		//IL_0a8e: Expected I, but got Obj
		//IL_0aa4: Expected Obj, but got I
		//IL_0138: Expected Obj, but got I4
		//IL_0834: Expected VT, but got Obj
		//IL_083d: Expected Obj, but got I4
		//IL_0acb: Expected Obj, but got I4
		//IL_0853: Expected VT, but got Obj
		//IL_085c: Expected Obj, but got I4
		//IL_0879: Expected Obj, but got F4
		//IL_0447: Expected I, but got Obj
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected Obj, but got Unknown
		//IL_0afa: Expected I, but got Obj
		//IL_0b10: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I4
		//IL_04b0: Expected I, but got Obj
		//IL_0b3b: Expected I, but got Obj
		//IL_0b51: Expected Obj, but got I
		//IL_0c63: Expected Obj, but got I4
		//IL_0c75: Expected I, but got Obj
		//IL_0c8b: Expected Obj, but got I
		//IL_01b1: Expected I4, but got Obj
		//IL_01f2: Invalid comparison between I4 and F4
		//IL_0620: Expected I, but got Obj
		//IL_051d: Expected I, but got Obj
		//IL_0288: Expected I, but got Obj
		//IL_022b: Invalid comparison between I4 and F4
		//IL_0d40: Expected I, but got Obj
		//IL_0d56: Expected Obj, but got I
		//IL_0569: Expected VT, but got I4
		//IL_0571: Expected I, but got Obj
		//IL_02d4: Expected VT, but got Obj
		//IL_02e1: Expected VT, but got Obj
		//IL_05b2: Invalid comparison between Obj and F4
		//IL_02ef: Expected Obj, but got I4
		//IL_0305: Expected Obj, but got I4
		//IL_0633: Expected I, but got Obj
		//IL_05eb: Invalid comparison between Obj and F4
		//IL_0b9c: Expected Obj, but got I
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected I4, but got Unknown
		//IL_0bb2: Expected Obj, but got I4
		//IL_0bbf: Expected Obj, but got I4
		//IL_0bd0: Expected VT, but got Obj
		//IL_0be3: Expected I, but got Obj
		//IL_0bf9: Expected Obj, but got I
		//IL_06b5: Expected Obj, but got I4
		//IL_06c6: Expected VT, but got Obj
		//IL_06d4: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I4
		//IL_08e8: Expected I, but got Obj
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 48);
		Transform transform3 = (Transform)(transform2 + 36);
		Transform transform4 = (Transform)(transform2 + 24);
		object obj = transform2 + 12;
		GameObject gameObject = base.gameObject;
		if (((Transform)(object)gameObject).GetSiblingIndex() == 0)
		{
			return;
		}
		UIWidget component = GetComponent<UIWidget>();
		int num = component.mWidth;
		if (~(_useHorizontalWeights ? 1u : 0u) == 0)
		{
			GameObject gameObject2 = base.gameObject;
			int siblingIndex = ((Transform)(object)gameObject2).GetSiblingIndex();
			if (component.mWidth != component.mWidth)
			{
				num = int.MinValue;
			}
			else if (!((float)component.mWidth < 2.1474836E+09f))
			{
				num = int.MinValue;
			}
			else if (!((float)component.mWidth > -2.1474836E+09f))
			{
				num = int.MinValue;
			}
			object obj2 = siblingIndex - 1;
			object obj3 = obj2 * _horizontalSpacing;
			object obj4 = num - obj3;
			int index = ((OverlayIndex)(object)_layoutWeights).index;
			Sprite sprite = null;
			while (true)
			{
				GameObject gameObject3 = base.gameObject;
				int siblingIndex2 = ((Transform)(object)gameObject3).GetSiblingIndex();
				if ((nint)sprite >= siblingIndex2)
				{
					break;
				}
				GameObject gameObject4 = base.gameObject;
				bool flag = ((SpriteAtlas)(object)gameObject4).CanBindTo(sprite);
				string text = ((Component)flag).tag;
				if (((GameObject)(object)text).activeInHierarchy)
				{
					UIWidget component2 = ((Component)flag).GetComponent<UIWidget>();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77AA");
					int num3;
					if (~(_useHorizontalWeights ? 1u : 0u) == 0)
					{
						transform2 = transform2;
						int num2 = obj4 * (object)transform2;
						num3 = ((num2 != num2) ? int.MinValue : ((!((float)num2 < 2.1474836E+09f)) ? int.MinValue : (((float)num2 > -2.1474836E+09f) ? num2 : int.MinValue)));
					}
					else
					{
						num3 = component2.mWidth;
					}
					component2.height = num3;
					BoxCollider component3 = ((Component)flag).GetComponent<BoxCollider>();
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v184 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num5 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S0_v206 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)component3).FindKernel((string)null) != 0)
					{
						((BoxCollider)(object)transform).size = (Vector3)component3;
						((BoxCollider)(object)transform3).size = (Vector3)component3;
						transform4 = (Transform)0;
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						transform4 = (Transform)num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
						_ = 0;
						((UnityEngine.Object)transform4).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
						transform2 = transform4;
						((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
						component3.get_center_Injected(out *(Vector3*)transform2);
					}
					((WeightList)(object)this).AddWeightEntry((Transform)(object)component2);
				}
				Sprite sprite2 = (Sprite)(sprite + 1);
				sprite = sprite2;
			}
		}
		float num6 = 0f;
		Sprite sprite3 = null;
		Sprite sprite4 = (Sprite)(-1);
		while (true)
		{
			GameObject gameObject5 = base.gameObject;
			int siblingIndex3 = ((Transform)(object)gameObject5).GetSiblingIndex();
			bool flag2 = (nint)sprite3 < siblingIndex3;
			GameObject gameObject6 = base.gameObject;
			if (flag2)
			{
				bool flag3 = ((SpriteAtlas)(object)gameObject6).CanBindTo(sprite3);
				string text2 = ((Component)flag3).tag;
				if (((GameObject)(object)text2).activeInHierarchy)
				{
					bool flag4;
					if ((nint)sprite4 > -1)
					{
						GameObject gameObject7 = base.gameObject;
						flag4 = ((SpriteAtlas)(object)gameObject7).CanBindTo(sprite4);
					}
					else
					{
						flag4 = false;
					}
					UIWidget component4 = ((Component)flag3).GetComponent<UIWidget>();
					nint num7 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num8 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v146 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					UIWidget uIWidget = ((((ComputeShader)flag4).FindKernel(null) == 0) ? null : ((Component)flag4).GetComponent<UIWidget>());
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v70 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num10 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v139 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num11 = ((((ComputeShader)(object)uIWidget).FindKernel((string)null) != 0) ? uIWidget.mWidth : 0);
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num13 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ S0_v132 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num14;
					if (((ComputeShader)(object)uIWidget).FindKernel((string)null) != 0)
					{
						transform2.localPosition = (Vector3)flag4;
						num14 = (nint)transform2;
						if ((object)transform2 != transform2)
						{
							num14 = int.MinValue;
						}
						else if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2.1474836E+09f))
						{
							num14 = int.MinValue;
						}
						else if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2.1474836E+09f)))
						{
							num14 = int.MinValue;
						}
					}
					else
					{
						num14 = unchecked((nint)null);
					}
					nint num15 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S0_v86 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num16 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!(component4 == null))
					{
						break;
					}
					int num17 = (((object)sprite3 != null) ? _horizontalSpacing : 0);
					object obj10 = num11 + num14;
					int num18 = num17 + obj10;
					GameObject gameObject8 = ((Component)flag3).gameObject;
					GameObject gameObject9 = ((Component)flag3).gameObject;
					transform.localPosition = (Vector3)gameObject9;
					GameObject gameObject10 = ((Component)flag3).gameObject;
					transform3.localPosition = (Vector3)gameObject10;
					transform4 = (Transform)0;
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					transform4 = (Transform)num18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Transform)+4]");
					_ = 0;
					((UnityEngine.Object)transform4).m_CachedPtr = ((UnityEngine.Object)transform3).m_CachedPtr;
					transform2 = transform4;
					((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
					Vector3 eulerAngles = transform2.eulerAngles;
					object obj11 = num17 + component4.mWidth;
					float num19 = num6 + (float)obj11;
					num6 = num19;
					sprite4 = sprite3;
				}
				Sprite sprite5 = (Sprite)(sprite3 + 1);
				sprite3 = sprite5;
				continue;
			}
			float num20 = num6 * 0.5f;
			bool flag5 = ((SpriteAtlas)(object)gameObject6).CanBindTo((Sprite)null);
			UIWidget component5 = ((Component)flag5).GetComponent<UIWidget>();
			int num21 = component5.mWidth / 2;
			float num22 = num20 - (float)num21;
			Sprite sprite6 = null;
			while (true)
			{
				GameObject gameObject11 = base.gameObject;
				int siblingIndex4 = ((Transform)(object)gameObject11).GetSiblingIndex();
				if ((nint)sprite6 < siblingIndex4)
				{
					GameObject gameObject12 = base.gameObject;
					bool flag6 = ((SpriteAtlas)(object)gameObject12).CanBindTo(sprite6);
					GameObject gameObject13 = ((Component)flag6).gameObject;
					GameObject gameObject14 = ((Component)flag6).gameObject;
					transform.localPosition = (Vector3)gameObject14;
					GameObject gameObject15 = ((Component)flag6).gameObject;
					transform3.localPosition = (Vector3)gameObject15;
					GameObject gameObject16 = ((Component)flag6).gameObject;
					transform4.localPosition = (Vector3)gameObject16;
					obj = 0;
					_ = 0;
					float num23 = (float)transform - num22;
					obj = num23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Transform)+4]");
					_ = 0;
					_ = ((UnityEngine.Object)transform4).m_CachedPtr;
					transform2 = (Transform)obj;
					Transform transform5 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles2 = transform2.eulerAngles;
					Sprite sprite7 = (Sprite)(sprite6 + 1);
					sprite6 = sprite7;
					continue;
				}
				break;
			}
			return;
		}
		nint num24 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ S0_v93 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num25 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S0_v99 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)"All children of linear layout must have ui widget.");
	}
}
