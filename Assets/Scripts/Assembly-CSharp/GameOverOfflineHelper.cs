using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Plugins.GameCenter;
using UnityEngine;

public class GameOverOfflineHelper : MonoBehaviour
{
	private sealed class _003CAnimateAlpha_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite sprite1;

		public float duration;

		public float toAlpha;

		public UISprite sprite2;

		public GameOverOfflineHelper _003C_003E4__this;

		private float _003CfromAlpha_003E5__2;

		private float _003Cfactor2_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected Obj, but got Unknown
			//IL_0210: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Expected Obj, but got Unknown
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Expected Obj, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected Obj, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected Obj, but got Unknown
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					bool flag = _003Cfactor2_003E5__3 < 1f;
					num = _003Cfactor2_003E5__3;
					if (flag)
					{
						goto IL_012e;
					}
					UISprite uISprite = sprite1;
					object obj = uISprite - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S2_v27+BC] (should have been resolved before IL gen)");
					UISprite uISprite2 = sprite2;
					object obj2 = uISprite2 - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S2_v31+BC] (should have been resolved before IL gen)");
					_003C_003E4__this.HandleColliders(AddNow: true);
				}
				return false;
			}
			_003C_003E1__state = -1;
			UISprite uISprite3 = sprite1;
			nint num2 = (nint)uISprite3;
			object obj3 = uISprite3 + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S1_v15 (Il2CppClass<UISprite>)+F4] (should have been resolved before IL gen)");
			_003Cfactor2_003E5__3 = 0f;
			float num3 = default;
			_003CfromAlpha_003E5__2 = num3;
			num = 0f;
			goto IL_012e;
			IL_012e:
			float deltaTime = Time.deltaTime;
			float num4 = deltaTime / duration;
			float num5 = num + num4;
			float num6 = Math.Min(num5, 1f);
			bool flag2 = num5 < 0f;
			float num7 = 0f;
			if (!flag2)
			{
				num7 = num6;
			}
			_003Cfactor2_003E5__3 = num7;
			UISprite uISprite4 = sprite1;
			float num8 = toAlpha - _003CfromAlpha_003E5__2;
			float num9 = Math.Max(num7, 0f);
			float num10 = num8 * num9;
			float num11 = _003CfromAlpha_003E5__2 + num10;
			object obj4 = uISprite4 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ S2_v11+BC] (should have been resolved before IL gen)");
			UISprite uISprite5 = sprite2;
			float num12 = toAlpha - _003CfromAlpha_003E5__2;
			float num13 = Math.Min(_003Cfactor2_003E5__3, 1f);
			bool flag3 = _003Cfactor2_003E5__3 < 0f;
			float num14 = 0f;
			if (!flag3)
			{
				num14 = num13;
			}
			float num15 = num12 * num14;
			float num16 = _003CfromAlpha_003E5__2 + num15;
			object obj5 = uISprite5 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ S2_v19+BC] (should have been resolved before IL gen)");
			_003C_003E2__current = null;
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

	public GameObject FacebookLoginButton;

	public GameObject GameCenterLoginButton;

	public UISprite FacebookIcon;

	public UISprite GameCenterIcon;

	private unsafe void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00e6: Expected F4, but got I
		//IL_00e1: Expected native int or pointer, but got VT
		//IL_0101: Expected F4, but got I
		//IL_00fc: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (!GameCenter.IsSupported() && GameCenterLoginButton != null && FacebookLoginButton != null)
		{
			GameCenterLoginButton.SetActive(value: false);
			UnityEngine.Object.Destroy(GameCenterLoginButton);
			Transform transform = FacebookLoginButton.transform;
			Vector3 localPosition = transform.localPosition;
			Transform transform2 = FacebookLoginButton.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform2.localPosition = vector;
		}
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	private IEnumerator AnimateAlpha(UISprite sprite1, UISprite sprite2, float duration, float toAlpha)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void HandleColliders(bool AddNow)
	{
		if (AddNow)
		{
			NGUITools.AddWidgetCollider(FacebookLoginButton);
			return;
		}
		Collider component = FacebookLoginButton.GetComponent<Collider>();
		if (component != null)
		{
			Collider component2 = FacebookLoginButton.GetComponent<Collider>();
			UnityEngine.Object.Destroy(component2);
		}
	}
}
