# ☕ MiniSmartPOS

A lightweight Cafe Point-of-Sale (POS) desktop application built with **C# WinForms** to demonstrate clean UI component design, event-driven programming, and custom delegates.

![MiniSmartPOS Screenshot](Screenshot 2026-11-25 165905.png)

## ✨ Features
- **Reusable Product Cards:** Custom `UserControl` (`ctrProductCard`) supporting design-time properties (`ItemName`, `UnitPrice`) and quantity selection.
- **Smart Cart Management:** Automatically merges duplicate items by updating quantities and recalculating totals in real time using `List<OrderItem>`.
- **Flexible Discount System:** Supports dynamic pricing tiers (**Regular 0%**, **Student 15%**, **VIP 25%**) without hardcoded `if/else` logic inside the calculator.
- **Dual Receipt Logging:** Logs every completed checkout simultaneously to the on-screen log panel and a local `receipts.txt` file.

## 🧠 Core C# / .NET Concepts Applied
- **User Controls:** Encapsulating UI and behavior into a single reusable `ctrProductCard` control.
- **Events & Custom `EventArgs`:** Decoupled Publisher-Subscriber communication (`OnItemAdded` with `OrderItemEventArgs`) between product cards and the main form.
- **Custom Delegates:** Strategy pattern implementation (`DiscountDelegate`) inside `OrderCalculator`.
- **Multicast Delegates (`+=`):** Invoking multiple logging targets (`LogToListBox` + `LogToFile`) through a single `ReceiptLogger` call.

## 🛠️ Tech Stack
- **Language:** C#
- **Framework:** .NET Windows Forms (WinForms)
- **UI Library:** `Guna.UI2.WinForms`

## 🚀 How to Run Locally
1. Clone the repository:
   ```bash
   git clone [https://github.com/YOUR_USERNAME/MiniSmartPOS.git](https://github.com/YOUR_USERNAME/MiniSmartPOS.git)
