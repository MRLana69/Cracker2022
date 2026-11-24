namespace UnityEngine.UI;

public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
{
	private sealed class <OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Button <>4__this; //Field offset: 0x10
		private float <fadeTime>5__2; //Field offset: 0x14
		private float <elapsedTime>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 374
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <OnFinishSubmit>d__9(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class ButtonClickedEvent : UnityEvent
	{

		public ButtonClickedEvent() { }

	}

	private ButtonClickedEvent m_OnClick; //Field offset: 0xA4

	public ButtonClickedEvent onClick
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	protected Button() { }

	public ButtonClickedEvent get_onClick() { }

	private IEnumerator OnFinishSubmit() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnSubmit(BaseEventData eventData) { }

	private void Press() { }

	public void set_onClick(ButtonClickedEvent value) { }

}

