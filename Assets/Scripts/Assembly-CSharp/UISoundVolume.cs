using UnityEngine;

public class UISoundVolume : MonoBehaviour
{
	private unsafe void Awake()
	{
		UISlider component = GetComponent<UISlider>();
		float soundVolume = NGUITools.soundVolume;
		component.value = soundVolume;
		EventDelegate.Callback callback = default;
		callback._002Ector(this, (nint)__ldftn(UISoundVolume.OnChange));
		EventDelegate eventDelegate = EventDelegate.Add(component.onChange, callback);
	}

	private void OnChange()
	{
		float value = UIProgressBar.current.value;
		NGUITools.soundVolume = value;
	}
}
