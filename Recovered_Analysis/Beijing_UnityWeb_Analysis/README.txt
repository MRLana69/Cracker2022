Beijing Unity WebGL payload analysis

Inputs: Beijing_2.data.unityweb and Beijing_2.wasm.code.unityweb from the supplied local web build.
The data payload is a UnityWebData archive; its seven contained files are extracted under data-extracted/.
The WebAssembly module is preserved under wasm/ and translated to WABT .dcmp pseudocode, with module structure in wasm-structure.txt.
The .dcmp file is structured pseudocode, not original C# source and not guaranteed to compile. Native IL2CPP has lost high-level source constructs and symbol names may be limited.
This output was created locally and was not uploaded or published.
