INSERT INTO Patients (first_name, last_name, birth_date, gender, student_or_staff, id_number, contact_number)
VALUES
    ('Adrian', 'Villacorta', '2004-02-19', 'M', 'student', 2023135256, 9606451987),
    ('Joan', 'Dela Cruz', '1999-05-10', 'F', 'staff', 1004567890, 9212345678),
    ('Miguel', 'Santos', '2003-08-25', 'M', 'student', 2023123456, 9156781234),
    ('Lara', 'Garcia', '2002-11-30', 'F', 'student', 2023147890, 9276543210),
    ('Carlos', 'Reyes', '1985-07-15', 'M', 'staff', 1009876543, 9298765432);

INSERT INTO Doctors (first_name, last_name, email, role, contact_number, status)
VALUES
    ('Sarah', 'Lopez', 'sarah.lopez@example.com', 'doctor', 9123456789, 'available'),
    ('John', 'Smith', 'john.smith@example.com', 'nurse', 9134567890, 'unavailable'),
    ('Emily', 'Tan', 'emily.tan@example.com', 'doctor', 9145678901, 'available'),
    ('Michael', 'Chua', 'michael.chua@example.com', 'nurse', 9156789012, 'available'),
    ('Laura', 'Reyes', 'laura.reyes@example.com', 'doctor', 9167890123, 'unavailable');

CREATE TABLE Doctors (
    doctor_id int identity(1,1) not null,
    first_name varchar(50) not null,
    last_name varchar(50) not null,
    email varchar(100) not null,
    role varchar(10) not null,
    contact_number bigint not null,
    status varchar(12) not null,
    CONSTRAINT PK_DoctorID PRIMARY KEY CLUSTERED (doctor_id ASC),
    CONSTRAINT CHK_Role CHECK (role IN ('nurse', 'doctor')),
    CONSTRAINT CHK_Status CHECK (status IN ('available', 'unavailable'))
);

CREATE TABLE [dbo].[Patients] (
    [patient_id]          INT           IDENTITY (1, 1) NOT NULL,
    [first_name]          VARCHAR (50)  NOT NULL,
    [last_name]           VARCHAR (50)  NOT NULL,
    [birth_date]          DATE          NOT NULL,
    [gender]              VARCHAR (10)  NOT NULL,
    [student_or_staff]    NVARCHAR (10) NOT NULL,
    [id_number]           INT           NULL,
    [grade_or_department] VARCHAR (100) NULL,
    [contact_number]      BIGINT        NOT NULL,
    [date_registered]     DATE          DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_PatientID] PRIMARY KEY CLUSTERED ([patient_id] ASC),
    CONSTRAINT [CHK_StudentOrStaff] CHECK ([student_or_staff]='staff' OR [student_or_staff]='student')
);

