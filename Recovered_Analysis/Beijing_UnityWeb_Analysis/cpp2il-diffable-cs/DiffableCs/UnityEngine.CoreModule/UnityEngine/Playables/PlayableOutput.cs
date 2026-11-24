namespace UnityEngine.Playables;

public struct PlayableOutput : IEquatable<PlayableOutput>
{
	private static readonly PlayableOutput m_NullPlayableOutput; //Field offset: 0x0
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	private static PlayableOutput() { }

	internal PlayableOutput(PlayableOutputHandle handle) { }

	public bool Equals(PlayableOutput other) { }

	public PlayableOutputHandle GetHandle() { }

}

