# Beijing Runner Reconstruction — Unity 2022.3.0f1

Projeto independente de endless runner com três faixas, movimento por teclado/toque, pulo, deslize, moedas, obstáculos, pontuação, aumento progressivo de velocidade e reinício. Não é restauração byte a byte do jogo original nem build oficial.

## Abrir e compilar

1. Abra a raiz deste repositório no Unity Editor **2022.3.0f1** (ou outro patch da linha 2022.3) e aguarde a resolução de pacotes/importação. Na primeira abertura, o Editor pode atualizar metadados e configurações do projeto.
2. Abra `Assets/BeijingReconstruction/Scenes/BeijingRunner.unity`; ela está habilitada em `ProjectSettings/EditorBuildSettings.asset`.
3. Para WebGL, instale WebGL Build Support para a mesma versão do Editor, selecione **File → Build Settings → WebGL → Switch Platform**, confirme `BeijingRunner` em Scenes In Build e use **Build**. O projeto seleciona explicitamente o template interno `APPLICATION:Default`.

`ProjectSettings/ProjectVersion.txt` define a versão-alvo como Unity 2022.3.0f1; o ZIP recebido foi gerado usando Unity 2022.3.62f3. Os controles usam a API legada `UnityEngine.Input`, fornecida pelo próprio Unity; ela não requer uma dependência UPM separada. `Packages/manifest.json` contém os módulos Built-in válidos do projeto. Não há dependências de terceiros. Os artefatos WebGL foram gerados, mas ainda não foram validados em execução no navegador.

O log anterior do Unity Build Automation (Unity 2022.3.62f3, macOS) não mostrou erros C# e falhou no pós-processamento WebGL. O ZIP recebido depois contém os artefatos completos de uma build WebGL, então os arquivos do player foram gerados; a execução do jogo no navegador ainda precisa ser validada.

## Servir a build WebGL localmente

Extraia o ZIP da build e rode `python3 Tools/serve_webgl.py /caminho/para/beijing`, trocando o caminho pela pasta que contém `index.html` e `Build/`. Abra `http://127.0.0.1:8000/` no navegador. Esse servidor envia `Content-Encoding: br` para os arquivos Brotli `.br`, necessário para o loader interpretar os arquivos WebGL; abrir o HTML diretamente por `file://` ou usar um servidor sem esse cabeçalho pode causar erro no carregamento. Para acessar a partir de outro dispositivo na mesma rede, inicie com `--host 0.0.0.0` e use o endereço IP local do computador. Não exponha o servidor à internet.

## Materiais recuperados

Os assets do AssetRipper, os PNGs TexLow e os dados de análise estão sob `Recovered_Assets_Reference/` e `Recovered_Analysis/`, fora da pasta raiz especial `Assets` do Unity. Permanecem acessíveis no repositório, mas não são importados automaticamente nem fazem parte do protótipo ativo. Por isso o `beijing.data.br` da build atual tem apenas cerca de 655 KB comprimido (cerca de 2,70 MB descomprimido); essa pequena dimensão é esperada para o protótipo atual e não indica, por si só, arquivo truncado. Veja [RECOVERED_ARTIFACTS.md](RECOVERED_ARTIFACTS.md) para inventário, localização e limitações dos dados recuperados.
