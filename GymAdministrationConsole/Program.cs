using GymAdministration.Core;

List<Student> students = new List<Student>();

students.Add(new Student("Guilherme", "0123", new DateTime(1994, 08, 11)));
students.Add(new Student("Gabriela", "4567", new DateTime(1994, 06, 06)));
students.Add(new Student("Rodrigo", "8910", new DateTime(1995, 08, 30)));
students.Add(new Student("Luis", "1112", new DateTime(1996, 07, 07)));
students.Add(new Student("Jailson", "1314", new DateTime(1997, 08, 08)));
students.Add(new Student("Henderson", "1516", new DateTime(1998, 09, 09)));
students.Add(new Student("Vasco", "1718", new DateTime(1999, 10, 10)));
students.Add(new Student("Chuca", "1920", new DateTime(2000, 11, 11)));
students.Add(new Student("Romildo", "2122", new DateTime(2001, 12, 12)));
students.Add(new Student("Jacinto", "2324", new DateTime(2002, 01, 01)));

foreach (var student in students)
{
    Console.WriteLine("Student Name: {0}, Medical Observation: {1}, Birthday Date: {2}, Status: {3}", student.Name, student.MedicalObservation, student.BirthdayDate, student.Status);
}

Employee employee = new Employee("Wilson");
Console.WriteLine("\nEmployee Name: {0}, Status: {1}", employee.Name, employee.Status);

ActivityClass activityClass = new ActivityClass("Bodybuilding", "Hypertrophy", new DateTime(2022, 10, 10));
activityClass.Employee = employee;
activityClass.Student = students;
Console.WriteLine("\nActivity Class: {0}, Description: {1}, Started Date: {2}", activityClass.Name, activityClass.Description, activityClass.StartedActivity);

Equipment equipment = new Equipment(1, "Halter", "20lbs halter", new DateTime(2022, 10, 10));
Console.WriteLine("\nEquipment Id: {0}, Equipment: {1}, Description: {2}, Acquired Date: {3}", equipment.Id, equipment.Name, equipment.Description, equipment.AcquiredDate);

List<Equipment> equipmentList = new List<Equipment>();
equipmentList.Add(new Equipment(2, "Halter 2", "30lbs halter", new DateTime(2022, 10, 10)));
equipmentList.Add(new Equipment(2, "Halter 3", "40lbs halter", new DateTime(2022, 10, 10)));
equipmentList.Add(new Equipment(2, "Halter 4", "50lbs halter", new DateTime(2022, 10, 10)));
equipmentList.Add(new Equipment(2, "Halter 5", "60lbs halter", new DateTime(2022, 10, 10)));
equipmentList.Add(new Equipment(2, "Halter 6", "70lbs halter", new DateTime(2022, 10, 10)));
equipmentList.Add(new Equipment(2, "Halter 7", "80lbs halter", new DateTime(2022, 10, 10)));
equipmentList.Add(new Equipment(2, "Halter 8", "90lbs halter", new DateTime(2022, 10, 10)));
equipmentList.Add(new Equipment(2, "Halter 9", "100lbs halter", new DateTime(2022, 10, 10)));
equipmentList.Add(new Equipment(2, "Halter 10", "110lbs halter", new DateTime(2022, 10, 10)));
equipmentList.Add(new Equipment(2, "Halter 11", "120lbs halter", new DateTime(2022, 10, 10)));

foreach (var equipmentItems in equipmentList)
{
    Console.WriteLine("Equipment Id: {0}, Equipment: {1}, Description: {2}, Acquired Date: {3}", equipmentItems.Id, equipmentItems.Name, equipmentItems.Description, equipmentItems.AcquiredDate);
}

Console.WriteLine("\n");

List<Employee> employees = new List<Employee>();
employees.Add(new Employee("Donald"));
employees.Add(new Employee("Duck"));
employees.Add(new Employee("Larissa"));
employees.Add(new Employee("Emily"));
employees.Add(new Employee("Putin"));

foreach (var employeesInsideList in employees)
{
    Console.WriteLine("Employee Name: {0}, Status: {1}", employeesInsideList.Name, employeesInsideList.Status);
}