using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIKeyNavigation : MonoBehaviour
{
	public enum Constraint
	{
		None,
		Vertical,
		Horizontal,
		Explicit
	}

	public static BetterList<UIKeyNavigation> list;

	public Constraint constraint;

	public GameObject onUp;

	public GameObject onDown;

	public GameObject onLeft;

	public GameObject onRight;

	public GameObject onClick;

	public GameObject onTab;

	public bool startsSelected;

	[NonSerialized]
	private bool mStarted;

	public static UIKeyNavigation current
	{
		get
		{
			GameObject hoveredObject = UICamera.hoveredObject;
			if (hoveredObject == null)
			{
				return null;
			}
			return hoveredObject.GetComponent<UIKeyNavigation>();
		}
	}

	public bool isColliderEnabled
	{
		get
		{
			bool flag = enabled;
			bool flag2 = !flag;
			bool result = false;
			if (!flag2)
			{
				GameObject gameObject = base.gameObject;
				bool activeInHierarchy = gameObject.activeInHierarchy;
				bool flag3 = !activeInHierarchy;
				result = false;
				if (!flag3)
				{
					Collider component = GetComponent<Collider>();
					if (component != null)
					{
						return component.enabled;
					}
					Collider2D component2 = GetComponent<Collider2D>();
					bool flag4 = component2 != null;
					bool flag5 = !flag4;
					result = false;
					if (!flag5)
					{
						bool flag6 = component2.enabled;
						result = flag6;
					}
				}
			}
			return result;
		}
	}

	protected virtual void OnEnable()
	{
		list.Add(this);
		if (~(mStarted ? 1u : 0u) == 0)
		{
			Start();
		}
	}

	private void Start()
	{
		mStarted = true;
		if (~(startsSelected ? 1u : 0u) == 0 && isColliderEnabled)
		{
			GameObject hoveredObject = gameObject;
			UICamera.hoveredObject = hoveredObject;
		}
	}

	protected virtual void OnDisable()
	{
		bool flag = list.Remove(this);
	}

	private static bool IsActive(GameObject go)
	{
		bool flag = go;
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			bool activeInHierarchy = go.activeInHierarchy;
			bool flag3 = !activeInHierarchy;
			result = false;
			if (!flag3)
			{
				Collider component = go.GetComponent<Collider>();
				if (component != null)
				{
					return component.enabled;
				}
				Collider2D component2 = go.GetComponent<Collider2D>();
				bool flag4 = component2 != null;
				bool flag5 = !flag4;
				result = false;
				if (!flag5)
				{
					bool flag6 = component2.enabled;
					result = flag6;
				}
			}
		}
		return result;
	}

	public unsafe GameObject GetLeft()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0032: Expected Obj, but got I4
		//IL_00da: Expected I, but got Obj
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_010d: Expected F4, but got VT
		//IL_0108: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		GameObject result;
		if (IsActive(onLeft))
		{
			result = onLeft;
		}
		else
		{
			object obj2 = constraint - 1;
			bool flag = constraint == Constraint.Vertical;
			result = null;
			if (!flag)
			{
				if ((nint)obj2 != 1)
				{
					bool flag2 = (nint)obj2 == 2;
					result = null;
					if (flag2)
					{
						goto IL_00c7;
					}
				}
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v10 (Il2CppStaticFields<UnityEngine.Vector3>)+38]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)Vector3.leftVector;
				GameObject gameObject = Get(vector, 1f, 2f);
				result = gameObject;
			}
		}
		goto IL_00c7;
		IL_00c7:
		return result;
	}

	public unsafe GameObject GetRight()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0032: Expected Obj, but got I4
		//IL_00da: Expected I, but got Obj
		//IL_00ff: Expected F4, but got I
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_010d: Expected F4, but got VT
		//IL_0108: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		GameObject result;
		if (IsActive(onRight))
		{
			result = onRight;
		}
		else
		{
			object obj2 = constraint - 1;
			bool flag = constraint == Constraint.Vertical;
			result = null;
			if (!flag)
			{
				if ((nint)obj2 != 1)
				{
					bool flag2 = (nint)obj2 == 2;
					result = null;
					if (flag2)
					{
						goto IL_00c7;
					}
				}
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v10 (Il2CppStaticFields<UnityEngine.Vector3>)+44]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)Vector3.rightVector;
				GameObject gameObject = Get(vector, 1f, 2f);
				result = gameObject;
			}
		}
		goto IL_00c7;
		IL_00c7:
		return result;
	}

	public unsafe GameObject GetUp()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0032: Expected Obj, but got I4
		//IL_0094: Expected I, but got Obj
		//IL_00b9: Expected F4, but got I
		//IL_00b4: Expected native int or pointer, but got VT
		//IL_00c7: Expected F4, but got VT
		//IL_00c2: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		GameObject result;
		if (IsActive(onUp))
		{
			result = onUp;
		}
		else
		{
			object obj2 = constraint & (Constraint)(-2);
			bool flag = (nint)obj2 == 2;
			result = null;
			if (!flag)
			{
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v12 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)Vector3.upVector;
				result = Get(vector, 2f);
			}
		}
		return result;
	}

	public unsafe GameObject GetDown()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0032: Expected Obj, but got I4
		//IL_0094: Expected I, but got Obj
		//IL_00b9: Expected F4, but got I
		//IL_00b4: Expected native int or pointer, but got VT
		//IL_00c7: Expected F4, but got VT
		//IL_00c2: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		GameObject result;
		if (IsActive(onDown))
		{
			result = onDown;
		}
		else
		{
			object obj2 = constraint & (Constraint)(-2);
			bool flag = (nint)obj2 == 2;
			result = null;
			if (!flag)
			{
				nint num = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v12 (Il2CppClass<UnityEngine.Vector3>)+5C]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+2C]");
				((Vector3*)(nint)vector)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)Vector3.downVector;
				result = Get(vector, 2f);
			}
		}
		return result;
	}

	public unsafe GameObject Get(Vector3 myDir, float x = 1f, float y = 1f)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected VT, but got Unknown
		//IL_039e: Expected F4, but got I
		//IL_0399: Expected native int or pointer, but got VT
		//IL_03b3: Expected F4, but got I
		//IL_03ae: Expected native int or pointer, but got VT
		//IL_0037: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I
		//IL_008d: Expected Obj, but got I
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_00d5: Expected Obj, but got I
		//IL_0103: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I
		//IL_01e2: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_014e: Invalid comparison between Obj and F4
		//IL_04db: Expected I, but got Obj
		//IL_0503: Expected F4, but got I
		//IL_0513: Expected F4, but got I
		//IL_022c: Expected I, but got F4
		//IL_0250: Expected F4, but got I
		//IL_024b: Expected native int or pointer, but got VT
		//IL_026f: Expected F4, but got I
		//IL_026a: Expected native int or pointer, but got VT
		//IL_02f8: Expected Obj, but got I
		//IL_0335: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		Transform transform = base.transform;
		_ = myDir.z;
		_ = myDir.x;
		Vector3 direction = vector + 16;
		Vector3 vector2 = transform.TransformDirection(direction);
		Vector3 vector3 = myDir;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = myDir;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector4)->x = 0f;
		GameObject go = gameObject;
		Vector3 center = GetCenter(go);
		float num = float.MaxValue;
		object obj2 = 0;
		object obj6 = default;
		GameObject result = default;
		while (true)
		{
			BetterList<UIKeyNavigation> betterList = list;
			if (betterList.size <= (nint)obj2)
			{
				break;
			}
			BetterList<UIKeyNavigation> betterList2 = list;
			object obj3 = obj2 << 2;
			object obj4 = (object)betterList2.buffer + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v50+10]");
			UnityEngine.Object obj5 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v50+10]");
			if ((UnityEngine.Object)0 != this)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v51 (UnityEngine.Object)+C]");
				if ((nint)0 != 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v50+10]");
					if (((UIKeyNavigation)0).isColliderEnabled)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v50+10]");
						UIWidget component = ((Component)0).GetComponent<UIWidget>();
						if (component != null)
						{
							nint num2 = (nint)component;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ S1_v91 (Il2CppClass<UIWidget>)+F4] (should have been resolved before IL gen)");
							if (obj6 == (object)0f)
							{
								goto IL_03c2;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v50+10]");
						GameObject go2 = ((Component)0).gameObject;
						center = GetCenter(go2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
						float num3 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
						float num4 = num3 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
						object obj7 = num5 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
						object obj8 = num6 - 0;
						float num7 = num4 * num4;
						object obj9 = obj7 * obj7;
						float num8 = num7 + (float)obj9;
						object obj10 = obj8 * obj8;
						float num9 = num8 + (float)obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
						float num13;
						float num14;
						nint num15;
						if (num9 > 1E-05f)
						{
							float num10 = (float)obj8 / num9;
							float num11 = (float)obj7 / num9;
							float num12 = num4 / num9;
							num13 = num11;
							num14 = num10;
							num15 = (nint)num12;
						}
						else
						{
							nint num16 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S1_v74 (Il2CppClass<UnityEngine.Vector3>)+5C]");
							nint num17 = 0;
							num15 = num17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S1_v75 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
							num13 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S1_v75 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
							num14 = 0f;
						}
						float num18 = myDir.x * (float)num15;
						float num19 = myDir.y * num13;
						float num20 = num18 + num19;
						float num21 = myDir.z * num14;
						float num22 = num20 + num21;
						if (!(num22 < 0.707f))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
							((Vector3*)(nint)vector)->z = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
							((Vector3*)(nint)vector)->x = 0f;
							center = transform.InverseTransformDirection(vector);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
							float num23 = 0f * x;
							float num24 = num23 * num23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
							float num25 = 0f * y;
							float num26 = num25 * num25;
							float num27 = num24 + num26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
							nint num28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
							object obj11 = num28 * 0;
							float num29 = num27 + (float)obj11;
							if (!(num29 > num))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v50+10]");
								result = ((Component)0).gameObject;
								num = num29;
							}
						}
					}
				}
			}
			goto IL_03c2;
			IL_03c2:
			object obj12 = obj2 + 1;
			obj2 = obj12;
		}
		return result;
	}

	protected unsafe static Vector3 GetCenter(GameObject go)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0326: Expected F4, but got I
		//IL_0321: Expected native int or pointer, but got VT
		//IL_033b: Expected F4, but got I
		//IL_0336: Expected native int or pointer, but got VT
		//IL_01f3: Expected I, but got Obj
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_025c: Expected Obj, but got I
		//IL_0289: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I
		//IL_02ce: Expected native int or pointer, but got VT
		//IL_02db: Expected native int or pointer, but got VT
		//IL_02e8: Expected native int or pointer, but got VT
		//IL_0099: Expected F4, but got I
		//IL_00a9: Expected F4, but got I
		//IL_00b9: Expected F4, but got I
		//IL_0386: Expected F4, but got I
		//IL_0381: Expected native int or pointer, but got VT
		//IL_0394: Expected Obj, but got F4
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected F4, but got Unknown
		//IL_03ae: Expected native int or pointer, but got VT
		//IL_03cd: Expected native int or pointer, but got VT
		//IL_03e7: Expected F4, but got I
		//IL_03e2: Expected native int or pointer, but got VT
		//IL_00cf: Expected I, but got Obj
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_0138: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		UIWidget component = go.GetComponent<UIWidget>();
		int layer = go.layer;
		UICamera uICamera = UICamera.FindCameraForLayer(layer);
		Vector3 vector3 = default;
		if (uICamera != null)
		{
			Transform transform = go.transform;
			Vector3 position = transform.position;
			bool flag = component != null;
			bool flag2 = !flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			float num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			float num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
			float num3 = 0f;
			if (!flag2)
			{
				nint num4 = (nint)component;
				object obj2 = component + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ S2_v21 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v56+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v56+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v56+30]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v56+28]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				object obj3 = num5 + 0;
				float num6 = (float)obj3 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				object obj4 = num7 + 0;
				float num8 = (float)obj4 * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
				object obj5 = num9 + 0;
				float num10 = (float)obj5 * 0.5f;
				num = num8;
				num2 = num6;
				num3 = num10;
			}
			Camera cachedCamera = uICamera.cachedCamera;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj6 = num3 << 32;
			float x = num2 | obj6;
			((Vector3*)(nint)vector)->x = x;
			Vector3 vector2 = cachedCamera.WorldToScreenPoint(vector);
			((Vector3*)(nint)vector3)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector3)->x = 0f;
		}
		else if (component != null)
		{
			nint num11 = (nint)component;
			object obj7 = component + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ S2_v7 (Il2CppClass<UIWidget>)+10C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v19+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v19+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v19+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v19+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			object obj8 = num12 + 0;
			float x2 = (float)obj8 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			object obj9 = num13 + 0;
			float y = (float)obj9 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			object obj10 = num14 + 0;
			float z = (float)obj10 * 0.5f;
			((Vector3*)(nint)vector3)->z = z;
			((Vector3*)(nint)vector3)->y = y;
			((Vector3*)(nint)vector3)->x = x2;
		}
		else
		{
			Transform transform2 = go.transform;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector3)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector3)->x = 0f;
		}
		return vector3;
	}

	public virtual void OnNavigate(KeyCode key)
	{
		//IL_0013: Expected Obj, but got I4
		if (UIPopupList.isOpen)
		{
			return;
		}
		object obj = key - 273;
		GameObject gameObject;
		if (key != KeyCode.UpArrow)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						gameObject = null;
					}
					else
					{
						GameObject left = GetLeft();
						gameObject = left;
					}
				}
				else
				{
					GameObject right = GetRight();
					gameObject = right;
				}
			}
			else
			{
				GameObject down = GetDown();
				gameObject = down;
			}
		}
		else
		{
			GameObject up = GetUp();
			gameObject = up;
		}
		if (gameObject != null)
		{
			UICamera.hoveredObject = gameObject;
		}
	}

	public virtual void OnKey(KeyCode key)
	{
		if (key != KeyCode.Tab)
		{
			return;
		}
		bool flag = onTab == null;
		bool flag2 = !flag;
		UnityEngine.Object obj = onTab;
		if (!flag2)
		{
			UICamera.GetKeyStateFunc getKey = UICamera.GetKey;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v70.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj2 = default;
			if (obj2 == null)
			{
				UICamera.GetKeyStateFunc getKey2 = UICamera.GetKey;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v99.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				object obj3 = default;
				if (obj3 == null)
				{
					GameObject right = GetRight();
					bool flag3 = right == null;
					bool flag4 = !flag3;
					GameObject gameObject = right;
					if (!flag4)
					{
						GameObject down = GetDown();
						gameObject = down;
					}
					bool flag5 = gameObject == null;
					bool flag6 = !flag5;
					obj = gameObject;
					if (!flag6)
					{
						GameObject up = GetUp();
						obj = up;
					}
					if (obj == null)
					{
						GameObject left = GetLeft();
						obj = left;
					}
					goto IL_01df;
				}
			}
			GameObject left2 = GetLeft();
			bool flag7 = left2 == null;
			bool flag8 = !flag7;
			GameObject gameObject2 = left2;
			if (!flag8)
			{
				GameObject up2 = GetUp();
				gameObject2 = up2;
			}
			bool flag9 = gameObject2 == null;
			bool flag10 = !flag9;
			obj = gameObject2;
			if (!flag10)
			{
				GameObject down2 = GetDown();
				obj = down2;
			}
			if (obj == null)
			{
				GameObject right2 = GetRight();
				obj = right2;
			}
		}
		goto IL_01df;
		IL_01df:
		if (obj != null)
		{
			UICamera.selectedObject = (GameObject)obj;
		}
	}

	protected virtual void OnClick()
	{
		if (NGUITools.GetActive(onClick))
		{
			UICamera.hoveredObject = onClick;
		}
	}

	static UIKeyNavigation()
	{
		BetterList<UIKeyNavigation> betterList = default;
		list = betterList;
	}
}
