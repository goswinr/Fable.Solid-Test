import { toConsole } from "../fable_modules/fable-library-js.4.16.0/String.js";
import { render } from "solid-js/web";
import { Hello } from "./Hello.jsx";

toConsole(`Loading ${"App.fs"}...`);

export const div = document.getElementById("solid-app-container");

render(() => <Hello></Hello>, div);

