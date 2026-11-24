# Fonte C# de referência (ILSpy sobre saída Cpp2IL)

Esta pasta contém fontes emitidas pelo ILSpy 11.2 a partir dos assemblies auxiliares de `cpp2il-extra/dll_il_recovery/`:

- `Assembly-CSharp/`: 1.827 arquivos `.cs` decompilados de `Assembly-CSharp.dll`.
- `Assembly-CSharp-firstpass/`: 32 arquivos `.cs` decompilados de `Assembly-CSharp-firstpass.dll`.

Esta não é a fonte original do jogo nem um projeto compilável/validado. O assembly de entrada é uma recuperação aproximada do Cpp2IL baseada nos dados WebAssembly. A saída inclui avisos `Cpp2ILHelpers.NoteDecompilerIssue`, valores/tipos desconhecidos e reconstruções imperfeitas de instruções; por isso ela foi guardada fora de `Assets` e não substitui os stubs AssetRipper do projeto ativo. Nenhum projeto Unity foi compilado ou testado nesta etapa.

Use os arquivos para consulta e reconstrução manual de lógica, conferindo cada método contra `cpp2il-extra/isil/`, `cpp2il-extra/wasmmappings/`, os assets/prefabs e os relatórios existentes. Não copie esta árvore diretamente para `Assets` sem resolver referências e corrigir os trechos gerados.
