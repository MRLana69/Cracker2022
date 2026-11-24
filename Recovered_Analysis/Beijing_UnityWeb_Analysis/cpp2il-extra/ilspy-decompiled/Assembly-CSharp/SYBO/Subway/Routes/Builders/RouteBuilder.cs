using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Common.Builders;
using SYBO.Common.Components;
using SYBO.Common.StateSystem;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Placeholders;
using SYBO.Subway.Routes.Builders.Worker;
using SYBO.Subway.Routes.Log;
using SYBO.Subway.StateSystem;
using SYBO.Subway.StateSystem.States;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Routes.Builders;

[Serializable]
public abstract class RouteBuilder
{
	private struct BuildDirective
	{
		public readonly int GamePositionZ;

		public readonly bool IsApplicablePositionStrict;

		public readonly RouteSection Section;

		public readonly SectionSpawnMode SectionSpawnMode;

		public readonly ChunkBuildMode ChunkBuildMode;

		public bool HasSection => (byte)SectionSpawnMode != 0;

		public unsafe BuildDirective(int gamePositionZ, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, bool isApplicablePositionStrict = true, RouteSection section = null)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_0064: Expected Obj, but got Ref
			//IL_006c: Expected Obj, but got I4
			//IL_0077: Expected Obj, but got Ref
			//IL_007f: Expected Obj, but got I4
			//IL_008a: Expected Obj, but got Ref
			//IL_0092: Expected Obj, but got I4
			//IL_009d: Expected Obj, but got Ref
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
			obj6 = sectionSpawnMode;
			object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 20));
			obj7 = chunkBuildMode;
			object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
			obj8 = isApplicablePositionStrict;
			object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 28));
			obj9 = section;
		}

		public unsafe override string ToString()
		{
			//IL_000b: Expected Obj, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F8");
			string result = default;
			return result;
		}
	}

	[Serializable]
	public class EnvironmentKindRepeatConfig
	{
		public EnvironmentKind EnvironmentKind;

		public int RepeatDistance;

		public void Validate()
		{
		}

		public EnvironmentKindRepeatConfig()
		{
			//IL_00ef: Expected I, but got Obj
			//IL_0105: Expected Obj, but got I
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Expected Obj, but got Unknown
			//IL_003a: Expected I, but got Obj
			//IL_0050: Expected Obj, but got I
			//IL_0130: Expected I, but got Obj
			//IL_01ca: Expected I4, but got Obj
			//IL_007b: Expected I, but got Obj
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected Obj, but got Unknown
			//IL_00dc: Expected Obj, but got I4
			EnvironmentKind environmentKind = EnvironmentKind;
			if (environmentKind._type == EnvironmentType.Fillers || environmentKind._type == EnvironmentType.Tube)
			{
				nint num = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v14 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v24 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (EnvironmentKind.GetDefaultDensity((EnvironmentType)EnvironmentKind) == EnvironmentDensity.Default)
				{
					object obj2 = this + 8;
					bool flag = EnvironmentKind.IsValidDensity(EnvironmentKind);
					obj2 = flag;
				}
			}
			else
			{
				nint num3 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v13 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v19 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj4 = this + 8;
				GamePositionRoot instance = GamePositionRoot.Instance;
				obj4 = instance;
			}
			int num5 = RepeatDistance / 180;
			int repeatDistance = num5 * 180;
			RepeatDistance = repeatDistance;
		}
	}

	[Serializable]
	public class TransitionSectionInfo
	{
		public RouteType TransitionRouteType;

		public RouteSection Section;

		public TransitionSectionInfo()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00ba: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EnvironmentKind);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 8;
			GamePositionRoot instance = GamePositionRoot.Instance;
			obj2 = instance;
			Section = (RouteSection)2160;
		}
	}

	private class EnvironmentRangeWrapper
	{
		public EnvironmentKind EnvironmentKind;

		public float StartGamePositionZ;

		public float EndGamePositionZ;

		public EnvironmentRangeWrapper(EnvironmentKind kind, float startGamePositionZ, float endGamePositionZ)
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_007d: Expected I, but got Obj
			//IL_0093: Expected Obj, but got I
			//IL_00d7: Expected F4, but got I4
			//IL_0013: Expected I, but got Obj
			object obj = this + 8;
			obj = kind;
			StartGamePositionZ = startGamePositionZ;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float f = endGamePositionZ + 0.5f;
			int num3 = Mathf.RoundToInt(f);
			EndGamePositionZ = num3;
		}
	}

	private sealed class _003CPerformSelectionAndActivationASync_003Ed__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteBuilder _003C_003E4__this;

		public RouteChunk chunk;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Expected Obj, but got Unknown
				//IL_00a9: Expected Obj, but got I4
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Expected Obj, but got Unknown
				//IL_00ef: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					object obj = this + 12;
					IEnumerator enumerator = chunk.DeactivateTrackObjects();
					obj = enumerator;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj2 = this + 12;
				GameObject gameObject = ((Placeholder)(object)_003C_003E4__this).SpawnInstance((Transform)(object)chunk);
				obj2 = gameObject;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CPerformSelectionAndActivationASync_003Ed__145(int _003C_003E1__state)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Expected Obj, but got Unknown
			//IL_0367: Expected Obj, but got I4
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Expected Obj, but got Unknown
			//IL_0397: Expected I, but got Obj
			//IL_03ad: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Expected Obj, but got Unknown
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Expected Obj, but got Unknown
			//IL_047e: Expected Obj, but got I4
			//IL_00c6: Expected I, but got Obj
			//IL_00dc: Expected Obj, but got I
			//IL_02a6: Expected Obj, but got I
			//IL_0107: Expected I, but got Obj
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Expected Obj, but got Unknown
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Expected Obj, but got Unknown
			//IL_0180: Expected I, but got Obj
			//IL_0196: Expected Obj, but got I
			//IL_01c1: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v131 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = ((this._003C_003E1__state > 0) ? this._003C_003E1__state : 0);
			this._003C_003E1__state = num3;
			RouteBuilder routeBuilder = _003C_003E4__this;
			if ((nint)_003C_003E4__this <= 0)
			{
				routeBuilder = null;
			}
			_003C_003E4__this = routeBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj6 = default;
			object obj8 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v83 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v124 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj8 == null)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num6 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v97 (Il2CppClass<Utils>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num7 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v117 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			object obj10 = obj4 + 4;
			object obj11 = obj10 + 1;
			obj10 = obj11;
			object obj12 = obj11 << 2;
			object obj13 = obj4 + obj12;
			obj13 = 117;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj14 = (nint)0 << 2;
				object obj15 = obj4 + obj14;
				if ((nint)obj15 == 117)
				{
					object obj16 = obj4 + 4;
					if ((nint)obj16 > -1)
					{
						object obj17 = obj16 + -1;
						obj16 = obj17;
					}
					return;
				}
			}
			object obj18 = default;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_000e: Expected I4, but got Obj
			ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
			return (byte)(int)ex != 0;
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

	private sealed class _003CDespawnRouteChunkASync_003Ed__176(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteChunk chunk;

		public RouteBuilder _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_0069: Expected VT, but got Obj
				//IL_0075: Expected Obj, but got I4
				//IL_0089: Expected Obj, but got I4
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Expected Obj, but got Unknown
				//IL_00bb: Expected Obj, but got I4
				//IL_00cf: Expected Obj, but got I4
				//IL_01c6: Expected I, but got Obj
				//IL_01dc: Expected Obj, but got I
				//IL_0129: Expected I, but got Obj
				//IL_013f: Expected Obj, but got I
				//IL_0207: Expected I, but got Obj
				//IL_016a: Expected I, but got Obj
				RouteBuilder routeBuilder = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							if (routeBuilder._routeHeight == RouteHeight.Pos1)
							{
								string tag = chunk.tag;
								nint num = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
								object obj = (nint)0 & (nint)0x200;
								if (obj != null)
								{
									nint num2 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)tag);
							}
							else
							{
								GameObject gameObject = chunk.gameObject;
								nint num3 = (nint)typeof(PoolManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v22 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
								object obj2 = (nint)0 & (nint)0x200;
								if (obj2 != null)
								{
									nint num4 = (nint)typeof(PoolManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v27 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								PoolManager.AddPool((PrefabPool)(object)gameObject);
							}
							RouteChunk routeChunk = chunk;
							((RouteTransitionTrigger)(object)routeChunk._section).TargetRoute = (Route)(object)chunk;
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
					object obj3 = this + 12;
					bool generateEnvironmentBase = chunk.GenerateEnvironmentBase;
					obj3 = generateEnvironmentBase;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj4 = this + 12;
				int blockIndexFromLocalPosition = RouteChunk.GetBlockIndexFromLocalPosition((Vector3)chunk);
				obj4 = blockIndexFromLocalPosition;
				_003C_003E1__state = 1;
				return 1;
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

	private sealed class _003CPerformSelectionASync_003Ed__182(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RouteBuilder _003C_003E4__this;

		public RouteChunk chunk;

		private List<Selector> _003CspawnPoints_003E5__2;

		private List<GameObject> _003CobjectsToVisit_003E5__3;

		private List<Selector>.Enumerator _003C_003E7__wrap3;

		private List<GameObject>.Enumerator _003C_003E7__wrap4;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_05f2: Expected Obj, but got Unknown
				//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0600: Expected Obj, but got Unknown
				//IL_0252: Unknown result type (might be due to invalid IL or missing references)
				//IL_0257: Expected Obj, but got Unknown
				//IL_0273: Expected Obj, but got I4
				//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e5: Expected Obj, but got Unknown
				//IL_031a: Unknown result type (might be due to invalid IL or missing references)
				//IL_031f: Expected Obj, but got Unknown
				//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_06d8: Expected Obj, but got Unknown
				//IL_0491: Unknown result type (might be due to invalid IL or missing references)
				//IL_0496: Expected Obj, but got Unknown
				//IL_0459: Unknown result type (might be due to invalid IL or missing references)
				//IL_045e: Expected Obj, but got Unknown
				//IL_0467: Expected Obj, but got I4
				//IL_047b: Expected Obj, but got I4
				//IL_038a: Unknown result type (might be due to invalid IL or missing references)
				//IL_038f: Expected Obj, but got Unknown
				//IL_051b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0520: Expected Obj, but got Unknown
				//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ec: Expected Obj, but got Unknown
				//IL_0501: Unknown result type (might be due to invalid IL or missing references)
				//IL_0506: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 + 48;
				object obj3 = obj2 + 24;
				object obj4 = obj2 + 16;
				obj4 = obj;
				_ = -1;
				RouteBuilder routeBuilder = _003C_003E4__this;
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
									goto IL_06c8;
								}
								goto IL_0480;
							}
						}
						else
						{
							_003C_003E1__state = -1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj3 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
							object obj5 = this + 32;
							obj5 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
							_ = 0;
						}
						_003C_003E1__state = -3;
						object obj6 = this + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						object obj7 = default;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj8 = this + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							obj3 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
							object obj9 = this + 48;
							obj9 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
							_ = 0;
							goto IL_0480;
						}
						object obj10 = this + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						object obj11 = this + 12;
						obj11 = 0;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
					object obj12 = this + 12;
					object obj13 = default;
					obj12 = obj13;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj15 = default;
				object obj14 = obj15;
				object obj17 = default;
				object obj16 = obj17;
				goto IL_0656;
				IL_0480:
				_003C_003E1__state = -4;
				object obj18 = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj19 = default;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					object obj20 = this + 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
					goto IL_06c8;
				}
				object obj21 = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj22 = default;
				obj14 = obj22;
				obj16 = obj17;
				goto IL_0656;
				IL_06c8:
				object result = default;
				return result;
				IL_0656:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj23 = default;
				if (obj16 != obj23)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				_003C_003Em__Finally1();
				object obj24 = default;
				if (obj24 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_06c8;
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

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00b6: Expected Obj, but got I4
			//IL_0056: Expected Obj, but got I4
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected Obj, but got Unknown
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected Obj, but got Unknown
			//IL_0250: Expected Obj, but got I4
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected Obj, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Expected Obj, but got Unknown
			//IL_0149: Expected Obj, but got I4
			//IL_029f: Expected Obj, but got I
			//IL_018a: Expected Obj, but got I
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected Obj, but got Unknown
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Expected Obj, but got Unknown
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Expected Obj, but got Unknown
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			if (_003C_003E1__state > -3)
			{
				object obj3 = _003C_003E1__state - 3;
				if (_003C_003E1__state == 3)
				{
					goto IL_0101;
				}
				if ((nint)obj3 != 1)
				{
					return;
				}
			}
			else
			{
				object obj4 = _003C_003E1__state - -4;
				if (_003C_003E1__state != -4)
				{
					if ((nint)obj4 != 1)
					{
						return;
					}
					goto IL_0101;
				}
			}
			goto IL_0208;
			IL_0101:
			object obj5 = obj + 4;
			object obj6 = obj5 + 1;
			obj5 = obj6;
			object obj7 = obj6 << 2;
			object obj8 = obj + obj7;
			obj8 = 52;
			_003C_003Em__Finally2();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
				object obj9 = (nint)0 << 2;
				object obj10 = obj + obj9;
				if ((nint)obj10 == 52)
				{
					object obj11 = obj + 4;
					if ((nint)obj11 > -1)
					{
						object obj12 = obj11 + -1;
						obj11 = obj12;
					}
					return;
				}
			}
			goto IL_0208;
			IL_0208:
			object obj13 = obj + 4;
			object obj14 = obj13 + 1;
			obj13 = obj14;
			object obj15 = obj14 << 2;
			object obj16 = obj + obj15;
			obj16 = 52;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj + obj17;
			if ((nint)obj18 == 52)
			{
				object obj19 = obj + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -1;
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
		}
	}

	private sealed class _003CRecursiveSelectionASync_003Ed__183(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0be8: Expected Obj, but got Unknown
				//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bf6: Expected Obj, but got Unknown
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dd: Expected Obj, but got Unknown
				//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cd0: Expected Obj, but got Unknown
				//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a3d: Expected Obj, but got Unknown
				//IL_0113: Unknown result type (might be due to invalid IL or missing references)
				//IL_0118: Expected Obj, but got Unknown
				//IL_0121: Expected Obj, but got I4
				//IL_0175: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Expected Obj, but got Unknown
				//IL_016a: Expected Obj, but got I4
				//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0af8: Expected Obj, but got Unknown
				//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a93: Expected Obj, but got Unknown
				//IL_036e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0373: Expected Obj, but got Unknown
				//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b40: Expected Obj, but got Unknown
				//IL_0b5c: Expected Obj, but got I4
				//IL_021f: Expected I, but got Obj
				//IL_0235: Expected Obj, but got I
				//IL_0260: Expected I, but got Obj
				//IL_0360: Expected Obj, but got I4
				//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a13: Expected Obj, but got Unknown
				object obj2 = default;
				object obj = obj2 + 48;
				object obj3 = obj2 + 24;
				object obj4 = obj2 + 16;
				obj4 = obj;
				_ = -1;
				RouteBuilder routeBuilder = _003C_003E4__this;
				object obj10;
				object obj11 = default;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -4;
						object obj5 = this + 52;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						object obj6 = default;
						if (obj6 != null)
						{
							object obj7 = this + 52;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj9 = default;
							object obj8 = obj9;
							obj10 = obj11;
							goto IL_0c32;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						object obj12 = this + 52;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
						object obj13 = this + 12;
						object obj14 = default;
						obj13 = obj14;
						_003C_003E1__state = 2;
						return 1;
					}
					if (_003C_003E1__state != 2)
					{
						goto IL_0c66;
					}
					_003C_003E1__state = -3;
					object obj15 = this + 48;
					obj15 = 0;
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					object obj16 = this + 32;
					obj16 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					_003C_003E1__state = -3;
				}
				object obj18 = default;
				object obj19;
				object obj21 = default;
				object obj23 = default;
				object obj24 = default;
				object obj26 = default;
				while (true)
				{
					object obj17 = this + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj18 == null)
					{
						obj19 = 55;
						break;
					}
					object obj20 = this + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj25;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						nint num = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S0_v135 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							nint num2 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ S0_v152 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if (obj24 != null)
							{
								obj25 = obj26;
								obj19 = 30;
								break;
							}
						}
					}
					obj25 = obj26;
				}
				object obj27 = obj19 - 14;
				if ((nint)obj19 != 14)
				{
					if ((nint)obj27 != 1)
					{
						if ((nint)obj27 == 2 || (nint)obj27 == 3 || (nint)obj27 == 4 || (nint)obj27 == 5)
						{
							goto IL_0c66;
						}
						if ((nint)obj27 != 6)
						{
							if ((nint)obj27 != 7)
							{
								if ((nint)obj27 == 8 || (nint)obj27 == 9)
								{
									goto IL_0c66;
								}
								if ((nint)obj27 != 10)
								{
									if ((nint)obj27 == 11 || (nint)obj27 == 12 || (nint)obj27 == 13)
									{
										goto IL_0c66;
									}
									if ((nint)obj27 != 14)
									{
										if ((nint)obj27 != 15)
										{
											object obj8;
											if ((nint)obj27 != 16)
											{
												if ((nint)obj27 != 17 && (nint)obj27 != 18 && (nint)obj27 != 19 && (nint)obj27 != 20 && (nint)obj27 != 21 && (nint)obj27 != 22 && (nint)obj27 != 23 && (nint)obj27 != 24 && (nint)obj27 != 25 && (nint)obj27 != 26 && (nint)obj27 != 27 && (nint)obj27 != 28 && (nint)obj27 != 29 && (nint)obj27 != 30 && (nint)obj27 != 31 && (nint)obj27 != 32 && (nint)obj27 != 33 && (nint)obj27 != 34 && (nint)obj27 != 35 && (nint)obj27 != 36 && (nint)obj27 != 37 && (nint)obj27 != 38 && (nint)obj27 != 39)
												{
													if ((nint)obj27 == 40)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj28 = default;
														obj8 = obj28;
														obj10 = obj11;
														goto IL_0c32;
													}
													if ((nint)obj27 == 41)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
														object obj29 = this + 32;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
													}
												}
												goto IL_0c66;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj30 = default;
											obj8 = obj30;
											obj10 = obj11;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj31 = default;
											object obj8 = obj31;
											obj10 = obj11;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj32 = default;
										object obj8 = obj32;
										obj10 = obj11;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj33 = default;
									object obj8 = obj33;
									obj10 = obj11;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj34 = default;
								object obj8 = obj34;
								obj10 = obj11;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj35 = default;
							object obj8 = obj35;
							obj10 = obj11;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj36 = default;
						object obj8 = obj36;
						obj10 = obj11;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj37 = default;
					object obj8 = obj37;
					obj10 = obj11;
				}
				goto IL_0c32;
				IL_0c32:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj38 = default;
				if (obj10 != obj38)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				_003C_003Em__Finally1();
				object obj39 = default;
				if (obj39 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_0c66;
				IL_0c66:
				object result = default;
				return result;
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

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_008e: Expected Obj, but got I4
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected Obj, but got Unknown
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected Obj, but got Unknown
			//IL_018b: Expected Obj, but got I4
			//IL_005c: Expected Obj, but got I4
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Expected Obj, but got Unknown
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Expected Obj, but got Unknown
			//IL_0279: Expected Obj, but got I4
			//IL_0294: Expected Obj, but got I
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Expected Obj, but got Unknown
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_030d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -4;
			if ((nint)obj3 > 1)
			{
				object obj4 = _003C_003E1__state - 1;
				if ((nint)obj4 >= 2)
				{
					return;
				}
			}
			object obj5 = _003C_003E1__state - -4;
			if (_003C_003E1__state == -4 || ((nint)obj5 != 1 && (nint)obj5 != 2 && (nint)obj5 != 3 && (nint)obj5 != 4 && (nint)obj5 == 5))
			{
				object obj6 = obj + 4;
				object obj7 = obj6 + 1;
				obj6 = obj7;
				object obj8 = obj7 << 2;
				object obj9 = obj + obj8;
				obj9 = 49;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj10 = default;
				object obj11 = default;
				if (obj10 == obj11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
			}
			else
			{
				object obj12 = obj + 4;
				object obj13 = obj12 + 1;
				obj12 = obj13;
				object obj14 = obj13 << 2;
				object obj15 = obj + obj14;
				obj15 = 49;
			}
			_003C_003Em__Finally2();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
				object obj16 = (nint)0 << 2;
				object obj17 = obj + obj16;
				if ((nint)obj17 == 49)
				{
					object obj18 = obj + 4;
					if ((nint)obj18 > -1)
					{
						object obj19 = obj18 + -1;
						obj18 = obj19;
					}
					return;
				}
			}
			object obj20 = default;
			if (obj20 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -1;
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -3;
		}
	}

	private const int RouteChunksToBuildForEntry = 1;

	public const int CameraToBackgroundGameDistance = 1000;

	public const int DistanceToChunksSpawned = 2000;

	public const int DistanceToChunksBuildStart = 1200;

	public const int DistanceToChunksReady = 1100;

	public const int DistanceStartCleanupAfterCharacter = 170;

	public const int DistanceDoneCleanupAfterCharacter = 2000;

	private EventHandler m_OnCompletedLayingSections;

	public Action<Route, RouteSection, float> OnAddedSection;

	public Action<Route, RouteChunk, float> OnRouteChunkSpawned;

	public static Action<Route, RouteSection, float> OnGlobalAddedSection;

	internal RouteHeight _routeHeight;

	private bool _midSectionsCountLimited;

	private int _midSectionsCountTarget;

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

	private List<RouteChunk> _chunks;

	private int _chunksBuiltCount;

	protected int _spawnedChunkCount;

	private RouteSection _lastSpawnedSection;

	private RouteBuildProgress _sectionLayingProgress;

	private int _midSectionCountUsed;

	protected RouteManager _routeManager;

	protected bool _stopped;

	private bool _completedSectionLayingThisUpdate;

	protected List<RouteChunk> _chunksSpawnedThisUpdate;

	protected List<RouteChunk> _chunksSpawnedDelayedBuild;

	protected List<IConstrainingRouteBuilder> _constrainingBuilders;

	protected LogicAssetsManager _logicAssetManager;

	protected ThemeManager _themeManager;

	protected Vector3 _originGamePosition;

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

	private EnvironmentKind DesiredEnvironmentKind__BackingField;

	private EnvironmentKind PreviousDesiredEnvironmentKind__BackingField;

	private int DistanceBuilt__BackingField;

	protected SyboRandom RandomGenerator
	{
		get
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+F4]");
			return (SyboRandom)0;
		}
		private set
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCompletedLayingSections;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)value);
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

	public RouteHeight RouteHeight
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (RouteHeight)RandomGenerator__BackingField;
		}
	}

	public int SpawnedLeadingEdgeGamePositionZ => (int)_routeHeight;

	public int SpawnedLeadingEdgeWorldPositionZ
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0063: Invalid comparison between I4 and F4
			//IL_009c: Invalid comparison between I4 and F4
			object obj = this + 168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			int num = (int)((nint)0 + (nint)_length);
			if (num != num)
			{
				num = int.MinValue;
			}
			else if (!((float)num < 2.1474836E+09f))
			{
				num = int.MinValue;
			}
			else if (!((float)num > -2.1474836E+09f))
			{
				num = int.MinValue;
			}
			return num;
		}
	}

	public int BuiltLeadingEdgeGamePositionZ
	{
		get
		{
			//IL_00e0: Expected I, but got Obj
			//IL_00f6: Expected Obj, but got I
			//IL_0069: Invalid comparison between I4 and F4
			//IL_0013: Expected I, but got Obj
			//IL_00a2: Invalid comparison between I4 and F4
			nint num = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isRestricted = AgeRestriction.isRestricted;
			int spawnedLeadingEdgeWorldPositionZ = SpawnedLeadingEdgeWorldPositionZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+10]");
			int num3 = (int)((nint)spawnedLeadingEdgeWorldPositionZ - (nint)0);
			if (num3 != num3)
			{
				num3 = int.MinValue;
			}
			else if (!((float)num3 < 2.1474836E+09f))
			{
				num3 = int.MinValue;
			}
			else if (!((float)num3 > -2.1474836E+09f))
			{
				num3 = int.MinValue;
			}
			return num3;
		}
	}

	public virtual int DistanceVisibleFromEntry
	{
		get
		{
			//IL_0158: Expected I, but got Obj
			//IL_016e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00d9: Invalid comparison between I and F4
			//IL_011a: Invalid comparison between I and F4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int result;
			if (_lastBuiltChunk != null)
			{
				result = SpawnedLeadingEdgeWorldPositionZ;
			}
			else
			{
				EnvironmentBaseKind environmentBaseKind = RouteChunk.EnvironentBaseToBaseKind((EnvironmentBase)(object)_lastBuiltChunk);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				result = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				if (num3 != 0)
				{
					result = int.MinValue;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					if (!(0f < 2.1474836E+09f))
					{
						result = int.MinValue;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						if (!(0f > -2.1474836E+09f))
						{
							result = int.MinValue;
						}
					}
				}
			}
			return result;
		}
	}

	public virtual int LastPositionVisibleFromEntry => 1080;

	public SectionSpawnMode SectionSpawnMode
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected I4, but got Unknown
			//IL_006b: Invalid comparison between I4 and F4
			//IL_00a4: Invalid comparison between I4 and F4
			object obj = this + 168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj2 = default;
			SectionSpawnMode sectionSpawnMode = (SectionSpawnMode)(0 + obj2);
			if (sectionSpawnMode != sectionSpawnMode)
			{
				sectionSpawnMode = (SectionSpawnMode)int.MinValue;
			}
			else if (!((float)sectionSpawnMode < 2.1474836E+09f))
			{
				sectionSpawnMode = (SectionSpawnMode)int.MinValue;
			}
			else if (!((float)sectionSpawnMode > -2.1474836E+09f))
			{
				sectionSpawnMode = (SectionSpawnMode)int.MinValue;
			}
			return sectionSpawnMode;
		}
	}

	public ChunkBuildMode ChunkBuildMode => (ChunkBuildMode)_secionSpawnMode;

	public Route Route
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			return (Route)(this - -64);
		}
	}

	public Bounds Bounds
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			Bounds bounds = default;
			object obj = bounds + 212;
			obj = this;
			return bounds;
		}
	}

	public bool IsDone
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_route != 0;
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
			if (_sectionLayingProgress == RouteBuildProgress.Done)
			{
				List<RouteChunk> chunksSpawnedDelayedBuild = _chunksSpawnedDelayedBuild;
				return chunksSpawnedDelayedBuild._size == 0;
			}
			return false;
		}
	}

	public RouteChunk FallbackRouteChunk
	{
		get
		{
			//IL_0040: Expected Obj, but got I4
			//IL_0022: Expected Obj, but got I4
			if (~(_stopped ? 1u : 0u) == 0)
			{
				return (RouteChunk)1;
			}
			bool flag = _sectionLayingProgress == RouteBuildProgress.Done;
			return (RouteChunk)flag;
		}
	}

	public RouteChunk LastChunk
	{
		get
		{
			//IL_0011: Expected I4, but got Obj
			return _fallbackSection.GetSpawnedChunk((int)RandomGenerator__BackingField);
		}
	}

	private RouteSection LastSection
	{
		get
		{
			if (_chunks != null)
			{
				List<RouteChunk> chunks = _chunks;
				if (chunks._size > 0)
				{
					List<RouteChunk> chunks2 = _chunks;
					int index = chunks2._size - 1;
					return (RouteSection)(object)_chunks.get_Item(index);
				}
				return null;
			}
			return null;
		}
	}

	public List<RouteBuilder> BuildersAbove
	{
		get
		{
			if (_sections != null)
			{
				List<RouteSection> sections = _sections;
				if (sections._size > 0)
				{
					List<RouteSection> sections2 = _sections;
					int index = sections2._size - 1;
					return (List<RouteBuilder>)(object)_sections.get_Item(index);
				}
				return null;
			}
			return null;
		}
	}

	public List<RouteBuilder> BuildersBelow => _buildersAbove;

	public RouteBuilder BuilderForward => (RouteBuilder)(object)_buildersBelow;

	public bool IsCleanedUp
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_builderForward != 0;
		}
	}

	public int SpawnedChunkCount
	{
		get
		{
			List<RouteChunk> chunks = _chunks;
			return (chunks._size == 0) ? 1 : 0;
		}
	}

	protected RouteBuildProgress SectionLayingProgress => (RouteBuildProgress)_spawnedChunkCount;

	public int MidSectionCountUsed => (int)_sectionLayingProgress;

	public int SectionCountUsed
	{
		get
		{
			return _midSectionCountUsed;
		}
		private set
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0028: Expected Obj, but got I
			//IL_003a: Expected Obj, but got I
			object obj = value + 72;
			RouteBuilder routeBuilder = (RouteBuilder)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			this.m_OnCompletedLayingSections = (EventHandler)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+10]");
			OnRouteChunkSpawned = (Action<Route, RouteChunk, float>)0;
		}
	}

	public bool ReadyToAddSection => (byte)SectionCountUsed__BackingField != 0;

	public virtual EnvironmentKind DesiredEnvironmentKind
	{
		get
		{
			//IL_0099: Expected I, but got Obj
			//IL_00af: Expected Obj, but got I
			//IL_0086: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_005b: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_currentSection != null)
			{
				return (EnvironmentKind)1;
			}
			RouteSection currentSection = _currentSection;
			bool flag = currentSection._progressState == RouteBuildProgress.Done;
			return (EnvironmentKind)flag;
		}
		protected set
		{
			//IL_000a: Expected I4, but got Obj
			SectionCountUsed__BackingField = (int)value;
		}
	}

	private EnvironmentKind PreviousDesiredEnvironmentKind
	{
		get
		{
			return DesiredEnvironmentKind__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 220;
			obj = value;
		}
	}

	private List<RouteBuilder> BuildersOnSides => (List<RouteBuilder>)(object)PreviousDesiredEnvironmentKind__BackingField;

	public List<IConstrainingRouteBuilder> ConstrainingBuilders
	{
		get
		{
			throw new IndexOutOfRangeException();
		}
	}

	protected int DistanceBuilt
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_constrainingBuilders;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 224;
			obj = value;
		}
	}

	public event EventHandler OnCompletedLayingSections
	{
		add
		{
			//IL_0025: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+F4]");
			((PickupSpawnPoint)this).SetSpawnPointForced((PickupType)value, SpawnPointDifficulty.Easy, true, true, false);
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnCompletedLayingSections;
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

	public RouteBuilder()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D06F");
		object obj = this + 240;
		object obj2 = default;
		obj = obj2;
		InitializeSectionGroups();
	}

	public virtual void Initialize(RouteManager routeManager, Route route, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator)
	{
		//IL_008d: Expected I4, but got Obj
		//IL_008d: Expected Obj, but got I4
		//IL_008d: Expected I4, but got Obj
		//IL_008d: Expected I4, but got Obj
		//IL_00b0: Expected VT, but got I
		//IL_00b0: Expected Obj, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I
		((Character)this).HandleStumble((Character.StumbleType)routeManager, (Character.StumbleHorizontalHit)route, (Character.StumbleVerticalHit)sectionSpawnMode, (string)chunkBuildMode, (byte)previousRouteType != 0, (byte)(int)randomGenerator != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+F0]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+EC]");
		((SemiRandomlyOrderedList<>)num).Consume((T)0, RandomGenerator__BackingField);
		object obj = this + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+F0]");
		EnvironmentKindRepeatConfig next = ((SemiRandomlyOrderedList<EnvironmentKindRepeatConfig>)0).GetNext(RandomGenerator__BackingField);
		obj = next;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+F8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+F8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v11+C]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+F8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	private void InitializeSectionGroups()
	{
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0283: Expected I, but got Obj
		//IL_0299: Expected Obj, but got I
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_02c4: Expected I, but got Obj
		_midSectionsCountTarget = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<TransitionSectionInfo> list = default;
		list._002Ector();
		object obj = this + 32;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		bool flag = default;
		RoutesLogManagerBridge.IsLogging = flag;
		object obj2 = this + 36;
		obj2 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj3 = this + 40;
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<TransitionSectionInfo> list2 = default;
		list2._002Ector();
		object obj5 = this + 44;
		obj5 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<RouteBuilder> list3 = default;
		list3._002Ector();
		object obj6 = this + 96;
		obj6 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<RouteBuilder> list4 = default;
		list4._002Ector();
		object obj7 = this + 100;
		obj7 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<RouteBuilder> list5 = default;
		list5._002Ector();
		object obj8 = this + 108;
		obj8 = list5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<RouteChunk> list6 = default;
		list6._002Ector();
		object obj9 = this + 116;
		obj9 = list6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<RouteChunk> list7 = default;
		list7._002Ector();
		object obj10 = this + 148;
		obj10 = list7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<RouteChunk> list8 = default;
		list8._002Ector();
		object obj11 = this + 152;
		obj11 = list8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj12 = this + 156;
		object obj13 = default;
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<RouteSection> list9 = default;
		list9._002Ector();
		object obj14 = this + 184;
		obj14 = list9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj15 = this + 188;
		object obj16 = default;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RouteBuilderWorker routeBuilderWorker = default;
		routeBuilderWorker.SwitchActiveWorkQueue();
		object obj17 = this + 192;
		obj17 = routeBuilderWorker;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<> hashSet = default;
		((HashSet<T>)(object)hashSet).Clear();
		object obj18 = this + 200;
		obj18 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj19 = this + 204;
		object obj20 = default;
		obj19 = obj20;
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v89 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v98 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj22 = this + 208;
		GamePositionRoot instance = GamePositionRoot.Instance;
		obj22 = instance;
		GamePositionRoot instance2 = GamePositionRoot.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		object obj23 = this + 224;
		GamePositionRoot instance3 = GamePositionRoot.Instance;
		obj23 = instance3;
	}

	public virtual void Validate(Route route)
	{
		//IL_000a: Expected I4, but got Obj
		DistanceBuilt__BackingField = (int)route;
	}

	public void SetBuildMode(SectionSpawnMode spawnMode, ChunkBuildMode chunkBuildMode)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		ICollection<RouteBuilder> collection = default;
		object obj = collection + 16;
		obj = this;
		ConstrainingRouteBuilder constrainingRouteBuilder = default;
		constrainingRouteBuilder.AddFromListIfConstrained(collection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		SyboRandom syboRandom = default;
		syboRandom._randomGen = (IRandomGen)num2;
		_ = 0;
		object obj2 = syboRandom + 16;
		obj2 = this;
		constrainingRouteBuilder.RandomGenerator = syboRandom;
		int spawnedLeadingEdgeWorldPositionZ = constrainingRouteBuilder.SpawnedLeadingEdgeWorldPositionZ;
		((PickupSpawnPoint)this).SetSpawnPointForced((PickupType)spawnedLeadingEdgeWorldPositionZ, (SpawnPointDifficulty)0, true, true, false);
	}

	public void StopBuilding()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_04d3: Expected Obj, but got I4
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_04f0: Expected Obj, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_053a: Expected Obj, but got I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		//IL_0389: Expected Obj, but got I4
		//IL_0412: Expected Obj, but got I
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected Obj, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I4
		//IL_01de: Expected Obj, but got I
		//IL_0273: Expected Obj, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [458BD7]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = 0;
		object obj7 = default;
		object obj8 = default;
		object obj18 = default;
		object obj20 = default;
		object obj21 = default;
		object obj22 = default;
		object obj23 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj8 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
				object obj9 = obj5 + 4;
				object obj10 = obj9 + 1;
				obj9 = obj10;
				object obj11 = obj10 << 2;
				object obj12 = obj5 + obj11;
				obj12 = 79;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
					object obj13 = (nint)0 << 2;
					object obj14 = obj5 + obj13;
					if ((nint)obj14 == 79)
					{
						object obj15 = obj5 + 4;
						if ((nint)obj15 > -1)
						{
							object obj16 = obj15 + -1;
							obj15 = obj16;
						}
						continue;
					}
				}
				if (obj6 == null)
				{
					obj6 = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj17 = obj18;
				object obj19 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj19 == obj21)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					obj22 = obj23;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				break;
			}
			object obj24 = obj5 + 4;
			object obj25 = obj24 + 1;
			obj24 = obj25;
			object obj26 = obj25 << 2;
			object obj27 = obj5 + obj26;
			obj27 = 104;
			obj22 = obj6;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj28 = (nint)0 << 2;
			object obj29 = obj5 + obj28;
			if ((nint)obj29 == 104)
			{
				object obj30 = obj5 + 4;
				if ((nint)obj30 > -1)
				{
					object obj31 = obj30 + -1;
					obj30 = obj31;
				}
				return;
			}
		}
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void EnqueueStartSection(RouteType fromRouteType, int positionZ)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_001d: Expected Obj, but got I4
		_secionSpawnMode = (SectionSpawnMode)fromRouteType;
		object obj = this - -64;
		obj = positionZ;
	}

	internal unsafe void EnqueueBuildDirective(int gamePositionZ, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, bool isApplicablePositionStict = true, RouteSection section = null)
	{
		//IL_029d: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0313: Expected Obj, but got I
		//IL_00d1: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_038a: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I
		//IL_0223: Expected Obj, but got I
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		((SectionSpawnMode*)(int)sectionSpawnMode)->value__ = 0;
		object obj3 = default;
		object obj7 = default;
		while (true)
		{
			int midSectionsCountTarget = _midSectionsCountTarget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v5 (System.Int32)+64]");
			object obj = 0;
			object obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v6+C]");
			if ((nint)obj2 < 0)
			{
				int midSectionsCountTarget2 = _midSectionsCountTarget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v54 (System.Int32)+64]");
				object obj4 = (nint)0 + (nint)16;
				object obj5 = obj3 << 2;
				object obj6 = obj4 + obj5;
				if ((nint)obj6 != gamePositionZ)
				{
					obj3 = obj7 + 1;
					continue;
				}
				((SectionSpawnMode*)(int)sectionSpawnMode)->value__ = 1;
				((ChunkBuildMode*)(int)chunkBuildMode)->value__ = 0;
				break;
			}
			break;
		}
		if (((SectionSpawnMode*)(int)sectionSpawnMode)->value__ != 0)
		{
			return;
		}
		object obj8 = 0;
		while (true)
		{
			int midSectionsCountTarget3 = _midSectionsCountTarget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v12 (System.Int32)+68]");
			object obj9 = 0;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v13+C]");
			if ((nint)obj10 < 0)
			{
				int midSectionsCountTarget4 = _midSectionsCountTarget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v43 (System.Int32)+68]");
				object obj11 = (nint)0 + (nint)16;
				object obj12 = obj8 << 2;
				object obj13 = obj11 + obj12;
				if ((nint)obj13 != gamePositionZ)
				{
					object obj14 = obj8 + 1;
					obj8 = obj14;
					continue;
				}
				((SectionSpawnMode*)(int)sectionSpawnMode)->value__ = 1;
				((ChunkBuildMode*)(int)chunkBuildMode)->value__ = 1;
				break;
			}
			break;
		}
		if (((SectionSpawnMode*)(int)sectionSpawnMode)->value__ != 0)
		{
			return;
		}
		object obj15 = 0;
		while (true)
		{
			int midSectionsCountTarget5 = _midSectionsCountTarget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v18 (System.Int32)+6C]");
			object obj16 = 0;
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v19+C]");
			if ((nint)obj17 < 0)
			{
				int midSectionsCountTarget6 = _midSectionsCountTarget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v27 (System.Int32)+6C]");
				object obj18 = (nint)0 + (nint)16;
				object obj19 = obj15 << 2;
				object obj20 = obj18 + obj19;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v31+8]");
				if ((nint)0 != gamePositionZ)
				{
					object obj22 = obj15 + 1;
					obj15 = obj22;
					continue;
				}
				((SectionSpawnMode*)(int)sectionSpawnMode)->value__ = 1;
				((bool*)(isApplicablePositionStict ? 1 : 0))->m_value = true;
				int midSectionsCountTarget7 = _midSectionsCountTarget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v28 (System.Int32)+6C]");
				object obj23 = (nint)0 + (nint)16;
				object obj24 = obj15 << 2;
				object obj25 = obj23 + obj24;
				object obj26 = obj25 + 12;
				object obj27 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v33+8]");
				_ = 0;
				RouteSection routeSection = (RouteSection)obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)section).m_CachedPtr = (IntPtr)0;
				break;
			}
			break;
		}
	}

	private float GetSectionMinEndGamePosition(RouteSection section)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		object obj = section - 1;
		if ((nint)section != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj == 2)
				{
					return 90f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			float result = default;
			return result;
		}
		return -90f;
	}

	public float GetLastSectionStartGamePosition()
	{
		//IL_0007: Expected F4, but got Obj
		return (float)this.m_OnCompletedLayingSections;
	}

	public float GetLastSectionMinEndGamePosition()
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_005f: Expected VT, but got Obj
		//IL_005f: Expected Obj, but got I4
		//IL_0070: Expected F4, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v16 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		List<RouteBuilder> buildersAbove = BuildersAbove;
		GameObject gameObject = ((Component)(object)buildersAbove).gameObject;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		return 0f;
	}

	public virtual void ConnectBuilder(RouteBuilder builderToConnect)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected Obj, but got Unknown
		//IL_06a2: Expected Obj, but got I4
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_06bf: Expected Obj, but got I4
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected Obj, but got Unknown
		//IL_06f7: Expected Obj, but got I
		//IL_0707: Expected Obj, but got I
		//IL_0717: Expected Obj, but got I
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected Obj, but got Unknown
		//IL_0746: Expected Obj, but got I4
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected Obj, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected Obj, but got Unknown
		//IL_0793: Expected Obj, but got I4
		//IL_079c: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_04fa: Expected Obj, but got I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_0584: Expected Obj, but got I
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected Obj, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_081c: Expected Obj, but got I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_034f: Expected Obj, but got I
		//IL_03e4: Expected Obj, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v14 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v15+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v16+C]");
		object obj8 = 0;
		object obj9 = obj8 & 0x3FFF;
		object obj10 = obj9 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S2_v4 (should have been resolved before IL gen)");
		object obj11 = 0;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj12 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v230+C]");
			object obj13 = 0 + obj11;
			obj11 = obj13;
		}
		object obj14 = obj5 + 4;
		object obj15 = obj14 + 1;
		obj14 = obj15;
		object obj16 = obj15 << 2;
		object obj17 = obj5 + obj16;
		obj17 = 52;
		object obj18 = 0;
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj5 + obj20;
			if ((nint)obj21 == 52)
			{
				object obj22 = obj5 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0849;
			}
		}
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0849;
		IL_0849:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj24 = default;
		object obj25 = default;
		object obj36 = default;
		object obj38 = default;
		object obj39 = default;
		object obj40 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj24 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj25 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S0_v190+C]");
					object obj26 = 0 + obj11;
					obj11 = obj26;
				}
				object obj27 = obj5 + 4;
				object obj28 = obj27 + 1;
				obj27 = obj28;
				object obj29 = obj28 << 2;
				object obj30 = obj5 + obj29;
				obj30 = 131;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
					object obj31 = (nint)0 << 2;
					object obj32 = obj5 + obj31;
					if ((nint)obj32 == 131)
					{
						object obj33 = obj5 + 4;
						if ((nint)obj33 > -1)
						{
							object obj34 = obj33 + -1;
							obj33 = obj34;
						}
						continue;
					}
				}
				if (obj18 == null)
				{
					obj18 = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj35 = obj36;
				object obj37 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj35 != obj39)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				obj18 = obj40;
			}
			else
			{
				object obj41 = obj5 + 4;
				object obj42 = obj41 + 1;
				obj41 = obj42;
				object obj43 = obj42 << 2;
				object obj44 = obj5 + obj43;
				obj44 = 156;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj45 = (nint)0 << 2;
				object obj46 = obj5 + obj45;
				if ((nint)obj46 == 156)
				{
					object obj47 = obj5 + 4;
					if ((nint)obj47 > -1)
					{
						object obj48 = obj47 + -1;
						obj47 = obj48;
					}
					goto IL_0872;
				}
			}
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0872;
			IL_0872:
			if ((nint)obj11 < 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				UnityEngine.Object obj49 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)builderToConnect);
				throw new ArrayTypeMismatchException();
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	public virtual void DisconnectBuilder(RouteBuilder builderToDisconnect)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		if (_routeHeight < builderToDisconnect._routeHeight)
		{
			_buildersAbove.Add(builderToDisconnect);
			builderToDisconnect._buildersBelow.Add(this);
		}
		else if (builderToDisconnect._routeHeight < _routeHeight)
		{
			_buildersBelow.Add(builderToDisconnect);
			builderToDisconnect._buildersAbove.Add(this);
		}
		else
		{
			if (_builderForward != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			object obj = this + 104;
			obj = builderToDisconnect;
		}
		CalculateBounds();
		builderToDisconnect.CalculateBounds();
	}

	private void DisconnectAllBuilders()
	{
		_sectionLayingProgress = RouteBuildProgress.Done;
		throw new IndexOutOfRangeException();
	}

	public IConstrainingRouteBuilder GetConstrainingBuilderAt(float gamePositionZ)
	{
		//IL_041c: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I
		//IL_043c: Expected Obj, but got I
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0481: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_04b0: Expected Obj, but got I4
		//IL_04e1: Invalid comparison between I and F4
		//IL_0054: Expected I, but got Obj
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00a9: Invalid comparison between Obj and F4
		//IL_01a0: Expected Obj, but got I
		//IL_01e1: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_0319: Invalid comparison between I and F4
		//IL_05ac: Expected Obj, but got I
		//IL_026e: Expected VT, but got Obj
		//IL_026e: Expected Obj, but got I4
		//IL_0282: Invalid comparison between I and F4
		//IL_0222: Expected I, but got Obj
		//IL_034f: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I
		//IL_036c: Expected Obj, but got I
		//IL_0370: Expected VT, but got Obj
		//IL_037e: Invalid comparison between VT and I4
		bool flag = this == null;
		List<RouteBuilder> buildersBelow = _buildersBelow;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v4+8]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag2 = obj6 != null;
		object obj7 = flag & flag2;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(GameStateMachine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v16 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num3 = (nint)typeof(GameStateMachine);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v103 (Il2CppClass<SYBO.Subway.StateSystem.GameStateMachine>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool useBenchmarkRoute = RouteManager.UseBenchmarkRoute;
			FlyingState flyingState = ((StateMachine)useBenchmarkRoute).TryGetCurrentState<FlyingState>();
			if (flyingState != null)
			{
				object obj9 = flyingState - -64;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)gamePositionZ))
				{
					return null;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [78]");
			if (0f > gamePositionZ)
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj10 = default;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v88+90]");
				bool flag3;
				if ((nint)0 != 0)
				{
					flag3 = true;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v88+84]");
					flag3 = (nint)0 == 3;
				}
				if (!flag3)
				{
					return null;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			RouteBuilder routeBuilder = default;
			if (routeBuilder != null)
			{
				EnvironmentKind desiredEnvironmentKind = routeBuilder.DesiredEnvironmentKind;
				if ((object)desiredEnvironmentKind != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7C]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v43+C]");
					if ((nint)0 >= (nint)1)
					{
						nint num4 = (nint)typeof(GamePositionRoot);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v74 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num5 = (nint)typeof(GamePositionRoot);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v83 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool isRestricted = AgeRestriction.isRestricted;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7C]");
						PickupSpawnPoint pickupSpawnPoint = ((List<PickupSpawnPoint>)0).get_Item(0);
						GameObject gameObject = pickupSpawnPoint.gameObject;
						Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						if (0f < gamePositionZ)
						{
							return null;
						}
					}
					EnvironmentKind environmentKindAt = routeBuilder.GetEnvironmentKindAt(gamePositionZ);
					if ((object)environmentKindAt != null)
					{
						return null;
					}
					float num6 = ((CoinCurve)null).JumpLength(gamePositionZ);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [68]");
					float num7 = 0f + num6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [74]");
					if ((nint)0 != 0)
					{
						return null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70]");
					if (0f < num7)
					{
						((RouteManager)null).MainRoute = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [40]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [64]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S1_v33+CC]");
						_00211 val = (_00211)((WeightRandomizedOrderedContainter<, >)num8).PickRandomPrefab((SyboRandom)0);
						if (val != (_00211)(object)0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							((ConstrainingRouteBuilder)null).UpdateBuilder(gamePositionZ);
							_ = 1;
							IConstrainingRouteBuilder result = default;
							return result;
						}
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public virtual void UpdateBuilder(float characterGamePositionZ)
	{
		//IL_005f: Expected I, but got Obj
		//IL_0075: Expected Obj, but got I
		//IL_00a0: Expected I, but got Obj
		int constraintStartZ = ((ConstrainingRouteBuilder)this).ConstraintStartZ;
		DespawnPassedChunks(characterGamePositionZ);
		if (constraintStartZ != 0 || ((ConstrainingRouteBuilder)this).ConstraintStartZ == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+E8]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num = (nint)typeof(EventArgs);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v7 (Il2CppClass<System.EventArgs>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v12 (Il2CppClass<System.EventArgs>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
	}

	private bool IsConstraintBlockingSpawningAt(int spawnedLeadingEdgeGamePositionZ)
	{
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_033d: Expected Obj, but got I4
		//IL_034f: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01c8: Expected Obj, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0269: Expected Obj, but got I
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		object obj3 = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj5 = default;
		object obj4 = obj5 + 8;
		obj4 = spawnedLeadingEdgeGamePositionZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
		if (CanSpawnChunk((RouteChunk)0))
		{
			int spawnedLeadingEdgeWorldPositionZ = SpawnedLeadingEdgeWorldPositionZ;
			IConstrainingRouteBuilder builderConstrainingStartAt = GetBuilderConstrainingStartAt(spawnedLeadingEdgeWorldPositionZ);
			if (builderConstrainingStartAt != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				RouteSection startSectionPrefab = GetStartSectionPrefab((RouteType)spawnedLeadingEdgeWorldPositionZ);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
				object obj6 = -(-64);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v17+44]");
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					UnityEngine.Object obj8 = UnityEngine.Object.Instantiate((UnityEngine.Object)_route);
					throw new ArrayTypeMismatchException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj10 = default;
				object obj9 = obj10 - spawnedLeadingEdgeWorldPositionZ;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
				object obj11 = -(-64);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj12 = default;
				obj3 = obj12;
				obj = obj3;
				object obj14 = default;
				object obj13 = obj14 + 8;
				obj13 = obj;
				object source = obj14 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				Func<_0021_00210, bool> func = default;
				object obj15 = func + 16;
				obj15 = obj5;
				bool flag = Enumerable.All<TSource>((IEnumerable<TSource>)source, (Func<TSource, bool>)(object)func);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14+8]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num2 = 0;
				_ = 0;
				Func<_0021_00210, bool> func2 = default;
				object obj17 = func2 + 16;
				obj17 = obj14;
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
				object obj18 = flag2 & flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v35+3C]");
				int num3 = Enumerable.Count<TSource>((IEnumerable<TSource>)0, (Func<TSource, bool>)(object)func2);
				return (byte)(obj18 & num3) != 0;
			}
			return true;
		}
		return false;
	}

	private bool ProcessBuildDirectives(int spawnedLeadingEdgeGamePositionZ)
	{
		int num = 0;
		RouteBuilder routeBuilder = default;
		while (true)
		{
			List<IConstrainingRouteBuilder> constrainingBuilders = _constrainingBuilders;
			if (num >= constrainingBuilders._size)
			{
				return false;
			}
			IConstrainingRouteBuilder constrainingRouteBuilder = _constrainingBuilders.get_Item(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			if (!routeBuilder.IsDoneLayingSections)
			{
				ICollection<RouteBuilder> constrainedBuilders = ((ConstrainingRouteBuilder)routeBuilder).ConstrainedBuilders;
				if ((nint)constrainedBuilders == spawnedLeadingEdgeGamePositionZ)
				{
					return true;
				}
			}
			if (!routeBuilder.IsDoneLayingSections && ((ConstrainingRouteBuilder)routeBuilder).ConstraintStartZ == 0)
			{
				break;
			}
			int num2 = num + 1;
			num = num2;
		}
		return true;
	}

	private void BuildChunks(float buildUntilGamePositionZ, ChunkBuildMode previouslySpawnedBuildMode = ChunkBuildMode.Normal, ChunkBuildMode thisUpdateSpawnedBuildMode = ChunkBuildMode.Normal)
	{
		//IL_000a: Expected I4, but got F4
		//IL_0014: Expected I4, but got F4
		//IL_0022: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0065: Expected Obj, but got I4
		_midSectionsCountLimited = (byte)(int)buildUntilGamePositionZ != 0;
		_midSectionsCountTarget = (int)buildUntilGamePositionZ;
		EventHandler onCompletedLayingSections = (EventHandler)(previouslySpawnedBuildMode & ChunkBuildMode.Normal);
		this.m_OnCompletedLayingSections = onCompletedLayingSections;
		object obj = previouslySpawnedBuildMode & ChunkBuildMode.Normal;
		object obj2 = this + 12;
		obj2 = thisUpdateSpawnedBuildMode;
		object obj3 = this + 16;
		obj3 = thisUpdateSpawnedBuildMode;
	}

	private void BuildChunk(RouteChunk chunk, ChunkBuildMode buildMode)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		bool willIgnoreJetpackZ = default;
		((PickupSpawnPoint)this).SetSpawnPointForced((PickupType)buildMode, SpawnPointDifficulty.Easy, true, true, willIgnoreJetpackZ);
	}

	private unsafe IEnumerator PerformSelectionAndActivationASync(RouteChunk chunk, ChunkBuildMode buildMode)
	{
		//IL_00b6: Expected I4, but got Obj
		//IL_00c2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00f5: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		if (OnboardingSave.numberOfRunsSinceLastGuideline == 0)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+E8]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+E8]");
				return (IEnumerator)0;
			}
		}
		bool flag = ((RouteBuilder)null).AddTransitionSectionTo((RouteType)chunk, out *(RouteSection*)(int)buildMode);
		return (IEnumerator)flag;
	}

	protected virtual EnvironmentKind EvalNextChunkDesiredEnvironment(RouteChunk spawnedChunk)
	{
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03cc: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0321: Expected Obj, but got I
		//IL_038e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 20;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		List<BuildDirective> buildDirectives = _buildDirectives;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F5");
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<RouteChunk, UIntPtr>(ref spawnedChunk))
			{
				return null;
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
			_ = 0;
			object obj4 = obj / 180;
			object obj5 = obj4 * 180;
			object obj6 = obj - obj5;
			if (obj6 == null)
			{
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
				_ = 0;
				if (obj == spawnedChunk)
				{
					goto IL_02a0;
				}
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
			_ = 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<RouteChunk, UIntPtr>(ref spawnedChunk))
			{
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
				if ((nint)0 == 0)
				{
					goto IL_02a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			UnityEngine.Object obj7 = UnityEngine.Object.Instantiate((UnityEngine.Object)_route);
			throw new ArrayTypeMismatchException();
		}
		return null;
		IL_02a0:
		_buildDirectives.RemoveAt(0);
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
		_ = 0;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
		_secionSpawnMode = SectionSpawnMode.None;
		object obj8 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F8");
		object obj9 = default;
		if (obj9 != null)
		{
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			int progressStateSectionCount = GetProgressStateSectionCount(RouteBuildProgress.Start);
			return (EnvironmentKind)1;
		}
		return null;
	}

	public virtual bool WillChangeEnvironment(int addedDistance)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	private bool IsPositionWithinConnectedBuilder(Vector3 position)
	{
		return false;
	}

	public void RemoveChunk(RouteChunk chunk)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_009e: Expected Obj, but got I4
		if (_buildersAbove.Remove((RouteBuilder)(object)chunk))
		{
			bool flag = ((List<RouteBuilder>)(object)chunk._logicAssetManager).Remove(this);
		}
		else if (_buildersBelow.Remove((RouteBuilder)(object)chunk))
		{
			bool flag2 = ((List<RouteBuilder>)(object)chunk._blockConstraints).Remove(this);
		}
		else if ((object)_builderForward == chunk)
		{
			object obj = this + 104;
			obj = 0;
		}
		CalculateBounds();
		((RouteBuilder)(object)chunk).CalculateBounds();
	}

	public virtual void Destruct()
	{
		while (true)
		{
			List<RouteBuilder> buildersAbove = _buildersAbove;
			if (buildersAbove._size < 1)
			{
				break;
			}
			RouteBuilder routeBuilder = _buildersAbove.get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		while (true)
		{
			List<RouteBuilder> buildersBelow = _buildersBelow;
			if (buildersBelow._size < 1)
			{
				break;
			}
			RouteBuilder routeBuilder2 = _buildersBelow.get_Item(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		if (_builderForward != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	private unsafe void CollectConstrainingBuilders()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		Destruct();
		DespawnUnbuiltChunks();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(RouteBuilder.RouteChunk_OnEnvironmentSegmentSpawned);
		object obj2 = obj + 16;
		obj2 = this;
		Delegate obj3 = ((Delegate)RouteChunk.OnEnvironmentSegmentSpawned).RemoveImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action<EnvironmentKind, int, Route> onEnvironmentSegmentSpawned = default;
		RouteChunk.OnEnvironmentSegmentSpawned = onEnvironmentSegmentSpawned;
	}

	private void CollectConstrainingBuilders(ICollection<RouteBuilder> builders)
	{
		bool flag = _chunks.Remove((RouteChunk)builders);
	}

	private void CollectIfConstrainingBuilder(RouteBuilder builder)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 43;
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 43)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private void CalculateBounds()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		CollectIfConstrainingBuilder((RouteBuilder)(object)_buildersAbove);
		CollectIfConstrainingBuilder((RouteBuilder)(object)_buildersBelow);
		SpawnNextChunk((RouteSection)(object)_builderForward);
	}

	protected virtual bool CanSpawnSection(RouteSection section)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_035f: Expected Obj, but got I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got I4
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0164: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_01ec: Expected Obj, but got I
		//IL_02b3: Expected Obj, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 56;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = obj;
		_ = -1;
		object obj6 = obj2 + 72;
		List<IConstrainingRouteBuilder> constrainingBuilders = ConstrainingBuilders;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
		_ = 0;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj8 = obj9 + 72;
				obj2 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v63+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v63+10]");
				_ = 0;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
				_ = 0;
				obj6 = section;
				_ = ((UnityEngine.Object)section).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj10 != null)
				{
					object obj11 = obj5 + 4;
					object obj12 = obj11 + 1;
					obj11 = obj12;
					object obj13 = obj12 << 2;
					object obj14 = obj5 + obj13;
					obj14 = 68;
					break;
				}
				continue;
			}
			object obj15 = obj5 + 4;
			object obj16 = obj15 + 1;
			obj15 = obj16;
			object obj17 = obj16 << 2;
			object obj18 = obj5 + obj17;
			obj18 = 66;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj5 + obj19;
			if ((nint)obj20 == 68)
			{
				object obj21 = obj5 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_043b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj5 + obj23;
			if ((nint)obj24 == 66)
			{
				object obj25 = obj5 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_043b;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_043b;
		IL_043b:
		return true;
	}

	public bool CanSpawnChunk(RouteChunk chunk)
	{
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_0018: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0018: Expected Obj, but got I4
		//IL_0047: Expected I, but got Obj
		//IL_005d: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_0088: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_0184: Invalid comparison between I4 and VT
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		int spawnedLeadingEdgeWorldPositionZ = SpawnedLeadingEdgeWorldPositionZ;
		object obj = chunk - -64;
		object obj2 = obj + spawnedLeadingEdgeWorldPositionZ;
		bool isRepeatableInSections = chunk._isRepeatableInSections;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (System.Boolean)+C]");
		bool result;
		if ((nint)0 < (nint)1)
		{
			if (((PickerCollection._003C_003Ec)isRepeatableInSections)._003CUpdatePickers_003Eb__10_0((IPicker)spawnedLeadingEdgeWorldPositionZ, (IPicker)_minDistanceBetweenSectionRepeats) != 0)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)_lastSpawnedSection).FindKernel((string)null) != 0)
				{
					bool flag = ((DefaultRouteBuilder._003C_003Ec__DisplayClass14_0)isRepeatableInSections)._003CEvalNextChunkDesiredEnvironment_003Eb__1((EnvironmentKindRepeatConfig)(object)_lastSpawnedSection);
					bool flag2 = !flag;
					result = false;
					if (flag2)
					{
						goto IL_0314;
					}
				}
				object obj4 = 0;
				object obj6 = default;
				while (true)
				{
					List<BuildDirective> buildDirectives = _buildDirectives;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v20 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
					if ((nint)obj5 < 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F5");
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F5");
							result = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
							if ((nint)0 != 0)
							{
								break;
							}
							object obj7 = obj4 + 1;
							obj4 = obj7;
							continue;
						}
					}
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)spawnedLeadingEdgeWorldPositionZ) < System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref chunk.LogicHideOffset))
					{
						result = false;
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [chunk @ L1 (SYBO.Subway.Routes.RouteChunk)+14]");
					if ((nint)0 < (nint)spawnedLeadingEdgeWorldPositionZ)
					{
						result = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [chunk @ L1 (SYBO.Subway.Routes.RouteChunk)+10]");
						if ((nint)0 != 0)
						{
							break;
						}
					}
					if (chunk.OnDeactivate != null)
					{
						object obj8 = chunk.OnDeactivate + 1;
						bool flag3 = SectionCountUsed__BackingField < (nint)obj8;
						result = false;
						if (flag3)
						{
							break;
						}
					}
					result = true;
					break;
				}
			}
			else
			{
				result = false;
			}
		}
		else
		{
			result = false;
		}
		goto IL_0314;
		IL_0314:
		return result;
	}

	public unsafe void HideLogic(float fromGamePositionZ, float distance)
	{
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected VT, but got Unknown
		//IL_0194: Expected F4, but got Obj
		//IL_018f: Expected native int or pointer, but got VT
		//IL_01a9: Expected F4, but got I
		//IL_01a4: Expected native int or pointer, but got VT
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0082: Expected F4, but got Obj
		//IL_007d: Expected native int or pointer, but got VT
		//IL_0097: Expected F4, but got I
		//IL_0092: Expected native int or pointer, but got VT
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected VT, but got Unknown
		//IL_00d3: Expected F4, but got Obj
		//IL_00ce: Expected native int or pointer, but got VT
		//IL_00e8: Expected F4, but got I
		//IL_00e3: Expected native int or pointer, but got VT
		//IL_00f5: Expected F4, but got Obj
		//IL_00f0: Expected native int or pointer, but got VT
		//IL_010a: Expected F4, but got I
		//IL_0105: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 48;
		Vector3 back = Vector3.back;
		Vector3 vector = (Vector3)(obj3 + 72);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj4 = obj3 + 36;
		Vector3 vector2 = vector / distance;
		object obj5 = obj3 + 12;
		Quaternion identity = Quaternion.identity;
		object obj6 = obj3 + 24;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v21+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23+8]");
		((Vector3*)(nint)vector)->z = 0f;
		float num3 = fromGamePositionZ - 20f;
		Vector3 vector3 = vector / num3;
		Vector3 vector4 = (Vector3)(obj3 + 60);
		((Vector3*)(nint)vector4)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v19+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector5 = vector4 - vector;
	}

	protected bool IsStartPositionConstrained(int startPositionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected Obj, but got Unknown
		//IL_079f: Expected Obj, but got I4
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_0870: Expected Obj, but got I4
		//IL_00ee: Expected Obj, but got I4
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_013f: Expected Obj, but got I4
		//IL_0157: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_063c: Expected Obj, but got I
		//IL_06d8: Expected Obj, but got I
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected Obj, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected Obj, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected Obj, but got Unknown
		//IL_0266: Expected Obj, but got I4
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected Obj, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_054f: Expected Obj, but got I4
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected Obj, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got Unknown
		//IL_05c4: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = obj;
		_ = -1;
		List<IConstrainingRouteBuilder> constrainingBuilders = _constrainingBuilders;
		if (constrainingBuilders._size != 0)
		{
			int spawnedLeadingEdgeWorldPositionZ = SpawnedLeadingEdgeWorldPositionZ;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [startPositionZ @ L1 (System.Int32)+20]");
			object obj5 = (nint)0 * (nint)90;
			object obj6 = obj5 + spawnedLeadingEdgeWorldPositionZ;
			object obj7 = 0;
			object obj11 = default;
			object obj12 = default;
			bool flag3 = default;
			object obj13 = default;
			object obj14 = default;
			object obj16 = default;
			bool flag2 = default;
			object obj20 = default;
			object obj22 = default;
			object obj23 = default;
			object obj24 = default;
			bool result = default;
			object obj33 = default;
			object obj34 = default;
			object obj35 = default;
			object obj36 = default;
			object obj45 = default;
			bool result2 = default;
			while (true)
			{
				List<BuildDirective> buildDirectives = _buildDirectives;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v16 (System.Collections.Generic.List`1<SYBO.Subway.Routes.Builders.RouteBuilder+BuildDirective>)+C]");
				if ((nint)obj8 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F5");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @96F5");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						if ((nint)0 == 0)
						{
							object obj9 = obj7 + 1;
							obj7 = obj9;
							continue;
						}
						goto IL_07ed;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj10;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 32;
					bool flag = obj11 == null;
					obj10 = 33;
					if (flag)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj10 = 18;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					obj10 = 19;
					obj2 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					flag2 = flag3;
					obj10 = 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					bool flag4;
					if (obj13 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						flag4 = (nint)obj14 <= spawnedLeadingEdgeWorldPositionZ;
					}
					else
					{
						flag4 = false;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					object obj15 = flag3 & obj16;
					object obj17 = flag4 | obj15;
					flag2 = flag3;
					if (obj17 == null)
					{
						flag2 = flag3;
						obj10 = 29;
						break;
					}
				}
				object obj18 = obj10 - 17;
				bool flag5;
				object obj21;
				if ((nint)obj10 != 17)
				{
					if ((nint)obj18 != 1)
					{
						object obj19;
						if ((nint)obj18 != 2)
						{
							if ((nint)obj18 != 3)
							{
								if ((nint)obj18 != 4)
								{
									if ((nint)obj18 != 5 && (nint)obj18 != 6 && (nint)obj18 != 7)
									{
										if ((nint)obj18 == 8)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											flag5 = flag2;
											obj19 = obj20;
											obj21 = obj22;
											goto IL_087a;
										}
										if ((nint)obj18 != 9 && (nint)obj18 != 10)
										{
											if ((nint)obj18 == 11)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												flag5 = flag2;
												obj19 = obj23;
												obj21 = obj22;
												goto IL_087a;
											}
											if ((nint)obj18 != 12)
											{
												if ((nint)obj18 != 13 && (nint)obj18 != 14)
												{
													if ((nint)obj18 == 15)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														flag5 = true;
														obj19 = obj24;
														obj21 = obj22;
														goto IL_087a;
													}
													if ((nint)obj18 == 16)
													{
														object obj25 = obj4 + 4;
														object obj26 = obj25 + 1;
														obj25 = obj26;
														object obj27 = obj26 << 2;
														object obj28 = obj4 + obj27;
														obj28 = 238;
														result = true;
													}
												}
											}
											else
											{
												object obj29 = obj4 + 4;
												object obj30 = obj29 + 1;
												obj29 = obj30;
												object obj31 = obj30 << 2;
												object obj32 = obj4 + obj31;
												obj32 = 240;
											}
										}
									}
									goto IL_08ab;
								}
								flag5 = flag2;
							}
							else
							{
								flag5 = true;
							}
						}
						else
						{
							flag5 = true;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj19 = obj33;
						obj21 = obj22;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						flag5 = true;
						object obj19 = obj34;
						obj21 = obj22;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					flag5 = true;
					object obj19 = obj35;
					obj21 = obj22;
				}
				goto IL_087a;
				IL_087a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj21 == obj36)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					result = flag5;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				goto IL_08ab;
				IL_08ab:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj37 = (nint)0 << 2;
					object obj38 = obj4 + obj37;
					if ((nint)obj38 == 240)
					{
						object obj39 = obj4 + 4;
						if ((nint)obj39 > -1)
						{
							object obj40 = obj39 + -1;
							obj39 = obj40;
						}
						goto IL_07ed;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
					object obj41 = (nint)0 << 2;
					object obj42 = obj4 + obj41;
					if ((nint)obj42 == 238)
					{
						object obj43 = obj4 + 4;
						if ((nint)obj43 > -1)
						{
							object obj44 = obj43 + -1;
							obj43 = obj44;
						}
						break;
					}
				}
				if (obj45 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					goto IL_07ed;
				}
				return result;
				IL_07ed:
				return result2;
			}
			return result;
		}
		return true;
	}

	protected IConstrainingRouteBuilder GetBuilderConstrainingStartAt(int startPositionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_02fb: Expected Obj, but got I4
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_0100: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I
		//IL_03a2: Expected Obj, but got I4
		//IL_024f: Expected Obj, but got I
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				if (obj6 != null)
				{
					object obj7 = obj4 + 4;
					object obj8 = obj7 + 1;
					obj7 = obj8;
					object obj9 = obj8 << 2;
					object obj10 = obj4 + obj9;
					obj10 = 60;
					break;
				}
				continue;
			}
			object obj11 = obj4 + 4;
			object obj12 = obj11 + 1;
			obj11 = obj12;
			object obj13 = obj12 << 2;
			object obj14 = obj4 + obj13;
			obj14 = 58;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 60)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_039c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 58)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_039c;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_039c;
		IL_039c:
		return (IConstrainingRouteBuilder)1;
	}

	protected void SpawnNextChunk(RouteSection section)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj2 = default;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			}
		}
	}

	protected virtual RouteSection GetSectionPrefab(RouteBuildProgress progressState, RouteType transitionRouteType = RouteType.None)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		RouteSection routeSection = default;
		((UnityEngine.Object)routeSection).m_CachedPtr = (IntPtr)0;
		object obj = routeSection + 16;
		obj = this;
		object obj2 = routeSection + 20;
		obj2 = progressState;
		return routeSection;
	}

	protected virtual RouteSection GetTransitionSectionPrefab(List<TransitionSectionInfo> transitionSections, RouteType transitionRouteType)
	{
		//IL_0088: Expected Obj, but got I4
		if (transitionSections != null)
		{
			if ((nint)transitionSections != 1)
			{
				if ((nint)transitionSections == 2)
				{
					return AddSection((RouteSection)transitionRouteType);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			return GetNextSectionPrefab();
		}
		return GetEndSectionPrefab(transitionRouteType);
	}

	protected RouteSection GetStartSectionPrefab(RouteType previousRouteType)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = default;
		obj = obj3;
		return (RouteSection)(object)new NullReferenceException();
	}

	protected RouteSection GetEndSectionPrefab(RouteType nextRouteType)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		RouteSection result = default;
		return result;
	}

	protected RouteSection GetMidSectionPrefab()
	{
		//IL_0007: Expected Obj, but got I4
		return (RouteSection)DistanceBuilt__BackingField;
	}

	protected virtual RouteSection GetNextSectionPrefab()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_027e: Expected VT, but got Obj
		//IL_028c: Expected I, but got Obj
		//IL_02a2: Expected Obj, but got I
		//IL_02c9: Expected Obj, but got VT
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0301: Expected Obj, but got VT
		//IL_0317: Expected Obj, but got I
		//IL_0327: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected Obj, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006a: Expected VT, but got Obj
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_03aa: Expected Obj, but got I4
		//IL_03f5: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I
		//IL_042b: Expected Obj, but got VT
		//IL_01b1: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		_00211 val = (_00211)((WeightRandomizedPrefabContainter<, >)(object)_midSectionPrefabs).PickRandomPrefab(RandomGenerator__BackingField);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v103 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (UnityEngine.Object)val != null;
		bool flag2 = !flag;
		_00211 val2 = val;
		if (!flag2)
		{
			val2 = (_00211)_fallbackSection;
		}
		object obj4 = this + 128;
		obj4 = val2;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v13 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v14+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v15+C]");
		object obj7 = 0;
		object obj8 = obj7 & 0x3FFF;
		object obj9 = obj8 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v77 @ S2_v7 (should have been resolved before IL gen)");
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v93+C]");
			if ((nint)0 > (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v93+C]");
				object obj11 = -1;
			}
		}
		object obj12 = obj2 + 4;
		object obj13 = obj12 + 1;
		obj12 = obj13;
		object obj14 = obj13 << 2;
		object obj15 = obj2 + obj14;
		obj15 = 96;
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj2 + obj17;
			if ((nint)obj18 == 96)
			{
				object obj19 = obj2 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_03e5;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03e5;
		IL_03e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ L1_v3 (T)+1C]");
		object obj22 = 0;
		int spawnedLeadingEdgeWorldPositionZ = SpawnedLeadingEdgeWorldPositionZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v43+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ L1_v3 (T)+44]");
		object obj23 = (nint)0 + (nint)spawnedLeadingEdgeWorldPositionZ;
		return (RouteSection)val2;
	}

	protected unsafe virtual void AddNextSection()
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got F4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got F4
		//IL_01e5: Expected I, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected VT, but got Unknown
		//IL_0269: Expected F4, but got Obj
		//IL_0264: Expected native int or pointer, but got VT
		//IL_027e: Expected F4, but got I
		//IL_0279: Expected native int or pointer, but got VT
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected VT, but got Unknown
		//IL_02b9: Expected F4, but got Obj
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02ce: Expected F4, but got I
		//IL_02c9: Expected native int or pointer, but got VT
		//IL_02db: Expected F4, but got Obj
		//IL_02d6: Expected native int or pointer, but got VT
		//IL_02f0: Expected F4, but got I
		//IL_02eb: Expected native int or pointer, but got VT
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got I4
		//IL_0331: Expected F4, but got Obj
		//IL_032c: Expected native int or pointer, but got VT
		//IL_0346: Expected F4, but got I
		//IL_0341: Expected native int or pointer, but got VT
		//IL_0353: Expected F4, but got Obj
		//IL_034e: Expected native int or pointer, but got VT
		//IL_0368: Expected F4, but got I
		//IL_0363: Expected native int or pointer, but got VT
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_00f0: Expected native int or pointer, but got VT
		//IL_0102: Expected native int or pointer, but got VT
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 72;
		obj = 0;
		_ = 0;
		obj = 60f;
		_ = 90f;
		_ = 0f;
		object obj3 = obj2 + 60;
		object obj4 = this + 168;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v11+8]");
		_ = 0;
		object obj5 = obj2 + 48;
		obj5 = 0;
		_ = 0;
		obj5 = 0f;
		_ = 90f;
		_ = 0f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v24 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v70 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 112);
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj7 = obj2 + 36;
		Vector3 vector3 = vector / 0.5f;
		Vector3 vector4 = (Vector3)(obj2 + 88);
		((Vector3*)(nint)vector4)->x = (float)obj3;
		Vector3 vector5 = vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v32+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		object obj8 = obj2 + 24;
		Vector3 vector7 = vector4 - vector;
		obj2 = 0;
		_ = 0;
		_ = 0;
		((Vector3*)(nint)vector4)->x = (float)obj8;
		Vector3 vector8 = vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v39+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector9 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F496");
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector10 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj9 = this + 72;
		obj9 = vector.x;
		_ = vector.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v29 (UnityEngine.Vector3)+10]");
		_ = 0;
		int num3 = 0;
		while (true)
		{
			List<RouteChunk> chunks = _chunks;
			if (num3 < chunks._size)
			{
				RouteChunk routeChunk = _chunks.get_Item(num3);
				Vector3 gamePositionStart = routeChunk.GamePositionStart;
				((Vector3*)(nint)vector)->x = vector4.x;
				((Vector3*)(nint)vector)->z = vector4.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v34 (UnityEngine.Vector3)+10]");
				_ = 0;
				object obj10 = this + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B8");
				int num4 = num3 + 1;
				num3 = num4;
				continue;
			}
			break;
		}
	}

	protected RouteSection AddSection(RouteSection sectionPrefab)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		RouteSection result = default;
		return result;
	}

	public unsafe bool AddTransitionSectionTo(RouteType routeType, out RouteSection routeSection)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected Obj, but got Unknown
		//IL_02f6: Expected Obj, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_0183: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00ae: Expected Obj, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v87+8]");
				if (null == System.Runtime.CompilerServices.Unsafe.AsPointer(ref routeSection))
				{
					object obj6 = obj4 + 4;
					object obj7 = obj6 + 1;
					obj6 = obj7;
					object obj8 = obj7 << 2;
					object obj9 = obj4 + obj8;
					obj9 = 62;
					break;
				}
				continue;
			}
			object obj10 = obj4 + 4;
			object obj11 = obj10 + 1;
			obj10 = obj11;
			object obj12 = obj11 << 2;
			object obj13 = obj4 + obj12;
			obj13 = 60;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj4 + obj14;
			if ((nint)obj15 == 62)
			{
				object obj16 = obj4 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_0397;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj4 + obj18;
			if ((nint)obj19 == 60)
			{
				object obj20 = obj4 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_0397;
			}
		}
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0397;
		IL_0397:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v87+C]");
		return false;
	}

	private void IncrementSectionProgressState()
	{
		if (_sectionLayingProgress == RouteBuildProgress.Mid)
		{
			int midSectionCountUsed = _midSectionCountUsed + 1;
			_midSectionCountUsed = midSectionCountUsed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		RouteBuildProgress progressState = default;
		int progressStateSectionCount = GetProgressStateSectionCount(progressState);
	}

	private unsafe int GetProgressStateSectionCount(RouteBuildProgress progressState)
	{
		//IL_0279: Expected Obj, but got I4
		//IL_028b: Expected I, but got Obj
		//IL_02a1: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected VT, but got Unknown
		//IL_031d: Expected F4, but got Obj
		//IL_0318: Expected native int or pointer, but got VT
		//IL_0332: Expected F4, but got I
		//IL_032d: Expected native int or pointer, but got VT
		//IL_033f: Expected F4, but got I4
		//IL_0350: Expected F4, but got Obj
		//IL_034b: Expected native int or pointer, but got VT
		//IL_0365: Expected F4, but got I
		//IL_0360: Expected native int or pointer, but got VT
		//IL_036e: Expected Obj, but got VT
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_038d: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got VT
		//IL_015a: Expected I, but got Obj
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c5: Expected Obj, but got VT
		//IL_0256: Expected I4, but got VT
		//IL_0207: Expected F4, but got I4
		//IL_0207: Expected Obj, but got I4
		//IL_024c: Expected F4, but got I4
		//IL_024c: Expected Obj, but got I4
		int num = SectionCountUsed__BackingField + 1;
		SectionCountUsed__BackingField = num;
		GameObject gameObject = ((Component)progressState).gameObject;
		nint num2 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v8 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v47 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool((Transform)(object)gameObject);
		string tag = ((Component)(object)prefabPool).tag;
		((GameObject)(object)tag).tag = (string)1;
		GameObject gameObject2 = _route.gameObject;
		((Transform)(object)prefabPool).parentInternal = (Transform)(object)gameObject2;
		int builtLeadingEdgeGamePositionZ = BuiltLeadingEdgeGamePositionZ;
		nint num4 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v17 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v63 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 12;
		Vector3 back = Vector3.back;
		Vector3 vector = (Vector3)(obj4 + 24);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v22+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = Quaternion.AngleAxis(builtLeadingEdgeGamePositionZ, vector);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 localPosition = ((Transform)vector).localPosition;
		nint num6 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v31 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v59 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		((GamePositionRoot)isRestricted).RemoveOffsetTransform((Transform)(object)prefabPool);
		_0021_00210 componentInChildren = (_0021_00210)((Component)(object)prefabPool).GetComponentInChildren<T>();
		((RouteSection)componentInChildren).AddSpawnedChunk((RouteChunk)(object)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		object obj6 = this + 180;
		obj6 = componentInChildren;
		if (OnAddedSection != null)
		{
			int spawnedLeadingEdgeWorldPositionZ = SpawnedLeadingEdgeWorldPositionZ;
			OnAddedSection(_route, (RouteSection)progressState, spawnedLeadingEdgeWorldPositionZ);
		}
		if (OnGlobalAddedSection != null)
		{
			int spawnedLeadingEdgeWorldPositionZ2 = SpawnedLeadingEdgeWorldPositionZ;
			OnGlobalAddedSection(_route, (RouteSection)progressState, spawnedLeadingEdgeWorldPositionZ2);
		}
		return (int)componentInChildren;
	}

	protected RouteChunk SpawnRouteChunk(RouteChunk chunkPrefab)
	{
		//IL_0063: Expected Obj, but got I4
		//IL_0088: Expected Obj, but got I
		//IL_0098: Expected Obj, but got I
		//IL_00a8: Expected Obj, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00f2: Expected Obj, but got I4
		if ((object)chunkPrefab != null)
		{
			if ((nint)chunkPrefab != 1)
			{
				if ((nint)chunkPrefab == 2)
				{
					List<TransitionSectionInfo> endSectionPrefabs = _endSectionPrefabs;
					return (RouteChunk)endSectionPrefabs._size;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			WeightRandomizedRouteSectionContainter midSectionPrefabs = _midSectionPrefabs;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v7+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v8+8]");
			object obj3 = 0;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S2_v5 (should have been resolved before IL gen)");
			RouteChunk result = default;
			return result;
		}
		List<TransitionSectionInfo> startSectionPrefabs = _startSectionPrefabs;
		return (RouteChunk)startSectionPrefabs._size;
	}

	private void SetChunkCrossReferences(RouteChunk previous, RouteChunk next)
	{
		//IL_0032: Expected I4, but got Obj
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I4, but got Unknown
		//IL_00e8: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		RouteChunk routeChunk = default;
		EnvironmentBaseKind startEnvironmentBase = routeChunk.GetStartEnvironmentBase((int)PreviousDesiredEnvironmentKind__BackingField);
		object obj = this + 196;
		obj = previous;
		object obj2 = this + 224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj3 = default;
		obj2 = obj3;
		object obj4 = previous._blockCount * 90;
		int num = obj4 + DistanceBuilt__BackingField;
		DistanceBuilt__BackingField = num;
		int chunksBuiltCount = _chunksBuiltCount + 1;
		_chunksBuiltCount = chunksBuiltCount;
		if ((nint)next == 1)
		{
			RouteSection sectionPrefab = GetSectionPrefab((RouteBuildProgress)previous);
			_worker.EnqueueDespawnWork(previous, (IEnumerator)sectionPrefab);
		}
	}

	public unsafe RouteChunk GetChunkContainingPoint(Vector3 gamePosition)
	{
		//IL_046a: Expected Obj, but got VT
		//IL_047c: Expected I, but got Obj
		//IL_0492: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_0521: Expected I, but got Obj
		//IL_0537: Expected Obj, but got I
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected Obj, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected VT, but got Unknown
		//IL_0586: Expected F4, but got Obj
		//IL_0581: Expected native int or pointer, but got VT
		//IL_059b: Expected F4, but got I
		//IL_0596: Expected native int or pointer, but got VT
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_05b8: Expected F4, but got I4
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected VT, but got Unknown
		//IL_05d7: Expected F4, but got Obj
		//IL_05d2: Expected native int or pointer, but got VT
		//IL_05ec: Expected F4, but got I
		//IL_05e7: Expected native int or pointer, but got VT
		//IL_05f9: Expected F4, but got Obj
		//IL_05f4: Expected native int or pointer, but got VT
		//IL_060e: Expected F4, but got I
		//IL_0609: Expected native int or pointer, but got VT
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_00cb: Expected I, but got Obj
		//IL_0164: Expected F4, but got Obj
		//IL_015f: Expected native int or pointer, but got VT
		//IL_0179: Expected F4, but got I
		//IL_0174: Expected native int or pointer, but got VT
		//IL_018a: Expected I4, but got VT
		//IL_018a: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got VT
		//IL_0197: Expected native int or pointer, but got VT
		//IL_01a9: Expected native int or pointer, but got VT
		//IL_01b7: Expected Obj, but got VT
		//IL_0118: Expected I, but got Obj
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got VT
		//IL_021d: Expected Obj, but got VT
		//IL_0245: Expected Obj, but got VT
		//IL_0256: Expected F4, but got Obj
		//IL_0251: Expected native int or pointer, but got VT
		//IL_026b: Expected F4, but got I
		//IL_0266: Expected native int or pointer, but got VT
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_0640: Expected I, but got Obj
		//IL_0656: Expected Obj, but got I
		//IL_036c: Expected Obj, but got VT
		//IL_037b: Expected Obj, but got VT
		//IL_030b: Expected I, but got Obj
		//IL_0396: Expected Obj, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected I4, but got Unknown
		//IL_0358: Expected I4, but got VT
		//IL_0461: Expected Obj, but got VT
		//IL_03dc: Expected I, but got Obj
		//IL_03f2: Expected Obj, but got I
		//IL_0689: Expected VT, but got Obj
		//IL_0689: Expected Obj, but got I4
		//IL_06ab: Expected Obj, but got VT
		//IL_041d: Expected I, but got Obj
		GameObject gameObject = ((Component)gamePosition).gameObject;
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v95 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool((Transform)(object)gameObject);
		string tag = ((Component)(object)prefabPool).tag;
		((GameObject)(object)tag).tag = (string)1;
		GameObject gameObject2 = _currentSection.gameObject;
		((Transform)(object)prefabPool).parentInternal = (Transform)(object)gameObject2;
		((Transform.Enumerator)(object)prefabPool).Reset();
		nint num3 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v15 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v109 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		object obj4 = default;
		object obj3 = obj4 + 60;
		object obj5 = this + 168;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v19+8]");
		_ = 0;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v105 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj4 + 48;
		Vector3 back = Vector3.back;
		Vector3 vector = (Vector3)(obj4 + 88);
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v30+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj8 = obj4 + 36;
		Vector3 vector3 = vector / _length;
		Vector3 vector4 = (Vector3)(obj4 + 72);
		((Vector3*)(nint)vector4)->x = (float)obj3;
		Vector3 vector5 = vector4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v22+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v37+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		object obj9 = obj4 + 24;
		Vector3 vector7 = vector4 - vector;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v44+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		((BackgroundCulling)vector4).Initialize((Material)isRestricted, (int)vector);
		((Vector3*)(nint)vector)->x = vector4.x;
		((Vector3*)(nint)vector)->z = vector4.z;
		Vector3 localPosition = ((Transform)vector).localPosition;
		_0021_00210 componentInChildren = (_0021_00210)((Component)(object)prefabPool).GetComponentInChildren<T>();
		object obj10 = componentInChildren + 116;
		obj10 = this;
		object obj11 = componentInChildren + 120;
		obj11 = _currentSection;
		object obj12 = componentInChildren + 124;
		obj12 = gamePosition;
		_currentSection.RemoveSpawnedChunk((RouteChunk)componentInChildren);
		int spawnedChunkCount = _spawnedChunkCount + 1;
		_spawnedChunkCount = spawnedChunkCount;
		Vector3 gamePositionStart = ((RouteChunk)componentInChildren).GamePositionStart;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector9 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj13 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B8");
		List<RouteChunk> chunks = _chunks;
		RouteChunk routeChunk;
		if (chunks._size != 0)
		{
			List<RouteChunk> chunks2 = _chunks;
			int index = chunks2._size - 1;
			routeChunk = _chunks.get_Item(index);
		}
		else
		{
			routeChunk = null;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v77 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v97 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)routeChunk).FindKernel((string)null) != 0)
		{
			((RouteBuilder)null).DespawnRouteChunk(routeChunk, (byte)(int)componentInChildren != 0);
		}
		_chunksSpawnedThisUpdate.Add((RouteChunk)componentInChildren);
		_chunks.Add((RouteChunk)componentInChildren);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v52 (T)+20]");
		object obj15 = (nint)0 * (nint)90;
		int length = obj15 + _length;
		_length = length;
		if (OnRouteChunkSpawned != null)
		{
			nint num9 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S2_v26 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num10 = (nint)typeof(GamePositionRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S2_v32 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isRestricted2 = AgeRestriction.isRestricted;
			Vector3 gamePosition2 = ((GamePositionRoot)isRestricted2).GetGamePosition((Vector3)prefabPool);
			OnRouteChunkSpawned(_route, (RouteChunk)componentInChildren, vector.z);
		}
		return (RouteChunk)componentInChildren;
	}

	protected void DespawnRouteChunk(RouteChunk chunk, bool instantDespawn)
	{
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0124: Expected I, but got Obj
		//IL_013a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_018d: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0068: Expected Obj, but got I4
		//IL_007b: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)chunk).FindKernel((string)null) != 0)
		{
			object obj2 = chunk + 76;
			obj2 = instantDespawn;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)instantDespawn).FindKernel(null) != 0)
		{
			object obj4 = (instantDespawn ? 1 : 0) + 72;
			obj4 = chunk;
		}
	}

	private IEnumerator DespawnRouteChunkASync(RouteChunk chunk)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 24;
		object obj3 = obj2 + 12;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		_ = 0;
		int num = default;
		RouteChunk result;
		int num4 = default;
		while (true)
		{
			List<RouteChunk> chunks = _chunks;
			if (num >= chunks._size)
			{
				result = null;
				break;
			}
			RouteChunk routeChunk = _chunks.get_Item(num);
			Vector3 gamePositionStart = routeChunk.GamePositionStart;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			obj2 = chunk;
			_ = ((UnityEngine.Object)chunk).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			if (num2 < 0)
			{
				obj = chunk;
				_ = ((UnityEngine.Object)chunk).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				bool flag = num3 < 0;
				result = routeChunk;
				if (flag)
				{
					break;
				}
			}
			num = num4 + 1;
		}
		return (IEnumerator)result;
	}

	protected void DespawnAllRouteChunks()
	{
		//IL_002b: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		while (true)
		{
			if (_sectionLayingProgress != RouteBuildProgress.Done)
			{
				RouteChunk routeChunk = SpawnRouteChunk((RouteChunk)_sectionLayingProgress);
				bool flag = (nint)routeChunk < 1;
				bool flag2 = _sectionLayingProgress != RouteBuildProgress.Mid;
				object obj = flag | flag2;
				if (obj != null || (~(_midSectionsCountLimited ? 1u : 0u) == 0 && _midSectionCountUsed >= _midSectionsCountTarget))
				{
					RouteBuildProgress sectionLayingProgress = _sectionLayingProgress + 1;
					_sectionLayingProgress = sectionLayingProgress;
					if (_sectionLayingProgress == RouteBuildProgress.Done)
					{
						break;
					}
					RouteChunk routeChunk2 = SpawnRouteChunk((RouteChunk)_sectionLayingProgress);
					if ((object)routeChunk2 != null)
					{
						return;
					}
					continue;
				}
				return;
			}
			return;
		}
		_completedSectionLayingThisUpdate = true;
	}

	protected void DespawnPassedChunks(float characterGamePositionZ)
	{
		_completedSectionLayingThisUpdate = false;
		throw new IndexOutOfRangeException();
	}

	private bool CanDespawnPassedChunk(RouteChunk chunk, float characterGamePositionZ)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 24;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = chunk;
		return flag;
	}

	protected void DespawnUnbuiltChunks()
	{
		//IL_0027: Expected Obj, but got I4
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_00c9: Expected I, but got Obj
		List<RouteChunk> chunks = _chunks;
		int num = chunks._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 < 0)
			{
				break;
			}
			RouteChunk sender = _chunks.get_Item(num2);
			RouteBuilder_OnCompletedLayingSections(sender, (EventArgs)1);
			num = num2;
		}
		List<RouteSection> sections = _sections;
		int num3 = sections._size;
		while (true)
		{
			int num4 = num3 - 1;
			if (num4 < 0)
			{
				break;
			}
			RouteSection routeSection = _sections.get_Item(num4);
			GameObject gameObject = routeSection.gameObject;
			nint num5 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v13 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num6 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v18 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PoolManager.AddPool((PrefabPool)(object)gameObject);
			num3 = num4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
	}

	protected void RemoveEmptySections()
	{
		List<RouteChunk> chunks = _chunks;
		int num = chunks._size;
		while (true)
		{
			int num2 = num - 1;
			if (num2 >= 0)
			{
				RouteChunk routeChunk = _chunks.get_Item(num2);
				if (~(routeChunk._built ? 1u : 0u) != 0)
				{
					RouteBuilder_OnCompletedLayingSections(routeChunk, null);
				}
				num = num2;
				continue;
			}
			break;
		}
	}

	private IEnumerator PerformSelectionASync(RouteChunk chunk)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = chunk;
		return enumerator;
	}

	private IEnumerator RecursiveSelectionASync(List<Selector> selectors, List<GameObject> objectsToVisit, List<Selector> spawnPoints)
	{
		//IL_048d: Expected Obj, but got I4
		//IL_049b: Expected I, but got Obj
		//IL_04b1: Expected Obj, but got I
		//IL_0541: Expected I4, but got Obj
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_009a: Expected VT, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_0105: Expected VT, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got I4
		//IL_01c3: Expected Obj, but got I
		//IL_01e4: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I
		//IL_021c: Expected I, but got Obj
		//IL_0232: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I
		//IL_025d: Expected I, but got Obj
		//IL_02aa: Expected I, but got Obj
		//IL_02c0: Expected Obj, but got I
		//IL_02eb: Expected I, but got Obj
		//IL_0341: Expected Obj, but got I
		//IL_03a4: Expected I, but got Obj
		//IL_03be: Expected I, but got Obj
		//IL_03dc: Expected VT, but got Obj
		//IL_03dc: Expected VT, but got Obj
		//IL_03fb: Expected I, but got Obj
		//IL_0415: Expected I, but got Obj
		//IL_0433: Expected I4, but got Obj
		//IL_0433: Expected I4, but got Obj
		//IL_0433: Expected I4, but got Obj
		//IL_0433: Expected VT, but got Obj
		//IL_044f: Expected Obj, but got I
		object obj = 0;
		nint num = (nint)typeof(StackablePrefabBuilder);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Common.Builders.StackablePrefabBuilder>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(StackablePrefabBuilder);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v95 (Il2CppClass<SYBO.Common.Builders.StackablePrefabBuilder>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)StackablePrefabBuilder._STACKABLE_PREFAB_BUILDER_NAME;
		DeselectMeComponent deselectMeComponent = gameObject.AddComponent<DeselectMeComponent>();
		deselectMeComponent._deselectMeMode = DeselectMeMode.EnabledRedirectToParent;
		int layer = gameObject.layer;
		Transform transform = (Transform)(obj + 4);
		int layer2 = ((GameObject)(object)selectors).layer;
		transform.position = (Vector3)layer2;
		Transform transform2 = (Transform)(obj + 16);
		transform2 = transform;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 localPosition = transform2.localPosition;
		int layer3 = gameObject.layer;
		int layer4 = ((GameObject)(object)selectors).layer;
		HierarchyUtility.Reparent((Transform)layer3, (Transform)layer4, (Vector3)1);
		EventHandler onCompletedLayingSections = this.m_OnCompletedLayingSections;
		IntPtr method_ptr = ((Delegate)onCompletedLayingSections).method_ptr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v30 (System.IntPtr)+C]");
		if ((nint)0 != 3)
		{
			EventHandler onCompletedLayingSections2 = this.m_OnCompletedLayingSections;
			IntPtr method_ptr2 = ((Delegate)onCompletedLayingSections2).method_ptr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v60 (System.IntPtr)+C]");
			transform2 = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string msg = "Stackabel system CURRENTLY requires 3 Prefabs. Has : " + text;
			SDebug.LogFormat(msg, null);
		}
		EventHandler onCompletedLayingSections3 = this.m_OnCompletedLayingSections;
		GameObject gameObject2 = ((List<GameObject>)(nint)((Delegate)onCompletedLayingSections3).method_ptr).get_Item(0);
		EventHandler onCompletedLayingSections4 = this.m_OnCompletedLayingSections;
		GameObject gameObject3 = ((List<GameObject>)(nint)((Delegate)onCompletedLayingSections4).method_ptr).get_Item(1);
		EventHandler onCompletedLayingSections5 = this.m_OnCompletedLayingSections;
		GameObject gameObject4 = ((List<GameObject>)(nint)((Delegate)onCompletedLayingSections5).method_ptr).get_Item(2);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v82 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)gameObject2).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v57 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)gameObject4).FindKernel((string)null) != 0)
			{
				EventHandler onCompletedLayingSections6 = this.m_OnCompletedLayingSections;
				obj = (nint)((Delegate)onCompletedLayingSections6).invoke_impl;
				if (((Delegate)onCompletedLayingSections6).invoke_impl != (IntPtr)0)
				{
					if (((Delegate)onCompletedLayingSections6).invoke_impl != (IntPtr)1)
					{
						EventHandler onCompletedLayingSections7 = this.m_OnCompletedLayingSections;
						obj = (nint)((Delegate)onCompletedLayingSections7).invoke_impl;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						throw new NullReferenceException();
					}
					transform = (Transform)(object)objectsToVisit;
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)objectsToVisit._items;
					transform2 = (Transform)(object)spawnPoints;
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)spawnPoints._items;
					((AlternateRoute)null).Initialize((RouteManager)(object)gameObject, (Vector3)transform, (SectionSpawnMode)transform2, (ChunkBuildMode)gameObject2, (RouteType)gameObject3, (SyboRandom)(object)gameObject4);
				}
				else
				{
					transform = (Transform)(object)objectsToVisit;
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)objectsToVisit._items;
					transform2 = (Transform)(object)spawnPoints;
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)spawnPoints._items;
					((StackablePrefabBuilder)null).BuildYDirection(gameObject, (Vector3)transform, (Vector3)transform2, gameObject2, gameObject3, gameObject4);
				}
			}
		}
		return (IEnumerator)(object)gameObject;
	}

	private unsafe void RouteBuilder_OnCompletedLayingSections(object sender, EventArgs args)
	{
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0258: Expected I, but got Obj
		//IL_026e: Expected Obj, but got I
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected VT, but got Unknown
		//IL_02bd: Expected F4, but got Obj
		//IL_02b8: Expected native int or pointer, but got VT
		//IL_02d2: Expected F4, but got I
		//IL_02cd: Expected native int or pointer, but got VT
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_0317: Expected F4, but got Obj
		//IL_0312: Expected native int or pointer, but got VT
		//IL_032c: Expected F4, but got I
		//IL_0327: Expected native int or pointer, but got VT
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected VT, but got Unknown
		//IL_006d: Expected F4, but got Obj
		//IL_0068: Expected native int or pointer, but got VT
		//IL_0082: Expected F4, but got I
		//IL_007d: Expected native int or pointer, but got VT
		//IL_008f: Expected F4, but got Obj
		//IL_008a: Expected native int or pointer, but got VT
		//IL_00a4: Expected F4, but got I
		//IL_009f: Expected native int or pointer, but got VT
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00d0: Expected F4, but got Obj
		//IL_00cb: Expected native int or pointer, but got VT
		//IL_00e5: Expected F4, but got I
		//IL_00e0: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_016a: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I4
		//IL_0186: Expected Obj, but got F4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01ba: Expected F4, but got Obj
		//IL_01b5: Expected native int or pointer, but got VT
		//IL_01cf: Expected F4, but got I
		//IL_01ca: Expected native int or pointer, but got VT
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_0226: Expected I4, but got Obj
		//IL_0226: Expected I4, but got Obj
		//IL_0226: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 84;
		object obj3 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F499");
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v68 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 72;
		Vector3 back = Vector3.back;
		Vector3 vector = (Vector3)(obj2 + 108);
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v16+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj6 = obj2 + 60;
		Quaternion quaternion = Quaternion.AngleAxis(0.5f, vector);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+20]");
		float num3 = 0f * 90f;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v21+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj7 = obj2 + 48;
		Vector3 vector2 = vector / num3;
		Vector3 vector3 = (Vector3)(obj2 + 96);
		((Vector3*)(nint)vector3)->x = (float)obj;
		Vector3 vector4 = vector3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v28+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj8 = obj2 + 36;
		Vector3 vector5 = vector3 - vector;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v35+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A1");
		object obj9 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		object obj10 = obj2 + 24;
		object obj11 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		object obj12 = obj2 + 12;
		object obj13 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sender @ L1 (System.Object)+20]");
		object obj14 = (nint)0 * (nint)90;
		obj2 = 0;
		_ = 0;
		obj2 = vector3.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v43+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v47+8]");
		object obj15 = 0 - obj14;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj16 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A5");
		bool flag = _chunks.Remove((RouteChunk)sender);
		IEnumerator enumerator = PerformSelectionASync((RouteChunk)sender);
		((SelectionPlaceholderLifecycle)(object)_worker).SpawnInstances((byte)(int)sender != 0, (byte)(int)enumerator != 0, (byte)(int)args != 0);
	}

	private unsafe void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind spawnedKind, int gamePositionZ, Route route)
	{
		//IL_032c: Expected I, but got Obj
		//IL_0342: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_00f3: Expected I, but got Obj
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I4
		//IL_03e0: Expected I, but got Obj
		//IL_03f6: Expected Obj, but got I
		//IL_0181: Expected I, but got Obj
		//IL_04c3: Expected Obj, but got I
		//IL_04c3: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I
		//IL_01de: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_02af: Expected I, but got Obj
		//IL_0425: Expected Obj, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0319: Expected Obj, but got I
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_047a: Expected Obj, but got I
		//IL_021f: Expected I, but got Obj
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_027c: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I
		//IL_029c: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (route != null)
		{
			SDebug.LogFormat("Character is outside bounds for any route!", null);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		RouteChunk routeChunk = (RouteChunk)((int*)gamePositionZ)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [gamePositionZ @ L2 (System.Int32)+8]");
		((UnityEngine.Object)routeChunk).m_CachedPtr = (IntPtr)0;
		RouteBuilder routeBuilder = default;
		IEnumerator enumerator = routeBuilder.DespawnRouteChunkASync(routeChunk);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)enumerator != null)
		{
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)spawnedKind._density).FindKernel((string)(object)enumerator) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+50]");
			object obj4 = 0;
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v38+C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				object obj6 = spawnedKind + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.Builders.RouteBuilder)+50]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v40+C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v41+50]");
				obj6 = 0;
			}
			object obj9 = spawnedKind + 12;
			obj9 = enumerator;
			object obj10 = spawnedKind + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v19 (System.Collections.IEnumerator)+4C]");
			obj10 = 0;
		}
		EnvironmentDensity density = spawnedKind._density;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S2_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [spawnedKind @ L1 (SYBO.Subway.Level.EnvironmentKind)+10]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v20 (SYBO.Subway.Level.EnvironmentDensity)+4C]");
		if (((ComputeShader)num11).FindKernel((string)0) != 0)
		{
			object obj12 = spawnedKind + 16;
			EnvironmentDensity density2 = spawnedKind._density;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v24 (SYBO.Subway.Level.EnvironmentDensity)+4C]");
			obj12 = 0;
		}
	}

	public EnvironmentKind GetEnvironmentKindAt(float gamePositionZ)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I
		//IL_0056: Invalid comparison between Obj and F4
		//IL_0242: Expected Obj, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_008f: Invalid comparison between Obj and F4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)gamePositionZ))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)gamePositionZ))
					{
						object obj8 = obj4 + 4;
						object obj9 = obj8 + 1;
						obj8 = obj9;
						object obj10 = obj9 << 2;
						object obj11 = obj4 + obj10;
						obj11 = 73;
						break;
					}
				}
				continue;
			}
			object obj12 = obj4 + 4;
			object obj13 = obj12 + 1;
			obj12 = obj13;
			object obj14 = obj13 << 2;
			object obj15 = obj4 + obj14;
			obj15 = 71;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj4 + obj16;
			if ((nint)obj17 == 73)
			{
				object obj18 = obj4 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_03dc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj4 + obj20;
			if ((nint)obj21 == 71)
			{
				object obj22 = obj4 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_03dc;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03dc;
		IL_03dc:
		EnvironmentKind result = default;
		return result;
	}
}
