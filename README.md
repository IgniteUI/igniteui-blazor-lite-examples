# Ignite UI Blazor Lite Examples

[**Live Demo on GitHub Pages**](https://igniteui.github.io/igniteui-blazor-lite-examples/)

Standalone component demos for [IgniteUI.Blazor.Lite](https://www.nuget.org/packages/IgniteUI.Blazor.Lite) and [IgniteUI.Blazor.GridLite](https://www.nuget.org/packages/IgniteUI.Blazor.GridLite) — lightweight, MIT-licensed UI components for Blazor.

This project is structured as one component demo per page, intended for use as a macro-benchmark target to measure WASM runtime performance and download size.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Getting Started

```bash
cd IgniteUI.Blazor.Lite.Examples/IgniteUI.Blazor.Lite.Examples/IgniteUI.Blazor.Lite.Examples.Client
dotnet run
```

## Deployment

The app is deployed to GitHub Pages automatically on push to `master` via the workflow in `.github/workflows/deploy.yml`.

## Project Structure

```
IgniteUI.Blazor.Lite.Examples/
└── IgniteUI.Blazor.Lite.Examples.Client/  # Standalone Blazor WebAssembly app
    ├── Layout/                            # NavMenu, MainLayout
    ├── Pages/                             # All component demo pages
    └── wwwroot/                           # Static assets & index.html
```

## Component Demos

| Category | Components |
|---|---|
| Form Controls | Input, Textarea, Combo, Select, DatePicker, DateRangePicker, Calendar, DateTimeInput, MaskInput, Checkbox, Radio, Switch, Slider, Rating |
| Layout | Tabs, Stepper, Accordion, ExpansionPanel, Navbar, NavDrawer, Tree |
| Data Display | Button, Icon, Card, Carousel, List, Avatar, Badge, Chip, Progress, Dropdown, Tooltip, Ripple, Divider |
| Feedback | Dialog, Snackbar, Toast, Banner |
| Grid | GridLite |
| Layout Managers | TileManager |

## Packages

- **IgniteUI.Blazor.Lite** — Core UI components (MIT)
- **IgniteUI.Blazor.GridLite** — Lightweight data grid (MIT)

## License

[MIT](LICENSE)