var arr = [
    { id: 1, name: 'Vasya', group: 10 },
    { id: 2, name: 'Ivan', group: 11 },
    { id: 3, name: 'Masha', group: 12 },
    { id: 4, name: 'Petya', group: 10 },
    { id: 5, name: 'Kira', group: 11 },
];
console.log(arr);
var car = {};
console.log(car);
car.manufacturer = "manufacturer";
car.model = "model";
console.log(car);
////////3/////////
var car1 = {};
car1.manufacturer = "manufacturer";
car1.model = "model";
var car2 = {};
car2.manufacturer = "manufacturer";
car2.model = "model";
var arrayCars = [{
        cars: [car1, car2]
    }];
var group = {
    students: [
        { id: 1, name: 'Dmitry', group: 5, marks: [{ subject: 'OOP', mark: 7, done: 'yes' }, { subject: 'TRPI', mark: 3, done: 'no' }] },
        { id: 2, name: 'Rodion', group: 5, marks: [{ subject: 'OOP', mark: 4, done: 'yes' }, { subject: 'BD', mark: 8, done: 'yes' }] },
        { id: 3, name: 'Vladislav', group: 5, marks: [{ subject: 'OOP', mark: 3, done: 'no' }, { subject: 'TRPI', mark: 1, done: 'no' }] },
        { id: 4, name: 'Vadim', group: 6, marks: [{ subject: 'TPVI', mark: 7, done: 'yes' }, { subject: 'TRPI', mark: 5, done: 'yes' }] },
        { id: 5, name: 'Ilya', group: 4, marks: [{ subject: 'KPO', mark: 7, done: 'yes' }, { subject: 'AISD', mark: 8, done: 'yes' }] }
    ],
    studentsFilter: function (group) {
        return this.students.filter(function (student) { return student.group === group; });
    },
    marksFilter: function (mark) {
        return this.students.filter(function (student) { return student.marks.some(function (m) { return m.mark === mark; }); });
    },
    deleteStudent: function (id) {
        var index = this.students.findIndex(function (student) { return student.id === id; });
        if (index !== -1) {
            this.students.splice(index, 1);
        }
    },
    mark: 7,
    group: 5
};
function string_students(students) {
    for (var _i = 0, students_1 = students; _i < students_1.length; _i++) {
        var student = students_1[_i];
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
