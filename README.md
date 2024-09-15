# 🏥 Hospital Management System Database

**Cairo University | Computer Engineering Department | Fall 2021**  
Course: CMPN202 - Database Management Systems

## 📖 Project Overview

This project focuses on building a **Hospital Management System Database** that organizes, stores, and manages data related to hospital operations. The system is designed to handle different entities such as doctors, patients, nurses, rooms, operations, and more. This database ensures smooth and efficient operations within a hospital, providing features for managing appointments, staff schedules, patient reports, financial records, and more.

## 🔍 Main Features

1. **Organized Data**: The system organizes various entities like doctors, nurses, patients, equipment, rooms, and clinics.
2. **User Roles**: Different user types such as receptionists, doctors, nurses, and managers can access different functionalities of the system.
3. **Appointments and Reservations**: The system allows users to reserve doctors, tests, emergency rooms, and checkups.
4. **Comprehensive Functionality**: Includes handling staff reports, schedule management, equipment tracking, financial reporting, and more.
5. **Well-Defined ERD**: The project follows a well-structured **Entity-Relationship Diagram (ERD)** to represent the relationships between different hospital entities.

## 🏗️ System Design

### Entities in the Database:

- **Doctors**: Stores details such as names, phone numbers, working hours, specialization, and more.
- **Patients**: Records information such as name, age, address, contact information, medical history, and appointment times.
- **Nurses**: Includes nurse details like work schedules, salaries, and responsibilities.
- **Rooms**: Contains information about hospital rooms, their type, price, and availability.
- **Medicine**: Details all the medicines available in the hospital, including their price and category.
- **Operations**: Tracks the operations performed in the hospital, along with doctors, patients, and equipment involved.
- **Emergency Room**: Manages emergency cases, including the tools and equipment needed.
- **Laboratories**: Stores lab details and patient tests conducted.
- **Financial Data**: Manages hospital payments and salaries of staff.

### Users and Functionalities:

1. **Receptionist**:
   - Reserve appointments with doctors.
   - Reserve medical tests and emergency services.
   - Provide reports and receipts to patients.
2. **Doctors**:
   - Manage their work schedules.
   - Access patient appointments and write reports.
   - Handle attendance and overtime.
   - File complaints and request raises.
3. **Nurses**:
   - Organize schedules and view reports.
   - Assist doctors in handling patient care.
   - Record complaints and handle overtime.
4. **Managers**:
   - Hire doctors and nurses.
   - Approve requests and handle patient complaints.
   - Track hospital equipment and supplies.
   - Generate reports and assign raises.

## 🧩 Relationships Between Entities

- **Manages**: Links a manager to a specific department.
- **Appointment**: Connects a patient with a doctor for appointments.
- **Works For**: Represents the relationship between doctors/nurses and their departments.
- **Have**: Indicates what equipment or tools a department or room contains.
- **Reserve**: Shows reservations made by patients for rooms, operation rooms, and emergency services.
- **Take**: Tracks which medicines a patient has received during treatment.
- **Do**: Tracks medical tests conducted on patients.

## 🛠️ Tools & Technologies

- **Database Engine**: MySQL / Oracle / SQL Server
- **Programming Languages**: VC#.net, VB.net, Java (for GUI)
- **Database Design Tools**: SQL Server, MySQL Workbench, Oracle SQL Developer
- **Frontend**: Graphical User Interface (GUI) designed to interact with the database without requiring direct access to queries.

## 🔧 Project Phases

1. **Analysis Phase**:

   - Identification of requirements for the hospital system.
   - Deliverable: **Project Proposal Report**.

2. **Design Phase**:

   - Creation of an Entity-Relationship Diagram (ERD) for all entities in the hospital system.
   - Deliverable: **ER Diagram Report**.

3. **Implementation Phase**:
   - Building the hospital database using a chosen database management system.
   - Developing a user-friendly graphical interface (GUI) for different user roles.
   - Deliverable: **Final Project Delivery** with full implementation, including sample data.

## 📅 Timeline

- **Week 4**: Submit the **Project Proposal**.
- **Week 7**: Submit the **ER Diagram**.
- **Week 13**: Submit the **Final Project** (database schema, implementation, and demo).

## 📊 Evaluation Criteria

1. **System Functionality (50%)**: How well the system supports the hospital’s operations.
2. **User Support (5%)**: Ease of use for different types of users (doctors, nurses, receptionists, managers).
3. **Reporting (10%)**: Ability to generate reports on operations, finances, and hospital activity.
4. **Graphical User Interface (10%)**: Intuitive design and user experience of the hospital management system.
5. **Team Member Roles**: Each team member’s contribution is evaluated individually.

## 📝 How to Run

1. **Clone the Repository**:

   ```bash
   git clone <repository_url>
   ```

2. **Database Setup**:
   Import the provided SQL schema into your MySQL/Oracle/SQL Server database engine.

3. **Run the Application**:
   Use your preferred IDE (Visual Studio, Eclipse, etc.) to run the graphical interface:

   ```bash
   java -jar HospitalManagementSystem.jar
   ```

4. **Access the System**:
   Use the application’s GUI to interact with the hospital system by logging in as one of the defined user roles (doctor, nurse, manager, receptionist).

## 👥 Team Members

- **Kareem Ashraf Mohammed Ali**
- **Shredan Abd-Allah Kamal**
- **Omar Khalid Ali Mohammed**
- **Nada Osman Abdalaziz**

## 📧 Contact

For any questions or further information, feel free to contact us:

- Kareem: [kemokhalifa5@gmail.com](mailto:kemokhalifa5@gmail.com)
- Nada: [nadaosman20022002@gmail.com](mailto:nadaosman20022002@gmail.com)
- Omar: [omarkh200165@gmail.com](mailto:omarkh200165@gmail.com)
- Shredan: [shredanabdullah@gmail.com](mailto:shredanabdullah@gmail.com)
