# Lewee.Blazor

This package provides infrastructure components for Blazor WebAssembly applications, focusing on state management, real-time messaging, and HTTP communication.

## Dependencies

- `Microsoft.AspNetCore.Components.WebAssembly`
- [Fluxor](https://github.com/mrpmorris/Fluxor) for state management
- [Correlate](https://github.com/skwasjer/Correlate) for request correlation
- [SignalR Client](https://docs.microsoft.com/en-us/aspnet/core/signalr/dotnet-client) for real-time communication

## Features

### State Management (`/Fluxor`)
- Integration with Fluxor for Redux-style state management
- Request state handling with success/error states
- Correlation ID tracking across state changes
- Redux DevTools integration support
- Built-in request effects for handling async operations

### Real-time Messaging (`/Messaging`)
- SignalR client integration with automatic reconnection
- Message deserialization and handling
- Health monitoring for connection status
- Message-to-action mapping for state updates
- Hub connection management

### HTTP Communication (`/Http`)
- Correlation ID propagation in HTTP requests
- Standardized HTTP client configuration
- Request/response interceptors
- Error handling middleware

### Error Handling (`/ErrorHandling`)
- API exception handling
- Standardized error response format
- Error state management
- User-friendly error messages

## Integration

The package is designed to work with:
- [Lewee.Contracts](../Lewee.Contracts/README.md) for shared contracts and message types
- [Lewee.Shared](../Lewee.Shared/README.md) for shared utilities and common functionality


