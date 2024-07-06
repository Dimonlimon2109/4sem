package by.lab3.Main;
import by.lab3.Student.Specialty;
import by.lab3.Student.Student;
import by.lab3.StudentParse.StaxStreamProcessor;
import by.lab3.University.University;
import com.fasterxml.jackson.databind.JsonMappingException;
import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;
import org.apache.log4j.xml.DOMConfigurator;
import org.xml.sax.SAXException;
import com.fasterxml.jackson.databind.ObjectMapper;

import javax.xml.XMLConstants;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;
import javax.xml.transform.stream.StreamSource;
import javax.xml.validation.Schema;
import javax.xml.validation.SchemaFactory;
import javax.xml.validation.Validator;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Stream;

public class Main {

    static {
        new DOMConfigurator().doConfigure("log/log4j.xml",
                LogManager.getLoggerRepository());
    }

    private static final Logger LOG = Logger.getLogger(Main.class);

    public static void main(String[] args) {
        try {
            Student yanukovich = new Student("Янукович", Specialty.ИСИТ, false, 3, (float) 9.5);
            Student ivanov = new Student("Иванов", Specialty.ПОИТ, true, 3, (float) 4.5);
            Student Petrov = new Student("Петров", Specialty.ПОИТ, true, 1, (float) 6.5);
            LOG.info("Начало программы!");
            ivanov.goToUniversity();
            University bstu = new University("БГТУ");
            /*            bstu.DeleteStudent("Иванов");*/
            bstu.AddStudent(ivanov);
            bstu.AddStudent(Petrov);
            bstu.AddStudent(yanukovich);
            bstu.AddStudent(new Student("Смелов", Specialty.ДЭИВИ, true, 1, (float) 5));
            University.Dekan dekan = bstu.new Dekan();
            dekan.countStudents();
            dekan.findByPerfomance(3, (float) 4.5);
            dekan.sortStudents();
            System.out.println("Отсортированный список студентов:");
            for (Student student : bstu.getStudents()) {
                System.out.println(student.toString());

        }
        ////////////////////////LAB4///////////////////////////////////////////
            SchemaFactory factoryy = SchemaFactory.newInstance(XMLConstants.W3C_XML_SCHEMA_NS_URI);
            Schema schema = factoryy.newSchema(new File("D:/study/4_sem/JAVA/laba3/files/validation.xsd"));
            Validator validator = schema.newValidator(); // Создание валидатора
            validator.validate(new StreamSource(new File("D:/study/4_sem/JAVA/laba3/files/info.xml")));
            SAXParserFactory factory = SAXParserFactory.newInstance();
            SAXParser saxParser = factory.newSAXParser();

            StaxStreamProcessor handler = new StaxStreamProcessor();

            saxParser.parse("D:/study/4_sem/JAVA/laba3/files/info.xml", handler);

            List<Student> students = handler.getStudents();

            System.out.println("2345678");
            Stream stream = students.stream();
            stream.filter(x-> x.toString().length()>=0).forEach(System.out::println);

            System.out.println("//lab4//");
            for (Student student : students) {
                System.out.println(student);
            }
            /////////////////
            ObjectMapper mapper = new ObjectMapper();
            String jsonBook = mapper.writeValueAsString(bstu);
            var writer = new FileWriter("D:\\study\\4_sem\\JAVA\\laba3\\files\\serialize.json");
            writer.write(jsonBook, 0, jsonBook.length());
            writer.close();

            University university = null;
            Object obj;

            var file = new File("D:\\study\\4_sem\\JAVA\\laba3\\files\\serialize.json");
            ObjectMapper ow = new ObjectMapper();
            obj = ow.readValue(Files.readString(Path.of(file.getPath())), University.class);

            if(obj instanceof University)
            {
                System.out.println("\nДесериализация:\n");
                university = (University) obj;
                System.out.println(university.toString());

            }
            else
            {
                System.out.println("Ошибка!");
            }
            ///////////
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }
}