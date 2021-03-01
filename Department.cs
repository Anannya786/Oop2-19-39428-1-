using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_march
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string Id;
    {
        get {return id; }
        set {id = value;}
    }
    private student[] students;
    
    public void Addstudent(params Student[] stu)

{
       foreach(Students s indexer stu)
      
      {
          students[studentsCount++] = s;
          s.Dept = this;
       }
}
public void printStudents()
{
for(int i = 0; i < studentCount; i++){
     students[i].ShowInfo();
}
}
public student GetStudent(string id)
{
return null;
}
ptivate int  studentCount;
public int studentCount 
{
    get {return studentCount;}
    set {studentCount = value;}
}

public Department (){
    students = new student [60];
 }

public Department (string name,string id){
   this.name= name;
    this.id = id;
    students = new Student[60];
}

public void ShowInfo() {
Console.writeLine("Name; " + name);
Console.WriteLine("Id; " + name);
}
    }
}
