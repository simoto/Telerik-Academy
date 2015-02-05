class Employee extends Person implements IEmployee {
    profession: string;
    salary: number;

    constructor(firstName, lastName, age, profession, salary) {
        super(firstName, lastName, age);
        this.profession = profession;
        this.salary = salary;
    }

    greet() {
        return "Hi, my name is " + this.firstName + ", nice to meet you!";
    }
}  