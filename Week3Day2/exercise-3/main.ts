interface Person{
    firstName:string;
    lastName:string;
    age:number;
}
const p2:Person={
    firstName:"Raghav",
    lastName:"Rajpoot",
    age:21
};
function introduce(p2:Person){
    let intro:string=p2.firstName +" "+p2.lastName +" is "+p2.age+" years old. ";
    console.log(intro);
    
}
introduce(p2);