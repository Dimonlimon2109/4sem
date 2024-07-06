package by.lab3.Student;


import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import org.testng.annotations.Ignore;

import java.util.Objects;

public class Student implements Comparable<Student>, IStudent {
    private String surname;
    private Specialty specialty;

    private boolean isFTimeEdu;
    private int course;
    private float perfomance;

    public Student()
    {

    }

    public float getPerfomance() {
        return perfomance;
    }

    public void setPerfomance(float perfomance) throws IllegalArgumentException {
        if(perfomance < 0 || perfomance > 10)
            throw new IllegalArgumentException("Средний балл от 0 до 10");
        this.perfomance = perfomance;
    }

    public String getSurname() {
        return surname;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public Specialty getSpecialty() {
        return specialty;
    }

    public void setSpecialty(Specialty specialty) {
        this.specialty = specialty;
    }

    public boolean isFTimeEdu() {
        return isFTimeEdu;
    }

    public void setIsFTimeEdu(boolean FTimeEdu) {
        isFTimeEdu = FTimeEdu;
    }

    public int getCourse() {
        return course;
    }

    public void setCourse(int course) throws IllegalArgumentException {
        if(course < 1 || course > 4) {
            throw new IllegalArgumentException("Курс может быть от 1 до 4");
        }
        this.course = course;
    }

    public Student(String surname, Specialty specialty, boolean isFTimeEdu, int course, float perfomance) {
        this.surname = surname;
        this.specialty = specialty;
        this.isFTimeEdu = isFTimeEdu;
        this.course = course;
        this.perfomance = perfomance;
    }

    @Override
    public String toString() {
        return "Студент: " +
                "фамилия - '" + surname + '\'' +
                ", Специальность - " + specialty +
                ", Очная Форма? " + isFTimeEdu +
                ", Курс - " + course + ", Средний балл - " + perfomance + "\n";
    }
    public void goToUniversity() {
        System.out.println("Студент " + this.surname + " сегодня пошёл на пары");
    }

    @Override
    public boolean equals(Object obj)
    {
        if(this == obj) return true;
        if(obj == null || getClass() != obj.getClass()) return false;
        Student student =(Student) obj;
        return surname == student.surname && specialty == student.specialty && isFTimeEdu == student.isFTimeEdu && course == student.course && perfomance == student.perfomance;
    }
    @Override
    public int compareTo(Student other) {
        if (this.course != other.course) {
            return Integer.compare(this.course, other.course);
        } else {
            return this.surname.compareTo(other.surname);
        }
    }
}
