namespace UnityEngine.Networking;

public class ConnectionSimulatorConfig : IDisposable
{
	internal int m_OutMinDelay; //Field offset: 0x8
	internal int m_OutAvgDelay; //Field offset: 0xC
	internal int m_InMinDelay; //Field offset: 0x10
	internal int m_InAvgDelay; //Field offset: 0x14
	internal float m_PacketLossPercentage; //Field offset: 0x18

	public ConnectionSimulatorConfig(int outMinDelay, int outAvgDelay, int inMinDelay, int inAvgDelay, float packetLossPercentage) { }

	public void Dispose() { }

	protected override void Finalize() { }

}

