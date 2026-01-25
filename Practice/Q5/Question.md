📝 Scenario: Vintage Automobile Dealership

The proprietor of a vintage automobile dealership is offering a Halloween promotion.

- **SUVs** get a **10% discount**.

- **Sedans** get a **25% discount**.

You need to create an application to calculate the final price based on the car type.

⚙️ Requirements

**1\. Class** **Owner**

- **Field:**

◦ `protected string ownerName` (Note: It is `protected`, not private).

**2\. Class** **Car** **(Inherits** **Owner****)**

- **Fields:**

◦ `internal double price` (Note: It is `internal`).

◦ `private string bodyStyle`

- **Property:**

◦ `public string BodyStyle` (Getter and Setter for the private field `bodyStyle`).

- **Methods:**

◦ `public void SetOwnerName(string name)`

- **Logic:** Assign the parameter `name` to the protected field `ownerName`.

◦ `public bool ValidateBodyStyle(string bodyStyle)`

- **Logic:** Return `true` if the `bodyStyle` is **"SUV"** or **"Sedan"**. Otherwise, return `false`.

◦ `public double CalculatePrice()`

- **Logic:**

- If `BodyStyle` is "SUV", reduce `price` by 10% (Price * 0.90).

- If `BodyStyle` is "Sedan", reduce `price` by 25% (Price * 0.75).

- Return the new price. (If invalid style, return 0 or original price, but validation happens in Main usually).

**3\. Class** **Program** **(Main Method)**

- **Logic:**

1. Read `Owner Name`.

2. Read `Car Body Style`.

3. Read `Price`.

4. Create a `Car` object.

5. Call `ValidateBodyStyle`.

- **If false:** Print `"Invalid Car Type"`.

- **If true:**

- Call `SetOwnerName` to set the name.

- Set the `BodyStyle` and `price` properties/fields.

- Call `CalculatePrice`.

- **Output:**  `"The owner [OwnerName] sells the [BodyStyle] type car for $[Result]"`

🔍 Sample Input/Output

**Sample 1 (SUV)**

```
Enter the owner name:
Sam
Enter the car body style:
SUV
Enter the price:
3000

```

**Output 1**

```
The owner Sam sells the SUV type car for $2700

```

**Sample 2 (Invalid Type)**

```
Enter the owner name:
John
Enter the car body style:
Hatchback
Enter the price:
3000

```

**Output 2**

```
Invalid Car Type
```