namespace SYBO.Subway.Level;

public class MovingTrainUpdater : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<MovingTrain> <>9__13_0; //Field offset: 0x4
		public static Func<TrainAudioWrapper, bool> <>9__13_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Update>b__13_0(MovingTrain a, MovingTrain b) { }

		internal bool <Update>b__13_1(TrainAudioWrapper w) { }

	}

	private class TrainAudioWrapper
	{
		private GameObject _passingTrainGameObject; //Field offset: 0x8
		private Transform _passingTrainTransform; //Field offset: 0xC
		private AudioSource _passingTrainAudioSource; //Field offset: 0x10
		private MovingTrain _currentPassingTrain; //Field offset: 0x14
		private float previousVolume; //Field offset: 0x18

		public MovingTrain CurrentPassingTrain
		{
			 get { } //Length: 6
		}

		public TrainAudioWrapper(Transform parent) { }

		public MovingTrain get_CurrentPassingTrain() { }

		public void Mute() { }

		public void Pause(bool pause) { }

		public void ResetPassingTrain() { }

		public void SetAudioClip(AudioClip clip) { }

		public void SetPassingTrain(MovingTrain train) { }

		public void Unmute() { }

		public void UpdatePosition() { }

	}

	private const int MaxNumberOfTrainAudios = 3; //Field offset: 0x0
	private const float MaxPlayingDistance = 300; //Field offset: 0x0
	private List<MovingTrain> _trains; //Field offset: 0xC
	private TrainAudioWrapper[] _audioWrappers; //Field offset: 0x10
	private Dictionary<MovingTrain, TrainAudioWrapper> _trainToAudioWrapperMap; //Field offset: 0x14
	private float _lastCameraPositionZ; //Field offset: 0x18

	public MovingTrainUpdater() { }

	public void AddMovingTrain(MovingTrain train) { }

	private void Awake() { }

	private void Game_OnPauseChange(bool pause) { }

	private void OnSfxSettingChanged() { }

	public void RemoveMovingTrain(MovingTrain train) { }

	public void SetAudioClip(AudioClip clip) { }

	private void Update() { }

	private void UpdateSfxVolumeToSettings() { }

}

