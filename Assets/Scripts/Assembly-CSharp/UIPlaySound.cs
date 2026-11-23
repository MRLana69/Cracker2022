using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIPlaySound : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease,
		Custom,
		OnEnable,
		OnDisable
	}

	public AudioClip audioClip;

	public Trigger trigger;

	public float volume = 1f;

	public float pitch;

	private Button btn;

	private void OnEnable()
	{
		if (btn == null)
		{
			Button component = GetComponent<Button>();
			btn = component;
		}
	}

	private unsafe void Start()
	{
		if (btn != null)
		{
			Button button = btn;
			UnityAction unityAction = default;
			unityAction._002Ector(this, (nint)__ldftn(UIPlaySound._003CStart_003Eb__7_0));
			button.m_OnClick.AddListener(unityAction);
		}
	}

	public void Play()
	{
		bool optionSfx = Settings.optionSfx;
		float num = 1f;
		if (!optionSfx)
		{
			num = 0f;
		}
		AudioSource audioSource = NGUITools.PlaySound(audioClip, num, pitch);
	}

	private void _003CStart_003Eb__7_0()
	{
		Play();
	}
}
