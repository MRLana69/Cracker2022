using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Missions;
using SYBO.Subway.Info;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class PoolManager
{
	private class PoolPriority
	{
		public int Priority;

		public bool IsSpawnPriority;

		public SpawnPool Pool;

		public PoolPriority()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private class PoolPriorityComparer : IComparer<PoolPriority>
	{
		public int Compare(PoolPriority x, PoolPriority y)
		{
			//IL_0009: Expected Obj, but got I4
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			int result = default;
			return result;
		}
	}

	private sealed class _003CPoolBalancing_003Ed__27(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		private Action<float> _003CthisProgress_003E5__2;

		private float _003CtotalBalanceOperations_003E5__3;

		private float _003CbalanceOperation_003E5__4;

		private int _003Ci_003E5__5;

		private PoolPriority _003Cpriority_003E5__6;

		private int _003Cj_003E5__7;

		private PrefabPool _003CprefabPool_003E5__8;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Expected Obj, but got Unknown
				//IL_0086: Expected Obj, but got I4
				//IL_009a: Expected Obj, but got I4
				//IL_00a3: Expected Obj, but got I4
				//IL_00bc: Expected Obj, but got I4
				//IL_00da: Expected I, but got Obj
				//IL_00f0: Expected Obj, but got I
				//IL_02b2: Expected VT, but got I4
				//IL_02b2: Expected VT, but got Obj
				//IL_0f1c: Expected I4, but got F4
				//IL_0870: Expected I4, but got F4
				//IL_087e: Expected I, but got Obj
				//IL_0894: Expected Obj, but got I
				//IL_02e5: Expected I, but got Obj
				//IL_02fb: Expected Obj, but got I
				//IL_028a: Expected Obj, but got I4
				//IL_0171: Expected Obj, but got I4
				//IL_011b: Expected I, but got Obj
				//IL_018f: Expected I, but got Obj
				//IL_01a5: Expected Obj, but got I
				//IL_0964: Expected I, but got Obj
				//IL_097a: Expected Obj, but got I
				//IL_065f: Expected I, but got Obj
				//IL_0675: Expected Obj, but got I
				//IL_050f: Expected Obj, but got I4
				//IL_0f3d: Expected F4, but got I4
				//IL_0163: Expected Obj, but got I4
				//IL_0f80: Expected I4, but got F4
				//IL_116f: Expected I, but got Obj
				//IL_1185: Expected Obj, but got I
				//IL_0912: Unknown result type (might be due to invalid IL or missing references)
				//IL_0917: Expected Obj, but got Unknown
				//IL_0920: Expected Obj, but got I4
				//IL_0929: Expected Obj, but got I4
				//IL_08bf: Expected I, but got Obj
				//IL_10ee: Expected Obj, but got I4
				//IL_0326: Expected I, but got Obj
				//IL_0226: Expected Obj, but got I4
				//IL_01d0: Expected I, but got Obj
				//IL_0234: Expected Obj, but got I4
				//IL_09a5: Expected I, but got Obj
				//IL_1141: Expected F4, but got I4
				//IL_0907: Expected Obj, but got I4
				//IL_06a0: Expected I, but got Obj
				//IL_03aa: Expected I, but got Obj
				//IL_03c0: Expected Obj, but got I
				//IL_0fa1: Expected F4, but got I4
				//IL_0218: Expected Obj, but got I4
				//IL_0b49: Expected I, but got Obj
				//IL_0b5f: Expected Obj, but got I
				//IL_1250: Expected F4, but got I4
				//IL_1259: Expected Obj, but got I4
				//IL_1067: Expected I, but got Obj
				//IL_107d: Expected Obj, but got I
				//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
				//IL_0d76: Expected Obj, but got Unknown
				//IL_0d94: Expected Obj, but got I4
				//IL_0da0: Expected Obj, but got I4
				//IL_0dd9: Expected I4, but got F4
				//IL_0c46: Expected I, but got Obj
				//IL_0c5c: Expected Obj, but got I
				//IL_0a71: Expected I, but got Obj
				//IL_11ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_11cf: Expected Obj, but got Unknown
				//IL_11e6: Expected I, but got Obj
				//IL_11fc: Expected Obj, but got I
				//IL_1205: Expected Obj, but got I4
				//IL_121d: Expected F4, but got Obj
				//IL_045d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0462: Expected Obj, but got Unknown
				//IL_046b: Expected Obj, but got I4
				//IL_047f: Expected F4, but got I
				//IL_0488: Expected Obj, but got I4
				//IL_0491: Expected Obj, but got I4
				//IL_03eb: Expected I, but got Obj
				//IL_0d5d: Expected F4, but got I4
				//IL_0d66: Expected Obj, but got I4
				//IL_130c: Expected F4, but got I4
				//IL_136b: Expected I, but got F4
				//IL_0b8a: Expected I, but got Obj
				//IL_0ab9: Expected F4, but got I4
				//IL_0ac2: Expected Obj, but got I4
				//IL_0a0b: Expected I, but got Obj
				//IL_05bd: Expected I, but got Obj
				//IL_0e5f: Expected F4, but got I4
				//IL_0e68: Expected Obj, but got I4
				//IL_0e09: Expected F4, but got I4
				//IL_0e12: Expected Obj, but got I4
				//IL_0c87: Expected I, but got Obj
				//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0e93: Expected Obj, but got Unknown
				//IL_0e9c: Expected Obj, but got I4
				//IL_0ea4: Expected F4, but got I
				//IL_0ead: Expected Obj, but got I4
				//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bd4: Expected Obj, but got Unknown
				//IL_0bdd: Expected Obj, but got I4
				//IL_0bf9: Expected I4, but got F4
				//IL_0c02: Expected F4, but got I4
				//IL_0c0b: Expected Obj, but got I4
				//IL_0e47: Expected F4, but got I4
				//IL_0e50: Expected Obj, but got I4
				//IL_0cd4: Expected I, but got Obj
				//IL_0cea: Expected Obj, but got I
				//IL_1320: Unknown result type (might be due to invalid IL or missing references)
				//IL_1325: Expected Obj, but got Unknown
				//IL_0724: Expected I, but got Obj
				//IL_073a: Expected Obj, but got I
				//IL_0d15: Expected I, but got Obj
				//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_07dc: Expected Obj, but got Unknown
				//IL_07e5: Expected Obj, but got I4
				//IL_07f8: Expected F4, but got I
				//IL_0801: Expected Obj, but got I4
				//IL_080a: Expected Obj, but got I4
				//IL_0765: Expected I, but got Obj
				object obj2;
				float num4 = default;
				object result = default;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								nint num = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v329 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
								object obj = (nint)0 & (nint)0x200;
								if (obj != null)
								{
									nint num2 = (nint)typeof(PoolManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v344 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								StopClock();
								PoolPriority poolPriority = _003Cpriority_003E5__6;
								SpawnPool pool = poolPriority.Pool;
								float num3 = (float)pool.logLevelAdjust + 1f;
								pool.logLevelAdjust = (int)num3;
								obj2 = ((~(_forceRestartBalancing ? 1u : 0u) != 0) ? ((object)51) : ((object)53));
								num4 = 1f;
							}
							else
							{
								obj2 = 80;
							}
						}
						else
						{
							_003C_003E1__state = -1;
							nint num5 = (nint)typeof(PoolManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v308 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							if (obj3 != null)
							{
								nint num6 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v323 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							StopClock();
							PoolPriority poolPriority2 = _003Cpriority_003E5__6;
							SpawnPool pool2 = poolPriority2.Pool;
							float num7 = (float)pool2.logLevelAdjust + 1f;
							pool2.logLevelAdjust = (int)num7;
							obj2 = ((~(_forceRestartBalancing ? 1u : 0u) != 0) ? ((object)29) : ((object)53));
							num4 = 1f;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						obj2 = 72;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					object obj4 = this + 12;
					obj4 = 0;
					_003C_003E1__state = 1;
					result = 1;
					obj2 = 80;
				}
				object obj5 = obj2;
				while (true)
				{
					if ((nint)obj5 == 29)
					{
						while (true)
						{
							Transform transform = _003CprefabPool_003E5__8.SpawnNew();
							PrefabPool prefabPool = _003CprefabPool_003E5__8;
							if ((nint)transform >= prefabPool.preloadAmount)
							{
								obj5 = 53;
								break;
							}
							string text = ((PrefabsDict)(object)_003CprefabPool_003E5__8).ToString();
							Transform transform2 = _003CprefabPool_003E5__8.SpawnInstance((Vector3)text, (Quaternion)0);
							float num8 = _003CbalanceOperation_003E5__4 + 1f;
							_003CbalanceOperation_003E5__4 = num8;
							nint num9 = (nint)typeof(PoolManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v259 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num10 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v291 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							long elapsedTicks = _sw.ElapsedTicks;
							bool flag = elapsedTicks < BalancingBudgetMS;
							num4 = 1f;
							if (flag)
							{
								continue;
							}
							PoolPriority poolPriority3 = _003Cpriority_003E5__6;
							SpawnPool pool3 = poolPriority3.Pool;
							int logLevelAdjust = pool3.logLevelAdjust - 1;
							pool3.logLevelAdjust = logLevelAdjust;
							nint num11 = (nint)typeof(PoolManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v272 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num12 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S0_v287 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							PoolManager._002Ecctor();
							bool flag2 = _003CthisProgress_003E5__2 == null;
							nint num13 = 1;
							if (!flag2)
							{
								float obj8 = _003CbalanceOperation_003E5__4 / _003CtotalBalanceOperations_003E5__3;
								_003CthisProgress_003E5__2(obj8);
								num13 = 0;
							}
							object obj9 = this + 12;
							obj9 = 0;
							_003C_003E1__state = 2;
							num4 = num13;
							obj5 = 80;
							result = 1;
							break;
						}
						continue;
					}
					if ((nint)obj5 == 51)
					{
						while (true)
						{
							Transform transform3 = _003CprefabPool_003E5__8.SpawnNew();
							PrefabPool prefabPool2 = _003CprefabPool_003E5__8;
							if ((nint)transform3 <= prefabPool2.cullAbove)
							{
								obj5 = 53;
								break;
							}
							PrefabPool prefabPool3 = _003CprefabPool_003E5__8;
							LinkedList<PooledInstanceData> despawned = prefabPool3._despawned;
							if (despawned.count != 0)
							{
								PrefabPool prefabPool4 = _003CprefabPool_003E5__8;
								LinkedList<PooledInstanceData> despawned2 = prefabPool4._despawned;
								LinkedListNode<PooledInstanceData> linkedListNode;
								if (despawned2.head != null)
								{
									LinkedListNode<PooledInstanceData> head = despawned2.head;
									linkedListNode = head.prev;
								}
								else
								{
									linkedListNode = null;
								}
								PooledInstanceData item = linkedListNode.item;
								PrefabPool prefabPool5 = _003CprefabPool_003E5__8;
								prefabPool5._despawned.Remove(linkedListNode);
								nint num14 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S1_v101 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
								object obj10 = (nint)0 & (nint)0x200;
								if (obj10 != null)
								{
									nint num15 = (nint)typeof(PoolManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S1_v127 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Despawn((Transform)(object)linkedListNode.item);
								PrefabPool prefabPool6 = _003CprefabPool_003E5__8;
								string tag = item.transform__BackingField.tag;
								prefabPool6.spawnPool.CreatePrefabPool((PrefabPool)(object)tag);
								float num16 = _003CbalanceOperation_003E5__4 + 1f;
								_003CbalanceOperation_003E5__4 = num16;
								long elapsedTicks2 = _sw.ElapsedTicks;
								bool flag3 = elapsedTicks2 < BalancingBudgetMS;
								num4 = 1f;
								if (flag3)
								{
									continue;
								}
								PoolPriority poolPriority4 = _003Cpriority_003E5__6;
								SpawnPool pool4 = poolPriority4.Pool;
								int logLevelAdjust2 = pool4.logLevelAdjust - 1;
								pool4.logLevelAdjust = logLevelAdjust2;
								nint num17 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S0_v222 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
								object obj11 = (nint)0 & (nint)0x200;
								if (obj11 != null)
								{
									nint num18 = (nint)typeof(PoolManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ S0_v237 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								PoolManager._002Ecctor();
								bool flag4 = _003CthisProgress_003E5__2 == null;
								nint num19 = 1;
								if (!flag4)
								{
									float obj12 = _003CbalanceOperation_003E5__4 / _003CtotalBalanceOperations_003E5__3;
									_003CthisProgress_003E5__2(obj12);
									num19 = 0;
								}
								object obj13 = this + 12;
								obj13 = 0;
								_003C_003E1__state = 3;
								num4 = num19;
								obj5 = 80;
								result = 1;
								break;
							}
							nint num20 = (nint)typeof(PoolManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v177 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
							object obj14 = (nint)0 & (nint)0x200;
							if (obj14 != null)
							{
								nint num21 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v184 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							_restartBalancing = true;
							obj5 = 53;
							break;
						}
						continue;
					}
					if ((nint)obj5 == 53)
					{
						PoolPriority poolPriority5 = _003Cpriority_003E5__6;
						SpawnPool pool5 = poolPriority5.Pool;
						float num22 = (float)pool5.logLevelAdjust - 1f;
						pool5.logLevelAdjust = (int)num22;
						nint num23 = (nint)typeof(PoolManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v146 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num24 = (nint)typeof(PoolManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v158 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj16;
						if (~(_forceRestartBalancing ? 1u : 0u) == 0)
						{
							obj16 = 60;
						}
						else
						{
							object obj17 = this + 40;
							obj17 = 0;
							obj16 = 58;
						}
						num4 = 1f;
						obj5 = obj16;
					}
					else if ((nint)obj5 == 72)
					{
						nint num25 = (nint)typeof(PoolManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v92 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
						object obj18 = (nint)0 & (nint)0x200;
						if (obj18 != null)
						{
							nint num26 = (nint)typeof(PoolManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v136 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool restartBalancing = _restartBalancing;
						nint num27 = (nint)typeof(PoolManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S1_v67 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						bool flag5 = obj19 != null;
						if (!restartBalancing)
						{
							if (flag5)
							{
								nint num28 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ S0_v108 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							PoolManager._002Ecctor();
							_balancing = false;
							num4 = 0f;
							obj5 = 80;
							result = null;
							continue;
						}
						if (flag5)
						{
							nint num29 = (nint)typeof(PoolManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ S0_v130 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						_restartBalancing = false;
						_forceRestartBalancing = false;
						object obj20 = this + 16;
						obj20 = _onProgress;
						nint num30 = (nint)typeof(PoolManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v122 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+5C]");
						object obj21 = (nint)0 + (nint)12;
						obj21 = 0;
						StopClock();
						IComparer<PrefabPool> comparer = PrefabPool.comparer;
						_003CtotalBalanceOperations_003E5__3 = (float)comparer;
						_003CbalanceOperation_003E5__4 = 0f;
						_003Ci_003E5__5 = 0;
						num4 = 0f;
						obj5 = 65;
					}
					else if ((nint)obj5 == 80)
					{
						break;
					}
					while (true)
					{
						if ((nint)obj5 == 58)
						{
							int num31 = _003Cj_003E5__7 + 1;
							_003Cj_003E5__7 = num31;
						}
						else
						{
							if ((nint)obj5 == 60)
							{
								nint num32 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S0_v68 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
								object obj22 = (nint)0 & (nint)0x200;
								if (obj22 != null)
								{
									nint num33 = (nint)typeof(PoolManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ S0_v79 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (!_forceRestartBalancing)
								{
									object obj23 = this + 32;
									obj23 = 0;
									float num34 = (float)_003Ci_003E5__5 + 1f;
									_003Ci_003E5__5 = (int)num34;
									num4 = 1f;
									obj5 = 65;
									continue;
								}
								goto IL_1352;
							}
							if ((nint)obj5 == 65)
							{
								nint num35 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S1_v30 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
								object obj24 = (nint)0 & (nint)0x200;
								if (obj24 != null)
								{
									nint num36 = (nint)typeof(PoolManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S1_v47 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								List<PoolPriority> priorities = _priorities;
								bool flag6 = _003Ci_003E5__5 >= priorities._size;
								num4 = 512f;
								if (flag6)
								{
									goto IL_1352;
								}
								nint num37 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S0_v54 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
								object obj25 = (nint)0 & (nint)0x200;
								if (obj25 != null)
								{
									nint num38 = (nint)typeof(PoolManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v61 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								object obj26 = this + 32;
								PoolPriority poolPriority6 = _priorities.get_Item(_003Ci_003E5__5);
								obj26 = poolPriority6;
								_003Cj_003E5__7 = 0;
							}
						}
						PoolPriority poolPriority7 = _003Cpriority_003E5__6;
						LinkedList<PooledInstanceData> spawned = ((PrefabPool)(object)poolPriority7.Pool).spawned;
						if (_003Cj_003E5__7 >= (nint)spawned)
						{
							num4 = 0f;
							obj5 = 60;
							continue;
						}
						object obj27 = this + 40;
						PoolPriority poolPriority8 = _003Cpriority_003E5__6;
						bool flag7 = ((ICollection<Transform>)poolPriority8.Pool).Remove((Transform)_003Cj_003E5__7);
						obj27 = flag7;
						PoolPriority poolPriority9 = _003Cpriority_003E5__6;
						SpawnPool pool6 = poolPriority9.Pool;
						float num39 = (float)pool6.logLevelAdjust + 1f;
						pool6.logLevelAdjust = (int)num39;
						PoolPriority poolPriority10 = _003Cpriority_003E5__6;
						if (~(poolPriority10.IsSpawnPriority ? 1u : 0u) == 0)
						{
							num4 = 1f;
							obj5 = 29;
							break;
						}
						PrefabPool prefabPool7 = _003CprefabPool_003E5__8;
						if (~(prefabPool7.cullDespawned ? 1u : 0u) == 0)
						{
							num4 = 1f;
							obj5 = 51;
							break;
						}
						num4 = 1f;
						obj5 = 58;
						continue;
						IL_1352:
						bool flag8 = _003CthisProgress_003E5__2 == null;
						nint num40 = (nint)num4;
						if (!flag8)
						{
							_003CthisProgress_003E5__2(1f);
							num40 = 0;
						}
						object obj28 = this + 16;
						obj28 = 0;
						num4 = num40;
						obj5 = 72;
						break;
					}
				}
				return result;
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

	public static Action<Transform> OnObjectInstantiated;

	public static readonly SpawnPoolsDict Pools;

	private static bool _balancing;

	private static bool _restartBalancing;

	private static bool _forceRestartBalancing;

	private static Action<float> _onProgress;

	public static int BalancingBudgetMS;

	private static List<PoolPriority> _priorities;

	private static PoolPriorityComparer _comparer;

	private static int _frameCount;

	private static Stopwatch _sw;

	private static Dictionary<Transform, PrefabPool> _prefabPoolLookup;

	private static Dictionary<int, PooledInstanceData> _pooledLookup;

	public static bool Working
	{
		get
		{
			//IL_0049: Expected I4, but got Obj
			//IL_0018: Expected Obj, but got I4
			bool flag = StayInOneLaneMission._instance == null;
			bool flag2 = !flag;
			bool result = (byte)(int)StayInOneLaneMission._instance != 0;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				bool flag3 = default;
				StayInOneLaneMission._instance = (StayInOneLaneMission)flag3;
				result = flag3;
			}
			return result;
		}
	}

	public static void TriggerPoolBalancing(MonoBehaviour coroutineHost = null)
	{
		((Award)(object)coroutineHost).RewardPayedOut();
	}

	public static void BeginBalancing(Action<float> onProgress)
	{
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_022e: Expected I, but got Obj
		//IL_0244: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00fb: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0148: Expected I, but got Obj
		//IL_015e: Expected Obj, but got I
		//IL_0281: Expected Obj, but got I4
		//IL_0189: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Action<float> action;
		if ((UnityEngine.Object)(object)onProgress != null)
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v49 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v55 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IEnumerator enumerator = PoolBalancing();
			action = (Action<float>)(object)enumerator;
		}
		else
		{
			action = onProgress;
		}
		nint num5 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v14 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v41 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_restartBalancing = true;
		if (~(_balancing ? 1u : 0u) == 0)
		{
			return;
		}
		nint num7 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v27 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v35 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_balancing = true;
		int num9 = UpdatePriorityList();
		Coroutine coroutine = ((MonoBehaviour)(object)action).StartCoroutine_Auto((IEnumerator)num9);
	}

	public unsafe static void StartClock()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_2b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b90: Expected Obj, but got Unknown
		//IL_2b99: Expected Obj, but got I4
		//IL_2bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc5: Expected Obj, but got Unknown
		//IL_2bce: Expected Obj, but got I4
		//IL_2be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bee: Expected Obj, but got Unknown
		//IL_2bf7: Expected Obj, but got I4
		//IL_2c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c11: Expected Obj, but got Unknown
		//IL_2c1a: Expected Obj, but got I4
		//IL_2c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c28: Expected Obj, but got Unknown
		//IL_2c31: Expected Obj, but got I4
		//IL_2c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c51: Expected Obj, but got Unknown
		//IL_2c6d: Expected I, but got Obj
		//IL_2c83: Expected Obj, but got I
		//IL_317c: Expected I, but got Obj
		//IL_3192: Expected Obj, but got I
		//IL_3274: Unknown result type (might be due to invalid IL or missing references)
		//IL_3279: Expected Obj, but got Unknown
		//IL_3290: Unknown result type (might be due to invalid IL or missing references)
		//IL_3295: Expected I, but got Unknown
		//IL_32a2: Expected I, but got Obj
		//IL_32bd: Expected I, but got Obj
		//IL_32d3: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_2ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cae: Expected Obj, but got Unknown
		//IL_2cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cbc: Expected Obj, but got Unknown
		//IL_2cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd7: Expected Obj, but got Unknown
		//IL_2ce0: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_025c: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0131: Expected I, but got Obj
		//IL_0147: Expected Obj, but got I
		//IL_2d00: Expected I, but got Obj
		//IL_2d1b: Expected I, but got Obj
		//IL_2d31: Expected Obj, but got I
		//IL_0172: Expected I, but got Obj
		//IL_0316: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I4
		//IL_01bf: Expected I, but got Obj
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected Obj, but got Unknown
		//IL_0602: Expected Obj, but got I
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected Obj, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_31d5: Expected Obj, but got I
		//IL_1276: Expected Obj, but got I
		//IL_0782: Expected I, but got Obj
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected Obj, but got Unknown
		//IL_12ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b1: Expected Obj, but got Unknown
		//IL_1394: Expected Obj, but got I
		//IL_135f: Expected Obj, but got I4
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e7: Expected Obj, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_18a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ae: Expected Obj, but got Unknown
		//IL_0853: Expected I, but got Obj
		//IL_14a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14aa: Expected Obj, but got Unknown
		//IL_3238: Expected I, but got Obj
		//IL_324e: Expected Obj, but got I
		//IL_21b3: Expected Obj, but got I
		//IL_2eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eaf: Expected Obj, but got Unknown
		//IL_2eb8: Expected Obj, but got I4
		//IL_155a: Expected I, but got Obj
		//IL_226b: Expected I, but got Obj
		//IL_21e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ee: Expected Obj, but got Unknown
		//IL_26e4: Expected I, but got Obj
		//IL_26fa: Expected Obj, but got I
		//IL_3011: Unknown result type (might be due to invalid IL or missing references)
		//IL_3016: Expected Obj, but got Unknown
		//IL_301f: Expected Obj, but got I4
		//IL_22b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b9: Expected Obj, but got Unknown
		//IL_22dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e2: Expected Obj, but got Unknown
		//IL_22eb: Expected Obj, but got I4
		//IL_221f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2224: Expected Obj, but got Unknown
		//IL_2725: Expected I, but got Obj
		//IL_26c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c9: Expected Obj, but got Unknown
		//IL_276e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2773: Expected Obj, but got Unknown
		//IL_2797: Unknown result type (might be due to invalid IL or missing references)
		//IL_279c: Expected Obj, but got Unknown
		//IL_27a5: Expected Obj, but got I4
		//IL_22f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fe: Expected Obj, but got Unknown
		//IL_2326: Expected I, but got Obj
		//IL_2333: Expected Obj, but got I
		//IL_234b: Expected I, but got Obj
		//IL_2361: Expected Obj, but got I
		//IL_2b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b69: Expected Obj, but got Unknown
		//IL_238c: Expected I, but got Obj
		//IL_27b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b8: Expected Obj, but got Unknown
		//IL_27e0: Expected I, but got Obj
		//IL_27ed: Expected Obj, but got I
		//IL_2805: Expected I, but got Obj
		//IL_281b: Expected Obj, but got I
		//IL_2670: Expected Obj, but got I
		//IL_2846: Expected I, but got Obj
		//IL_241c: Expected I, but got Obj
		//IL_2432: Expected Obj, but got I
		//IL_16c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c8: Expected Obj, but got Unknown
		//IL_26a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ae: Expected Obj, but got Unknown
		//IL_2f07: Expected Obj, but got I
		//IL_2b10: Expected Obj, but got I
		//IL_245d: Expected I, but got Obj
		//IL_171e: Expected Obj, but got I
		//IL_1741: Unknown result type (might be due to invalid IL or missing references)
		//IL_1746: Expected Obj, but got Unknown
		//IL_28d6: Expected I, but got Obj
		//IL_28ec: Expected Obj, but got I
		//IL_2b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b4e: Expected Obj, but got Unknown
		//IL_306e: Expected Obj, but got I
		//IL_2917: Expected I, but got Obj
		//IL_24ed: Expected I, but got Obj
		//IL_2503: Expected Obj, but got I
		//IL_2f48: Expected Obj, but got I
		//IL_17f7: Expected I, but got Obj
		//IL_252e: Expected I, but got Obj
		//IL_29a7: Expected I, but got Obj
		//IL_29bd: Expected Obj, but got I
		//IL_30af: Expected Obj, but got I
		//IL_29e8: Expected I, but got Obj
		//IL_25be: Expected I, but got Obj
		//IL_25d4: Expected Obj, but got I
		//IL_2f89: Expected Obj, but got I
		//IL_1888: Expected I, but got Obj
		//IL_25ff: Expected I, but got Obj
		//IL_2a5e: Expected I, but got Obj
		//IL_2a74: Expected Obj, but got I
		//IL_30f0: Expected Obj, but got I
		//IL_2a9f: Expected I, but got Obj
		//IL_20a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a6: Expected Obj, but got Unknown
		//IL_20af: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b4: Expected Obj, but got Unknown
		//IL_20e0: Expected Obj, but got I4
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected Obj, but got Unknown
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1151: Expected Obj, but got Unknown
		//IL_117d: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 256;
		object obj3 = obj2 + 204;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 176;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 152;
		obj5 = 0;
		_ = 0;
		_ = 0;
		string text = (string)(obj2 + 144);
		text = (string)0;
		object obj6 = obj2 + 116;
		obj6 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj7 = obj2 + 104;
		obj7 = obj;
		_ = -1;
		nint num = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v38 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v939 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v48 (Il2CppClass<System.Type>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v935 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = obj2 + 112;
		obj10 = typeof(MissionType);
		nint num5 = (nint)(obj2 + 24);
		((IntPtr*)num5)->m_value = (void*)(nint)obj10;
		Type enumType = Type.internal_from_handle((IntPtr)num5);
		nint num6 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v39 (Il2CppClass<System.Enum>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num7 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v534 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = obj2 + 96;
		object key = obj2 + 72;
		string[] array = Enum.InternalGetNames((System.RuntimeType)enumType);
		object obj13 = array + 12;
		object obj14 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13))
		{
			object obj15 = array + 16;
			object obj16 = obj14 << 2;
			object value = obj15 + obj16;
			nint num8 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v905 (Il2CppClass<System.Type>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num9 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v931 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj12 = typeof(MissionType);
			((IntPtr*)num5)->m_value = (void*)(nint)obj12;
			Type enumType2 = Type.internal_from_handle((IntPtr)num5);
			nint num10 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v914 (Il2CppClass<System.Enum>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num11 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v927 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string name = Enum.GetName(enumType2, value);
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A427");
		obj3 = (object)((IntPtr*)num5)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+28]");
		_ = 0;
		object obj19 = default;
		object obj21 = default;
		void* value2 = default;
		object obj23 = default;
		object obj26 = default;
		object obj28 = default;
		object obj29 = default;
		object obj30 = default;
		object obj31 = default;
		void* value3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj19 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = (object)((IntPtr*)num5)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+15]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+14]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					object obj20 = obj21 + 16;
					obj20 = "completeIfLess misisons needs to be singlerun, ";
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					((IntPtr*)num5)->m_value = value2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					object obj22 = obj21 + 20;
					obj22 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					object obj24 = obj21 + 24;
					obj24 = " ";
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					key = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					object obj25 = obj21 + 28;
					obj25 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj5 = (object)((IntPtr*)num5)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+10]");
			_ = 0;
			object obj27 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj27 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			text = (string)obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			text = (string)obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			bool flag = obj31 == null;
			nint num12 = unchecked((nint)null);
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+14]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					((IntPtr*)num5)->m_value = value3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					num12 = unchecked((nint)null);
				}
			}
		}
		object obj32 = 90;
		object obj33 = obj32 - 27;
		object obj34;
		object obj36;
		object obj37 = default;
		string text2;
		if ((nint)obj32 != 27 && (nint)obj33 != 1)
		{
			if ((nint)obj33 == 2 || (nint)obj33 == 3 || (nint)obj33 == 4)
			{
				goto IL_2b77;
			}
			if ((nint)obj33 != 5)
			{
				if ((nint)obj33 == 6 || (nint)obj33 == 7 || (nint)obj33 == 8 || (nint)obj33 == 9 || (nint)obj33 == 10 || (nint)obj33 == 11 || (nint)obj33 == 12 || (nint)obj33 == 13 || (nint)obj33 == 14 || (nint)obj33 == 15 || (nint)obj33 == 16 || (nint)obj33 == 17 || (nint)obj33 == 18 || (nint)obj33 == 19 || (nint)obj33 == 20 || (nint)obj33 == 21 || (nint)obj33 == 22 || (nint)obj33 == 23 || (nint)obj33 == 24 || (nint)obj33 == 25 || (nint)obj33 == 26 || (nint)obj33 == 27)
				{
					goto IL_2b77;
				}
				if ((nint)obj33 != 28)
				{
					if ((nint)obj33 != 29)
					{
						if ((nint)obj33 != 30)
						{
							if ((nint)obj33 != 31)
							{
								if ((nint)obj33 != 32)
								{
									if ((nint)obj33 != 33)
									{
										if ((nint)obj33 != 34 && (nint)obj33 != 35)
										{
											if ((nint)obj33 == 36 || (nint)obj33 == 37 || (nint)obj33 == 38)
											{
												goto IL_2b77;
											}
											if ((nint)obj33 != 39 && (nint)obj33 != 40 && (nint)obj33 != 41 && (nint)obj33 != 42 && (nint)obj33 != 43 && (nint)obj33 != 44 && (nint)obj33 != 45)
											{
												if ((nint)obj33 == 46 || (nint)obj33 == 47 || (nint)obj33 == 48)
												{
													goto IL_2b77;
												}
												if ((nint)obj33 != 49)
												{
													if ((nint)obj33 == 50 || (nint)obj33 == 51 || (nint)obj33 == 52 || (nint)obj33 == 53 || (nint)obj33 == 54 || (nint)obj33 == 55 || (nint)obj33 == 56 || (nint)obj33 == 57)
													{
														goto IL_2b77;
													}
													if ((nint)obj33 != 58)
													{
														if ((nint)obj33 != 59 && (nint)obj33 != 60)
														{
															if ((nint)obj33 != 61)
															{
																if ((nint)obj33 == 62)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj35 = default;
																	obj34 = obj35;
																	obj36 = obj37;
																	goto IL_2e27;
																}
																if ((nint)obj33 == 63)
																{
																	object obj38 = obj7 + 4;
																	object obj39 = obj38 + 1;
																	obj38 = obj39;
																	object obj40 = obj39 << 2;
																	object obj41 = obj7 + obj40;
																	obj41 = 334;
																	text2 = null;
																	goto IL_123b;
																}
															}
															goto IL_2b77;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj42 = default;
														obj34 = obj42;
														obj36 = obj37;
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj43 = default;
														obj34 = obj43;
														obj36 = obj37;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj44 = default;
													obj34 = obj44;
													obj36 = obj37;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj45 = default;
												obj34 = obj45;
												obj36 = obj37;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj46 = default;
											obj34 = obj46;
											obj36 = obj37;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj47 = default;
										obj34 = obj47;
										obj36 = obj37;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj48 = default;
									obj34 = obj48;
									obj36 = obj37;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj49 = default;
								obj34 = obj49;
								obj36 = obj37;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj50 = default;
							obj34 = obj50;
							obj36 = obj37;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj51 = default;
						obj34 = obj51;
						obj36 = obj37;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj52 = default;
					obj34 = obj52;
					obj36 = obj37;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj53 = default;
				obj34 = obj53;
				obj36 = obj37;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj54 = default;
			obj34 = obj54;
			obj36 = obj37;
		}
		goto IL_2e27;
		IL_2e27:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj55 = default;
		if (obj36 == obj55)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj56 = default;
			text2 = (string)obj56;
			goto IL_123b;
		}
		object obj57 = obj34;
		goto IL_2b77;
		IL_2e67:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj58;
		object obj59 = default;
		object obj60;
		if (obj58 != obj59)
		{
			obj57 = obj60;
			goto IL_2b77;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		object obj61 = default;
		string text3 = (string)obj61;
		goto IL_2178;
		IL_2b77:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		return;
		IL_31be:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A427");
		obj3 = (object)((IntPtr*)num5)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+28]");
		_ = 0;
		object obj62 = default;
		object obj63 = default;
		object obj64 = default;
		object obj66 = default;
		object obj67 = default;
		object obj68 = default;
		object obj69 = default;
		object obj70 = default;
		object obj71 = default;
		object obj73 = default;
		object obj75 = default;
		object obj76 = default;
		void* value4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj62 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj6 = (object)((IntPtr*)num5)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			text = (string)obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			text = (string)obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj65 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj65 = obj66;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			bool flag2 = obj67 == null;
			nint num12 = unchecked((nint)null);
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				text = (string)obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				text = (string)obj69;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				text = (string)obj70;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				text = (string)obj71;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj72 = obj73 - 9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj5 = (object)((IntPtr*)num5)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v55 (System.IntPtr)+10]");
				_ = 0;
				object obj74 = obj5 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				obj74 = obj75;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				bool flag3 = obj76 == null;
				num12 = unchecked((nint)null);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					((IntPtr*)num5)->m_value = value4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					num12 = unchecked((nint)null);
				}
			}
		}
		object obj77 = 162;
		object obj78 = obj77 - 110;
		if ((nint)obj77 != 110)
		{
			if ((nint)obj78 != 1)
			{
				if ((nint)obj78 != 2)
				{
					if ((nint)obj78 != 3)
					{
						if ((nint)obj78 != 4 && (nint)obj78 != 5 && (nint)obj78 != 6 && (nint)obj78 != 7)
						{
							if ((nint)obj78 == 8 || (nint)obj78 == 9 || (nint)obj78 == 10 || (nint)obj78 == 11 || (nint)obj78 == 12 || (nint)obj78 == 13 || (nint)obj78 == 14 || (nint)obj78 == 15 || (nint)obj78 == 16 || (nint)obj78 == 17 || (nint)obj78 == 18 || (nint)obj78 == 19 || (nint)obj78 == 20 || (nint)obj78 == 21 || (nint)obj78 == 22 || (nint)obj78 == 23 || (nint)obj78 == 24 || (nint)obj78 == 25)
							{
								goto IL_2178;
							}
							if ((nint)obj78 != 26)
							{
								if ((nint)obj78 != 27)
								{
									if ((nint)obj78 != 28)
									{
										if ((nint)obj78 != 29)
										{
											if ((nint)obj78 != 30)
											{
												if ((nint)obj78 != 31)
												{
													if ((nint)obj78 != 32)
													{
														if ((nint)obj78 != 33)
														{
															if ((nint)obj78 != 34 && (nint)obj78 != 35 && (nint)obj78 != 36 && (nint)obj78 != 37)
															{
																if ((nint)obj78 == 38 || (nint)obj78 == 39 || (nint)obj78 == 40 || (nint)obj78 == 41 || (nint)obj78 == 42 || (nint)obj78 == 43 || (nint)obj78 == 44 || (nint)obj78 == 45 || (nint)obj78 == 46)
																{
																	goto IL_2178;
																}
																if ((nint)obj78 != 47)
																{
																	if ((nint)obj78 != 48 && (nint)obj78 != 49)
																	{
																		if ((nint)obj78 != 50)
																		{
																			if ((nint)obj78 == 51)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																				object obj79 = default;
																				obj60 = obj79;
																				obj58 = obj37;
																				goto IL_2e67;
																			}
																			if ((nint)obj78 == 52)
																			{
																				object obj80 = obj7 + 4;
																				object obj81 = obj80 + 1;
																				obj80 = obj81;
																				object obj82 = obj81 << 2;
																				object obj83 = obj7 + obj82;
																				obj83 = 561;
																				text3 = text2;
																			}
																		}
																		goto IL_2178;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj84 = default;
																	obj60 = obj84;
																	obj58 = obj37;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	object obj85 = default;
																	obj60 = obj85;
																	obj58 = obj37;
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																object obj86 = default;
																obj60 = obj86;
																obj58 = obj37;
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj87 = default;
															obj60 = obj87;
															obj58 = obj37;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj88 = default;
														obj60 = obj88;
														obj58 = obj37;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj89 = default;
													obj60 = obj89;
													obj58 = obj37;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj90 = default;
												obj60 = obj90;
												obj58 = obj37;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj91 = default;
											obj60 = obj91;
											obj58 = obj37;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj92 = default;
										obj60 = obj92;
										obj58 = obj37;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj93 = default;
									obj60 = obj93;
									obj58 = obj37;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj94 = default;
								obj60 = obj94;
								obj58 = obj37;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj95 = default;
							obj60 = obj95;
							obj58 = obj37;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj96 = default;
						obj60 = obj96;
						obj58 = obj37;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj97 = default;
					obj60 = obj97;
					obj58 = obj37;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj98 = default;
				obj60 = obj98;
				obj58 = obj37;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj99 = default;
			obj60 = obj99;
			obj58 = obj37;
		}
		goto IL_2e67;
		IL_2178:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v35+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v35+4]");
			object obj100 = (nint)0 << 2;
			object obj101 = obj7 + obj100;
			if ((nint)obj101 == 561)
			{
				object obj102 = obj7 + 4;
				if ((nint)obj102 > -1)
				{
					object obj103 = obj102 + -1;
					obj102 = obj103;
				}
				goto IL_322a;
			}
		}
		if (text3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_322a;
		IL_123b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v35+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v35+4]");
			object obj104 = (nint)0 << 2;
			object obj105 = obj7 + obj104;
			if ((nint)obj105 == 334)
			{
				object obj106 = obj7 + 4;
				if ((nint)obj106 > -1)
				{
					object obj107 = obj106 + -1;
					obj106 = obj107;
				}
				goto IL_31be;
			}
		}
		if (text2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_31be;
		IL_322a:
		nint num13 = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ S0_v125 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj108 = (nint)0 & (nint)0x200;
		if (obj108 != null)
		{
			nint num14 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1565 @ S0_v305 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj109 = MissionsData.repeatableMissions + 12;
		object obj110 = 0;
		string text9 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj110) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj109))
		{
			object obj111 = MissionsData.repeatableMissions + 16;
			object obj112 = obj110 << 2;
			object obj113 = obj111 + obj112;
			object obj114 = obj113 + 12;
			object obj123;
			for (object obj115 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj115) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj114); obj123 = obj115 + 1, obj115 = obj123)
			{
				object obj116 = obj113 + 16;
				object obj117 = obj115 << 3;
				object obj118 = obj116 + obj117;
				((IntPtr*)num5)->m_value = (void*)(nint)obj118;
				obj2 = (object)((IntPtr*)num5)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
				nint num15 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1794 @ S0_v248 (Il2CppClass<Strings>)+BA]");
				object obj119 = (nint)0 & (nint)0x200;
				if (obj119 != null)
				{
					nint num16 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1825 @ S0_v301 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text4 = Strings.GetDefault((string)key);
				if (text4 != null && text4.m_stringLength != 0)
				{
					((IntPtr*)num5)->m_value = ((IntPtr*)num5)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
					nint num17 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1980 @ S1_v200 (Il2CppClass<Strings>)+BA]");
					object obj120 = (nint)0 & (nint)0x200;
					if (obj120 != null)
					{
						nint num18 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2008 @ S1_v228 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
					string text5 = Strings.GetDefault((string)0);
					if (text5 != null && text5.m_stringLength != 0)
					{
						((IntPtr*)num5)->m_value = ((IntPtr*)num5)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
						nint num19 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2139 @ S1_v208 (Il2CppClass<Strings>)+BA]");
						object obj121 = (nint)0 & (nint)0x200;
						if (obj121 != null)
						{
							nint num20 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2155 @ S1_v224 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						string text6 = Strings.GetDefault((string)0);
						if (text6 != null && text6.m_stringLength != 0)
						{
							((IntPtr*)num5)->m_value = ((IntPtr*)num5)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
							nint num21 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2237 @ S1_v216 (Il2CppClass<Strings>)+BA]");
							object obj122 = (nint)0 & (nint)0x200;
							if (obj122 != null)
							{
								nint num22 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2256 @ S1_v221 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
							string text7 = Strings.GetDefault((string)0);
							if (text7 != null && text7.m_stringLength != 0)
							{
								continue;
							}
						}
					}
				}
				((IntPtr*)num5)->m_value = ((IntPtr*)num5)->m_value;
				obj2 = (object)((IntPtr*)num5)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text8 = "no description for repeatableMission: " + text9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
			}
			object obj124 = obj110 + 1;
			obj110 = obj124;
		}
		nint num23 = (nint)typeof(MissionsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1660 @ S0_v138 (Il2CppClass<Missions.MissionsData>)+BA]");
		object obj125 = (nint)0 & (nint)0x200;
		if (obj125 != null)
		{
			nint num24 = (nint)typeof(MissionsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1709 @ S0_v225 (Il2CppClass<Missions.MissionsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj126 = MissionsData.storylineMissions + 12;
		object obj127 = 0;
		string text15 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj127) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj126))
		{
			object obj128 = MissionsData.storylineMissions + 16;
			object obj129 = obj127 << 2;
			object obj130 = obj128 + obj129;
			object obj131 = obj130 + 12;
			object obj140;
			for (object obj132 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj132) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj131); obj140 = obj132 + 1, obj132 = obj140)
			{
				object obj133 = obj130 + 16;
				object obj134 = obj132 << 3;
				object obj135 = obj133 + obj134;
				((IntPtr*)num5)->m_value = (void*)(nint)obj135;
				obj2 = (object)((IntPtr*)num5)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
				nint num25 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1900 @ S0_v168 (Il2CppClass<Strings>)+BA]");
				object obj136 = (nint)0 & (nint)0x200;
				if (obj136 != null)
				{
					nint num26 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ S0_v221 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text10 = Strings.GetDefault((string)key);
				if (text10 != null && text10.m_stringLength != 0)
				{
					((IntPtr*)num5)->m_value = ((IntPtr*)num5)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
					nint num27 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2084 @ S1_v140 (Il2CppClass<Strings>)+BA]");
					object obj137 = (nint)0 & (nint)0x200;
					if (obj137 != null)
					{
						nint num28 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2105 @ S1_v167 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
					string text11 = Strings.GetDefault((string)0);
					if (text11 != null && text11.m_stringLength != 0)
					{
						((IntPtr*)num5)->m_value = ((IntPtr*)num5)->m_value;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
						nint num29 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2195 @ S1_v148 (Il2CppClass<Strings>)+BA]");
						object obj138 = (nint)0 & (nint)0x200;
						if (obj138 != null)
						{
							nint num30 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2205 @ S1_v164 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						string text12 = Strings.GetDefault((string)0);
						if (text12 != null && text12.m_stringLength != 0)
						{
							((IntPtr*)num5)->m_value = ((IntPtr*)num5)->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A42B");
							nint num31 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2288 @ S1_v156 (Il2CppClass<Strings>)+BA]");
							object obj139 = (nint)0 & (nint)0x200;
							if (obj139 != null)
							{
								nint num32 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2296 @ S1_v161 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
							string text13 = Strings.GetDefault((string)0);
							if (text13 != null && text13.m_stringLength != 0)
							{
								continue;
							}
						}
					}
				}
				((IntPtr*)num5)->m_value = ((IntPtr*)num5)->m_value;
				obj2 = (object)((IntPtr*)num5)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text14 = "no description for missions: " + text15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
			}
			object obj141 = obj127 + 1;
			obj127 = obj141;
		}
	}

	public static void StopClock()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_01c6: Expected I8, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int renderedFrameCount = Time.renderedFrameCount;
		if (_frameCount != renderedFrameCount)
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v30 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v43 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Stopwatch sw = _sw;
			sw.elapsed = 0L;
			sw.is_running = false;
			int renderedFrameCount2 = Time.renderedFrameCount;
			_frameCount = renderedFrameCount2;
		}
		nint num5 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v16 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v23 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_sw.Stop();
	}

	public static void RegisterInstance(PooledInstanceData instanceData)
	{
		//IL_011d: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_0150: Expected I, but got Obj
		//IL_018f: Expected Obj, but got I
		//IL_008f: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_00d0: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(PoolManager);
		if (!flag)
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(PoolManager);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(PoolManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = instanceData;
		((Action<float>)(object)instanceData)?.Invoke(0f);
		nint num4 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v16 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v26 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_forceRestartBalancing = true;
		_restartBalancing = true;
		BeginBalancing(null);
	}

	public static void UnregisterInstance(PooledInstanceData instanceData)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0150: Expected Obj, but got I
		//IL_0160: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S4_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v4+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v4 (should have been resolved before IL gen)");
		if (OnObjectInstantiated == null)
		{
			return;
		}
		nint num4 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v20 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v27 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnObjectInstantiated(instanceData.transform__BackingField);
	}

	public static PooledInstanceData GetInstanceData(Transform instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_028e: Expected Obj, but got I4
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected Obj, but got Unknown
		//IL_02be: Expected I, but got Obj
		//IL_02d4: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0339: Expected Obj, but got I4
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v97 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		PooledInstanceData result = default;
		PooledInstanceData pooledInstanceData = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v80 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v90 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 != null)
			{
				result = (PooledInstanceData)(pooledInstanceData + 1);
			}
		}
		object obj9 = obj4 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj4 + obj11;
		obj12 = 58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj4 + obj13;
			if ((nint)obj14 == 58)
			{
				object obj15 = obj4 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				goto IL_03aa;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03aa;
		IL_03aa:
		return result;
	}

	public static Transform Spawn(Transform prefab)
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object result = 0;
		int hashCode = prefab.GetHashCode();
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v22 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		return (Transform)result;
	}

	private static SpawnPool GetDefaultSpawnPool()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool balancing = _balancing;
		return (SpawnPool)balancing;
	}

	public static void Despawn(Transform instance)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<int, PooledInstanceData> pooledLookup = _pooledLookup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [instance @ L0 (UnityEngine.Transform)+10]");
		bool flag = pooledLookup.Remove(0);
	}

	private static IEnumerator PoolBalancing()
	{
		//IL_00a7: Expected Obj, but got I4
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_0077: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0099: Expected I, but got Obj
		//IL_005a: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		Transform transform = (Transform)0;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v27 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform2 = ((SpawnPool)(object)Pools).Spawn((Transform)(object)"Default", transform);
		nint num3;
		if ((object)transform2 != null)
		{
			num3 = (nint)transform;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"DefaultPool";
			SpawnPool spawnPool = gameObject.AddComponent<SpawnPool>();
			transform = (Transform)(object)spawnPool;
			num3 = (nint)spawnPool;
		}
		return (IEnumerator)num3;
	}

	private static int UpdatePriorityList()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int result = default;
		return result;
	}

	public static void AddPool(PrefabPool prefabPool)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00c5: Expected I4, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = Spawn((Transform)(object)prefabPool);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (UnityEngine.Transform)+18]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12+24]");
		((SpawnPool)0).RemoveAt((int)prefabPool);
	}

	public unsafe static PrefabPool GetPrefabPool(Transform prefab)
	{
		//IL_0128: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00bc: Expected I, but got Obj
		ref PrefabPool reference = ref *(PrefabPool*)null;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v34 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SpawnPool spawnPool;
		if (_prefabPoolLookup.TryGetValue(prefab, out reference))
		{
			PrefabPool prefabPool = reference;
			spawnPool = prefabPool.spawnPool;
		}
		else
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v27 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IEnumerator enumerator = PoolBalancing();
			spawnPool = (SpawnPool)(object)enumerator;
		}
		return (PrefabPool)(object)spawnPool.Spawn((GameObject)(object)prefab);
	}

	public unsafe static bool PrefabPoolExists(Transform prefab)
	{
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_013d: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		ref PrefabPool reference = ref *(PrefabPool*)null;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v33 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool;
		if (_prefabPoolLookup.TryGetValue(prefab, out reference))
		{
			prefabPool = reference;
		}
		else
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v27 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IEnumerator enumerator = PoolBalancing();
			PrefabPool prefabPool2 = ((SpawnPool)(object)enumerator).GetPrefabPool((GameObject)(object)prefab);
			reference = ref *(PrefabPool*)prefabPool2;
			prefabPool = prefabPool2;
		}
		return (byte)(int)prefabPool != 0;
	}

	public static void Remove(SpawnPool spawnPool)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S4_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v4+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v46 @ S5_v4 (should have been resolved before IL gen)");
	}

	static PoolManager()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((ArrayConverter)(object)_sw)._002Ector();
	}
}
