namespace UnityEngine.Playables;

public abstract class PlayableAsset : ScriptableObject
{

	public virtual double duration
	{
		 get { } //Length: 16
	}

	public virtual IEnumerable<PlayableBinding> outputs
	{
		 get { } //Length: 6
	}

	protected PlayableAsset() { }

	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	public virtual double get_duration() { }

	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, nint ptr) { }

	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, nint ptrToDouble) { }

}

