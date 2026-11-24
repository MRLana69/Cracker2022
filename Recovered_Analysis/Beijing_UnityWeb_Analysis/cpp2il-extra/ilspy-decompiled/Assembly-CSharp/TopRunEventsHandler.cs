using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo;
using TopRun;
using UnityEngine;

public class TopRunEventsHandler
{
	private EventHandler<TournamentChangedEventArgs> m_OnTopRunChangedEvent;

	private static TopRunEventsHandler _instance;

	public static TopRunEventsHandler instance
	{
		get
		{
			if (CountryManager._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				CountryManager countryManager = default;
				CountryManager._instance = countryManager;
			}
			return (TopRunEventsHandler)(object)CountryManager._instance;
		}
	}

	public unsafe event EventHandler<TournamentChangedEventArgs> OnTopRunChangedEvent
	{
		add
		{
			//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f3: Expected VT, but got Unknown
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0401: Expected Obj, but got Unknown
			//IL_040a: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Expected Obj, but got Unknown
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Expected Obj, but got Unknown
			//IL_0426: Unknown result type (might be due to invalid IL or missing references)
			//IL_042b: Expected Obj, but got Unknown
			//IL_0434: Unknown result type (might be due to invalid IL or missing references)
			//IL_0439: Expected Obj, but got Unknown
			//IL_0442: Unknown result type (might be due to invalid IL or missing references)
			//IL_0447: Expected Obj, but got Unknown
			//IL_0450: Unknown result type (might be due to invalid IL or missing references)
			//IL_0455: Expected Obj, but got Unknown
			//IL_045e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0463: Expected Obj, but got Unknown
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_0489: Expected Obj, but got VT
			//IL_049e: Expected F4, but got Obj
			//IL_0499: Expected native int or pointer, but got VT
			//IL_04b8: Expected F4, but got Obj
			//IL_04b3: Expected native int or pointer, but got VT
			//IL_04cd: Expected F4, but got I
			//IL_04c8: Expected native int or pointer, but got VT
			//IL_04e2: Expected I4, but got VT
			//IL_04e2: Expected Obj, but got I
			//IL_00b0: Expected I, but got Obj
			//IL_00fd: Expected I, but got Obj
			//IL_0113: Expected Obj, but got I
			//IL_04f0: Expected Obj, but got VT
			//IL_0505: Expected F4, but got Obj
			//IL_0500: Expected native int or pointer, but got VT
			//IL_051f: Expected F4, but got Obj
			//IL_051a: Expected native int or pointer, but got VT
			//IL_0534: Expected F4, but got I
			//IL_052f: Expected native int or pointer, but got VT
			//IL_0549: Expected I4, but got VT
			//IL_0549: Expected Obj, but got I
			//IL_013e: Expected I, but got Obj
			//IL_018b: Expected I, but got Obj
			//IL_01a1: Expected Obj, but got I
			//IL_0557: Expected Obj, but got VT
			//IL_056c: Expected F4, but got Obj
			//IL_0567: Expected native int or pointer, but got VT
			//IL_0586: Expected F4, but got Obj
			//IL_0581: Expected native int or pointer, but got VT
			//IL_059b: Expected F4, but got I
			//IL_0596: Expected native int or pointer, but got VT
			//IL_05b0: Expected I4, but got VT
			//IL_05b0: Expected Obj, but got I
			//IL_01cc: Expected I, but got Obj
			//IL_0219: Expected I, but got Obj
			//IL_022f: Expected Obj, but got I
			//IL_05be: Expected Obj, but got VT
			//IL_05d3: Expected F4, but got Obj
			//IL_05ce: Expected native int or pointer, but got VT
			//IL_05ed: Expected F4, but got Obj
			//IL_05e8: Expected native int or pointer, but got VT
			//IL_0602: Expected F4, but got I
			//IL_05fd: Expected native int or pointer, but got VT
			//IL_0617: Expected I4, but got VT
			//IL_0617: Expected Obj, but got I
			//IL_025a: Expected I, but got Obj
			//IL_02a7: Expected I, but got Obj
			//IL_02bd: Expected Obj, but got I
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Expected Obj, but got Unknown
			//IL_0648: Expected Obj, but got VT
			//IL_065d: Expected F4, but got Obj
			//IL_0658: Expected native int or pointer, but got VT
			//IL_067c: Expected F4, but got Obj
			//IL_0677: Expected native int or pointer, but got VT
			//IL_0691: Expected F4, but got I
			//IL_068c: Expected native int or pointer, but got VT
			//IL_06a6: Expected I4, but got VT
			//IL_06a6: Expected Obj, but got I
			//IL_03a5: Expected I, but got Obj
			//IL_0625: Expected Obj, but got VT
			//IL_063a: Expected F4, but got Obj
			//IL_0635: Expected native int or pointer, but got VT
			//IL_0334: Expected I, but got Obj
			object obj = default;
			Matrix4x4 matrix4x = (Matrix4x4)(obj + 48);
			object obj2 = obj + 16;
			object obj3 = obj + 40;
			object obj4 = obj + 36;
			object obj5 = obj + 32;
			object obj6 = obj + 28;
			object obj7 = obj + 24;
			object obj8 = obj + 20;
			object obj9 = value - 1;
			if ((nint)value != 1)
			{
				if ((nint)obj9 != 1)
				{
					if ((nint)obj9 != 2)
					{
						if ((nint)obj9 == 3)
						{
							nint num = (nint)typeof(GlobalColors);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v68 (Il2CppClass<GlobalColors>)+BA]");
							object obj10 = (nint)0 & (nint)0x200;
							if (obj10 != null)
							{
								nint num2 = (nint)typeof(GlobalColors);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v79 (Il2CppClass<GlobalColors>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_30_DARK_COLOUR;
							obj6 = obj2;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
							Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunEventsHandler)+C]");
							((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
							return;
						}
						nint num3 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S1_v86 (Il2CppClass<GlobalColors>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						bool flag = obj11 == null;
						object obj12 = value + -5;
						if ((nint)obj12 < 6)
						{
							if (!flag)
							{
								nint num4 = (nint)typeof(GlobalColors);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v116 (Il2CppClass<GlobalColors>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR;
							obj7 = obj2;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
						}
						else
						{
							if (!flag)
							{
								nint num5 = (nint)typeof(GlobalColors);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v104 (Il2CppClass<GlobalColors>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_40_DARK_COLOUR;
							obj8 = obj2;
							((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
						}
						Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
						((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunEventsHandler)+C]");
						((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
						return;
					}
					nint num6 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v50 (Il2CppClass<GlobalColors>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num7 = (nint)typeof(GlobalColors);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v61 (Il2CppClass<GlobalColors>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_20_DARK_COLOUR;
					obj5 = obj2;
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
					Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
					((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunEventsHandler)+C]");
					((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
					return;
				}
				nint num8 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v32 (Il2CppClass<GlobalColors>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num9 = (nint)typeof(GlobalColors);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v43 (Il2CppClass<GlobalColors>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_10_DARK_COLOUR;
				obj4 = obj2;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
				Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunEventsHandler)+C]");
				((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
				return;
			}
			nint num10 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v14 (Il2CppClass<GlobalColors>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num11 = (nint)typeof(GlobalColors);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v25 (Il2CppClass<GlobalColors>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = GlobalColors.TOPRUN_PLAYER_BACKGOURD_00_DARK_COLOUR;
			obj3 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRunEventsHandler)+C]");
			((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnTopRunChangedEvent;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private TopRunEventsHandler()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public virtual void TriggerOnTopRunChanged(object o, TournamentChangedEventArgs eventArg = null)
	{
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_00cd: Expected I, but got Obj
		//IL_00e3: Expected Obj, but got I
		//IL_021b: Expected Obj, but got VT
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_010e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj5 = default;
		if (obj5 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [eventArg @ L2 (System.Object)+9]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string text = default;
			int index = default;
			if (text.get_Chars(index) != '\0')
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
				DateTime today = CDateTime.Today;
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v41 (Il2CppClass<System.DateTime>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v62 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj8 = default;
				obj4 = obj8;
				obj2 = today;
				obj3 = obj4;
				obj = obj2;
				object obj9 = obj3 & 0x3FFFFFFFFFFFFFFFL;
				object obj10 = obj & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj11 = default;
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj12 = default;
						if (obj12 == null)
						{
							goto IL_0276;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
			}
		}
		goto IL_0276;
		IL_0276:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj14 = default;
		object obj13 = obj14 + 16;
		obj13 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
	}
}
