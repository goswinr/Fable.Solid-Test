module Hello

open Fable.Core

printfn $"Loading {__SOURCE_FILE__}..."

[<JSX.Component>]
let Hello() =
    JSX.jsx $"""
    <h1>Hello, Solid !!2</h1>
    """