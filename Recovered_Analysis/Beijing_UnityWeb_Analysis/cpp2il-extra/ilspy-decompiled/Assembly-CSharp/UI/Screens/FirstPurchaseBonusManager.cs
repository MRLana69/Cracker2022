using System;
using System.Collections;
using System.Collections.Generic;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Kiloo.Common.Utility;
using UnityEngine;

namespace UI.Screens;

public static class FirstPurchaseBonusManager
{
	private sealed class _003CStateCheckCoroutine_003Ed__19(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0056: Expected I, but got Obj
				//IL_006c: Expected Obj, but got I
				//IL_0097: Expected I, but got Obj
				//IL_00e4: Expected I, but got Obj
				//IL_00fa: Expected Obj, but got I
				//IL_0616: Expected I, but got Obj
				//IL_062c: Expected Obj, but got I
				//IL_0125: Expected I, but got Obj
				//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_05e6: Expected Obj, but got Unknown
				//IL_05ef: Expected Obj, but got I4
				//IL_0603: Expected Obj, but got I4
				//IL_0172: Expected I, but got Obj
				//IL_0188: Expected Obj, but got I
				//IL_0485: Expected I, but got Obj
				//IL_053f: Expected I, but got Obj
				//IL_0555: Expected Obj, but got I
				//IL_0677: Expected Obj, but got I4
				//IL_01b3: Expected I, but got Obj
				//IL_024d: Expected I, but got Obj
				//IL_0263: Expected Obj, but got I
				//IL_0200: Expected I, but got Obj
				//IL_0369: Expected I, but got Obj
				//IL_037f: Expected Obj, but got I
				//IL_028e: Expected I, but got Obj
				//IL_02db: Expected I, but got Obj
				//IL_02f1: Expected Obj, but got I
				//IL_03aa: Expected I, but got Obj
				//IL_03f7: Expected I, but got Obj
				//IL_040d: Expected Obj, but got I
				//IL_031c: Expected I, but got Obj
				//IL_0438: Expected I, but got Obj
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				nint num = (nint)typeof(FirstPurchaseBonusManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(FirstPurchaseBonusManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v123 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78C1");
				object obj2 = default;
				if (obj2 != null)
				{
					nint num3 = (nint)typeof(FirstPurchaseBonusManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v18 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(FirstPurchaseBonusManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v117 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(_lastIsFirstPurchaseBonusActive ? 1u : 0u) == 0)
					{
						nint num5 = (nint)typeof(FirstPurchaseBonusManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v44 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num6 = (nint)typeof(FirstPurchaseBonusManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v113 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num7 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v49 (Il2CppClass<UIScreenController>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num8 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v109 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UIScreenController.ShouldShowOnlineScreen();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						string text = default;
						text.m_stringLength = 18;
						((UIScreenController)flag)._QueueMessage(text);
						nint num9 = (nint)typeof(FirstPurchaseBonusManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v56 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num10 = (nint)typeof(FirstPurchaseBonusManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v103 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (FirstPurchaseBonusManager.m_onFirstPurchaseBonusBecameInactive != null)
						{
							nint num11 = (nint)typeof(FirstPurchaseBonusManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v90 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num12 = (nint)typeof(FirstPurchaseBonusManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v97 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						}
						nint num13 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v65 (Il2CppClass<Globals>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num14 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v83 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(Globals.DEBUG_FIRST_PURCHASE_BONUS ? 1u : 0u) != 0)
						{
							nint num15 = (nint)typeof(FirstPurchaseBonusManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v74 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
							object obj9 = (nint)0 & (nint)0x200;
							if (obj9 != null)
							{
								nint num16 = (nint)typeof(FirstPurchaseBonusManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v79 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78C5");
						}
					}
					nint num17 = (nint)typeof(FirstPurchaseBonusManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v27 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num18 = (nint)typeof(FirstPurchaseBonusManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v37 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					_lastIsFirstPurchaseBonusActive = false;
					object obj11 = this + 12;
					obj11 = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

	private static bool _lastIsFirstPurchaseBonusActive;

	private static bool running__BackingField;

	private static FirstPurchaseBonusBecameInactive m_onFirstPurchaseBonusBecameInactive;

	private static IEnumerator _stateCheckCoroutine;

	public static bool running
	{
		get
		{
			//IL_0145: Expected I, but got Obj
			//IL_015b: Expected Obj, but got I
			//IL_01c3: Expected I, but got Obj
			//IL_01d9: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01b5: Expected I4, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00f8: Expected I, but got Obj
			//IL_00ab: Expected I, but got Obj
			nint num = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (CharacterScreenManager._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v33 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(CharacterScreenManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v39 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterScreenManager instance = default;
				CharacterScreenManager._instance = instance;
			}
			nint num5 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(CharacterScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v23 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)CharacterScreenManager._instance != 0;
		}
		private set
		{
			//IL_0008: Expected Obj, but got I4
			//IL_0018: Expected Obj, but got I
			//IL_0081: Expected Obj, but got I4
			//IL_0053: Expected Obj, but got I
			//IL_0063: Expected Obj, but got I
			//IL_00b9: Expected Obj, but got I
			//IL_00c9: Expected Obj, but got I
			//IL_011e: Expected Obj, but got I
			//IL_013b: Expected Obj, but got I4
			//IL_0383: Expected Obj, but got I
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Expected Obj, but got Unknown
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Expected Obj, but got Unknown
			//IL_01c7: Expected Obj, but got I
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected Obj, but got Unknown
			//IL_0193: Expected Obj, but got I
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Expected Obj, but got Unknown
			//IL_025a: Expected Obj, but got I
			//IL_02ba: Expected Obj, but got I
			object obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Boolean)+34]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Boolean)+34]");
			object obj4;
			object obj5;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Boolean)+34]");
				object obj3 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj4 = 0;
				obj5 = obj3;
			}
			else
			{
				obj5 = obj;
				obj4 = 1;
			}
			object obj6 = default;
			object obj24 = default;
			object obj21 = default;
			for (; obj6 != obj4; obj6 = obj24 + 1)
			{
				object obj7 = obj6 << 2;
				object obj8 = obj5 + obj7;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj12 = (nint)0 & (nint)0x10;
				bool flag = obj12 == null;
				object obj13 = (flag ? 1 : 0) ^ 1;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj14 = (nint)0 & (nint)0x3FFF;
						object obj15 = obj14 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj16 = (nint)0 & (nint)0x7FFF;
						object obj17 = obj16 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj18 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj19 = (nint)0 & (nint)0x100;
						flag2 = obj19 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Boolean)+C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
							object obj20 = (nint)0 & (nint)3;
							bool flag3 = (nint)obj20 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag3)
							{
								if (obj21 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
								}
							}
							else if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
							}
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj22 = (nint)0 & (nint)0x3FFF;
				object obj23 = obj22 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
		}
	}

	public static bool isFirstPurchaseBonusActive
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FirstPurchaseBonusManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return running__BackingField;
		}
	}

	public static bool isCollectingFirstPurchaseBonus => false;

	public static event FirstPurchaseBonusBecameInactive onFirstPurchaseBonusBecameInactive
	{
		add
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected I4, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FirstPurchaseBonusManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (byte)(value & 1) != 0;
			running__BackingField = flag;
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FirstPurchaseBonusManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FirstPurchaseBonusManager.m_onFirstPurchaseBonusBecameInactive;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FirstPurchaseBonusManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FirstPurchaseBonusManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(FirstPurchaseBonusManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FirstPurchaseBonusManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FirstPurchaseBonusManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static void ResetFirstPurchaseBonus()
	{
	}

	public static void ActivateCollectState()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UserSave.inAppNonConsumablePurchaseCount = 0;
		UserSave.inAppRestoredPurchaseCount = 0;
		UserSave.inAppPurchaseHistory = null;
		UserSave.inAppConsumablePurchaseCount = 0;
	}

	public static void StartStateCheckCoroutine()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UserSave.inAppNonConsumablePurchaseCount = 1;
	}

	static FirstPurchaseBonusManager()
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78C1");
		object obj2 = default;
		if (obj2 != null)
		{
			return;
		}
		nint num3 = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private static void AppWillRefresh(RefreshType obj)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0161: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj3 = FirstPurchaseBonusManager.m_onFirstPurchaseBonusBecameInactive;
		object obj7 = default;
		while (true)
		{
			Delegate obj4 = obj3.RemoveImpl((Delegate)obj);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			bool flag = obj5 == null;
			nint num4 = (nint)typeof(FirstPurchaseBonusManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(FirstPurchaseBonusManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(FirstPurchaseBonusManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(FirstPurchaseBonusManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+5C]");
			object obj6 = (nint)0 + (nint)4;
			if (obj6 == obj3)
			{
				obj6 = obj7;
			}
			if (obj6 != obj3)
			{
				obj3 = (Delegate)obj6;
				continue;
			}
			break;
		}
	}

	private static void AppHasRefreshed(RefreshType obj)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj3 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj4 = default;
		IFormatProvider provider = default;
		if (!obj4.System_002EIConvertible_002EToBoolean(provider))
		{
			return;
		}
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v28 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CoroutineUtil.StopCoroutine((Coroutine)(object)_stateCheckCoroutine);
		_lastIsFirstPurchaseBonusActive = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78C5");
	}

	private static IEnumerator StateCheckCoroutine()
	{
		return null;
	}
}
