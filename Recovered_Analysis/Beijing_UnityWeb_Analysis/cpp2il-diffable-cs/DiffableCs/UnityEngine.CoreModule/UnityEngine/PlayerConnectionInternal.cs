namespace UnityEngine;

internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
{

	public PlayerConnectionInternal() { }

	private static void DisconnectAll() { }

	private static void Initialize() { }

	private static bool IsConnected() { }

	private static void PollInternal() { }

	private static void RegisterInternal(string messageId) { }

	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	private static void UnregisterInternal(string messageId) { }

}

