CPP2IL — SAÍDAS SUPLEMENTARES
==============================

dll_il_recovery/
  Assemblies auxiliares exportadas pelo formato IL Recovery do Cpp2IL. São reconstruções aproximadas; corpos de método não recuperáveis continuam sem lógica original.

isil/
  Dump intermediário ISIL e disassembly WASM organizado por assembly/tipo. Útil para inspeção estática, não é fonte C# nem um projeto compilável.

wasmmappings/wasm_mappings.txt
  Liga métodos reconhecidos a locais/instruções do módulo WebAssembly. O log relata assinaturas/importações não associadas, portanto alguns mapas podem estar incompletos ou incorretos.

Os logs de cada execução estão ao lado destes diretórios. Os dados foram gerados em novas pastas, sem sobrescrever as saídas preexistentes. Ver ../BUILD_REPORT.txt para limitações gerais.
