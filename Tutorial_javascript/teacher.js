import { Person } from "./person";

export class Teacher extends Person { 
    constructor(name, degree){ 
        this.degree = degree;
        
    }
    
    teach() {
        console.log("teach");
    }
}