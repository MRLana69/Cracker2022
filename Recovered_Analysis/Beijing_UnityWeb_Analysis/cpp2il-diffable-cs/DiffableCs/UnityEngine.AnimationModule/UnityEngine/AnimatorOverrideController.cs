namespace UnityEngine;

public class AnimatorOverrideController : RuntimeAnimatorController
{
	internal delegate OnOverrideControllerDirtyCallback
	{

		public OnOverrideControllerDirtyCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; //Field offset: 0xC

	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

