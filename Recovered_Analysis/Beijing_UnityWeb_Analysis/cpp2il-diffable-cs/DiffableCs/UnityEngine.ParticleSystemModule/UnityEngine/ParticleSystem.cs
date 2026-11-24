namespace UnityEngine;

public sealed class ParticleSystem : Component
{
	public struct EmissionModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public bool enabled
		{
			 set { } //Length: 11
		}

		public MinMaxCurve rateOverTime
		{
			 set { } //Length: 14
		}

		internal EmissionModule(ParticleSystem particleSystem) { }

		public void set_enabled(bool value) { }

		private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value) { }

		public void set_rateOverTime(MinMaxCurve value) { }

		private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value) { }

	}

	public struct EmitParams
	{
		private Particle m_Particle; //Field offset: 0x0
		private bool m_PositionSet; //Field offset: 0x80
		private bool m_VelocitySet; //Field offset: 0x81
		private bool m_AxisOfRotationSet; //Field offset: 0x82
		private bool m_RotationSet; //Field offset: 0x83
		private bool m_AngularVelocitySet; //Field offset: 0x84
		private bool m_StartSizeSet; //Field offset: 0x85
		private bool m_StartColorSet; //Field offset: 0x86
		private bool m_RandomSeedSet; //Field offset: 0x87
		private bool m_StartLifetimeSet; //Field offset: 0x88
		private bool m_MeshIndexSet; //Field offset: 0x89
		private bool m_ApplyShapeToPosition; //Field offset: 0x8A

	}

	public struct MainModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public float duration
		{
			 get { } //Length: 49
		}

		public bool playOnAwake
		{
			 set { } //Length: 89
		}

		public float simulationSpeed
		{
			 set { } //Length: 14
		}

		public MinMaxGradient startColor
		{
			 set { } //Length: 59
		}

		public MinMaxCurve startRotation
		{
			 set { } //Length: 59
		}

		public float startSizeMultiplier
		{
			 set { } //Length: 13
		}

		public MinMaxCurve startSpeed
		{
			 set { } //Length: 11
		}

		internal MainModule(ParticleSystem particleSystem) { }

		public float get_duration() { }

		private static float get_duration_Injected(ref MainModule _unity_self) { }

		public void set_playOnAwake(bool value) { }

		private static void set_playOnAwake_Injected(ref MainModule _unity_self, bool value) { }

		public void set_simulationSpeed(float value) { }

		private static void set_simulationSpeed_Injected(ref MainModule _unity_self, float value) { }

		public void set_startColor(MinMaxGradient value) { }

		private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value) { }

		public void set_startRotation(MinMaxCurve value) { }

		private static void set_startRotation_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

		public void set_startSizeMultiplier(float value) { }

		private static void set_startSizeMultiplier_Injected(ref MainModule _unity_self, float value) { }

		public void set_startSpeed(MinMaxCurve value) { }

		private static void set_startSpeed_Injected(ref MainModule _unity_self, ref MinMaxCurve value) { }

	}

	public struct MinMaxCurve
	{
		private ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		private float m_CurveMultiplier; //Field offset: 0x4
		private AnimationCurve m_CurveMin; //Field offset: 0x8
		private AnimationCurve m_CurveMax; //Field offset: 0xC
		private float m_ConstantMin; //Field offset: 0x10
		private float m_ConstantMax; //Field offset: 0x14

		public MinMaxCurve(float constant) { }

		public MinMaxCurve(float min, float max) { }

		public static MinMaxCurve op_Implicit(float constant) { }

	}

	public struct MinMaxGradient
	{
		private ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		private Gradient m_GradientMin; //Field offset: 0x4
		private Gradient m_GradientMax; //Field offset: 0x8
		private Color m_ColorMin; //Field offset: 0xC
		private Color m_ColorMax; //Field offset: 0x1C

		public MinMaxGradient(Color min, Color max) { }

	}

	public struct Particle
	{
		private Vector3 m_Position; //Field offset: 0x0
		private Vector3 m_Velocity; //Field offset: 0xC
		private Vector3 m_AnimatedVelocity; //Field offset: 0x18
		private Vector3 m_InitialVelocity; //Field offset: 0x24
		private Vector3 m_AxisOfRotation; //Field offset: 0x30
		private Vector3 m_Rotation; //Field offset: 0x3C
		private Vector3 m_AngularVelocity; //Field offset: 0x48
		private Vector3 m_StartSize; //Field offset: 0x54
		private Color32 m_StartColor; //Field offset: 0x60
		private uint m_RandomSeed; //Field offset: 0x64
		private float m_Lifetime; //Field offset: 0x68
		private float m_StartLifetime; //Field offset: 0x6C
		private int m_MeshIndex; //Field offset: 0x70
		private float m_EmitAccumulator0; //Field offset: 0x74
		private float m_EmitAccumulator1; //Field offset: 0x78
		private uint m_Flags; //Field offset: 0x7C

		public Vector3 angularVelocity3D
		{
			 set { } //Length: 49
		}

		public float lifetime
		{
			 set { } //Length: 52
		}

		public Vector3 position
		{
			 set { } //Length: 53
		}

		public uint randomSeed
		{
			 set { } //Length: 54
		}

		public float remainingLifetime
		{
			 set { } //Length: 11
		}

		public Vector3 rotation3D
		{
			 set { } //Length: 11
		}

		public Color32 startColor
		{
			 set { } //Length: 49
		}

		public float startLifetime
		{
			 set { } //Length: 11
		}

		public float startSize
		{
			 set { } //Length: 11
		}

		public Vector3 velocity
		{
			 set { } //Length: 49
		}

		public void set_angularVelocity3D(Vector3 value) { }

		public void set_lifetime(float value) { }

		public void set_position(Vector3 value) { }

		public void set_randomSeed(uint value) { }

		public void set_remainingLifetime(float value) { }

		public void set_rotation3D(Vector3 value) { }

		public void set_startColor(Color32 value) { }

		public void set_startLifetime(float value) { }

		public void set_startSize(float value) { }

		public void set_velocity(Vector3 value) { }

	}


	public EmissionModule emission
	{
		 get { } //Length: 35
	}

	public MainModule main
	{
		 get { } //Length: 49
	}

	public void Clear() { }

	public void Clear(bool withChildren) { }

	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	public void Emit(Particle particle) { }

	public void Emit(EmitParams emitParams, int count) { }

	public void Emit(int count) { }

	private void Emit_Injected(ref EmitParams emitParams, int count) { }

	private void Emit_Internal(int count) { }

	private void EmitOld_Internal(ref Particle particle) { }

	public EmissionModule get_emission() { }

	public MainModule get_main() { }

	public void Play() { }

	public void Play(bool withChildren) { }

	public void Simulate(float t) { }

	public void Simulate(float t, bool withChildren) { }

	public void Simulate(float t, bool withChildren, bool restart) { }

	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	public void Stop() { }

	public void Stop(bool withChildren) { }

}

