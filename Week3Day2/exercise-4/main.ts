class Car{
    make : string;
    model:string;
    year: number;
    constructor(make:string,model:string,year:number){
        this.make=make;
        this.model=model;
        this.year=year;
    }
    displayCarInfo(){
        console.log(`${this.make}${this.model}${this.year}`);
        
    }

}
const car1=new Car("Mahindra","Thar",2021);
car1.displayCarInfo();