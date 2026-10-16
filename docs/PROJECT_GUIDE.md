# InvoiceSystem domain-model prototype
## Project description
An unfinished .NET Framework console design sketch for companies, customers, projects, time/milestone billing modes and bank transactions.

**Stack:** C#, .NET Framework, Visual Studio console solution.

## Implemented code inventory
| File / folder | Role |
|---|---|
| `InvoiceSystem/Program.cs` | All interfaces, domain classes and a minimal Main method |
| `InvoiceSystem/InvoiceSystem.csproj` | Application project |
| `InvoiceSystem.sln` | Visual Studio solution |

## Architecture
~~~mermaid
flowchart LR
 User[Developer / user] --> Entry[Console entry point]
 Entry --> Logic[Company / Customer / Project]
 Logic --> Output[Placeholder billing and transaction model]
~~~

## Activity flow
~~~mermaid
sequenceDiagram
 participant U as User
 participant P as Program
 participant R as Local runtime
 U->>P: Start / choose activity
 P->>R: Perform currently implemented logic
 R-->>P: Result or error
 P-->>U: UI / output
~~~

## Installation and local setup
1. Install Visual Studio with .NET desktop development and the project's .NET Framework developer pack on Windows.
2. Open InvoiceSystem.sln, build and run the console entry point.
3. The Main method constructs Company only; no generated invoice is expected. Study Program.cs as a domain design draft.

~~~mermaid
flowchart TD
 Clone[Clone repository] --> Prep[Install correct runtime]
 Prep --> Inspect[Inspect and choose relevant example]
 Inspect --> Execute[Execute local checks]
 Execute --> Review{Pass / expected?}
 Review -->|Yes| Explore[Review output and code]
 Review -->|No| Debug[Read known limitations]
 Debug --> Inspect
~~~

## Working functionality
Company holds customers, Customer references projects and transactions, and BillingMode is implemented by TimeMode and MilesStone. Invoice generation, upload and transaction processing are placeholders.

## Validation and testing
- GitHub Actions tests documentation links and diagrams plus a Windows MSBuild compile step.
- A successful source/README check does not establish full runtime correctness; follow the manual setup steps.
- Test in a disposable environment; do not rely on fixed external services.

## Gaps and risks
- Customer.projects is not initialized before projects.Add(p) in the constructor, so constructing a Customer currently raises a runtime error.
- GenerateInvoicesForProject and FileUpload contain no working invoice/file processing.
- No billing calculation integration or automated unit tests are supplied.
- No synthetic maps or benchmark charts: the code contains no geospatial functionality or measured performance dataset.
- This documentation-only PR does not change source behavior.
