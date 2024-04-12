import { defineConfig } from 'vite'
import solidPlugin from 'vite-plugin-solid'

export default defineConfig({
    clearScreen: false,
    server: {
        watch: {
            ignored: [
                "**/*.fs" , // Don't watch F# files
                "**/*.fsx"  // Don't watch F# script files
            ]
        }
    },
    plugins: [ solidPlugin() ]



})