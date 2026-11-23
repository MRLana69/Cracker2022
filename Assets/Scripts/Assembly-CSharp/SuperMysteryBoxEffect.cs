using System;
using Cpp2ILInjected;
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

	public bool isRendering
	{
		get
		{
			return isRendering__BackingField;
		}
		set
		{
			isRendering__BackingField = value;
		}
	}

	private void Awake()
	{
		isRendering__BackingField = false;
	}

	private unsafe void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected VT, but got Unknown
		//IL_0079: Expected Ref, but got VT
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		ParticleSystem[] array = particleSystems;
		object obj3 = default;
		object obj5 = default;
		while (array.Length > (nint)obj3)
		{
			object obj4 = obj5 << 2;
			object obj6 = (object)array + obj4;
			object obj7 = obj - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v43+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v46+8]");
			_ = 0;
			ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)(obj + 56);
			((ParticleSystem.MainModule*)mainModule)->playOnAwake = false;
			obj3 = obj5 + 1;
		}
		Renderer[] array2 = glowRenderers;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Material[] glowMaterials = default;
		_glowMaterials = glowMaterials;
		Renderer[] array3 = glowRenderers;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Color[] glowBaseColors = default;
		_glowBaseColors = glowBaseColors;
		object obj8 = 0;
		Renderer[] array4 = glowRenderers;
		if (array4.Length > (nint)obj8)
		{
			object obj9 = obj8 << 2;
			object obj10 = (object)array4 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v17+10]");
			Material material = ((Renderer)0).material;
			throw new ArrayTypeMismatchException();
		}
		ApplyGlowAniFactor();
	}

	private void Update()
	{
		float num2;
		if (~(_glowShouldBeOn ? 1u : 0u) == 0)
		{
			if (!(_glowAniFactor < 1f))
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			float num = deltaTime * 0.5f;
			num2 = _glowAniFactor + num;
		}
		else
		{
			if (!(_glowAniFactor > 0f))
			{
				return;
			}
			float deltaTime2 = Time.deltaTime;
			float num3 = deltaTime2 * 0.5f;
			num2 = _glowAniFactor - num3;
		}
		float num4 = Math.Min(num2, 1f);
		bool flag = num2 < 0f;
		float glowAniFactor = 0f;
		if (!flag)
		{
			glowAniFactor = num4;
		}
		_glowAniFactor = glowAniFactor;
		ApplyGlowAniFactor();
	}

	public void StartEffect()
	{
		//IL_0039: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		if (!isRendering__BackingField)
		{
			_glowShouldBeOn = true;
			isRendering__BackingField = true;
			ParticleSystem[] array = particleSystems;
			object obj = 0;
			while ((nint)obj < array.Length)
			{
				object obj2 = obj << 2;
				object obj3 = (object)array + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v13+10]");
				((ParticleSystem)0).Play();
				object obj4 = obj + 1;
				obj = obj4;
			}
		}
	}

	public void StopEffect()
	{
		//IL_0029: Expected Obj, but got I4
		//IL_005a: Expected Obj, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		_glowShouldBeOn = false;
		isRendering__BackingField = false;
		ParticleSystem[] array = particleSystems;
		object obj = 0;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v11+10]");
			((ParticleSystem)0).Stop();
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	public void SetVisible(bool visible)
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(visible);
	}

	public void FastForwardEffect(int time)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0048: Expected F4, but got I4
		//IL_0048: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		ParticleSystem[] array = particleSystems;
		object obj = 0;
		while (array.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v10+10]");
			((ParticleSystem)0).Simulate(time);
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	private unsafe void ApplyGlowAniFactor()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00e0: Expected F4, but got I
		//IL_00db: Expected native int or pointer, but got VT
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_0119: Expected Obj, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 48);
		float num = _glowAniFactor * (float)Math.PI;
		float num2 = num + (float)Math.PI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
		object obj2 = default;
		float num3 = (float)obj2 * 0.5f;
		float num4 = num3 + 0.5f;
		object obj3 = default;
		object obj5 = default;
		while (true)
		{
			Material[] glowMaterials = _glowMaterials;
			if (glowMaterials.Length > (nint)obj3)
			{
				object obj4 = obj5 << 2;
				object obj6 = (object)glowMaterials + obj4;
				object obj7 = obj5 << 4;
				object obj8 = (object)_glowBaseColors + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v14+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v14+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
				float num5 = 0f * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+24]");
				float num6 = 0f * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2C]");
				float num7 = 0f * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
				float num8 = 0f * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
				((Color*)(nint)color)->b = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
				((Color*)(nint)color)->r = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v22+10]");
				((Material)0).SetColor("_TintColor", color);
				obj3 = obj5 + 1;
				continue;
			}
			break;
		}
	}

	public SuperMysteryBoxEffect()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		ParticleSystem[] array = default;
		particleSystems = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Renderer[] array2 = default;
		glowRenderers = array2;
		base._002Ector();
	}
}
