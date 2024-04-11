module Main

open Fable.Core
open Browser

printfn $"Loading {__SOURCE_FILE__}..."

[<JSX.Component>]
let App() =
    JSX.html $"""
    <h1>Hello, Solid !!</h1>
    """

let div = document.getElementById("solid-app-container")
Solid.render(App, div)