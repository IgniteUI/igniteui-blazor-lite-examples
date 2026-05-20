# Ignite UI Blazor Lite Examples

Standalone component demos for [IgniteUI.Blazor.Lite](https://www.nuget.org/packages/IgniteUI.Blazor.Lite) and [IgniteUI.Blazor.GridLite](https://www.nuget.org/packages/IgniteUI.Blazor.GridLite) — lightweight, MIT-licensed UI components for Blazor.

This project is structured as one component demo per page, intended for use as a macro-benchmark target to measure WASM runtime performance and download size.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Getting Started

```bash
cd IgniteUI.Blazor.Lite.Examples/IgniteUI.Blazor.Lite.Examples/IgniteUI.Blazor.Lite.Examples
dotnet run
```

## Project Structure

```
IgniteUI.Blazor.Lite.Examples/
├── IgniteUI.Blazor.Lite.Examples/        # Server project (hosts the app)
│   └── Components/
│       ├── Layout/                        # NavMenu, MainLayout
│       └── Pages/                         # Home, Error, NotFound
└── IgniteUI.Blazor.Lite.Examples.Client/  # WebAssembly client project
    └── Pages/                             # All component demo pages
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