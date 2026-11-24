using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Coins;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteTransitionTrigger : MonoBehaviour, IRouteTransitionTrigger
{
	private CharacterCollisionTrigger _characterTrigger;

	public Route TargetRoute
	{
		get
		{
			return (Route)(object)_characterTrigger;
		}
		set
		{
			//IL_001a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteTransitionTrigger)+74]");
			bool flag = ((List<RouteChunk>)0).Remove((RouteChunk)(object)value);
		}
	}

	private void Awake()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 12;
		object obj2 = default;
		obj = obj2;
		CancelInvoke();
	}

	private void CharacterTrigger_OnCharacterEnter(object sender, EventArgs args)
	{
		//IL_01cb: Expected Obj, but got I
		//IL_01cb: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_004b: Expected Obj, but got I
		//IL_0061: Expected Obj, but got I
		//IL_01f6: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0255: Expected VT, but got Obj
		//IL_0255: Expected Obj, but got I4
		//IL_00c6: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I
		//IL_0146: Expected VT, but got Obj
		//IL_015a: Expected F4, but got I
		//IL_0185: Invalid comparison between I and F4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteTransitionTrigger)+7C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
		if (((List<PickupSpawnPoint>)num).Contains((PickupSpawnPoint)0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteTransitionTrigger)+7C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
			bool flag = ((List<PickupSpawnPoint>)num2).Remove((PickupSpawnPoint)0);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v13+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14+8]");
		object obj3 = -8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v14+8]");
		Transform transform = default;
		if ((nint)0 != 8)
		{
			if ((nint)obj3 == 2040)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
				GameObject gameObject = ((Component)0).gameObject;
				transform.position = (Vector3)gameObject;
				float num3 = ((CoinCurve)this).JumpLength((float)(nint)((UnityEngine.Object)transform).m_CachedPtr);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteTransitionTrigger)+68]");
				float num4 = 0f + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Routes.RouteTransitionTrigger)+70]");
				if (!(0f < num4))
				{
				}
			}
			return;
		}
		nint num5 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v20 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v26 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [args @ L2 (System.Object)+8]");
		GameObject gameObject2 = ((Component)0).gameObject;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject2);
		float num7 = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr + 3240f;
	}

	public unsafe RouteTransitionTrigger()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		object obj = this + 12;
		CharacterCollisionTrigger component = GetComponent<CharacterCollisionTrigger>();
		obj = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventHandler eventHandler = default;
		((Delegate)eventHandler).method_ptr = method_ptr;
		((Delegate)eventHandler).method = (nint)__ldftn(RouteTransitionTrigger.CharacterTrigger_OnCharacterEnter);
		object obj2 = eventHandler + 16;
		obj2 = this;
		_characterTrigger.OnCharacterEnter -= eventHandler;
	}
}
