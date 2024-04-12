module Main

open Fable.Core

printfn $"Loading {__SOURCE_FILE__}..."


let div = Browser.Dom.document.getElementById("solid-app-container")
Solid.render(Hello.Hello, div)