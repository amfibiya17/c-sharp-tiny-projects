Exquisite Corpse
==============

## What is this project about
Exquisite Corpse is a game, where participants draw either a head, body, or feet of a creature. The players don’t know how their part of the body connects to the other two, until the drawing is finished and revealed.

For this project, I wrote a program that mimics the Exquisite Corpse game. Using methods, I was able to randomly combine different parts of ASCII characters so they create a new creature.  

---

## Steps
- Defined nine methods: three creatures, broken up into three different parts (head, body, feet) - the user can call a combination of these methods to build various creatures
- Created one method that combines those calls for the user - that way, it can easily swap out the different creatures and quickly create lots of different character combinations
- Created a custom method that uses the built-in Random() class and it’s method - Next() to randomly assemble a body each time the program is run, then inside of RandomMode(), I created an instance of the Random() class
- Created a new custom method to store our switch statement - SwitchCase() and give it int parameters named head, body, and feet
- Inside of the SwitchCase(), I wrote three switch statements that use the parameter integer values to call the different creature methods
- In order to keep using strings, I needed to create a method that translates the meaning of our string data into ints - this method will take in a creature name and translate it to an int that SwitchCase() can make sense of and then below the SwitchCase() method, I created a new method called TranslateToNumber() that takes in creature as a string parameter
- Created a switch statement that takes in the value of creature - instead of calling a function, it is returning an integer
- Because I have a switch statement in a method, and I have a way to translate string values to int values, I deleted the switch statement in the BuildACreature() method
- Called TranslateToNumber() three times, one for each body part and saved the method calls to a set of int variables
- And finally passed the new int variables into the SwitchCase() method as arguments

---

## Examples of usage:

![screen1](https://i.postimg.cc/rsdq84Nk/Screenshot-2022-08-07-at-16-25-21.png)  

![screen2](https://i.postimg.cc/6QYKncHK/Screenshot-2022-08-07-at-16-25-42.png)  

![screen3](https://i.postimg.cc/tJVH0j9R/Screenshot-2022-08-07-at-16-26-03.png)     

![screen4](https://i.postimg.cc/zXZfJd62/Screenshot-2022-08-07-at-16-26-21.png)     

---

## How to install the program

- Clone this repository 

```
git clone https://github.com/amfibiya17/c-sharp-tyny-projects.git
```

---

## How to run the program

```
cd 7.ExquisiteCorpse
dotnet run
```

---