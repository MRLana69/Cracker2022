using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Extensions;
using UI;
using UI.Helpers.WelcomePack;
using UI.ModelCamera;
using UnityEngine;

public class RenderTextureManager : MonoBehaviour
{
	private const float CAMERA_Y_OFFSET = 10000f;

	private static RenderTextureManager _instance;

	private GameObject _cameraPrefab;

	private Transform _renderTextureCamerasRoot;

	private List<RenderTextureCamera> _renderTextureCameras;

	private RenderTexture _renderTexturePrefab;

	public static RenderTextureManager instance
	{
		get
		{
			//IL_000b: Expected Obj, but got I4
			return (RenderTextureManager)InRunAverageFPSCounter.runLength__BackingField;
		}
	}

	private void Awake()
	{
		CancelInvoke();
	}

	public RenderTexture GetRenderTextureFor(GameObject go, AnimationClip animationClip = null, CameraSettings overrideCameraSettings = null, bool copySettings = true)
	{
		//IL_0319: Expected Obj, but got I4
		//IL_002a: Expected I, but got Obj
		//IL_0040: Expected Obj, but got I
		//IL_05a2: Expected Obj, but got I
		//IL_0385: Expected I4, but got Obj
		//IL_006b: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I4
		//IL_00cb: Expected Obj, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0303: Expected Obj, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0113: Expected I4, but got Obj
		//IL_01e0: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I4
		//IL_017b: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I4
		//IL_03c2: Expected I, but got Obj
		//IL_03d8: Expected Obj, but got I
		//IL_01be: Expected I4, but got Obj
		//IL_01ca: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_046e: Expected I, but got Obj
		//IL_0494: Expected Obj, but got I4
		//IL_01fc: Expected I, but got Obj
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got I
		//IL_02d6: Expected I4, but got Obj
		CameraSettings cameraSettings = (CameraSettings)(object)"";
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+164]");
		if ((nint)0 != 2)
		{
			_ = 2;
			_ = 1;
			_ = 1;
		}
		((UILabel)(object)animationClip)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+164]");
		RenderTexture result;
		if ((nint)0 != 0)
		{
			nint num = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v29 (Il2CppClass<NGUIText>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v102 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject gameObject = default;
			NGUITools.AddWidgetCollider(gameObject, (byte)(int)go != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+64]");
			if ((nint)gameObject > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				int num3 = default;
				object obj2 = num3 + 16;
				obj2 = 32;
				string text = ((string)(object)go).Substring(num3);
				object obj3 = text + 12;
				object obj4 = 1;
				int num4 = default;
				object obj5 = default;
				StringSplitOptions stringSplitOptions = default;
				while (true)
				{
					if (num4 < (nint)obj3)
					{
						obj5++;
						int num5 = (int)obj3;
						IFormatProvider formatProvider;
						int num10;
						while (true)
						{
							if (num5 > num4)
							{
								stringSplitOptions = (StringSplitOptions)(num5 - num4);
								string[] array = " ".Split((char[])(object)text, num4, stringSplitOptions);
								object obj6 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+140]");
								nint num6;
								object obj7;
								if ((nint)obj6 < 0)
								{
									num6 = (nint)array;
									obj7 = 1;
								}
								else if (num5 < (nint)obj3)
								{
									string text2 = string.ConcatArray(array, (int)"...");
									num6 = (nint)text2;
									obj7 = 0;
								}
								else
								{
									num6 = (nint)array;
									obj7 = 1;
								}
								nint num7 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v78 (Il2CppClass<NGUIText>)+BA]");
								object obj8 = (nint)0 & (nint)0x200;
								if (obj8 != null)
								{
									nint num8 = (nint)typeof(NGUIText);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S0_v90 (Il2CppClass<NGUIText>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								NGUITools.AddWidgetCollider(gameObject, (byte)num6 != 0);
								int num9 = num5 - 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+64]");
								bool flag = (nint)gameObject < 0;
								bool flag2 = !flag;
								num5 = num9;
								obj4 = obj7;
								if (!flag2)
								{
									object obj9 = ((IConvertible)overrideCameraSettings).ToType((Type)num6, (IFormatProvider)(object)" ");
									cameraSettings = (CameraSettings)obj9;
									formatProvider = (IFormatProvider)(object)" ";
									num10 = num9;
									obj4 = obj7;
									break;
								}
								continue;
							}
							formatProvider = (IFormatProvider)stringSplitOptions;
							num10 = num4;
							break;
						}
						object obj10 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+140]");
						if ((nint)obj10 < 0)
						{
							object obj11 = obj3 - 1;
							if (num10 < (nint)obj11)
							{
								num4 = num10 + 1;
								stringSplitOptions = (StringSplitOptions)formatProvider;
								continue;
							}
						}
						object obj12 = obj4 & 1;
						bool flag3 = obj12 != null;
						nint num11 = (nint)overrideCameraSettings;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S1_v44 (Il2CppClass<UI.CameraSettings>)+8]");
						bool flag4 = (nint)0 >= (nint)(copySettings ? 1 : 0);
						result = (RenderTexture)(flag3 & flag4);
					}
					else
					{
						object obj13 = obj4 & 1;
						bool flag5 = obj13 != null;
						result = (RenderTexture)flag5;
					}
					break;
				}
				goto IL_04b8;
			}
		}
		cameraSettings = (CameraSettings)(object)go;
		result = (RenderTexture)1;
		goto IL_04b8;
		IL_04b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+164]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+164]");
		if (num12 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+164]");
			_ = 0;
			_ = 1;
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+64]");
		((UIWidget)(object)animationClip).height = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animationClip @ L2 (UnityEngine.AnimationClip)+68]");
		Color color = ((UIWidget)0).color;
		return result;
	}

	public void ReleaseTexture(RenderTexture texture)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_00c5: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I
		//IL_01c9: Expected Obj, but got I4
		//IL_01c9: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_0205: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I
		//IL_0217: Expected Obj, but got I
		_cameraPrefab.tag = null;
		((GameObject)(object)_renderTextureCamerasRoot).tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
		((GameObject)(object)_renderTexturePrefab).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+1C]");
		((GameObject)0).tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+24]");
		((GameObject)0).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+28]");
		((GameObject)0).tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+30]");
		((GameObject)0).tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+34]");
		((GameObject)0).tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
		if ((object)texture != null)
		{
			if ((nint)texture != 1)
			{
				if ((nint)texture != 2)
				{
					if ((nint)texture == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+30]");
						((GameObject)0).tag = (string)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+34]");
						((GameObject)0).tag = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+24]");
					((GameObject)0).tag = (string)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+28]");
					((GameObject)0).tag = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
				}
			}
			else
			{
				((GameObject)(object)_renderTexturePrefab).tag = (string)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RenderTextureManager)+1C]");
				((GameObject)0).tag = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
			}
		}
		else
		{
			_cameraPrefab.tag = (string)1;
			((GameObject)(object)_renderTextureCamerasRoot).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7345");
		}
	}

	private RenderTextureCamera GetAvailableCamera(bool copySettings)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_037a: Expected Obj, but got I4
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_004d: Expected I, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_0207: Expected Obj, but got I
		//IL_0430: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I
		//IL_008e: Expected I, but got Obj
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0132: Expected Obj, but got I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected Obj, but got Unknown
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
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v90 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v107 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj7 != null)
				{
					object obj8 = obj4 + 4;
					object obj9 = obj8 + 1;
					obj8 = obj9;
					object obj10 = obj9 << 2;
					object obj11 = obj4 + obj10;
					obj11 = 65;
					break;
				}
				continue;
			}
			object obj12 = obj4 + 4;
			object obj13 = obj12 + 1;
			obj12 = obj13;
			object obj14 = obj13 << 2;
			object obj15 = obj4 + obj14;
			obj15 = 63;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj4 + obj16;
			if ((nint)obj17 == 65)
			{
				object obj18 = obj4 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_042a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj4 + obj20;
			if ((nint)obj21 == 63)
			{
				object obj22 = obj4 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_042a;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_042a;
		IL_042a:
		return (RenderTextureCamera)1;
	}

	private RenderTextureCamera CreateNewCamera(bool copySettings)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02fb: Expected Obj, but got I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00f9: Expected Obj, but got I4
		//IL_0181: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		RenderTexture result = default;
		RenderTexture renderTexture = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					object obj7 = obj4 + 4;
					object obj8 = obj7 + 1;
					obj7 = obj8;
					object obj9 = obj8 << 2;
					object obj10 = obj4 + obj9;
					obj10 = 67;
					result = renderTexture;
					break;
				}
				continue;
			}
			object obj11 = obj4 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj4 + obj13;
			obj14 = 59;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 67)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_037f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 59)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_0384;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0384;
		IL_037f:
		return (RenderTextureCamera)(object)result;
		IL_0384:
		RenderTexture renderTexture2 = CreateRenderTexture(copySettings);
		result = renderTexture2;
		goto IL_037f;
	}

	private RenderTexture CreateRenderTexture(bool copySettings)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b0: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate(_cameraPrefab, _renderTextureCamerasRoot);
		Camera component = gameObject.GetComponent<Camera>();
		GameObject gameObject2 = component.gameObject;
		List<RenderTextureCamera> renderTextureCameras = _renderTextureCameras;
		float posZ = (float)renderTextureCameras._size * 10000f;
		TransformExtensions.SetLocalPosZ((Transform)(object)gameObject2, posZ);
		string providerIDForLocation = ((AdSystemTesterCell)this).GetProviderIDForLocation((string)copySettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		WelcomePackBannerHelper welcomePackBannerHelper = default;
		welcomePackBannerHelper.OnPurchaseSuccess((string)(object)component, (byte)(int)gameObject != 0, (IPurchaseValidationResult)(object)providerIDForLocation);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		Matrix4x4 worldToCameraMatrix = ((Camera)(object)providerIDForLocation).worldToCameraMatrix;
		return (RenderTexture)(object)welcomePackBannerHelper;
	}

	private unsafe void CopyRenderTextureSettings(ref RenderTexture dst, RenderTexture src)
	{
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Expected VT, but got Unknown
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Expected Obj, but got Unknown
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Expected Obj, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Expected Obj, but got Unknown
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected Obj, but got Unknown
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Expected Obj, but got Unknown
		//IL_0dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd7: Expected Obj, but got Unknown
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Expected Obj, but got Unknown
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected Obj, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected Obj, but got Unknown
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0f: Expected Obj, but got Unknown
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Expected Obj, but got Unknown
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2b: Expected Obj, but got Unknown
		//IL_0e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e39: Expected Obj, but got Unknown
		//IL_0e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e47: Expected Obj, but got Unknown
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Expected Obj, but got Unknown
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Expected Obj, but got Unknown
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Expected Obj, but got Unknown
		//IL_0e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Expected Obj, but got Unknown
		//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Expected Obj, but got Unknown
		//IL_0e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Expected Obj, but got Unknown
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Expected Obj, but got Unknown
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb7: Expected Obj, but got Unknown
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Expected Obj, but got Unknown
		//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Expected Obj, but got Unknown
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Expected Obj, but got Unknown
		//IL_0eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Expected Obj, but got Unknown
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Expected Obj, but got Unknown
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected Obj, but got Unknown
		//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Expected Obj, but got Unknown
		//IL_0f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Expected Obj, but got Unknown
		//IL_0f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f35: Expected Obj, but got Unknown
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Expected Obj, but got Unknown
		//IL_0f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected Obj, but got Unknown
		//IL_0f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5f: Expected Obj, but got Unknown
		//IL_0f7c: Expected Obj, but got I4
		//IL_0f8a: Expected Obj, but got Ref
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0fc4: Expected I4, but got Obj
		//IL_0fd2: Expected I, but got Obj
		//IL_0fe8: Expected Obj, but got I
		//IL_100e: Expected Obj, but got VT
		//IL_1023: Expected F4, but got Obj
		//IL_101e: Expected native int or pointer, but got VT
		//IL_103d: Expected F4, but got Obj
		//IL_1038: Expected native int or pointer, but got VT
		//IL_1052: Expected F4, but got I
		//IL_104d: Expected native int or pointer, but got VT
		//IL_1061: Expected I4, but got VT
		//IL_106a: Expected Obj, but got VT
		//IL_107f: Expected F4, but got Obj
		//IL_107a: Expected native int or pointer, but got VT
		//IL_00b0: Expected I, but got Obj
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_0149: Expected F4, but got Obj
		//IL_0144: Expected native int or pointer, but got VT
		//IL_015e: Expected F4, but got I
		//IL_0159: Expected native int or pointer, but got VT
		//IL_016d: Expected I4, but got VT
		//IL_0176: Expected Obj, but got VT
		//IL_018b: Expected F4, but got Obj
		//IL_0186: Expected native int or pointer, but got VT
		//IL_00fd: Expected I, but got Obj
		//IL_10e6: Expected I4, but got Obj
		//IL_10f4: Expected I, but got Obj
		//IL_110a: Expected Obj, but got I
		//IL_01aa: Expected F4, but got Obj
		//IL_01a5: Expected native int or pointer, but got VT
		//IL_01bf: Expected F4, but got I
		//IL_01ba: Expected native int or pointer, but got VT
		//IL_01ce: Expected I4, but got VT
		//IL_01d7: Expected Obj, but got VT
		//IL_01ec: Expected F4, but got Obj
		//IL_01e7: Expected native int or pointer, but got VT
		//IL_1130: Expected Obj, but got VT
		//IL_1145: Expected F4, but got Obj
		//IL_1140: Expected native int or pointer, but got VT
		//IL_115f: Expected F4, but got Obj
		//IL_115a: Expected native int or pointer, but got VT
		//IL_1174: Expected F4, but got I
		//IL_116f: Expected native int or pointer, but got VT
		//IL_1183: Expected I4, but got VT
		//IL_118c: Expected Obj, but got VT
		//IL_11a1: Expected F4, but got Obj
		//IL_119c: Expected native int or pointer, but got VT
		//IL_030d: Expected I, but got Obj
		//IL_0529: Expected I, but got Obj
		//IL_053f: Expected Obj, but got I
		//IL_020b: Expected F4, but got Obj
		//IL_0206: Expected native int or pointer, but got VT
		//IL_0220: Expected F4, but got I
		//IL_021b: Expected native int or pointer, but got VT
		//IL_0229: Expected Obj, but got VT
		//IL_0236: Expected Obj, but got VT
		//IL_024b: Expected F4, but got Obj
		//IL_0246: Expected native int or pointer, but got VT
		//IL_03a6: Expected F4, but got Obj
		//IL_03a1: Expected native int or pointer, but got VT
		//IL_03bb: Expected F4, but got I
		//IL_03b6: Expected native int or pointer, but got VT
		//IL_03ca: Expected I4, but got VT
		//IL_03d3: Expected Obj, but got VT
		//IL_03e8: Expected F4, but got Obj
		//IL_03e3: Expected native int or pointer, but got VT
		//IL_035a: Expected I, but got Obj
		//IL_11d0: Expected I4, but got Obj
		//IL_11de: Expected I, but got Obj
		//IL_11f4: Expected Obj, but got I
		//IL_026a: Expected F4, but got Obj
		//IL_0265: Expected native int or pointer, but got VT
		//IL_027f: Expected F4, but got I
		//IL_027a: Expected native int or pointer, but got VT
		//IL_028e: Expected I4, but got VT
		//IL_0407: Expected F4, but got Obj
		//IL_0402: Expected native int or pointer, but got VT
		//IL_041c: Expected F4, but got I
		//IL_0417: Expected native int or pointer, but got VT
		//IL_042b: Expected I4, but got VT
		//IL_0434: Expected Obj, but got VT
		//IL_0449: Expected F4, but got Obj
		//IL_0444: Expected native int or pointer, but got VT
		//IL_121a: Expected Obj, but got VT
		//IL_122f: Expected F4, but got Obj
		//IL_122a: Expected native int or pointer, but got VT
		//IL_1249: Expected F4, but got Obj
		//IL_1244: Expected native int or pointer, but got VT
		//IL_125e: Expected F4, but got I
		//IL_1259: Expected native int or pointer, but got VT
		//IL_126d: Expected I4, but got VT
		//IL_1276: Expected Obj, but got VT
		//IL_128b: Expected F4, but got Obj
		//IL_1286: Expected native int or pointer, but got VT
		//IL_056a: Expected I, but got Obj
		//IL_0786: Expected I, but got Obj
		//IL_079c: Expected Obj, but got I
		//IL_02b0: Expected I4, but got Obj
		//IL_02b9: Expected Obj, but got I4
		//IL_0468: Expected F4, but got Obj
		//IL_0463: Expected native int or pointer, but got VT
		//IL_047d: Expected F4, but got I
		//IL_0478: Expected native int or pointer, but got VT
		//IL_0486: Expected Obj, but got VT
		//IL_0493: Expected Obj, but got VT
		//IL_04a8: Expected F4, but got Obj
		//IL_04a3: Expected native int or pointer, but got VT
		//IL_0603: Expected F4, but got Obj
		//IL_05fe: Expected native int or pointer, but got VT
		//IL_0618: Expected F4, but got I
		//IL_0613: Expected native int or pointer, but got VT
		//IL_0627: Expected I4, but got VT
		//IL_0630: Expected Obj, but got VT
		//IL_0645: Expected F4, but got Obj
		//IL_0640: Expected native int or pointer, but got VT
		//IL_05b7: Expected I, but got Obj
		//IL_12ba: Expected I4, but got Obj
		//IL_12c8: Expected I, but got Obj
		//IL_12de: Expected Obj, but got I
		//IL_04c7: Expected F4, but got Obj
		//IL_04c2: Expected native int or pointer, but got VT
		//IL_04dc: Expected F4, but got I
		//IL_04d7: Expected native int or pointer, but got VT
		//IL_04eb: Expected I4, but got VT
		//IL_0664: Expected F4, but got Obj
		//IL_065f: Expected native int or pointer, but got VT
		//IL_0679: Expected F4, but got I
		//IL_0674: Expected native int or pointer, but got VT
		//IL_0688: Expected I4, but got VT
		//IL_0691: Expected Obj, but got VT
		//IL_06a6: Expected F4, but got Obj
		//IL_06a1: Expected native int or pointer, but got VT
		//IL_1304: Expected Obj, but got VT
		//IL_1319: Expected F4, but got Obj
		//IL_1314: Expected native int or pointer, but got VT
		//IL_1333: Expected F4, but got Obj
		//IL_132e: Expected native int or pointer, but got VT
		//IL_1348: Expected F4, but got I
		//IL_1343: Expected native int or pointer, but got VT
		//IL_1357: Expected I4, but got VT
		//IL_1360: Expected Obj, but got VT
		//IL_1375: Expected F4, but got Obj
		//IL_1370: Expected native int or pointer, but got VT
		//IL_07c7: Expected I, but got Obj
		//IL_09e3: Expected Obj, but got Ref
		//IL_0c92: Expected I, but got Obj
		//IL_0ca8: Expected Obj, but got I
		//IL_050d: Expected I4, but got Obj
		//IL_0516: Expected Obj, but got I4
		//IL_06c5: Expected F4, but got Obj
		//IL_06c0: Expected native int or pointer, but got VT
		//IL_06da: Expected F4, but got I
		//IL_06d5: Expected native int or pointer, but got VT
		//IL_06e3: Expected Obj, but got VT
		//IL_06f0: Expected Obj, but got VT
		//IL_0705: Expected F4, but got Obj
		//IL_0700: Expected native int or pointer, but got VT
		//IL_0860: Expected F4, but got Obj
		//IL_085b: Expected native int or pointer, but got VT
		//IL_0875: Expected F4, but got I
		//IL_0870: Expected native int or pointer, but got VT
		//IL_0884: Expected I4, but got VT
		//IL_088d: Expected Obj, but got VT
		//IL_08a2: Expected F4, but got Obj
		//IL_089d: Expected native int or pointer, but got VT
		//IL_0814: Expected I, but got Obj
		//IL_142e: Expected F4, but got Obj
		//IL_1429: Expected native int or pointer, but got VT
		//IL_0c7f: Expected I4, but got Obj
		//IL_0724: Expected F4, but got Obj
		//IL_071f: Expected native int or pointer, but got VT
		//IL_0739: Expected F4, but got I
		//IL_0734: Expected native int or pointer, but got VT
		//IL_0748: Expected I4, but got VT
		//IL_08c1: Expected F4, but got Obj
		//IL_08bc: Expected native int or pointer, but got VT
		//IL_08d6: Expected F4, but got I
		//IL_08d1: Expected native int or pointer, but got VT
		//IL_08e5: Expected I4, but got VT
		//IL_08ee: Expected Obj, but got VT
		//IL_0903: Expected F4, but got Obj
		//IL_08fe: Expected native int or pointer, but got VT
		//IL_0a7a: Expected I, but got Obj
		//IL_0a90: Expected Obj, but got I
		//IL_0a1b: Expected I4, but got Obj
		//IL_0a2b: Expected I4, but got Obj
		//IL_0d21: Expected I4, but got Obj
		//IL_0cd3: Expected I, but got Obj
		//IL_0d51: Expected Obj, but got I4
		//IL_076a: Expected I4, but got Obj
		//IL_0773: Expected Obj, but got I4
		//IL_0922: Expected F4, but got Obj
		//IL_091d: Expected native int or pointer, but got VT
		//IL_0937: Expected F4, but got I
		//IL_0932: Expected native int or pointer, but got VT
		//IL_0940: Expected Obj, but got VT
		//IL_094d: Expected Obj, but got VT
		//IL_0962: Expected F4, but got Obj
		//IL_095d: Expected native int or pointer, but got VT
		//IL_1390: Expected Obj, but got VT
		//IL_13a5: Expected F4, but got Obj
		//IL_13a0: Expected native int or pointer, but got VT
		//IL_13bf: Expected F4, but got Obj
		//IL_13ba: Expected native int or pointer, but got VT
		//IL_13d4: Expected F4, but got I
		//IL_13cf: Expected native int or pointer, but got VT
		//IL_13e3: Expected I4, but got VT
		//IL_13ec: Expected Obj, but got VT
		//IL_1401: Expected F4, but got Obj
		//IL_13fc: Expected native int or pointer, but got VT
		//IL_0a40: Expected I4, but got Obj
		//IL_0a49: Expected Obj, but got I4
		//IL_0981: Expected F4, but got Obj
		//IL_097c: Expected native int or pointer, but got VT
		//IL_0996: Expected F4, but got I
		//IL_0991: Expected native int or pointer, but got VT
		//IL_09a5: Expected I4, but got VT
		//IL_0b07: Expected F4, but got Obj
		//IL_0b02: Expected native int or pointer, but got VT
		//IL_0b1c: Expected F4, but got I
		//IL_0b17: Expected native int or pointer, but got VT
		//IL_0b2b: Expected I4, but got VT
		//IL_0b34: Expected Obj, but got VT
		//IL_0b49: Expected F4, but got Obj
		//IL_0b44: Expected native int or pointer, but got VT
		//IL_0abb: Expected I, but got Obj
		//IL_09c7: Expected I4, but got Obj
		//IL_09d0: Expected Obj, but got I4
		//IL_0b68: Expected F4, but got Obj
		//IL_0b63: Expected native int or pointer, but got VT
		//IL_0b7d: Expected F4, but got I
		//IL_0b78: Expected native int or pointer, but got VT
		//IL_0b8c: Expected I4, but got VT
		//IL_0b95: Expected Obj, but got VT
		//IL_0baa: Expected F4, but got Obj
		//IL_0ba5: Expected native int or pointer, but got VT
		//IL_0bc9: Expected F4, but got Obj
		//IL_0bc4: Expected native int or pointer, but got VT
		//IL_0bde: Expected F4, but got I
		//IL_0bd9: Expected native int or pointer, but got VT
		//IL_0be7: Expected Obj, but got VT
		//IL_0bf4: Expected Obj, but got VT
		//IL_0c09: Expected F4, but got Obj
		//IL_0c04: Expected native int or pointer, but got VT
		//IL_0c28: Expected F4, but got Obj
		//IL_0c23: Expected native int or pointer, but got VT
		//IL_0c3d: Expected F4, but got I
		//IL_0c38: Expected native int or pointer, but got VT
		//IL_0c4c: Expected I4, but got VT
		//IL_0c5c: Expected I4, but got Obj
		//IL_0c6a: Expected Obj, but got I4
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 216);
		object obj2 = obj + 112;
		object obj3 = obj + 96;
		object obj4 = obj + 212;
		object obj5 = obj + 88;
		object obj6 = obj + 72;
		object obj7 = obj + 208;
		object obj8 = obj - -64;
		object obj9 = obj + 48;
		object obj10 = obj + 204;
		object obj11 = obj + 40;
		object obj12 = obj + 24;
		object obj13 = obj + 200;
		object obj14 = obj + 16;
		object obj15 = obj + 196;
		object obj16 = obj + 192;
		object obj17 = obj + 188;
		object obj18 = obj + 184;
		object obj19 = obj + 180;
		object obj20 = obj + 176;
		object obj21 = obj + 172;
		object obj22 = obj + 168;
		object obj23 = obj + 164;
		object obj24 = obj + 160;
		object obj25 = obj + 156;
		object obj26 = obj + 152;
		object obj27 = obj + 148;
		object obj28 = obj + 144;
		object obj29 = obj + 140;
		object obj30 = obj + 136;
		object obj31 = obj + 132;
		object obj32 = obj + 128;
		object obj33 = obj + 124;
		object obj34 = obj + 120;
		object obj35 = obj + 116;
		string text = ((Component)(object)_cameraPrefab).tag;
		((GameObject)(object)text).tag = (string)1;
		object obj36 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref dst, 1));
		object obj39;
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref dst) != (void*)1)
		{
			if ((nint)obj36 != 1)
			{
				if ((nint)obj36 != 2)
				{
					if ((nint)obj36 == 3)
					{
						nint num = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v241 (Il2CppClass<Strings>)+BA]");
						object obj37 = (nint)0 & (nint)0x200;
						if (obj37 != null)
						{
							nint num2 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v297 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string text2 = Strings.GetDefault("TOPRUN_RANK_4_TITLE");
						((UILabel)(object)_cameraPrefab).fontSize = (int)text2;
						nint num3 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S1_v249 (Il2CppClass<GlobalColors>)+BA]");
						object obj38 = (nint)0 & (nint)0x200;
						if (obj38 != null)
						{
							nint num4 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S1_v291 (Il2CppClass<GlobalColors>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj2 = GlobalColors.TOPRUN_RANK_HEADER_30_BACKGROUND_COLOUR;
						obj26 = obj2;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj26;
						Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						((UIWidget)(object)_renderTexturePrefab).rawPivot = (UIWidget.Pivot)matrix4x;
						obj5 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR;
						obj27 = obj5;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj27;
						Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						((UIWidget)(object)_cameraPrefab).rawPivot = (UIWidget.Pivot)matrix4x;
						obj8 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR;
						obj28 = obj8;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj28;
						Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						((UIWidget)(object)_renderTextureCamerasRoot).rawPivot = (UIWidget.Pivot)matrix4x;
						obj11 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_SHADOW_COLOUR;
						obj29 = obj11;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj29;
						Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						Vector2 effectDistance = ((UILabel)matrix4x).effectDistance;
						obj14 = GlobalColors.TOPRUN_RANK_HEADER_30_TITLE_COLOUR;
						obj30 = obj14;
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj30;
						Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						((UIWidget)(object)_renderTextureCameras).rawPivot = (UIWidget.Pivot)matrix4x;
						string text3 = Strings.GetDefault("TOPRUN_RANK_4_TITLE");
						((UILabel)(object)_renderTextureCameras).fontSize = (int)text3;
						obj39 = 0;
					}
					else
					{
						object obj40 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref dst, -5));
						if ((nint)obj40 > 5)
						{
							((UILabel)(object)_cameraPrefab).fontSize = (int)"";
							((UILabel)(object)_renderTextureCameras).fontSize = (int)"";
							((UILabel)(object)_renderTextureCamerasRoot).fontSize = (int)"";
							obj39 = 0;
						}
						else
						{
							string text4 = ((Component)(object)_cameraPrefab).tag;
							((GameObject)(object)text4).tag = null;
							nint num5 = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S1_v306 (Il2CppClass<GlobalColors>)+BA]");
							object obj41 = (nint)0 & (nint)0x200;
							if (obj41 != null)
							{
								nint num6 = (nint)typeof(GlobalColors);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S1_v347 (Il2CppClass<GlobalColors>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj2 = GlobalColors.TOPRUN_RANK_HEADER_40_BACKGROUND_COLOUR;
							obj31 = obj2;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj31;
							Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
							((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
							((UIWidget)(object)_renderTexturePrefab).rawPivot = (UIWidget.Pivot)matrix4x;
							obj5 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR;
							obj32 = obj5;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj32;
							Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
							((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
							((UIWidget)(object)_cameraPrefab).rawPivot = (UIWidget.Pivot)matrix4x;
							obj8 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR;
							obj33 = obj8;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj33;
							Matrix4x4 matrix4x9 = Matrix4x4.Inverse(matrix4x);
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
							((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
							((UIWidget)(object)_renderTextureCamerasRoot).rawPivot = (UIWidget.Pivot)matrix4x;
							obj11 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_SHADOW_COLOUR;
							obj34 = obj11;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj34;
							Matrix4x4 matrix4x10 = Matrix4x4.Inverse(matrix4x);
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
							((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
							Vector2 effectDistance2 = ((UILabel)matrix4x).effectDistance;
							obj14 = GlobalColors.TOPRUN_RANK_HEADER_40_TITLE_COLOUR;
							obj35 = obj14;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj35;
							Matrix4x4 matrix4x11 = Matrix4x4.Inverse(matrix4x);
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
							((UIWidget)(object)_renderTextureCameras).rawPivot = (UIWidget.Pivot)matrix4x;
							((UILabel)(object)_renderTextureCameras).fontSize = (int)"";
							obj39 = 0;
						}
					}
				}
				else
				{
					nint num7 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v180 (Il2CppClass<Strings>)+BA]");
					object obj42 = (nint)0 & (nint)0x200;
					if (obj42 != null)
					{
						nint num8 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v236 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text5 = Strings.GetDefault("TOPRUN_RANK_3_TITLE");
					((UILabel)(object)_cameraPrefab).fontSize = (int)text5;
					nint num9 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S1_v188 (Il2CppClass<GlobalColors>)+BA]");
					object obj43 = (nint)0 & (nint)0x200;
					if (obj43 != null)
					{
						nint num10 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v230 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj2 = GlobalColors.TOPRUN_RANK_HEADER_20_BACKGROUND_COLOUR;
					obj21 = obj2;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj21;
					Matrix4x4 matrix4x12 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					((UIWidget)(object)_renderTexturePrefab).rawPivot = (UIWidget.Pivot)matrix4x;
					obj5 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR;
					obj22 = obj5;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj22;
					Matrix4x4 matrix4x13 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					((UIWidget)(object)_cameraPrefab).rawPivot = (UIWidget.Pivot)matrix4x;
					obj8 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR;
					obj23 = obj8;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj23;
					Matrix4x4 matrix4x14 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					((UIWidget)(object)_renderTextureCamerasRoot).rawPivot = (UIWidget.Pivot)matrix4x;
					obj11 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_SHADOW_COLOUR;
					obj24 = obj11;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj24;
					Matrix4x4 matrix4x15 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					Vector2 effectDistance3 = ((UILabel)matrix4x).effectDistance;
					obj14 = GlobalColors.TOPRUN_RANK_HEADER_20_TITLE_COLOUR;
					obj25 = obj14;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj25;
					Matrix4x4 matrix4x16 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					((UIWidget)(object)_renderTextureCameras).rawPivot = (UIWidget.Pivot)matrix4x;
					string text6 = Strings.GetDefault("TOPRUN_RANK_3_TITLE");
					((UILabel)(object)_renderTextureCameras).fontSize = (int)text6;
					obj39 = 0;
				}
			}
			else
			{
				nint num11 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v119 (Il2CppClass<Strings>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num12 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S1_v175 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text7 = Strings.GetDefault("TOPRUN_RANK_2_TITLE");
				((UILabel)(object)_cameraPrefab).fontSize = (int)text7;
				nint num13 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v127 (Il2CppClass<GlobalColors>)+BA]");
				object obj45 = (nint)0 & (nint)0x200;
				if (obj45 != null)
				{
					nint num14 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S1_v169 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.TOPRUN_RANK_HEADER_10_BACKGROUND_COLOUR;
				obj16 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj16;
				Matrix4x4 matrix4x17 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((UIWidget)(object)_renderTexturePrefab).rawPivot = (UIWidget.Pivot)matrix4x;
				obj5 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR;
				obj17 = obj5;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj17;
				Matrix4x4 matrix4x18 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((UIWidget)(object)_cameraPrefab).rawPivot = (UIWidget.Pivot)matrix4x;
				obj8 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR;
				obj18 = obj8;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
				Matrix4x4 matrix4x19 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((UIWidget)(object)_renderTextureCamerasRoot).rawPivot = (UIWidget.Pivot)matrix4x;
				obj11 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_SHADOW_COLOUR;
				obj19 = obj11;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj19;
				Matrix4x4 matrix4x20 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Vector2 effectDistance4 = ((UILabel)matrix4x).effectDistance;
				obj14 = GlobalColors.TOPRUN_RANK_HEADER_10_TITLE_COLOUR;
				obj20 = obj14;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj20;
				Matrix4x4 matrix4x21 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				((UIWidget)(object)_renderTextureCameras).rawPivot = (UIWidget.Pivot)matrix4x;
				string text8 = Strings.GetDefault("TOPRUN_RANK_2_TITLE");
				((UILabel)(object)_renderTextureCameras).fontSize = (int)text8;
				obj39 = 0;
			}
		}
		else
		{
			nint num15 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v58 (Il2CppClass<Strings>)+BA]");
			object obj46 = (nint)0 & (nint)0x200;
			if (obj46 != null)
			{
				nint num16 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v114 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text9 = Strings.GetDefault("TOPRUN_RANK_1_TITLE");
			((UILabel)(object)_cameraPrefab).fontSize = (int)text9;
			nint num17 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S1_v66 (Il2CppClass<GlobalColors>)+BA]");
			object obj47 = (nint)0 & (nint)0x200;
			if (obj47 != null)
			{
				nint num18 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v108 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.TOPRUN_RANK_HEADER_00_BACKGROUND_COLOUR;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x22 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)(object)_renderTexturePrefab).rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR;
			obj7 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			Matrix4x4 matrix4x23 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)(object)_cameraPrefab).rawPivot = (UIWidget.Pivot)matrix4x;
			obj8 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR;
			obj10 = obj8;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
			Matrix4x4 matrix4x24 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)(object)_renderTextureCamerasRoot).rawPivot = (UIWidget.Pivot)matrix4x;
			obj11 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_SHADOW_COLOUR;
			obj13 = obj11;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
			Matrix4x4 matrix4x25 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Vector2 effectDistance5 = ((UILabel)matrix4x).effectDistance;
			obj14 = GlobalColors.TOPRUN_RANK_HEADER_00_TITLE_COLOUR;
			obj15 = obj14;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj15;
			Matrix4x4 matrix4x26 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)(object)_renderTextureCameras).rawPivot = (UIWidget.Pivot)matrix4x;
			string text10 = Strings.GetDefault("TOPRUN_RANK_1_TITLE");
			((UILabel)(object)_renderTextureCameras).fontSize = (int)text10;
			obj39 = 1;
		}
		object obj48 = (object)src >> 31;
		object obj49 = obj39 | obj48;
		if (obj49 != null)
		{
			((UILabel)(object)_renderTextureCamerasRoot).fontSize = (int)"";
		}
		else
		{
			nint num19 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ S0_v97 (Il2CppClass<Strings>)+BA]");
			object obj50 = (nint)0 & (nint)0x200;
			if (obj50 != null)
			{
				nint num20 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S0_v106 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string format = Strings.GetDefault("TOPRUN_RANK_BEST");
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)src;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text11 = string.Format(format, args);
			((UILabel)(object)_renderTextureCamerasRoot).fontSize = (int)text11;
		}
		string text12 = _renderTextureCamerasRoot.tag;
		bool flag = obj39 == null;
		((GameObject)(object)text12).tag = (string)flag;
		string text13 = ((Component)(object)_renderTextureCameras).tag;
		((GameObject)(object)text13).tag = null;
	}

	public RenderTextureManager()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		_instance = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 20;
		object obj2 = default;
		obj = obj2;
	}
}
