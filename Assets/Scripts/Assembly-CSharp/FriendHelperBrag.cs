using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class FriendHelperBrag : MonoBehaviour
{
	private sealed class _003CDisableDepthPass_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FriendHelperBrag _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0038: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					FriendHelperBrag friendHelperBrag = _003C_003E4__this;
					UITexture friendPicture = friendHelperBrag.friendPicture;
					bool flag = friendPicture.panel != null;
				}
				return false;
			}
			_003C_003E1__state = -1;
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

	private Color localPlayerColor = (Color)4524651749906614409L;

	public UILabel friendRank;

	public UILabel friendName;

	public UILabel friendScore;

	public UITexture friendPicture;

	public UISprite friendBackground;

	public Texture2D dummyImage;

	private bool _isLocalUser;

	private Friend _friend;

	private bool _initialized;

	public unsafe void InitLocalUser(int ranking, bool backgroundActive = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected I4, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected VT, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected VT, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected I4, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected VT, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_0346: Expected I, but got Obj
		//IL_0370: Expected I, but got Obj
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		UISprite uISprite = friendBackground;
		float num = 0.2f;
		if (!backgroundActive)
		{
			num = 0f;
		}
		object obj3 = uISprite - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S2_v4+BC] (should have been resolved before IL gen)");
		int num2 = obj + 60;
		string text = ((int*)num2)->ToString();
		friendRank.text = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHelperBrag)+14]");
		_ = 0;
		_ = localPlayerColor;
		Color color = (Color)(obj + 40);
		friendRank.color = color;
		SocialManager instance = SocialManager.instance;
		string localUserName = instance.localUserName;
		friendName.text = localUserName;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHelperBrag)+14]");
		_ = 0;
		_ = localPlayerColor;
		Color color2 = (Color)(obj + 24);
		friendName.color = color2;
		PlayerInfo instance2 = PlayerInfo.Instance;
		_ = instance2._highScore;
		int num3 = obj + 56;
		string text2 = ((int*)num3)->ToString();
		friendScore.text = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHelperBrag)+14]");
		_ = 0;
		_ = localPlayerColor;
		Color color3 = (Color)(obj + 8);
		friendScore.color = color3;
		SocialManager instance3 = SocialManager.instance;
		object obj4;
		UnityEngine.Object obj5;
		if (instance3._fbProfile != null)
		{
			obj4 = instance3._fbProfile + 20;
		}
		else
		{
			bool flag = instance3._gcProfile == null;
			obj5 = null;
			if (flag)
			{
				goto IL_0283;
			}
			obj4 = instance3._gcProfile + 20;
		}
		obj5 = (UnityEngine.Object)obj4;
		goto IL_0283;
		IL_033e:
		UITexture uITexture;
		nint num4 = (nint)uITexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ S2_v23 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		UITexture uITexture2 = friendPicture;
		Shader shader = Shader.Find("Unlit/Transparent Colored (AlphaClip)");
		nint num5 = (nint)uITexture2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ S2_v27 (Il2CppClass<UITexture>)+1A4] (should have been resolved before IL gen)");
		SocialManager instance4 = SocialManager.instance;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendHelperBrag.OnLocalUserUpdated));
		instance4.AddLocalUserUpdatedHandler(action);
		_isLocalUser = true;
		_initialized = true;
		return;
		IL_0283:
		bool flag2 = obj5 != null;
		uITexture = friendPicture;
		if (flag2)
		{
			SocialManager instance5 = SocialManager.instance;
			object obj6;
			Texture2D texture2D;
			if (instance5._fbProfile != null)
			{
				obj6 = instance5._fbProfile + 20;
			}
			else
			{
				bool flag3 = instance5._gcProfile == null;
				texture2D = null;
				if (flag3)
				{
					goto IL_033e;
				}
				obj6 = instance5._gcProfile + 20;
			}
			texture2D = (Texture2D)obj6;
		}
		else
		{
			Texture2D texture2D = dummyImage;
		}
		goto IL_033e;
	}

	public unsafe void InitFriend(Friend friend, int ranking, bool backgroundActive = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected I4, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I4, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_026f: Expected I, but got Obj
		//IL_0299: Expected I, but got Obj
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_friend = friend;
		UISprite uISprite = friendBackground;
		float num = 0.2f;
		if (!backgroundActive)
		{
			num = 0f;
		}
		object obj3 = uISprite - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v4+BC] (should have been resolved before IL gen)");
		int num2 = obj + 12;
		string text = ((int*)num2)->ToString();
		friendRank.text = text;
		string text2 = _friend.name;
		friendName.text = text2;
		int num3 = _friend + 12;
		string text3 = ((int*)num3)->ToString();
		friendScore.text = text3;
		Friend friend2 = _friend;
		object obj4;
		UnityEngine.Object obj5;
		if (friend2.fbProfile != null)
		{
			obj4 = friend2.fbProfile + 20;
		}
		else
		{
			bool flag = friend2.gcProfile == null;
			obj5 = null;
			if (flag)
			{
				goto IL_01ce;
			}
			obj4 = friend2.gcProfile + 20;
		}
		obj5 = (UnityEngine.Object)obj4;
		goto IL_01ce;
		IL_0267:
		UITexture uITexture;
		nint num4 = (nint)uITexture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S2_v17 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		UITexture uITexture2 = friendPicture;
		Shader shader = Shader.Find("Unlit/Transparent Colored (AlphaClip)");
		nint num5 = (nint)uITexture2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ S2_v21 (Il2CppClass<UITexture>)+1A4] (should have been resolved before IL gen)");
		Action action = default;
		action._002Ector(this, (nint)__ldftn(FriendHelperBrag.OnFriendUpdatedHandler));
		_friend.AddUpdatedHandler(action);
		_initialized = true;
		return;
		IL_01ce:
		bool flag2 = obj5 != null;
		uITexture = friendPicture;
		if (flag2)
		{
			Friend friend3 = _friend;
			object obj6;
			Texture2D texture2D;
			if (friend3.fbProfile != null)
			{
				obj6 = friend3.fbProfile + 20;
			}
			else
			{
				bool flag3 = friend3.gcProfile == null;
				texture2D = null;
				if (flag3)
				{
					goto IL_0267;
				}
				obj6 = friend3.gcProfile + 20;
			}
			texture2D = (Texture2D)obj6;
		}
		else
		{
			Texture2D texture2D = dummyImage;
		}
		goto IL_0267;
	}

	private unsafe void OnDestroy()
	{
		if (~(_initialized ? 1u : 0u) == 0)
		{
			if (~(_isLocalUser ? 1u : 0u) != 0)
			{
				Action action = default;
				action._002Ector(this, (nint)__ldftn(FriendHelperBrag.OnFriendUpdatedHandler));
				_friend.RemoveUpdatedHandler(action);
			}
			else
			{
				SocialManager instance = SocialManager.instance;
				Action action2 = default;
				action2._002Ector(this, (nint)__ldftn(FriendHelperBrag.OnLocalUserUpdated));
				instance.RemoveLocalUserUpdatedHandler(action2);
			}
		}
	}

	private void OnFriendUpdatedHandler()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
		//IL_0180: Expected I, but got Obj
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		Friend friend = _friend;
		object obj;
		UnityEngine.Object obj2;
		if (friend.fbProfile != null)
		{
			obj = friend.fbProfile + 20;
		}
		else
		{
			bool flag = friend.gcProfile == null;
			obj2 = null;
			if (flag)
			{
				goto IL_0144;
			}
			obj = friend.gcProfile + 20;
		}
		obj2 = (UnityEngine.Object)obj;
		goto IL_0144;
		IL_0144:
		if (!(obj2 != null))
		{
			return;
		}
		UITexture uITexture = friendPicture;
		Friend friend2 = _friend;
		object obj3;
		object obj4;
		if (friend2.fbProfile != null)
		{
			obj3 = friend2.fbProfile + 20;
		}
		else
		{
			bool flag2 = friend2.gcProfile == null;
			obj4 = 0;
			if (flag2)
			{
				goto IL_0178;
			}
			obj3 = friend2.gcProfile + 20;
		}
		obj4 = obj3;
		goto IL_0178;
		IL_0178:
		nint num = (nint)uITexture;
		object obj5 = uITexture + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ S2_v5 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		UITexture uITexture2 = friendPicture;
		if (uITexture2.panel != null)
		{
			IEnumerator routine = DisableDepthPass();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private void OnLocalUserUpdated()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_017e: Expected I, but got Obj
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		SocialManager instance = SocialManager.instance;
		object obj;
		UnityEngine.Object obj2;
		if (instance._fbProfile != null)
		{
			obj = instance._fbProfile + 20;
		}
		else
		{
			bool flag = instance._gcProfile == null;
			obj2 = null;
			if (flag)
			{
				goto IL_0142;
			}
			obj = instance._gcProfile + 20;
		}
		obj2 = (UnityEngine.Object)obj;
		goto IL_0142;
		IL_0142:
		if (!(obj2 != null))
		{
			return;
		}
		UITexture uITexture = friendPicture;
		SocialManager instance2 = SocialManager.instance;
		object obj3;
		object obj4;
		if (instance2._fbProfile != null)
		{
			obj3 = instance2._fbProfile + 20;
		}
		else
		{
			bool flag2 = instance2._gcProfile == null;
			obj4 = 0;
			if (flag2)
			{
				goto IL_0176;
			}
			obj3 = instance2._gcProfile + 20;
		}
		obj4 = obj3;
		goto IL_0176;
		IL_0176:
		nint num = (nint)uITexture;
		object obj5 = uITexture + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v92 @ S2_v5 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		UITexture uITexture2 = friendPicture;
		if (uITexture2.panel != null)
		{
			IEnumerator routine = DisableDepthPass();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator DisableDepthPass()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public FriendHelperBrag()
	{
		//IL_000f: Expected VT, but got I8
		_ = 4575657222467329438L;
		base._002Ector();
	}
}
