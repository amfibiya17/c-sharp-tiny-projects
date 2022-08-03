Choose Your Own Adventure
==============

## What is this project about

In this project, I used:
- Logic and conditional statements to write a classic text-based Choose Your Own Adventure Game.  
Depending on what choices the user makes, the program will have a different result.  
- The command Console.Write() to give instructions to the user, then Console.ReadLine() to get input from the user and then save that input to a variable named name.  
- Interpolate the value of that variable in a message I print to the console using Console.WriteLine(). 

I used these commands frequently throughout the project, to make sure I am comfortable with them before moving forward with C#.


---

## Steps:

- Print the sentences to the console
- Use Console.Write() to inform the user that they should type YES or NO
- Save the user’s input to a string variable named noiseChoice
- Write an if statement that checks to see if a user writes NO
- Write an else if statement that checks to see if a user writes YES
- Save their response to a variable named doorChoice, make sure to change the value of doorChoice to uppercase
- Write an if statement for if a user chooses KNOCK and an else if statement for if they choose OPEN
- Using Console.Write(), tell the user to answer the riddle
- Return to the else if statement that checks to see if doorChoice is equal to OPEN, if the condition is true, have it print the text to the console
- Using Console.Write(), get the user to give a number for the key they want to use nad save their response to a string variable named keyChoice
- Write a switch statement that checks to see if a value is equal to either "1", "2", or "3"
- For each case, print out something to the console to finish the story
- Modify the story and the code to create your very own Choose Your Adventure

---

## Examples of usage:

![screen1](https://i.postimg.cc/bJRnX9YW/Screenshot-2022-08-03-at-14-21-26.png)  

![screen2](https://i.postimg.cc/HWZJQxrw/Screenshot-2022-08-03-at-14-22-02.png)  

![screen3](https://i.postimg.cc/FKNst5fF/Screenshot-2022-08-03-at-14-22-38.png)  

![screen4](https://i.postimg.cc/85n1r7Zs/Screenshot-2022-08-03-at-14-23-06.png)

![screen5](https://i.postimg.cc/T2LyJxgB/Screenshot-2022-08-03-at-14-24-29.png)  

![screen6](https://i.postimg.cc/8k65rHVS/Screenshot-2022-08-03-at-14-25-43.png)    


---

## How to install the program

- Clone this repository 

```
git clone https://github.com/amfibiya17/c-sharp-tyny-projects.git
```

---

## How to run the program

```
cd 5.ChooseYourOwnAdventure
dotnet run
```

---