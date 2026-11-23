using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class UIMessageHelper : MonoBehaviour
{
	private sealed class _003CFadeOut_003Ed__4(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMessageHelper _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private float _003CfadeTime_003E5__3;

		private Vector3 _003CscaleFrom_003E5__4;

		private Vector3 _003CscaleTo_003E5__5;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00d0: Expected Obj, but got I
			//IL_011f: Expected VT, but got I
			//IL_0274: Expected Obj, but got I
			//IL_028e: Expected Obj, but got VT
			//IL_0197: Expected Obj, but got I
			//IL_01ba: Expected Obj, but got I
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Expected VT, but got Unknown
			//IL_0361: Expected Obj, but got I
			//IL_03a4: Expected Obj, but got I
			//IL_03e4: Expected F4, but got I
			//IL_03df: Expected native int or pointer, but got VT
			//IL_0403: Expected F4, but got I
			//IL_03fe: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj - 80);
			UIMessageHelper uIMessageHelper = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state == 3)
						{
							_003C_003E1__state = -1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIMessageHelper)+1C]");
							object obj2 = 0;
							object obj3 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ S2_v20+2CC] (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIMessageHelper)+1C]");
							Transform transform = ((TMP_Text)0).transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper+<FadeOut>d__4)+24]");
							_ = 0;
							_ = _003CscaleFrom_003E5__4;
							Vector3 localScale = vector + 16;
							transform.localScale = localScale;
							GameObject gameObject = uIMessageHelper.gameObject;
							gameObject.SetActive(value: false);
							UIScreenController instance = UIScreenController.Instance;
							instance.ReadyForNextMessage();
						}
						bool result = default;
						return result;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003Cduration_003E5__2 = 0.2f;
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIMessageHelper)+1C]");
					Transform transform2 = ((TMP_Text)0).transform;
					Vector3 localScale2 = transform2.localScale;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_003CscaleFrom_003E5__4 = (Vector3)0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper+<FadeOut>d__4)+24]");
					_ = 0;
					_003CscaleTo_003E5__5 = _003CscaleFrom_003E5__4;
				}
				if (!(_003CfadeTime_003E5__3 < 1f))
				{
					_ = 0.5f;
					object obj4 = default;
					_003C_003E2__current = obj4;
					_003C_003E1__state = 3;
					return true;
				}
				float deltaTime = Time.deltaTime;
				float num = deltaTime / _003Cduration_003E5__2;
				float num2 = _003CfadeTime_003E5__3 + num;
				_003CfadeTime_003E5__3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (UIMessageHelper)+1C]");
				Transform transform3 = ((TMP_Text)0).transform;
				object obj5 = _003CscaleTo_003E5__5 - _003CscaleFrom_003E5__4;
				float num3 = Math.Min(_003CfadeTime_003E5__3, 1f);
				bool flag = _003CfadeTime_003E5__3 < 0f;
				float num4 = 0f;
				if (!flag)
				{
					num4 = num3;
				}
				float num5 = (float)obj5 * num4;
				float num6 = (float)_003CscaleFrom_003E5__4 + num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper+<FadeOut>d__4)+2C]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper+<FadeOut>d__4)+20]");
				object obj6 = num7 - 0;
				float num8 = (float)obj6 * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper+<FadeOut>d__4)+20]");
				float num9 = 0f + num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper+<FadeOut>d__4)+30]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper+<FadeOut>d__4)+24]");
				object obj7 = num10 - 0;
				float num11 = (float)obj7 * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper+<FadeOut>d__4)+24]");
				float num12 = 0f + num11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				transform3.localScale = vector;
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			_ = 2f;
			object obj8 = default;
			_003C_003E2__current = obj8;
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

	public Color shownColor = (Color)4575657222473777152L;

	private TMP_Text _label;

	private bool _wasPermanentlyHidden;

	public void ShowMessage(string message, bool bigText = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0058: Expected I, but got Obj
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0087: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_wasPermanentlyHidden = false;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		_label.enabled = true;
		TMP_Text label = _label;
		nint num = (nint)label;
		object obj3 = label + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S2_v4 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIMessageHelper)+14]");
		_ = 0;
		obj = shownColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
		float fontSize = 56f;
		if (!bigText)
		{
			fontSize = 46f;
		}
		_label.fontSize = fontSize;
		IEnumerator routine = FadeOut();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator FadeOut()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void SetTemporaryHidden(bool hidden)
	{
		bool flag = hidden || _wasPermanentlyHidden;
		bool flag2 = !flag;
		_label.enabled = flag2;
	}

	public void DisableShowLabel()
	{
		//IL_0017: Expected I, but got Obj
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		TMP_Text label = _label;
		nint num = (nint)label;
		object obj = label + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S2_v2 (Il2CppClass<TMPro.TMP_Text>)+2C4] (should have been resolved before IL gen)");
		string text = default;
		bool wasPermanentlyHidden = text != string.Empty;
		_wasPermanentlyHidden = wasPermanentlyHidden;
		_label.enabled = false;
	}

	public UIMessageHelper()
	{
		//IL_000f: Expected VT, but got I8
		_ = 4575657222473777152L;
		base._002Ector();
	}
}
