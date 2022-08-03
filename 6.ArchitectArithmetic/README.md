Architect Arithmetic
==============

## What is this project about

In this project, I used methods to build a program that calculates the material cost for any architect’s floor plan. For example, the floor plan of the Pantheon in Rome, Italy:

![screen1](https://i.postimg.cc/JhyND2cL/Screenshot-2022-08-03-at-14-44-26.png)  

…can be (approximately) broken into circles and rectangles:  

![screen2](https://i.postimg.cc/cHynK4LR/Screenshot-2022-08-03-at-14-44-36.png)  

Using basic formulas, user can calculate the area of each shape and find the total:  

```
double totalArea = Circle(21.5) + Rect(15, 18);
```  

And then multiply the total area by the cost of each unit of flooring material:  

```
double tileCost = 1; // <- let’s assume that tiles cost ₤1 each
double totalCost = totalArea * tileCost;
```

---

## Examples of usage:

![screen1](https://i.postimg.cc/mkx1Vhbr/Screenshot-2022-08-03-at-17-27-13.png)  

![screen2](https://i.postimg.cc/Y0kYMjTs/Screenshot-2022-08-03-at-17-47-16.png)  

![screen3](https://i.postimg.cc/QtgjGMQC/Screenshot-2022-08-03-at-17-27-27.png)  

![screen4](https://i.postimg.cc/VvDrwgqJ/Screenshot-2022-08-03-at-17-49-18.png)  

![screen5](https://i.postimg.cc/50JM3MhV/Screenshot-2022-08-03-at-17-31-32.png)   

![screen5](https://i.postimg.cc/Njy9h150/Screenshot-2022-08-03-at-17-49-32.png)   


---

## How to install the program

- Clone this repository 

```
git clone https://github.com/amfibiya17/c-sharp-tyny-projects.git
```

---

## How to run the program

```
cd 6.ArchitectArithmetic
dotnet run
```

---