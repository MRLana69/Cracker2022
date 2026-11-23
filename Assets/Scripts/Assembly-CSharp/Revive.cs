using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Rendering;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

public class Revive : MonoBehaviour
{
	public delegate void OnSwitchToRunningDelegate();

	public delegate void OnReviveDelegate();

	private sealed class _003CReviveNow_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Revive _003C_003E4__this;

		private float _003CtimeLeft_003E5__2;

		private float _003CtimeLeftFX_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_008f: Expected VT, but got Obj
			//IL_009d: Expected Obj, but got VT
			//IL_00e1: Expected VT, but got Obj
			//IL_00f1: Expected Obj, but got I
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected Obj, but got Unknown
			Revive revive = _003C_003E4__this;
			float num;
			float num2;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						goto IL_025b;
					}
					_003C_003E1__state = -1;
					num = _003CtimeLeftFX_003E5__3;
					goto IL_039c;
				}
				_003C_003E1__state = -1;
				num2 = _003CtimeLeft_003E5__2;
			}
			else
			{
				_003C_003E1__state = -1;
				GameObject gameObject = revive._reviveParticles.gameObject;
				gameObject.SetActive(value: true);
				revive._reviveParticles.Play();
				_00210 val = (_00210)Singleton<>.Instance;
				((AudioStateLoop)val).PlayReviveSound();
				_003CtimeLeft_003E5__2 = revive.WaitForParticlesDelay;
				num2 = revive.WaitForParticlesDelay;
			}
			if (!(num2 > 0f))
			{
				_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v35 (T)+3C]");
				object obj = 0;
				object obj2 = obj;
				object obj3 = obj + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S1_v21+DC] (should have been resolved before IL gen)");
				Character character = revive.character;
				Game instance = Game.Instance;
				Game.SpeedInfo speed = instance.speed;
				float num3 = instance.__currentSpeed / speed.min;
				float distance = revive.RemoveObstaclesDistance * num3;
				RouteBuilder routeBuilder = default;
				routeBuilder.HideLogic(character.z, distance);
				OnReviveDelegate onRevive = revive.m_OnRevive;
				if (revive.m_OnRevive != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v180.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				revive.game.Revive();
				OnSwitchToRunningDelegate onSwitchToRunning = revive.m_OnSwitchToRunning;
				if (revive.m_OnSwitchToRunning != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v198.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				GameObject gameObject2 = revive._reviveFX.gameObject;
				gameObject2.SetActive(value: true);
				ReviveFX reviveFX = revive._reviveFX;
				bool flag = reviveFX.ReviveAnimation.Play();
				num = (_003CtimeLeftFX_003E5__3 = revive.ReviveAnimationClip.length);
				goto IL_039c;
			}
			float deltaTime = Time.deltaTime;
			float num4 = num2 - deltaTime;
			_003C_003E2__current = null;
			_003CtimeLeft_003E5__2 = num4;
			_003C_003E1__state = 1;
			return true;
			IL_039c:
			if (!(num > 0f))
			{
				GameObject gameObject3 = revive._reviveFX.gameObject;
				gameObject3.SetActive(value: false);
				GameObject gameObject4 = revive._reviveParticles.gameObject;
				gameObject4.SetActive(value: false);
				goto IL_025b;
			}
			float deltaTime2 = Time.deltaTime;
			float num5 = num - deltaTime2;
			_003C_003E2__current = null;
			_003CtimeLeftFX_003E5__3 = num5;
			_003C_003E1__state = 2;
			return true;
			IL_025b:
			return false;
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

	private Game game;

	private Character character;

	public float WaitForParticlesDelay = 0.144f;

	public float RemoveObstaclesDistance;

	private MainCamera _mainCamera;

	private ParticleSystem _reviveParticles;

	private ReviveFX _reviveFX;

	private AnimationClip ReviveAnimationClip;

	private static Revive instance;

	private OnSwitchToRunningDelegate m_OnSwitchToRunning;

	private OnReviveDelegate m_OnRevive;

	public static Revive Instance
	{
		get
		{
			bool flag = (object)instance == null;
			bool flag2 = !flag;
			Revive result = instance;
			if (!flag2)
			{
				result = (instance = Utils.FindObject<Revive>());
			}
			return result;
		}
	}

	public event OnSwitchToRunningDelegate OnSwitchToRunning
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 44;
			Delegate obj2 = this.m_OnSwitchToRunning;
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
			object obj = this + 44;
			Delegate obj2 = this.m_OnSwitchToRunning;
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

	public event OnReviveDelegate OnRevive
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 48;
			Delegate obj2 = this.m_OnRevive;
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
			object obj = this + 48;
			Delegate obj2 = this.m_OnRevive;
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

	private void Start()
	{
		Game game = Game.Instance;
		this.game = game;
		Character character = Character.Instance;
		this.character = character;
		CharacterCamera characterCamera = CharacterCamera.Instance;
		MainCamera mainCamera = characterCamera._mainCamera;
		ParticleSystem component = mainCamera._reviveEffectTransform.GetComponent<ParticleSystem>();
		_reviveParticles = component;
		Renderer component2 = _reviveParticles.GetComponent<Renderer>();
		Material material = component2.material;
		material.renderQueue = RenderQueues.TransparentOverlay;
		Character character2 = Character.Instance;
		_reviveFX = character2._reviveFX;
		GameObject gameObject = _reviveFX.gameObject;
		gameObject.SetActive(value: false);
	}

	public void SendRevive()
	{
		IEnumerator routine = ReviveNow();
		Coroutine coroutine = StartCoroutine(routine);
	}

	public void SendSkipRevive()
	{
		IEnumerator routine = game.SkipRevive();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator ReviveNow()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
