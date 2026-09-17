---
name: verify
description: Build, launch, and drive this Blazor WASM examples app in a headless browser to verify demo pages end-to-end.
---

# Verifying demo pages in this repo

Standalone Blazor WebAssembly app — everything renders client-side, so `curl` on a route only returns `index.html`. Real verification needs a browser.

## Build & launch

```bash
cd IgniteUI.Blazor.Lite.Examples/IgniteUI.Blazor.Lite.Examples/IgniteUI.Blazor.Lite.Examples.Client
dotnet build          # expect 0 warnings, 0 errors
dotnet run --no-build # serves at http://localhost:5214/ (launchSettings.json)
```

Run `dotnet run` in the background; the server prints `App url: http://localhost:5214/` when ready. Restart it after every rebuild — it serves the built output.

## Drive with Playwright

No Playwright browsers are downloaded on this machine, but Edge is installed — use `playwright-core` with `channel: 'msedge'`:

```js
const { chromium } = require('playwright-core'); // npm i playwright-core in a scratch dir
const browser = await chromium.launch({ channel: 'msedge', headless: true });
```

Wait for the WASM boot: `page.waitForSelector('igc-<component>')` plus ~1-2s settle. Collect `page.on('pageerror')` and console errors — interop failures only surface there.

## Gotchas

- The Igb* Blazor wrappers render `igc-*` custom elements (e.g. `IgbChat` → `<igc-chat>`). Playwright CSS pierces shadow DOM, so `igc-chat [part~="send-button"]` works.
- The chat input is a nested custom element: fill `igc-chat igc-textarea textarea`, not `[part~="text-input"]` (that resolves to the `igc-textarea` host, which isn't fillable).
- The nav drawer occupies the left ~270px; element x-coordinates on demo pages start after it.
- The Blazor chat wrapper manages message state externally: demos must append `args.Detail` to `Messages` in `MessageCreated` AND reset `DraftMessage` to an empty draft, or the input keeps its text after send.
