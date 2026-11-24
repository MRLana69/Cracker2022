namespace System.Threading;

internal struct ExecutionContextSwitcher
{
	internal Reader outerEC; //Field offset: 0x0
	internal bool outerECBelongsToScope; //Field offset: 0x4
	internal object hecsw; //Field offset: 0x8
	internal Thread thread; //Field offset: 0xC

	internal void Undo() { }

	internal bool UndoNoThrow() { }

}

