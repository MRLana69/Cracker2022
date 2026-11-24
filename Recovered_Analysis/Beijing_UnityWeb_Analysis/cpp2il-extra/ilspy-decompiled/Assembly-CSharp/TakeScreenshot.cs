using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Managers;
using SYBO.Components.Utilities;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class TakeScreenshot : MonoBehaviour
{
	private sealed class _003CTakeLargeScreenshot_003Ed__17(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TakeScreenshot _003C_003E4__this;

		private Camera _003Ccam_003E5__2;

		private int _003Cx_003E5__3;

		private int _003Cy_003E5__4;

		private int _003Ci_003E5__5;

		private int _003Cn_003E5__6;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0586: Unknown result type (might be due to invalid IL or missing references)
				//IL_058b: Expected Ref, but got Unknown
				//IL_0594: Unknown result type (might be due to invalid IL or missing references)
				//IL_0599: Expected Obj, but got Unknown
				//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a7: Expected Obj, but got Unknown
				//IL_05b0: Expected Obj, but got I4
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Expected Obj, but got Unknown
				//IL_0098: Expected VT, but got Obj
				//IL_00bc: Expected VT, but got Obj
				//IL_00ca: Expected Obj, but got VT
				//IL_0187: Expected VT, but got Obj
				//IL_019e: Expected Obj, but got VT
				//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b7: Expected Obj, but got Unknown
				//IL_01c0: Expected Obj, but got I4
				//IL_01d4: Expected Obj, but got I4
				object obj = default;
				ref Color reference = ref *(Color*)(obj + 72);
				object obj2 = obj + 4;
				object obj3 = obj + 8;
				obj3 = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				TakeScreenshot takeScreenshot = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					takeScreenshot._takingScreenshot = true;
					takeScreenshot._Shoot();
					object obj4 = this + 20;
					Camera component = takeScreenshot.GetComponent<Camera>();
					obj4 = component;
					_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
					float realtimeSinceStartup = Time.realtimeSinceStartup;
					takeScreenshot.timeScaleReset = realtimeSinceStartup;
					_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
					((TimeScaleManager)val2).TimeScaleInMenuDefault = 0f;
					_003Cx_003E5__3 = 0;
					_003Cy_003E5__4 = 0;
					_003Ci_003E5__5 = 0;
					int num = takeScreenshot.scale * takeScreenshot.scale;
					_003Cn_003E5__6 = num;
				}
				if (_003Ci_003E5__5 >= _003Cn_003E5__6)
				{
					_003Ccam_003E5__2.Render();
					_00210 val3 = (_00210)SingletonMonoBehaviour<>.Instantiate();
					((TimeScaleManager)val3).TimeScaleInMenuDefault = takeScreenshot.timeScaleReset;
					takeScreenshot._takingScreenshot = false;
					object obj5 = this + 12;
					obj5 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				float num2 = (float)_003Cx_003E5__3 * takeScreenshot.w;
				float num3 = num2 / (float)takeScreenshot.scale;
				float num4 = takeScreenshot.w * 0.5f;
				float left = num3 - num4;
				takeScreenshot.left = left;
				float num5 = takeScreenshot.w / (float)takeScreenshot.scale;
				float right = takeScreenshot.left + num5;
				takeScreenshot.right = right;
				float num6 = (float)_003Cy_003E5__4 * takeScreenshot.h;
				float num7 = num6 / (float)takeScreenshot.scale;
				float num8 = takeScreenshot.h * 0.5f;
				float bottom = num7 - num8;
				takeScreenshot.bottom = bottom;
				float num9 = takeScreenshot.h / (float)takeScreenshot.scale;
				float top = takeScreenshot.bottom + num9;
				takeScreenshot.top = top;
				float farClipPlane = _003Ccam_003E5__2.farClipPlane;
				float fieldOfView = _003Ccam_003E5__2.fieldOfView;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8DB9");
				reference = ref *(Color*)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+38]");
				_ = 0;
				_003Ccam_003E5__2.get_backgroundColor_Injected(out reference);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
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

	public int scale;

	private bool takeScreenshot;

	private float left;

	private float right;

	private float top;

	private float bottom;

	private float w;

	private float h;

	private float timeScaleReset;

	private bool _takingScreenshot;

	private int screenshotCount;

	private List<Camera> uiCameras;

	private bool uiCamerasEnabled;

	private void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected I8, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0282: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I
		//IL_01e6: Expected I, but got Obj
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_02c3: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj3 = default;
		if (obj3 == null)
		{
			return;
		}
		object obj4 = obj3 + 12;
		object obj5 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj6 = obj3 + 16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			nint num = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v36 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num2 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v47 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime lastWriteTimeUtc = ((FileSystemInfo)obj8).LastWriteTimeUtc;
			long currentSize = (long)(lastWriteTimeUtc + StorageSizeLogging._currentSize);
			StorageSizeLogging._currentSize = currentSize;
			object obj10 = obj5 + 1;
			obj5 = obj10;
		}
		string text = ((DirectoryInfo)(object)this).ToString();
		object obj11 = text + 12;
		object obj12 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
		{
			object obj13 = text + 16;
			object obj14 = obj12 << 2;
			object obj15 = obj13 + obj14;
			nint num3 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v22 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num4 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S1_v28 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((TakeScreenshot)obj15).Start();
			object obj17 = obj12 + 1;
			obj12 = obj17;
		}
	}

	private void Update()
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got I4
		//IL_006b: Expected Obj, but got I4
		//IL_0079: Expected Obj, but got I4
		//IL_0087: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected I4, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper internal_ScriptableRuntimeReflectionSystemSettings_instance = ScriptableRuntimeReflectionSystemSettings.Internal_ScriptableRuntimeReflectionSystemSettings_instance;
		object obj = internal_ScriptableRuntimeReflectionSystemSettings_instance + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = internal_ScriptableRuntimeReflectionSystemSettings_instance + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			bool flag = ((MonoBehaviour)(object)"2DGUI").IsInvoking();
			bool flag2 = ((MonoBehaviour)(object)"2DOVERLAY").IsInvoking();
			object obj6 = (flag2 ? 1 : 0) & 0x1F;
			object obj7 = 1 << (int)obj6;
			object obj8 = (flag ? 1 : 0) & 0x1F;
			object obj9 = 1 << (int)obj8;
			object obj10 = obj7 | obj9;
			bool flag3 = ((MonoBehaviour)(object)"2DOVERLAYCLIP").IsInvoking();
			object obj11 = (flag3 ? 1 : 0) & 0x1F;
			object obj12 = 1 << (int)obj11;
			object obj13 = obj10 | obj12;
			int eventMask = ((Camera)obj5).eventMask;
			if ((obj13 & eventMask) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			}
			object obj14 = obj2 + 1;
			obj2 = obj14;
		}
	}

	private void LimitsFromCameraProjectionMatrix()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
	}

	private void _Shoot()
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0174: Expected Obj, but got I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01c3: Expected VT, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 192;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Camera camera = (Camera)(obj2 + 128);
		Camera component = GetComponent<Camera>();
		camera.projectionMatrix = (Matrix4x4)component;
		obj = camera;
		_ = ((UnityEngine.Object)camera).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (UnityEngine.Camera)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (UnityEngine.Camera)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (UnityEngine.Camera)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (UnityEngine.Camera)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (UnityEngine.Camera)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (UnityEngine.Camera)+38]");
		_ = 0;
		Camera component2 = GetComponent<Camera>();
		float farClipPlane = component2.farClipPlane;
		object obj3 = obj2 - -64;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+38]");
		_ = 0;
		float num = 2f * farClipPlane;
		float num2 = num / (float)obj3;
		w = num2;
		Camera component3 = GetComponent<Camera>();
		float farClipPlane2 = component3.farClipPlane;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+38]");
		_ = 0;
		float num3 = 2f * farClipPlane2;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+14]");
		float num5 = num4 / 0f;
		h = num5;
	}

	private IEnumerator TakeLargeScreenshot()
	{
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = this + 8;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v6+8]");
		_ = 0;
		object obj4 = obj2 + 52;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	private Matrix4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Matrix4x4 result = default;
		return result;
	}

	public TakeScreenshot()
	{
		//IL_0010: Expected Obj, but got I4
		object obj = screenshotCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "screenshot" + text2 + ".png";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A62");
	}
}
