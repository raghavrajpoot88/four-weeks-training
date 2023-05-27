interface Person{
    firstName:string;
    lastName:string;
    age:number;
}
const p1:Person={
    firstName:"Raghav",
    lastName:"Rajpoot",
    age:21
};
function introduce(p1:Person){
    let intro:string=p1.firstName +" "+p1.lastName +" is "+p1.age+" years old. ";
    console.log(intro);
    
}
introduce(p1);