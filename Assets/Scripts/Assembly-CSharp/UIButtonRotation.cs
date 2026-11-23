using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIButtonRotation : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	private Quaternion mRot;

	private bool mStarted;

	private void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c1: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		if (~(mStarted ? 1u : 0u) != 0)
		{
			mStarted = true;
			if (tweenTarget == null)
			{
				Transform transform = base.transform;
				tweenTarget = transform;
			}
			Quaternion localRotation = tweenTarget.localRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			mRot = (Quaternion)obj;
		}
	}

	private void OnEnable()
	{
		if (~(mStarted ? 1u : 0u) == 0)
		{
			GameObject go = gameObject;
			bool isOver = UICamera.IsHighlighted(go);
			OnHover(isOver);
		}
	}

	private unsafe void OnDisable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0091: Expected F4, but got I
		//IL_008c: Expected native int or pointer, but got VT
		//IL_00a0: Expected F4, but got VT
		//IL_009b: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 16);
		if (~(mStarted ? 1u : 0u) == 0 && tweenTarget != null)
		{
			TweenRotation component = tweenTarget.GetComponent<TweenRotation>();
			if (component != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				((Quaternion*)(nint)quaternion)->z = 0f;
				((Quaternion*)(nint)quaternion)->x = (float)mRot;
				component.value = quaternion;
				component.enabled = false;
			}
		}
	}

	private unsafe void OnPress(bool isPressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected VT, but got Unknown
		//IL_0496: Expected Obj, but got I
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected Obj, but got Unknown
		//IL_04d7: Expected Obj, but got I
		//IL_0501: Expected Obj, but got I
		//IL_050e: Expected VT, but got Obj
		//IL_052b: Expected Obj, but got I
		//IL_0548: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_05c0: Expected Obj, but got I
		//IL_05dd: Expected Obj, but got I
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected Obj, but got Unknown
		//IL_062b: Expected Obj, but got I
		//IL_0655: Expected Obj, but got I
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		//IL_0696: Expected Obj, but got I
		//IL_06c0: Expected Obj, but got I
		//IL_0735: Expected F4, but got I
		//IL_0730: Expected native int or pointer, but got VT
		//IL_0754: Expected F4, but got I
		//IL_074f: Expected native int or pointer, but got VT
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected VT, but got Unknown
		//IL_0197: Expected Obj, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I
		//IL_0202: Expected Obj, but got I
		//IL_020f: Expected VT, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_0249: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_02c1: Expected Obj, but got I
		//IL_02de: Expected Obj, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_032c: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0397: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 96);
		if (!enabled)
		{
			return;
		}
		if (~(mStarted ? 1u : 0u) != 0)
		{
			Start();
		}
		GameObject go = tweenTarget.gameObject;
		if (!isPressed)
		{
			GameObject go2 = gameObject;
			if (!UICamera.IsHighlighted(go2))
			{
				Quaternion quaternion2 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				object obj4 = 0;
			}
			else
			{
				float num = (float)hover * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+14]");
				float num2 = 0f * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+18]");
				float num3 = 0f * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
				_ = 0;
				Vector3 euler = (Vector3)(quaternion + 32);
				Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(euler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				object obj5 = num4 * 0;
				Quaternion quaternion4 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+5C]");
				object obj6 = quaternion4 * 0;
				object obj7 = obj5 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				object obj8 = num5 * 0;
				object obj9 = obj7 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+54]");
				object obj10 = num6 * 0;
				Quaternion quaternion5 = (Quaternion)(obj9 - obj10);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+54]");
				object obj11 = num7 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+5C]");
				object obj12 = num8 * 0;
				object obj13 = obj11 + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				object obj14 = num9 * 0;
				object obj15 = obj13 + obj14;
				Quaternion quaternion6 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				object obj16 = quaternion6 * 0;
				object obj17 = obj15 - obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				object obj18 = num10 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+5C]");
				object obj19 = num11 * 0;
				object obj20 = obj18 + obj19;
				Quaternion quaternion7 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+54]");
				object obj21 = quaternion7 * 0;
				object obj22 = obj20 + obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				object obj23 = num12 * 0;
				object obj24 = obj22 - obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+5C]");
				object obj25 = num13 * 0;
				Quaternion quaternion8 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
				object obj26 = quaternion8 * 0;
				object obj27 = obj25 - obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+54]");
				object obj28 = num14 * 0;
				object obj29 = obj27 - obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
				object obj30 = num15 * 0;
				object obj31 = obj29 - obj30;
				Quaternion quaternion2 = quaternion5;
				object obj2 = obj17;
				object obj3 = obj24;
				object obj4 = obj31;
			}
		}
		else
		{
			float num16 = (float)pressed * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+20]");
			float num17 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+24]");
			float num18 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
			_ = 0;
			Vector3 euler2 = (Vector3)(quaternion + 16);
			Quaternion quaternion9 = Quaternion.Internal_FromEulerRad(euler2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
			object obj32 = num19 * 0;
			Quaternion quaternion10 = mRot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+5C]");
			object obj33 = quaternion10 * 0;
			object obj34 = obj32 + obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
			object obj35 = num20 * 0;
			object obj36 = obj34 + obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+54]");
			object obj37 = num21 * 0;
			Quaternion quaternion11 = (Quaternion)(obj36 - obj37);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+54]");
			object obj38 = num22 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
			nint num23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+5C]");
			object obj39 = num23 * 0;
			object obj40 = obj38 + obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
			object obj41 = num24 * 0;
			object obj42 = obj40 + obj41;
			Quaternion quaternion12 = mRot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
			object obj43 = quaternion12 * 0;
			object obj44 = obj42 - obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
			object obj45 = num25 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
			nint num26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+5C]");
			object obj46 = num26 * 0;
			object obj47 = obj45 + obj46;
			Quaternion quaternion13 = mRot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+54]");
			object obj48 = quaternion13 * 0;
			object obj49 = obj47 + obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
			nint num27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
			object obj50 = num27 * 0;
			object obj51 = obj49 - obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+5C]");
			object obj52 = num28 * 0;
			Quaternion quaternion14 = mRot;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
			object obj53 = quaternion14 * 0;
			object obj54 = obj52 - obj53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+54]");
			object obj55 = num29 * 0;
			object obj56 = obj54 - obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
			object obj57 = num30 * 0;
			object obj58 = obj56 - obj57;
			Quaternion quaternion2 = quaternion11;
			object obj2 = obj44;
			object obj3 = obj51;
			object obj4 = obj58;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		TweenRotation tweenRotation = TweenRotation.Begin(go, duration, quaternion);
		tweenRotation.method = UITweener.Method.EaseInOut;
	}

	private unsafe void OnHover(bool isOver)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected VT, but got Unknown
		//IL_0175: Expected Obj, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01b6: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01ed: Expected VT, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0227: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got I
		//IL_02bc: Expected Obj, but got I
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_030a: Expected Obj, but got I
		//IL_0334: Expected Obj, but got I
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_0375: Expected Obj, but got I
		//IL_039f: Expected Obj, but got I
		//IL_03f1: Expected F4, but got I
		//IL_03ec: Expected native int or pointer, but got VT
		//IL_0410: Expected F4, but got I
		//IL_040b: Expected native int or pointer, but got VT
		//IL_00ad: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 80);
		if (enabled)
		{
			if (~(mStarted ? 1u : 0u) != 0)
			{
				Start();
			}
			GameObject go = tweenTarget.gameObject;
			if (!isOver)
			{
				Quaternion quaternion2 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				object obj4 = 0;
			}
			else
			{
				float num = (float)hover * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+14]");
				float num2 = 0f * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+18]");
				float num3 = 0f * ((float)Math.PI / 180f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
				_ = 0;
				Vector3 euler = (Vector3)(quaternion + 16);
				Quaternion quaternion3 = Quaternion.Internal_FromEulerRad(euler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
				object obj5 = num4 * 0;
				Quaternion quaternion4 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+4C]");
				object obj6 = quaternion4 * 0;
				object obj7 = obj5 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
				object obj8 = num5 * 0;
				object obj9 = obj7 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+44]");
				object obj10 = num6 * 0;
				Quaternion quaternion5 = (Quaternion)(obj9 - obj10);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+44]");
				object obj11 = num7 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+4C]");
				object obj12 = num8 * 0;
				object obj13 = obj11 + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
				object obj14 = num9 * 0;
				object obj15 = obj13 + obj14;
				Quaternion quaternion6 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
				object obj16 = quaternion6 * 0;
				object obj17 = obj15 - obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
				object obj18 = num10 * 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+4C]");
				object obj19 = num11 * 0;
				object obj20 = obj18 + obj19;
				Quaternion quaternion7 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+44]");
				object obj21 = quaternion7 * 0;
				object obj22 = obj20 + obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
				object obj23 = num12 * 0;
				object obj24 = obj22 - obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+38]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+4C]");
				object obj25 = num13 * 0;
				Quaternion quaternion8 = mRot;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
				object obj26 = quaternion8 * 0;
				object obj27 = obj25 - obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+30]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+44]");
				object obj28 = num14 * 0;
				object obj29 = obj27 - obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonRotation)+34]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
				object obj30 = num15 * 0;
				object obj31 = obj29 - obj30;
				Quaternion quaternion2 = quaternion5;
				object obj2 = obj17;
				object obj3 = obj24;
				object obj4 = obj31;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			TweenRotation tweenRotation = TweenRotation.Begin(go, duration, quaternion);
			tweenRotation.method = UITweener.Method.EaseInOut;
		}
	}

	private void OnSelect(bool isSelected)
	{
		if (!enabled)
		{
			return;
		}
		if (isSelected)
		{
			UICamera.ControlScheme currentScheme = UICamera.currentScheme;
			if (currentScheme != UICamera.ControlScheme.Controller)
			{
				return;
			}
		}
		OnHover(isSelected);
	}

	public UIButtonRotation()
	{
		//IL_0013: Expected I, but got Obj
		//IL_004e: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		hover = Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		pressed = Vector3.zeroVector;
		duration = 0.2f;
		base._002Ector();
	}
}
