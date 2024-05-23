# SOLID Principles in C# .NET Core

## Overview
This repository provides an implementation of the SOLID principles using C# and .NET Core. SOLID is a set of five design principles intended to make software designs more understandable, flexible, and maintainable.

## SOLID Principles
- **S**ingle Responsibility Principle (SRP)
- **O**pen/Closed Principle (OCP)
- **L**iskov Substitution Principle (LSP)
- **I**nterface Segregation Principle (ISP)
- **D**ependency Inversion Principle (DIP)

## Features
- **Single Responsibility Principle**
  - Each class has one, and only one, reason to change.
- **Open/Closed Principle**
  - Software entities should be open for extension but closed for modification.
- **Liskov Substitution Principle**
  - Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.
- **Interface Segregation Principle**
  - No client should be forced to depend on methods it does not use.
- **Dependency Inversion Principle**
  - High-level modules should not depend on low-level modules. Both should depend on abstractions.

## Technologies Used
- **Backend**: .NET Core
- **Language**: C#
- **Design Patterns**: Various patterns to demonstrate each SOLID principle

## Project Structure

```plaintext
src/
├── SOLIDPrinciples
│   ├── Controllers
│   ├── Models
│   ├── Repositories
│   ├── Services
│   └── ...
