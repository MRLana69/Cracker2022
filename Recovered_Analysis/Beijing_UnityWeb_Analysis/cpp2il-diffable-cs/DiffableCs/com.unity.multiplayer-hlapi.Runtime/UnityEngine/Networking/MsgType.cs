namespace UnityEngine.Networking;

public class MsgType
{
	public const short ObjectDestroy = 1; //Field offset: 0x0
	public const short InternalHighest = 31; //Field offset: 0x0
	public const short Connect = 32; //Field offset: 0x0
	public const short Disconnect = 33; //Field offset: 0x0
	public const short Error = 34; //Field offset: 0x0
	public const short Ready = 35; //Field offset: 0x0
	public const short NotReady = 36; //Field offset: 0x0
	public const short AddPlayer = 37; //Field offset: 0x0
	public const short RemovePlayer = 38; //Field offset: 0x0
	public const short Scene = 39; //Field offset: 0x0
	public const short Animation = 40; //Field offset: 0x0
	public const short AnimationParameters = 41; //Field offset: 0x0
	public const short AnimationTrigger = 42; //Field offset: 0x0
	public const short LobbyReadyToBegin = 43; //Field offset: 0x0
	public const short LobbySceneLoaded = 44; //Field offset: 0x0
	public const short LobbyAddPlayerFailed = 45; //Field offset: 0x0
	public const short LobbyReturnToLobby = 46; //Field offset: 0x0
	public const short ReconnectPlayer = 47; //Field offset: 0x0
	internal const short HLAPIPending = 31; //Field offset: 0x0
	internal const short HLAPIResend = 30; //Field offset: 0x0
	internal const short LLAPIMsg = 29; //Field offset: 0x0
	internal const short HLAPIMsg = 28; //Field offset: 0x0
	public const short Rpc = 2; //Field offset: 0x0
	public const short ObjectSpawn = 3; //Field offset: 0x0
	public const short Owner = 4; //Field offset: 0x0
	public const short Command = 5; //Field offset: 0x0
	public const short LocalPlayerTransform = 6; //Field offset: 0x0
	public const short SyncEvent = 7; //Field offset: 0x0
	public const short UpdateVars = 8; //Field offset: 0x0
	public const short SyncList = 9; //Field offset: 0x0
	public const short Highest = 47; //Field offset: 0x0
	public const short ObjectSpawnScene = 10; //Field offset: 0x0
	public const short SpawnFinished = 12; //Field offset: 0x0
	public const short ObjectHide = 13; //Field offset: 0x0
	public const short CRC = 14; //Field offset: 0x0
	public const short LocalClientAuthority = 15; //Field offset: 0x0
	public const short LocalChildTransform = 16; //Field offset: 0x0
	public const short Fragment = 17; //Field offset: 0x0
	public const short PeerClientAuthority = 18; //Field offset: 0x0
	internal const short UserMessage = 0; //Field offset: 0x0
	public const short NetworkInfo = 11; //Field offset: 0x0
	internal static string[] msgLabels; //Field offset: 0x0

	private static MsgType() { }

	public MsgType() { }

	public static string MsgTypeToString(short value) { }

}

