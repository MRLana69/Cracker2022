# Beijing — materiais recuperados e análise

Estes diretórios preservam os resultados recuperados da build Beijing. Ficam fora da pasta Unity `Assets` para que itens incompletos não interfiram na importação do protótipo.

## Grupos

1. **Export AssetRipper — 3.733 arquivos:** `Recovered_Assets_Reference/AssetRipper_Export/`. Inclui o payload recuperado de assets e metadados importáveis como referência.
2. **TexLow — 49 PNGs:** `Recovered_Assets_Reference/TexLowPNG/`, junto com `tex_low_export_manifest.csv` e `export_tex_low.py`.
3. **Análise técnica Cpp2IL, IL2CPP e WebAssembly:** `Recovered_Analysis/Beijing_UnityWeb_Analysis/`. Inclui dumps e saídas de ferramentas, inventários, relatórios, arquivos intermediários e entradas preservadas da análise.

## Limitações

Os resultados não equivalem ao projeto-fonte original completo. A extração AssetRipper contém referências GUID sem correspondência; a saída Cpp2IL/IL2CPP tem corpos de métodos ausentes/incompletos e o pseudocódigo WebAssembly não é C# original. Os arquivos recuperados são disponibilizados para inspeção e pesquisa; não estão conectados à cena jogável nem garantem uma compilação do jogo original.
