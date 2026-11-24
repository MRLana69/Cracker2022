using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.GameCenter;
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

		private float _003Cfactor_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_011d: Expected I, but got Obj
				//IL_0133: Expected Obj, but got I
				//IL_015e: Expected I, but got Obj
				//IL_0202: Unknown result type (might be due to invalid IL or missing references)
				//IL_0207: Expected Obj, but got Unknown
				//IL_0210: Expected Obj, but got I4
				//IL_0224: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
					float num = default;
					_003CfromAlpha_003E5__2 = num;
					_003Cfactor_003E5__3 = 0f;
				}
				if (!(_003Cfactor_003E5__3 < 1f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					((AwardTierHelper)(object)_003C_003E4__this).TierComplete(true);
					return null;
				}
				float unscaledTime = Time.unscaledTime;
				float num2 = unscaledTime / duration;
				float num3 = _003Cfactor_003E5__3 + num2;
				_003Cfactor_003E5__3 = num3;
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num6;
				if (_003Cfactor_003E5__3 < 0f)
				{
					num6 = 0f;
				}
				else
				{
					num6 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
				}
				_003Cfactor_003E5__3 = num6;
				float num7 = Mathf.LerpUnclamped(_003CfromAlpha_003E5__2, toAlpha, _003Cfactor_003E5__3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				float num8 = Mathf.LerpUnclamped(_003CfromAlpha_003E5__2, toAlpha, _003Cfactor_003E5__3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				object obj2 = this + 12;
				obj2 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public GameObject FacebookLoginButton;

	public GameObject GameCenterLoginButton;

	public UISprite FacebookIcon;

	public UISprite GameCenterIcon;

	private void Start()
	{
		CancelInvoke();
	}

	public void EnableButtons()
	{
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0278: Expected Obj, but got I4
		//IL_028c: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_0341: Expected VT, but got I4
		//IL_0223: Expected Obj, but got F4
		//IL_01c9: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 12;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v40 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = (Transform)(transform + 24);
		if (GameCenterPlugin.hasLoginView)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)GameCenterLoginButton).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)FacebookLoginButton).FindKernel((string)null) == 0)
		{
			return;
		}
		GameCenterLoginButton.tag = null;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(GameCenterLoginButton);
		int layer = FacebookLoginButton.layer;
		transform.localPosition = (Vector3)layer;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		obj = 0f;
		int layer2 = FacebookLoginButton.layer;
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
	}

	public void DisableButtons()
	{
	}

	private IEnumerator AnimateAlpha(UISprite sprite1, UISprite sprite2, float duration, float toAlpha)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private void HandleColliders(bool AddNow)
	{
		//IL_0011: Expected Obj, but got I
		//IL_001f: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [AddNow @ L1 (System.Boolean)+14]");
		GameObject gameObject = ((Component)0).gameObject;
		((Transform)(object)this).position = (Vector3)gameObject;
	}
}
