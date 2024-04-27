# Frank.Blazor.Mermaid

This is a Blazor component that renders Mermaid diagrams. It is based on the [mermaid](https://mermaid-js.github.
io/mermaid/#/) library. The component is written in C# and uses the `IJSRuntime` to call the JavaScript functions of the 
mermaid library. The component is a Razor class library and can be used in any Blazor project.

## Installation

You can install the package via NuGet. 

```bash
dotnet add package Frank.Blazor.Mermaid
```

## Usage

Add the following using statement to your _Imports.razor:

```csharp
@using Frank.Blazor.Mermaid
```

Add the following script tag to your index.html or _Host.cshtml:

```html
<script src="_content/Frank.Blazor.Mermaid/mermaid.min.js"></script>
```

Add the following tag to your component:

```html
<Mermaid Diagram="@_diagram" />
```

Add the following code to your component:

```csharp
@code {
    private string _diagram = "graph TD\nA[Christmas] -->|Get money| B(Go shopping)\nB --> C{Let me think}\nC -->|One| D[Laptop]\nC -->|Two| E[iPhone]\nC -->|Three| F[fa:fa-car Car]\n";
}
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.