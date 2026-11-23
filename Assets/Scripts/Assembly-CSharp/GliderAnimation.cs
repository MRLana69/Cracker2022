using System;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

public class GliderAnimation : MonoBehaviour
{
	private Animation _animation;

	private AnimationClip _clipClose;

	private AnimationClip _clipOpen;

	private AnimationState _stateClose;

	private AnimationState _stateOpen;

	private Character _character;

	private HoverboardModelPreviewFactory _factory;

	private bool _open;

	private void Awake()
	{
		Character instance = Character.Instance;
		_character = instance;
		Animation component = GetComponent<Animation>();
		_animation = component;
		Animation component2 = GetComponent<Animation>();
		string text = _clipClose.name;
		AnimationState stateClose = component2.get_Item(text);
		_stateClose = stateClose;
		_stateClose.weight = 1f;
		_stateClose.time = 1f;
		_stateClose.speed = 0f;
		_stateClose.enabled = true;
		Animation component3 = GetComponent<Animation>();
		string text2 = _clipOpen.name;
		AnimationState stateOpen = component3.get_Item(text2);
		_stateOpen = stateOpen;
	}

	private void HandleOnSwitchToHoverboard(HoverboardBundle hoverbooardBundle, Hoverboard.BoardAbility[] abilities)
	{
		Character character = _character;
		Variable<bool> isGrounded = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v9 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 == 0)
		{
			HandleOnHangtime();
		}
	}

	public unsafe void AddEvents()
	{
		Character.OnHangtimeDelegate onHangtimeDelegate = default;
		onHangtimeDelegate._002Ector(this, (nint)__ldftn(GliderAnimation.HandleOnHangtime));
		_character.OnHangtime += onHangtimeDelegate;
		throw new ArgumentException();
	}

	public unsafe void AddEvents(HoverboardModelPreviewFactory factory)
	{
		_factory = factory;
		HoverboardModelPreviewFactory factory2 = _factory;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(GliderAnimation.HandleOnOpenMenu));
		Delegate obj = Delegate.Combine(factory2.OnOpenGlider, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onOpenGlider = default;
		factory2.OnOpenGlider = onOpenGlider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		HoverboardModelPreviewFactory factory3 = _factory;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(GliderAnimation.HandleOnCloseMenu));
		Delegate obj2 = Delegate.Combine(factory3.OnCloseGlider, action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onCloseGlider = default;
		factory3.OnCloseGlider = onCloseGlider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private unsafe void OnDestroy()
	{
		Character.OnHangtimeDelegate onHangtimeDelegate = default;
		onHangtimeDelegate._002Ector(this, (nint)__ldftn(GliderAnimation.HandleOnHangtime));
		_character.OnHangtime -= onHangtimeDelegate;
		throw new ArgumentException();
	}

	private void HandleOnLanding(Character character)
	{
		HandleOnClose();
	}

	private void HandleOnClose()
	{
		if (~(_open ? 1u : 0u) == 0)
		{
			_stateClose.speed = 1f;
			if (_animation != null)
			{
				string animation = _clipClose.name;
				bool flag = _animation.Play(animation);
			}
			_open = false;
		}
	}

	private void HandleOnHangtime()
	{
		if (_open)
		{
			return;
		}
		Character character = _character;
		Variable<bool> isGrounded = character.IsGrounded;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 == 0)
		{
			_open = true;
			if (_animation != null)
			{
				string animation = _clipOpen.name;
				bool flag = _animation.Play(animation);
			}
		}
	}

	private void HandleOnCloseMenu()
	{
		_stateClose.speed = 1f;
		_stateClose.normalizedTime = 0f;
		_stateClose.weight = 1f;
		if (_animation != null)
		{
			string animation = _clipClose.name;
			bool flag = _animation.Play(animation);
		}
		_open = false;
	}

	private unsafe void HandleOnOpenMenu()
	{
		if (_animation == null)
		{
			if (_factory != null)
			{
				HoverboardModelPreviewFactory factory = _factory;
				Action action = default;
				action._002Ector(this, (nint)__ldftn(GliderAnimation.HandleOnOpenMenu));
				Delegate obj = Delegate.Remove(factory.OnOpenGlider, action);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				Action onOpenGlider = default;
				factory.OnOpenGlider = onOpenGlider;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				HoverboardModelPreviewFactory factory2 = _factory;
				Action action2 = default;
				action2._002Ector(this, (nint)__ldftn(GliderAnimation.HandleOnCloseMenu));
				Delegate obj2 = Delegate.Remove(factory2.OnCloseGlider, action2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				Action onCloseGlider = default;
				factory2.OnCloseGlider = onCloseGlider;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			}
		}
		else
		{
			_stateOpen.normalizedTime = 0f;
			_stateClose.weight = 0f;
			_stateClose.normalizedTime = 0f;
			if (_animation != null)
			{
				string animation = _clipOpen.name;
				bool flag = _animation.Play(animation);
			}
		}
	}

	public unsafe void RemoveEventHandling()
	{
		Character.OnHangtimeDelegate onHangtimeDelegate = default;
		onHangtimeDelegate._002Ector(this, (nint)__ldftn(GliderAnimation.HandleOnHangtime));
		_character.OnHangtime -= onHangtimeDelegate;
		throw new ArgumentException();
	}
}
