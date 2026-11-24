namespace UnityEngine;

public class WaitForSecondsRealtime : CustomYieldInstruction
{
	private float <waitTime>k__BackingField; //Field offset: 0x8
	private float m_WaitUntilTime; //Field offset: 0xC

	public override bool keepWaiting
	{
		 get { } //Length: 75
	}

	public float waitTime
	{
		 get { } //Length: 49
		 set { } //Length: 18
	}

	public WaitForSecondsRealtime(float time) { }

	public override bool get_keepWaiting() { }

	public float get_waitTime() { }

	public void set_waitTime(float value) { }

}

