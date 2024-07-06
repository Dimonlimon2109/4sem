package by.lab3.University;


import by.lab3.Student.Student;
import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import java.util.*;
import java.util.stream.Collectors;

public class University {
    private String university_name;
    private ArrayList<Student> students = new ArrayList<>();

    public String getUniversity_name() {
        return university_name;
    }

    public void setUniversity_name(String university_name) {
        this.university_name = university_name;
    }

    public ArrayList<Student> getStudents() {
        return students;
    }

    public void setStudents(ArrayList<Student> students) {
        this.students = students;
    }

    public void AddStudent(Student student)
    {
     students.add(student);
    }

    public University(String university_name, ArrayList<Student> students) {
        this.university_name = university_name;
        this.students = students;
    }
    public University(String university_name) {
        this.university_name = university_name;
    }

    public University()
    {

    }

    @Override
    public String toString() {
        String result_string = "Университет: " + this.university_name + "\n";
        if(!this.students.isEmpty())
        {
            for(Student student : students)
            {
                result_string += student.toString();
            }
        }
        return result_string;
    }
    public void DeleteStudent(String surname) throws NullPointerException {
        Iterator<Student> iterator = students.iterator();
        boolean isFind = false;
        if(students.isEmpty()) {
        throw new NullPointerException("Нельзя удалить из пустого списка студентов");
        }
        while(iterator.hasNext())
        {
            Student student = iterator.next();
            if(student.getSurname().equals(surname)) {
                iterator.remove();
                isFind = true;
            }
        }
        if(!isFind)
            System.out.println("Студент с фамилией " + surname + " не найден");
    }

    @JsonIgnoreProperties
    public class Dekan extends abstrDekan
    {
        public void countStudents()
        {
            Map<Integer, Integer> courseCounting = new HashMap<>();
            for(Student student : students) {
                int course = student.getCourse();
                courseCounting.put(course, courseCounting.getOrDefault(course, 0) + 1);
            }
            for(Map.Entry<Integer, Integer> entry: courseCounting.entrySet())
            {
                System.out.println("Курс " + entry.getKey() + ": " + entry.getValue() + " студентов");
            }
        }
        public List<Student> findByPerfomance(int course, float perfomance)
        {
            ArrayList<Student> founded_students = new ArrayList<>();
            for(Student student : students)
            {
                if(student.getCourse() == course && student.getPerfomance() == perfomance)
                {
                    founded_students.add(student);
                }
            }
            if(founded_students.isEmpty())
            {
                System.out.println("Нужных студентов не найдено");
                return null;
            }
            else{
                System.out.println("Список найденных студентов:");
                for(Student student : founded_students)
                {
                    System.out.println(student.toString());
                }
                return founded_students;
            }
        }

        public List<Student> sortStudents()
        {
            return students.stream()
                    .sorted(Comparator.comparing(Student::getCourse).thenComparing(Student::getSurname))
                    .collect(Collectors.toCollection(ArrayList::new));
        }
    }
}
