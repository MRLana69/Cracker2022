# Beijing — projeto recuperado para Unity 2022.3

A raiz deste repositório agora usa como projeto ativo a exportação de assets e cenas da build Beijing/Subway Surfers 1.94.0 feita pelo AssetRipper. O marcador do Editor foi atualizado para **Unity 2022.3.62f3**. Isso é uma reconstrução a partir da build compilada, não o projeto-fonte original.

## Abrir no Unity

1. Abra esta pasta raiz no Unity Editor **2022.3.62f3**.
2. Aguarde a migração de configurações e a importação dos assets. O projeto exportado originalmente indicava Unity 2019.2.0f1; o upgrade para 2022.3 ainda não foi executado nem validado pelo assistente.
3. As cenas `Assets/Scenes/LoadScene.unity` e `Assets/Scenes/Merge.unity` estão listadas nas configurações de build.

**Não compilei nem gerei uma build**, conforme solicitado. Também não posso afirmar que os scripts compilarão sem erros.

## O que foi recuperado

A exportação contém cenas, prefabs, meshes, animações, materiais, texturas, shaders, áudio, Resources e outros assets. O projeto original indicado nos dados era Subway Surfers 1.94.0, Unity 2019.2.0f1. Os relatórios da exportação estão em `Recovered_Analysis/Beijing_UnityWeb_Analysis/assetripper-export/`.

## Limitação importante da lógica C#

Os scripts sob `Assets/Scripts/` gerados pelo AssetRipper são **stubs**, não a lógica original do jogo. A saída Cpp2IL foi convertida em fontes legíveis pelo ILSpy e está separada em `Recovered_Analysis/Beijing_UnityWeb_Analysis/cpp2il-extra/ilspy-decompiled/`. Ela é aproximada e contém muitos trechos não resolvidos (`Cpp2ILHelpers.NoteDecompilerIssue`); não a coloquei em `Assets` porque não é código-fonte validado e pode não compilar. Consulte o README dessa pasta e `BUILD_REPORT.txt` para detalhes e limitações.

Portanto, esta raiz permite abrir e examinar os assets/cenas recuperados no Editor, mas **a lógica de jogo ainda não foi restaurada**. Para obter um jogo funcional, será necessário reparar/reconstruir os scripts e dependências e então compilar e testar. Não é possível prometer fidelidade exata ao original apenas com os dados recuperados.

Se posteriormente gerar uma build WebGL com Brotli, `Tools/serve_webgl.py` pode servir os arquivos `.br` localmente com o cabeçalho HTTP correto.
