# Beijing Runner Reconstruction — Unity 2022.3.0f1

Projeto independente de endless runner com três faixas, movimento por teclado/toque, pulo, deslize, moedas, obstáculos, pontuação, aumento progressivo de velocidade e reinício. Não é restauração byte a byte do jogo original nem build oficial.

## Abrir e compilar

1. Abra a raiz deste repositório no Unity Editor **2022.3.0f1** (ou outro patch da linha 2022.3) e aguarde a resolução de pacotes/importação. Na primeira abertura, o Editor pode atualizar metadados e configurações do projeto.
2. Abra `Assets/BeijingReconstruction/Scenes/BeijingRunner.unity`; ela está habilitada em `ProjectSettings/EditorBuildSettings.asset`.
3. Para WebGL, instale WebGL Build Support para a mesma versão do Editor, selecione **File → Build Settings → WebGL → Switch Platform**, confirme `BeijingRunner` em Scenes In Build e use **Build**. O projeto seleciona explicitamente o template interno `APPLICATION:Default`.

`ProjectSettings/ProjectVersion.txt` define a versão-alvo como Unity 2022.3.0f1. Os controles usam a API legada `UnityEngine.Input`, fornecida pelo próprio Unity; ela não requer uma dependência UPM separada. `Packages/manifest.json` contém os módulos Built-in válidos do projeto. Não há dependências de terceiros. O projeto ainda precisa ser aberto, importado e validado no Unity Editor 2022.3; compile e teste no Editor antes de considerar a build pronta.

O último log do Unity Build Automation (Unity 2022.3.62f3, macOS) não mostrou erros C# e chegou a gerar os dados do player, mas falhou no pós-processamento WebGL com `IndexOutOfRangeException`. O template embutido foi definido explicitamente para eliminar um possível problema de seleção ou formato do template. Uma nova execução é necessária para confirmar se isso resolve; ainda não há build WebGL validada.

## Materiais recuperados

Os assets do AssetRipper, os PNGs TexLow e os dados de análise estão sob `Recovered_Assets_Reference/` e `Recovered_Analysis/`, fora da pasta raiz especial `Assets` do Unity. Permanecem acessíveis no repositório, mas não são importados automaticamente nem fazem parte do protótipo ativo. Veja [RECOVERED_ARTIFACTS.md](RECOVERED_ARTIFACTS.md) para inventário, localização e limitações dos dados recuperados.
