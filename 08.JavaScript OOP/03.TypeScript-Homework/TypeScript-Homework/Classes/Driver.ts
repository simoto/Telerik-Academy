class Driver extends Person implements IDriver {
    car: string;

    constructor(firstName, lastName, age, car) {
        super(firstName, lastName, age);
        this.car = car;
    }

    greet() {
        return "Hi, I am driver and my name is " + this.firstName + ", nice to meet you!";
    }
}  