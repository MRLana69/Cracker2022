using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using FullSerializer.Internal;
using FullSerializer.Internal.DirectConverters;

namespace FullSerializer;

public class fsConverterRegistrar
{
	public static AnimationCurve_DirectConverter Register_AnimationCurve_DirectConverter;

	public static Bounds_DirectConverter Register_Bounds_DirectConverter;

	public static Gradient_DirectConverter Register_Gradient_DirectConverter;

	public static GUIStyleState_DirectConverter Register_GUIStyleState_DirectConverter;

	public static GUIStyle_DirectConverter Register_GUIStyle_DirectConverter;

	public static Keyframe_DirectConverter Register_Keyframe_DirectConverter;

	public static LayerMask_DirectConverter Register_LayerMask_DirectConverter;

	public static RectOffset_DirectConverter Register_RectOffset_DirectConverter;

	public static Rect_DirectConverter Register_Rect_DirectConverter;

	public static List<Type> Converters;

	static fsConverterRegistrar()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Expected Obj, but got Unknown
		//IL_0022: Expected VT, but got Obj
		//IL_0041: Expected Obj, but got I4
		//IL_0103: Expected VT, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Expected Obj, but got Unknown
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected Obj, but got Unknown
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected Obj, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected Obj, but got Unknown
		//IL_03dc: Expected Obj, but got I
		//IL_0407: Expected Obj, but got I
		//IL_0544: Expected Obj, but got I
		//IL_0552: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 24;
		_ = 0;
		List<Type> list = default;
		list._002Ector();
		Converters = list;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(fsConverterRegistrar));
		FieldInfo[] declaredFields = fsPortableReflection.GetDeclaredFields(typeFromHandle);
		object obj4 = 0;
		string text = default;
		Type item = default;
		while (declaredFields.Length > (nint)obj4)
		{
			object obj5 = obj4 << 2;
			object obj6 = (object)declaredFields + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v314+10]");
			object obj7 = 0;
			object obj8 = obj7 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ S1_v164+BC] (should have been resolved before IL gen)");
			if (text.StartsWith("Register_"))
			{
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ S2_v52+144] (should have been resolved before IL gen)");
				Converters.Add(item);
			}
			object obj10 = obj4 + 1;
			obj4 = obj10;
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(fsConverterRegistrar));
		MethodInfo[] declaredMethods = fsPortableReflection.GetDeclaredMethods(typeFromHandle2);
		object obj11 = 0;
		string text2 = default;
		while (declaredMethods.Length > (nint)obj11)
		{
			object obj12 = obj11 << 2;
			object obj13 = (object)declaredMethods + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v304+10]");
			object obj14 = 0;
			object obj15 = obj14 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ S1_v153+BC] (should have been resolved before IL gen)");
			if (text2.StartsWith("Register_"))
			{
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ S6_v4+1BC] (should have been resolved before IL gen)");
			}
			object obj17 = obj11 + 1;
			obj11 = obj17;
		}
		List<Type> list2 = default;
		list2._002Ector((IEnumerable<Type>)Converters);
		object obj18 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj19 = obj + 32;
		obj = obj19;
		_ = 0;
		object obj21 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		object obj28 = default;
		object obj30 = default;
		object obj31 = default;
		object obj37 = default;
		object obj38 = default;
		object obj39 = default;
		object obj40 = default;
		object obj42 = default;
		object obj43 = default;
		object obj44 = default;
		object obj45 = default;
		while (true)
		{
			_ = 0;
			object obj20 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj26;
			object obj27;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj21 == null)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 == 1;
					bool flag2 = !flag;
					object obj22 = obj23;
					if (flag2)
					{
						goto IL_0987;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag3 = obj24 != obj25;
					obj26 = obj24;
					obj27 = obj28;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							object obj29 = obj30;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (obj31 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
									object obj32 = (nint)0 << 2;
									object obj33 = obj3 + obj32;
									obj33 = obj30;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
									object obj34 = (nint)0 + (nint)1;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										goto IL_07d5;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10+4]");
									object obj35 = -1;
									obj22 = 0;
									goto IL_0987;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
								object obj36 = obj30;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_04cc;
								}
								return;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_04cc;
					}
					goto IL_09c2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_07d5;
			IL_07d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj26 = obj37;
			obj27 = obj38;
			goto IL_09c2;
			IL_09c2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj39 == obj26)
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
				obj27 = obj40;
			}
			_ = 0;
			object obj41 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			goto IL_08c0;
			IL_04cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			obj26 = obj42;
			obj27 = obj43;
			if (!flag4)
			{
				goto IL_08c0;
			}
			goto IL_09c2;
			IL_0987:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj44 == null)
				{
					continue;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											if (obj45 != null)
											{
												continue;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												continue;
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
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								goto IL_07d5;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_07d5;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_07d5;
			IL_08c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
		}
		object obj46 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A0D");
		Converters = list2;
	}
}
