# Ativos estáticos — Copenhagen Super Runner

Esta pasta contém quatro personagens exportados de bundles `CharacterPacks` da build WebGL fornecida, usando apenas leitura estática com UnityPy. Nenhum executável, script ou runtime dos bundles foi iniciado.

| Personagem | Mesh | Triângulos | Joints | Textura |
|---|---:|---:|---:|---|
| Snowy | 1.620 vértices | 1.944 | 26 | 256×256 RGBA |
| CaptainFlash | 1.485 vértices | 1.740 | 26 | `_MainTex` exportada |
| Valentina | 2.255 vértices | 2.655 | 26 | `_MainTex` exportada |
| Mia | 1.841 vértices | 2.300 | 26 | `_MainTex` exportada |

Cada personagem tem um arquivo Collada 1.4.1 (`*_Mesh.dae`) com geometria, UVs, normais calculadas, esqueleto, bind poses e pesos de skinning, além da respectiva textura PNG. Os pesos comprimidos da Unity foram decodificados por UnityPy e normalizados por vértice. Os nomes dos 18 ossos centrais foram remapeados para os nomes usados pelos clips do prefab de origem (por exemplo, `Root_jnt` → `jRoot`); os bones auxiliares continuam no skeleton. A diferença de hierarquia da raiz e das clavículas foi achatada preservando as transformações globais, conforme comparação estática dos rigs.

Os sidecars `.meta` usam GUIDs determinísticos, inclusive para pastas, para manter referências estáveis entre importações. A exportação e seus XMLs/pesos podem ser verificados estaticamente, mas estes arquivos **ainda não foram importados nem validados no Editor Unity**. Assim, não se afirma que os personagens já estejam selecionáveis, nem que as animações funcionem visualmente. `Characters.cs`, `CharacterModelPreviewFactory.cs` e `Merge.unity` permanecem sem alterações. A próxima etapa segura é importar e inspecionar os modelos em Unity; nenhuma compilação foi feita.
