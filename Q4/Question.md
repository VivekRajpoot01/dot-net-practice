Scenario: Case File Management

Sam is working with confidential case files and needs a system to **add** and **delete** files efficiently. He decides to use the `List` class to keep track of the files he is working on.

Requirements

**1\. Class** **Case**

- **Properties (Public):**

◦ `CaseNo` (int)

◦ `CaseCode` (string)

◦ `CaseContent` (string)

◦ `Date` (DateTime)

**2\. Class** **Program**

- **Static Field (Already provided in template):**

◦ `public static List<Case> CaseFile = new List<Case>();`

- **Methods:**

◦ `public static bool AddToList(Case caseObj)`

- **Logic:** Add the `caseObj` to the `CaseFile` list.

- **Return:**  `true` if added successfully (technically `List.Add` is always void, so just add it and return true).

◦ `public static bool DeleteFromList(int caseNo)`

- **Logic:** Search for the case in `CaseFile` where the `CaseNo` matches the argument `caseNo`.

- If found: Remove it from the list and return `true`.

- If not found: Return `false`.

◦ `public static void Main(string[] args)`

- **Logic:**

1. Print menu: `1\. Add to the list` and `2\. Delete from the list`.

2. Read user choice.

3. **If 1:**

◦ Read `CaseNo`, `CaseCode`, `CaseContent`, and `Date`.

◦ Create a `Case` object and populate it.

◦ Call `AddToList`.

◦ If it returns `true`, print `"Added successfully"`. Else, print `"Adding failed"`.

4. **If 2:**

◦ Read `CaseNo`.

◦ Call `DeleteFromList`.

◦ If it returns `true`, print `"Deleted successfully"`. Else, print `"Deleting failed"`.

Sample Input/Output

**Sample 1 (Add)**

```
1\. Add to the list
2. Delete from the list
Enter your choice
1
Enter the case no
150
Enter the case code
KN240
Enter the case content
Drunk and Drive
Enter the date:
12/05/2009

```

**Output 1**

```
Added successfully

```

**Sample 2 (Delete)**

```
1\. Add to the list
2. Delete from the list
Enter your choice
2
Enter the case no
150

```

**Output 2**

```
Deleted successfully
```