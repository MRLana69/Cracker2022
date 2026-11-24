# Beijing Runner Reconstruction — Unity 2019.2.0f1

Projeto independente de endless runner com três faixas, movimento por teclado/toque, pulo, deslize, moedas, obstáculos, pontuação, aumento progressivo de velocidade e reinício. Não é restauração byte a byte do jogo original nem build oficial.

## Abrir e compilar

1. Abra a raiz deste repositório no Unity Editor **2019.2.0f1** e aguarde a resolução de pacotes/importação.
2. Abra `Assets/BeijingReconstruction/Scenes/BeijingRunner.unity`; ela está habilitada em `ProjectSettings/EditorBuildSettings.asset`.
3. Para WebGL, instale WebGL Build Support para a mesma versão do Editor, selecione **File → Build Settings → WebGL → Switch Platform**, confirme `BeijingRunner` em Scenes In Build e use **Build**.

`Packages/manifest.json` declara os módulos Unity Built-in, incluindo `com.unity.modules.inputlegacy` 1.0.0 para os controles. Não há dependências de terceiros. O projeto foi preparado e verificado estaticamente, mas **ainda não foi importado nem compilado no Unity Editor**; compile e teste no Editor antes de considerar a build pronta.

## Materiais recuperados

Os assets do AssetRipper, os PNGs TexLow e os dados de análise estão sob `Recovered_Assets_Reference/` e `Recovered_Analysis/`, fora da pasta raiz especial `Assets` do Unity. Permanecem acessíveis no repositório, mas não são importados automaticamente nem fazem parte do protótipo ativo. Veja [RECOVERED_ARTIFACTS.md](RECOVERED_ARTIFACTS.md) para inventário, localização e limitações dos dados recuperados.
