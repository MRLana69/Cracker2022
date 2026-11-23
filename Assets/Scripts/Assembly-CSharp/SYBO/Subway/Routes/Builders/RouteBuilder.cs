using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Exceptions;
using SYBO.Common.Math;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Routes.Builders.Worker;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Routes.Builders;

[Serializable]
public abstract class RouteBuilder
{
	private struct BuildDirective
	{
		public readonly int PositionZ;

		public readonly bool IsApplicablePositionStrict;

		public readonly RouteSection Section;

		public readonly SectionSpawnMode SectionSpawnMode;

		public readonly ChunkBuildMode ChunkBuildMode;

		public bool HasSection => Section != null;

		public BuildDirective(int positionZ, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, bool isApplicablePositionStrict = true, RouteSection section = null)
		{
			Section = section;
			PositionZ = positionZ;
			ChunkBuildMode = chunkBuildMode;
			SectionSpawnMode = sectionSpawnMode;
			IsApplicablePositionStrict = isApplicablePositionStrict;
		}

		public override string ToString()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			_ = PositionZ;
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
	}

	[Serializable]
	public class EnvironmentKindRepeatConfig
	{
		public EnvironmentKind EnvironmentKind;

		public int RepeatDistance;

		public void Validate()
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_007a: Expected Obj, but got I4
			object obj = this + 8;
			EnvironmentKind environmentKind = EnvironmentKind;
			object obj2 = environmentKind._type - 1;
			EnvironmentKind environmentKind2;
			if ((nint)obj2 < 2)
			{
				if (EnvironmentKind.IsValidDensity((EnvironmentKind)obj))
				{
					goto IL_00a2;
				}
				environmentKind2 = ((EnvironmentKind)obj).GetValidated();
			}
			else
			{
				environmentKind2 = EnvironmentKind.None;
			}
			obj = environmentKind2;
			goto IL_00a2;
			IL_00a2:
			int num = RepeatDistance / 180;
			int repeatDistance = num * 180;
			RepeatDistance = repeatDistance;
		}

		public EnvironmentKindRepeatConfig()
		{
			EnvironmentKind none = EnvironmentKind.None;
			EnvironmentKind = none;
			RepeatDistance = 2160;
		}
	}

	[Serializable]
	public class TransitionSectionInfo
	{
		public RouteType TransitionRouteType;

		public RouteSection Section;
	}

	private class EnvironmentRangeWrapper
	{
		public EnvironmentKind EnvironmentKind;

		public float StartPositionZ;

		public float EndPositionZ;

		public EnvironmentRangeWrapper(EnvironmentKind kind, float startPositionZ, float endPositionZ)
		{
			EnvironmentKind none = EnvironmentKind.None;
			EnvironmentKind = none;
			EnvironmentKind = kind;
			EndPositionZ = endPositionZ;
			StartPositionZ = startPositionZ;
		}
	}

	private sealed class _003CPerformSelectionAndActivationASync_003Ed__151(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteBuilder _003C_003E4__this;

		public RouteChunk chunk;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			bool result;
			int num;
			int num2;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					bool flag = _003C_003E1__state == 2;
					result = false;
					num = -1;
					if (flag)
					{
						goto IL_00e7;
					}
					result = false;
					goto IL_00f6;
				}
				_003C_003E1__state = -1;
				IEnumerator enumerator = chunk.ActivateTrackObjectsASync();
				_003C_003E2__current = enumerator;
				num2 = 2;
			}
			else
			{
				_003C_003E1__state = -1;
				IEnumerator enumerator2 = _003C_003E4__this.PerformSelectionASync(chunk);
				_003C_003E2__current = enumerator2;
				num2 = 1;
			}
			result = true;
			num = num2;
			goto IL_00e7;
			IL_00e7:
			_003C_003E1__state = num;
			goto IL_00f6;
			IL_00f6:
			return result;
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

	private sealed class _003CDespawnRouteChunkASync_003Ed__182(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteChunk chunk;

		public RouteBuilder _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						RouteBuilder routeBuilder = _003C_003E4__this;
						if (routeBuilder._routeHeight == RouteHeight.Pos1)
						{
							GameObject gameObject = chunk.gameObject;
							UnityEngine.Object.Destroy(gameObject);
						}
						else
						{
							Transform transform = chunk.transform;
							PoolManager.Despawn(transform);
						}
						RouteChunk routeChunk = chunk;
						routeChunk._section.RemoveSpawnedChunk(chunk);
					}
					return false;
				}
				_003C_003E1__state = -1;
				IEnumerator enumerator = chunk.Destruct();
				_003C_003E2__current = enumerator;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			IEnumerator enumerator2 = chunk.DeactivateTrackObjects();
			_003C_003E2__current = enumerator2;
			_003C_003E1__state = 1;
			return true;
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

	private sealed class _003CPerformSelectionASync_003Ed__188(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteBuilder _003C_003E4__this;

		public RouteChunk chunk;

		private List<Selector> _003CspawnPoints_003E5__2;

		private List<GameObject> _003CobjectsToVisit_003E5__3;

		private List<Selector>.Enumerator _003C_003E7__wrap3;

		private List<GameObject>.Enumerator _003C_003E7__wrap4;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_009c: Expected Obj, but got I4
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected Obj, but got Unknown
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected Obj, but got Unknown
			//IL_004d: Expected Obj, but got I4
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected Obj, but got Unknown
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			if (_003C_003E1__state <= -3)
			{
				object obj3 = _003C_003E1__state + 4;
				if (obj3 != null)
				{
					if ((nint)obj3 != 1)
					{
						return;
					}
					goto IL_00dd;
				}
			}
			else
			{
				object obj4 = _003C_003E1__state - 3;
				if (_003C_003E1__state == 3)
				{
					goto IL_00dd;
				}
				if ((nint)obj4 != 1)
				{
					return;
				}
			}
			object obj5 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = obj + 20;
			object obj7 = obj6;
			((_003CPerformSelectionASync_003Ed__188)obj7)._003C_003Em__Finally2();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @254");
			}
			return;
			IL_00dd:
			object obj8 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj9 = obj + 20;
			object obj10 = obj9;
			((_003CPerformSelectionASync_003Ed__188)obj10)._003C_003Em__Finally1();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @254");
			}
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0acc: Expected Obj, but got Unknown
			//IL_0af4: Expected Obj, but got I
			//IL_0b04: Expected Obj, but got I
			//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a55: Expected Obj, but got Unknown
			//IL_0385: Expected Obj, but got I
			//IL_0395: Expected Obj, but got I
			//IL_0c09: Expected Obj, but got I
			//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b37: Expected Obj, but got Unknown
			//IL_019d: Expected Obj, but got I
			//IL_03e0: Expected Obj, but got I
			//IL_03f5: Expected Obj, but got I
			//IL_049e: Expected Obj, but got I
			//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5a: Expected Obj, but got Unknown
			//IL_04fb: Expected Obj, but got I
			//IL_0523: Expected Obj, but got I
			//IL_0580: Expected Obj, but got I
			//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bae: Expected Obj, but got Unknown
			//IL_0248: Expected Obj, but got I
			//IL_025d: Expected Obj, but got I
			//IL_026d: Expected Obj, but got I
			//IL_06ef: Expected Obj, but got I
			//IL_08b1: Expected Obj, but got I
			//IL_02b8: Expected Obj, but got I
			//IL_02cd: Expected Obj, but got I
			//IL_05e7: Expected Obj, but got I
			//IL_0601: Expected Obj, but got I
			//IL_08fc: Expected Obj, but got I
			//IL_0912: Expected Obj, but got I
			//IL_0757: Expected Obj, but got I
			//IL_0671: Expected Obj, but got I
			//IL_0699: Expected Obj, but got I
			//IL_0802: Expected Obj, but got I
			//IL_0818: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 48;
			object obj3 = obj + 44;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
			object obj6;
			object obj7;
			object obj8;
			bool result = default;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
					if ((nint)0 != 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
						if ((nint)0 != 3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
							if ((nint)0 != 4)
							{
								obj6 = obj;
								goto IL_0b29;
							}
							_ = -4;
							obj7 = obj4;
							goto IL_0b9a;
						}
						_ = -3;
						obj8 = obj4;
						goto IL_0b46;
					}
					_ = -1;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj9 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							_ = -3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							obj8 = 0;
							goto IL_0b46;
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
					_ = -1;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v139+14]");
						object obj12 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj14 = 0;
							_ = 2;
							result = true;
							obj6 = obj;
							goto IL_0b29;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						result = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
			}
			else
			{
				_ = -1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = false;
					if (!flag)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag2 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						result = false;
						if (!flag2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj15 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag3 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							result = false;
							if (!flag3)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag4 = (nint)0 == 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								result = false;
								if (!flag4)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
									object obj16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
									object obj17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ S0_v104+14]");
									object obj18 = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
										object obj19 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
										object obj20 = 0;
										_ = 1;
										result = true;
										obj6 = obj;
										goto IL_0b29;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									result = false;
									goto IL_096c;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_096c;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			goto IL_096c;
			IL_0b9a:
			_ = 0;
			object obj21 = obj7 + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = default;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				result = flag5;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj22 = 0;
				if (!flag5)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 == 1;
					result = false;
					if (flag6)
					{
						goto IL_0853;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj23 = (nint)0 + (nint)48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					result = false;
					obj6 = obj;
					goto IL_0b29;
				}
				_ = 0;
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
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj24 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj25 = 0;
						_ = 4;
						result = true;
						obj6 = obj;
						goto IL_0b29;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				result = false;
			}
			goto IL_096c;
			IL_096c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj26 = default;
			object obj27 = default;
			bool flag7 = obj26 == obj27;
			bool flag8 = !flag7;
			object obj29 = default;
			object obj28 = obj29;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag9 = (nint)0 != 1;
				result = false;
				obj6 = obj;
				if (flag9)
				{
					goto IL_0b29;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = false;
				object obj30 = default;
				obj28 = obj30;
			}
			_ = 0;
			object obj31 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			goto IL_0b29;
			IL_0b46:
			_ = 0;
			object obj32 = obj8 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag10 = default;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				result = flag10;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj33 = 0;
				if (!flag10)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag11 = (nint)0 == 1;
					result = flag10;
					if (flag11)
					{
						goto IL_0853;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj34 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj35 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						_ = -4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						obj7 = 0;
						goto IL_0b9a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					result = flag10;
				}
				else
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj37 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj38 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj39 = 0;
							_ = 3;
							result = true;
							obj6 = obj;
							goto IL_0b29;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S0_v236+1C]");
						result = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						result = false;
					}
				}
			}
			goto IL_096c;
			IL_0b29:
			object obj40 = obj6 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3C4");
			return result;
			IL_0853:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_096c;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -1;
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

	private sealed class _003CRecursiveSelectionASync_003Ed__189(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public List<GameObject> objectsToVisit;

		public List<Selector> selectors;

		public RouteBuilder _003C_003E4__this;

		public List<Selector> spawnPoints;

		private List<Selector>.Enumerator _003C_003E7__wrap1;

		private List<Selector> _003CsubSelectors_003E5__3;

		private List<GameObject>.Enumerator _003C_003E7__wrap3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0020: Expected Obj, but got I4
			//IL_0042: Expected Obj, but got I4
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected Obj, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected Obj, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected Obj, but got Unknown
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 32;
			object obj3 = _003C_003E1__state + 4;
			bool flag = (nint)obj3 >= 2;
			object obj4 = _003C_003E1__state - 1;
			if ((nint)obj4 <= 1)
			{
				flag = false;
			}
			if (flag)
			{
				return;
			}
			object obj5 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			bool flag2 = _003C_003E1__state != 1;
			if (_003C_003E1__state == -4)
			{
				flag2 = false;
			}
			if (!flag2)
			{
				object obj6 = obj + 28;
				obj = obj6;
				_ = 0;
				_ = 0;
				object obj7 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					object obj8 = default;
					object obj9 = default;
					bool flag3 = obj8 != obj9;
					object obj11 = default;
					object obj10 = obj11;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							goto IL_01dd;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						object obj12 = default;
						obj10 = obj12;
					}
					_ = 0;
					object obj13 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return;
				}
			}
			goto IL_01dd;
			IL_01dd:
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3C2");
		}

		private bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa7: Expected Obj, but got Unknown
			//IL_0acf: Expected Obj, but got I
			//IL_0adf: Expected Obj, but got I
			//IL_00bd: Expected Obj, but got I
			//IL_0647: Unknown result type (might be due to invalid IL or missing references)
			//IL_064c: Expected Obj, but got Unknown
			//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a30: Expected Obj, but got Unknown
			//IL_0128: Expected Obj, but got I
			//IL_014a: Expected Obj, but got I
			//IL_06b3: Expected Obj, but got I
			//IL_0b98: Expected Obj, but got I
			//IL_0b3d: Expected Obj, but got I
			//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b12: Expected Obj, but got Unknown
			//IL_01af: Expected Obj, but got I
			//IL_071a: Expected Obj, but got I
			//IL_0734: Expected Obj, but got I
			//IL_083c: Expected Obj, but got I
			//IL_08f6: Expected Obj, but got I
			//IL_090c: Expected Obj, but got I
			//IL_0792: Expected Obj, but got I
			//IL_07a7: Expected Obj, but got I
			//IL_0502: Expected Obj, but got I
			//IL_0517: Expected Obj, but got I
			//IL_0570: Expected Obj, but got I
			//IL_05cd: Expected Obj, but got I
			//IL_05f5: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 48;
			object obj3 = obj + 44;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
			object obj6;
			object obj7;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12+8]");
					if ((nint)0 != 2)
					{
						obj6 = obj;
						goto IL_0b04;
					}
					_ = 0;
					_ = -3;
					goto IL_0b21;
				}
				_ = -4;
				obj7 = obj4;
				goto IL_0638;
			}
			_ = -1;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj10 = 0;
					_ = -3;
					goto IL_0b21;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0947;
			IL_04c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			bool flag = default;
			bool result = flag;
			goto IL_0947;
			IL_048e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			result = false;
			goto IL_0947;
			IL_0638:
			_ = 0;
			object obj11 = obj7 + 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = default;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				result = flag2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj12 = 0;
				if (!flag2)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 == 1;
					result = flag2;
					if (flag3)
					{
						goto IL_086b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj13 = (nint)0 + (nint)52;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj14 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj16 = 0;
						_ = 2;
						result = true;
						obj6 = obj;
						goto IL_0b04;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = false;
				}
				else
				{
					_ = 0;
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
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj17 = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj18 = 0;
							_ = 1;
							result = true;
							obj6 = obj;
							goto IL_0b04;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = false;
				}
			}
			goto IL_0947;
			IL_04ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			bool flag4 = default;
			result = flag4;
			goto IL_0947;
			IL_086b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0947;
			IL_0439:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			result = false;
			goto IL_0947;
			IL_039b:
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
					object obj20 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj21 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							object obj22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							_ = -4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							obj7 = 0;
							goto IL_0638;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S0_v141+10]");
						result = false;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S0_v141+10]");
						result = false;
					}
					goto IL_0947;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			bool flag5 = default;
			result = flag5;
			goto IL_0947;
			IL_0458:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			bool flag6 = default;
			result = flag6;
			goto IL_0947;
			IL_046f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			result = false;
			goto IL_0947;
			IL_0b21:
			bool flag7 = default;
			bool flag8 = default;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj23 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj24 = 0;
				if (flag7)
				{
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_0439;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_0458;
					}
					if (flag6)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_046f;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_048e;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_04ad;
					}
					if (!flag4)
					{
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_04c4;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (!flag8)
						{
							continue;
						}
						goto IL_039b;
					}
					goto IL_04db;
				}
				goto IL_07e2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			result = flag7;
			goto IL_0947;
			IL_0b04:
			object obj25 = obj6 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3BF");
			return result;
			IL_07e2:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag9 = (nint)0 == 1;
			result = false;
			if (flag9)
			{
				goto IL_086b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
			object obj26 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
			result = false;
			obj6 = obj;
			goto IL_0b04;
			IL_0947:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj27 = default;
			object obj28 = default;
			bool flag10 = obj27 == obj28;
			bool flag11 = !flag10;
			object obj30 = default;
			object obj29 = obj30;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag12 = (nint)0 != 1;
				result = false;
				obj6 = obj;
				if (flag12)
				{
					goto IL_0b04;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = false;
				object obj31 = default;
				obj29 = obj31;
			}
			_ = 0;
			object obj32 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			goto IL_0b04;
			IL_04db:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			result = flag8;
			goto IL_0947;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
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

	private const int RouteChunksToBuildForEntry = 1;

	public const int CameraToBackgroundGameDistance = 1000;

	public const int DistanceToChunksSpawned = 2000;

	public const int DistanceToChunksBuildStart = 1200;

	public const int DistanceToChunksReady = 1100;

	public const int DistanceStartCleanupAfterCharacter = 170;

	public const int DistanceDoneCleanupAfterCharacter = 2000;

	public Action<Route, RouteSection, float> OnAddedSection;

	public Action<Route, RouteChunk, float> OnRouteChunkSpawned;

	public static Action<Route, RouteSection, float> OnGlobalAddedSection;

	internal RouteHeight _routeHeight;

	private bool _midSectionsCountLimited;

	private int _midSectionsCountTarget = 1;

	protected List<TransitionSectionInfo> _startSectionPrefabs;

	protected WeightRandomizedRouteSectionContainter _midSectionPrefabs;

	private List<RouteSectionGroup> _midSectionGroupPrefabs;

	protected List<TransitionSectionInfo> _endSectionPrefabs;

	private int _minDistanceBetweenSectionRepeats;

	internal RouteSection _fallbackSection;

	protected int _length;

	protected SectionSpawnMode _secionSpawnMode;

	protected ChunkBuildMode _chunkBuildMode;

	protected Route _route;

	protected Bounds _bounds;

	private List<RouteBuilder> _buildersAbove;

	private List<RouteBuilder> _buildersBelow;

	private RouteBuilder _builderForward;

	private List<RouteBuilder> _buildersOnSides;

	private PickupSpawnPoint _buildLimitingSpawnPoint;

	private float _maxBuildLimitZ;

	private List<RouteChunk> _chunks;

	private int _chunksBuiltCount;

	protected int _spawnedChunkCount;

	private RouteSection _lastSpawnedSection;

	private RouteBuildProgress _sectionLayingProgress;

	private int _midSectionCountUsed;

	protected Vector3 _originPosition;

	protected RouteManager _routeManager;

	protected bool _stopped;

	private bool _completedSectionLayingThisUpdate;

	protected List<RouteChunk> _chunksSpawnedThisUpdate;

	protected List<RouteChunk> _chunksSpawnedDelayedBuild;

	protected List<IConstrainingRouteBuilder> _constrainingBuilders;

	protected LogicAssetsManager _logicAssetManager;

	protected ThemeManager _themeManager;

	protected Transform _originTransfrom;

	protected RouteSection _currentSection;

	private List<RouteSection> _sections;

	private List<BuildDirective> _buildDirectives;

	private RouteBuilderWorker _worker;

	private RouteChunk _lastBuiltChunk;

	private HashSet<Selector> _processedSelectors;

	private LinkedList<EnvironmentRangeWrapper> _environmentWrapperQueue;

	private EnvironmentKind _lastSpawnedEnvironmentKind;

	private SyboRandom RandomGenerator__BackingField;

	private int SectionCountUsed__BackingField;

	private EnvironmentKind PreviousDesiredEnvironmentKind__BackingField;

	private int DistanceBuilt__BackingField;

	private EventHandler m_OnCompletedLayingSections;

	protected SyboRandom RandomGenerator
	{
		get
		{
			return RandomGenerator__BackingField;
		}
		private set
		{
			RandomGenerator__BackingField = value;
		}
	}

	public RouteHeight RouteHeight => _routeHeight;

	public int SpawnedLeadingEdgeWorldZ
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0082: Expected F8, but got I4
			//IL_008c: Expected I4, but got F8
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 position = _originTransfrom.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num = 0.0 + (double)_length;
			double num2 = Math.Abs(num);
			if (!(num2 < 2147483648.0))
			{
				num = -2147483648.0;
			}
			return (int)num;
		}
	}

	public int BuiltLeadingEdgeWorldZ
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0042: Expected F8, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			if (_lastBuiltChunk == null)
			{
				return SpawnedLeadingEdgeWorldZ;
			}
			Vector3 posEnd = _lastBuiltChunk.PosEnd;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			double num = Math.Abs(0.0);
			if (num < 2147483648.0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				return 0;
			}
			return int.MinValue;
		}
	}

	public virtual int DistanceVisibleFromEntry => 1080;

	public virtual int LastPositionVisibleFromEntry
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0022: Expected I, but got Obj
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected Obj, but got Unknown
			//IL_009a: Expected F8, but got I4
			//IL_00a4: Expected I4, but got F8
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 position = _originTransfrom.position;
			nint num = (nint)this;
			object obj3 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v16 @ S2_v3 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+DC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj4 = default;
			double num2 = 0.0 + (double)obj4;
			double num3 = Math.Abs(num2);
			if (!(num3 < 2147483648.0))
			{
				num2 = -2147483648.0;
			}
			return (int)num2;
		}
	}

	public SectionSpawnMode SectionSpawnMode => _secionSpawnMode;

	public ChunkBuildMode ChunkBuildMode => _chunkBuildMode;

	public Route Route => _route;

	public unsafe Bounds Bounds
	{
		get
		{
			//IL_000a: Expected native int or pointer, but got VT
			Bounds bounds = default;
			((Bounds*)(nint)bounds)->m_Center = (Vector3)_bounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Routes.Builders.RouteBuilder)+54]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Routes.Builders.RouteBuilder)+4C]");
			_ = 0;
			return bounds;
		}
	}

	public bool IsDone
	{
		get
		{
			bool result = true;
			if (!_stopped)
			{
				bool flag = _sectionLayingProgress != RouteBuildProgress.Done;
				result = false;
				if (!flag)
				{
					List<RouteChunk> chunksSpawnedDelayedBuild = _chunksSpawnedDelayedBuild;
					result = chunksSpawnedDelayedBuild._size == 0;
				}
			}
			return result;
		}
	}

	public bool IsDoneLayingSections
	{
		get
		{
			if (~(_stopped ? 1u : 0u) == 0)
			{
				return true;
			}
			return _sectionLayingProgress == RouteBuildProgress.Done;
		}
	}

	public RouteChunk FallbackRouteChunk => _fallbackSection.GetRandomMidChunk(RandomGenerator__BackingField);

	public RouteChunk LastChunk
	{
		get
		{
			List<RouteChunk> chunks = _chunks;
			bool flag = _chunks == null;
			RouteChunk result = null;
			if (!flag)
			{
				bool flag2 = chunks._size < 1;
				result = null;
				if (!flag2)
				{
					List<RouteChunk> chunks2 = _chunks;
					int index = chunks2._size - 1;
					RouteChunk routeChunk = chunks2.get_Item(index);
					result = routeChunk;
				}
			}
			return result;
		}
	}

	private RouteSection LastSection
	{
		get
		{
			List<RouteSection> sections = _sections;
			bool flag = _sections == null;
			RouteSection result = null;
			if (!flag)
			{
				bool flag2 = sections._size < 1;
				result = null;
				if (!flag2)
				{
					List<RouteSection> sections2 = _sections;
					int index = sections2._size - 1;
					RouteSection routeSection = sections2.get_Item(index);
					result = routeSection;
				}
			}
			return result;
		}
	}

	public List<RouteBuilder> BuildersAbove => _buildersAbove;

	public List<RouteBuilder> BuildersBelow => _buildersBelow;

	public RouteBuilder BuilderForward => _builderForward;

	public bool IsCleanedUp
	{
		get
		{
			List<RouteChunk> chunks = _chunks;
			return chunks._size == 0;
		}
	}

	public int SpawnedChunkCount => _spawnedChunkCount;

	protected RouteBuildProgress SectionLayingProgress => _sectionLayingProgress;

	public int MidSectionCountUsed => _midSectionCountUsed;

	public int SectionCountUsed
	{
		get
		{
			return SectionCountUsed__BackingField;
		}
		private set
		{
			SectionCountUsed__BackingField = value;
		}
	}

	public bool ReadyToAddSection
	{
		get
		{
			if (_currentSection == null)
			{
				return true;
			}
			RouteSection currentSection = _currentSection;
			return currentSection._progressState == RouteBuildProgress.Done;
		}
	}

	public virtual EnvironmentKind DesiredEnvironmentKind
	{
		get
		{
			return field;
		}
		protected set
		{
			field = value;
		}
	}

	private EnvironmentKind PreviousDesiredEnvironmentKind
	{
		get
		{
			return PreviousDesiredEnvironmentKind__BackingField;
		}
		set
		{
			PreviousDesiredEnvironmentKind__BackingField = value;
		}
	}

	private List<RouteBuilder> BuildersOnSides
	{
		get
		{
			//IL_0036: Expected Obj, but got I
			//IL_0066: Expected Obj, but got I
			((List<T>)(object)_buildersOnSides).Clear();
			List<RouteBuilder> buildersOnSides = _buildersOnSides;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S4_v3 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder>>)+3C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S4_v4+4] (should have been resolved before IL gen)");
			List<RouteBuilder> buildersOnSides2 = _buildersOnSides;
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S4_v8 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder>>)+3C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S4_v9+4] (should have been resolved before IL gen)");
			return _buildersOnSides;
		}
	}

	public List<IConstrainingRouteBuilder> ConstrainingBuilders => _constrainingBuilders;

	protected int DistanceBuilt
	{
		get
		{
			return DistanceBuilt__BackingField;
		}
		private set
		{
			DistanceBuilt__BackingField = value;
		}
	}

	public event EventHandler OnCompletedLayingSections
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 236;
			Delegate obj2 = this.m_OnCompletedLayingSections;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 236;
			Delegate obj2 = this.m_OnCompletedLayingSections;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public RouteBuilder()
	{
		//IL_0185: Expected I, but got Obj
		List<TransitionSectionInfo> list = default;
		list._002Ector();
		_startSectionPrefabs = list;
		WeightRandomizedRouteSectionContainter weightRandomizedRouteSectionContainter = default;
		weightRandomizedRouteSectionContainter._002Ector();
		_midSectionPrefabs = weightRandomizedRouteSectionContainter;
		List<RouteSectionGroup> list2 = default;
		list2._002Ector();
		_midSectionGroupPrefabs = list2;
		List<TransitionSectionInfo> list3 = default;
		list3._002Ector();
		_endSectionPrefabs = list3;
		List<RouteBuilder> list4 = default;
		list4._002Ector();
		_buildersAbove = list4;
		List<RouteBuilder> list5 = default;
		list5._002Ector();
		_buildersBelow = list5;
		List<RouteBuilder> list6 = default;
		list6._002Ector();
		_buildersOnSides = list6;
		List<RouteChunk> list7 = default;
		list7._002Ector();
		_chunks = list7;
		List<RouteChunk> list8 = default;
		list8._002Ector();
		_chunksSpawnedThisUpdate = list8;
		List<RouteChunk> list9 = default;
		list9._002Ector();
		_chunksSpawnedDelayedBuild = list9;
		List<IConstrainingRouteBuilder> list10 = default;
		list10._002Ector();
		_constrainingBuilders = list10;
		List<RouteSection> list11 = default;
		list11._002Ector();
		_sections = list11;
		List<BuildDirective> list12 = default;
		list12._002Ector();
		_buildDirectives = list12;
		RouteBuilderWorker routeBuilderWorker = default;
		routeBuilderWorker._002Ector();
		_worker = routeBuilderWorker;
		HashSet<Selector> hashSet = default;
		hashSet._002Ector();
		_processedSelectors = hashSet;
		LinkedList<EnvironmentRangeWrapper> environmentWrapperQueue = default;
		_environmentWrapperQueue = environmentWrapperQueue;
		_lastSpawnedEnvironmentKind = EnvironmentKind.None;
		EnvironmentKind none = EnvironmentKind.None;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ S2_v2 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+F4] (should have been resolved before IL gen)");
		PreviousDesiredEnvironmentKind__BackingField = EnvironmentKind.None;
	}

	public virtual void Initialize(RouteManager routeManager, Route route, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_036b: Expected Obj, but got I8
		//IL_037e: Expected VT, but got Obj
		//IL_0388: Expected Obj, but got VT
		//IL_0080: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_route = route;
		RandomGenerator__BackingField = randomGenerator;
		_buildLimitingSpawnPoint = (PickupSpawnPoint)(-4647714815446351872L);
		_routeManager = routeManager;
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_logicAssetManager = (LogicAssetsManager)val;
		ThemeManager instance = ThemeManager.Instance;
		_themeManager = instance;
		InitializeSectionGroups();
		_midSectionPrefabs.RemoveEmptyEntries();
		SectionCountUsed__BackingField = 0;
		_midSectionCountUsed = 0;
		_originTransfrom = route._transform;
		Vector3 position = _originTransfrom.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_originPosition = (Vector3)obj;
		_chunkBuildMode = chunkBuildMode;
		_secionSpawnMode = sectionSpawnMode;
		CalculateBounds();
		WeightRandomizedRouteSectionContainter midSectionPrefabs = _midSectionPrefabs;
		NullReferenceException ex = new NullReferenceException();
		throw new ArgumentException();
	}

	private void InitializeSectionGroups()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 48;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj6 = default;
		nint num2 = default;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		object obj16 = default;
		object obj17 = default;
		object obj18 = default;
		object obj20 = default;
		object obj21 = default;
		object obj22 = default;
		object obj23 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj14;
			object obj15;
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj8 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						_ = 0;
						object obj9 = obj + 32;
						obj = obj9;
						_ = 0;
						nint num;
						while (true)
						{
							_ = 0;
							object obj10 = obj + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag = (nint)0 == 1;
							num = num2;
							if (flag)
							{
								break;
							}
							if (obj11 != null)
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag2 = (nint)0 == 1;
								num = num2;
								if (flag2)
								{
									break;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag3 = (nint)0 != 1;
								num = 0;
								num2 = 0;
								if (!flag3)
								{
									break;
								}
								continue;
							}
							goto IL_0256;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
						bool flag4 = obj12 != obj13;
						obj14 = obj12;
						obj15 = obj16;
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag5 = (nint)0 == 1;
							num2 = num;
							if (!flag5)
							{
								goto IL_0256;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							obj14 = obj17;
							obj15 = obj18;
						}
						_ = 0;
						object obj19 = obj + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_03cc;
						}
						goto IL_0572;
					}
				}
			}
			goto IL_02df;
			IL_03cc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
			IL_02df:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj14 = obj20;
			obj15 = obj21;
			goto IL_0572;
			IL_0572:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj22 == obj14)
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
				obj15 = obj23;
			}
			_ = 0;
			object obj24 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_03cc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_0256:
			_ = 0;
			object obj25 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				continue;
			}
			goto IL_02df;
		}
		object obj26 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2AB4");
	}

	public void SetMaxBuildLimitZ(float z, PickupSpawnPoint spawnPoint)
	{
		//IL_0084: Expected Obj, but got I8
		if (!(_buildLimitingSpawnPoint == null))
		{
			int instanceID = spawnPoint.GetInstanceID();
			int instanceID2 = _buildLimitingSpawnPoint.GetInstanceID();
			if (instanceID == instanceID2)
			{
				if (z < 0f)
				{
					_buildLimitingSpawnPoint = (PickupSpawnPoint)(-4647714815446351872L);
				}
				return;
			}
			if (!(_maxBuildLimitZ < z))
			{
				return;
			}
		}
		_buildLimitingSpawnPoint = spawnPoint;
		_maxBuildLimitZ = z;
	}

	private void ResetMaxBuildLimit()
	{
		//IL_000f: Expected Obj, but got I8
		_buildLimitingSpawnPoint = (PickupSpawnPoint)(-4647714815446351872L);
	}

	public virtual void Validate(Route route)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected Obj, but got Unknown
		//IL_06be: Expected Obj, but got I4
		//IL_06ec: Expected Obj, but got I
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_018d: Expected Obj, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected Obj, but got Unknown
		//IL_026f: Expected Obj, but got I
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected Obj, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected Obj, but got Unknown
		//IL_048c: Expected Obj, but got I4
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_0387: Expected Obj, but got I
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_047e: Expected Obj, but got I4
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S3_v3 (Il2CppRgctx<SYBO.Subway.Routes.WeightRandomizedPrefabContainter`2<SYBO.Subway.Routes.WeightedRouteSection, SYBO.Subway.Routes.RouteSection>>)+14]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = obj + 76;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		object obj21 = default;
		object obj26 = default;
		object obj29 = default;
		object obj30 = default;
		object obj32 = default;
		object obj34 = default;
		object obj35 = default;
		object obj39 = default;
		object obj40 = default;
		object obj42 = default;
		object obj43 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_013a;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v223+C]");
					object obj7 = 0 + obj8;
					obj8 = obj7;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 != obj10;
			object obj11 = obj12;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_013a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0676;
			}
			object obj15 = obj11;
			goto IL_0761;
			IL_0761:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
			IL_0676:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			obj15 = obj11;
			goto IL_0761;
			IL_013a:
			object obj16 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
			object obj17 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			object obj18 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			object obj19 = obj + 56;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			while (true)
			{
				_ = 0;
				object obj20 = obj + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj31;
				object obj33;
				if ((nint)0 != 1)
				{
					if (obj21 == null)
					{
						goto IL_059d;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+44]");
					object obj22 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj23 = obj + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
							_ = 0;
							object obj24 = obj + 40;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							_ = 0;
							while (true)
							{
								_ = 0;
								object obj25 = obj + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 == 1)
								{
									break;
								}
								if (obj26 != null)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
									object obj27 = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 == 1)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S0_v186+C]");
									object obj28 = 0 + obj8;
									obj8 = obj28;
									continue;
								}
								goto IL_0483;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							bool flag2 = obj29 != obj30;
							obj31 = obj29;
							obj11 = obj32;
							if (!flag2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									obj33 = 0;
									goto IL_07ff;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								obj31 = obj34;
								obj11 = obj35;
							}
							_ = 0;
							object obj36 = obj + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								break;
							}
							goto IL_089f;
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
				goto IL_052f;
				IL_0483:
				obj33 = 5;
				goto IL_07ff;
				IL_07ff:
				_ = 0;
				object obj37 = obj + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if ((nint)obj33 == 5 || obj33 == null)
					{
						continue;
					}
					object obj38 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2AB4");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_052f;
				IL_089f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				if (obj39 == obj31)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_059d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj11 = obj40;
				}
				_ = 0;
				object obj41 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 != 1;
				obj15 = obj11;
				if (!flag3)
				{
					break;
				}
				goto IL_0761;
				IL_052f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj31 = obj42;
				obj11 = obj43;
				goto IL_089f;
				IL_059d:
				object obj44 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2AB4");
				if ((nint)obj8 < 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string name = route.name;
					throw new ArrayTypeMismatchException();
				}
				return;
			}
			goto IL_0676;
		}
	}

	public void SetBuildMode(SectionSpawnMode spawnMode, ChunkBuildMode chunkBuildMode)
	{
		_chunkBuildMode = chunkBuildMode;
		_secionSpawnMode = spawnMode;
	}

	public void StopBuilding()
	{
		_sectionLayingProgress = RouteBuildProgress.Done;
		((List<T>)(object)_chunksSpawnedDelayedBuild).Clear();
		_stopped = true;
	}

	public void EnqueueStartSection(RouteType fromRouteType, int positionZ)
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S8_v2 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+144] (should have been resolved before IL gen)");
		RouteSection section = default;
		EnqueueBuildDirective(positionZ, SectionSpawnMode.All, ChunkBuildMode.Normal, isApplicablePositionStict: true, section);
	}

	internal unsafe void EnqueueBuildDirective(int positionZ, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, bool isApplicablePositionStict = true, RouteSection section = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0724: Expected Obj, but got I4
		//IL_0760: Invalid comparison between F4 and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0041: Expected Obj, but got I
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected Obj, but got Unknown
		//IL_07b4: Expected Obj, but got I
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected Obj, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected Obj, but got Unknown
		//IL_07fa: Expected Obj, but got I
		//IL_081d: Expected Obj, but got I
		//IL_0832: Expected Obj, but got I
		//IL_065f: Expected Obj, but got I
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_05ce: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_0a6d: Expected I, but got Obj
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected Obj, but got Unknown
		//IL_0aa0: Expected Obj, but got I
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_0917: Expected I, but got Obj
		//IL_0983: Expected Obj, but got I
		//IL_09c7: Expected native int or pointer, but got VT
		//IL_0a09: Expected native int or pointer, but got VT
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Expected VT, but got Unknown
		//IL_0a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected VT, but got Unknown
		//IL_031b: Invalid comparison between F4 and I4
		//IL_0258: Invalid comparison between F4 and I4
		//IL_08ad: Expected Obj, but got I4
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected I4, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 208);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		List<BuildDirective> buildDirectives = _buildDirectives;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
		if ((nint)0 != 0)
		{
			object obj2 = color + 144;
			List<BuildDirective> buildDirectives2 = _buildDirectives;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v200 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
			object obj3 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EC2");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+9C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+94]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
			if ((nint)0 > (nint)positionZ)
			{
				string name = _route.name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
				_ = 0;
				object obj4 = color + 144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
				_ = 0;
				object obj5 = color + 120;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg = default;
				object arg2 = default;
				string text = string.Format("{0} enqueuing a build directive before already existing one. Existing: [{0}] New: [{1}]", name, arg, arg2);
			}
		}
		int num = positionZ / 180;
		object obj6 = num * 180;
		if (positionZ != (nint)obj6 && isApplicablePositionStict)
		{
			string name2 = _route.name;
			_ = 180;
			object obj7 = color + 120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
			_ = 0;
			object obj8 = color + 144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg3 = default;
			object arg4 = default;
			string text2 = $"{name2} enqueuing a build directive with position not multiple of MIN_CHUNK_LENGTH ({arg3}) - [{arg4}] ";
		}
		RouteSection lastSection = LastSection;
		float sectionMinEndPos = GetSectionMinEndPos(lastSection);
		if (sectionMinEndPos > (float)positionZ)
		{
			if (isApplicablePositionStict)
			{
				while (true)
				{
					RouteSection lastSection2 = LastSection;
					RouteChunk spawnedChunk = lastSection2.GetSpawnedChunk(0);
					if (spawnedChunk._built)
					{
						break;
					}
					RouteSection lastSection3 = LastSection;
					float sectionMinEndPos2 = GetSectionMinEndPos(lastSection3);
					if (!(sectionMinEndPos2 > (float)positionZ))
					{
						break;
					}
					RouteSection lastSection4 = LastSection;
					List<RouteChunk> spawnedChunks2;
					do
					{
						List<RouteChunk> spawnedChunks = lastSection4._spawnedChunks;
						int index = spawnedChunks._size - 1;
						RouteChunk routeChunk = spawnedChunks.get_Item(index);
						object obj9 = routeChunk._blockCount * 90;
						int length = _length - obj9;
						_length = length;
						DespawnRouteChunk(routeChunk, instantDespawn: true);
						spawnedChunks2 = lastSection4._spawnedChunks;
					}
					while (spawnedChunks2._size > 0);
					bool flag = _sections.Remove(lastSection4);
					Transform transform = lastSection4.transform;
					PoolManager.Despawn(transform);
				}
				List<RouteSection> sections = _sections;
				int index2 = sections._size - 1;
				RouteSection currentSection = sections.get_Item(index2);
				_currentSection = currentSection;
				RouteSection lastSection5 = LastSection;
				float sectionMinEndPos3 = GetSectionMinEndPos(lastSection5);
				if (sectionMinEndPos3 > (float)positionZ)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string name3 = _route.name;
					throw new ArrayTypeMismatchException();
				}
			}
			else
			{
				int spawnedLeadingEdgeWorldZ = SpawnedLeadingEdgeWorldZ;
				if (spawnedLeadingEdgeWorldZ > positionZ)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string name4 = _route.name;
					throw new ArrayTypeMismatchException();
				}
			}
		}
		List<BuildDirective> buildDirectives3 = _buildDirectives;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
		_ = 0;
		object obj10 = color - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
		_ = 0;
		object obj11 = color - 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
		_ = 0;
		object obj12 = obj11 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v34 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+10]");
		object obj13 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v34 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v34 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v39+C]");
		if (num2 < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v34 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
			object obj15 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v34 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
			object obj16 = (nint)0 * (nint)20;
			object obj17 = obj14 + obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v42+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v42+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v42+8]");
			_ = 0;
		}
		else
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v104 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>>)+2C]");
			object obj18 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v42+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v42+38]");
			_ = 0;
			object obj19 = obj11 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v318 @ S0_v105+4] (should have been resolved before IL gen)");
		}
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v59 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		object obj20 = Vector3.forwardVector * positionZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v60 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
		object obj21 = (nint)0 * (nint)positionZ;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S0_v73 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num8 = 0;
		float num9 = (float)Vector3.upVector * 300f;
		float num10 = (float)obj20 + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v74 (Il2CppStaticFields<UnityEngine.Vector3>)+1C]");
		float num11 = 0f * 300f;
		float num12 = (float)obj21 + num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v60 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		object obj22 = (nint)0 * (nint)positionZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v74 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		float num13 = 0f * 300f;
		float num14 = (float)obj22 + num13;
		_ = 4575657221408423936L;
		((Color*)(nint)color)->b = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+60]");
		_ = 0;
		_ = 1065353216;
		((Color*)(nint)color)->r = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
		_ = 0;
		Vector3 start = (Vector3)(color + 32);
		Vector3 end = (Vector3)(color + 16);
		Debug.DrawLine(start, end, color, 3000f);
	}

	private float GetSectionMinEndPos(RouteSection section)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = section.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		return 0f + (float)section._lengthMin;
	}

	public float GetLastSectionStartPos()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		RouteSection lastSection = LastSection;
		Transform transform = lastSection.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		return 0f;
	}

	public float GetLastSectionMinEndPos()
	{
		RouteSection lastSection = LastSection;
		return GetSectionMinEndPos(lastSection);
	}

	public virtual void ConnectBuilder(RouteBuilder builderToConnect)
	{
		//IL_00c4: Expected I, but got Obj
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_010d: Expected I, but got Obj
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		if (_routeHeight < builderToConnect._routeHeight)
		{
			_buildersAbove.Add(builderToConnect);
			builderToConnect._buildersBelow.Add(this);
		}
		else if (_routeHeight > builderToConnect._routeHeight)
		{
			_buildersBelow.Add(builderToConnect);
			builderToConnect._buildersAbove.Add(this);
		}
		else if (_builderForward == null)
		{
			_builderForward = builderToConnect;
		}
		else
		{
			nint num = (nint)builderToConnect;
			object obj = builderToConnect + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S2_v3 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+D4] (should have been resolved before IL gen)");
			RouteBuilder builderForward = _builderForward;
			string text = default;
			if (_builderForward != null)
			{
				nint num2 = (nint)builderForward;
				object obj2 = builderForward + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S4_v5 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+D4] (should have been resolved before IL gen)");
			}
			else
			{
				text = null;
			}
			string text3 = default;
			string text2 = "RouteBuilder: - attempting to connect forward builder " + text3 + " but already have connected " + text;
		}
		CollectConstrainingBuilders();
		builderToConnect.CollectConstrainingBuilders();
	}

	public virtual void DisconnectBuilder(RouteBuilder builderToDisconnect)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		if (_buildersAbove.Remove(builderToDisconnect))
		{
			bool flag = builderToDisconnect._buildersBelow.Remove(this);
		}
		else if (_buildersBelow.Remove(builderToDisconnect))
		{
			bool flag2 = builderToDisconnect._buildersAbove.Remove(this);
		}
		else if (_builderForward == builderToDisconnect)
		{
			object obj = this + 100;
			obj = 0;
		}
		CollectConstrainingBuilders();
		builderToDisconnect.CollectConstrainingBuilders();
	}

	private void DisconnectAllBuilders()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0051: Expected I, but got Obj
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_008f: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		while (true)
		{
			List<RouteBuilder> buildersAbove = _buildersAbove;
			if (buildersAbove._size <= 0)
			{
				break;
			}
			RouteBuilder routeBuilder = _buildersAbove.get_Item(0);
			nint num = (nint)this;
			object obj = this + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S2_v15 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+114] (should have been resolved before IL gen)");
		}
		while (true)
		{
			List<RouteBuilder> buildersBelow = _buildersBelow;
			if (buildersBelow._size <= 0)
			{
				break;
			}
			RouteBuilder routeBuilder2 = _buildersBelow.get_Item(0);
			nint num2 = (nint)this;
			object obj2 = this + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S2_v10 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+114] (should have been resolved before IL gen)");
		}
		if (_builderForward != null)
		{
			nint num3 = (nint)this;
			object obj3 = this + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S2_v5 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+114] (should have been resolved before IL gen)");
		}
	}

	public IConstrainingRouteBuilder GetConstrainingBuilderAt(float positionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_00d6: Invalid comparison between Obj and F4
		//IL_013b: Invalid comparison between Obj and F4
		//IL_016d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		IConstrainingRouteBuilder result2;
		IConstrainingRouteBuilder constrainingRouteBuilder = default;
		IConstrainingRouteBuilder constrainingRouteBuilder2 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			IConstrainingRouteBuilder result;
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					result = null;
					goto IL_0233;
				}
				_ = 0;
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
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)positionZ))
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)positionZ))
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
							result = (IConstrainingRouteBuilder)0;
							goto IL_0233;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 != obj10;
			result2 = constrainingRouteBuilder;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			result = null;
			if (!flag2)
			{
				goto IL_0233;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			result2 = constrainingRouteBuilder2;
			break;
			IL_0233:
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B6");
			return result;
		}
		_ = 0;
		object obj12 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result2;
	}

	public virtual void UpdateBuilder(float characterWorldZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0498: Expected Obj, but got I4
		//IL_04b0: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_00dd: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I
		//IL_0105: Invalid comparison between F4 and I4
		//IL_0118: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I
		//IL_0223: Expected I, but got Obj
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_02b5: Expected Obj, but got I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_01c0: Expected Obj, but got I4
		//IL_02da: Invalid comparison between Obj and F4
		object obj2 = default;
		object obj = obj2 - 16;
		_completedSectionLayingThisUpdate = false;
		((List<T>)(object)_chunksSpawnedThisUpdate).Clear();
		int spawnedLeadingEdgeWorldZ = SpawnedLeadingEdgeWorldZ;
		bool flag = ProcessBuildDirectives(spawnedLeadingEdgeWorldZ);
		float num = characterWorldZ + 2000f;
		float num2 = characterWorldZ + 1200f;
		float reqPositionReadyWorldZ = characterWorldZ + 1100f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		bool flag2 = default;
		if (_secionSpawnMode == SectionSpawnMode.OnlyEntry && _sectionLayingProgress == RouteBuildProgress.Start)
		{
			RouteSection currentSection = _currentSection;
			flag2 = currentSection._progressState != RouteBuildProgress.Done;
		}
		bool flag3 = _secionSpawnMode == SectionSpawnMode.All;
		object obj3 = flag2 | flag3;
		bool flag4 = obj3 == null;
		object obj4 = 0;
		if (!flag4)
		{
			bool flag5 = IsConstraintBlockingSpawningAt(spawnedLeadingEdgeWorldZ);
			obj4 = 0;
			if (!flag5)
			{
				bool isDone = IsDone;
				obj4 = 0;
				if (!isDone)
				{
					object obj5 = default;
					bool flag6 = obj5 != null;
					bool flag7 = num > (float)spawnedLeadingEdgeWorldZ;
					obj4 = flag6 | flag7;
				}
			}
		}
		RouteChunk lastChunk = LastChunk;
		bool flag8 = lastChunk != null;
		bool flag9 = !flag8;
		object obj6 = obj4;
		if (!flag9)
		{
			RouteChunk lastChunk2 = LastChunk;
			bool flag10 = lastChunk2 == null;
			bool flag11 = !flag10;
			obj6 = obj4;
			if (!flag11)
			{
				RouteChunk lastChunk3 = LastChunk;
				if (lastChunk3.Previous == null)
				{
					obj6 = 1;
				}
				else
				{
					RouteChunk lastChunk4 = LastChunk;
					RouteChunk previous = lastChunk4.Previous;
					object obj7 = previous._built | obj4;
					obj6 = obj7;
				}
			}
		}
		if (obj6 != null)
		{
			if (ReadyToAddSection)
			{
				nint num3 = (nint)this;
				object obj8 = this + 160;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v172 @ S1_v50 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+15C] (should have been resolved before IL gen)");
			}
			SpawnNextChunk(_currentSection);
		}
		object obj9;
		if (_lastBuiltChunk == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+94]");
			obj9 = 0;
		}
		else
		{
			Vector3 posEnd = _lastBuiltChunk.PosEnd;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			obj9 = 0;
		}
		if (!flag2)
		{
			object obj10 = _chunkBuildMode | _chunkBuildMode;
			if (obj10 != null && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num2))
			{
				BuildChunks(num2, _chunkBuildMode, _chunkBuildMode);
			}
		}
		else
		{
			BuildChunks(2.1474836E+09f);
		}
		DespawnPassedChunks(characterWorldZ);
		if (~(_stopped ? 1u : 0u) == 0)
		{
			DespawnUnbuiltChunks(characterWorldZ);
		}
		RemoveEmptySections(characterWorldZ);
		LinkedList<EnvironmentRangeWrapper> environmentWrapperQueue = _environmentWrapperQueue;
		if (environmentWrapperQueue.count >= 1)
		{
			LinkedList<EnvironmentRangeWrapper> environmentWrapperQueue2 = _environmentWrapperQueue;
			LinkedListNode<EnvironmentRangeWrapper> head = environmentWrapperQueue2.head;
			EnvironmentRangeWrapper item = head.item;
			if (item.EndPositionZ < characterWorldZ)
			{
				_environmentWrapperQueue.RemoveFirst();
			}
		}
		if (~(_completedSectionLayingThisUpdate ? 1u : 0u) == 0)
		{
			EventHandler onCompletedLayingSections = this.m_OnCompletedLayingSections;
			if (this.m_OnCompletedLayingSections != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v284.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
		float reqPositionCleanedUpWorldZ = characterWorldZ - 2000f;
		_worker.UpdateWorker(reqPositionReadyWorldZ, reqPositionCleanedUpWorldZ);
	}

	private bool IsConstraintBlockingSpawningAt(int spawnedLeadingEdgeWorldZ)
	{
		//IL_00ba: Expected I, but got Obj
		int num = 0;
		RouteBuilder routeBuilder = default;
		object obj = default;
		while (true)
		{
			List<IConstrainingRouteBuilder> constrainingBuilders = _constrainingBuilders;
			if (num < constrainingBuilders._size)
			{
				IConstrainingRouteBuilder constrainingRouteBuilder = _constrainingBuilders.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				if (!routeBuilder.IsDone)
				{
					int constraintEndZ = ((ConstrainingRouteBuilder)routeBuilder).ConstraintEndZ;
					if (constraintEndZ == spawnedLeadingEdgeWorldZ)
					{
						break;
					}
				}
				if (!routeBuilder.IsDone)
				{
					nint num2 = (nint)routeBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S1_v16 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+DC] (should have been resolved before IL gen)");
					if ((nint)obj > routeBuilder._length)
					{
						break;
					}
				}
				int num3 = num + 1;
				num = num3;
				continue;
			}
			return false;
		}
		return true;
	}

	private unsafe bool ProcessBuildDirectives(int spawnedLeadingEdgeWorldZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_008c: Expected Obj, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected VT, but got Unknown
		//IL_0171: Expected Ref, but got VT
		//IL_00dc: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		List<BuildDirective> buildDirectives = _buildDirectives;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
		if ((nint)0 != 0)
		{
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EC2");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			if ((nint)0 <= (nint)spawnedLeadingEdgeWorldZ)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				object obj4 = (nint)0 / (nint)180;
				object obj5 = obj4 * 180;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				object obj6 = 0 - obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				if ((nint)spawnedLeadingEdgeWorldZ != 0)
				{
					obj6 = 1;
				}
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					if ((nint)spawnedLeadingEdgeWorldZ > (nint)0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
						object obj7 = (nint)0 & (nint)1;
						if (obj7 == null)
						{
							goto IL_012c;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					string name = _route.name;
					throw new ArrayTypeMismatchException();
				}
				goto IL_012c;
			}
		}
		goto IL_0262;
		IL_0262:
		return true;
		IL_012c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3D7");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_chunkBuildMode = ChunkBuildMode.None;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
		_secionSpawnMode = SectionSpawnMode.None;
		BuildDirective buildDirective = (BuildDirective)(obj + 40);
		if (((BuildDirective*)buildDirective)->HasSection)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			RouteSection routeSection = AddSection((RouteSection)0);
		}
		goto IL_0262;
	}

	private void BuildChunks(float buildUntilWorldZ, ChunkBuildMode previouslySpawnedBuildMode = ChunkBuildMode.Normal, ChunkBuildMode thisUpdateSpawnedBuildMode = ChunkBuildMode.Normal)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a6: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		List<RouteChunk> chunks = _chunks;
		if (chunks._size == 0)
		{
			return;
		}
		RouteChunk routeChunk;
		if (_lastBuiltChunk == null)
		{
			routeChunk = _chunks.get_Item(0);
		}
		else
		{
			RouteChunk lastBuiltChunk = _lastBuiltChunk;
			routeChunk = lastBuiltChunk.Next;
		}
		RouteChunk routeChunk2 = routeChunk;
		while (routeChunk2 != null && !routeChunk2._built)
		{
			Vector3 posStart = routeChunk2.PosStart;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if (0f < buildUntilWorldZ)
			{
				bool flag = _chunksSpawnedThisUpdate.Contains(routeChunk2);
				bool flag2 = false;
				if (thisUpdateSpawnedBuildMode == ChunkBuildMode.None)
				{
					flag2 = flag;
				}
				if (!flag2)
				{
					ChunkBuildMode buildMode = thisUpdateSpawnedBuildMode;
					if (!flag)
					{
						buildMode = previouslySpawnedBuildMode;
					}
					BuildChunk(routeChunk2, buildMode);
					routeChunk2 = routeChunk2.Next;
					continue;
				}
				break;
			}
			break;
		}
	}

	private void BuildChunk(RouteChunk chunk, ChunkBuildMode buildMode)
	{
		//IL_0005: Expected I, but got Obj
		//IL_0014: Expected I, but got Obj
		//IL_0023: Expected I, but got Obj
		//IL_004f: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected I4, but got Unknown
		//IL_00dc: Expected I4, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S3_v2 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+124] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v13 @ S2_v3 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+F4] (should have been resolved before IL gen)");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S2_v6 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+EC] (should have been resolved before IL gen)");
		EnvironmentKind routeDesiredEnvironmentKind = default;
		chunk.Build(routeDesiredEnvironmentKind, PreviousDesiredEnvironmentKind__BackingField);
		_lastBuiltChunk = chunk;
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S2_v11 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+EC] (should have been resolved before IL gen)");
		EnvironmentKind environmentKind = default;
		PreviousDesiredEnvironmentKind__BackingField = environmentKind;
		object obj = chunk._blockCount * 90;
		int num5 = DistanceBuilt__BackingField + obj;
		DistanceBuilt__BackingField = num5;
		int chunksBuiltCount = _chunksBuiltCount + 1;
		_chunksBuiltCount = chunksBuiltCount;
		if (buildMode == ChunkBuildMode.Normal)
		{
			IEnumerator workRoutine = PerformSelectionAndActivationASync(chunk, (ChunkBuildMode)this);
			_worker.EnqueueSpawnWork(chunk, workRoutine);
		}
	}

	private IEnumerator PerformSelectionAndActivationASync(RouteChunk chunk, ChunkBuildMode buildMode)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	protected virtual EnvironmentKind EvalNextChunkDesiredEnvironment(RouteChunk spawnedChunk)
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+EC] (should have been resolved before IL gen)");
		EnvironmentKind result = default;
		return result;
	}

	public virtual bool WillChangeEnvironment(int addedDistance)
	{
		return false;
	}

	private bool IsPositionWithinConnectedBuilder(Vector3 position)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I
		//IL_00e4: Expected Obj, but got F4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 24;
		List<RouteBuilder> buildersOnSides = BuildersOnSides;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj4 = obj - -64;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		bool flag2 = default;
		bool result;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		bool flag5 = default;
		bool flag7 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = !flag2;
				result = flag2;
				if (flag)
				{
					break;
				}
				_ = 0;
				object obj6 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v69+C]");
				object obj7 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v70+54]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v70+4C]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v70+44]");
					_ = 0;
					_ = 0;
					_ = position.z;
					obj = position.x;
					object obj8 = obj + 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj9 != null)
						{
							result = flag2;
							break;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj10 == obj11;
			bool flag4 = !flag3;
			result = flag5;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 != 1;
				result = false;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag7;
			}
			_ = 0;
			object obj12 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		object obj13 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3CF");
		return result;
	}

	public void RemoveChunk(RouteChunk chunk)
	{
		bool flag = _chunks.Remove(chunk);
	}

	public virtual void Destruct()
	{
		DisconnectAllBuilders();
		DespawnAllRouteChunks();
		throw new ArgumentException();
	}

	private void CollectConstrainingBuilders()
	{
		((List<T>)(object)_constrainingBuilders).Clear();
		CollectConstrainingBuilders(_buildersAbove);
		CollectConstrainingBuilders(_buildersBelow);
		CollectIfConstrainingBuilder(_builderForward);
	}

	private void CollectConstrainingBuilders(ICollection<RouteBuilder> builders)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = default;
		object obj5 = default;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj4 == null)
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj5 == obj6;
			bool flag2 = !flag;
			object obj7 = obj8;
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
				obj7 = obj9;
			}
			_ = 0;
			object obj10 = obj + 16;
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
		object obj11 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	private void CollectIfConstrainingBuilder(RouteBuilder builder)
	{
		//IL_0021: Expected I, but got Obj
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		IConstrainingRouteBuilder constrainingRouteBuilder = default;
		if (constrainingRouteBuilder != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Route route = _route;
			nint num = (nint)route;
			object obj = route + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S1_v8 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
			object obj2 = default;
			if (obj2 != null)
			{
				_constrainingBuilders.Add(constrainingRouteBuilder);
			}
		}
	}

	private unsafe void CalculateBounds()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected VT, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected VT, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected VT, but got Unknown
		//IL_0188: Expected native int or pointer, but got VT
		//IL_01b9: Expected VT, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected VT, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected VT, but got Unknown
		//IL_00a1: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 144;
		float num = (float)_originPosition + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+90]");
		float num2 = 0f + 45f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+94]");
		float num3 = 0f + 0f;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		_ = 0;
		_ = 4806466703425798144L;
		_ = 4806466703425798144L;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		Bounds bounds = (Bounds)(obj + 120);
		Vector3 center = (Vector3)(obj + 48);
		Vector3 size = (Vector3)(obj + 32);
		*(Bounds*)(nint)bounds = new Bounds(center, size);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_bounds = (Bounds)0;
		Bounds bounds2 = (Bounds)(this + 68);
		int num4 = default;
		int num5 = default;
		while (true)
		{
			List<RouteChunk> chunks = _chunks;
			if (num4 < chunks._size)
			{
				RouteChunk routeChunk = _chunks.get_Item(num4);
				Bounds trackBounds = routeChunk.TrackBounds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
				_ = 0;
				Bounds bounds3 = (Bounds)(obj + 8);
				((Bounds*)bounds2)->Encapsulate(bounds3);
				num4 = num5 + 1;
				continue;
			}
			break;
		}
	}

	protected virtual bool CanSpawnSection(RouteSection section)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0285: Expected Obj, but got I4
		//IL_02e4: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		int spawnedLeadingEdgeWorldZ = SpawnedLeadingEdgeWorldZ;
		object obj3 = spawnedLeadingEdgeWorldZ + section._lengthMin;
		RouteSection.RepeatConfiguration repeatConfiguration = section._repeatConfiguration;
		bool result = default;
		if (repeatConfiguration._remainingSectionsBetweenRepeats <= 0)
		{
			bool flag = repeatConfiguration._lastSpawnZPosition == 0;
			bool flag2 = true;
			if (!flag)
			{
				int num = repeatConfiguration._distanceBetweenRepeats;
				if (repeatConfiguration._distanceBetweenRepeats <= _minDistanceBetweenSectionRepeats)
				{
					num = _minDistanceBetweenSectionRepeats;
				}
				object obj4 = repeatConfiguration._lastSpawnZPosition + num;
				flag2 = spawnedLeadingEdgeWorldZ >= (nint)obj4;
			}
			if (flag2)
			{
				if (_lastSpawnedSection != null)
				{
					bool flag3 = repeatConfiguration.CanSpawnAfter(_lastSpawnedSection);
					bool flag4 = !flag3;
					result = false;
					if (flag4)
					{
						goto IL_02b4;
					}
				}
				object obj5 = 0;
				while (true)
				{
					List<BuildDirective> buildDirectives = _buildDirectives;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v17 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
					if ((nint)obj6 < 0)
					{
						object obj7 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EC2");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						if (0 < (nint)obj3)
						{
							object obj8 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EC2");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
							object obj9 = (nint)0 & (nint)1;
							result = false;
							if (obj9 != null)
							{
								break;
							}
							object obj10 = obj5 + 1;
							obj5 = obj10;
							continue;
						}
					}
					bool flag5 = spawnedLeadingEdgeWorldZ < section._zMinimum;
					result = false;
					if (flag5)
					{
						break;
					}
					if (spawnedLeadingEdgeWorldZ > section._zMaximum)
					{
						result = false;
						if (section._zMaximumActive)
						{
							break;
						}
					}
					if (section._minSpawnOrder != 0)
					{
						object obj11 = section._minSpawnOrder + 1;
						bool flag6 = SectionCountUsed__BackingField < (nint)obj11;
						result = false;
						if (flag6)
						{
							break;
						}
					}
					result = true;
					break;
				}
			}
		}
		goto IL_02b4;
		IL_02b4:
		return result;
	}

	public bool CanSpawnChunk(RouteChunk chunk)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected Obj, but got Unknown
		//IL_06a4: Expected I4, but got Obj
		//IL_037e: Expected Obj, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_04c8: Expected Obj, but got I4
		//IL_0396: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<IConstrainingRouteBuilder> constrainingBuilders = _constrainingBuilders;
		bool flag = constrainingBuilders._size == 0;
		bool result = true;
		if (!flag)
		{
			int spawnedLeadingEdgeWorldZ = SpawnedLeadingEdgeWorldZ;
			object obj3 = chunk._blockCount * 90;
			object obj4 = spawnedLeadingEdgeWorldZ + obj3;
			object obj6 = default;
			object obj10 = default;
			object obj15 = default;
			object obj16 = default;
			object obj17 = default;
			object obj18 = default;
			object obj20 = default;
			object obj21 = default;
			object obj22 = default;
			object obj24 = default;
			object obj25 = default;
			bool result2 = default;
			while (true)
			{
				List<BuildDirective> buildDirectives = _buildDirectives;
				object obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v17 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
				if ((nint)obj5 < 0)
				{
					object obj7 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EC2");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					if (0 < (nint)obj4)
					{
						object obj8 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EC2");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						object obj9 = (nint)0 & (nint)1;
						result = false;
						if (obj9 != null)
						{
							break;
						}
						obj6 = obj10 + 1;
						continue;
					}
				}
				object obj11 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
				object obj12 = obj + 32;
				obj = obj12;
				_ = 0;
				object obj14;
				object obj23;
				while (true)
				{
					_ = 0;
					object obj13 = obj + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						obj14 = 1;
					}
					else
					{
						if (obj15 == null)
						{
							goto IL_03e2;
						}
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												bool flag2 = obj16 == null;
												bool flag3 = false;
												if (!flag2)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														obj14 = obj17;
														goto IL_0433;
													}
													bool flag4 = (nint)obj18 <= spawnedLeadingEdgeWorldZ;
													flag3 = flag4;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													if (flag3)
													{
														continue;
													}
													object obj19 = obj20 & obj17;
													if (obj19 != null)
													{
														continue;
													}
													goto IL_03e2;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												obj14 = obj17;
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												obj14 = obj17;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											obj14 = 1;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										obj14 = 1;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									obj14 = 1;
								}
								goto IL_0433;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						obj14 = 1;
					}
					goto IL_0433;
					IL_0433:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag5 = obj21 == obj22;
					bool flag6 = !flag5;
					obj23 = obj24;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag7 = (nint)0 != 1;
						obj23 = 1;
						if (flag7)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						obj23 = obj25;
					}
					_ = 0;
					object obj26 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					return result2;
					IL_03e2:
					object obj27 = obj15 ^ 1;
					obj14 = obj27;
					obj23 = obj27;
					break;
				}
				object obj28 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B6");
				result = (byte)(obj23 & obj14) != 0;
				break;
			}
		}
		return result;
	}

	public void HideLogic(float fromPositionZ, float distance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0349: Expected Obj, but got I
		//IL_0135: Expected F4, but got I
		//IL_0135: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		float range2End = fromPositionZ + distance;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj8 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						object obj9 = obj + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
							bool flag2 = MathUtil.AreRangesOverlapping(num, 0f, fromPositionZ, range2End);
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								if (!flag2)
								{
									continue;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C");
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
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj10 == obj11;
			bool flag4 = !flag3;
			object obj12 = obj13;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				obj7 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj16 = obj7 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3872");
	}

	protected bool IsStartPositionConstrained(int startPositionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		bool flag2 = default;
		bool result;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		bool flag5 = default;
		bool flag7 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				bool flag = !flag2;
				result = flag2;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj6 != null)
						{
							result = flag2;
							break;
						}
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj7 == obj8;
			bool flag4 = !flag3;
			result = flag5;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag6 = (nint)0 != 1;
				result = false;
				if (flag6)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = flag7;
			}
			_ = 0;
			object obj9 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B6");
		return result;
	}

	protected IConstrainingRouteBuilder GetBuilderConstrainingStartAt(int startPositionZ)
	{
		throw new ArgumentException();
	}

	protected unsafe void SpawnNextChunk(RouteSection section)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_02b9: Expected I, but got Obj
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected I4, but got Unknown
		//IL_010a: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 32);
		_ = 0;
		_ = 0;
		_ = 0;
		RouteChunk nextChunk = section.GetNextChunk(this, RandomGenerator__BackingField);
		if (nextChunk != null)
		{
			RouteChunk routeChunk = SpawnRouteChunk(nextChunk);
		}
		else
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			object obj3 = default;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj4 = obj + 24;
				obj = (Enum)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+10]");
				_ = 0;
				object obj5 = default;
				object obj7 = default;
				object obj8 = default;
				object obj9 = default;
				object obj11 = default;
				object obj12 = default;
				object obj13 = default;
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
							object obj6 = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+1F]");
							if ((nint)0 != 0)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag = (nint)0 != 1;
								obj6 = obj7;
								if (flag)
								{
									continue;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					bool flag2 = obj8 != obj9;
					object obj10 = obj11;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						obj = (Enum)obj12;
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
						obj10 = obj13;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+1F]");
				if ((nint)0 != 0)
				{
					Route route = _route;
					nint num = (nint)route;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ S2_v13 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
					_ = -1;
					obj = (Enum)(object)typeof(RouteType);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+14]");
					_ = 0;
					string text = obj.ToString();
					bool flag3 = (byte)(obj + 31) != 0;
					string text2 = (flag3 ? ((bool*)1) : ((bool*)null))->ToString();
					string text3 = "MaybeSpawnNextRouteChunk(): " + text + " No compatible chunks! Has cross-builder constrains? " + text2;
				}
			}
		}
		if (section._progressState == RouteBuildProgress.Done)
		{
			IncrementSectionProgressState();
		}
	}

	protected virtual RouteSection GetSectionPrefab(RouteBuildProgress progressState, RouteType transitionRouteType = RouteType.None)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_010c: Expected I, but got Obj
		//IL_0083: Expected I, but got Obj
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		string text = default;
		if (progressState != RouteBuildProgress.Start)
		{
			if (progressState == RouteBuildProgress.Mid)
			{
				return GetMidSectionPrefab();
			}
			if (progressState == RouteBuildProgress.End)
			{
				nint num = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S3_v6 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+14C] (should have been resolved before IL gen)");
				goto IL_011b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			_ = -1;
			object obj3 = default;
			obj = (Enum)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			text = obj.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			SwitchDefaultException ex = default;
			ex._002Ector(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		nint num2 = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S3_v3 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+14C] (should have been resolved before IL gen)");
		goto IL_011b;
		IL_011b:
		RouteSection result = default;
		return result;
	}

	protected virtual RouteSection GetTransitionSectionPrefab(List<TransitionSectionInfo> transitionSections, RouteType transitionRouteType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_00d4: Expected Obj, but got I
		//IL_0238: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		RouteSection result;
		object obj7;
		object obj9 = default;
		object obj10 = default;
		RouteSection routeSection = default;
		RouteSection routeSection2 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj6 == null)
				{
					result = null;
					obj7 = obj;
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v65+8]");
					if ((nint)0 == (nint)transitionRouteType)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v65+C]");
						result = (RouteSection)0;
						obj7 = obj;
						break;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 == obj10;
			bool flag2 = !flag;
			result = routeSection;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 != 1;
				result = null;
				obj7 = obj;
				if (flag3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = routeSection2;
			}
			_ = 0;
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj7 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		object obj12 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A3E7");
		return result;
	}

	protected RouteSection GetStartSectionPrefab(RouteType previousRouteType)
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S3_v2 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+14C] (should have been resolved before IL gen)");
		RouteSection result = default;
		return result;
	}

	protected RouteSection GetEndSectionPrefab(RouteType nextRouteType)
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S3_v2 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+14C] (should have been resolved before IL gen)");
		RouteSection result = default;
		return result;
	}

	protected RouteSection GetMidSectionPrefab()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got I
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_0335: Expected Obj, but got I
		//IL_00c8: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		RouteSection routeSection = _midSectionPrefabs.PickSemiRandomlyOrderedPrefab(RandomGenerator__BackingField);
		bool flag = routeSection == null;
		bool flag2 = !flag;
		RouteSection routeSection2 = routeSection;
		if (!flag2)
		{
			routeSection2 = _fallbackSection;
		}
		_lastSpawnedSection = routeSection2;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v3 (Il2CppRgctx<SYBO.Subway.Routes.WeightRandomizedPrefabContainter`2<SYBO.Subway.Routes.WeightedRouteSection, SYBO.Subway.Routes.RouteSection>>)+14]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj4 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj5 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		RouteSection result = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v74+10]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v83+1C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v84+C]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v84+C]");
						object obj8 = -1;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj9 == obj10;
			bool flag4 = !flag3;
			object obj11 = obj12;
			if (!flag4)
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
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return result;
		}
		object obj15 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		RouteSection.RepeatConfiguration repeatConfiguration = routeSection2._repeatConfiguration;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		int spawnedLeadingEdgeWorldZ = ((RouteBuilder)0).SpawnedLeadingEdgeWorldZ;
		repeatConfiguration._remainingSectionsBetweenRepeats = repeatConfiguration._sectionsBetweenRepeats;
		int lastSpawnZPosition = spawnedLeadingEdgeWorldZ + routeSection2._lengthMax;
		repeatConfiguration._lastSpawnZPosition = lastSpawnZPosition;
		return routeSection2;
	}

	protected virtual RouteSection GetNextSectionPrefab()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S3_v2 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+144] (should have been resolved before IL gen)");
		RouteSection result = default;
		return result;
	}

	protected virtual void AddNextSection()
	{
		//IL_004e: Expected I, but got Obj
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		if (_sectionLayingProgress == RouteBuildProgress.Mid)
		{
			int midSectionCountUsed = _midSectionCountUsed + 1;
			_midSectionCountUsed = midSectionCountUsed;
		}
		nint num = (nint)this;
		object obj = this + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S2_v3 (Il2CppClass<SYBO.Subway.Routes.Builders.RouteBuilder>)+154] (should have been resolved before IL gen)");
		RouteSection sectionPrefab = default;
		RouteSection routeSection = AddSection(sectionPrefab);
	}

	protected unsafe RouteSection AddSection(RouteSection sectionPrefab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0111: Expected I, but got Obj
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0148: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I
		//IL_0179: Expected F4, but got I
		//IL_0174: Expected native int or pointer, but got VT
		//IL_0198: Expected F4, but got I
		//IL_0193: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		int num = SectionCountUsed__BackingField + 1;
		SectionCountUsed__BackingField = num;
		Transform transform = sectionPrefab.transform;
		Transform transform2 = PoolManager.Spawn(transform);
		GameObject gameObject = transform2.gameObject;
		gameObject.SetActive(value: true);
		transform2.parent = _originTransfrom;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num3 = 0;
		object obj2 = Vector3.forwardVector * _length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
		object obj3 = (nint)0 * (nint)_length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		object obj4 = (nint)0 * (nint)_length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		transform2.localPosition = vector;
		RouteSection component = transform2.GetComponent<RouteSection>();
		component.Reset(this);
		_sections.Add(component);
		_currentSection = component;
		Action<Route, RouteSection, float> onAddedSection = OnAddedSection;
		if (OnAddedSection != null)
		{
			Vector3 position = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S0_v44 (System.Action`3<SYBO.Subway.Routes.Route, SYBO.Subway.Routes.RouteSection, System.Single>)+C] (should have been resolved before IL gen)");
		}
		if (OnGlobalAddedSection != null)
		{
			Action<Route, RouteSection, float> onGlobalAddedSection = OnGlobalAddedSection;
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ S0_v59 (System.Action`3<SYBO.Subway.Routes.Route, SYBO.Subway.Routes.RouteSection, System.Single>)+C] (should have been resolved before IL gen)");
		}
		return component;
	}

	public unsafe bool AddTransitionSectionTo(RouteType routeType, out RouteSection routeSection)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		ref RouteSection reference = ref *(RouteSection*)null;
		if (!ReadyToAddSection)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			_ = 0;
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
		if ((nint)0 != 0)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
		_ = 0;
		object obj4 = obj + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	private void IncrementSectionProgressState()
	{
		while (_sectionLayingProgress != RouteBuildProgress.Done)
		{
			int progressStateSectionCount = GetProgressStateSectionCount(_sectionLayingProgress);
			if (_sectionLayingProgress == RouteBuildProgress.Mid && progressStateSectionCount >= 1 && (~(_midSectionsCountLimited ? 1u : 0u) != 0 || _midSectionCountUsed < _midSectionsCountTarget))
			{
				break;
			}
			RouteBuildProgress routeBuildProgress = ++_sectionLayingProgress;
			if (routeBuildProgress != RouteBuildProgress.Done)
			{
				if (GetProgressStateSectionCount(routeBuildProgress) != 0)
				{
					break;
				}
				continue;
			}
			_completedSectionLayingThisUpdate = true;
			break;
		}
	}

	private int GetProgressStateSectionCount(RouteBuildProgress progressState)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		string text = default;
		switch (progressState)
		{
		case RouteBuildProgress.Mid:
		{
			WeightRandomizedRouteSectionContainter midSectionPrefabs = _midSectionPrefabs;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S2_v5 (Il2CppRgctx<SYBO.Subway.Routes.WeightRandomizedPrefabContainter`2<SYBO.Subway.Routes.WeightedRouteSection, SYBO.Subway.Routes.RouteSection>>)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S2_v6+4] (should have been resolved before IL gen)");
			int result = default;
			return result;
		}
		case RouteBuildProgress.End:
		{
			List<TransitionSectionInfo> endSectionPrefabs = _endSectionPrefabs;
			return endSectionPrefabs._size;
		}
		default:
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			_ = -1;
			object obj3 = default;
			obj = (Enum)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			text = obj.ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			SwitchDefaultException ex = default;
			ex._002Ector(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			break;
		}
		case RouteBuildProgress.Start:
			break;
		}
		List<TransitionSectionInfo> startSectionPrefabs = ((RouteBuilder)(object)text)._startSectionPrefabs;
		return startSectionPrefabs._size;
	}

	protected unsafe RouteChunk SpawnRouteChunk(RouteChunk chunkPrefab)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_027e: Expected I, but got Obj
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		//IL_02b5: Expected Obj, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got I
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected VT, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a7: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_0110: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected VT, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected VT, but got Unknown
		//IL_0136: Expected Ref, but got VT
		//IL_01f3: Expected Obj, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected I4, but got Unknown
		object obj = default;
		RouteBuilder routeBuilder = (RouteBuilder)(obj - 112);
		Transform transform = chunkPrefab.transform;
		Transform transform2 = PoolManager.Spawn(transform);
		GameObject gameObject = transform2.gameObject;
		gameObject.SetActive(value: true);
		Transform transform3 = _currentSection.transform;
		transform2.parent = transform3;
		transform2.SetAsLastSibling();
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		object obj2 = Vector3.forwardVector * _length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
		object obj3 = (nint)0 * (nint)_length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+90]");
		RouteBuilder builderForward = (RouteBuilder)(0 + obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		object obj4 = (nint)0 * (nint)_length;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+94]");
		List<RouteBuilder> buildersOnSides = (List<RouteBuilder>)(0 + obj4);
		routeBuilder._buildersOnSides = buildersOnSides;
		routeBuilder._endSectionPrefabs = (List<TransitionSectionInfo>)(object)routeBuilder._buildersOnSides;
		routeBuilder._builderForward = builderForward;
		List<RouteBuilder> buildersBelow = (List<RouteBuilder>)(_originPosition + obj2);
		routeBuilder._buildersBelow = buildersBelow;
		routeBuilder._midSectionPrefabs = (WeightRandomizedRouteSectionContainter)(object)routeBuilder._buildersBelow;
		Vector3 position = (Vector3)(routeBuilder + 32);
		transform2.position = position;
		RouteChunk component = transform2.GetComponent<RouteChunk>();
		component._builder = this;
		component._section = _currentSection;
		component._sourcePrefab = chunkPrefab;
		_currentSection.AddSpawnedChunk(component);
		int spawnedChunkCount = _spawnedChunkCount + 1;
		_spawnedChunkCount = spawnedChunkCount;
		Bounds trackBounds = component.TrackBounds;
		object obj5 = routeBuilder - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.Builders.RouteBuilder)+58]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.Builders.RouteBuilder)+50]");
		routeBuilder._secionSpawnMode = SectionSpawnMode.None;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.Builders.RouteBuilder)+50]");
		routeBuilder._routeHeight = RouteHeight.None;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.Builders.RouteBuilder)+58]");
		routeBuilder._midSectionsCountTarget = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.Builders.RouteBuilder)+48]");
		routeBuilder._fallbackSection = (RouteSection)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Routes.Builders.RouteBuilder)+48]");
		routeBuilder.OnAddedSection = (Action<Route, RouteSection, float>)0;
		Bounds bounds = (Bounds)(this + 68);
		Bounds bounds2 = (Bounds)(routeBuilder + 8);
		((Bounds*)bounds)->Encapsulate(bounds2);
		List<RouteChunk> chunks = _chunks;
		bool flag = chunks._size == 0;
		RouteChunk routeChunk = null;
		if (!flag)
		{
			List<RouteChunk> chunks2 = _chunks;
			int index = chunks2._size - 1;
			RouteChunk routeChunk2 = chunks2.get_Item(index);
			routeChunk = routeChunk2;
		}
		if (routeChunk != null)
		{
			routeBuilder.SetChunkCrossReferences(routeChunk, component);
		}
		_chunksSpawnedThisUpdate.Add(component);
		_chunks.Add(component);
		object obj6 = component._blockCount * 90;
		int length = _length + obj6;
		_length = length;
		Action<Route, RouteChunk, float> onRouteChunkSpawned = OnRouteChunkSpawned;
		if (OnRouteChunkSpawned != null)
		{
			Vector3 position2 = transform2.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ S0_v80 (System.Action`3<SYBO.Subway.Routes.Route, SYBO.Subway.Routes.RouteChunk, System.Single>)+C] (should have been resolved before IL gen)");
		}
		return component;
	}

	private void SetChunkCrossReferences(RouteChunk previous, RouteChunk next)
	{
		if (previous != null)
		{
			previous.Next = next;
		}
		if (next != null)
		{
			next.Previous = previous;
		}
	}

	public unsafe RouteChunk GetChunkContainingPoint(Vector3 point)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected VT, but got Unknown
		//IL_006e: Expected Ref, but got VT
		//IL_0087: Invalid comparison between F4 and I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected VT, but got Unknown
		//IL_00bd: Expected Ref, but got VT
		//IL_00d6: Invalid comparison between F4 and I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		int num = 0;
		RouteChunk result;
		while (true)
		{
			List<RouteChunk> chunks = _chunks;
			bool flag = num >= chunks._size;
			result = null;
			if (flag)
			{
				break;
			}
			RouteChunk routeChunk = _chunks.get_Item(num);
			Bounds trackBounds = routeChunk.TrackBounds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Bounds bounds = (Bounds)(obj + 24);
			Vector3 min = ((Bounds*)bounds)->min;
			float z = point.z;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if (z > 0f)
			{
				Bounds bounds2 = (Bounds)(obj + 24);
				Vector3 max = ((Bounds*)bounds2)->max;
				float z2 = point.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				bool flag2 = z2 < 0f;
				result = routeChunk;
				if (flag2)
				{
					break;
				}
			}
			int num2 = num + 1;
			num = num2;
		}
		return result;
	}

	protected unsafe void DespawnRouteChunk(RouteChunk chunk, bool instantDespawn)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected VT, but got Unknown
		//IL_00fa: Expected Obj, but got VT
		//IL_011a: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I4
		//IL_022e: Expected VT, but got I
		//IL_0229: Expected native int or pointer, but got VT
		//IL_0244: Expected Ref, but got VT
		//IL_0251: Expected Ref, but got VT
		//IL_025e: Expected Ref, but got VT
		//IL_0026: Expected Obj, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0055: Expected F4, but got I
		//IL_0050: Expected native int or pointer, but got VT
		//IL_0084: Expected F4, but got I
		//IL_007f: Expected native int or pointer, but got VT
		//IL_0091: Expected Ref, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		object obj2 = vector - -64;
		Bounds bounds = (Bounds)(this + 68);
		obj2 = bounds.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (UnityEngine.Bounds)+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
		float num3 = 0f * 0.5f;
		float num4 = (float)Vector3.forwardVector * 0.5f;
		object obj3 = chunk._blockCount * 90;
		float num5 = num4 * (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		float num6 = 0f * 0.5f;
		float num7 = num6 * (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		float num8 = 0f + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		float num9 = num3 * (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		float num10 = 0f + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		float num11 = 0f + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Bounds bounds2 = bounds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Bounds*)(nint)bounds2)->m_Center = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		_ = 0;
		Vector3 size = ((Bounds*)bounds)->size;
		Vector3 size2 = ((Bounds*)bounds)->size;
		Vector3 size3 = ((Bounds*)bounds)->size;
		object obj4 = chunk._blockCount * 90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		object obj5 = 0 - obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		((Bounds*)bounds)->size = vector;
		bool flag = _chunks.Remove(chunk);
		IEnumerator workRoutine = DespawnRouteChunkASync(chunk);
		_worker.EnqueueDespawnWork(chunk, workRoutine, instantDespawn);
	}

	private IEnumerator DespawnRouteChunkASync(RouteChunk chunk)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	protected void DespawnAllRouteChunks()
	{
		List<RouteChunk> chunks = _chunks;
		int num = chunks._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 <= -1)
			{
				break;
			}
			RouteChunk chunk = _chunks.get_Item(num2);
			DespawnRouteChunk(chunk, instantDespawn: true);
			num = num2;
		}
		List<RouteSection> sections = _sections;
		int num3 = sections._size;
		while (true)
		{
			int num4 = num3 - 1;
			if (num4 <= -1)
			{
				break;
			}
			RouteSection routeSection = _sections.get_Item(num4);
			Transform transform = routeSection.transform;
			PoolManager.Despawn(transform);
			num3 = num4;
		}
		((List<T>)(object)_sections).Clear();
	}

	protected void DespawnPassedChunks(float characterZ)
	{
		while (true)
		{
			List<RouteChunk> chunks = _chunks;
			if (chunks._size >= 1)
			{
				RouteChunk chunk = _chunks.get_Item(0);
				if (CanDespawnPassedChunk(chunk, characterZ))
				{
					RouteChunk chunk2 = _chunks.get_Item(0);
					DespawnRouteChunk(chunk2, instantDespawn: false);
					continue;
				}
				break;
			}
			break;
		}
	}

	private bool CanDespawnPassedChunk(RouteChunk chunk, float characterZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		RouteManager routeManager = _routeManager;
		bool flag = routeManager._characterChunksNear.Contains(chunk);
		bool result = false;
		if (!flag)
		{
			Vector3 posEnd = chunk.PosEnd;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			float num = 0f + 170f;
			bool flag2 = characterZ > num;
			bool flag3 = !flag2;
			result = false;
			if (!flag3)
			{
				result = true;
			}
		}
		return result;
	}

	protected void DespawnUnbuiltChunks(float characterZ)
	{
		List<RouteChunk> chunks = _chunks;
		int num = chunks._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 > -1)
			{
				RouteChunk routeChunk = _chunks.get_Item(num2);
				num = num2;
				if (!routeChunk._built)
				{
					DespawnRouteChunk(routeChunk, instantDespawn: false);
					num = num2;
				}
				continue;
			}
			break;
		}
	}

	protected void RemoveEmptySections(float characterZ)
	{
		while (true)
		{
			List<RouteSection> sections = _sections;
			if (sections._size >= 1)
			{
				RouteSection routeSection = _sections.get_Item(0);
				if (routeSection.SpawnedChunkCount == 0)
				{
					RouteSection routeSection2 = _sections.get_Item(0);
					bool flag = _sections.Remove(routeSection2);
					Transform transform = routeSection2.transform;
					PoolManager.Despawn(transform);
					continue;
				}
				break;
			}
			break;
		}
	}

	private IEnumerator PerformSelectionASync(RouteChunk chunk)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator RecursiveSelectionASync(List<Selector> selectors, List<GameObject> objectsToVisit, List<Selector> spawnPoints)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void RouteBuilder_OnCompletedLayingSections(object sender, EventArgs args)
	{
	}

	private void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind spawnedKind, int posZ, Route route)
	{
		//IL_005b: Expected F4, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_00a0: Expected F4, but got I4
		//IL_00a0: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		if (obj != null)
		{
			LinkedList<EnvironmentRangeWrapper> environmentWrapperQueue = _environmentWrapperQueue;
			if (environmentWrapperQueue.count >= 1)
			{
				EnvironmentRangeWrapper environmentRangeWrapper = Enumerable.Last(_environmentWrapperQueue);
				environmentRangeWrapper.EndPositionZ = posZ;
			}
			EnvironmentKind lastSpawnedEnvironmentKind = _lastSpawnedEnvironmentKind;
			bool flag = spawnedKind._type == lastSpawnedEnvironmentKind._type && spawnedKind._density == lastSpawnedEnvironmentKind._density;
			object obj2 = (flag ? 1 : 0) ^ 1;
			if (obj2 != null)
			{
				EnvironmentRangeWrapper environmentRangeWrapper2 = default;
				environmentRangeWrapper2._002Ector(spawnedKind, posZ, posZ);
				LinkedListNode<EnvironmentRangeWrapper> linkedListNode = _environmentWrapperQueue.AddLast(environmentRangeWrapper2);
				_lastSpawnedEnvironmentKind = spawnedKind;
			}
		}
	}

	public EnvironmentKind GetEnvironmentKindAt(float worldPositionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I
		//IL_00eb: Invalid comparison between I and F4
		//IL_011d: Invalid comparison between I and F4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0189: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		LinkedList<EnvironmentRangeWrapper> environmentWrapperQueue = _environmentWrapperQueue;
		EnvironmentKind result;
		if (environmentWrapperQueue.count >= 1)
		{
			object obj3 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C6");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			object obj4 = obj + 40;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = default;
			object obj9 = default;
			object obj10 = default;
			EnvironmentKind environmentKind = default;
			EnvironmentKind environmentKind2 = default;
			EnvironmentKind result2 = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						goto IL_0227;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
					object obj7 = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v83+C]");
						if (!(0f > worldPositionZ))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v83+10]");
							if (0f > worldPositionZ)
							{
								object obj8 = obj + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5394");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v83+8]");
								result = (EnvironmentKind)0;
								break;
							}
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj9 != obj10;
				result = environmentKind;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_0227;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					result = environmentKind2;
				}
				_ = 0;
				object obj11 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return result2;
				IL_0227:
				object obj12 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5394");
				EnvironmentRangeWrapper environmentRangeWrapper = Enumerable.Last(_environmentWrapperQueue);
				result = environmentRangeWrapper.EnvironmentKind;
				break;
			}
		}
		else
		{
			EnvironmentKind none = EnvironmentKind.None;
			result = none;
		}
		return result;
	}
}
