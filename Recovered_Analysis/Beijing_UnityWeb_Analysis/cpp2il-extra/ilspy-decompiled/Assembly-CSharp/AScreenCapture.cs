using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public abstract class AScreenCapture
{
	private string _captureFolder;

	private int _width;

	private int _height;

	private Camera[] _camera;

	private RenderTexture _renderTexture;

	private Texture2D _screenshotTexture;

	public AScreenCapture(string captureFolder, int width, int height, Camera[] camera, int antiAliasing = 8)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0066: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = height;
		object obj3 = obj2 + 12;
		obj3 = width;
		if (camera != null)
		{
			object obj4 = obj2 + 16;
			obj4 = camera;
		}
		if (_width != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
	}

	public AScreenCapture(string captureFolder, int width, int height, Camera camera, int antiAliasing = 8)
	{
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I4
		//IL_023b: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_006a: Expected VT, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_011f: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I
		//IL_0160: Expected I, but got Obj
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = "";
		object obj2 = this + 8;
		obj2 = captureFolder;
		DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal(_captureFolder);
		_width = width;
		_height = height;
		object obj3 = this + 20;
		obj3 = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Logger logger = default;
		logger.Log((LogType)_width, _height, (UnityEngine.Object)32);
		object obj4 = this + 24;
		obj4 = logger;
		_renderTexture.isPowerOfTwo = (byte)antiAliasing != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Texture2D texture2D = default;
		int image = default;
		int x = default;
		texture2D.SetPixelImpl(image, x, 5, (Color)0);
		object obj5 = this + 28;
		obj5 = texture2D;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [camera @ L4 (UnityEngine.Camera)+C]");
		if ((nint)0 <= (nint)1)
		{
			return;
		}
		object obj6 = _camera + 12;
		object obj7 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj8 = _camera + 16;
			object obj9 = obj7 << 2;
			object obj10 = obj8 + obj9;
			UnityEngine.Object obj11 = UnityEngine.Object.Instantiate((UnityEngine.Object)obj10);
			Camera current = Camera.current;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v69 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IFormatProvider provider = (IFormatProvider)((!((UnityEngine.Object)obj10 != current)) ? ((object)obj11) : ((object)"Main"));
			object path = ((IConvertible)_captureFolder).ToType((Type)(object)"/", provider);
			DirectoryInfo directoryInfo2 = Directory.CreateDirectoriesInternal((string)path);
			object obj13 = obj7 + 1;
			obj7 = obj13;
		}
	}

	public virtual void Cleanup()
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 24;
		Vector3 one = Vector3.one;
		object obj4 = obj3 + 36;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		_ = 0;
		object obj5 = this + 16;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		object obj6 = obj3 + 12;
		Vector3 one2 = Vector3.one;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v22+8]");
		_ = 0;
		object obj7 = this + 28;
		obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		_ = 1f;
		Vector3 one3 = Vector3.one;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj8 = this + 44;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	protected unsafe void SaveScreenshot(string name)
	{
		//IL_05bd: Expected I, but got Obj
		//IL_05d3: Expected Obj, but got I
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected I, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected Obj, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected Obj, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected Obj, but got Unknown
		//IL_07b0: Expected Obj, but got I
		//IL_0293: Expected I, but got Obj
		//IL_02a9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_06a1: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got I4
		//IL_02d4: Expected I, but got Obj
		//IL_060b: Expected I, but got Obj
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_0379: Expected Obj, but got I4
		//IL_0379: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0394: Expected Obj, but got I
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_06cf: Expected Obj, but got I
		//IL_06ed: Expected VT, but got Obj
		//IL_056d: Expected I, but got Obj
		//IL_0580: Expected Obj, but got I
		//IL_05a5: Expected VT, but got I
		//IL_04e7: Expected Obj, but got I
		//IL_04f0: Expected Obj, but got I4
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_0422: Expected Obj, but got I4
		//IL_050b: Expected Obj, but got I
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected Obj, but got Unknown
		//IL_045e: Expected I4, but got Obj
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_0491: Expected Obj, but got I
		//IL_049e: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v118 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 + 40);
		object obj3 = obj2 + 32;
		Transform transform = (Transform)(obj2 + 16);
		object obj4 = obj2 + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+28]");
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v86 (Il2CppClass<System.Type>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v113 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = typeof(Camera);
			((IntPtr*)num3)->m_value = (void*)(nint)obj3;
			Type type = Type.internal_from_handle((IntPtr)num3);
			throw new ArrayTypeMismatchException();
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v71 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+2C]");
		AScreenCapture aScreenCapture;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)0))
		{
			aScreenCapture = this;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Logger logger = default;
			logger.Log((LogType)_width, _width, (UnityEngine.Object)16);
			object obj7 = this + 44;
			obj7 = logger;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+2C]");
			UnityEngine.Object.CheckNullArgument((object)0, (string)61);
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S2_v21 (Il2CppMethodInfo)+18]");
			object obj8 = 0;
			object obj9 = obj8;
			object obj10 = obj9 & 0x1FFF;
			object obj11 = obj10 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v318 @ S3_v13 (should have been resolved before IL gen)");
			object obj13 = default;
			object obj12 = obj13 + 12;
			object obj14 = default;
			object obj23 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				object obj15 = obj13 + 16;
				object obj16 = obj14 << 2;
				object name2 = obj15 + obj16;
				Shader shader = Shader.Find((string)name2);
				object obj17 = shader + 12;
				object obj18 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
				{
					object obj19 = shader + 16;
					object obj20 = obj18 << 2;
					object obj21 = obj19 + obj20;
					if (((Material)obj21).SetPass((int)"_Cube"))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+2C]");
						Color color = ((Material)(object)"_Cube").GetColor((string)0);
						obj11 = 0;
					}
					object obj22 = obj18 + 1;
					obj18 = obj22;
				}
				obj14 = obj23 + 1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+20]");
			object obj24 = (nint)0 + (nint)12;
			object obj25 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj25) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+20]");
				object obj26 = (nint)0 + (nint)16;
				object obj27 = obj25 << 2;
				object probe = obj26 + obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+2C]");
				ReflectionProbe.CallReflectionProbeEvent((ReflectionProbe)probe, ReflectionProbe.ReflectionProbeEvent.ReflectionProbeAdded);
				object obj28 = obj25 + 1;
				obj25 = obj28;
			}
			aScreenCapture = this;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+28]");
		GameObject gameObject = ((Component)0).gameObject;
		GameObject gameObject2 = ((Component)(object)aScreenCapture).gameObject;
		transform.position = (Vector3)gameObject2;
		((IntPtr*)num3)->m_value = (void*)(nint)transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 localPosition = ((Transform)num3).localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AScreenCapture)+2C]");
		bool flag = ((Plane*)num9)->Raycast((Ray)0, out *(float*)name);
	}

	private void Screenshot(Camera camera)
	{
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003a: Expected I4, but got Obj
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0157: Expected I4, but got Obj
		//IL_00e5: Expected I, but got Obj
		//IL_016e: Expected I, but got Obj
		//IL_0184: Expected Obj, but got I
		//IL_0271: Expected Obj, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_01af: Expected I, but got Obj
		object obj = _camera + 12;
		object obj2 = default;
		string contents = default;
		object obj10 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _camera + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			((InGameCaptureWrapper)this).Width = (int)obj5;
			Camera[] camera2 = _camera;
			string[] values;
			if (camera2.Length < 2)
			{
				values = (string[])(object)camera;
			}
			else
			{
				UnityEngine.Object obj6 = UnityEngine.Object.Instantiate((UnityEngine.Object)obj5);
				Camera current = Camera.current;
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = (string)((!((UnityEngine.Object)obj5 != current)) ? ((object)obj6) : ((object)"Main"));
				object obj8 = ((IConvertible)text).ToType((Type)(object)"/", (IFormatProvider)(object)camera);
				values = (string[])obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A5F");
			string path = string.ConcatArray(values, (int)".png");
			nint num3 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v19 (Il2CppClass<System.IO.Path>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v27 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot(_captureFolder, path);
			File.WriteAllText((string)flag, contents);
			obj2 = obj10 + 1;
		}
	}
}
