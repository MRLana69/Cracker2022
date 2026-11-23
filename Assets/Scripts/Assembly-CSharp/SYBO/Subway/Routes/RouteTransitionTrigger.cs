using System;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Level;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteTransitionTrigger : MonoBehaviour, IRouteTransitionTrigger
{
	private CharacterCollisionTrigger _characterTrigger;

	private Route TargetRoute__BackingField;

	public Route TargetRoute
	{
		get
		{
			return TargetRoute__BackingField;
		}
		set
		{
			TargetRoute__BackingField = value;
		}
	}

	private unsafe void Awake()
	{
		CharacterCollisionTrigger component = GetComponent<CharacterCollisionTrigger>();
		_characterTrigger = component;
		EventHandler eventHandler = default;
		eventHandler._002Ector(this, (nint)__ldftn(RouteTransitionTrigger.CharacterTrigger_OnCharacterEnter));
		_characterTrigger.OnCharacterEnter += eventHandler;
	}

	private void CharacterTrigger_OnCharacterEnter(object sender, EventArgs args)
	{
		//IL_000e: Expected VT, but got Obj
		//IL_001d: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		((RouteManager)val).StartRouteTransition(TargetRoute__BackingField);
	}
}
