using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Popups.AgeRestrictionPopupInternal;
using UI.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Popups;

public class CloudSaveCelebrationPopup : UIScreen
{
	private sealed class _003CAnimateRoutine_003Ed__13(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudSaveCelebrationPopup _003C_003E4__this;

		private Vector3 _003CoriginalCloudScale_003E5__2;

		private Vector3 _003CoriginalCheckmarkScale_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bc9: Expected VT, but got Unknown
				//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bd7: Expected I4, but got Unknown
				//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0be5: Expected Obj, but got Unknown
				//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bf3: Expected Obj, but got Unknown
				//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c01: Expected Obj, but got Unknown
				//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c0f: Expected Obj, but got Unknown
				//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c1d: Expected Obj, but got Unknown
				//IL_0c26: Expected Obj, but got I4
				//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c3a: Expected Obj, but got Unknown
				//IL_0c43: Expected Obj, but got I4
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0133: Expected Obj, but got Unknown
				//IL_013c: Expected Obj, but got I4
				//IL_0142: Unknown result type (might be due to invalid IL or missing references)
				//IL_0147: Expected Obj, but got Unknown
				//IL_0183: Expected Obj, but got I4
				//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Expected Obj, but got Unknown
				//IL_01c2: Expected Obj, but got I4
				//IL_01f0: Expected I, but got Obj
				//IL_0206: Expected Obj, but got I
				//IL_0c8d: Expected F4, but got Obj
				//IL_0c88: Expected native int or pointer, but got VT
				//IL_0ca2: Expected F4, but got I
				//IL_0c9d: Expected native int or pointer, but got VT
				//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f7: Expected Obj, but got Unknown
				//IL_041a: Expected I, but got Obj
				//IL_0430: Expected Obj, but got I
				//IL_027d: Expected F4, but got Obj
				//IL_0278: Expected native int or pointer, but got VT
				//IL_0292: Expected F4, but got I
				//IL_028d: Expected native int or pointer, but got VT
				//IL_0298: Unknown result type (might be due to invalid IL or missing references)
				//IL_029d: Expected Obj, but got Unknown
				//IL_02aa: Expected Obj, but got F4
				//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_02bf: Expected Obj, but got Unknown
				//IL_02e1: Expected F4, but got Obj
				//IL_02dc: Expected native int or pointer, but got VT
				//IL_02f6: Expected F4, but got I
				//IL_02f1: Expected native int or pointer, but got VT
				//IL_0231: Expected I, but got Obj
				//IL_0ce4: Expected F4, but got Obj
				//IL_0cdf: Expected native int or pointer, but got VT
				//IL_0cf9: Expected F4, but got I
				//IL_0cf4: Expected native int or pointer, but got VT
				//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d16: Expected Obj, but got Unknown
				//IL_0d38: Expected F4, but got Obj
				//IL_0d33: Expected native int or pointer, but got VT
				//IL_0d4d: Expected F4, but got I
				//IL_0d48: Expected native int or pointer, but got VT
				//IL_032e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0333: Expected Obj, but got Unknown
				//IL_033c: Expected Obj, but got I4
				//IL_0349: Expected I4, but got Obj
				//IL_0363: Expected F4, but got Obj
				//IL_035e: Expected native int or pointer, but got VT
				//IL_0378: Expected F4, but got I
				//IL_0373: Expected native int or pointer, but got VT
				//IL_037e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0383: Expected Obj, but got Unknown
				//IL_03a6: Expected Obj, but got VT
				//IL_03a6: Expected VT, but got I
				//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_04b6: Expected Obj, but got Unknown
				//IL_04bf: Expected Obj, but got I4
				//IL_04cc: Expected I4, but got Obj
				//IL_04e6: Expected F4, but got Obj
				//IL_04e1: Expected native int or pointer, but got VT
				//IL_04fb: Expected F4, but got I
				//IL_04f6: Expected native int or pointer, but got VT
				//IL_0501: Unknown result type (might be due to invalid IL or missing references)
				//IL_0506: Expected Obj, but got Unknown
				//IL_0529: Expected Obj, but got VT
				//IL_0529: Expected VT, but got I
				//IL_045b: Expected I, but got Obj
				//IL_0575: Unknown result type (might be due to invalid IL or missing references)
				//IL_057a: Expected Obj, but got Unknown
				//IL_059d: Expected I, but got Obj
				//IL_05b3: Expected Obj, but got I
				//IL_03dc: Expected Obj, but got I4
				//IL_055f: Expected Obj, but got I4
				//IL_0d7b: Expected F4, but got Obj
				//IL_0d76: Expected native int or pointer, but got VT
				//IL_0d90: Expected F4, but got I
				//IL_0d8b: Expected native int or pointer, but got VT
				//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0dad: Expected Obj, but got Unknown
				//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0de8: Expected Obj, but got Unknown
				//IL_0df1: Expected Obj, but got I4
				//IL_0dfe: Expected I4, but got Obj
				//IL_0e18: Expected F4, but got Obj
				//IL_0e13: Expected native int or pointer, but got VT
				//IL_0e2d: Expected F4, but got I
				//IL_0e28: Expected native int or pointer, but got VT
				//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e38: Expected Obj, but got Unknown
				//IL_0e5b: Expected Obj, but got VT
				//IL_0e5b: Expected VT, but got I
				//IL_064a: Expected Obj, but got I4
				//IL_05de: Expected I, but got Obj
				//IL_067b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0680: Expected Obj, but got Unknown
				//IL_0689: Expected Obj, but got I4
				//IL_06b7: Expected I, but got Obj
				//IL_06cd: Expected Obj, but got I
				//IL_0e7a: Expected F4, but got Obj
				//IL_0e75: Expected native int or pointer, but got VT
				//IL_0e8f: Expected F4, but got I
				//IL_0e8a: Expected native int or pointer, but got VT
				//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_08be: Expected Obj, but got Unknown
				//IL_08e1: Expected I, but got Obj
				//IL_08f7: Expected Obj, but got I
				//IL_0744: Expected F4, but got Obj
				//IL_073f: Expected native int or pointer, but got VT
				//IL_0759: Expected F4, but got I
				//IL_0754: Expected native int or pointer, but got VT
				//IL_075f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0764: Expected Obj, but got Unknown
				//IL_0771: Expected Obj, but got F4
				//IL_0781: Unknown result type (might be due to invalid IL or missing references)
				//IL_0786: Expected Obj, but got Unknown
				//IL_07a8: Expected F4, but got Obj
				//IL_07a3: Expected native int or pointer, but got VT
				//IL_07bd: Expected F4, but got I
				//IL_07b8: Expected native int or pointer, but got VT
				//IL_06f8: Expected I, but got Obj
				//IL_0ed1: Expected F4, but got Obj
				//IL_0ecc: Expected native int or pointer, but got VT
				//IL_0ee6: Expected F4, but got I
				//IL_0ee1: Expected native int or pointer, but got VT
				//IL_0efe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f03: Expected Obj, but got Unknown
				//IL_0f25: Expected F4, but got Obj
				//IL_0f20: Expected native int or pointer, but got VT
				//IL_0f3a: Expected F4, but got I
				//IL_0f35: Expected native int or pointer, but got VT
				//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
				//IL_07fa: Expected Obj, but got Unknown
				//IL_0803: Expected Obj, but got I4
				//IL_0810: Expected I4, but got Obj
				//IL_082a: Expected F4, but got Obj
				//IL_0825: Expected native int or pointer, but got VT
				//IL_083f: Expected F4, but got I
				//IL_083a: Expected native int or pointer, but got VT
				//IL_0845: Unknown result type (might be due to invalid IL or missing references)
				//IL_084a: Expected Obj, but got Unknown
				//IL_086d: Expected Obj, but got VT
				//IL_086d: Expected VT, but got I
				//IL_0978: Unknown result type (might be due to invalid IL or missing references)
				//IL_097d: Expected Obj, but got Unknown
				//IL_0986: Expected Obj, but got I4
				//IL_0993: Expected I4, but got Obj
				//IL_09ad: Expected F4, but got Obj
				//IL_09a8: Expected native int or pointer, but got VT
				//IL_09c2: Expected F4, but got I
				//IL_09bd: Expected native int or pointer, but got VT
				//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_09cd: Expected Obj, but got Unknown
				//IL_09f0: Expected Obj, but got VT
				//IL_09f0: Expected VT, but got I
				//IL_0922: Expected I, but got Obj
				//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a41: Expected Obj, but got Unknown
				//IL_0a64: Expected I, but got Obj
				//IL_0a7a: Expected Obj, but got I
				//IL_08a3: Expected Obj, but got I4
				//IL_0a26: Expected Obj, but got I4
				//IL_0f68: Expected F4, but got Obj
				//IL_0f63: Expected native int or pointer, but got VT
				//IL_0f7d: Expected F4, but got I
				//IL_0f78: Expected native int or pointer, but got VT
				//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
				//IL_0f9a: Expected Obj, but got Unknown
				//IL_0fd0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0fd5: Expected Obj, but got Unknown
				//IL_0fde: Expected Obj, but got I4
				//IL_0feb: Expected I4, but got Obj
				//IL_1005: Expected F4, but got Obj
				//IL_1000: Expected native int or pointer, but got VT
				//IL_101a: Expected F4, but got I
				//IL_1015: Expected native int or pointer, but got VT
				//IL_1020: Unknown result type (might be due to invalid IL or missing references)
				//IL_1025: Expected Obj, but got Unknown
				//IL_1048: Expected Obj, but got VT
				//IL_1048: Expected VT, but got I
				//IL_0b11: Expected Obj, but got I4
				//IL_0aa5: Expected I, but got Obj
				//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b47: Expected Obj, but got Unknown
				//IL_0b50: Expected Obj, but got I4
				//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b5b: Expected Obj, but got Unknown
				//IL_0b97: Expected Obj, but got I4
				object obj = default;
				Vector3 vector = (Vector3)(obj + 96);
				int num = obj + 84;
				object obj2 = obj + 48;
				object obj3 = obj + 36;
				object obj4 = obj + 24;
				object obj5 = obj + 12;
				object obj6 = obj + 72;
				obj6 = 0;
				_ = 0;
				object obj7 = obj + 60;
				obj7 = 0;
				_ = 0;
				CloudSaveCelebrationPopup cloudSaveCelebrationPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								if (_003C_003E1__state != 4)
								{
									if (_003C_003E1__state != 5)
									{
										if (_003C_003E1__state != 6)
										{
											if (_003C_003E1__state != 7)
											{
												if (_003C_003E1__state == 8)
												{
													_003C_003E1__state = -1;
													return null;
												}
												return null;
											}
											_003C_003E1__state = -1;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
											nint num2 = 0;
											_ = 0;
											object obj9 = default;
											object obj8 = obj9 + 16;
											obj8 = 0;
											object obj10 = this + 12;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @838D");
											IEnumerator routine = default;
											Coroutine coroutine = cloudSaveCelebrationPopup.StartCoroutine_Auto(routine);
											obj10 = coroutine;
											_003C_003E1__state = 8;
											return 1;
										}
										_003C_003E1__state = -1;
										object obj11 = this + 32;
										obj2 = obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S1_v261+8]");
										_ = 0;
										nint num3 = (nint)typeof(Vector3);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v285 (Il2CppClass<UnityEngine.Vector3>)+BA]");
										object obj12 = (nint)0 & (nint)0x200;
										if (obj12 != null)
										{
											nint num4 = (nint)typeof(Vector3);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S0_v311 (Il2CppClass<UnityEngine.Vector3>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										((Vector3*)(nint)vector)->x = (float)obj2;
										Vector3 vector2 = vector;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
										((Vector3*)(nint)vector2)->z = 0f;
										Vector3 vector3 = vector / 0.9f;
										object obj13 = this + 32;
										obj4 = obj13;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S1_v272+8]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
										nint num5 = 0;
										_ = 0;
										object obj15 = default;
										object obj14 = obj15 + 16;
										obj14 = 0;
										((int*)num)->m_value = (int)obj3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
										_ = 0;
										((Vector3*)(nint)vector)->x = (float)obj4;
										Vector3 vector4 = vector;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
										((Vector3*)(nint)vector4)->z = 0f;
										object obj16 = this + 12;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27 (UI.Popups.CloudSaveCelebrationPopup)+38]");
										IAsyncResult routine2 = ((UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback)null).BeginInvoke((Ray)0, 1f / 15f, num, (AsyncCallback)vector, obj15);
										Coroutine coroutine2 = cloudSaveCelebrationPopup.StartCoroutine_Auto((IEnumerator)routine2);
										obj16 = coroutine2;
										_003C_003E1__state = 7;
										return 1;
									}
									_003C_003E1__state = -1;
									object obj17 = this + 32;
									obj2 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S1_v221+8]");
									_ = 0;
									nint num6 = (nint)typeof(Vector3);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v246 (Il2CppClass<UnityEngine.Vector3>)+BA]");
									object obj18 = (nint)0 & (nint)0x200;
									if (obj18 != null)
									{
										nint num7 = (nint)typeof(Vector3);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v275 (Il2CppClass<UnityEngine.Vector3>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									((Vector3*)(nint)vector)->x = (float)obj2;
									Vector3 vector5 = vector;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
									((Vector3*)(nint)vector5)->z = 0f;
									Vector3 vector6 = vector / 1.2f;
									object obj19 = this + 32;
									obj4 = obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S1_v232+8]");
									_ = 0;
									((Vector3*)(nint)vector)->x = (float)obj4;
									Vector3 vector7 = vector;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
									((Vector3*)(nint)vector7)->z = 0f;
									Vector3 vector8 = vector / 0.9f;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									nint num8 = 0;
									_ = 0;
									object obj21 = default;
									object obj20 = obj21 + 16;
									obj20 = 0;
									((int*)num)->m_value = (int)obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
									_ = 0;
									((Vector3*)(nint)vector)->x = (float)obj5;
									Vector3 vector9 = vector;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
									((Vector3*)(nint)vector9)->z = 0f;
									object obj22 = this + 12;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27 (UI.Popups.CloudSaveCelebrationPopup)+38]");
									IAsyncResult routine3 = ((UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback)null).BeginInvoke((Ray)0, 1f / 15f, num, (AsyncCallback)vector, obj21);
									Coroutine coroutine3 = cloudSaveCelebrationPopup.StartCoroutine_Auto((IEnumerator)routine3);
									obj22 = coroutine3;
									_003C_003E1__state = 6;
									return 1;
								}
								_003C_003E1__state = -1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								nint num9 = 0;
								_ = 0;
								object obj24 = default;
								object obj23 = obj24 + 16;
								obj23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @838D");
								IEnumerator routine4 = default;
								Coroutine coroutine4 = cloudSaveCelebrationPopup.StartCoroutine_Auto(routine4);
								nint num10 = (nint)typeof(Vector3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S0_v196 (Il2CppClass<UnityEngine.Vector3>)+BA]");
								object obj25 = (nint)0 & (nint)0x200;
								if (obj25 != null)
								{
									nint num11 = (nint)typeof(Vector3);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S0_v236 (Il2CppClass<UnityEngine.Vector3>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Vector3 forward = Vector3.forward;
								((Vector3*)(nint)vector)->x = (float)obj2;
								Vector3 vector10 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
								((Vector3*)(nint)vector10)->z = 0f;
								Vector3 vector11 = vector / 0.8f;
								obj7 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
								_ = 0;
								Vector3 forward2 = Vector3.forward;
								((Vector3*)(nint)vector)->x = (float)obj4;
								Vector3 vector12 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
								((Vector3*)(nint)vector12)->z = 0f;
								object obj26 = this + 32;
								obj26 = vector.x;
								_ = vector.z;
								object obj27 = this + 32;
								obj5 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ S1_v192+8]");
								_ = 0;
								((Vector3*)(nint)vector)->x = (float)obj5;
								Vector3 vector13 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
								((Vector3*)(nint)vector13)->z = 0f;
								Vector3 vector14 = vector / 1.2f;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								nint num12 = 0;
								_ = 0;
								object obj29 = default;
								object obj28 = obj29 + 16;
								obj28 = 0;
								((int*)num)->m_value = (int)obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v24+8]");
								_ = 0;
								((Vector3*)(nint)vector)->x = (float)obj;
								Vector3 vector15 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								((Vector3*)(nint)vector15)->z = 0f;
								object obj30 = this + 12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27 (UI.Popups.CloudSaveCelebrationPopup)+38]");
								IAsyncResult routine5 = ((UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback)null).BeginInvoke((Ray)0, 1f / 15f, num, (AsyncCallback)vector, obj29);
								Coroutine coroutine5 = cloudSaveCelebrationPopup.StartCoroutine_Auto((IEnumerator)routine5);
								obj30 = coroutine5;
								_003C_003E1__state = 5;
								return 1;
							}
							_003C_003E1__state = -1;
							object obj31 = this + 20;
							obj2 = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v128+8]");
							_ = 0;
							nint num13 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v151 (Il2CppClass<UnityEngine.Vector3>)+BA]");
							object obj32 = (nint)0 & (nint)0x200;
							if (obj32 != null)
							{
								nint num14 = (nint)typeof(Vector3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v177 (Il2CppClass<UnityEngine.Vector3>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							((Vector3*)(nint)vector)->x = (float)obj2;
							Vector3 vector16 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
							((Vector3*)(nint)vector16)->z = 0f;
							Vector3 vector17 = vector / 0.9f;
							object obj33 = this + 20;
							obj4 = obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S1_v139+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num15 = 0;
							_ = 0;
							object obj35 = default;
							object obj34 = obj35 + 16;
							obj34 = 0;
							((int*)num)->m_value = (int)obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
							_ = 0;
							((Vector3*)(nint)vector)->x = (float)obj4;
							Vector3 vector18 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
							((Vector3*)(nint)vector18)->z = 0f;
							object obj36 = this + 12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27 (UI.Popups.CloudSaveCelebrationPopup)+34]");
							IAsyncResult routine6 = ((UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback)null).BeginInvoke((Ray)0, 0.1f, num, (AsyncCallback)vector, obj35);
							Coroutine coroutine6 = cloudSaveCelebrationPopup.StartCoroutine_Auto((IEnumerator)routine6);
							obj36 = coroutine6;
							_003C_003E1__state = 4;
							return 1;
						}
						_003C_003E1__state = -1;
						object obj37 = this + 20;
						obj2 = obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v88+8]");
						_ = 0;
						nint num16 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v112 (Il2CppClass<UnityEngine.Vector3>)+BA]");
						object obj38 = (nint)0 & (nint)0x200;
						if (obj38 != null)
						{
							nint num17 = (nint)typeof(Vector3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v141 (Il2CppClass<UnityEngine.Vector3>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector)->x = (float)obj2;
						Vector3 vector19 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
						((Vector3*)(nint)vector19)->z = 0f;
						Vector3 vector20 = vector / 1.2f;
						object obj39 = this + 20;
						obj4 = obj39;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v99+8]");
						_ = 0;
						((Vector3*)(nint)vector)->x = (float)obj4;
						Vector3 vector21 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
						((Vector3*)(nint)vector21)->z = 0f;
						Vector3 vector22 = vector / 0.9f;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num18 = 0;
						_ = 0;
						object obj41 = default;
						object obj40 = obj41 + 16;
						obj40 = 0;
						((int*)num)->m_value = (int)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
						_ = 0;
						((Vector3*)(nint)vector)->x = (float)obj5;
						Vector3 vector23 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
						((Vector3*)(nint)vector23)->z = 0f;
						object obj42 = this + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27 (UI.Popups.CloudSaveCelebrationPopup)+34]");
						IAsyncResult routine7 = ((UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback)null).BeginInvoke((Ray)0, 0.125f, num, (AsyncCallback)vector, obj41);
						Coroutine coroutine7 = cloudSaveCelebrationPopup.StartCoroutine_Auto((IEnumerator)routine7);
						obj42 = coroutine7;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num19 = 0;
					_ = 0;
					object obj44 = default;
					object obj43 = obj44 + 16;
					obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @838D");
					IEnumerator routine8 = default;
					Coroutine coroutine8 = cloudSaveCelebrationPopup.StartCoroutine_Auto(routine8);
					nint num20 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v62 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj45 = (nint)0 & (nint)0x200;
					if (obj45 != null)
					{
						nint num21 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S0_v102 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward3 = Vector3.forward;
					((Vector3*)(nint)vector)->x = (float)obj2;
					Vector3 vector24 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector3*)(nint)vector24)->z = 0f;
					Vector3 vector25 = vector / 0.1f;
					obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					_ = 0;
					Vector3 forward4 = Vector3.forward;
					((Vector3*)(nint)vector)->x = (float)obj4;
					Vector3 vector26 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
					((Vector3*)(nint)vector26)->z = 0f;
					object obj46 = this + 20;
					obj46 = vector.x;
					_ = vector.z;
					object obj47 = this + 20;
					obj5 = obj47;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S1_v59+8]");
					_ = 0;
					((Vector3*)(nint)vector)->x = (float)obj5;
					Vector3 vector27 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
					((Vector3*)(nint)vector27)->z = 0f;
					Vector3 vector28 = vector / 1.2f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num22 = 0;
					_ = 0;
					object obj49 = default;
					object obj48 = obj49 + 16;
					obj48 = 0;
					((int*)num)->m_value = (int)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
					_ = 0;
					((Vector3*)(nint)vector)->x = (float)obj;
					Vector3 vector29 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector3*)(nint)vector29)->z = 0f;
					object obj50 = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v27 (UI.Popups.CloudSaveCelebrationPopup)+34]");
					IAsyncResult routine9 = ((UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback)null).BeginInvoke((Ray)0, 1f / 6f, num, (AsyncCallback)vector, obj49);
					Coroutine coroutine9 = cloudSaveCelebrationPopup.StartCoroutine_Auto((IEnumerator)routine9);
					obj50 = coroutine9;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num23 = 0;
				_ = 0;
				object obj52 = default;
				object obj51 = obj52 + 16;
				obj51 = 0;
				object obj53 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @838D");
				IEnumerator routine10 = default;
				Coroutine coroutine10 = cloudSaveCelebrationPopup.StartCoroutine_Auto(routine10);
				obj53 = coroutine10;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		unsafe void IDisposable.Dispose()
		{
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected Obj, but got Unknown
			//IL_0314: Expected Obj, but got I4
			//IL_0323: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Expected Obj, but got Unknown
			//IL_0331: Expected Obj, but got I4
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Expected Obj, but got Unknown
			//IL_034e: Expected Obj, but got I4
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Expected Obj, but got Unknown
			//IL_036d: Expected Obj, but got I4
			//IL_037e: Expected VT, but got Obj
			//IL_039e: Expected I, but got Obj
			//IL_03b4: Expected Obj, but got I
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Expected VT, but got Unknown
			//IL_03f5: Expected F4, but got Obj
			//IL_03f0: Expected native int or pointer, but got VT
			//IL_040a: Expected F4, but got I
			//IL_0405: Expected native int or pointer, but got VT
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_0418: Expected Obj, but got Unknown
			//IL_042d: Expected Obj, but got I
			//IL_044f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Expected Obj, but got Unknown
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_0477: Expected Obj, but got Unknown
			//IL_005f: Expected F4, but got Obj
			//IL_005a: Expected native int or pointer, but got VT
			//IL_0074: Expected F4, but got I
			//IL_006f: Expected native int or pointer, but got VT
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			//IL_0097: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00d1: Expected F4, but got Obj
			//IL_00cc: Expected native int or pointer, but got VT
			//IL_00e6: Expected F4, but got I
			//IL_00e1: Expected native int or pointer, but got VT
			//IL_00ef: Expected Obj, but got VT
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected Obj, but got Unknown
			//IL_0131: Expected VT, but got I4
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected Obj, but got Unknown
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected Obj, but got Unknown
			//IL_0172: Expected I, but got Obj
			//IL_0188: Expected Obj, but got I
			//IL_04be: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Expected VT, but got Unknown
			//IL_04d0: Expected F4, but got Obj
			//IL_04cb: Expected native int or pointer, but got VT
			//IL_04e2: Expected F4, but got I
			//IL_04dd: Expected native int or pointer, but got VT
			//IL_04ef: Expected F4, but got Obj
			//IL_04ea: Expected native int or pointer, but got VT
			//IL_0504: Expected F4, but got I
			//IL_04ff: Expected native int or pointer, but got VT
			//IL_050d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0512: Expected Obj, but got Unknown
			//IL_0530: Expected F4, but got Obj
			//IL_052b: Expected native int or pointer, but got VT
			//IL_0545: Expected F4, but got I
			//IL_0540: Expected native int or pointer, but got VT
			//IL_054e: Expected Obj, but got VT
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected Obj, but got Unknown
			//IL_020a: Expected F4, but got Obj
			//IL_0205: Expected native int or pointer, but got VT
			//IL_021f: Expected F4, but got I
			//IL_021a: Expected native int or pointer, but got VT
			//IL_022d: Expected I, but got Obj
			//IL_0243: Expected Obj, but got I
			//IL_01b3: Expected I, but got Obj
			//IL_0573: Expected native int or pointer, but got VT
			//IL_0585: Expected native int or pointer, but got VT
			//IL_0593: Unknown result type (might be due to invalid IL or missing references)
			//IL_0598: Expected Ref, but got Unknown
			//IL_05a5: Expected Ref, but got VT
			//IL_05b7: Expected F4, but got VT
			//IL_05b2: Expected native int or pointer, but got VT
			//IL_05cc: Expected F4, but got I
			//IL_05c7: Expected native int or pointer, but got VT
			//IL_05d5: Expected Obj, but got VT
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected Obj, but got Unknown
			//IL_02da: Expected F4, but got Obj
			//IL_02d5: Expected native int or pointer, but got VT
			//IL_02ef: Expected F4, but got I
			//IL_02ea: Expected native int or pointer, but got VT
			//IL_02fc: Expected Obj, but got VT
			//IL_02fc: Expected Obj, but got I4
			//IL_026e: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 152;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 140;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 128;
			obj4 = 0;
			_ = 0;
			Transform transform = (Transform)(obj2 + 116);
			GameObject gameObject = ((Component)_003C_003E1__state).gameObject;
			transform.position = (Vector3)gameObject;
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v22 (Il2CppClass<UIScreenController>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v71 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Vector3 vector = (Vector3)(obj2 + 176);
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj6 = obj2 + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v27 (System.Boolean)+30]");
			Vector3 vector2 = ((Camera)0).WorldToViewportPoint(vector);
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v33+8]");
			_ = 0;
			object obj7 = obj2 + 92;
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v33+8]");
			_ = 0;
			object obj8 = obj2 + 80;
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			obj3 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v42+4]");
			_ = 0;
			_ = 1f;
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((Vector3*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj9 = obj2 + 68;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v50 (System.Boolean)+20]");
			Vector3 vector3 = ((Camera)0).ScreenToViewportPoint(vector);
			obj4 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v55+8]");
			_ = 0;
			int layer = ((GameObject)_003C_003E2__current).layer;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 localPosition = ((Transform)vector).localPosition;
			int layer2 = ((GameObject)_003C_003E2__current).layer;
			Transform transform2 = (Transform)(obj2 + 56);
			int layer3 = ((GameObject)_003C_003E2__current).layer;
			transform2.localPosition = (Vector3)layer3;
			object obj10 = obj2 + 44;
			object obj11 = this + 16;
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S2_v16+8]");
			_ = 0;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v66 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v105 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector4 = (Vector3)(obj2 + 164);
			((Vector3*)(nint)vector4)->x = (float)transform2;
			((Vector3*)(nint)vector4)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			((Vector3*)(nint)vector)->x = (float)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v63+8]");
			((Vector3*)(nint)vector)->z = 0f;
			object obj13 = obj2 + 32;
			Vector3 vector5 = vector4 - vector;
			((Vector3*)(nint)vector)->x = (float)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v76+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 eulerAngles = ((Transform)vector).eulerAngles;
			int layer4 = ((GameObject)_003C_003E2__current).layer;
			object obj14 = this + 28;
			((Vector3*)(nint)vector4)->x = (float)obj14;
			Vector3 vector6 = vector4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S2_v38+8]");
			((Vector3*)(nint)vector6)->z = 0f;
			nint num5 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v84 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num6 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v101 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector)->x = vector4.x;
			((Vector3*)(nint)vector)->z = vector4.z;
			ref Quaternion reference = ref *(Quaternion*)(obj2 + 16);
			Quaternion.Inverse_Injected(ref reference, out *(Quaternion*)vector);
			((Vector3*)(nint)vector)->x = (float)reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v91 (UnityEngine.Quaternion&)+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 localScale = ((Transform)vector).localScale;
			int layer5 = ((GameObject)_003C_003E2__current).layer;
			object obj16 = this + 40;
			obj2 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S2_v55+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			((Transform)layer5).parent = (Transform)vector;
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

	private sealed class _003CAnimateAlpha_003Ed__14(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWidget widget;

		public float from;

		public float duration;

		public Func<float, float> easing;

		public float to;

		private float _003Cfactor_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00d5: Expected I, but got Obj
				//IL_00eb: Expected Obj, but got I
				//IL_0116: Expected I, but got Obj
				//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b5: Expected Obj, but got Unknown
				//IL_01be: Expected Obj, but got I4
				//IL_01d2: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					_003Cfactor_003E5__2 = 0f;
				}
				if (_003Cfactor_003E5__2 < 1f)
				{
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime / duration;
					float num2 = _003Cfactor_003E5__2 + num;
					_003Cfactor_003E5__2 = num2;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num5;
					if (_003Cfactor_003E5__2 < 0f)
					{
						num5 = 0f;
					}
					else
					{
						num5 = ((!(_003Cfactor_003E5__2 > 1f)) ? _003Cfactor_003E5__2 : 1f);
					}
					_003Cfactor_003E5__2 = num5;
					float t = easing(_003Cfactor_003E5__2);
					float num6 = Mathf.LerpUnclamped(from, to, t);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					object obj2 = this + 12;
					obj2 = 0;
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

	private sealed class _003CAnimateScale_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWidget widget;

		public Vector3 from;

		public float duration;

		public Func<float, float> easing;

		public Vector3 to;

		private float _003Cfactor_003E5__2;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ea: Expected Obj, but got Unknown
				//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02f8: Expected VT, but got Unknown
				//IL_0301: Unknown result type (might be due to invalid IL or missing references)
				//IL_0306: Expected Obj, but got Unknown
				//IL_030f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0314: Expected Obj, but got Unknown
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Expected Obj, but got Unknown
				//IL_005b: Expected F4, but got Obj
				//IL_0056: Expected native int or pointer, but got VT
				//IL_0070: Expected F4, but got I
				//IL_006b: Expected native int or pointer, but got VT
				//IL_007d: Expected Obj, but got F4
				//IL_008f: Expected I, but got F4
				//IL_01ba: Expected I, but got Obj
				//IL_01d0: Expected Obj, but got I
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_011a: Expected Obj, but got Unknown
				//IL_0127: Expected F4, but got Obj
				//IL_0122: Expected native int or pointer, but got VT
				//IL_013c: Expected F4, but got I
				//IL_0137: Expected native int or pointer, but got VT
				//IL_0149: Expected Obj, but got F4
				//IL_015b: Expected I, but got F4
				//IL_01fb: Expected I, but got Obj
				//IL_0396: Unknown result type (might be due to invalid IL or missing references)
				//IL_039b: Expected Obj, but got Unknown
				//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bb: Expected Obj, but got Unknown
				//IL_03de: Expected I, but got Obj
				//IL_03f4: Expected Obj, but got I
				//IL_041e: Expected F4, but got Obj
				//IL_0419: Expected native int or pointer, but got VT
				//IL_0433: Expected F4, but got I
				//IL_042e: Expected native int or pointer, but got VT
				//IL_0461: Expected VT, but got Obj
				//IL_0495: Unknown result type (might be due to invalid IL or missing references)
				//IL_049a: Expected Obj, but got Unknown
				//IL_04a3: Expected Obj, but got I4
				//IL_04b7: Expected Obj, but got I4
				//IL_029d: Expected I, but got Obj
				object obj = default;
				Transform transform = (Transform)(obj + 48);
				Quaternion quaternion = (Quaternion)(obj + 36);
				object obj2 = obj + 24;
				object obj3 = obj + 12;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					GameObject gameObject = widget.gameObject;
					object obj4 = this + 20;
					((Quaternion*)(nint)quaternion)->x = (float)obj4;
					Quaternion quaternion2 = quaternion;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v47+8]");
					((Quaternion*)(nint)quaternion2)->z = 0f;
					transform = (Transform)quaternion.x;
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)quaternion.z;
					((Transform)(object)gameObject).parent = transform;
					_003Cfactor_003E5__2 = 0f;
				}
				if (!(_003Cfactor_003E5__2 < 1f))
				{
					GameObject gameObject2 = widget.gameObject;
					object obj5 = this + 40;
					((Quaternion*)(nint)quaternion)->x = (float)obj5;
					Quaternion quaternion3 = quaternion;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v37+8]");
					((Quaternion*)(nint)quaternion3)->z = 0f;
					transform = (Transform)quaternion.x;
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)quaternion.z;
					((Transform)(object)gameObject2).parent = transform;
					return null;
				}
				float unscaledTime = Time.unscaledTime;
				float num = unscaledTime / duration;
				float num2 = _003Cfactor_003E5__2 + num;
				_003Cfactor_003E5__2 = num2;
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v28 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v43 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num5;
				if (_003Cfactor_003E5__2 < 0f)
				{
					num5 = 0f;
				}
				else
				{
					num5 = ((!(_003Cfactor_003E5__2 > 1f)) ? _003Cfactor_003E5__2 : 1f);
				}
				_003Cfactor_003E5__2 = num5;
				float t = easing(_003Cfactor_003E5__2);
				GameObject gameObject3 = widget.gameObject;
				object obj7 = this + 20;
				obj2 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S2_v11+8]");
				_ = 0;
				object obj8 = this + 40;
				obj3 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S2_v16+8]");
				_ = 0;
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v26 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num7 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Quaternion*)(nint)quaternion)->x = (float)obj2;
				Quaternion quaternion4 = quaternion;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Quaternion*)(nint)quaternion4)->z = 0f;
				transform = (Transform)obj3;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				Quaternion quaternion5 = Quaternion.Slerp(quaternion, (Quaternion)transform, t);
				transform = (Transform)obj;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				((Transform)(object)gameObject3).parent = transform;
				object obj10 = this + 12;
				obj10 = 0;
				_003C_003E1__state = 1;
				return 1;
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

	private UILabel _headline;

	private UILabel _subline;

	private UIWidget _skyline;

	private UIWidget _cloud;

	private UIWidget _checkmark;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		ShowIfInactive();
		ApplyColors();
		Update();
	}

	private void Localize()
	{
		base.Hide();
		Animate();
		this._002Ector();
	}

	private void ApplyColors()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_00c0: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("CLOUDSAVE_CELEBRATION_TOP");
		_headline.fontSize = (int)text;
		string text2 = Strings.GetDefault("CLOUDSAVE_CELEBRATION_BOTTOM");
		_subline.fontSize = (int)text2;
	}

	private unsafe void Update()
	{
		//IL_01d0: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0228: Expected Obj, but got I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected I4, but got Unknown
		//IL_0258: Expected I4, but got Obj
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_0290: Expected Obj, but got I4
		//IL_02b2: Expected I4, but got Obj
		//IL_02c8: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0090: Expected I4, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00ea: Expected I4, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I4
		//IL_0139: Expected I4, but got Obj
		//IL_01bc: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v34 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 - -64;
		object obj4 = (flag ? 1 : 0) + 604;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 80);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_headline.rawPivot = pivot;
		object obj5 = obj3 + 48;
		object obj6 = (flag ? 1 : 0) + 140;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		object obj7 = obj3 + 32;
		object obj8 = (flag ? 1 : 0) + 604;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v18+8]");
		_ = 0;
		_subline.rawPivot = pivot;
		object obj9 = obj3 + 16;
		object obj10 = (flag ? 1 : 0) + 140;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v37+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v24+8]");
		_ = 0;
		Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
		object obj11 = (flag ? 1 : 0) + 124;
		obj3 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S2_v47+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_skyline.rawPivot = pivot;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
	}

	public void PopupClicked()
	{
		//IL_000a: Expected Obj, but got I4
		if (Input.GetKeyDown((string)27))
		{
			((CloudSaveCelebrationPopup)null).Reset();
		}
	}

	private void Reset()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
	}

	private unsafe void Animate()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_0107: Expected F4, but got Obj
		//IL_0102: Expected native int or pointer, but got VT
		//IL_011c: Expected F4, but got I
		//IL_0117: Expected native int or pointer, but got VT
		//IL_013b: Expected F4, but got Obj
		//IL_0136: Expected native int or pointer, but got VT
		//IL_0150: Expected F4, but got I
		//IL_014b: Expected native int or pointer, but got VT
		//IL_015d: Expected Obj, but got VT
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		GameObject gameObject = _cloud.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v26 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 forward = Vector3.forward;
		Vector3 vector = (Vector3)(obj3 + 24);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v14+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = vector / 0.01f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		((Transform)(object)gameObject).parent = (Transform)vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
	}

	private IEnumerator AnimateRoutine()
	{
		//IL_00e0: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00aa: Expected I4, but got Obj
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<ListContentElement> list = default;
		list._002Ector(120);
		object obj2 = 1900;
		ListContentElement listContentElement = default;
		ListContentElement listContentElement2 = default;
		object obj5 = default;
		while (true)
		{
			obj = obj2;
			if ((nint)obj2 > 2018)
			{
				break;
			}
			if ((nint)obj2 == 2000)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj3 = listContentElement + 8;
				obj3 = "----";
				listContentElement.value__BackingField = int.MinValue;
				list.Add(listContentElement);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj4 = listContentElement2 + 8;
			obj4 = obj5;
			listContentElement2.value__BackingField = (int)obj;
			list.Add(listContentElement2);
			object obj6 = obj + 1;
			obj2 = obj6;
		}
		return (IEnumerator)list;
	}

	private IEnumerator AnimateAlpha(UIWidget widget, float duration, float from, float to, Func<float, float> easing)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private IEnumerator AnimateScale(UIWidget widget, float duration, Vector3 from, Vector3 to, Func<float, float> easing)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public CloudSaveCelebrationPopup()
	{
		IEnumerator routine = ((CloudSaveDisabledStatusPopup)this).ButtonClicked_Routine();
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}
}
