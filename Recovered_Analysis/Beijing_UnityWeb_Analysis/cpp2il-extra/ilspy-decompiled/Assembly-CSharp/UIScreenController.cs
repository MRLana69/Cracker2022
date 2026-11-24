using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ABTest;
using AppRefresh;
using Cloud;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Timer;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using Missions;
using SYBO.Common.Managers;
using SYBO.Common.Utilities.Flags;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Info;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level.Environments;
using SYBO.Subway.Promotion;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using TopRun.UI;
using UI;
using UI.Generic.Layout;
using UI.MessageCenter;
using UI.Pages.MissionsPageInternal;
using UI.Screens;
using UI.Screens.PauseScreenInternal;
using UI.Screens.RewardManagement;
using UI.ScrollListSelectPopup;
using UI.SlideIns;
using UnityEngine;
using UnityEngine.Bindings;
using WordHunt;

public class UIScreenController : MonoBehaviour
{
	private sealed class _003CShowMainMenuCoroutine_003Ed__97(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0109: Expected I, but got Obj
				//IL_011f: Expected Obj, but got I
				//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d4: Expected Obj, but got Unknown
				//IL_01dd: Expected Obj, but got I4
				//IL_01f1: Expected Obj, but got I4
				//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Expected Obj, but got Unknown
				//IL_00e2: Expected Obj, but got I4
				//IL_00f6: Expected Obj, but got I4
				//IL_014a: Expected I, but got Obj
				UIScreenController uIScreenController = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						uIScreenController._hasShownFrontScreenBefore = true;
						string text = uIScreenController.Peek((List<string>)(object)"FrontScreen");
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8D38");
				object obj = default;
				if (obj == null)
				{
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				nint num = (nint)typeof(ThemeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v15 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(ThemeManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameStateMachine instance = GameStateMachine.Instance;
				((ThemeManager)(object)instance).OnDestroy();
				object obj4 = this + 12;
				obj4 = 0;
				_003C_003E1__state = 2;
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

	private sealed class _003CDelayHideMainCamera_003Ed__115(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0065: Expected Obj, but got I4
				UIScreenController uIScreenController = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						uIScreenController.mainCamera.tag = null;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj2 = default;
				obj = obj2;
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

	private sealed class _003CAnimateCollectText_003Ed__157(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UILabel collectText;

		public UIScreenController _003C_003E4__this;

		private Vector3 _003CtoLocalPosition_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bf: Expected Obj, but got Unknown
				//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_03cd: Expected Obj, but got Unknown
				//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03db: Expected Obj, but got Unknown
				//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e9: Expected Obj, but got Unknown
				//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f7: Expected Obj, but got Unknown
				//IL_0400: Unknown result type (might be due to invalid IL or missing references)
				//IL_0405: Expected Obj, but got Unknown
				//IL_040e: Expected Obj, but got I4
				//IL_008e: Expected VT, but got Obj
				//IL_00ea: Expected Obj, but got I4
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Expected Obj, but got Unknown
				//IL_0162: Unknown result type (might be due to invalid IL or missing references)
				//IL_0167: Expected Obj, but got Unknown
				//IL_017d: Expected VT, but got Obj
				//IL_01b5: Expected Obj, but got I4
				//IL_01da: Unknown result type (might be due to invalid IL or missing references)
				//IL_01df: Expected Obj, but got Unknown
				//IL_0260: Unknown result type (might be due to invalid IL or missing references)
				//IL_0265: Expected Obj, but got Unknown
				//IL_0281: Expected Obj, but got I4
				//IL_02a7: Expected VT, but got Obj
				//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02de: Expected Obj, but got Unknown
				//IL_02fa: Expected Obj, but got I4
				//IL_0327: Expected I, but got Obj
				//IL_033d: Expected Obj, but got I
				//IL_0368: Expected I, but got Obj
				object obj = default;
				Action action = (Action)(obj + 72);
				Transform transform = (Transform)(obj + 48);
				object obj2 = obj + 36;
				object obj3 = obj + 24;
				object obj4 = obj + 12;
				object obj5 = obj + 60;
				obj5 = 0;
				_ = 0;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								string tag = collectText.tag;
								nint num = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+BA]");
								object obj6 = (nint)0 & (nint)0x200;
								if (obj6 != null)
								{
									nint num2 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v84 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						GameObject routine = ((UIKeyNavigation)null).Get((Vector3)collectText, 0.2f, 0f);
						Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)routine);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.25f;
						object obj7 = this + 12;
						object obj8 = default;
						obj7 = obj8;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					Camera anchorCamera = collectText.anchorCamera;
					object obj9 = this + 24;
					transform = (Transform)obj9;
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v55+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					action = (Action)(object)transform;
					((Delegate)action).method_ptr = ((UnityEngine.Object)transform).m_CachedPtr;
					IEnumerator routine2 = ((MissionSetProgress)null).BounceObject((UISprite)(object)anchorCamera, 1f, action);
					Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto(routine2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = 0.8f;
					object obj10 = this + 12;
					object obj11 = default;
					obj10 = obj11;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				GameObject gameObject = collectText.gameObject;
				transform.localPosition = (Vector3)gameObject;
				obj5 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				obj2 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				obj3 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				_ = 0;
				obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				_ = 0;
				obj = 0;
				_ = 0;
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
				float num3 = 0f + 50f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				_ = 0;
				action = (Action)obj;
				Action action2 = action;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Delegate)action2).method_ptr = (IntPtr)0;
				object obj12 = this + 24;
				obj12 = action;
				_ = ((Delegate)action).method_ptr;
				object obj13 = this + 12;
				GameObject routine3 = ((UIKeyNavigation)null).Get((Vector3)collectText, 0.1f, 1f);
				Coroutine coroutine3 = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)(object)routine3);
				obj13 = coroutine3;
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

	private sealed class _003CAnimateAlpha_003Ed__158(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UILabel label;

		public float duration;

		public float toAlpha;

		private float _003CfromAlpha_003E5__2;

		private float _003Cfactor_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00df: Expected I, but got Obj
				//IL_00f5: Expected Obj, but got I
				//IL_0120: Expected I, but got Obj
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0246: Expected Obj, but got Unknown
				//IL_024f: Expected Obj, but got I4
				//IL_0263: Expected Obj, but got I4
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
				if (_003Cfactor_003E5__3 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num2 = unscaledTime / duration;
					float num3 = _003Cfactor_003E5__3 + num2;
					_003Cfactor_003E5__3 = num3;
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num5 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
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
					object obj2 = this + 12;
					obj2 = 0;
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

	private sealed class _003CMoveTransform_003Ed__159(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public float duration;

		public Vector3 toPos;

		private Vector3 _003CfromPos_003E5__2;

		private float _003Cfactor_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0250: Unknown result type (might be due to invalid IL or missing references)
				//IL_0255: Expected VT, but got Unknown
				//IL_025e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0263: Expected Obj, but got Unknown
				//IL_026c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0271: Expected Obj, but got Unknown
				//IL_027a: Unknown result type (might be due to invalid IL or missing references)
				//IL_027f: Expected Obj, but got Unknown
				//IL_0043: Expected VT, but got Obj
				//IL_0050: Expected F4, but got Obj
				//IL_004b: Expected native int or pointer, but got VT
				//IL_0062: Expected F4, but got I
				//IL_005d: Expected native int or pointer, but got VT
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Expected Obj, but got Unknown
				//IL_007a: Expected Obj, but got F4
				//IL_011b: Expected I, but got Obj
				//IL_0131: Expected Obj, but got I
				//IL_015c: Expected I, but got Obj
				//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e2: Expected Obj, but got Unknown
				//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0302: Expected Obj, but got Unknown
				//IL_0325: Expected I, but got Obj
				//IL_033b: Expected Obj, but got I
				//IL_0382: Expected F4, but got Obj
				//IL_037d: Expected native int or pointer, but got VT
				//IL_0397: Expected F4, but got I
				//IL_0392: Expected native int or pointer, but got VT
				//IL_03aa: Expected VT, but got Obj
				//IL_03bb: Expected F4, but got Obj
				//IL_03b6: Expected native int or pointer, but got VT
				//IL_03d0: Expected F4, but got I
				//IL_03cb: Expected native int or pointer, but got VT
				//IL_03d9: Expected Obj, but got VT
				//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e8: Expected Obj, but got Unknown
				//IL_03f1: Expected Obj, but got I4
				//IL_0405: Expected Obj, but got I4
				//IL_01fe: Expected I, but got Obj
				object obj = default;
				Vector3 vector = (Vector3)(obj + 48);
				Transform transform = (Transform)(obj + 36);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
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
					transform.localPosition = (Vector3)trans;
					((Vector3*)(nint)vector)->x = (float)transform;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
					object obj4 = this + 36;
					obj4 = vector.x;
					_ = vector.z;
					_003Cfactor_003E5__3 = 0f;
				}
				if (_003Cfactor_003E5__3 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime / duration;
					float num2 = _003Cfactor_003E5__3 + num;
					_003Cfactor_003E5__3 = num2;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v39 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num5;
					if (_003Cfactor_003E5__3 < 0f)
					{
						num5 = 0f;
					}
					else
					{
						num5 = ((!(_003Cfactor_003E5__3 > 1f)) ? _003Cfactor_003E5__3 : 1f);
					}
					_003Cfactor_003E5__3 = num5;
					object obj6 = this + 36;
					obj2 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S2_v9+8]");
					_ = 0;
					object obj7 = this + 24;
					obj3 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S2_v14+8]");
					_ = 0;
					nint num6 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v25 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num7 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v40 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					transform = (Transform)obj2;
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					((Vector3*)(nint)vector)->x = (float)obj3;
					Vector3 vector2 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					((Vector3*)(nint)vector2)->z = 0f;
					Vector3 vector3 = Vector3.LerpUnclamped((Vector3)transform, vector, _003Cfactor_003E5__3);
					((Vector3*)(nint)vector)->x = (float)obj;
					Vector3 vector4 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector3*)(nint)vector4)->z = 0f;
					Vector3 eulerAngles = ((Transform)vector).eulerAngles;
					object obj9 = this + 12;
					obj9 = 0;
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

	private sealed class _003CHideInAppPurchaceOverlayDelayedCoroutine_003Ed__208(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected Obj, but got Unknown
				//IL_006b: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003E4__this.DelayedHideInAppPurchaseOverlay();
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 2f;
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

	private sealed class _003CHideAdsOverlayWithDelay_003Ed__213(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Expected Obj, but got Unknown
				//IL_007a: Expected Obj, but got VT
				//IL_008e: Expected Obj, but got I4
				UIScreenController uIScreenController = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						uIScreenController.adsOverlay.tag = null;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				Wait.Config.TimeConfig timeConfig = Wait.For(delay);
				obj = timeConfig;
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

	private sealed class _003CHideTransitionAdsOverlayWithDelay_003Ed__218(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected Obj, but got Unknown
				//IL_006c: Expected Obj, but got I4
				UIScreenController uIScreenController = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						uIScreenController.transitionAdsOverlay.tag = null;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
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

	private sealed class _003CDelayInputOnOverlay_003Ed__232(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIScreenController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Expected Obj, but got VT
				//IL_0081: Expected Obj, but got I4
				//IL_00ad: Expected Obj, but got I4
				//IL_00ad: Expected Obj, but got I
				//IL_00bb: Expected I, but got Obj
				//IL_00d1: Expected Obj, but got I
				//IL_0196: Expected I4, but got Obj
				//IL_0196: Expected Obj, but got I
				//IL_00fc: Expected I, but got Obj
				UIScreenController uIScreenController = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UIScreenController)+100]");
						((GameObject)0).tag = (string)1;
						nint num = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v12 (Il2CppClass<Strings>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v19 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text = Strings.GetDefault("AD_OVERLAY_CANCEL");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UIScreenController)+104]");
						((UILabel)0).fontSize = (int)text;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj2 = this + 12;
				Wait.Config.TimeConfig timeConfig = Wait.For(4f);
				Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)timeConfig);
				obj2 = coroutine;
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

	private const string SCREEN_RESOURCE_PATH = "Prefabs/Screens/";

	private const string POPUP_RESOURCE_PATH = "Prefabs/Popups/";

	private static UIScreenController _instance;

	public GameObject backgroundAnchor;

	public GameObject screenAnchor;

	public GameObject popupAnchor;

	public GameObject superPopupAnchor;

	public UICamera nguiCamera;

	public Camera Camera3D;

	public Camera CameraOverlay2dClipping;

	public Camera CameraOverlay2d;

	public Camera CameraCelebration;

	public Camera Camera2DNormal;

	public Camera Camera3DOverlay;

	public Camera Camera3DClip;

	public UIRoot root;

	public GameObject MenuElements3D;

	public bool LoadMenuOnStart;

	public Font FloatingTextFont;

	private Camera mainCamera;

	private static Action<string> m_OnChangedScreen;

	private static Action<string> m_OnNavigatedToScreen;

	private static Action<string> m_OnWillShowScreen;

	private static Action<string> m_OnWillNavigateToScreen;

	private Font lilitaRegularFont;

	private Font titanRegularFont;

	private bool _isApplicationFocused;

	private static readonly List<string> PAYOUT_DISALLOWED_SCREENS;

	private static bool _facebookPayoutPopupQueued;

	private static Action m_OnAwake;

	private static Action m_OnApplicationPaused;

	private static Action m_OnApplicationResumed;

	private static Action<string> m_OnPopupShown;

	private static Action m_OnLastPopupClosed;

	private static Action<string> m_OnPopupClosed;

	private Dictionary<string, UIScreen> _cachedScreens;

	private List<string> _screenStack;

	private List<string> _popupQueue;

	private List<string> _delayedPopups;

	private bool _popupActive;

	private List<UISlideIn> _allSlideIns;

	private List<string> _screenNamesWithoutBackground;

	public const string DEFAULT_CHARACTER_SET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

	public const int DEFAULT_SIZE = 16;

	public const FontStyle DEFAULT_STYLE = FontStyle.Normal;

	public const string DOUBLE_UP_2X_TEXT = "2x";

	private bool _isApplicationResuming;

	private bool _isApplicationPaused;

	public bool justPaidOutTopRun;

	private bool _hasShownFrontScreenBefore;

	public bool stoppingFromEditor;

	private List<string> _excludedScreensFromClear;

	public bool doSaveAndDelayRemainingPopups;

	public bool ignoreLastPopupClosed;

	private UISlideInMissionHelper _missionSlideIn;

	private UISlideInMissionSetHelper _missionSetSlideIn;

	private UISlideInLettersHelper _lettersSlideIn;

	private UISlideInUnlock _unlockSlideIn;

	private UISlideInErrorMessage _errorSlideIn;

	private UISlideInOfferPayoutHelper _offerWallSlideIn;

	private UISlideInItemHunt _weeklyHuntSlideIn;

	private UISlideInBrag _bragSlideIn;

	private UISlideInVideoPayoutHelper _videoPayoutSlideIn;

	private UISlideInAwards _awardsSlideIn;

	private UISlideInFacebook _facebookSlideIn;

	private UISlideInTopRunTimer _topRunTimerSlideIn;

	private UISlideInCharacterEventHelper _characterEventSlideIn;

	private UISlideInCharacterEventRewardHelper _characterEventRewardSlideIn;

	private UISlideInAdsRemoved _adsRemovedSlideIn;

	private UISlideInGift _giftSlideIn;

	private UiSlideInFirstPurchaseBonus _firstPurchaseBonusSlideIn;

	private UISlideInCloudSave _cloudSaveSlideIn;

	private UISlideInCloudSaveMessage _cloudSaveMessageSlideIn;

	private List<SlideIn> _slideInQueue;

	private bool _slideInActive;

	private bool _slideHasPreloaded;

	private List<SlideInData.SlideInType> _uniqueSlideInTypes;

	public UIMessageHelper messageHelper;

	private Queue<string> _messageQueue;

	private bool _messageShowing;

	public GameObject inAppPurchaseOverlay;

	public GameObject adsOverlay;

	private GameObject transitionAdsOverlay;

	private IEnumerator _transitionAdsOverlayCoroutine;

	public GameObject videoAdsOverlay;

	public GameObject videoAdsOverlayCloseButton;

	public UILabel videoAdsOverlayLabel;

	private bool _allowInputOnVideoAdsOverlay;

	private string _provider;

	private string _locationID;

	private IEnumerator _videoAdsOverlayInputCoroutine;

	private Action m_OnOverlayManuallyClosed;

	private GameObject generalDebugLabel;

	public static Vector3 popupDefaultPosition;

	public static Vector3 celebrationPopupPosition;

	public static Vector2 savemePopupPosition;

	public static bool IsInstanced
	{
		get
		{
			//IL_00f4: Expected I, but got Obj
			//IL_010a: Expected Obj, but got I
			//IL_00e6: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_013e: Expected I, but got Obj
			//IL_0154: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)UIModelController._instance))
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIModelController uIModelController = UnityEngine.Object.FindObjectOfType<UIModelController>();
				nint num5 = (nint)typeof(UIModelController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v25 (Il2CppClass<UIModelController>)+5C]");
				object obj3 = (nint)0 + (nint)8;
				obj3 = uIModelController;
				UIModelController._instance._002Ector();
			}
			return (byte)(int)UIModelController._instance != 0;
		}
	}

	public unsafe static UIScreenController Instance
	{
		get
		{
			//IL_026f: Expected I, but got Obj
			//IL_0285: Expected Obj, but got I
			//IL_03c0: Expected I, but got Obj
			//IL_03d6: Expected Obj, but got I
			//IL_043d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0442: Expected I, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_02b0: Expected I, but got Obj
			//IL_02c6: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0401: Expected I, but got Obj
			//IL_0417: Expected Obj, but got I
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0479: Expected Obj, but got I4
			//IL_01d5: Expected I, but got Obj
			//IL_02fe: Expected I, but got Obj
			//IL_0319: Expected I, but got Obj
			//IL_032f: Expected Obj, but got I
			//IL_0222: Expected I, but got Obj
			//IL_0367: Expected I, but got Obj
			//IL_037d: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_013b: Expected I, but got Obj
			//IL_0188: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v62 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = default;
			nint num5 = (nint)(obj3 + 4);
			if (_instance != null)
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v36 (Il2CppClass<System.Type>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v58 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = typeof(UIScreenController);
				((IntPtr*)num5)->m_value = (void*)(nint)obj3;
				Type type = Type.internal_from_handle((IntPtr)num5);
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = ((UnityEngine.Object)(object)type).ToString();
				nint num10 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v46 (Il2CppClass<UIScreenController>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v52 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
				UIScreenController instance = default;
				_instance = instance;
			}
			nint num12 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v19 (Il2CppClass<UIScreenController>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num13 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v27 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (UIScreenController)((ComputeShader)(object)_instance).FindKernel((string)null);
		}
	}

	public bool IsApplicationFocused
	{
		get
		{
			//IL_0031: Expected Obj, but got I
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected I4, but got Unknown
			GameObject gameObject = superPopupAnchor;
			GameObject gameObject2 = screenAnchor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (UnityEngine.GameObject)+64]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2 (UnityEngine.GameObject)+64]");
			object obj = num + 0;
			return (byte)(obj - 5) != 0;
		}
	}

	public bool IsApplicationPaused => _isApplicationFocused;

	public bool isShowingPopup
	{
		get
		{
			//IL_0010: Expected I4, but got Obj
			return (byte)(int)((UIScreenController)null).Dequeue(_popupQueue) != 0;
		}
	}

	public static Vector3 screenDefaultPosition
	{
		get
		{
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_00af: Expected VT, but got Obj
			//IL_00cd: Expected Obj, but got I
			//IL_00f4: Expected Obj, but got I4
			//IL_00f4: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0043: Expected VT, but got Obj
			//IL_0069: Expected VT, but got Obj
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			Vector3 result = (Vector3)typeof(Globals);
			if (!flag)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<Globals>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				result = (Vector3)typeof(Globals);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					result = (Vector3)typeof(Globals);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v2 (UnityEngine.Vector3)+5C]");
			object obj2 = 0;
			bool flag4 = obj2 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ L0+11C]");
			((GameObject)0).tag = (string)flag4;
			return result;
		}
	}

	public static event Action<string> OnChangedScreen
	{
		add
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnChangedScreen;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> OnNavigatedToScreen
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnChangedScreen;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnNavigatedToScreen;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> OnWillShowScreen
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnNavigatedToScreen;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnWillShowScreen;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> OnWillNavigateToScreen
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnWillShowScreen;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)12;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnWillNavigateToScreen;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)16;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnAwake
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnWillNavigateToScreen;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)16;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnAwake;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)28;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnApplicationPaused
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnAwake;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)28;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnApplicationPaused;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)32;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnApplicationResumed
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnApplicationPaused;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)32;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnApplicationResumed;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)36;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> OnPopupShown
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnApplicationResumed;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)36;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnPopupShown;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)40;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnLastPopupClosed
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnPopupShown;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)40;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnLastPopupClosed;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)44;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<string> OnPopupClosed
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnLastPopupClosed;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)44;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = UIScreenController.m_OnPopupClosed;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(UIScreenController);
				if (!flag)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(UIScreenController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(UIScreenController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
				object obj5 = (nint)0 + (nint)48;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public event Action OnOverlayManuallyClosed
	{
		add
		{
			//IL_01be: Expected I, but got Obj
			//IL_01d4: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_01fc: Expected Obj, but got VT
			//IL_0111: Expected Obj, but got I4
			//IL_011f: Expected I, but got Obj
			//IL_0135: Expected Obj, but got I
			//IL_00b0: Expected I, but got Obj
			//IL_0236: Expected Obj, but got I
			//IL_00fc: Expected I4, but got Obj
			//IL_00fc: Expected Obj, but got VT
			//IL_0160: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)inAppPurchaseOverlay).FindKernel((string)null) == 0)
			{
				return;
			}
			_0021_00210 componentInChildren = (_0021_00210)inAppPurchaseOverlay.GetComponentInChildren<T>();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
			{
				((InRunAverageFPSCounter)componentInChildren).PauseChange((byte)(int)value != 0);
			}
			inAppPurchaseOverlay.tag = (string)1;
			nint num5 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v23 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v34 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v28 (System.Boolean)+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v29+8]");
			if ((nint)0 == 0)
			{
				Camera3D.tag = null;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnOverlayManuallyClosed;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 280;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private void Awake()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = UIScreenController.m_OnPopupClosed;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(UIScreenController);
			if (!flag)
			{
				nint num5 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(UIScreenController);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(UIScreenController);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UIScreenController>)+5C]");
			object obj5 = (nint)0 + (nint)48;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	public unsafe void RequestCharactersForDoubleUpButton()
	{
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_0652: Expected I, but got Obj
		//IL_0668: Expected Obj, but got I
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected Obj, but got Unknown
		//IL_06c7: Expected I, but got Obj
		//IL_06dd: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_0123: Expected I, but got Obj
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0170: Expected I, but got Obj
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0773: Expected I, but got Obj
		//IL_0789: Expected Obj, but got I
		//IL_0237: Expected I, but got Obj
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0317: Expected I, but got Obj
		//IL_032d: Expected Obj, but got I
		//IL_02a5: Expected I, but got Obj
		//IL_03c4: Expected I, but got Obj
		//IL_03da: Expected Obj, but got I
		//IL_0358: Expected I, but got Obj
		//IL_07e1: Expected I, but got Obj
		//IL_07f7: Expected Obj, but got I
		//IL_0405: Expected I, but got Obj
		//IL_0822: Expected I, but got Obj
		//IL_0838: Expected Obj, but got I
		//IL_0452: Expected I, but got Obj
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected Obj, but got Unknown
		//IL_091a: Expected I, but got Obj
		//IL_0930: Expected Obj, but got I
		//IL_049f: Expected I, but got Obj
		//IL_04b5: Expected Obj, but got I
		//IL_052d: Expected I, but got Obj
		//IL_057a: Expected I, but got Obj
		//IL_04e0: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		MissionsManager.MissionCompleteHandler missionCompleteHandler = default;
		((Delegate)missionCompleteHandler).method_ptr = method_ptr;
		((Delegate)missionCompleteHandler).method = (nint)__ldftn(UIScreenController.OnMissionCompleted);
		object obj = missionCompleteHandler + 16;
		obj = this;
		MissionsManager.onMissionComplete -= missionCompleteHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		MissionsManager.MissionSetCompleteHandler missionSetCompleteHandler = default;
		((Delegate)missionSetCompleteHandler).method_ptr = method_ptr2;
		((Delegate)missionSetCompleteHandler).method = (nint)__ldftn(UIScreenController.OnMissionSetCompleted);
		object obj2 = missionSetCompleteHandler + 16;
		obj2 = this;
		MissionsManager.onMissionSetComplete -= missionSetCompleteHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr3;
		((Delegate)action).method = (nint)__ldftn(UIScreenController.OnLetterPickedUp);
		object obj3 = action + 16;
		obj3 = this;
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v26 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v167 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WordHuntManager.OnPickedUpLetter -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<Characters.CharacterId> action2 = default;
		object obj5 = action2 + 16;
		obj5 = this;
		nint num4 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v41 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v163 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterManager.characterTokenCollected -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj7 = action3 + 16;
		obj7 = this;
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v56 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v159 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnWillNavigateToScreen -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<RefreshType> action4 = default;
		object obj9 = action4 + 16;
		obj9 = this;
		AppRefreshHandler.willRefresh -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num10 = 0;
		_ = 0;
		Action<RefreshType> action5 = default;
		object obj10 = action5 + 16;
		obj10 = this;
		AppRefreshHandler.hasRefreshed -= action5;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v115 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mainCamera != null)
		{
			object obj12 = this + 76;
			Camera current = Camera.current;
			obj12 = current;
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v108 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)lilitaRegularFont).FindKernel((string)null) != 0)
		{
			((UnityEngine.Bindings.NativeMethodAttribute)(object)lilitaRegularFont)._002Ector("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", true, false);
			OnApplicationQuit();
		}
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S1_v101 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)titanRegularFont).FindKernel((string)null) != 0)
		{
			((UnityEngine.Bindings.NativeMethodAttribute)(object)titanRegularFont)._002Ector("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", true, false);
		}
		nint num17 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v94 (Il2CppClass<UIScreenController>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num18 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v146 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num19 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num20 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S1_v95 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_instance).FindKernel((string)null) != 0)
		{
			nint num21 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v134 (Il2CppClass<UIScreenController>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num22 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v140 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_instance = this;
		}
		nint num23 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v104 (Il2CppClass<UIScreenController>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num24 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v127 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)UIScreenController.m_OnAwake);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr4 = 0;
		Action action6 = default;
		((Delegate)action6).method_ptr = method_ptr4;
		((Delegate)action6).method = (nint)__ldftn(UIScreenController._003CAwake_003Eb__78_0);
		object obj19 = action6 + 16;
		obj19 = this;
		nint num25 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S0_v118 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num26 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v123 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSave.stateChanged -= action6;
	}

	private unsafe void OnWillRefresh(RefreshType refreshType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00c1: Invalid comparison between I4 and F4
		//IL_0439: Invalid comparison between I4 and F4
		//IL_0497: Expected Obj, but got I4
		//IL_033a: Expected Obj, but got I4
		//IL_020a: Invalid comparison between I4 and F4
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected Obj, but got Unknown
		//IL_0915: Expected F4, but got Obj
		//IL_0910: Expected native int or pointer, but got VT
		//IL_0959: Expected I4, but got Obj
		//IL_0973: Expected F4, but got Obj
		//IL_096e: Expected native int or pointer, but got VT
		//IL_0988: Expected F4, but got I
		//IL_0983: Expected native int or pointer, but got VT
		//IL_09a2: Expected Obj, but got I
		//IL_0471: Expected Obj, but got I4
		//IL_047c: Expected Obj, but got I4
		//IL_0487: Expected I4, but got F4
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected Obj, but got Unknown
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_083c: Expected F4, but got Obj
		//IL_0837: Expected native int or pointer, but got VT
		//IL_0856: Expected I4, but got Obj
		//IL_0870: Expected F4, but got Obj
		//IL_086b: Expected native int or pointer, but got VT
		//IL_0885: Expected F4, but got I
		//IL_0880: Expected native int or pointer, but got VT
		//IL_089c: Expected F4, but got I4
		//IL_089c: Expected I4, but got VT
		//IL_089c: Expected Ref, but got VT
		//IL_010b: Expected Obj, but got I4
		//IL_0792: Expected I4, but got VT
		//IL_0792: Expected Ref, but got VT
		//IL_079f: Expected native int or pointer, but got VT
		//IL_07b1: Expected native int or pointer, but got VT
		//IL_07c3: Expected I4, but got VT
		//IL_04e5: Expected Obj, but got I
		//IL_04f2: Expected I4, but got Obj
		//IL_0511: Expected F4, but got I4
		//IL_050c: Expected native int or pointer, but got VT
		//IL_0526: Expected F4, but got I
		//IL_0521: Expected native int or pointer, but got VT
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected Obj, but got Unknown
		//IL_053e: Expected Obj, but got F4
		//IL_0581: Expected I4, but got F4
		//IL_058d: Expected I4, but got Obj
		//IL_03fd: Expected native int or pointer, but got VT
		//IL_040f: Expected native int or pointer, but got VT
		//IL_0429: Expected I4, but got VT
		//IL_0429: Expected Obj, but got I
		//IL_0388: Expected Obj, but got I
		//IL_0395: Expected I4, but got Obj
		//IL_03b4: Expected F4, but got I4
		//IL_03af: Expected native int or pointer, but got VT
		//IL_03c9: Expected F4, but got I
		//IL_03c4: Expected native int or pointer, but got VT
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03e1: Expected Obj, but got F4
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected Obj, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected Obj, but got Unknown
		//IL_06db: Expected F4, but got Obj
		//IL_06d6: Expected native int or pointer, but got VT
		//IL_071f: Expected I4, but got Obj
		//IL_0739: Expected F4, but got Obj
		//IL_0734: Expected native int or pointer, but got VT
		//IL_074e: Expected F4, but got I
		//IL_0749: Expected native int or pointer, but got VT
		//IL_0768: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I4
		//IL_0254: Expected I4, but got F4
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_0602: Expected F4, but got Obj
		//IL_05fd: Expected native int or pointer, but got VT
		//IL_061c: Expected I4, but got Obj
		//IL_0636: Expected F4, but got Obj
		//IL_0631: Expected native int or pointer, but got VT
		//IL_064b: Expected F4, but got I
		//IL_0646: Expected native int or pointer, but got VT
		//IL_0662: Expected F4, but got I4
		//IL_0662: Expected I4, but got VT
		//IL_0662: Expected Ref, but got VT
		//IL_02ae: Expected Obj, but got I
		//IL_02bb: Expected I4, but got Obj
		//IL_02da: Expected F4, but got I4
		//IL_02d5: Expected native int or pointer, but got VT
		//IL_02ef: Expected F4, but got I
		//IL_02ea: Expected native int or pointer, but got VT
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0307: Expected Obj, but got F4
		//IL_01ce: Expected native int or pointer, but got VT
		//IL_01e0: Expected native int or pointer, but got VT
		//IL_01fa: Expected I4, but got VT
		//IL_01fa: Expected Obj, but got I
		//IL_0159: Expected Obj, but got I
		//IL_0166: Expected I4, but got Obj
		//IL_0185: Expected F4, but got I4
		//IL_0180: Expected native int or pointer, but got VT
		//IL_019a: Expected F4, but got I
		//IL_0195: Expected native int or pointer, but got VT
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01b2: Expected Obj, but got F4
		Matrix4x4 matrix4x2 = default;
		Matrix4x4 matrix4x = (Matrix4x4)(matrix4x2 + 152);
		int num = matrix4x2 + 136;
		object obj = matrix4x2 + 40;
		object obj2 = matrix4x2 + 32;
		object obj3 = matrix4x2 + 16;
		object obj4 = matrix4x2 + 132;
		object obj5 = matrix4x2 + 128;
		object obj6 = matrix4x2 + 112;
		object obj7 = matrix4x2 + 96;
		object obj8 = matrix4x2 + 92;
		object obj9 = matrix4x2 + 88;
		object obj10 = matrix4x2 + 72;
		object obj11 = matrix4x2 + 56;
		bool flag = !((float)(_popupActive ? 1 : 0) > 1f);
		bool popupActive;
		UIWidget uIWidget;
		if (refreshType != 0)
		{
			if (flag)
			{
				titanRegularFont = (Font)1;
				if ((nint)titanRegularFont != (_isApplicationFocused ? 1 : 0))
				{
					int sliderWidth = ((UIPowerupHelper)this).getSliderWidth();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v200 (System.Int32)+38]");
					object obj12 = (nint)0 + (nint)80;
					((int*)num)->m_value = (int)obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v202+8]");
					_ = 0;
					((Matrix4x4*)(nint)matrix4x)->m00 = ((int*)num)->m_value;
					Matrix4x4 matrix4x3 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (System.Int32)+8]");
					((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
					object obj13 = this + 92;
					obj13 = matrix4x.m00;
					_ = matrix4x.m20;
				}
				int sliderWidth2 = ((UIPowerupHelper)this).getSliderWidth();
				object obj14 = this + 92;
				obj = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S2_v60+8]");
				_ = 0;
				object obj15 = lilitaRegularFont + 16;
				object obj16 = (object)titanRegularFont << 2;
				object obj17 = obj15 + obj16;
				obj2 = obj17;
				obj4 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
				((int*)num)->m_value = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
				Matrix4x4 matrix4x5 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
				((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
				((Matrix4x4*)matrix4x2)->set_Item(num, (int)matrix4x, (float)(_popupActive ? 1 : 0));
				((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
				((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v142 (System.Int32)+38]");
				((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
			}
			else
			{
				if (!((float)(_popupActive ? 1 : 0) > 2f))
				{
					titanRegularFont = null;
					if ((nint)titanRegularFont != (_isApplicationFocused ? 1 : 0))
					{
						int sliderWidth3 = ((UIPowerupHelper)this).getSliderWidth();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S1_v160 (System.Int32)+38]");
						object obj18 = (nint)0 + (nint)80;
						((int*)num)->m_value = (int)obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v162+8]");
						_ = 0;
						((Matrix4x4*)(nint)matrix4x)->m00 = ((int*)num)->m_value;
						Matrix4x4 matrix4x6 = matrix4x;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (System.Int32)+8]");
						((Matrix4x4*)(nint)matrix4x6)->m20 = 0f;
						object obj19 = this + 92;
						obj19 = matrix4x.m00;
						_ = matrix4x.m20;
					}
					int sliderWidth4 = ((UIPowerupHelper)this).getSliderWidth();
					object obj20 = this + 92;
					obj = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S1_v129+8]");
					_ = 0;
					object obj21 = lilitaRegularFont + 16;
					object obj22 = (object)titanRegularFont << 2;
					object obj23 = obj21 + obj22;
					obj2 = obj23;
					obj5 = obj2;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
					Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
					obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
					_ = 0;
					obj7 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
					_ = 0;
					((int*)num)->m_value = (int)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19+8]");
					_ = 0;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
					Matrix4x4 matrix4x8 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21+8]");
					((Matrix4x4*)(nint)matrix4x8)->m20 = 0f;
					popupActive = _popupActive;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v108 (System.Int32)+38]");
					uIWidget = (UIWidget)0;
					goto IL_076d;
				}
				titanRegularFont = (Font)3;
				FloatingTextFont = null;
				_popupActive = false;
			}
		}
		else if (flag)
		{
			titanRegularFont = (Font)1;
			if ((nint)titanRegularFont != (_isApplicationFocused ? 1 : 0))
			{
				int sliderWidth5 = ((UIPowerupHelper)this).getSliderWidth();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v107 (System.Int32)+38]");
				object obj24 = (nint)0 + (nint)80;
				((int*)num)->m_value = (int)obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S1_v109+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = ((int*)num)->m_value;
				Matrix4x4 matrix4x9 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (System.Int32)+8]");
				((Matrix4x4*)(nint)matrix4x9)->m20 = 0f;
				object obj25 = this + 92;
				obj25 = matrix4x.m00;
				_ = matrix4x.m20;
			}
			int sliderWidth6 = ((UIPowerupHelper)this).getSliderWidth();
			object obj26 = this + 92;
			obj = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S2_v19+8]");
			_ = 0;
			object obj27 = lilitaRegularFont + 16;
			object obj28 = (object)titanRegularFont << 2;
			object obj29 = obj27 + obj28;
			obj2 = obj29;
			obj8 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
			Matrix4x4 matrix4x10 = Matrix4x4.Inverse(matrix4x);
			((int*)num)->m_value = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			_ = 0;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x11 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x11)->m20 = 0f;
			((Matrix4x4*)matrix4x2)->set_Item(num, (int)matrix4x, (float)(_popupActive ? 1 : 0));
			((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
			((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v88 (System.Int32)+38]");
			((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		}
		else
		{
			if (!((float)(_popupActive ? 1 : 0) > 2f))
			{
				titanRegularFont = (Font)2;
				if ((nint)titanRegularFont != (_isApplicationFocused ? 1 : 0))
				{
					int sliderWidth7 = ((UIPowerupHelper)this).getSliderWidth();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S1_v67 (System.Int32)+38]");
					object obj30 = (nint)0 + (nint)80;
					((int*)num)->m_value = (int)obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S1_v69+8]");
					_ = 0;
					((Matrix4x4*)(nint)matrix4x)->m00 = ((int*)num)->m_value;
					Matrix4x4 matrix4x12 = matrix4x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (System.Int32)+8]");
					((Matrix4x4*)(nint)matrix4x12)->m20 = 0f;
					object obj31 = this + 92;
					obj31 = matrix4x.m00;
					_ = matrix4x.m20;
				}
				int sliderWidth8 = ((UIPowerupHelper)this).getSliderWidth();
				object obj32 = this + 92;
				obj = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S1_v36+8]");
				_ = 0;
				object obj33 = lilitaRegularFont + 16;
				object obj34 = (object)titanRegularFont << 2;
				object obj35 = obj33 + obj34;
				obj2 = obj35;
				obj9 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
				Matrix4x4 matrix4x13 = Matrix4x4.Inverse(matrix4x);
				obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
				_ = 0;
				obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
				_ = 0;
				((int*)num)->m_value = (int)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v27+8]");
				_ = 0;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
				Matrix4x4 matrix4x14 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v29+8]");
				((Matrix4x4*)(nint)matrix4x14)->m20 = 0f;
				popupActive = _popupActive;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v54 (System.Int32)+38]");
				uIWidget = (UIWidget)0;
				goto IL_076d;
			}
			titanRegularFont = (Font)3;
			FloatingTextFont = (Font)1;
			_popupActive = false;
		}
		goto IL_054d;
		IL_054d:
		float unscaledTime = Time.unscaledTime;
		float num2 = unscaledTime * 8.2343f;
		float num3 = (float)(_popupActive ? 1 : 0) + num2;
		_popupActive = (byte)(int)num3 != 0;
		_isApplicationFocused = (byte)(int)titanRegularFont != 0;
		return;
		IL_076d:
		float value = (float)(popupActive ? 1 : 0) - 1f;
		((Matrix4x4*)matrix4x2)->set_Item(num, (int)matrix4x, value);
		((Matrix4x4*)(nint)matrix4x)->m00 = matrix4x2.m00;
		((Matrix4x4*)(nint)matrix4x)->m20 = matrix4x2.m20;
		uIWidget.rawPivot = (UIWidget.Pivot)matrix4x;
		goto IL_054d;
	}

	private void OnHasRefreshed(RefreshType refreshType)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = refreshType;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			ignoreLastPopupClosed = true;
			ClearSlideIns();
			TryQueuePayoutPopups();
		}
	}

	private void OnApplicationQuit()
	{
		((UnityEngine.Bindings.NativeMethodAttribute)(object)lilitaRegularFont)._002Ector("CELEBRATION_POPUP_DOUBLE_UP", true, false);
		((UnityEngine.Bindings.NativeMethodAttribute)(object)lilitaRegularFont)._002Ector("CELEBRATION_POPUP_STICKER_BONUS", true, false);
		((UnityEngine.Bindings.NativeMethodAttribute)(object)lilitaRegularFont)._002Ector("2x", true, false);
	}

	private void OnDestroy()
	{
	}

	private unsafe void Start()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_0297: Expected Obj, but got I4
		//IL_02aa: Expected I, but got Obj
		//IL_02c0: Expected Obj, but got I
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0333: Expected I, but got Obj
		//IL_0349: Expected Obj, but got I
		//IL_0129: Expected I, but got Obj
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_0176: Expected I, but got Obj
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_01c3: Expected I, but got Obj
		if (~(stoppingFromEditor ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		MissionsManager missionsManager = default;
		missionsManager._currentMissionTemplateSetLoaded = (int)num;
		missionsManager._defaultMissionIndexUpdateInterval = 0;
		object obj = missionsManager + 16;
		obj = this;
		missionsManager._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		MissionsManager.MissionCompleteHandler missionCompleteHandler = default;
		((Delegate)missionCompleteHandler).method_ptr = method_ptr;
		((Delegate)missionCompleteHandler).method = (nint)__ldftn(UIScreenController.OnMissionSetCompleted);
		object obj2 = missionCompleteHandler + 16;
		obj2 = this;
		MissionsManager.onMissionComplete += missionCompleteHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr2;
		((Delegate)action).method = (nint)__ldftn(UIScreenController.OnLetterPickedUp);
		object obj3 = action + 16;
		obj3 = this;
		nint num2 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v30 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v93 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WordHuntManager.OnDailyWordInRowChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Characters.CharacterId characterId = default;
		object obj5 = characterId + 16;
		obj5 = this;
		nint num5 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v45 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v89 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterManager.UnlockCharacter(characterId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr3;
		((Delegate)action2).method = (nint)__ldftn(UIScreenController.OnWillNavigateToScreenHandler);
		object obj7 = action2 + 16;
		obj7 = this;
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v60 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v85 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnAwake += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		Action<RefreshType> action3 = default;
		object obj9 = action3 + 16;
		obj9 = this;
		AppRefreshHandler.refresh += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		AnimationPlayAfterDelay animationPlayAfterDelay = default;
		((UnityEngine.Object)animationPlayAfterDelay).m_CachedPtr = cachedPtr;
		_ = 0;
		object obj10 = animationPlayAfterDelay + 16;
		obj10 = this;
		animationPlayAfterDelay.OnEnable();
	}

	private unsafe void _SetApplicationPause(bool isApplicationPaused)
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a1: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_00ad: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0185: Expected Obj, but got I4
		//IL_0135: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = isApplicationPaused;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			OnMissionSetCompleted();
			if (~(_hasShownFrontScreenBefore ? 1u : 0u) == 0)
			{
				string text = Peek((List<string>)(object)"FrontScreen");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			string text2 = default;
			text2.m_stringLength = (int)num;
			_ = 0;
			object obj4 = text2 + 16;
			obj4 = this;
			Timer.Log(text2);
		}
		obj = isApplicationPaused;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj5 = default;
		IFormatProvider provider2 = default;
		if (!obj5.System_002EIConvertible_002EToBoolean(provider2))
		{
			return;
		}
		nint num2 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v23 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v29 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool running = FirstPurchaseBonusManager.running;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
		((CoinScreen)running).InsertEarner((int)currentBoardId, ref *(int*)(int)currentCharacterId);
	}

	private void _SetApplicationFocus(bool _isApplicationFocus)
	{
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		if (_isApplicationFocus)
		{
			_isApplicationPaused = true;
			nint num = (nint)typeof(UpdateApp);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UpdateApp>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UpdateApp);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v31 (Il2CppClass<UpdateApp>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UpdateApp.ShowIfNeeded();
			ShowMainMenu();
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v25 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TransformExtensions.Reset((Transform)(object)UIScreenController.m_OnApplicationPaused);
		}
		else
		{
			_isApplicationPaused = false;
		}
		bool isApplicationPaused = _isApplicationPaused;
		bool isApplicationResuming = (byte)((isApplicationPaused ? 1u : 0u) ^ 1u) != 0;
		_isApplicationResuming = isApplicationResuming;
	}

	public void DebugSetApplicationPause(bool isApplicationPaused)
	{
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I4
		//IL_00c8: Expected I, but got Obj
		//IL_0155: Expected I, but got Obj
		//IL_016b: Expected Obj, but got I
		//IL_0285: Expected Obj, but got I4
		//IL_0196: Expected I, but got Obj
		//IL_01de: Expected VT, but got Obj
		//IL_01ec: Expected Obj, but got VT
		_isApplicationFocused = isApplicationPaused;
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 7)
		{
			return;
		}
		string dataPath2 = Application.dataPath;
		if (dataPath2 == null)
		{
			return;
		}
		bool isApplicationFocus = (byte)((isApplicationPaused ? 1u : 0u) ^ 1u) != 0;
		_SetApplicationFocus(isApplicationFocus);
		string dataPath3 = Application.dataPath;
		if ((nint)dataPath3 != 11)
		{
			return;
		}
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v17 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v45 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool iOSOtherAudioPlaying = DeviceUtility.GetIOSOtherAudioPlaying();
		object obj2 = iOSOtherAudioPlaying | isApplicationPaused;
		if (obj2 != null)
		{
			return;
		}
		string text = ((UIScreenController)null).Pop(_screenStack);
		if (!(text != "IngameUI"))
		{
			return;
		}
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v29 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v41 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		object obj4 = (isInstantiated ? 1 : 0) - -64;
		if (obj4 == null)
		{
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((TimeScaleManager)val).TimeScaleInMenuDefault = 0f;
		}
	}

	public void DebugSetApplicationFocus(bool isApplicationFocused)
	{
		_SetApplicationFocus(isApplicationFocused);
	}

	private void LateUpdate()
	{
		//IL_0051: Expected Obj, but got I4
		//IL_01cf: Expected I, but got Obj
		//IL_01e5: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I4
		//IL_0210: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I4
		//IL_0141: Expected I, but got Obj
		//IL_0157: Expected Obj, but got I
		//IL_0182: Expected I, but got Obj
		DelayedHideInAppPurchaseOverlay();
		if (~(LoadMenuOnStart ? 1u : 0u) == 0)
		{
			GameOverTriggered();
		}
		int bragScoreThreshold = PlayerSave.bragScoreThreshold;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745B");
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		int currentMissionSet = ((MissionsManager)(object)instance).currentMissionSet;
		object obj = currentMissionSet + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+24]");
		if ((nint)0 != 0)
		{
			object obj2 = currentMissionSet + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v32+24]");
			if ((nint)0 != 0)
			{
				object obj3 = currentMissionSet + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v35+24]");
				if ((nint)0 != 0)
				{
					int missionsVersion = PlayerSave.missionsVersion;
					int missionsVersion2 = missionsVersion + 1;
					PlayerSave.missionsVersion = missionsVersion2;
					StayInOneLaneMission instance2 = StayInOneLaneMission.instance;
					int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
					int mission = currentSkipForVideoMissionIndex + 1;
					((MissionsManager)(object)instance2).TestGoToMissionSum(mission);
					nint num = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v43 (Il2CppClass<UIScreenController>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num2 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v46 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
				}
			}
		}
		OnMissionSetCompleted();
		LogFlurry();
		Vector3 vector = screenDefaultPosition;
		nint num3 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v21 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v27 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		char newDailyLetter = WordHuntManager.GetNewDailyLetter();
		((WordHuntManager)newDailyLetter).DownloadDailyIfExpired();
	}

	private void OnApplicationPause(bool isApplicationPaused)
	{
		DebugSetApplicationPause(isApplicationPaused);
	}

	private void OnApplicationFocus(bool isFocused)
	{
		_SetApplicationFocus(isFocused);
	}

	private void UpdateNguiTouchThresholds()
	{
		//IL_03ee: Expected I, but got Obj
		//IL_0404: Expected Obj, but got I
		//IL_0260: Expected I, but got Obj
		//IL_02ad: Expected I, but got Obj
		//IL_02c3: Expected Obj, but got I
		//IL_0098: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_02ee: Expected I, but got Obj
		//IL_035d: Expected I, but got Obj
		//IL_0373: Expected Obj, but got I
		//IL_039a: Expected Obj, but got I4
		//IL_00d9: Expected I, but got Obj
		//IL_0126: Expected I, but got Obj
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_03d2: Expected Obj, but got I4
		//IL_01b4: Expected I, but got Obj
		if (~(_isApplicationResuming ? 1u : 0u) != 0)
		{
			return;
		}
		_isApplicationResuming = false;
		List<string> screenStack = _screenStack;
		if (screenStack._size >= 1)
		{
			string text = ((UIScreenController)null).Pop(_screenStack);
			if (text != "IngameUI")
			{
				nint num = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v48 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v76 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated = Game.IsInstantiated;
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)isInstantiated).FindKernel(null) != 0)
				{
					nint num5 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v64 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v72 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated2 = Game.IsInstantiated;
					object obj4 = (isInstantiated2 ? 1 : 0) - -64;
					if (obj4 != null)
					{
						goto IL_03e0;
					}
				}
				if (~(_popupActive ? 1u : 0u) == 0)
				{
					string text2 = ((UIScreenController)null).Pop(_popupQueue);
					if (!(text2 == "ConsumablesPopup"))
					{
						goto IL_03e0;
					}
				}
				_ShowScreen(null, (UIScreen)(object)"PauseUI");
			}
		}
		goto IL_03e0;
		IL_03e0:
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UIScreenController.m_OnApplicationResumed == null)
		{
			return;
		}
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v25 (Il2CppClass<UIScreenController>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v32 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
	}

	private void LogFlurry()
	{
		float value = UnityEngine.Random.value;
		float touchClickThreshold;
		if (value > 0f)
		{
			float value2 = UnityEngine.Random.value;
			touchClickThreshold = 0.1f * value2;
		}
		else
		{
			touchClickThreshold = 30f;
		}
		UICamera uICamera = nguiCamera;
		uICamera.touchDragThreshold = 1f;
		UICamera uICamera2 = nguiCamera;
		uICamera2.touchClickThreshold = touchClickThreshold;
	}

	public void FacebookLogIn(bool loggedIn)
	{
		DebugSetApplicationPause(loggedIn);
	}

	public void ShowMainMenu()
	{
		//IL_03a0: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_01e7: Expected I, but got Obj
		//IL_01fd: Expected Obj, but got I
		//IL_011d: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0297: Expected I, but got Obj
		//IL_0228: Expected I, but got Obj
		//IL_0170: Expected I, but got Obj
		bool flag = isShowingPopup;
		IEnumerator enumerator = DelayHideMainCamera();
		string dataPath = Application.dataPath;
		if ((nint)dataPath != 11)
		{
			string dataPath2 = Application.dataPath;
		}
		bool flag2;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (flag2)
		{
			return;
		}
		bool flag3;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6 (System.Boolean)+8]");
			flag3 = (nint)0 == 0;
		}
		else
		{
			flag3 = true;
		}
		if (!flag3)
		{
			bool flag4;
			if (enumerator != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (System.Collections.IEnumerator)+8]");
				flag4 = (nint)0 == 0;
			}
			else
			{
				flag4 = true;
			}
			if (!flag4)
			{
				object obj = ((IConvertible)enumerator).ToType((Type)(object)"_", (IFormatProvider)flag);
				nint num = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v57 (Il2CppClass<Flurry>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v61 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return;
			}
		}
		bool flag5;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6 (System.Boolean)+8]");
			flag5 = (nint)0 == 0;
		}
		else
		{
			flag5 = true;
		}
		if (!flag5)
		{
			nint num3 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v39 (Il2CppClass<Flurry>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v43 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return;
		}
		if (enumerator != null)
		{
		}
		nint num5 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v27 (Il2CppClass<Flurry>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v30 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private IEnumerator ShowMainMenuCoroutine()
	{
		//IL_0019: Expected Obj, but got I4
		bool isApplicationPaused = _isApplicationPaused;
		return (IEnumerator)isApplicationPaused;
	}

	public void GameOverTriggered()
	{
		//IL_0014: Expected Obj, but got I4
		bool flag = IsCelebrationPopupBlocked();
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag);
	}

	public void QueueMessage(string message)
	{
		//IL_003e: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		if (message != null)
		{
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)55, (PersistentAwardProgress)1, (Action<Award>)(-1));
		}
	}

	public void GoToMainMenuFromGame(GameObject sender)
	{
		ShowInAppPurchaseOverlay((string)(object)sender);
	}

	private void PayWeeklyHuntIfNeeded()
	{
		IEnumerator a = DelayHideMainCamera();
		if (!string.Equals((string)(object)a, "GameOverScreen"))
		{
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			((GlobalColors)(object)privacyPolicyUrl)._002Ector();
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			((MissionsManager)(object)instance).RemoveProgressForThis(MissionTarget.none);
			string text = Peek((List<string>)(object)"GameOverScreen");
		}
	}

	public void PayoutCelebrationReward(CelebrationReward reward)
	{
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_021a: Expected I, but got Obj
		//IL_0230: Expected Obj, but got I
		//IL_01c2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_01f5: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_010a: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)isInstantiated).FindKernel(null) != 0)
		{
			StayInOneLaneMission instance = StayInOneLaneMission.instance;
			((MissionsManager)(object)instance).RemoveProgressForThis(MissionTarget.none);
			nint num5 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v20 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v28 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated2 = Game.IsInstantiated;
			((Game)isInstantiated2).Megaheadstart();
			bool isInstantiated3 = Game.IsInstantiated;
			((Game)isInstantiated3).HandleProductionInput(InputType.None);
		}
		BackToPrevious();
		string text = Peek((List<string>)(object)"FrontScreen");
	}

	public bool IsCelebrationPopupBlocked()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	public string GetTopScreenName()
	{
		//IL_00bd: Expected Obj, but got I4
		bool flag = isShowingPopup;
		bool flag2;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		IEnumerator screenName;
		if (flag2)
		{
			IEnumerator enumerator = DelayHideMainCamera();
			bool flag3;
			if (enumerator != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v9 (System.Collections.IEnumerator)+8]");
				flag3 = (nint)0 == 0;
			}
			else
			{
				flag3 = true;
			}
			if (flag3)
			{
				return null;
			}
			screenName = enumerator;
		}
		else
		{
			screenName = (IEnumerator)flag;
		}
		UIScreen uIScreen = _ActivateScreen((string)(object)screenName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string result = default;
		return result;
	}

	public UIScreen GetScreenFromCache(string screenName)
	{
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_00a8: Expected I, but got Obj
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0037: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		object obj2 = screenName & 1;
		if (obj2 != null)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v34 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float f = (float)screenName * 0.5f;
			int num3 = Mathf.FloorToInt(f);
			object obj3 = screenAnchor / 4;
			return (UIScreen)(num3 * obj3);
		}
		if (!flag)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float f2 = (float)screenName * 0.5f;
		int num5 = Mathf.FloorToInt(f2);
		object obj4 = num5 + 1;
		object obj5 = screenAnchor / 4;
		return (UIScreen)(obj4 * obj5);
	}

	public void PushScreen(string screenName)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_039b: Expected I, but got Obj
		//IL_03b1: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_01bb: Expected I, but got Obj
		//IL_01d1: Expected Obj, but got I
		//IL_0279: Expected Obj, but got I
		//IL_0300: Expected I, but got Obj
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_01fc: Expected I, but got Obj
		if (screenName.m_firstChar == '\n')
		{
			nint num = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<TopRunRewardHelper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v56 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((CollectCoinsCell)(object)screenName).UpdateCell();
			TopRunNotificationSlideInManager instance = TopRunNotificationSlideInManager.instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			TopRunNormalStateHelper topRunNormalStateHelper = default;
			topRunNormalStateHelper.InitNormalState();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		}
		else if (screenName.m_firstChar == '\u0002')
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenName @ L1 (System.String)+28]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenName @ L1 (System.String)+14]");
			InventorySave.AddPendingReward((CelebrationReward)num3, (Func<CelebrationRewardOrigin, int>)0);
		}
		else
		{
			if (screenName.m_firstChar == '\u0001')
			{
				object obj2 = screenName + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			if (screenName.m_firstChar == '\u0003')
			{
				nint num4 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S2_v8 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(CharacterManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v13 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenName @ L1 (System.String)+18]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenName @ L1 (System.String)+14]");
				CharacterManager.SetOutfitSelectionIndex((Characters.CharacterId)num6, 0);
			}
			else if (screenName.m_firstChar == '\u0004')
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [screenName @ L1 (System.String)+24]");
				PlayerSave.awardsProgress = (Dictionary<AwardId, PersistentAwardProgress>)0;
			}
			else if (screenName.m_firstChar == '\u0006')
			{
				object obj4 = screenName + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
		}
		nint num7 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v10 (Il2CppClass<RewardManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v15 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((SaveMePopup)(object)screenName).Init();
	}

	public void PushScreen(GameObject sender, string screenOverride)
	{
		//IL_003e: Expected I4, but got Obj
		//IL_004f: Expected I4, but got Obj
		//IL_0063: Expected I4, but got Obj
		//IL_00bd: Expected I4, but got Obj
		//IL_00e1: Expected Obj, but got I4
		if (((UnityEngine.Object)sender).m_CachedPtr != (IntPtr)1 || ((UnityEngine.Object)sender).m_CachedPtr != (IntPtr)24)
		{
			UIPowerupHelper uIPowerupHelper = ((List<UIPowerupHelper>)(object)superPopupAnchor).get_Item((int)screenOverride);
			uIPowerupHelper.FadingToWhiteToGreenToDarkGreen((byte)(int)sender != 0);
		}
		UIPowerupHelper uIPowerupHelper2 = ((List<UIPowerupHelper>)(object)superPopupAnchor).get_Item((int)screenOverride);
		string text = uIPowerupHelper2.tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 == null)
		{
			UIPowerupHelper uIPowerupHelper3 = ((List<UIPowerupHelper>)(object)superPopupAnchor).get_Item((int)screenOverride);
			string text3 = uIPowerupHelper3.tag;
			((GameObject)(object)text3).tag = (string)1;
		}
	}

	public void BackToPrevious()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0231: Expected Obj, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected Obj, but got Unknown
		//IL_0261: Expected I, but got Obj
		//IL_0277: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_0170: Expected Obj, but got I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<RewardManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v83 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int rewardsToUnlockCount = RewardManager.rewardsToUnlockCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 53)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				return;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private UIScreen _ActivateScreen(string screenName)
	{
		//IL_003d: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_005d: Expected Obj, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			return _cachedScreens.get_Item(screenName);
		}
		return null;
	}

	private void _ShowScreen(string screenName, UIScreen screen)
	{
		//IL_095c: Expected I4, but got Obj
		//IL_0996: Expected I, but got Obj
		//IL_09ac: Expected Obj, but got I
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_00d6: Expected I, but got Obj
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_00c3: Expected I4, but got Obj
		//IL_0061: Expected I, but got Obj
		//IL_09fc: Expected Obj, but got I4
		//IL_0171: Expected I, but got Obj
		//IL_0746: Expected I, but got Obj
		//IL_075c: Expected Obj, but got I
		//IL_0bc5: Expected I, but got Obj
		//IL_0bdb: Expected Obj, but got I
		//IL_0c02: Expected Obj, but got I4
		//IL_0787: Expected I, but got Obj
		//IL_07d4: Expected I, but got Obj
		//IL_0821: Expected I, but got Obj
		//IL_0837: Expected Obj, but got I
		//IL_024c: Expected I, but got Obj
		//IL_0262: Expected Obj, but got I
		//IL_027f: Expected I, but got Obj
		//IL_093b: Expected Obj, but got VT
		//IL_0c3a: Expected Obj, but got I4
		//IL_032f: Expected I, but got Obj
		//IL_0345: Expected Obj, but got I
		//IL_0362: Expected I, but got Obj
		//IL_0a91: Expected Obj, but got I
		//IL_0862: Expected I, but got Obj
		//IL_0af3: Expected I, but got Obj
		//IL_0b09: Expected Obj, but got I
		//IL_0b26: Expected I, but got Obj
		//IL_0412: Expected I, but got Obj
		//IL_0428: Expected Obj, but got I
		//IL_0445: Expected I, but got Obj
		//IL_0ab4: Expected Obj, but got I
		//IL_029b: Expected I, but got Obj
		//IL_02cb: Expected I, but got Obj
		//IL_0c9c: Expected Obj, but got I
		//IL_0ad7: Expected Obj, but got I
		//IL_037e: Expected I, but got Obj
		//IL_03ae: Expected I, but got Obj
		//IL_066c: Expected I, but got Obj
		//IL_069c: Expected I, but got Obj
		//IL_0461: Expected I, but got Obj
		//IL_0491: Expected I, but got Obj
		//IL_02f1: Expected I, but got Obj
		//IL_03d4: Expected I, but got Obj
		//IL_06c2: Expected I, but got Obj
		//IL_04b7: Expected I, but got Obj
		//IL_0b42: Expected I, but got Obj
		//IL_0b58: Expected Obj, but got I
		//IL_0b75: Expected I, but got Obj
		//IL_0cbf: Expected Obj, but got I
		//IL_0603: Expected I, but got Obj
		//IL_0633: Expected I, but got Obj
		//IL_0659: Expected I, but got Obj
		UIScreen uIScreen = default;
		if (((string)(object)uIScreen).get_Chars((int)"") == '\0')
		{
			UIButtonChangeScreen component = ((GameObject)(object)screenName).GetComponent<UIButtonChangeScreen>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v198 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v208 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3;
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				bool flag = component.ShowScreens();
				num3 = (flag ? 1 : 0);
			}
			else
			{
				num3 = (int)"";
			}
			uIScreen = (UIScreen)num3;
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v191 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)screenName).FindKernel((string)null) != 0)
		{
			BackBtnBehaviour component2 = ((GameObject)(object)screenName).GetComponent<BackBtnBehaviour>();
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v179 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v187 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
			{
				uIScreen = (UIScreen)(object)component2.screenNameToOpen;
			}
		}
		if ((string)(object)uIScreen != "FrontScreen")
		{
			IEnumerator enumerator = DelayHideMainCamera();
			bool flag2;
			if (enumerator != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v73 (System.Collections.IEnumerator)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (!flag2)
			{
				if ((string)(object)enumerator != "FriendsUI")
				{
					nint num8 = (nint)typeof(UIScreens);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v159 (Il2CppClass<UIScreens>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					bool flag3 = obj4 == null;
					nint num9 = (nint)typeof(UIScreens);
					if (!flag3)
					{
						nint num10 = (nint)typeof(UIScreens);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v166 (Il2CppClass<UIScreens>)+74]");
						bool flag4 = (nint)0 == 0;
						bool flag5 = !flag4;
						num9 = (nint)typeof(UIScreens);
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num9 = (nint)typeof(UIScreens);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ L1_v22 (Il2CppClass<UIScreens>)+5C]");
					object obj5 = (nint)0 + (nint)8;
					obj5 = enumerator;
				}
				else if ((string)(object)enumerator != "LeaderboardUI")
				{
					nint num11 = (nint)typeof(UIScreens);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v145 (Il2CppClass<UIScreens>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					bool flag6 = obj6 == null;
					nint num12 = (nint)typeof(UIScreens);
					if (!flag6)
					{
						nint num13 = (nint)typeof(UIScreens);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v152 (Il2CppClass<UIScreens>)+74]");
						bool flag7 = (nint)0 == 0;
						bool flag8 = !flag7;
						num12 = (nint)typeof(UIScreens);
						if (!flag8)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num12 = (nint)typeof(UIScreens);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ L1_v19 (Il2CppClass<UIScreens>)+5C]");
					object obj7 = (nint)0 + (nint)8;
					obj7 = enumerator;
				}
				else if ((string)(object)enumerator != "TopRunUI")
				{
					nint num14 = (nint)typeof(UIScreens);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v131 (Il2CppClass<UIScreens>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					bool flag9 = obj8 == null;
					nint num15 = (nint)typeof(UIScreens);
					if (!flag9)
					{
						nint num16 = (nint)typeof(UIScreens);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S0_v138 (Il2CppClass<UIScreens>)+74]");
						bool flag10 = (nint)0 == 0;
						bool flag11 = !flag10;
						num15 = (nint)typeof(UIScreens);
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num15 = (nint)typeof(UIScreens);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ L1_v16 (Il2CppClass<UIScreens>)+5C]");
					object obj9 = (nint)0 + (nint)8;
					obj9 = "TopRunUI";
				}
				else if (!((string)(object)enumerator != "CharacterScreen") && !((string)(object)enumerator != "BoardScreen") && !((string)(object)enumerator != "AwardsScreen"))
				{
					if ((string)(object)enumerator != "UpgradesUI_shop" || (string)(object)enumerator != "EarnCoinsScreen" || (string)(object)enumerator != "CoinsUI_shop")
					{
						nint num17 = (nint)typeof(UIScreens);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v111 (Il2CppClass<UIScreens>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						bool flag12 = obj10 == null;
						nint num18 = (nint)typeof(UIScreens);
						if (!flag12)
						{
							nint num19 = (nint)typeof(UIScreens);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v118 (Il2CppClass<UIScreens>)+74]");
							bool flag13 = (nint)0 == 0;
							bool flag14 = !flag13;
							num18 = (nint)typeof(UIScreens);
							if (!flag14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num18 = (nint)typeof(UIScreens);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ L1_v13 (Il2CppClass<UIScreens>)+5C]");
						object obj11 = (nint)0 + (nint)16;
						obj11 = enumerator;
					}
				}
				else
				{
					nint num20 = (nint)typeof(UIScreens);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v87 (Il2CppClass<UIScreens>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					bool flag15 = obj12 == null;
					nint num21 = (nint)typeof(UIScreens);
					if (!flag15)
					{
						nint num22 = (nint)typeof(UIScreens);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S0_v94 (Il2CppClass<UIScreens>)+74]");
						bool flag16 = (nint)0 == 0;
						bool flag17 = !flag16;
						num21 = (nint)typeof(UIScreens);
						if (!flag17)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num21 = (nint)typeof(UIScreens);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ L1_v10 (Il2CppClass<UIScreens>)+5C]");
					object obj13 = (nint)0 + (nint)12;
					obj13 = enumerator;
				}
			}
		}
		if (string.Equals((string)(object)uIScreen, "FrontScreen"))
		{
			IEnumerator a = DelayHideMainCamera();
			if (string.Equals((string)(object)a, "GameOverScreen"))
			{
				PayoutCelebrationReward(null);
				return;
			}
		}
		if ((string)(object)uIScreen != "PauseUI")
		{
			nint num23 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v42 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num24 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v63 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			nint num25 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num26 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)isInstantiated).FindKernel(null) == 0)
			{
				return;
			}
			nint num27 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v51 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num28 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v59 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated2 = Game.IsInstantiated;
			object obj17 = (isInstantiated2 ? 1 : 0) - -64;
			if (obj17 != null)
			{
				return;
			}
		}
		string text = ((UIScreenController)null).Pop(_screenStack);
		if (text != "PauseUI" && (string)(object)uIScreen != "IngameUI")
		{
			UIScreen uIScreen2 = _cachedScreens.get_Item("PauseUI");
			_0021_00210 componentInChildren = (_0021_00210)((Component)uIScreen2).GetComponentInChildren<T>();
			PromotionDefinition promotionDefinition = ((PromotionManager)componentInChildren).TryGetCurrentPromotion();
			if ((object)promotionDefinition != null)
			{
				return;
			}
		}
		string text2 = Peek((List<string>)(object)uIScreen);
	}

	public void SwitchScreen(string screenName)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ABTestManager.DisableDebugPayload(screenName);
		_ShowScreen(null, (UIScreen)(object)screenName);
	}

	public void BackToPreviousScreen()
	{
		ClearPopupsAndScreens();
	}

	private void ScreenDidChange(string newScreenName)
	{
		string key = ((UIScreenController)null).QueuePeek(_screenStack);
		UIScreen uIScreen = _cachedScreens.get_Item(key);
		uIScreen.Show();
		string text = Peek((List<string>)(object)newScreenName);
	}

	private void _SetBackground(bool active)
	{
		//IL_0102: Expected I4, but got Obj
		//IL_0102: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		//IL_004e: Expected Obj, but got I4
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_00b4: Expected I, but got Obj
		if (((string)active).get_Chars((int)"IngameUI") != '\0')
		{
			messageHelper._002Ector();
		}
		QueueCelebrationPopup();
		if ((string)active == "FrontScreen" && !((string)active != "GameOverScreen"))
		{
			return;
		}
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v14 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper._002Ecctor();
	}

	private IEnumerator DelayHideMainCamera()
	{
		if (_screenStack != null)
		{
			List<string> screenStack = _screenStack;
			if (screenStack._size > 0)
			{
				return (IEnumerator)(object)((UIScreenController)null).Pop(_screenStack);
			}
			return null;
		}
		return null;
	}

	private UIScreen _LoadScreenToCache(string screenName, GameObject destinationParent)
	{
		//IL_002a: Expected I4, but got Obj
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		UIScreen uIScreen = default;
		((UnityEngine.Object)uIScreen).m_CachedPtr = (IntPtr)0;
		uIScreen._selectedFooterButton = (int)screenName;
		object obj = uIScreen + 16;
		obj = destinationParent;
		return uIScreen;
	}

	public unsafe static bool ShouldShowOnlineScreen()
	{
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected I, but got Unknown
		//IL_02c4: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01d6: Expected I, but got Obj
		//IL_01f1: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_0249: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0285: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 + 4);
		bool flag = (object)_instance == null;
		bool flag2 = !flag;
		bool result = (byte)(int)_instance != 0;
		if (!flag2)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v49 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(UIScreenController);
			((IntPtr*)num3)->m_value = (void*)(nint)obj2;
			Type type = Type.internal_from_handle((IntPtr)num3);
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = ((UnityEngine.Object)(object)type).ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<UIScreenController>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = default;
			_instance = (UIScreenController)flag3;
			result = flag3;
		}
		return result;
	}

	private string Peek(List<string> list)
	{
		//IL_03d6: Expected Obj, but got I
		//IL_03e6: Expected Obj, but got I
		//IL_03f6: Expected Obj, but got I
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_0193: Expected I4, but got Obj
		//IL_0193: Expected I4, but got Obj
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I4
		//IL_01e6: Expected I, but got Obj
		//IL_0059: Expected VT, but got Obj
		//IL_0258: Expected I, but got Obj
		//IL_026e: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
		//IL_0045: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_0299: Expected I, but got Obj
		//IL_03b6: Expected I4, but got Obj
		//IL_03b6: Expected I4, but got Obj
		//IL_0479: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		object obj10;
		UIScreen uIScreen3;
		if ((nint)obj6 > -1)
		{
			List<string> screenStack = _screenStack;
			object obj7;
			if (screenStack._size < 1)
			{
				obj7 = 1;
			}
			else
			{
				bool flag = ((List<T>)(object)_screenStack).Remove((T)list);
				if ((flag ? 1 : 0) < (false ? 1 : 0))
				{
					obj7 = 1;
				}
				else
				{
					List<string> screenStack2 = _screenStack;
					object obj8 = screenStack2._size - 1;
					if ((flag ? 1 : 0) < (nint)obj8)
					{
						List<string> screenStack3 = _screenStack;
						int num2 = (flag ? 1 : 0) + 1;
						int num3 = screenStack3._size - num2;
						int num4 = num2;
						while (true)
						{
							object obj9 = num3 + num2;
							if (num4 >= (nint)obj9)
							{
								break;
							}
							string key = _screenStack.get_Item(num4);
							UIScreen uIScreen = _cachedScreens.get_Item(key);
							uIScreen.Show();
							int num5 = num4 + 1;
							num4 = num5;
						}
						((List<T>)(object)_screenStack).Reverse(num2, num3);
					}
					obj7 = 0;
				}
			}
			UIScreen uIScreen2 = _cachedScreens.get_Item((string)(object)list);
			obj10 = obj7;
			uIScreen3 = uIScreen2;
		}
		else
		{
			IEnumerator enumerator = ((FPSLog)(object)this).FPSTestRoutine((byte)(int)list != 0, (byte)(int)screenAnchor != 0);
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)enumerator != null)
			{
				uIScreen3 = null;
				goto IL_03bb;
			}
			obj10 = 1;
			uIScreen3 = (UIScreen)enumerator;
		}
		nint num8 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v13 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num9 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v36 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string androidExternalSavePath = DeviceUtility.GetAndroidExternalSavePath();
		if (androidExternalSavePath != null)
		{
			LogError((string)(object)this, (UnityEngine.Object)(object)list);
		}
		if (obj10 != null)
		{
			List<string> screenStack4 = _screenStack;
			if (screenStack4._size >= 1)
			{
				List<string> screenStack5 = _screenStack;
				int index = screenStack5._size - 1;
				string key2 = _screenStack.get_Item(index);
				UIScreen uIScreen4 = _cachedScreens.get_Item(key2);
				uIScreen4.Show();
			}
			_screenStack.Add((string)(object)list);
		}
		ShowUnlockAnimationForCharacter((Characters.CharacterId)list, (int)uIScreen3);
		goto IL_03bb;
		IL_03bb:
		return (string)(object)uIScreen3;
	}

	private string Pop(List<string> list)
	{
		if (list._size > 0)
		{
			int index = list._size - 1;
			return list.get_Item(index);
		}
		return "";
	}

	private string QueuePeek(List<string> list)
	{
		bool flag = list._size > 0;
		bool flag2 = !flag;
		string result = "";
		if (!flag2)
		{
			int index = list._size - 1;
			string text = list.get_Item(index);
			int index2 = list._size - 1;
			list.RemoveAt(index2);
			result = text;
		}
		return result;
	}

	private string Dequeue(List<string> list)
	{
		bool flag = list == null;
		string result = "";
		if (!flag)
		{
			bool flag2 = list._size > 0;
			bool flag3 = !flag2;
			result = "";
			if (!flag3)
			{
				string text = list.get_Item(0);
				result = text;
			}
		}
		return result;
	}

	public void ShowUnlockAnimationForCharacter(Characters.CharacterId ctype, int themeIndex = 0)
	{
		//IL_02d1: Expected Obj, but got I4
		//IL_02e3: Expected Obj, but got I4
		//IL_02fb: Expected I, but got Obj
		//IL_0311: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0355: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_038e: Expected I, but got Obj
		//IL_03a4: Expected Obj, but got I
		//IL_00b1: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_01f1: Expected I, but got Obj
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_0246: Expected Obj, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_028f: Expected Obj, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I4
		//IL_0161: Expected I, but got Obj
		bool flag = _screenNamesWithoutBackground.Contains((string)ctype);
		GameObject sender = (GameObject)((flag ? 1 : 0) ^ 1);
		PushPopup(sender);
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v78 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UIScreenController.m_OnWillShowScreen != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v25 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S3_v22 (should have been resolved before IL gen)");
		}
		if (UIScreenController.m_OnWillNavigateToScreen != null)
		{
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v22 (Il2CppMethodInfo)+18]");
			object obj6 = 0;
			object obj7 = obj6;
			object obj8 = obj7 & 0x3FFF;
			object obj9 = obj8 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S3_v18 (should have been resolved before IL gen)");
		}
		((UIScreen)themeIndex).HideIfActive();
		if ((string)ctype != "GameOverScreen")
		{
			UIScreen uIScreen = _cachedScreens.get_Item((string)ctype);
			GameOverScreen component = uIScreen.GetComponent<GameOverScreen>();
			component.SetupAfterMysteryBox();
			nint num5 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v60 (Il2CppClass<RewardManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v72 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PurchaseHandler instance = PurchaseHandler.Instance;
			if ((nint)instance > 0)
			{
				_ActivateNextPopup("CelebrationPopup");
			}
			else
			{
				UIScreen uIScreen2 = _cachedScreens.get_Item((string)ctype);
				GameOverScreen component2 = uIScreen2.GetComponent<GameOverScreen>();
				component2.UpdateUpgradeSticker();
			}
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v29 (Il2CppClass<UIScreenController>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v49 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UIScreenController.m_OnChangedScreen != null)
		{
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S2_v14 (Il2CppMethodInfo)+18]");
			object obj12 = 0;
			object obj13 = obj12;
			object obj14 = obj13 & 0x3FFF;
			object obj15 = obj14 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v168 @ S3_v14 (should have been resolved before IL gen)");
		}
		if (UIScreenController.m_OnNavigatedToScreen != null)
		{
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S2_v11 (Il2CppMethodInfo)+18]");
			object obj16 = 0;
			object obj17 = obj16;
			object obj18 = obj17 & 0x3FFF;
			object obj19 = obj18 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v204 @ S3_v10 (should have been resolved before IL gen)");
		}
		_SetBackground((byte)ctype != 0);
	}

	public void ShowUnlockAnimationForHoverboard(Boards.BoardId boardId, Hoverboard.BoardAbility boardPower = Hoverboard.BoardAbility.None)
	{
		//IL_0081: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		dailyChallengeRewardHelper.Refresh();
		((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)7;
		dailyChallengeRewardHelper._rewardLayout = (Layout)8;
		dailyChallengeRewardHelper._rewardLabel = (UILabel)boardId;
		dailyChallengeRewardHelper._3BagsReward = (GameObject)boardPower;
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<RewardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v19 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager.AddMysteryBoxToUnlock((CelebrationReward)(object)dailyChallengeRewardHelper);
		ClosePopup();
	}

	public void ShowRewardAnimationForBundlePurchase(List<InAppItemModel.BundleItem> bundleContent, string kilooAnalyticsSourceId)
	{
		//IL_0081: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		dailyChallengeRewardHelper.Refresh();
		((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)8;
		dailyChallengeRewardHelper._rewardLayout = (Layout)7;
		dailyChallengeRewardHelper._6BagsReward = (GameObject)(object)bundleContent;
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<RewardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v19 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager.AddMysteryBoxToUnlock((CelebrationReward)(object)dailyChallengeRewardHelper);
		ClosePopup();
	}

	public void ShowUnlockAnimationForHoverboardBundle(Boards.BoardId boardId, List<HoverboardThemes.ThemeIdentifier> bundledThemes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected Obj, but got Unknown
		//IL_08f5: Expected Obj, but got I4
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_030a: Expected I, but got Obj
		//IL_0320: Expected Obj, but got I
		//IL_034b: Expected I, but got Obj
		//IL_09b1: Expected I, but got Obj
		//IL_09c7: Expected Obj, but got I
		//IL_07e7: Expected Obj, but got I
		//IL_089f: Expected I, but got Obj
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Expected Obj, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected Obj, but got Unknown
		//IL_075f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj7 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			_ = 15;
			object obj6 = obj7 + 92;
			obj6 = bundledThemes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj8 = obj9 - 3;
			if ((nint)obj9 != 3)
			{
				if ((nint)obj8 == 1)
				{
					continue;
				}
				if ((nint)obj8 != 2)
				{
					if ((nint)obj8 != 3)
					{
						if ((nint)obj8 == 4 || (nint)obj8 == 5)
						{
							continue;
						}
						if ((nint)obj8 != 6)
						{
							if ((nint)obj8 != 7)
							{
								if ((nint)obj8 != 8)
								{
									continue;
								}
								_ = 2;
								_ = 15;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							}
							else
							{
								_ = 2;
								_ = 3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							}
						}
						else
						{
							_ = 2;
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						}
					}
					else
					{
						_ = 6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					}
				}
				else
				{
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				}
			}
			nint num = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v114 (Il2CppClass<RewardManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num2 = (nint)typeof(RewardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v123 (Il2CppClass<RewardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj11 = 36;
		object obj12 = obj11 - 9;
		if ((nint)obj11 != 9 && (nint)obj12 != 1 && (nint)obj12 != 2)
		{
			if ((nint)obj12 != 3 && (nint)obj12 != 4)
			{
				if ((nint)obj12 == 5)
				{
					goto IL_0764;
				}
				if ((nint)obj12 != 6 && (nint)obj12 != 7)
				{
					if ((nint)obj12 == 8)
					{
						goto IL_0764;
					}
					if ((nint)obj12 != 9 && (nint)obj12 != 10)
					{
						if ((nint)obj12 == 11)
						{
							goto IL_0764;
						}
						if ((nint)obj12 != 12 && (nint)obj12 != 13)
						{
							if ((nint)obj12 == 14)
							{
								goto IL_0764;
							}
							if ((nint)obj12 != 15 && (nint)obj12 != 16)
							{
								if ((nint)obj12 == 17)
								{
									goto IL_0764;
								}
								if ((nint)obj12 != 18 && (nint)obj12 != 19 && (nint)obj12 != 20)
								{
									if ((nint)obj12 == 21)
									{
										goto IL_0764;
									}
									if ((nint)obj12 != 22 && (nint)obj12 != 23 && (nint)obj12 != 24 && (nint)obj12 != 25)
									{
										if ((nint)obj12 == 26)
										{
											goto IL_0764;
										}
										if ((nint)obj12 == 27)
										{
											object obj13 = obj4 + 4;
											object obj14 = obj13 + 1;
											obj13 = obj14;
											object obj15 = obj14 << 2;
											object obj16 = obj4 + obj15;
											obj16 = 264;
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_097e;
		}
		goto IL_0764;
		IL_09a3:
		nint num3 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v37 (Il2CppClass<RewardManager>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num4 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v45 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager.canShowMultipleQueuedCelebrations = true;
		QueuePopup("CelebrationPopup");
		return;
		IL_0764:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj18 = default;
		object obj19 = default;
		if (obj18 == obj19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_097e;
		IL_097e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj4 + obj20;
			if ((nint)obj21 == 264)
			{
				object obj22 = obj4 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_09a3;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_09a3;
	}

	private void ClearPopupsAndScreens()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_0134: Expected I4, but got Obj
		List<string> screenStack = _screenStack;
		if (screenStack._size < 2)
		{
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v25 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v31 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
		}
		else
		{
			string key = ((UIScreenController)null).QueuePeek(_screenStack);
			UIScreen uIScreen = _cachedScreens.get_Item(key);
			uIScreen.Show();
			string text = ((UIScreenController)null).Pop(_screenStack);
			UIScreen uIScreen2 = _cachedScreens.get_Item(text);
			uIScreen2.HideIfActive();
			bool flag = _screenNamesWithoutBackground.Contains(text);
			GameObject sender = (GameObject)((flag ? 1 : 0) ^ 1);
			PushPopup(sender);
			_SetBackground((byte)(int)text != 0);
		}
	}

	private unsafe void ClearSlideIns()
	{
		//IL_000e: Expected Obj, but got Ref
		//IL_040f: Expected Obj, but got Ref
		//IL_0418: Expected Obj, but got I4
		//IL_042c: Expected Obj, but got Ref
		//IL_00b1: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected I, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I4
		//IL_007f: Expected I4, but got Obj
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_0357: Expected Obj, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected Obj, but got Unknown
		//IL_01a0: Expected Obj, but got I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got I4
		//IL_0218: Expected I, but got Obj
		ref _0021_00210 reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 48));
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 24));
		obj2 = 0;
		_ = 0;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		obj3 = obj;
		_ = -1;
		List<string> popupQueue = _popupQueue;
		int num = popupQueue._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 < 0)
			{
				break;
			}
			string item = _popupQueue.get_Item(num2);
			if (!_excludedScreensFromClear.Contains(item))
			{
				string text = _popupQueue.get_Item(num2);
				SetCoinRewardAmount((int)text);
			}
			num = num2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S3_v4+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		nint num4 = (nint)(obj7 + 113696);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v127 @ S4_v5 (Il2CppMethodInfo) (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE17");
		_0021_00210 flag = default;
		FlagsHelper.Set<T>(ref System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (T)flag);
		obj2 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+8]");
		_ = 0;
		object obj8 = default;
		object obj9 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj10;
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					obj10 = 0;
					num4 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v120 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					obj10 = 0;
				}
				object obj12 = obj10 & 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					if (obj13 == obj14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
					}
					break;
				}
				continue;
			}
			object obj15 = obj3 + 4;
			object obj16 = obj15 + 1;
			obj15 = obj16;
			object obj17 = obj16 << 2;
			object obj18 = obj3 + obj17;
			obj18 = 183;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj3 + obj19;
			if ((nint)obj20 == 183)
			{
				object obj21 = obj3 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_04e0;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04e0;
		IL_04e0:
		object obj24 = this + 92;
		object obj25 = default;
		obj24 = obj25;
		throw new IndexOutOfRangeException();
	}

	public string GetCurrentPopupName()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = this;
		return text;
	}

	public bool IsPopupQueueEmpty()
	{
		if (_popupQueue != null)
		{
			List<string> popupQueue = _popupQueue;
			return popupQueue._size > 0;
		}
		return false;
	}

	public bool IsPopupAlreadyQueued(string popupName)
	{
		//IL_0037: Expected I4, but got Obj
		bool flag = popupName.m_firstChar > '\0';
		bool flag2 = !flag;
		string text = "";
		if (!flag2)
		{
			string text2 = ((List<string>)(object)popupName).get_Item(0);
			((List<string>)(object)popupName).RemoveAt(0);
			text = text2;
		}
		return (byte)(int)text != 0;
	}

	public void PushPopup(GameObject sender)
	{
		//IL_0215: Expected Obj, but got I
		//IL_0225: Expected Obj, but got I
		//IL_0235: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_0305: Expected Obj, but got I4
		//IL_019e: Expected I, but got Obj
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_003a: Expected I4, but got Obj
		//IL_003a: Expected I4, but got Obj
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_00b4: Expected I, but got Obj
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag = (nint)obj6 > -1;
		if ((object)sender != null)
		{
			if (!flag)
			{
				IEnumerator enumerator = ((FPSLog)(object)this).FPSTestRoutine((byte)(int)"NotebookScreen" != 0, (byte)(int)backgroundAnchor != 0);
			}
			UIScreen uIScreen = _cachedScreens.get_Item("NotebookScreen");
			uIScreen.HideIfActive();
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mainCamera != null)
			{
				object obj8 = this + 76;
				Camera current = Camera.current;
				obj8 = current;
			}
			string currentPopupName = GetCurrentPopupName();
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)currentPopupName);
			return;
		}
		if (flag)
		{
			UIScreen uIScreen2 = _cachedScreens.get_Item("NotebookScreen");
			uIScreen2.Show();
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mainCamera != null)
		{
			object obj10 = this + 76;
			Camera current2 = Camera.current;
			obj10 = current2;
		}
		mainCamera.tag = (string)1;
	}

	public void PushPopup(string popupName)
	{
		//IL_002a: Expected Obj, but got I4
		UIButtonChangeScreen component = ((GameObject)(object)popupName).GetComponent<UIButtonChangeScreen>();
		bool flag = component.ShowScreens();
		QueuePopup((string)flag);
	}

	public void QueuePopup(string popupName)
	{
		//IL_0050: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0435: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		//IL_0458: Expected I4, but got Obj
		//IL_046e: Expected Obj, but got I
		//IL_047e: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0174: Expected Obj, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I4
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_02d3: Expected I, but got Obj
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_0369: Expected Obj, but got I4
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected I4, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected Obj, but got Unknown
		string text = ((UIScreenController)null).Dequeue(_popupQueue);
		object obj;
		object obj9;
		if (text == null || text.m_stringLength == 0)
		{
			obj = -1;
		}
		else
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S2_v26 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S2_v27+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v28+44]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S3_v14 (should have been resolved before IL gen)");
			object obj7 = default;
			if ((nint)obj7 > -1)
			{
				UIScreen uIScreen = _cachedScreens.get_Item(text);
				UIPanel[] componentsInChildren = uIScreen.GetComponentsInChildren<UIPanel>(includeInactive: true);
				object obj8 = componentsInChildren + 12;
				obj9 = -1;
				object obj10 = default;
				object obj15 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
				{
					object obj11 = componentsInChildren + 16;
					object obj12 = obj10 << 2;
					object obj13 = obj11 + obj12;
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v86+F4]");
					if (0 > (nint)obj9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v86+F4]");
						obj9 = 0;
					}
					obj10 = obj15 + 1;
				}
				goto IL_043a;
			}
			obj = -1;
		}
		obj9 = obj;
		goto IL_043a;
		IL_043a:
		_popupQueue.Insert(0, popupName);
		ActivateAnchors((byte)(int)text != 0);
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S2_v6 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S2_v7+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v8+44]");
		object obj18 = 0;
		object obj19 = obj18 & 0x1FFF;
		object obj20 = obj19 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v119 @ S3_v7 (should have been resolved before IL gen)");
		object obj21 = default;
		if ((nint)obj21 <= -1)
		{
			return;
		}
		UIScreen uIScreen2 = _cachedScreens.get_Item(popupName);
		UIPanel[] componentsInChildren2 = uIScreen2.GetComponentsInChildren<UIPanel>(includeInactive: true);
		if (componentsInChildren2 == null)
		{
			return;
		}
		object obj22 = componentsInChildren2 + 12;
		if (obj22 == null)
		{
			return;
		}
		object obj23 = componentsInChildren2 + 16;
		ComputeShader computeShader = (ComputeShader)obj23;
		object obj24 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
		{
			object obj25 = componentsInChildren2 + 16;
			object obj26 = obj24 << 2;
			object obj27 = obj25 + obj26;
			ComputeShader computeShader2 = (ComputeShader)obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v61 (UnityEngine.ComputeShader)+F4]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L0_v7 (UnityEngine.ComputeShader)+F4]");
			if (num3 < 0)
			{
				computeShader = computeShader2;
			}
			object obj28 = obj24 + 1;
			obj24 = obj28;
		}
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (nint)obj9 < 0;
		int num6 = computeShader.FindKernel(null);
		int num7 = num6 ^ 1;
		if (((flag ? 1u : 0u) | (uint)num7) != 0)
		{
			return;
		}
		object obj30 = obj9 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L0_v7 (UnityEngine.ComputeShader)+F4]");
		object obj31 = obj30 - 0;
		if ((nint)obj31 >= 0)
		{
			object obj32 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
			{
				object obj33 = componentsInChildren2 + 16;
				object obj34 = obj32 << 2;
				object obj35 = obj33 + obj34;
				UIPanel uIPanel = (UIPanel)obj35;
				int sortingOrder = obj31 + uIPanel.mDepth;
				uIPanel.sortingOrder = sortingOrder;
				object obj36 = obj32 + 1;
				obj32 = obj36;
			}
		}
	}

	private void _ActivateNextPopup(string oldPopupName = "")
	{
		//IL_0010: Expected I4, but got Obj
		messageHelper._002Ector();
		_popupQueue.Add(oldPopupName);
		if (~(_popupActive ? 1u : 0u) != 0)
		{
			ActivateAnchors((byte)(int)"" != 0);
		}
	}

	private void EnableBackButton(string screenName, bool enable)
	{
		//IL_0081: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
		dailyChallengeRewardHelper.Refresh();
		((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)14;
		dailyChallengeRewardHelper._rewardLayout = (Layout)11;
		dailyChallengeRewardHelper._6BagsReward = (GameObject)(object)screenName;
		object obj = dailyChallengeRewardHelper + 88;
		obj = enable;
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<RewardManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v20 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager.AddMysteryBoxToUnlock((CelebrationReward)(object)dailyChallengeRewardHelper);
		ClosePopup();
	}

	private void ActivateAnchors(bool active)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected Obj, but got Unknown
		//IL_0a27: Expected Obj, but got I4
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected Obj, but got Unknown
		//IL_014e: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_029d: Expected Obj, but got I4
		//IL_0d0c: Expected I, but got Obj
		//IL_0d22: Expected Obj, but got I
		//IL_0988: Expected I, but got Obj
		//IL_0d5e: Expected I, but got Obj
		//IL_0d74: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I
		//IL_09dd: Expected Obj, but got I
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Expected Obj, but got Unknown
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected Obj, but got Unknown
		//IL_010c: Expected Obj, but got I4
		//IL_010c: Expected I4, but got Obj
		//IL_03ed: Expected I, but got Obj
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0da7: Expected Obj, but got I
		//IL_0db7: Expected Obj, but got I
		//IL_0dc7: Expected Obj, but got I
		//IL_0dd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd5: Expected Obj, but got Unknown
		//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de3: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_0bf3: Expected I, but got Obj
		//IL_0c09: Expected Obj, but got I
		//IL_059c: Expected I4, but got Obj
		//IL_059c: Expected I4, but got Obj
		//IL_05ae: Expected I, but got Obj
		//IL_05c4: Expected Obj, but got I
		//IL_0c79: Expected I, but got Obj
		//IL_0c8f: Expected Obj, but got I
		//IL_078f: Expected I, but got Obj
		//IL_05ef: Expected I, but got Obj
		//IL_047e: Expected I4, but got Obj
		//IL_04e0: Expected Obj, but got I
		//IL_04f0: Expected Obj, but got I
		//IL_0500: Expected Obj, but got I
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected Obj, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0234: Expected Obj, but got I4
		//IL_08a9: Expected I, but got Obj
		//IL_08bf: Expected Obj, but got I
		//IL_084d: Expected I, but got Obj
		//IL_0803: Expected I4, but got Obj
		//IL_0803: Expected Obj, but got I4
		//IL_08ea: Expected I, but got Obj
		//IL_0701: Expected I, but got Obj
		//IL_0717: Expected Obj, but got I
		//IL_093f: Expected Obj, but got I
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected Obj, but got Unknown
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected Obj, but got Unknown
		//IL_083a: Expected Obj, but got I4
		//IL_0742: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		List<string> popupQueue = _popupQueue;
		string text;
		if (popupQueue._size < 1)
		{
			QueuePopupRightAfterCurrentActivePopup((string)1);
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v265 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v283 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string androidExternalSavePath = DeviceUtility.GetAndroidExternalSavePath();
			if (androidExternalSavePath != null)
			{
				IEnumerator enumerator = DelayHideMainCamera();
				bool flag;
				if (enumerator != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v275 (System.Collections.IEnumerator)+8]");
					flag = (nint)0 == 0;
				}
				else
				{
					flag = true;
				}
				if (!flag)
				{
					_PauseAnimations((byte)(int)enumerator != 0, (Transform)1);
				}
			}
			text = "";
			goto IL_0cfe;
		}
		string text2 = ((UIScreenController)null).Dequeue(_popupQueue);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = 0;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj8 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				obj6 = 1;
			}
		}
		object obj11 = obj4 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj4 + obj13;
		obj14 = 154;
		object obj15 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v8+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj4 + obj16;
			if ((nint)obj17 == 154)
			{
				object obj18 = obj4 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_0d3f;
			}
		}
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0d3f;
		IL_0cfe:
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UIScreenController.m_OnPopupShown != null)
		{
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S2_v4 (Il2CppMethodInfo)+18]");
			object obj22 = 0;
			object obj23 = obj22;
			object obj24 = obj23 & 0x3FFF;
			object obj25 = obj24 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v319 @ S3_v5 (should have been resolved before IL gen)");
		}
		return;
		IL_0d3f:
		QueuePopupRightAfterCurrentActivePopup(null);
		IEnumerator enumerator2 = DelayHideMainCamera();
		nint num6 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v59 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num7 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v182 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string androidExternalSavePath2 = DeviceUtility.GetAndroidExternalSavePath();
		if (androidExternalSavePath2 != null)
		{
			bool flag2;
			if (enumerator2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v57 (System.Collections.IEnumerator)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (!flag2)
			{
				_PauseAnimations((byte)(int)enumerator2 != 0, null);
			}
		}
		if (obj15 == null)
		{
			bool flag3;
			if (enumerator2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v57 (System.Collections.IEnumerator)+8]");
				flag3 = (nint)0 == 0;
			}
			else
			{
				flag3 = true;
			}
			if (!flag3)
			{
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ S2_v47 (Il2CppMethodInfo)+C]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S2_v48+60]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S2_v49+44]");
				object obj29 = 0;
				object obj30 = obj29 & 0x1FFF;
				object obj31 = obj30 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v493 @ S3_v24 (should have been resolved before IL gen)");
				object obj32 = default;
				if ((nint)obj32 > -1)
				{
					UIScreen uIScreen = _cachedScreens.get_Item((string)(object)enumerator2);
					if (~(uIScreen._isActive ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
					}
				}
			}
		}
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S2_v21 (Il2CppMethodInfo)+C]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S2_v22+60]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S2_v23+44]");
		object obj35 = 0;
		object obj36 = obj35 & 0x1FFF;
		object obj37 = obj36 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v525 @ S3_v14 (should have been resolved before IL gen)");
		object obj38 = default;
		if ((nint)obj38 <= -1)
		{
			IEnumerator enumerator3 = ((FPSLog)(object)this).FPSTestRoutine((byte)(int)text2 != 0, (byte)(int)popupAnchor != 0);
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj39 = (nint)0 & (nint)0x200;
			if (obj39 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)enumerator3 == null))
			{
				return;
			}
		}
		if (text2 != "CelebrationPopup")
		{
			List<string> screenStack = _screenStack;
			if (screenStack._size >= 1)
			{
				List<string> screenStack2 = _screenStack;
				int index = screenStack2._size - 1;
				string text3 = _screenStack.get_Item(index);
				if (text3 != "GameOverScreen")
				{
					nint num12 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ S0_v143 (Il2CppClass<RewardManager>)+BA]");
					object obj40 = (nint)0 & (nint)0x200;
					if (obj40 != null)
					{
						nint num13 = (nint)typeof(RewardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S0_v149 (Il2CppClass<RewardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					RewardManager.canShowMultipleQueuedCelebrations = true;
				}
			}
		}
		UIScreen uIScreen2 = _cachedScreens.get_Item(text2);
		nint num14 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ S0_v81 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ S0_v128 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIScreen2).FindKernel((string)null) != 0 && ~(uIScreen2._isActive ? 1u : 0u) != 0)
		{
			if (((string)active).get_Chars((int)"") != '\0')
			{
				object obj42 = uIScreen2 + 36;
				obj42 = active;
			}
			uIScreen2.HideIfActive();
		}
		_popupActive = true;
		nint num16 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S0_v90 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj43 = (nint)0 & (nint)0x200;
		if (obj43 != null)
		{
			nint num17 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S0_v115 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string androidExternalSavePath3 = DeviceUtility.GetAndroidExternalSavePath();
		if (androidExternalSavePath3 != null)
		{
			LogError((string)(object)this, (UnityEngine.Object)(object)text2);
		}
		nint num18 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ S0_v98 (Il2CppClass<UIScreenController>)+BA]");
		object obj44 = (nint)0 & (nint)0x200;
		if (obj44 != null)
		{
			nint num19 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ S0_v108 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = UIScreenController.m_OnChangedScreen == null;
		text = text2;
		if (!flag4)
		{
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ S2_v33 (Il2CppMethodInfo)+18]");
			object obj45 = 0;
			object obj46 = obj45;
			object obj47 = obj46 & 0x3FFF;
			object obj48 = obj47 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v181 @ S3_v19 (should have been resolved before IL gen)");
			text = text2;
		}
		goto IL_0cfe;
	}

	public static void QueueFacebookPayoutPopup()
	{
		//IL_000e: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got F4
		//IL_0037: Expected I, but got Obj
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_0073: Expected VT, but got Obj
		object obj = 0;
		_ = 0;
		obj = 0f;
		_ = -60f;
		_ = 0f;
		nint num = (nint)typeof(TutorialMultilineLabelsHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<TutorialMultilineLabelsHelper>)+5C]");
		nint num2 = 0;
		object obj2 = obj + 12;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		TutorialMultilineLabelsHelper._defaultPosition = (Vector3)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17+8]");
		_ = 0;
	}

	private void TryQueuePayoutPopups()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0272: Expected Obj, but got I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I4
		//IL_01b1: Expected Obj, but got I
		//IL_005c: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_009d: Expected I, but got Obj
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		_slideInActive = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v85 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v94 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 74;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 74)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0315;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0315;
		IL_0315:
		_slideHasPreloaded = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
	}

	public void QueuePopupRightAfterCurrentActivePopup(string popupName)
	{
		//IL_00f3: Expected I, but got Obj
		//IL_0109: Expected Obj, but got I
		//IL_0140: Expected VT, but got I4
		//IL_0140: Expected Obj, but got I
		//IL_0163: Expected VT, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_0075: Expected VT, but got I4
		//IL_0075: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009d: Expected VT, but got I4
		//IL_009d: Expected Obj, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected VT, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		bool isInstanced = IsInstanced;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (System.Boolean)+C]");
		NGUITools.FitOnScreen((Camera)0, (Transform)(object)popupName, (Vector3)0);
		bool isInstanced2 = IsInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v9 (System.Boolean)+10]");
		NGUITools.FitOnScreen((Camera)0, (Transform)(object)popupName, (Vector3)0);
		bool isInstanced3 = IsInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v12 (System.Boolean)+14]");
		NGUITools.FitOnScreen((Camera)0, (Transform)(object)popupName, (Vector3)0);
		bool isInstanced4 = IsInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v15 (System.Boolean)+20]");
		NGUITools.FitOnScreen((Camera)0, (Transform)(object)popupName, (Vector3)0);
		Vector3 startPosition = (Vector3)(popupName ^ 1);
		object obj2 = this - -64;
		int layer = ((GameObject)obj2).layer;
		SpawnCollectText(startPosition, (string)layer);
	}

	public void QueuePopup(GameObject sender)
	{
		string text = ((UIScreenController)null).Dequeue(_popupQueue);
		if (text == null || text.m_stringLength == 0)
		{
			_ActivateNextPopup((string)(object)sender);
		}
		else
		{
			_popupQueue.Insert(1, (string)(object)sender);
		}
	}

	public void QueueCelebrationPopup()
	{
		//IL_02b7: Expected I, but got Obj
		//IL_02cd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_0195: Expected I, but got Obj
		//IL_0229: Expected I, but got Obj
		//IL_023f: Expected Obj, but got I
		//IL_026a: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v72 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_facebookPayoutPopupQueued ? 1u : 0u) != 0 || _screenStack == null)
		{
			return;
		}
		List<string> screenStack = _screenStack;
		if (screenStack._size <= 0)
		{
			return;
		}
		string item = ((UIScreenController)null).Pop(_screenStack);
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v25 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v66 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PAYOUT_DISALLOWED_SCREENS.Contains(item))
		{
			return;
		}
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v35 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v60 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_facebookPayoutPopupQueued ? 1u : 0u) != 0)
		{
			return;
		}
		IEnumerator enumerator = AnimateCollectText((UILabel)(object)"FBPromotionPopup");
		if (enumerator == null)
		{
			_ActivateNextPopup("FBPromotionPopup");
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v47 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v53 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_facebookPayoutPopupQueued = false;
	}

	public void CloseActivePopups(string popupToStopAt)
	{
		//IL_002a: Expected Obj, but got I4
		UIButtonChangeScreen component = ((GameObject)(object)popupToStopAt).GetComponent<UIButtonChangeScreen>();
		bool flag = component.ShowScreens();
		_ActivateNextPopup((string)flag);
	}

	public void ClosePopup()
	{
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<RewardManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<CelebrationReward> weeklyHuntRewardsToUnlock = RewardManager.GetWeeklyHuntRewardsToUnlock();
		if (weeklyHuntRewardsToUnlock._size == 0)
		{
			return;
		}
		List<string> popupQueue = _popupQueue;
		if (popupQueue._size > 0)
		{
			string text = ((UIScreenController)null).Dequeue(_popupQueue);
			if (!(text == "CelebrationPopup"))
			{
				return;
			}
		}
		List<string> popupQueue2 = _popupQueue;
		if (popupQueue2._size > 0)
		{
			QueuePopup("CelebrationPopup");
		}
		else
		{
			_ActivateNextPopup("CelebrationPopup");
		}
	}

	public void ClosePopup(GameObject go)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04cc: Expected Obj, but got I4
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got Unknown
		//IL_02a9: Expected Obj, but got I4
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_035f: Expected Obj, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0130: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I
		//IL_0296: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got I
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_0561: Expected Obj, but got I4
		//IL_056a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj12;
		if (_popupQueue.Contains((string)(object)go))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			object obj6 = default;
			object obj7 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj6 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj7 != null)
						{
							object obj8 = obj4 + 4;
							object obj9 = obj8 + 1;
							obj8 = obj9;
							object obj10 = obj9 << 2;
							object obj11 = obj4 + obj10;
							obj11 = 104;
							obj12 = 0;
							break;
						}
					}
					continue;
				}
				object obj13 = obj4 + 4;
				object obj14 = obj13 + 1;
				obj13 = obj14;
				object obj15 = obj14 << 2;
				object obj16 = obj4 + obj15;
				obj16 = 104;
				obj12 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj17 = (nint)0 << 2;
				object obj18 = obj4 + obj17;
				if ((nint)obj18 == 104)
				{
					object obj19 = obj4 + 4;
					if ((nint)obj19 > -1)
					{
						object obj20 = obj19 + -1;
						obj19 = obj20;
					}
					goto IL_02b3;
				}
			}
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				return;
			}
			obj12 = 0;
		}
		else
		{
			obj12 = 0;
		}
		goto IL_02b3;
		IL_02b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj21 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj21 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj22 = obj4 + 4;
		object obj23 = obj22 + 1;
		obj22 = obj23;
		object obj24 = obj23 << 2;
		object obj25 = obj4 + obj24;
		obj25 = 153;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj26 = (nint)0 << 2;
			object obj27 = obj4 + obj26;
			if ((nint)obj27 == 153)
			{
				object obj28 = obj4 + 4;
				if ((nint)obj28 > -1)
				{
					object obj29 = obj28 + -1;
					obj28 = obj29;
				}
				return;
			}
		}
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void ClosePopup(string screenName)
	{
		//IL_0010: Expected I4, but got Obj
		SetCoinRewardAmount((int)"");
	}

	public void DebugCloseAllPopups()
	{
		//IL_0010: Expected I4, but got Obj
		SetCoinRewardAmount((int)"");
	}

	private void _PauseAnimations(bool pause, Transform trans)
	{
		//IL_0120: Expected Obj, but got I4
		//IL_0132: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_00c0: Expected I, but got Obj
		UIScreen uIScreen = _cachedScreens.get_Item((string)pause);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIScreen).FindKernel((string)null) == 0)
		{
			return;
		}
		string text = uIScreen.tag;
		BackBtnBehaviour component = ((GameObject)(object)text).GetComponent<BackBtnBehaviour>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component.tag = (string)(object)trans;
		}
	}

	public void SaveAndDelayPopups()
	{
		//IL_0022: Expected I4, but got Obj
		List<string> popupQueue = _popupQueue;
		int num = popupQueue._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 >= 0)
			{
				string text = _popupQueue.get_Item(num2);
				SetCoinRewardAmount((int)text);
				num = num2;
				continue;
			}
			break;
		}
	}

	public void RequeueDelayedPopups()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		doSaveAndDelayRemainingPopups = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 66)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_0251;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		goto IL_0251;
		IL_0251:
		throw new IndexOutOfRangeException();
	}

	private void _RemovePopup(string screenName = "")
	{
		//IL_000a: Expected I4, but got Obj
		SetCoinRewardAmount((int)screenName);
	}

	public void SpawnCollectText(Vector3 startPosition, string text)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I4
		//IL_0489: Expected I, but got Obj
		//IL_049f: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_021e: Expected I, but got Obj
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_0266: Invalid comparison between VT and I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_0350: Expected I, but got Obj
		//IL_0366: Expected Obj, but got I
		//IL_0391: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object current = ((Transform.Enumerator)(object)text).Current;
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 56)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				goto IL_046e;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_046e;
		IL_046e:
		CharacterModel component = ((Component)(object)text).GetComponent<CharacterModel>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v64 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			return;
		}
		if (startPosition != (Vector3)(object)0)
		{
			CharacterModel component2 = ((Component)(object)text).GetComponent<CharacterModel>();
			component2.PauseIdleAnimations();
			return;
		}
		string text2 = ((UIScreenController)null).Pop(_screenStack);
		if (!(text2 != "BoardScreen"))
		{
			string text3 = ((Component)(object)text).tag;
			string text4 = ((GameObject)(object)text3).tag;
			if (text4 != null)
			{
				CharacterModel component3 = ((Component)(object)text).GetComponent<CharacterModel>();
				((CharacterPickupParticles)(object)component3).PickedUpCoin((Transform)null);
			}
			return;
		}
		nint num3 = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v46 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num4 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v52 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoinMagnet instance = CoinMagnet.Instance;
		((HoverboardModelPreviewFactory)(object)instance).OpenGlider();
	}

	private IEnumerator AnimateCollectText(UILabel collectText)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02fb: Expected Obj, but got I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I
		//IL_03a2: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj6 != null)
				{
					object obj7 = obj4 + 4;
					object obj8 = obj7 + 1;
					obj7 = obj8;
					object obj9 = obj8 << 2;
					object obj10 = obj4 + obj9;
					obj10 = 60;
					break;
				}
				continue;
			}
			object obj11 = obj4 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj4 + obj13;
			obj14 = 58;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 60)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_039c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 58)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_039c;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_039c;
		IL_039c:
		return (IEnumerator)1;
	}

	private IEnumerator AnimateAlpha(UILabel label, float duration, float toAlpha)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = label;
		return enumerator;
	}

	private IEnumerator MoveTransform(Transform trans, float duration, Vector3 toPos)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public void SetCoinRewardAmount(int coins)
	{
		//IL_06ce: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I4
		//IL_0742: Expected Obj, but got I
		//IL_0752: Expected Obj, but got I
		//IL_0762: Expected Obj, but got I
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected Obj, but got Unknown
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected Obj, but got Unknown
		//IL_08c7: Expected I, but got Obj
		//IL_08dd: Expected Obj, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0165: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_03b4: Expected I4, but got Obj
		//IL_03c2: Expected Obj, but got I4
		//IL_0205: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I
		//IL_0118: Expected I, but got Obj
		//IL_0246: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected Obj, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		//IL_058e: Expected I, but got Obj
		//IL_05a4: Expected Obj, but got I
		//IL_0436: Expected I4, but got Obj
		//IL_05cf: Expected I, but got Obj
		//IL_030e: Expected Obj, but got I
		//IL_031e: Expected Obj, but got I
		//IL_032e: Expected Obj, but got I
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_0645: Expected I, but got Obj
		//IL_065b: Expected Obj, but got I
		//IL_0686: Expected I, but got Obj
		//IL_04ed: Expected Obj, but got I4
		//IL_0523: Expected Obj, but got I4
		object obj = 0;
		List<string> popupQueue = _popupQueue;
		if (popupQueue._size <= 0)
		{
			return;
		}
		int num;
		if ((string)coins != "")
		{
			bool flag = ((UIScreenController)null).IsPopupAlreadyQueued((string)(object)_popupQueue);
			num = (flag ? 1 : 0);
		}
		else
		{
			bool flag2 = _popupQueue.Remove((string)coins);
			num = coins;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		object obj2 = default;
		if (obj2 != null)
		{
			((UIScreen)obj).Show();
			object obj3 = obj + 36;
			obj3 = "";
		}
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S2_v6 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S2_v7+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v8+44]");
		object obj6 = 0;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v124 @ S3_v7 (should have been resolved before IL gen)");
		object obj9 = default;
		if ((nint)obj9 > -1)
		{
			List<string> popupQueue2 = _popupQueue;
			if (popupQueue2._size == 0)
			{
				nint num3 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v171 (Il2CppClass<BoardScreenManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num4 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v177 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				HoverboardModelPreviewFactory instance = HoverboardModelPreviewFactory.Instance;
				_ = 1;
			}
		}
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v30 (Il2CppClass<UIScreenController>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v158 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UIScreenController.m_OnPopupClosed != null)
		{
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S2_v42 (Il2CppMethodInfo)+18]");
			object obj12 = 0;
			object obj13 = obj12;
			object obj14 = obj13 & 0x3FFF;
			object obj15 = obj14 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S3_v29 (should have been resolved before IL gen)");
		}
		_popupActive = false;
		List<string> popupQueue3 = _popupQueue;
		if (popupQueue3._size == 0)
		{
			IEnumerator enumerator = DelayHideMainCamera();
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v128 (Il2CppClass<UIScreenController>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num9 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v151 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UIScreenController.m_OnChangedScreen != null)
			{
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S2_v39 (Il2CppMethodInfo)+18]");
				object obj17 = 0;
				object obj18 = obj17;
				object obj19 = obj18 & 0x3FFF;
				object obj20 = obj19 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v297 @ S3_v25 (should have been resolved before IL gen)");
			}
			bool flag3;
			if (enumerator != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v126 (System.Collections.IEnumerator)+8]");
				flag3 = (nint)0 == 0;
			}
			else
			{
				flag3 = true;
			}
			if (!flag3)
			{
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S2_v34 (Il2CppMethodInfo)+C]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S2_v35+60]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S2_v36+44]");
				object obj23 = 0;
				object obj24 = obj23 & 0x1FFF;
				object obj25 = obj24 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v227 @ S3_v19 (should have been resolved before IL gen)");
				object obj26 = default;
				if ((nint)obj26 > -1)
				{
					UIScreen uIScreen = _cachedScreens.get_Item((string)(object)enumerator);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
		}
		if (~(doSaveAndDelayRemainingPopups ? 1u : 0u) == 0)
		{
			RequeueDelayedPopups();
		}
		ActivateAnchors((byte)(int)"" != 0);
		if ((string)num != "CelebrationPopup")
		{
			List<string> screenStack = _screenStack;
			if (screenStack._size >= 1)
			{
				IEnumerator enumerator2 = DelayHideMainCamera();
				if (((string)(object)enumerator2).get_Chars((int)"GameOverScreen") != '\0')
				{
					List<string> screenStack2 = _screenStack;
					int index = screenStack2._size - 1;
					string key = _screenStack.get_Item(index);
					UIScreen uIScreen2 = _cachedScreens.get_Item(key);
					uIScreen2.HideIfActive();
					bool flag4 = isShowingPopup;
					if (IsPopupQueueEmpty() && ((string)flag4 != "CoinsUI_quick" || (string)flag4 != "NotEnoughCurrencyPopup"))
					{
						QueuePopupRightAfterCurrentActivePopup(null);
					}
				}
			}
			IEnumerator enumerator3 = DelayHideMainCamera();
			if ((string)(object)enumerator3 != "GameOverScreen")
			{
				UIScreen uIScreen3 = _cachedScreens.get_Item("GameOverScreen");
				GameOverScreen component = uIScreen3.GetComponent<GameOverScreen>();
				component.UpdateUpgradeSticker();
			}
		}
		List<string> popupQueue4 = _popupQueue;
		if (popupQueue4._size != 0)
		{
			return;
		}
		nint num12 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v62 (Il2CppClass<UIScreenController>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num13 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v86 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UIScreenController.m_OnLastPopupClosed == null)
		{
			return;
		}
		if (~(ignoreLastPopupClosed ? 1u : 0u) == 0)
		{
			ignoreLastPopupClosed = false;
			return;
		}
		nint num14 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v72 (Il2CppClass<UIScreenController>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num15 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S0_v79 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
	}

	private void PreloadAllSlideIn()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 54;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 54)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				goto IL_0246;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		goto IL_0246;
		IL_0246:
		throw new IndexOutOfRangeException();
	}

	private T InstantiateSlideIn<T>() where T : UISlideIn
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected Obj, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af9: Expected Obj, but got Unknown
		//IL_0b02: Expected Obj, but got I4
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected Obj, but got Unknown
		//IL_0b25: Expected Obj, but got I4
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected Obj, but got Unknown
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b62: Expected Obj, but got Unknown
		//IL_0b70: Expected Obj, but got I
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Expected Obj, but got Unknown
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected Obj, but got Unknown
		//IL_0c7b: Expected Obj, but got I4
		//IL_002b: Expected Obj, but got I4
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0c08: Expected Obj, but got I
		//IL_0c23: Expected Obj, but got I4
		//IL_011b: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d30: Expected Obj, but got Unknown
		//IL_0d39: Expected Obj, but got I4
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Expected Obj, but got Unknown
		//IL_0cda: Expected Obj, but got I
		//IL_0c3b: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I4
		//IL_01ca: Expected Obj, but got I4
		//IL_016f: Expected I, but got Obj
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected Obj, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Expected Obj, but got Unknown
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected Obj, but got Unknown
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Expected Obj, but got Unknown
		//IL_01e2: Expected Obj, but got I4
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected Obj, but got Unknown
		//IL_0932: Expected Obj, but got I
		//IL_01f0: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_0d55: Expected Obj, but got I4
		//IL_09e4: Expected Obj, but got I
		//IL_0c5b: Expected Obj, but got I4
		//IL_0aa5: Expected Obj, but got I4
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Expected I4, but got Unknown
		//IL_0ac5: Expected Obj, but got I4
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1f: Expected Obj, but got Unknown
		//IL_02d5: Expected Obj, but got I
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I4
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I4
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Expected Obj, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected Obj, but got Unknown
		//IL_0812: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 32;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 8;
		obj5 = 0;
		object obj6 = obj2 + 24;
		obj6 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj7 = obj2 + 56;
		nint num = default;
		object obj8 = num + 24;
		object obj9 = obj8;
		object obj10 = obj9;
		object obj11 = obj10 & 0x3FFF;
		object obj12 = obj11 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S3_v5 (should have been resolved before IL gen)");
		obj4 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26+10]");
		_ = 0;
		object obj15 = default;
		object obj26 = default;
		object obj14;
		while (true)
		{
			object obj13 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj14 = 40;
			bool flag = obj15 == null;
			obj14 = 41;
			if (flag)
			{
				break;
			}
			object obj16 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj14 = 8;
			obj5 = obj2;
			object obj17 = obj8;
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v133 (Il2CppClass<System.Type>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v252 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj14 = 9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v130+8]");
			obj3 = 0;
			obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj14 = 15;
			object obj19 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj14 = 16;
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v155 (Il2CppClass<System.Enum>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v244 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj14 = 16;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj14 = 21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj14 = 22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj14 = 22;
			object obj21 = 0;
			while (true)
			{
				object obj22 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj14 = 32;
				object obj23 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ S0_v185+C]");
				if ((nint)obj23 >= 0)
				{
					break;
				}
				object obj24 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj14 = 30;
				object obj25 = obj26 + 16;
				object obj27 = obj21 << 2;
				object obj28 = obj25 + obj27;
				obj7 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj14 = 31;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				obj14 = 31;
				object obj29 = obj21 + 1;
				obj21 = obj29;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v169+10]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v169+14]");
			object obj30 = num6 + 0;
			object obj31 = obj30 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj14 = 38;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj14 = 39;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		}
		object obj32 = obj14 - 8;
		object obj39;
		object obj40 = default;
		object obj37;
		if ((nint)obj14 != 8 && (nint)obj32 != 1)
		{
			if ((nint)obj32 != 2 && (nint)obj32 != 3 && (nint)obj32 != 4 && (nint)obj32 != 5 && (nint)obj32 != 6)
			{
				if ((nint)obj32 == 7 || (nint)obj32 == 8)
				{
					goto IL_0817;
				}
				if ((nint)obj32 != 9 && (nint)obj32 != 10 && (nint)obj32 != 11 && (nint)obj32 != 12)
				{
					if ((nint)obj32 == 13 || (nint)obj32 == 14)
					{
						goto IL_0817;
					}
					if ((nint)obj32 != 15 && (nint)obj32 != 16 && (nint)obj32 != 17 && (nint)obj32 != 18 && (nint)obj32 != 19 && (nint)obj32 != 20 && (nint)obj32 != 21)
					{
						if ((nint)obj32 != 22)
						{
							if ((nint)obj32 != 23)
							{
								if ((nint)obj32 != 24)
								{
									if ((nint)obj32 == 25 || (nint)obj32 == 26 || (nint)obj32 == 27 || (nint)obj32 == 28 || (nint)obj32 == 29)
									{
										goto IL_0cfe;
									}
									if ((nint)obj32 != 30)
									{
										if ((nint)obj32 != 31)
										{
											if ((nint)obj32 != 32)
											{
												if ((nint)obj32 == 33)
												{
													object obj33 = obj6 + 4;
													object obj34 = obj33 + 1;
													obj33 = obj34;
													object obj35 = obj34 << 2;
													object obj36 = obj6 + obj35;
													obj36 = 179;
												}
												goto IL_0cfe;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj38 = default;
											obj37 = obj38;
											obj39 = obj40;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj41 = default;
											obj37 = obj41;
											obj39 = obj40;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj42 = default;
										obj37 = obj42;
										obj39 = obj40;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj43 = default;
									obj37 = obj43;
									obj39 = obj40;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj44 = default;
								obj37 = obj44;
								obj39 = obj40;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj45 = default;
							obj37 = obj45;
							obj39 = obj40;
						}
						goto IL_0c85;
					}
				}
			}
			goto IL_0cfe;
		}
		goto IL_0817;
		IL_0817:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj46 = default;
		obj37 = obj46;
		obj39 = obj40;
		goto IL_0c85;
		IL_0d3e:
		object obj47 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
		if ((nint)obj47 >= 1)
		{
			object obj48 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
			int index = obj48 - 1;
			StringBuilder stringBuilder2 = stringBuilder.Insert(index, (string)1);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		T result = default;
		return result;
		IL_0c85:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj49 = default;
		if (obj39 == obj49)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0cfe;
		IL_0cfe:
		object obj50 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @91BB");
		object obj51 = obj7;
		object obj52 = obj7 + 88;
		object obj53 = 0;
		object obj66 = default;
		while (true)
		{
			object obj54 = obj53 & 0xFFFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v47+B2]");
			object obj55 = (nint)0 & (nint)0xFFFF;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj55))
			{
				object obj56 = obj53 + 1;
				object obj57 = obj56 << 16;
				object obj58 = obj57 >> 16;
				object obj59 = obj53 & 0xFFFF;
				object obj60 = obj59 << 3;
				object obj61 = obj52 + obj60;
				if (obj61 != typeof(IDisposable))
				{
					obj53 = obj58;
					continue;
				}
				object obj62 = obj7 + 188;
				object obj63 = obj59 << 3;
				object obj64 = obj52 + obj63;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S2_v42+4]");
				object obj65 = (nint)0 << 3;
				obj66 = obj62 + obj65;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11C74");
			break;
		}
		object obj67 = obj66 & 0x3FFF;
		object obj68 = obj67 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v502 @ S2_v19 (should have been resolved before IL gen)");
		object obj69 = obj7 + 8;
		obj4 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S1_v42+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S1_v42+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
			object obj70 = (nint)0 << 2;
			object obj71 = obj6 + obj70;
			if ((nint)obj71 == 179)
			{
				object obj72 = obj6 + 4;
				if ((nint)obj72 > -1)
				{
					object obj73 = obj72 + -1;
					obj72 = obj73;
				}
				goto IL_0d3e;
			}
		}
		object obj74 = default;
		if (obj74 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0d3e;
	}

	private void OnMissionCompleted(string message, int missionIndex)
	{
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I4
		//IL_006e: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00fa: Expected VT, but got Obj
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_02d1: Expected Obj, but got I4
		//IL_02e0: Expected Obj, but got F4
		//IL_031c: Expected I4, but got Obj
		//IL_01ce: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_0222: Expected I4, but got Obj
		//IL_0230: Expected Obj, but got I4
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v72 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NullReferenceException ex = new NullReferenceException();
		string text = ((Component)(object)ex).tag;
		int layer = ((GameObject)(object)text).layer;
		bool activeSelf = superPopupAnchor.activeSelf;
		((AssignTextureAndMaterial)layer)._003CAwake_003Eb__3_0((Material)activeSelf);
		((UILabel)(object)ex).fontSize = missionIndex;
		GameObject gameObject = ((Component)(object)ex).gameObject;
		object obj3 = default;
		object obj2 = obj3 + 52;
		obj2 = message;
		_ = message.m_stringLength;
		object obj4 = obj3 + 40;
		obj4 = message;
		_ = message.m_stringLength;
		Transform transform = (Transform)(obj3 + 28);
		Camera anchorCamera = ((UIRect)(object)ex).anchorCamera;
		transform.position = (Vector3)anchorCamera;
		object obj5 = obj3 + 16;
		obj5 = 0;
		_ = 0;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v22+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Transform transform2 = (Transform)(obj3 - -64);
		transform2 = (Transform)obj5;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v31+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform2.localPosition;
		((UILabel)(object)ex).ambigiousFont = FloatingTextFont;
		((UILabel)(object)ex).fontStyle = (FontStyle)20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v10 (System.NullReferenceException)+13C]");
		if ((nint)0 != 0)
		{
			_ = 0;
			((Exception)ex)._dynamicMethods = 1;
			_ = 1;
		}
		Vector4 drawingDimensions = ((UILabel)null).drawingDimensions;
		_ = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v10 (System.NullReferenceException)+164]");
		if ((nint)0 != 2)
		{
			_ = 2;
			((Exception)ex)._dynamicMethods = 1;
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		obj3 = 0;
		_ = 0;
		obj3 = 250f / 255f;
		_ = 198f / 255f;
		_ = 60f / 255f;
		_ = 0f;
		transform2 = (Transform)obj3;
		Transform transform4 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((UIWidget)(object)ex).rawPivot = (UIWidget.Pivot)transform2;
		string text2 = ((Component)(object)ex).tag;
		UIPanel uIPanel = ((GameObject)(object)text2).AddComponent<UIPanel>();
		uIPanel.sortingOrder = 11;
		bool flag = UniqueAlreadyInQueue((SlideInData.SlideInType)ex);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)flag);
	}

	private void OnMissionSetCompleted()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_0466: Expected Obj, but got I4
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0033: Expected VT, but got Obj
		//IL_003b: Expected Obj, but got VT
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0050: Expected VT, but got Obj
		//IL_005d: Expected Obj, but got VT
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0072: Expected VT, but got Obj
		//IL_007a: Expected Obj, but got VT
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_008f: Expected VT, but got Obj
		//IL_009c: Expected Obj, but got VT
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b1: Expected VT, but got Obj
		//IL_00b9: Expected Obj, but got VT
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00ce: Expected VT, but got Obj
		//IL_00db: Expected Obj, but got VT
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_00f0: Expected VT, but got Obj
		//IL_00f8: Expected Obj, but got VT
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_010d: Expected VT, but got Obj
		//IL_011a: Expected Obj, but got VT
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_012f: Expected VT, but got Obj
		//IL_0137: Expected Obj, but got VT
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014c: Expected VT, but got Obj
		//IL_0159: Expected Obj, but got VT
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016e: Expected VT, but got Obj
		//IL_0176: Expected Obj, but got VT
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_018b: Expected VT, but got Obj
		//IL_0198: Expected Obj, but got VT
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ad: Expected VT, but got Obj
		//IL_01b5: Expected Obj, but got VT
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01ca: Expected VT, but got Obj
		//IL_01d7: Expected Obj, but got VT
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01ec: Expected VT, but got Obj
		//IL_01f4: Expected Obj, but got VT
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0209: Expected VT, but got Obj
		//IL_0216: Expected Obj, but got VT
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_022b: Expected VT, but got Obj
		//IL_0233: Expected Obj, but got VT
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0248: Expected VT, but got Obj
		//IL_0255: Expected Obj, but got VT
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_026a: Expected VT, but got Obj
		//IL_0272: Expected Obj, but got VT
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0332: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (~(_slideHasPreloaded ? 1u : 0u) == 0)
		{
			return;
		}
		_slideHasPreloaded = true;
		object obj5 = this + 136;
		_0021_00210 val = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj5 = val;
		object obj6 = this + 140;
		_0021_00210 val2 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj6 = val2;
		object obj7 = this + 144;
		_0021_00210 val3 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj7 = val3;
		object obj8 = this + 148;
		_0021_00210 val4 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj8 = val4;
		object obj9 = this + 152;
		_0021_00210 val5 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj9 = val5;
		object obj10 = this + 160;
		_0021_00210 val6 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj10 = val6;
		object obj11 = this + 164;
		_0021_00210 val7 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj11 = val7;
		object obj12 = this + 168;
		_0021_00210 val8 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj12 = val8;
		object obj13 = this + 156;
		_0021_00210 val9 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj13 = val9;
		object obj14 = this + 172;
		_0021_00210 val10 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj14 = val10;
		object obj15 = this + 176;
		_0021_00210 val11 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj15 = val11;
		object obj16 = this + 180;
		_0021_00210 val12 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj16 = val12;
		object obj17 = this + 184;
		_0021_00210 val13 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj17 = val13;
		object obj18 = this + 188;
		_0021_00210 val14 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj18 = val14;
		object obj19 = this + 192;
		_0021_00210 val15 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj19 = val15;
		object obj20 = this + 196;
		_0021_00210 val16 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj20 = val16;
		object obj21 = this + 200;
		_0021_00210 val17 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj21 = val17;
		object obj22 = this + 204;
		_0021_00210 val18 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj22 = val18;
		object obj23 = this + 208;
		_0021_00210 val19 = (_0021_00210)Utils.FindObject<T>((MonoBehaviour)this);
		obj23 = val19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj24 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj24 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		}
		object obj25 = obj4 + 4;
		object obj26 = obj25 + 1;
		obj25 = obj26;
		object obj27 = obj26 << 2;
		object obj28 = obj4 + obj27;
		obj28 = 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj29 = (nint)0 << 2;
			object obj30 = obj4 + obj29;
			if ((nint)obj30 == 304)
			{
				object obj31 = obj4 + 4;
				if ((nint)obj31 > -1)
				{
					object obj32 = obj31 + -1;
					obj31 = obj32;
				}
				return;
			}
		}
		object obj33 = default;
		if (obj33 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void OnLetterPickedUp()
	{
		//IL_00f8: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_00f8: Expected Obj, but got I4
		//IL_0013: Expected I4, but got Obj
		//IL_004c: Expected I4, but got Obj
		//IL_008a: Expected I4, but got Obj
		//IL_008a: Expected Obj, but got I4
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)instance)._002Ector((AwardStaticData)39, (PersistentAwardProgress)1, (Action<Award>)(-1));
		IEnumerator enumerator = DelayHideMainCamera();
		if (((string)(object)enumerator).get_Chars((int)"ChallengesScreen") == '\0')
		{
			return;
		}
		IEnumerator enumerator2 = DelayHideMainCamera();
		if (((string)(object)enumerator2).get_Chars((int)"PauseUI") != '\0')
		{
			bool flag = isShowingPopup;
			if (((string)flag).get_Chars((int)"DebugSettingsPopup") != '\0')
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text = default;
				text.m_stringLength = 2;
				_QueueMessage(text);
			}
		}
	}

	private void OnTokenCollected(Characters.CharacterId id)
	{
		//IL_000f: Expected Obj, but got I4
		_missionSetSlideIn.NewCoinAmount((string)id);
	}

	private void OnWillNavigateToScreenHandler(string screen)
	{
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_02a4: Expected I4, but got Obj
		//IL_02b6: Expected I, but got Obj
		//IL_02cc: Expected Obj, but got I
		//IL_0205: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0247: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0291: Expected I4, but got Obj
		//IL_017c: Expected I, but got Obj
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v48 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)screen);
		nint num3 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v5 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v18 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int outfitIndex = CharacterManager.GetOutfitIndex((Characters.CharacterId)screen);
		if (model.Price > outfitIndex)
		{
			return;
		}
		nint num5 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v42 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model2 = Characters.characterData.get_Item((Characters.CharacterId)screen);
		if (model2.unlockType != PurchaseData.UnlockType.Tokens)
		{
			return;
		}
		nint num7 = (nint)typeof(RewardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v29 (Il2CppClass<RewardManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(RewardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v36 (Il2CppClass<RewardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RewardManager.canShowMultipleQueuedCelebrations = true;
		ShowUnlockAnimationForHoverboard((Boards.BoardId)screen);
	}

	private void SetMenuCamerasEnabled(bool state)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		bool flag = (string)state != "IngameUI";
		string message = (string)((flag ? 1 : 0) ^ 1);
		QueueErrorMessageSlidein(message);
	}

	public void QueueErrorMessageSlidein(string message)
	{
		Camera3D.tag = message;
		Camera3DClip.tag = message;
		Camera3DOverlay.tag = message;
		CameraOverlay2dClipping.tag = message;
	}

	public void QueueSlideIn(SlideIn slideIn)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 7;
		object obj = text + 12;
		obj = slideIn;
		_QueueMessage(text);
	}

	private bool UniqueAlreadyInQueue(SlideInData.SlideInType type)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = type;
		return flag;
	}

	public void ReadyForNextSlide()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 3;
		_QueueMessage(text);
	}

	private void ShowSlideIn()
	{
		_slideInActive = false;
		if (~(_slideInActive ? 1u : 0u) != 0)
		{
			ReadyForNextMessage();
		}
	}

	private UISlideIn GetCachedSlideIn(SlideInData.SlideInType slideType)
	{
		//IL_0088: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<SlideInData.SlideInType> uniqueSlideInTypes = _uniqueSlideInTypes;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		IOrderedEnumerable<_0021_00210> orderedEnumerable = (IOrderedEnumerable<_0021_00210>)Enumerable.OrderByDescending<TSource, TKey>((IEnumerable<TSource>)uniqueSlideInTypes, (Func<TSource, TKey>)0);
		if (orderedEnumerable != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Func<_0021_00210, bool> func = default;
			object obj = func + 16;
			object obj2 = default;
			obj = obj2;
			bool flag = Enumerable.All<TSource>((IEnumerable<TSource>)_slideInQueue, (Func<TSource, bool>)(object)func);
			return (UISlideIn)flag;
		}
		return null;
	}

	public void ReadyForNextMessage()
	{
		//IL_003d: Expected Obj, but got I4
		//IL_005e: Expected I, but got Obj
		//IL_0074: Expected Obj, but got I
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_01ca: Expected I4, but got Obj
		//IL_01e1: Expected Obj, but got I4
		//IL_009f: Expected I, but got Obj
		//IL_00ec: Expected I, but got Obj
		List<SlideIn> slideInQueue = _slideInQueue;
		if (slideInQueue._size <= 0)
		{
			return;
		}
		SlideIn slideIn = _slideInQueue.get_Item(0);
		_slideInQueue.RemoveAt(0);
		int num = Utility.CompareVersions((string)(object)this, (string)slideIn.type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		nint num2 = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v19 (Il2CppClass<So>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num4 = (nint)typeof(SlideInData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v10 (Il2CppClass<UI.SlideIns.SlideInData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(SlideInData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v18 (Il2CppClass<UI.SlideIns.SlideInData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ScrollListSelectPopup instance = ScrollListSelectPopup.instance;
		bool flag = ((UISlideInCharacterEventHelper)(object)instance).IsFilteredCharacter((char)(int)slideIn);
		HoverboardBundle hoverboardBundle = ((CharacterModel)(object)So.Instance).AddHoverboard((string)flag, false);
		_slideInActive = true;
	}

	private void _QueueMessage(string message)
	{
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AgeRestriction.shouldDisplayPopup)
		{
			return;
		}
		UISlideIn cachedSlideIn = GetCachedSlideIn((SlideInData.SlideInType)message.m_stringLength);
		if ((object)cachedSlideIn != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		if (~(_slideInActive ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @790E");
			object obj2 = default;
			if (obj2 == null)
			{
				ReadyForNextMessage();
			}
		}
	}

	private void _ShowNextMessage()
	{
		_messageShowing = false;
		HideInAppPurchaseOverlay();
	}

	public void ShowInAppPurchaseOverlay(string overlayText)
	{
		_messageQueue.Enqueue(overlayText);
		if (~(_messageShowing ? 1u : 0u) != 0)
		{
			HideInAppPurchaseOverlay();
		}
		if (~(_slideInActive ? 1u : 0u) != 0)
		{
			ReadyForNextMessage();
		}
	}

	public void HideInAppPurchaseOverlay()
	{
		//IL_0028: Expected I4, but got Obj
		Queue<string> messageQueue = _messageQueue;
		if (messageQueue._size > 0)
		{
			string text = _messageQueue.Dequeue();
			((UIModelController)(object)messageHelper).ActivateCelebrationBoardWithStripes((Boards.BoardId)text, UIModelController.ModelScreen.Character);
			_messageShowing = true;
		}
	}

	public void DelayedHideInAppPurchaseOverlay()
	{
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_00ce: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I4
		inAppPurchaseOverlay.tag = null;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v20 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (System.Boolean)+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14+8]");
		if ((nint)0 == 0)
		{
			Camera3D.tag = (string)1;
		}
	}

	private IEnumerator HideInAppPurchaceOverlayDelayedCoroutine()
	{
		//IL_0028: Expected Obj, but got I4
		List<string> popupQueue = _popupQueue;
		bool flag = popupQueue._size < 1;
		return (IEnumerator)flag;
	}

	public bool IsInAppPurchaseOverlayVisible()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	public void ShowAdsOverlay()
	{
		//IL_003b: Expected Obj, but got I4
		if (inAppPurchaseOverlay.activeInHierarchy)
		{
			bool flag = IsInAppPurchaseOverlayVisible();
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])flag);
		}
	}

	public void HideAdsOverlay()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError("FBAdsBridge ShowingAdsOverlay");
		adsOverlay.tag = (string)1;
	}

	private IEnumerator HideAdsOverlayWithDelay(float delay)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	public bool IsAdsOverlayVisible()
	{
		//IL_000f: Expected I4, but got Obj
		return (byte)(int)inAppPurchaseOverlay.tag != 0;
	}

	public void ShowTransitionAdsOverlay()
	{
		IEnumerator routine = HideTransitionAdsOverlayWithDelay(0.3f);
		Coroutine coroutine = StartCoroutine_Auto(routine);
		IEnumerator routine2 = HideTransitionAdsOverlayWithDelay(0.3f);
		Coroutine coroutine2 = StartCoroutine_Auto(routine2);
	}

	private IEnumerator HideTransitionAdsOverlayWithDelay(float delay)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	public void ShowDiskSpaceErrorOverlay()
	{
		//IL_0010: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		transitionAdsOverlay.tag = (string)1;
		CoroutineUtil.StopCoroutine((Coroutine)(object)_transitionAdsOverlayCoroutine);
		object obj = this + 248;
		bool flag = ((Range)(object)this).IsValueWithinRange(0.5f);
		obj = flag;
		Coroutine coroutine = StartCoroutine_Auto(_transitionAdsOverlayCoroutine);
	}

	public void ShowVideoAdsOverlay(string adLocationID)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnOverlayManuallyClosed;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)adLocationID);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 280;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public void HideVideoAdsOverlay(bool forceHide = false)
	{
		//IL_00fc: Expected Obj, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got I4
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_0150: Expected I4, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I4
		//IL_007b: Expected I, but got Obj
		videoAdsOverlay.tag = (string)1;
		_allowInputOnVideoAdsOverlay = false;
		object obj = this + 268;
		OfferWallManager instance = OfferWallManager.instance;
		string currentProviderIDForLocation = ((AdSystemManager)(object)instance).GetCurrentProviderIDForLocation(_locationID);
		obj = currentProviderIDForLocation;
		object obj2 = this + 272;
		obj2 = forceHide;
		videoAdsOverlayCloseButton.tag = null;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v12 (Il2CppClass<Strings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v24 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("AD_OVERLAY_LOADING");
		videoAdsOverlayLabel.fontSize = (int)text;
		CoroutineUtil.StopCoroutine((Coroutine)(object)_videoAdsOverlayInputCoroutine);
		object obj4 = this + 276;
		bool flag = IsVideoAdsOverlayVisible();
		obj4 = flag;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_videoAdsOverlayInputCoroutine);
	}

	private IEnumerator DelayInputOnOverlay()
	{
		return (IEnumerator)(object)adsOverlay.tag;
	}

	public bool IsVideoAdsOverlayVisible()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	private void EnableGeneralDebugLabelIfNeeded()
	{
		//IL_0010: Expected Obj, but got I4
		videoAdsOverlay.tag = (string)1;
		_allowInputOnVideoAdsOverlay = false;
	}

	private void AddBackButtonBehavior(string screenName)
	{
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0062: Expected I, but got Obj
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I
		//IL_013a: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_022e: Expected I, but got Obj
		//IL_0244: Expected Obj, but got I
		//IL_0378: Expected I, but got Obj
		//IL_038e: Expected Obj, but got I
		//IL_026f: Expected I, but got Obj
		//IL_02bc: Expected I, but got Obj
		bool flag;
		if (~(_allowInputOnVideoAdsOverlay ? 1u : 0u) == 0)
		{
			flag = true;
		}
		else
		{
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v50 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v57 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Globals.DEBUG_SKIP_VIDEO_ADS;
		}
		object obj2 = screenName & 1;
		object obj3 = flag | obj2;
		if (obj3 != null)
		{
			videoAdsOverlayCloseButton.tag = null;
			videoAdsOverlay.tag = null;
		}
		bool allowInputOnVideoAdsOverlay = _allowInputOnVideoAdsOverlay;
		object obj4 = screenName ^ 1;
		object obj5 = allowInputOnVideoAdsOverlay & obj4;
		if (obj5 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S3_v4+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v114 @ S4_v5 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S4_v8+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S4_v9+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v131 @ S5_v7 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S4_v12 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S4_v13+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S4_v14+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v78 @ S5_v11 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v23 (Il2CppClass<Flurry>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v41 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num8 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v28 (Il2CppClass<HouseKeeper>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num9 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v37 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper.RefreshOnlineSettingsAndInappsIfNeeded();
		if (this.m_OnOverlayManuallyClosed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public unsafe void SetViewportRectXForCamera(Camera camera, float x)
	{
		//IL_025c: Expected Obj, but got Ref
		//IL_0265: Expected Obj, but got I4
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_02ae: Invalid comparison between I and F4
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0016: Invalid comparison between I and F4
		//IL_020e: Expected I, but got Obj
		//IL_0038: Expected I, but got Obj
		//IL_004e: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0334: Expected I, but got Obj
		//IL_034a: Expected Obj, but got I
		//IL_038d: Expected VT, but got I4
		//IL_038d: Expected F4, but got I
		//IL_038d: Expected Obj, but got I
		//IL_0145: Expected I, but got Obj
		ref GameCenterPlugin.LocalPlayer reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = this;
		object obj4 = obj3 + 12;
		obj4 = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+10]");
		if (!(0f < 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+10]");
			if (!(0f > 100f))
			{
				nint num = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v34 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num2 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v53 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameCenterPlugin.GetLocalPlayer(ref reference);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (LocalPlayer&)+D]");
				if ((nint)0 == 0)
				{
					return;
				}
				if (~(_isApplicationResuming ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
					object obj6 = default;
					if (obj6 != null)
					{
						object obj7 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+10]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v37+C]");
						if (num3 <= 0)
						{
							return;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint cachedPtr = 0;
				Transform transform = default;
				((UnityEngine.Object)transform).m_CachedPtr = cachedPtr;
				_ = 0;
				object obj8 = transform + 16;
				obj8 = obj3;
				nint num4 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S2_v15 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num5 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S2_v20 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+C]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+10]");
				((DistantEnvironmentController.DistantObjectSpawner)num6).Spawn(0f, (Vector3)0, transform);
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+10]");
		reference = ref *(GameCenterPlugin.LocalPlayer*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "SocialManager.ReportAchievement: percentCompleted has invalid value: " + text2 + " (must be >= 0  and <= 100)";
		nint num7 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v18 (Il2CppClass<SocialManager>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num8 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v23 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
	}

	public void SetViewportRectYForCamera(Camera camera, float y)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00c0: Expected Obj, but got I4
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected VT, but got Obj
		//IL_0079: Expected Obj, but got F4
		Camera camera2 = default;
		object obj = camera2 + 16;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Camera camera3 = (Camera)(camera2 + 32);
		if (((ComputeShader)(object)camera).FindKernel((string)null) != 0)
		{
			camera2.rect = (Rect)camera;
			obj = camera2;
			_ = ((UnityEngine.Object)camera2).m_CachedPtr;
			obj = y;
			camera3 = (Camera)obj;
			Camera camera4 = camera3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)camera4).m_CachedPtr = (IntPtr)0;
			Rect pixelRect = camera3.pixelRect;
		}
	}

	public void SetViewportRectWidthForCamera(Camera camera, float width)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_00d1: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected VT, but got Obj
		Camera camera2 = default;
		object obj = camera2 + 16;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Camera camera3 = (Camera)(camera2 + 32);
		if (((ComputeShader)(object)camera).FindKernel((string)null) != 0)
		{
			camera2.rect = (Rect)camera;
			obj = camera2;
			_ = ((UnityEngine.Object)camera2).m_CachedPtr;
			camera3 = (Camera)obj;
			Camera camera4 = camera3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)camera4).m_CachedPtr = (IntPtr)0;
			Rect pixelRect = camera3.pixelRect;
		}
	}

	public void SetViewportRectHeightForCamera(Camera camera, float height)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Expected Obj, but got I4
		//IL_00d1: Expected I, but got Obj
		//IL_00e7: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected VT, but got Obj
		Camera camera2 = default;
		object obj = camera2 + 16;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Camera camera3 = (Camera)(camera2 + 32);
		if (((ComputeShader)(object)camera).FindKernel((string)null) != 0)
		{
			camera2.rect = (Rect)camera;
			obj = camera2;
			_ = ((UnityEngine.Object)camera2).m_CachedPtr;
			camera3 = (Camera)obj;
			Camera camera4 = camera3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)camera4).m_CachedPtr = (IntPtr)0;
			Rect pixelRect = camera3.pixelRect;
		}
	}

	public void RecalculateViewportRectForClipCamera(Camera camera, bool popupSizedClip)
	{
		//IL_00d6: Expected I4, but got Obj
		//IL_001d: Expected I4, but got Obj
		//IL_005b: Expected I4, but got Obj
		//IL_005b: Expected Obj, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		IEnumerator enumerator = DelayHideMainCamera();
		if (((string)(object)enumerator).get_Chars((int)"ChallengesScreen") == '\0')
		{
			return;
		}
		IEnumerator enumerator2 = DelayHideMainCamera();
		if (((string)(object)enumerator2).get_Chars((int)"PauseUI") != '\0')
		{
			bool flag = isShowingPopup;
			if (((string)flag).get_Chars((int)"DebugSettingsPopup") != '\0')
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text = default;
				text.m_stringLength = 1;
				object obj = text + 12;
				obj = camera;
				_QueueMessage(text);
			}
		}
	}

	public void SetCameraToOrtographic(Camera camera, bool isOrtographic)
	{
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_014b: Expected Obj, but got VT
		//IL_00ae: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I4
		//IL_00fa: Expected Obj, but got VT
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)camera).FindKernel((string)null) == 0)
		{
			return;
		}
		_0021_00210 componentInChildren = (_0021_00210)((Component)camera).GetComponentInChildren<T>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
		{
			WelcomePackManager.Log((string)componentInChildren, (UnityEngine.Object)isOrtographic);
		}
	}

	public void CalculateCameraFieldOfView(Camera camera, float designedScreenWidth, float distanceToUI)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		UIWidget[] componentsInChildren = ((GameObject)(object)camera).GetComponentsInChildren<UIWidget>(true);
		object obj = componentsInChildren + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = componentsInChildren + 16;
			object obj4 = obj2 << 2;
			object label = obj3 + obj4;
			IEnumerator routine = ((UIScreenController)null).AnimateAlpha((UILabel)label, designedScreenWidth, distanceToUI);
			Coroutine coroutine = StartCoroutine_Auto(routine);
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_0641: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+5C]");
		UIScreen uIScreen = ((Dictionary<string, UIScreen>)0).get_Item((string)(object)context);
		string text = uIScreen.tag;
		BackBtnBehaviour component = ((GameObject)(object)text).GetComponent<BackBtnBehaviour>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public UIScreenController()
	{
		//IL_00f7: Expected Obj, but got I4
		//IL_0106: Expected Obj, but got F4
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		object obj = 0;
		_ = 0;
		obj = 90f;
		_ = -60f;
		_ = 0f;
		nint num = (nint)typeof(IPhoneXSupport);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<IPhoneXSupport>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v39 (Il2CppClass<IPhoneXSupport>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (IPhoneXSupport.CheckIsiPhoneXDevice())
		{
			object obj3 = obj + 4;
			nint num3 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v28 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v33 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = -IPhoneXSupport.OFFSET_TOP;
			object obj6 = obj3 + obj5;
			obj3 = obj6;
		}
		UIScreenController uIScreenController = (UIScreenController)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
	}

	static UIScreenController()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_facebookPayoutPopupQueued = true;
		UIScreenController instance = Instance;
		if ((object)instance == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = ShouldShowOnlineScreen();
		((UIScreenController)flag).QueueCelebrationPopup();
	}

	private void _003CAwake_003Eb__78_0()
	{
		//IL_027b: Expected Obj, but got I
		//IL_028b: Expected Obj, but got I
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got I
		//IL_01c8: Expected Obj, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		_isApplicationFocused = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 92;
		object obj7 = default;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj8 = this + 96;
		obj8 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list2 = default;
		list2._002Ector();
		object obj9 = this + 100;
		obj9 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list3 = default;
		list3._002Ector();
		object obj10 = this + 104;
		obj10 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj11 = this + 112;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list4 = default;
		list4._002Ector();
		list4.Add("FrontScreen");
		list4.Add("IngameUI");
		object obj13 = this + 116;
		obj13 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list5 = default;
		list5._002Ector();
		list5.Add("CloudSaveCelebrationPopup");
		object obj14 = this + 128;
		obj14 = list5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list6 = default;
		((List<T>)(object)list6)._002Ector((IEnumerable<T>)15);
		object obj15 = this + 212;
		obj15 = list6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		object obj16 = this + 220;
		object obj17 = default;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj19 = default;
		object obj18 = obj19 + 8;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v46 (Il2CppMethodInfo)+C]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v47+60]");
		object obj21 = 0;
		object obj22 = obj21;
		object obj23 = obj22 & 0xFFF;
		object obj24 = obj23 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v154 @ S2_v15 (should have been resolved before IL gen)");
		object obj25 = default;
		obj18 = obj25;
		object obj26 = this + 228;
		obj26 = obj19;
		_allowInputOnVideoAdsOverlay = true;
		object obj27 = this + 268;
		obj27 = string.Empty;
		object obj28 = this + 272;
		obj28 = string.Empty;
		CancelInvoke();
	}
}
