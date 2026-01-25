📝 Scenario: Hasina Cabs

Hasina Cabs offers vehicles like Hatchbacks, Sedans, and SUVs. They need a software to calculate the fare based on the vehicle type, distance, and waiting time. You also need to validate the Booking ID format before calculating the fare.

⚙️ Requirements

**1\. Class** **Cab**

- **Properties (Public):**

◦ `BookingID` (string)

◦ `CabType` (string)

◦ `Distance` (double)

◦ `WaitingTime` (int)

**2\. Class** **CabDetails** **(Inherits** **Cab****)**

- **Methods:**

◦ `public bool ValidateBookingID()`

- **Logic:** The `BookingID` is valid **only** if:

1. The total length is exactly **6**.

2. It contains the character **'@'** (implied: starts with "AC", followed by '@', then 3 digits, based on the example `AC@123`). *Correction based on source:* The source says:

◦ Length should be **6**.

◦ The id should have **"AC"** before the character **'@'**.

◦ There should be **3 digits** after the character **'@'**.

- Return `true` if valid, otherwise `false`.

◦ `public double CalculateFareAmount()`

- **Formula:**  Fare=(Distance×PricePerKm)+WaitingCharge

- **Waiting Charge:**  WaitingTime =​ (Square root of Waiting Time).

- **Price Per Km:**

- **Hatchback**: 10

- **Sedan**: 20

- **SUV**: 30

- **Case Sensitivity:** Cab Type is case-sensitive (e.g., "SUV").

- **Return:** The calculated fare. (Note: The source asks to return it, but implies specific output formatting in Main).

**3\. Class** **Program**

- **Logic:**

1. Get `BookingID` from user.

2. Create a `CabDetails` object and set the ID.

3. Call `ValidateBookingID`.

- **If false:** Print `"Invalid booking id"`.

- **If true:**

- Get `CabType`, `Distance`, and `WaitingTime`.

- Call `CalculateFareAmount`.

- **Output:**  `"The fare amount is [Result]"` (Result should be formatted to 2 decimal places, e.g., 903.87).

🔍 Sample Input/Output

**Sample 1 (Valid)**

```
Enter the booking id
AC@234
Enter the cab type
SUV
Enter the distance in km
30
Enter the waiting time in minutes
15

```

**Output 1**

```
The fare amount is 903.87

```

**Sample 2 (Invalid ID)**

```
Enter the booking id
DC@123

```

**Output 2**

```
Invalid booking id
```