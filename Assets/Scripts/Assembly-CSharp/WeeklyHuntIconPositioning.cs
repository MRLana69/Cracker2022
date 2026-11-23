using Cpp2ILInjected;
using UnityEngine;

public class WeeklyHuntIconPositioning : MonoBehaviour
{
	public enum IconPlacement
	{
		_notSet,
		FrontUIButton,
		CelebrationPopup,
		WeeklyHuntPopupActive,
		WeeklyHuntPopupInactive,
		SlideIn,
		IngameCounter,
		IngameCounterBackground
	}

	private IconPlacement _placement;

	private bool RUN_ONCE = true;

	private Vector3 CELEBRATION_POPUP_ICON_POSITION = (Vector3)(-4445052828948103168L);

	private Vector3 FRONT_UI_ICON_POSITION;

	private Vector3 HUNTPOPUP_ACTIVE_ICON_POSITION = (Vector3)4692750812838166528L;

	private Vector3 HUNTPOPUP_INACTIVE_ICON_POSITION;

	private Vector3 SLIDEIN_ICON_POSITION = (Vector3)(-4467570827086594048L);

	private Vector3 INGAME_COUNTER_ICON_POSITION;

	private Vector3 INGAME_COUNTER_BACKGROUND_POSITION = (Vector3)4833783852919155589L;

	private int HEIGHT_SLIDE_IN;

	private int HEIGHT_CELEBRATION_POPUP = 34;

	private int HEIGHT_PERIOD_CELL_ACTIVE;

	private int HEIGHT_PERIOD_CELL_INACTIVE = 23;

	private int HEIGHT_INGAME;

	private int HEIGHT_FRONT_UI_BUTTON = 32;

	public void ForceUpdate()
	{
		SetSize();
		Update();
	}

	private void Awake()
	{
		ForceUpdate();
	}

	private void Update()
	{
		SetPosition();
		if (~(RUN_ONCE ? 1u : 0u) == 0)
		{
			enabled = false;
		}
	}

	private void SetSize()
	{
		//IL_018f: Expected Obj, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_0146: Expected I, but got Obj
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_0179: Expected I4, but got Obj
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		object obj = _placement - 1;
		object obj2;
		if (_placement != IconPlacement.FrontUIButton)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							if ((nint)obj != 5)
							{
								return;
							}
							obj2 = this + 120;
						}
						else
						{
							obj2 = this + 104;
						}
					}
					else
					{
						obj2 = this + 116;
					}
				}
				else
				{
					obj2 = this + 112;
				}
			}
			else
			{
				obj2 = this + 108;
			}
		}
		else
		{
			obj2 = this + 124;
		}
		if (obj2 != null)
		{
			UISprite component = GetComponent<UISprite>();
			if ((bool)component)
			{
				component.keepAspectRatio = UIWidget.AspectRatioSource.Free;
				nint num = (nint)component;
				object obj3 = component + 296;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S1_v9 (Il2CppClass<UISprite>)+1E4] (should have been resolved before IL gen)");
				component.keepAspectRatio = UIWidget.AspectRatioSource.BasedOnHeight;
				component.height = (int)obj2;
			}
		}
	}

	private unsafe void SetPosition()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0150: Expected I, but got Obj
		//IL_0183: Expected Obj, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_01c1: Expected F4, but got I
		//IL_01bc: Expected native int or pointer, but got VT
		//IL_01d6: Expected F4, but got I
		//IL_01d1: Expected native int or pointer, but got VT
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_ = Vector3.zeroVector;
		object obj2 = _placement - 1;
		if (_placement != IconPlacement.FrontUIButton)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 != 3)
					{
						if ((nint)obj2 != 4)
						{
							if ((nint)obj2 != 5)
							{
								if ((nint)obj2 != 6)
								{
									goto IL_01a2;
								}
								object obj3 = this + 92;
							}
							else
							{
								object obj3 = this + 80;
							}
						}
						else
						{
							object obj3 = this + 68;
						}
					}
					else
					{
						object obj3 = this + 56;
					}
				}
				else
				{
					object obj3 = this + 44;
				}
			}
			else
			{
				object obj3 = this + 20;
			}
		}
		else
		{
			object obj3 = this + 32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v14+8]");
		_ = 0;
		goto IL_01a2;
		IL_01a2:
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.localPosition = vector;
	}

	public WeeklyHuntIconPositioning()
	{
		//IL_001a: Expected I4, but got I8
		//IL_0029: Expected I4, but got I8
		//IL_0038: Expected VT, but got I8
		//IL_0047: Expected VT, but got I8
		//IL_0056: Expected VT, but got I8
		//IL_0065: Expected VT, but got I8
		_ = 188978561024L;
		_ = 3245342720L;
		_ = -4490088828488384512L;
		_ = 3258449920L;
		_ = 4800837202776948736L;
		_ = 3204448256L;
		_ = -4647714815446351872L;
		base._002Ector();
	}
}
