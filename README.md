# Blood_Bank_Management_System
Blood Bank Management System

## Description
The Blood Bank Management System is a C# .NET application designed to efficiently manage blood donation and patient records in a blood bank. The system provides a user-friendly interface with different forms to handle various functionalities. This project aims to streamline the process of collecting and maintaining information related to blood donors and patients, ensuring smooth operations and effective communication between staff members.

## Features
#### Donor Form
Allows users to input donor information, including personal details, blood group, contact information, and donation history. 
Saves donor information in the donor table for future reference.
#### View Donor Form
Displays a list of all registered donors, providing search and filtering options. 
Allows users to view specific donor details, including donation history and contact information. 
Retrieves donor data from the donor table.
####Donate Form
Enables donors to submit their blood donation information, such as donation date, type, and quantity. 
Updates the donor's profile with the latest donation information.
####Patient Form
Captures patient data, including name, age, blood group, medical history, and contact information. 
Saves patient information in the patient table for future use
####View Patient Form
Presents a comprehensive list of all registered patients with search and sorting capabilities. 
Allows users to view specific patient details, facilitating easy access to medical records. 
Retrieves patient data from the patient table.
####Dashboard Form
Provides an informative overview of the blood bank's performance. 
Displays the total count of registered donors, patients, and successful blood donations. 
Helps staff assess the blood bank's status and track progress.

##How To Use
1.Clone the repository to your local machine. 
2.Open the solution file in Visual Studio. 
3.Build the project and resolve any dependencies. 
4.Set up a database connection using the provided SQL script or modify the connection string in the code to connect to an existing database. 
5.Run the application to access the main dashboard. 
6.From the dashboard, navigate through different forms (Donor, View Donor, Donate, Patient, View Patient) to manage donor and patient information.

##Database
The Blood Bank Management System utilizes a database named "BloodBankb" to store donor and patient information. The database consists of different tables, such as Donor,Patient,which store their respective data.

##Technologies Used
C#.NET
SQL server
WinForms(Windows Form)

##Contributions
Contributions to the Blood Bank Management System project are welcome. If you encounter any issues or have suggestions for improvements, feel free to submit a pull request.

##License
This project is licensed under the MIT License. You are free to use, modify, and distribute the code as per the terms of the license.
