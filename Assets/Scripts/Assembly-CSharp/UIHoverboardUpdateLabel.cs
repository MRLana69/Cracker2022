using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHoverboardUpdateLabel : MonoBehaviour
{
	private sealed class _003CCountUpAndFlashCoroutine_003Ed__14(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHoverboardUpdateLabel _003C_003E4__this;

		private float _003CaniFactor_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0350: Expected Obj, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected I4, but got Unknown
			//IL_017b: Expected I, but got Obj
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected I4, but got Unknown
			//IL_0222: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - 48;
			_ = 0;
			UIHoverboardUpdateLabel uIHoverboardUpdateLabel = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (!(_003CaniFactor_003E5__2 < 1f))
					{
						uIHoverboardUpdateLabel.blinkSprite.enabled = false;
						_ = 0.1f;
						object obj3 = default;
						_003C_003E2__current = obj3;
						_003C_003E1__state = 2;
						return true;
					}
					goto IL_029a;
				}
				if (_003C_003E1__state != 2)
				{
					goto IL_0275;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				if (uIHoverboardUpdateLabel._countUpCoroutineRunning)
				{
					goto IL_0275;
				}
				uIHoverboardUpdateLabel._countUpCoroutineRunning = true;
			}
			PlayerInfo instance = PlayerInfo.Instance;
			int upgradeAmount = instance.GetUpgradeAmount(PowerupType.hoverboard);
			if (uIHoverboardUpdateLabel._lastAmountSet < upgradeAmount)
			{
				int lastAmountSet = uIHoverboardUpdateLabel._lastAmountSet + 1;
				uIHoverboardUpdateLabel._lastAmountSet = lastAmountSet;
				TMP_Text amountLabel = uIHoverboardUpdateLabel.amountLabel;
				int num = uIHoverboardUpdateLabel + 24;
				string text = ((int*)num)->ToString();
				nint num2 = (nint)amountLabel;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v181 @ S2_v19 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				uIHoverboardUpdateLabel.SpawnScrollingLabel();
				uIHoverboardUpdateLabel.blinkSprite.enabled = true;
				_003CaniFactor_003E5__2 = 0f;
				goto IL_029a;
			}
			if (upgradeAmount != uIHoverboardUpdateLabel._lastAmountSet)
			{
				TMP_Text amountLabel2 = uIHoverboardUpdateLabel.amountLabel;
				int num3 = obj + 44;
				string text2 = ((int*)num3)->ToString();
				nint num4 = (nint)amountLabel2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v207 @ S2_v13 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				uIHoverboardUpdateLabel._lastAmountSet = 0;
			}
			uIHoverboardUpdateLabel._countUpCoroutineRunning = false;
			return false;
			IL_029a:
			float deltaTime = Time.deltaTime;
			float num5 = deltaTime * 4f;
			float num6 = _003CaniFactor_003E5__2 + num5;
			float num7 = Math.Min(num6, 1f);
			bool flag = num6 < 0f;
			float num8 = 0f;
			if (!flag)
			{
				num8 = num7;
			}
			_003CaniFactor_003E5__2 = num8;
			_ = 1065353216;
			float num9 = 1f - num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			object obj4 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0275:
			bool result = default;
			return result;
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

	private const float BLINK_SPEED = 4f;

	private const float DELAY_AFTER_BLINK = 0.1f;

	private const float SCROLL_TEXT_DURATION = 1f;

	private const float SCROLL_TEXT_FADEOUT_DURATION = 0.5f;

	private static readonly Vector3 SCROLL_TEXT_STARTOFFSET;

	private static readonly Vector3 SCROLL_TEXT_ENDOFFSET;

	private TMP_Text amountLabel;

	private Image blinkSprite;

	private GameObject scrollingLabelPrefab;

	private int _lastAmountSet = -1;

	private bool _countUpCoroutineRunning;

	private void OnEnable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		throw new ArgumentException();
	}

	private unsafe void UpdateLabels(PowerupType powerupType, int newAmount)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected I4, but got Unknown
		//IL_0141: Expected I, but got Obj
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I4, but got Unknown
		//IL_008a: Expected I, but got Obj
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (powerupType != PowerupType.hoverboard)
		{
			return;
		}
		if (_lastAmountSet == -1)
		{
			TMP_Text tMP_Text = amountLabel;
			int num = obj + 12;
			string text = ((int*)num)->ToString();
			nint num2 = (nint)tMP_Text;
			object obj3 = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S2_v13 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			_lastAmountSet = 0;
		}
		else if (_lastAmountSet < newAmount)
		{
			if (!_countUpCoroutineRunning)
			{
				IEnumerator routine = CountUpAndFlashCoroutine();
				Coroutine coroutine = StartCoroutine(routine);
			}
		}
		else
		{
			TMP_Text tMP_Text2 = amountLabel;
			int num3 = obj + 12;
			string text2 = ((int*)num3)->ToString();
			nint num4 = (nint)tMP_Text2;
			object obj4 = tMP_Text2 + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			_lastAmountSet = 0;
		}
	}

	private IEnumerator CountUpAndFlashCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void SpawnScrollingLabel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005a: Expected I, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_00ca: Expected F4, but got I
		//IL_00c5: Expected native int or pointer, but got VT
		//IL_00d8: Expected F4, but got VT
		//IL_00d3: Expected native int or pointer, but got VT
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		GameObject parent = base.gameObject;
		GameObject gameObject = NGUITools.AddChild(parent, scrollingLabelPrefab);
		ScrollingTextLabel component = gameObject.GetComponent<ScrollingTextLabel>();
		if (component != null)
		{
			nint num = (nint)typeof(UIHoverboardUpdateLabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11 (Il2CppClass<UIHoverboardUpdateLabel>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v12 (Il2CppStaticFields<UIHoverboardUpdateLabel>)+8]");
			_ = 0;
			_ = SCROLL_TEXT_STARTOFFSET;
			nint num3 = (nint)typeof(UIHoverboardUpdateLabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v30 (Il2CppClass<UIHoverboardUpdateLabel>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v31 (Il2CppStaticFields<UIHoverboardUpdateLabel>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)SCROLL_TEXT_ENDOFFSET;
			Vector3 startLocalPos = vector + 16;
			component.StartScrolling("+1", startLocalPos, vector, 1f, 0.5f, destroyWhenDone: true);
		}
	}

	static UIHoverboardUpdateLabel()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0037: Expected VT, but got I8
		//IL_0045: Expected I, but got Obj
		//IL_0069: Expected VT, but got I8
		nint num = (nint)typeof(UIHoverboardUpdateLabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UIHoverboardUpdateLabel>)+5C]");
		nint num2 = 0;
		_ = 0;
		SCROLL_TEXT_STARTOFFSET = (Vector3)(-4494592428115755008L);
		nint num3 = (nint)typeof(UIHoverboardUpdateLabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<UIHoverboardUpdateLabel>)+5C]");
		nint num4 = 0;
		_ = 0;
		SCROLL_TEXT_ENDOFFSET = (Vector3)4728779608739020800L;
	}
}
