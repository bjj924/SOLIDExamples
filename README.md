# SOLID Examples
A List of examples for the SOLID principles in .NET

In the Solid folder we have the principles explained One-By-One in practical examples.

<h1>Theory</h1>

SOLID are the 5 letter for the this principles of programing, but they are more like a recomendation or good practices.
The 5 letters are:

- **[S – Single Responsability Principle](https://code-maze.com/single-responsibility-principle/)**
- **[O – Open/Closed Principle](https://code-maze.com/open-closed-principle/)**
- **[L – Liskov Substitution Principle](https://code-maze.com/liskov-substitution-principle/)**
- **[I – Interface Segregation Principle](https://code-maze.com/interface-segregation-principle/)**
- **[D – Dependency Inversion Principle](https://code-maze.com/dependency-inversion-principle/)**

(links to code maze)

In the practice, the principles are useful to the code scalability and as time pass we don't have to change all the code from 0.
Now let's start with the theory behind each principle.

## **Single Responsibility Principle**

The first SOLID principle, Single Responsibility, establishes that every class has to have one and only one responsibility.

But, why does it have to have one responsibility? 

Imagine the scenery in which our code has a class that does and manages multiple tasks and we have to change it, this will cause the class to become difficult to maintain in time because it starts to grow a lot in functionality, and this causes confusion in the code because of how large it became.

### Profits

- The code becomes less complex and easier to read, therefore it also becomes maintainable.
- It allows us to reuse the project logic if our class works well.
- Methods in the code become consistent.
- Our classes become less dependent on others.

## **Open Closed Principle**

The second SOLID principle, Single Responsibility, establishes that every class or method should be open for extension and closed for modifications.

But, what does this mean? 

It means that we have to strive to write code that doesn't require modifications every time that the client changes the request. 
Give a solution in with we can extend the behavior of a class (by the client's additional request) and don't change the class itself, only the behavior. This should be our goal most of the time.

### Why we should implement the OCP?

Because basically with the OCP we reduce the possibilities that our project has bugs, but we have to be cautious while implementing the principle. And why is that? Because sometimes is impossible to extend a class more than what we already had and the thing that we end up doing is only changing the existing functionalities.
