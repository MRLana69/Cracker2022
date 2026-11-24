using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class RealtimeReflections : MonoBehaviour
{
	public int cubemapSize;

	public float nearClip;

	public float farClip;

	public bool oneFacePerFrame;

	public Material[] materials;

	public ReflectionProbe[] reflectionProbes;

	public LayerMask layerMask;

	private Camera cam;

	private RenderTexture renderTexture;

	private void OnEnable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0090: Expected F4, but got I4
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		cubemapSize = 1;
		nearClip = 1024f;
		farClip = 0.07f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v42 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj4 = obj2 + 16;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 44;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18+8]");
		_ = 0;
		obj = 0;
		obj = -1;
		object obj6 = obj2 + 12;
		obj6 = obj;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Hashtable hashtable = default;
		hashtable.Clear();
		object obj7 = this + 60;
		obj7 = hashtable;
		CancelInvoke();
	}

	private void Start()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 36;
		obj = -1;
	}

	private void LateUpdate()
	{
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_00fc: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		object obj2 = reflectionProbes + 12;
		object obj3 = default;
		object obj8 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = reflectionProbes + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			((ReflectionProbe)obj6).customBakedTexture = (Texture)1;
			((ReflectionProbe)obj6).mode = ReflectionProbeMode.Realtime;
			((ReflectionProbe)obj6).boxProjection = (byte)cubemapSize != 0;
			GameObject gameObject = ((Component)obj6).gameObject;
			GameObject gameObject2 = base.gameObject;
			Transform parentInternal = ((Transform)(object)gameObject2).parentInternal;
			((Transform)(object)gameObject).parentInternal = parentInternal;
			GameObject gameObject3 = ((Component)obj6).gameObject;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v23 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			obj3 = obj8 + 1;
		}
		Material[] array = materials;
		if (array.Length != 0)
		{
			((AScreenCapture)(object)this).SaveScreenshot((string)63);
		}
	}

	private void UpdateCubemap(int faceMask)
	{
		//IL_0050: Expected Obj, but got F4
		//IL_00d4: Expected Obj, but got F4
		//IL_01e2: Expected VT, but got F4
		//IL_0261: Expected I, but got F4
		//IL_02a3: Expected I4, but got F4
		//IL_02f5: Expected Obj, but got F4
		//IL_033d: Expected I4, but got F4
		//IL_0348: Expected Obj, but got F4
		//IL_0353: Expected Obj, but got F4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj = default;
		float num = 2f * (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj2 = default;
		float num2 = num * (float)obj2;
		float num3 = 1f - num2;
		RealtimeReflections realtimeReflections = (RealtimeReflections)num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj3 = default;
		float num4 = -2f * (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj4 = default;
		float num5 = num4 * (float)obj4;
		nearClip = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj5 = default;
		float num6 = -2f * (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj6 = default;
		float num7 = num6 * (float)obj6;
		reflectionProbes = (ReflectionProbe[])num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj7 = default;
		float num8 = -2f * (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj8 = default;
		float num9 = num8 * (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj9 = default;
		float num10 = -2f * (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj10 = default;
		float num11 = num10 * (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj11 = default;
		float num12 = 2f * (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj12 = default;
		float num13 = num12 * (float)obj12;
		float num14 = 1f - num13;
		farClip = num14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj13 = default;
		float num15 = -2f * (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj14 = default;
		float num16 = num15 * (float)obj14;
		layerMask = (LayerMask)num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj15 = default;
		float num17 = -2f * (float)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj16 = default;
		float num18 = num17 * (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj17 = default;
		float num19 = -2f * (float)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj18 = default;
		float num20 = num19 * (float)obj18;
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj19 = default;
		float num21 = -2f * (float)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj20 = default;
		float num22 = num21 * (float)obj20;
		oneFacePerFrame = (byte)(int)num22 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj21 = default;
		float num23 = 2f * (float)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj22 = default;
		float num24 = num23 * (float)obj22;
		float num25 = 1f - num24;
		cam = (Camera)num25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj23 = default;
		float num26 = -2f * (float)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1147F");
		object obj24 = default;
		float num27 = num26 * (float)obj24;
		cubemapSize = 0;
		materials = (Material[])0f;
		renderTexture = (RenderTexture)0f;
		_ = 1f;
	}

	private void OnDisable()
	{
		//IL_00af: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I4
		Material[] array = materials;
		if (array.Length != 0)
		{
			if (~(oneFacePerFrame ? 1u : 0u) == 0)
			{
				int renderedFrameCount = Time.renderedFrameCount;
				int num = renderedFrameCount / 6;
				object obj = num * 6;
				object obj2 = renderedFrameCount - obj;
				object obj3 = obj2 & 0x1F;
				string text = (string)(1 << (int)obj3);
				((AScreenCapture)(object)this).SaveScreenshot(text);
			}
			else
			{
				((AScreenCapture)(object)this).SaveScreenshot((string)63);
			}
		}
	}

	public RealtimeReflections()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DontDestroyOnLoad(cam);
		UnityEngine.Object.DontDestroyOnLoad(renderTexture);
	}
}
