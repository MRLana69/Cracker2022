Beijing Unity WebGL payload analysis

The three original UnityWeb payloads (data, wasm code, framework) were removed from the current repository tree at the user's request. Their previously committed blobs remain accessible in older Git history; the history was not rewritten.
The data payload had been extracted as a UnityWebData archive; its seven contained files remain under data-extracted/.
The raw WebAssembly module was removed from the current tree after analysis. Compressed WABT named WAT remains at wasm/Beijing_2.named.wat.gz; WABT structured pseudocode remains at wasm/Beijing_2.pseudocode.dcmp, with module structure at wasm/wasm-structure.txt.
The .dcmp and .wat outputs are WebAssembly-level representations, not original C# source and not guaranteed to compile. Native IL2CPP has lost high-level source constructs and symbol names may be limited.
Additional C# approximations and IL dumps from Cpp2IL/ILSpy are recorded under cpp2il-extra/; Il2CppDumper signatures/stubs and their ILSpy view are under il2cppdumper/.
See BUILD_REPORT.txt for tool versions, output paths and known limitations. No Unity compilation was performed.
