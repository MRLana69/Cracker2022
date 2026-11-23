using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TopRun;
using UnityEngine;

public class TopRunPlayerCell : MonoBehaviour
{
	private sealed class _003CAnimateMedalSprite_003Ed__27(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite glowSprite;

		public UISprite medalSprite;

		public TopRunPlayerCell _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected VT, but got Unknown
			//IL_0128: Expected Obj, but got VT
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected Obj, but got Unknown
			//IL_015a: Expected Obj, but got VT
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected Obj, but got Unknown
			//IL_01af: Expected Obj, but got VT
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected Obj, but got Unknown
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Expected VT, but got Unknown
			//IL_022a: Expected F4, but got I
			//IL_022a: Expected F4, but got I
			//IL_022a: Expected Obj, but got I
			//IL_026e: Expected F4, but got I
			//IL_0269: Expected native int or pointer, but got VT
			//IL_0281: Expected native int or pointer, but got VT
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Expected VT, but got Unknown
			//IL_035a: Expected Obj, but got VT
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Expected Obj, but got Unknown
			//IL_0399: Expected Obj, but got VT
			//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ca: Expected Obj, but got Unknown
			//IL_03ee: Expected Obj, but got VT
			//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Expected Obj, but got Unknown
			//IL_0434: Unknown result type (might be due to invalid IL or missing references)
			//IL_0439: Expected VT, but got Unknown
			//IL_0442: Unknown result type (might be due to invalid IL or missing references)
			//IL_0447: Expected VT, but got Unknown
			object obj = default;
			Color color = (Color)(obj - 192);
			TopRunPlayerCell topRunPlayerCell = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state == 3)
						{
							_003C_003E1__state = -1;
							glowSprite.enabled = false;
						}
						bool result = default;
						return result;
					}
					_003C_003E1__state = -1;
					UISprite uISprite = glowSprite;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v61 (UISprite)+54]");
					_ = 0;
					_ = ((UIWidget)uISprite).mColor;
					object obj2 = EFFECT_INITIAL_COLOR >> 16;
					object obj3 = obj2 & 0xFF;
					float num = (float)obj3 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
					_ = 0;
					object obj4 = EFFECT_INITIAL_COLOR >> 24;
					float num2 = (float)obj4 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+68]");
					_ = 0;
					object obj5 = EFFECT_INITIAL_COLOR & 0xFF;
					float num3 = (float)obj5 / 255f;
					object obj6 = EFFECT_INITIAL_COLOR >> 8;
					object obj7 = obj6 & 0xFF;
					float num4 = (float)obj7 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+60]");
					_ = 0;
					Color color2 = color + 80;
					Color color3 = color - -64;
					IEnumerator routine = topRunPlayerCell.AnimateEffectColor(uISprite, color2, color3, 0.8f);
					Coroutine coroutine = topRunPlayerCell.StartCoroutine(routine);
					_003C_003E2__current = coroutine;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E1__state = -1;
				_ = 0.5f;
				object obj8 = default;
				_003C_003E2__current = obj8;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			glowSprite.enabled = true;
			Transform transform = glowSprite.transform;
			Transform transform2 = medalSprite.transform;
			Vector3 localPosition = transform2.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
			_ = 0;
			Vector3 localPosition2 = (Vector3)(color + 48);
			transform.localPosition = localPosition2;
			object obj9 = EFFECT_INITIAL_COLOR >> 16;
			object obj10 = obj9 & 0xFF;
			float num5 = (float)obj10 / 255f;
			object obj11 = EFFECT_INITIAL_COLOR >> 24;
			float num6 = (float)obj11 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
			_ = 0;
			object obj12 = EFFECT_INITIAL_COLOR & 0xFF;
			float num7 = (float)obj12 / 255f;
			object obj13 = EFFECT_INITIAL_COLOR >> 8;
			object obj14 = obj13 & 0xFF;
			float num8 = (float)obj14 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
			_ = 0;
			Color color4 = color + 32;
			glowSprite.color = color4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (TopRunPlayerCell)+30]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (TopRunPlayerCell)+48]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (TopRunPlayerCell)+4C]");
			AudioSource audioSource = NGUITools.PlaySound((AudioClip)num9, num10, 0f);
			UISprite uISprite2 = glowSprite;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v51 (UISprite)+54]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
			((Color*)(nint)color)->b = 0f;
			_ = ((UIWidget)uISprite2).mColor;
			((Color*)(nint)color)->r = 1f;
			Color color5 = color + 16;
			IEnumerator routine2 = topRunPlayerCell.AnimateEffectColor(uISprite2, color5, color, 3f);
			Coroutine coroutine2 = topRunPlayerCell.StartCoroutine(routine2);
			_003C_003E2__current = coroutine2;
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

	private sealed class _003CAnimateEffectColor_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TopRunPlayerCell _003C_003E4__this;

		public float speedFactor;

		public UISprite spriteToAnimate;

		public Color color1;

		public Color color2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_00fd: Expected Obj, but got VT
			//IL_018a: Expected Obj, but got I
			//IL_01cd: Expected Obj, but got I
			//IL_0210: Expected Obj, but got I
			//IL_0255: Expected F4, but got I
			//IL_0250: Expected native int or pointer, but got VT
			//IL_0274: Expected F4, but got I
			//IL_026f: Expected native int or pointer, but got VT
			object obj = default;
			Color color = (Color)(obj - 32);
			TopRunPlayerCell topRunPlayerCell = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (topRunPlayerCell._animationLerpFactor < 1f)
					{
						goto IL_00b1;
					}
				}
				goto IL_0147;
			}
			_003C_003E1__state = -1;
			topRunPlayerCell._animationLerpFactor = 0f;
			goto IL_00b1;
			IL_00b1:
			float deltaTime = Time.deltaTime;
			float num = deltaTime * speedFactor;
			float num2 = (topRunPlayerCell._animationLerpFactor += num);
			object obj2 = color2 - color1;
			float num3 = Math.Min(num2, 1f);
			bool flag = num2 < 0f;
			float num4 = 0f;
			if (!flag)
			{
				num4 = num3;
			}
			float num5 = (float)obj2 * num4;
			float num6 = (float)color1 + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell+<AnimateEffectColor>d__28)+30]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell+<AnimateEffectColor>d__28)+20]");
			object obj3 = num7 - 0;
			float num8 = (float)obj3 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell+<AnimateEffectColor>d__28)+20]");
			float num9 = 0f + num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell+<AnimateEffectColor>d__28)+38]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell+<AnimateEffectColor>d__28)+28]");
			object obj4 = num10 - 0;
			float num11 = (float)obj4 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell+<AnimateEffectColor>d__28)+28]");
			float num12 = 0f + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell+<AnimateEffectColor>d__28)+34]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell+<AnimateEffectColor>d__28)+24]");
			object obj5 = num13 - 0;
			float num14 = (float)obj5 * num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell+<AnimateEffectColor>d__28)+24]");
			float num15 = 0f + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
			((Color*)(nint)color)->b = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
			((Color*)(nint)color)->r = 0f;
			spriteToAnimate.color = color;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			goto IL_0147;
			IL_0147:
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

	private UITexture _picture;

	private UILabel _name;

	private UISprite _medal;

	private UISprite _glow;

	private UISprite _flag;

	private UISprite _shadow;

	private UILabel _score;

	private UISprite _background;

	private UISprite _competitorIcon;

	private AudioClip _medalAnimationSound;

	public Texture dummyImage;

	private bool isLocalUser;

	private IPlayer player;

	private bool useDarkColour;

	private int rank;

	private float soundVolume = 0.1f;

	private float soundPitch;

	private float _animationLerpFactor;

	private const int SCORE_SPACING = 10;

	private static readonly Color32 EFFECT_INITIAL_COLOR = (Color32)16777215;

	private const float MEDAL_ANIMATION_TIME_OFFSET = 0.5f;

	public void InitCell(IPlayer playerT, bool useDarkColourT, int rankT, bool isLocalUserT)
	{
		player = playerT;
		rank = rankT;
		useDarkColour = useDarkColourT;
		isLocalUser = isLocalUserT;
		Refresh();
	}

	public bool IsLocalUser()
	{
		return isLocalUser;
	}

	public unsafe void Refresh()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0539: Expected Obj, but got VT
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_056b: Expected Obj, but got VT
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05c0: Expected Obj, but got VT
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected Obj, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected VT, but got Unknown
		//IL_061c: Expected Obj, but got VT
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_064e: Expected Obj, but got VT
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected Obj, but got Unknown
		//IL_06a3: Expected Obj, but got VT
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected Obj, but got Unknown
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected VT, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected Obj, but got Unknown
		//IL_04f4: Expected Obj, but got I
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected VT, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_01b9: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected VT, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_06fd: Expected I, but got Obj
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected I4, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 144;
		_ = 0;
		_name.text = string.Empty;
		_medal.enabled = false;
		_flag.enabled = false;
		_shadow.enabled = false;
		_glow.enabled = false;
		if (TopRunRoot.manager__BackingField == null)
		{
			return;
		}
		SocialManager instance;
		Texture texture;
		if (~(isLocalUser ? 1u : 0u) == 0)
		{
			instance = SocialManager.instance;
			object obj3;
			if (instance._fbProfile != null)
			{
				obj3 = instance._fbProfile + 20;
			}
			else
			{
				bool flag = instance._gcProfile == null;
				texture = null;
				if (flag)
				{
					goto IL_04b0;
				}
				obj3 = instance._gcProfile + 20;
			}
			texture = (Texture)obj3;
			goto IL_04b0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj4 = default;
		Texture texture2;
		object obj5 = default;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			UILabel uILabel = _name;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v114+C]");
			uILabel.text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v116+14]");
			texture2 = (Texture)0;
			object obj6 = default;
			obj5 = obj6;
		}
		else
		{
			string text = Strings.Get(StringID.TOPRUN_ANONYMOUS_PLAYER_ALIAS);
			_name.text = text;
			texture2 = null;
		}
		object obj7 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR >> 16;
		object obj8 = obj7 & 0xFF;
		float num = (float)obj8 / 255f;
		object obj9 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR >> 24;
		float num2 = (float)obj9 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
		_ = 0;
		object obj10 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR & 0xFF;
		float num3 = (float)obj10 / 255f;
		object obj11 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR >> 8;
		object obj12 = obj11 & 0xFF;
		float num4 = (float)obj12 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Color color = (Color)(obj + 24);
		_name.color = color;
		object obj13 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR >> 16;
		object obj14 = obj13 & 0xFF;
		float num5 = (float)obj14 / 255f;
		object obj15 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR >> 24;
		float num6 = (float)obj15 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		object obj16 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR & 0xFF;
		float num7 = (float)obj16 / 255f;
		object obj17 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR >> 8;
		object obj18 = obj17 & 0xFF;
		float num8 = (float)obj18 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Color color2 = (Color)(obj + 8);
		_score.color = color2;
		goto IL_0202;
		IL_0202:
		if (obj5 != null && (~(isLocalUser ? 1u : 0u) != 0 || !TopRunRewardHelper.ShouldShowResults()))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			int num9 = default;
			string countryID = default;
			SetMedalForRank(num9, countryID);
		}
		if (~(isLocalUser ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj19 = default;
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj20 = default;
				if (obj20 != null && !TopRunRewardHelper.ShouldShowResults())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj21 = default;
					if ((nint)obj21 >= 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
						int num10 = default;
						SetMedalForRank(num10, string.Empty);
					}
				}
			}
		}
		UITexture picture = _picture;
		if ((object)texture2 != null)
		{
			Texture texture3 = texture2;
		}
		else
		{
			Texture texture3 = dummyImage;
		}
		nint num11 = (nint)picture;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ S2_v11 (Il2CppClass<UITexture>)+194] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int num12 = obj + 140;
		string text2 = ((int*)num12)->ToString();
		_score.text = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj22 = default;
		bool flag2 = (byte)(obj22 ^ 1) != 0;
		_competitorIcon.enabled = flag2;
		UILabel uILabel2 = _name;
		if (uILabel2.mOverflow != UILabel.Overflow.ResizeFreely)
		{
			uILabel2.mOverflow = UILabel.Overflow.ResizeFreely;
			((UIRect)uILabel2).mChanged = true;
			uILabel2.mShouldBeProcessed = true;
		}
		SetBackgroundColour(useDarkColour, rank);
		ResizeNameIfNeeded();
		return;
		IL_04b0:
		string localUserName = instance.localUserName;
		_name.text = localUserName;
		_ = 4575657222473777152L;
		object obj23 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
		obj23 = 0;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		Color color3 = (Color)(obj + 56);
		_name.color = color3;
		_ = 4575657222473777152L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		_ = 0;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		Color color4 = (Color)(obj + 40);
		_score.color = color4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		texture2 = texture;
		object obj24 = default;
		obj5 = obj24;
		goto IL_0202;
	}

	public void AnimateMedalIfNeeded()
	{
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I4
		if (TopRunRoot.manager__BackingField == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		if (obj == null || ~(isLocalUser ? 1u : 0u) != 0 || !_medal.enabled)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj2 = default;
		if (obj2 == null || TopRunRewardHelper.ShouldShowResults())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			if (obj3 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj4 = default;
		int num = default;
		object obj5 = default;
		if (obj4 != null)
		{
			bool flag = ((TopRunPlayerCell)TopRunRoot.manager__BackingField).HasShownMedalForWeek(num);
			obj5 = (flag ? 1 : 0) ^ 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj6 = default;
		bool flag2 = obj6 == null;
		bool flag3 = false;
		if (!flag2)
		{
			bool flag4 = TopRunRewardHelper.ShouldShowResults();
			flag3 = false;
			if (!flag4)
			{
				int weekNumber = num + 1;
				bool flag5 = ((TopRunPlayerCell)TopRunRoot.manager__BackingField).HasShownMedalForWeek(weekNumber);
				flag3 = false;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					object obj7 = default;
					bool flag6 = (nint)obj7 > 0;
					flag3 = flag6;
				}
			}
		}
		object obj8 = flag3 | obj5;
		if (obj8 != null)
		{
			IEnumerator routine = AnimateMedalSprite(_glow, _medal, isThisWeeksResult: false);
			Coroutine coroutine = StartCoroutine(routine);
			int num2 = num + 1;
			if (!flag3)
			{
				num2 = num;
			}
			PlayerInfo instance = PlayerInfo.Instance;
			if (num2 != instance._lastWeekMedalWasShown)
			{
				instance._dirty = true;
				instance._lastWeekMedalWasShown = num2;
			}
		}
	}

	private bool HasShownMedalForWeek(int weekNumber)
	{
		PlayerInfo instance = PlayerInfo.Instance;
		return instance._lastWeekMedalWasShown >= weekNumber;
	}

	private void SetMedalForRank(int rank, string countryID)
	{
		//IL_003c: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		Country countryForID = CountryData.GetCountryForID(countryID);
		bool flag = countryForID == null;
		string text = null;
		if (!flag)
		{
			text = countryForID.flag__BackingField;
		}
		object obj;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_02ac;
			}
		}
		obj = 1;
		goto IL_02ac;
		IL_02ac:
		if (rank <= 3 && obj == null)
		{
			_flag.spriteName = text;
			if (TopRunRoot.manager__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj2 = default;
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
					string text3 = default;
					string text2 = text3.ToLower();
					string text4 = countryID.ToLower();
					bool flag2 = text2 == text4;
					bool flag3 = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
					_flag.enabled = flag3;
					_shadow.enabled = flag3;
				}
			}
		}
		_medal.enabled = true;
		switch (rank)
		{
		case 0:
			_medal.spriteName = "icon_diamond_medal";
			_glow.spriteName = "icon_diamond_medal_glow";
			break;
		case 1:
			_medal.spriteName = "icon_gold_medal";
			_glow.spriteName = "icon_gold_medal_glow";
			break;
		case 2:
			_medal.spriteName = "icon_silver_medal";
			_glow.spriteName = "icon_silver_medal_glow";
			break;
		case 3:
			_medal.spriteName = "icon_bronze_medal";
			_glow.spriteName = "icon_bronze_medal_glow";
			break;
		default:
			_medal.enabled = false;
			_shadow.enabled = false;
			_flag.enabled = false;
			break;
		}
	}

	private IEnumerator AnimateMedalSprite(UISprite glowSprite, UISprite medalSprite, bool isThisWeeksResult)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateEffectColor(UISprite spriteToAnimate, Color color1, Color color2, float speedFactor = 1f)
	{
		_ = 0;
		_ = color1.b;
		_ = color1.r;
		_ = color2.r;
		_ = color2.b;
		IEnumerator result = default;
		return result;
	}

	private unsafe void SetBackgroundColour(bool useDark, int rank)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_010e: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got VT
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got VT
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got VT
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected VT, but got Unknown
		//IL_0345: Expected Obj, but got VT
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_0377: Expected Obj, but got VT
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_03cc: Expected Obj, but got VT
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected Obj, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected VT, but got Unknown
		//IL_025d: Expected Obj, but got VT
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_028f: Expected Obj, but got VT
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02e4: Expected Obj, but got VT
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected VT, but got Unknown
		//IL_052e: Expected Obj, but got VT
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_0560: Expected Obj, but got VT
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected Obj, but got Unknown
		//IL_05b5: Expected Obj, but got VT
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected Obj, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected VT, but got Unknown
		//IL_0446: Expected Obj, but got VT
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_0478: Expected Obj, but got VT
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04cd: Expected Obj, but got VT
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected VT, but got Unknown
		//IL_0717: Expected Obj, but got VT
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_0749: Expected Obj, but got VT
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected Obj, but got Unknown
		//IL_079e: Expected Obj, but got VT
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected Obj, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected VT, but got Unknown
		//IL_062f: Expected Obj, but got VT
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected Obj, but got Unknown
		//IL_0661: Expected Obj, but got VT
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected Obj, but got Unknown
		//IL_06b6: Expected Obj, but got VT
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected VT, but got Unknown
		//IL_0900: Expected Obj, but got VT
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Expected Obj, but got Unknown
		//IL_0932: Expected Obj, but got VT
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got Unknown
		//IL_0987: Expected Obj, but got VT
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected Obj, but got Unknown
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected VT, but got Unknown
		//IL_0818: Expected Obj, but got VT
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Expected Obj, but got Unknown
		//IL_084a: Expected Obj, but got VT
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected Obj, but got Unknown
		//IL_089f: Expected Obj, but got VT
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected Obj, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected VT, but got Unknown
		//IL_0ae9: Expected Obj, but got VT
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected Obj, but got Unknown
		//IL_0b1b: Expected Obj, but got VT
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected Obj, but got Unknown
		//IL_0b70: Expected Obj, but got VT
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected Obj, but got Unknown
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Expected VT, but got Unknown
		//IL_0a01: Expected Obj, but got VT
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Expected Obj, but got Unknown
		//IL_0a33: Expected Obj, but got VT
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected Obj, but got Unknown
		//IL_0a88: Expected Obj, but got VT
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Expected Obj, but got Unknown
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected VT, but got Unknown
		//IL_0bd1: Expected Obj, but got VT
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected Obj, but got Unknown
		//IL_0c03: Expected Obj, but got VT
		//IL_0c2d: Expected F4, but got I
		//IL_0c28: Expected native int or pointer, but got VT
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3c: Expected Obj, but got Unknown
		//IL_0c60: Expected Obj, but got VT
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Expected Obj, but got Unknown
		//IL_0c98: Expected F4, but got I
		//IL_0c93: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 384);
		if (~(isLocalUser ? 1u : 0u) == 0)
		{
			object obj2 = GlobalColors.TOPRUN_ME_PLAYER_BACKGROUND_COLOUR >> 16;
			object obj3 = obj2 & 0xFF;
			float num = (float)obj3 / 255f;
			object obj4 = GlobalColors.TOPRUN_ME_PLAYER_BACKGROUND_COLOUR >> 24;
			float num2 = (float)obj4 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+178]");
			_ = 0;
			object obj5 = GlobalColors.TOPRUN_ME_PLAYER_BACKGROUND_COLOUR & 0xFF;
			float num3 = (float)obj5 / 255f;
			object obj6 = GlobalColors.TOPRUN_ME_PLAYER_BACKGROUND_COLOUR >> 8;
			object obj7 = obj6 & 0xFF;
			float num4 = (float)obj7 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+170]");
			_ = 0;
			Color color2 = color + 176;
			_background.color = color2;
			return;
		}
		object obj8 = rank - 1;
		if (rank != 1)
		{
			if ((nint)obj8 != 1)
			{
				if ((nint)obj8 != 2)
				{
					if ((nint)obj8 != 3)
					{
						if ((nint)obj8 == 4 || (nint)obj8 == 5 || (nint)obj8 == 6 || (nint)obj8 == 7 || (nint)obj8 == 8 || (nint)obj8 == 9)
						{
							if (useDark)
							{
								object obj9 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 16;
								object obj10 = obj9 & 0xFF;
								float num5 = (float)obj10 / 255f;
								object obj11 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 24;
								float num6 = (float)obj11 / 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E8]");
								_ = 0;
								object obj12 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR & 0xFF;
								float num7 = (float)obj12 / 255f;
								object obj13 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 8;
								object obj14 = obj13 & 0xFF;
								float num8 = (float)obj14 / 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
								_ = 0;
								Color color3 = color + 144;
								_background.color = color3;
							}
							else
							{
								object obj15 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_LIGHT_COLOUR >> 16;
								object obj16 = obj15 & 0xFF;
								float num9 = (float)obj16 / 255f;
								object obj17 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_LIGHT_COLOUR >> 24;
								float num10 = (float)obj17 / 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D8]");
								_ = 0;
								object obj18 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_LIGHT_COLOUR & 0xFF;
								float num11 = (float)obj18 / 255f;
								object obj19 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_LIGHT_COLOUR >> 8;
								object obj20 = obj19 & 0xFF;
								float num12 = (float)obj20 / 255f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
								_ = 0;
								Color color4 = color + 160;
								_background.color = color4;
							}
						}
						else
						{
							object obj21 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 16;
							object obj22 = obj21 & 0xFF;
							float num13 = (float)obj22 / 255f;
							object obj23 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 24;
							float num14 = (float)obj23 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
							((Color*)(nint)color)->b = 0f;
							object obj24 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR & 0xFF;
							float num15 = (float)obj24 / 255f;
							object obj25 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR >> 8;
							object obj26 = obj25 & 0xFF;
							float num16 = (float)obj26 / 255f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
							((Color*)(nint)color)->r = 0f;
							_background.color = color;
						}
					}
					else if (useDark)
					{
						object obj27 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR >> 16;
						object obj28 = obj27 & 0xFF;
						float num17 = (float)obj28 / 255f;
						object obj29 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR >> 24;
						float num18 = (float)obj29 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+108]");
						_ = 0;
						object obj30 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR & 0xFF;
						float num19 = (float)obj30 / 255f;
						object obj31 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR >> 8;
						object obj32 = obj31 & 0xFF;
						float num20 = (float)obj32 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+100]");
						_ = 0;
						Color color5 = color + 112;
						_background.color = color5;
					}
					else
					{
						object obj33 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_LIGHT_COLOUR >> 16;
						object obj34 = obj33 & 0xFF;
						float num21 = (float)obj34 / 255f;
						object obj35 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_LIGHT_COLOUR >> 24;
						float num22 = (float)obj35 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F8]");
						_ = 0;
						object obj36 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_LIGHT_COLOUR & 0xFF;
						float num23 = (float)obj36 / 255f;
						object obj37 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_LIGHT_COLOUR >> 8;
						object obj38 = obj37 & 0xFF;
						float num24 = (float)obj38 / 255f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F0]");
						_ = 0;
						Color color6 = color + 128;
						_background.color = color6;
					}
				}
				else if (useDark)
				{
					object obj39 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR >> 16;
					object obj40 = obj39 & 0xFF;
					float num25 = (float)obj40 / 255f;
					object obj41 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR >> 24;
					float num26 = (float)obj41 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+128]");
					_ = 0;
					object obj42 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR & 0xFF;
					float num27 = (float)obj42 / 255f;
					object obj43 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR >> 8;
					object obj44 = obj43 & 0xFF;
					float num28 = (float)obj44 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+120]");
					_ = 0;
					Color color7 = color + 80;
					_background.color = color7;
				}
				else
				{
					object obj45 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_LIGHT_COLOUR >> 16;
					object obj46 = obj45 & 0xFF;
					float num29 = (float)obj46 / 255f;
					object obj47 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_LIGHT_COLOUR >> 24;
					float num30 = (float)obj47 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+118]");
					_ = 0;
					object obj48 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_LIGHT_COLOUR & 0xFF;
					float num31 = (float)obj48 / 255f;
					object obj49 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_LIGHT_COLOUR >> 8;
					object obj50 = obj49 & 0xFF;
					float num32 = (float)obj50 / 255f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+110]");
					_ = 0;
					Color color8 = color + 96;
					_background.color = color8;
				}
			}
			else if (useDark)
			{
				object obj51 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR >> 16;
				object obj52 = obj51 & 0xFF;
				float num33 = (float)obj52 / 255f;
				object obj53 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR >> 24;
				float num34 = (float)obj53 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
				_ = 0;
				object obj54 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR & 0xFF;
				float num35 = (float)obj54 / 255f;
				object obj55 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR >> 8;
				object obj56 = obj55 & 0xFF;
				float num36 = (float)obj56 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+140]");
				_ = 0;
				Color color9 = color + 48;
				_background.color = color9;
			}
			else
			{
				object obj57 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_LIGHT_COLOUR >> 16;
				object obj58 = obj57 & 0xFF;
				float num37 = (float)obj58 / 255f;
				object obj59 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_LIGHT_COLOUR >> 24;
				float num38 = (float)obj59 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+138]");
				_ = 0;
				object obj60 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_LIGHT_COLOUR & 0xFF;
				float num39 = (float)obj60 / 255f;
				object obj61 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_LIGHT_COLOUR >> 8;
				object obj62 = obj61 & 0xFF;
				float num40 = (float)obj62 / 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+130]");
				_ = 0;
				Color color10 = color - -64;
				_background.color = color10;
			}
		}
		else if (useDark)
		{
			object obj63 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR >> 16;
			object obj64 = obj63 & 0xFF;
			float num41 = (float)obj64 / 255f;
			object obj65 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR >> 24;
			float num42 = (float)obj65 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+168]");
			_ = 0;
			object obj66 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR & 0xFF;
			float num43 = (float)obj66 / 255f;
			object obj67 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR >> 8;
			object obj68 = obj67 & 0xFF;
			float num44 = (float)obj68 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+160]");
			_ = 0;
			Color color11 = color + 16;
			_background.color = color11;
		}
		else
		{
			object obj69 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_LIGHT_COLOUR >> 16;
			object obj70 = obj69 & 0xFF;
			float num45 = (float)obj70 / 255f;
			object obj71 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_LIGHT_COLOUR >> 24;
			float num46 = (float)obj71 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+158]");
			_ = 0;
			object obj72 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_LIGHT_COLOUR & 0xFF;
			float num47 = (float)obj72 / 255f;
			object obj73 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_LIGHT_COLOUR >> 8;
			object obj74 = obj73 & 0xFF;
			float num48 = (float)obj74 / 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+150]");
			_ = 0;
			Color color12 = color + 32;
			_background.color = color12;
		}
	}

	private void ResizeNameIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d8: Invalid comparison between F4 and Obj
		//IL_019d: Expected F8, but got I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = _score.transform;
		Vector3 localPosition = transform.localPosition;
		UILabel score = _score;
		object obj3 = obj - ((UIWidget)score).mWidth;
		Transform transform2 = _name.transform;
		Vector3 localPosition2 = transform2.localPosition;
		float num = (float)obj3 - 10f;
		UILabel uILabel = _name;
		object obj4 = obj + ((UIWidget)uILabel).mWidth;
		UISprite medal = _medal;
		object obj5 = obj4 + ((UIWidget)medal).mWidth;
		UISprite flag = _flag;
		object obj6 = obj5 + ((UIWidget)flag).mWidth;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			UILabel uILabel2 = _name;
			if (uILabel2.mOverflow != UILabel.Overflow.ClampContent)
			{
				uILabel2.mOverflow = UILabel.Overflow.ClampContent;
				((UIRect)uILabel2).mChanged = true;
				uILabel2.mShouldBeProcessed = true;
			}
			UILabel uILabel3 = _name;
			float num2 = (float)obj6 - num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num4 = default;
			double num3 = Math.Abs(num4);
			if (!(num3 < 2147483648.0))
			{
				num4 = -2147483648.0;
			}
			int width = (int)(((UIWidget)uILabel3).mWidth - num4);
			uILabel3.width = width;
			string processedText = _name.processedText;
			_name.text = processedText;
			UILabel uILabel4 = _name;
			if (uILabel4.mOverflow != UILabel.Overflow.ResizeFreely)
			{
				uILabel4.mOverflow = UILabel.Overflow.ResizeFreely;
				((UIRect)uILabel4).mChanged = true;
				uILabel4.mShouldBeProcessed = true;
			}
		}
	}

	static TopRunPlayerCell()
	{
		//IL_000f: Expected VT, but got I4
	}
}
