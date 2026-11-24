using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using TopRun;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PlanarRealtimeReflection : MonoBehaviour
{
	public bool m_DisablePixelLights;

	public int m_TextureResolution;

	public float m_clipPlaneOffset;

	private float m_finalClipPlaneOffset;

	public float m_AlphaOverwrite;

	public bool m_ColorReflection;

	public Shader m_RenderCamShader;

	public bool m_NormalsFromMesh;

	public bool m_BaseClipOffsetFromMesh;

	public bool m_BaseClipOffsetFromMeshInverted;

	private Vector3 m_calculatedNormal;

	public LayerMask m_ReflectLayers;

	private Hashtable m_ReflectionCameras;

	private Camera reflectionCamera;

	private RenderTexture m_ReflectionTexture;

	private int m_OldReflectionTextureSize;

	private static bool s_InsideRendering;

	public void OnWillRenderObject()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 44;
		obj = "com.kiloo.subwaysurfers.ScoreLeaderboard";
		CancelInvoke();
	}

	private unsafe void OnDisable()
	{
		//IL_1a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0f: Expected VT, but got Unknown
		//IL_1a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1d: Expected VT, but got Unknown
		//IL_1a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2b: Expected Obj, but got Unknown
		//IL_1a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a39: Expected Obj, but got Unknown
		//IL_1a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a47: Expected Obj, but got Unknown
		//IL_1a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a55: Expected Obj, but got Unknown
		//IL_1a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a63: Expected VT, but got Unknown
		//IL_1a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a71: Expected Obj, but got Unknown
		//IL_1a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7f: Expected Obj, but got Unknown
		//IL_1a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8d: Expected Obj, but got Unknown
		//IL_1a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9b: Expected Obj, but got Unknown
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa9: Expected Obj, but got Unknown
		//IL_1ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab7: Expected Ref, but got Unknown
		//IL_1ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac5: Expected Obj, but got Unknown
		//IL_1ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad3: Expected Obj, but got Unknown
		//IL_1adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae1: Expected Obj, but got Unknown
		//IL_1aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aef: Expected Obj, but got Unknown
		//IL_1af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afd: Expected Obj, but got Unknown
		//IL_1b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0b: Expected Obj, but got Unknown
		//IL_1b14: Expected Obj, but got I4
		//IL_1b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b28: Expected Obj, but got Unknown
		//IL_1b31: Expected Obj, but got I4
		//IL_1b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b45: Expected Obj, but got Unknown
		//IL_1b4e: Expected Obj, but got I4
		//IL_1b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b62: Expected Obj, but got Unknown
		//IL_1b6b: Expected Obj, but got I4
		//IL_1bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc3: Expected Obj, but got Unknown
		//IL_1bcc: Expected Obj, but got I4
		//IL_1bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be0: Expected Obj, but got Unknown
		//IL_1be9: Expected Obj, but got I4
		//IL_1bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfd: Expected Obj, but got Unknown
		//IL_1c06: Expected Obj, but got I4
		//IL_1c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1a: Expected Ref, but got Unknown
		//IL_1c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5b: Expected Obj, but got Unknown
		//IL_1c64: Expected Obj, but got I4
		//IL_1c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c78: Expected Obj, but got Unknown
		//IL_1c81: Expected Obj, but got I4
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c95: Expected Obj, but got Unknown
		//IL_1c9e: Expected Obj, but got I4
		//IL_1cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd6: Expected Obj, but got Unknown
		//IL_1cdf: Expected Obj, but got I4
		//IL_1cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf3: Expected Obj, but got Unknown
		//IL_1cfc: Expected Obj, but got I4
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_0108: Expected I, but got Obj
		//IL_0197: Expected I, but got Obj
		//IL_01ad: Expected Obj, but got I
		//IL_1d7b: Expected Obj, but got I4
		//IL_01d8: Expected I, but got Obj
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_03c3: Expected I, but got Obj
		//IL_03d9: Expected Obj, but got I
		//IL_1ea6: Expected I, but got Obj
		//IL_1ebc: Expected Obj, but got I
		//IL_05ac: Expected I, but got Obj
		//IL_05c2: Expected Obj, but got I
		//IL_0289: Expected I, but got Obj
		//IL_0404: Expected I, but got Obj
		//IL_0772: Expected I, but got Obj
		//IL_05ed: Expected I, but got Obj
		//IL_045a: Expected VT, but got Obj
		//IL_07bf: Expected I, but got Obj
		//IL_07d5: Expected Obj, but got I
		//IL_0643: Expected VT, but got Obj
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_031b: Expected F4, but got Obj
		//IL_0316: Expected native int or pointer, but got VT
		//IL_0330: Expected F4, but got I
		//IL_032b: Expected native int or pointer, but got VT
		//IL_033d: Expected native int or pointer, but got VT
		//IL_034f: Expected native int or pointer, but got VT
		//IL_0372: Expected F4, but got Obj
		//IL_036d: Expected native int or pointer, but got VT
		//IL_0384: Expected F4, but got I
		//IL_037f: Expected native int or pointer, but got VT
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_039c: Expected Obj, but got F4
		//IL_1fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc4: Expected Obj, but got Unknown
		//IL_1fd2: Expected Obj, but got I4
		//IL_1fe9: Expected VT, but got Obj
		//IL_1fe9: Expected Obj, but got VT
		//IL_084c: Expected Obj, but got F4
		//IL_0800: Expected I, but got Obj
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04c7: Expected F4, but got Obj
		//IL_04c2: Expected native int or pointer, but got VT
		//IL_04dc: Expected F4, but got I
		//IL_04d7: Expected native int or pointer, but got VT
		//IL_04fb: Expected I, but got Obj
		//IL_0511: Expected Obj, but got I
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected Obj, but got Unknown
		//IL_06b0: Expected F4, but got Obj
		//IL_06ab: Expected native int or pointer, but got VT
		//IL_06c5: Expected F4, but got I
		//IL_06c0: Expected native int or pointer, but got VT
		//IL_06e4: Expected I, but got Obj
		//IL_06fa: Expected Obj, but got I
		//IL_1e14: Expected F4, but got Obj
		//IL_1e0f: Expected native int or pointer, but got VT
		//IL_1e26: Expected F4, but got I
		//IL_1e21: Expected native int or pointer, but got VT
		//IL_1e33: Expected F4, but got Obj
		//IL_1e2e: Expected native int or pointer, but got VT
		//IL_1e48: Expected F4, but got I
		//IL_1e43: Expected native int or pointer, but got VT
		//IL_0962: Expected Obj, but got F4
		//IL_0887: Expected I, but got Obj
		//IL_089d: Expected Obj, but got I
		//IL_1f22: Expected F4, but got Obj
		//IL_1f1d: Expected native int or pointer, but got VT
		//IL_1f34: Expected F4, but got I
		//IL_1f2f: Expected native int or pointer, but got VT
		//IL_1f41: Expected F4, but got Obj
		//IL_1f3c: Expected native int or pointer, but got VT
		//IL_1f56: Expected F4, but got I
		//IL_1f51: Expected native int or pointer, but got VT
		//IL_1f8a: Unsupported input type for neg.
		//IL_1f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8f: Expected Obj, but got Unknown
		//IL_053c: Expected I, but got Obj
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected Obj, but got Unknown
		//IL_09c7: Expected Obj, but got I4
		//IL_0a07: Expected I, but got Obj
		//IL_0a1d: Expected Obj, but got I
		//IL_0725: Expected I, but got Obj
		//IL_2026: Expected F4, but got Obj
		//IL_2021: Expected native int or pointer, but got VT
		//IL_2038: Expected F4, but got I
		//IL_2033: Expected native int or pointer, but got VT
		//IL_2045: Expected F4, but got Obj
		//IL_2040: Expected native int or pointer, but got VT
		//IL_205a: Expected F4, but got I
		//IL_2055: Expected native int or pointer, but got VT
		//IL_20cc: Expected Obj, but got F4
		//IL_2114: Expected F4, but got Obj
		//IL_210f: Expected native int or pointer, but got VT
		//IL_2129: Expected F4, but got I
		//IL_2124: Expected native int or pointer, but got VT
		//IL_215b: Expected I, but got Obj
		//IL_2171: Expected Obj, but got I
		//IL_08c8: Expected I, but got Obj
		//IL_21c6: Expected F4, but got I
		//IL_21f0: Expected Obj, but got I
		//IL_2205: Expected Obj, but got I
		//IL_2242: Expected I, but got Obj
		//IL_2258: Expected Obj, but got I
		//IL_0a48: Expected I, but got Obj
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected Obj, but got Unknown
		//IL_091f: Expected F4, but got Obj
		//IL_091a: Expected native int or pointer, but got VT
		//IL_0934: Expected F4, but got I
		//IL_092f: Expected native int or pointer, but got VT
		//IL_2282: Expected F4, but got Obj
		//IL_227d: Expected native int or pointer, but got VT
		//IL_2297: Expected F4, but got I
		//IL_2292: Expected native int or pointer, but got VT
		//IL_22a4: Expected I4, but got VT
		//IL_22ad: Expected Obj, but got I4
		//IL_22be: Expected VT, but got Obj
		//IL_0a95: Expected I, but got Obj
		//IL_0b0c: Expected F4, but got Obj
		//IL_0b07: Expected native int or pointer, but got VT
		//IL_0b1e: Expected F4, but got I
		//IL_0b19: Expected native int or pointer, but got VT
		//IL_0b4a: Expected VT, but got I4
		//IL_0ac8: Expected I, but got Obj
		//IL_0b5c: Expected F4, but got Obj
		//IL_0b57: Expected native int or pointer, but got VT
		//IL_0b6e: Expected F4, but got I
		//IL_0b69: Expected native int or pointer, but got VT
		//IL_0bc9: Expected F4, but got Obj
		//IL_0bc4: Expected native int or pointer, but got VT
		//IL_0bdb: Expected F4, but got I
		//IL_0bd6: Expected native int or pointer, but got VT
		//IL_0c40: Expected F4, but got VT
		//IL_0c3b: Expected native int or pointer, but got VT
		//IL_0c55: Expected F4, but got I
		//IL_0c50: Expected native int or pointer, but got VT
		//IL_0cac: Expected Obj, but got VT
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected Obj, but got Unknown
		//IL_0ccd: Expected F4, but got Obj
		//IL_0cc8: Expected native int or pointer, but got VT
		//IL_0ce2: Expected F4, but got I
		//IL_0cdd: Expected native int or pointer, but got VT
		//IL_0cef: Expected F4, but got Obj
		//IL_0cea: Expected native int or pointer, but got VT
		//IL_0d04: Expected F4, but got I
		//IL_0cff: Expected native int or pointer, but got VT
		//IL_0d1f: Expected I4, but got VT
		//IL_0d1f: Expected I4, but got VT
		//IL_0d1f: Expected I4, but got Obj
		//IL_0d3e: Expected VT, but got I4
		//IL_0d3e: Expected Obj, but got VT
		//IL_0d50: Expected Ref, but got F4
		//IL_0db5: Expected F4, but got Obj
		//IL_0db0: Expected native int or pointer, but got VT
		//IL_0dca: Expected F4, but got I
		//IL_0dc5: Expected native int or pointer, but got VT
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected Obj, but got Unknown
		//IL_0df4: Expected F4, but got VT
		//IL_0def: Expected native int or pointer, but got VT
		//IL_0e09: Expected F4, but got I
		//IL_0e04: Expected native int or pointer, but got VT
		//IL_0e64: Expected Ref, but got VT
		//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Expected Obj, but got Unknown
		//IL_0e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Expected Obj, but got Unknown
		//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Expected I4, but got Unknown
		//IL_0ea8: Expected I, but got Obj
		//IL_0ebe: Expected Obj, but got I
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Expected Obj, but got Unknown
		//IL_0ee9: Expected I, but got Obj
		//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7a: Expected Obj, but got Unknown
		//IL_0f94: Expected F4, but got Obj
		//IL_0f8f: Expected native int or pointer, but got VT
		//IL_0fa9: Expected F4, but got I
		//IL_0fa4: Expected native int or pointer, but got VT
		//IL_0fb2: Expected Obj, but got VT
		//IL_0fc4: Expected Obj, but got I4
		//IL_0fd5: Expected VT, but got Obj
		//IL_0fd5: Expected Obj, but got VT
		//IL_0f2e: Expected VT, but got I4
		//IL_0fe7: Expected Obj, but got F4
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffc: Expected Obj, but got Unknown
		//IL_1044: Expected Obj, but got I4
		//IL_1053: Expected Obj, but got F4
		//IL_107a: Expected F4, but got Obj
		//IL_1075: Expected native int or pointer, but got VT
		//IL_108f: Expected F4, but got I
		//IL_108a: Expected native int or pointer, but got VT
		//IL_1098: Expected Obj, but got VT
		//IL_10a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ac: Expected Obj, but got Unknown
		//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c0: Expected Obj, but got Unknown
		//IL_10df: Expected F4, but got Obj
		//IL_10da: Expected native int or pointer, but got VT
		//IL_10f4: Expected F4, but got I
		//IL_10ef: Expected native int or pointer, but got VT
		//IL_10fd: Expected Obj, but got VT
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_113a: Expected Obj, but got Unknown
		//IL_1143: Expected Obj, but got I4
		//IL_1231: Expected Obj, but got I4
		//IL_1240: Expected Obj, but got F4
		//IL_125a: Expected I, but got Obj
		//IL_1270: Expected Obj, but got I
		//IL_2329: Expected Obj, but got I4
		//IL_2338: Expected Obj, but got F4
		//IL_2352: Expected I, but got Obj
		//IL_2368: Expected Obj, but got I
		//IL_1151: Unknown result type (might be due to invalid IL or missing references)
		//IL_1156: Expected Obj, but got Unknown
		//IL_117f: Expected I4, but got Obj
		//IL_23af: Expected F4, but got Obj
		//IL_23aa: Expected native int or pointer, but got VT
		//IL_23c4: Expected F4, but got I
		//IL_23bf: Expected native int or pointer, but got VT
		//IL_23d1: Expected F4, but got Obj
		//IL_23cc: Expected native int or pointer, but got VT
		//IL_23e6: Expected F4, but got I
		//IL_23e1: Expected native int or pointer, but got VT
		//IL_23fb: Expected VT, but got Obj
		//IL_23fb: Expected Ref, but got VT
		//IL_2412: Expected I4, but got Obj
		//IL_129b: Expected I, but got Obj
		//IL_11d6: Expected I4, but got Obj
		//IL_131c: Expected VT, but got Obj
		//IL_12ce: Expected I, but got Obj
		//IL_1216: Unknown result type (might be due to invalid IL or missing references)
		//IL_121b: Expected Obj, but got Unknown
		//IL_11c2: Expected VT, but got I4
		//IL_1371: Expected Obj, but got I4
		//IL_1397: Expected Obj, but got F4
		//IL_13d9: Expected I, but got F4
		//IL_13e6: Expected F4, but got Obj
		//IL_13e1: Expected native int or pointer, but got VT
		//IL_13f8: Expected F4, but got I
		//IL_13f3: Expected native int or pointer, but got VT
		//IL_1405: Expected Ref, but got VT
		//IL_1412: Expected F4, but got Obj
		//IL_140d: Expected native int or pointer, but got VT
		//IL_1424: Expected F4, but got I
		//IL_141f: Expected native int or pointer, but got VT
		//IL_1484: Expected F4, but got VT
		//IL_147f: Expected native int or pointer, but got VT
		//IL_1499: Expected F4, but got I
		//IL_1494: Expected native int or pointer, but got VT
		//IL_155b: Expected VT, but got I4
		//IL_1568: Expected native int or pointer, but got VT
		//IL_157a: Expected native int or pointer, but got VT
		//IL_15c8: Expected F4, but got Obj
		//IL_15c3: Expected native int or pointer, but got VT
		//IL_15da: Expected F4, but got I
		//IL_15d5: Expected native int or pointer, but got VT
		//IL_164b: Expected VT, but got I4
		//IL_1658: Expected F4, but got Obj
		//IL_1653: Expected native int or pointer, but got VT
		//IL_166d: Expected F4, but got I
		//IL_1668: Expected native int or pointer, but got VT
		//IL_16c8: Expected F4, but got Obj
		//IL_16c3: Expected native int or pointer, but got VT
		//IL_16da: Expected F4, but got I
		//IL_16d5: Expected native int or pointer, but got VT
		//IL_174b: Expected F4, but got Obj
		//IL_1746: Expected native int or pointer, but got VT
		//IL_1760: Expected F4, but got I
		//IL_175b: Expected native int or pointer, but got VT
		//IL_17bb: Expected F4, but got Obj
		//IL_17b6: Expected native int or pointer, but got VT
		//IL_17d0: Expected F4, but got I
		//IL_17cb: Expected native int or pointer, but got VT
		//IL_189b: Expected Obj, but got I4
		//IL_199b: Expected I, but got Obj
		//IL_19b1: Expected Obj, but got I
		//IL_18a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ae: Expected Obj, but got Unknown
		//IL_18d6: Expected F4, but got Obj
		//IL_18d1: Expected native int or pointer, but got VT
		//IL_18eb: Expected F4, but got I
		//IL_18e6: Expected native int or pointer, but got VT
		//IL_194b: Expected Obj, but got VT
		//IL_1954: Unknown result type (might be due to invalid IL or missing references)
		//IL_1959: Expected Obj, but got Unknown
		//IL_1988: Expected Obj, but got I4
		//IL_19dc: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 1128);
		Vector3 vector2 = (Vector3)(obj + 1064);
		Transform transform = (Transform)(obj + 1048);
		object obj2 = obj + 712;
		object obj3 = obj + 696;
		object obj4 = obj + 680;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 616);
		Transform transform2 = (Transform)(obj + 552);
		object obj5 = obj + 536;
		Transform transform3 = (Transform)(obj + 524);
		object obj6 = obj + 512;
		Camera camera = (Camera)(obj + 448);
		ref Matrix4x4 reference = ref *(Matrix4x4*)(obj + 384);
		RouteChunk routeChunk = (RouteChunk)(obj + 320);
		Camera camera2 = (Camera)(obj + 256);
		object obj7 = obj + 192;
		Camera camera3 = (Camera)(obj + 128);
		object obj8 = obj - -64;
		object obj9 = obj + 1036;
		obj9 = 0;
		_ = 0;
		object obj10 = obj + 1024;
		obj10 = 0;
		_ = 0;
		object obj11 = obj + 1008;
		obj11 = 0;
		_ = 0;
		RealtimeReflections realtimeReflections = (RealtimeReflections)(obj + 944);
		realtimeReflections = (RealtimeReflections)0;
		((UnityEngine.Object)realtimeReflections).m_CachedPtr = (IntPtr)0;
		realtimeReflections.nearClip = 0f;
		realtimeReflections.oneFacePerFrame = false;
		realtimeReflections.reflectionProbes = null;
		realtimeReflections.cam = null;
		_ = 0;
		_ = 0;
		object obj12 = obj + 932;
		obj12 = 0;
		_ = 0;
		object obj13 = obj + 920;
		obj13 = 0;
		_ = 0;
		object obj14 = obj + 904;
		obj14 = 0;
		_ = 0;
		ref Matrix4x4 reference2 = ref *(Matrix4x4*)(obj + 840);
		reference2 = ref *(Matrix4x4*)null;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj15 = obj + 828;
		obj15 = 0;
		_ = 0;
		object obj16 = obj + 816;
		obj16 = 0;
		_ = 0;
		object obj17 = obj + 752;
		obj17 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj18 = obj + 736;
		obj18 = 0;
		_ = 0;
		object obj19 = obj + 724;
		obj19 = 0;
		_ = 0;
		if (!isActiveAndEnabled)
		{
			return;
		}
		Renderer component = GetComponent<Renderer>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v83 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S1_v753 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component))
		{
			return;
		}
		Renderer component2 = GetComponent<Renderer>();
		Material[] sharedMaterials = component2.sharedMaterials;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S1_v92 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S1_v749 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)(object)sharedMaterials))
		{
			return;
		}
		Renderer component3 = GetComponent<Renderer>();
		string sortingLayerName = component3.sortingLayerName;
		if (sortingLayerName == null)
		{
			return;
		}
		int allCamerasCount = Camera.GetAllCamerasCount();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v118 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v609 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)allCamerasCount))
		{
			return;
		}
		if (~(m_NormalsFromMesh ? 1u : 0u) == 0)
		{
			MeshFilter component4 = GetComponent<MeshFilter>();
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S1_v717 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S1_v745 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component4).FindKernel((string)null) != 0)
			{
				GameObject gameObject = base.gameObject;
				MeshFilter component5 = GetComponent<MeshFilter>();
				Mesh mesh = component5.mesh;
				Vector4[] tangents = mesh.tangents;
				object obj24 = tangents + 16;
				((Vector3*)(nint)vector2)->x = (float)obj24;
				Vector3 vector3 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S1_v727+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				((Vector3*)(nint)vector)->x = vector2.x;
				((Vector3*)(nint)vector)->z = vector2.z;
				Vector3 vector4 = ((Transform)(object)gameObject).InverseTransformDirection(vector);
				((Vector3*)(nint)vector)->x = (float)transform;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				object obj25 = this + 44;
				obj25 = vector.x;
				_ = vector.z;
			}
		}
		if (~(m_BaseClipOffsetFromMesh ? 1u : 0u) == 0)
		{
			MeshFilter component6 = GetComponent<MeshFilter>();
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S1_v672 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S1_v710 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component6).FindKernel((string)null) != 0)
			{
				GameObject gameObject2 = base.gameObject;
				transform.position = (Vector3)gameObject2;
				GameObject gameObject3 = base.gameObject;
				MeshFilter component7 = GetComponent<MeshFilter>();
				Mesh mesh2 = component7.mesh;
				Vector3[] normals = mesh2.normals;
				object obj27 = normals + 16;
				obj2 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ S1_v684+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector5 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Vector3*)(nint)vector5)->z = 0f;
				Vector3 vector6 = ((Transform)(object)gameObject3).InverseTransformPoint(vector);
				nint num11 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S0_v578 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num12 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ S0_v590 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj3;
				Vector3 vector7 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Vector3*)(nint)vector7)->z = 0f;
				Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
				obj18 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
				object obj29 = default;
				float finalClipPlaneOffset = (float)obj29 + m_clipPlaneOffset;
				m_finalClipPlaneOffset = finalClipPlaneOffset;
				goto IL_1e98;
			}
		}
		if (~(m_BaseClipOffsetFromMeshInverted ? 1u : 0u) == 0)
		{
			MeshFilter component8 = GetComponent<MeshFilter>();
			nint num13 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S1_v626 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S1_v665 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component8).FindKernel((string)null) != 0)
			{
				GameObject gameObject4 = base.gameObject;
				transform.position = (Vector3)gameObject4;
				GameObject gameObject5 = base.gameObject;
				MeshFilter component9 = GetComponent<MeshFilter>();
				Mesh mesh3 = component9.mesh;
				Vector3[] normals2 = mesh3.normals;
				object obj31 = normals2 + 16;
				obj2 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ S1_v638+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector8 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Vector3*)(nint)vector8)->z = 0f;
				Vector3 vector9 = ((Transform)(object)gameObject5).InverseTransformPoint(vector);
				nint num15 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ S0_v549 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num16 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ S0_v561 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj3;
				Vector3 vector10 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Vector3*)(nint)vector10)->z = 0f;
				Quaternion quaternion2 = Quaternion.FromToRotation(vector2, vector);
				obj18 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
				object obj34 = default;
				object obj33 = 0 - obj34;
				float finalClipPlaneOffset2 = (float)obj33 + m_clipPlaneOffset;
				m_finalClipPlaneOffset = finalClipPlaneOffset2;
				goto IL_1e98;
			}
		}
		m_finalClipPlaneOffset = m_clipPlaneOffset;
		goto IL_1e98;
		IL_1e98:
		nint num17 = (nint)typeof(PlanarRealtimeReflection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v132 (Il2CppClass<PlanarRealtimeReflection>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num18 = (nint)typeof(PlanarRealtimeReflection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S0_v526 (Il2CppClass<PlanarRealtimeReflection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(s_InsideRendering ? 1u : 0u) == 0)
		{
			return;
		}
		nint num19 = (nint)typeof(PlanarRealtimeReflection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S0_v141 (Il2CppClass<PlanarRealtimeReflection>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num20 = (nint)typeof(PlanarRealtimeReflection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S0_v520 (Il2CppClass<PlanarRealtimeReflection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		s_InsideRendering = true;
		TournamentChangedEventArgs eventArg = (TournamentChangedEventArgs)(this - -64);
		((CountryPopup)this).TournamentChanged((object)allCamerasCount, eventArg);
		GameObject gameObject6 = base.gameObject;
		((Transform)vector).position = (Vector3)gameObject6;
		obj9 = vector.x;
		_ = vector.z;
		if (~(m_NormalsFromMesh ? 1u : 0u) == 0)
		{
			MeshFilter component10 = GetComponent<MeshFilter>();
			nint num21 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S1_v605 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num22 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ S1_v615 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component10).FindKernel((string)null) != 0)
			{
				object obj38 = this + 44;
				((Vector3*)(nint)vector)->x = (float)obj38;
				Vector3 vector11 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S1_v611+8]");
				((Vector3*)(nint)vector11)->z = 0f;
				goto IL_0955;
			}
		}
		GameObject gameObject7 = base.gameObject;
		Vector3 forward = ((Transform)(object)gameObject7).forward;
		goto IL_0955;
		IL_0955:
		obj19 = vector.x;
		_ = vector.z;
		obj10 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v99+8]");
		_ = 0;
		int qualityLevel = QualitySettings.GetQualityLevel();
		if (~(m_DisablePixelLights ? 1u : 0u) == 0)
		{
			((MaterialPropertyBlock)null)._002Ector();
		}
		object obj39 = this - -64;
		((PlanarRealtimeReflection)null).CreateSurfaceObjects((Camera)allCamerasCount, out *(Camera*)obj39);
		transform = (Transform)obj10;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v48+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		obj2 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+8]");
		_ = 0;
		nint num23 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ S0_v170 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj40 = (nint)0 & (nint)0x200;
		if (obj40 != null)
		{
			nint num24 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S0_v507 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector12 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector12)->z = 0f;
		float num25 = vector2.x * vector.x;
		float num26 = vector2.y * vector.y;
		float num27 = num25 + num26;
		float num28 = vector2.z * vector.z;
		float num29 = num27 + num28;
		object obj41 = 0f - num29;
		float num30 = (float)obj41 - m_finalClipPlaneOffset;
		obj3 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v48+8]");
		_ = 0;
		obj4 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v48+8]");
		_ = 0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Matrix4x4 matrix4x2 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v48+8]");
		((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
		_ = 0;
		_ = matrix4x.m20;
		nint num31 = (nint)typeof(Matrix4x4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ S0_v202 (Il2CppClass<UnityEngine.Matrix4x4>)+BA]");
		object obj42 = (nint)0 & (nint)0x200;
		if (obj42 != null)
		{
			nint num32 = (nint)typeof(Matrix4x4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ S0_v504 (Il2CppClass<UnityEngine.Matrix4x4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Matrix4x4 identity = Matrix4x4.identity;
		realtimeReflections = (RealtimeReflections)(object)transform2;
		((UnityEngine.Object)realtimeReflections).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		RealtimeReflections realtimeReflections2 = realtimeReflections;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+10]");
		realtimeReflections2.nearClip = 0f;
		RealtimeReflections realtimeReflections3 = realtimeReflections;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+18]");
		realtimeReflections3.oneFacePerFrame = false;
		RealtimeReflections realtimeReflections4 = realtimeReflections;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+20]");
		realtimeReflections4.reflectionProbes = (ReflectionProbe[])0;
		RealtimeReflections realtimeReflections5 = realtimeReflections;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+28]");
		realtimeReflections5.cam = (Camera)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+38]");
		_ = 0;
		obj5 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v51+8]");
		_ = 0;
		nint num33 = (nint)typeof(PlanarRealtimeReflection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S0_v218 (Il2CppClass<PlanarRealtimeReflection>)+BA]");
		object obj43 = (nint)0 & (nint)0x200;
		if (obj43 != null)
		{
			nint num34 = (nint)typeof(PlanarRealtimeReflection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ S0_v501 (Il2CppClass<PlanarRealtimeReflection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector13 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		realtimeReflections.UpdateCubemap((int)vector);
		GameObject gameObject8 = ((Component)allCamerasCount).gameObject;
		transform3.position = (Vector3)gameObject8;
		obj12 = transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)transform3;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6DD");
		obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
		_ = 0;
		camera.worldToCameraMatrix = (Matrix4x4)allCamerasCount;
		((Vector3*)(nint)vector2)->x = (float)camera;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (UnityEngine.Camera)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (UnityEngine.Camera)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (UnityEngine.Camera)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (UnityEngine.Camera)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (UnityEngine.Camera)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (UnityEngine.Camera)+38]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)realtimeReflections;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)realtimeReflections).m_CachedPtr;
		_ = realtimeReflections.nearClip;
		_ = realtimeReflections.oneFacePerFrame;
		_ = realtimeReflections.reflectionProbes;
		_ = realtimeReflections.cam;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v54 (RealtimeReflections)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v54 (RealtimeReflections)+38]");
		_ = 0;
		Vector4 vector14 = (Matrix4x4)vector2 * (Vector4)vector;
		((Vector3*)(nint)vector)->x = (float)reference;
		Vector3 vector15 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+8]");
		((Vector3*)(nint)vector15)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+38]");
		_ = 0;
		Matrix4x4 projectionMatrix = ((Camera)vector).projectionMatrix;
		object obj44 = this - -64;
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Vector3 vector16 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+8]");
		((Vector3*)(nint)vector16)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector17 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v48+8]");
		((Vector3*)(nint)vector17)->z = 0f;
		routeChunk.PlaceEnvironmentModel((EnvironmentKind)(object)this, (EnvironmentSequence)obj44, (EnvironmentSide)vector2, (int)vector, 1f);
		obj14 = routeChunk;
		_ = ((UnityEngine.Object)routeChunk).m_CachedPtr;
		((Camera)vector2).projectionMatrix = (Matrix4x4)allCamerasCount;
		reference2 = ref *(Matrix4x4*)vector2.x;
		_ = vector2.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (UnityEngine.Vector3)+38]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj14;
		Vector3 vector18 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v69+8]");
		((Vector3*)(nint)vector18)->z = 0f;
		CalculateReflectionMatrix(ref reference2, (Vector4)vector);
		object obj45 = this - -64;
		((Vector3*)(nint)vector)->x = (float)reference2;
		Vector3 vector19 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v72 (UnityEngine.Matrix4x4&)+8]");
		((Vector3*)(nint)vector19)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v72 (UnityEngine.Matrix4x4&)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v72 (UnityEngine.Matrix4x4&)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v72 (UnityEngine.Matrix4x4&)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v72 (UnityEngine.Matrix4x4&)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v72 (UnityEngine.Matrix4x4&)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v72 (UnityEngine.Matrix4x4&)+38]");
		_ = 0;
		((Camera)obj45).get_backgroundColor_Injected(out *(Color*)vector);
		object obj46 = this - -64;
		object obj47 = this + 56;
		int eventMask = obj47 & -17;
		((Camera)obj46).eventMask = eventMask;
		nint num35 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1182 @ S0_v267 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj48 = (nint)0 & (nint)0x200;
		if (obj48 != null)
		{
			nint num36 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ S0_v498 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)m_RenderCamShader).FindKernel((string)null) != 0 && !m_ColorReflection)
		{
			Vector3 vector20 = ((Camera)(object)m_RenderCamShader).WorldToScreenPoint((Vector3)0);
		}
		else
		{
			object obj49 = this - -64;
			((Camera)obj49).ResetProjectionMatrix();
		}
		Matrix4x4 worldToCameraMatrix = ((Camera)(object)m_ReflectionTexture).worldToCameraMatrix;
		GL.Begin(1);
		object obj50 = this - -64;
		GameObject gameObject9 = ((Component)obj50).gameObject;
		((Vector3*)(nint)vector)->x = (float)obj13;
		Vector3 vector21 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v66+8]");
		((Vector3*)(nint)vector21)->z = 0f;
		Vector3 localPosition = ((Transform)vector).localPosition;
		GameObject gameObject10 = ((Component)allCamerasCount).gameObject;
		((Transform)vector2).eulerAngles = (Vector3)gameObject10;
		obj15 = vector2.x;
		_ = vector2.z;
		object obj51 = this - -64;
		GameObject gameObject11 = ((Component)obj51).gameObject;
		transform = (Transform)obj15;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v81+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		obj2 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v81+8]");
		_ = 0;
		obj3 = 0;
		_ = 0;
		obj3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (UnityEngine.Transform)+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector22 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector3*)(nint)vector22)->z = 0f;
		Vector3 localEulerAngles = ((Transform)vector).localEulerAngles;
		object cam = this - -64;
		Camera.FireOnPreCull((Camera)cam);
		object obj52 = this - -64;
		GameObject gameObject12 = ((Component)obj52).gameObject;
		((Vector3*)(nint)vector)->x = (float)obj12;
		Vector3 vector23 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v63+8]");
		((Vector3*)(nint)vector23)->z = 0f;
		Vector3 localPosition2 = ((Transform)vector).localPosition;
		GL.Begin(0);
		Renderer component11 = GetComponent<Renderer>();
		Shader shader = Shader.Find((string)(object)component11);
		object obj53 = shader + 12;
		object obj54 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53))
		{
			object obj55 = shader + 16;
			object obj56 = obj54 << 2;
			object obj57 = obj55 + obj56;
			if (((Material)obj57).SetPass((int)"_ColorReflection"))
			{
				bool colorReflection = m_ColorReflection;
				((Material)obj57).SetColor("_ColorReflection", (Color)colorReflection);
			}
			if (((Material)obj57).SetPass((int)"_ReflectionTex"))
			{
				Color color = ((Material)(object)"_ReflectionTex").GetColor((string)(object)m_ReflectionTexture);
			}
			object obj58 = obj54 + 1;
			obj54 = obj58;
		}
		obj2 = 0;
		_ = 0;
		obj2 = 0.5f;
		_ = 0.5f;
		_ = 0.5f;
		nint num37 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1373 @ S0_v312 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj59 = (nint)0 & (nint)0x200;
		if (obj59 != null)
		{
			nint num38 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1380 @ S0_v473 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		obj4 = 0;
		_ = 0;
		obj4 = 0.5f;
		_ = 0.5f;
		_ = 0.5f;
		nint num39 = (nint)typeof(Matrix4x4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1415 @ S0_v323 (Il2CppClass<UnityEngine.Matrix4x4>)+BA]");
		object obj60 = (nint)0 & (nint)0x200;
		if (obj60 != null)
		{
			nint num40 = (nint)typeof(Matrix4x4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1420 @ S0_v470 (Il2CppClass<UnityEngine.Matrix4x4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform = (Transform)obj2;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Vector3 vector24 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector3*)(nint)vector24)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector25 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		((Vector3*)(nint)vector25)->z = 0f;
		((Matrix4x4*)matrix4x)->SetTRS((Vector3)transform, (Quaternion)vector2, vector);
		GameObject gameObject13 = base.gameObject;
		transform.hasChanged = (byte)(int)gameObject13 != 0;
		obj16 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		GameObject gameObject14 = base.gameObject;
		transform2.Rotate((Vector3)gameObject14);
		obj5 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v84+8]");
		_ = 0;
		transform3 = (Transform)obj16;
		Transform transform7 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v84+8]");
		((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
		obj6 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v84+8]");
		_ = 0;
		camera = (Camera)0;
		((UnityEngine.Object)camera).m_CachedPtr = (IntPtr)0;
		float num41 = 1f / (float)obj5;
		camera = (Camera)num41;
		float num42 = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27 (UnityEngine.Transform)+4]");
		float num43 = num42 / 0f;
		float num44 = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+8]");
		float num45 = num44 / 0f;
		((UnityEngine.Object)camera).m_CachedPtr = (IntPtr)num45;
		((Vector3*)(nint)vector)->x = (float)camera;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera).m_CachedPtr;
		Matrix4x4.Inverse_Injected(ref reference, out *(Matrix4x4*)vector);
		((Vector3*)(nint)vector2)->x = (float)transform2;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (UnityEngine.Transform)+38]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)reference;
		Vector3 vector26 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+8]");
		((Vector3*)(nint)vector26)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (UnityEngine.Matrix4x4&)+38]");
		_ = 0;
		Vector4 vector27 = (Matrix4x4)vector2 * (Vector4)vector;
		obj17 = routeChunk;
		_ = ((UnityEngine.Object)routeChunk).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35 (SYBO.Subway.Routes.RouteChunk)+10]");
		_ = 0;
		_ = routeChunk.OnDeactivate;
		_ = routeChunk._blockCount;
		_ = routeChunk._limitedAllowedEnvironmentKinds;
		_ = routeChunk._environmentTrackObjects;
		_ = routeChunk._forcedEnvironments;
		camera2.projectionMatrix = (Matrix4x4)allCamerasCount;
		((Vector3*)(nint)vector2)->x = matrix4x.m00;
		((Vector3*)(nint)vector2)->z = matrix4x.m20;
		_ = matrix4x.m01;
		_ = matrix4x.m21;
		_ = matrix4x.m02;
		_ = matrix4x.m22;
		_ = matrix4x.m03;
		_ = matrix4x.m23;
		((Vector3*)(nint)vector)->x = (float)camera2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37 (UnityEngine.Camera)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37 (UnityEngine.Camera)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37 (UnityEngine.Camera)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37 (UnityEngine.Camera)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37 (UnityEngine.Camera)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37 (UnityEngine.Camera)+38]");
		_ = 0;
		Vector4 vector28 = (Matrix4x4)vector2 * (Vector4)vector;
		camera3.worldToCameraMatrix = (Matrix4x4)allCamerasCount;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector29 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+8]");
		((Vector3*)(nint)vector29)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+38]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)camera3;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)camera3).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41 (UnityEngine.Camera)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41 (UnityEngine.Camera)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41 (UnityEngine.Camera)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41 (UnityEngine.Camera)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41 (UnityEngine.Camera)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v41 (UnityEngine.Camera)+38]");
		_ = 0;
		Vector4 vector30 = (Matrix4x4)vector2 * (Vector4)vector;
		((Vector3*)(nint)vector2)->x = (float)obj8;
		Vector3 vector31 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+8]");
		((Vector3*)(nint)vector31)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+38]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj17;
		Vector3 vector32 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+8]");
		((Vector3*)(nint)vector32)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+38]");
		_ = 0;
		Vector4 vector33 = (Matrix4x4)vector2 * (Vector4)vector;
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+38]");
		_ = 0;
		object obj61 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj61) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53))
		{
			object obj62 = shader + 16;
			object obj63 = obj61 << 2;
			object obj64 = obj62 + obj63;
			((Vector3*)(nint)vector)->x = (float)obj17;
			Vector3 vector34 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+8]");
			((Vector3*)(nint)vector34)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v87+38]");
			_ = 0;
			((Material)obj64).SetTexture("_ProjMatrix", (Texture)vector);
			object obj65 = obj61 + 1;
			obj61 = obj65;
		}
		if (~(m_DisablePixelLights ? 1u : 0u) == 0)
		{
			((MaterialPropertyBlock)qualityLevel)._002Ector();
		}
		nint num46 = (nint)typeof(PlanarRealtimeReflection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1844 @ S0_v452 (Il2CppClass<PlanarRealtimeReflection>)+BA]");
		object obj66 = (nint)0 & (nint)0x200;
		if (obj66 != null)
		{
			nint num47 = (nint)typeof(PlanarRealtimeReflection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1849 @ S0_v458 (Il2CppClass<PlanarRealtimeReflection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		s_InsideRendering = false;
	}

	private void UpdateCameraModes(Camera src, Camera dest)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerator enumerator = ((FollowingGuard)(object)"Social GameCenter Friends Retrieved").HitByTrainSequenceCoroutine();
		if (enumerator == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Flurry.ShouldLogDailyEvent((string)(object)src);
		bool flag2 = Flurry.ShouldLogDailyEvent((string)(object)dest);
		object obj3 = ((IConvertible)flag).ToType((Type)(object)";", (IFormatProvider)flag2);
	}

	private unsafe void CreateSurfaceObjects(Camera currentCamera, out Camera reflectionCamera)
	{
		//IL_03b7: Expected I, but got Obj
		//IL_03cd: Expected Obj, but got I
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected I4, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected Obj, but got Unknown
		//IL_0505: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I4
		//IL_007e: Expected VT, but got Obj
		//IL_008b: Expected I4, but got Obj
		//IL_00a2: Expected Obj, but got Ref
		//IL_04bf: Expected Obj, but got Ref
		//IL_0327: Expected Obj, but got Ref
		//IL_00ea: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_0346: Expected Obj, but got Ref
		//IL_0405: Expected I4, but got Obj
		//IL_0365: Expected Obj, but got Ref
		//IL_012b: Expected I, but got Obj
		//IL_0548: Expected I4, but got Obj
		//IL_0562: Expected Obj, but got Ref
		//IL_03a3: Expected Obj, but got Ref
		//IL_0591: Expected I, but got Obj
		//IL_05a7: Expected Obj, but got I
		//IL_020e: Expected I, but got Obj
		//IL_0268: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_02a9: Expected I, but got Obj
		//IL_02f6: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v98 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Camera camera = default;
		CameraClearFlags cameraClearFlags = (CameraClearFlags)(camera + 24);
		object obj2 = camera + 20;
		object obj3 = camera + 16;
		if ((UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reflectionCamera) != null)
		{
			return;
		}
		int pixelWidth = currentCamera.pixelWidth;
		Rect rect = ((Camera)pixelWidth).rect;
		camera.backgroundColor = (Color)currentCamera;
		((CameraClearFlags*)(int)cameraClearFlags)->value__ = (int)camera;
		_ = ((UnityEngine.Object)camera).m_CachedPtr;
		((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reflectionCamera)).clearFlags = cameraClearFlags;
		int pixelWidth2 = currentCamera.pixelWidth;
		if (pixelWidth2 == 1)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v42 (Il2CppClass<System.Type>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v94 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(Skybox);
			((CameraClearFlags*)(int)cameraClearFlags)->value__ = (int)obj2;
			Type t = Type.internal_from_handle((IntPtr)(nint)cameraClearFlags);
			Component component = currentCamera.GetComponentInParent(t);
			if ((object)component != null)
			{
				if ((object)component.GetType() != typeof(Skybox))
				{
					component = null;
				}
			}
			else
			{
				component = null;
			}
			obj3 = typeof(Skybox);
			((CameraClearFlags*)(int)cameraClearFlags)->value__ = (int)obj3;
			Type t2 = Type.internal_from_handle((IntPtr)(nint)cameraClearFlags);
			Component component2 = ((Component)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reflectionCamera)).GetComponentInParent(t2);
			if ((object)component2 != null)
			{
				if ((object)component2.GetType() != typeof(Skybox))
				{
					component2 = null;
				}
			}
			else
			{
				component2 = null;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v63 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v76 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component))
			{
				Mesh sharedMesh = ((MeshFilter)component).sharedMesh;
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)sharedMesh))
				{
					component2.tag = (string)1;
					Mesh sharedMesh2 = ((MeshFilter)component).sharedMesh;
					((MeshFilter)component2).sharedMesh = sharedMesh2;
					goto IL_04a5;
				}
			}
			component2.tag = null;
		}
		goto IL_04a5;
		IL_04a5:
		float fieldOfView = currentCamera.fieldOfView;
		((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reflectionCamera)).fieldOfView = fieldOfView;
		float farClipPlane = currentCamera.farClipPlane;
		((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reflectionCamera)).farClipPlane = farClipPlane;
		TransparencySortMode transparencySortMode = currentCamera.transparencySortMode;
		((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reflectionCamera)).transparencySortMode = transparencySortMode;
		float orthographicSize = currentCamera.orthographicSize;
		((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reflectionCamera)).orthographicSize = orthographicSize;
		float x = LightmapperUtils.ExtractInnerCone((Light)(object)currentCamera);
		System.Runtime.CompilerServices.Unsafe.As<Camera, Rect>(ref reflectionCamera).x = x;
		float depth = currentCamera.depth;
		((Camera)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reflectionCamera)).depth = depth;
	}

	private static float sgn(float a)
	{
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Math.Abs(a);
		if (num3 < 0f)
		{
			num3 = 0f;
		}
		else if (num3 > 1f)
		{
			num3 = 1f;
		}
		return num3;
	}

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Vector4 result = default;
		return result;
	}

	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
	{
	}

	private unsafe static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02b1: Expected Obj, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got F4
		//IL_0302: Expected I, but got Obj
		//IL_0318: Expected Obj, but got I
		//IL_033e: Invalid comparison between Obj and F4
		//IL_0069: Invalid comparison between Obj and F4
		//IL_0013: Expected I, but got Obj
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_0378: Expected Obj, but got F4
		//IL_0393: Invalid comparison between I and F4
		//IL_00c3: Invalid comparison between I and F4
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got I4
		//IL_03d7: Expected Obj, but got F4
		//IL_03f6: Expected I, but got Obj
		//IL_040c: Expected Obj, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected VT, but got Unknown
		//IL_0500: Expected F4, but got Obj
		//IL_04fb: Expected native int or pointer, but got VT
		//IL_0515: Expected F4, but got I
		//IL_0510: Expected native int or pointer, but got VT
		//IL_052a: Expected F4, but got I
		//IL_0525: Expected native int or pointer, but got VT
		//IL_053f: Expected F4, but got I
		//IL_053a: Expected native int or pointer, but got VT
		//IL_0554: Expected F4, but got I
		//IL_054f: Expected native int or pointer, but got VT
		//IL_0569: Expected F4, but got I
		//IL_0564: Expected native int or pointer, but got VT
		//IL_057e: Expected F4, but got I
		//IL_0579: Expected native int or pointer, but got VT
		//IL_0593: Expected F4, but got I
		//IL_058e: Expected native int or pointer, but got VT
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected I4, but got Unknown
		//IL_05ae: Expected I4, but got Obj
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected Obj, but got Unknown
		//IL_05d6: Expected Ref, but got VT
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_05f5: Expected Obj, but got F4
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Obj, but got Unknown
		//IL_061a: Expected Obj, but got F4
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected Obj, but got Unknown
		//IL_0655: Expected I, but got Obj
		//IL_066b: Expected Obj, but got I
		//IL_0436: Expected F4, but got Obj
		//IL_0431: Expected native int or pointer, but got VT
		//IL_044b: Expected F4, but got I
		//IL_0446: Expected native int or pointer, but got VT
		//IL_0458: Expected I4, but got Obj
		//IL_048c: Expected I4, but got Obj
		//IL_04b0: Expected Obj, but got F4
		//IL_04cc: Expected I4, but got F4
		//IL_010c: Expected I, but got Obj
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_0159: Expected I, but got Obj
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 224;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6CB");
		object obj4 = obj2 + 144;
		obj4 = plane.x;
		_ = plane.z;
		nint num = (nint)typeof(PlanarRealtimeReflection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v19 (Il2CppClass<PlanarRealtimeReflection>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(PlanarRealtimeReflection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v117 (Il2CppClass<PlanarRealtimeReflection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
		{
			num3 = 1f;
		}
		else
		{
			num3 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f)) ? 0f : (-1f));
		}
		object obj6 = obj2 + 128;
		obj6 = plane.x;
		_ = plane.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v27+4]");
		if (0f > 0f)
		{
			float num4 = 1f;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v27+4]");
			if (0f < 0f)
			{
				float num4 = -1f;
			}
			else
			{
				float num4 = 0f;
			}
		}
		object obj7 = obj2 + 112;
		obj7 = 0;
		_ = 0;
		obj7 = num3;
		_ = 1f;
		_ = 1f;
		nint num5 = (nint)typeof(Matrix4x4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v41 (Il2CppClass<UnityEngine.Matrix4x4>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Matrix4x4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v103 (Il2CppClass<UnityEngine.Matrix4x4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Matrix4x4 matrix4x = (Matrix4x4)(obj2 + 240);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
		Matrix4x4 matrix4x2 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		((Matrix4x4*)(nint)matrix4x2)->m20 = 0f;
		Matrix4x4 matrix4x3 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
		((Matrix4x4*)(nint)matrix4x3)->m01 = 0f;
		Matrix4x4 matrix4x4 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+18]");
		((Matrix4x4*)(nint)matrix4x4)->m21 = 0f;
		Matrix4x4 matrix4x5 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+20]");
		((Matrix4x4*)(nint)matrix4x5)->m02 = 0f;
		Matrix4x4 matrix4x6 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+28]");
		((Matrix4x4*)(nint)matrix4x6)->m22 = 0f;
		Matrix4x4 matrix4x7 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+30]");
		((Matrix4x4*)(nint)matrix4x7)->m03 = 0f;
		Matrix4x4 matrix4x8 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+38]");
		((Matrix4x4*)(nint)matrix4x8)->m23 = 0f;
		int num7 = obj2 + 304;
		((int*)num7)->m_value = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v34+8]");
		_ = 0;
		object obj9 = obj2 + 96;
		Vector4 column = ((Matrix4x4*)matrix4x)->GetColumn(num7);
		object obj10 = obj2 + 80;
		obj10 = plane.x;
		_ = plane.z;
		object obj11 = obj2 - -64;
		obj11 = plane.x;
		_ = plane.z;
		object obj12 = obj2 + 48;
		obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v58+8]");
		_ = 0;
		nint num8 = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v69 (Il2CppClass<UnityEngine.Vector4>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num9 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v99 (Il2CppClass<UnityEngine.Vector4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj11;
		Matrix4x4 matrix4x9 = matrix4x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v63+8]");
		((Matrix4x4*)(nint)matrix4x9)->m20 = 0f;
		((int*)num7)->m_value = (int)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v66+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F948");
		object obj14 = default;
		float num10 = 2f / (float)obj14;
		((int*)num7)->m_value = (int)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v60+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
		obj = matrix4x.m00;
		_ = matrix4x.m20;
		((int*)num7)->m_value = (int)matrix4x.m00;
		_ = matrix4x.m20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D0");
		object obj16 = default;
		object obj15 = ((int*)num7)->m_value - obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6CE");
		object obj17 = obj2 + 32;
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v88+4]");
		object obj19 = default;
		object obj18 = 0 - obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6CE");
		object obj20 = obj2 + 16;
		obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v92+8]");
		object obj22 = default;
		object obj21 = 0 - obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6CE");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
		object obj24 = default;
		object obj23 = 0 - obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F6CE");
	}

	public PlanarRealtimeReflection()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03a8: Expected Obj, but got I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03d2: Expected I, but got Obj
		//IL_03e8: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_0433: Expected Obj, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0239: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got I
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected Obj, but got Unknown
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_01ad: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = 0;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)m_ReflectionTexture))
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v84 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DontDestroyOnLoad(m_ReflectionTexture);
			object obj6 = this + 68;
			obj6 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj7 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj2 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v103 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v112 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj10 = obj3 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj3 + obj12;
		obj13 = 106;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj3 + obj15;
			if ((nint)obj16 == 106)
			{
				object obj17 = obj3 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_04aa;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04aa;
		IL_04aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}
}
