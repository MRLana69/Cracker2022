using System;
using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Extensions;

public static class GameObjectExtensions
{
	public unsafe static GameObject Duplicate(GameObject gameObject)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected VT, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected VT, but got Unknown
		//IL_0192: Expected F4, but got I
		//IL_018d: Expected native int or pointer, but got VT
		//IL_01b4: Expected F4, but got I
		//IL_01af: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 112);
		GameObject gameObject2 = UnityEngine.Object.Instantiate(gameObject);
		Transform transform = gameObject2.transform;
		Transform transform2 = gameObject.transform;
		Vector3 position = transform2.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Vector3 position2 = (Vector3)(quaternion + 32);
		transform.position = position2;
		Transform transform3 = gameObject2.transform;
		Transform transform4 = gameObject.transform;
		Transform parent = transform4.parent;
		transform3.parent = parent;
		Transform transform5 = gameObject2.transform;
		Transform transform6 = gameObject.transform;
		Vector3 localScale = transform6.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Vector3 localScale2 = (Vector3)(quaternion + 16);
		transform5.localScale = localScale2;
		Transform transform7 = gameObject2.transform;
		Transform transform8 = gameObject.transform;
		Quaternion rotation = transform8.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		transform7.rotation = quaternion;
		return gameObject2;
	}

	public static void SetLayerRecursively(GameObject gameObject, int layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		gameObject.layer = layer;
		Transform transform = gameObject.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_019e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_019e;
			IL_019e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 == obj7;
			bool flag2 = !flag;
			object obj8 = obj9;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	public static void SetLayerRecursively(GameObject gameObject, int layer, int layerToSkip)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		int layer2 = gameObject.layer;
		if (layer2 != layerToSkip)
		{
			gameObject.layer = layer;
		}
		Transform transform = gameObject.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_01cf;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_01cf;
			IL_01cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 == obj7;
			bool flag2 = !flag;
			object obj8 = obj9;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	public static T GetOrAdd<T>(GameObject go) where T : Component
	{
		//IL_005c: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.Extensions.GameObjectExtensions::GetOrAdd>>)+4] (should have been resolved before IL gen)");
		T val = default;
		if ((object)val == null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v7 (Il2CppMethodRgctx<Kiloo.Common.Extensions.GameObjectExtensions::GetOrAdd>)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S2_v8+4] (should have been resolved before IL gen)");
		}
		return val;
	}

	public static T GetComponentInParents<T>(GameObject gameObject) where T : Component
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Transform transform = gameObject.transform;
		Transform transform2 = transform;
		UnityEngine.Object obj3 = default;
		UnityEngine.Object result;
		while (true)
		{
			if (transform2 != null)
			{
				nint num = 0;
				nint num2 = 0;
				IntPtr intPtr = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S2_v6 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.Extensions.GameObjectExtensions::GetComponentInParents>>)+4] (should have been resolved before IL gen)");
				bool flag = obj3 == null;
				result = obj3;
				if (!flag)
				{
					break;
				}
				Transform parent = transform2.parent;
				transform2 = parent;
				continue;
			}
			object obj4 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			result = (UnityEngine.Object)0;
			break;
		}
		return (T)result;
	}
}
