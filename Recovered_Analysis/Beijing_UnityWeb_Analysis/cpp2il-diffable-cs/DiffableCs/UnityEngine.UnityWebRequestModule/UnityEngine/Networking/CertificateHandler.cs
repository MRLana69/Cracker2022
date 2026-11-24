namespace UnityEngine.Networking;

public class CertificateHandler
{
	internal nint m_Ptr; //Field offset: 0x8

	public void Dispose() { }

	protected override void Finalize() { }

	private void Release() { }

	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	internal bool ValidateCertificateNative(byte[] certificateData) { }

}

