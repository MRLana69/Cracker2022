using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using UnityEngine;
using UnityEngine.Events;

namespace UI.Screens;

public class FacebookRewardsPopup : UIScreen
{
	private sealed class _003CDelayPositioning_003Ed__94(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject modelHost;

		public FacebookRewardsPopup _003C_003E4__this;

		public GameObject modelToPosition;

		public Vector3 offset;

		public Vector3 rotation;

		public Vector3 scale;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected VT, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected VT, but got Unknown
			//IL_01d4: Expected Obj, but got VT
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected Obj, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected Obj, but got Unknown
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 160;
			_ = 0;
			_ = 0;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Transform transform = modelHost.transform;
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					UIScreenController instance = UIScreenController.Instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
					_ = 0;
					Vector3 position2 = (Vector3)(obj + 80);
					Vector3 vector = instance.Camera2DNormal.WorldToScreenPoint(position2);
					UIScreenController instance2 = UIScreenController.Instance;
					_ = 1077936128;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					Vector3 position3 = (Vector3)(obj - -64);
					Vector3 vector2 = instance2.Camera3D.ScreenToWorldPoint(position3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
					_ = 0;
					Transform transform2 = modelToPosition.transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup+<DelayPositioning>d__94)+24]");
					_ = 0;
					_ = offset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup+<DelayPositioning>d__94)+30]");
					_ = 0;
					_ = rotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup+<DelayPositioning>d__94)+3C]");
					_ = 0;
					obj = scale;
					object obj3 = obj + 48;
					object obj4 = obj + 32;
					object obj5 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CEC");
				}
			}
			else
			{
				_003C_003E1__state = -1;
				object obj6 = default;
				_003C_003E2__current = obj6;
				_003C_003E1__state = 1;
			}
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

	private UISprite background;

	private UISprite outline;

	private GameObject exitButton;

	private GameObject connectButton;

	private GameObject connectButtonAnchor;

	private UILabel connectButtonLabel;

	private GameObject retrieveButton;

	private GameObject retrieveButtonAnchor;

	private UILabel retrieveButtonLabel;

	private const int FONT_SIZE_BIG = 25;

	private const int FONT_SIZE_SMALL = 20;

	private const float SIZE_OFFSET1 = 0.5f;

	private const float SIZE_OFFSET2 = 2f;

	private const float SIZE_OFFSET3 = 5f;

	private UISprite container1Bg;

	private UISprite container1Check;

	private UISprite[] container1Rays;

	private UISprite container1Glow;

	private UILabel container1Amount;

	private GameObject container1Prefab;

	private UIAnchor container1Anchor;

	private GameObject _container1Model;

	private readonly Vector3 _offset1 = (Vector3)4611686021652807680L;

	private readonly Vector3 _rotation1;

	private readonly Vector3 _scale1 = (Vector3)4706261611697930240L;

	private UISprite container2Bg;

	private UISprite container2Check;

	private UISprite[] container2Rays;

	private UISprite container2Glow;

	private UILabel container2Amount;

	private GameObject container2Prefab;

	private UIAnchor container2Anchor;

	private GameObject _container2Model;

	private readonly Vector3 _offset2 = (Vector3)3225419776L;

	private readonly Vector3 _rotation2;

	private readonly Vector3 _scale2 = (Vector3)4706261611697930240L;

	private UISprite container3Bg;

	private UISprite container3Check;

	private UISprite[] container3Rays;

	private UISprite container3Glow;

	private UILabel container3Amount;

	private GameObject container3Prefab;

	private UIAnchor container3Anchor;

	private GameObject _container3Model;

	private readonly Vector3 _offset3 = (Vector3)4665729213955833856L;

	private readonly Vector3 _rotation3;

	private readonly Vector3 _scale3 = (Vector3)4710765211326349312L;

	private UISprite container4Bg;

	private UISprite container4Check;

	private UISprite[] container4Rays;

	private UISprite container4Glow;

	private UILabel container4Amount;

	private GameObject container4Prefab;

	private UIAnchor container4Anchor;

	private GameObject _container4Model;

	private readonly Vector3 _offset4 = (Vector3)0;

	private readonly Vector3 _rotation4;

	private readonly Vector3 _scale4;

	private UISprite container5Bg;

	private UISprite container5Check;

	private UISprite[] container5Rays;

	private UISprite container5Glow;

	private UILabel container5Line1;

	private UILabel container5Line2;

	private UIAnchor container5Anchor;

	private GameObject _container5Model;

	private GameObject stars1;

	private GameObject stars2;

	private GameObject stars3;

	public override void Show()
	{
		base.Show();
		SocialManager instance = SocialManager.instance;
		bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
		InitTitles(facebookIsLoggedIn);
		InitButtons(facebookIsLoggedIn);
		InitCheckmarks(facebookIsLoggedIn);
		PlayerInfo instance2 = PlayerInfo.Instance;
		if (~(FacebookRewardsInfo.isCharacterRewarded ? 1u : 0u) != 0)
		{
			if (~(instance2._hasPayedOutFacebook ? 1u : 0u) != 0)
			{
				SetupPack();
			}
			else
			{
				SetupPackWithoutCoins();
			}
			return;
		}
		if (~(instance2._hasPayedOutFacebook ? 1u : 0u) != 0)
		{
			SetupPackAndCharacter();
			return;
		}
		PlayerInfo instance3 = PlayerInfo.Instance;
		if (~(instance3._hasPayedOutFacebookPack ? 1u : 0u) != 0)
		{
			SetupPackAndCharacterWithoutCoins();
			return;
		}
		PlayerInfo instance4 = PlayerInfo.Instance;
		if (~(instance4._hasPayedOutFacebookCharacter ? 1u : 0u) != 0)
		{
			SetupCharacter();
			return;
		}
		UIScreenController instance5 = UIScreenController.Instance;
		instance5.CloseActivePopups(screenName);
	}

	public override void Hide()
	{
		base.Hide();
		Show3DElements(show: false);
	}

	public override void GainFocus()
	{
		Show3DElements(show: true);
	}

	public override void LoseFocus()
	{
		Show3DElements(show: false);
	}

	private void Show3DElements(bool show)
	{
		if (_container1Model != null)
		{
			_container1Model.SetActive(show);
		}
		if (_container2Model != null)
		{
			_container2Model.SetActive(show);
		}
		if (_container3Model != null)
		{
			_container3Model.SetActive(show);
		}
		if (_container4Model != null)
		{
			_container4Model.SetActive(show);
		}
		if (_container5Model != null)
		{
			_container5Model.SetActive(show);
		}
	}

	private unsafe void SetupPack()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005a: Expected I, but got Obj
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected VT, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected VT, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Ref, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected VT, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected VT, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected VT, but got Unknown
		//IL_0242: Expected I, but got Obj
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected VT, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected VT, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Ref, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected VT, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected VT, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected VT, but got Unknown
		//IL_042a: Expected I, but got Obj
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected VT, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected VT, but got Unknown
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Ref, but got Unknown
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected VT, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected VT, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected VT, but got Unknown
		//IL_0612: Expected I, but got Obj
		//IL_0631: Expected Obj, but got VT
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected Obj, but got Unknown
		//IL_065d: Expected Obj, but got I
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_068f: Expected Obj, but got I
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected Obj, but got Unknown
		//IL_06d8: Expected F4, but got I
		//IL_06d3: Expected native int or pointer, but got VT
		//IL_0739: Expected F4, but got I
		//IL_0734: Expected native int or pointer, but got VT
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected VT, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected VT, but got Unknown
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected Ref, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected VT, but got Unknown
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected VT, but got Unknown
		//IL_07d8: Expected Obj, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 512);
		ResizePopup(309, 392);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+88]");
		_ = 0;
		_ = _offset1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+94]");
		_ = 0;
		_ = _rotation1;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.oneVector * 5f;
		float num4 = (float)_scale1 + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num5 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+9C]");
		float num6 = 0f + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num7 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+A0]");
		float num8 = 0f + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1C8]");
		_ = 0;
		_ = 4837147478036971520L;
		_ = 4813785052830171136L;
		_ = 4813785052830171136L;
		_ = 4837147478036971520L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1C0]");
		_ = 0;
		Vector2 rewardSize = (Vector2)(vector + 248);
		Vector2 pixelOffset = (Vector2)(vector + 240);
		ref GameObject containerModel = ref *(GameObject*)(this + 124);
		Vector3 modelOffset = vector + 224;
		Vector3 modelRotation = vector + 208;
		Vector3 modelScale = vector + 192;
		SetupContainer(rewardSize, pixelOffset, container1Anchor, container1Amount, FacebookRewardsInfo.FacebookRewardType.Keys, container1Bg, container1Glow, container1Rays, ref containerModel, container1Prefab, modelOffset, modelRotation, modelScale);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+CC]");
		_ = 0;
		_ = _offset2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+D8]");
		_ = 0;
		_ = _rotation2;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v79 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num10 = 0;
		float num11 = (float)Vector3.oneVector * 5f;
		float num12 = (float)_scale2 + num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v80 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num13 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+E0]");
		float num14 = 0f + num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v80 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num15 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+E4]");
		float num16 = 0f + num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+188]");
		_ = 0;
		_ = 4837147475888701440L;
		_ = 4813785052830171136L;
		_ = 4813785052830171136L;
		_ = 4837147475888701440L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+180]");
		_ = 0;
		Vector2 rewardSize2 = (Vector2)(vector + 184);
		Vector2 pixelOffset2 = (Vector2)(vector + 176);
		ref GameObject containerModel2 = ref *(GameObject*)(this + 192);
		Vector3 modelOffset2 = vector + 160;
		Vector3 modelRotation2 = vector + 144;
		Vector3 modelScale2 = vector + 128;
		SetupContainer(rewardSize2, pixelOffset2, container2Anchor, container2Amount, FacebookRewardsInfo.FacebookRewardType.Headstarts, container2Bg, container2Glow, container2Rays, ref containerModel2, container2Prefab, modelOffset2, modelRotation2, modelScale2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+110]");
		_ = 0;
		_ = _offset3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+11C]");
		_ = 0;
		_ = _rotation3;
		nint num17 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v127 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num18 = 0;
		float num19 = (float)Vector3.oneVector * 5f;
		float num20 = (float)_scale3 + num19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v128 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num21 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+124]");
		float num22 = 0f + num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S0_v128 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num23 = 0f * 5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+128]");
		float num24 = 0f + num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+178]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+168]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+148]");
		_ = 0;
		_ = 4779445107811287040L;
		_ = 4813785052830171136L;
		_ = 4813785052830171136L;
		_ = 4779445107811287040L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+170]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+160]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+140]");
		_ = 0;
		Vector2 rewardSize3 = (Vector2)(vector + 120);
		Vector2 pixelOffset3 = (Vector2)(vector + 112);
		ref GameObject containerModel3 = ref *(GameObject*)(this + 260);
		Vector3 modelOffset3 = vector + 96;
		Vector3 modelRotation3 = vector + 80;
		Vector3 modelScale3 = vector - -64;
		SetupContainer(rewardSize3, pixelOffset3, container3Anchor, container3Amount, FacebookRewardsInfo.FacebookRewardType.Hoverboards, container3Bg, container3Glow, container3Rays, ref containerModel3, container3Prefab, modelOffset3, modelRotation3, modelScale3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+154]");
		_ = 0;
		_ = _offset4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+160]");
		_ = 0;
		_ = _rotation4;
		nint num25 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S0_v175 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num26 = 0;
		object obj2 = Vector3.oneVector + Vector3.oneVector;
		object obj3 = _scale4 + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v176 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v176 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		object obj4 = num27 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+168]");
		object obj5 = 0 + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v176 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v176 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		object obj6 = num28 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+16C]");
		object obj7 = 0 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = 4779445105663016960L;
		_ = 4813785052830171136L;
		_ = 4813785052830171136L;
		_ = 4779445105663016960L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector2 rewardSize4 = (Vector2)(vector + 56);
		Vector2 pixelOffset4 = (Vector2)(vector + 48);
		ref GameObject containerModel4 = ref *(GameObject*)(this + 328);
		Vector3 modelOffset4 = vector + 32;
		Vector3 modelRotation4 = vector + 16;
		SetupContainer(rewardSize4, pixelOffset4, container4Anchor, container4Amount, FacebookRewardsInfo.FacebookRewardType.Coins, container4Bg, container4Glow, container4Rays, ref containerModel4, container4Prefab, modelOffset4, modelRotation4, vector);
		((FacebookRewardsPopup)vector).DisableContainer(container5Anchor, _container5Model);
		SetupLabelSize(25);
	}

	private unsafe void SetupPackWithoutCoins()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0065: Expected I, but got Obj
		//IL_0084: Expected Obj, but got VT
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected VT, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected VT, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Ref, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected VT, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected VT, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected VT, but got Unknown
		//IL_024f: Expected I, but got Obj
		//IL_026e: Expected Obj, but got VT
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_029a: Expected Obj, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected VT, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected VT, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Ref, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected VT, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected VT, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected VT, but got Unknown
		//IL_0439: Expected I, but got Obj
		//IL_0458: Expected Obj, but got VT
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0484: Expected Obj, but got I
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04b6: Expected Obj, but got I
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_04ff: Expected F4, but got I
		//IL_04fa: Expected native int or pointer, but got VT
		//IL_0560: Expected F4, but got I
		//IL_055b: Expected native int or pointer, but got VT
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected VT, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected VT, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected Ref, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected VT, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected VT, but got Unknown
		//IL_05ff: Expected Obj, but got VT
		//IL_0614: Expected Obj, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 384);
		ResizePopup(309, 287);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+88]");
		_ = 0;
		_ = _offset1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+94]");
		_ = 0;
		_ = _rotation1;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		object obj2 = Vector3.oneVector + Vector3.oneVector;
		object obj3 = _scale1 + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		object obj4 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+9C]");
		object obj5 = 0 + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		object obj6 = num4 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+A0]");
		object obj7 = 0 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+178]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+168]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+148]");
		_ = 0;
		_ = 4785074607348514816L;
		_ = 4813785052824469504L;
		_ = 4813785052824469504L;
		_ = 4785074607348514816L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+170]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+160]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+140]");
		_ = 0;
		Vector2 rewardSize = (Vector2)(vector + 184);
		Vector2 pixelOffset = (Vector2)(vector + 176);
		ref GameObject containerModel = ref *(GameObject*)(this + 124);
		Vector3 modelOffset = vector + 160;
		Vector3 modelRotation = vector + 144;
		Vector3 modelScale = vector + 128;
		SetupContainer(rewardSize, pixelOffset, container1Anchor, container1Amount, FacebookRewardsInfo.FacebookRewardType.Keys, container1Bg, container1Glow, container1Rays, ref containerModel, container1Prefab, modelOffset, modelRotation, modelScale);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+CC]");
		_ = 0;
		_ = _offset2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+D8]");
		_ = 0;
		_ = _rotation2;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v79 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		object obj8 = Vector3.oneVector + Vector3.oneVector;
		object obj9 = _scale2 + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v80 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v80 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		object obj10 = num7 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+E0]");
		object obj11 = 0 + obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v80 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v80 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		object obj12 = num8 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+E4]");
		object obj13 = 0 + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
		_ = 0;
		_ = 4785074605200244736L;
		_ = 4813785052824469504L;
		_ = 4813785052824469504L;
		_ = 4785074605200244736L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
		_ = 0;
		Vector2 rewardSize2 = (Vector2)(vector + 120);
		Vector2 pixelOffset2 = (Vector2)(vector + 112);
		ref GameObject containerModel2 = ref *(GameObject*)(this + 192);
		Vector3 modelOffset2 = vector + 96;
		Vector3 modelRotation2 = vector + 80;
		Vector3 modelScale2 = vector - -64;
		SetupContainer(rewardSize2, pixelOffset2, container2Anchor, container2Amount, FacebookRewardsInfo.FacebookRewardType.Headstarts, container2Bg, container2Glow, container2Rays, ref containerModel2, container2Prefab, modelOffset2, modelRotation2, modelScale2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+110]");
		_ = 0;
		_ = _offset3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+11C]");
		_ = 0;
		_ = _rotation3;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v127 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num10 = 0;
		object obj14 = Vector3.oneVector + Vector3.oneVector;
		object obj15 = _scale3 + obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v128 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v128 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		object obj16 = num11 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+124]");
		object obj17 = 0 + obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v128 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v128 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		object obj18 = num12 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+128]");
		object obj19 = 0 + obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C8]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = 4785074607306571776L;
		_ = 4813785052824469504L;
		_ = 4813785052824469504L;
		_ = 4785074607306571776L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+C0]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector2 rewardSize3 = (Vector2)(vector + 56);
		Vector2 pixelOffset3 = (Vector2)(vector + 48);
		ref GameObject containerModel3 = ref *(GameObject*)(this + 260);
		Vector3 modelOffset3 = vector + 32;
		Vector3 modelRotation3 = vector + 16;
		SetupContainer(rewardSize3, pixelOffset3, container3Anchor, container3Amount, FacebookRewardsInfo.FacebookRewardType.Hoverboards, container3Bg, container3Glow, container3Rays, ref containerModel3, container3Prefab, modelOffset3, modelRotation3, vector);
		((FacebookRewardsPopup)vector).DisableContainer(container4Anchor, _container4Model);
		((FacebookRewardsPopup)vector).DisableContainer(container5Anchor, _container5Model);
		SetupLabelSize(25);
	}

	private unsafe void SetupPackAndCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected VT, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected VT, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Ref, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected VT, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected VT, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected VT, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected VT, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected VT, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Ref, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected VT, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected VT, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected VT, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected VT, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected VT, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Ref, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected VT, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected VT, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected VT, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected VT, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected VT, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Ref, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected VT, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected VT, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected VT, but got Unknown
		//IL_0437: Expected I, but got Obj
		//IL_04ba: Expected F4, but got I
		//IL_04b5: Expected native int or pointer, but got VT
		//IL_0529: Expected F4, but got I
		//IL_0524: Expected native int or pointer, but got VT
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected VT, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected VT, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected VT, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 448);
		ResizePopup(309, 363);
		_ = 4831236501361655808L;
		_ = 4805340803521445888L;
		_ = 4805340803521445888L;
		_ = 4831236501361655808L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+88]");
		_ = 0;
		_ = _offset1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+94]");
		_ = 0;
		_ = _rotation1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+A0]");
		_ = 0;
		_ = _scale1;
		Vector2 rewardSize = (Vector2)(vector + 312);
		Vector2 pixelOffset = (Vector2)(vector + 304);
		ref GameObject containerModel = ref *(GameObject*)(this + 124);
		Vector3 modelOffset = vector + 288;
		Vector3 modelRotation = vector + 272;
		Vector3 modelScale = vector + 256;
		SetupContainer(rewardSize, pixelOffset, container1Anchor, container1Amount, FacebookRewardsInfo.FacebookRewardType.Keys, container1Bg, container1Glow, container1Rays, ref containerModel, container1Prefab, modelOffset, modelRotation, modelScale);
		_ = 4831236501381840896L;
		_ = 4805340803521445888L;
		_ = 4805340803521445888L;
		_ = 4831236501381840896L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+CC]");
		_ = 0;
		_ = _offset2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+D8]");
		_ = 0;
		_ = _rotation2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+E4]");
		_ = 0;
		_ = _scale2;
		Vector2 rewardSize2 = (Vector2)(vector + 248);
		Vector2 pixelOffset2 = (Vector2)(vector + 240);
		ref GameObject containerModel2 = ref *(GameObject*)(this + 192);
		Vector3 modelOffset2 = vector + 224;
		Vector3 modelRotation2 = vector + 208;
		Vector3 modelScale2 = vector + 192;
		SetupContainer(rewardSize2, pixelOffset2, container2Anchor, container2Amount, FacebookRewardsInfo.FacebookRewardType.Headstarts, container2Bg, container2Glow, container2Rays, ref containerModel2, container2Prefab, modelOffset2, modelRotation2, modelScale2);
		_ = 4773815606112681984L;
		_ = 4805340803521445888L;
		_ = 4805340803521445888L;
		_ = 4773815606112681984L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+110]");
		_ = 0;
		_ = _offset3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+11C]");
		_ = 0;
		_ = _rotation3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+128]");
		_ = 0;
		_ = _scale3;
		Vector2 rewardSize3 = (Vector2)(vector + 184);
		Vector2 pixelOffset3 = (Vector2)(vector + 176);
		ref GameObject containerModel3 = ref *(GameObject*)(this + 260);
		Vector3 modelOffset3 = vector + 160;
		Vector3 modelRotation3 = vector + 144;
		Vector3 modelScale3 = vector + 128;
		SetupContainer(rewardSize3, pixelOffset3, container3Anchor, container3Amount, FacebookRewardsInfo.FacebookRewardType.Hoverboards, container3Bg, container3Glow, container3Rays, ref containerModel3, container3Prefab, modelOffset3, modelRotation3, modelScale3);
		_ = 4773815606132867072L;
		_ = 4805340803521445888L;
		_ = 4805340803521445888L;
		_ = 4773815606132867072L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+154]");
		_ = 0;
		_ = _offset4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+160]");
		_ = 0;
		_ = _rotation4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+16C]");
		_ = 0;
		_ = _scale4;
		Vector2 rewardSize4 = (Vector2)(vector + 120);
		Vector2 pixelOffset4 = (Vector2)(vector + 112);
		ref GameObject containerModel4 = ref *(GameObject*)(this + 328);
		Vector3 modelOffset4 = vector + 96;
		Vector3 modelRotation4 = vector + 80;
		Vector3 modelScale4 = vector - -64;
		SetupContainer(rewardSize4, pixelOffset4, container4Anchor, container4Amount, FacebookRewardsInfo.FacebookRewardType.Coins, container4Bg, container4Glow, container4Rays, ref containerModel4, container4Prefab, modelOffset4, modelRotation4, modelScale4);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v101 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.oneVector * 26f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v102 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num4 = 0f * 26f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v102 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num5 = 0f * 26f;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+148]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = 4808718505390505984L;
		_ = 4842776975429468160L;
		_ = -4418031234450456576L;
		_ = 4839680749563019264L;
		_ = 4842776975429468160L;
		_ = 4808718505390505984L;
		_ = -4418031234450456576L;
		_ = 4839680749563019264L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+140]");
		((Vector3*)(nint)vector)->x = 0f;
		Vector2 rewardSize5 = (Vector2)(vector + 56);
		Vector2 pixelOffset5 = (Vector2)(vector + 48);
		Vector3 positionOffset = vector + 32;
		Vector3 rotationOffset = vector + 16;
		SetupContainer5(rewardSize5, pixelOffset5, positionOffset, rotationOffset, vector);
		ActivateStars(1);
		SetupCharacterTitle(isFullscreen: false);
		SetupLabelSize(20);
	}

	private unsafe void SetupPackAndCharacterWithoutCoins()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0093: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I8
		//IL_01a8: Expected Obj, but got I8
		//IL_01ca: Expected VT, but got I
		//IL_01df: Expected Obj, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected VT, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected VT, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Ref, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected VT, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected VT, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected VT, but got Unknown
		//IL_02e0: Expected I, but got Obj
		//IL_034e: Expected Obj, but got F4
		//IL_038a: Expected Obj, but got F4
		//IL_039f: Expected Obj, but got I
		//IL_03b1: Expected VT, but got Obj
		//IL_03c8: Expected Obj, but got F4
		//IL_03d5: Expected Obj, but got F4
		//IL_03e2: Expected Obj, but got F4
		//IL_03ef: Expected Obj, but got F4
		//IL_0415: Expected Obj, but got I8
		//IL_0427: Expected Obj, but got I8
		//IL_0450: Expected VT, but got Obj
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected VT, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected VT, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Ref, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected VT, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected VT, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected VT, but got Unknown
		//IL_057f: Expected I, but got Obj
		//IL_05f2: Expected VT, but got F4
		//IL_062e: Expected Obj, but got F4
		//IL_0643: Expected Obj, but got I
		//IL_0655: Expected Obj, but got VT
		//IL_0662: Expected VT, but got F4
		//IL_0683: Expected Obj, but got I8
		//IL_0695: Expected Obj, but got I8
		//IL_06a2: Expected Obj, but got F4
		//IL_06af: Expected Obj, but got F4
		//IL_06c1: Expected Obj, but got I8
		//IL_06d3: Expected Obj, but got I8
		//IL_06e8: Expected Obj, but got I
		//IL_06fd: Expected Obj, but got I
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected VT, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected VT, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Ref, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected VT, but got Unknown
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected VT, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Expected VT, but got Unknown
		//IL_07e1: Expected I, but got Obj
		//IL_083f: Expected VT, but got F4
		//IL_0875: Expected I, but got VT
		//IL_0882: Expected Obj, but got F4
		//IL_088f: Expected Obj, but got F4
		//IL_08a1: Expected Obj, but got I8
		//IL_08b3: Expected Obj, but got I8
		//IL_08c5: Expected VT, but got I8
		//IL_08e1: Expected Obj, but got I8
		//IL_08f3: Expected Obj, but got I8
		//IL_0905: Expected I4, but got I8
		//IL_0917: Expected I4, but got I8
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected VT, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected VT, but got Unknown
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Expected VT, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected VT, but got Unknown
		//IL_0976: Expected VT, but got Obj
		object obj = default;
		FacebookRewardsPopup facebookRewardsPopup = (FacebookRewardsPopup)(obj - 512);
		ResizePopup(309, 400);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+88]");
		_ = 0;
		_ = _offset1;
		float num = (float)_rotation1 + 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+90]");
		float num2 = 0f + 14f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+94]");
		float num3 = 0f + -4f;
		nint num4 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num5 = 0;
		float num6 = (float)Vector3.oneVector * 0.5f;
		float num7 = (float)_scale1 + num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v39 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num8 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+9C]");
		float num9 = 0f + num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v39 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num10 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+A0]");
		float num11 = 0f + num10;
		FacebookRewardsPopup facebookRewardsPopup2 = facebookRewardsPopup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+1F8]");
		facebookRewardsPopup2.container3Bg = (UISprite)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+1D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+1C8]");
		_ = 0;
		_ = 4844184350308040704L;
		_ = 4795207704364580864L;
		facebookRewardsPopup.container3Amount = (UILabel)4795207704364580864L;
		facebookRewardsPopup.container3Rays = (UISprite[])4844184350308040704L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+1F0]");
		_ = 0;
		FacebookRewardsPopup facebookRewardsPopup3 = facebookRewardsPopup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+1D0]");
		facebookRewardsPopup3._rotation2 = (Vector3)0;
		FacebookRewardsPopup facebookRewardsPopup4 = facebookRewardsPopup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+1C0]");
		facebookRewardsPopup4._container2Model = (GameObject)0;
		Vector2 rewardSize = (Vector2)(facebookRewardsPopup + 248);
		Vector2 pixelOffset = (Vector2)(facebookRewardsPopup + 240);
		ref GameObject containerModel = ref *(GameObject*)(this + 124);
		Vector3 modelOffset = (Vector3)(facebookRewardsPopup + 224);
		Vector3 modelRotation = (Vector3)(facebookRewardsPopup + 208);
		Vector3 modelScale = (Vector3)(facebookRewardsPopup + 192);
		SetupContainer(rewardSize, pixelOffset, container1Anchor, container1Amount, FacebookRewardsInfo.FacebookRewardType.Keys, container1Bg, container1Glow, container1Rays, ref containerModel, container1Prefab, modelOffset, modelRotation, modelScale);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+CC]");
		_ = 0;
		_ = _offset2;
		float num12 = (float)_rotation2 + 22f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+D4]");
		float num13 = 0f + -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+D8]");
		float num14 = 0f + -6f;
		nint num15 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v96 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num16 = 0;
		float num17 = (float)Vector3.oneVector * 0.5f;
		float num18 = (float)_scale2 + num17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v97 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num19 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+E0]");
		float num20 = 0f + num19;
		facebookRewardsPopup.stars3 = (GameObject)num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v97 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num21 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+E4]");
		float num22 = 0f + num21;
		facebookRewardsPopup.container5Anchor = (UIAnchor)num22;
		FacebookRewardsPopup facebookRewardsPopup5 = facebookRewardsPopup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+1B8]");
		facebookRewardsPopup5.container2Check = (UISprite)0;
		facebookRewardsPopup._scale1 = (Vector3)facebookRewardsPopup.stars3;
		_ = facebookRewardsPopup.container5Anchor;
		facebookRewardsPopup.stars2 = (GameObject)num13;
		facebookRewardsPopup.stars1 = (GameObject)num12;
		facebookRewardsPopup.container5Line2 = (UILabel)num20;
		facebookRewardsPopup.container5Line1 = (UILabel)num18;
		_ = 4760304807248265216L;
		_ = 4795207704364580864L;
		facebookRewardsPopup.container2Prefab = (GameObject)4795207704364580864L;
		facebookRewardsPopup.container2Glow = (UISprite)4760304807248265216L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+1B0]");
		_ = 0;
		_ = facebookRewardsPopup.stars1;
		facebookRewardsPopup._offset1 = (Vector3)facebookRewardsPopup.container5Line1;
		Vector2 rewardSize2 = (Vector2)(facebookRewardsPopup + 184);
		Vector2 pixelOffset2 = (Vector2)(facebookRewardsPopup + 176);
		ref GameObject containerModel2 = ref *(GameObject*)(this + 192);
		Vector3 modelOffset2 = (Vector3)(facebookRewardsPopup + 160);
		Vector3 modelRotation2 = (Vector3)(facebookRewardsPopup + 144);
		Vector3 modelScale2 = (Vector3)(facebookRewardsPopup + 128);
		SetupContainer(rewardSize2, pixelOffset2, container2Anchor, container2Amount, FacebookRewardsInfo.FacebookRewardType.Headstarts, container2Bg, container2Glow, container2Rays, ref containerModel2, container2Prefab, modelOffset2, modelRotation2, modelScale2);
		float num23 = (float)_offset3 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+10C]");
		float num24 = 0f + -5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+110]");
		float num25 = 0f + 0f;
		float num26 = (float)_rotation3 + -16f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+118]");
		float num27 = 0f + 8f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+11C]");
		float num28 = 0f + -2f;
		nint num29 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v161 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num30 = 0;
		float num31 = (float)Vector3.oneVector * 0.5f;
		float num32 = (float)_scale3 + num31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v162 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num33 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+124]");
		float num34 = 0f + num33;
		facebookRewardsPopup._rotation4 = (Vector3)num28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v162 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num35 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.FacebookRewardsPopup)+128]");
		float num36 = 0f + num35;
		facebookRewardsPopup._container4Model = (GameObject)num36;
		FacebookRewardsPopup facebookRewardsPopup6 = facebookRewardsPopup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+168]");
		facebookRewardsPopup6.container1Rays = (UISprite[])0;
		facebookRewardsPopup.retrieveButtonAnchor = (GameObject)facebookRewardsPopup._rotation4;
		facebookRewardsPopup._scale4 = (Vector3)num24;
		facebookRewardsPopup.container5Bg = (UISprite)4818288652450660352L;
		facebookRewardsPopup.container5Rays = (UISprite[])4795207704364580864L;
		facebookRewardsPopup.container4Anchor = (UIAnchor)num34;
		facebookRewardsPopup.container4Prefab = (GameObject)num32;
		facebookRewardsPopup.container1Anchor = (UIAnchor)4795207704364580864L;
		facebookRewardsPopup.container1Amount = (UILabel)4818288652450660352L;
		FacebookRewardsPopup facebookRewardsPopup7 = facebookRewardsPopup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+160]");
		facebookRewardsPopup7.container1Bg = (UISprite)0;
		FacebookRewardsPopup facebookRewardsPopup8 = facebookRewardsPopup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UI.Screens.FacebookRewardsPopup)+150]");
		facebookRewardsPopup8.connectButtonLabel = (UILabel)0;
		facebookRewardsPopup.connectButton = facebookRewardsPopup._container4Model;
		facebookRewardsPopup.outline = (UISprite)(object)facebookRewardsPopup.container4Prefab;
		Vector2 rewardSize3 = (Vector2)(facebookRewardsPopup + 120);
		Vector2 pixelOffset3 = (Vector2)(facebookRewardsPopup + 112);
		ref GameObject containerModel3 = ref *(GameObject*)(this + 260);
		Vector3 modelOffset3 = (Vector3)(facebookRewardsPopup + 96);
		Vector3 modelRotation3 = (Vector3)(facebookRewardsPopup + 80);
		Vector3 modelScale3 = (Vector3)(facebookRewardsPopup - -64);
		SetupContainer(rewardSize3, pixelOffset3, container3Anchor, container3Amount, FacebookRewardsInfo.FacebookRewardType.Hoverboards, container3Bg, container3Glow, container3Rays, ref containerModel3, container3Prefab, modelOffset3, modelRotation3, modelScale3);
		facebookRewardsPopup.DisableContainer(container4Anchor, _container4Model);
		nint num37 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v194 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num38 = 0;
		float num39 = (float)Vector3.oneVector * 31f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v195 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num40 = 0f * 31f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v195 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num41 = 0f * 31f;
		facebookRewardsPopup._offset3 = (Vector3)num41;
		_ = 0;
		_ = 0;
		facebookRewardsPopup.InComplete = null;
		facebookRewardsPopup._selectedFooterButton = 0;
		((UnityEngine.Object)facebookRewardsPopup).m_CachedPtr = (IntPtr)facebookRewardsPopup._offset3;
		facebookRewardsPopup._container3Model = (GameObject)num40;
		facebookRewardsPopup.container3Anchor = (UIAnchor)num39;
		facebookRewardsPopup.container4Check = (UISprite)4818288654595391488L;
		facebookRewardsPopup.container4Glow = (UISprite)4853754499524591616L;
		facebookRewardsPopup._scale3 = (Vector3)(-4402831585708081152L);
		_ = 4842495499330125824L;
		facebookRewardsPopup.subtitle = (UILabel)4853754499524591616L;
		((UIScreen)facebookRewardsPopup).parentScreen__BackingField = (string)4818288654595391488L;
		((UIScreen)facebookRewardsPopup)._footerInited = false;
		((UIScreen)facebookRewardsPopup).addScreen = false;
		facebookRewardsPopup = (FacebookRewardsPopup)(object)facebookRewardsPopup.container3Anchor;
		Vector2 rewardSize4 = (Vector2)(facebookRewardsPopup + 56);
		Vector2 pixelOffset4 = (Vector2)(facebookRewardsPopup + 48);
		Vector3 positionOffset = (Vector3)(facebookRewardsPopup + 32);
		Vector3 rotationOffset = (Vector3)(facebookRewardsPopup + 16);
		SetupContainer5(rewardSize4, pixelOffset4, positionOffset, rotationOffset, (Vector3)facebookRewardsPopup);
		ActivateStars(2);
		SetupCharacterTitle(isFullscreen: false);
		SetupLabelSize(20);
	}

	private void SetupCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00b2: Expected I, but got Obj
		//IL_0110: Expected Obj, but got F4
		//IL_014e: Expected I, but got Obj
		//IL_015b: Expected Obj, but got F4
		//IL_0168: Expected Obj, but got F4
		//IL_017a: Expected Obj, but got I8
		//IL_018c: Expected Obj, but got I8
		//IL_019e: Expected Obj, but got I8
		//IL_01b0: Expected Obj, but got I8
		//IL_01c2: Expected Obj, but got I8
		//IL_01d4: Expected Obj, but got I8
		//IL_01e6: Expected I4, but got I8
		//IL_01f8: Expected I4, but got I8
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected VT, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected VT, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected VT, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected VT, but got Unknown
		//IL_0257: Expected VT, but got Obj
		object obj = default;
		FacebookRewardsPopup facebookRewardsPopup = (FacebookRewardsPopup)(obj - 128);
		ResizePopup(309, 363);
		facebookRewardsPopup.DisableContainer(container1Anchor, _container1Model);
		facebookRewardsPopup.DisableContainer(container2Anchor, _container2Model);
		facebookRewardsPopup.DisableContainer(container3Anchor, _container3Model);
		facebookRewardsPopup.DisableContainer(container4Anchor, _container4Model);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v13 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.oneVector * 32f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v14 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num4 = 0f * 32f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v14 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num5 = 0f * 32f;
		facebookRewardsPopup.connectButton = (GameObject)num5;
		facebookRewardsPopup.container1Rays = null;
		facebookRewardsPopup.retrieveButtonAnchor = null;
		facebookRewardsPopup.InComplete = null;
		facebookRewardsPopup._selectedFooterButton = 0;
		((UnityEngine.Object)facebookRewardsPopup).m_CachedPtr = (IntPtr)facebookRewardsPopup.connectButton;
		facebookRewardsPopup.exitButton = (GameObject)num4;
		facebookRewardsPopup.outline = (UISprite)num3;
		facebookRewardsPopup.container1Amount = (UILabel)4809281452078268416L;
		facebookRewardsPopup.container1Anchor = (UIAnchor)4843058450414632960L;
		facebookRewardsPopup.container1Bg = (UISprite)(-4389320783568306176L);
		facebookRewardsPopup.connectButtonLabel = (UILabel)4842495499330125824L;
		facebookRewardsPopup.subtitle = (UILabel)4843058450414632960L;
		((UIScreen)facebookRewardsPopup).parentScreen__BackingField = (string)4809281452078268416L;
		((UIScreen)facebookRewardsPopup)._footerInited = false;
		((UIScreen)facebookRewardsPopup).addScreen = false;
		facebookRewardsPopup = (FacebookRewardsPopup)(object)facebookRewardsPopup.outline;
		Vector2 rewardSize = (Vector2)(facebookRewardsPopup + 56);
		Vector2 pixelOffset = (Vector2)(facebookRewardsPopup + 48);
		Vector3 positionOffset = (Vector3)(facebookRewardsPopup + 32);
		Vector3 rotationOffset = (Vector3)(facebookRewardsPopup + 16);
		SetupContainer5(rewardSize, pixelOffset, positionOffset, rotationOffset, (Vector3)facebookRewardsPopup);
		ActivateStars(3);
		SetupCharacterTitle(isFullscreen: true);
		GameObject gameObject = container5Check.gameObject;
		gameObject.SetActive(value: false);
	}

	private void SetupLabelSize(int fontSize)
	{
		container1Amount.fontSize = fontSize;
		container2Amount.fontSize = fontSize;
		container3Amount.fontSize = fontSize;
		container4Amount.fontSize = fontSize;
	}

	private void SetupCharacterTitle(bool isFullscreen)
	{
		//IL_0033: Expected VT, but got I8
		//IL_0012: Expected VT, but got I8
		UIAnchor component = container5Line2.GetComponent<UIAnchor>();
		Vector2 pixelOffset = (Vector2)4744542208545783808L;
		if (!isFullscreen)
		{
			pixelOffset = (Vector2)4656722014701092864L;
		}
		component.pixelOffset = pixelOffset;
	}

	private unsafe void SetupContainer(Vector2 rewardSize, Vector2 pixelOffset, UIAnchor containerAnchor, UILabel containerAmount, FacebookRewardsInfo.FacebookRewardType rewardType, UISprite containerBg, UISprite containerGlow, UISprite[] containerRays, ref GameObject containerModel, GameObject containerPrefab, Vector3 modelOffset, Vector3 modelRotation, Vector3 modelScale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		//IL_0088: Expected Obj, but got F4
		//IL_009a: Expected Obj, but got F4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected VT, but got Unknown
		//IL_0174: Expected Obj, but got F4
		//IL_0186: Expected Obj, but got F4
		//IL_0198: Expected I4, but got F4
		//IL_01aa: Expected I4, but got F4
		//IL_01bc: Expected I4, but got F4
		//IL_01ce: Expected I, but got F4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected VT, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected VT, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected VT, but got Unknown
		//IL_0229: Expected VT, but got F4
		object obj = default;
		FacebookRewardsPopup facebookRewardsPopup = (FacebookRewardsPopup)(obj - 80);
		GameObject gameObject = containerAnchor.gameObject;
		gameObject.SetActive(value: true);
		int num = FacebookRewardsInfo.facebookRewardPack.get_Item(rewardType);
		facebookRewardsPopup.connectButtonAnchor = (GameObject)num;
		int num2 = facebookRewardsPopup + 76;
		string text = ((int*)num2)->ToString();
		string text2 = "x" + text;
		containerAmount.text = text2;
		facebookRewardsPopup.subtitle = (UILabel)rewardSize.x;
		facebookRewardsPopup.outline = (UISprite)rewardSize.x;
		Vector2 newSize = (Vector2)(facebookRewardsPopup + 56);
		facebookRewardsPopup.ResizeReward(containerBg, containerGlow, containerRays, newSize);
		if (containerModel != null)
		{
			containerModel.SetActive(value: true);
		}
		else
		{
			UIModelController instance = UIModelController.Instance;
			GameObject gameObject2 = NGUITools.AddChild(instance.TutorialPopupAnchor, containerPrefab);
			ref GameObject reference = ref *(GameObject*)gameObject2;
			Layers instance2 = Layers.Instance;
			SetLayerRecursively(containerModel, instance2._3DGUI);
		}
		GameObject modelHost = containerBg.gameObject;
		((UIScreen)facebookRewardsPopup).parentScreen__BackingField = (string)modelOffset.z;
		facebookRewardsPopup.InComplete = (UnityEvent)modelOffset.x;
		((UIScreen)facebookRewardsPopup)._footerInited = (byte)(int)modelScale.z != 0;
		facebookRewardsPopup._selectedFooterButton = (int)modelScale.x;
		((UIScreen)facebookRewardsPopup).addScreen = (byte)(int)modelRotation.z != 0;
		((UnityEngine.Object)facebookRewardsPopup).m_CachedPtr = (IntPtr)modelRotation.x;
		Vector3 offset = (Vector3)(facebookRewardsPopup + 40);
		Vector3 scale = (Vector3)(facebookRewardsPopup + 24);
		Vector3 rotation = (Vector3)(facebookRewardsPopup + 8);
		PlaceModel(modelHost, ref containerModel, offset, scale, rotation);
		containerAnchor.pixelOffset = (Vector2)pixelOffset.x;
	}

	private void SetupContainer5(Vector2 rewardSize, Vector2 pixelOffset, Vector3 positionOffset, Vector3 rotationOffset, Vector3 characterScale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got F4
		//IL_0059: Expected Obj, but got F4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected VT, but got Unknown
		//IL_009d: Expected Obj, but got F4
		//IL_00af: Expected I4, but got F4
		//IL_00c1: Expected I4, but got F4
		//IL_00d3: Expected I4, but got F4
		//IL_00e5: Expected I, but got F4
		//IL_00f2: Expected Obj, but got F4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected VT, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected VT, but got Unknown
		//IL_0120: Expected VT, but got Obj
		//IL_013c: Expected VT, but got F4
		object obj = default;
		FacebookRewardsPopup facebookRewardsPopup = (FacebookRewardsPopup)(obj + -64);
		GameObject gameObject = container5Anchor.gameObject;
		gameObject.SetActive(value: true);
		container5Line1.text = string.Empty;
		string text = Strings.Get(StringID.FACEBOOK_REWARD_POPUP_CHARACTER_LINE_2);
		container5Line2.text = text;
		((UIScreen)facebookRewardsPopup).parentScreen__BackingField = (string)rewardSize.x;
		facebookRewardsPopup.subtitle = (UILabel)rewardSize.x;
		Vector2 newSize = (Vector2)(facebookRewardsPopup + 48);
		facebookRewardsPopup.ResizeReward(container5Bg, container5Glow, container5Rays, newSize);
		facebookRewardsPopup.InComplete = (UnityEvent)positionOffset.z;
		((UIScreen)facebookRewardsPopup)._footerInited = (byte)(int)positionOffset.x != 0;
		facebookRewardsPopup._selectedFooterButton = (int)rotationOffset.z;
		((UIScreen)facebookRewardsPopup).addScreen = (byte)(int)rotationOffset.x != 0;
		((UnityEngine.Object)facebookRewardsPopup).m_CachedPtr = (IntPtr)characterScale.z;
		facebookRewardsPopup = (FacebookRewardsPopup)characterScale.x;
		Vector3 positionOffset2 = (Vector3)(facebookRewardsPopup + 32);
		Vector3 rotationOffset2 = (Vector3)(facebookRewardsPopup + 16);
		SetupCharacterModel(positionOffset2, rotationOffset2, (Vector3)facebookRewardsPopup);
		UIAnchor uIAnchor = container5Anchor;
		uIAnchor.pixelOffset = (Vector2)pixelOffset.x;
	}

	private void SetupCharacterModel(Vector3 positionOffset, Vector3 rotationOffset, Vector3 characterScale)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_ = positionOffset.z;
		_ = positionOffset.x;
		_ = characterScale.x;
		_ = characterScale.z;
		_ = rotationOffset.x;
		_ = rotationOffset.z;
		CharacterModelPreviewFactory instance = CharacterModelPreviewFactory.Instance;
		_ = -1;
		obj = (Enum)(object)typeof(Characters.CharacterType);
		_ = FacebookRewardsInfo.awardedCharacter;
		string text = obj.ToString();
		throw new ArgumentException();
	}

	private unsafe GameObject PlaceModelUnderAnchor(GameObject model, Transform anchor, int layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0064: Expected I, but got Obj
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected VT, but got Unknown
		//IL_00dc: Expected I, but got Obj
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected VT, but got Unknown
		//IL_0154: Expected I, but got Obj
		//IL_0179: Expected F4, but got I
		//IL_0174: Expected native int or pointer, but got VT
		//IL_0187: Expected F4, but got VT
		//IL_0182: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		NGUITools.SetLayer(model, layer);
		Transform transform = model.transform;
		transform.parent = anchor;
		Transform transform2 = model.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform2.localPosition = localPosition;
		Transform transform3 = model.transform;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v35 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 localEulerAngles = vector + 16;
		transform3.localEulerAngles = localEulerAngles;
		Transform transform4 = model.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
		return model;
	}

	private void DisableContainer(UIAnchor containerAnchor, GameObject containerModel)
	{
		GameObject gameObject = containerAnchor.gameObject;
		gameObject.SetActive(value: false);
		if (containerModel != null)
		{
			containerModel.SetActive(value: false);
		}
	}

	private void ResizePopup(int width, int height)
	{
		outline.width = width;
		outline.height = height;
		int width2 = width - 11;
		background.width = width2;
		int height2 = height - 11;
		background.height = height2;
	}

	private void ResizeReward(UISprite bg, UISprite glow, UISprite[] rays, Vector2 newSize)
	{
		//IL_004b: Expected I4, but got F4
		//IL_006b: Expected I4, but got F4
		//IL_008b: Expected I4, but got F4
		//IL_024f: Expected Obj, but got I4
		//IL_00ab: Expected I4, but got F4
		//IL_0132: Expected F8, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected I4, but got Unknown
		//IL_0277: Expected Obj, but got I
		//IL_0152: Expected F8, but got I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected I4, but got Unknown
		//IL_02d8: Expected Obj, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		double num = Math.Abs((double)newSize.x);
		int width = ((!(num < 2147483648.0)) ? int.MinValue : ((int)newSize.x));
		bg.width = width;
		double num2 = Math.Abs((double)newSize.y);
		int height = ((!(num2 < 2147483648.0)) ? int.MinValue : ((int)newSize.y));
		bg.height = height;
		double num3 = Math.Abs((double)newSize.x);
		int width2 = ((!(num3 < 2147483648.0)) ? int.MinValue : ((int)newSize.x));
		glow.width = width2;
		double num4 = Math.Abs((double)newSize.y);
		int height2 = ((!(num4 < 2147483648.0)) ? int.MinValue : ((int)newSize.y));
		glow.height = height2;
		object obj = 0;
		while (rays.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)rays + obj2;
			double num5 = Math.Abs((double)newSize.y);
			double num6 = ((!(num5 < 2147483648.0)) ? (-2147483648.0) : ((double)newSize.y));
			int width3 = (int)(num6 / 2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v11+10]");
			((UIWidget)0).width = width3;
			double num7 = Math.Abs((double)newSize.x);
			double num8 = ((!(num7 < 2147483648.0)) ? (-2147483648.0) : ((double)newSize.x));
			int height3 = (int)(num8 / 2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v11+10]");
			((UIWidget)0).height = height3;
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	private void InitTitles(bool isLoggedIn)
	{
		StringID key = StringID.FACEBOOK_REWARDS_POPUP_TITLE_LOGGED_IN;
		if (!isLoggedIn)
		{
			key = StringID.FACEBOOK_REWARDS_POPUP_TITLE_NOT_LOGGED_IN;
		}
		string text = Strings.Get(key);
		title.text = text;
		StringID key2 = StringID.FACEBOOK_REWARDS_POPUP_SUBTITLE_LOGGED_IN;
		if (!isLoggedIn)
		{
			key2 = StringID.FACEBOOK_REWARDS_POPUP_SUBTITLE_NOT_LOGGED_IN;
		}
		string text2 = Strings.Get(key2);
		subtitle.text = text2;
	}

	private void InitButtons(bool isLoggedIn)
	{
		string text = Strings.Get(StringID.FACEBOOK_REWARDS_POPUP_CONNECT_BUTTON_TEXT);
		connectButtonLabel.text = text;
		string text2 = Strings.Get(StringID.FACEBOOK_REWARDS_POPUP_RETRIEVE_BUTTON_TEXT);
		retrieveButtonLabel.text = text2;
		bool active = (byte)((isLoggedIn ? 1u : 0u) ^ 1u) != 0;
		exitButton.SetActive(active);
		connectButton.SetActive(active);
		retrieveButton.SetActive(isLoggedIn);
	}

	private void InitCheckmarks(bool facebookLoggedIn)
	{
		GameObject gameObject = container1Check.gameObject;
		gameObject.SetActive(facebookLoggedIn);
		GameObject gameObject2 = container2Check.gameObject;
		gameObject2.SetActive(facebookLoggedIn);
		GameObject gameObject3 = container3Check.gameObject;
		gameObject3.SetActive(facebookLoggedIn);
		GameObject gameObject4 = container4Check.gameObject;
		gameObject4.SetActive(facebookLoggedIn);
		GameObject gameObject5 = container5Check.gameObject;
		gameObject5.SetActive(facebookLoggedIn);
	}

	public unsafe void PlaceModel(GameObject modelHost, ref GameObject modelToPosition, Vector3 offset, Vector3 scale, Vector3 rotation)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0043: Expected native int or pointer, but got VT
		//IL_0055: Expected native int or pointer, but got VT
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected VT, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		_ = offset.z;
		_ = offset.x;
		_ = scale.z;
		_ = scale.x;
		((Vector3*)(nint)vector)->z = rotation.z;
		((Vector3*)(nint)vector)->x = rotation.x;
		Vector3 offset2 = vector + 32;
		Vector3 scale2 = vector + 16;
		IEnumerator routine = DelayPositioning(modelHost, modelToPosition, offset2, scale2, vector);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator DelayPositioning(GameObject modelHost, GameObject modelToPosition, Vector3 offset, Vector3 scale, Vector3 rotation)
	{
		_ = 0;
		_ = offset.z;
		_ = offset.x;
		_ = scale.x;
		_ = scale.z;
		_ = rotation.x;
		_ = rotation.z;
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

	private void SetLayerRecursively(GameObject target, int layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		target.layer = layer;
		Transform transform = target.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		Transform transform2 = target.transform;
		IEnumerator enumerator = transform2.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_0269;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_01da;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_01da;
			IL_01da:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 != obj7;
			object obj8 = obj9;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0269;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj8 = obj10;
			break;
			IL_0269:
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			return;
		}
		_ = 0;
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public void OnConnectClicked()
	{
		SocialManager instance = SocialManager.instance;
		throw new ArgumentException();
	}

	public void OnRetrieveClicked()
	{
		DeliverRemainingFacebookRewards();
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}

	public void OnBackBtnClicked()
	{
		if (retrieveButton.activeSelf && retrieveButton.activeInHierarchy)
		{
			DeliverRemainingFacebookRewards();
		}
	}

	private void OnFacebookLoginResult(bool loggedIn)
	{
		if (!loggedIn)
		{
			UIScreenController instance = UIScreenController.Instance;
			UIScreenController.SlideIn slideIn = default;
			slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectFailed);
			instance.QueueSlideIn(slideIn);
		}
	}

	private void DeliverRemainingFacebookRewards()
	{
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_03fe: Expected I4, but got I8
		//IL_02a0: Expected I4, but got Obj
		PlayerInfo instance = PlayerInfo.Instance;
		if (~(instance._hasPayedOutFacebook ? 1u : 0u) != 0)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			int amountOfCoins = instance2.amountOfCoins;
			int num = FacebookRewardsInfo.facebookRewardPack.get_Item(FacebookRewardsInfo.FacebookRewardType.Coins);
			int amountOfCoins2 = num + amountOfCoins;
			instance2.amountOfCoins = amountOfCoins2;
			PlayerInfo instance3 = PlayerInfo.Instance;
			if (!instance3._hasPayedOutFacebook)
			{
				instance3._dirty = true;
				instance3._hasPayedOutFacebook = true;
			}
		}
		PlayerInfo instance4 = PlayerInfo.Instance;
		if (~(instance4._hasPayedOutFacebookPack ? 1u : 0u) != 0)
		{
			PlayerInfo instance5 = PlayerInfo.Instance;
			int amountOfKeys = instance5.amountOfKeys;
			int num2 = FacebookRewardsInfo.facebookRewardPack.get_Item(FacebookRewardsInfo.FacebookRewardType.Keys);
			int amountOfKeys2 = num2 + amountOfKeys;
			instance5.amountOfKeys = amountOfKeys2;
			PlayerInfo instance6 = PlayerInfo.Instance;
			int amount = FacebookRewardsInfo.facebookRewardPack.get_Item(FacebookRewardsInfo.FacebookRewardType.Hoverboards);
			instance6.IncreaseUpgradeAmount(PowerupType.hoverboard, amount);
			PlayerInfo instance7 = PlayerInfo.Instance;
			int amount2 = FacebookRewardsInfo.facebookRewardPack.get_Item(FacebookRewardsInfo.FacebookRewardType.Headstarts);
			instance7.IncreaseUpgradeAmount(PowerupType.headstart2000, amount2);
			PlayerInfo instance8 = PlayerInfo.Instance;
			if (!instance8._hasPayedOutFacebookPack)
			{
				instance8._dirty = true;
				instance8._hasPayedOutFacebookPack = true;
			}
		}
		if (~(FacebookRewardsInfo.isCharacterRewarded ? 1u : 0u) == 0)
		{
			PlayerInfo instance9 = PlayerInfo.Instance;
			if (!instance9._hasPayedOutFacebookCharacter)
			{
				Characters.Model model = Characters.characterData.get_Item(FacebookRewardsInfo.awardedCharacter);
				CharacterTheme themeForCharacter = CharacterThemes.GetThemeForCharacter(FacebookRewardsInfo.awardedCharacter, FacebookRewardsInfo.characterTheme);
				object obj = themeForCharacter + 8;
				object obj2 = model + 16;
				if (themeForCharacter == null)
				{
					obj = obj2;
				}
				CelebrationReward celebrationReward = default;
				celebrationReward._002Ector();
				celebrationReward.characterOutfitIndex = FacebookRewardsInfo.characterTheme;
				celebrationReward.characterType = FacebookRewardsInfo.awardedCharacter;
				celebrationReward.CelebrationRewardOrigin = CelebrationRewardOrigin.CharacterUnlock;
				RewardManager.AddRewardToUnlock(celebrationReward);
				PlayerInfo instance10 = PlayerInfo.Instance;
				if (themeForCharacter != null)
				{
					instance10.UnlockTheme(FacebookRewardsInfo.awardedCharacter, FacebookRewardsInfo.characterTheme);
				}
				else
				{
					instance10.CollectToken(FacebookRewardsInfo.awardedCharacter, (int)obj);
				}
				CharacterScreenManager instance11 = CharacterScreenManager.Instance;
				instance11.OnFacebookCharacterUnlocked();
				UIScreenController instance12 = UIScreenController.Instance;
				instance12.QueuePopupRightAfterCurrentActivePopup("CelebrationPopup");
				PlayerInfo instance13 = PlayerInfo.Instance;
				if (!instance13._hasPayedOutFacebookCharacter)
				{
					instance13._dirty = true;
					instance13._hasPayedOutFacebookCharacter = true;
				}
			}
		}
		PlayerInfo instance14 = PlayerInfo.Instance;
		instance14.SaveIfDirty();
	}

	private void ActivateStars(int set)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected I4, but got Unknown
		object obj = set - 1;
		bool flag = (nint)obj < 3;
		object obj2 = obj & 7;
		bool flag2 = obj2 == null;
		bool active = flag & flag2;
		stars1.SetActive(active);
		bool active2 = (byte)((obj & flag) ? 1 : 0) != 0;
		stars2.SetActive(active2);
		bool flag3 = (nint)obj2 == 2;
		bool active3 = flag & flag3;
		stars3.SetActive(active3);
	}

	public FacebookRewardsPopup()
	{
		//IL_000f: Expected VT, but got I8
		//IL_001e: Expected VT, but got I8
		//IL_002d: Expected VT, but got I8
		//IL_003c: Expected VT, but got I8
		//IL_004b: Expected VT, but got I8
		//IL_005a: Expected VT, but got I8
		//IL_0065: Expected VT, but got I4
		//IL_00ca: Expected VT, but got I8
		_ = 1096810496;
		_ = 4780571007712755712L;
		_ = -4490088828488384512L;
		_ = 1095761920;
		_ = -4465319029433171968L;
		_ = 0;
		_ = 1095761920;
		_ = -4485585227750047744L;
		_ = -4647714815446351872L;
		_ = 0;
		_ = 1088421888;
		_scale4 = (Vector3)4674736414298996736L;
		_ = 1100218368;
		base._002Ector();
	}
}
