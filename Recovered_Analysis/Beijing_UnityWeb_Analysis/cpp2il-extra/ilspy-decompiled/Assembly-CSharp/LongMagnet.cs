using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Info;
using SYBO.Common;
using SYBO.Subway;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Coins;
using SYBO.Subway.Pickups;
using SYBO.Subway.Pickups.Pickers;
using UnityEngine;
using UnityEngine.Rendering;

public class LongMagnet : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public PickupSpawnPoint pickupSpawnPoint;

		public Vector3 position;

		public LongMagnet _003C_003E4__this;

		public _003C_003Ec__DisplayClass9_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal unsafe void _003CPullPickupSpawnPoint_003Eb__0(float t)
		{
			//IL_006a: Expected Obj, but got I4
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected Obj, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected Obj, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected Obj, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected Obj, but got Unknown
			//IL_00d8: Expected I, but got Obj
			//IL_00ee: Expected Obj, but got I
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected VT, but got Unknown
			//IL_0126: Expected F4, but got Obj
			//IL_0121: Expected native int or pointer, but got VT
			//IL_013b: Expected F4, but got I
			//IL_0136: Expected native int or pointer, but got VT
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected VT, but got Unknown
			//IL_0156: Expected F4, but got Obj
			//IL_0151: Expected native int or pointer, but got VT
			//IL_016b: Expected F4, but got I
			//IL_0166: Expected native int or pointer, but got VT
			//IL_018d: Expected F4, but got Obj
			//IL_0188: Expected native int or pointer, but got VT
			//IL_01a2: Expected F4, but got I
			//IL_019d: Expected native int or pointer, but got VT
			//IL_01ab: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			PickupSpawnPoint pickupSpawnPoint = this.pickupSpawnPoint;
			int layer = ((GameObject)pickupSpawnPoint._ignoreJetpackZ).layer;
			object obj2 = default;
			object obj = obj2 + 24;
			object obj3 = this + 12;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v3+8]");
			_ = 0;
			object obj4 = obj2 + 12;
			object obj5 = this + 24;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v9+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v11 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v25 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector = (Vector3)(obj2 + 36);
			((Vector3*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v5+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = (Vector3)(obj2 + 48);
			((Vector3*)(nint)vector2)->x = (float)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v8+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 vector3 = Vector3.LerpUnclamped(vector, vector2, t);
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			Vector3 localPosition = ((Transform)vector2).localPosition;
		}
	}

	private sealed class _003CPullPickupSpawnPoint_003Ed__9(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PickupSpawnPoint pickupSpawnPoint;

		public LongMagnet _003C_003E4__this;

		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0378: Unknown result type (might be due to invalid IL or missing references)
				//IL_037d: Expected VT, but got Unknown
				//IL_0386: Unknown result type (might be due to invalid IL or missing references)
				//IL_038b: Expected VT, but got Unknown
				//IL_0394: Unknown result type (might be due to invalid IL or missing references)
				//IL_0399: Expected Obj, but got Unknown
				//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a7: Expected Obj, but got Unknown
				//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03b5: Expected Obj, but got Unknown
				//IL_03be: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c3: Expected Obj, but got Unknown
				//IL_03cc: Expected Obj, but got I4
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected Obj, but got Unknown
				//IL_00c0: Expected VT, but got I4
				//IL_00cd: Expected F4, but got Obj
				//IL_00c8: Expected native int or pointer, but got VT
				//IL_00df: Expected F4, but got I
				//IL_00da: Expected native int or pointer, but got VT
				//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Expected Obj, but got Unknown
				//IL_00fc: Expected Obj, but got F4
				//IL_0111: Unknown result type (might be due to invalid IL or missing references)
				//IL_0116: Expected Obj, but got Unknown
				//IL_013c: Expected Obj, but got I
				//IL_0152: Expected VT, but got Obj
				//IL_0160: Expected I, but got Obj
				//IL_0176: Expected Obj, but got I
				//IL_0408: Expected F4, but got Obj
				//IL_0403: Expected native int or pointer, but got VT
				//IL_041d: Expected F4, but got I
				//IL_0418: Expected native int or pointer, but got VT
				//IL_042a: Expected F4, but got Obj
				//IL_0425: Expected native int or pointer, but got VT
				//IL_043c: Expected F4, but got I
				//IL_0437: Expected native int or pointer, but got VT
				//IL_047c: Expected Obj, but got I
				//IL_048c: Expected Obj, but got I
				//IL_04a9: Expected Obj, but got I
				//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fc: Expected Obj, but got Unknown
				//IL_020c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0211: Expected Obj, but got Unknown
				//IL_0221: Unknown result type (might be due to invalid IL or missing references)
				//IL_0226: Expected Obj, but got Unknown
				//IL_01a1: Expected I, but got Obj
				//IL_02db: Expected I, but got Obj
				//IL_02f1: Expected Obj, but got I
				//IL_026f: Expected Obj, but got I4
				//IL_031c: Expected I, but got Obj
				object obj = default;
				Vector3 vector = (Vector3)(obj + 72);
				Vector3 vector2 = (Vector3)(obj + 60);
				Transform transform = (Transform)(obj + 36);
				object obj2 = obj + 24;
				Transform transform2 = (Transform)(obj + 12);
				object obj3 = obj + 48;
				obj3 = 0;
				_ = 0;
				LongMagnet longMagnet = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						_003C_003Ec__DisplayClass9_0 obj4 = _003C_003E8__1;
						PickupSpawnPoint pickupSpawnPoint = obj4.pickupSpawnPoint;
						if (pickupSpawnPoint.__spawnPointState == SpawnPointState.Spawned)
						{
							_003C_003Ec__DisplayClass9_0 obj5 = _003C_003E8__1;
							nint num = (nint)typeof(Character);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v73 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num2 = (nint)typeof(Character);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v80 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							CharacterRendering instance = CharacterRendering.Instance;
							((PickerCollection)(object)obj5.pickupSpawnPoint).OnPickerRemoveRequest += (Action<PickerRemoveRequestEventArgs>)(object)instance._characterModel;
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj7 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj8 = default;
				obj7 = obj8;
				object obj9 = _003C_003E8__1 + 8;
				obj9 = this.pickupSpawnPoint;
				object obj10 = _003C_003E8__1 + 24;
				obj10 = _003C_003E4__this;
				_003C_003Ec__DisplayClass9_0 obj11 = _003C_003E8__1;
				PickupSpawnPoint pickupSpawnPoint2 = obj11.pickupSpawnPoint;
				int layer = pickupSpawnPoint2._spawnedPickupVisuals.layer;
				transform.position = (Vector3)layer;
				((Vector3*)(nint)vector)->x = (float)transform;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				object obj12 = _003C_003E8__1 + 12;
				obj12 = vector.x;
				_ = vector.z;
				object obj13 = _003C_003E8__1 + 12;
				obj2 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v34+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22 (LongMagnet)+10]");
				GameObject gameObject = ((Component)0).gameObject;
				transform2.position = (Vector3)gameObject;
				nint num3 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num4 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				((Vector3*)(nint)vector)->x = (float)transform2;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22 (LongMagnet)+C]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v59+58]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v59+44]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v57+8]");
				object obj17 = num5 / 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num6 = 0;
				_ = 0;
				object obj19 = default;
				object obj18 = obj19 + 16;
				obj18 = _003C_003E8__1;
				object obj20 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v22 (LongMagnet)+20]");
				object obj21 = 0 * obj17;
				object obj23 = default;
				object obj22 = obj23 / obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
				IEnumerator routine = default;
				Coroutine coroutine = longMagnet.StartCoroutine_Auto(routine);
				obj20 = coroutine;
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

	private Game game;

	private CharacterController characterController;

	private CharacterRendering characterRendering;

	private Character character;

	private CollisionNotifier coinMagnetCollider;

	public float pullSpeed;

	private VariableBool longMagnetSuction;

	public bool ShouldBeActive => true;

	public VariableBool LongMagnetSuction
	{
		get
		{
			//IL_0125: Expected I, but got Obj
			//IL_013b: Expected Obj, but got I
			//IL_0097: Expected I, but got Obj
			//IL_00ad: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0188: Expected Obj, but got I4
			//IL_00d8: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I4
			nint num = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Hoverboard>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Hoverboard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Hoverboard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (CharacterModifier)+54]");
			if ((nint)0 != 0)
			{
				Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
				if (previousBoardId == Boards.BoardId.gliderboard)
				{
					return (VariableBool)1;
				}
			}
			nint num3 = (nint)typeof(SuperSneakers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<SuperSneakers>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SuperSneakers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v25 (Il2CppClass<SuperSneakers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool watchedReviveAdInCurrentRun = SaveMeManager.WatchedReviveAdInCurrentRun;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (System.Boolean)+20]");
			bool flag = (nint)0 != 0;
			return (VariableBool)flag;
		}
	}

	public void Start()
	{
		_ = 50f;
		_ = 90f;
		_ = 0.3f;
		_ = 250f;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public void CoinHit(Collider collider)
	{
		//IL_0efb: Expected Obj, but got I
		//IL_0f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Expected Obj, but got Unknown
		//IL_0f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1f: Expected Obj, but got Unknown
		//IL_0f3f: Expected Obj, but got I
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6a: Expected Obj, but got Unknown
		//IL_0fce: Expected Obj, but got I4
		//IL_00e8: Expected Obj, but got I
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I4
		//IL_100a: Expected Obj, but got I4
		//IL_03f3: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I
		//IL_0467: Expected I, but got Obj
		//IL_047d: Expected Obj, but got I
		//IL_0175: Expected I, but got Obj
		//IL_10a4: Expected Obj, but got I
		//IL_10c5: Expected I, but got Obj
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_01ca: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I4
		//IL_10e6: Expected Obj, but got I4
		//IL_10fc: Expected Obj, but got I
		//IL_04a8: Expected I, but got Obj
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_074a: Expected Obj, but got I
		//IL_04fa: Expected I, but got Obj
		//IL_07fb: Expected Obj, but got I
		//IL_055c: Expected F4, but got I4
		//IL_0572: Expected Obj, but got I
		//IL_02de: Expected I, but got Obj
		//IL_0350: Expected I, but got Obj
		//IL_0366: Expected Obj, but got I
		//IL_092c: Expected Obj, but got I
		//IL_07b3: Expected Obj, but got I
		//IL_07c5: Expected Obj, but got I
		//IL_07d7: Expected Obj, but got I4
		//IL_07e0: Expected Obj, but got I4
		//IL_0606: Expected Obj, but got I
		//IL_032b: Expected I, but got Obj
		//IL_0334: Expected Obj, but got I4
		//IL_107b: Expected I, but got Obj
		//IL_1084: Expected Obj, but got I4
		//IL_0a5d: Expected Obj, but got I
		//IL_1041: Unknown result type (might be due to invalid IL or missing references)
		//IL_1046: Expected Obj, but got Unknown
		//IL_062e: Expected Obj, but got I
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
		//IL_066a: Expected I, but got Obj
		//IL_0680: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I
		//IL_05da: Expected Obj, but got I
		//IL_05f0: Expected Obj, but got I
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected Obj, but got Unknown
		//IL_051b: Expected Obj, but got I
		//IL_0391: Expected I, but got Obj
		//IL_0be7: Expected Obj, but got I
		//IL_0896: Expected I, but got Obj
		//IL_08ac: Expected Obj, but got I
		//IL_1178: Expected Obj, but got I
		//IL_119e: Expected Obj, but got I4
		//IL_0c76: Expected Obj, but got I
		//IL_0abb: Expected Obj, but got I4
		//IL_0acc: Expected Obj, but got I
		//IL_09c7: Expected I, but got Obj
		//IL_09dd: Expected Obj, but got I
		//IL_11c3: Expected Obj, but got I4
		//IL_11c3: Expected Obj, but got I4
		//IL_11d1: Expected I, but got Obj
		//IL_11db: Expected Obj, but got I4
		//IL_11e4: Expected Obj, but got I4
		//IL_0d97: Expected Obj, but got I
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Expected Obj, but got Unknown
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected Obj, but got Unknown
		//IL_0dd3: Expected I, but got Obj
		//IL_0de9: Expected Obj, but got I
		//IL_0c52: Expected Obj, but got I4
		//IL_0c5b: Expected Obj, but got I4
		//IL_0af4: Expected Obj, but got I
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Expected Obj, but got Unknown
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected Obj, but got Unknown
		//IL_0b30: Expected I, but got Obj
		//IL_0b46: Expected Obj, but got I
		//IL_11fc: Expected Obj, but got I4
		//IL_120a: Expected I, but got Obj
		//IL_1214: Expected Obj, but got I4
		//IL_121d: Expected Obj, but got I4
		//IL_08d7: Expected I, but got Obj
		//IL_06fd: Expected Obj, but got I4
		//IL_126a: Expected Obj, but got I
		//IL_1290: Expected Obj, but got I4
		//IL_0ce2: Expected Obj, but got I
		//IL_0d31: Expected Obj, but got I4
		//IL_0d3a: Expected Obj, but got I4
		//IL_122c: Expected Obj, but got I
		//IL_1252: Expected Obj, but got I4
		//IL_0a08: Expected I, but got Obj
		//IL_071c: Expected Obj, but got I
		//IL_072f: Expected Obj, but got I4
		//IL_0e88: Expected Obj, but got I4
		//IL_0d60: Expected Obj, but got I4
		//IL_0d69: Expected Obj, but got I4
		//IL_0bb9: Expected Obj, but got I
		//IL_0bcc: Expected Obj, but got I4
		//IL_0e9f: Expected Obj, but got I
		//IL_0eb2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		List<AnimationClip> list = (List<AnimationClip>)(obj3 + 22691);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v131 @ S3_v11 (System.Collections.Generic.List`1<UnityEngine.AnimationClip>) (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
		object obj4 = (nint)0 + (nint)12;
		if (obj4 != null)
		{
			bool flag;
			if ((nint)obj4 < 2)
			{
				flag = true;
			}
			else
			{
				Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v136 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num3 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v160 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2;
				if (BoardManager.IsThemeOwned(previousBoardId, HoverboardThemes.ThemeIdentifier.none))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
					object obj6 = (nint)0 + (nint)20;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v246+1C]");
					flag2 = (nint)0 != 0;
				}
				else
				{
					flag2 = true;
				}
				bool flag3 = (nint)obj4 >= 3;
				bool flag4 = !flag3;
				flag = flag2;
				obj2 = 0;
				if (!flag4)
				{
					Boards.BoardId previousBoardId2 = PlayerSave.previousBoardId;
					nint num4 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S1_v144 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num5 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S1_v154 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag5 = BoardManager.IsThemeOwned(previousBoardId2, HoverboardThemes.ThemeIdentifier.heroboardTheme01);
					bool flag6 = !flag5;
					flag = flag2;
					obj2 = 0;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
						object obj9 = (nint)0 + (nint)24;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S1_v151+1C]");
						bool flag7 = (nint)0 != 0;
						bool flag8 = flag2 & flag7;
						flag = flag8;
						obj2 = 0;
					}
				}
			}
			object obj12 = default;
			object obj11 = obj12 + 12;
			HoverboardModelPreviewFactory hoverboardModelPreviewFactory2;
			nint num8 = default;
			nint num9;
			IntPtr intPtr = default;
			IntPtr intPtr2 = default;
			IntPtr intPtr3 = default;
			for (HoverboardModelPreviewFactory hoverboardModelPreviewFactory = null; System.Runtime.CompilerServices.Unsafe.As<HoverboardModelPreviewFactory, UIntPtr>(ref hoverboardModelPreviewFactory) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4); hoverboardModelPreviewFactory2 = (HoverboardModelPreviewFactory)(hoverboardModelPreviewFactory + 1), num8 = num9, hoverboardModelPreviewFactory = hoverboardModelPreviewFactory2)
			{
				bool flag9 = (object)hoverboardModelPreviewFactory == null;
				object obj13 = flag & flag9;
				if (obj13 == null)
				{
					object obj14 = hoverboardModelPreviewFactory - 1;
					if ((nint)hoverboardModelPreviewFactory != 1)
					{
						if ((nint)obj14 == 1)
						{
							Boards.BoardId previousBoardId3 = PlayerSave.previousBoardId;
							nint num6 = (nint)typeof(BoardManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v126 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
							object obj15 = (nint)0 & (nint)0x200;
							if (obj15 != null)
							{
								nint num7 = (nint)typeof(BoardManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S1_v131 (Il2CppClass<Data.Managers.BoardManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag10 = BoardManager.IsThemeOwned(previousBoardId3, HoverboardThemes.ThemeIdentifier.heroboardTheme01);
							num8 = (nint)typeof(BoardManager);
							obj2 = 0;
							if (flag10)
							{
								goto IL_03dd;
							}
						}
						num9 = num8;
						continue;
					}
					Boards.BoardId previousBoardId4 = PlayerSave.previousBoardId;
					nint num10 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v115 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num11 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v120 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!BoardManager.IsThemeOwned(previousBoardId4, HoverboardThemes.ThemeIdentifier.none))
					{
						num9 = (nint)typeof(BoardManager);
						obj2 = 0;
						continue;
					}
				}
				goto IL_03dd;
				IL_03dd:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
				object obj17 = (nint)0 + (nint)16;
				object obj18 = (object)hoverboardModelPreviewFactory << 2;
				object obj19 = obj17 + obj18;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
				object obj21 = (nint)0 + (nint)16;
				object obj22 = (object)hoverboardModelPreviewFactory << 2;
				object obj23 = obj21 + obj22;
				object obj24 = obj23;
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				if (obj25 != null)
				{
					nint num13 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v218 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v39+C]");
				int num14 = ((ComputeShader)0).FindKernel(null);
				bool flag11 = num14 == 0;
				nint num15 = (nint)typeof(UnityEngine.Object);
				if (!flag11)
				{
					Quaternion hoverboardDefaultRotation = hoverboardModelPreviewFactory.GetHoverboardDefaultRotation(null);
					num15 = unchecked((nint)null);
					while (num15 < (nint)obj11)
					{
						object obj26 = obj12 + 16;
						object obj27 = num15 << 2;
						object obj28 = obj26 + obj27;
						((Renderer)obj28).shadowCastingMode = ShadowCastingMode.Off;
						nint num16 = num15 + 1;
						num15 = num16;
					}
				}
				((HoverboardRendering)(object)collider).AddClipsToAnimationComp((Animation)(object)hoverboardModelPreviewFactory, (AnimationClip)null, (List<AnimationClip>)1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
				object obj29 = (nint)0 + (nint)16;
				object obj30 = (object)hoverboardModelPreviewFactory << 2;
				object obj31 = obj29 + obj30;
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v53+8]");
				if ((nint)0 == 1)
				{
					pullSpeed = 1f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
					object obj33 = (nint)0 + (nint)16;
					object obj34 = (object)hoverboardModelPreviewFactory << 2;
					object obj35 = obj33 + obj34;
					object obj36 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S0_v180+1D]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet)+50]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v204+BC]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v205+9C]");
						((Renderer)0).shadowCastingMode = ShadowCastingMode.On;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet)+4C]");
					((LongMagnet)0).Deactivate();
					string text = collider.tag;
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S2_v46 (Il2CppMethodInfo)+18]");
					object obj39 = 0;
					object obj40 = obj39;
					object obj41 = obj40 & 0x1FFF;
					list = (List<AnimationClip>)(obj41 + 22691);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v131 @ S3_v11 (System.Collections.Generic.List`1<UnityEngine.AnimationClip>) (should have been resolved before IL gen)");
					nint num18 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ S0_v189 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj42 = (nint)0 & (nint)0x200;
					if (obj42 != null)
					{
						ComputeShader typeFromHandle = (ComputeShader)(object)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S0_v199 (UnityEngine.ComputeShader)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num19 = ((ComputeShader)(nint)intPtr).FindKernel(null);
					bool flag12 = num19 == 0;
					num9 = intPtr;
					obj2 = 0;
					if (!flag12)
					{
						num9 = intPtr;
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S0_v187 (Il2CppClass<Data.Managers.BoardManager>)+20]");
						if ((nint)0 == 0)
						{
							((playThruster)(nint)intPtr).OnEnable();
							num9 = intPtr;
							obj2 = 0;
						}
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
				object obj43 = (nint)0 + (nint)16;
				object obj44 = (object)hoverboardModelPreviewFactory << 2;
				object obj45 = obj43 + obj44;
				object obj46 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S0_v59+8]");
				if ((nint)0 == 2)
				{
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet)+50]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v174+D8]");
					((VariableBool)0).Remove(this);
					num9 = num15;
					list = (List<AnimationClip>)1;
					obj2 = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
				object obj48 = (nint)0 + (nint)16;
				object obj49 = (object)hoverboardModelPreviewFactory << 2;
				object obj50 = obj48 + obj49;
				object obj51 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v65+8]");
				if ((nint)0 == 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet)+74]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					}
					_ = 1;
					nint num20 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v160 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj52 = (nint)0 & (nint)0x200;
					if (obj52 != null)
					{
						nint num21 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ S0_v166 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated = Game.IsInstantiated;
					((Game)isInstantiated).RegisterSpeedChangeHandler((Action<float>)1);
					num9 = (nint)typeof(Game);
					list = (List<AnimationClip>)1;
					obj2 = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
				object obj53 = (nint)0 + (nint)16;
				object obj54 = (object)hoverboardModelPreviewFactory << 2;
				object obj55 = obj53 + obj54;
				object obj56 = obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v71+8]");
				if ((nint)0 == 4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet)+74]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					}
					_ = 1;
					nint num22 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S0_v143 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj57 = (nint)0 & (nint)0x200;
					if (obj57 != null)
					{
						nint num23 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ S0_v149 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated2 = Game.IsInstantiated;
					((Game)isInstantiated2).RegisterSpeedChangeHandler(null);
					num9 = (nint)typeof(Game);
					list = (List<AnimationClip>)1;
					obj2 = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
				object obj58 = (nint)0 + (nint)16;
				object obj59 = (object)hoverboardModelPreviewFactory << 2;
				object obj60 = obj58 + obj59;
				object obj61 = obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v77+8]");
				if ((nint)0 == 6)
				{
					longMagnetSuction = (VariableBool)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet)+4C]");
					((LongMagnet)0).Deactivate();
					string text2 = collider.tag;
					nint num24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ S2_v36 (Il2CppMethodInfo)+18]");
					object obj62 = 0;
					object obj63 = obj62;
					object obj64 = obj63 & 0x1FFF;
					list = (List<AnimationClip>)(obj64 + 22691);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v131 @ S3_v11 (System.Collections.Generic.List`1<UnityEngine.AnimationClip>) (should have been resolved before IL gen)");
					nint num25 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ S0_v126 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj65 = (nint)0 & (nint)0x200;
					if (obj65 != null)
					{
						ComputeShader typeFromHandle2 = (ComputeShader)(object)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S0_v134 (UnityEngine.ComputeShader)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num26 = ((ComputeShader)(nint)intPtr2).FindKernel(null);
					bool flag13 = num26 == 0;
					num9 = intPtr2;
					obj2 = 0;
					if (!flag13)
					{
						((GliderAnimation)(nint)intPtr2).OnDestroy();
						num9 = intPtr2;
						obj2 = 0;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
				object obj66 = (nint)0 + (nint)16;
				object obj67 = (object)hoverboardModelPreviewFactory << 2;
				object obj68 = obj66 + obj67;
				object obj69 = obj68;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S0_v83+8]");
				if ((nint)0 == 7)
				{
					_ = 1;
					num9 = num15;
					list = (List<AnimationClip>)1;
					obj2 = 2;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
				object obj70 = (nint)0 + (nint)16;
				object obj71 = (object)hoverboardModelPreviewFactory << 2;
				object obj72 = obj70 + obj71;
				object obj73 = obj72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S0_v89+8]");
				if ((nint)0 != 5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [collider @ L1 (UnityEngine.Collider)+C]");
					object obj74 = (nint)0 + (nint)16;
					object obj75 = (object)hoverboardModelPreviewFactory << 2;
					object obj76 = obj74 + obj75;
					object obj77 = obj76;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S0_v114+8]");
					bool flag14 = (nint)0 != 8;
					num9 = num15;
					list = (List<AnimationClip>)1;
					obj2 = 2;
					if (!flag14)
					{
						_ = 1;
						num9 = num15;
						list = (List<AnimationClip>)1;
						obj2 = 2;
					}
					continue;
				}
				_ = 1;
				string text3 = collider.tag;
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S2_v30 (Il2CppMethodInfo)+18]");
				object obj78 = 0;
				object obj79 = obj78;
				object obj80 = obj79 & 0x1FFF;
				list = (List<AnimationClip>)(obj80 + 22691);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v131 @ S3_v11 (System.Collections.Generic.List`1<UnityEngine.AnimationClip>) (should have been resolved before IL gen)");
				nint num28 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ S0_v97 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj81 = (nint)0 & (nint)0x200;
				if (obj81 != null)
				{
					ComputeShader typeFromHandle3 = (ComputeShader)(object)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S0_v107 (UnityEngine.ComputeShader)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num29 = ((ComputeShader)(nint)intPtr3).FindKernel(null);
				bool flag15 = num29 == 0;
				num9 = intPtr3;
				obj2 = 0;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ S0_v95 (Il2CppClass<Data.Managers.BoardManager>)+20]");
					bool flag16 = (nint)0 == 1;
					bool flag17 = !flag16;
					num9 = intPtr3;
					obj2 = 0;
					if (!flag17)
					{
						((playThruster)(nint)intPtr3).OnEnable();
						num9 = intPtr3;
						obj2 = 0;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet)+64]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
	}

	private IEnumerator PullPickupSpawnPoint(PickupSpawnPoint pickupSpawnPoint)
	{
		//IL_001a: Expected Obj, but got I
		//IL_001e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (LongMagnet)+28]");
		return (IEnumerator)((List<CharacterModifier>)0).Contains((CharacterModifier)(object)pickupSpawnPoint);
	}

	public unsafe void Activate()
	{
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0339: Expected I, but got Obj
		//IL_034f: Expected Obj, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0239: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v64 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 24;
		CharacterRendering instance = CharacterRendering.Instance;
		obj2 = instance;
		nint num3 = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v60 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = this + 20;
		CharacterCamera instance2 = CharacterCamera.Instance;
		obj4 = instance2;
		object obj5 = this + 28;
		Character character = this.character;
		obj5 = character.CoinMagnetLongCollider;
		object obj6 = this + 16;
		Character character2 = this.character;
		obj6 = character2._characterController;
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v24 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v56 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = this + 12;
		bool isInstantiated = Game.IsInstantiated;
		obj8 = isInstantiated;
		Game game = this.game;
		Variable<bool> isInGame = game.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj9 = default;
		obj9.method_ptr = method_ptr;
		obj9.method = (nint)__ldftn(LongMagnet._003CStart_003Eb__7_0);
		object obj10 = obj9 + 16;
		obj10 = this;
		object obj11 = game.IsInGame + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v32 (Variable`1<System.Boolean>)+C]");
		Delegate obj12 = ((Delegate)0).CombineImpl(obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj13 = default;
		obj11 = obj13;
		VariableBool variableBool = longMagnetSuction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj14 = default;
		obj14.method_ptr = method_ptr2;
		obj14.method = (nint)__ldftn(LongMagnet._003CStart_003Eb__7_1);
		object obj15 = obj14 + 16;
		obj15 = this;
		object obj16 = longMagnetSuction + 12;
		Delegate obj17 = ((Delegate)variableBool.OnChange).CombineImpl(obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj18 = default;
		obj16 = obj18;
	}

	public void Deactivate()
	{
		longMagnetSuction.Remove(this);
	}

	public LongMagnet()
	{
		((MeFooterNavigation)(object)longMagnetSuction).OnClickButton((Transform)(object)this);
	}

	private void _003CStart_003Eb__7_0(bool value)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I4
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		//IL_0110: Expected I, but got Obj
		//IL_0186: Expected VT, but got Obj
		if (game.IsInPogostickMode)
		{
			return;
		}
		Coin component = ((Component)value).GetComponent<Coin>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			((CoinCurve)(object)component).SpeedChanged(pullSpeed);
			return;
		}
		PickupSpawnPoint component2 = ((Component)value).GetComponent<PickupSpawnPoint>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) != 0 && component2.__spawnPointState == SpawnPointState.Spawned)
		{
			Curve routine = CurveParent.CreateCurve((Transform)(object)this, (Vector3)component2);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)routine);
		}
	}

	private void _003CStart_003Eb__7_1(bool value)
	{
		if (value)
		{
			longMagnetSuction.UpdateValue();
		}
	}
}
