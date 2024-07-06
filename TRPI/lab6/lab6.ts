/////1//////
type id = number;
type name = string;
type group = number;
type elem = {id:id, name:string, group:number};
type array = elem[];

const arr:array = [
    {id:1, name: 'Vasya', group: 10},
    {id:2, name: 'Ivan', group: 11},
    {id:3, name: 'Masha', group: 12},
    {id:4, name: 'Petya', group: 10},
    {id:5, name: 'Kira', group: 11},
]
console.log(arr);


//////2//////////

type manufacturer = string;
type model  = string;
type CarsType = {manufacturer?: manufacturer, model?: model};
let car : CarsType = {};
console.log(car);
car.manufacturer = "manufacturer";
car.model = "model";

console.log(car);


////////3/////////

const car1: CarsType = {};
car1.manufacturer = "manufacturer";
car1.model = "model";

const car2: CarsType = {};
car2.manufacturer = "manufacturer";
car2.model = "model";

type ArrayCarsType = {cars: CarsType[]};

const arrayCars : Array<ArrayCarsType> = [{
        cars: [car1, car2]
    }];

///////////////4//////////////////

type MarkFilterType = 1 | 2 | 3 | 4 | 5| 6 | 7 | 8 | 9 | 10;
type GroupFilterType = 1 | 2 | 3 | 4 | 5| 6 | 7 | 8 | 9 | 10 | 11 | 12;
type DoneType = 'yes' | 'no';
type MarkType = {
    subject: string,
    mark: MarkFilterType,
    done: DoneType,
}
type StudentType = {
    id:number,
    name: string,
    group: GroupFilterType,
    marks: Array<MarkType>,
}

type GroupType = {
    students: Array<StudentType>,
    studentsFilter: (group: number) => Array<StudentType>,
    marksFilter: (mark: number) => Array<StudentType>,
    deleteStudent: (id: number) => void,
    mark: MarkFilterType,
    group: GroupFilterType,
}



const group : GroupType = {
    students: [
        {id: 1, name: 'Dmitry', group: 5, marks: [{subject:'OOP', mark: 7, done: 'yes'},{subject:'TRPI', mark: 3, done: 'no'}]},
        {id: 2, name: 'Rodion', group: 5, marks: [{subject:'OOP', mark: 4, done: 'yes'},{subject:'BD', mark: 8, done: 'yes'}]},
        {id: 3, name: 'Vladislav', group: 5, marks: [{subject:'OOP', mark: 3, done: 'no'},{subject:'TRPI', mark: 1, done: 'no'}]},
        {id: 4, name: 'Vadim', group: 6, marks: [{subject:'TPVI', mark: 7, done: 'yes'},{subject:'TRPI', mark: 5, done: 'yes'}]},
        {id: 5, name: 'Ilya', group: 4, marks: [{subject:'KPO', mark: 7, done: 'yes'},{subject:'AISD', mark: 8, done: 'yes'}]}
    ],
    studentsFilter (group: number): Array<StudentType> {
        return this.students.filter(student => student.group === group)
    },
    marksFilter (mark: number): Array<StudentType> {
        return this.students.filter(student => student.marks.some(m => m.mark === mark))
    },
    deleteStudent (id: number): void  {
        const index : number = this.students.findIndex(student => student.id === id);
        if(index !== -1)
        {
            this.students.splice(index, 1);
        }
    },
    mark: 7,
    group:5
}

function string_students (students: Array<StudentType>) : void
{
    for(let student of students)
    {
        console.log("ID:", student.id, "Name:", student.name, "Group:", student.group, "Marks:", student.marks);
    }
}

console.log("Изначальный список студентов:");
string_students(group.students);
console.log("Фильтр по оценке:");
string_students(group.marksFilter(group.mark));
console.log("Фильтр по группе:");
string_students(group.studentsFilter(group.group));
group.deleteStudent(2);
"Новый список студентов:";
string_students(group.students);
