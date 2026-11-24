using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Info;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class HoverboardModelPreviewFactory : MonoBehaviour
{
	[Serializable]
	public class HoverboardModelSetup
	{
		public string name;

		public Vector3 eulerAngles;

		public float menuYPosition;

		public AnimationClip clipHangtime;

		public AnimationClip clipRun;
	}

	private sealed class _003CJumpDelayedEvent_003Ed__50(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public HoverboardModelPreviewFactory _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Expected Obj, but got Unknown
				//IL_006c: Expected Obj, but got I4
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Expected Obj, but got Unknown
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Expected Obj, but got Unknown
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						object obj = _003C_003E4__this - -64;
						if (obj != null)
						{
							object obj2 = _003C_003E4__this - -64;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = delay;
				object obj3 = this + 12;
				object obj4 = default;
				obj3 = obj4;
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

	private sealed class _003CSpeederEvents_003Ed__51(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public HoverboardModelPreviewFactory _003C_003E4__this;

		public float waitTime;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Expected Obj, but got Unknown
				//IL_009d: Expected Obj, but got I4
				HoverboardModelPreviewFactory hoverboardModelPreviewFactory = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						if (hoverboardModelPreviewFactory.OnSpeederEnd != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				if (hoverboardModelPreviewFactory.OnSpeederStart != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = waitTime;
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

	private sealed class _003CTeleportFXStartScale_003Ed__55(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public HoverboardModelPreviewFactory _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0540: Unknown result type (might be due to invalid IL or missing references)
				//IL_0545: Expected Obj, but got Unknown
				//IL_00bb: Expected I, but got Obj
				//IL_00d1: Expected Obj, but got I
				//IL_00fc: Expected I, but got Obj
				//IL_05bc: Expected I, but got Obj
				//IL_05d2: Expected Obj, but got I
				//IL_06b4: Expected Obj, but got I
				//IL_01e7: Expected Obj, but got I
				//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f9: Expected Obj, but got Unknown
				//IL_0202: Unknown result type (might be due to invalid IL or missing references)
				//IL_0207: Expected Obj, but got Unknown
				//IL_0210: Unknown result type (might be due to invalid IL or missing references)
				//IL_0215: Expected Obj, but got Unknown
				//IL_021e: Expected Obj, but got I4
				//IL_025b: Expected Obj, but got F4
				//IL_018d: Expected I, but got Obj
				//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_05ff: Expected Obj, but got Unknown
				//IL_0608: Expected Obj, but got I4
				//IL_061c: Expected Obj, but got I4
				//IL_0350: Expected Obj, but got I
				//IL_0362: Expected I, but got Obj
				//IL_0378: Expected Obj, but got I
				//IL_066a: Expected Obj, but got I
				//IL_03f2: Expected Obj, but got I
				//IL_0408: Expected Obj, but got I
				//IL_0418: Expected Obj, but got I
				//IL_042e: Expected Obj, but got I
				//IL_03a3: Expected I, but got Obj
				//IL_044d: Expected Obj, but got I
				//IL_0463: Expected Obj, but got I
				//IL_0478: Expected Obj, but got I
				//IL_0486: Expected I, but got Obj
				//IL_049c: Expected Obj, but got I
				//IL_0681: Expected Obj, but got I
				//IL_04c7: Expected I, but got Obj
				//IL_0516: Expected Obj, but got I
				//IL_0528: Expected Obj, but got I
				object obj = default;
				Transform transform = (Transform)(obj + 12);
				HoverboardModelPreviewFactory hoverboardModelPreviewFactory = _003C_003E4__this;
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
					_003Ctime_003E5__2 = 0f;
				}
				if (_003Ctime_003E5__2 < duration)
				{
					float unscaledTime = Time.unscaledTime;
					float num = _003Ctime_003E5__2 + unscaledTime;
					_003Ctime_003E5__2 = num;
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num3 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S2_v47 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num4 = _003Ctime_003E5__2 / duration;
					if (num4 < 0f)
					{
						num4 = 0f;
					}
					else if (num4 > 1f)
					{
						num4 = 1f;
					}
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v76 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+B0]");
					if ((UnityEngine.Object)0 != null)
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+B0]");
					GameObject gameObject = ((Component)0).gameObject;
					object obj4 = hoverboardModelPreviewFactory + 124;
					object obj5 = hoverboardModelPreviewFactory + 124;
					object obj6 = hoverboardModelPreviewFactory + 124;
					obj = 0;
					_ = 0;
					float num7 = 0.5f * num4;
					float num8 = 1f - num7;
					float num9 = num8 * (float)obj4;
					obj = num9;
					float num10 = 0.5f * num4;
					float num11 = 1f + num10;
					float num12 = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v28+4]");
					float num13 = num12 * 0f;
					float num14 = 1f - num4;
					float num15 = num14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v31+8]");
					float num16 = num15 * 0f;
					transform = (Transform)obj;
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					((Transform)(object)gameObject).parent = transform;
					if (num4 == 1f)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+B5]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+B0]");
							GameObject gameObject2 = ((Component)0).gameObject;
							nint num17 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v48 (Il2CppClass<UnityEngine.Vector3>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num18 = (nint)typeof(Vector3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v72 (Il2CppClass<UnityEngine.Vector3>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Vector3 one = Vector3.one;
							transform = (Transform)obj;
							Transform transform3 = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
							((Transform)(object)gameObject2).parent = transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+98]");
							((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+B0]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v48+90]");
							((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+B0]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v51+98]");
							((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
							((AvatarAnimations)(object)hoverboardModelPreviewFactory).Head = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+B0]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v55+94]");
							((Renderer)0).shadowCastingMode = ShadowCastingMode.Off;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+B0]");
							object obj11 = 0;
							nint num19 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj12 = (nint)0 & (nint)0x200;
							if (obj12 != null)
							{
								nint num20 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S1_v68 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v58+D0]");
							if (((ComputeShader)0).FindKernel(null) != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (HoverboardModelPreviewFactory)+B0]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v62+D0]");
								((GameObject)0).tag = null;
							}
						}
					}
					object obj14 = this + 12;
					obj14 = 0;
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

	private sealed class _003CTeleboardEndTimer_003Ed__57(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public HoverboardModelPreviewFactory _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00bb: Expected I, but got Obj
				//IL_00d1: Expected Obj, but got I
				//IL_00fc: Expected I, but got Obj
				//IL_026c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0271: Expected Obj, but got Unknown
				//IL_027a: Expected Obj, but got I4
				//IL_028e: Expected Obj, but got I4
				HoverboardModelPreviewFactory hoverboardModelPreviewFactory = _003C_003E4__this;
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
					_003Ctime_003E5__2 = 0f;
				}
				if (_003Ctime_003E5__2 < duration)
				{
					float unscaledTime = Time.unscaledTime;
					float num = _003Ctime_003E5__2 + unscaledTime;
					_003Ctime_003E5__2 = num;
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S2_v5 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num3 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num4 = _003Ctime_003E5__2 / duration;
					if (num4 < 0f)
					{
						num4 = 0f;
					}
					else if (num4 > 1f)
					{
						num4 = 1f;
					}
					if (num4 == 1f && ~(hoverboardModelPreviewFactory.teleportFxActive ? 1u : 0u) == 0)
					{
						hoverboardModelPreviewFactory.teleboardWarp.tag = null;
						((AnimatorControllerParameter)(object)hoverboardModelPreviewFactory.animator)._002Ector();
						hoverboardModelPreviewFactory.OpenGlider();
					}
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

	private HoverboardModelSetup[] hoverboards;

	private AnimationClip jumperSignature;

	private AnimationClip speederSignature;

	private AnimationClip doublejumperSignature;

	private AnimationClip lowriderSignature;

	private AnimationClip lowriderRunIdle;

	private AnimationClip teleporterSignature;

	private AnimationClip gliderSignature;

	private AnimationClip vanitySignature;

	public Action OnOpenGlider;

	public Action OnCloseGlider;

	public Action OnSpeederStart;

	public Action OnSpeederEnd;

	public Action OnJump;

	private Dictionary<string, HoverboardModelSetup> name2board;

	private string currentIdleClip;

	private GameObject teleboardWarpPrefab;

	private Material teleboardFXMaterial;

	private GameObject teleboardWarp;

	private ATeleboardMenuEffect _teleboardMenuEffect;

	private AnimationState teleboardAnimation;

	private Vector3 teleboardWarpPosition;

	private GliderAnimation gliderAnimation;

	private readonly int id_Teleboard;

	private readonly int id_Glider;

	private Animator animator;

	private Vector3 intialScale;

	private Transform root;

	private Material cachedModelMaterial;

	private Material cachedCustomizationMaterial;

	private Material[] cachedHeadMaterials;

	private Renderer cachedHoverboardBaseModelRenderer;

	private Material cachedHoverboardMaterial;

	private Material cachedSupersneakersMaterial;

	private Material cachedDoubleJumperMaterial;

	private Material[] cachedCustomHoverboardModelMaterials;

	private HoverboardBundle hoverboardBundle;

	private CharacterModel characterModel;

	private bool cachedCustomizationState;

	private bool teleportFxActive;

	private static HoverboardModelPreviewFactory instance;

	public static HoverboardModelPreviewFactory Instance
	{
		get
		{
			//IL_0145: Expected I, but got Obj
			//IL_015b: Expected Obj, but got I
			//IL_01c3: Expected I, but got Obj
			//IL_01d9: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00f8: Expected I, but got Obj
			//IL_00ab: Expected I, but got Obj
			nint num = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (BoardScreenManager._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v33 (Il2CppClass<BoardScreenManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(BoardScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v39 (Il2CppClass<BoardScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BoardScreenManager boardScreenManager = default;
				BoardScreenManager._instance = boardScreenManager;
			}
			nint num5 = (nint)typeof(BoardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<BoardScreenManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(BoardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v23 (Il2CppClass<BoardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (HoverboardModelPreviewFactory)(object)BoardScreenManager._instance;
		}
	}

	public void Awake()
	{
		CancelInvoke();
	}

	private unsafe void UIScreenController_OnApplicationResumed()
	{
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got VT
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0075: Expected I, but got Obj
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0168: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		object obj = this + 120;
		string text = tag;
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)(object)text).GetComponentInChildren<T>();
		obj = componentInChildren;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj2 = action + 16;
		obj2 = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v51 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnNavigatedToScreen -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj4 = action2 + 16;
		obj4 = this;
		UIScreenController.OnPopupShown -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr;
		((Delegate)action3).method = (nint)__ldftn(HoverboardModelPreviewFactory.UIScreenController_OnApplicationResumed);
		object obj5 = action3 + 16;
		obj5 = this;
		UIScreenController.OnApplicationResumed -= action3;
		object obj6 = hoverboards + 12;
		object obj7 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj8 = hoverboards + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			object obj11 = obj10;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S4_v4+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S4_v5+48]");
			object obj14 = 0;
			object obj15 = obj14 & 0x7FF;
			object obj16 = obj15 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S5_v5 (should have been resolved before IL gen)");
			object obj17 = obj7 + 1;
			obj7 = obj17;
		}
	}

	private void HandleOnPopupShown(string popupName)
	{
		//IL_0228: Expected I, but got Obj
		//IL_023e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_026a: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I
		//IL_0095: Expected Obj, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_01b1: Expected I, but got Obj
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_02b4: Expected Obj, but got I4
		//IL_02c1: Expected I4, but got Obj
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_0164: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)lowriderSignature).FindKernel((string)null) == 0)
		{
			return;
		}
		HoverboardBundle hoverboardBundle = ((HoverboardModelFactory)this).RequestHoverboardInstance((string)(object)lowriderSignature);
		if (popupName != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v11 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S3_v6 (should have been resolved before IL gen)");
			object obj7 = default;
			object obj6 = obj7 + 12;
			object obj8 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
			{
				object obj9 = obj7 + 16;
				object obj10 = obj8 << 2;
				object obj11 = obj9 + obj10;
				string text = ((Component)obj11).tag;
				nint num4 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v35 (Il2CppClass<Layers>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num5 = (nint)typeof(Layers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v44 (Il2CppClass<Layers>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool startupFinished = LoadLevelCtrl.StartupFinished;
				object obj13 = (startupFinished ? 1 : 0) - -64;
				((GameObject)(object)text).SetActive((byte)(int)obj13 != 0);
				object obj14 = obj8 + 1;
				obj8 = obj14;
			}
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)teleporterSignature).FindKernel((string)null) != 0)
		{
			object obj16 = teleporterSignature + 68;
			Renderer component = ((GameObject)(object)hoverboardBundle).GetComponent<Renderer>();
			obj16 = component;
		}
	}

	private void HandleOnNavigateToScreen(string obj)
	{
		//IL_0037: Expected I, but got Obj
		//IL_004d: Expected Obj, but got I
		//IL_0078: Expected I, but got Obj
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_0115: Expected I, but got Obj
		OnDestroy();
		UnityEngine.Object a = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		if (string.Equals((string)(object)a, "BoardScreen"))
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_teleboardMenuEffect).FindKernel((string)null) == 0)
		{
			return;
		}
		string obj3 = _teleboardMenuEffect.tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj3);
	}

	public GameObject GetHoverboardModelPreview(string name, Boards.BoardId boardId)
	{
		//IL_0013: Expected VT, but got Obj
		//IL_0020: Expected Obj, but got VT
		//IL_0032: Expected Obj, but got I4
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		CharacterModel characterModel = ((HoverboardModelPreviewFactory)val).FindCharacterModel((GameObject)(object)name);
		((CharacterModel)this).AddCustomHoverboardVanityMenuFX((GameObject)(object)characterModel, (Transform)boardId);
		return (GameObject)(object)characterModel;
	}

	public unsafe Quaternion GetHoverboardDefaultRotation(string name)
	{
		//IL_0287: Expected native int or pointer, but got F4
		//IL_029e: Expected I, but got Obj
		//IL_02b4: Expected Obj, but got I
		//IL_0344: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0085: Expected native int or pointer, but got F4
		//IL_00a3: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got VT
		//IL_00bd: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_0311: Expected Obj, but got I
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_01f2: Expected I, but got Obj
		//IL_02ed: Expected Obj, but got I4
		//IL_02fa: Expected I4, but got Obj
		//IL_0247: Expected Obj, but got I
		//IL_0164: Expected I, but got Obj
		Quaternion quaternion = default;
		float num = quaternion.w + 16f;
		object obj = (object)this << 2;
		float num2 = num + (float)obj;
		float value = ((float*)(nint)num2)->m_value;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v9 (System.Single)+C]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			float num5 = quaternion.w + 16f;
			object obj3 = (object)this << 2;
			float num6 = num5 + (float)obj3;
			float value2 = ((float*)(nint)num6)->m_value;
			Quaternion quaternion2 = quaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v16 (System.Single)+C]");
			HoverboardBundle hoverboardBundle = ((HoverboardModelFactory)quaternion2).RequestHoverboardInstance((string)0);
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S2_v10 (Il2CppMethodInfo)+18]");
			object obj4 = 0;
			object obj5 = obj4;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v64 @ S3_v6 (should have been resolved before IL gen)");
			Component component = default;
			if (name != null)
			{
				string text = component.tag;
				nint num8 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v34 (Il2CppClass<Layers>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num9 = (nint)typeof(Layers);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v42 (Il2CppClass<Layers>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool startupFinished = LoadLevelCtrl.StartupFinished;
				object obj9 = (startupFinished ? 1 : 0) - -64;
				((GameObject)(object)text).SetActive((byte)(int)obj9 != 0);
			}
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Quaternion)+24]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Quaternion)+24]");
				object obj11 = (nint)0 + (nint)68;
				obj11 = component;
			}
		}
		return quaternion;
	}

	private CharacterModel FindCharacterModel(GameObject characterAnimation)
	{
		//IL_01aa: Expected I4, but got Obj
		//IL_01b7: Expected I4, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_01df: Expected Obj, but got I
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0105: Expected I, but got Obj
		//IL_0267: Expected Obj, but got VT
		string text = string.ConcatArray((string[])(object)"Prefabs/HoverboardAssets/", (int)characterAnimation);
		string nameInternal = Scene.GetNameInternal((int)text);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)nameInternal != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType((Type)(object)nameInternal);
		GameObject gameObject;
		if (array == null)
		{
			gameObject = null;
		}
		else
		{
			gameObject = (GameObject)(object)(((object)array.GetType() != typeof(GameObject)) ? null : array);
		}
		_0021_00210 componentInChildren = (_0021_00210)gameObject.GetComponentInChildren<T>();
		return (CharacterModel)componentInChildren;
	}

	public void ChangeHoverboard(Boards.BoardId boardId, GameObject hoverboardGO, Animation characterAnimation, bool willUpdateAnimation, bool willAllowSignatureAnimation, Hoverboard.BoardAbility boardAbility)
	{
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [3B0E24]");
		object obj = (nint)0 + (nint)92;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5664");
	}

	private void AddCustomModelsAndFX(HoverboardBundle.CustomSet[] customSets, int customSetIndex, Transform hoverboardRoot)
	{
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I4
		//IL_0098: Expected I4, but got Obj
		//IL_0098: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_0107: Expected I4, but got Obj
		//IL_0107: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)customSetIndex).FindKernel(null) != 0)
		{
			if ((object)hoverboardRoot == null)
			{
				UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)customSetIndex);
				((AnimationState)(object)customSets).AddMixingTransform((Transform)customSetIndex, (byte)(int)obj2 != 0);
			}
			else if (!((List<AnimationClip>)(object)hoverboardRoot).Contains((AnimationClip)customSetIndex))
			{
				((List<AnimationClip>)(object)hoverboardRoot).Add((AnimationClip)customSetIndex);
				UnityEngine.Object obj3 = UnityEngine.Object.Instantiate((UnityEngine.Object)customSetIndex);
				((AnimationState)(object)customSets).AddMixingTransform((Transform)customSetIndex, (byte)(int)obj3 != 0);
			}
		}
	}

	public void PlaySignatureMove(HoverboardBundle.CustomSet set, Animation characterAnimation, bool useLowrider)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I4
		//IL_0451: Expected Obj, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_00f1: Expected I, but got Obj
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_030e: Expected Obj, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected Obj, but got Unknown
		//IL_034a: Expected I, but got Obj
		//IL_0360: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01bb: Expected Obj, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01ff: Expected I, but got Obj
		//IL_0215: Expected Obj, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_038b: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_03d4: Expected I4, but got Obj
		GameObject baseModelPrefab = set.baseModelPrefab;
		if (System.Runtime.CompilerServices.Unsafe.As<GameObject, UIntPtr>(ref baseModelPrefab) <= System.Runtime.CompilerServices.Unsafe.As<Animation, UIntPtr>(ref characterAnimation))
		{
			return;
		}
		object obj = set + 16;
		object obj2 = (object)characterAnimation << 2;
		object obj3 = obj + obj2;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+8]");
		if ((nint)0 == 7)
		{
			ResetTeleportFX();
		}
		object obj5 = set + 16;
		object obj6 = (object)characterAnimation << 2;
		object obj7 = obj5 + obj6;
		object obj8 = obj7;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v61 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v19+C]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			CharacterModel characterModel = this.characterModel;
			characterModel.currentHoverboadBasemodel.shadowCastingMode = ShadowCastingMode.Off;
			Quaternion hoverboardDefaultRotation = ((HoverboardModelPreviewFactory)(object)characterAnimation).GetHoverboardDefaultRotation((string)1);
			object obj10 = this + 152;
			CharacterModel characterModel2 = this.characterModel;
			obj10 = characterModel2.currentHoverboadBasemodel;
		}
		((HoverboardRendering)(object)hoverboardBundle).AddClipsToAnimationComp(characterAnimation, (AnimationClip)1, (List<AnimationClip>)1);
		object obj11 = set + 16;
		object obj12 = (object)characterAnimation << 2;
		object obj13 = obj11 + obj12;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v28+8]");
		if ((nint)0 == 6)
		{
			object obj15 = this + 108;
			string text = hoverboardBundle.tag;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S3_v10 (Il2CppMethodInfo)+18]");
			object obj16 = 0;
			object obj17 = obj16;
			object obj18 = obj17 & 0x1FFF;
			object obj19 = obj18 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v146 @ S4_v9 (should have been resolved before IL gen)");
			object obj20 = default;
			obj15 = obj20;
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)gliderAnimation).FindKernel((string)null) != 0)
			{
				gliderAnimation.HandleOnLanding((Character)(object)this);
			}
		}
		object obj22 = set + 16;
		object obj23 = (object)characterAnimation << 2;
		object obj24 = obj22 + obj23;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v35+8]");
		if ((nint)0 != 5)
		{
			object obj26 = set + 16;
			object obj27 = (object)characterAnimation << 2;
			object obj28 = obj26 + obj27;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v58+8]");
			if ((nint)0 != 1)
			{
				return;
			}
		}
		string text2 = hoverboardBundle.tag;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S2_v13 (Il2CppMethodInfo)+18]");
		object obj30 = 0;
		object obj31 = obj30;
		object obj32 = obj31 & 0x1FFF;
		object obj33 = obj32 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S3_v8 (should have been resolved before IL gen)");
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			((playThruster)(object)computeShader).PlayEffects((byte)(int)this != 0);
		}
	}

	private IEnumerator JumpDelayedEvent(float delay)
	{
		//IL_002d: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		CharacterModel characterModel = default;
		((UnityEngine.Object)characterModel).m_CachedPtr = cachedPtr;
		characterModel.rigController = (GameObject)0;
		object obj = characterModel + 16;
		obj = this;
		return ((BatTeleboardMenuEffect)(object)speederSignature).DelayEndPoof(delay, characterModel);
	}

	private IEnumerator SpeederEvents(float waitTime)
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

	private void CachMaterials()
	{
		OnDestroy();
		OpenGlider();
	}

	private void TeleboardStart(float duration)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		object obj = teleporterSignature + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = teleporterSignature + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((AnimationState)obj5).speed = duration;
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		if (duration == 1f)
		{
			object obj7 = jumperSignature + 12;
			object obj8 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				object obj9 = jumperSignature + 16;
				object obj10 = obj8 << 2;
				object obj11 = obj9 + obj10;
				((Renderer)obj11).shadowCastingMode = ShadowCastingMode.Off;
				object obj12 = obj8 + 1;
				obj8 = obj12;
			}
		}
	}

	private IEnumerator TeleportFXStartScale(float duration)
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

	private void TeleboardEnd(float duration)
	{
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa5: Expected Obj, but got Unknown
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Expected Obj, but got Unknown
		//IL_0075: Expected I, but got Obj
		//IL_0021: Expected I4, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_016a: Expected I, but got Obj
		//IL_0180: Expected Obj, but got I
		//IL_0103: Expected I, but got Obj
		//IL_01ab: Expected I, but got Obj
		//IL_01f8: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_048a: Expected Obj, but got I4
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Expected Obj, but got Unknown
		//IL_0b78: Expected Obj, but got I4
		//IL_0b87: Expected Obj, but got F4
		//IL_0bbd: Expected Obj, but got I4
		//IL_0295: Expected I, but got Obj
		//IL_02ab: Expected Obj, but got I
		//IL_0239: Expected I, but got Obj
		//IL_0c17: Expected Obj, but got I
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected Obj, but got Unknown
		//IL_0c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3b: Expected Obj, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_0559: Expected I, but got Obj
		//IL_056f: Expected Obj, but got I
		//IL_0323: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_02d6: Expected I, but got Obj
		//IL_0c6e: Expected Obj, but got I4
		//IL_0c7b: Expected I4, but got Obj
		//IL_0c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c86: Expected Obj, but got Unknown
		//IL_059a: Expected I, but got Obj
		//IL_03b1: Expected I4, but got Obj
		//IL_03bd: Expected Obj, but got I4
		//IL_0364: Expected I, but got Obj
		//IL_05ff: Expected I, but got Obj
		//IL_0615: Expected Obj, but got I
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected Obj, but got Unknown
		//IL_0640: Expected I, but got Obj
		//IL_06b2: Expected I, but got Obj
		//IL_06c8: Expected Obj, but got I
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected Obj, but got Unknown
		//IL_06f3: Expected I, but got Obj
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected Obj, but got Unknown
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_0801: Expected I, but got Obj
		//IL_0817: Expected Obj, but got I
		//IL_09c9: Expected I, but got Obj
		//IL_09df: Expected Obj, but got I
		//IL_0842: Expected I, but got Obj
		//IL_0e50: Expected I, but got Obj
		//IL_0e66: Expected Obj, but got I
		//IL_0a0a: Expected I, but got Obj
		//IL_08b6: Expected I, but got Obj
		//IL_08e9: Expected I, but got Obj
		//IL_08ff: Expected Obj, but got I
		//IL_092a: Expected I, but got Obj
		if (~(teleportFxActive ? 1u : 0u) == 0)
		{
			OpenGlider();
			OnDestroy();
			useGUILayout = (byte)(int)"TeleportFXStartScale" != 0;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v253 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 32);
		object obj2 = transform2 + 16;
		if (this.characterModel != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v196 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_teleboardMenuEffect).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A9F");
			return;
		}
		teleportFxActive = true;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v190 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (teleboardWarp != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v220 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v248 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = this + 84;
			GameObject gameObject = UnityEngine.Object.Instantiate(teleboardWarpPrefab);
			obj6 = gameObject;
			int layer = teleboardWarp.layer;
			obj2 = 0;
			_ = 0;
			obj2 = 0.07f;
			_ = 0.07f;
			_ = 0.07f;
			transform = (Transform)obj2;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v21+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			((Transform)layer).parent = transform;
			int layer2 = teleboardWarp.layer;
			nint num9 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v153 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v186 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			transform2.Rotate(0f, 0f, 0f);
			transform = transform2;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			Vector3 localScale = transform.localScale;
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S2_v70 (Il2CppMethodInfo)+18]");
			object obj8 = 0;
			object obj9 = obj8;
			object obj10 = obj9 & 0x1FFF;
			object obj11 = obj10 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v314 @ S3_v8 (should have been resolved before IL gen)");
			Component component = default;
			string text = component.tag;
			nint num12 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S1_v164 (Il2CppClass<Layers>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num13 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S1_v182 (Il2CppClass<Layers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool startupFinished = LoadLevelCtrl.StartupFinished;
			object obj13 = (startupFinished ? 1 : 0) - -64;
			((GameObject)(object)text).SetActive((byte)(int)obj13 != 0);
			object obj14 = this + 92;
			Animation component2 = teleboardWarp.GetComponent<Animation>();
			bool flag = component2.Play((PlayMode)"teleboardWarp");
			obj14 = flag;
			teleboardAnimation.speed = 0f;
			teleboardAnimation.time = 1f;
			teleboardAnimation.wrapMode = WrapMode.Once;
			((CharacterController)(object)teleboardAnimation).height = 0f;
			teleboardWarp.tag = null;
		}
		CharacterModel characterModel = this.characterModel;
		Renderer component3 = characterModel._model.GetComponent<Renderer>();
		component3.sharedMaterials = (Material[])(object)teleboardFXMaterial;
		CharacterModel characterModel2 = this.characterModel;
		Material material = characterModel2._headModel.material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj16 = default;
		object obj15 = obj16 + 12;
		object obj17 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
		{
			throw new ArrayTypeMismatchException();
		}
		CharacterModel characterModel3 = this.characterModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
		CharacterModel characterModel4 = this.characterModel;
		characterModel4._outfitModel.sharedMaterials = (Material[])(object)teleboardFXMaterial;
		object obj18 = this + 152;
		CharacterModel characterModel5 = this.characterModel;
		obj18 = characterModel5.currentHoverboadBasemodel;
		Material[] sharedMaterials = cachedHoverboardBaseModelRenderer.sharedMaterials;
		nint num14 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v207 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)sharedMaterials).FindKernel((string)(object)teleboardFXMaterial) != 0)
		{
			object obj20 = this + 156;
			obj20 = sharedMaterials;
		}
		cachedHoverboardBaseModelRenderer.sharedMaterials = (Material[])(object)teleboardFXMaterial;
		CharacterModel characterModel6 = this.characterModel;
		Renderer component4 = characterModel6._meshSuperSneaker.GetComponent<Renderer>();
		Material[] sharedMaterials2 = component4.sharedMaterials;
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v82 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v201 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)sharedMaterials2).FindKernel((string)(object)teleboardFXMaterial) != 0)
		{
			object obj22 = this + 160;
			obj22 = sharedMaterials2;
		}
		CharacterModel characterModel7 = this.characterModel;
		Renderer component5 = characterModel7._meshSuperSneaker.GetComponent<Renderer>();
		component5.sharedMaterials = (Material[])(object)teleboardFXMaterial;
		CharacterModel characterModel8 = this.characterModel;
		Renderer component6 = characterModel8._doubleJumpers.GetComponent<Renderer>();
		Material[] sharedMaterials3 = component6.sharedMaterials;
		nint num18 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S0_v101 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v195 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)sharedMaterials3).FindKernel((string)(object)teleboardFXMaterial) != 0)
		{
			object obj24 = this + 164;
			obj24 = sharedMaterials3;
		}
		CharacterModel characterModel9 = this.characterModel;
		Renderer component7 = characterModel9._doubleJumpers.GetComponent<Renderer>();
		component7.sharedMaterials = (Material[])(object)teleboardFXMaterial;
		this.characterModel.StartIdlePopupAnimations();
		CharacterModel characterModel10 = this.characterModel;
		List<Renderer> currentCustomBoardModelsRenderes = characterModel10.currentCustomBoardModelsRenderes;
		if (currentCustomBoardModelsRenderes._size >= 1)
		{
			object obj25 = this + 168;
			CharacterModel characterModel11 = this.characterModel;
			List<Renderer> currentCustomBoardModelsRenderes2 = characterModel11.currentCustomBoardModelsRenderes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj26 = default;
			obj25 = obj26;
			int num20 = 0;
			while (true)
			{
				CharacterModel characterModel12 = this.characterModel;
				List<Renderer> currentCustomBoardModelsRenderes3 = characterModel12.currentCustomBoardModelsRenderes;
				if (num20 >= currentCustomBoardModelsRenderes3._size)
				{
					break;
				}
				CharacterModel characterModel13 = this.characterModel;
				Renderer renderer = characterModel13.currentCustomBoardModelsRenderes.get_Item(num20);
				nint num21 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ S1_v103 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					nint num22 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ S1_v122 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Material[] array;
				if (((ComputeShader)(object)renderer).FindKernel((string)null) != 0)
				{
					CharacterModel characterModel14 = this.characterModel;
					Renderer renderer2 = characterModel14.currentCustomBoardModelsRenderes.get_Item(num20);
					array = renderer2.sharedMaterials;
				}
				else
				{
					array = null;
				}
				nint num23 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ S0_v159 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num24 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S0_v184 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)array).FindKernel((string)(object)teleboardFXMaterial) != 0)
				{
					nint num25 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ S0_v169 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj29 = (nint)0 & (nint)0x200;
					if (obj29 != null)
					{
						nint num26 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ S0_v181 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)array).FindKernel((string)null) != 0)
					{
						throw new ArrayTypeMismatchException();
					}
				}
				int num27 = num20 + 1;
				num20 = num27;
			}
			int num28 = 0;
			while (true)
			{
				CharacterModel characterModel15 = this.characterModel;
				List<Renderer> currentCustomBoardModelsRenderes4 = characterModel15.currentCustomBoardModelsRenderes;
				if (num28 >= currentCustomBoardModelsRenderes4._size)
				{
					break;
				}
				CharacterModel characterModel16 = this.characterModel;
				Renderer renderer3 = characterModel16.currentCustomBoardModelsRenderes.get_Item(num28);
				nint num29 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj30 = (nint)0 & (nint)0x200;
				if (obj30 != null)
				{
					nint num30 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S1_v98 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)renderer3).FindKernel((string)null) != 0)
				{
					CharacterModel characterModel17 = this.characterModel;
					Renderer renderer4 = characterModel17.currentCustomBoardModelsRenderes.get_Item(num28);
					renderer4.sharedMaterials = (Material[])(object)teleboardFXMaterial;
				}
				int num31 = num28 + 1;
				num28 = num31;
			}
		}
		IEnumerator routine = TeleboardEndTimer(duration);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private IEnumerator TeleboardEndTimer(float duration)
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

	public void ResetTeleportFX()
	{
		//IL_01ec: Expected I, but got Obj
		//IL_0202: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0288: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0315: Expected I, but got Obj
		//IL_032b: Expected Obj, but got I
		//IL_0122: Expected I, but got Obj
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected I4, but got Unknown
		//IL_0187: Expected I, but got Obj
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)this.characterModel).FindKernel((string)null) == 0)
		{
			return;
		}
		CharacterModel characterModel = this.characterModel;
		Material[] sharedMaterials = characterModel._model.sharedMaterials;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v56 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)sharedMaterials).FindKernel((string)(object)teleboardFXMaterial) != 0)
		{
			object obj3 = this + 140;
			obj3 = sharedMaterials;
		}
		CharacterModel characterModel2 = this.characterModel;
		Shader shader = Shader.Find((string)(object)characterModel2._headModel);
		object obj4 = shader + 16;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S2_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj4).FindKernel((string)(object)teleboardFXMaterial) != 0)
		{
			object obj6 = this + 148;
			obj6 = shader;
		}
		CharacterModel characterModel3 = this.characterModel;
		Material[] sharedMaterials2 = characterModel3._outfitModel.sharedMaterials;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)sharedMaterials2).FindKernel((string)(object)teleboardFXMaterial) != 0)
		{
			object obj8 = this + 144;
			obj8 = sharedMaterials2;
		}
		CharacterModel characterModel4 = this.characterModel;
		string sortingLayerName = characterModel4._outfitModel.sortingLayerName;
		bool flag = (byte)(sortingLayerName & 1) != 0;
		cachedCustomizationState = flag;
	}

	private void SetEnabledWithinCurrentCustomHoverboardModels(bool isEnabled)
	{
		//IL_018e: Expected Obj, but got I4
		//IL_0063: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_00a4: Expected I, but got Obj
		//IL_0100: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_0141: Expected I, but got Obj
		if ((string)isEnabled != "FrontScreen")
		{
			OnDestroy();
		}
		UnityEngine.Object a = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		if (string.Equals((string)(object)a, "BoardScreen"))
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_teleboardMenuEffect).FindKernel((string)null) == 0)
		{
			return;
		}
		string obj2 = _teleboardMenuEffect.tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj2);
	}

	private void OpenGlider()
	{
		//IL_05e5: Expected I, but got Obj
		//IL_05fb: Expected Obj, but got I
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b8: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I4
		//IL_00f9: Expected I, but got Obj
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_0255: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_01e6: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I4
		//IL_031d: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_0296: Expected I, but got Obj
		//IL_035e: Expected I, but got Obj
		//IL_042c: Expected I, but got Obj
		//IL_0442: Expected Obj, but got I
		//IL_046d: Expected I, but got Obj
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected Obj, but got Unknown
		//IL_0533: Expected Obj, but got I4
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v114 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 12);
		if (this.characterModel != null || ~(teleportFxActive ? 1u : 0u) != 0)
		{
			return;
		}
		CharacterModel characterModel = this.characterModel;
		characterModel._model.shadowCastingMode = ShadowCastingMode.On;
		CharacterModel characterModel2 = this.characterModel;
		characterModel2._headModel.shadowCastingMode = ShadowCastingMode.On;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v110 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)cachedHoverboardBaseModelRenderer).FindKernel((string)null) != 0)
		{
			cachedHoverboardBaseModelRenderer.shadowCastingMode = ShadowCastingMode.On;
		}
		((AvatarAnimations)this).Head = (SkinnedMeshRenderer)1;
		CharacterModel characterModel3 = this.characterModel;
		bool shadowCastingMode = cachedCustomizationState;
		characterModel3._outfitModel.shadowCastingMode = (shadowCastingMode ? ShadowCastingMode.On : ShadowCastingMode.Off);
		CharacterModel characterModel4 = this.characterModel;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v105 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)characterModel4._currentHoverboard).FindKernel((string)null) != 0)
		{
			CharacterModel characterModel5 = this.characterModel;
			characterModel5._currentHoverboard.tag = (string)1;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v100 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)cachedModelMaterial).FindKernel((string)null) != 0)
		{
			CharacterModel characterModel6 = this.characterModel;
			Renderer component = characterModel6._model.GetComponent<Renderer>();
			component.sharedMaterials = (Material[])(object)cachedModelMaterial;
		}
		CharacterModel characterModel7 = this.characterModel;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)characterModel7._headModel).FindKernel((string)null) != 0)
		{
			CharacterModel characterModel8 = this.characterModel;
			Material material = characterModel8._headModel.material;
			if ((object)material != null && cachedHeadMaterials != null)
			{
				CharacterModel characterModel9 = this.characterModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
			}
		}
		CharacterModel characterModel10 = this.characterModel;
		characterModel10._outfitModel.sharedMaterials = (Material[])(object)cachedCustomizationMaterial;
		CharacterModel characterModel11 = this.characterModel;
		characterModel11._meshSuperSneaker.sharedMaterials = (Material[])(object)cachedSupersneakersMaterial;
		CharacterModel characterModel12 = this.characterModel;
		characterModel12._doubleJumpers.sharedMaterials = (Material[])(object)cachedDoubleJumperMaterial;
		this.characterModel.StartIdleAnimations(UIModelController.ModelScreen.Boards);
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v85 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)cachedHoverboardBaseModelRenderer).FindKernel((string)null) != 0)
		{
			cachedHoverboardBaseModelRenderer.sharedMaterials = (Material[])(object)cachedHoverboardMaterial;
		}
		if (cachedCustomHoverboardModelMaterials != null)
		{
			Material[] array = cachedCustomHoverboardModelMaterials;
			if (array.Length != 0)
			{
				int num13 = 0;
				while (true)
				{
					CharacterModel characterModel13 = this.characterModel;
					List<Renderer> currentCustomBoardModelsRenderes = characterModel13.currentCustomBoardModelsRenderes;
					if (num13 >= currentCustomBoardModelsRenderes._size)
					{
						break;
					}
					Material[] array2 = cachedCustomHoverboardModelMaterials;
					object obj8 = array2.Length - 1;
					if ((nint)obj8 >= num13)
					{
						CharacterModel characterModel14 = this.characterModel;
						Renderer renderer = characterModel14.currentCustomBoardModelsRenderes.get_Item(num13);
						object obj9 = cachedCustomHoverboardModelMaterials + 16;
						int num14 = num13 << 2;
						object sharedMaterials = obj9 + num14;
						renderer.sharedMaterials = (Material[])sharedMaterials;
					}
					int num15 = num13 + 1;
					num13 = num15;
				}
			}
		}
		GameObject gameObject = this.characterModel.gameObject;
		object obj10 = this + 124;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S2_v31+8]");
		_ = 0;
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject).parent = transform;
		teleportFxActive = false;
	}

	private void CloseGlider()
	{
		if (OnOpenGlider != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public void ResetAnimator()
	{
		if (OnCloseGlider != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private void OnDestroy()
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)animator).FindKernel((string)null) != 0)
		{
			animator.Play((int)"empty");
		}
	}

	public HoverboardModelPreviewFactory()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(HoverboardModelPreviewFactory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HoverboardModelPreviewFactory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HoverboardModelPreviewFactory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<HoverboardModelPreviewFactory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		instance = null;
	}

	private unsafe void _003CTeleboardEnd_003Eb__56_0(float t)
	{
		//IL_043b: Expected I, but got Obj
		//IL_0451: Expected Obj, but got I
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_0275: Expected I, but got Obj
		//IL_028b: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected Obj, but got Unknown
		//IL_02b6: Expected I, but got Obj
		//IL_0303: Expected I, but got Obj
		//IL_0319: Expected Obj, but got I
		//IL_01c9: Expected I, but got Obj
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0218: Expected Obj, but got I4
		//IL_0344: Expected I, but got Obj
		//IL_03a1: Expected VT, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v81 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 12);
		if (characterModel != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v82 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_teleboardMenuEffect).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A9F");
			return;
		}
		GameObject gameObject = characterModel.gameObject;
		object obj3 = this + 124;
		transform2 = (Transform)obj3;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S2_v6+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		transform = transform2;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		((Transform)(object)gameObject).parent = transform;
		if (t > 0f)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v76 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)teleboardWarp).FindKernel((string)null) != 0)
			{
				teleboardWarp.tag = (string)1;
			}
			teleboardAnimation.speed = 1f;
			teleboardAnimation.time = 1f;
			((CharacterController)(object)teleboardAnimation).height = -1.8f;
			teleboardAnimation.wrapMode = WrapMode.Once;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)root).FindKernel((string)null) != 0)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)teleboardWarp).FindKernel((string)null) != 0)
			{
				int layer = teleboardWarp.layer;
				transform2.position = (Vector3)root;
				transform = transform2;
				((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
				Vector3 localPosition = transform.localPosition;
			}
		}
		float distance = ((RaycastHit*)teleboardAnimation)->distance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		_ = 0;
		object obj8 = default;
		object obj7 = obj8 + 16;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine = default;
		Coroutine coroutine = StartCoroutine_Auto(routine);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num12 = 0;
		_ = 0;
		object obj10 = default;
		object obj9 = obj10 + 16;
		obj9 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine2 = default;
		Coroutine coroutine2 = StartCoroutine_Auto(routine2);
	}

	private void _003CTeleboardEnd_003Eb__56_1(float t)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I4
		if (t != 1f)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)teleboardWarp).FindKernel((string)null) != 0)
		{
			teleboardWarp.tag = (string)1;
		}
		((AnimatorControllerParameter)(object)animator)._002Ector();
	}
}
