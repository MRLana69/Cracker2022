using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class FacebookWeeklyGiftPopup : UIScreen
{
	private sealed class _003CPlace3DModel_003Ed__9(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FacebookWeeklyGiftPopup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected VT, but got Unknown
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected VT, but got Unknown
			//IL_027a: Expected Obj, but got VT
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected Obj, but got Unknown
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Expected Obj, but got Unknown
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 160;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					FacebookWeeklyGiftPopup facebookWeeklyGiftPopup = _003C_003E4__this;
					_003C_003E1__state = -1;
					if (facebookWeeklyGiftPopup.superMysteryBoxPrize != null)
					{
						facebookWeeklyGiftPopup.superMysteryBoxPrize.SetActive(value: true);
					}
					else
					{
						UIModelController instance = UIModelController.Instance;
						GameObject superMysteryBoxPrize = NGUITools.AddChild(instance.TutorialPopupAnchor, facebookWeeklyGiftPopup.superMysteryBoxPrefab);
						facebookWeeklyGiftPopup.superMysteryBoxPrize = superMysteryBoxPrize;
					}
					UIModelController instance2 = UIModelController.Instance;
					int layer = instance2.TutorialPopupAnchor.layer;
					facebookWeeklyGiftPopup.superMysteryBoxPrize.layer = layer;
					Transform transform = facebookWeeklyGiftPopup.centerWidget.transform;
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					UIScreenController instance3 = UIScreenController.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					_ = 0;
					Vector3 position2 = (Vector3)(obj + 80);
					Vector3 vector = instance3.Camera2DNormal.WorldToScreenPoint(position2);
					UIScreenController instance4 = UIScreenController.Instance;
					_ = 1077936128;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					Vector3 position3 = (Vector3)(obj - -64);
					Vector3 vector2 = instance4.Camera3D.ScreenToWorldPoint(position3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					_ = 0;
					Transform transform2 = facebookWeeklyGiftPopup.superMysteryBoxPrize.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v20 (FacebookWeeklyGiftPopup)+50]");
					_ = 0;
					_ = facebookWeeklyGiftPopup.ITEM_POSITION_OFFSET;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v20 (FacebookWeeklyGiftPopup)+5C]");
					_ = 0;
					_ = facebookWeeklyGiftPopup.ITEM_ROTATION;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v20 (FacebookWeeklyGiftPopup)+68]");
					_ = 0;
					obj = facebookWeeklyGiftPopup.ITEM_SCALE;
					object obj3 = obj + 48;
					object obj4 = obj + 32;
					object obj5 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CEC");
					return false;
				}
				bool result = default;
				return result;
			}
			_003C_003E1__state = -1;
			object obj6 = default;
			_003C_003E2__current = obj6;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private UILabel title;

	private UILabel subtitle;

	private UIWidget centerWidget;

	private GameObject superMysteryBoxPrefab;

	private GameObject superMysteryBoxPrize;

	private Vector3 ITEM_POSITION_OFFSET = (Vector3)4728779608739020800L;

	private Vector3 ITEM_ROTATION;

	private Vector3 ITEM_SCALE = (Vector3)4970285139913998336L;

	public override void Show()
	{
		base.Show();
		IEnumerator routine = Place3DModel();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator Place3DModel()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void ResetTransform(Transform trans, Vector3 newPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected VT, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected VT, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected VT, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01cb: Expected native int or pointer, but got VT
		//IL_01dd: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		_ = newPosition.z;
		_ = newPosition.x;
		Vector3 position = vector - -64;
		trans.position = position;
		Vector3 localPosition = trans.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		float num = 0f + positionOffset.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		float num2 = 0f + positionOffset.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		float num3 = 0f + positionOffset.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector3 localPosition2 = vector + 48;
		trans.localPosition = localPosition2;
		float num4 = newRotation.x * ((float)Math.PI / 180f);
		float num5 = newRotation.y * ((float)Math.PI / 180f);
		float num6 = newRotation.z * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 euler = vector + 32;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		trans.localRotation = localRotation;
		((Vector3*)(nint)vector)->z = newScale.z;
		((Vector3*)(nint)vector)->x = newScale.x;
		trans.localScale = vector;
	}

	public override void Hide()
	{
		base.Hide();
		superMysteryBoxPrize.SetActive(value: false);
	}

	public void OnCheckoutClicked()
	{
		if (UIScreenController.IsInstanced)
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.ignoreLastPopupClosed = true;
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.doSaveAndDelayRemainingPopups = true;
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.CloseActivePopups(screenName);
			UIScreenController instance4 = UIScreenController.Instance;
			instance4.PushScreen("EarnCoinsScreen");
		}
	}

	public static void ShowIfNeeded()
	{
		FacebookWeeklyGiftManager instance = FacebookWeeklyGiftManager.Instance;
		if (instance.ShouldDisplayPopup())
		{
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.QueuePopup("FacebookWeeklyGiftPopup");
			FacebookWeeklyGiftManager instance3 = FacebookWeeklyGiftManager.Instance;
			((FacebookWeeklyGiftManager)null).PopupDidShow();
		}
	}

	public FacebookWeeklyGiftPopup()
	{
		//IL_000f: Expected VT, but got I8
		//IL_001e: Expected VT, but got I8
		_ = 1157234688;
		_ = 4656722017948008448L;
		_ = -4503599627370496000L;
		base._002Ector();
	}
}
