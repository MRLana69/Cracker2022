using System;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__3_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameStats._003C_003Ec obj = default;
			GameStats._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			_ = 1;
			_ = 1;
			_ = 1;
		}

		internal void _003CAwake_003Eb__3_0()
		{
		}
	}

	private float _tunnelLength;

	private Game _game;

	public AudioStateLoop audioStateLoop;

	private void Awake()
	{
		CancelInvoke();
	}

	private void OnTriggerEnter(Collider collider)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Tunnel)+24]");
		bool flag = (nint)0 != 0;
		object obj = flag ^ collider;
		if (obj == null)
		{
			return;
		}
		object obj2 = collider & 1;
		if ((object)audioStateLoop != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Tunnel)+24]");
			if ((nint)0 != 0)
			{
				((TrackObject)this).DeactivateChildren();
			}
		}
	}

	public unsafe Tunnel()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0233: Expected I, but got Obj
		//IL_0249: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0273: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01f1: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<Tunnel+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v38 (Il2CppClass<Tunnel+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__3_0 == null;
		bool flag2 = !flag;
		Action value = _003C_003Ec._003C_003E9__3_0;
		if (!flag2)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v15 (Il2CppClass<Tunnel+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v32 (Il2CppClass<Tunnel+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__3_0);
			object obj4 = action + 16;
			obj4 = _003C_003Ec._003C_003E9;
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v29 (Il2CppClass<Tunnel+<>c>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			obj5 = action;
			value = action;
		}
		((Game)isInstantiated).OnStageMenuSequence -= value;
	}
}
