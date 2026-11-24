namespace UnityEngine;

public sealed class AnimationEvent
{
	internal float m_Time; //Field offset: 0x8
	internal string m_FunctionName; //Field offset: 0xC
	internal string m_StringParameter; //Field offset: 0x10
	internal Object m_ObjectReferenceParameter; //Field offset: 0x14
	internal float m_FloatParameter; //Field offset: 0x18
	internal int m_IntParameter; //Field offset: 0x1C
	internal int m_MessageOptions; //Field offset: 0x20
	internal AnimationEventSource m_Source; //Field offset: 0x24
	internal AnimationState m_StateSender; //Field offset: 0x28
	internal AnimatorStateInfo m_AnimatorStateInfo; //Field offset: 0x2C
	internal AnimatorClipInfo m_AnimatorClipInfo; //Field offset: 0x50

	public AnimationState animationState
	{
		 get { } //Length: 9
	}

	public string functionName
	{
		 get { } //Length: 12
		 set { } //Length: 8
	}

	public int intParameter
	{
		 set { } //Length: 10
	}

	public bool isFiredByLegacy
	{
		 get { } //Length: 6
	}

	public SendMessageOptions messageOptions
	{
		 set { } //Length: 11
	}

	public float time
	{
		 get { } //Length: 9
		 set { } //Length: 52
	}

	public AnimationEvent() { }

	public AnimationState get_animationState() { }

	public string get_functionName() { }

	public bool get_isFiredByLegacy() { }

	public float get_time() { }

	public void set_functionName(string value) { }

	public void set_intParameter(int value) { }

	public void set_messageOptions(SendMessageOptions value) { }

	public void set_time(float value) { }

}

