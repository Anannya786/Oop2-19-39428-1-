using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_march
{
    class student
    {
        private string Name;

        public string Name
        {
            get { return name; }
            set { namespace = value;}

        }
private string id;

public string Id
{
get {return id;}
srt {id = value;}
}

private float Cgpa
{
get { return cgpa;}
set { cgpa = value;}
}
private Department dept;

 public Department Dept
{
     get {return dept; }
     set {dept = value; }
}

public student () {
}
public student (string name,string id,float cgpa){
this.name = name;
ths.id = id;
this.cgpa = cgpa;
}

public void ShowInfo(){
console.WriteLine("Name: " + name);
console.WriteLine("Id: " + id);
console.WriteLine("cgpa: " + cgpa);
}

    
public void ShowDepartmentDetails()
ShowInfo();
dept.ShowInfo();
}
}
}


