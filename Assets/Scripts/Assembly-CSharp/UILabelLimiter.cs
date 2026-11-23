using UnityEngine;

public class UILabelLimiter : MonoBehaviour
{
	private UILabel _label;

	private void Awake()
	{
		do
		{
			UILabel component = GetComponent<UILabel>();
			_label = component;
		}
		while (_label == null);
	}

	private void Start()
	{
		string processedText = _label.processedText;
		UILabel label = _label;
		if (processedText.CompareTo(label.mText) != 0 && processedText._stringLength >= 4)
		{
			int length = processedText._stringLength - 3;
			string text = processedText.Substring(0, length);
			string text2 = text + "...";
			_label.text = text2;
		}
	}
}
