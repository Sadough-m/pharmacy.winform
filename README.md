Pharmacy Management System

This is a Windows Forms Application designed to help pharmacies manage their medicine inventory, receive stock, track batch numbers, store different prices, and handle insurance company tariffs.
The system supports issuing medicine to customers while selecting an insurance company and calculating the final costs.
The financial module is still under development.

🚀 Features
1. Inventory Management

Add and update medicines

Track batch numbers

Store purchase price, selling price, and insurance price

Monitor available quantity for each batch

Search medicines quickly

2. Receiving Medicine

Enter new inventory shipments

Record quantity, batch number, expiration date, and cost

Support for multiple batches of the same medicine

Automatic updating of inventory levels

3. Insurance Company Management

Add and manage insurance companies

Define each company's tariff for different medicines

Automatically apply tariff prices when selling to insured customers

4. Issuing Medicine (Factor / Invoice)

Select medicines from inventory

Automatically pick the correct batch

Apply insurance tariff when the buyer is insured

Calculate total cost, discount, and payable amount

Manage simple customer invoices

Reduce inventory quantities automatically

5. Reporting (Basic)

View inventory status

Track incoming batches

Track outgoing invoices

Basic filtering and simple reports

🧭 Workflow Example

Define Medicine

Define Insurance Companies + Tariffs

Receive Medicine with batch, price, expiry date

Sell Medicine using invoice screen

System automatically:

Selects batch

Applies insurance tariff

Calculates final cost

Updates inventory stock

🔧 Technologies Used

C# Windows Forms

.NET Framework 

SQL Server (LocalDB or full version)

 ADO.NET

📌 Current Status

Core inventory functions ✔️

Receiving medicine ✔️

Insurance companies + tariffs ✔️

Invoice system (factor) ✔️

Financial module ❗ Not completed yet

Cost analysis

Profit reporting

Insurance billing reports

Payment tracking

🛠️ Future Improvements

Complete financial accounting module

Add user roles and permissions

Add barcode scanning

Add detailed reporting system

Improve UI and workflows

Add backup/restore functionality
