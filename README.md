# Product Catalog — C# OOP Exercise

> A console application that demonstrates object-oriented programming fundamentals in C#: inheritance, polymorphism, and method overriding through a practical product registration system.

<img width="300" height="142" alt="Image" src="https://github.com/user-attachments/assets/dbc2d510-d6b5-4400-8fdf-b93fb35dd201" />
</br>
<img width="1360" height="611" alt="Image" src="https://github.com/user-attachments/assets/a837f6d0-c44a-4203-90de-aec0d200d65e" />
---

## About the Project

This project was built as a hands-on exercise in object-oriented design. The application registers products of three different types — common, used, and imported — and prints a formatted price tag for each one. The core challenge is modeling each product type as its own class while sharing behavior through a common base.

It's a small but deliberate exercise: the code is intentionally lean, putting the focus on *how* the classes relate to each other rather than on infrastructure.

---

## How It Works

The user runs the program, enters how many products they want to register, and for each one chooses a type:

| Type | Input | Extra fields |
|---|---|---|
| Common | `c` | — |
| Used | `u` | Manufacture date |
| Imported | `i` | Customs fee |

After all entries are collected, the program prints a formatted price tag for each product. Imported products display the total price (base + customs). Used products display the manufacture date.

```
PRICE TAGS:
MacBook Pro 16"$ 15699.0 (Customs free: $ 3200.0)
Sony WH-1000XM4 (used) $ 850.0 (Manufacture date: 15/03/2021)
USB-C Hub $ 149.99
```

---

## Class Design

```
Product  (base class)
├── ImportedProduct  — adds CustomsFree, overrides PriceTag()
├── UsedProduct      — adds ManufactureDate, overrides PriceTag()
└── (common)         — uses Product directly, no subclass needed
```

The `PriceTag()` method is declared `virtual` on `Product` and overridden in each subclass. The `List<Product>` in `Ex12.cs` holds all three types polymorphically — the correct `PriceTag()` is dispatched at runtime without any type-checking.

---

## Key OOP Concepts Applied

**Inheritance** — `ImportedProduct` and `UsedProduct` both extend `Product`, reusing its `Name` and `Price` properties and the constructor chain via `: base(name, price)`.

**Polymorphism** — A single `foreach` loop iterates over `List<Product>` and calls `p.PriceTag()` on each element. The runtime resolves the right implementation depending on the actual type of each object.

**Method overriding** — Each subclass redefines `PriceTag()` with `override`, producing output specific to its type without changing the calling code.

---

## Project Structure

```
Ex12/
├── Ex12.cs                  ← Entry point and user input logic
└── Entities/
    ├── Product.cs           ← Base class
    ├── ImportedProduct.cs   ← Subclass with customs fee
    └── UsedProduct.cs       ← Subclass with manufacture date
```

---

## Running Locally

**Prerequisites:** [.NET SDK](https://dotnet.microsoft.com/download) 6.0 or later.

```bash
git clone https://github.com/your-username/product-catalog-csharp.git
cd product-catalog-csharp
dotnet run
```

---

## What I Learned

This exercise reinforced how inheritance and polymorphism allow a single collection to hold different object types and dispatch the right behavior at runtime — no `if/switch` chains, no type casting. The `virtual`/`override` mechanism in C# makes this clean and explicit.

---

## About Me

I'm a developer focused on building solid fundamentals in object-oriented and systems programming.

- LinkedIn:(www.linkedin.com/in/caio-gonçalves-4724683b7)
