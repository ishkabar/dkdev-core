# DKDev.Core

[![wakatime](https://wakatime.com/badge/user/c59759de-7539-43ec-bc20-5cd3aeca16e5/project/1b8623df-eab7-42a1-9744-b9ccb3f388a1.svg?style=flat-square)](https://wakatime.com/@c59759de-7539-43ec-bc20-5cd3aeca16e5/projects/twhxfhsqpd)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-12.0-239120?style=flat-square&logo=csharp)
[![NuGet](https://img.shields.io/nuget/v/DKDev.Core?style=flat-square&logo=nuget)](https://www.nuget.org/packages/DKDev.Core)
[![License](https://img.shields.io/github/license/ishkabar/dkdev-core?style=flat-square)](LICENSE)

Lightweight utilities and extensions for .NET applications. Zero dependencies.

## Installation
```bash
dotnet add package DKDev.Core
```

## Features

- **Guard Clauses** - Parameter validation helpers
- **String Extensions** - Common string operations
- **URL Validation** - HTTP/HTTPS link checking

## Usage

### Guard Clauses
```csharp
using DKDev;

public class UserService
{
    public void CreateUser(string username, string email)
    {
        Guard.NotNullOrWhiteSpace(username, nameof(username));
        Guard.NotNullOrWhiteSpace(email, nameof(email));
        
        // Your logic here
    }
}
```

### String Extensions
```csharp
using DKDev.Extensions;

string text = "  hello world  ";

if (text.HasValue())
{
    var truncated = text.Truncate(10);        // "hello w..."
    var withSlash = text.EnsureEndsWith("/"); // "  hello world  /"
}
```

### URL Validation
```csharp
using DKDev;

string url = "https://example.com";

if (LinkCheck.IsHttpUrl(url))
{
    // Valid HTTP/HTTPS URL
}
```

## API Reference

### Guard

- `NotNull<T>(T value, string paramName)` - Throws if null
- `NotNullOrEmpty(string value, string paramName)` - Throws if null/empty
- `NotNullOrWhiteSpace(string value, string paramName)` - Throws if null/empty/whitespace
- `InRange<T>(T value, string paramName, T min, T max)` - Throws if outside range

### StringExtensions

- `IsNullOrEmpty()` - Check if null or empty
- `IsNullOrWhiteSpace()` - Check if null, empty, or whitespace
- `HasValue()` - Check if has meaningful value
- `Truncate(int maxLength, string suffix = "...")` - Truncate with suffix
- `EnsureEndsWith(string suffix)` - Append suffix if missing
- `EnsureStartsWith(string prefix)` - Prepend prefix if missing

### LinkCheck

- `IsHttpUrl(string value)` - Validate HTTP/HTTPS URL

## License

MIT

## Author

Dominik Karczewski
