using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using TopRun;
using UI.Screens.RewardManagement;
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

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_034d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0352: Expected Obj, but got Unknown
				//IL_035b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0360: Expected VT, but got Unknown
				//IL_0369: Unknown result type (might be due to invalid IL or missing references)
				//IL_036e: Expected Obj, but got Unknown
				//IL_0377: Unknown result type (might be due to invalid IL or missing references)
				//IL_037c: Expected Obj, but got Unknown
				//IL_0385: Unknown result type (might be due to invalid IL or missing references)
				//IL_038a: Expected Obj, but got Unknown
				//IL_0393: Unknown result type (might be due to invalid IL or missing references)
				//IL_0398: Expected Obj, but got Unknown
				//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a6: Expected Obj, but got Unknown
				//IL_03af: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b4: Expected Obj, but got Unknown
				//IL_0082: Expected Obj, but got I4
				//IL_00b2: Expected VT, but got Obj
				//IL_00ec: Expected I, but got Obj
				//IL_0102: Expected Obj, but got I
				//IL_020c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0211: Expected Obj, but got Unknown
				//IL_022d: Expected Obj, but got I4
				//IL_03e6: Expected Obj, but got VT
				//IL_03ff: Expected VT, but got Obj
				//IL_042f: Expected I4, but got Obj
				//IL_043d: Expected I, but got Obj
				//IL_0453: Expected Obj, but got I
				//IL_0499: Expected F4, but got I
				//IL_0499: Expected F4, but got I
				//IL_0499: Expected Obj, but got I
				//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ad: Expected Obj, but got Unknown
				//IL_04d8: Expected I4, but got Obj
				//IL_04d3: Expected native int or pointer, but got VT
				//IL_0508: Unknown result type (might be due to invalid IL or missing references)
				//IL_050d: Expected Obj, but got Unknown
				//IL_0529: Expected VT, but got Obj
				//IL_012d: Expected I, but got Obj
				//IL_0248: Unknown result type (might be due to invalid IL or missing references)
				//IL_024d: Expected Obj, but got Unknown
				//IL_0278: Expected I, but got Obj
				//IL_028e: Expected Obj, but got I
				//IL_01e6: Expected Obj, but got I4
				//IL_017a: Expected I, but got Obj
				//IL_0540: Expected Obj, but got VT
				//IL_0559: Expected VT, but got Obj
				//IL_056a: Expected I4, but got Obj
				//IL_0565: Expected native int or pointer, but got VT
				//IL_0597: Unknown result type (might be due to invalid IL or missing references)
				//IL_059c: Expected Obj, but got Unknown
				//IL_05b8: Expected VT, but got Obj
				//IL_0314: Expected Obj, but got I4
				//IL_02b9: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 96);
				Color32 color = (Color32)(obj + 80);
				Transform transform2 = (Transform)(obj + 56);
				object obj2 = obj + 48;
				object obj3 = obj + 32;
				object obj4 = obj + 72;
				object obj5 = obj + 16;
				object obj6 = obj + 52;
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
								glowSprite.tag = null;
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						object obj7 = glowSprite + 80;
						transform2 = (Transform)obj7;
						Transform transform3 = transform2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v67+8]");
						((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
						nint num = (nint)typeof(TopRunPlayerCell);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v67 (Il2CppClass<TopRunPlayerCell>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num2 = (nint)typeof(TopRunPlayerCell);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v83 (Il2CppClass<TopRunPlayerCell>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj2 = EFFECT_INITIAL_COLOR;
						obj6 = obj2;
						transform = (Transform)obj6;
						Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)transform);
						((Color32*)(nint)color)->rgba = (int)transform2;
						_ = ((UnityEngine.Object)transform2).m_CachedPtr;
						transform = (Transform)obj3;
						Transform transform4 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
						object obj9 = this + 12;
						IEnumerator routine = ((IngameScreen)(object)topRunPlayerCell).AnimateSpriteColor(glowSprite, color, (Color32)transform, 0.8f);
						Coroutine coroutine = topRunPlayerCell.StartCoroutine_Auto(routine);
						obj9 = coroutine;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 0.5f;
					object obj10 = this + 12;
					object obj11 = default;
					obj10 = obj11;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				glowSprite.tag = (string)1;
				GameObject gameObject = glowSprite.gameObject;
				GameObject gameObject2 = medalSprite.gameObject;
				transform2.localPosition = (Vector3)gameObject2;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				Vector3 eulerAngles = transform.eulerAngles;
				nint num3 = (nint)typeof(TopRunPlayerCell);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v21 (Il2CppClass<TopRunPlayerCell>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num4 = (nint)typeof(TopRunPlayerCell);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v53 (Il2CppClass<TopRunPlayerCell>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = EFFECT_INITIAL_COLOR;
				obj4 = obj2;
				transform = (Transform)obj4;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)transform);
				transform = (Transform)obj3;
				Transform transform5 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				glowSprite.rawPivot = (UIWidget.Pivot)transform;
				nint num5 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S3_v6 (Il2CppClass<NGUITools>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num6 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S3_v13 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (TopRunPlayerCell)+30]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (TopRunPlayerCell)+48]");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (TopRunPlayerCell)+4C]");
				TweenFill tweenFill = TweenFill.Begin((GameObject)num7, num8, 0f);
				object obj14 = glowSprite + 80;
				obj5 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S1_v36+8]");
				_ = 0;
				Color black = Color.black;
				((Color32*)(nint)color)->rgba = (int)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
				_ = 0;
				transform = (Transform)obj;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				object obj15 = this + 12;
				IEnumerator routine2 = ((IngameScreen)(object)topRunPlayerCell).AnimateSpriteColor(glowSprite, color, (Color32)transform, 3f);
				Coroutine coroutine2 = topRunPlayerCell.StartCoroutine_Auto(routine2);
				obj15 = coroutine2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

	private sealed class _003CAnimateEffectColor_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TopRunPlayerCell _003C_003E4__this;

		public float speedFactor;

		public UISprite spriteToAnimate;

		public Color color1;

		public Color color2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected I4, but got Unknown
				//IL_0017: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected I4, but got Unknown
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Expected Obj, but got Unknown
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected Obj, but got Unknown
				//IL_012b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Expected Obj, but got Unknown
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0150: Expected Obj, but got Unknown
				//IL_0172: Expected I4, but got Obj
				//IL_018c: Expected I4, but got Obj
				//IL_01b3: Expected Ref, but got VT
				//IL_01ca: Expected I4, but got F4
				//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ee: Expected Obj, but got Unknown
				//IL_01f7: Expected Obj, but got I4
				//IL_020b: Expected Obj, but got I4
				Matrix4x4 matrix4x = default;
				int num = matrix4x - -64;
				int num2 = matrix4x + 48;
				object obj = matrix4x + 32;
				object obj2 = matrix4x + 16;
				TopRunPlayerCell topRunPlayerCell = _003C_003E4__this;
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
					topRunPlayerCell._animationLerpFactor = 0f;
				}
				if (topRunPlayerCell._animationLerpFactor < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num3 = unscaledTime * speedFactor;
					float animationLerpFactor = topRunPlayerCell._animationLerpFactor + num3;
					topRunPlayerCell._animationLerpFactor = animationLerpFactor;
					object obj3 = this + 28;
					obj = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S2_v6+8]");
					_ = 0;
					object obj4 = this + 44;
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v11+8]");
					_ = 0;
					((int*)num2)->m_value = (int)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
					_ = 0;
					((int*)num)->m_value = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
					_ = 0;
					((Matrix4x4*)matrix4x)->set_Item(num2, num, topRunPlayerCell._animationLerpFactor);
					((int*)num)->m_value = (int)matrix4x.m00;
					_ = matrix4x.m20;
					spriteToAnimate.rawPivot = (UIWidget.Pivot)num;
					object obj5 = this + 12;
					obj5 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

	private float soundVolume;

	private float soundPitch;

	private float _animationLerpFactor;

	private const int SCORE_SPACING = 10;

	private static readonly Color32 EFFECT_INITIAL_COLOR;

	private const float MEDAL_ANIMATION_TIME_OFFSET = 0.5f;

	public void InitCell(IPlayer playerT, bool useDarkColourT, int rankT, bool isLocalUserT)
	{
		//IL_00f9: Expected Obj, but got I4
		//IL_00f9: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00a9: Expected Obj, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I4
		((CaptureScreenshot)(object)this)._002Ector((string)(object)playerT, (string)useDarkColourT, rankT, isLocalUserT ? 1 : 0, (Camera)8);
		TouchScreenKeyboard.Internal_Destroy((IntPtr)60);
		string[] directories = Directory.GetDirectories((string)(object)playerT);
		object obj = directories + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = directories + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((FileStream)obj5).ExposeHandle();
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
		object obj7 = this + 32;
		obj7 = stream;
		UnityEngine.Object.CheckNullArgument((object)_shadow, (string)61);
		NewMonoBehaviour newMonoBehaviour = ((GameObject)(object)_shadow).AddComponent<NewMonoBehaviour>();
		int width = ((InGameCaptureWrapper)this).Width;
		Coroutine coroutine = newMonoBehaviour.StartCoroutine_Auto((IEnumerator)width);
	}

	public bool IsLocalUser()
	{
		//IL_00f6: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell)+60]");
		bool result;
		if ((nint)0 != 0)
		{
			result = true;
			int num2 = default;
			int num3 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell)+60]");
				object obj = 0;
				int num = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5+C]");
				if ((nint)num >= (nint)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell)+60]");
				TopRunCell topRunCell = ((List<TopRunCell>)0).get_Item(num2);
				if (topRunCell.cellType == TopRunCellType.PLAYER)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunPlayerCell)+60]");
					TopRunCell topRunCell2 = ((List<TopRunCell>)0).get_Item(num2);
					if (~(topRunCell2.isLocalUser ? 1u : 0u) == 0)
					{
						result = (byte)num2 != 0;
					}
				}
				num2 = num3 + 1;
			}
		}
		else
		{
			result = true;
		}
		return result;
	}

	public void Refresh()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		_ = 2;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<TopRunCell> list = default;
		list._002Ector();
		object obj = this + 96;
		obj = list;
		CancelInvoke();
	}

	public unsafe void AnimateMedalIfNeeded()
	{
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected I4, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected Obj, but got Unknown
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected Obj, but got Unknown
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected Obj, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got Unknown
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected Obj, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected Obj, but got Unknown
		//IL_0712: Expected Obj, but got I4
		//IL_0722: Expected I4, but got Obj
		//IL_0288: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_07f5: Expected I4, but got Obj
		//IL_07fe: Expected Obj, but got I4
		//IL_07a5: Expected I, but got Obj
		//IL_07bb: Expected Obj, but got I
		//IL_02c9: Expected I, but got Obj
		//IL_00b1: Expected I, but got Obj
		//IL_08aa: Expected Obj, but got VT
		//IL_08bf: Expected I4, but got Obj
		//IL_08c8: Expected VT, but got I4
		//IL_08d9: Expected I4, but got Obj
		//IL_08fe: Expected Obj, but got VT
		//IL_0913: Expected I4, but got Obj
		//IL_091c: Expected VT, but got I4
		//IL_0275: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0362: Expected I4, but got Obj
		//IL_0316: Expected I, but got Obj
		//IL_0776: Expected Obj, but got I4
		//IL_014a: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_0176: Expected I4, but got Obj
		//IL_01ad: Expected I4, but got Obj
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected Obj, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_0896: Expected Obj, but got I4
		//IL_03e0: Expected I, but got Obj
		//IL_03f6: Expected Obj, but got I
		//IL_04f7: Expected I, but got Obj
		//IL_050d: Expected Obj, but got I
		//IL_0421: Expected I, but got Obj
		//IL_0538: Expected I, but got Obj
		//IL_05de: Expected I4, but got Obj
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 72);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj - -64;
		object obj5 = obj + 16;
		object obj6 = obj + 56;
		object obj7 = obj + 60;
		obj7 = 0;
		_name.fontSize = (int)string.Empty;
		_medal.tag = null;
		_flag.tag = null;
		_shadow.tag = null;
		_glow.tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj8 = default;
		Texture texture2;
		if (obj8 != null)
		{
			object obj12;
			if (~(isLocalUser ? 1u : 0u) == 0)
			{
				nint num = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v134 (Il2CppClass<SocialManager>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num2 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v159 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v139 (System.Boolean)+38]");
				Texture texture;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v139 (System.Boolean)+38]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v157+14]");
					texture = (Texture)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v139 (System.Boolean)+3C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v139 (System.Boolean)+3C]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v154+14]");
						texture = (Texture)0;
					}
					else
					{
						texture = null;
					}
				}
				bool hasFacebookProfile = ((SocialManager)facebookDialogsSupported).HasFacebookProfile;
				_name.fontSize = (hasFacebookProfile ? 1 : 0);
				Color black = Color.black;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				_name.rawPivot = pivot;
				Color black2 = Color.black;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				_score.rawPivot = pivot;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj13 = default;
				obj12 = obj13;
				texture2 = texture;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj14 = default;
				if (obj14 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					UILabel uILabel = _name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v108+C]");
					uILabel.fontSize = 0;
					object obj15 = default;
					obj12 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v129+14]");
					texture2 = (Texture)0;
				}
				else
				{
					nint num3 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v90 (Il2CppClass<Strings>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num4 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v97 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = Strings.GetDefault("TOPRUN_ANONYMOUS_PLAYER_ALIAS");
					_name.fontSize = (int)text;
					obj12 = 0;
					texture2 = null;
				}
				nint num5 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v65 (Il2CppClass<GlobalColors>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num6 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S1_v83 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR;
				obj4 = obj2;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
				Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)pivot);
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				_name.rawPivot = pivot;
				obj5 = GlobalColors.TOPRUN_NORMAL_PLAYER_TEXT_COLOUR;
				obj6 = obj5;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
				Matrix4x4 matrix4x2 = Matrix4x4.Inverse((Matrix4x4)pivot);
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				_score.rawPivot = pivot;
			}
			if (obj12 != null)
			{
				if (~(isLocalUser ? 1u : 0u) != 0)
				{
					goto IL_0460;
				}
				if (~(isLocalUser ? 1u : 0u) == 0)
				{
					nint num7 = (nint)typeof(TopRunRewardHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v102 (Il2CppClass<TopRunRewardHelper>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num8 = (nint)typeof(TopRunRewardHelper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v108 (Il2CppClass<TopRunRewardHelper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CelebrationReward pendingReward = TopRunRewardHelper.GetPendingReward();
					if (pendingReward == null)
					{
						goto IL_0460;
					}
				}
			}
			goto IL_0808;
		}
		SDebug.LogFormat("Manager is null. Aborting cell initialization.", null);
		return;
		IL_0808:
		if (~(isLocalUser ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj19 = default;
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj20 = default;
				if (obj20 != null)
				{
					nint num9 = (nint)typeof(TopRunRewardHelper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v75 (Il2CppClass<TopRunRewardHelper>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num10 = (nint)typeof(TopRunRewardHelper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ S0_v90 (Il2CppClass<TopRunRewardHelper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CelebrationReward pendingReward2 = TopRunRewardHelper.GetPendingReward();
					if (pendingReward2 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj22 = default;
						if ((nint)obj22 >= 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
							bool useDark = default;
							SetBackgroundColour(useDark, (int)"");
						}
					}
				}
			}
		}
		if ((object)texture2 == null)
		{
			texture2 = dummyImage;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj23 = default;
		obj7 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_score.fontSize = fontSize;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj24 = default;
		string text2 = (string)(obj24 ^ 1);
		_competitorIcon.tag = text2;
		UILabel uILabel2 = _name;
		if (uILabel2.mOverflow != UILabel.Overflow.ResizeFreely)
		{
			uILabel2.mOverflow = UILabel.Overflow.ResizeFreely;
			((UIRect)uILabel2).mChanged = true;
			uILabel2.mShouldBeProcessed = true;
		}
		object obj25 = this - -64;
		bool flag = obj25 != null;
		((BreadCrumbHelper)this).OnVideoStateChanged((string)flag, (byte)rank != 0);
		this._002Ector();
		return;
		IL_0460:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		bool useDark2 = default;
		int num11 = default;
		SetBackgroundColour(useDark2, num11);
		goto IL_0808;
	}

	private bool HasShownMedalForWeek(int weekNumber)
	{
		//IL_0200: Expected I, but got Obj
		//IL_0216: Expected Obj, but got I
		//IL_0041: Expected I, but got Obj
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_00cf: Expected I, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I4
		//IL_028d: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		bool flag = obj != null;
		if (((flag ? 1u : 0u) & (uint)weekNumber) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}
		else
		{
			_ = 0;
		}
		_ = 1;
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v15 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v48 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v20 (System.Boolean)+60]");
		bool flag2 = default;
		if ((nint)0 == 3)
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v26 (Il2CppClass<SocialManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v44 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v31 (System.Boolean)+38]");
			if ((nint)0 != 0)
			{
				nint num5 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v34 (Il2CppClass<SocialManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v40 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj5 = (flag2 ? 1 : 0) + 20;
				bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v13 (System.Boolean)+38]");
				obj5 = 0;
			}
		}
		return flag2;
	}

	private void SetMedalForRank(int rank, string countryID)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		if (countryID != null)
		{
			return;
		}
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v38 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			return;
		}
		nint num3 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v19 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v34 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!AgeRestriction.waitForAgeRestriction)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			TopRunCell topRunCell = default;
			topRunCell.rank = -1;
			topRunCell.bestScore = -1;
			topRunCell.cellType = TopRunCellType.FACEBOOK_BUTTON;
			topRunCell.noPadding = true;
			((List<TopRunCell>)rank).Add(topRunCell);
			string text = (string)1;
		}
	}

	private IEnumerator AnimateMedalSprite(UISprite glowSprite, UISprite medalSprite, bool isThisWeeksResult)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = glowSprite;
		object obj2 = enumerator + 20;
		obj2 = isThisWeeksResult;
		return enumerator;
	}

	private IEnumerator AnimateEffectColor(UISprite spriteToAnimate, Color color1, Color color2, float speedFactor = 1f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private void SetBackgroundColour(bool useDark, int rank)
	{
		//IL_02a5: Expected Obj, but got I4
		//IL_02f0: Expected Obj, but got I4
		//IL_0328: Expected Obj, but got I4
		//IL_01c6: Expected I4, but got Obj
		//IL_01d6: Expected I4, but got Obj
		//IL_01f0: Expected I4, but got Obj
		//IL_0200: Expected I4, but got Obj
		//IL_021a: Expected I4, but got Obj
		//IL_022a: Expected I4, but got Obj
		//IL_0244: Expected I4, but got Obj
		//IL_0254: Expected I4, but got Obj
		//IL_00e0: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		bool flag = (useDark ? 1 : 0) > 3;
		char c = ((CountryManager)rank).GetDefaultCountryCodeFromDevice()?.m_firstChar ?? '\0';
		bool flag2;
		if (c != '\0')
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5 (System.Char)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		object obj = flag | flag2;
		if (obj == null)
		{
			_flag.fillCenter = (byte)c != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj3 = default;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					string text2 = default;
					string text = text2.ToLowerInvariant();
					string text3 = ((string)rank).ToLowerInvariant();
					if (text != text3)
					{
						_flag.tag = null;
						_shadow.tag = null;
					}
					else
					{
						_flag.tag = (string)1;
						_shadow.tag = (string)1;
					}
				}
			}
		}
		_medal.tag = (string)1;
		switch (useDark)
		{
		case false:
			_medal.fillCenter = (byte)(int)"icon_diamond_medal" != 0;
			_glow.fillCenter = (byte)(int)"icon_diamond_medal_glow" != 0;
			break;
		case true:
			_medal.fillCenter = (byte)(int)"icon_gold_medal" != 0;
			_glow.fillCenter = (byte)(int)"icon_gold_medal_glow" != 0;
			break;
		case true:
			_medal.fillCenter = (byte)(int)"icon_silver_medal" != 0;
			_glow.fillCenter = (byte)(int)"icon_silver_medal_glow" != 0;
			break;
		case true:
			_medal.fillCenter = (byte)(int)"icon_bronze_medal" != 0;
			_glow.fillCenter = (byte)(int)"icon_bronze_medal_glow" != 0;
			break;
		default:
			_medal.tag = null;
			_shadow.tag = null;
			_flag.tag = null;
			break;
		}
	}

	private void ResizeNameIfNeeded()
	{
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_00f2: Expected I, but got Obj
		//IL_01e4: Expected Obj, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_01f7: Expected I, but got Obj
		//IL_020d: Expected Obj, but got I
		//IL_0238: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj2 = default;
		if (obj2 == null || ~(isLocalUser ? 1u : 0u) != 0 || !_medal.isActiveAndEnabled)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		if (obj3 != null)
		{
			nint num = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v45 (Il2CppClass<TopRunRewardHelper>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v51 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationReward pendingReward = TopRunRewardHelper.GetPendingReward();
			if (pendingReward == null)
			{
				goto IL_015d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		if (obj5 == null)
		{
			goto IL_015d;
		}
		return;
		IL_015d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		bool flag = default;
		object obj8;
		if (obj6 != null)
		{
			string text = ((AwardFinishedCellHelper)null).FindBackgroundToUse(flag);
			object obj7 = text ^ 1;
			obj8 = obj7 & 1;
		}
		else
		{
			obj8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj9 = default;
		bool flag2;
		if (obj9 != null)
		{
			nint num3 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v31 (Il2CppClass<TopRunRewardHelper>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v45 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationReward pendingReward2 = TopRunRewardHelper.GetPendingReward();
			if (pendingReward2 != null)
			{
				flag2 = false;
			}
			else
			{
				bool mainGoalIcon = (byte)((flag ? 1u : 0u) + 1u) != 0;
				string text2 = ((AwardFinishedCellHelper)null).FindBackgroundToUse(mainGoalIcon);
				if (text2 != null)
				{
					flag2 = false;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj11 = default;
					flag2 = (nint)obj11 > 0;
				}
			}
		}
		else
		{
			flag2 = false;
		}
		object obj12 = obj8 | flag2;
		if (obj12 != null)
		{
			GameObject routine = ((SSEventsPopup)this).PlaceModelUnderAnchor((GameObject)(object)_glow, (Transform)(object)_medal, 0);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)routine);
			bool flag3 = !flag2;
			bool pendingTopRunBeatenFriendsAward = flag;
			if (!flag3)
			{
				bool flag4 = (byte)((flag ? 1u : 0u) + 1u) != 0;
				pendingTopRunBeatenFriendsAward = flag4;
			}
			TopRunSave.pendingTopRunBeatenFriendsAward = (pendingTopRunBeatenFriendsAward ? 1 : 0);
		}
	}

	public TopRunPlayerCell()
	{
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0207: Expected VT, but got Obj
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected Obj, but got Unknown
		//IL_0012: Expected VT, but got Obj
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_007e: Invalid comparison between F4 and Obj
		//IL_0250: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected I4, but got Unknown
		//IL_0126: Expected I, but got Obj
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 12);
		GameObject gameObject = _score.gameObject;
		transform.localPosition = (Vector3)gameObject;
		UILabel score = _score;
		object obj = transform - ((UIWidget)score).mWidth;
		GameObject gameObject2 = _name.gameObject;
		transform2.localPosition = (Vector3)gameObject2;
		float num = (float)obj - 10f;
		UILabel uILabel = _name;
		object obj2 = transform2 + ((UIWidget)uILabel).mWidth;
		UISprite medal = _medal;
		object obj3 = obj2 + ((UIWidget)medal).mWidth;
		UISprite flag = _flag;
		object obj4 = obj3 + ((UIWidget)flag).mWidth;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			return;
		}
		float width = (float)obj4 - num;
		UILabel uILabel2 = _name;
		if (uILabel2.mOverflow != UILabel.Overflow.ClampContent)
		{
			uILabel2.mOverflow = UILabel.Overflow.ClampContent;
			((UIRect)uILabel2).mChanged = true;
			uILabel2.mShouldBeProcessed = true;
		}
		UILabel uILabel3 = _name;
		nint num2 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S2_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S2_v26 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		int height = ((UIWidget)uILabel3).mWidth - gUILayoutOption;
		_name.height = height;
		bool isValid = _name.isValid;
		_name.fontSize = (isValid ? 1 : 0);
		UILabel uILabel4 = _name;
		if (uILabel4.mOverflow != UILabel.Overflow.ResizeFreely)
		{
			uILabel4.mOverflow = UILabel.Overflow.ResizeFreely;
			((UIRect)uILabel4).mChanged = true;
			uILabel4.mShouldBeProcessed = true;
		}
	}
}
