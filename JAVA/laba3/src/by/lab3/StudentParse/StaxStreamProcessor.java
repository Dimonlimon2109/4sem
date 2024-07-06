package by.lab3.StudentParse;

import by.lab3.Student.Specialty;
import by.lab3.Student.Student;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

import javax.xml.stream.XMLInputFactory;
import javax.xml.stream.XMLStreamException;
import javax.xml.stream.XMLStreamReader;
import javax.xml.stream.events.XMLEvent;
import java.io.IOException;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.List;

public class StaxStreamProcessor extends DefaultHandler {
    private List<Student> students;
    private Student currentStudent;
    private StringBuilder data;

    public List<Student> getStudents() {
        return students;
    }

    @Override
    public void startDocument() throws SAXException {
        students = new ArrayList<>();
        data = new StringBuilder();
    }

    @Override
    public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
        if (qName.equalsIgnoreCase("Student")) {
            currentStudent = new Student();
        }
    }

    @Override
    public void characters(char[] ch, int start, int length) throws SAXException {
        data.append(new String(ch, start, length).trim());
    }

    @Override
    public void endElement(String uri, String localName, String qName) throws SAXException {
        if (qName.equalsIgnoreCase("Student")) {
            students.add(currentStudent);
        } else if (qName.equalsIgnoreCase("surname")) {
            currentStudent.setSurname(data.toString());
        } else if (qName.equalsIgnoreCase("specialty")) {
            currentStudent.setSpecialty(Specialty.valueOf(data.toString().toUpperCase()));
        } else if (qName.equalsIgnoreCase("isFTimeEdu")) {
            currentStudent.setIsFTimeEdu(Boolean.parseBoolean(data.toString()));
        } else if (qName.equalsIgnoreCase("course")) {
            currentStudent.setCourse(Integer.parseInt(data.toString()));
        } else if (qName.equalsIgnoreCase("perfomance")) {
            currentStudent.setPerfomance(Float.parseFloat(data.toString()));
        }
        data.setLength(0);
    }
}