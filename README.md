# Frank.Blazor.Mermaid

This is a Blazor component that renders Mermaid diagrams. It is wrapper around the Blazorade.Mermaid library, which is a 
Blazor wrapper around the MermaidJS library.

This just exists because I wanted to use Mermaid diagrams in my Blazor projects, and I wanted to make the mermaid diagrams 
in between tags, and not in a separate property and then bind that property to the component.

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

Add the following tag to your component:

```html
<Mermaid>
    @_diagram
</Mermaid
```

```csharp
@code {
    private string _diagram = "graph TD\nA[Christmas] -->|Get money| B(Go shopping)\nB --> C{Let me think}\nC -->|One| D[Laptop]\nC -->|Two| E[iPhone]\nC -->|Three| F[fa:fa-car Car]\n";
}
```

or if you want write the diagram directly in the tag:

```html
<Mermaid>
    graph TD
    A[Christmas] -->|Get money| B(Go shopping)
    B --> C{Let me think}
    C -->|One| D[Laptop]
    C -->|Two| E[iPhone]
    C -->|Three| F[fa:fa-car Car]
</Mermaid
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.