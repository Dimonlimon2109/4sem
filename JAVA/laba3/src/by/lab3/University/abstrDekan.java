package by.lab3.University;

import by.lab3.Student.Student;

import java.util.List;

public abstract class abstrDekan {
    abstract void countStudents();
    abstract List<Student> findByPerfomance(int course, float perfomance);

    abstract List<Student> sortStudents();
}
