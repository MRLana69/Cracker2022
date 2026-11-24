namespace UnityEngine.Networking;

public class NetworkAnimator : NetworkBehaviour
{
	private static AnimationMessage s_AnimationMessage; //Field offset: 0x0
	private static AnimationParametersMessage s_AnimationParametersMessage; //Field offset: 0x4
	private static AnimationTriggerMessage s_AnimationTriggerMessage; //Field offset: 0x8
	private Animator m_Animator; //Field offset: 0x1C
	private uint m_ParameterSendBits; //Field offset: 0x20
	private int m_AnimationHash; //Field offset: 0x24
	private int m_TransitionHash; //Field offset: 0x28
	private NetworkWriter m_ParameterWriter; //Field offset: 0x2C
	private float m_SendTimer; //Field offset: 0x30
	public string param0; //Field offset: 0x34
	public string param1; //Field offset: 0x38
	public string param2; //Field offset: 0x3C
	public string param3; //Field offset: 0x40
	public string param4; //Field offset: 0x44
	public string param5; //Field offset: 0x48

	public Animator animator
	{
		 get { } //Length: 6
		 set { } //Length: 2
	}

	private bool sendMessagesAllowed
	{
		 get { } //Length: 6
	}

	private static NetworkAnimator() { }

	public NetworkAnimator() { }

	private bool CheckAnimStateChanged(out int stateHash, out float normalizedTime) { }

	private void CheckSendRate() { }

	private void FixedUpdate() { }

	public Animator get_animator() { }

	private bool get_sendMessagesAllowed() { }

	public bool GetParameterAutoSend(int index) { }

	internal void HandleAnimMsg(AnimationMessage msg, NetworkReader reader) { }

	internal void HandleAnimParamsMsg(AnimationParametersMessage msg, NetworkReader reader) { }

	internal void HandleAnimTriggerMsg(int hash) { }

	internal static void OnAnimationClientMessage(NetworkMessage netMsg) { }

	internal static void OnAnimationParametersClientMessage(NetworkMessage netMsg) { }

	internal static void OnAnimationParametersServerMessage(NetworkMessage netMsg) { }

	internal static void OnAnimationServerMessage(NetworkMessage netMsg) { }

	internal static void OnAnimationTriggerClientMessage(NetworkMessage netMsg) { }

	internal static void OnAnimationTriggerServerMessage(NetworkMessage netMsg) { }

	public override void OnDeserialize(NetworkReader reader, bool initialState) { }

	public override bool OnSerialize(NetworkWriter writer, bool forceAll) { }

	private void ReadParameters(NetworkReader reader, bool autoSend) { }

	internal void ResetParameterOptions() { }

	private void SendMessage(short type, MessageBase msg) { }

	public void set_animator(Animator value) { }

	public void SetParameterAutoSend(int index, bool value) { }

	private void SetRecvTrackingParam(string p, int i) { }

	private void SetSendTrackingParam(string p, int i) { }

	public void SetTrigger(int hash) { }

	public void SetTrigger(string triggerName) { }

	private void WriteParameters(NetworkWriter writer, bool autoSend) { }

}

