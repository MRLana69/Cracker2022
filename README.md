# Beijing — projeto recuperado para Unity 2022.3

A raiz deste repositório agora usa como projeto ativo a exportação de assets e cenas da build Beijing/Subway Surfers 1.94.0 feita pelo AssetRipper. O marcador do Editor foi atualizado para **Unity 2022.3.62f3**. Isso é uma reconstrução a partir da build compilada, não o projeto-fonte original.

## Abrir no Unity

1. Abra esta pasta raiz no Unity Editor **2022.3.62f3**.
2. Aguarde a migração de configurações e a importação dos assets. O projeto exportado originalmente indicava Unity 2019.2.0f1; o upgrade para 2022.3 ainda não foi executado nem validado pelo assistente.
3. As cenas `Assets/Scenes/LoadScene.unity` e `Assets/Scenes/Merge.unity` estão listadas nas configurações de build.

**Não compilei nem gerei uma build**, conforme solicitado. Também não posso afirmar que os scripts compilarão sem erros.

O primeiro log do Cloud Build em Unity 2022.3.62f3 encontrou três scripts-placeholder inválidos e sem referências, exportados pelo AssetRipper. Uma varredura estática achou outros 12 stubs com identificadores inválidos e também sem referências. Os 15 foram removidos para corrigir os erros de sintaxe observados e prevenir os mesmos erros nos outros scripts. Ainda é necessário executar uma nova tentativa de build e analisar qualquer erro subsequente; esta limpeza não foi validada por compilação.

## O que foi recuperado

A exportação contém cenas, prefabs, meshes, animações, materiais, texturas, shaders, áudio, Resources e outros assets. O projeto original indicado nos dados era Subway Surfers 1.94.0, Unity 2019.2.0f1. Os relatórios da exportação estão em `Recovered_Analysis/Beijing_UnityWeb_Analysis/assetripper-export/`.

## Limitação importante da lógica C#

Os scripts sob `Assets/Scripts/` gerados pelo AssetRipper são **stubs**, não a lógica original do jogo. A saída Cpp2IL foi convertida em fontes legíveis pelo ILSpy e está separada em `Recovered_Analysis/Beijing_UnityWeb_Analysis/cpp2il-extra/ilspy-decompiled/`. Ela é aproximada e contém muitos trechos não resolvidos (`Cpp2ILHelpers.NoteDecompilerIssue`); não a coloquei em `Assets` porque não é código-fonte validado e pode não compilar. Consulte o README dessa pasta e `BUILD_REPORT.txt` para detalhes e limitações.

Portanto, esta raiz permite abrir e examinar os assets/cenas recuperados no Editor, mas **a lógica de jogo ainda não foi restaurada**. Para obter um jogo funcional, será necessário reparar/reconstruir os scripts e dependências e então compilar e testar. Não é possível prometer fidelidade exata ao original apenas com os dados recuperados.

## Resultados adicionais de análise

Foram mantidos o pseudocódigo estruturado do WABT e um WAT nomeado compactado (`Recovered_Analysis/Beijing_UnityWeb_Analysis/wasm/Beijing_2.named.wat.gz`), além de listagens IL do ILSpy e fontes C# de metadados do Il2CppDumper. Estes são níveis diferentes de representação do binário, não uma restauração completa da fonte C# original. O relatório `Recovered_Analysis/Beijing_UnityWeb_Analysis/BUILD_REPORT.txt` detalha ferramentas, caminhos e limitações.

Os três arquivos UnityWeb originais e o módulo WASM bruto foram removidos da árvore atual conforme solicitado; os derivados textuais e os assets já extraídos permanecem. **O histórico Git anterior ainda contém os blobs removidos**, pois não foi reescrito.

Se posteriormente gerar uma build WebGL com Brotli, `Tools/serve_webgl.py` pode servir os arquivos `.br` localmente com o cabeçalho HTTP correto.
