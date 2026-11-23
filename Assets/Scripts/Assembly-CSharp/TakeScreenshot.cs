using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Managers;
using UnityEngine;

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

		private int _003Ck_003E5__5;

		private int _003Cj_003E5__6;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00a6: Expected VT, but got Obj
			//IL_00ca: Expected VT, but got Obj
			//IL_00d8: Expected Obj, but got VT
			//IL_02fa: Expected Obj, but got I4
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Expected Obj, but got Unknown
			//IL_014f: Expected VT, but got Obj
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_0338: Expected I4, but got Unknown
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Expected I4, but got Unknown
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Expected I4, but got Unknown
			//IL_0166: Expected Obj, but got VT
			object obj2 = default;
			object obj = obj2 - 128;
			TakeScreenshot takeScreenshot = _003C_003E4__this;
			int num;
			int num2;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 2;
					num = -1;
					if (flag)
					{
						goto IL_04fa;
					}
					goto IL_0509;
				}
				_003C_003E1__state = -1;
				num2 = _003Cj_003E5__6;
			}
			else
			{
				_003C_003E1__state = -1;
				takeScreenshot._takingScreenshot = true;
				takeScreenshot.LimitsFromCameraProjectionMatrix();
				Camera component = takeScreenshot.GetComponent<Camera>();
				_003Ccam_003E5__2 = component;
				_00210 val = (_00210)SingletonMonobehavior<>.Instance;
				float timeScale = Time.timeScale;
				takeScreenshot.timeScaleReset = timeScale;
				_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
				((TimeScaleManager)val2).TimeScale = 0f;
				_003Ck_003E5__5 = 0;
				_003Cx_003E5__3 = 0;
				num2 = (_003Cj_003E5__6 = takeScreenshot.scale * takeScreenshot.scale);
			}
			if (num2 <= _003Ck_003E5__5)
			{
				_003Ccam_003E5__2.ResetProjectionMatrix();
				_00210 val3 = (_00210)SingletonMonobehavior<>.Instance;
				((TimeScaleManager)val3).TimeScale = takeScreenshot.timeScaleReset;
				takeScreenshot._takingScreenshot = false;
				num = 2;
				_003C_003E2__current = null;
				goto IL_04fa;
			}
			float num3 = (float)_003Cx_003E5__3 * takeScreenshot.w;
			float num4 = num3 / (float)takeScreenshot.scale;
			float num5 = takeScreenshot.w * 0.5f;
			float num6 = (takeScreenshot.left = num4 - num5);
			float num7 = takeScreenshot.w / (float)takeScreenshot.scale;
			float right = num6 + num7;
			takeScreenshot.right = right;
			float num8 = (float)_003Cy_003E5__4 * takeScreenshot.h;
			float num9 = num8 / (float)takeScreenshot.scale;
			float num10 = takeScreenshot.h * 0.5f;
			float num11 = (takeScreenshot.bottom = num9 - num10);
			float num12 = takeScreenshot.h / (float)takeScreenshot.scale;
			float top = (takeScreenshot.top = num11 + num12);
			float nearClipPlane = _003Ccam_003E5__2.nearClipPlane;
			float farClipPlane = _003Ccam_003E5__2.farClipPlane;
			Matrix4x4 matrix4x = ((TakeScreenshot)takeScreenshot.scale).PerspectiveOffCenter(takeScreenshot.left, takeScreenshot.right, takeScreenshot.bottom, top, nearClipPlane, farClipPlane);
			object obj3 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
			Matrix4x4 projectionMatrix = default;
			_003Ccam_003E5__2.projectionMatrix = projectionMatrix;
			int num13 = takeScreenshot + 52;
			int num14 = this + 28;
			int num15 = this + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
			IL_0509:
			return true;
			IL_04fa:
			_003C_003E1__state = num;
			goto IL_0509;
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

	public int scale = 2;

	private bool takeScreenshot;

	private float left;

	private float right;

	private float top;

	private float bottom;

	private float w;

	private float h;

	private float timeScaleReset = 1f;

	private bool _takingScreenshot;

	private int screenshotCount;

	private List<Camera> uiCameras;

	private bool uiCamerasEnabled;

	private void Start()
	{
		//IL_0121: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_00ee: Expected Obj, but got I
		Camera[] allCameras = Camera.allCameras;
		object obj = 0;
		while (allCameras.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)allCameras + obj2;
			int num = LayerMask.NameToLayer("2DGUI");
			int num2 = LayerMask.NameToLayer("2DOVERLAY");
			int num3 = 1 << num2;
			int num4 = 1 << num;
			int num5 = num3 | num4;
			int num6 = LayerMask.NameToLayer("2DOVERLAYCLIP");
			int num7 = 1 << num6;
			int num8 = num5 | num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v13+10]");
			int cullingMask = ((Camera)0).cullingMask;
			if ((num8 & cullingMask) != 0)
			{
				List<Camera> list = uiCameras;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v13+10]");
				list.Add((Camera)0);
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
	}

	private void LimitsFromCameraProjectionMatrix()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		Camera component = GetComponent<Camera>();
		Matrix4x4 projectionMatrix = component.projectionMatrix;
		Camera component2 = GetComponent<Camera>();
		float nearClipPlane = component2.nearClipPlane;
		float num = nearClipPlane + nearClipPlane;
		float num2 = num / (float)obj;
		w = num2;
		Camera component3 = GetComponent<Camera>();
		float nearClipPlane2 = component3.nearClipPlane;
		float num3 = nearClipPlane2 + nearClipPlane2;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
		float num5 = num4 / 0f;
		h = num5;
	}

	private unsafe void _Shoot()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		int num = this + 52;
		string text = ((int*)num)->ToString();
		string filename = "screenshot" + text + ".png";
		ScreenCapture.CaptureScreenshot(filename, scale);
	}

	private IEnumerator TakeLargeScreenshot()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private unsafe Matrix4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected VT, but got Unknown
		//IL_0099: Expected Ref, but got VT
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected VT, but got Unknown
		//IL_00bf: Expected Ref, but got VT
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected VT, but got Unknown
		//IL_010c: Expected Ref, but got VT
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected VT, but got Unknown
		//IL_0132: Expected Ref, but got VT
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected VT, but got Unknown
		//IL_0153: Expected Ref, but got VT
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected VT, but got Unknown
		//IL_01a5: Expected Ref, but got VT
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected VT, but got Unknown
		//IL_01f2: Expected Ref, but got VT
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected VT, but got Unknown
		//IL_0218: Expected Ref, but got VT
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected VT, but got Unknown
		//IL_0239: Expected Ref, but got VT
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected VT, but got Unknown
		//IL_025f: Expected Ref, but got VT
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected VT, but got Unknown
		//IL_02bc: Expected Ref, but got VT
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected VT, but got Unknown
		//IL_032d: Expected Ref, but got VT
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected VT, but got Unknown
		//IL_034e: Expected Ref, but got VT
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected VT, but got Unknown
		//IL_0374: Expected Ref, but got VT
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected VT, but got Unknown
		//IL_0395: Expected Ref, but got VT
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected VT, but got Unknown
		//IL_03bb: Expected Ref, but got VT
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 128;
		object obj3 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @237");
		Matrix4x4 zero = Matrix4x4.zero;
		object obj4 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		Matrix4x4 matrix4x = (Matrix4x4)(obj - -64);
		float num = near + near;
		float num2 = right - left;
		float value = num / num2;
		((Matrix4x4*)matrix4x)->set_Item(0, value);
		Matrix4x4 matrix4x2 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x2)->set_Item(4, 0f);
		Matrix4x4 matrix4x3 = (Matrix4x4)(obj - -64);
		float num3 = right + left;
		float num4 = right - left;
		float value2 = num3 / num4;
		((Matrix4x4*)matrix4x3)->set_Item(8, value2);
		Matrix4x4 matrix4x4 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x4)->set_Item(12, 0f);
		Matrix4x4 matrix4x5 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x5)->set_Item(1, 0f);
		Matrix4x4 matrix4x6 = (Matrix4x4)(obj - -64);
		float num5 = near + near;
		float num6 = top - bottom;
		float value3 = num5 / num6;
		((Matrix4x4*)matrix4x6)->set_Item(5, value3);
		Matrix4x4 matrix4x7 = (Matrix4x4)(obj - -64);
		float num7 = top + bottom;
		float num8 = top - bottom;
		float value4 = num7 / num8;
		((Matrix4x4*)matrix4x7)->set_Item(9, value4);
		Matrix4x4 matrix4x8 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x8)->set_Item(13, 0f);
		Matrix4x4 matrix4x9 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x9)->set_Item(2, 0f);
		Matrix4x4 matrix4x10 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x10)->set_Item(6, 0f);
		Matrix4x4 matrix4x11 = (Matrix4x4)(obj - -64);
		float num9 = far + near;
		float num10 = 0f - num9;
		float num11 = far - near;
		float value5 = num10 / num11;
		((Matrix4x4*)matrix4x11)->set_Item(10, value5);
		Matrix4x4 matrix4x12 = (Matrix4x4)(obj - -64);
		float num12 = far + far;
		float num13 = num12 * near;
		float num14 = 0f - num13;
		float num15 = far - near;
		float value6 = num14 / num15;
		((Matrix4x4*)matrix4x12)->set_Item(14, value6);
		Matrix4x4 matrix4x13 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x13)->set_Item(3, 0f);
		Matrix4x4 matrix4x14 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x14)->set_Item(7, 0f);
		Matrix4x4 matrix4x15 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x15)->set_Item(11, -1f);
		Matrix4x4 matrix4x16 = (Matrix4x4)(obj - -64);
		((Matrix4x4*)matrix4x16)->set_Item(15, 0f);
		object obj5 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		Matrix4x4 result = default;
		return result;
	}

	public TakeScreenshot()
	{
		List<Camera> list = default;
		list._002Ector();
		uiCameras = list;
		uiCamerasEnabled = true;
		base._002Ector();
	}
}
