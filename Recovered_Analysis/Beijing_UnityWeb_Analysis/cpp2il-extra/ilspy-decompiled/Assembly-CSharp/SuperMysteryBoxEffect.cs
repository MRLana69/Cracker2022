using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

public class SuperMysteryBoxEffect : MonoBehaviour
{
	private const string GLOW_MATERIAL_COLOR_NAME = "_TintColor";

	private const float GLOW_ANI_SPEED = 0.5f;

	public ParticleSystem[] particleSystems;

	public Renderer[] glowRenderers;

	private float _glowAniFactor;

	private bool _glowShouldBeOn;

	private Color[] _glowBaseColors;

	private Material[] _glowMaterials;

	private bool isRendering__BackingField;

	public unsafe bool isRendering
	{
		get
		{
			Collider component = ((Component)(object)glowRenderers).GetComponent<Collider>();
			return component.isTrigger;
		}
		set
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected Obj, but got Unknown
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Expected Obj, but got Unknown
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected Obj, but got Unknown
			//IL_0215: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_006a: Expected Obj, but got I
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected Obj, but got Unknown
			//IL_0095: Expected I, but got Obj
			Collider component = ((Component)(object)glowRenderers).GetComponent<Collider>();
			component.isTrigger = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SuperMysteryBoxEffect)+5C]");
			if ((nint)0 == 0)
			{
				((SlideinPowerupHelper)this).OnGameReviveOffer();
			}
			object obj = default;
			Transform transform = (Transform)(obj + 12);
			if (value)
			{
				SpringPosition component2 = ((Component)(object)glowRenderers).GetComponent<SpringPosition>();
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
				{
					component2.tag = null;
				}
				GameObject gameObject = ((Component)(object)glowRenderers).gameObject;
				object obj3 = this + 56;
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S2_v19+8]");
				_ = 0;
				transform = (Transform)obj;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				Vector3 localPosition = transform.localPosition;
				((SlideinPowerupHelper)this).ResetScoreboosterButtonGlowColor();
			}
			else
			{
				string text = ((Component)(object)glowRenderers).tag;
				object obj4 = this + 56;
				obj = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v4+8]");
				_ = 0;
				transform = (Transform)obj;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				IEnumerator enumerator = ((SpawnPool)(object)text).DoDespawnAfterSeconds(transform, 10f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Delegate obj5 = default;
				obj5.method_ptr = method_ptr;
				obj5.method = (nint)__ldftn(SlideinPowerupHelper.OnPowerup2ButtonAnimatedOut);
				object obj6 = obj5 + 16;
				obj6 = this;
				object obj7 = enumerator + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v25 (System.Collections.IEnumerator)+20]");
				Delegate obj8 = ((Delegate)0).CombineImpl(obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj9 = default;
				obj7 = obj9;
			}
			((SlideinPowerupHelper)this).OnPowerup1ButtonAnimatedOut();
		}
	}

	private void Awake()
	{
		CancelInvoke();
	}

	private void Start()
	{
		isRendering__BackingField = false;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0221: Expected Obj, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		Material material = default;
		object obj = material + 48;
		object obj2 = material + 24;
		object obj3 = material + 16;
		obj3 = 0;
		object obj4 = particleSystems + 12;
		object obj5 = default;
		object obj8 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj6 = particleSystems + 16;
			object obj7 = obj8 << 2;
			object obj9 = obj6 + obj7;
			obj = 0;
			obj = obj9;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11763");
			obj5 = obj8 + 1;
		}
		object obj10 = this + 32;
		Renderer[] array = glowRenderers;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj11 = default;
		obj10 = obj11;
		object obj12 = this + 28;
		Renderer[] array2 = glowRenderers;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj13 = default;
		obj12 = obj13;
		object obj14 = 0;
		Renderer[] array3 = glowRenderers;
		if ((nint)obj14 < array3.Length)
		{
			object obj15 = glowRenderers + 16;
			object obj16 = obj14 << 2;
			object obj17 = obj15 + obj16;
			Material sharedMaterial = ((Renderer)obj17).sharedMaterial;
			throw new ArrayTypeMismatchException();
		}
		this._002Ector();
	}

	public void StartEffect()
	{
		//IL_0046: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_016f: Expected I, but got Obj
		//IL_0185: Expected Obj, but got I
		//IL_0087: Expected I, but got Obj
		//IL_01b0: Expected I, but got Obj
		if (~(_glowShouldBeOn ? 1u : 0u) == 0 && _glowAniFactor < 1f)
		{
			float unscaledTime = Time.unscaledTime;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v40 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v46 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3 = 0.5f * unscaledTime;
			float num4 = _glowAniFactor + num3;
			if (num4 < 0f)
			{
				num4 = 0f;
			}
			else if (num4 > 1f)
			{
				num4 = 1f;
			}
			_glowAniFactor = num4;
			this._002Ector();
		}
		else
		{
			if (~(_glowShouldBeOn ? 1u : 0u) == 0 || !(_glowAniFactor > 0f))
			{
				return;
			}
			float unscaledTime2 = Time.unscaledTime;
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num7 = 0.5f * unscaledTime2;
			float num8 = _glowAniFactor - num7;
			if (num8 < 0f)
			{
				num8 = 0f;
			}
			else if (num8 > 1f)
			{
				num8 = 1f;
			}
			_glowAniFactor = num8;
			this._002Ector();
		}
	}

	public void StopEffect()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0053: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		if (~(isRendering__BackingField ? 1u : 0u) != 0)
		{
			isRendering__BackingField = true;
			_glowShouldBeOn = true;
			object obj = particleSystems + 12;
			object obj2 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj3 = particleSystems + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				((ParticleSystem)obj5).Stop();
				object obj6 = obj2 + 1;
				obj2 = obj6;
			}
		}
	}

	public void SetVisible(bool visible)
	{
		isRendering__BackingField = visible;
	}

	public void FastForwardEffect(int time)
	{
		//IL_0017: Expected Obj, but got I4
		string text = tag;
		((GameObject)(object)text).tag = (string)time;
	}

	private void ApplyGlowAniFactor()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		isRendering__BackingField = false;
		_glowShouldBeOn = false;
		object obj = particleSystems + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = particleSystems + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((ParticleSystem)obj5).Clear();
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}

	public unsafe SuperMysteryBoxEffect()
	{
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected VT, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00ca: Expected F4, but got Obj
		//IL_00c5: Expected native int or pointer, but got VT
		//IL_00df: Expected F4, but got I
		//IL_00da: Expected native int or pointer, but got VT
		//IL_00f6: Expected F4, but got Obj
		//IL_00f1: Expected native int or pointer, but got VT
		//IL_010b: Expected F4, but got I
		//IL_0106: Expected native int or pointer, but got VT
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v32 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Vector4 vector = (Vector4)(obj2 + 32);
		object obj3 = obj2 + 16;
		float num3 = (float)Math.PI * _glowAniFactor;
		float num4 = (float)Math.PI + num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @122E5");
		object obj4 = default;
		float num5 = 0.5f * (float)obj4;
		float num6 = 0.5f + num5;
		object obj5 = default;
		object obj12 = default;
		while (true)
		{
			Material[] glowMaterials = _glowMaterials;
			if ((nint)obj5 < glowMaterials.Length)
			{
				object obj6 = _glowMaterials + 16;
				object obj7 = obj5 << 2;
				object obj8 = obj6 + obj7;
				object obj9 = _glowBaseColors + 16;
				object obj10 = obj5 << 4;
				object obj11 = obj9 + obj10;
				obj3 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S2_v9+8]");
				_ = 0;
				((Vector4*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18+8]");
				((Vector4*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
				((Vector4*)(nint)vector)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector4*)(nint)vector)->z = 0f;
				((Material)obj8).SetVector("_TintColor", vector);
				obj5 = obj12 + 1;
				continue;
			}
			break;
		}
	}
}
