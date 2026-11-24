# Beijing — materiais recuperados e análise

A raiz deste repositório contém a exportação AssetRipper usada como base do projeto Unity ativo: `Assets/`, `Packages/` e `ProjectSettings/`. A exportação tem aproximadamente 7.980 arquivos e está marcada para Unity 2022.3.62f3; a origem indicava Unity 2019.2.0f1 e o upgrade ainda não foi validado no Editor.

A pasta auxiliar `Recovered_Assets_Reference/`, que continha uma cópia anterior da exportação AssetRipper e 49 texturas TexLow, foi removida da árvore atual conforme solicitado. A exportação ativa em `Assets/` e os resultados de análise em `Recovered_Analysis/Beijing_UnityWeb_Analysis/` foram preservados.

## Materiais de análise preservados

A pasta `Recovered_Analysis/Beijing_UnityWeb_Analysis/` contém os inventários, relatórios, arquivos intermediários e saídas de ferramentas AssetRipper, Cpp2IL, Il2CppDumper, ILSpy e WABT. As fontes C# aproximadas do Cpp2IL/ILSpy e as fontes derivadas dos DummyDLLs estão fora de `Assets`, pois não são código original validado nem estão prontas para compilação. Também permanecem os resultados textuais WAT e pseudocódigo WebAssembly.

Os três binários UnityWeb originais e o módulo WASM bruto foram removidos da árvore atual conforme solicitado. Os dados e assets já extraídos e as saídas derivadas permanecem. Os blobs dos arquivos removidos ainda constam no histórico Git anterior, pois o histórico não foi reescrito.

## Limitações

A exportação AssetRipper contém assets, cenas e scripts-stub; não recupera toda a lógica original dos métodos. A saída Cpp2IL/ILSpy contém trechos incompletos e marcadores de problemas de decompilação, e o pseudocódigo/WebAssembly não é C# original. O projeto permite inspecionar os assets/cenas recuperados, mas a lógica do jogo não está restaurada e a compilação não foi verificada. Consulte `README.md`, `RECONSTRUCTION_STATUS.json` e `Recovered_Analysis/Beijing_UnityWeb_Analysis/BUILD_REPORT.txt` para o estado e detalhes.
