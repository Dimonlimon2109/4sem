package by.lab3.Test;

import by.lab3.Student.Specialty;
import by.lab3.Student.Student;
import by.lab3.University.University;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.junit.jupiter.api.*;
import org.testng.annotations.*;
import org.testng.annotations.Test;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.TimeUnit;

import static java.util.concurrent.TimeUnit.SECONDS;
import static org.testng.Assert.assertEquals;

public class TestClass {

    private University.Dekan dekan;
    private University university;

    @BeforeClass
    static void start(){
        System.out.println("Начало");
    }
    @AfterClass
    static void end(){
        System.out.println("Конец");
    }
    @BeforeTest
    void setupEach() {
        university = new University("TestName");
        dekan = university.new Dekan();
        university.AddStudent(new Student("Иванов", Specialty.ПОИТ, false, 1, (float)9.3));
        university.AddStudent(new Student("Петров", Specialty.ИСИТ, true, 2, (float)8.3));
        university.AddStudent(new Student("Иванов", Specialty.ПОИБМС, false, 3, (float)7.3));
    }


    @AfterTest
    void clearEach() {
        university = null;
    }

    @Disabled
    @Test
    void testFind(){
        System.out.println("Тест поиск студента по среднему баллу и курсу");
        ArrayList<Student> studentss = new ArrayList<Student>();
        studentss.add(new Student("Петров", Specialty.ИСИТ, true, 2, (float)8.3));
        Assertions.assertEquals(studentss, dekan.findByPerfomance(2, (float)8.3));
        System.out.println("Успех!");
    }

    @Timeout(value = 1000, unit = SECONDS)
    @Test
    void testSortStudents(){
        System.out.println("Тест на сортировку студентов деканом");
        Assertions.assertEquals(dekan.sortStudents(), university.getStudents());
        System.out.println("Успех!");
    }

    @Test
    void testStudent(){
        System.out.println("Тест на правильное сравнение студентов");
        Student student1 = new Student("Иванов", Specialty.ПОИТ, false, 1, (float)9.3);
        Student student2 = new Student("Иванов", Specialty.ПОИТ, false, 1, (float)9.3);
        Assertions.assertEquals(student1, student2);
        System.out.println("Успех!");
    }

    @Test
    public void testGetMyClassListFromJson() throws IOException {
        System.out.println("Тест на правильное получение списка из Json");
        ObjectMapper mapper = new ObjectMapper();
        List<Student> myClassList = mapper.readValue(new File("files/students.json"), new TypeReference<List<Student>>() {});
        assertEquals(myClassList.size(), 3);
        assertEquals(myClassList.get(0).getSurname(), "Ivanov");
        System.out.println("Успех!");
    }
}
