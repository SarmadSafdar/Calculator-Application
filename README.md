# Calculator Application

**Author:** Sarmad Safdar

---

## Project Description

This Calculator Application is a user-friendly Windows Forms app developed in C# that replicates the core functions of a traditional calculator. It supports basic arithmetic operations, memory functions, decimal precision, continuous operations, and includes error handling for common issues like division by zero.

### Features

- **Basic Arithmetic:** Addition, subtraction, multiplication, division, and square root calculations.
- **Memory Functions:** Store, recall, add to, subtract from, and clear a single memory value.
- **Decimal Precision:** Input and calculate with decimal numbers.
- **Continuous Operations:** Chain multiple calculations without restarting.
- **Error Handling:** Gracefully handles errors such as division by zero by showing error messages.

---

## How It Works

- **Input Processing:** Numeric and decimal buttons allow users to enter numbers precisely. Only one decimal point is allowed per number.
- **Operation Execution:** Selecting an arithmetic operation stores the current number and waits for the next operand. Pressing equals (`=`) computes and displays the result.
- **Memory Management:**  
  - `M+`: Adds the current display number to memory.  
  - `M-`: Subtracts the current display number from memory.  
  - `MR`: Recalls the stored memory number to the display.  
  - `MC`: Clears the memory.
- **Result Display:** Shows calculation results, ready for further use or new operations.
- **Error Handling:** Displays error messages like “Error” when invalid operations occur (e.g., division by zero), with an option to clear and restart.

---

## User Guide

### Starting a Calculation

1. Launch the calculator application.
2. Click numeric buttons to input the first number.
3. Use the decimal (`.`) button once to input decimal numbers.

### Performing Operations

1. After entering the first number, click an operation button (`+`, `-`, `*`, `/`).
2. Enter the second number.
3. Click the equals (`=`) button to see the result.

### Using Memory Functions

- **Store/Add to Memory:** Click `M+` to add the current display number to memory.
- **Subtract from Memory:** Click `M-` to subtract the current display number from memory.
- **Recall Memory:** Click `MR` to display the stored memory value.
- **Clear Memory:** Click `MC` to reset the stored memory.

### Continuing Calculations

- Start a new calculation by entering a new number.
- Use the current result by clicking an operation button.
- Clear the display with `C` to reset and start fresh.

### Special Operations

- To calculate the square root, enter a number and click the `√` button.

### Error Handling

- If an invalid operation occurs (e.g., division by zero), an error message appears.
- Clear errors with the `C` button to continue calculations.

---

## How to Run

- Open the solution/project file in Visual Studio.
- Build and run the application.
- Use the graphical interface to perform calculations as described above.

---

## Technologies Used

- C#  
- Windows Forms (WinForms)  

---

Thank you for using this Calculator Application! For questions or suggestions, please contact Sarmad Safdar.

