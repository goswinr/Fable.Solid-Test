module Main

open Fable.Core
open Browser

printfn $"Loading {__SOURCE_FILE__}..."


Solid.render(Hello.Hello, document.getElementById("root"))