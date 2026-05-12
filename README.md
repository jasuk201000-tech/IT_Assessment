# IT_Assessment_2 — Amane Boutique POS

## How to open this project

1. Extract this entire folder anywhere on your computer.
   Recommended: `C:\Users\<you>\source\repos\IT_Assessment_2\`

2. Double-click `IT_Assessment_2.csproj` — Visual Studio will open it.

3. In Visual Studio:
   - **Build → Rebuild Solution** (Ctrl+Shift+B)
   - **Debug → Start Without Debugging** (Ctrl+F5) or press F5

## Test logins

Password login:
- Username: `amane` | Password: `Admin@2026` (Admin)
- Username: `mwilliams` | Password: `Cashier01!` (Cashier)

PIN login:
- `1234` — Amane Tanaka (Admin)
- `1111` — Mia Williams (Cashier)
- `5678` — Sophie Chen (Manager)

## Project structure

```
IT_Assessment_2/
├── IT_Assessment_2.csproj   ← open this in Visual Studio
├── App.config
├── Program.cs               ← entry point
├── Properties/
│   └── AssemblyInfo.cs
├── CSVs/                    ← data + helper
│   ├── CsvHelper.cs
│   ├── staff.csv
│   ├── products.csv
│   ├── variants.csv
│   ├── categories.csv
│   ├── orders.csv
│   └── order_items.csv
├── Forms/                   ← all forms & user controls
│   ├── LoginForm.cs + .Designer.cs + .resx
│   ├── PasswordControl1.cs + .Designer.cs + .resx
│   ├── PINControl1.cs + .Designer.cs + .resx
│   ├── DashboardForm1.cs + .Designer.cs + .resx
│   ├── BuildOrderForm.cs + .Designer.cs + .resx
│   ├── ProductCardControl.cs + .Designer.cs + .resx
│   └── OrderLineItemControl.cs + .Designer.cs + .resx
├── Helpers/
│   ├── Paths.cs
│   ├── SessionManager.cs
│   └── AmaneStyling.cs
└── Models/
    └── UserRole.cs
```

## Build target

.NET Framework 4.7.2. Make sure that's installed
(it's standard with Visual Studio 2019/2022 — usually pre-installed).

## If the CSVs aren't found at runtime

Each `.csv` should already be set to "Copy to Output Directory: Preserve newest"
via the `.csproj`. If you get a "file not found" popup, do:

1. Select all `.csv` files in `CSVs/` in Solution Explorer
2. F4 (Properties)
3. Confirm "Copy to Output Directory" = "Copy if newer"
4. Rebuild
