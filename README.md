[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.moq.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.moq/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus.moq/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus.moq/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.moq.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.moq/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus.moq/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus.moq/actions/workflows/codeql.yml)

# Soenneker.Utils.AutoBogus.Moq

A Moq binder that lets `Soenneker.Utils.AutoBogus` create and populate interfaces and abstract classes.

## Installation

```bash
dotnet add package Soenneker.Utils.AutoBogus.Moq
```

## Usage

```csharp
var faker = new AutoFaker
{
    Binder = new MoqAutoFakerBinder()
};

IOrderService service = faker.Generate<IOrderService>();
```

Concrete types continue to use AutoBogus's default construction path. Interface and abstract-type requests are created with `Mock.Of<T>()`, then their writable members are populated by AutoBogus where the generated proxy permits it. Retain the configured `AutoFaker` when generating repeatedly so its binder and reflection caches can be reused.
