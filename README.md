[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.moq.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.moq/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus.moq/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus.moq/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.moq.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.moq/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus.Moq
### An AutoFakerBinder for interfaces and abstract objects using Moq

## Installation

```
dotnet add package Soenneker.Utils.AutoBogus.Moq
```

## Usage

```csharp
var faker = new AutoFaker
{
    Binder = new MoqAutoFakerBinder()
};
```