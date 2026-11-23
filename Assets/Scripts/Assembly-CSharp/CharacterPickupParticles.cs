using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Characters.States;
using UnityEngine;

public class CharacterPickupParticles : MonoBehaviour
{
	[Serializable]
	private class EffectDetails
	{
		public Transform target;

		public float duration = 0.05f;

		public AnimationCurve scaleCurve;

		private Renderer _renderer;

		private Material _materialInstance;

		public Renderer Renderer
		{
			get
			{
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_006a: Expected Obj, but got Unknown
				object result = this + 20;
				if (_renderer == null)
				{
					if (target != null)
					{
						Renderer component = target.GetComponent<Renderer>();
						_renderer = component;
					}
					else
					{
						object[] array = Array.Empty<object>();
					}
				}
				return (Renderer)result;
			}
		}

		public Material MaterialInstance
		{
			get
			{
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Expected Obj, but got Unknown
				object result = this + 24;
				if (_materialInstance == null)
				{
					if (target != null)
					{
						Renderer renderer = Renderer;
						Material material = renderer.material;
						_materialInstance = material;
					}
					else
					{
						object[] array = Array.Empty<object>();
					}
				}
				return (Material)result;
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public EffectDetails details;

		public Material material;

		internal unsafe void _003CEffectCoroutine_003Eb__0(float t)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected VT, but got Unknown
			//IL_0167: Expected I, but got Obj
			//IL_01d8: Expected F4, but got I
			//IL_01d3: Expected native int or pointer, but got VT
			//IL_020e: Expected F4, but got I
			//IL_0209: Expected native int or pointer, but got VT
			object obj = default;
			Vector3 vector = (Vector3)(obj + -64);
			Renderer renderer = details.Renderer;
			renderer.enabled = true;
			float num = Math.Min(t, 1f);
			bool flag = t < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			float num3 = -0f - num2;
			float num4 = num3 + 1f;
			float num5 = -0f - num2;
			float num6 = num5 + 1f;
			float num7 = num2 * 0f;
			float num8 = num7 + 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			float num9 = -0f - num2;
			float num10 = num9 + 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Color value = (Color)(vector + 16);
			material.SetColor("_MainColor", value);
			EffectDetails effectDetails = details;
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num12 = 0;
			EffectDetails effectDetails2 = details;
			float num13 = effectDetails2.scaleCurve.Evaluate(t);
			float num14 = (float)Vector3.oneVector * num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v31 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			float num15 = 0f * num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v31 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
			float num16 = 0f * num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			effectDetails.target.localScale = vector;
		}
	}

	private sealed class _003CEffectCoroutine_003Ed__19(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EffectDetails details;

		public CharacterPickupParticles _003C_003E4__this;

		private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass19_0 obj = _003C_003E8__1;
					Renderer renderer = obj.details.Renderer;
					renderer.enabled = false;
				}
				return false;
			}
			_003C_003E1__state = -1;
			_003C_003Ec__DisplayClass19_0 obj2 = default;
			_003C_003E8__1 = obj2;
			_003C_003Ec__DisplayClass19_0 obj3 = _003C_003E8__1;
			obj3.details = details;
			_003C_003Ec__DisplayClass19_0 obj4 = _003C_003E8__1;
			EffectDetails effectDetails = obj4.details;
			float zAngle = UnityEngine.Random.Range(0f, 360f);
			effectDetails.target.Rotate(0f, 0f, zAngle);
			_003C_003Ec__DisplayClass19_0 obj5 = _003C_003E8__1;
			Material materialInstance = obj5.details.MaterialInstance;
			obj5.material = materialInstance;
			_003C_003Ec__DisplayClass19_0 obj6 = _003C_003E8__1;
			EffectDetails effectDetails2 = obj6.details;
			throw new ArgumentException();
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

	public static Vector3 coinEfxOffset;

	public GameObject CoinEFX;

	public GameObject PowerUpEFX;

	public Transform master;

	public AudioClipInfo CoinPickup;

	public AudioClipInfo PowerUpPickup;

	public float CoinDistanceForStairway;

	private int coinStairway;

	private int flyWay;

	private int[] pentatonicScale;

	private JetpackState jetpack;

	public AnimationCurve compressCurve;

	private EffectDetails coinEffect;

	private EffectDetails powerupEffect;

	private unsafe void Start()
	{
		JetpackState instance = JetpackState.Instance;
		jetpack = instance;
		JetpackState jetpackState = jetpack;
		JetpackState.OnStopDelegate onStopDelegate = default;
		onStopDelegate._002Ector(this, (nint)__ldftn(CharacterPickupParticles.OnJetpackStop));
		Delegate obj = Delegate.Combine(jetpackState.OnStop, onStopDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		JetpackState.OnStopDelegate onStop = default;
		jetpackState.OnStop = onStop;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	private void OnJetpackStop(bool isHeadstart)
	{
		flyWay = 0;
	}

	private unsafe void OnDestroy()
	{
		if (jetpack != null)
		{
			JetpackState jetpackState = jetpack;
			JetpackState.OnStopDelegate onStopDelegate = default;
			onStopDelegate._002Ector(this, (nint)__ldftn(CharacterPickupParticles.OnJetpackStop));
			Delegate obj = Delegate.Remove(jetpackState.OnStop, onStopDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			JetpackState.OnStopDelegate onStop = default;
			jetpackState.OnStop = onStop;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		}
	}

	public void PickedUpCoin(Transform trans)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0466: Invalid comparison between I and F4
		//IL_00f1: Invalid comparison between I and F4
		//IL_03d4: Expected Obj, but got I4
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected Obj, but got Unknown
		//IL_0123: Invalid comparison between I and F4
		//IL_0192: Invalid comparison between I and F4
		//IL_0201: Invalid comparison between I and F4
		//IL_0160: Invalid comparison between I and F4
		//IL_0270: Invalid comparison between I and F4
		//IL_01cf: Invalid comparison between I and F4
		//IL_02e6: Expected Obj, but got I4
		//IL_023e: Invalid comparison between I and F4
		//IL_04f3: Expected Obj, but got I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_058e: Expected Obj, but got I4
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_02ad: Invalid comparison between I and F4
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 position = trans.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		if (0f > 80f)
		{
			coinStairway = 0;
			AudioClipInfo coinPickup = CoinPickup;
			float time = (float)flyWay / 48f;
			float num = compressCurve.Evaluate(time);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @874");
			float maxPitch = default;
			coinPickup.maxPitch = maxPitch;
			AudioClipInfo coinPickup2 = CoinPickup;
			float time2 = (float)flyWay / 48f;
			float num2 = compressCurve.Evaluate(time2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @874");
			float minPitch = default;
			coinPickup2.minPitch = minPitch;
			int num3 = flyWay + 1;
			flyWay = num3;
		}
		else
		{
			Vector3 position2 = trans.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			if (0f < 0.1f)
			{
				goto IL_0340;
			}
			Vector3 position3 = trans.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			if (0f > 8.795f)
			{
				Vector3 position4 = trans.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if (0f < 8.805f)
				{
					goto IL_0340;
				}
			}
			Vector3 position5 = trans.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			if (0f > 9.95f)
			{
				Vector3 position6 = trans.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if (0f < 10.05f)
				{
					goto IL_0340;
				}
			}
			Vector3 position7 = trans.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			if (0f > 28.95f)
			{
				Vector3 position8 = trans.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if (0f < 29.05f)
				{
					goto IL_0340;
				}
			}
			Vector3 position9 = trans.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			if (0f > 34.95f)
			{
				Vector3 position10 = trans.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if (0f < 35.05f)
				{
					goto IL_0340;
				}
			}
			flyWay = 0;
			int[] array = pentatonicScale;
			object obj3 = array.Length - 1;
			bool flag = coinStairway < (nint)obj3;
			bool flag2 = !flag;
			int num4 = coinStairway;
			if (!flag2)
			{
				num4 = ++coinStairway;
			}
			AudioClipInfo coinPickup3 = CoinPickup;
			int[] array2 = pentatonicScale;
			int num5 = num4 / array2.Length;
			object obj4 = num5 * array2.Length;
			object obj5 = num4 - obj4;
			object obj6 = obj5 << 2;
			object obj7 = (object)array2 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v50+10]");
			float num6 = 0f / 12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @874");
			object obj8 = default;
			float maxPitch2 = (float)obj8 * 0.5f;
			coinPickup3.maxPitch = maxPitch2;
			AudioClipInfo coinPickup4 = CoinPickup;
			int[] array3 = pentatonicScale;
			int num7 = coinStairway / array3.Length;
			object obj9 = num7 * array3.Length;
			object obj10 = coinStairway - obj9;
			object obj11 = obj10 << 2;
			object obj12 = (object)array3 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v58+10]");
			float num8 = 0f / 12f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @874");
			object obj13 = default;
			float minPitch2 = (float)obj13 * 0.5f;
			coinPickup4.minPitch = minPitch2;
		}
		goto IL_0485;
		IL_0340:
		coinStairway = 0;
		AudioClipInfo coinPickup5 = CoinPickup;
		int[] array4 = pentatonicScale;
		float num9 = (float)array4[0] / 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @874");
		object obj14 = default;
		float maxPitch3 = (float)obj14 * 0.5f;
		coinPickup5.maxPitch = maxPitch3;
		AudioClipInfo coinPickup6 = CoinPickup;
		int[] array5 = pentatonicScale;
		int num10 = coinStairway / array5.Length;
		object obj15 = num10 * array5.Length;
		object obj16 = coinStairway - obj15;
		object obj17 = obj16 << 2;
		object obj18 = (object)array5 + obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v24+10]");
		float num11 = 0f / 12f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @874");
		object obj19 = default;
		float minPitch3 = (float)obj19 * 0.5f;
		coinPickup6.minPitch = minPitch3;
		goto IL_0485;
		IL_0485:
		Sound sound = So.Instance.playSound(CoinPickup);
		IEnumerator routine = EffectCoroutine(coinEffect);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator EffectCoroutine(EffectDetails details)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void PickedUpPowerUp()
	{
		Sound sound = So.Instance.playSound(PowerUpPickup);
		PickedUpDefaultPowerUp();
	}

	public void PickedUpDefaultPowerUp()
	{
		IEnumerator routine = EffectCoroutine(powerupEffect);
		Coroutine coroutine = StartCoroutine(routine);
	}

	public CharacterPickupParticles()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array array = default;
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003CPrivateImplementationDetails_003E.FB1BF14FF9D4E0C2E61779E6DCD4A65DAED6EA62BF72F0DA2708BD3523EC3D9D));
		pentatonicScale = (int[])array;
		base._002Ector();
	}

	static CharacterPickupParticles()
	{
		//IL_0018: Expected I, but got Obj
		//IL_005f: Expected I, but got Obj
		//IL_009a: Expected VT, but got F4
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.forwardVector * 1.2f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
		float num4 = 0f * 1.2f;
		nint num5 = (nint)typeof(CharacterPickupParticles);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v20 (Il2CppClass<CharacterPickupParticles>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		float num7 = 0f * 1.2f;
		coinEfxOffset = (Vector3)num3;
	}
}
