Password checker
==============

## What is this project about

In this project I made a program that measures the strength of any given password based on the following criteria.  
The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.

A strong password:
- is at least 8 characters long
- has lowercase letters
- has uppercase letters
- has numerical digits
- has symbols, like #, ?, !

---

I started by defining all of the standards for a password:  
`minLength` — a number with the minimum length  
`uppercase` — a string with all uppercase letters  
`lowercase` — a string with all lowercase letters  
`digits` — a string with all 10 digits  
`specialChars` — a string made of special characters

Then I captured input from the user. Asked the user to enter a password and capture their input in a variable.

I scored the user’s password: one point for each standard satisfied. Define a variable score to hold their score and set it to 0.

I used switch statement to log different messages for different scores:
- for scores of 4 and 5, the password is extremely strong
- for scores of 3, the password is strong
- for scores of 2, the password is medium
- for scores of 1, the password is weak
- if none of those match, the password doesn’t meet any of the standards

---
## Examples:

![screen1](https://i.postimg.cc/XNPzX5rb/Screenshot-2022-07-31-at-12-27-38.png)  

![screen2](https://i.postimg.cc/hGKCNb59/Screenshot-2022-07-31-at-12-28-13.png)  

![screen3](https://i.postimg.cc/5tPZ3R2H/Screenshot-2022-07-31-at-12-28-58.png)  

![screen4](https://i.postimg.cc/W1NWHwK0/Screenshot-2022-07-31-at-12-30-51.png)  

![screen5](https://i.postimg.cc/qqcwmNxm/Screenshot-2022-07-31-at-12-31-12.png)  


---

## How to install the program

- Clone this repository 

```
git clone https://github.com/amfibiya17/c-sharp-tyny-projects.git
```

---

## How to run the program

```
cd 4.PasswordChecker
dotnet run
```

---