function loadMermaidComponent() {
    if (window.mermaid) {
        initializeMermaid();
    } else {
        const script = document.createElement('script');
        script.type = 'text/javascript';
        script.src = '_content/Frank.Blazor.Mermaid/mermaid.min.js';
        script.onload = initializeMermaid;
        document.head.appendChild(script);
    }
}

function initializeMermaid() {
    window.mermaid.initialize({
        startOnLoad: true
    });
}

function renderMermaid(elementId, definition) {
    const element = document.getElementById(elementId);
    element.innerHTML = definition;
    window.mermaid.init();
}