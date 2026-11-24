# Beijing — materiais recuperados e análise

A raiz deste repositório contém agora a exportação completa do AssetRipper usada como base do projeto Unity ativo: `Assets/`, `Packages/` e `ProjectSettings/`. A exportação contém 7.980 arquivos e está marcada para Unity 2022.3.62f3, embora a origem estivesse marcada como Unity 2019.2.0f1 e o upgrade não tenha sido validado no Editor.

## Grupos

1. **Exportação AssetRipper auxiliar:** `Recovered_Assets_Reference/AssetRipper_Export/`, uma cópia/exportação anterior preservada para comparação; não é a raiz Unity ativa.
2. **TexLow — 49 PNGs:** `Recovered_Assets_Reference/TexLowPNG/`, junto com `tex_low_export_manifest.csv` e `export_tex_low.py`.
3. **Análise técnica Cpp2IL, IL2CPP e WebAssembly:** `Recovered_Analysis/Beijing_UnityWeb_Analysis/`. Inclui dumps, inventários, relatórios, intermediários e arquivos de análise preservados.
4. **Fontes C# aproximadas de ILSpy:** `Recovered_Analysis/Beijing_UnityWeb_Analysis/cpp2il-extra/ilspy-decompiled/`. Estão fora de `Assets` porque não são fontes originais validadas nem prontas para compilar.
5. **Saídas complementares:** WAT nomeado compactado em `Recovered_Analysis/Beijing_UnityWeb_Analysis/wasm/Beijing_2.named.wat.gz`; IL em `Recovered_Analysis/Beijing_UnityWeb_Analysis/cpp2il-extra/ilspy-il/`; e C# de metadados/stubs em `Recovered_Analysis/Beijing_UnityWeb_Analysis/il2cppdumper/ilspy-decompiled/`.

Os três UnityWeb binários originais e a cópia WASM extraída foram removidos da árvore de trabalho conforme solicitado. Seus blobs ainda constam no histórico Git anterior; esse histórico não foi reescrito. Permanecem os assets e dados já extraídos, além das saídas textuais de análise.

## Limitações

A exportação AssetRipper contém assets, cenas e scripts-stub; não recupera toda a lógica original dos métodos. A saída Cpp2IL/ILSpy inclui trechos incompletos e marcadores de problemas de decompilação, e o pseudocódigo WebAssembly não é C# original. Logo, o projeto ativo permite inspecionar os assets/cenas recuperados, mas a lógica de jogo não está restaurada nem a compilação foi verificada. Consulte `README.md` e `RECONSTRUCTION_STATUS.json` para o estado atual.
