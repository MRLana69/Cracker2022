using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIClickable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	public enum STATE
	{
		DOWN,
		ENTER,
		EXIT,
		UP,
		NORMAL
	}

	private STATE state;

	private Vector3 startScale;

	private RectTransform trans;

	private Image img;

	private float multiplier = 0.07f;

	private float duration;

	private Sprite active;

	private Sprite normal;

	private Sprite hide;

	private Sprite hideActive;

	public bool Main;

	private bool highlight;

	private bool init;

	private bool activeText;

	private Color ActiveColor;

	private Color hideActiveColor;

	private TMP_Text text;

	private bool SaveMe;

	private void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007d: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		if (trans == null)
		{
			RectTransform component = GetComponent<RectTransform>();
			trans = component;
		}
		if (img == null)
		{
			Image component2 = GetComponent<Image>();
			img = component2;
		}
		if (~(init ? 1u : 0u) != 0)
		{
			Vector3 localScale = trans.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			startScale = (Vector3)obj;
			init = true;
		}
		Main = false;
		ChangeState(STATE.NORMAL);
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (state != STATE.DOWN)
		{
			ChangeState(STATE.DOWN);
		}
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (state != STATE.ENTER)
		{
			ChangeState(STATE.ENTER);
		}
		highlight = true;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		if (state != STATE.EXIT)
		{
			ChangeState(STATE.EXIT);
		}
		highlight = false;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		if (state != STATE.UP)
		{
			ChangeState(STATE.UP);
		}
	}

	public void ChangeState(STATE _state)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_0763: Expected I, but got Obj
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Expected Obj, but got Unknown
		//IL_0476: Expected I, but got Obj
		//IL_0512: Expected Obj, but got I4
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected Obj, but got Unknown
		//IL_0556: Expected VT, but got F4
		//IL_0102: Expected Obj, but got I4
		//IL_0581: Expected I, but got Obj
		//IL_061d: Expected Obj, but got I4
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected VT, but got Unknown
		//IL_0661: Expected VT, but got F4
		//IL_0122: Expected Obj, but got I4
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected Obj, but got Unknown
		//IL_0917: Expected F4, but got I
		//IL_0927: Expected F4, but got I
		//IL_01cc: Expected Obj, but got I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_06f6: Expected F4, but got I
		//IL_0706: Expected F4, but got I
		//IL_0165: Expected Obj, but got I4
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected Obj, but got Unknown
		//IL_00df: Expected F4, but got I
		//IL_00ef: Expected F4, but got I
		//IL_01a5: Expected Obj, but got I4
		//IL_0972: Expected F4, but got I
		//IL_0982: Expected F4, but got I
		//IL_0200: Expected Obj, but got I4
		//IL_038b: Expected Obj, but got I
		//IL_0819: Expected I, but got Obj
		//IL_08b4: Expected VT, but got F4
		//IL_017e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 144;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (trans == null)
		{
			RectTransform component = GetComponent<RectTransform>();
			trans = component;
		}
		object obj3 = this + 32;
		if (img == null)
		{
			Image component2 = GetComponent<Image>();
			img = component2;
		}
		state = _state;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v42 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+48]");
		_ = 0;
		_ = ActiveColor;
		object obj4 = this - -64;
		Object obj5;
		if (state != STATE.DOWN)
		{
			if (state != STATE.ENTER)
			{
				if (state != STATE.EXIT)
				{
					if (state != STATE.UP)
					{
						if (state != STATE.NORMAL)
						{
							Vector3 oneVector = Vector3.oneVector;
							obj5 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v43 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
							float num3 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v43 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
							float num4 = 0f;
						}
						else
						{
							object obj6 = 52;
							if (!Main)
							{
								obj6 = 48;
							}
							object obj7 = (object)this + obj6;
							object obj8 = this + 80;
							if (!Main)
							{
								obj4 = obj8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v244+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v244+8]");
							_ = 0;
							Vector3 oneVector = startScale;
							obj5 = (Object)obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+18]");
							float num3 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+14]");
							float num4 = 0f;
						}
					}
					else
					{
						object obj9 = this + 80;
						if (!Main)
						{
							obj4 = obj9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v244+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v244+8]");
						_ = 0;
						if (~(highlight ? 1u : 0u) == 0)
						{
							object obj10 = 56;
							if (!Main)
							{
								obj10 = 44;
							}
							object obj11 = (object)this + obj10;
							nint num5 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S0_v224 (Il2CppClass<UnityEngine.Vector3>)+5C]");
							nint num6 = 0;
							float num7 = (float)Vector3.oneVector * multiplier;
							float num8 = (float)startScale + num7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v225 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
							float num9 = 0f * multiplier;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+14]");
							float num10 = 0f + num9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v225 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
							float num11 = 0f * multiplier;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+18]");
							float num12 = 0f + num11;
							Vector3 oneVector = (Vector3)num8;
							obj5 = (Object)obj11;
							float num3 = num12;
							float num4 = num10;
						}
						else
						{
							object obj12 = 48;
							if (!Main)
							{
								obj12 = 52;
							}
							object obj13 = (object)this + obj12;
							Vector3 oneVector = startScale;
							obj5 = (Object)obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+18]");
							float num3 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+14]");
							float num4 = 0f;
						}
					}
				}
				else
				{
					object obj14 = 52;
					if (!Main)
					{
						obj14 = 48;
					}
					object obj15 = (object)this + obj14;
					object obj16 = this + 80;
					if (!Main)
					{
						obj4 = obj16;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v244+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v244+8]");
					_ = 0;
					Vector3 oneVector = startScale;
					obj5 = (Object)obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+18]");
					float num3 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+14]");
					float num4 = 0f;
				}
			}
			else
			{
				nint num13 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v155 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num14 = 0;
				float num15 = (float)Vector3.oneVector * multiplier;
				float num16 = (float)startScale + num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v156 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
				float num17 = 0f * multiplier;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+14]");
				float num18 = 0f + num17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v156 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
				float num19 = 0f * multiplier;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+18]");
				float num20 = 0f + num19;
				object obj17 = 56;
				if (!Main)
				{
					obj17 = 44;
				}
				object obj18 = (object)this + obj17;
				object obj19 = this + 80;
				object obj20 = obj4;
				if (!Main)
				{
					obj20 = obj19;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S1_v89+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
				_ = 0;
				Vector3 oneVector = (Vector3)num16;
				obj5 = (Object)obj18;
				float num3 = num20;
				float num4 = num18;
			}
		}
		else
		{
			nint num21 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v124 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num22 = 0;
			float num23 = (float)Vector3.oneVector * multiplier;
			float num24 = (float)startScale - num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v125 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
			float num25 = 0f * multiplier;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+14]");
			float num26 = 0f - num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v125 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			float num27 = 0f * multiplier;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIClickable)+18]");
			float num28 = 0f - num27;
			object obj21 = 56;
			if (!Main)
			{
				obj21 = 44;
			}
			object obj22 = (object)this + obj21;
			object obj23 = this + 80;
			object obj24 = obj4;
			if (!Main)
			{
				obj24 = obj23;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S1_v67+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
			_ = 0;
			Vector3 oneVector = (Vector3)num24;
			obj5 = (Object)obj22;
			float num3 = num28;
			float num4 = num26;
		}
		if (~(SaveMe ? 1u : 0u) == 0)
		{
			Button component3 = GetComponent<Button>();
			if (((Selectable)component3).m_Interactable)
			{
				goto IL_0296;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Vector3 endValue = (Vector3)(obj + 16);
		TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale(trans, endValue, duration);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = TweenSettingsExtensions.SetEase(t, Ease.OutQuad);
		goto IL_0296;
		IL_0296:
		if (active != null && normal != null && obj5 != null && !SaveMe)
		{
			((Image)obj3).sprite = (Sprite)obj5;
		}
		if (text != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		}
	}

	public void SetUp(bool main)
	{
		Main = main;
		ChangeState(state);
	}
}
