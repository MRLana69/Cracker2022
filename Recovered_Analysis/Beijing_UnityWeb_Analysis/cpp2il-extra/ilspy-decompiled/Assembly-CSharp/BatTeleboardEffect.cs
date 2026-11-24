using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using UnityEngine;

public class BatTeleboardEffect : ATeleboardEffect
{
	private sealed class _003CResetCharacterTeleportFX_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BatTeleboardEffect _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_01e0: Expected I, but got Obj
				//IL_01f6: Expected Obj, but got I
				//IL_00ac: Expected I, but got Obj
				//IL_00c2: Expected Obj, but got I
				//IL_0586: Expected Obj, but got I4
				//IL_019e: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a3: Expected Obj, but got Unknown
				//IL_01bf: Expected Obj, but got I4
				//IL_026e: Expected I, but got Obj
				//IL_0284: Expected Obj, but got I
				//IL_0221: Expected I, but got Obj
				//IL_00ed: Expected I, but got Obj
				//IL_059d: Expected Obj, but got I4
				//IL_02af: Expected I, but got Obj
				//IL_02fc: Expected I, but got Obj
				//IL_0312: Expected Obj, but got I
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0162: Expected Obj, but got Unknown
				//IL_016b: Expected Obj, but got I4
				//IL_017f: Expected Obj, but got I4
				//IL_05e1: Expected Obj, but got I4
				//IL_033d: Expected I, but got Obj
				//IL_038a: Expected I, but got Obj
				//IL_03a0: Expected Obj, but got I
				//IL_0622: Expected Obj, but got I
				//IL_064a: Expected I, but got Obj
				//IL_0660: Expected Obj, but got I
				//IL_03cb: Expected I, but got Obj
				//IL_04ad: Expected I, but got Obj
				//IL_043c: Expected I, but got Obj
				BatTeleboardEffect batTeleboardEffect = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					if (~(batTeleboardEffect._overrideEnd ? 1u : 0u) != 0)
					{
						nint num = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (((ComputeShader)(object)batTeleboardEffect._animation).FindKernel((string)null) != 0 && batTeleboardEffect._animation.Play())
						{
							object obj2 = this + 12;
							obj2 = 0;
							_003C_003E1__state = 1;
							return 1;
						}
					}
					if (!batTeleboardEffect._overrideEnd)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = batTeleboardEffect._reappearDelay;
						object obj3 = this + 12;
						object obj4 = default;
						obj3 = obj4;
						_003C_003E1__state = 2;
						return 1;
					}
				}
				batTeleboardEffect._correctEndYPos = false;
				nint num3 = (nint)typeof(Character);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v13 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(Character);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v81 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CharacterRendering instance = CharacterRendering.Instance;
				string tag = ((Component)(object)instance._cachedModelMaterial).tag;
				((GameObject)(object)tag).tag = (string)1;
				nint num5 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v22 (Il2CppClass<SYBO.Subway.Game>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v77 (Il2CppClass<SYBO.Subway.Game>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool isInstantiated = Game.IsInstantiated;
				if (!((Game)isInstantiated).IsInPogostickMode)
				{
					nint num7 = (nint)typeof(Game);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v33 (Il2CppClass<SYBO.Subway.Game>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num8 = (nint)typeof(Game);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v73 (Il2CppClass<SYBO.Subway.Game>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool isInstantiated2 = Game.IsInstantiated;
					if (!((Game)isInstantiated2).HasSuperSneakers)
					{
						nint num9 = (nint)typeof(Character);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v42 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num10 = (nint)typeof(Character);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v69 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						CharacterRendering instance2 = CharacterRendering.Instance;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v47 (SYBO.Subway.Characters.CharacterRendering)+84]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v48+8]");
						bool flag = (nint)0 != 0;
						nint num11 = (nint)typeof(CharacterRendering);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v18 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						bool flag2 = obj10 == null;
						if (flag)
						{
							if (!flag2)
							{
								nint num12 = (nint)typeof(CharacterRendering);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v65 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							CharacterCamera instance3 = CharacterCamera.Instance;
							((CharacterRendering)(object)instance3).Game_OnEndStumbleDeathSequence();
						}
						else
						{
							if (!flag2)
							{
								nint num13 = (nint)typeof(CharacterRendering);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v56 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							CharacterCamera instance4 = CharacterCamera.Instance;
							((CharacterRendering)(object)instance4).Character_OnHangtime_AfterAlternateRoute();
						}
					}
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CResetCharacterTeleportFX_003Ed__13(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

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

	private Animation _animation;

	private string _leftAnimationName;

	private string _rightAnimationName;

	private Transform _endPoof;

	private Vector3 _offset;

	private float _reappearDelay;

	private bool _overrideEnd = true;

	private Vector3 pos;

	private bool _correctEndYPos;

	public override void StartTeleBoardEffect()
	{
		CancelInvoke();
	}

	private unsafe void Update()
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_0062: Expected I, but got Obj
		//IL_0302: Expected I4, but got Obj
		//IL_00ce: Expected I4, but got Obj
		//IL_00f2: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I4
		//IL_0356: Expected I, but got Obj
		//IL_036c: Expected Obj, but got I
		//IL_0133: Expected I, but got Obj
		//IL_0180: Expected I, but got Obj
		_overrideEnd = false;
		string text = tag;
		((GameObject)(object)text).tag = null;
		string text2 = tag;
		((GameObject)(object)text2).tag = (string)1;
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v63 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		object obj2 = instance + 248;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v11+8]");
		_ = 0;
		object obj4 = obj3 + 12;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 48;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v21+8]");
		_ = 0;
		CharacterRendering instance2 = CharacterRendering.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v27 (SYBO.Subway.Characters.CharacterRendering)+1BC]");
		string text3 = (((nint)0 >= (nint)0) ? _rightAnimationName : _leftAnimationName);
		Animation.INTERNAL_CALL_Stop(_animation);
		AnimationState animationState = _animation.CrossFadeQueued(text3);
		bool flag = _animation.Play((PlayMode)text3);
		bool flag2 = _animation.Play((PlayMode)text3);
		float distance = (flag2 ? ((RaycastHit*)1) : ((RaycastHit*)null))->distance;
		nint num3 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S2_v9 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v17 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		float num5 = 20f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S3_v4 (System.Boolean)+44]");
		float num6 = num5 / 0f;
		float height = distance / num6;
		((CharacterController)flag).height = height;
		nint num7 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v40 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v55 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance3 = CharacterRendering.Instance;
		string text4 = ((Component)(object)instance3._cachedModelMaterial).tag;
		((GameObject)(object)text4).tag = null;
		_correctEndYPos = true;
		List<Material> coroutine = ((ColorTeleboardEffect)this).CollectMaterials();
		CoroutineUtil.StopCoroutine((Coroutine)(object)coroutine);
		List<Material> list = ((ColorTeleboardEffect)this).CollectMaterials();
		Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private unsafe void LateUpdate()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00b8: Expected I, but got Obj
		//IL_00ce: Expected Obj, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0247: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected VT, but got Unknown
		//IL_0106: Expected F4, but got Obj
		//IL_0101: Expected native int or pointer, but got VT
		//IL_011b: Expected F4, but got I
		//IL_0116: Expected native int or pointer, but got VT
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected VT, but got Unknown
		//IL_0136: Expected F4, but got Obj
		//IL_0131: Expected native int or pointer, but got VT
		//IL_014b: Expected F4, but got I
		//IL_0146: Expected native int or pointer, but got VT
		//IL_0169: Expected F4, but got Obj
		//IL_0164: Expected native int or pointer, but got VT
		//IL_017e: Expected F4, but got I
		//IL_0179: Expected native int or pointer, but got VT
		//IL_0187: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj = this + 48;
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v40 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 36;
		CharacterRendering instance = CharacterRendering.Instance;
		object obj5 = instance + 248;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v5+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10+8]");
		_ = 0;
		GameObject gameObject = base.gameObject;
		object obj6 = obj4 + 24;
		object obj7 = this + 48;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S2_v11+8]");
		_ = 0;
		object obj8 = obj4 + 12;
		object obj9 = this + 28;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S2_v17+8]");
		_ = 0;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v22 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v36 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj4 + 48);
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v16+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = (Vector3)(obj4 + 60);
		((Vector3*)(nint)vector2)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v19+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector3 = vector - vector2;
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 localPosition = ((Transform)vector2).localPosition;
	}

	public override void ResetTeleboardEffect()
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0144: Expected Obj, but got I4
		//IL_0014: Expected VT, but got Obj
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_018b: Expected VT, but got Obj
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 36);
		Transform transform3 = (Transform)(transform2 + 12);
		object obj = transform2 + 24;
		obj = 0;
		_ = 0;
		if (~(_correctEndYPos ? 1u : 0u) != 0)
		{
			return;
		}
		transform3.position = (Vector3)_endPoof;
		obj = transform3;
		_ = ((UnityEngine.Object)transform3).m_CachedPtr;
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v23 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v31 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		GameObject gameObject = ((Component)(object)instance._cachedModelMaterial).gameObject;
		transform2.position = (Vector3)gameObject;
		object obj3 = this + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S2_v6+4]");
		object obj4 = num3 + 0;
		transform = (Transform)obj;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform.localPosition;
	}

	private IEnumerator ResetCharacterTeleportFX()
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BatTeleboardEffect)+E8]");
		return (IEnumerator)0;
	}
}
