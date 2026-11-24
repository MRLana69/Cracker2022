namespace UnityEngine.Networking;

public class ChannelQOS
{
	internal QosType m_Type; //Field offset: 0x8
	internal bool m_BelongsSharedOrderChannel; //Field offset: 0xC

	public QosType QOS
	{
		 get { } //Length: 6
	}

	public ChannelQOS(QosType value) { }

	public ChannelQOS() { }

	public ChannelQOS(ChannelQOS channel) { }

	public QosType get_QOS() { }

}

