/* var: hay que inicializar la variable y no cambiara 
let: el valor de la variable puede cambiar luego y se puede dejar sin inicializar
const: no puede ser reasignado el valor porque es una constante debe ser inicializado



*/ 



// function sayHello(){
//     for(let i = 0; i<5; i++){
//         console.log(i);
//     }

//     console.log(i);
// }

// sayHello();

// const person = {
//     name: "Mosh",
//     walk(){
//         console.log(this);
//     }
// };

// person.walk();
// console.log(walk);

// if we call a function aas a method
// in an object this will always this will 
// always return a reference to that object 
// The first iteration method that we’re going to learn is 
// Preview: Docs Loops over the array, passing each item
//  in the array into the callback function provided.
// .forEach(). Aptly named, .forEach() will 
// execute the same code for each element 
// of an array.
// The code above will log a nicely formatted list of the 
// groceries to the console. Let’s explore the syntax of invoking .forEach().

// groceries.forEach() calls the forEach method on the groceries array.
// .forEach() takes an argument of callback function. Remember, a callback 
// function is a function passed as an argument into another function.
// .forEach() 
// Preview: Docs A loop is a programming tool that is used to repeat
// a set of instructions. loops  through the array and executes the
//  callback function for each element. 
//  During each execution, the current element is passed as an argument
//   to the callback function.
// The return value for .forEach() will always be undefined.


// When .map() //  is called on an array, it takes an
// argument of a callback function and returns a new array!

// == compara mayormente el contenido
// === compara el tipo de dato tambien


// function sayHello2(){
//     for ( var i = 0; i <5; i++){
//         // (en otra 0version al parecer) muestra hasta 5, porque 5 NO es mayor que 5
//         console.log(i);
//     }
// }
// sayHello2();

// var -> scoped en la funcion
// let -> defined in the block
// const -> constantes defined in block

// const x =1;
// x = 2; // no funciona porque es una constante y no puede ser cambiada

// const person = { // objeto
//     name : 'Mosh',
//     walk: function() {}, // funcion en un objeto es un metodo
//     talk() {}
// };

// person.talk();
// person['name'] = 'John'; // 2 formas diferentes de asignar valor a la variable name
// person.name = 'John;

// // const targetMember = 'name';
// // person['name'] = 'John';
// const targetMember = 'name';
// person[targetMember.value] = 'John'; 

// const person = {
//     name : "Mosh",
//     walk(){
//         console.log(this); // this no es igual en otros lenguajes
//     }
// };
// person.walk();

// const walk = person.walk.bind(person);
// walk();

// const square1 = function(number){
//     return number * number;
// }

// const test = () => { // funcion moderna
    
// }

// const square2 = number => number * number;   
//                             //si tiene una sola lnea se puede dejar en una sola 
                            // ByteLengthQueuingStrategy, quitando braces y return
                            // si tiene solo un parametro se puede dejar sin parentesis
                            // si no tiene parameytros dejar () vacio
    
// console.log(square1(5));
// console.log(square2(5));
                            
// const jobs = [ // array, menos preferible
//     {id : 1, isActive: true}, /// objeto
//     {id : 2, isActive: false},
//     {id : 3, isActive: true},
// ];
 
// const activeJobs = jobs.filter(function(job){return job.isActive;}) // retornar si el parametro es verdadero
// // const activeJobs2 = jobs.filter(job => job.isActive); // manera mas limpia *preferible para filter, foreach, map...
// const activeJob = jobs.find(job => job.id == 2); 

// console.log(activeJob);
// arrow functions don't rebind ~this~

// const person = {
//     talk(){
//         console.log('this', this); // this se refiere al contexto, esta dentro de la funcion talk
//     }
// };

// person.talk();

// const person = {
//     talk(){
//         var self = this; // con esto se puede acceder al objeto persona tambien
//         setTimeout(function() { // con esta funcion deberia llamr a la venta pero da error . Para esperar 1 segundo
//             console.log("self", self);
//         }, 1000);
//     }
// };

// person.talk();

// const colors = ['red', 'green', 'blue']; // forma antigua
// const items = colors.map(function(color){
//     return '<li>' + color + '</li>';
// });

// const colors = ['red', 'green', 'blue'];
// const item = colors.map(color => `<li>${color}</li>`); // forma preferible. // callback function
//  console.log(item);
// //.map method sirve para rendering lists

// const address = {
//     street: 'calle cuatro',
//     city: 'Santiago',
//     country: 'RD',
// };

// const street1 = address.street;   // forma uno 
// const city1 = address.city;
// const country1 = address.country;

// console.log(address.street);

// const { street, city, country } = address; // objec t *destructuring // manera de conseguir los datos de un objerto
// console.log(street); // forma preferible
// const first = [1, 2, 3];
// const second = [4, 5, 6];

// const combined = first.concat(second); // concatenacion
// console.log(combined);
// const combined2 = [...second, 'a', ...first, 'b']; // concatenacion
// console.log(combined2);

//  const clone = [...first]; // spread operator , guardar elementos internos del arreglo
//  console.log(first);
//  console.log(clone);

// const first = { name: 'Mosh'};
// const second = { job: 'Instructor'};

// const combined = {...first, ...second, location: 'Australia'}; // con el spread operator accedes directamente al operator
// console.log(combined);

// const clone = {first};

// //console.log(clone);
// console.log(clone);

// const person = {
//     name: "Mosh",
//     walk(){
//         console.log("walk");
//     }
// };

// const person2 = {
//     name: "Mosh",
//     walk(){
//         console.log("walk");
//     }
// };

//console.log(person);

// class Person {                           // para evitar poner name 2 veces
//     constructor(name){
//         this.name = name; // para llamar la variable fuera de la clase en este caso
//     }
//     walk(){
//         console.log("walk");
//     }
// }

// //  const person = new Person('Mosh');
// //  console.log(person.name);

// class Teacher extends Person { // inheritance from Person
//     constructor(name, degree){ // se hizo un constructor, hay que agregar un constructor de class Person Tambien
//         super (name);
//         this.degree = degree;
//     }
//     teach() {
//         console.log("teach");
//     }
// }

// const teacher = new Teacher('Mosh', "MSc");




