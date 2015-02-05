class Person implements IPerson {
    firstName: string;
    lastName: string;
    age: number;

    constructor(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    greet() {
        return "Hi, my name is " + this.firstName + ", nice to meet you!";
    }
} 