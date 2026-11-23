using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Extensions;

public static class UIExtensions
{
	public static void RepositionImmediately(UIGrid uiGrid)
	{
		uiGrid.SendMessage("Start", SendMessageOptions.DontRequireReceiver);
	}

	public unsafe static void DrawBounds(Bounds b, Color col)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01df: Expected Obj, but got I
		//IL_01fc: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected VT, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected VT, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected VT, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected VT, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected VT, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected VT, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected VT, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected VT, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected VT, but got Unknown
		//IL_0133: Expected native int or pointer, but got VT
		//IL_0145: Expected native int or pointer, but got VT
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected VT, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected VT, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 336);
		_ = b.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+8]");
		_ = 0;
		_ = b.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+8]");
		_ = 0;
		_ = b.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+140]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+140]");
		object obj2 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+144]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+144]");
		object obj3 = num2 - 0;
		_ = b.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+8]");
		_ = 0;
		_ = b.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+140]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+140]");
		object obj4 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+144]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+144]");
		object obj5 = num4 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+138]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+130]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+120]");
		_ = 0;
		_ = col.b;
		_ = col.r;
		Vector3 start = (Vector3)(color + 176);
		Vector3 end = (Vector3)(color + 160);
		Color color2 = color + 144;
		Debug.DrawLine(start, end, color2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+100]");
		_ = 0;
		_ = col.b;
		_ = col.r;
		Vector3 start2 = (Vector3)(color + 128);
		Vector3 end2 = (Vector3)(color + 112);
		Color color3 = color + 96;
		Debug.DrawLine(start2, end2, color3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
		_ = 0;
		_ = col.b;
		_ = col.r;
		Vector3 start3 = (Vector3)(color + 80);
		Vector3 end3 = (Vector3)(color - -64);
		Color color4 = color + 48;
		Debug.DrawLine(start3, end3, color4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
		_ = 0;
		((Color*)(nint)color)->b = col.b;
		((Color*)(nint)color)->r = col.r;
		Vector3 start4 = (Vector3)(color + 32);
		Vector3 end4 = (Vector3)(color + 16);
		Debug.DrawLine(start4, end4, color);
	}

	public unsafe static Vector4 GetEndPositions(Transform transform, Renderer[] renderers = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0327: Expected Obj, but got I4
		//IL_020f: Expected native int or pointer, but got VT
		//IL_021c: Expected native int or pointer, but got VT
		//IL_0229: Expected native int or pointer, but got VT
		//IL_0236: Expected native int or pointer, but got VT
		//IL_006f: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I
		//IL_00bf: Expected Obj, but got I
		//IL_00eb: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_018d: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		Renderer[] array = default;
		if (array == null)
		{
			GameObject gameObject = transform.gameObject;
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S3_v10 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		}
		float num3 = float.MaxValue;
		float num4 = float.MaxValue;
		float num5 = float.MinValue;
		float num6 = float.MinValue;
		object obj3 = 0;
		Renderer[] array2 = default;
		while (array2.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)array2 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v15+10]");
			Bounds bounds = ((Renderer)0).bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			_ = 0;
			float num7 = (float)obj + (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			_ = 0;
			float num8 = (float)obj - (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num9 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num10 = num9 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			_ = 0;
			if (!(num7 > num6))
			{
				num7 = num6;
			}
			if (!(num4 > num8))
			{
				num8 = num4;
			}
			if (!(num5 < num10))
			{
				num10 = num5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num11 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			float num12 = num11 - 0f;
			if (!(num12 < num3))
			{
				num12 = num3;
			}
			object obj6 = obj3 + 1;
			num3 = num12;
			num4 = num8;
			num5 = num10;
			num6 = num7;
			obj3 = obj6;
		}
		Vector4 vector = default;
		((Vector4*)(nint)vector)->w = num5;
		((Vector4*)(nint)vector)->z = num6;
		((Vector4*)(nint)vector)->y = num3;
		((Vector4*)(nint)vector)->x = num4;
		return vector;
	}

	public unsafe static void PositionOnWidget(Transform t, UIWidget w, Camera modelCamera = null, Camera widgetCamera = null, UIWidget.Pivot pivot = UIWidget.Pivot.Center)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_047b: Expected I, but got Obj
		//IL_0493: Expected I, but got Obj
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_04b3: Expected I, but got Obj
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_03d7: Expected Obj, but got I
		//IL_03e7: Expected VT, but got I
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected VT, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected VT, but got Unknown
		//IL_0366: Expected F4, but got I
		//IL_0361: Expected native int or pointer, but got VT
		//IL_0388: Expected F4, but got I
		//IL_0383: Expected native int or pointer, but got VT
		//IL_010b: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		nint num3 = (nint)w;
		object obj2 = w + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S1_v5 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
		nint num4 = (nint)w;
		object obj3 = w + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v5 (Il2CppClass<UIWidget>)+124] (should have been resolved before IL gen)");
		object obj4;
		Vector3 zeroVector;
		if (pivot != UIWidget.Pivot.TopLeft)
		{
			if (pivot != UIWidget.Pivot.Top)
			{
				if (pivot != UIWidget.Pivot.TopRight)
				{
					if (pivot != UIWidget.Pivot.Left)
					{
						if (pivot != UIWidget.Pivot.Center)
						{
							if (pivot != UIWidget.Pivot.Right)
							{
								if (pivot != UIWidget.Pivot.BottomLeft)
								{
									if (pivot != UIWidget.Pivot.Bottom)
									{
										if (pivot != UIWidget.Pivot.BottomRight)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
											obj4 = 0;
											zeroVector = Vector3.zeroVector;
											goto IL_03a0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+3C]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+34]");
										_ = 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20+3C]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20+34]");
										_ = 0;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+24]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+1C]");
									_ = 0;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20+30]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20+28]");
								_ = 0;
							}
						}
						else
						{
							Vector3 worldCenter = w.worldCenter;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20+10]");
						_ = 0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+28]");
					_ = 0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20+24]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v20+1C]");
				_ = 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+24]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18+1C]");
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		zeroVector = (Vector3)0;
		goto IL_03a0;
		IL_03a0:
		Camera camera = default;
		Camera camera2 = default;
		if (camera == null)
		{
			GameObject gameObject = w.gameObject;
			int layer = gameObject.layer;
			camera2 = NGUITools.FindCameraForLayer(layer);
		}
		Camera camera3 = default;
		Camera camera4 = default;
		if (camera3 == null)
		{
			GameObject gameObject2 = t.gameObject;
			int layer2 = gameObject2.layer;
			camera4 = NGUITools.FindCameraForLayer(layer2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Vector3 position = vector + 32;
		Vector3 vector2 = camera2.WorldToScreenPoint(position);
		Transform transform = camera2.transform;
		Vector3 position2 = transform.position;
		Transform transform2 = camera4.transform;
		Vector3 position3 = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		float num5 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		float value = num5 - 0f;
		Vector3 position4 = t.position;
		float num6 = Math.Abs(value);
		float num7 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		float num8 = num7 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector3 position5 = vector + 16;
		Vector3 vector3 = camera4.ScreenToWorldPoint(position5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		((Vector3*)(nint)vector)->x = 0f;
		t.position = vector;
	}

	public unsafe static void SimpleFitToWidget(Transform transform, UIWidget widget, bool fitHorizontal = true)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_07fa: Expected I, but got Obj
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected VT, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected VT, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_08c0: Expected Obj, but got I4
		//IL_022f: Expected I, but got Obj
		//IL_028f: Expected I, but got Obj
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_02b7: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_025a: Expected I, but got Obj
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0160: Expected Obj, but got I
		//IL_0179: Expected F4, but got I
		//IL_0174: Expected native int or pointer, but got VT
		//IL_018e: Expected F4, but got I
		//IL_0189: Expected native int or pointer, but got VT
		//IL_01ac: Invalid comparison between F4 and Obj
		//IL_01e0: Invalid comparison between Obj and F4
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected VT, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected Obj, but got Unknown
		//IL_01d3: Expected F4, but got Obj
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected VT, but got Unknown
		//IL_0207: Expected F4, but got Obj
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected VT, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected VT, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected VT, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c3: Expected VT, but got Unknown
		//IL_06e4: Expected Obj, but got I
		//IL_06f4: Expected Obj, but got I
		//IL_0704: Expected Obj, but got I
		//IL_0714: Expected Obj, but got I
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected VT, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Expected VT, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected VT, but got Unknown
		//IL_0516: Expected Obj, but got I
		//IL_0526: Expected Obj, but got I
		//IL_0536: Expected Obj, but got I
		//IL_0546: Expected Obj, but got I
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected VT, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 480);
		_ = 0;
		_ = 0;
		GameObject gameObject = transform.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		Transform transform2 = widget.transform;
		Vector3 position = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1C0]");
		_ = 0;
		Vector3 position2 = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
		_ = 0;
		Transform cachedTransform = widget.cachedTransform;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v29 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v30 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+198]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+190]");
		_ = 0;
		Vector3 position3 = vector + 208;
		cachedTransform.position = position3;
		Vector3 position4 = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+188]");
		_ = 0;
		_ = 0;
		_ = 0;
		Vector3 position5 = vector + 192;
		transform.position = position5;
		object obj2 = vector + 368;
		object obj3 = vector + 368;
		object obj4 = obj3 | 4;
		if (!fitHorizontal)
		{
			obj2 = obj4;
		}
		float num5 = float.MinValue;
		float num6 = float.MaxValue;
		object obj5 = 0;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v11+C]");
			if (0 <= (nint)obj5)
			{
				break;
			}
			object obj6 = obj5 << 2;
			object obj7 = obj8 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v205+10]");
			Mesh mesh = ((MeshFilter)0).mesh;
			Vector3[] vertices = mesh.vertices;
			object obj9 = 0;
			while (vertices.Length > (nint)obj9)
			{
				object obj10 = obj9 * 12;
				object obj11 = (object)vertices + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v209+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v209+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v205+10]");
				Transform transform3 = ((Component)0).transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1B8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1B0]");
				((Vector3*)(nint)vector)->x = 0f;
				position4 = transform3.TransformPoint(vector);
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
				{
					num6 = (float)obj2;
				}
				else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num5))
				{
					num5 = (float)obj2;
				}
				object obj12 = obj9 + 1;
				obj9 = obj12;
			}
			object obj13 = obj5 + 1;
			obj5 = obj13;
		}
		nint num7 = (nint)widget;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ S1_v48 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
		if (fitHorizontal)
		{
			nint num8 = (nint)widget;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ S1_v198 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
			object obj15 = default;
			object obj14 = obj15 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v53+10]");
			object obj16 = 0;
		}
		else
		{
			nint num9 = (nint)widget;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v216 @ S1_v194 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
			object obj17 = default;
			object obj14 = obj17 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v53+14]");
			object obj16 = 0;
		}
		GameObject cachedGameObject = widget.cachedGameObject;
		int layer = cachedGameObject.layer;
		Camera camera = NGUITools.FindCameraForLayer(layer);
		GameObject gameObject2 = transform.gameObject;
		int layer2 = gameObject2.layer;
		Camera camera2 = NGUITools.FindCameraForLayer(layer2);
		Vector3 position6 = transform.position;
		Transform transform4 = camera2.transform;
		Vector3 position7 = transform4.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A8]");
		float num10 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A8]");
		float value = num10 - 0f;
		float num11 = Math.Abs(value);
		Transform cachedTransform2 = widget.cachedTransform;
		object obj18;
		object obj19;
		object obj20;
		object obj21;
		if (fitHorizontal)
		{
			Vector3 position8 = cachedTransform2.position;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+160]");
			_ = 0;
			Vector3 position9 = vector + 112;
			Vector3 vector2 = camera.WorldToScreenPoint(position9);
			Transform cachedTransform3 = widget.cachedTransform;
			Vector3 position10 = cachedTransform3.position;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+150]");
			_ = 0;
			Vector3 position11 = vector + 96;
			Vector3 vector3 = camera.WorldToScreenPoint(position11);
			Vector3 position12 = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+148]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+140]");
			_ = 0;
			Vector3 position13 = vector + 80;
			Vector3 vector4 = camera2.WorldToScreenPoint(position13);
			Vector3 position14 = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+138]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+130]");
			_ = 0;
			Vector3 position15 = vector - -64;
			Vector3 vector5 = camera2.WorldToScreenPoint(position15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
			obj21 = 0;
		}
		else
		{
			Vector3 position16 = cachedTransform2.position;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+120]");
			_ = 0;
			Vector3 position17 = vector + 176;
			Vector3 vector6 = camera.WorldToScreenPoint(position17);
			Transform cachedTransform4 = widget.cachedTransform;
			Vector3 position18 = cachedTransform4.position;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+110]");
			_ = 0;
			Vector3 position19 = vector + 160;
			Vector3 vector7 = camera.WorldToScreenPoint(position19);
			Vector3 position20 = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+108]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+100]");
			_ = 0;
			Vector3 position21 = vector + 144;
			Vector3 vector8 = camera2.WorldToScreenPoint(position21);
			Vector3 position22 = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+F0]");
			_ = 0;
			Vector3 position23 = vector + 128;
			Vector3 vector9 = camera2.WorldToScreenPoint(position23);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A4]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A4]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A4]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A4]");
			obj21 = 0;
		}
		Vector3 localScale = transform.localScale;
		object obj22 = obj19 - obj20;
		object obj23 = obj21 - obj18;
		float value2 = (float)obj22 / (float)obj23;
		float num12 = Math.Abs(value2);
		float num13 = num12 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A0]");
		float num14 = 0f * num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A4]");
		float num15 = 0f * num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1A8]");
		float num16 = 0f * num13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+E0]");
		_ = 0;
		Vector3 localScale2 = vector + 48;
		transform.localScale = localScale2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1C0]");
		_ = 0;
		Vector3 position24 = vector + 32;
		transform.position = position24;
		Transform cachedTransform5 = widget.cachedTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+1D0]");
		_ = 0;
		Vector3 position25 = vector + 16;
		cachedTransform5.position = position25;
	}

	public unsafe static Bounds CalculateMeshBounds(Transform t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_156a: Unknown result type (might be due to invalid IL or missing references)
		//IL_156f: Expected Obj, but got Unknown
		//IL_1578: Expected Obj, but got I4
		//IL_1581: Unknown result type (might be due to invalid IL or missing references)
		//IL_1586: Expected Obj, but got Unknown
		//IL_158f: Expected Obj, but got I4
		//IL_159e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a3: Expected Obj, but got Unknown
		//IL_15ac: Expected Obj, but got I4
		//IL_15bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c0: Expected Obj, but got Unknown
		//IL_15c9: Expected Obj, but got I4
		//IL_15d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15dd: Expected Obj, but got Unknown
		//IL_15e6: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got F4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected VT, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected VT, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected Obj, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected VT, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected Obj, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_0792: Expected Obj, but got I
		//IL_07af: Expected Obj, but got I
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected Obj, but got Unknown
		//IL_07da: Expected Obj, but got I
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected VT, but got Unknown
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected VT, but got Unknown
		//IL_015b: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_085f: Expected Obj, but got I
		//IL_087c: Expected Obj, but got I
		//IL_0899: Expected Obj, but got I
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected Obj, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected Obj, but got Unknown
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected Obj, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_0950: Expected Obj, but got F4
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected VT, but got Unknown
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Expected VT, but got Unknown
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected Obj, but got Unknown
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Expected Obj, but got Unknown
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected Obj, but got Unknown
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected Obj, but got Unknown
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected Obj, but got Unknown
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected VT, but got Unknown
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected VT, but got Unknown
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Expected Obj, but got Unknown
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected VT, but got Unknown
		//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected VT, but got Unknown
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected Obj, but got Unknown
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected Obj, but got Unknown
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Expected Obj, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected Obj, but got Unknown
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Expected VT, but got Unknown
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Expected VT, but got Unknown
		//IL_01a9: Expected Obj, but got I
		//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Expected Obj, but got Unknown
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected Obj, but got Unknown
		//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Expected Obj, but got Unknown
		//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db0: Expected Obj, but got Unknown
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Expected VT, but got Unknown
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Expected VT, but got Unknown
		//IL_0e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Expected Obj, but got Unknown
		//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eac: Expected Obj, but got Unknown
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec1: Expected Obj, but got Unknown
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee1: Expected Obj, but got Unknown
		//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f94: Expected VT, but got Unknown
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Expected VT, but got Unknown
		//IL_01dd: Expected Obj, but got I
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcd: Expected Obj, but got Unknown
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Expected Obj, but got Unknown
		//IL_0ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Expected Obj, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Expected Obj, but got Unknown
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ca: Expected VT, but got Unknown
		//IL_10d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d8: Expected VT, but got Unknown
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fe: Expected Obj, but got Unknown
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1113: Expected Obj, but got Unknown
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_1128: Expected Obj, but got Unknown
		//IL_1143: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Expected Obj, but got Unknown
		//IL_11f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fb: Expected VT, but got Unknown
		//IL_1204: Unknown result type (might be due to invalid IL or missing references)
		//IL_1209: Expected VT, but got Unknown
		//IL_122f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1234: Expected Obj, but got Unknown
		//IL_1244: Unknown result type (might be due to invalid IL or missing references)
		//IL_1249: Expected Obj, but got Unknown
		//IL_1259: Unknown result type (might be due to invalid IL or missing references)
		//IL_125e: Expected Obj, but got Unknown
		//IL_1796: Expected I, but got Obj
		//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1803: Expected VT, but got Unknown
		//IL_180c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1811: Expected VT, but got Unknown
		//IL_181a: Unknown result type (might be due to invalid IL or missing references)
		//IL_181f: Expected VT, but got Unknown
		//IL_182b: Expected native int or pointer, but got VT
		//IL_1839: Expected Obj, but got I4
		//IL_162b: Expected I, but got Obj
		//IL_164b: Expected Obj, but got I
		//IL_1536: Expected VT, but got I
		//IL_1531: Expected native int or pointer, but got VT
		//IL_153f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1544: Expected Obj, but got Unknown
		//IL_1552: Unknown result type (might be due to invalid IL or missing references)
		//IL_1557: Expected Obj, but got Unknown
		//IL_187b: Expected I, but got Obj
		//IL_189b: Expected Obj, but got I
		//IL_18aa: Expected Obj, but got I4
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1493: Expected Obj, but got Unknown
		//IL_149c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a1: Expected Obj, but got Unknown
		//IL_14cb: Expected Obj, but got I
		//IL_14e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14eb: Expected VT, but got Unknown
		//IL_14f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f9: Expected VT, but got Unknown
		//IL_1506: Expected Ref, but got VT
		//IL_150f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1514: Expected Obj, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected VT, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected VT, but got Unknown
		//IL_0674: Expected Ref, but got VT
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected VT, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected VT, but got Unknown
		//IL_06af: Expected Ref, but got VT
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_0470: Expected Obj, but got I
		//IL_048d: Expected Obj, but got I
		//IL_04aa: Expected Obj, but got I
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04d5: Expected Obj, but got I
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected VT, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected VT, but got Unknown
		//IL_0555: Expected Obj, but got I
		//IL_0572: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_02b9: Expected Obj, but got I
		//IL_02d6: Expected Obj, but got I
		//IL_02f3: Expected Obj, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_031e: Expected Obj, but got I
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected VT, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected VT, but got Unknown
		//IL_03af: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I
		//IL_03e9: Expected Obj, but got I
		//IL_05cb: Expected Obj, but got I
		//IL_1664: Expected I, but got Obj
		//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a7: Expected VT, but got Unknown
		//IL_16b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b5: Expected VT, but got Unknown
		//IL_16be: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c3: Expected VT, but got Unknown
		//IL_16cf: Expected native int or pointer, but got VT
		//IL_05e0: Expected Obj, but got I
		//IL_16eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f0: Expected Obj, but got Unknown
		//IL_05f5: Expected Obj, but got I
		//IL_060a: Expected Obj, but got I
		//IL_061f: Expected Obj, but got I
		//IL_0634: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 1232;
		object obj3 = obj + 1192;
		obj3 = 0;
		object obj4 = obj + 1184;
		obj4 = 0;
		_ = 0;
		object obj5 = obj + 1168;
		obj5 = 0;
		_ = 0;
		object obj6 = obj + 1152;
		obj6 = 0;
		_ = 0;
		object obj7 = obj + 1136;
		obj7 = 0;
		_ = 0;
		GameObject gameObject = t.gameObject;
		MeshFilter[] componentsInChildren = gameObject.GetComponentsInChildren<MeshFilter>(includeInactive: true);
		Quaternion rotation = t.rotation;
		object obj8 = obj + 1208;
		object obj9 = obj + 1224;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
		_ = 0;
		object obj10 = obj + 1056;
		obj10 = 0f;
		_ = 0f;
		_ = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+418]");
		_ = 0;
		Vector3 euler = (Vector3)(obj + 632);
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
		object obj11 = obj + 1120;
		obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
		_ = 0;
		Quaternion rotation2 = (Quaternion)(obj + 616);
		t.rotation = rotation2;
		object obj12 = obj + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		object obj13 = default;
		object obj47 = default;
		while (componentsInChildren.Length > (nint)obj13)
		{
			object obj14 = obj13 << 2;
			object obj15 = (object)componentsInChildren + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v392+10]");
			Mesh mesh = ((MeshFilter)0).mesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v392+10]");
			GameObject gameObject2 = ((Component)0).gameObject;
			Transform transform = gameObject2.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v392+10]");
			GameObject gameObject3 = ((Component)0).gameObject;
			Transform transform2 = gameObject3.transform;
			Vector3 lossyScale = transform2.lossyScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v392+10]");
			GameObject gameObject4 = ((Component)0).gameObject;
			Transform transform3 = gameObject4.transform;
			Quaternion rotation3 = transform3.rotation;
			obj5 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
			_ = 0;
			int vertexCount = mesh.vertexCount;
			Vector3[] vertices = mesh.vertices;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v978 @ S1_v524 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ S1_v525 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj6 = 0;
			_ = Vector3.zeroVector;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1147 @ S1_v531 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ S1_v532 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj7 = 0;
			_ = Vector3.zeroVector;
			object obj16 = 0;
			while ((nint)obj16 < vertexCount)
			{
				object obj17 = obj16 | obj13;
				if (obj17 == null)
				{
					object obj18 = obj + 1216;
					object obj19 = obj16 * 12;
					object obj20 = (object)vertices + obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ S1_v611+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ S1_v611+10]");
					obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
					object obj21 = num5 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C4]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C4]");
					object obj22 = num6 * 0;
					object obj23 = obj + 1104;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C8]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C8]");
					object obj24 = num7 * 0;
					obj23 = obj24;
					object obj25 = obj - -64;
					obj25 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+488]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+448]");
					_ = 0;
					Quaternion quaternion2 = (Quaternion)(obj + 56);
					Vector3 vector = (Vector3)(obj + 40);
					Vector3 vector2 = quaternion2 * vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+418]");
					object obj26 = num8 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C4]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+41C]");
					object obj27 = num9 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C8]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+420]");
					object obj28 = num10 + 0;
					obj6 = obj28;
					obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+478]");
					_ = 0;
					nint num11 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ S0_v512 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+478]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1498 @ S0_v513 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
					_ = 0;
					_ = Vector3.zeroVector;
					Bounds bounds = (Bounds)(obj + 1176);
					Vector3 center = (Vector3)(obj + 24);
					Vector3 size = (Vector3)(obj + 8);
					*(Bounds*)(nint)bounds = new Bounds(center, size);
					bool flag = false;
				}
				else
				{
					obj9 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+488]");
					_ = 0;
					object obj29 = obj + 1048;
					object obj30 = obj16 * 12;
					object obj31 = (object)vertices + obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1334 @ S1_v562+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1334 @ S1_v562+10]");
					obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+418]");
					object obj32 = num13 * 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C4]");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+41C]");
					object obj33 = num14 * 0;
					object obj34 = obj + 1088;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C8]");
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+420]");
					object obj35 = num15 * 0;
					obj34 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+438]");
					_ = 0;
					Quaternion quaternion3 = (Quaternion)(obj + 88);
					Vector3 vector3 = (Vector3)(obj + 72);
					Vector3 vector4 = quaternion3 * vector3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C4]");
					nint num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3FC]");
					object obj36 = num16 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C8]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+400]");
					object obj37 = num17 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
					nint num18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3F8]");
					object obj38 = num18 + 0;
					object obj39 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+478]");
					bool flag2 = (nint)obj39 < 0;
					object obj40 = obj38;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+478]");
						obj40 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+47C]");
					bool flag3 = (nint)obj36 < 0;
					object obj41 = obj36;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+47C]");
						obj41 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+480]");
					bool flag4 = (nint)obj37 < 0;
					object obj42 = obj37;
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+480]");
						obj42 = 0;
					}
					object obj43 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+468]");
					if ((nint)obj43 <= 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+468]");
						obj38 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+46C]");
					bool flag5 = (nint)obj36 > 0;
					object obj44 = obj36;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+46C]");
						obj44 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+470]");
					bool flag = 0 < (nint)obj37;
					object obj45 = obj37;
					if (!flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+470]");
						obj45 = 0;
					}
				}
				object obj46 = obj16 + 1;
				obj16 = obj46;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+478]");
			_ = 0;
			Bounds bounds2 = (Bounds)(obj + 1176);
			Vector3 point = (Vector3)(obj + 120);
			((Bounds*)bounds2)->Encapsulate(point);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+468]");
			_ = 0;
			Bounds bounds3 = (Bounds)(obj + 1176);
			Vector3 point2 = (Vector3)(obj + 104);
			((Bounds*)bounds3)->Encapsulate(point2);
			obj13 = obj47 + 1;
		}
		object obj48 = obj + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		Quaternion rotation4 = (Quaternion)(obj + 600);
		t.rotation = rotation4;
		Vector3 position2 = t.position;
		object obj49 = obj + 1224;
		obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		object obj50 = obj + 1048;
		object obj51 = obj + 1176;
		obj50 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v67+8]");
		_ = 0;
		Vector3 position3 = t.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+418]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+418]");
		object obj52 = num19 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+41C]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+41C]");
		object obj53 = num20 - 0;
		object obj54 = obj + 1072;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+420]");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+420]");
		object obj55 = num21 - 0;
		obj54 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+428]");
		_ = 0;
		Quaternion quaternion4 = (Quaternion)(obj + 584);
		Vector3 vector5 = (Vector3)(obj + 568);
		Vector3 vector6 = quaternion4 * vector5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+418]");
		object obj56 = num22 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C4]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+41C]");
		object obj57 = num23 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C8]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+420]");
		object obj58 = num24 + 0;
		object obj59 = obj + 1056;
		obj59 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		object obj60 = obj + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v105+C]");
		_ = 0;
		object obj61 = obj + 1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S1_v105+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3F8]");
		float num25 = 0f * 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3FC]");
		float num26 = 0f * 1f;
		object obj62 = obj + 1040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+400]");
		float num27 = 0f * 1f;
		obj62 = num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+418]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+408]");
		_ = 0;
		Quaternion quaternion5 = (Quaternion)(obj + 552);
		Vector3 vector7 = (Vector3)(obj + 536);
		Vector3 vector8 = quaternion5 * vector7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3F8]");
		object obj63 = obj56 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3FC]");
		object obj64 = obj57 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+400]");
		object obj65 = obj58 + 0;
		object obj66 = obj + 1024;
		obj66 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		object obj67 = obj + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S1_v141+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S1_v141+14]");
		_ = 0;
		float num28 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3D8]");
		float num29 = num28 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3DC]");
		float num30 = 0f * 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3E0]");
		float num31 = 0f * 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3E8]");
		_ = 0;
		Quaternion quaternion6 = (Quaternion)(obj + 520);
		Vector3 vector9 = (Vector3)(obj + 504);
		Vector3 vector10 = quaternion6 * vector9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3D8]");
		object obj68 = obj56 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3DC]");
		object obj69 = obj57 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3E0]");
		object obj70 = obj58 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		object obj71 = obj + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S1_v175+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S1_v175+14]");
		_ = 0;
		float num32 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3B8]");
		float num33 = num32 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3BC]");
		float num34 = 0f * 1f;
		float num35 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C0]");
		float num36 = num35 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C8]");
		_ = 0;
		Quaternion quaternion7 = (Quaternion)(obj + 488);
		Vector3 vector11 = (Vector3)(obj + 472);
		Vector3 vector12 = quaternion7 * vector11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3B8]");
		object obj72 = obj56 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3BC]");
		object obj73 = obj57 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C0]");
		object obj74 = obj58 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		object obj75 = obj + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S1_v208+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S1_v208+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+398]");
		float num37 = 0f * 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+39C]");
		float num38 = 0f * 1f;
		float num39 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3A0]");
		float num40 = num39 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3A8]");
		_ = 0;
		Quaternion quaternion8 = (Quaternion)(obj + 456);
		Vector3 vector13 = (Vector3)(obj + 440);
		Vector3 vector14 = quaternion8 * vector13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+398]");
		object obj76 = obj56 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+39C]");
		object obj77 = obj57 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3A0]");
		object obj78 = obj58 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		object obj79 = obj + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ S1_v240+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ S1_v240+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+378]");
		float num41 = 0f * 1f;
		float num42 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+37C]");
		float num43 = num42 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+380]");
		float num44 = 0f * 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+390]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+398]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+388]");
		_ = 0;
		Quaternion quaternion9 = (Quaternion)(obj + 424);
		Vector3 vector15 = (Vector3)(obj + 408);
		Vector3 vector16 = quaternion9 * vector15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+378]");
		object obj80 = obj56 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+37C]");
		object obj81 = obj57 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+380]");
		object obj82 = obj58 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		object obj83 = obj + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ S1_v274+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ S1_v274+14]");
		_ = 0;
		float num45 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		float num46 = num45 - 0f;
		float num47 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+35C]");
		float num48 = num47 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+360]");
		float num49 = 0f * 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+380]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+370]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+378]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+368]");
		_ = 0;
		Quaternion quaternion10 = (Quaternion)(obj + 392);
		Vector3 vector17 = (Vector3)(obj + 376);
		Vector3 vector18 = quaternion10 * vector17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		object obj84 = obj56 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+35C]");
		object obj85 = obj57 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+360]");
		object obj86 = obj58 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		object obj87 = obj + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ S1_v309+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ S1_v309+14]");
		_ = 0;
		float num50 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+338]");
		float num51 = num50 - 0f;
		float num52 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+33C]");
		float num53 = num52 - 0f;
		float num54 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+340]");
		float num55 = num54 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+360]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+350]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+358]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+348]");
		_ = 0;
		Quaternion quaternion11 = (Quaternion)(obj + 360);
		Vector3 vector19 = (Vector3)(obj + 344);
		Vector3 vector20 = quaternion11 * vector19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+338]");
		object obj88 = obj56 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+33C]");
		object obj89 = obj57 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+340]");
		object obj90 = obj58 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4B0]");
		_ = 0;
		object obj91 = obj + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S1_v343+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S1_v343+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+328]");
		float num56 = 0f * 1f;
		float num57 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+32C]");
		float num58 = num57 - 0f;
		float num59 = -0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+330]");
		float num60 = num59 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+340]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+320]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+338]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+318]");
		_ = 0;
		Quaternion quaternion12 = (Quaternion)(obj + 328);
		Vector3 vector21 = (Vector3)(obj + 312);
		Vector3 vector22 = quaternion12 * vector21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+328]");
		object obj92 = obj56 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+32C]");
		object obj93 = obj57 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+330]");
		object obj94 = obj58 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+310]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+308]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+130]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+300]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2B8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2B0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+298]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
		_ = 0;
		nint num61 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ S0_v354 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ S0_v355 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ S0_v355 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+290]");
		_ = 0;
		_ = Vector3.zeroVector;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+288]");
		_ = 0;
		Bounds bounds4 = (Bounds)(obj + 1176);
		Vector3 center2 = (Vector3)(obj + 168);
		Vector3 size2 = (Vector3)(obj + 152);
		*(Bounds*)(nint)bounds4 = new Bounds(center2, size2);
		object obj95 = 0;
		object obj99 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ S0_v292+C]");
			if (0 <= (nint)obj95)
			{
				break;
			}
			object obj96 = obj + 1216;
			object obj97 = obj95 * 12;
			object obj98 = obj99 + obj97;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1403 @ S1_v488+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1403 @ S1_v488+10]");
			obj96 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C0]");
			_ = 0;
			Bounds bounds5 = (Bounds)(obj + 1176);
			Vector3 point3 = (Vector3)(obj + 136);
			((Bounds*)bounds5)->Encapsulate(point3);
			object obj100 = obj95 + 1;
			obj95 = obj100;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+498]");
		Bounds bounds6 = default;
		((Bounds*)(nint)bounds6)->m_Center = (Vector3)0;
		object obj101 = obj + 1192;
		object obj102 = obj + 1184;
		return bounds6;
	}

	public unsafe static void CenterAlignOnZero(UIGrid grid)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_010f: Expected F4, but got I
		//IL_010a: Expected native int or pointer, but got VT
		//IL_0139: Expected F4, but got I
		//IL_0134: Expected native int or pointer, but got VT
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		int num = default;
		object obj2 = default;
		object obj3 = default;
		int num2 = default;
		while (true)
		{
			Transform transform = grid.transform;
			int childCount = transform.childCount;
			if (childCount <= num)
			{
				break;
			}
			Transform transform2 = grid.transform;
			Transform child = transform2.GetChild(num);
			GameObject gameObject = child.gameObject;
			if (gameObject.activeSelf || !grid.hideInactive)
			{
				obj2 = obj3 + 1;
			}
			num = num2 + 1;
		}
		object obj4 = obj2 - 1;
		float num3 = (float)obj4 * grid.cellWidth;
		Transform transform3 = grid.transform;
		Vector3 localPosition = transform3.localPosition;
		Transform transform4 = grid.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		float num4 = num3 * -0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform4.localPosition = vector;
	}

	public unsafe static void CenterAlignOnZero(UITable table)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_0250: Expected F4, but got I
		//IL_024b: Expected native int or pointer, but got VT
		//IL_027f: Expected F4, but got I
		//IL_027a: Expected native int or pointer, but got VT
		//IL_0095: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		object obj2 = vector - -64;
		obj2 = 0;
		_ = 0;
		int num = default;
		object obj4 = default;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		int num4 = default;
		while (true)
		{
			Transform transform = table.transform;
			int childCount = transform.childCount;
			if (childCount <= num)
			{
				break;
			}
			Transform transform2 = table.transform;
			Transform child = transform2.GetChild(num);
			bool considerInactive = (byte)(~(table.hideInactive ? 1u : 0u)) != 0;
			Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(child, considerInactive);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			GameObject gameObject = child.gameObject;
			if (gameObject.activeSelf || !table.hideInactive)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				object obj3 = num2 + 0;
				obj4 += obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				object obj5 = num3 + 0;
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6);
				obj6 = obj6;
				if (!flag)
				{
					obj6 = obj5;
				}
				obj7 = obj8 + 1;
			}
			num = num4 + 1;
		}
		object obj9 = obj7 - 1;
		object obj10 = obj9 * table.padding;
		object obj11 = obj10 + obj10;
		object obj12 = obj4 + obj11;
		Transform transform3 = table.transform;
		Vector3 localPosition = transform3.localPosition;
		float num5 = (float)obj12 * -0.5f;
		float num6 = num5 - (float)table.padding;
		Transform transform4 = table.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		float num7 = (float)obj6 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform4.localPosition = vector;
	}

	public static float CenterChildrenHorizontally(Transform t, float padding)
	{
		int childCount = t.childCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = 0;
		int childCount2 = t.childCount;
		if (childCount2 > num)
		{
			Transform child = t.GetChild(num);
			throw new ArrayTypeMismatchException();
		}
		Transform[] children = default;
		return CenterChildrenHorizontally(children, padding, t);
	}

	public static float CenterChildrenHorizontally(Transform[] children, float padding, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_023d: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected VT, but got Unknown
		//IL_0378: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 144;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		List<int> list = default;
		list._002Ector(children.Length);
		int num = default;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		int num4 = default;
		while (children.Length > num)
		{
			int num2 = num << 2;
			object obj3 = children + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v73+10]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v73+10]");
				Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(parent, (Transform)0, considerInactive: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				obj = 0;
				object obj4 = num * 24;
				object obj5 = obj6 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				object obj7 = num3 + 0;
				obj8 = obj9 + obj7;
				list.Add(num);
			}
			num = num4 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18 (System.Collections.Generic.List`1<System.Int32>)+C]");
		object obj10 = -1;
		float num5 = (float)obj10 * padding;
		float num6 = (float)obj8 + num5;
		float num7 = num6 * -0.5f;
		int num8 = 0;
		while (true)
		{
			int num9 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18 (System.Collections.Generic.List`1<System.Int32>)+C]");
			if ((nint)num9 >= (nint)0)
			{
				break;
			}
			int num10 = list.get_Item(num8);
			int num11 = num10 << 2;
			object obj11 = children + num11;
			object obj12 = num10 * 24;
			object obj13 = obj6 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v28+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v28+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v28+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v38+10]");
			Vector3 localPosition = ((Transform)0).localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			object obj14 = num12 - 0;
			float num13 = num7 + (float)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
			_ = 0;
			float num14 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			float num15 = num14 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Vector3 localPosition2 = (Vector3)(obj + 24);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v38+10]");
			((Transform)0).localPosition = localPosition2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
			_ = 0;
			int num16 = num8 + 1;
			num8 = num16;
		}
		return num6;
	}

	public unsafe static float CenterTransformsHorizontalFixedWidth(Transform[] transforms, float width, float padding)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ce: Expected Obj, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I
		//IL_0191: Expected F4, but got I
		//IL_018c: Expected native int or pointer, but got VT
		//IL_01ab: Expected F4, but got I
		//IL_01a6: Expected native int or pointer, but got VT
		//IL_01c0: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		List<int> list = default;
		list._002Ector(transforms.Length);
		int num = default;
		float num3 = default;
		float num4 = default;
		int num5 = default;
		while (transforms.Length > num)
		{
			int num2 = num << 2;
			object obj2 = transforms + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v42+10]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject.activeSelf)
			{
				list.Add(num);
				num3 = num4 + width;
			}
			num = num5 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (System.Collections.Generic.List`1<System.Int32>)+C]");
		object obj3 = -1;
		float num6 = (float)obj3 * padding;
		float num7 = num3 + num6;
		float num8 = num7 * -0.5f;
		float num9 = width * 0.5f;
		float num10 = num8 + num9;
		int num11 = 0;
		while (true)
		{
			int num12 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (System.Collections.Generic.List`1<System.Int32>)+C]");
			if ((nint)num12 >= (nint)0)
			{
				break;
			}
			int num13 = list.get_Item(num11);
			int num14 = num13 << 2;
			object obj4 = transforms + num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v20+10]");
			Vector3 localPosition = ((Transform)0).localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v20+10]");
			((Transform)0).localPosition = vector;
			int num15 = num11 + 1;
			num11 = num15;
		}
		return num7;
	}

	public static float AlignChildrenHorizontally(Transform t, float padding, bool leftAligned)
	{
		int childCount = t.childCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = 0;
		int childCount2 = t.childCount;
		if (childCount2 > num)
		{
			Transform child = t.GetChild(num);
			throw new ArrayTypeMismatchException();
		}
		Transform[] children = default;
		return AlignChildrenHorizontally(children, padding, t, leftAligned);
	}

	private unsafe static float AlignChildrenHorizontally(Transform[] children, float padding, Transform parent, bool leftAligned)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_00d0: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_01d2: Expected Obj, but got I
		//IL_020d: Expected Obj, but got I
		//IL_026f: Expected F4, but got I
		//IL_026a: Expected native int or pointer, but got VT
		//IL_0289: Expected F4, but got I
		//IL_0284: Expected native int or pointer, but got VT
		//IL_029e: Expected Obj, but got I
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		object obj2 = vector - -64;
		obj2 = 0;
		_ = 0;
		float num = 1f;
		if (!leftAligned)
		{
			num = -1f;
		}
		object obj3 = default;
		object obj6 = default;
		float num3 = default;
		float num5 = default;
		object obj9 = default;
		object obj11 = default;
		while (children.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)children + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v21+10]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v21+10]");
				Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(parent, (Transform)0, considerInactive: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				if (obj6 == null && !leftAligned)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					object obj7 = num2 + 0;
					num3 = (float)obj7 * num;
					float num4 = num5 + num3;
					num5 = num4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v21+10]");
				Vector3 localPosition = ((Transform)0).localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				object obj8 = num6 - 0;
				float num7 = num5 + (float)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
				_ = 0;
				float num8 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				float num9 = num8 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v21+10]");
				((Transform)0).localPosition = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
				_ = 0;
				obj6 = obj9 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				object obj10 = num10 + 0;
				float num11 = (float)obj10 * num;
				float num12 = num5 + num11;
				float num13 = padding * num;
				float num14 = num12 + num13;
				num5 = num14;
			}
			obj3 = obj11 + 1;
		}
		float num15 = num5 - num3;
		float num16 = num5;
		if (!leftAligned)
		{
			num16 = num15;
		}
		float num17 = padding * num;
		float value = num16 - num17;
		return Math.Abs(value);
	}

	public static float CenterChildrenVertically(Transform t, float padding)
	{
		int childCount = t.childCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = 0;
		int childCount2 = t.childCount;
		if (childCount2 > num)
		{
			Transform child = t.GetChild(num);
			throw new ArrayTypeMismatchException();
		}
		Transform[] children = default;
		return CenterChildrenVertically(children, padding, t);
	}

	private static float CenterChildrenVertically(Transform[] children, float padding, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01c7: Expected Obj, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		//IL_023d: Expected Obj, but got I4
		//IL_02a9: Expected Obj, but got I
		//IL_02e9: Expected Obj, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected VT, but got Unknown
		//IL_0385: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_0119: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 144;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		List<int> list = default;
		list._002Ector(children.Length);
		int num = default;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		int num4 = default;
		while (children.Length > num)
		{
			int num2 = num << 2;
			object obj3 = children + num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v76+10]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v76+10]");
				Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(parent, (Transform)0, considerInactive: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				obj = 0;
				object obj4 = num * 24;
				object obj5 = obj6 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+84]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8C]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4C]");
				object obj7 = num3 + 0;
				obj8 = obj9 + obj7;
				list.Add(num);
			}
			num = num4 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18 (System.Collections.Generic.List`1<System.Int32>)+C]");
		object obj10 = -1;
		float num5 = (float)obj10 * padding;
		float num6 = (float)obj8 + num5;
		float num7 = num6 * 0.5f;
		int num8 = 0;
		while (true)
		{
			int num9 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v18 (System.Collections.Generic.List`1<System.Int32>)+C]");
			if ((nint)num9 >= (nint)0)
			{
				break;
			}
			int num10 = list.get_Item(num8);
			int num11 = num10 << 2;
			object obj11 = children + num11;
			object obj12 = num10 * 24;
			object obj13 = obj6 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v28+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v28+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v28+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v38+10]");
			Vector3 localPosition = ((Transform)0).localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			object obj14 = num12 - 0;
			float num13 = num7 - (float)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
			_ = 0;
			float num14 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
			float num15 = num14 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Vector3 localPosition2 = (Vector3)(obj + 24);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v38+10]");
			((Transform)0).localPosition = localPosition2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
			_ = 0;
			int num16 = num8 + 1;
			num8 = num16;
		}
		return num6;
	}

	public static float AlignChildrenVertically(Transform t, float padding, bool downAlign)
	{
		int childCount = t.childCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = 0;
		int childCount2 = t.childCount;
		if (childCount2 > num)
		{
			Transform child = t.GetChild(num);
			throw new ArrayTypeMismatchException();
		}
		Transform[] children = default;
		return AlignChildrenVertically(children, padding, t, downAlign);
	}

	private unsafe static float AlignChildrenVertically(Transform[] children, float padding, Transform parent, bool downAlign)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I
		//IL_0203: Expected Obj, but got I
		//IL_023e: Expected Obj, but got I
		//IL_02a0: Expected F4, but got I
		//IL_029b: Expected native int or pointer, but got VT
		//IL_02c7: Expected F4, but got I
		//IL_02c2: Expected native int or pointer, but got VT
		//IL_02dc: Expected Obj, but got I
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_0321: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_ = 0;
		object obj2 = vector - -64;
		obj2 = 0;
		_ = 0;
		Transform[] array = default;
		if (!downAlign)
		{
			Transform[] source2 = default;
			IEnumerable<_0021_00210> source = (IEnumerable<_0021_00210>)Enumerable.Reverse<TSource>((IEnumerable<TSource>)(object)source2);
			array = Enumerable.ToArray((IEnumerable<Transform>)source);
		}
		float num = 1f;
		if (!downAlign)
		{
			num = -1f;
		}
		object obj3 = default;
		object obj6 = default;
		float num3 = default;
		float num5 = default;
		object obj9 = default;
		object obj11 = default;
		while (array.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)array + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v28+10]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v28+10]");
				Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds(parent, (Transform)0, considerInactive: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				if (obj6 == null && !downAlign)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					object obj7 = num2 + 0;
					num3 = (float)obj7 * num;
					float num4 = num5 - num3;
					num5 = num4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v28+10]");
				Vector3 localPosition = ((Transform)0).localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				object obj8 = num6 - 0;
				float num7 = num5 - (float)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
				_ = 0;
				float num8 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				float num9 = num8 - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				((Vector3*)(nint)vector)->x = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v28+10]");
				((Transform)0).localPosition = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+4C]");
				_ = 0;
				obj6 = obj9 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				object obj10 = num10 + 0;
				float num11 = (float)obj10 * num;
				float num12 = num5 - num11;
				float num13 = padding * num;
				float num14 = num12 - num13;
				num5 = num14;
			}
			obj3 = obj11 + 1;
		}
		float num15 = num5 - num3;
		float num16 = num5;
		if (!downAlign)
		{
			num16 = num15;
		}
		float num17 = padding * num;
		float value = num16 - num17;
		return Math.Abs(value);
	}

	private unsafe static void EncapsulateViewportVertices(Vector3[] vertices, Transform transform, ref Bounds bounds, ref bool init, Camera modelCamera)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected VT, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected VT, but got Unknown
		//IL_0171: Expected native int or pointer, but got VT
		//IL_01b2: Expected F4, but got I
		//IL_01ad: Expected native int or pointer, but got VT
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected VT, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		_ = 0;
		_ = 0;
		object obj2 = default;
		object obj5 = default;
		while (vertices.Length > (nint)obj2)
		{
			object obj3 = obj2 * 12;
			object obj4 = (object)vertices + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v8+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v8+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Vector3 position = vector - -64;
			Vector3 vector2 = transform.TransformPoint(position);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Vector3 position2 = vector + 48;
			Vector3 vector3 = modelCamera.WorldToViewportPoint(position2);
			if (init)
			{
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Vector3 point = vector + 32;
				bounds.Encapsulate(point);
			}
			else
			{
				ref bool reference = ref *(bool*)1;
				_ = 0;
				_ = 0;
				_ = 0;
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				((Vector3*)(nint)vector)->x = 0f;
				Vector3 min = vector + 16;
				bounds.SetMinMax(min, vector);
			}
			obj2 = obj5 + 1;
		}
	}

	public unsafe static Bounds CalculateViewportBounds(Transform t, Camera modelCamera)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I
		//IL_0234: Expected VT, but got I
		//IL_022f: Expected native int or pointer, but got VT
		//IL_015f: Expected Obj, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Ref, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Ref, but got Unknown
		//IL_019f: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Ref, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4]");
		ref bool reference = ref *(bool*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj4 = default;
		object obj7 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v14+C]");
			if (0 <= (nint)obj4)
			{
				break;
			}
			object obj5 = obj4 << 2;
			object obj6 = obj7 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v43+10]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v43+10]");
				Mesh sharedMesh = ((MeshFilter)0).sharedMesh;
				Vector3[] vertices = sharedMesh.vertices;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v43+10]");
				Transform transform = ((Component)0).transform;
				EncapsulateViewportVertices(vertices, transform, ref *(Bounds*)(obj + 8), ref *(bool*)(obj + 7), modelCamera);
			}
			obj4 = obj8 + 1;
		}
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S3_v8 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4]");
		ref bool reference2 = ref *(bool*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S3_v8 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj9 = 0;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v20+C]");
			if (0 <= (nint)obj9)
			{
				break;
			}
			object obj10 = obj9 << 2;
			object obj11 = obj12 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v32+10]");
			GameObject gameObject2 = ((Component)0).gameObject;
			if (gameObject2.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v32+10]");
				Mesh sharedMesh2 = ((SkinnedMeshRenderer)0).sharedMesh;
				Vector3[] vertices2 = sharedMesh2.vertices;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v32+10]");
				Transform transform2 = ((Component)0).transform;
				EncapsulateViewportVertices(vertices2, transform2, ref *(Bounds*)(obj + 8), ref *(bool*)(obj + 7), modelCamera);
			}
			object obj13 = obj9 + 1;
			obj9 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Bounds bounds = default;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		return bounds;
	}

	public unsafe static void CenterInViewport(Transform t, Camera modelCamera, Vector2 offset)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected VT, but got Unknown
		//IL_0101: Expected F4, but got I
		//IL_00fc: Expected native int or pointer, but got VT
		//IL_0123: Expected F4, but got I
		//IL_011e: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		float nearClipPlane = modelCamera.nearClipPlane;
		float farClipPlane = modelCamera.farClipPlane;
		float nearClipPlane2 = modelCamera.nearClipPlane;
		float num = farClipPlane - nearClipPlane2;
		float num2 = num * 0.5f;
		float num3 = nearClipPlane + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		float num4 = offset.y + 0.5f;
		float num5 = offset.x + 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Vector3 position = vector + 16;
		Vector3 vector2 = modelCamera.ViewportToWorldPoint(position);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector)->x = 0f;
		t.position = vector;
	}

	public unsafe static void CenterInViewport(Transform t, Camera modelCamera)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected F4, but got VT
		//IL_001c: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		((Vector2*)(nint)vector)->x = (float)Vector2.zeroVector;
		_ = Vector2.zeroVector;
		CenterInViewport(t, modelCamera, vector);
	}

	private unsafe static void EncapsulateScreenVertices(Vector3[] vertices, Transform transform, ref Bounds bounds, ref bool init, Camera modelCamera)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected VT, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected VT, but got Unknown
		//IL_0171: Expected native int or pointer, but got VT
		//IL_01b2: Expected F4, but got I
		//IL_01ad: Expected native int or pointer, but got VT
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected VT, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		_ = 0;
		_ = 0;
		object obj2 = default;
		object obj5 = default;
		while (vertices.Length > (nint)obj2)
		{
			object obj3 = obj2 * 12;
			object obj4 = (object)vertices + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v8+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v8+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Vector3 position = vector - -64;
			Vector3 vector2 = transform.TransformPoint(position);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Vector3 position2 = vector + 48;
			Vector3 vector3 = modelCamera.WorldToScreenPoint(position2);
			if (init)
			{
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Vector3 point = vector + 32;
				bounds.Encapsulate(point);
			}
			else
			{
				ref bool reference = ref *(bool*)1;
				_ = 0;
				_ = 0;
				_ = 0;
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				((Vector3*)(nint)vector)->x = 0f;
				Vector3 min = vector + 16;
				bounds.SetMinMax(min, vector);
			}
			obj2 = obj5 + 1;
		}
	}

	public unsafe static Bounds CalculateScreenBounds(Transform t, Camera modelCamera)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_012e: Expected Obj, but got I4
		//IL_003f: Expected Obj, but got I
		//IL_0234: Expected VT, but got I
		//IL_022f: Expected native int or pointer, but got VT
		//IL_015f: Expected Obj, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_007f: Expected Obj, but got I
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Ref, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Ref, but got Unknown
		//IL_019f: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Ref, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4]");
		ref bool reference = ref *(bool*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj4 = default;
		object obj7 = default;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v14+C]");
			if (0 <= (nint)obj4)
			{
				break;
			}
			object obj5 = obj4 << 2;
			object obj6 = obj7 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v43+10]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v43+10]");
				Mesh sharedMesh = ((MeshFilter)0).sharedMesh;
				Vector3[] vertices = sharedMesh.vertices;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v43+10]");
				Transform transform = ((Component)0).transform;
				EncapsulateScreenVertices(vertices, transform, ref *(Bounds*)(obj + 8), ref *(bool*)(obj + 7), modelCamera);
			}
			obj4 = obj8 + 1;
		}
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S3_v8 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4]");
		ref bool reference2 = ref *(bool*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S3_v8 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.Component::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj9 = 0;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v20+C]");
			if (0 <= (nint)obj9)
			{
				break;
			}
			object obj10 = obj9 << 2;
			object obj11 = obj12 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v32+10]");
			GameObject gameObject2 = ((Component)0).gameObject;
			if (gameObject2.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v32+10]");
				Mesh sharedMesh2 = ((SkinnedMeshRenderer)0).sharedMesh;
				Vector3[] vertices2 = sharedMesh2.vertices;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v32+10]");
				Transform transform2 = ((Component)0).transform;
				EncapsulateScreenVertices(vertices2, transform2, ref *(Bounds*)(obj + 8), ref *(bool*)(obj + 7), modelCamera);
			}
			object obj13 = obj9 + 1;
			obj9 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		Bounds bounds = default;
		((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		return bounds;
	}

	public unsafe static void FitToWidget(Transform t, UIWidget w, Camera modelCamera = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004a: Expected VT, but got I
		//IL_0045: Expected native int or pointer, but got VT
		object obj = default;
		Bounds bounds = (Bounds)(obj - 48);
		Bounds bounds2 = CalculateMeshBounds(t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Bounds)+18]");
		((Bounds*)(nint)bounds)->m_Center = (Vector3)0;
		FitToWidget(t, w, bounds, modelCamera);
	}

	public unsafe static void FitToWidget(Transform t, UIWidget w, Bounds b, Camera modelCamera = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_028b: Expected Ref, but got VT
		//IL_0298: Expected Ref, but got VT
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected VT, but got Unknown
		//IL_004d: Expected Ref, but got VT
		//IL_005a: Expected Ref, but got VT
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected VT, but got Unknown
		//IL_00f7: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected I4, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected I4, but got Unknown
		//IL_0229: Expected F4, but got I
		//IL_0224: Expected native int or pointer, but got VT
		//IL_0248: Expected F4, but got I
		//IL_0243: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		Camera camera = default;
		Camera camera2 = default;
		if (camera == null)
		{
			GameObject gameObject = t.gameObject;
			int layer = gameObject.layer;
			camera2 = NGUITools.FindCameraForLayer(layer);
		}
		Vector3 min = ((Bounds*)b)->min;
		Vector3 min2 = ((Bounds*)b)->min;
		_ = b.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L2 (UnityEngine.Bounds)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Vector3 position = vector + 32;
		Vector3 vector2 = camera2.WorldToScreenPoint(position);
		Vector3 max = ((Bounds*)b)->max;
		Vector3 max2 = ((Bounds*)b)->max;
		_ = b.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L2 (UnityEngine.Bounds)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 position2 = vector + 16;
		Vector3 vector3 = camera2.WorldToScreenPoint(position2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		object obj2 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
		object obj3 = num2 - 0;
		GameObject cachedGameObject = w.cachedGameObject;
		int num3 = w.mWidth / obj2;
		int num4 = w.mHeight / obj3;
		if (num4 <= num3)
		{
			num3 = num4;
		}
		float pixelSizeAdjustment = UIRoot.GetPixelSizeAdjustment(cachedGameObject);
		float num5 = (float)num3 / pixelSizeAdjustment;
		float num6 = Math.Abs(num5);
		if (num6 > Mathf.Epsilon)
		{
			float value = num5 - 1f;
			float num7 = Math.Abs(value);
			if (num7 > 0.01f)
			{
				Vector3 localScale = t.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				float num8 = 0f * num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				float num9 = 0f * num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				float num10 = 0f * num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				((Vector3*)(nint)vector)->x = 0f;
				t.localScale = vector;
			}
		}
	}

	public unsafe static void FitToWidget(Transform t, Camera modelCamera, UIWidget widget, float zoom = 1f, int passes = 2)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected VT, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected VT, but got Unknown
		//IL_011a: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_03d3: Expected F4, but got I
		//IL_03ce: Expected native int or pointer, but got VT
		//IL_03f2: Expected F4, but got I
		//IL_03ed: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 160);
		_ = 0;
		_ = 0;
		_ = 1167867904;
		_ = 1167867904;
		_ = 0;
		_ = 5015954454895935488L;
		_ = 5015954454895935488L;
		Vector3 localScale = vector + 32;
		t.localScale = localScale;
		object obj2 = default;
		object obj5 = default;
		while (passes > (nint)obj2)
		{
			Bounds bounds = CalculateScreenBounds(t, modelCamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			GameObject gameObject = widget.gameObject;
			float pixelSizeAdjustment = UIRoot.GetPixelSizeAdjustment(gameObject);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+9C]");
			_ = 0;
			GameObject gameObject2 = widget.gameObject;
			float pixelSizeAdjustment2 = UIRoot.GetPixelSizeAdjustment(gameObject2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+9C]");
			_ = 0;
			float num = (float)widget.mWidth / pixelSizeAdjustment;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
			object obj3 = num2 + 0;
			float num3 = num / (float)obj3;
			float num4 = (float)widget.mHeight / pixelSizeAdjustment2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
			object obj4 = num5 + 0;
			float num6 = num4 / (float)obj4;
			if (!(num3 < num6))
			{
				num3 = num6;
			}
			float num7 = num3 * 0.95f;
			float num8 = Math.Abs(num7);
			if (Mathf.Epsilon < num8)
			{
				float value = num7 - 1f;
				float num9 = Math.Abs(value);
				if (num9 > 0.01f)
				{
					Vector3 localScale2 = t.localScale;
					float num10 = Math.Min(num7, 2.1474836E+09f);
					bool flag = num7 < 0f;
					float num11 = 0f;
					if (!flag)
					{
						num11 = num10;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
					float num12 = 0f * num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
					float num13 = 0f * num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
					float num14 = 0f * num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
					((Vector3*)(nint)vector)->x = 0f;
					t.localScale = vector;
				}
			}
			obj2 = obj5 + 1;
		}
		Vector3 localScale3 = t.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		float num15 = 0f * zoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
		float num16 = 0f * zoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		float num17 = 0f * zoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 localScale4 = vector + 16;
		t.localScale = localScale4;
	}

	public unsafe static void CenterOnWidget(Transform t, Camera modelCamera, UIWidget widget, Vector2 offset)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected VT, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected VT, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected VT, but got Unknown
		//IL_01b0: Expected F4, but got I
		//IL_01ab: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got I
		//IL_01cd: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 144);
		Transform transform = widget.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		float num = 0f + offset.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+84]");
		float num2 = 0f + offset.y;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		float num3 = 0f + 0f;
		GameObject gameObject = widget.gameObject;
		int layer = gameObject.layer;
		Camera camera = NGUITools.FindCameraForLayer(layer);
		Transform transform2 = widget.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 position = vector + 48;
		Vector3 vector2 = transform2.TransformPoint(position);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Vector3 position2 = vector + 32;
		Vector3 vector3 = camera.WorldToScreenPoint(position2);
		float nearClipPlane = modelCamera.nearClipPlane;
		float farClipPlane = modelCamera.farClipPlane;
		float nearClipPlane2 = modelCamera.nearClipPlane;
		float num4 = farClipPlane - nearClipPlane2;
		float num5 = num4 * 0.5f;
		float num6 = nearClipPlane + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Vector3 position3 = vector + 16;
		Vector3 vector4 = modelCamera.ScreenToWorldPoint(position3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		((Vector3*)(nint)vector)->x = 0f;
		t.position = vector;
	}

	public unsafe static void CenterOnWidget(Transform t, Camera modelCamera, UIWidget widget)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0021: Expected F4, but got VT
		//IL_001c: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		((Vector2*)(nint)vector)->x = (float)Vector2.zeroVector;
		_ = Vector2.zeroVector;
		CenterOnWidget(t, modelCamera, widget, vector);
	}
}
