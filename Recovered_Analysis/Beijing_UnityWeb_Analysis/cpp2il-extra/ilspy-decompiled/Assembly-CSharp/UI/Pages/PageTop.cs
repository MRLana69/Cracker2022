using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Extensions;
using Missions;
using SYBO.Common;
using SYBO.Common.Data;
using UI.Footer;
using UI.Pages.MissionsPageInternal;
using UI.Popups.AgeRestrictionPopupInternal;
using UI.Popups.BoardBundlePopupInternal;
using UnityEngine;

namespace UI.Pages;

public class PageTop : MonoBehaviour
{
	public enum TopSplatType
	{
		Bubble,
		Star
	}

	public class EventsPageTopPayload
	{
		public string mainTitle;

		public string subTitle;

		public string multiplierText;

		public Color mainColor;

		public Color subTitleColor;

		public Color splatColor;

		public Color splatShadowColor;

		public TopSplatType topSplatType;

		public EventsPageTopPayload()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public class TopIconPayload
	{
		public GameObject iconPrefab;

		public Vector3 localPositionOffset;

		public Vector3 localRotationOffsetEuler;

		public Vector3 localScaleOffset;

		public TopIconPayload()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = "";
		}
	}

	private sealed class _003CDelayCoroutine_003Ed__37(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public Action action;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Expected Obj, but got Unknown
				//IL_0072: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						TransformExtensions.Reset((Transform)(object)action);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = -1f;
				_ = delay;
				object obj = this + 12;
				object obj2 = default;
				obj = obj2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_000b: Expected Obj, but got I4
			//IL_001e: Expected Obj, but got I4
			FooterButton.FooterPayload buttonPayload = ((WeeklyHuntPage)_003C_003E1__state).GetButtonPayload();
			Coroutine coroutine = ((MonoBehaviour)_003C_003E1__state).StartCoroutine_Auto((IEnumerator)buttonPayload);
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

	private sealed class _003CFadeOutBlinkImage_003Ed__39(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PageTop _003C_003E4__this;

		private float _003CcurrentDuration_003E5__2;

		private float _003CstartAlpha_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_01d7: Expected I, but got Obj
				//IL_01ed: Expected Obj, but got I
				//IL_00ef: Expected I, but got Obj
				//IL_0105: Expected Obj, but got I
				//IL_0218: Expected I, but got Obj
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_0195: Expected Obj, but got Unknown
				//IL_019e: Expected Obj, but got I4
				//IL_01b2: Expected Obj, but got I4
				//IL_0130: Expected I, but got Obj
				PageTop pageTop = _003C_003E4__this;
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
					_003CcurrentDuration_003E5__2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
					float num = default;
					_003CstartAlpha_003E5__3 = num;
				}
				if (!(_003CcurrentDuration_003E5__2 > pageTop._blinkEffectDuration))
				{
					float num2 = _003CcurrentDuration_003E5__2 / pageTop._blinkEffectDuration;
					float num3 = num2 - 2f;
					float num4 = num2 * num3;
					float t = 0f - num4;
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num6 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v38 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num7 = Mathf.LerpUnclamped(_003CstartAlpha_003E5__3, 0f, t);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					float fixedDeltaTime = Time.fixedDeltaTime;
					float num8 = _003CcurrentDuration_003E5__2 + fixedDeltaTime;
					_003CcurrentDuration_003E5__2 = num8;
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				string tag = pageTop._blinkImage.tag;
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
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

	private sealed class _003CAnimateIconScale_003Ed__40(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PageTop _003C_003E4__this;

		private float _003CcurrentDuration_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f8: Expected VT, but got Unknown
				//IL_0201: Unknown result type (might be due to invalid IL or missing references)
				//IL_0206: Expected VT, but got Unknown
				//IL_020f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0214: Expected Obj, but got Unknown
				//IL_021d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0222: Expected Obj, but got Unknown
				//IL_022b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0230: Expected Obj, but got Unknown
				//IL_0104: Expected I, but got Obj
				//IL_011a: Expected Obj, but got I
				//IL_0270: Unknown result type (might be due to invalid IL or missing references)
				//IL_0275: Expected Obj, but got Unknown
				//IL_0297: Expected F4, but got Obj
				//IL_0292: Expected native int or pointer, but got VT
				//IL_02ac: Expected F4, but got I
				//IL_02a7: Expected native int or pointer, but got VT
				//IL_02ca: Expected F4, but got Obj
				//IL_02c5: Expected native int or pointer, but got VT
				//IL_02df: Expected F4, but got I
				//IL_02da: Expected native int or pointer, but got VT
				//IL_02ec: Expected F4, but got Obj
				//IL_02e7: Expected native int or pointer, but got VT
				//IL_0301: Expected F4, but got I
				//IL_02fc: Expected native int or pointer, but got VT
				//IL_0191: Expected F4, but got Obj
				//IL_018c: Expected native int or pointer, but got VT
				//IL_01a6: Expected F4, but got I
				//IL_01a1: Expected native int or pointer, but got VT
				//IL_01b3: Expected Obj, but got VT
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Expected Obj, but got Unknown
				//IL_01c7: Expected Obj, but got I4
				//IL_01db: Expected Obj, but got I4
				//IL_0145: Expected I, but got Obj
				object obj = default;
				Vector3 vector = (Vector3)(obj + 60);
				Vector3 vector2 = (Vector3)(obj + 48);
				object obj2 = obj + 36;
				object obj3 = obj + 24;
				object obj4 = obj + 12;
				PageTop pageTop = _003C_003E4__this;
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
					_003CcurrentDuration_003E5__2 = 0f;
				}
				if (!(_003CcurrentDuration_003E5__2 > pageTop._iconScaleEffectDuration))
				{
					float fixedDeltaTime = Time.fixedDeltaTime;
					float num = _003CcurrentDuration_003E5__2 + fixedDeltaTime;
					_003CcurrentDuration_003E5__2 = num;
					float defaultValue = _003CcurrentDuration_003E5__2 / pageTop._iconScaleEffectDuration;
					float angle = PlayerPrefs.GetFloat((string)(object)pageTop._iconScaleEffectCurve, defaultValue);
					GameObject gameObject = pageTop._multiplierText.gameObject;
					nint num2 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num3 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v42 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward = Vector3.forward;
					object obj6 = pageTop - -64;
					obj3 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v10+8]");
					_ = 0;
					((Vector3*)(nint)vector)->x = (float)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Quaternion quaternion = Quaternion.AngleAxis(angle, vector);
					((Vector3*)(nint)vector2)->x = (float)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					((Vector3*)(nint)vector)->x = (float)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((Vector3*)(nint)vector)->z = 0f;
					Vector3 vector3 = vector2 - vector;
					((Vector3*)(nint)vector)->x = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector3*)(nint)vector)->z = 0f;
					((Transform)(object)gameObject).parent = (Transform)vector;
					object obj7 = this + 12;
					obj7 = 0;
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

	private sealed class _003CAnimateShadowAlpha_003Ed__41(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PageTop _003C_003E4__this;

		private float _003CcurrentDuration_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0083: Expected Obj, but got I4
				//IL_0151: Unknown result type (might be due to invalid IL or missing references)
				//IL_0156: Expected Obj, but got Unknown
				//IL_015f: Expected Obj, but got I4
				//IL_0173: Expected Obj, but got I4
				PageTop pageTop = _003C_003E4__this;
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
					_003CcurrentDuration_003E5__2 = 0f;
					string tag = pageTop._shadowAnimText.tag;
					((GameObject)(object)tag).tag = (string)1;
				}
				if (!(_003CcurrentDuration_003E5__2 > pageTop._shadowAlphaEffectDuration))
				{
					float defaultValue = _003CcurrentDuration_003E5__2 / pageTop._shadowAlphaEffectDuration;
					float num = PlayerPrefs.GetFloat((string)(object)pageTop._shadowAlphaEffectCurve, defaultValue);
					float num2 = num * pageTop._shadowAlphaEffectAmount;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					float fixedDeltaTime = Time.fixedDeltaTime;
					float num3 = _003CcurrentDuration_003E5__2 + fixedDeltaTime;
					_003CcurrentDuration_003E5__2 = num3;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
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

	private sealed class _003CAnimateShadowExpansion_003Ed__42(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PageTop _003C_003E4__this;

		private float _003CcurrentDuration_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b3: Expected Obj, but got Unknown
				//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c1: Expected VT, but got Unknown
				//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cf: Expected Obj, but got Unknown
				//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02dd: Expected Obj, but got Unknown
				//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02eb: Expected Obj, but got Unknown
				//IL_005f: Expected Obj, but got I4
				//IL_0225: Expected I, but got Obj
				//IL_023b: Expected Obj, but got I
				//IL_03de: Expected Obj, but got F4
				//IL_03f0: Expected I, but got F4
				//IL_0266: Expected I, but got Obj
				//IL_0105: Expected I, but got Obj
				//IL_011b: Expected Obj, but got I
				//IL_032b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0330: Expected Obj, but got Unknown
				//IL_036f: Expected VT, but got Obj
				//IL_0380: Expected F4, but got Obj
				//IL_037b: Expected native int or pointer, but got VT
				//IL_0395: Expected F4, but got I
				//IL_0390: Expected native int or pointer, but got VT
				//IL_03bf: Expected VT, but got Obj
				//IL_0146: Expected I, but got Obj
				//IL_01de: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e3: Expected Obj, but got Unknown
				//IL_01ec: Expected Obj, but got I4
				//IL_0200: Expected Obj, but got I4
				object obj = default;
				Transform transform = (Transform)(obj + 60);
				Vector3 vector = (Vector3)(obj + 48);
				object obj2 = obj + 36;
				object obj3 = obj + 24;
				object obj4 = obj + 12;
				PageTop pageTop = _003C_003E4__this;
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
					_003CcurrentDuration_003E5__2 = 0f;
					string tag = pageTop._shadowAnimText.tag;
					((GameObject)(object)tag).tag = (string)1;
				}
				if (!(_003CcurrentDuration_003E5__2 > pageTop._shadowExpansionEffectDuration))
				{
					float defaultValue = _003CcurrentDuration_003E5__2 / pageTop._shadowExpansionEffectDuration;
					float angle = PlayerPrefs.GetFloat((string)(object)pageTop._shadowExpansionEffectCurve, defaultValue);
					GameObject gameObject = pageTop._shadowAnimText.gameObject;
					nint num = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num2 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v56 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward = Vector3.forward;
					object obj6 = pageTop + 104;
					obj3 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S2_v16+8]");
					_ = 0;
					transform = (Transform)obj3;
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					Quaternion quaternion = Quaternion.AngleAxis(angle, (Vector3)transform);
					((Vector3*)(nint)vector)->x = (float)obj2;
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					transform = (Transform)obj4;
					Transform transform3 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
					Vector3 vector3 = vector - (Vector3)transform;
					transform = (Transform)obj;
					Transform transform4 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
					((Transform)(object)gameObject).parent = transform;
					float fixedDeltaTime = Time.fixedDeltaTime;
					float num3 = _003CcurrentDuration_003E5__2 + fixedDeltaTime;
					_003CcurrentDuration_003E5__2 = num3;
					object obj7 = this + 12;
					obj7 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				GameObject gameObject2 = pageTop._shadowAnimText.gameObject;
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num5 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v23 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 forward2 = Vector3.forward;
				transform = (Transform)vector.x;
				((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
				((Transform)(object)gameObject2).parent = transform;
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

	private UILabel _mainTitle;

	private UILabel _subtitle;

	private UIWidget _slotForItemLoad;

	private UISprite _bubbleSplat;

	private UISprite _bubbleSplatShadow;

	private UISprite _starSplat;

	private UISprite _starSplatShadow;

	private UILabel _multiplierText;

	private UILabel _shadowAnimText;

	private UIWidget _iconGuideWidget;

	private Transform _iconAnchor;

	private AnimationCurve _iconScaleEffectCurve;

	private float _iconScaleEffectDuration;

	private Vector3 _iconScaleEffectAmount;

	private float _iconScaleEffectDelay;

	private AnimationCurve _shadowAlphaEffectCurve;

	private float _shadowAlphaEffectDuration;

	private float _shadowAlphaEffectAmount;

	private float _shadowAlphaEffectDelay;

	private AnimationCurve _shadowExpansionEffectCurve;

	private float _shadowExpansionEffectDuration;

	private Vector3 _shadowExpansionEffectAmount;

	private float _shadowExpansionEffectDelay;

	private ParticleSystem _starBurstVFX;

	private float _blinkEffectDuration;

	private Transform _icon;

	private UILabel _blinkImage;

	public void Setup(EventsPageTopPayload payload)
	{
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_021a: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I
		//IL_0067: Expected VT, but got Obj
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0135: Expected I, but got Obj
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_027f: Expected Obj, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_02b9: Expected F4, but got I4
		//IL_01c3: Expected I, but got Obj
		Transform transform = default;
		object obj = transform + 12;
		obj = 0;
		_ = 0;
		UIWidget component = GetComponent<UIWidget>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [payload @ L1 (UI.Pages.PageTop+EventsPageTopPayload)+68]");
		Color color = ((UIWidget)0).color;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj3 = default;
		object obj2 = obj3 + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj5 = default;
		object obj4 = obj5 + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v14+4]");
		object obj6 = num - 0;
		GameObject gameObject = component.gameObject;
		transform.position = (Vector3)gameObject;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj7 = obj + 4;
		object obj8 = obj7 + obj6;
		obj7 = obj8;
		GameObject gameObject2 = component.gameObject;
		Transform transform2 = (Transform)(transform + 24);
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform2.localPosition;
		nint num2 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v26 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num3 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v50 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			return;
		}
		nint num4 = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v37 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num5 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v44 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = IPhoneXSupport.OFFSET_BOTTOM + IPhoneXSupport.OFFSET_TOP;
		UIWidget uIWidget = (UIWidget)(component.mHeight - obj11);
		Color color2 = uIWidget.color;
		GameObject gameObject3 = component.gameObject;
		TransformExtensions.OffsetLocalPosZ((Transform)(object)gameObject3, IPhoneXSupport.OFFSET_BOTTOM);
	}

	public GameObject MakeSlotItem(Func<UIWidget, GameObject> maker)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		GameObject parent = ((Component)(object)maker).gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionSetProgress missionSetProgress = UnityEngine.Object.Instantiate((MissionSetProgress)(object)_shadowAnimText, (Transform)(object)parent);
		return (GameObject)(object)missionSetProgress.tag;
	}

	public unsafe void MakeIcon(TopIconPayload payload)
	{
		//IL_0014: Expected I4, but got Obj
		//IL_0028: Expected I4, but got VT
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected I4, but got Unknown
		//IL_0079: Expected I4, but got Obj
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00d3: Expected I4, but got Obj
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0132: Expected I4, but got Obj
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_018c: Expected I4, but got Obj
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01eb: Expected I4, but got Obj
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0237: Expected I4, but got Obj
		//IL_02be: Expected Obj, but got I4
		//IL_02f6: Expected Obj, but got I4
		_mainTitle.fontSize = (int)payload.iconPrefab;
		_subtitle.fontSize = (int)payload.localPositionOffset;
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = payload + 20;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S2_v5+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 96);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v7+8]");
		_ = 0;
		_mainTitle.rawPivot = pivot;
		object obj4 = obj2 - -64;
		object obj5 = payload + 36;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v17+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v14+8]");
		_ = 0;
		_subtitle.rawPivot = pivot;
		object obj6 = obj2 + 48;
		object obj7 = payload + 52;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v28+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v20+8]");
		_ = 0;
		_bubbleSplat.rawPivot = pivot;
		object obj8 = obj2 + 32;
		object obj9 = payload + 52;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S2_v39+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v26+8]");
		_ = 0;
		_starSplat.rawPivot = pivot;
		object obj10 = obj2 + 16;
		object obj11 = payload + 68;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S2_v50+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v32+8]");
		_ = 0;
		_bubbleSplatShadow.rawPivot = pivot;
		object obj12 = payload + 68;
		obj2 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v60+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_starSplatShadow.rawPivot = pivot;
		UILabel shadowAnimText = _shadowAnimText;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [payload @ L1 (UI.Pages.PageTop+TopIconPayload)+10]");
		shadowAnimText.fontSize = 0;
		UILabel multiplierText = _multiplierText;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [payload @ L1 (UI.Pages.PageTop+TopIconPayload)+10]");
		multiplierText.fontSize = 0;
		string text = _bubbleSplat.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [payload @ L1 (UI.Pages.PageTop+TopIconPayload)+54]");
		bool flag = (nint)0 == 0;
		((GameObject)(object)text).tag = (string)flag;
		string text2 = _starSplat.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [payload @ L1 (UI.Pages.PageTop+TopIconPayload)+54]");
		bool flag2 = (nint)0 == 1;
		((GameObject)(object)text2).tag = (string)flag2;
		this._002Ector();
	}

	private void AdjustIcon(Vector3 localPositionOffset, Vector3 localRotationOffsetEuler, Vector3 localScaleOffset)
	{
		//IL_003d: Expected I4, but got VT
		//IL_004a: Invalid comparison between VT and I4
		//IL_0028: Expected I4, but got VT
		//IL_0028: Expected Obj, but got VT
		//IL_0012: Expected Obj, but got VT
		BundleIcon bundleIcon = ((List<BundleIcon>)(object)_bubbleSplatShadow).get_Item((int)localScaleOffset);
		if (localRotationOffsetEuler < (object)1)
		{
			((ListContentElement)(object)bundleIcon).content = (string)localPositionOffset;
		}
		else
		{
			((ListContentElement)(object)bundleIcon)._002Ector((string)localPositionOffset, (int)localRotationOffsetEuler);
		}
	}

	public void UpdateMultiplierText(string newText, bool useEffect = false)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got I
		object obj = this + 48;
		obj = newText;
		object obj2 = _iconGuideWidget + 16;
		obj2 = this;
		object obj3 = this + 52;
		obj3 = useEffect;
		object obj4 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [useEffect @ L2 (System.Boolean)+C]");
		string text = ((Component)0).tag;
		UIPanel component = ((GameObject)(object)text).GetComponent<UIPanel>();
		obj4 = component;
		_mainTitle.fontSize = newText.m_stringLength;
	}

	public void PlayMultiplierAnimations()
	{
		CancelInvoke();
	}

	private void Delay(float delay, Action action)
	{
		//IL_04a6: Expected I, but got Obj
		//IL_04bc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_032e: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_00f2: Expected I, but got Obj
		//IL_036f: Expected I, but got Obj
		//IL_01c6: Expected I, but got Obj
		//IL_03dc: Expected I, but got Obj
		//IL_03f2: Expected Obj, but got I
		//IL_02a6: Expected VT, but got I4
		//IL_02ff: Expected VT, but got I4
		//IL_041d: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v111 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3;
		if (delay < 0f)
		{
			num3 = 0f;
		}
		else
		{
			num3 = ((!(delay > 1f)) ? delay : 1f);
		}
		float defaultValue;
		if ((nint)_mainTitle == 1)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v91 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v102 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num6 = 1f - num3;
			float num7 = (float)Math.PI / 2f * num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
			object obj3 = default;
			float num8 = 1f - (float)obj3;
			bool flag = (object)_starSplatShadow == null;
			defaultValue = num8;
			if (!flag)
			{
				float num9 = num8 * num8;
				defaultValue = num9;
			}
		}
		else if ((nint)_mainTitle == 2)
		{
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v74 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num11 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v86 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num12 = (float)Math.PI / 2f * num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
			bool flag2 = (object)_starSplatShadow == null;
			float num13 = default;
			defaultValue = num13;
			if (!flag2)
			{
				float num14 = 1f - num13;
				float num15 = num14 * num14;
				float num16 = 1f - num15;
				defaultValue = num16;
			}
		}
		else if ((nint)_mainTitle != 3)
		{
			if ((nint)_mainTitle == 4)
			{
				float num17 = Math3D.MouseDistanceToCircle((Vector3)0, num3);
				defaultValue = num17;
			}
			else
			{
				bool flag3 = (nint)_mainTitle != 5;
				defaultValue = num3;
				if (!flag3)
				{
					float radius = 1f - num3;
					float num18 = Math3D.MouseDistanceToCircle((Vector3)0, radius);
					float num19 = 1f - num18;
					defaultValue = num19;
				}
			}
		}
		else
		{
			nint num20 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v31 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num21 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v59 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num22 = num3 * ((float)Math.PI * 2f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E7");
			object obj6 = default;
			float num23 = (float)obj6 / ((float)Math.PI * 2f);
			float num24 = num3 - num23;
			bool flag4 = (object)_starSplatShadow == null;
			defaultValue = num24;
			if (!flag4)
			{
				float num25 = num24 * 2f;
				float num26 = num25 - 1f;
				nint num27 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v43 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num28 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v55 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num29 = ((num26 < 0f) ? (-1f) : 1f);
				float num30 = Math.Abs(num26);
				float num31 = 1f - num30;
				float num32 = num31 * num31;
				float num33 = 1f - num32;
				float num34 = num29 * num33;
				float num35 = num34 * 0.5f;
				float num36 = num35 + 0.5f;
				defaultValue = num36;
			}
		}
		if ((object)_slotForItemLoad != null)
		{
			float num37 = PlayerPrefs.GetFloat((string)(object)_slotForItemLoad, defaultValue);
			defaultValue = num37;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A9F");
	}

	private IEnumerator DelayCoroutine(float delay, Action action)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = action;
		return enumerator;
	}

	public float GetMultiplierAnimationDuration()
	{
		float num = (float)_starSplatShadow * 2f;
		return num + (float)_starSplat;
	}

	private IEnumerator FadeOutBlinkImage()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator AnimateIconScale()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private IEnumerator AnimateShadowAlpha()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private IEnumerator AnimateShadowExpansion()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void ResetAnimations()
	{
		//IL_0104: Expected Obj, but got I
		//IL_010f: Expected F4, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0018: Expected Obj, but got I
		//IL_0023: Expected F4, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0073: Expected F4, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I
		//IL_00c3: Expected F4, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		ScoreMultiplier scoreMultiplier = default;
		scoreMultiplier.OnValueChanged = (EventHandler<ScoreMultiplier.ValueChangedEventArgs>)num;
		scoreMultiplier._coolDownDurationMS = 0f;
		object obj = scoreMultiplier + 16;
		obj = this;
		float originalValue = _iconScaleEffectDelay + _iconScaleEffectDuration;
		((Score)(object)this)._002Ector(originalValue, scoreMultiplier);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		ScoreMultiplier scoreMultiplier2 = default;
		scoreMultiplier2.OnValueChanged = (EventHandler<ScoreMultiplier.ValueChangedEventArgs>)num2;
		scoreMultiplier2._coolDownDurationMS = 0f;
		object obj2 = scoreMultiplier2 + 16;
		obj2 = this;
		((Score)(object)this)._002Ector(_iconScaleEffectDelay, scoreMultiplier2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		ScoreMultiplier scoreMultiplier3 = default;
		scoreMultiplier3.OnValueChanged = (EventHandler<ScoreMultiplier.ValueChangedEventArgs>)num3;
		scoreMultiplier3._coolDownDurationMS = 0f;
		object obj3 = scoreMultiplier3 + 16;
		obj3 = this;
		((Score)(object)this)._002Ector(_shadowAlphaEffectDelay, scoreMultiplier3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		ScoreMultiplier scoreMultiplier4 = default;
		scoreMultiplier4.OnValueChanged = (EventHandler<ScoreMultiplier.ValueChangedEventArgs>)num4;
		scoreMultiplier4._coolDownDurationMS = 0f;
		object obj4 = scoreMultiplier4 + 16;
		obj4 = this;
		((Score)(object)this)._002Ector(_shadowExpansionEffectDelay, scoreMultiplier4);
	}

	public PageTop()
	{
		//IL_0219: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00de: Expected I, but got Obj
		//IL_00f4: Expected Obj, but got I
		//IL_011f: Expected I, but got Obj
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_01bc: Expected I, but got Obj
		GameObject gameObject = _multiplierText.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v48 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 forward = Vector3.forward;
		Transform transform = (Transform)(obj3 + 24);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v10+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject).parent = transform;
		string text = _shadowAnimText.tag;
		((GameObject)(object)text).tag = null;
		GameObject gameObject2 = _shadowAnimText.gameObject;
		Vector3 forward2 = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject2).parent = transform;
		string text2 = _starBurstVFX.tag;
		((GameObject)(object)text2).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_blinkImage).FindKernel((string)null) == 0)
		{
			return;
		}
		string obj5 = _blinkImage.tag;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj5);
	}

	private void _003CPlayMultiplierAnimations_003Eb__35_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got F4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got F4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		_iconScaleEffectDuration = 0.5f;
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		obj = 0.1f;
		_ = 0.1f;
		_ = 0.1f;
		object obj3 = obj2 + 24;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+8]");
		_ = 0;
		object obj4 = this - -64;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
		_ = 0;
		_shadowAlphaEffectDuration = 0.5f;
		_shadowAlphaEffectAmount = 1f;
		_shadowAlphaEffectDelay = 0.5f;
		_shadowExpansionEffectDuration = 0.5f;
		obj2 = 0;
		_ = 0;
		obj2 = 0.1f;
		_ = 0.1f;
		_ = 0.1f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 104;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
		_ = 0;
		_shadowExpansionEffectDelay = 0.5f;
		_blinkEffectDuration = 0.05f;
		CancelInvoke();
	}

	private unsafe void _003CPlayMultiplierAnimations_003Eb__35_1()
	{
		//IL_02c1: Expected I, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_035d: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_0082: Expected I4, but got Obj
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got I4
		//IL_03d8: Expected Obj, but got F4
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected I4, but got Unknown
		//IL_0405: Expected I4, but got Obj
		//IL_00f2: Expected I, but got Obj
		//IL_0163: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_043c: Expected I4, but got Obj
		//IL_0456: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		//IL_01a4: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I4
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v4 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v66 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = ((currentSkipForVideoMissionIndex <= 29) ? ((object)(currentSkipForVideoMissionIndex + 1)) : ((object)30));
		object obj4 = default;
		object obj3 = obj4 + 32;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "x" + text2;
		_shadowAnimText.fontSize = (int)text;
		_multiplierText.fontSize = (int)text;
		GameObject gameObject = _shadowAnimText.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 132;
		UILabel uILabel = UnityEngine.Object.Instantiate(_shadowAnimText, parentInternal);
		obj6 = uILabel;
		UILabel blinkImage = _blinkImage;
		UIWidget uIWidget = (UIWidget)(((UIWidget)blinkImage).mDepth + 1);
		Vector2 localSize = uIWidget.localSize;
		object obj7 = obj4 + 16;
		obj7 = 0;
		_ = 0;
		obj7 = 1f;
		_ = 1f;
		_ = 1f;
		_ = 1f;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj4 + 40);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v27+8]");
		_ = 0;
		_blinkImage.rawPivot = pivot;
		_blinkImage.fontStyle = (FontStyle)43;
		GameObject gameObject2 = _blinkImage.gameObject;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v40 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v61 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward = Vector3.forward;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		((Transform)(object)gameObject2).parent = (Transform)pivot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		string text3 = _blinkImage.tag;
		((GameObject)(object)text3).tag = (string)1;
		string text4 = _starBurstVFX.tag;
		string text5 = ((GameObject)(object)text4).tag;
		if (text5 != null)
		{
			string text6 = _starBurstVFX.tag;
			((GameObject)(object)text6).tag = null;
		}
		string text7 = _starBurstVFX.tag;
		((GameObject)(object)text7).tag = (string)1;
		IEnumerator routine = AnimateIconScale();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private void _003CPlayMultiplierAnimations_003Eb__35_2()
	{
		IEnumerator routine = AnimateShadowAlpha();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private void _003CPlayMultiplierAnimations_003Eb__35_3()
	{
		IEnumerator routine = AnimateShadowExpansion();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}
}
