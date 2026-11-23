using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIGeometry
{
	public BetterList<Vector3> verts;

	public BetterList<Vector2> uvs;

	public BetterList<Color32> cols;

	private BetterList<Vector3> mRtpVerts;

	private Vector3 mRtpNormal;

	private Vector4 mRtpTan;

	public bool hasVertices
	{
		get
		{
			BetterList<Vector3> betterList = verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (BetterList`1<UnityEngine.Vector3>)+C]");
			return (nint)0 > (nint)0;
		}
	}

	public bool hasTransformed
	{
		get
		{
			BetterList<Vector3> betterList = mRtpVerts;
			bool flag = mRtpVerts == null;
			bool result = false;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v3 (BetterList`1<UnityEngine.Vector3>)+C]");
				bool flag2 = (nint)0 < (nint)1;
				result = false;
				if (!flag2)
				{
					BetterList<Vector3> betterList2 = verts;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S0_v3 (BetterList`1<UnityEngine.Vector3>)+C]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v4 (BetterList`1<UnityEngine.Vector3>)+C]");
					bool flag3 = num == 0;
					result = flag3;
				}
			}
			return result;
		}
	}

	public void Clear()
	{
		BetterList<Vector3> betterList = verts;
		_ = 0;
		BetterList<Vector2> betterList2 = uvs;
		_ = 0;
		BetterList<Color32> betterList3 = cols;
		_ = 0;
		BetterList<Vector3> betterList4 = mRtpVerts;
		_ = 0;
	}

	public unsafe void ApplyTransform(Matrix4x4 widgetToPanel, bool generateNormals = true)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected VT, but got Unknown
		//IL_00c1: Expected Ref, but got VT
		//IL_00e7: Expected F4, but got I
		//IL_00e2: Expected native int or pointer, but got VT
		//IL_0109: Expected F4, but got I
		//IL_0104: Expected native int or pointer, but got VT
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0285: Expected I, but got Obj
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected VT, but got Unknown
		//IL_02c3: Expected Ref, but got VT
		//IL_02e9: Expected Obj, but got I
		//IL_0306: Expected Obj, but got I
		//IL_0330: Expected Obj, but got I
		//IL_0350: Invalid comparison between Obj and F4
		//IL_0396: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_03cf: Expected Obj, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected VT, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_04f0: Expected I, but got Obj
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected VT, but got Unknown
		//IL_052e: Expected Ref, but got VT
		//IL_03f1: Expected Obj, but got I
		//IL_040e: Expected Obj, but got I
		//IL_0438: Expected Obj, but got I
		//IL_0458: Invalid comparison between Obj and F4
		//IL_04a4: Expected I, but got Obj
		//IL_04c4: Expected Obj, but got I
		//IL_04dd: Expected Obj, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected VT, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 112);
		BetterList<Vector3> betterList = verts;
		BetterList<Vector3> betterList2 = mRtpVerts;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (BetterList`1<UnityEngine.Vector3>)+C]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		BetterList<Vector3> betterList3 = verts;
		object obj2 = 0;
		while (true)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v20 (BetterList`1<UnityEngine.Vector3>)+C]");
			if ((nint)obj3 >= 0)
			{
				break;
			}
			BetterList<Vector3> betterList4 = verts;
			object obj4 = obj2 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v65 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj5 = 0 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v67+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v67+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 point = vector + 16;
			Vector3 vector2 = ((Matrix4x4*)widgetToPanel)->MultiplyPoint3x4(point);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			((Vector3*)(nint)vector)->x = 0f;
			mRtpVerts.Add(vector);
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		if (generateNormals)
		{
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v11 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v12 (Il2CppStaticFields<UnityEngine.Vector3>)+5C]");
			_ = 0;
			_ = Vector3.backVector;
			Vector3 vector3 = vector + 48;
			Vector3 vector4 = ((Matrix4x4*)widgetToPanel)->MultiplyVector(vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			object obj7 = num3 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			object obj8 = num4 * 0;
			object obj9 = obj7 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			object obj10 = num5 * 0;
			object obj11 = obj9 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			Vector3 vector6;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				object obj12 = 0 / obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				Vector3 vector5 = (Vector3)(0 / obj11);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				object obj13 = 0 / obj11;
				vector6 = vector5;
				object obj14 = obj12;
			}
			else
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v116 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v117 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				object obj13 = 0;
				vector6 = Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v117 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				object obj14 = 0;
			}
			mRtpNormal = vector6;
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S1_v32 (Il2CppStaticFields<UnityEngine.Vector3>)+44]");
			_ = 0;
			_ = Vector3.rightVector;
			Vector3 vector7 = vector + 32;
			Vector3 vector8 = ((Matrix4x4*)widgetToPanel)->MultiplyVector(vector7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			object obj15 = num10 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			object obj16 = num11 * 0;
			object obj17 = obj15 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			object obj18 = num12 * 0;
			object obj19 = obj17 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			Vector3 vector10;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				object obj20 = 0 / obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				Vector3 vector9 = (Vector3)(0 / obj19);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				object obj21 = 0 / obj19;
				vector10 = vector9;
				object obj22 = obj20;
			}
			else
			{
				nint num13 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v92 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v93 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
				object obj21 = 0;
				vector10 = Vector3.zeroVector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v93 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
				object obj22 = 0;
			}
			mRtpTan = vector10;
			_ = -1082130432;
		}
	}

	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected VT, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected VT, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected VT, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03ba: Expected Obj, but got I
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected VT, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected VT, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected VT, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected VT, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_044a: Expected Obj, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected VT, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		//IL_0242: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 160;
		BetterList<Vector3> betterList = mRtpVerts;
		if (mRtpVerts == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (BetterList`1<UnityEngine.Vector3>)+C]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		bool flag = n == null;
		bool flag2 = !flag;
		BetterList<Vector3> betterList2 = mRtpVerts;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (BetterList`1<UnityEngine.Vector3>)+C]");
		object obj3 = 0;
		BetterList<Vector3> betterList3 = mRtpVerts;
		object obj5 = default;
		object obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (BetterList`1<UnityEngine.Vector3>)+C]");
		object obj6 = 0;
		if (!flag2)
		{
			object obj7 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj8 = obj7 * 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ L8_v7 (BetterList`1<UnityEngine.Vector3>)+8]");
				object obj9 = 0 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v58+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v58+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
				_ = 0;
				Vector3 item = (Vector3)(obj + 24);
				v.Add(item);
				BetterList<Vector2> betterList4 = uvs;
				object obj10 = obj7 << 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v69 (BetterList`1<UnityEngine.Vector2>)+8]");
				object obj11 = 0 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v71+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Vector2 item2 = (Vector2)(obj + 16);
				u.Add(item2);
				BetterList<Color32> betterList5 = cols;
				object obj12 = obj5 << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v79 (BetterList`1<UnityEngine.Color32>)+8]");
				object obj13 = 0 + obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v81+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Color32 item3 = (Color32)(obj + 12);
				c.Add(item3);
				obj7 = obj5 + 1;
				BetterList<Vector3> betterList6 = mRtpVerts;
				betterList2 = mRtpVerts;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v65 (BetterList`1<UnityEngine.Vector3>)+C]");
				obj3 = 0;
			}
			return;
		}
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj14 = obj4 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ L8_v3 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj15 = 0 + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v10+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v10+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			_ = 0;
			Vector3 item4 = (Vector3)(obj + 80);
			v.Add(item4);
			BetterList<Vector2> betterList7 = uvs;
			object obj16 = obj4 << 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v21 (BetterList`1<UnityEngine.Vector2>)+8]");
			object obj17 = 0 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v23+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Vector2 item5 = (Vector2)(obj + 72);
			u.Add(item5);
			BetterList<Color32> betterList8 = cols;
			object obj18 = obj4 << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v31 (BetterList`1<UnityEngine.Color32>)+8]");
			object obj19 = 0 + obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v33+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
			_ = 0;
			Color32 item6 = (Color32)(obj + 68);
			c.Add(item6);
			object obj20 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIGeometry)+20]");
			obj20 = 0;
			_ = mRtpNormal;
			Vector3 item7 = (Vector3)(obj + 56);
			n.Add(item7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIGeometry)+2C]");
			_ = 0;
			_ = mRtpTan;
			Vector4 item8 = (Vector4)(obj + 40);
			t.Add(item8);
			object obj21 = obj4 + 1;
			BetterList<Vector3> betterList9 = mRtpVerts;
			betterList3 = mRtpVerts;
			obj4 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v44 (BetterList`1<UnityEngine.Vector3>)+C]");
			obj6 = 0;
		}
	}

	public UIGeometry()
	{
		BetterList<Vector3> betterList = default;
		verts = betterList;
		BetterList<Vector2> betterList2 = default;
		uvs = betterList2;
		BetterList<Color32> betterList3 = default;
		cols = betterList3;
		BetterList<Vector3> betterList4 = default;
		mRtpVerts = betterList4;
	}
}
