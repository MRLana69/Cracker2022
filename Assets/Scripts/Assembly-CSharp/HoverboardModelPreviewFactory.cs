using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using UnityEngine;
using UnityEngine.UI;

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

	private sealed class _003CSpeederEvents_003Ed__53(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public HoverboardModelPreviewFactory _003C_003E4__this;

		public float waitTime;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			HoverboardModelPreviewFactory hoverboardModelPreviewFactory = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Action onSpeederEnd = hoverboardModelPreviewFactory.OnSpeederEnd;
					if (hoverboardModelPreviewFactory.OnSpeederEnd != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			Action onSpeederStart = hoverboardModelPreviewFactory.OnSpeederStart;
			if (hoverboardModelPreviewFactory.OnSpeederStart != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v21.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			_ = waitTime;
			object obj = default;
			_003C_003E2__current = obj;
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

	private sealed class _003CTeleportFXStartScale_003Ed__56(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public HoverboardModelPreviewFactory _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Expected VT, but got Unknown
			//IL_0386: Expected I, but got Obj
			//IL_03b8: Expected F4, but got I
			//IL_03b3: Expected native int or pointer, but got VT
			//IL_03d3: Expected F4, but got I
			//IL_03ce: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj + -64);
			HoverboardModelPreviewFactory hoverboardModelPreviewFactory = _003C_003E4__this;
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0253;
				}
				_003C_003E1__state = -1;
				num = _003Ctime_003E5__2;
			}
			else
			{
				_003Ctime_003E5__2 = 0f;
				_003C_003E1__state = -1;
				num = 0f;
			}
			if (num < duration)
			{
				float deltaTime = Time.deltaTime;
				float num2 = (_003Ctime_003E5__2 = num + deltaTime);
				if (hoverboardModelPreviewFactory.characterModel != null)
				{
					Transform transform = hoverboardModelPreviewFactory.characterModel.transform;
					float num3 = num2 / duration;
					float num4 = Math.Min(num3, 1f);
					bool flag = num3 < 0f;
					float num5 = 0f;
					if (!flag)
					{
						num5 = num4;
					}
					float num6 = num5 * 0.5f;
					float num7 = 1f - num6;
					float num8 = num7 * (float)hoverboardModelPreviewFactory.intialScale;
					float num9 = num5 * 0.5f;
					float num10 = num9 + 1f;
					float num11 = num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (HoverboardModelPreviewFactory)+7C]");
					float num12 = num11 * 0f;
					float num13 = 1f - num5;
					float num14 = num13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (HoverboardModelPreviewFactory)+80]");
					float num15 = num14 * 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_ = 0;
					Vector3 localScale = vector + 16;
					transform.localScale = localScale;
					if (num5 == 1f && ~(hoverboardModelPreviewFactory.teleportFxActive ? 1u : 0u) == 0)
					{
						Transform transform2 = hoverboardModelPreviewFactory.characterModel.transform;
						nint num16 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v57 (Il2CppClass<UnityEngine.Vector3>)+5C]");
						nint num17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v58 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
						((Vector3*)(nint)vector)->z = 0f;
						_ = Vector3.zeroVector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
						((Vector3*)(nint)vector)->x = 0f;
						transform2.localScale = vector;
						hoverboardModelPreviewFactory.cachedHoverboardBaseModelRenderer.enabled = false;
						CharacterModel characterModel = hoverboardModelPreviewFactory.characterModel;
						characterModel._model.enabled = false;
						CharacterModel characterModel2 = hoverboardModelPreviewFactory.characterModel;
						characterModel2._headModel.enabled = false;
						hoverboardModelPreviewFactory.SetEnabledWithinCurrentCustomHoverboardModels(isEnabled: false);
						CharacterModel characterModel3 = hoverboardModelPreviewFactory.characterModel;
						characterModel3._outfitModel.enabled = false;
						CharacterModel characterModel4 = hoverboardModelPreviewFactory.characterModel;
						if (characterModel4._currentHoverboard != null)
						{
							CharacterModel characterModel5 = hoverboardModelPreviewFactory.characterModel;
							characterModel5._currentHoverboard.SetActive(value: false);
						}
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
				}
			}
			goto IL_0253;
			IL_0253:
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

	private sealed class _003CTeleboardEndTimer_003Ed__58(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float duration;

		public HoverboardModelPreviewFactory _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			HoverboardModelPreviewFactory hoverboardModelPreviewFactory = _003C_003E4__this;
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_008b;
				}
				_003C_003E1__state = -1;
				num = _003Ctime_003E5__2;
			}
			else
			{
				_003Ctime_003E5__2 = 0f;
				_003C_003E1__state = -1;
				num = 0f;
			}
			if (num < duration)
			{
				float deltaTime = Time.deltaTime;
				float num2 = (_003Ctime_003E5__2 = num + deltaTime) / duration;
				if (!(num2 < 0f) && !(num2 < 1f) && ~(hoverboardModelPreviewFactory.teleportFxActive ? 1u : 0u) == 0)
				{
					hoverboardModelPreviewFactory.teleboardWarp.SetActive(value: false);
					hoverboardModelPreviewFactory.animator.StopPlayback();
					hoverboardModelPreviewFactory.ResetTeleportFX();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_008b;
			IL_008b:
			return false;
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

	private Dictionary<string, HoverboardModelSetup> name2character;

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
			//IL_0014: Expected VT, but got Obj
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			HoverboardModelPreviewFactory result = instance;
			if (!flag2)
			{
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(HoverboardModelPreviewFactory));
				UnityEngine.Object obj = UnityEngine.Object.FindObjectOfType(typeFromHandle);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				HoverboardModelPreviewFactory hoverboardModelPreviewFactory = default;
				instance = hoverboardModelPreviewFactory;
				result = hoverboardModelPreviewFactory;
			}
			return result;
		}
	}

	public void Awake()
	{
		GameObject gameObject = base.gameObject;
		Animator component = gameObject.GetComponent<Animator>();
		animator = component;
		throw new ArgumentException();
	}

	private void UIScreenController_OnApplicationResumed()
	{
		ResetAnimator();
		ResetTeleportFX();
	}

	private void HandleOnPopupShown(string popupName)
	{
		ResetAnimator();
		string text = name;
		if (!text.Equals("BoardScreen") && _teleboardMenuEffect != null)
		{
			GameObject obj = _teleboardMenuEffect.gameObject;
			UnityEngine.Object.Destroy(obj);
		}
	}

	private void HandleOnNavigateToScreen(string obj)
	{
		if (obj == "FrontUI")
		{
			ResetAnimator();
		}
		string text = name;
		if (!text.Equals("BoardScreen") && _teleboardMenuEffect != null)
		{
			GameObject obj2 = _teleboardMenuEffect.gameObject;
			UnityEngine.Object.Destroy(obj2);
		}
	}

	public unsafe GameObject GetHoverboardModelPreview(string name, Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected Ref, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00a1: Expected VT, but got Obj
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_05d9: Expected I, but got Obj
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected VT, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected Obj, but got Unknown
		//IL_0692: Expected Obj, but got I4
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected VT, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_03d1: Expected Obj, but got I4
		//IL_0407: Expected Obj, but got I
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_04de: Expected Obj, but got I4
		//IL_0514: Expected Obj, but got I
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		object obj = default;
		HoverboardModelFactory hoverboardModelFactory = (HoverboardModelFactory)(obj - 128);
		_ = 0;
		GameObject gameObject = default;
		HoverboardBundle hoverboardBundle;
		HoverboardBundle.CustomSet[] customSets;
		if (name2character.TryGetValue(name, out *(HoverboardModelSetup*)(hoverboardModelFactory + 120)))
		{
			string text = "Hoverboard: " + name;
			gameObject._002Ector(text);
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			Image image = gameObject.AddComponent<Image>();
			_ = 1065353216;
			_ = 1065353216;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			object obj2 = hoverboardModelFactory + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @388");
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			Enum obj3 = (Enum)(hoverboardModelFactory + 88);
			_ = -1;
			obj3 = (Enum)(object)typeof(Hoverboards.BoardType);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (HoverboardModelFactory)+7C]");
			_ = 0;
			string text2 = obj3.ToString();
			hoverboardBundle = hoverboardModelFactory.RequestHoverboardInstance(text2);
			hoverboardBundle.AddCustomPreviewModel();
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ S3_v9 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
			Transform transform = hoverboardBundle.transform;
			Transform parent = gameObject.transform;
			transform.parent = parent;
			Transform transform2 = hoverboardBundle.transform;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v50 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num4 = 0;
			float num5 = (float)Vector3.oneVector * 12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v51 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
			float num6 = 0f * 12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v51 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			float num7 = 0f * 12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (HoverboardModelFactory)+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (HoverboardModelFactory)+48]");
			_ = 0;
			Vector3 localScale = (Vector3)(hoverboardModelFactory + 24);
			transform2.localScale = localScale;
			Transform transform3 = hoverboardBundle.transform;
			object obj4 = hoverboardModelFactory - -64;
			obj4 = 1132920832;
			_ = 1132920832;
			_ = 4812096202950574080L;
			_ = 4812096202950574080L;
			Vector3 eulerAngles = (Vector3)(hoverboardModelFactory + 8);
			transform3.eulerAngles = eulerAngles;
			customSets = hoverboardBundle.customSets;
			if (hoverboardBundle.customSets != null)
			{
				HoverboardManager hoverboardManager = HoverboardManager.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (HoverboardModelFactory)+7C]");
				bool flag = hoverboardManager.IsCustomSetEquippedForBoard(Hoverboards.BoardType.normal, 0);
				bool flag2 = !flag;
				bool flag3 = true;
				if (!flag2)
				{
					HoverboardBundle.CustomSet customSet = customSets[1];
					bool useDefaultmodel = customSet.useDefaultmodel;
					flag3 = useDefaultmodel;
				}
				HoverboardManager hoverboardManager2 = HoverboardManager.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (HoverboardModelFactory)+7C]");
				if (hoverboardManager2.IsCustomSetEquippedForBoard(Hoverboards.BoardType.normal, 1))
				{
					HoverboardBundle.CustomSet customSet2 = customSets[2];
					bool useDefaultmodel2 = customSet2.useDefaultmodel;
					object obj5 = flag3 & useDefaultmodel2;
					if (obj5 != null)
					{
						goto IL_0277;
					}
				}
				else if (flag3)
				{
					goto IL_0277;
				}
				goto IL_02f6;
			}
			goto IL_06cc;
		}
		string text3 = "GetHoverboardModelPreview() could not find preview character model for '" + name + "'.";
		goto IL_0582;
		IL_02f6:
		if (customSets.Length >= 2)
		{
			HoverboardManager hoverboardManager3 = HoverboardManager.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (HoverboardModelFactory)+7C]");
			object obj10 = default;
			if (hoverboardManager3.IsCustomSetEquippedForBoard(Hoverboards.BoardType.normal, 0))
			{
				hoverboardBundle.AddCustomSetModelAndEffect(1, isMenu: true, addEffect: false);
				HoverboardBundle.CustomSet customSet3 = customSets[1];
				if (customSet3.baseModelPrefab != null)
				{
					hoverboardBundle.AddCustomBaseModel(1, isMenu: true);
					object obj6 = 0;
					while (true)
					{
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v40+C]");
						if ((nint)obj7 >= 0)
						{
							break;
						}
						object obj8 = obj6 << 2;
						object obj9 = obj10 + obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v143+10]");
						((Renderer)0).enabled = false;
						object obj11 = obj6 + 1;
						obj6 = obj11;
					}
				}
			}
			if (customSets.Length >= 3)
			{
				HoverboardManager hoverboardManager4 = HoverboardManager.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (HoverboardModelFactory)+7C]");
				if (hoverboardManager4.IsCustomSetEquippedForBoard(Hoverboards.BoardType.normal, 1))
				{
					hoverboardBundle.AddCustomSetModelAndEffect(2, isMenu: true, addEffect: false);
					HoverboardBundle.CustomSet customSet4 = customSets[2];
					if (customSet4.baseModelPrefab != null)
					{
						hoverboardBundle.AddCustomBaseModel(2, isMenu: true);
						object obj12 = 0;
						while (true)
						{
							object obj13 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v40+C]");
							if ((nint)obj13 >= 0)
							{
								break;
							}
							object obj14 = obj12 << 2;
							object obj15 = obj10 + obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v124+10]");
							((Renderer)0).enabled = false;
							object obj16 = obj12 + 1;
							obj12 = obj16;
						}
					}
				}
			}
		}
		goto IL_06cc;
		IL_0277:
		if (customSets.Length != 0)
		{
			HoverboardBundle.CustomSet customSet5 = customSets[0];
			if (customSet5.modelPrefab != null)
			{
				hoverboardBundle.AddCustomSetModelAndEffect(0, isMenu: true, addEffect: false);
			}
		}
		goto IL_02f6;
		IL_0582:
		GameObject result = default;
		return result;
		IL_06cc:
		GliderAnimation componentInChildren = hoverboardBundle.GetComponentInChildren<GliderAnimation>();
		bool flag4 = componentInChildren != null;
		bool flag5 = !flag4;
		result = gameObject;
		if (!flag5)
		{
			componentInChildren.RemoveEventHandling();
			result = gameObject;
		}
		goto IL_0582;
	}

	public unsafe Quaternion GetHoverboardDefaultRotation(string name)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Ref, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected VT, but got Unknown
		//IL_0406: Expected F4, but got I
		//IL_0401: Expected native int or pointer, but got VT
		//IL_041b: Expected F4, but got I
		//IL_0416: Expected native int or pointer, but got VT
		//IL_0023: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected VT, but got Unknown
		//IL_00ca: Expected F4, but got I
		//IL_00c5: Expected native int or pointer, but got VT
		//IL_00eb: Expected F4, but got I
		//IL_00e6: Expected native int or pointer, but got VT
		//IL_011a: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I
		//IL_018b: Expected Obj, but got I
		//IL_01b7: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_023f: Expected native int or pointer, but got VT
		//IL_0261: Expected Obj, but got I
		//IL_027e: Expected Obj, but got I
		//IL_02a8: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I
		//IL_02e9: Expected native int or pointer, but got VT
		//IL_030b: Expected Obj, but got I
		//IL_0328: Expected Obj, but got I
		//IL_0352: Expected Obj, but got I
		//IL_037c: Expected Obj, but got I
		//IL_0393: Expected native int or pointer, but got VT
		//IL_03a0: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		Quaternion quaternion3 = default;
		if (name2character.TryGetValue(name, out *(HoverboardModelSetup*)(vector + 44)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+2C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v24+C]");
			float num = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v24+10]");
			float num2 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v24+14]");
			float num3 = 0f * ((float)Math.PI / 180f);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Vector3 euler = vector + 16;
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			_ = (float)Math.PI;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			object obj3 = num4 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
			object obj4 = num5 * 0;
			object obj5 = obj3 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			object obj6 = num6 * 0;
			object obj7 = obj5 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			object obj8 = num7 * 0;
			float x = (float)obj7 - (float)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
			object obj9 = num8 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			object obj10 = num9 * 0;
			object obj11 = obj9 - obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			object obj12 = num10 * 0;
			object obj13 = obj11 - obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			object obj14 = num11 * 0;
			float w = (float)obj13 - (float)obj14;
			((Quaternion*)(nint)quaternion3)->w = w;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			object obj15 = num12 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
			object obj16 = num13 * 0;
			object obj17 = obj15 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			object obj18 = num14 * 0;
			object obj19 = obj17 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			object obj20 = num15 * 0;
			float z = (float)obj19 - (float)obj20;
			((Quaternion*)(nint)quaternion3)->z = z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			object obj21 = num16 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
			object obj22 = num17 * 0;
			object obj23 = obj21 + obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			nint num18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			object obj24 = num18 * 0;
			object obj25 = obj23 + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			object obj26 = num19 * 0;
			float y = (float)obj25 - (float)obj26;
			((Quaternion*)(nint)quaternion3)->y = y;
			((Quaternion*)(nint)quaternion3)->x = x;
		}
		else
		{
			_ = (float)Math.PI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = (float)Math.PI * 221f / 360f;
			_ = 3.3859386f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Vector3 euler2 = vector + 32;
			Quaternion quaternion4 = Quaternion.Internal_FromEulerRad(euler2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			((Quaternion*)(nint)quaternion3)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			((Quaternion*)(nint)quaternion3)->x = 0f;
		}
		return quaternion3;
	}

	private CharacterModel FindCharacterModel(GameObject characterAnimation)
	{
		UnityEngine.Object obj = null;
		GameObject gameObject = default;
		UnityEngine.Object obj2 = default;
		while (obj == null)
		{
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S3_v5 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInParent>>)+4] (should have been resolved before IL gen)");
			Transform transform = gameObject.transform;
			Transform parent = transform.parent;
			bool flag = parent != null;
			obj = null;
			if (!flag)
			{
				break;
			}
			gameObject = parent.gameObject;
			obj = obj2;
		}
		return (CharacterModel)obj;
	}

	public unsafe void ChangeHoverboard(Hoverboards.BoardType boardType, GameObject hoverboardGO, Animation characterAnimation, bool willUpdateAnimation, bool willAllowSignatureAnimation, Hoverboard.BoardAbility boardAbility)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eea: Expected Ref, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected Obj, but got Unknown
		//IL_0386: Expected VT, but got I
		//IL_0fa1: Expected Obj, but got I4
		//IL_0f41: Expected Obj, but got I4
		//IL_08a8: Expected Obj, but got I4
		//IL_08b1: Expected Obj, but got I4
		//IL_08ba: Expected Obj, but got I4
		//IL_0a97: Expected Obj, but got I4
		//IL_0ff9: Expected Obj, but got I4
		//IL_0a6a: Expected Obj, but got I4
		//IL_0a73: Expected Obj, but got I4
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Expected Obj, but got Unknown
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Expected Obj, but got Unknown
		//IL_0ab8: Expected Obj, but got I4
		//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Expected Obj, but got Unknown
		//IL_0907: Expected I4, but got Obj
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected Obj, but got Unknown
		//IL_0929: Expected Obj, but got I
		//IL_0ada: Expected Obj, but got I
		//IL_0aeb: Expected Obj, but got I
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Expected I4, but got Unknown
		//IL_0ea3: Expected Obj, but got I
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Expected I4, but got Unknown
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected Obj, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected Obj, but got Unknown
		//IL_0b7f: Expected Obj, but got I
		//IL_0b90: Expected Obj, but got I
		//IL_0bc8: Expected Obj, but got I
		//IL_0bd9: Expected Obj, but got I
		//IL_0b3c: Expected Obj, but got I
		//IL_0b4d: Expected Obj, but got I
		//IL_0b6a: Expected Obj, but got I
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected Obj, but got Unknown
		//IL_0cd2: Expected Obj, but got I
		//IL_0ce3: Expected Obj, but got I
		//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Expected Obj, but got Unknown
		//IL_0d77: Expected Obj, but got I
		//IL_0d88: Expected Obj, but got I
		//IL_0dac: Expected Obj, but got I
		//IL_1032: Unknown result type (might be due to invalid IL or missing references)
		//IL_1037: Expected Obj, but got Unknown
		//IL_0d34: Expected Obj, but got I
		//IL_0d45: Expected Obj, but got I
		//IL_0d62: Expected Obj, but got I
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddb: Expected Obj, but got Unknown
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Expected Obj, but got Unknown
		//IL_0e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 112;
		_ = 0;
		object obj3 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		if (this.hoverboardBundle != null)
		{
			GameObject obj4 = this.hoverboardBundle.gameObject;
			UnityEngine.Object.Destroy(obj4);
		}
		AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
		object obj5 = obj - -64;
		object obj6 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		object obj7 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v25+8]");
		if ((nint)0 == id_Teleboard && willUpdateAnimation)
		{
			StopAllCoroutines();
		}
		else
		{
			AnimatorStateInfo currentAnimatorStateInfo2 = animator.GetCurrentAnimatorStateInfo(0);
			object obj8 = obj - -64;
			object obj9 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			object obj10 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v275+8]");
			if ((nint)0 != id_Glider)
			{
				goto IL_016e;
			}
		}
		ResetAnimator();
		goto IL_016e;
		IL_1054:
		object obj11;
		bool flag = (nint)obj11 != 1;
		bool flag2;
		int num = (flag2 ? 1 : 0);
		HoverboardBundle.CustomSet[] customSets;
		if (!flag)
		{
			bool flag3 = !willAllowSignatureAnimation;
			num = (flag2 ? 1 : 0);
			if (!flag3)
			{
				HoverboardBundle.CustomSet customSet = customSets[0];
				if (customSet.ability != Hoverboard.BoardAbility.None)
				{
					HoverboardBundle.CustomSet customSet2 = customSets[0];
					if (customSet2.ability == Hoverboard.BoardAbility.Teleport)
					{
						CachMaterials();
					}
					HoverboardBundle.CustomSet customSet3 = customSets[0];
					if (customSet3.ability == Hoverboard.BoardAbility.Lowrider)
					{
						PlaySignatureMove(customSets[0], characterAnimation, useLowrider: true);
					}
					else
					{
						PlaySignatureMove(customSets[0], characterAnimation, useLowrider: false);
					}
				}
				return;
			}
		}
		goto IL_07b8;
		IL_016e:
		if (~(teleportFxActive ? 1u : 0u) == 0)
		{
			ResetTeleportFX();
		}
		if (_teleboardMenuEffect != null && willUpdateAnimation)
		{
			GameObject obj12 = _teleboardMenuEffect.gameObject;
			UnityEngine.Object.Destroy(obj12);
		}
		Dictionary<Hoverboards.BoardType, Hoverboards.Board> boardData = Hoverboards.boardData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
		Hoverboards.Board board = boardData.get_Item(Hoverboards.BoardType.normal);
		GameObject characterAnimation2 = characterAnimation.gameObject;
		CharacterModel characterModel = FindCharacterModel(characterAnimation2);
		this.characterModel = characterModel;
		if (this.characterModel == null)
		{
			return;
		}
		float num2 = (float)intialScale - -1f;
		float num3 = num2 * num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardModelPreviewFactory)+7C]");
		float num4 = 0f - -1f;
		float num5 = num4 * num4;
		float num6 = num3 + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardModelPreviewFactory)+80]");
		float num7 = 0f - -1f;
		float num8 = num7 * num7;
		float num9 = num6 + num8;
		if (num9 < 9.9999994E-11f)
		{
			Transform transform = this.characterModel.transform;
			Vector3 localScale = transform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			intialScale = (Vector3)0;
		}
		if (!name2character.TryGetValue(board.boardModelName, out *(HoverboardModelSetup*)(obj + 104)))
		{
			return;
		}
		Enum obj13 = (Enum)(obj + 24);
		_ = -1;
		obj13 = (Enum)(object)typeof(Hoverboards.BoardType);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
		_ = 0;
		string text = obj13.ToString();
		HoverboardBundle hoverboardBundle = this.characterModel.AddHoverboard(text, isMenu: true);
		this.hoverboardBundle = hoverboardBundle;
		bool flag4 = board.boardModelName == "Jumpboard";
		CharacterModel characterModel2 = this.characterModel;
		characterModel2._meshSuperSneaker.enabled = flag4;
		if (board.boardModelName == "gliderboard")
		{
			nint num10 = 0;
			nint num11 = 0;
			IntPtr intPtr = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v391 @ S4_v22 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			GliderAnimation gliderAnimation = default;
			this.gliderAnimation = gliderAnimation;
			if (this.gliderAnimation != null)
			{
				this.gliderAnimation.AddEvents(this);
			}
		}
		if (board.boardModelName == "teleboard")
		{
			CachMaterials();
		}
		HoverboardBundle hoverboardBundle2 = this.hoverboardBundle;
		customSets = hoverboardBundle2.customSets;
		if (hoverboardBundle2.customSets == null)
		{
			return;
		}
		HoverboardBundle hoverboardBundle3;
		if (customSets.Length <= 1)
		{
			hoverboardBundle3 = hoverboardBundle2;
			if (customSets.Length == 0)
			{
				num = 0;
				goto IL_07b8;
			}
		}
		else
		{
			HoverboardManager hoverboardManager = HoverboardManager.Instance;
			bool[] displayCustomSets = hoverboardManager._displayCustomSets;
			bool flag5 = (byte)(~(displayCustomSets[0] ? 1u : 0u)) != 0;
			bool flag6 = true;
			if (!flag5)
			{
				HoverboardBundle.CustomSet customSet4 = customSets[1];
				bool useDefaultmodel = customSet4.useDefaultmodel;
				flag6 = useDefaultmodel;
			}
			bool flag7 = customSets.Length < 3;
			flag2 = false;
			if (!flag7)
			{
				HoverboardManager hoverboardManager2 = HoverboardManager.Instance;
				bool[] displayCustomSets2 = hoverboardManager2._displayCustomSets;
				bool flag8 = (byte)(~(displayCustomSets2[1] ? 1u : 0u)) != 0;
				flag2 = false;
				if (!flag8)
				{
					HoverboardBundle.CustomSet customSet5 = customSets[2];
					bool useDefaultmodel2 = customSet5.useDefaultmodel;
					bool flag9 = flag6 & useDefaultmodel2;
					flag6 = flag9;
					flag2 = false;
				}
			}
			bool flag10 = customSets.Length == 0;
			bool flag11 = flag6 == flag10;
			obj11 = customSets.Length;
			if (flag11)
			{
				goto IL_1054;
			}
			hoverboardBundle3 = this.hoverboardBundle;
		}
		hoverboardBundle3.AddCustomSetModelAndEffect(0, isMenu: true, addEffect: true);
		obj11 = customSets.Length;
		flag2 = true;
		goto IL_1054;
		IL_07b8:
		HoverboardManager hoverboardManager3 = HoverboardManager.Instance;
		bool[] displayCustomSets3 = hoverboardManager3._displayCustomSets;
		if (~(displayCustomSets3[0] ? 1u : 0u) == 0)
		{
			Transform transform2 = hoverboardGO.transform;
			AddCustomModelsAndFX(hoverboardBundle2.customSets, 1, (Transform)(object)this);
			num = 1;
		}
		HoverboardManager hoverboardManager4 = HoverboardManager.Instance;
		bool[] displayCustomSets4 = hoverboardManager4._displayCustomSets;
		if (~(displayCustomSets4[1] ? 1u : 0u) == 0)
		{
			Transform transform3 = hoverboardGO.transform;
			AddCustomModelsAndFX(hoverboardBundle2.customSets, 2, (Transform)(object)this);
			num = 2;
		}
		if (!willUpdateAnimation)
		{
			return;
		}
		object obj14 = 0;
		object obj15 = 0;
		object obj16 = 0;
		while (customSets.Length > (nint)obj14)
		{
			if (obj14 != null)
			{
				if ((nint)obj14 >= 1)
				{
					int num12 = obj14 << 2;
					object obj17 = hoverboardBundle2.customSets + num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v201+10]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S0_v202+8]");
					bool flag12 = (nint)0 != 2;
					num = 2;
					if (!flag12)
					{
						HoverboardManager hoverboardManager5 = HoverboardManager.Instance;
						num = obj14 - 1;
						object obj19 = hoverboardManager5._displayCustomSets + num;
						object obj20 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ S1_v150+10]");
						object obj21 = obj20 | 0;
						obj15 = obj21;
					}
				}
			}
			else
			{
				HoverboardBundle.CustomSet customSet6 = customSets[0];
				bool flag13 = customSet6.ability == Hoverboard.BoardAbility.Lowrider;
				object obj22 = obj15 | flag13;
				HoverboardBundle.CustomSet customSet7 = customSets[0];
				bool flag14 = customSet7.ability == Hoverboard.BoardAbility.Glider;
				object obj23 = obj16 | flag14;
				obj15 = obj22;
				obj16 = obj23;
				num = 6;
			}
			object obj24 = obj14 + 1;
			obj14 = obj24;
		}
		HoverboardManager hoverboardManager6 = HoverboardManager.Instance;
		bool[] displayCustomSets5 = hoverboardManager6._displayCustomSets;
		object obj25;
		object obj26;
		if (~(displayCustomSets5[0] ? 1u : 0u) == 0)
		{
			obj25 = 1;
			obj26 = 0;
		}
		else
		{
			HoverboardManager hoverboardManager7 = HoverboardManager.Instance;
			bool[] displayCustomSets6 = hoverboardManager7._displayCustomSets;
			object obj27 = 2;
			if (!displayCustomSets6[1])
			{
				obj27 = 0;
			}
			obj26 = (displayCustomSets6[1] ? 1 : 0) ^ 1;
			obj25 = obj27;
		}
		Hoverboard.BoardAbility boardAbility2 = Hoverboard.BoardAbility.None;
		if (obj26 == null)
		{
			boardAbility2 = boardAbility;
		}
		if (boardAbility2 == Hoverboard.BoardAbility.None)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S1_v75+1C]");
			string text2 = ((UnityEngine.Object)0).name;
			AnimationState animationState = characterAnimation.get_Item(text2);
			if (animationState == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S1_v131+1C]");
				string newName = ((UnityEngine.Object)0).name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ S1_v131+1C]");
				characterAnimation.AddClip((AnimationClip)0, newName);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ S1_v81+1C]");
			string text3 = ((UnityEngine.Object)0).name;
			AnimationState animationState2 = characterAnimation.get_Item(text3);
			animationState2.wrapMode = WrapMode.Once;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S1_v86+1C]");
			string animation = ((UnityEngine.Object)0).name;
			bool flag15 = characterAnimation.Play(animation);
			object obj32 = obj15 & 1;
			object obj34;
			if (obj32 != null)
			{
				object obj33 = this + 32;
				string text4 = lowriderRunIdle.name;
				AnimationState animationState3 = characterAnimation.get_Item(text4);
				if (animationState3 == null)
				{
					string newName2 = lowriderRunIdle.name;
					characterAnimation.AddClip(lowriderRunIdle, newName2);
				}
				string text5 = lowriderRunIdle.name;
				currentIdleClip = text5;
				obj34 = obj33;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ S1_v106+20]");
				string text6 = ((UnityEngine.Object)0).name;
				AnimationState animationState4 = characterAnimation.get_Item(text6);
				if (animationState4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ S1_v117+20]");
					string newName3 = ((UnityEngine.Object)0).name;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ S1_v117+20]");
					characterAnimation.AddClip((AnimationClip)0, newName3);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ S1_v112+20]");
				string text7 = ((UnityEngine.Object)0).name;
				currentIdleClip = text7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
				object obj38 = (nint)0 + (nint)32;
				obj34 = obj38;
			}
			string animation2 = ((UnityEngine.Object)obj34).name;
			AnimationState animationState5 = characterAnimation.CrossFadeQueued(animation2, 0.2f);
			object obj39 = obj16 & 1;
			if (obj39 != null)
			{
				AnimatorStateInfo currentAnimatorStateInfo3 = animator.GetCurrentAnimatorStateInfo(0);
				object obj40 = obj - -64;
				object obj41 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
				object obj42 = obj - -64;
				int num13 = id_Glider;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ S1_v102+8]");
				if ((nint)num13 != 0)
				{
					animator.Play(id_Glider);
				}
			}
		}
		else if (willAllowSignatureAnimation)
		{
			object obj43 = obj25 << 2;
			object obj44 = (object)hoverboardBundle2.customSets + obj43;
			bool useLowrider = (byte)(obj15 & 1) != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ S1_v72+10]");
			PlaySignatureMove((HoverboardBundle.CustomSet)0, characterAnimation, useLowrider);
		}
	}

	private void AddCustomModelsAndFX(HoverboardBundle.CustomSet[] customSets, int customSetIndex, Transform hoverboardRoot)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_01fa: Expected Obj, but got I
		if (customSets.Length <= customSetIndex)
		{
			return;
		}
		int num = customSetIndex << 2;
		object obj = customSets + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11+8]");
		if ((nint)0 == 7)
		{
			CachMaterials();
		}
		int num2 = customSetIndex << 2;
		object obj3 = customSets + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v16+10]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v17+C]");
		if ((UnityEngine.Object)0 != null)
		{
			CharacterModel characterModel = this.characterModel;
			characterModel.currentHoverboadBasemodel.enabled = false;
			hoverboardBundle.AddCustomBaseModel(customSetIndex, isMenu: true);
			CharacterModel characterModel2 = this.characterModel;
			cachedHoverboardBaseModelRenderer = characterModel2.currentHoverboadBasemodel;
		}
		hoverboardBundle.AddCustomSetModelAndEffect(customSetIndex, isMenu: true, addEffect: true);
		int num3 = customSetIndex << 2;
		object obj5 = customSets + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v27+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v28+8]");
		if ((nint)0 == 6)
		{
			GameObject gameObject = hoverboardBundle.gameObject;
			nint num4 = 0;
			nint num5 = 0;
			IntPtr intPtr = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S4_v5 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			GliderAnimation gliderAnimation = default;
			this.gliderAnimation = gliderAnimation;
			if (this.gliderAnimation != null)
			{
				this.gliderAnimation.AddEvents(this);
			}
		}
	}

	public void PlaySignatureMove(HoverboardBundle.CustomSet set, Animation characterAnimation, bool useLowrider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected Obj, but got Unknown
		//IL_0031: Expected Obj, but got I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Expected Obj, but got Unknown
		//IL_072b: Expected I, but got Obj
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		object obj3 = obj + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		if (~(teleportFxActive ? 1u : 0u) == 0)
		{
			ResetTeleportFX();
		}
		object obj4 = set.ability - 1;
		if (set.ability != Hoverboard.BoardAbility.Jumper)
		{
			if ((nint)obj4 != 1)
			{
				if ((nint)obj4 != 2 && (nint)obj4 != 3)
				{
					if ((nint)obj4 != 4)
					{
						if ((nint)obj4 != 5)
						{
							if ((nint)obj4 != 6)
							{
								if ((nint)obj4 == 7)
								{
									string text = vanitySignature.name;
									AnimationState animationState = characterAnimation.get_Item(text);
									if (animationState == null)
									{
										string newName = vanitySignature.name;
										characterAnimation.AddClip(vanitySignature, newName);
									}
									bool isPlaying = characterAnimation.isPlaying;
									string animation = vanitySignature.name;
									if (isPlaying)
									{
										characterAnimation.CrossFade(animation, 0.2f);
									}
									else
									{
										bool flag = characterAnimation.Play(animation);
									}
								}
							}
							else
							{
								CharacterModel characterModel = this.characterModel;
								root = characterModel._hip;
								if (set.ExtraMenuFXPrefab != null)
								{
									GameObject gameObject = UnityEngine.Object.Instantiate(set.ExtraMenuFXPrefab);
									if (_teleboardMenuEffect != null)
									{
										GameObject obj5 = _teleboardMenuEffect.gameObject;
										UnityEngine.Object.Destroy(obj5);
									}
									ATeleboardMenuEffect component = gameObject.GetComponent<ATeleboardMenuEffect>();
									_teleboardMenuEffect = component;
									if (_teleboardMenuEffect == null)
									{
										UnityEngine.Object.Destroy(gameObject);
									}
									else
									{
										ATeleboardMenuEffect teleboardMenuEffect = _teleboardMenuEffect;
										nint num = (nint)teleboardMenuEffect;
										object obj6 = teleboardMenuEffect + 32;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v542 @ S2_v80 (Il2CppClass<ATeleboardMenuEffect>)+DC] (should have been resolved before IL gen)");
									}
								}
								AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
								object obj7 = obj + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
								int num2 = id_Teleboard;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
								if ((nint)num2 != 0)
								{
									animator.Play(id_Teleboard);
								}
								string text2 = teleporterSignature.name;
								AnimationState animationState2 = characterAnimation.get_Item(text2);
								if (animationState2 == null)
								{
									string newName2 = teleporterSignature.name;
									characterAnimation.AddClip(teleporterSignature, newName2);
								}
								bool isPlaying2 = characterAnimation.isPlaying;
								string animation2 = teleporterSignature.name;
								if (isPlaying2)
								{
									characterAnimation.CrossFade(animation2, 0.2f);
								}
								else
								{
									bool flag2 = characterAnimation.Play(animation2);
								}
							}
						}
						else
						{
							AnimatorStateInfo currentAnimatorStateInfo2 = animator.GetCurrentAnimatorStateInfo(0);
							object obj8 = obj + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
							int num3 = id_Glider;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
							if ((nint)num3 != 0)
							{
								animator.Play(id_Glider);
							}
							string text3 = gliderSignature.name;
							AnimationState animationState3 = characterAnimation.get_Item(text3);
							if (animationState3 == null)
							{
								string newName3 = gliderSignature.name;
								characterAnimation.AddClip(gliderSignature, newName3);
							}
							bool isPlaying3 = characterAnimation.isPlaying;
							string animation3 = gliderSignature.name;
							if (isPlaying3)
							{
								characterAnimation.CrossFade(animation3, 0.2f);
							}
							else
							{
								bool flag3 = characterAnimation.Play(animation3);
							}
						}
					}
					else
					{
						string text4 = doublejumperSignature.name;
						AnimationState animationState4 = characterAnimation.get_Item(text4);
						if (animationState4 == null)
						{
							string newName4 = doublejumperSignature.name;
							characterAnimation.AddClip(doublejumperSignature, newName4);
						}
						bool isPlaying4 = characterAnimation.isPlaying;
						string animation4 = doublejumperSignature.name;
						if (isPlaying4)
						{
							characterAnimation.CrossFade(animation4, 0.2f);
						}
						else
						{
							bool flag4 = characterAnimation.Play(animation4);
						}
					}
				}
				else
				{
					float length = speederSignature.length;
					IEnumerator routine = SpeederEvents(length);
					Coroutine coroutine = StartCoroutine(routine);
					string text5 = speederSignature.name;
					AnimationState animationState5 = characterAnimation.get_Item(text5);
					if (animationState5 == null)
					{
						string newName5 = speederSignature.name;
						characterAnimation.AddClip(speederSignature, newName5);
					}
					bool isPlaying5 = characterAnimation.isPlaying;
					string animation5 = speederSignature.name;
					if (isPlaying5)
					{
						characterAnimation.CrossFade(animation5, 0.2f);
					}
					else
					{
						bool flag5 = characterAnimation.Play(animation5);
					}
				}
			}
			else
			{
				string text6 = lowriderSignature.name;
				AnimationState animationState6 = characterAnimation.get_Item(text6);
				if (animationState6 == null)
				{
					string newName6 = lowriderSignature.name;
					characterAnimation.AddClip(lowriderSignature, newName6);
				}
				bool isPlaying6 = characterAnimation.isPlaying;
				string animation6 = lowriderSignature.name;
				if (isPlaying6)
				{
					characterAnimation.CrossFade(animation6, 0.2f);
				}
				else
				{
					bool flag6 = characterAnimation.Play(animation6);
				}
			}
		}
		else
		{
			string text7 = jumperSignature.name;
			AnimationState animationState7 = characterAnimation.get_Item(text7);
			if (animationState7 == null)
			{
				string newName7 = jumperSignature.name;
				characterAnimation.AddClip(jumperSignature, newName7);
			}
			bool isPlaying7 = characterAnimation.isPlaying;
			string animation7 = jumperSignature.name;
			if (isPlaying7)
			{
				characterAnimation.CrossFade(animation7, 0.2f);
			}
			else
			{
				bool flag7 = characterAnimation.Play(animation7);
			}
		}
		string animation8;
		if (useLowrider)
		{
			string text8 = lowriderRunIdle.name;
			AnimationState animationState8 = characterAnimation.get_Item(text8);
			if (animationState8 == null)
			{
				string newName8 = lowriderRunIdle.name;
				characterAnimation.AddClip(lowriderRunIdle, newName8);
			}
			animation8 = lowriderRunIdle.name;
		}
		else
		{
			animation8 = currentIdleClip;
		}
		AnimationState animationState9 = characterAnimation.CrossFadeQueued(animation8, 0.2f);
	}

	private IEnumerator SpeederEvents(float waitTime)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void CachMaterials()
	{
		if (this.characterModel != null)
		{
			CharacterModel characterModel = this.characterModel;
			Material sharedMaterial = characterModel._model.sharedMaterial;
			if (sharedMaterial != teleboardFXMaterial)
			{
				cachedModelMaterial = sharedMaterial;
			}
			CharacterModel characterModel2 = this.characterModel;
			Material[] sharedMaterials = characterModel2._headModel.sharedMaterials;
			if (sharedMaterials[0] != teleboardFXMaterial)
			{
				cachedHeadMaterials = sharedMaterials;
			}
			CharacterModel characterModel3 = this.characterModel;
			Material sharedMaterial2 = characterModel3._outfitModel.sharedMaterial;
			if (sharedMaterial2 != teleboardFXMaterial)
			{
				cachedCustomizationMaterial = sharedMaterial2;
			}
			CharacterModel characterModel4 = this.characterModel;
			bool flag = characterModel4._outfitModel.enabled;
			cachedCustomizationState = flag;
		}
	}

	private unsafe void TeleboardStart(float duration)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0097: Expected I, but got Obj
		//IL_033b: Expected Obj, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected VT, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected VT, but got Unknown
		//IL_01c9: Expected F4, but got I
		//IL_01c4: Expected native int or pointer, but got VT
		//IL_01eb: Expected F4, but got I
		//IL_01e6: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 112);
		if (~(teleportFxActive ? 1u : 0u) == 0)
		{
			ResetTeleportFX();
			ResetAnimator();
			StopCoroutine("TeleportFXStartScale");
		}
		if (!(this.characterModel != null))
		{
			return;
		}
		if (_teleboardMenuEffect != null)
		{
			ATeleboardMenuEffect teleboardMenuEffect = _teleboardMenuEffect;
			nint num = (nint)teleboardMenuEffect;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S3_v10 (Il2CppClass<ATeleboardMenuEffect>)+E4] (should have been resolved before IL gen)");
			return;
		}
		teleportFxActive = true;
		if (teleboardWarp == null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(teleboardWarpPrefab);
			teleboardWarp = gameObject;
			Transform transform = teleboardWarp.transform;
			_ = 1032805417;
			_ = 1032805417;
			_ = 4435865490179447849L;
			_ = 4435865490179447849L;
			Vector3 localScale = (Vector3)(quaternion + 32);
			transform.localScale = localScale;
			Transform transform2 = teleboardWarp.transform;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
			_ = 0;
			_ = 0f;
			_ = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
			_ = 0;
			Vector3 euler = (Vector3)(quaternion + 16);
			Quaternion quaternion2 = Quaternion.Internal_FromEulerRad(euler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			transform2.localRotation = quaternion;
			nint num2 = 0;
			nint num3 = 0;
			IntPtr intPtr = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v254 @ S3_v6 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			Component component = default;
			GameObject gameObject2 = component.gameObject;
			Layers layers = Layers.Instance;
			gameObject2.layer = layers._3DGUI;
			Animation component2 = teleboardWarp.GetComponent<Animation>();
			AnimationState animationState = component2.get_Item("teleboardWarp");
			teleboardAnimation = animationState;
			teleboardAnimation.normalizedTime = 0f;
			teleboardAnimation.weight = 1f;
			teleboardAnimation.enabled = true;
			teleboardAnimation.speed = 0f;
			teleboardWarp.SetActive(value: false);
		}
		CharacterModel characterModel = this.characterModel;
		Renderer component3 = characterModel._model.GetComponent<Renderer>();
		component3.material = teleboardFXMaterial;
		CharacterModel characterModel2 = this.characterModel;
		Material[] materials = characterModel2._headModel.materials;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v44+C]");
		if (0 > (nint)obj2)
		{
			throw new ArrayTypeMismatchException();
		}
		CharacterModel characterModel3 = this.characterModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
		CharacterModel characterModel4 = this.characterModel;
		characterModel4._outfitModel.material = teleboardFXMaterial;
		CharacterModel characterModel5 = this.characterModel;
		cachedHoverboardBaseModelRenderer = characterModel5.currentHoverboadBasemodel;
		Material sharedMaterial = cachedHoverboardBaseModelRenderer.sharedMaterial;
		if (sharedMaterial != teleboardFXMaterial)
		{
			cachedHoverboardMaterial = sharedMaterial;
		}
		cachedHoverboardBaseModelRenderer.material = teleboardFXMaterial;
		CharacterModel characterModel6 = this.characterModel;
		Renderer component4 = characterModel6._meshSuperSneaker.GetComponent<Renderer>();
		Material sharedMaterial2 = component4.sharedMaterial;
		if (sharedMaterial2 != teleboardFXMaterial)
		{
			cachedSupersneakersMaterial = sharedMaterial2;
		}
		CharacterModel characterModel7 = this.characterModel;
		Renderer component5 = characterModel7._meshSuperSneaker.GetComponent<Renderer>();
		component5.material = teleboardFXMaterial;
		CharacterModel characterModel8 = this.characterModel;
		Renderer component6 = characterModel8._doubleJumpers.GetComponent<Renderer>();
		Material sharedMaterial3 = component6.sharedMaterial;
		if (sharedMaterial3 != teleboardFXMaterial)
		{
			cachedDoubleJumperMaterial = sharedMaterial3;
		}
		CharacterModel characterModel9 = this.characterModel;
		Renderer component7 = characterModel9._doubleJumpers.GetComponent<Renderer>();
		component7.material = teleboardFXMaterial;
		this.characterModel.StopEyeAnimations();
		CharacterModel characterModel10 = this.characterModel;
		List<Renderer> currentCustomBoardModelsRenderes = characterModel10.currentCustomBoardModelsRenderes;
		if (currentCustomBoardModelsRenderes._size >= 1)
		{
			CharacterModel characterModel11 = this.characterModel;
			List<Renderer> currentCustomBoardModelsRenderes2 = characterModel11.currentCustomBoardModelsRenderes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Material[] array = default;
			cachedCustomHoverboardModelMaterials = array;
			int num4 = 0;
			int num5;
			while (true)
			{
				CharacterModel characterModel12 = this.characterModel;
				List<Renderer> currentCustomBoardModelsRenderes3 = characterModel12.currentCustomBoardModelsRenderes;
				bool flag = num4 < currentCustomBoardModelsRenderes3._size;
				bool flag2 = !flag;
				num5 = 0;
				if (flag2)
				{
					break;
				}
				CharacterModel characterModel13 = this.characterModel;
				Renderer renderer = characterModel13.currentCustomBoardModelsRenderes.get_Item(num4);
				bool flag3 = renderer != null;
				bool flag4 = !flag3;
				UnityEngine.Object obj3 = null;
				if (!flag4)
				{
					CharacterModel characterModel14 = this.characterModel;
					Renderer renderer2 = characterModel14.currentCustomBoardModelsRenderes.get_Item(num4);
					Material sharedMaterial4 = renderer2.sharedMaterial;
					obj3 = sharedMaterial4;
				}
				if (obj3 != teleboardFXMaterial && obj3 != null)
				{
					throw new ArrayTypeMismatchException();
				}
				int num6 = num4 + 1;
				num4 = num6;
			}
			while (true)
			{
				CharacterModel characterModel15 = this.characterModel;
				List<Renderer> currentCustomBoardModelsRenderes4 = characterModel15.currentCustomBoardModelsRenderes;
				if (num5 >= currentCustomBoardModelsRenderes4._size)
				{
					break;
				}
				CharacterModel characterModel16 = this.characterModel;
				Renderer renderer3 = characterModel16.currentCustomBoardModelsRenderes.get_Item(num5);
				if (renderer3 != null)
				{
					CharacterModel characterModel17 = this.characterModel;
					Renderer renderer4 = characterModel17.currentCustomBoardModelsRenderes.get_Item(num5);
					renderer4.material = teleboardFXMaterial;
				}
				int num7 = num5 + 1;
				num5 = num7;
			}
		}
		IEnumerator routine = TeleportFXStartScale(duration);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator TeleportFXStartScale(float duration)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe void TeleboardEnd(float duration)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected VT, but got Unknown
		//IL_0053: Expected I, but got Obj
		//IL_019f: Expected F4, but got I
		//IL_019a: Expected native int or pointer, but got VT
		//IL_01c1: Expected F4, but got I
		//IL_01bc: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (!(characterModel != null))
		{
			return;
		}
		if (_teleboardMenuEffect != null)
		{
			ATeleboardMenuEffect teleboardMenuEffect = _teleboardMenuEffect;
			nint num = (nint)teleboardMenuEffect;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S3_v5 (Il2CppClass<ATeleboardMenuEffect>)+EC] (should have been resolved before IL gen)");
			return;
		}
		Transform transform = characterModel.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardModelPreviewFactory)+80]");
		_ = 0;
		_ = intialScale;
		Vector3 localScale = vector + 16;
		transform.localScale = localScale;
		if (duration > 0f)
		{
			teleboardWarp.SetActive(value: true);
			teleboardAnimation.normalizedTime = 1f;
			teleboardAnimation.weight = 1f;
			teleboardAnimation.speed = -1.8f;
			teleboardAnimation.enabled = true;
		}
		if (root != null)
		{
			Transform transform2 = teleboardWarp.transform;
			Vector3 position = root.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			transform2.position = vector;
		}
		float length = teleboardAnimation.length;
		throw new ArgumentException();
	}

	private IEnumerator TeleboardEndTimer(float duration)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public unsafe void ResetTeleportFX()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_044b: Expected F4, but got I
		//IL_0446: Expected native int or pointer, but got VT
		//IL_045a: Expected F4, but got VT
		//IL_0455: Expected native int or pointer, but got VT
		//IL_036b: Expected Obj, but got I4
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03e7: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		if (!(this.characterModel != null) || ~(teleportFxActive ? 1u : 0u) != 0)
		{
			return;
		}
		CharacterModel characterModel = this.characterModel;
		characterModel._model.enabled = true;
		CharacterModel characterModel2 = this.characterModel;
		characterModel2._headModel.enabled = true;
		if (cachedHoverboardBaseModelRenderer != null)
		{
			cachedHoverboardBaseModelRenderer.enabled = true;
		}
		SetEnabledWithinCurrentCustomHoverboardModels(isEnabled: true);
		CharacterModel characterModel3 = this.characterModel;
		characterModel3._outfitModel.enabled = cachedCustomizationState;
		CharacterModel characterModel4 = this.characterModel;
		if (characterModel4._currentHoverboard != null)
		{
			CharacterModel characterModel5 = this.characterModel;
			characterModel5._currentHoverboard.SetActive(value: true);
		}
		if (cachedModelMaterial != null)
		{
			CharacterModel characterModel6 = this.characterModel;
			Renderer component = characterModel6._model.GetComponent<Renderer>();
			component.material = cachedModelMaterial;
		}
		CharacterModel characterModel7 = this.characterModel;
		if (characterModel7._headModel != null)
		{
			CharacterModel characterModel8 = this.characterModel;
			Material[] materials = characterModel8._headModel.materials;
			if (materials != null && cachedHeadMaterials != null)
			{
				CharacterModel characterModel9 = this.characterModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
			}
		}
		CharacterModel characterModel10 = this.characterModel;
		characterModel10._outfitModel.material = cachedCustomizationMaterial;
		CharacterModel characterModel11 = this.characterModel;
		characterModel11._meshSuperSneaker.material = cachedSupersneakersMaterial;
		CharacterModel characterModel12 = this.characterModel;
		characterModel12._doubleJumpers.material = cachedDoubleJumperMaterial;
		this.characterModel.StartEyeAnimations(UIModelController.ModelScreen.Boards);
		if (cachedHoverboardBaseModelRenderer != null)
		{
			cachedHoverboardBaseModelRenderer.material = cachedHoverboardMaterial;
		}
		Material[] array = cachedCustomHoverboardModelMaterials;
		if (cachedCustomHoverboardModelMaterials != null && array.Length != 0)
		{
			int num = 0;
			while (true)
			{
				CharacterModel characterModel13 = this.characterModel;
				List<Renderer> currentCustomBoardModelsRenderes = characterModel13.currentCustomBoardModelsRenderes;
				if (num >= currentCustomBoardModelsRenderes._size)
				{
					break;
				}
				Material[] array2 = cachedCustomHoverboardModelMaterials;
				object obj2 = array2.Length - 1;
				if (num <= (nint)obj2)
				{
					CharacterModel characterModel14 = this.characterModel;
					Renderer renderer = characterModel14.currentCustomBoardModelsRenderes.get_Item(num);
					int num2 = num << 2;
					object obj3 = cachedCustomHoverboardModelMaterials + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v50+10]");
					renderer.material = (Material)0;
				}
				int num3 = num + 1;
				num = num3;
			}
		}
		Transform transform = this.characterModel.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HoverboardModelPreviewFactory)+80]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)intialScale;
		transform.localScale = vector;
		teleportFxActive = false;
	}

	private void SetEnabledWithinCurrentCustomHoverboardModels(bool isEnabled)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		CharacterModel characterModel = this.characterModel;
		List<Renderer> currentCustomBoardModelsRenderes = characterModel.currentCustomBoardModelsRenderes;
		if (currentCustomBoardModelsRenderes._size < 1)
		{
			return;
		}
		object obj3 = obj + 16;
		CharacterModel characterModel2 = this.characterModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					goto IL_0273;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj7 == null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj8 != obj9;
			object obj10 = obj11;
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
				goto IL_0273;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj10 = obj12;
			break;
			IL_0273:
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @37E7");
			return;
		}
		_ = 0;
		object obj14 = obj + 16;
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

	private void OpenGlider()
	{
		Action onOpenGlider = OnOpenGlider;
		if (OnOpenGlider != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void CloseGlider()
	{
		Action onCloseGlider = OnCloseGlider;
		if (OnCloseGlider != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void ResetAnimator()
	{
		if (animator != null)
		{
			animator.Play("empty");
		}
	}

	private void OnDestroy()
	{
		instance = null;
	}

	public HoverboardModelPreviewFactory()
	{
		//IL_001a: Expected VT, but got I8
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, HoverboardModelPreviewFactory+HoverboardModelSetup>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, HoverboardModelSetup> dictionary = default;
		name2character = dictionary;
		int num3 = Animator.StringToHash("Base Layer.HoverboardMenuTeleport");
		id_Teleboard = num3;
		int num4 = Animator.StringToHash("Base Layer.HoverboardMenuGlider");
		_ = -1082130432;
		intialScale = (Vector3)(-4647714812233515008L);
		id_Glider = num4;
		base._002Ector();
	}

	private void _003CTeleboardEnd_003Eb__57_0(float t)
	{
		if (t == 1f)
		{
			teleboardWarp.SetActive(value: false);
			animator.StopPlayback();
		}
	}

	private void _003CTeleboardEnd_003Eb__57_1(float t)
	{
		if (t == 1f && ~(teleportFxActive ? 1u : 0u) == 0)
		{
			ResetTeleportFX();
		}
	}
}
